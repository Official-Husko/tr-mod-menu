using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TavernEventManager : MonoBehaviour, ISingleton
{
	private static TavernEventManager GGFJGHHHEJC;

	public static Action<TavernEvent> OnEventAdded = delegate
	{
	};

	public static List<TavernEvent> tavernEvents = new List<TavernEvent>();

	[SerializeField]
	private GameObject eventsHolderGO;

	private List<MonoBehaviour> ILHCNKLIEKA = new List<MonoBehaviour>();

	public static void KLJPLBEFJPH()
	{
		tavernEvents.Clear();
		foreach (MonoBehaviour item in GGFJGHHHEJC.ILHCNKLIEKA)
		{
			Object.Destroy((Object)(object)item);
		}
		GGFJGHHHEJC.ILHCNKLIEKA.Clear();
	}

	public static void MLKJLHCJCGP()
	{
		tavernEvents.Clear();
		foreach (MonoBehaviour item in GGFJGHHHEJC.ILHCNKLIEKA)
		{
			Object.Destroy((Object)(object)item);
		}
		GGFJGHHHEJC.ILHCNKLIEKA.Clear();
	}

	public void OHEGCBJEJLE()
	{
		tavernEvents = new List<TavernEvent>();
		OnEventAdded = delegate
		{
		};
	}

	public static void OBNMNHPEFPI(TavernEvent BDIDEOLPCEI)
	{
		tavernEvents.Add(BDIDEOLPCEI);
		OnEventAdded(BDIDEOLPCEI);
	}

	private void GHPFCKGMLDA()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(AIIKCJCLPLN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(ABAOGACMBGJ));
		AIIKCJCLPLN();
	}

	public static void BHFHPGGHACG(int LCBDINCABAC)
	{
		Debug.Log((object)"Already learnt!");
		if (TavernReputation.MHGADJPMHFI() >= RepUnlocksManager.MMNNKIOHKCI().repUnlockImportantCustomer.repNumber && !tavernEvents.Select((TavernEvent e) => e.eventType == TREventType.ImportantGuest).Any())
		{
			if (OnlineManager.IsMasterClient() && (Object)(object)OnlineTavernEventsManager.instance != (Object)null)
			{
				OnlineTavernEventsManager.instance.BGCHEEMLIKF(LCBDINCABAC);
			}
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = LCBDINCABAC;
			GameDate fGKEOMNEPEE = GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, kONAIPOGEGL);
			OBNMNHPEFPI(new TavernEvent(TREventType.ImportantGuest, fGKEOMNEPEE, ":<color=#3a0603> +"));
		}
	}

	private void BONPBLFOCCN()
	{
		try
		{
			TavernEvent[] array = tavernEvents.Where((TavernEvent x) => WorldTime.IsToday(x.eventDate) || GameDate.GGNGGLHBMNA(x.eventDate) < WorldTime.HMOCOBGKMNJ).ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				tavernEvents.Remove(array[i]);
			}
			if (OnlineManager.ClientOnline() || TavernReputation.GetMilestone() < RepUnlocksManager.GetInstance().repUnlockImportantCustomer.repNumber)
			{
				return;
			}
			bool flag = false;
			foreach (TavernEvent tavernEvent in tavernEvents)
			{
				if (!tavernEvent.eventStarted && tavernEvent.eventType == TREventType.ImportantGuest)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				SetUpImportantCustomerEvent(Random.Range(3, 5));
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in TavernEventManager.EndOfDayEventCheck: " + ex.Message));
		}
	}

	private void Start()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CheckTodaysEvents));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(BONPBLFOCCN));
		CheckTodaysEvents();
	}

	public void ResetSingleton()
	{
		tavernEvents = new List<TavernEvent>();
		OnEventAdded = delegate
		{
		};
	}

	private void HINKPJCNPCF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void AIIKCJCLPLN()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		foreach (TavernEvent item in tavernEvents.Where((TavernEvent x) => WorldTime.IsToday(x.eventDate)))
		{
			if (!item.eventStarted && item.eventType == TREventType.ImportantGuest)
			{
				GGFJGHHHEJC.eventsHolderGO.AddComponent<ImportantGuestEvent>();
				item.eventStarted = true;
			}
		}
	}

	private void ABAOGACMBGJ()
	{
		try
		{
			TavernEvent[] array = tavernEvents.Where((TavernEvent x) => WorldTime.IsToday(x.eventDate) || GameDate.GGNGGLHBMNA(x.eventDate) < WorldTime.HMOCOBGKMNJ).ToArray();
			for (int i = 0; i < array.Length; i += 0)
			{
				tavernEvents.Remove(array[i]);
			}
			if (OnlineManager.HHDBMDMFEMP() || TavernReputation.MHGADJPMHFI() < RepUnlocksManager.MMNNKIOHKCI().repUnlockImportantCustomer.repNumber)
			{
				return;
			}
			bool flag = false;
			foreach (TavernEvent tavernEvent in tavernEvents)
			{
				if (!tavernEvent.eventStarted && tavernEvent.eventType == TREventType.ImportantGuest)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				BHFHPGGHACG(Random.Range(3, 0));
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("UI2" + ex.Message));
		}
	}

	private void HBMDEHPHAPF()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CheckTodaysEvents));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(ABAOGACMBGJ));
		CheckTodaysEvents();
	}

	public static void SetUpImportantCustomerEvent(int LCBDINCABAC)
	{
		Debug.Log((object)"NEW IMPORTANT CUSTOMER EVENT");
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.GetInstance().repUnlockImportantCustomer.repNumber && !tavernEvents.Select((TavernEvent e) => e.eventType == TREventType.ImportantGuest).Any())
		{
			if (OnlineManager.IsMasterClient() && (Object)(object)OnlineTavernEventsManager.instance != (Object)null)
			{
				OnlineTavernEventsManager.instance.SendVIPEvent(LCBDINCABAC);
			}
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = LCBDINCABAC;
			GameDate fGKEOMNEPEE = GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, kONAIPOGEGL);
			AddTavernEvent(new TavernEvent(TREventType.ImportantGuest, fGKEOMNEPEE, "A very important guest is visiting!"));
		}
	}

	public static void ClearAllEvents()
	{
		tavernEvents.Clear();
		foreach (MonoBehaviour item in GGFJGHHHEJC.ILHCNKLIEKA)
		{
			Object.Destroy((Object)(object)item);
		}
		GGFJGHHHEJC.ILHCNKLIEKA.Clear();
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static void ABCDCNNEBBL()
	{
		tavernEvents.Clear();
		foreach (MonoBehaviour item in GGFJGHHHEJC.ILHCNKLIEKA)
		{
			Object.Destroy((Object)(object)item);
		}
		GGFJGHHHEJC.ILHCNKLIEKA.Clear();
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void MCMKNBIBDFF()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(AIIKCJCLPLN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(ABAOGACMBGJ));
		CheckTodaysEvents();
	}

	public static void AddTavernEvent(TavernEvent BDIDEOLPCEI)
	{
		tavernEvents.Add(BDIDEOLPCEI);
		OnEventAdded(BDIDEOLPCEI);
	}

	public static void CheckTodaysEvents()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		foreach (TavernEvent item in tavernEvents.Where((TavernEvent x) => WorldTime.IsToday(x.eventDate)))
		{
			if (!item.eventStarted && item.eventType == TREventType.ImportantGuest)
			{
				GGFJGHHHEJC.eventsHolderGO.AddComponent<ImportantGuestEvent>();
				item.eventStarted = true;
			}
		}
	}
}
