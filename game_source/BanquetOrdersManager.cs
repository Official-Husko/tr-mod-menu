using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class BanquetOrdersManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IMLAGBNBHHH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BanquetOrdersManager _003C_003E4__this;

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
		public IMLAGBNBHHH(int _003C_003E1__state)
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
			BanquetOrdersManager banquetOrdersManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(((Vector2Int)(ref banquetOrdersManager.initialDelayTimeForNewOrders)).x, ((Vector2Int)(ref banquetOrdersManager.initialDelayTimeForNewOrders)).y));
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				banquetOrdersManager.tableOrders.Clear();
				_003CnextOrderTime_003E5__2 = Time.time;
				goto IL_007e;
			case 2:
				_003C_003E1__state = -1;
				goto IL_007e;
			case 3:
				_003C_003E1__state = -1;
				banquetOrdersManager.LPBFKODPAMI();
				goto IL_0125;
			case 4:
				{
					_003C_003E1__state = -1;
					goto IL_007e;
				}
				IL_007e:
				if (banquetOrdersManager.pauseOrders)
				{
					_003C_003E2__current = CommonReferences.wait01;
					_003C_003E1__state = 2;
					return true;
				}
				if (!(Time.time >= _003CnextOrderTime_003E5__2))
				{
					break;
				}
				if (banquetOrdersManager.tableOrders.Count < banquetOrdersManager.maxCustomerOrders)
				{
					banquetOrdersManager.LPBFKODPAMI();
				}
				if (banquetOrdersManager.tableOrders.Count < banquetOrdersManager.maxCustomerOrders && Random.Range(0f, 2f) == 0f)
				{
					_003C_003E2__current = Random.Range(0f, 1f);
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_0125;
				IL_0125:
				if (BanquetEvent.GGPPFKPOCLL)
				{
					_003CnextOrderTime_003E5__2 = Time.time + (float)Random.Range(((Vector2Int)(ref banquetOrdersManager.ordersRateChallenge)).x, ((Vector2Int)(ref banquetOrdersManager.ordersRateChallenge)).y);
				}
				else
				{
					_003CnextOrderTime_003E5__2 = Time.time + (float)Random.Range(((Vector2Int)(ref banquetOrdersManager.ordersRateNotChallenge)).x, ((Vector2Int)(ref banquetOrdersManager.ordersRateNotChallenge)).y);
				}
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

	public static BanquetOrdersManager instance;

	public Vector2Int initialDelayTimeForNewOrders = new Vector2Int(1, 2);

	public Vector2Int ordersRateNotChallenge = new Vector2Int(20, 30);

	public Vector2Int ordersRateChallenge = new Vector2Int(2, 8);

	public int maxCustomerOrders = 10;

	public bool pauseOrders;

	public List<BanquetCustomer> tableOrders = new List<BanquetCustomer>();

	public BanquetCustomer[] banquetCustomers;

	private Coroutine BMBICELCHEP;

	public void ADOMCLLPMLO(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public static void COGCAMEMHOM()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public void FMBEJCJJGCJ(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void OMOIGMEMPOO(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	private void IGBEKHCLKFD()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void DBMKDKODLMC(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void GOBMAHFDDIJ(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void GDLNGGOAAHH(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void MFAOAJJIEJC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < banquetCustomers.Length; i += 0)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].HLEJMAOOBKC();
					banquetCustomers[i].PLJMJBPHNLE(BanquetCustomerState.Inactive, KCNFNAICINO: false);
				}
			}
		}
		tableOrders.Clear();
	}

	public void AHLOJANOMAB(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public void NMLLGDJLMIP(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.LKNPKAKOGMM();
		if (itemInstance != null)
		{
			HADLCFDMGII.RequestTableOrder(itemInstance, !BanquetRoundsManager.instance.IsColorVisibleInOrders());
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("Disconnecting..." + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public void RemoveTableOrder(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public void BNDADDLAKPO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			for (int i = 0; i < banquetCustomers.Length; i++)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].HLEJMAOOBKC();
					banquetCustomers[i].PLJMJBPHNLE(BanquetCustomerState.Inactive);
				}
			}
		}
		tableOrders.Clear();
	}

	private void HFKOBCFMNJJ()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void EKPALOHNDKA(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void GDNKCDLEADL(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	private void MBBIGANCPNE()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void EFPKJAKBAFF(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public static void KGKAOADFLFB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public void MIGLIIOBDMI(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	private IEnumerator MBFHKOEHMFA()
	{
		return new IMLAGBNBHHH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void AKEBIOMFFEO()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			JIHPNFMECPG();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.GKGCHEIIFJO());
		}
	}

	private void LBNPEDBNKEM()
	{
		if (WorldTime.EOMMHMGGEED())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.Inactive)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState((BanquetCustomerState)6);
			}
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
		}
	}

	public static void IFCJBHJJLAM()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KPPPHEMEPKE();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.NFPBGGAOHDA());
		}
	}

	public void GMALIFOCAFL(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void PJAHMCMMNNH(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	private void CAINBOMACDB()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.Inactive)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState(BanquetCustomerState.LENGTH);
			}
		}
	}

	public static void OHGDAAEMNPE()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	private void LBBNJJAPDDL()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.Inactive)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.PLJMJBPHNLE((BanquetCustomerState)6);
			}
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	private void JCHMICLODGM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void LPBFKODPAMI()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState(BanquetCustomerState.OrderInTable);
			}
		}
	}

	public static void NAEJOBGMIFE()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public void RequestTableOrder(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance drinkOrder = BanquetDrinksManager.instance.GetDrinkOrder();
		if (drinkOrder != null)
		{
			HADLCFDMGII.RequestTableOrder(drinkOrder, !BanquetRoundsManager.instance.IsColorVisibleInOrders());
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("No drink available for order in banquet event. Customer: " + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public void IHCGOHFOALK(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public static void EFOBHHKEGEA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public static void EKLOFCGOHND()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			IPAMMHINLBP();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.MBFHKOEHMFA());
		}
	}

	private void PFHBKNJAJFH()
	{
		if (WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState(BanquetCustomerState.Inactive, KCNFNAICINO: false);
			}
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public void GNCJNLMDOKJ(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void GAOEAJOIEFO(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	private void GOOPOBMDALA()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void KPPPHEMEPKE()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public static void JIHPNFMECPG()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	private void BDDBDNPCPGC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void CLNFDLNNGBD()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			NAEJOBGMIFE();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.HJNIJBFIMEJ());
		}
	}

	public void IEHKOHMPLHH(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public static void StopCustomerOrdersCoroutine()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	private void APPGDIHOBBI()
	{
		if (WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.PLJMJBPHNLE(BanquetCustomerState.LENGTH, KCNFNAICINO: false);
			}
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void CKGJAOHPHOA()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void AADHNKNDOFD()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KGKAOADFLFB();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.FOOPAPIHGLD());
		}
	}

	private void MGEIHBNCIDM()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState((BanquetCustomerState)6, KCNFNAICINO: false);
			}
		}
	}

	public void MFKJEJEGJOC(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.LKNPKAKOGMM();
		if (itemInstance != null)
		{
			HADLCFDMGII.AJBMKOKEPEE(itemInstance, !BanquetRoundsManager.instance.OGNJCKELNEK());
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("Access" + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public static void HEMLIOFIICF()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KPPPHEMEPKE();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.HJNIJBFIMEJ());
		}
	}

	public void FMCJOOFGNNB(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public static void StartCustomerOrders()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			StopCustomerOrdersCoroutine();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.FOOPAPIHGLD());
		}
	}

	public void MGAKAHKJHHA(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public static void CKEIOJNDOIJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public void JLFDKBNPBIK(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void PJLJFJIDOKI(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance drinkOrder = BanquetDrinksManager.instance.GetDrinkOrder();
		if (drinkOrder != null)
		{
			HADLCFDMGII.RequestTableOrder(drinkOrder, BanquetRoundsManager.instance.IsColorVisibleInOrders());
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("sForSeconds" + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	private void FGLJPGBFPBC()
	{
		instance = this;
	}

	private void HJANCPIFLIJ()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void EOMJBBGJLKE(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	private void LBBMFJOANKJ()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState((BanquetCustomerState)8);
			}
		}
	}

	private void ALKHMJNLDDG()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.PLJMJBPHNLE(BanquetCustomerState.Inactive, KCNFNAICINO: false);
			}
		}
	}

	public static void CEHEBGLCJME()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public static void IGKFCNIPLGJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			COGCAMEMHOM();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.NFPBGGAOHDA());
		}
	}

	public void EPILPOLBIMG(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void GADCOKCHAMD(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.NNPBBIKJLNA();
		if (itemInstance != null)
		{
			HADLCFDMGII.RequestTableOrder(itemInstance, BanquetRoundsManager.instance.MNEABKKFCDI());
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("Items/item_name_1074" + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	private void MEHNHEDLHOK()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.PLJMJBPHNLE(BanquetCustomerState.EatingAtTable, KCNFNAICINO: false);
			}
		}
	}

	public static void KIJEJOBMJIB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KPPPHEMEPKE();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.HJNIJBFIMEJ());
		}
	}

	public void IMBJPCNDLKD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < banquetCustomers.Length; i++)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].MEMHBEIAICP();
					banquetCustomers[i].PLJMJBPHNLE(BanquetCustomerState.EatingAtTable);
				}
			}
		}
		tableOrders.Clear();
	}

	public void JDECPFEJDCC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < banquetCustomers.Length; i++)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].GCKMHJLIGGJ();
					banquetCustomers[i].PLJMJBPHNLE(BanquetCustomerState.Inactive);
				}
			}
		}
		tableOrders.Clear();
	}

	public void BAOFKFHLHFC(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	private void FCJIDBIJMLN()
	{
		if (WorldTime.EOMMHMGGEED())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.Inactive)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.PLJMJBPHNLE((BanquetCustomerState)5);
			}
		}
	}

	public void HDLAIFPJJHH(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void AHAJNMFEEFF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < banquetCustomers.Length; i += 0)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].RemoveTableOrder();
					banquetCustomers[i].PLJMJBPHNLE(BanquetCustomerState.EatingAtTable);
				}
			}
		}
		tableOrders.Clear();
	}

	public static void MFDDJFKIJJJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			EFOBHHKEGEA();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.GFJCAGLCFGG());
		}
	}

	private IEnumerator GFJCAGLCFGG()
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
				if (tableOrders.Count < maxCustomerOrders)
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < maxCustomerOrders && Random.Range(0f, 2f) == 0f)
				{
					yield return Random.Range(0f, 1f);
					LPBFKODPAMI();
				}
				nextOrderTime = ((!BanquetEvent.GGPPFKPOCLL) ? (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateNotChallenge)).x, ((Vector2Int)(ref ordersRateNotChallenge)).y)) : (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y)));
			}
			yield return CommonReferences.wait02;
		}
	}

	private IEnumerator GKGCHEIIFJO()
	{
		return new IMLAGBNBHHH(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void IPAMMHINLBP()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	public void POJAIFLHKBK(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public static void HOMJHELEBLE()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KPPPHEMEPKE();
			instance.BMBICELCHEP = ((MonoBehaviour)instance).StartCoroutine(instance.GGGICLFEJPC());
		}
	}

	private IEnumerator EMBMFBKIJLG()
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
				if (tableOrders.Count < maxCustomerOrders)
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < maxCustomerOrders && Random.Range(0f, 2f) == 0f)
				{
					yield return Random.Range(0f, 1f);
					LPBFKODPAMI();
				}
				nextOrderTime = ((!BanquetEvent.GGPPFKPOCLL) ? (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateNotChallenge)).x, ((Vector2Int)(ref ordersRateNotChallenge)).y)) : (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y)));
			}
			yield return CommonReferences.wait02;
		}
	}

	private void CBKPNLCBEAL()
	{
		if (WorldTime.EOMMHMGGEED())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState((BanquetCustomerState)4);
			}
		}
	}

	public void HCDBCKNOOCA(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void JMEMPNLNDPK(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public static void CGGENCKIANC()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator JMAFMJPCJFN()
	{
		return new IMLAGBNBHHH(1)
		{
			_003C_003E4__this = this
		};
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
				if (tableOrders.Count < maxCustomerOrders)
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < maxCustomerOrders && Random.Range(0f, 2f) == 0f)
				{
					yield return Random.Range(0f, 1f);
					LPBFKODPAMI();
				}
				nextOrderTime = ((!BanquetEvent.GGPPFKPOCLL) ? (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateNotChallenge)).x, ((Vector2Int)(ref ordersRateNotChallenge)).y)) : (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y)));
			}
			yield return CommonReferences.wait02;
		}
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	private IEnumerator GGGICLFEJPC()
	{
		return new IMLAGBNBHHH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DJCJAPAALHG(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void JPDFBBAMDBF(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public static void PBLKCAMDKNK()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public void MKMNJBLBMNM(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void IHJGFNAHBKM(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void LIBPJELCBNI(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void ResetAllOrders()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 0; i < banquetCustomers.Length; i++)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].RemoveTableOrder();
					banquetCustomers[i].ChangeState(BanquetCustomerState.EatingAtTable);
				}
			}
		}
		tableOrders.Clear();
	}

	public void NPICCNHLLNO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			for (int i = 1; i < banquetCustomers.Length; i += 0)
			{
				if ((banquetCustomers[i].currentRequest != null && banquetCustomers[i].requesting) || banquetCustomers[i].requestingStarted)
				{
					banquetCustomers[i].MEMHBEIAICP();
					banquetCustomers[i].ChangeState(BanquetCustomerState.Inactive);
				}
			}
		}
		tableOrders.Clear();
	}

	public void AKEEBMIAHJP(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	public void OCEOIJKDHHE(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	private void OCMPPGDNLFI()
	{
		if (WorldTime.BEGCEJALKNP())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState(BanquetCustomerState.Inactive);
			}
		}
	}

	private void DNBGIIGAKMJ()
	{
		instance = this;
	}

	public void SetVisibleColorInOrders(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void FOCCOKEHJMA(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public void GLLHGGOCBFK(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	private IEnumerator HJNIJBFIMEJ()
	{
		return new IMLAGBNBHHH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IOPFMPHMOMI()
	{
		if (WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.Inactive)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.PLJMJBPHNLE((BanquetCustomerState)6, KCNFNAICINO: false);
			}
		}
	}

	public static void CGIMCCGPLLD()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public void FGHNKLIJABE(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.CNHJFGCNJPP();
		if (itemInstance != null)
		{
			HADLCFDMGII.RequestTableOrder(itemInstance, BanquetRoundsManager.instance.FCCOOKFJPGE());
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("mainMenuMultiplayerButtonConnecting" + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public void FFJNIHIDODM(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.JPFFGDEKCDK();
		if (itemInstance != null)
		{
			HADLCFDMGII.RequestTableOrder(itemInstance, !BanquetRoundsManager.instance.EBMHOLCJCHG());
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("Resolucion nativa: " + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public void DOJEHDHAMHJ(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	private IEnumerator BAAPNEODFNL()
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
				if (tableOrders.Count < maxCustomerOrders)
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < maxCustomerOrders && Random.Range(0f, 2f) == 0f)
				{
					yield return Random.Range(0f, 1f);
					LPBFKODPAMI();
				}
				nextOrderTime = ((!BanquetEvent.GGPPFKPOCLL) ? (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateNotChallenge)).x, ((Vector2Int)(ref ordersRateNotChallenge)).y)) : (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y)));
			}
			yield return CommonReferences.wait02;
		}
	}

	public void ECIBMMEDJLF(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	private void ILCBKEIEOAN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator NFPBGGAOHDA()
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
				if (tableOrders.Count < maxCustomerOrders)
				{
					LPBFKODPAMI();
				}
				if (tableOrders.Count < maxCustomerOrders && Random.Range(0f, 2f) == 0f)
				{
					yield return Random.Range(0f, 1f);
					LPBFKODPAMI();
				}
				nextOrderTime = ((!BanquetEvent.GGPPFKPOCLL) ? (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateNotChallenge)).x, ((Vector2Int)(ref ordersRateNotChallenge)).y)) : (Time.time + (float)Random.Range(((Vector2Int)(ref ordersRateChallenge)).x, ((Vector2Int)(ref ordersRateChallenge)).y)));
			}
			yield return CommonReferences.wait02;
		}
	}

	public void KLGMBONOMOH(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	private void KLHIMJFCHPD()
	{
		instance = this;
	}

	public void CPLCEEBDMGP(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.JPFFGDEKCDK();
		if (itemInstance != null)
		{
			HADLCFDMGII.RequestTableOrder(itemInstance, !BanquetRoundsManager.instance.JFFICGAOHDC());
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("Game Over! " + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public void FIEOGHHPFAL(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public void AddTableOrder(BanquetCustomer HADLCFDMGII)
	{
		if (!tableOrders.Contains(HADLCFDMGII))
		{
			tableOrders.Add(HADLCFDMGII);
		}
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void FDGFMMKIBPL()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void BKKEPCJHHBA()
	{
		if (WorldTime.TickTimeIsBlocked())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i++)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.Inactive)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 1)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(0, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState((BanquetCustomerState)5);
			}
		}
	}

	private void MDGLECECOIG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void JBAAPDIDKKE(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < banquetCustomers.Length; i++)
		{
			if ((Object)(object)banquetCustomers[i].drinkColor != (Object)null)
			{
				((Component)banquetCustomers[i].drinkColor).gameObject.SetActive(MDIKPGGBNLI);
			}
		}
	}

	public void BIJCFNDFAJJ(BanquetCustomer HADLCFDMGII)
	{
		ItemInstance itemInstance = BanquetDrinksManager.instance.FPBMBCMBHOP();
		if (itemInstance != null)
		{
			HADLCFDMGII.RequestTableOrder(itemInstance, BanquetRoundsManager.instance.JEPDCGINBJK());
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)HADLCFDMGII).transform);
		}
		else
		{
			Debug.LogError((object)("" + ((Object)((Component)HADLCFDMGII).gameObject).name));
		}
	}

	public void KHHHGOLDMCF(BanquetCustomer HADLCFDMGII)
	{
		tableOrders.Remove(HADLCFDMGII);
	}

	public static void FHKNKEEPKMA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	public static void PBJDMMEOMEA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BMBICELCHEP != null)
			{
				((MonoBehaviour)instance).StopCoroutine(instance.BMBICELCHEP);
			}
			instance.tableOrders.Clear();
		}
	}

	private void JOIMGFPMKNI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void KJLMALNHJIF()
	{
		if (WorldTime.BKIIKAGIHAK())
		{
			return;
		}
		List<BanquetCustomer> list = new List<BanquetCustomer>();
		for (int i = 0; i < banquetCustomers.Length; i += 0)
		{
			if (banquetCustomers[i].banquetCustomerState == BanquetCustomerState.EatingAtTable)
			{
				list.Add(banquetCustomers[i]);
			}
		}
		if (list.Count > 0)
		{
			BanquetCustomer banquetCustomer = list[Random.Range(1, list.Count)];
			if (Object.op_Implicit((Object)(object)banquetCustomer))
			{
				banquetCustomer.ChangeState((BanquetCustomerState)4);
			}
		}
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}
}
