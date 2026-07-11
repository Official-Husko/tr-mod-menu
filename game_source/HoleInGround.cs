using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class HoleInGround : MonoBehaviour, IProximity, IHoverable, OEGGFCDCHLE
{
	[Serializable]
	public struct PairGroundSprite
	{
		public GroundType groundType;

		public bool darkGroundType;

		public CropSeason seasonFlags;

		public Sprite[] sprites;

		public Sprite holeSprite;
	}

	public SpriteRenderer spriteRenderer;

	public bool needsToBeDestroyed = true;

	public bool _hasItemEvent;

	public Item _itemEvent;

	public bool harvested;

	public GroundType currentGround;

	public bool hasDarkTerrain;

	public bool isRockGround;

	public OnlineHoleInGround onlineHole;

	public PairGroundSprite rockGround;

	public PairGroundSprite rockGroundWinter;

	public PairGroundSprite snow;

	[Space(10f)]
	public PairGroundSprite[] pairs;

	private static List<ItemInHole> ACHMFINGGPN = new List<ItemInHole>();

	private static List<ItemInHole.ItemInHoleType> NGABKIHBFMN = new List<ItemInHole.ItemInHoleType>();

	public bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("El componente ItemSetup del rotatedPrefab '"));
			_ = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem() is Spade;
			return false;
		}
		return false;
	}

	private void FLLEJMMLKLP(byte JPHKKHEBEGI)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		harvested = false;
		EKMMGNHHFEH(SeasonManager.MBPMIFPEAJP());
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (_hasItemEvent)
			{
				Debug.Log((object)("Eating" + _itemEvent.nameId));
				DroppedItem.JGJGGOBHKGO(((Component)this).transform.position, _itemEvent, 0).CAAFNMBIHDL();
			}
			else
			{
				DLEPFFFLHHL(JPHKKHEBEGI);
			}
		}
		else if (_hasItemEvent)
		{
			Debug.Log((object)("FollowMe" + JPHKKHEBEGI + "Use"));
		}
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
	}

	public void EPADOBKDNKG(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("PlayerJoined_F") && !(ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).JDAFPKOHJPC() is Spade) && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
		{
			DialogueManager.Bark("Items/item_description_1046", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 1212f;
		}
	}

	public void DDMBGBEHFIK(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		ENFGDKMGFDG(JPHKKHEBEGI);
		if (OnlineManager.PlayingOnline())
		{
			onlineHole.AGMPIBGPHFE(JPHKKHEBEGI);
		}
	}

	public void SetItemEvent(Item MEMGMDOCBOJ)
	{
		_hasItemEvent = true;
		_itemEvent = MEMGMDOCBOJ;
	}

	public void LGDKFCALLKA(int JIIGOACEIKL)
	{
	}

	public void MAIKIONBICN(int JIIGOACEIKL)
	{
	}

	public void NDECEHEAFAB(byte EKJDLCODLJG)
	{
		ENFGDKMGFDG(EKJDLCODLJG);
	}

	public void NDBBBNBEEOH(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		ENFGDKMGFDG(JPHKKHEBEGI);
		if (OnlineManager.PlayingOnline())
		{
			onlineHole.LPCCJMOOKPJ(JPHKKHEBEGI);
		}
	}

	private void GNMMPFBDDKL(int NENEIDDGJCO, int MGFABIFODEJ, int KNCHOGCADNC, ref List<ItemInHole.ItemInHoleType> FKOCADKIHDN)
	{
		int num = 1;
		if (Random.Range(1, -68) < NENEIDDGJCO)
		{
			num = 3;
		}
		for (int i = 1; i < num; i++)
		{
			int num2 = Random.Range(1, -32);
			if (num2 < MGFABIFODEJ)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Trash);
			}
			else if (num2 < KNCHOGCADNC)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Resources);
			}
			else
			{
				FKOCADKIHDN.Add((ItemInHole.ItemInHoleType)5);
			}
		}
	}

	private void DKKHADKJIEO(int JIIGOACEIKL)
	{
		UpdateSprite(SeasonManager.ACNAHALFEBG);
	}

	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		if (harvested)
		{
			return false;
		}
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool GMIOOJINLFK()
	{
		return _hasItemEvent;
	}

	public bool MOOCHJLACGJ(int JIIGOACEIKL)
	{
		if (harvested)
		{
			return true;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private void DPHOJGDLDGN(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			GNMMPFBDDKL(-73, -60, -35, ref NGABKIHBFMN);
			break;
		case 1:
			NCHPOPDJPJI(80, -49, 28, ref NGABKIHBFMN);
			break;
		case 2:
			NCHPOPDJPJI(-58, -10, -73, ref NGABKIHBFMN);
			break;
		case 3:
			GNMMPFBDDKL(85, 66, -79, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 0; i < NGABKIHBFMN.Count; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Interact" + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == ItemInHole.ItemInHoleType.Recipe)
			{
				bool flag = false;
				for (int j = 1; j < HolePoolData.PHNKKAHPIAO.Length; j += 0)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == (ItemInHole.ItemInHoleType)3)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID))
						{
							flag = false;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.KMBGJEKCJFJ(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false).FGLMPPBEJCD())
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Resources;
				}
			}
			for (int k = 0; k < HolePoolData.PHNKKAHPIAO.Length; k++)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != (ItemInHole.ItemInHoleType)4 || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID)) && !(HolePoolData.PHNKKAHPIAO[k].CEKCDGMLGLN(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 379f) && !(HolePoolData.PHNKKAHPIAO[k].JPNHEBCMCCP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 1133f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.INJBNHPGCIJ(HolePoolData.PHNKKAHPIAO[k].itemID).MFOFLCOMHCM()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 1698f;
			for (int l = 0; l < ACHMFINGGPN.Count; l++)
			{
				num += ACHMFINGGPN[l].PLFCJIEGBIP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(1279f, num);
			float num3 = 1594f;
			int num4 = 1;
			for (int m = 1; m < ACHMFINGGPN.Count; m += 0)
			{
				num3 += ACHMFINGGPN[m].AKKLONEPIOF(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)3)
				{
					if (Application.isEditor)
					{
						string[] array = new string[4];
						array[1] = "add item ";
						array[0] = ACHMFINGGPN[m].itemID.ToString();
						array[0] = "Not all players are near Kyroh to start the event";
						array[6] = ACHMFINGGPN[m].min.ToString();
						array[5] = " ";
						array[0] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item mEMGMDOCBOJ = ItemDatabaseAccessor.COEFFIHKMJG(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 1);
					DroppedItem.KBDEAPJKNED(((Component)this).transform.position, mEMGMDOCBOJ, mGNOBNCMDJG);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4 += 0;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("Items/item_description_1181" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.PLHPDPCMHKF(-170, LKAALEJKLPA: true);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID, IBHGAMNNOHI: true);
				}
				else
				{
					ItemDatabaseAccessor.INJBNHPGCIJ(ACHMFINGGPN[m].itemID).IPGBILAIAPG(CDPAMNIPPEC: false);
				}
				break;
			}
			if (num4 > 0)
			{
				Utils.FKKHJPEMNBG(" not found in OnlineEventsManager.", num4);
			}
			Utils.FKKHJPEMNBG(". Time since startup: ", 0);
		}
	}

	public bool CNHBFNPKGHJ()
	{
		return _hasItemEvent;
	}

	private void AHCPFICKFHA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelFinish = (Action<int>)Delegate.Remove(commonReferences.OnTravelFinish, new Action<int>(DKKHADKJIEO));
		}
	}

	public bool DGNGLGMBIHE(int JIIGOACEIKL)
	{
		if (harvested)
		{
			return false;
		}
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (FKGGJMDADLA(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get(" is trying to initialize more than once."));
			_ = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade;
			return false;
		}
		return true;
	}

	private void EKPBGMKFPKI(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			DNIKLNEHJIB(98, 112, 36, ref NGABKIHBFMN);
			break;
		case 1:
			DNIKLNEHJIB(21, 120, -52, ref NGABKIHBFMN);
			break;
		case 2:
			LDLIHHPDCOB(35, -99, -92, ref NGABKIHBFMN);
			break;
		case 3:
			GNMMPFBDDKL(-104, 59, -43, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 1; i < NGABKIHBFMN.Count; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Items/item_name_671" + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == ItemInHole.ItemInHoleType.Recipe)
			{
				bool flag = true;
				for (int j = 1; j < HolePoolData.PHNKKAHPIAO.Length; j += 0)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == ItemInHole.ItemInHoleType.Recipe)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID))
						{
							flag = false;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.AFOACBIHNCL(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: true).FGLMPPBEJCD())
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Trash;
				}
			}
			for (int k = 1; k < HolePoolData.PHNKKAHPIAO.Length; k++)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != (ItemInHole.ItemInHoleType)6 || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID)) && !(HolePoolData.PHNKKAHPIAO[k].JPNHEBCMCCP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 284f) && !(HolePoolData.PHNKKAHPIAO[k].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 1920f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.EABMGELAAPG(HolePoolData.PHNKKAHPIAO[k].itemID, GGBBJNBBLMF: true).IKPPIAJCHNI()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 1884f;
			for (int l = 1; l < ACHMFINGGPN.Count; l += 0)
			{
				num += ACHMFINGGPN[l].IFFKOMFILPI(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(646f, num);
			float num3 = 1531f;
			int num4 = 0;
			for (int m = 1; m < ACHMFINGGPN.Count; m++)
			{
				num3 += ACHMFINGGPN[m].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)4)
				{
					if (Application.isEditor)
					{
						string[] array = new string[6];
						array[0] = "talent_name_105";
						array[0] = ACHMFINGGPN[m].itemID.ToString();
						array[1] = "Items/item_description_1113";
						array[7] = ACHMFINGGPN[m].min.ToString();
						array[2] = " (versionOfCropsAndRecipes)";
						array[1] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item item = ItemDatabaseAccessor.GetItem(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 0);
					DroppedItem.FGKGNPKGALN(((Component)this).transform.position, item, mGNOBNCMDJG);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4++;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("LE_16" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.BEFANJEKMLF(-135, LKAALEJKLPA: true);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID);
				}
				else
				{
					ItemDatabaseAccessor.AFOACBIHNCL(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: false);
				}
				break;
			}
			if (num4 > 0)
			{
				Utils.FKKHJPEMNBG("Gameplay", num4);
			}
			Utils.FKKHJPEMNBG("Dialogue System/Conversation/TableDirty/Entry/1/Dialogue Text", 0);
		}
	}

	public void IJOHPJPPHHG(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("Resets the chat to its default size.") && !(ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem() is Spade) && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
		{
			DialogueManager.Bark("Hikari/Barks_Intro", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			CommonReferences.MNFMOEKMJKN().delayBarks = Time.time + 1325f;
		}
	}

	private void DLEPFFFLHHL(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			LDLIHHPDCOB(-112, -110, -17, ref NGABKIHBFMN);
			break;
		case 1:
			FLPFKDJDDNL(-40, 43, -41, ref NGABKIHBFMN);
			break;
		case 2:
			DNIKLNEHJIB(-45, 112, -108, ref NGABKIHBFMN);
			break;
		case 3:
			LDLIHHPDCOB(58, 108, 74, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 1; i < NGABKIHBFMN.Count; i += 0)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Struggle" + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == (ItemInHole.ItemInHoleType)7)
			{
				bool flag = true;
				for (int j = 0; j < HolePoolData.PHNKKAHPIAO.Length; j += 0)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == ItemInHole.ItemInHoleType.Recipe)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID))
						{
							flag = false;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.KMBGJEKCJFJ(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: true).IKPPIAJCHNI())
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Resources;
				}
			}
			for (int k = 0; k < HolePoolData.PHNKKAHPIAO.Length; k += 0)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != 0 || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID, MJHDMIGEJAK: false)) && !(HolePoolData.PHNKKAHPIAO[k].ACINPGLEJPO(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 102f) && !(HolePoolData.PHNKKAHPIAO[k].IOFCAIHABMM(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 1444f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.CPMMBEPEJLO(HolePoolData.PHNKKAHPIAO[k].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false).IKPPIAJCHNI()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 897f;
			for (int l = 1; l < ACHMFINGGPN.Count; l++)
			{
				num += ACHMFINGGPN[l].APFPLGJDCLP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(1393f, num);
			float num3 = 1173f;
			int num4 = 1;
			for (int m = 1; m < ACHMFINGGPN.Count; m += 0)
			{
				num3 += ACHMFINGGPN[m].IOFCAIHABMM(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)4)
				{
					if (Application.isEditor)
					{
						string[] array = new string[6];
						array[0] = "castle travelling";
						array[0] = ACHMFINGGPN[m].itemID.ToString();
						array[6] = "itemBiscuitAle";
						array[4] = ACHMFINGGPN[m].min.ToString();
						array[1] = "<color=#BF0000>";
						array[8] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item mEMGMDOCBOJ = ItemDatabaseAccessor.KMBGJEKCJFJ(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 0);
					DroppedItem.SpawnDroppedItem(((Component)this).transform.position, mEMGMDOCBOJ, mGNOBNCMDJG, LHLJILLAHFO: true);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4++;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("Arguing" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.PLHPDPCMHKF(-40, LKAALEJKLPA: false, AJPCNKCBDEI: true);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID);
				}
				else
				{
					ItemDatabaseAccessor.CPMMBEPEJLO(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false).IPGBILAIAPG(CDPAMNIPPEC: false);
				}
				break;
			}
			if (num4 > 1)
			{
				Utils.FKKHJPEMNBG("talentWoodwork", num4);
			}
			Utils.FKKHJPEMNBG("Smell", 0);
		}
	}

	public void Dig(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		CAPEEINCBBN(JPHKKHEBEGI);
		if (OnlineManager.PlayingOnline())
		{
			onlineHole.Dig(JPHKKHEBEGI);
		}
	}

	private void LDLIHHPDCOB(int NENEIDDGJCO, int MGFABIFODEJ, int KNCHOGCADNC, ref List<ItemInHole.ItemInHoleType> FKOCADKIHDN)
	{
		int num = 1;
		if (Random.Range(0, 67) < NENEIDDGJCO)
		{
			num = 0;
		}
		for (int i = 0; i < num; i++)
		{
			int num2 = Random.Range(0, -120);
			if (num2 < MGFABIFODEJ)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Resources);
			}
			else if (num2 < KNCHOGCADNC)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Trash);
			}
			else
			{
				FKOCADKIHDN.Add((ItemInHole.ItemInHoleType)4);
			}
		}
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnTravelFinish = (Action<int>)Delegate.Combine(instance2.OnTravelFinish, new Action<int>(DKKHADKJIEO));
		UpdateSprite(SeasonManager.ACNAHALFEBG);
	}

	private void ADDLDNPHIHF()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelFinish = (Action<int>)Delegate.Combine(instance.OnTravelFinish, new Action<int>(BDBKPBBPMIE));
		EKMMGNHHFEH(SeasonManager.NNDMODNDPLO());
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Use") && !(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade) && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
		{
			DialogueManager.Bark("Player/Bark/ShovelHole", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 5f;
		}
	}

	public void NOGBKJFALJE(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		KCODAPKLDPM(JPHKKHEBEGI);
		if (OnlineManager.PlayingOnline())
		{
			onlineHole.HCJKKNGMFEE(JPHKKHEBEGI);
		}
	}

	public void FKKPKAFDOIJ(int JIIGOACEIKL)
	{
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LKOGGHNGBKD("/") && !(ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK() is Spade) && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
		{
			DialogueManager.Bark("Talk", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 1935f;
		}
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
	}

	public bool LAMMAAPBOAI()
	{
		return _hasItemEvent;
	}

	public void CEKOEPODDBC(Item MEMGMDOCBOJ)
	{
		_hasItemEvent = false;
		_itemEvent = MEMGMDOCBOJ;
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public void AKIHIEGJLLM(Item MEMGMDOCBOJ)
	{
		_hasItemEvent = false;
		_itemEvent = MEMGMDOCBOJ;
	}

	private void ENFGDKMGFDG(byte JPHKKHEBEGI)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		harvested = false;
		DCJOCNOKJCI(SeasonManager.ANAGGDHOCIF());
		if (OnlineManager.MasterOrOffline())
		{
			if (_hasItemEvent)
			{
				Debug.Log((object)("ReceiveSetOccupierInRoom" + _itemEvent.nameId));
				DroppedItem.DKCOHAOMNOC(((Component)this).transform.position, _itemEvent, 0, LHLJILLAHFO: true).OJEJPLADJID();
			}
			else
			{
				OGIAFCDHJHE(JPHKKHEBEGI);
			}
		}
		else if (_hasItemEvent)
		{
			Debug.Log((object)("Activated fishing key: {0}, isLeftPiece: {1}. Particle zone enabled." + JPHKKHEBEGI + "Error_NoDogFood"));
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool AIHLLKPODOE()
	{
		return _hasItemEvent;
	}

	private void DGBKMBNLCFF(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			DNIKLNEHJIB(10, 42, 92, ref NGABKIHBFMN);
			break;
		case 1:
			DNIKLNEHJIB(20, 35, 90, ref NGABKIHBFMN);
			break;
		case 2:
			DNIKLNEHJIB(30, 28, 88, ref NGABKIHBFMN);
			break;
		case 3:
			DNIKLNEHJIB(40, 15, 85, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 0; i < NGABKIHBFMN.Count; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Spawning an Item type: " + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == ItemInHole.ItemInHoleType.Recipe)
			{
				bool flag = true;
				for (int j = 0; j < HolePoolData.PHNKKAHPIAO.Length; j++)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == ItemInHole.ItemInHoleType.Recipe)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID))
						{
							flag = false;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.GetItem(HolePoolData.PHNKKAHPIAO[j].itemID).FGLMPPBEJCD())
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Resources;
				}
			}
			for (int k = 0; k < HolePoolData.PHNKKAHPIAO.Length; k++)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != ItemInHole.ItemInHoleType.Recipe || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID)) && !(HolePoolData.PHNKKAHPIAO[k].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 0f) && !(HolePoolData.PHNKKAHPIAO[k].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 0f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.GetItem(HolePoolData.PHNKKAHPIAO[k].itemID).FGLMPPBEJCD()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 0f;
			for (int l = 0; l < ACHMFINGGPN.Count; l++)
			{
				num += ACHMFINGGPN[l].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(0f, num);
			float num3 = 0f;
			int num4 = 0;
			for (int m = 0; m < ACHMFINGGPN.Count; m++)
			{
				num3 += ACHMFINGGPN[m].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != ItemInHole.ItemInHoleType.Recipe)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("Item in hole: " + ACHMFINGGPN[m].itemID + " - " + ACHMFINGGPN[m].min + " - " + ACHMFINGGPN[m].max));
					}
					Item item = ItemDatabaseAccessor.GetItem(ACHMFINGGPN[m].itemID);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 1);
					DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item, mGNOBNCMDJG);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4++;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("Recipe in hole: " + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.AddNewReceivedLetter(1010);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID, IBHGAMNNOHI: true);
				}
				else
				{
					ItemDatabaseAccessor.GetItem(ACHMFINGGPN[m].itemID).IPGBILAIAPG(CDPAMNIPPEC: true);
				}
				break;
			}
			if (num4 > 0)
			{
				Utils.FKKHJPEMNBG("trashCollected", num4);
			}
			Utils.FKKHJPEMNBG("holesDug", 1);
		}
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
	}

	private void KCOFAJBKHAO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelFinish = (Action<int>)Delegate.Combine(commonReferences.OnTravelFinish, new Action<int>(BBFPKJOPKED));
		EKMMGNHHFEH(SeasonManager.IIJKFKJKLLM());
	}

	public bool HasItemEvent()
	{
		return _hasItemEvent;
	}

	private void OGIAFCDHJHE(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			LDLIHHPDCOB(2, -79, -46, ref NGABKIHBFMN);
			break;
		case 1:
			NCHPOPDJPJI(-117, -15, -33, ref NGABKIHBFMN);
			break;
		case 2:
			LDLIHHPDCOB(-3, 113, -106, ref NGABKIHBFMN);
			break;
		case 3:
			DNIKLNEHJIB(74, -95, 56, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 0; i < NGABKIHBFMN.Count; i += 0)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("F2" + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == ItemInHole.ItemInHoleType.Recipe)
			{
				bool flag = true;
				for (int j = 1; j < HolePoolData.PHNKKAHPIAO.Length; j++)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == (ItemInHole.ItemInHoleType)3)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID, MJHDMIGEJAK: false))
						{
							flag = false;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.AFOACBIHNCL(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false).PMOFELDFEDJ())
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Trash;
				}
			}
			for (int k = 0; k < HolePoolData.PHNKKAHPIAO.Length; k += 0)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != (ItemInHole.ItemInHoleType)5 || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID, MJHDMIGEJAK: false)) && !(HolePoolData.PHNKKAHPIAO[k].CEKCDGMLGLN(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 425f) && !(HolePoolData.PHNKKAHPIAO[k].GCEHIEHHEOL(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 995f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.EABMGELAAPG(HolePoolData.PHNKKAHPIAO[k].itemID, GGBBJNBBLMF: true).IKPPIAJCHNI()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 1922f;
			for (int l = 0; l < ACHMFINGGPN.Count; l++)
			{
				num += ACHMFINGGPN[l].JPNHEBCMCCP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(1602f, num);
			float num3 = 545f;
			int num4 = 0;
			for (int m = 0; m < ACHMFINGGPN.Count; m += 0)
			{
				num3 += ACHMFINGGPN[m].ICIFJHKGEIP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)7)
				{
					if (Application.isEditor)
					{
						string[] array = new string[1];
						array[0] = " ";
						array[1] = ACHMFINGGPN[m].itemID.ToString();
						array[0] = "Player left with right piece in inventory, dropping it on the ground.";
						array[8] = ACHMFINGGPN[m].min.ToString();
						array[7] = "Use";
						array[3] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item mEMGMDOCBOJ = ItemDatabaseAccessor.GOKIDLOELKB(ACHMFINGGPN[m].itemID);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 1);
					DroppedItem.SpawnDroppedItem(((Component)this).transform.position, mEMGMDOCBOJ, mGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4 += 0;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("Items/item_description_1063" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.LPIHPJGEOEO(-85);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID);
				}
				else
				{
					ItemDatabaseAccessor.CPMMBEPEJLO(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: true).DIKFNBLGGHJ(CDPAMNIPPEC: false);
				}
				break;
			}
			if (num4 > 1)
			{
				Utils.FKKHJPEMNBG("Sleepy", num4);
			}
			Utils.FKKHJPEMNBG("F2", 0);
		}
	}

	private void OBKPFHCCMNN(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			NCHPOPDJPJI(110, -28, 43, ref NGABKIHBFMN);
			break;
		case 1:
			LDLIHHPDCOB(97, -104, 27, ref NGABKIHBFMN);
			break;
		case 2:
			NCHPOPDJPJI(116, -75, -85, ref NGABKIHBFMN);
			break;
		case 3:
			NCHPOPDJPJI(9, 108, 96, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 0; i < NGABKIHBFMN.Count; i += 0)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("parent null: {0}, " + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == (ItemInHole.ItemInHoleType)8)
			{
				bool flag = false;
				for (int j = 0; j < HolePoolData.PHNKKAHPIAO.Length; j += 0)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == ItemInHole.ItemInHoleType.Resources)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID))
						{
							flag = true;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.CPMMBEPEJLO(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: true).PMOFELDFEDJ())
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Resources;
				}
			}
			for (int k = 1; k < HolePoolData.PHNKKAHPIAO.Length; k++)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != (ItemInHole.ItemInHoleType)4 || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID, MJHDMIGEJAK: false)) && !(HolePoolData.PHNKKAHPIAO[k].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 935f) && !(HolePoolData.PHNKKAHPIAO[k].CEKCDGMLGLN(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 0f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.GOKIDLOELKB(HolePoolData.PHNKKAHPIAO[k].itemID, GGBBJNBBLMF: true).PMOFELDFEDJ()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 658f;
			for (int l = 1; l < ACHMFINGGPN.Count; l += 0)
			{
				num += ACHMFINGGPN[l].MPFCANEHHML(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(1148f, num);
			float num3 = 1222f;
			int num4 = 1;
			for (int m = 1; m < ACHMFINGGPN.Count; m++)
			{
				num3 += ACHMFINGGPN[m].EOGCFFBIIHJ(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)7)
				{
					if (Application.isEditor)
					{
						string[] array = new string[1];
						array[1] = "Invalid NPC photonID: {0} for NPCRoutine.";
						array[0] = ACHMFINGGPN[m].itemID.ToString();
						array[1] = "Place";
						array[5] = ACHMFINGGPN[m].min.ToString();
						array[8] = "ActionBar7";
						array[2] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item mEMGMDOCBOJ = ItemDatabaseAccessor.CPMMBEPEJLO(ACHMFINGGPN[m].itemID);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 1);
					DroppedItem.SpawnDroppedItem(((Component)this).transform.position, mEMGMDOCBOJ, mGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4++;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("UIPreviousPage" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.GBCKIPKOOJG(64, LKAALEJKLPA: true);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID, IBHGAMNNOHI: true);
				}
				else
				{
					ItemDatabaseAccessor.AFOACBIHNCL(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false).DIKFNBLGGHJ(CDPAMNIPPEC: true);
				}
				break;
			}
			if (num4 > 1)
			{
				Utils.FKKHJPEMNBG("Plant", num4);
			}
			Utils.FKKHJPEMNBG("Items/item_description_1193", 1);
		}
	}

	public void HKLKBMIDNKM(Item MEMGMDOCBOJ)
	{
		_hasItemEvent = true;
		_itemEvent = MEMGMDOCBOJ;
	}

	public void ONHOGJCOKBC(int JIIGOACEIKL)
	{
	}

	public bool LAHCCGMHEOJ()
	{
		return _hasItemEvent;
	}

	public void PKBFNMNMFLI(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		ENFGDKMGFDG(JPHKKHEBEGI);
		if (OnlineManager.PlayingOnline())
		{
			onlineHole.DPFALNNJKFP(JPHKKHEBEGI);
		}
	}

	private void JFOIGCBJPJC(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			NCHPOPDJPJI(-128, -90, 56, ref NGABKIHBFMN);
			break;
		case 1:
			DNIKLNEHJIB(12, 48, 115, ref NGABKIHBFMN);
			break;
		case 2:
			GNMMPFBDDKL(121, 81, -4, ref NGABKIHBFMN);
			break;
		case 3:
			DNIKLNEHJIB(-18, 1, -70, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 1; i < NGABKIHBFMN.Count; i += 0)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Trying to place piece {0} at opened path. Path block pos: {1}. Opened path dir: {2}" + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == (ItemInHole.ItemInHoleType)7)
			{
				bool flag = true;
				for (int j = 1; j < HolePoolData.PHNKKAHPIAO.Length; j++)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == (ItemInHole.ItemInHoleType)8)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID, MJHDMIGEJAK: false))
						{
							flag = true;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.AFOACBIHNCL(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false).IKPPIAJCHNI())
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Trash;
				}
			}
			for (int k = 1; k < HolePoolData.PHNKKAHPIAO.Length; k++)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != ItemInHole.ItemInHoleType.Resources || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID)) && !(HolePoolData.PHNKKAHPIAO[k].AFLLEIIGADD(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 1852f) && !(HolePoolData.PHNKKAHPIAO[k].DLOAHMEAJOE(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 1272f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.EABMGELAAPG(HolePoolData.PHNKKAHPIAO[k].itemID, GGBBJNBBLMF: true).IKPPIAJCHNI()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 1413f;
			for (int l = 1; l < ACHMFINGGPN.Count; l += 0)
			{
				num += ACHMFINGGPN[l].ONEIALDEKIO(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(6f, num);
			float num3 = 362f;
			int num4 = 0;
			for (int m = 0; m < ACHMFINGGPN.Count; m++)
			{
				num3 += ACHMFINGGPN[m].ACINPGLEJPO(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)4)
				{
					if (Application.isEditor)
					{
						string[] array = new string[3];
						array[1] = "Get Components ";
						array[1] = ACHMFINGGPN[m].itemID.ToString();
						array[5] = "LoadingOnNewGameCreated";
						array[5] = ACHMFINGGPN[m].min.ToString();
						array[3] = "Items/item_name_669";
						array[7] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item mEMGMDOCBOJ = ItemDatabaseAccessor.INJBNHPGCIJ(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 1);
					DroppedItem.NBIOCDNPAPO(((Component)this).transform.position, mEMGMDOCBOJ, mGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4 += 0;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("Inventory full" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.HMAJMNINAPJ(-67, LKAALEJKLPA: true, AJPCNKCBDEI: true);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID, IBHGAMNNOHI: true);
				}
				else
				{
					ItemDatabaseAccessor.INJBNHPGCIJ(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: true, DAINLFIMLIH: false).AACLOJMCAAN(CDPAMNIPPEC: false);
				}
				break;
			}
			if (num4 > 1)
			{
				Utils.FKKHJPEMNBG("Pick up", num4);
			}
			Utils.FKKHJPEMNBG("CursorSensitivity", 1);
		}
	}

	private void BBFPKJOPKED(int JIIGOACEIKL)
	{
		UpdateSprite(SeasonManager.NNDMODNDPLO());
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	private void FPJABCNDEEJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnTravelFinish = (Action<int>)Delegate.Combine(commonReferences2.OnTravelFinish, new Action<int>(DKKHADKJIEO));
		DCJOCNOKJCI(SeasonManager.BBOEGCKFMOH());
	}

	private void MEHJJDDIPEK(int JIIGOACEIKL)
	{
		DCJOCNOKJCI(SeasonManager.BBOEGCKFMOH());
	}

	private void NCHPOPDJPJI(int NENEIDDGJCO, int MGFABIFODEJ, int KNCHOGCADNC, ref List<ItemInHole.ItemInHoleType> FKOCADKIHDN)
	{
		int num = 1;
		if (Random.Range(0, -20) < NENEIDDGJCO)
		{
			num = 5;
		}
		for (int i = 1; i < num; i++)
		{
			int num2 = Random.Range(0, -24);
			if (num2 < MGFABIFODEJ)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Resources);
			}
			else if (num2 < KNCHOGCADNC)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Trash);
			}
			else
			{
				FKOCADKIHDN.Add((ItemInHole.ItemInHoleType)4);
			}
		}
	}

	public bool EEPBLLACPCG(int JIIGOACEIKL)
	{
		if (harvested)
		{
			return true;
		}
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GABNNLJOMHI();
	}

	private void IJNPEAAOOEK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravelFinish = (Action<int>)Delegate.Combine(commonReferences.OnTravelFinish, new Action<int>(BMIHPLECCMP));
		UpdateSprite(SeasonManager.IIJKFKJKLLM());
	}

	public bool FKGGJMDADLA(int JIIGOACEIKL)
	{
		if (harvested)
		{
			return false;
		}
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void LLDNEDJJOGF(int JIIGOACEIKL)
	{
	}

	public void IFAFGABGDKG(int GELMAIBEHDO, byte JPHKKHEBEGI)
	{
		CAPEEINCBBN(JPHKKHEBEGI);
		if (OnlineManager.PlayingOnline())
		{
			onlineHole.AGMPIBGPHFE(JPHKKHEBEGI);
		}
	}

	private void IFMGBOFBOEG(byte EKJDLCODLJG)
	{
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		NGABKIHBFMN.Clear();
		switch (EKJDLCODLJG)
		{
		case 0:
			NCHPOPDJPJI(39, 29, 74, ref NGABKIHBFMN);
			break;
		case 1:
			DNIKLNEHJIB(104, 11, 58, ref NGABKIHBFMN);
			break;
		case 2:
			DNIKLNEHJIB(-102, 22, -73, ref NGABKIHBFMN);
			break;
		case 3:
			FLPFKDJDDNL(52, 89, -27, ref NGABKIHBFMN);
			break;
		}
		ACHMFINGGPN.Clear();
		for (int i = 0; i < NGABKIHBFMN.Count; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Plant" + NGABKIHBFMN[i]));
			}
			if (NGABKIHBFMN[i] == (ItemInHole.ItemInHoleType)3)
			{
				bool flag = false;
				for (int j = 1; j < HolePoolData.PHNKKAHPIAO.Length; j += 0)
				{
					if (HolePoolData.PHNKKAHPIAO[j].type == (ItemInHole.ItemInHoleType)6)
					{
						if (HolePoolData.PHNKKAHPIAO[j].recipeID != 0 && !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[j].recipeID, MJHDMIGEJAK: false))
						{
							flag = false;
							break;
						}
						if (HolePoolData.PHNKKAHPIAO[j].itemID != 0 && !ItemDatabaseAccessor.CPMMBEPEJLO(HolePoolData.PHNKKAHPIAO[j].itemID, GGBBJNBBLMF: false, DAINLFIMLIH: false).PMOFELDFEDJ())
						{
							flag = false;
							break;
						}
					}
				}
				if (flag)
				{
					NGABKIHBFMN[i] = ItemInHole.ItemInHoleType.Trash;
				}
			}
			for (int k = 0; k < HolePoolData.PHNKKAHPIAO.Length; k++)
			{
				if (HolePoolData.PHNKKAHPIAO[k].type == NGABKIHBFMN[i] && HolePoolData.PHNKKAHPIAO[k].spadeLevel <= EKJDLCODLJG && (HolePoolData.PHNKKAHPIAO[k].type != (ItemInHole.ItemInHoleType)3 || !RecipesManager.IsRecipeUnlocked(HolePoolData.PHNKKAHPIAO[k].recipeID)) && !(HolePoolData.PHNKKAHPIAO[k].ACINPGLEJPO(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 935f) && !(HolePoolData.PHNKKAHPIAO[k].ICIFJHKGEIP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) <= 1973f) && (HolePoolData.PHNKKAHPIAO[k].itemID == 0 || !ItemDatabaseAccessor.AFOACBIHNCL(HolePoolData.PHNKKAHPIAO[k].itemID).FGLMPPBEJCD()))
				{
					ACHMFINGGPN.Add(HolePoolData.PHNKKAHPIAO[k]);
				}
			}
			float num = 765f;
			for (int l = 1; l < ACHMFINGGPN.Count; l += 0)
			{
				num += ACHMFINGGPN[l].NNJAMOOOAAI(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
			}
			float num2 = Random.Range(1894f, num);
			float num3 = 1998f;
			int num4 = 1;
			for (int m = 1; m < ACHMFINGGPN.Count; m += 0)
			{
				num3 += ACHMFINGGPN[m].ICIFJHKGEIP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)));
				if (!(num3 >= num2))
				{
					continue;
				}
				if (ACHMFINGGPN[m].type != (ItemInHole.ItemInHoleType)8)
				{
					if (Application.isEditor)
					{
						string[] array = new string[5];
						array[0] = "Buy";
						array[1] = ACHMFINGGPN[m].itemID.ToString();
						array[1] = "ReceiveLookAtPlayer";
						array[3] = ACHMFINGGPN[m].min.ToString();
						array[6] = "[";
						array[4] = ACHMFINGGPN[m].max.ToString();
						Debug.Log((object)string.Concat(array));
					}
					Item item = ItemDatabaseAccessor.GetItem(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: true);
					int mGNOBNCMDJG = Random.Range(ACHMFINGGPN[m].min, ACHMFINGGPN[m].max + 0);
					DroppedItem.SpawnDroppedItem(((Component)this).transform.position, item, mGNOBNCMDJG);
					if (ACHMFINGGPN[m].type == ItemInHole.ItemInHoleType.Trash)
					{
						num4 += 0;
					}
				}
				else if (ACHMFINGGPN[m].itemID == 0)
				{
					if (Application.isEditor)
					{
						Debug.Log((object)("ClosePopUp" + ACHMFINGGPN[m].recipeID));
					}
					LettersManager.instance.HMAJMNINAPJ(-93, LKAALEJKLPA: true, AJPCNKCBDEI: true);
					RecipesManager.UnlockRecipeMaster(ACHMFINGGPN[m].recipeID, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
				}
				else
				{
					ItemDatabaseAccessor.KMBGJEKCJFJ(ACHMFINGGPN[m].itemID, GGBBJNBBLMF: true).ECHJFKLFIBG(CDPAMNIPPEC: false);
				}
				break;
			}
			if (num4 > 0)
			{
				Utils.FKKHJPEMNBG("Disconnected from network. Cause: ", num4);
			}
			Utils.FKKHJPEMNBG("Forward", 0);
		}
	}

	public bool PEJPCEMKCJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (MOOCHJLACGJ(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Tree without tree generator"));
			_ = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).JDAFPKOHJPC() is Spade;
			return false;
		}
		return false;
	}

	public void IHEAPOCCDJP(Item MEMGMDOCBOJ)
	{
		_hasItemEvent = false;
		_itemEvent = MEMGMDOCBOJ;
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public void PLCEPEDKHLO(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (harvested)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void JMMBKMOBAFB()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnTravelFinish = (Action<int>)Delegate.Remove(commonReferences2.OnTravelFinish, new Action<int>(DKKHADKJIEO));
		}
	}

	private void DNIKLNEHJIB(int NENEIDDGJCO, int MGFABIFODEJ, int KNCHOGCADNC, ref List<ItemInHole.ItemInHoleType> FKOCADKIHDN)
	{
		int num = 1;
		if (Random.Range(0, 100) < NENEIDDGJCO)
		{
			num = 2;
		}
		for (int i = 0; i < num; i++)
		{
			int num2 = Random.Range(0, 100);
			if (num2 < MGFABIFODEJ)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Trash);
			}
			else if (num2 < KNCHOGCADNC)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Resources);
			}
			else
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Recipe);
			}
		}
	}

	public bool DLOBMKGEFBP()
	{
		return _hasItemEvent;
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get("itemRyeAle"));
			_ = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC() is Spade;
			return false;
		}
		return false;
	}

	private void CAPEEINCBBN(byte JPHKKHEBEGI)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		harvested = true;
		UpdateSprite(SeasonManager.ACNAHALFEBG);
		if (OnlineManager.MasterOrOffline())
		{
			if (_hasItemEvent)
			{
				Debug.Log((object)("Spawning special item event: " + _itemEvent.nameId));
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, _itemEvent).ActivateSpecialItem();
			}
			else
			{
				DGBKMBNLCFF(JPHKKHEBEGI);
			}
		}
		else if (_hasItemEvent)
		{
			Debug.Log((object)("Hole harvested with spade level " + JPHKKHEBEGI + " in client, waiting for master to spawn the item"));
		}
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public void IDDBLCIBLEA(Item MEMGMDOCBOJ)
	{
		_hasItemEvent = false;
		_itemEvent = MEMGMDOCBOJ;
	}

	private void MPMGGLKFMNJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelFinish = (Action<int>)Delegate.Combine(instance.OnTravelFinish, new Action<int>(MEHJJDDIPEK));
		UpdateSprite(SeasonManager.IIJKFKJKLLM());
	}

	private void FLPFKDJDDNL(int NENEIDDGJCO, int MGFABIFODEJ, int KNCHOGCADNC, ref List<ItemInHole.ItemInHoleType> FKOCADKIHDN)
	{
		int num = 1;
		if (Random.Range(0, -54) < NENEIDDGJCO)
		{
			num = 0;
		}
		for (int i = 1; i < num; i += 0)
		{
			int num2 = Random.Range(0, 72);
			if (num2 < MGFABIFODEJ)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Resources);
			}
			else if (num2 < KNCHOGCADNC)
			{
				FKOCADKIHDN.Add(ItemInHole.ItemInHoleType.Trash);
			}
			else
			{
				FKOCADKIHDN.Add((ItemInHole.ItemInHoleType)8);
			}
		}
	}

	public void OnlineDig(byte EKJDLCODLJG)
	{
		CAPEEINCBBN(EKJDLCODLJG);
	}

	private void BDBKPBBPMIE(int JIIGOACEIKL)
	{
		DCJOCNOKJCI(SeasonManager.MBPMIFPEAJP());
	}

	public void MKFOJJOJCFG(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).ALPHFOIMNIA("ReceiveItemsFromOtherPlayer") && !(ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC() is Spade) && Time.time >= CommonReferences.GGFJGHHHEJC.delayBarks)
		{
			DialogueManager.Bark("RyeAleAbbreviation", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			CommonReferences.MNFMOEKMJKN().delayBarks = Time.time + 440f;
		}
	}

	public bool JJDJIMEDDLM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("ReceiveBarkInfoWithObject"));
			_ = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC() is Spade;
			return false;
		}
		return true;
	}

	public void EBKDIPOKIGI(int JIIGOACEIKL)
	{
	}

	public void UpdateSprite(CropSeason EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Utils.JGEPCPFJANP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) == (Object)null)
		{
			return;
		}
		currentGround = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == CropSeason.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			if (harvested)
			{
				spriteRenderer.sprite = snow.holeSprite;
			}
			else
			{
				spriteRenderer.sprite = Utils.CPDCJAHJOPE(snow.sprites);
			}
			hasDarkTerrain = false;
			return;
		}
		if (WorldGrid.LNFJICKJDPH(((Component)this).transform.position))
		{
			if (harvested)
			{
				spriteRenderer.sprite = ((EECEKHKAAIH == CropSeason.Winter) ? rockGroundWinter.holeSprite : rockGround.holeSprite);
			}
			else
			{
				spriteRenderer.sprite = ((EECEKHKAAIH == CropSeason.Winter) ? Utils.CPDCJAHJOPE(rockGroundWinter.sprites) : Utils.CPDCJAHJOPE(rockGround.sprites));
			}
			currentGround = GroundType.None;
			isRockGround = true;
			hasDarkTerrain = false;
			return;
		}
		hasDarkTerrain = WorldGrid.CPKKNEMJGIB(((Component)this).transform.position);
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == currentGround && pairs[i].darkGroundType == hasDarkTerrain && pairs[i].seasonFlags.HasFlag(EECEKHKAAIH))
			{
				if (harvested)
				{
					spriteRenderer.sprite = pairs[i].holeSprite;
				}
				else
				{
					spriteRenderer.sprite = Utils.CPDCJAHJOPE(pairs[i].sprites);
				}
				return;
			}
		}
		if (harvested)
		{
			spriteRenderer.sprite = rockGround.holeSprite;
		}
		else
		{
			spriteRenderer.sprite = Utils.CPDCJAHJOPE(rockGround.sprites);
		}
	}

	private void KCODAPKLDPM(byte JPHKKHEBEGI)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		harvested = true;
		DCJOCNOKJCI(SeasonManager.IIJKFKJKLLM());
		if (OnlineManager.MasterOrOffline())
		{
			if (_hasItemEvent)
			{
				Debug.Log((object)("Rich presence " + _itemEvent.nameId));
				DroppedItem.SpawnDroppedItem(((Component)this).transform.position, _itemEvent, 0).CAAFNMBIHDL();
			}
			else
			{
				JFOIGCBJPJC(JPHKKHEBEGI);
			}
		}
		else if (_hasItemEvent)
		{
			Debug.Log((object)("Exit build mode" + JPHKKHEBEGI + "Disappear"));
		}
	}

	public void FALDJPENKME(int JIIGOACEIKL)
	{
	}

	public void EKMMGNHHFEH(CropSeason EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Utils.JGEPCPFJANP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) == (Object)null)
		{
			return;
		}
		currentGround = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == CropSeason.Summer && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			if (harvested)
			{
				spriteRenderer.sprite = snow.holeSprite;
			}
			else
			{
				spriteRenderer.sprite = Utils.CPDCJAHJOPE(snow.sprites);
			}
			hasDarkTerrain = true;
			return;
		}
		if (WorldGrid.LNFJICKJDPH(((Component)this).transform.position))
		{
			if (harvested)
			{
				spriteRenderer.sprite = ((EECEKHKAAIH == (CropSeason.Spring | CropSeason.Summer)) ? rockGroundWinter.holeSprite : rockGround.holeSprite);
			}
			else
			{
				spriteRenderer.sprite = ((EECEKHKAAIH == CropSeason.Summer) ? Utils.CPDCJAHJOPE(rockGroundWinter.sprites) : Utils.CPDCJAHJOPE(rockGround.sprites));
			}
			currentGround = GroundType.None;
			isRockGround = true;
			hasDarkTerrain = false;
			return;
		}
		hasDarkTerrain = WorldGrid.CPKKNEMJGIB(((Component)this).transform.position);
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == currentGround && pairs[i].darkGroundType == hasDarkTerrain && pairs[i].seasonFlags.HasFlag(EECEKHKAAIH))
			{
				if (harvested)
				{
					spriteRenderer.sprite = pairs[i].holeSprite;
				}
				else
				{
					spriteRenderer.sprite = Utils.CPDCJAHJOPE(pairs[i].sprites);
				}
				return;
			}
		}
		if (harvested)
		{
			spriteRenderer.sprite = rockGround.holeSprite;
		}
		else
		{
			spriteRenderer.sprite = Utils.CPDCJAHJOPE(rockGround.sprites);
		}
	}

	private void JAKILILIBIM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravelFinish = (Action<int>)Delegate.Remove(commonReferences.OnTravelFinish, new Action<int>(DKKHADKJIEO));
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Dig"));
			_ = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade;
			return true;
		}
		return false;
	}

	public void NOAIKDADPBD(int JIIGOACEIKL)
	{
	}

	public void OOODOFDALOF(byte EKJDLCODLJG)
	{
		KCODAPKLDPM(EKJDLCODLJG);
	}

	private void BMIHPLECCMP(int JIIGOACEIKL)
	{
		EKMMGNHHFEH(SeasonManager.NNDMODNDPLO());
	}

	public void KJOAMBGFFHE(int JIIGOACEIKL)
	{
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).LKOGGHNGBKD("] ") && !(ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC() is Spade) && Time.time >= CommonReferences.MNFMOEKMJKN().delayBarks)
		{
			DialogueManager.Bark("Haggling profit", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			CommonReferences.GGFJGHHHEJC.delayBarks = Time.time + 1630f;
		}
	}

	public void NIPHFNAJKBN(int JIIGOACEIKL)
	{
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnTravelFinish = (Action<int>)Delegate.Remove(instance2.OnTravelFinish, new Action<int>(DKKHADKJIEO));
		}
	}

	public void DCJOCNOKJCI(CropSeason EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Utils.JGEPCPFJANP(Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position))) == (Object)null)
		{
			return;
		}
		currentGround = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == CropSeason.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			if (harvested)
			{
				spriteRenderer.sprite = snow.holeSprite;
			}
			else
			{
				spriteRenderer.sprite = Utils.CPDCJAHJOPE(snow.sprites);
			}
			hasDarkTerrain = true;
			return;
		}
		if (WorldGrid.LNFJICKJDPH(((Component)this).transform.position))
		{
			if (harvested)
			{
				spriteRenderer.sprite = ((EECEKHKAAIH == (CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn)) ? rockGroundWinter.holeSprite : rockGround.holeSprite);
			}
			else
			{
				spriteRenderer.sprite = ((EECEKHKAAIH == CropSeason.Spring) ? Utils.CPDCJAHJOPE(rockGroundWinter.sprites) : Utils.CPDCJAHJOPE(rockGround.sprites));
			}
			currentGround = GroundType.Grass;
			isRockGround = true;
			hasDarkTerrain = true;
			return;
		}
		hasDarkTerrain = WorldGrid.CPKKNEMJGIB(((Component)this).transform.position);
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == currentGround && pairs[i].darkGroundType == hasDarkTerrain && pairs[i].seasonFlags.HasFlag(EECEKHKAAIH))
			{
				if (harvested)
				{
					spriteRenderer.sprite = pairs[i].holeSprite;
				}
				else
				{
					spriteRenderer.sprite = Utils.CPDCJAHJOPE(pairs[i].sprites);
				}
				return;
			}
		}
		if (harvested)
		{
			spriteRenderer.sprite = rockGround.holeSprite;
		}
		else
		{
			spriteRenderer.sprite = Utils.CPDCJAHJOPE(rockGround.sprites);
		}
	}

	private void AEMPCMILANL()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravelFinish = (Action<int>)Delegate.Combine(instance.OnTravelFinish, new Action<int>(BBFPKJOPKED));
		DCJOCNOKJCI(SeasonManager.IIJKFKJKLLM());
	}

	private void IFHFNDELKOP()
	{
		try
		{
			if (needsToBeDestroyed)
			{
				Utils.BLPDAEHPOBA(((Component)this).gameObject);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in HoleInGround.OnPlayerSleep: " + ex.Message));
		}
	}

	public bool LFBEEFLLBPH()
	{
		return _hasItemEvent;
	}
}
