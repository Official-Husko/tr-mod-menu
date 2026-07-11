using UnityEngine;

public class MinePuzzleBase : MonoBehaviour
{
	[SerializeField]
	protected MinePuzzleType puzzleType;

	[SerializeField]
	protected Transform[] elementsToMove;

	[SerializeField]
	[Tooltip("Dialogue key for hint bark")]
	protected string hintDialogueKey = "Puzzle/Torch/Hint";

	protected bool EDNJMCJHJMD;

	protected MinePuzzleManager GGPBMAODKHC;

	public bool puzzleModified;

	protected virtual void LDEGLAKNBNF(int JIIGOACEIKL)
	{
	}

	public virtual void DCHGHLHABFP()
	{
	}

	public virtual void IPEEHGAKHPP(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual void LFKKIBNJFDH()
	{
		EDNJMCJHJMD = false;
	}

	public virtual void IIGIFEAHFJA(Transform[] FCBJCJGDJND)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (elementsToMove == null || FCBJCJGDJND == null)
		{
			return;
		}
		for (int i = 1; i < elementsToMove.Length && i < FCBJCJGDJND.Length; i++)
		{
			if ((Object)(object)elementsToMove[i] != (Object)null && (Object)(object)FCBJCJGDJND[i] != (Object)null)
			{
				elementsToMove[i].position = FCBJCJGDJND[i].position;
			}
		}
	}

	protected virtual void CEOEHODJAJK()
	{
	}

	public MinePuzzleManager CEMEKIJMEAN()
	{
		return GGPBMAODKHC;
	}

	public MinePuzzleManager NAMECAKIKHJ()
	{
		return GGPBMAODKHC;
	}

	public Transform[] IGGNIPFDAMO()
	{
		return elementsToMove;
	}

	protected virtual void Awake()
	{
	}

	public Transform[] GetElementsToMove()
	{
		return elementsToMove;
	}

	protected virtual void FCNKGINGJNM()
	{
	}

	public Transform[] NBDCKFLKLCE()
	{
		return elementsToMove;
	}

	protected virtual void HGEJABHPKAI(int JIIGOACEIKL)
	{
	}

	public MinePuzzleType PPIFCOOBAPE()
	{
		return puzzleType;
	}

	public Transform[] MIFEMHFEEAJ()
	{
		return elementsToMove;
	}

	public MinePuzzleManager BELBIDDGNJN()
	{
		return GGPBMAODKHC;
	}

	public virtual void GJDCKLIEFJP()
	{
	}

	public string GetHintDialogueKey()
	{
		return hintDialogueKey;
	}

