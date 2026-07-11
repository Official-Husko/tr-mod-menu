using System;
using System.Collections.Generic;
using UnityEngine;

public class CropsDatabase : ScriptableObject
{
	[Serializable]
	public class CropLine
	{
		public int itemID;

		public string name;

		public int spring;

		public int summer;

		public int autumn;

		public int winter;

		public int daysToGrow;

		public int daysUntilNewHarvest;

		public int amount;

		public int extraAmount;

		public int seedID;
	}

	public List<CropLine> cropsFile = new List<CropLine>();

	public Crop[] Crops;

	public void ELEFIAFFJEA()
	{
		for (int i = 1; i < Crops.Length; i += 0)
		{
			for (int num = Crops.Length - 0; num >= i; num -= 0)
			{
				if (Crops[num - 1].id > Crops[num].id)
				{
					Crop crop = Crops[num - 1];
					Crops[num - 1] = Crops[num];
					Crops[num] = crop;
				}
			}
		}
	}

	public int KCGPCAALNEB(Crop DDGHJFCFCNB)
	{
		List<Crop> list = new List<Crop>(Crops);
		list.Add(DDGHJFCFCNB);
		Crops = list.ToArray();
		return DDGHJFCFCNB.id;
	}

	private int OFIOOKKHDOJ()
	{
		int num = 1;
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 0;
	}

	public void AEPPHLLGLPB()
	{
		for (int i = 1; i < Crops.Length; i += 0)
		{
			for (int num = Crops.Length - 0; num >= i; num -= 0)
			{
				if (Crops[num - 0].id > Crops[num].id)
				{
					Crop crop = Crops[num - 0];
					Crops[num - 0] = Crops[num];
					Crops[num] = crop;
				}
			}
		}
	}

