using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class Timer : MonoBehaviour
{
	[SerializeField]
	private GameDate dateFinished;

	public bool destoryOnDone;

	public bool pause;

	public ulong totalMinToFinish;

	public ulong dateStartedMin;

	[SerializeField]
	private GameObject progressorPrefab;

	[SerializeField]
	private GameObject progressorPosition;

	[HideInInspector]
	public Progressor progressor;

	public GameDate DGFFOHBELPL
	{
		get
		{
			return dateFinished;
		}
		set
		{
			SetUpTimer(value, WorldTime.HMOCOBGKMNJ);
		}
	}

	public event Action DHAHIIPHFPB = delegate
	{
	};

	public void UpdateTimer()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.BHGJPBGINCG != 1f)
			{
				if (!pause)
				{
					progressor.BHGJPBGINCG = GetProgressValue();
				}
				if (progressor.BHGJPBGINCG == 1f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void HDHALAEHNLM(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.BDEKNPKCJHN(LHBHOPKNBHM) - HHLEOPBICJK;
		InstantiateNewTimer();
		FFFEGFJMGPP();
	}

	public void LKGJDHMPJLG()
	{
		dateStartedMin = 0uL;
		totalMinToFinish = 1uL;
		progressor.PIDPOCCIFOK(876f);
	}

	[SpecialName]
	public void GFOPLIOOCHD(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void LHBFPODFCLA()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.MOIECMGIGIP(1332f);
		((Behaviour)progressor).enabled = false;
	}

	[SpecialName]
	public void IBCJADOBLMH(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public GameDate LOGMNHECKGP()
	{
		return dateFinished;
	}

	[SpecialName]
	public void AGLDAKOJFAE(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void InstantiateNewTimer()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		EndTimer();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	private void FINKPIHPHDE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(LFEOCFFOGIE));
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NABKHBDOMIH));
			}
		}
	}

	public void AAHMGIEAKPH()
	{
		dateStartedMin = 1uL;
		totalMinToFinish = 1uL;
		progressor.FOLMDNFLBOE(250f);
	}

	public void COJFNNABPAI()
	{
		dateStartedMin = 1uL;
		totalMinToFinish = 0uL;
		progressor.NIPNGHKNIGN(65f);
	}

	private void CIIBBCPIOIP()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(BHHMPGBLJFI));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JPOPPNNJMHE));
	}

	[SpecialName]
	public GameDate EKNAEPDKBLJ()
	{
		return dateFinished;
	}

	private void IILOKDBOODL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(BHHMPGBLJFI));
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(JPOPPNNJMHE));
			}
		}
	}

	private void HCKMHIHALBL()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(PGGPLGJIKND));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	public void NDEDFDPLHBK()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		CHEGEMJJMFJ();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	public void PPAPLOIFLIA(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.DAFIFHBDNDF(LHBHOPKNBHM) - HHLEOPBICJK;
		AIBACCNJEFJ();
		UpdateTimer();
	}

	[SpecialName]
	public GameDate PBHOMOCJCHJ()
	{
		return dateFinished;
	}

	[SpecialName]
	public void KPKNFDMMAJP(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void EGMFJLAAAJC(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.JNBDOMFDJEH(LHBHOPKNBHM) - HHLEOPBICJK;
		AIBACCNJEFJ();
		FBKIIGGGNDH();
	}

	public void KBOOPLMAADD()
	{
		progressor.OHNGIDACMMM(200f);
		dateStartedMin = 0uL;
		totalMinToFinish = 0uL;
		((Behaviour)progressor).enabled = true;
	}

	public void KCAJCCIKDKG()
	{
		dateStartedMin = 1uL;
		totalMinToFinish = 0uL;
		progressor.KLHFMOPHNBM(974f);
	}

	[SpecialName]
	public void IPHDFAEIKLH(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void EJFJOIDIODL()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		CPOIPMOIAMD();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			UpdateTimer();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void MBJJEJPPFBD()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	[SpecialName]
	public GameDate EHJOJAFEANC()
	{
		return dateFinished;
	}

	public void FFFEGFJMGPP()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.FOLDHLBEICH() != 844f)
			{
				if (!pause)
				{
					progressor.BPPMDMLMGPN(KBGLOOHHODF());
				}
				if (progressor.PHJPPHNMBHN() == 1565f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void EHJJOCPAGKM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.IBNCJLJDMGH(1514f);
		((Behaviour)progressor).enabled = true;
	}

	[SpecialName]
	public GameDate IGMCFHODGPM()
	{
		return dateFinished;
	}

	public void LFANKOFOLIM(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.JNBDOMFDJEH(LHBHOPKNBHM) - HHLEOPBICJK;
		LFOPJDLOIIO();
		FBKIIGGGNDH();
	}

	public void EFHOMEFBCCD()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.PIDPOCCIFOK(192f);
		((Behaviour)progressor).enabled = false;
	}

	[SpecialName]
	public void PFJFGBPECAG(GameDate AODONKKHPBP)
	{
		GCNCMFHCLBA(AODONKKHPBP, WorldTime.JMLDELMPDMH());
	}

	public void EGCLBBPNKLP()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	[SpecialName]
	public void BNDGLPHMJGJ(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	private void OHIMJBJOGHI()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(BHHMPGBLJFI));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	public void AGJNDIODJPI()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.CLDDFMGPEPM(1878f);
		((Behaviour)progressor).enabled = true;
	}

	public void LFEOCFFOGIE()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.KJKPPHJJOKK() != 1680f)
			{
				if (!pause)
				{
					progressor.JJDKOIOIADG(ONLGPFBKFIE());
				}
				if (progressor.LGMMMHGJLNF() == 1619f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void MAHONNCPNPE()
	{
		progressor.LKMMANDAGDJ(452f);
		dateStartedMin = 1uL;
		totalMinToFinish = 1uL;
		((Behaviour)progressor).enabled = false;
	}

	public float ONLGPFBKFIE()
	{
		if (totalMinToFinish != 0L)
		{
			return (float)(WorldTime.HMOCOBGKMNJ - dateStartedMin) / (float)totalMinToFinish;
		}
		return 900f;
	}

	public void GCNCMFHCLBA(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.ALJFLADELOD(LHBHOPKNBHM) - HHLEOPBICJK;
		NDEDFDPLHBK();
		FCAHMCDMAPM();
	}

	private void FEMMGHPCOBI()
	{
		try
		{
			PGGPLGJIKND();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void EIPDLBEBFNJ(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.DAFIFHBDNDF(LHBHOPKNBHM) - HHLEOPBICJK;
		PHFBFIJDAKE();
		FFFEGFJMGPP();
	}

	public float OMFAGCGKEIH()
	{
		if (totalMinToFinish != 0L)
		{
			return (float)(WorldTime.JOBFPNANHDK() - dateStartedMin) / (float)totalMinToFinish;
		}
		return 28f;
	}

	private void HIFDFFEJNEH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(FCAHMCDMAPM));
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(OCBADIFBBDM));
			}
		}
	}

	public void SetUpTimer(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.GGNGGLHBMNA(LHBHOPKNBHM) - HHLEOPBICJK;
		InstantiateNewTimer();
		UpdateTimer();
	}

	[SpecialName]
	public void CCKEBOAKCFK(GameDate AODONKKHPBP)
	{
		EIPDLBEBFNJ(AODONKKHPBP, WorldTime.PLBFKLOOBCD());
	}

	[SpecialName]
	public void GKFBHIMPEPH(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	private void DAGGLALPNIM()
	{
		try
		{
			FBKIIGGGNDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void HLKNBADMMIA()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		EGCLBBPNKLP();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	[SpecialName]
	public GameDate MCPHKAEHAHM()
	{
		return dateFinished;
	}

	[SpecialName]
	public GameDate FIEGGCAJEIG()
	{
		return dateFinished;
	}

	[SpecialName]
	public void OKDALNMNCKM(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public float GetProgressValue()
	{
		if (totalMinToFinish != 0L)
		{
			return (float)(WorldTime.HMOCOBGKMNJ - dateStartedMin) / (float)totalMinToFinish;
		}
		return 1f;
	}

	public void PHFBFIJDAKE()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		CPOIPMOIAMD();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	[SpecialName]
	public void MBGGFCCEIPO(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			DLLLKGILJMP();
		}
	}

	public void OCLJIGJINAN()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(UpdateTimer));
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
		}
	}

	private void ANLHPMPMBFM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(BHHMPGBLJFI));
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
			}
		}
	}

	[SpecialName]
	public void AGDOODLHPJE(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void FBKIIGGGNDH()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.CMGEJDGIIIB() != 941f)
			{
				if (!pause)
				{
					progressor.AKLMBMNEBOG(CICJNEIPFOL());
				}
				if (progressor.PLLKABPFNIP() == 246f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public float NOIHJFMOFFG()
	{
		if (totalMinToFinish != 0L)
		{
			return (float)(WorldTime.HMOCOBGKMNJ - dateStartedMin) / (float)totalMinToFinish;
		}
		return 1367f;
	}

	private void IGBEKHCLKFD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CHEGEMJJMFJ();
		}
	}

	[SpecialName]
	public void CCIDELHJPGM(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void FinishTimer()
	{
		dateStartedMin = 0uL;
		totalMinToFinish = 1uL;
		progressor.BHGJPBGINCG = 1f;
	}

	private void ICKIAOEOHDJ()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(UpdateTimer));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DAGGLALPNIM));
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			ABDDFHCMEOO();
		}
	}

	public void EndTimer()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	public void OGJGPIPDFBB()
	{
		dateStartedMin = 0uL;
		totalMinToFinish = 0uL;
		progressor.DCOALEBFLEG(107f);
	}

	private void OCBADIFBBDM()
	{
		try
		{
			LFEOCFFOGIE();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void HLHHDNGOGNI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			OCLJIGJINAN();
		}
	}

	public void AIBACCNJEFJ()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		ABDDFHCMEOO();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	public void AKGKDFEPFNG()
	{
		progressor.DHJOICOCIHJ(982f);
		dateStartedMin = 0uL;
		totalMinToFinish = 1uL;
		((Behaviour)progressor).enabled = false;
	}

	public void PGGPLGJIKND()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.MONKBKIDAHA() != 1461f)
			{
				if (!pause)
				{
					progressor.CLEMOMEPLID(KBGLOOHHODF());
				}
				if (progressor.BFIKINCPIJM() == 1708f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	[SpecialName]
	public GameDate LANHPNNPBNP()
	{
		return dateFinished;
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CHEGEMJJMFJ();
		}
	}

	[SpecialName]
	public void BMEAHEPGLON(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void LPCINNGEOPJ()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.IBNCJLJDMGH(134f);
		((Behaviour)progressor).enabled = true;
	}

	public void FNCPIHJBJFK(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.DAFIFHBDNDF(LHBHOPKNBHM) - HHLEOPBICJK;
		InstantiateNewTimer();
		NCJIHBHHICJ();
	}

	[SpecialName]
	public GameDate IAHOPIPPKDN()
	{
		return dateFinished;
	}

	[SpecialName]
	public void GGFHBJFIDKI(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	private void JPOPPNNJMHE()
	{
		try
		{
			BHHMPGBLJFI();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	[SpecialName]
	public void HMINNFNNLKK(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void BAGLIMENELB()
	{
		dateStartedMin = 1uL;
		totalMinToFinish = 1uL;
		progressor.AOFGDOBJMHP(1864f);
	}

	private void HEMHHGCBEKO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(FBKIIGGGNDH));
			if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NABKHBDOMIH));
			}
		}
	}

	public void LFOPJDLOIIO()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		EGCLBBPNKLP();
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
	}

	private void IANGDMHMCEL()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(FFFEGFJMGPP));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NABKHBDOMIH));
	}

	[SpecialName]
	public void EEILAGLEKJD(GameDate AODONKKHPBP)
	{
		EIPDLBEBFNJ(AODONKKHPBP, WorldTime.PLBFKLOOBCD());
	}

	private void IAPAKPNFAJF()
	{
		try
		{
			FBKIIGGGNDH();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void NCJIHBHHICJ()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.FOLDHLBEICH() != 1233f)
			{
				if (!pause)
				{
					progressor.HADLIKGKHOK(CICJNEIPFOL());
				}
				if (progressor.GBEHCBKGKHL() == 309f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void MEAKJFEPKHF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			EGCLBBPNKLP();
		}
	}

	public void DLLLKGILJMP()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	[SpecialName]
	public void AHNILFGHION(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void OGJBIBNMJLM()
	{
		dateStartedMin = 1uL;
		totalMinToFinish = 0uL;
		progressor.CLAENEBEIMH(608f);
	}

	public void FCAHMCDMAPM()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.AMPEOCDAHLE() != 1416f)
			{
				if (!pause)
				{
					progressor.DCOALEBFLEG(CICJNEIPFOL());
				}
				if (progressor.DMEGPGOMFNN() == 359f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void SetEndStateTimer()
	{
		progressor.BHGJPBGINCG = 1f;
		dateStartedMin = 0uL;
		totalMinToFinish = 0uL;
		((Behaviour)progressor).enabled = false;
	}

	public void BHHMPGBLJFI()
	{
		try
		{
			if (!((Object)(object)progressor == (Object)null) && progressor.AMPEOCDAHLE() != 1779f)
			{
				if (!pause)
				{
					progressor.GILHMDPDMPA(OMFAGCGKEIH());
				}
				if (progressor.OBCNBELKPHL() == 75f)
				{
					this.DHAHIIPHFPB();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void ABDDFHCMEOO()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	public void CDCDNEEBMFB(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.IAAIHAFKOKL(LHBHOPKNBHM) - HHLEOPBICJK;
		AIBACCNJEFJ();
		PGGPLGJIKND();
	}

	public void OJOOEHANAGC(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.HJCLEBDPLOP(LHBHOPKNBHM) - HHLEOPBICJK;
		AIBACCNJEFJ();
		FBKIIGGGNDH();
	}

	public void InstantiateEndStateTimer()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.BHGJPBGINCG = 1f;
		((Behaviour)progressor).enabled = false;
	}

	private void OnEnable()
	{
		WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(UpdateTimer));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	[SpecialName]
	public void HDJHCHFBAOG(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Remove(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public void CPOIPMOIAMD()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	private void AMBKBOBDAIF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			CHEGEMJJMFJ();
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			EndTimer();
		}
	}

	public void FCAFLNOLHDK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = progressorPrefab;
		Vector3 val;
		if (!((Object)(object)progressorPosition == (Object)null))
		{
			val = Utils.BMBMPKNANAC(progressorPosition.transform.position);
		}
		else
		{
			Bounds bounds = ((Renderer)((Component)this).GetComponent<SpriteRenderer>()).bounds;
			val = Utils.BMBMPKNANAC(((Bounds)(ref bounds)).center);
		}
		progressor = Object.Instantiate<GameObject>(obj, val, Quaternion.identity).GetComponent<Progressor>();
		progressor.MCCIGMPHBOF(957f);
		((Behaviour)progressor).enabled = true;
	}

	public void DOFJGJEDBCL()
	{
		progressor.DCOALEBFLEG(323f);
		dateStartedMin = 0uL;
		totalMinToFinish = 0uL;
		((Behaviour)progressor).enabled = true;
	}

	public void MBCKNOLNAIM()
	{
		dateStartedMin = 0uL;
		totalMinToFinish = 0uL;
		progressor.NIPNGHKNIGN(1869f);
	}

	public void IKHCKDJGEMN(GameDate LHBHOPKNBHM, ulong HHLEOPBICJK)
	{
		dateFinished = LHBHOPKNBHM;
		dateStartedMin = HHLEOPBICJK;
		totalMinToFinish = GameDate.IAAIHAFKOKL(LHBHOPKNBHM) - HHLEOPBICJK;
		EJFJOIDIODL();
		NCJIHBHHICJ();
	}

	public void CHEGEMJJMFJ()
	{
		if (Object.op_Implicit((Object)(object)progressor) && (Object)(object)((Component)progressor).gameObject != (Object)null)
		{
			Utils.BLPDAEHPOBA(((Component)progressor).gameObject);
		}
		progressor = null;
	}

	private void NABKHBDOMIH()
	{
		try
		{
			UpdateTimer();
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	[SpecialName]
	public void IOKEFNGNDFL(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}

	public float KBGLOOHHODF()
	{
		if (totalMinToFinish != 0L)
		{
			return (float)(WorldTime.JOBFPNANHDK() - dateStartedMin) / (float)totalMinToFinish;
		}
		return 1279f;
	}

	public float CICJNEIPFOL()
	{
		if (totalMinToFinish != 0L)
		{
			return (float)(WorldTime.JOBFPNANHDK() - dateStartedMin) / (float)totalMinToFinish;
		}
		return 779f;
	}

	[SpecialName]
	public void GMHIPAFCEIN(GameDate AODONKKHPBP)
	{
		SetUpTimer(AODONKKHPBP, WorldTime.PLBFKLOOBCD());
	}

	[SpecialName]
	public void EBLALDIIOGG(Action AODONKKHPBP)
	{
		Action action = this.DHAHIIPHFPB;
		Action action2;
		do
		{
			action2 = action;
			Action value = (Action)Delegate.Combine(action2, AODONKKHPBP);
			action = Interlocked.CompareExchange(ref this.DHAHIIPHFPB, value, action2);
		}
		while ((object)action != action2);
	}
}
