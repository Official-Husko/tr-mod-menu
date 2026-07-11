using System;
using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class DestructibleObject : MonoBehaviour
{
	[Serializable]
	public class DroppedItems
	{
		public Item item;

		[HideInInspector]
		public int quantity;

		[HideInInspector]
		public int alreadyDropped;
	}

	[Serializable]
	public class DroppedItemsWithProbability : DroppedItems
	{
		[Range(0f, 100f)]
		public float probability = 100f;

		public int minNum;

		public int maxNum;
	}

	public DroppedItemsWithProbability[] droppedItems;

	private DroppedItems[] CDGNCDHAPKB;

	[SerializeField]
	[Header("Visual States")]
	private GameObject normalVisual;

	[SerializeField]
	private GameObject destroyedVisual;

	[SerializeField]
	private AudioObject destructionSound;

	[SerializeField]
	private OccupyNodesWithColliders occupyNodesWithColliders;

	public MinePiece pieceProbability;

	public bool _hasItemEvent;

	public Item _itemEvent;

	public OnlineDestructibleObject onlineDestructibleObject;

	public bool isDestroyed;

	private void GNOBDKFFPOL()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		BNJAHBDOIFC();
	}

	public void NKJBLKNGCPK(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.NCFDEOLIALM();
			}
		}
	}

	private void DIMAPDNCBAN()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(false);
		PLFEDMBDDED();
	}

	public void HHECIIPGCID(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			SetDestroyed(BOCMNPIGJHM: false);
			if (CDPAMNIPPEC)
			{
				JCDAKPMENHP(0);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.HKGFOENINAL();
			}
		}
	}

	private void JDHHJKBOJML()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(false);
		OOEPIDOKHGL();
	}

	private void EIHBGOFBHCB(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.EKMFELLJHFG(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount);
			if (_hasItemEvent)
			{
				droppedItem.CAAFNMBIHDL();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	public void MIEEMPABFJM(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.GPAJBAKJADO();
			}
		}
	}

	private void DPFDILFAMBM(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, null);
			if (list.Count > 1)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			if (_hasItemEvent)
			{
				droppedItem.CAAFNMBIHDL();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	public void DMDJJAHHAFJ(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.CheckAllNodes();
			}
		}
	}

	public void KFEKNFBEPPI(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)(" downloaded, written with name " + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void MDEHGIHFFJN()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1083f, 1386f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1857f;
				for (int i = 0; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1113f, num);
				float num3 = 1256f;
				for (int j = 0; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(517f, 1559f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void OKHLEMPJONN()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(true);
		IIDKJLKFDMC();
	}

	private void KOHNMNPINJJ()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1618f, 231f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1355f;
				for (int i = 1; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(369f, num);
				float num3 = 1839f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1882f, 778f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void GMCKBBECJOE()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		PLFEDMBDDED();
	}

	public void HDPNGJPOHJP(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.PDGBIKOLALJ();
			}
		}
	}

	private void IGHMMOKFINH()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(false);
		LGCLMEJMPNG();
	}

	public void EDFKCGHCPJJ(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			EOILOIPKNJB(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				PECFDHIKDHK(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.IIJGJAFMOAF();
			}
		}
	}

	private void IAAODGBCDCK()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(7f, 1441f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1596f;
				for (int i = 1; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1390f, num);
				float num3 = 207f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(1850f, 1336f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void IIDKJLKFDMC()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(462f, 1820f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 847f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1463f, num);
				float num3 = 899f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1037f, 57f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void MAMMEDALLHF(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, null);
			if (list.Count > 0)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.EKGNIODFJCO(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.CAAFNMBIHDL();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void GNAJBACLEKG()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		IMANIJHAEPK();
	}

	private void DNFFDAABGCC(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.EKMFELLJHFG(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void FIHEJNBFKLF(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, null);
			if (list.Count > 1)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.HABHKDOJMLE();
			}
			FFDIEOBBFKL--;
		}
	}

	private void IPDGEAMLAAF(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.NGIIPJDAMGP(_itemEvent, null))
			{
				Debug.Log((object)string.Format("LE_18", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				EKGBEBMDEIB(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					GCPNMLHKAHK(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void SetItemEvent(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("Setting item event for " + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void ANFFGMGODIK(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.CPABCHCKDEM();
			}
		}
	}

	private void OPCOGGHEOOB(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, null);
			if (list.Count > 0)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.EKMFELLJHFG(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void FGAEKHGGEBG(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.GBMFCPGEJDK(_itemEvent, null))
			{
				Debug.Log((object)string.Format("Items/item_description_1070", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				AMKFCDAKNGI(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					AMKFCDAKNGI(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void JDNFHJCGHLI(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("HumanDisappear" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = false;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void DJDLPLBJPMN(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.EKMFELLJHFG(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.CAAFNMBIHDL();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void BOMGBMMDICH(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKMFELLJHFG(_itemEvent, null))
			{
				Debug.Log((object)string.Format("MineState", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				KKPPBMLIDHK(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 0;
					KKPPBMLIDHK(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void MHIJILOJEEE(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.KDNBFFIPFFE();
			}
		}
	}

	private void GNIDOLNHGGL()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1947f, 425f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 407f;
				for (int i = 1; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(712f, num);
				float num3 = 289f;
				for (int j = 0; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1830f, 671f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	public void CDMLNDALPIE(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.OPPBPMBNNNI();
			}
		}
	}

	public void AEALGIGHFMB(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("Waiting for guest player to connect..." + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = false;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void OnMopHit(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			SetDestroyed(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				JCDAKPMENHP(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.SendMopHit();
			}
		}
	}

	public void AKAOEEKDKAG(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.GPAJBAKJADO();
			}
		}
	}

	public void EOILOIPKNJB(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.GPAJBAKJADO();
			}
		}
	}

	public void JGDIEOCOAAG(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("meatDishes" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = false;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void EKOMOPNFCPO(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			ANFFGMGODIK(BOCMNPIGJHM: false);
			if (CDPAMNIPPEC)
			{
				CKKCFHFDALJ(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.ANPIAENICLN();
			}
		}
	}

	private void NAMELOFMBAF(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKGNIODFJCO(_itemEvent, null))
			{
				Debug.Log((object)string.Format("Select", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				KKPPBMLIDHK(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					KKPPBMLIDHK(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void JDPNMGAADFK(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.MHEECOJKLPJ();
			}
		}
	}

	public void ANOCIHHMNNJ(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			HDPNGJPOHJP(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				MKEGNHLHNED(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.IIJGJAFMOAF();
			}
		}
	}

	private void FAAPAIBDCEE(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKGNIODFJCO(_itemEvent, null))
			{
				Debug.Log((object)string.Format("add item", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				NBBFHOIIFKM(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 0;
					BNJEAKIKOOH(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void CMJLHCNKFJK(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.LIEDDIBADHF();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void HMANFAEHJCA()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(false);
		BNJAHBDOIFC();
	}

	public void JBIENFEIGPH(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			NKJBLKNGCPK(BOCMNPIGJHM: false);
			if (CDPAMNIPPEC)
			{
				PECFDHIKDHK(0);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.MFLCNPOLEBG();
			}
		}
	}

	public void LIDCMMEPCPC(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("Tried to Initialize the SteamAPI twice in one session!" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void GPGIDFMNJMA(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("Crop without ID: " + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = false;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void GEHCBCGBBOD(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.MHEECOJKLPJ();
			}
		}
	}

	private void OOEPIDOKHGL()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(190f, 1981f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1175f;
				for (int i = 1; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1319f, num);
				float num3 = 175f;
				for (int j = 1; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(417f, 800f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void ALEAOANPHIO()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(false);
		MGKIJKGEJOH();
	}

	private void BNJAHBDOIFC()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1284f, 1046f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 339f;
				for (int i = 1; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1501f, num);
				float num3 = 762f;
				for (int j = 0; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(443f, 575f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void IMANIJHAEPK()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(203f, 1755f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1258f;
				for (int i = 0; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1850f, num);
				float num3 = 121f;
				for (int j = 1; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1916f, 1573f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void NLGHNDLPPKI()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		OOEPIDOKHGL();
	}

	private void BODICIENBEH()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		JFPKMDKJJGJ();
	}

	public void AEHJPMPPMIG(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			ABNLDPAGLKJ(BOCMNPIGJHM: false);
			if (CDPAMNIPPEC)
			{
				EKOABBEGHPO(0);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.GEKELCMDIEN();
			}
		}
	}

	private void BBLFGNGFAPF()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(327f, 24f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 330f;
				for (int i = 1; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(760f, num);
				float num3 = 1031f;
				for (int j = 1; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(422f, 1384f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void LGCLMEJMPNG()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(263f, 1491f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1286f;
				for (int i = 1; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(613f, num);
				float num3 = 1104f;
				for (int j = 1; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(633f, 618f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	public void MGNBPMOPIJK(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			GEHCBCGBBOD(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				NEAAMAAADJK(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.CEBMBHNJPOC();
			}
		}
	}

	public void HNILINMCKJM(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/35/Dialogue Text" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void EKOABBEGHPO(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKGNIODFJCO(_itemEvent, null))
			{
				Debug.Log((object)string.Format("Swap", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				NIELALKIJMA(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					EIHBGOFBHCB(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void BDCENLGCKJP(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.GPAJBAKJADO();
			}
		}
	}

	private void IBCANNHCMGI(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKMFELLJHFG(_itemEvent, null))
			{
				Debug.Log((object)string.Format(")", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				EFMHMOODKAI(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					EIHBGOFBHCB(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void HPDKMCFHMEL()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(519f, 473f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 866f;
				for (int i = 1; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(660f, num);
				float num3 = 1731f;
				for (int j = 1; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(634f, 1461f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void NIELALKIJMA(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, null);
			if (list.Count > 0)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL--;
		}
	}

	private void Awake()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(false);
		BJFDMJDJNLL();
	}

	public void EIIPICPHDAI(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.KFPIBONAIHE();
			}
		}
	}

	private void KKPPBMLIDHK(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
			if (list.Count > 0)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.EKMFELLJHFG(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.NBIOCDNPAPO(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.HABHKDOJMLE();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	public void PKLAHMOMFPM(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.KPIBCIBOGEB();
			}
		}
	}

	private void EMJKKALMGLK()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		JPPKFDHHOGM();
	}

	private void FAAMBICGAPM(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.NGIIPJDAMGP(_itemEvent, null))
			{
				Debug.Log((object)string.Format("Grab", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				KKPPBMLIDHK(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 0;
					AMKFCDAKNGI(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void MOHLILANGPC(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 0)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.EKMFELLJHFG(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount);
			if (_hasItemEvent)
			{
				droppedItem.LIEDDIBADHF();
			}
			FFDIEOBBFKL--;
		}
	}

	private void GOJKOBEEMNA()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(true);
		JFJNLOHKBCB();
	}

	public void KFFPHPHFEMP(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)(" (versionOfCropsAndRecipes)" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void JFJNLOHKBCB()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(72f, 1255f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1137f;
				for (int i = 1; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(838f, num);
				float num3 = 624f;
				for (int j = 1; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(1490f, 1476f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void GECHJIGBPEN()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(false);
		AGNIGANOHEN();
	}

	private void MKEGNHLHNED(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.GBMFCPGEJDK(_itemEvent, null))
			{
				Debug.Log((object)string.Format("CatOfFriend", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				AMIOPFPMIIG(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					CMJLHCNKFJK(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void FFLLCOBFIPE()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(true);
		KOHNMNPINJJ();
	}

	private void EHMNJCIFOCB(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.NGIIPJDAMGP(_itemEvent, null))
			{
				Debug.Log((object)string.Format("piratecave", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				OPCOGGHEOOB(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					EFMHMOODKAI(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void OMBHDODDHNO()
	{
		normalVisual.SetActive(false);
		destroyedVisual.SetActive(false);
		IAAODGBCDCK();
	}

	private void CKKCFHFDALJ(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKMFELLJHFG(_itemEvent, null))
			{
				Debug.Log((object)string.Format("NoEresDigno/EndEvent", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				GCPNMLHKAHK(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					MOHLILANGPC(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void BLKAEMBGOIM(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("UINextPage" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void FCMIALJFIEB(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.NGIIPJDAMGP(_itemEvent, null))
			{
				Debug.Log((object)string.Format("torchCount=[{0}-{1}], minConnections={2}", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				EFMHMOODKAI(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					MAMMEDALLHF(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void ABNLDPAGLKJ(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.KDNBFFIPFFE();
			}
		}
	}

	private void GCPNMLHKAHK(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL--;
		}
	}

	public void NANAMIGGAJM(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			BDCENLGCKJP(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				NAMELOFMBAF(0);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.FPLFMKAHGGP();
			}
		}
	}

	private void MHBNMCIHKLJ(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKMFELLJHFG(_itemEvent, null))
			{
				Debug.Log((object)string.Format("ReceiveBeginFishCuttingMinigame", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				EFMHMOODKAI(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					DPFDILFAMBM(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void HEOIJINPOLE(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.GBMFCPGEJDK(_itemEvent, null))
			{
				Debug.Log((object)string.Format("Trying to add a player that's already on the list.", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				DJDLPLBJPMN(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					KKPPBMLIDHK(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void EFBJIJCLDHL(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 0)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.EKGNIODFJCO(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void PHNJGHKBIIL()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		BBLFGNGFAPF();
	}

	public void EGPMGMAFOMM(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("CatSize" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = false;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void NBBFHOIIFKM(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, null);
			if (list.Count > 1)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL -= 0;
		}
	}

	private void JKGANGIAOBF(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKMFELLJHFG(_itemEvent, null))
			{
				Debug.Log((object)string.Format("<br>", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				EIHBGOFBHCB(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 0;
					DNFFDAABGCC(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void EFMHMOODKAI(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 1)
		{
			DroppedItem droppedItem = DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL--;
		}
	}

	private void PNLAJCHBHPH()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(false);
		MDEHGIHFFJN();
	}

	private void ONFABHLKEKA()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1830f, 838f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 525f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(48f, num);
				float num3 = 1095f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(775f, 1912f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	public void AJBCCLLJMKG(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			NKJBLKNGCPK(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				JKGANGIAOBF(0);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.HLJJEKJDGCC();
			}
		}
	}

	private void AMKFCDAKNGI(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, null);
			if (list.Count > 0)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL--;
		}
	}

	private void EKGBEBMDEIB(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.GBMFCPGEJDK(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.ActivateSpecialItem();
			}
			FFDIEOBBFKL--;
		}
	}

	public void SetDestroyed(bool BOCMNPIGJHM)
	{
		if (isDestroyed != BOCMNPIGJHM)
		{
			isDestroyed = BOCMNPIGJHM;
			normalVisual.SetActive(!BOCMNPIGJHM);
			destroyedVisual.SetActive(BOCMNPIGJHM);
			if (Object.op_Implicit((Object)(object)occupyNodesWithColliders))
			{
				occupyNodesWithColliders.CheckAllNodes();
			}
		}
	}

	private void HPPOGMMDLAB(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
			if (list.Count > 1)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.NGIIPJDAMGP(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount);
			if (_hasItemEvent)
			{
				droppedItem.CAAFNMBIHDL();
			}
			FFDIEOBBFKL--;
		}
	}

	public void HFDHGPBPFHH(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("BarnTutorialDone" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void AEOEOKPIHCN(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			MIEEMPABFJM(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				IPDGEAMLAAF(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.MFLCNPOLEBG();
			}
		}
	}

	private void AGNIGANOHEN()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(82f, 613f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 989f;
				for (int i = 0; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(781f, num);
				float num3 = 267f;
				for (int j = 0; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(1349f, 1415f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void ELPNEJAOLHJ()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(366f, 536f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 401f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1498f, num);
				float num3 = 1843f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1875f, 1297f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void BHAFCBHENPL()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(false);
		KOHNMNPINJJ();
	}

	public void KDKBFGGDONA(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			CDMLNDALPIE(BOCMNPIGJHM: true);
			if (CDPAMNIPPEC)
			{
				MHBNMCIHKLJ(0);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.JKEDODIKKAL();
			}
		}
	}

	private void LNPDALMANFB()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		ONFABHLKEKA();
	}

	private void AKBALEECILG()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1686f, 1915f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1587f;
				for (int i = 0; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1456f, num);
				float num3 = 847f;
				for (int j = 0; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 0);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(450f, 180f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void AMIOPFPMIIG(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.BEBJHEGMNOC(OBAHGHBFIGO: false, null, BMMBDCBJNAK: true);
			if (list.Count > 0)
			{
				item = list[Random.Range(0, list.Count)].item;
			}
		}
		if (Item.GBMFCPGEJDK(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.KBDEAPJKNED(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true);
			if (_hasItemEvent)
			{
				droppedItem.OJEJPLADJID();
			}
			FFDIEOBBFKL--;
		}
	}

	private void NPBBEJNMBFL()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1923f, 1446f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 482f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1924f, num);
				float num3 = 23f;
				for (int j = 1; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(205f, 76f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	public void NDKCOLFGCFF(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("TrayTrigger" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	public void FNLDECPKOOE(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("TavernFilthy" + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void JCDAKPMENHP(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.NGIIPJDAMGP(_itemEvent, null))
			{
				Debug.Log((object)$"Dropping item event {((Object)_itemEvent).name} for player {JIIGOACEIKL}");
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				AMKFCDAKNGI(mLKICMJELLC, 1);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					AMKFCDAKNGI(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void GCHJFIIOKLF(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.NGIIPJDAMGP(_itemEvent, null))
			{
				Debug.Log((object)string.Format("yForYears", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				NBBFHOIIFKM(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 1; i < CDGNCDHAPKB.Length; i += 0)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 1;
					DPFDILFAMBM(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	public void IHEDKNIMBBH(Item MEMGMDOCBOJ)
	{
		if (!_hasItemEvent)
		{
			Debug.Log((object)("Could not find shop with id: " + ((Object)MEMGMDOCBOJ).name));
			_hasItemEvent = true;
			_itemEvent = MEMGMDOCBOJ;
		}
	}

	private void NLNOFEBEBDE()
	{
		normalVisual.SetActive(true);
		destroyedVisual.SetActive(true);
		AGNIGANOHEN();
	}

	private void JFPKMDKJJGJ()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1938f, 1678f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 25f;
				for (int i = 1; i < droppedItems.Length; i += 0)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1926f, num);
				float num3 = 601f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1515f, 934f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	public void KBHGBOGMPDC(bool CDPAMNIPPEC = true)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (!isDestroyed)
		{
			BDCENLGCKJP(BOCMNPIGJHM: false);
			if (CDPAMNIPPEC)
			{
				FGAEKHGGEBG(1);
			}
			if ((Object)(object)destructionSound != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(destructionSound, ((Component)this).transform.position);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline() && Object.op_Implicit((Object)(object)onlineDestructibleObject))
			{
				onlineDestructibleObject.OOOGLMCCPIH();
			}
		}
	}

	private void JPPKFDHHOGM()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(1590f, 247f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1688f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1862f, num);
				float num3 = 358f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[1].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1153f, 152f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void NEAAMAAADJK(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKGNIODFJCO(_itemEvent, null))
			{
				Debug.Log((object)string.Format("ConnectionTimeout", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 1;
				EFBJIJCLDHL(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 0;
					NIELALKIJMA(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void PECFDHIKDHK(int JIIGOACEIKL)
	{
		if (_hasItemEvent)
		{
			if (!Item.EKMFELLJHFG(_itemEvent, null))
			{
				Debug.Log((object)string.Format("SecondAction", ((Object)_itemEvent).name, JIIGOACEIKL));
				ItemAmount mLKICMJELLC = default(ItemAmount);
				mLKICMJELLC.item = _itemEvent;
				mLKICMJELLC.amount = 0;
				DJDLPLBJPMN(mLKICMJELLC, 0);
			}
		}
		else
		{
			if (CDGNCDHAPKB == null || CDGNCDHAPKB.Length == 0)
			{
				return;
			}
			ItemAmount mLKICMJELLC2 = default(ItemAmount);
			for (int i = 0; i < CDGNCDHAPKB.Length; i++)
			{
				if (CDGNCDHAPKB[i] != null)
				{
					mLKICMJELLC2.item = CDGNCDHAPKB[i].item;
					mLKICMJELLC2.amount = 0;
					EIHBGOFBHCB(mLKICMJELLC2, CDGNCDHAPKB[i].quantity);
				}
			}
		}
	}

	private void PLFEDMBDDED()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(37f, 150f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 1548f;
				for (int i = 1; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(24f, num);
				float num3 = 492f;
				for (int j = 1; j < droppedItems.Length; j += 0)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[1] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(1696f, 446f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void BJFDMJDJNLL()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(0f, 100f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 0f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(0f, num);
				float num3 = 0f;
				for (int j = 0; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[1];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[0].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 0; k < droppedItems.Length; k++)
			{
				if (!(Random.Range(0f, 100f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 1);
				}
			}
		}
		_hasItemEvent = false;
		_itemEvent = null;
	}

	private void MGKIJKGEJOH()
	{
		if (droppedItems == null || droppedItems.Length == 0)
		{
			return;
		}
		if ((Object)(object)pieceProbability != (Object)null)
		{
			if (Random.Range(923f, 1271f) > pieceProbability.destructibleObjectsProbability)
			{
				float num = 657f;
				for (int i = 0; i < droppedItems.Length; i++)
				{
					num += droppedItems[i].probability;
				}
				float num2 = Random.Range(1670f, num);
				float num3 = 682f;
				for (int j = 1; j < droppedItems.Length; j++)
				{
					num3 += droppedItems[j].probability;
					if (num2 < num3)
					{
						CDGNCDHAPKB = new DroppedItems[0];
						CDGNCDHAPKB[0] = new DroppedItems();
						CDGNCDHAPKB[0].item = droppedItems[j].item;
						CDGNCDHAPKB[1].quantity = Random.Range(droppedItems[j].minNum, droppedItems[j].maxNum + 1);
						break;
					}
				}
			}
		}
		else
		{
			CDGNCDHAPKB = new DroppedItems[droppedItems.Length];
			for (int k = 1; k < droppedItems.Length; k += 0)
			{
				if (!(Random.Range(775f, 1141f) > droppedItems[k].probability))
				{
					CDGNCDHAPKB[k] = new DroppedItems();
					CDGNCDHAPKB[k].item = droppedItems[k].item;
					CDGNCDHAPKB[k].quantity = Random.Range(droppedItems[k].minNum, droppedItems[k].maxNum + 0);
				}
			}
		}
		_hasItemEvent = true;
		_itemEvent = null;
	}

	private void BNJEAKIKOOH(ItemAmount MLKICMJELLC, int FFDIEOBBFKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Item item = null;
		if (MLKICMJELLC.item is IngredientGroup ingredientGroup)
		{
			List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, null);
			if (list.Count > 0)
			{
				item = list[Random.Range(1, list.Count)].item;
			}
		}
		if (Item.EKGNIODFJCO(item, null))
		{
			item = MLKICMJELLC.item;
		}
		while (FFDIEOBBFKL > 0)
		{
			DroppedItem droppedItem = DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, item, MLKICMJELLC.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			if (_hasItemEvent)
			{
				droppedItem.OJEJPLADJID();
			}
			FFDIEOBBFKL--;
		}
	}
}
