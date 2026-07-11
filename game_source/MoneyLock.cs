using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PopUpTrigger))]
[RequireComponent(typeof(Collider2D))]
public class MoneyLock : ContentLock
{
	[CompilerGenerated]
	private sealed class OJJKIIPNFLL
	{
		public MoneyLock _003C_003E4__this;

		public int playerNum;

		internal void AGPJOAAKHII()
		{
			_003C_003E4__this.LAKAMCEKHPI(playerNum);
		}
	}

	[SerializeField]
	private string contentToLocalise;

	public Quest requiredQuest;

	public ReputationInfo requiredRep;

	[SerializeField]
	private Price requirement;

	private string KEJPBACDIDE = "contentUnlock";

	private string MDIFGBAFFLI = "contentLockMessage";

	private string JPEDEDNAPJP = "contentLockRepMessage";

	[SerializeField]
	private PopUpTrigger popUpTrigger;

	private bool NGIEPMJKJBN()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool IJNMJPCFKBL()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void KJJINNGPPEA(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_description_1085") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_description_662"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveGetUniqueCropHarvestableOnClient"))
		{
			playerNum = 0;
		}
		else
		{
			playerNum = 1;
		}
		if (!NGIEPMJKJBN())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.ShowPopUp(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.ShowPopUp(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[6];
		array3[1] = LocalisationSystem.Get(contentToLocalise);
		array3[1] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "{0} - Activating variant object {1} at index {2} for piece {3}. Next variant index: {4}" + Money.AAOABKNGEHF().FEJCKKMDKBE().ToString() + "BobProgress";
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = text;
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.NEFOKCKKLNI().OFGKFMJKBON(playerNum);
	}

	private bool GMKDMNOENMP()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.KHMEGDIABBF().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool KJFEKENLGCE()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.KHMEGDIABBF().MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void KIJDNFODCKJ(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag(" because it doesn't have puzzle altar but the piece ID matches the altar piece ID.") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveRemoveTableOrder"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Disabled"))
		{
			playerNum = 6;
		}
		else
		{
			playerNum = 0;
		}
		if (!DPEANMMHCEK())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.PADOAKMGDJE(playerNum);
			return;
		}
		string text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(KEJPBACDIDE), LocalisationSystem.Get(contentToLocalise), requirement.ToString(), null, null, null, null, null, null);
		text = text + "adoptionsRequired" + Money.PJDFPKDPFHG().FEJCKKMDKBE().ToString() + "- ";
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = text;
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.MCPEEGPBPLH().Open(playerNum);
	}

	protected override void Start()
	{
		base.Start();
		ActivateLock();
	}

	private void NFDJLCGELJM(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_description_1047") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("itemGreenPepperSeeds"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_description_1179"))
		{
			playerNum = 2;
		}
		else
		{
			playerNum = 0;
		}
		if (!ALANFGAOHFA())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.FEKCGEIDABO(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[5];
		array3[1] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "Temperature" + Money.PFKHMCHBLJJ().FEJCKKMDKBE().ToString() + "Disabled";
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = text;
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().Open(playerNum);
	}

	private void JDMMNLKLMAA()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = false;
	}

	private bool MPMAAEOJNIG()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool NPFHEPBDGKM()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private bool HMAFDMBABHD()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.KHMEGDIABBF().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool JHFBEIKFKLH()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.KHMEGDIABBF().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void LJJDGAJNNCH(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("TabernaClausurada/KlaynTavernBarks") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Castle/Talks/Hawks"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveGiveRoom"))
		{
			playerNum = 2;
		}
		else
		{
			playerNum = 0;
		}
		if (!KJFEKENLGCE())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(JPEDEDNAPJP), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.PADOAKMGDJE(playerNum);
			return;
		}
		string cAEDMEDBEGI2 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array2 = new string[4];
		array2[1] = LocalisationSystem.Get(contentToLocalise);
		array2[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		text = text + "fishCaught" + Money.JOBFHDLGMDP().IHEMDADEBON().ToString() + "Building";
		((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = text;
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.MCPEEGPBPLH().Open(playerNum);
	}

	private bool AFLHEGDBBAM()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private void ADIGNNPBACJ(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("NormalLeftExterior"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("UI2"))
		{
			playerNum = 2;
		}
		else
		{
			playerNum = 0;
		}
		if (!FBKFOGHLPDI())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[4];
		array3[0] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "itemBeer" + Money.PJDFPKDPFHG().IHEMDADEBON().ToString() + "mForMins";
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = text;
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.MCPEEGPBPLH().Open(playerNum);
	}

	private bool DPEANMMHCEK()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void GECHJIGBPEN()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = false;
	}

	private bool JFMCJBCHGDE()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.KHMEGDIABBF().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool LPBDKPHOPNJ()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.OPILDPFDFKJ().MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void OCMFFLLPHCK(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("subject") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveAllDecorations"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag(""))
		{
			playerNum = 1;
		}
		else
		{
			playerNum = 1;
		}
		if (!GMKDMNOENMP())
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(MDIFGBAFFLI), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(JPEDEDNAPJP), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		string cAEDMEDBEGI = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array = new string[2];
		array[0] = LocalisationSystem.Get(contentToLocalise);
		array[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		text = text + "mForMins" + Money.NAELLPMADDP().CKNMHNMBCOF().ToString() + " dying!";
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = text;
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.NEFOKCKKLNI().Open(playerNum);
	}

	private void CIMPOOJOMMH(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag(" ") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveCollectItemsMaster"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag(""))
		{
			playerNum = 8;
		}
		else
		{
			playerNum = 1;
		}
		if (!EBIDANEMCCG())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(JPEDEDNAPJP), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		string cAEDMEDBEGI2 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array2 = new string[0];
		array2[0] = LocalisationSystem.Get(contentToLocalise);
		array2[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		text = text + "Right Stick Up" + Money.AAOABKNGEHF().ALLHDAPPBHL().ToString() + "Chisel";
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = text;
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.NEFOKCKKLNI().OFGKFMJKBON(playerNum);
	}

	private bool GEDHAHFLLEG()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void JGBLJPDNLMO(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("The Cellar") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Interact"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_description_602"))
		{
			playerNum = 8;
		}
		else
		{
			playerNum = 1;
		}
		if (!DPEANMMHCEK())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.AEBKHLILFNJ(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.FEKCGEIDABO(playerNum);
			return;
		}
		string text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(KEJPBACDIDE), LocalisationSystem.Get(contentToLocalise), requirement.ToString(), null, null, null);
		text = text + "Player" + Money.BGIKBFLIDGD().CKNMHNMBCOF().ToString() + "Item Transaction. Tutorial active!!";
		((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = text;
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().Open(playerNum);
	}

	private void LEKBKCLEEHE(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("\n") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Receive next game date from host "))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("KickedCustomers"))
		{
			playerNum = 1;
		}
		else
		{
			playerNum = 1;
		}
		if (!CILMEBLMKJM())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[1];
		array3[0] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "GameEvent with eventType: " + Money.OGNEAEMNLLD().GMAFKAMJEJH().ToString() + "EnableNPC";
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = text;
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.NEFOKCKKLNI().Open(playerNum);
	}

	private void DHIOKICDPIK(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag(") ") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_name_1068"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("[Player2Name]"))
		{
			playerNum = 6;
		}
		else
		{
			playerNum = 1;
		}
		if (!LPBDKPHOPNJ())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.ShowPopUp(playerNum);
			return;
		}
		string text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(KEJPBACDIDE), LocalisationSystem.Get(contentToLocalise), requirement.ToString(), null, null, null, null, null);
		text = text + "Run" + Money.OGNEAEMNLLD().FEJCKKMDKBE().ToString() + "Left";
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = text;
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.LBHLPIFCINB().OFGKFMJKBON(playerNum);
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private void EJMDCLNDBFJ(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag(", Property: ") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("]"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("[^0-9]"))
		{
			playerNum = 6;
		}
		else
		{
			playerNum = 1;
		}
		if (!IJNMJPCFKBL())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[0] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.FEKCGEIDABO(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[2];
		array3[0] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "Dialogue System/Conversation/Gass_Stand/Entry/20/Dialogue Text" + Money.PJDFPKDPFHG().ALLHDAPPBHL().ToString() + "Grass";
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = text;
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().Open(playerNum);
	}

	private void IIPKPMPGLOL()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	public override void LoadUnlocked()
	{
		base.LoadUnlocked();
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void KKONKMFFILD(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Swiss Cheese") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("UIPreviousPage"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("kickedCustomers"))
		{
			playerNum = 1;
		}
		else
		{
			playerNum = 1;
		}
		if (!EBIDANEMCCG())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(JPEDEDNAPJP), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.OBJHCAMMDEN(playerNum);
			return;
		}
		string cAEDMEDBEGI2 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array2 = new string[4];
		array2[1] = LocalisationSystem.Get(contentToLocalise);
		array2[1] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		text = text + "Inventory full" + Money.PJDFPKDPFHG().IHEMDADEBON().ToString() + "subject";
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = text;
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.LBHLPIFCINB().Open(playerNum);
	}

	private bool CILMEBLMKJM()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Player") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Player2"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Player2"))
		{
			playerNum = 2;
		}
		else
		{
			playerNum = 1;
		}
		if (!IJNMJPCFKBL())
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(MDIFGBAFFLI), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.ShowPopUp(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			popUpTrigger.message = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(JPEDEDNAPJP), LocalisationSystem.Get(contentLockID.ToString()));
			popUpTrigger.ShowPopUp(playerNum);
			return;
		}
		string text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(KEJPBACDIDE), LocalisationSystem.Get(contentToLocalise), requirement.ToString());
		text = text + "(" + Money.GetBalance().ALLHDAPPBHL().ToString() + ")";
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = text;
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().Open(playerNum);
	}

	private void DMENPMHIPDA(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveSpawnMoneyText") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Items/item_description_1053"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("add item "))
		{
			playerNum = 2;
		}
		else
		{
			playerNum = 0;
		}
		if (!JHFBEIKFKLH())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[1];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[6];
		array3[1] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "Sending finish minigame" + Money.PJDFPKDPFHG().GMAFKAMJEJH().ToString() + "endconversation";
		((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = text;
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.LBHLPIFCINB().Open(playerNum);
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private bool EKKPADCEEBA()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GGFJGHHHEJC.CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool EBIDANEMCCG()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.OPILDPFDFKJ().MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	protected override void LAKAMCEKHPI(int JIIGOACEIKL)
	{
		Debug.LogError((object)"Unlock");
		if (Money.CanAfford(requirement))
		{
			Money.MinusPrice(requirement);
			base.LAKAMCEKHPI(JIIGOACEIKL);
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Can't afford"));
		}
	}

	private void FJKGPAPACOI(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Sit") && !((Component)LGGCFCHOOMB).gameObject.CompareTag(" - Restoring non-altar variants. Excluded indices for variants with puzzle or altar: "))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("parent destroyed: {0}"))
		{
			playerNum = 3;
		}
		else
		{
			playerNum = 0;
		}
		if (!BHKCOGABCGN())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.OBJHCAMMDEN(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.AEBKHLILFNJ(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[5];
		array3[0] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "Collect" + Money.CADNHAGELGN().ALLHDAPPBHL().ToString() + "Recipe in hole: ";
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = text;
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.NEFOKCKKLNI().OFGKFMJKBON(playerNum);
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private void NPIDHDAIPKG(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Tutorial/T115/Dialogue1") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Error_Mortar"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/8/Dialogue Text"))
		{
			playerNum = 4;
		}
		else
		{
			playerNum = 1;
		}
		if (!GEDHAHFLLEG())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[1];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[5];
		array3[1] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "AimDirection" + Money.PJDFPKDPFHG().OMOHMCCADDJ().ToString() + "Player";
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = text;
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().OFGKFMJKBON(playerNum);
	}

	private bool BHKCOGABCGN()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void JOLMPGBPDEP(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("LicenciaDeApertura/TheloniousDialogue 01") && !((Component)LGGCFCHOOMB).gameObject.CompareTag(" "))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("</color>"))
		{
			playerNum = 2;
		}
		else
		{
			playerNum = 1;
		}
		if (!GMAEEIGEPPC())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[1];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.DJCCNPOCHAO(playerNum);
			return;
		}
		string cAEDMEDBEGI3 = LocalisationSystem.Get(KEJPBACDIDE);
		string[] array3 = new string[3];
		array3[1] = LocalisationSystem.Get(contentToLocalise);
		array3[0] = requirement.ToString();
		string text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		text = text + "Error_RoomIndependent" + Money.BGIKBFLIDGD().ALLHDAPPBHL().ToString() + "City/Amos/Bark/Buy";
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = text;
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().Open(playerNum);
	}

	private bool HAEOAIHAHJO()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool PBJJIEBMAHG()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool GMAEEIGEPPC()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.OPILDPFDFKJ().MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private bool BMBIGJOAFIP()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.KHMEGDIABBF().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void COKBJNMAMDI()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = false;
	}

	private void AAOFFIJHHIB(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Sending ") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Dialogue System/Conversation/Gass_Introduce/Entry/11/Dialogue Text"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("Player2"))
		{
			playerNum = 4;
		}
		else
		{
			playerNum = 1;
		}
		if (!KJFEKENLGCE())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.NJDOPBFJMFM(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.GetMilestone() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[0];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.FEKCGEIDABO(playerNum);
			return;
		}
		string text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(KEJPBACDIDE), LocalisationSystem.Get(contentToLocalise), requirement.ToString(), null, null, null, null);
		text = text + "Player" + Money.OGNEAEMNLLD().FEJCKKMDKBE().ToString() + "Random";
		((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = text;
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.GetYesNoDialogue().OFGKFMJKBON(playerNum);
	}

	private void OOALHOHGANE(Collider2D LGGCFCHOOMB)
	{
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("quarry") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("questNameMalting"))
		{
			return;
		}
		int playerNum;
		if (((Component)LGGCFCHOOMB).gameObject.CompareTag("QuestInfoButton"))
		{
			playerNum = 8;
		}
		else
		{
			playerNum = 1;
		}
		if (!IJNMJPCFKBL())
		{
			PopUpTrigger obj = popUpTrigger;
			string cAEDMEDBEGI = LocalisationSystem.Get(MDIFGBAFFLI);
			string[] array = new string[0];
			array[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			popUpTrigger.OJOGDDIHMNL(playerNum);
			return;
		}
		if ((Object)(object)requiredRep != (Object)null && TavernReputation.MHGADJPMHFI() < requiredRep.repNumber)
		{
			PopUpTrigger obj2 = popUpTrigger;
			string cAEDMEDBEGI2 = LocalisationSystem.Get(JPEDEDNAPJP);
			string[] array2 = new string[1];
			array2[1] = LocalisationSystem.Get(contentLockID.ToString());
			obj2.message = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			popUpTrigger.AEBKHLILFNJ(playerNum);
			return;
		}
		string text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get(KEJPBACDIDE), LocalisationSystem.Get(contentToLocalise), requirement.ToString(), null, null, null);
		text = text + "itemRyeSeeds" + Money.BGIKBFLIDGD().GMAFKAMJEJH().ToString() + "CookiesNeeded";
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = text;
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			LAKAMCEKHPI(playerNum);
		});
		MainUI.MCPEEGPBPLH().Open(playerNum);
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private bool FBKFOGHLPDI()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return true;
		}
		return (from aq in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void KDHLJKMKFMG()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private void Awake()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = false;
	}

	private void FPNCANODJKE()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}

	private bool ALANFGAOHFA()
	{
		if ((Object)(object)requiredQuest == (Object)null)
		{
			return false;
		}
		return (from aq in QuestManager.GGFJGHHHEJC.MADOFDHLKKN
			where aq != null
			select aq.quest).Contains(requiredQuest);
	}

	private void HPJBLOPJIMI()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = false;
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)popUpTrigger == (Object)null)
		{
			popUpTrigger = ((Component)this).GetComponent<PopUpTrigger>();
		}
		popUpTrigger.selfTrigger = true;
	}
}
