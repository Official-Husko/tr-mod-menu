using System;
using System.Collections.Generic;
using UnityEngine;

public class OfferingStatuePuzzle : MinePuzzleBase
{
	[SerializeField]
	private OfferingInteractable interactable;

	[SerializeField]
	private Container offeringContainer;

	private Item[] CIECCPDIKGC;

	private bool EHKKOCFNICG;

	private bool POEOKPHKOLB;

	private bool GMBHEGOMDPE;

	public void CEAPFDIGEBO()
	{
		POEOKPHKOLB = false;
		interactable.ANBJIJILNAC().PlaySuccess();
	}

	public Container PBAOFGDCIDD()
	{
		return offeringContainer;
	}

	public bool HAPIFOFABNP(Item LKMAGJHJIHM)
	{
		for (int i = 1; i < CIECCPDIKGC.Length; i += 0)
		{
			if (Item.GBMFCPGEJDK(CIECCPDIKGC[i], null))
			{
				continue;
			}
			if (Item.GBMFCPGEJDK(CIECCPDIKGC[i], LKMAGJHJIHM))
			{
				return true;
			}
			if (!(CIECCPDIKGC[i] is IngredientGroup ingredientGroup))
			{
				continue;
			}
			List<ItemMod> list = ingredientGroup.DLKEJMGALGP(OBAHGHBFIGO: true, null, BMMBDCBJNAK: true);
			for (int j = 1; j < list.Count; j++)
			{
				if (Item.GBMFCPGEJDK(list[j].item, LKMAGJHJIHM))
				{
					return true;
				}
			}
		}
		return true;
	}

