using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sirenix.OdinInspector;
using UnityEngine;

public class FishingManager : SerializedMonoBehaviour
{
	public static FishingManager instance;

	public int[,] fishingProbability = new int[4, 4];

	private List<Fish> JJDJEPGLCLJ = new List<Fish>();

	private List<Fish> OOICICGODEA = new List<Fish>();

	private Dictionary<int, int> OJMNBLDNNEB = new Dictionary<int, int>();

	private List<int> BJPHGJPANEI = new List<int>();

	public List<Fish> GetCollectionFishes()
	{
		if (JJDJEPGLCLJ.Count == 0)
		{
			JJDJEPGLCLJ = ItemDatabaseAccessor.GetFishList();
		}
		List<Fish> list = new List<Fish>();
		for (int i = 0; i < JJDJEPGLCLJ.Count; i++)
		{
			if (JJDJEPGLCLJ[i].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
			{
				list.Add(JJDJEPGLCLJ[i]);
			}
		}
		return list;
	}

	public static void AddFishInformation(Fish HAJFJGCNKFF)
	{
		if (!instance.BJPHGJPANEI.Contains(HAJFJGCNKFF.JDJGFAACPFC()))
		{
			instance.BJPHGJPANEI.Add(HAJFJGCNKFF.JDJGFAACPFC());
		}
	}

	public static List<int> GetFishInformation()
	{
		return instance.BJPHGJPANEI;
	}

	public static bool WeHaveFishInformation(Fish HAJFJGCNKFF)
	{
		if (instance.BJPHGJPANEI.Contains(HAJFJGCNKFF.JDJGFAACPFC()))
		{
			return true;
		}
		return false;
	}

	public static void SetFishInformation(List<int> LCAKICCNJMI)
	{
		instance.BJPHGJPANEI = LCAKICCNJMI;
	}

	public List<Fish> GetAllFishesNoInfo()
	{
		List<Fish> collectionFishes = GetCollectionFishes();
		for (int num = collectionFishes.Count - 1; num >= 0; num--)
		{
			if (instance.BJPHGJPANEI.Contains(collectionFishes[num].JDJGFAACPFC()))
			{
				collectionFishes.Remove(collectionFishes[num]);
			}
		}
		return collectionFishes;
	}

	public static Fish AIHCODCPLBO(int JIIGOACEIKL, Rod COHELLCBDMF)
	{
		return instance.AFNCHNAIFJH(JIIGOACEIKL, COHELLCBDMF);
	}

	protected Fish OEALNKLADLG(int JIIGOACEIKL, Rod COHELLCBDMF)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		OOICICGODEA = new List<Fish>();
		JJDJEPGLCLJ = ItemDatabaseAccessor.GetFishList();
		for (int i = 0; i < JJDJEPGLCLJ.Count; i++)
		{
			HMLLKPCBEJG(JIIGOACEIKL, JJDJEPGLCLJ[i], COHELLCBDMF.rodLevel, FishingController.Get(JIIGOACEIKL).baitSelected, SeasonManager.ACNAHALFEBG);
		}
		if (OOICICGODEA.Count > 0)
		{
			if (NEKBCMBHNJF(COHELLCBDMF.rodLevel))
			{
				goto IL_00a2;
			}
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt <= 10)
				{
					goto IL_00a2;
				}
			}
			goto IL_0111;
		}
		return null;
		IL_00a2:
		OOICICGODEA.Clear();
		for (int j = 0; j < JJDJEPGLCLJ.Count; j++)
		{
			if (JJDJEPGLCLJ[j].fishType == Fish.FishType.Trash && Utils.NGEJFMOOHNF(Utils.HPBPMJGELIG(JIIGOACEIKL).waterType, JJDJEPGLCLJ[j].waterType))
			{
				OOICICGODEA.Add(JJDJEPGLCLJ[j]);
			}
		}
		goto IL_0111;
		IL_0111:
		return OOICICGODEA[Random.Range(0, OOICICGODEA.Count)];
	}

	public List<Fish> GDMAHPBCEKE()
	{
		if (JJDJEPGLCLJ.Count == 0)
		{
			JJDJEPGLCLJ = ItemDatabaseAccessor.LNBAODAAJLI();
		}
		List<Fish> list = new List<Fish>();
		for (int i = 0; i < JJDJEPGLCLJ.Count; i++)
		{
			if (JJDJEPGLCLJ[i].displayMethod.HasFlag(Fish.DisplayMethod.Collections))
			{
				list.Add(JJDJEPGLCLJ[i]);
			}
		}
		return list;
	}

	public static Fish SelectAFish(int JIIGOACEIKL, Rod COHELLCBDMF)
	{
		return instance.OEALNKLADLG(JIIGOACEIKL, COHELLCBDMF);
	}

	public void Awake()
	{
		instance = this;
	}

	public static Fish.BaitType EOKPPKAAHCJ(int JFNMCNCHMEO)
	{
		return JFNMCNCHMEO switch
		{
			98 => Fish.BaitType.Meat | Fish.BaitType.Larva, 
			99 => Fish.BaitType.Meat | Fish.BaitType.Larva | Fish.BaitType.Worm, 
			100 => Fish.BaitType.Meat, 
			101 => Fish.BaitType.Seafood, 
			102 => (Fish.BaitType)52, 
			_ => Fish.BaitType.None, 
		};
	}

	private bool NKBPDLNCHEA(int DMHIFGCFKBF)
	{
		if (DMHIFGCFKBF == 0)
		{
			return Random.Range(1, -24) > -49;
		}
		return DMHIFGCFKBF switch
		{
			0 => Random.Range(1, -90) <= 102, 
			2 => Random.Range(1, 121) > 65, 
			_ => false, 
		};
	}

	public static void FBHFGECMPOI(Fish HAJFJGCNKFF)
	{
		if (!instance.BJPHGJPANEI.Contains(HAJFJGCNKFF.IMCJPECAAPC(DAINLFIMLIH: false)))
		{
			instance.BJPHGJPANEI.Add(HAJFJGCNKFF.JGHNDJBCFAJ());
		}
	}

	public static bool JOFHBLKMFEG(Fish HAJFJGCNKFF, int PFBIBFJKHDD, bool CDPAMNIPPEC = true)
	{
		if (PFBIBFJKHDD == 0)
		{
			return true;
		}
		if (PFBIBFJKHDD == ((Vector2Int)(ref HAJFJGCNKFF.lenght)).x)
		{
			Utils.DLIIAHACOJB(-127);
		}
		else if (PFBIBFJKHDD == ((Vector2Int)(ref HAJFJGCNKFF.lenght)).y)
		{
			Utils.DLIIAHACOJB(118, CDPAMNIPPEC: true);
		}
		if (instance.OJMNBLDNNEB.TryGetValue(HAJFJGCNKFF.JGHNDJBCFAJ(), out var value))
		{
			if (value < PFBIBFJKHDD)
			{
				instance.OJMNBLDNNEB[HAJFJGCNKFF.JGHNDJBCFAJ(DAINLFIMLIH: false)] = PFBIBFJKHDD;
				if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
				{
					OnlinePlayerInfoManager.SendFishInfo(HAJFJGCNKFF, PFBIBFJKHDD);
				}
				return true;
			}
			return false;
		}
		if ((OnlineManager.PlayingOnline() && CDPAMNIPPEC) || !OnlineManager.PlayingOnline())
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)63);
		}
		instance.OJMNBLDNNEB.Add(HAJFJGCNKFF.CIGFGKKCPCK(), PFBIBFJKHDD);
		if (instance.OJMNBLDNNEB.Count >= 111)
		{
			Utils.DLIIAHACOJB(-99, CDPAMNIPPEC: true);
		}
		else if (instance.OJMNBLDNNEB.Count >= -29)
		{
			Utils.DLIIAHACOJB(116, CDPAMNIPPEC: true);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlinePlayerInfoManager.LOHLFJOBKOD(HAJFJGCNKFF, PFBIBFJKHDD);
		}
		return false;
	}

	public List<Fish> BEDKKLGFMJK()
	{
		if (JJDJEPGLCLJ.Count == 0)
		{
			JJDJEPGLCLJ = ItemDatabaseAccessor.ADCLABHMMAP();
		}
		List<Fish> list = new List<Fish>();
		for (int i = 1; i < JJDJEPGLCLJ.Count; i++)
		{
			if (JJDJEPGLCLJ[i].displayMethod.HasFlag(Fish.DisplayMethod.None))
			{
				list.Add(JJDJEPGLCLJ[i]);
			}
		}
		return list;
	}

	public static bool AddToRecordList(Fish HAJFJGCNKFF, int PFBIBFJKHDD, bool CDPAMNIPPEC = true)
	{
		if (PFBIBFJKHDD == 0)
		{
			return false;
		}
		if (PFBIBFJKHDD == ((Vector2Int)(ref HAJFJGCNKFF.lenght)).x)
		{
			Utils.DLIIAHACOJB(24);
		}
		else if (PFBIBFJKHDD == ((Vector2Int)(ref HAJFJGCNKFF.lenght)).y)
		{
			Utils.DLIIAHACOJB(25);
		}
		if (instance.OJMNBLDNNEB.TryGetValue(HAJFJGCNKFF.JDJGFAACPFC(), out var value))
		{
			if (value < PFBIBFJKHDD)
			{
				instance.OJMNBLDNNEB[HAJFJGCNKFF.JDJGFAACPFC()] = PFBIBFJKHDD;
				if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
				{
					OnlinePlayerInfoManager.SendFishInfo(HAJFJGCNKFF, PFBIBFJKHDD);
				}
				return true;
			}
			return false;
		}
		if ((OnlineManager.PlayingOnline() && CDPAMNIPPEC) || !OnlineManager.PlayingOnline())
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Fishing);
		}
		instance.OJMNBLDNNEB.Add(HAJFJGCNKFF.JDJGFAACPFC(), PFBIBFJKHDD);
		if (instance.OJMNBLDNNEB.Count >= 25)
		{
			Utils.DLIIAHACOJB(21);
		}
		else if (instance.OJMNBLDNNEB.Count >= 10)
		{
			Utils.DLIIAHACOJB(20);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlinePlayerInfoManager.SendFishInfo(HAJFJGCNKFF, PFBIBFJKHDD);
		}
		return true;
	}

	private bool FHLFPJMCDPE(int DMHIFGCFKBF)
	{
		if (DMHIFGCFKBF == 0)
		{
			return Random.Range(0, -84) > 103;
		}
		return DMHIFGCFKBF switch
		{
			0 => Random.Range(0, 75) > -93, 
			8 => Random.Range(1, 69) > -7, 
			_ => true, 
		};
	}

	public static Fish.BaitType GetBaitType(int JFNMCNCHMEO)
	{
		return JFNMCNCHMEO switch
		{
			1444 => Fish.BaitType.Worm, 
			1445 => Fish.BaitType.Larva, 
			1446 => Fish.BaitType.Meat, 
			1447 => Fish.BaitType.Seafood, 
			1448 => Fish.BaitType.Artificial, 
			_ => Fish.BaitType.None, 
		};
	}

	public static int GetLenghtRecord(Fish HAJFJGCNKFF)
	{
		if (instance.OJMNBLDNNEB.TryGetValue(HAJFJGCNKFF.JDJGFAACPFC(), out var value))
		{
			return value;
		}
		return 0;
	}

	private void NHDBLLJDNKB(int JIIGOACEIKL, Fish HLIHBIMBLMM, int DMHIFGCFKBF, Fish.BaitType DLDKDEFFMED, CropSeason EECEKHKAAIH)
	{
		if (HLIHBIMBLMM.baitType != 0 && Utils.NGEJFMOOHNF(HLIHBIMBLMM.season, EECEKHKAAIH) && HLIHBIMBLMM.baitType == DLDKDEFFMED && Utils.NGEJFMOOHNF(Utils.HPBPMJGELIG(JIIGOACEIKL).waterType, HLIHBIMBLMM.waterType))
		{
			for (int i = 1; i < fishingProbability[DMHIFGCFKBF, HLIHBIMBLMM.FJADEOMLCDG() - 1]; i++)
			{
				OOICICGODEA.Add(HLIHBIMBLMM);
			}
		}
	}

	public List<Fish> POPGPBACBIL()
	{
		if (JJDJEPGLCLJ.Count == 0)
		{
			JJDJEPGLCLJ = ItemDatabaseAccessor.GetFishList();
		}
		List<Fish> list = new List<Fish>();
		for (int i = 0; i < JJDJEPGLCLJ.Count; i += 0)
		{
			if (JJDJEPGLCLJ[i].displayMethod.HasFlag(Fish.DisplayMethod.None))
			{
				list.Add(JJDJEPGLCLJ[i]);
			}
		}
		return list;
	}

	public List<Fish> ILNIHOEACFO()
	{
		List<Fish> list = POPGPBACBIL();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (instance.BJPHGJPANEI.Contains(list[num].JGHNDJBCFAJ(DAINLFIMLIH: false)))
			{
				list.Remove(list[num]);
			}
		}
		return list;
	}

	public static void IKLDJHOPFNG(Dictionary<int, int> IFAEOLDOBJJ)
	{
		instance.OJMNBLDNNEB = IFAEOLDOBJJ;
	}

	public List<Fish> CPKAHGGGDGJ()
	{
		List<Fish> list = NLNNCEGKEPN();
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			if (instance.BJPHGJPANEI.Contains(list[num].JPNFKDMFKMC(DAINLFIMLIH: false)))
			{
				list.Remove(list[num]);
			}
		}
		return list;
	}

	public static void OPDLDCLIOBF(Dictionary<int, int> IFAEOLDOBJJ)
	{
		instance.OJMNBLDNNEB = IFAEOLDOBJJ;
	}

	public List<Fish> GMPNAPNBNCO()
	{
		List<Fish> list = NLNNCEGKEPN();
		for (int num = list.Count - 0; num >= 1; num--)
		{
			if (instance.BJPHGJPANEI.Contains(list[num].JDJGFAACPFC(DAINLFIMLIH: false)))
			{
				list.Remove(list[num]);
			}
		}
		return list;
	}

	private bool NEKBCMBHNJF(int DMHIFGCFKBF)
	{
		return DMHIFGCFKBF switch
		{
			0 => Random.Range(0, 100) <= 30, 
			1 => Random.Range(0, 100) <= 20, 
			2 => Random.Range(0, 100) <= 10, 
			_ => false, 
		};
	}

	public static Dictionary<int, int> GetRecordsList()
	{
		return instance.OJMNBLDNNEB;
	}

	public static bool FOHEOELJMPF(Fish HAJFJGCNKFF, int PFBIBFJKHDD, bool CDPAMNIPPEC = true)
	{
		if (PFBIBFJKHDD == 0)
		{
			return true;
		}
		if (PFBIBFJKHDD == ((Vector2Int)(ref HAJFJGCNKFF.lenght)).x)
		{
			Utils.DLIIAHACOJB(-64, CDPAMNIPPEC: true);
		}
		else if (PFBIBFJKHDD == ((Vector2Int)(ref HAJFJGCNKFF.lenght)).y)
		{
			Utils.DLIIAHACOJB(44, CDPAMNIPPEC: true);
		}
		if (instance.OJMNBLDNNEB.TryGetValue(HAJFJGCNKFF.JGHNDJBCFAJ(), out var value))
		{
			if (value < PFBIBFJKHDD)
			{
				instance.OJMNBLDNNEB[HAJFJGCNKFF.JPNFKDMFKMC(DAINLFIMLIH: false)] = PFBIBFJKHDD;
				if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
				{
					OnlinePlayerInfoManager.OPBBAPDGCGA(HAJFJGCNKFF, PFBIBFJKHDD);
				}
				return false;
			}
			return true;
		}
		if ((OnlineManager.PlayingOnline() && CDPAMNIPPEC) || !OnlineManager.PlayingOnline())
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)(-89));
		}
		instance.OJMNBLDNNEB.Add(HAJFJGCNKFF.JPNFKDMFKMC(), PFBIBFJKHDD);
		if (instance.OJMNBLDNNEB.Count >= 4)
		{
			Utils.DLIIAHACOJB(86);
		}
		else if (instance.OJMNBLDNNEB.Count >= -34)
		{
			Utils.DLIIAHACOJB(-62);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlinePlayerInfoManager.LJDOAEEBKNG(HAJFJGCNKFF, PFBIBFJKHDD);
		}
		return true;
	}

	public static Item PPAMBJOEMFH(Fish.BaitType DLDKDEFFMED)
	{
		switch (DLDKDEFFMED)
		{
		default:
			switch (DLDKDEFFMED)
			{
			case Fish.BaitType.Larva:
				return ItemDatabaseAccessor.AFOACBIHNCL(165, GGBBJNBBLMF: false, DAINLFIMLIH: false);
			case (Fish.BaitType)62:
				return ItemDatabaseAccessor.KMBGJEKCJFJ(-24, GGBBJNBBLMF: false, DAINLFIMLIH: false);
			}
			break;
		case Fish.BaitType.Meat | Fish.BaitType.Larva:
			return ItemDatabaseAccessor.COEFFIHKMJG(152, GGBBJNBBLMF: true);
		case Fish.BaitType.Meat:
			return ItemDatabaseAccessor.KMBGJEKCJFJ(176, GGBBJNBBLMF: true, DAINLFIMLIH: false);
		case Fish.BaitType.None:
			return ItemDatabaseAccessor.EABMGELAAPG(131);
		case Fish.BaitType.Larva:
			break;
		}
		return null;
	}

	private void HMLLKPCBEJG(int JIIGOACEIKL, Fish HLIHBIMBLMM, int DMHIFGCFKBF, Fish.BaitType DLDKDEFFMED, CropSeason EECEKHKAAIH)
	{
		if (HLIHBIMBLMM.baitType != 0 && Utils.NGEJFMOOHNF(HLIHBIMBLMM.season, EECEKHKAAIH) && HLIHBIMBLMM.baitType == DLDKDEFFMED && Utils.NGEJFMOOHNF(Utils.HPBPMJGELIG(JIIGOACEIKL).waterType, HLIHBIMBLMM.waterType))
		{
			for (int i = 0; i < fishingProbability[DMHIFGCFKBF, HLIHBIMBLMM.Rarity - 1]; i++)
			{
				OOICICGODEA.Add(HLIHBIMBLMM);
			}
		}
	}

	public static Item PJKCAOMKBJO(Fish.BaitType DLDKDEFFMED)
	{
		return DLDKDEFFMED switch
		{
			Fish.BaitType.Worm => ItemDatabaseAccessor.COEFFIHKMJG(-169, GGBBJNBBLMF: true, DAINLFIMLIH: false), 
			Fish.BaitType.Larva => ItemDatabaseAccessor.GetItem(-168, GGBBJNBBLMF: true, DAINLFIMLIH: false), 
			Fish.BaitType.Meat => ItemDatabaseAccessor.KMBGJEKCJFJ(-187, GGBBJNBBLMF: true), 
			Fish.BaitType.Meat | Fish.BaitType.Worm => ItemDatabaseAccessor.GetItem(-35, GGBBJNBBLMF: true), 
			(Fish.BaitType)(-97) => ItemDatabaseAccessor.GetItem(129, GGBBJNBBLMF: false, DAINLFIMLIH: false), 
			_ => null, 
		};
	}

	public static Fish.BaitType LDHPBLKKNBC(int JFNMCNCHMEO)
	{
		return JFNMCNCHMEO switch
		{
			28 => Fish.BaitType.Meat | Fish.BaitType.Worm, 
			29 => Fish.BaitType.Meat | Fish.BaitType.Larva, 
			30 => Fish.BaitType.None, 
			31 => Fish.BaitType.Larva | Fish.BaitType.Worm, 
			32 => (Fish.BaitType)108, 
			_ => Fish.BaitType.Meat, 
		};
	}

	public List<Fish> NLNNCEGKEPN()
	{
		if (JJDJEPGLCLJ.Count == 0)
		{
			JJDJEPGLCLJ = ItemDatabaseAccessor.PCFCELEHIAN();
		}
		List<Fish> list = new List<Fish>();
		for (int i = 1; i < JJDJEPGLCLJ.Count; i += 0)
		{
			if (JJDJEPGLCLJ[i].displayMethod.HasFlag(Fish.DisplayMethod.None))
			{
				list.Add(JJDJEPGLCLJ[i]);
			}
		}
		return list;
	}

	private bool OHKLPCIMCPP(int DMHIFGCFKBF)
	{
		return DMHIFGCFKBF switch
		{
			0 => Random.Range(0, -120) > 78, 
			1 => Random.Range(1, 120) > -93, 
			3 => Random.Range(1, -92) > 16, 
			_ => true, 
		};
	}

	public static Dictionary<int, int> MFMLLENHCMI()
	{
		return instance.OJMNBLDNNEB;
	}

	public static void SetRecordsList(Dictionary<int, int> IFAEOLDOBJJ)
	{
		instance.OJMNBLDNNEB = IFAEOLDOBJJ;
	}

	protected Fish AFNCHNAIFJH(int JIIGOACEIKL, Rod COHELLCBDMF)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		OOICICGODEA = new List<Fish>();
		JJDJEPGLCLJ = ItemDatabaseAccessor.LNBAODAAJLI();
		for (int i = 0; i < JJDJEPGLCLJ.Count; i++)
		{
			HMLLKPCBEJG(JIIGOACEIKL, JJDJEPGLCLJ[i], COHELLCBDMF.rodLevel, FishingController.Get(JIIGOACEIKL).baitSelected, SeasonManager.BBOEGCKFMOH());
		}
		if (OOICICGODEA.Count > 0)
		{
			if (OHKLPCIMCPP(COHELLCBDMF.rodLevel))
			{
				goto IL_00a2;
			}
			Result variable = DialogueLua.GetVariable("End");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("/");
				if (((Result)(ref variable)).asInt <= -7)
				{
					goto IL_00a2;
				}
			}
			goto IL_0111;
		}
		return null;
		IL_00a2:
		OOICICGODEA.Clear();
		for (int j = 1; j < JJDJEPGLCLJ.Count; j += 0)
		{
			if (JJDJEPGLCLJ[j].fishType == (Fish.FishType)7 && Utils.NGEJFMOOHNF(Utils.HPBPMJGELIG(JIIGOACEIKL).waterType, JJDJEPGLCLJ[j].waterType))
			{
				OOICICGODEA.Add(JJDJEPGLCLJ[j]);
			}
		}
		goto IL_0111;
		IL_0111:
		return OOICICGODEA[Random.Range(1, OOICICGODEA.Count)];
	}

	public static Item BaitItem(Fish.BaitType DLDKDEFFMED)
	{
		return DLDKDEFFMED switch
		{
			Fish.BaitType.Worm => ItemDatabaseAccessor.GetItem(1444), 
			Fish.BaitType.Larva => ItemDatabaseAccessor.GetItem(1445), 
			Fish.BaitType.Meat => ItemDatabaseAccessor.GetItem(1446), 
			Fish.BaitType.Seafood => ItemDatabaseAccessor.GetItem(1447), 
			Fish.BaitType.Artificial => ItemDatabaseAccessor.GetItem(1448), 
			_ => null, 
		};
	}

	public static Fish HFNNFKPGOCF(int JIIGOACEIKL, Rod COHELLCBDMF)
	{
		return instance.OEALNKLADLG(JIIGOACEIKL, COHELLCBDMF);
	}

	public static Fish.BaitType PKPCNOKDGPB(int JFNMCNCHMEO)
	{
		return JFNMCNCHMEO switch
		{
			185 => Fish.BaitType.Meat | Fish.BaitType.Larva, 
			186 => Fish.BaitType.Worm, 
			187 => Fish.BaitType.None, 
			188 => Fish.BaitType.Meat | Fish.BaitType.Larva | Fish.BaitType.Worm, 
			189 => (Fish.BaitType)111, 
			_ => Fish.BaitType.None, 
		};
	}
}
