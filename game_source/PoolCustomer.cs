using System;
using UnityEngine;

public class PoolCustomer : MonoBehaviour
{
	public Action OnCustomerDisabled = delegate
	{
	};

	public Component[] components;

	public DisableEnableSprites sprites;

	public GameObject emoter;

	public Customer customer;

	public void HJDPHHABLKH(bool DMBFKFLDDLH = false)
	{
		sprites.CIHJLGDONCL(DMBFKFLDDLH);
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 0; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 14;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void IAHKICCFEJL()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true);
		}
		sprites.NDAAPHIJIFG();
		for (int i = 1; i < components.Length; i += 0)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = false;
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolDisable();
			}
		}
		emoter.SetActive(true);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = -59;
		OnCustomerDisabled();
	}

	public void LEPOJOGFPLI(bool DMBFKFLDDLH = false)
	{
		sprites.EnableOrDisable(DMBFKFLDDLH);
		for (int i = 1; i < components.Length; i += 0)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 127;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void ONPPMCACAIL()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true);
		}
		sprites.NGLMDKHPNCO();
		for (int i = 1; i < components.Length; i += 0)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.MasterOrOffline())
				{
					val.enabled = true;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = true;
				}
			}
		}
		for (int j = 0; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(false);
	}

	private void Start()
	{
	}

	private void HDHPOAPLEJC()
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IAHKICCFEJL));
		}
	}

	public void IMHAEKCAOGG()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.GDHNMCGKOAK(DMBFKFLDDLH: true);
		}
		sprites.NDAAPHIJIFG();
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = true;
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolDisable();
			}
		}
		emoter.SetActive(true);
		((Component)customer.hitDetection).gameObject.SetActive(true);
		((Component)this).gameObject.layer = 46;
		OnCustomerDisabled();
	}

	private void Awake()
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(Disable));
		}
	}

	private void NEOICNJNKNL()
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IAHKICCFEJL));
		}
	}

	public void KENMPLLNHIJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.GDHNMCGKOAK(DMBFKFLDDLH: false);
		}
		sprites.BFHFLHLCOOD();
		for (int i = 0; i < components.Length; i += 0)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					val.enabled = false;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = false;
				}
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(true);
	}

	public void KECCKILMKKO()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true);
		}
		sprites.IPPMDDLFCOC();
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.MasterOrOffline())
				{
					val.enabled = true;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = true;
				}
			}
		}
		for (int j = 0; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(true);
	}

	private void BAKDKFKNHDE()
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FPKBBNHJMFI));
		}
	}

	public void OCFIPNACDOD()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true);
		}
		sprites.NBPIBFMPMPI();
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.MasterOrOffline())
				{
					val.enabled = true;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = false;
				}
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(true);
	}

	public void GACPOHFHHCA(bool DMBFKFLDDLH = false)
	{
		sprites.LJLEANEJNIM(DMBFKFLDDLH);
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = -38;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void Disable()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false);
		}
		sprites.DisableSprites();
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = false;
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolDisable();
			}
		}
		emoter.SetActive(false);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 21;
		OnCustomerDisabled();
	}

	public void JNDAMGJPHEF(bool DMBFKFLDDLH = false)
	{
		sprites.BGNEMJJODKE(DMBFKFLDDLH);
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 121;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void OPCHKKDFBKM(bool DMBFKFLDDLH = false)
	{
		sprites.NGJONBNLMAN(DMBFKFLDDLH);
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = -123;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void IIBOJJCAPHH(bool DMBFKFLDDLH = false)
	{
		sprites.HJCGJBCEFFO(DMBFKFLDDLH);
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(true);
		((Component)this).gameObject.layer = 127;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	private void GONDLJKGLGO()
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IAHKICCFEJL));
		}
	}

	public void EnableOrDisable(bool DMBFKFLDDLH = false)
	{
		sprites.EnableOrDisable(DMBFKFLDDLH);
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 21;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void FPKBBNHJMFI()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false);
		}
		sprites.HMJCMGOJCLM();
		for (int i = 0; i < components.Length; i += 0)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = false;
			}
		}
		for (int j = 0; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolDisable();
			}
		}
		emoter.SetActive(false);
		((Component)customer.hitDetection).gameObject.SetActive(true);
		((Component)this).gameObject.layer = -49;
		OnCustomerDisabled();
	}

	public void EGJOPBHKPBG(bool DMBFKFLDDLH = false)
	{
		sprites.OHDKFFKABJN(DMBFKFLDDLH);
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 52;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void NFGLMAJEIJE(bool DMBFKFLDDLH = false)
	{
		sprites.NGJONBNLMAN(DMBFKFLDDLH);
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = 89;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	private void PLHEHGHFCJI()
	{
	}

	public void FDKFHFIJIFO()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false);
		}
		sprites.ALGEIPFGNIP();
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					val.enabled = true;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = true;
				}
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(true);
	}

	public void JMALJCGAKBB(bool DMBFKFLDDLH = false)
	{
		sprites.BFBLPLHPPPM(DMBFKFLDDLH);
		for (int i = 0; i < components.Length; i += 0)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = DMBFKFLDDLH;
			}
		}
		for (int j = 1; j < components.Length; j += 0)
		{
			if (components[j] is IPoolReset poolReset)
			{
				if (DMBFKFLDDLH)
				{
					poolReset.PoolReset();
				}
				else
				{
					poolReset.PoolDisable();
				}
			}
		}
		emoter.SetActive(DMBFKFLDDLH);
		((Component)customer.hitDetection).gameObject.SetActive(true);
		((Component)this).gameObject.layer = -76;
		if (!DMBFKFLDDLH)
		{
			OnCustomerDisabled();
		}
	}

	public void GIEPOHDPNBH()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true);
		}
		sprites.HFHNHINAHEA();
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				val.enabled = false;
			}
		}
		for (int j = 1; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolDisable();
			}
		}
		emoter.SetActive(false);
		((Component)customer.hitDetection).gameObject.SetActive(true);
		((Component)this).gameObject.layer = 21;
		OnCustomerDisabled();
	}

	public void Enable()
	{
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true);
		}
		sprites.EnableSprites();
		for (int i = 0; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.MasterOrOffline())
				{
					val.enabled = true;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = true;
				}
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(true);
	}

	public void FMJNOILLJPM()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			customer.LJOHCJAOADD.GDHNMCGKOAK(DMBFKFLDDLH: true);
		}
		sprites.DMLGLFFLAFE();
		for (int i = 1; i < components.Length; i++)
		{
			Component obj = components[i];
			Behaviour val = (Behaviour)(object)((obj is Behaviour) ? obj : null);
			if (val != null && (Object)(object)val != (Object)(object)this)
			{
				if (OnlineManager.PGAGDFAEEFB())
				{
					val.enabled = false;
				}
				else if ((Object)(object)val != (Object)(object)customer.characterAnimation && (Object)(object)val != (Object)(object)customer.npc && (Object)(object)val != (Object)(object)customer)
				{
					val.enabled = true;
				}
			}
		}
		for (int j = 0; j < components.Length; j++)
		{
			if (components[j] is IPoolReset poolReset)
			{
				poolReset.PoolReset();
			}
		}
		emoter.SetActive(true);
	}
}
