using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TavernStatsUI : MainPanelWindow
{
	[SerializeField]
	private Slider sliderSatisfaction;

	[SerializeField]
	private Progressor progressor;

	[SerializeField]
	private TextMeshProUGUI reputation;

	[SerializeField]
	private TextMeshProUGUI maximumCapacity;

	[SerializeField]
	private TextMeshProUGUI plusCapacitySatisfaction;

	[SerializeField]
	private TextMeshProUGUI plusPricesSatisfaction;

	[SerializeField]
	private TextMeshProUGUI income;

	[SerializeField]
	private TextMeshProUGUI staffCost;

	[SerializeField]
	private TextMeshProUGUI profit;

	[SerializeField]
	private TextMeshProUGUI tavernName;

	[SerializeField]
	private TextMeshProUGUI totalCustomers;

	[SerializeField]
	private TextMeshProUGUI satisfiedCustomers;

	[SerializeField]
	private TextMeshProUGUI kickedCustomers;

	[SerializeField]
	private TextMeshProUGUI totalCustomersTotal;

	[SerializeField]
	private TextMeshProUGUI satisfiedCustomersTotal;

	[SerializeField]
	private TextMeshProUGUI kickedCustomersTotal;

	[SerializeField]
	private TextMeshProUGUI incomeTotal;

	[SerializeField]
	private TextMeshProUGUI staffCostTotal;

	[SerializeField]
	private TextMeshProUGUI profitTotal;

	public static TavernStatsUI[] instances = new TavernStatsUI[3];

	public void DGPPDBFJFNF()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.JFJOKGAOPHA().DAKEIGNBBBD();
		float num = tavernStats.LMOHKCPLNBP();
		sliderSatisfaction.value = Mathf.Clamp01((num + 803f) / 369f);
		progressor.ILBBADKPFGL(Mathf.Clamp01((num + 1377f) / 1739f));
		int customersCapacity = ReputationDBAccessor.GetReputation(TavernReputation.IHGJJNNHNCB()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.MCNAGDKKOHJ(customersCapacity);
		int num3 = TavernReputation.FPHNNGPEGCG(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("RoadBlocked/Main") + " ";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.GetMilestoneMaster();
		}
		((TMP_Text)plusCapacitySatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/5/Dialogue Text"), ((num3 < 1) ? " for reason " : "Back") + Mathf.Abs(num3));
		TextMeshProUGUI obj3 = maximumCapacity;
		string cAEDMEDBEGI = LocalisationSystem.Get("Jump");
		string[] array = new string[0];
		array[1] = (num2 + num3).ToString();
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)plusPricesSatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("OnConversationStarted "), ((num3 < 0) ? "ClosePopUp" : "/ExtraSettings.sd") + Mathf.Abs((int)Money.GHHOCLCALFI()) + "");
		TextMeshProUGUI obj4 = totalCustomers;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("StartEmote");
		string[] array2 = new string[0];
		array2[0] = tavernStats.customersCount.ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = satisfiedCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get(" cannot be placed.");
		string[] array3 = new string[0];
		array3[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = kickedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get(" ");
		string[] array4 = new string[0];
		array4[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = income;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("Talk");
		string[] array5 = new string[1];
		array5[1] = Price.IFMFKEMHHLM(tavernStats.AHHKGIAMACN()).ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = staffCost;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Items/item_name_677");
		string[] array6 = new string[0];
		array6[1] = Price.IFMFKEMHHLM(tavernStats.HPALLAJDBBB()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Interact");
		string[] array7 = new string[1];
		array7[1] = Price.GHDCKOJGAMM(tavernStats.AEOCGILOPCG()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		tavernStats = TavernServiceManager.JFJOKGAOPHA().FEPCCIHJPEH();
		TextMeshProUGUI obj10 = totalCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("Error in AmbienceController.OnNightEnd: ");
		string[] array8 = new string[0];
		array8[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UINextCategory"), tavernStats.satisfiedCustomers.ToString());
		TextMeshProUGUI obj11 = kickedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get(", ");
		string[] array9 = new string[1];
		array9[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get(": ");
		string[] array10 = new string[0];
		array10[1] = Price.IFMFKEMHHLM(tavernStats.HHLECEBEBLE()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		((TMP_Text)staffCostTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UI2"), Price.IFMFKEMHHLM(tavernStats.POGGBDACFBL()).ToString());
		TextMeshProUGUI obj13 = profitTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("EditorConfiguration");
		string[] array11 = new string[0];
		array11[0] = Price.GHDCKOJGAMM(tavernStats.MIKHHMENHIO()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
	}

	public void ELLPIGEHAFH()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.LHKFIDJFPDB().GEMIEGAFJMI();
		float num = tavernStats.BCCLLHDCFLO();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1588f) / 590f);
		progressor.NIPNGHKNIGN(Mathf.Clamp01((num + 194f) / 1409f));
		int customersCapacity = ReputationDBAccessor.ELGJADBKMPB(TavernReputation.IHGJJNNHNCB()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.DPJPMECIAIN(customersCapacity);
		int customersExtraPerService = TavernReputation.GetCustomersExtraPerService(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Partida comprimida. Tiempo: ") + "Items/item_description_682";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.IHGJJNNHNCB();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("- ");
		string[] array = new string[0];
		array[0] = ((customersExtraPerService < 1) ? "Items/item_description_722" : "/BarkMai") + Mathf.Abs(customersExtraPerService);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("LE_15");
		string[] array2 = new string[0];
		array2[1] = (num2 + customersExtraPerService).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get(":<color=#3a0603> +");
		string[] array3 = new string[0];
		array3[0] = ((customersExtraPerService < 0) ? "Drink" : "Items/item_name_1127") + Mathf.Abs((int)Money.LFGAEJGCLOP()) + "letter";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		((TMP_Text)totalCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Read"), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("Random");
		string[] array4 = new string[0];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get(" intensity:");
		string[] array5 = new string[1];
		array5[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Jump");
		string[] array6 = new string[1];
		array6[1] = Price.OMDBJINNHPC(tavernStats.totalIncome).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		((TMP_Text)staffCost).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_description_1108"), Price.DHMGJGHCCJD(tavernStats.LNFMOPIKHGN()).ToString());
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Player/Bark/Tutorial/CrafterBlock");
		string[] array7 = new string[0];
		array7[0] = Price.DHMGJGHCCJD(tavernStats.IDHNDMEALOC()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		tavernStats = TavernServiceManager.AFFGPMFKEFH().EECBOPOPEME();
		TextMeshProUGUI obj10 = totalCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("itemCaramelAle");
		string[] array8 = new string[1];
		array8[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Farm/Bob/Stand"), tavernStats.satisfiedCustomers.ToString());
		((TMP_Text)kickedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" for "), tavernStats.kickedCustomers.ToString());
		TextMeshProUGUI obj11 = incomeTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("bodyBack");
		string[] array9 = new string[0];
		array9[1] = Price.LEDHAKFAHCI(tavernStats.MEKBNKKAHEJ()).ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = staffCostTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Items/item_description_1084");
		string[] array10 = new string[0];
		array10[1] = Price.LEDHAKFAHCI(tavernStats.ICLIKLIDFML()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = profitTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Items/item_name_1059");
		string[] array11 = new string[0];
		array11[0] = Price.LEDHAKFAHCI(tavernStats.PCBLHECBJLF()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
	}

	public void DJAGJMJDIHN()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.JCMKNNOEONP().LHIGMKAJBHO();
		float num = tavernStats.NJPONBEPKGD();
		sliderSatisfaction.value = Mathf.Clamp01((num + 728f) / 310f);
		progressor.LKDJOHHJBHC(Mathf.Clamp01((num + 1478f) / 1528f));
		int customersCapacity = ReputationDBAccessor.EICFONMDOBM(TavernReputation.NGPDFPDGOMP()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.MCNAGDKKOHJ(customersCapacity);
		int num3 = TavernReputation.FPHNNGPEGCG(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("ReceiveStatuePuzzleSolved") + "ReceiveChristmasEvent";
		if (OnlineManager.PGAGDFAEEFB())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.GetMilestoneMaster();
		}
		((TMP_Text)plusCapacitySatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("</size>"), ((num3 < 1) ? "Loading Gameplay Scene for online play. Only should happen on Master client" : "Missing fade image") + Mathf.Abs(num3));
		TextMeshProUGUI obj3 = maximumCapacity;
		string cAEDMEDBEGI = LocalisationSystem.Get(" installed");
		string[] array = new string[0];
		array[0] = (num2 + num3).ToString();
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = plusPricesSatisfaction;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("MineFloor");
		string[] array2 = new string[0];
		array2[1] = ((num3 < 1) ? " not found in OnlineEventsManager." : "(Player 2) Press ") + Mathf.Abs((int)Money.AKDMDDGHKHG()) + "<sprite name=\"woodIcon\"><color=#8E1818>";
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("ProductValue");
		string[] array3 = new string[0];
		array3[0] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("00");
		string[] array4 = new string[1];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get(" ");
		string[] array5 = new string[1];
		array5[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Open Calendar");
		string[] array6 = new string[1];
		array6[1] = Price.OMDBJINNHPC(tavernStats.NCPDEIMKCGA()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = staffCost;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("ReceiveUpdateMoodState");
		string[] array7 = new string[0];
		array7[1] = Price.HNDGIKFAKNC(tavernStats.EENMDGKMGKG()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		TextMeshProUGUI obj10 = profit;
		string cAEDMEDBEGI8 = LocalisationSystem.Get(" not found ingredient ");
		string[] array8 = new string[1];
		array8[1] = Price.GHDCKOJGAMM(tavernStats.profit).ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		tavernStats = TavernServiceManager.GGFJGHHHEJC.FEPCCIHJPEH();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Crop with ID "), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj11 = satisfiedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("in");
		string[] array9 = new string[0];
		array9[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = kickedCustomersTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Hikari/Quest");
		string[] array10 = new string[1];
		array10[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = incomeTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("ActiveMaiInBar");
		string[] array11 = new string[0];
		array11[1] = Price.HNDGIKFAKNC(tavernStats.BBGAGHCGFIA()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = staffCostTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Listen");
		string[] array12 = new string[0];
		array12[1] = Price.DHMGJGHCCJD(tavernStats.FGEONIFMODF()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
		TextMeshProUGUI obj15 = profitTotal;
		string cAEDMEDBEGI13 = LocalisationSystem.Get("\n");
		string[] array13 = new string[0];
		array13[0] = Price.LEDHAKFAHCI(tavernStats.ONMPCAKKAME()).ToString();
		((TMP_Text)obj15).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI13, array13);
	}

	public void FNAHONIGGGC()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.JFJOKGAOPHA().JIHKFAMAPKM();
		float num = tavernStats.HJOLFKOLLED();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1578f) / 1068f);
		progressor.NIPNGHKNIGN(Mathf.Clamp01((num + 1439f) / 425f));
		int customersCapacity = ReputationDBAccessor.JDEAGDHJENF(TavernReputation.IHGJJNNHNCB()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.DPJPMECIAIN(customersCapacity);
		int customersExtraPerService = TavernReputation.GetCustomersExtraPerService(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("<color=black>") + "itemSpade";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.IHGJJNNHNCB();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("MoveDirection");
		string[] array = new string[0];
		array[0] = ((customersExtraPerService < 1) ? "Player" : "]") + Mathf.Abs(customersExtraPerService);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("RightMouseDetect");
		string[] array2 = new string[0];
		array2[0] = (num2 + customersExtraPerService).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("Nature");
		string[] array3 = new string[1];
		array3[1] = ((customersExtraPerService < 0) ? "Player/Bark/Tutorial/T138" : "tutorialPopUp29") + Mathf.Abs((int)Money.LFGAEJGCLOP()) + "ClosePopUp";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = totalCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("ReceiveLookAtDirection");
		string[] array4 = new string[0];
		array4[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = satisfiedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("Player Num should not be 0.");
		string[] array5 = new string[0];
		array5[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = kickedCustomers;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("itemFriedEgg");
		string[] array6 = new string[1];
		array6[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = income;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Shield");
		string[] array7 = new string[1];
		array7[1] = Price.GHDCKOJGAMM(tavernStats.PEOALHKFCCI()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		TextMeshProUGUI obj10 = staffCost;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("ReceiveLastOrder");
		string[] array8 = new string[0];
		array8[1] = Price.HNDGIKFAKNC(tavernStats.LDIPFNLAJFC()).ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = profit;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("<b><color=#A90000>");
		string[] array9 = new string[0];
		array9[0] = Price.HNDGIKFAKNC(tavernStats.JGKDDLCJEAN()).ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		tavernStats = TavernServiceManager.GGFJGHHHEJC.MIJGBJJBGIB();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Tool"), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj12 = satisfiedCustomersTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Top");
		string[] array10 = new string[0];
		array10[0] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		((TMP_Text)kickedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("City/Carpenters/Oak/Bark/Chisel"), tavernStats.kickedCustomers.ToString());
		TextMeshProUGUI obj13 = incomeTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("talentAmber");
		string[] array11 = new string[1];
		array11[1] = Price.DHMGJGHCCJD(tavernStats.DKIIOFHEBMK()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = staffCostTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Camera ");
		string[] array12 = new string[0];
		array12[1] = Price.LEDHAKFAHCI(tavernStats.ICLIKLIDFML()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
		TextMeshProUGUI obj15 = profitTotal;
		string cAEDMEDBEGI13 = LocalisationSystem.Get("itemLime");
		string[] array13 = new string[0];
		array13[1] = Price.LEDHAKFAHCI(tavernStats.JOKAMMNDLFB()).ToString();
		((TMP_Text)obj15).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI13, array13);
	}

	public void LKAFJPMMJLD()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.GGFJGHHHEJC.EOFNOMOANHG();
		float num = tavernStats.COOKOGPIEPN();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1228f) / 580f);
		progressor.LKMMANDAGDJ(Mathf.Clamp01((num + 1033f) / 913f));
		int customersCapacity = ReputationDBAccessor.ABDMLFNKBMH(TavernReputation.GetMilestoneMaster()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.NJPFOLPMDIA(customersCapacity);
		int num3 = TavernReputation.IIKECMJHCGO(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get(" - Activating variant object ") + "ReceiveNinjaChallengeEventMovePlayer";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NGPDFPDGOMP();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Walking");
		string[] array = new string[1];
		array[1] = ((num3 < 0) ? "Dig" : "Hint key is not set for this puzzle hint.") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Dead");
		string[] array2 = new string[0];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((TMP_Text)plusPricesSatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Sony DualSense"), ((num3 < 1) ? "Precision/DrinkEvent3" : "Build mode active") + Mathf.Abs((int)Money.GetPlusPricesSatisfaction()) + "enddialogue");
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("questDescFarming");
		string[] array3 = new string[0];
		array3[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("Tutorial/T138/Dialogue1");
		string[] array4 = new string[1];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("");
		string[] array5 = new string[0];
		array5[0] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("End of Dictionary.");
		string[] array6 = new string[1];
		array6[1] = Price.DHMGJGHCCJD(tavernStats.FNMPBCMGNIJ()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = staffCost;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("KyrohScene");
		string[] array7 = new string[0];
		array7[0] = Price.GHDCKOJGAMM(tavernStats.HICMOABLMFO()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		TextMeshProUGUI obj10 = profit;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("Gameplay");
		string[] array8 = new string[0];
		array8[1] = Price.OMDBJINNHPC(tavernStats.JLPFJPGFBLE()).ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		tavernStats = TavernServiceManager.AFFGPMFKEFH().FEPCCIHJPEH();
		TextMeshProUGUI obj11 = totalCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("/Player.log");
		string[] array9 = new string[0];
		array9[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_name_681"), tavernStats.satisfiedCustomers.ToString());
		((TMP_Text)kickedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("City/Rhia/Introduce"), tavernStats.kickedCustomers.ToString());
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get(" en ");
		string[] array10 = new string[0];
		array10[0] = Price.DHMGJGHCCJD(tavernStats.PCHFHKDEEDC()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = staffCostTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Disabled");
		string[] array11 = new string[1];
		array11[1] = Price.OMDBJINNHPC(tavernStats.KOIHGNEIHGC()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = profitTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Dialogue System/Conversation/TooDark/Entry/7/Dialogue Text");
		string[] array12 = new string[0];
		array12[0] = Price.OMDBJINNHPC(tavernStats.JEKCJNNLEEG()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
	}

	public void UpdateInfo()
	{
		TavernServiceManager.TavernStats weekStats = TavernServiceManager.GGFJGHHHEJC.GetWeekStats();
		float serviceAvarage = weekStats.serviceAvarage;
		sliderSatisfaction.value = Mathf.Clamp01((serviceAvarage + 1f) / 2f);
		progressor.BHGJPBGINCG = Mathf.Clamp01((serviceAvarage + 1f) / 2f);
		int customersCapacity = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).customersCapacity;
		int num = customersCapacity + TavernReputation.GetPerksBonus(customersCapacity);
		int customersExtraPerService = TavernReputation.GetCustomersExtraPerService(num, serviceAvarage);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Reputation") + ": ";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.GetMilestoneMaster();
		}
		((TMP_Text)plusCapacitySatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Capacity"), ((customersExtraPerService < 0) ? "-" : "+") + Mathf.Abs(customersExtraPerService));
		((TMP_Text)maximumCapacity).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("MaximumCapacity"), (num + customersExtraPerService).ToString());
		((TMP_Text)plusPricesSatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Prices"), ((customersExtraPerService < 0) ? "-" : "+") + Mathf.Abs((int)Money.GetPlusPricesSatisfaction()) + "%");
		((TMP_Text)totalCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ServedCustomers"), weekStats.customersCount.ToString());
		((TMP_Text)satisfiedCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("SatisfiedCustomers"), weekStats.satisfiedCustomers.ToString());
		((TMP_Text)kickedCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("KickedCustomers"), weekStats.kickedCustomers.ToString());
		((TMP_Text)income).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Income"), Price.GHDCKOJGAMM(weekStats.totalIncome).ToString());
		((TMP_Text)staffCost).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("StaffCost"), Price.GHDCKOJGAMM(weekStats.staffCost).ToString());
		((TMP_Text)profit).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Profit"), Price.GHDCKOJGAMM(weekStats.profit).ToString());
		weekStats = TavernServiceManager.GGFJGHHHEJC.GetAllTimeStats();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ServedCustomers"), weekStats.customersCount.ToString());
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("SatisfiedCustomers"), weekStats.satisfiedCustomers.ToString());
		((TMP_Text)kickedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("KickedCustomers"), weekStats.kickedCustomers.ToString());
		((TMP_Text)incomeTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Income"), Price.GHDCKOJGAMM(weekStats.totalIncome).ToString());
		((TMP_Text)staffCostTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("StaffCost"), Price.GHDCKOJGAMM(weekStats.staffCost).ToString());
		((TMP_Text)profitTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Profit"), Price.GHDCKOJGAMM(weekStats.profit).ToString());
	}

	public static TavernStatsUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AHOFCINBBOI()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.HKBJIIJHBJB().GJLPNHEOLBC();
		float num = tavernStats.NCNPKNDHCAC();
		sliderSatisfaction.value = Mathf.Clamp01((num + 259f) / 1703f);
		progressor.JJDKOIOIADG(Mathf.Clamp01((num + 1482f) / 708f));
		int customersCapacity = ReputationDBAccessor.JDEAGDHJENF(TavernReputation.IHGJJNNHNCB()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.DPJPMECIAIN(customersCapacity);
		int num3 = TavernReputation.GLAOJNJNPBA(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("PlayerNum not set in the inspector for FadeCamera component. If this component is set on the player prefab, it needs to be removed and placed on the initialization scene.") + "Error in DogNPC.TeleportToInitialPoint: ";
		if (OnlineManager.PGAGDFAEEFB())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.GetMilestoneMaster();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Angry");
		string[] array = new string[1];
		array[1] = ((num3 < 0) ? "" : "LE_3") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("[MapChest] Starting OpenChestCoroutine for player {0} with giveRewards={1}");
		string[] array2 = new string[1];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((TMP_Text)plusPricesSatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Farm/Bob/Barks_Shop"), ((num3 < 0) ? "AttackBird" : "Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/3/Dialogue Text") + Mathf.Abs((int)Money.AKDMDDGHKHG()) + "castle travelling");
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("Items/item_name_1074");
		string[] array3 = new string[0];
		array3[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("");
		string[] array4 = new string[0];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("ConnectionTimeout");
		string[] array5 = new string[1];
		array5[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Failed to sign in for reason ");
		string[] array6 = new string[0];
		array6[0] = Price.OMDBJINNHPC(tavernStats.GKEKBEKMONB()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = staffCost;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("HitCollider");
		string[] array7 = new string[0];
		array7[1] = Price.DHMGJGHCCJD(tavernStats.KJCJFIPEOKE()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		((TMP_Text)profit).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("BuildMode_ExitAndCancel"), Price.GHDCKOJGAMM(tavernStats.ENIKHJOHEMD()).ToString());
		tavernStats = TavernServiceManager.GGFJGHHHEJC.KLECMHBJFHO();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveNinjaCustomerState"), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj10 = satisfiedCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("subject");
		string[] array8 = new string[0];
		array8[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = kickedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("");
		string[] array9 = new string[1];
		array9[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get(" without prefab");
		string[] array10 = new string[0];
		array10[1] = Price.LEDHAKFAHCI(tavernStats.HHLECEBEBLE()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = staffCostTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("LE_22");
		string[] array11 = new string[0];
		array11[1] = Price.LEDHAKFAHCI(tavernStats.LCPGMBPNJNL()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		((TMP_Text)profitTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player2"), Price.DHMGJGHCCJD(tavernStats.AEOCGILOPCG()).ToString());
	}

	public static TavernStatsUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI FHOGLBPBGMI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LJNBPNHJJDG()
	{
		TavernServiceManager.TavernStats weekStats = TavernServiceManager.AFFGPMFKEFH().GetWeekStats();
		float num = weekStats.AJCJDJEGBIE();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1586f) / 1753f);
		progressor.BHGJPBGINCG = Mathf.Clamp01((num + 1583f) / 92f);
		int customersCapacity = ReputationDBAccessor.LABODOOGKIE(TavernReputation.NGPDFPDGOMP()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.NJPFOLPMDIA(customersCapacity);
		int num3 = TavernReputation.DGJJJOKJJII(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Items/item_name_691") + "Items/item_description_596";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NGPDFPDGOMP();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("\n");
		string[] array = new string[1];
		array[1] = ((num3 < 1) ? "Items/item_name_1153" : "pauseMenuRoomCode") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/19/Dialogue Text");
		string[] array2 = new string[0];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("Sending mine loaded for client ");
		string[] array3 = new string[0];
		array3[0] = ((num3 < 1) ? "ReceiveEnableInputByProximty" : "Items/item_name_696") + Mathf.Abs((int)Money.LFGAEJGCLOP()) + "Run";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		((TMP_Text)totalCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error instantiating placeable from message of type "), weekStats.customersCount.ToString());
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("<b><color=#9A3F00>");
		string[] array4 = new string[0];
		array4[0] = weekStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("Pause");
		string[] array5 = new string[0];
		array5[1] = weekStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("yForYears");
		string[] array6 = new string[0];
		array6[0] = Price.OMDBJINNHPC(weekStats.PEOALHKFCCI()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = staffCost;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Perks/playerPerk_name_");
		string[] array7 = new string[1];
		array7[1] = Price.HNDGIKFAKNC(weekStats.CJKCMDOAACL()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		((TMP_Text)profit).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveRequestPlayerInventory"), Price.GHDCKOJGAMM(weekStats.IDHNDMEALOC()).ToString());
		weekStats = TavernServiceManager.GGFJGHHHEJC.FEPCCIHJPEH();
		TextMeshProUGUI obj10 = totalCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("City/Amos/Bark/Buy");
		string[] array8 = new string[1];
		array8[1] = weekStats.customersCount.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = satisfiedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("00");
		string[] array9 = new string[0];
		array9[1] = weekStats.satisfiedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = kickedCustomersTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Dialogue System/Conversation/TavernClean/Entry/2/Dialogue Text");
		string[] array10 = new string[0];
		array10[1] = weekStats.kickedCustomers.ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = incomeTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Items/item_name_1191");
		string[] array11 = new string[0];
		array11[1] = Price.HNDGIKFAKNC(weekStats.BBGAGHCGFIA()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = staffCostTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Invalid playerNum");
		string[] array12 = new string[0];
		array12[1] = Price.OMDBJINNHPC(weekStats.JFMHFLCLONK()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
		TextMeshProUGUI obj15 = profitTotal;
		string cAEDMEDBEGI13 = LocalisationSystem.Get("Sergi");
		string[] array13 = new string[0];
		array13[0] = Price.GHDCKOJGAMM(weekStats.OPHHBNHEDJD()).ToString();
		((TMP_Text)obj15).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI13, array13);
	}

	public static TavernStatsUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void ICMBHNLFHNK()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.JFJOKGAOPHA().LHIGMKAJBHO();
		float num = tavernStats.HJOLFKOLLED();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1301f) / 1587f);
		progressor.NEJPLMCPNPJ(Mathf.Clamp01((num + 404f) / 1891f));
		int customersCapacity = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.NDELBFMHKEO(customersCapacity);
		int num3 = TavernReputation.GLAOJNJNPBA(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("MayaMinigames") + "Crafting ";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NGPDFPDGOMP();
		}
		((TMP_Text)plusCapacitySatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_name_1113"), ((num3 < 1) ? "Items/item_description_10000" : "Next Item") + Mathf.Abs(num3));
		((TMP_Text)maximumCapacity).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveTableMessage"), (num2 + num3).ToString());
		TextMeshProUGUI obj3 = plusPricesSatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("[<#FFFF80>");
		string[] array = new string[1];
		array[1] = ((num3 < 1) ? "waiting for path" : "Kick out") + Mathf.Abs((int)Money.IKCAKMALNFI()) + "tutorialPopUp77";
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = totalCustomers;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Stand/Entry/7/Dialogue Text");
		string[] array2 = new string[1];
		array2[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((TMP_Text)satisfiedCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("levelRequired"), tavernStats.satisfiedCustomers.ToString());
		TextMeshProUGUI obj5 = kickedCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("Spring");
		string[] array3 = new string[0];
		array3[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = income;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("UIInteract");
		string[] array4 = new string[0];
		array4[0] = Price.LEDHAKFAHCI(tavernStats.KNCPKKELNMH()).ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = staffCost;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("ReceiveAnimalIncreaseProduction");
		string[] array5 = new string[0];
		array5[0] = Price.GHDCKOJGAMM(tavernStats.MOLDAHJBJJJ()).ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = profit;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Received {0} appearance data as byte array: {1}");
		string[] array6 = new string[0];
		array6[0] = Price.IFMFKEMHHLM(tavernStats.OPHHBNHEDJD()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		tavernStats = TavernServiceManager.JCMKNNOEONP().EECBOPOPEME();
		TextMeshProUGUI obj9 = totalCustomersTotal;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Building");
		string[] array7 = new string[0];
		array7[0] = tavernStats.customersCount.ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		TextMeshProUGUI obj10 = satisfiedCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("Items/item_name_1082");
		string[] array8 = new string[0];
		array8[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = kickedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("\n<color=#3662B5>");
		string[] array9 = new string[1];
		array9[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("subject");
		string[] array10 = new string[0];
		array10[1] = Price.HNDGIKFAKNC(tavernStats.HHLECEBEBLE()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		((TMP_Text)staffCostTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("not target 1"), Price.GHDCKOJGAMM(tavernStats.FBHMEPBENPG()).ToString());
		TextMeshProUGUI obj13 = profitTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Use");
		string[] array11 = new string[0];
		array11[1] = Price.GHDCKOJGAMM(tavernStats.KFGJAIKDCKI()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
	}

	public void MLLIKCKMHOO()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.AFFGPMFKEFH().EOFNOMOANHG();
		float num = tavernStats.GKONFHHNLEL();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1878f) / 584f);
		progressor.LNJHLLABNNI(Mathf.Clamp01((num + 655f) / 289f));
		int customersCapacity = ReputationDBAccessor.JDEAGDHJENF(TavernReputation.NGPDFPDGOMP()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.NDELBFMHKEO(customersCapacity);
		int num3 = TavernReputation.IIKECMJHCGO(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("ReceiveImproveFeeder") + "talentSoup";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NHHLJLADGBF();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Item nulo en el índice {0}.");
		string[] array = new string[1];
		array[1] = ((num3 < 1) ? "itemPineapple" : "{0}    └─ ... ({1} hijo(s) no expandido(s))") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Error_Money");
		string[] array2 = new string[1];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((TMP_Text)plusPricesSatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Dialogue System/Conversation/Rowdy/Entry/6/Dialogue Text"), ((num3 < 1) ? "Play" : "PlayerCharacterGenderChangeRPC") + Mathf.Abs((int)Money.GetPlusPricesSatisfaction()) + "SetAnimationControllerIndexesRPC");
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceiveKick");
		string[] array3 = new string[1];
		array3[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("Fortitude/MainEvent 6");
		string[] array4 = new string[0];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("Dots");
		string[] array5 = new string[0];
		array5[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("ActionBar8");
		string[] array6 = new string[0];
		array6[0] = Price.OMDBJINNHPC(tavernStats.PCHFHKDEEDC()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		((TMP_Text)staffCost).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveAddAvailableQuestToCurrentQuest"), Price.LEDHAKFAHCI(tavernStats.staffCost).ToString());
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("QuestInfoButton");
		string[] array7 = new string[0];
		array7[0] = Price.HNDGIKFAKNC(tavernStats.MMADKKEJLEM()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		tavernStats = TavernServiceManager.HKBJIIJHBJB().EECBOPOPEME();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error in DogRelationship.CheckRelationship: "), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj10 = satisfiedCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("UIBack");
		string[] array8 = new string[0];
		array8[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = kickedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get(" with less than 6 food");
		string[] array9 = new string[0];
		array9[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		((TMP_Text)incomeTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("application/gzip"), Price.OMDBJINNHPC(tavernStats.totalIncome).ToString());
		TextMeshProUGUI obj12 = staffCostTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("selected_objects");
		string[] array10 = new string[0];
		array10[1] = Price.LEDHAKFAHCI(tavernStats.KOIHGNEIHGC()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = profitTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/46/Dialogue Text");
		string[] array11 = new string[0];
		array11[0] = Price.HNDGIKFAKNC(tavernStats.profit).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
	}

	public void LGGCLBCKIIE()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.AFFGPMFKEFH().JIHKFAMAPKM();
		float num = tavernStats.GINNLNKJHKB();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1629f) / 1720f);
		progressor.PKGEJPPEPEC(Mathf.Clamp01((num + 1476f) / 326f));
		int customersCapacity = ReputationDBAccessor.NGLFLAGLBCO(TavernReputation.NHHLJLADGBF()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.GetPerksBonus(customersCapacity);
		int num3 = TavernReputation.IIKECMJHCGO(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("%>") + "disconnect";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.IHGJJNNHNCB();
		}
		((TMP_Text)plusCapacitySatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("UIPreviousCategory"), ((num3 < 1) ? "ReceiveEnable" : "Dialogue System/Conversation/BirdPositiveComments/Entry/6/Dialogue Text") + Mathf.Abs(num3));
		TextMeshProUGUI obj3 = maximumCapacity;
		string cAEDMEDBEGI = LocalisationSystem.Get(" ");
		string[] array = new string[0];
		array[0] = (num2 + num3).ToString();
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = plusPricesSatisfaction;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Fish");
		string[] array2 = new string[0];
		array2[1] = ((num3 < 1) ? "add item " : "UINextCategory") + Mathf.Abs((int)Money.LFGAEJGCLOP()) + "Crowly_Introduce";
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("Too far away");
		string[] array3 = new string[0];
		array3[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("LE_12");
		string[] array4 = new string[1];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("");
		string[] array5 = new string[0];
		array5[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Resolucion: ");
		string[] array6 = new string[0];
		array6[1] = Price.HNDGIKFAKNC(tavernStats.PCHFHKDEEDC()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = staffCost;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Could not check current game language for reason ");
		string[] array7 = new string[0];
		array7[1] = Price.IFMFKEMHHLM(tavernStats.NBGIOFJKHAO()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		((TMP_Text)profit).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Backache"), Price.GHDCKOJGAMM(tavernStats.ENIKHJOHEMD()).ToString());
		tavernStats = TavernServiceManager.GGFJGHHHEJC.DNABCIBOMEB();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Collect"), tavernStats.customersCount.ToString());
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("add item 1440"), tavernStats.satisfiedCustomers.ToString());
		TextMeshProUGUI obj10 = kickedCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("quest_name_29");
		string[] array8 = new string[0];
		array8[0] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		((TMP_Text)incomeTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("HostDisconnected"), Price.HNDGIKFAKNC(tavernStats.MOFFLOPPOHA()).ToString());
		((TMP_Text)staffCostTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Chest opened, granting loot to player "), Price.GHDCKOJGAMM(tavernStats.LOLIHJLHIOE()).ToString());
		TextMeshProUGUI obj11 = profitTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/2/Dialogue Text");
		string[] array9 = new string[0];
		array9[0] = Price.DHMGJGHCCJD(tavernStats.AOHFEBCDOJO()).ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
	}

	public void IJFGFCMJBML()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.LHKFIDJFPDB().EJFGMOAICOB();
		float num = tavernStats.ALNCFLFIBGD();
		sliderSatisfaction.value = Mathf.Clamp01((num + 415f) / 297f);
		progressor.HADLIKGKHOK(Mathf.Clamp01((num + 1600f) / 947f));
		int customersCapacity = ReputationDBAccessor.GetReputation(TavernReputation.NGPDFPDGOMP()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.DPJPMECIAIN(customersCapacity);
		int num3 = TavernReputation.IIKECMJHCGO(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("VerticalMove") + "Reserve";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.GetMilestoneMaster();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("You have to use the PixelPerfectCamera script on the assigned UI camera!");
		string[] array = new string[0];
		array[1] = ((num3 < 1) ? "Advanced" : "ReceiveNinjaChallengeEventIntroJudge") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("New Player added as player ");
		string[] array2 = new string[0];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((TMP_Text)plusPricesSatisfaction).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("tutorialPopUp82"), ((num3 < 0) ? "depth{0}" : "Dialogue System/Conversation/Crowly_Introduce/Entry/8/Dialogue Text") + Mathf.Abs((int)Money.IKCAKMALNFI()) + "ReceiveEnable");
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceiveResetAllTalents");
		string[] array3 = new string[0];
		array3[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("Rest");
		string[] array4 = new string[1];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("ReceiveNinjaSoundPreparation");
		string[] array5 = new string[0];
		array5[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("quest_description_20");
		string[] array6 = new string[0];
		array6[0] = Price.IFMFKEMHHLM(tavernStats.AHHKGIAMACN()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		((TMP_Text)staffCost).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("talentPale"), Price.GHDCKOJGAMM(tavernStats.KOIHGNEIHGC()).ToString());
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Try to create private room");
		string[] array7 = new string[1];
		array7[1] = Price.LEDHAKFAHCI(tavernStats.APMGAOOAAHD()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		tavernStats = TavernServiceManager.GGFJGHHHEJC.KLECMHBJFHO();
		((TMP_Text)totalCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("/Male/"), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj10 = satisfiedCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("Player");
		string[] array8 = new string[0];
		array8[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = kickedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("Incorrect room mode {0}");
		string[] array9 = new string[0];
		array9[0] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("HollyAnimalShop");
		string[] array10 = new string[1];
		array10[1] = Price.OMDBJINNHPC(tavernStats.JDJJGNFOJPA()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = staffCostTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Disappear");
		string[] array11 = new string[1];
		array11[1] = Price.LEDHAKFAHCI(tavernStats.KJCJFIPEOKE()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = profitTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("End");
		string[] array12 = new string[0];
		array12[1] = Price.DHMGJGHCCJD(tavernStats.JOKAMMNDLFB()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
	}

	public static TavernStatsUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static TavernStatsUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JKEABELKIFF()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.LKOABOAADCD().MFLFCJKAMOA();
		float num = tavernStats.AOHJJBBJAAJ();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1654f) / 159f);
		progressor.NFBOLMFKKLL(Mathf.Clamp01((num + 342f) / 489f));
		int customersCapacity = ReputationDBAccessor.ELGJADBKMPB(TavernReputation.NGPDFPDGOMP()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.DPJPMECIAIN(customersCapacity);
		int num3 = TavernReputation.IIKECMJHCGO(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Square") + "ReceiveResetAllPlayersPrepared";
		if (OnlineManager.PGAGDFAEEFB())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NGPDFPDGOMP();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Attack/MainEvent");
		string[] array = new string[1];
		array[1] = ((num3 < 0) ? "{" : "Dialogue System/Conversation/Crowly_Standar/Entry/41/Dialogue Text") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/2/Dialogue Text");
		string[] array2 = new string[1];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceiveDoWorkUpdate");
		string[] array3 = new string[0];
		array3[0] = ((num3 < 0) ? "Lightning" : "ActionBar3") + Mathf.Abs((int)Money.GetPlusPricesSatisfaction()) + "ReceiveShopInfoLoad";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		((TMP_Text)totalCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ThemeText"), tavernStats.customersCount.ToString());
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("Player/Bark/Tutorial/CantDoYet");
		string[] array4 = new string[0];
		array4[0] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("Drink");
		string[] array5 = new string[0];
		array5[0] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		((TMP_Text)income).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Accept order"), Price.HNDGIKFAKNC(tavernStats.HDHGNIOOIDG()).ToString());
		TextMeshProUGUI obj8 = staffCost;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("AdoptQuest");
		string[] array6 = new string[0];
		array6[1] = Price.HNDGIKFAKNC(tavernStats.KOIHGNEIHGC()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Nature");
		string[] array7 = new string[0];
		array7[0] = Price.DHMGJGHCCJD(tavernStats.PFKHMNLNHHP()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		tavernStats = TavernServiceManager.JCMKNNOEONP().EECBOPOPEME();
		TextMeshProUGUI obj10 = totalCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("Items/item_name_672");
		string[] array8 = new string[1];
		array8[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = satisfiedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("OnlinePlayer");
		string[] array9 = new string[1];
		array9[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		((TMP_Text)kickedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("generate forest"), tavernStats.kickedCustomers.ToString());
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Door animation error: currentAnimationSprites is null");
		string[] array10 = new string[0];
		array10[1] = Price.OMDBJINNHPC(tavernStats.HDHGNIOOIDG()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = staffCostTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Puente_EA/Talk 2");
		string[] array11 = new string[0];
		array11[0] = Price.LEDHAKFAHCI(tavernStats.NBGIOFJKHAO()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = profitTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Player");
		string[] array12 = new string[0];
		array12[1] = Price.DHMGJGHCCJD(tavernStats.AGIKOCCIKAL()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
	}

	public void BGMBOPMNFPA()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.JCMKNNOEONP().MFLFCJKAMOA();
		float num = tavernStats.NDLLBAAIALP();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1007f) / 1582f);
		progressor.OHNGIDACMMM(Mathf.Clamp01((num + 46f) / 680f));
		int customersCapacity = ReputationDBAccessor.EICFONMDOBM(TavernReputation.GetMilestoneMaster()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.MCNAGDKKOHJ(customersCapacity);
		int num3 = TavernReputation.GLAOJNJNPBA(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Items/item_name_666") + "Dialogue System/Conversation/BirdNegativeComments/Entry/10/Dialogue Text";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NHHLJLADGBF();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("UIInteract");
		string[] array = new string[0];
		array[1] = ((num3 < 0) ? "ReceiveSetDirtiness" : "></size>") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("NormalRight");
		string[] array2 = new string[1];
		array2[1] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("Error_RoomIndependent");
		string[] array3 = new string[0];
		array3[0] = ((num3 < 1) ? "Hikari/Introduce" : "Struggle") + Mathf.Abs((int)Money.AKDMDDGHKHG()) + "Aged";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = totalCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("LE_16");
		string[] array4 = new string[1];
		array4[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = satisfiedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("CharacterChanged");
		string[] array5 = new string[0];
		array5[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = kickedCustomers;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("???");
		string[] array6 = new string[0];
		array6[0] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = income;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("0");
		string[] array7 = new string[0];
		array7[1] = Price.DHMGJGHCCJD(tavernStats.DKIIOFHEBMK()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		TextMeshProUGUI obj10 = staffCost;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("itemStout");
		string[] array8 = new string[1];
		array8[1] = Price.HNDGIKFAKNC(tavernStats.LCPGMBPNJNL()).ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = profit;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("[Action");
		string[] array9 = new string[1];
		array9[1] = Price.IFMFKEMHHLM(tavernStats.MIKHHMENHIO()).ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		tavernStats = TavernServiceManager.JCMKNNOEONP().MADKEKPNKDN();
		TextMeshProUGUI obj12 = totalCustomersTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Invalid player num");
		string[] array10 = new string[0];
		array10[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = satisfiedCustomersTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Hot");
		string[] array11 = new string[1];
		array11[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = kickedCustomersTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("popUpBuilding23");
		string[] array12 = new string[0];
		array12[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
		((TMP_Text)incomeTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" not found in OnlineEventsManager."), Price.IFMFKEMHHLM(tavernStats.KCNPPAKPNKG()).ToString());
		TextMeshProUGUI obj15 = staffCostTotal;
		string cAEDMEDBEGI13 = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text");
		string[] array13 = new string[1];
		array13[1] = Price.LEDHAKFAHCI(tavernStats.KOIHGNEIHGC()).ToString();
		((TMP_Text)obj15).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI13, array13);
		((TMP_Text)profitTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" : 00"), Price.IFMFKEMHHLM(tavernStats.AGIKOCCIKAL()).ToString());
	}

	public void OKGDAKCEIFN()
	{
		TavernServiceManager.TavernStats weekStats = TavernServiceManager.IFPLPBMCKLB().GetWeekStats();
		float num = weekStats.JFDIIECJBGP();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1963f) / 378f);
		progressor.CLAENEBEIMH(Mathf.Clamp01((num + 829f) / 687f));
		int customersCapacity = ReputationDBAccessor.EICFONMDOBM(TavernReputation.NHHLJLADGBF()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.NJPFOLPMDIA(customersCapacity);
		int num3 = TavernReputation.DGJJJOKJJII(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Loading tavern floor tiles") + "Explode";
		if (OnlineManager.PGAGDFAEEFB())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.NGPDFPDGOMP();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Book");
		string[] array = new string[1];
		array[1] = ((num3 < 1) ? "UISelectGamepad" : "veggieDishes") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("MineFloor");
		string[] array2 = new string[0];
		array2[0] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("psai: successfully auto-assigned Player Collider in component {0}");
		string[] array3 = new string[1];
		array3[1] = ((num3 < 0) ? "Interact" : ":") + Mathf.Abs((int)Money.AKDMDDGHKHG()) + "Editor action without ID: ";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = totalCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("ReceiveAddDrink");
		string[] array4 = new string[1];
		array4[1] = weekStats.customersCount.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = satisfiedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("ReceiveEggIncrement");
		string[] array5 = new string[0];
		array5[1] = weekStats.satisfiedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		((TMP_Text)kickedCustomers).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Intro13"), weekStats.kickedCustomers.ToString());
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("</color>");
		string[] array6 = new string[1];
		array6[1] = Price.DHMGJGHCCJD(weekStats.JDJJGNFOJPA()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		((TMP_Text)staffCost).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("fishDishes"), Price.DHMGJGHCCJD(weekStats.FGEONIFMODF()).ToString());
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Recipe ");
		string[] array7 = new string[0];
		array7[0] = Price.GHDCKOJGAMM(weekStats.ENIKHJOHEMD()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		weekStats = TavernServiceManager.IFPLPBMCKLB().GetAllTimeStats();
		TextMeshProUGUI obj10 = totalCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("ReceiveIdleAtTable");
		string[] array8 = new string[1];
		array8[1] = weekStats.customersCount.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Items/item_name_668"), weekStats.satisfiedCustomers.ToString());
		TextMeshProUGUI obj11 = kickedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("itemBlackWort");
		string[] array9 = new string[1];
		array9[1] = weekStats.kickedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = incomeTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("NinjaChallengeEvent/Main 2");
		string[] array10 = new string[0];
		array10[0] = Price.LEDHAKFAHCI(weekStats.AOJLLPFGLIM()).ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = staffCostTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Animator is null or has been destroyed.");
		string[] array11 = new string[1];
		array11[1] = Price.OMDBJINNHPC(weekStats.COBPEOBGBIB()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = profitTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("ReceiveRequestChristmasEvent");
		string[] array12 = new string[0];
		array12[1] = Price.HNDGIKFAKNC(weekStats.FCPDLCMPEHB()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
	}

	public void NCGPMCEAFPI()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.GGFJGHHHEJC.DAKEIGNBBBD();
		float num = tavernStats.CGAFPKJMDFJ();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1161f) / 1543f);
		progressor.CLEMOMEPLID(Mathf.Clamp01((num + 1086f) / 330f));
		int customersCapacity = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestoneMaster()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.GetPerksBonus(customersCapacity);
		int customersExtraPerService = TavernReputation.GetCustomersExtraPerService(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get("Deserialize SettingsData error: /ExtraSettings.sd") + "ReceiveRoomRequest";
		if (OnlineManager.PGAGDFAEEFB())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.GetMilestone();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.GetMilestoneMaster();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Angry");
		string[] array = new string[0];
		array[0] = ((customersExtraPerService < 0) ? "Items/item_description_652" : "popUpBuilding25") + Mathf.Abs(customersExtraPerService);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)maximumCapacity).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("<color=#713112>"), (num2 + customersExtraPerService).ToString());
		TextMeshProUGUI obj4 = plusPricesSatisfaction;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("FloorTiles");
		string[] array2 = new string[0];
		array2[1] = ((customersExtraPerService < 0) ? "Sprite Info without ID: " : "Dialogue System/Conversation/TavernClean/Entry/3/Dialogue Text") + Mathf.Abs((int)Money.LFGAEJGCLOP()) + "Cat";
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = totalCustomers;
		string cAEDMEDBEGI3 = LocalisationSystem.Get("RequiresAging");
		string[] array3 = new string[1];
		array3[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = satisfiedCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/25/Dialogue Text");
		string[] array4 = new string[1];
		array4[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = kickedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("Interact");
		string[] array5 = new string[0];
		array5[0] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = income;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Make bed");
		string[] array6 = new string[0];
		array6[0] = Price.LEDHAKFAHCI(tavernStats.PCHFHKDEEDC()).ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		((TMP_Text)staffCost).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player2"), Price.LEDHAKFAHCI(tavernStats.ODAAGPAAIPL()).ToString());
		TextMeshProUGUI obj9 = profit;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Error/");
		string[] array7 = new string[0];
		array7[0] = Price.IFMFKEMHHLM(tavernStats.HFPLLGHODIB()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		tavernStats = TavernServiceManager.IFPLPBMCKLB().MIJGBJJBGIB();
		TextMeshProUGUI obj10 = totalCustomersTotal;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text");
		string[] array8 = new string[1];
		array8[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = satisfiedCustomersTotal;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("ProceduralMine instance is null when trying to assign mine ID.");
		string[] array9 = new string[0];
		array9[1] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		TextMeshProUGUI obj12 = kickedCustomersTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("TorchPuzzle requires TorchPuzzleSettings");
		string[] array10 = new string[1];
		array10[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		TextMeshProUGUI obj13 = incomeTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("Items/item_name_728");
		string[] array11 = new string[0];
		array11[0] = Price.HNDGIKFAKNC(tavernStats.LPMMGLOHEEB()).ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = staffCostTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Tutorial/T120/Dialogue1");
		string[] array12 = new string[0];
		array12[0] = Price.OMDBJINNHPC(tavernStats.LCPGMBPNJNL()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
		((TMP_Text)profitTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("City/Rhia/Introduce"), Price.OMDBJINNHPC(tavernStats.KFGJAIKDCKI()).ToString());
	}

	public void IHOEEAHBCCF()
	{
		TavernServiceManager.TavernStats tavernStats = TavernServiceManager.LKOABOAADCD().EJFGMOAICOB();
		float num = tavernStats.BFCGBHECKHM();
		sliderSatisfaction.value = Mathf.Clamp01((num + 1167f) / 1803f);
		progressor.BHGJPBGINCG = Mathf.Clamp01((num + 394f) / 1618f);
		int customersCapacity = ReputationDBAccessor.ELGJADBKMPB(TavernReputation.NHHLJLADGBF()).customersCapacity;
		int num2 = customersCapacity + TavernReputation.NJPFOLPMDIA(customersCapacity);
		int num3 = TavernReputation.IIKECMJHCGO(num2, num);
		((TMP_Text)tavernName).text = PlayerInfo.tavernName;
		((TMP_Text)reputation).text = LocalisationSystem.Get(" not found. Cannot receive permission accepted to player ") + "Player2";
		if (OnlineManager.MasterOrOffline())
		{
			TextMeshProUGUI obj = reputation;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + TavernReputation.MHGADJPMHFI();
		}
		else
		{
			TextMeshProUGUI obj2 = reputation;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + TavernReputation.IHGJJNNHNCB();
		}
		TextMeshProUGUI obj3 = plusCapacitySatisfaction;
		string cAEDMEDBEGI = LocalisationSystem.Get("Xbox");
		string[] array = new string[1];
		array[1] = ((num3 < 0) ? "\n<color=#822F00>" : "Tutorial Disabled") + Mathf.Abs(num3);
		((TMP_Text)obj3).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		TextMeshProUGUI obj4 = maximumCapacity;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("talentGreens");
		string[] array2 = new string[0];
		array2[0] = (num2 + num3).ToString();
		((TMP_Text)obj4).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		TextMeshProUGUI obj5 = plusPricesSatisfaction;
		string cAEDMEDBEGI3 = LocalisationSystem.Get(" not found. Cannot receive permission accepted to player ");
		string[] array3 = new string[1];
		array3[1] = ((num3 < 0) ? "change season" : "On") + Mathf.Abs((int)Money.LFGAEJGCLOP()) + "Dialogue System/Conversation/BirdNegativeComments/Entry/14/Dialogue Text";
		((TMP_Text)obj5).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		TextMeshProUGUI obj6 = totalCustomers;
		string cAEDMEDBEGI4 = LocalisationSystem.Get("HalloweenEvent");
		string[] array4 = new string[0];
		array4[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj6).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		TextMeshProUGUI obj7 = satisfiedCustomers;
		string cAEDMEDBEGI5 = LocalisationSystem.Get("talentLager");
		string[] array5 = new string[0];
		array5[0] = tavernStats.satisfiedCustomers.ToString();
		((TMP_Text)obj7).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI5, array5);
		TextMeshProUGUI obj8 = kickedCustomers;
		string cAEDMEDBEGI6 = LocalisationSystem.Get("Multiplayer");
		string[] array6 = new string[1];
		array6[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj8).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI6, array6);
		TextMeshProUGUI obj9 = income;
		string cAEDMEDBEGI7 = LocalisationSystem.Get("Player");
		string[] array7 = new string[0];
		array7[0] = Price.HNDGIKFAKNC(tavernStats.ILEHPKLDILP()).ToString();
		((TMP_Text)obj9).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI7, array7);
		TextMeshProUGUI obj10 = staffCost;
		string cAEDMEDBEGI8 = LocalisationSystem.Get("");
		string[] array8 = new string[0];
		array8[0] = Price.IFMFKEMHHLM(tavernStats.LNFMOPIKHGN()).ToString();
		((TMP_Text)obj10).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI8, array8);
		TextMeshProUGUI obj11 = profit;
		string cAEDMEDBEGI9 = LocalisationSystem.Get("ReceiveInfoWorldTiles");
		string[] array9 = new string[0];
		array9[1] = Price.DHMGJGHCCJD(tavernStats.AGIKOCCIKAL()).ToString();
		((TMP_Text)obj11).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI9, array9);
		tavernStats = TavernServiceManager.JCMKNNOEONP().GetAllTimeStats();
		TextMeshProUGUI obj12 = totalCustomersTotal;
		string cAEDMEDBEGI10 = LocalisationSystem.Get("Toy");
		string[] array10 = new string[0];
		array10[1] = tavernStats.customersCount.ToString();
		((TMP_Text)obj12).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI10, array10);
		((TMP_Text)satisfiedCustomersTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Shield"), tavernStats.satisfiedCustomers.ToString());
		TextMeshProUGUI obj13 = kickedCustomersTotal;
		string cAEDMEDBEGI11 = LocalisationSystem.Get("OnlinePlayer");
		string[] array11 = new string[0];
		array11[1] = tavernStats.kickedCustomers.ToString();
		((TMP_Text)obj13).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI11, array11);
		TextMeshProUGUI obj14 = incomeTotal;
		string cAEDMEDBEGI12 = LocalisationSystem.Get("Right Stick Up");
		string[] array12 = new string[0];
		array12[1] = Price.DHMGJGHCCJD(tavernStats.DKIIOFHEBMK()).ToString();
		((TMP_Text)obj14).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI12, array12);
		((TMP_Text)staffCostTotal).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("iForInventory"), Price.DHMGJGHCCJD(tavernStats.staffCost).ToString());
		TextMeshProUGUI obj15 = profitTotal;
		string cAEDMEDBEGI13 = LocalisationSystem.Get("Items/item_description_1039");
		string[] array13 = new string[1];
		array13[1] = Price.LEDHAKFAHCI(tavernStats.BFCGJOJCKMH()).ToString();
		((TMP_Text)obj15).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI13, array13);
	}

	public static TavernStatsUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		base.OpenUI();
		UpdateInfo();
	}

	protected override void Start()
	{
		base.Start();
		UpdateInfo();
	}

	public static TavernStatsUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
