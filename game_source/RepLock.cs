using System;
using TMPro;
using UnityEngine;

public class RepLock : MonoBehaviour
{
	[SerializeField]
	private ReputationInfo reputationReward;

	[SerializeField]
	private TextMeshProUGUI unlockText;

	[SerializeField]
	private TextMeshProUGUI unlockText2;

	private void HJFEJJICHEM(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void NAOBODGBECL()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			((TMP_Text)unlockText).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("CraftingRoom") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Order quest"), reputationReward.repNumber.ToString()));
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj = unlockText2;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Chilly");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Items/item_description_1180");
			}
			((TMP_Text)obj).text = text;
		}
	}

	private void HFFCLOBDAAN(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void HFIDFNBPAHG(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	public bool OICFEBPEDDF()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return false;
		}
		return false;
	}

	private void KCLKEAHGGEK()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HFFCLOBDAAN));
	}

	private void GCAEICHCIMA()
	{
		DJHHDGGOEOO(TavernReputation.IHGJJNNHNCB());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KDNPGMADJIF));
	}

	private void ABJIPFAEENG()
	{
		ALGIJPLDNIG(TavernReputation.NHHLJLADGBF());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	public bool HJPCGJOKLBJ()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void CMEDJEGJLJN()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	private void IHNHDCLJDPJ(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void LCACEGAJGJA(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void IJMBEEEGCGF()
	{
		MPMKPIGFNCA(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(OKNFGGEGBHP));
	}

	private void FGLJPGBFPBC()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/TooHot/Entry/3/Dialogue Text");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("KentaProgress");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/10/Dialogue Text");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("Scene ");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void CDFMNDEKBJE()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(GAHMEHGCGHI));
	}

	private void OnDisable()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HJFEJJICHEM));
	}

	private void FPNPLFALPHP()
	{
		BODMIOLJIAA(TavernReputation.NHHLJLADGBF());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(EFEBBGGLDDP));
	}

	public bool EIEHDOHCAIN()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void NCFCFOKDGAB()
	{
		HFIDFNBPAHG(TavernReputation.NHHLJLADGBF());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(LHPADNJAGEE));
	}

	private void DIMAPDNCBAN()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Fill");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("ReceiveAnimalWalk");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("New states cannot be null.");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("BeginPirateMinigameRequest");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void INKEOMEDDKF(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void AIFOBFHCHGK()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(DJHHDGGOEOO));
	}

	private void PIHGEBONAOI()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			((TMP_Text)unlockText).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("SendRPC: '") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Masters/Klayn/Banquet"), reputationReward.repNumber.ToString()));
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj = unlockText2;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Pausing network sync until the world is loaded...");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("UIPreviousPage");
			}
			((TMP_Text)obj).text = text;
		}
	}

	public bool IFKJABFDICB()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return false;
	}

	private void FEPFNOEGFEM()
	{
		JAAEPHCCEGL(TavernReputation.IHGJJNNHNCB());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MBDIDMEIDDH));
	}

	private void FLOFJHNAIKP()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MGLPPFCKGPK));
	}

	private void LCJCGFNFBBD()
	{
		LHPADNJAGEE(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(JAAEPHCCEGL));
	}

	private void BPHGADINMAN()
	{
		MCMGCKOHFJH(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(DJHHDGGOEOO));
	}

	private void IFBKCNJGADL()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(GAHMEHGCGHI));
	}

	private void CIAIAEJIMCM()
	{
		MGLPPFCKGPK(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(BODMIOLJIAA));
	}

	private void KEJFJLKAHJI(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void JAAEPHCCEGL(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1104");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("OnlinePlayer");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Items/item_name_639") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("rain"), reputationReward.repNumber.ToString()));
		}
	}

	private void NDFDAHHHOPO(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void EDLFOKNNMFB(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	public bool IsLocked()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void IHICKHAABJH()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("NeutralInTavern");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("UIInteract");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("CultivableAllYearRound");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("TutorialPhase");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void AGLMGDNBHBF()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("alcoholContentWarning");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("TavernFilthy");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("intensity:") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Leave immediately"), reputationReward.repNumber.ToString()));
		}
	}

	private void MPMKPIGFNCA(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void FFHIGDJEFJE()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Floor_8");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("shake");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("IsKicked");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("UIInteract");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void MBDIDMEIDDH(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void AGAELOFMHBO(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void BKJFLMPOLCH()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MBDIDMEIDDH));
	}

	private void MGLPPFCKGPK(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void HJEOOBGDCMA()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HFFCLOBDAAN));
	}

	private void LHAPMEEADKH()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	private void PEFKNEPONAG()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("StartEvent can only be called in play mode.");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("SatisfiedCustomers");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("veggieDishes");
				string[] array2 = new string[1];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("Minning");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void EAMLHICIOMO()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(OLBLGFAONJA));
	}

	private void ADDLDNPHIHF()
	{
		AGAELOFMHBO(TavernReputation.NHHLJLADGBF());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(BODMIOLJIAA));
	}

	private void JCNPCJOBENP()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HFFCLOBDAAN));
	}

	private void KDNPGMADJIF(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	public bool OAEFBJOMEMN()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.MHGADJPMHFI() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void OnDestroy()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HJFEJJICHEM));
	}

	private void EFEBBGGLDDP(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void KNKILPPBEDC()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HJFEJJICHEM));
	}

	private void LDBBNBEBKLA()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MPMKPIGFNCA));
	}

	public bool ENMHKHBFJDA()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return true;
	}

	private void CHDGJHNBNEJ()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(PMACDCBOOLM));
	}

	private void KKNHADAMLFP()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			((TMP_Text)unlockText).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Items/item_description_1142") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("MainProgress"), reputationReward.repNumber.ToString()));
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj = unlockText2;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/15/Dialogue Text");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("/");
			}
			((TMP_Text)obj).text = text;
		}
	}

	public bool ICNKILNPOPA()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.MHGADJPMHFI() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void IIPKPMPGLOL()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("[^0-9]");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get(" : 00");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Interact");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("Sit");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void AFCIKJPPLFA()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(LHPADNJAGEE));
	}

	private void COKBJNMAMDI()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("ReciveHollyDirectionForTutorial");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("UIAddRemove");
				string[] array2 = new string[1];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("BuzzProgress");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void BNFGHAGJEGG()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("File with ID ");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Place");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Intensity: ") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player/Bark/Tutorial/T137"), reputationReward.repNumber.ToString()));
		}
	}

	public bool MBHADOMMFDK()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.MHGADJPMHFI() >= reputationReward.repNumber)
		{
			return false;
		}
		return false;
	}

	private void HKJCLFHCMKC()
	{
		EFEBBGGLDDP(TavernReputation.IHGJJNNHNCB());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(INKEOMEDDKF));
	}

	private void NLHALEAEDMM()
	{
		KDNPGMADJIF(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(LCACEGAJGJA));
	}

	private void LBFFMGAKDFG()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(GGJHBKFFDPP));
	}

	private void HBEBKMNGLBJ()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(AMIPPOIJKIP));
	}

	public bool NDDGMAJHNGN()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return false;
	}

	private void AMIPPOIJKIP(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void GMLHHLMOLBH()
	{
		GGJHBKFFDPP(TavernReputation.GetMilestoneMaster());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(ALGIJPLDNIG));
	}

	private void OHOHFGMJGAJ()
	{
		LHPADNJAGEE(TavernReputation.GetMilestoneMaster());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MGLPPFCKGPK));
	}

	private void GGIJFBAJLIF()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KEJFJLKAHJI));
	}

	public bool KAPONALJPIE()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return true;
	}

	private void FBOGKDNKPIO()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HFIDFNBPAHG));
	}

	private void LHPADNJAGEE(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void FLFBLIOOLMA()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(DJHHDGGOEOO));
	}

	private void PMACDCBOOLM(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void IIDHODAONIJ()
	{
		MPMKPIGFNCA(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MCMGCKOHFJH));
	}

	private void JBBHDOMALDB()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(EFEBBGGLDDP));
	}

	private void HNNBAAJAHEN()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	public bool OCBBGFDOEHF()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.MHGADJPMHFI() >= reputationReward.repNumber)
		{
			return false;
		}
		return false;
	}

	private void JIAJFDKNJME()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("UIPreviousPage");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get(" (ONLINE) [master client] length: ");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("[PlayerGender=");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("Description of ");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("TreasureMapUI");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("SelectedNotFocused");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("\n") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Left Stick Button"), reputationReward.repNumber.ToString()));
		}
	}

	private void PPHEPODCNMK()
	{
		NAGBMODCLLP(TavernReputation.NHHLJLADGBF());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(INKEOMEDDKF));
	}

	private void GHEOLMMHFJC()
	{
		MCMGCKOHFJH(TavernReputation.NHHLJLADGBF());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MPMKPIGFNCA));
	}

	private void EIDJLHFAMIB()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(OKNFGGEGBHP));
	}

	public bool CIBAFHPDMFF()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.MHGADJPMHFI() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void Awake()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			((TMP_Text)unlockText).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Coming soon!") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Unlocked at Tavern Reputation {0}"), reputationReward.repNumber.ToString()));
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Coming soon!") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Unlocked at Tavern Reputation {0}"), reputationReward.repNumber.ToString()));
		}
	}

	private void KJPECNGCOKK()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			((TMP_Text)unlockText).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Idle") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceivInstantiateMiscellaneousHarvest"), reputationReward.repNumber.ToString()));
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj = unlockText2;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("itemRoastedChicken");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Items/item_name_1093");
			}
			((TMP_Text)obj).text = text;
		}
	}

	private void HFIHGHBLLAM()
	{
		KDNPGMADJIF(TavernReputation.IHGJJNNHNCB());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	private void OKHLEMPJONN()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get(":</color> ");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("UIAddRemove");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("itemRedPotato") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("- Loading "), reputationReward.repNumber.ToString()));
		}
	}

	private void DIGLPPFFKEC()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NDFDAHHHOPO));
	}

	public bool ADKKPIDICIL()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return false;
	}

	private void CHDEOJALBFK()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(EDLFOKNNMFB));
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Mine");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("itemDillSeeds");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Player/Bark/Tutorial/CantDoYet");
				string[] array2 = new string[0];
				array2[0] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get(":<color=#3a0603> +");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	public bool MPCPDOHKOFB()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return true;
	}

	public bool LLIPALHNJMN()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.MHGADJPMHFI() >= reputationReward.repNumber)
		{
			return true;
		}
		return false;
	}

	private void FDJIDOCMLHB()
	{
		HFIDFNBPAHG(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MGLPPFCKGPK));
	}

	private void CMDBLLMEBLG()
	{
		MBDIDMEIDDH(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(BODMIOLJIAA));
	}

	private void DJJENHCMCBN()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(KEJFJLKAHJI));
	}

	public bool CKPPHDCFAKB()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return false;
		}
		return true;
	}

	private void BDDBDNPCPGC()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(BODMIOLJIAA));
	}

	private void LPKHACNBCLA()
	{
		MGLPPFCKGPK(TavernReputation.GetMilestoneMaster());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(DJHHDGGOEOO));
	}

	private void KHCJDKHONPK()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Message queue is running");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/31/Dialogue Text");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("errorEmptyName");
				string[] array2 = new string[1];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("UI2");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	public bool POPICGPHNBB()
	{
		if ((Object)(object)reputationReward != (Object)null && TavernReputation.GetMilestone() >= reputationReward.repNumber)
		{
			return true;
		}
		return true;
	}

	private void DJHHDGGOEOO(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j++)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void OKNFGGEGBHP(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void GAHMEHGCGHI(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void INEOMPKPILM()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HFFCLOBDAAN));
	}

	private void DADPOICMNPI()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Frame Time Average: ");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("popUpBuilding10");
				string[] array2 = new string[0];
				array2[0] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("LicenciaDeApertura/KlaynDialogue 07");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void OGGJNBCJGCE()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(JAAEPHCCEGL));
	}

	private void NAGBMODCLLP(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void PGABAEGKPIG()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(JAAEPHCCEGL));
	}

	private void IGNEGEOPLOP()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			((TMP_Text)unlockText).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("</color><br>") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("No travel zone found for mine stairs destination "), reputationReward.repNumber.ToString()));
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj = unlockText2;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Collect");
				string[] array = new string[0];
				array[0] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Aged price");
			}
			((TMP_Text)obj).text = text;
		}
	}

	private void GGJHBKFFDPP(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void ODBDHFBMDAG()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(PMACDCBOOLM));
	}

	private void KLGCMMIKGIO()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("MineFloor");
				string[] array = new string[0];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("popUpBuilding17");
				string[] array2 = new string[0];
				array2[0] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("Received upgrade tool collect RPC");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void NKGMEMEACNN()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(BODMIOLJIAA));
	}

	private void ONNAGOCFJML()
	{
		EDLFOKNNMFB(TavernReputation.GetMilestoneMaster());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(MGLPPFCKGPK));
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Cheese ageing");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Generating new trends ");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			((TMP_Text)unlockText2).text = (((Object)(object)reputationReward == (Object)null) ? LocalisationSystem.Get("Collect") : InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player"), reputationReward.repNumber.ToString()));
		}
	}

	private void ALGIJPLDNIG(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 0; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void OnEnable()
	{
		HJFEJJICHEM(TavernReputation.GetMilestoneMaster());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(HJFEJJICHEM));
	}

	private void OLBLGFAONJA(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void AGELAMLCINB()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Farm/Event/RegañinaViolet");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get("Items/item_description_596");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get(")");
				string[] array2 = new string[0];
				array2[1] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get("report_type");
			}
			((TMP_Text)obj2).text = text2;
		}
	}

	private void MKGKKAJHLAO()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	private void KJJAGKNOFIG()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(EFEBBGGLDDP));
	}

	private void OJLGPAJPCHG()
	{
		KEJFJLKAHJI(TavernReputation.NGPDFPDGOMP());
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Combine(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(NAGBMODCLLP));
	}

	private void BODMIOLJIAA(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 1; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(false);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(false);
			}
		}
	}

	private void HPOMPFNHGHN()
	{
		TavernReputation.OnTavernRepMilestoneChanged = (Action<int>)Delegate.Remove(TavernReputation.OnTavernRepMilestoneChanged, new Action<int>(EDLFOKNNMFB));
	}

	private void MCMGCKOHFJH(int NALJEKOPKIA)
	{
		if ((Object)(object)reputationReward != (Object)null && NALJEKOPKIA >= reputationReward.repNumber)
		{
			for (int i = 0; i < ((Component)this).transform.childCount; i++)
			{
				if (((Component)((Component)this).transform.GetChild(i)).gameObject.activeSelf)
				{
					((Component)((Component)this).transform.GetChild(i)).gameObject.SetActive(true);
				}
			}
			return;
		}
		for (int j = 1; j < ((Component)this).transform.childCount; j += 0)
		{
			if (!((Component)((Component)this).transform.GetChild(j)).gameObject.activeSelf)
			{
				((Component)((Component)this).transform.GetChild(j)).gameObject.SetActive(true);
			}
		}
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)unlockText != (Object)null)
		{
			TextMeshProUGUI obj = unlockText;
			string text;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI = LocalisationSystem.Get("Miners/Mine/Ferro/Stand");
				string[] array = new string[1];
				array[1] = reputationReward.repNumber.ToString();
				text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				text = LocalisationSystem.Get(" ");
			}
			((TMP_Text)obj).text = text;
		}
		if ((Object)(object)unlockText2 != (Object)null)
		{
			TextMeshProUGUI obj2 = unlockText2;
			string text2;
			if (!((Object)(object)reputationReward == (Object)null))
			{
				string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/13/Dialogue Text");
				string[] array2 = new string[0];
				array2[0] = reputationReward.repNumber.ToString();
				text2 = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
			else
			{
				text2 = LocalisationSystem.Get(" added to delivery chest");
			}
			((TMP_Text)obj2).text = text2;
		}
	}
}
