using TMPro;
using UnityEngine;

public class UpgradeRoomLockedUI : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI unlockText;

	public void MCIBPHCHFAB(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Item");
		string[] array = new string[0];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void PMOGLENNPEN(ReputationInfo LEJBKGLCNBM)
	{
		((TMP_Text)unlockText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Chilly"), LEJBKGLCNBM.repNumber.ToString());
	}

	public void BCPLGIJLLAD(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("tutorialPopUpCraftingChests");
		string[] array = new string[1];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void LOFNIECDBAF(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Player2");
		string[] array = new string[1];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void OGLAJAKDIPG(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("SendInitialPosition");
		string[] array = new string[0];
		array[0] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void JFHCPBJONGE(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Drink");
		string[] array = new string[0];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void LMFDGABDAKM(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get(" - Deactivating variant object ");
		string[] array = new string[0];
		array[0] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void LOEPFAHGDIA(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveSymbolPuzzleSolved");
		string[] array = new string[0];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void EIJFGACDMNK(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("City/Chuck/Bark/Buy");
		string[] array = new string[0];
		array[0] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void MNMPLAIEAPN(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Xbox");
		string[] array = new string[0];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void UpdateElement(ReputationInfo LEJBKGLCNBM)
	{
		((TMP_Text)unlockText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Unlocked at Tavern Reputation {0}"), LEJBKGLCNBM.repNumber.ToString());
	}

	public void OOKANHIBNDE(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/30/Dialogue Text");
		string[] array = new string[1];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}

	public void EHEOAKJDLCE(ReputationInfo LEJBKGLCNBM)
	{
		TextMeshProUGUI obj = unlockText;
		string cAEDMEDBEGI = LocalisationSystem.Get("stormy");
		string[] array = new string[0];
		array[1] = LEJBKGLCNBM.repNumber.ToString();
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
	}
}
