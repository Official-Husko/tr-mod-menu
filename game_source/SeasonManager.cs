using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SeasonManager : MonoBehaviour, ISingleton
{
	public static SeasonManager instance;

	public Action<Season> OnSeasonChanged = delegate
	{
	};

	public Season seasonInMap;

	public static Season EECEKHKAAIH
	{
		get
		{
			if (!Application.isPlaying)
			{
				return Season.Spring;
			}
			return WorldTime.NOAOJJLNHJJ.seasonWithNight;
		}
	}

	public static CropSeason ACNAHALFEBG => SeasonToCropSeason(EECEKHKAAIH);

	private void CACJMKJBJDP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(AJLNDFPNBLK));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JFFJNPFGHBI));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public static CropSeason LCGFNOJPGJF(Season EECEKHKAAIH)
	{
		return EECEKHKAAIH switch
		{
			Season.Spring => CropSeason.Spring, 
			Season.Summer => CropSeason.Spring, 
			(Season)7 => CropSeason.Winter, 
			_ => CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn, 
		};
	}

	public void CLEKENDLCKD()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = false;
		if (WorldTime.CJOHMLNMJLK().season != seasonInMap)
		{
			AJFAKNHLGNB(WorldTime.NOAOJJLNHJJ.season);
		}
	}

	private void EACIGGOOKGD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJGIEMCPPPF(WorldTime.NOAOJJLNHJJ.season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DPNHEJKKCBL));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NJNEKKGKEKA));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CJNCGHMNJME));
	}

	public static CropSeason OFJMBHOKIMA()
	{
		if (NHKAHEEGEGF() == Season.Spring)
		{
			return CropSeason.Spring | CropSeason.Summer;
		}
		if (EEGJBDCBKFD() == Season.Summer)
		{
			return CropSeason.Spring;
		}
		if (BLCGOEMGKGH() == (Season)6)
		{
			return CropSeason.Spring | CropSeason.Autumn;
		}
		return CropSeason.None;
	}

	public static CropSeason DBILODAOMAB(Season EECEKHKAAIH)
	{
		return EECEKHKAAIH switch
		{
			Season.Spring => CropSeason.Spring, 
			Season.Summer => CropSeason.Spring | CropSeason.Summer, 
			(Season)5 => CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn, 
			_ => CropSeason.None, 
		};
	}

	public void DPNHEJKKCBL()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = false;
		if (WorldTime.HGIBNMBJMOC().season != seasonInMap)
		{
			NMMLELDCBBJ(WorldTime.NOAOJJLNHJJ.season);
		}
	}

	private void CAOKPIIFHBJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OGKNMEMHHEK(WorldTime.HGIBNMBJMOC().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ChangeSeasonIfIsPossible));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MBDFJIOFBCF));
	}

	public void ANIIHEIACFM()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = false;
		if (WorldTime.NOAOJJLNHJJ.season != seasonInMap)
		{
			AJFAKNHLGNB(WorldTime.NOAOJJLNHJJ.season);
		}
	}

	private void HFFFFAJFIPB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			EBJINCHPBJB(WorldTime.CJOHMLNMJLK().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NJNEKKGKEKA));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MBDFJIOFBCF));
	}

	public static bool NDPJFGABFNP()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static CropSeason ADPMPPPLOLI()
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.Winter;
		}
		if (LPGPJPPLHKG() == Season.Spring)
		{
			return CropSeason.None;
		}
		if (ADEICKHEPFI() == (Season)4)
		{
			return CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn;
		}
		return CropSeason.Spring;
	}

	private void BDDBDNPCPGC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(DPNHEJKKCBL));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PDFPAIEANDP));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public void JDFDLEEELFH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ANIIHEIACFM();
		}
	}

	public void HMHNGIJDFJA()
	{
	}

	private void AIILKEGPDME()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				AJLNDFPNBLK();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static CropSeason IOJJBLDJLNH(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.None;
		}
		return EECEKHKAAIH switch
		{
			Season.Spring => CropSeason.Spring | CropSeason.Summer, 
			(Season)6 => CropSeason.Summer, 
			_ => CropSeason.None, 
		};
	}

	private void Awake()
	{
		instance = this;
	}

	public static CropSeason GetPreviousCropSeason()
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.Winter;
		}
		if (EECEKHKAAIH == Season.Summer)
		{
			return CropSeason.Spring;
		}
		if (EECEKHKAAIH == Season.Autumn)
		{
			return CropSeason.Summer;
		}
		return CropSeason.Spring;
	}

	private void OAOGEEENNKA()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				ChangeSeasonIfIsPossible();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	[SpecialName]
	public static CropSeason IIJKFKJKLLM()
	{
		return DBILODAOMAB(PJMGHIMKFJL());
	}

	[SpecialName]
	public static Season BLCGOEMGKGH()
	{
		if (!Application.isPlaying)
		{
			return Season.Summer;
		}
		return WorldTime.NOAOJJLNHJJ.OELFLBEIFOL();
	}

	[SpecialName]
	public static CropSeason MBPMIFPEAJP()
	{
		return SeasonToCropSeason(ADEICKHEPFI());
	}

	private void NFABFPFLNEE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			NMMLELDCBBJ(WorldTime.NOAOJJLNHJJ.season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(LBFGLNEOPFD));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NJNEKKGKEKA));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MBDFJIOFBCF));
	}

	public static CropSeason IENCGPPIANH()
	{
		if (ADEICKHEPFI() == Season.Spring)
		{
			return CropSeason.Spring | CropSeason.Autumn;
		}
		if (BLCGOEMGKGH() == Season.Spring)
		{
			return CropSeason.None;
		}
		if (KCJFCHNPIBJ() == (Season)6)
		{
			return CropSeason.Winter;
		}
		return CropSeason.Spring;
	}

	public void AJFAKNHLGNB(Season EECEKHKAAIH)
	{
		GameDate aODONKKHPBP = WorldTime.CJOHMLNMJLK();
		aODONKKHPBP.season = EECEKHKAAIH;
		WorldTime.OFHDFEONCOL(aODONKKHPBP);
		WorldTime.GMAPCOKNNAI();
		seasonInMap = EECEKHKAAIH;
		OnSeasonChanged(EECEKHKAAIH);
	}

	private void ALCJOABPBMA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FFFJENNJMFG));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OLCKOFPKOHM));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public void LBFGLNEOPFD()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = true;
		if (WorldTime.CJOHMLNMJLK().season != seasonInMap)
		{
			NMMLELDCBBJ(WorldTime.HGIBNMBJMOC().season);
		}
	}

	private void HOKBBFHGACN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CJGIEMCPPPF(WorldTime.CJOHMLNMJLK().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(LOIDOPMHOGN));
	}

	[SpecialName]
	public static CropSeason BBOEGCKFMOH()
	{
		return LCGFNOJPGJF(PJMGHIMKFJL());
	}

	public static CropSeason SeasonToCropSeason(Season EECEKHKAAIH)
	{
		return EECEKHKAAIH switch
		{
			Season.Spring => CropSeason.Spring, 
			Season.Summer => CropSeason.Summer, 
			Season.Autumn => CropSeason.Autumn, 
			_ => CropSeason.Winter, 
		};
	}

	private void HELHNJDFPPF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OGKNMEMHHEK(WorldTime.NOAOJJLNHJJ.season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(AJLNDFPNBLK));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EODPIKFPHPK));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OCHBKMJLCGN));
	}

	public void FFFJENNJMFG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LBFGLNEOPFD();
		}
	}

	public void OnWorldLoaded()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ChangeSeasonIfIsPossible();
		}
	}

	public static bool FDPCPOLFJNO()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void MMPJMJAOJOO()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = true;
		if (WorldTime.CJOHMLNMJLK().season != seasonInMap)
		{
			CJGIEMCPPPF(WorldTime.HGIBNMBJMOC().season);
		}
	}

	public void EMDFCOLKMNI()
	{
	}

	public static bool CABCLEFJMBP()
	{
		return (Object)(object)instance != (Object)null;
	}

	[SpecialName]
	public static Season LPGPJPPLHKG()
	{
		if (!Application.isPlaying)
		{
			return Season.Summer;
		}
		return WorldTime.NOAOJJLNHJJ.FLDBFDKHNPN();
	}

	public static CropSeason KJCNKFEICPC(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.None;
		}
		return EECEKHKAAIH switch
		{
			Season.Spring => CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn, 
			(Season)6 => CropSeason.Spring | CropSeason.Summer, 
			_ => CropSeason.Spring | CropSeason.Autumn, 
		};
	}

	private void FJOCCFEFHHG()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				MMPJMJAOJOO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void PKPGJJGOLGE()
	{
	}

	private void PDFPAIEANDP()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				CLEKENDLCKD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static bool BNPNHMOAGCC()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void LNPDALMANFB()
	{
		instance = this;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(ChangeSeasonIfIsPossible));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CJNCGHMNJME));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void CJNCGHMNJME()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				ChangeSeasonIfIsPossible();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void LOIDOPMHOGN()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				LBFGLNEOPFD();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void PMHNOIOIKOH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			AJLNDFPNBLK();
		}
	}

	public void EBJINCHPBJB(Season EECEKHKAAIH)
	{
		GameDate currentGameDate = WorldTime.CJOHMLNMJLK();
		currentGameDate.season = EECEKHKAAIH;
		WorldTime.NOAOJJLNHJJ = currentGameDate;
		WorldTime.CalcCurrentDayTimeSec();
		seasonInMap = EECEKHKAAIH;
		OnSeasonChanged(EECEKHKAAIH);
	}

	public static CropSeason IMKOHOBOEMJ()
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn;
		}
		if (EEGJBDCBKFD() == Season.Summer)
		{
			return CropSeason.None;
		}
		if (ADEICKHEPFI() == Season.Autumn)
		{
			return CropSeason.Spring | CropSeason.Summer;
		}
		return CropSeason.Spring;
	}

	private void CEIIFHIBIFI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChangeSeason(WorldTime.CJOHMLNMJLK().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ANIIHEIACFM));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JDFDLEEELFH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MBDFJIOFBCF));
	}

	private void JFFJNPFGHBI()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				MMPJMJAOJOO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static bool HOEFBJIFBAO()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static bool CGGBKGLEHKF()
	{
		return (Object)(object)instance != (Object)null;
	}

	[SpecialName]
	public static CropSeason OPKHCOODFKF()
	{
		return KJCNKFEICPC(LPGPJPPLHKG());
	}

	private void HEGNINLLINP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NJNEKKGKEKA));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JFFJNPFGHBI));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void IAKHGGHENAA()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				ChangeSeasonIfIsPossible();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(CLEKENDLCKD));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(AIILKEGPDME));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public void DFPDNPABDBG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			AJLNDFPNBLK();
		}
	}

	public void NEJABGEEFJF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChangeSeasonIfIsPossible();
		}
	}

	[SpecialName]
	public static CropSeason ANAGGDHOCIF()
	{
		return LCGFNOJPGJF(NHKAHEEGEGF());
	}

	private void BNIKICAEIND()
	{
		if (OnlineManager.MasterOrOffline())
		{
			NMMLELDCBBJ(WorldTime.HGIBNMBJMOC().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FFFJENNJMFG));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MBDFJIOFBCF));
	}

	private void NNBIAIMPNGL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ChangeSeason(WorldTime.HGIBNMBJMOC().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JDFDLEEELFH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(LOIDOPMHOGN));
	}

	public static bool FIDIBJDLFFB()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static bool MBHNNMJBCFC()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static bool DMMEJMAGKII()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void ResetSingleton()
	{
	}

	public static CropSeason KCLNLLMKHOG(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.Spring;
		}
		return EECEKHKAAIH switch
		{
			Season.Spring => CropSeason.None, 
			Season.Winter => CropSeason.Summer | CropSeason.Autumn, 
			_ => CropSeason.None, 
		};
	}

	private void MBDFJIOFBCF()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				MMPJMJAOJOO();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	[SpecialName]
	public static Season ADEICKHEPFI()
	{
		if (!Application.isPlaying)
		{
			return Season.Spring;
		}
		return WorldTime.HGIBNMBJMOC().BJMHOBIINLC();
	}

	public void AJLNDFPNBLK()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = true;
		if (WorldTime.NOAOJJLNHJJ.season != seasonInMap)
		{
			EBJINCHPBJB(WorldTime.CJOHMLNMJLK().season);
		}
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			ChangeSeason(WorldTime.NOAOJJLNHJJ.season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ChangeSeasonIfIsPossible));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CJNCGHMNJME));
	}

	private void FPDPAJHNGHK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NMMLELDCBBJ(WorldTime.CJOHMLNMJLK().season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DPNHEJKKCBL));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CJNCGHMNJME));
	}

	public void NJNEKKGKEKA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MMPJMJAOJOO();
		}
	}

	public void EODPIKFPHPK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DPNHEJKKCBL();
		}
	}

	public static bool FLHFMPHCEKA()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void OCHBKMJLCGN()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				ChangeSeasonIfIsPossible();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void AKPLLNELLJK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(DPNHEJKKCBL));
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(IAKHGGHENAA));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public void ChangeSeasonIfIsPossible()
	{
		TitleScreen.GetInstance().waitingForSeasonChanges = false;
		if (WorldTime.NOAOJJLNHJJ.season != seasonInMap)
		{
			ChangeSeason(WorldTime.NOAOJJLNHJJ.season);
		}
	}

	[SpecialName]
	public static CropSeason IEMEBFFIKMD()
	{
		return SeasonToCropSeason(KCJFCHNPIBJ());
	}

	public static CropSeason AOCBIDAKCLJ()
	{
		if (LPGPJPPLHKG() == Season.Spring)
		{
			return CropSeason.Autumn;
		}
		if (KCJFCHNPIBJ() == Season.Summer)
		{
			return CropSeason.Spring;
		}
		if (KCJFCHNPIBJ() == Season.Winter)
		{
			return CropSeason.Summer | CropSeason.Autumn;
		}
		return CropSeason.None;
	}

	public static bool EPBHPOHDAFI()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void AGPONCCIFHC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(LBFGLNEOPFD));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DFPDNPABDBG));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PDFPAIEANDP));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	public void CJGIEMCPPPF(Season EECEKHKAAIH)
	{
		GameDate aODONKKHPBP = WorldTime.HGIBNMBJMOC();
		aODONKKHPBP.season = EECEKHKAAIH;
		WorldTime.OFHDFEONCOL(aODONKKHPBP);
		WorldTime.DMOBDEGAJFH();
		seasonInMap = EECEKHKAAIH;
		OnSeasonChanged(EECEKHKAAIH);
	}

	[SpecialName]
	public static CropSeason NNDMODNDPLO()
	{
		return DBILODAOMAB(BLCGOEMGKGH());
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
	}

	[SpecialName]
	public static Season NHKAHEEGEGF()
	{
		if (!Application.isPlaying)
		{
			return Season.Summer;
		}
		return WorldTime.NOAOJJLNHJJ.OELFLBEIFOL();
	}

	public static CropSeason OPFKDDIJOJD()
	{
		if (BLCGOEMGKGH() == Season.Spring)
		{
			return CropSeason.Summer;
		}
		if (EECEKHKAAIH == Season.Summer)
		{
			return CropSeason.Spring;
		}
		if (NHKAHEEGEGF() == Season.Winter)
		{
			return CropSeason.Spring | CropSeason.Autumn;
		}
		return CropSeason.Spring;
	}

	public static bool BELCCHBEFKE()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void IDGFNHMCDPB()
	{
	}

	private void EFJFJJDGGGI()
	{
		instance = this;
	}

	public void OGKNMEMHHEK(Season EECEKHKAAIH)
	{
		GameDate aODONKKHPBP = WorldTime.HGIBNMBJMOC();
		aODONKKHPBP.season = EECEKHKAAIH;
		WorldTime.OFHDFEONCOL(aODONKKHPBP);
		WorldTime.ODEBIGOLHBN();
		seasonInMap = EECEKHKAAIH;
		OnSeasonChanged(EECEKHKAAIH);
	}

	[SpecialName]
	public static Season EEGJBDCBKFD()
	{
		if (!Application.isPlaying)
		{
			return Season.Spring;
		}
		return WorldTime.HGIBNMBJMOC().JAILNPKPONC();
	}

	public void ChangeSeason(Season EECEKHKAAIH)
	{
		GameDate currentGameDate = WorldTime.NOAOJJLNHJJ;
		currentGameDate.season = EECEKHKAAIH;
		WorldTime.NOAOJJLNHJJ = currentGameDate;
		WorldTime.CalcCurrentDayTimeSec();
		seasonInMap = EECEKHKAAIH;
		OnSeasonChanged(EECEKHKAAIH);
	}

	public static bool GGHGMCEPDKG()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void NMMLELDCBBJ(Season EECEKHKAAIH)
	{
		GameDate aODONKKHPBP = WorldTime.HGIBNMBJMOC();
		aODONKKHPBP.season = EECEKHKAAIH;
		WorldTime.LKEPKFBGKOH(aODONKKHPBP);
		WorldTime.GMAPCOKNNAI();
		seasonInMap = EECEKHKAAIH;
		OnSeasonChanged(EECEKHKAAIH);
	}

	public static bool ICPPNLMIIEC()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static CropSeason GGALEPCMBID(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			return CropSeason.None;
		case Season.Summer:
			return CropSeason.Autumn;
		default:
			if (EECEKHKAAIH == Season.Spring)
			{
				return CropSeason.Summer | CropSeason.Autumn;
			}
			return CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn;
		}
	}

	public void GHGFJOALEGA()
	{
	}

	public static CropSeason PGHAPBCDBCA()
	{
		if (BLCGOEMGKGH() == Season.Spring)
		{
			return CropSeason.Autumn;
		}
		if (BLCGOEMGKGH() == Season.Summer)
		{
			return CropSeason.Spring;
		}
		if (EECEKHKAAIH == Season.Spring)
		{
			return CropSeason.Autumn;
		}
		return CropSeason.Spring;
	}

	public static bool MLGNJKMFAEN()
	{
		return (Object)(object)instance != (Object)null;
	}

	private void KACEOJDPLKB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OGKNMEMHHEK(WorldTime.NOAOJJLNHJJ.season);
		}
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ChangeSeasonIfIsPossible));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(JFFJNPFGHBI));
	}

	[SpecialName]
	public static Season KCJFCHNPIBJ()
	{
		if (!Application.isPlaying)
		{
			return Season.Spring;
		}
		return WorldTime.CJOHMLNMJLK().OELFLBEIFOL();
	}

	[SpecialName]
	public static Season PJMGHIMKFJL()
	{
		if (!Application.isPlaying)
		{
			return Season.Summer;
		}
		return WorldTime.HGIBNMBJMOC().FLDBFDKHNPN();
	}

	public void ADGPJJJIIME()
	{
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(MMPJMJAOJOO));
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FFFJENNJMFG));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JFFJNPFGHBI));
			}
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void OLCKOFPKOHM()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				AJLNDFPNBLK();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}
}
