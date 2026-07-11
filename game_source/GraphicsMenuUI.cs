using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsMenuUI : UIWindow
{
	[CompilerGenerated]
	private sealed class BIHDHGINGPF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GraphicsMenuUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public BIHDHGINGPF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GraphicsMenuUI graphicsMenuUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				graphicsMenuUI.cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
				graphicsMenuUI.cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
				graphicsMenuUI.cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class NNPEECIJCFJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GraphicsMenuUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public NNPEECIJCFJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Invalid comparison between Unknown and I4
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GraphicsMenuUI graphicsMenuUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((int)Application.platform == 1)
				{
					graphicsMenuUI.EBPPELLDGLI = Screen.currentResolution;
				}
				else
				{
					if (!Application.isEditor)
					{
						int width = Screen.width;
						int height = Screen.height;
						_ = Screen.fullScreen;
						Debug.Log((object)("Resolucion: " + width + "x" + height));
						Debug.Log((object)"Pasamos aplicación a ventana");
						_003C_003E2__current = null;
						_003C_003E1__state = 2;
						return true;
					}
					graphicsMenuUI.EBPPELLDGLI = Screen.currentResolution;
				}
				goto IL_01da;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			case 4:
			{
				_003C_003E1__state = -1;
				graphicsMenuUI.EBPPELLDGLI = Screen.currentResolution;
				((Resolution)(ref graphicsMenuUI.EBPPELLDGLI)).height = Display.main.systemHeight;
				((Resolution)(ref graphicsMenuUI.EBPPELLDGLI)).width = Display.main.systemWidth;
				float num2 = Display.main.systemWidth;
				float num3 = Display.main.systemHeight;
				graphicsMenuUI.ratioPantalla = num2 / num3;
				Debug.Log((object)("Resolucion nativa: " + ((Resolution)(ref graphicsMenuUI.EBPPELLDGLI)).width + " x " + ((Resolution)(ref graphicsMenuUI.EBPPELLDGLI)).height));
				Debug.Log((object)("Ratio pantalla: " + graphicsMenuUI.ratioPantalla));
				_003C_003E2__current = null;
				_003C_003E1__state = 5;
				return true;
			}
			case 5:
				_003C_003E1__state = -1;
				((MonoBehaviour)graphicsMenuUI).StartCoroutine(graphicsMenuUI.JAFMFLJPLAK());
				goto IL_01da;
			case 6:
				_003C_003E1__state = -1;
				graphicsMenuUI.JKKNABLEPEF();
				graphicsMenuUI.NAFGGIGOBMC();
				_003C_003E2__current = null;
				_003C_003E1__state = 7;
				return true;
			case 7:
				{
					_003C_003E1__state = -1;
					TitleScreen.BackgroundSize();
					return false;
				}
				IL_01da:
				_003C_003E2__current = null;
				_003C_003E1__state = 6;
				return true;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public Action<int, int, float> OnResolutionChange = delegate
	{
	};

	public Action OnZoomChanged = delegate
	{
	};

	private static GraphicsMenuUI IADEMLIIDPC;

	public ToggleButton tutorialEnabledToggle;

	public TextMeshProUGUI resolutionText;

	public TextMeshProUGUI zoomText;

	public TextMeshProUGUI qualityText;

	[SerializeField]
	private Button firstFocusedGameObject;

	private List<Resolution> LEBOCOLFBHL = new List<Resolution>();

	private List<Resolution> GFIGJEJLAAD = new List<Resolution>();

	private List<Resolution> GPKMBCDFIGN = new List<Resolution>();

	private List<Resolution> NFMAAJKHAKO = new List<Resolution>();

	private List<Resolution> IDOFMDDNEBD = new List<Resolution>();

	private List<Resolution> BEGOEOLCOJK = new List<Resolution>();

	private List<Resolution> OMFFFBEACMA = new List<Resolution>();

	private List<Resolution> ICOAGJNKOCB = new List<Resolution>();

	private List<Resolution> APFNFNDAKLG = new List<Resolution>();

	private List<Resolution> GLGLOILJGDB = new List<Resolution>();

	private Resolution EBPPELLDGLI;

	[HideInInspector]
	public float ratioPantalla;

	private int GDLBJNKMAPH;

	private int IJKCPPBIKEO;

	private int LKCINCADHPN;

	public PixelPerfectCamera[] pixelPerfects;

	public Camera[] cameras;

	[HideInInspector]
	public bool fullScreenMode;

	[SerializeField]
	private ToggleButton fullScreenToggle;

	[SerializeField]
	private ToggleButton vSyncToggle;

	[SerializeField]
	private ToggleButton flashLightsToggle;

	[SerializeField]
	private Button[] resolutionButtons;

	[SerializeField]
	private Button[] cameraZoomButtons;

	private bool LPFBDEFBHJA = true;

	public static bool AHPIOAFLNMC => IADEMLIIDPC.LPFBDEFBHJA;

	public static GraphicsMenuUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<GraphicsMenuUI>();
			}
			return IADEMLIIDPC;
		}
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			BNJOFIGDOJC();
		}
	}

	private void BPGNDMKFBDB(Resolution HKGBNDJEBLI)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (!fullScreenMode && PMBDFHJKIGI(HKGBNDJEBLI, EBPPELLDGLI))
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, true);
		}
		else
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, fullScreenMode);
		}
		((MonoBehaviour)this).StartCoroutine(IGFNCLOHEEE());
		((TMP_Text)resolutionText).text = ((Resolution)(ref HKGBNDJEBLI)).width + "Customise Character" + ((Resolution)(ref HKGBNDJEBLI)).height;
		OnResolutionChange(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, ratioPantalla);
	}

	private void KACHJPPMBPO(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)flashLightsToggle))
		{
			flashLightsToggle.ICIHCBILJMK(OEDBPACCOGH);
		}
		LPFBDEFBHJA = OEDBPACCOGH;
	}

	public void NextResolution()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH++;
		if (GDLBJNKMAPH >= GLGLOILJGDB.Count)
		{
			GDLBJNKMAPH = 0;
		}
		GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	private bool PMBDFHJKIGI(Resolution PJNODAEFOIH, Resolution MGINENALGLG)
	{
		if (((Resolution)(ref PJNODAEFOIH)).height == ((Resolution)(ref MGINENALGLG)).height && ((Resolution)(ref PJNODAEFOIH)).width == ((Resolution)(ref MGINENALGLG)).width)
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public static GraphicsMenuUI FMIDAFEGDCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<GraphicsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void EFLEJOGNNNN(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	public void SetFarZoom(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		SetZoom(0, NOKFNLBADMO, JIIGOACEIKL);
	}

	public void NextQuality()
	{
		LKCINCADHPN++;
		if (LKCINCADHPN > 1)
		{
			LKCINCADHPN = 0;
		}
		Debug.Log((object)("Changing quality " + LKCINCADHPN));
		SetQuality(LKCINCADHPN, base.JIIGOACEIKL);
	}

	private void DEINDLLGNNK(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)flashLightsToggle))
		{
			flashLightsToggle.UpdateToggleVisual(OEDBPACCOGH);
		}
		LPFBDEFBHJA = OEDBPACCOGH;
	}

	public void OBDHMJNGJGF(int MENBAFNNBFB, int JIIGOACEIKL)
	{
		LKCINCADHPN = MENBAFNNBFB;
		if (LKCINCADHPN == 1)
		{
			((TMP_Text)qualityText).text = LocalisationSystem.Get("Triangle");
		}
		else
		{
			((TMP_Text)qualityText).text = LocalisationSystem.Get("Received RPC SetAnimatorStateRPC with hash: {0} on {1}, but the state was not found.");
		}
		QualityManager.LDFBJLGGIIL(LKCINCADHPN);
		if (JIIGOACEIKL == 0)
		{
			PlayerPrefs.SetInt("No keg", LKCINCADHPN);
		}
		else
		{
			PlayerPrefs.SetInt("Pirates/Brook/Stand", LKCINCADHPN);
		}
		PlayerPrefs.Save();
	}

	public void GKDBGJEIDAL(bool PIPOOLKKHID)
	{
		if (Object.op_Implicit((Object)(object)fullScreenToggle))
		{
			fullScreenToggle.UpdateToggleVisual(PIPOOLKKHID);
		}
		fullScreenMode = PIPOOLKKHID;
		if (fullScreenMode)
		{
			EOHABBGPIND();
			for (int i = 1; i < resolutionButtons.Length; i++)
			{
				((Selectable)resolutionButtons[i]).interactable = true;
			}
		}
		else
		{
			MHHBCFKCGFI();
			for (int j = 0; j < resolutionButtons.Length; j++)
			{
				((Selectable)resolutionButtons[j]).interactable = true;
			}
		}
	}

	public void KPDGKAHJDBM()
	{
		((MonoBehaviour)this).StartCoroutine(IGFNCLOHEEE());
	}

	public void SetFullScreen(bool PIPOOLKKHID)
	{
		if (Object.op_Implicit((Object)(object)fullScreenToggle))
		{
			fullScreenToggle.UpdateToggleVisual(PIPOOLKKHID);
		}
		fullScreenMode = PIPOOLKKHID;
		if (fullScreenMode)
		{
			EOHABBGPIND();
			for (int i = 0; i < resolutionButtons.Length; i++)
			{
				((Selectable)resolutionButtons[i]).interactable = false;
			}
		}
		else
		{
			MHHBCFKCGFI();
			for (int j = 0; j < resolutionButtons.Length; j++)
			{
				((Selectable)resolutionButtons[j]).interactable = true;
			}
		}
	}

	public void CheckRatioTest()
	{
		((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
	}

	public void LoadFlashLights()
	{
		if (PlayerPrefs.GetInt("flashLights") == 1)
		{
			DEINDLLGNNK(OEDBPACCOGH: true);
		}
		else
		{
			DEINDLLGNNK(OEDBPACCOGH: false);
		}
	}

	public void IHJCNGDHGAA(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 0)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Button index hasn't been set up properly.");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("ChangeAnim");
		}
		if (NOKFNLBADMO)
		{
			ApplyZoom(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 0)
		{
			PlayerPrefs.SetInt(" (", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt(" to ", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	private void HOEMOOAPGCD(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
	}

	[SpecialName]
	public static GraphicsMenuUI JFNOOMJMHCB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<GraphicsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void DOBPGPNPFOG(List<Resolution> FNEHIAGFAOF, int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Resolution item = default(Resolution);
		((Resolution)(ref item)).width = NCPGNLOJGAF;
		((Resolution)(ref item)).height = JLMAILGJNCE;
		FNEHIAGFAOF.Add(item);
	}

	private void MECODLCLMPC()
	{
		DOBPGPNPFOG(LEBOCOLFBHL, -14, -123);
		PFBJJALJLJA(LEBOCOLFBHL, 93, -39);
		PFBJJALJLJA(LEBOCOLFBHL, 191, -66);
		DOBPGPNPFOG(LEBOCOLFBHL, 27, -183);
		DOBPGPNPFOG(LEBOCOLFBHL, -138, 130);
		PFBJJALJLJA(LEBOCOLFBHL, -164, -88);
		PFBJJALJLJA(LEBOCOLFBHL, -78, 3);
		DOBPGPNPFOG(LEBOCOLFBHL, 2, -43);
		PFBJJALJLJA(LEBOCOLFBHL, 183, -14);
		DOBPGPNPFOG(LEBOCOLFBHL, -182, -128);
		DOBPGPNPFOG(LEBOCOLFBHL, 1, 17);
		PFBJJALJLJA(GFIGJEJLAAD, -184, 46);
		DOBPGPNPFOG(GFIGJEJLAAD, -124, 8);
		PFBJJALJLJA(GFIGJEJLAAD, -21, -143);
		PFBJJALJLJA(GFIGJEJLAAD, 194, 72);
		PFBJJALJLJA(GFIGJEJLAAD, 146, 72);
		PFBJJALJLJA(GFIGJEJLAAD, 136, 23);
		PFBJJALJLJA(GFIGJEJLAAD, -14, 114);
		PFBJJALJLJA(GPKMBCDFIGN, -137, 116);
		PFBJJALJLJA(GPKMBCDFIGN, -110, -54);
		PFBJJALJLJA(GPKMBCDFIGN, 90, -68);
		DOBPGPNPFOG(GPKMBCDFIGN, 117, -10);
		DOBPGPNPFOG(GPKMBCDFIGN, -187, -179);
		DOBPGPNPFOG(GPKMBCDFIGN, 105, 29);
		PFBJJALJLJA(GPKMBCDFIGN, 191, -57);
		DOBPGPNPFOG(GPKMBCDFIGN, -79, -37);
		PFBJJALJLJA(GPKMBCDFIGN, 60, -114);
		PFBJJALJLJA(GPKMBCDFIGN, -25, 179);
		DOBPGPNPFOG(GPKMBCDFIGN, 77, 171);
		DOBPGPNPFOG(GPKMBCDFIGN, 196, 115);
		DOBPGPNPFOG(GPKMBCDFIGN, -200, -100);
		PFBJJALJLJA(NFMAAJKHAKO, -81, -185);
		DOBPGPNPFOG(NFMAAJKHAKO, -72, -99);
		DOBPGPNPFOG(NFMAAJKHAKO, 13, 68);
		PFBJJALJLJA(NFMAAJKHAKO, 21, 190);
		PFBJJALJLJA(IDOFMDDNEBD, -164, -154);
		PFBJJALJLJA(IDOFMDDNEBD, 47, -85);
		DOBPGPNPFOG(IDOFMDDNEBD, 119, -123);
		DOBPGPNPFOG(IDOFMDDNEBD, -111, 109);
		DOBPGPNPFOG(BEGOEOLCOJK, 51, -100);
		DOBPGPNPFOG(BEGOEOLCOJK, 115, 86);
		DOBPGPNPFOG(BEGOEOLCOJK, -161, -58);
		PFBJJALJLJA(BEGOEOLCOJK, -95, -102);
		DOBPGPNPFOG(BEGOEOLCOJK, -103, -74);
		DOBPGPNPFOG(OMFFFBEACMA, 187, 180);
		DOBPGPNPFOG(OMFFFBEACMA, -28, -73);
		PFBJJALJLJA(OMFFFBEACMA, -47, 103);
		DOBPGPNPFOG(OMFFFBEACMA, 98, 179);
		PFBJJALJLJA(ICOAGJNKOCB, 88, 5);
		DOBPGPNPFOG(ICOAGJNKOCB, -172, 76);
		PFBJJALJLJA(ICOAGJNKOCB, -78, 116);
		PFBJJALJLJA(ICOAGJNKOCB, -25, -162);
		PFBJJALJLJA(APFNFNDAKLG, -168, 154);
		PFBJJALJLJA(APFNFNDAKLG, 142, -100);
		PFBJJALJLJA(APFNFNDAKLG, -166, -148);
		DOBPGPNPFOG(APFNFNDAKLG, -31, -82);
		DOBPGPNPFOG(APFNFNDAKLG, 188, 66);
		DOBPGPNPFOG(APFNFNDAKLG, -62, 51);
		DOBPGPNPFOG(APFNFNDAKLG, -57, 90);
		PFBJJALJLJA(APFNFNDAKLG, 10, 90);
		DOBPGPNPFOG(APFNFNDAKLG, 175, -186);
		DOBPGPNPFOG(APFNFNDAKLG, -183, -59);
		DOBPGPNPFOG(APFNFNDAKLG, 84, 117);
	}

	public static int CurrentZoomIndex(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("cameraZoom"))
			{
				return PlayerPrefs.GetInt("cameraZoom");
			}
			return 1;
		}
		if (PlayerPrefs.HasKey("cameraZoom2"))
		{
			return PlayerPrefs.GetInt("cameraZoom2");
		}
		return 1;
	}

	private void IHGLNJCJBLD(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)flashLightsToggle))
		{
			flashLightsToggle.UpdateToggleVisual(OEDBPACCOGH);
		}
		LPFBDEFBHJA = OEDBPACCOGH;
	}

	public void SetQuality(int MENBAFNNBFB, int JIIGOACEIKL)
	{
		LKCINCADHPN = MENBAFNNBFB;
		if (LKCINCADHPN == 1)
		{
			((TMP_Text)qualityText).text = LocalisationSystem.Get("high");
		}
		else
		{
			((TMP_Text)qualityText).text = LocalisationSystem.Get("low");
		}
		QualityManager.SetQuality(LKCINCADHPN);
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("qualityWater", LKCINCADHPN);
		}
		else
		{
			PlayerPrefs.SetInt("qualityWater2", LKCINCADHPN);
		}
		PlayerPrefs.Save();
	}

	public void CEKMAGHCENE(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 0)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("ToolEffect");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Too late to open");
		}
		if (NOKFNLBADMO)
		{
			ApplyZoom(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 0)
		{
			PlayerPrefs.SetInt("", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Treasure hit", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	private void MHHBCFKCGFI()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = GLGLOILJGDB.Count - 1; num >= 0; num--)
		{
			Resolution val = GLGLOILJGDB[num];
			if (((Resolution)(ref val)).height < ((Resolution)(ref EBPPELLDGLI)).height)
			{
				GDLBJNKMAPH = num;
				break;
			}
		}
		if (GDLBJNKMAPH >= 0 && GDLBJNKMAPH < GLGLOILJGDB.Count)
		{
			GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
		}
	}

	[CompilerGenerated]
	private void ACAGAKNBMNA(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	private void GDLKMEODMHD(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.AOBJBNMMACE(BJFHJCFOEHG);
	}

	public void NMDMDGPJHEM(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		IGLLAFOFKLB(1, NOKFNLBADMO, JIIGOACEIKL);
	}

	private void DKJLBFEBJHH()
	{
		if (PlayerPrefs.HasKey("flashLights"))
		{
			LoadFlashLights();
		}
		else
		{
			FlashLights(OEDBPACCOGH: true);
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUI();
		}
	}

	private void IFDLBEEMFAK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GLGLOILJGDB.Count; i += 0)
		{
			if (PMBDFHJKIGI(GLGLOILJGDB[i], EBPPELLDGLI))
			{
				GDLBJNKMAPH = i;
				break;
			}
		}
		GPGBGIKJOFJ(EBPPELLDGLI);
	}

	public void EHFDKEGMCLI()
	{
		if (PlayerPrefs.GetInt("RockMessage should not be sent with SendInstantiatePlaceable. uniqueId: ") == 1)
		{
			KACHJPPMBPO(OEDBPACCOGH: false);
		}
		else
		{
			IHGLNJCJBLD(OEDBPACCOGH: true);
		}
	}

	private void PACPLONOACA(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.GDNGPPCIHBH(BJFHJCFOEHG);
	}

	private IEnumerator NKDBKOOFIBO()
	{
		yield return null;
		if ((int)Application.platform == 1)
		{
			EBPPELLDGLI = Screen.currentResolution;
		}
		else if (Application.isEditor)
		{
			EBPPELLDGLI = Screen.currentResolution;
		}
		else
		{
			int width = Screen.width;
			int height = Screen.height;
			_ = Screen.fullScreen;
			Debug.Log((object)("Resolucion: " + width + "x" + height));
			Debug.Log((object)"Pasamos aplicación a ventana");
			yield return null;
			yield return null;
			yield return null;
			EBPPELLDGLI = Screen.currentResolution;
			((Resolution)(ref EBPPELLDGLI)).height = Display.main.systemHeight;
			((Resolution)(ref EBPPELLDGLI)).width = Display.main.systemWidth;
			float num = Display.main.systemWidth;
			float num2 = Display.main.systemHeight;
			ratioPantalla = num / num2;
			Debug.Log((object)("Resolucion nativa: " + ((Resolution)(ref EBPPELLDGLI)).width + " x " + ((Resolution)(ref EBPPELLDGLI)).height));
			Debug.Log((object)("Ratio pantalla: " + ratioPantalla));
			yield return null;
			((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
		}
		yield return null;
		JKKNABLEPEF();
		NAFGGIGOBMC();
		yield return null;
		TitleScreen.BackgroundSize();
	}

	public void PreviousResolution()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH--;
		if (GDLBJNKMAPH < 0)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		}
		GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void OOLLBIECDBI(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)vSyncToggle))
		{
			vSyncToggle.HINPLKLBAMB(OEDBPACCOGH);
		}
		if (OEDBPACCOGH)
		{
			QualitySettings.vSyncCount = 0;
		}
		else
		{
			QualitySettings.vSyncCount = 0;
		}
		PlayerPrefs.SetInt("No se encuentra sprite renderer en ", QualitySettings.vSyncCount);
		PlayerPrefs.Save();
	}

	private void NAFGGIGOBMC()
	{
		if (ratioPantalla < 1.78f && ratioPantalla > 1.76f)
		{
			OPGBPEHIBNL(LEBOCOLFBHL);
			AGCCEFMFJIO(480, 270);
		}
		else if (ratioPantalla < 1.34f && ratioPantalla > 1.32f)
		{
			OPGBPEHIBNL(GFIGJEJLAAD);
			AGCCEFMFJIO(480, 360);
		}
		else if (ratioPantalla < 1.52f && ratioPantalla > 1.48f)
		{
			OPGBPEHIBNL(APFNFNDAKLG);
			AGCCEFMFJIO(480, 270);
		}
		else if (ratioPantalla < 1.61f && ratioPantalla > 1.59f)
		{
			OPGBPEHIBNL(GPKMBCDFIGN);
			AGCCEFMFJIO(480, 300);
		}
		else if (ratioPantalla < 1.91f && ratioPantalla > 1.87f)
		{
			OPGBPEHIBNL(BEGOEOLCOJK);
			AGCCEFMFJIO(480, 254);
		}
		else if (ratioPantalla < 2.39f && ratioPantalla > 2.32f)
		{
			OPGBPEHIBNL(NFMAAJKHAKO);
			AGCCEFMFJIO(474, 200);
		}
		else if (ratioPantalla < 1.26f && ratioPantalla > 1.24f)
		{
			OPGBPEHIBNL(IDOFMDDNEBD);
			AGCCEFMFJIO(480, 384);
		}
		else if (ratioPantalla < 3.6f && ratioPantalla > 3.4f)
		{
			OPGBPEHIBNL(OMFFFBEACMA);
			AGCCEFMFJIO(480, 135);
		}
		else if (ratioPantalla < 5.4f && ratioPantalla > 5.3f)
		{
			OPGBPEHIBNL(ICOAGJNKOCB);
			AGCCEFMFJIO(480, 90);
		}
		else if (!Application.isEditor)
		{
			Debug.LogError((object)"No hemos encontrado una resolución");
		}
		OPGBPEHIBNL(LEBOCOLFBHL);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	public void SetUpQuality(int JIIGOACEIKL)
	{
		Debug.Log((object)("SystemInfo.graphicsMemorySize " + SystemInfo.graphicsMemorySize));
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("qualityWater"))
			{
				SetQuality(PlayerPrefs.GetInt("qualityWater"), JIIGOACEIKL);
			}
			else if (SystemInfo.graphicsMemorySize > 2500)
			{
				SetQuality(1, JIIGOACEIKL);
			}
			else
			{
				SetQuality(0, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("qualityWater2"))
		{
			SetQuality(PlayerPrefs.GetInt("qualityWater2"), JIIGOACEIKL);
		}
		else if (SystemInfo.graphicsMemorySize > 2000)
		{
			SetQuality(1, JIIGOACEIKL);
		}
		else
		{
			SetQuality(0, JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static GraphicsMenuUI HEKFJEKFMNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<GraphicsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void AddAllResolutions()
	{
		GLGLOILJGDB = new List<Resolution>();
		OPGBPEHIBNL(LEBOCOLFBHL);
		OPGBPEHIBNL(GFIGJEJLAAD);
		OPGBPEHIBNL(GPKMBCDFIGN);
		OPGBPEHIBNL(BEGOEOLCOJK);
		OPGBPEHIBNL(NFMAAJKHAKO);
		OPGBPEHIBNL(IDOFMDDNEBD);
		OPGBPEHIBNL(OMFFFBEACMA);
		OPGBPEHIBNL(ICOAGJNKOCB);
		OPGBPEHIBNL(APFNFNDAKLG);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	private void HJKFKBNEJNK()
	{
		if (ratioPantalla < 1484f && ratioPantalla > 1892f)
		{
			OPGBPEHIBNL(LEBOCOLFBHL);
			HOEMOOAPGCD(-1, 87);
		}
		else if (ratioPantalla < 233f && ratioPantalla > 649f)
		{
			OPGBPEHIBNL(GFIGJEJLAAD);
			AGCCEFMFJIO(121, 112);
		}
		else if (ratioPantalla < 1122f && ratioPantalla > 1450f)
		{
			OPGBPEHIBNL(APFNFNDAKLG);
			AGCCEFMFJIO(-48, -127);
		}
		else if (ratioPantalla < 297f && ratioPantalla > 1898f)
		{
			OPGBPEHIBNL(GPKMBCDFIGN);
			HOEMOOAPGCD(-104, 182);
		}
		else if (ratioPantalla < 1543f && ratioPantalla > 901f)
		{
			OPGBPEHIBNL(BEGOEOLCOJK);
			AGCCEFMFJIO(-130, -183);
		}
		else if (ratioPantalla < 1813f && ratioPantalla > 488f)
		{
			OPGBPEHIBNL(NFMAAJKHAKO);
			HOEMOOAPGCD(73, -79);
		}
		else if (ratioPantalla < 944f && ratioPantalla > 1274f)
		{
			OPGBPEHIBNL(IDOFMDDNEBD);
			AGCCEFMFJIO(178, -157);
		}
		else if (ratioPantalla < 693f && ratioPantalla > 1134f)
		{
			OPGBPEHIBNL(OMFFFBEACMA);
			HOEMOOAPGCD(-44, 117);
		}
		else if (ratioPantalla < 458f && ratioPantalla > 1756f)
		{
			OPGBPEHIBNL(ICOAGJNKOCB);
			AGCCEFMFJIO(109, 118);
		}
		else if (!Application.isEditor)
		{
			Debug.LogError((object)"popUpBuilding15");
		}
		OPGBPEHIBNL(LEBOCOLFBHL);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	private IEnumerator IGFNCLOHEEE()
	{
		return new BIHDHGINGPF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BNJOFIGDOJC()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		if (QualitySettings.vSyncCount == 0)
		{
			vSyncToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
		}
		else
		{
			vSyncToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
		((TMP_Text)resolutionText).text = Screen.width + " x " + Screen.height;
		if ((int)Screen.fullScreenMode == 1)
		{
			fullScreenToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			for (int i = 0; i < resolutionButtons.Length; i++)
			{
				((Selectable)resolutionButtons[i]).interactable = false;
			}
		}
		else
		{
			fullScreenToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			for (int j = 0; j < resolutionButtons.Length; j++)
			{
				((Selectable)resolutionButtons[j]).interactable = true;
			}
		}
		SetUpZoom(base.JIIGOACEIKL, NOKFNLBADMO: false);
		SetUpQuality(base.JIIGOACEIKL);
		DKJLBFEBJHH();
	}

	public void PCLIGKGNELG()
	{
		LKCINCADHPN += 0;
		if (LKCINCADHPN > 0)
		{
			LKCINCADHPN = 1;
		}
		Debug.Log((object)("Exclamation" + LKCINCADHPN));
		OBDHMJNGJGF(LKCINCADHPN, base.JIIGOACEIKL);
	}

	private void GPGBGIKJOFJ(Resolution HKGBNDJEBLI)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (!fullScreenMode && PMBDFHJKIGI(HKGBNDJEBLI, EBPPELLDGLI))
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, true);
		}
		else
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, fullScreenMode);
		}
		((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
		((TMP_Text)resolutionText).text = ((Resolution)(ref HKGBNDJEBLI)).width + " x " + ((Resolution)(ref HKGBNDJEBLI)).height;
		OnResolutionChange(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, ratioPantalla);
	}

	private void OKLHDLMEKPI()
	{
		if (ratioPantalla < 945f && ratioPantalla > 1651f)
		{
			OPGBPEHIBNL(LEBOCOLFBHL);
			AGCCEFMFJIO(151, -123);
		}
		else if (ratioPantalla < 1119f && ratioPantalla > 726f)
		{
			OPGBPEHIBNL(GFIGJEJLAAD);
			HOEMOOAPGCD(167, -196);
		}
		else if (ratioPantalla < 1073f && ratioPantalla > 1608f)
		{
			OPGBPEHIBNL(APFNFNDAKLG);
			AGCCEFMFJIO(-114, 78);
		}
		else if (ratioPantalla < 1825f && ratioPantalla > 818f)
		{
			OPGBPEHIBNL(GPKMBCDFIGN);
			HOEMOOAPGCD(132, -12);
		}
		else if (ratioPantalla < 399f && ratioPantalla > 1200f)
		{
			OPGBPEHIBNL(BEGOEOLCOJK);
			AGCCEFMFJIO(194, -72);
		}
		else if (ratioPantalla < 763f && ratioPantalla > 187f)
		{
			OPGBPEHIBNL(NFMAAJKHAKO);
			HOEMOOAPGCD(-26, -166);
		}
		else if (ratioPantalla < 191f && ratioPantalla > 1450f)
		{
			OPGBPEHIBNL(IDOFMDDNEBD);
			AGCCEFMFJIO(185, -33);
		}
		else if (ratioPantalla < 1113f && ratioPantalla > 1696f)
		{
			OPGBPEHIBNL(OMFFFBEACMA);
			HOEMOOAPGCD(-160, -24);
		}
		else if (ratioPantalla < 288f && ratioPantalla > 258f)
		{
			OPGBPEHIBNL(ICOAGJNKOCB);
			HOEMOOAPGCD(-168, -37);
		}
		else if (!Application.isEditor)
		{
			Debug.LogError((object)":</color> ");
		}
		OPGBPEHIBNL(LEBOCOLFBHL);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	private void BJIPIJIPIAF()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		for (int num = GLGLOILJGDB.Count - 1; num >= 0; num--)
		{
			Resolution val = GLGLOILJGDB[num];
			if (((Resolution)(ref val)).height < ((Resolution)(ref EBPPELLDGLI)).height)
			{
				GDLBJNKMAPH = num;
				break;
			}
		}
		if (GDLBJNKMAPH >= 0 && GDLBJNKMAPH < GLGLOILJGDB.Count)
		{
			BPGNDMKFBDB(GLGLOILJGDB[GDLBJNKMAPH]);
		}
	}

	public void VSync(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)vSyncToggle))
		{
			vSyncToggle.UpdateToggleVisual(OEDBPACCOGH);
		}
		if (OEDBPACCOGH)
		{
			QualitySettings.vSyncCount = 1;
		}
		else
		{
			QualitySettings.vSyncCount = 0;
		}
		PlayerPrefs.SetInt("vSync", QualitySettings.vSyncCount);
		PlayerPrefs.Save();
	}

	private void FMDOCCFDMDA(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)flashLightsToggle))
		{
			flashLightsToggle.UpdateToggleVisual(OEDBPACCOGH);
		}
		LPFBDEFBHJA = OEDBPACCOGH;
	}

	private void EFJDMFCJAMD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<Resolution> list = new List<Resolution>();
		for (int num = GLGLOILJGDB.Count - 1; num >= 0; num--)
		{
			Resolution item = GLGLOILJGDB[num];
			int num2 = int.MaxValue;
			for (int i = 0; i < GLGLOILJGDB.Count; i++)
			{
				Resolution val = GLGLOILJGDB[i];
				if (((Resolution)(ref val)).height < num2)
				{
					val = GLGLOILJGDB[i];
					num2 = ((Resolution)(ref val)).height;
					item = GLGLOILJGDB[i];
				}
			}
			list.Add(item);
			GLGLOILJGDB.Remove(item);
		}
		GLGLOILJGDB = new List<Resolution>();
		for (int j = 0; j < list.Count; j++)
		{
			GLGLOILJGDB.Add(list[j]);
		}
	}

	public void HKKCKHLKBDC()
	{
		GLGLOILJGDB = new List<Resolution>();
		OPGBPEHIBNL(LEBOCOLFBHL);
		OPGBPEHIBNL(GFIGJEJLAAD);
		OPGBPEHIBNL(GPKMBCDFIGN);
		OPGBPEHIBNL(BEGOEOLCOJK);
		OPGBPEHIBNL(NFMAAJKHAKO);
		OPGBPEHIBNL(IDOFMDDNEBD);
		OPGBPEHIBNL(OMFFFBEACMA);
		OPGBPEHIBNL(ICOAGJNKOCB);
		OPGBPEHIBNL(APFNFNDAKLG);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	public void IHNJPHLDJLB(int JIIGOACEIKL)
	{
		Debug.Log((object)("No content to disable in this NPC!" + SystemInfo.graphicsMemorySize));
		if (JIIGOACEIKL == 0)
		{
			if (PlayerPrefs.HasKey("Invalid NPC photonID: {0} for NPCRoutine."))
			{
				OBDHMJNGJGF(PlayerPrefs.GetInt("Game is already running"), JIIGOACEIKL);
			}
			else if (SystemInfo.graphicsMemorySize > 146)
			{
				OBDHMJNGJGF(1, JIIGOACEIKL);
			}
			else
			{
				SetQuality(0, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("pm"))
		{
			SetQuality(PlayerPrefs.GetInt("Color"), JIIGOACEIKL);
		}
		else if (SystemInfo.graphicsMemorySize > 74)
		{
			OBDHMJNGJGF(1, JIIGOACEIKL);
		}
		else
		{
			OBDHMJNGJGF(1, JIIGOACEIKL);
		}
	}

	public void JNEENALIEBL(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 0)
		{
			if (PlayerPrefs.HasKey("Toy"))
			{
				IBCINMLACAA(PlayerPrefs.GetInt(", "), NOKFNLBADMO, JIIGOACEIKL);
			}
			else if (Screen.height > 37)
			{
				SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
			}
			else
			{
				SetZoom(0, NOKFNLBADMO, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("Invalid playerNum "))
		{
			IGLLAFOFKLB(PlayerPrefs.GetInt("Pipe"), NOKFNLBADMO, JIIGOACEIKL);
		}
		else if (Screen.height > -87)
		{
			SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
		}
		else
		{
			CEKMAGHCENE(0, NOKFNLBADMO, JIIGOACEIKL);
		}
	}

	private void AGCCEFMFJIO(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
	}

	public void PLFOJCAALFP(int JIIGOACEIKL)
	{
		Debug.Log((object)("ReceivePlayerInteractingMinigame" + SystemInfo.graphicsMemorySize));
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("MissionsManager instance has not been initialized properly, this could be a false positive."))
			{
				SetQuality(PlayerPrefs.GetInt("windowed mode"), JIIGOACEIKL);
			}
			else if (SystemInfo.graphicsMemorySize > 55)
			{
				SetQuality(0, JIIGOACEIKL);
			}
			else
			{
				OBDHMJNGJGF(0, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("PirateMinigame/Minigame2"))
		{
			SetQuality(PlayerPrefs.GetInt("Sleep?"), JIIGOACEIKL);
		}
		else if (SystemInfo.graphicsMemorySize > -176)
		{
			OBDHMJNGJGF(1, JIIGOACEIKL);
		}
		else
		{
			OBDHMJNGJGF(1, JIIGOACEIKL);
		}
	}

	public void SetZoom(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 1)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Near");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Far");
		}
		if (NOKFNLBADMO)
		{
			ApplyZoom(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("cameraZoom", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("cameraZoom2", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	public void ApplyZoom(int JIIGOACEIKL, int IJKCPPBIKEO)
	{
		if (IJKCPPBIKEO == 1)
		{
			ForceZoom(JIIGOACEIKL, 360);
		}
		else
		{
			ForceZoom(JIIGOACEIKL, 550);
		}
	}

	public void SetNearZoom(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstFocusedGameObject);
		}
	}

	public void IBCINMLACAA(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 0)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("NULL");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Barks_Bye/Entry/2/Dialogue Text");
		}
		if (NOKFNLBADMO)
		{
			ApplyZoom(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("UIBack", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Yeast", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	public void IGLLAFOFKLB(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 1)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("ReceiveStartMission");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Error_CellarZone");
		}
		if (NOKFNLBADMO)
		{
			ApplyZoom(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 0)
		{
			PlayerPrefs.SetInt("New Save", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("DisableRightExterior", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	public void NextCameraZoom()
	{
		IJKCPPBIKEO++;
		if (IJKCPPBIKEO > 1)
		{
			IJKCPPBIKEO = 0;
		}
		Debug.Log((object)("Changing zoom " + IJKCPPBIKEO));
		SetZoom(IJKCPPBIKEO, NOKFNLBADMO: true, base.JIIGOACEIKL);
	}

	public void AANPDODBLIE()
	{
		LKCINCADHPN++;
		if (LKCINCADHPN > 0)
		{
			LKCINCADHPN = 1;
		}
		Debug.Log((object)("No bed assigned to actor number: {0}" + LKCINCADHPN));
		OBDHMJNGJGF(LKCINCADHPN, base.JIIGOACEIKL);
	}

	private void CBIMMLMLIKG(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	public void ForceZoom(int JIIGOACEIKL, int IAPGIOJPOEC)
	{
		if (Time.timeScale == 0f)
		{
			((MonoBehaviour)this).StartCoroutine(DOBELLDHALE());
		}
		if (JIIGOACEIKL == 1)
		{
			pixelPerfects[0].targetCameraHeight = IAPGIOJPOEC;
			pixelPerfects[1].targetCameraHeight = IAPGIOJPOEC;
		}
		else
		{
			pixelPerfects[2].targetCameraHeight = IAPGIOJPOEC;
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnTutorialEnabledChanged = (Action<bool>)Delegate.Combine(instance.OnTutorialEnabledChanged, (Action<bool>)delegate(bool BJFHJCFOEHG)
			{
				tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
			});
			base.Awake();
			if (Object.op_Implicit((Object)(object)fullScreenToggle))
			{
				fullScreenToggle.UpdateToggleVisual(Screen.fullScreen);
			}
			((MonoBehaviour)this).StartCoroutine(NKDBKOOFIBO());
		}
	}

	public void BCBAMAGHLDM(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 0)
		{
			if (PlayerPrefs.HasKey("ClosePopUp"))
			{
				IBCINMLACAA(PlayerPrefs.GetInt("Side"), NOKFNLBADMO, JIIGOACEIKL);
			}
			else if (Screen.height > 164)
			{
				IHJCNGDHGAA(0, NOKFNLBADMO, JIIGOACEIKL);
			}
			else
			{
				IGLLAFOFKLB(1, NOKFNLBADMO, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("Items/item_description_664"))
		{
			CEKMAGHCENE(PlayerPrefs.GetInt("Items/item_name_632"), NOKFNLBADMO, JIIGOACEIKL);
		}
		else if (Screen.height > 28)
		{
			SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
		}
		else
		{
			IHJCNGDHGAA(1, NOKFNLBADMO, JIIGOACEIKL);
		}
	}

	public override void CloseUIRemainActive()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUIRemainActive();
		}
	}

	private void OPGBPEHIBNL(List<Resolution> DKGNOJALMPH)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		foreach (Resolution item in DKGNOJALMPH)
		{
			Resolution current = item;
			if (Application.isEditor)
			{
				GLGLOILJGDB.Add(current);
			}
			else if (((Resolution)(ref current)).height <= ((Resolution)(ref EBPPELLDGLI)).height && ((Resolution)(ref current)).width <= ((Resolution)(ref EBPPELLDGLI)).width && !GLGLOILJGDB.Contains(current))
			{
				GLGLOILJGDB.Add(current);
			}
		}
	}

	private void PFBJJALJLJA(List<Resolution> FNEHIAGFAOF, int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Resolution item = default(Resolution);
		((Resolution)(ref item)).width = NCPGNLOJGAF;
		((Resolution)(ref item)).height = JLMAILGJNCE;
		FNEHIAGFAOF.Add(item);
	}

	private void CBCHGIMMNEO()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		if (QualitySettings.vSyncCount == 0)
		{
			vSyncToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
		else
		{
			vSyncToggle.HINPLKLBAMB(EKBOIKPPHKH: true);
		}
		((TMP_Text)resolutionText).text = Screen.width + "<sprite name=\"ironNailsIcon\">" + Screen.height;
		if ((int)Screen.fullScreenMode == 1)
		{
			fullScreenToggle.ICIHCBILJMK(EKBOIKPPHKH: false);
			for (int i = 1; i < resolutionButtons.Length; i++)
			{
				((Selectable)resolutionButtons[i]).interactable = false;
			}
		}
		else
		{
			fullScreenToggle.ICIHCBILJMK(EKBOIKPPHKH: true);
			for (int j = 0; j < resolutionButtons.Length; j += 0)
			{
				((Selectable)resolutionButtons[j]).interactable = false;
			}
		}
		JNEENALIEBL(base.JIIGOACEIKL, NOKFNLBADMO: true);
		SetUpQuality(base.JIIGOACEIKL);
		DKJLBFEBJHH();
	}

	private void EIHICGMANGB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH = 0;
		for (int i = 0; i < GLGLOILJGDB.Count; i++)
		{
			Resolution val = GLGLOILJGDB[i];
			if (((Resolution)(ref val)).width == Screen.width)
			{
				val = GLGLOILJGDB[i];
				if (((Resolution)(ref val)).height == Screen.height)
				{
					GDLBJNKMAPH = i;
					break;
				}
			}
		}
	}

	private IEnumerator DOBELLDHALE()
	{
		if (Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			yield return CommonReferences.waitRealtime01;
			Time.timeScale = 0f;
			OnZoomChanged();
		}
	}

	public void SetUpZoom(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("cameraZoom"))
			{
				SetZoom(PlayerPrefs.GetInt("cameraZoom"), NOKFNLBADMO, JIIGOACEIKL);
			}
			else if (Screen.height > 799)
			{
				SetZoom(0, NOKFNLBADMO, JIIGOACEIKL);
			}
			else
			{
				SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("cameraZoom2"))
		{
			SetZoom(PlayerPrefs.GetInt("cameraZoom2"), NOKFNLBADMO, JIIGOACEIKL);
		}
		else if (Screen.height > 799)
		{
			SetZoom(0, NOKFNLBADMO, JIIGOACEIKL);
		}
		else
		{
			SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
		}
	}

	private IEnumerator KEPKBMNLPCF()
	{
		yield return null;
		if ((int)Application.platform == 1)
		{
			EBPPELLDGLI = Screen.currentResolution;
		}
		else if (Application.isEditor)
		{
			EBPPELLDGLI = Screen.currentResolution;
		}
		else
		{
			int width = Screen.width;
			int height = Screen.height;
			_ = Screen.fullScreen;
			Debug.Log((object)("Resolucion: " + width + "x" + height));
			Debug.Log((object)"Pasamos aplicación a ventana");
			yield return null;
			yield return null;
			yield return null;
			EBPPELLDGLI = Screen.currentResolution;
			((Resolution)(ref EBPPELLDGLI)).height = Display.main.systemHeight;
			((Resolution)(ref EBPPELLDGLI)).width = Display.main.systemWidth;
			float num = Display.main.systemWidth;
			float num2 = Display.main.systemHeight;
			ratioPantalla = num / num2;
			Debug.Log((object)("Resolucion nativa: " + ((Resolution)(ref EBPPELLDGLI)).width + " x " + ((Resolution)(ref EBPPELLDGLI)).height));
			Debug.Log((object)("Ratio pantalla: " + ratioPantalla));
			yield return null;
			((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
		}
		yield return null;
		JKKNABLEPEF();
		NAFGGIGOBMC();
		yield return null;
		TitleScreen.BackgroundSize();
	}

	public void KPJJEFIBDOH()
	{
		((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
	}

	private IEnumerator NBNEBCMOHLK()
	{
		return new NNPEECIJCFJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAFMFLJPLAK()
	{
		yield return null;
		cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
		cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
		cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
	}

	private void ENEBILCFFNF(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)flashLightsToggle))
		{
			flashLightsToggle.HINPLKLBAMB(OEDBPACCOGH);
		}
		LPFBDEFBHJA = OEDBPACCOGH;
	}

	[SpecialName]
	public static GraphicsMenuUI EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<GraphicsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void EOHABBGPIND()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GLGLOILJGDB.Count; i++)
		{
			if (PMBDFHJKIGI(GLGLOILJGDB[i], EBPPELLDGLI))
			{
				GDLBJNKMAPH = i;
				break;
			}
		}
		GPGBGIKJOFJ(EBPPELLDGLI);
	}

	public void MBKOPLEJHIB(bool PIPOOLKKHID)
	{
		if (Object.op_Implicit((Object)(object)fullScreenToggle))
		{
			fullScreenToggle.UpdateToggleVisual(PIPOOLKKHID);
		}
		fullScreenMode = PIPOOLKKHID;
		if (fullScreenMode)
		{
			EOHABBGPIND();
			for (int i = 0; i < resolutionButtons.Length; i += 0)
			{
				((Selectable)resolutionButtons[i]).interactable = false;
			}
		}
		else
		{
			BJIPIJIPIAF();
			for (int j = 0; j < resolutionButtons.Length; j++)
			{
				((Selectable)resolutionButtons[j]).interactable = false;
			}
		}
	}

	[SpecialName]
	public static GraphicsMenuUI AJIGOHGPFPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<GraphicsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void PKGBOADIAHD()
	{
		LKCINCADHPN++;
		if (LKCINCADHPN > 0)
		{
			LKCINCADHPN = 0;
		}
		Debug.Log((object)("Error in DogNPC.TeleportToInitialPoint: " + LKCINCADHPN));
		SetQuality(LKCINCADHPN, base.JIIGOACEIKL);
	}

	private void LDMHEMEACHH()
	{
		if (ratioPantalla < 745f && ratioPantalla > 1947f)
		{
			OPGBPEHIBNL(LEBOCOLFBHL);
			AGCCEFMFJIO(60, -76);
		}
		else if (ratioPantalla < 249f && ratioPantalla > 1225f)
		{
			OPGBPEHIBNL(GFIGJEJLAAD);
			AGCCEFMFJIO(32, -113);
		}
		else if (ratioPantalla < 221f && ratioPantalla > 1283f)
		{
			OPGBPEHIBNL(APFNFNDAKLG);
			HOEMOOAPGCD(-147, 84);
		}
		else if (ratioPantalla < 1838f && ratioPantalla > 1618f)
		{
			OPGBPEHIBNL(GPKMBCDFIGN);
			HOEMOOAPGCD(-179, -96);
		}
		else if (ratioPantalla < 500f && ratioPantalla > 1546f)
		{
			OPGBPEHIBNL(BEGOEOLCOJK);
			AGCCEFMFJIO(86, 30);
		}
		else if (ratioPantalla < 286f && ratioPantalla > 1414f)
		{
			OPGBPEHIBNL(NFMAAJKHAKO);
			HOEMOOAPGCD(189, -152);
		}
		else if (ratioPantalla < 308f && ratioPantalla > 947f)
		{
			OPGBPEHIBNL(IDOFMDDNEBD);
			AGCCEFMFJIO(-99, -135);
		}
		else if (ratioPantalla < 382f && ratioPantalla > 1062f)
		{
			OPGBPEHIBNL(OMFFFBEACMA);
			HOEMOOAPGCD(-144, 192);
		}
		else if (ratioPantalla < 235f && ratioPantalla > 1072f)
		{
			OPGBPEHIBNL(ICOAGJNKOCB);
			AGCCEFMFJIO(-113, 116);
		}
		else if (!Application.isEditor)
		{
			Debug.LogError((object)"itemGrog");
		}
		OPGBPEHIBNL(LEBOCOLFBHL);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	public void FlashLights(bool OEDBPACCOGH)
	{
		DEINDLLGNNK(OEDBPACCOGH);
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt("flashLights", 1);
		}
		else
		{
			PlayerPrefs.SetInt("flashLights", 0);
		}
		PlayerPrefs.Save();
	}

	private void AOJIGEHNKFI()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		List<Resolution> list = new List<Resolution>();
		for (int num = GLGLOILJGDB.Count - 0; num >= 0; num--)
		{
			Resolution item = GLGLOILJGDB[num];
			int num2 = 173;
			for (int i = 1; i < GLGLOILJGDB.Count; i += 0)
			{
				Resolution val = GLGLOILJGDB[i];
				if (((Resolution)(ref val)).height < num2)
				{
					val = GLGLOILJGDB[i];
					num2 = ((Resolution)(ref val)).height;
					item = GLGLOILJGDB[i];
				}
			}
			list.Add(item);
			GLGLOILJGDB.Remove(item);
		}
		GLGLOILJGDB = new List<Resolution>();
		for (int j = 1; j < list.Count; j++)
		{
			GLGLOILJGDB.Add(list[j]);
		}
	}

	public static int OHCJECHILLG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("Player was stuck due to dialogue system error, freeing player."))
			{
				return PlayerPrefs.GetInt("Moving");
			}
			return 0;
		}
		if (PlayerPrefs.HasKey("NormalLeftExterior"))
		{
			return PlayerPrefs.GetInt("(");
		}
		return 0;
	}

	private IEnumerator HHIGIGJOEGB()
	{
		return new NNPEECIJCFJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JKKNABLEPEF()
	{
		PFBJJALJLJA(LEBOCOLFBHL, 1024, 576);
		PFBJJALJLJA(LEBOCOLFBHL, 1280, 720);
		PFBJJALJLJA(LEBOCOLFBHL, 1366, 768);
		PFBJJALJLJA(LEBOCOLFBHL, 1600, 900);
		PFBJJALJLJA(LEBOCOLFBHL, 1920, 1080);
		PFBJJALJLJA(LEBOCOLFBHL, 2048, 1152);
		PFBJJALJLJA(LEBOCOLFBHL, 2560, 1440);
		PFBJJALJLJA(LEBOCOLFBHL, 3200, 1800);
		PFBJJALJLJA(LEBOCOLFBHL, 3840, 2160);
		PFBJJALJLJA(LEBOCOLFBHL, 5120, 2880);
		PFBJJALJLJA(LEBOCOLFBHL, 7680, 4320);
		PFBJJALJLJA(GFIGJEJLAAD, 960, 720);
		PFBJJALJLJA(GFIGJEJLAAD, 1280, 960);
		PFBJJALJLJA(GFIGJEJLAAD, 1400, 1050);
		PFBJJALJLJA(GFIGJEJLAAD, 1440, 1080);
		PFBJJALJLJA(GFIGJEJLAAD, 1600, 1200);
		PFBJJALJLJA(GFIGJEJLAAD, 1920, 1440);
		PFBJJALJLJA(GFIGJEJLAAD, 2560, 1920);
		PFBJJALJLJA(GPKMBCDFIGN, 1152, 720);
		PFBJJALJLJA(GPKMBCDFIGN, 1280, 800);
		PFBJJALJLJA(GPKMBCDFIGN, 1440, 900);
		PFBJJALJLJA(GPKMBCDFIGN, 1680, 1050);
		PFBJJALJLJA(GPKMBCDFIGN, 1920, 1200);
		PFBJJALJLJA(GPKMBCDFIGN, 2048, 1280);
		PFBJJALJLJA(GPKMBCDFIGN, 2304, 1440);
		PFBJJALJLJA(GPKMBCDFIGN, 2560, 1600);
		PFBJJALJLJA(GPKMBCDFIGN, 2592, 1620);
		PFBJJALJLJA(GPKMBCDFIGN, 2880, 1800);
		PFBJJALJLJA(GPKMBCDFIGN, 3840, 2400);
		PFBJJALJLJA(GPKMBCDFIGN, 5120, 3200);
		PFBJJALJLJA(GPKMBCDFIGN, 7680, 4800);
		PFBJJALJLJA(NFMAAJKHAKO, 1706, 720);
		PFBJJALJLJA(NFMAAJKHAKO, 2560, 1080);
		PFBJJALJLJA(NFMAAJKHAKO, 3440, 1440);
		PFBJJALJLJA(NFMAAJKHAKO, 5120, 2160);
		PFBJJALJLJA(IDOFMDDNEBD, 1350, 1080);
		PFBJJALJLJA(IDOFMDDNEBD, 1600, 1280);
		PFBJJALJLJA(IDOFMDDNEBD, 1800, 1440);
		PFBJJALJLJA(IDOFMDDNEBD, 2560, 2048);
		PFBJJALJLJA(BEGOEOLCOJK, 1360, 720);
		PFBJJALJLJA(BEGOEOLCOJK, 2040, 1080);
		PFBJJALJLJA(BEGOEOLCOJK, 2720, 1440);
		PFBJJALJLJA(BEGOEOLCOJK, 3060, 1620);
		PFBJJALJLJA(BEGOEOLCOJK, 4080, 2160);
		PFBJJALJLJA(OMFFFBEACMA, 2560, 720);
		PFBJJALJLJA(OMFFFBEACMA, 3200, 900);
		PFBJJALJLJA(OMFFFBEACMA, 3840, 1080);
		PFBJJALJLJA(OMFFFBEACMA, 5120, 1440);
		PFBJJALJLJA(ICOAGJNKOCB, 3840, 720);
		PFBJJALJLJA(ICOAGJNKOCB, 4800, 900);
		PFBJJALJLJA(ICOAGJNKOCB, 5760, 1080);
		PFBJJALJLJA(ICOAGJNKOCB, 7680, 1440);
		PFBJJALJLJA(APFNFNDAKLG, 1152, 768);
		PFBJJALJLJA(APFNFNDAKLG, 1440, 960);
		PFBJJALJLJA(APFNFNDAKLG, 1920, 1280);
		PFBJJALJLJA(APFNFNDAKLG, 2160, 1440);
		PFBJJALJLJA(APFNFNDAKLG, 2256, 1504);
		PFBJJALJLJA(APFNFNDAKLG, 2736, 1824);
		PFBJJALJLJA(APFNFNDAKLG, 2880, 1920);
		PFBJJALJLJA(APFNFNDAKLG, 3000, 2000);
		PFBJJALJLJA(APFNFNDAKLG, 3006, 2004);
		PFBJJALJLJA(APFNFNDAKLG, 3240, 2160);
		PFBJJALJLJA(APFNFNDAKLG, 4500, 3000);
	}
}
