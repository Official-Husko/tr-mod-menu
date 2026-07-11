using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FarmAnimalUI : UIWindow
{
	public static FarmAnimalUI[] instances = new FarmAnimalUI[3];

	public AnimalNPC animalNPC;

	public SlotUI slotUI;

	public TMP_InputField nameText;

	public TextMeshProUGUI birthdayText;

	public GameObject production;

	public GameObject checkBoxFood;

	public GameObject checkBoxWater;

	public GameObject checkBoxWalk;

	public GameObject checkBoxWalkGameObject;

	public GameObject[] levelSlots;

	public ProductionBarUI[] productionBarUI;

	public SlotUI[] sacrificeSlotsUI;

	private string LEABIPLMOJF;

	private void MEHIPBLHDCC()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FKNHELFHMNJ();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].EHIMPKMEKHO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void AHEGFMOEILC()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.BKCGGLLLBCD();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[1].DFDLHCIGBCF(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void MFEPPINCOBF()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KPNKJDPGNJK();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[0].DFDLHCIGBCF(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OCJOJKJPDNO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void GEGECOCNJMI()
	{
		CloseUI();
	}

	public void JLADGBNKMGN()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)5)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
			switch (num)
			{
			case 4294967195u:
				if (text == "Open")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					MFEPPINCOBF();
				}
				break;
			case 4294967260u:
				if (text == "EditorAction_5")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-125));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					AEGPPJFAOCD();
				}
				break;
			}
			return;
		case 4294967142u:
		case 4294967143u:
		case 4294967144u:
		case 4294967145u:
		case 4294967146u:
		case 4294967147u:
		case 4294967148u:
		case 4294967149u:
		case 4294967150u:
		case 4294967151u:
		case 4294967152u:
		case 4294967153u:
		case 4294967154u:
		case 4294967155u:
		case 4294967156u:
		case 4294967157u:
		case 4294967158u:
		case 4294967159u:
		case 4294967160u:
		case 4294967161u:
		case 4294967162u:
		case 4294967163u:
		case 4294967164u:
		case 4294967165u:
		case 4294967166u:
		case 4294967167u:
		case 4294967168u:
		case 4294967169u:
		case 4294967170u:
		case 4294967171u:
		case 4294967172u:
		case 4294967173u:
		case 4294967174u:
		case 4294967175u:
		case 4294967176u:
		case 4294967177u:
		case 4294967178u:
		case 4294967179u:
		case 4294967180u:
		case 4294967181u:
		case 4294967182u:
		case 4294967183u:
		case 4294967184u:
		case 4294967185u:
		case 4294967186u:
		case 4294967187u:
		case 4294967188u:
		case 4294967189u:
		case 4294967190u:
		case 4294967191u:
		case 4294967192u:
		case 4294967193u:
		case 4294967194u:
		case 4294967195u:
		case 4294967196u:
		case 4294967197u:
		case 4294967198u:
		case 4294967199u:
		case 4294967200u:
		case 4294967201u:
		case 4294967202u:
		case 4294967203u:
		case 4294967204u:
		case 4294967205u:
		case 4294967206u:
		case 4294967207u:
		case 4294967208u:
		case 4294967209u:
		case 4294967210u:
		case 4294967211u:
		case 4294967212u:
		case 4294967213u:
		case 4294967214u:
		case 4294967215u:
		case 4294967216u:
		case 4294967217u:
		case 4294967218u:
		case 4294967219u:
		case 4294967220u:
		case 4294967221u:
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
			switch (num)
			{
			case 140u:
				if (text == "Disconnected from network. Cause: ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-4));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
					AEGPPJFAOCD();
				}
				break;
			case 4294967294u:
				if (text == "None")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					DGPPDBFJFNF();
				}
				break;
			}
			return;
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 164u:
				if (text == "Japanese Door Not Sending Open Action. Unique ID: ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.PEECGCDGNOB(animalNPC.NBMNBKEJHPM);
					DJAGJMJDIHN();
				}
				break;
			case 154u:
				if (text == " (")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					MFEPPINCOBF();
				}
				break;
			case 5u:
				if (text == "add item 1447 20")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					AHEGFMOEILC();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 28u:
			if (text == "BuildingTutorialOnlyHost")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				MGAGMKGKCGJ();
			}
			break;
		case 53u:
			if (text == "KyrohNPC: ChangeState called with invalid state: ")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
				ACECOKOMJLG();
			}
			break;
		case 0u:
			if (text == "No MinePuzzleConfig found for level {0}")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				ENJCFNFIIMM();
			}
			break;
		}
	}

	public static FarmAnimalUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmAnimalUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void HBIONMJELMM()
	{
		BOBCIFEDJED();
	}

	private void HDEABKKDOID()
	{
		BOBCIFEDJED();
	}

	private void EAIMHIDMANH()
	{
		BOBCIFEDJED();
	}

	private void HAFBIPGEEFF()
	{
		BOBCIFEDJED();
	}

	public void PIEMGDMNGML()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)6)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967138u)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
			case 11u:
			case 12u:
			case 13u:
			case 14u:
			case 15u:
			case 16u:
			case 17u:
			case 18u:
			case 19u:
			case 20u:
			case 21u:
			case 22u:
			case 23u:
			case 24u:
			case 25u:
				switch (num)
				{
				case 141u:
					if (text == "mForMins")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
						KMCGHAFAJIC();
					}
					break;
				case 83u:
					if (text == "Shanty")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
						animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
						MEHIPBLHDCC();
					}
					break;
				}
				break;
			case 154u:
				if (text == "itemShimejiMushrooms")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ANJENCIEDLM();
				}
				break;
			case 41u:
				if (text == "Player/Bark/Tutorial/T116")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
					MLLIKCKMHOO();
				}
				break;
			case 4294967210u:
				if (text == "ZonePlanks")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
					EBGEDECEPII();
				}
				break;
			}
			return;
		}
		if (num <= 6)
		{
			switch (num)
			{
			case 33u:
				if (text == "BarIdleNumber")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(86));
					animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM);
					KMCGHAFAJIC();
				}
				break;
			case 3u:
				if (text == "MainProgress")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					NEBOMGGJOPD();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 22u:
			if (text == "resolution")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM);
				ACECOKOMJLG();
			}
			break;
		case 74u:
			if (text == "FollowTransforms parent")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
				EOFAJIKAJIG();
			}
			break;
		case 4294967244u:
			if (text == "LE_7")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				FJNBMBPBELE();
			}
			break;
		}
	}

	public static FarmAnimalUI OFEFGPCGJDF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ACECOKOMJLG()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].DPGOGNOOLCP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void CJIFDGBEPPB()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OPKIMBACIHA();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[0].EHIMPKMEKHO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void ICMBHNLFHNK()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KPNKJDPGNJK();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[0].IPPLLPCPLBP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.KMKAIPMHANN(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public static FarmAnimalUI EDGLKGEJKDP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BCKIPLLDHMI()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OPKIMBACIHA();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[1].IPPLLPCPLBP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void OBOAIOAGLEI()
	{
		CloseUI();
	}

	public static FarmAnimalUI MIMFFJHBFDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void AHOFCINBBOI()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
			productionBarUI[1].DFDLHCIGBCF(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void ANJENCIEDLM()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.DAEKAMPDAJH();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
			productionBarUI[1].JLCEMHMPPPG(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.KMKAIPMHANN(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public void LILGOGNIKMN()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)4)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
		case 77u:
		case 78u:
		case 79u:
		case 80u:
		case 81u:
		case 82u:
		case 83u:
		case 84u:
		case 85u:
		case 86u:
		case 87u:
		case 88u:
		case 89u:
		case 90u:
		case 91u:
		case 92u:
			switch (num)
			{
			case 4294967277u:
				if (text == "UpgradeObjectConfirmation")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					OGHIPMNFBAN();
				}
				break;
			case 4294967238u:
				if (text == " ")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(90));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					BCKIPLLDHMI();
				}
				break;
			}
			return;
		case 93u:
		case 94u:
		case 95u:
		case 96u:
		case 97u:
		case 98u:
		case 99u:
		case 100u:
		case 101u:
		case 102u:
		case 103u:
		case 104u:
		case 105u:
		case 106u:
		case 107u:
		case 108u:
		case 109u:
		case 110u:
		case 111u:
		case 112u:
		case 113u:
		case 114u:
		case 115u:
		case 116u:
		case 117u:
		case 118u:
		case 119u:
		case 120u:
		case 121u:
		case 122u:
		case 123u:
		case 124u:
		case 125u:
		case 126u:
		case 127u:
		case 128u:
		case 129u:
		case 130u:
		case 131u:
		case 132u:
		case 133u:
		case 134u:
		case 135u:
		case 136u:
		case 137u:
		case 138u:
		case 139u:
		case 140u:
		case 141u:
		case 142u:
		case 143u:
		case 144u:
		case 145u:
		case 146u:
		case 147u:
		case 148u:
		case 149u:
			switch (num)
			{
			case 4294967163u:
				if (text == "InteractPermissionDenied")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
					JAFKCFKJGPK();
				}
				break;
			case 4294967282u:
				if (text == "")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
					ACECOKOMJLG();
				}
				break;
			case 4294967267u:
				if (text == "Items/item_description_1051")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(animalNPC.NBMNBKEJHPM);
					PHNJFPEDEBK();
				}
				break;
			}
			return;
		}
		if (num <= 130)
		{
			switch (num)
			{
			case 4294967184u:
				if (text == "Travellers Rest")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-109));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					BHKJHFCJDKP();
				}
				break;
			case 4294967204u:
				if (text == ".")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					BHKJHFCJDKP();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 189u:
			if (text == "Cancel Crafting")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				IHOEEAHBCCF();
			}
			break;
		case 71u:
			if (text == "BackPain")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
				CJIFDGBEPPB();
			}
			break;
		case 42u:
			if (text == "Items/item_description_1040")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
				FJNBMBPBELE();
			}
			break;
		}
	}

	private void FJEBNIGFPJL()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[1].EFFKLBMAEMO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.KMKAIPMHANN(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void EBGEDECEPII()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.BKCGGLLLBCD();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[1].IPPLLPCPLBP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void EIMIELCGLME()
	{
		BOBCIFEDJED();
	}

	private void HBELDFKIINO()
	{
		CloseUI();
	}

	public static FarmAnimalUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IELDAMFIBJG()
	{
		CloseUI();
	}

	private void BNGKOKFJOKM()
	{
		CloseUI();
	}

	private void IHOEEAHBCCF()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.LILCGICDMEN();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[1].DPGOGNOOLCP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void FLMCBENIEAH()
	{
		BOBCIFEDJED();
	}

	private void HPNAHBPMKGD()
	{
		BOBCIFEDJED();
	}

	private void COKOMEOBGIC()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.DAEKAMPDAJH();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].EFFKLBMAEMO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OCJOJKJPDNO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public void HBNNPGCCFJL()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)7)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 75)
		{
			if (num <= 173)
			{
				switch (num)
				{
				case 4294967225u:
					if (text == "Trying to add a player that's already on the list.")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
						AHOFCINBBOI();
					}
					break;
				case 4294967173u:
					if (text == "Sweet")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-74));
						animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						LBJKBMGMOKH();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967265u:
				if (text == "itemCourgetteSeeds")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ICMBHNLFHNK();
				}
				break;
			case 4294967201u:
				if (text == "Items/item_name_1085")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
					MFEPPINCOBF();
				}
				break;
			case 4294967172u:
				if (text == "Invalid playerNum ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					CJIFDGBEPPB();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
			switch (num)
			{
			case 164u:
				if (text == "ReceiveKick")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(15));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
					FDJPMFDBFBB();
				}
				break;
			case 4294967169u:
				if (text == "ReceiveAddDrink")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ICMBHNLFHNK();
				}
				break;
			}
			break;
		case 199u:
			if (text == "Open")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
				FJEBNIGFPJL();
			}
			break;
		case 35u:
			if (text == "UIAddRemove")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
				BHKJHFCJDKP();
			}
			break;
		case 63u:
			if (text == "Right Stick Button")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
				EOFAJIKAJIG();
			}
			break;
		}
	}

	public static FarmAnimalUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmAnimalUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void KLEKFEFOILD()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)6)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= uint.MaxValue)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
			case 11u:
			case 12u:
			case 13u:
			case 14u:
			case 15u:
			case 16u:
			case 17u:
			case 18u:
			case 19u:
			case 20u:
			case 21u:
			case 22u:
			case 23u:
			case 24u:
			case 25u:
			case 26u:
			case 27u:
			case 28u:
			case 29u:
			case 30u:
			case 31u:
				switch (num)
				{
				case 4294967216u:
					if (text == "Items/item_name_1073")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						FJNBMBPBELE();
					}
					break;
				case 73u:
					if (text == "buildingObjective_17_0")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-25));
						animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
						ICMBHNLFHNK();
					}
					break;
				}
				break;
			case 4294967146u:
				if (text == "Sleeve_R")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					NEBOMGGJOPD();
				}
				break;
			case 186u:
				if (text == "ReceiveStopWork")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM);
					FJEBNIGFPJL();
				}
				break;
			case 4294967242u:
				if (text == "Cat")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
					FJNBMBPBELE();
				}
				break;
			}
			return;
		}
		if (num <= 4294967191u)
		{
			switch (num)
			{
			case 65u:
				if (text == "Player/Bark/Tutorial/SleepBlock")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
					PHNJFPEDEBK();
				}
				break;
			case 182u:
				if (text == "Farm/Event/VioletyBob")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
					PFPFHAGEOLG();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 198u:
			if (text == "Moving")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM);
				DGPPDBFJFNF();
			}
			break;
		case 1u:
			if (text == "Haggle")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
				FDJPMFDBFBB();
			}
			break;
		case 4294967185u:
			if (text == "ReceiveHeldItem")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				MEHIPBLHDCC();
			}
			break;
		}
	}

	private void NEBOMGGJOPD()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KBCEHEPDDHI();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[0].UpdateInfo(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void ENJCFNFIIMM()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FKNHELFHMNJ();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[0].ABPNEMONOBO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.KMKAIPMHANN(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void PPBJODIPGLN()
	{
		CloseUI();
	}

	private void FDJPMFDBFBB()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OPKIMBACIHA();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
			productionBarUI[1].OJEPPKBMCPO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public void HONOEPIHJAM()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != AnimalType.Cow)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 179)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
				switch (num)
				{
				case 4294967117u:
					if (text == "Closed")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
						NEBOMGGJOPD();
					}
					break;
				case 120u:
					if (text == "Error_SmallRoom")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-47));
						animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						EBGEDECEPII();
					}
					break;
				}
				break;
			case 4294967170u:
				if (text == "stuck recovery")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KMCGHAFAJIC();
				}
				break;
			case 185u:
				if (text == "Dial was ")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(animalNPC.NBMNBKEJHPM);
					IHOEEAHBCCF();
				}
				break;
			case 4294967215u:
				if (text == "City/Amos/Introduce")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
					AHOFCINBBOI();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 191u:
				if (text == "Error in DogNPC.TeleportToInitialPoint: ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM);
					EOFAJIKAJIG();
				}
				break;
			case 4294967280u:
				if (text == "")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					EOFAJIKAJIG();
				}
				break;
			case 4294967203u:
				if (text == "Guest")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KGDLEELKGEB();
				}
				break;
			}
			break;
		case 4294967120u:
			if (text == "quest_description_16")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(75));
				animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM);
				ACECOKOMJLG();
			}
			break;
		case 4294967132u:
			if (text == "BarIdleNumber")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM);
				MFEPPINCOBF();
			}
			break;
		}
	}

	public static FarmAnimalUI NDPAJCGHGOB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmAnimalUI PKNHLBOHEDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ChangeAnimalName()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type == AnimalType.Sheep)
		{
			switch (nameText.text)
			{
			case "Ahruon":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "AlexPoysky":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(10));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Alheab":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(9));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Jose D":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Mooruroa":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Sabrina":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Sergi":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Sh3ik":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "Shovah3D":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			case "The Bullet":
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
				break;
			}
		}
	}

	private void NJJGIHENLAA()
	{
		BOBCIFEDJED();
	}

	public static FarmAnimalUI BBDNJAKIBFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void ODHPCMKJIOK()
	{
		BOBCIFEDJED();
	}

	public void GPBIMJHPKOG()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)8)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967192u)
		{
			if (num <= 173)
			{
				switch (num)
				{
				case 185u:
					if (text == "Generate All Routes")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						EKNGDFMNPJB();
					}
					break;
				case 160u:
					if (text == "UpdatePopUP_")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(66));
						animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						OGHIPMNFBAN();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 151u:
				if (text == "LastWeekStats")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					COKOMEOBGIC();
				}
				break;
			case 95u:
				if (text == "UIPreviousPage")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
					LJNBPNHJJDG();
				}
				break;
			case 149u:
				if (text == "itemPumpkin")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KMCGHAFAJIC();
				}
				break;
			}
			return;
		}
		if (num <= 155)
		{
			switch (num)
			{
			case 4294967100u:
				if (text == "talentSoup")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(48));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
					MGAGMKGKCGJ();
				}
				break;
			case 138u:
				if (text == "Player/Bark/Tutorial/CrafterBlock")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					BCKIPLLDHMI();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 114u:
			if (text == "Items/item_name_731")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
				OGHIPMNFBAN();
			}
			break;
		case 152u:
			if (text == "Bar")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM);
				PHNJFPEDEBK();
			}
			break;
		case 4294967163u:
			if (text == "BathhouseGame/Lose")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
				MEEFCOPIGDM();
			}
			break;
		}
	}

	public void NCCCCCAAKFL()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != AnimalType.Sheep)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967174u)
		{
			if (num <= 174)
			{
				switch (num)
				{
				case 128u:
					if (text == "SendNPCDirection")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM);
						FJNBMBPBELE();
					}
					break;
				case 4294967172u:
					if (text == "Attempting to spawn more than one local player for online play. This is not supported.")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(10));
						animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
						BCKIPLLDHMI();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967194u:
				if (text == "Checking SignedIn status...")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
					COKOMEOBGIC();
				}
				break;
			case 4294967207u:
				if (text == "<color=black>")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					JAFKCFKJGPK();
				}
				break;
			case 136u:
				if (text == "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
					PFPFHAGEOLG();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 113u:
				if (text == "Received PlaceableMsg of another type not ContainerMsg to ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					PFPFHAGEOLG();
				}
				break;
			case 4294967212u:
				if (text == "<sprite name=reputationIcon>")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM);
					ICMBHNLFHNK();
				}
				break;
			case 62u:
				if (text == "ReceiveCompleteOrderQuest")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					BHKJHFCJDKP();
				}
				break;
			}
			break;
		case 116u:
			if (text == " ")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-116));
				animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				KMCGHAFAJIC();
			}
			break;
		case 34u:
			if (text == "Unaged Brie")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM);
				IHOEEAHBCCF();
			}
			break;
		}
	}

	private void JKPNDKJDMJG()
	{
		CloseUI();
	}

	public void JKEGIBDKDPJ()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != AnimalType.Cow)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967173u)
		{
			if (num <= 88)
			{
				switch (num)
				{
				case 4294967098u:
					if (text == "Kyroh not found path to at ")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM);
						AEGPPJFAOCD();
					}
					break;
				case 6u:
					if (text == "Items/item_description_1118")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(26));
						animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						OGHIPMNFBAN();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 99u:
				if (text == "Disabled")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					AEGPPJFAOCD();
				}
				break;
			case 4294967247u:
				if (text == "no tiene el spriteRenderer de las Seasons asignado")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KGDLEELKGEB();
				}
				break;
			case 51u:
				if (text == "Throw")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM);
					MEHIPBLHDCC();
				}
				break;
			}
			return;
		}
		if (num <= 126)
		{
			switch (num)
			{
			case 18u:
				if (text == "")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-66));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
					IHOEEAHBCCF();
				}
				break;
			case 104u:
				if (text == "ReceiveBirdMessage")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ENJCFNFIIMM();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 190u:
			if (text == "")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM);
				MLLIKCKMHOO();
			}
			break;
		case 90u:
			if (text == "talentWoodwork")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				AEGPPJFAOCD();
			}
			break;
		case 4294967170u:
			if (text == "Steam Lobby received on launch command: {0}")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				COKOMEOBGIC();
			}
			break;
		}
	}

	private void LJNBPNHJJDG()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KBCEHEPDDHI();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[0].ILHFKJDANBM(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public static FarmAnimalUI LIFMPGJIEKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CGBEIKHPCHL()
	{
		CloseUI();
	}

	public static FarmAnimalUI IEHEFJBFHJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CJNOFHBHDEP()
	{
		CloseUI();
	}

	public static FarmAnimalUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EPEABEJDPOE()
	{
		CloseUI();
	}

	public static FarmAnimalUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CHBFEBAENNC()
	{
		CloseUI();
	}

	private void KFPMOCCBLEM()
	{
		BOBCIFEDJED();
	}

	private void BDCEGPNJEJK()
	{
		CloseUI();
	}

	private void DAEGOOLKPIB()
	{
		CloseUI();
	}

	private void PHNJFPEDEBK()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[1].EHIMPKMEKHO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public void PIPOGIMKKLC()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)8)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 117)
		{
			if (num <= 4294967255u)
			{
				switch (num)
				{
				case 4294967260u:
					if (text == "Could not get status of achievement ")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						DGPPDBFJFNF();
					}
					break;
				case 170u:
					if (text == " ExitState().")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(84));
						animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						EKNGDFMNPJB();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 179u:
				if (text == "LE_10")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(animalNPC.NBMNBKEJHPM);
					FJNBMBPBELE();
				}
				break;
			case 4294967142u:
				if (text == "HitCollider")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					EJDAGIHKAHG();
				}
				break;
			case 116u:
				if (text == "ReceiveRemoveOrderQuestMaster")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					LJNBPNHJJDG();
				}
				break;
			}
			return;
		}
		if (num <= 4294967186u)
		{
			switch (num)
			{
			case 13u:
				if (text == "itemGruel")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-77));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
					EKNGDFMNPJB();
				}
				break;
			case 4294967129u:
				if (text == "</color>")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
					AHEGFMOEILC();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 87u:
			if (text == "Select Theme")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				NEBOMGGJOPD();
			}
			break;
		case 4294967214u:
			if (text == "")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				FEMFGFBGBLC();
			}
			break;
		case 172u:
			if (text == "Player")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				IHOEEAHBCCF();
			}
			break;
		}
	}

	private void LDENBEJCCMM()
	{
		BOBCIFEDJED();
	}

	public void EGFJAIBDKPE()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != AnimalType.Sheep)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 147)
		{
			if (num <= 4294967149u)
			{
				switch (num)
				{
				case 165u:
					if (text == "Moving")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
						CJIFDGBEPPB();
					}
					break;
				case 4294967147u:
					if (text == "Player/Bark/Tutorial/T138")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-40));
						animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						FEMFGFBGBLC();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967265u:
				if (text == "FishCuttingEvent/Lose2")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					EBGEDECEPII();
				}
				break;
			case 39u:
				if (text == "Dialogue System/Conversation/Crowly_Introduce/Entry/13/Dialogue Text")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM);
					FJNBMBPBELE();
				}
				break;
			case 111u:
				if (text == "DualShock")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM);
					DJAGJMJDIHN();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
			switch (num)
			{
			case 91u:
				if (text == "Top")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-8));
					animalNPC.FFHHEGALBKO.animalAnimator.PEECGCDGNOB(animalNPC.NBMNBKEJHPM);
					LBJKBMGMOKH();
				}
				break;
			case 134u:
				if (text == "Player2")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM);
					ENJCFNFIIMM();
				}
				break;
			}
			break;
		case 4294967242u:
			if (text == "")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM);
				ICMBHNLFHNK();
			}
			break;
		case 4294967130u:
			if (text == "itemLemon")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				KMCGHAFAJIC();
			}
			break;
		case 4294967186u:
			if (text == "Player/Bark/Tutorial/AgingBarrelBlock")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				OGHIPMNFBAN();
			}
			break;
		}
	}

	private void BHKJHFCJDKP()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.DAEKAMPDAJH();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[0].ILHFKJDANBM(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public void JHHLKNCPOMD()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != 0)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 156)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
				switch (num)
				{
				case 4294967146u:
					if (text == "Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						DGPPDBFJFNF();
					}
					break;
				case 20u:
					if (text == "Items/item_description_1144")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-98));
						animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM);
						AEGPPJFAOCD();
					}
					break;
				}
				break;
			case 36u:
				if (text == "dog ")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					FEMFGFBGBLC();
				}
				break;
			case 4294967158u:
				if (text == "[Variants] Piece {0} ({1}) has 1 variant and it's deactivated.")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					MLLIKCKMHOO();
				}
				break;
			case 4294967116u:
				if (text == "<color=#BF0000>")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					PFPFHAGEOLG();
				}
				break;
			}
			return;
		}
		if (num <= 113)
		{
			switch (num)
			{
			case 37u:
				if (text == "currentTutorialPhaseID ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(73));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					EBGEDECEPII();
				}
				break;
			case 4294967178u:
				if (text == "HammerFloor")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ACECOKOMJLG();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967200u:
			if (text == "No travel zone found for mine stairs destination ")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				AHOFCINBBOI();
			}
			break;
		case 64u:
			if (text == "GENERIC STATE - NAME UNDEFINED")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				OGHIPMNFBAN();
			}
			break;
		case 4294967112u:
			if (text == "add item ")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				EBGEDECEPII();
			}
			break;
		}
	}

	private void MCAGFAPOJCO()
	{
		BOBCIFEDJED();
	}

	public static FarmAnimalUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MKBKFDCJIBP()
	{
		BOBCIFEDJED();
	}

	private void HDPJCBGHDDA()
	{
		CloseUI();
	}

	public static FarmAnimalUI PIOIOJFDDNF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			GameActionBarUI.Get(base.JIIGOACEIKL).Close();
			base.OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
			NEBOMGGJOPD();
			LEABIPLMOJF = animalNPC.NBMNBKEJHPM.animalName;
			if (animalNPC.type == AnimalType.Pig)
			{
				production.SetActive(false);
			}
			else
			{
				production.SetActive(true);
			}
		}
	}

	public static FarmAnimalUI ENIICLMAPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OGHIPMNFBAN()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KBCEHEPDDHI();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
			productionBarUI[0].DPGOGNOOLCP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.KMKAIPMHANN(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CGBEIKHPCHL));
			FocusArrowUI.Get(base.JIIGOACEIKL).SetVisible(NKFPJPCFBJI: false);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			if (LEABIPLMOJF != animalNPC.NBMNBKEJHPM.animalName)
			{
				animalNPC.onlineAnimal.SendName();
			}
		}
	}

	private void DGPPDBFJFNF()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.BKCGGLLLBCD();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
			productionBarUI[1].UpdateInfo(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void MGAGMKGKCGJ()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FMCPFNCIJAB();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[0].EHIMPKMEKHO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public static FarmAnimalUI BDJFHFHLJGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FJNBMBPBELE()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].OJEPPKBMCPO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void EOFAJIKAJIG()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[1].LFLHCMHPMGA(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public static FarmAnimalUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void KGDLEELKGEB()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OHELBLMAGPP();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[0].IPPLLPCPLBP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void MEEFCOPIGDM()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FKNHELFHMNJ();
		for (int i = 1; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[0].OJEPPKBMCPO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.KMKAIPMHANN(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void KGPMDGMCPLD()
	{
		BOBCIFEDJED();
	}

	private void AEGPPJFAOCD()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KPNKJDPGNJK();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[0].OJEPPKBMCPO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	public void HLGMAAGPMNN()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)4)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967143u)
		{
			switch (num)
			{
			case 4294967281u:
			case 4294967282u:
			case 4294967283u:
			case 4294967284u:
			case 4294967285u:
			case 4294967286u:
			case 4294967287u:
			case 4294967288u:
			case 4294967289u:
			case 4294967290u:
			case 4294967291u:
			case 4294967292u:
			case 4294967293u:
			case 4294967294u:
			case uint.MaxValue:
				switch (num)
				{
				case 115u:
					if (text == "ChristmasPresent")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
						animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM);
						ACECOKOMJLG();
					}
					break;
				case 45u:
					if (text == "Items/item_description_641")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						COKOMEOBGIC();
					}
					break;
				case 4294967233u:
					if (text == "add item ")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
						animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						FJNBMBPBELE();
					}
					break;
				}
				break;
			case 4294967107u:
				if (text == "Items/item_description_1096")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
					AHOFCINBBOI();
				}
				break;
			case 148u:
				if (text == "Crowly_RaraAvis")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(23));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					FJNBMBPBELE();
				}
				break;
			}
			return;
		}
		if (num <= 155)
		{
			switch (num)
			{
			case 47u:
				if (text == "Idle")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-93));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KMCGHAFAJIC();
				}
				break;
			case 4294967263u:
				if (text == "You have to assign a UI camera!")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
					OGHIPMNFBAN();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967231u:
			if (text == "LE_5")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				EBGEDECEPII();
			}
			break;
		case 4294967271u:
			if (text == ",")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				EKNGDFMNPJB();
			}
			break;
		case 4294967100u:
			if (text == "F2")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM);
				ICMBHNLFHNK();
			}
			break;
		}
	}

	public void ONMLMJELADF()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)4)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967289u)
		{
			if (num <= 4294967097u)
			{
				switch (num)
				{
				case 31u:
					if (text == "ReceiveSitDown")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						LBJKBMGMOKH();
					}
					break;
				case 51u:
					if (text == "in")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-55));
						animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						NEBOMGGJOPD();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 49u:
				if (text == "Red text: ")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM);
					DGPPDBFJFNF();
				}
				break;
			case 4294967260u:
				if (text == "tutorialPopUp115")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					COKOMEOBGIC();
				}
				break;
			case 4294967235u:
				if (text == "Dialogue System/Conversation/TooHot/Entry/2/Dialogue Text")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					LBJKBMGMOKH();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
		case 77u:
		case 78u:
		case 79u:
		case 80u:
		case 81u:
		case 82u:
		case 83u:
		case 84u:
		case 85u:
		case 86u:
		case 87u:
		case 88u:
		case 89u:
		case 90u:
		case 91u:
		case 92u:
		case 93u:
		case 94u:
		case 95u:
		case 96u:
		case 97u:
		case 98u:
		case 99u:
			switch (num)
			{
			case 10u:
				if (text == "Next Trends")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-92));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					FJEBNIGFPJL();
				}
				break;
			case 167u:
				if (text == "Clean")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ACECOKOMJLG();
				}
				break;
			}
			break;
		case 4294967100u:
			if (text == "UI2")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
				OGHIPMNFBAN();
			}
			break;
		case 4294967245u:
			if (text == "LE_10")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM);
				IHOEEAHBCCF();
			}
			break;
		case 4294967222u:
			if (text == "Eat")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				ENJCFNFIIMM();
			}
			break;
		}
	}

	private void KGIACKKFILH()
	{
		BOBCIFEDJED();
	}

	private void PFPFHAGEOLG()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KPNKJDPGNJK();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
			productionBarUI[0].UpdateInfo(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public void IOMIHEAIOLA()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)4)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967121u)
		{
			if (num <= 4294967145u)
			{
				switch (num)
				{
				case 4294967106u:
					if (text == "BaseCamp")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.PEECGCDGNOB(animalNPC.NBMNBKEJHPM);
						PFPFHAGEOLG();
					}
					break;
				case 4294967252u:
					if (text == "Cycle Placeable Colors")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-116));
						animalNPC.FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						ICMBHNLFHNK();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 112u:
				if (text == "MainProgress")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM);
					IHOEEAHBCCF();
				}
				break;
			case 4294967176u:
				if (text == "Dialogue System/Conversation/BirdCatInteraction/Entry/5/Dialogue Text")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					FJNBMBPBELE();
				}
				break;
			case 144u:
				if (text == "El componente OnlinePlaceable del rotatedPrefab '")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KMCGHAFAJIC();
				}
				break;
			}
			return;
		}
		if (num <= 166)
		{
			switch (num)
			{
			case 34u:
				if (text == "ReceiveLastOrder")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-43));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					MFEPPINCOBF();
				}
				break;
			case 94u:
				if (text == "Farm/Buzz/Door_Bark_Searching")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
					ACECOKOMJLG();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967130u:
			if (text == "Invalid year: ")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				MEHIPBLHDCC();
			}
			break;
		case 4294967097u:
			if (text == "ReceiveAddFloor")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				FEMFGFBGBLC();
			}
			break;
		case 14u:
			if (text == "Sending ")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				FJNBMBPBELE();
			}
			break;
		}
	}

	public void KFICFLBAFDJ()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != 0)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967132u)
		{
			if (num <= 135)
			{
				switch (num)
				{
				case 164u:
					if (text == "DecorationTile_19")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						MEHIPBLHDCC();
					}
					break;
				case 4294967152u:
					if (text == "_")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(20));
						animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM);
						KMCGHAFAJIC();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 131u:
				if (text == "UI2")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					DGPPDBFJFNF();
				}
				break;
			case 39u:
				if (text == "Day")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
					BCKIPLLDHMI();
				}
				break;
			case 63u:
				if (text == "Year")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
					COKOMEOBGIC();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
		case 77u:
		case 78u:
		case 79u:
		case 80u:
		case 81u:
		case 82u:
		case 83u:
		case 84u:
		case 85u:
		case 86u:
		case 87u:
		case 88u:
			switch (num)
			{
			case 4294967171u:
				if (text == "ReceiveFinishKlaynChallenge")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-75));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
					MEEFCOPIGDM();
				}
				break;
			case 128u:
				if (text == "TimeLeft")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
					EKNGDFMNPJB();
				}
				break;
			}
			break;
		case 4294967226u:
			if (text == "Items/item_description_617")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
				BCKIPLLDHMI();
			}
			break;
		case 132u:
			if (text == "Disabled")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				COKOMEOBGIC();
			}
			break;
		case 142u:
			if (text == "City/Hallmund/Talk/GiveTool")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
				ANJENCIEDLM();
			}
			break;
		}
	}

	private void MGDCDIHOABF()
	{
		CloseUI();
	}

	private void FEMFGFBGBLC()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.OPKIMBACIHA();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].DFDLHCIGBCF(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public void HOJANCEPDMB()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != 0)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967214u)
		{
			switch (num)
			{
			case 4294967292u:
			case 4294967293u:
			case 4294967294u:
			case uint.MaxValue:
				switch (num)
				{
				case 176u:
					if (text == "Missing fade image")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
						animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						BHKJHFCJDKP();
					}
					break;
				case 152u:
					if (text == "[Action")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
						animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						OGHIPMNFBAN();
					}
					break;
				case 4294967280u:
					if (text == "MainProgress")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
						animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
						BCKIPLLDHMI();
					}
					break;
				}
				break;
			case 4294967258u:
				if (text == "Title Screen")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					FJNBMBPBELE();
				}
				break;
			case 156u:
				if (text == "itemAubergine")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-103));
					animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
					ICMBHNLFHNK();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
			switch (num)
			{
			case 4294967256u:
				if (text == "Items/item_description_1088")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-83));
					animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM);
					COKOMEOBGIC();
				}
				break;
			case 4294967245u:
				if (text == "ChristmasEvent")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					AHEGFMOEILC();
				}
				break;
			}
			break;
		case 136u:
			if (text == "OnlinePlayer")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
				MFEPPINCOBF();
			}
			break;
		case 4294967199u:
			if (text == "Sell")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
				FJEBNIGFPJL();
			}
			break;
		case 4294967149u:
			if (text == "No se encontró una entrada con ID {0} en la conversación '{1}'.")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
				LJNBPNHJJDG();
			}
			break;
		}
	}

	private void MLLIKCKMHOO()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FMCPFNCIJAB();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
			productionBarUI[1].OJEPPKBMCPO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OCJOJKJPDNO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public void EHLNGGEGJNH()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)4)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967224u)
		{
			switch (num)
			{
			case 4294967285u:
			case 4294967286u:
			case 4294967287u:
			case 4294967288u:
			case 4294967289u:
			case 4294967290u:
			case 4294967291u:
			case 4294967292u:
			case 4294967293u:
			case 4294967294u:
			case uint.MaxValue:
				switch (num)
				{
				case 125u:
					if (text == "Disabled")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
						animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						AHEGFMOEILC();
					}
					break;
				case 4294967152u:
					if (text == "</color>")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						CJIFDGBEPPB();
					}
					break;
				case 8u:
					if (text == "itemIPA")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
						animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						IHOEEAHBCCF();
					}
					break;
				}
				break;
			case 4294967224u:
				if (text == "meatDishes")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					FJNBMBPBELE();
				}
				break;
			case 4294967275u:
				if (text == "Dialogue System/Conversation/Crowly_Barks_Bye/Entry/2/Dialogue Text")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-17));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					IHOEEAHBCCF();
				}
				break;
			}
			return;
		}
		if (num <= 4294967148u)
		{
			switch (num)
			{
			case 9u:
				if (text == "ReceiveEndIntroLucen")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-44));
					animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM);
					LJNBPNHJJDG();
				}
				break;
			case 4294967243u:
				if (text == "add item ")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ACECOKOMJLG();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967288u:
			if (text == "- ")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
				LJNBPNHJJDG();
			}
			break;
		case 149u:
			if (text == "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/28/Dialogue Text")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				PHNJFPEDEBK();
			}
			break;
		case 4294967105u:
			if (text == "ReceiveAddReputationPoints")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
				PFPFHAGEOLG();
			}
			break;
		}
	}

	public void EKGCKJAIKHK()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)8)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 182)
		{
			if (num <= 198)
			{
				switch (num)
				{
				case 4294967192u:
					if (text == "Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						BHKJHFCJDKP();
					}
					break;
				case 4294967220u:
					if (text == " - ")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(48));
						animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
						MEEFCOPIGDM();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967247u:
				if (text == "Ingredient null!")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.KGIFGHKCOFC(animalNPC.NBMNBKEJHPM);
					ENJCFNFIIMM();
				}
				break;
			case 158u:
				if (text == "Trying to add player but player list is full.")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
					EKNGDFMNPJB();
				}
				break;
			case 22u:
				if (text == "+connect_lobby")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					NEBOMGGJOPD();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		default:
			if (num == uint.MaxValue && text == "Player2")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(87));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
				BHKJHFCJDKP();
			}
			break;
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 4294967115u:
				if (text == "Waiter")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
					EBGEDECEPII();
				}
				break;
			case 4294967270u:
				if (text == "Random name")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					AEGPPJFAOCD();
				}
				break;
			case 36u:
				if (text == "City/Rhia/Bark/Stand")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
					AHEGFMOEILC();
				}
				break;
			}
			break;
		case 4294967261u:
			if (text == " ")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
				LBJKBMGMOKH();
			}
			break;
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void HFAMLDMPNOD()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)6)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
		case 63u:
		case 64u:
		case 65u:
		case 66u:
		case 67u:
		case 68u:
		case 69u:
		case 70u:
		case 71u:
		case 72u:
		case 73u:
		case 74u:
		case 75u:
		case 76u:
		case 77u:
			if (num <= 121)
			{
				switch (num)
				{
				case 49u:
					if (text == "Harvest")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM);
						EBGEDECEPII();
					}
					break;
				case 193u:
					if (text == "Player/Bark/Tutorial/AgingBarrelBlock")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-109));
						animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM);
						MLLIKCKMHOO();
					}
					break;
				}
				break;
			}
			switch (num)
			{
			case 157u:
				if (text == "VerticalMove")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.PEECGCDGNOB(animalNPC.NBMNBKEJHPM);
					MFEPPINCOBF();
				}
				break;
			case 4294967116u:
				if (text == "NPC")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
					AHOFCINBBOI();
				}
				break;
			case 4294967163u:
				if (text == "Unsaved progress will be lost.")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
					animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					EKNGDFMNPJB();
				}
				break;
			}
			break;
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 44u:
				if (text == "Items/item_description_1086")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM);
					BHKJHFCJDKP();
				}
				break;
			case 4294967153u:
				if (text == "")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					EJDAGIHKAHG();
				}
				break;
			case 4294967140u:
				if (text == "The Cellar")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					BHKJHFCJDKP();
				}
				break;
			}
			break;
		case 194u:
			if (text == "City/PetShop/Markus/Intro")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-77));
				animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
				JAFKCFKJGPK();
			}
			break;
		case 4294967271u:
			if (text == "Invalid tavern floor {0}")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
				NEBOMGGJOPD();
			}
			break;
		}
	}

	private void JAFKCFKJGPK()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.KPNKJDPGNJK();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(0)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].UpdateInfo(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void KMCGHAFAJIC()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM));
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.LILCGICDMEN();
		for (int i = 0; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].UpdateInfo(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 1; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OBBKDJNLCIO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(true);
		}
	}

	private void DJAGJMJDIHN()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.LILCGICDMEN();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].DPGOGNOOLCP(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(false);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j++)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.OCJOJKJPDNO(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void LBJKBMGMOKH()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.DAEKAMPDAJH();
		for (int i = 1; i < levelSlots.Length; i += 0)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
			productionBarUI[0].DFDLHCIGBCF(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(true);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.Stack = list[j].amount;
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	private void AMDJNCALMOB()
	{
		BOBCIFEDJED();
	}

	public static FarmAnimalUI HINOELPNLLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AJEDBKGPLKD()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)6)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967176u)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
				switch (num)
				{
				case 4294967269u:
					if (text == "' no referencia correctamente al item '")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM);
						JAFKCFKJGPK();
					}
					break;
				case 21u:
					if (text == "buildingObjective_21_0")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-123));
						animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
						ICMBHNLFHNK();
					}
					break;
				}
				break;
			case 19u:
				if (text == "PirateMinigame/Minigame")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					CJIFDGBEPPB();
				}
				break;
			case 4294967270u:
				if (text == " ")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					EBGEDECEPII();
				}
				break;
			case 4294967254u:
				if (text == "Items/item_name_1082")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					FEMFGFBGBLC();
				}
				break;
			}
			return;
		}
		if (num <= 4294967187u)
		{
			switch (num)
			{
			case 4294967211u:
				if (text == "Sit")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(113));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM);
					BCKIPLLDHMI();
				}
				break;
			case 193u:
				if (text == "Dialogue System/Conversation/Gass_Barks_Bye/Entry/5/Dialogue Text")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM);
					LBJKBMGMOKH();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967247u:
			if (text == "\n<color=#822F00>")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				MGAGMKGKCGJ();
			}
			break;
		case 113u:
			if (text == "Game")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
				animalNPC.FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				KGDLEELKGEB();
			}
			break;
		case 4294967112u:
			if (text == "ReceiveUnlockHair")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
				animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				FJEBNIGFPJL();
			}
			break;
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
	}

	public static FarmAnimalUI KLJCCHJHDGG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PCKJMCMLNKF()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != AnimalType.Sheep)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967234u)
		{
			switch (num)
			{
			case 4294967255u:
			case 4294967256u:
			case 4294967257u:
			case 4294967258u:
			case 4294967259u:
			case 4294967260u:
			case 4294967261u:
			case 4294967262u:
			case 4294967263u:
			case 4294967264u:
			case 4294967265u:
			case 4294967266u:
			case 4294967267u:
			case 4294967268u:
			case 4294967269u:
			case 4294967270u:
			case 4294967271u:
			case 4294967272u:
			case 4294967273u:
			case 4294967274u:
			case 4294967275u:
			case 4294967276u:
			case 4294967277u:
			case 4294967278u:
			case 4294967279u:
			case 4294967280u:
			case 4294967281u:
			case 4294967282u:
			case 4294967283u:
			case 4294967284u:
			case 4294967285u:
			case 4294967286u:
			case 4294967287u:
			case 4294967288u:
			case 4294967289u:
			case 4294967290u:
			case 4294967291u:
			case 4294967292u:
			case 4294967293u:
			case 4294967294u:
			case uint.MaxValue:
				switch (num)
				{
				case 4294967280u:
					if (text == "Reducing quality water to Low")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
						animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM);
						KGDLEELKGEB();
					}
					break;
				case 4294967205u:
					if (text == "Items/item_name_1180")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
						animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						MLLIKCKMHOO();
					}
					break;
				case 4294967140u:
					if (text == "End")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
						animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						MFEPPINCOBF();
					}
					break;
				}
				break;
			case 12u:
				if (text == "ReceiveGetUniqueCropDayOnClient")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(animalNPC.NBMNBKEJHPM);
					JAFKCFKJGPK();
				}
				break;
			case 81u:
				if (text == "ReceiveIntroNinjaChallengeEventMoveZuzzu")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-5));
					animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
					EKNGDFMNPJB();
				}
				break;
			}
			return;
		}
		if (num <= 121)
		{
			switch (num)
			{
			case uint.MaxValue:
				if (text == "[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(17));
					animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM);
					IHOEEAHBCCF();
				}
				break;
			case 69u:
				if (text == "Items/item_description_699")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
					CJIFDGBEPPB();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967123u:
			if (text == "BarkActor")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				EKNGDFMNPJB();
			}
			break;
		case 4294967142u:
			if (text == "Player")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				MFEPPINCOBF();
			}
			break;
		case 4294967272u:
			if (text == "itemRedWine")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
				animalNPC.FFHHEGALBKO.animalAnimator.EPGDGJOPAJD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				ANJENCIEDLM();
			}
			break;
		}
	}

	public void BKBJCCBFHAD()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)5)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 192)
		{
			if (num <= 4294967197u)
			{
				switch (num)
				{
				case 4294967266u:
					if (text == "")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
						ICMBHNLFHNK();
					}
					break;
				case 192u:
					if (text == " platos")
					{
						animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-117));
						animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						BHKJHFCJDKP();
					}
					break;
				}
				return;
			}
			switch (num)
			{
			case 4294967192u:
				if (text == "Items/item_description_703")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM);
					IHOEEAHBCCF();
				}
				break;
			case 88u:
				if (text == "No empty bucket")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.FHJBLKBDOKN(animalNPC.NBMNBKEJHPM);
					MGAGMKGKCGJ();
				}
				break;
			case 26u:
				if (text == "LearnBalance")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					LJNBPNHJJDG();
				}
				break;
			}
			return;
		}
		if (num <= 190)
		{
			switch (num)
			{
			case 42u:
				if (text == "Items/item_name_1036")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(90));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
					ICMBHNLFHNK();
				}
				break;
			case 4294967235u:
				if (text == "City/Chuck/Introduce")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
					animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM);
					MGAGMKGKCGJ();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967101u:
			if (text == "Dialogue System/Conversation/EnterTavernDrink/Entry/2/Dialogue Text")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
				animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
				OGHIPMNFBAN();
			}
			break;
		case 127u:
			if (text == "Received mine loaded for client ")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(4));
				animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				MLLIKCKMHOO();
			}
			break;
		case 4294967290u:
			if (text == "MainProgress")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM);
				AHEGFMOEILC();
			}
			break;
		}
	}

	private void OPHILMKKHHL()
	{
		BOBCIFEDJED();
	}

	public static FarmAnimalUI NALKHGMLALJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmAnimalUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void MJNFCCGEACB()
	{
		BOBCIFEDJED();
	}

	private void EJDAGIHKAHG()
	{
		slotUI.IHENCGDNPBL.OLHGPMJPJFF(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FKNHELFHMNJ();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.FKLOBGBIHLB(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].JLCEMHMPPPG(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(false);
		}
		((Component)productionBarUI[0]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive((uint)animalNPC.type > 1u);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.OFJDJIBMIGE(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JNMNCEPHFOE(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k += 0)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public static FarmAnimalUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JGICGJNKCPM()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)6)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 4294967138u)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
			case 11u:
			case 12u:
			case 13u:
			case 14u:
			case 15u:
			case 16u:
			case 17u:
			case 18u:
			case 19u:
			case 20u:
			case 21u:
			case 22u:
			case 23u:
			case 24u:
			case 25u:
			case 26u:
			case 27u:
			case 28u:
			case 29u:
			case 30u:
			case 31u:
			case 32u:
			case 33u:
			case 34u:
			case 35u:
			case 36u:
			case 37u:
			case 38u:
			case 39u:
			case 40u:
			case 41u:
			case 42u:
			case 43u:
			case 44u:
			case 45u:
			case 46u:
			case 47u:
			case 48u:
			case 49u:
			case 50u:
			case 51u:
			case 52u:
			case 53u:
			case 54u:
			case 55u:
			case 56u:
			case 57u:
			case 58u:
			case 59u:
			case 60u:
			case 61u:
			case 62u:
			case 63u:
			case 64u:
			case 65u:
			case 66u:
			case 67u:
			case 68u:
			case 69u:
				switch (num)
				{
				case 4294967284u:
					if (text == "Player")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
						animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM);
						BHKJHFCJDKP();
					}
					break;
				case 4294967119u:
					if (text == "ValueSuitabilities")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-58));
						animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						MEHIPBLHDCC();
					}
					break;
				}
				break;
			default:
				if (num == 47 && text == "Cannot create Steam lobby.")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.PEECGCDGNOB(animalNPC.NBMNBKEJHPM);
					KGDLEELKGEB();
				}
				break;
			case 4294967127u:
				if (text == "Remove")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.FFOLBNHJIAD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					DJAGJMJDIHN();
				}
				break;
			case 4294967186u:
				if (text == "talentWoodwork")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ANJENCIEDLM();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
		case 5u:
		case 6u:
		case 7u:
		case 8u:
		case 9u:
		case 10u:
		case 11u:
		case 12u:
		case 13u:
		case 14u:
		case 15u:
		case 16u:
		case 17u:
		case 18u:
		case 19u:
		case 20u:
		case 21u:
		case 22u:
		case 23u:
		case 24u:
		case 25u:
		case 26u:
		case 27u:
		case 28u:
		case 29u:
		case 30u:
		case 31u:
		case 32u:
		case 33u:
		case 34u:
		case 35u:
		case 36u:
		case 37u:
		case 38u:
		case 39u:
		case 40u:
		case 41u:
		case 42u:
		case 43u:
		case 44u:
		case 45u:
		case 46u:
		case 47u:
		case 48u:
		case 49u:
		case 50u:
		case 51u:
		case 52u:
		case 53u:
		case 54u:
		case 55u:
		case 56u:
		case 57u:
		case 58u:
		case 59u:
		case 60u:
		case 61u:
		case 62u:
			switch (num)
			{
			case 55u:
				if (text == "MineState")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(53));
					animalNPC.FFHHEGALBKO.animalAnimator.MFJCPADIAMJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ANJENCIEDLM();
				}
				break;
			case 171u:
				if (text == "Items/item_description_621")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM);
					MLLIKCKMHOO();
				}
				break;
			}
			break;
		case 4294967177u:
			if (text == "Dialogue System/Conversation/DeclinedRoom/Entry/1/Dialogue Text")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
				animalNPC.FFHHEGALBKO.animalAnimator.AEBBABIBLND(animalNPC.NBMNBKEJHPM);
				LBJKBMGMOKH();
			}
			break;
		case 153u:
			if (text == "scaleUI")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.FFBFELKDNII(animalNPC.NBMNBKEJHPM);
				OGHIPMNFBAN();
			}
			break;
		case 4294967192u:
			if (text == "TutorialQuestion")
			{
				animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(3));
				animalNPC.FFHHEGALBKO.animalAnimator.DCAFPHAMHFC(animalNPC.NBMNBKEJHPM);
				ACECOKOMJLG();
			}
			break;
		}
	}

	public void JNDAAFGDMKN()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != (AnimalType)5)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		switch (num)
		{
		default:
			if (num == 4294967136u && text == "FindSeat")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-97));
				animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
				FDJPMFDBFBB();
			}
			break;
		case 4294967123u:
		case 4294967124u:
		case 4294967125u:
		case 4294967126u:
		case 4294967127u:
		case 4294967128u:
		case 4294967129u:
		case 4294967130u:
		case 4294967131u:
		case 4294967132u:
		case 4294967133u:
		case 4294967134u:
		case 4294967135u:
		case 4294967136u:
		case 4294967137u:
		case 4294967138u:
		case 4294967139u:
		case 4294967140u:
		case 4294967141u:
		case 4294967142u:
		case 4294967143u:
		case 4294967144u:
		case 4294967145u:
		case 4294967146u:
		case 4294967147u:
		case 4294967148u:
		case 4294967149u:
		case 4294967150u:
		case 4294967151u:
		case 4294967152u:
		case 4294967153u:
		case 4294967154u:
		case 4294967155u:
		case 4294967156u:
		case 4294967157u:
		case 4294967158u:
		case 4294967159u:
		case 4294967160u:
		case 4294967161u:
		case 4294967162u:
		case 4294967163u:
		case 4294967164u:
		case 4294967165u:
		case 4294967166u:
		case 4294967167u:
		case 4294967168u:
			switch (num)
			{
			case 130u:
				if (text == "Dead")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM);
					KGDLEELKGEB();
				}
				break;
			case 127u:
				if (text == " ")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
					animalNPC.FFHHEGALBKO.animalAnimator.HNAMLLBLGIG(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					KGDLEELKGEB();
				}
				break;
			case 4294967208u:
				if (text == "end conversations")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM);
					OGHIPMNFBAN();
				}
				break;
			}
			break;
		case 4294967169u:
		case 4294967170u:
		case 4294967171u:
		case 4294967172u:
		case 4294967173u:
		case 4294967174u:
		case 4294967175u:
		case 4294967176u:
		case 4294967177u:
		case 4294967178u:
		case 4294967179u:
		case 4294967180u:
		case 4294967181u:
		case 4294967182u:
		case 4294967183u:
		case 4294967184u:
		case 4294967185u:
		case 4294967186u:
		case 4294967187u:
		case 4294967188u:
		case 4294967189u:
		case 4294967190u:
		case 4294967191u:
		case 4294967192u:
		case 4294967193u:
		case 4294967194u:
		case 4294967195u:
		case 4294967196u:
		case 4294967197u:
		case 4294967198u:
		case 4294967199u:
		case 4294967200u:
		case 4294967201u:
		case 4294967202u:
		case 4294967203u:
		case 4294967204u:
		case 4294967205u:
		case 4294967206u:
		case 4294967207u:
		case 4294967208u:
		case 4294967209u:
		case 4294967210u:
		case 4294967211u:
		case 4294967212u:
		case 4294967213u:
		case 4294967214u:
		case 4294967215u:
		case 4294967216u:
		case 4294967217u:
		case 4294967218u:
		case 4294967219u:
		case 4294967220u:
		case 4294967221u:
		case 4294967222u:
		case 4294967223u:
		case 4294967224u:
		case 4294967225u:
		case 4294967226u:
		case 4294967227u:
		case 4294967228u:
		case 4294967229u:
		case 4294967230u:
		case 4294967231u:
		case 4294967232u:
			switch (num)
			{
			case 4294967112u:
				if (text == "Not enough ingredients")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(77));
					animalNPC.FFHHEGALBKO.animalAnimator.EPEJFHPAFFL(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					CJIFDGBEPPB();
				}
				break;
			case 4294967150u:
				if (text == "WheatAleAbbreviation")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					DGPPDBFJFNF();
				}
				break;
			}
			break;
		case 4294967233u:
		case 4294967234u:
		case 4294967235u:
		case 4294967236u:
		case 4294967237u:
		case 4294967238u:
		case 4294967239u:
		case 4294967240u:
		case 4294967241u:
		case 4294967242u:
		case 4294967243u:
		case 4294967244u:
		case 4294967245u:
		case 4294967246u:
		case 4294967247u:
		case 4294967248u:
		case 4294967249u:
		case 4294967250u:
		case 4294967251u:
		case 4294967252u:
		case 4294967253u:
		case 4294967254u:
		case 4294967255u:
		case 4294967256u:
		case 4294967257u:
		case 4294967258u:
		case 4294967259u:
		case 4294967260u:
		case 4294967261u:
		case 4294967262u:
		case 4294967263u:
		case 4294967264u:
		case 4294967265u:
		case 4294967266u:
		case 4294967267u:
		case 4294967268u:
		case 4294967269u:
		case 4294967270u:
		case 4294967271u:
		case 4294967272u:
		case 4294967273u:
		case 4294967274u:
		case 4294967275u:
		case 4294967276u:
		case 4294967277u:
		case 4294967278u:
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 39u:
				if (text == "veggieDishes")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ICMBHNLFHNK();
				}
				break;
			case 13u:
				if (text == "ReceiveHeldItem")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
					animalNPC.FFHHEGALBKO.animalAnimator.BMNJLEAAJLN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					MGAGMKGKCGJ();
				}
				break;
			case 4294967243u:
				if (text == "Reputation decreased...")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(6));
					animalNPC.FFHHEGALBKO.animalAnimator.NINEAKFMMNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					ACECOKOMJLG();
				}
				break;
			}
			break;
		case 119u:
			if (text == "WaterTrough")
			{
				animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(0));
				animalNPC.FFHHEGALBKO.animalAnimator.CHAOEBIPCFJ(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				IHOEEAHBCCF();
			}
			break;
		}
	}

	private void EKNGDFMNPJB()
	{
		slotUI.IHENCGDNPBL.ONIFGHNHCPP(base.JIIGOACEIKL, new AnimalInstance(animalNPC.NBMNBKEJHPM), CDPAMNIPPEC: true);
		nameText.text = animalNPC.NBMNBKEJHPM.animalName;
		((TMP_Text)birthdayText).text = animalNPC.NBMNBKEJHPM.birthday.FMCPFNCIJAB();
		for (int i = 0; i < levelSlots.Length; i++)
		{
			levelSlots[i].SetActive(i < animalNPC.maxLevel);
			((Component)levelSlots[i].transform.GetChild(1)).gameObject.SetActive(i < animalNPC.level);
		}
		checkBoxFood.SetActive(animalNPC.hasFood);
		checkBoxWater.SetActive(animalNPC.hasWater);
		checkBoxWalk.SetActive(animalNPC.hasWalked);
		if (Item.MLBOMGHINCA(animalNPC.CMOBLFMDNKF.productionItem.item, null))
		{
			((Component)productionBarUI[0]).gameObject.SetActive(true);
			productionBarUI[1].GJFBILHHNCO(animalNPC.GetNumTasksDone(), animalNPC.productionProgress, animalNPC.CMOBLFMDNKF.productionItem);
		}
		else
		{
			((Component)productionBarUI[1]).gameObject.SetActive(true);
		}
		((Component)productionBarUI[1]).gameObject.SetActive(true);
		checkBoxWalkGameObject.SetActive(animalNPC.type != AnimalType.Chicken);
		List<ItemAmount> list = animalNPC.CMOBLFMDNKF.LPCKMEJAODN(animalNPC.level);
		for (int j = 0; j < list.Count; j += 0)
		{
			((Component)sacrificeSlotsUI[j]).gameObject.SetActive(false);
			sacrificeSlotsUI[j].IHENCGDNPBL.DOOMMIJPGOO(base.JIIGOACEIKL, list[j].item);
			sacrificeSlotsUI[j].IHENCGDNPBL.JIANDFCINIP(list[j].amount);
		}
		for (int k = list.Count; k < sacrificeSlotsUI.Length; k++)
		{
			((Component)sacrificeSlotsUI[k]).gameObject.SetActive(false);
		}
	}

	public void NLGODNMAJAE()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		animalNPC.NBMNBKEJHPM.animalName = nameText.text;
		if (animalNPC.type != AnimalType.Pig)
		{
			return;
		}
		string text = nameText.text;
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text);
		if (num <= 193)
		{
			switch (num)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
				switch (num)
				{
				case 4294967098u:
					if (text == "Dialogue System/Conversation/Rowdy/Entry/2/Dialogue Text")
					{
						animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
						animalNPC.FFHHEGALBKO.animalAnimator.SetAnimalSkin(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
						EOFAJIKAJIG();
					}
					break;
				case 150u:
					if (text == "Items/item_name_673")
					{
						animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-24));
						animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
						LBJKBMGMOKH();
					}
					break;
				}
				break;
			case 4294967143u:
				if (text == "Items/item_description_1154")
				{
					animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.LNPBJECICNH(animalNPC.NBMNBKEJHPM);
					AEGPPJFAOCD();
				}
				break;
			case 4294967168u:
				if (text == "questDescFirstCustomers")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					PHNJFPEDEBK();
				}
				break;
			case 187u:
				if (text == "Sleepy")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(2));
					animalNPC.FFHHEGALBKO.animalAnimator.IOPDGOIGBPL(animalNPC.NBMNBKEJHPM);
					MEEFCOPIGDM();
				}
				break;
			}
			return;
		}
		switch (num)
		{
		case 4294967279u:
		case 4294967280u:
		case 4294967281u:
		case 4294967282u:
		case 4294967283u:
		case 4294967284u:
		case 4294967285u:
		case 4294967286u:
		case 4294967287u:
		case 4294967288u:
		case 4294967289u:
		case 4294967290u:
		case 4294967291u:
		case 4294967292u:
		case 4294967293u:
		case 4294967294u:
		case uint.MaxValue:
			switch (num)
			{
			case 4294967119u:
				if (text == "/")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(8));
					animalNPC.FFHHEGALBKO.animalAnimator.LGCKPJCGCAK(animalNPC.NBMNBKEJHPM);
					DGPPDBFJFNF();
				}
				break;
			case 168u:
				if (text == "R2")
				{
					animalNPC.NBMNBKEJHPM.GBNPMEBJCFD((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(5));
					animalNPC.FFHHEGALBKO.animalAnimator.BOMOGFIEKHD(animalNPC.NBMNBKEJHPM);
					LJNBPNHJJDG();
				}
				break;
			case 4294967111u:
				if (text == "Received {0} appearance data as byte array: {1}")
				{
					animalNPC.NBMNBKEJHPM.AMLAIHJAILK((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(7));
					animalNPC.FFHHEGALBKO.animalAnimator.ELDGKDDLHNN(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
					BHKJHFCJDKP();
				}
				break;
			}
			break;
		case 4294967247u:
			if (text == "UIPreviousPage")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(-92));
				animalNPC.FFHHEGALBKO.animalAnimator.DLKMKOMMOEK(animalNPC.NBMNBKEJHPM, OBDGKOCOLIN: true);
				DJAGJMJDIHN();
			}
			break;
		case 4294967267u:
			if (text == "/")
			{
				animalNPC.NBMNBKEJHPM.DIFBBFPBECP((animalNPC.CMOBLFMDNKF as Sheep).DKBKBEJKOFA(1));
				animalNPC.FFHHEGALBKO.animalAnimator.HKCIJHIJPBG(animalNPC.NBMNBKEJHPM);
				DGPPDBFJFNF();
			}
			break;
		}
	}

	public static FarmAnimalUI LOBGJNFHBJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static FarmAnimalUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
