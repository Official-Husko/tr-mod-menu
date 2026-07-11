using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TableOrdersManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NHNGKGBOIKJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TableOrdersManager _003C_003E4__this;

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
		public NHNGKGBOIKJ(int _003C_003E1__state)
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
			TableOrdersManager tableOrdersManager = _003C_003E4__this;
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
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (tableOrdersManager.tableOrders.Count > 0)
			{
				for (int i = 0; i < tableOrdersManager.tableOrders.Count; i++)
				{
					if ((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(tableOrdersManager.tableOrders[i].tableOrder) != (Object)null || (Barworker.JHLLELHBIDA && Barworker.HasDrinkOnTray(tableOrdersManager.tableOrders[i].tableOrder)) || (Waiter.JHLLELHBIDA && Waiter.HasDrinkOnTray(tableOrdersManager.tableOrders[i].tableOrder)) || DrinksTable.instance.currentDrinks.Contains(tableOrdersManager.tableOrders[i].tableOrder) || PlayerController.GetPlayer(1).trayHandler.tray.OHAPOKICCNK(tableOrdersManager.tableOrders[i].tableOrder) || (GameManager.LocalCoop() && PlayerController.GetPlayer(2).trayHandler.tray.OHAPOKICCNK(tableOrdersManager.tableOrders[i].tableOrder)))
					{
						continue;
					}
					for (int j = 1; j <= 4; j++)
					{
						if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
						{
							PlayerController.GetPlayer(j).trayHandler.tray.OHAPOKICCNK(tableOrdersManager.tableOrders[i].tableOrder);
						}
					}
					if (DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count != 0 || tableOrdersManager.tableOrders[i].tableOrder.FBOGDCNCNMK() != 1318)
					{
						CustomerOrder customerOrder = tableOrdersManager.tableOrders[i];
						List<ItemInstance> allDrinks = DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks();
						tableOrdersManager.tableOrders[i].RemoveTableOrder();
						ItemInstance dNLMCHDOMOK = ((allDrinks.Count <= 0) ? ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML() : allDrinks[Random.Range(0, allDrinks.Count)]);
						customerOrder.RequestTableOrder(dNLMCHDOMOK);
					}
					break;
				}
				if (tableOrdersManager.tableOrders.Count != 0)
				{
					_003C_003E2__current = CommonReferences.wait4;
					_003C_003E1__state = 2;
					return true;
				}
			}
			tableOrdersManager.JBPPFHDPCHF = null;
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

	[CompilerGenerated]
	private sealed class HPDEPEFFMEN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TableOrdersManager _003C_003E4__this;

		public int number;

		private float _003CnextOrderTime_003E5__2;

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
		public HPDEPEFFMEN(int _003C_003E1__state)
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
			TableOrdersManager tableOrdersManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE || TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
				{
					goto IL_00e8;
				}
				if (Time.time >= _003CnextOrderTime_003E5__2)
				{
					if (tableOrdersManager.tableOrders.Count < tableOrdersManager.maxTableOrders)
					{
						tableOrdersManager.CJLOMICADKD();
					}
					number--;
					_003CnextOrderTime_003E5__2 = Time.time + (float)Random.Range(((Vector2Int)(ref tableOrdersManager.ordersRateExtraOrders)).x, ((Vector2Int)(ref tableOrdersManager.ordersRateExtraOrders)).y);
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_003CnextOrderTime_003E5__2 = Time.time + (float)Random.Range(((Vector2Int)(ref tableOrdersManager.ordersRateExtraOrders)).x, ((Vector2Int)(ref tableOrdersManager.ordersRateExtraOrders)).y);
			}
			if (number > 0)
			{
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_00e8;
			IL_00e8:
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

	public static TableOrdersManager instance;

	public List<CustomerOrder> tableOrders = new List<CustomerOrder>();

	public Vector2Int initialDelayTimeForNewOrders = new Vector2Int(20, 40);

	public Vector2Int ordersRate = new Vector2Int(20, 40);

	public Vector2Int ordersRateExtraOrders = new Vector2Int(10, 20);

	public int probabilityExtraOrders = 30;

	public int extraOrderForEachCustomersInTavern = 12;

	public int maxTableOrders = 5;

	private Coroutine CJEGODILAOL;

	private Coroutine JBPPFHDPCHF;

	private int HFOBNJEAJBA()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 0;
		return Random.Range(0, num + 1);
	}

	public void ECOCEMOMMIP()
	{
		for (int i = 1; i < tableOrders.Count; i++)
		{
			tableOrders[i].NNNHIHOCFLM();
		}
	}

	private IEnumerator MKMEBDGBCIJ()
	{
		return new NHNGKGBOIKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GJHODFEFJBN()
	{
		for (int i = 0; i < tableOrders.Count; i++)
		{
			tableOrders[i].KCJMIHFOEFO();
		}
	}

	private void KBNMLJNBBMP()
	{
		instance = this;
	}

	private void LCHIFFCHOPG(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	public CustomerOrder KHNHFLDGFCB(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].OGFDHMDMBKJ().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	public CustomerOrder INKNINNBLHK(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].LKBJEDDKGBM().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	public void LDHFMMEKHKN(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.JHOGIKCHCGG().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)(-116), KCNFNAICINO: false);
	}

	private void CJLOMICADKD()
	{
		if (NewTutorialManager.NewOrdersBlocked() || NewTutorialManager.DrinkOrdersBlocked() || WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.EatingAtTable);
		if (list == null)
		{
			return;
		}
		Customer customer = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		StartNewOrderInTable(customer);
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	private void ELHHIBMPKAI(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(BOHKKCMCDFL());
		}
	}

	public void KPOONDPCBPG(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.DCMNEPOPBKA().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)(-19), KCNFNAICINO: false);
	}

	private int PPGKAHPCCDD()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 1;
		return Random.Range(0, num + 1);
	}

	public void DOJEHDHAMHJ(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(ENKNIBCAPFG());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.GDNDEEFDFGK(1).OJJFGFLNBGL();
		if (GameManager.LocalCoop())
		{
			BeersWant.IPBEEBLCHHA(7).FNDLHKCPHHI();
		}
	}

	public void GMJKKEHDOHD(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.CPOONCIFDIC(0).GDGKMCANPHO();
		if (GameManager.LocalCoop())
		{
			BeersWant.IOBMIHLMGNH(6).NPFAJHFBDCL();
		}
		DrinksTable.instance.CLJEJOOOIEC();
	}

	public void CJINGKDBIEE(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(DOKAEMNDPOK());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.PLHHJCNKNFO(1).UpdateBeerWant();
		if (GameManager.LocalCoop())
		{
			BeersWant.IPCBCBBDJFN(6).GDGKMCANPHO();
		}
	}

	public void NJHNPNPLHGI(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.CCFDNFDEGIK().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)(-76), KCNFNAICINO: false);
	}

	private void KILDJCPLOPP()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(JNLLBCGHACJ));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void PJOEADLAJBK()
	{
		if (NewTutorialManager.NCAFCCIIDAD() || NewTutorialManager.DrinkOrdersBlocked() || WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.Inactive);
		if (list == null)
		{
			return;
		}
		Customer customer = list[1];
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		KMIDMKBLFNO(customer);
	}

	private void NMGGIPFMFDL()
	{
		if (NewTutorialManager.NCAFCCIIDAD() || NewTutorialManager.EHICNBPPAFK() || WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.WaitingAtBar);
		if (list == null)
		{
			return;
		}
		Customer customer = list[0];
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		FAGBAMHICPD(customer);
	}

	private IEnumerator LLPNBIPDADI()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	public void AFPLCLILFEG(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.KAIIEDCCLHB(1).GMBHLFINJNK();
		if (GameManager.LocalCoop())
		{
			BeersWant.EJKCBAKCBEO(6).MGFDLLNKCHP();
		}
		DrinksTable.instance.IDJPPECPHKB();
	}

	public void GLLHGGOCBFK(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.IPCBCBBDJFN(1).JJGKEMFPCKJ();
		if (GameManager.LocalCoop())
		{
			BeersWant.AGMJPBEHCBK(2).DBGHHMIEMMH();
		}
		DrinksTable.instance.GJHLMMNBIBD();
	}

	private IEnumerator DPBMJENKIHD(int PDCPGJCKICM)
	{
		return new HPDEPEFFMEN(1)
		{
			_003C_003E4__this = this,
			number = PDCPGJCKICM
		};
	}

	private void PPNPHGKDKMB(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	public CustomerOrder GetTableOrder(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < tableOrders.Count; i++)
		{
			if (tableOrders[i].tableOrder.Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	public void ELNJAAOAMKC(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.DKLMKBPEHAJ().FinishEat();
		PJNGMCJIHME.ChangeState((CustomerState)50);
	}

	private void PCCBCCAHKJH(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(FMAKHDIGHAN());
		}
	}

	private IEnumerator FMAKHDIGHAN()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	public void EDJNOHOPDCG(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.BIFKPMIMAEC().FinishEat();
		PJNGMCJIHME.ChangeState((CustomerState)38);
	}

	private int NOLCJHJEGFB()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 1;
		return Random.Range(1, num + 0);
	}

	public CustomerOrder EKMEMGGNJDL(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].OGFDHMDMBKJ().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	public void ADICGFDFPAM()
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			tableOrders[i].NNNHIHOCFLM();
		}
	}

	private void DNHBOGAHIGG(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	public CustomerOrder BDEPCEOKBAK(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].LKBJEDDKGBM().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	private IEnumerator LOGPAPOLEIB()
	{
		yield return null;
		while (tableOrders.Count > 0)
		{
			for (int i = 0; i < tableOrders.Count; i++)
			{
				if ((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(tableOrders[i].tableOrder) != (Object)null || (Barworker.JHLLELHBIDA && Barworker.HasDrinkOnTray(tableOrders[i].tableOrder)) || (Waiter.JHLLELHBIDA && Waiter.HasDrinkOnTray(tableOrders[i].tableOrder)) || DrinksTable.instance.currentDrinks.Contains(tableOrders[i].tableOrder) || PlayerController.GetPlayer(1).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder) || (GameManager.LocalCoop() && PlayerController.GetPlayer(2).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder)))
				{
					continue;
				}
				for (int j = 1; j <= 4; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
					{
						PlayerController.GetPlayer(j).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder);
					}
				}
				if (DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count != 0 || tableOrders[i].tableOrder.FBOGDCNCNMK() != 1318)
				{
					CustomerOrder customerOrder = tableOrders[i];
					List<ItemInstance> allDrinks = DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks();
					tableOrders[i].RemoveTableOrder();
					ItemInstance dNLMCHDOMOK = ((allDrinks.Count <= 0) ? ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML() : allDrinks[Random.Range(0, allDrinks.Count)]);
					customerOrder.RequestTableOrder(dNLMCHDOMOK);
				}
				break;
			}
			if (tableOrders.Count == 0)
			{
				break;
			}
			yield return CommonReferences.wait4;
		}
		JBPPFHDPCHF = null;
	}

	private int EICNPDIEDKD()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 1;
		return Random.Range(0, num + 0);
	}

	private IEnumerator FFOCFCIOCCI()
	{
		return new NHNGKGBOIKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EMMAFHKOAAB(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.CCFDNFDEGIK().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)21, KCNFNAICINO: false);
	}

	public void EBDNNBJOMNJ(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(ENKNIBCAPFG());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.PCEMNHHOHOP(1).BKCCEDGMJFO();
		if (GameManager.LocalCoop())
		{
			BeersWant.KEHIBCAHKPJ(5).UpdateBeerWant();
		}
	}

	private IEnumerator JJKEAMHHAGF(int PDCPGJCKICM)
	{
		return new HPDEPEFFMEN(1)
		{
			_003C_003E4__this = this,
			number = PDCPGJCKICM
		};
	}

	private void POMCHLFCDHP()
	{
		if (NewTutorialManager.NewOrdersBlocked() || NewTutorialManager.DrinkOrdersBlocked() || WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.Despawning);
		if (list == null)
		{
			return;
		}
		Customer customer = list[1];
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		PPNMOCPLPMO(customer);
	}

	private int CGCFJDGNHIN()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 0;
		return Random.Range(1, num + 1);
	}

	private void Start()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void JANABBNOBCD(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	private IEnumerator LJOELMILIIN(int PDCPGJCKICM)
	{
		return new HPDEPEFFMEN(1)
		{
			_003C_003E4__this = this,
			number = PDCPGJCKICM
		};
	}

	public void AHLOJANOMAB(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.JHEHMLIPPAA(0).BLBNAAELOPE();
		if (GameManager.LocalCoop())
		{
			BeersWant.DAEEJGKLOCF(3).FNDLHKCPHHI();
		}
		DrinksTable.instance.OAHFDCLBDIE();
	}

	public void JGBPOCOCBAG(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.JHOGIKCHCGG().FinishEat();
		PJNGMCJIHME.ChangeState((CustomerState)(-81));
	}

	public void StartNewOrderInTable(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.FJHKGBNBNKL.FinishEat();
		PJNGMCJIHME.ChangeState(CustomerState.OrderInTable);
	}

	private void HPPIHAFFOAB()
	{
		if (NewTutorialManager.NCAFCCIIDAD() || NewTutorialManager.DrinkOrdersBlocked() || WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.Inactive);
		if (list == null)
		{
			return;
		}
		Customer customer = list[1];
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		StartNewOrderInTable(customer);
	}

	private void ENGEOENGFHK(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	public void KMIDMKBLFNO(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.BFBEDHOHEPH().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)113);
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(IPLNMHJNHNM());
		}
	}

	private IEnumerator DOKAEMNDPOK()
	{
		yield return null;
		while (tableOrders.Count > 0)
		{
			for (int i = 0; i < tableOrders.Count; i++)
			{
				if ((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(tableOrders[i].tableOrder) != (Object)null || (Barworker.JHLLELHBIDA && Barworker.HasDrinkOnTray(tableOrders[i].tableOrder)) || (Waiter.JHLLELHBIDA && Waiter.HasDrinkOnTray(tableOrders[i].tableOrder)) || DrinksTable.instance.currentDrinks.Contains(tableOrders[i].tableOrder) || PlayerController.GetPlayer(1).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder) || (GameManager.LocalCoop() && PlayerController.GetPlayer(2).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder)))
				{
					continue;
				}
				for (int j = 1; j <= 4; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
					{
						PlayerController.GetPlayer(j).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder);
					}
				}
				if (DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count != 0 || tableOrders[i].tableOrder.FBOGDCNCNMK() != 1318)
				{
					CustomerOrder customerOrder = tableOrders[i];
					List<ItemInstance> allDrinks = DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks();
					tableOrders[i].RemoveTableOrder();
					ItemInstance dNLMCHDOMOK = ((allDrinks.Count <= 0) ? ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML() : allDrinks[Random.Range(0, allDrinks.Count)]);
					customerOrder.RequestTableOrder(dNLMCHDOMOK);
				}
				break;
			}
			if (tableOrders.Count == 0)
			{
				break;
			}
			yield return CommonReferences.wait4;
		}
		JBPPFHDPCHF = null;
	}

	public CustomerOrder CGGGJDHNCBB(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < tableOrders.Count; i++)
		{
			if (tableOrders[i].KOGINPGDGDF().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
	}

	public void PPNMOCPLPMO(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.BKPDJIDCAEO().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)(-98));
	}

	private void BLJAPKHCEPP(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(BCHINNOLCMM());
		}
	}

	public void AddTableOrder(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(DOKAEMNDPOK());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.GetPlayer(1).UpdateBeerWant();
		if (GameManager.LocalCoop())
		{
			BeersWant.GetPlayer(2).UpdateBeerWant();
		}
	}

	public void JHCMPLGBLOI(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.NDPNCJAOGNL().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)(-57), KCNFNAICINO: false);
	}

	private void BJBPHIFNKIF()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(BLJAPKHCEPP));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(JANABBNOBCD));
	}

	public void FAGBAMHICPD(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.CFIFGDBGLPH().FinishEat();
		PJNGMCJIHME.ChangeState((CustomerState)(-79));
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void INDKJIHALGL(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	public void CHIFBKLEOAL(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.GetPlayer(0).ELDMCIGKIOK();
		if (GameManager.LocalCoop())
		{
			BeersWant.MOAKGLJCELI(6).GMBHLFINJNK();
		}
		DrinksTable.instance.CLJEJOOOIEC();
	}

	public void MLOHDAOFKLM(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.JHOGIKCHCGG().MJIEOAOAHJI();
		PJNGMCJIHME.ChangeState((CustomerState)(-13), KCNFNAICINO: false);
	}

	private void HOKBBFHGACN()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(DCKGJLELFKH));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(ENGEOENGFHK));
	}

	private void KFHFEBOOHCD(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(LLPNBIPDADI());
		}
	}

	private void CAOLDOKOCBE(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	public void AIGNHFPIOOE()
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			tableOrders[i].UpdateDrinkColorTable();
		}
	}

	public void MHFJOPIADJI(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.EPLLKPJIAFF().FinishEat();
		PJNGMCJIHME.ChangeState((CustomerState)46);
	}

	private void LOHNIHLMAED(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(IPLNMHJNHNM());
		}
	}

	private IEnumerator FACCDNLOFDN()
	{
		yield return null;
		while (tableOrders.Count > 0)
		{
			for (int i = 0; i < tableOrders.Count; i++)
			{
				if ((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(tableOrders[i].tableOrder) != (Object)null || (Barworker.JHLLELHBIDA && Barworker.HasDrinkOnTray(tableOrders[i].tableOrder)) || (Waiter.JHLLELHBIDA && Waiter.HasDrinkOnTray(tableOrders[i].tableOrder)) || DrinksTable.instance.currentDrinks.Contains(tableOrders[i].tableOrder) || PlayerController.GetPlayer(1).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder) || (GameManager.LocalCoop() && PlayerController.GetPlayer(2).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder)))
				{
					continue;
				}
				for (int j = 1; j <= 4; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
					{
						PlayerController.GetPlayer(j).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder);
					}
				}
				if (DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count != 0 || tableOrders[i].tableOrder.FBOGDCNCNMK() != 1318)
				{
					CustomerOrder customerOrder = tableOrders[i];
					List<ItemInstance> allDrinks = DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks();
					tableOrders[i].RemoveTableOrder();
					ItemInstance dNLMCHDOMOK = ((allDrinks.Count <= 0) ? ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML() : allDrinks[Random.Range(0, allDrinks.Count)]);
					customerOrder.RequestTableOrder(dNLMCHDOMOK);
				}
				break;
			}
			if (tableOrders.Count == 0)
			{
				break;
			}
			yield return CommonReferences.wait4;
		}
		JBPPFHDPCHF = null;
	}

	private void IAAGKLPMAMK()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(PCCBCCAHKJH));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(ENGEOENGFHK));
	}

	public void CCEHBICCBKP(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.NPANPNIDKDG(0).MGFDLLNKCHP();
		if (GameManager.LocalCoop())
		{
			BeersWant.PCEMNHHOHOP(4).OJJFGFLNBGL();
		}
		DrinksTable.instance.CLJEJOOOIEC();
	}

	private void OIPJKHKCEDO(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(BOHKKCMCDFL());
		}
	}

	public void OJAKGKHHFKA(Customer PJNGMCJIHME)
	{
		PJNGMCJIHME.npc.APBNLDNECGJ().FinishEat();
		PJNGMCJIHME.ChangeState((CustomerState)59);
	}

	public CustomerOrder CBHPHBNMEMJ(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].PMGKJFMLLFE().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	private void HLCCJBBGJLC()
	{
		if (NewTutorialManager.NCAFCCIIDAD() || NewTutorialManager.EHICNBPPAFK() || WorldTime.BKIIKAGIHAK())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.WaitingAtBar);
		if (list == null)
		{
			return;
		}
		Customer customer = list[1];
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		LDHFMMEKHKN(customer);
	}

	public CustomerOrder FHDILNBHNLE(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].tableOrder.Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	private IEnumerator BOHKKCMCDFL()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	private void DCKGJLELFKH(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(BCHINNOLCMM());
		}
	}

	private int CJMPPCOODIC()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 0;
		return Random.Range(0, num + 1);
	}

	public CustomerOrder KMKFMAFBPIJ(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 0; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].LKBJEDDKGBM().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	public void PIKHCMFHHAN(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(DOKAEMNDPOK());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.GetPlayer(1).DBGHHMIEMMH();
		if (GameManager.LocalCoop())
		{
			BeersWant.LJCKMLJJLKA(7).DBGHHMIEMMH();
		}
	}

	public CustomerOrder NLIFABPOFMK(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < tableOrders.Count; i += 0)
		{
			if (tableOrders[i].HDOHIKMGKEP().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	private void LAMKPCBAOED()
	{
		if (NewTutorialManager.NCAFCCIIDAD() || NewTutorialManager.EHICNBPPAFK() || WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.Inactive);
		if (list == null)
		{
			return;
		}
		Customer customer = list[0];
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		JHCMPLGBLOI(customer);
	}

	private int LMCPIGAPDOO()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 1;
		return Random.Range(1, num + 1);
	}

	public void LCDMKIAEBNO(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.LJCKMLJJLKA(1).CGGLDOIAMHG();
		if (GameManager.LocalCoop())
		{
			BeersWant.CDEGEPGEHED(1).ELDMCIGKIOK();
		}
		DrinksTable.instance.CheckCurrentDrinks();
	}

	private void BDGCFCPFKKE()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(ENGEOENGFHK));
	}

	public void APCOJIEEIMA(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(MKMEBDGBCIJ());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.JPDEFKLINCL(1).JKMGDIMNDFL();
		if (GameManager.LocalCoop())
		{
			BeersWant.PLHHJCNKNFO(1).FGAGEOCGIML();
		}
	}

	private void JOJCGBCNBOG()
	{
		if (NewTutorialManager.NewOrdersBlocked() || NewTutorialManager.DrinkOrdersBlocked() || WorldTime.EOMMHMGGEED())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.HeadingToBar);
		if (list == null)
		{
			return;
		}
		Customer customer = list[1];
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		EMMAFHKOAAB(customer);
	}

	public CustomerOrder GLMMDGKLDDC(ItemInstance DNLMCHDOMOK)
	{
		for (int i = 1; i < tableOrders.Count; i++)
		{
			if (tableOrders[i].KADOIIENGDI().Equals(DNLMCHDOMOK))
			{
				return tableOrders[i];
			}
		}
		return null;
	}

	private IEnumerator OJKDPBIELFL()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private void NFOPIMKHGMN(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(FMAKHDIGHAN());
		}
	}

	private IEnumerator DBKFDKFJMHB()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	private IEnumerator JCCGLJGAPFF()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	public void DJCJAPAALHG(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(ENKNIBCAPFG());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.IPCBCBBDJFN(1).IIOOBPABGEI();
		if (GameManager.LocalCoop())
		{
			BeersWant.AGMJPBEHCBK(2).FGAGEOCGIML();
		}
	}

	private void JNLLBCGHACJ(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(DBKFDKFJMHB());
		}
	}

	private IEnumerator IMAIEIJDDII(int PDCPGJCKICM)
	{
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateExtraOrders)).x, ((Vector2Int)(ref ordersRateExtraOrders)).y);
		while (PDCPGJCKICM > 0)
		{
			yield return CommonReferences.wait3;
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE || TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
			{
				break;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				PDCPGJCKICM--;
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateExtraOrders)).x, ((Vector2Int)(ref ordersRateExtraOrders)).y);
			}
		}
	}

	public void UpdateDrinksColor()
	{
		for (int i = 0; i < tableOrders.Count; i++)
		{
			tableOrders[i].UpdateDrinkColorTable();
		}
	}

	private IEnumerator IPLNMHJNHNM()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	private IEnumerator BCHINNOLCMM()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		float nextOrderTime = Time.time;
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRate)).x, ((Vector2Int)(ref ordersRate)).y);
				yield return CommonReferences.wait1;
				if (Random.Range(0, 100) < probabilityExtraOrders)
				{
					((MonoBehaviour)this).StartCoroutine(IMAIEIJDDII(LMCPIGAPDOO()));
				}
			}
			yield return CommonReferences.wait3;
		}
	}

	public void FALLMAIFLDO(CustomerOrder GIMHPAANCDH)
	{
		if (tableOrders.Count == 0)
		{
			JBPPFHDPCHF = ((MonoBehaviour)this).StartCoroutine(MKMEBDGBCIJ());
		}
		if (!tableOrders.Contains(GIMHPAANCDH))
		{
			tableOrders.Add(GIMHPAANCDH);
		}
		BeersWant.GDNDEEFDFGK(0).NGJONLJEOEG();
		if (GameManager.LocalCoop())
		{
			BeersWant.KAIIEDCCLHB(7).UpdateBeerWant();
		}
	}

	private void EOGHJNGJFID()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(ELHHIBMPKAI));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(JANABBNOBCD));
	}

	private IEnumerator PEJAFLOLEPB(int PDCPGJCKICM)
	{
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateExtraOrders)).x, ((Vector2Int)(ref ordersRateExtraOrders)).y);
		while (PDCPGJCKICM > 0)
		{
			yield return CommonReferences.wait3;
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE || TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
			{
				break;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				PDCPGJCKICM--;
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateExtraOrders)).x, ((Vector2Int)(ref ordersRateExtraOrders)).y);
			}
		}
	}

	private void CBGPIPIDBOA(int JIIGOACEIKL)
	{
		if (CJEGODILAOL != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJEGODILAOL);
		}
	}

	private int HBBOFNKGKPE()
	{
		int num = TavernManager.GGFJGHHHEJC.customers.Count / extraOrderForEachCustomersInTavern + 0;
		return Random.Range(1, num + 1);
	}

	private void KBHHLHFDEGL()
	{
		if (NewTutorialManager.NCAFCCIIDAD() || NewTutorialManager.EHICNBPPAFK() || WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<Customer> list = TavernManager.GGFJGHHHEJC.FindCustomersInState(CustomerState.HeadingToSeat);
		if (list == null)
		{
			return;
		}
		Customer customer = list[0];
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].KPGJGABJMFC == MoodState.Neutral && list[i].currentFinishEatTime < customer.currentFinishEatTime)
			{
				customer = list[i];
			}
		}
		KPOONDPCBPG(customer);
	}

	private void HLDFGLIMPFJ(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJEGODILAOL = ((MonoBehaviour)this).StartCoroutine(FMAKHDIGHAN());
		}
	}

	public void GJMHBCABJEH(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.PCEMNHHOHOP(1).NGJONLJEOEG();
		if (GameManager.LocalCoop())
		{
			BeersWant.IPCBCBBDJFN(6).NGJONLJEOEG();
		}
		DrinksTable.instance.OAHFDCLBDIE();
	}

	private IEnumerator EAMLANKPHHD(int PDCPGJCKICM)
	{
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateExtraOrders)).x, ((Vector2Int)(ref ordersRateExtraOrders)).y);
		while (PDCPGJCKICM > 0)
		{
			yield return CommonReferences.wait3;
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE || TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
			{
				break;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < maxTableOrders)
				{
					CJLOMICADKD();
				}
				PDCPGJCKICM--;
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateExtraOrders)).x, ((Vector2Int)(ref ordersRateExtraOrders)).y);
			}
		}
	}

	public void OEEFOADLKNM(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.MJJHNNJKEMO(0).NGJONLJEOEG();
		if (GameManager.LocalCoop())
		{
			BeersWant.DAEEJGKLOCF(6).BLBNAAELOPE();
		}
		DrinksTable.instance.CLJEJOOOIEC();
	}

	private IEnumerator OLHHOFDNBCD(int PDCPGJCKICM)
	{
		return new HPDEPEFFMEN(1)
		{
			_003C_003E4__this = this,
			number = PDCPGJCKICM
		};
	}

	public void RemoveTableOrder(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.GetPlayer(1).UpdateBeerWant();
		if (GameManager.LocalCoop())
		{
			BeersWant.GetPlayer(2).UpdateBeerWant();
		}
		DrinksTable.instance.CheckCurrentDrinks();
	}

	public void JGDBDKAANAE(CustomerOrder GIMHPAANCDH)
	{
		tableOrders.Remove(GIMHPAANCDH);
		if (tableOrders.Count == 0 && JBPPFHDPCHF != null)
		{
			((MonoBehaviour)this).StopCoroutine(JBPPFHDPCHF);
		}
		BeersWant.KDGAEHCELHA(0).JKMGDIMNDFL();
		if (GameManager.LocalCoop())
		{
			BeersWant.PCEMNHHOHOP(0).MGFDLLNKCHP();
		}
		DrinksTable.instance.CMKKOIABMIL();
	}

	private void AHFGOOHOLEL()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(HLDFGLIMPFJ));
		TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
		tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(ENGEOENGFHK));
	}

	private IEnumerator ENKNIBCAPFG()
	{
		yield return null;
		while (tableOrders.Count > 0)
		{
			for (int i = 0; i < tableOrders.Count; i++)
			{
				if ((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(tableOrders[i].tableOrder) != (Object)null || (Barworker.JHLLELHBIDA && Barworker.HasDrinkOnTray(tableOrders[i].tableOrder)) || (Waiter.JHLLELHBIDA && Waiter.HasDrinkOnTray(tableOrders[i].tableOrder)) || DrinksTable.instance.currentDrinks.Contains(tableOrders[i].tableOrder) || PlayerController.GetPlayer(1).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder) || (GameManager.LocalCoop() && PlayerController.GetPlayer(2).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder)))
				{
					continue;
				}
				for (int j = 1; j <= 4; j++)
				{
					if ((Object)(object)PlayerController.GetPlayer(j) != (Object)null)
					{
						PlayerController.GetPlayer(j).trayHandler.tray.OHAPOKICCNK(tableOrders[i].tableOrder);
					}
				}
				if (DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count != 0 || tableOrders[i].tableOrder.FBOGDCNCNMK() != 1318)
				{
					CustomerOrder customerOrder = tableOrders[i];
					List<ItemInstance> allDrinks = DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks();
					tableOrders[i].RemoveTableOrder();
					ItemInstance dNLMCHDOMOK = ((allDrinks.Count <= 0) ? ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML() : allDrinks[Random.Range(0, allDrinks.Count)]);
					customerOrder.RequestTableOrder(dNLMCHDOMOK);
				}
				break;
			}
			if (tableOrders.Count == 0)
			{
				break;
			}
			yield return CommonReferences.wait4;
		}
		JBPPFHDPCHF = null;
	}
}
