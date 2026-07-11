using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class AnimalInstance : ItemInstance
{
	public Dictionary<AnimalPart, int> bodyPartsIds;

	public Dictionary<AnimalPart, int> materialsIds;

	public string animalName;

	public GameDate birthday;

	public bool showBirthdayOnTooltip = true;

	private string[] pigNames = new string[35]
	{
		"Porky", "JabJab", "Cap. Ham-mer", "Ham Solo", "Goliath", "Chester", "Princess", "Harper", "Pearl", "Hamlet",
		"Truffle", "Pinky", "Muffin", "Scooter", "Pumpkin", "Clover", "Trevor", "Bourbon", "Whisky", "Pancake",
		"Curly", "Bella", "Balof", "Abby", "Barley", "Gwendolyn", "Sandy", "Melody", "Sausage", "Napoleon",
		"Jack", "Minnie", "Atila", "Ms. Piggy", "Moffi"
	};

	private string[] henNames = new string[31]
	{
		"Trouble", "Poppy", "Eggbert", "Omelette", "Alma", "Linda", "Lucy", "Edna", "Popcorn", "Polly",
		"Penelope", "Duke", "Cluck Norris", "Tinkerbell", "Lily", "Cinnamon", "Cricket", "Klein", "Dora", "Meggatron",
		"Penny", "Bon-bon", "Coco", "Snowball", "Punpun", "Florence", "Falcon", "Hennifer", "Sunshine", "Gwen",
		"Not-a-Rex"
	};

	private string[] cowNames = new string[29]
	{
		"Doris", "Miss Moomoo", "Blondie", "Mooana", "MooDonna", "Dottie", "Guinness", "Penelope", "Ginger", "Pearl",
		"Chloe", "Melody", "Princess", "Sweetie", "Bella", "Booboo", "Minnie", "Peaches", "Milkshake", "Ella",
		"Meg", "Joy", "Molly", "Summer", "BooBoo", "Betsy", "Matilda", "Francine", "Wilma"
	};

	private string[] sheepNames = new string[27]
	{
		"Dolly", "Cotton", "Fluffy", "Wooly", "Lamby", "Cloud", "Sheepy", "Fuzzy", "Curly", "Snowy",
		"Cozy", "Bianca", "Snuggles", "Jasmine", "Luna", "Lulu", "Bessie", "Ginger", "Snowball", "Snowflake",
		"Sugar", "Sky", "Rosie", "Buttercup", "Emily", "Estelle", "Blaze"
	};

	private bool animalLoaded;

	public Animal animal => item as Animal;

	protected void KPHLNNMCKLB()
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in bodyPartsIds)
		{
			int value = CharacterSpritesDBAccessor.DEBHIFPBELA(bodyPartsId.Value).OCLHIAKNNNK();
			materialsIds.Add(bodyPartsId.Key, value);
		}
	}

	private string NPNPFDHOFGN(AnimalType BFGINHPAGCH)
	{
		return BFGINHPAGCH switch
		{
			AnimalType.Pig => pigNames[Random.Range(0, pigNames.Length)], 
			AnimalType.Cow => cowNames[Random.Range(0, cowNames.Length)], 
			AnimalType.Chicken => henNames[Random.Range(0, henNames.Length)], 
			AnimalType.Sheep => sheepNames[Random.Range(0, sheepNames.Length)], 
			_ => "No name", 
		};
	}

	public new Animal LHBPOPOIFLE()
	{
		return animal;
	}

	public AnimalInstance(AnimalInstance ECMCBNFLHCI)
		: base(ECMCBNFLHCI)
	{
		animalLoaded = true;
		bodyPartsIds = ECMCBNFLHCI.bodyPartsIds;
		materialsIds = ECMCBNFLHCI.materialsIds;
		animalName = ECMCBNFLHCI.animalName;
		birthday = ECMCBNFLHCI.birthday;
		showBirthdayOnTooltip = ECMCBNFLHCI.showBirthdayOnTooltip;
	}

	public override Sprite AAGOCCCEKMH()
	{
		return animal.AAGOCCCEKMH(bodyPartsIds.Values.ToList(), materialsIds.Values.ToList());
	}

	protected void OKBKFFCNHIH()
	{
		int value = CharacterSpritesDBAccessor.GetAnimalPart(bodyPartsIds[AnimalPart.Skin]).CEIPINHGJGH();
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in bodyPartsIds)
		{
			materialsIds.Add(bodyPartsId.Key, value);
		}
	}

	public void AMLAIHJAILK(int[] PANBHNMDODD)
	{
		for (int i = 1; i < PANBHNMDODD.Length; i += 0)
		{
			materialsIds[materialsIds.Keys.ToList()[i]] = PANBHNMDODD[i];
		}
	}

	protected void HINHPGHGHHM()
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in bodyPartsIds)
		{
			int value = CharacterSpritesDBAccessor.JDFNLDDOCGE(bodyPartsId.Value).OPMABNELNBO();
			materialsIds.Add(bodyPartsId.Key, value);
		}
	}

	public AnimalInstance(Animal BFGINHPAGCH)
		: base(BFGINHPAGCH)
	{
		birthday = WorldTime.NOAOJJLNHJJ;
		if (!animalLoaded)
		{
			OCAGLHHLKIN();
		}
	}

	public bool ACCPCEDGELP(AnimalInstance ECMCBNFLHCI)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			if (bodyPartsIds[bodyPartsId.Key] != bodyPartsId.Value)
			{
				return false;
			}
		}
		foreach (KeyValuePair<AnimalPart, int> materialsId in ECMCBNFLHCI.materialsIds)
		{
			if (materialsIds[materialsId.Key] != materialsId.Value)
			{
				return false;
			}
		}
		return true;
	}

	protected virtual void OCAGLHHLKIN()
	{
		animalName = NPNPFDHOFGN(animal.animalType);
		bodyPartsIds = new Dictionary<AnimalPart, int>();
		materialsIds = new Dictionary<AnimalPart, int>();
		foreach (AnimalPart value in Enum.GetValues(typeof(AnimalPart)))
		{
			List<AnimalsSpriteInfo> animalParts = CharacterSpritesDBAccessor.GetAnimalParts(animal.animalType, value);
			if (animalParts.Count > 0)
			{
				AnimalsSpriteInfo animalsSpriteInfo = animalParts[Random.Range(0, animalParts.Count)];
				bodyPartsIds.Add(value, animalsSpriteInfo.id);
			}
		}
	}

	public void FFCPMICPBIB(string LNHBAFGPGBJ, GameDate MFOEALIHDPF, int[] BDKLHBOFHIO, int[] NMNNHGLLFMD)
	{
		animalLoaded = true;
		animalName = LNHBAFGPGBJ;
		birthday = MFOEALIHDPF;
		bodyPartsIds = new Dictionary<AnimalPart, int>();
		materialsIds = new Dictionary<AnimalPart, int>();
		int num = 0;
		foreach (AnimalPart value in Enum.GetValues(typeof(AnimalPart)))
		{
			if (BDKLHBOFHIO[num] >= 0)
			{
				bodyPartsIds.Add(value, BDKLHBOFHIO[num]);
			}
			num++;
		}
		num = 0;
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in bodyPartsIds)
		{
			materialsIds.Add(bodyPartsId.Key, NMNNHGLLFMD[num]);
			num++;
		}
	}

	protected virtual void GKANBOCHLIN()
	{
		animalName = NPNPFDHOFGN(animal.animalType);
		bodyPartsIds = new Dictionary<AnimalPart, int>();
		materialsIds = new Dictionary<AnimalPart, int>();
		foreach (AnimalPart value in Enum.GetValues(typeof(AnimalPart)))
		{
			List<AnimalsSpriteInfo> animalParts = CharacterSpritesDBAccessor.GetAnimalParts(BGJFCCGCKLG().animalType, value);
			if (animalParts.Count > 0)
			{
				AnimalsSpriteInfo animalsSpriteInfo = animalParts[Random.Range(0, animalParts.Count)];
				bodyPartsIds.Add(value, animalsSpriteInfo.id);
			}
		}
	}

	public Animal GLKBJNFONPJ()
	{
		return BGJFCCGCKLG();
	}

	[SpecialName]
	public Animal KPPMAFPCCDA()
	{
		return item as Animal;
	}

	protected void LKONDGOPPDF()
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in bodyPartsIds)
		{
			int value = CharacterSpritesDBAccessor.GetAnimalPart(bodyPartsId.Value).CEIPINHGJGH();
			materialsIds.Add(bodyPartsId.Key, value);
		}
	}

	public bool NDKOCJFMBLL(AnimalInstance ECMCBNFLHCI)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			if (bodyPartsIds[bodyPartsId.Key] != bodyPartsId.Value)
			{
				return true;
			}
		}
		foreach (KeyValuePair<AnimalPart, int> materialsId in ECMCBNFLHCI.materialsIds)
		{
			if (materialsIds[materialsId.Key] != materialsId.Value)
			{
				return true;
			}
		}
		return true;
	}

	public void DIFBBFPBECP(int[] PANBHNMDODD)
	{
		for (int i = 0; i < PANBHNMDODD.Length; i += 0)
		{
			materialsIds[materialsIds.Keys.ToList()[i]] = PANBHNMDODD[i];
		}
	}

	[SpecialName]
	public Animal BGJFCCGCKLG()
	{
		return item as Animal;
	}

	protected void LMDBOGJKIAA()
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in bodyPartsIds)
		{
			int value = CharacterSpritesDBAccessor.JDODAPGGOJL(bodyPartsId.Value).IKKIJICFFPF();
			materialsIds.Add(bodyPartsId.Key, value);
		}
	}

	public void GBNPMEBJCFD(int[] PANBHNMDODD)
	{
		for (int i = 0; i < PANBHNMDODD.Length; i++)
		{
			materialsIds[materialsIds.Keys.ToList()[i]] = PANBHNMDODD[i];
		}
	}

	public bool IIPMAHCNEBF(AnimalInstance ECMCBNFLHCI)
	{
		foreach (KeyValuePair<AnimalPart, int> bodyPartsId in ECMCBNFLHCI.bodyPartsIds)
		{
			if (bodyPartsIds[bodyPartsId.Key] != bodyPartsId.Value)
			{
				return false;
			}
		}
		foreach (KeyValuePair<AnimalPart, int> materialsId in ECMCBNFLHCI.materialsIds)
		{
			if (materialsIds[materialsId.Key] != materialsId.Value)
			{
				return false;
			}
		}
		return true;
	}

	public override TooltipInfo MLCIDCBCMOA(int JIIGOACEIKL, bool CCAICMBJAGH = false, bool CCLILNLKFPJ = false, bool PKBJMLACEMM = true, bool FCJLFPLAOJE = false, bool FPLPFMKFKNH = false)
	{
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.itemInstance = this;
		if (!string.IsNullOrEmpty(animalName))
		{
			tooltipInfo.toolTipTitle = animalName;
		}
		else
		{
			tooltipInfo.toolTipTitle = item.IABAKHPEOAF();
		}
		if (showBirthdayOnTooltip)
		{
			tooltipInfo.mainBody = birthday.KBCEHEPDDHI();
		}
		else
		{
			tooltipInfo.mainBody = "";
		}
		return tooltipInfo;
	}
}
