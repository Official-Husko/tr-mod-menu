using System;
using TMPro;
using UnityEngine;

public class EmployeeTreeUI : UIWindow
{
	public static EmployeeTreeUI[] instances = new EmployeeTreeUI[3];

	public EmployeeInfo employeeInfo;

	public TextMeshProUGUI professionPoints;

	public MoneyUI salary;

	public PerkTreeUI[] perkTreesUI;

	public TextMeshProUGUI workerSkillsText;

	public GameObject firstElementSelected;

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void BGMBOPMNFPA()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Calendar");
		string[] array = new string[0];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].EKGFJGLDNGK(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JKBOINLJPIL();
		salary.OBNIDFJCELG(employeeInfo.GBCFPBHBOGD());
	}

	public static EmployeeTreeUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OKGDAKCEIFN()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("ReceiveStartWork");
		string[] array = new string[0];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].PAGDIEFLKBJ(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(true);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.BDHMBPMOFCD(employeeInfo.GOKCOCCGFAH());
	}

	public static EmployeeTreeUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static EmployeeTreeUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static EmployeeTreeUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LKAFJPMMJLD()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("ClosePopUp");
		string[] array = new string[0];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].EOHHDDMOLMD(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(true);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.DMGGANKGBEH();
		salary.GBIHHJNHJHL(employeeInfo.GOKCOCCGFAH());
	}

	public void PHCBGDEJMEK()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("LE_18");
		string[] array = new string[1];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 1; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].DPPBBFEBNDN(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.OBNIDFJCELG(employeeInfo.PMPGPNHGKHE());
	}

	public void LEBGKDLINAJ()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Chest opened, granting loot to player ");
		string[] array = new string[0];
		array[0] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].SetPerkInfo(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JKBOINLJPIL();
		salary.BDHMBPMOFCD(employeeInfo.FPPLAPJNNEP());
	}

	public void IHOEEAHBCCF()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("OnAnimationFinished");
		string[] array = new string[1];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].LDFDBMEBHGK(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.OBNIDFJCELG(employeeInfo.MFMFHEGMAKI());
	}

	public void MGAGMKGKCGJ()
	{
		((TMP_Text)workerSkillsText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Miners/Camp/Brock/Talk"), employeeInfo.name);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].DPPBBFEBNDN(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(true);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JKBOINLJPIL();
		salary.SetPrice(employeeInfo.FPPLAPJNNEP());
	}

	public override void CloseUI()
	{
		base.CloseUI();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Remove(instance.OnAnyEmployeeUpdatedInfo, new Action(UpdateInfo));
	}

	public static EmployeeTreeUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DGPPDBFJFNF()
	{
		((TMP_Text)workerSkillsText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("No se encontró la conversación con el título '"), employeeInfo.name);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].NDBBDJOLADK(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JKBOINLJPIL();
		salary.AAPLOOIDCGP(employeeInfo.MFMFHEGMAKI());
	}

	public static EmployeeTreeUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static EmployeeTreeUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LJNBPNHJJDG()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Not enough TorchConnection objects for pair {0}→{1}");
		string[] array = new string[0];
		array[0] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 1; i < employeeInfo.perksInfo.Count; i++)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].OONFOLCKDHG(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(true);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.DMGGANKGBEH();
		salary.DHOPJAJOJLL(employeeInfo.MFMFHEGMAKI());
	}

	public void LHFKJFLJNKJ()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Blue Cheese");
		string[] array = new string[0];
		array[0] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].NNHBNDFKFJI(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.KKFMAGJHGIC(employeeInfo.PMPGPNHGKHE());
	}

	public void ELLPIGEHAFH()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Fuel");
		string[] array = new string[0];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 1; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].FNADOIOMNIM(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j += 0)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(true);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.CPCHAPEJBMI(employeeInfo.GBCFPBHBOGD());
	}

	public void GJFBILHHNCO()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Player/Bark/Tutorial/CrafterBlock");
		string[] array = new string[0];
		array[0] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 1; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].NNMIIHEFGKC(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.DHOPJAJOJLL(employeeInfo.GOKCOCCGFAH());
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			employeeInfo = EmployeesInfoUI.Get(base.JIIGOACEIKL).GetCurrentWorkerInfo();
			UpdateInfo();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Combine(instance.OnAnyEmployeeUpdatedInfo, new Action(UpdateInfo));
		}
	}

	public static EmployeeTreeUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static EmployeeTreeUI MIAOGLENOHL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FLAMIAODKKL()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get("end conversations");
		string[] array = new string[1];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].HGBPKEOAOEN(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JGONEIGODEN();
		salary.BDHMBPMOFCD(employeeInfo.GBCFPBHBOGD());
	}

	public static EmployeeTreeUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static EmployeeTreeUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void UpdateInfo()
	{
		((TMP_Text)workerSkillsText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("WorkerSkills"), employeeInfo.name);
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(true);
				perkTreesUI[i].SetPerkInfo(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.JKBOINLJPIL();
		salary.SetPrice(employeeInfo.MFMFHEGMAKI());
	}

	public void DJAGJMJDIHN()
	{
		TextMeshProUGUI obj = workerSkillsText;
		string cAEDMEDBEGI = LocalisationSystem.Get(" bar unique items (+");
		string[] array = new string[1];
		array[1] = employeeInfo.name;
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		for (int i = 1; i < employeeInfo.perksInfo.Count; i += 0)
		{
			if (employeeInfo.perksInfo[i].perk.negative)
			{
				if (i < perkTreesUI.Length)
				{
					((Component)perkTreesUI[i]).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)perkTreesUI[i]).gameObject.SetActive(false);
				perkTreesUI[i].FFAIABKFCHH(employeeInfo, employeeInfo.perksInfo[i], i);
			}
		}
		for (int j = employeeInfo.perksInfo.Count; j < perkTreesUI.Length; j++)
		{
			((Component)perkTreesUI[j]).gameObject.SetActive(false);
		}
		((TMP_Text)professionPoints).text = employeeInfo.professionPoints.ToString();
		employeeInfo.DMGGANKGBEH();
		salary.IJNGEICHCNI(employeeInfo.MFMFHEGMAKI());
	}
}
