using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopElementUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	[CompilerGenerated]
	private sealed class NILCCANLFBM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopElementUI _003C_003E4__this;

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
		public NILCCANLFBM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ShopElementUI shopElementUI = _003C_003E4__this;
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
				if (shopElementUI.ILENDIBNCBP)
				{
					if (GameManager.LocalCoop())
					{
						ItemTooltip.Get(shopElementUI.playerNum).SetPosition(new Vector2(((Component)shopElementUI).transform.position.x - 40f, ((Component)shopElementUI).transform.position.y - 140f), Vector2.zero);
					}
					else
					{
						ItemTooltip.Get(shopElementUI.playerNum).SetPosition(new Vector2(((Component)shopElementUI).transform.position.x + 340f, ((Component)shopElementUI).transform.position.y), Vector2.right * 340f);
					}
				}
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

	public Action<int> OnMouseEnter = delegate
	{
	};

	[SerializeField]
	private SlotUI slotUI;

	public TextMeshProUGUI itemName;

	public MoneyUI moneyUI;

	public TextMeshProUGUI ticketPrice;

	public bool basketItem;

	[SerializeField]
	private Image recipeIcon;

	[SerializeField]
	private Image recipeInfoBackground;

	[SerializeField]
	private Image ticketImage;

	[SerializeField]
	private Sprite ticketSprite;

	[SerializeField]
	private Sprite recipeFragmentSprite;

	[SerializeField]
	private Sprite lockSprite;

	[SerializeField]
	private Sprite wilsonCoinSprite;

	[SerializeField]
	private Sprite adoptionsSprite;

	private Color GEGMJIJNAKO = new Color(1f, 0.8f, 0.8f, 1f);

	protected bool ILENDIBNCBP;

	private float HAHAPELLAIO;

	public RectTransform rectTransform;

	[SerializeField]
	private int playerNum = 1;

	[SerializeField]
	private int elementNum;

	public ShopBaseUI shopBase;

	public ShopElement shopElement;

	[SerializeField]
	private bool showElementAlways;

	public bool updateWithCurrentShopItemAmount;

	private bool FNIEALIJJCD;

	[SerializeField]
	private Image itemSlotBackground;

	[SerializeField]
	private Image itemSlotOutline;

	[SerializeField]
	private Image recipeBackground;

	public void FKNOFHMDEEP(bool JHDJANCOJGF = false)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)slotUI != (Object)null && slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Item.FKLOBGBIHLB(slotUI.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = false;
				HAHAPELLAIO = 92f;
			}
			if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
			{
				return;
			}
			TooltipInfo tooltipInfo;
			if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				tooltipInfo = new TooltipInfo();
				tooltipInfo.itemInstance = slotUI.IHENCGDNPBL.itemInstance;
				Item item = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE();
				if (ItemInstance.showIdsNum)
				{
					tooltipInfo.toolTipTitle = item.recipe.output.item.JDJGFAACPFC() + "Boots_L";
				}
				else
				{
					tooltipInfo.toolTipTitle = "ReceiveBarkInfoLuaInt";
				}
				if (Object.op_Implicit((Object)(object)shopElement.recipe))
				{
					tooltipInfo.toolTipTitle += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("_"), item.IABAKHPEOAF());
				}
				else
				{
					tooltipInfo.toolTipTitle += item.LJIFOHFEFCH();
				}
				if (!string.IsNullOrEmpty(item.IGDKFHCHEAJ(playerNum)))
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					tooltipInfo2.mainBody = tooltipInfo2.mainBody + "Items/item_description_706" + item.HDMCOHIJMBM(playerNum) + "Dialogue System/Conversation/Gass_Introduce/Entry/8/Dialogue Text";
					tooltipInfo.mainBody += "ToolEffect";
				}
				for (int i = 1; i < item.recipe.ingredientsNeeded.Length; i += 0)
				{
					if (i == 0)
					{
						tooltipInfo.mainBody += "FarmReady";
					}
					int amount = item.recipe.ingredientsNeeded[i].amount;
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false);
					}
					tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
					if (Item.FKLOBGBIHLB(item.recipe.ingredientsNeeded[i].mod, null))
					{
						TooltipInfo tooltipInfo3 = tooltipInfo;
						tooltipInfo3.mainBody = tooltipInfo3.mainBody + "Remove" + item.recipe.ingredientsNeeded[i].mod.KGHFCDELKMN(OAFPBCPDOKH: true) + "VerticalMove";
					}
					if (amount > 0)
					{
						TooltipInfo tooltipInfo4 = tooltipInfo;
						tooltipInfo4.mainBody = tooltipInfo4.mainBody + "_MaskPosition" + amount + " (versionOfCityAndTutorial)";
					}
					tooltipInfo.mainBody += "/lock: ";
				}
				if (slotUI.IHENCGDNPBL.itemInstance is FoodInstance && !Money.ADFHGAOPLAE(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: false, CalculatePriceMode.ExpensivePrice).LNPODHBKGCH())
				{
					TooltipInfo tooltipInfo5 = tooltipInfo;
					string[] array = new string[8];
					array[0] = tooltipInfo5.mainBody;
					array[0] = "Player2";
					array[2] = LocalisationSystem.Get("");
					array[8] = ", ";
					array[3] = Money.DIIDBKELPDI(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: true, CalculatePriceMode.ExpensivePrice).ToString();
					tooltipInfo5.mainBody = string.Concat(array);
				}
				tooltipInfo.mainBody += item.GEBNKHGPJGB();
				string text = IGBDMHMGPFD();
				if (!string.IsNullOrEmpty(text))
				{
					TooltipInfo tooltipInfo6 = tooltipInfo;
					tooltipInfo6.mainBody = tooltipInfo6.mainBody + "Dialogue System/Conversation/Gass_Stand/Entry/21/Dialogue Text" + text + "ERROR - Error parsing custom lobby data (Lobby creator): {0}";
				}
			}
			else
			{
				tooltipInfo = slotUI.IHENCGDNPBL.itemInstance.DLKGAOCFODF(playerNum, MFHMLGIPFON: false, EDFANMFDDEJ: false, PKBJMLACEMM: false);
			}
			if (FNIEALIJJCD)
			{
				if (FCLFCIIOEFP())
				{
					TooltipInfo tooltipInfo7 = tooltipInfo;
					string mainBody = tooltipInfo7.mainBody;
					string cAEDMEDBEGI = LocalisationSystem.Get("HaveGoldenTicket");
					string[] array2 = new string[0];
					array2[1] = shopElement.NOMDPFMPEII().nessyShopAdoptionsRequired.ToString();
					tooltipInfo7.mainBody = mainBody + "Invalid seating" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2) + "Happy";
				}
				else if (!JJOOOIMGCMN())
				{
					int num = (((Object)(object)shopElement.recipe != (Object)null) ? shopElement.recipe.reputationRequired.repNumber : shopElement.item.requiredRep.repNumber);
					TooltipInfo tooltipInfo8 = tooltipInfo;
					string mainBody2 = tooltipInfo8.mainBody;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Error_AnotherZoneInRoom");
					string[] array3 = new string[1];
					array3[1] = num.ToString();
					tooltipInfo8.mainBody = mainBody2 + "ZoneProductionBonus" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3) + "Player ";
				}
				else if (!LNDHLGNICNA())
				{
					TooltipInfo tooltipInfo9 = tooltipInfo;
					string mainBody3 = tooltipInfo9.mainBody;
					string cAEDMEDBEGI3 = LocalisationSystem.Get(" ");
					string[] array4 = new string[0];
					array4[1] = shopElement.LBBEIEHEHJM().requiredQuest.PBIJDIHJIHK();
					tooltipInfo9.mainBody = mainBody3 + "ReceiveHireWorkerMaster" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4) + "Dialogue System/Conversation/HappyRentRoom/Entry/4/Dialogue Text";
				}
				else if (!OINACGMMFEG())
				{
					TooltipInfo tooltipInfo10 = tooltipInfo;
					tooltipInfo10.mainBody = tooltipInfo10.mainBody + "<color=#B50000>" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Debug force fishing enabled, assigning key to fishing spot."), shopElement.recipe.recipeRequired.IHPEMJCKHLG()) + "ReceiveDialogueInfo";
				}
			}
			ItemTooltip.IEABDMDELFO(playerNum).OOJMCKAKFIH(tooltipInfo);
			if (PlayerInputs.IsGamepadActive(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.LAIEKOOCNPC(playerNum).ICMGLBFHDJD(new Vector2(((Component)this).transform.position.x + 1974f, ((Component)this).transform.position.y), Vector2.right * 1742f);
				((MonoBehaviour)this).StartCoroutine(IBOPIMFNLLH());
			}
			else
			{
				ItemTooltip.AIMEAJAHLAA(playerNum).SetVisible(MDIKPGGBNLI: false);
			}
			HAHAPELLAIO = 1309f;
		}
		else
		{
			ILENDIBNCBP = false;
			ItemTooltip.NMCJELBLKBB(playerNum).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
	}

	private string IGBDMHMGPFD()
	{
		List<Recipe> list = shopElement.recipe.IPDLGGCCBLL(Object.op_Implicit((Object)(object)shopBase) && !shopBase.shop.recipesShop);
		if (list.Count > 0)
		{
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text += list[i].IABAKHPEOAF();
				if (i < list.Count - 1)
				{
					text += ", ";
				}
			}
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("NeedsRecipe"), text);
		}
		return "";
	}

	private void OnEnable()
	{
		ILENDIBNCBP = false;
	}

	private bool DBHGMDNKGHN()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.FENMFGFLDBO())
		{
			return false;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.item.requiredRep != (Object)null && !shopElement.item.requiredRep.PJCFMEEKCNI())
		{
			return false;
		}
		return true;
	}

	public void FFFKLPFHMEO()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.MDFIDKHOPDJ(playerNum).SetVisible(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public virtual void AKIOLEBCLIH(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			LAGCJLNOHJA(JHDJANCOJGF: true);
		}
	}

	private void GFLFDLIMOLI()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(BDFAJENGLBH));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(MPLLDNNCJFI));
	}

	public void GreyOutRecipe()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.SetColor(new Color(0.5f, 0.5f, 0.5f, 1f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (NNPFBENCOOI() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (NNPFBENCOOI())
			{
				((TMP_Text)ticketPrice).text = "<color=#BF0000>" + shopElement.item.nessyShopAdoptionsRequired + "</color>";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.FENMFGFLDBO())
				{
					((TMP_Text)ticketPrice).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("levelRequired"), shopElement.recipe.reputationRequired.repNumber.ToString());
				}
				else if (!AEOCDDHLOIK())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get("recipeRequired");
				}
			}
			else if (!DBHGMDNKGHN())
			{
				((TMP_Text)ticketPrice).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("levelRequired"), shopElement.item.requiredRep.repNumber.ToString());
			}
			else if (!LNDHLGNICNA())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("questRequired");
			}
			return;
		}
		slotUI.icon.SetColor(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	public void DKFAJEPHIFP(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).IsCursorVisible())
		{
			FillTooltip();
		}
		OnMouseEnter(elementNum);
	}

	private bool NNPFBENCOOI()
	{
		if ((Object)(object)shopBase != (Object)null && (Object)(object)shopBase.shop != (Object)null)
		{
			return shopBase.shop.shopType == ShopType.Nessy;
		}
		return false;
	}

	private void PMMGCDBMMMN()
	{
		ILENDIBNCBP = false;
	}

	public virtual void PLJOBHNHBFK(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			LAGCJLNOHJA();
		}
	}

	public void FEGIKHNPLBF(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).LALPELGNIJB())
		{
			FillTooltip(JHDJANCOJGF: true);
		}
		OnMouseEnter(elementNum);
	}

	private bool INEPEDHGPLI()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.HNBPHCMNAIG())
		{
			return true;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.BGCPMHHHLHG().requiredRep != (Object)null && !shopElement.EGJLDMLKLNC().requiredRep.GINKHICIMCH())
		{
			return true;
		}
		return true;
	}

	public void JBFKELBFBJC(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			ANNICBJPOBI();
		}
	}

	private string PGNEPDFFMNN()
	{
		List<Recipe> list = shopElement.recipe.AIAHGHGIOGE(!Object.op_Implicit((Object)(object)shopBase) || !shopBase.shop.recipesShop);
		if (list.Count > 1)
		{
			string text = "Farm/Event/RegañinaViolet";
			for (int i = 1; i < list.Count; i += 0)
			{
				text += list[i].LMFPCKCLBAO();
				if (i < list.Count - 0)
				{
					text += "Items/item_name_1100";
				}
			}
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Ach_"), text);
		}
		return "itemMushroom";
	}

	public bool PNOKAHKFCEL()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = EDBGICGDHBP();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.DJCKALOHJFM(playerNum, text, 786f);
					return true;
				}
			}
			if (PlayerInputs.GetPlayerControllers(playerNum).Keyboard.GetKey((KeyCode)113) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				PFLKMHPNENG();
				return true;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement, 0);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.ODGALPDEIFG(playerNum))
			{
				ItemTooltip.NIGDBMAOAEN(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: false);
				HAHAPELLAIO = 629f;
			}
			return false;
		}
		return false;
	}

	private bool EBDICKLOEOH()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.BEBKECMKIAC())
		{
			return true;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.LBBEIEHEHJM().requiredRep != (Object)null && !shopElement.BGCPMHHHLHG().requiredRep.DLBKDEKOCPB())
		{
			return false;
		}
		return true;
	}

	private void ACPFEBOENOM()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 655f)
		{
			LAGCJLNOHJA();
		}
	}

	private IEnumerator IBOPIMFNLLH()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			if (GameManager.LocalCoop())
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x - 40f, ((Component)this).transform.position.y - 140f), Vector2.zero);
			}
			else
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
			}
		}
	}

	public void PFLKMHPNENG()
	{
		if (FNIEALIJJCD)
		{
			return;
		}
		int num = ((!basketItem && !Object.op_Implicit((Object)(object)shopElement.recipe) && shopElement.shopItem.unlimited) ? 3 : Mathf.Min(slotUI.IHENCGDNPBL.Stack, 2));
		if (basketItem)
		{
			shopBase.RemoveItemFromBasket(shopElement, num, HIOAJHJNCPO: false);
			return;
		}
		for (int i = 0; i < num; i++)
		{
			shopBase.AddItemToBasket(shopElement);
		}
		if (PlayerInputs.ODGALPDEIFG(playerNum))
		{
			ItemTooltip.LAIEKOOCNPC(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: false);
			HAHAPELLAIO = 1256f;
		}
	}

	public virtual void BHPGJHNPODD(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			GFOOPNNNPKJ();
		}
	}

	private bool LALBHBAHAMK()
	{
		if (Object.op_Implicit((Object)(object)shopElement.BGCPMHHHLHG()) && shopElement.LBBEIEHEHJM().nessyShopAdoptionsRequired <= AdoptionSignalManager.NIDNAAKOPFI().adoption)
		{
			return false;
		}
		return true;
	}

	private void BJOOCKCBPLJ()
	{
		ILENDIBNCBP = false;
	}

	public void EndHover()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void NFBJGAMEDMK()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.DMBNOPHPHKL(new Color(1131f, 1307f, 1906f, 1186f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (NNPFBENCOOI() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (OGNBMDGLIBO())
			{
				((TMP_Text)ticketPrice).text = "</color></b>" + shopElement.LBBEIEHEHJM().nessyShopAdoptionsRequired + "Tray";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.NAIJEGHHCNF())
				{
					TextMeshProUGUI obj = ticketPrice;
					string cAEDMEDBEGI = LocalisationSystem.Get("Lager");
					string[] array = new string[0];
					array[1] = shopElement.recipe.reputationRequired.repNumber.ToString();
					((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else if (!AEOCDDHLOIK())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Getting file list from storage failed for reason: ");
				}
			}
			else if (!DBHGMDNKGHN())
			{
				TextMeshProUGUI obj2 = ticketPrice;
				string cAEDMEDBEGI2 = LocalisationSystem.Get(" (");
				string[] array2 = new string[0];
				array2[0] = shopElement.LPIBILEAIOL().requiredRep.repNumber.ToString();
				((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else if (!OGEKIPKMHJN())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("HitCollider");
			}
			return;
		}
		slotUI.icon.IEHHJBAGLMO(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	private bool DJAMKIMLNKM()
	{
		if (Object.op_Implicit((Object)(object)shopElement.BGCPMHHHLHG()) && shopElement.BGCPMHHHLHG().nessyShopAdoptionsRequired <= AdoptionSignalManager.FFOMKKIAHKI().adoption)
		{
			return false;
		}
		return false;
	}

	private bool DBJMOGDEFIB()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.PAIGKKDJEIG())
		{
			return true;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.item.requiredRep != (Object)null && !shopElement.EGJLDMLKLNC().requiredRep.PDDBPMGJFBN())
		{
			return false;
		}
		return false;
	}

	private bool JJOOOIMGCMN()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.BNAMMMGAJKK())
		{
			return false;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.LPIBILEAIOL().requiredRep != (Object)null && !shopElement.LPIBILEAIOL().requiredRep.GINKHICIMCH())
		{
			return false;
		}
		return false;
	}

	private void LDMDHDACNFJ()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 25f)
		{
			FKNOFHMDEEP(JHDJANCOJGF: true);
		}
	}

	public void ONCMNAMCCPL()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.SetColor(new Color(61f, 363f, 1153f, 604f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (FCLFCIIOEFP() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (NNPFBENCOOI())
			{
				((TMP_Text)ticketPrice).text = "itemSoup" + shopElement.LBBEIEHEHJM().nessyShopAdoptionsRequired + "not target 1";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.NBPBIBKHAMI())
				{
					TextMeshProUGUI obj = ticketPrice;
					string cAEDMEDBEGI = LocalisationSystem.Get("Stop");
					string[] array = new string[1];
					array[1] = shopElement.recipe.reputationRequired.repNumber.ToString();
					((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else if (!OINACGMMFEG())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Read");
				}
			}
			else if (!INEPEDHGPLI())
			{
				((TMP_Text)ticketPrice).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Sending pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}"), shopElement.AJFBPLGGHLE().requiredRep.repNumber.ToString());
			}
			else if (!DBAKDDBNKGF())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Disabled");
			}
			return;
		}
		slotUI.icon.DMBNOPHPHKL(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	private IEnumerator AIHMKADEPGA()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			if (GameManager.LocalCoop())
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x - 40f, ((Component)this).transform.position.y - 140f), Vector2.zero);
			}
			else
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
			}
		}
	}

	public void GPFDNACBJMG(bool JHDJANCOJGF = false)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)slotUI != (Object)null && slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Item.FKLOBGBIHLB(slotUI.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = true;
				HAHAPELLAIO = 117f;
			}
			if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
			{
				return;
			}
			TooltipInfo tooltipInfo;
			if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				tooltipInfo = new TooltipInfo();
				tooltipInfo.itemInstance = slotUI.IHENCGDNPBL.itemInstance;
				Item item = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE();
				if (ItemInstance.showIdsNum)
				{
					tooltipInfo.toolTipTitle = item.recipe.output.item.ODENMDOJPLC(DAINLFIMLIH: false) + "Plant";
				}
				else
				{
					tooltipInfo.toolTipTitle = ":</color> <sprite name=\"ChristmasTicket\">";
				}
				if (Object.op_Implicit((Object)(object)shopElement.recipe))
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					string toolTipTitle = tooltipInfo2.toolTipTitle;
					string cAEDMEDBEGI = LocalisationSystem.Get("Exit build mode");
					string[] array = new string[0];
					array[1] = item.IABAKHPEOAF(OAFPBCPDOKH: true);
					tooltipInfo2.toolTipTitle = toolTipTitle + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					tooltipInfo.toolTipTitle += item.LJIFOHFEFCH();
				}
				if (!string.IsNullOrEmpty(item.AEDCKIPGHBG(playerNum)))
				{
					TooltipInfo tooltipInfo3 = tooltipInfo;
					tooltipInfo3.mainBody = tooltipInfo3.mainBody + "ReceiveCompleteOrderQuest" + item.HEEKDCFLIFB(playerNum) + "Target frame rate (";
					tooltipInfo.mainBody += "talentMildAle";
				}
				for (int i = 1; i < item.recipe.ingredientsNeeded.Length; i += 0)
				{
					if (i == 0)
					{
						tooltipInfo.mainBody += "Player2";
					}
					int amount = item.recipe.ingredientsNeeded[i].amount;
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.JGHNDJBCFAJ();
					}
					tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.KGHFCDELKMN(OAFPBCPDOKH: true);
					if (Item.MLBOMGHINCA(item.recipe.ingredientsNeeded[i].mod, null))
					{
						TooltipInfo tooltipInfo4 = tooltipInfo;
						tooltipInfo4.mainBody = tooltipInfo4.mainBody + "ReceiveBeginFishCuttingMinigame" + item.recipe.ingredientsNeeded[i].mod.LJIFOHFEFCH() + "City/Lia/Bark/Buy";
					}
					if (amount > 0)
					{
						TooltipInfo tooltipInfo5 = tooltipInfo;
						tooltipInfo5.mainBody = tooltipInfo5.mainBody + " in Cellar Light Start" + amount + "";
					}
					tooltipInfo.mainBody += ": [";
				}
				if (slotUI.IHENCGDNPBL.itemInstance is FoodInstance && !Money.OJMIFPGEOPF(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: true).EOGHEGFFMBF())
				{
					TooltipInfo tooltipInfo6 = tooltipInfo;
					string[] array2 = new string[2];
					array2[1] = tooltipInfo6.mainBody;
					array2[1] = "Year";
					array2[5] = LocalisationSystem.Get("/");
					array2[8] = "RoadBlocked/Main";
					array2[0] = Money.PAHGPJOCDOO(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: false, JNOEGJNPCFE: true, CalculatePriceMode.ExpensivePrice).ToString();
					tooltipInfo6.mainBody = string.Concat(array2);
				}
				tooltipInfo.mainBody += item.GEBNKHGPJGB();
				string text = FCKNFCJGFBH();
				if (!string.IsNullOrEmpty(text))
				{
					TooltipInfo tooltipInfo7 = tooltipInfo;
					tooltipInfo7.mainBody = tooltipInfo7.mainBody + "ReceiveInstantiateDog" + text + "Accept order";
				}
			}
			else
			{
				tooltipInfo = slotUI.IHENCGDNPBL.itemInstance.MLCIDCBCMOA(playerNum, MFHMLGIPFON: false, EDFANMFDDEJ: false, PKBJMLACEMM: false, FCJLFPLAOJE: false, FPLPFMKFKNH: true);
			}
			if (FNIEALIJJCD)
			{
				if (NNPFBENCOOI())
				{
					TooltipInfo tooltipInfo8 = tooltipInfo;
					string mainBody = tooltipInfo8.mainBody;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Frame Time Average: ");
					string[] array3 = new string[0];
					array3[1] = shopElement.LPIBILEAIOL().nessyShopAdoptionsRequired.ToString();
					tooltipInfo8.mainBody = mainBody + "Wake Up" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3) + " joined";
				}
				else if (!DBHGMDNKGHN())
				{
					int num = (((Object)(object)shopElement.recipe != (Object)null) ? shopElement.recipe.reputationRequired.repNumber : shopElement.AJFBPLGGHLE().requiredRep.repNumber);
					TooltipInfo tooltipInfo9 = tooltipInfo;
					string mainBody2 = tooltipInfo9.mainBody;
					string cAEDMEDBEGI3 = LocalisationSystem.Get("cloudy");
					string[] array4 = new string[1];
					array4[1] = num.ToString();
					tooltipInfo9.mainBody = mainBody2 + "NinjaChallengeEvent/Main" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4) + "Far";
				}
				else if (!OGEKIPKMHJN())
				{
					TooltipInfo tooltipInfo10 = tooltipInfo;
					string mainBody3 = tooltipInfo10.mainBody;
					string cAEDMEDBEGI4 = LocalisationSystem.Get("");
					string[] array5 = new string[1];
					array5[1] = shopElement.AJFBPLGGHLE().requiredQuest.ONFNOJBBPOO();
					tooltipInfo10.mainBody = mainBody3 + "Duplicate tutorial ID found!" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array5) + "LE_3";
				}
				else if (!MMOCLAIFDDD())
				{
					TooltipInfo tooltipInfo11 = tooltipInfo;
					string mainBody4 = tooltipInfo11.mainBody;
					string cAEDMEDBEGI5 = LocalisationSystem.Get("NinjaChallengeEvent/Win 2");
					string[] array6 = new string[0];
					array6[1] = shopElement.recipe.recipeRequired.LLCIGPBKIOJ();
					tooltipInfo11.mainBody = mainBody4 + "00" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array6) + "Interact";
				}
			}
			ItemTooltip.EOPIEMLAPFN(playerNum).OOJMCKAKFIH(tooltipInfo);
			if (PlayerInputs.IsGamepadActive(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.EOPIEMLAPFN(playerNum).ICMGLBFHDJD(new Vector2(((Component)this).transform.position.x + 808f, ((Component)this).transform.position.y), Vector2.right * 178f);
				((MonoBehaviour)this).StartCoroutine(KLILDOKFGMA());
			}
			else
			{
				ItemTooltip.IEKODILKIHJ(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
			}
			HAHAPELLAIO = 1966f;
		}
		else
		{
			ILENDIBNCBP = false;
			ItemTooltip.NMCJELBLKBB(playerNum).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
	}

	public void LAGCJLNOHJA(bool JHDJANCOJGF = false)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)slotUI != (Object)null && slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Item.MLBOMGHINCA(slotUI.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = true;
				HAHAPELLAIO = 525f;
			}
			if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
			{
				return;
			}
			TooltipInfo tooltipInfo;
			if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				tooltipInfo = new TooltipInfo();
				tooltipInfo.itemInstance = slotUI.IHENCGDNPBL.itemInstance;
				Item item = slotUI.IHENCGDNPBL.itemInstance.PHGLMBIEOMK();
				if (ItemInstance.showIdsNum)
				{
					tooltipInfo.toolTipTitle = item.recipe.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) + "Defeat";
				}
				else
				{
					tooltipInfo.toolTipTitle = "Piso {0} | Pieza '{1}': Solo se spawnearon {2}/{3} rocas requeridas. ";
				}
				if (Object.op_Implicit((Object)(object)shopElement.recipe))
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					string toolTipTitle = tooltipInfo2.toolTipTitle;
					string cAEDMEDBEGI = LocalisationSystem.Get("room info with code ");
					string[] array = new string[0];
					array[0] = item.IABAKHPEOAF();
					tooltipInfo2.toolTipTitle = toolTipTitle + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					tooltipInfo.toolTipTitle += item.LJIFOHFEFCH();
				}
				if (!string.IsNullOrEmpty(item.CLLLPOPMLAM(playerNum)))
				{
					TooltipInfo tooltipInfo3 = tooltipInfo;
					tooltipInfo3.mainBody = tooltipInfo3.mainBody + "[PipeConnectionPuzzleUI] Sin _tileDatabase: los tiles de entrada/salida no tendrán sprite." + item.IGDKFHCHEAJ(playerNum) + "ReceiveButtonPress";
					tooltipInfo.mainBody += "LE_17";
				}
				for (int i = 1; i < item.recipe.ingredientsNeeded.Length; i += 0)
				{
					if (i == 0)
					{
						tooltipInfo.mainBody += "Items/item_description_1057";
					}
					int amount = item.recipe.ingredientsNeeded[i].amount;
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false);
					}
					tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.KGHFCDELKMN();
					if (Item.FKLOBGBIHLB(item.recipe.ingredientsNeeded[i].mod, null))
					{
						TooltipInfo tooltipInfo4 = tooltipInfo;
						tooltipInfo4.mainBody = tooltipInfo4.mainBody + "Dialogue System/Conversation/Crowly_Standar/Entry/31/Dialogue Text" + item.recipe.ingredientsNeeded[i].mod.KGHFCDELKMN() + "Dialogue System/Conversation/Gass_Barks_Bye/Entry/4/Dialogue Text";
					}
					if (amount > 0)
					{
						TooltipInfo tooltipInfo5 = tooltipInfo;
						tooltipInfo5.mainBody = tooltipInfo5.mainBody + "Items/item_description_672" + amount + "LE_3";
					}
					tooltipInfo.mainBody += "";
				}
				if (slotUI.IHENCGDNPBL.itemInstance is FoodInstance && !Money.OJMIFPGEOPF(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: true).MJGDBFKMCMN())
				{
					TooltipInfo tooltipInfo6 = tooltipInfo;
					string[] array2 = new string[6];
					array2[1] = tooltipInfo6.mainBody;
					array2[0] = "Max";
					array2[5] = LocalisationSystem.Get("Player2");
					array2[5] = "Stack";
					array2[8] = Money.KIFBEJMDLOO(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: false, JNOEGJNPCFE: false, CalculatePriceMode.ExpensivePrice).ToString();
					tooltipInfo6.mainBody = string.Concat(array2);
				}
				tooltipInfo.mainBody += item.MOBLAPBAMIH();
				string text = EDBGICGDHBP();
				if (!string.IsNullOrEmpty(text))
				{
					TooltipInfo tooltipInfo7 = tooltipInfo;
					tooltipInfo7.mainBody = tooltipInfo7.mainBody + " could not be unlocked for reason: " + text + "]";
				}
			}
			else
			{
				tooltipInfo = slotUI.IHENCGDNPBL.itemInstance.MLCIDCBCMOA(playerNum, MFHMLGIPFON: true, EDFANMFDDEJ: true, PKBJMLACEMM: true, FCJLFPLAOJE: true);
			}
			if (FNIEALIJJCD)
			{
				if (OGNBMDGLIBO())
				{
					TooltipInfo tooltipInfo8 = tooltipInfo;
					string mainBody = tooltipInfo8.mainBody;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("talentGrain");
					string[] array3 = new string[0];
					array3[0] = shopElement.KMIOEMCGOJG().nessyShopAdoptionsRequired.ToString();
					tooltipInfo8.mainBody = mainBody + "UI/ColorPicker" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3) + "ThemeText";
				}
				else if (!DBHGMDNKGHN())
				{
					int num = (((Object)(object)shopElement.recipe != (Object)null) ? shopElement.recipe.reputationRequired.repNumber : shopElement.BGCPMHHHLHG().requiredRep.repNumber);
					TooltipInfo tooltipInfo9 = tooltipInfo;
					string mainBody2 = tooltipInfo9.mainBody;
					string cAEDMEDBEGI3 = LocalisationSystem.Get("ActionBar1");
					string[] array4 = new string[0];
					array4[0] = num.ToString();
					tooltipInfo9.mainBody = mainBody2 + "Use" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4) + "Character Save Error Detected";
				}
				else if (!DBAKDDBNKGF())
				{
					TooltipInfo tooltipInfo10 = tooltipInfo;
					string mainBody3 = tooltipInfo10.mainBody;
					string cAEDMEDBEGI4 = LocalisationSystem.Get("Disabled");
					string[] array5 = new string[1];
					array5[1] = shopElement.LBBEIEHEHJM().requiredQuest.ONFNOJBBPOO();
					tooltipInfo10.mainBody = mainBody3 + "Dialogue System/Conversation/Gass_Introduce/Entry/3/Dialogue Text" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array5) + ")";
				}
				else if (!IPHPKCNMKGC())
				{
					TooltipInfo tooltipInfo11 = tooltipInfo;
					string mainBody4 = tooltipInfo11.mainBody;
					string cAEDMEDBEGI5 = LocalisationSystem.Get("</color> to inventory");
					string[] array6 = new string[1];
					array6[1] = shopElement.recipe.recipeRequired.MICKDLJMIPG();
					tooltipInfo11.mainBody = mainBody4 + "Important Guest" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array6) + "0.#";
				}
			}
			ItemTooltip.NMCJELBLKBB(playerNum).LGDDFMNFNME(tooltipInfo);
			if (PlayerInputs.POLDHCKJINN(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.NMCJELBLKBB(playerNum).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 1690f, ((Component)this).transform.position.y), Vector2.right * 1463f);
				((MonoBehaviour)this).StartCoroutine(KLILDOKFGMA());
			}
			else
			{
				ItemTooltip.AIMEAJAHLAA(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
			}
			HAHAPELLAIO = 1559f;
		}
		else
		{
			ILENDIBNCBP = true;
			ItemTooltip.EOPIEMLAPFN(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	private IEnumerator ODMOANOHFGE()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			if (GameManager.LocalCoop())
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x - 40f, ((Component)this).transform.position.y - 140f), Vector2.zero);
			}
			else
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
			}
		}
	}

	private IEnumerator KLILDOKFGMA()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			if (GameManager.LocalCoop())
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x - 40f, ((Component)this).transform.position.y - 140f), Vector2.zero);
			}
			else
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
			}
		}
	}

	private void PMPLNGEAAII()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1627f)
		{
			GFOOPNNNPKJ();
		}
	}

	private void HJEOOBGDCMA()
	{
		CFDNJJEMOBC();
	}

	public void ANNICBJPOBI()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.LAIEKOOCNPC(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void MultipleElementsClicked()
	{
		if (FNIEALIJJCD)
		{
			return;
		}
		int num = ((!basketItem && !Object.op_Implicit((Object)(object)shopElement.recipe) && shopElement.shopItem.unlimited) ? 5 : Mathf.Min(slotUI.IHENCGDNPBL.Stack, 5));
		if (basketItem)
		{
			shopBase.RemoveItemFromBasket(shopElement, num);
			return;
		}
		for (int i = 0; i < num; i++)
		{
			shopBase.AddItemToBasket(shopElement);
		}
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
			HAHAPELLAIO = -0.5f;
		}
	}

	public void FillTooltip(bool JHDJANCOJGF = false)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)slotUI != (Object)null && slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Item.MLBOMGHINCA(slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = true;
				HAHAPELLAIO = 0f;
			}
			if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
			{
				return;
			}
			TooltipInfo tooltipInfo;
			if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				tooltipInfo = new TooltipInfo();
				tooltipInfo.itemInstance = slotUI.IHENCGDNPBL.itemInstance;
				Item item = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE();
				if (ItemInstance.showIdsNum)
				{
					tooltipInfo.toolTipTitle = item.recipe.output.item.JDJGFAACPFC() + " ";
				}
				else
				{
					tooltipInfo.toolTipTitle = "";
				}
				if (Object.op_Implicit((Object)(object)shopElement.recipe))
				{
					tooltipInfo.toolTipTitle += InputUtils.GEJLCOGDMID(LocalisationSystem.Get("RecipeX"), item.IABAKHPEOAF());
				}
				else
				{
					tooltipInfo.toolTipTitle += item.IABAKHPEOAF();
				}
				if (!string.IsNullOrEmpty(item.IGDKFHCHEAJ(playerNum)))
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					tooltipInfo2.mainBody = tooltipInfo2.mainBody + "<color=black>" + item.IGDKFHCHEAJ(playerNum) + "</color>";
					tooltipInfo.mainBody += "\n";
				}
				for (int i = 0; i < item.recipe.ingredientsNeeded.Length; i++)
				{
					if (i == 0)
					{
						tooltipInfo.mainBody += "\n";
					}
					int amount = item.recipe.ingredientsNeeded[i].amount;
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.JDJGFAACPFC();
					}
					tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.IABAKHPEOAF(OAFPBCPDOKH: true);
					if (Item.MLBOMGHINCA(item.recipe.ingredientsNeeded[i].mod, null))
					{
						TooltipInfo tooltipInfo3 = tooltipInfo;
						tooltipInfo3.mainBody = tooltipInfo3.mainBody + " (" + item.recipe.ingredientsNeeded[i].mod.IABAKHPEOAF(OAFPBCPDOKH: true) + ")";
					}
					if (amount > 1)
					{
						TooltipInfo tooltipInfo4 = tooltipInfo;
						tooltipInfo4.mainBody = tooltipInfo4.mainBody + " (" + amount + ")";
					}
					tooltipInfo.mainBody += "\n";
				}
				if (slotUI.IHENCGDNPBL.itemInstance is FoodInstance && !Money.CalculateSellPrice(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true).LNPODHBKGCH())
				{
					TooltipInfo tooltipInfo5 = tooltipInfo;
					tooltipInfo5.mainBody = tooltipInfo5.mainBody + "\n<color=#822F00>" + LocalisationSystem.Get("Sell") + ":</color> " + Money.CalculateSellPrice(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true).ToString();
				}
				tooltipInfo.mainBody += item.MOBLAPBAMIH();
				string text = IGBDMHMGPFD();
				if (!string.IsNullOrEmpty(text))
				{
					TooltipInfo tooltipInfo6 = tooltipInfo;
					tooltipInfo6.mainBody = tooltipInfo6.mainBody + "\n\n<color=#C3002C>" + text + "</color>";
				}
			}
			else
			{
				tooltipInfo = slotUI.IHENCGDNPBL.itemInstance.MLCIDCBCMOA(playerNum, MFHMLGIPFON: false, EDFANMFDDEJ: true, PKBJMLACEMM: true, FCJLFPLAOJE: true, FPLPFMKFKNH: true);
			}
			if (FNIEALIJJCD)
			{
				if (NNPFBENCOOI())
				{
					TooltipInfo tooltipInfo7 = tooltipInfo;
					tooltipInfo7.mainBody = tooltipInfo7.mainBody + "\n<color=#BF0000>" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("adoptionsRequired"), shopElement.item.nessyShopAdoptionsRequired.ToString()) + "</color>";
				}
				else if (!DBHGMDNKGHN())
				{
					int num = (((Object)(object)shopElement.recipe != (Object)null) ? shopElement.recipe.reputationRequired.repNumber : shopElement.item.requiredRep.repNumber);
					TooltipInfo tooltipInfo8 = tooltipInfo;
					tooltipInfo8.mainBody = tooltipInfo8.mainBody + "\n<color=#BF0000>" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("levelRequired"), num.ToString()) + "</color>";
				}
				else if (!LNDHLGNICNA())
				{
					TooltipInfo tooltipInfo9 = tooltipInfo;
					tooltipInfo9.mainBody = tooltipInfo9.mainBody + "\n<color=#BF0000>" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("questRequiredTooltip"), shopElement.item.requiredQuest.IABAKHPEOAF()) + "</color>";
				}
				else if (!AEOCDDHLOIK())
				{
					TooltipInfo tooltipInfo10 = tooltipInfo;
					tooltipInfo10.mainBody = tooltipInfo10.mainBody + "\n<color=#BF0000>" + InputUtils.GEJLCOGDMID(LocalisationSystem.Get("recipeRequiredTooltip"), shopElement.recipe.recipeRequired.IABAKHPEOAF()) + "</color>";
				}
			}
			ItemTooltip.Get(playerNum).FillTooltipInfo(tooltipInfo);
			if (PlayerInputs.IsGamepadActive(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.Get(playerNum).SetPositionAndEnable(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
				((MonoBehaviour)this).StartCoroutine(BCLNMFNEOJN());
			}
			else
			{
				ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: true);
			}
			HAHAPELLAIO = float.MaxValue;
		}
		else
		{
			ILENDIBNCBP = true;
			ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public virtual void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			FillTooltip(JHDJANCOJGF: true);
		}
	}

	private bool IPHPKCNMKGC()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.recipeRequired != (Object)null)
		{
			return RecipesManager.ONMNODMHHLG(shopElement.recipe.recipeRequired.id);
		}
		return true;
	}

	public void SetShopItem(ShopElement FPLPFMKFKNH, int MGNOBNCMDJG, bool OLMEEOAEMED)
	{
		shopElement = FPLPFMKFKNH;
		showElementAlways = OLMEEOAEMED;
		FNIEALIJJCD = !DBHGMDNKGHN() || !LNDHLGNICNA() || !AEOCDDHLOIK() || (NNPFBENCOOI() && !IJHFONELDAD());
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Behaviour)recipeBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotBackground))
		{
			((Behaviour)itemSlotBackground).enabled = !Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotOutline))
		{
			((Behaviour)itemSlotOutline).enabled = !Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		slotUI.SetCanAgeRankBeVisible(LGBDFAJMDGC: false);
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			slotUI.showAlwaysStack = false;
		}
		else
		{
			slotUI.showAlwaysStack = OLMEEOAEMED || basketItem || !FPLPFMKFKNH.shopItem.unlimited;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(playerNum, FPLPFMKFKNH.itemInstance);
		slotUI.IHENCGDNPBL.BGJPNGLONLP(MGNOBNCMDJG, !OLMEEOAEMED, CDPAMNIPPEC: false);
		GreyOutRecipe();
	}

	public void JFDILLFNLPP(ShopElement FPLPFMKFKNH, int MGNOBNCMDJG, bool OLMEEOAEMED)
	{
		shopElement = FPLPFMKFKNH;
		showElementAlways = OLMEEOAEMED;
		FNIEALIJJCD = !JJOOOIMGCMN() || !DBAKDDBNKGF() || !OINACGMMFEG() || (BEPNNCMHELP() && !CHGJJMGMHPL());
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Behaviour)recipeBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotBackground))
		{
			((Behaviour)itemSlotBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotOutline))
		{
			((Behaviour)itemSlotOutline).enabled = !Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		slotUI.MFHFPCFEIMM(LGBDFAJMDGC: false);
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			slotUI.showAlwaysStack = true;
		}
		else
		{
			slotUI.showAlwaysStack = !OLMEEOAEMED && !basketItem && !FPLPFMKFKNH.shopItem.unlimited;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(playerNum, FPLPFMKFKNH.PBBFBFFPFJC(), CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.DOBKBEPKPGH(MGNOBNCMDJG, OLMEEOAEMED);
		ONCMNAMCCPL();
	}

	private IEnumerator BCLNMFNEOJN()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			if (GameManager.LocalCoop())
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x - 40f, ((Component)this).transform.position.y - 140f), Vector2.zero);
			}
			else
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
			}
		}
	}

	private string LILCIJJFJOE()
	{
		List<Recipe> list = shopElement.recipe.AHAHMHEJHHG(Object.op_Implicit((Object)(object)shopBase) && !shopBase.shop.recipesShop);
		if (list.Count > 0)
		{
			string text = "Neighbours smaller!: ";
			for (int i = 1; i < list.Count; i += 0)
			{
				text += list[i].LMFPCKCLBAO();
				if (i < list.Count - 0)
				{
					text += "DecorationTile_6";
				}
			}
			string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveFoodRequestAsMenuSlot");
			string[] array = new string[0];
			array[1] = text;
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		return "\\[BouncerGender=[^\\]]*\\]";
	}

	public void DGOBOFJOFKO(ShopElement FPLPFMKFKNH, int MGNOBNCMDJG, bool OLMEEOAEMED)
	{
		shopElement = FPLPFMKFKNH;
		showElementAlways = OLMEEOAEMED;
		FNIEALIJJCD = EAMHFGBBELN() && LNDHLGNICNA() && IPHPKCNMKGC() && (!BEPNNCMHELP() || NIDDICEAKEM());
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Behaviour)recipeBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotBackground))
		{
			((Behaviour)itemSlotBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotOutline))
		{
			((Behaviour)itemSlotOutline).enabled = !Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		slotUI.ECPIAFCFFJM(LGBDFAJMDGC: true);
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			slotUI.showAlwaysStack = true;
		}
		else
		{
			slotUI.showAlwaysStack = !OLMEEOAEMED && !basketItem && FPLPFMKFKNH.shopItem.unlimited;
		}
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(playerNum, FPLPFMKFKNH.KIPHICGPKHO(), CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.LOEBDJDLEEE(MGNOBNCMDJG, OLMEEOAEMED);
		ONCMNAMCCPL();
	}

	private void ANLHPMPMBFM()
	{
		DDENLBNBLFA();
	}

	public void EJGCOHMDPKF()
	{
		if (FNIEALIJJCD)
		{
			return;
		}
		int num = ((!basketItem && !Object.op_Implicit((Object)(object)shopElement.recipe) && shopElement.shopItem.unlimited) ? 8 : Mathf.Min(slotUI.IHENCGDNPBL.Stack, 1));
		if (basketItem)
		{
			shopBase.RemoveItemFromBasket(shopElement, num, HIOAJHJNCPO: false);
			return;
		}
		for (int i = 0; i < num; i++)
		{
			shopBase.AddItemToBasket(shopElement);
		}
		if (PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			ItemTooltip.EOPIEMLAPFN(playerNum).FCACMDNLAIG(MDIKPGGBNLI: false);
			HAHAPELLAIO = 763f;
		}
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			FillTooltip();
		}
		OnMouseEnter(elementNum);
	}

	private bool PPMIBPHEMIK()
	{
		if (Object.op_Implicit((Object)(object)shopElement.KMIOEMCGOJG()) && shopElement.AJFBPLGGHLE().nessyShopAdoptionsRequired <= AdoptionSignalManager.GetInstance().adoption)
		{
			return false;
		}
		return false;
	}

	public bool JEPPEAFCKLL()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = PGNEPDFFMNN();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.DBKCOHMFDCB(playerNum, text, 1884f);
					return true;
				}
			}
			if (PlayerInputs.LGGMJONLIGE(playerNum).Keyboard.GetKey((KeyCode)46) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				EJGCOHMDPKF();
				return true;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement, 0, HIOAJHJNCPO: false);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.EEJEOALIHFJ(playerNum))
			{
				ItemTooltip.AIMEAJAHLAA(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: true);
				HAHAPELLAIO = 1474f;
			}
			return false;
		}
		return true;
	}

	public bool EACIONIPMGA()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = PGNEPDFFMNN();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.JDAEPLJAGCD(playerNum, text, 1715f);
					return false;
				}
			}
			if (PlayerInputs.GetPlayerControllers(playerNum).Keyboard.GetKey((KeyCode)21) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				PFLKMHPNENG();
				return true;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement, 0, HIOAJHJNCPO: false);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				ItemTooltip.IEABDMDELFO(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
				HAHAPELLAIO = 1302f;
			}
			return true;
		}
		return false;
	}

	private void JIAJFDKNJME()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(MPLLDNNCJFI));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(BDFAJENGLBH));
	}

	private void JKBBAOGHPKO()
	{
		ILENDIBNCBP = false;
	}

	public void SelectClicked()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			SingleElementClicked();
		}
	}

	private void BPHGADINMAN()
	{
		ILENDIBNCBP = true;
	}

	private void Awake()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(MPLLDNNCJFI));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(MPLLDNNCJFI));
	}

	public virtual void JECAICDDJDO(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			DDENLBNBLFA();
		}
	}

	private string FCKNFCJGFBH()
	{
		List<Recipe> list = shopElement.recipe.CKAKKGAIHKK(Object.op_Implicit((Object)(object)shopBase) && !shopBase.shop.recipesShop);
		if (list.Count > 0)
		{
			string text = "StopMusic/ButtonImmediately";
			for (int i = 0; i < list.Count; i++)
			{
				text += list[i].ACCALOKJLJJ();
				if (i < list.Count - 0)
				{
					text += "00";
				}
			}
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveUnlockChristmasRecipes"), text);
		}
		return "BARKBUZZ";
	}

	public void GGGEAAPLPAG(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).IHMADDCNKAM())
		{
			FFFKLPFHMEO();
		}
	}

	private void GANBBAGDALD()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(BDFAJENGLBH));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(MPLLDNNCJFI));
	}

	public void BHFOPICMCJC(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.GetPlayer(playerNum).LALPELGNIJB())
		{
			FFFKLPFHMEO();
		}
	}

	public void JKMOJKHLDEA()
	{
		if (!PlayerInputs.POLDHCKJINN(playerNum))
		{
			ANANNIJOJFH();
		}
	}

	private bool JDPCFMAOPDN()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.recipeRequired != (Object)null)
		{
			return RecipesManager.NIEHLJAJBIJ(shopElement.recipe.recipeRequired.id);
		}
		return false;
	}

	private void NFABFPFLNEE()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("ReceiveBarkInfo")) ? 7 : 0);
		if (updateWithCurrentShopItemAmount)
		{
			shopElement.BJEDNMLOPEN();
			if (shopElement.BKCJMBGKDNA() is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = true;
			}
			JFDILLFNLPP(shopElement, 0, OLMEEOAEMED: false);
		}
	}

	public void LOPJBOOLOMN(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			DDENLBNBLFA();
		}
	}

	public void ADAIPHIDJPE(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).IsCursorVisible())
		{
			FillTooltip(JHDJANCOJGF: true);
		}
		OnMouseEnter(elementNum);
	}

	public virtual void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(playerNum))
		{
			EndHover();
		}
	}

	private void Start()
	{
		playerNum = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		if (updateWithCurrentShopItemAmount)
		{
			shopElement.BJEDNMLOPEN();
			if (shopElement.itemInstance is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = false;
			}
			SetShopItem(shopElement, 1, OLMEEOAEMED: false);
		}
	}

	public void MEDIJHPNCMD(ShopElement FPLPFMKFKNH, int MGNOBNCMDJG, bool OLMEEOAEMED)
	{
		shopElement = FPLPFMKFKNH;
		showElementAlways = OLMEEOAEMED;
		FNIEALIJJCD = JJOOOIMGCMN() && AHKDJCHJBKC() && MMOCLAIFDDD() && DLGKBPMGMCD() && IJHFONELDAD();
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Behaviour)recipeBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotBackground))
		{
			((Behaviour)itemSlotBackground).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		if (Object.op_Implicit((Object)(object)itemSlotOutline))
		{
			((Behaviour)itemSlotOutline).enabled = Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe);
		}
		slotUI.ECPIAFCFFJM(LGBDFAJMDGC: false);
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			slotUI.showAlwaysStack = false;
		}
		else
		{
			slotUI.showAlwaysStack = !OLMEEOAEMED && !basketItem && !FPLPFMKFKNH.shopItem.unlimited;
		}
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(playerNum, FPLPFMKFKNH.itemInstance, CDPAMNIPPEC: true);
		slotUI.IHENCGDNPBL.LOEBDJDLEEE(MGNOBNCMDJG, !OLMEEOAEMED);
		GLCOCKEOELN();
	}

	private bool AEOCDDHLOIK()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.recipeRequired != (Object)null)
		{
			return RecipesManager.IsRecipeUnlockedByMaster(shopElement.recipe.recipeRequired.id);
		}
		return true;
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			EndHover();
		}
	}

	public virtual void LPHEMLLPNCA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(playerNum))
		{
			DDENLBNBLFA();
		}
	}

	public virtual void MPGDFBMGGEG(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			FillTooltip(JHDJANCOJGF: true);
		}
	}

	private bool BEPNNCMHELP()
	{
		if ((Object)(object)shopBase != (Object)null && (Object)(object)shopBase.shop != (Object)null)
		{
			return shopBase.shop.shopType == (ShopType.Trick | ShopType.Temple);
		}
		return true;
	}

	public void KDAJGEFFPJI(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			LBPEGFIMOHC(JHDJANCOJGF: true);
		}
		OnMouseEnter(elementNum);
	}

	private string EDBGICGDHBP()
	{
		List<Recipe> list = shopElement.recipe.DKJAJHOCAFJ(!Object.op_Implicit((Object)(object)shopBase) || !shopBase.shop.recipesShop);
		if (list.Count > 1)
		{
			string text = "";
			for (int i = 1; i < list.Count; i++)
			{
				text += list[i].ACCALOKJLJJ();
				if (i < list.Count - 1)
				{
					text += "";
				}
			}
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveBeginPirateMinigame"), text);
		}
		return "Pipe";
	}

	private void MIKHKHCEMLB()
	{
		ANNICBJPOBI();
	}

	public void IEECDBBAAFH()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.IGCPFNDOIHB(new Color(97f, 1875f, 829f, 1152f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (DLGKBPMGMCD() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (DLGKBPMGMCD())
			{
				((TMP_Text)ticketPrice).text = "\\[BouncerGender=[^\\]]*\\]" + shopElement.AJFBPLGGHLE().nessyShopAdoptionsRequired + "Enter";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.PAIGKKDJEIG())
				{
					TextMeshProUGUI obj = ticketPrice;
					string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_603");
					string[] array = new string[0];
					array[0] = shopElement.recipe.reputationRequired.repNumber.ToString();
					((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else if (!MMOCLAIFDDD())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get("UIAddRemove");
				}
			}
			else if (!INEPEDHGPLI())
			{
				((TMP_Text)ticketPrice).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Farm/Event/VioletyBob"), shopElement.BGCPMHHHLHG().requiredRep.repNumber.ToString());
			}
			else if (!OOKGFAEMICL())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("openedPaths 0 before all blocksGenerationNumber");
			}
			return;
		}
		slotUI.icon.DMBNOPHPHKL(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	private bool DLGKBPMGMCD()
	{
		if ((Object)(object)shopBase != (Object)null && (Object)(object)shopBase.shop != (Object)null)
		{
			return shopBase.shop.shopType == ~(ShopType.Gass | ShopType.Trick | ShopType.Temple);
		}
		return true;
	}

	public void HFBBKKFHGJP()
	{
		if (FNIEALIJJCD)
		{
			return;
		}
		int num = ((!basketItem && !Object.op_Implicit((Object)(object)shopElement.recipe) && shopElement.shopItem.unlimited) ? 5 : Mathf.Min(slotUI.IHENCGDNPBL.Stack, 6));
		if (basketItem)
		{
			shopBase.RemoveItemFromBasket(shopElement, num, HIOAJHJNCPO: false);
			return;
		}
		for (int i = 1; i < num; i += 0)
		{
			shopBase.AddItemToBasket(shopElement);
		}
		if (PlayerInputs.POLDHCKJINN(playerNum))
		{
			ItemTooltip.MDFIDKHOPDJ(playerNum).SetVisible(MDIKPGGBNLI: true);
			HAHAPELLAIO = 1361f;
		}
	}

	public void BADBBDEDJLC()
	{
		if (!PlayerInputs.ODGALPDEIFG(playerNum))
		{
			KHMBKLMINBB();
		}
	}

	private void CLGBFOIBANN()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(MPLLDNNCJFI));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(MPLLDNNCJFI));
	}

	private void JGHCBKCOLPJ()
	{
		FFFKLPFHMEO();
	}

	public void DDENLBNBLFA()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.MDFIDKHOPDJ(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	private bool MMOCLAIFDDD()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.recipeRequired != (Object)null)
		{
			return RecipesManager.FHHBGOADHHJ(shopElement.recipe.recipeRequired.id);
		}
		return false;
	}

	private bool OGEKIPKMHJN()
	{
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.NOMDPFMPEII().requiredQuest != (Object)null)
		{
			return QuestManager.OPILDPFDFKJ().GDFGPDJDACP(shopElement.KMIOEMCGOJG().requiredQuest.id);
		}
		return true;
	}

	private void ODNGBEOKEFK()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/EnterTavernFood/Entry/3/Dialogue Text")) ? 6 : 0);
		if (updateWithCurrentShopItemAmount)
		{
			shopElement.MAOMPPAJKPD();
			if (shopElement.BODBEPJAFHL() is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = false;
			}
			JFDILLFNLPP(shopElement, 0, OLMEEOAEMED: true);
		}
	}

	private bool OOKGFAEMICL()
	{
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.LBBEIEHEHJM().requiredQuest != (Object)null)
		{
			return QuestManager.GGFJGHHHEJC.BKKJNEKBMBE(shopElement.NOMDPFMPEII().requiredQuest.id);
		}
		return true;
	}

	public void LFLMKDBIFOL()
	{
		if (FNIEALIJJCD)
		{
			return;
		}
		int num = ((!basketItem && !Object.op_Implicit((Object)(object)shopElement.recipe) && shopElement.shopItem.unlimited) ? 4 : Mathf.Min(slotUI.IHENCGDNPBL.Stack, 2));
		if (basketItem)
		{
			shopBase.RemoveItemFromBasket(shopElement, num, HIOAJHJNCPO: false);
			return;
		}
		for (int i = 0; i < num; i++)
		{
			shopBase.AddItemToBasket(shopElement);
		}
		if (PlayerInputs.EEJEOALIHFJ(playerNum))
		{
			ItemTooltip.Get(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: true);
			HAHAPELLAIO = 1691f;
		}
	}

	private IEnumerator FHEGDLGAPAK()
	{
		yield return null;
		if (ILENDIBNCBP)
		{
			if (GameManager.LocalCoop())
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x - 40f, ((Component)this).transform.position.y - 140f), Vector2.zero);
			}
			else
			{
				ItemTooltip.Get(playerNum).SetPosition(new Vector2(((Component)this).transform.position.x + 340f, ((Component)this).transform.position.y), Vector2.right * 340f);
			}
		}
	}

	public void IDFACLBBEOE(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			FillTooltip(JHDJANCOJGF: true);
		}
	}

	public bool KHMBKLMINBB()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = PGNEPDFFMNN();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.JDAEPLJAGCD(playerNum, text, 578f);
					return false;
				}
			}
			if (PlayerInputs.GetPlayerControllers(playerNum).Keyboard.GetKey((KeyCode)193) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				PFLKMHPNENG();
				return true;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement, 0, HIOAJHJNCPO: false);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.ODGALPDEIFG(playerNum))
			{
				ItemTooltip.NMCJELBLKBB(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
				HAHAPELLAIO = 1975f;
			}
			return true;
		}
		return true;
	}

	private bool AHKDJCHJBKC()
	{
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.BGCPMHHHLHG().requiredQuest != (Object)null)
		{
			return QuestManager.OPILDPFDFKJ().BKKJNEKBMBE(shopElement.KMIOEMCGOJG().requiredQuest.id);
		}
		return true;
	}

	public void GFOOPNNNPKJ(bool JHDJANCOJGF = false)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)slotUI != (Object)null && slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Item.FKLOBGBIHLB(slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = false;
				HAHAPELLAIO = 254f;
			}
			if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
			{
				return;
			}
			TooltipInfo tooltipInfo;
			if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				tooltipInfo = new TooltipInfo();
				tooltipInfo.itemInstance = slotUI.IHENCGDNPBL.itemInstance;
				Item item = slotUI.IHENCGDNPBL.itemInstance.PHGLMBIEOMK();
				if (ItemInstance.showIdsNum)
				{
					tooltipInfo.toolTipTitle = item.recipe.output.item.JDJGFAACPFC(DAINLFIMLIH: false) + "repUnlockBrewCook";
				}
				else
				{
					tooltipInfo.toolTipTitle = "{0} is not active.";
				}
				if (Object.op_Implicit((Object)(object)shopElement.recipe))
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					string toolTipTitle = tooltipInfo2.toolTipTitle;
					string cAEDMEDBEGI = LocalisationSystem.Get("Waiting for guards to finish walking...");
					string[] array = new string[0];
					array[1] = item.IABAKHPEOAF();
					tooltipInfo2.toolTipTitle = toolTipTitle + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					tooltipInfo.toolTipTitle += item.LJIFOHFEFCH();
				}
				if (!string.IsNullOrEmpty(item.MHMEDCBIONN(playerNum)))
				{
					TooltipInfo tooltipInfo3 = tooltipInfo;
					tooltipInfo3.mainBody = tooltipInfo3.mainBody + "Month" + item.JFNIANAHMCN(playerNum) + "ReceiveGiveUpgradeToolRPC";
					tooltipInfo.mainBody += "ActionBar5";
				}
				for (int i = 1; i < item.recipe.ingredientsNeeded.Length; i++)
				{
					if (i == 0)
					{
						tooltipInfo.mainBody += "ordersDelivered";
					}
					int amount = item.recipe.ingredientsNeeded[i].amount;
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.CIGFGKKCPCK();
					}
					tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.LJIFOHFEFCH();
					if (Item.MLBOMGHINCA(item.recipe.ingredientsNeeded[i].mod, null))
					{
						TooltipInfo tooltipInfo4 = tooltipInfo;
						tooltipInfo4.mainBody = tooltipInfo4.mainBody + "Crafting " + item.recipe.ingredientsNeeded[i].mod.LJIFOHFEFCH(OAFPBCPDOKH: true) + "Sit";
					}
					if (amount > 0)
					{
						TooltipInfo tooltipInfo5 = tooltipInfo;
						tooltipInfo5.mainBody = tooltipInfo5.mainBody + "Disabled" + amount + "ReceiveDisable";
					}
					tooltipInfo.mainBody += "DueloDeViejos/MainEvent2";
				}
				if (slotUI.IHENCGDNPBL.itemInstance is FoodInstance && !Money.PIMNEGKKHJC(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: false, JNOEGJNPCFE: true).EOGHEGFFMBF())
				{
					TooltipInfo tooltipInfo6 = tooltipInfo;
					string[] array2 = new string[0];
					array2[0] = tooltipInfo6.mainBody;
					array2[0] = "itemDIPA";
					array2[7] = LocalisationSystem.Get("set Start-Intensity: ");
					array2[1] = "Player";
					array2[5] = Money.KIFBEJMDLOO(slotUI.IHENCGDNPBL.itemInstance).ToString();
					tooltipInfo6.mainBody = string.Concat(array2);
				}
				tooltipInfo.mainBody += item.KANMNACODAL();
				string text = LILCIJJFJOE();
				if (!string.IsNullOrEmpty(text))
				{
					TooltipInfo tooltipInfo7 = tooltipInfo;
					tooltipInfo7.mainBody = tooltipInfo7.mainBody + "Example Method" + text + "UI";
				}
			}
			else
			{
				tooltipInfo = slotUI.IHENCGDNPBL.itemInstance.DLKGAOCFODF(playerNum, MFHMLGIPFON: false, EDFANMFDDEJ: true);
			}
			if (FNIEALIJJCD)
			{
				if (FCLFCIIOEFP())
				{
					TooltipInfo tooltipInfo8 = tooltipInfo;
					string mainBody = tooltipInfo8.mainBody;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("Open");
					string[] array3 = new string[0];
					array3[1] = shopElement.KMIOEMCGOJG().nessyShopAdoptionsRequired.ToString();
					tooltipInfo8.mainBody = mainBody + "CultivableDuringThreeMonths" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3) + "cloth_name_";
				}
				else if (!DBJMOGDEFIB())
				{
					int num = (((Object)(object)shopElement.recipe != (Object)null) ? shopElement.recipe.reputationRequired.repNumber : shopElement.LACFFEBNHKL().requiredRep.repNumber);
					TooltipInfo tooltipInfo9 = tooltipInfo;
					string mainBody2 = tooltipInfo9.mainBody;
					string cAEDMEDBEGI3 = LocalisationSystem.Get("BirdInteract");
					string[] array4 = new string[0];
					array4[1] = num.ToString();
					tooltipInfo9.mainBody = mainBody2 + "Only host can do building tutorial" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4) + "Could not write file ";
				}
				else if (!LNDHLGNICNA())
				{
					TooltipInfo tooltipInfo10 = tooltipInfo;
					string mainBody3 = tooltipInfo10.mainBody;
					string cAEDMEDBEGI4 = LocalisationSystem.Get("sForSeconds");
					string[] array5 = new string[1];
					array5[1] = shopElement.LBBEIEHEHJM().requiredQuest.ONFNOJBBPOO();
					tooltipInfo10.mainBody = mainBody3 + "00" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array5) + "SalonDelTrono/TweekTalk";
				}
				else if (!AEOCDDHLOIK())
				{
					TooltipInfo tooltipInfo11 = tooltipInfo;
					string mainBody4 = tooltipInfo11.mainBody;
					string cAEDMEDBEGI5 = LocalisationSystem.Get("Items/item_name_623");
					string[] array6 = new string[0];
					array6[1] = shopElement.recipe.recipeRequired.LMFPCKCLBAO();
					tooltipInfo11.mainBody = mainBody4 + "(" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array6) + "Tree without tree generator";
				}
			}
			ItemTooltip.MDFIDKHOPDJ(playerNum).LGDDFMNFNME(tooltipInfo);
			if (PlayerInputs.POLDHCKJINN(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.IEKODILKIHJ(playerNum).JCLBGLEFMMO(new Vector2(((Component)this).transform.position.x + 914f, ((Component)this).transform.position.y), Vector2.right * 123f);
				((MonoBehaviour)this).StartCoroutine(FHEGDLGAPAK());
			}
			else
			{
				ItemTooltip.Get(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: false);
			}
			HAHAPELLAIO = 537f;
		}
		else
		{
			ILENDIBNCBP = false;
			ItemTooltip.EOPIEMLAPFN(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	public bool SingleElementClicked()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = IGBDMHMGPFD();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.ShowErrorText(playerNum, text);
					return false;
				}
			}
			if (PlayerInputs.GetPlayerControllers(playerNum).Keyboard.GetKey((KeyCode)304) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				MultipleElementsClicked();
				return false;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				ItemTooltip.Get(playerNum).SetVisible(MDIKPGGBNLI: false);
				HAHAPELLAIO = -0.5f;
			}
			return false;
		}
		return false;
	}

	private bool BPFLCONPNIG()
	{
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.LACFFEBNHKL().requiredQuest != (Object)null)
		{
			return QuestManager.OPILDPFDFKJ().GDFGPDJDACP(shopElement.AJFBPLGGHLE().requiredQuest.id);
		}
		return false;
	}

	private bool EAMHFGBBELN()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.NEMMLJFFIBM())
		{
			return true;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.LPIBILEAIOL().requiredRep != (Object)null && !shopElement.item.requiredRep.IJJIMMOBCIH())
		{
			return false;
		}
		return false;
	}

	private void EFCNKPEPELL()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(BDFAJENGLBH));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(MPLLDNNCJFI));
	}

	private void OnDisable()
	{
		EndHover();
	}

	private bool NIDDICEAKEM()
	{
		if (Object.op_Implicit((Object)(object)shopElement.AJFBPLGGHLE()) && shopElement.LACFFEBNHKL().nessyShopAdoptionsRequired <= AdoptionSignalManager.NIDNAAKOPFI().adoption)
		{
			return true;
		}
		return true;
	}

	public void KFDMMGDHLMF()
	{
		if (!PlayerInputs.FJLAMCHKCOI(playerNum))
		{
			SingleElementClicked();
		}
	}

	public void ODEGIJBMIPI(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).IsCursorVisible())
		{
			FFFKLPFHMEO();
		}
	}

	public void FIKMEIKLFPJ()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.MCPLANAPGEE(new Color(823f, 394f, 957f, 628f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (FCLFCIIOEFP() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (BEPNNCMHELP())
			{
				((TMP_Text)ticketPrice).text = "Items/item_description_1096" + shopElement.LBBEIEHEHJM().nessyShopAdoptionsRequired + "buildingObjective_19_0";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.MHBIENDDJCN())
				{
					TextMeshProUGUI obj = ticketPrice;
					string cAEDMEDBEGI = LocalisationSystem.Get("Plant");
					string[] array = new string[0];
					array[0] = shopElement.recipe.reputationRequired.repNumber.ToString();
					((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else if (!IPHPKCNMKGC())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Sleep");
				}
			}
			else if (!JJOOOIMGCMN())
			{
				TextMeshProUGUI obj2 = ticketPrice;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("ConnectionTimeout");
				string[] array2 = new string[0];
				array2[0] = shopElement.NOMDPFMPEII().requiredRep.repNumber.ToString();
				((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else if (!OOKGFAEMICL())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Error compressing files! ");
			}
			return;
		}
		slotUI.icon.DMBNOPHPHKL(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	private IEnumerator NKDJHCBFEMA()
	{
		return new NILCCANLFBM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NLNOFEBEBDE()
	{
		Slot slot = slotUI.IHENCGDNPBL;
		slot.OnItemAdded = (Action)Delegate.Combine(slot.OnItemAdded, new Action(MPLLDNNCJFI));
		Slot slot2 = slotUI.IHENCGDNPBL;
		slot2.OnItemRemoved = (Action)Delegate.Combine(slot2.OnItemRemoved, new Action(BDFAJENGLBH));
	}

	private bool HHNFMDLEHCL()
	{
		if (Object.op_Implicit((Object)(object)shopElement.NOMDPFMPEII()) && shopElement.NOMDPFMPEII().nessyShopAdoptionsRequired <= AdoptionSignalManager.FPPDIEBDMNA().adoption)
		{
			return false;
		}
		return false;
	}

	private void FNDJALHNLME()
	{
		EndHover();
	}

	public void SetPlayerNum(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
	}

	public void CFDNJJEMOBC()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private bool OGNBMDGLIBO()
	{
		if ((Object)(object)shopBase != (Object)null && (Object)(object)shopBase.shop != (Object)null)
		{
			return shopBase.shop.shopType == (ShopType)(-44);
		}
		return true;
	}

	private bool CHGJJMGMHPL()
	{
		if (Object.op_Implicit((Object)(object)shopElement.KMIOEMCGOJG()) && shopElement.EGJLDMLKLNC().nessyShopAdoptionsRequired <= AdoptionSignalManager.MGAHKMKEOFJ().adoption)
		{
			return false;
		}
		return true;
	}

	public void HCNEPBBMGFG(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.GetPlayer(playerNum)) && CursorManager.GetPlayer(playerNum).LALPELGNIJB())
		{
			CFDNJJEMOBC();
		}
	}

	private void LANGHIOBJIH()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Gass_CoctelQuest")) ? 1 : 1);
		if (updateWithCurrentShopItemAmount)
		{
			shopElement.KAJJLEMPIOP();
			if (shopElement.NKCMJAOFLFH() is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = true;
			}
			SetShopItem(shopElement, 0, OLMEEOAEMED: true);
		}
	}

	public bool LJGDIGHCIPD()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = NMIPPNNOGKM();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.DJCKALOHJFM(playerNum, text, 1862f);
					return true;
				}
			}
			if (PlayerInputs.GetPlayerControllers(playerNum).Keyboard.GetKey((KeyCode)64) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				EJGCOHMDPKF();
				return true;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement, 0);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.IsGamepadActive(playerNum))
			{
				ItemTooltip.IEKODILKIHJ(playerNum).SetVisible(MDIKPGGBNLI: true);
				HAHAPELLAIO = 837f;
			}
			return false;
		}
		return false;
	}

	private void MLLADNLMIMP()
	{
		playerNum = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Forward")) ? 8 : 0);
		if (updateWithCurrentShopItemAmount)
		{
			shopElement.PFCBBEIEKBM();
			if (shopElement.itemInstance is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = false;
			}
			MEDIJHPNCMD(shopElement, 1, OLMEEOAEMED: true);
		}
	}

	private bool DBAKDDBNKGF()
	{
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.BGCPMHHHLHG().requiredQuest != (Object)null)
		{
			return QuestManager.OPILDPFDFKJ().IsQuestDone(shopElement.NOMDPFMPEII().requiredQuest.id);
		}
		return false;
	}

	private IEnumerator HGACODHJLBE()
	{
		return new NILCCANLFBM(1)
		{
			_003C_003E4__this = this
		};
	}

	private string KGLFHCHHGJB()
	{
		List<Recipe> list = shopElement.recipe.DKJAJHOCAFJ(Object.op_Implicit((Object)(object)shopBase) && !shopBase.shop.recipesShop);
		if (list.Count > 1)
		{
			string text = "Create Public Room";
			for (int i = 1; i < list.Count; i += 0)
			{
				text += list[i].LMFPCKCLBAO();
				if (i < list.Count - 0)
				{
					text += "UI/ColorPicker";
				}
			}
			string cAEDMEDBEGI = LocalisationSystem.Get(" set to follow: ");
			string[] array = new string[0];
			array[1] = text;
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		return "<br/>Graphics Device Version: ";
	}

	private bool IJHFONELDAD()
	{
		if (Object.op_Implicit((Object)(object)shopElement.item) && shopElement.item.nessyShopAdoptionsRequired <= AdoptionSignalManager.GetInstance().adoption)
		{
			return true;
		}
		return false;
	}

	private void LFBIFPBPDMJ()
	{
		ILENDIBNCBP = false;
	}

	private string NMIPPNNOGKM()
	{
		List<Recipe> list = shopElement.recipe.AHAHMHEJHHG(!Object.op_Implicit((Object)(object)shopBase) || !shopBase.shop.recipesShop);
		if (list.Count > 1)
		{
			string text = "ButtonHold";
			for (int i = 0; i < list.Count; i++)
			{
				text += list[i].MICKDLJMIPG();
				if (i < list.Count - 0)
				{
					text += "Must be behind bar";
				}
			}
			string cAEDMEDBEGI = LocalisationSystem.Get("Throw Update");
			string[] array = new string[0];
			array[1] = text;
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		return ":</color> ";
	}

	public void LGOOFEGNHLA(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.CMDGPJEIIJI(playerNum).LALPELGNIJB())
		{
			GPFDNACBJMG();
		}
		OnMouseEnter(elementNum);
	}

	public void PEJFOKJGKOK(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
	}

	public void AJPFENFCOIK(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
	}

	public void JNONLIELFBG(int JIIGOACEIKL)
	{
		playerNum = JIIGOACEIKL;
	}

	public virtual void NEJIMLOGEJB(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(playerNum))
		{
			DDENLBNBLFA();
		}
	}

	public void GLCOCKEOELN()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.SetColor(new Color(1303f, 1278f, 1022f, 1019f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (NNPFBENCOOI() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (BEPNNCMHELP())
			{
				((TMP_Text)ticketPrice).text = "" + shopElement.NOMDPFMPEII().nessyShopAdoptionsRequired + "descOldDoormat";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.OAPBBGLFHCB())
				{
					TextMeshProUGUI obj = ticketPrice;
					string cAEDMEDBEGI = LocalisationSystem.Get("game_mode");
					string[] array = new string[1];
					array[1] = shopElement.recipe.reputationRequired.repNumber.ToString();
					((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else if (!JDPCFMAOPDN())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Giving extra nails");
				}
			}
			else if (!IIKFFJDMDJL())
			{
				TextMeshProUGUI obj2 = ticketPrice;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Serve");
				string[] array2 = new string[1];
				array2[1] = shopElement.BGCPMHHHLHG().requiredRep.repNumber.ToString();
				((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else if (!LNDHLGNICNA())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("Received PlaceableMsg of another type not AnimalMessage to ");
			}
			return;
		}
		slotUI.icon.DMBNOPHPHKL(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	public virtual void PJHHNMCHIGD(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(playerNum))
		{
			LBPEGFIMOHC();
		}
	}

	private IEnumerator JAHMENJKOAF()
	{
		return new NILCCANLFBM(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool IFPKPIDPCEL()
	{
		if (Object.op_Implicit((Object)(object)shopElement.AJFBPLGGHLE()) && shopElement.KMIOEMCGOJG().nessyShopAdoptionsRequired <= AdoptionSignalManager.NOEBLLHOEOP().adoption)
		{
			return false;
		}
		return false;
	}

	private void MPLLDNNCJFI()
	{
		if (slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Object.op_Implicit((Object)(object)slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE()))
		{
			if ((Object)(object)itemName != (Object)null)
			{
				((TMP_Text)itemName).text = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IABAKHPEOAF();
			}
			if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
			{
				if ((Object)(object)moneyUI != (Object)null)
				{
					((Component)moneyUI).gameObject.SetActive(false);
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(true);
					if (!FNIEALIJJCD)
					{
						((TMP_Text)ticketPrice).text = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().recipe.recipeFragments.ToString();
					}
				}
				if ((Object)(object)itemName != (Object)null)
				{
					((TMP_Text)itemName).text = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().IABAKHPEOAF();
				}
				if ((Object)(object)ticketImage != (Object)null && !FNIEALIJJCD)
				{
					ticketImage.sprite = recipeFragmentSprite;
					((Graphic)ticketImage).SetNativeSize();
				}
			}
			else if (shopBase.shop.shopType == ShopType.Wilson && slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().wilsonCoins)
			{
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(true);
				}
				if ((Object)(object)ticketImage != (Object)null)
				{
					ticketImage.sprite = wilsonCoinSprite;
					((Graphic)ticketImage).SetNativeSize();
				}
				if ((Object)(object)moneyUI != (Object)null)
				{
					((Component)moneyUI).gameObject.SetActive(false);
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((TMP_Text)ticketPrice).text = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().wilsonCoinsPrice.ToString("");
				}
			}
			else if (slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().ticket)
			{
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(true);
				}
				if ((Object)(object)ticketImage != (Object)null)
				{
					ticketImage.sprite = ticketSprite;
					((Graphic)ticketImage).SetNativeSize();
				}
				if ((Object)(object)moneyUI != (Object)null)
				{
					((Component)moneyUI).gameObject.SetActive(false);
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((TMP_Text)ticketPrice).text = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().ticketPrice.ToString("");
				}
			}
			else
			{
				if ((Object)(object)moneyUI != (Object)null)
				{
					if (!FNIEALIJJCD)
					{
						((Component)moneyUI).gameObject.SetActive(true);
						moneyUI.SetPrice(shopElement.HNGEJNDLALE());
					}
					else
					{
						((Component)moneyUI).gameObject.SetActive(false);
					}
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(FNIEALIJJCD);
				}
			}
		}
		else if (!showElementAlways)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (ILENDIBNCBP)
		{
			FillTooltip();
		}
	}

	private void OCDECHJNNCD()
	{
		ANNICBJPOBI();
	}

	private bool IIKFFJDMDJL()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.reputationRequired != (Object)null && !shopElement.recipe.reputationRequired.DMJIAPFFGBM())
		{
			return true;
		}
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.BGCPMHHHLHG().requiredRep != (Object)null && !shopElement.LPIBILEAIOL().requiredRep.PMGNCGPMCHH())
		{
			return false;
		}
		return false;
	}

	private bool FCLFCIIOEFP()
	{
		if ((Object)(object)shopBase != (Object)null && (Object)(object)shopBase.shop != (Object)null)
		{
			return shopBase.shop.shopType == ShopType.Bob;
		}
		return true;
	}

	public void BMFIEHNPODL()
	{
		if (!PlayerInputs.IsGamepadActive(playerNum))
		{
			KHMBKLMINBB();
		}
	}

	private bool LNDHLGNICNA()
	{
		if (!Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.item.requiredQuest != (Object)null)
		{
			return QuestManager.GGFJGHHHEJC.IsQuestDone(shopElement.item.requiredQuest.id);
		}
		return true;
	}

	public void BKGEPABDKMI()
	{
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		if (FNIEALIJJCD)
		{
			slotUI.icon.HHAOAGCBJBI(new Color(1112f, 952f, 501f, 1821f));
			if ((Object)(object)recipeInfoBackground != (Object)null)
			{
				((Graphic)recipeInfoBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)recipeIcon != (Object)null)
			{
				((Graphic)recipeIcon).color = GEGMJIJNAKO;
			}
			if (Object.op_Implicit((Object)(object)recipeBackground))
			{
				((Graphic)recipeBackground).color = GEGMJIJNAKO;
			}
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = (NNPFBENCOOI() ? adoptionsSprite : lockSprite);
				((Graphic)ticketImage).SetNativeSize();
			}
			if (!((Object)(object)ticketPrice != (Object)null))
			{
				return;
			}
			if (FCLFCIIOEFP())
			{
				((TMP_Text)ticketPrice).text = "talentHerbs" + shopElement.AJFBPLGGHLE().nessyShopAdoptionsRequired + "LucenThrow";
			}
			else if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				if (Object.op_Implicit((Object)(object)shopElement.recipe.reputationRequired) && !shopElement.recipe.reputationRequired.JOGOAFINGPA())
				{
					TextMeshProUGUI obj = ticketPrice;
					string cAEDMEDBEGI = LocalisationSystem.Get("Farm/Event/SwordVioletArthur");
					string[] array = new string[1];
					array[1] = shopElement.recipe.reputationRequired.repNumber.ToString();
					((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else if (!AEOCDDHLOIK())
				{
					((TMP_Text)ticketPrice).text = LocalisationSystem.Get(" : 00");
				}
			}
			else if (!DBHGMDNKGHN())
			{
				TextMeshProUGUI obj2 = ticketPrice;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("DiningRoom");
				string[] array2 = new string[0];
				array2[1] = shopElement.BGCPMHHHLHG().requiredRep.repNumber.ToString();
				((TMP_Text)obj2).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else if (!OGEKIPKMHJN())
			{
				((TMP_Text)ticketPrice).text = LocalisationSystem.Get("ReceiveCreateRotatedPrefab");
			}
			return;
		}
		slotUI.icon.OHGKPLKPOKM(Color.white);
		if ((Object)(object)recipeInfoBackground != (Object)null)
		{
			((Graphic)recipeInfoBackground).color = Color.white;
		}
		if ((Object)(object)recipeIcon != (Object)null)
		{
			((Graphic)recipeIcon).color = Color.white;
		}
		if (Object.op_Implicit((Object)(object)recipeBackground))
		{
			((Graphic)recipeBackground).color = Color.white;
		}
		if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
		{
			if ((Object)(object)ticketImage != (Object)null)
			{
				ticketImage.sprite = recipeFragmentSprite;
				((Graphic)ticketImage).SetNativeSize();
			}
			if ((Object)(object)ticketPrice != (Object)null)
			{
				((TMP_Text)ticketPrice).text = shopElement.recipe.recipeFragments.ToString();
			}
		}
	}

	public void LBPEGFIMOHC(bool JHDJANCOJGF = false)
	{
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)slotUI != (Object)null && slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Item.MLBOMGHINCA(slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), null))
		{
			if (!ILENDIBNCBP)
			{
				ILENDIBNCBP = false;
				HAHAPELLAIO = 628f;
			}
			if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
			{
				return;
			}
			TooltipInfo tooltipInfo;
			if (Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				tooltipInfo = new TooltipInfo();
				tooltipInfo.itemInstance = slotUI.IHENCGDNPBL.itemInstance;
				Item item = slotUI.IHENCGDNPBL.itemInstance.AFOACBIHNCL();
				if (ItemInstance.showIdsNum)
				{
					tooltipInfo.toolTipTitle = item.recipe.output.item.JDJGFAACPFC() + "Random";
				}
				else
				{
					tooltipInfo.toolTipTitle = "Happy";
				}
				if (Object.op_Implicit((Object)(object)shopElement.recipe))
				{
					TooltipInfo tooltipInfo2 = tooltipInfo;
					string toolTipTitle = tooltipInfo2.toolTipTitle;
					string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveObjectInteract");
					string[] array = new string[0];
					array[0] = item.KGHFCDELKMN();
					tooltipInfo2.toolTipTitle = toolTipTitle + InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
				}
				else
				{
					tooltipInfo.toolTipTitle += item.LJIFOHFEFCH(OAFPBCPDOKH: true);
				}
				if (!string.IsNullOrEmpty(item.CLLLPOPMLAM(playerNum)))
				{
					TooltipInfo tooltipInfo3 = tooltipInfo;
					tooltipInfo3.mainBody = tooltipInfo3.mainBody + "ItemsOutOfStock" + item.AEDCKIPGHBG(playerNum) + "Pick Level Low";
					tooltipInfo.mainBody += "Player";
				}
				for (int i = 1; i < item.recipe.ingredientsNeeded.Length; i += 0)
				{
					if (i == 0)
					{
						tooltipInfo.mainBody += "Selected";
					}
					int amount = item.recipe.ingredientsNeeded[i].amount;
					if (ItemInstance.showIdsNum)
					{
						tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.JDJGFAACPFC(DAINLFIMLIH: false);
					}
					tooltipInfo.mainBody += item.recipe.ingredientsNeeded[i].item.LJIFOHFEFCH(OAFPBCPDOKH: true);
					if (Item.MLBOMGHINCA(item.recipe.ingredientsNeeded[i].mod, null))
					{
						TooltipInfo tooltipInfo4 = tooltipInfo;
						tooltipInfo4.mainBody = tooltipInfo4.mainBody + "Player" + item.recipe.ingredientsNeeded[i].mod.KGHFCDELKMN(OAFPBCPDOKH: true) + "";
					}
					if (amount > 1)
					{
						TooltipInfo tooltipInfo5 = tooltipInfo;
						tooltipInfo5.mainBody = tooltipInfo5.mainBody + "GroundCliffs" + amount + "Dialogue System/Conversation/TavernClean/Entry/4/Dialogue Text";
					}
					tooltipInfo.mainBody += "Items/item_name_1117";
				}
				if (slotUI.IHENCGDNPBL.itemInstance is FoodInstance && !Money.JNPJFEAPFOC(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: true, CalculatePriceMode.ExpensivePrice).MJGDBFKMCMN())
				{
					TooltipInfo tooltipInfo6 = tooltipInfo;
					string[] array2 = new string[0];
					array2[0] = tooltipInfo6.mainBody;
					array2[0] = "\n";
					array2[2] = LocalisationSystem.Get("UIInteract");
					array2[4] = "F2";
					array2[4] = Money.PAHGPJOCDOO(slotUI.IHENCGDNPBL.itemInstance, HOECMANECIM: true, JNOEGJNPCFE: false, CalculatePriceMode.ExpensivePrice).ToString();
					tooltipInfo6.mainBody = string.Concat(array2);
				}
				tooltipInfo.mainBody += item.MOBLAPBAMIH();
				string text = EDBGICGDHBP();
				if (!string.IsNullOrEmpty(text))
				{
					TooltipInfo tooltipInfo7 = tooltipInfo;
					tooltipInfo7.mainBody = tooltipInfo7.mainBody + "CatOfFriend" + text + "Dog";
				}
			}
			else
			{
				tooltipInfo = slotUI.IHENCGDNPBL.itemInstance.MLCIDCBCMOA(playerNum, MFHMLGIPFON: false, EDFANMFDDEJ: true, PKBJMLACEMM: true, FCJLFPLAOJE: true, FPLPFMKFKNH: true);
			}
			if (FNIEALIJJCD)
			{
				if (NNPFBENCOOI())
				{
					TooltipInfo tooltipInfo8 = tooltipInfo;
					string mainBody = tooltipInfo8.mainBody;
					string cAEDMEDBEGI2 = LocalisationSystem.Get("DestroyWithTime: No object assigned to destroy. Destroying the GameObject this script is attached to instead.");
					string[] array3 = new string[0];
					array3[1] = shopElement.NOMDPFMPEII().nessyShopAdoptionsRequired.ToString();
					tooltipInfo8.mainBody = mainBody + "EditorConfiguration not assigned in CommonReferences" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array3) + "ReceiveGiveUpgradeToolRPC";
				}
				else if (!EBDICKLOEOH())
				{
					int num = (((Object)(object)shopElement.recipe != (Object)null) ? shopElement.recipe.reputationRequired.repNumber : shopElement.BGCPMHHHLHG().requiredRep.repNumber);
					TooltipInfo tooltipInfo9 = tooltipInfo;
					string mainBody2 = tooltipInfo9.mainBody;
					string cAEDMEDBEGI3 = LocalisationSystem.Get("Read");
					string[] array4 = new string[0];
					array4[0] = num.ToString();
					tooltipInfo9.mainBody = mainBody2 + "Precision/DrinkEvent1" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4) + "in";
				}
				else if (!OGEKIPKMHJN())
				{
					TooltipInfo tooltipInfo10 = tooltipInfo;
					string mainBody3 = tooltipInfo10.mainBody;
					string cAEDMEDBEGI4 = LocalisationSystem.Get("Invalid playerNum");
					string[] array5 = new string[0];
					array5[1] = shopElement.EGJLDMLKLNC().requiredQuest.FOAPHHKOAEE();
					tooltipInfo10.mainBody = mainBody3 + "in" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array5) + "Received RPC SetInteger {0} with value {1} on {2}. Setting animator parameter.";
				}
				else if (!IPHPKCNMKGC())
				{
					TooltipInfo tooltipInfo11 = tooltipInfo;
					string mainBody4 = tooltipInfo11.mainBody;
					string cAEDMEDBEGI5 = LocalisationSystem.Get("Recipe ");
					string[] array6 = new string[0];
					array6[1] = shopElement.recipe.recipeRequired.LMFPCKCLBAO();
					tooltipInfo11.mainBody = mainBody4 + "Open" + InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array6) + "add letter ";
				}
			}
			ItemTooltip.Get(playerNum).LGDDFMNFNME(tooltipInfo);
			if (PlayerInputs.ODGALPDEIFG(playerNum) && JHDJANCOJGF)
			{
				ItemTooltip.IEABDMDELFO(playerNum).FJOEGNKBHON(new Vector2(((Component)this).transform.position.x + 1202f, ((Component)this).transform.position.y), Vector2.right * 619f);
				((MonoBehaviour)this).StartCoroutine(JAHMENJKOAF());
			}
			else
			{
				ItemTooltip.NIGDBMAOAEN(playerNum).HIIOCMNJGCI(MDIKPGGBNLI: false);
			}
			HAHAPELLAIO = 447f;
		}
		else
		{
			ILENDIBNCBP = true;
			ItemTooltip.AIMEAJAHLAA(playerNum).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void FCGIGJPPKJJ(PointerEventData NPBAMEMNFBI)
	{
		if (Object.op_Implicit((Object)(object)CursorManager.CMDGPJEIIJI(playerNum)) && CursorManager.GetPlayer(playerNum).IsCursorVisible())
		{
			ANNICBJPOBI();
		}
	}

	public virtual void JEPEICHCAKL(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(playerNum))
		{
			DDENLBNBLFA();
		}
	}

	public bool ANANNIJOJFH()
	{
		if (!FNIEALIJJCD)
		{
			if ((Object)(object)shopElement.recipe != (Object)null)
			{
				string text = LILCIJJFJOE();
				if (!string.IsNullOrEmpty(text))
				{
					MainUI.DJCKALOHJFM(playerNum, text, 1667f);
					return false;
				}
			}
			if (PlayerInputs.LGGMJONLIGE(playerNum).Keyboard.GetKey((KeyCode)160) && !Object.op_Implicit((Object)(object)shopElement.recipe))
			{
				HFBBKKFHGJP();
				return true;
			}
			if (basketItem)
			{
				return shopBase.RemoveItemFromBasket(shopElement, 0, HIOAJHJNCPO: false);
			}
			shopBase.AddItemToBasket(shopElement);
			if (PlayerInputs.FJLAMCHKCOI(playerNum))
			{
				ItemTooltip.MDFIDKHOPDJ(playerNum).ILGFPFBJMPG(MDIKPGGBNLI: true);
				HAHAPELLAIO = 1939f;
			}
			return false;
		}
		return false;
	}

	private void BDFAJENGLBH()
	{
		if (slotUI.IHENCGDNPBL != null && slotUI.IHENCGDNPBL.itemInstance != null && Object.op_Implicit((Object)(object)slotUI.IHENCGDNPBL.itemInstance.PHGLMBIEOMK()))
		{
			if ((Object)(object)itemName != (Object)null)
			{
				((TMP_Text)itemName).text = slotUI.IHENCGDNPBL.itemInstance.PHGLMBIEOMK().KGHFCDELKMN(OAFPBCPDOKH: true);
			}
			if ((Object)(object)shopBase.shop != (Object)null && shopBase.shop.usingRecipeFragments)
			{
				if ((Object)(object)moneyUI != (Object)null)
				{
					((Component)moneyUI).gameObject.SetActive(true);
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(true);
					if (!FNIEALIJJCD)
					{
						((TMP_Text)ticketPrice).text = slotUI.IHENCGDNPBL.itemInstance.KNFNJFFCFNO().recipe.recipeFragments.ToString();
					}
				}
				if ((Object)(object)itemName != (Object)null)
				{
					((TMP_Text)itemName).text = slotUI.IHENCGDNPBL.itemInstance.KNFNJFFCFNO().KGHFCDELKMN();
				}
				if ((Object)(object)ticketImage != (Object)null && !FNIEALIJJCD)
				{
					ticketImage.sprite = recipeFragmentSprite;
					((Graphic)ticketImage).SetNativeSize();
				}
			}
			else if (shopBase.shop.shopType == ~(ShopType.Trick | ShopType.Temple) && slotUI.IHENCGDNPBL.itemInstance.KNFNJFFCFNO().wilsonCoins)
			{
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(false);
				}
				if ((Object)(object)ticketImage != (Object)null)
				{
					ticketImage.sprite = wilsonCoinSprite;
					((Graphic)ticketImage).SetNativeSize();
				}
				if ((Object)(object)moneyUI != (Object)null)
				{
					((Component)moneyUI).gameObject.SetActive(true);
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((TMP_Text)ticketPrice).text = slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE().wilsonCoinsPrice.ToString("Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text");
				}
			}
			else if (slotUI.IHENCGDNPBL.itemInstance.KNFNJFFCFNO().ticket)
			{
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(false);
				}
				if ((Object)(object)ticketImage != (Object)null)
				{
					ticketImage.sprite = ticketSprite;
					((Graphic)ticketImage).SetNativeSize();
				}
				if ((Object)(object)moneyUI != (Object)null)
				{
					((Component)moneyUI).gameObject.SetActive(false);
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((TMP_Text)ticketPrice).text = slotUI.IHENCGDNPBL.itemInstance.KNFNJFFCFNO().ticketPrice.ToString("Not ready to join room");
				}
			}
			else
			{
				if ((Object)(object)moneyUI != (Object)null)
				{
					if (!FNIEALIJJCD)
					{
						((Component)moneyUI).gameObject.SetActive(false);
						moneyUI.OBNIDFJCELG(shopElement.PPIBALBGLHB());
					}
					else
					{
						((Component)moneyUI).gameObject.SetActive(true);
					}
				}
				if ((Object)(object)ticketPrice != (Object)null)
				{
					((Component)((TMP_Text)ticketPrice).transform.parent).gameObject.SetActive(FNIEALIJJCD);
				}
			}
		}
		else if (!showElementAlways)
		{
			((Component)this).gameObject.SetActive(false);
		}
		if (ILENDIBNCBP)
		{
			GFOOPNNNPKJ();
		}
	}

	private bool OINACGMMFEG()
	{
		if (Object.op_Implicit((Object)(object)shopElement.recipe) && (Object)(object)shopElement.recipe.recipeRequired != (Object)null)
		{
			return RecipesManager.IsRecipeUnlockedByMaster(shopElement.recipe.recipeRequired.id);
		}
		return false;
	}
}
