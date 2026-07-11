using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipeElementUI : MonoBehaviour
{
	public enum CheckInventory
	{
		crafterInventory,
		playerInventory
	}

	public bool clickable;

	public Color normalColor;

	public Color redColor;

	public Image favorite;

	public GameObject[] infoToDisableIfNull;

	public SlotUIRecipe outputSlot;

	public SlotUIRecipe optionsSlot;

	private int JIIGOACEIKL = 1;

	[SerializeField]
	private Sprite favoriteSprite;

	[SerializeField]
	private Sprite notFavoriteSprite;

	[SerializeField]
	private SlotUIRecipe[] inputSlots;

	[SerializeField]
	private TextMeshProUGUI recipeName;

	[SerializeField]
	private TextMeshProUGUI timeText;

	[SerializeField]
	private TextMeshProUGUI fuelText;

	[SerializeField]
	private Image fuelIcon;

	[SerializeField]
	private GameObject redBoxFuel;

	[SerializeField]
	private RectTransform rectTransform;

	public int qualityLevel;

	private bool JKIAKMICLKF;

	private Coroutine ANKPDEANCEI;

	[SerializeField]
	private GameObject slotsGameObject;

	[SerializeField]
	private GameObject multiOptionGameObject;

	private Recipe JNLKEMLDFIM;

	private bool OEEPLPMIEOG;

	public bool needsMods;

	public CheckInventory checkInventory;

	public bool CDPKJGCLAHE { get; private set; }

	public bool FLNBPNIGDLC { get; private set; }

	public Recipe GBJDNNCOIAC
	{
		get
		{
			return JNLKEMLDFIM;
		}
		set
		{
			JNLKEMLDFIM = value;
			if ((Object)(object)JNLKEMLDFIM != (Object)null)
			{
				for (int i = 0; i < infoToDisableIfNull.Length; i++)
				{
					if (!infoToDisableIfNull[i].activeSelf)
					{
						infoToDisableIfNull[i].SetActive(true);
					}
				}
				PopulateElement();
				return;
			}
			for (int j = 0; j < infoToDisableIfNull.Length; j++)
			{
				if (infoToDisableIfNull[j].activeSelf)
				{
					infoToDisableIfNull[j].SetActive(false);
				}
			}
			favorite.sprite = notFavoriteSprite;
			outputSlot.IHENCGDNPBL.Stack = 0;
			outputSlot.redBox.SetActive(false);
			for (int k = 0; k < inputSlots.Length; k++)
			{
				inputSlots[k].IHENCGDNPBL.Stack = 0;
				inputSlots[k].redBox.SetActive(false);
			}
		}
	}

	private IEnumerator KCOICLLOIBD()
	{
		yield return (object)new WaitForSecondsRealtime(ItemTooltip.delayTime);
		if (!JKIAKMICLKF || !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			yield break;
		}
		ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(0f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x), outputSlot.IHENCGDNPBL.itemInstance);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = JNLKEMLDFIM.IABAKHPEOAF();
		if (outputSlot.IHENCGDNPBL.Stack > 1)
		{
			tooltipInfo.toolTipTitle = tooltipInfo.toolTipTitle + " (" + outputSlot.IHENCGDNPBL.Stack;
			if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen())
			{
				int num = (int)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeProduction, JNLKEMLDFIM);
				if (num > 0)
				{
					tooltipInfo.toolTipTitle = tooltipInfo.toolTipTitle + "<color=#A95A00>+" + num + "</color>";
				}
			}
			tooltipInfo.toolTipTitle += ")";
		}
		tooltipInfo.mainBody = "";
		if (!string.IsNullOrEmpty(outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IGDKFHCHEAJ(JIIGOACEIKL)))
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IGDKFHCHEAJ(JIIGOACEIKL) + "</color>";
			tooltipInfo.mainBody += "\n";
		}
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (i == 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			int num2 = CraftingInventory.NumberOfItems(JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, JNLKEMLDFIM.ingredientsNeeded[i].mod, AKNBKINJGCF: true, GameCraftingUI.Get(JIIGOACEIKL).GetCrafter(), !GameCraftingUI.Get(JIIGOACEIKL).IsOpen());
			if (num2 < Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[i].amount))
			{
				tooltipInfo.mainBody += "<color=#BF0000>";
			}
			tooltipInfo.mainBody += JNLKEMLDFIM.ingredientsNeeded[i].item.IABAKHPEOAF();
			if (JNLKEMLDFIM.ingredientsNeeded[i].amount > 1)
			{
				TooltipInfo tooltipInfo2 = tooltipInfo;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + " (" + num2 + "/" + JNLKEMLDFIM.ingredientsNeeded[i].amount + ")";
			}
			if (num2 < Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[i].amount))
			{
				tooltipInfo.mainBody += "</color>";
			}
			tooltipInfo.mainBody += "\n";
		}
		if (outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().comfort != 0)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().comfort + "</color>";
		}
		if (!outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().price.LNPODHBKGCH() && outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is Food)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> " + Money.CalculateSellPrice(outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true).ToString();
		}
		tooltipInfo.mainBody += "\n";
		tooltipInfo.mainBody += JNLKEMLDFIM.output.item.MOBLAPBAMIH();
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
	}

	public void DGMKJLGNLIB()
	{
		if (Object.op_Implicit((Object)(object)JNLKEMLDFIM))
		{
			RecipesBookUI.MAOAEHDKHDP(JIIGOACEIKL).BJDICINHNNH(this);
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void UpdateFuel(Crafter LDLINOBIKPL)
	{
		int num = ((JNLKEMLDFIM.fuel <= 0) ? JNLKEMLDFIM.fuel : ((int)Mathf.Max(1f, (float)JNLKEMLDFIM.fuel - LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.FuelDiscount, JNLKEMLDFIM))));
		CDPKJGCLAHE = num <= LDLINOBIKPL.LCCABPFHCOL;
		OEEPLPMIEOG = OLINHHPDINO();
		outputSlot.FBBAFPGFLPE = OEEPLPMIEOG;
		if (Object.op_Implicit((Object)(object)redBoxFuel))
		{
			redBoxFuel.SetActive(!CDPKJGCLAHE);
		}
	}

	public void OnDeselect()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			if (ANKPDEANCEI != null)
			{
				((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
			}
			PopulateElement();
			JKIAKMICLKF = false;
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public bool HAFMNCODGLP()
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem && !FAPFLLDKEAF() && !JNLKEMLDFIM.multiOptions && !needsMods)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("questDescGruel"), 1194f);
			return true;
		}
		if (!JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions)
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/TooDark/Entry/6/Dialogue Text"), 562f);
			return true;
		}
		Debug.Log((object)("Chisel" + JNLKEMLDFIM.IHPEMJCKHLG()));
		return true;
	}

	private void MCFIFCKNFJG(bool ACJFIEKCKEC, SlotUIRecipe PHJNJCJJHID)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (!ACJFIEKCKEC)
		{
			if (!JNLKEMLDFIM.multiOptions)
			{
				_ = FLNBPNIGDLC;
				FLNBPNIGDLC = false;
			}
			PHJNJCJJHID.FBBAFPGFLPE = false;
			((Graphic)PHJNJCJJHID.stackText).color = redColor;
		}
		else
		{
			PHJNJCJJHID.FBBAFPGFLPE = true;
			((Graphic)PHJNJCJJHID.stackText).color = normalColor;
		}
	}

	public void FavoriteClicked()
	{
		if (Object.op_Implicit((Object)(object)JNLKEMLDFIM))
		{
			RecipesBookUI.Get(JIIGOACEIKL).ToggleFavorite(this);
		}
	}

	private void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	[SpecialName]
	public bool CGDGOAAOGPG()
	{
		return _003CCHIDEAIJAKF_003Ek__BackingField;
	}

	public void HLKABDFJGNJ()
	{
		if (!clickable)
		{
			DGMKJLGNLIB();
			return;
		}
		if (OnlineManager.HHDBMDMFEMP() && (Object)(object)JNLKEMLDFIM != (Object)null && (Object)(object)JNLKEMLDFIM.reputationRequired != (Object)null && JNLKEMLDFIM.reputationRequired.repNumber > OnlineReputationManager.instance.milestoneMaster)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("SortByType"), 1951f);
			return;
		}
		if (JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions && !needsMods)
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Cat"), 533f);
			return;
		}
		if (!JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions)
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("eh"), 710f);
			return;
		}
		if (!CDPKJGCLAHE && JNLKEMLDFIM.fuel > 0)
		{
			CommonReferences.GGFJGHHHEJC.OnTryCraftNoFuel(JIIGOACEIKL);
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Warm"), 769f);
			return;
		}
		if (JNLKEMLDFIM.multiOptions)
		{
			ChooseSlotUI.EPLOMIBMKFC(JIIGOACEIKL).LBJKBMGMOKH(JNLKEMLDFIM);
			ChooseSlotUI.OFEFGPCGJDF(JIIGOACEIKL).IDLAGJNLPJL();
		}
		else if (needsMods)
		{
			if (GameCraftingUI.Get(JIIGOACEIKL).BGLJFMHCFJF() && Object.op_Implicit((Object)(object)GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL()))
			{
				ModifierUI.NIGDBMAOAEN(JIIGOACEIKL).isCraftable = OEEPLPMIEOG;
				ModifierUI.NIGDBMAOAEN(JIIGOACEIKL).HKEIKLFACDE(GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL, JNLKEMLDFIM);
			}
		}
		else
		{
			GameCraftingUI.Get(JIIGOACEIKL).BDFECHAHJFG(JNLKEMLDFIM);
		}
		MBNAAHELNHO();
	}

	private bool OLINHHPDINO()
	{
		OEEPLPMIEOG = CDPKJGCLAHE;
		OEEPLPMIEOG &= FLNBPNIGDLC;
		if (OnlineManager.ClientOnline() && (Object)(object)JNLKEMLDFIM != (Object)null && (Object)(object)JNLKEMLDFIM.reputationRequired != (Object)null && JNLKEMLDFIM.reputationRequired.repNumber > OnlineReputationManager.instance.milestoneMaster)
		{
			OEEPLPMIEOG = false;
		}
		return OEEPLPMIEOG;
	}

	public void ElementClicked()
	{
		if (!clickable)
		{
			FavoriteClicked();
			return;
		}
		if (OnlineManager.ClientOnline() && (Object)(object)JNLKEMLDFIM != (Object)null && (Object)(object)JNLKEMLDFIM.reputationRequired != (Object)null && JNLKEMLDFIM.reputationRequired.repNumber > OnlineReputationManager.instance.milestoneMaster)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("MasterMilestoneLower"));
			return;
		}
		if (JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions && !needsMods)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough ingredients"));
			return;
		}
		if (!JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough ingredients"));
			return;
		}
		if (!CDPKJGCLAHE && JNLKEMLDFIM.fuel > 0)
		{
			CommonReferences.GGFJGHHHEJC.OnTryCraftNoFuel(JIIGOACEIKL);
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough fuel"));
			return;
		}
		if (JNLKEMLDFIM.multiOptions)
		{
			ChooseSlotUI.Get(JIIGOACEIKL).UpdateInfo(JNLKEMLDFIM);
			ChooseSlotUI.Get(JIIGOACEIKL).OpenUI();
		}
		else if (needsMods)
		{
			if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen() && Object.op_Implicit((Object)(object)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL))
			{
				ModifierUI.Get(JIIGOACEIKL).isCraftable = OEEPLPMIEOG;
				ModifierUI.Get(JIIGOACEIKL).OpenUI(GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL, JNLKEMLDFIM);
			}
		}
		else
		{
			GameCraftingUI.Get(JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
		}
		PopulateElement();
	}

	private IEnumerator DLJLHEMLBFD()
	{
		yield return (object)new WaitForSecondsRealtime(ItemTooltip.delayTime);
		if (!JKIAKMICLKF || !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			yield break;
		}
		ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(0f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x), outputSlot.IHENCGDNPBL.itemInstance);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = JNLKEMLDFIM.IABAKHPEOAF();
		if (outputSlot.IHENCGDNPBL.Stack > 1)
		{
			tooltipInfo.toolTipTitle = tooltipInfo.toolTipTitle + " (" + outputSlot.IHENCGDNPBL.Stack;
			if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen())
			{
				int num = (int)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeProduction, JNLKEMLDFIM);
				if (num > 0)
				{
					tooltipInfo.toolTipTitle = tooltipInfo.toolTipTitle + "<color=#A95A00>+" + num + "</color>";
				}
			}
			tooltipInfo.toolTipTitle += ")";
		}
		tooltipInfo.mainBody = "";
		if (!string.IsNullOrEmpty(outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IGDKFHCHEAJ(JIIGOACEIKL)))
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IGDKFHCHEAJ(JIIGOACEIKL) + "</color>";
			tooltipInfo.mainBody += "\n";
		}
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (i == 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			int num2 = CraftingInventory.NumberOfItems(JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, JNLKEMLDFIM.ingredientsNeeded[i].mod, AKNBKINJGCF: true, GameCraftingUI.Get(JIIGOACEIKL).GetCrafter(), !GameCraftingUI.Get(JIIGOACEIKL).IsOpen());
			if (num2 < Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[i].amount))
			{
				tooltipInfo.mainBody += "<color=#BF0000>";
			}
			tooltipInfo.mainBody += JNLKEMLDFIM.ingredientsNeeded[i].item.IABAKHPEOAF();
			if (JNLKEMLDFIM.ingredientsNeeded[i].amount > 1)
			{
				TooltipInfo tooltipInfo2 = tooltipInfo;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + " (" + num2 + "/" + JNLKEMLDFIM.ingredientsNeeded[i].amount + ")";
			}
			if (num2 < Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[i].amount))
			{
				tooltipInfo.mainBody += "</color>";
			}
			tooltipInfo.mainBody += "\n";
		}
		if (outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().comfort != 0)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().comfort + "</color>";
		}
		if (!outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().price.LNPODHBKGCH() && outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is Food)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> " + Money.CalculateSellPrice(outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true).ToString();
		}
		tooltipInfo.mainBody += "\n";
		tooltipInfo.mainBody += JNLKEMLDFIM.output.item.MOBLAPBAMIH();
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
	}

	public void JEPEICHCAKL()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			if (ANKPDEANCEI != null)
			{
				((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
			}
			MBNAAHELNHO();
			JKIAKMICLKF = true;
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	[SpecialName]
	public void BDBBCBKLFOL(Recipe AODONKKHPBP)
	{
		JNLKEMLDFIM = AODONKKHPBP;
		if ((Object)(object)JNLKEMLDFIM != (Object)null)
		{
			for (int i = 1; i < infoToDisableIfNull.Length; i += 0)
			{
				if (!infoToDisableIfNull[i].activeSelf)
				{
					infoToDisableIfNull[i].SetActive(false);
				}
			}
			MBNAAHELNHO();
			return;
		}
		for (int j = 1; j < infoToDisableIfNull.Length; j++)
		{
			if (infoToDisableIfNull[j].activeSelf)
			{
				infoToDisableIfNull[j].SetActive(false);
			}
		}
		favorite.sprite = notFavoriteSprite;
		outputSlot.IHENCGDNPBL.JIANDFCINIP(1);
		outputSlot.redBox.SetActive(false);
		for (int k = 0; k < inputSlots.Length; k += 0)
		{
			inputSlots[k].IHENCGDNPBL.OCJOJKJPDNO(1);
			inputSlots[k].redBox.SetActive(false);
		}
	}

	private IEnumerator BKJKGMFLDCC()
	{
		yield return (object)new WaitForSecondsRealtime(ItemTooltip.delayTime);
		if (!JKIAKMICLKF || !PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			yield break;
		}
		ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)rectTransform).position.x + 4f * ((Transform)rectTransform).lossyScale.x, ((Transform)rectTransform).position.y + 4f * ((Transform)rectTransform).lossyScale.y), new Vector2(0f, (rectTransform.sizeDelta.y + 15f) * ((Transform)rectTransform).lossyScale.x), outputSlot.IHENCGDNPBL.itemInstance);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = JNLKEMLDFIM.IABAKHPEOAF();
		if (outputSlot.IHENCGDNPBL.Stack > 1)
		{
			tooltipInfo.toolTipTitle = tooltipInfo.toolTipTitle + " (" + outputSlot.IHENCGDNPBL.Stack;
			if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen())
			{
				int num = (int)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeProduction, JNLKEMLDFIM);
				if (num > 0)
				{
					tooltipInfo.toolTipTitle = tooltipInfo.toolTipTitle + "<color=#A95A00>+" + num + "</color>";
				}
			}
			tooltipInfo.toolTipTitle += ")";
		}
		tooltipInfo.mainBody = "";
		if (!string.IsNullOrEmpty(outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IGDKFHCHEAJ(JIIGOACEIKL)))
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<color=black>" + outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IGDKFHCHEAJ(JIIGOACEIKL) + "</color>";
			tooltipInfo.mainBody += "\n";
		}
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (i == 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			int num2 = CraftingInventory.NumberOfItems(JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, JNLKEMLDFIM.ingredientsNeeded[i].mod, AKNBKINJGCF: true, GameCraftingUI.Get(JIIGOACEIKL).GetCrafter(), !GameCraftingUI.Get(JIIGOACEIKL).IsOpen());
			if (num2 < Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[i].amount))
			{
				tooltipInfo.mainBody += "<color=#BF0000>";
			}
			tooltipInfo.mainBody += JNLKEMLDFIM.ingredientsNeeded[i].item.IABAKHPEOAF();
			if (JNLKEMLDFIM.ingredientsNeeded[i].amount > 1)
			{
				TooltipInfo tooltipInfo2 = tooltipInfo;
				tooltipInfo2.mainBody = tooltipInfo2.mainBody + " (" + num2 + "/" + JNLKEMLDFIM.ingredientsNeeded[i].amount + ")";
			}
			if (num2 < Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[i].amount))
			{
				tooltipInfo.mainBody += "</color>";
			}
			tooltipInfo.mainBody += "\n";
		}
		if (outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().comfort != 0)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#3662B5>" + LocalisationSystem.Get("Comfort") + ": " + outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().comfort + "</color>";
		}
		if (!outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().price.LNPODHBKGCH() && outputSlot.IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is Food)
		{
			TooltipInfo tooltipInfo2 = tooltipInfo;
			tooltipInfo2.mainBody = tooltipInfo2.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> " + Money.CalculateSellPrice(outputSlot.IHENCGDNPBL.itemInstance, HOECMANECIM: true).ToString();
		}
		tooltipInfo.mainBody += "\n";
		tooltipInfo.mainBody += JNLKEMLDFIM.output.item.MOBLAPBAMIH();
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
	}

	public bool CanCraft()
	{
		if (JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions && !needsMods)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough ingredients"));
			return false;
		}
		if (!JNLKEMLDFIM.usingNewRecipesSystem && !FLNBPNIGDLC && !JNLKEMLDFIM.multiOptions)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Not enough ingredients"));
			return false;
		}
		Debug.Log((object)("Crafting " + JNLKEMLDFIM.IABAKHPEOAF()));
		return true;
	}

	[SpecialName]
	public bool FAPFLLDKEAF()
	{
		return _003CIBEPPNPHGBP_003Ek__BackingField;
	}

	public void MBNAAHELNHO()
	{
		if ((Object)(object)JNLKEMLDFIM == (Object)null)
		{
			return;
		}
		for (int i = 0; i < inputSlots.Length; i += 0)
		{
			inputSlots[i].IHENCGDNPBL.KMKAIPMHANN(0);
		}
		outputSlot.IHENCGDNPBL.JNMNCEPHFOE(0);
		if (Item.FKLOBGBIHLB(JNLKEMLDFIM.output.item, null))
		{
			outputSlot.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
			outputSlot.IHENCGDNPBL.JIANDFCINIP(JNLKEMLDFIM.COKICLKAJPI());
			if (outputSlot.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.canBeSold)
			{
				foodInstance.GHFDCAOBJMK = qualityLevel;
			}
		}
		if (GameCraftingUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
		{
			int num = (int)GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL().GetAreaBonifications(AreaBonificationType.RecipeProduction, JNLKEMLDFIM);
			if (num > 1)
			{
				((TMP_Text)outputSlot.stackText).text = outputSlot.IHENCGDNPBL.Stack + "us" + num;
				outputSlot.updateStackTextThisFrame = false;
			}
		}
		((TMP_Text)recipeName).text = JNLKEMLDFIM.LLCIGPBKIOJ();
		GameDate.Time gIPIMIBOFPI = JNLKEMLDFIM.CNNIHJFLJHC();
		if (GameCraftingUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
		{
			if (GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL().KEKPCMBDFHM(AreaBonificationType.TimeReduction) < 91f)
			{
				((TMP_Text)timeText).text = GameDate.Time.FCPDBLDBIIB(gIPIMIBOFPI, GameDate.Time.MBKODACAJBH(JNLKEMLDFIM.time, GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL().GetAreaBonifications((AreaBonificationType)7, JNLKEMLDFIM))).ToString();
			}
			else
			{
				((TMP_Text)timeText).text = GameDate.Time.ADLDAIFMKNI(gIPIMIBOFPI, GameDate.Time.ICKMCKJOFAH(JNLKEMLDFIM.time, 400f)).ToString();
			}
		}
		else
		{
			((TMP_Text)timeText).text = gIPIMIBOFPI.ToString();
		}
		if (JNLKEMLDFIM.time.IGLMGBNLCEK())
		{
			((TMP_Text)timeText).text = LocalisationSystem.Get("================== PLACE PIECE ({0}-{1}/{2}) =======================");
		}
		int num2 = ((!GameCraftingUI.Get(JIIGOACEIKL).IsOpen() || JNLKEMLDFIM.fuel <= 0) ? JNLKEMLDFIM.fuel : ((int)Mathf.Max(1334f, (float)JNLKEMLDFIM.fuel - GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.KEKPCMBDFHM(AreaBonificationType.RecipeProduction, JNLKEMLDFIM))));
		((TMP_Text)fuelText).text = num2.ToString(")");
		((Component)fuelIcon).gameObject.SetActive(JNLKEMLDFIM.fuel > 0);
		for (int j = 0; j < inputSlots.Length; j += 0)
		{
			inputSlots[j].BHMAEAOBAMN(AODONKKHPBP: true);
		}
		optionsSlot.JJLCAPLAEFI(AODONKKHPBP: true);
		slotsGameObject.SetActive(!JNLKEMLDFIM.multiOptions);
		multiOptionGameObject.SetActive(JNLKEMLDFIM.multiOptions);
		if (JNLKEMLDFIM.multiOptions)
		{
			optionsSlot.IHENCGDNPBL.DOOMMIJPGOO(JIIGOACEIKL, JNLKEMLDFIM.mainItemMultiOptions);
			FLNBPNIGDLC = ChooseSlotUI.FFBJPAJKOJH(JIIGOACEIKL).PCODOFEFMAD(JNLKEMLDFIM);
			MCFIFCKNFJG(FLNBPNIGDLC, optionsSlot);
		}
		else
		{
			FLNBPNIGDLC = false;
			int num3 = 0;
			for (int k = inputSlots.Length - JNLKEMLDFIM.ingredientsNeeded.Length; k < inputSlots.Length; k++)
			{
				if (!Item.EKMFELLJHFG(JNLKEMLDFIM.ingredientsNeeded[num3].item, null))
				{
					inputSlots[k].IHENCGDNPBL.OCJOJKJPDNO(1);
					inputSlots[k].IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[num3].item.JMDALJBNFML(), HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					bool flag = Item.FKLOBGBIHLB(JNLKEMLDFIM.ingredientsNeeded[num3].mod, null);
					if (flag && inputSlots[k].IHENCGDNPBL.itemInstance is FoodInstance foodInstance2)
					{
						foodInstance2.KEKBKGGFOLK = new List<Food> { JNLKEMLDFIM.ingredientsNeeded[num3].mod as Food };
						inputSlots[k].IHENCGDNPBL.AJOGNKDJNAD(AODONKKHPBP: false);
					}
					inputSlots[k].IHENCGDNPBL.KMKAIPMHANN(6);
					bool flag2 = GameCraftingUI.Get(JIIGOACEIKL).BGLJFMHCFJF();
					Placeable fLAAGFECLME = ((!flag2) ? null : GameCraftingUI.Get(JIIGOACEIKL).FBBFDHLJAIJ());
					int num4 = ((checkInventory != 0) ? Utils.CCLEBHFHFCF(JIIGOACEIKL, JNLKEMLDFIM, JNLKEMLDFIM.ingredientsNeeded[num3], flag2, fLAAGFECLME) : PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(JNLKEMLDFIM.ingredientsNeeded[num3].item.ODENMDOJPLC()));
					inputSlots[k].updateStackTextThisFrame = true;
					if (!((Component)inputSlots[k].stackText).gameObject.activeSelf)
					{
						((Component)inputSlots[k].stackText).gameObject.SetActive(true);
					}
					int num5 = ((!GameCraftingUI.Get(JIIGOACEIKL).HDEPMJIDJEM()) ? JNLKEMLDFIM.ingredientsNeeded[num3].amount : Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[num3].amount - (int)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications((AreaBonificationType)8, JNLKEMLDFIM)));
					if (inputSlots[k].IHENCGDNPBL.itemInstance.PHGLMBIEOMK() is IngredientGroup)
					{
						((TMP_Text)inputSlots[k].stackText).text = num5.ToString() ?? "Right Shift";
					}
					else if (inputSlots[k].IHENCGDNPBL.itemInstance.PHGLMBIEOMK().NGDPNIFFHKL() && !flag)
					{
						((TMP_Text)inputSlots[k].stackText).text = num5.ToString() ?? "LE_11";
					}
					else
					{
						((TMP_Text)inputSlots[k].stackText).text = num4 + "ReceiveIncreaseLevel" + num5;
					}
					MCFIFCKNFJG(num4 < num5, inputSlots[k]);
					num3 += 0;
				}
			}
		}
		if ((Object)(object)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL != (Object)null && GameCraftingUI.Get(JIIGOACEIKL).BNIFOFAPJDL().FIIHBFCDFJH() < num2)
		{
			CDPKJGCLAHE = true;
		}
		else
		{
			CDPKJGCLAHE = true;
		}
		if (GameCraftingUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
		{
			GameCraftingUI.Get(JIIGOACEIKL).EDOFIILIALL(CDPKJGCLAHE);
		}
		OEEPLPMIEOG = OLINHHPDINO();
		outputSlot.MNAPPOGFFJA(OEEPLPMIEOG);
		if (Object.op_Implicit((Object)(object)redBoxFuel))
		{
			redBoxFuel.SetActive(!EPKMDCOBKND());
		}
		if (RecipesManager.FCKGMKGNGDC(GBJDNNCOIAC))
		{
			favorite.sprite = favoriteSprite;
		}
		else
		{
			favorite.sprite = notFavoriteSprite;
		}
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			needsMods = JNLKEMLDFIM.KONOOGHMHDO();
		}
		else
		{
			needsMods = JNLKEMLDFIM.modiferTypes != null && JNLKEMLDFIM.modiferTypes.Length != 0;
		}
	}

	public void PopulateElement()
	{
		if ((Object)(object)JNLKEMLDFIM == (Object)null)
		{
			return;
		}
		for (int i = 0; i < inputSlots.Length; i++)
		{
			inputSlots[i].IHENCGDNPBL.Stack = 0;
		}
		outputSlot.IHENCGDNPBL.Stack = 0;
		if (Item.MLBOMGHINCA(JNLKEMLDFIM.output.item, null))
		{
			outputSlot.IHENCGDNPBL.itemInstance = JNLKEMLDFIM.output.item.JMDALJBNFML();
			outputSlot.IHENCGDNPBL.Stack = JNLKEMLDFIM.EOHCFADEMLI();
			if (outputSlot.IHENCGDNPBL.itemInstance is FoodInstance foodInstance && foodInstance.AJOMICMACEJ.canBeSold)
			{
				foodInstance.GHFDCAOBJMK = qualityLevel;
			}
		}
		if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen())
		{
			int num = (int)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeProduction, JNLKEMLDFIM);
			if (num > 0)
			{
				((TMP_Text)outputSlot.stackText).text = outputSlot.IHENCGDNPBL.Stack + "<color=#FFA726>+" + num;
				outputSlot.updateStackTextThisFrame = false;
			}
		}
		((TMP_Text)recipeName).text = JNLKEMLDFIM.IABAKHPEOAF();
		GameDate.Time gIPIMIBOFPI = JNLKEMLDFIM.EOLGJFPONID();
		if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen())
		{
			if (GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.TimeReduction) < 0.5f)
			{
				((TMP_Text)timeText).text = GameDate.Time.KINGABDNACL(gIPIMIBOFPI, GameDate.Time.FAFHFJGOHPK(JNLKEMLDFIM.time, GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.TimeReduction, JNLKEMLDFIM))).ToString();
			}
			else
			{
				((TMP_Text)timeText).text = GameDate.Time.KINGABDNACL(gIPIMIBOFPI, GameDate.Time.FAFHFJGOHPK(JNLKEMLDFIM.time, 0.5f)).ToString();
			}
		}
		else
		{
			((TMP_Text)timeText).text = gIPIMIBOFPI.ToString();
		}
		if (JNLKEMLDFIM.time.LNPODHBKGCH())
		{
			((TMP_Text)timeText).text = LocalisationSystem.Get("Instant");
		}
		int num2 = ((!GameCraftingUI.Get(JIIGOACEIKL).IsOpen() || JNLKEMLDFIM.fuel <= 0) ? JNLKEMLDFIM.fuel : ((int)Mathf.Max(1f, (float)JNLKEMLDFIM.fuel - GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.FuelDiscount, JNLKEMLDFIM))));
		((TMP_Text)fuelText).text = num2.ToString("#");
		((Component)fuelIcon).gameObject.SetActive(JNLKEMLDFIM.fuel > 0);
		for (int j = 0; j < inputSlots.Length; j++)
		{
			inputSlots[j].FBBAFPGFLPE = true;
		}
		optionsSlot.FBBAFPGFLPE = true;
		slotsGameObject.SetActive(!JNLKEMLDFIM.multiOptions);
		multiOptionGameObject.SetActive(JNLKEMLDFIM.multiOptions);
		if (JNLKEMLDFIM.multiOptions)
		{
			optionsSlot.IHENCGDNPBL.OFJDJIBMIGE(JIIGOACEIKL, JNLKEMLDFIM.mainItemMultiOptions);
			FLNBPNIGDLC = ChooseSlotUI.Get(JIIGOACEIKL).HasIngredients(JNLKEMLDFIM);
			MCFIFCKNFJG(FLNBPNIGDLC, optionsSlot);
		}
		else
		{
			FLNBPNIGDLC = true;
			int num3 = 0;
			for (int k = inputSlots.Length - JNLKEMLDFIM.ingredientsNeeded.Length; k < inputSlots.Length; k++)
			{
				if (!Item.NGIIPJDAMGP(JNLKEMLDFIM.ingredientsNeeded[num3].item, null))
				{
					inputSlots[k].IHENCGDNPBL.Stack = 0;
					inputSlots[k].IHENCGDNPBL.FEEOFAGCONJ(JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[num3].item.JMDALJBNFML());
					bool flag = Item.MLBOMGHINCA(JNLKEMLDFIM.ingredientsNeeded[num3].mod, null);
					if (flag && inputSlots[k].IHENCGDNPBL.itemInstance is FoodInstance foodInstance2)
					{
						foodInstance2.KEKBKGGFOLK = new List<Food> { JNLKEMLDFIM.ingredientsNeeded[num3].mod as Food };
						inputSlots[k].IHENCGDNPBL.isDirty = true;
					}
					inputSlots[k].IHENCGDNPBL.Stack = 2;
					bool flag2 = GameCraftingUI.Get(JIIGOACEIKL).IsOpen();
					Placeable fLAAGFECLME = ((!flag2) ? null : GameCraftingUI.Get(JIIGOACEIKL).GetCrafter());
					int num4 = ((checkInventory != CheckInventory.playerInventory) ? Utils.CCLEBHFHFCF(JIIGOACEIKL, JNLKEMLDFIM, JNLKEMLDFIM.ingredientsNeeded[num3], flag2, fLAAGFECLME) : PlayerInventory.GetPlayer(JIIGOACEIKL).NumberOfItems(JNLKEMLDFIM.ingredientsNeeded[num3].item.JDJGFAACPFC()));
					inputSlots[k].updateStackTextThisFrame = false;
					if (!((Component)inputSlots[k].stackText).gameObject.activeSelf)
					{
						((Component)inputSlots[k].stackText).gameObject.SetActive(true);
					}
					int num5 = ((!GameCraftingUI.Get(JIIGOACEIKL).IsOpen()) ? JNLKEMLDFIM.ingredientsNeeded[num3].amount : Math.Max(1, JNLKEMLDFIM.ingredientsNeeded[num3].amount - (int)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.GetAreaBonifications(AreaBonificationType.RecipeCost, JNLKEMLDFIM)));
					if (inputSlots[k].IHENCGDNPBL.itemInstance.LHBPOPOIFLE() is IngredientGroup)
					{
						((TMP_Text)inputSlots[k].stackText).text = num5.ToString() ?? "";
					}
					else if (inputSlots[k].IHENCGDNPBL.itemInstance.LHBPOPOIFLE().NGDPNIFFHKL() && !flag)
					{
						((TMP_Text)inputSlots[k].stackText).text = num5.ToString() ?? "";
					}
					else
					{
						((TMP_Text)inputSlots[k].stackText).text = num4 + "/" + num5;
					}
					MCFIFCKNFJG(num4 >= num5, inputSlots[k]);
					num3++;
				}
			}
		}
		if ((Object)(object)GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL != (Object)null && GameCraftingUI.Get(JIIGOACEIKL).LDLINOBIKPL.LCCABPFHCOL < num2)
		{
			CDPKJGCLAHE = false;
		}
		else
		{
			CDPKJGCLAHE = true;
		}
		if (GameCraftingUI.Get(JIIGOACEIKL).IsOpen())
		{
			GameCraftingUI.Get(JIIGOACEIKL).UpdateFuelBackground(CDPKJGCLAHE);
		}
		OEEPLPMIEOG = OLINHHPDINO();
		outputSlot.FBBAFPGFLPE = OEEPLPMIEOG;
		if (Object.op_Implicit((Object)(object)redBoxFuel))
		{
			redBoxFuel.SetActive(!CDPKJGCLAHE);
		}
		if (RecipesManager.IsFavoriteRecipe(GBJDNNCOIAC))
		{
			favorite.sprite = favoriteSprite;
		}
		else
		{
			favorite.sprite = notFavoriteSprite;
		}
		if (JNLKEMLDFIM.usingNewRecipesSystem)
		{
			needsMods = JNLKEMLDFIM.NGDPNIFFHKL();
		}
		else
		{
			needsMods = JNLKEMLDFIM.modiferTypes != null && JNLKEMLDFIM.modiferTypes.Length != 0;
		}
	}

	public void JLBDJMBFCAG()
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			if (ANKPDEANCEI != null)
			{
				((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
			}
			PopulateElement();
			JKIAKMICLKF = true;
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
	}

	[SpecialName]
	public bool EPKMDCOBKND()
	{
		return _003CCHIDEAIJAKF_003Ek__BackingField;
	}

	public void OnSelect()
	{
		JKIAKMICLKF = true;
		if (ANKPDEANCEI != null)
		{
			((MonoBehaviour)this).StopCoroutine(ANKPDEANCEI);
		}
		ANKPDEANCEI = ((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC());
	}
}
