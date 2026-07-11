using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AdoptionSignalManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NNAGLJLLLIB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdoptionSignalManager _003C_003E4__this;

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
		public NNAGLJLLLIB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			int num = _003C_003E1__state;
			AdoptionSignalManager adoptionSignalManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0029;
			case 1:
				_003C_003E1__state = -1;
				adoptionSignalManager.CustomerRequestAdoption();
				adoptionSignalManager.currentAdoptionRequestsToday++;
				goto IL_008e;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_0029;
				}
				IL_0029:
				if (adoptionSignalManager.currentAdoptionRequestsToday < adoptionSignalManager.maxAdoptionRequestsToday)
				{
					if (Random.Range(0, 100) < adoptionSignalManager.probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
					{
						_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(20, 50));
						_003C_003E1__state = 1;
						return true;
					}
					goto IL_008e;
				}
				adoptionSignalManager.EMLDBOAIADM = null;
				return false;
				IL_008e:
				_003C_003E2__current = CommonReferences.wait60;
				_003C_003E1__state = 2;
				return true;
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

	private static AdoptionSignalManager GGFJGHHHEJC;

	public int maxAdoptionRequestsPerDay = 3;

	public int maxAdoptionRequestsToday = 3;

	public int currentAdoptionRequestsToday;

	public int probabilityNewRequestPerHour = 50;

	private Coroutine EMLDBOAIADM;

	public int adoption;

	private IEnumerator EHBMDBNHIJG()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DAGGLALPNIM()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	private void NNMFLMJDKNH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private IEnumerator IIFDGEOACFL()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ANALJINIGCH()
	{
		while (currentAdoptionRequestsToday < maxAdoptionRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestAdoption();
				currentAdoptionRequestsToday++;
			}
			yield return CommonReferences.wait60;
		}
		EMLDBOAIADM = null;
	}

	public void MBMAOJNACAN()
	{
		CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime = Time.time + 42f;
		Customer customer = NPCRoadManager.CHCCNCNNELI();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState((CustomerState)(-41));
	}

	private IEnumerator EFPAHMJCJLD()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HEMAHKJEONA()
	{
		GGFJGHHHEJC = this;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OCHJEPFBJIF));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(IAOOGPMBAJG));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void ALGOBMNPLIB()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager LPADOMGFAIE()
	{
		return GGFJGHHHEJC;
	}

	private void EHBMONGBJFI()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(GENAABPGOHP));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(FICDFNDGPHO));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(NJAFHOCGBHG));
	}

	private void ALCJOABPBMA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DCOEEADJLIK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AJGLDLLIIFO()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(NKLAEFMJPDE));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(BCFKHDCGKCA));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(NGALPPCPLNN));
	}

	private void HMPHACKFPJA(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static AdoptionSignalManager FJBAFMJHBCO()
	{
		return GGFJGHHHEJC;
	}

	public void KJJKPJBBNDJ()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1744f;
		Customer customer = NPCRoadManager.SpawnRandomNPC();
		customer.customerType = CustomerType.Traveller;
		customer.ChangeState(CustomerState.Despawning, KCNFNAICINO: false);
	}

	public static AdoptionSignalManager GICPPAGFDPG()
	{
		return GGFJGHHHEJC;
	}

	private void DCGIIOONGAI(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void GCFIMFAJNDO(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void HLGCFHDLHON()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public void JGMIJDEMCKH()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1024f;
		Customer customer = NPCRoadManager.HFLIOBAFGBP();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState((CustomerState)(-4));
	}

	private void MFIEPGBABAM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NJAFHOCGBHG(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	public void AAPLBIEEHOE()
	{
		CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime = Time.time + 771f;
		Customer customer = NPCRoadManager.HHLLOLDEJAB();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState((CustomerState)(-39), KCNFNAICINO: false);
	}

	private void MINHJPAACDJ()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public void CustomerRequestAdoption()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1f;
		Customer customer = NPCRoadManager.SpawnRandomNPC();
		customer.customerType = CustomerType.Traveller;
		customer.ChangeState(CustomerState.Adoption);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OCPLOMJAFPC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JCCICALJDAF(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void ONEDJBMPCBH()
	{
		currentAdoptionRequestsToday = 1;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	private void JJMAPJMKKIJ(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private IEnumerator KJGPBCHANCE()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODNOMMKJOHC(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(DMLAIINMKLJ());
		}
	}

	private void FICDFNDGPHO(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(JEAOAHPEECB());
		}
	}

	private void AGNPLLDEFAO(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(CAPNMKKHJII());
		}
	}

	public void EFOMAIPLKLE()
	{
		CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime = Time.time + 1595f;
		Customer customer = NPCRoadManager.HHLLOLDEJAB();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState((CustomerState)(-2), KCNFNAICINO: false);
	}

	public void KLKIDHGJNOC()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1694f;
		Customer customer = NPCRoadManager.IENMNPMLAOL();
		customer.customerType = CustomerType.Traveller;
		customer.ChangeState((CustomerState)32);
	}

	private void FMHEGCBFJPJ()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	private void GENAABPGOHP()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void GONDLJKGLGO()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(JHLEIHABONO));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(HLDFGLIMPFJ));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(DPPJMCAJOJP));
	}

	public static AdoptionSignalManager CAJHNGGCJKM()
	{
		return GGFJGHHHEJC;
	}

	private void ALEAOANPHIO()
	{
		GGFJGHHHEJC = this;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(EJKIADFBMJO));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(JJMAPJMKKIJ));
	}

	private IEnumerator EONEPBPJFIL()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JEAOAHPEECB()
	{
		while (currentAdoptionRequestsToday < maxAdoptionRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestAdoption();
				currentAdoptionRequestsToday++;
			}
			yield return CommonReferences.wait60;
		}
		EMLDBOAIADM = null;
	}

	private void MKFIGDKGEKC(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void FAMBJKKLBMD(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void NKLAEFMJPDE()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	private void IAMJGJLOLNN()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager FPPDIEBDMNA()
	{
		return GGFJGHHHEJC;
	}

	private void GBKNIJENJEF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DPPJMCAJOJP(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OCHJEPFBJIF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(NGALPPCPLNN));
	}

	public static AdoptionSignalManager HHGEEDCALHK()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator CAPNMKKHJII()
	{
		while (currentAdoptionRequestsToday < maxAdoptionRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestAdoption();
				currentAdoptionRequestsToday++;
			}
			yield return CommonReferences.wait60;
		}
		EMLDBOAIADM = null;
	}

	private void BCFKHDCGKCA(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(IIFDGEOACFL());
		}
	}

	private void EJKIADFBMJO()
	{
		currentAdoptionRequestsToday = 1;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	private void GOJKOBEEMNA()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(PHNEEMAKGJP));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(AGNPLLDEFAO));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FPKBPINMIOG));
	}

	public static AdoptionSignalManager NOEBLLHOEOP()
	{
		return GGFJGHHHEJC;
	}

	private void IHICKHAABJH()
	{
		GGFJGHHHEJC = this;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DAGGLALPNIM));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(AGNPLLDEFAO));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public void MIEDHNPGFAP()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1784f;
		Customer customer = NPCRoadManager.SpawnRandomNPC();
		customer.customerType = CustomerType.Traveller;
		customer.ChangeState(CustomerState.EatingAtTable);
	}

	public void EIHBFKFJGHD()
	{
		CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime = Time.time + 272f;
		Customer customer = NPCRoadManager.IENMNPMLAOL();
		customer.customerType = CustomerType.Traveller;
		customer.ChangeState((CustomerState)(-32), KCNFNAICINO: false);
	}

	public static AdoptionSignalManager DNEGFMDKNHL()
	{
		return GGFJGHHHEJC;
	}

	public static AdoptionSignalManager OMEPPDMCFAO()
	{
		return GGFJGHHHEJC;
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void AENIKKJIHND(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void MMNBJPDJHGK()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(BHCJNHCGMCN));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(ODNOMMKJOHC));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(DPPJMCAJOJP));
	}

	private void NGALPPCPLNN(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	public void NHAKDCOBLIO()
	{
		CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime = Time.time + 1796f;
		Customer customer = NPCRoadManager.MAOIGEMGIAO();
		customer.customerType = CustomerType.Traveller;
		customer.ChangeState((CustomerState)(-95), KCNFNAICINO: false);
	}

	private void PEINGFGIJAB(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(BFOAPBCJMKN());
		}
	}

	private IEnumerator DMLAIINMKLJ()
	{
		while (currentAdoptionRequestsToday < maxAdoptionRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestAdoption();
				currentAdoptionRequestsToday++;
			}
			yield return CommonReferences.wait60;
		}
		EMLDBOAIADM = null;
	}

	private void KDJPAFHMNCN(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(EFPAHMJCJLD());
		}
	}

	private void PFAOIEEMEHA()
	{
		currentAdoptionRequestsToday = 1;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public void DHOLEOHFIHN()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 184f;
		Customer customer = NPCRoadManager.MAOIGEMGIAO();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState((CustomerState)(-90));
	}

	private void MLPAOEEILAL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static AdoptionSignalManager FFOMKKIAHKI()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator IGPOEKJCJDB()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KAMHCHPDMEF()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PJKNCIBFAFO()
	{
		currentAdoptionRequestsToday = 1;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager DJEINBKFBAM()
	{
		return GGFJGHHHEJC;
	}

	private void HLDFGLIMPFJ(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(EHBMDBNHIJG());
		}
	}

	private void JHLEIHABONO()
	{
		currentAdoptionRequestsToday = 1;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager MGAHKMKEOFJ()
	{
		return GGFJGHHHEJC;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void DADPOICMNPI()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ONEDJBMPCBH));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(AGNPLLDEFAO));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(JJMAPJMKKIJ));
	}

	public void GIMLJEMIKMD()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1181f;
		Customer customer = NPCRoadManager.PIIOHNMPOAB();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState((CustomerState)(-25), KCNFNAICINO: false);
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(CAPNMKKHJII());
		}
	}

	private void PHNJGHKBIIL()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(EJKIADFBMJO));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(HLDFGLIMPFJ));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private IEnumerator BFOAPBCJMKN()
	{
		return new NNAGLJLLLIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KMNIENHHPAH()
	{
		while (currentAdoptionRequestsToday < maxAdoptionRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestAdoption();
				currentAdoptionRequestsToday++;
			}
			yield return CommonReferences.wait60;
		}
		EMLDBOAIADM = null;
	}

	private void PHNEEMAKGJP()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager NIDNAAKOPFI()
	{
		return GGFJGHHHEJC;
	}

	public void CLMFFFEPPBO()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1640f;
		Customer customer = NPCRoadManager.EOCCCAKCNEM();
		customer.customerType = CustomerType.ImportantGuest;
		customer.ChangeState(CustomerState.Inactive);
	}

	private void IAOOGPMBAJG(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (EMLDBOAIADM != null)
			{
				((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
			}
			EMLDBOAIADM = ((MonoBehaviour)this).StartCoroutine(EFPAHMJCJLD());
		}
	}

	private void CLGBFOIBANN()
	{
		GGFJGHHHEJC = this;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NKLAEFMJPDE));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(BCFKHDCGKCA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(FPKBPINMIOG));
	}

	private void MFGANCCJFJK()
	{
		GGFJGHHHEJC = this;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(ODNOMMKJOHC));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(JCCICALJDAF));
	}

	private void FPKBPINMIOG(int JIIGOACEIKL)
	{
		if (EMLDBOAIADM != null)
		{
			((MonoBehaviour)this).StopCoroutine(EMLDBOAIADM);
		}
		EMLDBOAIADM = null;
	}

	private void OCHJEPFBJIF()
	{
		currentAdoptionRequestsToday = 1;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	private void BHCJNHCGMCN()
	{
		currentAdoptionRequestsToday = 0;
		maxAdoptionRequestsToday = maxAdoptionRequestsPerDay;
	}

	public static AdoptionSignalManager GDAEMIPHAHH()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator MBEKFFMLBOE()
	{
		while (currentAdoptionRequestsToday < maxAdoptionRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && AdoptionSignal.IsValid() && !AdoptionSignal.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestAdoption();
				currentAdoptionRequestsToday++;
			}
			yield return CommonReferences.wait60;
		}
		EMLDBOAIADM = null;
	}
}
