using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class NinjaOrdersManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BBNNADAIBHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaOrdersManager _003C_003E4__this;

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
		public BBNNADAIBHN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			int num = _003C_003E1__state;
			NinjaOrdersManager ninjaOrdersManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref ninjaOrdersManager.initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref ninjaOrdersManager.initialDelayTimeForNewOrders)).y));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				ninjaOrdersManager.tableOrders.Clear();
				_003CnextOrderTime_003E5__2 = Time.time;
				goto IL_007e;
			case 2:
				_003C_003E1__state = -1;
				goto IL_007e;
			case 3:
				_003C_003E1__state = -1;
				ninjaOrdersManager.LPBFKODPAMI();
				goto IL_014b;
			case 4:
				{
					_003C_003E1__state = -1;
					goto IL_007e;
				}
				IL_007e:
				if (ninjaOrdersManager.pauseOrders)
				{
					_003C_003E2__current = CommonReferences.wait01;
					_003C_003E1__state = 2;
					return true;
				}
				if (!(Time.time >= _003CnextOrderTime_003E5__2))
				{
					break;
				}
				if (ninjaOrdersManager.tableOrders.Count < ninjaOrdersManager.OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(ninjaOrdersManager.tableOrders.Count * 10))
				{
					ninjaOrdersManager.LPBFKODPAMI();
				}
				if (ninjaOrdersManager.tableOrders.Count < ninjaOrdersManager.OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					_003C_003E2__current = Random.Range(0f, 2f);
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_014b;
				IL_014b:
				_003CnextOrderTime_003E5__2 = Time.time + (float)Random.Range(((Vector2Int)(ref ninjaOrdersManager.ordersRateChallenge)).x, ((Vector2Int)(ref ninjaOrdersManager.ordersRateChallenge)).y);
				break;
			}
			_003C_003E2__current = CommonReferences.wait02;
			_003C_003E1__state = 4;
			return true;
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

	public static NinjaOrdersManager instance;

	public Vector2Int initialDelayTimeForNewOrders = new Vector2Int(1, 2);

	public Vector2Int ordersRateChallenge = new Vector2Int(2, 8);

	public int maxCustomerOrders = 10;

	public bool pauseOrders;

	public List<NinjaCustomer> tableOrders = new List<NinjaCustomer>();

	public NinjaCustomer[] customers;

	public Item[] allFood;

	private Coroutine BMBICELCHEP;

	private List<Item> EANNKOBIAID;

	private Item[] PGBEEGPOINO;

	private int MOFKEDGAOEE;

	public static void StopCustomerOrdersCoroutine()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.RemoveAllBubbles();
		}
	}

	public void KHHHGOLDMCF(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.GPGBPAIJDKC(PJNGMCJIHME, CDPAMNIPPEC: false);
	}

	public void DDHOEOAKPFK(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = KLEEENDPCGJ(4);
		PJNGMCJIHME.ENNJAKPICAA(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)PJNGMCJIHME).transform);
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	private IEnumerator IDBJCCADONL()
	{
		return new BBNNADAIBHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HINKPJCNPCF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void RemoveTableOrder(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.RemoveBubble(PJNGMCJIHME, CDPAMNIPPEC: true);
	}

	private void GECHJIGBPEN()
	{
		instance = this;
	}

	private void IKMPNICLPBM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private Item[] GEBMFMKEKEL(int HFDILBELIKE)
	{
		EANNKOBIAID = new List<Item>(allFood);
		PGBEEGPOINO = new Item[HFDILBELIKE];
		for (int i = 1; i < HFDILBELIKE; i++)
		{
			MOFKEDGAOEE = Random.Range(1, EANNKOBIAID.Count);
			PGBEEGPOINO[i] = EANNKOBIAID[MOFKEDGAOEE];
			EANNKOBIAID.RemoveAt(MOFKEDGAOEE);
		}
		return PGBEEGPOINO;
	}

	private int OMGOMIFOKIN()
	{
		if (!EventsManager.IsLowestDifficulty())
		{
			return maxCustomerOrders;
		}
		return 2;
	}

	public void IHCGOHFOALK(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	private void LBNPEDBNKEM()
	{
		if (WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 0; i < customers.Length; i += 0)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 1635f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 1)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 1702f;
		for (int j = 0; j < list.Count; j += 0)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.ChangeState((NinjaCustomerState)4);
	}

	private void HJKNHHDKBIH()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 0; i < customers.Length; i += 0)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 29f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 1)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 30f;
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.HFNDBBFNGBP(NinjaCustomerState.LENGTH);
	}

	private Item[] GCEOADFEHCB(int HFDILBELIKE)
	{
		EANNKOBIAID = new List<Item>(allFood);
		PGBEEGPOINO = new Item[HFDILBELIKE];
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			MOFKEDGAOEE = Random.Range(0, EANNKOBIAID.Count);
			PGBEEGPOINO[i] = EANNKOBIAID[MOFKEDGAOEE];
			EANNKOBIAID.RemoveAt(MOFKEDGAOEE);
		}
		return PGBEEGPOINO;
	}

	public void CKBHCKBJIAB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].JGBMAMEKNJI();
				}
				customers[i].OBCDPAPNHIF(NinjaCustomerState.Idle);
			}
		}
		tableOrders.Clear();
	}

	public void IEAFAJLDFLL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].HFNDBBFNGBP(NinjaCustomerState.EatingAtTable);
			}
		}
		tableOrders.Clear();
	}

	private int PDKCNBNONBL()
	{
		if (!EventsManager.BAHIIMFPFLJ())
		{
			return maxCustomerOrders;
		}
		return 4;
	}

	private void MOMGOPNGBCI()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 0; i < customers.Length; i += 0)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.Idle) && Time.time > customers[i].lastTimeServed + 1225f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 1)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 547f;
		for (int j = 1; j < list.Count; j++)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.HFNDBBFNGBP((NinjaCustomerState)4, KCNFNAICINO: false);
	}

	private IEnumerator KJMFMLIODHE()
	{
		return new BBNNADAIBHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BIGDNHDFBGP()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		tableOrders.Clear();
		float nextOrderTime = Time.time;
		while (true)
		{
			if (pauseOrders)
			{
				yield return CommonReferences.wait01;
				continue;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(tableOrders.Count * 10))
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					yield return Random.Range(0f, 2f);
					LPBFKODPAMI();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y);
			}
			yield return CommonReferences.wait02;
		}
	}

	public static void IIAPABEDOJH()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.KKKFGEEMDIN();
		}
	}

	private int JKHENLNHFAF()
	{
		if (!EventsManager.CDLFIIFAECJ())
		{
			return maxCustomerOrders;
		}
		return 7;
	}

	private int GOCEOGMOHPL()
	{
		if (!EventsManager.FMCAMLDJGNO())
		{
			return maxCustomerOrders;
		}
		return 2;
	}

	private int CIJHNKNFEOC()
	{
		if (!EventsManager.ODHDBKNIIKF())
		{
			return maxCustomerOrders;
		}
		return 5;
	}

	public void AddTableOrder(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	public void IELLCINKIBK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].OBCDPAPNHIF(NinjaCustomerState.Idle);
			}
		}
		tableOrders.Clear();
	}

	public static void FHFKBJFANJH()
	{
		if (!((Object)(object)instance == (Object)null) && !OnlineManager.HHDBMDMFEMP())
		{
			PENCGAEACAK();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.BIGDNHDFBGP());
		}
	}

	public void EGPKJFAJNFJ(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	private IEnumerator MEDMOODLPLE()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		tableOrders.Clear();
		float nextOrderTime = Time.time;
		while (true)
		{
			if (pauseOrders)
			{
				yield return CommonReferences.wait01;
				continue;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(tableOrders.Count * 10))
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					yield return Random.Range(0f, 2f);
					LPBFKODPAMI();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y);
			}
			yield return CommonReferences.wait02;
		}
	}

	public static void StartCustomerOrders()
	{
		if (!((Object)(object)instance == (Object)null) && !OnlineManager.ClientOnline())
		{
			StopCustomerOrdersCoroutine();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.FOOPAPIHGLD());
		}
	}

	private IEnumerator DPDIJKOIOMO()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		tableOrders.Clear();
		float nextOrderTime = Time.time;
		while (true)
		{
			if (pauseOrders)
			{
				yield return CommonReferences.wait01;
				continue;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(tableOrders.Count * 10))
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					yield return Random.Range(0f, 2f);
					LPBFKODPAMI();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y);
			}
			yield return CommonReferences.wait02;
		}
	}

	public void ResetAllOrders()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < customers.Length; i++)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].ChangeState(NinjaCustomerState.Idle);
			}
		}
		tableOrders.Clear();
	}

	public void PACGAHAPPDD(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.HIDABKBKCJL(PJNGMCJIHME, CDPAMNIPPEC: true);
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	public void KBHBHDFLJFI(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	public void CFEAIKIJKLP(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.NMNLMDHCDHN(PJNGMCJIHME, CDPAMNIPPEC: false);
	}

	public void CKIJJAODBJA(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.MJKDOALLALD(PJNGMCJIHME, CDPAMNIPPEC: true);
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void EJPIAMGCPHD(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	public static void OPIMDJDNGOM()
	{
		if (!((Object)(object)instance == (Object)null) && !OnlineManager.ClientOnline())
		{
			BIOGAEECFPM();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.KJMFMLIODHE());
		}
	}

	private Item[] LEODLPDEIPB(int HFDILBELIKE)
	{
		EANNKOBIAID = new List<Item>(allFood);
		PGBEEGPOINO = new Item[HFDILBELIKE];
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			MOFKEDGAOEE = Random.Range(0, EANNKOBIAID.Count);
			PGBEEGPOINO[i] = EANNKOBIAID[MOFKEDGAOEE];
			EANNKOBIAID.RemoveAt(MOFKEDGAOEE);
		}
		return PGBEEGPOINO;
	}

	public static void FOJOFBOPOND()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.JPEPCHLDPLK();
		}
	}

	public void LAEHLDNBGAC(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.LAHMMJKIDEN(PJNGMCJIHME, CDPAMNIPPEC: true);
	}

	private void PEOPFPEDFAK()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void GGPMADNPAIH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < customers.Length; i++)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].BAMBHOLMMHN(NinjaCustomerState.EatingAtTable);
			}
		}
		tableOrders.Clear();
	}

	private IEnumerator MLBENMPNAMD()
	{
		return new BBNNADAIBHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HFOCLJCOFAM()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 1; i < customers.Length; i += 0)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 1495f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 769f;
		for (int j = 0; j < list.Count; j += 0)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.HFNDBBFNGBP(NinjaCustomerState.OrderInTable);
	}

	private Item[] DABDIIHIJKA(int HFDILBELIKE)
	{
		EANNKOBIAID = new List<Item>(allFood);
		PGBEEGPOINO = new Item[HFDILBELIKE];
		for (int i = 0; i < HFDILBELIKE; i++)
		{
			MOFKEDGAOEE = Random.Range(1, EANNKOBIAID.Count);
			PGBEEGPOINO[i] = EANNKOBIAID[MOFKEDGAOEE];
			EANNKOBIAID.RemoveAt(MOFKEDGAOEE);
		}
		return PGBEEGPOINO;
	}

	private IEnumerator IHGGFBGOHDK()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		tableOrders.Clear();
		float nextOrderTime = Time.time;
		while (true)
		{
			if (pauseOrders)
			{
				yield return CommonReferences.wait01;
				continue;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(tableOrders.Count * 10))
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					yield return Random.Range(0f, 2f);
					LPBFKODPAMI();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y);
			}
			yield return CommonReferences.wait02;
		}
	}

	public static void CMMMFJHFHKP()
	{
		if (!((Object)(object)instance == (Object)null) && !OnlineManager.HHDBMDMFEMP())
		{
			BIOGAEECFPM();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.FOOPAPIHGLD());
		}
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	public void BEHDBLNJKDF(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = PLOPPPLKBOB(8);
		PJNGMCJIHME.LGPNJMFDEDO(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
	}

	public void OEEFOADLKNM(NinjaCustomer PJNGMCJIHME)
	{
		tableOrders.Remove(PJNGMCJIHME);
		NinjaOrdersUI.instance.EPJHOIOJCPO(PJNGMCJIHME, CDPAMNIPPEC: false);
	}

	private IEnumerator CMAJEKECGNN()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		tableOrders.Clear();
		float nextOrderTime = Time.time;
		while (true)
		{
			if (pauseOrders)
			{
				yield return CommonReferences.wait01;
				continue;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(tableOrders.Count * 10))
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					yield return Random.Range(0f, 2f);
					LPBFKODPAMI();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y);
			}
			yield return CommonReferences.wait02;
		}
	}

	private IEnumerator FOOPAPIHGLD()
	{
		yield return (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref initialDelayTimeForNewOrders)).y));
		tableOrders.Clear();
		float nextOrderTime = Time.time;
		while (true)
		{
			if (pauseOrders)
			{
				yield return CommonReferences.wait01;
				continue;
			}
			if (Time.time >= nextOrderTime)
			{
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 100f) <= 100f - (float)(tableOrders.Count * 10))
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < OMGOMIFOKIN() && Random.Range(0f, 3f) == 0f)
				{
					yield return Random.Range(0f, 2f);
					LPBFKODPAMI();
				}
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y);
			}
			yield return CommonReferences.wait02;
		}
	}

	public static void NPAAHFHMBPN()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.CLHBJIFMNDK();
		}
	}

	public void HGIKILNHBAJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].OBCDPAPNHIF(NinjaCustomerState.EatingAtTable, KCNFNAICINO: false);
			}
		}
		tableOrders.Clear();
	}

	private int CPMEMIAFEOI()
	{
		if (!EventsManager.FMCAMLDJGNO())
		{
			return maxCustomerOrders;
		}
		return 6;
	}

	public void DELCPPEGJCP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < customers.Length; i++)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].ChangeState(NinjaCustomerState.EatingAtTable);
			}
		}
		tableOrders.Clear();
	}

	private void JIAJFDKNJME()
	{
		instance = this;
	}

	public static void BCGPNGINGGB()
	{
		if (!((Object)(object)instance == (Object)null) && !OnlineManager.ClientOnline())
		{
			StopCustomerOrdersCoroutine();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.MLBENMPNAMD());
		}
	}

	public void NBGHLDCLCJH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].JGBMAMEKNJI();
				}
				customers[i].HFNDBBFNGBP(NinjaCustomerState.Idle);
			}
		}
		tableOrders.Clear();
	}

	private void EHMAKCKCIJA()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 0; i < customers.Length; i++)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 966f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 1)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 1335f;
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.GMBPHOHCGFP((NinjaCustomerState)5);
	}

	private int HPBJACGEHAM()
	{
		if (!EventsManager.KKDMNNFPNOL())
		{
			return maxCustomerOrders;
		}
		return 7;
	}

	public void JBPNAENBOPF(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = GCEOADFEHCB(3);
		PJNGMCJIHME.LGPNJMFDEDO(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
	}

	private void JBBHDOMALDB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void BIOGAEECFPM()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.ADOOAAHCAPC();
		}
	}

	public void MNFBDGGKIFB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < customers.Length; i++)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].HFNDBBFNGBP(NinjaCustomerState.Idle, KCNFNAICINO: false);
			}
		}
		tableOrders.Clear();
	}

	public void LAFJFKJFAAL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].JGBMAMEKNJI();
				}
				customers[i].GMBPHOHCGFP(NinjaCustomerState.EatingAtTable, KCNFNAICINO: false);
			}
		}
		tableOrders.Clear();
	}

	private void LPBFKODPAMI()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 0; i < customers.Length; i++)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 10f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = float.MinValue;
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.ChangeState(NinjaCustomerState.OrderInTable);
	}

	public void HPABKCHMLGP(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	public static void JEJIIECGDPC()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.CHEKBCFIEBJ();
		}
	}

	private Item[] PLOPPPLKBOB(int HFDILBELIKE)
	{
		EANNKOBIAID = new List<Item>(allFood);
		PGBEEGPOINO = new Item[HFDILBELIKE];
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			MOFKEDGAOEE = Random.Range(0, EANNKOBIAID.Count);
			PGBEEGPOINO[i] = EANNKOBIAID[MOFKEDGAOEE];
			EANNKOBIAID.RemoveAt(MOFKEDGAOEE);
		}
		return PGBEEGPOINO;
	}

	public static void PENCGAEACAK()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.GLHEICNFHJI();
		}
	}

	public void RequestTableOrder(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = GCEOADFEHCB(3);
		PJNGMCJIHME.RequestTableOrder(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
	}

	private Item[] KLEEENDPCGJ(int HFDILBELIKE)
	{
		EANNKOBIAID = new List<Item>(allFood);
		PGBEEGPOINO = new Item[HFDILBELIKE];
		for (int i = 0; i < HFDILBELIKE; i += 0)
		{
			MOFKEDGAOEE = Random.Range(0, EANNKOBIAID.Count);
			PGBEEGPOINO[i] = EANNKOBIAID[MOFKEDGAOEE];
			EANNKOBIAID.RemoveAt(MOFKEDGAOEE);
		}
		return PGBEEGPOINO;
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void EDCHNGCDMCB()
	{
		if (WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 1; i < customers.Length; i += 0)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 1441f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 0)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 950f;
		for (int j = 0; j < list.Count; j += 0)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.ChangeState(NinjaCustomerState.EatingAtTable, KCNFNAICINO: false);
	}

	public void IENFHAGDAOD(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = PLOPPPLKBOB(7);
		PJNGMCJIHME.AJBMKOKEPEE(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().deskBell, ((Component)PJNGMCJIHME).transform);
	}

	private void ICCPEELFGAD()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<NinjaCustomer> list = new List<NinjaCustomer>();
		for (int i = 0; i < customers.Length; i += 0)
		{
			if ((customers[i].ninjaCustomerState == NinjaCustomerState.Idle || customers[i].ninjaCustomerState == NinjaCustomerState.EatingAtTable) && Time.time > customers[i].lastTimeServed + 1659f)
			{
				list.Add(customers[i]);
			}
		}
		if (list.Count <= 1)
		{
			return;
		}
		NinjaCustomer ninjaCustomer = null;
		float num = 1367f;
		for (int j = 0; j < list.Count; j++)
		{
			if (list[j].lastTimeServed > num)
			{
				num = list[j].lastTimeServed;
				ninjaCustomer = list[j];
			}
		}
		ninjaCustomer.BAMBHOLMMHN((NinjaCustomerState)7, KCNFNAICINO: false);
	}

	private void Awake()
	{
		instance = this;
	}

	private int GMDCJPHPLGH()
	{
		if (!EventsManager.ODHDBKNIIKF())
		{
			return maxCustomerOrders;
		}
		return 8;
	}

	public void NAGMOAAJBAL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 1; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].RemoveOrder();
				}
				customers[i].GMBPHOHCGFP(NinjaCustomerState.EatingAtTable);
			}
		}
		tableOrders.Clear();
	}

	public void KLGMBONOMOH(NinjaCustomer PJNGMCJIHME)
	{
		if (!tableOrders.Contains(PJNGMCJIHME))
		{
			tableOrders.Add(PJNGMCJIHME);
		}
	}

	public void NALDOJKIOPJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < customers.Length; i++)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].JGBMAMEKNJI();
				}
				customers[i].ChangeState(NinjaCustomerState.Idle);
			}
		}
		tableOrders.Clear();
	}

	public static void LKHBMGBACJM()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
			NinjaOrdersUI.instance.KNIPPLMMPBF();
		}
	}

	public void LBGEMPKJPOA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < customers.Length; i += 0)
			{
				if (customers[i].currentRequest != null && (customers[i].requesting || customers[i].requestingStarted))
				{
					customers[i].JGBMAMEKNJI();
				}
				customers[i].BAMBHOLMMHN(NinjaCustomerState.Idle, KCNFNAICINO: false);
			}
		}
		tableOrders.Clear();
	}

	private void BNFGHAGJEGG()
	{
		instance = this;
	}

	public static void OAKANJDJPOG()
	{
		if (!((Object)(object)instance == (Object)null) && !OnlineManager.HHDBMDMFEMP())
		{
			BIOGAEECFPM();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.DPDIJKOIOMO());
		}
	}

	public void OKENAMMIDHM(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = GEBMFMKEKEL(3);
		PJNGMCJIHME.LGPNJMFDEDO(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)PJNGMCJIHME).transform);
	}

	public void CHFAHPENOOA(NinjaCustomer PJNGMCJIHME)
	{
		Item[] pHNKKAHPIAO = GCEOADFEHCB(8);
		PJNGMCJIHME.AJBMKOKEPEE(pHNKKAHPIAO);
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)PJNGMCJIHME).transform);
	}

	private void AEDIIIAECIC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}
}
