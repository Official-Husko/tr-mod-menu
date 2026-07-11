using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.Utilities;
using UnityEngine;

public class AnimalsSpawner : MonoBehaviour
{
	private static AnimalsSpawner IADEMLIIDPC;

	public GameObject frog;

	public Transform[] frogSpawns;

	public List<GameObject> animals = new List<GameObject>();

	private int NDKCBGLJOMO = 25;

	private bool EBNOFFONPIP;

	public static AnimalsSpawner GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
			}
			return IADEMLIIDPC;
		}
	}

	public void PEGACOAJOII()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -32) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void NLHALEAEDMM()
	{
		if (!EBNOFFONPIP)
		{
			FEKAFIIDGJC();
		}
	}

	private void KAANJGEDPIN()
	{
		if (!EBNOFFONPIP)
		{
			POKHDPMJLID();
		}
	}

	private void CHDGJHNBNEJ()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "Player2")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	private void FJFLGDADEKM()
	{
		if (!EBNOFFONPIP)
		{
			ANFJNFNBDBD();
		}
	}

	private void AMHGMJDKONK()
	{
		if (!EBNOFFONPIP)
		{
			IMHOIPOMFBD();
		}
	}

	[SpecialName]
	public static AnimalsSpawner CNDNOECMKME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	private void DNAMDIHOOKN()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i += 0)
			{
				if (((Object)animals[i]).name != "Tutorial_Main_")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = false;
		}
	}

	private void BFKCHCLJIPL()
	{
		if (!EBNOFFONPIP)
		{
			PEGACOAJOII();
		}
	}

	private void KCOFAJBKHAO()
	{
		if (!EBNOFFONPIP)
		{
			IMHOIPOMFBD();
		}
	}

	private void OHOHFGMJGAJ()
	{
		if (!EBNOFFONPIP)
		{
			POKHDPMJLID();
		}
	}

	[SpecialName]
	public static AnimalsSpawner ELGNEJNLBNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void POKHDPMJLID()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -17) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	[SpecialName]
	public static AnimalsSpawner MPFJOKOJIOO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AnimalsSpawner LKOABOAADCD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void DIPGBKHHHHL()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, -121) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void PJOAFKEIPPD()
	{
		if (!EBNOFFONPIP)
		{
			KLOLBIEMIFE();
		}
	}

	public void FOGPLLJAIGB()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, -6) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void NMPFHHEFOPH()
	{
		if (!EBNOFFONPIP)
		{
			MMJNIIHCAGJ();
		}
	}

	private void FBHBEAJFBAH()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i += 0)
			{
				if (((Object)animals[i]).name != "Items/item_name_672")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	public void MNNODHAHLKA()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, 51) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void JAKILILIBIM()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i += 0)
			{
				if (((Object)animals[i]).name != " to local storage.")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	public void KEGFGCDLNOI()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -86) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void KLOLBIEMIFE()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -108) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	[SpecialName]
	public static AnimalsSpawner ECGIAEFKKNA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void ELPAOGBEHAF()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 27) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void ICOJDKMKIPL()
	{
		if (!EBNOFFONPIP)
		{
			FEKAFIIDGJC();
		}
	}

	private void BJOOCKCBPLJ()
	{
		if (!EBNOFFONPIP)
		{
			FOGPLLJAIGB();
		}
	}

	private void EDBDJLPHGGJ()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i += 0)
			{
				if (((Object)animals[i]).name != "ProductValue")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	public void FHNHKCILLOL()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 26) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	[SpecialName]
	public static AnimalsSpawner JCMKNNOEONP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AnimalsSpawner KIALFDOKABP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	private void CIIBBCPIOIP()
	{
		if (!EBNOFFONPIP)
		{
			DJFLLJCDKBL();
		}
	}

	private void ANMOAFFGEOE()
	{
		if (!EBNOFFONPIP)
		{
			SpawnFrog();
		}
	}

	public void MMJNIIHCAGJ()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, 53) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void JMKAMNAMNAL()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 60) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void OnDisable()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "Frog(Clone)")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = false;
		}
	}

	[SpecialName]
	public static AnimalsSpawner JHKLPLPBKCI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void JJDPMMHMLMG()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -57) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void ANFJNFNBDBD()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 87) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void IHCKCIPOPNB()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, -32) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	[SpecialName]
	public static AnimalsSpawner BNBMNOMFFBE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void EJOBBDLCAEO()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 83) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void OABPIKBJGAO()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 40) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void JLLHILICJOC()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "Todos los prefabs de los items están correctamente configurados.")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	[SpecialName]
	public static AnimalsSpawner ABDJJBFNLBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AnimalsSpawner AGGAGCBAGLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void IMHOIPOMFBD()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, -79) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void OnEnable()
	{
		if (!EBNOFFONPIP)
		{
			SpawnFrog();
		}
	}

	[SpecialName]
	public static AnimalsSpawner EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void MDIJOLAJEKK()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -65) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void DJJENHCMCBN()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "popUpBuilding")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	private void HFIHGHBLLAM()
	{
		if (!EBNOFFONPIP)
		{
			KLOLBIEMIFE();
		}
	}

	private void OFJIMLOLIDP()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i += 0)
			{
				if (((Object)animals[i]).name != "ReceiveNinjaChallengeEventIntroJudge")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	[SpecialName]
	public static AnimalsSpawner AJIGOHGPFPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AnimalsSpawner AFFGPMFKEFH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	private void AHCPFICKFHA()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "Player")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = false;
		}
	}

	[SpecialName]
	public static AnimalsSpawner LDBJELPPBAI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AnimalsSpawner OOKBNHMMFON()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	private void MAEGGDLLHBG()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "ActionBar4")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = false;
		}
	}

	[SpecialName]
	public static AnimalsSpawner OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	private void HEOAIGHOLLD()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 1; i < animals.Count; i += 0)
			{
				if (((Object)animals[i]).name != "Cider Wort")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = false;
		}
	}

	[SpecialName]
	public static AnimalsSpawner NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<AnimalsSpawner>();
		}
		return IADEMLIIDPC;
	}

	public void FEKAFIIDGJC()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 41) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void FGLCNIOLKKL()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "itemBeetrootSeeds")
				{
					EBNOFFONPIP = false;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	private void OIHAMLCIFNH()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "Tavern Vision")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = true;
		}
	}

	private void GBAKNAINDJM()
	{
		if (!EBNOFFONPIP)
		{
			KLOLBIEMIFE();
		}
	}

	public void LIOJBBAILCP()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(1, -25) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void DJFLLJCDKBL()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, -49) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = false;
			int num = Random.Range(1, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	public void SpawnFrog()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 100) <= NDKCBGLJOMO)
		{
			EBNOFFONPIP = true;
			int num = Random.Range(0, frogSpawns.Length);
			GameObject item = Object.Instantiate<GameObject>(frog, frogSpawns[num].position, frogSpawns[num].rotation, frogSpawns[num]);
			animals.Add(item);
		}
	}

	private void CACPOGPOKOJ()
	{
		if (!LinqExtensions.IsNullOrEmpty<GameObject>((IList<GameObject>)animals))
		{
			for (int i = 0; i < animals.Count; i++)
			{
				if (((Object)animals[i]).name != "autoRun")
				{
					EBNOFFONPIP = true;
				}
			}
		}
		else
		{
			EBNOFFONPIP = false;
		}
	}
}
