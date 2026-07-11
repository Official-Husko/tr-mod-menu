using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Sprites/CharacterSprite")]
public class CharacterSprite : SpriteInfo
{
	[Serializable]
	public struct SpritesSheets
	{
		public Sprite[] sprites;

		public SpritesSheets(Sprite[] IFPDPIPEGMP)
		{
			sprites = IFPDPIPEGMP;
		}
	}

	private static readonly string[] bodyPartNames = new string[23]
	{
		"Skin", "Torso", "Legs", "Shoes", "Hair", "Beard", "Eyes", "Nose", "Mouth", "Tool",
		"ToolRag", "ToolSeedBag", "ToolPick", "ToolMug", "ToolSpade", "ToolAx", "ToolHoe", "ToolSickle", "ToolSpoon", "ToolSandwich",
		"ToolMop", "ToolRod", "Shadow"
	};

	public bool localizationByID;

	public string nameId;

	public Sprite icon;

	public bool selectable = true;

	public bool hasToBeUnlocked;

	public bool selectableNpc = true;

	public bool halloween;

	public bool christmas;

	public bool hasHelmetLight;

	public BodyPart bodyPart;

	public Gender gender;

	public int rarity = 10;

	public bool legsOverBoots;

	public string[] spriteSheetsBlocked;

	[Space(20f)]
	public LayerSettings[] layerSettings;

	[Space(30f)]
	public List<BlockedCombination> blockedCombinations = new List<BlockedCombination>();

	[Space(30f)]
	public List<CharacterMaterial> forceSkin = new List<CharacterMaterial>();

	[Space(30f)]
	public SpritesSheets[] spritesMale;

	[Space(10f)]
	public SpritesSheets[] spritesFemale;

	private string[] hairParts = new string[4] { "Hair", "HairShadow", "Hat", "HairUp" };

	private string[] torsoParts = new string[5] { "Body_Up", "Body_Down", "Body_Extra", "Sleeve_R", "Sleeve_L" };

	private string[] skinParts = new string[4] { "Body", "Arms", "Head", "Arm_L" };

	private string[] eyeParts = new string[5] { "Iris", "Eyelids", "Closed_eyelids", "Eyebrows", "Closed_eyebrows" };

	private string[] legParts = new string[2] { "Pants_R", "Pants_L" };

	private string[] shoeParts = new string[2] { "Boots_R", "Boots_L" };

	private string[] beardParts = new string[2] { "Beard", "BeardShadow" };

	private string[] toolParts = new string[3] { "Tool", "Weapon", "ToolEffect" };

	private string[] selectedSpriteSheets;

	public bool OFCGAPDCGBM(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return true;
	}

