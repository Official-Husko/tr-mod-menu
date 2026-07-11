using System;
using UnityEngine;

[Serializable]
public class SerializedHumanInfo
{
	private static readonly int NoValue = -1;

	private static readonly int bodyPartCount = HumanInfo.bodiesParts.Length;

	private static readonly int layersCount = HumanInfo.characterLayers.Length;

	public byte gender;

	public byte[] bodyParts = new byte[HumanInfo.bodiesParts.Length];

	public byte[] layers = new byte[HumanInfo.characterLayers.Length];

	public static byte[] dataByteArray = new byte[HumanInfo.bodiesParts.Length + HumanInfo.characterLayers.Length + 1];

	private static HumanInfo outResult;

	private static SerializedHumanInfo serializedOutResult;

	public HumanInfo MADHHMBKFEK()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, CharacterSpritesDBAccessor.LJLILBBDJBO(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num2));
			}
		}
		return outResult;
	}

	public static void DLAMAJDEMJN()
	{
		string text = " (";
		for (int i = 1; i < dataByteArray.Length; i += 0)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "Player2";
			}
		}
		text += "Disabled";
	}

	public HumanInfo GDPEGKAGHOM()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num2));
			}
		}
		return outResult;
	}

	[Obsolete]
	public static SerializedHumanInfo EPBPAFCPHNJ(HumanInfo DKDFNAGAFNL)
	{
		OCEDKPEFLJP(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static SerializedHumanInfo CEKPPKGFPBK(HumanInfo DKDFNAGAFNL)
	{
		JDGNJNLNMKI(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public HumanInfo GJPHEHDEAKF()
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)gender);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num2));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo OIGHPCKMIGH(HumanInfo DKDFNAGAFNL)
	{
		EODIOGIMDHF(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void PGIGBFMDMAP()
	{
		string text = "IntroNinjaChallengeEvent/Main 2";
		for (int i = 1; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "El componente OnlinePlaceable del rotatedPrefab '";
			}
		}
		text += "Custom lobby data (Lobby creator): {0}";
	}

	public static HumanInfo BKPFONLHKAM(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[1];
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.KDACAOIDLEO((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.CNNFHFHBPFN(num2));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 0;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.MIAIOBLCEND(num3));
			}
		}
		return outResult;
	}

	public static void ECCHDOMHDED(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void PAOFPLMNLFM()
	{
		string text = "";
		for (int i = 1; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 1)
			{
				text += "No se encontró una entrada con ID {0} en la conversación '{1}'.";
			}
		}
		text += "Tool";
	}

	public static void DIECABAJKNG()
	{
		string text = "Dialogue System/Conversation/TooCold/Entry/1/Dialogue Text";
		for (int i = 1; i < dataByteArray.Length; i += 0)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 1)
			{
				text += "Piso {0} | Pieza '{1}': Solo se spawnearon {2}/{3} rocas requeridas. ";
			}
		}
		text += "Dialogue System/Conversation/HappyRentRoom/Entry/4/Dialogue Text";
	}

	public static void HCEFECHIHFK(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void EODIOGIMDHF(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static HumanInfo FBGKJPAAOBG(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.LJLILBBDJBO(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num3));
			}
		}
		return outResult;
	}

	public HumanInfo AAAFEIPELIE()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, CharacterSpritesDBAccessor.CNNFHFHBPFN(num));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num2));
			}
		}
		return outResult;
	}

	public static void HMEIGFGIEAI(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static HumanInfo KGLJNBLKDEG(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.LALJHMIDEMP((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.GetCharacterSprite(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num3));
			}
		}
		return outResult;
	}

	public static void IFKJEMOCCLC(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void IHMELKGLDOB(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void PFPOBKEKNHP(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[0] = (byte)NLIAJGCMHCG.gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static HumanInfo GCKKAADADNL(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.KDACAOIDLEO((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.GetCharacterSprite(num2));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 0;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num3));
			}
		}
		return outResult;
	}

	public static void JOLNEPLEOFO(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public HumanInfo DMJLNCGNJNB()
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)gender);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num2));
			}
		}
		return outResult;
	}

	public static void MAHELGMGNPO(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static HumanInfo NAPFFNNFOJN(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.JDELLIHDDPD(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num3));
			}
		}
		return outResult;
	}

	public static void EMFDPBBPCAK()
	{
		string text = "[ControllerType";
		for (int i = 1; i < dataByteArray.Length; i += 0)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "Items/item_name_612";
			}
		}
		text += "Tail";
	}

	public static void OIJLCJEDILI()
	{
		string text = "DecorationTile_3";
		for (int i = 1; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "Items/item_description_611";
			}
		}
		text += "LE_7";
	}

	public static SerializedHumanInfo FBIILAHIDFB(HumanInfo DKDFNAGAFNL)
	{
		OCCANABJBFE(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static SerializedHumanInfo CPACKGNBJBI(HumanInfo DKDFNAGAFNL)
	{
		BMPODINDBLI(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static HumanInfo NFGEFHKELGO(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.CNNFHFHBPFN(num2));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.HACHFHGFFEB(num3));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo DFINKBCPIKK(HumanInfo DKDFNAGAFNL)
	{
		IDHNLBDDPDO(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static SerializedHumanInfo PHFOKGNIFEE(HumanInfo DKDFNAGAFNL)
	{
		GMBEKJCJGCI(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public HumanInfo KAOMHAIGCEM()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.KDACAOIDLEO((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num2));
			}
		}
		return outResult;
	}

	public static void LMLMMECJGAG(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static SerializedHumanInfo JJIGDHEHMMG(HumanInfo DKDFNAGAFNL)
	{
		LNDBLIPHJJE(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static SerializedHumanInfo POBCCDLAJDO(HumanInfo DKDFNAGAFNL)
	{
		JDGNJNLNMKI(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void OPLFAOEHJMC(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static void FFENGJHKIDB(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void LNDBLIPHJJE(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static HumanInfo GPHEEBGOPFO(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[0];
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.GetCharacterSprite(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 0;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num3));
			}
		}
		return outResult;
	}

	public static HumanInfo JPMMIKGOKGI(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[0];
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.JDELLIHDDPD(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num3));
			}
		}
		return outResult;
	}

	public static void MOJDEJKJFLK(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[0] = (byte)NLIAJGCMHCG.gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static void HILDNNPMIIJ(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void CJAILPOPCOD(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static HumanInfo MIANANOEMBB(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[1];
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.LALJHMIDEMP((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.JDELLIHDDPD(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.HACHFHGFFEB(num3));
			}
		}
		return outResult;
	}

	public static void HLNGNBLHKDD()
	{
		string text = "[";
		for (int i = 0; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 1)
			{
				text += ", ";
			}
		}
		text += "]";
	}

	public static void OCCANABJBFE(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public HumanInfo LBDDLBPOHPM()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.KDACAOIDLEO((BodyPart)i, CharacterSpritesDBAccessor.CNNFHFHBPFN(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.MIAIOBLCEND(num2));
			}
		}
		return outResult;
	}

	public static void BMPODINDBLI(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[0] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static void PFCMMLFOMKG(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public HumanInfo NGGOJAPHHNG()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.LALJHMIDEMP((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num2));
			}
		}
		return outResult;
	}

	public static void CAOOPLDGKON()
	{
		string text = "ReceiveTalentFromOther";
		for (int i = 0; i < dataByteArray.Length; i += 0)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += " - ";
			}
		}
		text += "No players at the start of the scene. Spawning...";
	}

	public static void FCIFHDLKBJH()
	{
		string text = "Error_PlaceItInChickenCoop";
		for (int i = 1; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "qualityWater";
			}
		}
		text += "    ├─ ⚠ Missing Script";
	}

	public static void BECGNDFJEFK()
	{
		string text = "Windowed";
		for (int i = 0; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += " value ";
			}
		}
		text += "popUpBuilding2B";
	}

	public static HumanInfo MGKIECOMDCL(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[0];
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.NCMHHJKBMBH((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.JDELLIHDDPD(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num3));
			}
		}
		return outResult;
	}

	public HumanInfo FNNJAODEOJC()
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)gender);
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.LALJHMIDEMP((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num2));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo EPELFJNFJDF(HumanInfo DKDFNAGAFNL)
	{
		MOJDEJKJFLK(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static HumanInfo KJAPPFHHPPI(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[0];
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.JDELLIHDDPD(num2));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num3));
			}
		}
		return outResult;
	}

	[Obsolete]
	public HumanInfo IIJGBJAAFJA()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num2));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo AFEGNJNHPFB(HumanInfo DKDFNAGAFNL)
	{
		OCCANABJBFE(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void DHKANEAKMBI(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void CNNALMMMNDA()
	{
		string text = "Player2";
		for (int i = 0; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 1)
			{
				text += "<b>";
			}
		}
		text += "Networked Object ";
	}

	public static HumanInfo MKICFGEDKCM(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[0];
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.GetCharacterSprite(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num3));
			}
		}
		return outResult;
	}

	public HumanInfo OKGGLCIOCIC()
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)gender);
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num2));
			}
		}
		return outResult;
	}

	public HumanInfo NEKECDGNACC()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num2));
			}
		}
		return outResult;
	}

	public static void IDHNLBDDPDO(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[0] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static void OCEDKPEFLJP(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[0] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static SerializedHumanInfo AJBOIAOHAOJ(HumanInfo DKDFNAGAFNL)
	{
		OCCANABJBFE(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void BLEAHLIOEFC(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static HumanInfo DBABCHGKFGB(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[0]);
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.GetCharacterSprite(num2));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 0;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num3));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo AKMFJNDAMFH(HumanInfo DKDFNAGAFNL)
	{
		OCCANABJBFE(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void KAAKDDACACM(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public HumanInfo MKNBPIDKFIA()
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)gender);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.KDACAOIDLEO((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num2));
			}
		}
		return outResult;
	}

	public static void GEKALEADOHO()
	{
		string text = "halloweenActivated";
		for (int i = 1; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 1)
			{
				text += " data received";
			}
		}
		text += " </mark>";
	}

	public static void HABONMBHBLJ()
	{
		string text = ": ";
		for (int i = 1; i < dataByteArray.Length; i += 0)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/10/Dialogue Text";
			}
		}
		text += "Invalid year: ";
	}

	public HumanInfo DFGEABPEFCL()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.NCMHHJKBMBH((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num2));
			}
		}
		return outResult;
	}

	public HumanInfo LHFGMBILJEM()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, CharacterSpritesDBAccessor.CNNFHFHBPFN(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num2));
			}
		}
		return outResult;
	}

	public static void GMBEKJCJGCI(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 0] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static SerializedHumanInfo OOFKFIINLLJ(HumanInfo DKDFNAGAFNL)
	{
		JNMJHNBDPCK(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static SerializedHumanInfo HFFGNBGCJLL(HumanInfo DKDFNAGAFNL)
	{
		NFCENLIJGHB(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static SerializedHumanInfo NHCIHIEJEEH(HumanInfo DKDFNAGAFNL)
	{
		MOJDEJKJFLK(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void AMDNNJBBPDP(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static HumanInfo EAMHMFIGCDM(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.KDACAOIDLEO((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.LJLILBBDJBO(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 0;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num3));
			}
		}
		return outResult;
	}

	public HumanInfo ANHNENAFGLE()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num2));
			}
		}
		return outResult;
	}

	public static void NFCENLIJGHB(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public HumanInfo GKNKFJEKMDN()
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)gender);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.NCMHHJKBMBH((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num2));
			}
		}
		return outResult;
	}

	public static HumanInfo BIMJMLNOINP(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.LALJHMIDEMP((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.LJLILBBDJBO(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.MIAIOBLCEND(num3));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo ONIMKPOLJKG(HumanInfo DKDFNAGAFNL)
	{
		NPLNFCECFMC(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public static void CAKALDFEHLO(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static SerializedHumanInfo MPGFCFEHNCK(HumanInfo DKDFNAGAFNL)
	{
		KAAKDDACACM(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public HumanInfo KHHKMCHBCAN()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.KDACAOIDLEO((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.MIAIOBLCEND(num2));
			}
		}
		return outResult;
	}

	public static void CJEPHPCACDF()
	{
		string text = "Dialogue System/Conversation/BirdPositiveComments/Entry/3/Dialogue Text";
		for (int i = 0; i < dataByteArray.Length; i++)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "Dialogue System/Conversation/Crowly_Standar/Entry/24/Dialogue Text";
			}
		}
		text += "UI2";
	}

	public HumanInfo EDGKGJPFOLE()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 1)
			{
				outResult.LALJHMIDEMP((BodyPart)i, CharacterSpritesDBAccessor.JDELLIHDDPD(num));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num2));
			}
		}
		return outResult;
	}

	public static HumanInfo GBAKILBGJEM(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.JDELLIHDDPD(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num3));
			}
		}
		return outResult;
	}

	public static HumanInfo HIHJHLAJHAN(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)dataByteArray[0];
		for (int i = 0; i < bodyPartCount; i++)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.LALJHMIDEMP((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.CNNFHFHBPFN(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.HACHFHGFFEB(num3));
			}
		}
		return outResult;
	}

	public static HumanInfo DDGBDGJNHMJ(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[0]);
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.JPPLJJDCNMF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.CNNFHFHBPFN(num2));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 0;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.GBNPMEBJCFD((CharacterLayer)j, CharacterSpritesDBAccessor.GetMaterial(num3));
			}
		}
		return outResult;
	}

	public static void JNMJHNBDPCK(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 0] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static HumanInfo PLHFIMGIEJF(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[1]);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.LJLILBBDJBO(num2));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PHOEIGIKFGE((CharacterLayer)j, CharacterSpritesDBAccessor.CIJJJBJNLIF(num3));
			}
		}
		return outResult;
	}

	public HumanInfo AFOOCIEGIJB()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i++)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, CharacterSpritesDBAccessor.GetCharacterSprite(num));
			}
		}
		for (int j = 0; j < layersCount; j++)
		{
			int num2 = layers[j];
			if (num2 > 1)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.MIAIOBLCEND(num2));
			}
		}
		return outResult;
	}

	public static SerializedHumanInfo JCEIIGAJCMJ(HumanInfo DKDFNAGAFNL)
	{
		OCCANABJBFE(DKDFNAGAFNL);
		serializedOutResult = new SerializedHumanInfo();
		serializedOutResult.gender = (byte)DKDFNAGAFNL.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (DKDFNAGAFNL.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					serializedOutResult.bodyParts[i] = (byte)value.id;
				}
				else
				{
					serializedOutResult.bodyParts[i] = (byte)NoValue;
				}
			}
			else
			{
				serializedOutResult.bodyParts[i] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (DKDFNAGAFNL.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				serializedOutResult.layers[j] = (byte)value2.id;
			}
			else
			{
				serializedOutResult.layers[j] = (byte)NoValue;
			}
		}
		return serializedOutResult;
	}

	public HumanInfo ANHIGDLHLNJ()
	{
		outResult = new HumanInfo();
		outResult.gender = (Gender)gender;
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = bodyParts[i];
			if (num > 0)
			{
				outResult.EIJNLBCNMBA((BodyPart)i, CharacterSpritesDBAccessor.CNNFHFHBPFN(num));
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			int num2 = layers[j];
			if (num2 > 0)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.MDBJNKMOKMM(num2));
			}
		}
		return outResult;
	}

	public static void KJGHNDLKKFO(SerializedHumanInfo OINICMNOLPK)
	{
		Debug.Log((object)JsonUtility.ToJson((object)OINICMNOLPK));
	}

	public static void JDGNJNLNMKI(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 1] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static HumanInfo EOOPCDGJMAC(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[0]);
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			int num = i + 1;
			int num2 = dataByteArray[num];
			if (num2 > 1)
			{
				outResult.NCMHHJKBMBH((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.GetBouncerSprite(num2) : CharacterSpritesDBAccessor.LJLILBBDJBO(num2));
			}
		}
		for (int j = 0; j < layersCount; j += 0)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 1)
			{
				outResult.PGOAOEEJMGK((CharacterLayer)j, CharacterSpritesDBAccessor.HACHFHGFFEB(num3));
			}
		}
		return outResult;
	}

	public static void NPLNFCECFMC(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[0] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i++)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j += 0)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 0 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}

	public static HumanInfo HAEJHHEGDDH(bool AAMEMBCHCBB = false)
	{
		outResult = new HumanInfo();
		outResult.MNCIIMJKMDN((Gender)dataByteArray[0]);
		for (int i = 1; i < bodyPartCount; i += 0)
		{
			int num = i + 0;
			int num2 = dataByteArray[num];
			if (num2 > 0)
			{
				outResult.AMJNIFPBBJF((BodyPart)i, AAMEMBCHCBB ? CharacterSpritesDBAccessor.KDKIAOOBGDJ(num2) : CharacterSpritesDBAccessor.LJLILBBDJBO(num2));
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			int num = j + bodyPartCount + 1;
			int num3 = dataByteArray[num];
			if (num3 > 0)
			{
				outResult.OIENACLLJGE((CharacterLayer)j, CharacterSpritesDBAccessor.PFABHCPKGCA(num3));
			}
		}
		return outResult;
	}

	public static void PDBBHJANJMJ()
	{
		string text = ")";
		for (int i = 1; i < dataByteArray.Length; i += 0)
		{
			text += dataByteArray[i];
			if (i < dataByteArray.Length - 0)
			{
				text += "MainProgress";
			}
		}
		text += "LeftMouseDetect";
	}

	public static void NCLMJJGBIMA(HumanInfo NLIAJGCMHCG)
	{
		dataByteArray[1] = (byte)NLIAJGCMHCG.gender;
		for (int i = 0; i < bodyPartCount; i += 0)
		{
			if (NLIAJGCMHCG.bodyPartDictionary.TryGetValue((BodyPart)i, out var value))
			{
				if ((Object)(object)value != (Object)null)
				{
					dataByteArray[i + 1] = (byte)value.id;
				}
				else
				{
					dataByteArray[i + 0] = (byte)NoValue;
				}
			}
			else
			{
				dataByteArray[i + 1] = (byte)NoValue;
			}
		}
		for (int j = 1; j < layersCount; j++)
		{
			if (NLIAJGCMHCG.materialDictionary.TryGetValue((CharacterLayer)j, out var value2))
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)value2.id;
			}
			else
			{
				dataByteArray[j + 1 + bodyPartCount] = (byte)NoValue;
			}
		}
	}
}