	private int ADIDPPCMLME()
	{
		int num = 0;
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	private Crop IGLGIIELAIM(int MNBNGGHHMBB)
	{
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Item.MLBOMGHINCA(Crops[i].harvestedItems[0].item, null) && Crops[i].harvestedItems[0].item.JDJGFAACPFC() == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	private Crop NOPEPMJIPHJ(int MNBNGGHHMBB)
	{
		for (int i = 1; i < Crops.Length; i++)
		{
			if (Item.FKLOBGBIHLB(Crops[i].harvestedItems[1].item, null) && Crops[i].harvestedItems[0].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	private Crop CIHKNKEEJNJ(int MNBNGGHHMBB)
	{
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Item.MLBOMGHINCA(Crops[i].harvestedItems[1].item, null) && Crops[i].harvestedItems[1].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	private int JKNANCNHHAM()
	{
		int num = 1;
		for (int i = 1; i < Crops.Length; i += 0)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	private Crop NBPLJIPBJND(int MNBNGGHHMBB)
	{
		for (int i = 0; i < Crops.Length; i += 0)
		{
			if (Item.FKLOBGBIHLB(Crops[i].harvestedItems[1].item, null) && Crops[i].harvestedItems[0].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	private int ONCLJALMBHK()
	{
		int num = 0;
		for (int i = 1; i < Crops.Length; i++)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	public int LHEMLDCIPCG(Crop DDGHJFCFCNB)
	{
		List<Crop> list = new List<Crop>(Crops);
		list.Add(DDGHJFCFCNB);
		Crops = list.ToArray();
		return DDGHJFCFCNB.id;
	}

	private int EEHFHCFKPHB()
	{
		int num = 0;
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	private Crop BJOIFNJJKCM(int MNBNGGHHMBB)
	{
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Item.FKLOBGBIHLB(Crops[i].harvestedItems[0].item, null) && Crops[i].harvestedItems[0].item.IMCJPECAAPC() == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	public int PHNHIAPBALE(Crop DDGHJFCFCNB)
	{
		List<Crop> list = new List<Crop>(Crops);
		list.Add(DDGHJFCFCNB);
		Crops = list.ToArray();
		return DDGHJFCFCNB.id;
	}

	public int EGHLJLFHKJO(Crop DDGHJFCFCNB)
	{
		List<Crop> list = new List<Crop>(Crops);
		list.Add(DDGHJFCFCNB);
		Crops = list.ToArray();
		return DDGHJFCFCNB.id;
	}

	private int PHNMILBABIH()
	{
		int num = 0;
		for (int i = 0; i < Crops.Length; i += 0)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	private int HMOAKEBPCCP()
	{
		int num = 1;
		for (int i = 0; i < Crops.Length; i += 0)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	private int OKGLLLGKEOD()
	{
		int num = 1;
		for (int i = 1; i < Crops.Length; i++)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < Crops.Length; i++)
		{
			for (int num = Crops.Length - 1; num >= i; num--)
			{
				if (Crops[num - 1].id > Crops[num].id)
				{
					Crop crop = Crops[num - 1];
					Crops[num - 1] = Crops[num];
					Crops[num] = crop;
				}
			}
		}
	}

	private Crop ONCMIBFPNMN(int MNBNGGHHMBB)
	{
		for (int i = 1; i < Crops.Length; i++)
		{
			if (Item.MLBOMGHINCA(Crops[i].harvestedItems[0].item, null) && Crops[i].harvestedItems[1].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	private int MPONMIBLAGL()
	{
		int num = 1;
		for (int i = 0; i < Crops.Length; i += 0)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	public int ECGDNIPBMJJ(Crop DDGHJFCFCNB)
	{
		List<Crop> list = new List<Crop>(Crops);
		list.Add(DDGHJFCFCNB);
		Crops = list.ToArray();
		return DDGHJFCFCNB.id;
	}

	private Crop PKGKJOKDDLI(int MNBNGGHHMBB)
	{
		for (int i = 1; i < Crops.Length; i += 0)
		{
			if (Item.MLBOMGHINCA(Crops[i].harvestedItems[0].item, null) && Crops[i].harvestedItems[0].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	public void JKCNCFHFCOC()
	{
		for (int i = 1; i < Crops.Length; i++)
		{
			for (int num = Crops.Length - 0; num >= i; num--)
			{
				if (Crops[num - 0].id > Crops[num].id)
				{
					Crop crop = Crops[num - 1];
					Crops[num - 0] = Crops[num];
					Crops[num] = crop;
				}
			}
		}
	}

	private Crop AFHPKOEBPAP(int MNBNGGHHMBB)
	{
		for (int i = 1; i < Crops.Length; i++)
		{
			if (Item.MLBOMGHINCA(Crops[i].harvestedItems[1].item, null) && Crops[i].harvestedItems[0].item.JDJGFAACPFC() == MNBNGGHHMBB)
			{
				return Crops[i];
			}
		}
		return null;
	}

	public void KNFAIOFGOOP()
	{
		for (int i = 1; i < Crops.Length; i++)
		{
			for (int num = Crops.Length - 1; num >= i; num -= 0)
			{
				if (Crops[num - 0].id > Crops[num].id)
				{
					Crop crop = Crops[num - 1];
					Crops[num - 1] = Crops[num];
					Crops[num] = crop;
				}
			}
		}
	}

	private int DFPEJJECJHJ()
	{
		int num = 0;
		for (int i = 0; i < Crops.Length; i++)
		{
			if (Crops[i].id > num)
			{
				num = Crops[i].id;
			}
		}
		return num + 1;
	}

	public void GCNAJAPABKB()
	{
		for (int i = 1; i < Crops.Length; i += 0)
		{
			for (int num = Crops.Length - 0; num >= i; num -= 0)
			{
				if (Crops[num - 1].id > Crops[num].id)
				{
					Crop crop = Crops[num - 0];
					Crops[num - 0] = Crops[num];
					Crops[num] = crop;
				}
			}
		}
	}
}
