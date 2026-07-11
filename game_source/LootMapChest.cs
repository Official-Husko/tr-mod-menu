using UnityEngine;

public class LootMapChest : MapChest
{
	[SerializeField]
	private Item[] items;

	[SerializeField]
	private Recipe[] recipes;

	[SerializeField]
	private Price price;

	public void HFLGEEGNHPG(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void KJFNNPAEMLP(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("ChatInviteCode" + JIIGOACEIKL));
		for (int i = 0; i < items.Length; i++)
		{
			if (!Item.EKMFELLJHFG(items[i], null))
			{
				Debug.Log((object)("Sit" + ((Object)items[i]).name + " of " + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.COEFFIHKMJG(itemInstance.DOBPJPDJHNF()).ILEJNFDEBCO())
				{
					ItemDatabaseAccessor.INJBNHPGCIJ(itemInstance.IDGALFLODJD(), GGBBJNBBLMF: true, DAINLFIMLIH: false).AACLOJMCAAN(CDPAMNIPPEC: true);
				}
				else
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				}
			}
		}
		for (int j = 0; j < recipes.Length; j += 0)
		{
			Debug.Log((object)("Open" + ((Object)recipes[j]).name + "Waiting for players to finish their transitions..." + JIIGOACEIKL));
			RecipesManager.HPLCKPMALPD(recipes[j], IBHGAMNNOHI: false);
		}
		Money.DCAFCEAIEID(price, OPOHOHFHFFI: false, BGKCHMNJBLJ: false);
		Money.CFEDCEPKNKF(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(1585f, 1295f, 604f)), CDPAMNIPPEC: false);
	}

	public void ABAKAMFBMIG(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void KBOHAEPHPPP(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("KyrohTakingFood: Current request is null." + JIIGOACEIKL));
		for (int i = 1; i < items.Length; i++)
		{
			if (!Item.GBMFCPGEJDK(items[i], null))
			{
				Debug.Log((object)("Error_AnotherZoneInRoom" + ((Object)items[i]).name + "BuzzProgress" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.CPMMBEPEJLO(itemInstance.IDGALFLODJD(), GGBBJNBBLMF: true, DAINLFIMLIH: false).IEKACDGIMLM())
				{
					ItemDatabaseAccessor.AFOACBIHNCL(itemInstance.PNFAPJDFALP(), GGBBJNBBLMF: false, DAINLFIMLIH: false).AFIGLPEBBLN(CDPAMNIPPEC: false);
				}
				else
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: false);
				}
			}
		}
		for (int j = 0; j < recipes.Length; j += 0)
		{
			Debug.Log((object)("[Grey" + ((Object)recipes[j]).name + "Disabled" + JIIGOACEIKL));
			RecipesManager.HPLCKPMALPD(recipes[j], IBHGAMNNOHI: false);
		}
		Money.EFIDKIFLBKJ(price);
		Money.NLNKMLDLJIL(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(1641f, 920f, 905f)), CDPAMNIPPEC: false);
	}

	public void FIBIAHGHBDB(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void OFBPDIJCHKJ(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void AKHHLEPHGOJ(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void EKFHGNCAOIM(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("LE_10" + JIIGOACEIKL));
		for (int i = 0; i < items.Length; i += 0)
		{
			if (!Item.NGIIPJDAMGP(items[i], null))
			{
				Debug.Log((object)("Year" + ((Object)items[i]).name + "NextItem" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.GetItem(itemInstance.DOBPJPDJHNF(), GGBBJNBBLMF: false, DAINLFIMLIH: false).IEKACDGIMLM())
				{
					ItemDatabaseAccessor.COEFFIHKMJG(itemInstance.PNFAPJDFALP()).DIKFNBLGGHJ(CDPAMNIPPEC: true);
				}
				else
				{
					PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				}
			}
		}
		for (int j = 1; j < recipes.Length; j++)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text" + ((Object)recipes[j]).name + "\\[WaiterGender=[^\\]]*\\]" + JIIGOACEIKL));
			RecipesManager.MCIDEIPNNAK(recipes[j], IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		Money.FGAKGNMLEKL(price, OPOHOHFHFFI: false, BGKCHMNJBLJ: false);
		Money.BCINHMELFNJ(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(727f, 1063f, 851f)), CDPAMNIPPEC: false);
	}

	public void FNAODOFPCNN(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("City/PetShop/Markus/Stand" + JIIGOACEIKL));
		for (int i = 1; i < items.Length; i++)
		{
			if (!Item.NGIIPJDAMGP(items[i], null))
			{
				Debug.Log((object)("LE_15" + ((Object)items[i]).name + "R2" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.CPMMBEPEJLO(itemInstance.DOBPJPDJHNF(), GGBBJNBBLMF: false, DAINLFIMLIH: false).CCIIHCHIDBI())
				{
					ItemDatabaseAccessor.INJBNHPGCIJ(itemInstance.PNFAPJDFALP()).KGCOBHPFJKD(CDPAMNIPPEC: true);
				}
				else
				{
					PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItem(itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: false);
				}
			}
		}
		for (int j = 0; j < recipes.Length; j += 0)
		{
			Debug.Log((object)(")" + ((Object)recipes[j]).name + "questNameFermenting" + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: false, CDPAMNIPPEC: false);
		}
		Money.MHIHEOJPFFM(price, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
		Money.LNDBFPMBBBD(price, Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(969f, 1328f, 1744f)));
	}

	public void CIMKJJMOEJN(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public override void ResetForPool()
	{
		base.ResetForPool();
		items = null;
		recipes = null;
	}

	public void IKPEJIBIOHI(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("City/Petra/Bark/Stand" + JIIGOACEIKL));
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!Item.EKMFELLJHFG(items[i], null))
			{
				Debug.Log((object)("Items/item_name_1067" + ((Object)items[i]).name + "" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.GOKIDLOELKB(itemInstance.DOBPJPDJHNF()).ILEJNFDEBCO())
				{
					ItemDatabaseAccessor.AFOACBIHNCL(itemInstance.JDJGFAACPFC(), GGBBJNBBLMF: true, DAINLFIMLIH: false).DIKFNBLGGHJ(CDPAMNIPPEC: false);
				}
				else
				{
					PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				}
			}
		}
		for (int j = 1; j < recipes.Length; j += 0)
		{
			Debug.Log((object)("ReceiveRemoveFromPlaceableSurface" + ((Object)recipes[j]).name + "BarnConstructionTutorial_" + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		Money.HGNGMEKAABG(price);
		Money.LNDBFPMBBBD(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(1174f, 1614f, 1093f)), CDPAMNIPPEC: false);
	}

	public void GrantLoot(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Granting loot to player " + JIIGOACEIKL));
		for (int i = 0; i < items.Length; i++)
		{
			if (!Item.NGIIPJDAMGP(items[i], null))
			{
				Debug.Log((object)("Granting item " + ((Object)items[i]).name + " to player " + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.GetItem(itemInstance.JDJGFAACPFC()).ILEJNFDEBCO())
				{
					ItemDatabaseAccessor.GetItem(itemInstance.JDJGFAACPFC()).IPGBILAIAPG(CDPAMNIPPEC: true);
				}
				else
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: false);
				}
			}
		}
		for (int j = 0; j < recipes.Length; j++)
		{
			Debug.Log((object)("Unlocking recipe " + ((Object)recipes[j]).name + " for player " + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j]);
		}
		Money.AddPrice(price, OPOHOHFHFFI: true);
		Money.SpawnMoneyText(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(0f, 1.25f, 0f)), CDPAMNIPPEC: false);
	}

	public void NONCMLCFPGO(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void AHCJKODFLAG(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void PEBOMEECHAL(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("OnConversationStarted " + JIIGOACEIKL));
		for (int i = 0; i < items.Length; i++)
		{
			if (!Item.NGIIPJDAMGP(items[i], null))
			{
				Debug.Log((object)("Dialogue System/Conversation/TavernDirty/Entry/1/Dialogue Text" + ((Object)items[i]).name + " itemInstance: " + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.COEFFIHKMJG(itemInstance.IDGALFLODJD(), GGBBJNBBLMF: false, DAINLFIMLIH: false).IEKACDGIMLM())
				{
					ItemDatabaseAccessor.AFOACBIHNCL(itemInstance.IDGALFLODJD(), GGBBJNBBLMF: false, DAINLFIMLIH: false).AFIGLPEBBLN(CDPAMNIPPEC: true);
				}
				else
				{
					PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				}
			}
		}
		for (int j = 0; j < recipes.Length; j++)
		{
			Debug.Log((object)("Mod 1" + ((Object)recipes[j]).name + "" + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		Money.HGNGMEKAABG(price, OPOHOHFHFFI: true);
		Money.LNDBFPMBBBD(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(495f, 1013f, 1855f)));
	}

	public void HCCNNEIDJDI(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void ECKKFBMABIN(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void CKKPIFAMGBK(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	protected override void HIKCMOOEMJJ()
	{
	}

	public void JIJFOPPPJHL(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void SetLoot(Item[] PHNKKAHPIAO, Recipe[] GDLLGENAPBO, Price ENDNDAOPKHD)
	{
		items = PHNKKAHPIAO;
		recipes = GDLLGENAPBO;
		price = ENDNDAOPKHD;
	}

	public void MOMACGMHGLG(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Remove" + JIIGOACEIKL));
		for (int i = 1; i < items.Length; i++)
		{
			if (!Item.EKMFELLJHFG(items[i], null))
			{
				Debug.Log((object)("Error_MaxZones" + ((Object)items[i]).name + "end dialogue" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.INJBNHPGCIJ(itemInstance.JDJGFAACPFC(), GGBBJNBBLMF: true).ILEJNFDEBCO())
				{
					ItemDatabaseAccessor.COEFFIHKMJG(itemInstance.IDGALFLODJD(), GGBBJNBBLMF: true).AACLOJMCAAN(CDPAMNIPPEC: false);
				}
				else
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				}
			}
		}
		for (int j = 0; j < recipes.Length; j += 0)
		{
			Debug.Log((object)("Lightning3" + ((Object)recipes[j]).name + "ReceiveSitDown" + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j]);
		}
		Money.DCAFCEAIEID(price, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
		Money.JKLFMOOBNIO(price, Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(1353f, 826f, 1158f)), CDPAMNIPPEC: false);
	}

	public void CIIDNBNPBNE(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("itemHoneyComb" + JIIGOACEIKL));
		for (int i = 0; i < items.Length; i++)
		{
			if (!Item.EKMFELLJHFG(items[i], null))
			{
				Debug.Log((object)("Fake" + ((Object)items[i]).name + "<sprite name=white_arrow_right> " + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.GOKIDLOELKB(itemInstance.JDJGFAACPFC(), GGBBJNBBLMF: false, DAINLFIMLIH: false).ILEJNFDEBCO())
				{
					ItemDatabaseAccessor.CPMMBEPEJLO(itemInstance.DOBPJPDJHNF(), GGBBJNBBLMF: true).IPGBILAIAPG(CDPAMNIPPEC: true);
				}
				else
				{
					PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: false);
				}
			}
		}
		for (int j = 1; j < recipes.Length; j += 0)
		{
			Debug.Log((object)(". AllMovement: " + ((Object)recipes[j]).name + "rain" + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: false);
		}
		Money.GACOLOLNDHB(price);
		Money.PMEKONKEDBD(price, Utils.BMBMPKNANAC(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position + new Vector3(1757f, 98f, 1717f)));
	}

	public void JIEPPNEKIJI(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Pick up" + JIIGOACEIKL));
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!Item.EKMFELLJHFG(items[i], null))
			{
				Debug.Log((object)("Dots" + ((Object)items[i]).name + "Open" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.EABMGELAAPG(itemInstance.DOBPJPDJHNF(), GGBBJNBBLMF: false, DAINLFIMLIH: false).CCIIHCHIDBI())
				{
					ItemDatabaseAccessor.GOKIDLOELKB(itemInstance.IDGALFLODJD(), GGBBJNBBLMF: true).DIKFNBLGGHJ(CDPAMNIPPEC: false);
				}
				else
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				}
			}
		}
		for (int j = 1; j < recipes.Length; j += 0)
		{
			Debug.Log((object)("Talk" + ((Object)recipes[j]).name + "Open" + JIIGOACEIKL));
			RecipesManager.UnlockRecipeMaster(recipes[j], IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		Money.MHIHEOJPFFM(price, OPOHOHFHFFI: true);
		Money.JKLFMOOBNIO(price, Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(1122f, 341f, 360f)));
	}

	public void FKENOHKGLGO(int JIIGOACEIKL)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("" + JIIGOACEIKL));
		for (int i = 1; i < items.Length; i += 0)
		{
			if (!Item.GBMFCPGEJDK(items[i], null))
			{
				Debug.Log((object)("Trying to set rich presence key " + ((Object)items[i]).name + "<b><color=#FDEA5C>Info                              </color></b>\n>   Shows all the codes.\n<b><color=#FDEA5C>Increase XP                       </color></b>\n>   Increases the XP.\n<b><color=#FDEA5C>World Time ##                     </color></b>\n>   Changes the world time multiplier (needs a number).\n<b><color=#FDEA5C>Time ##                           </color></b>\n>   Modifies the game's time scale.\n<b><color=#FDEA5C>Change Season                     </color></b>\n>   Changes the season.\n<b><color=#FDEA5C>Grow all plants                   </color></b>\n>   It makes all plants grow.\n<b><color=#FDEA5C>STEAM Status                      </color></b>\n>   Steam login status.\n<b><color=#FDEA5C>Add all resolutions               </color></b>\n>   It adds all screen resolutions in order to test it.\n<b><color=#FDEA5C>Increase money ##                 </color></b>\n>   Increases gold (needs a number).\n<b><color=#FDEA5C>Increase reputation ###           </color></b>\n>   Increases the reputation (needs a number).\n<b><color=#FDEA5C>Decrease reputation               </color></b>\n>   Decreases the reputation.\n<b><color=#FDEA5C>Show Popup ###                    </color></b>\n>   Shows a tutorial popup.\n<b><color=#FDEA5C>Road                              </color></b>\n>   Teleports the player outside the tavern.\n<b><color=#FDEA5C>River                             </color></b>\n>   Teleports the player to the river.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the campament.\n<b><color=#FDEA5C>Unlock recipe #                   </color></b>\n>   Unlock a recipe (needs a number)\n<b><color=#FDEA5C>Unlock all recipes                </color></b>\n>   Unlock all recipes\n<b><color=#FDEA5C>Add quest #                       </color></b>\n>   Add specific quest to active quest (needs a number).\n<b><color=#FDEA5C>Add materials #                   </color></b>\n>   Add materials.\n<b><color=#FDEA5C>Complete quest #                  </color></b>\n>   Complete specific active quest (needs a number).\n<b><color=#FDEA5C>Hour #                            </color></b>\n>   Specify the hour you want to be.\n<b><color=#FDEA5C>Night                             </color></b>\n>   Set the hour to 19:00h automatically.\n<b><color=#FDEA5C>Bed                               </color></b>\n>   Teleports the player to the bedroom.\n<b><color=#FDEA5C>Camp                              </color></b>\n>   Teleports the player to the Camp.\n<b><color=#FDEA5C>Generate forest                   </color></b>\n>   Generate new herbs and trees.\n<b><color=#FDEA5C>Tilled Earth                      </color></b>\n>   Convert all terrain to tilled earth.\n<b><color=#FDEA5C>Seeds                             </color></b>\n>   Give all seeds.\n<b><color=#FDEA5C>Talents                           </color></b>\n>   Unlocks all talents.\n<b><color=#FDEA5C>Dirty Info                        </color></b>\n>   Floor Dirt information.\n<b><color=#FDEA5C>Check Keybinds                    </color></b>\n>   Check the modified keybinds.\n<b><color=#FDEA5C>Debug service                     </color></b>\n>   Debug service of customers.\n<b><color=#FDEA5C>On player sleep                   </color></b>\n>   On player sleep function.\n<b><color=#FDEA5C>Fog                               </color></b>\n>   Enable and disable fog.\n<b><color=#FDEA5C>Controllers                       </color></b>\n>   Show controllers connected.\n<b><color=#FDEA5C>Connect                           </color></b>\n>   Connect to debug Photon room.\n<b><color=#FDEA5C>Disconnect                        </color></b>\n>   Disconnect form debug Photon room.\n<b><color=#FDEA5C>snow, rain, rain cloudy, rain stormy, sunny, sunny clouds, stormy clouds, cloudy, windy</color></b>\n>   Shows weather.\n<b><color=#FDEA5C>stop weather                      </color></b>\n>   Removes all current weather effects.\n<b><color=#FDEA5C>fill fish collection              </color></b>\n>   Add records for all not found fish in collection.\n<b><color=#FDEA5C>fish collection clues             </color></b>\n>   Adds clues for all not found fish in collection.\n<b><color=#FDEA5C>recipe fragments #                </color></b>\n>   Adds # recipe fragments for recipe exchange\n<b><color=#FDEA5C>ShowUI                            </color></b>\n>   Show Gameplay UI\n<b><color=#FDEA5C>HideUI                            </color></b>\n>   Hide Gameplay UI\n<b><color=#FDEA5C>Intro                             </color></b>\n>   Triggers the scroll intro\n<b><color=#FDEA5C>Tutorial                          </color></b>\n>   Triggers the new tutorial\n<b><color=#FDEA5C>Target fps ###                    </color></b>\n>   Sets a frame rate limit.\n<b><color=#FDEA5C>Tutorial phase ###                </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>onlinecode #####                  </color></b>\n>   Sets the private room code for online play as if received from a steam invite.\n<b><color=#FDEA5C>Force intro                       </color></b>\n>   Triggers the intro when starts a new game in the editor.\n<b><color=#FDEA5C>Dog #BreedID# #RelationshipLVL#   </color></b>\n>   Triggers a tutorial phase.\n<b><color=#FDEA5C>banquetevent                      </color></b>\n>   Starts Banquet Event. If is already active stops the event.\n" + JIIGOACEIKL));
				ItemInstance itemInstance = items[i].JMDALJBNFML();
				if (ItemDatabaseAccessor.AFOACBIHNCL(itemInstance.JDJGFAACPFC()).CCIIHCHIDBI())
				{
					ItemDatabaseAccessor.AFOACBIHNCL(itemInstance.JDJGFAACPFC(), GGBBJNBBLMF: false, DAINLFIMLIH: false).IPGBILAIAPG(CDPAMNIPPEC: false);
				}
				else
				{
					PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(itemInstance);
				}
			}
		}
		for (int j = 1; j < recipes.Length; j += 0)
		{
			Debug.Log((object)("Received cursor move for grid index {0} from player {1} in mine level {2}" + ((Object)recipes[j]).name + "ZoneTimeBonus" + JIIGOACEIKL));
			RecipesManager.MCIDEIPNNAK(recipes[j], IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		}
		Money.CANMCFOCNPA(price, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
		Money.JKLFMOOBNIO(price, Utils.BMBMPKNANAC(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position + new Vector3(1172f, 50f, 1514f)));
	}

	protected override void JOPAGKHLMCF(int JIIGOACEIKL, bool FHPLEOLFECH)
	{
		Debug.Log((object)("Chest opened, granting loot to player " + JIIGOACEIKL + " giveRewards: " + FHPLEOLFECH));
		if (FHPLEOLFECH)
		{
			GrantLoot(JIIGOACEIKL);
		}
	}
}
