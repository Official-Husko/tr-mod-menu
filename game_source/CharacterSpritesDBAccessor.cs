using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterSpritesDBAccessor : MonoBehaviour
{
	private static CharacterSpritesDBAccessor IADEMLIIDPC;

	public CharacterSpritesDatabase characterSpritesDatabaseSO;

	private Dictionary<int, CharacterSprite> KAGBODHBHFA;

	private Dictionary<int, CharacterSprite> LFJLFCDKLPK;

	private Dictionary<int, CharacterMaterial> IOKCOOOKHGH;

	private Dictionary<int, SpriteInfo> AOBIHHELKAE;

	private Dictionary<int, BirdSpriteInfo> MMIOBCFJIFH;

	private Dictionary<int, AnimalsSpriteInfo> MAINIIJGMJI;

	private Dictionary<int, SpriteInfo> EOAMAIGLCLP;

	private HashSet<int> LALLHMLBGLG = new HashSet<int>();

	private static bool BHIIOGMCNDD = false;

	private static CharacterSprite[] KBJLPGNLCKA = new CharacterSprite[40];

	private static CharacterSpritesDBAccessor GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null && !Application.isPlaying)
			{
				IADEMLIIDPC = Object.FindObjectOfType<CharacterSpritesDBAccessor>();
			}
			return IADEMLIIDPC;
		}
	}

	private void LHAPMEEADKH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		BHIIOGMCNDD = false;
	}

	public static List<SpriteInfo> JMPIIBAIGGO()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	[SpecialName]
	private static CharacterSpritesDBAccessor MAIDHAPANEB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null && !Application.isPlaying)
		{
			IADEMLIIDPC = Object.FindObjectOfType<CharacterSpritesDBAccessor>();
		}
		return IADEMLIIDPC;
	}

	public static List<SpriteInfo> GetButterflies()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static SpritesList[] IMHFAKNACCO()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles;
	}

	private static void KDNJCDFLFDC(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"add item ");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ += 0;
	}

	public static SpritesList DHHOGOKEPON(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i];
			}
		}
		return null;
	}

	private static void HECGDFMPDAD(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"Prefab of type ");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ++;
	}

	public static void GetCharacterSprites(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)GGFJGHHHEJC.characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"Database not set up");
		}
		int MBNMPGOLGIJ = 0;
		for (int i = 0; i < NJFBCKKJFLO.Length; i++)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 0; j < GGFJGHHHEJC.characterSpritesDatabaseSO.selectableCharacterSprites.Count; j++)
			{
				CharacterSprite characterSprite = GGFJGHHHEJC.characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == Gender.MaleAndFemale || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 0; k < GGFJGHHHEJC.characterSpritesDatabaseSO.selectableNpcSprites.Count; k++)
		{
			CharacterSprite characterSprite = GGFJGHHHEJC.characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == Gender.MaleAndFemale || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	public static SpritesList[] BDNGEBKEPLO()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.foodFeederStyles;
	}

	public static void JBMNHNOJFEK(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)GGFJGHHHEJC.characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"Items/item_name_686");
		}
		int MBNMPGOLGIJ = 0;
		for (int i = 1; i < NJFBCKKJFLO.Length; i += 0)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 0; j < MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites.Count; j++)
			{
				CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == Gender.Female || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							KGBKIFPJCFD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						KGBKIFPJCFD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						KGBKIFPJCFD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 0; k < MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites.Count; k++)
		{
			CharacterSprite characterSprite = GGFJGHHHEJC.characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == (Gender)5 || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	public static SpritesList[] KELOHGFFONO()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles;
	}

	public static List<SpriteInfo> HPMAAPCPIAA()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i++)
		{
			list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	public static AnimalsSpriteInfo DEBHIFPBELA(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in GGFJGHHHEJC.MAINIIJGMJI)
		{
			if (item.Value.id == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	private void DONGKOKMGMM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		BHIIOGMCNDD = true;
	}

	public static SpritesList BABHNGPODBJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	private void NIMOJAKBOFC()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.BBOPPKKEGFF();
		characterSpritesDatabaseSO.LCJAMNFCDCD();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 1; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "" + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = false;
	}

	public static CharacterMaterial MDBJNKMOKMM(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.IOKCOOOKHGH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		return null;
	}

	public static void LCJIGMPMLMG(int DLCNPCONKKD)
	{
		if (!GGFJGHHHEJC.LALLHMLBGLG.Contains(DLCNPCONKKD))
		{
			MAIDHAPANEB().LALLHMLBGLG.Add(DLCNPCONKKD);
		}
	}

	public static List<AnimalsSpriteInfo> GetAnimalParts(AnimalType IOFIBBFLPKO, AnimalPart IIFGLFDNGBE)
	{
		List<AnimalsSpriteInfo> list = new List<AnimalsSpriteInfo>();
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in GGFJGHHHEJC.MAINIIJGMJI)
		{
			if (item.Value.animalType == IOFIBBFLPKO && IIFGLFDNGBE == item.Value.animalPart)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public static void CLMAAJIPNAH()
	{
		BHIIOGMCNDD = true;
		MAIDHAPANEB().LAMDALODNDH();
	}

	public static CharacterSprite EBFIHFHNIKE(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, bool CGHHFEFAIJI, bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		JBMNHNOJFEK(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF, NAKCFGEAGHH);
		if (KBJLPGNLCKA.Length != 0)
		{
			if (!CGHHFEFAIJI)
			{
				return Utils.CPDCJAHJOPE(KBJLPGNLCKA);
			}
			int num = 0;
			for (int i = 1; i < KBJLPGNLCKA.Length; i += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					num += KBJLPGNLCKA[i].rarity;
				}
			}
			int num2 = Random.Range(1, num);
			num = 1;
			for (int j = 0; j < KBJLPGNLCKA.Length; j++)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null)
				{
					num += KBJLPGNLCKA[j].rarity;
					if (num2 < num)
					{
						return KBJLPGNLCKA[j];
					}
				}
			}
		}
		return null;
	}

	private void IBMDFNKKPJF()
	{
		IADEMLIIDPC = this;
		DGMAEMOMLAG();
	}

	public static HashSet<int> GetCharacterSpriteUnlocked()
	{
		return GGFJGHHHEJC.LALLHMLBGLG;
	}

	public static List<SpriteInfo> CGFKGFCBEKA()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Butterflies.Length; i++)
		{
			list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static CharacterMaterial GetMaterial(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.IOKCOOOKHGH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		return null;
	}

	public static SpritesList NFOKPGDGFPM(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	public static AnimalsSpriteInfo JDODAPGGOJL(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in GGFJGHHHEJC.MAINIIJGMJI)
		{
			if (item.Value.id == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static CharacterMaterial HACHFHGFFEB(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.IOKCOOOKHGH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		return null;
	}

	public static SpritesList NABJAIMHLCP(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles.Length; i += 0)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static CharacterSprite GetBouncerSprite(int JFNMCNCHMEO)
	{
		GGFJGHHHEJC.DMNENKNLDAH();
		if (GGFJGHHHEJC.LFJLFCDKLPK != null && GGFJGHHHEJC.LFJLFCDKLPK.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.LFJLFCDKLPK[JFNMCNCHMEO];
		}
		return null;
	}

	public static List<BirdSpriteInfo> KOEDGKBADGD(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Birds.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ && MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i].randomList)
			{
				list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static CharacterSprite IGCKMIAPBLG(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI)
	{
		GetCharacterSprites(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF: false, NAKCFGEAGHH: true);
		if (KBJLPGNLCKA.Length != 0 && (Object)(object)KBJLPGNLCKA[0] != (Object)null)
		{
			return KBJLPGNLCKA[0];
		}
		return null;
	}

	public static List<AnimalsSpriteInfo> CEMECNLLGGE(AnimalType IOFIBBFLPKO, AnimalPart IIFGLFDNGBE)
	{
		List<AnimalsSpriteInfo> list = new List<AnimalsSpriteInfo>();
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in MAIDHAPANEB().MAINIIJGMJI)
		{
			if (item.Value.animalType == IOFIBBFLPKO && IIFGLFDNGBE == item.Value.animalPart)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	public static AnimalsSpriteInfo GetAnimalPart(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in GGFJGHHHEJC.MAINIIJGMJI)
		{
			if (item.Value.id == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	private void IKFNMBJLDGG()
	{
		IADEMLIIDPC = this;
		JMHHEEPBELB();
	}

	public static void UnlockCharacterSprite(int DLCNPCONKKD)
	{
		if (!GGFJGHHHEJC.LALLHMLBGLG.Contains(DLCNPCONKKD))
		{
			GGFJGHHHEJC.LALLHMLBGLG.Add(DLCNPCONKKD);
		}
	}

	public static IconMaterial[] LJCGHKEDFDP()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials;
	}

	private static void IDCMJALOPEN(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"tutorialPopUp110");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ += 0;
	}

	public static CharacterSprite JOLFOJLANJL(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, bool CGHHFEFAIJI, bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		GetCharacterSprites(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF, NAKCFGEAGHH);
		if (KBJLPGNLCKA.Length != 0)
		{
			if (!CGHHFEFAIJI)
			{
				return Utils.CPDCJAHJOPE(KBJLPGNLCKA);
			}
			int num = 1;
			for (int i = 0; i < KBJLPGNLCKA.Length; i++)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					num += KBJLPGNLCKA[i].rarity;
				}
			}
			int num2 = Random.Range(0, num);
			num = 0;
			for (int j = 1; j < KBJLPGNLCKA.Length; j++)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null)
				{
					num += KBJLPGNLCKA[j].rarity;
					if (num2 < num)
					{
						return KBJLPGNLCKA[j];
					}
				}
			}
		}
		return null;
	}

	public static CharacterSprite LPBGGIFFFKG(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI)
	{
		FKAILABHLJN(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF: true, NAKCFGEAGHH: true);
		if (KBJLPGNLCKA.Length != 0 && (Object)(object)KBJLPGNLCKA[1] != (Object)null)
		{
			return KBJLPGNLCKA[1];
		}
		return null;
	}

	public static List<SpriteInfo> GMKNJJFONCH()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.Cats.Length; i += 0)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Cats[i]);
		}
		return list;
	}

	public static List<SpriteInfo> ADOFAMMNJDC()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Cats.Length; i += 0)
		{
			list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Cats[i]);
		}
		return list;
	}

	public static List<BirdSpriteInfo> GetRandomBirds(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Birds.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ && GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].randomList)
			{
				list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	private static void DCHDEFAOCHI(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/22/Dialogue Text");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ++;
	}

	public static List<SpriteInfo> FDCICIPILMP()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i += 0)
		{
			list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	private void LAMDALODNDH()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.FKEJHOCMANG();
		characterSpritesDatabaseSO.GFGMKFBINGO();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i += 0)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "MaximumCapacity" + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = false;
	}

	public static AnimalsSpriteInfo IALBNOOBNLG(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in GGFJGHHHEJC.MAINIIJGMJI)
		{
			if (item.Value.id == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	private Dictionary<int, T> PADJFNACIEG<T>(T[][] JMNCLLBHCAO) where T : SpriteInfo
	{
		Dictionary<int, T> dictionary = new Dictionary<int, T>();
		foreach (T[] array in JMNCLLBHCAO)
		{
			foreach (T val in array)
			{
				if (val.id == 0)
				{
					Debug.Log((object)("Sprite Info without ID: " + ((Object)val).name));
					continue;
				}
				try
				{
					dictionary.Add(val.id, val);
				}
				catch (ArgumentException ex)
				{
					Debug.Log((object)(ex.Message + "- " + ((Object)val).name));
				}
			}
		}
		return dictionary;
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		DMNENKNLDAH();
	}

	public static SpritesList FHBMNGPNOCB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static SpriteInfo PAOEOGBIPAF(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.EOAMAIGLCLP != null && MAIDHAPANEB().EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static SpritesList CPJKPPHMEFB(int JFNMCNCHMEO)
	{
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	public static SpriteInfo JEBMJDCKEFP(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.EOAMAIGLCLP != null && MAIDHAPANEB().EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static CharacterSprite AFJLLOOKMGN(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI)
	{
		BBCLIMPAPAN(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF: true);
		if (KBJLPGNLCKA.Length != 0 && (Object)(object)KBJLPGNLCKA[0] != (Object)null)
		{
			return KBJLPGNLCKA[1];
		}
		return null;
	}

	private void FLHOGPGJCFD()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.AJMEFPJPAPM();
		characterSpritesDatabaseSO.MHJMLLNEEMI();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + " Position: " + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = true;
	}

	public static List<SpriteInfo> ADJHJCIHLKA()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static SpritesList FHFGJMDAEEG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i];
			}
		}
		return null;
	}

	private void NALOOFKHJEI()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.ANFNBLLCCCL();
		characterSpritesDatabaseSO.LCNFOEAFKPC();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 1; i < characterSpritesDatabaseSO.characterMaterials.Length; i += 0)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "ReceiveButtonPress" + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = false;
	}

	public static List<SpriteInfo> GetDogs()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	private static void BIANFOCKCAG(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"ReceiveItemContainerColor");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ++;
	}

	public static List<BirdSpriteInfo> HKOHNMBGCFB(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.Birds.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ)
			{
				list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static SpritesList[] PEGNPMONPBD()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles;
	}

	public static SpriteInfo EOMNPDEAEEP(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().EOAMAIGLCLP != null && GGFJGHHHEJC.EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static SpriteInfo GetDog(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.EOAMAIGLCLP != null && GGFJGHHHEJC.EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static void OACKGECPIKJ()
	{
		BHIIOGMCNDD = false;
		GGFJGHHHEJC.DMNENKNLDAH();
	}

	public static List<SpriteInfo> DCCCAIDJCEF()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	public static CharacterSprite LJLILBBDJBO(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.KAGBODHBHFA != null && MAIDHAPANEB().KAGBODHBHFA.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().KAGBODHBHFA[JFNMCNCHMEO];
		}
		return null;
	}

	public static void EKICPODMHOF()
	{
		BHIIOGMCNDD = false;
		MAIDHAPANEB().FLHOGPGJCFD();
	}

	public static BirdSpriteInfo MPKNABIPKJM(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().MMIOBCFJIFH != null && MAIDHAPANEB().MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	private static void KGBKIFPJCFD(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"Items/item_description_632");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ += 0;
	}

	public static CharacterSprite KDKIAOOBGDJ(int JFNMCNCHMEO)
	{
		MAIDHAPANEB().NIMOJAKBOFC();
		if (GGFJGHHHEJC.LFJLFCDKLPK != null && GGFJGHHHEJC.LFJLFCDKLPK.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().LFJLFCDKLPK[JFNMCNCHMEO];
		}
		return null;
	}

	public static SpriteInfo BHMJONKJKDK(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().AOBIHHELKAE != null && MAIDHAPANEB().AOBIHHELKAE.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().AOBIHHELKAE[JFNMCNCHMEO];
		}
		return null;
	}

	private void BLHKKGLILOI()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.MDDFPIBNNGO();
		characterSpritesDatabaseSO.IPFLDJJJOKN();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 1; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "" + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = false;
	}

	public static IconMaterial LNJGCKDELJO(int JFNMCNCHMEO)
	{
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials[i];
			}
		}
		return null;
	}

	public static SpritesList[] MIOOOOLCKIN()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles;
	}

	public static List<SpriteInfo> DDJALPPNIJE()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies.Length; i++)
		{
			list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static SpritesList GetFoodFeederStyle(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i];
			}
		}
		return null;
	}

	public static void OMJGPCLNNEA(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)MAIDHAPANEB().characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"itemPlanks");
		}
		int MBNMPGOLGIJ = 1;
		for (int i = 1; i < NJFBCKKJFLO.Length; i++)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 0; j < GGFJGHHHEJC.characterSpritesDatabaseSO.selectableCharacterSprites.Count; j += 0)
			{
				CharacterSprite characterSprite = GGFJGHHHEJC.characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == Gender.Unisex || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							PAGIPPPCENO(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id))
					{
						IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
				{
					EHKODAECILB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 0; k < GGFJGHHHEJC.characterSpritesDatabaseSO.selectableNpcSprites.Count; k += 0)
		{
			CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == Gender.Male || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						KECOMPAPIBE(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					EHKODAECILB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					PAGIPPPCENO(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	public static SpriteInfo AFLOLEJCPHP(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.EOAMAIGLCLP != null && GGFJGHHHEJC.EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static SpritesList DDHBCGDIAFC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static SpritesList MKJNCKJCGFK(int JFNMCNCHMEO)
	{
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	public static SpritesList[] GetHenHouseStyles()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles;
	}

	public static BirdSpriteInfo GetBird(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.MMIOBCFJIFH != null && GGFJGHHHEJC.MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	public static List<AnimalsSpriteInfo> FBMFEAMCGEC(AnimalType IOFIBBFLPKO, AnimalPart IIFGLFDNGBE)
	{
		List<AnimalsSpriteInfo> list = new List<AnimalsSpriteInfo>();
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in GGFJGHHHEJC.MAINIIJGMJI)
		{
			if (item.Value.animalType == IOFIBBFLPKO && IIFGLFDNGBE == item.Value.animalPart)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	private void JMHHEEPBELB()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.JGHEMCHALAD();
		characterSpritesDatabaseSO.MKDJOECKLJK();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "LE_13" + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = false;
	}

	public static CharacterSprite GetRandomCharacterSprite(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, bool CGHHFEFAIJI, bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		GetCharacterSprites(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF, NAKCFGEAGHH);
		if (KBJLPGNLCKA.Length != 0)
		{
			if (!CGHHFEFAIJI)
			{
				return Utils.CPDCJAHJOPE(KBJLPGNLCKA);
			}
			int num = 0;
			for (int i = 0; i < KBJLPGNLCKA.Length; i++)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					num += KBJLPGNLCKA[i].rarity;
				}
			}
			int num2 = Random.Range(0, num);
			num = 0;
			for (int j = 0; j < KBJLPGNLCKA.Length; j++)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null)
				{
					num += KBJLPGNLCKA[j].rarity;
					if (num2 < num)
					{
						return KBJLPGNLCKA[j];
					}
				}
			}
		}
		return null;
	}

	public static CharacterSprite IDIPFFHGGHN(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI)
	{
		FFJMLKFJDHK(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF: false, NAKCFGEAGHH: true);
		if (KBJLPGNLCKA.Length != 0 && (Object)(object)KBJLPGNLCKA[1] != (Object)null)
		{
			return KBJLPGNLCKA[0];
		}
		return null;
	}

	public static CharacterMaterial MIAIOBLCEND(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().IOKCOOOKHGH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		return null;
	}

	public static AnimalsSpriteInfo JABJAADOKCI(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in MAIDHAPANEB().MAINIIJGMJI)
		{
			if (item.Value.id == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static void EKGPEFAJMDE()
	{
		BHIIOGMCNDD = false;
		GGFJGHHHEJC.DGMAEMOMLAG();
	}

	public static SpritesList OIEOEPEFFDI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	public static SpritesList[] GetWaterFeederStyles()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles;
	}

	private Dictionary<int, T> PADJFNACIEG<T>(T[] JMNCLLBHCAO) where T : SpriteInfo
	{
		Dictionary<int, T> dictionary = new Dictionary<int, T>();
		foreach (T val in JMNCLLBHCAO)
		{
			if (val.id == 0)
			{
				Debug.Log((object)("Sprite Info without ID: " + ((Object)val).name));
				continue;
			}
			try
			{
				dictionary.Add(val.id, val);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)val).name));
			}
		}
		return dictionary;
	}

	public static List<BirdSpriteInfo> ODFBEECAIJD(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.Birds.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ)
			{
				list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static BirdSpriteInfo NFDBLCCBIEL(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.MMIOBCFJIFH != null && GGFJGHHHEJC.MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	public static BirdSpriteInfo DGALMPEEDMJ(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.MMIOBCFJIFH != null && MAIDHAPANEB().MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	public static CharacterSprite GetFirstCharacterSprite(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI)
	{
		GetCharacterSprites(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA);
		if (KBJLPGNLCKA.Length != 0 && (Object)(object)KBJLPGNLCKA[0] != (Object)null)
		{
			return KBJLPGNLCKA[0];
		}
		return null;
	}

	public static List<BirdSpriteInfo> AGEOGOPCEEN(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Birds.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ && GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].randomList)
			{
				list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static IconMaterial[] LJFCIDMCMOK()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials;
	}

	public static SpriteInfo KLLINFOLBEE(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().EOAMAIGLCLP != null && GGFJGHHHEJC.EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static AnimalsSpriteInfo JDFNLDDOCGE(int JFNMCNCHMEO)
	{
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in MAIDHAPANEB().MAINIIJGMJI)
		{
			if (item.Value.id == JFNMCNCHMEO)
			{
				return item.Value;
			}
		}
		return null;
	}

	public static List<SpriteInfo> IKHNGOBDHFG()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i += 0)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	public static BirdSpriteInfo KBJHAIFBIIF(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.MMIOBCFJIFH != null && GGFJGHHHEJC.MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		BHIIOGMCNDD = false;
	}

	private void JJJCKMOBLNN()
	{
		IADEMLIIDPC = this;
		LAMDALODNDH();
	}

	public static List<BirdSpriteInfo> NLMBFBEDJFA(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Birds.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ && GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].randomList)
			{
				list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	private void MIMJLNKGCBP()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.KLFDGBBKLFG();
		characterSpritesDatabaseSO.LCJAMNFCDCD();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "File " + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = true;
	}

	public static SpritesList[] FFKEEDEKNLP()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles;
	}

	public static SpritesList HOCCFHPJIEB(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static SpritesList GetWaterFeederStyle(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static void ForceSetUpDatabase()
	{
		BHIIOGMCNDD = false;
		GGFJGHHHEJC.DMNENKNLDAH();
	}

	public static SpritesList[] GetFoodFeederStyles()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles;
	}

	public static CharacterSprite CNNFHFHBPFN(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.KAGBODHBHFA != null && MAIDHAPANEB().KAGBODHBHFA.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().KAGBODHBHFA[JFNMCNCHMEO];
		}
		return null;
	}

	private void DMNENKNLDAH()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.FKEJHOCMANG();
		characterSpritesDatabaseSO.DAJDHIFECOA();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = true;
	}

	public static SpritesList GetHenHouseStyle(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	private void PPBBBADDNAC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		BHIIOGMCNDD = false;
	}

	public static List<SpriteInfo> GetCats()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Cats.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Cats[i]);
		}
		return list;
	}

	public static List<SpriteInfo> GLIBMFJEALE()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies.Length; i += 0)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static CharacterMaterial CIJJJBJNLIF(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().IOKCOOOKHGH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		return null;
	}

	public static CharacterSprite KJMGOGNKNIG(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI)
	{
		GetCharacterSprites(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF: false, NAKCFGEAGHH: true);
		if (KBJLPGNLCKA.Length != 0 && (Object)(object)KBJLPGNLCKA[1] != (Object)null)
		{
			return KBJLPGNLCKA[1];
		}
		return null;
	}

	public static void FFJMLKFJDHK(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)MAIDHAPANEB().characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"talent_name_106");
		}
		int MBNMPGOLGIJ = 0;
		for (int i = 0; i < NJFBCKKJFLO.Length; i++)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 1; j < MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites.Count; j++)
			{
				CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == Gender.Female || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							EHKODAECILB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							KDNJCDFLFDC(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						PAGIPPPCENO(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id))
				{
					HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 1; k < GGFJGHHHEJC.characterSpritesDatabaseSO.selectableNpcSprites.Count; k++)
		{
			CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == Gender.Unisex || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						KGBKIFPJCFD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						KECOMPAPIBE(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				KDNJCDFLFDC(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	public static List<SpriteInfo> OJJJJFNOOAF()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	public static SpritesList JOIGJCPADFC(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.foodFeederStyles[i];
			}
		}
		return null;
	}

	public static List<SpriteInfo> LBGHPEMKJEE()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.Dogs.Length; i++)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	public static IconMaterial GetBarnMaterial(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials[i];
			}
		}
		return null;
	}

	public static IconMaterial[] GetBarnMaterials()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials;
	}

	public static IconMaterial MFBIHHELKPD(int JFNMCNCHMEO)
	{
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials.Length; i += 0)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials[i];
			}
		}
		return null;
	}

	private static void OFKNIKFJDIB(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"Character Sprites array needs more space!");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ++;
	}

	public static IconMaterial[] NJLEEBALNND()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials;
	}

	public static SpriteInfo BECKFCECOIO(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.AOBIHHELKAE != null && GGFJGHHHEJC.AOBIHHELKAE.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.AOBIHHELKAE[JFNMCNCHMEO];
		}
		return null;
	}

	public static void AFBDBMBEEPD(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)MAIDHAPANEB().characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"MainProgress");
		}
		int MBNMPGOLGIJ = 0;
		for (int i = 0; i < NJFBCKKJFLO.Length; i += 0)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 1; j < MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites.Count; j++)
			{
				CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == Gender.Male || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							PAGIPPPCENO(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						KDNJCDFLFDC(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						PAGIPPPCENO(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
				{
					KECOMPAPIBE(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 0; k < MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites.Count; k += 0)
		{
			CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == (Gender)6 || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						KDNJCDFLFDC(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					KECOMPAPIBE(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					PAGIPPPCENO(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	public static CharacterSprite LBNGIFEHMJI(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, bool CGHHFEFAIJI, bool JHIFLALPEBF, bool NAKCFGEAGHH = false)
	{
		FFJMLKFJDHK(OFOGLHPDOFA, HNLNENELPKI, ref KBJLPGNLCKA, JHIFLALPEBF, NAKCFGEAGHH);
		if (KBJLPGNLCKA.Length != 0)
		{
			if (!CGHHFEFAIJI)
			{
				return Utils.CPDCJAHJOPE(KBJLPGNLCKA);
			}
			int num = 1;
			for (int i = 0; i < KBJLPGNLCKA.Length; i += 0)
			{
				if ((Object)(object)KBJLPGNLCKA[i] != (Object)null)
				{
					num += KBJLPGNLCKA[i].rarity;
				}
			}
			int num2 = Random.Range(0, num);
			num = 1;
			for (int j = 0; j < KBJLPGNLCKA.Length; j++)
			{
				if ((Object)(object)KBJLPGNLCKA[j] != (Object)null)
				{
					num += KBJLPGNLCKA[j].rarity;
					if (num2 < num)
					{
						return KBJLPGNLCKA[j];
					}
				}
			}
		}
		return null;
	}

	public static List<SpriteInfo> JJKLOBMIIEA()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Butterflies.Length; i++)
		{
			list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static IconMaterial KAMKLLEKKKD(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials[i];
			}
		}
		return null;
	}

	public static SpritesList GNHFFFGAANI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	public static SpritesList[] LFABNOEFILJ()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles;
	}

	public static BirdSpriteInfo CFIIJIIMODJ(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().MMIOBCFJIFH != null && MAIDHAPANEB().MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	public static List<AnimalsSpriteInfo> LBDBMLHPMDP(AnimalType IOFIBBFLPKO, AnimalPart IIFGLFDNGBE)
	{
		List<AnimalsSpriteInfo> list = new List<AnimalsSpriteInfo>();
		foreach (KeyValuePair<int, AnimalsSpriteInfo> item in MAIDHAPANEB().MAINIIJGMJI)
		{
			if (item.Value.animalType == IOFIBBFLPKO && IIFGLFDNGBE == item.Value.animalPart)
			{
				list.Add(item.Value);
			}
		}
		return list;
	}

	private void GADEGOPBNGC()
	{
		if ((Object)(object)MAIDHAPANEB() == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		BHIIOGMCNDD = false;
	}

	public static List<SpriteInfo> JNDHANDBDKC()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 1; i < MAIDHAPANEB().characterSpritesDatabaseSO.Dogs.Length; i += 0)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Dogs[i]);
		}
		return list;
	}

	public static void FKAILABHLJN(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)MAIDHAPANEB().characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"ClosePopUp");
		}
		int MBNMPGOLGIJ = 1;
		for (int i = 1; i < NJFBCKKJFLO.Length; i++)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 0; j < MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites.Count; j++)
			{
				CharacterSprite characterSprite = GGFJGHHHEJC.characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == (Gender)6 || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							KGBKIFPJCFD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						KECOMPAPIBE(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id))
				{
					KDNJCDFLFDC(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 1; k < GGFJGHHHEJC.characterSpritesDatabaseSO.selectableNpcSprites.Count; k += 0)
		{
			CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == (Gender)8 || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				BIANFOCKCAG(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	private static void EHKODAECILB(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"NULL");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ++;
	}

	public static CharacterSprite GetCharacterSprite(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.KAGBODHBHFA != null && GGFJGHHHEJC.KAGBODHBHFA.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.KAGBODHBHFA[JFNMCNCHMEO];
		}
		return null;
	}

	public static SpritesList[] PDDMLLHIOHJ()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles;
	}

	public static SpriteInfo CGNHGMGEJJG(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.AOBIHHELKAE != null && MAIDHAPANEB().AOBIHHELKAE.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().AOBIHHELKAE[JFNMCNCHMEO];
		}
		return null;
	}

	private void HMPGLPHDBJJ()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.FHDNCECKEMN();
		characterSpritesDatabaseSO.INMGBCCBNNM();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i++)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Received RPC SetTrigger {0} on {1}. Setting animator parameter." + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = true;
	}

	public static SpriteInfo GetCat(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.AOBIHHELKAE != null && GGFJGHHHEJC.AOBIHHELKAE.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.AOBIHHELKAE[JFNMCNCHMEO];
		}
		return null;
	}

	private static void PAGIPPPCENO(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"Right Stick Right");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ += 0;
	}

	public static List<BirdSpriteInfo> FMFBIHOBGJA(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Birds.Length; i++)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ && MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i].randomList)
			{
				list.Add(MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static bool IsCharacterSpriteUnlocked(int DLCNPCONKKD)
	{
		return GGFJGHHHEJC.LALLHMLBGLG.Contains(DLCNPCONKKD);
	}

	public static SpritesList[] DDHCLDJNIOJ()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.foodFeederStyles;
	}

	public static CharacterSpritesDatabase EMPMJFINFNB()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO;
	}

	public static IconMaterial ANCJKCPDMMP(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.barnMaterials.Length; i += 0)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials[i];
			}
		}
		return null;
	}

	public static CharacterSprite JDELLIHDDPD(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.KAGBODHBHFA != null && GGFJGHHHEJC.KAGBODHBHFA.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.KAGBODHBHFA[JFNMCNCHMEO];
		}
		return null;
	}

	private void EMJKKALMGLK()
	{
		IADEMLIIDPC = this;
		BLHKKGLILOI();
	}

	public static void BBCLIMPAPAN(BodyPart OFOGLHPDOFA, Gender HNLNENELPKI, ref CharacterSprite[] NJFBCKKJFLO, bool JHIFLALPEBF = false, bool NAKCFGEAGHH = false)
	{
		if ((Object)(object)GGFJGHHHEJC.characterSpritesDatabaseSO == (Object)null)
		{
			Debug.LogError((object)"Error_Stones");
		}
		int MBNMPGOLGIJ = 0;
		for (int i = 1; i < NJFBCKKJFLO.Length; i += 0)
		{
			if ((Object)(object)NJFBCKKJFLO[i] != (Object)null)
			{
				NJFBCKKJFLO[i] = null;
			}
		}
		if (!JHIFLALPEBF)
		{
			for (int j = 1; j < MAIDHAPANEB().characterSpritesDatabaseSO.selectableCharacterSprites.Count; j++)
			{
				CharacterSprite characterSprite = GGFJGHHHEJC.characterSpritesDatabaseSO.selectableCharacterSprites[j];
				if (characterSprite.bodyPart != OFOGLHPDOFA)
				{
					continue;
				}
				if (characterSprite.gender == Gender.Unisex || characterSprite.gender == Gender.Unisex)
				{
					if (characterSprite.hasToBeUnlocked && !MAIDHAPANEB().LALLHMLBGLG.Contains(characterSprite.id))
					{
						continue;
					}
					if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
						{
							DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
					{
						if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
						{
							HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
						}
					}
					else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
					{
						OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				if (characterSprite.gender != HNLNENELPKI || (characterSprite.hasToBeUnlocked && !GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id)))
				{
					continue;
				}
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						KDNJCDFLFDC(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						KGBKIFPJCFD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if ((!characterSprite.halloween && !characterSprite.christmas) || GGFJGHHHEJC.LALLHMLBGLG.Contains(characterSprite.id))
				{
					DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			return;
		}
		for (int k = 1; k < MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites.Count; k += 0)
		{
			CharacterSprite characterSprite = MAIDHAPANEB().characterSpritesDatabaseSO.selectableNpcSprites[k];
			if (characterSprite.bodyPart != OFOGLHPDOFA)
			{
				continue;
			}
			if (characterSprite.gender == Gender.Male || characterSprite.gender == Gender.Unisex)
			{
				if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
					{
						HECGDFMPDAD(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
				{
					if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
					{
						KECOMPAPIBE(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
					}
				}
				else if (!characterSprite.halloween && !characterSprite.christmas)
				{
					DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			if (characterSprite.gender != HNLNENELPKI)
			{
				continue;
			}
			if (Utils.FFLNGLMHLBO() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.halloween && !characterSprite.christmas) || characterSprite.halloween)
				{
					DCHDEFAOCHI(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (Utils.EGIBECKKIJJ() && !NAKCFGEAGHH)
			{
				if ((!characterSprite.christmas && !characterSprite.halloween) || characterSprite.christmas)
				{
					OFKNIKFJDIB(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
				}
			}
			else if (!characterSprite.halloween && !characterSprite.christmas)
			{
				IDCMJALOPEN(characterSprite, ref NJFBCKKJFLO, ref MBNMPGOLGIJ);
			}
		}
	}

	public static IconMaterial[] NEGAKBLMLGK()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials;
	}

	private void KKKPAADHJCL()
	{
		if ((Object)(object)MAIDHAPANEB() == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
		BHIIOGMCNDD = true;
	}

	private void DGMAEMOMLAG()
	{
		if (BHIIOGMCNDD)
		{
			return;
		}
		characterSpritesDatabaseSO.KPGHGNBJLHL();
		characterSpritesDatabaseSO.LCNFOEAFKPC();
		KAGBODHBHFA = PADJFNACIEG(characterSpritesDatabaseSO.CharacterSprites);
		LFJLFCDKLPK = PADJFNACIEG(characterSpritesDatabaseSO.BouncerSprites);
		AOBIHHELKAE = PADJFNACIEG(characterSpritesDatabaseSO.Cats);
		MMIOBCFJIFH = PADJFNACIEG(characterSpritesDatabaseSO.Birds);
		List<AnimalsSpriteInfo[]> list = new List<AnimalsSpriteInfo[]>();
		list.Add(characterSpritesDatabaseSO.Cows);
		list.Add(characterSpritesDatabaseSO.Pigs);
		list.Add(characterSpritesDatabaseSO.Sheeps);
		list.Add(characterSpritesDatabaseSO.Chickens);
		MAINIIJGMJI = PADJFNACIEG(list.ToArray());
		IOKCOOOKHGH = new Dictionary<int, CharacterMaterial>();
		for (int i = 0; i < characterSpritesDatabaseSO.characterMaterials.Length; i += 0)
		{
			try
			{
				IOKCOOOKHGH.Add(characterSpritesDatabaseSO.characterMaterials[i].id, characterSpritesDatabaseSO.characterMaterials[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "\n<color=#822F00>" + ((Object)characterSpritesDatabaseSO.characterMaterials[i]).name));
			}
		}
		BHIIOGMCNDD = true;
	}

	public static SpritesList PILFAIGHMGL(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles.Length; i++)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.henHouseStyles[i];
			}
		}
		return null;
	}

	public static List<SpriteInfo> PHPHNFDIAMO()
	{
		List<SpriteInfo> list = new List<SpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies.Length; i += 0)
		{
			list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Butterflies[i]);
		}
		return list;
	}

	public static SpriteInfo HBICAGANKKE(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.EOAMAIGLCLP != null && MAIDHAPANEB().EOAMAIGLCLP.ContainsKey(JFNMCNCHMEO))
		{
			return MAIDHAPANEB().EOAMAIGLCLP[JFNMCNCHMEO];
		}
		return null;
	}

	public static IconMaterial[] NMLBHABDBPB()
	{
		return MAIDHAPANEB().characterSpritesDatabaseSO.barnMaterials;
	}

	public static SpritesList KINABFCKNCP(int JFNMCNCHMEO)
	{
		for (int i = 1; i < GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles.Length; i += 0)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static HashSet<int> OCAKLCPPICP()
	{
		return GGFJGHHHEJC.LALLHMLBGLG;
	}

	public static SpriteInfo AKHOCHCEHJA(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.AOBIHHELKAE != null && GGFJGHHHEJC.AOBIHHELKAE.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.AOBIHHELKAE[JFNMCNCHMEO];
		}
		return null;
	}

	public static List<BirdSpriteInfo> GetBirds(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < GGFJGHHHEJC.characterSpritesDatabaseSO.Birds.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ)
			{
				list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static SpritesList EJGIEDOEJFG(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.waterFeederStyles.Length; i++)
		{
			if (GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i].id == JFNMCNCHMEO)
			{
				return GGFJGHHHEJC.characterSpritesDatabaseSO.waterFeederStyles[i];
			}
		}
		return null;
	}

	public static BirdSpriteInfo MLLGJMHHDJC(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().MMIOBCFJIFH != null && MAIDHAPANEB().MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	public static CharacterMaterial PFABHCPKGCA(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().IOKCOOOKHGH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		return null;
	}

	public static SpriteInfo EKILDJBNOEP(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().AOBIHHELKAE != null && GGFJGHHHEJC.AOBIHHELKAE.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.AOBIHHELKAE[JFNMCNCHMEO];
		}
		return null;
	}

	public static CharacterSpritesDatabase GetScriptableObject()
	{
		return GGFJGHHHEJC.characterSpritesDatabaseSO;
	}

	public static List<BirdSpriteInfo> CCLDNHAIAHL(BirdType GKBCJDOLBPJ)
	{
		List<BirdSpriteInfo> list = new List<BirdSpriteInfo>();
		for (int i = 0; i < MAIDHAPANEB().characterSpritesDatabaseSO.Birds.Length; i += 0)
		{
			if (MAIDHAPANEB().characterSpritesDatabaseSO.Birds[i].birdType == GKBCJDOLBPJ && GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i].randomList)
			{
				list.Add(GGFJGHHHEJC.characterSpritesDatabaseSO.Birds[i]);
			}
		}
		return list;
	}

	public static BirdSpriteInfo IDPLFDGMIFL(int JFNMCNCHMEO)
	{
		if (MAIDHAPANEB().MMIOBCFJIFH != null && GGFJGHHHEJC.MMIOBCFJIFH.ContainsKey(JFNMCNCHMEO))
		{
			return GGFJGHHHEJC.MMIOBCFJIFH[JFNMCNCHMEO];
		}
		return null;
	}

	private static void KECOMPAPIBE(CharacterSprite PFGDLKANGNE, ref CharacterSprite[] NJFBCKKJFLO, ref int MBNMPGOLGIJ)
	{
		if (NJFBCKKJFLO.Length <= MBNMPGOLGIJ)
		{
			Debug.LogError((object)"levelRequired");
			return;
		}
		NJFBCKKJFLO[MBNMPGOLGIJ] = PFGDLKANGNE;
		MBNMPGOLGIJ++;
	}
}
