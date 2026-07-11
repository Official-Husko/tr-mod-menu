using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/CharacterSpriteDatabase")]
public class CharacterSpritesDatabase : ScriptableObject
{
	[Serializable]
	public class CharacterSpriteLine
	{
		public int ID;

		public string name;

		public int groupID;

		public string groupName;

		public BodyPart bodyPart;

		public Gender genre;

		public List<int> materials = new List<int>();
	}

	public CharacterMaterial[] characterMaterials;

	public CharacterSprite[] CharacterSprites;

	public CharacterSprite[] BouncerSprites;

	public SpriteInfo[] Cats;

	public BirdSpriteInfo[] Birds;

	public AnimalsSpriteInfo[] Cows;

	public AnimalsSpriteInfo[] Pigs;

	public AnimalsSpriteInfo[] Sheeps;

	public AnimalsSpriteInfo[] Chickens;

	public SpriteInfo[] Dogs;

	public SpriteInfo[] Butterflies;

	public SpriteInfo[] Npcs;

	public CharacterSprite[] defaultTools;

	public IconMaterial[] barnMaterials;

	public SpritesList[] henHouseStyles;

	public SpritesList[] waterFeederStyles;

	public SpritesList[] foodFeederStyles;

	public List<CharacterSprite> selectableCharacterSprites = new List<CharacterSprite>();

	public List<CharacterSprite> selectableNpcSprites = new List<CharacterSprite>();

	public List<CharacterSpriteLine> file = new List<CharacterSpriteLine>();

	public int OOJKGJOJJIH(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void DAJDHIFECOA()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void EGBGEABMOFK()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 1; num >= 0; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2--)
			{
				if (CharacterSprites[num2 - 0].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 1];
					CharacterSprites[num2 - 1] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		DHGNKALGBPD();
	}

