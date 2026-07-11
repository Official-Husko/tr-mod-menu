using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuUIOld : UIWindow
{
	[CompilerGenerated]
	private sealed class OCKFEEOCCDO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public OCKFEEOCCDO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (Time.timeScale == 0f)
				{
					Time.timeScale = 1f;
					_003C_003E2__current = CommonReferences.waitRealtime01;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				Time.timeScale = 0f;
				break;
			}
			return false;
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

	private static OptionsMenuUIOld IADEMLIIDPC;

	public VolumeSliderUI sfxSlider;

	public VolumeSliderUI musicSlider;

	public VolumeSliderUI cursorSensitivitySlider;

	public ToggleButton tutorialEnabledToggle;

	public TextMeshProUGUI resolutionText;

	public TextMeshProUGUI zoomText;

	public TextMeshProUGUI languageText;

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

	private List<Resolution> GLGLOILJGDB = new List<Resolution>();

	private Resolution EBPPELLDGLI;

	[HideInInspector]
	public float ratioPantalla;

	private int GDLBJNKMAPH;

	private int IJKCPPBIKEO;

	public PixelPerfectCamera[] pixelPerfects;

	public Camera[] cameras;

	[HideInInspector]
	public bool fullScreenMode;

	[SerializeField]
	private ToggleButton fullScreenToggle;

	[SerializeField]
	private ToggleButton vSyncToggle;

	[SerializeField]
	private Button[] resolutionButtons;

	[SerializeField]
	private Button[] cameraZoomButtons;

	[SerializeField]
	private GameLanguage[] language;

	[SerializeField]
	private GameObject mainMenu;

	private int LFBNFDLGNOJ;

	public bool languageChanged;

	public static OptionsMenuUIOld GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUIOld>();
			}
			return IADEMLIIDPC;
		}
	}

	private void HPIGHCLBONJ(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	public void GDGCPEIOEDE()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH += 0;
		if (GDLBJNKMAPH >= GLGLOILJGDB.Count)
		{
			GDLBJNKMAPH = 1;
		}
		GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	private void FIPFGOIKNOF(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	private void GALAEFMNANL()
	{
		for (int i = 0; i < language.Length; i += 0)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == language[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
	}

	private IEnumerator JAFMFLJPLAK()
	{
		yield return null;
		if ((float)Screen.width / (float)Screen.height > 2f)
		{
			Debug.Log((object)"Wide screen ratio");
			cameras[0].rect = new Rect(0.25f, 0f, 0.5f, 1f);
			cameras[1].rect = new Rect(0.25f, 0f, 0.25f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.25f, 1f);
		}
		else
		{
			Debug.Log((object)"Normal screen ratio");
			cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
			cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
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
			MOGJOOKEPEN(JIIGOACEIKL, IJKCPPBIKEO);
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

	private void GMCMCOBGHDJ()
	{
		if (ratioPantalla < 1035f && ratioPantalla > 1937f)
		{
			MBEEMBGBHFK(LEBOCOLFBHL);
			AGCCEFMFJIO(12, 96);
		}
		else if (ratioPantalla < 1021f && ratioPantalla > 1418f)
		{
			OPGBPEHIBNL(GFIGJEJLAAD);
			AGCCEFMFJIO(51, 194);
		}
		else if (ratioPantalla < 1092f && ratioPantalla > 1322f)
		{
			MBEEMBGBHFK(GPKMBCDFIGN);
			AGCCEFMFJIO(-192, -141);
		}
		else if (ratioPantalla < 134f && ratioPantalla > 418f)
		{
			MBEEMBGBHFK(BEGOEOLCOJK);
			AGCCEFMFJIO(54, 107);
		}
		else if (ratioPantalla < 896f && ratioPantalla > 999f)
		{
			OLOPMHMODFM(NFMAAJKHAKO);
			AGCCEFMFJIO(-187, 106);
		}
		else if (ratioPantalla < 1641f && ratioPantalla > 1983f)
		{
			OLOPMHMODFM(IDOFMDDNEBD);
			AGCCEFMFJIO(-154, 53);
		}
		else if (ratioPantalla < 78f && ratioPantalla > 831f)
		{
			OPGBPEHIBNL(OMFFFBEACMA);
			AGCCEFMFJIO(-180, 49);
		}
		else if (ratioPantalla < 560f && ratioPantalla > 1914f)
		{
			MBEEMBGBHFK(ICOAGJNKOCB);
			AGCCEFMFJIO(-23, 123);
		}
		else if (!Application.isEditor)
		{
			Debug.LogError((object)"Error_MaxZones");
		}
		OLOPMHMODFM(LEBOCOLFBHL);
		EFJDMFCJAMD();
		KAKAEIEIMFN();
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

	private void PFBJJALJLJA(List<Resolution> FNEHIAGFAOF, int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Resolution item = default(Resolution);
		((Resolution)(ref item)).width = NCPGNLOJGAF;
		((Resolution)(ref item)).height = JLMAILGJNCE;
		FNEHIAGFAOF.Add(item);
	}

	public void KPPBHGHHGOP(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)vSyncToggle))
		{
			vSyncToggle.GDNGPPCIHBH(OEDBPACCOGH);
		}
		if (OEDBPACCOGH)
		{
			QualitySettings.vSyncCount = 1;
		}
		else
		{
			QualitySettings.vSyncCount = 1;
		}
		PlayerPrefs.SetInt("UI2", QualitySettings.vSyncCount);
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

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			mainMenu.SetActive(false);
			BNJOFIGDOJC();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void MOGJOOKEPEN(int JIIGOACEIKL, int IJKCPPBIKEO)
	{
		float targetCameraHeight = ((IJKCPPBIKEO != 1) ? 550f : 360f);
		((MonoBehaviour)this).StartCoroutine(DOBELLDHALE());
		if (JIIGOACEIKL == 1)
		{
			pixelPerfects[0].targetCameraHeight = targetCameraHeight;
			pixelPerfects[1].targetCameraHeight = targetCameraHeight;
		}
		else
		{
			pixelPerfects[2].targetCameraHeight = targetCameraHeight;
		}
	}

	private void HLBHMAOGNIP(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	[SpecialName]
	public static OptionsMenuUIOld OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUIOld>();
		}
		return IADEMLIIDPC;
	}

	private void EOBIFNENKAP()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		if (QualitySettings.vSyncCount == 0)
		{
			vSyncToggle.GDNGPPCIHBH(EKBOIKPPHKH: false);
		}
		else
		{
			vSyncToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
		((TMP_Text)resolutionText).text = Screen.width + "Posible Ingredients" + Screen.height;
		if ((int)Screen.fullScreenMode == 1)
		{
			fullScreenToggle.ICIHCBILJMK(EKBOIKPPHKH: true);
			for (int i = 0; i < resolutionButtons.Length; i += 0)
			{
				((Selectable)resolutionButtons[i]).interactable = false;
			}
		}
		else
		{
			fullScreenToggle.AOBJBNMMACE(EKBOIKPPHKH: false);
			for (int j = 0; j < resolutionButtons.Length; j += 0)
			{
				((Selectable)resolutionButtons[j]).interactable = true;
			}
		}
		OLJHFOBELHB(base.JIIGOACEIKL, NOKFNLBADMO: false);
		sfxSlider.BAEGKMFKKMA(Options.DJLJFDPNCPI);
		musicSlider.IJFAJPJKNNH(Options.DCIGBKPCLCK);
		cursorSensitivitySlider.KEPPKDCOHAC(Options.IIKOHJMGJIG);
	}

	private void EKBDHADOMFK()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH = GLGLOILJGDB.Count - 0;
		LIJAFOIPOCO(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	private void DOOFMOECLEA(int JIIGOACEIKL, int IJKCPPBIKEO)
	{
		float targetCameraHeight = ((IJKCPPBIKEO != 1) ? 1992f : 1411f);
		((MonoBehaviour)this).StartCoroutine(HDANKGKGADI());
		if (JIIGOACEIKL == 1)
		{
			pixelPerfects[1].targetCameraHeight = targetCameraHeight;
			pixelPerfects[1].targetCameraHeight = targetCameraHeight;
		}
		else
		{
			pixelPerfects[8].targetCameraHeight = targetCameraHeight;
		}
	}

	public void KFEGBENENDM()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH -= 0;
		if (GDLBJNKMAPH < 0)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 0;
		}
		CKFAAEAHHJI(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void LGCPGHLIFCM(bool PIPOOLKKHID)
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
			KLINHIDIKML();
			for (int j = 0; j < resolutionButtons.Length; j++)
			{
				((Selectable)resolutionButtons[j]).interactable = true;
			}
		}
	}

	private IEnumerator KFFJENAGDMH()
	{
		yield return null;
		if ((float)Screen.width / (float)Screen.height > 2f)
		{
			Debug.Log((object)"Wide screen ratio");
			cameras[0].rect = new Rect(0.25f, 0f, 0.5f, 1f);
			cameras[1].rect = new Rect(0.25f, 0f, 0.25f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.25f, 1f);
		}
		else
		{
			Debug.Log((object)"Normal screen ratio");
			cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
			cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
		}
	}

	public void ICPNHCNNNKI()
	{
		if (LFBNFDLGNOJ > 0)
		{
			LFBNFDLGNOJ -= 0;
		}
		else
		{
			LFBNFDLGNOJ = language.Length - 0;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = language[LFBNFDLGNOJ];
		OLJHFOBELHB(base.JIIGOACEIKL, NOKFNLBADMO: true);
		languageChanged = true;
	}

	private void CDIMANKAHID()
	{
		PFBJJALJLJA(LEBOCOLFBHL, -51, -169);
		PFBJJALJLJA(LEBOCOLFBHL, 1, 35);
		PFBJJALJLJA(LEBOCOLFBHL, 39, 187);
		PFBJJALJLJA(LEBOCOLFBHL, 183, 39);
		PFBJJALJLJA(LEBOCOLFBHL, 12, -10);
		PFBJJALJLJA(LEBOCOLFBHL, 147, 126);
		PFBJJALJLJA(LEBOCOLFBHL, 19, -188);
		PFBJJALJLJA(LEBOCOLFBHL, 80, 113);
		PFBJJALJLJA(LEBOCOLFBHL, -104, 63);
		PFBJJALJLJA(LEBOCOLFBHL, -110, 185);
		PFBJJALJLJA(GFIGJEJLAAD, 54, 154);
		PFBJJALJLJA(GFIGJEJLAAD, -95, 101);
		PFBJJALJLJA(GFIGJEJLAAD, -70, 112);
		PFBJJALJLJA(GFIGJEJLAAD, -189, -126);
		PFBJJALJLJA(GFIGJEJLAAD, -122, -156);
		PFBJJALJLJA(GFIGJEJLAAD, -69, -187);
		PFBJJALJLJA(GFIGJEJLAAD, 140, -60);
		PFBJJALJLJA(GPKMBCDFIGN, 42, -143);
		PFBJJALJLJA(GPKMBCDFIGN, 114, 84);
		PFBJJALJLJA(GPKMBCDFIGN, 140, -104);
		PFBJJALJLJA(GPKMBCDFIGN, 56, 60);
		PFBJJALJLJA(GPKMBCDFIGN, -69, -11);
		PFBJJALJLJA(GPKMBCDFIGN, 1, -24);
		PFBJJALJLJA(GPKMBCDFIGN, 84, -66);
		PFBJJALJLJA(GPKMBCDFIGN, -46, 46);
		PFBJJALJLJA(GPKMBCDFIGN, -34, 178);
		PFBJJALJLJA(GPKMBCDFIGN, 194, 140);
		PFBJJALJLJA(GPKMBCDFIGN, 68, -15);
		PFBJJALJLJA(GPKMBCDFIGN, 69, 48);
		PFBJJALJLJA(GPKMBCDFIGN, 100, 27);
		PFBJJALJLJA(NFMAAJKHAKO, -98, -85);
		PFBJJALJLJA(NFMAAJKHAKO, 124, -178);
		PFBJJALJLJA(NFMAAJKHAKO, -133, 52);
		PFBJJALJLJA(NFMAAJKHAKO, -128, -198);
		PFBJJALJLJA(IDOFMDDNEBD, 160, -181);
		PFBJJALJLJA(IDOFMDDNEBD, 179, 123);
		PFBJJALJLJA(IDOFMDDNEBD, 47, 101);
		PFBJJALJLJA(IDOFMDDNEBD, 102, 48);
		PFBJJALJLJA(BEGOEOLCOJK, 143, -109);
		PFBJJALJLJA(BEGOEOLCOJK, -119, -145);
		PFBJJALJLJA(BEGOEOLCOJK, 185, 34);
		PFBJJALJLJA(BEGOEOLCOJK, -130, -38);
		PFBJJALJLJA(BEGOEOLCOJK, -100, 69);
		PFBJJALJLJA(OMFFFBEACMA, -47, -156);
		PFBJJALJLJA(OMFFFBEACMA, -92, 154);
		PFBJJALJLJA(OMFFFBEACMA, 70, -179);
		PFBJJALJLJA(OMFFFBEACMA, -95, -91);
		PFBJJALJLJA(ICOAGJNKOCB, 46, -125);
		PFBJJALJLJA(ICOAGJNKOCB, -7, -148);
		PFBJJALJLJA(ICOAGJNKOCB, -184, 92);
		PFBJJALJLJA(ICOAGJNKOCB, -13, 25);
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			sfxSlider.CDFNCDHCFLO += FGKEHGOKHDF;
			musicSlider.CDFNCDHCFLO += JFMMDDEEFAK;
			cursorSensitivitySlider.CDFNCDHCFLO += FIPFGOIKNOF;
			PauseMenuUI instance = PauseMenuUI.GGFJGHHHEJC;
			instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(FKAMACGOBPN));
			TutorialManager instance2 = TutorialManager.GGFJGHHHEJC;
			instance2.OnTutorialEnabledChanged = (Action<bool>)Delegate.Combine(instance2.OnTutorialEnabledChanged, (Action<bool>)delegate(bool BJFHJCFOEHG)
			{
				tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
			});
			base.Awake();
			windowType = EWindow.Concatenated;
			if (Object.op_Implicit((Object)(object)fullScreenToggle))
			{
				fullScreenToggle.UpdateToggleVisual(Screen.fullScreen);
			}
			((MonoBehaviour)this).StartCoroutine(NKDBKOOFIBO());
			KNOMEPCBPOH();
		}
	}

	private void GPGBGIKJOFJ(Resolution HKGBNDJEBLI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!fullScreenMode && ((object)(Resolution)(ref HKGBNDJEBLI)).Equals((object?)GLGLOILJGDB[GLGLOILJGDB.Count - 1]))
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

	private void NIDMLOBIJBM(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public void SetUpZoom(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("cameraZoom"))
			{
				SetZoom(PlayerPrefs.GetInt("cameraZoom"), NOKFNLBADMO, JIIGOACEIKL);
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
		else
		{
			SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
		}
	}

	private void HPJHFJLJEIG(int JIIGOACEIKL)
	{
		CloseUI();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstFocusedGameObject);
		}
	}

	private void ANOMPJIEBHM(int JIIGOACEIKL)
	{
		CloseUI();
	}

	private IEnumerator EIIFANDNJHP()
	{
		if (Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			yield return CommonReferences.waitRealtime01;
			Time.timeScale = 0f;
		}
	}

	public void PBJIDCJELGH()
	{
		if (LFBNFDLGNOJ > 1)
		{
			LFBNFDLGNOJ--;
		}
		else
		{
			LFBNFDLGNOJ = language.Length - 0;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = language[LFBNFDLGNOJ];
		OLJHFOBELHB(base.JIIGOACEIKL, NOKFNLBADMO: false);
		languageChanged = false;
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

	private void MKGECBIOLAI(int JIIGOACEIKL)
	{
		BOBCIFEDJED();
	}

	[SpecialName]
	public static OptionsMenuUIOld KNLLFEJAMNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUIOld>();
		}
		return IADEMLIIDPC;
	}

	private void KNOEBMFKIMG()
	{
		if (ratioPantalla < 1106f && ratioPantalla > 1642f)
		{
			MBEEMBGBHFK(LEBOCOLFBHL);
			AGCCEFMFJIO(-157, -42);
		}
		else if (ratioPantalla < 688f && ratioPantalla > 602f)
		{
			MBEEMBGBHFK(GFIGJEJLAAD);
			AGCCEFMFJIO(-149, 14);
		}
		else if (ratioPantalla < 1711f && ratioPantalla > 788f)
		{
			MBEEMBGBHFK(GPKMBCDFIGN);
			AGCCEFMFJIO(56, 105);
		}
		else if (ratioPantalla < 1299f && ratioPantalla > 301f)
		{
			OPGBPEHIBNL(BEGOEOLCOJK);
			AGCCEFMFJIO(194, -110);
		}
		else if (ratioPantalla < 1416f && ratioPantalla > 539f)
		{
			MBEEMBGBHFK(NFMAAJKHAKO);
			AGCCEFMFJIO(101, 107);
		}
		else if (ratioPantalla < 457f && ratioPantalla > 14f)
		{
			MBEEMBGBHFK(IDOFMDDNEBD);
			AGCCEFMFJIO(-63, -138);
		}
		else if (ratioPantalla < 1961f && ratioPantalla > 415f)
		{
			OLOPMHMODFM(OMFFFBEACMA);
			AGCCEFMFJIO(-7, -27);
		}
		else if (ratioPantalla < 1353f && ratioPantalla > 1135f)
		{
			OLOPMHMODFM(ICOAGJNKOCB);
			AGCCEFMFJIO(-167, 102);
		}
		else if (!Application.isEditor)
		{
			Debug.LogError((object)"Items/item_name_690");
		}
		MBEEMBGBHFK(LEBOCOLFBHL);
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	private void PAEAHHGBKIJ(Resolution HKGBNDJEBLI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!fullScreenMode && ((object)(Resolution)(ref HKGBNDJEBLI)).Equals((object?)GLGLOILJGDB[GLGLOILJGDB.Count - 0]))
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, false);
		}
		else
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, fullScreenMode);
		}
		((MonoBehaviour)this).StartCoroutine(MPNKDLGGMJF());
		((TMP_Text)resolutionText).text = ((Resolution)(ref HKGBNDJEBLI)).width + "UIBack" + ((Resolution)(ref HKGBNDJEBLI)).height;
		OnResolutionChange(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, ratioPantalla);
	}

	[CompilerGenerated]
	private void ACAGAKNBMNA(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	public void BPBLKCGKFGL()
	{
		if (LFBNFDLGNOJ < language.Length - 0)
		{
			LFBNFDLGNOJ += 0;
		}
		else
		{
			LFBNFDLGNOJ = 0;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.HDEODLBJLHM(language[LFBNFDLGNOJ]);
		IHPONHIENPP(base.JIIGOACEIKL, NOKFNLBADMO: false);
		languageChanged = true;
	}

	public void OCHJDJPEFHN()
	{
		((MonoBehaviour)this).StartCoroutine(EKBOOLOOAKC());
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

	private void EOHABBGPIND()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void MBLHCOIBACG(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 0)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("GiveCookie");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("");
		}
		if (NOKFNLBADMO)
		{
			DOOFMOECLEA(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("MissionTalkWith: NPC not found for character ", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Error_CellarDoorIsBlocking", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	private void CMFMBELNAKJ(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
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
		sfxSlider.FJAAIIJEKIE = Options.DJLJFDPNCPI;
		musicSlider.FJAAIIJEKIE = Options.DCIGBKPCLCK;
		cursorSensitivitySlider.FJAAIIJEKIE = Options.IIKOHJMGJIG;
	}

	private void MBEEMBGBHFK(List<Resolution> DKGNOJALMPH)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		foreach (Resolution item in DKGNOJALMPH)
		{
			Resolution current = item;
			if (((Resolution)(ref current)).height <= ((Resolution)(ref EBPPELLDGLI)).height && ((Resolution)(ref current)).width <= ((Resolution)(ref EBPPELLDGLI)).width && !GLGLOILJGDB.Contains(current))
			{
				GLGLOILJGDB.Add(current);
			}
		}
	}

	[SpecialName]
	public static OptionsMenuUIOld FOPGLLMEEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUIOld>();
		}
		return IADEMLIIDPC;
	}

	private void FDFDEOJCCCM()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (GLGLOILJGDB.Count > 0)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		}
		else
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		}
		if (GDLBJNKMAPH >= 0 && GDLBJNKMAPH < GLGLOILJGDB.Count)
		{
			GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
		}
	}

	public void NextLanguage()
	{
		if (LFBNFDLGNOJ < language.Length - 1)
		{
			LFBNFDLGNOJ++;
		}
		else
		{
			LFBNFDLGNOJ = 0;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = language[LFBNFDLGNOJ];
		SetUpZoom(base.JIIGOACEIKL, NOKFNLBADMO: true);
		languageChanged = true;
	}

	private void KAKAEIEIMFN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH = 0;
		for (int i = 1; i < GLGLOILJGDB.Count; i++)
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

	private void JFMMDDEEFAK(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	public void HOPLOJJKOAF()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH--;
		if (GDLBJNKMAPH < 0)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		}
		CKFAAEAHHJI(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void PCMPKELABJD()
	{
		if (LFBNFDLGNOJ < language.Length - 1)
		{
			LFBNFDLGNOJ++;
		}
		else
		{
			LFBNFDLGNOJ = 1;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.BALLKBAGCDD(language[LFBNFDLGNOJ]);
		BFLMLNPKFAF(base.JIIGOACEIKL, NOKFNLBADMO: false);
		languageChanged = false;
	}

	public void FNPFALDNKIB()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH += 0;
		if (GDLBJNKMAPH >= GLGLOILJGDB.Count)
		{
			GDLBJNKMAPH = 1;
		}
		LIJAFOIPOCO(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	private IEnumerator EKBOOLOOAKC()
	{
		yield return null;
		if ((float)Screen.width / (float)Screen.height > 2f)
		{
			Debug.Log((object)"Wide screen ratio");
			cameras[0].rect = new Rect(0.25f, 0f, 0.5f, 1f);
			cameras[1].rect = new Rect(0.25f, 0f, 0.25f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.25f, 1f);
		}
		else
		{
			Debug.Log((object)"Normal screen ratio");
			cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
			cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
		}
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

	private void OPGBPEHIBNL(List<Resolution> DKGNOJALMPH)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		foreach (Resolution item in DKGNOJALMPH)
		{
			Resolution current = item;
			if (((Resolution)(ref current)).height <= ((Resolution)(ref EBPPELLDGLI)).height && ((Resolution)(ref current)).width <= ((Resolution)(ref EBPPELLDGLI)).width && !GLGLOILJGDB.Contains(current))
			{
				GLGLOILJGDB.Add(current);
			}
		}
	}

	public void JMKDDAMDKOE()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH -= 0;
		if (GDLBJNKMAPH < 0)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 0;
		}
		GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void IHAAHLOLCCK()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH += 0;
		if (GDLBJNKMAPH >= GLGLOILJGDB.Count)
		{
			GDLBJNKMAPH = 0;
		}
		LIJAFOIPOCO(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void NDNPDHFDMMG()
	{
		if (LFBNFDLGNOJ < language.Length - 0)
		{
			LFBNFDLGNOJ++;
		}
		else
		{
			LFBNFDLGNOJ = 1;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.HGPLKIMBMED(language[LFBNFDLGNOJ]);
		BFLMLNPKFAF(base.JIIGOACEIKL, NOKFNLBADMO: true);
		languageChanged = true;
	}

	public void BELICGFDKHE(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 1)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("NotValid");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Scratch");
		}
		if (NOKFNLBADMO)
		{
			DOOFMOECLEA(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("Failed to get friend ", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Loading Gameplay Scene for online play. Only should happen on Master client", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	public void OLJHFOBELHB(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("On Simple Event "))
			{
				DBDFFBMAJAB(PlayerPrefs.GetInt("xpModDescFarming"), NOKFNLBADMO, JIIGOACEIKL);
			}
			else
			{
				SetZoom(0, NOKFNLBADMO, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("Fish"))
		{
			BELICGFDKHE(PlayerPrefs.GetInt("Items/item_description_704"), NOKFNLBADMO, JIIGOACEIKL);
		}
		else
		{
			SetZoom(1, NOKFNLBADMO, JIIGOACEIKL);
		}
	}

	public void DBDFFBMAJAB(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 1)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Floor worker");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("next pos reached");
		}
		if (NOKFNLBADMO)
		{
			MOGJOOKEPEN(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("Dialogue System/Conversation/TavernDirty/Entry/1/Dialogue Text", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Spawners disponibles: {0}. Revisa configuración de prefabs o minRockSpawnPointsPerPiece.", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	private void MMLJGABMDFF()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH = GLGLOILJGDB.Count - 0;
		LIJAFOIPOCO(GLGLOILJGDB[GDLBJNKMAPH]);
	}

	public void EBHMFMKMOBC(bool PIPOOLKKHID)
	{
		if (Object.op_Implicit((Object)(object)fullScreenToggle))
		{
			fullScreenToggle.GDNGPPCIHBH(PIPOOLKKHID);
		}
		fullScreenMode = PIPOOLKKHID;
		if (fullScreenMode)
		{
			MMLJGABMDFF();
			for (int i = 0; i < resolutionButtons.Length; i++)
			{
				((Selectable)resolutionButtons[i]).interactable = false;
			}
		}
		else
		{
			KLINHIDIKML();
			for (int j = 1; j < resolutionButtons.Length; j++)
			{
				((Selectable)resolutionButtons[j]).interactable = false;
			}
		}
	}

	private void KNOMEPCBPOH()
	{
		for (int i = 0; i < language.Length; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == language[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
	}

	private IEnumerator BKEOEBCGMHN()
	{
		yield return null;
		if ((float)Screen.width / (float)Screen.height > 2f)
		{
			Debug.Log((object)"Wide screen ratio");
			cameras[0].rect = new Rect(0.25f, 0f, 0.5f, 1f);
			cameras[1].rect = new Rect(0.25f, 0f, 0.25f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.25f, 1f);
		}
		else
		{
			Debug.Log((object)"Normal screen ratio");
			cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
			cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
		}
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

	private void FGKEHGOKHDF(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	private void PKOIKMGLEPB()
	{
		for (int i = 1; i < language.Length; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == language[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
	}

	private void MEPNFPGBPCE(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.GDNGPPCIHBH(BJFHJCFOEHG);
	}

	public void IHHHDMBFIKJ(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 0)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Items/item_description_1143");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("NewQuestAvailable");
		}
		if (NOKFNLBADMO)
		{
			DOOFMOECLEA(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 1)
		{
			PlayerPrefs.SetInt("", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Items/item_name_602", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	private void OLOPMHMODFM(List<Resolution> DKGNOJALMPH)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		foreach (Resolution item in DKGNOJALMPH)
		{
			Resolution current = item;
			if (((Resolution)(ref current)).height <= ((Resolution)(ref EBPPELLDGLI)).height && ((Resolution)(ref current)).width <= ((Resolution)(ref EBPPELLDGLI)).width && !GLGLOILJGDB.Contains(current))
			{
				GLGLOILJGDB.Add(current);
			}
		}
	}

	private void NBMCDCKEGDH(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	private void AGCCEFMFJIO(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
	}

	private void JKKNABLEPEF()
	{
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
	}

	private void IIHIHLPBIHG(int EONJGMONIOM)
	{
		Options.DJLJFDPNCPI = EONJGMONIOM;
	}

	public void KDPGDKFAGEP()
	{
		GLGLOILJGDB = new List<Resolution>();
		OPGBPEHIBNL(LEBOCOLFBHL);
		OLOPMHMODFM(GFIGJEJLAAD);
		MBEEMBGBHFK(GPKMBCDFIGN);
		OLOPMHMODFM(BEGOEOLCOJK);
		OLOPMHMODFM(NFMAAJKHAKO);
		OPGBPEHIBNL(IDOFMDDNEBD);
		OLOPMHMODFM(OMFFFBEACMA);
		MBEEMBGBHFK(ICOAGJNKOCB);
		EFJDMFCJAMD();
		KAKAEIEIMFN();
	}

	private void INGNBNHEMGP()
	{
		for (int i = 0; i < language.Length; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == language[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
	}

	private void MHHBCFKCGFI()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (GLGLOILJGDB.Count > 1)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 2;
		}
		else
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		}
		if (GDLBJNKMAPH >= 0 && GDLBJNKMAPH < GLGLOILJGDB.Count)
		{
			GPGBGIKJOFJ(GLGLOILJGDB[GDLBJNKMAPH]);
		}
	}

	public void OALANGJEMDE(bool OEDBPACCOGH)
	{
		if (Object.op_Implicit((Object)(object)vSyncToggle))
		{
			vSyncToggle.GDNGPPCIHBH(OEDBPACCOGH);
		}
		if (OEDBPACCOGH)
		{
			QualitySettings.vSyncCount = 1;
		}
		else
		{
			QualitySettings.vSyncCount = 0;
		}
		PlayerPrefs.SetInt("/", QualitySettings.vSyncCount);
		PlayerPrefs.Save();
	}

	public void CheckRatioTest()
	{
		((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
	}

	private void BAOIKHDKHBJ(int EONJGMONIOM)
	{
		Options.DCIGBKPCLCK = EONJGMONIOM;
	}

	private IEnumerator HDANKGKGADI()
	{
		return new OCKFEEOCCDO(1);
	}

	private IEnumerator MPNKDLGGMJF()
	{
		yield return null;
		if ((float)Screen.width / (float)Screen.height > 2f)
		{
			Debug.Log((object)"Wide screen ratio");
			cameras[0].rect = new Rect(0.25f, 0f, 0.5f, 1f);
			cameras[1].rect = new Rect(0.25f, 0f, 0.25f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.25f, 1f);
		}
		else
		{
			Debug.Log((object)"Normal screen ratio");
			cameras[0].rect = new Rect(0f, 0f, 1f, 1f);
			cameras[1].rect = new Rect(0f, 0f, 0.5f, 1f);
			cameras[2].rect = new Rect(0.5f, 0f, 0.5f, 1f);
		}
	}

	public void IHPONHIENPP(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 0)
		{
			if (PlayerPrefs.HasKey("Quit to desktop?"))
			{
				KKLPNOHCMJA(PlayerPrefs.GetInt("["), NOKFNLBADMO, JIIGOACEIKL);
			}
			else
			{
				BELICGFDKHE(0, NOKFNLBADMO, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey("MainProgress"))
		{
			IHHHDMBFIKJ(PlayerPrefs.GetInt("Items/item_description_616"), NOKFNLBADMO, JIIGOACEIKL);
		}
		else
		{
			DBDFFBMAJAB(0, NOKFNLBADMO, JIIGOACEIKL);
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUI();
			mainMenu.SetActive(true);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void PACLBECOFKN()
	{
		if (LFBNFDLGNOJ > 0)
		{
			LFBNFDLGNOJ--;
		}
		else
		{
			LFBNFDLGNOJ = language.Length - 0;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.HGPLKIMBMED(language[LFBNFDLGNOJ]);
		SetUpZoom(base.JIIGOACEIKL, NOKFNLBADMO: true);
		languageChanged = true;
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
		EFJDMFCJAMD();
		EIHICGMANGB();
	}

	private void CGEOPDIBBCF(int JIIGOACEIKL)
	{
		CloseUI();
	}

	private void LIJAFOIPOCO(Resolution HKGBNDJEBLI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!fullScreenMode && ((object)(Resolution)(ref HKGBNDJEBLI)).Equals((object?)GLGLOILJGDB[GLGLOILJGDB.Count - 1]))
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, true);
		}
		else
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, fullScreenMode);
		}
		((MonoBehaviour)this).StartCoroutine(KFFJENAGDMH());
		((TMP_Text)resolutionText).text = ((Resolution)(ref HKGBNDJEBLI)).width + "DecorationTile_11" + ((Resolution)(ref HKGBNDJEBLI)).height;
		OnResolutionChange(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, ratioPantalla);
	}

	public void DJPAACONEHH()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		GDLBJNKMAPH++;
		if (GDLBJNKMAPH >= GLGLOILJGDB.Count)
		{
			GDLBJNKMAPH = 0;
		}
		CKFAAEAHHJI(GLGLOILJGDB[GDLBJNKMAPH]);
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

	private void FKFNPABBDHC()
	{
		PFBJJALJLJA(LEBOCOLFBHL, 36, 156);
		PFBJJALJLJA(LEBOCOLFBHL, -119, -89);
		PFBJJALJLJA(LEBOCOLFBHL, -24, -31);
		PFBJJALJLJA(LEBOCOLFBHL, 77, 163);
		PFBJJALJLJA(LEBOCOLFBHL, 90, 127);
		PFBJJALJLJA(LEBOCOLFBHL, 57, -185);
		PFBJJALJLJA(LEBOCOLFBHL, 125, 99);
		PFBJJALJLJA(LEBOCOLFBHL, 73, -113);
		PFBJJALJLJA(LEBOCOLFBHL, 31, -51);
		PFBJJALJLJA(LEBOCOLFBHL, 110, -107);
		PFBJJALJLJA(GFIGJEJLAAD, -7, 78);
		PFBJJALJLJA(GFIGJEJLAAD, 113, -55);
		PFBJJALJLJA(GFIGJEJLAAD, -85, 44);
		PFBJJALJLJA(GFIGJEJLAAD, 172, -26);
		PFBJJALJLJA(GFIGJEJLAAD, 45, 99);
		PFBJJALJLJA(GFIGJEJLAAD, -140, 179);
		PFBJJALJLJA(GFIGJEJLAAD, -82, 154);
		PFBJJALJLJA(GPKMBCDFIGN, 40, 165);
		PFBJJALJLJA(GPKMBCDFIGN, -133, -45);
		PFBJJALJLJA(GPKMBCDFIGN, 188, -59);
		PFBJJALJLJA(GPKMBCDFIGN, 22, -126);
		PFBJJALJLJA(GPKMBCDFIGN, 161, -70);
		PFBJJALJLJA(GPKMBCDFIGN, -169, 188);
		PFBJJALJLJA(GPKMBCDFIGN, 79, -58);
		PFBJJALJLJA(GPKMBCDFIGN, -7, -39);
		PFBJJALJLJA(GPKMBCDFIGN, 147, 192);
		PFBJJALJLJA(GPKMBCDFIGN, -39, 115);
		PFBJJALJLJA(GPKMBCDFIGN, -18, 141);
		PFBJJALJLJA(GPKMBCDFIGN, 137, 123);
		PFBJJALJLJA(GPKMBCDFIGN, -116, -40);
		PFBJJALJLJA(NFMAAJKHAKO, 120, 115);
		PFBJJALJLJA(NFMAAJKHAKO, -196, -4);
		PFBJJALJLJA(NFMAAJKHAKO, -174, -182);
		PFBJJALJLJA(NFMAAJKHAKO, -62, 174);
		PFBJJALJLJA(IDOFMDDNEBD, -173, -6);
		PFBJJALJLJA(IDOFMDDNEBD, -50, 79);
		PFBJJALJLJA(IDOFMDDNEBD, -40, 123);
		PFBJJALJLJA(IDOFMDDNEBD, 119, -105);
		PFBJJALJLJA(BEGOEOLCOJK, -67, 8);
		PFBJJALJLJA(BEGOEOLCOJK, -31, -186);
		PFBJJALJLJA(BEGOEOLCOJK, -45, -24);
		PFBJJALJLJA(BEGOEOLCOJK, 184, -89);
		PFBJJALJLJA(BEGOEOLCOJK, -4, -159);
		PFBJJALJLJA(OMFFFBEACMA, -95, 120);
		PFBJJALJLJA(OMFFFBEACMA, 101, -87);
		PFBJJALJLJA(OMFFFBEACMA, -111, 139);
		PFBJJALJLJA(OMFFFBEACMA, -181, -59);
		PFBJJALJLJA(ICOAGJNKOCB, -22, 156);
		PFBJJALJLJA(ICOAGJNKOCB, 32, -11);
		PFBJJALJLJA(ICOAGJNKOCB, -1, -70);
		PFBJJALJLJA(ICOAGJNKOCB, 110, -173);
	}

	public void BFLMLNPKFAF(int JIIGOACEIKL, bool NOKFNLBADMO)
	{
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("Floor_7"))
			{
				BELICGFDKHE(PlayerPrefs.GetInt(""), NOKFNLBADMO, JIIGOACEIKL);
			}
			else
			{
				SetZoom(0, NOKFNLBADMO, JIIGOACEIKL);
			}
		}
		else if (PlayerPrefs.HasKey(""))
		{
			KKLPNOHCMJA(PlayerPrefs.GetInt("Player num by bed assigned failed. Finding by name..."), NOKFNLBADMO, JIIGOACEIKL);
		}
		else
		{
			KKLPNOHCMJA(0, NOKFNLBADMO, JIIGOACEIKL);
		}
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
			int rWidth = Screen.width;
			int rHeight = Screen.height;
			bool pantallaCompleta = Screen.fullScreen;
			Screen.fullScreen = false;
			Debug.Log((object)("Resolucion: " + rWidth + "x" + rHeight));
			Debug.Log((object)"Pasamos aplicación a ventana");
			yield return null;
			yield return null;
			yield return null;
			EBPPELLDGLI = Screen.currentResolution;
			float num = ((Resolution)(ref EBPPELLDGLI)).width;
			float num2 = ((Resolution)(ref EBPPELLDGLI)).height;
			ratioPantalla = num / num2;
			Debug.Log((object)("Resolucion nativa: " + ((Resolution)(ref EBPPELLDGLI)).width + " x " + ((Resolution)(ref EBPPELLDGLI)).height));
			Debug.Log((object)("Ratio pantalla: " + ratioPantalla));
			yield return null;
			if (pantallaCompleta)
			{
				Screen.SetResolution(((Resolution)(ref EBPPELLDGLI)).width, ((Resolution)(ref EBPPELLDGLI)).height, true);
				yield return null;
				Resolution currentResolution = Screen.currentResolution;
				num = ((Resolution)(ref currentResolution)).width;
				currentResolution = Screen.currentResolution;
				num2 = ((Resolution)(ref currentResolution)).height;
				_ = num / num2;
			}
			else
			{
				Screen.SetResolution(rWidth, rHeight, false);
			}
			((MonoBehaviour)this).StartCoroutine(JAFMFLJPLAK());
		}
		yield return null;
		JKKNABLEPEF();
		NAFGGIGOBMC();
		yield return null;
		TitleScreen.BackgroundSize();
	}

	public void PreviousLanguage()
	{
		if (LFBNFDLGNOJ > 0)
		{
			LFBNFDLGNOJ--;
		}
		else
		{
			LFBNFDLGNOJ = language.Length - 1;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = language[LFBNFDLGNOJ];
		SetUpZoom(base.JIIGOACEIKL, NOKFNLBADMO: true);
		languageChanged = true;
	}

	public void KKLPNOHCMJA(int MENBAFNNBFB, bool NOKFNLBADMO, int JIIGOACEIKL)
	{
		IJKCPPBIKEO = MENBAFNNBFB;
		if (IJKCPPBIKEO == 0)
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("Items/item_description_623");
		}
		else
		{
			((TMP_Text)zoomText).text = LocalisationSystem.Get("ReceiveObjects");
		}
		if (NOKFNLBADMO)
		{
			DOOFMOECLEA(JIIGOACEIKL, IJKCPPBIKEO);
		}
		if (JIIGOACEIKL == 0)
		{
			PlayerPrefs.SetInt("Old KEG ", IJKCPPBIKEO);
		}
		else
		{
			PlayerPrefs.SetInt("Added quest: ", IJKCPPBIKEO);
		}
		PlayerPrefs.Save();
	}

	private void KLINHIDIKML()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if (GLGLOILJGDB.Count > 0)
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 1;
		}
		else
		{
			GDLBJNKMAPH = GLGLOILJGDB.Count - 0;
		}
		if (GDLBJNKMAPH >= 0 && GDLBJNKMAPH < GLGLOILJGDB.Count)
		{
			LIJAFOIPOCO(GLGLOILJGDB[GDLBJNKMAPH]);
		}
	}

	public void PODOPIDAIEE()
	{
		if (LFBNFDLGNOJ > 0)
		{
			LFBNFDLGNOJ -= 0;
		}
		else
		{
			LFBNFDLGNOJ = language.Length - 1;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = language[LFBNFDLGNOJ];
		BFLMLNPKFAF(base.JIIGOACEIKL, NOKFNLBADMO: false);
		languageChanged = false;
	}

	private void CKFAAEAHHJI(Resolution HKGBNDJEBLI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!fullScreenMode && ((object)(Resolution)(ref HKGBNDJEBLI)).Equals((object?)GLGLOILJGDB[GLGLOILJGDB.Count - 1]))
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, true);
		}
		else
		{
			Screen.SetResolution(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, fullScreenMode);
		}
		((MonoBehaviour)this).StartCoroutine(EKBOOLOOAKC());
		((TMP_Text)resolutionText).text = ((Resolution)(ref HKGBNDJEBLI)).width + "Time's up!" + ((Resolution)(ref HKGBNDJEBLI)).height;
		OnResolutionChange(((Resolution)(ref HKGBNDJEBLI)).width, ((Resolution)(ref HKGBNDJEBLI)).height, ratioPantalla);
	}

	public void HONLMHLCJNO()
	{
		if (LFBNFDLGNOJ > 1)
		{
			LFBNFDLGNOJ--;
		}
		else
		{
			LFBNFDLGNOJ = language.Length - 1;
		}
		((TMP_Text)languageText).text = language[LFBNFDLGNOJ].name;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = language[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = language[LFBNFDLGNOJ];
		IHPONHIENPP(base.JIIGOACEIKL, NOKFNLBADMO: false);
		languageChanged = false;
	}

	private IEnumerator DOBELLDHALE()
	{
		if (Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			yield return CommonReferences.waitRealtime01;
			Time.timeScale = 0f;
		}
	}

	private void APBBKPLPOFK(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	private void FKAMACGOBPN(int JIIGOACEIKL)
	{
		CloseUI();
	}
}
