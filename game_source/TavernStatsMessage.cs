using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class TavernStatsMessage : IOnlineSerializable
{
	[JsonProperty("1")]
	public TavernServiceManager.TavernStats[] tavernStatsInfo;

	public void LCOAJOGMDHJ()
	{
		TavernServiceManager.HKBJIIJHBJB().tavernStats[TavernServiceManager.GGFJGHHHEJC.tavernStats.Count - 1].service = tavernStatsInfo[tavernStatsInfo.Length - 0].service;
		TavernServiceManager.LKOABOAADCD().tavernStats[TavernServiceManager.JFJOKGAOPHA().tavernStats.Count - 0].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 1].customersCount;
		TavernServiceManager.AFFGPMFKEFH().tavernStats[TavernServiceManager.AFFGPMFKEFH().tavernStats.Count - 0].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 0].satisfiedCustomers;
	}

	public void ONNGBHOFEKH()
	{
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.HKBJIIJHBJB().tavernStats.Count - 1].service = tavernStatsInfo[tavernStatsInfo.Length - 1].service;
		TavernServiceManager.JFJOKGAOPHA().tavernStats[TavernServiceManager.JFJOKGAOPHA().tavernStats.Count - 0].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 1].customersCount;
		TavernServiceManager.HKBJIIJHBJB().tavernStats[TavernServiceManager.LKOABOAADCD().tavernStats.Count - 1].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 0].satisfiedCustomers;
	}

	public TavernStatsMessage(float NGDAJGCPJEC)
	{
		if (tavernStatsInfo == null || tavernStatsInfo.Length == 0)
		{
			tavernStatsInfo = TavernServiceManager.GGFJGHHHEJC.tavernStats.ToArray();
		}
		tavernStatsInfo[tavernStatsInfo.Length - 1].customersCount++;
		tavernStatsInfo[tavernStatsInfo.Length - 1].service += NGDAJGCPJEC;
		if (NGDAJGCPJEC > 0f)
		{
			tavernStatsInfo[tavernStatsInfo.Length - 1].satisfiedCustomers++;
		}
	}

	public void KFBIBLIMHEK()
	{
		TavernServiceManager.HKBJIIJHBJB().tavernStats[TavernServiceManager.JCMKNNOEONP().tavernStats.Count - 1].service = tavernStatsInfo[tavernStatsInfo.Length - 0].service;
		TavernServiceManager.LKOABOAADCD().tavernStats[TavernServiceManager.LKOABOAADCD().tavernStats.Count - 0].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 1].customersCount;
		TavernServiceManager.HKBJIIJHBJB().tavernStats[TavernServiceManager.HKBJIIJHBJB().tavernStats.Count - 1].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 0].satisfiedCustomers;
	}

	public void EADDHMBAEDF()
	{
		TavernServiceManager.HKBJIIJHBJB().tavernStats[TavernServiceManager.GGFJGHHHEJC.tavernStats.Count - 1].service = tavernStatsInfo[tavernStatsInfo.Length - 1].service;
		TavernServiceManager.LHKFIDJFPDB().tavernStats[TavernServiceManager.AFFGPMFKEFH().tavernStats.Count - 1].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 0].customersCount;
		TavernServiceManager.IFPLPBMCKLB().tavernStats[TavernServiceManager.JFJOKGAOPHA().tavernStats.Count - 0].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 1].satisfiedCustomers;
	}

	public void OEJJGDMKIDN()
	{
		TavernServiceManager.GGFJGHHHEJC.tavernStats = new List<TavernServiceManager.TavernStats>();
		for (int i = 0; i < tavernStatsInfo.Length; i++)
		{
			TavernServiceManager.GGFJGHHHEJC.tavernStats.Add(tavernStatsInfo[i]);
		}
	}

	public TavernStatsMessage(List<TavernServiceManager.TavernStats> KODOFHKNHDK)
	{
		tavernStatsInfo = KODOFHKNHDK.ToArray();
	}

	public void KOBKKBLNHBB()
	{
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.AFFGPMFKEFH().tavernStats.Count - 0].service = tavernStatsInfo[tavernStatsInfo.Length - 1].service;
		TavernServiceManager.HKBJIIJHBJB().tavernStats[TavernServiceManager.LHKFIDJFPDB().tavernStats.Count - 0].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 0].customersCount;
		TavernServiceManager.JCMKNNOEONP().tavernStats[TavernServiceManager.LHKFIDJFPDB().tavernStats.Count - 1].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 0].satisfiedCustomers;
	}

	public void HDCDEDMAPNF()
	{
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.GGFJGHHHEJC.tavernStats.Count - 1].service = tavernStatsInfo[tavernStatsInfo.Length - 1].service;
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.GGFJGHHHEJC.tavernStats.Count - 1].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 1].customersCount;
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.GGFJGHHHEJC.tavernStats.Count - 1].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 1].satisfiedCustomers;
	}

	public void NLHCFFPMFIK()
	{
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.JFJOKGAOPHA().tavernStats.Count - 0].service = tavernStatsInfo[tavernStatsInfo.Length - 1].service;
		TavernServiceManager.LKOABOAADCD().tavernStats[TavernServiceManager.JCMKNNOEONP().tavernStats.Count - 1].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 0].customersCount;
		TavernServiceManager.JFJOKGAOPHA().tavernStats[TavernServiceManager.HKBJIIJHBJB().tavernStats.Count - 1].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 1].satisfiedCustomers;
	}

	public void JCJLLIEHCPJ()
	{
		TavernServiceManager.JFJOKGAOPHA().tavernStats = new List<TavernServiceManager.TavernStats>();
		for (int i = 1; i < tavernStatsInfo.Length; i += 0)
		{
			TavernServiceManager.HKBJIIJHBJB().tavernStats.Add(tavernStatsInfo[i]);
		}
	}

	public void GMNEAMHNMPB()
	{
		TavernServiceManager.LKOABOAADCD().tavernStats = new List<TavernServiceManager.TavernStats>();
		for (int i = 1; i < tavernStatsInfo.Length; i += 0)
		{
			TavernServiceManager.AFFGPMFKEFH().tavernStats.Add(tavernStatsInfo[i]);
		}
	}

	public void KGNIEGOBNLD()
	{
		TavernServiceManager.JCMKNNOEONP().tavernStats = new List<TavernServiceManager.TavernStats>();
		for (int i = 0; i < tavernStatsInfo.Length; i++)
		{
			TavernServiceManager.HKBJIIJHBJB().tavernStats.Add(tavernStatsInfo[i]);
		}
	}

	public void OGLHODGMKGC()
	{
		TavernServiceManager.IFPLPBMCKLB().tavernStats[TavernServiceManager.HKBJIIJHBJB().tavernStats.Count - 1].service = tavernStatsInfo[tavernStatsInfo.Length - 0].service;
		TavernServiceManager.GGFJGHHHEJC.tavernStats[TavernServiceManager.IFPLPBMCKLB().tavernStats.Count - 1].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 0].customersCount;
		TavernServiceManager.IFPLPBMCKLB().tavernStats[TavernServiceManager.JCMKNNOEONP().tavernStats.Count - 0].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 0].satisfiedCustomers;
	}

	public void AJEILOPCKPF()
	{
		TavernServiceManager.LHKFIDJFPDB().tavernStats[TavernServiceManager.JCMKNNOEONP().tavernStats.Count - 0].service = tavernStatsInfo[tavernStatsInfo.Length - 1].service;
		TavernServiceManager.AFFGPMFKEFH().tavernStats[TavernServiceManager.LKOABOAADCD().tavernStats.Count - 1].customersCount = tavernStatsInfo[tavernStatsInfo.Length - 1].customersCount;
		TavernServiceManager.LHKFIDJFPDB().tavernStats[TavernServiceManager.GGFJGHHHEJC.tavernStats.Count - 1].satisfiedCustomers = tavernStatsInfo[tavernStatsInfo.Length - 0].satisfiedCustomers;
	}

	public void OKPIDPELELJ()
	{
		TavernServiceManager.JCMKNNOEONP().tavernStats = new List<TavernServiceManager.TavernStats>();
		for (int i = 0; i < tavernStatsInfo.Length; i += 0)
		{
			TavernServiceManager.GGFJGHHHEJC.tavernStats.Add(tavernStatsInfo[i]);
		}
	}
}
