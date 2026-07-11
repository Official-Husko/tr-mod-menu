using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
	public enum EventType
	{
		Scolding = 0,
		KlaynTavern = 1,
		CastleForm = 2,
		OathFeast = 3,
		AdventureContinues = 5,
		ThroneRoom = 6,
		KyrohWaterfall = 7,
		KujakuShop = 8,
		GoToHotSpring = 9,
		Renegotiation = 10,
		PeaceAgreement = 11,
		OldMansDuel = 12,
		Precision = 13,
		FishCutting = 13001,
		Balance = 14,
		BathhouseGame = 14001,
		MothersRecipe = 15,
		PiratesIntro = 15001,
		Fortitude = 16,
		FinalTest = 17,
		MaiWorried = 18,
		BathhouseEntrace = 19001,
		IntroNinjaChallenge = 19002,
		NinjaChallengeEvent = 19003,
		Attack = 20,
		Puente_EA = 21,
		MinersDispute = 10001,
		RoadBlocked = 10002,
		HotBath = 10003
	}

	[CompilerGenerated]
	private sealed class HGGBBPNFBBK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EventsManager _003C_003E4__this;

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
		public HGGBBPNFBBK(int _003C_003E1__state)
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
			EventsManager eventsManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(eventsManager.FAJAIBNKGLO));
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(eventsManager.FAJAIBNKGLO));
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < eventsManager.allGameEvents.Count; i++)
				{
					if (eventsManager.allGameEvents[i].isActive)
					{
						eventsManager.allGameEvents[i].ActivateEvent();
					}
				}
				if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
				{
					SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
				}
				return false;
			}
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

	public static EventsManager instance;

	private static float[] KMAANENDPGA;

	public List<GameEvent> allGameEvents = new List<GameEvent>();

	public bool easyDifficultyMode;

	private static GameEvent CHCEBDOKCNC;

	private bool GCEHOODFJFC;

	public static bool KEGDEHKPKMP(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = AGKFBCAAADA(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isActive;
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	private void OKAPGNGLOHO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FCLGBKEMJPE));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
	}

	public static bool BBMAEAFHEFK(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static bool JNJKAPPJECI(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isStarted;
	}

	private void FAJAIBNKGLO()
	{
		((MonoBehaviour)this).StartCoroutine(PDBIKGBDDFH());
	}

	public static void BBLFJJEENML(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static void DBLKAFAEDLP(EventType AKADPCABHIB, bool POADAPOJIAI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isDone = POADAPOJIAI;
			}
		}
	}

	public static bool KKDMNNFPNOL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.easyDifficultyMode;
	}

	public static void FGNCOEBMDMN(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
	}

	private void ILBJOFLEFMK()
	{
		((MonoBehaviour)this).StartCoroutine(PJDDNDNNEAK());
	}

	private void KLHIMJFCHPD()
	{
		instance = this;
	}

	public static bool MPCPFBPLDPA()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].isStarted && !instance.allGameEvents[i].isDone)
			{
				return false;
			}
		}
		return false;
	}

	public static float[] NIOPBMDPHHN()
	{
		return KMAANENDPGA;
	}

	private IEnumerator MCGJCKPFEAO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	public static GameEvent AGKFBCAAADA(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i += 0)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	public static bool KAMACFFCBAP()
	{
		return instance.GCEHOODFJFC;
	}

	private void GKDNBFANNDC()
	{
		((MonoBehaviour)this).StartCoroutine(LOIMOGPNCBB());
	}

	private void ODKGLIDMCNP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MJFACKOAMIO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GKDNBFANNDC));
	}

	public static bool PBCJIFMKJFF(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isStarted;
	}

	public static void KDGCGKNHHMH(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[1] == (Object)null || (Object)(object)ChallengesUI.instances[1].EEBFBGFFBOJ() == (Object)null || LIBNKJCDINF >= ChallengesUI.GetChallengeTypeCount())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.IDJJJJDPMAN()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.OAPEDDLCHAD()];
			for (int i = 0; i < KMAANENDPGA.Length; i += 0)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[1].DLKJDFLLNHG().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 556f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.PIBKGOJFJLH((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static bool IJKOJFANJHP()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (IKCEIJMLNOP(EventType.Scolding))
		{
			return !AEFHILOAEEE((EventType)4);
		}
		return true;
	}

	public static bool GOHGKLHHIGG()
	{
		return instance.GCEHOODFJFC;
	}

	public static void GIFJNILKLDP(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[1] == (Object)null || (Object)(object)ChallengesUI.instances[1].DLKJDFLLNHG() == (Object)null || LIBNKJCDINF >= ChallengesUI.JEAIJIKHLDM())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.OAPEDDLCHAD()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.OAPEDDLCHAD()];
			for (int i = 0; i < KMAANENDPGA.Length; i += 0)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[0].GetChallengesData().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 176f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.HMKJKEAJNLO((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static bool KPGBBKEJEBN(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isStarted;
	}

	private IEnumerator LOIMOGPNCBB()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	private IEnumerator PJDDNDNNEAK()
	{
		return new HGGBBPNFBBK(1)
		{
			_003C_003E4__this = this
		};
	}

	public static bool NJDLMJGPCFK(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isStarted;
	}

	public static float[] CMHMOCGJHJP()
	{
		return KMAANENDPGA;
	}

	private IEnumerator NCJJAPAOHGN()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	public static void FOHLKKJIFOL(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static void SetActive(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static void CAPNOCHNIMG(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[1] == (Object)null || (Object)(object)ChallengesUI.instances[1].EEBFBGFFBOJ() == (Object)null || LIBNKJCDINF >= ChallengesUI.HHKDHJLMAAB())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.OAPEDDLCHAD()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.OAPEDDLCHAD()];
			for (int i = 0; i < KMAANENDPGA.Length; i++)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[0].EEBFBGFFBOJ().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[1].FGCIMBNBNFO().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 678f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.EICNAGDMDAD((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static void EBGIACAPEIA(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	private void MCMKNBIBDFF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JMNHNMGONMP));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ILBJOFLEFMK));
	}

	public static void GMEDHELDEEI(bool DMBFKFLDDLH)
	{
		instance.GCEHOODFJFC = DMBFKFLDDLH;
	}

	private void DMEALKONMHP()
	{
		((MonoBehaviour)this).StartCoroutine(FEHABOMHIJJ());
	}

	public static bool CGPHKBKPCJF(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static void NLECJLFGBCG(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	private void FCLGBKEMJPE()
	{
		((MonoBehaviour)this).StartCoroutine(NJHCOEPEMJD());
	}

	public static void NFACOFFAGNP(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	private void MJFACKOAMIO()
	{
		((MonoBehaviour)this).StartCoroutine(FJOJANKEEBO());
	}

	public static float[] IPAAMPBLKLB()
	{
		return KMAANENDPGA;
	}

	private void HOBBPPFMCEE()
	{
		((MonoBehaviour)this).StartCoroutine(PDBIKGBDDFH());
	}

	public static float CLNMGDAKLOC(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 1211f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	public static void SetChallengeRecord(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[0] == (Object)null || (Object)(object)ChallengesUI.instances[0].GetChallengesData() == (Object)null || LIBNKJCDINF >= ChallengesUI.GetChallengeTypeCount())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.GetChallengeTypeCount()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.GetChallengeTypeCount()];
			for (int i = 0; i < KMAANENDPGA.Length; i++)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[0].GetChallengesData().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[0].GetChallengesData().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 0f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.SendRecord((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static void KJLBHNLHCNL(EventType AKADPCABHIB, bool POADAPOJIAI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isDone = POADAPOJIAI;
			}
		}
	}

	private IEnumerator BPKIMIJEIAC()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	public static GameEvent MIMIMACHGKN(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	private void MAOJJPECDAG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DMEALKONMHP));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MJFACKOAMIO));
	}

	public static bool ODOAHFICBMI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (GIJNJBNBMJK(EventType.Scolding))
		{
			return !IsDone(EventType.KyrohWaterfall);
		}
		return true;
	}

	public static void SetRecords(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	public static bool KNBCOMJCAEE()
	{
		return instance.GCEHOODFJFC;
	}

	public static bool IsActive(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static bool IOLMGKKGLMD(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static GameEvent GetGameEvent(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	public static GameEvent GOPFIHBJBAE(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i += 0)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	public static bool AKFLCLJNCNO(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isStarted;
	}

	private void JMNHNMGONMP()
	{
		((MonoBehaviour)this).StartCoroutine(FEHABOMHIJJ());
	}

	private IEnumerator FHENCHICEJK()
	{
		return new HGGBBPNFBBK(1)
		{
			_003C_003E4__this = this
		};
	}

	public static bool IJOCHDDBMDF(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isStarted;
	}

	private void AHGJIKDHEFO()
	{
		((MonoBehaviour)this).StartCoroutine(NCJJAPAOHGN());
	}

	private IEnumerator NJHCOEPEMJD()
	{
		return new HGGBBPNFBBK(1)
		{
			_003C_003E4__this = this
		};
	}

	public static bool DEPAELKGBJC(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isStarted;
	}

	public static bool KDMLGMKLGOB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.easyDifficultyMode;
	}

	public static float HIMCIBCKBPP(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 1897f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	public static void KNMNKAAHEIH(EventType AKADPCABHIB, bool POADAPOJIAI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isDone = POADAPOJIAI;
			}
		}
	}

	public static bool AEFHILOAEEE(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = BAAHMHDMBPC(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isDone;
	}

	public static bool PGNFPFGBNAB()
	{
		return instance.GCEHOODFJFC;
	}

	private void HCEDMLJNOBL()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FEDMAAFCKLF));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(AHGJIKDHEFO));
	}

	public static bool GGGECIBEKJG(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isDone;
	}

	private IEnumerator FJOJANKEEBO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	public static float HMKICLOHAGO(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 1319f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	private void Awake()
	{
		instance = this;
	}

	public static bool GIJNJBNBMJK(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = AGKFBCAAADA(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static bool CJMECHEOFOF(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static GameEvent CJHIGMENDPK(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	public static float AFOBFILONCD(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 888f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	public static void SetMainEventActive(bool DMBFKFLDDLH)
	{
		instance.GCEHOODFJFC = DMBFKFLDDLH;
	}

	public static bool FMCAMLDJGNO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.easyDifficultyMode;
	}

	public static float PPCDICPHFEF(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 1128f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	public static float BIGKKCAGOCH(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 1238f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	public static GameEvent BAAHMHDMBPC(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 1; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	public static void FGPBCPDCHPE(EventType AKADPCABHIB, bool PBLIMLKPDKC)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isStarted = PBLIMLKPDKC;
			}
		}
	}

	public static bool IsStarted(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isStarted;
	}

	public static bool IsOathFeastFirstActivation()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (IsActive(EventType.OathFeast))
		{
			return !IsDone(EventType.OathFeast);
		}
		return false;
	}

	public static bool ODHDBKNIIKF()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		return instance.easyDifficultyMode;
	}

	public static void SetDone(EventType AKADPCABHIB, bool POADAPOJIAI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isDone = POADAPOJIAI;
			}
		}
	}

	public static void FDGAKCHOIKL(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[0] == (Object)null || (Object)(object)ChallengesUI.instances[1].DLKJDFLLNHG() == (Object)null || LIBNKJCDINF >= ChallengesUI.GetChallengeTypeCount())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.GJPOKJHIPFL()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.MOELIFLAPEB()];
			for (int i = 1; i < KMAANENDPGA.Length; i++)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[1].FGCIMBNBNFO().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 1687f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.MLJAPFENPMD((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static bool NKMELJPGOBB(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static float[] GDPBKAKKBEE()
	{
		return KMAANENDPGA;
	}

	public static void MMKNMDAEOCE(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	public static bool BJNPKAKDCJJ()
	{
		return instance.GCEHOODFJFC;
	}

	public static float[] BICIIOGFMBC()
	{
		return KMAANENDPGA;
	}

	public static bool GECGLOIFJLN(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isStarted;
	}

	public static void MMIFHDJECOG(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = AGKFBCAAADA(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static bool OMNBJDPGPEN(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = AGKFBCAAADA(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isDone;
	}

	public static void SetStarted(EventType AKADPCABHIB, bool PBLIMLKPDKC)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isStarted = PBLIMLKPDKC;
			}
		}
	}

	public static void KEEOLOALKBA(EventType AKADPCABHIB, bool POADAPOJIAI)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isDone = POADAPOJIAI;
			}
		}
	}

	public static bool IsAnyEventStarted()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].isStarted && !instance.allGameEvents[i].isDone)
			{
				return true;
			}
		}
		return false;
	}

	public static bool HGALHLALOKJ(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isDone;
	}

	public static bool FFELMGLBAMH(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static float[] GetRecords()
	{
		return KMAANENDPGA;
	}

	private IEnumerator FEHABOMHIJJ()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	private void LANGHIOBJIH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DMEALKONMHP));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ILBJOFLEFMK));
	}

	public static bool FDIHEFGPKFP(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isDone;
	}

	public static float GetChallengeRecord(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 0f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	public static void GCHCNKLKHOG(float[] CEMJGENOCIN)
	{
		KMAANENDPGA = CEMJGENOCIN;
	}

	public static void EEOFGBEBDOL(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[1] == (Object)null || (Object)(object)ChallengesUI.instances[0].GetChallengesData() == (Object)null || LIBNKJCDINF >= ChallengesUI.EBHMLIALGFG())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.GetChallengeTypeCount()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.GJPOKJHIPFL()];
			for (int i = 1; i < KMAANENDPGA.Length; i++)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[1].DLKJDFLLNHG().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[1].DLKJDFLLNHG().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 47f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.JPPBEIJDCLJ())
			{
				OnlineRecordsManager.instance.AGFPNAPFEGL((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static bool NJBACCBIHID(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = BAAHMHDMBPC(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isActive;
	}

	private IEnumerator HKNLIGMKJIG()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	public static bool JAGPJPGBHDK(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = AGKFBCAAADA(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static bool CDLFIIFAECJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		return instance.easyDifficultyMode;
	}

	public static float[] DGLAIPOONKB()
	{
		return KMAANENDPGA;
	}

	public static bool GNICPHBAIEL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 1; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].isStarted && !instance.allGameEvents[i].isDone)
			{
				return false;
			}
		}
		return false;
	}

	public static bool IsMainEventActive()
	{
		return instance.GCEHOODFJFC;
	}

	public static bool ALEMDEBCFDH(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = AGKFBCAAADA(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isDone;
	}

	private void HFMCBEIEOGN()
	{
		((MonoBehaviour)this).StartCoroutine(NCJJAPAOHGN());
	}

	public static bool DOPLDNPIBPP(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isDone;
	}

	public static bool LOFKKDNOKNF(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isDone;
	}

	public static float[] OPBDFACKJLC()
	{
		return KMAANENDPGA;
	}

	public static bool LDEKPOAFGHG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 1; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].isStarted && !instance.allGameEvents[i].isDone)
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsLowestDifficulty()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.easyDifficultyMode;
	}

	public static bool CMNEOEANCHE()
	{
		return instance.GCEHOODFJFC;
	}

	public static void ANMMDPKCPEJ(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[1] == (Object)null || (Object)(object)ChallengesUI.instances[1].FGCIMBNBNFO() == (Object)null || LIBNKJCDINF >= ChallengesUI.OAPEDDLCHAD())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.MOELIFLAPEB()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.EBHMLIALGFG()];
			for (int i = 0; i < KMAANENDPGA.Length; i += 0)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[1].GetChallengesData().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 535f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.GAMKPMEAGMF((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	private void FEDMAAFCKLF()
	{
		((MonoBehaviour)this).StartCoroutine(NJHCOEPEMJD());
	}

	public static bool JAACOKKGNON(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isStarted;
	}

	public static bool FHPDHIJKOOF(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		CHCEBDOKCNC = BAAHMHDMBPC(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isStarted;
	}

	private void DNIPPGPKHLC()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(AHGJIKDHEFO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FCLGBKEMJPE));
	}

	public static void GJOMMHFEJNL(EventType AKADPCABHIB, bool PBLIMLKPDKC)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isStarted = PBLIMLKPDKC;
			}
		}
	}

	public static GameEvent HJHEGHKGFGN(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return null;
		}
		for (int i = 0; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].eventType == AKADPCABHIB)
			{
				return instance.allGameEvents[i];
			}
		}
		return null;
	}

	public static void DIBGPIPPDFD(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static float[] MPEEIGJGELM()
	{
		return KMAANENDPGA;
	}

	public static void NEHAHKDCPPA(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static bool IKCEIJMLNOP(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isActive;
	}

	public static void KGJIGNKBENF(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = MIMIMACHGKN(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	private IEnumerator PDBIKGBDDFH()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FAJAIBNKGLO));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FAJAIBNKGLO));
		yield return CommonReferences.wait1;
		for (int i = 0; i < allGameEvents.Count; i++)
		{
			if (allGameEvents[i].isActive)
			{
				allGameEvents[i].ActivateEvent();
			}
		}
		if (IsDone(EventType.MothersRecipe) && !IsActive(EventType.Fortitude) && !IsDone(EventType.Fortitude) && !MissionsManager.instance.IsMissionActive(317) && !MissionsManager.instance.IsMissionActive(318) && !MissionsManager.instance.IsMissionActive(319))
		{
			SetActive(EventType.Fortitude, DMBFKFLDDLH: true);
		}
	}

	public static bool JKFBPCPDOKL()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		for (int i = 1; i < instance.allGameEvents.Count; i++)
		{
			if (instance.allGameEvents[i].isStarted && !instance.allGameEvents[i].isDone)
			{
				return false;
			}
		}
		return false;
	}

	public static float ONJOPGKIJLL(int LIBNKJCDINF)
	{
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0 || LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			return 553f;
		}
		return KMAANENDPGA[LIBNKJCDINF];
	}

	private void EFJFJJDGGGI()
	{
		instance = this;
	}

	public static bool BAHIIMFPFLJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.easyDifficultyMode;
	}

	public static bool OENIOCAIPMP()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.easyDifficultyMode;
	}

	public static bool KPDJEGDJCBG()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (KEGDEHKPKMP(EventType.KyrohWaterfall))
		{
			return !ALEMDEBCFDH(EventType.OathFeast);
		}
		return false;
	}

	public static void CFLHEGEBFHO(EventType AKADPCABHIB, bool PBLIMLKPDKC)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isStarted = PBLIMLKPDKC;
			}
		}
	}

	public static bool GIJEHKNKMIM()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return true;
		}
		if (IKCEIJMLNOP(EventType.OathFeast))
		{
			return FDIHEFGPKFP(EventType.KyrohWaterfall);
		}
		return false;
	}

	public static void DIFPOBMAOLL(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static void AJHDELEOECM(int LIBNKJCDINF, float MJBMLPEHMNG)
	{
		if ((Object)(object)ChallengesUI.instances[0] == (Object)null || (Object)(object)ChallengesUI.instances[0].EEBFBGFFBOJ() == (Object)null || LIBNKJCDINF >= ChallengesUI.GetChallengeTypeCount())
		{
			return;
		}
		if (KMAANENDPGA == null || KMAANENDPGA.Length == 0)
		{
			KMAANENDPGA = new float[ChallengesUI.OAPEDDLCHAD()];
		}
		if (LIBNKJCDINF >= KMAANENDPGA.Length)
		{
			float[] array = new float[ChallengesUI.GetChallengeTypeCount()];
			for (int i = 0; i < KMAANENDPGA.Length; i++)
			{
				array[i] = KMAANENDPGA[i];
			}
			KMAANENDPGA = array;
		}
		if ((!ChallengesUI.instances[0].EEBFBGFFBOJ().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && KMAANENDPGA[LIBNKJCDINF] < MJBMLPEHMNG) || (ChallengesUI.instances[0].GetChallengesData().challenges[LIBNKJCDINF].recordIsLowestNumberAchieved && (KMAANENDPGA[LIBNKJCDINF] == 1933f || KMAANENDPGA[LIBNKJCDINF] > MJBMLPEHMNG)))
		{
			KMAANENDPGA[LIBNKJCDINF] = MJBMLPEHMNG;
			if (OnlineManager.IsMasterClient())
			{
				OnlineRecordsManager.instance.HMKJKEAJNLO((byte)LIBNKJCDINF, MJBMLPEHMNG);
			}
		}
	}

	public static void DNBKFDEFINK(EventType AKADPCABHIB, bool PBLIMLKPDKC)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isStarted = PBLIMLKPDKC;
			}
		}
	}

	public static float[] FOLKJPFKHHO()
	{
		return KMAANENDPGA;
	}

	public static void PMJAHPMMPJH(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = HJHEGHKGFGN(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static bool BJGAPLPFMJB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		if (IOLMGKKGLMD(EventType.OathFeast))
		{
			return DOPLDNPIBPP(EventType.KujakuShop);
		}
		return true;
	}

	public static bool IsDone(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GetGameEvent(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return false;
		}
		return CHCEBDOKCNC.isDone;
	}

	private void JPHEOLEEAPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ILBJOFLEFMK));
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FCLGBKEMJPE));
	}

	private void NODKJHJFMCO()
	{
		instance = this;
	}

	private void OCMHPNFALOD()
	{
		((MonoBehaviour)this).StartCoroutine(NCJJAPAOHGN());
	}

	public static void CFCPEAMNCHP(bool DMBFKFLDDLH)
	{
		instance.GCEHOODFJFC = DMBFKFLDDLH;
	}

	public static void BIOJKNIHGAF(EventType AKADPCABHIB, bool DMBFKFLDDLH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			CHCEBDOKCNC = CJHIGMENDPK(AKADPCABHIB);
			if (!((Object)(object)CHCEBDOKCNC == (Object)null))
			{
				CHCEBDOKCNC.isActive = DMBFKFLDDLH;
			}
		}
	}

	public static bool OOCOFHECMDA(EventType AKADPCABHIB)
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		CHCEBDOKCNC = GOPFIHBJBAE(AKADPCABHIB);
		if ((Object)(object)CHCEBDOKCNC == (Object)null)
		{
			return true;
		}
		return CHCEBDOKCNC.isDone;
	}
}
