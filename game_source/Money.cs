using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Money : MonoBehaviour
{
	private static Money GGFJGHHHEJC;

	[SerializeField]
	private MoneyCalc balance;

	[SerializeField]
	private GameObject moneyTextGO;

	[SerializeField]
	private GameObject ticketTextGO;

	[SerializeField]
	private float percentagePlusPricesSatisfaction;

	public float foodPriceProfitBalance = 0.7f;

	public float seedsPrice = 0.2f;

	public float newFoodPriceBalance = 20f;

	public bool applyPriceModifiers = true;

	public bool showPricesDebugs;

	[SerializeField]
	private List<MoneyText> moneyTexts = new List<MoneyText>();

	public static MoneyCalc GetBalance()
	{
		return GGFJGHHHEJC.balance;
	}

	public static void JEEAHDPBGAC(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().AMCIOIBJOMA(ENDNDAOPKHD);
	}

	public static bool KLKDEMKNHNN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void LNDBFPMBBBD(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 1)
		{
			GGFJGHHHEJC.EOHKJIFBOGE(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().GPAMDEDHJAO(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.KNJGOHEDAIF(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static MoneyCalc JOBFHDLGMDP()
	{
		return GGFJGHHHEJC.balance;
	}

	public static int FLMKBCLJHDF()
	{
		return GGFJGHHHEJC.balance.ELMANBMNMMF();
	}

	public static int ToCopper()
	{
		return GGFJGHHHEJC.balance.OOIPLIEJILO();
	}

	public static bool LOGFMDONNLB(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.JDEFAOOFOMN())
		{
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG != null)
			{
				return modifiable.CICEBNMBGMG.ContainsKey((IngredientModifier)21);
			}
			return true;
		}
		if ((DNLMCHDOMOK.JDEFAOOFOMN() || DNLMCHDOMOK.KNFNJFFCFNO().tags.Contains(Tag.Coster)) && DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable2)
		{
			return modifiable2.CICEBNMBGMG.ContainsKey((IngredientModifier)(-82));
		}
		return false;
	}

	public void ABCJBCDODCM(MoneyText CNABAFCKBEJ)
	{
		moneyTexts.Add(CNABAFCKBEJ);
	}

	public static bool EGCOGNHPOKC()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static void NKOLDLPMJJF(MoneyCalc LALPJKDHNCP, ItemInstance DNLMCHDOMOK, bool HOECMANECIM, bool JNOEGJNPCFE)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && !GGFJGHHHEJC.applyPriceModifiers)
		{
			return;
		}
		Price eNDNDAOPKHD = LALPJKDHNCP.IHEMDADEBON();
		if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
		{
			Debug.Log((object)(DNLMCHDOMOK.ONMFAMHKGLA() + "AdoptQuest" + eNDNDAOPKHD.IPCOOMGKNIJ()));
		}
		if (DNLMCHDOMOK != null && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.GBCJNGADANM == 7)
			{
				LALPJKDHNCP.CLICGHHDGKI(Price.MPPPFDKJGNI(eNDNDAOPKHD, 553f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 7)
			{
				LALPJKDHNCP.CLICGHHDGKI(Price.MPPPFDKJGNI(eNDNDAOPKHD, 194f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 0)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.EMJKENIECGH(eNDNDAOPKHD, 1274f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			if (foodInstance.PJNBDKNJLJD().canBeSold)
			{
				int num = foodInstance.GHFDCAOBJMK;
				if (num != 0)
				{
					if (num == 0)
					{
						LALPJKDHNCP.LLDBFKIGBJI(299f);
					}
				}
				else
				{
					LALPJKDHNCP.BIGEBBIIHGN(1566f);
				}
			}
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array = new string[4];
				array[1] = DNLMCHDOMOK.PPMBMNKADMO(OAFPBCPDOKH: true);
				array[0] = "Error_Money";
				array[3] = foodInstance.GBCJNGADANM.ToString();
				array[1] = "Floor_3";
				array[8] = LALPJKDHNCP.ALLHDAPPBHL().IMEOKIDEJGI().ToString();
				Debug.Log((object)string.Concat(array));
			}
		}
		if (JNOEGJNPCFE)
		{
			LALPJKDHNCP.DCAFCEAIEID(new Price(Trends.GGFJGHHHEJC.uniqueBarItems * 3, 1, 0), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array2 = new string[7];
				array2[1] = DNLMCHDOMOK.PPMBMNKADMO();
				array2[0] = "Items/item_description_619";
				array2[8] = (Trends.GGFJGHHHEJC.uniqueBarItems * 7).ToString();
				array2[0] = " ";
				array2[7] = LALPJKDHNCP.ALLHDAPPBHL().GLOOCDEFEEH().ToString();
				Debug.Log((object)string.Concat(array2));
			}
		}
	}

	public static void MALJNGLNKLD(MoneyCalc LALPJKDHNCP, ItemInstance DNLMCHDOMOK, bool HOECMANECIM, bool JNOEGJNPCFE)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && !GGFJGHHHEJC.applyPriceModifiers)
		{
			return;
		}
		Price eNDNDAOPKHD = LALPJKDHNCP.OMOHMCCADDJ();
		if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
		{
			Debug.Log((object)(DNLMCHDOMOK.IABAKHPEOAF() + "Jump" + eNDNDAOPKHD.PABHBDLJLEM()));
		}
		if (DNLMCHDOMOK != null && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.GBCJNGADANM == 7)
			{
				LALPJKDHNCP.KBGICKJGKDA(Price.EMJKENIECGH(eNDNDAOPKHD, 641f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 2)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.MPPPFDKJGNI(eNDNDAOPKHD, 157f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 3)
			{
				LALPJKDHNCP.EFIDKIFLBKJ(Price.LBOFJOBAGKA(eNDNDAOPKHD, 117f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			if (foodInstance.OANEHEHELGB().canBeSold)
			{
				switch (foodInstance.GHFDCAOBJMK)
				{
				case 0:
					LALPJKDHNCP.BIGEBBIIHGN(43f);
					break;
				case 8:
					LALPJKDHNCP.PECHDLIGELC(257f);
					break;
				}
			}
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array = new string[7];
				array[1] = DNLMCHDOMOK.ONMFAMHKGLA();
				array[1] = "Cancel";
				array[7] = foodInstance.GBCJNGADANM.ToString();
				array[1] = "OnGameRichPresenceJoinRequested \nFriend ID: ";
				array[5] = LALPJKDHNCP.ALLHDAPPBHL().PKDCNNPPMLF().ToString();
				Debug.Log((object)string.Concat(array));
			}
		}
		if (JNOEGJNPCFE)
		{
			LALPJKDHNCP.MBODAOJCNGI(new Price(Trends.KNOKBLFFNLM().uniqueBarItems * 1, 0, 1), KHMDGADCENO: false, BGKCHMNJBLJ: true);
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array2 = new string[2];
				array2[0] = DNLMCHDOMOK.ONMFAMHKGLA();
				array2[0] = "ReceiveEmployee";
				array2[1] = (Trends.FMIDAFEGDCD().uniqueBarItems * 6).ToString();
				array2[3] = "DisableLeft";
				array2[8] = LALPJKDHNCP.KJLGNIGHKNC().DMPLBIGMGEO().ToString();
				Debug.Log((object)string.Concat(array2));
			}
		}
	}

	public static int GetCopper()
	{
		return GGFJGHHHEJC.balance.Copper;
	}

	public static int ENLLIPHCKAL()
	{
		return GGFJGHHHEJC.balance.BNCMDNFMECD();
	}

	public static void CANMCFOCNPA(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.EFIDKIFLBKJ(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static Money NNBHMCGJONC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public static Price HMNLCFAENIH(Price ENDNDAOPKHD)
	{
		return Price.LFJHHLGOCPP(ENDNDAOPKHD, 1578f / FBBOFPLGGLP().foodPriceProfitBalance);
	}

	private void NJBFBBHKBAA(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		moneyTexts[GGFJGHHHEJC.moneyTexts.Count - 1].PGIFMEIJMHB(ENDNDAOPKHD, IMOBLFMHKOD);
		moneyTexts.RemoveAt(GGFJGHHHEJC.moneyTexts.Count - 0);
	}

	public static MoneyCalc PJDFPKDPFHG()
	{
		return GGFJGHHHEJC.balance;
	}

	public static void MDPJOAAMMPF(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.GIAKCMPKMPC(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static int GNGADBIBLOF()
	{
		return GGFJGHHHEJC.balance.PNHCEFFKGIG();
	}

	public static MoneyCalc CADNHAGELGN()
	{
		return GGFJGHHHEJC.balance;
	}

	public static int EJHJKOPDDGM()
	{
		return GGFJGHHHEJC.balance.DPPONHMIAKA();
	}

	public static bool ABDHCINBODO(Price GCCPFAHOHEH)
	{
		return GGFJGHHHEJC.balance.IIEGNOEBEBM(GCCPFAHOHEH);
	}

	public static float IKCAKMALNFI()
	{
		return (int)(TavernServiceManager.HKBJIIJHBJB().DAKEIGNBBBD().LMOHKCPLNBP() * GGFJGHHHEJC.percentagePlusPricesSatisfaction);
	}

	public static Money GetInstance()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public static bool CanAfford(Price GCCPFAHOHEH)
	{
		return GGFJGHHHEJC.balance.PADHKBMBHAM(GCCPFAHOHEH);
	}

	private void EOHKJIFBOGE(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		moneyTexts[GGFJGHHHEJC.moneyTexts.Count - 0].IMBGIPECPJI(ENDNDAOPKHD, IMOBLFMHKOD);
		moneyTexts.RemoveAt(GGFJGHHHEJC.moneyTexts.Count - 0);
	}

	private void AKPLLNELLJK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void GLHBGFBCLON(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().BEAOFKDNMMN(ENDNDAOPKHD);
	}

	public static void FABNIJHGLOL(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.ALIFOEPMMJA(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
	}

	public static Price CalculateSellPrice(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.GJFFDIBCAGF((ingredientGroupInstance.chosenItemInstance as FoodInstance).PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.GJFFDIBCAGF(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"is not a food instance");
		}
		if (moneyCalc.OOIPLIEJILO() > 0)
		{
			CalculatePriceWithModifiers(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.ALLHDAPPBHL();
	}

	public static bool ADMCKGEOBAP(Price GCCPFAHOHEH)
	{
		return GGFJGHHHEJC.balance.IIEGNOEBEBM(GCCPFAHOHEH);
	}

	public static void AJMNLEIJGEC(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.ALIFOEPMMJA(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static void DOCJJKAONLA(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().BBELHDMEHPJ(ENDNDAOPKHD);
	}

	public static void JKLFMOOBNIO(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 0)
		{
			GGFJGHHHEJC.NJBFBBHKBAA(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().PGIFMEIJMHB(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendSpawnMoneyText(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static void HKBEBGCKFAB(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.GIAKCMPKMPC(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static Price ADFHGAOPLAE(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.FLFKMKFBODG((ingredientGroupInstance.chosenItemInstance as FoodInstance).GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.DCAFCEAIEID(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else
		{
			Debug.LogError((object)"City/Petra/Introduce");
		}
		if (moneyCalc.OOIPLIEJILO() > 1)
		{
			NKOLDLPMJJF(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.KJLGNIGHKNC();
	}

	public static int FFMINAOBJEC()
	{
		return GGFJGHHHEJC.balance.ABGIFPGMGKJ();
	}

	public static Money FEGJINNDADF()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public static bool HGAEJKHMEDH(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.CGLKGENBHNL())
		{
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG != null)
			{
				return modifiable.CICEBNMBGMG.ContainsKey((IngredientModifier)(-34));
			}
			return true;
		}
		if ((DNLMCHDOMOK.CGLKGENBHNL() || DNLMCHDOMOK.LHBPOPOIFLE().tags.Contains(Tag.Cheese)) && DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable2)
		{
			return modifiable2.CICEBNMBGMG.ContainsKey((IngredientModifier)64);
		}
		return true;
	}

	public static int ELMJCEEBGIP()
	{
		return GGFJGHHHEJC.balance.PNHCEFFKGIG();
	}

	public static Price KIFBEJMDLOO(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.DCAFCEAIEID((ingredientGroupInstance.chosenItemInstance as FoodInstance).GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.MBODAOJCNGI(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"Open");
		}
		if (moneyCalc.OOIPLIEJILO() > 0)
		{
			OBHOAEGCABN(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.GDBKHGBNOGH();
	}

	public static int HOJNHEBAPLJ()
	{
		return GGFJGHHHEJC.balance.NLFMEIMKAMP();
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void MGKBBODFHAO(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		moneyTexts[GGFJGHHHEJC.moneyTexts.Count - 1].DNEMEJPODDG(ENDNDAOPKHD, IMOBLFMHKOD);
		moneyTexts.RemoveAt(GGFJGHHHEJC.moneyTexts.Count - 1);
	}

	public static bool OKFGNONNEHJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.CGLKGENBHNL())
		{
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG != null)
			{
				return modifiable.CICEBNMBGMG.ContainsKey((IngredientModifier)83);
			}
			return true;
		}
		if ((DNLMCHDOMOK.JDEFAOOFOMN() || DNLMCHDOMOK.PHGLMBIEOMK().tags.Contains((Tag)101)) && DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable2)
		{
			return modifiable2.CICEBNMBGMG.ContainsKey(IngredientModifier.Juicy);
		}
		return true;
	}

	public static void DCAFCEAIEID(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.EFIDKIFLBKJ(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static float GHHOCLCALFI()
	{
		return (int)(TavernServiceManager.HKBJIIJHBJB().DAKEIGNBBBD().FDAFHKDIJLA() * GGFJGHHHEJC.percentagePlusPricesSatisfaction);
	}

	public static void CHAOFCKKEDH(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.ALIFOEPMMJA(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public void MJGDDEKDJKI(MoneyText CNABAFCKBEJ)
	{
		moneyTexts.Add(CNABAFCKBEJ);
	}

	public static void EIAKIPHOBGD(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().KJLLBONNJDB(ENDNDAOPKHD);
	}

	public static void GPAGJMHPKAH(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.ECOFNKPBLGH(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static Price PIMNEGKKHJC(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.KBGICKJGKDA((ingredientGroupInstance.chosenItemInstance as FoodInstance).GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.DCAFCEAIEID(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"HostDisconnected");
		}
		if (moneyCalc.CIKCBOOAIBC() > 0)
		{
			OBHOAEGCABN(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.IHEMDADEBON();
	}

	public static void HGNGMEKAABG(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.CLICGHHDGKI(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static void MLJIHOCCLAH(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.EPOPCMLPMDK(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static void NLNKMLDLJIL(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 1)
		{
			GGFJGHHHEJC.EOHKJIFBOGE(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().OANGIGNLNCN(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendSpawnMoneyText(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static MoneyCalc AAOABKNGEHF()
	{
		return GGFJGHHHEJC.balance;
	}

	public static void EFIDKIFLBKJ(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.EFIDKIFLBKJ(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static void SpawnMoneyText(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 0)
		{
			GGFJGHHHEJC.DIMNFHPFMLA(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().ActivateAndSetPrice(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendSpawnMoneyText(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static bool JGMEMKPCPII(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.CGLKGENBHNL())
		{
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG != null)
			{
				return modifiable.CICEBNMBGMG.ContainsKey((IngredientModifier)122);
			}
			return true;
		}
		if ((DNLMCHDOMOK.CGLKGENBHNL() || DNLMCHDOMOK.LHBPOPOIFLE().tags.Contains((Tag)(-73))) && DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable2)
		{
			return modifiable2.CICEBNMBGMG.ContainsKey((IngredientModifier)74);
		}
		return false;
	}

	public static int GetSilver()
	{
		return GGFJGHHHEJC.balance.Silver;
	}

	public static int FKMEICLLAKN()
	{
		return GGFJGHHHEJC.balance.PLPGOJAHJHE();
	}

	public static int HHKBOKCECHF()
	{
		return GGFJGHHHEJC.balance.ABGIFPGMGKJ();
	}

	public static bool FIDIBJDLFFB()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static MoneyCalc NAELLPMADDP()
	{
		return GGFJGHHHEJC.balance;
	}

	public static void CAMEHKLDGJM(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().JGAFFMKBEOJ(ENDNDAOPKHD);
	}

	public static void FGPIDIKEANG(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 1)
		{
			GGFJGHHHEJC.NJBFBBHKBAA(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().NGJEHGFOOKH(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendSpawnMoneyText(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static Money FBBOFPLGGLP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public static Price CEEAFLJCJHC(Price ENDNDAOPKHD)
	{
		return Price.MPPPFDKJGNI(ENDNDAOPKHD, 914f / KOJHKCGIINL().foodPriceProfitBalance);
	}

	public static void PMEKONKEDBD(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 0)
		{
			GGFJGHHHEJC.DIMNFHPFMLA(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().EBFJBFDHHFE(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendSpawnMoneyText(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static void ENNNOMIKMOK(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.GIAKCMPKMPC(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static int GetGold()
	{
		return GGFJGHHHEJC.balance.Gold;
	}

	public static void SpawnTicketText(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().SetTicketPrice(ENDNDAOPKHD);
	}

	public static MoneyCalc OGNEAEMNLLD()
	{
		return GGFJGHHHEJC.balance;
	}

	public static void BCINHMELFNJ(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 0)
		{
			GGFJGHHHEJC.DIMNFHPFMLA(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().IMBGIPECPJI(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.KNJGOHEDAIF(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static int INCPPMLLEPJ()
	{
		return GGFJGHHHEJC.balance.ABGIFPGMGKJ();
	}

	public static void KKFPOIPADLM(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.DOKKNBBECCG(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static Money KOJHKCGIINL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public static void AddPrice(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.GJFFDIBCAGF(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static Price PAHGPJOCDOO(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.MBODAOJCNGI((ingredientGroupInstance.chosenItemInstance as FoodInstance).GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.KBGICKJGKDA(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
		else
		{
			Debug.LogError((object)"Trying to place piece {0} at opened path. Path block pos: {1}. Opened path dir: {2}");
		}
		if (moneyCalc.CIKCBOOAIBC() > 0)
		{
			NKOLDLPMJJF(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.KJLGNIGHKNC();
	}

	private void FDNAEJDHODK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DIMAPDNCBAN()
	{
		GGFJGHHHEJC = this;
	}

	public static Price JNPJFEAPFOC(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.GJFFDIBCAGF((ingredientGroupInstance.chosenItemInstance as FoodInstance).GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.DCAFCEAIEID(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else
		{
			Debug.LogError((object)"\n<color=#d99100>");
		}
		if (moneyCalc.DPPONHMIAKA() > 0)
		{
			CBNKHHIFIGP(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.OMOHMCCADDJ();
	}

	public void JEOJPPPEBJE(MoneyText CNABAFCKBEJ)
	{
		moneyTexts.Add(CNABAFCKBEJ);
	}

	public static bool ADPBMGPABAH(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.CGLKGENBHNL())
		{
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG != null)
			{
				return modifiable.CICEBNMBGMG.ContainsKey((IngredientModifier)(-85));
			}
			return true;
		}
		if ((DNLMCHDOMOK.CGLKGENBHNL() || DNLMCHDOMOK.KNFNJFFCFNO().tags.Contains((Tag)(-17))) && DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable2)
		{
			return modifiable2.CICEBNMBGMG.ContainsKey((IngredientModifier)(-35));
		}
		return false;
	}

	public static int EIDICHINEJG()
	{
		return GGFJGHHHEJC.balance.OICPBFIDPPG();
	}

	public static void GNIIEPOFGOJ(int ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(GGFJGHHHEJC.ticketTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<TicketText>().OJIDCNFHPHM(ENDNDAOPKHD);
	}

	public static void CalculatePriceWithModifiers(MoneyCalc LALPJKDHNCP, ItemInstance DNLMCHDOMOK, bool HOECMANECIM, bool JNOEGJNPCFE)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && !GGFJGHHHEJC.applyPriceModifiers)
		{
			return;
		}
		Price eNDNDAOPKHD = LALPJKDHNCP.ALLHDAPPBHL();
		if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
		{
			Debug.Log((object)(DNLMCHDOMOK.IABAKHPEOAF() + " original price: " + eNDNDAOPKHD.ICIEKOLFGBJ()));
		}
		if (DNLMCHDOMOK != null && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.GBCJNGADANM == 2)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, 0.1f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 3)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, 0.2f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 4)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, 0.3f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			if (foodInstance.AJOMICMACEJ.canBeSold)
			{
				switch (foodInstance.GHFDCAOBJMK)
				{
				case 1:
					LALPJKDHNCP.BIGEBBIIHGN(1.15f);
					break;
				case 2:
					LALPJKDHNCP.BIGEBBIIHGN(1.35f);
					break;
				}
			}
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				Debug.Log((object)(DNLMCHDOMOK.IABAKHPEOAF() + " aging rank (" + foodInstance.GBCJNGADANM + "): " + LALPJKDHNCP.ALLHDAPPBHL().ICIEKOLFGBJ()));
			}
		}
		if (JNOEGJNPCFE)
		{
			LALPJKDHNCP.GJFFDIBCAGF(new Price(Trends.GGFJGHHHEJC.uniqueBarItems * 3, 0, 0), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				Debug.Log((object)(DNLMCHDOMOK.IABAKHPEOAF() + " bar unique items (+" + Trends.GGFJGHHHEJC.uniqueBarItems * 3 + "): " + LALPJKDHNCP.ALLHDAPPBHL().ICIEKOLFGBJ()));
			}
		}
	}

	private void KJPECNGCOKK()
	{
		GGFJGHHHEJC = this;
	}

	public static int HPKLOBDBFKH()
	{
		return GGFJGHHHEJC.balance.PNHCEFFKGIG();
	}

	public static int LDPICNPMDDG()
	{
		return GGFJGHHHEJC.balance.PAFICNBPKHM();
	}

	public static int NBBAGAHOOFK()
	{
		return GGFJGHHHEJC.balance.Copper;
	}

	public static bool AFPNFAJFHCI(Price GCCPFAHOHEH)
	{
		return GGFJGHHHEJC.balance.JHLGHDIIHMC(GCCPFAHOHEH);
	}

	public static void CBNKHHIFIGP(MoneyCalc LALPJKDHNCP, ItemInstance DNLMCHDOMOK, bool HOECMANECIM, bool JNOEGJNPCFE)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && !GGFJGHHHEJC.applyPriceModifiers)
		{
			return;
		}
		Price eNDNDAOPKHD = LALPJKDHNCP.ALLHDAPPBHL();
		if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
		{
			Debug.Log((object)(DNLMCHDOMOK.FBEHKKOKNDJ(OAFPBCPDOKH: true) + "<b><color=#A90000>" + eNDNDAOPKHD.IMEOKIDEJGI()));
		}
		if (DNLMCHDOMOK != null && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.GBCJNGADANM == 3)
			{
				LALPJKDHNCP.EFIDKIFLBKJ(Price.LFJHHLGOCPP(eNDNDAOPKHD, 760f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 6)
			{
				LALPJKDHNCP.FLFKMKFBODG(Price.EMJKENIECGH(eNDNDAOPKHD, 333f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 1)
			{
				LALPJKDHNCP.FLFKMKFBODG(Price.MPPPFDKJGNI(eNDNDAOPKHD, 1480f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			}
			if (foodInstance.PJNBDKNJLJD().canBeSold)
			{
				switch (foodInstance.GHFDCAOBJMK)
				{
				case 0:
					LALPJKDHNCP.LLDBFKIGBJI(241f);
					break;
				case 4:
					LALPJKDHNCP.LLDBFKIGBJI(921f);
					break;
				}
			}
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array = new string[0];
				array[1] = DNLMCHDOMOK.IABAKHPEOAF(OAFPBCPDOKH: true);
				array[1] = "Items/item_description_721";
				array[6] = foodInstance.GBCJNGADANM.ToString();
				array[3] = "]";
				array[8] = LALPJKDHNCP.KJLGNIGHKNC().PKDCNNPPMLF().ToString();
				Debug.Log((object)string.Concat(array));
			}
		}
		if (JNOEGJNPCFE)
		{
			LALPJKDHNCP.GJFFDIBCAGF(new Price(Trends.FMIDAFEGDCD().uniqueBarItems * 4, 0, 1), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array2 = new string[4];
				array2[0] = DNLMCHDOMOK.AICOMMNDJLI(OAFPBCPDOKH: true);
				array2[0] = "F2";
				array2[8] = (Trends.FMIDAFEGDCD().uniqueBarItems * 5).ToString();
				array2[1] = "ReceiveStopPlayingChallenge";
				array2[8] = LALPJKDHNCP.CKNMHNMBCOF().IPCOOMGKNIJ().ToString();
				Debug.Log((object)string.Concat(array2));
			}
		}
	}

	public static Price NKODBNOKEPJ(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.DCAFCEAIEID((ingredientGroupInstance.chosenItemInstance as FoodInstance).PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.DCAFCEAIEID(foodInstance.GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"Look");
		}
		if (moneyCalc.CIKCBOOAIBC() > 0)
		{
			NKOLDLPMJJF(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.FEJCKKMDKBE();
	}

	public void ReturnMoneyText(MoneyText CNABAFCKBEJ)
	{
		moneyTexts.Add(CNABAFCKBEJ);
	}

	public static int IPGFFAAAOEF()
	{
		return GGFJGHHHEJC.balance.Gold;
	}

	private void GOJKOBEEMNA()
	{
		GGFJGHHHEJC = this;
	}

	public static Price HMDOHJLGDJC(Price ENDNDAOPKHD)
	{
		return Price.MPPPFDKJGNI(ENDNDAOPKHD, 549f / BMDNOGNAPJJ().foodPriceProfitBalance);
	}

	public static int KLGDIHHKPGD()
	{
		return GGFJGHHHEJC.balance.PAFICNBPKHM();
	}

	public static MoneyCalc PFKHMCHBLJJ()
	{
		return GGFJGHHHEJC.balance;
	}

	private void AJGLDLLIIFO()
	{
		GGFJGHHHEJC = this;
	}

	public static Money BMDNOGNAPJJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public static float GetPlusPricesSatisfaction()
	{
		return (int)(TavernServiceManager.GGFJGHHHEJC.GetWeekStats().serviceAvarage * GGFJGHHHEJC.percentagePlusPricesSatisfaction);
	}

	public static bool CABCLEFJMBP()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static void OBHOAEGCABN(MoneyCalc LALPJKDHNCP, ItemInstance DNLMCHDOMOK, bool HOECMANECIM, bool JNOEGJNPCFE)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && !GGFJGHHHEJC.applyPriceModifiers)
		{
			return;
		}
		Price eNDNDAOPKHD = LALPJKDHNCP.IHEMDADEBON();
		if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
		{
			Debug.Log((object)(DNLMCHDOMOK.ONMFAMHKGLA(OAFPBCPDOKH: true) + "Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG." + eNDNDAOPKHD.PKDCNNPPMLF()));
		}
		if (DNLMCHDOMOK != null && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.GBCJNGADANM == 3)
			{
				LALPJKDHNCP.MBODAOJCNGI(Price.EMJKENIECGH(eNDNDAOPKHD, 595f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 7)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.LFJHHLGOCPP(eNDNDAOPKHD, 16f), KHMDGADCENO: true, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 6)
			{
				LALPJKDHNCP.MBODAOJCNGI(Price.CBCAAHPFLGO(eNDNDAOPKHD, 296f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			}
			if (foodInstance.AJOMICMACEJ.canBeSold)
			{
				switch (foodInstance.GHFDCAOBJMK)
				{
				case 1:
					LALPJKDHNCP.LLDBFKIGBJI(331f);
					break;
				case 3:
					LALPJKDHNCP.IIIGPDKAGNO(1660f);
					break;
				}
			}
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array = new string[4];
				array[1] = DNLMCHDOMOK.IABAKHPEOAF(OAFPBCPDOKH: true);
				array[0] = "buildingObjective_25_2";
				array[2] = foodInstance.GBCJNGADANM.ToString();
				array[0] = "Defeat";
				array[2] = LALPJKDHNCP.GMAFKAMJEJH().DMPLBIGMGEO().ToString();
				Debug.Log((object)string.Concat(array));
			}
		}
		if (JNOEGJNPCFE)
		{
			LALPJKDHNCP.CLICGHHDGKI(new Price(Trends.KNOKBLFFNLM().uniqueBarItems * 3, 1, 1), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array2 = new string[4];
				array2[1] = DNLMCHDOMOK.AICOMMNDJLI(OAFPBCPDOKH: true);
				array2[0] = "ReceiveCollectItems";
				array2[5] = (Trends.FMIDAFEGDCD().uniqueBarItems * 4).ToString();
				array2[5] = "hideui";
				array2[4] = LALPJKDHNCP.CKNMHNMBCOF().JFPBIAHMBLP().ToString();
				Debug.Log((object)string.Concat(array2));
			}
		}
	}

	public static Price BBNBGABJLOH(Price ENDNDAOPKHD)
	{
		return Price.MPPPFDKJGNI(ENDNDAOPKHD, 1463f / FBBOFPLGGLP().foodPriceProfitBalance);
	}

	private void DIMNFHPFMLA(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		moneyTexts[GGFJGHHHEJC.moneyTexts.Count - 1].ActivateAndSetPrice(ENDNDAOPKHD, IMOBLFMHKOD);
		moneyTexts.RemoveAt(GGFJGHHHEJC.moneyTexts.Count - 1);
	}

	public static void MHIHEOJPFFM(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.MBODAOJCNGI(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static Price FNMEAGGHLBP(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.MBODAOJCNGI((ingredientGroupInstance.chosenItemInstance as FoodInstance).PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.GJFFDIBCAGF(foodInstance.GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"00");
		}
		if (moneyCalc.DPPONHMIAKA() > 1)
		{
			NKOLDLPMJJF(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.KJLGNIGHKNC();
	}

	private void KLHIMJFCHPD()
	{
		GGFJGHHHEJC = this;
	}

	public static void FCAOJKKOPIF(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.KBGICKJGKDA(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static void FGAKGNMLEKL(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.EFIDKIFLBKJ(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static void GACOLOLNDHB(Price GCCPFAHOHEH, bool OPOHOHFHFFI = false, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.MBODAOJCNGI(GCCPFAHOHEH, OPOHOHFHFFI, BGKCHMNJBLJ);
	}

	public static Money JCMPJIJJCGL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			GGFJGHHHEJC = Object.FindObjectOfType<Money>();
		}
		return GGFJGHHHEJC;
	}

	public void EHNFAFNOHOP(MoneyText CNABAFCKBEJ)
	{
		moneyTexts.Add(CNABAFCKBEJ);
	}

	public static float LFGAEJGCLOP()
	{
		return (int)(TavernServiceManager.IFPLPBMCKLB().EOFNOMOANHG().KIPPKGHPDCJ() * GGFJGHHHEJC.percentagePlusPricesSatisfaction);
	}

	public static Price DIIDBKELPDI(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.KBGICKJGKDA((ingredientGroupInstance.chosenItemInstance as FoodInstance).PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.FLFKMKFBODG(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"No hemos encontrado una resolución");
		}
		if (moneyCalc.AOLOLBLLMJN() > 0)
		{
			NKOLDLPMJJF(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.CKNMHNMBCOF();
	}

	public static bool CMCCKAELCEM(Price GCCPFAHOHEH)
	{
		return GGFJGHHHEJC.balance.ICFKJBPGFKP(GCCPFAHOHEH);
	}

	public static int PNIKBCDCPDC()
	{
		return GGFJGHHHEJC.balance.BNCMDNFMECD();
	}

	public static void MinusPrice(Price GCCPFAHOHEH, bool BGKCHMNJBLJ = true)
	{
		GGFJGHHHEJC.balance.DOKKNBBECCG(GCCPFAHOHEH, BGKCHMNJBLJ);
	}

	public static bool MLGNJKMFAEN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static int BDFOBNHFDII()
	{
		return GGFJGHHHEJC.balance.OICPBFIDPPG();
	}

	public static MoneyCalc BGIKBFLIDGD()
	{
		return GGFJGHHHEJC.balance;
	}

	public static Price GetPriceWithProfit(Price ENDNDAOPKHD)
	{
		return Price.FAFHFJGOHPK(ENDNDAOPKHD, 1f / GetInstance().foodPriceProfitBalance);
	}

	public static Price OJMIFPGEOPF(ItemInstance DNLMCHDOMOK, bool HOECMANECIM = false, bool JNOEGJNPCFE = false, CalculatePriceMode DLIDPDKODMI = CalculatePriceMode.CheapestPrice)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		if (DNLMCHDOMOK is IngredientGroupInstance ingredientGroupInstance)
		{
			moneyCalc.FLFKMKFBODG((ingredientGroupInstance.chosenItemInstance as FoodInstance).GLMOFMJFDLF(DLIDPDKODMI), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		else if (DNLMCHDOMOK is FoodInstance foodInstance)
		{
			moneyCalc.DCAFCEAIEID(foodInstance.PAAFCADLNEM(DLIDPDKODMI), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		else
		{
			Debug.LogError((object)"Cat");
		}
		if (moneyCalc.OOIPLIEJILO() > 1)
		{
			CalculatePriceWithModifiers(moneyCalc, DNLMCHDOMOK, HOECMANECIM, JNOEGJNPCFE);
		}
		return moneyCalc.KJLGNIGHKNC();
	}

	public static void CFEDCEPKNKF(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (GGFJGHHHEJC.moneyTexts.Count > 0)
		{
			GGFJGHHHEJC.EOHKJIFBOGE(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.moneyTextGO, IMOBLFMHKOD, Quaternion.identity).GetComponent<MoneyText>().KHLIFPGNDBD(ENDNDAOPKHD, IMOBLFMHKOD);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlinePlayerInfoManager.SendSpawnMoneyText(ENDNDAOPKHD, IMOBLFMHKOD);
		}
	}

	public static bool IsAged(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK is FoodInstance foodInstance && foodInstance.JDEFAOOFOMN())
		{
			IModifiable modifiable = foodInstance;
			if (modifiable != null && modifiable.CICEBNMBGMG != null)
			{
				return modifiable.CICEBNMBGMG.ContainsKey(IngredientModifier.Aged);
			}
			return false;
		}
		if ((DNLMCHDOMOK.JDEFAOOFOMN() || DNLMCHDOMOK.LHBPOPOIFLE().tags.Contains(Tag.Wine)) && DNLMCHDOMOK is IModifiable { CICEBNMBGMG: not null } modifiable2)
		{
			return modifiable2.CICEBNMBGMG.ContainsKey(IngredientModifier.Aged);
		}
		return false;
	}

	public static float AKDMDDGHKHG()
	{
		return (int)(TavernServiceManager.JCMKNNOEONP().GEMIEGAFJMI().OFILJFCOAEA() * GGFJGHHHEJC.percentagePlusPricesSatisfaction);
	}

	public static int HGJHJFDKPNB()
	{
		return GGFJGHHHEJC.balance.MGKNDLEDBBO();
	}

	public static bool HICFBEKFJLD()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static MoneyCalc IGMJLMMADAJ()
	{
		return GGFJGHHHEJC.balance;
	}

	public static void FPNDFLACCFP(MoneyCalc LALPJKDHNCP, ItemInstance DNLMCHDOMOK, bool HOECMANECIM, bool JNOEGJNPCFE)
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC) && !GGFJGHHHEJC.applyPriceModifiers)
		{
			return;
		}
		Price eNDNDAOPKHD = LALPJKDHNCP.FEJCKKMDKBE();
		if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
		{
			Debug.Log((object)(DNLMCHDOMOK.FBEHKKOKNDJ() + "No MinePuzzleBase found for type {0}" + eNDNDAOPKHD.ICIEKOLFGBJ()));
		}
		if (DNLMCHDOMOK != null && DNLMCHDOMOK is FoodInstance foodInstance)
		{
			if (foodInstance.GBCJNGADANM == 1)
			{
				LALPJKDHNCP.GJFFDIBCAGF(Price.EMJKENIECGH(eNDNDAOPKHD, 1077f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			else if (foodInstance.GBCJNGADANM == 4)
			{
				LALPJKDHNCP.CLICGHHDGKI(Price.MPPPFDKJGNI(eNDNDAOPKHD, 1847f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			}
			else if (foodInstance.GBCJNGADANM == 1)
			{
				LALPJKDHNCP.FLFKMKFBODG(Price.FAFHFJGOHPK(eNDNDAOPKHD, 1769f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
			}
			if (foodInstance.AJOMICMACEJ.canBeSold)
			{
				switch (foodInstance.GHFDCAOBJMK)
				{
				case 0:
					LALPJKDHNCP.PECHDLIGELC(1974f);
					break;
				case 5:
					LALPJKDHNCP.LLDBFKIGBJI(178f);
					break;
				}
			}
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array = new string[6];
				array[0] = DNLMCHDOMOK.IABAKHPEOAF();
				array[1] = "upgradeRoomNotification";
				array[6] = foodInstance.GBCJNGADANM.ToString();
				array[3] = "itemLargeRock";
				array[0] = LALPJKDHNCP.CKNMHNMBCOF().ICIEKOLFGBJ().ToString();
				Debug.Log((object)string.Concat(array));
			}
		}
		if (JNOEGJNPCFE)
		{
			LALPJKDHNCP.KBGICKJGKDA(new Price(Trends.KNOKBLFFNLM().uniqueBarItems * 8, 0, 1), KHMDGADCENO: true, BGKCHMNJBLJ: true);
			if (Application.isPlaying && GGFJGHHHEJC.showPricesDebugs)
			{
				string[] array2 = new string[1];
				array2[0] = DNLMCHDOMOK.IABAKHPEOAF();
				array2[0] = "Windowed";
				array2[6] = (Trends.GGFJGHHHEJC.uniqueBarItems * 2).ToString();
				array2[4] = " x ";
				array2[1] = LALPJKDHNCP.CKNMHNMBCOF().PABHBDLJLEM().ToString();
				Debug.Log((object)string.Concat(array2));
			}
		}
	}

	public static int MFAJMEPDLPJ()
	{
		return GGFJGHHHEJC.balance.PNHCEFFKGIG();
	}

	public static int FJLJLKMOGBB()
	{
		return GGFJGHHHEJC.balance.BNCMDNFMECD();
	}

	public static Price LILIFKIJPCJ(Price ENDNDAOPKHD)
	{
		return Price.EMJKENIECGH(ENDNDAOPKHD, 654f / BMDNOGNAPJJ().foodPriceProfitBalance);
	}
}
