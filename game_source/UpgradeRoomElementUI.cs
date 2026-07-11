using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UpgradeRoomElementUI : MonoBehaviour
{
	[Serializable]
	public struct UpgradeRequirements
	{
		public Price price;

		public ReputationInfo reputation;
	}

	[CompilerGenerated]
	private sealed class PIPNNPOCCKO
	{
		public UpgradeRequirements requirements;

		public UpgradeRoomElementUI _003C_003E4__this;

		internal void NMEMPNEMJFF()
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(_003C_003E4__this.zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			_003C_003E4__this.UpdateElement();
		}
	}

	public UpgradeRequirements[] upgradeRequirements;

	public ZoneType zoneType;

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private string localId;

	[SerializeField]
	private GameObject priceParent;

	[SerializeField]
	private MoneyUI price;

	private bool FEMONJAKCBK;

	private void CGHHPELBKBK()
	{
		CIPNBDCLGEJ();
	}

	public ReputationInfo JOHADBAAFND()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	public void LCDNOJEDJKN()
	{
		if (RoomUpgrader.GGFJGHHHEJC.upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "Error in TavernManager.OnPlayerSleep: " + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.KKFMAGJHGIC(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = false;
			}
		}
	}

	public bool MKNHFDLDAMP()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		return TavernReputation.GetMilestone() < upgradeRequirements.reputation.repNumber;
	}

	public void OBHLDFECKHJ()
	{
		if (RoomUpgrader.MAAAKALBBEE().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "Club" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.AAPLOOIDCGP(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = true;
			}
		}
	}

	private void HAHDIENCHCC()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			MainUI.DJCKALOHJFM(0, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("City/Agatha/Introduce"), requirements.reputation.repNumber.ToString()), 554f);
			return;
		}
		if (Money.ToCopper() < requirements.price.OOIPLIEJILO())
		{
			MainUI.ShowErrorText(1, LocalisationSystem.Get("MissionTalkWith: NPC not found for character "), 1754f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.JDAEPLJAGCD(1, LocalisationSystem.Get("Year"), 526f);
			return;
		}
		MainUI.NEFOKCKKLNI().Open(1);
		TextMeshProUGUI boxText = MainUI.MCPEEGPBPLH().boxText;
		string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveAssignChicken");
		string[] array = new string[7];
		array[1] = LocalisationSystem.Get(zoneType.ToString());
		array[0] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public void EPGOCMGAAPB()
	{
		JPHIBJJDMME();
	}

	public ReputationInfo ALCDFAFMDOG()
	{
		return upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]].reputation;
	}

	public ReputationInfo FINFDMOEIMP()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	private void IANGDMHMCEL()
	{
		BBEINCCFDDP();
	}

	private void HKJCLFHCMKC()
	{
		CIPNBDCLGEJ();
	}

	public void SelectClicked()
	{
		HHHGCOKNLMJ();
	}

	private void ICFNHIKHOHM()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			MainUI.LJDOBNEINNJ(0, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Last"), requirements.reputation.repNumber.ToString()), 761f);
			return;
		}
		if (Money.ENLLIPHCKAL() < requirements.price.OOIPLIEJILO())
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get("TavernManager instance is null, cannot add open tavern blocker."), 1127f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.JDAEPLJAGCD(1, LocalisationSystem.Get("[MinePuzzleManager] Puzzle {0} placed with {1} elements."), 1975f);
			return;
		}
		MainUI.NEFOKCKKLNI().OFGKFMJKBON(1);
		TextMeshProUGUI boxText = MainUI.NEFOKCKKLNI().boxText;
		string cAEDMEDBEGI = LocalisationSystem.Get("halloweenActivated");
		string[] array = new string[4];
		array[1] = LocalisationSystem.Get(zoneType.ToString());
		array[0] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public bool BPELFFDOPKB()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		return TavernReputation.GetMilestone() >= upgradeRequirements.reputation.repNumber;
	}

	public ReputationInfo HOPEOPFJKKH()
	{
		return upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]].reputation;
	}

	public void PNILDPCIBBL()
	{
		if (RoomUpgrader.GGFJGHHHEJC.upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "Capacity" + (value + 0);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.IJNGEICHCNI(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = false;
			}
		}
	}

	public ReputationInfo FGBEIEOHKGA()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	public ReputationInfo ANJAAONHLEO()
	{
		return upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]].reputation;
	}

	public void OOKANHIBNDE()
	{
		if (RoomUpgrader.MAAAKALBBEE().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "No seat or table!" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.GBIHHJNHJHL(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = false;
			}
		}
	}

	private void MBCCCMMBPEK()
	{
		OBHLDFECKHJ();
	}

	public bool EAMHFGBBELN()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		return TavernReputation.GetMilestone() >= upgradeRequirements.reputation.repNumber;
	}

	public ReputationInfo JLFOCHAKDJG()
	{
		return upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]].reputation;
	}

	public void OOEKBBDMLGA()
	{
		HEGLBPLFNBK();
	}

	public void BKCMHPFANBL()
	{
		AHLHKBKGCJO();
	}

	private void PJDGEEBMPMG()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Beta ");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1157f);
			return;
		}
		if (Money.ToCopper() < requirements.price.OOIPLIEJILO())
		{
			MainUI.LJDOBNEINNJ(0, LocalisationSystem.Get("Player/Bark/ShovelHole"), 503f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.LJDOBNEINNJ(0, LocalisationSystem.Get("Items/item_description_675"), 800f);
			return;
		}
		MainUI.GetYesNoDialogue().Open(0);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Winner"), LocalisationSystem.Get(zoneType.ToString()), requirements.price.ToString(), null, null, null, null, null, null);
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	private void FPJABCNDEEJ()
	{
		OOKANHIBNDE();
	}

	private void NLHALEAEDMM()
	{
		OOKANHIBNDE();
	}

	public void MIINHGIJLJD()
	{
		FDDDEGDLPKM();
	}

	public void HGGNFBDKFEK()
	{
		if (RoomUpgrader.LDBJELPPBAI().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "Tutorial/MaiPatch" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.OBNIDFJCELG(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = true;
			}
		}
	}

	private void HGEKPHOPJCD()
	{
		PNILDPCIBBL();
	}

	private void HHHGCOKNLMJ()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Unlocked at Tavern Reputation {0}"), requirements.reputation.repNumber.ToString()));
			return;
		}
		if (Money.ToCopper() < requirements.price.OOIPLIEJILO())
		{
			MainUI.ShowErrorText(1, LocalisationSystem.Get("Not enough money"));
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.ShowErrorText(1, LocalisationSystem.Get("Tavern must be closed"));
			return;
		}
		MainUI.GetYesNoDialogue().Open(1);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("upgradeRoomNotification"), LocalisationSystem.Get(zoneType.ToString()), requirements.price.ToString());
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public void EIEGNDAGECJ()
	{
		AHLHKBKGCJO();
	}

	public bool EOILPEPACDE()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		return TavernReputation.GetMilestone() < upgradeRequirements.reputation.repNumber;
	}

	private void CIIBBCPIOIP()
	{
		LMFDGABDAKM();
	}

	public void LIDLKHPKLNK()
	{
		if (RoomUpgrader.LDBJELPPBAI().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "unlock recipe" + (value + 0);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.CPCHAPEJBMI(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = false;
			}
		}
	}

	private void JLDNAPIPCOF()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(", ");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1723f);
			return;
		}
		if (Money.ToCopper() < requirements.price.BNCMDNFMECD())
		{
			MainUI.LJDOBNEINNJ(0, LocalisationSystem.Get("selected_objects"), 362f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("\n"), 1686f);
			return;
		}
		MainUI.GetYesNoDialogue().Open(1);
		TextMeshProUGUI boxText = MainUI.NEFOKCKKLNI().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Trying to add player but player list is full.");
		string[] array2 = new string[7];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[0] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	private void KHNBDGDLMIE()
	{
		LIDLKHPKLNK();
	}

	public void GCMOKLLFBNF()
	{
		if (RoomUpgrader.MAAAKALBBEE().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + " " + (value + 0);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.IJNGEICHCNI(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = false;
			}
		}
	}

	public bool HasReputationLevel()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		return TavernReputation.GetMilestone() >= upgradeRequirements.reputation.repNumber;
	}

	public bool BEMNCDGLNDB()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		return TavernReputation.GetMilestone() >= upgradeRequirements.reputation.repNumber;
	}

	public void PKHFJAIBCDI()
	{
		if (RoomUpgrader.MAAAKALBBEE().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "Chat input cancelled" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.KICIFCCILNK(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = true;
			}
		}
	}

	private void HPHAABDONGN()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("SetAnimatorObjectFloatRPC");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.LJDOBNEINNJ(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 788f);
			return;
		}
		if (Money.FJLJLKMOGBB() < requirements.price.JHKPNCOMAHI())
		{
			MainUI.ShowErrorText(1, LocalisationSystem.Get("Failed to load psai soundtrack from path '"), 827f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.JDAEPLJAGCD(0, LocalisationSystem.Get("enddialogue"), 1145f);
			return;
		}
		MainUI.GetYesNoDialogue().OFGKFMJKBON(1);
		TextMeshProUGUI boxText = MainUI.GetYesNoDialogue().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/TableDirty/Entry/2/Dialogue Text");
		string[] array2 = new string[6];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	private void JPHIBJJDMME()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Miners/Camp/Rochelle/Talk");
			string[] array = new string[0];
			array[1] = requirements.reputation.repNumber.ToString();
			MainUI.DJCKALOHJFM(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 180f);
			return;
		}
		if (Money.ToCopper() < requirements.price.BNCMDNFMECD())
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("/"), 126f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.ShowErrorText(0, LocalisationSystem.Get("MainProgress"), 991f);
			return;
		}
		MainUI.GetYesNoDialogue().OFGKFMJKBON(1);
		((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Inventory full"), LocalisationSystem.Get(zoneType.ToString()), requirements.price.ToString(), null, null, null, null, null, null);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public void JHEFBAADCKD()
	{
		AHLHKBKGCJO();
	}

	public bool GOEPJLMDBAL()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.GetMilestone() < upgradeRequirements.reputation.repNumber;
	}

	private void GBAKNAINDJM()
	{
		CIPNBDCLGEJ();
	}

	private void HEGLBPLFNBK()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("itemTurnip");
			string[] array = new string[1];
			array[1] = requirements.reputation.repNumber.ToString();
			MainUI.JDAEPLJAGCD(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1117f);
			return;
		}
		if (Money.PNIKBCDCPDC() < requirements.price.JHKPNCOMAHI())
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("- "), 1322f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get(""), 1643f);
			return;
		}
		MainUI.MCPEEGPBPLH().OFGKFMJKBON(1);
		TextMeshProUGUI boxText = MainUI.LBHLPIFCINB().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("ReceiveQuestInfoLoad");
		string[] array2 = new string[2];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public bool OOPCCIAKMCE()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.GetMilestone() < upgradeRequirements.reputation.repNumber;
	}

	public bool ILBCEFEBNBN()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() >= upgradeRequirements.reputation.repNumber;
	}

	private void ELAEGPDLAHK()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_667");
			string[] array = new string[0];
			array[1] = requirements.reputation.repNumber.ToString();
			MainUI.LJDOBNEINNJ(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1633f);
			return;
		}
		if (Money.PNIKBCDCPDC() < requirements.price.OOIPLIEJILO())
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get("Lager"), 1718f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.DBKCOHMFDCB(0, LocalisationSystem.Get("\n</color>"), 61f);
			return;
		}
		MainUI.MCPEEGPBPLH().OFGKFMJKBON(1);
		TextMeshProUGUI boxText = MainUI.NEFOKCKKLNI().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("fog");
		string[] array2 = new string[4];
		array2[0] = LocalisationSystem.Get(zoneType.ToString());
		array2[0] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public bool ADLGEPGGOEJ()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() < upgradeRequirements.reputation.repNumber;
	}

	public void UpdateElement()
	{
		if (RoomUpgrader.GGFJGHHHEJC.upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + " " + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.SetPrice(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = true;
			}
		}
	}

	public ReputationInfo INLPPPMNLMO()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	private void BMDDIJPFEGA()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("talentHops");
			string[] array = new string[0];
			array[1] = requirements.reputation.repNumber.ToString();
			MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 890f);
			return;
		}
		if (Money.ENLLIPHCKAL() < requirements.price.OOIPLIEJILO())
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("Missing fade image"), 219f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.DBKCOHMFDCB(0, LocalisationSystem.Get(" playerDialogue: "), 1020f);
			return;
		}
		MainUI.LBHLPIFCINB().OFGKFMJKBON(0);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ZuzzuProgress"), LocalisationSystem.Get(zoneType.ToString()), requirements.price.ToString(), null, null, null, null, null);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public ReputationInfo CPJGABDELKJ()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	public void FJAPAOJMLNH()
	{
		NIPHHJPBGFH();
	}

	public void BBEINCCFDDP()
	{
		if (RoomUpgrader.LDBJELPPBAI().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "Duplicate editor action id found: " + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.DHOPJAJOJLL(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = true;
			}
		}
	}

	private void JINLGFOFJAN()
	{
		LIDLKHPKLNK();
	}

	public bool EGMBBBGIAIJ()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() < upgradeRequirements.reputation.repNumber;
	}

	private void OnEnable()
	{
		UpdateElement();
	}

	public bool BHHJOCGKPFI()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() >= upgradeRequirements.reputation.repNumber;
	}

	public void AOEIHMNLJAC()
	{
		if (RoomUpgrader.LDBJELPPBAI().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.CPCHAPEJBMI(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = true;
			}
		}
	}

	private void GLNCDPMJPPD()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Player/Bark/Error/NotAllPlayersHere");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.LJDOBNEINNJ(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1455f);
			return;
		}
		if (Money.ENLLIPHCKAL() < requirements.price.BNCMDNFMECD())
		{
			MainUI.DJCKALOHJFM(1, LocalisationSystem.Get("ToFish"), 1243f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.DBKCOHMFDCB(0, LocalisationSystem.Get("Rest"), 743f);
			return;
		}
		MainUI.GetYesNoDialogue().OFGKFMJKBON(1);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error in CatNPC.TeleToBed: "), LocalisationSystem.Get(zoneType.ToString()), requirements.price.ToString(), null, null, null, null);
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public bool HAHIKABNEGL()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.GetMilestone() >= upgradeRequirements.reputation.repNumber;
	}

	private void IDNDOOHFPEA()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Wall");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.JDAEPLJAGCD(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 579f);
			return;
		}
		if (Money.EJHJKOPDDGM() < requirements.price.BNCMDNFMECD())
		{
			MainUI.JDAEPLJAGCD(0, LocalisationSystem.Get("SwitchFood"), 1729f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.DBKCOHMFDCB(0, LocalisationSystem.Get("File "), 889f);
			return;
		}
		MainUI.NEFOKCKKLNI().Open(1);
		TextMeshProUGUI boxText = MainUI.LBHLPIFCINB().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("ZoneTimeBonus");
		string[] array2 = new string[6];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public bool OGKCFLFMMOE()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() < upgradeRequirements.reputation.repNumber;
	}

	public ReputationInfo JIHDOIDOONA()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	public ReputationInfo GNMPFNLOBGD()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	private void MJDIEKLBHBK()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(" perk 40 servicial (+");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.DJCKALOHJFM(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1519f);
			return;
		}
		if (Money.PNIKBCDCPDC() < requirements.price.JHKPNCOMAHI())
		{
			MainUI.JDAEPLJAGCD(0, LocalisationSystem.Get("BobAnimation SetSleep"), 630f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get("Victory"), 656f);
			return;
		}
		MainUI.LBHLPIFCINB().Open(1);
		TextMeshProUGUI boxText = MainUI.MCPEEGPBPLH().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Walk");
		string[] array2 = new string[2];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	private void NBBJGJMEGDO()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("</size>");
			string[] array = new string[1];
			array[1] = requirements.reputation.repNumber.ToString();
			MainUI.DBKCOHMFDCB(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1076f);
			return;
		}
		if (Money.PNIKBCDCPDC() < requirements.price.JHKPNCOMAHI())
		{
			MainUI.DJCKALOHJFM(1, LocalisationSystem.Get("Player/Bark/"), 122f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("LearnMettle"), 161f);
			return;
		}
		MainUI.MCPEEGPBPLH().Open(1);
		TextMeshProUGUI boxText = MainUI.LBHLPIFCINB().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Tutorial/BarnBarks_Holly");
		string[] array2 = new string[5];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public ReputationInfo IPIJKHDMDKM()
	{
		return upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]].reputation;
	}

	public void PABPIGGOEMO()
	{
		if (RoomUpgrader.LDBJELPPBAI().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "SetAnimatorStateRPC" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.BDHMBPMOFCD(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = true;
			}
		}
	}

	public ReputationInfo MCNPKNKNHIL()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	public void NPPFHJLGCBE()
	{
		if (RoomUpgrader.GGFJGHHHEJC.upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "RecieveStartEvent" + (value + 0);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.EPPHEPCEHGN(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = false;
			}
		}
	}

	public void MKFMLOHPMGH()
	{
		GLNCDPMJPPD();
	}

	private void FDDDEGDLPKM()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(" in Cellar Light Start");
			string[] array = new string[1];
			array[1] = requirements.reputation.repNumber.ToString();
			MainUI.DBKCOHMFDCB(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1607f);
			return;
		}
		if (Money.PNIKBCDCPDC() < requirements.price.BNCMDNFMECD())
		{
			MainUI.ShowErrorText(0, LocalisationSystem.Get("ReceivePlayerLeftBed"), 1384f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.DJCKALOHJFM(0, LocalisationSystem.Get("Trying to add a player that's already on the list."), 1369f);
			return;
		}
		MainUI.LBHLPIFCINB().OFGKFMJKBON(0);
		TextMeshProUGUI boxText = MainUI.MCPEEGPBPLH().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("ClosePopUp");
		string[] array2 = new string[1];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	private void GJJPNFHFBFP()
	{
		GCMOKLLFBNF();
	}

	private void NIPHHJPBGFH()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			MainUI.JDAEPLJAGCD(0, InputUtils.GEJLCOGDMID(LocalisationSystem.Get(""), requirements.reputation.repNumber.ToString()), 678f);
			return;
		}
		if (Money.PNIKBCDCPDC() < requirements.price.OOIPLIEJILO())
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("waterQualityTestDone"), 64f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.DBKCOHMFDCB(1, LocalisationSystem.Get("Actionbar 10"), 603f);
			return;
		}
		MainUI.NEFOKCKKLNI().OFGKFMJKBON(1);
		TextMeshProUGUI boxText = MainUI.LBHLPIFCINB().boxText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Fortitude/MainEvent 3");
		string[] array = new string[8];
		array[1] = LocalisationSystem.Get(zoneType.ToString());
		array[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public void HEGCJJNHBKI()
	{
		ICFNHIKHOHM();
	}

	public void BPLKCCNBPFH()
	{
		if (RoomUpgrader.GGFJGHHHEJC.upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "ReceiveOnConversationLine" + (value + 0);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.SetPrice(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(false);
				FEMONJAKCBK = true;
			}
		}
	}

	public ReputationInfo NNPKBEJDLJL()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	public ReputationInfo CPKGJKGNDCE()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	public bool HEPNFGADEIN()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() >= upgradeRequirements.reputation.repNumber;
	}

	private void NICKFKNAGHN()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.GetMilestone() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(" ");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.DJCKALOHJFM(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 271f);
			return;
		}
		if (Money.EJHJKOPDDGM() < requirements.price.OOIPLIEJILO())
		{
			MainUI.DBKCOHMFDCB(0, LocalisationSystem.Get("Hierarchy_"), 828f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("Explosion"), 1291f);
			return;
		}
		MainUI.LBHLPIFCINB().Open(1);
		TextMeshProUGUI boxText = MainUI.LBHLPIFCINB().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get("Player2");
		string[] array2 = new string[7];
		array2[1] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	private void NBBFLJNPLEA()
	{
		OOKANHIBNDE();
	}

	private void BJOOCKCBPLJ()
	{
		BPLKCCNBPFH();
	}

	public void CIPNBDCLGEJ()
	{
		if (RoomUpgrader.MAAAKALBBEE().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "itemWheatLager" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(false);
				price.DHOPJAJOJLL(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = true;
			}
		}
	}

	public ReputationInfo GHHPONDHDDK()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	public ReputationInfo BAIKKHFJBHL()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	private void JNDFLHEMOBG()
	{
		BBEINCCFDDP();
	}

	private void AHLHKBKGCJO()
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		if (FEMONJAKCBK)
		{
			return;
		}
		UpgradeRequirements requirements = upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		if ((Object)(object)requirements.reputation != (Object)null && TavernReputation.MHGADJPMHFI() < requirements.reputation.repNumber)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Run");
			string[] array = new string[0];
			array[0] = requirements.reputation.repNumber.ToString();
			MainUI.DBKCOHMFDCB(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 409f);
			return;
		}
		if (Money.EJHJKOPDDGM() < requirements.price.BNCMDNFMECD())
		{
			MainUI.LJDOBNEINNJ(0, LocalisationSystem.Get("itemAleYeast"), 1365f);
			return;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			MainUI.LJDOBNEINNJ(1, LocalisationSystem.Get("itemStrawberry"), 340f);
			return;
		}
		MainUI.GetYesNoDialogue().OFGKFMJKBON(1);
		TextMeshProUGUI boxText = MainUI.MCPEEGPBPLH().boxText;
		string cAEDMEDBEGI2 = LocalisationSystem.Get(" totalMsgs: ");
		string[] array2 = new string[1];
		array2[0] = LocalisationSystem.Get(zoneType.ToString());
		array2[1] = requirements.price.ToString();
		((TMP_Text)boxText).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener((UnityAction)delegate
		{
			Money.MinusPrice(requirements.price);
			RoomUpgrader.GGFJGHHHEJC.UpgradeRoom(zoneType);
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.repairFurniture), HOMFPAFAOGD: true);
			UpdateElement();
		});
	}

	public bool PMCCKIEOMKB()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.MHGADJPMHFI() < upgradeRequirements.reputation.repNumber;
	}

	public bool JJALEIAELNF()
	{
		if (FEMONJAKCBK)
		{
			return true;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]];
		return TavernReputation.GetMilestone() >= upgradeRequirements.reputation.repNumber;
	}

	public bool INEPEDHGPLI()
	{
		if (FEMONJAKCBK)
		{
			return false;
		}
		UpgradeRequirements upgradeRequirements = this.upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]];
		return TavernReputation.GetMilestone() < upgradeRequirements.reputation.repNumber;
	}

	private void IJMBEEEGCGF()
	{
		GCMOKLLFBNF();
	}

	public ReputationInfo JOCBBJCOBCH()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	public void NMBDPFPGMOG()
	{
		NIPHHJPBGFH();
	}

	public void EIKILIJPCPP()
	{
		NIPHHJPBGFH();
	}

	public void BIKKJDAOLGF()
	{
		HPHAABDONGN();
	}

	public void LMFDGABDAKM()
	{
		if (RoomUpgrader.LDBJELPPBAI().upgrades.TryGetValue(zoneType, out var value))
		{
			((TMP_Text)title).text = LocalisationSystem.Get(localId) + "CultivableDuringOneMonth" + (value + 1);
			if (value < upgradeRequirements.Length)
			{
				priceParent.SetActive(true);
				price.SetPrice(upgradeRequirements[value].price);
			}
			else
			{
				priceParent.SetActive(true);
				FEMONJAKCBK = true;
			}
		}
	}

	public ReputationInfo JFJJPGAOFJD()
	{
		return upgradeRequirements[RoomUpgrader.LDBJELPPBAI().upgrades[zoneType]].reputation;
	}

	public ReputationInfo LOJKCGANDBG()
	{
		return upgradeRequirements[RoomUpgrader.MAAAKALBBEE().upgrades[zoneType]].reputation;
	}

	public ReputationInfo GetCurrentReputationReward()
	{
		return upgradeRequirements[RoomUpgrader.GGFJGHHHEJC.upgrades[zoneType]].reputation;
	}
}
