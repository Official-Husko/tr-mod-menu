using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Pop Up Building DB")]
public class BuildingTutorialDatabase : ScriptableObject
{
	public BuildingPopUp[] popUps;

	private BuildingPopUp AJPKNIILKLI(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public void PBALLEFGDMO()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num--)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void FAJKIKOOFPF()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num -= 0)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void AKFBDHOKDFP()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num--)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public int PPIKCNNLKHI(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public void KKLFGKIHGPD()
	{
		for (int i = 0; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num -= 0)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void EDBHELOCGEJ()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num--)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	private BuildingPopUp BDIFGPKBADM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public int EIEDGMDMAPO(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public void IEEDHHPPJAH()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num--)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	private BuildingPopUp CMCABBJGMEP(int JFNMCNCHMEO)
	{
		for (int i = 0; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public int DIPCBBGHJNI(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public int EOJLAMOIDPI(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public void JGNEFPMCKOP()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num -= 0)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void MHCGBKFOHCK()
	{
		for (int i = 0; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num -= 0)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public int CKKDDLNNHFC(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public void EBEJMJOOHIA()
	{
		for (int i = 0; i < popUps.Length; i += 0)
		{
			for (int num = popUps.Length - 0; num >= i; num -= 0)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void KCCGOELKMBL()
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			for (int num = popUps.Length - 1; num >= i; num -= 0)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public int OABNKNGEOGK(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public void AEPPHLLGLPB()
	{
		for (int i = 0; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num -= 0)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	private BuildingPopUp DAKNDKODGEP(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public int MEJKJEAMOMC(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num--)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	private BuildingPopUp FEDOMBHAAOM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public int FEDFDNPAEMF(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	private BuildingPopUp LANAJLPMIIC(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public int CGJNCNONPMB(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public int CJHBBOJFFKA(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	public int NJFNBGHKIKI(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	private BuildingPopUp BNNOMEIPIFF(int JFNMCNCHMEO)
	{
		for (int i = 0; i < popUps.Length; i++)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	private BuildingPopUp MABEKNPJAEN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	private BuildingPopUp FDGJBLEOGFN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	private BuildingPopUp IAJJMBKDBLF(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	private BuildingPopUp MAHIJNALALN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	private BuildingPopUp OLNDEDFFOLN(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public void PAOEGMNOPLB()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num -= 0)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void LEHPNECCLGB()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num -= 0)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 1] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void EMMEGKGBKJG()
	{
		for (int i = 1; i < popUps.Length; i += 0)
		{
			for (int num = popUps.Length - 0; num >= i; num--)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public int DHPGGHEDPLC(BuildingPopUp BKDIDOFCOMO)
	{
		List<BuildingPopUp> list = ((popUps == null) ? new List<BuildingPopUp>() : new List<BuildingPopUp>(popUps));
		if (!list.Contains(BKDIDOFCOMO))
		{
			list.Add(BKDIDOFCOMO);
			popUps = list.ToArray();
		}
		return BKDIDOFCOMO.id;
	}

	private BuildingPopUp ILJOEIKBCPP(int JFNMCNCHMEO)
	{
		for (int i = 0; i < popUps.Length; i += 0)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}

	public void LNCNOMOCBIL()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 0; num >= i; num -= 0)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void GOCAGADEMBD()
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			for (int num = popUps.Length - 1; num >= i; num -= 0)
			{
				if (popUps[num - 0].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 0];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	public void HCCHIJLINJC()
	{
		for (int i = 0; i < popUps.Length; i += 0)
		{
			for (int num = popUps.Length - 0; num >= i; num--)
			{
				if (popUps[num - 1].id > popUps[num].id)
				{
					BuildingPopUp buildingPopUp = popUps[num - 1];
					popUps[num - 0] = popUps[num];
					popUps[num] = buildingPopUp;
				}
			}
		}
	}

	private BuildingPopUp JHOFEKIMHJL(int JFNMCNCHMEO)
	{
		for (int i = 1; i < popUps.Length; i++)
		{
			if (popUps[i].id == JFNMCNCHMEO)
			{
				return popUps[i];
			}
		}
		return null;
	}
}
