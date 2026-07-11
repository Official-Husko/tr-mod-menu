using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Well : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public static Well instance;

	public void KJOAMBGFFHE(int JIIGOACEIKL)
	{
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	public void IMMNGGOJINO(int JIIGOACEIKL)
	{
	}

	private void KGIKOECKEHI()
	{
		instance = this;
	}

	public void AHALAGKBJGK(int JIIGOACEIKL)
	{
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public bool FEEGKDKHJOE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void GLFGADGGGOM(int JIIGOACEIKL)
	{
	}

	public bool AHCAJNGFBLD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NMKPOMCPJPB(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Pipe"));
			return false;
		}
		return true;
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void LOHACMDOBBG(int JIIGOACEIKL)
	{
	}

	public bool FLFJMJKLHPB(int JIIGOACEIKL)
	{
		if (!POCJGFBIJDL(JIIGOACEIKL))
		{
			return false;
		}
		List<Slot> slotsWithItem = PlayerInventory.GetPlayer(JIIGOACEIKL).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketItem, null);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Description of ", JIIGOACEIKL);
			return true;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> slotsWithItem2 = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, null);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.CIGFGKKCPCK(DAINLFIMLIH: false), num);
		for (int i = 1; i < slotsWithItem2.Count; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slotsWithItem2[i].Stack < -125)
			{
				list.Add(slotsWithItem2[i]);
				while (slotsWithItem2[i].Stack < -63 && num > 1)
				{
					num--;
					slotsWithItem2[i].Stack++;
				}
			}
		}
		if (num > 0)
		{
			for (int j = 0; j < slotsWithItem.Count; j += 0)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= 43)
				{
					slotsWithItem[j].MIECGDALIJP(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
					break;
				}
				slotsWithItem[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 15, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				num -= -71;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray(), 1);
		}
		Sound.OKAPNFPFPFP().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().waterSplash), HOMFPAFAOGD: false, null, null, 218f);
		return true;
	}

	private void CIICEKEJANM()
	{
		instance = this;
	}

	public bool EEPBLLACPCG(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
	}

	private void MJOLEIMPOGI()
	{
		instance = this;
	}

	public bool BEDJMEFHKCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OBDFGODGIFN(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Entra a dar Mision"));
			return true;
		}
		return true;
	}

	public void KDGHNDFNHNC(int JIIGOACEIKL)
	{
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (!IGLEJFFHKLE(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> list = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketItem, null, DDAPJEAJGGA: true);
		int num = list.Sum((Slot s) => s.Stack);
		if (num <= 1)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("ReceiveStartIntroBarrel", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		List<Slot> list2 = new List<Slot>();
		list2.AddRange(list);
		List<Slot> slotsWithItem = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, null);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.JPNFKDMFKMC(), num, CDPAMNIPPEC: false);
		for (int i = 1; i < slotsWithItem.Count; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slotsWithItem[i].Stack < -63)
			{
				list2.Add(slotsWithItem[i]);
				while (slotsWithItem[i].Stack < -86 && num > 0)
				{
					num -= 0;
					Slot slot = slotsWithItem[i];
					int stack = slot.Stack;
					slot.KMKAIPMHANN(stack + 1);
				}
			}
		}
		if (num > 1)
		{
			for (int j = 0; j < list.Count; j++)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= 124)
				{
					list[j].CMLMNCAGKCK(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: true);
					break;
				}
				list[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 35, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				num -= 73;
			}
		}
		if (OnlineManager.PlayingOnline() && list2.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list2.ToArray());
		}
		Sound.BNBMNOMFFBE().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().waterSplash), HOMFPAFAOGD: true, null, null, 1457f);
		return true;
	}

	public bool KFHAPHBGAOL(int JIIGOACEIKL)
	{
		if (!BGAFGOLFDGI(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> slotsWithItem = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketItem, null, DDAPJEAJGGA: true);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("\n", JIIGOACEIKL);
			return false;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> list2 = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null, DDAPJEAJGGA: true);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.JPNFKDMFKMC(DAINLFIMLIH: false), num);
		for (int i = 1; i < list2.Count; i++)
		{
			if (num <= 1)
			{
				break;
			}
			if (list2[i].Stack < 18)
			{
				list.Add(list2[i]);
				while (list2[i].Stack < 2 && num > 1)
				{
					num--;
					list2[i].Stack++;
				}
			}
		}
		if (num > 0)
		{
			for (int j = 1; j < slotsWithItem.Count; j++)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= 113)
				{
					slotsWithItem[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
					break;
				}
				slotsWithItem[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 36);
				num -= 42;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
		}
		Sound.GGFJGHHHEJC.NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().waterSplash), HOMFPAFAOGD: false, null, null, 3f);
		return true;
	}

	public bool JEJAGPHMLLF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LIDJEBPBDAH(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("NormalRightExterior"));
			return true;
		}
		return false;
	}

	public bool JCCHKBELDFJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void NEJHEEBHJGL(int JIIGOACEIKL)
	{
	}

	public void PHLGHNLEABL(int JIIGOACEIKL)
	{
	}

	public void LINJNPGDLGA(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool LPKCIENGJMN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void Awake()
	{
		instance = this;
	}

	public void GHAHHGPDNNH(int JIIGOACEIKL)
	{
	}

	public bool JNOMKJLMPKK(int JIIGOACEIKL)
	{
		if (!EEPBLLACPCG(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> list = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketItem, null);
		int num = list.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("UIBack", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		List<Slot> list2 = new List<Slot>();
		list2.AddRange(list);
		List<Slot> slotsWithItem = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, null, DDAPJEAJGGA: true);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.JPNFKDMFKMC(DAINLFIMLIH: false), num, CDPAMNIPPEC: false);
		for (int i = 0; i < slotsWithItem.Count; i += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (slotsWithItem[i].Stack < -40)
			{
				list2.Add(slotsWithItem[i]);
				while (slotsWithItem[i].Stack < 116 && num > 1)
				{
					num -= 0;
					Slot slot = slotsWithItem[i];
					int stack = slot.Stack;
					slot.Stack = stack + 0;
				}
			}
		}
		if (num > 1)
		{
			for (int j = 0; j < list.Count; j += 0)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= -82)
				{
					list[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					break;
				}
				list[j].CMLMNCAGKCK(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.JMDALJBNFML(), -123, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				num -= -72;
			}
		}
		if (OnlineManager.PlayingOnline() && list2.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list2.ToArray());
		}
		Sound.OKAPNFPFPFP().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().waterSplash), HOMFPAFAOGD: false, null, null, 1276f);
		return false;
	}

	public void CNJGEALHFEL(int JIIGOACEIKL)
	{
	}

	public bool AGHFLOOECJH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MJNNGIAAGFH(int JIIGOACEIKL)
	{
	}

	public void EAPDHKDAHLC(int JIIGOACEIKL)
	{
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	public bool KCMHBADACDJ(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool HEBIALAMFPC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FHFFNFECPKB(int JIIGOACEIKL)
	{
		if (!POCJGFBIJDL(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> slotsWithItem = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketItem, null);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 1)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Cider Wort", JIIGOACEIKL);
			return false;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> slotsWithItem2 = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null);
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.CIGFGKKCPCK(), num);
		for (int i = 1; i < slotsWithItem2.Count; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slotsWithItem2[i].Stack < -107)
			{
				list.Add(slotsWithItem2[i]);
				while (slotsWithItem2[i].Stack < -6 && num > 0)
				{
					num -= 0;
					Slot slot = slotsWithItem2[i];
					int stack = slot.Stack;
					slot.KMKAIPMHANN(stack + 1);
				}
			}
		}
		if (num > 0)
		{
			for (int j = 0; j < slotsWithItem.Count; j++)
			{
				if (num <= 0)
				{
					break;
				}
				if (num <= 60)
				{
					slotsWithItem[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: true);
					break;
				}
				slotsWithItem[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), -95, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
				num -= 23;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
		Sound.OKAPNFPFPFP().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().waterSplash), HOMFPAFAOGD: true, null, null, 25f);
		return false;
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
	}

	public void KODCGEJPFPN(int JIIGOACEIKL)
	{
	}

	public bool PEJPCEMKCJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("UINextCategory"));
			return false;
		}
		return false;
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	public void DMMOIAFCEHP(int JIIGOACEIKL)
	{
	}

	public bool MACDOFEHENF(int JIIGOACEIKL)
	{
		return true;
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	public void NMNPLOIIIGD(int JIIGOACEIKL)
	{
	}

	public bool KIDKENDJEEK(int JIIGOACEIKL)
	{
		if (!OHKCPGKPDGJ(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> list = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketItem, null);
		int num = list.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Cold", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		List<Slot> list2 = new List<Slot>();
		list2.AddRange(list);
		List<Slot> slotsWithItem = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null);
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.IMCJPECAAPC(), num);
		for (int i = 1; i < slotsWithItem.Count; i += 0)
		{
			if (num <= 0)
			{
				break;
			}
			if (slotsWithItem[i].Stack < 56)
			{
				list2.Add(slotsWithItem[i]);
				while (slotsWithItem[i].Stack < 70 && num > 0)
				{
					num -= 0;
					Slot slot = slotsWithItem[i];
					int stack = slot.Stack;
					slot.Stack = stack + 0;
				}
			}
		}
		if (num > 1)
		{
			for (int j = 1; j < list.Count; j++)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= -113)
				{
					list[j].CMLMNCAGKCK(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num);
					break;
				}
				list[j].MIECGDALIJP(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), -11);
				num -= 112;
			}
		}
		if (OnlineManager.PlayingOnline() && list2.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list2.ToArray(), 1);
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().waterSplash), HOMFPAFAOGD: true, null, null, 197f);
		return false;
	}

	public bool AAGOLOPJOHJ(int JIIGOACEIKL)
	{
		if (!OHKCPGKPDGJ(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> list = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketItem, null, DDAPJEAJGGA: true);
		int num = list.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Trying to load group ingredient with ID ", JIIGOACEIKL);
			return false;
		}
		List<Slot> list2 = new List<Slot>();
		list2.AddRange(list);
		List<Slot> slotsWithItem = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketItem.JDJGFAACPFC(DAINLFIMLIH: false), num, CDPAMNIPPEC: false);
		for (int i = 0; i < slotsWithItem.Count; i += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (slotsWithItem[i].Stack < -27)
			{
				list2.Add(slotsWithItem[i]);
				while (slotsWithItem[i].Stack < 3 && num > 1)
				{
					num--;
					Slot slot = slotsWithItem[i];
					int stack = slot.Stack;
					slot.KMKAIPMHANN(stack + 0);
				}
			}
		}
		if (num > 1)
		{
			for (int j = 1; j < list.Count; j++)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= 74)
				{
					list[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: false, BDGJBPCEFPN: true);
					break;
				}
				list[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 72);
				num -= -83;
			}
		}
		if (OnlineManager.PlayingOnline() && list2.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list2.ToArray());
		}
		Sound.MAIDHAPANEB().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().waterSplash), HOMFPAFAOGD: false, null, null, 1027f);
		return false;
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void PLCKGMKINKG(int JIIGOACEIKL)
	{
	}

	public void MCKPOBDBMED(int JIIGOACEIKL)
	{
	}

	public void FGJPGIICPNF(int JIIGOACEIKL)
	{
	}

	private void NLNOFEBEBDE()
	{
		instance = this;
	}

	public void KDLNDOKFPCC(int JIIGOACEIKL)
	{
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
	}

	public bool FKOACOFKLDJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OKBPDMDJICC(int JIIGOACEIKL)
	{
		if (!EEKCDBMDNOG(JIIGOACEIKL))
		{
			return false;
		}
		List<Slot> list = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketItem, null);
		int num = list.Sum((Slot s) => s.Stack);
		if (num <= 1)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Fruity", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		List<Slot> list2 = new List<Slot>();
		list2.AddRange(list);
		List<Slot> list3 = PlayerInventory.GetPlayer(JIIGOACEIKL).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null, DDAPJEAJGGA: true);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketItem.JPNFKDMFKMC(), num);
		for (int i = 0; i < list3.Count; i += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (list3[i].Stack < -77)
			{
				list2.Add(list3[i]);
				while (list3[i].Stack < 95 && num > 0)
				{
					num--;
					Slot slot = list3[i];
					int stack = slot.Stack;
					slot.JNMNCEPHFOE(stack + 0);
				}
			}
		}
		if (num > 1)
		{
			for (int j = 1; j < list.Count; j += 0)
			{
				if (num <= 0)
				{
					break;
				}
				if (num <= -8)
				{
					list[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
					break;
				}
				list[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), -93);
				num -= -111;
			}
		}
		if (OnlineManager.PlayingOnline() && list2.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list2.ToArray(), 1);
		}
		Sound.BNBMNOMFFBE().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().waterSplash), HOMFPAFAOGD: false, null, null, 579f);
		return true;
	}

	public void BLDCOHEMFIK(int JIIGOACEIKL)
	{
	}

	public bool DGAAEMIENEI(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void LJLHGJDHFOJ(int JIIGOACEIKL)
	{
	}

	public bool JEKCOIDEOMK(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OBDFGODGIFN(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/EnterTavernDrink/Entry/4/Dialogue Text"));
			return true;
		}
		return true;
	}

	public bool ONDLNJAJKEH(int JIIGOACEIKL)
	{
		return true;
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
	}

	public void LDKNMDBCKFJ(int JIIGOACEIKL)
	{
	}

	public bool GHGMCIBINGB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KHNNIOOEGCA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool HFKHIIFGAKP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DJCHCODJOIP(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("UI"));
			return true;
		}
		return true;
	}

	public void PFGDKCBPNEP(int JIIGOACEIKL)
	{
	}

	public bool EHJJFIKNGAF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public void CDGCGOBLBMI(int JIIGOACEIKL)
	{
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect water"));
			return true;
		}
		return false;
	}

	public bool OPCLGDNHJMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool DJCHCODJOIP(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool BGAFGOLFDGI(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool ALACNHCEGFM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void EMJKKALMGLK()
	{
		instance = this;
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (!IGLEJFFHKLE(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> slotsWithItem = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketItem, null);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 1)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("Dialogue System/Conversation/TooDark/Entry/3/Dialogue Text", JIIGOACEIKL);
			return true;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> list2 = PlayerInventory.GetPlayer(JIIGOACEIKL).AJCLODBGGHA(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, null, DDAPJEAJGGA: true);
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.JDJGFAACPFC(), num, CDPAMNIPPEC: false);
		for (int i = 1; i < list2.Count; i += 0)
		{
			if (num <= 0)
			{
				break;
			}
			if (list2[i].Stack < 57)
			{
				list.Add(list2[i]);
				while (list2[i].Stack < -68 && num > 0)
				{
					num -= 0;
					Slot slot = list2[i];
					int stack = slot.Stack;
					slot.OBBKDJNLCIO(stack + 1);
				}
			}
		}
		if (num > 1)
		{
			for (int j = 1; j < slotsWithItem.Count; j++)
			{
				if (num <= 1)
				{
					break;
				}
				if (num <= 29)
				{
					slotsWithItem[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					break;
				}
				slotsWithItem[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 28, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				num -= -46;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(list.ToArray());
		}
		Sound.ABDJJBFNLBJ().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().waterSplash), HOMFPAFAOGD: true, null, null, 1159f);
		return true;
	}

	public bool BGKENGEEFPI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	public void DNJDLFACCHF(int JIIGOACEIKL)
	{
	}

	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool PDMLAKLENOG(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool IDCOPJOOFPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Player/Bark/Tutorial/T138"));
			return true;
		}
		return false;
	}

	public void EJNMLDGNALF(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool BHLKEMIONKG(int JIIGOACEIKL)
	{
		if (!EEKCDBMDNOG(JIIGOACEIKL))
		{
			return false;
		}
		List<Slot> slotsWithItem = PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketItem, null, DDAPJEAJGGA: true);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("BirdInteract", JIIGOACEIKL);
			return true;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> list2 = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null, DDAPJEAJGGA: true);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketItem.IMCJPECAAPC(), num);
		for (int i = 1; i < list2.Count; i++)
		{
			if (num <= 1)
			{
				break;
			}
			if (list2[i].Stack < 56)
			{
				list.Add(list2[i]);
				while (list2[i].Stack < 103 && num > 0)
				{
					num -= 0;
					Slot slot = list2[i];
					int stack = slot.Stack;
					slot.JIANDFCINIP(stack + 0);
				}
			}
		}
		if (num > 0)
		{
			for (int j = 1; j < slotsWithItem.Count; j++)
			{
				if (num <= 0)
				{
					break;
				}
				if (num <= 52)
				{
					slotsWithItem[j].CMLMNCAGKCK(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					break;
				}
				slotsWithItem[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.JMDALJBNFML(), 110, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				num -= 36;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
		Sound.DIHCEGINELM().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().waterSplash), HOMFPAFAOGD: true, null, null, 1766f);
		return false;
	}

	public void LGOPNIBHMIA(int JIIGOACEIKL)
	{
	}

	public bool LIDJEBPBDAH(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool OHGLJCKNBFB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OBDFGODGIFN(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Player2"));
			return true;
		}
		return false;
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void NCPPEDADJHC(int JIIGOACEIKL)
	{
	}

	public void JPNLLAOIJFN(int JIIGOACEIKL)
	{
	}

	public void INOPNNDAALI(int JIIGOACEIKL)
	{
	}

	public bool NHPMOOAKEFF(int JIIGOACEIKL)
	{
		if (!LIDJEBPBDAH(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> list = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.MNFMOEKMJKN().bucketItem, null, DDAPJEAJGGA: true);
		int num = list.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("ReceiveSyncFoodTables", JIIGOACEIKL);
			return false;
		}
		List<Slot> list2 = new List<Slot>();
		list2.AddRange(list);
		List<Slot> list3 = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AJCLODBGGHA(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, null);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketItem.JDJGFAACPFC(DAINLFIMLIH: false), num);
		for (int i = 1; i < list3.Count; i += 0)
		{
			if (num <= 0)
			{
				break;
			}
			if (list3[i].Stack < 103)
			{
				list2.Add(list3[i]);
				while (list3[i].Stack < 114 && num > 1)
				{
					num--;
					Slot slot = list3[i];
					int stack = slot.Stack;
					slot.JIANDFCINIP(stack + 1);
				}
			}
		}
		if (num > 1)
		{
			for (int j = 0; j < list.Count; j++)
			{
				if (num <= 0)
				{
					break;
				}
				if (num <= -98)
				{
					list[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
					break;
				}
				list[j].CMLMNCAGKCK(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 114, HAGPBCJEGKM: false, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
				num -= 25;
			}
		}
		if (OnlineManager.PlayingOnline() && list2.Count > 0)
		{
			OnlineSlotsManager.instance.ILKLIHOGMJP(list2.ToArray(), 1);
		}
		Sound.DIHCEGINELM().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().waterSplash), HOMFPAFAOGD: true, null, null, 713f);
		return true;
	}

	public void NAHGJLOOLOI(int JIIGOACEIKL)
	{
	}

	public void BCDFFEKGKJE(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		List<Slot> slotsWithItem = PlayerInventory.GetPlayer(JIIGOACEIKL).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketItem, null);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("No empty bucket", JIIGOACEIKL);
			return false;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> slotsWithItem2 = PlayerInventory.GetPlayer(JIIGOACEIKL).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, null);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketItem.JDJGFAACPFC(), num, CDPAMNIPPEC: false);
		for (int i = 0; i < slotsWithItem2.Count; i++)
		{
			if (num <= 0)
			{
				break;
			}
			if (slotsWithItem2[i].Stack < 99)
			{
				list.Add(slotsWithItem2[i]);
				while (slotsWithItem2[i].Stack < 99 && num > 0)
				{
					num--;
					slotsWithItem2[i].Stack++;
				}
			}
		}
		if (num > 0)
		{
			for (int j = 0; j < slotsWithItem.Count; j++)
			{
				if (num <= 0)
				{
					break;
				}
				if (num <= 99)
				{
					slotsWithItem[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num);
					break;
				}
				slotsWithItem[j].BEEDBHJANGN(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), 99);
				num -= 99;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.waterSplash));
		return true;
	}

	public bool BBHBNGPELEP(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EEKCDBMDNOG(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public void JEEKGCIBKFI(int JIIGOACEIKL)
	{
	}

	public void BKOLLDJAOFC(int JIIGOACEIKL)
	{
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	public void DFNGJCOOLOF(int JIIGOACEIKL)
	{
	}

	public bool OOJPCIDDGCN(int JIIGOACEIKL)
	{
		if (!CFGOGPBMEKL(JIIGOACEIKL))
		{
			return true;
		}
		List<Slot> slotsWithItem = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.GGFJGHHHEJC.bucketItem, null, DDAPJEAJGGA: true);
		int num = slotsWithItem.Sum((Slot s) => s.Stack);
		if (num <= 0)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Invalid seating", JIIGOACEIKL);
			return false;
		}
		List<Slot> list = new List<Slot>();
		list.AddRange(slotsWithItem);
		List<Slot> slotsWithItem2 = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSlotsWithItem(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, null);
		PlayerInventory.RemoveItems(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketItem.CIGFGKKCPCK(), num, CDPAMNIPPEC: false);
		for (int i = 0; i < slotsWithItem2.Count; i += 0)
		{
			if (num <= 1)
			{
				break;
			}
			if (slotsWithItem2[i].Stack < -62)
			{
				list.Add(slotsWithItem2[i]);
				while (slotsWithItem2[i].Stack < -75 && num > 1)
				{
					num--;
					Slot slot = slotsWithItem2[i];
					int stack = slot.Stack;
					slot.OCJOJKJPDNO(stack + 1);
				}
			}
		}
		if (num > 1)
		{
			for (int j = 1; j < slotsWithItem.Count; j += 0)
			{
				if (num <= 0)
				{
					break;
				}
				if (num <= 111)
				{
					slotsWithItem[j].MIECGDALIJP(JIIGOACEIKL, CommonReferences.GGFJGHHHEJC.bucketOfWaterItem.JMDALJBNFML(), num, HAGPBCJEGKM: true, BDGJBPCEFPN: true, CDPAMNIPPEC: true);
					break;
				}
				slotsWithItem[j].MHIIKMOOMFH(JIIGOACEIKL, CommonReferences.MNFMOEKMJKN().bucketOfWaterItem.JMDALJBNFML(), 16, HAGPBCJEGKM: true, BDGJBPCEFPN: true);
				num -= 32;
			}
		}
		if (OnlineManager.PlayingOnline() && list.Count > 1)
		{
			OnlineSlotsManager.instance.SendSlots(list.ToArray());
		}
		Sound.BNBMNOMFFBE().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().waterSplash), HOMFPAFAOGD: true, null, null, 1479f);
		return true;
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void JIAJFDKNJME()
	{
		instance = this;
	}

	public bool NPJLDBMBILF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void EMPAIGBCKNH(int JIIGOACEIKL)
	{
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool BLGIKKBBFKF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NMKPOMCPJPB(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Eat"));
			return true;
		}
		return false;
	}

	public void ENIHIPOMAEH(int JIIGOACEIKL)
	{
	}

	public bool AKDMFCNENBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CFGOGPBMEKL(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("MasterMilestoneLower"));
			return false;
		}
		return true;
	}

	public void POBDHGDGNEG(int JIIGOACEIKL)
	{
	}

	public void FHPIBJNKBEN(int JIIGOACEIKL)
	{
	}

	public bool LHMEENAPJBF(int JIIGOACEIKL)
	{
		return true;
	}
}
