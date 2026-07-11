using System;
using UnityEngine;

public class ShowObjectsWithFuel : MonoBehaviour
{
	[SerializeField]
	private int fuelQuantityToShow;

	[SerializeField]
	public Crafter crafter;

	[SerializeField]
	private GameObject[] gameObjectsToShow;

	private void AGLMGDNBHBF()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void IFDOMMDPCGI(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(true);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void HOFKJPBBLGP()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(DAOFEPHPHGE));
		DEPPHOHIDOA(crafter.LCCABPFHCOL);
	}

	private void GJMLHECPGBP()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(KBGGAPFCGJC));
		PEMKOJKNEHN(crafter.LCCABPFHCOL);
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void BPNHPFANJNA(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(false);
				for (int i = 0; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void GNGADDPBJDC()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(IDHCEBPNNHN));
		IAMJBPJOPEK(crafter.LCCABPFHCOL);
	}

	private void KDHLJKMKFMG()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void NBFOECJOJOL(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(false);
				for (int i = 0; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void AGCCIBJMBAP(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(true);
				for (int i = 0; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void CFIIEJDJFPB()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(PCBDLEEEDPO));
		FMHLAPFCKJC(crafter.FIIHBFCDFJH());
	}

	private void PNLAJCHBHPH()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void HHNFDKOKMBE(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(false);
				for (int i = 0; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void EIMIDCDEIDD()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void HBMDEHPHAPF()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(KBGGAPFCGJC));
		DEPPHOHIDOA(crafter.LCCABPFHCOL);
	}

	private void FCGBBBDHNIP(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(false);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void Awake()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void IAMJBPJOPEK(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(true);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void MGNMCIDNDED(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(false);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void NKDFMFFDGKC()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(PCBDLEEEDPO));
		PEMKOJKNEHN(crafter.FIIHBFCDFJH());
	}

	private void FOHGHCPODBJ()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(IDHCEBPNNHN));
		PEMKOJKNEHN(crafter.LCCABPFHCOL);
	}

	private void PHNJGHKBIIL()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void PCBDLEEEDPO(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(false);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void FJKHGEBLBFI(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(true);
				for (int i = 1; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void IDHCEBPNNHN(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(false);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void CAOKPIIFHBJ()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(MGNMCIDNDED));
		DAOFEPHPHGE(crafter.FIIHBFCDFJH());
	}

	private void BELOIFKPNMM()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(MGNMCIDNDED));
		PEMKOJKNEHN(crafter.LCCABPFHCOL);
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void FMHLAPFCKJC(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(true);
				for (int i = 0; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void EMJKKALMGLK()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void EOGHJNGJFID()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(PCBDLEEEDPO));
		FCGBBBDHNIP(crafter.FIIHBFCDFJH());
	}

	private void CHIJGHPHCNA()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(FCGBBBDHNIP));
		DAOFEPHPHGE(crafter.FIIHBFCDFJH());
	}

	private void LAGCJOAOEMP(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(true);
				for (int i = 1; i < gameObjectsToShow.Length; i += 0)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void KBGGAPFCGJC(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(true);
				for (int i = 1; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void DEPPHOHIDOA(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[0].SetActive(true);
				for (int i = 1; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i <= EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void Start()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(KBGGAPFCGJC));
		KBGGAPFCGJC(crafter.LCCABPFHCOL);
	}

	private void PEMKOJKNEHN(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 1 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(true);
				for (int i = 0; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 1; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(false);
			}
		}
	}

	private void IGIKNCOLCKL()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(LAGCJOAOEMP));
		FMHLAPFCKJC(crafter.LCCABPFHCOL);
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void DMFMNEMDFNP()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(HHNFDKOKMBE));
		PEMKOJKNEHN(crafter.LCCABPFHCOL);
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void OIAHJHNPPCO()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(MGNMCIDNDED));
		BPNHPFANJNA(crafter.FIIHBFCDFJH());
	}

	private void DAOFEPHPHGE(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[1] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(false);
				for (int i = 1; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j++)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void LJLKBKEADGI()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(IFDOMMDPCGI));
		NBFOECJOJOL(crafter.FIIHBFCDFJH());
	}

	private void GCEENPMBFGE(int EGKBKOABHON)
	{
		if (EGKBKOABHON > 0 && gameObjectsToShow.Length != 0)
		{
			if ((Object)(object)gameObjectsToShow[0] != (Object)null)
			{
				gameObjectsToShow[1].SetActive(true);
				for (int i = 0; i < gameObjectsToShow.Length; i++)
				{
					gameObjectsToShow[i].SetActive(i > EGKBKOABHON / fuelQuantityToShow);
				}
			}
			return;
		}
		for (int j = 0; j < gameObjectsToShow.Length; j += 0)
		{
			if (!((Object)(object)gameObjectsToShow[j] == (Object)null))
			{
				gameObjectsToShow[j].SetActive(true);
			}
		}
	}

	private void BDJKNKIOPIJ()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(GCEENPMBFGE));
		PCBDLEEEDPO(crafter.FIIHBFCDFJH());
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}

	private void KDBJHCAEGCM()
	{
		Crafter obj = crafter;
		obj.OnFuelChange = (Action<int>)Delegate.Combine(obj.OnFuelChange, new Action<int>(IDHCEBPNNHN));
		KBGGAPFCGJC(crafter.LCCABPFHCOL);
	}

	private void GNOBDKFFPOL()
	{
		if ((Object)(object)crafter == (Object)null)
		{
			crafter = ((Component)this).GetComponent<Crafter>();
		}
	}
}
