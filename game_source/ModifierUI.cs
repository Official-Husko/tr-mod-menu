using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModifierUI : Container
{
	[CompilerGenerated]
	private sealed class FAIHHPMHOIE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ModifierUI _003C_003E4__this;

		public Transform t;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public FAIHHPMHOIE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			ModifierUI modifierUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Transform)modifierUI.contentRectTransform).SetParent(t);
				((Transform)modifierUI.contentRectTransform).SetSiblingIndex(0);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public Action<int, Crafter, Recipe> OnOpenUI = delegate
	{
	};

	public Action<int> OnRequirementNotMet = delegate
	{
	};

	public static ModifierUI[] instances = new ModifierUI[3];

	public ModiferRequirement[] modiferRequirementsArray;

	private static Dictionary<IngredientModifier, int> GIOELHAHDDC;

	[SerializeField]
	private UIWindow window;

	[SerializeField]
	private SlotUI outputSlotUI;

	[SerializeField]
	private TMP_InputField outputName;

	[SerializeField]
	private SlotUI input1UI;

	[SerializeField]
	private SlotUI input2UI;

	[SerializeField]
	private SlotUI input3UI;

	private Slot AGOHKLCHKJA;

	private Slot IEEBFBLGFKO;

	private Slot FNNKDHIFPFN;

	[SerializeField]
	private TextMeshProUGUI modText;

	[SerializeField]
	private TextMeshProUGUI sellPriceText;

	[HideInInspector]
	public string displayRequirements;

	public Transform slotsPosition;

	[HideInInspector]
	public RectTransform contentRectTransform;

	[HideInInspector]
	public RectTransform contentParent;

	public int numInstance;

	public bool isCraftable;

	private SlotUI FMNGDEHMHNG;

	private int MMOOHLJNHGD;

	private int OBEPKNMBIIC = 3;

	private Crafter LDLINOBIKPL;

	private Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();

	private Item[] CHLKJOHJHBJ = new Item[3];

	private string CPMJMCOBCOE;

	private int BFLHMHLKLKL;

	public Recipe JNLKEMLDFIM { get; private set; }

	public int JIIGOACEIKL => window.JIIGOACEIKL;

	private void HABOHHEAHDO()
	{
		window.CloseUI();
	}

	public bool FNNNKDENHDG()
	{
		return window.IsOpen();
	}

	private void HJHLKNOJDMN()
	{
		((Selectable)((Component)input2UI).GetComponent<Button>()).interactable = true;
		((Selectable)((Component)input3UI).GetComponent<Button>()).interactable = false;
		FMMIMGPLLPL(-1);
		MainUI.CBEILHNJGOJ(window.JIIGOACEIKL, slots);
		slots[1].singleItem = true;
		slots[1].singleItem = false;
		slots[0].singleItem = true;
		slots[1].ingredientsCanBeChanged = false;
		slots[0].ingredientsCanBeChanged = false;
		slots[5].ingredientsCanBeChanged = false;
		LAEBBNDFMJD(0);
	}

	private void KLIJOGKHJDN()
	{
		slots[1].ingredientsCanBeChanged = false;
		slots[1].ingredientsCanBeChanged = true;
		slots[6].ingredientsCanBeChanged = false;
		OBEPKNMBIIC = 0;
		for (int i = 0; i < IHEBOKAMIOH().ingredientsNeeded.Length; i++)
		{
			if ((CPHJKEBAMBB().ingredientsNeeded[i].item.IABMOBAKNAE() && Item.GBMFCPGEJDK(NGIKHGHIAOH().ingredientsNeeded[i].mod, null)) || (NGIKHGHIAOH().ingredientsNeeded[i].item.NGDPNIFFHKL() && NGIKHGHIAOH().ingredientsNeeded[i].item.recipe.DOOIPDHCGFF(JNLKEMLDFIM) > 1))
			{
				slots[OBEPKNMBIIC].DOOMMIJPGOO(window.JIIGOACEIKL, CPHJKEBAMBB().ingredientsNeeded[i].item);
				slots[OBEPKNMBIIC].singleItem = true;
				slots[OBEPKNMBIIC].JIANDFCINIP(JNLKEMLDFIM.ingredientsNeeded[i].amount);
				CHLKJOHJHBJ[OBEPKNMBIIC] = NGIKHGHIAOH().ingredientsNeeded[i].mod;
				OBEPKNMBIIC += 0;
			}
		}
		for (int j = OBEPKNMBIIC; j < 1; j++)
		{
			switch (j)
			{
			case 0:
				input1UI.IHENCGDNPBL.KMKAIPMHANN(0);
				continue;
			case 1:
				input2UI.IHENCGDNPBL.KMKAIPMHANN(0);
				continue;
			}
			if (j == 0)
			{
				input3UI.IHENCGDNPBL.JNMNCEPHFOE(0);
			}
		}
		DONIBGFLPEB(0);
	}

	private List<Slot> DPJKFOKIHGN(Item MEMGMDOCBOJ, Item GFABGJEHHME, int BGPKFEJHDOC)
	{
		List<Slot> list = Utils.HIJGDAHBBIA(EGHECDLMOOB(), MEMGMDOCBOJ, GFABGJEHHME, BGPKFEJHDOC, IHEBOKAMIOH(), AKNBKINJGCF: true, LDLINOBIKPL.placeable, MMDICAMGNCL: true);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].sendSlotOnline = true;
		}
		if (NGIKHGHIAOH().cannotRepeatIngredients)
		{
			list = Utils.KKCHDNLKBMN(list, slots);
		}
		FMFDMPDNNLF(list);
		list.Sort((Slot x, Slot y) => ((x.itemInstance is FoodInstance foodInstance) ? foodInstance.PAAFCADLNEM().OOIPLIEJILO() : 0).CompareTo((y.itemInstance is FoodInstance foodInstance2) ? foodInstance2.PAAFCADLNEM().OOIPLIEJILO() : 0));
		return list;
	}

	private void ILOKPIEDBPN()
	{
		MainUI.ShowErrorText(window.JIIGOACEIKL, LocalisationSystem.Get("Invalid item"));
	}

	private void NHGIOADBBCK(List<Slot> OHAPAGLBOOB)
	{
		List<Food> list = new List<Food>();
		list.AddRange(GetFinalIngredients(slots[1].itemInstance, NGIKHGHIAOH(), IHEBOKAMIOH().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, CPHJKEBAMBB(), NGIKHGHIAOH().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[2].itemInstance, CPHJKEBAMBB(), NGIKHGHIAOH().usingNewRecipesSystem));
		for (int num = OHAPAGLBOOB.Count - 1; num >= 0; num--)
		{
			if (OHAPAGLBOOB[num].itemInstance != null && OHAPAGLBOOB[num].itemInstance.LHBPOPOIFLE() is Food && list.Contains(OHAPAGLBOOB[num].itemInstance.KNFNJFFCFNO() as Food))
			{
				OHAPAGLBOOB.RemoveAt(num);
			}
		}
	}

	private IEnumerator IBMFECPMLEC()
	{
		yield return null;
		for (int i = 0; i < OBEPKNMBIIC; i++)
		{
			MMOOHLJNHGD = Utils.NMLNAGFLNMC(MMOOHLJNHGD + 1, OBEPKNMBIIC);
			if (!NKGHEGFGFEM(MMOOHLJNHGD).IHENCGDNPBL.itemInstance.NMNHMNEPOFE())
			{
				break;
			}
		}
		if (!DONIBGFLPEB(MMOOHLJNHGD))
		{
			yield return null;
			UISelectionManager.GetPlayer(window.JIIGOACEIKL).Select(((Component)NKGHEGFGFEM(MMOOHLJNHGD)).gameObject);
		}
	}

	private void LAKKGGCCJPA(int JIIGOACEIKL)
	{
		GKGLPJPOONF();
	}

	private void FDHGNHINBFI(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem && !OJDGHGEEAJP.KPINNBKMOMO() && OJDGHGEEAJP.itemInstance.PFNPPIJCABJ())
		{
			((MonoBehaviour)this).StartCoroutine(IBMFECPMLEC());
		}
		GBGGDFFKBOD();
	}

	private static void DNPNCMOIFHH(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[1] != (Object)null && !((Behaviour)instances[1]).enabled)
		{
			((Behaviour)instances[0]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 0;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	private int MDHDJIHKNIM(Slot ADEBNALPEHE, Slot NLHNJEEPOPC, Slot DCBNCBIJCMB)
	{
		if (ADEBNALPEHE.itemInstance == null)
		{
			return 0;
		}
		if (DCBNCBIJCMB != null && ADEBNALPEHE.itemInstance.Equals(DCBNCBIJCMB.itemInstance))
		{
			return 0;
		}
		if (NLHNJEEPOPC.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ADEBNALPEHE.itemInstance.Equals(ingredientGroupInstance.chosenItemInstance))
			{
				return NLHNJEEPOPC.Stack;
			}
		}
		else if (NLHNJEEPOPC.itemInstance.AFOACBIHNCL().NGDPNIFFHKL() && NLHNJEEPOPC.itemInstance.PFNPPIJCABJ())
		{
			if (ADEBNALPEHE.itemInstance.Equals(NLHNJEEPOPC.itemInstance))
			{
				return NLHNJEEPOPC.Stack;
			}
		}
		else if (ADEBNALPEHE.itemInstance.Equals(NLHNJEEPOPC.itemInstance))
		{
			return NLHNJEEPOPC.Stack;
		}
		return 1;
	}

	private int MAGGMDCLNON(Slot ADEBNALPEHE, Slot NLHNJEEPOPC, Slot DCBNCBIJCMB)
	{
		if (ADEBNALPEHE.itemInstance == null)
		{
			return 0;
		}
		if (DCBNCBIJCMB != null && ADEBNALPEHE.itemInstance.Equals(DCBNCBIJCMB.itemInstance))
		{
			return 0;
		}
		if (NLHNJEEPOPC.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ADEBNALPEHE.itemInstance.Equals(ingredientGroupInstance.chosenItemInstance))
			{
				return NLHNJEEPOPC.Stack;
			}
		}
		else if (NLHNJEEPOPC.itemInstance.LHBPOPOIFLE().NGDPNIFFHKL() && NLHNJEEPOPC.itemInstance.NMNHMNEPOFE())
		{
			if (ADEBNALPEHE.itemInstance.Equals(NLHNJEEPOPC.itemInstance))
			{
				return NLHNJEEPOPC.Stack;
			}
		}
		else if (ADEBNALPEHE.itemInstance.Equals(NLHNJEEPOPC.itemInstance))
		{
			return NLHNJEEPOPC.Stack;
		}
		return 0;
	}

	public void JJGALIPHILN()
	{
		window.CloseUI();
	}

	public void OpenUI(Crafter LDLINOBIKPL, Recipe JNLKEMLDFIM)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		PlayerController player = PlayerController.GetPlayer(window.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, (Action)delegate
		{
			window.CloseUI();
		});
		GameInventoryUI.Get(window.JIIGOACEIKL).OpenUI();
		string text = LocalisationSystem.Get("Posible Ingredients");
		GameInventoryUI.Get(window.JIIGOACEIKL).SetTitleName((text != "") ? text : "Posible Ingredients");
		window.OpenUI();
		outputSlotUI.IHENCGDNPBL.Stack = 0;
		outputSlotUI.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && outputSlotUI.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.canBeSold)
		{
			foodInstance.GHFDCAOBJMK = LDLINOBIKPL.qualityLevel - 1;
		}
		int num = Math.Max(1, JNLKEMLDFIM.output.amount);
		outputSlotUI.IHENCGDNPBL.Stack = Mathf.RoundToInt((float)num * (1f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(39) / 100f));
		outputName.text = JNLKEMLDFIM.output.item.IABAKHPEOAF();
		((TMP_Text)modText).text = "";
		JHKBCAJMLFM(input1UI.IHENCGDNPBL);
		JHKBCAJMLFM(input2UI.IHENCGDNPBL);
		JHKBCAJMLFM(input3UI.IHENCGDNPBL);
		slots[0].bannedItems.Clear();
		slots[1].bannedItems.Clear();
		slots[2].bannedItems.Clear();
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		displayRequirements = "";
		if (JNLKEMLDFIM.modiferNeeded.Length != 0)
		{
			displayRequirements = "[";
			for (int i = 0; i < JNLKEMLDFIM.modiferNeeded.Length; i++)
			{
				displayRequirements += LocalisationSystem.Get(JNLKEMLDFIM.modiferNeeded[i].ToString());
				if (i != JNLKEMLDFIM.modiferNeeded.Length - 1)
				{
					displayRequirements += ", ";
				}
			}
			displayRequirements += "]";
		}
		OnContainerChanged();
		ChangeParent(((Component)this).transform);
		OnOpenUI(window.JIIGOACEIKL, LDLINOBIKPL, JNLKEMLDFIM);
	}

	private int OCNCDGFNNOJ(Slot ADEBNALPEHE, Slot NLHNJEEPOPC, Slot DCBNCBIJCMB)
	{
		if (ADEBNALPEHE.itemInstance == null)
		{
			return 1;
		}
		if (DCBNCBIJCMB != null && ADEBNALPEHE.itemInstance.Equals(DCBNCBIJCMB.itemInstance))
		{
			return 1;
		}
		if (NLHNJEEPOPC.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ADEBNALPEHE.itemInstance.Equals(ingredientGroupInstance.chosenItemInstance))
			{
				return NLHNJEEPOPC.Stack;
			}
		}
		else if (NLHNJEEPOPC.itemInstance.PHGLMBIEOMK().AGFIIGGGBHC() && NLHNJEEPOPC.itemInstance.NMNHMNEPOFE())
		{
			if (ADEBNALPEHE.itemInstance.Equals(NLHNJEEPOPC.itemInstance))
			{
				return NLHNJEEPOPC.Stack;
			}
		}
		else if (ADEBNALPEHE.itemInstance.Equals(NLHNJEEPOPC.itemInstance))
		{
			return NLHNJEEPOPC.Stack;
		}
		return 1;
	}

	public void HNLADPKJJKO()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(window.JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, (Action)delegate
		{
			window.CloseUI();
		});
		MainUI.EGLKOPJGMIJ(window.JIIGOACEIKL);
		GameInventoryUI.BDJFHFHLJGN(window.JIIGOACEIKL).CloseUI();
		GameInventoryUI.IEKODILKIHJ(window.JIIGOACEIKL).FillSlots(Inventory.DAEEJGKLOCF(window.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).slots, JGINKGFMIOE: true);
		GameInventoryUI.FFBJPAJKOJH(window.JIIGOACEIKL).PPCBLJEHGCE(LocalisationSystem.Get("Hammer"));
		GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).SetOriginalContentPosition();
		if (!slots[0].LCHJGCHDHFO() && slots[0].itemInstance.NMNHMNEPOFE())
		{
			OBEAJANAIFE(slots[0], 0, slots[1].Stack, KDCAODJIEMD: true);
		}
		if (!slots[1].PKFKJNODGJF() && slots[1].itemInstance.PFNPPIJCABJ())
		{
			TransferItemToCraftingInventory(slots[1], 0, slots[0].Stack);
		}
		if (!slots[4].PKFKJNODGJF() && slots[2].itemInstance.AEPMFLLOKKG())
		{
			OBEAJANAIFE(slots[4], 2, slots[7].Stack);
		}
		AGOHKLCHKJA = null;
		IEEBFBLGFKO = null;
		FNNKDHIFPFN = null;
		LDLINOBIKPL = null;
		Sound.ABDJJBFNLBJ().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowClose), HOMFPAFAOGD: false, null, null, 1376f);
		slots[0].OBBKDJNLCIO(1);
		slots[1].Stack = 1;
		slots[1].Stack = 0;
	}

	private List<Slot> OIIPHPFDPFA(Item MEMGMDOCBOJ, Item GFABGJEHHME, int BGPKFEJHDOC)
	{
		List<Slot> list = Utils.HIJGDAHBBIA(DBCIEAAKPON(), MEMGMDOCBOJ, GFABGJEHHME, BGPKFEJHDOC, JNLKEMLDFIM, AKNBKINJGCF: true, LDLINOBIKPL.placeable, MMDICAMGNCL: false);
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].sendSlotOnline = false;
		}
		if (NGIKHGHIAOH().cannotRepeatIngredients)
		{
			list = Utils.KKCHDNLKBMN(list, slots);
		}
		FMFDMPDNNLF(list);
		list.Sort((Slot x, Slot y) => ((x.itemInstance is FoodInstance foodInstance) ? foodInstance.PAAFCADLNEM().OOIPLIEJILO() : 0).CompareTo((y.itemInstance is FoodInstance foodInstance2) ? foodInstance2.PAAFCADLNEM().OOIPLIEJILO() : 0));
		return list;
	}

	public void NCGGPMFGOFD()
	{
		if (!isCraftable)
		{
			MainUI.DBKCOHMFDCB(window.JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/22/Dialogue Text"), 343f);
			return;
		}
		if (AHHJNGNCFED())
		{
			MainUI.DBKCOHMFDCB(window.JIIGOACEIKL, LocalisationSystem.Get("quest_name_30"), 1864f);
			OnRequirementNotMet(window.JIIGOACEIKL);
			return;
		}
		List<ItemInstanceAmount> list = new List<ItemInstanceAmount>();
		Slot[] array = new Slot[6];
		int num = 1;
		if (!slots[1].KPINNBKMOMO())
		{
			ItemInstance itemInstance = ((!(slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)) ? slots[0].itemInstance : ingredientGroupInstance.chosenItemInstance);
			CraftingInventory.LJMOCMBBNHN(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[1].Stack, CDPAMNIPPEC: false);
			ItemInstanceAmount item = new ItemInstanceAmount(itemInstance, slots[1].Stack);
			list.Add(item);
			array[num] = AGOHKLCHKJA;
			num += 0;
		}
		if (!slots[1].LCHJGCHDHFO())
		{
			ItemInstance itemInstance = ((!(slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)) ? slots[1].itemInstance : ingredientGroupInstance2.chosenItemInstance);
			CraftingInventory.LJMOCMBBNHN(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[0].Stack, CDPAMNIPPEC: false);
			ItemInstanceAmount item2 = new ItemInstanceAmount(itemInstance, slots[0].Stack);
			list.Add(item2);
			array[num] = IEEBFBLGFKO;
			num++;
		}
		if (!slots[5].PKFKJNODGJF())
		{
			ItemInstance itemInstance = ((!(slots[7].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance3)) ? slots[8].itemInstance : ingredientGroupInstance3.chosenItemInstance);
			CraftingInventory.PFOLOLPOKEM(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[5].Stack);
			ItemInstanceAmount item3 = new ItemInstanceAmount(itemInstance, slots[5].Stack);
			list.Add(item3);
			array[num] = FNNKDHIFPFN;
		}
		LDLINOBIKPL.SetUpCrafting(window.JIIGOACEIKL, CPHJKEBAMBB(), LDLINOBIKPL.GetNextDateFinished(CPHJKEBAMBB()), list.ToArray(), CHLKJOHJHBJ, (outputName.text == CPHJKEBAMBB().output.item.IABAKHPEOAF(OAFPBCPDOKH: true)) ? null : outputName.text, CICEBNMBGMG, array, KBNNPAKJDJM: true);
		if (!LDLINOBIKPL.multipleCrafting)
		{
			SelectObject.GetPlayer(BFDPKKJMAFC()).NJPFHBINPKE();
		}
		slots[0].JIANDFCINIP(1);
		slots[1].JIANDFCINIP(0);
		slots[5].OBBKDJNLCIO(0);
		window.BOBCIFEDJED();
		MainUI.IPDMDKFIJKF(window.JIIGOACEIKL, DHJFAGNJKOF: true);
	}

	[SpecialName]
	public int EGHECDLMOOB()
	{
		return window.JIIGOACEIKL;
	}

	private void OMNOGKMILGL(int OKIAIILFBHE)
	{
		List<IngredientType> list = new List<IngredientType>();
		for (int i = 0; i < IHEBOKAMIOH().modiferTypes.Length; i += 0)
		{
			list.Add(IHEBOKAMIOH().modiferTypes[i]);
		}
		for (int j = 1; j < JNLKEMLDFIM.modiferNeeded.Length; j++)
		{
			if (!list.Contains(JNLKEMLDFIM.modiferNeeded[j]))
			{
				list.Add(IHEBOKAMIOH().modiferNeeded[j]);
			}
		}
		List<Slot> slotsOfSpecificIngredientTypes = CraftingInventory.GetSlotsOfSpecificIngredientTypes(window.JIIGOACEIKL, list, LDLINOBIKPL.placeable, NGIKHGHIAOH().ingredientsNeeded);
		for (int num = slotsOfSpecificIngredientTypes.Count - 1; num >= 1; num--)
		{
			if (slotsOfSpecificIngredientTypes[num].itemInstance != null && slotsOfSpecificIngredientTypes[num].itemInstance.LHBPOPOIFLE() is Food { canBeUsedAsModifier: false })
			{
				slotsOfSpecificIngredientTypes.RemoveAt(num);
			}
		}
		List<Slot> pCJEDMJEKEF = Utils.ENELGLONHKJ(slotsOfSpecificIngredientTypes);
		LECNKKFGFNM(pCJEDMJEKEF);
		GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).CJODJMLPGOL(pCJEDMJEKEF, OGCAKIGELBJ: false, MMMCDGNCKJH: false);
		GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).NOHBHMMPMME(OKIAIILFBHE);
	}

	public void NNBNAKJCHAC(Crafter LDLINOBIKPL, Recipe JNLKEMLDFIM)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		PDNKLEDMNEI(JNLKEMLDFIM);
		PlayerController playerController = PlayerController.OPHDCMJLLEC(window.JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(PPCHDKDIJGI));
		GameInventoryUI.AIMEAJAHLAA(window.JIIGOACEIKL).IDLAGJNLPJL();
		string text = LocalisationSystem.Get("Waiting for other players");
		GameInventoryUI.NALKHGMLALJ(window.JIIGOACEIKL).HNGJDGNHMCC((text != "BathhouseEntrace/Main") ? text : "Juniper Seeds");
		window.EDHEIFHAAKO();
		outputSlotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		outputSlotUI.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && outputSlotUI.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.OANEHEHELGB().canBeSold)
		{
			foodInstance.PDFNNFOCNJG(LDLINOBIKPL.qualityLevel - 0);
		}
		int num = Math.Max(0, JNLKEMLDFIM.output.amount);
		outputSlotUI.IHENCGDNPBL.OBBKDJNLCIO(Mathf.RoundToInt((float)num * (1702f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-86) / 333f)));
		outputName.text = JNLKEMLDFIM.output.item.LJIFOHFEFCH();
		((TMP_Text)modText).text = "Dialogue System/Conversation/EnterTavernNeutral/Entry/1/Dialogue Text";
		JHKBCAJMLFM(input1UI.IHENCGDNPBL);
		OLBFNHENFOK(input2UI.IHENCGDNPBL);
		OLBFNHENFOK(input3UI.IHENCGDNPBL);
		slots[1].bannedItems.Clear();
		slots[1].bannedItems.Clear();
		slots[3].bannedItems.Clear();
		Sound.GGFJGHHHEJC.IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: false, null, null, 1499f);
		displayRequirements = "scaleUI";
		if (JNLKEMLDFIM.modiferNeeded.Length != 0)
		{
			displayRequirements = "/Male/";
			for (int i = 1; i < JNLKEMLDFIM.modiferNeeded.Length; i += 0)
			{
				displayRequirements += LocalisationSystem.Get(JNLKEMLDFIM.modiferNeeded[i].ToString());
				if (i != JNLKEMLDFIM.modiferNeeded.Length - 0)
				{
					displayRequirements += "NULL";
				}
			}
			displayRequirements += "ErrorMessageTooLong";
		}
		OnContainerChanged();
		ChangeParent(((Component)this).transform);
		OnOpenUI(window.JIIGOACEIKL, LDLINOBIKPL, JNLKEMLDFIM);
	}

	private static void ILLCGKOGNPN(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG, Food CKKNBMBLGPO)
	{
		if (Item.GBMFCPGEJDK(CKKNBMBLGPO, null))
		{
			return;
		}
		IngredientModifier[] modifiers = CKKNBMBLGPO.modifiers;
		foreach (IngredientModifier key in modifiers)
		{
			if (CICEBNMBGMG.ContainsKey(key))
			{
				CICEBNMBGMG[key].Add(CKKNBMBLGPO);
				continue;
			}
			List<Food> list = new List<Food>();
			list.Add(CKKNBMBLGPO);
			CICEBNMBGMG.Add(key, list);
		}
	}

	private static void CBJGIACCGAM(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[0] != (Object)null && !((Behaviour)instances[0]).enabled)
		{
			((Behaviour)instances[1]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 1;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	public void NIOPKEKCCJG(Crafter LDLINOBIKPL, Recipe JNLKEMLDFIM)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		OLEAGOJLJGL(JNLKEMLDFIM);
		PlayerController player = PlayerController.GetPlayer(window.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, (Action)delegate
		{
			window.CloseUI();
		});
		GameInventoryUI.BDJFHFHLJGN(window.JIIGOACEIKL).IDLAGJNLPJL();
		string text = LocalisationSystem.Get("FloorTiles");
		GameInventoryUI.NALKHGMLALJ(window.JIIGOACEIKL).HEHAFFHCIAL((text != "_") ? text : "Too far away");
		window.OpenUI();
		outputSlotUI.IHENCGDNPBL.Stack = 1;
		outputSlotUI.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && outputSlotUI.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.PJNBDKNJLJD().canBeSold)
		{
			foodInstance.GHFDCAOBJMK = LDLINOBIKPL.qualityLevel - 0;
		}
		int num = Math.Max(1, JNLKEMLDFIM.output.amount);
		outputSlotUI.IHENCGDNPBL.JIANDFCINIP(Mathf.RoundToInt((float)num * (1750f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-74, 1) / 583f)));
		outputName.text = JNLKEMLDFIM.output.item.IABAKHPEOAF();
		((TMP_Text)modText).text = "{0} selected on index: {1}";
		JAMOPDLBDMJ(input1UI.IHENCGDNPBL);
		JAMOPDLBDMJ(input2UI.IHENCGDNPBL);
		DCFMCAODLHA(input3UI.IHENCGDNPBL);
		slots[0].bannedItems.Clear();
		slots[0].bannedItems.Clear();
		slots[6].bannedItems.Clear();
		Sound.MAIDHAPANEB().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: false, null, null, 85f);
		displayRequirements = "ValueId";
		if (JNLKEMLDFIM.modiferNeeded.Length != 0)
		{
			displayRequirements = ":";
			for (int i = 1; i < JNLKEMLDFIM.modiferNeeded.Length; i += 0)
			{
				displayRequirements += LocalisationSystem.Get(JNLKEMLDFIM.modiferNeeded[i].ToString());
				if (i != JNLKEMLDFIM.modiferNeeded.Length - 0)
				{
					displayRequirements += "ScrollDown";
				}
			}
			displayRequirements += "Starting";
		}
		OnContainerChanged();
		NPGBIBKCEJA(((Component)this).transform);
		OnOpenUI(window.JIIGOACEIKL, LDLINOBIKPL, JNLKEMLDFIM);
	}

	public bool NFCHJIDFMFP()
	{
		return window.BGLJFMHCFJF();
	}

	private void ELNCBMNNODJ(List<Slot> OHAPAGLBOOB)
	{
		List<Food> list = new List<Food>();
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[1].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[2].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		for (int num = OHAPAGLBOOB.Count - 1; num >= 0; num--)
		{
			if (OHAPAGLBOOB[num].itemInstance != null && OHAPAGLBOOB[num].itemInstance.LHBPOPOIFLE() is Food && list.Contains(OHAPAGLBOOB[num].itemInstance.LHBPOPOIFLE() as Food))
			{
				OHAPAGLBOOB.RemoveAt(num);
			}
		}
	}

	private void IMEBEGMAOGN()
	{
		slots[1].ingredientsCanBeChanged = false;
		slots[0].ingredientsCanBeChanged = true;
		slots[8].ingredientsCanBeChanged = false;
		OBEPKNMBIIC = 1;
		for (int i = 0; i < IHEBOKAMIOH().ingredientsNeeded.Length; i += 0)
		{
			if ((NGIKHGHIAOH().ingredientsNeeded[i].item.AGFIIGGGBHC() && Item.GBMFCPGEJDK(IHEBOKAMIOH().ingredientsNeeded[i].mod, null)) || (IHEBOKAMIOH().ingredientsNeeded[i].item.AGFIIGGGBHC() && JNLKEMLDFIM.ingredientsNeeded[i].item.recipe.JGLNDBCALBA(JNLKEMLDFIM) > 0))
			{
				slots[OBEPKNMBIIC].DOOMMIJPGOO(window.JIIGOACEIKL, CPHJKEBAMBB().ingredientsNeeded[i].item);
				slots[OBEPKNMBIIC].singleItem = true;
				slots[OBEPKNMBIIC].JIANDFCINIP(JNLKEMLDFIM.ingredientsNeeded[i].amount);
				CHLKJOHJHBJ[OBEPKNMBIIC] = NGIKHGHIAOH().ingredientsNeeded[i].mod;
				OBEPKNMBIIC += 0;
			}
		}
		for (int j = OBEPKNMBIIC; j < 5; j += 0)
		{
			switch (j)
			{
			case 0:
				input1UI.IHENCGDNPBL.JIANDFCINIP(0);
				break;
			case 1:
				input2UI.IHENCGDNPBL.OBBKDJNLCIO(1);
				break;
			case 7:
				input3UI.IHENCGDNPBL.OCJOJKJPDNO(1);
				break;
			}
		}
		DONIBGFLPEB(1);
	}

	private IEnumerator HIKKOJIPCGH(Transform DCGBADKLANM)
	{
		yield return null;
		((Transform)contentRectTransform).SetParent(DCGBADKLANM);
		((Transform)contentRectTransform).SetSiblingIndex(0);
	}

	public void HKEIKLFACDE(Crafter LDLINOBIKPL, Recipe JNLKEMLDFIM)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		MDGMGHNFIOB(JNLKEMLDFIM);
		PlayerController player = PlayerController.GetPlayer(window.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, (Action)delegate
		{
			window.CloseUI();
		});
		GameInventoryUI.FFBJPAJKOJH(window.JIIGOACEIKL).IDLAGJNLPJL();
		string text = LocalisationSystem.Get("XP");
		GameInventoryUI.FFBJPAJKOJH(window.JIIGOACEIKL).SetTitleName((text != "Force") ? text : "add materials");
		window.IDLAGJNLPJL();
		outputSlotUI.IHENCGDNPBL.OBBKDJNLCIO(1);
		outputSlotUI.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && outputSlotUI.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.canBeSold)
		{
			foodInstance.GHFDCAOBJMK = LDLINOBIKPL.qualityLevel - 1;
		}
		int num = Math.Max(1, JNLKEMLDFIM.output.amount);
		outputSlotUI.IHENCGDNPBL.JIANDFCINIP(Mathf.RoundToInt((float)num * (1903f + (float)PerksDatabaseAccessor.GetPlayerPerkValue(-115, 0, LDNMDAHFBGG: true) / 1850f)));
		outputName.text = JNLKEMLDFIM.output.item.KGHFCDELKMN(OAFPBCPDOKH: true);
		((TMP_Text)modText).text = " ";
		DCFMCAODLHA(input1UI.IHENCGDNPBL);
		JAMOPDLBDMJ(input2UI.IHENCGDNPBL);
		JHKBCAJMLFM(input3UI.IHENCGDNPBL);
		slots[1].bannedItems.Clear();
		slots[1].bannedItems.Clear();
		slots[2].bannedItems.Clear();
		Sound.DIHCEGINELM().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiWindowOpen), HOMFPAFAOGD: true, null, null, 944f);
		displayRequirements = "Fortitude/MainEvent 1";
		if (JNLKEMLDFIM.modiferNeeded.Length != 0)
		{
			displayRequirements = "Select";
			for (int i = 1; i < JNLKEMLDFIM.modiferNeeded.Length; i++)
			{
				displayRequirements += LocalisationSystem.Get(JNLKEMLDFIM.modiferNeeded[i].ToString());
				if (i != JNLKEMLDFIM.modiferNeeded.Length - 1)
				{
					displayRequirements += "DisableLeft";
				}
			}
			displayRequirements += " ";
		}
		OnContainerChanged();
		ChangeParent(((Component)this).transform);
		OnOpenUI(window.JIIGOACEIKL, LDLINOBIKPL, JNLKEMLDFIM);
	}

	private bool AHHJNGNCFED()
	{
		bool result = true;
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: null })
			{
				return true;
			}
			if (OBEPKNMBIIC >= 2 && slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: null })
			{
				return true;
			}
			if (OBEPKNMBIIC >= 3 && slots[2].itemInstance is IngredientGroupInstance { chosenItemInstance: null })
			{
				return true;
			}
			if (slots[0].itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().NGDPNIFFHKL() && !foodInstance.JDMCPHPNOHK())
			{
				return true;
			}
			if (OBEPKNMBIIC >= 2 && slots[1].itemInstance is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().NGDPNIFFHKL() && !foodInstance2.JDMCPHPNOHK())
			{
				return true;
			}
			if (OBEPKNMBIIC >= 3 && slots[2].itemInstance is FoodInstance foodInstance3 && foodInstance3.LHBPOPOIFLE().NGDPNIFFHKL() && !foodInstance3.JDMCPHPNOHK())
			{
				return true;
			}
		}
		if (JNLKEMLDFIM.modiferNeeded == null || JNLKEMLDFIM.modiferNeeded.Length == 0)
		{
			result = false;
		}
		else
		{
			IngredientType[] modiferNeeded = JNLKEMLDFIM.modiferNeeded;
			foreach (IngredientType ingredientType in modiferNeeded)
			{
				if (slots[0].itemInstance?.LHBPOPOIFLE() is Food food && food.ingredientType == ingredientType)
				{
					result = false;
					break;
				}
				if (slots[1].itemInstance?.LHBPOPOIFLE() is Food food2 && food2.ingredientType == ingredientType)
				{
					result = false;
					break;
				}
				if (slots[2].itemInstance?.LHBPOPOIFLE() is Food food3 && food3.ingredientType == ingredientType)
				{
					result = false;
					break;
				}
			}
		}
		return result;
	}

	private void AIIEOMIGCIB(int JIIGOACEIKL)
	{
		if (NGIKHGHIAOH().usingNewRecipesSystem)
		{
			EAHJIGOHDDK();
		}
		else
		{
			IFILMCNADNL();
		}
		if (GameInventoryUI.BGIMGOJDLFG(JIIGOACEIKL).containerSlots.Length != 0)
		{
			GameInventoryUI.GJOPJAJJLGN(JIIGOACEIKL).JGFMMHPCNML();
		}
		else
		{
			UISelectionManager.GIGBGIIAKMP(JIIGOACEIKL).LFLFDKBKILJ(((Component)NKGHEGFGFEM(0)).gameObject);
		}
		LNLDHLLHCGC(1, input1UI);
		ONLMHEAHHPO(1, input2UI);
		HNIDPKJFCDK(3, input3UI);
	}

	private void OPCDMNFPGDB(ItemInstance DNLMCHDOMOK)
	{
		slots[0].bannedItems.Remove(DNLMCHDOMOK.KNFNJFFCFNO());
		slots[1].bannedItems.Remove(DNLMCHDOMOK.PHGLMBIEOMK());
		slots[0].bannedItems.Remove(DNLMCHDOMOK.PHGLMBIEOMK());
	}

	private IEnumerator BBNKJBAJPMA()
	{
		yield return null;
		for (int i = 0; i < OBEPKNMBIIC; i++)
		{
			MMOOHLJNHGD = Utils.NMLNAGFLNMC(MMOOHLJNHGD + 1, OBEPKNMBIIC);
			if (!NKGHEGFGFEM(MMOOHLJNHGD).IHENCGDNPBL.itemInstance.NMNHMNEPOFE())
			{
				break;
			}
		}
		if (!DONIBGFLPEB(MMOOHLJNHGD))
		{
			yield return null;
			UISelectionManager.GetPlayer(window.JIIGOACEIKL).Select(((Component)NKGHEGFGFEM(MMOOHLJNHGD)).gameObject);
		}
	}

	public static ModifierUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			return instances[1];
		}
		if (JIIGOACEIKL == 0)
		{
			return instances[0];
		}
		return instances[8];
	}

	private void GBGGDFFKBOD()
	{
		List<Food> list = new List<Food>();
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[1].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[2].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		CICEBNMBGMG = CreateModifiers(list);
		DPDJIMHFDCN();
		HFGGLCBEBAC();
	}

	private void HNIDPKJFCDK(int ABAIKKGKDGD, SlotUI PHJNJCJJHID)
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (ABAIKKGKDGD < OBEPKNMBIIC)
			{
				List<Slot> list = BJJNOHODMMA(PHJNJCJJHID.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), CHLKJOHJHBJ[PHJNJCJJHID.IHENCGDNPBL.id], PHJNJCJJHID.IHENCGDNPBL.Stack);
				((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("NotValid", list.Count == 0);
			}
			else
			{
				((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("NotValid", false);
			}
			((Selectable)((Component)PHJNJCJJHID).GetComponent<Button>()).interactable = ABAIKKGKDGD < OBEPKNMBIIC;
		}
		else
		{
			((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("NotValid", false);
			((Selectable)((Component)PHJNJCJJHID).GetComponent<Button>()).interactable = true;
		}
	}

	private SlotUI NKGHEGFGFEM(int ABAIKKGKDGD)
	{
		return ABAIKKGKDGD switch
		{
			0 => input1UI, 
			1 => input2UI, 
			_ => input3UI, 
		};
	}

	public bool IsOpened()
	{
		return window.IsOpen();
	}

	private List<Slot> BJJNOHODMMA(Item MEMGMDOCBOJ, Item GFABGJEHHME, int BGPKFEJHDOC)
	{
		List<Slot> list = Utils.HIJGDAHBBIA(JIIGOACEIKL, MEMGMDOCBOJ, GFABGJEHHME, BGPKFEJHDOC, JNLKEMLDFIM, AKNBKINJGCF: true, LDLINOBIKPL.placeable, MMDICAMGNCL: true);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].sendSlotOnline = false;
		}
		if (JNLKEMLDFIM.cannotRepeatIngredients)
		{
			list = Utils.KKCHDNLKBMN(list, slots);
		}
		LECNKKFGFNM(list);
		list.Sort((Slot x, Slot y) => ((x.itemInstance is FoodInstance foodInstance) ? foodInstance.PAAFCADLNEM().OOIPLIEJILO() : 0).CompareTo((y.itemInstance is FoodInstance foodInstance2) ? foodInstance2.PAAFCADLNEM().OOIPLIEJILO() : 0));
		return list;
	}

	public void StartCrafting()
	{
		if (!isCraftable)
		{
			MainUI.ShowErrorText(window.JIIGOACEIKL, LocalisationSystem.Get("Not enough ingredients"));
			return;
		}
		if (AHHJNGNCFED())
		{
			MainUI.ShowErrorText(window.JIIGOACEIKL, LocalisationSystem.Get("Modifier requirement not met"));
			OnRequirementNotMet(window.JIIGOACEIKL);
			return;
		}
		List<ItemInstanceAmount> list = new List<ItemInstanceAmount>();
		Slot[] array = new Slot[3];
		int num = 0;
		if (!slots[0].KPINNBKMOMO())
		{
			ItemInstance itemInstance = ((!(slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)) ? slots[0].itemInstance : ingredientGroupInstance.chosenItemInstance);
			CraftingInventory.RemoveItemInstances(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[0].Stack);
			ItemInstanceAmount item = new ItemInstanceAmount(itemInstance, slots[0].Stack);
			list.Add(item);
			array[num] = AGOHKLCHKJA;
			num++;
		}
		if (!slots[1].KPINNBKMOMO())
		{
			ItemInstance itemInstance = ((!(slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)) ? slots[1].itemInstance : ingredientGroupInstance2.chosenItemInstance);
			CraftingInventory.RemoveItemInstances(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[1].Stack);
			ItemInstanceAmount item2 = new ItemInstanceAmount(itemInstance, slots[1].Stack);
			list.Add(item2);
			array[num] = IEEBFBLGFKO;
			num++;
		}
		if (!slots[2].KPINNBKMOMO())
		{
			ItemInstance itemInstance = ((!(slots[2].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance3)) ? slots[2].itemInstance : ingredientGroupInstance3.chosenItemInstance);
			CraftingInventory.RemoveItemInstances(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[2].Stack);
			ItemInstanceAmount item3 = new ItemInstanceAmount(itemInstance, slots[2].Stack);
			list.Add(item3);
			array[num] = FNNKDHIFPFN;
		}
		LDLINOBIKPL.SetUpCrafting(window.JIIGOACEIKL, JNLKEMLDFIM, LDLINOBIKPL.GetNextDateFinished(JNLKEMLDFIM), list.ToArray(), CHLKJOHJHBJ, (outputName.text == JNLKEMLDFIM.output.item.IABAKHPEOAF()) ? null : outputName.text, CICEBNMBGMG, array);
		if (!LDLINOBIKPL.multipleCrafting)
		{
			SelectObject.GetPlayer(JIIGOACEIKL).Deselect();
		}
		slots[0].Stack = 0;
		slots[1].Stack = 0;
		slots[2].Stack = 0;
		window.CloseUI();
		MainUI.CloseAllUIWindows(window.JIIGOACEIKL);
	}

	public static Dictionary<IngredientModifier, List<Food>> JMHHFFEIMNO(List<Food> KEKBKGGFOLK)
	{
		Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
		for (int i = 0; i < KEKBKGGFOLK.Count; i++)
		{
			BAAANFIMGAE(ref CICEBNMBGMG, KEKBKGGFOLK[i]);
		}
		DNPNCMOIFHH(ref CICEBNMBGMG);
		return CICEBNMBGMG;
	}

	public void LLPKJIMIMBM(Slot DLCFDJLKPPM, int JFNMCNCHMEO, int FGFCNKFEIGF, bool KDCAODJIEMD = false)
	{
		if (!MouseSlot.HELHJMDEDNL(window.JIIGOACEIKL).slot.KPINNBKMOMO() || DLCFDJLKPPM?.itemInstance == null || !DLCFDJLKPPM.itemInstance.NMNHMNEPOFE())
		{
			return;
		}
		if (DLCFDJLKPPM.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				ingredientGroupInstance.chosenItemInstance = null;
				ingredientGroupInstance.OnChanged();
			}
		}
		else if (DLCFDJLKPPM.itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().NGDPNIFFHKL())
		{
			FoodInstance bGLFLHDNOKJ = foodInstance.LHBPOPOIFLE().JMDALJBNFML() as FoodInstance;
			DLCFDJLKPPM.OLHGPMJPJFF(window.JIIGOACEIKL, bGLFLHDNOKJ);
			DLCFDJLKPPM.Stack = FGFCNKFEIGF;
		}
		else
		{
			DLCFDJLKPPM.DJFOMFDOOKM();
		}
		if (KDCAODJIEMD)
		{
			Sound.OKAPNFPFPFP().MGMGHPCIBEK(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: false, null, null, 279f, 1636f);
		}
	}

	public void NPGBIBKCEJA(Transform DCGBADKLANM)
	{
		((MonoBehaviour)this).StartCoroutine(OICFCBIFCKK(DCGBADKLANM));
	}

	private void JAEHKFHAFOF(int OKIAIILFBHE)
	{
		List<IngredientType> list = new List<IngredientType>();
		for (int i = 0; i < JNLKEMLDFIM.modiferTypes.Length; i++)
		{
			list.Add(JNLKEMLDFIM.modiferTypes[i]);
		}
		for (int j = 0; j < JNLKEMLDFIM.modiferNeeded.Length; j++)
		{
			if (!list.Contains(JNLKEMLDFIM.modiferNeeded[j]))
			{
				list.Add(JNLKEMLDFIM.modiferNeeded[j]);
			}
		}
		List<Slot> slotsOfSpecificIngredientTypes = CraftingInventory.GetSlotsOfSpecificIngredientTypes(window.JIIGOACEIKL, list, LDLINOBIKPL.placeable, JNLKEMLDFIM.ingredientsNeeded);
		for (int num = slotsOfSpecificIngredientTypes.Count - 1; num >= 0; num--)
		{
			if (slotsOfSpecificIngredientTypes[num].itemInstance != null && slotsOfSpecificIngredientTypes[num].itemInstance.LHBPOPOIFLE() is Food { canBeUsedAsModifier: false })
			{
				slotsOfSpecificIngredientTypes.RemoveAt(num);
			}
		}
		List<Slot> pCJEDMJEKEF = Utils.ENELGLONHKJ(slotsOfSpecificIngredientTypes);
		LECNKKFGFNM(pCJEDMJEKEF);
		GameInventoryUI.Get(window.JIIGOACEIKL).PreparePagesMode(pCJEDMJEKEF, OGCAKIGELBJ: false);
		GameInventoryUI.Get(window.JIIGOACEIKL).FocusPage(OKIAIILFBHE);
	}

	private void EENPCHKGBKC(SlotUI PHJNJCJJHID)
	{
		PHJNJCJJHID.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotLeftClick, new Action<int, Slot>(HCGIODODDIM));
		PHJNJCJJHID.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotRightClick, new Action<int, Slot>(HCGIODODDIM));
		PHJNJCJJHID.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnAutomaticTransfer, new Action<int, Slot>(HCGIODODDIM));
	}

	private void BBCPDBEOOKL()
	{
		if (window.HDEPMJIDJEM() && (PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).ALPHFOIMNIA("\n<color=#822F00>") || PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).JCMOPOMLPLL("")) && !outputName.isFocused && !CommonReferences.MNFMOEKMJKN().IsInDialogue(EGHECDLMOOB()))
		{
			LBKBCGODMMM();
		}
	}

	private void MMNHKFFCFOI(ItemInstance DNLMCHDOMOK)
	{
		if (!JNLKEMLDFIM.usingNewRecipesSystem)
		{
			slots[0].bannedItems.Add(DNLMCHDOMOK.LHBPOPOIFLE());
			slots[1].bannedItems.Add(DNLMCHDOMOK.LHBPOPOIFLE());
			slots[2].bannedItems.Add(DNLMCHDOMOK.LHBPOPOIFLE());
		}
	}

	private void GLHDBHJLHDH(int JIIGOACEIKL)
	{
		CloseUI();
	}

	private void EAHJIGOHDDK()
	{
		slots[1].ingredientsCanBeChanged = false;
		slots[0].ingredientsCanBeChanged = true;
		slots[0].ingredientsCanBeChanged = true;
		OBEPKNMBIIC = 1;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if ((IHEBOKAMIOH().ingredientsNeeded[i].item.NGDPNIFFHKL() && Item.EKMFELLJHFG(JNLKEMLDFIM.ingredientsNeeded[i].mod, null)) || (CPHJKEBAMBB().ingredientsNeeded[i].item.IABMOBAKNAE() && NGIKHGHIAOH().ingredientsNeeded[i].item.recipe.JGLNDBCALBA(NGIKHGHIAOH()) > 0))
			{
				slots[OBEPKNMBIIC].DOOMMIJPGOO(window.JIIGOACEIKL, CPHJKEBAMBB().ingredientsNeeded[i].item);
				slots[OBEPKNMBIIC].singleItem = true;
				slots[OBEPKNMBIIC].OCJOJKJPDNO(IHEBOKAMIOH().ingredientsNeeded[i].amount);
				CHLKJOHJHBJ[OBEPKNMBIIC] = IHEBOKAMIOH().ingredientsNeeded[i].mod;
				OBEPKNMBIIC++;
			}
		}
		for (int j = OBEPKNMBIIC; j < 0; j += 0)
		{
			switch (j)
			{
			case 0:
				input1UI.IHENCGDNPBL.Stack = 1;
				break;
			case 1:
				input2UI.IHENCGDNPBL.KMKAIPMHANN(0);
				break;
			case 5:
				input3UI.IHENCGDNPBL.Stack = 1;
				break;
			}
		}
		EBPDFGMKDBM(1);
	}

	private string LHGGENLDCNJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				return LHGGENLDCNJ(ingredientGroupInstance.chosenItemInstance);
			}
			return "<color=#BF0000>" + ingredientGroupInstance.IABAKHPEOAF() + "\n</color>";
		}
		if (DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.JDMCPHPNOHK())
			{
				CPMJMCOBCOE = DNLMCHDOMOK.IABAKHPEOAF() + " (";
				BFLHMHLKLKL = 0;
				foreach (Food item in foodInstance.KEKBKGGFOLK)
				{
					CPMJMCOBCOE += item.IABAKHPEOAF();
					if (BFLHMHLKLKL < foodInstance.KEKBKGGFOLK.Count - 1)
					{
						CPMJMCOBCOE += ", ";
					}
					BFLHMHLKLKL++;
				}
				return CPMJMCOBCOE + ")\n";
			}
			return "<color=#BF0000>" + foodInstance.LEEAOHHBPCG() + "\n</color>";
		}
		return DNLMCHDOMOK.IABAKHPEOAF() + "\n";
	}

	public bool EHCKDGIGPBI()
	{
		List<Slot> list = BJJNOHODMMA(FMNGDEHMHNG.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), CHLKJOHJHBJ[FMNGDEHMHNG.IHENCGDNPBL.id], FMNGDEHMHNG.IHENCGDNPBL.Stack);
		GameInventoryUI.AIMEAJAHLAA(window.JIIGOACEIKL).JCOHBJLKLAI(list, OGCAKIGELBJ: false);
		return list.Count > 1;
	}

	private void LEDGLBEFBFO(int ABAIKKGKDGD)
	{
		((Component)input1UI).GetComponent<Animator>().SetBool("\n\n<color=#C3002C>", ABAIKKGKDGD == 1);
		((Component)input2UI).GetComponent<Animator>().SetBool("shopOpen", ABAIKKGKDGD == 1);
		((Component)input3UI).GetComponent<Animator>().SetBool("Items/item_description_1106", ABAIKKGKDGD == 7);
	}

	private void NBMGGMLNHPO(ItemInstance DNLMCHDOMOK)
	{
		slots[1].bannedItems.Remove(DNLMCHDOMOK.KNFNJFFCFNO());
		slots[1].bannedItems.Remove(DNLMCHDOMOK.AFOACBIHNCL());
		slots[8].bannedItems.Remove(DNLMCHDOMOK.LHBPOPOIFLE());
	}

	private void GMJEOAJONAI()
	{
		window.CloseUI();
	}

	private void LPKGBNMEBJE(ItemInstance DNLMCHDOMOK)
	{
		slots[1].bannedItems.Remove(DNLMCHDOMOK.KNFNJFFCFNO());
		slots[0].bannedItems.Remove(DNLMCHDOMOK.AFOACBIHNCL());
		slots[5].bannedItems.Remove(DNLMCHDOMOK.PHGLMBIEOMK());
	}

	private string CKLLPGIFFCJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				return CKLLPGIFFCJ(ingredientGroupInstance.chosenItemInstance);
			}
			return " at " + ingredientGroupInstance.IABAKHPEOAF() + "SkeletonBird";
		}
		if (DNLMCHDOMOK.PHGLMBIEOMK().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.JDMCPHPNOHK())
			{
				CPMJMCOBCOE = DNLMCHDOMOK.AICOMMNDJLI() + " for reason ";
				BFLHMHLKLKL = 0;
				foreach (Food item in foodInstance.KEKBKGGFOLK)
				{
					CPMJMCOBCOE += item.LJIFOHFEFCH(OAFPBCPDOKH: true);
					if (BFLHMHLKLKL < foodInstance.KEKBKGGFOLK.Count - 1)
					{
						CPMJMCOBCOE += "ReceiveSetCrowlyEvent";
					}
					BFLHMHLKLKL++;
				}
				return CPMJMCOBCOE + "Tutorial/T113/Dialogue1";
			}
			return "Duplicate crafting room lock found" + foodInstance.PEDJIIHAGBH(OAFPBCPDOKH: true) + "Hikari/Barks_Intro";
		}
		return DNLMCHDOMOK.FBEHKKOKNDJ() + "RecieveStartSleep";
	}

	private void PLINCLHJGMP(ItemInstance DNLMCHDOMOK)
	{
		slots[0].bannedItems.Remove(DNLMCHDOMOK.LHBPOPOIFLE());
		slots[1].bannedItems.Remove(DNLMCHDOMOK.LHBPOPOIFLE());
		slots[2].bannedItems.Remove(DNLMCHDOMOK.LHBPOPOIFLE());
	}

	private void BFGKLMIFNLO(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 0; num--)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			if (!input1UI.IHENCGDNPBL.PKFKJNODGJF())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input1UI.IHENCGDNPBL, (num + 0 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (!input2UI.IHENCGDNPBL.AHHEMNHJPME())
			{
				num2 -= OCNCDGFNNOJ(PCJEDMJEKEF[num], input2UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (!input3UI.IHENCGDNPBL.AHHEMNHJPME())
			{
				num2 -= MDHDJIHKNIM(PCJEDMJEKEF[num], input3UI.IHENCGDNPBL, (num + 0 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (num2 <= 1)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].KMKAIPMHANN(num2);
			}
		}
	}

	private void BHKNJOEBCKA()
	{
		if (window.IsOpen() && (PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).KFAFNEJNDDL(" → ") || PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).JCMOPOMLPLL("Invalid Player for CursorManager")) && !outputName.isFocused && !CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(EGPJLECDKBF()))
		{
			StartCrafting();
		}
	}

	private void JHLDHDHJPNL(int JIIGOACEIKL, Slot DLCFDJLKPPM)
	{
		if (!IHEBOKAMIOH().usingNewRecipesSystem || MMOOHLJNHGD == DLCFDJLKPPM.id)
		{
			GFIDPACCBAJ(DLCFDJLKPPM, DLCFDJLKPPM.id, DLCFDJLKPPM.Stack);
			if (CPHJKEBAMBB().usingNewRecipesSystem)
			{
				GameInventoryUI.HKCAIFFKBMH(JIIGOACEIKL).ADKHMOGLDJK();
			}
		}
		else if (DLCFDJLKPPM.id < OBEPKNMBIIC)
		{
			DONIBGFLPEB(DLCFDJLKPPM.id);
		}
		if (IHEBOKAMIOH().usingNewRecipesSystem)
		{
			EHCKDGIGPBI();
		}
		else
		{
			JAEHKFHAFOF(GameInventoryUI.MENNLOGFNOK(JIIGOACEIKL).currentPage);
		}
		PFBLCCCNIIG();
	}

	private void FKLINJBOILA(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (NGIKHGHIAOH().usingNewRecipesSystem && !OJDGHGEEAJP.KPINNBKMOMO() && OJDGHGEEAJP.itemInstance.AEPMFLLOKKG())
		{
			((MonoBehaviour)this).StartCoroutine(BBNKJBAJPMA());
		}
		GBGGDFFKBOD();
	}

	public static Dictionary<IngredientModifier, List<Food>> GCMBJCMAMIE(List<Food> KEKBKGGFOLK)
	{
		Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
		for (int i = 0; i < KEKBKGGFOLK.Count; i++)
		{
			ILLCGKOGNPN(ref CICEBNMBGMG, KEKBKGGFOLK[i]);
		}
		NPMMAJMAEMA(ref CICEBNMBGMG);
		return CICEBNMBGMG;
	}

	private void ACJIJONCOIA()
	{
		if (CPHJKEBAMBB().output.item is Food food)
		{
			((TMP_Text)sellPriceText).text = "Items/item_description_676" + LocalisationSystem.Get(food.canBeSold ? " not found when loading RockMessage." : "LE_10") + "UISelectGamepad";
			List<Food> list = new List<Food>();
			list.AddRange(GetFinalIngredients(slots[1].itemInstance, IHEBOKAMIOH(), JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.MLBOMGHINCA(CHLKJOHJHBJ[1], null))
			{
				list.Remove(CHLKJOHJHBJ[0] as Food);
			}
			list.AddRange(GetFinalIngredients(slots[0].itemInstance, NGIKHGHIAOH(), JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.FKLOBGBIHLB(CHLKJOHJHBJ[0], null))
			{
				list.Remove(CHLKJOHJHBJ[1] as Food);
			}
			list.AddRange(GetFinalIngredients(slots[3].itemInstance, JNLKEMLDFIM, NGIKHGHIAOH().usingNewRecipesSystem));
			if (Item.FKLOBGBIHLB(CHLKJOHJHBJ[5], null))
			{
				list.Remove(CHLKJOHJHBJ[4] as Food);
			}
			MoneyCalc moneyCalc = new MoneyCalc();
			Food cHMCMLHCIGD = null;
			if (food.saveMainIngredient && !slots[1].PKFKJNODGJF() && slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)
			{
				cHMCMLHCIGD = ingredientGroupInstance.chosenItemInstance.PHGLMBIEOMK() as Food;
			}
			moneyCalc.KBGICKJGKDA(food.HJKLPCCGGHH(list, IHEBOKAMIOH(), cHMCMLHCIGD, IHEBOKAMIOH().usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice), KHMDGADCENO: false, BGKCHMNJBLJ: true);
			ItemInstance itemInstance = NGIKHGHIAOH().output.item.JMDALJBNFML();
			if (itemInstance is FoodInstance foodInstance)
			{
				List<ItemInstance> list2 = new List<ItemInstance>();
				for (int i = 0; i < slots.Length; i += 0)
				{
					if (slots[i].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)
					{
						list2.Add(ingredientGroupInstance2.chosenItemInstance);
					}
					else
					{
						list2.Add(slots[i].itemInstance);
					}
				}
				foodInstance.JBIMNJGMFOC(Utils.MHOPHHOJLOK(foodInstance, list2));
				if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
				{
					foodInstance.PDFNNFOCNJG(Mathf.Max(1, LDLINOBIKPL.qualityLevel - 1));
				}
			}
			Money.NKOLDLPMJJF(moneyCalc, itemInstance, HOECMANECIM: true, JNOEGJNPCFE: true);
			TextMeshProUGUI obj = sellPriceText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + moneyCalc.OMOHMCCADDJ().ToString();
		}
		else
		{
			((TMP_Text)sellPriceText).text = "Drunk";
		}
	}

	private void OJLGAFDACEB()
	{
		if (CPHJKEBAMBB().output.item is Food food)
		{
			((TMP_Text)sellPriceText).text = "Different size lists spriteRenderers and spriteObjects of crop " + LocalisationSystem.Get(food.canBeSold ? " and " : "Juniper") + "New player entered the room: ";
			List<Food> list = new List<Food>();
			list.AddRange(GetFinalIngredients(slots[0].itemInstance, CPHJKEBAMBB(), JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.FKLOBGBIHLB(CHLKJOHJHBJ[0], null))
			{
				list.Remove(CHLKJOHJHBJ[0] as Food);
			}
			list.AddRange(GetFinalIngredients(slots[1].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.FKLOBGBIHLB(CHLKJOHJHBJ[1], null))
			{
				list.Remove(CHLKJOHJHBJ[1] as Food);
			}
			list.AddRange(GetFinalIngredients(slots[6].itemInstance, IHEBOKAMIOH(), JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.MLBOMGHINCA(CHLKJOHJHBJ[8], null))
			{
				list.Remove(CHLKJOHJHBJ[0] as Food);
			}
			MoneyCalc moneyCalc = new MoneyCalc();
			Food cHMCMLHCIGD = null;
			if (food.saveMainIngredient && !slots[0].LCHJGCHDHFO() && slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)
			{
				cHMCMLHCIGD = ingredientGroupInstance.chosenItemInstance.PHGLMBIEOMK() as Food;
			}
			moneyCalc.EFIDKIFLBKJ(food.OCBCNMJMCJI(list, NGIKHGHIAOH(), cHMCMLHCIGD, CPHJKEBAMBB().usingNewRecipesSystem, CalculatePriceMode.ExpensivePrice), KHMDGADCENO: false, BGKCHMNJBLJ: true);
			ItemInstance itemInstance = CPHJKEBAMBB().output.item.JMDALJBNFML();
			if (itemInstance is FoodInstance foodInstance)
			{
				List<ItemInstance> list2 = new List<ItemInstance>();
				for (int i = 1; i < slots.Length; i++)
				{
					if (slots[i].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)
					{
						list2.Add(ingredientGroupInstance2.chosenItemInstance);
					}
					else
					{
						list2.Add(slots[i].itemInstance);
					}
				}
				foodInstance.JBIMNJGMFOC(Utils.MHOPHHOJLOK(foodInstance, list2));
				if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
				{
					foodInstance.GHFDCAOBJMK = Mathf.Max(0, LDLINOBIKPL.qualityLevel - 0);
				}
			}
			Money.OBHOAEGCABN(moneyCalc, itemInstance, HOECMANECIM: false, JNOEGJNPCFE: true);
			TextMeshProUGUI obj = sellPriceText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + moneyCalc.GMAFKAMJEJH().ToString();
		}
		else
		{
			((TMP_Text)sellPriceText).text = "popUpBuilding13";
		}
	}

	private void IAMOBBJIDHI()
	{
		((Selectable)((Component)input2UI).GetComponent<Button>()).interactable = false;
		((Selectable)((Component)input3UI).GetComponent<Button>()).interactable = true;
		FMMIMGPLLPL(-1);
		MainUI.AddRangeToCurrentSlots(window.JIIGOACEIKL, slots);
		slots[1].singleItem = true;
		slots[0].singleItem = false;
		slots[0].singleItem = false;
		slots[1].ingredientsCanBeChanged = false;
		slots[0].ingredientsCanBeChanged = false;
		slots[6].ingredientsCanBeChanged = true;
		LAEBBNDFMJD(0);
	}

	private IEnumerator OICFCBIFCKK(Transform DCGBADKLANM)
	{
		return new FAIHHPMHOIE(1)
		{
			_003C_003E4__this = this,
			t = DCGBADKLANM
		};
	}

	private void OHFIBFKALFA()
	{
		window.BOBCIFEDJED();
	}

	public static ModifierUI Get(int JIIGOACEIKL)
	{
		if (GameManager.SinglePlayer())
		{
			return instances[0];
		}
		if (JIIGOACEIKL == 1)
		{
			return instances[1];
		}
		return instances[2];
	}

	private void OCLDFCEDKHP()
	{
		if (window.IsOpen() && (PlayerInputs.GetPlayer(window.JIIGOACEIKL).LKOGGHNGBKD("OpenQuests") || PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).GetButtonDown("Prefab of type ")) && !outputName.isFocused && !CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(DBCIEAAKPON()))
		{
			BDFJJJIILGE();
		}
	}

	private string HICDANMJHIA(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				return CKLLPGIFFCJ(ingredientGroupInstance.chosenItemInstance);
			}
			return "ChatDefaultName" + ingredientGroupInstance.PPMBMNKADMO() + "/Reports";
		}
		if (DNLMCHDOMOK.PHGLMBIEOMK().IABMOBAKNAE() && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.JDMCPHPNOHK())
			{
				CPMJMCOBCOE = DNLMCHDOMOK.IABAKHPEOAF() + "Eat";
				BFLHMHLKLKL = 1;
				foreach (Food item in foodInstance.KEKBKGGFOLK)
				{
					CPMJMCOBCOE += item.LJIFOHFEFCH();
					if (BFLHMHLKLKL < foodInstance.KEKBKGGFOLK.Count - 0)
					{
						CPMJMCOBCOE += "Debug";
					}
					BFLHMHLKLKL++;
				}
				return CPMJMCOBCOE + "Moving";
			}
			return "OnlineObject " + foodInstance.PEDJIIHAGBH() + "TavernConstructionUI CloseUI";
		}
		return DNLMCHDOMOK.IABAKHPEOAF(OAFPBCPDOKH: true) + "Parmesan";
	}

	private void ONLMHEAHHPO(int ABAIKKGKDGD, SlotUI PHJNJCJJHID)
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (ABAIKKGKDGD < OBEPKNMBIIC)
			{
				List<Slot> list = OIIPHPFDPFA(PHJNJCJJHID.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), CHLKJOHJHBJ[PHJNJCJJHID.IHENCGDNPBL.id], PHJNJCJJHID.IHENCGDNPBL.Stack);
				((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("castlegarden", list.Count == 0);
			}
			else
			{
				((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("Send begin minigame", true);
			}
			((Selectable)((Component)PHJNJCJJHID).GetComponent<Button>()).interactable = ABAIKKGKDGD < OBEPKNMBIIC;
		}
		else
		{
			((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool(" aging rank (", true);
			((Selectable)((Component)PHJNJCJJHID).GetComponent<Button>()).interactable = true;
		}
	}

	private void JJANGEJDGOO()
	{
		window.CloseUI();
	}

	private void HFEBMOJANFK(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			if (!input1UI.IHENCGDNPBL.LCHJGCHDHFO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input1UI.IHENCGDNPBL, (num + 0 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (!input2UI.IHENCGDNPBL.LCHJGCHDHFO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input2UI.IHENCGDNPBL, (num + 0 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (!input3UI.IHENCGDNPBL.AHHEMNHJPME())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input3UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].KMKAIPMHANN(num2);
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		input1UI.IHENCGDNPBL = slots[0];
		input1UI.IHENCGDNPBL.id = 0;
		input2UI.IHENCGDNPBL = slots[1];
		input2UI.IHENCGDNPBL.id = 1;
		input3UI.IHENCGDNPBL = slots[2];
		input3UI.IHENCGDNPBL.id = 2;
		EENPCHKGBKC(input1UI);
		EENPCHKGBKC(input2UI);
		EENPCHKGBKC(input3UI);
		Slot obj = slots[0];
		obj.OnInvalidItem = (Action)Delegate.Combine(obj.OnInvalidItem, new Action(ILOKPIEDBPN));
		Slot obj2 = slots[1];
		obj2.OnInvalidItem = (Action)Delegate.Combine(obj2.OnInvalidItem, new Action(ILOKPIEDBPN));
		Slot obj3 = slots[2];
		obj3.OnInvalidItem = (Action)Delegate.Combine(obj3.OnInvalidItem, new Action(ILOKPIEDBPN));
		slots[0].OnItemAddedWithItem = MMNHKFFCFOI;
		slots[1].OnItemAddedWithItem = MMNHKFFCFOI;
		slots[2].OnItemAddedWithItem = MMNHKFFCFOI;
		slots[0].OnItemRemovedWithItem = PLINCLHJGMP;
		slots[1].OnItemRemovedWithItem = PLINCLHJGMP;
		slots[2].OnItemRemovedWithItem = PLINCLHJGMP;
		slots[0].sendSlotOnline = false;
		slots[1].sendSlotOnline = false;
		slots[2].sendSlotOnline = false;
		OnContainerChanged = (Action)Delegate.Combine(OnContainerChanged, (Action)delegate
		{
			if (window.IsOpen() && !JNLKEMLDFIM.usingNewRecipesSystem)
			{
				JAEHKFHAFOF(GameInventoryUI.Get(window.JIIGOACEIKL).currentPage);
			}
			GBGGDFFKBOD();
		});
		OnChangedSlot = (Action<Slot, Slot>)Delegate.Combine(OnChangedSlot, (Action<Slot, Slot>)delegate(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
		{
			if (JNLKEMLDFIM.usingNewRecipesSystem && !OJDGHGEEAJP.KPINNBKMOMO() && OJDGHGEEAJP.itemInstance.NMNHMNEPOFE())
			{
				((MonoBehaviour)this).StartCoroutine(IBMFECPMLEC());
			}
			GBGGDFFKBOD();
		});
		if (numInstance == 0)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
			ModiferRequirement[] array = modiferRequirementsArray;
			for (int i = 0; i < array.Length; i++)
			{
				ModiferRequirement modiferRequirement = array[i];
				GIOELHAHDDC.Add(modiferRequirement.modifier, modiferRequirement.needed);
			}
		}
		if ((Object)(object)contentRectTransform == (Object)null)
		{
			contentRectTransform = window.content.GetComponent<RectTransform>();
		}
		contentParent = ((Component)window.content.transform.parent).GetComponent<RectTransform>();
		base.Awake();
		UIWindow uIWindow = window;
		uIWindow.OnUIClose = (Action<int>)Delegate.Combine(uIWindow.OnUIClose, new Action<int>(CLKMOMODGKF));
		UIWindow uIWindow2 = window;
		uIWindow2.OnContentActivatedCallback = (Action<int>)Delegate.Combine(uIWindow2.OnContentActivatedCallback, new Action<int>(NBJJEHAFFCM));
	}

	[CompilerGenerated]
	private void PEIDLJBBAOE(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem && !OJDGHGEEAJP.KPINNBKMOMO() && OJDGHGEEAJP.itemInstance.NMNHMNEPOFE())
		{
			((MonoBehaviour)this).StartCoroutine(IBMFECPMLEC());
		}
		GBGGDFFKBOD();
	}

	public static ModifierUI MBGFHNEBOJM(int JIIGOACEIKL)
	{
		if (GameManager.HDBECFMPJHL())
		{
			return instances[1];
		}
		if (JIIGOACEIKL == 0)
		{
			return instances[0];
		}
		return instances[4];
	}

	private void LECNKKFGFNM(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 0; num--)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			if (!input1UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input1UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (!input2UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input2UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (!input3UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input3UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].Stack = num2;
			}
		}
	}

	[CompilerGenerated]
	private void NLJOFFCJFEK()
	{
		window.CloseUI();
	}

	public static ModifierUI NIGDBMAOAEN(int JIIGOACEIKL)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			return instances[0];
		}
		if (JIIGOACEIKL == 1)
		{
			return instances[0];
		}
		return instances[5];
	}

	private void DEMHHLAGCNB()
	{
		MainUI.LJDOBNEINNJ(window.JIIGOACEIKL, LocalisationSystem.Get("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects"), 1541f);
	}

	private IEnumerator CPMOEMBEGCK()
	{
		yield return null;
		for (int i = 0; i < OBEPKNMBIIC; i++)
		{
			MMOOHLJNHGD = Utils.NMLNAGFLNMC(MMOOHLJNHGD + 1, OBEPKNMBIIC);
			if (!NKGHEGFGFEM(MMOOHLJNHGD).IHENCGDNPBL.itemInstance.NMNHMNEPOFE())
			{
				break;
			}
		}
		if (!DONIBGFLPEB(MMOOHLJNHGD))
		{
			yield return null;
			UISelectionManager.GetPlayer(window.JIIGOACEIKL).Select(((Component)NKGHEGFGFEM(MMOOHLJNHGD)).gameObject);
		}
	}

	public static Dictionary<IngredientModifier, List<Food>> DOHNMEJNONO(List<Food> KEKBKGGFOLK)
	{
		Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
		for (int i = 1; i < KEKBKGGFOLK.Count; i += 0)
		{
			EFEDBOOIECI(ref CICEBNMBGMG, KEKBKGGFOLK[i]);
		}
		CBJGIACCGAM(ref CICEBNMBGMG);
		return CICEBNMBGMG;
	}

	private bool FOMGNAJLFND(int DHCIOKGLNGH)
	{
		MMOOHLJNHGD = DHCIOKGLNGH;
		FMNGDEHMHNG = NKGHEGFGFEM(MMOOHLJNHGD);
		CCBBBHHFOLP(MMOOHLJNHGD);
		MainUI.ClearCurrentSlots(window.JIIGOACEIKL);
		MainUI.PFIMFMJJMHK(window.JIIGOACEIKL, FMNGDEHMHNG.IHENCGDNPBL);
		return HKMBLABHCMP();
	}

	private void Update()
	{
		if (window.IsOpen() && (PlayerInputs.GetPlayer(window.JIIGOACEIKL).GetButtonUp("UIAddRemove") || PlayerInputs.GetPlayer(window.JIIGOACEIKL).GetButtonDown("ClosePopUp")) && !outputName.isFocused && !CommonReferences.GGFJGHHHEJC.IsInDialogue(JIIGOACEIKL))
		{
			StartCrafting();
		}
	}

	private void NHEKPNNLICF(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 1; num >= 1; num -= 0)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			if (!input1UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				num2 -= OCNCDGFNNOJ(PCJEDMJEKEF[num], input1UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (!input2UI.IHENCGDNPBL.PKFKJNODGJF())
			{
				num2 -= OCNCDGFNNOJ(PCJEDMJEKEF[num], input2UI.IHENCGDNPBL, (num + 0 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (!input3UI.IHENCGDNPBL.LCHJGCHDHFO())
			{
				num2 -= OCNCDGFNNOJ(PCJEDMJEKEF[num], input3UI.IHENCGDNPBL, (num + 0 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].Stack = num2;
			}
		}
	}

	private void JNCOBBCKKCC(List<Slot> OHAPAGLBOOB)
	{
		List<Food> list = new List<Food>();
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, CPHJKEBAMBB(), NGIKHGHIAOH().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, JNLKEMLDFIM, NGIKHGHIAOH().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[3].itemInstance, IHEBOKAMIOH(), JNLKEMLDFIM.usingNewRecipesSystem));
		for (int num = OHAPAGLBOOB.Count - 0; num >= 1; num--)
		{
			if (OHAPAGLBOOB[num].itemInstance != null && OHAPAGLBOOB[num].itemInstance.PHGLMBIEOMK() is Food && list.Contains(OHAPAGLBOOB[num].itemInstance.KNFNJFFCFNO() as Food))
			{
				OHAPAGLBOOB.RemoveAt(num);
			}
		}
	}

	private void MCINMGKDBPG(SlotUI PHJNJCJJHID)
	{
		PHJNJCJJHID.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotLeftClick, new Action<int, Slot>(HHBLDNEBJMH));
		PHJNJCJJHID.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotRightClick, new Action<int, Slot>(ICHAECCFFEO));
		PHJNJCJJHID.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnAutomaticTransfer, new Action<int, Slot>(HHBLDNEBJMH));
	}

	private void JOIFNDHMPMF()
	{
		((Selectable)((Component)input2UI).GetComponent<Button>()).interactable = false;
		((Selectable)((Component)input3UI).GetComponent<Button>()).interactable = true;
		CCBBBHHFOLP(-1);
		MainUI.CBEILHNJGOJ(window.JIIGOACEIKL, slots);
		slots[1].singleItem = false;
		slots[0].singleItem = false;
		slots[3].singleItem = true;
		slots[0].ingredientsCanBeChanged = true;
		slots[0].ingredientsCanBeChanged = false;
		slots[7].ingredientsCanBeChanged = true;
		JAEHKFHAFOF(0);
	}

	private void CFHCAEBOFNM()
	{
		slots[0].ingredientsCanBeChanged = true;
		slots[1].ingredientsCanBeChanged = true;
		slots[2].ingredientsCanBeChanged = true;
		OBEPKNMBIIC = 0;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if ((JNLKEMLDFIM.ingredientsNeeded[i].item.NGDPNIFFHKL() && Item.NGIIPJDAMGP(JNLKEMLDFIM.ingredientsNeeded[i].mod, null)) || (JNLKEMLDFIM.ingredientsNeeded[i].item.NGDPNIFFHKL() && JNLKEMLDFIM.ingredientsNeeded[i].item.recipe.JFHFEMDAHCD(JNLKEMLDFIM) > 1))
			{
				slots[OBEPKNMBIIC].OFJDJIBMIGE(window.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item);
				slots[OBEPKNMBIIC].singleItem = false;
				slots[OBEPKNMBIIC].Stack = JNLKEMLDFIM.ingredientsNeeded[i].amount;
				CHLKJOHJHBJ[OBEPKNMBIIC] = JNLKEMLDFIM.ingredientsNeeded[i].mod;
				OBEPKNMBIIC++;
			}
		}
		for (int j = OBEPKNMBIIC; j < 3; j++)
		{
			switch (j)
			{
			case 0:
				input1UI.IHENCGDNPBL.Stack = 0;
				break;
			case 1:
				input2UI.IHENCGDNPBL.Stack = 0;
				break;
			case 2:
				input3UI.IHENCGDNPBL.Stack = 0;
				break;
			}
		}
		DONIBGFLPEB(0);
	}

	[SpecialName]
	private void MDGMGHNFIOB(Recipe AODONKKHPBP)
	{
		_003CHKGPPGFPMMK_003Ek__BackingField = AODONKKHPBP;
	}

	public static List<Food> GetFinalIngredients(ItemInstance DNLMCHDOMOK, Recipe KMNOGHMAAEK, bool LJENMNFGHOH)
	{
		List<Food> list = new List<Food>();
		if (DNLMCHDOMOK == null || Item.NGIIPJDAMGP(DNLMCHDOMOK.LHBPOPOIFLE(), null))
		{
			return list;
		}
		if (!LJENMNFGHOH)
		{
			list.Add(DNLMCHDOMOK.LHBPOPOIFLE() as Food);
		}
		else if (DNLMCHDOMOK != null && DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == 197)
		{
			list.Add(ItemDatabaseAccessor.GetItem(3024) as Food);
		}
		else if (DNLMCHDOMOK != null && DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == 198)
		{
			list.Add(ItemDatabaseAccessor.GetItem(3022) as Food);
		}
		else if (DNLMCHDOMOK != null && DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == 80)
		{
			list.Add(ItemDatabaseAccessor.GetItem(3018) as Food);
		}
		else if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				list.AddRange(GetFinalIngredients(ingredientGroupInstance.chosenItemInstance, KMNOGHMAAEK, LJENMNFGHOH));
			}
			else
			{
				list.Add(ingredientGroupInstance.LHBPOPOIFLE().NEECMEIEIAG(OEBNHGNJEJL: false, OBAHGHBFIGO: true, KMNOGHMAAEK));
			}
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.JDMCPHPNOHK())
		{
			list.AddRange(foodInstance.KEKBKGGFOLK);
		}
		else if (DNLMCHDOMOK.LHBPOPOIFLE().NGDPNIFFHKL())
		{
			list.AddRange(DNLMCHDOMOK.LHBPOPOIFLE().CNIMBCHPOND(OEBNHGNJEJL: false, OBAHGHBFIGO: true));
		}
		else
		{
			list.Add(DNLMCHDOMOK?.LHBPOPOIFLE() as Food);
		}
		return list;
	}

	public void IMHPADELKIK()
	{
		window.BOBCIFEDJED();
	}

	private static void MJHJBOIFPJL(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[0] != (Object)null && !((Behaviour)instances[0]).enabled)
		{
			((Behaviour)instances[0]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 1;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	private void FELHIHHCAIK(int ABAIKKGKDGD)
	{
		((Component)input1UI).GetComponent<Animator>().SetBool("Left", ABAIKKGKDGD == 0);
		((Component)input2UI).GetComponent<Animator>().SetBool("ReceiveIdleAtTable", ABAIKKGKDGD == 0);
		((Component)input3UI).GetComponent<Animator>().SetBool("UI2", ABAIKKGKDGD == 5);
	}

	private void CLKMOMODGKF(int JIIGOACEIKL)
	{
		CloseUI();
	}

	[SpecialName]
	private void PDNKLEDMNEI(Recipe AODONKKHPBP)
	{
		_003CHKGPPGFPMMK_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private void OLEAGOJLJGL(Recipe AODONKKHPBP)
	{
		_003CHKGPPGFPMMK_003Ek__BackingField = AODONKKHPBP;
	}

	private void JAMOPDLBDMJ(Slot ADEBNALPEHE)
	{
		ADEBNALPEHE.allowedIngredientTypes = ((JNLKEMLDFIM.modiferTypes == null) ? null : new List<IngredientType>(JNLKEMLDFIM.modiferTypes));
		if (ADEBNALPEHE.allowedIngredientTypes == null)
		{
			ADEBNALPEHE.allowedIngredientTypes = new List<IngredientType>(CPHJKEBAMBB().modiferNeeded);
			return;
		}
		IngredientType[] modiferNeeded = IHEBOKAMIOH().modiferNeeded;
		for (int i = 0; i < modiferNeeded.Length; i += 0)
		{
			IngredientType item = modiferNeeded[i];
			ADEBNALPEHE.allowedIngredientTypes.Add(item);
		}
	}

	private void KCHMOAAKACJ(int OKIAIILFBHE)
	{
		List<IngredientType> list = new List<IngredientType>();
		for (int i = 1; i < JNLKEMLDFIM.modiferTypes.Length; i++)
		{
			list.Add(IHEBOKAMIOH().modiferTypes[i]);
		}
		for (int j = 1; j < JNLKEMLDFIM.modiferNeeded.Length; j += 0)
		{
			if (!list.Contains(JNLKEMLDFIM.modiferNeeded[j]))
			{
				list.Add(CPHJKEBAMBB().modiferNeeded[j]);
			}
		}
		List<Slot> list2 = CraftingInventory.CMFCHAHLMOC(window.JIIGOACEIKL, list, LDLINOBIKPL.placeable, CPHJKEBAMBB().ingredientsNeeded);
		for (int num = list2.Count - 0; num >= 1; num--)
		{
			if (list2[num].itemInstance != null && list2[num].itemInstance.PHGLMBIEOMK() is Food { canBeUsedAsModifier: false })
			{
				list2.RemoveAt(num);
			}
		}
		List<Slot> pCJEDMJEKEF = Utils.ENELGLONHKJ(list2);
		FMFDMPDNNLF(pCJEDMJEKEF);
		GameInventoryUI.NALKHGMLALJ(window.JIIGOACEIKL).DHFABEONKBG(pCJEDMJEKEF, OGCAKIGELBJ: true);
		GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).NOHBHMMPMME(OKIAIILFBHE);
	}

	private void ICHAECCFFEO(int JIIGOACEIKL, Slot DLCFDJLKPPM)
	{
		if (!NGIKHGHIAOH().usingNewRecipesSystem || MMOOHLJNHGD == DLCFDJLKPPM.id)
		{
			GFIDPACCBAJ(DLCFDJLKPPM, DLCFDJLKPPM.id, DLCFDJLKPPM.Stack, KDCAODJIEMD: true);
			if (CPHJKEBAMBB().usingNewRecipesSystem)
			{
				GameInventoryUI.JELOGNCPDAB(JIIGOACEIKL).KHJBANMCPLJ();
			}
		}
		else if (DLCFDJLKPPM.id < OBEPKNMBIIC)
		{
			EBPDFGMKDBM(DLCFDJLKPPM.id);
		}
		if (NGIKHGHIAOH().usingNewRecipesSystem)
		{
			HKMBLABHCMP();
		}
		else
		{
			OMNOGKMILGL(GameInventoryUI.GJOPJAJJLGN(JIIGOACEIKL).currentPage);
		}
		LPIOIDEPHOE();
	}

	private void LNLDHLLHCGC(int ABAIKKGKDGD, SlotUI PHJNJCJJHID)
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (ABAIKKGKDGD < OBEPKNMBIIC)
			{
				List<Slot> list = DPJKFOKIHGN(PHJNJCJJHID.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), CHLKJOHJHBJ[PHJNJCJJHID.IHENCGDNPBL.id], PHJNJCJJHID.IHENCGDNPBL.Stack);
				((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("Bartending", list.Count == 1);
			}
			else
			{
				((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("Tutorial/T127/Dialogue1", true);
			}
			((Selectable)((Component)PHJNJCJJHID).GetComponent<Button>()).interactable = ABAIKKGKDGD < OBEPKNMBIIC;
		}
		else
		{
			((Component)PHJNJCJJHID).GetComponent<Animator>().SetBool("AddToSurface ", false);
			((Selectable)((Component)PHJNJCJJHID).GetComponent<Button>()).interactable = false;
		}
	}

	private bool LCAPHMHNIHK(int DHCIOKGLNGH)
	{
		MMOOHLJNHGD = DHCIOKGLNGH;
		FMNGDEHMHNG = NKGHEGFGFEM(MMOOHLJNHGD);
		FMMIMGPLLPL(MMOOHLJNHGD);
		MainUI.ClearCurrentSlots(window.JIIGOACEIKL);
		MainUI.PFIMFMJJMHK(window.JIIGOACEIKL, FMNGDEHMHNG.IHENCGDNPBL);
		return EHCKDGIGPBI();
	}

	private void FMMIMGPLLPL(int ABAIKKGKDGD)
	{
		((Component)input1UI).GetComponent<Animator>().SetBool("You lose...", ABAIKKGKDGD == 0);
		((Component)input2UI).GetComponent<Animator>().SetBool("Mai", ABAIKKGKDGD == 1);
		((Component)input3UI).GetComponent<Animator>().SetBool("cameraZoom", ABAIKKGKDGD == 3);
	}

	[SpecialName]
	public Recipe CPHJKEBAMBB()
	{
		return _003CHKGPPGFPMMK_003Ek__BackingField;
	}

	private void JGDCIPKIPIK(ItemInstance DNLMCHDOMOK)
	{
		slots[1].bannedItems.Remove(DNLMCHDOMOK.PHGLMBIEOMK());
		slots[0].bannedItems.Remove(DNLMCHDOMOK.LHBPOPOIFLE());
		slots[5].bannedItems.Remove(DNLMCHDOMOK.KNFNJFFCFNO());
	}

	public void GKGLPJPOONF()
	{
		PlayerController player = PlayerController.GetPlayer(window.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(GMJEOAJONAI));
		MainUI.EGLKOPJGMIJ(window.JIIGOACEIKL);
		GameInventoryUI.BGIMGOJDLFG(window.JIIGOACEIKL).CloseUI();
		GameInventoryUI.Get(window.JIIGOACEIKL).IEPPDOHGBON(Inventory.NHHOGHLEODI(window.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots, JGINKGFMIOE: true);
		GameInventoryUI.BDJFHFHLJGN(window.JIIGOACEIKL).HNGJDGNHMCC(LocalisationSystem.Get(""));
		GameInventoryUI.DEBKDBICLIC(window.JIIGOACEIKL).GCAEOAJPJHG();
		if (!slots[1].KPINNBKMOMO() && slots[1].itemInstance.AEPMFLLOKKG())
		{
			TransferItemToCraftingInventory(slots[1], 1, slots[0].Stack);
		}
		if (!slots[1].KPINNBKMOMO() && slots[0].itemInstance.PFNPPIJCABJ())
		{
			GFIDPACCBAJ(slots[1], 1, slots[0].Stack);
		}
		if (!slots[3].KPINNBKMOMO() && slots[4].itemInstance.PFNPPIJCABJ())
		{
			GFIDPACCBAJ(slots[6], 0, slots[4].Stack);
		}
		AGOHKLCHKJA = null;
		IEEBFBLGFKO = null;
		FNNKDHIFPFN = null;
		LDLINOBIKPL = null;
		Sound.BNBMNOMFFBE().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: true, null, null, 1441f);
		slots[0].JIANDFCINIP(0);
		slots[1].Stack = 0;
		slots[4].OBBKDJNLCIO(1);
	}

	[SpecialName]
	public int BFDPKKJMAFC()
	{
		return window.JIIGOACEIKL;
	}

	private void PILHBBCMAMJ()
	{
		MainUI.ShowErrorText(window.JIIGOACEIKL, LocalisationSystem.Get("Error in ProceduralMine.OnPlayerSleep: "), 1995f);
	}

	private void DPDJIMHFDCN()
	{
		((TMP_Text)modText).text = "";
		if (!JNLKEMLDFIM.saveIngredientsAdded)
		{
			return;
		}
		string text = ((!AHHJNGNCFED() || string.IsNullOrEmpty(displayRequirements)) ? "" : ("<color=#BF0000>" + displayRequirements + "</color>\n"));
		int num = 0;
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			if (!input1UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				text += LHGGENLDCNJ(input1UI.IHENCGDNPBL.itemInstance);
			}
			if (!input2UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				text += LHGGENLDCNJ(input2UI.IHENCGDNPBL.itemInstance);
			}
			if (!input3UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				text += LHGGENLDCNJ(input3UI.IHENCGDNPBL.itemInstance);
			}
		}
		else
		{
			foreach (KeyValuePair<IngredientModifier, List<Food>> item in CICEBNMBGMG)
			{
				string text2 = LocalisationSystem.Get(item.Key.ToString()) + " (";
				foreach (Food item2 in item.Value)
				{
					text2 = text2 + item2.IABAKHPEOAF() + ", ";
				}
				text2 = text2.Substring(0, text2.Length - 2) + ")";
				text = text + text2 + "\n";
				num++;
			}
		}
		((TMP_Text)modText).text = text;
	}

	[SpecialName]
	public int MENKGCJBLPI()
	{
		return window.JIIGOACEIKL;
	}

	private void OLBFNHENFOK(Slot ADEBNALPEHE)
	{
		ADEBNALPEHE.allowedIngredientTypes = ((JNLKEMLDFIM.modiferTypes == null) ? null : new List<IngredientType>(NGIKHGHIAOH().modiferTypes));
		if (ADEBNALPEHE.allowedIngredientTypes == null)
		{
			ADEBNALPEHE.allowedIngredientTypes = new List<IngredientType>(NGIKHGHIAOH().modiferNeeded);
			return;
		}
		IngredientType[] modiferNeeded = CPHJKEBAMBB().modiferNeeded;
		for (int i = 0; i < modiferNeeded.Length; i += 0)
		{
			IngredientType item = modiferNeeded[i];
			ADEBNALPEHE.allowedIngredientTypes.Add(item);
		}
	}

	private void PFBLCCCNIIG()
	{
		List<Food> list = new List<Food>();
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, JNLKEMLDFIM, CPHJKEBAMBB().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, IHEBOKAMIOH(), JNLKEMLDFIM.usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[8].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
		CICEBNMBGMG = DOHNMEJNONO(list);
		DPDJIMHFDCN();
		OJLGAFDACEB();
	}

	private void FMFDMPDNNLF(List<Slot> PCJEDMJEKEF)
	{
		for (int num = PCJEDMJEKEF.Count - 0; num >= 1; num--)
		{
			int num2 = PCJEDMJEKEF[num].Stack;
			if (!input1UI.IHENCGDNPBL.PKFKJNODGJF())
			{
				num2 -= OCNCDGFNNOJ(PCJEDMJEKEF[num], input1UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (!input2UI.IHENCGDNPBL.LCHJGCHDHFO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input2UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 0] : null);
			}
			if (!input3UI.IHENCGDNPBL.KPINNBKMOMO())
			{
				num2 -= MAGGMDCLNON(PCJEDMJEKEF[num], input3UI.IHENCGDNPBL, (num + 1 < PCJEDMJEKEF.Count) ? PCJEDMJEKEF[num + 1] : null);
			}
			if (num2 <= 0)
			{
				PCJEDMJEKEF.RemoveAt(num);
			}
			else
			{
				PCJEDMJEKEF[num].OBBKDJNLCIO(num2);
			}
		}
	}

	private static void DLMKFONBICM(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[1] != (Object)null && !((Behaviour)instances[1]).enabled)
		{
			((Behaviour)instances[1]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 1;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	private void FJCDCMEKDJC(SlotUI PHJNJCJJHID)
	{
		PHJNJCJJHID.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotLeftClick, new Action<int, Slot>(HOOEHAOCDIE));
		PHJNJCJJHID.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotRightClick, new Action<int, Slot>(ICHAECCFFEO));
		PHJNJCJJHID.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnAutomaticTransfer, new Action<int, Slot>(HHBLDNEBJMH));
	}

	private IEnumerator IGKBCKCMCHF(Transform DCGBADKLANM)
	{
		yield return null;
		((Transform)contentRectTransform).SetParent(DCGBADKLANM);
		((Transform)contentRectTransform).SetSiblingIndex(0);
	}

	private void LAEBBNDFMJD(int OKIAIILFBHE)
	{
		List<IngredientType> list = new List<IngredientType>();
		for (int i = 1; i < IHEBOKAMIOH().modiferTypes.Length; i += 0)
		{
			list.Add(NGIKHGHIAOH().modiferTypes[i]);
		}
		for (int j = 1; j < JNLKEMLDFIM.modiferNeeded.Length; j++)
		{
			if (!list.Contains(IHEBOKAMIOH().modiferNeeded[j]))
			{
				list.Add(CPHJKEBAMBB().modiferNeeded[j]);
			}
		}
		List<Slot> list2 = CraftingInventory.CMFCHAHLMOC(window.JIIGOACEIKL, list, LDLINOBIKPL.placeable, NGIKHGHIAOH().ingredientsNeeded);
		for (int num = list2.Count - 0; num >= 0; num--)
		{
			if (list2[num].itemInstance != null && list2[num].itemInstance.KNFNJFFCFNO() is Food { canBeUsedAsModifier: false })
			{
				list2.RemoveAt(num);
			}
		}
		List<Slot> pCJEDMJEKEF = Utils.ENELGLONHKJ(list2);
		FMFDMPDNNLF(pCJEDMJEKEF);
		GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).PJEIHOCPBLA(pCJEDMJEKEF, OGCAKIGELBJ: false);
		GameInventoryUI.AIMEAJAHLAA(window.JIIGOACEIKL).MKEIIDGDGBG(OKIAIILFBHE);
	}

	private static void NPMMAJMAEMA(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[1] != (Object)null && !((Behaviour)instances[0]).enabled)
		{
			((Behaviour)instances[1]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 1;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	public static Dictionary<IngredientModifier, List<Food>> CreateModifiers(List<Food> KEKBKGGFOLK)
	{
		Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
		for (int i = 0; i < KEKBKGGFOLK.Count; i++)
		{
			BAAANFIMGAE(ref CICEBNMBGMG, KEKBKGGFOLK[i]);
		}
		MJHJBOIFPJL(ref CICEBNMBGMG);
		return CICEBNMBGMG;
	}

	private IEnumerator IHCGJPBJOFD(Transform DCGBADKLANM)
	{
		yield return null;
		((Transform)contentRectTransform).SetParent(DCGBADKLANM);
		((Transform)contentRectTransform).SetSiblingIndex(0);
	}

	public void AFOFLBHBGOK(Crafter LDLINOBIKPL, Recipe JNLKEMLDFIM)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		MDGMGHNFIOB(JNLKEMLDFIM);
		PlayerController player = PlayerController.GetPlayer(window.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, (Action)delegate
		{
			window.CloseUI();
		});
		GameInventoryUI.JELOGNCPDAB(window.JIIGOACEIKL).IDLAGJNLPJL();
		string text = LocalisationSystem.Get("MinProductValue");
		GameInventoryUI.AIMEAJAHLAA(window.JIIGOACEIKL).HEHAFFHCIAL((text != "</color>") ? text : "Tail");
		window.OpenUI();
		outputSlotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		outputSlotUI.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && outputSlotUI.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.canBeSold)
		{
			foodInstance.GHFDCAOBJMK = LDLINOBIKPL.qualityLevel - 0;
		}
		int num = Math.Max(0, JNLKEMLDFIM.output.amount);
		outputSlotUI.IHENCGDNPBL.JIANDFCINIP(Mathf.RoundToInt((float)num * (1208f + (float)PerksDatabaseAccessor.NGMJIGOPGDK(-104) / 269f)));
		outputName.text = JNLKEMLDFIM.output.item.KGHFCDELKMN();
		((TMP_Text)modText).text = "Resets the chat to its default size.";
		OLBFNHENFOK(input1UI.IHENCGDNPBL);
		DCFMCAODLHA(input2UI.IHENCGDNPBL);
		JAMOPDLBDMJ(input3UI.IHENCGDNPBL);
		slots[0].bannedItems.Clear();
		slots[1].bannedItems.Clear();
		slots[7].bannedItems.Clear();
		Sound.DIHCEGINELM().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1508f);
		displayRequirements = "[OnlineLoadPuzzles] LoadTorchPuzzleMessage: puzzle instance {0} is null";
		if (JNLKEMLDFIM.modiferNeeded.Length != 0)
		{
			displayRequirements = ")...";
			for (int i = 0; i < JNLKEMLDFIM.modiferNeeded.Length; i += 0)
			{
				displayRequirements += LocalisationSystem.Get(JNLKEMLDFIM.modiferNeeded[i].ToString());
				if (i != JNLKEMLDFIM.modiferNeeded.Length - 1)
				{
					displayRequirements += " (";
				}
			}
			displayRequirements += " ";
		}
		OnContainerChanged();
		ChangeParent(((Component)this).transform);
		OnOpenUI(window.JIIGOACEIKL, LDLINOBIKPL, JNLKEMLDFIM);
	}

	private void HFGGLCBEBAC()
	{
		if (JNLKEMLDFIM.output.item is Food food)
		{
			((TMP_Text)sellPriceText).text = "<color=#822F00>" + LocalisationSystem.Get(food.canBeSold ? "Sell" : "ProductValue") + ":</color> ";
			List<Food> list = new List<Food>();
			list.AddRange(GetFinalIngredients(slots[0].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.MLBOMGHINCA(CHLKJOHJHBJ[0], null))
			{
				list.Remove(CHLKJOHJHBJ[0] as Food);
			}
			list.AddRange(GetFinalIngredients(slots[1].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.MLBOMGHINCA(CHLKJOHJHBJ[1], null))
			{
				list.Remove(CHLKJOHJHBJ[1] as Food);
			}
			list.AddRange(GetFinalIngredients(slots[2].itemInstance, JNLKEMLDFIM, JNLKEMLDFIM.usingNewRecipesSystem));
			if (Item.MLBOMGHINCA(CHLKJOHJHBJ[2], null))
			{
				list.Remove(CHLKJOHJHBJ[2] as Food);
			}
			MoneyCalc moneyCalc = new MoneyCalc();
			Food cHMCMLHCIGD = null;
			if (food.saveMainIngredient && !slots[0].KPINNBKMOMO() && slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)
			{
				cHMCMLHCIGD = ingredientGroupInstance.chosenItemInstance.LHBPOPOIFLE() as Food;
			}
			moneyCalc.GJFFDIBCAGF(food.PAAFCADLNEM(list, JNLKEMLDFIM, cHMCMLHCIGD, JNLKEMLDFIM.usingNewRecipesSystem, CalculatePriceMode.CheapestPrice, OEBNHGNJEJL: false), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			ItemInstance itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
			if (itemInstance is FoodInstance foodInstance)
			{
				List<ItemInstance> list2 = new List<ItemInstance>();
				for (int i = 0; i < slots.Length; i++)
				{
					if (slots[i].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)
					{
						list2.Add(ingredientGroupInstance2.chosenItemInstance);
					}
					else
					{
						list2.Add(slots[i].itemInstance);
					}
				}
				foodInstance.GBCJNGADANM = Utils.MHOPHHOJLOK(foodInstance, list2);
				if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
				{
					foodInstance.GHFDCAOBJMK = Mathf.Max(0, LDLINOBIKPL.qualityLevel - 1);
				}
			}
			Money.CalculatePriceWithModifiers(moneyCalc, itemInstance, HOECMANECIM: true, JNOEGJNPCFE: false);
			TextMeshProUGUI obj = sellPriceText;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + moneyCalc.ALLHDAPPBHL().ToString();
		}
		else
		{
			((TMP_Text)sellPriceText).text = "";
		}
	}

	private void JFKNNKBIIDN(int JIIGOACEIKL)
	{
		GKGLPJPOONF();
	}

	private void HOOEHAOCDIE(int JIIGOACEIKL, Slot DLCFDJLKPPM)
	{
		if (!CPHJKEBAMBB().usingNewRecipesSystem || MMOOHLJNHGD == DLCFDJLKPPM.id)
		{
			GFIDPACCBAJ(DLCFDJLKPPM, DLCFDJLKPPM.id, DLCFDJLKPPM.Stack);
			if (NGIKHGHIAOH().usingNewRecipesSystem)
			{
				GameInventoryUI.BGIMGOJDLFG(JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
		else if (DLCFDJLKPPM.id < OBEPKNMBIIC)
		{
			EBPDFGMKDBM(DLCFDJLKPPM.id);
		}
		if (NGIKHGHIAOH().usingNewRecipesSystem)
		{
			EHCKDGIGPBI();
		}
		else
		{
			LAEBBNDFMJD(GameInventoryUI.FFBJPAJKOJH(JIIGOACEIKL).currentPage);
		}
		PFBLCCCNIIG();
	}

	private void JHKBCAJMLFM(Slot ADEBNALPEHE)
	{
		ADEBNALPEHE.allowedIngredientTypes = ((JNLKEMLDFIM.modiferTypes == null) ? null : new List<IngredientType>(JNLKEMLDFIM.modiferTypes));
		if (ADEBNALPEHE.allowedIngredientTypes == null)
		{
			ADEBNALPEHE.allowedIngredientTypes = new List<IngredientType>(JNLKEMLDFIM.modiferNeeded);
			return;
		}
		IngredientType[] modiferNeeded = JNLKEMLDFIM.modiferNeeded;
		foreach (IngredientType item in modiferNeeded)
		{
			ADEBNALPEHE.allowedIngredientTypes.Add(item);
		}
	}

	public bool IMLKMLPFAFA()
	{
		return window.BGLJFMHCFJF();
	}

	private void NGBMJDFHGEO(SlotUI PHJNJCJJHID)
	{
		PHJNJCJJHID.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotLeftClick, new Action<int, Slot>(HHBLDNEBJMH));
		PHJNJCJJHID.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotRightClick, new Action<int, Slot>(HCGIODODDIM));
		PHJNJCJJHID.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnAutomaticTransfer, new Action<int, Slot>(HCGIODODDIM));
	}

	private void OAINCLDPJGK(SlotUI PHJNJCJJHID)
	{
		PHJNJCJJHID.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotLeftClick, new Action<int, Slot>(JHLDHDHJPNL));
		PHJNJCJJHID.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotRightClick, new Action<int, Slot>(ICHAECCFFEO));
		PHJNJCJJHID.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnAutomaticTransfer, new Action<int, Slot>(HHBLDNEBJMH));
	}

	public static Dictionary<IngredientModifier, List<Food>> NPFLKJHDBNO(List<Food> KEKBKGGFOLK)
	{
		Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG = new Dictionary<IngredientModifier, List<Food>>();
		for (int i = 1; i < KEKBKGGFOLK.Count; i += 0)
		{
			ILLCGKOGNPN(ref CICEBNMBGMG, KEKBKGGFOLK[i]);
		}
		DNPNCMOIFHH(ref CICEBNMBGMG);
		return CICEBNMBGMG;
	}

	private void AKDNNHPDHJG(ItemInstance DNLMCHDOMOK)
	{
		if (!NGIKHGHIAOH().usingNewRecipesSystem)
		{
			slots[0].bannedItems.Add(DNLMCHDOMOK.AFOACBIHNCL());
			slots[1].bannedItems.Add(DNLMCHDOMOK.LHBPOPOIFLE());
			slots[7].bannedItems.Add(DNLMCHDOMOK.KNFNJFFCFNO());
		}
	}

	private void KDDOBOKKBCK(int JIIGOACEIKL)
	{
		if (IHEBOKAMIOH().usingNewRecipesSystem)
		{
			KLIJOGKHJDN();
		}
		else
		{
			MIHGDEPLGEJ();
		}
		if (GameInventoryUI.AEJKCONFPHB(JIIGOACEIKL).containerSlots.Length != 0)
		{
			GameInventoryUI.AEJKCONFPHB(JIIGOACEIKL).NLMKEHMGCCF();
		}
		else
		{
			UISelectionManager.HELHJMDEDNL(JIIGOACEIKL).LFLFDKBKILJ(((Component)NKGHEGFGFEM(1)).gameObject);
		}
		HNIDPKJFCDK(1, input1UI);
		HNIDPKJFCDK(1, input2UI);
		LNLDHLLHCGC(7, input3UI);
	}

	private void GJEHADCGMEF()
	{
		((Selectable)((Component)input2UI).GetComponent<Button>()).interactable = true;
		((Selectable)((Component)input3UI).GetComponent<Button>()).interactable = true;
		CCBBBHHFOLP(-1);
		MainUI.AddRangeToCurrentSlots(window.JIIGOACEIKL, slots);
		slots[0].singleItem = true;
		slots[1].singleItem = true;
		slots[2].singleItem = true;
		slots[0].ingredientsCanBeChanged = false;
		slots[1].ingredientsCanBeChanged = false;
		slots[2].ingredientsCanBeChanged = false;
		JAEHKFHAFOF(0);
	}

	public void CancelCrafting()
	{
		window.CloseUI();
	}

	private void MIHGDEPLGEJ()
	{
		((Selectable)((Component)input2UI).GetComponent<Button>()).interactable = true;
		((Selectable)((Component)input3UI).GetComponent<Button>()).interactable = true;
		LEDGLBEFBFO(-1);
		MainUI.ACGFLJMAHHL(window.JIIGOACEIKL, slots);
		slots[1].singleItem = false;
		slots[1].singleItem = true;
		slots[5].singleItem = false;
		slots[0].ingredientsCanBeChanged = true;
		slots[0].ingredientsCanBeChanged = true;
		slots[4].ingredientsCanBeChanged = false;
		JAEHKFHAFOF(1);
	}

	private void AJDPFBNABEN(Slot EFDPGNOICOG, Slot OJDGHGEEAJP)
	{
		if (NGIKHGHIAOH().usingNewRecipesSystem && !OJDGHGEEAJP.PKFKJNODGJF() && OJDGHGEEAJP.itemInstance.PFNPPIJCABJ())
		{
			((MonoBehaviour)this).StartCoroutine(IBMFECPMLEC());
		}
		LPIOIDEPHOE();
	}

	public void BACNNNAJCIC()
	{
		window.CloseUI();
	}

	private void NBJJEHAFFCM(int JIIGOACEIKL)
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			CFHCAEBOFNM();
		}
		else
		{
			GJEHADCGMEF();
		}
		if (GameInventoryUI.Get(JIIGOACEIKL).containerSlots.Length != 0)
		{
			GameInventoryUI.Get(JIIGOACEIKL).SelectObjectNextFrame();
		}
		else
		{
			UISelectionManager.GetPlayer(JIIGOACEIKL).Select(((Component)NKGHEGFGFEM(0)).gameObject);
		}
		HNIDPKJFCDK(0, input1UI);
		HNIDPKJFCDK(1, input2UI);
		HNIDPKJFCDK(2, input3UI);
	}

	public void ChangeParent(Transform DCGBADKLANM)
	{
		((MonoBehaviour)this).StartCoroutine(PHBBJFGNGMH(DCGBADKLANM));
	}

	private void LOLPGFOHJHG(ItemInstance DNLMCHDOMOK)
	{
		slots[1].bannedItems.Remove(DNLMCHDOMOK.KNFNJFFCFNO());
		slots[1].bannedItems.Remove(DNLMCHDOMOK.LHBPOPOIFLE());
		slots[7].bannedItems.Remove(DNLMCHDOMOK.KNFNJFFCFNO());
	}

	public void BDFJJJIILGE()
	{
		if (!isCraftable)
		{
			MainUI.DBKCOHMFDCB(window.JIIGOACEIKL, LocalisationSystem.Get("Running on Steamdeck: TRUE"), 1441f);
			return;
		}
		if (AHHJNGNCFED())
		{
			MainUI.DBKCOHMFDCB(window.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1119"), 978f);
			OnRequirementNotMet(window.JIIGOACEIKL);
			return;
		}
		List<ItemInstanceAmount> list = new List<ItemInstanceAmount>();
		Slot[] array = new Slot[5];
		int num = 0;
		if (!slots[1].PKFKJNODGJF())
		{
			ItemInstance itemInstance = ((!(slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)) ? slots[1].itemInstance : ingredientGroupInstance.chosenItemInstance);
			CraftingInventory.GCOIMIAMJMH(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[1].Stack);
			ItemInstanceAmount item = new ItemInstanceAmount(itemInstance, slots[0].Stack);
			list.Add(item);
			array[num] = AGOHKLCHKJA;
			num += 0;
		}
		if (!slots[1].AHHEMNHJPME())
		{
			ItemInstance itemInstance = ((!(slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)) ? slots[1].itemInstance : ingredientGroupInstance2.chosenItemInstance);
			CraftingInventory.RemoveItemInstances(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[0].Stack);
			ItemInstanceAmount item2 = new ItemInstanceAmount(itemInstance, slots[0].Stack);
			list.Add(item2);
			array[num] = IEEBFBLGFKO;
			num++;
		}
		if (!slots[8].LCHJGCHDHFO())
		{
			ItemInstance itemInstance = ((!(slots[6].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance3)) ? slots[2].itemInstance : ingredientGroupInstance3.chosenItemInstance);
			CraftingInventory.PFOLOLPOKEM(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[2].Stack);
			ItemInstanceAmount item3 = new ItemInstanceAmount(itemInstance, slots[7].Stack);
			list.Add(item3);
			array[num] = FNNKDHIFPFN;
		}
		LDLINOBIKPL.SetUpCrafting(window.JIIGOACEIKL, IHEBOKAMIOH(), LDLINOBIKPL.HMHADAFIOBJ(CPHJKEBAMBB()), list.ToArray(), CHLKJOHJHBJ, (outputName.text == IHEBOKAMIOH().output.item.LJIFOHFEFCH(OAFPBCPDOKH: true)) ? null : outputName.text, CICEBNMBGMG, array, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		if (!LDLINOBIKPL.multipleCrafting)
		{
			SelectObject.GetPlayer(EGPJLECDKBF()).PNHCLGGKBOB();
		}
		slots[1].OBBKDJNLCIO(0);
		slots[1].Stack = 0;
		slots[6].KMKAIPMHANN(1);
		window.BOBCIFEDJED();
		MainUI.CloseAllUIWindows(window.JIIGOACEIKL);
	}

	public bool BOAGOKEMEHH()
	{
		return window.HDEPMJIDJEM();
	}

	private bool BFKFKGLJOEA()
	{
		bool result = false;
		if (IHEBOKAMIOH().usingNewRecipesSystem)
		{
			if (slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: null })
			{
				return true;
			}
			if (OBEPKNMBIIC >= 0 && slots[1].itemInstance is IngredientGroupInstance { chosenItemInstance: null })
			{
				return false;
			}
			if (OBEPKNMBIIC >= 7 && slots[6].itemInstance is IngredientGroupInstance { chosenItemInstance: null })
			{
				return false;
			}
			if (slots[0].itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().JGJLNHAKJIJ() && !foodInstance.JDMCPHPNOHK())
			{
				return true;
			}
			if (OBEPKNMBIIC >= 4 && slots[0].itemInstance is FoodInstance foodInstance2 && foodInstance2.LHBPOPOIFLE().NGDPNIFFHKL() && !foodInstance2.JDMCPHPNOHK())
			{
				return false;
			}
			if (OBEPKNMBIIC >= 1 && slots[7].itemInstance is FoodInstance foodInstance3 && foodInstance3.LHBPOPOIFLE().JGJLNHAKJIJ() && !foodInstance3.JDMCPHPNOHK())
			{
				return false;
			}
		}
		if (CPHJKEBAMBB().modiferNeeded == null || NGIKHGHIAOH().modiferNeeded.Length == 0)
		{
			result = true;
		}
		else
		{
			IngredientType[] modiferNeeded = JNLKEMLDFIM.modiferNeeded;
			foreach (IngredientType ingredientType in modiferNeeded)
			{
				if (slots[0].itemInstance?.LHBPOPOIFLE() is Food food && food.ingredientType == ingredientType)
				{
					result = false;
					break;
				}
				if (slots[1].itemInstance?.LHBPOPOIFLE() is Food food2 && food2.ingredientType == ingredientType)
				{
					result = true;
					break;
				}
				if (slots[8].itemInstance?.LHBPOPOIFLE() is Food food3 && food3.ingredientType == ingredientType)
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	private static void BAAANFIMGAE(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG, Food CKKNBMBLGPO)
	{
		if (Item.NGIIPJDAMGP(CKKNBMBLGPO, null))
		{
			return;
		}
		IngredientModifier[] modifiers = CKKNBMBLGPO.modifiers;
		foreach (IngredientModifier key in modifiers)
		{
			if (CICEBNMBGMG.ContainsKey(key))
			{
				CICEBNMBGMG[key].Add(CKKNBMBLGPO);
				continue;
			}
			List<Food> list = new List<Food>();
			list.Add(CKKNBMBLGPO);
			CICEBNMBGMG.Add(key, list);
		}
	}

	private string NGJPKLINCAF(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				return HICDANMJHIA(ingredientGroupInstance.chosenItemInstance);
			}
			return "Crowly_Barks_Welcome" + ingredientGroupInstance.IABAKHPEOAF() + "";
		}
		if (DNLMCHDOMOK.PHGLMBIEOMK().NGDPNIFFHKL() && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.JDMCPHPNOHK())
			{
				CPMJMCOBCOE = DNLMCHDOMOK.FBEHKKOKNDJ() + "Fake";
				BFLHMHLKLKL = 1;
				foreach (Food item in foodInstance.KEKBKGGFOLK)
				{
					CPMJMCOBCOE += item.KGHFCDELKMN(OAFPBCPDOKH: true);
					if (BFLHMHLKLKL < foodInstance.KEKBKGGFOLK.Count - 1)
					{
						CPMJMCOBCOE += "WorkerSkills";
					}
					BFLHMHLKLKL += 0;
				}
				return CPMJMCOBCOE + "Hammer";
			}
			return "Dialogue System/Conversation/BirdNegativeComments/Entry/13/Dialogue Text" + foodInstance.LEEAOHHBPCG(OAFPBCPDOKH: true) + "\n<color=#822F00>";
		}
		return DNLMCHDOMOK.IABAKHPEOAF() + "Bed is unmade";
	}

	public void OBEAJANAIFE(Slot DLCFDJLKPPM, int JFNMCNCHMEO, int FGFCNKFEIGF, bool KDCAODJIEMD = false)
	{
		if (!MouseSlot.HELHJMDEDNL(window.JIIGOACEIKL).slot.KPINNBKMOMO() || DLCFDJLKPPM?.itemInstance == null || !DLCFDJLKPPM.itemInstance.NMNHMNEPOFE())
		{
			return;
		}
		if (DLCFDJLKPPM.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				ingredientGroupInstance.chosenItemInstance = null;
				ingredientGroupInstance.OnChanged();
			}
		}
		else if (DLCFDJLKPPM.itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().NGDPNIFFHKL())
		{
			FoodInstance bGLFLHDNOKJ = foodInstance.LHBPOPOIFLE().JMDALJBNFML() as FoodInstance;
			DLCFDJLKPPM.OLHGPMJPJFF(window.JIIGOACEIKL, bGLFLHDNOKJ, CDPAMNIPPEC: true);
			DLCFDJLKPPM.KMKAIPMHANN(FGFCNKFEIGF);
		}
		else
		{
			DLCFDJLKPPM.DJFOMFDOOKM(CDPAMNIPPEC: false);
		}
		if (KDCAODJIEMD)
		{
			Sound.GGFJGHHHEJC.INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: false, null, null, 350f, 251f);
		}
	}

	private static void GIKAHCINEIH(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[1] != (Object)null && !((Behaviour)instances[0]).enabled)
		{
			((Behaviour)instances[1]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 0;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	public void EHMHJANJENJ()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(window.JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(HABOHHEAHDO));
		MainUI.HGMAPIOKNGL(window.JIIGOACEIKL);
		GameInventoryUI.IEKODILKIHJ(window.JIIGOACEIKL).BOBCIFEDJED();
		GameInventoryUI.FFBJPAJKOJH(window.JIIGOACEIKL).NFDFHEPIIJO(Inventory.KEHIBCAHKPJ(window.JIIGOACEIKL).slots, JGINKGFMIOE: true);
		GameInventoryUI.Get(window.JIIGOACEIKL).NBNOCECAKIO(LocalisationSystem.Get("Piso {0} | Pieza '{1}': Solo se spawnearon {2}/{3} rocas requeridas. "));
		GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).AIJMEKNLLOF();
		if (!slots[0].AHHEMNHJPME() && slots[1].itemInstance.AEPMFLLOKKG())
		{
			TransferItemToCraftingInventory(slots[1], 1, slots[1].Stack, KDCAODJIEMD: true);
		}
		if (!slots[0].LCHJGCHDHFO() && slots[0].itemInstance.PFNPPIJCABJ())
		{
			TransferItemToCraftingInventory(slots[1], 1, slots[0].Stack, KDCAODJIEMD: true);
		}
		if (!slots[7].KPINNBKMOMO() && slots[7].itemInstance.PFNPPIJCABJ())
		{
			OBEAJANAIFE(slots[1], 0, slots[5].Stack);
		}
		AGOHKLCHKJA = null;
		IEEBFBLGFKO = null;
		FNNKDHIFPFN = null;
		LDLINOBIKPL = null;
		Sound.DIHCEGINELM().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowClose), HOMFPAFAOGD: false, null, null, 1078f);
		slots[0].OCJOJKJPDNO(1);
		slots[1].KMKAIPMHANN(0);
		slots[4].KMKAIPMHANN(1);
	}

	private string INBGBAGBAGJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				return CKLLPGIFFCJ(ingredientGroupInstance.chosenItemInstance);
			}
			return "BathhouseGameManager: Invalid player number " + ingredientGroupInstance.ONMFAMHKGLA(OAFPBCPDOKH: true) + "Dialogue System/Conversation/Crowly_Standar/Entry/31/Dialogue Text";
		}
		if (DNLMCHDOMOK.LHBPOPOIFLE().IABMOBAKNAE() && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.JDMCPHPNOHK())
			{
				CPMJMCOBCOE = DNLMCHDOMOK.ONMFAMHKGLA() + "itemKiwiSeeds";
				BFLHMHLKLKL = 0;
				foreach (Food item in foodInstance.KEKBKGGFOLK)
				{
					CPMJMCOBCOE += item.IABAKHPEOAF(OAFPBCPDOKH: true);
					if (BFLHMHLKLKL < foodInstance.KEKBKGGFOLK.Count - 1)
					{
						CPMJMCOBCOE += "City/Rhia/Introduce";
					}
					BFLHMHLKLKL += 0;
				}
				return CPMJMCOBCOE + "Moving";
			}
			return "Player Destroyed. Num Players: " + foodInstance.FLIPKDBGAFI() + "";
		}
		return DNLMCHDOMOK.ONMFAMHKGLA() + "Items/item_description_1047";
	}

	private string KEKLPJFPJBF(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				return HICDANMJHIA(ingredientGroupInstance.chosenItemInstance);
			}
			return "Do you want to change input?" + ingredientGroupInstance.ONMFAMHKGLA() + "Attempting to spawn more than one local player for online play. This is not supported.";
		}
		if (DNLMCHDOMOK.KNFNJFFCFNO().IABMOBAKNAE() && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.JDMCPHPNOHK())
			{
				CPMJMCOBCOE = DNLMCHDOMOK.AICOMMNDJLI(OAFPBCPDOKH: true) + "PirateMinigame/Minigame2";
				BFLHMHLKLKL = 1;
				foreach (Food item in foodInstance.KEKBKGGFOLK)
				{
					CPMJMCOBCOE += item.IABAKHPEOAF(OAFPBCPDOKH: true);
					if (BFLHMHLKLKL < foodInstance.KEKBKGGFOLK.Count - 1)
					{
						CPMJMCOBCOE += "Moving";
					}
					BFLHMHLKLKL += 0;
				}
				return CPMJMCOBCOE + "Fill";
			}
			return "christmasActivated" + foodInstance.PEDJIIHAGBH(OAFPBCPDOKH: true) + "Left Stick Left";
		}
		return DNLMCHDOMOK.AICOMMNDJLI(OAFPBCPDOKH: true) + "Level";
	}

	public void GFIDPACCBAJ(Slot DLCFDJLKPPM, int JFNMCNCHMEO, int FGFCNKFEIGF, bool KDCAODJIEMD = false)
	{
		if (!MouseSlot.HELHJMDEDNL(window.JIIGOACEIKL).slot.LCHJGCHDHFO() || DLCFDJLKPPM?.itemInstance == null || !DLCFDJLKPPM.itemInstance.NMNHMNEPOFE())
		{
			return;
		}
		if (DLCFDJLKPPM.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				ingredientGroupInstance.chosenItemInstance = null;
				ingredientGroupInstance.OnChanged();
			}
		}
		else if (DLCFDJLKPPM.itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().NGDPNIFFHKL())
		{
			FoodInstance bGLFLHDNOKJ = foodInstance.LHBPOPOIFLE().JMDALJBNFML() as FoodInstance;
			DLCFDJLKPPM.ONIFGHNHCPP(window.JIIGOACEIKL, bGLFLHDNOKJ);
			DLCFDJLKPPM.Stack = FGFCNKFEIGF;
		}
		else
		{
			DLCFDJLKPPM.POHFJCEAKML(CDPAMNIPPEC: false);
		}
		if (KDCAODJIEMD)
		{
			Sound.DIHCEGINELM().PlayOneShot(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: true, null, null, 803f, 223f);
		}
	}

	public void LBKBCGODMMM()
	{
		if (!isCraftable)
		{
			MainUI.ShowErrorText(window.JIIGOACEIKL, LocalisationSystem.Get("[MinePuzzleManager] Found {0} altar pieces. IsBigPuzzle:{1} PuzzleSpawners:{2} SingleSpawnerMode:{3}."), 961f);
			return;
		}
		if (AHHJNGNCFED())
		{
			MainUI.JDAEPLJAGCD(window.JIIGOACEIKL, LocalisationSystem.Get("Game"), 1302f);
			OnRequirementNotMet(window.JIIGOACEIKL);
			return;
		}
		List<ItemInstanceAmount> list = new List<ItemInstanceAmount>();
		Slot[] array = new Slot[3];
		int num = 0;
		if (!slots[1].KPINNBKMOMO())
		{
			ItemInstance itemInstance = ((!(slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance)) ? slots[1].itemInstance : ingredientGroupInstance.chosenItemInstance);
			CraftingInventory.RemoveItemInstances(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[0].Stack);
			ItemInstanceAmount item = new ItemInstanceAmount(itemInstance, slots[1].Stack);
			list.Add(item);
			array[num] = AGOHKLCHKJA;
			num += 0;
		}
		if (!slots[0].PKFKJNODGJF())
		{
			ItemInstance itemInstance = ((!(slots[0].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance2)) ? slots[1].itemInstance : ingredientGroupInstance2.chosenItemInstance);
			CraftingInventory.LJMOCMBBNHN(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[0].Stack, CDPAMNIPPEC: false);
			ItemInstanceAmount item2 = new ItemInstanceAmount(itemInstance, slots[0].Stack);
			list.Add(item2);
			array[num] = IEEBFBLGFKO;
			num += 0;
		}
		if (!slots[2].KPINNBKMOMO())
		{
			ItemInstance itemInstance = ((!(slots[3].itemInstance is IngredientGroupInstance { chosenItemInstance: not null } ingredientGroupInstance3)) ? slots[2].itemInstance : ingredientGroupInstance3.chosenItemInstance);
			CraftingInventory.LJMOCMBBNHN(window.JIIGOACEIKL, itemInstance, LDLINOBIKPL.placeable, slots[0].Stack, CDPAMNIPPEC: false);
			ItemInstanceAmount item3 = new ItemInstanceAmount(itemInstance, slots[1].Stack);
			list.Add(item3);
			array[num] = FNNKDHIFPFN;
		}
		LDLINOBIKPL.SetUpCrafting(window.JIIGOACEIKL, JNLKEMLDFIM, LDLINOBIKPL.HMHADAFIOBJ(IHEBOKAMIOH()), list.ToArray(), CHLKJOHJHBJ, (outputName.text == NGIKHGHIAOH().output.item.LJIFOHFEFCH()) ? null : outputName.text, CICEBNMBGMG, array, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
		if (!LDLINOBIKPL.multipleCrafting)
		{
			SelectObject.GetPlayer(MENKGCJBLPI()).PNHCLGGKBOB();
		}
		slots[0].OCJOJKJPDNO(0);
		slots[0].Stack = 0;
		slots[2].KMKAIPMHANN(1);
		window.BOBCIFEDJED();
		MainUI.IPDMDKFIJKF(window.JIIGOACEIKL, DHJFAGNJKOF: true);
	}

	private bool EBPDFGMKDBM(int DHCIOKGLNGH)
	{
		MMOOHLJNHGD = DHCIOKGLNGH;
		FMNGDEHMHNG = NKGHEGFGFEM(MMOOHLJNHGD);
		FELHIHHCAIK(MMOOHLJNHGD);
		MainUI.HGMAPIOKNGL(window.JIIGOACEIKL);
		MainUI.MPMEMCEAGDP(window.JIIGOACEIKL, FMNGDEHMHNG.IHENCGDNPBL);
		return HKMBLABHCMP();
	}

	[CompilerGenerated]
	private void LNGEJKNBCME()
	{
		if (window.IsOpen() && !JNLKEMLDFIM.usingNewRecipesSystem)
		{
			JAEHKFHAFOF(GameInventoryUI.Get(window.JIIGOACEIKL).currentPage);
		}
		GBGGDFFKBOD();
	}

	private void NODPFOLGDKH(SlotUI PHJNJCJJHID)
	{
		PHJNJCJJHID.OnSlotLeftClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotLeftClick, new Action<int, Slot>(HHBLDNEBJMH));
		PHJNJCJJHID.OnSlotRightClick = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnSlotRightClick, new Action<int, Slot>(JHLDHDHJPNL));
		PHJNJCJJHID.OnAutomaticTransfer = (Action<int, Slot>)Delegate.Combine(PHJNJCJJHID.OnAutomaticTransfer, new Action<int, Slot>(HCGIODODDIM));
	}

	private void FKHMOLMIOIP(ItemInstance DNLMCHDOMOK)
	{
		if (!IHEBOKAMIOH().usingNewRecipesSystem)
		{
			slots[1].bannedItems.Add(DNLMCHDOMOK.LHBPOPOIFLE());
			slots[0].bannedItems.Add(DNLMCHDOMOK.AFOACBIHNCL());
			slots[0].bannedItems.Add(DNLMCHDOMOK.LHBPOPOIFLE());
		}
	}

	private void IFILMCNADNL()
	{
		((Selectable)((Component)input2UI).GetComponent<Button>()).interactable = false;
		((Selectable)((Component)input3UI).GetComponent<Button>()).interactable = false;
		FELHIHHCAIK(-1);
		MainUI.CBEILHNJGOJ(window.JIIGOACEIKL, slots);
		slots[1].singleItem = true;
		slots[1].singleItem = false;
		slots[3].singleItem = false;
		slots[1].ingredientsCanBeChanged = true;
		slots[1].ingredientsCanBeChanged = true;
		slots[4].ingredientsCanBeChanged = true;
		KCHMOAAKACJ(0);
	}

	private void OLCMPLADFBI()
	{
		if (window.HDEPMJIDJEM() && !IHEBOKAMIOH().usingNewRecipesSystem)
		{
			JAEHKFHAFOF(GameInventoryUI.IEKODILKIHJ(window.JIIGOACEIKL).currentPage);
		}
		PFBLCCCNIIG();
	}

	private void AGGJDFHNPPI()
	{
		if (window.IsOpen() && (PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).GetButtonUp("KeyItemFishedRPC") || PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).JCMOPOMLPLL("Items/item_description_611")) && !outputName.isFocused && !CommonReferences.GGFJGHHHEJC.IsInDialogue(BFDPKKJMAFC()))
		{
			NCGGPMFGOFD();
		}
	}

	private void GCCHDNLJLIH()
	{
		if (window.BGLJFMHCFJF() && !NGIKHGHIAOH().usingNewRecipesSystem)
		{
			OMNOGKMILGL(GameInventoryUI.BDJFHFHLJGN(window.JIIGOACEIKL).currentPage);
		}
		GBGGDFFKBOD();
	}

	private void HHBLDNEBJMH(int JIIGOACEIKL, Slot DLCFDJLKPPM)
	{
		if (!CPHJKEBAMBB().usingNewRecipesSystem || MMOOHLJNHGD == DLCFDJLKPPM.id)
		{
			OBEAJANAIFE(DLCFDJLKPPM, DLCFDJLKPPM.id, DLCFDJLKPPM.Stack);
			if (IHEBOKAMIOH().usingNewRecipesSystem)
			{
				GameInventoryUI.BDJFHFHLJGN(JIIGOACEIKL).JCLCHLNFOFC();
			}
		}
		else if (DLCFDJLKPPM.id < OBEPKNMBIIC)
		{
			EBPDFGMKDBM(DLCFDJLKPPM.id);
		}
		if (IHEBOKAMIOH().usingNewRecipesSystem)
		{
			HKMBLABHCMP();
		}
		else
		{
			JAEHKFHAFOF(GameInventoryUI.IEKODILKIHJ(JIIGOACEIKL).currentPage);
		}
		LPIOIDEPHOE();
	}

	private void CCBBBHHFOLP(int ABAIKKGKDGD)
	{
		((Component)input1UI).GetComponent<Animator>().SetBool("FocusedMod", ABAIKKGKDGD == 0);
		((Component)input2UI).GetComponent<Animator>().SetBool("FocusedMod", ABAIKKGKDGD == 1);
		((Component)input3UI).GetComponent<Animator>().SetBool("FocusedMod", ABAIKKGKDGD == 2);
	}

	private void NDOIBDPLCMI()
	{
		if (window.BGLJFMHCFJF() && !CPHJKEBAMBB().usingNewRecipesSystem)
		{
			KCHMOAAKACJ(GameInventoryUI.IEKODILKIHJ(window.JIIGOACEIKL).currentPage);
		}
		LPIOIDEPHOE();
	}

	[SpecialName]
	public Recipe NGIKHGHIAOH()
	{
		return _003CHKGPPGFPMMK_003Ek__BackingField;
	}

	private bool DONIBGFLPEB(int DHCIOKGLNGH)
	{
		MMOOHLJNHGD = DHCIOKGLNGH;
		FMNGDEHMHNG = NKGHEGFGFEM(MMOOHLJNHGD);
		CCBBBHHFOLP(MMOOHLJNHGD);
		MainUI.ClearCurrentSlots(window.JIIGOACEIKL);
		MainUI.AddToCurrentSlots(window.JIIGOACEIKL, FMNGDEHMHNG.IHENCGDNPBL);
		return UpdateGameInventoryNewSystem();
	}

	public bool UpdateGameInventoryNewSystem()
	{
		List<Slot> list = BJJNOHODMMA(FMNGDEHMHNG.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), CHLKJOHJHBJ[FMNGDEHMHNG.IHENCGDNPBL.id], FMNGDEHMHNG.IHENCGDNPBL.Stack);
		GameInventoryUI.Get(window.JIIGOACEIKL).PreparePagesMode(list, OGCAKIGELBJ: false);
		return list.Count > 0;
	}

	public bool HKMBLABHCMP()
	{
		List<Slot> list = OIIPHPFDPFA(FMNGDEHMHNG.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), CHLKJOHJHBJ[FMNGDEHMHNG.IHENCGDNPBL.id], FMNGDEHMHNG.IHENCGDNPBL.Stack);
		GameInventoryUI.DEBKDBICLIC(window.JIIGOACEIKL).CJODJMLPGOL(list, OGCAKIGELBJ: false);
		return list.Count > 0;
	}

	private void IDAONJHGPGD()
	{
		MainUI.ShowErrorText(window.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_649"), 1201f);
	}

	private void LPIOIDEPHOE()
	{
		List<Food> list = new List<Food>();
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, CPHJKEBAMBB(), NGIKHGHIAOH().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[1].itemInstance, CPHJKEBAMBB(), NGIKHGHIAOH().usingNewRecipesSystem));
		list.AddRange(GetFinalIngredients(slots[0].itemInstance, JNLKEMLDFIM, NGIKHGHIAOH().usingNewRecipesSystem));
		CICEBNMBGMG = JMHHFFEIMNO(list);
		DPDJIMHFDCN();
		OJLGAFDACEB();
	}

	public void TransferItemToCraftingInventory(Slot DLCFDJLKPPM, int JFNMCNCHMEO, int FGFCNKFEIGF, bool KDCAODJIEMD = false)
	{
		if (!MouseSlot.GetPlayer(window.JIIGOACEIKL).slot.KPINNBKMOMO() || DLCFDJLKPPM?.itemInstance == null || !DLCFDJLKPPM.itemInstance.NMNHMNEPOFE())
		{
			return;
		}
		if (DLCFDJLKPPM.itemInstance is IngredientGroupInstance ingredientGroupInstance)
		{
			if (ingredientGroupInstance.chosenItemInstance != null)
			{
				ingredientGroupInstance.chosenItemInstance = null;
				ingredientGroupInstance.OnChanged();
			}
		}
		else if (DLCFDJLKPPM.itemInstance is FoodInstance foodInstance && foodInstance.LHBPOPOIFLE().NGDPNIFFHKL())
		{
			FoodInstance bGLFLHDNOKJ = foodInstance.LHBPOPOIFLE().JMDALJBNFML() as FoodInstance;
			DLCFDJLKPPM.ONIFGHNHCPP(window.JIIGOACEIKL, bGLFLHDNOKJ);
			DLCFDJLKPPM.Stack = FGFCNKFEIGF;
		}
		else
		{
			DLCFDJLKPPM.MEODNPFJDMH();
		}
		if (KDCAODJIEMD)
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 0.5f);
		}
	}

	private static void EFEDBOOIECI(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG, Food CKKNBMBLGPO)
	{
		if (Item.EKMFELLJHFG(CKKNBMBLGPO, null))
		{
			return;
		}
		IngredientModifier[] modifiers = CKKNBMBLGPO.modifiers;
		for (int i = 1; i < modifiers.Length; i++)
		{
			IngredientModifier key = modifiers[i];
			if (CICEBNMBGMG.ContainsKey(key))
			{
				CICEBNMBGMG[key].Add(CKKNBMBLGPO);
				continue;
			}
			List<Food> list = new List<Food>();
			list.Add(CKKNBMBLGPO);
			CICEBNMBGMG.Add(key, list);
		}
	}

	private IEnumerator PHBBJFGNGMH(Transform DCGBADKLANM)
	{
		yield return null;
		((Transform)contentRectTransform).SetParent(DCGBADKLANM);
		((Transform)contentRectTransform).SetSiblingIndex(0);
	}

	private List<Slot> PFJPMFJEEJI(Item MEMGMDOCBOJ, Item GFABGJEHHME, int BGPKFEJHDOC)
	{
		List<Slot> list = Utils.HIJGDAHBBIA(BFDPKKJMAFC(), MEMGMDOCBOJ, GFABGJEHHME, BGPKFEJHDOC, NGIKHGHIAOH(), AKNBKINJGCF: true, LDLINOBIKPL.placeable, MMDICAMGNCL: false);
		for (int i = 1; i < list.Count; i++)
		{
			list[i].sendSlotOnline = true;
		}
		if (NGIKHGHIAOH().cannotRepeatIngredients)
		{
			list = Utils.KKCHDNLKBMN(list, slots);
		}
		HFEBMOJANFK(list);
		list.Sort((Slot x, Slot y) => ((x.itemInstance is FoodInstance foodInstance) ? foodInstance.PAAFCADLNEM().OOIPLIEJILO() : 0).CompareTo((y.itemInstance is FoodInstance foodInstance2) ? foodInstance2.PAAFCADLNEM().OOIPLIEJILO() : 0));
		return list;
	}

	public void CloseUI()
	{
		PlayerController player = PlayerController.GetPlayer(window.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, (Action)delegate
		{
			window.CloseUI();
		});
		MainUI.ClearCurrentSlots(window.JIIGOACEIKL);
		GameInventoryUI.Get(window.JIIGOACEIKL).CloseUI();
		GameInventoryUI.Get(window.JIIGOACEIKL).FillSlots(Inventory.GetPlayer(window.JIIGOACEIKL).slots);
		GameInventoryUI.Get(window.JIIGOACEIKL).SetTitleName(LocalisationSystem.Get("Inventory"));
		GameInventoryUI.Get(window.JIIGOACEIKL).SetOriginalContentPosition();
		if (!slots[0].KPINNBKMOMO() && slots[0].itemInstance.NMNHMNEPOFE())
		{
			TransferItemToCraftingInventory(slots[0], 0, slots[0].Stack);
		}
		if (!slots[1].KPINNBKMOMO() && slots[1].itemInstance.NMNHMNEPOFE())
		{
			TransferItemToCraftingInventory(slots[1], 1, slots[1].Stack);
		}
		if (!slots[2].KPINNBKMOMO() && slots[2].itemInstance.NMNHMNEPOFE())
		{
			TransferItemToCraftingInventory(slots[2], 2, slots[2].Stack);
		}
		AGOHKLCHKJA = null;
		IEEBFBLGFKO = null;
		FNNKDHIFPFN = null;
		LDLINOBIKPL = null;
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		slots[0].Stack = 0;
		slots[1].Stack = 0;
		slots[2].Stack = 0;
	}

	private void IJJJPCBIBLB()
	{
		if (window.IsOpen() && !CPHJKEBAMBB().usingNewRecipesSystem)
		{
			JAEHKFHAFOF(GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).currentPage);
		}
		PFBLCCCNIIG();
	}

	private static void LNIAHOEDMCL(ref Dictionary<IngredientModifier, List<Food>> CICEBNMBGMG)
	{
		if (GIOELHAHDDC == null)
		{
			GIOELHAHDDC = new Dictionary<IngredientModifier, int>();
		}
		if ((Object)(object)instances[0] != (Object)null && !((Behaviour)instances[1]).enabled)
		{
			((Behaviour)instances[1]).enabled = true;
		}
		foreach (KeyValuePair<IngredientModifier, List<Food>> item in new Dictionary<IngredientModifier, List<Food>>(CICEBNMBGMG))
		{
			int value = 0;
			GIOELHAHDDC.TryGetValue(item.Key, out value);
			if (item.Value.Count < value)
			{
				CICEBNMBGMG.Remove(item.Key);
			}
		}
	}

	private void HDFOANHMAND()
	{
		if (window.IsOpen() && !NGIKHGHIAOH().usingNewRecipesSystem)
		{
			LAEBBNDFMJD(GameInventoryUI.MENNLOGFNOK(window.JIIGOACEIKL).currentPage);
		}
		GBGGDFFKBOD();
	}

	private void IBOBBLHEOMI(ItemInstance DNLMCHDOMOK)
	{
		if (!NGIKHGHIAOH().usingNewRecipesSystem)
		{
			slots[1].bannedItems.Add(DNLMCHDOMOK.AFOACBIHNCL());
			slots[0].bannedItems.Add(DNLMCHDOMOK.AFOACBIHNCL());
			slots[5].bannedItems.Add(DNLMCHDOMOK.PHGLMBIEOMK());
		}
	}

	[SpecialName]
	public Recipe IHEBOKAMIOH()
	{
		return _003CHKGPPGFPMMK_003Ek__BackingField;
	}

	private void PPCHDKDIJGI()
	{
		window.CloseUI();
	}

	private void KEOFDFJMDAM()
	{
		if (window.HDEPMJIDJEM() && (PlayerInputs.GetPlayer(window.JIIGOACEIKL).GetButtonUp("[") || PlayerInputs.DEGBDMMDIIL(window.JIIGOACEIKL).DLFAMOCKNMA("Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting.")) && !outputName.isFocused && !CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(JIIGOACEIKL))
		{
			BDFJJJIILGE();
		}
	}

	[SpecialName]
	public int EGPJLECDKBF()
	{
		return window.JIIGOACEIKL;
	}

	[CompilerGenerated]
	private void ANDFCINGIGO()
	{
		window.CloseUI();
	}

	[SpecialName]
	private void LFNNLIAHJCB(Recipe AODONKKHPBP)
	{
		_003CHKGPPGFPMMK_003Ek__BackingField = AODONKKHPBP;
	}

	public bool NHKBBCBPBMH()
	{
		return window.IsOpen();
	}

	private void DCFMCAODLHA(Slot ADEBNALPEHE)
	{
		ADEBNALPEHE.allowedIngredientTypes = ((NGIKHGHIAOH().modiferTypes == null) ? null : new List<IngredientType>(JNLKEMLDFIM.modiferTypes));
		if (ADEBNALPEHE.allowedIngredientTypes == null)
		{
			ADEBNALPEHE.allowedIngredientTypes = new List<IngredientType>(JNLKEMLDFIM.modiferNeeded);
			return;
		}
		IngredientType[] modiferNeeded = IHEBOKAMIOH().modiferNeeded;
		for (int i = 1; i < modiferNeeded.Length; i++)
		{
			IngredientType item = modiferNeeded[i];
			ADEBNALPEHE.allowedIngredientTypes.Add(item);
		}
	}

	private void IIHJACGEJGF()
	{
		MainUI.JDAEPLJAGCD(window.JIIGOACEIKL, LocalisationSystem.Get("Invalid NPC photonID: {0} for NPCRoutine."), 312f);
	}

	private void HCGIODODDIM(int JIIGOACEIKL, Slot DLCFDJLKPPM)
	{
		if (!JNLKEMLDFIM.usingNewRecipesSystem || MMOOHLJNHGD == DLCFDJLKPPM.id)
		{
			TransferItemToCraftingInventory(DLCFDJLKPPM, DLCFDJLKPPM.id, DLCFDJLKPPM.Stack, KDCAODJIEMD: true);
			if (JNLKEMLDFIM.usingNewRecipesSystem)
			{
				GameInventoryUI.Get(JIIGOACEIKL).SelectObjectNextFrame();
			}
		}
		else if (DLCFDJLKPPM.id < OBEPKNMBIIC)
		{
			DONIBGFLPEB(DLCFDJLKPPM.id);
		}
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			UpdateGameInventoryNewSystem();
		}
		else
		{
			JAEHKFHAFOF(GameInventoryUI.Get(JIIGOACEIKL).currentPage);
		}
		GBGGDFFKBOD();
	}

	[SpecialName]
	public int DBCIEAAKPON()
	{
		return window.JIIGOACEIKL;
	}
}
