using System;
using UnityEngine;

public class OnlineCrafter : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Fuel,
		StartCrafting,
		RemoveFromCraftingList
	}

	public Action<short> OnFuelChanged = delegate
	{
	};

	public Crafter crafter;

	public void HIMFEDDIOIO(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, (short)EGKBKOABHON);
	}

	public void DIILBJODGPD(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HKPMELDAGIH(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IKHOIDOOHEE(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}

	public void JONEIHCMNKC(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void SendCollectItems(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void ILGMPPBBPHL()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void AOJMBNFNKND(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void HLMEGNJFMNM()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void OGPGHGDIKAN()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void OHBGCACJOEI(int MOFKEDGAOEE)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)MOFKEDGAOEE);
	}

	public void PCPFKLHPJAI(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void OJFCHCHDICN(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void AHILLCILNJH(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public void NKCHJKNHAKO(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JNHNADNGAIH(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void SendRemoveFromCraftingList(int MOFKEDGAOEE)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, (byte)MOFKEDGAOEE);
	}

	public void OLPFGODGKII(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void NJAGJBJJPDG(int MOFKEDGAOEE)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5, (byte)MOFKEDGAOEE);
	}

	public void BEMLCGJBDFC(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void LBHLIPFKOLI(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void DNKAFILACFB(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HBBOOLMICHC(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void GJKDLILFABO(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void EJNNDNLAHBO()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void JOIMFFPICMP(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void IOOLLJGJHIO(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void GOKJKANFJJA(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void GGAAMFPHGKG(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void NDBNIBDCCIK(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void ICHJIDNJBAL(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JJICIBICEOA(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM));
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		crafter = ((Component)((Component)this).transform).GetComponentInChildren<Crafter>();
	}

	public void CAGADEOLBOH(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	public void AEMIJIAACGH(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void ENIAABOKNHD(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MCOJFJNOGAP(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void OIIKMILKGOK()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void OECKCJKONCJ(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void MDCEKNJFEEI(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MGMCCGBFAOA(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LIBBGIPFCEN(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IDFFJKBEEIL(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void BGOEACLMACE(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KLHNMDHHGLP(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void GNLGOFIMFMI(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void GGIECKJGEEI(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public override void CollectItems(byte HFDILBELIKE, short JJPJHIHBOIB)
	{
		crafter.CollectItems(1, EFNFMEIDGDN: true, HFDILBELIKE, OnlineManager.IsLocalActor(JJPJHIHBOIB));
	}

	public void BKMAGDKNOHK()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void NHIDBMCEKLN(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public void CGLGKMHCAOG(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void PACDPCDCAAJ(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void KHGIGIPECLL(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FNFIEOELIDG(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void ODGCFPGFFCC(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void DHEOPDDJNGP(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}

	public void EHPMKJAJOLA(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}

	public void NGLEPLIHKAB(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void DDNFPPLPIFB(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KDGGOPKJEGF(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void FHFCOLMMKFK()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void GFNLBABJHIH()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void JODIKEEIJGN(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void IPLINOJDAEA(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void BFCILGBNACC(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void OBBANMLDJMJ(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KIKGJAPFKEN(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BOPKEPDJDMB()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void SendStartCrafting(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void ANCJHIGCMCA()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void FLJOFLLCLGI()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void KECLEBODJGN()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void INHHLJNINLH(int MOFKEDGAOEE)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7, (byte)MOFKEDGAOEE);
	}

	public void JJEIGAJHBGI()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void EJIJAFNDKLH(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void ADLOFOJNPND(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void OPCGNLJPFOC(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HLKHHDKJKCP(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IPNCJDNPKFK(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public void SendCancelAllCrafting()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void OENKICEILJP(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NACPDGLHGMJ(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public void CAEOJNGIOLE()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void EGKKIBJCBEF(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void CPFGLNBJJPH(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	public void FDPDOKNDIMF(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void GCHGBOBNBNC(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}

	public void EDKHAPOGNGB(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LAMPBOALHND(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public void PILGBLBJAAM()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void KCLGKNBPFJP(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public void NNMFLJOHAED(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void IMHGNIADFKL(RecipeQueueElement FFNGGJENDKI, GameDate OOMMCABDBGO)
	{
		NewRecipeQueueElementMessage mOBFJEDPIPM = new NewRecipeQueueElementMessage(FFNGGJENDKI, OOMMCABDBGO);
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MHKHKEGIKDJ()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void JHIPPIJHKMK(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (short)EGKBKOABHON);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		switch (FACPEEACCMH)
		{
		case 0:
			crafter.SetFuel((short)GEMFIOKGIMC[0]);
			break;
		case 1:
		{
			NewRecipeQueueElementMessage newRecipeQueueElementMessage = OnlineSerializer.Deserialize<NewRecipeQueueElementMessage>((byte[])GEMFIOKGIMC[0]);
			crafter.StartCrafting(1, newRecipeQueueElementMessage.recipeQueueElementMessage.MMANNOMOCMP(), newRecipeQueueElementMessage.dateFinished.JBJLBDHAECK(), LHAMOFLLKOF: true, GFNHAMCPEAK: false);
			break;
		}
		case 2:
			crafter.RemoveFromCraftingList(1, (byte)GEMFIOKGIMC[0], GFNHAMCPEAK: false);
			break;
		}
	}

	public override PlaceableMsg CreateMsg()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			Debug.LogError((object)("Crafter not attached on OnlineCrafter of placeable " + ((Object)((Component)this).gameObject).name));
		}
		return new CrafterMessage(this);
	}

	public void SendFuel(int EGKBKOABHON)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, (short)EGKBKOABHON);
	}

	public void PLCPOIFGLML(int EGKBKOABHON)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (short)EGKBKOABHON;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IMPHOBLELCM()
	{
		OnlineObjectsManager.instance.SendCancelAllCrafting(uniqueId);
	}

	public void JCBMOBEBFCA(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void CEACDMNMDPC(int MOFKEDGAOEE)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (byte)MOFKEDGAOEE;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void ELEGALJPOEC(int HFDILBELIKE)
	{
		OnlineObjectsManager.instance.SendCollectItems(uniqueId, HFDILBELIKE);
	}
}
