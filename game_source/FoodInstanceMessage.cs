using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WebSocketSharp;

[Serializable]
public class FoodInstanceMessage : ItemInstanceMessage
{
	[JsonProperty("1")]
	public short[] ingredientsID;

	[JsonProperty("2")]
	public string customName;

	[JsonProperty("3")]
	public byte agingRank;

	[JsonProperty("4")]
	public short mainIngredientID;

	[JsonProperty("5")]
	public byte qualityLevel;

	private Food JIIAEMMNPHN(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.INJBNHPGCIJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food NBOGMGKJBHC(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food BBJHMNCFLBF(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food HBCAHECHIKF(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food HCODKFMHLKF(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food KEMBGFNDOPC(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GOKIDLOELKB(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food HNCPKGAOFCF(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GOKIDLOELKB(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food NCMGKFMHJGG(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food AFHBMIOFIHM(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food PNFLBGJJLDF(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food JDFFNNCOFPE(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food JHJHGLJOINA(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food BBEMBCCKLJD(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	public FoodInstanceMessage(FoodInstance GCJPFFNGCJA)
		: base(GCJPFFNGCJA)
	{
		customName = GCJPFFNGCJA.AKFIOJCGMDH;
		agingRank = (byte)GCJPFFNGCJA.GBCJNGADANM;
		qualityLevel = (byte)GCJPFFNGCJA.GHFDCAOBJMK;
		if (GCJPFFNGCJA.KEKBKGGFOLK != null && GCJPFFNGCJA.KEKBKGGFOLK.Count > 0)
		{
			ingredientsID = (from x in GCJPFFNGCJA.KEKBKGGFOLK
				where Item.MLBOMGHINCA(x, null)
				select (short)x.JDJGFAACPFC()).ToArray();
		}
		if (Item.MLBOMGHINCA(GCJPFFNGCJA.mainIngredient, null))
		{
			mainIngredientID = (short)GCJPFFNGCJA.mainIngredient.JDJGFAACPFC();
		}
	}

	public override void BNBJFAHIMNH(ItemInstance DNLMCHDOMOK)
	{
		base.BNBJFAHIMNH(DNLMCHDOMOK);
		if (!(DNLMCHDOMOK is FoodInstance foodInstance))
		{
			return;
		}
		if (!Ext.IsNullOrEmpty(customName))
		{
			foodInstance.AKFIOJCGMDH = customName;
		}
		if (ingredientsID != null && ingredientsID.Length != 0)
		{
			Food food = EADEKIOKABI(ingredientsID, 0);
			Food food2 = EADEKIOKABI(ingredientsID, 1);
			Food food3 = EADEKIOKABI(ingredientsID, 2);
			foodInstance.KEKBKGGFOLK = new List<Food>();
			if (Item.MLBOMGHINCA(food, null))
			{
				foodInstance.KEKBKGGFOLK.Add(food);
			}
			if (Item.MLBOMGHINCA(food2, null))
			{
				foodInstance.KEKBKGGFOLK.Add(food2);
			}
			if (Item.MLBOMGHINCA(food3, null))
			{
				foodInstance.KEKBKGGFOLK.Add(food3);
			}
			foodInstance.CICEBNMBGMG = ModifierUI.CreateModifiers(foodInstance.KEKBKGGFOLK);
			foodInstance.mainIngredient = ItemDatabaseAccessor.GetItem(mainIngredientID) as Food;
		}
		foodInstance.GBCJNGADANM = agingRank;
		foodInstance.GHFDCAOBJMK = qualityLevel;
	}

	private Food AMOOKDDPDPE(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food LJIPEOJMPJH(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.INJBNHPGCIJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food FOPKALFOMBG(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.KMBGJEKCJFJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food HCLIOAEOAIP(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GOKIDLOELKB(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food BJKKEIPNCFA(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.KMBGJEKCJFJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food BMKAANNFMEJ(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.CPMMBEPEJLO(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food OHLOOEPJCCL(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food LCGEGIDOGEO(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food FLGHAJNMGMN(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food IBMNGBHIGIC(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food AOHNGLOEKOG(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food OLOKNKJDEPI(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food NIFIFDAPKFK(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food AKPABPIIIJD(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.INJBNHPGCIJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food MODADMFMGPP(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food EBGCIODECOD(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GOKIDLOELKB(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food PFEGIJFDOKC(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food LIPPLALFIJC(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food PGCBHKGAAOH(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food HNACGNCDPLM(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food DPNFOFPIKFD(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food JFIKDEMCFHJ(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food JBPEOKACJFK(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food JLNNNNILAEO(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.KMBGJEKCJFJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food NKIMFBIIHOF(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.KMBGJEKCJFJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food MLPOBBGANJL(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food IHJAMFKIECN(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.EABMGELAAPG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: false, DAINLFIMLIH: false) as Food;
	}

	private Food LLKCLKBEAEI(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food ONIAMFFPBOB(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food EADEKIOKABI(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GetItem(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}

	private Food KLPKAIABCOE(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.AFOACBIHNCL(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true, DAINLFIMLIH: false) as Food;
	}

	private Food IGPIDKBKJPG(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.INJBNHPGCIJ(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	public FoodInstanceMessage()
	{
	}

	private Food PBAEPHKHICI(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food KNLJBFJMICM(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.COEFFIHKMJG(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE), GGBBJNBBLMF: true) as Food;
	}

	private Food LKLGGBOIDIM(short[] AKNADGKJBIF, int MOFKEDGAOEE)
	{
		return ItemDatabaseAccessor.GOKIDLOELKB(Utils.OFAJOIGFMAD(AKNADGKJBIF, MOFKEDGAOEE)) as Food;
	}
}
