using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CalendarUI : UIWindow
{
	[CompilerGenerated]
	private sealed class KDKLDDNDJDP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CalendarUI _003C_003E4__this;

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
		public KDKLDDNDJDP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			CalendarUI calendarUI = _003C_003E4__this;
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
				UISelectionManager.GetPlayer(calendarUI.JIIGOACEIKL).Select(((Component)calendarUI.calendarDays[calendarUI.KCBMDDCELDD.DKGMLALMDEH() - 1]).GetComponent<Selectable>());
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

	[SerializeField]
	private CalendarDay[] calendarDays;

	[SerializeField]
	private Image calendarImage;

	[SerializeField]
	private Image calendarMaskImage;

	[SerializeField]
	private Sprite spriteSpringCalendar;

	[SerializeField]
	private Sprite spriteSummerCalendar;

	[SerializeField]
	private Sprite spriteAutumnCalendar;

	[SerializeField]
	private Sprite spriteWinterCalendar;

	[SerializeField]
	private Sprite spriteSpringMask;

	[SerializeField]
	private Sprite spriteSummerMask;

	[SerializeField]
	private Sprite spriteAutumnMask;

	[SerializeField]
	private Sprite spriteWinterMask;

	[SerializeField]
	private TextMeshProUGUI seasonText;

	[SerializeField]
	private TextMeshProUGUI monthNumText;

	[SerializeField]
	private TextMeshProUGUI yearNumText;

	[SerializeField]
	private TrendUI trendsUI;

	private GameDate JDJJPICJAEL;

	public static CalendarUI[] instances = new CalendarUI[3];

	[HideInInspector]
	public bool openedFromNoticeBoard;

	public Sprite[] selectionSprites;

	public GameDate KCBMDDCELDD
	{
		get
		{
			return JDJJPICJAEL;
		}
		set
		{
			JDJJPICJAEL = value;
			PJBDFNMJEOC();
		}
	}

	private void DBOLCPECKDN()
	{
		switch (KCBMDDCELDD.JAILNPKPONC())
		{
		case Season.Spring:
			calendarImage.sprite = spriteSpringCalendar;
			calendarMaskImage.sprite = spriteSpringMask;
			break;
		case Season.Summer:
			calendarImage.sprite = spriteSummerCalendar;
			calendarMaskImage.sprite = spriteSummerMask;
			break;
		case Season.Autumn:
			calendarImage.sprite = spriteAutumnCalendar;
			calendarMaskImage.sprite = spriteAutumnMask;
			break;
		case Season.Winter:
			calendarImage.sprite = spriteWinterCalendar;
			calendarMaskImage.sprite = spriteWinterMask;
			break;
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void GDLAHKEMJFN()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(NBPFGLBFIPP));
	}

	public static CalendarUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public GameDate EIOGGIBNJNJ()
	{
		return JDJJPICJAEL;
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			if (!openedFromNoticeBoard)
			{
				MainUI.ResumeGame();
				GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			}
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			base.CloseUI();
			if (!openedFromNoticeBoard)
			{
				SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			}
			FocusArrowUI.Get(base.JIIGOACEIKL).SetVisible(NKFPJPCFBJI: false);
			if (Object.op_Implicit((Object)(object)ItemTooltip.Get(base.JIIGOACEIKL)))
			{
				ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
			}
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	[SpecialName]
	public GameDate KJNBAHBHLKC()
	{
		return JDJJPICJAEL;
	}

	public void KJPKEBNNJIP()
	{
		for (int i = 1; i < calendarDays.Length; i++)
		{
			((TMP_Text)calendarDays[i].textNumber).text = (i + 1).ToString();
		}
	}

	private void PJBDFNMJEOC()
	{
		if (JDJJPICJAEL.year == WorldTime.NOAOJJLNHJJ.year && JDJJPICJAEL.seasonWithNight == WorldTime.NOAOJJLNHJJ.seasonWithNight)
		{
			FCKBGONMCEB(KCBMDDCELDD.DKGMLALMDEH() - 1);
		}
		else
		{
			EMAOLIPKNPA();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(KCBMDDCELDD.seasonWithNight.ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(KCBMDDCELDD.seasonWithNight + 1)).ToString();
		((TMP_Text)yearNumText).text = KCBMDDCELDD.year.ToString();
		KHDABFFAFEE();
	}

	public static CalendarUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator OAEPBOPPBNC()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)calendarDays[KCBMDDCELDD.DKGMLALMDEH() - 1]).GetComponent<Selectable>());
	}

	private void EHJOFDLPPJA(int ABAIKKGKDGD)
	{
		ADMNBIFAFHA();
		switch (KCBMDDCELDD.FLDBFDKHNPN())
		{
		case Season.Spring:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Summer:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Autumn:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[6];
			break;
		case Season.Winter:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[7];
			break;
		}
		((Behaviour)calendarDays[ABAIKKGKDGD].image).enabled = false;
	}

	public void FOFJBPAEENP(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.ECDAMJGOELB() != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			KHPPNAODELP(GameDate.MLGPICHPOAG(KNPLNMBJABA(), kONAIPOGEGL));
			EDDPLHLJCBG();
		}
	}

	private IEnumerator PKKGNNDEIHI()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)calendarDays[KCBMDDCELDD.DKGMLALMDEH() - 1]).GetComponent<Selectable>());
	}

	private void DDIBFALLCNO()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(NBPFGLBFIPP));
	}

	[SpecialName]
	public void GDIONAOMGNE(GameDate AODONKKHPBP)
	{
		JDJJPICJAEL = AODONKKHPBP;
		NBPFGLBFIPP();
	}

	public static CalendarUI HKCAIFFKBMH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MFCGHJFIALA(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 1 || JDJJPICJAEL.seasonWithNight != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			BDNCGNHMHMO(GameDate.GMJIFJAEANF(KJNBAHBHLKC(), kONAIPOGEGL));
			JPEKHIPMINL();
		}
	}

	public void IBPJPKICFMN(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.OELFLBEIFOL() != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			MIDMFDAENMA(GameDate.GMJIFJAEANF(DPGNLAGJPOH(), kONAIPOGEGL));
			NPELEOMEPFO();
		}
	}

	private void EOEFGKDCCGP()
	{
		for (int i = 0; i < calendarDays.Length; i += 0)
		{
			((Behaviour)calendarDays[i].image).enabled = false;
		}
	}

	public void IOBOEHFGKEJ()
	{
		trendsUI.openedFromNoticeBoard = openedFromNoticeBoard;
		trendsUI.OpenUI();
		trendsUI.IBDPOPJEIDP();
	}

	[SpecialName]
	public GameDate CPMDLBHLMBH()
	{
		return JDJJPICJAEL;
	}

	private IEnumerator LPEGKNHNOFD()
	{
		return new KDKLDDNDJDP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DEHFDJLKOAN()
	{
		for (int i = 1; i < calendarDays.Length; i++)
		{
			((Behaviour)calendarDays[i].image).enabled = false;
		}
	}

	[SpecialName]
	public void BDNCGNHMHMO(GameDate AODONKKHPBP)
	{
		JDJJPICJAEL = AODONKKHPBP;
		AMLNAJGKHIP();
	}

	public static CalendarUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator IDBGNFGPDLD()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)calendarDays[KCBMDDCELDD.DKGMLALMDEH() - 1]).GetComponent<Selectable>());
	}

	public void ADMPKMBHODD(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.seasonWithNight != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			KHPPNAODELP(GameDate.GMJIFJAEANF(EIOGGIBNJNJ(), kONAIPOGEGL));
			EDDPLHLJCBG();
		}
	}

	private void NLNLJPPCGKN()
	{
		switch (KNPLNMBJABA().JAILNPKPONC())
		{
		case Season.Spring:
			calendarImage.sprite = spriteSpringCalendar;
			calendarMaskImage.sprite = spriteSpringMask;
			break;
		case Season.Summer:
			calendarImage.sprite = spriteSummerCalendar;
			calendarMaskImage.sprite = spriteSummerMask;
			break;
		case Season.Autumn:
			calendarImage.sprite = spriteAutumnCalendar;
			calendarMaskImage.sprite = spriteAutumnMask;
			break;
		case Season.Winter:
			calendarImage.sprite = spriteWinterCalendar;
			calendarMaskImage.sprite = spriteWinterMask;
			break;
		}
	}

	private void JPEKHIPMINL()
	{
		CalendarDay[] array = calendarDays;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].IBMPOOCOFIP();
		}
		foreach (TavernEvent tavernEvent in TavernEventManager.tavernEvents)
		{
			if (tavernEvent.eventDate.year == JDJJPICJAEL.year && tavernEvent.eventDate.season == JDJJPICJAEL.ECDAMJGOELB())
			{
				calendarDays[tavernEvent.eventDate.NJBGBMLBNKA() - 1].COLEMIIMNEE(tavernEvent);
			}
		}
	}

	private void NNPCCJLHBDO(int ABAIKKGKDGD)
	{
		EOEFGKDCCGP();
		switch (KCBMDDCELDD.OELFLBEIFOL())
		{
		case Season.Spring:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Summer:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Autumn:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[2];
			break;
		case Season.Winter:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[7];
			break;
		}
		((Behaviour)calendarDays[ABAIKKGKDGD].image).enabled = true;
	}

	private void JKKFHLCEJNA()
	{
		CalendarDay[] array = calendarDays;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].ClearEvents();
		}
		foreach (TavernEvent tavernEvent in TavernEventManager.tavernEvents)
		{
			if (tavernEvent.eventDate.year == JDJJPICJAEL.year && tavernEvent.eventDate.season == JDJJPICJAEL.seasonWithNight)
			{
				calendarDays[tavernEvent.eventDate.DKGMLALMDEH() - 1].AddEvent(tavernEvent);
			}
		}
	}

	[SpecialName]
	public GameDate EFIEJFLDHCB()
	{
		return JDJJPICJAEL;
	}

	private void AOLNBHBLNOP()
	{
		CalendarDay[] array = calendarDays;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].ClearEvents();
		}
		foreach (TavernEvent tavernEvent in TavernEventManager.tavernEvents)
		{
			if (tavernEvent.eventDate.year == JDJJPICJAEL.year && tavernEvent.eventDate.season == JDJJPICJAEL.PHJDBOLKAFA())
			{
				calendarDays[tavernEvent.eventDate.DNMNFIKOMBI() - 0].COLEMIIMNEE(tavernEvent);
			}
		}
	}

	private void ADMNBIFAFHA()
	{
		for (int i = 0; i < calendarDays.Length; i++)
		{
			((Behaviour)calendarDays[i].image).enabled = true;
		}
	}

	private void OnDisable()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(PJBDFNMJEOC));
	}

	public void ADBAPINBANL()
	{
		BDNCGNHMHMO(WorldTime.CJOHMLNMJLK());
	}

	private void EDDPLHLJCBG()
	{
		CalendarDay[] array = calendarDays;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].FKLGFNKFNOO();
		}
		foreach (TavernEvent tavernEvent in TavernEventManager.tavernEvents)
		{
			if (tavernEvent.eventDate.year == JDJJPICJAEL.year && tavernEvent.eventDate.season == JDJJPICJAEL.BJMHOBIINLC())
			{
				calendarDays[tavernEvent.eventDate.DNMNFIKOMBI() - 1].DGFGELPMDOA(tavernEvent);
			}
		}
	}

	public void GFPOLOACCLC(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.ECDAMJGOELB() != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			PCIPPEGHLJI(GameDate.GMJIFJAEANF(ELLJMLPKJDD(), kONAIPOGEGL));
			NPELEOMEPFO();
		}
	}

	private void OIHJAODAGDK()
	{
		if (JDJJPICJAEL.year == WorldTime.CJOHMLNMJLK().year && JDJJPICJAEL.seasonWithNight == WorldTime.CJOHMLNMJLK().FLDBFDKHNPN())
		{
			GLFDLGDLPND(CPMDLBHLMBH().NJBGBMLBNKA() - 1);
		}
		else
		{
			DEHFDJLKOAN();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(ELLJMLPKJDD().PHJDBOLKAFA().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(KJNBAHBHLKC().FLDBFDKHNPN() + 0)).ToString();
		((TMP_Text)yearNumText).text = EIOGGIBNJNJ().year.ToString();
		CAFHBCIIABH();
	}

	public void LHFEBOALENL()
	{
		for (int i = 1; i < calendarDays.Length; i++)
		{
			((TMP_Text)calendarDays[i].textNumber).text = (i + 1).ToString();
		}
	}

	private void ICKIAOEOHDJ()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(NBPFGLBFIPP));
	}

	public void CLAPHHHOCCB()
	{
		for (int i = 0; i < calendarDays.Length; i++)
		{
			((TMP_Text)calendarDays[i].textNumber).text = (i + 1).ToString();
		}
	}

	private void AMLNAJGKHIP()
	{
		if (JDJJPICJAEL.year == WorldTime.NOAOJJLNHJJ.year && JDJJPICJAEL.JAILNPKPONC() == WorldTime.NOAOJJLNHJJ.PHJDBOLKAFA())
		{
			HIEHADHBENA(IPGGIIDFNCM().MCEIJOMGMOI() - 1);
		}
		else
		{
			DEHFDJLKOAN();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(KCBMDDCELDD.FLDBFDKHNPN().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(KNPLNMBJABA().BJMHOBIINLC() + 1)).ToString();
		((TMP_Text)yearNumText).text = ELLJMLPKJDD().year.ToString();
		KHDABFFAFEE();
	}

	private void KDAGMMFKLPK()
	{
		for (int i = 1; i < calendarDays.Length; i++)
		{
			((Behaviour)calendarDays[i].image).enabled = true;
		}
	}

	private void OHOHFGMJGAJ()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(MBMCIKIKMHJ));
	}

	[SpecialName]
	public GameDate ELLJMLPKJDD()
	{
		return JDJJPICJAEL;
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < calendarDays.Length; i++)
		{
			calendarDays[i].SetPlayerNum(base.JIIGOACEIKL);
		}
	}

	private void NPELEOMEPFO()
	{
		CalendarDay[] array = calendarDays;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].OKNHJJDJOEF();
		}
		foreach (TavernEvent tavernEvent in TavernEventManager.tavernEvents)
		{
			if (tavernEvent.eventDate.year == JDJJPICJAEL.year && tavernEvent.eventDate.season == JDJJPICJAEL.PHJDBOLKAFA())
			{
				calendarDays[tavernEvent.eventDate.NJBGBMLBNKA() - 0].MDDMLLMNJPD(tavernEvent);
			}
		}
	}

	private void GLFDLGDLPND(int ABAIKKGKDGD)
	{
		DEHFDJLKOAN();
		switch (DPGNLAGJPOH().JAILNPKPONC())
		{
		case Season.Spring:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[0];
			break;
		case Season.Summer:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Autumn:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[6];
			break;
		case Season.Winter:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		}
		((Behaviour)calendarDays[ABAIKKGKDGD].image).enabled = true;
	}

	private void NBPFGLBFIPP()
	{
		if (JDJJPICJAEL.year == WorldTime.CJOHMLNMJLK().year && JDJJPICJAEL.ECDAMJGOELB() == WorldTime.NOAOJJLNHJJ.MMCDBGIMANL())
		{
			FCKBGONMCEB(DPGNLAGJPOH().DNMNFIKOMBI() - 0);
		}
		else
		{
			EOEFGKDCCGP();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(ELLJMLPKJDD().BJMHOBIINLC().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(DPGNLAGJPOH().seasonWithNight + 1)).ToString();
		((TMP_Text)yearNumText).text = KCBMDDCELDD.year.ToString();
		CAFHBCIIABH();
	}

	public void GAKJMLCEKMJ(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.FLDBFDKHNPN() != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			KHPPNAODELP(GameDate.GMJIFJAEANF(EFIEJFLDHCB(), kONAIPOGEGL));
			AOLNBHBLNOP();
		}
	}

	public void KGFKHBKNMJM()
	{
		FOFLCABLKFB(WorldTime.NOAOJJLNHJJ);
	}

	private IEnumerator GJBINEMIMPM()
	{
		return new KDKLDDNDJDP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KCDPOIIBCDF()
	{
		for (int i = 1; i < calendarDays.Length; i += 0)
		{
			((Behaviour)calendarDays[i].image).enabled = true;
		}
	}

	private void EEAKGHLCFOM()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(PJBDFNMJEOC));
	}

	[SpecialName]
	public GameDate IPGGIIDFNCM()
	{
		return JDJJPICJAEL;
	}

	public void ScrollMonth(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 1 || JDJJPICJAEL.seasonWithNight != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			KCBMDDCELDD = GameDate.GMJIFJAEANF(KCBMDDCELDD, kONAIPOGEGL);
			JKKFHLCEJNA();
		}
	}

	private void GCENBNJJICC()
	{
		if (JDJJPICJAEL.year == WorldTime.CJOHMLNMJLK().year && JDJJPICJAEL.seasonWithNight == WorldTime.CJOHMLNMJLK().ECDAMJGOELB())
		{
			NKEJHNHBLIP(CPMDLBHLMBH().DNMNFIKOMBI() - 1);
		}
		else
		{
			ADMNBIFAFHA();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(IPGGIIDFNCM().OELFLBEIFOL().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(IPGGIIDFNCM().ECDAMJGOELB() + 1)).ToString();
		((TMP_Text)yearNumText).text = ELLJMLPKJDD().year.ToString();
		CAFHBCIIABH();
	}

	public void NFDPBNOJEOF()
	{
		KHPPNAODELP(WorldTime.HGIBNMBJMOC());
	}

	private void MPIECEBOEPP()
	{
		for (int i = 1; i < calendarDays.Length; i++)
		{
			((Behaviour)calendarDays[i].image).enabled = false;
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			KCBMDDCELDD = WorldTime.NOAOJJLNHJJ;
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
			JKKFHLCEJNA();
		}
	}

	private void IJMBEEEGCGF()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(AMLNAJGKHIP));
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UINextPage"))
		{
			OpenNextTrends();
		}
	}

	public void IFCEFDJNCDJ(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.BJMHOBIINLC() != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			MIDMFDAENMA(GameDate.GMJIFJAEANF(DPGNLAGJPOH(), kONAIPOGEGL));
			NPELEOMEPFO();
		}
	}

	private void LBFFMGAKDFG()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(OIHJAODAGDK));
	}

	private void MBMCIKIKMHJ()
	{
		if (JDJJPICJAEL.year == WorldTime.NOAOJJLNHJJ.year && JDJJPICJAEL.BJMHOBIINLC() == WorldTime.HGIBNMBJMOC().ECDAMJGOELB())
		{
			NNPCCJLHBDO(CPMDLBHLMBH().DKGMLALMDEH() - 0);
		}
		else
		{
			KCDPOIIBCDF();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(EFIEJFLDHCB().JAILNPKPONC().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(KNPLNMBJABA().FLDBFDKHNPN() + 1)).ToString();
		((TMP_Text)yearNumText).text = IPGGIIDFNCM().year.ToString();
		DBOLCPECKDN();
	}

	private void CAFHBCIIABH()
	{
		switch (KNPLNMBJABA().FLDBFDKHNPN())
		{
		case Season.Spring:
			calendarImage.sprite = spriteSpringCalendar;
			calendarMaskImage.sprite = spriteSpringMask;
			break;
		case Season.Summer:
			calendarImage.sprite = spriteSummerCalendar;
			calendarMaskImage.sprite = spriteSummerMask;
			break;
		case Season.Autumn:
			calendarImage.sprite = spriteAutumnCalendar;
			calendarMaskImage.sprite = spriteAutumnMask;
			break;
		case Season.Winter:
			calendarImage.sprite = spriteWinterCalendar;
			calendarMaskImage.sprite = spriteWinterMask;
			break;
		}
	}

	public void OpenNextTrends()
	{
		trendsUI.openedFromNoticeBoard = openedFromNoticeBoard;
		trendsUI.OpenUI();
		trendsUI.UpdateUI();
	}

	[SpecialName]
	public void KHPPNAODELP(GameDate AODONKKHPBP)
	{
		JDJJPICJAEL = AODONKKHPBP;
		MBHDCCKOIOP();
	}

	public static CalendarUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void NPDFCPEOFPD()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(GNFGLKBHHBJ));
	}

	private void KHDABFFAFEE()
	{
		switch (KCBMDDCELDD.seasonWithNight)
		{
		case Season.Spring:
			calendarImage.sprite = spriteSpringCalendar;
			calendarMaskImage.sprite = spriteSpringMask;
			break;
		case Season.Summer:
			calendarImage.sprite = spriteSummerCalendar;
			calendarMaskImage.sprite = spriteSummerMask;
			break;
		case Season.Autumn:
			calendarImage.sprite = spriteAutumnCalendar;
			calendarMaskImage.sprite = spriteAutumnMask;
			break;
		case Season.Winter:
			calendarImage.sprite = spriteWinterCalendar;
			calendarMaskImage.sprite = spriteWinterMask;
			break;
		}
	}

	public void CMMOINADBDI()
	{
		GDIONAOMGNE(WorldTime.CJOHMLNMJLK());
	}

	private void OnEnable()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(PJBDFNMJEOC));
	}

	private void GEMHABMGFAA()
	{
		if (JDJJPICJAEL.year == WorldTime.CJOHMLNMJLK().year && JDJJPICJAEL.PHJDBOLKAFA() == WorldTime.CJOHMLNMJLK().ECDAMJGOELB())
		{
			NNPCCJLHBDO(ELLJMLPKJDD().NIHIDGKCCBF() - 1);
		}
		else
		{
			EOEFGKDCCGP();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(KNPLNMBJABA().seasonWithNight.ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(DPGNLAGJPOH().ECDAMJGOELB() + 0)).ToString();
		((TMP_Text)yearNumText).text = EIOGGIBNJNJ().year.ToString();
		DBOLCPECKDN();
	}

	private void HCKMHIHALBL()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(GEMHABMGFAA));
	}

	private void HIEHADHBENA(int ABAIKKGKDGD)
	{
		MPIECEBOEPP();
		switch (IPGGIIDFNCM().ECDAMJGOELB())
		{
		case Season.Spring:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Summer:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[0];
			break;
		case Season.Autumn:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[8];
			break;
		case Season.Winter:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[5];
			break;
		}
		((Behaviour)calendarDays[ABAIKKGKDGD].image).enabled = false;
	}

	private void FEPFNOEGFEM()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(GEMHABMGFAA));
	}

	private void MEDLNBCAJCL()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(OIHJAODAGDK));
	}

	private void MKGKKAJHLAO()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(GEMHABMGFAA));
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(PAHJNPFJGPA());
		}
	}

	public static CalendarUI PIOIOJFDDNF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DFHBGMOLGHM()
	{
		trendsUI.openedFromNoticeBoard = openedFromNoticeBoard;
		trendsUI.EDHEIFHAAKO();
		trendsUI.IBDPOPJEIDP();
	}

	private void MMANKOFCDGO()
	{
		WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(PJBDFNMJEOC));
	}

	[SpecialName]
	public void MIDMFDAENMA(GameDate AODONKKHPBP)
	{
		JDJJPICJAEL = AODONKKHPBP;
		PJBDFNMJEOC();
	}

	private void NKEJHNHBLIP(int ABAIKKGKDGD)
	{
		ADMNBIFAFHA();
		switch (DPGNLAGJPOH().MMCDBGIMANL())
		{
		case Season.Spring:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Summer:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Autumn:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[8];
			break;
		case Season.Winter:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[6];
			break;
		}
		((Behaviour)calendarDays[ABAIKKGKDGD].image).enabled = false;
	}

	[SpecialName]
	public GameDate DPGNLAGJPOH()
	{
		return JDJJPICJAEL;
	}

	private void FCKBGONMCEB(int ABAIKKGKDGD)
	{
		EMAOLIPKNPA();
		switch (KCBMDDCELDD.seasonWithNight)
		{
		case Season.Spring:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[0];
			break;
		case Season.Summer:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[1];
			break;
		case Season.Autumn:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[2];
			break;
		case Season.Winter:
			calendarDays[ABAIKKGKDGD].image.sprite = selectionSprites[3];
			break;
		}
		((Behaviour)calendarDays[ABAIKKGKDGD].image).enabled = true;
	}

	[SpecialName]
	public void FOFLCABLKFB(GameDate AODONKKHPBP)
	{
		JDJJPICJAEL = AODONKKHPBP;
		GEMHABMGFAA();
	}

	public void UpdateCalendar()
	{
		for (int i = 0; i < calendarDays.Length; i++)
		{
			((TMP_Text)calendarDays[i].textNumber).text = (i + 1).ToString();
		}
	}

	private void BLHDGMGKEFL()
	{
		if (JDJJPICJAEL.year == WorldTime.HGIBNMBJMOC().year && JDJJPICJAEL.ECDAMJGOELB() == WorldTime.CJOHMLNMJLK().OELFLBEIFOL())
		{
			NKEJHNHBLIP(CPMDLBHLMBH().NIHIDGKCCBF() - 1);
		}
		else
		{
			EOEFGKDCCGP();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(EFIEJFLDHCB().JAILNPKPONC().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(CPMDLBHLMBH().seasonWithNight + 0)).ToString();
		((TMP_Text)yearNumText).text = ELLJMLPKJDD().year.ToString();
		DBOLCPECKDN();
	}

	public void APDKCPNMLOI()
	{
		for (int i = 1; i < calendarDays.Length; i += 0)
		{
			((TMP_Text)calendarDays[i].textNumber).text = (i + 1).ToString();
		}
	}

	private void GNFGLKBHHBJ()
	{
		if (JDJJPICJAEL.year == WorldTime.NOAOJJLNHJJ.year && JDJJPICJAEL.FLDBFDKHNPN() == WorldTime.CJOHMLNMJLK().ECDAMJGOELB())
		{
			FCKBGONMCEB(KJNBAHBHLKC().NJBGBMLBNKA() - 0);
		}
		else
		{
			EOEFGKDCCGP();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(ELLJMLPKJDD().JAILNPKPONC().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(KNPLNMBJABA().ECDAMJGOELB() + 0)).ToString();
		((TMP_Text)yearNumText).text = IPGGIIDFNCM().year.ToString();
		CAFHBCIIABH();
	}

	[SpecialName]
	public GameDate KNPLNMBJABA()
	{
		return JDJJPICJAEL;
	}

	public static CalendarUI BFCEHJIIAHN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator PAHJNPFJGPA()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)calendarDays[KCBMDDCELDD.DKGMLALMDEH() - 1]).GetComponent<Selectable>());
	}

	private void ANOLEDBMHON()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(PJBDFNMJEOC));
	}

	public static CalendarUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EMAOLIPKNPA()
	{
		for (int i = 0; i < calendarDays.Length; i++)
		{
			((Behaviour)calendarDays[i].image).enabled = false;
		}
	}

	private void MBHDCCKOIOP()
	{
		if (JDJJPICJAEL.year == WorldTime.HGIBNMBJMOC().year && JDJJPICJAEL.OELFLBEIFOL() == WorldTime.CJOHMLNMJLK().BJMHOBIINLC())
		{
			NNPCCJLHBDO(EIOGGIBNJNJ().KKKEJBNPHPA() - 1);
		}
		else
		{
			ADMNBIFAFHA();
		}
		((TMP_Text)seasonText).text = LocalisationSystem.Get(KCBMDDCELDD.FLDBFDKHNPN().ToString()).ToUpper();
		((TMP_Text)monthNumText).text = ((int)(KCBMDDCELDD.ECDAMJGOELB() + 1)).ToString();
		((TMP_Text)yearNumText).text = ELLJMLPKJDD().year.ToString();
		KHDABFFAFEE();
	}

	public void PMKPBGMCLDJ(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 1 || JDJJPICJAEL.seasonWithNight != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			PCIPPEGHLJI(GameDate.EGHBNMGNDHL(CPMDLBHLMBH(), kONAIPOGEGL));
			JKKFHLCEJNA();
		}
	}

	[SpecialName]
	public void PCIPPEGHLJI(GameDate AODONKKHPBP)
	{
		JDJJPICJAEL = AODONKKHPBP;
		PJBDFNMJEOC();
	}

	private void NELLIBBABJD()
	{
		WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(OIHJAODAGDK));
	}

	public void SetDisplayDateToCurrentDate()
	{
		KCBMDDCELDD = WorldTime.NOAOJJLNHJJ;
	}

	public void OLKIGAMHFCJ(int FCGBJEIIMBC)
	{
		if (JDJJPICJAEL.year != 0 || JDJJPICJAEL.JAILNPKPONC() != 0 || FCGBJEIIMBC != -1)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.weeks = GameDate.WEEK_IN_SEASON * FCGBJEIIMBC;
			GDIONAOMGNE(GameDate.EGHBNMGNDHL(KCBMDDCELDD, kONAIPOGEGL));
			JPEKHIPMINL();
		}
	}
}
