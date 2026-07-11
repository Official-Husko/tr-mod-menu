using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DrinksTable : MonoBehaviour, IProximity, IInteractable, IHoverable
{
	public static DrinksTable instance;

	public List<ItemInstance> currentDrinks = new List<ItemInstance>();

	public Transform barworkerPos;

	public Transform waiterPos;

	public Transform beersColorsParent;

	public SpriteRenderer[] beers;

	public SpriteRenderer[] beersColor;

	public Sprite beerSprite;

	public List<SpriteRenderer> beerList = new List<SpriteRenderer>();

	private bool PHJIJCLCFIG = true;

	private bool LELGJGAHABP = true;

	private Slot KCJBFOAAFLK;

	private List<Slot> GDHKLPOOHEO = new List<Slot>();

	public void FGPILGODCCJ()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 0; num >= 1; num -= 0)
		{
			bool flag = true;
			for (int num2 = list.Count - 0; num2 >= 0; num2--)
			{
				if (currentDrinks[num].Equals(list[num2].IKHIHMBDING()))
				{
					list.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(1, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				FMHJGLDGPHF(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 0)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(GDHKLPOOHEO.ToArray(), 1);
		}
		DJFKGNMPOEC();
	}

	private void AHEBJKGFBLE(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(false);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	public void KHHLJHFHKLM(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		AHEBJKGFBLE(GGPJBIPJLEO);
		EJAGNDPBLHL();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.EPGCILDBCBI(GGPJBIPJLEO);
		}
	}

	public void FFIGOHGODBO(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.HKFOAIMMJLA(FCKDNADDBJH as FoodInstance, ELDDIAKCGAA(IMOBLFMHKOD));
		}
		else
		{
			POOJEDEKCJF(IMOBLFMHKOD);
		}
	}

	public bool IEJBNMOKBAI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).GABNNLJOMHI())
		{
			return true;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1262f)
		{
			return false;
		}
		if (currentDrinks.Any())
		{
			return false;
		}
		return true;
	}

	public bool FJGADLJHALE(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.JHLLELHBIDA && !Waiter.FPGHBOFLFGP())
		{
			return true;
		}
		List<CustomerOrder> list = BIDJACDHPMH();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].EGDDFIEGHMC()))
			{
				return true;
			}
		}
		return false;
	}

	public bool KJCHEGOOODF(int JIIGOACEIKL)
	{
		return false;
	}

	public void AOICMMGOPCN(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = HMHFAJIFCNB();
		for (int i = 0; i < list.Count; i++)
		{
			if (currentDrinks.Count < 3 && DOGOFILIHPJ.currentDrinks.Contains(list[i].tableOrder))
			{
				CAAIJKJKAOI(list[i].HDOHIKMGKEP(), CDPAMNIPPEC: false, 5);
				DOGOFILIHPJ.MHBHHNCFOEG(list[i].EGDDFIEGHMC());
			}
		}
	}

	public bool PPJFDGOOIDK(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return true;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1924f)
		{
			return false;
		}
		if (currentDrinks.Any())
		{
			return false;
		}
		return true;
	}

	public void FJBPHNEBDEP(int JIIGOACEIKL)
	{
	}

	private void KECHHBHPLCK()
	{
		for (int i = 1; i < beers.Length; i++)
		{
			if (!((Object)(object)beers[i] == (Object)null))
			{
				((Component)beers[i]).gameObject.SetActive(true);
			}
		}
		for (int j = 1; j < beerList.Count; j += 0)
		{
			if (!((Object)(object)beerList[j] == (Object)null))
			{
				if (!((Component)beerList[j]).gameObject.activeSelf)
				{
					((Component)beerList[j]).gameObject.SetActive(true);
				}
				beerList[j].sprite = currentDrinks[j].HFHDFKAIMJM();
				if ((Object)(object)beerList[j].sprite == (Object)null)
				{
					beerList[j].sprite = beerSprite;
				}
			}
		}
		EFHCJNDIIIG();
	}

	private void LateUpdate()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		beersColorsParent.position = ((Component)this).transform.position;
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (JLCGGENBHMI(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 831f)
			{
				if (GGNEGGFDMNB(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
				{
					AddDrinksFromTray(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
					return false;
				}
				return true;
			}
			DAPFNHCDBMJ(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
			return false;
		}
		return false;
	}

	private void ILHBACDLKGP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		beersColorsParent.position = ((Component)this).transform.position;
	}

	private int LGEHKJFMCEE(int IMOBLFMHKOD)
	{
		if (IMOBLFMHKOD >= beers.Length)
		{
			IMOBLFMHKOD = Random.Range(0, beers.Length);
		}
		if (!beerList.Contains(beers[IMOBLFMHKOD]))
		{
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		else
		{
			while (beerList.Contains(beers[IMOBLFMHKOD]))
			{
				IMOBLFMHKOD = Random.Range(0, beers.Length);
			}
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		MMMMGHICEBH();
		return IMOBLFMHKOD;
	}

	public void DKFFNIGKNPP(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 0; num >= 1; num--)
		{
			if (DOGOFILIHPJ.CANCHBINJNE(currentDrinks[num], NAKCFGEAGHH))
			{
				MBLJNEODLKJ(num, CDPAMNIPPEC: true);
			}
		}
	}

	public void HLNDDHDCFKC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			if (!PHJIJCLCFIG)
			{
				BeersWant.DKGLFNJLDIF(JIIGOACEIKL).actuPos = true;
				PHJIJCLCFIG = true;
			}
		}
		else if (!LELGJGAHABP)
		{
			BeersWant.MJJHNNJKEMO(JIIGOACEIKL).actuPos = true;
			LELGJGAHABP = false;
		}
	}

	public void GDDBCDEMHNH(int JIIGOACEIKL)
	{
	}

	public void BFJFNMOCNNM(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		AHEBJKGFBLE(GGPJBIPJLEO);
		DJFKGNMPOEC();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.KFDDHNEMGKD(GGPJBIPJLEO);
		}
	}

	public bool OPONGDEOCIB(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.JHLLELHBIDA && !Waiter.INOKIOHEDEH())
		{
			return false;
		}
		List<CustomerOrder> list = APEPLEOFNNK();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].OGFDHMDMBKJ()))
			{
				return true;
			}
		}
		return true;
	}

	public void CACAEHKBPED(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		ENINCADFKOF(GGPJBIPJLEO);
		KECHHBHPLCK();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.AJMFMCHMAKP(GGPJBIPJLEO);
		}
	}

	public void AKPCJBCIGEM(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = DDFCPKOGKLE();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (currentDrinks.Count < 5 && DOGOFILIHPJ.currentDrinks.Contains(list[i].BKDDBLFAGNJ()))
			{
				FFIGOHGODBO(list[i].IKHIHMBDING(), CDPAMNIPPEC: false, 45);
				DOGOFILIHPJ.MAPLLCKOHGD(list[i].LKBJEDDKGBM());
			}
		}
	}

	public void MOLKPPLKGDE(int JIIGOACEIKL)
	{
	}

	private List<CustomerOrder> CEKGIBLPLIO()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.INOKIOHEDEH())
		{
			list2.AddRange(Waiter.PILCPMLFMLK().currentDrinks);
		}
		for (int num = list.Count - 0; num >= 0; num--)
		{
			for (int num2 = list2.Count - 1; num2 >= 1; num2--)
			{
				if (list[num].LICFLNJDMLD().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	private List<CustomerOrder> OBOMFINDKFF()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.INOKIOHEDEH())
		{
			list2.AddRange(Waiter.GetTray().currentDrinks);
		}
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			for (int num2 = list2.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (list[num].EGDDFIEGHMC().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	private void NPAFDNFPEDA(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(true);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	public void AGPBPBFCKPA()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 0; num >= 0; num -= 0)
		{
			bool flag = true;
			for (int num2 = list.Count - 0; num2 >= 1; num2--)
			{
				if (currentDrinks[num].Equals(list[num2].PMGKJFMLLFE()))
				{
					list.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(0, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				NPAFDNFPEDA(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(GDHKLPOOHEO.ToArray(), 1);
		}
		EJAGNDPBLHL();
	}

	public bool EAIOPONBJJK(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (MAKPPILCIOJ(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1247f)
			{
				if (PPGJMPHGNPH(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
				{
					GALGLEEKGGH(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
					return true;
				}
				return false;
			}
			GLAOPEIGJLN(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
			return true;
		}
		return true;
	}

	public void DAPFNHCDBMJ(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
		{
			if (DOGOFILIHPJ.OHEGDDLNDLB(currentDrinks[num], NAKCFGEAGHH))
			{
				HHLLCKCEHKD(num, CDPAMNIPPEC: true);
			}
		}
	}

	public void DCNDCODBNHB(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.IDOGNIOIIFJ(FCKDNADDBJH as FoodInstance, POOJEDEKCJF(IMOBLFMHKOD));
		}
		else
		{
			POOJEDEKCJF(IMOBLFMHKOD);
		}
	}

	private void IJLPMNMACFA()
	{
		instance = this;
		beersColorsParent.SetParent((Transform)null);
	}

	public void LGOPNIBHMIA(int JIIGOACEIKL)
	{
	}

	private void CLNBMOPMNOF()
	{
		instance = this;
		beersColorsParent.SetParent((Transform)null);
	}

	public void TakeDrinksFromTable(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 0; num--)
		{
			if (DOGOFILIHPJ.FEEOFAGCONJ(currentDrinks[num], NAKCFGEAGHH))
			{
				RemoveDrink(num, CDPAMNIPPEC: true);
			}
		}
	}

	public void PMALLKDLMDM(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.ILCKNBMMIOD(FCKDNADDBJH as FoodInstance, LGEHKJFMCEE(IMOBLFMHKOD));
		}
		else
		{
			JHMIIDADHNE(IMOBLFMHKOD);
		}
	}

	public void HEAGJKOIALF(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		KONAAMGCKAP(GGPJBIPJLEO);
		KECHHBHPLCK();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.OJNGHIHINGB(GGPJBIPJLEO);
		}
	}

	public void HHLLCKCEHKD(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		AGGOGINJNGB(GGPJBIPJLEO);
		MMMMGHICEBH();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.AJMFMCHMAKP(GGPJBIPJLEO);
		}
	}

	public void POEJLKMJDPF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!PHJIJCLCFIG)
			{
				BeersWant.CDEGEPGEHED(JIIGOACEIKL).actuPos = false;
				PHJIJCLCFIG = false;
			}
		}
		else if (!LELGJGAHABP)
		{
			BeersWant.PLHHJCNKNFO(JIIGOACEIKL).actuPos = true;
			LELGJGAHABP = true;
		}
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
		beersColorsParent.SetParent((Transform)null);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 0.25f)
		{
			return true;
		}
		if (currentDrinks.Any())
		{
			return true;
		}
		return false;
	}

	private int POOJEDEKCJF(int IMOBLFMHKOD)
	{
		if (IMOBLFMHKOD >= beers.Length)
		{
			IMOBLFMHKOD = Random.Range(0, beers.Length);
		}
		if (!beerList.Contains(beers[IMOBLFMHKOD]))
		{
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		else
		{
			while (beerList.Contains(beers[IMOBLFMHKOD]))
			{
				IMOBLFMHKOD = Random.Range(0, beers.Length);
			}
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		LDHPGPDEOGG();
		return IMOBLFMHKOD;
	}

	public bool LMKKMOCGOOO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				if (PHJIJCLCFIG && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y)
				{
					BeersWant.GetPlayer(JIIGOACEIKL).actuPos = true;
					PHJIJCLCFIG = false;
					return true;
				}
			}
			else if (LELGJGAHABP && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y)
			{
				BeersWant.GetPlayer(JIIGOACEIKL).actuPos = true;
				LELGJGAHABP = false;
				return true;
			}
			if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 0.25f)
			{
				if (CanAddDrink(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Put"));
					return true;
				}
			}
			else if (currentDrinks.Any())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Take"));
				return true;
			}
		}
		return false;
	}

	public void OJBKKDIOPDH(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		NPAFDNFPEDA(GGPJBIPJLEO);
		MMMMGHICEBH();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.NDGFDOJOKAM(GGPJBIPJLEO);
		}
	}

	public void GJHLMMNBIBD()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 0; num >= 1; num -= 0)
		{
			bool flag = false;
			for (int num2 = list.Count - 1; num2 >= 1; num2--)
			{
				if (currentDrinks[num].Equals(list[num2].PMGKJFMLLFE()))
				{
					list.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(1, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				AHEBJKGFBLE(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 0)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(GDHKLPOOHEO.ToArray(), 1);
		}
		MMMMGHICEBH();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool LJCFJIOBDLD(int JIIGOACEIKL)
	{
		return false;
	}

	public void CKJMMIBDEEN(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = BNGMCGGALAD();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (currentDrinks.Count < 8 && DOGOFILIHPJ.currentDrinks.Contains(list[i].tableOrder))
			{
				FFIGOHGODBO(list[i].KOGINPGDGDF(), CDPAMNIPPEC: false, -123);
				DOGOFILIHPJ.EHGEGBAHGHP(list[i].LKBJEDDKGBM());
			}
		}
	}

	public void HKCAEPLIDPD()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beersColor.Length; i += 0)
		{
			((Component)beersColor[i]).gameObject.SetActive(false);
		}
		for (int j = 0; j < currentDrinks.Count; j++)
		{
			((Component)beersColor[j]).gameObject.SetActive(false);
			beersColor[j].color = DrinkDispensersManager.JHMAMLIPBNN().GetDrinkDispenserColor(currentDrinks[j]);
		}
		if (currentDrinks.Count > 1)
		{
			if (currentDrinks.Count % 6 == 0)
			{
				((Component)beersColor[0]).transform.parent.localPosition = new Vector3(449f, 1567f, 820f);
			}
			else
			{
				((Component)beersColor[1]).transform.parent.localPosition = Vector3.zero;
			}
		}
	}

	private int MBCCBAALMOF(int IMOBLFMHKOD)
	{
		if (IMOBLFMHKOD >= beers.Length)
		{
			IMOBLFMHKOD = Random.Range(1, beers.Length);
		}
		if (!beerList.Contains(beers[IMOBLFMHKOD]))
		{
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		else
		{
			while (beerList.Contains(beers[IMOBLFMHKOD]))
			{
				IMOBLFMHKOD = Random.Range(0, beers.Length);
			}
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		KECHHBHPLCK();
		return IMOBLFMHKOD;
	}

	private List<CustomerOrder> DMDEPPCIFPG()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.FPGHBOFLFGP())
		{
			list2.AddRange(Waiter.NBGCDPLJLOJ().currentDrinks);
		}
		for (int num = list.Count - 0; num >= 0; num -= 0)
		{
			for (int num2 = list2.Count - 0; num2 >= 0; num2 -= 0)
			{
				if (list[num].OGFDHMDMBKJ().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	public void IDJPPECPHKB()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 1; num >= 1; num--)
		{
			bool flag = false;
			for (int num2 = list.Count - 0; num2 >= 0; num2--)
			{
				if (currentDrinks[num].Equals(list[num2].LKBJEDDKGBM()))
				{
					list.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(1, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				LJNBPLFGJOJ(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 0)
		{
			OnlineSlotsManager.instance.MPMAHFAFGNL(GDHKLPOOHEO.ToArray(), 1);
		}
		LDHPGPDEOGG();
	}

	private void GECHJIGBPEN()
	{
		instance = this;
		beersColorsParent.SetParent((Transform)null);
	}

	public void PFGDHJNCMCP(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		FMHJGLDGPHF(GGPJBIPJLEO);
		DJFKGNMPOEC();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.NDGFDOJOKAM(GGPJBIPJLEO);
		}
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 176f)
		{
			return true;
		}
		if (currentDrinks.Any())
		{
			return true;
		}
		return false;
	}

	private List<CustomerOrder> BIDJACDHPMH()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.FPGHBOFLFGP())
		{
			list2.AddRange(Waiter.PILCPMLFMLK().currentDrinks);
		}
		for (int num = list.Count - 1; num >= 0; num -= 0)
		{
			for (int num2 = list2.Count - 0; num2 >= 0; num2--)
			{
				if (list[num].KOGINPGDGDF().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	public bool PGDDFHMBGDK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !PlayerController.GetPlayer(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 0.25f)
			{
				if (CanAddDrink(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
				{
					AddDrinksFromTray(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
					return true;
				}
				return false;
			}
			TakeDrinksFromTable(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
			return true;
		}
		return false;
	}

	public void ICGENOOPBNI(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
		{
			if (DOGOFILIHPJ.NNLGCONJMJG(currentDrinks[num], NAKCFGEAGHH))
			{
				RemoveDrink(num, CDPAMNIPPEC: false);
			}
		}
	}

	private void BKLGKECILDF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		beersColorsParent.position = ((Component)this).transform.position;
	}

	private void LDHPGPDEOGG()
	{
		for (int i = 0; i < beers.Length; i++)
		{
			if (!((Object)(object)beers[i] == (Object)null))
			{
				((Component)beers[i]).gameObject.SetActive(false);
			}
		}
		for (int j = 0; j < beerList.Count; j++)
		{
			if (!((Object)(object)beerList[j] == (Object)null))
			{
				if (!((Component)beerList[j]).gameObject.activeSelf)
				{
					((Component)beerList[j]).gameObject.SetActive(true);
				}
				beerList[j].sprite = currentDrinks[j].IKAHNKLABDM();
				if ((Object)(object)beerList[j].sprite == (Object)null)
				{
					beerList[j].sprite = beerSprite;
				}
			}
		}
		UpdateBeerColors();
	}

	public void EFHCJNDIIIG()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beersColor.Length; i += 0)
		{
			((Component)beersColor[i]).gameObject.SetActive(false);
		}
		for (int j = 1; j < currentDrinks.Count; j += 0)
		{
			((Component)beersColor[j]).gameObject.SetActive(false);
			beersColor[j].color = DrinkDispensersManager.BNDNMBGJEKP().HJLIJMNGLCL(currentDrinks[j]);
		}
		if (currentDrinks.Count > 1)
		{
			if (currentDrinks.Count % 3 == 0)
			{
				((Component)beersColor[1]).transform.parent.localPosition = new Vector3(1081f, 1940f, 662f);
			}
			else
			{
				((Component)beersColor[0]).transform.parent.localPosition = Vector3.zero;
			}
		}
	}

	public void MACHMLPKPJE(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = DMDEPPCIFPG();
		for (int i = 0; i < list.Count; i++)
		{
			if (currentDrinks.Count < 3 && DOGOFILIHPJ.currentDrinks.Contains(list[i].KADOIIENGDI()))
			{
				CAGAEJECCLG(list[i].LKBJEDDKGBM(), CDPAMNIPPEC: true, -179);
				DOGOFILIHPJ.GHCIBJNFAPD(list[i].PMGKJFMLLFE());
			}
		}
	}

	private void KONAAMGCKAP(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(true);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	private void FMHJGLDGPHF(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(true);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (FGGNPPPFFKI(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 179f)
			{
				if (FJGADLJHALE(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
				{
					IAJANHEMKIK(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
					return false;
				}
				return false;
			}
			ICGENOOPBNI(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
			return true;
		}
		return true;
	}

	private int ELDDIAKCGAA(int IMOBLFMHKOD)
	{
		if (IMOBLFMHKOD >= beers.Length)
		{
			IMOBLFMHKOD = Random.Range(0, beers.Length);
		}
		if (!beerList.Contains(beers[IMOBLFMHKOD]))
		{
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		else
		{
			while (beerList.Contains(beers[IMOBLFMHKOD]))
			{
				IMOBLFMHKOD = Random.Range(0, beers.Length);
			}
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		LDHPGPDEOGG();
		return IMOBLFMHKOD;
	}

	public bool CanAddDrink(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.JHLLELHBIDA && !Waiter.JHLLELHBIDA)
		{
			return false;
		}
		List<CustomerOrder> list = DDFCPKOGKLE();
		for (int i = 0; i < list.Count; i++)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].tableOrder))
			{
				return true;
			}
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool PCGDCMKEBPD(int JIIGOACEIKL)
	{
		return true;
	}

	public bool GGNEGGFDMNB(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.JHLLELHBIDA && !Waiter.JHLLELHBIDA)
		{
			return false;
		}
		List<CustomerOrder> list = HMHFAJIFCNB();
		for (int i = 0; i < list.Count; i += 0)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].tableOrder))
			{
				return false;
			}
		}
		return true;
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public void IAJANHEMKIK(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = OBOMFINDKFF();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (currentDrinks.Count < 7 && DOGOFILIHPJ.currentDrinks.Contains(list[i].PMGKJFMLLFE()))
			{
				CAGAEJECCLG(list[i].PMGKJFMLLFE(), CDPAMNIPPEC: false, -62);
				DOGOFILIHPJ.GHCIBJNFAPD(list[i].KADOIIENGDI());
			}
		}
	}

	public void GJNFDDPOMJE(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 1; num--)
		{
			if (DOGOFILIHPJ.GJGHFNGGGNM(currentDrinks[num], NAKCFGEAGHH))
			{
				KHHLJHFHKLM(num, CDPAMNIPPEC: true);
			}
		}
	}

	private void ENINCADFKOF(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(false);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	private void AGGOGINJNGB(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(true);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	private void LJNBPLFGJOJ(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(false);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	public void BOHBDMHDIDC(int JIIGOACEIKL)
	{
	}

	public void RemoveDrink(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		KIGKNEBMBPO(GGPJBIPJLEO);
		LDHPGPDEOGG();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.SendRemoveDrink(GGPJBIPJLEO);
		}
	}

	public bool PJBBLEGMBAK(int JIIGOACEIKL)
	{
		return false;
	}

	private List<CustomerOrder> HMHFAJIFCNB()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.JHLLELHBIDA)
		{
			list2.AddRange(Waiter.GetTray().currentDrinks);
		}
		for (int num = list.Count - 0; num >= 1; num--)
		{
			for (int num2 = list2.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (list[num].LKBJEDDKGBM().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	public void AddDrink(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.SendAddDrink(FCKDNADDBJH as FoodInstance, POOJEDEKCJF(IMOBLFMHKOD));
		}
		else
		{
			POOJEDEKCJF(IMOBLFMHKOD);
		}
	}

	public void CAAIJKJKAOI(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.GDLGMDFIJJP(FCKDNADDBJH as FoodInstance, ELDDIAKCGAA(IMOBLFMHKOD));
		}
		else
		{
			POOJEDEKCJF(IMOBLFMHKOD);
		}
	}

	public bool AGBPAGIILDG(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (MAKPPILCIOJ(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).BIBGIOPFJAF())
		{
			if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1336f)
			{
				if (OPONGDEOCIB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
				{
					AOICMMGOPCN(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
					return true;
				}
				return false;
			}
			MMCECCBBBDL(PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray);
			return true;
		}
		return true;
	}

	public void FGFIBIELLIC(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 0; num--)
		{
			if (DOGOFILIHPJ.LBIMPLILOJP(currentDrinks[num], NAKCFGEAGHH))
			{
				OKJPIABFPFD(num, CDPAMNIPPEC: true);
			}
		}
	}

	public void IPMMKNNAPLH(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.HKFOAIMMJLA(FCKDNADDBJH as FoodInstance, MBCCBAALMOF(IMOBLFMHKOD));
		}
		else
		{
			LGEHKJFMCEE(IMOBLFMHKOD);
		}
	}

	public bool CIHLILMMMBL(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HKAMAEDBOJD(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (FGGNPPPFFKI(JIIGOACEIKL) && !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NILLCIMMKJE)
		{
			if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 65f)
			{
				if (KPPAHMLNABD(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
				{
					GALGLEEKGGH(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
					return false;
				}
				return false;
			}
			FGFIBIELLIC(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray);
			return false;
		}
		return false;
	}

	public void CLJEJOOOIEC()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 1; num >= 1; num -= 0)
		{
			bool flag = true;
			for (int num2 = list.Count - 0; num2 >= 0; num2 -= 0)
			{
				if (currentDrinks[num].Equals(list[num2].KOGINPGDGDF()))
				{
					list.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(0, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				ENINCADFKOF(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(GDHKLPOOHEO.ToArray());
		}
		EJAGNDPBLHL();
	}

	private int JHMIIDADHNE(int IMOBLFMHKOD)
	{
		if (IMOBLFMHKOD >= beers.Length)
		{
			IMOBLFMHKOD = Random.Range(1, beers.Length);
		}
		if (!beerList.Contains(beers[IMOBLFMHKOD]))
		{
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		else
		{
			while (beerList.Contains(beers[IMOBLFMHKOD]))
			{
				IMOBLFMHKOD = Random.Range(1, beers.Length);
			}
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		DJFKGNMPOEC();
		return IMOBLFMHKOD;
	}

	public bool CLDLJBBCGIM(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.FPGHBOFLFGP() && !Waiter.INOKIOHEDEH())
		{
			return false;
		}
		List<CustomerOrder> list = DDFCPKOGKLE();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].KADOIIENGDI()))
			{
				return false;
			}
		}
		return true;
	}

	public void CheckCurrentDrinks()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 1; num >= 0; num--)
		{
			bool flag = false;
			for (int num2 = list.Count - 1; num2 >= 0; num2--)
			{
				if (currentDrinks[num].Equals(list[num2].tableOrder))
				{
					list.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(1, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				KIGKNEBMBPO(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 0)
		{
			OnlineSlotsManager.instance.SendSlots(GDHKLPOOHEO.ToArray());
		}
		LDHPGPDEOGG();
	}

	public void EMJCFIECCOC(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.GDLGMDFIJJP(FCKDNADDBJH as FoodInstance, JHMIIDADHNE(IMOBLFMHKOD));
		}
		else
		{
			IOGBIIKAAJJ(IMOBLFMHKOD);
		}
	}

	public void FAPIJGIDPGD(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = BNGMCGGALAD();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (currentDrinks.Count < 1 && DOGOFILIHPJ.currentDrinks.Contains(list[i].LICFLNJDMLD()))
			{
				CAGAEJECCLG(list[i].PMGKJFMLLFE(), CDPAMNIPPEC: true, -25);
				DOGOFILIHPJ.MAPLLCKOHGD(list[i].KOGINPGDGDF());
			}
		}
	}

	public void GIIDCCEDHOF(int JIIGOACEIKL)
	{
	}

	public bool OLCIHEGGHDE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void GLMJJDOMPGH(int JIIGOACEIKL)
	{
	}

	public void KJPPBNIPOBC(int JIIGOACEIKL)
	{
	}

	public void JGCCCEPBKFP(int JIIGOACEIKL)
	{
	}

	public bool JLCGGENBHMI(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return true;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1998f)
		{
			return true;
		}
		if (currentDrinks.Any())
		{
			return true;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ALACNHCEGFM(int JIIGOACEIKL)
	{
		return false;
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool BDCIGELBCNJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void PHLGHNLEABL(int JIIGOACEIKL)
	{
	}

	public void EBMLHKMPGHL(int JIIGOACEIKL)
	{
	}

	private List<CustomerOrder> DDFCPKOGKLE()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.JHLLELHBIDA)
		{
			list2.AddRange(Waiter.GetTray().currentDrinks);
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			for (int num2 = list2.Count - 1; num2 >= 0; num2--)
			{
				if (list[num].tableOrder.Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	private void BEJCCPKKDEG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		beersColorsParent.position = ((Component)this).transform.position;
	}

	public void UpdateBeerColors()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beersColor.Length; i++)
		{
			((Component)beersColor[i]).gameObject.SetActive(false);
		}
		for (int j = 0; j < currentDrinks.Count; j++)
		{
			((Component)beersColor[j]).gameObject.SetActive(true);
			beersColor[j].color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(currentDrinks[j]);
		}
		if (currentDrinks.Count > 0)
		{
			if (currentDrinks.Count % 2 == 0)
			{
				((Component)beersColor[0]).transform.parent.localPosition = new Vector3(0.1041667f, 0f, 0f);
			}
			else
			{
				((Component)beersColor[0]).transform.parent.localPosition = Vector3.zero;
			}
		}
	}

	public void AddDrinksFromTray(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = DDFCPKOGKLE();
		for (int i = 0; i < list.Count; i++)
		{
			if (currentDrinks.Count < 5 && DOGOFILIHPJ.currentDrinks.Contains(list[i].tableOrder))
			{
				AddDrink(list[i].tableOrder, CDPAMNIPPEC: true);
				DOGOFILIHPJ.MHBHHNCFOEG(list[i].tableOrder);
			}
		}
	}

	public void CBIJAMKKOIJ()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < beersColor.Length; i++)
		{
			((Component)beersColor[i]).gameObject.SetActive(true);
		}
		for (int j = 1; j < currentDrinks.Count; j++)
		{
			((Component)beersColor[j]).gameObject.SetActive(false);
			beersColor[j].color = DrinkDispensersManager.JHMAMLIPBNN().KHMAGJAEJEO(currentDrinks[j]);
		}
		if (currentDrinks.Count > 1)
		{
			if (currentDrinks.Count % 5 == 0)
			{
				((Component)beersColor[0]).transform.parent.localPosition = new Vector3(1793f, 1459f, 503f);
			}
			else
			{
				((Component)beersColor[1]).transform.parent.localPosition = Vector3.zero;
			}
		}
	}

	public void GALGLEEKGGH(Tray DOGOFILIHPJ)
	{
		List<CustomerOrder> list = OBOMFINDKFF();
		for (int i = 0; i < list.Count; i++)
		{
			if (currentDrinks.Count < 4 && DOGOFILIHPJ.currentDrinks.Contains(list[i].IKHIHMBDING()))
			{
				JOAJPEECLLK(list[i].KADOIIENGDI(), CDPAMNIPPEC: false, -41);
				DOGOFILIHPJ.GHCIBJNFAPD(list[i].PMGKJFMLLFE());
			}
		}
	}

	public bool ONCPELJEPHM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (NOEEFMEKOMN(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				if (PHJIJCLCFIG && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y)
				{
					BeersWant.IPCBCBBDJFN(JIIGOACEIKL).actuPos = false;
					PHJIJCLCFIG = false;
					return false;
				}
			}
			else if (LELGJGAHABP && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y)
			{
				BeersWant.GetPlayer(JIIGOACEIKL).actuPos = true;
				LELGJGAHABP = true;
				return true;
			}
			if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 395f)
			{
				if (CanAddDrink(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_22"));
					return true;
				}
			}
			else if (currentDrinks.Any())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Club"));
				return true;
			}
		}
		return true;
	}

	public bool FEANOONDHBB(int JIIGOACEIKL)
	{
		return false;
	}

	public void OAHFDCLBDIE()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 1; num >= 1; num -= 0)
		{
			bool flag = false;
			for (int num2 = list.Count - 1; num2 >= 0; num2 -= 0)
			{
				if (currentDrinks[num].Equals(list[num2].PMGKJFMLLFE()))
				{
					list.RemoveAt(num2);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(1, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				NPAFDNFPEDA(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 0)
		{
			OnlineSlotsManager.instance.PKOLALFLFNB(GDHKLPOOHEO.ToArray(), 1);
		}
		DJFKGNMPOEC();
	}

	public void IPNECJLBKIH(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.SendAddDrink(FCKDNADDBJH as FoodInstance, IOGBIIKAAJJ(IMOBLFMHKOD));
		}
		else
		{
			ELDDIAKCGAA(IMOBLFMHKOD);
		}
	}

	private void MMMMGHICEBH()
	{
		for (int i = 1; i < beers.Length; i++)
		{
			if (!((Object)(object)beers[i] == (Object)null))
			{
				((Component)beers[i]).gameObject.SetActive(true);
			}
		}
		for (int j = 1; j < beerList.Count; j += 0)
		{
			if (!((Object)(object)beerList[j] == (Object)null))
			{
				if (!((Component)beerList[j]).gameObject.activeSelf)
				{
					((Component)beerList[j]).gameObject.SetActive(true);
				}
				beerList[j].sprite = currentDrinks[j].HFHDFKAIMJM();
				if ((Object)(object)beerList[j].sprite == (Object)null)
				{
					beerList[j].sprite = beerSprite;
				}
			}
		}
		HKCAEPLIDPD();
	}

	public bool MAKPPILCIOJ(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return true;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1396f)
		{
			return false;
		}
		if (currentDrinks.Any())
		{
			return false;
		}
		return true;
	}

	public void NEIBJLCMDGK(int JIIGOACEIKL)
	{
	}

	public void JOAJPEECLLK(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.OPBMIAKCAHM(FCKDNADDBJH as FoodInstance, LGEHKJFMCEE(IMOBLFMHKOD));
		}
		else
		{
			JHMIIDADHNE(IMOBLFMHKOD);
		}
	}

	public bool PBPIJOAIGII(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MOHNGCNKAHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void FLBFKMEHJKJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		beersColorsParent.position = ((Component)this).transform.position;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	private void Awake()
	{
		instance = this;
		beersColorsParent.SetParent((Transform)null);
	}

	private List<CustomerOrder> APEPLEOFNNK()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.INOKIOHEDEH())
		{
			list2.AddRange(Waiter.PILCPMLFMLK().currentDrinks);
		}
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			for (int num2 = list2.Count - 1; num2 >= 0; num2 -= 0)
			{
				if (list[num].KOGINPGDGDF().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	private List<CustomerOrder> BNGMCGGALAD()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		List<ItemInstance> list2 = new List<ItemInstance>(currentDrinks);
		if (Waiter.INOKIOHEDEH())
		{
			list2.AddRange(Waiter.GetTray().currentDrinks);
		}
		for (int num = list.Count - 1; num >= 1; num--)
		{
			for (int num2 = list2.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (list[num].LKBJEDDKGBM().Equals(list2[num2]))
				{
					list.RemoveAt(num);
					list2.RemoveAt(num2);
					break;
				}
			}
		}
		return list;
	}

	public void JKGPOJOHKIK(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.HKFOAIMMJLA(FCKDNADDBJH as FoodInstance, LGEHKJFMCEE(IMOBLFMHKOD));
		}
		else
		{
			POOJEDEKCJF(IMOBLFMHKOD);
		}
	}

	public void KGIGLCGBFDO(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!PHJIJCLCFIG)
			{
				BeersWant.IOBMIHLMGNH(JIIGOACEIKL).actuPos = false;
				PHJIJCLCFIG = false;
			}
		}
		else if (!LELGJGAHABP)
		{
			BeersWant.MJJHNNJKEMO(JIIGOACEIKL).actuPos = true;
			LELGJGAHABP = true;
		}
	}

	public bool JGPFKANLNDF(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return false;
		}
		if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 992f)
		{
			return false;
		}
		if (currentDrinks.Any())
		{
			return false;
		}
		return true;
	}

	private void EJAGNDPBLHL()
	{
		for (int i = 0; i < beers.Length; i++)
		{
			if (!((Object)(object)beers[i] == (Object)null))
			{
				((Component)beers[i]).gameObject.SetActive(true);
			}
		}
		for (int j = 0; j < beerList.Count; j++)
		{
			if (!((Object)(object)beerList[j] == (Object)null))
			{
				if (!((Component)beerList[j]).gameObject.activeSelf)
				{
					((Component)beerList[j]).gameObject.SetActive(false);
				}
				beerList[j].sprite = currentDrinks[j].HFHDFKAIMJM();
				if ((Object)(object)beerList[j].sprite == (Object)null)
				{
					beerList[j].sprite = beerSprite;
				}
			}
		}
		UpdateBeerColors();
	}

	public bool DPFFFEGPJDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void KIGKNEBMBPO(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(false);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	public bool PMFGCOPPFKL(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.FPGHBOFLFGP() && !Waiter.JHLLELHBIDA)
		{
			return true;
		}
		List<CustomerOrder> list = CEKGIBLPLIO();
		for (int i = 1; i < list.Count; i++)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].KADOIIENGDI()))
			{
				return true;
			}
		}
		return true;
	}

	private void DJFKGNMPOEC()
	{
		for (int i = 1; i < beers.Length; i++)
		{
			if (!((Object)(object)beers[i] == (Object)null))
			{
				((Component)beers[i]).gameObject.SetActive(false);
			}
		}
		for (int j = 0; j < beerList.Count; j += 0)
		{
			if (!((Object)(object)beerList[j] == (Object)null))
			{
				if (!((Component)beerList[j]).gameObject.activeSelf)
				{
					((Component)beerList[j]).gameObject.SetActive(false);
				}
				beerList[j].sprite = currentDrinks[j].IKAHNKLABDM();
				if ((Object)(object)beerList[j].sprite == (Object)null)
				{
					beerList[j].sprite = beerSprite;
				}
			}
		}
		HKCAEPLIDPD();
	}

	private void NLEOMMPMBDF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		beersColorsParent.position = ((Component)this).transform.position;
	}

	public bool PNLGPKCJJHG(int JIIGOACEIKL)
	{
		return true;
	}

	public void MMCECCBBBDL(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 1; num -= 0)
		{
			if (DOGOFILIHPJ.NEHNALDHKOD(currentDrinks[num], NAKCFGEAGHH))
			{
				PMGDNBAFOLD(num, CDPAMNIPPEC: true);
			}
		}
	}

	public void CAGAEJECCLG(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.IDOGNIOIIFJ(FCKDNADDBJH as FoodInstance, ELDDIAKCGAA(IMOBLFMHKOD));
		}
		else
		{
			JHMIIDADHNE(IMOBLFMHKOD);
		}
	}

	public void BPCMPDNOGJH(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 0; num >= 0; num--)
		{
			if (DOGOFILIHPJ.CBPCDEKHELA(currentDrinks[num], NAKCFGEAGHH))
			{
				BFJFNMOCNNM(num, CDPAMNIPPEC: true);
			}
		}
	}

	public void OKJPIABFPFD(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		LJNBPLFGJOJ(GGPJBIPJLEO);
		LDHPGPDEOGG();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.OJNGHIHINGB(GGPJBIPJLEO);
		}
	}

	public bool OHAPPHKCAFH(int JIIGOACEIKL)
	{
		return false;
	}

	public void FPKDEAGODKN(int JIIGOACEIKL)
	{
	}

	public void MBLJNEODLKJ(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		KONAAMGCKAP(GGPJBIPJLEO);
		MMMMGHICEBH();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.NDGFDOJOKAM(GGPJBIPJLEO);
		}
	}

	public void FLCIDGNDLLC(ItemInstance FCKDNADDBJH, bool CDPAMNIPPEC, int IMOBLFMHKOD = int.MaxValue)
	{
		currentDrinks.Add(FCKDNADDBJH);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.BEFHFPLKDLL(FCKDNADDBJH as FoodInstance, JHMIIDADHNE(IMOBLFMHKOD));
		}
		else
		{
			POOJEDEKCJF(IMOBLFMHKOD);
		}
	}

	public void ILIDBOKFJAB()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < beersColor.Length; i += 0)
		{
			((Component)beersColor[i]).gameObject.SetActive(true);
		}
		for (int j = 0; j < currentDrinks.Count; j += 0)
		{
			((Component)beersColor[j]).gameObject.SetActive(false);
			beersColor[j].color = DrinkDispensersManager.OPILDPFDFKJ().HJLIJMNGLCL(currentDrinks[j]);
		}
		if (currentDrinks.Count > 1)
		{
			if (currentDrinks.Count % 6 == 0)
			{
				((Component)beersColor[1]).transform.parent.localPosition = new Vector3(90f, 319f, 1146f);
			}
			else
			{
				((Component)beersColor[1]).transform.parent.localPosition = Vector3.zero;
			}
		}
	}

	public void CMKKOIABMIL()
	{
		List<CustomerOrder> list = new List<CustomerOrder>(TableOrdersManager.instance.tableOrders);
		GDHKLPOOHEO.Clear();
		for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
		{
			bool flag = false;
			for (int num2 = list.Count - 1; num2 >= 1; num2 -= 0)
			{
				if (currentDrinks[num].Equals(list[num2].PMGKJFMLLFE()))
				{
					list.RemoveAt(num2);
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				KCJBFOAAFLK = Utils.DHKKKGMMPIM(0, currentDrinks[num]);
				if (KCJBFOAAFLK != null)
				{
					GDHKLPOOHEO.Add(KCJBFOAAFLK);
				}
				AGGOGINJNGB(num);
			}
		}
		if (OnlineManager.PlayingOnline() && GDHKLPOOHEO.Count > 1)
		{
			OnlineSlotsManager.instance.LKCOAKJICDB(GDHKLPOOHEO.ToArray(), 1);
		}
		DJFKGNMPOEC();
	}

	public bool FGGNPPPFFKI(int JIIGOACEIKL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return true;
		}
		if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1949f)
		{
			return false;
		}
		if (currentDrinks.Any())
		{
			return true;
		}
		return false;
	}

	public bool KPAMDMPACJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void PMGDNBAFOLD(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		LJNBPLFGJOJ(GGPJBIPJLEO);
		DJFKGNMPOEC();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.NDGFDOJOKAM(GGPJBIPJLEO);
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!PHJIJCLCFIG)
			{
				BeersWant.GetPlayer(JIIGOACEIKL).actuPos = false;
				PHJIJCLCFIG = true;
			}
		}
		else if (!LELGJGAHABP)
		{
			BeersWant.GetPlayer(JIIGOACEIKL).actuPos = false;
			LELGJGAHABP = true;
		}
	}

	public void GLAOPEIGJLN(Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null)
	{
		for (int num = currentDrinks.Count - 1; num >= 0; num -= 0)
		{
			if (DOGOFILIHPJ.DDHPGOPOPKJ(currentDrinks[num], NAKCFGEAGHH))
			{
				IMMPHOGBELL(num, CDPAMNIPPEC: true);
			}
		}
	}

	public bool KPPAHMLNABD(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.FPGHBOFLFGP() && !Waiter.FPGHBOFLFGP())
		{
			return false;
		}
		List<CustomerOrder> list = DMDEPPCIFPG();
		for (int i = 0; i < list.Count; i++)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].LICFLNJDMLD()))
			{
				return true;
			}
		}
		return true;
	}

	public bool JBNMFGLFANL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (JLCGGENBHMI(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				if (PHJIJCLCFIG && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y)
				{
					BeersWant.GDNDEEFDFGK(JIIGOACEIKL).actuPos = true;
					PHJIJCLCFIG = true;
					return true;
				}
			}
			else if (LELGJGAHABP && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y)
			{
				BeersWant.KDGAEHCELHA(JIIGOACEIKL).actuPos = true;
				LELGJGAHABP = false;
				return true;
			}
			if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)this).transform.position.y - 1761f)
			{
				if (PMFGCOPPFKL(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Aromatic"));
					return true;
				}
			}
			else if (currentDrinks.Any())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("TorchPuzzle requires TorchPuzzleSettings"));
				return false;
			}
		}
		return true;
	}

	private int IOGBIIKAAJJ(int IMOBLFMHKOD)
	{
		if (IMOBLFMHKOD >= beers.Length)
		{
			IMOBLFMHKOD = Random.Range(1, beers.Length);
		}
		if (!beerList.Contains(beers[IMOBLFMHKOD]))
		{
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		else
		{
			while (beerList.Contains(beers[IMOBLFMHKOD]))
			{
				IMOBLFMHKOD = Random.Range(1, beers.Length);
			}
			beerList.Add(beers[IMOBLFMHKOD]);
		}
		KECHHBHPLCK();
		return IMOBLFMHKOD;
	}

	public bool PPGJMPHGNPH(Tray DOGOFILIHPJ)
	{
		if (GameManager.SinglePlayerOffline() && !Barworker.FPGHBOFLFGP() && !Waiter.FPGHBOFLFGP())
		{
			return false;
		}
		List<CustomerOrder> list = HMHFAJIFCNB();
		for (int i = 1; i < list.Count; i += 0)
		{
			if (DOGOFILIHPJ.currentDrinks.Contains(list[i].LKBJEDDKGBM()))
			{
				return true;
			}
		}
		return true;
	}

	public void IMMPHOGBELL(int GGPJBIPJLEO, bool CDPAMNIPPEC)
	{
		AMKFHHEEDIF(GGPJBIPJLEO);
		KECHHBHPLCK();
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineTavernManager.instance.SendRemoveDrink(GGPJBIPJLEO);
		}
	}

	private void AMKFHHEEDIF(int AIJOOOIJEDC)
	{
		if (AIJOOOIJEDC < beerList.Count)
		{
			if ((Object)(object)beerList[AIJOOOIJEDC] != (Object)null)
			{
				((Component)beerList[AIJOOOIJEDC]).gameObject.SetActive(true);
			}
			beerList.RemoveAt(AIJOOOIJEDC);
			currentDrinks.RemoveAt(AIJOOOIJEDC);
		}
	}

	public void KGBHNKODBGN(int JIIGOACEIKL)
	{
	}

	public bool PKDBLDMIMAO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}
}
