using System;
using AlmenaraGames;
using UnityEngine;

public class Harvestable : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[Serializable]
	public struct HarvestedItemProb
	{
		public ItemAmount itemAmount;

		public int probability;
	}

	public ItemAmount[] harvestedItems;

	public HarvestedItemProb[] harvestedItemsProb;

	public CropSetter cropSetter;

	public Herb herb;

	public GameObject harvestEffect;

	public GameObject winterHarvestEffect;

	public GameObject summerHarvestEffect;

	public GameObject autumnHarvestEffect;

	public bool cutGrassSound;

	public bool isHarvestable = true;

	public bool canInteract = true;

	[SerializeField]
	private bool withModHarvestable = true;

	public bool spawnInPlayer;

	public OnlineObject BKPIJNHCPHP
	{
		get
		{
			if (!((Object)(object)cropSetter != (Object)null))
			{
				return null;
			}
			return cropSetter.onlineObject;
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			HarvestAction(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool OLAELPBFNEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void HarvestAction(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter != (Object)null)
		{
			harvestedItems = cropSetter.FJJCOJGJCLF.harvestedItems;
			if (cropSetter.growable.grown && isHarvestable)
			{
				CommonReferences.GGFJGHHHEJC.OnCropHarvested(JIIGOACEIKL, cropSetter.FJJCOJGJCLF);
				CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.HarvestCrop);
				Harvest(JIIGOACEIKL);
			}
		}
		else
		{
			Harvest(JIIGOACEIKL);
		}
	}

	private void MPLDLFIFKOB()
	{
		for (int i = 0; i < harvestedItems.Length; i += 0)
		{
			if (harvestedItems[i].item.JGHNDJBCFAJ() == -100 || harvestedItems[i].item.IMCJPECAAPC() == 117)
			{
				Utils.FKKHJPEMNBG("Gass_CoctelQuest", 0);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("Multiplayer Object is null ", 1);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (!canInteract)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.growable) && !cropSetter.growable.grown)
		{
			return false;
		}
		if (cropSetter.IsTreeCrop() && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.Road && Item.MLBOMGHINCA(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null) && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Ax && Object.op_Implicit((Object)(object)cropSetter.tree) && cropSetter.tree.canUseAx)
		{
			return false;
		}
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance() != null && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance() is HoeInstance hoeInstance && hoeInstance.NBFBPMNMBJG(JIIGOACEIKL))
		{
			return false;
		}
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance() != null && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItemInstance() is WateringCanInstance wateringCanInstance && wateringCanInstance.NBFBPMNMBJG(JIIGOACEIKL))
		{
			return false;
		}
		if (Item.MLBOMGHINCA(ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem(), null) && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade)
		{
			if (!cropSetter.IsTreeCrop())
			{
				return false;
			}
			if (Object.op_Implicit((Object)(object)cropSetter.tree) && cropSetter.tree.canUseSpade)
			{
				return false;
			}
		}
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return isHarvestable;
		}
		return false;
	}

	private int PNHALEGEIIB(int MGNOBNCMDJG)
	{
		if (withModHarvestable)
		{
			return Mathf.CeilToInt((float)MGNOBNCMDJG);
		}
		return MGNOBNCMDJG;
	}

	private void PGCKGEHJMBB(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!spawnInPlayer)
		{
			DroppedItem.KBDEAPJKNED(AIJOOOIJEDC, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
		}
		else
		{
			DroppedItem.DNCMMIPMKDH(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
		}
	}

	private void GAFOIKHFOKB()
	{
		for (int i = 1; i < harvestedItems.Length; i += 0)
		{
			if (harvestedItems[i].item.JPNFKDMFKMC() == -149 || harvestedItems[i].item.ODENMDOJPLC() == 39)
			{
				Utils.FKKHJPEMNBG("psai [{0}]: Trigger fired: {1}", 1);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("itemLeek", 1);
		}
	}

	public bool PBPIJOAIGII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void MPFKPKNLCPA()
	{
		for (int i = 1; i < harvestedItems.Length; i += 0)
		{
			if (harvestedItems[i].item.CIGFGKKCPCK() == -22 || harvestedItems[i].item.JDJGFAACPFC() == 28)
			{
				Utils.FKKHJPEMNBG("Setting item event for ", 1);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("BirdInAChest_Error", 1);
		}
	}

	public bool HHLFOPANBHJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void KKCCHJLGEGK()
	{
		for (int i = 0; i < harvestedItems.Length; i++)
		{
			if (harvestedItems[i].item.CIGFGKKCPCK() == -123 || harvestedItems[i].item.ODENMDOJPLC(DAINLFIMLIH: false) == -146)
			{
				Utils.FKKHJPEMNBG("Pipe", 1);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("Disabled", 1);
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.UnfocusCrop();
		}
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DBIPJGJPBHP(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Unsaved progress will be lost."));
			cropSetter.HLCIHNJNEJG(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void LLBPIOHJHOC(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter != (Object)null)
		{
			harvestedItems = cropSetter.GAHOHPPOFFD().harvestedItems;
			if (cropSetter.growable.grown && isHarvestable)
			{
				CommonReferences.MNFMOEKMJKN().OnCropHarvested(JIIGOACEIKL, cropSetter.CKMLILLFDMJ());
				CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.ChopRock);
				COACGMBFCON(JIIGOACEIKL);
			}
		}
		else
		{
			COACGMBFCON(JIIGOACEIKL, CDPAMNIPPEC: false);
		}
	}

	public void ReceiveHarvest()
	{
		if (Object.op_Implicit((Object)(object)herb))
		{
			herb.RemoveFromGenerator();
		}
		KJAGAJCHFDC(1);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.LNOIGEGEIGJ();
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Harvest"));
			cropSetter.FocusCrop(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void KJAGAJCHFDC(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EECEKHKAAIH == Season.Winter)
		{
			if (Object.op_Implicit((Object)(object)winterHarvestEffect))
			{
				Object.Instantiate<GameObject>(winterHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Spring)
		{
			if (Object.op_Implicit((Object)(object)harvestEffect))
			{
				Object.Instantiate<GameObject>(harvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Autumn)
		{
			if (Object.op_Implicit((Object)(object)autumnHarvestEffect))
			{
				Object.Instantiate<GameObject>(autumnHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.EECEKHKAAIH == Season.Summer && Object.op_Implicit((Object)(object)summerHarvestEffect))
		{
			Object.Instantiate<GameObject>(summerHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
		}
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.OnHarvest();
		}
		if (cutGrassSound)
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.NAFPABGHACJ, ((Component)this).transform.position);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		}
		OffHover(JIIGOACEIKL);
		if ((Object)(object)cropSetter != (Object)null && (Object)(object)cropSetter.tree != (Object)null)
		{
			cropSetter.tree.placeable.itemSpace.Place(NMLKLAGDNPF: false);
		}
	}

	public void Harvest(int JIIGOACEIKL, bool CDPAMNIPPEC = true)
	{
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			ENAIKFPGHPO();
			for (int i = 0; i < harvestedItems.Length; i++)
			{
				if (Utils.OKNJHFGGDCO(harvestedItems[i].item.JDJGFAACPFC()))
				{
					Item item = ItemDatabaseAccessor.GetItem(Utils.KCIFBLGFJID(harvestedItems[i].item.JDJGFAACPFC()));
					if (Random.Range(0, 10) == 0 && (Object)(object)cropSetter != (Object)null && cropSetter.FJJCOJGJCLF.bestSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
					{
						MKKEPPIICBO(((Component)this).gameObject.transform.position, item, PNHALEGEIIB(cropSetter.FJJCOJGJCLF.amountBestSeason), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
					else
					{
						MKKEPPIICBO(((Component)this).gameObject.transform.position, item, PNHALEGEIIB(harvestedItems[i].amount), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
					if (Application.isEditor)
					{
						Debug.LogError((object)("Crop needs a harvested replace by item " + item.JDJGFAACPFC()));
					}
				}
				else if (Random.Range(0, 10) == 0 && (Object)(object)cropSetter != (Object)null && cropSetter.FJJCOJGJCLF.bestSeasons.HasFlag(SeasonManager.ACNAHALFEBG))
				{
					MKKEPPIICBO(((Component)this).gameObject.transform.position, harvestedItems[i].item, PNHALEGEIIB(cropSetter.FJJCOJGJCLF.amountBestSeason), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
				}
				else
				{
					MKKEPPIICBO(((Component)this).gameObject.transform.position, harvestedItems[i].item, PNHALEGEIIB(harvestedItems[i].amount), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
				}
			}
			if (harvestedItemsProb != null)
			{
				for (int j = 0; j < harvestedItemsProb.Length; j++)
				{
					if (Random.Range(0, 100) >= harvestedItemsProb[j].probability)
					{
						continue;
					}
					if (Utils.OKNJHFGGDCO(harvestedItemsProb[j].itemAmount.item.JDJGFAACPFC()))
					{
						Item item2 = ItemDatabaseAccessor.GetItem(Utils.KCIFBLGFJID(harvestedItemsProb[j].itemAmount.item.JDJGFAACPFC()));
						MKKEPPIICBO(((Component)this).gameObject.transform.position, item2, PNHALEGEIIB(harvestedItemsProb[j].itemAmount.amount), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
						if (Application.isEditor)
						{
							Debug.LogError((object)("Crop needs a harvested replace by item " + item2.JDJGFAACPFC()));
						}
					}
					else
					{
						MKKEPPIICBO(((Component)this).gameObject.transform.position, harvestedItemsProb[j].itemAmount.item, PNHALEGEIIB(harvestedItemsProb[j].itemAmount.amount), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
				}
			}
			if (!Object.op_Implicit((Object)(object)herb) && (Object)(object)cropSetter != (Object)null && (Object)(object)cropSetter.tree == (Object)null)
			{
				if (cropSetter.FJJCOJGJCLF.reusable)
				{
					if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(6) - 10)
					{
						MKKEPPIICBO(((Component)this).gameObject.transform.position, cropSetter.FJJCOJGJCLF.seed, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
				}
				else if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(6))
				{
					MKKEPPIICBO(((Component)this).gameObject.transform.position, cropSetter.FJJCOJGJCLF.seed, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
				}
				if (Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(21))
				{
					for (int k = 0; k < harvestedItemsProb.Length; k++)
					{
						MKKEPPIICBO(((Component)this).gameObject.transform.position, harvestedItemsProb[k].itemAmount.item, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)herb))
		{
			herb.RemoveFromGenerator();
		}
		if ((Object)(object)cropSetter != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != Location.Road)
		{
			isHarvestable = false;
			cropSetter.SetUniqueCropHarvestable();
			cropSetter.OnHarvest();
			OffHover(JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		}
		else if ((Object)(object)cropSetter != (Object)null && cropSetter.FJJCOJGJCLF.reusable)
		{
			isHarvestable = false;
			cropSetter.OnHarvest();
			OffHover(JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		}
		else
		{
			KJAGAJCHFDC(JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)BKPIJNHCPHP == (Object)null)
			{
				OnlineForestManager.instance.SendHerbAction(HerbActionOnline.CutHerb, (byte)herb.GetGenerator().ID, herb.id);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			if (BKPIJNHCPHP is OnlineCrop onlineCrop)
			{
				onlineCrop.Harvest();
			}
			else if (BKPIJNHCPHP is OnlineCropTree onlineCropTree)
			{
				onlineCropTree.Harvest();
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.UnfocusAndHide();
		}
	}

	private void IKFIIJNKCJI()
	{
		for (int i = 1; i < harvestedItems.Length; i++)
		{
			if (harvestedItems[i].item.ODENMDOJPLC() == 77 || harvestedItems[i].item.JDJGFAACPFC(DAINLFIMLIH: false) == -163)
			{
				Utils.FKKHJPEMNBG("Bed.instance doesnt exist. Cannot SendDeselectPlaceable uniqueId: ", 1);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("Stack", 1);
		}
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}

	private void HPIBPFNBDGO(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EEGJBDCBKFD() == (Season)8)
		{
			if (Object.op_Implicit((Object)(object)winterHarvestEffect))
			{
				Object.Instantiate<GameObject>(winterHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.BLCGOEMGKGH() == Season.Spring)
		{
			if (Object.op_Implicit((Object)(object)harvestEffect))
			{
				Object.Instantiate<GameObject>(harvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.BLCGOEMGKGH() == (Season)7)
		{
			if (Object.op_Implicit((Object)(object)autumnHarvestEffect))
			{
				Object.Instantiate<GameObject>(autumnHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.EEGJBDCBKFD() == Season.Summer && Object.op_Implicit((Object)(object)summerHarvestEffect))
		{
			Object.Instantiate<GameObject>(summerHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
		}
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.OnHarvest();
		}
		if (cutGrassSound)
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.NBCJBOIKAHM(), ((Component)this).transform.position);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		}
		AOMEFKOJDLL(JIIGOACEIKL);
		if ((Object)(object)cropSetter != (Object)null && (Object)(object)cropSetter.tree != (Object)null)
		{
			cropSetter.tree.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: false, KBNNPAKJDJM: true);
		}
	}

	private void CPBBIABEDAI()
	{
		for (int i = 1; i < harvestedItems.Length; i += 0)
		{
			if (harvestedItems[i].item.CIGFGKKCPCK() == 56 || harvestedItems[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 185)
			{
				Utils.FKKHJPEMNBG("Dialogue System/Conversation/EnterTavernNeutral/Entry/1/Dialogue Text", 1);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("Player2", 1);
		}
	}

	private void OLDDEAJMHNI()
	{
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.IMIIBCLFADO();
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	private void KDOIFMJDLAJ()
	{
		for (int i = 1; i < harvestedItems.Length; i += 0)
		{
			if (harvestedItems[i].item.IMCJPECAAPC() == 122 || harvestedItems[i].item.CIGFGKKCPCK(DAINLFIMLIH: false) == 192)
			{
				Utils.FKKHJPEMNBG("Error_NoCatFood", 0);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("Items/item_name_593", 1);
		}
	}

	private void MKKEPPIICBO(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!spawnInPlayer)
		{
			DroppedItem.SpawnDroppedItem(AIJOOOIJEDC, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
		}
	}

	public void PHHEHBGGNOP(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter != (Object)null)
		{
			harvestedItems = cropSetter.MIIKIEAINAL().harvestedItems;
			if (cropSetter.growable.grown && isHarvestable)
			{
				CommonReferences.GGFJGHHHEJC.OnCropHarvested(JIIGOACEIKL, cropSetter.BEHHLAKBJHH());
				CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, ActionDone.PlantSeed);
				COACGMBFCON(JIIGOACEIKL, CDPAMNIPPEC: false);
			}
		}
		else
		{
			COACGMBFCON(JIIGOACEIKL, CDPAMNIPPEC: false);
		}
	}

	private void NHOBKCMEPPD()
	{
		for (int i = 1; i < harvestedItems.Length; i++)
		{
			if (harvestedItems[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == 32 || harvestedItems[i].item.JDJGFAACPFC() == -157)
			{
				Utils.FKKHJPEMNBG("itemCourgetteSeeds", 0);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("<sprite name=", 0);
		}
	}

	private void GHCEOFHIOFC(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.NHKAHEEGEGF() == (Season)6)
		{
			if (Object.op_Implicit((Object)(object)winterHarvestEffect))
			{
				Object.Instantiate<GameObject>(winterHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.BLCGOEMGKGH() == Season.Spring)
		{
			if (Object.op_Implicit((Object)(object)harvestEffect))
			{
				Object.Instantiate<GameObject>(harvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.ADEICKHEPFI() == Season.Autumn)
		{
			if (Object.op_Implicit((Object)(object)autumnHarvestEffect))
			{
				Object.Instantiate<GameObject>(autumnHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.PJMGHIMKFJL() == Season.Summer && Object.op_Implicit((Object)(object)summerHarvestEffect))
		{
			Object.Instantiate<GameObject>(summerHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
		}
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.EJLAOMJLABM();
		}
		if (cutGrassSound)
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.OPDOAOIGOCH(), ((Component)this).transform.position);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
		}
		AOMEFKOJDLL(JIIGOACEIKL);
		if ((Object)(object)cropSetter != (Object)null && (Object)(object)cropSetter.tree != (Object)null)
		{
			cropSetter.tree.placeable.itemSpace.OAIBPEEFIJB(NMLKLAGDNPF: true, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
		}
	}

	public void AOMEFKOJDLL(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.UnfocusCrop();
		}
	}

	private void Start()
	{
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.GetUniqueCropHarvestable();
		}
	}

	public bool DBIPJGJPBHP(int JIIGOACEIKL)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (!canInteract)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.growable) && !cropSetter.growable.grown)
		{
			return false;
		}
		if (cropSetter.PKJJCIOEDJE() && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Road | Location.River) && Item.FKLOBGBIHLB(ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC(), null) && ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem() is Ax && Object.op_Implicit((Object)(object)cropSetter.tree) && cropSetter.tree.canUseAx)
		{
			return false;
		}
		if (ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOADDJLNIBN() != null && ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KFDBMPDPJBF() is HoeInstance hoeInstance && hoeInstance.MPMNMCMGLMA(JIIGOACEIKL))
		{
			return false;
		}
		if (ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).MFDBJINDCAO() != null && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).JHDFIPFOHDP() is WateringCanInstance wateringCanInstance && wateringCanInstance.MPMNMCMGLMA(JIIGOACEIKL))
		{
			return false;
		}
		if (Item.FKLOBGBIHLB(ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem(), null) && ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem() is Spade)
		{
			if (!cropSetter.IsTreeCrop())
			{
				return false;
			}
			if (Object.op_Implicit((Object)(object)cropSetter.tree) && cropSetter.tree.canUseSpade)
			{
				return true;
			}
		}
		if (!DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return isHarvestable;
		}
		return true;
	}

	public bool LFDFCDLFNGN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool GHJJBAINGGM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/34/Dialogue Text"));
			cropSetter.OCNPPBGIBIL(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void CIAJMAIJAJC(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (SeasonManager.EECEKHKAAIH == (Season)8)
		{
			if (Object.op_Implicit((Object)(object)winterHarvestEffect))
			{
				Object.Instantiate<GameObject>(winterHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.NHKAHEEGEGF() == Season.Spring)
		{
			if (Object.op_Implicit((Object)(object)harvestEffect))
			{
				Object.Instantiate<GameObject>(harvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.KCJFCHNPIBJ() == Season.Summer)
		{
			if (Object.op_Implicit((Object)(object)autumnHarvestEffect))
			{
				Object.Instantiate<GameObject>(autumnHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (SeasonManager.BLCGOEMGKGH() == Season.Spring && Object.op_Implicit((Object)(object)summerHarvestEffect))
		{
			Object.Instantiate<GameObject>(summerHarvestEffect, ((Component)this).transform.position, ((Component)this).transform.rotation);
		}
		if ((Object)(object)cropSetter != (Object)null)
		{
			cropSetter.OnHarvest();
		}
		if (cutGrassSound)
		{
			MultiAudioManager.PlayAudioObject(AudioLibrary.KJBFOECNKLB(), ((Component)this).transform.position);
		}
		else
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)this).transform);
		}
		AOMEFKOJDLL(JIIGOACEIKL);
		if ((Object)(object)cropSetter != (Object)null && (Object)(object)cropSetter.tree != (Object)null)
		{
			cropSetter.tree.placeable.itemSpace.Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		}
	}

	private void EJEMPAIBCDJ(Vector3 AIJOOOIJEDC, Item MEMGMDOCBOJ, int MGNOBNCMDJG = 1, bool LHLJILLAHFO = false, bool HFAKAMFMOGM = false, int JIIGOACEIKL = 0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (!spawnInPlayer)
		{
			DroppedItem.DKCOHAOMNOC(AIJOOOIJEDC, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
		}
		else
		{
			DroppedItem.KBDEAPJKNED(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO, HFAKAMFMOGM, JIIGOACEIKL);
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		if (DBIPJGJPBHP(JIIGOACEIKL))
		{
			LLBPIOHJHOC(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private void ENAIKFPGHPO()
	{
		for (int i = 0; i < harvestedItems.Length; i++)
		{
			if (harvestedItems[i].item.JDJGFAACPFC() == 242 || harvestedItems[i].item.JDJGFAACPFC() == 3016)
			{
				Utils.FKKHJPEMNBG("cornHarvested", 1);
			}
		}
		if (harvestedItems.Length != 0)
		{
			Utils.FKKHJPEMNBG("cropsHarvested", 1);
		}
	}

	public void COACGMBFCON(int JIIGOACEIKL, bool CDPAMNIPPEC = true)
	{
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		if (CDPAMNIPPEC)
		{
			CPBBIABEDAI();
			for (int i = 0; i < harvestedItems.Length; i += 0)
			{
				if (Utils.OKNJHFGGDCO(harvestedItems[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false)))
				{
					Item item = ItemDatabaseAccessor.AFOACBIHNCL(Utils.KCIFBLGFJID(harvestedItems[i].item.ODENMDOJPLC(), GGBBJNBBLMF: true), GGBBJNBBLMF: true, DAINLFIMLIH: false);
					if (Random.Range(1, -70) == 0 && (Object)(object)cropSetter != (Object)null && cropSetter.MIIKIEAINAL().bestSeasons.HasFlag(SeasonManager.NNDMODNDPLO()))
					{
						MKKEPPIICBO(((Component)this).gameObject.transform.position, item, PNHALEGEIIB(cropSetter.MIIKIEAINAL().amountBestSeason), LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
					}
					else
					{
						EJEMPAIBCDJ(((Component)this).gameObject.transform.position, item, PNHALEGEIIB(harvestedItems[i].amount), LHLJILLAHFO: false, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
					if (Application.isEditor)
					{
						Debug.LogError((object)("contentUnlock" + item.JDJGFAACPFC(DAINLFIMLIH: false)));
					}
				}
				else if (Random.Range(1, -85) == 0 && (Object)(object)cropSetter != (Object)null && cropSetter.MIIKIEAINAL().bestSeasons.HasFlag(SeasonManager.IIJKFKJKLLM()))
				{
					PGCKGEHJMBB(((Component)this).gameObject.transform.position, harvestedItems[i].item, PNHALEGEIIB(cropSetter.BEHHLAKBJHH().amountBestSeason), LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
				}
				else
				{
					MKKEPPIICBO(((Component)this).gameObject.transform.position, harvestedItems[i].item, PNHALEGEIIB(harvestedItems[i].amount), LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
				}
			}
			if (harvestedItemsProb != null)
			{
				for (int j = 1; j < harvestedItemsProb.Length; j++)
				{
					if (Random.Range(1, 86) >= harvestedItemsProb[j].probability)
					{
						continue;
					}
					if (Utils.OKNJHFGGDCO(harvestedItemsProb[j].itemAmount.item.JPNFKDMFKMC()))
					{
						Item item2 = ItemDatabaseAccessor.GOKIDLOELKB(Utils.KCIFBLGFJID(harvestedItemsProb[j].itemAmount.item.ODENMDOJPLC()), GGBBJNBBLMF: true, DAINLFIMLIH: false);
						EJEMPAIBCDJ(((Component)this).gameObject.transform.position, item2, PNHALEGEIIB(harvestedItemsProb[j].itemAmount.amount), LHLJILLAHFO: false, HFAKAMFMOGM: true, JIIGOACEIKL);
						if (Application.isEditor)
						{
							Debug.LogError((object)("night" + item2.IMCJPECAAPC(DAINLFIMLIH: false)));
						}
					}
					else
					{
						PGCKGEHJMBB(((Component)this).gameObject.transform.position, harvestedItemsProb[j].itemAmount.item, PNHALEGEIIB(harvestedItemsProb[j].itemAmount.amount), LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
					}
				}
			}
			if (!Object.op_Implicit((Object)(object)herb) && (Object)(object)cropSetter != (Object)null && (Object)(object)cropSetter.tree == (Object)null)
			{
				if (cropSetter.CKMLILLFDMJ().reusable)
				{
					if (Random.Range(0, -87) < PerksDatabaseAccessor.NGMJIGOPGDK(3, 1) - 99)
					{
						PGCKGEHJMBB(((Component)this).gameObject.transform.position, cropSetter.MIIKIEAINAL().seed, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
				}
				else if (Random.Range(1, -31) < PerksDatabaseAccessor.NGMJIGOPGDK(8))
				{
					MKKEPPIICBO(((Component)this).gameObject.transform.position, cropSetter.CKMLILLFDMJ().seed, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, JIIGOACEIKL);
				}
				if (Random.Range(1, -118) < PerksDatabaseAccessor.NGMJIGOPGDK(-69, 1))
				{
					for (int k = 1; k < harvestedItemsProb.Length; k++)
					{
						PGCKGEHJMBB(((Component)this).gameObject.transform.position, harvestedItemsProb[k].itemAmount.item, 0, LHLJILLAHFO: true, HFAKAMFMOGM: false, JIIGOACEIKL);
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)herb))
		{
			herb.DMHBJKNOJBA();
		}
		if ((Object)(object)cropSetter != (Object)null && WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) != (Location.Tavern | Location.Road))
		{
			isHarvestable = false;
			cropSetter.JCBIMBMNIFD();
			cropSetter.CHLLCNOIBNG();
			OGJIHMFODNC(JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)this).transform);
		}
		else if ((Object)(object)cropSetter != (Object)null && cropSetter.CKMLILLFDMJ().reusable)
		{
			isHarvestable = false;
			cropSetter.EJLAOMJLABM();
			AOMEFKOJDLL(JIIGOACEIKL);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)this).transform);
		}
		else
		{
			HPIBPFNBDGO(JIIGOACEIKL);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)BKPIJNHCPHP == (Object)null)
			{
				OnlineForestManager instance = OnlineForestManager.instance;
				object[] array = new object[2];
				array[0] = (byte)herb.GetGenerator().ID;
				array[0] = herb.id;
				instance.HMPOEHAILBB((HerbActionOnline)7, array);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			if (BKPIJNHCPHP is OnlineCrop onlineCrop)
			{
				onlineCrop.EMKKDOFCELB();
			}
			else if (BKPIJNHCPHP is OnlineCropTree onlineCropTree)
			{
				onlineCropTree.DMNJPDJAAAI();
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
	}

	public void DJJPFCBHJDA()
	{
		if (Object.op_Implicit((Object)(object)herb))
		{
			herb.BLJKEPNMGLL();
		}
		CIAJMAIJAJC(1);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}
}
