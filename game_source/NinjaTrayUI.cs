using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinjaTrayUI : UIWindow
{
	public static NinjaTrayUI[] instances = new NinjaTrayUI[3];

	public Image[] ingredientsTray;

	public Image[] ingredientsBento;

	public GameObject ticketsUI;

	public GameObject bentoUI;

	public Progressor trayRadialKey;

	public Progressor trayRadialButton;

	public Progressor bentoTrayRadialKey;

	public Progressor bentoTrayRadialButton;

	public static NinjaTrayUI LAMFGLIGLOP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LKLNBODCCJG(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HOELPLEFFIF(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void OMAEEIIADLD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI JGNOJMLHPOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OEJDJIALKNP(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void BIICMCCLFJI(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FGJCMOADFDO(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void IBIMEIIAHDE(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI LAIEKOOCNPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PGNGFGKLDOH(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI ANPKEGFMLED(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IOOJCLPKOLK(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI DPBGKDNKDGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CEFDMBKPHDM(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void ANMEOAEEFFP(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void FEOIMCHKDBO(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void PPDEKPEKCAA(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI HKCAIFFKBMH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JDKAAOFGMKJ(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void DPBFFBDAEPP(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void FGAFCNLMBCF(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI HDMPJKMLFML(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DADJHAPIMFA(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void JDMPFHPCNHL(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void CHAHMMDBKBM(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI IJJJEMKCNJM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DICFCHLEKOH(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void AMMFMAMEDGF(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void BOGHIMAJMLL(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void MJMKPNOCEID(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void MCOEKPIPJLH(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void MNMADGAKLBI(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void EFIKKELDJCM(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void MLNLKOKDCEG(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void BHHPAAGBODH(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void HCKKAIPIHLP(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CLOHHIMDOGA(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void GPCLFLPJEOF(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void KLHBCJLIILJ(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI AGNKKAPMHLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI MLJJHLNAGBP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JHOHEBEHELD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void BMBCACHLEDK(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void AMKNOLNOMBO(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void NBGBKJNJLCL(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI LPJPJMPOHPG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OHKKJGBOPPI(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI KPDICMKELDP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void COEHCKILKFB(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void UpdateTrayUI(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void GPJNJEGAPLN(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI OMOLNKBLGOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FIFMDJPFOHK(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FJFAIFJDPIC(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ELBKMFOKOJD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void JCOAJHNOOPL(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI OCCEHEMCGJF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ICKFOPGNDMD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void JAGKCNJPGDE(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public override void OpenUI()
	{
		base.OpenUI();
		UpdateTrayUI(null);
		UpdateBentoUI(null);
	}

	public void HENBLBEJKCI(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void LCFOELLLBHA(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void DMNOJDNMDFN(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void GFNBDLJDNIA(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void FOHGMPGPHIG(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI LMEMFKKKMGJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GGPHJCOLIMI(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void CLLCPFEONMC(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI BBDNJAKIBFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PFPCECJDPPH(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void NMGKGPDMELK(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI KMBADAHDAML(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CFOCGKGPLDP(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void NBNBOIEPGMJ(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void INFGOHMJFJL(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI KNMACJDNGEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DABMFONDJLN(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void PCDNDDDBMKF(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void HHLOJBJNKBI(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void LHOMAHKGMBE(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI PPJMPMKLCME(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FPOBCFILKIK(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void DAFICKCGHED(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void GNOOFHNDDJN(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void HIDPABALGJH(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void GPOEGKEIGOO(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void HDNOGPMNKJG(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI FLNPIJOHBIP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void PKEBLJCHMLM(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void AOMLPLFLJOP(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void OCOGHCJFEBD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void LCEPEPDHFFD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void MCICMJAOIAF(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void EMGPCCNONDM(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI DGHJBIGOGHG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI HILKHEKNGIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void AHEKBKCDAMN(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI MIFFCOMDIEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI IPDFCJLOHLC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IGADCNDDJLO(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void IKIBMLBPEIE(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void KLAKHILLDAD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void EJMJLLKOKMD(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void JDDCGCAHBHM(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void PKDELMHPJHP(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].KNFNJFFCFNO().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void UpdateBentoUI(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void PNPDICKOAGC(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void CHOBNECMDNA(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void BJJGPJGIFCH(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI AHAMJJCGFFA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NBKGADOJDFN(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instances[numInstance] = this;
	}

	public void AMPCEILPDBO(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public static NinjaTrayUI JELOGNCPDAB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void MPMDLFDDHHG(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i += 0)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void GGBMNNPNCDK(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 0)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].PHGLMBIEOMK().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void BCBMGPMPJLH(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG == null || NMPMEHGKHCG.Count > 1);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void MBLPBIDBBJJ(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void IBIOKLOKBHI(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 0; i < ingredientsTray.Length; i += 0)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].AFOACBIHNCL().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GCNJNKMIMAL(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO == null || HPCKGLFLFJO.currentFood.Count > 0);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 0; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public void PNJHDONKCGK(Bento HPCKGLFLFJO)
	{
		bentoUI.gameObject.SetActive(HPCKGLFLFJO != null && HPCKGLFLFJO.currentFood.Count > 1);
		if (HPCKGLFLFJO == null)
		{
			return;
		}
		for (int i = 1; i < ingredientsBento.Length; i++)
		{
			if (i < HPCKGLFLFJO.currentFood.Count)
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(true);
				ingredientsBento[i].sprite = HPCKGLFLFJO.currentFood[i].icon;
			}
			else
			{
				((Component)((Component)ingredientsBento[i]).transform.parent).gameObject.SetActive(false);
			}
		}
	}

	public void OPAPBMCFMMK(List<ItemInstance> NMPMEHGKHCG)
	{
		ticketsUI.gameObject.SetActive(NMPMEHGKHCG != null && NMPMEHGKHCG.Count > 0);
		if (NMPMEHGKHCG == null || NMPMEHGKHCG.Count <= 1)
		{
			return;
		}
		for (int i = 1; i < ingredientsTray.Length; i++)
		{
			if (i < NMPMEHGKHCG.Count)
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(false);
				ingredientsTray[i].sprite = NMPMEHGKHCG[i].LHBPOPOIFLE().icon;
			}
			else
			{
				((Component)((Component)ingredientsTray[i]).transform.parent).gameObject.SetActive(true);
			}
		}
	}

	public static NinjaTrayUI DPIEMFBANNJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static NinjaTrayUI PJIGCLMPHKP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