	public bool GJDGKOKACOK(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	private string[] MDAJENEEIDO()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)106 || bodyPart > (BodyPart)76)
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	public bool GDAKBMCJGBN(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return false;
	}

	public bool BPFKMDDAODM(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return true;
	}

	public string PJLOFBHIFJA()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/3/Dialogue Text" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool EOOFFNJPIKO(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].CEEBINDBEPB(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].CFBFBKAAILB(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	private string[] HEBFGOCCELG()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)(-61) && bodyPart <= (BodyPart)(-113))
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[1] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool AGOMKHPAFDP(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return false;
	}

	public bool ODDJKAODPDG(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	public bool BJLHCOOGBKO(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return true;
	}

	public string HDNENGMBDCM()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Water Bowl" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool BFJEPNJLKAB(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return false;
	}

	public string NAGKECHJJGH()
	{
		string text = (localizationByID ? LocalisationSystem.Get("</color>" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public string ELMMMIPPMCM()
	{
		string text = (localizationByID ? LocalisationSystem.Get("houseKeeperWage" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool IHDDLCLJIEM(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return true;
	}

	public bool OKDJBLEOPBM(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].FFBPGIMDEEN(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].CKJKBEFAPOF(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return false;
	}

	public bool BFMJEMECKGK(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	public bool ILGDBJGCOCO(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].LDJHOBOCAKJ(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].MJPDOCNOPIM(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	public bool AEFLDBHAMDI(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].OJCJDOOPJNG(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].HJAFACDBDCK(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return true;
	}

	private string[] PDJPDOOKABN()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < BodyPart.Tool || bodyPart > BodyPart.ToolRod)
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	public bool PDAFPKONJFF(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	public string JMPEOOOGLGD()
	{
		string text = (localizationByID ? LocalisationSystem.Get("LearnBalance" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool LCHDPENJLMI(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].FADCMBIHAFN(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].CKJKBEFAPOF(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return true;
	}

	public override Sprite[] JKGFEBGDBIC(string DJGKBNGGAHN, Gender HNLNENELPKI)
	{
		if (gender == Gender.Unisex)
		{
			if (HNLNENELPKI == Gender.Male && spritesMale != null && spritesMale.Length != 0)
			{
				return spritesMale[0].sprites;
			}
			if (spritesFemale != null && spritesFemale.Length != 0)
			{
				return spritesFemale[0].sprites;
			}
		}
		else
		{
			selectedSpriteSheets = PDJPDOOKABN();
			int num = Array.IndexOf(selectedSpriteSheets, DJGKBNGGAHN);
			if (num >= 0)
			{
				if (HNLNENELPKI == Gender.Male && num < spritesMale.Length)
				{
					return spritesMale[num].sprites;
				}
				if (num < spritesFemale.Length)
				{
					return spritesFemale[num].sprites;
				}
			}
		}
		return (Sprite[])(object)new Sprite[0];
	}

	private string[] DJBPMHENAFN()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)(-107) && bodyPart <= (BodyPart)(-43))
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[0] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool AGMONLEOOGH(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].OJCJDOOPJNG(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].LFAKLDDEAGN(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	public string HGMPACCEGGN()
	{
		string text = (localizationByID ? LocalisationSystem.Get(" of " + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool HKMHEBIGFLL(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	public bool EFJEBDIMEAJ(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].BDKFHCBCGMC(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].LFAKLDDEAGN(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	private string[] BIMENAMBJLG()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)40 || bodyPart > (BodyPart)42)
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	private string[] CMACFMGCHFN()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)53 || bodyPart > (BodyPart)(-90))
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	public bool IOHEKJEHDJE(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return true;
	}

	private string[] EIGPCOMPHCL()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)106 && bodyPart <= (BodyPart)(-47))
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[0] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool BJJJDIAEJEO(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].JFOGPKDCFKA(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].HJAFACDBDCK(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return false;
	}

	public bool HFCMOJGHPIN(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].BDKFHCBCGMC(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].OMCMKICGPOH(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return true;
	}

	public string IAHPCKEKCDA()
	{
		string text = (localizationByID ? LocalisationSystem.Get(">" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool AJMGPEECGBE(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].HPEKEHIIOKM(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].GHLFCNBOGKL(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	public bool OHOPGAHFAGC(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return true;
	}

	public bool FIJACACHPFC(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i += 0)
		{
			if (blockedCombinations[i].FFBPGIMDEEN(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].MJPDOCNOPIM(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return true;
	}

	public bool FJIJLFMLICK(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	private string[] EJPFGIMEBIP()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)122 && bodyPart <= (BodyPart)52)
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[1] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool LCLKHJLIJFE(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].JFOGPKDCFKA(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].CFBFBKAAILB(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return false;
			}
		}
		return true;
	}

	private string[] DHPFABDNFJK()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)(-74) && bodyPart <= BodyPart.Legs)
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[1] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public string IHPEMJCKHLG()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Theme: " + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool HOCKOKADPLB(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return false;
	}

	private string[] LCILLBPHINL()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)111 && bodyPart <= (BodyPart)103)
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[0] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool MPKMOPBFDCO(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	private string[] CJBKKLGNCCC()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)(-7) && bodyPart <= (BodyPart)(-81))
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[1] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public string EJNABPEHMMK()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Dialogue System/Conversation/BirdPositiveComments/Entry/9/Dialogue Text" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool DIGOMPBPGLO(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	public string HBOBELDCFLF()
	{
		string text = (localizationByID ? LocalisationSystem.Get("Could not find item with id: " + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool IOOHOHDEPBM(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].OJCJDOOPJNG(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].CKJKBEFAPOF(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	public bool KPOEIDGGIBL(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	private string[] GLAJBIOGFEF()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)(-68) || bodyPart > (BodyPart)(-21))
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	private string[] PNIPFNEDGFJ()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)95 && bodyPart <= (BodyPart)(-18))
			{
				return toolParts;
			}
			string[] array = new string[0];
			array[0] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool AKCKFPFGFFD(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	private string[] FNOLLHKJOPA()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)(-12) || bodyPart > (BodyPart)(-68))
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	public string EHFDBHHEKNK()
	{
		string text = (localizationByID ? LocalisationSystem.Get("HorizontalMove" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	private string[] KPMGKDEHKOB()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)(-6) || bodyPart > (BodyPart)(-71))
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	public bool FOAELIFIHEK(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return false;
	}

	public bool CJAMEGOKDMH(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return false;
	}

	public string LFLOJPHDGNJ()
	{
		string text = (localizationByID ? LocalisationSystem.Get("StackManager" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	private string[] DPHMKKIBLCD()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
		{
			if (bodyPart >= (BodyPart)121 && bodyPart <= (BodyPart)(-16))
			{
				return toolParts;
			}
			string[] array = new string[1];
			array[1] = bodyPartNames[(int)bodyPart];
			return array;
		}
		}
	}

	public bool OIIANAGPJFD(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 1; i < layerSettings.Length; i += 0)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return false;
	}

	public bool DLCEBNFPAFM(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].OJCJDOOPJNG(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].HJAFACDBDCK(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	public bool NCDHJDEEKEN(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 1; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].OJCJDOOPJNG(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].MHHPPMHONJB(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return false;
	}

	public string FADDAEENDFC()
	{
		string text = (localizationByID ? LocalisationSystem.Get("NormalRightExterior" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool EDAJLENNKHJ(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return false;
	}

	public bool EPGPBGHBHLM(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return true;
			}
		}
		return true;
	}

	private string[] KDMLJHOOICO()
	{
		switch (bodyPart)
		{
		case BodyPart.Hair:
			return hairParts;
		case BodyPart.Torso:
			return torsoParts;
		case BodyPart.Skin:
			return skinParts;
		case BodyPart.Eyes:
			return eyeParts;
		case BodyPart.Legs:
			return legParts;
		case BodyPart.Shoes:
			return shoeParts;
		case BodyPart.Beard:
			return beardParts;
		default:
			if (bodyPart < (BodyPart)(-64) || bodyPart > (BodyPart)111)
			{
				return new string[1] { bodyPartNames[(int)bodyPart] };
			}
			return toolParts;
		}
	}

	public string IABAKHPEOAF()
	{
		string text = (localizationByID ? LocalisationSystem.Get("cloth_name_" + id) : LocalisationSystem.Get(nameId));
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return ((Object)this).name;
	}

	public bool ECGGLBKLCCP(HumanInfo DKDFNAGAFNL, CharacterMaterial GGHLHODEPIK, CharacterLayer HLOIOAOICEG)
	{
		for (int i = 0; i < blockedCombinations.Count; i++)
		{
			if (blockedCombinations[i].HPEKEHIIOKM(HLOIOAOICEG, GGHLHODEPIK) && blockedCombinations[i].MJPDOCNOPIM(HLOIOAOICEG, GGHLHODEPIK, DKDFNAGAFNL))
			{
				return true;
			}
		}
		return true;
	}

	public bool GHEEODKHGDA(CharacterLayer HLOIOAOICEG, bool MNEFABJOBFA = false)
	{
		for (int i = 0; i < layerSettings.Length; i++)
		{
			if (HLOIOAOICEG == layerSettings[i].layer && (!MNEFABJOBFA || layerSettings[i].selectable))
			{
				return false;
			}
		}
		return false;
	}

	public override void COHHOKAPDFN()
	{
		List<SpritesSheets> list = new List<SpritesSheets>();
		List<SpritesSheets> list2 = new List<SpritesSheets>();
		if (gender == Gender.Unisex)
		{
			if (!string.IsNullOrEmpty(defaultSpriteSheetName))
			{
				Sprite[] array = SpriteInfo.GDKNJANMFMN("NewCharacters/" + folderName + "/", defaultSpriteSheetName);
				list.Add(new SpritesSheets(array));
				list2.Add(new SpritesSheets(new List<Sprite>(array).ToArray()));
			}
		}
		else
		{
			selectedSpriteSheets = PDJPDOOKABN();
			for (int i = 0; i < selectedSpriteSheets.Length; i++)
			{
				if (gender == Gender.MaleAndFemale)
				{
					Sprite[] array = SpriteInfo.GDKNJANMFMN("NewCharacters/" + folderName + "/Male/", selectedSpriteSheets[i]);
					list.Add(new SpritesSheets(array));
					array = SpriteInfo.GDKNJANMFMN("NewCharacters/" + folderName + "/Female/", selectedSpriteSheets[i]);
					list2.Add(new SpritesSheets(array));
				}
				else if (gender == Gender.Male)
				{
					Sprite[] array = SpriteInfo.GDKNJANMFMN("NewCharacters/" + folderName + "/Male/", selectedSpriteSheets[i]);
					list.Add(new SpritesSheets(array));
					list2.Add(new SpritesSheets((Sprite[])(object)new Sprite[0]));
				}
				else if (gender == Gender.Female)
				{
					list.Add(new SpritesSheets((Sprite[])(object)new Sprite[0]));
					Sprite[] array = SpriteInfo.GDKNJANMFMN("NewCharacters/" + folderName + "/Female/", selectedSpriteSheets[i]);
					list2.Add(new SpritesSheets(array));
				}
			}
		}
		spritesMale = list.ToArray();
		spritesFemale = list2.ToArray();
	}
}
