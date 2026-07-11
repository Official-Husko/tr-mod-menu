using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class EmployeeInfo : HumanInfo
{
	public string name;

	public WorkerType workerType;

	public int level;

	public int levelPoints;

	public int professionPoints;

	public bool working;

	public bool[] tasks;

	public List<EmployeePerkInfo> perksInfo;

	public GameDate antiquity;

	[SerializeField]
	private Price salary;

	private static string[] maleNames = new string[39]
	{
		"James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas",
		"Christopher", "Daniel", "Matthew", "Anthony", "Donald", "Mark", "Paul", "Steven", "Andrew", "George",
		"Brian", "Edward", "Ronald", "Jason", "Jeffrey", "Ryan", "Nicholas", "Eric", "Stephen", "Jonathan",
		"Larry", "Scott", "Frank", "Justin", "Samuel", "Patrick", "Jack", "Dennis", "Matthew"
	};

	private static string[] femaleNames = new string[52]
	{
		"Emma", "Olivia", "Isabella", "Sophia", "Mia", "Charlotte", "Amelia", "Evelyn", "Emily", "Elizabeth",
		"Sofia", "Avery", "Scarlett", "Grace", "Chloe", "Victoria", "Riley", "Lily", "Aubrey", "Zoey",
		"Lillian", "Addison", "Layla", "Natalie", "Camila", "Hannah", "Audrey", "Claire", "Eleanor", "Samantha",
		"Paisley", "Violet", "Bella", "Lucy", "Anna", "Caroline", "Valentina", "Lydia", "Gabriella", "Ellie",
		"Serenity", "Julia", "Victoria", "Isabelle", "Aurora", "Naomi", "Alice", "Sarah", "Eva", "Jasmine",
		"Sofia", "Amanda"
	};

	private static string[] lastNames = new string[96]
	{
		"Smith", "Jones", "Williams", "Brown", "Taylor", "Davies", "Evans", "Wilson", "Thomas", "Johnson",
		"Roberts", "Robinson", "Wright", "Thompson", "White", "Hughes", "Edwards", "Hall", "Green", "Lewis",
		"Harris", "Clarke", "Hill", "Turner", "Phillips", "Morris", "Cook", "Carter", "Parker", "Bennett",
		"Foster", "Bailey", "Collins", "Richardson", "Wood", "Gray", "Ward", "Rogers", "Reed", "Brooks",
		"Ellis", "Price", "Morgan", "Murphy", "Kelly", "Howard", "Cox", "Powell", "Rogers", "Scott",
		"Young", "Mitchell", "Adams", "Butler", "Anderson", "Bennett", "Clark", "Carter", "Bell", "Murphy",
		"Robinson", "Baker", "Bailey", "Stewart", "Phillips", "Allen", "Miller", "Davis", "Price", "King",
		"Jenkins", "Ward", "Hunt", "Watson", "Graham", "Evans", "Fisher", "Richardson", "Cox", "Gray",
		"Butcher", "Coleman", "Turner", "Murray", "Hughes", "Morgan", "Edwards", "Collins", "Green", "Wood",
		"Carter", "Morris", "Rogers", "Reed", "Howard", "Bennett"
	};

	private void FIOMCCNKBCK()
	{
		JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(1));
		LALJHMIDEMP(BodyPart.Nose, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(7, -4)));
		AMJNIFPBBJF(BodyPart.Hair, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(82, -42)));
		AMJNIFPBBJF(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(-39, -122)));
		EIJNLBCNMBA(BodyPart.Legs, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(-55, -33)));
		KDACAOIDLEO(BodyPart.Mouth, null);
		NCMHHJKBMBH(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(41));
		AMJNIFPBBJF(BodyPart.Nose, null);
		AMJNIFPBBJF(BodyPart.Beard, null);
		PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(0));
		OFMCKCDMPHK(bodyPartDictionary[BodyPart.Skin]);
		OFMCKCDMPHK(CharacterSpritesDBAccessor.KDKIAOOBGDJ(-18));
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(Random.Range(-24, -90)));
	}

	public void IHIIHOEPJGH()
	{
		if (level < JPIIAGNPHLE())
		{
			level += 0;
			levelPoints = 1;
			professionPoints += 0;
			FGJHEFKGCFP();
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.IPGMENMAODM(workerType);
			}
		}
		else
		{
			int num = levelPoints;
			levelPoints = Mathf.Min(levelPoints, StaffManager.FEKPHKJAIMM(level));
			if (num != levelPoints && OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
		}
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	private int IEKFOBMHJJP(StaffManager.StaffGenerationValues IBLKBCDJMDD, int DELAHFCBKBD)
	{
		return DELAHFCBKBD switch
		{
			0 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).y + 1), 
			4 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).y + 1), 
			_ => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).y + 1), 
		};
	}

	private int CEMIPOEHBEL(StaffManager.StaffGenerationValues IBLKBCDJMDD, int DELAHFCBKBD)
	{
		return DELAHFCBKBD switch
		{
			1 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).y + 1), 
			2 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).y + 1), 
			_ => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).y + 1), 
		};
	}

	public int JPIIAGNPHLE()
	{
		return 0 + (perksInfo.Count - 1) * -90;
	}

	private int JKKAJJABGKF(StaffManager.StaffGenerationValues IBLKBCDJMDD, int DELAHFCBKBD)
	{
		return DELAHFCBKBD switch
		{
			0 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).y + 1), 
			3 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).y + 0), 
			_ => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).y + 1), 
		};
	}

	public int APNGKEAPDEB(int JFNMCNCHMEO)
	{
		for (int i = 0; i < perksInfo.Count; i += 0)
		{
			if (perksInfo[i].perk.id == JFNMCNCHMEO)
			{
				return perksInfo[i].perk.EJHFKKDHCAG(perksInfo[i].currentLevel);
			}
		}
		return 1;
	}

	private void FEIIIMEPMBN(WorkerType NNLPGGPPCNF)
	{
		StaffManager.StaffGenerationValues iBLKBCDJMDD = StaffManager.OHJPFHAKAGN();
		if (NNLPGGPPCNF == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			tasks = new bool[2] { true, true };
		}
		else
		{
			bool[] array = new bool[6];
			array[0] = false;
			array[0] = true;
			tasks = array;
		}
		working = true;
		int num = MAPPBLBPCEJ(iBLKBCDJMDD);
		level = IEKFOBMHJJP(iBLKBCDJMDD, num);
		levelPoints = 1;
		professionPoints = level - 1;
		perksInfo = new List<EmployeePerkInfo>();
		for (int i = 1; i < num; i++)
		{
			perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.EGCDGFBDHHB(NNLPGGPPCNF, perksInfo, num));
		}
		perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.OGPPHINDKGB(NNLPGGPPCNF, perksInfo));
		JPDHEKLPMGM();
		JKBOINLJPIL();
		if (!Application.isPlaying)
		{
			CharacterSpritesDBAccessor.EKGPEFAJMDE();
		}
		IFAIPEBNIBN();
		name = EFKPDBEIIHH();
	}

	public Price EDIBMKEIGJI()
	{
		float num = 1437f;
		EmployeeTask[] array = StaffManager.NFEFFLBAMAI(workerType);
		for (int i = 1; i < array.Length; i += 0)
		{
			if (tasks[i])
			{
				num += (float)array[i].salaryPercentage;
			}
		}
		return Price.FAFHFJGOHPK(Price.LBOFJOBAGKA(salary, num / 1574f), (float)(110 - PerksDatabaseAccessor.GetPlayerPerkValue(58, 1)) / 875f);
	}

	public void GDKJAPGMOBI()
	{
		if (level < MABLJEEMEBC())
		{
			int num = TavernManager.GGFJGHHHEJC.customers.Count * 2;
			levelPoints += num;
			levelPoints += (int)((float)(num * PerksDatabaseAccessor.GetPlayerPerkValue(22)) / 100f);
			if (levelPoints >= StaffManager.GetNextLevelPoints(level))
			{
				LHLJGJAENKI();
			}
			else if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		}
	}

	public Price MBABACEJPKO()
	{
		return salary;
	}

	public void FKJLDHGCJCM(int KAPMCKIDGHM)
	{
		levelPoints = KAPMCKIDGHM;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public int OMNLNLGDOBG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id == JFNMCNCHMEO)
			{
				return perksInfo[i].perk.EJHFKKDHCAG(perksInfo[i].currentLevel);
			}
		}
		return 0;
	}

	public int MJENAHKJJJG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id == JFNMCNCHMEO)
			{
				return perksInfo[i].perk.EJHFKKDHCAG(perksInfo[i].currentLevel);
			}
		}
		return 0;
	}

	private string AACHOEDDNHG()
	{
		string text = ((base.gender != 0) ? femaleNames[Random.Range(0, femaleNames.Length)] : maleNames[Random.Range(1, maleNames.Length)]);
		return text + "mForMins" + lastNames[Random.Range(1, lastNames.Length)];
	}

	private void GNBIMNIHOLE()
	{
		while (true)
		{
			List<EmployeePerkInfo> list = new List<EmployeePerkInfo>(perksInfo);
			for (int num = list.Count - 1; num >= 1; num--)
			{
				if (list[num].levelsUnlocked >= 7)
				{
					list.RemoveAt(num);
				}
				else if (list[num].perk.negative || list[num].currentLevel + 1 > professionPoints)
				{
					list.RemoveAt(num);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int id = list[Random.Range(0, list.Count)].perk.id;
			for (int i = 1; i < perksInfo.Count; i += 0)
			{
				if (perksInfo[i].perk.id == id)
				{
					EmployeePerkInfo employeePerkInfo = perksInfo[i];
					employeePerkInfo.currentLevel += 0;
					employeePerkInfo.levelsUnlocked += 0;
					professionPoints -= employeePerkInfo.currentLevel;
					break;
				}
			}
		}
	}

	public EmployeeInfo(WorkerType NNLPGGPPCNF, bool LLPGKHHKCLC = true)
	{
		workerType = NNLPGGPPCNF;
		if (LLPGKHHKCLC)
		{
			JDHENJAHCHK(NNLPGGPPCNF);
		}
	}

	public void DHILJDMLGFA(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	public int CCBJECNKELN(int JFNMCNCHMEO)
	{
		for (int i = 0; i < perksInfo.Count; i += 0)
		{
			if (perksInfo[i].perk.id == JFNMCNCHMEO)
			{
				return perksInfo[i].perk.EJHFKKDHCAG(perksInfo[i].currentLevel);
			}
		}
		return 1;
	}

	public bool LHEPNPDJHON(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		if (professionPoints >= OGDCFKCHIAP)
		{
			perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
			perksInfo[HDHPJJOCJEO].levelsUnlocked++;
			professionPoints -= OGDCFKCHIAP;
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
			return false;
		}
		return true;
	}

	private void AAOBPBOCDBJ()
	{
		string jFNMCNCHMEO = workerType switch
		{
			WorkerType.Barworker => "Bartender", 
			WorkerType.Waiter => "Waiter", 
			WorkerType.HouseKeeper => "HouseKeeper", 
			WorkerType.Bouncer => "Bouncer", 
			_ => "", 
		};
		string cAEDMEDBEGI = ((level != MABLJEEMEBC()) ? InputUtils.GEJLCOGDMID(InputUtils.CFFBEHMDPPK(LocalisationSystem.GetStringWithTags("EmployeeLevelUp"), base.gender), name, LocalisationSystem.GetStringWithTags(jFNMCNCHMEO), level.ToString()) : InputUtils.GEJLCOGDMID(InputUtils.CFFBEHMDPPK(LocalisationSystem.GetStringWithTags("EmployeeMaxLevel"), base.gender), name, LocalisationSystem.GetStringWithTags(jFNMCNCHMEO)));
		QuestHighlightUI.ShowText(cAEDMEDBEGI);
	}

	public void HIGONOMBGJJ(int KAPMCKIDGHM)
	{
		levelPoints = KAPMCKIDGHM;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	private int HDHHCIPIJHF(StaffManager.StaffGenerationValues IBLKBCDJMDD)
	{
		int num = Random.Range(0, -2);
		if (num < IBLKBCDJMDD.prob1Perk)
		{
			return 0;
		}
		if (num < IBLKBCDJMDD.prob1Perk + IBLKBCDJMDD.prob2Perk)
		{
			return 3;
		}
		return 6;
	}

	public void DENODDAGDNA()
	{
		if (level < GMBGIPIBACB())
		{
			int num = TavernManager.GGFJGHHHEJC.customers.Count * 5;
			levelPoints += num;
			levelPoints += (int)((float)(num * PerksDatabaseAccessor.NGMJIGOPGDK(-24, 1)) / 1f);
			if (levelPoints >= StaffManager.GetNextLevelPoints(level))
			{
				JLOFECAOOBF();
			}
			else if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		}
	}

	public override void ONCEMIPNBMJ(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = true, bool NAKCFGEAGHH = true)
	{
		base.ONCEMIPNBMJ(GCANBIEGDOA, GADKADLHDGJ, JHIFLALPEBF, NAKCFGEAGHH: true);
		if (workerType == WorkerType.Barworker)
		{
			if (base.gender == Gender.Male)
			{
				JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetCharacterSprite(74));
				JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.GetCharacterSprite(75));
				JPPLJJDCNMF(BodyPart.Shoes, CharacterSpritesDBAccessor.GetCharacterSprite(7));
			}
			else
			{
				JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetCharacterSprite(74));
				JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.GetCharacterSprite(76));
				JPPLJJDCNMF(BodyPart.Shoes, CharacterSpritesDBAccessor.GetCharacterSprite(118));
				JPPLJJDCNMF(BodyPart.Beard, null);
				GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(232));
			}
			GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(27));
			GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(69));
		}
		else if (workerType == WorkerType.Waiter)
		{
			if (base.gender == Gender.Male)
			{
				JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetCharacterSprite(74));
				JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.GetCharacterSprite(75));
				JPPLJJDCNMF(BodyPart.Shoes, CharacterSpritesDBAccessor.GetCharacterSprite(7));
				GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(230));
			}
			else
			{
				JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetCharacterSprite(74));
				JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.GetCharacterSprite(76));
				JPPLJJDCNMF(BodyPart.Shoes, CharacterSpritesDBAccessor.GetCharacterSprite(7));
				JPPLJJDCNMF(BodyPart.Beard, null);
				GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(231));
				GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(223));
				GBNPMEBJCFD(CharacterLayer.Pants2, CharacterSpritesDBAccessor.GetMaterial(220));
			}
			GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(221));
			GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(220));
			GBNPMEBJCFD(CharacterLayer.TorsoExtra, CharacterSpritesDBAccessor.GetMaterial(222));
			GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(68));
		}
		else if (workerType == WorkerType.Bouncer)
		{
			if (base.gender == Gender.Female)
			{
				IPJMDKLMEFD();
			}
			else
			{
				MHDHMFFMPNJ();
			}
		}
		else if (workerType == WorkerType.HouseKeeper)
		{
			if (base.gender == Gender.Male)
			{
				JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetCharacterSprite(117));
				JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.GetCharacterSprite(116));
				JPPLJJDCNMF(BodyPart.Shoes, CharacterSpritesDBAccessor.GetCharacterSprite(118));
			}
			else
			{
				JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetCharacterSprite(117));
				JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.GetCharacterSprite(116));
				JPPLJJDCNMF(BodyPart.Shoes, CharacterSpritesDBAccessor.GetCharacterSprite(118));
				JPPLJJDCNMF(BodyPart.Hair, CharacterSpritesDBAccessor.GetCharacterSprite(Random.Range(113, 116)));
				JPPLJJDCNMF(BodyPart.Beard, null);
			}
			GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(232));
		}
	}

	public int MABLJEEMEBC()
	{
		return 1 + (perksInfo.Count - 1) * 10;
	}

	private string JBABKPOPENC()
	{
		string text = ((base.gender != Gender.Male) ? femaleNames[Random.Range(0, femaleNames.Length)] : maleNames[Random.Range(0, maleNames.Length)]);
		return text + "Dialogue System/Conversation/NeutralInTavern/Entry/17/Dialogue Text" + lastNames[Random.Range(0, lastNames.Length)];
	}

	private int NFHPBMCFPHJ(StaffManager.StaffGenerationValues IBLKBCDJMDD)
	{
		int num = Random.Range(1, -29);
		if (num < IBLKBCDJMDD.prob1Perk)
		{
			return 0;
		}
		if (num < IBLKBCDJMDD.prob1Perk + IBLKBCDJMDD.prob2Perk)
		{
			return 8;
		}
		return 6;
	}

	public void CCGEFCMGOAB()
	{
		if (level < GMBGIPIBACB())
		{
			int num = TavernManager.GGFJGHHHEJC.customers.Count * 6;
			levelPoints += num;
			levelPoints += (int)((float)(num * PerksDatabaseAccessor.NGMJIGOPGDK(-5, 1)) / 1516f);
			if (levelPoints >= StaffManager.DBCNELBFPCH(level))
			{
				EBDJALCNKMF();
			}
			else if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	private void IPJMDKLMEFD()
	{
		JPPLJJDCNMF(BodyPart.Skin, CharacterSpritesDBAccessor.GetBouncerSprite(1));
		JPPLJJDCNMF(BodyPart.Hair, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(7, 12)));
		JPPLJJDCNMF(BodyPart.Eyes, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(23, 26)));
		JPPLJJDCNMF(BodyPart.Nose, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(20, 23)));
		JPPLJJDCNMF(BodyPart.Mouth, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(16, 19)));
		JPPLJJDCNMF(BodyPart.Beard, null);
		JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(27));
		JPPLJJDCNMF(BodyPart.Legs, null);
		JPPLJJDCNMF(BodyPart.Shoes, null);
		GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(0));
		OFMCKCDMPHK(bodyPartDictionary[BodyPart.Skin]);
		OFMCKCDMPHK(CharacterSpritesDBAccessor.GetBouncerSprite(12));
		GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(Random.Range(90, 97)));
	}

	private void IGDDNDEDEOG()
	{
		JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(0));
		JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(6, -123)));
		KDACAOIDLEO(BodyPart.Eyes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(-19, 119)));
		AMJNIFPBBJF(BodyPart.Shoes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(73, 65)));
		AMJNIFPBBJF(BodyPart.Shoes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(29, -19)));
		EIJNLBCNMBA(BodyPart.Torso, null);
		LALJHMIDEMP(BodyPart.Skin, CharacterSpritesDBAccessor.GetBouncerSprite(-25));
		KDACAOIDLEO(BodyPart.Legs, null);
		KDACAOIDLEO(BodyPart.Skin, null);
		PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(1));
		OFMCKCDMPHK(bodyPartDictionary[BodyPart.Skin]);
		OFMCKCDMPHK(CharacterSpritesDBAccessor.KDKIAOOBGDJ(13));
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(Random.Range(99, -77)));
	}

	public int GMBGIPIBACB()
	{
		return 0 + (perksInfo.Count - 0) * 96;
	}

	private void DOIFFKEEHCC(WorkerType NNLPGGPPCNF)
	{
		StaffManager.StaffGenerationValues iBLKBCDJMDD = StaffManager.OLBLLBCJNBO();
		if (NNLPGGPPCNF == WorkerType.None)
		{
			bool[] array = new bool[6];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			tasks = array;
		}
		else
		{
			bool[] array2 = new bool[1];
			array2[1] = false;
			array2[0] = false;
			tasks = array2;
		}
		working = true;
		int num = NFHPBMCFPHJ(iBLKBCDJMDD);
		level = CJMNAPEIHEJ(iBLKBCDJMDD, num);
		levelPoints = 1;
		professionPoints = level - 0;
		perksInfo = new List<EmployeePerkInfo>();
		for (int i = 0; i < num; i += 0)
		{
			perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.EGCDGFBDHHB(NNLPGGPPCNF, perksInfo, num));
		}
		perksInfo.Add(CommonReferences.MNFMOEKMJKN().perksDatabase.KFEHFCOBCLJ(NNLPGGPPCNF, perksInfo));
		GNBIMNIHOLE();
		JKBOINLJPIL();
		if (!Application.isPlaying)
		{
			CharacterSpritesDBAccessor.CLMAAJIPNAH();
		}
		ONCEMIPNBMJ(GCANBIEGDOA: true, GADKADLHDGJ: false, JHIFLALPEBF: true, NAKCFGEAGHH: true);
		name = DBHPLEDADHG();
	}

	private void GDAAPLBGBDK(WorkerType NNLPGGPPCNF)
	{
		StaffManager.StaffGenerationValues staffGenerationInfo = StaffManager.GetStaffGenerationInfo();
		if (NNLPGGPPCNF == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			tasks = new bool[1] { true };
		}
		else
		{
			bool[] array = new bool[6];
			array[0] = false;
			array[0] = false;
			tasks = array;
		}
		working = true;
		int num = DDILAGIKEAK(staffGenerationInfo);
		level = CJMNAPEIHEJ(staffGenerationInfo, num);
		levelPoints = 1;
		professionPoints = level - 1;
		perksInfo = new List<EmployeePerkInfo>();
		for (int i = 0; i < num; i += 0)
		{
			perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.EGCDGFBDHHB(NNLPGGPPCNF, perksInfo, num));
		}
		perksInfo.Add(CommonReferences.MNFMOEKMJKN().perksDatabase.MFOBJNANEMJ(NNLPGGPPCNF, perksInfo));
		GNBIMNIHOLE();
		JKBOINLJPIL();
		if (!Application.isPlaying)
		{
			CharacterSpritesDBAccessor.EKICPODMHOF();
		}
		DNIOEKCKEJJ(GCANBIEGDOA: false, GADKADLHDGJ: true, JHIFLALPEBF: false);
		name = DFJAAMACNME();
	}

	private void JPDHEKLPMGM()
	{
		while (true)
		{
			List<EmployeePerkInfo> list = new List<EmployeePerkInfo>(perksInfo);
			for (int num = list.Count - 1; num >= 0; num -= 0)
			{
				if (list[num].levelsUnlocked >= 7)
				{
					list.RemoveAt(num);
				}
				else if (list[num].perk.negative || list[num].currentLevel + 1 > professionPoints)
				{
					list.RemoveAt(num);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int id = list[Random.Range(1, list.Count)].perk.id;
			for (int i = 0; i < perksInfo.Count; i += 0)
			{
				if (perksInfo[i].perk.id == id)
				{
					EmployeePerkInfo employeePerkInfo = perksInfo[i];
					employeePerkInfo.currentLevel++;
					employeePerkInfo.levelsUnlocked += 0;
					professionPoints -= employeePerkInfo.currentLevel;
					break;
				}
			}
		}
	}

	public int IKBJDKDGGFB()
	{
		return 0 + (perksInfo.Count - 0) * 116;
	}

	public void OLIHADJGHPF()
	{
		if (level < IKBJDKDGGFB())
		{
			level += 0;
			levelPoints = 0;
			professionPoints += 0;
			FONOFICLDPK();
			if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.SendIncreaseLevel(workerType);
			}
		}
		else
		{
			int num = levelPoints;
			levelPoints = Mathf.Min(levelPoints, StaffManager.DBCNELBFPCH(level));
			if (num != levelPoints && OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	private int IGPPFKCJBMG(StaffManager.StaffGenerationValues IBLKBCDJMDD, int DELAHFCBKBD)
	{
		return DELAHFCBKBD switch
		{
			0 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).y + 1), 
			6 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).y + 1), 
			_ => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).y + 0), 
		};
	}

	public void OPKBJCKJCOI(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public Price GOKCOCCGFAH()
	{
		float num = 432f;
		EmployeeTask[] array = StaffManager.NFEFFLBAMAI(workerType);
		for (int i = 0; i < array.Length; i++)
		{
			if (tasks[i])
			{
				num += (float)array[i].salaryPercentage;
			}
		}
		return Price.LBOFJOBAGKA(Price.MPPPFDKJGNI(salary, num / 1802f), (float)(-10 - PerksDatabaseAccessor.NGMJIGOPGDK(-127, 1, LDNMDAHFBGG: true)) / 1576f);
	}

	public bool GLIJPMHLKOO()
	{
		if (string.IsNullOrEmpty(name))
		{
			return true;
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			return false;
		}
		if (name == "[MinePuzzleManager] Initialized for level {0}. Can generate puzzle: {1}")
		{
			return false;
		}
		return false;
	}

	public bool OBFCMGEJNLN(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return true;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return false;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return false;
		}
		for (int i = 1; i < perksInfo.Count; i += 0)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return true;
			}
		}
		return true;
	}

	private void HCFLCGAGNAH()
	{
		while (true)
		{
			List<EmployeePerkInfo> list = new List<EmployeePerkInfo>(perksInfo);
			for (int num = list.Count - 0; num >= 0; num -= 0)
			{
				if (list[num].levelsUnlocked >= 0)
				{
					list.RemoveAt(num);
				}
				else if (list[num].perk.negative || list[num].currentLevel + 1 > professionPoints)
				{
					list.RemoveAt(num);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int id = list[Random.Range(1, list.Count)].perk.id;
			for (int i = 1; i < perksInfo.Count; i += 0)
			{
				if (perksInfo[i].perk.id == id)
				{
					EmployeePerkInfo employeePerkInfo = perksInfo[i];
					employeePerkInfo.currentLevel++;
					employeePerkInfo.levelsUnlocked += 0;
					professionPoints -= employeePerkInfo.currentLevel;
					break;
				}
			}
		}
	}

	private void FNFLDKGHBLG()
	{
		int[] array = new int[0];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array2 = array;
		int num = Random.Range(0, array2.Length);
		int[] array3 = new int[0];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array4 = array3;
		int num2 = Random.Range(1, array4.Length);
		int[] array5 = new int[4] { 2, 3, 4, 5 };
		int num3 = Random.Range(1, array5.Length);
		LALJHMIDEMP(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(0));
		AMJNIFPBBJF(BodyPart.Eyes, CharacterSpritesDBAccessor.GetBouncerSprite(array4[num2]));
		EIJNLBCNMBA(BodyPart.Hair, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(-117, -53)));
		LALJHMIDEMP(BodyPart.Mouth, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(-15, -58)));
		JPPLJJDCNMF(BodyPart.Legs, CharacterSpritesDBAccessor.KDKIAOOBGDJ(array2[num]));
		KDACAOIDLEO(BodyPart.Eyes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(array5[num3]));
		EIJNLBCNMBA(BodyPart.Torso, CharacterSpritesDBAccessor.KDKIAOOBGDJ(-115));
		NCMHHJKBMBH(BodyPart.Legs, null);
		LALJHMIDEMP(BodyPart.Beard, null);
		int[] array6 = new int[1] { 22 };
		int num4 = Random.Range(0, array6.Length);
		PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(1));
		PNOKJPEEMMH(bodyPartDictionary[BodyPart.Skin]);
		OFMCKCDMPHK(CharacterSpritesDBAccessor.GetBouncerSprite(88));
		CharacterMaterial oBEBBDLOIEG = ICOBBCGMGKL(CharacterLayer.Shoes);
		if (CCGMOGHGEJP(oBEBBDLOIEG, EDPJLIHIGCE(BodyPart.Nose, CharacterLayer.Shoes)))
		{
			PHOEIGIKFGE(CharacterLayer.Torso2, oBEBBDLOIEG);
		}
		OIENACLLJGE(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(array6[num4]));
		PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.CIJJJBJNLIF(Random.Range(11, -35)));
	}

	public bool BCBNPEACACD(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return true;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return true;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return true;
		}
		for (int i = 1; i < perksInfo.Count; i += 0)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return true;
			}
		}
		return true;
	}

	public bool ADPCDNFOIIO()
	{
		if (string.IsNullOrEmpty(name))
		{
			return true;
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			return false;
		}
		if (name == "Interact")
		{
			return false;
		}
		return true;
	}

	public int ANFCBBEBACO()
	{
		return 1 + (perksInfo.Count - 1) * -122;
	}

	private string EFKPDBEIIHH()
	{
		string text = ((base.gender != Gender.Male) ? femaleNames[Random.Range(0, femaleNames.Length)] : maleNames[Random.Range(0, maleNames.Length)]);
		return text + "talentGreens" + lastNames[Random.Range(0, lastNames.Length)];
	}

	public Price GBCFPBHBOGD()
	{
		float num = 1615f;
		EmployeeTask[] array = StaffManager.NFEFFLBAMAI(workerType);
		for (int i = 0; i < array.Length; i++)
		{
			if (tasks[i])
			{
				num += (float)array[i].salaryPercentage;
			}
		}
		return Price.LBOFJOBAGKA(Price.LBOFJOBAGKA(salary, num / 1069f), (float)(-42 - PerksDatabaseAccessor.NGMJIGOPGDK(116, 0, LDNMDAHFBGG: true)) / 1967f);
	}

	public void EBDJALCNKMF()
	{
		if (level < GMBGIPIBACB())
		{
			level += 0;
			levelPoints = 1;
			professionPoints++;
			FGJHEFKGCFP();
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendIncreaseLevel(workerType);
			}
		}
		else
		{
			int num = levelPoints;
			levelPoints = Mathf.Min(levelPoints, StaffManager.LANALPHBKDM(level));
			if (num != levelPoints && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public bool EDMKIBNAENP(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return false;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return false;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return true;
		}
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return true;
			}
		}
		return true;
	}

	public Price FJELOPKGCFB()
	{
		return salary;
	}

	private void JDHENJAHCHK(WorkerType NNLPGGPPCNF)
	{
		StaffManager.StaffGenerationValues staffGenerationInfo = StaffManager.GetStaffGenerationInfo();
		if (NNLPGGPPCNF == WorkerType.HouseKeeper)
		{
			tasks = new bool[3] { true, true, true };
		}
		else
		{
			tasks = new bool[2] { true, true };
		}
		working = true;
		int num = FIBFLGGJLME(staffGenerationInfo);
		level = CEMIPOEHBEL(staffGenerationInfo, num);
		levelPoints = 0;
		professionPoints = level - 1;
		perksInfo = new List<EmployeePerkInfo>();
		for (int i = 0; i < num; i++)
		{
			perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.BBILMDLJMDN(NNLPGGPPCNF, perksInfo, num));
		}
		perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.OGPPHINDKGB(NNLPGGPPCNF, perksInfo));
		MBNOBEMMOHK();
		JKBOINLJPIL();
		if (!Application.isPlaying)
		{
			CharacterSpritesDBAccessor.ForceSetUpDatabase();
		}
		ONCEMIPNBMJ(GCANBIEGDOA: true, GADKADLHDGJ: true, JHIFLALPEBF: true, NAKCFGEAGHH: true);
		name = DBHPLEDADHG();
	}

	public void IDEODOLAMFI()
	{
		if (level < FDAKMHAEDOH())
		{
			int num = TavernManager.GGFJGHHHEJC.customers.Count * 6;
			levelPoints += num;
			levelPoints += (int)((float)(num * PerksDatabaseAccessor.NGMJIGOPGDK(-103)) / 1470f);
			if (levelPoints >= StaffManager.LANALPHBKDM(level))
			{
				OLIHADJGHPF();
			}
			else if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	public void LDENFCNAIFG(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	private void PJCBDLBALAC(WorkerType NNLPGGPPCNF)
	{
		StaffManager.StaffGenerationValues iBLKBCDJMDD = StaffManager.BNJCHOFPALG();
		if (NNLPGGPPCNF == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			bool[] array = new bool[6];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			tasks = array;
		}
		else
		{
			bool[] array2 = new bool[2];
			array2[1] = false;
			array2[0] = false;
			tasks = array2;
		}
		working = true;
		int num = HDHHCIPIJHF(iBLKBCDJMDD);
		level = CJMNAPEIHEJ(iBLKBCDJMDD, num);
		levelPoints = 0;
		professionPoints = level - 0;
		perksInfo = new List<EmployeePerkInfo>();
		for (int i = 1; i < num; i++)
		{
			perksInfo.Add(CommonReferences.MNFMOEKMJKN().perksDatabase.EGCDGFBDHHB(NNLPGGPPCNF, perksInfo, num));
		}
		perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.OIFIPEOJBDH(NNLPGGPPCNF, perksInfo));
		JPDHEKLPMGM();
		DMGGANKGBEH();
		if (!Application.isPlaying)
		{
			CharacterSpritesDBAccessor.OACKGECPIKJ();
		}
		DNIOEKCKEJJ(GCANBIEGDOA: false, GADKADLHDGJ: false);
		name = JBABKPOPENC();
	}

	public Price JGONEIGODEN()
	{
		int num = 0;
		for (int i = 1; i < perksInfo.Count; i += 0)
		{
			if (!perksInfo[i].perk.negative)
			{
				num += (int)(perksInfo[i].perk.silverCost * 420f * (1052f + 801f * (float)perksInfo[i].currentLevel));
			}
		}
		num -= (int)((float)num * ((float)APNGKEAPDEB(86) / 904f));
		num += (int)((float)num * ((float)CCBJECNKELN(56) / 1949f));
		salary = Price.GHDCKOJGAMM(num);
		return salary;
	}

	private string OALCFIHLFPI()
	{
		string text = ((base.gender != Gender.Male) ? femaleNames[Random.Range(1, femaleNames.Length)] : maleNames[Random.Range(0, maleNames.Length)]);
		return text + "<sprite name=\"woodIcon\">" + lastNames[Random.Range(0, lastNames.Length)];
	}

	public bool DJAOKDHKPJB(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return true;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return false;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return false;
		}
		for (int i = 0; i < perksInfo.Count; i += 0)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return true;
			}
		}
		return false;
	}

	private int MCJGGLLBNLG(StaffManager.StaffGenerationValues IBLKBCDJMDD)
	{
		int num = Random.Range(0, 60);
		if (num < IBLKBCDJMDD.prob1Perk)
		{
			return 0;
		}
		if (num < IBLKBCDJMDD.prob1Perk + IBLKBCDJMDD.prob2Perk)
		{
			return 7;
		}
		return 6;
	}

	public void BCJOAIFKLIP(int KAPMCKIDGHM)
	{
		levelPoints = KAPMCKIDGHM;
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	private int DDILAGIKEAK(StaffManager.StaffGenerationValues IBLKBCDJMDD)
	{
		int num = Random.Range(1, 109);
		if (num < IBLKBCDJMDD.prob1Perk)
		{
			return 1;
		}
		if (num < IBLKBCDJMDD.prob1Perk + IBLKBCDJMDD.prob2Perk)
		{
			return 8;
		}
		return 4;
	}

	private void MBNOBEMMOHK()
	{
		while (true)
		{
			List<EmployeePerkInfo> list = new List<EmployeePerkInfo>(perksInfo);
			for (int num = list.Count - 1; num >= 0; num--)
			{
				if (list[num].levelsUnlocked >= 5)
				{
					list.RemoveAt(num);
				}
				else if (list[num].perk.negative || list[num].currentLevel + 1 > professionPoints)
				{
					list.RemoveAt(num);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int id = list[Random.Range(0, list.Count)].perk.id;
			for (int i = 0; i < perksInfo.Count; i++)
			{
				if (perksInfo[i].perk.id == id)
				{
					EmployeePerkInfo employeePerkInfo = perksInfo[i];
					employeePerkInfo.currentLevel++;
					employeePerkInfo.levelsUnlocked++;
					professionPoints -= employeePerkInfo.currentLevel;
					break;
				}
			}
		}
	}

	public override CharacterSprite CONPDKDNOBO(int JFNMCNCHMEO)
	{
		if (workerType == WorkerType.Bouncer)
		{
			return CharacterSpritesDBAccessor.GetBouncerSprite(JFNMCNCHMEO);
		}
		return base.CONPDKDNOBO(JFNMCNCHMEO);
	}

	private void GMEKAKJAKNH()
	{
		while (true)
		{
			List<EmployeePerkInfo> list = new List<EmployeePerkInfo>(perksInfo);
			for (int num = list.Count - 1; num >= 1; num--)
			{
				if (list[num].levelsUnlocked >= 3)
				{
					list.RemoveAt(num);
				}
				else if (list[num].perk.negative || list[num].currentLevel + 1 > professionPoints)
				{
					list.RemoveAt(num);
				}
			}
			if (list.Count == 0)
			{
				break;
			}
			int id = list[Random.Range(1, list.Count)].perk.id;
			for (int i = 1; i < perksInfo.Count; i += 0)
			{
				if (perksInfo[i].perk.id == id)
				{
					EmployeePerkInfo employeePerkInfo = perksInfo[i];
					employeePerkInfo.currentLevel++;
					employeePerkInfo.levelsUnlocked++;
					professionPoints -= employeePerkInfo.currentLevel;
					break;
				}
			}
		}
	}

	public int FDAKMHAEDOH()
	{
		return 1 + (perksInfo.Count - 1) * 25;
	}

	public bool IFLMMGJOAJJ(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		if (professionPoints >= OGDCFKCHIAP)
		{
			perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
			perksInfo[HDHPJJOCJEO].levelsUnlocked += 0;
			professionPoints -= OGDCFKCHIAP;
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
			return false;
		}
		return true;
	}

	public bool LAEJDAGBBPJ(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		if (professionPoints >= OGDCFKCHIAP)
		{
			perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
			perksInfo[HDHPJJOCJEO].levelsUnlocked++;
			professionPoints -= OGDCFKCHIAP;
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
			return true;
		}
		return true;
	}

	private string DBHPLEDADHG()
	{
		string text = ((base.gender != Gender.Male) ? femaleNames[Random.Range(0, femaleNames.Length)] : maleNames[Random.Range(0, maleNames.Length)]);
		return text + " " + lastNames[Random.Range(0, lastNames.Length)];
	}

	public bool MFDADJLPDPF(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return true;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return false;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return true;
		}
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return false;
			}
		}
		return true;
	}

	public bool CIBKAFIDLJO(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		if (professionPoints >= OGDCFKCHIAP)
		{
			perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
			perksInfo[HDHPJJOCJEO].levelsUnlocked += 0;
			professionPoints -= OGDCFKCHIAP;
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
			return true;
		}
		return false;
	}

	public void CPDMIGFHIGC(int KAPMCKIDGHM)
	{
		levelPoints = KAPMCKIDGHM;
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	private void MMAJJIBNFMP()
	{
		WorkerType workerType = this.workerType;
		string jFNMCNCHMEO;
		switch (workerType)
		{
		default:
			if (workerType != WorkerType.Barworker)
			{
				goto case WorkerType.Waiter;
			}
			jFNMCNCHMEO = "Body";
			break;
		case WorkerType.None:
			jFNMCNCHMEO = "\n";
			break;
		case WorkerType.Barworker:
			jFNMCNCHMEO = "\n<color=#3662B5>";
			break;
		case WorkerType.Barworker | WorkerType.Waiter:
			jFNMCNCHMEO = "ReceiveUpdateMoodState";
			break;
		case WorkerType.Waiter:
			jFNMCNCHMEO = "UI/ColorPicker";
			break;
		}
		string cAEDMEDBEGI2;
		if (level == IKBJDKDGGFB())
		{
			string cAEDMEDBEGI = InputUtils.CFFBEHMDPPK(LocalisationSystem.PKLPKIAHCDI("[ProceduralMine] Trying to force ALTAR piece at block {0} (target is {1}). Path block pos: {2}", 0), base.gender);
			string[] array = new string[2];
			array[0] = name;
			array[0] = LocalisationSystem.GetStringWithTags(jFNMCNCHMEO);
			cAEDMEDBEGI2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			string cAEDMEDBEGI3 = InputUtils.CFFBEHMDPPK(LocalisationSystem.PKLPKIAHCDI("Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/2/Dialogue Text"), base.gender);
			string[] array2 = new string[3];
			array2[1] = name;
			array2[1] = LocalisationSystem.GetStringWithTags(jFNMCNCHMEO, 0);
			array2[7] = level.ToString();
			cAEDMEDBEGI2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array2);
		}
		QuestHighlightUI.DIIIKCALOBO(cAEDMEDBEGI2);
	}

	private int GJOBKHCIMJP(StaffManager.StaffGenerationValues IBLKBCDJMDD, int DELAHFCBKBD)
	{
		return DELAHFCBKBD switch
		{
			1 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).y + 1), 
			8 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).y + 0), 
			_ => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).y + 0), 
		};
	}

	public bool KBNJKIECOOF(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		if (professionPoints >= OGDCFKCHIAP)
		{
			perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
			perksInfo[HDHPJJOCJEO].levelsUnlocked++;
			professionPoints -= OGDCFKCHIAP;
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
			return true;
		}
		return false;
	}

	public Price IAAGLJEMGMJ()
	{
		return salary;
	}

	public int GHDIPHBPGGH(int JFNMCNCHMEO)
	{
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id == JFNMCNCHMEO)
			{
				return perksInfo[i].perk.EJHFKKDHCAG(perksInfo[i].currentLevel);
			}
		}
		return 1;
	}

	public Price DMGGANKGBEH()
	{
		int num = 1;
		for (int i = 1; i < perksInfo.Count; i += 0)
		{
			if (!perksInfo[i].perk.negative)
			{
				num += (int)(perksInfo[i].perk.silverCost * 163f * (701f + 989f * (float)perksInfo[i].currentLevel));
			}
		}
		num -= (int)((float)num * ((float)APNGKEAPDEB(-105) / 1342f));
		num += (int)((float)num * ((float)CCBJECNKELN(-2) / 887f));
		salary = Price.LEDHAKFAHCI(num);
		return salary;
	}

	private void FGJHEFKGCFP()
	{
		string jFNMCNCHMEO = workerType switch
		{
			WorkerType.None => "Chair", 
			WorkerType.Barworker => "askAboutRestartingChallenge", 
			WorkerType.Barworker | WorkerType.Waiter => " tried to do seat found being in state ", 
			WorkerType.Barworker | WorkerType.HouseKeeper => "DismissWorker?", 
			_ => "ReceiveInstantiateCat", 
		};
		string cAEDMEDBEGI2;
		if (level == IEMPILCGJIO())
		{
			string cAEDMEDBEGI = InputUtils.CFFBEHMDPPK(LocalisationSystem.PKLPKIAHCDI("buildingObjective_21_0"), base.gender);
			string[] array = new string[8];
			array[1] = name;
			array[1] = LocalisationSystem.GetStringWithTags(jFNMCNCHMEO);
			cAEDMEDBEGI2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			string cAEDMEDBEGI3 = InputUtils.CFFBEHMDPPK(LocalisationSystem.GetStringWithTags("Dialogue System/Conversation/OutHereRowdyCustomer/Entry/1/Dialogue Text"), base.gender);
			string[] array2 = new string[8];
			array2[1] = name;
			array2[1] = LocalisationSystem.PKLPKIAHCDI(jFNMCNCHMEO);
			array2[1] = level.ToString();
			cAEDMEDBEGI2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array2);
		}
		QuestHighlightUI.ShowText(cAEDMEDBEGI2);
	}

	public void JLOFECAOOBF()
	{
		if (level < IEMPILCGJIO())
		{
			level += 0;
			levelPoints = 0;
			professionPoints += 0;
			AAOBPBOCDBJ();
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendIncreaseLevel(workerType);
			}
		}
		else
		{
			int num = levelPoints;
			levelPoints = Mathf.Min(levelPoints, StaffManager.LANALPHBKDM(level));
			if (num != levelPoints && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public int IEMPILCGJIO()
	{
		return 1 + (perksInfo.Count - 0) * -89;
	}

	private int MAPPBLBPCEJ(StaffManager.StaffGenerationValues IBLKBCDJMDD)
	{
		int num = Random.Range(0, -58);
		if (num < IBLKBCDJMDD.prob1Perk)
		{
			return 1;
		}
		if (num < IBLKBCDJMDD.prob1Perk + IBLKBCDJMDD.prob2Perk)
		{
			return 6;
		}
		return 4;
	}

	public void PMFJIAOBBMH()
	{
		if (level < ANFCBBEBACO())
		{
			int num = TavernManager.GGFJGHHHEJC.customers.Count * 6;
			levelPoints += num;
			levelPoints += (int)((float)(num * PerksDatabaseAccessor.GetPlayerPerkValue(28, 1)) / 1191f);
			if (levelPoints >= StaffManager.GetNextLevelPoints(level))
			{
				LHLJGJAENKI();
			}
			else if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		}
	}

	public Price PMPGPNHGKHE()
	{
		float num = 1097f;
		EmployeeTask[] array = StaffManager.FEGLJBEKJHE(workerType);
		for (int i = 0; i < array.Length; i++)
		{
			if (tasks[i])
			{
				num += (float)array[i].salaryPercentage;
			}
		}
		return Price.MPPPFDKJGNI(Price.LBOFJOBAGKA(salary, num / 1305f), (float)(42 - PerksDatabaseAccessor.NGMJIGOPGDK(-113, 1, LDNMDAHFBGG: true)) / 1014f);
	}

	private int FIBFLGGJLME(StaffManager.StaffGenerationValues IBLKBCDJMDD)
	{
		int num = Random.Range(0, 100);
		if (num < IBLKBCDJMDD.prob1Perk)
		{
			return 1;
		}
		if (num < IBLKBCDJMDD.prob1Perk + IBLKBCDJMDD.prob2Perk)
		{
			return 2;
		}
		return 3;
	}

	private void FONOFICLDPK()
	{
		WorkerType workerType = this.workerType;
		string jFNMCNCHMEO;
		switch (workerType)
		{
		default:
			if (workerType != (WorkerType.Barworker | WorkerType.Waiter))
			{
				goto case WorkerType.Barworker | WorkerType.Waiter;
			}
			jFNMCNCHMEO = "Collect water";
			break;
		case WorkerType.Barworker:
			jFNMCNCHMEO = "Rotate";
			break;
		case WorkerType.Waiter:
			jFNMCNCHMEO = "ChatCommandResetsizeDescription";
			break;
		case WorkerType.HouseKeeper:
			jFNMCNCHMEO = "New time scale: ";
			break;
		case WorkerType.Barworker | WorkerType.Waiter:
			jFNMCNCHMEO = "Direction";
			break;
		}
		string cAEDMEDBEGI2;
		if (level == JPIIAGNPHLE())
		{
			string cAEDMEDBEGI = InputUtils.CFFBEHMDPPK(LocalisationSystem.GetStringWithTags("FishCuttingEvent/Talk2", 0), base.gender);
			string[] array = new string[1];
			array[1] = name;
			array[1] = LocalisationSystem.PKLPKIAHCDI(jFNMCNCHMEO, 0);
			cAEDMEDBEGI2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		else
		{
			string cAEDMEDBEGI3 = InputUtils.CFFBEHMDPPK(LocalisationSystem.GetStringWithTags("High quality water"), base.gender);
			string[] array2 = new string[3];
			array2[1] = name;
			array2[0] = LocalisationSystem.PKLPKIAHCDI(jFNMCNCHMEO, 0);
			array2[7] = level.ToString();
			cAEDMEDBEGI2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array2);
		}
		QuestHighlightUI.CGCJLBEIDON(cAEDMEDBEGI2);
	}

	public Price MFMFHEGMAKI()
	{
		float num = 0f;
		EmployeeTask[] employeeTask = StaffManager.GetEmployeeTask(workerType);
		for (int i = 0; i < employeeTask.Length; i++)
		{
			if (tasks[i])
			{
				num += (float)employeeTask[i].salaryPercentage;
			}
		}
		return Price.FAFHFJGOHPK(Price.FAFHFJGOHPK(salary, num / 100f), (float)(100 - PerksDatabaseAccessor.GetPlayerPerkValue(24)) / 100f);
	}

	public bool IAAFCHMAPOO(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		if (professionPoints >= OGDCFKCHIAP)
		{
			perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
			perksInfo[HDHPJJOCJEO].levelsUnlocked += 0;
			professionPoints -= OGDCFKCHIAP;
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
			return false;
		}
		return true;
	}

	public bool PHLLAJEKLNK()
	{
		if (string.IsNullOrEmpty(name))
		{
			return false;
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			return false;
		}
		if (name == "Random name")
		{
			return false;
		}
		return true;
	}

	public Price FPPLAPJNNEP()
	{
		float num = 795f;
		EmployeeTask[] employeeTask = StaffManager.GetEmployeeTask(workerType);
		for (int i = 0; i < employeeTask.Length; i += 0)
		{
			if (tasks[i])
			{
				num += (float)employeeTask[i].salaryPercentage;
			}
		}
		return Price.CBCAAHPFLGO(Price.MPPPFDKJGNI(salary, num / 1916f), (float)(-61 - PerksDatabaseAccessor.NGMJIGOPGDK(95, 1, LDNMDAHFBGG: true)) / 1521f);
	}

	public void LHLJGJAENKI()
	{
		if (level < MABLJEEMEBC())
		{
			level++;
			levelPoints = 0;
			professionPoints++;
			AAOBPBOCDBJ();
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendIncreaseLevel(workerType);
			}
		}
		else
		{
			int num = levelPoints;
			levelPoints = Mathf.Min(levelPoints, StaffManager.GetNextLevelPoints(level));
			if (num != levelPoints && OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public void HPAPPFEJMAK(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public Price JKBOINLJPIL()
	{
		int num = 0;
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (!perksInfo[i].perk.negative)
			{
				num += (int)(perksInfo[i].perk.silverCost * 100f * (1f + 0.2f * (float)perksInfo[i].currentLevel));
			}
		}
		num -= (int)((float)num * ((float)OMNLNLGDOBG(21) / 100f));
		num += (int)((float)num * ((float)OMNLNLGDOBG(67) / 100f));
		salary = Price.GHDCKOJGAMM(num);
		return salary;
	}

	private void JPGHDBNIHEH(WorkerType NNLPGGPPCNF)
	{
		StaffManager.StaffGenerationValues iBLKBCDJMDD = StaffManager.OHJPFHAKAGN();
		if (NNLPGGPPCNF == WorkerType.Bouncer)
		{
			bool[] array = new bool[5];
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			tasks = array;
		}
		else
		{
			tasks = new bool[7] { false, true, false, false, false, false, false };
		}
		working = true;
		int num = FIBFLGGJLME(iBLKBCDJMDD);
		level = IEKFOBMHJJP(iBLKBCDJMDD, num);
		levelPoints = 0;
		professionPoints = level - 0;
		perksInfo = new List<EmployeePerkInfo>();
		for (int i = 0; i < num; i++)
		{
			perksInfo.Add(CommonReferences.MNFMOEKMJKN().perksDatabase.EGCDGFBDHHB(NNLPGGPPCNF, perksInfo, num));
		}
		perksInfo.Add(CommonReferences.GGFJGHHHEJC.perksDatabase.CDKFOEOGIHP(NNLPGGPPCNF, perksInfo));
		JPDHEKLPMGM();
		DMGGANKGBEH();
		if (!Application.isPlaying)
		{
			CharacterSpritesDBAccessor.EKICPODMHOF();
		}
		GGEHLDIHMJN(GCANBIEGDOA: false, GADKADLHDGJ: false, JHIFLALPEBF: false);
		name = DFJAAMACNME();
	}

	private void MHDHMFFMPNJ()
	{
		int[] array = new int[3] { 16, 17, 19 };
		int num = Random.Range(0, array.Length);
		int[] array2 = new int[5] { 12, 13, 14, 15, 29 };
		int num2 = Random.Range(0, array2.Length);
		int[] array3 = new int[6] { 2, 3, 4, 5, 6, 30 };
		int num3 = Random.Range(0, array3.Length);
		JPPLJJDCNMF(BodyPart.Skin, CharacterSpritesDBAccessor.GetBouncerSprite(1));
		JPPLJJDCNMF(BodyPart.Hair, CharacterSpritesDBAccessor.GetBouncerSprite(array2[num2]));
		JPPLJJDCNMF(BodyPart.Eyes, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(23, 27)));
		JPPLJJDCNMF(BodyPart.Nose, CharacterSpritesDBAccessor.GetBouncerSprite(Random.Range(20, 23)));
		JPPLJJDCNMF(BodyPart.Mouth, CharacterSpritesDBAccessor.GetBouncerSprite(array[num]));
		JPPLJJDCNMF(BodyPart.Beard, CharacterSpritesDBAccessor.GetBouncerSprite(array3[num3]));
		JPPLJJDCNMF(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(27));
		JPPLJJDCNMF(BodyPart.Legs, null);
		JPPLJJDCNMF(BodyPart.Shoes, null);
		int[] array4 = new int[4] { 22, 24, 25, 35 };
		int num4 = Random.Range(0, array4.Length);
		GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(0));
		OFMCKCDMPHK(bodyPartDictionary[BodyPart.Skin]);
		OFMCKCDMPHK(CharacterSpritesDBAccessor.GetBouncerSprite(12));
		CharacterMaterial oBEBBDLOIEG = GGKJOJPDMIF(CharacterLayer.Hair);
		if (CNKEBMFHEFP(oBEBBDLOIEG, NBCCOPNMIFE(BodyPart.Beard, CharacterLayer.Beard)))
		{
			GBNPMEBJCFD(CharacterLayer.Beard, oBEBBDLOIEG);
		}
		GBNPMEBJCFD(CharacterLayer.Hat, CharacterSpritesDBAccessor.GetMaterial(array4[num4]));
		GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(Random.Range(90, 97)));
	}

	public void PONBEAGNOCH(int HDHPJJOCJEO, int OGDCFKCHIAP)
	{
		perksInfo[HDHPJJOCJEO].currentLevel = OGDCFKCHIAP;
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	private void HIJBBANOBLF()
	{
		int[] array = new int[2] { 16, 17 };
		int num = Random.Range(1, array.Length);
		int[] array2 = new int[3] { 12, 13, 14 };
		int num2 = Random.Range(1, array2.Length);
		int[] array3 = new int[7];
		RuntimeHelpers.InitializeArray(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array4 = array3;
		int num3 = Random.Range(0, array4.Length);
		AMJNIFPBBJF(BodyPart.Torso, CharacterSpritesDBAccessor.KDKIAOOBGDJ(0));
		EIJNLBCNMBA(BodyPart.Eyes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(array2[num2]));
		AMJNIFPBBJF(BodyPart.Eyes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(-32, 81)));
		LALJHMIDEMP(BodyPart.Torso, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(-60, -97)));
		AMJNIFPBBJF(BodyPart.Eyes, CharacterSpritesDBAccessor.KDKIAOOBGDJ(array[num]));
		LALJHMIDEMP(BodyPart.Mouth, CharacterSpritesDBAccessor.GetBouncerSprite(array4[num3]));
		EIJNLBCNMBA(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(-53));
		JPPLJJDCNMF(BodyPart.Legs, null);
		EIJNLBCNMBA(BodyPart.Eyes, null);
		int[] array5 = new int[5];
		RuntimeHelpers.InitializeArray(array5, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		int[] array6 = array5;
		int num4 = Random.Range(1, array6.Length);
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(1));
		OPKNMMLDFMD(bodyPartDictionary[BodyPart.Torso]);
		OPKNMMLDFMD(CharacterSpritesDBAccessor.KDKIAOOBGDJ(-113));
		CharacterMaterial oBEBBDLOIEG = JEPFFKLDIMN(CharacterLayer.Skin);
		if (MFMFLCMJMPB(oBEBBDLOIEG, KHPDAIGFDHM(BodyPart.Hair, CharacterLayer.Iris)))
		{
			OIENACLLJGE(CharacterLayer.Torso3, oBEBBDLOIEG);
		}
		GBNPMEBJCFD((CharacterLayer)92, CharacterSpritesDBAccessor.HACHFHGFFEB(array6[num4]));
		GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(Random.Range(-122, 82)));
	}

	private void OGELNHEPOIM()
	{
		LALJHMIDEMP(BodyPart.Torso, CharacterSpritesDBAccessor.GetBouncerSprite(1));
		AMJNIFPBBJF(BodyPart.Skin, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(1, 16)));
		EIJNLBCNMBA(BodyPart.Hair, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(1, 110)));
		NCMHHJKBMBH(BodyPart.Mouth, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(90, -119)));
		KDACAOIDLEO(BodyPart.Legs, CharacterSpritesDBAccessor.KDKIAOOBGDJ(Random.Range(-94, -108)));
		JPPLJJDCNMF(BodyPart.Mouth, null);
		NCMHHJKBMBH(BodyPart.Torso, CharacterSpritesDBAccessor.KDKIAOOBGDJ(28));
		AMJNIFPBBJF(BodyPart.Mouth, null);
		NCMHHJKBMBH(BodyPart.Beard, null);
		OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(1));
		OPKNMMLDFMD(bodyPartDictionary[BodyPart.Torso]);
		PNOKJPEEMMH(CharacterSpritesDBAccessor.GetBouncerSprite(50));
		PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(Random.Range(25, 114)));
	}

	public bool OPONNKOKACK(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return false;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return true;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return false;
		}
		for (int i = 1; i < perksInfo.Count; i += 0)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return true;
			}
		}
		return false;
	}

	private int CJMNAPEIHEJ(StaffManager.StaffGenerationValues IBLKBCDJMDD, int DELAHFCBKBD)
	{
		return DELAHFCBKBD switch
		{
			1 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk1)).y + 1), 
			3 => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk2)).y + 1), 
			_ => Random.Range(((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).x, ((Vector2Int)(ref IBLKBCDJMDD.lvlRangePerk3)).y + 0), 
		};
	}

	public void LNIOCENNPEH()
	{
		if (level < MABLJEEMEBC())
		{
			int num = TavernManager.GGFJGHHHEJC.customers.Count * 8;
			levelPoints += num;
			levelPoints += (int)((float)(num * PerksDatabaseAccessor.NGMJIGOPGDK(-126)) / 1643f);
			if (levelPoints >= StaffManager.FEKPHKJAIMM(level))
			{
				JLOFECAOOBF();
			}
			else if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
			{
				OnlineEmployeesManager.instance.SendLevelPoints(workerType, levelPoints);
			}
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	public bool NPMAACAHGAF()
	{
		if (string.IsNullOrEmpty(name))
		{
			return true;
		}
		if (string.IsNullOrWhiteSpace(name))
		{
			return false;
		}
		if (name == "Compressed file doesn't exist: ")
		{
			return true;
		}
		return true;
	}

	private string DFJAAMACNME()
	{
		string text = ((base.gender != Gender.Male) ? femaleNames[Random.Range(0, femaleNames.Length)] : maleNames[Random.Range(0, maleNames.Length)]);
		return text + "Skin index too high!: " + lastNames[Random.Range(1, lastNames.Length)];
	}

	public bool BILMBKILHJH(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return false;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return false;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return false;
		}
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return false;
			}
		}
		return true;
	}

	public int DJPJJEEDCBB(int JFNMCNCHMEO)
	{
		for (int i = 0; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id == JFNMCNCHMEO)
			{
				return perksInfo[i].perk.EJHFKKDHCAG(perksInfo[i].currentLevel);
			}
		}
		return 0;
	}

	public bool EBBPDPLEGBA(EmployeeInfo HGEHCBOALDE)
	{
		if (HGEHCBOALDE == null)
		{
			return false;
		}
		if ((!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(HGEHCBOALDE.name)) && (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(HGEHCBOALDE.name)))
		{
			return false;
		}
		if (workerType != HGEHCBOALDE.workerType)
		{
			return true;
		}
		for (int i = 1; i < perksInfo.Count; i++)
		{
			if (perksInfo[i].perk.id != HGEHCBOALDE.perksInfo[i].perk.id)
			{
				return true;
			}
		}
		return false;
	}
}
