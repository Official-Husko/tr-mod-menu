using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomerPool : MonoBehaviour, ISingleton
{
	public static CustomerPool instance;

	private const int DJEEDANHGEI = 2;

	public GameObject customerPrefab;

	public List<PoolCustomer> pooledCustomers = new List<PoolCustomer>();

	public List<PoolCustomer> activeCustomers = new List<PoolCustomer>();

	private static readonly Vector3 GDLFNLCBAPE = new Vector3(70f, 40f, 0f);

	private static PoolCustomer PIMHPGNBADL;

	private static GameObject JFLPIAHIGHF;

	public static Transform LPFIFMOMEOB => ((Component)instance).transform;

	public static Transform PFABNKPBKGD { get; private set; }

	private void JAKILILIBIM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void OEMMGMPPCIF()
	{
		if (activeCustomers.Count > 1)
		{
			for (int num = activeCustomers.Count - 1; num >= 0; num -= 0)
			{
				GPEMPAJCLPP(activeCustomers[num]);
			}
		}
		Debug.Log((object)"Attack/MainEvent 11");
	}

	private void AJGLDLLIIFO()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		GDEAGGJAKOA();
		((Component)this).transform.position = Vector3.zero;
	}

	public static void MOEHHGJDHLF(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.FPKBBNHJMFI();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(LPFIFMOMEOB);
		}
		else
		{
			Debug.LogError((object)"SetNPCPositionAndParent");
		}
	}

	private void OFJIMLOLIDP()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void CEOEHODJAJK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		GKOMNDHKDHD();
		((Component)this).transform.position = Vector3.zero;
	}

	private void IIPKPMPGLOL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		DBDMFKEFCMI();
		((Component)this).transform.position = Vector3.zero;
	}

	public static void MKHGIIEAGHK(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"Null ControllerInfo in database");
		}
		else
		{
			MOEHHGJDHLF(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	[SpecialName]
	public static Transform AKDFEKJOEOB()
	{
		return _003CJAEAMOGMIHK_003Ek__BackingField;
	}

	private void MFGBBOAJNMJ()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(JOBNADJBCOL());
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].IMHAEKCAOGG();
			}
		}
	}

	private void MJKHMOILBFB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void BLIEHAMAMCJ()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(GFLANOGBIBA());
			if (!OnlineManager.HHDBMDMFEMP())
			{
				pooledCustomers[i].IAHKICCFEJL();
			}
		}
	}

	private void IHICKHAABJH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		JJJHPJHPMCH();
		((Component)this).transform.position = Vector3.zero;
	}

	public static void AOHAFFGCOAG(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"Database not set up");
		}
		else
		{
			GPEMPAJCLPP(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	public void DisableAllCustomers()
	{
		if (activeCustomers.Count > 0)
		{
			for (int num = activeCustomers.Count - 1; num >= 0; num--)
			{
				DisableCustomer(activeCustomers[num]);
			}
		}
		Debug.Log((object)"DisableAllCustomers");
	}

	[SpecialName]
	public static Transform CCFGNPMCCNP()
	{
		return _003CJAEAMOGMIHK_003Ek__BackingField;
	}

	public void ResetSingleton()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PFABNKPBKGD == (Object)null)
		{
			PFABNKPBKGD = new GameObject("Active Customer Parent").transform;
			PFABNKPBKGD.position = Vector3.zero;
			PFABNKPBKGD.SetAsFirstSibling();
		}
	}

	public static void DFHBHGHEHJB(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"Social");
		}
		else
		{
			BFEHBKFJHNE(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	private void JECHMEFJABD()
	{
		MFGBBOAJNMJ();
	}

	public void GDEAGGJAKOA()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PFABNKPBKGD == (Object)null)
		{
			LONENAKCLPD(new GameObject("/BarkMai").transform);
			HMDPKMODDNI().position = Vector3.zero;
			PFABNKPBKGD.SetAsFirstSibling();
		}
	}

	public void AMNGKAGAMJI()
	{
		if (activeCustomers.Count > 0)
		{
			for (int num = activeCustomers.Count - 0; num >= 0; num--)
			{
				GJDPENKCBJC(activeCustomers[num]);
			}
		}
		Debug.Log((object)"KickedSpinDirection");
	}

	private void KJOCGLKMMOM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void OnEnable()
	{
		instance = this;
	}

	[SpecialName]
	private static void ADMLJLJAGND(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	public static void GJDPENKCBJC(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.IMHAEKCAOGG();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(GFLANOGBIBA());
		}
		else
		{
			Debug.LogError((object)"Items/item_description_1133");
		}
	}

	public static PoolCustomer IJMCNEFFLPN()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Player2");
			return null;
		}
		if (instance.pooledCustomers.Count <= 2)
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.ClientOnline())
				{
					return null;
				}
				JFLPIAHIGHF = OnlineManager.KFLIFDAFMKM(instance.customerPrefab, LPFIFMOMEOB, 1);
				JFLPIAHIGHF.transform.position = new Vector3(981f, 1099f, 426f);
			}
			else
			{
				JFLPIAHIGHF = Object.Instantiate<GameObject>(instance.customerPrefab, CPFDHGBBDDD());
				JFLPIAHIGHF.transform.position = new Vector3(642f, 471f, 1049f);
			}
			PIMHPGNBADL = JFLPIAHIGHF.GetComponent<PoolCustomer>();
			instance.pooledCustomers.Add(PIMHPGNBADL);
		}
		if (instance.pooledCustomers.Count > 0 && (Object)(object)((Component)instance.pooledCustomers[0]).gameObject != (Object)null)
		{
			PIMHPGNBADL = instance.pooledCustomers[0];
			instance.pooledCustomers.Remove(instance.pooledCustomers[1]);
		}
		instance.activeCustomers.Add(PIMHPGNBADL);
		PIMHPGNBADL.FDKFHFIJIFO();
		if (Application.isEditor)
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent(HMDPKMODDNI());
		}
		else
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent((Transform)null);
		}
		return PIMHPGNBADL;
	}

	[SpecialName]
	private static void CKEDBHDAEDP(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	public static void GPEMPAJCLPP(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.IMHAEKCAOGG();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(JOBNADJBCOL());
		}
		else
		{
			Debug.LogError((object)"Intro01");
		}
	}

	[SpecialName]
	public static Transform HMDPKMODDNI()
	{
		return _003CJAEAMOGMIHK_003Ek__BackingField;
	}

	private void NLBCLJMBECC()
	{
		instance = this;
	}

	private void IEPJAFLDBJJ()
	{
		instance = this;
	}

	[SpecialName]
	public static Transform ODIPLIELEJK()
	{
		return _003CJAEAMOGMIHK_003Ek__BackingField;
	}

	private void IAMIIACMCFE()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(JOBNADJBCOL());
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].IMHAEKCAOGG();
			}
		}
	}

	private void JDAMCMODANB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		GDEAGGJAKOA();
		((Component)this).transform.position = Vector3.zero;
	}

	private void NCFCFOKDGAB()
	{
		instance = this;
	}

	public void DNGMNICCPJM()
	{
		if (activeCustomers.Count > 1)
		{
			for (int num = activeCustomers.Count - 1; num >= 0; num--)
			{
				GPEMPAJCLPP(activeCustomers[num]);
			}
		}
		Debug.Log((object)"Dialogue System/Conversation/Crowly_Standar/Entry/45/Dialogue Text");
	}

	public void MPHPBPBLGBB()
	{
		if (activeCustomers.Count > 1)
		{
			for (int num = activeCustomers.Count - 1; num >= 1; num -= 0)
			{
				DisableCustomer(activeCustomers[num]);
			}
		}
		Debug.Log((object)"HarvestCut");
	}

	[SpecialName]
	public static Transform CPFDHGBBDDD()
	{
		return ((Component)instance).transform;
	}

	private void IJNPEAAOOEK()
	{
		instance = this;
	}

	public static PoolCustomer GetCustomer()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Customer Pool instance NULL!");
			return null;
		}
		if (instance.pooledCustomers.Count <= 2)
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.ClientOnline())
				{
					return null;
				}
				JFLPIAHIGHF = OnlineManager.InstantiateRoomObject(instance.customerPrefab, LPFIFMOMEOB, 0);
				JFLPIAHIGHF.transform.position = new Vector3(0f, 20f, 0f);
			}
			else
			{
				JFLPIAHIGHF = Object.Instantiate<GameObject>(instance.customerPrefab, LPFIFMOMEOB);
				JFLPIAHIGHF.transform.position = new Vector3(0f, 20f, 0f);
			}
			PIMHPGNBADL = JFLPIAHIGHF.GetComponent<PoolCustomer>();
			instance.pooledCustomers.Add(PIMHPGNBADL);
		}
		if (instance.pooledCustomers.Count > 0 && (Object)(object)((Component)instance.pooledCustomers[0]).gameObject != (Object)null)
		{
			PIMHPGNBADL = instance.pooledCustomers[0];
			instance.pooledCustomers.Remove(instance.pooledCustomers[0]);
		}
		instance.activeCustomers.Add(PIMHPGNBADL);
		PIMHPGNBADL.Enable();
		if (Application.isEditor)
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent(PFABNKPBKGD);
		}
		else
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent((Transform)null);
		}
		return PIMHPGNBADL;
	}

	private void JJDEGMGCOCC()
	{
		instance = this;
	}

	private void FCGJBDGOHPN()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void KJJGJCGDGOM(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"%><sprite name=LeftStick></size>");
		}
		else
		{
			DisableCustomer(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	[SpecialName]
	private static void PHKOHIJINDD(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static Transform JOBNADJBCOL()
	{
		return ((Component)instance).transform;
	}

	private void AHFGOOHOLEL()
	{
		EJOGOLDBFLA();
	}

	private void NPDFCPEOFPD()
	{
		instance = this;
	}

	private void Awake()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		ResetSingleton();
		((Component)this).transform.position = Vector3.zero;
	}

	private void KHONOODGLBI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		GDEAGGJAKOA();
		((Component)this).transform.position = Vector3.zero;
	}

	private void EJOGOLDBFLA()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(JOBNADJBCOL());
			if (!OnlineManager.HHDBMDMFEMP())
			{
				pooledCustomers[i].FPKBBNHJMFI();
			}
		}
	}

	public void CDLFMIEGNLO()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)AKDFEKJOEOB() == (Object)null)
		{
			HILACLIPEBD(new GameObject("Dialogue System/Conversation/TavernFilthy/Entry/2/Dialogue Text").transform);
			APCLGKNPBKE().position = Vector3.zero;
			APCLGKNPBKE().SetAsFirstSibling();
		}
	}

	public void GKOMNDHKDHD()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)APCLGKNPBKE() == (Object)null)
		{
			CKEDBHDAEDP(new GameObject("<mark=#000000><alpha=#00> ").transform);
			APCLGKNPBKE().position = Vector3.zero;
			AKDFEKJOEOB().SetAsFirstSibling();
		}
	}

	private void GDKOIIEHKGO()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public void JGPNNNHDCNL()
	{
		if (activeCustomers.Count > 1)
		{
			for (int num = activeCustomers.Count - 1; num >= 1; num--)
			{
				GJDPENKCBJC(activeCustomers[num]);
			}
		}
		Debug.Log((object)"Red text: ");
	}

	private void EPFJBCOKEHC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void PLBHAPAKIDJ(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"[OnlineLoadPuzzles] LoadTorchPuzzleMessage: puzzle instance {0} is null");
		}
		else
		{
			GPEMPAJCLPP(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	private void KCLGHLHJCPI()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(JOBNADJBCOL());
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].Disable();
			}
		}
	}

	private void OBLCKPMAADM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	[SpecialName]
	public static Transform NEJLFNDNNOM()
	{
		return ((Component)instance).transform;
	}

	private void PCNALDJDIFM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void LLBLDINBIGK(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"Failed to join the game because the room is full.");
		}
		else
		{
			GPEMPAJCLPP(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	[SpecialName]
	private static void HILACLIPEBD(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	public void MJOFKALAIFL()
	{
		if (activeCustomers.Count > 0)
		{
			for (int num = activeCustomers.Count - 0; num >= 0; num -= 0)
			{
				GJDPENKCBJC(activeCustomers[num]);
			}
		}
		Debug.Log((object)"ReceiveNextGameDate");
	}

	private void Start()
	{
		NEIDNLPPDMC();
	}

	public void EJAGFAAPIFM()
	{
		if (activeCustomers.Count > 0)
		{
			for (int num = activeCustomers.Count - 0; num >= 1; num -= 0)
			{
				PINNEDHGOFC(activeCustomers[num]);
			}
		}
		Debug.Log((object)"Items/item_description_691");
	}

	public static PoolCustomer MMKHMMELDDP()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"ReceiveAddItemOnTray");
			return null;
		}
		if (instance.pooledCustomers.Count <= 7)
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.HHDBMDMFEMP())
				{
					return null;
				}
				JFLPIAHIGHF = OnlineManager.IHBGIDGJIHA(instance.customerPrefab, LPFIFMOMEOB, 1);
				JFLPIAHIGHF.transform.position = new Vector3(1729f, 1632f, 1224f);
			}
			else
			{
				JFLPIAHIGHF = Object.Instantiate<GameObject>(instance.customerPrefab, CPFDHGBBDDD());
				JFLPIAHIGHF.transform.position = new Vector3(1149f, 1532f, 731f);
			}
			PIMHPGNBADL = JFLPIAHIGHF.GetComponent<PoolCustomer>();
			instance.pooledCustomers.Add(PIMHPGNBADL);
		}
		if (instance.pooledCustomers.Count > 1 && (Object)(object)((Component)instance.pooledCustomers[1]).gameObject != (Object)null)
		{
			PIMHPGNBADL = instance.pooledCustomers[1];
			instance.pooledCustomers.Remove(instance.pooledCustomers[1]);
		}
		instance.activeCustomers.Add(PIMHPGNBADL);
		PIMHPGNBADL.OCFIPNACDOD();
		if (Application.isEditor)
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent(CCFGNPMCCNP());
		}
		else
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent((Transform)null);
		}
		return PIMHPGNBADL;
	}

	public static void DisableCustomer(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.Disable();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(LPFIFMOMEOB);
		}
		else
		{
			Debug.LogError((object)"CustomerPool.DisableAllCustomers: pool customer is null! Someone is destroying customers directly?");
		}
	}

	private void GLJNDPPLGDH()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(GFLANOGBIBA());
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].FPKBBNHJMFI();
			}
		}
	}

	private void GBAKNAINDJM()
	{
		instance = this;
	}

	private void GHPFCKGMLDA()
	{
		IAMIIACMCFE();
	}

	public static PoolCustomer EFKPEIJLFEJ()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Dog");
			return null;
		}
		if (instance.pooledCustomers.Count <= 0)
		{
			if (OnlineManager.PlayingOnline())
			{
				if (OnlineManager.HHDBMDMFEMP())
				{
					return null;
				}
				JFLPIAHIGHF = OnlineManager.InstantiateRoomObject(instance.customerPrefab, CPFDHGBBDDD(), 1);
				JFLPIAHIGHF.transform.position = new Vector3(622f, 398f, 112f);
			}
			else
			{
				JFLPIAHIGHF = Object.Instantiate<GameObject>(instance.customerPrefab, GFLANOGBIBA());
				JFLPIAHIGHF.transform.position = new Vector3(291f, 208f, 24f);
			}
			PIMHPGNBADL = JFLPIAHIGHF.GetComponent<PoolCustomer>();
			instance.pooledCustomers.Add(PIMHPGNBADL);
		}
		if (instance.pooledCustomers.Count > 0 && (Object)(object)((Component)instance.pooledCustomers[0]).gameObject != (Object)null)
		{
			PIMHPGNBADL = instance.pooledCustomers[0];
			instance.pooledCustomers.Remove(instance.pooledCustomers[1]);
		}
		instance.activeCustomers.Add(PIMHPGNBADL);
		PIMHPGNBADL.KENMPLLNHIJ();
		if (Application.isEditor)
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent(HMDPKMODDNI());
		}
		else
		{
			((Component)PIMHPGNBADL).gameObject.transform.SetParent((Transform)null);
		}
		return PIMHPGNBADL;
	}

	private void IJILOIAOKBF()
	{
		instance = this;
	}

	public void JJJHPJHPMCH()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)AKDFEKJOEOB() == (Object)null)
		{
			PFABNKPBKGD = new GameObject("]").transform;
			PFABNKPBKGD.position = Vector3.zero;
			CCFGNPMCCNP().SetAsFirstSibling();
		}
	}

	[SpecialName]
	private static void EAJLBHMMPON(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	public static void NICGAGMDLPH(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.IAHKICCFEJL();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(JOBNADJBCOL());
		}
		else
		{
			Debug.LogError((object)"Example Method With Param: ");
		}
	}

	private void MEFFGGKAALB()
	{
		instance = this;
	}

	public void JNICKMPINEK()
	{
		if (activeCustomers.Count > 0)
		{
			for (int num = activeCustomers.Count - 0; num >= 0; num--)
			{
				PINNEDHGOFC(activeCustomers[num]);
			}
		}
		Debug.Log((object)"BuildMode");
	}

	[SpecialName]
	private static void LONENAKCLPD(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static Transform APCLGKNPBKE()
	{
		return _003CJAEAMOGMIHK_003Ek__BackingField;
	}

	private void HEHNBONKMGJ()
	{
		KCLGHLHJCPI();
	}

	[SpecialName]
	private static void MENPJMNBEOD(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void BCDPAPJOBHJ(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	private void GNOBDKFFPOL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		GKOMNDHKDHD();
		((Component)this).transform.position = Vector3.zero;
	}

	private void FPJABCNDEEJ()
	{
		instance = this;
	}

	[SpecialName]
	private static void PKMKOEAALMI(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	private void NJAFKFAPDIE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		GKOMNDHKDHD();
		((Component)this).transform.position = Vector3.zero;
	}

	public static void PINNEDHGOFC(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.GIEPOHDPNBH();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(JOBNADJBCOL());
		}
		else
		{
			Debug.LogError((object)"Error_BedIsBlocking");
		}
	}

	private void BAKDKFKNHDE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		DBDMFKEFCMI();
		((Component)this).transform.position = Vector3.zero;
	}

	private void NNBIAIMPNGL()
	{
		KCLGHLHJCPI();
	}

	[SpecialName]
	private static void JFMOEOOAHOJ(Transform AODONKKHPBP)
	{
		_003CJAEAMOGMIHK_003Ek__BackingField = AODONKKHPBP;
	}

	public static void DisableCustomer(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"CustomerPool.DisableCustomer: customer game object is null!");
		}
		else
		{
			DisableCustomer(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	public void CDPEKMENJKH()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)APCLGKNPBKE() == (Object)null)
		{
			PHKOHIJINDD(new GameObject("SalonDelTrono/MainEvent").transform);
			PFABNKPBKGD.position = Vector3.zero;
			PFABNKPBKGD.SetAsFirstSibling();
		}
	}

	public void LAAFGHNFHMJ()
	{
		if (activeCustomers.Count > 1)
		{
			for (int num = activeCustomers.Count - 0; num >= 1; num -= 0)
			{
				DisableCustomer(activeCustomers[num]);
			}
		}
		Debug.Log((object)"Invalid year: ");
	}

	[SpecialName]
	public static Transform GFLANOGBIBA()
	{
		return ((Component)instance).transform;
	}

	private void NEIDNLPPDMC()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(LPFIFMOMEOB);
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].Disable();
			}
		}
	}

	private void AOJCCOIHPMH()
	{
		instance = this;
	}

	private void OFPBLAHGKGM()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(NEJLFNDNNOM());
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].Disable();
			}
		}
	}

	public void DBDMFKEFCMI()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PFABNKPBKGD == (Object)null)
		{
			PHKOHIJINDD(new GameObject("popUpBuilding20").transform);
			PFABNKPBKGD.position = Vector3.zero;
			APCLGKNPBKE().SetAsFirstSibling();
		}
	}

	public static void CBMBHAJAMCJ(GameObject CINEJKCOOCL)
	{
		if ((Object)(object)CINEJKCOOCL == (Object)null)
		{
			Debug.LogError((object)"A game with this code does not exist on this region.\nPlease, make sure both players are playing on the same region.");
		}
		else
		{
			GPEMPAJCLPP(CINEJKCOOCL.GetComponent<PoolCustomer>());
		}
	}

	public static void BFEHBKFJHNE(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.FPKBBNHJMFI();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(JOBNADJBCOL());
		}
		else
		{
			Debug.LogError((object)"Festín del Juramento/PresentacionMaestros 01");
		}
	}

	private void CNPHLKKCFAG()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(LPFIFMOMEOB);
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].IMHAEKCAOGG();
			}
		}
	}

	public static void GOAJOKAOLFP(PoolCustomer CINEJKCOOCL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		instance.activeCustomers.Remove(CINEJKCOOCL);
		if ((Object)(object)CINEJKCOOCL != (Object)null)
		{
			instance.pooledCustomers.Add(CINEJKCOOCL);
			CINEJKCOOCL.IMHAEKCAOGG();
			((Component)CINEJKCOOCL).transform.position = GDLFNLCBAPE;
			((Component)CINEJKCOOCL).transform.SetParent(GFLANOGBIBA());
		}
		else
		{
			Debug.LogError((object)"Attack/MainEvent 12");
		}
	}

	private void NMMALPMKMOE()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (pooledCustomers.Count != 0)
		{
			return;
		}
		PoolCustomer[] componentsInChildren = ((Component)this).GetComponentsInChildren<PoolCustomer>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			pooledCustomers.Add(componentsInChildren[i]);
			((Component)componentsInChildren[i]).transform.position = GDLFNLCBAPE;
			((Component)componentsInChildren[i]).transform.SetParent(CPFDHGBBDDD());
			if (!OnlineManager.ClientOnline())
			{
				pooledCustomers[i].FPKBBNHJMFI();
			}
		}
	}

	public void GHNJFMJJGDP()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CCFGNPMCCNP() == (Object)null)
		{
			PKMKOEAALMI(new GameObject("itemTurnip").transform);
			CCFGNPMCCNP().position = Vector3.zero;
			AKDFEKJOEOB().SetAsFirstSibling();
		}
	}

	private void BONEKIAPEIK()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void HOKBBFHGACN()
	{
		GLJNDPPLGDH();
	}

	private void PDAFINABOBC()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}
}
