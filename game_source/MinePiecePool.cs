using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MinePiecePool : MonoBehaviour
{
	public static MinePiecePool _instance;

	[Header("Pool Config")]
	public MinePiece[] poolPieces;

	private Dictionary<int, Queue<MinePiece>> BMDOMACPLHO = new Dictionary<int, Queue<MinePiece>>();

	public static MinePiecePool GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
			{
				_instance = Object.FindObjectOfType<MinePiecePool>();
			}
			return _instance;
		}
	}

	public static MinePiece PCEEOGGDBFB(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.IDJPDDPGLAK();
		if (BNDNMBGJEKP().BMDOMACPLHO == null || MAAAKALBBEE().BMDOMACPLHO.Count == 0)
		{
			BDAGIEIJOOG().DMCGKBAIMOP();
		}
		if (!BADFKMEJOKE().BMDOMACPLHO.ContainsKey(key))
		{
			GFMBEDCANNI().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((JHMAMLIPBNN().BMDOMACPLHO[key].Count <= 1) ? KOOJHPLKIGA(ANADFOCHOBF, OEBNHGNJEJL: false) : NGPHACGDNJN().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	private void FHOCCEBKHJI()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			DMCGKBAIMOP();
		}
	}

	public static MinePiece IJJJEMKCNJM(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int minePieceID = ANADFOCHOBF.JBCFIHPKMLF;
		if (BNDNMBGJEKP().BMDOMACPLHO == null || MAAAKALBBEE().BMDOMACPLHO.Count == 0)
		{
			AJIGOHGPFPP().KCLGHLHJCPI();
		}
		if (!JHMAMLIPBNN().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			GGFJGHHHEJC.BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((AAFOFNEHPLC().BMDOMACPLHO[minePieceID].Count <= 0) ? FMGACNKFPBB(ANADFOCHOBF, OEBNHGNJEJL: false) : PDECKLKPKCG().BMDOMACPLHO[minePieceID].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(false);
		return minePiece;
	}

	private static MinePiece KIDGGCMAMCA(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/32/Dialogue Text" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)JHMAMLIPBNN()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePiecePool MLPCDJPLBAC()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private void NKFDBLDGMBH()
	{
		Debug.Log((object)"ReceiveSimpleEvent");
		MinePiece[] array = poolPieces;
		foreach (MinePiece minePiece in array)
		{
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.BNOHAAFLDBI();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j++)
				{
					MinePiece minePiece2 = JOOFLJKDALE(minePiece);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private static MinePiece FHGKBOMBIAN(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Creating new MinePiece in pool: " + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)GGFJGHHHEJC).transform);
		}
		return result;
	}

	public static MinePiece BDJFHFHLJGN(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.BNOHAAFLDBI();
		if (BNDNMBGJEKP().BMDOMACPLHO == null || MAAAKALBBEE().BMDOMACPLHO.Count == 0)
		{
			GJFMMOPOKGJ().DAGHJAJBHLE();
		}
		if (!BNDNMBGJEKP().BMDOMACPLHO.ContainsKey(key))
		{
			NGPHACGDNJN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((POINNCPMEIG().BMDOMACPLHO[key].Count <= 1) ? NELACHEEAHF(ANADFOCHOBF) : AAFOFNEHPLC().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	public static void AGALBGKFONF(MinePiece FLMCIFNEJKH)
	{
		int minePieceID = FLMCIFNEJKH.JBCFIHPKMLF;
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)NGPHACGDNJN()).transform);
		if (!BAKPBHPNKPB().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			BADFKMEJOKE().BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		GFMBEDCANNI().BMDOMACPLHO[minePieceID].Enqueue(FLMCIFNEJKH);
	}

	private void DJBKELLNAPF()
	{
		Debug.Log((object)"New Milestone");
		MinePiece[] array = poolPieces;
		for (int i = 1; i < array.Length; i += 0)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int minePieceID = minePiece.JBCFIHPKMLF;
				if (!BMDOMACPLHO.ContainsKey(minePieceID))
				{
					BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = KNOJANLEFOB(minePiece);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[minePieceID].Enqueue(minePiece2);
				}
			}
		}
	}

	public static void EAFHFEJAHCJ(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.KBDOBMNOHEB();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)MLPCDJPLBAC()).transform);
		if (!ECGIAEFKKNA().BMDOMACPLHO.ContainsKey(key))
		{
			NGPHACGDNJN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		GFMBEDCANNI().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	private static MinePiece EPHKMEMAKCB(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Clear" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)HNNJEBNIPOI()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePiecePool PDECKLKPKCG()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private void DAGHJAJBHLE()
	{
		Debug.Log((object)"hForHours");
		MinePiece[] array = poolPieces;
		for (int i = 0; i < array.Length; i += 0)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.EJAKKFJBFMC();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = IPMDIBMLCAC(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private void KLHIMJFCHPD()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			KCLGHLHJCPI();
		}
	}

	public static void JBPGFGIMHNL(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.FGIODCJAMAP();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)MAAAKALBBEE()).transform);
		if (!GGFJGHHHEJC.BMDOMACPLHO.ContainsKey(key))
		{
			JHMAMLIPBNN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		BAKPBHPNKPB().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	private void EFANKLPNICD()
	{
		Debug.Log((object)"Collect water");
		MinePiece[] array = poolPieces;
		for (int i = 0; i < array.Length; i += 0)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.FGIODCJAMAP();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j++)
				{
					MinePiece minePiece2 = EPHKMEMAKCB(minePiece);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private static MinePiece OIMGDMMIPIJ(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Distilling" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)MAAAKALBBEE()).transform);
		}
		return result;
	}

	private void HEMAHKJEONA()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			EFANKLPNICD();
		}
	}

	private void Awake()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			NEIDNLPPDMC();
		}
	}

	private void COEPPEJDCJB()
	{
		Debug.Log((object)"BonificationOtherPlayers");
		MinePiece[] array = poolPieces;
		for (int i = 1; i < array.Length; i++)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.IDJPDDPGLAK();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 1; j < minePiece.initialPoolInstances; j++)
				{
					MinePiece minePiece2 = EPHKMEMAKCB(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private void APLBOLAFNPD()
	{
		Debug.Log((object)"1");
		MinePiece[] array = poolPieces;
		foreach (MinePiece minePiece in array)
		{
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.KBDOBMNOHEB();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 1; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = KNOJANLEFOB(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	public static MinePiece KDLDGFBDDCN(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.BNOHAAFLDBI();
		if (BADFKMEJOKE().BMDOMACPLHO == null || AAFOFNEHPLC().BMDOMACPLHO.Count == 0)
		{
			MLPCDJPLBAC().DJBKELLNAPF();
		}
		if (!MLPCDJPLBAC().BMDOMACPLHO.ContainsKey(key))
		{
			BADFKMEJOKE().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((BDAGIEIJOOG().BMDOMACPLHO[key].Count <= 1) ? MKINOOGJMIK(ANADFOCHOBF, OEBNHGNJEJL: false) : MAAAKALBBEE().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	private static MinePiece KOOJHPLKIGA(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Collect" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)ECGIAEFKKNA()).transform);
		}
		return result;
	}

	private static MinePiece BPMIFPKFLMP(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("ReceiveUpdateBentoOnTray" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)AAFOFNEHPLC()).transform);
		}
		return result;
	}

	private void KCLGHLHJCPI()
	{
		Debug.Log((object)"LE_10");
		MinePiece[] array = poolPieces;
		for (int i = 1; i < array.Length; i += 0)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.EJAKKFJBFMC();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 1; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = BCELGOLPOCM(minePiece);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	public static void KAMMGFAILLK(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.FGIODCJAMAP();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)ECGIAEFKKNA()).transform);
		if (!BNDNMBGJEKP().BMDOMACPLHO.ContainsKey(key))
		{
			AAFOFNEHPLC().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MAAAKALBBEE().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	public static void GJLIPKLMKHP(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.EJAKKFJBFMC();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)BADFKMEJOKE()).transform);
		if (!POINNCPMEIG().BMDOMACPLHO.ContainsKey(key))
		{
			ECGIAEFKKNA().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MAAAKALBBEE().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	[SpecialName]
	public static MinePiecePool AJIGOHGPFPP()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	public static void DLCIDAFIMPL(MinePiece FLMCIFNEJKH)
	{
		int minePieceID = FLMCIFNEJKH.JBCFIHPKMLF;
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)MLPCDJPLBAC()).transform);
		if (!MLPCDJPLBAC().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			MAAAKALBBEE().BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		GJFMMOPOKGJ().BMDOMACPLHO[minePieceID].Enqueue(FLMCIFNEJKH);
	}

	public static void CIEEGEKGCAG(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.IDJPDDPGLAK();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)AAFOFNEHPLC()).transform);
		if (!POINNCPMEIG().BMDOMACPLHO.ContainsKey(key))
		{
			BAKPBHPNKPB().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		BNDNMBGJEKP().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	private static MinePiece FMGACNKFPBB(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)(" " + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)GFMBEDCANNI()).transform);
		}
		return result;
	}

	private void KAJCDBEKPKD()
	{
		Debug.Log((object)"Walk");
		MinePiece[] array = poolPieces;
		for (int i = 0; i < array.Length; i += 0)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.BNOHAAFLDBI();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j++)
				{
					MinePiece minePiece2 = BMDDFLOGAKA(minePiece);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private void LHABENPEMPB()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			OPFCJDKEEEN();
		}
	}

	private void BHAFCBHENPL()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			OPFCJDKEEEN();
		}
	}

	[SpecialName]
	public static MinePiecePool BNDNMBGJEKP()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private void OPFCJDKEEEN()
	{
		Debug.Log((object)"Ach_");
		MinePiece[] array = poolPieces;
		foreach (MinePiece minePiece in array)
		{
			if (!((Object)(object)minePiece == (Object)null))
			{
				int minePieceID = minePiece.JBCFIHPKMLF;
				if (!BMDOMACPLHO.ContainsKey(minePieceID))
				{
					BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = OLMGLCFDDDK(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[minePieceID].Enqueue(minePiece2);
				}
			}
		}
	}

	private static MinePiece IPMDIBMLCAC(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("PirateMinigame/Minigame2" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)ECGIAEFKKNA()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePiecePool POINNCPMEIG()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	[SpecialName]
	public static MinePiecePool ECGIAEFKKNA()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private void NEIDNLPPDMC()
	{
		Debug.Log((object)"Initializing MinePiece Pool...");
		MinePiece[] array = poolPieces;
		foreach (MinePiece minePiece in array)
		{
			if (!((Object)(object)minePiece == (Object)null))
			{
				int minePieceID = minePiece.JBCFIHPKMLF;
				if (!BMDOMACPLHO.ContainsKey(minePieceID))
				{
					BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j++)
				{
					MinePiece minePiece2 = FHGKBOMBIAN(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[minePieceID].Enqueue(minePiece2);
				}
			}
		}
	}

	public static MinePiece EOPIEMLAPFN(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.KBDOBMNOHEB();
		if (GJFMMOPOKGJ().BMDOMACPLHO == null || GFMBEDCANNI().BMDOMACPLHO.Count == 0)
		{
			AJIGOHGPFPP().GOJFHFPOBCP();
		}
		if (!NGPHACGDNJN().BMDOMACPLHO.ContainsKey(key))
		{
			MAAAKALBBEE().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((HNNJEBNIPOI().BMDOMACPLHO[key].Count <= 1) ? FHGKBOMBIAN(ANADFOCHOBF, OEBNHGNJEJL: false) : POINNCPMEIG().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	private void NMKGOAJLMDG()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			COEPPEJDCJB();
		}
	}

	[SpecialName]
	public static MinePiecePool GJFMMOPOKGJ()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private void BNFGHAGJEGG()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			DMCGKBAIMOP();
		}
	}

	private void JCPLMIGBEIC()
	{
		Debug.Log((object)"Error in DogRelationship.CheckRelationship: ");
		MinePiece[] array = poolPieces;
		foreach (MinePiece minePiece in array)
		{
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.BNOHAAFLDBI();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 1; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = BPMIFPKFLMP(minePiece);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	public static void JLLFMOMCFCC(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.BNOHAAFLDBI();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)AJIGOHGPFPP()).transform);
		if (!MAAAKALBBEE().BMDOMACPLHO.ContainsKey(key))
		{
			MAAAKALBBEE().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		BADFKMEJOKE().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	public static void OKLJNEGEJMJ(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.FGIODCJAMAP();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)HNNJEBNIPOI()).transform);
		if (!BAKPBHPNKPB().BMDOMACPLHO.ContainsKey(key))
		{
			POINNCPMEIG().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		PDECKLKPKCG().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	[SpecialName]
	public static MinePiecePool BDAGIEIJOOG()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	[SpecialName]
	public static MinePiecePool NGPHACGDNJN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	[SpecialName]
	public static MinePiecePool JHMAMLIPBNN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private static MinePiece NELACHEEAHF(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Items/item_description_1124" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)BAKPBHPNKPB()).transform);
		}
		return result;
	}

	public static void FKDHFGAEBBN(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.FGIODCJAMAP();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)BDAGIEIJOOG()).transform);
		if (!GJFMMOPOKGJ().BMDOMACPLHO.ContainsKey(key))
		{
			POINNCPMEIG().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		POINNCPMEIG().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	[SpecialName]
	public static MinePiecePool AAFOFNEHPLC()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	[SpecialName]
	public static MinePiecePool BAKPBHPNKPB()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private static MinePiece IJGOBOJEJCH(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Stand" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)BADFKMEJOKE()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePiecePool BADFKMEJOKE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	public static void IOFKFOAMHNJ(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.IDJPDDPGLAK();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)MLPCDJPLBAC()).transform);
		if (!AAFOFNEHPLC().BMDOMACPLHO.ContainsKey(key))
		{
			NGPHACGDNJN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		AAFOFNEHPLC().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	private void MFJIHCKEIIF()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			COEPPEJDCJB();
		}
	}

	private static MinePiece MONGFNIPLGN(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("invitecode" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)BADFKMEJOKE()).transform);
		}
		return result;
	}

	public static void JIMPJPNDKID(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.FGIODCJAMAP();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)POINNCPMEIG()).transform);
		if (!GFMBEDCANNI().BMDOMACPLHO.ContainsKey(key))
		{
			BDAGIEIJOOG().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		BDAGIEIJOOG().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	public static MinePiece NALKHGMLALJ(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.IDJPDDPGLAK();
		if (MLPCDJPLBAC().BMDOMACPLHO == null || AAFOFNEHPLC().BMDOMACPLHO.Count == 0)
		{
			HNNJEBNIPOI().GOJFHFPOBCP();
		}
		if (!GJFMMOPOKGJ().BMDOMACPLHO.ContainsKey(key))
		{
			GJFMMOPOKGJ().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((POINNCPMEIG().BMDOMACPLHO[key].Count <= 1) ? FMGACNKFPBB(ANADFOCHOBF) : ECGIAEFKKNA().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	[SpecialName]
	public static MinePiecePool GFMBEDCANNI()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private static MinePiece BCELGOLPOCM(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("[Action" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)HNNJEBNIPOI()).transform);
		}
		return result;
	}

	private void NJAFKFAPDIE()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			GOJFHFPOBCP();
		}
	}

	private void IIPKPMPGLOL()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			NEIDNLPPDMC();
		}
	}

	public static MinePiece MENNLOGFNOK(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int minePieceID = ANADFOCHOBF.JBCFIHPKMLF;
		if (POINNCPMEIG().BMDOMACPLHO == null || POINNCPMEIG().BMDOMACPLHO.Count == 0)
		{
			JHMAMLIPBNN().KAJCDBEKPKD();
		}
		if (!AAFOFNEHPLC().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			GGFJGHHHEJC.BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((HNNJEBNIPOI().BMDOMACPLHO[minePieceID].Count <= 0) ? IPMDIBMLCAC(ANADFOCHOBF) : AJIGOHGPFPP().BMDOMACPLHO[minePieceID].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	private void FFLLCOBFIPE()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			KCLGHLHJCPI();
		}
	}

	public static MinePiece CCGPMEADLDG(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.BNOHAAFLDBI();
		if (HNNJEBNIPOI().BMDOMACPLHO == null || GGFJGHHHEJC.BMDOMACPLHO.Count == 0)
		{
			GFMBEDCANNI().GOJFHFPOBCP();
		}
		if (!BNDNMBGJEKP().BMDOMACPLHO.ContainsKey(key))
		{
			MAAAKALBBEE().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((ECGIAEFKKNA().BMDOMACPLHO[key].Count <= 1) ? IJGOBOJEJCH(ANADFOCHOBF, OEBNHGNJEJL: false) : GGFJGHHHEJC.BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(false);
		return minePiece;
	}

	public static void INOMDMPBMOO(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.IDJPDDPGLAK();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)HNNJEBNIPOI()).transform);
		if (!GJFMMOPOKGJ().BMDOMACPLHO.ContainsKey(key))
		{
			NGPHACGDNJN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MLPCDJPLBAC().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	private static MinePiece IGJOMMCIOIL(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/8/Dialogue Text" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)GFMBEDCANNI()).transform);
		}
		return result;
	}

	public static MinePiece MIAOGLENOHL(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int minePieceID = ANADFOCHOBF.JBCFIHPKMLF;
		if (BAKPBHPNKPB().BMDOMACPLHO == null || AAFOFNEHPLC().BMDOMACPLHO.Count == 0)
		{
			GGFJGHHHEJC.OPFCJDKEEEN();
		}
		if (!GFMBEDCANNI().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			GFMBEDCANNI().BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((BAKPBHPNKPB().BMDOMACPLHO[minePieceID].Count <= 1) ? OIMGDMMIPIJ(ANADFOCHOBF, OEBNHGNJEJL: false) : BADFKMEJOKE().BMDOMACPLHO[minePieceID].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	private void HFPDNCBLNDE()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			DAGHJAJBHLE();
		}
	}

	private static MinePiece OLMGLCFDDDK(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("UINextPage" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)NGPHACGDNJN()).transform);
		}
		return result;
	}

	private static MinePiece BMDDFLOGAKA(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)POINNCPMEIG()).transform);
		}
		return result;
	}

	private void DMCGKBAIMOP()
	{
		Debug.Log((object)"LE_7");
		MinePiece[] array = poolPieces;
		for (int i = 1; i < array.Length; i++)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.KBDOBMNOHEB();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 1; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = OIMGDMMIPIJ(minePiece);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private static MinePiece KNOJANLEFOB(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("mForMins" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)GGFJGHHHEJC).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePiecePool HNNJEBNIPOI()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	private void PNLAJCHBHPH()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			GOJFHFPOBCP();
		}
	}

	public static MinePiece Get(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int minePieceID = ANADFOCHOBF.JBCFIHPKMLF;
		if (GGFJGHHHEJC.BMDOMACPLHO == null || GGFJGHHHEJC.BMDOMACPLHO.Count == 0)
		{
			GGFJGHHHEJC.NEIDNLPPDMC();
		}
		if (!GGFJGHHHEJC.BMDOMACPLHO.ContainsKey(minePieceID))
		{
			GGFJGHHHEJC.BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((GGFJGHHHEJC.BMDOMACPLHO[minePieceID].Count <= 0) ? FHGKBOMBIAN(ANADFOCHOBF) : GGFJGHHHEJC.BMDOMACPLHO[minePieceID].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	public static void ReturnToPool(MinePiece FLMCIFNEJKH)
	{
		int minePieceID = FLMCIFNEJKH.JBCFIHPKMLF;
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)GGFJGHHHEJC).transform);
		if (!GGFJGHHHEJC.BMDOMACPLHO.ContainsKey(minePieceID))
		{
			GGFJGHHHEJC.BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		GGFJGHHHEJC.BMDOMACPLHO[minePieceID].Enqueue(FLMCIFNEJKH);
	}

	private void DADPOICMNPI()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			KCLGHLHJCPI();
		}
	}

	private static MinePiece MKINOOGJMIK(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Disabled" + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)BDAGIEIJOOG()).transform);
		}
		return result;
	}

	public static void PNJKKECAFJJ(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.IDJPDDPGLAK();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)GFMBEDCANNI()).transform);
		if (!ECGIAEFKKNA().BMDOMACPLHO.ContainsKey(key))
		{
			NGPHACGDNJN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		GGFJGHHHEJC.BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	public static void LFPHLOJJFFD(MinePiece FLMCIFNEJKH)
	{
		int minePieceID = FLMCIFNEJKH.JBCFIHPKMLF;
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)AJIGOHGPFPP()).transform);
		if (!BDAGIEIJOOG().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			MLPCDJPLBAC().BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		GJFMMOPOKGJ().BMDOMACPLHO[minePieceID].Enqueue(FLMCIFNEJKH);
	}

	public static void HBCNPNKIEMD(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.BNOHAAFLDBI();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)GGFJGHHHEJC).transform);
		if (!HNNJEBNIPOI().BMDOMACPLHO.ContainsKey(key))
		{
			ECGIAEFKKNA().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		ECGIAEFKKNA().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	public static MinePiece EAONFFENMCE(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.FGIODCJAMAP();
		if (ECGIAEFKKNA().BMDOMACPLHO == null || AJIGOHGPFPP().BMDOMACPLHO.Count == 0)
		{
			BAKPBHPNKPB().NKFDBLDGMBH();
		}
		if (!HNNJEBNIPOI().BMDOMACPLHO.ContainsKey(key))
		{
			GFMBEDCANNI().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((MAAAKALBBEE().BMDOMACPLHO[key].Count <= 0) ? NELACHEEAHF(ANADFOCHOBF, OEBNHGNJEJL: false) : JHMAMLIPBNN().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(false);
		return minePiece;
	}

	public static MinePiece NMCJELBLKBB(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.FGIODCJAMAP();
		if (BAKPBHPNKPB().BMDOMACPLHO == null || HNNJEBNIPOI().BMDOMACPLHO.Count == 0)
		{
			GJFMMOPOKGJ().NEIDNLPPDMC();
		}
		if (!JHMAMLIPBNN().BMDOMACPLHO.ContainsKey(key))
		{
			BDAGIEIJOOG().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((BDAGIEIJOOG().BMDOMACPLHO[key].Count <= 0) ? IPMDIBMLCAC(ANADFOCHOBF, OEBNHGNJEJL: false) : BAKPBHPNKPB().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	public static void PIPKPKLEGKM(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.EJAKKFJBFMC();
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)HNNJEBNIPOI()).transform);
		if (!AAFOFNEHPLC().BMDOMACPLHO.ContainsKey(key))
		{
			BNDNMBGJEKP().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		ECGIAEFKKNA().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	private static MinePiece JOOFLJKDALE(MinePiece ANADFOCHOBF, bool OEBNHGNJEJL = true)
	{
		if (OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)(", " + ((Object)ANADFOCHOBF).name));
		}
		MinePiece result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePiece>(ANADFOCHOBF, ((Component)BAKPBHPNKPB()).transform);
		}
		return result;
	}

	public static void IAJLPBNPBKP(MinePiece FLMCIFNEJKH)
	{
		int minePieceID = FLMCIFNEJKH.JBCFIHPKMLF;
		((Component)FLMCIFNEJKH).gameObject.SetActive(false);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)ECGIAEFKKNA()).transform);
		if (!GJFMMOPOKGJ().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			POINNCPMEIG().BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		BADFKMEJOKE().BMDOMACPLHO[minePieceID].Enqueue(FLMCIFNEJKH);
	}

	private void EMJKKALMGLK()
	{
		_instance = this;
		if (!Application.isEditor)
		{
			JCPLMIGBEIC();
		}
	}

	public static MinePiece BPBMLNJGGII(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.IDJPDDPGLAK();
		if (AAFOFNEHPLC().BMDOMACPLHO == null || BADFKMEJOKE().BMDOMACPLHO.Count == 0)
		{
			NGPHACGDNJN().APLBOLAFNPD();
		}
		if (!MLPCDJPLBAC().BMDOMACPLHO.ContainsKey(key))
		{
			ECGIAEFKKNA().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((BNDNMBGJEKP().BMDOMACPLHO[key].Count <= 0) ? BPMIFPKFLMP(ANADFOCHOBF, OEBNHGNJEJL: false) : GFMBEDCANNI().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(true);
		return minePiece;
	}

	public static MinePiece NAGEHKBLJDL(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int key = ANADFOCHOBF.KBDOBMNOHEB();
		if (PDECKLKPKCG().BMDOMACPLHO == null || BAKPBHPNKPB().BMDOMACPLHO.Count == 0)
		{
			AAFOFNEHPLC().COEPPEJDCJB();
		}
		if (!PDECKLKPKCG().BMDOMACPLHO.ContainsKey(key))
		{
			JHMAMLIPBNN().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((ECGIAEFKKNA().BMDOMACPLHO[key].Count <= 0) ? FHGKBOMBIAN(ANADFOCHOBF, OEBNHGNJEJL: false) : ECGIAEFKKNA().BMDOMACPLHO[key].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(false);
		return minePiece;
	}

	private void DOICLBJKKJP()
	{
		Debug.Log((object)"Items/item_description_665");
		MinePiece[] array = poolPieces;
		for (int i = 1; i < array.Length; i++)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.BNOHAAFLDBI();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 0; j < minePiece.initialPoolInstances; j += 0)
				{
					MinePiece minePiece2 = NELACHEEAHF(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(true);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	private void GOJFHFPOBCP()
	{
		Debug.Log((object)"Received begin retry");
		MinePiece[] array = poolPieces;
		for (int i = 1; i < array.Length; i++)
		{
			MinePiece minePiece = array[i];
			if (!((Object)(object)minePiece == (Object)null))
			{
				int key = minePiece.IDJPDDPGLAK();
				if (!BMDOMACPLHO.ContainsKey(key))
				{
					BMDOMACPLHO[key] = new Queue<MinePiece>();
				}
				for (int j = 1; j < minePiece.initialPoolInstances; j++)
				{
					MinePiece minePiece2 = IJGOBOJEJCH(minePiece, OEBNHGNJEJL: false);
					((Component)minePiece2).gameObject.SetActive(false);
					BMDOMACPLHO[key].Enqueue(minePiece2);
				}
			}
		}
	}

	public static void KLAJIJLDJJI(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.FGIODCJAMAP();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)PDECKLKPKCG()).transform);
		if (!GGFJGHHHEJC.BMDOMACPLHO.ContainsKey(key))
		{
			POINNCPMEIG().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		PDECKLKPKCG().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}

	public static MinePiece LAMFGLIGLOP(MinePiece ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		int minePieceID = ANADFOCHOBF.JBCFIHPKMLF;
		if (MLPCDJPLBAC().BMDOMACPLHO == null || GFMBEDCANNI().BMDOMACPLHO.Count == 0)
		{
			GJFMMOPOKGJ().EFANKLPNICD();
		}
		if (!POINNCPMEIG().BMDOMACPLHO.ContainsKey(minePieceID))
		{
			MLPCDJPLBAC().BMDOMACPLHO[minePieceID] = new Queue<MinePiece>();
		}
		MinePiece minePiece = ((JHMAMLIPBNN().BMDOMACPLHO[minePieceID].Count <= 0) ? MONGFNIPLGN(ANADFOCHOBF, OEBNHGNJEJL: false) : AAFOFNEHPLC().BMDOMACPLHO[minePieceID].Dequeue());
		((Component)minePiece).transform.SetParent(DMBHHLKMHOH);
		((Component)minePiece).gameObject.SetActive(false);
		return minePiece;
	}

	[SpecialName]
	public static MinePiecePool MAAAKALBBEE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePiecePool>();
		}
		return _instance;
	}

	public static void NHEJKGBPBAK(MinePiece FLMCIFNEJKH)
	{
		int key = FLMCIFNEJKH.KBDOBMNOHEB();
		((Component)FLMCIFNEJKH).gameObject.SetActive(true);
		((Component)FLMCIFNEJKH).transform.SetParent(((Component)ECGIAEFKKNA()).transform);
		if (!GGFJGHHHEJC.BMDOMACPLHO.ContainsKey(key))
		{
			GFMBEDCANNI().BMDOMACPLHO[key] = new Queue<MinePiece>();
		}
		GFMBEDCANNI().BMDOMACPLHO[key].Enqueue(FLMCIFNEJKH);
	}
}