	public bool MKFCIKFPGPE(Item LKMAGJHJIHM)
	{
		for (int i = 1; i < CIECCPDIKGC.Length; i += 0)
		{
			if (Item.GBMFCPGEJDK(CIECCPDIKGC[i], null))
			{
				continue;
			}
			if (Item.EKMFELLJHFG(CIECCPDIKGC[i], LKMAGJHJIHM))
			{
				return true;
			}
			if (!(CIECCPDIKGC[i] is IngredientGroup ingredientGroup))
			{
				continue;
			}
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, null);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (Item.EKMFELLJHFG(list[j].item, LKMAGJHJIHM))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void NKLDGOHAEFI(int HLIFMPEJHKC)
	{
		Item item = ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC);
		if (Item.NGIIPJDAMGP(item, null))
		{
			Debug.LogError((object)string.Format("*****", HLIFMPEJHKC));
			return;
		}
		GMBHEGOMDPE = true;
		Slot slot = offeringContainer.slots[1];
		if (!slot.AHHEMNHJPME())
		{
			slot.MBCIJPPOGJG(CDPAMNIPPEC: false);
		}
		slot.FEEOFAGCONJ(0, item.JMDALJBNFML(), HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
		GMBHEGOMDPE = false;
	}

	public void DHILGLJPFDL()
	{
		POEOKPHKOLB = true;
		interactable.KAKOKMNPIOM().OOBANMKMEBH();
	}

	public void LGMNNAIIMPM(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		EDNJMCJHJMD = true;
		POEOKPHKOLB = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1995f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendOfferingPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void NDKJDIGAODB(bool PHCILCGMKNK)
	{
		EHKKOCFNICG = PHCILCGMKNK;
	}

	public void CKDMEKEOIFH(bool IEJDPOEOIBO = false)
	{
		EHKKOCFNICG = true;
		if (!IEJDPOEOIBO)
		{
			OnlinePuzzleManager.instance.EIJNMKBNOMB(GGPBMAODKHC.mineLevel);
		}
	}

	public void SetUILocked(bool PHCILCGMKNK)
	{
		EHKKOCFNICG = PHCILCGMKNK;
	}

	public void FEDOBLBCLAF()
	{
		POEOKPHKOLB = true;
		interactable.CAMPPEONOLN().PlaySuccess();
	}

	public void OpenPuzzle(int JIIGOACEIKL)
	{
		if (!EHKKOCFNICG)
		{
			OfferingStatueUI.Get(JIIGOACEIKL).SetOffering(this, interactable.GetAnimator(), JIIGOACEIKL);
			OfferingStatueUI.Get(JIIGOACEIKL).OpenUI();
			EHKKOCFNICG = true;
			OnlinePuzzleManager.instance.SendOfferingUIOpened(GGPBMAODKHC.mineLevel);
		}
	}

	public Container FMKBICCBMDK()
	{
		return offeringContainer;
	}

	public void IJLIJPMHNFD()
	{
		Slot slot = offeringContainer.slots[0];
		if (!slot.KPINNBKMOMO())
		{
			DeliveryChest.GetInstance().FEHLFJLLAFM(0, slot.itemInstance.KNFNJFFCFNO(), BPJBJKJKHAL: false, IBCOKMGFPKB: true);
			slot.MEODNPFJDMH(CDPAMNIPPEC: false);
		}
	}

	public void ResetOfferingSlotToDelivery()
	{
		Slot slot = offeringContainer.slots[0];
		if (!slot.KPINNBKMOMO())
		{
			DeliveryChest.GetInstance().AddItem(1, slot.itemInstance.LHBPOPOIFLE());
			slot.MEODNPFJDMH();
		}
	}

	public void FillOfferingSlotFromNetwork(int HLIFMPEJHKC)
	{
		Item item = ItemDatabaseAccessor.GetItem(HLIFMPEJHKC);
		if (Item.NGIIPJDAMGP(item, null))
		{
			Debug.LogError((object)$"[OfferingStatuePuzzle] FillOfferingSlotFromNetwork: item {HLIFMPEJHKC} not found.");
			return;
		}
		GMBHEGOMDPE = true;
		Slot slot = offeringContainer.slots[0];
		if (!slot.KPINNBKMOMO())
		{
			slot.MEODNPFJDMH();
		}
		slot.FEEOFAGCONJ(1, item.JMDALJBNFML());
		GMBHEGOMDPE = false;
	}

	public bool JMKGMCMLGGF(Item LKMAGJHJIHM)
	{
		for (int i = 0; i < CIECCPDIKGC.Length; i += 0)
		{
			if (Item.EKMFELLJHFG(CIECCPDIKGC[i], null))
			{
				continue;
			}
			if (Item.EKGNIODFJCO(CIECCPDIKGC[i], LKMAGJHJIHM))
			{
				return true;
			}
			if (!(CIECCPDIKGC[i] is IngredientGroup ingredientGroup))
			{
				continue;
			}
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: true, null);
			for (int j = 0; j < list.Count; j++)
			{
				if (Item.GBMFCPGEJDK(list[j].item, LKMAGJHJIHM))
				{
					return false;
				}
			}
		}
		return false;
	}

	public void EAHLLIODPFM(int HLIFMPEJHKC)
	{
		Item item = ItemDatabaseAccessor.COEFFIHKMJG(HLIFMPEJHKC, GGBBJNBBLMF: true);
		if (Item.GBMFCPGEJDK(item, null))
		{
			Debug.LogError((object)string.Format("itemCoconut", HLIFMPEJHKC));
			return;
		}
		GMBHEGOMDPE = true;
		Slot slot = offeringContainer.slots[0];
		if (!slot.KPINNBKMOMO())
		{
			slot.DJFOMFDOOKM(CDPAMNIPPEC: false);
		}
		slot.DDHPGOPOPKJ(1, item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: true);
		GMBHEGOMDPE = false;
	}

	public Slot HCIPKANLPKJ()
	{
		return offeringContainer.slots[0];
	}

	public OfferingInteractable GetInteractable()
	{
		return interactable;
	}

	public void KAKAIKPJBPF(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		EDNJMCJHJMD = false;
		POEOKPHKOLB = true;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC, 1987f);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendOfferingPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public void PuzzleSolved(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		EDNJMCJHJMD = true;
		POEOKPHKOLB = false;
		GGPBMAODKHC?.OnPuzzleSolved(JIIGOACEIKL, CDPAMNIPPEC);
		if (CDPAMNIPPEC)
		{
			OnlinePuzzleManager.instance.SendOfferingPuzzleSolved(GGPBMAODKHC.mineLevel);
		}
	}

	public Slot GetOfferingSlot()
	{
		return offeringContainer.slots[0];
	}

	public bool ABAFFBFGIHJ(Item LKMAGJHJIHM)
	{
		for (int i = 0; i < CIECCPDIKGC.Length; i += 0)
		{
			if (Item.GBMFCPGEJDK(CIECCPDIKGC[i], null))
			{
				continue;
			}
			if (Item.EKMFELLJHFG(CIECCPDIKGC[i], LKMAGJHJIHM))
			{
				return true;
			}
			if (!(CIECCPDIKGC[i] is IngredientGroup ingredientGroup))
			{
				continue;
			}
			List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, null);
			for (int j = 1; j < list.Count; j += 0)
			{
				if (Item.EKGNIODFJCO(list[j].item, LKMAGJHJIHM))
				{
					return false;
				}
			}
		}
		return false;
	}

