using System;
using Newtonsoft.Json;

[Serializable]
public struct IngredientUsedMessage
{
	[JsonProperty("i")]
	public ItemInstanceWrapperMessage itemInstance;

	[JsonProperty("a")]
	public short amount;

	[JsonProperty("mI")]
	public bool isModifierIngredient;

	public IngredientUsedInfo ABNGOCGAHKL()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.JPCIMEAFOBC(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo OLPCMJPOEOA()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.BAGHNANOFPK(), amount), isModifierIngredient, null);
	}

	public IngredientUsedMessage(IngredientUsedInfo PDNBFEBMDAP)
	{
		itemInstance = new ItemInstanceWrapperMessage(PDNBFEBMDAP.itemInstanceAmount.itemInstance);
		amount = (short)PDNBFEBMDAP.itemInstanceAmount.amount;
		isModifierIngredient = PDNBFEBMDAP.isModifierIngredient;
	}

	public IngredientUsedInfo CABAFLBMHOH()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.JPCIMEAFOBC(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo KPIIKNAPHJL()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.ECAEFDNJMDD(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo MONCIPBGGBO()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.JJACMHPLEPO(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo NCJMBGIOPFO()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.ANMBPDJLNFN(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo BKLHGICNBAF()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.LNELHNKCFBL(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo BHCNOCEOLCN()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.MEBJICJFALH(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo ADKEFGCFOBI()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.CGLNBKOHBIH(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo JDFLKBMOIDC()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.EMFCKLAFIED(), amount), isModifierIngredient, null);
	}

	public IngredientUsedInfo IBPNOFDBCJO()
	{
		return new IngredientUsedInfo(new ItemInstanceAmount(itemInstance.NMELFMAKGDK(), amount), isModifierIngredient, null);
	}
}
