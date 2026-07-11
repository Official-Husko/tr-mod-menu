using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class EmployeeMessage : HumanInfoMsg
{
	[JsonProperty("na")]
	public string name;

	[JsonProperty("wo")]
	public byte workerType;

	[JsonProperty("le")]
	public byte level;

	[JsonProperty("an")]
	public GameDateMessage antiquity;

	[JsonProperty("lP")]
	public short levelPoints;

	[JsonProperty("pP")]
	public byte professionPoints;

	[JsonProperty("wo")]
	public bool working;

	[JsonProperty("ta")]
	public bool[] tasks;

	[JsonProperty("pI")]
	public PerkInfoMsg[] perksInfo;

	public EmployeeInfo EKKEILKMENL()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		OJIGKLOMMEG(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.CLNEFAMNGEK();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = false;
		for (int i = 0; i < perksInfo.Length; i += 0)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.GGFJGHHHEJC.perksDatabase.NPBBMFKGPFM(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].HPKMGJPCKKE())
			{
				flag = true;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == -64)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.OGPPHINDKGB((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.MABLJEEMEBC());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JKBOINLJPIL();
		return employeeInfo;
	}

	public EmployeeInfo CDKAJJADJDL()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		LFOGNGHELDK(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.HOFLKNLJJPF();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = false;
		for (int i = 0; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.OGMIPPHOAGM(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].BBIOGEHCDGD())
			{
				flag = false;
			}
		}
		for (int j = 0; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == -71)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.KFEHFCOBCLJ((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.IKBJDKDGGFB());
		if (flag)
		{
			employeeInfo.professionPoints = 1;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JGONEIGODEN();
		return employeeInfo;
	}

	public EmployeeMessage(EmployeeInfo JFCLIAFAOEK)
		: base(JFCLIAFAOEK)
	{
		name = JFCLIAFAOEK.name;
		workerType = (byte)JFCLIAFAOEK.workerType;
		level = (byte)JFCLIAFAOEK.level;
		antiquity = new GameDateMessage(JFCLIAFAOEK.antiquity);
		levelPoints = (byte)JFCLIAFAOEK.levelPoints;
		professionPoints = (byte)JFCLIAFAOEK.professionPoints;
		working = JFCLIAFAOEK.working;
		tasks = JFCLIAFAOEK.tasks;
		perksInfo = JFCLIAFAOEK.perksInfo.Select((EmployeePerkInfo x) => new PerkInfoMsg(x)).ToArray();
	}

	public EmployeeInfo MBEMBCLOFAG()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		OABLCHJPPIN(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.JBJLBDHAECK();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 0; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.GGFJGHHHEJC.perksDatabase.JEHJMPBEJPI(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].AEKLINIOAJO())
			{
				flag = false;
			}
		}
		for (int j = 0; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == 65)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.OGPPHINDKGB((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.MABLJEEMEBC());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JKBOINLJPIL();
		return employeeInfo;
	}

	public EmployeeInfo LLJKABCICFL()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		MJHLPBPKHGH(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.EJBPDFAMFEJ();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 1; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.PCIDKALLDHP(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].AEKLINIOAJO())
			{
				flag = false;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == 23)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.PMDNGJMONPF((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.IEMPILCGJIO());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JGONEIGODEN();
		return employeeInfo;
	}

	public EmployeeInfo OAFCOHGLHBA()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType);
		JJEMKIKNIOG(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.LNOPKHGNLAA();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = false;
		for (int i = 0; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.MKDBCOEBLPN(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].AKKBODELPAN())
			{
				flag = false;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == 22)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.INPEEFGHNPB((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.MABLJEEMEBC());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.DMGGANKGBEH();
		return employeeInfo;
	}

	public EmployeeInfo DACLJPDMLNG()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		JJEMKIKNIOG(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.OIIMNMKECAC();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 1; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.MKDBCOEBLPN(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].JONLHDKGCGL())
			{
				flag = true;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == -7)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.CDKFOEOGIHP((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.ANFCBBEBACO());
		if (flag)
		{
			employeeInfo.professionPoints = 1;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JKBOINLJPIL();
		return employeeInfo;
	}

	public EmployeeInfo LJEJHALCBDD()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		KGGEPMPAKOM(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.JKCNKPONGNJ();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = false;
		for (int i = 0; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.OGMIPPHOAGM(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].LNPDJAEGLOH())
			{
				flag = false;
			}
		}
		for (int j = 0; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == 34)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.INPEEFGHNPB((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.JPIIAGNPHLE());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.DMGGANKGBEH();
		return employeeInfo;
	}

	public EmployeeInfo PMIMIHFABDJ()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		FHCIEPPIDND(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.CGDNCJIAHHG();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = false;
		for (int i = 0; i < perksInfo.Length; i += 0)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.GGFJGHHHEJC.perksDatabase.KMFPCLAMMJB(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].NGAKJIHNNJK())
			{
				flag = false;
			}
		}
		for (int j = 0; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == -84)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.KFEHFCOBCLJ((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.IKBJDKDGGFB());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JGONEIGODEN();
		return employeeInfo;
	}

	public EmployeeInfo GFDPGOGILLI()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		FHCIEPPIDND(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.EJBPDFAMFEJ();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = false;
		for (int i = 1; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.KDFFGPJBBDP(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].ECDLFCLFGMN())
			{
				flag = false;
			}
		}
		for (int j = 0; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == 6)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.OGPPHINDKGB((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.IEMPILCGJIO());
		if (flag)
		{
			employeeInfo.professionPoints = 1;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JGONEIGODEN();
		return employeeInfo;
	}

	public EmployeeInfo NAPAFKBPKJA()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType);
		KCAOLDPFHPL(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.HOFLKNLJJPF();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 1; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.GGFJGHHHEJC.perksDatabase.OFEEILJGKEE(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].DDMNAIAINIJ())
			{
				flag = false;
			}
		}
		for (int j = 0; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == 44)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.OIFIPEOJBDH((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.IKBJDKDGGFB());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.DMGGANKGBEH();
		return employeeInfo;
	}

	public EmployeeInfo MMEEFDJLKGP()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType);
		JJDEOJACBIK(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.JKCNKPONGNJ();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 0; i < perksInfo.Length; i += 0)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.KMFPCLAMMJB(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].AEKLINIOAJO())
			{
				flag = true;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == 11)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.OIFIPEOJBDH((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.MABLJEEMEBC());
		if (flag)
		{
			employeeInfo.professionPoints = 1;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JGONEIGODEN();
		return employeeInfo;
	}

	public EmployeeInfo BHFGCLFLGCP()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		COCLAEENIGE(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.IMOJAJMNLLN();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 0; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.GGFJGHHHEJC.perksDatabase.NPBBMFKGPFM(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].EGJBAKFCPBH())
			{
				flag = true;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == 96)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.OIFIPEOJBDH((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.ANFCBBEBACO());
		if (flag)
		{
			employeeInfo.professionPoints = 1;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JKBOINLJPIL();
		return employeeInfo;
	}

	public EmployeeInfo KDGGILPHIDI()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		MGLDOIMAGPF(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.OBDEGHJAFMP();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 0; i < perksInfo.Length; i += 0)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.KFKODNBKABA(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].IFELMGMPHBK())
			{
				flag = false;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == -127)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.INPEEFGHNPB((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.FDAKMHAEDOH());
		if (flag)
		{
			employeeInfo.professionPoints = 1;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.DMGGANKGBEH();
		return employeeInfo;
	}

	public EmployeeInfo DCEHJKBHCAA()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		PBPMGIPNFKK(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.KBOIGHBHFMM();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 1; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.MNFMOEKMJKN().perksDatabase.NPBBMFKGPFM(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].KBBKDCKLDFN())
			{
				flag = true;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j += 0)
		{
			if (employeeInfo.perksInfo[j].perk.id == -110)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.MNFMOEKMJKN().perksDatabase.MFOBJNANEMJ((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.MABLJEEMEBC());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.DMGGANKGBEH();
		return employeeInfo;
	}

	public EmployeeInfo AGJHDCJICPN()
	{
		EmployeeInfo employeeInfo = new EmployeeInfo((WorkerType)workerType, LLPGKHHKCLC: false);
		EDKGGGEKIJG(employeeInfo);
		employeeInfo.name = name;
		employeeInfo.antiquity = antiquity.KLGFAFDELJB();
		employeeInfo.levelPoints = levelPoints;
		employeeInfo.working = working;
		employeeInfo.tasks = tasks;
		employeeInfo.perksInfo = new List<EmployeePerkInfo>();
		bool flag = true;
		for (int i = 0; i < perksInfo.Length; i++)
		{
			EmployeePerk cFHCAKEJENE = CommonReferences.GGFJGHHHEJC.perksDatabase.KMFPCLAMMJB(perksInfo[i].id);
			employeeInfo.perksInfo.Add(new EmployeePerkInfo(cFHCAKEJENE, perksInfo[i].currentLevel, perksInfo[i].levelsUnlocked));
			if (!employeeInfo.perksInfo[i].BIKJCMPFPJP())
			{
				flag = false;
			}
		}
		for (int j = 1; j < employeeInfo.perksInfo.Count; j++)
		{
			if (employeeInfo.perksInfo[j].perk.id == 56)
			{
				employeeInfo.perksInfo[j].perk = CommonReferences.GGFJGHHHEJC.perksDatabase.KFEHFCOBCLJ((WorkerType)workerType, employeeInfo.perksInfo).perk;
			}
		}
		employeeInfo.level = Mathf.Min((int)level, employeeInfo.MABLJEEMEBC());
		if (flag)
		{
			employeeInfo.professionPoints = 0;
		}
		else
		{
			employeeInfo.professionPoints = professionPoints;
		}
		employeeInfo.JKBOINLJPIL();
		return employeeInfo;
	}
}