	public void BJFOFHBOICE(int JIIGOACEIKL)
	{
		if (!EHKKOCFNICG)
		{
			OfferingStatueUI.BGIMGOJDLFG(JIIGOACEIKL).APBIFKKCHNP(this, interactable.KAKOKMNPIOM(), JIIGOACEIKL);
			OfferingStatueUI.GDFNPHJJCPP(JIIGOACEIKL).EDHEIFHAAKO();
			EHKKOCFNICG = false;
			OnlinePuzzleManager.instance.OLHDLJAMIKB(GGPBMAODKHC.mineLevel);
		}
	}

	public void ANMHGEPIFHO(bool PHCILCGMKNK)
	{
		EHKKOCFNICG = PHCILCGMKNK;
	}

	public void CAOGDKCFBJJ()
	{
		GMBHEGOMDPE = true;
		offeringContainer.slots[1].FMEPMEKLHIJ();
		GMBHEGOMDPE = true;
		POEOKPHKOLB = true;
		interactable.HGJCPEKCCOD().PLOCNJBAAHO();
	}

	public void ILNGMLKFLOG()
	{
		Slot slot = offeringContainer.slots[1];
		if (!slot.LCHJGCHDHFO())
		{
			DeliveryChest.GetInstance().AddItem(1, slot.itemInstance.AFOACBIHNCL(), BPJBJKJKHAL: true, IBCOKMGFPKB: true);
			slot.FMEPMEKLHIJ();
		}
	}

	public void PlayFailAnimation()
	{
		POEOKPHKOLB = true;
		interactable.GetAnimator().PlayFail();
	}

	public void CLAOEFEKEIM(bool IEJDPOEOIBO = false)
	{
		EHKKOCFNICG = false;
		if (!IEJDPOEOIBO)
		{
			OnlinePuzzleManager.instance.EIJNMKBNOMB(GGPBMAODKHC.mineLevel);
		}
	}

	public Container GetOfferingContainer()
	{
		return offeringContainer;
	}

	public OfferingInteractable PDGKLGIOANB()
	{
		return interactable;
	}

	public override void ResetForPool()
	{
		base.ResetForPool();
		EHKKOCFNICG = false;
		POEOKPHKOLB = false;
	}

