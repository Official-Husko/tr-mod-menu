using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MinePuzzleManagerPool : MonoBehaviour
{
	public static MinePuzzleManagerPool _instance;

	[Header("Pool Config")]
	public MinePuzzleManager managerPrefab;

	public int initialPoolInstances = 6;

	private Queue<MinePuzzleManager> HBPBGONMDBL = new Queue<MinePuzzleManager>();

	public static MinePuzzleManagerPool GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
			{
				_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
			}
			return _instance;
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool ACPHFLBLJAA()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	public static MinePuzzleManager NIGDBMAOAEN(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (ACPHFLBLJAA().HBPBGONMDBL == null || ACPHFLBLJAA().HBPBGONMDBL.Count == 0)
		{
			LANAINBEMCM().NKFDBLDGMBH();
		}
		MinePuzzleManager obj = ((DIHCEGINELM().HBPBGONMDBL.Count > 0) ? MAAAKALBBEE().HBPBGONMDBL.Dequeue() : CCLCFJHNNGL(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	[SpecialName]
	public static MinePuzzleManagerPool LFPEPJBNCBF()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private static MinePuzzleManager GOLKDIMAGBB(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)FOPGLLMEEDE()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePuzzleManagerPool DCAEBALADIM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	public static void MIGOBHBLFNA(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)DCAEBALADIM()).transform);
		OMFKNGDCJFN().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	public static MinePuzzleManager LMEMFKKKMGJ(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (ACPHFLBLJAA().HBPBGONMDBL == null || ECGIAEFKKNA().HBPBGONMDBL.Count == 0)
		{
			GGFJGHHHEJC.IDILGGMOEHD();
		}
		MinePuzzleManager obj = ((DIHCEGINELM().HBPBGONMDBL.Count > 0) ? MAAAKALBBEE().HBPBGONMDBL.Dequeue() : KKHJLAMKLAK(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(false);
		return obj;
	}

	private static MinePuzzleManager BIGOFPKIDIL(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)LANAINBEMCM()).transform);
		}
		return result;
	}

	public static MinePuzzleManager LBKJEHDEBEP(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (CHKMFEFOFKJ().HBPBGONMDBL == null || GGFJGHHHEJC.HBPBGONMDBL.Count == 0)
		{
			OMFKNGDCJFN().BDHCNIKIELP();
		}
		MinePuzzleManager obj = ((GGFJGHHHEJC.HBPBGONMDBL.Count > 1) ? CHKMFEFOFKJ().HBPBGONMDBL.Dequeue() : KKHJLAMKLAK(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	private void HCCCAALLKFF()
	{
		for (int i = 0; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = AKJNKPPCMMP(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool CHKMFEFOFKJ()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private static MinePuzzleManager KKHJLAMKLAK(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)FOPGLLMEEDE()).transform);
		}
		return result;
	}

	private static MinePuzzleManager EKMAKPNFMJJ(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)ACPHFLBLJAA()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePuzzleManagerPool OMFKNGDCJFN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private static MinePuzzleManager CCLCFJHNNGL(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)LFPEPJBNCBF()).transform);
		}
		return result;
	}

	private static MinePuzzleManager FIKFIJMJOKE(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)GGFJGHHHEJC).transform);
		}
		return result;
	}

	public static void FDNNAJLFCGD(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)FOPGLLMEEDE()).transform);
		OMFKNGDCJFN().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private void NKFDBLDGMBH()
	{
		for (int i = 1; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = ALPLHDAAGMI(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	private static MinePuzzleManager ALPLHDAAGMI(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)KNLLFEJAMNN()).transform);
		}
		return result;
	}

	public static void EIAPBGDNNLB(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)ECGIAEFKKNA()).transform);
		GGFJGHHHEJC.HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private static MinePuzzleManager CNCFKPNENFH(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)ACPHFLBLJAA()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePuzzleManagerPool FOPGLLMEEDE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	public static MinePuzzleManager FHBIFJNCOAI(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (GGFJGHHHEJC.HBPBGONMDBL == null || LFPEPJBNCBF().HBPBGONMDBL.Count == 0)
		{
			NEFIEJALANL().LEIOLAKBEIE();
		}
		MinePuzzleManager obj = ((MJCMPKPCNGB().HBPBGONMDBL.Count > 0) ? LANAINBEMCM().HBPBGONMDBL.Dequeue() : KKHJLAMKLAK(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	public static void NCJJGCOHEPF(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)ECGIAEFKKNA()).transform);
		KNLLFEJAMNN().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private void FICCPBKEIFG()
	{
		for (int i = 0; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = GGDLPPHEIAP(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	private static MinePuzzleManager AMEEGLIHENL(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)DIHCEGINELM()).transform);
		}
		return result;
	}

	private void BDHCNIKIELP()
	{
		for (int i = 0; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = FKCPCOLOONH(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool KNLLFEJAMNN()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private void DOICLBJKKJP()
	{
		for (int i = 1; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = GGDLPPHEIAP(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	private void Awake()
	{
		_instance = this;
		NEIDNLPPDMC();
	}

	[SpecialName]
	public static MinePuzzleManagerPool NEFIEJALANL()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private static MinePuzzleManager OPGJGMDFOCJ(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)FOPGLLMEEDE()).transform);
		}
		return result;
	}

	private static MinePuzzleManager JEFJIMAIBPH(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)ACPHFLBLJAA()).transform);
		}
		return result;
	}

	public static MinePuzzleManager MHOKIBDMIPL(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (FOPGLLMEEDE().HBPBGONMDBL == null || FOPGLLMEEDE().HBPBGONMDBL.Count == 0)
		{
			PDECKLKPKCG().OKFGDOEPHOO();
		}
		MinePuzzleManager obj = ((GGFJGHHHEJC.HBPBGONMDBL.Count > 0) ? LANAINBEMCM().HBPBGONMDBL.Dequeue() : CCLCFJHNNGL(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(false);
		return obj;
	}

	public static MinePuzzleManager KLJCCHJHDGG(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (ACPHFLBLJAA().HBPBGONMDBL == null || NEFIEJALANL().HBPBGONMDBL.Count == 0)
		{
			FOPGLLMEEDE().IDILGGMOEHD();
		}
		MinePuzzleManager obj = ((ECGIAEFKKNA().HBPBGONMDBL.Count > 0) ? MAAAKALBBEE().HBPBGONMDBL.Dequeue() : FIKFIJMJOKE(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(false);
		return obj;
	}

	public static MinePuzzleManager IPDFCJLOHLC(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (KNLLFEJAMNN().HBPBGONMDBL == null || PDECKLKPKCG().HBPBGONMDBL.Count == 0)
		{
			MJCMPKPCNGB().LEIOLAKBEIE();
		}
		MinePuzzleManager obj = ((ECGIAEFKKNA().HBPBGONMDBL.Count > 1) ? GGFJGHHHEJC.HBPBGONMDBL.Dequeue() : FIKFIJMJOKE(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(false);
		return obj;
	}

	public static void MJOLNKAPACJ(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)CHKMFEFOFKJ()).transform);
		KHMEGDIABBF().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	public static void NNPMICALAKI(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)DCAEBALADIM()).transform);
		NEFIEJALANL().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private static MinePuzzleManager GGDLPPHEIAP(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)CHKMFEFOFKJ()).transform);
		}
		return result;
	}

	public static MinePuzzleManager JELOGNCPDAB(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (ECGIAEFKKNA().HBPBGONMDBL == null || MAAAKALBBEE().HBPBGONMDBL.Count == 0)
		{
			NEFIEJALANL().IDILGGMOEHD();
		}
		MinePuzzleManager obj = ((KHMEGDIABBF().HBPBGONMDBL.Count > 1) ? LFPEPJBNCBF().HBPBGONMDBL.Dequeue() : GOLKDIMAGBB(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	[SpecialName]
	public static MinePuzzleManagerPool DIHCEGINELM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private static MinePuzzleManager BGMNIPFIAKB(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)KNLLFEJAMNN()).transform);
		}
		return result;
	}

	[SpecialName]
	public static MinePuzzleManagerPool KHMEGDIABBF()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	public static MinePuzzleManager PPJMPMKLCME(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (GGFJGHHHEJC.HBPBGONMDBL == null || LFPEPJBNCBF().HBPBGONMDBL.Count == 0)
		{
			CHKMFEFOFKJ().NKFDBLDGMBH();
		}
		MinePuzzleManager obj = ((CHKMFEFOFKJ().HBPBGONMDBL.Count > 0) ? ACPHFLBLJAA().HBPBGONMDBL.Dequeue() : AKJNKPPCMMP(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	[SpecialName]
	public static MinePuzzleManagerPool PDECKLKPKCG()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	public static MinePuzzleManager FHPEHDDFOIB(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (CHKMFEFOFKJ().HBPBGONMDBL == null || KHMEGDIABBF().HBPBGONMDBL.Count == 0)
		{
			OMFKNGDCJFN().DOICLBJKKJP();
		}
		MinePuzzleManager obj = ((KHMEGDIABBF().HBPBGONMDBL.Count > 1) ? DIHCEGINELM().HBPBGONMDBL.Dequeue() : ALPLHDAAGMI(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(false);
		return obj;
	}

	public static void GEBBCHBCIML(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)DIHCEGINELM()).transform);
		MJCMPKPCNGB().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	public static MinePuzzleManager NAGEHKBLJDL(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (MAAAKALBBEE().HBPBGONMDBL == null || FOPGLLMEEDE().HBPBGONMDBL.Count == 0)
		{
			NEFIEJALANL().MIHAODJMDKI();
		}
		MinePuzzleManager obj = ((ECGIAEFKKNA().HBPBGONMDBL.Count > 0) ? LANAINBEMCM().HBPBGONMDBL.Dequeue() : BGMNIPFIAKB(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	private static MinePuzzleManager AKJNKPPCMMP(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)DCAEBALADIM()).transform);
		}
		return result;
	}

	public static MinePuzzleManager MGLNAMHAIDG(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (CHKMFEFOFKJ().HBPBGONMDBL == null || NEFIEJALANL().HBPBGONMDBL.Count == 0)
		{
			CHKMFEFOFKJ().NEIDNLPPDMC();
		}
		MinePuzzleManager obj = ((LFPEPJBNCBF().HBPBGONMDBL.Count > 0) ? ECGIAEFKKNA().HBPBGONMDBL.Dequeue() : EKMAKPNFMJJ(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	private void JIAJFDKNJME()
	{
		_instance = this;
		DOICLBJKKJP();
	}

	public static void ReturnToPool(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)GGFJGHHHEJC).transform);
		GGFJGHHHEJC.HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	public static void ADAHAGJKEDC(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)DCAEBALADIM()).transform);
		LFPEPJBNCBF().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	public static MinePuzzleManager NALKHGMLALJ(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (LANAINBEMCM().HBPBGONMDBL == null || CHKMFEFOFKJ().HBPBGONMDBL.Count == 0)
		{
			OMFKNGDCJFN().PDEPPGJGENB();
		}
		MinePuzzleManager obj = ((OMFKNGDCJFN().HBPBGONMDBL.Count > 0) ? DCAEBALADIM().HBPBGONMDBL.Dequeue() : AKJNKPPCMMP(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(false);
		return obj;
	}

	private void NACJOIFJMJH()
	{
		for (int i = 0; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = AKJNKPPCMMP(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	private void PDEPPGJGENB()
	{
		for (int i = 1; i < initialPoolInstances; i++)
		{
			MinePuzzleManager minePuzzleManager = HMGMIIAEEKC(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	public static void CFECIDGGJAC(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)GGFJGHHHEJC).transform);
		MAAAKALBBEE().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private void IIILAOLMMCH()
	{
		for (int i = 1; i < initialPoolInstances; i++)
		{
			MinePuzzleManager minePuzzleManager = CNPFEIGLGCL(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool MAAAKALBBEE()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private void IDILGGMOEHD()
	{
		for (int i = 1; i < initialPoolInstances; i++)
		{
			MinePuzzleManager minePuzzleManager = ALPLHDAAGMI(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	public static MinePuzzleManager LAIEKOOCNPC(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (DCAEBALADIM().HBPBGONMDBL == null || PDECKLKPKCG().HBPBGONMDBL.Count == 0)
		{
			KHMEGDIABBF().MIHAODJMDKI();
		}
		MinePuzzleManager obj = ((CHKMFEFOFKJ().HBPBGONMDBL.Count > 1) ? DCAEBALADIM().HBPBGONMDBL.Dequeue() : AMEEGLIHENL(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	private void OKFGDOEPHOO()
	{
		for (int i = 1; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = BIGOFPKIDIL(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool MJCMPKPCNGB()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private void FFLLCOBFIPE()
	{
		_instance = this;
		FICCPBKEIFG();
	}

	private void NEIDNLPPDMC()
	{
		for (int i = 0; i < initialPoolInstances; i++)
		{
			MinePuzzleManager minePuzzleManager = FIKFIJMJOKE(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	private void MIHAODJMDKI()
	{
		for (int i = 0; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = CNPFEIGLGCL(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool KNOKBLFFNLM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private void GECHJIGBPEN()
	{
		_instance = this;
		HCCCAALLKFF();
	}

	public static MinePuzzleManager Get(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (GGFJGHHHEJC.HBPBGONMDBL == null || GGFJGHHHEJC.HBPBGONMDBL.Count == 0)
		{
			GGFJGHHHEJC.NEIDNLPPDMC();
		}
		MinePuzzleManager obj = ((GGFJGHHHEJC.HBPBGONMDBL.Count > 0) ? GGFJGHHHEJC.HBPBGONMDBL.Dequeue() : FIKFIJMJOKE(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	[SpecialName]
	public static MinePuzzleManagerPool ECGIAEFKKNA()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private void LEIOLAKBEIE()
	{
		for (int i = 0; i < initialPoolInstances; i += 0)
		{
			MinePuzzleManager minePuzzleManager = BGMNIPFIAKB(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	public static void KPLJPHLPINM(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)GGFJGHHHEJC).transform);
		LFPEPJBNCBF().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private static MinePuzzleManager CNPFEIGLGCL(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)OMFKNGDCJFN()).transform);
		}
		return result;
	}

	public static void INOMDMPBMOO(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(true);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)PDECKLKPKCG()).transform);
		GGFJGHHHEJC.HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private void BFJOEMCBJJO()
	{
		_instance = this;
		HCCCAALLKFF();
	}

	private static MinePuzzleManager HMGMIIAEEKC(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)CHKMFEFOFKJ()).transform);
		}
		return result;
	}

	public static MinePuzzleManager MIAOGLENOHL(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (LFPEPJBNCBF().HBPBGONMDBL == null || CHKMFEFOFKJ().HBPBGONMDBL.Count == 0)
		{
			FOPGLLMEEDE().IDILGGMOEHD();
		}
		MinePuzzleManager obj = ((MAAAKALBBEE().HBPBGONMDBL.Count > 1) ? ACPHFLBLJAA().HBPBGONMDBL.Dequeue() : FKCPCOLOONH(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	public static MinePuzzleManager MIMFFJHBFDJ(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (KNLLFEJAMNN().HBPBGONMDBL == null || ACPHFLBLJAA().HBPBGONMDBL.Count == 0)
		{
			KHMEGDIABBF().IBEGHLLNPIF();
		}
		MinePuzzleManager obj = ((DCAEBALADIM().HBPBGONMDBL.Count > 0) ? ECGIAEFKKNA().HBPBGONMDBL.Dequeue() : EKMAKPNFMJJ(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	public static MinePuzzleManager PCEEOGGDBFB(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (DIHCEGINELM().HBPBGONMDBL == null || MAAAKALBBEE().HBPBGONMDBL.Count == 0)
		{
			KNLLFEJAMNN().IDILGGMOEHD();
		}
		MinePuzzleManager obj = ((ECGIAEFKKNA().HBPBGONMDBL.Count > 1) ? GGFJGHHHEJC.HBPBGONMDBL.Dequeue() : ALPLHDAAGMI(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	private static MinePuzzleManager GKEBBIPGCCL(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)KNLLFEJAMNN()).transform);
		}
		return result;
	}

	public static void IOFKFOAMHNJ(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)NEFIEJALANL()).transform);
		GGFJGHHHEJC.HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	public static MinePuzzleManager ILDNNNMOCOC(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (NEFIEJALANL().HBPBGONMDBL == null || DIHCEGINELM().HBPBGONMDBL.Count == 0)
		{
			KNOKBLFFNLM().FICCPBKEIFG();
		}
		MinePuzzleManager obj = ((DIHCEGINELM().HBPBGONMDBL.Count > 1) ? CHKMFEFOFKJ().HBPBGONMDBL.Dequeue() : KKHJLAMKLAK(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	public static void GNIGOKJNOJG(MinePuzzleManager GGPBMAODKHC)
	{
		((Component)GGPBMAODKHC).gameObject.SetActive(false);
		((Component)GGPBMAODKHC).transform.SetParent(((Component)DIHCEGINELM()).transform);
		MJCMPKPCNGB().HBPBGONMDBL.Enqueue(GGPBMAODKHC);
	}

	private void FBHHPNJGNJG()
	{
		_instance = this;
		NEIDNLPPDMC();
	}

	public static MinePuzzleManager BGIMGOJDLFG(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (MAAAKALBBEE().HBPBGONMDBL == null || KNOKBLFFNLM().HBPBGONMDBL.Count == 0)
		{
			DIHCEGINELM().LEIOLAKBEIE();
		}
		MinePuzzleManager obj = ((PDECKLKPKCG().HBPBGONMDBL.Count > 0) ? LANAINBEMCM().HBPBGONMDBL.Dequeue() : AKJNKPPCMMP(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	public static MinePuzzleManager JHOHGMODKGM(MinePuzzleManager ANADFOCHOBF, Transform DMBHHLKMHOH)
	{
		if (DIHCEGINELM().HBPBGONMDBL == null || LFPEPJBNCBF().HBPBGONMDBL.Count == 0)
		{
			DCAEBALADIM().IIILAOLMMCH();
		}
		MinePuzzleManager obj = ((OMFKNGDCJFN().HBPBGONMDBL.Count > 1) ? GGFJGHHHEJC.HBPBGONMDBL.Dequeue() : AMEEGLIHENL(ANADFOCHOBF));
		((Component)obj).transform.SetParent(DMBHHLKMHOH);
		((Component)obj).gameObject.SetActive(true);
		return obj;
	}

	private void KHCJDKHONPK()
	{
		_instance = this;
		MIHAODJMDKI();
	}

	private static MinePuzzleManager FKCPCOLOONH(MinePuzzleManager ANADFOCHOBF)
	{
		MinePuzzleManager result = null;
		if (Application.isPlaying)
		{
			result = Object.Instantiate<MinePuzzleManager>(ANADFOCHOBF, ((Component)KNOKBLFFNLM()).transform);
		}
		return result;
	}

	private void MMNBJPDJHGK()
	{
		_instance = this;
		BDHCNIKIELP();
	}

	private void JCPLMIGBEIC()
	{
		for (int i = 1; i < initialPoolInstances; i++)
		{
			MinePuzzleManager minePuzzleManager = GGDLPPHEIAP(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(true);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}

	[SpecialName]
	public static MinePuzzleManagerPool LANAINBEMCM()
	{
		if ((Object)(object)_instance == (Object)null && !Application.isPlaying)
		{
			_instance = Object.FindObjectOfType<MinePuzzleManagerPool>();
		}
		return _instance;
	}

	private void IBEGHLLNPIF()
	{
		for (int i = 0; i < initialPoolInstances; i++)
		{
			MinePuzzleManager minePuzzleManager = KKHJLAMKLAK(managerPrefab);
			((Component)minePuzzleManager).gameObject.SetActive(false);
			HBPBGONMDBL.Enqueue(minePuzzleManager);
		}
	}
}