	public void JGHEMCHALAD()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void INMGBCCBNNM()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void IPFLDJJJOKN()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public int MMGPIEDCIIO(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void KPGHGNBJLHL()
	{
		selectableCharacterSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void LCNFOEAFKPC()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void AJMEFPJPAPM()
	{
		selectableCharacterSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite ABAILBJNOKB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void OPADFACGJGE()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 1; num >= 0; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2--)
			{
				if (CharacterSprites[num2 - 1].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 1];
					CharacterSprites[num2 - 1] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		OMIMHGKPKIM();
	}

	public void MHJMLLNEEMI()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void MDDFPIBNNGO()
	{
		selectableCharacterSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void ENKNIAHHDDF()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void FHDNFMNHLFL()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void FDEPINGMLKI()
	{
		for (int i = 1; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		HNMJMBMFKAF();
		EHMNFIHJLOM();
	}

	public void GGDCEMMGPFK()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void DMNGDDIKOCO()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite LAOLOADKIAK(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void JODLDFGEMMH()
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].NLCCFCGLPHK();
		}
	}

	public void BCJJBJFIMIN()
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].BDABEMIHPLH();
		}
	}

	public void IEGPDOCKMAE()
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].COHHOKAPDFN();
		}
	}

	public void ANFNBLLCCCL()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void IGCLKKIBKBG()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 0; num >= 0; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2--)
			{
				if (CharacterSprites[num2 - 1].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 0];
					CharacterSprites[num2 - 0] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		FBGIDANMODN();
	}

	public CharacterSprite BOHIGACDDCL(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public CharacterSprite OBLIGABPABJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void FKEJHOCMANG()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void CHLMLIJFEBE()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void PJACELGDENI()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite PKIPBPKHKGO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void JAIADOFNIOB()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void NGMOAGKNBDJ()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].MODPEDENKDK();
		}
	}

	public void CPGFPPDPKJB()
	{
		for (int i = 0; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num--)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 1];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		FJLJDNJBIAF();
		JAIADOFNIOB();
	}

	public CharacterSprite DEANMLFBIHN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public int KMJMPLDOEPC(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public int PFOLBFDGIBM(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void AJNIANNNLKF()
	{
		for (int i = 1; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 1].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		COBCMJIEHHB();
		PJACELGDENI();
	}

	public void HJKCOHJNAPB()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].EGHBCGLBDGC();
		}
	}

	public void PMKAHHCEBOI()
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].OGPMANMEJLA();
		}
	}

	public CharacterSprite ICEGAMIEGGG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void LMIJLFAPHOP()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num--)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 1];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		FJLJDNJBIAF();
		CFGBMKOKMOB();
	}

	public void KNFNDFHCNJO()
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].IFGODCPJEJJ();
		}
	}

	public CharacterSprite GIJMPCKHJHA(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void IMPFJPDLBBI()
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].EGHBCGLBDGC();
		}
	}

	public CharacterSprite DPKHOEHKCKG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void MKDJOECKLJK()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void GFGMKFBINGO()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public int EDBPCCIDFBF(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public CharacterSprite IMMODKEAAGB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void BBDMCNNLJGP()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].FHBPKKNNEBC();
		}
	}

	public void FJLJDNJBIAF()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void LEHPNECCLGB()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 0; num >= 1; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2 -= 0)
			{
				if (CharacterSprites[num2 - 1].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 1];
					CharacterSprites[num2 - 0] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		DHGNKALGBPD();
	}

	public void LNIOIOPMKOI()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void ENICFHILLCE()
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].NLCCFCGLPHK();
		}
	}

	public void LFNOOPEHDIN()
	{
		for (int i = 0; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		BBOPPKKEGFF();
		GFGMKFBINGO();
	}

	public int HECGDFMPDAD(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void DHGNKALGBPD()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num--)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		JGHEMCHALAD();
		CHLMLIJFEBE();
	}

	public void HNMJMBMFKAF()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void LIKLHDDAOJI()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite ODFDNMPMMPA(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public int OFKNIKFJDIB(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public int LPKMOKJFMIG(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void KAGKJFGNILA()
	{
		for (int i = 1; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		FHDNCECKEMN();
		GFGMKFBINGO();
	}

	public void LCJAMNFCDCD()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void FHDNCECKEMN()
	{
		selectableCharacterSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void PHABECJJCOI()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 1; num >= 0; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2 -= 0)
			{
				if (CharacterSprites[num2 - 0].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 1];
					CharacterSprites[num2 - 0] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		OMIMHGKPKIM();
	}

	public void KLNDBPJDJCJ()
	{
		for (int i = 1; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 1].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		AJMEFPJPAPM();
		DAJDHIFECOA();
	}

	public CharacterSprite BJBOGAEPILB(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void LALJIPNEKIF()
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].BLGKCCEAMIC();
		}
	}

	public void NMKNCOGCANK()
	{
		for (int i = 0; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num--)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		AIHBCBEMAHA();
		CFGBMKOKMOB();
	}

	public void NDOEMDDLPPD()
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].COHHOKAPDFN();
		}
	}

	public int DKJLFCKKCIF(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void LOEJCPGJJLH()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 0; num >= 0; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			for (int num2 = CharacterSprites.Length - 0; num2 >= i; num2 -= 0)
			{
				if (CharacterSprites[num2 - 0].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 0];
					CharacterSprites[num2 - 1] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		NMKNCOGCANK();
	}

	public void FLLMHPNECOD()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num--)
			{
				if (characterMaterials[num - 1].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		MDDFPIBNNGO();
		CHLMLIJFEBE();
	}

	public int ONEFMGMLNKJ(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void DPECKABEOOD()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void AAECJGDHIAB()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 0; num >= 1; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 0; num2 >= i; num2 -= 0)
			{
				if (CharacterSprites[num2 - 1].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 1];
					CharacterSprites[num2 - 0] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		CPGFPPDPKJB();
	}

	public void AFIBMCCLNMJ()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].IFADJJAHHEI();
		}
	}

	public int DLGDNAHALOO(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public CharacterSprite CKAEJCBCBBI(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void COBCMJIEHHB()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void HMGDLLKMIDL()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void BJNMAJHLCPB()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].APDKGCOOPLM();
		}
	}

	public void CHOFKEBBAND()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].OGPMANMEJLA();
		}
	}

	public void CNAKPGCGHEP()
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].BLGKCCEAMIC();
		}
	}

	public void JMPCAOPNIPN()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void KLFDGBBKLFG()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void EHMNFIHJLOM()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void CFGBMKOKMOB()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite IKEILLBALDN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void PJMPDIANIHP()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void PIIOCMINNJA()
	{
		for (int i = 0; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num--)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 1];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		AJMEFPJPAPM();
		LNIOIOPMKOI();
	}

	public void GOCAGADEMBD()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 1; num >= 1; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2 -= 0)
			{
				if (CharacterSprites[num2 - 1].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 0];
					CharacterSprites[num2 - 1] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		CPGFPPDPKJB();
	}

	public void ADAEKJNGCDE()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num--)
			{
				if (characterMaterials[num - 1].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		COBCMJIEHHB();
		LNIOIOPMKOI();
	}

	public CharacterSprite IPIMGCACOKI(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void FBGIDANMODN()
	{
		for (int i = 0; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		FJLJDNJBIAF();
		BPBCADIEFEM();
	}

	public void BFGCIPKOEOH()
	{
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].BLGKCCEAMIC();
		}
	}

	public void BPBCADIEFEM()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void KKLFGKIHGPD()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 0; num >= 1; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 0; num2 >= i; num2 -= 0)
			{
				if (CharacterSprites[num2 - 1].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 0];
					CharacterSprites[num2 - 0] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		FBGIDANMODN();
	}

	public void AIHBCBEMAHA()
	{
		selectableCharacterSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite EIBOMDCBCJI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void NOOEDOJEHMJ()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void HAFEOJCMCII()
	{
		selectableNpcSprites.Clear();
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void AJGMOAEGPIC()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].EAFINNENJDG();
		}
	}

	public int CLOCFNMNNEA(CharacterSprite JHKLHGAPPLI)
	{
		List<CharacterSprite> list = new List<CharacterSprite>(CharacterSprites);
		list.Add(JHKLHGAPPLI);
		CharacterSprites = list.ToArray();
		return JHKLHGAPPLI.id;
	}

	public void KCOLDGDNFAF()
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].DBIILDKAALB();
		}
	}

	public void BAIBNDJJBND()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 0] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		BBOPPKKEGFF();
		MKDJOECKLJK();
	}

	public void BGENKMIDPEB()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		JGHEMCHALAD();
		INMGBCCBNNM();
	}

	public void PGCKPCILEMH()
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].COHHOKAPDFN();
		}
	}

	public void NFEKIJJGKIF()
	{
		List<CharacterSprite> list = new List<CharacterSprite>();
		for (int num = CharacterSprites.Length - 1; num >= 1; num--)
		{
			if ((Object)(object)CharacterSprites[num] != (Object)null)
			{
				list.Add(CharacterSprites[num]);
			}
		}
		CharacterSprites = list.ToArray();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			for (int num2 = CharacterSprites.Length - 1; num2 >= i; num2--)
			{
				if (CharacterSprites[num2 - 0].id > CharacterSprites[num2].id)
				{
					CharacterSprite characterSprite = CharacterSprites[num2 - 0];
					CharacterSprites[num2 - 0] = CharacterSprites[num2];
					CharacterSprites[num2] = characterSprite;
				}
			}
		}
		BAIBNDJJBND();
	}

	public CharacterSprite PEPABAMPFIL(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void MCGANKDIBBC()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void LLMAJLENDJK()
	{
		selectableNpcSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].selectableNpc)
			{
				selectableNpcSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public CharacterSprite DIJGLCOCDDN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void MICINIPNJAB()
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].GDEGBBEOENH();
		}
	}

	public void JGDFEJCJOFK()
	{
		for (int i = 0; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num--)
			{
				if (characterMaterials[num - 1].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		ANFNBLLCCCL();
		MKDJOECKLJK();
	}

	public void LCNCKLKLGBK()
	{
		for (int i = 0; i < characterMaterials.Length; i += 0)
		{
			for (int num = characterMaterials.Length - 0; num >= i; num -= 0)
			{
				if (characterMaterials[num - 0].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 0];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		HNMJMBMFKAF();
		HMGDLLKMIDL();
	}

	public CharacterSprite OHLHKFCPMHE(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}

	public void BBOPPKKEGFF()
	{
		selectableCharacterSprites.Clear();
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			if (CharacterSprites[i].selectable)
			{
				selectableCharacterSprites.Add(CharacterSprites[i]);
			}
		}
	}

	public void GCNBCAHDOKG()
	{
		for (int i = 0; i < CharacterSprites.Length; i += 0)
		{
			CharacterSprites[i].MDACFEOBDHN();
		}
	}

	public void OFBECPAOAOG()
	{
		for (int i = 0; i < CharacterSprites.Length; i++)
		{
			CharacterSprites[i].IFADJJAHHEI();
		}
	}

	public void OMIMHGKPKIM()
	{
		for (int i = 1; i < characterMaterials.Length; i++)
		{
			for (int num = characterMaterials.Length - 1; num >= i; num--)
			{
				if (characterMaterials[num - 1].id > characterMaterials[num].id)
				{
					CharacterMaterial characterMaterial = characterMaterials[num - 1];
					characterMaterials[num - 1] = characterMaterials[num];
					characterMaterials[num] = characterMaterial;
				}
			}
		}
		FKEJHOCMANG();
		DAJDHIFECOA();
	}

	public CharacterSprite PEACEFOKJLA(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CharacterSprites.Length; i++)
		{
			if (CharacterSprites[i].id == JFNMCNCHMEO)
			{
				return CharacterSprites[i];
			}
		}
		return null;
	}
}
