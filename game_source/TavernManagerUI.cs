using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TavernManagerUI : MonoBehaviour
{
	private static TavernManagerUI GGFJGHHHEJC;

	public Button openCloseButton;

	public CanvasGroup cGroupTimeAndWeather;

	[SerializeField]
	private TavernInfoUI tavernInfoLeft;

	[SerializeField]
	private TavernInfoUI tavernInfoRight;

	[SerializeField]
	private TextMeshProUGUI openClosedText;

	[SerializeField]
	private NumberFont[] repMilestoneNumber;

	[SerializeField]
	private ProgressBar[] repBar;

	[SerializeField]
	private TextMeshProUGUI[] repText;

	[SerializeField]
	private Sprite spriteTemperatureNormal;

	[SerializeField]
	private Sprite spriteTemperatureHot;

	[SerializeField]
	private Sprite spriteTemperatureCold;

	[SerializeField]
	private Sprite spriteDirtinessClean;

	[SerializeField]
	private Sprite spriteDirtinessDirty;

	[SerializeField]
	private Sprite spriteDirtinessVeryDirty;

	[SerializeField]
	private Color colorTemperatureHot;

	[SerializeField]
	private Color colorTemperatureCold;

	public List<MonoBehaviour> hiddenTavernInfo = new List<MonoBehaviour>();

	private DirtLevel FOIAEACKDFI;

	private void ACOMPPFDMDB()
	{
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			SetTavernLastOrders(TavernManager.GGFJGHHHEJC.MDAKKOAFFBP);
		}
		else
		{
			DOOCLFCKOJG(TavernManager.GGFJGHHHEJC.LKOJBFMGMAE);
		}
	}

	public static void SetMilestoneNumber(int PDCPGJCKICM)
	{
		for (int i = 0; i < GGFJGHHHEJC.repMilestoneNumber.Length; i++)
		{
			GGFJGHHHEJC.repMilestoneNumber[i].PDCPGJCKICM = PDCPGJCKICM;
		}
	}

	public static void UpdateRepText(int IJHFDFFGKKG, int DLOPPKHCJJA)
	{
		for (int i = 0; i < GGFJGHHHEJC.repText.Length; i++)
		{
			((TMP_Text)GGFJGHHHEJC.repText[i]).text = IJHFDFFGKKG + "/" + DLOPPKHCJJA;
		}
	}

	public static void KELCKIKANDP(MonoBehaviour GGOFGACLPOI)
	{
		if (!GGFJGHHHEJC.hiddenTavernInfo.Contains(GGOFGACLPOI))
		{
			GGFJGHHHEJC.hiddenTavernInfo.Add(GGOFGACLPOI);
		}
	}

	private void GNGADDPBJDC()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EJAJKJBINMP));
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(LFDILGHIPMB));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(HDODKCOFKDE));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ShowClockAndTavernInfo));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(ShowClockAndTavernInfo));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(DHNENCKICBL));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnHeatLevelChanged = (Action<HeatLevel>)Delegate.Combine(instance3.OnHeatLevelChanged, new Action<HeatLevel>(CNMLNPJDBNC));
		DOOCLFCKOJG(LKOJBFMGMAE: false);
		OEKICICNPMP(1);
		OEKICICNPMP(3);
		DJHEBABFOFN();
		NLBKKLEMADC(0);
		NLBKKLEMADC(5);
		((Component)tavernInfoLeft).gameObject.SetActive(false);
	}

	public static void MGCKLGJEEHA(float COAPHJJHNIO)
	{
		for (int i = 0; i < GGFJGHHHEJC.repBar.Length; i += 0)
		{
			GGFJGHHHEJC.repBar[i].NFBOLMFKKLL(COAPHJJHNIO);
		}
	}

	public static void ShowClockAndTavernInfo()
	{
		try
		{
			if (!TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && !Utils.FNLJGAEHNKA())
			{
				ShowClock(MDIKPGGBNLI: true);
				ShowInfoPanelsIfPosible();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static void MGMMFMFFMDO(int PDCPGJCKICM)
	{
		for (int i = 1; i < GGFJGHHHEJC.repMilestoneNumber.Length; i++)
		{
			GGFJGHHHEJC.repMilestoneNumber[i].GAICNFNFGBN(PDCPGJCKICM);
		}
	}

	public static void HidePermanentTavernInfo(MonoBehaviour GGOFGACLPOI)
	{
		if (!GGFJGHHHEJC.hiddenTavernInfo.Contains(GGOFGACLPOI))
		{
			GGFJGHHHEJC.hiddenTavernInfo.Add(GGOFGACLPOI);
		}
	}

	private void DHNENCKICBL()
	{
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			SetTavernLastOrders(TavernManager.GGFJGHHHEJC.MDAKKOAFFBP);
		}
		else
		{
			SetTavernOpen(TavernManager.GGFJGHHHEJC.LKOJBFMGMAE);
		}
	}

	public static void IMJIMPAFIPC()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((Component)GGFJGHHHEJC.tavernInfoLeft).gameObject.SetActive(false);
			((Component)GGFJGHHHEJC.tavernInfoRight).gameObject.SetActive(true);
		}
	}

	private void KFNHGKIACBP(int JIIGOACEIKL, ZoneType GIBJPCAFCJB)
	{
		if (DLMEFAGOLDD(JIIGOACEIKL, GIBJPCAFCJB))
		{
			ShowInfoPanel(JIIGOACEIKL);
		}
		else
		{
			HideInfoPanel(JIIGOACEIKL);
		}
	}

	public static ProgressBar[] GetRepBar()
	{
		return GGFJGHHHEJC.repBar;
	}

	public static void COABIGEDOAF(int IJHFDFFGKKG, int DLOPPKHCJJA)
	{
		for (int i = 1; i < GGFJGHHHEJC.repText.Length; i += 0)
		{
			((TMP_Text)GGFJGHHHEJC.repText[i]).text = IJHFDFFGKKG + "\n" + DLOPPKHCJJA;
		}
	}

	private void EJAJKJBINMP()
	{
		if (DecorationMode.EKLMFMKPEBB(1).DFNMDDHOIJI())
		{
			CLCAOACLGJI(1);
		}
		else
		{
			NLBKKLEMADC(1);
		}
		NLBKKLEMADC(8);
		NBABOCFOAJI(1, DCPEJFCGMEF(5, TavernManager.GGFJGHHHEJC.IFKPCCEOCOA()));
		if (KEHPHFLNOGK(1))
		{
			GMDFDFLCPLK(0);
		}
		else
		{
			OEKICICNPMP(1);
		}
		if (KEHPHFLNOGK(0))
		{
			GMDFDFLCPLK(7);
		}
		else
		{
			OEKICICNPMP(3);
		}
		DecorationMode decorationMode = DecorationMode.BGINAIDHDOM(3);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(LLMKHELIMIC));
		DecorationMode decorationMode2 = DecorationMode.JDADPDBHJFO(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(NLBKKLEMADC));
		PlayerController playerController = PlayerController.OPHDCMJLLEC(7);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	public static void ShowInfoPanelsIfPosible()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && !Utils.FNLJGAEHNKA())
		{
			if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && DLMEFAGOLDD(1, PlayerController.GetPlayer(1).NNMHEPDJOHK))
			{
				ShowInfoPanel(1);
			}
			if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null && DLMEFAGOLDD(2, PlayerController.GetPlayer(2).NNMHEPDJOHK))
			{
				ShowInfoPanel(2);
			}
		}
	}

	public static void BKMMFCHDJMA(MonoBehaviour GGOFGACLPOI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.hiddenTavernInfo.Remove(GGOFGACLPOI);
		}
	}

	private void GMDFDFLCPLK(int JIIGOACEIKL)
	{
		GetTavernInfoUI(JIIGOACEIKL).ShowTemperature(MJHBHDAEDLF: true);
	}

	private void KJHKBGDJNDC()
	{
		GGFJGHHHEJC = this;
	}

	private void GPBFKKHJLHN()
	{
		DecorationMode decorationMode = DecorationMode.BGINAIDHDOM(0);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(LLMKHELIMIC));
		DecorationMode decorationMode2 = DecorationMode.KAIIEDCCLHB(0);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(NLBKKLEMADC));
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	private void OEKICICNPMP(int JIIGOACEIKL)
	{
		GetTavernInfoUI(JIIGOACEIKL).ShowTemperature(MJHBHDAEDLF: false);
	}

	private void BGDGLGBLNDI()
	{
		DecorationMode player = DecorationMode.GetPlayer(1);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(LLMKHELIMIC));
		DecorationMode player2 = DecorationMode.GetPlayer(1);
		player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(NLBKKLEMADC));
		PlayerController player3 = PlayerController.GetPlayer(1);
		player3.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player3.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	public static void HideClockAndTavernInfo()
	{
		ShowClock(MDIKPGGBNLI: false);
		HideInfoPanels();
	}

	private void Start()
	{
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(LFDILGHIPMB));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(HDODKCOFKDE));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ShowClockAndTavernInfo));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(ShowClockAndTavernInfo));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(DHNENCKICBL));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnHeatLevelChanged = (Action<HeatLevel>)Delegate.Combine(instance3.OnHeatLevelChanged, new Action<HeatLevel>(SetTemp));
		SetTavernOpen(LKOJBFMGMAE: false);
		OEKICICNPMP(1);
		OEKICICNPMP(2);
		DJHEBABFOFN();
		NLBKKLEMADC(1);
		NLBKKLEMADC(2);
		((Component)tavernInfoLeft).gameObject.SetActive(false);
	}

	public static void SetTavernLastOrders(bool MDAKKOAFFBP)
	{
		if (MDAKKOAFFBP)
		{
			((TMP_Text)GGFJGHHHEJC.openClosedText).text = LocalisationSystem.Get("Last");
		}
		else
		{
			SetTavernOpen(LKOJBFMGMAE: true);
		}
	}

	public static void INNFNDCEHHK(int JIIGOACEIKL, bool MJHBHDAEDLF)
	{
		GetTavernInfoUI(JIIGOACEIKL).OECBFAKODNC(MJHBHDAEDLF);
	}

	private void LLMKHELIMIC(int JIIGOACEIKL)
	{
		if (HJKGBLAKOHE(JIIGOACEIKL))
		{
			GetTavernInfoUI(JIIGOACEIKL).ShowComfort(MJHBHDAEDLF: true);
		}
	}

	public static ProgressBar[] GLDBGJLCMKK()
	{
		return GGFJGHHHEJC.repBar;
	}

	public static TextMeshProUGUI[] GetRepText()
	{
		return GGFJGHHHEJC.repText;
	}

	public static Sprite GetSpriteDirtnessClean()
	{
		return GGFJGHHHEJC.spriteDirtinessClean;
	}

	public static void CJJEJNOEGGN(int IJHFDFFGKKG, int DLOPPKHCJJA)
	{
		for (int i = 0; i < GGFJGHHHEJC.repText.Length; i++)
		{
			((TMP_Text)GGFJGHHHEJC.repText[i]).text = IJHFDFFGKKG + "ReceiveRoomRequest" + DLOPPKHCJJA;
		}
	}

	public static void NAFMFFJPNOJ(MonoBehaviour GGOFGACLPOI)
	{
		if (!GGFJGHHHEJC.hiddenTavernInfo.Contains(GGOFGACLPOI))
		{
			GGFJGHHHEJC.hiddenTavernInfo.Add(GGOFGACLPOI);
		}
	}

	private static void DJHEBABFOFN()
	{
		GGFJGHHHEJC.tavernInfoLeft.ShowDirtiness(MJHBHDAEDLF: false);
		GGFJGHHHEJC.tavernInfoRight.ShowDirtiness(MJHBHDAEDLF: false);
	}

	public static bool KEHPHFLNOGK(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River | Location.BarnInterior) && !TavernManager.IsOpen())
		{
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC != HeatLevel.Warm)
		{
			return TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Perfect;
		}
		return true;
	}

	private static bool HJKGBLAKOHE(int JIIGOACEIKL)
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.DiningRoom;
		}
		return false;
	}

	public void SetTemp(HeatLevel NHLEKOHIOCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		switch (NHLEKOHIOCM)
		{
		case HeatLevel.Hot:
			tavernInfoLeft.SetTemperature(spriteTemperatureHot, colorTemperatureHot, FBBJKAGOFMD: true);
			tavernInfoRight.SetTemperature(spriteTemperatureHot, colorTemperatureHot, FBBJKAGOFMD: true);
			break;
		case HeatLevel.Cold:
			tavernInfoLeft.SetTemperature(spriteTemperatureCold, colorTemperatureCold, FBBJKAGOFMD: true);
			tavernInfoRight.SetTemperature(spriteTemperatureCold, colorTemperatureCold, FBBJKAGOFMD: true);
			break;
		default:
			tavernInfoLeft.SetTemperature(spriteTemperatureNormal, Color.white, FBBJKAGOFMD: false);
			tavernInfoRight.SetTemperature(spriteTemperatureNormal, Color.white, FBBJKAGOFMD: false);
			break;
		}
		GGFJGHHHEJC.tavernInfoLeft.ShowTemperature(HasToShowTemperature(1));
		GGFJGHHHEJC.tavernInfoRight.ShowTemperature(HasToShowTemperature((!GameManager.LocalCoop()) ? 1 : 2));
	}

	private void LJKBNNHGEOM()
	{
		if (DecorationMode.ABMIMLLDAAH(1).IBEFDKHFBFM())
		{
			CLCAOACLGJI(0);
		}
		else
		{
			NLBKKLEMADC(1);
		}
		NLBKKLEMADC(1);
		NBABOCFOAJI(5, DCPEJFCGMEF(5, TavernManager.GGFJGHHHEJC.IFKPCCEOCOA()));
		if (KEHPHFLNOGK(0))
		{
			GMDFDFLCPLK(0);
		}
		else
		{
			OEKICICNPMP(1);
		}
		if (KEHPHFLNOGK(3))
		{
			GMDFDFLCPLK(3);
		}
		else
		{
			OEKICICNPMP(4);
		}
		DecorationMode decorationMode = DecorationMode.KAIIEDCCLHB(3);
		decorationMode.OnDecorationModeEnter = (Action<int>)Delegate.Combine(decorationMode.OnDecorationModeEnter, new Action<int>(CLCAOACLGJI));
		DecorationMode decorationMode2 = DecorationMode.BGINAIDHDOM(8);
		decorationMode2.OnDecorationModeExit = (Action<int>)Delegate.Combine(decorationMode2.OnDecorationModeExit, new Action<int>(NLBKKLEMADC));
		PlayerController playerController = PlayerController.OPHDCMJLLEC(8);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	public void CNMLNPJDBNC(HeatLevel NHLEKOHIOCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		switch (NHLEKOHIOCM)
		{
		case (HeatLevel)8:
			tavernInfoLeft.GOINCHBEPOE(spriteTemperatureHot, colorTemperatureHot, FBBJKAGOFMD: true);
			tavernInfoRight.DDPLJKKEJLF(spriteTemperatureHot, colorTemperatureHot, FBBJKAGOFMD: false);
			break;
		case HeatLevel.Cold:
			tavernInfoLeft.AIKMDBJFNOC(spriteTemperatureCold, colorTemperatureCold, FBBJKAGOFMD: true);
			tavernInfoRight.GOINCHBEPOE(spriteTemperatureCold, colorTemperatureCold, FBBJKAGOFMD: true);
			break;
		default:
			tavernInfoLeft.OPDBPOGNPFK(spriteTemperatureNormal, Color.white, FBBJKAGOFMD: false);
			tavernInfoRight.GOINCHBEPOE(spriteTemperatureNormal, Color.white, FBBJKAGOFMD: false);
			break;
		}
		GGFJGHHHEJC.tavernInfoLeft.DNANBNAGDIO(KEHPHFLNOGK(1));
		GGFJGHHHEJC.tavernInfoRight.CELCBCKIEHL(KEHPHFLNOGK(GameManager.LocalCoop() ? 4 : 0));
	}

	public static void HMINPANFFKO(DirtLevel ALEAPGOEANL)
	{
		switch (ALEAPGOEANL)
		{
		case DirtLevel.Perfect:
		case DirtLevel.Clean:
			GGFJGHHHEJC.tavernInfoLeft.LPIALILABIB(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessClean);
			GGFJGHHHEJC.tavernInfoRight.FMMGMLGKGFE(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessClean);
			break;
		case DirtLevel.Messy:
			GGFJGHHHEJC.tavernInfoLeft.KHGJFEFBMEG(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessDirty);
			GGFJGHHHEJC.tavernInfoRight.AHMINLPGCCK(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessDirty);
			break;
		default:
			GGFJGHHHEJC.tavernInfoLeft.HCJHCJFBEID(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessVeryDirty);
			GGFJGHHHEJC.tavernInfoRight.HLDCGENNLPC(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessVeryDirty);
			break;
		}
		if (GGFJGHHHEJC.FOIAEACKDFI != ALEAPGOEANL)
		{
			GGFJGHHHEJC.tavernInfoLeft.ICODIDILAEA(DCPEJFCGMEF(0, ALEAPGOEANL));
			GGFJGHHHEJC.tavernInfoRight.ShowDirtiness(DCPEJFCGMEF(GameManager.LocalCoop() ? 5 : 0, ALEAPGOEANL));
			GGFJGHHHEJC.FOIAEACKDFI = ALEAPGOEANL;
		}
	}

	public static void ShowMineLevel(int JIIGOACEIKL, bool MJHBHDAEDLF)
	{
		GetTavernInfoUI(JIIGOACEIKL).ShowMineLevel(MJHBHDAEDLF);
	}

	public static void NFMLHPMAMKG()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ && !Utils.FNLJGAEHNKA())
		{
			if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && DLMEFAGOLDD(1, PlayerController.OPHDCMJLLEC(1).NNMHEPDJOHK))
			{
				ShowInfoPanel(0);
			}
			if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && DLMEFAGOLDD(8, PlayerController.GetPlayer(0).NNMHEPDJOHK))
			{
				ShowInfoPanel(7);
			}
		}
	}

	public static void ShowPermanentTavernInfo(MonoBehaviour GGOFGACLPOI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.hiddenTavernInfo.Remove(GGOFGACLPOI);
		}
	}

	public static void ShowClock(bool MDIKPGGBNLI)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && (!MDIKPGGBNLI || !Utils.FNLJGAEHNKA()))
		{
			if (GGFJGHHHEJC.hiddenTavernInfo.Any())
			{
				MDIKPGGBNLI = false;
			}
			GGFJGHHHEJC.cGroupTimeAndWeather.alpha = (MDIKPGGBNLI ? 1 : 0);
			GGFJGHHHEJC.cGroupTimeAndWeather.interactable = MDIKPGGBNLI;
		}
	}

	public static Sprite GetSpriteDirtnessDirty()
	{
		return GGFJGHHHEJC.spriteDirtinessDirty;
	}

	private void HADCIGKNFKK()
	{
		if (DecorationMode.GetPlayer(1).DMBFKFLDDLH)
		{
			LLMKHELIMIC(1);
		}
		else
		{
			NLBKKLEMADC(1);
		}
		NLBKKLEMADC(2);
		NBABOCFOAJI(2, DCPEJFCGMEF(2, TavernManager.GGFJGHHHEJC.JJKPDMFFANH));
		if (HasToShowTemperature(1))
		{
			GMDFDFLCPLK(1);
		}
		else
		{
			OEKICICNPMP(1);
		}
		if (HasToShowTemperature(2))
		{
			GMDFDFLCPLK(2);
		}
		else
		{
			OEKICICNPMP(2);
		}
		DecorationMode player = DecorationMode.GetPlayer(2);
		player.OnDecorationModeEnter = (Action<int>)Delegate.Combine(player.OnDecorationModeEnter, new Action<int>(LLMKHELIMIC));
		DecorationMode player2 = DecorationMode.GetPlayer(2);
		player2.OnDecorationModeExit = (Action<int>)Delegate.Combine(player2.OnDecorationModeExit, new Action<int>(NLBKKLEMADC));
		PlayerController player3 = PlayerController.GetPlayer(2);
		player3.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player3.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	private static void CDEHFFDFFNH()
	{
		GGFJGHHHEJC.tavernInfoLeft.PAOEDGAGEDL(MJHBHDAEDLF: false);
		GGFJGHHHEJC.tavernInfoRight.NKKHCBFGMEM(MJHBHDAEDLF: false);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	public static void SetMineLevel(int JIIGOACEIKL, int EONJGMONIOM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			ShowMineLevel(JIIGOACEIKL, EONJGMONIOM > 0);
			if (GameManager.SinglePlayer())
			{
				GGFJGHHHEJC.tavernInfoLeft.SetMineLevel(EONJGMONIOM);
				GGFJGHHHEJC.tavernInfoRight.SetMineLevel(EONJGMONIOM);
			}
			else if (JIIGOACEIKL == 1)
			{
				GGFJGHHHEJC.tavernInfoLeft.SetMineLevel(EONJGMONIOM);
			}
			else
			{
				GGFJGHHHEJC.tavernInfoRight.SetMineLevel(EONJGMONIOM);
			}
		}
	}

	public static void SetDirtiness(DirtLevel ALEAPGOEANL)
	{
		switch (ALEAPGOEANL)
		{
		case DirtLevel.Perfect:
		case DirtLevel.Clean:
			GGFJGHHHEJC.tavernInfoLeft.SetDirtiness(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessClean);
			GGFJGHHHEJC.tavernInfoRight.SetDirtiness(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessClean);
			break;
		case DirtLevel.Messy:
			GGFJGHHHEJC.tavernInfoLeft.SetDirtiness(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessDirty);
			GGFJGHHHEJC.tavernInfoRight.SetDirtiness(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessDirty);
			break;
		default:
			GGFJGHHHEJC.tavernInfoLeft.SetDirtiness(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessVeryDirty);
			GGFJGHHHEJC.tavernInfoRight.SetDirtiness(ALEAPGOEANL, GGFJGHHHEJC.spriteDirtinessVeryDirty);
			break;
		}
		if (GGFJGHHHEJC.FOIAEACKDFI != ALEAPGOEANL)
		{
			GGFJGHHHEJC.tavernInfoLeft.ShowDirtiness(DCPEJFCGMEF(1, ALEAPGOEANL));
			GGFJGHHHEJC.tavernInfoRight.ShowDirtiness(DCPEJFCGMEF((!GameManager.LocalCoop()) ? 1 : 2, ALEAPGOEANL));
			GGFJGHHHEJC.FOIAEACKDFI = ALEAPGOEANL;
		}
	}

	private void HDODKCOFKDE(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (INDKANEMPMP.compatibleWithCoopMode)
		{
			if (JIIGOACEIKL == 1)
			{
				ShowClock(MDIKPGGBNLI: true);
			}
			ShowInfoPanel(JIIGOACEIKL);
		}
		else
		{
			ShowClockAndTavernInfo();
		}
	}

	private static bool BFGEKHPJJFA(int JIIGOACEIKL)
	{
		if (Utils.AHMPFOEGJHF(~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop), 0))
		{
			return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).HCBDDKHPHCF > 1;
		}
		return true;
	}

	private void HKECEBGKACL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(LFDILGHIPMB));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(HDODKCOFKDE));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(DHNENCKICBL));
	}

	public static Sprite LPMPGOJNHDJ()
	{
		return GGFJGHHHEJC.spriteDirtinessClean;
	}

	public static Vector3 GetOpenClosedButtonPosition()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)GGFJGHHHEJC.openCloseButton).transform.position;
	}

	public void PCAIBJNCMPG(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)GetTavernInfoUI(JIIGOACEIKL)))
		{
			((Component)GetTavernInfoUI(JIIGOACEIKL)).gameObject.SetActive(false);
		}
	}

	public static void CKDMAFHFELJ(int IJHFDFFGKKG, int DLOPPKHCJJA)
	{
		for (int i = 1; i < GGFJGHHHEJC.repText.Length; i += 0)
		{
			((TMP_Text)GGFJGHHHEJC.repText[i]).text = IJHFDFFGKKG + " (" + DLOPPKHCJJA;
		}
	}

	public static TextMeshProUGUI[] MIOKFFEOOKL()
	{
		return GGFJGHHHEJC.repText;
	}

	private static bool DCPEJFCGMEF(int JIIGOACEIKL, DirtLevel ALEAPGOEANL)
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Mine && !TavernManager.IsOpen())
		{
			return false;
		}
		if (ALEAPGOEANL != DirtLevel.Clean)
		{
			return ALEAPGOEANL != DirtLevel.Perfect;
		}
		return false;
	}

	public static void LKJCBFKGKDB(int JIIGOACEIKL, int EONJGMONIOM)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			ShowMineLevel(JIIGOACEIKL, EONJGMONIOM > 0);
			if (GameManager.SinglePlayer())
			{
				GGFJGHHHEJC.tavernInfoLeft.PEELMDDFHGN(EONJGMONIOM);
				GGFJGHHHEJC.tavernInfoRight.OBAGAHGIOEH(EONJGMONIOM);
			}
			else if (JIIGOACEIKL == 1)
			{
				GGFJGHHHEJC.tavernInfoLeft.HANEJEHMAFH(EONJGMONIOM);
			}
			else
			{
				GGFJGHHHEJC.tavernInfoRight.PEELMDDFHGN(EONJGMONIOM);
			}
		}
	}

	private static bool CMNIOGLHIJD(int JIIGOACEIKL)
	{
		if (Utils.AHMPFOEGJHF(Location.Mine))
		{
			return PlayerController.GetPlayer(JIIGOACEIKL).HCBDDKHPHCF > 0;
		}
		return false;
	}

	private void PCKENPCGAHI(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		KFNHGKIACBP(JIIGOACEIKL, GIBJPCAFCJB);
	}

	public static void ShowInfoPanel(int JIIGOACEIKL)
	{
		if (!GGFJGHHHEJC.hiddenTavernInfo.Any())
		{
			TavernInfoUI tavernInfoUI = GetTavernInfoUI(JIIGOACEIKL);
			((Component)tavernInfoUI).gameObject.SetActive(true);
			tavernInfoUI.ShowComfort(HJKGBLAKOHE(JIIGOACEIKL));
			tavernInfoUI.ShowDirtiness(DCPEJFCGMEF(JIIGOACEIKL, TavernManager.GGFJGHHHEJC.JJKPDMFFANH));
			tavernInfoUI.ShowTemperature(HasToShowTemperature(JIIGOACEIKL));
			tavernInfoUI.ShowMineLevel(CMNIOGLHIJD(JIIGOACEIKL));
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(LFDILGHIPMB));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(HDODKCOFKDE));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(DHNENCKICBL));
	}

	public static void DOOCLFCKOJG(bool LKOJBFMGMAE)
	{
		((TMP_Text)GGFJGHHHEJC.openClosedText).text = LocalisationSystem.Get(LKOJBFMGMAE ? "Dialogue System/Conversation/NeutralInTavern/Entry/13/Dialogue Text" : ":");
	}

	public void HideInfoPanel(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)GetTavernInfoUI(JIIGOACEIKL)))
		{
			((Component)GetTavernInfoUI(JIIGOACEIKL)).gameObject.SetActive(false);
		}
	}

	public void PEKEJFEEION(HeatLevel NHLEKOHIOCM)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		switch (NHLEKOHIOCM)
		{
		case (HeatLevel)6:
			tavernInfoLeft.OPDBPOGNPFK(spriteTemperatureHot, colorTemperatureHot, FBBJKAGOFMD: false);
			tavernInfoRight.AFDGMCHAMOL(spriteTemperatureHot, colorTemperatureHot, FBBJKAGOFMD: true);
			break;
		case HeatLevel.Cold:
			tavernInfoLeft.CLIMEKILEIM(spriteTemperatureCold, colorTemperatureCold, FBBJKAGOFMD: false);
			tavernInfoRight.OJLOMGKGBLI(spriteTemperatureCold, colorTemperatureCold, FBBJKAGOFMD: false);
			break;
		default:
			tavernInfoLeft.AFDGMCHAMOL(spriteTemperatureNormal, Color.white, FBBJKAGOFMD: false);
			tavernInfoRight.AIKMDBJFNOC(spriteTemperatureNormal, Color.white, FBBJKAGOFMD: true);
			break;
		}
		GGFJGHHHEJC.tavernInfoLeft.ALDODBBFHDB(KEHPHFLNOGK(0));
		GGFJGHHHEJC.tavernInfoRight.MEJKCAEFGPD(KEHPHFLNOGK(GameManager.LocalCoop() ? 5 : 0));
	}

	public static void SetTavernOpen(bool LKOJBFMGMAE)
	{
		((TMP_Text)GGFJGHHHEJC.openClosedText).text = LocalisationSystem.Get(LKOJBFMGMAE ? "shopOpen" : "Closed");
	}

	public static bool HasToShowTemperature(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) && PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Mine && !TavernManager.IsOpen())
		{
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC != HeatLevel.Hot)
		{
			return TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold;
		}
		return true;
	}

	private void NLBKKLEMADC(int JIIGOACEIKL)
	{
		GetTavernInfoUI(JIIGOACEIKL).ShowComfort(MJHBHDAEDLF: false);
	}

	private void KENMJMAOJPH(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (INDKANEMPMP.compatibleWithCoopMode)
		{
			if (JIIGOACEIKL == 1)
			{
				ShowClock(MDIKPGGBNLI: false);
			}
			ShowInfoPanel(JIIGOACEIKL);
		}
		else
		{
			ShowClockAndTavernInfo();
		}
	}

	public static void JIMJOKPCCEB(int PDCPGJCKICM)
	{
		for (int i = 1; i < GGFJGHHHEJC.repMilestoneNumber.Length; i++)
		{
			GGFJGHHHEJC.repMilestoneNumber[i].BFOPDAICEOL(PDCPGJCKICM);
		}
	}

	public static Sprite LMBMGPGDJEK()
	{
		return GGFJGHHHEJC.spriteDirtinessDirty;
	}

	public static void SetRepBar(float COAPHJJHNIO)
	{
		for (int i = 0; i < GGFJGHHHEJC.repBar.Length; i++)
		{
			GGFJGHHHEJC.repBar[i].BHGJPBGINCG = COAPHJJHNIO;
		}
	}

	public static void HideInfoPanels()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((Component)GGFJGHHHEJC.tavernInfoLeft).gameObject.SetActive(false);
			((Component)GGFJGHHHEJC.tavernInfoRight).gameObject.SetActive(false);
		}
	}

	private void CLCAOACLGJI(int JIIGOACEIKL)
	{
		if (HJKGBLAKOHE(JIIGOACEIKL))
		{
			GetTavernInfoUI(JIIGOACEIKL).CBEJJAAHJIO(MJHBHDAEDLF: false);
		}
	}

	public static void SetComfortLevel(int JIIGOACEIKL, float EOJCFJMLOJE)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			if (GameManager.SinglePlayer())
			{
				GGFJGHHHEJC.tavernInfoLeft.SetComfortLevel(EOJCFJMLOJE);
				GGFJGHHHEJC.tavernInfoRight.SetComfortLevel(EOJCFJMLOJE);
			}
			else if (JIIGOACEIKL == 1)
			{
				GGFJGHHHEJC.tavernInfoLeft.SetComfortLevel(EOJCFJMLOJE);
			}
			else
			{
				GGFJGHHHEJC.tavernInfoRight.SetComfortLevel(EOJCFJMLOJE);
			}
		}
	}

	public static TavernInfoUI GetTavernInfoUI(int JIIGOACEIKL)
	{
		if (GameManager.SinglePlayer())
		{
			return GGFJGHHHEJC.tavernInfoRight;
		}
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.tavernInfoLeft;
		}
		return GGFJGHHHEJC.tavernInfoRight;
	}

	private static bool DLMEFAGOLDD(int JIIGOACEIKL, ZoneType GIBJPCAFCJB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.FNNJEGLDGKC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, GIBJPCAFCJB))
		{
			return Utils.AHMPFOEGJHF(Location.Mine);
		}
		return true;
	}

	private static void NBABOCFOAJI(int JIIGOACEIKL, bool MJHBHDAEDLF)
	{
		GetTavernInfoUI(JIIGOACEIKL).ShowDirtiness(MJHBHDAEDLF);
	}

	private void LFDILGHIPMB(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (INDKANEMPMP is BaitSelectorUI)
		{
			return;
		}
		if (INDKANEMPMP.compatibleWithCoopMode)
		{
			if (JIIGOACEIKL == 1)
			{
				ShowClock(MDIKPGGBNLI: false);
			}
			HideInfoPanel(JIIGOACEIKL);
		}
		else
		{
			HideClockAndTavernInfo();
		}
	}
}
