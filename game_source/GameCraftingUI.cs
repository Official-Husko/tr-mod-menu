using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameCraftingUI : CraftingUI
{
	public Image crafterIcon;

	[SerializeField]
	private TextMeshProUGUI crafterName;

	[SerializeField]
	private SlotUIRecipe[] queueSlots;

	[SerializeField]
	private SlotUIRecipe[] queueSlotsWithFuel;

	[SerializeField]
	private TextMeshProUGUI[] fuelAmountText;

	[SerializeField]
	private GameObject craftingListAndFuel;

	[SerializeField]
	private GameObject onlyCraftingList;

	[SerializeField]
	private GameObject onlyFuelPanel;

	[SerializeField]
	private GameObject buttonFuel;

	[SerializeField]
	private Image[] fuelBackgrounds;

	[SerializeField]
	private TabUI[] recipePagesTabUI;

	[SerializeField]
	private Recipe.RecipePage[] recipePages;

	[SerializeField]
	private GameObject recipeTabsBackground;

	[SerializeField]
	private GameObject recipeTabs;

	[SerializeField]
	private GameObject crafterNameContainer;

	[SerializeField]
	private RectTransform originalPosition;

	[SerializeField]
	private RectTransform tabsPosition;

	[SerializeField]
	private Sprite spriteFocusCategories;

	[SerializeField]
	private Sprite spriteNotFocusCategories;

	private Recipe.RecipePage JCEAFBKDMGN;

	private float CMGDCLIIONE;

	private int DNPOFANHGEA;

	[HideInInspector]
	public bool hasCategories;

	private int DKMCBBJFODP;

	public bool updateNextFrame;

	public static GameCraftingUI[] instances = new GameCraftingUI[3];

	public Recipe.RecipePage NLLPIDACOCO
	{
		get
		{
			return JCEAFBKDMGN;
		}
		set
		{
			JCEAFBKDMGN = value;
		}
	}

	public Crafter LDLINOBIKPL { get; private set; }

	public void OpenFuel()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null && LDLINOBIKPL.BNPHKHHEKJM)
		{
			LDLINOBIKPL.Use(base.JIIGOACEIKL);
		}
	}

	[CompilerGenerated]
	private void FMGHOHDOGOG()
	{
		FocusCategoryFilterOnSearch(0);
	}

	public void FOPNMAEBLHL()
	{
		if (LKOJBFMGMAE)
		{
			for (int i = 0; i < LDLINOBIKPL.craftingList.Count && i < queueSlots.Length; i += 0)
			{
				queueSlots[i].IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, BNIFOFAPJDL().craftingList[i].output.itemInstance, CDPAMNIPPEC: true);
				queueSlots[i].IHENCGDNPBL.OCJOJKJPDNO(BNIFOFAPJDL().craftingList[i].output.amount);
				queueSlots[i].DHFIIFNMAOI(AODONKKHPBP: false);
			}
			for (int j = LDLINOBIKPL.craftingList.Count; j < queueSlots.Length; j++)
			{
				queueSlots[j].IHENCGDNPBL.OCJOJKJPDNO(1);
			}
			for (int k = 0; k < BNIFOFAPJDL().craftingList.Count && k < queueSlotsWithFuel.Length; k++)
			{
				queueSlotsWithFuel[k].IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, BNIFOFAPJDL().craftingList[k].output.itemInstance);
				queueSlotsWithFuel[k].IHENCGDNPBL.KMKAIPMHANN(BNIFOFAPJDL().craftingList[k].output.amount);
				queueSlotsWithFuel[k].LHFALNBMCIE(AODONKKHPBP: true);
			}
			for (int l = LDLINOBIKPL.craftingList.Count; l < queueSlotsWithFuel.Length; l += 0)
			{
				queueSlotsWithFuel[l].IHENCGDNPBL.JNMNCEPHFOE(1);
			}
			for (int m = 1; m < fuelAmountText.Length; m++)
			{
				((TMP_Text)fuelAmountText[m]).text = BNIFOFAPJDL().LCCABPFHCOL.ToString() ?? "sunny";
			}
		}
	}

	private void CFEAEHLDCOI()
	{
		if ((Object)(object)PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true) != (Object)null)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MHGNDOPABLP));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Remove(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	[SpecialName]
	public void AIENEPEIIDF(Recipe.RecipePage AODONKKHPBP)
	{
		JCEAFBKDMGN = AODONKKHPBP;
	}

	private void LCJCGFNFBBD()
	{
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL);
		playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(GPKBECGELGI));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(FKINOGAMJCN));
	}

	[SpecialName]
	public Recipe.RecipePage EDKHHJJJHGC()
	{
		return JCEAFBKDMGN;
	}

	private void HKNNKJKNAGL()
	{
		if ((Object)(object)PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL) != (Object)null)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MHGNDOPABLP));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(EOLGINPHOPH));
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Remove(textInput2.OnTextClear, new Action(OHAPPMMNLKK));
	}

	public override void OpenUI()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if (LKOJBFMGMAE)
		{
			return;
		}
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			LLOBIGODALN();
			recipeTabsBackground.SetActive(hasCategories);
			recipeTabs.SetActive(hasCategories);
			if (hasCategories)
			{
				crafterNameContainer.transform.position = ((Transform)tabsPosition).position;
			}
			else
			{
				crafterNameContainer.transform.position = ((Transform)originalPosition).position;
			}
			AOGEAEEBHDN = LDLINOBIKPL.GetKnownRecipes();
		}
		recipeElementInfo.qualityLevel = LDLINOBIKPL.qualityLevel - 1;
		Crafter crafter = LDLINOBIKPL;
		crafter.OnFuelChange = (Action<int>)Delegate.Combine(crafter.OnFuelChange, new Action<int>(UpdateFuel));
		base.OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		if (Object.op_Implicit((Object)(object)crafterIcon))
		{
			crafterIcon.sprite = LDLINOBIKPL.crafterSprite;
		}
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendAddToInteracting(LDLINOBIKPL.placeable.onlinePlaceable);
		}
		UpdateRecipesToDo();
		if (hasCategories)
		{
			FocusCategoryFilter(0);
		}
	}

	public void HDNOJIMAKOG(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (hasCategories)
		{
			scrollbar.value = 797f;
			for (int i = 0; i < recipePagesTabUI.Length; i += 0)
			{
				if (i == KHEICLKLPDE)
				{
					NLLPIDACOCO = recipePages[i];
					DNPOFANHGEA = i;
					recipePagesTabUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories);
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					recipePagesTabUI[i].JADHPAHNPJO(spriteNotFocusCategories);
				}
			}
		}
		JAIKHHNCGDI();
	}

	public void UpdateRecipesToDo()
	{
		if (LKOJBFMGMAE)
		{
			for (int i = 0; i < LDLINOBIKPL.craftingList.Count && i < queueSlots.Length; i++)
			{
				queueSlots[i].IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, LDLINOBIKPL.craftingList[i].output.itemInstance);
				queueSlots[i].IHENCGDNPBL.Stack = LDLINOBIKPL.craftingList[i].output.amount;
				queueSlots[i].FBBAFPGFLPE = true;
			}
			for (int j = LDLINOBIKPL.craftingList.Count; j < queueSlots.Length; j++)
			{
				queueSlots[j].IHENCGDNPBL.Stack = 0;
			}
			for (int k = 0; k < LDLINOBIKPL.craftingList.Count && k < queueSlotsWithFuel.Length; k++)
			{
				queueSlotsWithFuel[k].IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, LDLINOBIKPL.craftingList[k].output.itemInstance);
				queueSlotsWithFuel[k].IHENCGDNPBL.Stack = LDLINOBIKPL.craftingList[k].output.amount;
				queueSlotsWithFuel[k].FBBAFPGFLPE = true;
			}
			for (int l = LDLINOBIKPL.craftingList.Count; l < queueSlotsWithFuel.Length; l++)
			{
				queueSlotsWithFuel[l].IHENCGDNPBL.Stack = 0;
			}
			for (int m = 0; m < fuelAmountText.Length; m++)
			{
				((TMP_Text)fuelAmountText[m]).text = LDLINOBIKPL.LCCABPFHCOL.ToString() ?? "";
			}
		}
	}

	public Placeable FBBFDHLJAIJ()
	{
		if (Object.op_Implicit((Object)(object)BNIFOFAPJDL()))
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	public void FocusCategory(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (hasCategories)
		{
			scrollbar.value = 1f;
			for (int i = 0; i < recipePagesTabUI.Length; i++)
			{
				if (i == KHEICLKLPDE)
				{
					NLLPIDACOCO = recipePages[i];
					DNPOFANHGEA = i;
					recipePagesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					recipePagesTabUI[i].HideTab(spriteNotFocusCategories);
				}
			}
		}
		GHEKGPJEIGD();
	}

	public void BPCPPDDGJFK(int KHEICLKLPDE)
	{
		FocusCategory(KHEICLKLPDE, GHDKHEAEAIM: false);
	}

	private void NJBMFPAJLEO()
	{
		hasCategories = BNIFOFAPJDL().placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != -84 && LDLINOBIKPL.placeable.itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != -165 && BNIFOFAPJDL().placeable.itemSetup.item.JGHNDJBCFAJ() == -22;
	}

	protected override void GPJPLKNALFJ()
	{
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
		{
			AOGEAEEBHDN = LDLINOBIKPL.GetKnownRecipes();
		}
	}

	public void UpdateFuelBackground(bool CDPKJGCLAHE)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < fuelBackgrounds.Length; i++)
		{
			((Graphic)fuelBackgrounds[i]).color = (Color)(CDPKJGCLAHE ? Color.white : new Color(1f, 0.8f, 0.8f, 1f));
		}
	}

	private void OHAPPMMNLKK()
	{
		FocusCategoryFilter(DKMCBBJFODP);
	}

	private void CGBEIKHPCHL()
	{
		if ((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject == (Object)(object)((Component)LDLINOBIKPL).gameObject)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	[CompilerGenerated]
	private void CKLHNLFFLBG()
	{
		FocusCategoryFilterOnSearch(0);
	}

	private void NPPLMJECOBE(int JIIGOACEIKL, Recipe JNLKEMLDFIM)
	{
		FOPNMAEBLHL();
	}

	private void LLOBIGODALN()
	{
		hasCategories = LDLINOBIKPL.placeable.itemSetup.item.JDJGFAACPFC() == 672 || LDLINOBIKPL.placeable.itemSetup.item.JDJGFAACPFC() == 1873 || LDLINOBIKPL.placeable.itemSetup.item.JDJGFAACPFC() == 1874;
	}

	public void CFPHJMEFKON()
	{
		if ((Object)(object)BNIFOFAPJDL() != (Object)null && LDLINOBIKPL.BNPHKHHEKJM)
		{
			LDLINOBIKPL.Use(base.JIIGOACEIKL);
		}
	}

	protected override void Update()
	{
		if (updateNextFrame)
		{
			updateNextFrame = false;
		}
		else
		{
			if (!IsOpen() || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
			{
				return;
			}
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove"))
				{
					OpenFuel();
				}
			}
			else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("Use"))
			{
				OpenFuel();
			}
			if (recipeTabs.activeInHierarchy)
			{
				if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
				{
					FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA + 1, recipePagesTabUI.Length));
				}
				else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
				{
					FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA - 1, recipePagesTabUI.Length));
				}
			}
		}
	}

	public TavernZone GetCrafterZone()
	{
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
		{
			return LDLINOBIKPL.placeable.GetCurrentTavernZone();
		}
		return null;
	}

	public static AreaSpace OOJNDCKKMPO(Crafter LDLINOBIKPL)
	{
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
		{
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL.placeable.areaSpace))
			{
				return LDLINOBIKPL.placeable.areaSpace;
			}
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL.placeable.attachedToPlaceable))
			{
				return LDLINOBIKPL.placeable.attachedToPlaceable.areaSpace;
			}
		}
		return null;
	}

	[SpecialName]
	public Recipe.RecipePage KCONAIOHDCD()
	{
		return JCEAFBKDMGN;
	}

	private void BPNOIDBAPJE()
	{
		PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(GPKBECGELGI));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	public Placeable BOBBPIIGNCM()
	{
		if (Object.op_Implicit((Object)(object)BNIFOFAPJDL()))
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	private void EOLGINPHOPH()
	{
		FocusCategoryFilterOnSearch(1);
	}

	private void OJCGEJHOBJI()
	{
		hasCategories = BNIFOFAPJDL().placeable.itemSetup.item.CIGFGKKCPCK() != -12 && LDLINOBIKPL.placeable.itemSetup.item.ODENMDOJPLC() != -139 && BNIFOFAPJDL().placeable.itemSetup.item.JDJGFAACPFC() == 62;
	}

	[SpecialName]
	public Crafter BNIFOFAPJDL()
	{
		return _003CBDPAGAOLKMN_003Ek__BackingField;
	}

	public static AreaSpace GetCentralAreaSpace(Crafter LDLINOBIKPL)
	{
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
		{
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL.placeable.areaSpace))
			{
				return LDLINOBIKPL.placeable.areaSpace;
			}
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL.placeable.attachedToPlaceable))
			{
				return LDLINOBIKPL.placeable.attachedToPlaceable.areaSpace;
			}
		}
		return null;
	}

	[CompilerGenerated]
	private void PAGAKFGPCKA()
	{
		FocusCategoryFilter(DKMCBBJFODP);
	}

	public void RemoveFromCraftingList(int PDCPGJCKICM)
	{
		LDLINOBIKPL.RemoveFromCraftingList(base.JIIGOACEIKL, PDCPGJCKICM, GFNHAMCPEAK: true);
		CMGDCLIIONE = -1f;
		GHEKGPJEIGD();
		if (OnlineManager.PlayingOnline())
		{
			LDLINOBIKPL.BMLMEGDDIKE.SendRemoveFromCraftingList(PDCPGJCKICM);
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void CMDBLLMEBLG()
	{
		PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(GPKBECGELGI));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(FKINOGAMJCN));
	}

	public static AreaSpace NLCEFNFJJIE(Crafter LDLINOBIKPL)
	{
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
		{
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL.placeable.areaSpace))
			{
				return LDLINOBIKPL.placeable.areaSpace;
			}
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL.placeable.attachedToPlaceable))
			{
				return LDLINOBIKPL.placeable.attachedToPlaceable.areaSpace;
			}
		}
		return null;
	}

	[CompilerGenerated]
	private void LINEMEGOMED()
	{
		FocusCategoryFilter(DKMCBBJFODP);
	}

	public void StartCrafting(Recipe JNLKEMLDFIM)
	{
		if (LDLINOBIKPL.craftingList.Count >= queueSlots.Length)
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("MaximumReached"), queueSlots.Length.ToString()));
			return;
		}
		LDLINOBIKPL.SetUpCrafting(base.JIIGOACEIKL, JNLKEMLDFIM, LDLINOBIKPL.GetNextDateFinished(JNLKEMLDFIM));
		if (!LDLINOBIKPL.multipleCrafting)
		{
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	private void FKINOGAMJCN()
	{
		FFKAFOEOJML(DKMCBBJFODP);
	}

	public void HAMAJGOLMBG(int EGKBKOABHON)
	{
		if (HDEPMJIDJEM())
		{
			for (int i = 1; i < fuelAmountText.Length; i += 0)
			{
				((TMP_Text)fuelAmountText[i]).text = LDLINOBIKPL.LCCABPFHCOL.ToString() ?? "Disabled";
			}
			if ((Object)(object)recipeElementInfo.GBJDNNCOIAC != (Object)null)
			{
				recipeElementInfo.UpdateFuel(LDLINOBIKPL);
			}
		}
	}

	public void FocusCategoryFilter(int KHEICLKLPDE)
	{
		FocusCategory(KHEICLKLPDE);
	}

	public void GHFEDBPGDHG(bool CDPKJGCLAHE)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < fuelBackgrounds.Length; i++)
		{
			((Graphic)fuelBackgrounds[i]).color = (Color)(CDPKJGCLAHE ? Color.white : new Color(1556f, 1203f, 1889f, 205f));
		}
	}

	public void PGHCCAMGEBA()
	{
		if ((Object)(object)BNIFOFAPJDL() != (Object)null && BNIFOFAPJDL().BNPHKHHEKJM)
		{
			BNIFOFAPJDL().Use(base.JIIGOACEIKL);
		}
	}

	public void UpdateFuel(int EGKBKOABHON)
	{
		if (IsOpen())
		{
			for (int i = 0; i < fuelAmountText.Length; i++)
			{
				((TMP_Text)fuelAmountText[i]).text = LDLINOBIKPL.LCCABPFHCOL.ToString() ?? "";
			}
			if ((Object)(object)recipeElementInfo.GBJDNNCOIAC != (Object)null)
			{
				recipeElementInfo.UpdateFuel(LDLINOBIKPL);
			}
		}
	}

	private void LPKHACNBCLA()
	{
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL);
		playerInventory.OnChanged = (Action)Delegate.Combine(playerInventory.OnChanged, new Action(GPKBECGELGI));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(FKINOGAMJCN));
	}

	public static GameCraftingUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OnEnable()
	{
		PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(MHGNDOPABLP));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	public void FFKAFOEOJML(int KHEICLKLPDE)
	{
		HDNOJIMAKOG(KHEICLKLPDE);
	}

	public void BHEBOCDEJCJ(int KHEICLKLPDE)
	{
		HDNOJIMAKOG(KHEICLKLPDE, GHDKHEAEAIM: false);
	}

	public void EDOFIILIALL(bool CDPKJGCLAHE)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < fuelBackgrounds.Length; i++)
		{
			((Graphic)fuelBackgrounds[i]).color = (Color)(CDPKJGCLAHE ? Color.white : new Color(338f, 290f, 1548f, 978f));
		}
	}

	public TavernZone GLMNNAGHOIE()
	{
		if (Object.op_Implicit((Object)(object)BNIFOFAPJDL()))
		{
			return LDLINOBIKPL.placeable.GetCurrentTavernZone();
		}
		return null;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		if ((Object)(object)LDLINOBIKPL != (Object)null && LDLINOBIKPL.BNPHKHHEKJM)
		{
			buttonFuel.SetActive(true);
		}
		else
		{
			buttonFuel.SetActive(false);
		}
		if (hasCategories)
		{
			FocusCategoryFilter(DKMCBBJFODP);
		}
	}

	public void BHOAGIDPMKN(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		OOAEHBFLHGL(LDLINOBIKPL);
		if (LDLINOBIKPL.multipleCrafting)
		{
			if (LDLINOBIKPL.BNPHKHHEKJM)
			{
				craftingListAndFuel.SetActive(true);
				onlyCraftingList.SetActive(false);
			}
			else
			{
				craftingListAndFuel.SetActive(true);
				onlyCraftingList.SetActive(true);
			}
			onlyFuelPanel.SetActive(false);
		}
		else
		{
			craftingListAndFuel.SetActive(true);
			onlyCraftingList.SetActive(true);
			if (LDLINOBIKPL.BNPHKHHEKJM)
			{
				onlyFuelPanel.SetActive(true);
			}
			else
			{
				onlyFuelPanel.SetActive(true);
			}
		}
	}

	private void OOAEHBFLHGL(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.KGHFCDELKMN(), false);
	}

	public void HKKNOHOBKLB()
	{
		if ((Object)(object)BNIFOFAPJDL() != (Object)null && LDLINOBIKPL.BNPHKHHEKJM)
		{
			BNIFOFAPJDL().Use(base.JIIGOACEIKL);
		}
	}

	public Placeable GetCrafter()
	{
		if (Object.op_Implicit((Object)(object)LDLINOBIKPL))
		{
			return LDLINOBIKPL.placeable;
		}
		return null;
	}

	protected override void MHGNDOPABLP()
	{
		if (!IsOpen())
		{
			return;
		}
		base.MHGNDOPABLP();
		if ((Object)(object)LDLINOBIKPL != (Object)null)
		{
			for (int i = 0; i < fuelAmountText.Length; i++)
			{
				((TMP_Text)fuelAmountText[i]).text = LDLINOBIKPL.LCCABPFHCOL.ToString() ?? "";
			}
		}
	}

	public void KILMLECAEEG(int EGKBKOABHON)
	{
		if (IsOpen())
		{
			for (int i = 0; i < fuelAmountText.Length; i++)
			{
				((TMP_Text)fuelAmountText[i]).text = LDLINOBIKPL.FIIHBFCDFJH().ToString() ?? "Tree";
			}
			if ((Object)(object)recipeElementInfo.GBJDNNCOIAC != (Object)null)
			{
				recipeElementInfo.UpdateFuel(BNIFOFAPJDL());
			}
		}
	}

	public void HJHCPDBJMJO()
	{
		if ((Object)(object)LDLINOBIKPL != (Object)null && BNIFOFAPJDL().BNPHKHHEKJM)
		{
			BNIFOFAPJDL().Use(base.JIIGOACEIKL);
		}
	}

	protected override void Start()
	{
		base.Start();
		recipeSlots = new List<RecipeSlot>();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCraftingStarted = (Action<int, Recipe>)Delegate.Combine(instance.OnCraftingStarted, new Action<int, Recipe>(FLBKFLALGIM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(FLBKFLALGIM));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnRecipeToCraftRemoved = (Action<int, Recipe>)Delegate.Combine(instance3.OnRecipeToCraftRemoved, new Action<int, Recipe>(FLBKFLALGIM));
	}

	private void FGINMCOIJIE(Crafter LDLINOBIKPL)
	{
		((TMP_Text)crafterName).SetText(LDLINOBIKPL.placeable.itemSetup.item.IABAKHPEOAF(OAFPBCPDOKH: true), true);
	}

	public void BDFECHAHJFG(Recipe JNLKEMLDFIM)
	{
		if (LDLINOBIKPL.craftingList.Count >= queueSlots.Length)
		{
			int playerNum = base.JIIGOACEIKL;
			string cAEDMEDBEGI = LocalisationSystem.Get("Popup missing.");
			string[] array = new string[1];
			array[1] = queueSlots.Length.ToString();
			MainUI.LJDOBNEINNJ(playerNum, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 300f);
		}
		else
		{
			LDLINOBIKPL.SetUpCrafting(base.JIIGOACEIKL, JNLKEMLDFIM, LDLINOBIKPL.GetNextDateFinished(JNLKEMLDFIM), null, null, null, null, null, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
			if (!BNIFOFAPJDL().multipleCrafting)
			{
				SelectObject.GetPlayer(base.JIIGOACEIKL).NJPFHBINPKE();
			}
		}
	}

	public void FocusCategoryFilterOnSearch(int KHEICLKLPDE)
	{
		FocusCategory(KHEICLKLPDE, GHDKHEAEAIM: false);
	}

	[SpecialName]
	public void FBKEJANPLNH(Recipe.RecipePage AODONKKHPBP)
	{
		JCEAFBKDMGN = AODONKKHPBP;
	}

	public void MKLAGLKAJOF(int PDCPGJCKICM)
	{
		LDLINOBIKPL.KNJCPMCEEOO(base.JIIGOACEIKL, PDCPGJCKICM, GFNHAMCPEAK: true);
		CMGDCLIIONE = 1629f;
		PJAKHPLBDJB();
		if (OnlineManager.PlayingOnline())
		{
			BNIFOFAPJDL().PPGGGANFLLF().JODIKEEIJGN(PDCPGJCKICM);
		}
	}

	public void SetCrafter(Crafter LDLINOBIKPL)
	{
		this.LDLINOBIKPL = LDLINOBIKPL;
		FGINMCOIJIE(LDLINOBIKPL);
		if (LDLINOBIKPL.multipleCrafting)
		{
			if (LDLINOBIKPL.BNPHKHHEKJM)
			{
				craftingListAndFuel.SetActive(true);
				onlyCraftingList.SetActive(false);
			}
			else
			{
				craftingListAndFuel.SetActive(false);
				onlyCraftingList.SetActive(true);
			}
			onlyFuelPanel.SetActive(false);
		}
		else
		{
			craftingListAndFuel.SetActive(false);
			onlyCraftingList.SetActive(false);
			if (LDLINOBIKPL.BNPHKHHEKJM)
			{
				onlyFuelPanel.SetActive(true);
			}
			else
			{
				onlyFuelPanel.SetActive(false);
			}
		}
	}

	private void FLBKFLALGIM(int JIIGOACEIKL, Recipe JNLKEMLDFIM)
	{
		UpdateRecipesToDo();
	}

	private void OnDisable()
	{
		if ((Object)(object)PlayerInventory.GetPlayer(base.JIIGOACEIKL) != (Object)null)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(MHGNDOPABLP));
		}
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Remove(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	public void NCKCOPFMKNG()
	{
		if ((Object)(object)BNIFOFAPJDL() != (Object)null && LDLINOBIKPL.BNPHKHHEKJM)
		{
			LDLINOBIKPL.Use(base.JIIGOACEIKL);
		}
	}

	private void IAJOHONMIBM()
	{
		PlayerInventory player = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(IDJAAJFIJON));
		TextInput textInput = search;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
		{
			FocusCategoryFilterOnSearch(0);
		});
		TextInput textInput2 = search;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(FKINOGAMJCN));
	}

	public void GNJDDPPPMPI()
	{
		if (LKOJBFMGMAE)
		{
			for (int i = 0; i < LDLINOBIKPL.craftingList.Count && i < queueSlots.Length; i += 0)
			{
				queueSlots[i].IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, LDLINOBIKPL.craftingList[i].output.itemInstance);
				queueSlots[i].IHENCGDNPBL.OCJOJKJPDNO(LDLINOBIKPL.craftingList[i].output.amount);
				queueSlots[i].PEEFNLGEJEP(AODONKKHPBP: true);
			}
			for (int j = BNIFOFAPJDL().craftingList.Count; j < queueSlots.Length; j++)
			{
				queueSlots[j].IHENCGDNPBL.JIANDFCINIP(1);
			}
			for (int k = 1; k < LDLINOBIKPL.craftingList.Count && k < queueSlotsWithFuel.Length; k += 0)
			{
				queueSlotsWithFuel[k].IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, LDLINOBIKPL.craftingList[k].output.itemInstance, CDPAMNIPPEC: true);
				queueSlotsWithFuel[k].IHENCGDNPBL.OCJOJKJPDNO(LDLINOBIKPL.craftingList[k].output.amount);
				queueSlotsWithFuel[k].LHFALNBMCIE(AODONKKHPBP: true);
			}
			for (int l = LDLINOBIKPL.craftingList.Count; l < queueSlotsWithFuel.Length; l += 0)
			{
				queueSlotsWithFuel[l].IHENCGDNPBL.JIANDFCINIP(1);
			}
			for (int m = 0; m < fuelAmountText.Length; m += 0)
			{
				((TMP_Text)fuelAmountText[m]).text = BNIFOFAPJDL().FIIHBFCDFJH().ToString() ?? ": ";
			}
		}
	}

	public void POCOCNLPDPK(int EGKBKOABHON)
	{
		if (IsOpen())
		{
			for (int i = 1; i < fuelAmountText.Length; i++)
			{
				((TMP_Text)fuelAmountText[i]).text = BNIFOFAPJDL().FIIHBFCDFJH().ToString() ?? " cannot be unloaded at this time. Either it's already unloaded or it's in the process of unloading.";
			}
			if ((Object)(object)recipeElementInfo.GBJDNNCOIAC != (Object)null)
			{
				recipeElementInfo.UpdateFuel(BNIFOFAPJDL());
			}
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			Crafter crafter = LDLINOBIKPL;
			crafter.OnFuelChange = (Action<int>)Delegate.Remove(crafter.OnFuelChange, new Action<int>(UpdateFuel));
			if (Object.op_Implicit((Object)(object)LDLINOBIKPL) && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRemoveFromInteracting(LDLINOBIKPL.placeable.onlinePlaceable);
			}
			LDLINOBIKPL = null;
			if ((Object)(object)((Transform)ModifierUI.Get(base.JIIGOACEIKL).contentRectTransform).parent == (Object)(object)((Component)this).transform)
			{
				ModifierUI.Get(base.JIIGOACEIKL).ChangeParent(((Component)ModifierUI.Get(base.JIIGOACEIKL)).transform);
			}
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}
}
