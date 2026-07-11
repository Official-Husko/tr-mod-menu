using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class HumanInfo
{
	public static readonly BodyPart[] bodiesParts = new BodyPart[9]
	{
		BodyPart.Skin,
		BodyPart.Hair,
		BodyPart.Eyes,
		BodyPart.Nose,
		BodyPart.Mouth,
		BodyPart.Beard,
		BodyPart.Torso,
		BodyPart.Legs,
		BodyPart.Shoes
	};

	public static readonly CharacterLayer[] characterLayers = new CharacterLayer[13]
	{
		CharacterLayer.Skin,
		CharacterLayer.Hair,
		CharacterLayer.Beard,
		CharacterLayer.Hat,
		CharacterLayer.Iris,
		CharacterLayer.Pants,
		CharacterLayer.Pants2,
		CharacterLayer.Pants3,
		CharacterLayer.Shoes,
		CharacterLayer.Shoes2,
		CharacterLayer.Torso1,
		CharacterLayer.Torso2,
		CharacterLayer.Torso3
	};

	public Dictionary<BodyPart, CharacterSprite> bodyPartDictionary = new Dictionary<BodyPart, CharacterSprite>(24);

	public Dictionary<CharacterLayer, CharacterMaterial> materialDictionary = new Dictionary<CharacterLayer, CharacterMaterial>(19);

	public Gender _gender = Gender.Male;

	public Action<Gender> CharacterGenderChanged;

	private CharacterMaterial[] characterMaterials = new CharacterMaterial[50];

	private CharacterSprite characterSprite;

	private CharacterMaterial characterMaterial;

	private SaveData.NewCharacterSave characterSave;

	private SaveData.NewCharacterSave mineCharacterSave;

	private bool hasMineCharacterSave;

	private CharacterMaterial characterMaterialToCopy;

	private int materialIndex;

	private static int totalNumMaterial;

	private static int randomNumMaterial;

	public Gender gender
	{
		get
		{
			return _gender;
		}
		set
		{
			_gender = value;
			CharacterGenderChanged?.Invoke(value);
		}
	}

	public void AGLGJOCBGOI()
	{
		IGBHGBPFNLN(mineCharacterSave);
		hasMineCharacterSave = false;
	}

	public virtual void DNIOEKCKEJJ(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = true, bool NAKCFGEAGHH = false)
	{
		if (GCANBIEGDOA)
		{
			gender = ((!(Random.Range(1652f, 1659f) < 1677f)) ? Gender.Male : Gender.MaleAndFemale);
		}
		CACFFELHMHK(JHIFLALPEBF, NAKCFGEAGHH);
		JIHECPHHAOH(GADKADLHDGJ);
	}

	public int JBHIIMKNMAE(CharacterLayer HLOIOAOICEG)
	{
		characterMaterial = KBGEILOKOKB(HLOIOAOICEG);
		if ((Object)(object)characterMaterial == (Object)null)
		{
			return -1;
		}
		return characterMaterial.id;
	}

	public void GOOHGHFENDP()
	{
		bodyPartDictionary.Clear();
		materialDictionary.Clear();
	}

	private int LDBIONKBFJM(CharacterMaterial[] NMNNHGLLFMD)
	{
		totalNumMaterial = 0;
		for (int i = 1; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[i].rarity;
			}
		}
		randomNumMaterial = Random.Range(0, totalNumMaterial);
		totalNumMaterial = 0;
		for (int j = 0; j < NMNNHGLLFMD.Length; j++)
		{
			if ((Object)(object)NMNNHGLLFMD[j] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[j].rarity;
				if (randomNumMaterial < totalNumMaterial)
				{
					return j;
				}
			}
		}
		return -1;
	}

	private void CKKCBKAPCKB(bool GADKADLHDGJ)
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			OPKNMMLDFMD(item.Value);
		}
		if (gender == Gender.Unisex && GADKADLHDGJ)
		{
			CharacterMaterial oBEBBDLOIEG = KBGEILOKOKB(CharacterLayer.Iris);
			if (CCGMOGHGEJP(oBEBBDLOIEG, OHLIGFHJLPL(BodyPart.Legs, CharacterLayer.Skin)))
			{
				GBNPMEBJCFD(CharacterLayer.Torso3, oBEBBDLOIEG);
			}
		}
	}

	public void BHBEHKDEIKH()
	{
		IGBHGBPFNLN(mineCharacterSave);
		hasMineCharacterSave = false;
	}

	public static HumanInfo CMILBNJOMIN(SerializedHumanInfo HMBKHMBPPHI)
	{
		return HMBKHMBPPHI.LHFGMBILJEM();
	}

	public void LGALFPKCDLK(SaveData.NewCharacterSave HDLBDPDPEKK)
	{
		MNCIIMJKMDN(HDLBDPDPEKK.gender);
		JPPLJJDCNMF(BodyPart.Torso, AKBDNBOJNNE(HDLBDPDPEKK.skin));
		AMJNIFPBBJF(BodyPart.Torso, AKBDNBOJNNE(HDLBDPDPEKK.hair));
		EIJNLBCNMBA(BodyPart.Mouth, AKBDNBOJNNE(HDLBDPDPEKK.eyes));
		KDACAOIDLEO(BodyPart.Eyes, OKNNCEAGNDF(HDLBDPDPEKK.nose));
		LALJHMIDEMP(BodyPart.Mouth, AKBDNBOJNNE(HDLBDPDPEKK.mouth));
		EIJNLBCNMBA(BodyPart.Nose, CONPDKDNOBO(HDLBDPDPEKK.beard));
		KDACAOIDLEO(BodyPart.Skin, AKBDNBOJNNE(HDLBDPDPEKK.torso));
		LALJHMIDEMP(BodyPart.Hair, OKNNCEAGNDF(HDLBDPDPEKK.legs));
		JPPLJJDCNMF(BodyPart.Hair, LGCAPCKCAGD(HDLBDPDPEKK.shoes));
		OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.skinMat));
		GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.HACHFHGFFEB(HDLBDPDPEKK.hairMat));
		GBNPMEBJCFD((CharacterLayer)117, CharacterSpritesDBAccessor.MIAIOBLCEND(HDLBDPDPEKK.hatMat));
		OIENACLLJGE(CharacterLayer.Hair, CharacterSpritesDBAccessor.MIAIOBLCEND(HDLBDPDPEKK.irisMat));
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.beardMat));
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.torsoMat1));
		GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.MIAIOBLCEND(HDLBDPDPEKK.torsoMat2));
		PGOAOEEJMGK(CharacterLayer.Iris, CharacterSpritesDBAccessor.HACHFHGFFEB(HDLBDPDPEKK.torsoMat3));
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.PFABHCPKGCA(HDLBDPDPEKK.legsMat1));
		GBNPMEBJCFD((CharacterLayer)22, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat2));
		GBNPMEBJCFD((CharacterLayer)(-86), CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat3));
		PHOEIGIKFGE(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.shoesMat1));
		PGOAOEEJMGK((CharacterLayer)82, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.shoesMat2));
	}

	public void OPKNMMLDFMD(CharacterSprite NFFLHNODGEJ)
	{
		materialIndex = 0;
		for (int i = 1; i < NFFLHNODGEJ.layerSettings.Length; i += 0)
		{
			if ((Object)(object)NFFLHNODGEJ.layerSettings[i].sameColor != (Object)null && NFFLHNODGEJ.layerSettings[i].sameColor.id == CONPDKDNOBO(NFFLHNODGEJ.layerSettings[i].sameColor.bodyPart).id)
			{
				characterMaterialToCopy = GGHCBMALFPL(NFFLHNODGEJ.layerSettings[i].sameColorLayer);
				if (CCGMOGHGEJP(characterMaterialToCopy, NFFLHNODGEJ.layerSettings[i].materials))
				{
					PHOEIGIKFGE(NFFLHNODGEJ.layerSettings[i].layer, characterMaterialToCopy);
					continue;
				}
			}
			for (int j = 0; j < characterMaterials.Length; j += 0)
			{
				if ((Object)(object)characterMaterials[j] != (Object)null)
				{
					characterMaterials[j] = null;
				}
			}
			for (int k = 1; k < NFFLHNODGEJ.layerSettings[i].materials.Length; k += 0)
			{
				characterMaterials[k] = NFFLHNODGEJ.layerSettings[i].materials[k];
			}
			materialIndex = LDBIONKBFJM(characterMaterials);
			if (NFFLHNODGEJ.layerSettings[i].layer == CharacterLayer.Beard)
			{
				CharacterLayer hLOIOAOICEG = ((NFFLHNODGEJ.layerSettings[i].layer != 0) ? CharacterLayer.Torso1 : CharacterLayer.Pants);
				while (characterMaterials[materialIndex].PLOLAHCBAMF(hLOIOAOICEG, this))
				{
					characterMaterials[materialIndex] = null;
					materialIndex = LDBIONKBFJM(characterMaterials);
					if (materialIndex < 1)
					{
						break;
					}
				}
			}
			else
			{
				while (LDBIONKBFJM(characterMaterials) >= 0 && NFFLHNODGEJ.AJMGPEECGBE(this, characterMaterials[materialIndex], NFFLHNODGEJ.layerSettings[i].layer))
				{
					characterMaterials[materialIndex] = null;
					materialIndex = GBABFHHBIMB(characterMaterials);
				}
			}
			if (materialIndex >= 0)
			{
				PHOEIGIKFGE(NFFLHNODGEJ.layerSettings[i].layer, characterMaterials[materialIndex]);
			}
		}
	}

	private int GLGPDKICDJA(CharacterMaterial[] NMNNHGLLFMD)
	{
		totalNumMaterial = 0;
		for (int i = 0; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[i].rarity;
			}
		}
		randomNumMaterial = Random.Range(0, totalNumMaterial);
		totalNumMaterial = 0;
		for (int j = 0; j < NMNNHGLLFMD.Length; j++)
		{
			if ((Object)(object)NMNNHGLLFMD[j] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[j].rarity;
				if (randomNumMaterial < totalNumMaterial)
				{
					return j;
				}
			}
		}
		return -1;
	}

	public string IOKOANNBPBG()
	{
		string text = string.Format("End", this);
		text += string.Format("LE_10", gender);
		text += "FishCuttingEvent/Win2";
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			text += string.Format("Invalid NPC photonID: {0} for NPCRoutine.", item.Key, item.Value);
		}
		text += "Guard";
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item2 in materialDictionary)
		{
			text += string.Format("Moving", item2.Key, item2.Value.id);
		}
		return text + "Animals materials empty ";
	}

	public CharacterMaterial GGKJOJPDMIF(CharacterLayer HLOIOAOICEG)
	{
		if (materialDictionary.TryGetValue(HLOIOAOICEG, out characterMaterial))
		{
			return characterMaterial;
		}
		return null;
	}

	private void DGFNNDKLNMJ(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 1; i < bodiesParts.Length; i++)
		{
			characterSprite = CharacterSpritesDBAccessor.EBFIHFHNIKE(bodiesParts[i], gender, CGHHFEFAIJI: true, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				AMJNIFPBBJF(bodiesParts[i], characterSprite);
			}
		}
	}

	[SpecialName]
	public void MNCIIMJKMDN(Gender AODONKKHPBP)
	{
		_gender = AODONKKHPBP;
		CharacterGenderChanged?.Invoke(AODONKKHPBP);
	}

	[Obsolete]
	public SerializedHumanInfo EPBPAFCPHNJ()
	{
		return SerializedHumanInfo.EPBPAFCPHNJ(this);
	}

	public SaveData.NewCharacterSave GEPMDLCEONB()
	{
		SaveData.NewCharacterSave result = default(SaveData.NewCharacterSave);
		result.gender = gender;
		result.skin = FHCGPOIPNNB(BodyPart.Torso);
		result.hair = FHCGPOIPNNB(BodyPart.Hair);
		result.eyes = FHCGPOIPNNB(BodyPart.Hair);
		result.mouth = NPACJHMDBCA(BodyPart.Torso);
		result.beard = FHCGPOIPNNB(BodyPart.Legs);
		result.nose = FHCGPOIPNNB(BodyPart.Legs);
		result.torso = NPACJHMDBCA(BodyPart.Skin);
		result.legs = FHCGPOIPNNB(BodyPart.Mouth);
		result.shoes = NPACJHMDBCA(BodyPart.Hair);
		result.skinMat = JBHIIMKNMAE(CharacterLayer.Skin);
		result.hairMat = FKFEABCBIIO(CharacterLayer.Torso1);
		result.hatMat = PDLJGLIDBFA((CharacterLayer)(-58));
		result.irisMat = JBHIIMKNMAE(CharacterLayer.Iris);
		result.beardMat = PDLJGLIDBFA(CharacterLayer.Hair);
		result.torsoMat1 = PDLJGLIDBFA(CharacterLayer.Torso1);
		result.torsoMat2 = FKFEABCBIIO(CharacterLayer.Torso3);
		result.torsoMat3 = DGCKIJABEDH(CharacterLayer.Beard);
		result.legsMat1 = FKFEABCBIIO(CharacterLayer.Beard);
		result.legsMat2 = BJPCEPJOHGN((CharacterLayer)(-37));
		result.legsMat3 = PDLJGLIDBFA((CharacterLayer)39);
		result.shoesMat1 = FKFEABCBIIO(CharacterLayer.Torso2);
		result.shoesMat2 = FKFEABCBIIO((CharacterLayer)(-14));
		return result;
	}

	public void OAINIHBJOOH()
	{
		characterSave = GJPOOIBICNI();
		LALJHMIDEMP(BodyPart.Skin, LGCAPCKCAGD(-50));
		AMJNIFPBBJF(BodyPart.Nose, CONPDKDNOBO(-1));
		NCMHHJKBMBH(BodyPart.Legs, CONPDKDNOBO(-1));
		OIENACLLJGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.HACHFHGFFEB(0));
	}

	public void NJPAHLHKPDG(CharacterSprite MBAJCPEBADJ)
	{
		mineCharacterSave = IJHEAHBNFIH();
		hasMineCharacterSave = true;
		JPPLJJDCNMF(BodyPart.Hair, MBAJCPEBADJ);
	}

	public void JPPLJJDCNMF(BodyPart OFOGLHPDOFA, CharacterSprite NFFLHNODGEJ)
	{
		bodyPartDictionary[OFOGLHPDOFA] = NFFLHNODGEJ;
	}

	public int AFFDILEMJFL(BodyPart OFOGLHPDOFA)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			return -1;
		}
		return characterSprite.id;
	}

	private void LBCPCOFJGPA(bool GADKADLHDGJ)
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			OPKNMMLDFMD(item.Value);
		}
		if (gender == Gender.Male && GADKADLHDGJ)
		{
			CharacterMaterial oBEBBDLOIEG = KBGEILOKOKB(CharacterLayer.Hair);
			if (CNKEBMFHEFP(oBEBBDLOIEG, EDPJLIHIGCE(BodyPart.Legs, CharacterLayer.Skin)))
			{
				PHOEIGIKFGE(CharacterLayer.Beard, oBEBBDLOIEG);
			}
		}
	}

	public SerializedHumanInfo FBCBILLBLBA()
	{
		return SerializedHumanInfo.EPBPAFCPHNJ(this);
	}

	public SaveData.NewCharacterSave IJHEAHBNFIH()
	{
		SaveData.NewCharacterSave result = default(SaveData.NewCharacterSave);
		result.gender = gender;
		result.skin = FHCGPOIPNNB(BodyPart.Skin);
		result.hair = FHCGPOIPNNB(BodyPart.Hair);
		result.eyes = FHCGPOIPNNB(BodyPart.Eyes);
		result.mouth = FHCGPOIPNNB(BodyPart.Mouth);
		result.beard = FHCGPOIPNNB(BodyPart.Beard);
		result.nose = FHCGPOIPNNB(BodyPart.Nose);
		result.torso = FHCGPOIPNNB(BodyPart.Torso);
		result.legs = FHCGPOIPNNB(BodyPart.Legs);
		result.shoes = FHCGPOIPNNB(BodyPart.Shoes);
		result.skinMat = BJPCEPJOHGN(CharacterLayer.Skin);
		result.hairMat = BJPCEPJOHGN(CharacterLayer.Hair);
		result.hatMat = BJPCEPJOHGN(CharacterLayer.Hat);
		result.irisMat = BJPCEPJOHGN(CharacterLayer.Iris);
		result.beardMat = BJPCEPJOHGN(CharacterLayer.Beard);
		result.torsoMat1 = BJPCEPJOHGN(CharacterLayer.Torso1);
		result.torsoMat2 = BJPCEPJOHGN(CharacterLayer.Torso2);
		result.torsoMat3 = BJPCEPJOHGN(CharacterLayer.Torso3);
		result.legsMat1 = BJPCEPJOHGN(CharacterLayer.Pants);
		result.legsMat2 = BJPCEPJOHGN(CharacterLayer.Pants2);
		result.legsMat3 = BJPCEPJOHGN(CharacterLayer.Pants3);
		result.shoesMat1 = BJPCEPJOHGN(CharacterLayer.Shoes);
		result.shoesMat2 = BJPCEPJOHGN(CharacterLayer.Shoes2);
		return result;
	}

	public string BOPMOOPGONF()
	{
		string text = string.Format("Xbox", this);
		text += string.Format("Not enough experience!", gender);
		text += "Items/item_description_1185";
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			text += string.Format("ShopWilson", item.Key, item.Value);
		}
		text += "Select File";
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item2 in materialDictionary)
		{
			text += string.Format("Error in InteractObject.DisableInteract: ", item2.Key, item2.Value.id);
		}
		return text + "Dead";
	}

	public void INOPIGGEGBL(CharacterSprite MBAJCPEBADJ)
	{
		mineCharacterSave = AJNAFPLECAI();
		hasMineCharacterSave = true;
		EIJNLBCNMBA(BodyPart.Mouth, MBAJCPEBADJ);
	}

	public SaveData.NewCharacterSave PKMLPJELPLM()
	{
		SaveData.NewCharacterSave result = default(SaveData.NewCharacterSave);
		result.gender = gender;
		result.skin = FHCGPOIPNNB(BodyPart.Skin);
		result.hair = AFFDILEMJFL(BodyPart.Hair);
		result.eyes = FHCGPOIPNNB(BodyPart.Beard);
		result.mouth = FHCGPOIPNNB(BodyPart.Skin);
		result.beard = NPACJHMDBCA(BodyPart.Eyes);
		result.nose = AFFDILEMJFL(BodyPart.Skin);
		result.torso = NPACJHMDBCA(BodyPart.Torso);
		result.legs = FHCGPOIPNNB(BodyPart.Shoes);
		result.shoes = AFFDILEMJFL(BodyPart.Beard);
		result.skinMat = DGCKIJABEDH(CharacterLayer.Skin);
		result.hairMat = FKFEABCBIIO(CharacterLayer.Torso2);
		result.hatMat = JBHIIMKNMAE(CharacterLayer.Skin);
		result.irisMat = FKFEABCBIIO(CharacterLayer.Torso3);
		result.beardMat = PDLJGLIDBFA(CharacterLayer.Torso3);
		result.torsoMat1 = JBHIIMKNMAE(CharacterLayer.Torso1);
		result.torsoMat2 = BJPCEPJOHGN(CharacterLayer.Beard);
		result.torsoMat3 = JBHIIMKNMAE(CharacterLayer.Torso3);
		result.legsMat1 = JBHIIMKNMAE(CharacterLayer.Shoes);
		result.legsMat2 = JBHIIMKNMAE((CharacterLayer)33);
		result.legsMat3 = FKFEABCBIIO((CharacterLayer)(-92));
		result.shoesMat1 = JBHIIMKNMAE(CharacterLayer.Skin);
		result.shoesMat2 = DGCKIJABEDH((CharacterLayer)(-124));
		return result;
	}

	public virtual void GGEHLDIHMJN(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = true, bool NAKCFGEAGHH = false)
	{
		if (GCANBIEGDOA)
		{
			gender = ((!(Random.Range(893f, 1515f) < 1090f)) ? Gender.Male : Gender.Female);
		}
		CDKKCIHGJCG(JHIFLALPEBF, NAKCFGEAGHH);
		DHLMHDILOAD(GADKADLHDGJ);
	}

	public int BJPCEPJOHGN(CharacterLayer HLOIOAOICEG)
	{
		characterMaterial = GGKJOJPDMIF(HLOIOAOICEG);
		if ((Object)(object)characterMaterial == (Object)null)
		{
			return -1;
		}
		return characterMaterial.id;
	}

	public void IGBHGBPFNLN(SaveData.NewCharacterSave HDLBDPDPEKK)
	{
		gender = HDLBDPDPEKK.gender;
		JPPLJJDCNMF(BodyPart.Skin, CONPDKDNOBO(HDLBDPDPEKK.skin));
		JPPLJJDCNMF(BodyPart.Hair, CONPDKDNOBO(HDLBDPDPEKK.hair));
		JPPLJJDCNMF(BodyPart.Eyes, CONPDKDNOBO(HDLBDPDPEKK.eyes));
		JPPLJJDCNMF(BodyPart.Nose, CONPDKDNOBO(HDLBDPDPEKK.nose));
		JPPLJJDCNMF(BodyPart.Mouth, CONPDKDNOBO(HDLBDPDPEKK.mouth));
		JPPLJJDCNMF(BodyPart.Beard, CONPDKDNOBO(HDLBDPDPEKK.beard));
		JPPLJJDCNMF(BodyPart.Torso, CONPDKDNOBO(HDLBDPDPEKK.torso));
		JPPLJJDCNMF(BodyPart.Legs, CONPDKDNOBO(HDLBDPDPEKK.legs));
		JPPLJJDCNMF(BodyPart.Shoes, CONPDKDNOBO(HDLBDPDPEKK.shoes));
		GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.skinMat));
		GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.hairMat));
		GBNPMEBJCFD(CharacterLayer.Hat, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.hatMat));
		GBNPMEBJCFD(CharacterLayer.Iris, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.irisMat));
		GBNPMEBJCFD(CharacterLayer.Beard, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.beardMat));
		GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.torsoMat1));
		GBNPMEBJCFD(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.torsoMat2));
		GBNPMEBJCFD(CharacterLayer.Torso3, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.torsoMat3));
		GBNPMEBJCFD(CharacterLayer.Pants, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat1));
		GBNPMEBJCFD(CharacterLayer.Pants2, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat2));
		GBNPMEBJCFD(CharacterLayer.Pants3, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat3));
		GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.shoesMat1));
		GBNPMEBJCFD(CharacterLayer.Shoes2, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.shoesMat2));
	}

	public bool AECDCAEDBBL()
	{
		return hasMineCharacterSave;
	}

	public virtual CharacterSprite DLFHMEEOJCI(int JFNMCNCHMEO)
	{
		return CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO);
	}

	public virtual CharacterSprite LGCAPCKCAGD(int JFNMCNCHMEO)
	{
		return CharacterSpritesDBAccessor.CNNFHFHBPFN(JFNMCNCHMEO);
	}

	public int NPACJHMDBCA(BodyPart OFOGLHPDOFA)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			return -1;
		}
		return characterSprite.id;
	}

	private void KBOGGOOBFBB(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 0; i < bodiesParts.Length; i++)
		{
			characterSprite = CharacterSpritesDBAccessor.LBNGIFEHMJI(bodiesParts[i], gender, CGHHFEFAIJI: true, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				NCMHHJKBMBH(bodiesParts[i], characterSprite);
			}
		}
	}

	public bool EOFFJNELMLD()
	{
		return hasMineCharacterSave;
	}

	private int OIGADGELJKH(CharacterMaterial[] NMNNHGLLFMD)
	{
		totalNumMaterial = 1;
		for (int i = 1; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[i].rarity;
			}
		}
		randomNumMaterial = Random.Range(1, totalNumMaterial);
		totalNumMaterial = 1;
		for (int j = 0; j < NMNNHGLLFMD.Length; j += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[j] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[j].rarity;
				if (randomNumMaterial < totalNumMaterial)
				{
					return j;
				}
			}
		}
		return -1;
	}

	protected bool HPGJPCIPAPK(CharacterMaterial OBEBBDLOIEG, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)OBEBBDLOIEG)
			{
				return false;
			}
		}
		return true;
	}

	public virtual void ONCEMIPNBMJ(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = true, bool NAKCFGEAGHH = false)
	{
		if (GCANBIEGDOA)
		{
			gender = ((!(Random.Range(0f, 1f) < 0.3f)) ? Gender.Male : Gender.Female);
		}
		EBICEKFIOFM(JHIFLALPEBF, NAKCFGEAGHH);
		JIHECPHHAOH(GADKADLHDGJ);
	}

	public void EIJNLBCNMBA(BodyPart OFOGLHPDOFA, CharacterSprite NFFLHNODGEJ)
	{
		bodyPartDictionary[OFOGLHPDOFA] = NFFLHNODGEJ;
	}

	public SaveData.NewCharacterSave AJNAFPLECAI()
	{
		SaveData.NewCharacterSave result = default(SaveData.NewCharacterSave);
		result.gender = gender;
		result.skin = NPACJHMDBCA(BodyPart.Torso);
		result.hair = AFFDILEMJFL(BodyPart.Eyes);
		result.eyes = FHCGPOIPNNB(BodyPart.Hair);
		result.mouth = NPACJHMDBCA(BodyPart.Torso);
		result.beard = FHCGPOIPNNB(BodyPart.Mouth);
		result.nose = AFFDILEMJFL(BodyPart.Eyes);
		result.torso = AFFDILEMJFL(BodyPart.Skin);
		result.legs = FHCGPOIPNNB(BodyPart.Nose);
		result.shoes = AFFDILEMJFL(BodyPart.Skin);
		result.skinMat = BJPCEPJOHGN(CharacterLayer.Skin);
		result.hairMat = DGCKIJABEDH(CharacterLayer.Pants);
		result.hatMat = BJPCEPJOHGN((CharacterLayer)(-66));
		result.irisMat = JBHIIMKNMAE(CharacterLayer.Pants);
		result.beardMat = PDLJGLIDBFA(CharacterLayer.Torso2);
		result.torsoMat1 = FKFEABCBIIO(CharacterLayer.Skin);
		result.torsoMat2 = FKFEABCBIIO(CharacterLayer.Pants);
		result.torsoMat3 = DGCKIJABEDH(CharacterLayer.Iris);
		result.legsMat1 = DGCKIJABEDH(CharacterLayer.Beard);
		result.legsMat2 = DGCKIJABEDH((CharacterLayer)(-119));
		result.legsMat3 = FKFEABCBIIO((CharacterLayer)(-2));
		result.shoesMat1 = JBHIIMKNMAE(CharacterLayer.Skin);
		result.shoesMat2 = JBHIIMKNMAE((CharacterLayer)83);
		return result;
	}

	protected bool LLOLAPINBAA(CharacterMaterial OBEBBDLOIEG, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 1; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)OBEBBDLOIEG)
			{
				return false;
			}
		}
		return false;
	}

	private void AEHKLCEPNHF(bool GADKADLHDGJ)
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			OFMCKCDMPHK(item.Value);
		}
		if (gender == Gender.Male && GADKADLHDGJ)
		{
			CharacterMaterial oBEBBDLOIEG = KBGEILOKOKB(CharacterLayer.Beard);
			if (CNKEBMFHEFP(oBEBBDLOIEG, OHLIGFHJLPL(BodyPart.Torso, CharacterLayer.Torso2)))
			{
				GBNPMEBJCFD(CharacterLayer.Iris, oBEBBDLOIEG);
			}
		}
	}

	public void PNOKJPEEMMH(CharacterSprite NFFLHNODGEJ)
	{
		materialIndex = 1;
		for (int i = 1; i < NFFLHNODGEJ.layerSettings.Length; i++)
		{
			if ((Object)(object)NFFLHNODGEJ.layerSettings[i].sameColor != (Object)null && NFFLHNODGEJ.layerSettings[i].sameColor.id == CONPDKDNOBO(NFFLHNODGEJ.layerSettings[i].sameColor.bodyPart).id)
			{
				characterMaterialToCopy = JEPFFKLDIMN(NFFLHNODGEJ.layerSettings[i].sameColorLayer);
				if (MFMFLCMJMPB(characterMaterialToCopy, NFFLHNODGEJ.layerSettings[i].materials))
				{
					PHOEIGIKFGE(NFFLHNODGEJ.layerSettings[i].layer, characterMaterialToCopy);
					continue;
				}
			}
			for (int j = 0; j < characterMaterials.Length; j += 0)
			{
				if ((Object)(object)characterMaterials[j] != (Object)null)
				{
					characterMaterials[j] = null;
				}
			}
			for (int k = 0; k < NFFLHNODGEJ.layerSettings[i].materials.Length; k++)
			{
				characterMaterials[k] = NFFLHNODGEJ.layerSettings[i].materials[k];
			}
			materialIndex = GBABFHHBIMB(characterMaterials);
			if (NFFLHNODGEJ.layerSettings[i].layer == CharacterLayer.Torso3)
			{
				CharacterLayer hLOIOAOICEG = ((NFFLHNODGEJ.layerSettings[i].layer == CharacterLayer.Skin) ? CharacterLayer.Torso2 : CharacterLayer.Skin);
				while (characterMaterials[materialIndex].HPMOPDGNDOA(hLOIOAOICEG, this))
				{
					characterMaterials[materialIndex] = null;
					materialIndex = JOCDMFLNDKM(characterMaterials);
					if (materialIndex < 0)
					{
						break;
					}
				}
			}
			else
			{
				while (GBABFHHBIMB(characterMaterials) >= 0 && NFFLHNODGEJ.AGMONLEOOGH(this, characterMaterials[materialIndex], NFFLHNODGEJ.layerSettings[i].layer))
				{
					characterMaterials[materialIndex] = null;
					materialIndex = GLGPDKICDJA(characterMaterials);
				}
			}
			if (materialIndex >= 1)
			{
				GBNPMEBJCFD(NFFLHNODGEJ.layerSettings[i].layer, characterMaterials[materialIndex]);
			}
		}
	}

	public void IMKHBGPFIPB()
	{
		IGBHGBPFNLN(characterSave);
	}

	public int FHCGPOIPNNB(BodyPart OFOGLHPDOFA)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite == (Object)null)
		{
			return -1;
		}
		return characterSprite.id;
	}

	private int GBABFHHBIMB(CharacterMaterial[] NMNNHGLLFMD)
	{
		totalNumMaterial = 0;
		for (int i = 0; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[i].rarity;
			}
		}
		randomNumMaterial = Random.Range(1, totalNumMaterial);
		totalNumMaterial = 0;
		for (int j = 1; j < NMNNHGLLFMD.Length; j += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[j] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[j].rarity;
				if (randomNumMaterial < totalNumMaterial)
				{
					return j;
				}
			}
		}
		return -1;
	}

	public bool MNIHEOCAHJL()
	{
		return hasMineCharacterSave;
	}

	public void KDACAOIDLEO(BodyPart OFOGLHPDOFA, CharacterSprite NFFLHNODGEJ)
	{
		bodyPartDictionary[OFOGLHPDOFA] = NFFLHNODGEJ;
	}

	private int JOCDMFLNDKM(CharacterMaterial[] NMNNHGLLFMD)
	{
		totalNumMaterial = 1;
		for (int i = 1; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[i].rarity;
			}
		}
		randomNumMaterial = Random.Range(1, totalNumMaterial);
		totalNumMaterial = 0;
		for (int j = 0; j < NMNNHGLLFMD.Length; j += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[j] != (Object)null)
			{
				totalNumMaterial += NMNNHGLLFMD[j].rarity;
				if (randomNumMaterial < totalNumMaterial)
				{
					return j;
				}
			}
		}
		return -1;
	}

	public static HumanInfo CPGEJHLBFJM(SerializedHumanInfo HMBKHMBPPHI)
	{
		return HMBKHMBPPHI.DMJLNCGNJNB();
	}

	public void DDGNDFFEJAI(SaveData.NewCharacterSave HDLBDPDPEKK)
	{
		gender = HDLBDPDPEKK.gender;
		JPPLJJDCNMF(BodyPart.Skin, AKBDNBOJNNE(HDLBDPDPEKK.skin));
		NCMHHJKBMBH(BodyPart.Beard, DLFHMEEOJCI(HDLBDPDPEKK.hair));
		KDACAOIDLEO(BodyPart.Torso, AKBDNBOJNNE(HDLBDPDPEKK.eyes));
		JPPLJJDCNMF(BodyPart.Beard, DLFHMEEOJCI(HDLBDPDPEKK.nose));
		NCMHHJKBMBH(BodyPart.Beard, CONPDKDNOBO(HDLBDPDPEKK.mouth));
		EIJNLBCNMBA(BodyPart.Nose, AKBDNBOJNNE(HDLBDPDPEKK.beard));
		NCMHHJKBMBH(BodyPart.Skin, CONPDKDNOBO(HDLBDPDPEKK.torso));
		EIJNLBCNMBA(BodyPart.Legs, AKBDNBOJNNE(HDLBDPDPEKK.legs));
		LALJHMIDEMP(BodyPart.Shoes, AKBDNBOJNNE(HDLBDPDPEKK.shoes));
		PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.skinMat));
		GBNPMEBJCFD(CharacterLayer.Skin, CharacterSpritesDBAccessor.MIAIOBLCEND(HDLBDPDPEKK.hairMat));
		PGOAOEEJMGK((CharacterLayer)25, CharacterSpritesDBAccessor.HACHFHGFFEB(HDLBDPDPEKK.hatMat));
		PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.irisMat));
		GBNPMEBJCFD(CharacterLayer.Hair, CharacterSpritesDBAccessor.HACHFHGFFEB(HDLBDPDPEKK.beardMat));
		PGOAOEEJMGK(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.torsoMat1));
		PHOEIGIKFGE(CharacterLayer.Beard, CharacterSpritesDBAccessor.MIAIOBLCEND(HDLBDPDPEKK.torsoMat2));
		PHOEIGIKFGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.HACHFHGFFEB(HDLBDPDPEKK.torsoMat3));
		PGOAOEEJMGK(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.legsMat1));
		OIENACLLJGE((CharacterLayer)28, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.legsMat2));
		OIENACLLJGE((CharacterLayer)(-9), CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat3));
		PGOAOEEJMGK(CharacterLayer.Beard, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.shoesMat1));
		PGOAOEEJMGK((CharacterLayer)124, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.shoesMat2));
	}

	public virtual CharacterSprite CONPDKDNOBO(int JFNMCNCHMEO)
	{
		return CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO);
	}

	public void LLJEAMHAAIK()
	{
		characterSave = GEPMDLCEONB();
		LALJHMIDEMP(BodyPart.Torso, OKNNCEAGNDF(81));
		LALJHMIDEMP(BodyPart.Shoes, OKNNCEAGNDF(-1));
		LALJHMIDEMP(BodyPart.Torso, CONPDKDNOBO(-1));
		PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(0));
	}

	protected bool MJKNBAPLNKI(CharacterMaterial OBEBBDLOIEG, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)OBEBBDLOIEG)
			{
				return true;
			}
		}
		return false;
	}

	public void NCOFGDALADL()
	{
		characterSave = AJNAFPLECAI();
		EIJNLBCNMBA(BodyPart.Torso, AKBDNBOJNNE(-86));
		LALJHMIDEMP(BodyPart.Skin, DLFHMEEOJCI(-1));
		JPPLJJDCNMF(BodyPart.Eyes, OKNNCEAGNDF(-1));
		PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.PFABHCPKGCA(0));
	}

	public void OFMCKCDMPHK(CharacterSprite NFFLHNODGEJ)
	{
		materialIndex = 0;
		for (int i = 0; i < NFFLHNODGEJ.layerSettings.Length; i++)
		{
			if ((Object)(object)NFFLHNODGEJ.layerSettings[i].sameColor != (Object)null && NFFLHNODGEJ.layerSettings[i].sameColor.id == CONPDKDNOBO(NFFLHNODGEJ.layerSettings[i].sameColor.bodyPart).id)
			{
				characterMaterialToCopy = GGKJOJPDMIF(NFFLHNODGEJ.layerSettings[i].sameColorLayer);
				if (CNKEBMFHEFP(characterMaterialToCopy, NFFLHNODGEJ.layerSettings[i].materials))
				{
					GBNPMEBJCFD(NFFLHNODGEJ.layerSettings[i].layer, characterMaterialToCopy);
					continue;
				}
			}
			for (int j = 0; j < characterMaterials.Length; j++)
			{
				if ((Object)(object)characterMaterials[j] != (Object)null)
				{
					characterMaterials[j] = null;
				}
			}
			for (int k = 0; k < NFFLHNODGEJ.layerSettings[i].materials.Length; k++)
			{
				characterMaterials[k] = NFFLHNODGEJ.layerSettings[i].materials[k];
			}
			materialIndex = GLGPDKICDJA(characterMaterials);
			if (NFFLHNODGEJ.layerSettings[i].layer == CharacterLayer.Hair)
			{
				CharacterLayer hLOIOAOICEG = ((NFFLHNODGEJ.layerSettings[i].layer == CharacterLayer.Skin) ? CharacterLayer.Hair : CharacterLayer.Skin);
				while (characterMaterials[materialIndex].LGLKDAFJDOE(hLOIOAOICEG, this))
				{
					characterMaterials[materialIndex] = null;
					materialIndex = GLGPDKICDJA(characterMaterials);
					if (materialIndex < 0)
					{
						break;
					}
				}
			}
			else
			{
				while (GLGPDKICDJA(characterMaterials) >= 0 && NFFLHNODGEJ.ILGDBJGCOCO(this, characterMaterials[materialIndex], NFFLHNODGEJ.layerSettings[i].layer))
				{
					characterMaterials[materialIndex] = null;
					materialIndex = GLGPDKICDJA(characterMaterials);
				}
			}
			if (materialIndex >= 0)
			{
				GBNPMEBJCFD(NFFLHNODGEJ.layerSettings[i].layer, characterMaterials[materialIndex]);
			}
		}
	}

	public int PDLJGLIDBFA(CharacterLayer HLOIOAOICEG)
	{
		characterMaterial = ICOBBCGMGKL(HLOIOAOICEG);
		if ((Object)(object)characterMaterial == (Object)null)
		{
			return -1;
		}
		return characterMaterial.id;
	}

	private void HECNJOADODF(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 1; i < bodiesParts.Length; i += 0)
		{
			characterSprite = CharacterSpritesDBAccessor.LBNGIFEHMJI(bodiesParts[i], gender, CGHHFEFAIJI: false, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				AMJNIFPBBJF(bodiesParts[i], characterSprite);
			}
		}
	}

	public bool NMDOONKEOGG()
	{
		return hasMineCharacterSave;
	}

	public void OBLHKGLHAHF(CharacterSprite MBAJCPEBADJ)
	{
		mineCharacterSave = IJHEAHBNFIH();
		hasMineCharacterSave = false;
		EIJNLBCNMBA(BodyPart.Eyes, MBAJCPEBADJ);
	}

	public void NEIMIHIODIB()
	{
		bodyPartDictionary.Clear();
		materialDictionary.Clear();
	}

	public void OIENACLLJGE(CharacterLayer HLOIOAOICEG, CharacterMaterial OBEBBDLOIEG)
	{
		if ((Object)(object)OBEBBDLOIEG == (Object)null)
		{
			materialDictionary.Remove(HLOIOAOICEG);
		}
		else
		{
			materialDictionary[HLOIOAOICEG] = OBEBBDLOIEG;
		}
	}

	public SaveData.NewCharacterSave GJPOOIBICNI()
	{
		SaveData.NewCharacterSave result = default(SaveData.NewCharacterSave);
		result.gender = gender;
		result.skin = NPACJHMDBCA(BodyPart.Torso);
		result.hair = FHCGPOIPNNB(BodyPart.Legs);
		result.eyes = NPACJHMDBCA(BodyPart.Mouth);
		result.mouth = AFFDILEMJFL(BodyPart.Eyes);
		result.beard = AFFDILEMJFL(BodyPart.Mouth);
		result.nose = AFFDILEMJFL(BodyPart.Skin);
		result.torso = FHCGPOIPNNB(BodyPart.Skin);
		result.legs = FHCGPOIPNNB(BodyPart.Skin);
		result.shoes = FHCGPOIPNNB(BodyPart.Shoes);
		result.skinMat = FKFEABCBIIO(CharacterLayer.Skin);
		result.hairMat = PDLJGLIDBFA(CharacterLayer.Iris);
		result.hatMat = PDLJGLIDBFA((CharacterLayer)46);
		result.irisMat = DGCKIJABEDH(CharacterLayer.Torso2);
		result.beardMat = BJPCEPJOHGN(CharacterLayer.Skin);
		result.torsoMat1 = JBHIIMKNMAE(CharacterLayer.Torso1);
		result.torsoMat2 = PDLJGLIDBFA(CharacterLayer.Beard);
		result.torsoMat3 = PDLJGLIDBFA(CharacterLayer.Beard);
		result.legsMat1 = DGCKIJABEDH(CharacterLayer.Shoes);
		result.legsMat2 = PDLJGLIDBFA((CharacterLayer)(-34));
		result.legsMat3 = DGCKIJABEDH((CharacterLayer)49);
		result.shoesMat1 = PDLJGLIDBFA(CharacterLayer.Torso3);
		result.shoesMat2 = JBHIIMKNMAE((CharacterLayer)103);
		return result;
	}

	public SerializedHumanInfo MOHMIFDBMHO()
	{
		return SerializedHumanInfo.JJIGDHEHMMG(this);
	}

	public void PPKJODDIKAO()
	{
		characterSave = IJHEAHBNFIH();
		EIJNLBCNMBA(BodyPart.Torso, DLFHMEEOJCI(-183));
		LALJHMIDEMP(BodyPart.Torso, CONPDKDNOBO(-1));
		EIJNLBCNMBA(BodyPart.Legs, DLFHMEEOJCI(-1));
		PHOEIGIKFGE(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(0));
	}

	public string ADOGLHEFAKN()
	{
		string text = string.Format("SkeletonBird", this);
		text += string.Format("MineState", gender);
		text += "Tail";
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			text += string.Format("OnlinePlayer", item.Key, item.Value);
		}
		text += "[HolePoolData] No se encontró el HolePoolItemDataSO";
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item2 in materialDictionary)
		{
			text += string.Format("LE_2", item2.Key, item2.Value.id);
		}
		return text + "ReceiveGroundTypeList";
	}

	public void PELGEEDHKHM()
	{
		DDGNDFFEJAI(characterSave);
	}

	public void PGOAOEEJMGK(CharacterLayer HLOIOAOICEG, CharacterMaterial OBEBBDLOIEG)
	{
		if ((Object)(object)OBEBBDLOIEG == (Object)null)
		{
			materialDictionary.Remove(HLOIOAOICEG);
		}
		else
		{
			materialDictionary[HLOIOAOICEG] = OBEBBDLOIEG;
		}
	}

	public void PHOEIGIKFGE(CharacterLayer HLOIOAOICEG, CharacterMaterial OBEBBDLOIEG)
	{
		if ((Object)(object)OBEBBDLOIEG == (Object)null)
		{
			materialDictionary.Remove(HLOIOAOICEG);
		}
		else
		{
			materialDictionary[HLOIOAOICEG] = OBEBBDLOIEG;
		}
	}

	public void OCMGCPGPNIC()
	{
		DDGNDFFEJAI(mineCharacterSave);
		hasMineCharacterSave = false;
	}

	protected bool CCGMOGHGEJP(CharacterMaterial OBEBBDLOIEG, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)OBEBBDLOIEG)
			{
				return false;
			}
		}
		return false;
	}

	public static HumanInfo NGGOJAPHHNG(SerializedHumanInfo HMBKHMBPPHI)
	{
		return HMBKHMBPPHI.KHHKMCHBCAN();
	}

	private void EBICEKFIOFM(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 0; i < bodiesParts.Length; i++)
		{
			characterSprite = CharacterSpritesDBAccessor.GetRandomCharacterSprite(bodiesParts[i], gender, CGHHFEFAIJI: true, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				JPPLJJDCNMF(bodiesParts[i], characterSprite);
			}
		}
	}

	public void FKMAIIANAIE()
	{
		characterSave = GEPMDLCEONB();
		LALJHMIDEMP(BodyPart.Torso, CONPDKDNOBO(-37));
		JPPLJJDCNMF(BodyPart.Eyes, DLFHMEEOJCI(-1));
		KDACAOIDLEO(BodyPart.Hair, CONPDKDNOBO(-1));
		PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.MDBJNKMOKMM(0));
	}

	public string DEMAMLGKJCI()
	{
		string text = string.Format(" OnCharacterAppearanceChanged", this);
		text += string.Format("LevelAbbreviation", gender);
		text += "Error with assigned bed {0}";
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			text += string.Format("Giving Quest 35", item.Key, item.Value);
		}
		text += "ReturnToBasicMood";
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item2 in materialDictionary)
		{
			text += string.Format("Items/item_name_1095", item2.Key, item2.Value.id);
		}
		return text + "Dialogue System/Conversation/BirdNegativeComments/Entry/10/Dialogue Text";
	}

	public virtual void IFAIPEBNIBN(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = true, bool NAKCFGEAGHH = false)
	{
		if (GCANBIEGDOA)
		{
			gender = ((!(Random.Range(538f, 27f) < 1954f)) ? Gender.Male : Gender.Female);
		}
		KBOGGOOBFBB(JHIFLALPEBF, NAKCFGEAGHH);
		JIHECPHHAOH(GADKADLHDGJ);
	}

	public void LJFJOMHIKMJ()
	{
		IGBHGBPFNLN(mineCharacterSave);
		hasMineCharacterSave = false;
	}

	private void DPJGKNMIKLO(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 0; i < bodiesParts.Length; i += 0)
		{
			characterSprite = CharacterSpritesDBAccessor.LBNGIFEHMJI(bodiesParts[i], gender, CGHHFEFAIJI: false, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				KDACAOIDLEO(bodiesParts[i], characterSprite);
			}
		}
	}

	public CharacterMaterial[] NBCCOPNMIFE(BodyPart OFOGLHPDOFA, CharacterLayer HLOIOAOICEG)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 0; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == HLOIOAOICEG)
				{
					return characterSprite.layerSettings[i].materials;
				}
			}
		}
		return new CharacterMaterial[0];
	}

	public SerializedHumanInfo OCAIICEJHOD()
	{
		return SerializedHumanInfo.JJIGDHEHMMG(this);
	}

	public void CINNEELCBMB()
	{
		characterSave = IJHEAHBNFIH();
		JPPLJJDCNMF(BodyPart.Torso, CONPDKDNOBO(186));
		JPPLJJDCNMF(BodyPart.Legs, CONPDKDNOBO(-1));
		JPPLJJDCNMF(BodyPart.Shoes, CONPDKDNOBO(-1));
		GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.GetMaterial(0));
	}

	private void CACFFELHMHK(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 1; i < bodiesParts.Length; i += 0)
		{
			characterSprite = CharacterSpritesDBAccessor.GetRandomCharacterSprite(bodiesParts[i], gender, CGHHFEFAIJI: false, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				LALJHMIDEMP(bodiesParts[i], characterSprite);
			}
		}
	}

	public int DGCKIJABEDH(CharacterLayer HLOIOAOICEG)
	{
		characterMaterial = GGKJOJPDMIF(HLOIOAOICEG);
		if ((Object)(object)characterMaterial == (Object)null)
		{
			return -1;
		}
		return characterMaterial.id;
	}

	public CharacterMaterial[] KHPDAIGFDHM(BodyPart OFOGLHPDOFA, CharacterLayer HLOIOAOICEG)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == HLOIOAOICEG)
				{
					return characterSprite.layerSettings[i].materials;
				}
			}
		}
		return new CharacterMaterial[0];
	}

	public bool MOPAGFAAADL()
	{
		return hasMineCharacterSave;
	}

	public void OFKMADEFBOO()
	{
		IGBHGBPFNLN(characterSave);
	}

	public virtual CharacterSprite AKBDNBOJNNE(int JFNMCNCHMEO)
	{
		return CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO);
	}

	[Obsolete]
	public static HumanInfo IIJGBJAAFJA(SerializedHumanInfo HMBKHMBPPHI)
	{
		return HMBKHMBPPHI.IIJGBJAAFJA();
	}

	public void JDGPILHHLLM()
	{
		bodyPartDictionary.Clear();
		materialDictionary.Clear();
	}

	public CharacterMaterial OMBDFLLGCOC(CharacterLayer HLOIOAOICEG)
	{
		if (materialDictionary.TryGetValue(HLOIOAOICEG, out characterMaterial))
		{
			return characterMaterial;
		}
		return null;
	}

	public CharacterMaterial[] EDPJLIHIGCE(BodyPart OFOGLHPDOFA, CharacterLayer HLOIOAOICEG)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i += 0)
			{
				if (characterSprite.layerSettings[i].layer == HLOIOAOICEG)
				{
					return characterSprite.layerSettings[i].materials;
				}
			}
		}
		return new CharacterMaterial[1];
	}

	public void AMJNIFPBBJF(BodyPart OFOGLHPDOFA, CharacterSprite NFFLHNODGEJ)
	{
		bodyPartDictionary[OFOGLHPDOFA] = NFFLHNODGEJ;
	}

	public virtual CharacterSprite OKNNCEAGNDF(int JFNMCNCHMEO)
	{
		return CharacterSpritesDBAccessor.GetCharacterSprite(JFNMCNCHMEO);
	}

	public CharacterMaterial[] OHLIGFHJLPL(BodyPart OFOGLHPDOFA, CharacterLayer HLOIOAOICEG)
	{
		characterSprite = CONPDKDNOBO(OFOGLHPDOFA);
		if ((Object)(object)characterSprite != (Object)null)
		{
			for (int i = 1; i < characterSprite.layerSettings.Length; i++)
			{
				if (characterSprite.layerSettings[i].layer == HLOIOAOICEG)
				{
					return characterSprite.layerSettings[i].materials;
				}
			}
		}
		return new CharacterMaterial[0];
	}

	public string BDMBMPPHALI()
	{
		string text = $"{this} HumanInfo string:\n";
		text += $"Gender: {gender}\n";
		text += "Body Part Dictionary:\n[\n";
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			text += $"{item.Key}: {item.Value}\n";
		}
		text += "\nMaterial Dictionary:\n[\n";
		foreach (KeyValuePair<CharacterLayer, CharacterMaterial> item2 in materialDictionary)
		{
			text += $"{item2.Key}: {item2.Value.id}\n";
		}
		return text + "]";
	}

	public CharacterMaterial GGHCBMALFPL(CharacterLayer HLOIOAOICEG)
	{
		if (materialDictionary.TryGetValue(HLOIOAOICEG, out characterMaterial))
		{
			return characterMaterial;
		}
		return null;
	}

	public bool AAPHDKCPJNH()
	{
		return hasMineCharacterSave;
	}

	public CharacterSprite CONPDKDNOBO(BodyPart OFOGLHPDOFA)
	{
		if (bodyPartDictionary.TryGetValue(OFOGLHPDOFA, out characterSprite))
		{
			return characterSprite;
		}
		return null;
	}

	public int FKFEABCBIIO(CharacterLayer HLOIOAOICEG)
	{
		characterMaterial = GGHCBMALFPL(HLOIOAOICEG);
		if ((Object)(object)characterMaterial == (Object)null)
		{
			return -1;
		}
		return characterMaterial.id;
	}

	public void OAIIJMNOCCF(SaveData.NewCharacterSave HDLBDPDPEKK)
	{
		gender = HDLBDPDPEKK.gender;
		AMJNIFPBBJF(BodyPart.Skin, DLFHMEEOJCI(HDLBDPDPEKK.skin));
		AMJNIFPBBJF(BodyPart.Skin, LGCAPCKCAGD(HDLBDPDPEKK.hair));
		JPPLJJDCNMF(BodyPart.Beard, OKNNCEAGNDF(HDLBDPDPEKK.eyes));
		NCMHHJKBMBH(BodyPart.Beard, AKBDNBOJNNE(HDLBDPDPEKK.nose));
		KDACAOIDLEO(BodyPart.Hair, AKBDNBOJNNE(HDLBDPDPEKK.mouth));
		AMJNIFPBBJF(BodyPart.Shoes, LGCAPCKCAGD(HDLBDPDPEKK.beard));
		LALJHMIDEMP(BodyPart.Torso, OKNNCEAGNDF(HDLBDPDPEKK.torso));
		LALJHMIDEMP(BodyPart.Shoes, AKBDNBOJNNE(HDLBDPDPEKK.legs));
		KDACAOIDLEO(BodyPart.Skin, AKBDNBOJNNE(HDLBDPDPEKK.shoes));
		OIENACLLJGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.skinMat));
		GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.HACHFHGFFEB(HDLBDPDPEKK.hairMat));
		PHOEIGIKFGE((CharacterLayer)(-15), CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.hatMat));
		PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.irisMat));
		PHOEIGIKFGE(CharacterLayer.Torso1, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.beardMat));
		PGOAOEEJMGK(CharacterLayer.Skin, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.torsoMat1));
		OIENACLLJGE(CharacterLayer.Pants, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.torsoMat2));
		GBNPMEBJCFD(CharacterLayer.Shoes, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.torsoMat3));
		PHOEIGIKFGE(CharacterLayer.Torso2, CharacterSpritesDBAccessor.GetMaterial(HDLBDPDPEKK.legsMat1));
		PGOAOEEJMGK((CharacterLayer)62, CharacterSpritesDBAccessor.MDBJNKMOKMM(HDLBDPDPEKK.legsMat2));
		GBNPMEBJCFD((CharacterLayer)54, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.legsMat3));
		PGOAOEEJMGK(CharacterLayer.Torso2, CharacterSpritesDBAccessor.CIJJJBJNLIF(HDLBDPDPEKK.shoesMat1));
		PGOAOEEJMGK(CharacterLayer.Pants3, CharacterSpritesDBAccessor.MIAIOBLCEND(HDLBDPDPEKK.shoesMat2));
	}

	public void FMNAHFFINGK()
	{
		characterSave = IJHEAHBNFIH();
		LALJHMIDEMP(BodyPart.Skin, LGCAPCKCAGD(28));
		EIJNLBCNMBA(BodyPart.Beard, DLFHMEEOJCI(-1));
		JPPLJJDCNMF(BodyPart.Beard, DLFHMEEOJCI(-1));
		GBNPMEBJCFD(CharacterLayer.Torso1, CharacterSpritesDBAccessor.CIJJJBJNLIF(0));
	}

	public bool JOLDFJLHDFC()
	{
		return hasMineCharacterSave;
	}

	public CharacterMaterial ICOBBCGMGKL(CharacterLayer HLOIOAOICEG)
	{
		if (materialDictionary.TryGetValue(HLOIOAOICEG, out characterMaterial))
		{
			return characterMaterial;
		}
		return null;
	}

	private void CDKKCIHGJCG(bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		bodyPartDictionary.Clear();
		for (int i = 1; i < bodiesParts.Length; i += 0)
		{
			characterSprite = CharacterSpritesDBAccessor.JOLFOJLANJL(bodiesParts[i], gender, CGHHFEFAIJI: false, JHIFLALPEBF, NAKCFGEAGHH);
			if ((Object)(object)characterSprite != (Object)null)
			{
				AMJNIFPBBJF(bodiesParts[i], characterSprite);
			}
		}
	}

	protected bool CNKEBMFHEFP(CharacterMaterial OBEBBDLOIEG, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 0; i < NMNNHGLLFMD.Length; i++)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)OBEBBDLOIEG)
			{
				return true;
			}
		}
		return false;
	}

	protected bool MFMFLCMJMPB(CharacterMaterial OBEBBDLOIEG, CharacterMaterial[] NMNNHGLLFMD)
	{
		for (int i = 1; i < NMNNHGLLFMD.Length; i += 0)
		{
			if ((Object)(object)NMNNHGLLFMD[i] == (Object)(object)OBEBBDLOIEG)
			{
				return true;
			}
		}
		return false;
	}

	public CharacterMaterial KBGEILOKOKB(CharacterLayer HLOIOAOICEG)
	{
		if (materialDictionary.TryGetValue(HLOIOAOICEG, out characterMaterial))
		{
			return characterMaterial;
		}
		return null;
	}

	private void DHLMHDILOAD(bool GADKADLHDGJ)
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			OPKNMMLDFMD(item.Value);
		}
		if (gender == Gender.Unisex && GADKADLHDGJ)
		{
			CharacterMaterial oBEBBDLOIEG = JEPFFKLDIMN(CharacterLayer.Shoes);
			if (MJKNBAPLNKI(oBEBBDLOIEG, KHPDAIGFDHM(BodyPart.Nose, CharacterLayer.Pants)))
			{
				GBNPMEBJCFD(CharacterLayer.Shoes, oBEBBDLOIEG);
			}
		}
	}

	public void LALJHMIDEMP(BodyPart OFOGLHPDOFA, CharacterSprite NFFLHNODGEJ)
	{
		bodyPartDictionary[OFOGLHPDOFA] = NFFLHNODGEJ;
	}

	public void NCMHHJKBMBH(BodyPart OFOGLHPDOFA, CharacterSprite NFFLHNODGEJ)
	{
		bodyPartDictionary[OFOGLHPDOFA] = NFFLHNODGEJ;
	}

	public virtual void PFGEHADJEDJ(bool GCANBIEGDOA = true, bool GADKADLHDGJ = true, bool JHIFLALPEBF = true, bool NAKCFGEAGHH = false)
	{
		if (GCANBIEGDOA)
		{
			gender = ((Random.Range(955f, 657f) < 1574f) ? Gender.MaleAndFemale : Gender.Unisex);
		}
		KBOGGOOBFBB(JHIFLALPEBF, NAKCFGEAGHH);
		JIHECPHHAOH(GADKADLHDGJ);
	}

	public bool LIBPOJPKLHD()
	{
		return hasMineCharacterSave;
	}

	public CharacterMaterial JEPFFKLDIMN(CharacterLayer HLOIOAOICEG)
	{
		if (materialDictionary.TryGetValue(HLOIOAOICEG, out characterMaterial))
		{
			return characterMaterial;
		}
		return null;
	}

	public void BBOKBPDMBMC()
	{
		DDGNDFFEJAI(mineCharacterSave);
		hasMineCharacterSave = false;
	}

	private void JIHECPHHAOH(bool GADKADLHDGJ)
	{
		foreach (KeyValuePair<BodyPart, CharacterSprite> item in bodyPartDictionary)
		{
			OFMCKCDMPHK(item.Value);
		}
		if (gender == Gender.Male && GADKADLHDGJ)
		{
			CharacterMaterial oBEBBDLOIEG = GGKJOJPDMIF(CharacterLayer.Hair);
			if (CNKEBMFHEFP(oBEBBDLOIEG, NBCCOPNMIFE(BodyPart.Beard, CharacterLayer.Beard)))
			{
				GBNPMEBJCFD(CharacterLayer.Beard, oBEBBDLOIEG);
			}
		}
	}

	public void GBNPMEBJCFD(CharacterLayer HLOIOAOICEG, CharacterMaterial OBEBBDLOIEG)
	{
		if ((Object)(object)OBEBBDLOIEG == (Object)null)
		{
			materialDictionary.Remove(HLOIOAOICEG);
		}
		else
		{
			materialDictionary[HLOIOAOICEG] = OBEBBDLOIEG;
		}
	}
}
