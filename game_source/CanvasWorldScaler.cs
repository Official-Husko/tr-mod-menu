using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Canvas))]
public class CanvasWorldScaler : MonoBehaviour
{
	[Tooltip("A camera that uses the PixelPerfectCamera script")]
	public Camera uiCamera;

	private PixelPerfectCamera MIBOLKMCJDM;

	private Vector2 FOOMPFIKPPK;

	private float FLALIJMIEBE;

	private Canvas BJPJKLLJAIA;

	private bool EEDGMFLBODE;

	private void JMLFLDCEGHH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 631f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1217f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1490f / FLALIJMIEBE;
			localScale.y = 1927f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void MNEAOFNAKIP()
	{
		EHGLJMKEJKE(BBHEMAPJGJM: false);
	}

	private void AGFLPEOOEAM()
	{
		NAAMONCFKMB(BBHEMAPJGJM: true);
	}

	private void ELPCMDCKLGN()
	{
		HJCOAJEIABK(BBHEMAPJGJM: false);
	}

	private void PMMGCDBMMMN()
	{
		NHINIAECHNC(BBHEMAPJGJM: true);
	}

	private void EHGLJMKEJKE(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 5)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)(" aging rank (" + ((object)(RenderMode)(ref renderMode)).ToString() + "/"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Throw");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Gameplay");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			CPIDOLGGPFJ();
		}
	}

	private void BEMHJMDDNKC(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 0)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("FinalTest/MainEvent" + ((object)(RenderMode)(ref renderMode)).ToString() + "Items/item_name_692"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"MinusMoneyMaterials ");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"ChatWelcomeToTavern");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			JMLFLDCEGHH();
		}
	}

	private void EPCDDJGINNA()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1485f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1218f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1006f / FLALIJMIEBE;
			localScale.y = 691f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void JECHFBHEOEF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 614f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1823f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 233f / FLALIJMIEBE;
			localScale.y = 1520f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void IANGDMHMCEL()
	{
		DJDAJEOOJMI(BBHEMAPJGJM: true);
	}

	private void IAICCKPOBMJ()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			AJPLCFDGBLA(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			CPIDOLGGPFJ();
		}
	}

	private void FHCBGJOPILC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1050f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1046f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 787f / FLALIJMIEBE;
			localScale.y = 1976f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void EEKOFIEBCPL(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 3)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("TooHot" + ((object)(RenderMode)(ref renderMode)).ToString() + "BLOCKS NUMBER: {0} Puzzle Needit: {1}"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"[");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"ReceiveAnimalWalk");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			CEEDDFCBCNG();
		}
	}

	private void EELJCLNJDDD(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 3)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)(" " + ((object)(RenderMode)(ref renderMode)).ToString() + "MainProgress"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Items/item_name_1071");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Pick Level Low");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			EPCDDJGINNA();
		}
	}

	private void FMEPCJNPHLH(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Items/item_name_703" + ((object)(RenderMode)(ref renderMode)).ToString() + "<color=#BF0000>"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"[Brown");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Crop needs a harvested replace by item ");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			OJCAPDGLHPC();
		}
	}

	private void OBNJPLBFJKM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1209f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1569f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 205f / FLALIJMIEBE;
			localScale.y = 363f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void BCLDCMPJGMM()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 502f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1019f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1865f / FLALIJMIEBE;
			localScale.y = 852f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void BANMLJCLKEJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 100f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1288f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 213f / FLALIJMIEBE;
			localScale.y = 687f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void MCLAJGDIIBK()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			FMEPCJNPHLH(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 4 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			LAJLMAOEIMN();
		}
	}

	private void PEIFJDIGKOC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			CEGECEJOPJD(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			BCLDCMPJGMM();
		}
	}

	private void ADDLDNPHIHF()
	{
		PCGKLLGNOGH(BBHEMAPJGJM: false);
	}

	private void AJPLCFDGBLA(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("RequestNPCPositionAndParent" + ((object)(RenderMode)(ref renderMode)).ToString() + "Game"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Left Stick Down");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"[^0-9]");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			BCLDCMPJGMM();
		}
	}

	private void PKEPBKHEDOD()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			CEGECEJOPJD(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 6 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			CLGINBGKFDE();
		}
	}

	private void PCGKLLGNOGH(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 2)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("InteractPlaceableIfIsPossibleMaster" + ((object)(RenderMode)(ref renderMode)).ToString() + " not found in OnlineEventsManager. Cannot start observe dialogue"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"ReceiveRequestChallengeRestart");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"ReciveActivateCustomers");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PCBBLGAEHHG();
		}
	}

	private void GHEOLMMHFJC()
	{
		EHGLJMKEJKE(BBHEMAPJGJM: false);
	}

	private void NAAMONCFKMB(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 1)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)(", " + ((object)(RenderMode)(ref renderMode)).ToString() + "cheeseAgeingRackPopUp"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Received begin minigame");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"UpgradeToLevel");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			JECHFBHEOEF();
		}
	}

	private void CIAIAEJIMCM()
	{
		DJDAJEOOJMI(BBHEMAPJGJM: true);
	}

	private void HHHEACKHADN()
	{
		OJBBMIGKHCG(BBHEMAPJGJM: true);
	}

	private void MKHMCIFFOFJ()
	{
		CPFDLKMCBCB(BBHEMAPJGJM: false);
	}

	private void Update()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			CPFDLKMCBCB(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 2 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			PFKBOFCDABE();
		}
	}

	private void PFOOOEOKMAC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1501f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 745f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 411f / FLALIJMIEBE;
			localScale.y = 1328f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void JDHNNLHGEKC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1794f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1544f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1429f / FLALIJMIEBE;
			localScale.y = 413f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			MKOHPBEGLNB(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 4 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			IDEACBAKOPF();
		}
	}

	private void NJCLFMHFNJH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1074f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1243f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1906f / FLALIJMIEBE;
			localScale.y = 1686f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void DJDAJEOOJMI(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 2)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)(" : 00" + ((object)(RenderMode)(ref renderMode)).ToString() + "NPC"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"<color=#");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Options");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PFOOOEOKMAC();
		}
	}

	private void EIGEIJJPFFP()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			IJBBCBKBNAN(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			OJCAPDGLHPC();
		}
	}

	private void JKBBAOGHPKO()
	{
		NAAMONCFKMB(BBHEMAPJGJM: false);
	}

	private void OnEnable()
	{
		CPFDLKMCBCB(BBHEMAPJGJM: true);
	}

	private void HKJCLFHCMKC()
	{
		DNNGLPLEEMJ(BBHEMAPJGJM: false);
	}

	private void NHINIAECHNC(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 7)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Selected" + ((object)(RenderMode)(ref renderMode)).ToString() + "ReceiveUnlockedRecipeMaster"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"LE_1");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"talentTropical");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			BHOJHJBKCLB();
		}
	}

	private void GGPDPOAICOM()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			DDDLBOBPBHB(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 5 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			PFKBOFCDABE();
		}
	}

	private void BINFEPPNOHG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 33f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1188f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1992f / FLALIJMIEBE;
			localScale.y = 668f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void MLICJIBNIFA()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			GBDLMLNPAPM(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 5 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			BANMLJCLKEJ();
		}
	}

	private void OGNIDHAIABM()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			IPHJECPBPOF(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 3 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			GHCEFKPDNIB();
		}
	}

	private void IPEEHGAKHPP(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 6)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Player2" + ((object)(RenderMode)(ref renderMode)).ToString() + "talentCitrus"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"LE_10");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Trucos activados via GOG.");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			LAJLMAOEIMN();
		}
	}

	private void IPHJECPBPOF(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 4)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Load Game Client" + ((object)(RenderMode)(ref renderMode)).ToString() + "0"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Community_Translation");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)" found in slot ");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			OBNJPLBFJKM();
		}
	}

	private void PCBBLGAEHHG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 582f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 787f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 345f / FLALIJMIEBE;
			localScale.y = 599f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void CMDHELEDLBP()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			DJDAJEOOJMI(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 2 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			JDHNNLHGEKC();
		}
	}

	private void COLMDMEJFDD(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 7)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("itemRedWine" + ((object)(RenderMode)(ref renderMode)).ToString() + "Player/Bark/Tutorial/CrafterBlock"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Upgrade");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)" ");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			MJPEHNDKKPF();
		}
	}

	private void AJOAKOCODOC()
	{
		DNNGLPLEEMJ(BBHEMAPJGJM: true);
	}

	private void CEGECEJOPJD(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 4)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("contentLockMessage" + ((object)(RenderMode)(ref renderMode)).ToString() + "popUpBuilding17"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"MainProgress");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			JMLFLDCEGHH();
		}
	}

	private void HFOCECKNDBG()
	{
		AJPLCFDGBLA(BBHEMAPJGJM: false);
	}

	private void MJPEHNDKKPF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 132f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1500f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 350f / FLALIJMIEBE;
			localScale.y = 752f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void OLFPIBOIIIO()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			JAEIFHAKANO(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			CPIDOLGGPFJ();
		}
	}

	private void CPFDLKMCBCB(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 2)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Render mode: " + ((object)(RenderMode)(ref renderMode)).ToString() + " is not supported by CanvasWorldScaler"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"You have to assign a UI camera!");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"You have to use the PixelPerfectCamera script on the assigned UI camera!");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			PFKBOFCDABE();
		}
	}

	private void DGJKLAEINHJ()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			IPEEHGAKHPP(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 6 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			PFKBOFCDABE();
		}
	}

	private void FOHHKGJFJAE(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 5)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Loop" + ((object)(RenderMode)(ref renderMode)).ToString() + "<color=#3a0603>+"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"SetUpOptions");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"OnBecameInvisible");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			NJCLFMHFNJH();
		}
	}

	private void CLGINBGKFDE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1327f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 6f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 120f / FLALIJMIEBE;
			localScale.y = 154f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void GNAHKAHPCFB()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			DDDLBOBPBHB(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 7 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			JDHNNLHGEKC();
		}
	}

	private void CMDBLLMEBLG()
	{
		NPENPGOABBO(BBHEMAPJGJM: true);
	}

	private void OONONNJFEFL()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			COLMDMEJFDD(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 5 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			OJCAPDGLHPC();
		}
	}

	private void CBAFHFPPNOL()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1980f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1723f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1380f / FLALIJMIEBE;
			localScale.y = 356f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void FPOIFOGELHC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			EEKOFIEBCPL(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 3 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			LAJLMAOEIMN();
		}
	}

	private void CPIDOLGGPFJ()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 341f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1451f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1699f / FLALIJMIEBE;
			localScale.y = 1485f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void EEKEMCKJNCH()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1721f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1782f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 784f / FLALIJMIEBE;
			localScale.y = 1885f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void GGGPGHLDKEP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1253f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1096f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1613f / FLALIJMIEBE;
			localScale.y = 1030f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void LAABMDDEGCG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			GBDLMLNPAPM(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 4 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			PFKBOFCDABE();
		}
	}

	private void FEPFNOEGFEM()
	{
		FOHHKGJFJAE(BBHEMAPJGJM: false);
	}

	private void BMNGDJGJCKP()
	{
		MKOHPBEGLNB(BBHEMAPJGJM: true);
	}

	private void JLPLLHKJEMH()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			IPEEHGAKHPP(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 8 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			PFKBOFCDABE();
		}
	}

	private void DNNGLPLEEMJ(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 7)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("popUpBuilding5" + ((object)(RenderMode)(ref renderMode)).ToString() + "LearnBalance"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"talentWine");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Bartender");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			JECHFBHEOEF();
		}
	}

	private void EMCCGDFOPEH()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			MKOHPBEGLNB(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			EEKEMCKJNCH();
		}
	}

	private void GHEHLJANBCF()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			HJCOAJEIABK(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			BANMLJCLKEJ();
		}
	}

	private void JJDEGMGCOCC()
	{
		EELJCLNJDDD(BBHEMAPJGJM: true);
	}

	private void GBNHKMLABGI()
	{
		JAEIFHAKANO(BBHEMAPJGJM: false);
	}

	private void PFKBOFCDABE()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 0f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 2f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1f / FLALIJMIEBE;
			localScale.y = 1f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void BHLHCOALABE()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			DDDLBOBPBHB(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 5 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			CPIDOLGGPFJ();
		}
	}

	private void GHCEFKPDNIB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1136f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 419f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 94f / FLALIJMIEBE;
			localScale.y = 1988f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void OHOHFGMJGAJ()
	{
		DJDAJEOOJMI(BBHEMAPJGJM: true);
	}

	private void IDEACBAKOPF()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 671f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1769f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1001f / FLALIJMIEBE;
			localScale.y = 510f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void GGCCOKCOMEE()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			COLMDMEJFDD(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 8 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			CPIDOLGGPFJ();
		}
	}

	private void OIEJIBAPDMM()
	{
		EELJCLNJDDD(BBHEMAPJGJM: true);
	}

	private void LAJLMAOEIMN()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1670f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1591f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1377f / FLALIJMIEBE;
			localScale.y = 458f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void OJCAPDGLHPC()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1247f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1868f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1808f / FLALIJMIEBE;
			localScale.y = 1602f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void OJBBMIGKHCG(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 6)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("AreaSpace not attached on OnlineAreaSpace of placeable " + ((object)(RenderMode)(ref renderMode)).ToString() + "Player/Bark/Tutorial/T138"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Beta ");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Unsaved progress will be lost.");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			GHCEFKPDNIB();
		}
	}

	private void IOHIEBBDOJN()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			IPHJECPBPOF(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 1 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			FHCBGJOPILC();
		}
	}

	private void ELHCBGCEJDH()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			EEKOFIEBCPL(BBHEMAPJGJM: false);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 3 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			CEEDDFCBCNG();
		}
	}

	private void AEMPCMILANL()
	{
		OJBBMIGKHCG(BBHEMAPJGJM: false);
	}

	private void CJDJDDNCNDJ()
	{
		IJBBCBKBNAN(BBHEMAPJGJM: true);
	}

	private void AJDKOMCHALC()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			EEKOFIEBCPL(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 5 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			GHCEFKPDNIB();
		}
	}

	private void IJBBCBKBNAN(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 4)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Text" + ((object)(RenderMode)(ref renderMode)).ToString() + "Sprint time"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"<color=#18650E>");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Next Item");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			CPIDOLGGPFJ();
		}
	}

	private void NPENPGOABBO(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 2)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("Dialogue System/Conversation/Gass_Quest/Entry/36/Dialogue Text" + ((object)(RenderMode)(ref renderMode)).ToString() + "Use"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Save");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Filthy");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			EPCDDJGINNA();
		}
	}

	private void BGHNLKKIKBC(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 5)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("/Localisation.txt" + ((object)(RenderMode)(ref renderMode)).ToString() + "CliveProgress"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Estufa duplicada eliminada");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Items/item_description_1182");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			BANMLJCLKEJ();
		}
	}

	private void BHOJHJBKCLB()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 1482f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1555f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 941f / FLALIJMIEBE;
			localScale.y = 1342f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void IJMBEEEGCGF()
	{
		NPENPGOABBO(BBHEMAPJGJM: false);
	}

	private void JAEIFHAKANO(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 8)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("cameraZoom2" + ((object)(RenderMode)(ref renderMode)).ToString() + "Dialogue System/Conversation/Crowly_Standar/Entry/15/Dialogue Text"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"UIBack");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"IsKicked");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			JDHNNLHGEKC();
		}
	}

	private void GBDLMLNPAPM(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 0)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("KyrohPreparingFood: Other player has advantage, going to WaitingToServe." + ((object)(RenderMode)(ref renderMode)).ToString() + "Disabled"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"LE_10");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Init failed for reason ");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			IDEACBAKOPF();
		}
	}

	private void CEEDDFCBCNG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 942f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1910f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 1903f / FLALIJMIEBE;
			localScale.y = 1143f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}

	private void GCHMNMKCOFG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (!EEDGMFLBODE)
		{
			OJBBMIGKHCG(BBHEMAPJGJM: true);
		}
		if (EEDGMFLBODE && (int)BJPJKLLJAIA.renderMode == 0 && (FLALIJMIEBE != MIBOLKMCJDM.assetsPixelsPerUnit || FOOMPFIKPPK != MIBOLKMCJDM.cameraSize))
		{
			IDEACBAKOPF();
		}
	}

	private void HJCOAJEIABK(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 7)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("itemMashTun" + ((object)(RenderMode)(ref renderMode)).ToString() + "Tutorial/T120/Dialogue1"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"castle travelling");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Item Instance type error in SlotMessage inventoryType: ");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			CBAFHFPPNOL();
		}
	}

	private void MKOHPBEGLNB(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 4)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("ReceiveRequestCustomerOrder" + ((object)(RenderMode)(ref renderMode)).ToString() + "Peak"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"UIInteract");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"Try to create private room");
			}
		}
		else
		{
			EEDGMFLBODE = false;
			GHCEFKPDNIB();
		}
	}

	private void ICBCMLAIIPF()
	{
		JAEIFHAKANO(BBHEMAPJGJM: true);
	}

	private void DDDLBOBPBHB(bool BBHEMAPJGJM)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		BJPJKLLJAIA = ((Component)this).GetComponent<Canvas>();
		if ((int)BJPJKLLJAIA.renderMode != 6)
		{
			RenderMode renderMode = BJPJKLLJAIA.renderMode;
			Debug.Log((object)("NextToWall" + ((object)(RenderMode)(ref renderMode)).ToString() + "HarvestableDuringTwoMonths"));
			return;
		}
		if ((Object)(object)uiCamera == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"DefaultSettings");
			}
			return;
		}
		MIBOLKMCJDM = ((Component)uiCamera).GetComponent<PixelPerfectCamera>();
		if ((Object)(object)MIBOLKMCJDM == (Object)null)
		{
			if (BBHEMAPJGJM)
			{
				Debug.Log((object)"ReceiveDecorationFloor");
			}
		}
		else
		{
			EEDGMFLBODE = true;
			GGGPGHLDKEP();
		}
	}

	private void ALJGEMAFODP()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (MIBOLKMCJDM.isInitialized && MIBOLKMCJDM.cameraSize.x != 656f)
		{
			FOOMPFIKPPK = MIBOLKMCJDM.cameraSize;
			FLALIJMIEBE = MIBOLKMCJDM.assetsPixelsPerUnit;
			((Component)this).GetComponent<RectTransform>().sizeDelta = 1065f * FLALIJMIEBE * FOOMPFIKPPK;
			Vector3 localScale = ((Transform)((Component)this).GetComponent<RectTransform>()).localScale;
			localScale.x = 789f / FLALIJMIEBE;
			localScale.y = 348f / FLALIJMIEBE;
			((Transform)((Component)this).GetComponent<RectTransform>()).localScale = localScale;
		}
	}
}
