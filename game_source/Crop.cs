using UnityEngine;

[CreateAssetMenu(menuName = "Game/Crop")]
public class Crop : ScriptableObject
{
	public int id;

	public string nameId;

	public Item seed;

	public Sprite[] growingSprites;

	public Sprite[] growingSpritesBack;

	public ItemAmount[] harvestedItems;

	public int daysToGrow = 1;

	public bool reusable;

	public int daysUntilNewHarvest;

	public Sprite fruit1Sprite;

	public Sprite fruit2Sprite;

	public GameObject prefab;

	public CropSeason avaliableSeasons = CropSeason.All;

	public CropSeason bestSeasons;

	public int amountBestSeason;

	public int deadSpriteNum;

	public GameObject[] growablePrefabs;

	public string LOMLPPEKPJB()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string LLCIGPBKIOJ()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string GDMNJCMLDCN()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string LIJLCLGPPHB()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject BIHPDLAGCEO(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public GameObject FNILKBLEDKJ(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public string BKLFJPCLOAH()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string IABAKHPEOAF()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject HCJDENELHAE(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public string IHPEMJCKHLG()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string JLEFCPJPOEO()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string PPMBMNKADMO()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string ONMFAMHKGLA()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string OCKFMDJHCHF()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string JMPEOOOGLGD()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject MENLFCBEKCA(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().cropPrefab, DMBHHLKMHOH);
	}

	public string GGKJJFDLAJB()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string FHHKMIBAEFO()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject MEBBBKEBCAA(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().cropPrefab, DMBHHLKMHOH);
	}

	public string GHJLPCCHDJO()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject EEJEAIMINGC(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public string NPDJPAIIEMN()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject FCMAIEBPDEE(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().cropPrefab, DMBHHLKMHOH);
	}

	public string EBCCOFBEGHO()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string PEFMPFLDHHL()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string NAMHLLJOPAI()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject IHKOPDFLEMF(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public string PJLOFBHIFJA()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string IFLPIPINLIM()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject MJIADAIECPA(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().cropPrefab, DMBHHLKMHOH);
	}

	public string AICOMMNDJLI()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string GDBLECDHLHF()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject PIICNMOPGAI(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public string KFNBHNHHIOM()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject AEAEBOMKBEK(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().cropPrefab, DMBHHLKMHOH);
	}

	public string BNGALMCLPBE()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject HDAPCPMIJEM(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().cropPrefab, DMBHHLKMHOH);
	}

	public GameObject CCLCJJPPJOA(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public GameObject AGBHNBOPHAO(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}

	public string LCNIPHCFGPM()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string CEFGEJAMLGN()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string MDOPGLDJJEA()
	{
		string text = LocalisationSystem.Get(nameId);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public GameObject EBAJEPAHFOJ(Transform DMBHHLKMHOH)
	{
		if ((Object)(object)prefab != (Object)null)
		{
			return Object.Instantiate<GameObject>(prefab, DMBHHLKMHOH);
		}
		return Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.cropPrefab, DMBHHLKMHOH);
	}
}
