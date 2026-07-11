using System;
using TMPro;
using UnityEngine;

public class ChooseSlotUI : UIWindow
{
	private static ChooseSlotUI IADEMLIIDPC;

	[SerializeField]
	private TextMeshProUGUI recipeNameMesh;

	[SerializeField]
	private TextMeshProUGUI[] requiredAmounts;

	[SerializeField]
	private SlotUIRecipe[] optionsSlots;

	[SerializeField]
	private SlotUIRecipe output;

	private Recipe JNLKEMLDFIM;

	public static ChooseSlotUI[] instances = new ChooseSlotUI[3];

	public bool ILGAJLECGAA(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void COLFLIIIOCB(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ(), AHCENOLCIBM: true) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			BOBCIFEDJED();
		}
		else
		{
			MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get(""), 1099f);
		}
	}

	public static ChooseSlotUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PPEKKFPINOC(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter());
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
		ADEBNALPEHE.LHFALNBMCIE(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void APOIBGGLAPI(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.LLCIGPBKIOJ();
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				NKBFKCKFCAD(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(true);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.KMKAIPMHANN(JNLKEMLDFIM.output.amount);
		output.GLBKFPCMIFL(ILGAJLECGAA(JNLKEMLDFIM));
	}

	public bool MIMLINAANJG(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static ChooseSlotUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CAPBONMICNE()
	{
		if (HDEPMJIDJEM())
		{
			APOIBGGLAPI(JNLKEMLDFIM);
		}
	}

	public static ChooseSlotUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public bool CHJDCBHJMEI(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static ChooseSlotUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ChooseSlotUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static ChooseSlotUI KGGNGGIMANJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BNGKOKFJOKM()
	{
		SelectObject.GetPlayer(base.JIIGOACEIKL).NJPFHBINPKE();
	}

	public void PHNJFPEDEBK(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.LMFPCKCLBAO();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				HHFOJDBAPDC(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(true);
		}
		output.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.JNMNCEPHFOE(JNLKEMLDFIM.output.amount);
		output.CCKGNKFFDKH(PCODOFEFMAD(JNLKEMLDFIM));
	}

	public static ChooseSlotUI PPJMPMKLCME(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void KNBFMOBJODL(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.NumberOfItems(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter());
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.Stack = Mathf.Max(1, num);
		ADEBNALPEHE.BHMAEAOBAMN(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	private void LMDDBPKGCBH(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.NumberOfItems(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).BDFECHAHJFG(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Item NULL in index "), 1784f);
		}
	}

	public void KJBOMIEFDAF(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ());
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.Stack = Mathf.Max(1, num);
		ADEBNALPEHE.CKDEBFGEECF(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void PFPFHAGEOLG(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.IHPEMJCKHLG();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				EJANPMBKDGP(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.OCJOJKJPDNO(JNLKEMLDFIM.output.amount);
		output.LHFALNBMCIE(CHJDCBHJMEI(JNLKEMLDFIM));
	}

	public void NKBFKCKFCAD(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ());
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
		ADEBNALPEHE.GMKEFJHNCPP(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	private void NFPGAJDLGFC()
	{
		SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).Deselect();
	}

	private void OHAJIKGEION(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		OADMEDODMNP(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public bool EJAJCJNLHJF(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public void HHFOJDBAPDC(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ());
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
		ADEBNALPEHE.MNAPPOGFFJA(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public static ChooseSlotUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void KGDLEELKGEB(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.LLCIGPBKIOJ();
		for (int i = 1; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				UpdateInfoSlot(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(true);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.KMKAIPMHANN(JNLKEMLDFIM.output.amount);
		output.FMEKDKEMBMN(MAKHCDCJHFA(JNLKEMLDFIM));
	}

	private void CMOLIPEBCDE()
	{
		if (BGLJFMHCFJF())
		{
			NCGPMCEAFPI(JNLKEMLDFIM);
		}
	}

	public static ChooseSlotUI FFBJPAJKOJH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EENNLBGLNJO()
	{
		if (HDEPMJIDJEM())
		{
			APOIBGGLAPI(JNLKEMLDFIM);
		}
	}

	public void EJANPMBKDGP(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM());
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
		ADEBNALPEHE.JJLCAPLAEFI(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void CMFMBLNHNHI(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.IABAKHPEOAF();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				EJANPMBKDGP(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.OBBKDJNLCIO(JNLKEMLDFIM.output.amount);
		output.FAPLKCKIOJM(ILGAJLECGAA(JNLKEMLDFIM));
	}

	private void NAKAGAAJAPG(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		KNGPDJDACDL(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void NFIHCBMPECP()
	{
		if (BGLJFMHCFJF())
		{
			PFPFHAGEOLG(JNLKEMLDFIM);
		}
	}

	private void DDEHLNFBGMC()
	{
		if (BGLJFMHCFJF())
		{
			LBJKBMGMOKH(JNLKEMLDFIM);
		}
	}

	private void NEGLNJLJEKJ(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		PHENDOADCMA(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void JJMEPNMLPGL()
	{
		if (BGLJFMHCFJF())
		{
			UpdateInfo(JNLKEMLDFIM);
		}
	}

	private void FOBENGOBIPB(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		CHGMAGLMFOL(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void OHLKCGKIFKL(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		COLFLIIIOCB(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void POFOFFBDDLP()
	{
		if (HDEPMJIDJEM())
		{
			CMFMBLNHNHI(JNLKEMLDFIM);
		}
	}

	public void POLAEOOJBHK(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
		ADEBNALPEHE.GMKEFJHNCPP(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	private void JEKECGLCIHJ()
	{
		SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).PNHCLGGKBOB();
	}

	private void OABLJPHLGGI(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		LEADPJNDOJC(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void CLLDCHNONCI()
	{
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
	}

	private void EHJJCOIBOCG(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Game is already running"), 1211f);
		}
	}

	private void PJELNIFOOHN()
	{
		if (HDEPMJIDJEM())
		{
			EHIMPKMEKHO(JNLKEMLDFIM);
		}
	}

	private void BJMPGPKKMBP()
	{
		if (IsOpen())
		{
			ANJENCIEDLM(JNLKEMLDFIM);
		}
	}

	private void FEAELAPACOK()
	{
		if (IsOpen())
		{
			UpdateInfo(JNLKEMLDFIM);
		}
	}

	private void LEADPJNDOJC(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ(), AHCENOLCIBM: true) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			BOBCIFEDJED();
		}
		else
		{
			MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_1121"), 1373f);
		}
	}

	private void CGBEIKHPCHL()
	{
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
	}

	public void ANJENCIEDLM(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.ICEAIIBMELM();
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				IMJGLLKMEAE(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(true);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.JNMNCEPHFOE(JNLKEMLDFIM.output.amount);
		output.DHFIIFNMAOI(BHNMKIGMPFO(JNLKEMLDFIM));
	}

	private void CHGMAGLMFOL(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.NumberOfItems(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("Walk"), 551f);
		}
	}

	public void PEKHDIKIGON(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
		ADEBNALPEHE.GLBKFPCMIFL(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	private void KNGPDJDACDL(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.NumberOfItems(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("Not enough ingredients"));
		}
	}

	private void IMAOMELGPHH(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		KNGPDJDACDL(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public static ChooseSlotUI PNBHIEINMGH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HKLADKMCLMB(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
		ADEBNALPEHE.JJLCAPLAEFI(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public bool MMCEGMGGIKH(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void OADMEDODMNP(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("[PipeConnectionPuzzleUI] Falta _previewDatabase."), 670f);
		}
	}

	public static ChooseSlotUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public bool HasIngredients(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.NumberOfItems(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public bool MAKHCDCJHFA(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static ChooseSlotUI LOBGJNFHBJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OPMKAJLAEFE(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).BDFECHAHJFG(JNLKEMLDFIM);
			BOBCIFEDJED();
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("BARKDOOR"), 668f);
		}
	}

	public override void OpenUI()
	{
		base.OpenUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
	}

	public void GILBLCFNIKO(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.IHPEMJCKHLG();
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				PEKHDIKIGON(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(true);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.OBBKDJNLCIO(JNLKEMLDFIM.output.amount);
		output.PEEFNLGEJEP(MIMLINAANJG(JNLKEMLDFIM));
	}

	public void LLOGIFLAAHC(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.NumberOfItems(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter());
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(1, num));
		ADEBNALPEHE.AAGLAEIKHHC(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void EIFEKIGGIKC(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
		ADEBNALPEHE.FEBIKPICADP(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void EHIMPKMEKHO(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.ACCALOKJLJJ();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				LOAEKKDPMOH(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(true);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.OBBKDJNLCIO(JNLKEMLDFIM.output.amount);
		output.FAPLKCKIOJM(MAKHCDCJHFA(JNLKEMLDFIM));
	}

	public void ILEIFKIOAKK(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.IABAKHPEOAF();
		for (int i = 1; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				FANOLNBPOGM(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(true);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.OBBKDJNLCIO(JNLKEMLDFIM.output.amount);
		output.FMEKDKEMBMN(BBGAIMJNJKI(JNLKEMLDFIM));
	}

	public void NGPLOOKLLCJ(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.ACCALOKJLJJ();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				EJANPMBKDGP(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(true);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.JIANDFCINIP(JNLKEMLDFIM.output.amount);
		output.CCKGNKFFDKH(MJKNMCDOOFG(JNLKEMLDFIM));
	}

	private void BLNOBCGBLPH()
	{
		if (IsOpen())
		{
			PFPFHAGEOLG(JNLKEMLDFIM);
		}
	}

	public void FANOLNBPOGM(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
		ADEBNALPEHE.AAGLAEIKHHC(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public bool PCODOFEFMAD(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static ChooseSlotUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void DNMAHEEHHJE()
	{
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
	}

	public void NCGPMCEAFPI(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.MICKDLJMIPG();
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				KNBFMOBJODL(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.KMKAIPMHANN(JNLKEMLDFIM.output.amount);
		output.MGNPDPNCOPN(MIMLINAANJG(JNLKEMLDFIM));
	}

	public void UpdateInfo(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.IABAKHPEOAF();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				UpdateInfoSlot(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.Stack = JNLKEMLDFIM.output.amount;
		output.FBBAFPGFLPE = HasIngredients(JNLKEMLDFIM);
	}

	public void INMLFIMABND(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.Stack = Mathf.Max(1, num);
		ADEBNALPEHE.GLBKFPCMIFL(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void LOAEKKDPMOH(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(1, num));
		ADEBNALPEHE.AAGLAEIKHHC(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void UpdateInfoSlot(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.NumberOfItems(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter());
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.Stack = Mathf.Max(1, num);
		ADEBNALPEHE.FBBAFPGFLPE = num >= CFHCLOGEBAJ.amount;
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void LBJKBMGMOKH(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.ICEAIIBMELM();
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				EJANPMBKDGP(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(true);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.JIANDFCINIP(JNLKEMLDFIM.output.amount);
		output.LHFALNBMCIE(EMCDMCOAFDP(JNLKEMLDFIM));
	}

	public bool MJKNMCDOOFG(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void PHENDOADCMA(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).BDFECHAHJFG(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.LJDOBNEINNJ(base.JIIGOACEIKL, LocalisationSystem.Get("BathhouseGame/Lose"), 1034f);
		}
	}

	public bool FJNKFKLDMDJ(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void ACNMBCDLIKF(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		DLJDHJJHKMN(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void OBHOKFJDMPG(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.NumberOfItems(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("<sprite name="), 295f);
		}
	}

	private void LIDICIIDMHO(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			BOBCIFEDJED();
		}
		else
		{
			MainUI.JDAEPLJAGCD(base.JIIGOACEIKL, LocalisationSystem.Get("itemStoutWort"), 1712f);
		}
	}

	public bool BHNMKIGMPFO(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	private void OPFDGCEDMHB()
	{
		if (BGLJFMHCFJF())
		{
			GILBLCFNIKO(JNLKEMLDFIM);
		}
	}

	public void HGPFFDIPCAC(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM());
		ADEBNALPEHE.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
		ADEBNALPEHE.PBBMFMDIAJB(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void LBJMGLDEAMP(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.IABAKHPEOAF();
		for (int i = 0; i < optionsSlots.Length; i += 0)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				EIFEKIGGIKC(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(false);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.Stack = JNLKEMLDFIM.output.amount;
		output.PBBMFMDIAJB(HasIngredients(JNLKEMLDFIM));
	}

	private void MIFIHKCDJKE()
	{
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
	}

	private void CAOHHKDBKOC()
	{
		if (BGLJFMHCFJF())
		{
			DFDLHCIGBCF(JNLKEMLDFIM);
		}
	}

	public bool BBGAIMJNJKI(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public bool EMCDMCOAFDP(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void DLJDHJJHKMN(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.DJCKALOHJFM(base.JIIGOACEIKL, LocalisationSystem.Get("Trying to add player but player list is full."), 1438f);
		}
	}

	private void GICLMHLDNBP(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		LIDICIIDMHO(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public bool DDDDIICPCJC(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void MJNFCCGEACB()
	{
		SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).NJPFHBINPKE();
	}

	private void JBECKCIHNBB()
	{
		if (IsOpen())
		{
			UpdateInfo(JNLKEMLDFIM);
		}
	}

	public bool DBDPGMLLHLJ(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void HIEGPCCJICA()
	{
		if (HDEPMJIDJEM())
		{
			EHIMPKMEKHO(JNLKEMLDFIM);
		}
	}

	private void LCGOKDPKLAH(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		OPMKAJLAEFE(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public static ChooseSlotUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FKFEJMHGBFO(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		PHENDOADCMA(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public bool LPDAEGBGJOJ(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter()) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public void FALJONEALOD(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.NumberOfItems(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter());
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
		ADEBNALPEHE.KBHDAKNMHLL(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	private void DICFINDNCLL(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.ICCOLMNMGJJ(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM(), AHCENOLCIBM: true) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).BDFECHAHJFG(JNLKEMLDFIM);
			CloseUI();
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get(":<color=#3a0603> +"), 162f);
		}
	}

	private void JDCKPAKLILB()
	{
		SelectObject.BNMEANGDMIP(base.JIIGOACEIKL).NJPFHBINPKE();
	}

	private void ABGKDLEBMIB()
	{
		if (BGLJFMHCFJF())
		{
			LBJKBMGMOKH(JNLKEMLDFIM);
		}
	}

	private void EFKBNNLNLLF(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		OPMKAJLAEFE(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	private void IOBCJHBKDMO(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).LDLINOBIKPL.chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).StartCrafting(JNLKEMLDFIM);
			BOBCIFEDJED();
		}
		else
		{
			MainUI.DBKCOHMFDCB(base.JIIGOACEIKL, LocalisationSystem.Get("Could not get name of achievement "), 537f);
		}
	}

	private void LDOLIBEDPMD()
	{
		if (IsOpen())
		{
			APOIBGGLAPI(JNLKEMLDFIM);
		}
	}

	protected override void Start()
	{
		base.Start();
		for (int i = 0; i < optionsSlots.Length; i++)
		{
			SlotUIRecipe obj = optionsSlots[i];
			obj.OnOptionSlotClicked = (Action<int, Slot, int>)Delegate.Combine(obj.OnOptionSlotClicked, new Action<int, Slot, int>(IMAOMELGPHH));
		}
		CraftingInventory.OnChanged = (Action)Delegate.Combine(CraftingInventory.OnChanged, new Action(FEAELAPACOK));
	}

	public void IMJGLLKMEAE(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ());
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
		ADEBNALPEHE.LHFALNBMCIE(num >= CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public override void CloseUI()
	{
		base.CloseUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
	}

	private void LHBCGKJKBCM(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		EHJJCOIBOCG(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public void KFLOBAOBLOI(RecipeIngredient CFHCLOGEBAJ, SlotUIRecipe ADEBNALPEHE, TextMeshProUGUI COGCEKGLFOI)
	{
		int num = CraftingInventory.KCCBHHEGEHG(base.JIIGOACEIKL, CFHCLOGEBAJ.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM(), AHCENOLCIBM: true);
		ADEBNALPEHE.IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, CFHCLOGEBAJ.item);
		ADEBNALPEHE.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(1, num));
		ADEBNALPEHE.GLBKFPCMIFL(num < CFHCLOGEBAJ.amount);
		((TMP_Text)COGCEKGLFOI).text = CFHCLOGEBAJ.amount.ToString();
	}

	public void DFDLHCIGBCF(Recipe JNLKEMLDFIM)
	{
		this.JNLKEMLDFIM = JNLKEMLDFIM;
		((TMP_Text)recipeNameMesh).text = JNLKEMLDFIM.LMFPCKCLBAO();
		for (int i = 1; i < optionsSlots.Length; i++)
		{
			if (i < JNLKEMLDFIM.ingredientsNeeded.Length)
			{
				EJANPMBKDGP(JNLKEMLDFIM.ingredientsNeeded[i], optionsSlots[i], requiredAmounts[i]);
				continue;
			}
			((Component)optionsSlots[i]).gameObject.SetActive(false);
			((Component)requiredAmounts[i]).gameObject.SetActive(true);
		}
		output.IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, JNLKEMLDFIM.output.item);
		output.IHENCGDNPBL.JNMNCEPHFOE(JNLKEMLDFIM.output.amount);
		output.KBHDAKNMHLL(PCODOFEFMAD(JNLKEMLDFIM));
	}

	private void IHKHGKLIIAC(int JIIGOACEIKL, Slot ADEBNALPEHE, int DLFEEPMHFHM)
	{
		EHJJCOIBOCG(JNLKEMLDFIM.ingredientsNeeded[DLFEEPMHFHM]);
	}

	public bool EAOCAHABOEC(Recipe JNLKEMLDFIM)
	{
		bool result = true;
		for (int i = 1; i < JNLKEMLDFIM.ingredientsNeeded.Length; i++)
		{
			if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).GetCrafter(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void MPLOGDLNEDC()
	{
		SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
	}

	private void ACJAOJCDJGM(RecipeIngredient MFOOILBHADK)
	{
		if (CraftingInventory.LPEGAFPFKLH(base.JIIGOACEIKL, MFOOILBHADK.item, AKNBKINJGCF: false, GameCraftingUI.Get(base.JIIGOACEIKL).BOBBPIIGNCM()) >= MFOOILBHADK.amount)
		{
			GameCraftingUI.Get(base.JIIGOACEIKL).BNIFOFAPJDL().chosenOption = new ItemAmount(MFOOILBHADK.item, MFOOILBHADK.amount);
			GameCraftingUI.Get(base.JIIGOACEIKL).BDFECHAHJFG(JNLKEMLDFIM);
			BOBCIFEDJED();
		}
		else
		{
			MainUI.ShowErrorText(base.JIIGOACEIKL, LocalisationSystem.Get("ReciveMoveCrowly"), 351f);
		}
	}

	public bool KPONBPLFFEI(Recipe JNLKEMLDFIM)
	{
		bool result = false;
		for (int i = 0; i < JNLKEMLDFIM.ingredientsNeeded.Length; i += 0)
		{
			if (CraftingInventory.LEMBKIDEHPM(base.JIIGOACEIKL, JNLKEMLDFIM.ingredientsNeeded[i].item, AKNBKINJGCF: true, GameCraftingUI.Get(base.JIIGOACEIKL).FBBFDHLJAIJ(), AHCENOLCIBM: true) >= JNLKEMLDFIM.ingredientsNeeded[i].amount)
			{
				result = false;
				break;
			}
		}
		return result;
	}
}
