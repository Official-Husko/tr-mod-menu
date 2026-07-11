using System;

[Serializable]
public class ShopItem
{
	public Item item;

	public bool alwaysAppear = true;

	public float weight;

	public bool unlimited = true;

	public int min = 1;

	public int max = 1;

	public ShopItem()
	{
	}

	public ShopItem(ShopItem EPBCFCNEOCF)
	{
		item = EPBCFCNEOCF.item;
		alwaysAppear = EPBCFCNEOCF.alwaysAppear;
		unlimited = EPBCFCNEOCF.unlimited;
		weight = EPBCFCNEOCF.weight;
		min = EPBCFCNEOCF.min;
		max = EPBCFCNEOCF.max;
	}

	public ShopItem(Item MEMGMDOCBOJ, bool PGAAADKDBJE = false, bool MJCABOBOLOK = false, float GCBEEIJBPOO = 1f, int MPCJBPJAGKK = 1, int ACAIKFICNFP = 1)
	{
		item = MEMGMDOCBOJ;
		alwaysAppear = PGAAADKDBJE;
		unlimited = MJCABOBOLOK;
		weight = GCBEEIJBPOO;
		min = MPCJBPJAGKK;
		max = ACAIKFICNFP;
	}
}