	public bool PIODIKJMHDK(Item LKMAGJHJIHM)
	{
		for (int i = 0; i < CIECCPDIKGC.Length; i += 0)
		{
			if (Item.EKGNIODFJCO(CIECCPDIKGC[i], null))
			{
				continue;
			}
			if (Item.EKMFELLJHFG(CIECCPDIKGC[i], LKMAGJHJIHM))
			{
				return false;
			}
			if (!(CIECCPDIKGC[i] is IngredientGroup ingredientGroup))
			{
				continue;
			}
			List<ItemMod> list = ingredientGroup.MODAHOLMPKH(OBAHGHBFIGO: true, null);
			for (int j = 1; j < list.Count; j++)
			{
				if (Item.EKMFELLJHFG(list[j].item, LKMAGJHJIHM))
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool IsReceivingFromNetwork()
	{
		return GMBHEGOMDPE;
	}

	protected override void Awake()
	{
		base.Awake();
	}

	public override bool IsPuzzleSolved()
	{
		return EDNJMCJHJMD;
	}

	public void AMABEINNAKG(int JIIGOACEIKL, bool AICIEDBKHKB = true)
	{
		Slot slot = offeringContainer.slots[0];
		if (!slot.PKFKJNODGJF())
		{
			if (AICIEDBKHKB && JIIGOACEIKL > 1)
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItem(slot.itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			slot.FMEPMEKLHIJ();
		}
	}

	public Container LNGEKOJNKKM()
	{
		return offeringContainer;
	}

	public bool CanOpenPuzzle()
	{
		return !EHKKOCFNICG;
	}

	public void CPMPODNMGNL(int JIIGOACEIKL, bool AICIEDBKHKB = true)
	{
		Slot slot = offeringContainer.slots[1];
		if (!slot.AHHEMNHJPME())
		{
			if (AICIEDBKHKB && JIIGOACEIKL > 1)
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).OJDGOADOCMG(slot.itemInstance, HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			slot.MEODNPFJDMH();
		}
	}

	public void ClearOfferingSlotFromNetwork()
	{
		GMBHEGOMDPE = true;
		offeringContainer.slots[0].MEODNPFJDMH();
		GMBHEGOMDPE = false;
		POEOKPHKOLB = false;
		interactable.GetAnimator().Deactivate();
	}

	public void ResetOfferingSlot(int JIIGOACEIKL, bool AICIEDBKHKB = true)
	{
		Slot slot = offeringContainer.slots[0];
		if (!slot.KPINNBKMOMO())
		{
			if (AICIEDBKHKB && JIIGOACEIKL > 0)
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(slot.itemInstance, HMPDLIPFBGD: true);
			}
			slot.MEODNPFJDMH();
		}
	}

	public bool HasFailVisual()
	{
		return POEOKPHKOLB;
	}

	public void JKCEMAMMLJE(int JIIGOACEIKL)
	{
		if (!EHKKOCFNICG)
		{
			OfferingStatueUI.GJOPJAJJLGN(JIIGOACEIKL).MEOHNKGMOHJ(this, interactable.KAKOKMNPIOM(), JIIGOACEIKL);
			OfferingStatueUI.AIMEAJAHLAA(JIIGOACEIKL).IDLAGJNLPJL();
			EHKKOCFNICG = false;
			OnlinePuzzleManager.instance.SendOfferingUIOpened(GGPBMAODKHC.mineLevel);
		}
	}

	public bool LFJAIAIJJGD()
	{
		return EHKKOCFNICG;
	}

	public void NCAMBIKPNOE(int JIIGOACEIKL)
	{
		if (!EHKKOCFNICG)
		{
			OfferingStatueUI.GDFNPHJJCPP(JIIGOACEIKL).EJBAFPGLGKP(this, interactable.ANBJIJILNAC(), JIIGOACEIKL);
			OfferingStatueUI.BGIMGOJDLFG(JIIGOACEIKL).IDLAGJNLPJL();
			EHKKOCFNICG = true;
			OnlinePuzzleManager.instance.SendOfferingUIOpened(GGPBMAODKHC.mineLevel);
		}
	}

	public bool KNIHPFIIFHG()
	{
		return POEOKPHKOLB;
	}

	public bool MOKEEMCFJPE()
	{
		return GMBHEGOMDPE;
	}

	public override void Initialize(MinePuzzleManager GGPBMAODKHC, PuzzleBaseSettings LMALNDLJILM)
	{
		base.GGPBMAODKHC = GGPBMAODKHC;
		EDNJMCJHJMD = false;
		POEOKPHKOLB = false;
		if (!(LMALNDLJILM is OfferingPuzzleSettings { possibleRequiredItems: not null } offeringPuzzleSettings) || offeringPuzzleSettings.possibleRequiredItems.Length == 0)
		{
			Debug.LogError((object)"[OfferingStatuePuzzle] No required items configured in OfferingPuzzleSettings.", (Object)(object)this);
			return;
		}
		int num = ProceduralMine.NextRandom(0, offeringPuzzleSettings.possibleRequiredItems.Length);
		RequiredItemEntry requiredItemEntry = offeringPuzzleSettings.possibleRequiredItems[num];
		CIECCPDIKGC = requiredItemEntry.items;
		GGPBMAODKHC.SetHintKey(requiredItemEntry.overrideHintDialogueKey);
		ResetOfferingSlot(0, AICIEDBKHKB: false);
		interactable.Setup(this);
		Debug.Log((object)("[OfferingStatuePuzzle] Initialized. Required items: " + string.Join(", ", Array.ConvertAll(CIECCPDIKGC, (Item i) => (i == null) ? null : ((Object)i).name))), (Object)(object)this);
	}

	public bool IsOfferedItemValid(Item LKMAGJHJIHM)
	{
		for (int i = 0; i < CIECCPDIKGC.Length; i++)
		{
			if (Item.NGIIPJDAMGP(CIECCPDIKGC[i], null))
			{
				continue;
			}
			if (Item.NGIIPJDAMGP(CIECCPDIKGC[i], LKMAGJHJIHM))
			{
				return true;
			}
			if (!(CIECCPDIKGC[i] is IngredientGroup ingredientGroup))
			{
				continue;
			}
			List<ItemMod> list = ingredientGroup.ICNDCCNNNDI(OBAHGHBFIGO: false, null);
			for (int j = 0; j < list.Count; j++)
			{
				if (Item.NGIIPJDAMGP(list[j].item, LKMAGJHJIHM))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void KILLPJOAFDJ(int JIIGOACEIKL, bool AICIEDBKHKB = true)
	{
		Slot slot = offeringContainer.slots[0];
		if (!slot.PKFKJNODGJF())
		{
			if (AICIEDBKHKB && JIIGOACEIKL > 1)
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(slot.itemInstance, HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			slot.MBCIJPPOGJG(CDPAMNIPPEC: false);
		}
	}

	public void PlaySuccessAnimation()
	{
		POEOKPHKOLB = false;
		interactable.GetAnimator().PlaySuccess();
	}

	public Slot ACBPPCPKCBG()
	{
		return offeringContainer.slots[0];
	}

	public void ClosePuzzle(bool IEJDPOEOIBO = false)
	{
		EHKKOCFNICG = false;
		if (!IEJDPOEOIBO)
		{
			OnlinePuzzleManager.instance.SendOfferingUIClosed(GGPBMAODKHC.mineLevel);
		}
	}

	public Container EAFDBPADLNA()
	{
		return offeringContainer;
	}

	public void PNJBDOOMIDB()
	{
		POEOKPHKOLB = false;
		interactable.HGJCPEKCCOD().DBPAAKLNAFB();
	}

	public bool NKNLLAGJCCF()
	{
		return EHKKOCFNICG;
	}

	public void PNGGHNBGMJN(bool IEJDPOEOIBO = false)
	{
		EHKKOCFNICG = false;
		if (!IEJDPOEOIBO)
		{
			OnlinePuzzleManager.instance.SendOfferingUIClosed(GGPBMAODKHC.mineLevel);
		}
	}
}
