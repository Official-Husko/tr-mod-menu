using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : ShopBaseUI
{
	[Serializable]
	public enum CategoryTab
	{
		All,
		Items,
		Recipes,
		Decor,
		Lighting,
		Furniture
	}

	public class LocalizedNameComparer : IComparer<ShopElement>
	{
		public int ECINGMIDKGM(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.AJFBPLGGHLE().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.item.KGHFCDELKMN();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int FBIKMGFHPFD(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.EGJLDMLKLNC().KGHFCDELKMN();
			string strB = JLMAILGJNCE.NOMDPFMPEII().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int NCKCKPFMPOG(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.BGCPMHHHLHG().IABAKHPEOAF(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.NOMDPFMPEII().LJIFOHFEFCH();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int OHLCCNHANBK(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.AJFBPLGGHLE().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.EGJLDMLKLNC().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int CJJHMJJFEEJ(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.item.KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.LBBEIEHEHJM().KGHFCDELKMN();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int EBJCGMPDKPO(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.item.IABAKHPEOAF(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.KMIOEMCGOJG().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int LGMIGEJIDLK(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LBBEIEHEHJM().IABAKHPEOAF();
			string strB = JLMAILGJNCE.LBBEIEHEHJM().KGHFCDELKMN();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int PMLLEBAHGPH(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.EGJLDMLKLNC().IABAKHPEOAF(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.EGJLDMLKLNC().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int BFADEKEHIMF(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LACFFEBNHKL().LJIFOHFEFCH();
			string strB = JLMAILGJNCE.BGCPMHHHLHG().LJIFOHFEFCH();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int Compare(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.item.IABAKHPEOAF();
			string strB = JLMAILGJNCE.item.IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int AFDFNKDFPJC(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.KMIOEMCGOJG().LJIFOHFEFCH(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.BGCPMHHHLHG().KGHFCDELKMN(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int CCLIGMEOLCO(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LBBEIEHEHJM().LJIFOHFEFCH();
			string strB = JLMAILGJNCE.LACFFEBNHKL().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int OONAHHOCKKJ(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LACFFEBNHKL().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.KMIOEMCGOJG().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int LJKGKJAJBEP(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LACFFEBNHKL().IABAKHPEOAF(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.item.KGHFCDELKMN();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int NOPHMPGNACE(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.item.KGHFCDELKMN();
			string strB = JLMAILGJNCE.LBBEIEHEHJM().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int ACPLFNCOEDC(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LBBEIEHEHJM().LJIFOHFEFCH();
			string strB = JLMAILGJNCE.LACFFEBNHKL().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int MOHCMDIOHDH(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.KMIOEMCGOJG().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.LBBEIEHEHJM().LJIFOHFEFCH();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int JPCOGKGHJLC(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.NOMDPFMPEII().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.AJFBPLGGHLE().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int IHKIGBJJOAF(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LPIBILEAIOL().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.KMIOEMCGOJG().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int KEDLLGCKEFF(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.AJFBPLGGHLE().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.LACFFEBNHKL().KGHFCDELKMN(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int PKEGFCLCBNI(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.NOMDPFMPEII().KGHFCDELKMN();
			string strB = JLMAILGJNCE.BGCPMHHHLHG().LJIFOHFEFCH();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int JDCHLBABCKF(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LACFFEBNHKL().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.KMIOEMCGOJG().KGHFCDELKMN();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int GDDFBBMGEJB(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.AJFBPLGGHLE().KGHFCDELKMN();
			string strB = JLMAILGJNCE.LPIBILEAIOL().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int PHLNODJJEGG(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LBBEIEHEHJM().KGHFCDELKMN();
			string strB = JLMAILGJNCE.LBBEIEHEHJM().KGHFCDELKMN(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int DEPDEEKLLCL(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.NOMDPFMPEII().LJIFOHFEFCH();
			string strB = JLMAILGJNCE.BGCPMHHHLHG().LJIFOHFEFCH();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int GGMCHDHJELO(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LPIBILEAIOL().LJIFOHFEFCH();
			string strB = JLMAILGJNCE.KMIOEMCGOJG().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int PFOKGIDAOEC(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.EGJLDMLKLNC().KGHFCDELKMN();
			string strB = JLMAILGJNCE.AJFBPLGGHLE().IABAKHPEOAF();
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}

		public int AHGHCJFCLLF(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.NOMDPFMPEII().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.LPIBILEAIOL().KGHFCDELKMN(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
		}

		public int OOODMNAIEHI(ShopElement NCPGNLOJGAF, ShopElement JLMAILGJNCE)
		{
			string strA = NCPGNLOJGAF.LBBEIEHEHJM().KGHFCDELKMN(OAFPBCPDOKH: true);
			string strB = JLMAILGJNCE.KMIOEMCGOJG().IABAKHPEOAF(OAFPBCPDOKH: true);
			return string.Compare(strA, strB, StringComparison.CurrentCulture);
		}
	}

	[CompilerGenerated]
	private sealed class HOOCINLMCHF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopUI _003C_003E4__this;

		private int _003Ct_003E5__2;

		private int _003Ci_003E5__3;

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
		public HOOCINLMCHF(int _003C_003E1__state)
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
			ShopUI shopUI = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0081;
			}
			_003C_003E1__state = -1;
			_003Ct_003E5__2 = 0;
			_003Ci_003E5__3 = 0;
			goto IL_0091;
			IL_0081:
			_003Ci_003E5__3++;
			goto IL_0091;
			IL_0091:
			if (_003Ci_003E5__3 < shopUI.optionsElements.Count)
			{
				((Component)shopUI.optionsElements[_003Ci_003E5__3]).gameObject.SetActive(false);
				_003Ct_003E5__2++;
				if (_003Ct_003E5__2 > 3)
				{
					_003Ct_003E5__2 = 0;
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0081;
			}
			return false;
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

	[CompilerGenerated]
	private sealed class LPEPGNDFOCM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopUI _003C_003E4__this;

		private int _003Ct_003E5__2;

		private int _003Ci_003E5__3;

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
		public LPEPGNDFOCM(int _003C_003E1__state)
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
			ShopUI shopUI = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_0210;
			}
			_003C_003E1__state = -1;
			_003Ct_003E5__2 = 0;
			shopUI.scrollRect.verticalScrollbar.value = 1f;
			bool flag = false;
			for (int i = 0; i < shopUI.EABLPPBEFNL.Count; i++)
			{
				if (shopUI.EABLPPBEFNL[i].amount > 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				if (!shopUI.searchInput.NBBBOLAGHFP)
				{
					for (int j = 0; j < shopUI.soldOut.Length; j++)
					{
						shopUI.soldOut[j].SetActive(true);
					}
				}
			}
			else
			{
				for (int k = 0; k < shopUI.soldOut.Length; k++)
				{
					shopUI.soldOut[k].SetActive(false);
				}
			}
			_003Ci_003E5__3 = 0;
			goto IL_0222;
			IL_0222:
			if (_003Ci_003E5__3 < shopUI.EABLPPBEFNL.Count)
			{
				if (_003Ci_003E5__3 >= shopUI.optionsElements.Count)
				{
					shopUI.optionsElements.Add(Object.Instantiate<ShopElementUI>(shopUI.optionElementPrefab, shopUI.optionsListParent.transform));
					shopUI.optionsElements[_003Ci_003E5__3].SetPlayerNum(shopUI.JIIGOACEIKL);
					shopUI.optionsElements[_003Ci_003E5__3].shopBase = shopUI;
				}
				((Component)shopUI.optionsElements[_003Ci_003E5__3]).gameObject.SetActive(true);
				shopUI.EABLPPBEFNL[_003Ci_003E5__3].BJEDNMLOPEN();
				if (shopUI.EABLPPBEFNL[_003Ci_003E5__3].itemInstance is AnimalInstance animalInstance)
				{
					animalInstance.showBirthdayOnTooltip = false;
				}
				shopUI.optionsElements[_003Ci_003E5__3].SetShopItem(shopUI.EABLPPBEFNL[_003Ci_003E5__3], shopUI.EABLPPBEFNL[_003Ci_003E5__3].amount, OLMEEOAEMED: false);
				_003Ct_003E5__2++;
				if (_003Ct_003E5__2 > 3)
				{
					_003Ct_003E5__2 = 0;
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0210;
			}
			for (int l = shopUI.EABLPPBEFNL.Count; l < shopUI.optionsElements.Count; l++)
			{
				((Component)shopUI.optionsElements[l]).gameObject.SetActive(false);
			}
			return false;
			IL_0210:
			_003Ci_003E5__3++;
			goto IL_0222;
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

	public Action<int, CategoryTab> OnCategorySelected = delegate
	{
	};

	[SerializeField]
	private TabUI[] categoriesTabUI;

	[SerializeField]
	private CategoryTab[] categories;

	[SerializeField]
	private TabUI[] categoryTabsAgatha;

	[SerializeField]
	private CategoryTab[] categoriesAgatha;

	[SerializeField]
	private GameObject categoriesContainer;

	[SerializeField]
	private GameObject recipePagesContainer;

	[SerializeField]
	private TabUI[] recipePagesTabUI;

	[SerializeField]
	private Recipe.RecipePage[] recipePages;

	[SerializeField]
	private Sprite spriteFocusCategories;

	[SerializeField]
	private Sprite spriteNotFocusCategories;

	[SerializeField]
	private Sprite beerSprite;

	[SerializeField]
	private Sprite recipeFragmentsSprite;

	[SerializeField]
	private Image windowIcon;

	public Animator[] panelsAnimatorUI;

	private int DNPOFANHGEA;

	[SerializeField]
	private TextInput searchInput;

	[SerializeField]
	private ScrollRect scrollRect;

	private CategoryTab CKLHPLMLBKJ = CategoryTab.Items;

	private Recipe.RecipePage JCEAFBKDMGN;

	private List<ShopElement> EABLPPBEFNL;

	public Image[] activateWithTabs;

	public static ShopUI[] instances = new ShopUI[3];

	public GameObject[] goldPanel;

	public GameObject[] ticketPanel;

	public GameObject[] recipeFragmentsPanel;

	public GameObject[] wilsonCoinPanel;

	public GameObject adoptionsPanel;

	public TextMeshProUGUI ticketPlayerText;

	public TextMeshProUGUI ticketBasketText;

	public TextMeshProUGUI recipeFragmentsPlayerText;

	public TextMeshProUGUI recipeFragmentsBasketText;

	public TextMeshProUGUI optionsPanelTitle;

	public TextMeshProUGUI soldOutText;

	public TextMeshProUGUI wilsonCoinPlayerText;

	public TextMeshProUGUI wilsonCoinBasketText;

	public TextMeshProUGUI adoptionsText;

	public GameObject[] soldOut;

	private Coroutine GODMGEHOBKP;

	private int DKMCBBJFODP;

	private int KANBIGLNJLO;

	public CategoryTab GBFGPENGELF
	{
		get
		{
			return CKLHPLMLBKJ;
		}
		set
		{
			CKLHPLMLBKJ = value;
			OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
		}
	}

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

	private IEnumerator MJNKPPMKPKE()
	{
		int t = 0;
		for (int i = 0; i < optionsElements.Count; i++)
		{
			((Component)optionsElements[i]).gameObject.SetActive(false);
			t++;
			if (t > 3)
			{
				t = 0;
				yield return null;
			}
		}
	}

	private ShopElement[] BMPKMNOCBIL(ShopElement[] HPGLDBGLNLA)
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			return HPGLDBGLNLA;
		}
		return HPGLDBGLNLA.Where((ShopElement NCPGNLOJGAF) => (((Object)(object)NCPGNLOJGAF.recipe != (Object)null) ? NCPGNLOJGAF.recipe.output.item : NCPGNLOJGAF.shopItem.item).IABAKHPEOAF().IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0).ToArray();
	}

	private void CCBLGJADPEO()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(JIEAPIOBAFN));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Remove(textInput2.OnTextClear, new Action(BEONMACPOCI));
	}

	public void BGMFINNBDJA(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (shop.recipesShop)
		{
			for (int i = 1; i < recipePagesTabUI.Length; i += 0)
			{
				if (i == KHEICLKLPDE)
				{
					KKDJOPDNMCH(recipePages[i]);
					DNPOFANHGEA = i;
					recipePagesTabUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories);
					EABOODHHNBP();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					recipePagesTabUI[i].ELEHNHEOMDK(spriteNotFocusCategories);
				}
			}
		}
		else if (shop.shopType == (ShopType.Gass | ShopType.Bob))
		{
			for (int j = 1; j < categoryTabsAgatha.Length; j++)
			{
				if (j == KHEICLKLPDE)
				{
					FLDNONNFAHE(categoriesAgatha[j]);
					DNPOFANHGEA = j;
					categoryTabsAgatha[j].IIBANMLPDAA(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					JIEAPIOBAFN();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoryTabsAgatha[j].NMOHHPFONIN(spriteNotFocusCategories);
				}
			}
		}
		else
		{
			for (int k = 0; k < categoriesTabUI.Length; k += 0)
			{
				if (k == KHEICLKLPDE)
				{
					CBLNHLCELJF(categories[k]);
					DNPOFANHGEA = k;
					categoriesTabUI[k].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
					CCEKHJJCHDE();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoriesTabUI[k].NNIBKIDJGGG(spriteNotFocusCategories);
				}
			}
		}
		scrollRect.verticalScrollbar.value = 213f;
	}

	public static ShopUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[CompilerGenerated]
	private void ICKHCDDGFLN()
	{
		FocusCategoryFilter(DKMCBBJFODP);
	}

	private void FPJHIPPJNMK()
	{
		buy = false;
		if (shop.shopType == (ShopType.Crowley | ShopType.Gass))
		{
			for (int i = 0; i < goldPanel.Length; i++)
			{
				goldPanel[i].SetActive(false);
				ticketPanel[i].SetActive(false);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(false);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.AFOACBIHNCL(40)).ToString("Skin index too high!: ");
		}
		else if (shop.shopType == (ShopType.Crowley | ShopType.Gass | ShopType.AceT | ShopType.Bob | ShopType.Holly))
		{
			for (int j = 1; j < goldPanel.Length; j++)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(true);
				ticketPanel[j].SetActive(true);
				recipeFragmentsPanel[j].SetActive(true);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL, LAGHIOKLJGH: true).HMCBIANPIKD(ItemDatabaseAccessor.KMBGJEKCJFJ(138, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString("Items/item_name_706");
		}
		else if (shop.recipesShop)
		{
			for (int k = 1; k < goldPanel.Length; k += 0)
			{
				goldPanel[k].SetActive(true);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(true);
				ticketPanel[l].SetActive(false);
				wilsonCoinPanel[l].SetActive(true);
				recipeFragmentsPanel[l].SetActive(true);
			}
		}
		if (shop.shopType == ~(ShopType.Crowley | ShopType.Gass | ShopType.Bob | ShopType.Trick))
		{
			adoptionsPanel.SetActive(true);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.MGAHKMKEOFJ().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(false);
		}
	}

	private void MFMLPEBCIDP()
	{
		NDMHGLGKPGJ(DKMCBBJFODP);
	}

	public void KCHJHIAGFPG(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (shop.recipesShop)
		{
			for (int i = 0; i < recipePagesTabUI.Length; i++)
			{
				if (i == KHEICLKLPDE)
				{
					KKDJOPDNMCH(recipePages[i]);
					DNPOFANHGEA = i;
					recipePagesTabUI[i].KHJLGGKPHLH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					AFBBPLKKMKC();
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
		else if (shop.shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Bob))
		{
			for (int j = 1; j < categoryTabsAgatha.Length; j += 0)
			{
				if (j == KHEICLKLPDE)
				{
					FLBEJJAKCGM(categoriesAgatha[j]);
					DNPOFANHGEA = j;
					categoryTabsAgatha[j].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					AFBBPLKKMKC();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoryTabsAgatha[j].EOICNOKEMFN(spriteNotFocusCategories);
				}
			}
		}
		else
		{
			for (int k = 0; k < categoriesTabUI.Length; k++)
			{
				if (k == KHEICLKLPDE)
				{
					MAMDBKKFBHB(categories[k]);
					DNPOFANHGEA = k;
					categoriesTabUI[k].KHJLGGKPHLH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					JIEAPIOBAFN();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoriesTabUI[k].DFHFPOIPCLK(spriteNotFocusCategories);
				}
			}
		}
		scrollRect.verticalScrollbar.value = 1049f;
	}

	private bool CLAGACPKNKL(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return RecipesManager.FHHBGOADHHJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.ONMNODMHHLG(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 7)
			{
				return true;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 197 && !LettersManager.instance.MIHACJOOLLM(32))
		{
			return true;
		}
		return true;
	}

	private void CACPOGPOKOJ()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(JIEAPIOBAFN));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Remove(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	private IEnumerator LHBBOCAOEKA()
	{
		return new LPEPGNDFOCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JIEMOJFOGEN(int KHEICLKLPDE)
	{
		HGJAOGNNJAO(KHEICLKLPDE);
	}

	private void DAALLBDDDKN(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = int.MaxValue;
			bool flag = false;
			bool flag2 = false;
			item = null;
			for (int i = 0; i < IJMFOEMPGFN.Count; i++)
			{
				if (!((Object)(object)IJMFOEMPGFN[i].recipe == (Object)null))
				{
					if ((Object)(object)IJMFOEMPGFN[i].recipe.reputationRequired == (Object)null)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if (IJMFOEMPGFN[i].recipe.reputationRequired.repNumber < num)
					{
						num = IJMFOEMPGFN[i].recipe.reputationRequired.repNumber;
						item = IJMFOEMPGFN[i];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.GetMilestoneMaster())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = int.MaxValue;
			bool flag = false;
			bool flag2 = false;
			for (int j = 0; j < IJMFOEMPGFN.Count; j++)
			{
				if (!((Object)(object)IJMFOEMPGFN[j].recipe != (Object)null))
				{
					if (IJMFOEMPGFN[j].item.BCDBAJMBIPK(shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.GetMilestoneMaster()))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if ((Object)(object)IJMFOEMPGFN[j].item.requiredRep != (Object)null && IJMFOEMPGFN[j].item.requiredRep.repNumber < num)
					{
						num = IJMFOEMPGFN[j].item.requiredRep.repNumber;
						item = IJMFOEMPGFN[j];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.GetMilestoneMaster())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	private void EBHOLLPMIMC(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		for (int i = 0; i < currentShopList.Length; i++)
		{
			if (!((Object)(object)currentShopList[i].recipe == (Object)null) && currentShopList[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(currentShopList[i]);
			}
		}
		ShopElement[] array = HJBADOJNFAA(list.ToArray());
		for (int j = 0; j < array.Length; j++)
		{
			if (OLAOCGNAOMP(array[j]))
			{
				IJMFOEMPGFN.Add(array[j]);
			}
		}
	}

	private void LAJLFBBMKLP()
	{
		IGBODNAELMP(1);
	}

	private void OHIGHGPMMEA(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = int.MaxValue;
			bool flag = false;
			bool flag2 = false;
			item = null;
			for (int i = 0; i < IJMFOEMPGFN.Count; i++)
			{
				if (!Item.NGIIPJDAMGP(IJMFOEMPGFN[i].item, null))
				{
					if (IJMFOEMPGFN[i].item.nessyShopAdoptionsRequired == 0)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if (IJMFOEMPGFN[i].item.nessyShopAdoptionsRequired < num)
					{
						num = IJMFOEMPGFN[i].item.nessyShopAdoptionsRequired;
						item = IJMFOEMPGFN[i];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > AdoptionSignalManager.GetInstance().adoption))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = int.MaxValue;
			bool flag = false;
			bool flag2 = false;
			for (int j = 0; j < IJMFOEMPGFN.Count; j++)
			{
				if (!Item.NGIIPJDAMGP(IJMFOEMPGFN[j].item, null) && IJMFOEMPGFN[j].item.nessyShopAdoptionsRequired != 0)
				{
					if (IJMFOEMPGFN[j].item.BCDBAJMBIPK(AdoptionSignalManager.GetInstance().adoption))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if (IJMFOEMPGFN[j].item.nessyShopAdoptionsRequired < num)
					{
						num = IJMFOEMPGFN[j].item.nessyShopAdoptionsRequired;
						item = IJMFOEMPGFN[j];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > AdoptionSignalManager.GetInstance().adoption))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	public void NDMHGLGKPGJ(int KHEICLKLPDE)
	{
		HDNOJIMAKOG(KHEICLKLPDE);
	}

	private void MFCHAAFFBLA()
	{
		buy = true;
		if (shop.shopType == ShopType.AceT)
		{
			for (int i = 1; i < goldPanel.Length; i += 0)
			{
				goldPanel[i].SetActive(false);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).NAENGEHEGHP(ItemDatabaseAccessor.AFOACBIHNCL(74, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString("Items/item_name_1189");
		}
		else if (shop.shopType == (ShopType.Holly | ShopType.Temple))
		{
			for (int j = 1; j < goldPanel.Length; j++)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(false);
				ticketPanel[j].SetActive(true);
				recipeFragmentsPanel[j].SetActive(true);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HMCBIANPIKD(ItemDatabaseAccessor.COEFFIHKMJG(164, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString("Dialogue System/Conversation/NeutralInTavern/Entry/7/Dialogue Text");
		}
		else if (shop.recipesShop)
		{
			for (int k = 0; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(false);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(false);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(true);
				ticketPanel[l].SetActive(true);
				wilsonCoinPanel[l].SetActive(true);
				recipeFragmentsPanel[l].SetActive(true);
			}
		}
		if (shop.shopType == (ShopType)115)
		{
			adoptionsPanel.SetActive(false);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.GetInstance().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(false);
		}
	}

	private IEnumerator JDIJFJHLDDP()
	{
		int t = 0;
		scrollRect.verticalScrollbar.value = 1f;
		bool flag = false;
		for (int j = 0; j < EABLPPBEFNL.Count; j++)
		{
			if (EABLPPBEFNL[j].amount > 0)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			if (!searchInput.NBBBOLAGHFP)
			{
				for (int k = 0; k < soldOut.Length; k++)
				{
					soldOut[k].SetActive(true);
				}
			}
		}
		else
		{
			for (int l = 0; l < soldOut.Length; l++)
			{
				soldOut[l].SetActive(false);
			}
		}
		for (int i = 0; i < EABLPPBEFNL.Count; i++)
		{
			if (i >= optionsElements.Count)
			{
				optionsElements.Add(Object.Instantiate<ShopElementUI>(optionElementPrefab, optionsListParent.transform));
				optionsElements[i].SetPlayerNum(base.JIIGOACEIKL);
				optionsElements[i].shopBase = this;
			}
			((Component)optionsElements[i]).gameObject.SetActive(true);
			EABLPPBEFNL[i].BJEDNMLOPEN();
			if (EABLPPBEFNL[i].itemInstance is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = false;
			}
			optionsElements[i].SetShopItem(EABLPPBEFNL[i], EABLPPBEFNL[i].amount, OLMEEOAEMED: false);
			t++;
			if (t > 3)
			{
				t = 0;
				yield return null;
			}
		}
		for (int m = EABLPPBEFNL.Count; m < optionsElements.Count; m++)
		{
			((Component)optionsElements[m]).gameObject.SetActive(false);
		}
	}

	private void ABBOFCGOIGI(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.ENPBNONDPLA())
		{
			return;
		}
		ShopElement[] hPGLDBGLNLA = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		hPGLDBGLNLA = GNPDELFCLCG(hPGLDBGLNLA);
		for (int i = 0; i < hPGLDBGLNLA.Length; i++)
		{
			if (OLAOCGNAOMP(hPGLDBGLNLA[i]))
			{
				IJMFOEMPGFN.Add(hPGLDBGLNLA[i]);
			}
		}
	}

	public void EAKNEHINICD(int KHEICLKLPDE)
	{
		BGMFINNBDJA(KHEICLKLPDE);
	}

	public void IGBODNAELMP(int KHEICLKLPDE)
	{
		HGJAOGNNJAO(KHEICLKLPDE);
	}

	[SpecialName]
	public void MHCMACLGFFG(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}

	private void ACNGJLJMDHM(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.ENPBNONDPLA())
		{
			return;
		}
		ShopElement[] hPGLDBGLNLA = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		hPGLDBGLNLA = GNPDELFCLCG(hPGLDBGLNLA);
		for (int i = 0; i < hPGLDBGLNLA.Length; i += 0)
		{
			if (HABKDPACBFE(hPGLDBGLNLA[i]))
			{
				IJMFOEMPGFN.Add(hPGLDBGLNLA[i]);
			}
		}
	}

	protected override void Update()
	{
		base.Update();
		if (!LKOJBFMGMAE || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
		{
			if (shop.shopType == ShopType.Woody || shop.shopType == ShopType.Petra || shop.shopType == ShopType.Amos)
			{
				FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA + 1, categoriesTabUI.Length));
			}
			if (shop.shopType == ShopType.Agatha)
			{
				FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA + 1, categoryTabsAgatha.Length));
			}
			if (shop.recipesShop)
			{
				FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA + 1, recipePagesTabUI.Length));
			}
		}
		else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
		{
			if (shop.shopType == ShopType.Woody || shop.shopType == ShopType.Petra || shop.shopType == ShopType.Amos)
			{
				FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA - 1, categoriesTabUI.Length));
			}
			if (shop.shopType == ShopType.Agatha)
			{
				FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA - 1, categoryTabsAgatha.Length));
			}
			if (shop.recipesShop)
			{
				FocusCategoryFilter(Utils.NMLNAGFLNMC(DNPOFANHGEA - 1, recipePagesTabUI.Length));
			}
		}
		else if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") || PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
		{
			OrderBasket();
		}
		else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UISelectGamepad") && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
		{
			ShopElementUI component = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<ShopElementUI>();
			if (Object.op_Implicit((Object)(object)component))
			{
				component.MultipleElementsClicked();
			}
		}
	}

	private void GACMOICLFCP()
	{
		FocusCategoryFilterOnSearch(0);
	}

	public static ShopUI EPKNOMLADCL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EAHIMPBPMKP()
	{
		MGFLJOOGCPB(DKMCBBJFODP);
	}

	private bool FENHNMCOGDJ(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return !RecipesManager.NIEHLJAJBIJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.ONMNODMHHLG(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 6)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.IMCJPECAAPC() == 100 && !LettersManager.instance.AONGGPJDPMO(165))
		{
			return true;
		}
		return true;
	}

	private void GJLGMCKFNPN(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 1)
		{
			int num = -125;
			bool flag = true;
			bool flag2 = true;
			item = null;
			for (int i = 0; i < IJMFOEMPGFN.Count; i++)
			{
				if (!Item.EKGNIODFJCO(IJMFOEMPGFN[i].NOMDPFMPEII(), null))
				{
					if (IJMFOEMPGFN[i].LBBEIEHEHJM().nessyShopAdoptionsRequired == 0)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if (IJMFOEMPGFN[i].AJFBPLGGHLE().nessyShopAdoptionsRequired < num)
					{
						num = IJMFOEMPGFN[i].item.nessyShopAdoptionsRequired;
						item = IJMFOEMPGFN[i];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > AdoptionSignalManager.NOEBLLHOEOP().adoption))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = -167;
			bool flag = false;
			bool flag2 = true;
			for (int j = 1; j < IJMFOEMPGFN.Count; j += 0)
			{
				if (!Item.NGIIPJDAMGP(IJMFOEMPGFN[j].AJFBPLGGHLE(), null) && IJMFOEMPGFN[j].item.nessyShopAdoptionsRequired != 0)
				{
					if (IJMFOEMPGFN[j].AJFBPLGGHLE().DJLPCJEABOK(AdoptionSignalManager.NOEBLLHOEOP().adoption))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if (IJMFOEMPGFN[j].NOMDPFMPEII().nessyShopAdoptionsRequired < num)
					{
						num = IJMFOEMPGFN[j].KMIOEMCGOJG().nessyShopAdoptionsRequired;
						item = IJMFOEMPGFN[j];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > AdoptionSignalManager.DNEGFMDKNHL().adoption))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	public static ShopUI FKFNANNBIAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool JKMNKCNDCGA(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id);
			}
			return RecipesManager.NIEHLJAJBIJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.IsRecipeUnlockedByMaster(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 0)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.IMCJPECAAPC(DAINLFIMLIH: false) == 190 && !LettersManager.instance.AONGGPJDPMO(9))
		{
			return true;
		}
		return true;
	}

	private void KJCABGMAOIA()
	{
		IGBODNAELMP(0);
	}

	private void PPPGIGMLILL(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = 55;
			bool flag = false;
			bool flag2 = false;
			item = null;
			for (int i = 0; i < IJMFOEMPGFN.Count; i += 0)
			{
				if (!Item.GBMFCPGEJDK(IJMFOEMPGFN[i].BGCPMHHHLHG(), null))
				{
					if (IJMFOEMPGFN[i].NOMDPFMPEII().nessyShopAdoptionsRequired == 0)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if (IJMFOEMPGFN[i].AJFBPLGGHLE().nessyShopAdoptionsRequired < num)
					{
						num = IJMFOEMPGFN[i].BGCPMHHHLHG().nessyShopAdoptionsRequired;
						item = IJMFOEMPGFN[i];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > AdoptionSignalManager.GetInstance().adoption))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 1)
		{
			int num = 67;
			bool flag = true;
			bool flag2 = false;
			for (int j = 1; j < IJMFOEMPGFN.Count; j++)
			{
				if (!Item.NGIIPJDAMGP(IJMFOEMPGFN[j].AJFBPLGGHLE(), null) && IJMFOEMPGFN[j].LPIBILEAIOL().nessyShopAdoptionsRequired != 0)
				{
					if (IJMFOEMPGFN[j].BGCPMHHHLHG().IMEIPAHHCLE(AdoptionSignalManager.LPADOMGFAIE().adoption))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if (IJMFOEMPGFN[j].EGJLDMLKLNC().nessyShopAdoptionsRequired < num)
					{
						num = IJMFOEMPGFN[j].NOMDPFMPEII().nessyShopAdoptionsRequired;
						item = IJMFOEMPGFN[j];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > AdoptionSignalManager.OMEPPDMCFAO().adoption))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
		content.SetActive(false);
	}

	[SpecialName]
	public void KKDJOPDNMCH(Recipe.RecipePage AODONKKHPBP)
	{
		JCEAFBKDMGN = AODONKKHPBP;
	}

	private void LANLFKNHAGK()
	{
		buy = false;
		if (shop.shopType == (ShopType)3)
		{
			for (int i = 1; i < goldPanel.Length; i++)
			{
				goldPanel[i].SetActive(true);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(false);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(ItemDatabaseAccessor.CPMMBEPEJLO(110, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString("Attack/MainEvent 4");
		}
		else if (shop.shopType == (ShopType)147)
		{
			for (int j = 1; j < goldPanel.Length; j += 0)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(true);
				ticketPanel[j].SetActive(false);
				recipeFragmentsPanel[j].SetActive(false);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL).NAENGEHEGHP(ItemDatabaseAccessor.GOKIDLOELKB(84, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString("Miners/Mine/Ferro/Explosion");
		}
		else if (shop.recipesShop)
		{
			for (int k = 1; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(true);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(true);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l += 0)
			{
				goldPanel[l].SetActive(true);
				ticketPanel[l].SetActive(false);
				wilsonCoinPanel[l].SetActive(true);
				recipeFragmentsPanel[l].SetActive(false);
			}
		}
		if (shop.shopType == ~(ShopType.Gass | ShopType.Bob | ShopType.Temple))
		{
			adoptionsPanel.SetActive(true);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.FFOMKKIAHKI().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(false);
		}
	}

	private ShopElement[] GNPDELFCLCG(ShopElement[] HPGLDBGLNLA)
	{
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			return HPGLDBGLNLA;
		}
		return HPGLDBGLNLA.Where(IOPDBJAKHPO).ToArray();
	}

	private void GHEOLMMHFJC()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(AFBBPLKKMKC));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(NAGPHMNKFKJ));
	}

	public static ShopUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool GAIGPHBJMFL(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id);
			}
			return !RecipesManager.ONMNODMHHLG(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.FHHBGOADHHJ(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 3)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.JPNFKDMFKMC() == 115 && !LettersManager.instance.MIHACJOOLLM(118))
		{
			return false;
		}
		return true;
	}

	private void EABOODHHNBP()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		if (shop.recipesShop)
		{
			if (JCEAFBKDMGN.Equals(Recipe.RecipePage.All))
			{
				for (int i = 0; i < recipePages.Length; i++)
				{
					EBHOLLPMIMC(list, recipePages[i]);
				}
			}
			else
			{
				JLDJMEKLFIP(list, JCEAFBKDMGN);
			}
		}
		else if (shop.shopType == (ShopType)133 || shop.shopType == (ShopType)65 || shop.shopType == ~(ShopType.Crowley | ShopType.Gass | ShopType.AceT | ShopType.Trick) || shop.shopType == (ShopType)71)
		{
			NDBGGIPFJCE(list, CKLHPLMLBKJ);
		}
		else
		{
			KKOMCPGPJIJ(list);
		}
		if (shop.shopType == (ShopType.Gass | ShopType.AceT | ShopType.Bob | ShopType.Holly | ShopType.Trick))
		{
			for (int num = list.Count - 1; num >= 0; num--)
			{
				if (list[num].shopItem.item.JGHNDJBCFAJ() == -97)
				{
					Result variable = DialogueLua.GetVariable("ReceiveEnable");
					if (((Result)(ref variable)).asInt < -6)
					{
						list.RemoveAt(num);
					}
				}
			}
			EABLPPBEFNL = list;
		}
		else if (shop.shopType == (ShopType)53)
		{
			EABLPPBEFNL = new List<ShopElement>();
			GJLGMCKFNPN(list, EFAHEOILMDH: false);
			OHIGHGPMMEA(list, EFAHEOILMDH: true);
		}
		else
		{
			EABLPPBEFNL = new List<ShopElement>();
			KEBHOBBLCNN(list, EFAHEOILMDH: false);
			MKGDELGFAIG(list, EFAHEOILMDH: true);
		}
		GELCMGCKCGG();
		OGBKMPPJHON();
	}

	[SpecialName]
	public Recipe.RecipePage FOLGHLJCJIF()
	{
		return JCEAFBKDMGN;
	}

	[SpecialName]
	public void FLDNONNFAHE(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}

	private void HMILNOIBBLD()
	{
		buy = true;
		if (shop.shopType == (ShopType)7)
		{
			for (int i = 1; i < goldPanel.Length; i += 0)
			{
				goldPanel[i].SetActive(true);
				ticketPanel[i].SetActive(false);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DEGAJPFIJDD(ItemDatabaseAccessor.GetItem(-128, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString("Miners/Mine/Clive/Intro");
		}
		else if (shop.shopType == (ShopType)115)
		{
			for (int j = 1; j < goldPanel.Length; j += 0)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(false);
				ticketPanel[j].SetActive(false);
				recipeFragmentsPanel[j].SetActive(false);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(ItemDatabaseAccessor.COEFFIHKMJG(-130)).ToString("complete quest ");
		}
		else if (shop.recipesShop)
		{
			for (int k = 1; k < goldPanel.Length; k += 0)
			{
				goldPanel[k].SetActive(false);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(true);
				ticketPanel[l].SetActive(true);
				wilsonCoinPanel[l].SetActive(false);
				recipeFragmentsPanel[l].SetActive(false);
			}
		}
		if (shop.shopType == (ShopType)(-176))
		{
			adoptionsPanel.SetActive(false);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.GetInstance().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(false);
		}
	}

	private void NAGPHMNKFKJ()
	{
		JIEMOJFOGEN(DKMCBBJFODP);
	}

	private void NEPKCOMIHID()
	{
		MGFLJOOGCPB(1);
	}

	private ShopElement[] HJBADOJNFAA(ShopElement[] HPGLDBGLNLA)
	{
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL) || string.IsNullOrEmpty(searchInput.currentText))
		{
			return HPGLDBGLNLA;
		}
		return HPGLDBGLNLA.Where((ShopElement NCPGNLOJGAF) => (((Object)(object)NCPGNLOJGAF.recipe != (Object)null) ? NCPGNLOJGAF.recipe.output.item : NCPGNLOJGAF.shopItem.item).IABAKHPEOAF().IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0).ToArray();
	}

	private void BKCJFPOLFIO(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.NDOIFBGIKHN())
		{
			return;
		}
		ShopElement[] hPGLDBGLNLA = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		hPGLDBGLNLA = HJBADOJNFAA(hPGLDBGLNLA);
		for (int i = 0; i < hPGLDBGLNLA.Length; i++)
		{
			if (HABKDPACBFE(hPGLDBGLNLA[i]))
			{
				IJMFOEMPGFN.Add(hPGLDBGLNLA[i]);
			}
		}
	}

	private bool HABKDPACBFE(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return RecipesManager.ONMNODMHHLG(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.NIEHLJAJBIJ(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 7)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.IMCJPECAAPC(DAINLFIMLIH: false) == 137 && !LettersManager.instance.IHDJNAFBBGI(124))
		{
			return false;
		}
		return true;
	}

	public override void UpdateOptionsUI()
	{
		if (GODMGEHOBKP != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(GODMGEHOBKP);
		}
		GODMGEHOBKP = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(JDIJFJHLDDP());
	}

	[SpecialName]
	public CategoryTab MKMPOCGEABJ()
	{
		return CKLHPLMLBKJ;
	}

	private void CJBHKEJCJCA()
	{
		IGBODNAELMP(0);
	}

	private void IBDMOLJCLJB(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.NDOIFBGIKHN())
		{
			return;
		}
		ShopElement[] hPGLDBGLNLA = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		hPGLDBGLNLA = GNPDELFCLCG(hPGLDBGLNLA);
		for (int i = 1; i < hPGLDBGLNLA.Length; i += 0)
		{
			if (ABHGFMOKHOE(hPGLDBGLNLA[i]))
			{
				IJMFOEMPGFN.Add(hPGLDBGLNLA[i]);
			}
		}
	}

	private void JLDJMEKLFIP(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] array = ShopDatabaseAccessor.JPIOGNINAFB(shop.shopType);
		for (int i = 1; i < array.Length; i++)
		{
			if (!((Object)(object)array[i].recipe == (Object)null) && array[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] array2 = GNPDELFCLCG(list.ToArray());
		for (int j = 1; j < array2.Length; j += 0)
		{
			if (ELNHOHGPDMF(array2[j]))
			{
				IJMFOEMPGFN.Add(array2[j]);
			}
		}
	}

	private bool AGCNBGFFFKN(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return RecipesManager.FHHBGOADHHJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.IsRecipeUnlockedByMaster(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 1)
			{
				return true;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -98 && !LettersManager.instance.IHDJNAFBBGI(-59))
		{
			return true;
		}
		return true;
	}

	private void EOCIJAOABHB()
	{
		buy = true;
		if (shop.shopType == (ShopType)1)
		{
			for (int i = 1; i < goldPanel.Length; i++)
			{
				goldPanel[i].SetActive(false);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NAENGEHEGHP(ItemDatabaseAccessor.KMBGJEKCJFJ(71, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString("InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ");
		}
		else if (shop.shopType == (ShopType.Trick | ShopType.Temple))
		{
			for (int j = 0; j < goldPanel.Length; j += 0)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(true);
				ticketPanel[j].SetActive(true);
				recipeFragmentsPanel[j].SetActive(false);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).NumberOfItems(ItemDatabaseAccessor.INJBNHPGCIJ(-99, GGBBJNBBLMF: true)).ToString("/");
		}
		else if (shop.recipesShop)
		{
			for (int k = 0; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(true);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(true);
				recipeFragmentsPanel[k].SetActive(false);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(false);
				ticketPanel[l].SetActive(true);
				wilsonCoinPanel[l].SetActive(true);
				recipeFragmentsPanel[l].SetActive(true);
			}
		}
		if (shop.shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Temple))
		{
			adoptionsPanel.SetActive(true);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.CAJHNGGCJKM().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(true);
		}
	}

	private bool IOPDBJAKHPO(ShopElement NCPGNLOJGAF)
	{
		return (((Object)(object)NCPGNLOJGAF.recipe != (Object)null) ? NCPGNLOJGAF.recipe.output.item : NCPGNLOJGAF.shopItem.item).IABAKHPEOAF(OAFPBCPDOKH: true).IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) < 1;
	}

	[SpecialName]
	public void MAMDBKKFBHB(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}

	public static ShopUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator LBKLGPODDIB()
	{
		int t = 0;
		for (int i = 0; i < optionsElements.Count; i++)
		{
			((Component)optionsElements[i]).gameObject.SetActive(false);
			t++;
			if (t > 3)
			{
				t = 0;
				yield return null;
			}
		}
	}

	private void LJIGHEHMEFH(List<ShopElement> IJMFOEMPGFN, CategoryTab LJBKGJPCBIN)
	{
		if (!ShopDatabaseAccessor.IsValid())
		{
			return;
		}
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		List<ShopElement> list = new List<ShopElement>();
		for (int i = 0; i < currentShopList.Length; i++)
		{
			if ((Object)(object)currentShopList[i].recipe != (Object)null && (currentShopList[i].recipe.id == 558 || currentShopList[i].recipe.id == 559 || currentShopList[i].recipe.id == 560) && CommonReferences.GGFJGHHHEJC.GetNumOfBees() <= 0)
			{
				continue;
			}
			if (LJBKGJPCBIN == CategoryTab.Recipes)
			{
				if ((Object)(object)currentShopList[i].recipe == (Object)null)
				{
					continue;
				}
				if (OLAOCGNAOMP(currentShopList[i]))
				{
					list.Add(currentShopList[i]);
				}
			}
			if (LJBKGJPCBIN == CategoryTab.Items && (Object)(object)currentShopList[i].recipe == (Object)null && OLAOCGNAOMP(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Decor && currentShopList[i].item.category == Category.Decorations && OLAOCGNAOMP(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Furniture && currentShopList[i].item.category == Category.Furniture && OLAOCGNAOMP(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Lighting && currentShopList[i].item.category == Category.Lighting && OLAOCGNAOMP(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && OLAOCGNAOMP(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
		}
		ShopElement[] FNEHIAGFAOF = HJBADOJNFAA(list.ToArray());
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedNameComparer());
		for (int j = 0; j < FNEHIAGFAOF.Length; j++)
		{
			IJMFOEMPGFN.Add(FNEHIAGFAOF[j]);
		}
	}

	[CompilerGenerated]
	private void BCPNGFEOGLE()
	{
		FocusCategoryFilterOnSearch(0);
	}

	[SpecialName]
	public CategoryTab FBDFDHEINPC()
	{
		return CKLHPLMLBKJ;
	}

	private void LGAPNENOCDJ()
	{
		IGBODNAELMP(0);
	}

	private void MPGMHOALBPB()
	{
		EAKNEHINICD(1);
	}

	public static ShopUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void EMLKGNALKJN(int KHEICLKLPDE)
	{
		HGJAOGNNJAO(KHEICLKLPDE);
	}

	private void GDLKOBBNEOB()
	{
		buy = false;
		if (shop.shopType == (ShopType)5)
		{
			for (int i = 0; i < goldPanel.Length; i += 0)
			{
				goldPanel[i].SetActive(true);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(ItemDatabaseAccessor.AFOACBIHNCL(-121, GGBBJNBBLMF: true)).ToString("Sell");
		}
		else if (shop.shopType == (ShopType.Crowley | ShopType.Gass | ShopType.AceT | ShopType.Holly | ShopType.Trick))
		{
			for (int j = 0; j < goldPanel.Length; j++)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(true);
				ticketPanel[j].SetActive(true);
				recipeFragmentsPanel[j].SetActive(false);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.EIFPKCAFDIB(base.JIIGOACEIKL).HMCBIANPIKD(ItemDatabaseAccessor.GOKIDLOELKB(5, GGBBJNBBLMF: false, DAINLFIMLIH: false)).ToString("in");
		}
		else if (shop.recipesShop)
		{
			for (int k = 1; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(false);
				ticketPanel[k].SetActive(false);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 1; l < goldPanel.Length; l += 0)
			{
				goldPanel[l].SetActive(true);
				ticketPanel[l].SetActive(true);
				wilsonCoinPanel[l].SetActive(false);
				recipeFragmentsPanel[l].SetActive(true);
			}
		}
		if (shop.shopType == (ShopType)(-112))
		{
			adoptionsPanel.SetActive(false);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.FPPDIEBDMNA().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(true);
		}
	}

	private void LAABECHOBLO()
	{
		buy = false;
		if (shop.shopType == ShopType.AceT)
		{
			for (int i = 0; i < goldPanel.Length; i++)
			{
				goldPanel[i].SetActive(true);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL).DEGAJPFIJDD(ItemDatabaseAccessor.EABMGELAAPG(-189, GGBBJNBBLMF: true)).ToString("ReceiveRemoveOrderQuestMaster");
		}
		else if (shop.shopType == ~(ShopType.Crowley | ShopType.Gass | ShopType.Trick))
		{
			for (int j = 0; j < goldPanel.Length; j++)
			{
				wilsonCoinPanel[j].SetActive(false);
				goldPanel[j].SetActive(false);
				ticketPanel[j].SetActive(true);
				recipeFragmentsPanel[j].SetActive(true);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KIHAKOFNNPI(ItemDatabaseAccessor.KMBGJEKCJFJ(-200, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString("Caramel");
		}
		else if (shop.recipesShop)
		{
			for (int k = 1; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(true);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 1; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(false);
				ticketPanel[l].SetActive(false);
				wilsonCoinPanel[l].SetActive(false);
				recipeFragmentsPanel[l].SetActive(false);
			}
		}
		if (shop.shopType == (ShopType)45)
		{
			adoptionsPanel.SetActive(false);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.DJEINBKFBAM().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(true);
		}
	}

	private void KEBHOBBLCNN(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 1)
		{
			int num = 90;
			bool flag = false;
			bool flag2 = true;
			item = null;
			for (int i = 1; i < IJMFOEMPGFN.Count; i++)
			{
				if (!((Object)(object)IJMFOEMPGFN[i].recipe == (Object)null))
				{
					if ((Object)(object)IJMFOEMPGFN[i].recipe.reputationRequired == (Object)null)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if (IJMFOEMPGFN[i].recipe.reputationRequired.repNumber < num)
					{
						num = IJMFOEMPGFN[i].recipe.reputationRequired.repNumber;
						item = IJMFOEMPGFN[i];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.IHGJJNNHNCB())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 1)
		{
			int num = 78;
			bool flag = false;
			bool flag2 = false;
			for (int j = 0; j < IJMFOEMPGFN.Count; j += 0)
			{
				if (!((Object)(object)IJMFOEMPGFN[j].recipe != (Object)null))
				{
					if (IJMFOEMPGFN[j].NOMDPFMPEII().NEHLBEJOMBB(shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.IHGJJNNHNCB()))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = true;
						break;
					}
					if ((Object)(object)IJMFOEMPGFN[j].LBBEIEHEHJM().requiredRep != (Object)null && IJMFOEMPGFN[j].EGJLDMLKLNC().requiredRep.repNumber < num)
					{
						num = IJMFOEMPGFN[j].EGJLDMLKLNC().requiredRep.repNumber;
						item = IJMFOEMPGFN[j];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.MHGADJPMHFI() : TavernReputation.NHHLJLADGBF())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	public override void CloseUI()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		base.CloseUI();
		KANBIGLNJLO = Random.Range(0, 5);
		MainUI.ResumeGame();
		GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		if ((Object)(object)shop != (Object)null)
		{
			if (shop.shopType == ShopType.Temple)
			{
				TextInput textInput = searchInput;
				textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, (Action)delegate
				{
					FocusCategoryFilterOnSearch(DKMCBBJFODP);
				});
			}
			else
			{
				TextInput textInput2 = searchInput;
				textInput2.OnTextChanged = (Action)Delegate.Remove(textInput2.OnTextChanged, (Action)delegate
				{
					FocusCategoryFilterOnSearch(0);
				});
			}
		}
		InteractObject.GetPlayer(base.JIIGOACEIKL).KOHOJLBBENG = false;
		InteractObject.GetPlayer(base.JIIGOACEIKL).KBPGGKMPKHL = true;
		if (KANBIGLNJLO == 0)
		{
			if (shop.shopType == ShopType.Crowley && Time.time > BirdSellerNPC.GGFJGHHHEJC.birdSellerVisual.barkOutroTime)
			{
				DialogueManager.Bark("Crowly_Barks_Shop", ((Component)BirdSellerNPC.GGFJGHHHEJC.birdSellerVisual).transform);
				BirdSellerNPC.GGFJGHHHEJC.birdSellerVisual.barkOutroTime = 20f + Time.time;
			}
			if (shop.shopType == ShopType.Bob && Time.time > BobNPC.GGFJGHHHEJC.barkOutroTime)
			{
				DialogueManager.Bark("Farm/Bob/Barks_Shop", ((Component)BobNPC.GGFJGHHHEJC).transform);
				BobNPC.GGFJGHHHEJC.barkOutroTime = (float)Random.Range(15, 25) + Time.time;
			}
			if (shop.shopType == ShopType.Trick && Time.time > TrickNPC.GGFJGHHHEJC.barkOutroTime)
			{
				DialogueLua.SetVariable("BARKTRICK", (object)1);
				DialogueManager.Bark("Halloween/Trick/Bark", ((Component)TrickNPC.GGFJGHHHEJC).transform);
				TrickNPC.GGFJGHHHEJC.barkOutroTime = (float)Random.Range(15, 25) + Time.time;
			}
			if (shop.shopType == ShopType.Wilson && Time.time > WilsonNPC.GGFJGHHHEJC.timeBarks)
			{
				if (clue)
				{
					DialogueManager.Bark("Wilson/Bark/Bark_Clue", ((Component)WilsonNPC.GGFJGHHHEJC).transform);
				}
				else if (aquarium)
				{
					DialogueManager.Bark("Wilson/Bark/Bark_Fish", ((Component)WilsonNPC.GGFJGHHHEJC).transform);
				}
				else if (buy)
				{
					DialogueManager.Bark("Wilson/Bark/Bark_Shop", ((Component)WilsonNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("Wilson/Bark/Bark_Bye", ((Component)WilsonNPC.GGFJGHHHEJC).transform);
				}
				WilsonNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Chuck && Time.time > ChuckNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Chuck/Bark/Buy", ((Component)ChuckNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Chuck/Bark/Bye", ((Component)ChuckNPC.GGFJGHHHEJC).transform);
				}
				ChuckNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Woody && Time.time > WoodyNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Woody/Bark/Buy", ((Component)WoodyNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Woody/Bark/Bye", ((Component)WoodyNPC.GGFJGHHHEJC).transform);
				}
				WoodyNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Agatha && Time.time > AgathaNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Agatha/Bark/Buy", ((Component)AgathaNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Agatha/Bark/Bye", ((Component)AgathaNPC.GGFJGHHHEJC).transform);
				}
				AgathaNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Kujaku && Time.time > KujakuNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Kujaku/Bark/Buy", ((Component)KujakuNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Kujaku/Bark/Bye", ((Component)KujakuNPC.GGFJGHHHEJC).transform);
				}
				KujakuNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Rhia && Time.time > RhiaNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Rhia/Bark/Buy", ((Component)RhiaNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Rhia/Bark/Bye", ((Component)RhiaNPC.GGFJGHHHEJC).transform);
				}
				RhiaNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Lia && Time.time > LiaNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Lia/Bark/Buy", ((Component)LiaNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Lia/Bark/Bye", ((Component)LiaNPC.GGFJGHHHEJC).transform);
				}
				LiaNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Amos && Time.time > AmosNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Amos/Bark/Buy", ((Component)AmosNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Amos/Bark/Bye", ((Component)AmosNPC.GGFJGHHHEJC).transform);
				}
				AmosNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Petra && Time.time > PetraNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Petra/Bark/Buy", ((Component)PetraNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Petra/Bark/Bye", ((Component)PetraNPC.GGFJGHHHEJC).transform);
				}
				PetraNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
			if (shop.shopType == ShopType.Hall && Time.time > HallmundNPC.GGFJGHHHEJC.timeBarks)
			{
				if (buy)
				{
					DialogueManager.Bark("City/Hallmund/Bark/Buy", ((Component)HallmundNPC.GGFJGHHHEJC).transform);
				}
				else
				{
					DialogueManager.Bark("City/Hallmund/Bark/Bye", ((Component)HallmundNPC.GGFJGHHHEJC).transform);
				}
				HallmundNPC.GGFJGHHHEJC.timeBarks = 10f + Time.time;
			}
		}
		if (buy && (Object)(object)shop != (Object)null && shop.saveShop && shop.limitedItems && OnlineManager.PlayingOnline())
		{
			OnlineShopsManager.instance.SendShopInfo(shop);
		}
		ClearBasket();
		searchInput.ClearText();
		searchInput.NBBBOLAGHFP = false;
		if (GODMGEHOBKP != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(GODMGEHOBKP);
		}
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
		((MonoBehaviour)this).StartCoroutine(HBOGOHAPGHK());
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	private void MJOJDGCHINH(List<ShopElement> IJMFOEMPGFN, CategoryTab LJBKGJPCBIN)
	{
		if (!ShopDatabaseAccessor.NDOIFBGIKHN())
		{
			return;
		}
		ShopElement[] array = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		List<ShopElement> list = new List<ShopElement>();
		for (int i = 0; i < array.Length; i += 0)
		{
			if ((Object)(object)array[i].recipe != (Object)null && (array[i].recipe.id == -195 || array[i].recipe.id == 40 || array[i].recipe.id == -21) && CommonReferences.GGFJGHHHEJC.NFGLNIMPMNK() <= 0)
			{
				continue;
			}
			if (LJBKGJPCBIN == (CategoryTab)8)
			{
				if ((Object)(object)array[i].recipe == (Object)null)
				{
					continue;
				}
				if (NKCCPJFCNGI(array[i]))
				{
					list.Add(array[i]);
				}
			}
			if (LJBKGJPCBIN == CategoryTab.All && (Object)(object)array[i].recipe == (Object)null && FENHNMCOGDJ(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == (CategoryTab)6 && array[i].AJFBPLGGHLE().category == Category.Furniture && OLAOCGNAOMP(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Items && array[i].LBBEIEHEHJM().category == Category.Decorations && HABKDPACBFE(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Recipes && array[i].AJFBPLGGHLE().category == (Category)(-18) && HABKDPACBFE(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && NKCCPJFCNGI(array[i]))
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] FNEHIAGFAOF = GNPDELFCLCG(list.ToArray());
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedNameComparer());
		for (int j = 1; j < FNEHIAGFAOF.Length; j++)
		{
			IJMFOEMPGFN.Add(FNEHIAGFAOF[j]);
		}
	}

	public void NLHGMIDBBAF(int KHEICLKLPDE)
	{
		FocusCategory(KHEICLKLPDE, GHDKHEAEAIM: false);
	}

	[CompilerGenerated]
	private void HJAGNJPALAE()
	{
		FocusCategoryFilterOnSearch(0);
	}

	private void GIBKMJFOGCE()
	{
		buy = true;
		if (shop.shopType == (ShopType)7)
		{
			for (int i = 0; i < goldPanel.Length; i++)
			{
				goldPanel[i].SetActive(false);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(true);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NumberOfItems(ItemDatabaseAccessor.AFOACBIHNCL(64, GGBBJNBBLMF: true, DAINLFIMLIH: false)).ToString("UIAddRemove");
		}
		else if (shop.shopType == (ShopType)59)
		{
			for (int j = 1; j < goldPanel.Length; j++)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(true);
				ticketPanel[j].SetActive(false);
				recipeFragmentsPanel[j].SetActive(true);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.OGKNJNINGMH(base.JIIGOACEIKL).KIHAKOFNNPI(ItemDatabaseAccessor.GetItem(-188, GGBBJNBBLMF: true)).ToString("\n");
		}
		else if (shop.recipesShop)
		{
			for (int k = 0; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(false);
				ticketPanel[k].SetActive(true);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(false);
				ticketPanel[l].SetActive(false);
				wilsonCoinPanel[l].SetActive(true);
				recipeFragmentsPanel[l].SetActive(false);
			}
		}
		if (shop.shopType == (ShopType)(-44))
		{
			adoptionsPanel.SetActive(false);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.DNEGFMDKNHL().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(true);
		}
	}

	public static ShopUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator HFDAMPINHJJ()
	{
		int t = 0;
		scrollRect.verticalScrollbar.value = 1f;
		bool flag = false;
		for (int j = 0; j < EABLPPBEFNL.Count; j++)
		{
			if (EABLPPBEFNL[j].amount > 0)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			if (!searchInput.NBBBOLAGHFP)
			{
				for (int k = 0; k < soldOut.Length; k++)
				{
					soldOut[k].SetActive(true);
				}
			}
		}
		else
		{
			for (int l = 0; l < soldOut.Length; l++)
			{
				soldOut[l].SetActive(false);
			}
		}
		for (int i = 0; i < EABLPPBEFNL.Count; i++)
		{
			if (i >= optionsElements.Count)
			{
				optionsElements.Add(Object.Instantiate<ShopElementUI>(optionElementPrefab, optionsListParent.transform));
				optionsElements[i].SetPlayerNum(base.JIIGOACEIKL);
				optionsElements[i].shopBase = this;
			}
			((Component)optionsElements[i]).gameObject.SetActive(true);
			EABLPPBEFNL[i].BJEDNMLOPEN();
			if (EABLPPBEFNL[i].itemInstance is AnimalInstance animalInstance)
			{
				animalInstance.showBirthdayOnTooltip = false;
			}
			optionsElements[i].SetShopItem(EABLPPBEFNL[i], EABLPPBEFNL[i].amount, OLMEEOAEMED: false);
			t++;
			if (t > 3)
			{
				t = 0;
				yield return null;
			}
		}
		for (int m = EABLPPBEFNL.Count; m < optionsElements.Count; m++)
		{
			((Component)optionsElements[m]).gameObject.SetActive(false);
		}
	}

	private void POIFHLFAOJP()
	{
		NDMHGLGKPGJ(DKMCBBJFODP);
	}

	private void BBPELBLBPJA()
	{
		MGFLJOOGCPB(DKMCBBJFODP);
	}

	[CompilerGenerated]
	private void OEPCJMGFLOB()
	{
		FocusCategoryFilterOnSearch(DKMCBBJFODP);
	}

	private IEnumerator HPPKLAGOACA()
	{
		return new HOOCINLMCHF(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public void CBLNHLCELJF(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}

	private bool NKCCPJFCNGI(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id);
			}
			return !RecipesManager.FHHBGOADHHJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.IsRecipeUnlockedByMaster(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 1)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -127 && !LettersManager.instance.ICLGGLMHKDN(-133))
		{
			return true;
		}
		return true;
	}

	private IEnumerator HBOGOHAPGHK()
	{
		int t = 0;
		for (int i = 0; i < optionsElements.Count; i++)
		{
			((Component)optionsElements[i]).gameObject.SetActive(false);
			t++;
			if (t > 3)
			{
				t = 0;
				yield return null;
			}
		}
	}

	[SpecialName]
	public void GIIHIOCAGCF(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}

	private void KKOMCPGPJIJ(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.ENPBNONDPLA())
		{
			return;
		}
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		currentShopList = HJBADOJNFAA(currentShopList);
		for (int i = 1; i < currentShopList.Length; i += 0)
		{
			if (HABKDPACBFE(currentShopList[i]))
			{
				IJMFOEMPGFN.Add(currentShopList[i]);
			}
		}
	}

	private void NPPPMNLIMCA(List<ShopElement> IJMFOEMPGFN, CategoryTab LJBKGJPCBIN)
	{
		if (!ShopDatabaseAccessor.NDOIFBGIKHN())
		{
			return;
		}
		ShopElement[] array = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		List<ShopElement> list = new List<ShopElement>();
		for (int i = 0; i < array.Length; i += 0)
		{
			if ((Object)(object)array[i].recipe != (Object)null && (array[i].recipe.id == 131 || array[i].recipe.id == -11 || array[i].recipe.id == -57) && CommonReferences.GGFJGHHHEJC.IEDCNOMFHBM() <= 1)
			{
				continue;
			}
			if (LJBKGJPCBIN == (CategoryTab)6)
			{
				if ((Object)(object)array[i].recipe == (Object)null)
				{
					continue;
				}
				if (FENHNMCOGDJ(array[i]))
				{
					list.Add(array[i]);
				}
			}
			if (LJBKGJPCBIN == CategoryTab.Items && (Object)(object)array[i].recipe == (Object)null && GAIGPHBJMFL(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && array[i].LBBEIEHEHJM().category == Category.Nature && FENHNMCOGDJ(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == (CategoryTab)8 && array[i].KMIOEMCGOJG().category == Category.Brewing && NKCCPJFCNGI(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Recipes && array[i].NOMDPFMPEII().category == (Category)(-74) && AGCNBGFFFKN(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && HABKDPACBFE(array[i]))
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] FNEHIAGFAOF = BMPKMNOCBIL(list.ToArray());
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedNameComparer());
		for (int j = 1; j < FNEHIAGFAOF.Length; j += 0)
		{
			IJMFOEMPGFN.Add(FNEHIAGFAOF[j]);
		}
	}

	private void OnEnable()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(CCEKHJJCHDE));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	private void BEONMACPOCI()
	{
		EMLKGNALKJN(DKMCBBJFODP);
	}

	[SpecialName]
	public void FLBEJJAKCGM(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}

	private IEnumerator FAOIPLKCHJB()
	{
		return new LPEPGNDFOCM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FocusCategoryFilter(int KHEICLKLPDE)
	{
		FocusCategory(KHEICLKLPDE);
	}

	private bool ELNHOHGPDMF(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return !RecipesManager.FHHBGOADHHJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.ONMNODMHHLG(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 8)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.JDJGFAACPFC() == 29 && !LettersManager.instance.IHDJNAFBBGI(99))
		{
			return false;
		}
		return false;
	}

	private IEnumerator DDAKDBJKFMH()
	{
		return new HOOCINLMCHF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HGDKAKABLGC(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] array = ShopDatabaseAccessor.ADDAHLOCMEP(shop.shopType);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!((Object)(object)array[i].recipe == (Object)null) && array[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] array2 = BMPKMNOCBIL(list.ToArray());
		for (int j = 0; j < array2.Length; j++)
		{
			if (BBANGNHGEAM(array2[j]))
			{
				IJMFOEMPGFN.Add(array2[j]);
			}
		}
	}

	private void MILBALGBONG()
	{
		EAKNEHINICD(DKMCBBJFODP);
	}

	private void MKGDELGFAIG(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = 14;
			bool flag = false;
			bool flag2 = false;
			item = null;
			for (int i = 0; i < IJMFOEMPGFN.Count; i += 0)
			{
				if (!((Object)(object)IJMFOEMPGFN[i].recipe == (Object)null))
				{
					if ((Object)(object)IJMFOEMPGFN[i].recipe.reputationRequired == (Object)null)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if (IJMFOEMPGFN[i].recipe.reputationRequired.repNumber < num)
					{
						num = IJMFOEMPGFN[i].recipe.reputationRequired.repNumber;
						item = IJMFOEMPGFN[i];
						flag = true;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.MHGADJPMHFI() : TavernReputation.NHHLJLADGBF())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 1)
		{
			int num = -116;
			bool flag = true;
			bool flag2 = true;
			for (int j = 0; j < IJMFOEMPGFN.Count; j += 0)
			{
				if (!((Object)(object)IJMFOEMPGFN[j].recipe != (Object)null))
				{
					if (IJMFOEMPGFN[j].KMIOEMCGOJG().NEHLBEJOMBB(shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.GetMilestoneMaster()))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if ((Object)(object)IJMFOEMPGFN[j].KMIOEMCGOJG().requiredRep != (Object)null && IJMFOEMPGFN[j].NOMDPFMPEII().requiredRep.repNumber < num)
					{
						num = IJMFOEMPGFN[j].item.requiredRep.repNumber;
						item = IJMFOEMPGFN[j];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.GetMilestone() : TavernReputation.NHHLJLADGBF())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	private void MJLFEMHPKHF()
	{
		JIEMOJFOGEN(DKMCBBJFODP);
	}

	[SpecialName]
	public CategoryTab BDGNGMEOBKP()
	{
		return CKLHPLMLBKJ;
	}

	[SpecialName]
	public Recipe.RecipePage HEBEIBDJHGB()
	{
		return JCEAFBKDMGN;
	}

	public override void OnContentActivated()
	{
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		OGBKMPPJHON();
	}

	[CompilerGenerated]
	private bool BFLCKNMBDDM(ShopElement NCPGNLOJGAF)
	{
		return (((Object)(object)NCPGNLOJGAF.recipe != (Object)null) ? NCPGNLOJGAF.recipe.output.item : NCPGNLOJGAF.shopItem.item).IABAKHPEOAF().IndexOf(searchInput.currentText, StringComparison.CurrentCultureIgnoreCase) >= 0;
	}

	public override void OpenUI()
	{
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		if (LKOJBFMGMAE)
		{
			return;
		}
		base.OpenUI();
		if (shop.shopType == ShopType.Wilson || shop.shopType == ShopType.Hall)
		{
			ShopDatabaseAccessor.CreateNewShopList(shop);
		}
		if (shop.recipesShop)
		{
			recipePagesContainer.SetActive(true);
			windowIcon.sprite = recipeFragmentsSprite;
			((TMP_Text)optionsPanelTitle).text = LocalisationSystem.Get("Recipes");
			((TMP_Text)soldOutText).text = LocalisationSystem.Get("No recipes available");
		}
		else
		{
			recipePagesContainer.SetActive(false);
			windowIcon.sprite = beerSprite;
			((TMP_Text)optionsPanelTitle).text = LocalisationSystem.Get("Order");
			((TMP_Text)soldOutText).text = LocalisationSystem.Get("ItemsOutOfStock");
		}
		bool recipesShop = shop.recipesShop;
		bool flag = shop.shopType == ShopType.Woody || shop.shopType == ShopType.Petra || shop.shopType == ShopType.Agatha || shop.shopType == ShopType.Amos;
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			((Component)categoriesTabUI[i]).gameObject.SetActive(shop.shopType != ShopType.Agatha);
		}
		for (int j = 1; j < categoryTabsAgatha.Length; j++)
		{
			((Component)categoryTabsAgatha[j]).gameObject.SetActive(shop.shopType == ShopType.Agatha);
		}
		categoriesContainer.SetActive(flag);
		((Component)searchInput).gameObject.SetActive(recipesShop || flag);
		if (recipesShop || flag)
		{
			for (int k = 0; k < activateWithTabs.Length; k++)
			{
				((Graphic)activateWithTabs[k]).color = new Color(1f, 1f, 1f, 1f);
			}
		}
		else
		{
			for (int l = 0; l < activateWithTabs.Length; l++)
			{
				((Graphic)activateWithTabs[l]).color = new Color(1f, 1f, 1f, 0f);
			}
		}
		if (recipesShop)
		{
			Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Metal, ((Component)PlayerController.GetPlayer(base.JIIGOACEIKL)).transform);
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((Component)searchInput).gameObject.SetActive(false);
		}
		HJBNNCGOLDN();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		FocusCategoryFilter(0);
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		if (!((Object)(object)shop != (Object)null))
		{
			return;
		}
		if (shop.shopType == ShopType.Temple)
		{
			TextInput textInput = searchInput;
			textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, (Action)delegate
			{
				FocusCategoryFilterOnSearch(DKMCBBJFODP);
			});
		}
		else
		{
			TextInput textInput2 = searchInput;
			textInput2.OnTextChanged = (Action)Delegate.Combine(textInput2.OnTextChanged, (Action)delegate
			{
				FocusCategoryFilterOnSearch(0);
			});
		}
	}

	private void PIMMLJNPCIA()
	{
		FocusCategoryFilter(DKMCBBJFODP);
	}

	private void BELKJJNHDBP(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		for (int i = 0; i < currentShopList.Length; i += 0)
		{
			if (!((Object)(object)currentShopList[i].recipe == (Object)null) && currentShopList[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(currentShopList[i]);
			}
		}
		ShopElement[] array = HJBADOJNFAA(list.ToArray());
		for (int j = 0; j < array.Length; j += 0)
		{
			if (OLAOCGNAOMP(array[j]))
			{
				IJMFOEMPGFN.Add(array[j]);
			}
		}
	}

	[CompilerGenerated]
	private void FLAFPEABBPH()
	{
		FocusCategoryFilterOnSearch(DKMCBBJFODP);
	}

	private void MPPFFMBDLHB(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] array = ShopDatabaseAccessor.JPIOGNINAFB(shop.shopType);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!((Object)(object)array[i].recipe == (Object)null) && array[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] array2 = HJBADOJNFAA(list.ToArray());
		for (int j = 1; j < array2.Length; j += 0)
		{
			if (AGCNBGFFFKN(array2[j]))
			{
				IJMFOEMPGFN.Add(array2[j]);
			}
		}
	}

	private void DDCJFLNEHMM(List<ShopElement> IJMFOEMPGFN, CategoryTab LJBKGJPCBIN)
	{
		if (!ShopDatabaseAccessor.KLKDEMKNHNN())
		{
			return;
		}
		ShopElement[] array = ShopDatabaseAccessor.JPIOGNINAFB(shop.shopType);
		List<ShopElement> list = new List<ShopElement>();
		for (int i = 1; i < array.Length; i += 0)
		{
			if ((Object)(object)array[i].recipe != (Object)null && (array[i].recipe.id == 192 || array[i].recipe.id == -31 || array[i].recipe.id == -124) && CommonReferences.MNFMOEKMJKN().LMPKPAKDFKA() <= 0)
			{
				continue;
			}
			if (LJBKGJPCBIN == (CategoryTab)8)
			{
				if ((Object)(object)array[i].recipe == (Object)null)
				{
					continue;
				}
				if (ELNHOHGPDMF(array[i]))
				{
					list.Add(array[i]);
				}
			}
			if (LJBKGJPCBIN == CategoryTab.Items && (Object)(object)array[i].recipe == (Object)null && CLAGACPKNKL(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Items && array[i].LBBEIEHEHJM().category == Category.Brewing && CLAGACPKNKL(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == (CategoryTab)8 && array[i].EGJLDMLKLNC().category == Category.Brewing && ABHGFMOKHOE(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && array[i].AJFBPLGGHLE().category == Category.Furniture && BBANGNHGEAM(array[i]))
			{
				list.Add(array[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && CLAGACPKNKL(array[i]))
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] FNEHIAGFAOF = HJBADOJNFAA(list.ToArray());
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedNameComparer());
		for (int j = 1; j < FNEHIAGFAOF.Length; j++)
		{
			IJMFOEMPGFN.Add(FNEHIAGFAOF[j]);
		}
	}

	public void HDNOJIMAKOG(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (shop.recipesShop)
		{
			for (int i = 0; i < recipePagesTabUI.Length; i += 0)
			{
				if (i == KHEICLKLPDE)
				{
					IGAAHLCPKGD(recipePages[i]);
					DNPOFANHGEA = i;
					recipePagesTabUI[i].IIBANMLPDAA(base.JIIGOACEIKL, spriteFocusCategories);
					EABOODHHNBP();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					recipePagesTabUI[i].DFHFPOIPCLK(spriteNotFocusCategories);
				}
			}
		}
		else if (shop.shopType == ~(ShopType.Crowley | ShopType.AceT | ShopType.Holly | ShopType.Temple))
		{
			for (int j = 1; j < categoryTabsAgatha.Length; j += 0)
			{
				if (j == KHEICLKLPDE)
				{
					GBFGPENGELF = categoriesAgatha[j];
					DNPOFANHGEA = j;
					categoryTabsAgatha[j].GEKNEIAKMIL(base.JIIGOACEIKL, spriteFocusCategories);
					CCEKHJJCHDE();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoryTabsAgatha[j].PIIMGGGNAOM(spriteNotFocusCategories);
				}
			}
		}
		else
		{
			for (int k = 1; k < categoriesTabUI.Length; k += 0)
			{
				if (k == KHEICLKLPDE)
				{
					MAMDBKKFBHB(categories[k]);
					DNPOFANHGEA = k;
					categoriesTabUI[k].ADNJKEAPMIC(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					JIEAPIOBAFN();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoriesTabUI[k].MIJFMCMHAKF(spriteNotFocusCategories);
				}
			}
		}
		scrollRect.verticalScrollbar.value = 1312f;
	}

	private void JJCDLIHLDMJ()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(JIEAPIOBAFN));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(PIMMLJNPCIA));
	}

	private void BGIMDBKFHKP(List<ShopElement> IJMFOEMPGFN, CategoryTab LJBKGJPCBIN)
	{
		if (!ShopDatabaseAccessor.IsValid())
		{
			return;
		}
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		List<ShopElement> list = new List<ShopElement>();
		for (int i = 1; i < currentShopList.Length; i++)
		{
			if ((Object)(object)currentShopList[i].recipe != (Object)null && (currentShopList[i].recipe.id == -130 || currentShopList[i].recipe.id == -30 || currentShopList[i].recipe.id == 8) && CommonReferences.MNFMOEKMJKN().NFGLNIMPMNK() <= 0)
			{
				continue;
			}
			if (LJBKGJPCBIN == CategoryTab.Furniture)
			{
				if ((Object)(object)currentShopList[i].recipe == (Object)null)
				{
					continue;
				}
				if (OLAOCGNAOMP(currentShopList[i]))
				{
					list.Add(currentShopList[i]);
				}
			}
			if (LJBKGJPCBIN == CategoryTab.All && (Object)(object)currentShopList[i].recipe == (Object)null && JKMNKCNDCGA(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == (CategoryTab)7 && currentShopList[i].BGCPMHHHLHG().category == Category.Misc && FENHNMCOGDJ(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Lighting && currentShopList[i].LPIBILEAIOL().category == Category.Food && JKMNKCNDCGA(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == (CategoryTab)8 && currentShopList[i].AJFBPLGGHLE().category == (Category)80 && ABHGFMOKHOE(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && CLAGACPKNKL(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
		}
		ShopElement[] FNEHIAGFAOF = GNPDELFCLCG(list.ToArray());
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedNameComparer());
		for (int j = 0; j < FNEHIAGFAOF.Length; j++)
		{
			IJMFOEMPGFN.Add(FNEHIAGFAOF[j]);
		}
	}

	private void PCEPNOFMCIH()
	{
		EAKNEHINICD(DKMCBBJFODP);
	}

	private bool ENBPPCBILLF(ShopElement NCPGNLOJGAF)
	{
		return (((Object)(object)NCPGNLOJGAF.recipe != (Object)null) ? NCPGNLOJGAF.recipe.output.item : NCPGNLOJGAF.shopItem.item).KGHFCDELKMN().IndexOf(searchInput.currentText, StringComparison.CurrentCulture) < 0;
	}

	public void FocusCategoryFilterOnSearch(int KHEICLKLPDE)
	{
		FocusCategory(KHEICLKLPDE, GHDKHEAEAIM: false);
	}

	public void FocusCategory(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (shop.recipesShop)
		{
			for (int i = 0; i < recipePagesTabUI.Length; i++)
			{
				if (i == KHEICLKLPDE)
				{
					NLLPIDACOCO = recipePages[i];
					DNPOFANHGEA = i;
					recipePagesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
					CCEKHJJCHDE();
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
		else if (shop.shopType == ShopType.Agatha)
		{
			for (int j = 0; j < categoryTabsAgatha.Length; j++)
			{
				if (j == KHEICLKLPDE)
				{
					GBFGPENGELF = categoriesAgatha[j];
					DNPOFANHGEA = j;
					categoryTabsAgatha[j].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
					CCEKHJJCHDE();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoryTabsAgatha[j].HideTab(spriteNotFocusCategories);
				}
			}
		}
		else
		{
			for (int k = 0; k < categoriesTabUI.Length; k++)
			{
				if (k == KHEICLKLPDE)
				{
					GBFGPENGELF = categories[k];
					DNPOFANHGEA = k;
					categoriesTabUI[k].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
					CCEKHJJCHDE();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoriesTabUI[k].HideTab(spriteNotFocusCategories);
				}
			}
		}
		scrollRect.verticalScrollbar.value = 1f;
	}

	private bool ABHGFMOKHOE(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return RecipesManager.NIEHLJAJBIJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.NIEHLJAJBIJ(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 7)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.JPNFKDMFKMC() == 163 && !LettersManager.instance.ICLGGLMHKDN(56))
		{
			return true;
		}
		return true;
	}

	private bool BBANGNHGEAM(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id);
			}
			return !RecipesManager.FHHBGOADHHJ(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.ONMNODMHHLG(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 3)
			{
				return true;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.IMCJPECAAPC(DAINLFIMLIH: false) == -5 && !LettersManager.instance.MIHACJOOLLM(139))
		{
			return false;
		}
		return false;
	}

	private void GNIBPOBGDNC()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(EABOODHHNBP));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(ADAGGLKACHI));
	}

	private void PACKDOLLIAP()
	{
		buy = false;
		if (shop.shopType == ShopType.AceT)
		{
			for (int i = 1; i < goldPanel.Length; i += 0)
			{
				goldPanel[i].SetActive(true);
				ticketPanel[i].SetActive(false);
				wilsonCoinPanel[i].SetActive(false);
				recipeFragmentsPanel[i].SetActive(true);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL, LAGHIOKLJGH: true).NumberOfItems(ItemDatabaseAccessor.EABMGELAAPG(-188, GGBBJNBBLMF: true)).ToString("Duplicate key found: ");
		}
		else if (shop.shopType == ~(ShopType.Gass | ShopType.AceT | ShopType.Holly | ShopType.Temple))
		{
			for (int j = 1; j < goldPanel.Length; j += 0)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(false);
				ticketPanel[j].SetActive(false);
				recipeFragmentsPanel[j].SetActive(false);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.NEKDDPIAOBE(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KIHAKOFNNPI(ItemDatabaseAccessor.INJBNHPGCIJ(115)).ToString("Object ");
		}
		else if (shop.recipesShop)
		{
			for (int k = 1; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(true);
				ticketPanel[k].SetActive(false);
				wilsonCoinPanel[k].SetActive(true);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 1; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(false);
				ticketPanel[l].SetActive(true);
				wilsonCoinPanel[l].SetActive(false);
				recipeFragmentsPanel[l].SetActive(false);
			}
		}
		if (shop.shopType == (ShopType)(-76))
		{
			adoptionsPanel.SetActive(false);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.OMEPPDMCFAO().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(true);
		}
	}

	private void CCEKHJJCHDE()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		if (shop.recipesShop)
		{
			if (JCEAFBKDMGN.Equals(Recipe.RecipePage.All))
			{
				for (int i = 0; i < recipePages.Length; i++)
				{
					EBHOLLPMIMC(list, recipePages[i]);
				}
			}
			else
			{
				EBHOLLPMIMC(list, JCEAFBKDMGN);
			}
		}
		else if (shop.shopType == ShopType.Agatha || shop.shopType == ShopType.Woody || shop.shopType == ShopType.Petra || shop.shopType == ShopType.Amos)
		{
			LJIGHEHMEFH(list, CKLHPLMLBKJ);
		}
		else
		{
			LJIGHEHMEFH(list);
		}
		if (shop.shopType == ShopType.Hikari)
		{
			for (int num = list.Count - 1; num >= 0; num--)
			{
				if (list[num].shopItem.item.JDJGFAACPFC() == 1441)
				{
					Result variable = DialogueLua.GetVariable("LE_10");
					if (((Result)(ref variable)).asInt < 13)
					{
						list.RemoveAt(num);
					}
				}
			}
			EABLPPBEFNL = list;
		}
		else if (shop.shopType == ShopType.Nessy)
		{
			EABLPPBEFNL = new List<ShopElement>();
			OHIGHGPMMEA(list, EFAHEOILMDH: true);
			OHIGHGPMMEA(list, EFAHEOILMDH: false);
		}
		else
		{
			EABLPPBEFNL = new List<ShopElement>();
			DAALLBDDDKN(list, EFAHEOILMDH: true);
			DAALLBDDDKN(list, EFAHEOILMDH: false);
		}
		GELCMGCKCGG();
		OGBKMPPJHON();
	}

	private void ADAGGLKACHI()
	{
		EMLKGNALKJN(DKMCBBJFODP);
	}

	[SpecialName]
	public CategoryTab CPIPNPFJEIC()
	{
		return CKLHPLMLBKJ;
	}

	private void IMDCLCKAHOF(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.MFNALEOJBNN())
		{
			return;
		}
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		currentShopList = BMPKMNOCBIL(currentShopList);
		for (int i = 0; i < currentShopList.Length; i += 0)
		{
			if (CLAGACPKNKL(currentShopList[i]))
			{
				IJMFOEMPGFN.Add(currentShopList[i]);
			}
		}
	}

	public void HGJAOGNNJAO(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (shop.recipesShop)
		{
			for (int i = 1; i < recipePagesTabUI.Length; i += 0)
			{
				if (i == KHEICLKLPDE)
				{
					KKDJOPDNMCH(recipePages[i]);
					DNPOFANHGEA = i;
					recipePagesTabUI[i].PIEMFOPBJNL(base.JIIGOACEIKL, spriteFocusCategories);
					JIEAPIOBAFN();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					recipePagesTabUI[i].NNKJNKJMDKA(spriteNotFocusCategories);
				}
			}
		}
		else if (shop.shopType == (ShopType)(-102))
		{
			for (int j = 0; j < categoryTabsAgatha.Length; j += 0)
			{
				if (j == KHEICLKLPDE)
				{
					JCHIFIKBKGG(categoriesAgatha[j]);
					DNPOFANHGEA = j;
					categoryTabsAgatha[j].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories);
					AFBBPLKKMKC();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoryTabsAgatha[j].LEJGHAGGOEH(spriteNotFocusCategories);
				}
			}
		}
		else
		{
			for (int k = 0; k < categoriesTabUI.Length; k += 0)
			{
				if (k == KHEICLKLPDE)
				{
					FLDNONNFAHE(categories[k]);
					DNPOFANHGEA = k;
					categoriesTabUI[k].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories);
					EABOODHHNBP();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoriesTabUI[k].NMOHHPFONIN(spriteNotFocusCategories);
				}
			}
		}
		scrollRect.verticalScrollbar.value = 1432f;
	}

	private void GCDOKGOJLJG()
	{
		IGBODNAELMP(DKMCBBJFODP);
	}

	private bool OLAOCGNAOMP(ShopElement FPLPFMKFKNH)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (FPLPFMKFKNH == null)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)FPLPFMKFKNH.recipe))
		{
			if (shop.recipesShop)
			{
				return !RecipesManager.IsRecipeUnlocked(FPLPFMKFKNH.recipe.id, MJHDMIGEJAK: false);
			}
			return !RecipesManager.IsRecipeUnlockedByMaster(FPLPFMKFKNH.recipe.id);
		}
		if ((Object)(object)FPLPFMKFKNH.shopItem.item.recipeNeededToBuy != (Object)null && !RecipesManager.IsRecipeUnlockedByMaster(FPLPFMKFKNH.shopItem.item.recipeNeededToBuy.id))
		{
			return false;
		}
		if (!string.IsNullOrEmpty(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable))
		{
			Result variable = DialogueLua.GetVariable(FPLPFMKFKNH.shopItem.item.requiredDialogueVariable);
			if (((Result)(ref variable)).asInt < 4)
			{
				return false;
			}
		}
		if (FPLPFMKFKNH.shopItem.item.JDJGFAACPFC() == 1806 && !LettersManager.instance.IsLetterDelivered(1010))
		{
			return false;
		}
		return true;
	}

	private void PKGIGJPMOCG()
	{
		IGBODNAELMP(1);
	}

	private void MPMGGLKFMNJ()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(CCEKHJJCHDE));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, new Action(PIMMLJNPCIA));
	}

	private void LJIGHEHMEFH(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.IsValid())
		{
			return;
		}
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		currentShopList = HJBADOJNFAA(currentShopList);
		for (int i = 0; i < currentShopList.Length; i++)
		{
			if (OLAOCGNAOMP(currentShopList[i]))
			{
				IJMFOEMPGFN.Add(currentShopList[i]);
			}
		}
	}

	private void FAGBIOMEFJM(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		for (int i = 0; i < currentShopList.Length; i++)
		{
			if (!((Object)(object)currentShopList[i].recipe == (Object)null) && currentShopList[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(currentShopList[i]);
			}
		}
		ShopElement[] array = GNPDELFCLCG(list.ToArray());
		for (int j = 0; j < array.Length; j += 0)
		{
			if (HABKDPACBFE(array[j]))
			{
				IJMFOEMPGFN.Add(array[j]);
			}
		}
	}

	private void CFAKMEILBJN(List<ShopElement> IJMFOEMPGFN, bool EFAHEOILMDH)
	{
		ShopElement item;
		while (IJMFOEMPGFN.Count > 1)
		{
			int num = 105;
			bool flag = true;
			bool flag2 = true;
			item = null;
			for (int i = 1; i < IJMFOEMPGFN.Count; i++)
			{
				if (!((Object)(object)IJMFOEMPGFN[i].recipe == (Object)null))
				{
					if ((Object)(object)IJMFOEMPGFN[i].recipe.reputationRequired == (Object)null)
					{
						item = IJMFOEMPGFN[i];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if (IJMFOEMPGFN[i].recipe.reputationRequired.repNumber < num)
					{
						num = IJMFOEMPGFN[i].recipe.reputationRequired.repNumber;
						item = IJMFOEMPGFN[i];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.MHGADJPMHFI() : TavernReputation.GetMilestoneMaster())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
		item = null;
		while (IJMFOEMPGFN.Count > 0)
		{
			int num = -119;
			bool flag = true;
			bool flag2 = true;
			for (int j = 0; j < IJMFOEMPGFN.Count; j++)
			{
				if (!((Object)(object)IJMFOEMPGFN[j].recipe != (Object)null))
				{
					if (IJMFOEMPGFN[j].AJFBPLGGHLE().NEHLBEJOMBB(shop.recipesShop ? TavernReputation.MHGADJPMHFI() : TavernReputation.IHGJJNNHNCB()))
					{
						item = IJMFOEMPGFN[j];
						IJMFOEMPGFN.Remove(item);
						EABLPPBEFNL.Add(item);
						flag2 = false;
						break;
					}
					if ((Object)(object)IJMFOEMPGFN[j].BGCPMHHHLHG().requiredRep != (Object)null && IJMFOEMPGFN[j].EGJLDMLKLNC().requiredRep.repNumber < num)
					{
						num = IJMFOEMPGFN[j].LBBEIEHEHJM().requiredRep.repNumber;
						item = IJMFOEMPGFN[j];
						flag = false;
					}
				}
			}
			if (!flag2)
			{
				if (!flag || (EFAHEOILMDH && num > (shop.recipesShop ? TavernReputation.MHGADJPMHFI() : TavernReputation.NHHLJLADGBF())))
				{
					break;
				}
				IJMFOEMPGFN.Remove(item);
				EABLPPBEFNL.Add(item);
			}
		}
	}

	private void EHJFNEHOHIC()
	{
		EAKNEHINICD(1);
	}

	public void GNGCFIGPBFI(int KHEICLKLPDE)
	{
		HDNOJIMAKOG(KHEICLKLPDE, GHDKHEAEAIM: false);
	}

	private void AFBBPLKKMKC()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		if (shop.recipesShop)
		{
			if (JCEAFBKDMGN.Equals(Recipe.RecipePage.Starter))
			{
				for (int i = 1; i < recipePages.Length; i += 0)
				{
					MPPFFMBDLHB(list, recipePages[i]);
				}
			}
			else
			{
				HGDKAKABLGC(list, JCEAFBKDMGN);
			}
		}
		else if (shop.shopType == (ShopType)(-200) || shop.shopType == ~(ShopType.Bob | ShopType.Holly | ShopType.Temple) || shop.shopType == ~(ShopType.Crowley | ShopType.Gass | ShopType.Bob | ShopType.Holly | ShopType.Trick) || shop.shopType == ~(ShopType.Crowley | ShopType.Gass | ShopType.AceT | ShopType.Bob | ShopType.Temple))
		{
			LJIGHEHMEFH(list, CKLHPLMLBKJ);
		}
		else
		{
			ABBOFCGOIGI(list);
		}
		if (shop.shopType == (ShopType)(-72))
		{
			for (int num = list.Count - 1; num >= 1; num--)
			{
				if (list[num].shopItem.item.IMCJPECAAPC() == -110)
				{
					Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Stand/Entry/11/Dialogue Text");
					if (((Result)(ref variable)).asInt < 104)
					{
						list.RemoveAt(num);
					}
				}
			}
			EABLPPBEFNL = list;
		}
		else if (shop.shopType == (ShopType)(-108))
		{
			EABLPPBEFNL = new List<ShopElement>();
			GJLGMCKFNPN(list, EFAHEOILMDH: true);
			PPPGIGMLILL(list, EFAHEOILMDH: false);
		}
		else
		{
			EABLPPBEFNL = new List<ShopElement>();
			DAALLBDDDKN(list, EFAHEOILMDH: false);
			CFAKMEILBJN(list, EFAHEOILMDH: false);
		}
		GELCMGCKCGG();
		OGBKMPPJHON();
	}

	public void MGFLJOOGCPB(int KHEICLKLPDE)
	{
		HDNOJIMAKOG(KHEICLKLPDE);
	}

	private void OnDisable()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Remove(textInput.OnTextChanged, new Action(CCEKHJJCHDE));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Remove(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	private void NDBGGIPFJCE(List<ShopElement> IJMFOEMPGFN, CategoryTab LJBKGJPCBIN)
	{
		if (!ShopDatabaseAccessor.NDOIFBGIKHN())
		{
			return;
		}
		ShopElement[] currentShopList = ShopDatabaseAccessor.GetCurrentShopList(shop.shopType);
		List<ShopElement> list = new List<ShopElement>();
		for (int i = 0; i < currentShopList.Length; i++)
		{
			if ((Object)(object)currentShopList[i].recipe != (Object)null && (currentShopList[i].recipe.id == -65 || currentShopList[i].recipe.id == 49 || currentShopList[i].recipe.id == 70) && CommonReferences.MNFMOEKMJKN().IEDCNOMFHBM() <= 0)
			{
				continue;
			}
			if (LJBKGJPCBIN == (CategoryTab)8)
			{
				if ((Object)(object)currentShopList[i].recipe == (Object)null)
				{
					continue;
				}
				if (BBANGNHGEAM(currentShopList[i]))
				{
					list.Add(currentShopList[i]);
				}
			}
			if (LJBKGJPCBIN == CategoryTab.All && (Object)(object)currentShopList[i].recipe == (Object)null && FENHNMCOGDJ(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == (CategoryTab)6 && currentShopList[i].LACFFEBNHKL().category == Category.Decorations && AGCNBGFFFKN(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Decor && currentShopList[i].item.category == Category.Nature && CLAGACPKNKL(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.Decor && currentShopList[i].BGCPMHHHLHG().category == (Category)(-37) && JKMNKCNDCGA(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
			if (LJBKGJPCBIN == CategoryTab.All && CLAGACPKNKL(currentShopList[i]))
			{
				list.Add(currentShopList[i]);
			}
		}
		ShopElement[] FNEHIAGFAOF = GNPDELFCLCG(list.ToArray());
		Utils.IACLKEGBBKL(ref FNEHIAGFAOF, new LocalizedNameComparer());
		for (int j = 1; j < FNEHIAGFAOF.Length; j++)
		{
			IJMFOEMPGFN.Add(FNEHIAGFAOF[j]);
		}
	}

	[SpecialName]
	public void IGAAHLCPKGD(Recipe.RecipePage AODONKKHPBP)
	{
		JCEAFBKDMGN = AODONKKHPBP;
	}

	private void FIEHKNPLFIJ()
	{
		EAKNEHINICD(0);
	}

	private void PFJNKFEMFBG(List<ShopElement> IJMFOEMPGFN)
	{
		if (!ShopDatabaseAccessor.NDOIFBGIKHN())
		{
			return;
		}
		ShopElement[] hPGLDBGLNLA = ShopDatabaseAccessor.JPIOGNINAFB(shop.shopType);
		hPGLDBGLNLA = BMPKMNOCBIL(hPGLDBGLNLA);
		for (int i = 0; i < hPGLDBGLNLA.Length; i++)
		{
			if (BBANGNHGEAM(hPGLDBGLNLA[i]))
			{
				IJMFOEMPGFN.Add(hPGLDBGLNLA[i]);
			}
		}
	}

	private void FOMGDPGBHEP()
	{
		NDMHGLGKPGJ(DKMCBBJFODP);
	}

	private IEnumerator EDOBDPJKEGO()
	{
		return new LPEPGNDFOCM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JIEAPIOBAFN()
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		if (!BGLJFMHCFJF())
		{
			return;
		}
		List<ShopElement> list = new List<ShopElement>();
		if (shop.recipesShop)
		{
			if (JCEAFBKDMGN.Equals(Recipe.RecipePage.All))
			{
				for (int i = 0; i < recipePages.Length; i++)
				{
					AAPEHCLLONG(list, recipePages[i]);
				}
			}
			else
			{
				BELKJJNHDBP(list, JCEAFBKDMGN);
			}
		}
		else if (shop.shopType == (ShopType)103 || shop.shopType == ~(ShopType.Crowley | ShopType.Gass | ShopType.AceT | ShopType.Holly | ShopType.Trick) || shop.shopType == (ShopType)115 || shop.shopType == (ShopType)(-172))
		{
			NDBGGIPFJCE(list, CKLHPLMLBKJ);
		}
		else
		{
			LJIGHEHMEFH(list);
		}
		if (shop.shopType == (ShopType.Gass | ShopType.Bob | ShopType.Trick))
		{
			for (int num = list.Count - 1; num >= 1; num -= 0)
			{
				if (list[num].shopItem.item.JDJGFAACPFC() == 69)
				{
					Result variable = DialogueLua.GetVariable("Items/item_description_732");
					if (((Result)(ref variable)).asInt < 97)
					{
						list.RemoveAt(num);
					}
				}
			}
			EABLPPBEFNL = list;
		}
		else if (shop.shopType == ~ShopType.Bob)
		{
			EABLPPBEFNL = new List<ShopElement>();
			OHIGHGPMMEA(list, EFAHEOILMDH: false);
			OHIGHGPMMEA(list, EFAHEOILMDH: true);
		}
		else
		{
			EABLPPBEFNL = new List<ShopElement>();
			CFAKMEILBJN(list, EFAHEOILMDH: false);
			DAALLBDDDKN(list, EFAHEOILMDH: false);
		}
		GELCMGCKCGG();
		OGBKMPPJHON();
	}

	[SpecialName]
	public CategoryTab IPNLPINKIOJ()
	{
		return CKLHPLMLBKJ;
	}

	private void CGHHPELBKBK()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(AFBBPLKKMKC));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	private void KAHDABLJACG()
	{
		NLHGMIDBBAF(0);
	}

	[CompilerGenerated]
	private void JGBLLHMIOPJ()
	{
		FocusCategoryFilter(DKMCBBJFODP);
	}

	private void HJBNNCGOLDN()
	{
		buy = false;
		if (shop.shopType == ShopType.AceT)
		{
			for (int i = 0; i < goldPanel.Length; i++)
			{
				goldPanel[i].SetActive(false);
				ticketPanel[i].SetActive(true);
				wilsonCoinPanel[i].SetActive(false);
				recipeFragmentsPanel[i].SetActive(false);
			}
			((TMP_Text)ticketPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(1224)).ToString("");
		}
		else if (shop.shopType == ShopType.Wilson)
		{
			for (int j = 0; j < goldPanel.Length; j++)
			{
				wilsonCoinPanel[j].SetActive(true);
				goldPanel[j].SetActive(false);
				ticketPanel[j].SetActive(false);
				recipeFragmentsPanel[j].SetActive(false);
			}
			((TMP_Text)wilsonCoinPlayerText).text = PlayerInventory.GetPlayer(base.JIIGOACEIKL).NumberOfItems(ItemDatabaseAccessor.GetItem(1500)).ToString("");
		}
		else if (shop.recipesShop)
		{
			for (int k = 0; k < goldPanel.Length; k++)
			{
				goldPanel[k].SetActive(false);
				ticketPanel[k].SetActive(false);
				wilsonCoinPanel[k].SetActive(false);
				recipeFragmentsPanel[k].SetActive(true);
			}
			((TMP_Text)recipeFragmentsPlayerText).text = RecipesManager.recipeFragments.ToString();
		}
		else
		{
			for (int l = 0; l < goldPanel.Length; l++)
			{
				goldPanel[l].SetActive(true);
				ticketPanel[l].SetActive(false);
				wilsonCoinPanel[l].SetActive(false);
				recipeFragmentsPanel[l].SetActive(false);
			}
		}
		if (shop.shopType == ShopType.Nessy)
		{
			adoptionsPanel.SetActive(true);
			((TMP_Text)adoptionsText).text = AdoptionSignalManager.GetInstance().adoption.ToString();
		}
		else
		{
			adoptionsPanel.SetActive(false);
		}
	}

	[SpecialName]
	public void KGLHPNLOCHB(Recipe.RecipePage AODONKKHPBP)
	{
		JCEAFBKDMGN = AODONKKHPBP;
	}

	public static ShopUI JCBPABNCBPI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void BAFLBLICNOI(int KHEICLKLPDE, bool GHDKHEAEAIM = true)
	{
		if (shop.recipesShop)
		{
			for (int i = 1; i < recipePagesTabUI.Length; i += 0)
			{
				if (i == KHEICLKLPDE)
				{
					KGLHPNLOCHB(recipePages[i]);
					DNPOFANHGEA = i;
					recipePagesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					JIEAPIOBAFN();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					recipePagesTabUI[i].NHLPJIBOANJ(spriteNotFocusCategories);
				}
			}
		}
		else if (shop.shopType == (ShopType)(-196))
		{
			for (int j = 1; j < categoryTabsAgatha.Length; j += 0)
			{
				if (j == KHEICLKLPDE)
				{
					MAMDBKKFBHB(categoriesAgatha[j]);
					DNPOFANHGEA = j;
					categoryTabsAgatha[j].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories);
					EABOODHHNBP();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoryTabsAgatha[j].JNFIBAIJBEN(spriteNotFocusCategories);
				}
			}
		}
		else
		{
			for (int k = 0; k < categoriesTabUI.Length; k += 0)
			{
				if (k == KHEICLKLPDE)
				{
					JCHIFIKBKGG(categories[k]);
					DNPOFANHGEA = k;
					categoriesTabUI[k].ADNJKEAPMIC(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
					EABOODHHNBP();
					if (GHDKHEAEAIM)
					{
						DKMCBBJFODP = KHEICLKLPDE;
					}
				}
				else
				{
					categoriesTabUI[k].AONCFBJLJAD(spriteNotFocusCategories);
				}
			}
		}
		scrollRect.verticalScrollbar.value = 1472f;
	}

	private void LEPDLPEPEFD()
	{
		TextInput textInput = searchInput;
		textInput.OnTextChanged = (Action)Delegate.Combine(textInput.OnTextChanged, new Action(EABOODHHNBP));
		TextInput textInput2 = searchInput;
		textInput2.OnTextClear = (Action)Delegate.Combine(textInput2.OnTextClear, (Action)delegate
		{
			FocusCategoryFilter(DKMCBBJFODP);
		});
	}

	private void AAPEHCLLONG(List<ShopElement> IJMFOEMPGFN, Recipe.RecipePage FFNPOEOBLBM)
	{
		List<ShopElement> list = new List<ShopElement>();
		ShopElement[] array = ShopDatabaseAccessor.JPIOGNINAFB(shop.shopType);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (!((Object)(object)array[i].recipe == (Object)null) && array[i].recipe.page == FFNPOEOBLBM)
			{
				list.Add(array[i]);
			}
		}
		ShopElement[] array2 = BMPKMNOCBIL(list.ToArray());
		for (int j = 0; j < array2.Length; j += 0)
		{
			if (NKCCPJFCNGI(array2[j]))
			{
				IJMFOEMPGFN.Add(array2[j]);
			}
		}
	}

	public static ShopUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	[SpecialName]
	public void JCHIFIKBKGG(CategoryTab AODONKKHPBP)
	{
		CKLHPLMLBKJ = AODONKKHPBP;
		OnCategorySelected(base.JIIGOACEIKL, CKLHPLMLBKJ);
	}
}