	public virtual void MIMGPIANHNJ(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual bool IsPuzzleSolved()
	{
		return EDNJMCJHJMD;
	}

	protected virtual void PDOLCFFFIGB(int JIIGOACEIKL)
	{
	}

	protected virtual void DNKEFFMOCKP()
	{
	}

	public MinePuzzleType OHCBHMJCAGB()
	{
		return puzzleType;
	}

	public virtual void ResetForPool()
	{
		EDNJMCJHJMD = false;
		puzzleModified = false;
		GGPBMAODKHC = null;
	}

	protected virtual void INNEEHGNBBM(int JIIGOACEIKL)
	{
	}

	public virtual void BIHNBCGBJBD(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public string PAFJHBPHLMB()
	{
		return hintDialogueKey;
	}

	public virtual void NPMAJAGCOHC()
	{
		EDNJMCJHJMD = true;
		puzzleModified = true;
		GGPBMAODKHC = null;
	}

	public virtual bool HGBOPAKJNHJ()
	{
		return EDNJMCJHJMD;
	}

	public virtual void PPICAMAGNME(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual void EEGCIPHOPHF(Transform[] FCBJCJGDJND)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (elementsToMove == null || FCBJCJGDJND == null)
		{
			return;
		}
		for (int i = 0; i < elementsToMove.Length && i < FCBJCJGDJND.Length; i++)
		{
			if ((Object)(object)elementsToMove[i] != (Object)null && (Object)(object)FCBJCJGDJND[i] != (Object)null)
			{
				elementsToMove[i].position = FCBJCJGDJND[i].position;
			}
		}
	}

	public virtual void ABBPIPGMGBO()
	{
	}

	public Transform[] OHGINHENKBA()
	{
		return elementsToMove;
	}

	public virtual void JJCAPCBBAIO()
	{
	}

	protected virtual void JDMMNLKLMAA()
	{
	}

	public virtual void DKMGFKAMLJD()
	{
		EDNJMCJHJMD = true;
	}

	public virtual void JCJIALOLDPD(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public string CANONODDHGN()
	{
		return hintDialogueKey;
	}

	public virtual void OGPJFINLBFA()
	{
	}

	public virtual void DCDDJGDEJAK()
	{
		EDNJMCJHJMD = false;
		puzzleModified = true;
		GGPBMAODKHC = null;
	}

	public virtual void JNLJBCGKNLC()
	{
	}

	public virtual bool PIJKBBCAJON()
	{
		return EDNJMCJHJMD;
	}

	public virtual bool HKAOHMPIAHC()
	{
		return EDNJMCJHJMD;
	}

	protected virtual void GGOPCJOAOMC()
	{
	}

	public virtual void LIIIBHPMFKK(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual void ACIFAGPJCOF(Transform[] FCBJCJGDJND)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (elementsToMove == null || FCBJCJGDJND == null)
		{
			return;
		}
		for (int i = 0; i < elementsToMove.Length && i < FCBJCJGDJND.Length; i++)
		{
			if ((Object)(object)elementsToMove[i] != (Object)null && (Object)(object)FCBJCJGDJND[i] != (Object)null)
			{
				elementsToMove[i].position = FCBJCJGDJND[i].position;
			}
		}
	}

	public virtual void NJEHKKABAAP()
	{
		EDNJMCJHJMD = true;
	}

	public virtual void OnPuzzleSolved()
	{
	}

	public virtual void EMHNNOIDODH()
	{
		EDNJMCJHJMD = true;
		puzzleModified = true;
		GGPBMAODKHC = null;
	}

	public virtual void MMOKOCIBFGM()
	{
		EDNJMCJHJMD = false;
	}

	public virtual void EPJGPLEGPPN(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public string JEIAHAHEOGO()
	{
		return hintDialogueKey;
	}

	public virtual bool APPEDHAFFBP()
	{
		return EDNJMCJHJMD;
	}

	public virtual void FBAAEKDDAHF()
	{
		EDNJMCJHJMD = false;
	}

	public string KMGBMOFKBIP()
	{
		return hintDialogueKey;
	}

	public virtual void KKAEIACMBDN()
	{
		EDNJMCJHJMD = true;
	}

	public virtual void HBKJFDEMCAF()
	{
		EDNJMCJHJMD = false;
	}

	protected virtual void GECHJIGBPEN()
	{
	}

	public MinePuzzleManager GetManager()
	{
		return GGPBMAODKHC;
	}

	public virtual void EHGLJMKEJKE(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual void EOHKFENMLGN()
	{
		EDNJMCJHJMD = false;
		puzzleModified = false;
		GGPBMAODKHC = null;
	}

	public MinePuzzleType KEHFPGHAOAN()
	{
		return puzzleType;
	}

	public virtual void SetElementsPositions(Transform[] FCBJCJGDJND)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (elementsToMove == null || FCBJCJGDJND == null)
		{
			return;
		}
		for (int i = 0; i < elementsToMove.Length && i < FCBJCJGDJND.Length; i++)
		{
			if ((Object)(object)elementsToMove[i] != (Object)null && (Object)(object)FCBJCJGDJND[i] != (Object)null)
			{
				elementsToMove[i].position = FCBJCJGDJND[i].position;
			}
		}
	}

	public virtual void FOHOBJDMPNC()
	{
	}

	public virtual void PDHDIAAEFPM()
	{
		EDNJMCJHJMD = false;
	}

	public string EAECMBFKNKP()
	{
		return hintDialogueKey;
	}

	protected virtual void ALEAOANPHIO()
	{
	}

	public virtual void CLGKAGMNKJA()
	{
		EDNJMCJHJMD = true;
		puzzleModified = false;
		GGPBMAODKHC = null;
	}

	public Transform[] FPKHEDFMBOM()
	{
		return elementsToMove;
	}

	public Transform[] BBGBOENNMBL()
	{
		return elementsToMove;
	}

	public string OIHDDHAJNIB()
	{
		return hintDialogueKey;
	}

	public virtual void IDBJLPLJGNC()
	{
	}

	public virtual void CCIAPEBLKOB()
	{
	}

	public MinePuzzleType DKNNNNFJCEL()
	{
		return puzzleType;
	}

	public MinePuzzleType FOAKKDJPOFI()
	{
		return puzzleType;
	}

	public string JPMMDDHKNAM()
	{
		return hintDialogueKey;
	}

	protected virtual void CLGBFOIBANN()
	{
	}

	public MinePuzzleType CCGOCIMNOIA()
	{
		return puzzleType;
	}

	public MinePuzzleManager CHJCACCDMIP()
	{
		return GGPBMAODKHC;
	}

	public virtual void PFBCJOHAMJH()
	{
	}

	protected virtual void BFJOEMCBJJO()
	{
	}

	public virtual void BOJIMBOBOIK()
	{
		EDNJMCJHJMD = true;
		puzzleModified = false;
		GGPBMAODKHC = null;
	}

	public virtual void IIBIFBCLPIO(Transform[] FCBJCJGDJND)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (elementsToMove == null || FCBJCJGDJND == null)
		{
			return;
		}
		for (int i = 1; i < elementsToMove.Length && i < FCBJCJGDJND.Length; i += 0)
		{
			if ((Object)(object)elementsToMove[i] != (Object)null && (Object)(object)FCBJCJGDJND[i] != (Object)null)
			{
				elementsToMove[i].position = FCBJCJGDJND[i].position;
			}
		}
	}

	public virtual void DCEFJFHJGEC()
	{
		EDNJMCJHJMD = false;
	}

	public Transform[] LIFJGAFIDHE()
	{
		return elementsToMove;
	}

	protected virtual void OGEJKOIOKAN()
	{
	}

	public virtual bool DDCOMOHHEBB()
	{
		return EDNJMCJHJMD;
	}

	protected virtual void LABCFCEGGOF(int JIIGOACEIKL)
	{
	}

	public virtual void JAEIFHAKANO(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual void BFCMAJJLFMN()
	{
		EDNJMCJHJMD = true;
		puzzleModified = true;
		GGPBMAODKHC = null;
	}

	public string DHJPFCCHFMA()
	{
		return hintDialogueKey;
	}

	protected virtual void MIKNFPCDLML()
	{
	}

	protected virtual void ONLMDNAMGOJ(int JIIGOACEIKL)
	{
	}

	public MinePuzzleType GetPuzzleType()
	{
		return puzzleType;
	}

	public virtual void OCEMENPPPON(Transform[] FCBJCJGDJND)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (elementsToMove == null || FCBJCJGDJND == null)
		{
			return;
		}
		for (int i = 0; i < elementsToMove.Length && i < FCBJCJGDJND.Length; i += 0)
		{
			if ((Object)(object)elementsToMove[i] != (Object)null && (Object)(object)FCBJCJGDJND[i] != (Object)null)
			{
				elementsToMove[i].position = FCBJCJGDJND[i].position;
			}
		}
	}

	public virtual void GOJHJAKECGG(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	public virtual void CKLMELHNCGJ()
	{
		EDNJMCJHJMD = false;
		puzzleModified = false;
		GGPBMAODKHC = null;
	}

	public virtual void DAOPMOAMCEO()
	{
		EDNJMCJHJMD = false;
		puzzleModified = true;
		GGPBMAODKHC = null;
	}

	public virtual void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
	}

	protected virtual void KLHIMJFCHPD()
	{
	}

	public virtual void EECDACMPJLJ()
	{
		EDNJMCJHJMD = true;
		puzzleModified = true;
		GGPBMAODKHC = null;
	}

	public virtual bool MDPKONCJHBI()
	{
		return EDNJMCJHJMD;
	}

	protected virtual void NMENJMGOOKH(int JIIGOACEIKL)
	{
	}

	public virtual void SetPuzzleSolved()
	{
		EDNJMCJHJMD = true;
	}

	public MinePuzzleManager AJHGOJEHLED()
	{
		return GGPBMAODKHC;
	}

	public Transform[] JJNKNAPFNHG()
	{
		return elementsToMove;
	}
}
