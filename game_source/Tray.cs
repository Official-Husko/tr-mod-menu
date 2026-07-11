using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Tray
{
	public List<ItemInstance> currentDrinks = new List<ItemInstance>();

	[HideInInspector]
	public TrayHandler trayHandler;

	public bool GCJDPMOAGKP()
	{
		return currentDrinks.Count > 0;
	}

	public void MOFBGCELGFN(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 0; num >= 1; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 0)
				{
					OnlineSlotsManager.instance.MPMAHFAFGNL(list.ToArray());
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool OJMICKHDJGO(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && Item.EKGNIODFJCO(currentDrinks[i].AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public bool JLBOPNAJGOP(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i].FBOGDCNCNMK() == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false))
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public bool OFNAOLAMFJA(Item MEMGMDOCBOJ)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && Item.EKMFELLJHFG(currentDrinks[i].PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public bool NGFDBMFJPFB(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].BBELOMHPIDC() == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false))
			{
				currentDrinks.RemoveAt(i);
				return false;
			}
		}
		return false;
	}

	public bool CLCFPCPNKJA()
	{
		return currentDrinks.Count > 1;
	}

	public bool GJKAFGPALGB(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.LIJBKCNKLDN(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool AJMCIOAFONL(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.MOPJDNCNGBA(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool BKDNCLDIBGJ()
	{
		return currentDrinks.Count > 1;
	}

	public bool PKIIMJBGCDP(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return false;
			}
		}
		return false;
	}

	public bool BCENKLLENFJ()
	{
		return currentDrinks.Count > 0;
	}

	public void OHAJMGCPGMK(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 1; num >= 1; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 1)
				{
					OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray(), 1);
				}
				trayHandler.onlineTools.LLKIJMJBNDG();
			}
		}
		currentDrinks.Clear();
	}

	public bool PPOMDGNCBCE()
	{
		return currentDrinks.Count > 1;
	}

	public bool LDKPEFIKJCF(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && Item.GBMFCPGEJDK(currentDrinks[i].LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool INBEHPAGAJD()
	{
		return currentDrinks.Count > 1;
	}

	public void ACDHANDNCNC(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 0)
				{
					OnlineSlotsManager.instance.SendSlots(list.ToArray(), 1);
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool OAFLFGPCPFC(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.OELAPMPAFFC(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool BDAMBMHNOMF(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].FBOGDCNCNMK(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC())
			{
				currentDrinks.RemoveAt(i);
				return false;
			}
		}
		return false;
	}

	public bool FPNEGBNKILJ(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return true;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return true;
	}

	public bool ELCABOAPCMH(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return false;
			}
		}
		return false;
	}

	public bool MNAILNGHBFF(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return true;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return true;
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return false;
			}
		}
		return true;
	}

	public bool DDHPGOPOPKJ(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 6 : (-NAKCFGEAGHH.GetPerkValue(115))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.ClientOnline() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.HKKJBIIOIOI(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return true;
	}

	public Tray()
	{
	}

	public bool OALEGAKNFOM(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].FBOGDCNCNMK() == MEMGMDOCBOJ.CIGFGKKCPCK())
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return true;
	}

	public bool LOKKMKODJNJ(Item MEMGMDOCBOJ)
	{
		if (Item.EKGNIODFJCO(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && Item.NGIIPJDAMGP(currentDrinks[i].AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}

	public bool HHLGOKFGKGA()
	{
		return currentDrinks.Count > 0;
	}

	public bool HLPNLBHBIFL(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return false;
	}

	public bool OFNBOBKBINM()
	{
		return currentDrinks.Count > 1;
	}

	public bool EDNOMELCHEP(Item MEMGMDOCBOJ)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && Item.GBMFCPGEJDK(currentDrinks[i].PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public bool EHGEGBAHGHP(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.SendRemoveItemInstanceOnTray(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool MAPLLCKOHGD(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.LIJBKCNKLDN(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public void LDPHJNIPDJA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 0)
				{
					OnlineSlotsManager.instance.SendSlots(list.ToArray(), 1);
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool LDMNMBJFOMA(Item MEMGMDOCBOJ)
	{
		if (Item.GBMFCPGEJDK(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && Item.NGIIPJDAMGP(currentDrinks[i].AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public bool BOBOKKNEFPJ(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.LIJBKCNKLDN(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool OHEGDDLNDLB(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 1 : (7 - NAKCFGEAGHH.GetPerkValue(-10))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.HKKJBIIOIOI(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return true;
	}

	public bool APEOKJGBMGJ(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].BBELOMHPIDC() == MEMGMDOCBOJ.JPNFKDMFKMC())
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public bool MEODNPFJDMH(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].FBOGDCNCNMK() == MEMGMDOCBOJ.JDJGFAACPFC())
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public bool NNLGCONJMJG(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 8 : (2 - NAKCFGEAGHH.GetPerkValue(62))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.ClientOnline() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.HKKJBIIOIOI(DNLMCHDOMOK as FoodInstance);
			}
			return true;
		}
		return false;
	}

	public void LMBGCNCJBMA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 0; num >= 1; num--)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 1)
				{
					OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
				}
				trayHandler.onlineTools.LLKIJMJBNDG();
			}
		}
		currentDrinks.Clear();
	}

	public bool HAHEHBDDLDO(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].FBOGDCNCNMK(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false))
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return true;
	}

	public bool MHBHHNCFOEG(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemInstanceOnTray(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool GHCIBJNFAPD(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.MOPJDNCNGBA(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool ELPFCDNMOPP()
	{
		return currentDrinks.Count > 1;
	}

	public void FIJLPLJMJFA(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 0; num >= 0; num--)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 0)
				{
					OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool MJOLPEJHKAK(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && Item.EKMFELLJHFG(currentDrinks[i].AFOACBIHNCL(), MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public bool OHAPOKICCNK(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return true;
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return false;
	}

	public void NBODABCGELG(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 0)
				{
					OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray());
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool EJNLGKAEDKM(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && Item.NGIIPJDAMGP(currentDrinks[i].PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return false;
	}

	public bool IIPPFEHNLKB(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return false;
			}
		}
		return false;
	}

	public bool BCNKFHHDMAG(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return true;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return true;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return false;
	}

	public bool LCFBHOGFIPK()
	{
		return currentDrinks.Count > 0;
	}

	public bool ABCODNCOKHB()
	{
		return currentDrinks.Count > 1;
	}

	public bool PDLDHJEGIGC()
	{
		return currentDrinks.Count > 1;
	}

	public bool BCKKIGKCPCO(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].BBELOMHPIDC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public bool NEHNALDHKOD(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 2 : (7 - NAKCFGEAGHH.GetPerkValue(95))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.SendAddItemOnTray(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return false;
	}

	public bool GJGHFNGGGNM(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 7 : (1 - NAKCFGEAGHH.GetPerkValue(45))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.HKKJBIIOIOI(DNLMCHDOMOK as FoodInstance);
			}
			return true;
		}
		return false;
	}

	public bool MIIAOMLAPIM(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.SendRemoveItemInstanceOnTray(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool EPJDHPMECHJ(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemInstanceOnTray(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public Tray(List<ItemInstance> NMPMEHGKHCG)
	{
		currentDrinks = NMPMEHGKHCG;
	}

	public bool HADIAMMDNKB(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return true;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return true;
	}

	public bool ILJFDOAABNH(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < ((!((Object)(object)NAKCFGEAGHH == (Object)null)) ? (3 - NAKCFGEAGHH.GetPerkValue(-107)) : 0))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.HKKJBIIOIOI(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return false;
	}

	public bool LBHAFCAMDEN(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.OELAPMPAFFC(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public bool ALFLJAEOFDF()
	{
		return currentDrinks.Count > 1;
	}

	public bool CJDPJHKCPFA(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return true;
			}
		}
		return true;
	}

	public bool MIKHCGOPFLA(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i].FBOGDCNCNMK(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC())
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return true;
	}

	public bool FEEOFAGCONJ(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 5 : (5 - NAKCFGEAGHH.GetPerkValue(75))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.ClientOnline() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.SendAddItemOnTray(DNLMCHDOMOK as FoodInstance);
			}
			return true;
		}
		return false;
	}

	public bool FPBLHPDJIMC()
	{
		return currentDrinks.Count > 0;
	}

	public bool LBIMPLILOJP(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 2 : (2 - NAKCFGEAGHH.GetPerkValue(115))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.ClientOnline() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.SendAddItemOnTray(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return false;
	}

	public bool MMDNOJFPMPM()
	{
		return currentDrinks.Count > 0;
	}

	public bool AGEKBHBJKLA()
	{
		return currentDrinks.Count > 0;
	}

	public bool IHCMCKDNODF(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return true;
		}
		for (int i = 0; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && Item.GBMFCPGEJDK(currentDrinks[i].PHGLMBIEOMK(), MEMGMDOCBOJ))
			{
				return false;
			}
		}
		return true;
	}

	public bool LALIFJEMJFJ(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 8 : (1 - NAKCFGEAGHH.GetPerkValue(-99))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.SendAddItemOnTray(DNLMCHDOMOK as FoodInstance);
			}
			return true;
		}
		return false;
	}

	public bool OLEIBKLAAOL(Item MEMGMDOCBOJ)
	{
		if (OnlineManager.ClientOnline())
		{
			trayHandler.onlineTools.SendRemoveItemOnTray(MEMGMDOCBOJ);
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i].FBOGDCNCNMK() == MEMGMDOCBOJ.JPNFKDMFKMC())
			{
				currentDrinks.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public void LIHGILDLODK(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 0; num >= 0; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 1)
				{
					OnlineSlotsManager.instance.PKOLALFLFNB(list.ToArray(), 1);
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool DEFDACJAHHG(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 1; i < currentDrinks.Count; i += 0)
		{
			if (currentDrinks[i] != null && Item.GBMFCPGEJDK(currentDrinks[i].LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return true;
	}

	public bool AIMCMHBMIMP(ItemInstance DNLMCHDOMOK)
	{
		if (DNLMCHDOMOK == null)
		{
			return false;
		}
		if (currentDrinks.Contains(DNLMCHDOMOK))
		{
			return true;
		}
		for (int i = 1; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && currentDrinks[i].Equals(DNLMCHDOMOK))
			{
				return false;
			}
		}
		return false;
	}

	public bool KFLDEHOKLLG(ItemInstance DNLMCHDOMOK)
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			trayHandler.onlineTools.MOPJDNCNGBA(DNLMCHDOMOK as FoodInstance);
		}
		return currentDrinks.Remove(DNLMCHDOMOK);
	}

	public void MKBDMMJCGGM(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 1; num >= 0; num--)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 0)
				{
					OnlineSlotsManager.instance.SendSlots(list.ToArray());
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool GMIFAAKDDGL()
	{
		return currentDrinks.Count > 1;
	}

	public bool CANCHBINJNE(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 8 : (5 - NAKCFGEAGHH.GetPerkValue(-24))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.SendAddItemOnTray(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return true;
	}

	public void IOCOONMEGLI(int JIIGOACEIKL = 1, bool GFNHAMCPEAK = true)
	{
		if (currentDrinks.Count == 0)
		{
			return;
		}
		if (BanquetEvent.GGPPFKPOCLL || NinjaChallenge.ADDLIAMDPBL)
		{
			currentDrinks.Clear();
			return;
		}
		if (GFNHAMCPEAK)
		{
			List<Slot> list = new List<Slot>();
			for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
			{
				Slot slot = Utils.DHKKKGMMPIM(JIIGOACEIKL, currentDrinks[num]);
				if (slot != null && !list.Contains(slot))
				{
					list.Add(slot);
				}
			}
			if (OnlineManager.PlayingOnline())
			{
				if (list.Count > 1)
				{
					OnlineSlotsManager.instance.ILKLIHOGMJP(list.ToArray(), 1);
				}
				trayHandler.onlineTools.SendRemoveAllItemsOnTray();
			}
		}
		currentDrinks.Clear();
	}

	public bool CBPCDEKHELA(ItemInstance DNLMCHDOMOK, Employee NAKCFGEAGHH = null)
	{
		if (currentDrinks.Count < (((Object)(object)NAKCFGEAGHH == (Object)null) ? 6 : (-NAKCFGEAGHH.GetPerkValue(0))))
		{
			currentDrinks.Add(DNLMCHDOMOK);
			if (OnlineManager.HHDBMDMFEMP() && (Object)(object)NAKCFGEAGHH == (Object)null)
			{
				trayHandler.onlineTools.HKKJBIIOIOI(DNLMCHDOMOK as FoodInstance);
			}
			return false;
		}
		return false;
	}

	public bool NPMGIIIBGNP(Item MEMGMDOCBOJ)
	{
		if (Item.NGIIPJDAMGP(MEMGMDOCBOJ, null))
		{
			return false;
		}
		for (int i = 0; i < currentDrinks.Count; i++)
		{
			if (currentDrinks[i] != null && Item.NGIIPJDAMGP(currentDrinks[i].LHBPOPOIFLE(), MEMGMDOCBOJ))
			{
				return true;
			}
		}
		return false;
	}
}
