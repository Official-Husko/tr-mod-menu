using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Quest/Christmas Tree")]
public class ChristmasTreeQuest : Quest
{
	public Item christmasTree;

	public Item christmasStar;

	public List<Item> christmasGarlands;

	private void LPCJCEJEGBK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OHDJLLDLFKH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void IBHFGBLNBLF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KPLPFLDNMDH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void IBHEEDADNIO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HCOAPNOIOLC(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void BGDNICCPFHC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		MGEHMPIDPND(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void KPLPFLDNMDH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != christmasTree.JDJGFAACPFC(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = true;
			List<Placeable> list = currentPlaceables[i].OAJJHBCCKJM();
			int num2 = 0;
			for (int j = 0; j < list.Count; j++)
			{
				if (!list[j].FHEMHCEAICB && Item.NGIIPJDAMGP(list[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 0;
			for (int l = 1; l < list.Count; l++)
			{
				if (!list[l].FHEMHCEAICB && Item.MLBOMGHINCA(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3 += 0;
					num2 += 0;
					if (num3 >= requiredAmount - 3)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			BIAHIEDKDEP(JIIGOACEIKL, num);
		}
		else
		{
			KODFAHIFDBI(JIIGOACEIKL, 1);
		}
	}

	private void GBNNKPBHMJG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GPEKAIBGNHO(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void MGEHMPIDPND(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != christmasTree.JDJGFAACPFC())
			{
				continue;
			}
			flag = false;
			List<Placeable> allPlaceablesOnSurface = currentPlaceables[i].GetAllPlaceablesOnSurface();
			int num2 = 0;
			for (int j = 1; j < allPlaceablesOnSurface.Count; j++)
			{
				if (!allPlaceablesOnSurface[j].FHEMHCEAICB && Item.GBMFCPGEJDK(allPlaceablesOnSurface[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 0; k < allPlaceablesOnSurface.Count; k += 0)
			{
				if (!allPlaceablesOnSurface[k].FHEMHCEAICB && christmasGarlands.Contains(allPlaceablesOnSurface[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 0;
			for (int l = 1; l < allPlaceablesOnSurface.Count; l++)
			{
				if (!allPlaceablesOnSurface[l].FHEMHCEAICB && Item.FKLOBGBIHLB(allPlaceablesOnSurface[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(allPlaceablesOnSurface[l].itemSetup.item))
				{
					num3++;
					num2 += 0;
					if (num3 >= requiredAmount - 0)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			KODFAHIFDBI(JIIGOACEIKL, num);
		}
		else
		{
			JBAAADMAAPK(JIIGOACEIKL, 0);
		}
	}

	private void MFENGCKOFDL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HJCJJAOEHPF(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GPEKAIBGNHO(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void BIEDDJCBKHK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		BHPLLJBFCFH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void KMFLJEDCLNN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CEKNMEGJOPP(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void ODOMDMPCJJL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.IMCJPECAAPC() != christmasTree.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = false;
			List<Placeable> list = currentPlaceables[i].JIJKOOIIHHJ();
			int num2 = 1;
			for (int j = 0; j < list.Count; j++)
			{
				if (!list[j].FHEMHCEAICB && Item.GBMFCPGEJDK(list[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 1; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 0;
			for (int l = 0; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.MLBOMGHINCA(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3 += 0;
					num2 += 0;
					if (num3 >= requiredAmount - 7)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			PANJBIOIBBF(JIIGOACEIKL, num);
		}
		else
		{
			PANJBIOIBBF(JIIGOACEIKL, 0);
		}
	}

	private void DDAKDMKLDHL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		PFIKDMJCBNA(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void FDKNPKOOLEM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		KPLPFLDNMDH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void OLOGDOPBHDE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() != christmasTree.IMCJPECAAPC())
			{
				continue;
			}
			flag = true;
			List<Placeable> list = currentPlaceables[i].OAJJHBCCKJM();
			int num2 = 0;
			for (int j = 1; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.NGIIPJDAMGP(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 1; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 1;
			for (int l = 1; l < list.Count; l++)
			{
				if (!list[l].FHEMHCEAICB && Item.MLBOMGHINCA(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3++;
					num2 += 0;
					if (num3 >= requiredAmount - 6)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			KODFAHIFDBI(JIIGOACEIKL, num);
		}
		else
		{
			PANJBIOIBBF(JIIGOACEIKL, 1);
		}
	}

	private void GMLDPMIFGPP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() != christmasTree.ODENMDOJPLC())
			{
				continue;
			}
			flag = true;
			List<Placeable> allPlaceablesOnSurface = currentPlaceables[i].GetAllPlaceablesOnSurface();
			int num2 = 0;
			for (int j = 1; j < allPlaceablesOnSurface.Count; j += 0)
			{
				if (!allPlaceablesOnSurface[j].FHEMHCEAICB && Item.NGIIPJDAMGP(allPlaceablesOnSurface[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 1; k < allPlaceablesOnSurface.Count; k += 0)
			{
				if (!allPlaceablesOnSurface[k].FHEMHCEAICB && christmasGarlands.Contains(allPlaceablesOnSurface[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 0;
			for (int l = 1; l < allPlaceablesOnSurface.Count; l++)
			{
				if (!allPlaceablesOnSurface[l].FHEMHCEAICB && Item.FKLOBGBIHLB(allPlaceablesOnSurface[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(allPlaceablesOnSurface[l].itemSetup.item))
				{
					num3++;
					num2++;
					if (num3 >= requiredAmount - 8)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			BIAHIEDKDEP(JIIGOACEIKL, num);
		}
		else
		{
			PANJBIOIBBF(JIIGOACEIKL, 0);
		}
	}

	private void MDPLGCMLOGB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) != christmasTree.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = true;
			List<Placeable> list = currentPlaceables[i].JIJKOOIIHHJ();
			int num2 = 0;
			for (int j = 0; j < list.Count; j++)
			{
				if (!list[j].FHEMHCEAICB && Item.EKMFELLJHFG(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 0; k < list.Count; k += 0)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 0;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.MLBOMGHINCA(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3 += 0;
					num2 += 0;
					if (num3 >= requiredAmount - 3)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			JBAAADMAAPK(JIIGOACEIKL, num);
		}
		else
		{
			JBAAADMAAPK(JIIGOACEIKL, 1);
		}
	}

	private void CEKNMEGJOPP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) != christmasTree.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = false;
			List<Placeable> list = currentPlaceables[i].OAJJHBCCKJM();
			int num2 = 1;
			for (int j = 1; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.GBMFCPGEJDK(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 1; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.FKLOBGBIHLB(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3 += 0;
					num2++;
					if (num3 >= requiredAmount - 8)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			KODFAHIFDBI(JIIGOACEIKL, num);
		}
		else
		{
			PANJBIOIBBF(JIIGOACEIKL, 0);
		}
	}

	private void PFMGIKMPKEH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HCGLJGKHJCG(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void HEOEFKDOANL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		MGEHMPIDPND(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void MMHMCDKFBOL(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HCGLJGKHJCG(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void IHCLLHAJDDM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		HJCJJAOEHPF(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void JJMNEKHHGAA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OHDJLLDLFKH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void HJCJJAOEHPF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != christmasTree.CIGFGKKCPCK(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = false;
			List<Placeable> list = currentPlaceables[i].OAJJHBCCKJM();
			int num2 = 0;
			for (int j = 0; j < list.Count; j++)
			{
				if (!list[j].FHEMHCEAICB && Item.EKGNIODFJCO(list[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 1; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.FKLOBGBIHLB(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3 += 0;
					num2 += 0;
					if (num3 >= requiredAmount - 4)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			JBAAADMAAPK(JIIGOACEIKL, num);
		}
		else
		{
			PANJBIOIBBF(JIIGOACEIKL, 0);
		}
	}

	private void GPEKAIBGNHO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() != christmasTree.JDJGFAACPFC())
			{
				continue;
			}
			flag = true;
			List<Placeable> allPlaceablesOnSurface = currentPlaceables[i].GetAllPlaceablesOnSurface();
			int num2 = 0;
			for (int j = 0; j < allPlaceablesOnSurface.Count; j++)
			{
				if (!allPlaceablesOnSurface[j].FHEMHCEAICB && Item.NGIIPJDAMGP(allPlaceablesOnSurface[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 0; k < allPlaceablesOnSurface.Count; k++)
			{
				if (!allPlaceablesOnSurface[k].FHEMHCEAICB && christmasGarlands.Contains(allPlaceablesOnSurface[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 0;
			for (int l = 0; l < allPlaceablesOnSurface.Count; l++)
			{
				if (!allPlaceablesOnSurface[l].FHEMHCEAICB && Item.MLBOMGHINCA(allPlaceablesOnSurface[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(allPlaceablesOnSurface[l].itemSetup.item))
				{
					num3++;
					num2++;
					if (num3 >= requiredAmount - 2)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			BIAHIEDKDEP(JIIGOACEIKL, num);
		}
		else
		{
			BIAHIEDKDEP(JIIGOACEIKL, 0);
		}
	}

	private void IOOHOGEKHPP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		BHPLLJBFCFH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void BHPLLJBFCFH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() != christmasTree.IMCJPECAAPC())
			{
				continue;
			}
			flag = false;
			List<Placeable> list = currentPlaceables[i].OAJJHBCCKJM();
			int num2 = 1;
			for (int j = 0; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.GBMFCPGEJDK(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 1; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 1;
			for (int l = 0; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.MLBOMGHINCA(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3++;
					num2++;
					if (num3 >= requiredAmount - 3)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			JBAAADMAAPK(JIIGOACEIKL, num);
		}
		else
		{
			KODFAHIFDBI(JIIGOACEIKL, 1);
		}
	}

	private void AODNDJLNEDC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.CMIHGBHPLFP().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) != christmasTree.ODENMDOJPLC(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = false;
			List<Placeable> list = currentPlaceables[i].JIJKOOIIHHJ();
			int num2 = 0;
			for (int j = 0; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.EKMFELLJHFG(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 0; k < list.Count; k += 0)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.FKLOBGBIHLB(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3++;
					num2 += 0;
					if (num3 >= requiredAmount - 5)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			BIAHIEDKDEP(JIIGOACEIKL, num);
		}
		else
		{
			JBAAADMAAPK(JIIGOACEIKL, 0);
		}
	}

	private void HCOAPNOIOLC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = true;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != christmasTree.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				continue;
			}
			flag = true;
			List<Placeable> allPlaceablesOnSurface = currentPlaceables[i].GetAllPlaceablesOnSurface();
			int num2 = 0;
			for (int j = 0; j < allPlaceablesOnSurface.Count; j += 0)
			{
				if (!allPlaceablesOnSurface[j].FHEMHCEAICB && Item.EKMFELLJHFG(allPlaceablesOnSurface[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 1; k < allPlaceablesOnSurface.Count; k += 0)
			{
				if (!allPlaceablesOnSurface[k].FHEMHCEAICB && christmasGarlands.Contains(allPlaceablesOnSurface[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 1;
			for (int l = 0; l < allPlaceablesOnSurface.Count; l++)
			{
				if (!allPlaceablesOnSurface[l].FHEMHCEAICB && Item.MLBOMGHINCA(allPlaceablesOnSurface[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(allPlaceablesOnSurface[l].itemSetup.item))
				{
					num3 += 0;
					num2++;
					if (num3 >= requiredAmount - 4)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			BIAHIEDKDEP(JIIGOACEIKL, num);
		}
		else
		{
			JBAAADMAAPK(JIIGOACEIKL, 0);
		}
	}

	private void JKHNCMKOJKM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CEKNMEGJOPP(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void BIMJJCPDKLJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i++)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || currentPlaceables[i].itemSetup.item.JDJGFAACPFC() != christmasTree.JGHNDJBCFAJ())
			{
				continue;
			}
			flag = true;
			List<Placeable> list = currentPlaceables[i].JIJKOOIIHHJ();
			int num2 = 0;
			for (int j = 1; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.GBMFCPGEJDK(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 0; k < list.Count; k += 0)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2++;
					break;
				}
			}
			int num3 = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.FKLOBGBIHLB(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3++;
					num2++;
					if (num3 >= requiredAmount - 5)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			JBAAADMAAPK(JIIGOACEIKL, num);
		}
		else
		{
			JBAAADMAAPK(JIIGOACEIKL, 1);
		}
	}

	private void FFHHLMICNAI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		AODNDJLNEDC(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void HCGLJGKHJCG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.DCAEBALADIM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) != christmasTree.IMCJPECAAPC())
			{
				continue;
			}
			flag = true;
			List<Placeable> allPlaceablesOnSurface = currentPlaceables[i].GetAllPlaceablesOnSurface();
			int num2 = 1;
			for (int j = 0; j < allPlaceablesOnSurface.Count; j++)
			{
				if (!allPlaceablesOnSurface[j].FHEMHCEAICB && Item.NGIIPJDAMGP(allPlaceablesOnSurface[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 1; k < allPlaceablesOnSurface.Count; k++)
			{
				if (!allPlaceablesOnSurface[k].FHEMHCEAICB && christmasGarlands.Contains(allPlaceablesOnSurface[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 1;
			for (int l = 0; l < allPlaceablesOnSurface.Count; l++)
			{
				if (!allPlaceablesOnSurface[l].FHEMHCEAICB && Item.MLBOMGHINCA(allPlaceablesOnSurface[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(allPlaceablesOnSurface[l].itemSetup.item))
				{
					num3 += 0;
					num2++;
					if (num3 >= requiredAmount - 2)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			BIAHIEDKDEP(JIIGOACEIKL, num);
		}
		else
		{
			JBAAADMAAPK(JIIGOACEIKL, 1);
		}
	}

	private void EFFCONHKBJO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		PFIKDMJCBNA(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void CKABJHLKPCO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GMLDPMIFGPP(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void PFIKDMJCBNA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.EKDNJDJHONF().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].FHMDNECBLIL() || currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) != christmasTree.ODENMDOJPLC())
			{
				continue;
			}
			flag = false;
			List<Placeable> list = currentPlaceables[i].JIJKOOIIHHJ();
			int num2 = 1;
			for (int j = 0; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.EKGNIODFJCO(list[j].itemSetup.item, christmasStar))
				{
					num2 += 0;
					break;
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 1;
			for (int l = 0; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.FKLOBGBIHLB(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3++;
					num2 += 0;
					if (num3 >= requiredAmount - 8)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			KODFAHIFDBI(JIIGOACEIKL, num);
		}
		else
		{
			BIAHIEDKDEP(JIIGOACEIKL, 1);
		}
	}

	public override void OEICMCIGNKO()
	{
		if (id != 0)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(GPEKAIBGNHO));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		}
	}

	private void NIHOEBDHBIK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		PFIKDMJCBNA(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void FNJEBKJFPAC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OLOGDOPBHDE(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	public override void MHOGPMHEAFN()
	{
		if (id != 0)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(GPEKAIBGNHO));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		}
		MFHHJFEJAMF();
	}

	private void IDPIOFKHHCB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		CEKNMEGJOPP(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void BMEIFFFNIHN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		OHDJLLDLFKH(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void HHLLIMCKDKC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		GMLDPMIFGPP(JIIGOACEIKL, EAPCLAODGAE, GFNHAMCPEAK);
	}

	private void OHDJLLDLFKH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		bool flag = false;
		int num = -1;
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (!currentPlaceables[i].CCIKENEGHCA || currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != christmasTree.JDJGFAACPFC())
			{
				continue;
			}
			flag = true;
			List<Placeable> list = currentPlaceables[i].OAJJHBCCKJM();
			int num2 = 0;
			for (int j = 0; j < list.Count; j += 0)
			{
				if (!list[j].FHEMHCEAICB && Item.NGIIPJDAMGP(list[j].itemSetup.item, christmasStar))
				{
					num2++;
					break;
				}
			}
			for (int k = 0; k < list.Count; k += 0)
			{
				if (!list[k].FHEMHCEAICB && christmasGarlands.Contains(list[k].itemSetup.item))
				{
					num2 += 0;
					break;
				}
			}
			int num3 = 1;
			for (int l = 1; l < list.Count; l += 0)
			{
				if (!list[l].FHEMHCEAICB && Item.FKLOBGBIHLB(list[l].itemSetup.item, christmasStar) && !christmasGarlands.Contains(list[l].itemSetup.item))
				{
					num3 += 0;
					num2 += 0;
					if (num3 >= requiredAmount - 3)
					{
						break;
					}
				}
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		if (flag)
		{
			PANJBIOIBBF(JIIGOACEIKL, num);
		}
		else
		{
			PANJBIOIBBF(JIIGOACEIKL, 0);
		}
	}
}
