using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecipesBookUI : CraftingUI
{
	[SerializeField]
	private TabUI[] categoriesTabUI;

	[SerializeField]
	private Sprite spriteFocusCategories;

	[SerializeField]
	private Sprite spriteNotFocusCategories;

	public Sprite mainQuestSprite;

	public Sprite orderSprite;

	public Sprite favoriteSprite;

	private int FEPLLEPLOJM;

	[SerializeField]
	private RecipeList defaultRecipeBookList;

	private RecipeList HHIGPBECMJH;

	public RecipeList[] recipesList;

	private float CMGDCLIIONE;

	[HideInInspector]
	public bool favoriteListOpen;

	[SerializeField]
	private TextMeshProUGUI playerRecipeFragments;

	public static RecipesBookUI[] instances = new RecipesBookUI[3];

	private void AJKKNOEILOP()
	{
		EPEJIIJMDDL(FEPLLEPLOJM);
	}

	private void IBJGFOANMMN(int LOJPCKPMPIB)
	{
		favoriteListOpen = true;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].NAHPCKLMGHD(MJHDMIGEJAK: false);
		scrollRect.verticalScrollbar.value = 1375f;
		JAIKHHNCGDI();
		PBFOOLDCHPL();
	}

	public static RecipesBookUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CPHDONDMHKI()
	{
		EJAJNDIKNNI(FEPLLEPLOJM);
	}

	public void BBLCINJGPFM(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			PKAKGPHNCEP(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			PJAKHPLBDJB();
			if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 0; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).KBFCCPBHDMP()))
				{
					num2 = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).BEOANCLEPOO()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BIHHMCBFPNK();
				}
				else if (num2 >= num)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).Select(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BOHHKGMEEEE()) && ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BOHHKGMEEEE()).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.FCKGMKGNGDC(NDIAMMHNACN.GBJDNNCOIAC))
			{
				JPDKMMFPMIA(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				BKNDEKIFPNL(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && ILDNNNMOCOC((base.JIIGOACEIKL == 1) ? 4 : 0).BGLJFMHCFJF() && EGBMJGOCIJJ((base.JIIGOACEIKL == 0) ? 1 : 0).favoriteListOpen)
		{
			CNAPMIHPOKC((base.JIIGOACEIKL == 0) ? 3 : 0).JAIKHHNCGDI();
		}
	}

	private void FOADAHIKGOO()
	{
		INLPBBOIAHI(FEPLLEPLOJM);
	}

	protected static void LGJAGPLMEBM(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	private void IHKHNPFCEHH()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = OALDKCIEHBC();
		scrollRect.verticalScrollbar.value = 300f;
		EBHILEAMNAB();
		PBFOOLDCHPL();
	}

	protected static void ELMHKLKCIEA(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public static RecipesBookUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GDIMLMPCHFJ()
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				OACKOKEHNFP();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].OHOCOHIKHPA(spriteNotFocusCategories);
			}
		}
	}

	public void KBBKJFHNDHA()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				KLJFAMCPOKK();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].IIBANMLPDAA(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
			}
		}
	}

	public void BJDICINHNNH(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			KDCABKEECOF(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			JAIKHHNCGDI();
			if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 0; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).PBGKEEENPME()))
				{
					num2 = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CGCIFFOJGOK()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).FBKDHHPNBIL();
				}
				else if (num2 >= num)
				{
					UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)recipes.transform.GetChild(num - 0)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).JJOGJECCPPD(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH()) && ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGOEJJIMAIP()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BEOANCLEPOO()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				KGJPAKIBLKM(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				GMPJLBBKBMA(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.MBNAAHELNHO();
		}
		if (GameManager.LocalCoop() && LAMFGLIGLOP((base.JIIGOACEIKL != 1) ? 1 : 7).IsOpen() && ODLPIANFFFJ((base.JIIGOACEIKL == 0) ? 1 : 1).favoriteListOpen)
		{
			Get((base.JIIGOACEIKL == 0) ? 0 : 0).JAFAHNMKBHE();
		}
	}

	public void OGCMPLEPABC()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				IEHNNOOLIJN();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].ELEHNHEOMDK(spriteNotFocusCategories);
			}
		}
	}

	public static RecipesBookUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected static void FKNNHKIHLLI(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public int CHGLMEEABOG(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].GEIAFFFEJGM();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public bool DKPJKDBFIMN()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 0;
	}

	public void FAFMHBBMLOB(RecipeElementUI NDIAMMHNACN)
	{
		if (BGLJFMHCFJF() && favoriteListOpen)
		{
			ECFOEALOPEO(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.BDBBCBKLFOL(null);
			MBGGNEHKGLJ();
			if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 1; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
				{
					num2 = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FJAKDODEIIF();
				}
				else if (num2 >= num)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).Select(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).CGCIFFOJGOK()) && ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CGCIFFOJGOK()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				BIJCDAGMADD(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				LGJAGPLMEBM(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && ILDNNNMOCOC((base.JIIGOACEIKL == 0) ? 2 : 0).HDEPMJIDJEM() && ILDNNNMOCOC((base.JIIGOACEIKL != 0) ? 1 : 3).favoriteListOpen)
		{
			CNAPMIHPOKC((base.JIIGOACEIKL == 0) ? 3 : 0).GHEKGPJEIGD();
		}
	}

	public void IPFCAJBBEKC(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			GKDJPPIIGPB(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			EBHILEAMNAB();
			if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 1; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEOANCLEPOO()))
				{
					num2 = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).CGCIFFOJGOK()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).LCLJFCKELJN();
				}
				else if (num2 >= num)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JHHNCDODNBD(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).JJOGJECCPPD(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KDJFBLKPFKM()) && ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BCHJGDHJHJK()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).BOHHKGMEEEE()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.HAEPHAHCGPK(NDIAMMHNACN.GBJDNNCOIAC))
			{
				KGJPAKIBLKM(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				ELMHKLKCIEA(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.MBNAAHELNHO();
		}
		if (GameManager.LocalCoop() && ODLPIANFFFJ((base.JIIGOACEIKL != 0) ? 1 : 8).HDEPMJIDJEM() && CGFJPHEFFLO((base.JIIGOACEIKL == 0) ? 6 : 0).favoriteListOpen)
		{
			CGFJPHEFFLO((base.JIIGOACEIKL != 1) ? 1 : 7).MBGGNEHKGLJ();
		}
	}

	private void EGBPCLMHFNH(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].NAHPCKLMGHD();
		scrollRect.verticalScrollbar.value = 1003f;
		GHEKGPJEIGD();
		BFBAKEKIPMC();
	}

	public static RecipesBookUI OMOLNKBLGOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public bool LEAMFLKBCCF()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 4;
	}

	public void CANIJJPHDJO()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				OACKOKEHNFP();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].KHJLGGKPHLH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].BMANHBFCGNE(spriteNotFocusCategories);
			}
		}
	}

	public int DPAFEENIOMD(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].JIBEILMHKLF();
			for (int j = 1; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	protected static void OJBLOBHANGH(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool DPEADBPGCEE()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 0;
	}

	private void HLGHMOAONHH()
	{
		ECPNGANKHFJ(FEPLLEPLOJM);
	}

	protected static void MJHPCNBGJDC(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool OJJPDEBMABM()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 5;
	}

	private void AHIJEDIFKND(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].OLEDIOCNIFH();
		scrollRect.verticalScrollbar.value = 1238f;
		JAIKHHNCGDI();
		BFBAKEKIPMC();
	}

	public static RecipesBookUI MAOAEHDKHDP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected static void CDCIPNBOFJG(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool DKLEBDONBJG()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 2;
	}

	public override void OpenUI()
	{
		if (IsOpen())
		{
			return;
		}
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i < recipesList.Length)
			{
				((Component)categoriesTabUI[i]).GetComponent<TooltipDisplay>().tooltipTitle = recipesList[i].nameId;
			}
		}
		recipes.SetActive(true);
		for (int j = 0; j < recipeSlots.Count; j++)
		{
			((Selectable)recipeSlots[j].buttonExtended).interactable = true;
		}
		HHIGPBECMJH = defaultRecipeBookList;
		AOGEAEEBHDN = HHIGPBECMJH.NEBIMEHBKMO();
		((TMP_Text)playerRecipeFragments).text = RecipesManager.recipeFragments.ToString();
		base.OpenUI();
		FocusCrafterFilter(0);
	}

	public int GNAOLDACNIO(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].BENIHDPABOG();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	protected static void ECFOEALOPEO(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public int KHKOCPPMGFG(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].BENIHDPABOG();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void FocusCrafterFilter(int KHEICLKLPDE)
	{
		ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				MKPFBLOMINJ(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
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
			if (FavoriteTabFocused())
			{
				FocusFavorite();
			}
			else
			{
				FocusCrafterFilter(Utils.NMLNAGFLNMC(FEPLLEPLOJM + 1, categoriesTabUI.Length));
			}
		}
		else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
		{
			if (FEPLLEPLOJM == 0)
			{
				FocusFavorite();
			}
			else
			{
				FocusCrafterFilter(Utils.NMLNAGFLNMC(FEPLLEPLOJM - 1, categoriesTabUI.Length));
			}
		}
	}

	public static RecipesBookUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected static void KDCABKEECOF(Recipe JNLKEMLDFIM)
	{
		RecipesManager.IBBMDKAEHHE(JNLKEMLDFIM.id);
	}

	public void INLPBBOIAHI(int KHEICLKLPDE)
	{
		ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				NMFOGOFNPGG(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].LDFIMGKJGHA(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].JNFIBAIJBEN(spriteNotFocusCategories);
			}
		}
	}

	protected static void OJJIONPKENL(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	protected override void GPJPLKNALFJ()
	{
		if (favoriteListOpen)
		{
			AOGEAEEBHDN = CAABFKNGCJE();
		}
		else
		{
			AOGEAEEBHDN = HHIGPBECMJH.NEBIMEHBKMO();
		}
	}

	public static RecipesBookUI CNAPMIHPOKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected static void NKCKDMPDNCA(Recipe JNLKEMLDFIM)
	{
		RecipesManager.IBBMDKAEHHE(JNLKEMLDFIM.id);
	}

	public void OEPFFCKPDOJ(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			KGJPAKIBLKM(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			JAIKHHNCGDI();
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 1; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KBFCCPBHDMP()))
				{
					num2 = ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).FJAKDODEIIF();
				}
				else if (num2 >= num)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KCDBIMPMGON(((Component)recipes.transform.GetChild(num - 0)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).JHHNCDODNBD(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KBFCCPBHDMP()) && ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).MGOEJJIMAIP()).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).CGCIFFOJGOK()).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				GKDJPPIIGPB(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				BEEMAALPEEB(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && CNAPMIHPOKC((base.JIIGOACEIKL != 1) ? 1 : 6).IsOpen() && AIMEAJAHLAA((base.JIIGOACEIKL == 1) ? 1 : 0).favoriteListOpen)
		{
			ODLPIANFFFJ((base.JIIGOACEIKL != 1) ? 1 : 8).PJAKHPLBDJB();
		}
	}

	private void OPOMAEPMECO(int LOJPCKPMPIB)
	{
		favoriteListOpen = true;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].NAHPCKLMGHD(MJHDMIGEJAK: false);
		scrollRect.verticalScrollbar.value = 31f;
		GHEKGPJEIGD();
		BFBAKEKIPMC();
	}

	private void MKPFBLOMINJ(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].NEBIMEHBKMO();
		scrollRect.verticalScrollbar.value = 1f;
		GHEKGPJEIGD();
		OnContentActivated();
	}

	private void GEDDOIMPHGO()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = CAABFKNGCJE();
		scrollRect.verticalScrollbar.value = 1f;
		GHEKGPJEIGD();
		OnContentActivated();
	}

	public int HHJCOFONODI(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].CNLGKONAGJH();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void ENCFCLBHABB(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].NEBIMEHBKMO();
		scrollRect.verticalScrollbar.value = 911f;
		EBHILEAMNAB();
		PMNCLJJHDPP();
	}

	public bool GKCALGJDAOG()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 8;
	}

	public int ODLICGHNIJM(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].JIBEILMHKLF();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void GDNFELPPHMM()
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				DMDMJPPJHDD();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].NMOHHPFONIN(spriteNotFocusCategories);
			}
		}
	}

	public void NHPLEEDNBCE(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			FGFNLNCIDDH(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			JAIKHHNCGDI();
			if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 0; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).MGOEJJIMAIP()))
				{
					num2 = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CKMLGHPIEEK();
				}
				else if (num2 >= num)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)recipes.transform.GetChild(num - 0)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).Select(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGOEJJIMAIP()) && ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KBFCCPBHDMP()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.FCKGMKGNGDC(NDIAMMHNACN.GBJDNNCOIAC))
			{
				JPDKMMFPMIA(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				MJHPCNBGJDC(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && Get((base.JIIGOACEIKL == 0) ? 7 : 0).BGLJFMHCFJF() && AIMEAJAHLAA((base.JIIGOACEIKL == 1) ? 2 : 0).favoriteListOpen)
		{
			AIMEAJAHLAA((base.JIIGOACEIKL != 1) ? 1 : 0).GHEKGPJEIGD();
		}
	}

	public bool KLPCLPLNOPL()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 0;
	}

	public void KMDGPOHGKLA(int KHEICLKLPDE)
	{
		ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				NMFOGOFNPGG(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].MIJFMCMHAKF(spriteNotFocusCategories);
			}
		}
	}

	private void CMLNJALGDDN(int LOJPCKPMPIB)
	{
		favoriteListOpen = true;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].OLEDIOCNIFH();
		scrollRect.verticalScrollbar.value = 237f;
		GHEKGPJEIGD();
		PBFOOLDCHPL();
	}

	private void FNHHJPJHFKB()
	{
		EJAJNDIKNNI(FEPLLEPLOJM);
	}

	public void AFLBMIALIEL(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			CNPBGKFBHMP(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.BDBBCBKLFOL(null);
			GHEKGPJEIGD();
			if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 1; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FOKMCIDMIKF()))
				{
					num2 = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).DAFBICEGOFO();
				}
				else if (num2 >= num)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEOANCLEPOO()) && ((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).FOKMCIDMIKF()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CGCIFFOJGOK()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				KDCABKEECOF(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				OJBLOBHANGH(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && OMOLNKBLGOC((base.JIIGOACEIKL != 0) ? 1 : 7).IsOpen() && LAMFGLIGLOP((base.JIIGOACEIKL != 1) ? 1 : 5).favoriteListOpen)
		{
			ILDNNNMOCOC((base.JIIGOACEIKL == 1) ? 8 : 0).JAIKHHNCGDI();
		}
	}

	private void PAPKLPEFDBF()
	{
		OLKBCKGPIFG(FEPLLEPLOJM);
	}

	private void LBPDKHHBGPJ()
	{
		favoriteListOpen = false;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = CAABFKNGCJE();
		scrollRect.verticalScrollbar.value = 1599f;
		DAJMKMADJIP();
		PMNCLJJHDPP();
	}

	private void FANFALFIKMB()
	{
		DONPJJAFMIJ(FEPLLEPLOJM);
	}

	private void KKCNBJEJAGL()
	{
		ECPNGANKHFJ(FEPLLEPLOJM);
	}

	protected static void JPDKMMFPMIA(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	protected static void EGJCODEKPCF(Recipe JNLKEMLDFIM)
	{
		RecipesManager.IBBMDKAEHHE(JNLKEMLDFIM.id);
	}

	public bool IBDILEGIFCA()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 2;
	}

	public bool BDAODIHCNKF()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 1;
	}

	private void OACKOKEHNFP()
	{
		favoriteListOpen = false;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = CAABFKNGCJE();
		scrollRect.verticalScrollbar.value = 971f;
		JAIKHHNCGDI();
		BFBAKEKIPMC();
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
		content.SetActive(false);
	}

	protected static void BIJCDAGMADD(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	private void PMHMOGHMMIH()
	{
		ECCLDCAHDND(FEPLLEPLOJM);
	}

	private void IANMHICICEB()
	{
		ECCLDCAHDND(FEPLLEPLOJM);
	}

	private void KNDMEODBLDA(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].OLEDIOCNIFH(MJHDMIGEJAK: false);
		scrollRect.verticalScrollbar.value = 1084f;
		MBGGNEHKGLJ();
		BFBAKEKIPMC();
	}

	public int GetRecipesListNum(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].NCDFLLKLALB();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public override void CloseUIRemainActive()
	{
		base.CloseUIRemainActive();
		for (int i = 0; i < recipeSlots.Count; i++)
		{
			((Selectable)recipeSlots[i].buttonExtended).interactable = false;
		}
	}

	public bool FavoriteTabFocused()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 2;
	}

	protected static void GMPJLBBKBMA(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public void ANDOMDFMGIF()
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				KLJFAMCPOKK();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].NNIBKIDJGGG(spriteNotFocusCategories);
			}
		}
	}

	private void PLIDIIOKFLB()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = OALDKCIEHBC();
		scrollRect.verticalScrollbar.value = 1493f;
		JAFAHNMKBHE();
		PBFOOLDCHPL();
	}

	public void LLGPCBPOKIG()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				IHKHNPFCEHH();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].JNFIBAIJBEN(spriteNotFocusCategories);
			}
		}
	}

	public static RecipesBookUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public int NEIHFMANJCH(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].GEIAFFFEJGM();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public bool NOPAGPFGIIA()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 7;
	}

	public int OHMDFBNDPDL(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].BENIHDPABOG();
			for (int j = 1; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void MPNEONODCKD()
	{
		KFCJFHHENJB(FEPLLEPLOJM);
	}

	public int LICHLOCCPLP(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].BENIHDPABOG();
			for (int j = 1; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	protected static void BKNDEKIFPNL(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool HOPCBKPHAMP()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 2;
	}

	protected static void KGJPAKIBLKM(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	protected static void EBKDPHOKIPC(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool HHNLGPOGIJM()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 6;
	}

	private void CLLHFLEJPHJ()
	{
		ECPNGANKHFJ(FEPLLEPLOJM);
	}

	private void MJCDLMEBNKP()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = CAABFKNGCJE();
		scrollRect.verticalScrollbar.value = 1750f;
		JAFAHNMKBHE();
		BFBAKEKIPMC();
	}

	protected static void ELICLJEFPLJ(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public int EHNDCDHPMJO(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].NCDFLLKLALB();
			for (int j = 1; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	protected static void GKDJPPIIGPB(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool ALHBJFNOBAJ()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 6;
	}

	public int MJPKKMCODJN(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].JIIAAHLGDKC();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void ECPNGANKHFJ(int KHEICLKLPDE)
	{
		ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				NMFOGOFNPGG(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].IIBANMLPDAA(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].JADHPAHNPJO(spriteNotFocusCategories);
			}
		}
	}

	public void KFCJFHHENJB(int KHEICLKLPDE)
	{
		ItemTooltip.IEABDMDELFO(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				OPOMAEPMECO(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].NAEEPFEOGAI(spriteNotFocusCategories);
			}
		}
	}

	private void OOBIKLBDAGP(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].OLEDIOCNIFH(MJHDMIGEJAK: false);
		scrollRect.verticalScrollbar.value = 11f;
		GHEKGPJEIGD();
		OnContentActivated();
	}

	public void LAJJOLNCOCI()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				IHKHNPFCEHH();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].AFOPKGPBOHE(spriteNotFocusCategories);
			}
		}
	}

	private void DMDMJPPJHDD()
	{
		favoriteListOpen = false;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = CAABFKNGCJE();
		scrollRect.verticalScrollbar.value = 662f;
		DAJMKMADJIP();
		PBFOOLDCHPL();
	}

	private void INPBOINMIMI()
	{
		KKJELBOGCBA(FEPLLEPLOJM);
	}

	private void HHFEGFDBGBE()
	{
		EJAJNDIKNNI(FEPLLEPLOJM);
	}

	protected static void MBBJOJMDDML(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public void GJNDKMKJEIL(RecipeElementUI NDIAMMHNACN)
	{
		if (BGLJFMHCFJF() && favoriteListOpen)
		{
			BIJCDAGMADD(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.BDBBCBKLFOL(null);
			JAFAHNMKBHE();
			if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 1; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KBFCCPBHDMP()))
				{
					num2 = ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).PBGKEEENPME()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).DAFBICEGOFO();
				}
				else if (num2 >= num)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).ALPPCGLKHIO(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).FOKMCIDMIKF()) && ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KDJFBLKPFKM()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BEOANCLEPOO()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.FCKGMKGNGDC(NDIAMMHNACN.GBJDNNCOIAC))
			{
				PKAKGPHNCEP(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				FKNNHKIHLLI(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && ODLPIANFFFJ((base.JIIGOACEIKL == 1) ? 4 : 0).HDEPMJIDJEM() && LAIEKOOCNPC((base.JIIGOACEIKL != 1) ? 1 : 2).favoriteListOpen)
		{
			CGFJPHEFFLO((base.JIIGOACEIKL != 0) ? 1 : 2).GHEKGPJEIGD();
		}
	}

	protected override void Start()
	{
		base.Start();
		recipeSlots = new List<RecipeSlot>();
		TextInput textInput = search;
		textInput.OnTextClear = (Action)Delegate.Combine(textInput.OnTextClear, (Action)delegate
		{
			FocusCrafterFilter(FEPLLEPLOJM);
		});
	}

	public void KKJELBOGCBA(int KHEICLKLPDE)
	{
		ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				AHIJEDIFKND(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].NHLPJIBOANJ(spriteNotFocusCategories);
			}
		}
	}

	public void ECCLDCAHDND(int KHEICLKLPDE)
	{
		ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				KNDMEODBLDA(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].IKNDAKBMKNB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].IIFCKDAMIPI(spriteNotFocusCategories);
			}
		}
	}

	protected static void FGFNLNCIDDH(Recipe JNLKEMLDFIM)
	{
		RecipesManager.RemoveFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public bool FJFPNEJLILB()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 2;
	}

	public static RecipesBookUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected static void CLDJJBBHKDP(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public void HODBNFBBMAD(RecipeElementUI NDIAMMHNACN)
	{
		if (BGLJFMHCFJF() && favoriteListOpen)
		{
			KDCABKEECOF(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			DAJMKMADJIP();
			if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 1; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).FOKMCIDMIKF()))
				{
					num2 = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).MGOEJJIMAIP()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).Deselect();
				}
				else if (num2 >= num)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).KCDBIMPMGON(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).PBGKEEENPME()) && ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).OFCEDMBCBBH()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CGCIFFOJGOK()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.HAEPHAHCGPK(NDIAMMHNACN.GBJDNNCOIAC))
			{
				KGJPAKIBLKM(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				FFJBEPMJAIC(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.MBNAAHELNHO();
		}
		if (GameManager.LocalCoop() && LAIEKOOCNPC((base.JIIGOACEIKL == 1) ? 7 : 0).IsOpen() && MAOAEHDKHDP((base.JIIGOACEIKL != 1) ? 1 : 2).favoriteListOpen)
		{
			ILDNNNMOCOC((base.JIIGOACEIKL != 0) ? 1 : 5).GHEKGPJEIGD();
		}
	}

	public void GNGDKNENNLI()
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				JNOBCMNEJGO();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].JADHPAHNPJO(spriteNotFocusCategories);
			}
		}
	}

	public int EOJLCHOOLOD(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].JIBEILMHKLF();
			for (int j = 0; j < list.Count; j += 0)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void KIPDIJPIMCC(RecipeElementUI NDIAMMHNACN)
	{
		if (BGLJFMHCFJF() && favoriteListOpen)
		{
			ELICLJEFPLJ(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			MBGGNEHKGLJ();
			if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 1; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).OFCEDMBCBBH()))
				{
					num2 = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KBFCCPBHDMP()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).LCLJFCKELJN();
				}
				else if (num2 >= num)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)recipes.transform.GetChild(num - 0)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).JJOGJECCPPD(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).MGOEJJIMAIP()) && ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).FOKMCIDMIKF()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).CGCIFFOJGOK()).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.HAEPHAHCGPK(NDIAMMHNACN.GBJDNNCOIAC))
			{
				KDCABKEECOF(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				BKNDEKIFPNL(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.MBNAAHELNHO();
		}
		if (GameManager.LocalCoop() && OMOLNKBLGOC((base.JIIGOACEIKL == 1) ? 2 : 0).HDEPMJIDJEM() && ODLPIANFFFJ((base.JIIGOACEIKL == 1) ? 7 : 0).favoriteListOpen)
		{
			LAIEKOOCNPC((base.JIIGOACEIKL == 0) ? 8 : 0).JAIKHHNCGDI();
		}
	}

	protected static void PKAKGPHNCEP(Recipe JNLKEMLDFIM)
	{
		RecipesManager.IBBMDKAEHHE(JNLKEMLDFIM.id);
	}

	public int HMCAOAKNEIM(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].GEIAFFFEJGM();
			for (int j = 1; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public void CBBNKAAAEGL(RecipeElementUI NDIAMMHNACN)
	{
		if (BGLJFMHCFJF() && favoriteListOpen)
		{
			BIJCDAGMADD(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			GHEKGPJEIGD();
			if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 1; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KBFCCPBHDMP()))
				{
					num2 = ((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).KBFCCPBHDMP()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).IHDPOMIAKOO();
				}
				else if (num2 >= num)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).ALPPCGLKHIO(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).CGCIFFOJGOK()) && ((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).PBGKEEENPME()).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).OFCEDMBCBBH()).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.HAEPHAHCGPK(NDIAMMHNACN.GBJDNNCOIAC))
			{
				PKAKGPHNCEP(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				BKNDEKIFPNL(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && Get((base.JIIGOACEIKL != 1) ? 1 : 7).HDEPMJIDJEM() && Get((base.JIIGOACEIKL != 0) ? 1 : 0).favoriteListOpen)
		{
			AIMEAJAHLAA((base.JIIGOACEIKL == 0) ? 7 : 0).DAJMKMADJIP();
		}
	}

	public int PNOKLGACIIA(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].JIBEILMHKLF();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public int JEJCGIAAJNM(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].BENIHDPABOG();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void IEHNNOOLIJN()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = OALDKCIEHBC();
		scrollRect.verticalScrollbar.value = 515f;
		DAJMKMADJIP();
		PBFOOLDCHPL();
	}

	public void ToggleFavorite(RecipeElementUI NDIAMMHNACN)
	{
		if (IsOpen() && favoriteListOpen)
		{
			ECFOEALOPEO(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			GHEKGPJEIGD();
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 0; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
				{
					num2 = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
				}
				else if (num2 >= num)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				ECFOEALOPEO(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				OJBLOBHANGH(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && Get((base.JIIGOACEIKL != 1) ? 1 : 2).IsOpen() && Get((base.JIIGOACEIKL != 1) ? 1 : 2).favoriteListOpen)
		{
			Get((base.JIIGOACEIKL != 1) ? 1 : 2).GHEKGPJEIGD();
		}
	}

	public static RecipesBookUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DONPJJAFMIJ(int KHEICLKLPDE)
	{
		ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				AHIJEDIFKND(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].PIEMFOPBJNL(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
			}
		}
	}

	protected static void FFJBEPMJAIC(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	public void AHPLMKCJOJN(RecipeElementUI NDIAMMHNACN)
	{
		if (HDEPMJIDJEM() && favoriteListOpen)
		{
			FGFNLNCIDDH(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			GHEKGPJEIGD();
			if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 0; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).MGOEJJIMAIP()))
				{
					num2 = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BCHJGDHJHJK()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).OKEACDGEJIB();
				}
				else if (num2 >= num)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).JHHNCDODNBD(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KGPDHFFEDKP(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CGCIFFOJGOK()) && ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).PBGKEEENPME()).gameObject.activeSelf)
				{
					recipeElementInfo.BDBBCBKLFOL(((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).HGNKFFMDOOL).GetComponent<RecipeSlot>().recipe);
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				PKAKGPHNCEP(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				MJHPCNBGJDC(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.MBNAAHELNHO();
		}
		if (GameManager.LocalCoop() && Get((base.JIIGOACEIKL != 0) ? 1 : 2).BGLJFMHCFJF() && ILDNNNMOCOC((base.JIIGOACEIKL == 1) ? 1 : 0).favoriteListOpen)
		{
			ODLPIANFFFJ((base.JIIGOACEIKL == 0) ? 1 : 0).EBHILEAMNAB();
		}
	}

	public bool DOKPMMPCCAF()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 6;
	}

	public void DOMJKNFNOAH()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				KLJFAMCPOKK();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].ELEHNHEOMDK(spriteNotFocusCategories);
			}
		}
	}

	public int CLFIILFJDIK(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].GEIAFFFEJGM();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	private void HECHAEOHFBI()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = OALDKCIEHBC();
		scrollRect.verticalScrollbar.value = 864f;
		MBGGNEHKGLJ();
		OnContentActivated();
	}

	public void OLKBCKGPIFG(int KHEICLKLPDE)
	{
		ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				EGBPCLMHFNH(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].GEKNEIAKMIL(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].HLJLOBHLMNM(spriteNotFocusCategories);
			}
		}
	}

	public void HDIALODAEND(RecipeElementUI NDIAMMHNACN)
	{
		if (HDEPMJIDJEM() && favoriteListOpen)
		{
			ECFOEALOPEO(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.BDBBCBKLFOL(null);
			MBGGNEHKGLJ();
			if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
			{
				int num = 1;
				for (int i = 0; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).BCHJGDHJHJK()))
				{
					num2 = ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).BOHHKGMEEEE()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BIHHMCBFPNK();
				}
				else if (num2 >= num)
				{
					UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).LFLFDKBKILJ(((Component)recipes.transform.GetChild(num - 0)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CPMHFMLDDFC(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BEOANCLEPOO()) && ((Component)UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).KBFCCPBHDMP()).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).BOHHKGMEEEE()).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.HAEPHAHCGPK(NDIAMMHNACN.GBJDNNCOIAC))
			{
				CNPBGKFBHMP(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				MJHPCNBGJDC(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && ILDNNNMOCOC((base.JIIGOACEIKL == 0) ? 1 : 0).BGLJFMHCFJF() && ODLPIANFFFJ((base.JIIGOACEIKL == 1) ? 7 : 0).favoriteListOpen)
		{
			LAIEKOOCNPC((base.JIIGOACEIKL == 0) ? 5 : 0).GHEKGPJEIGD();
		}
	}

	public void COJFGAODFCA(RecipeElementUI NDIAMMHNACN)
	{
		if (HDEPMJIDJEM() && favoriteListOpen)
		{
			BIJCDAGMADD(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.BDBBCBKLFOL(null);
			JAFAHNMKBHE();
			if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 0; i < recipes.transform.childCount; i++)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num++;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KBFCCPBHDMP()))
				{
					num2 = ((Component)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).CGCIFFOJGOK()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).CKMLGHPIEEK();
				}
				else if (num2 >= num)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).LDAGOHPIGNA(((Component)recipes.transform.GetChild(num - 1)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)recipes.transform.GetChild(0)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).CGCIFFOJGOK()) && ((Component)UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KBFCCPBHDMP()).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).KBFCCPBHDMP()).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.IsFavoriteRecipe(NDIAMMHNACN.GBJDNNCOIAC))
			{
				BIJCDAGMADD(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				BDIHDEBDHMM(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.MBNAAHELNHO();
		}
		if (GameManager.LocalCoop() && Get((base.JIIGOACEIKL == 0) ? 6 : 0).HDEPMJIDJEM() && ODLPIANFFFJ((base.JIIGOACEIKL == 1) ? 7 : 0).favoriteListOpen)
		{
			AIMEAJAHLAA((base.JIIGOACEIKL != 0) ? 1 : 4).JAIKHHNCGDI();
		}
	}

	public void EJAJNDIKNNI(int KHEICLKLPDE)
	{
		ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				ENCFCLBHABB(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].IKNDAKBMKNB(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].NNIBKIDJGGG(spriteNotFocusCategories);
			}
		}
	}

	private void MFINBOHPAFM()
	{
		favoriteListOpen = true;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = OALDKCIEHBC();
		scrollRect.verticalScrollbar.value = 283f;
		MBGGNEHKGLJ();
		PMNCLJJHDPP();
	}

	public void JHDOIEJONNN(RecipeElementUI NDIAMMHNACN)
	{
		if (BGLJFMHCFJF() && favoriteListOpen)
		{
			KDCABKEECOF(NDIAMMHNACN.GBJDNNCOIAC);
			NDIAMMHNACN.GBJDNNCOIAC = null;
			PJAKHPLBDJB();
			if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
			{
				int num = 0;
				for (int i = 0; i < recipes.transform.childCount; i += 0)
				{
					if (((Component)recipes.transform.GetChild(i)).gameObject.activeSelf)
					{
						num += 0;
					}
				}
				int num2 = -1;
				if (Object.op_Implicit((Object)(object)UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BOHHKGMEEEE()))
				{
					num2 = ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).BEOANCLEPOO()).transform.GetSiblingIndex();
				}
				if (num == 0)
				{
					UISelectionManager.HELHJMDEDNL(base.JIIGOACEIKL).CKNJJKJDBGA();
				}
				else if (num2 >= num)
				{
					UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).KCDBIMPMGON(((Component)recipes.transform.GetChild(num - 0)).gameObject);
				}
				else if (num2 == -1)
				{
					UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).GHPMOPMMLJI(((Component)recipes.transform.GetChild(1)).gameObject);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).HGNKFFMDOOL) && ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).BEOANCLEPOO()).gameObject.activeSelf)
				{
					recipeElementInfo.GBJDNNCOIAC = ((Component)UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).FOKMCIDMIKF()).GetComponent<RecipeSlot>().recipe;
				}
			}
		}
		else
		{
			if (RecipesManager.FCKGMKGNGDC(NDIAMMHNACN.GBJDNNCOIAC))
			{
				KDCABKEECOF(NDIAMMHNACN.GBJDNNCOIAC);
			}
			else
			{
				CLDJJBBHKDP(NDIAMMHNACN.GBJDNNCOIAC);
			}
			NDIAMMHNACN.PopulateElement();
		}
		if (GameManager.LocalCoop() && ILDNNNMOCOC((base.JIIGOACEIKL == 0) ? 1 : 1).IsOpen() && ODLPIANFFFJ((base.JIIGOACEIKL != 1) ? 1 : 5).favoriteListOpen)
		{
			ODLPIANFFFJ((base.JIIGOACEIKL != 1) ? 1 : 3).PJAKHPLBDJB();
		}
	}

	public bool FMGMEHNPDJJ()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 3;
	}

	private void KLJFAMCPOKK()
	{
		favoriteListOpen = false;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = CAABFKNGCJE();
		scrollRect.verticalScrollbar.value = 903f;
		JAIKHHNCGDI();
		PBFOOLDCHPL();
	}

	public bool ELGFEABPMDC()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 4;
	}

	private void JNOBCMNEJGO()
	{
		favoriteListOpen = false;
		HHIGPBECMJH = null;
		AOGEAEEBHDN = OALDKCIEHBC();
		scrollRect.verticalScrollbar.value = 1809f;
		PJAKHPLBDJB();
		BFBAKEKIPMC();
	}

	public int EEDODNHKMPN(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].JIIAAHLGDKC();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	public int DDJCMKJODBP(Item MEMGMDOCBOJ)
	{
		for (int i = 0; i < recipesList.Length; i++)
		{
			List<Recipe> list = recipesList[i].CNLGKONAGJH();
			for (int j = 1; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	protected static void EIPBMGBDIDF(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	protected static void BEEMAALPEEB(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	[CompilerGenerated]
	private void BNOHDFNPMDF()
	{
		FocusCrafterFilter(FEPLLEPLOJM);
	}

	public bool GLJPDEFMJHI()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 0;
	}

	public void DELLABDCAGN()
	{
		for (int i = 1; i < categoriesTabUI.Length; i += 0)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				IEHNNOOLIJN();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].OHOCOHIKHPA(spriteNotFocusCategories);
			}
		}
	}

	public void MHKCKMCMBED()
	{
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				MJCDLMEBNKP();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].BJIHNCGPNFL(spriteNotFocusCategories);
			}
		}
	}

	public void EMCOCBHALKL(int KHEICLKLPDE)
	{
		ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		for (int i = 1; i < categoriesTabUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				MKPFBLOMINJ(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].OEIKFIHLDHO(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].PIIMGGGNAOM(spriteNotFocusCategories);
			}
		}
	}

	public int KLNGAKBIEIP(Item MEMGMDOCBOJ)
	{
		for (int i = 1; i < recipesList.Length; i += 0)
		{
			List<Recipe> list = recipesList[i].JIIAAHLGDKC();
			for (int j = 0; j < list.Count; j++)
			{
				if (((object)list[j].output.item).Equals((object?)MEMGMDOCBOJ))
				{
					return i;
				}
			}
		}
		return -1;
	}

	protected static void BDIHDEBDHMM(Recipe JNLKEMLDFIM)
	{
		RecipesManager.AddFavoriteRecipe(JNLKEMLDFIM.id);
	}

	protected static void CNPBGKFBHMP(Recipe JNLKEMLDFIM)
	{
		RecipesManager.IBBMDKAEHHE(JNLKEMLDFIM.id);
	}

	public bool HHMBCGHNNAL()
	{
		return FEPLLEPLOJM == categoriesTabUI.Length - 1;
	}

	public static RecipesBookUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void EPEJIIJMDDL(int KHEICLKLPDE)
	{
		ItemTooltip.NMCJELBLKBB(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				MKPFBLOMINJ(i);
				FEPLLEPLOJM = i;
				categoriesTabUI[i].FKNDNHJBLHB(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].NHLPJIBOANJ(spriteNotFocusCategories);
			}
		}
	}

	private void NMFOGOFNPGG(int LOJPCKPMPIB)
	{
		favoriteListOpen = false;
		HHIGPBECMJH = recipesList[LOJPCKPMPIB];
		AOGEAEEBHDN = recipesList[LOJPCKPMPIB].BHPGBPKCANB(MJHDMIGEJAK: false);
		scrollRect.verticalScrollbar.value = 1701f;
		MBGGNEHKGLJ();
		BFBAKEKIPMC();
	}

	public void FocusFavorite()
	{
		for (int i = 0; i < categoriesTabUI.Length; i++)
		{
			if (i == categoriesTabUI.Length - 1)
			{
				GEDDOIMPHGO();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				categoriesTabUI[i].HideTab(spriteNotFocusCategories);
			}
		}
	}

	public void AILJDCPHHLO()
	{
		for (int i = 0; i < categoriesTabUI.Length; i += 0)
		{
			if (i == categoriesTabUI.Length - 0)
			{
				IEHNNOOLIJN();
				FEPLLEPLOJM = i;
				categoriesTabUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				categoriesTabUI[i].NAEEPFEOGAI(spriteNotFocusCategories);
			}
		}
	}
}
