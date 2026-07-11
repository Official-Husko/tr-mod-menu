using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CustomerOrder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BPJIHPBNJDB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int reputation;

		public CustomerOrder _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public BPJIHPBNJDB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CustomerOrder customerOrder = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				TavernReputation.AddAndShowReputationGain(reputation, Vector2.op_Implicit(((Component)customerOrder).transform.position));
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public Canvas canvasBubbles;

	public ItemInstance roomItemRequest;

	public RentedRoomDoor rentedRoomDoor;

	public CustomerBase customerBase;

	public RectTransform bubble;

	public GameObject leftPosition;

	public GameObject rightPosition;

	public bool useRequestIcon;

	public Image drink;

	public Image drinkColor;

	public Sprite food;

	public Sprite beer;

	public Sprite water;

	public bool requesting;

	public Customer customer => customerBase as Customer;

	public ItemInstance tableOrder => customerBase.currentRequest;

	public void DJELFIKKCOF(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = true;
		((Behaviour)canvasBubbles).enabled = false;
		((Component)bubble).gameObject.SetActive(true);
		BFOJIKGMEIF(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: false);
		RentedRoomsManager.IOGEKKBMMGN(this);
	}

	public void CCABKKMNJDO(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = false;
		((Behaviour)canvasBubbles).enabled = true;
		((Component)bubble).gameObject.SetActive(false);
		UpdateSprite(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: false);
		RentedRoomsManager.AddRoomOrder(this);
	}

	public void RequestRoomOrder()
	{
		if (Random.Range(0, 2) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 0)
			{
				roomItemRequest = allFoodInstances[Random.Range(0, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(324).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML();
			}
		}
		UpdateRequestRoomOrder(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void ServeRoomCustomer(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.JEPBBEBJEFI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.MHBHHNCFOEG(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 100) >= NAKCFGEAGHH.GetPerkValue(55))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				KAPJOAHIKGE(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.GHDCKOJGAMM(0));
			}
		}
		else
		{
			KAPJOAHIKGE(Price.GHDCKOJGAMM(GKNOLDEELGL));
		}
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			BDKJMPLGINI(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)rentedRoomDoor).transform);
		RemoveRoomOrder();
	}

	public void UpdateDrinkColorRoom()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(roomItemRequest);
	}

	private void EFPFPEMPHBB(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.GGFJGHHHEJC.customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.MNFMOEKMJKN().customerInfo.comfortMultiplier);
		float num = 1815f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(0) / 1445f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(-51) / 1840f;
			if (!roomItemRequest.JEPBBEBJEFI())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(6) / 1953f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-100) / 367f;
			}
			if (Bouncer.LDICGJGFBBG())
			{
				num += (float)Bouncer.GetEmployeePerkValue(-78) / 144f;
			}
		}
		num = ((WorldTime.NOAOJJLNHJJ.hour * -124 >= 162) ? (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(-110, 1) / 1403f)) : (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(7, 1) / 1269f)));
		if (repComfortMin > 0)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(ICGJGIGEJAF((int)((float)repComfortMin * CommonReferences.MNFMOEKMJKN().customerInfo.roomOrdersReputiationMultiplier)));
	}

	public void JNAEDPBIGAL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().BDOHOMHCKLH(roomItemRequest);
	}

	public void CLNAMDAPPOE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.JFNOOMJMHCB().LHOIHOGNBKI(customerBase.currentRequest);
		}
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	public void LBAJFNAFAIP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().HJLIJMNGLCL(roomItemRequest);
	}

	private void HEGIEELMDIJ(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.JHKPNCOMAHI() > 1)
		{
			TavernServiceManager.AFFGPMFKEFH().EEBMAOHKJOG(ENDNDAOPKHD);
			Money.FGAKGNMLEKL(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			Money.LNDBFPMBBBD(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(1088f, 1253f, 523f)), CDPAMNIPPEC: false);
		}
	}

	public void UpdateRequestRoomOrder(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = true;
		((Behaviour)canvasBubbles).enabled = true;
		((Component)bubble).gameObject.SetActive(true);
		UpdateSprite(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: false);
		RentedRoomsManager.AddRoomOrder(this);
	}

	public void DDIMFIAHMHJ(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			customer.SetNewItemRequest(null, GIMHPAANCDH: true, CDPAMNIPPEC: false);
			return;
		}
		DPLHHOHLBDC().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: false, CDPAMNIPPEC: false);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((AHGGMHBEIOF().characterAnimation.FCGBJEIIMBC == (Direction)5) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(false);
			INPJKDBOFOM(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.APCOJIEEIMA(this);
		}
		if (OnlineManager.PGAGDFAEEFB() && Object.op_Implicit((Object)(object)MFFKBCHNMJF()) && Object.op_Implicit((Object)(object)EGFDNFIBNDA().npc.seat))
		{
			DPLHHOHLBDC().npc.seat.table.serveOrderInTable.customers.Add(customer);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			AHGGMHBEIOF().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, OAKLPAAFAIB().npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void LFCMDCPLLFJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().GetDrinkDispenserColor(roomItemRequest);
	}

	public void EAKDJBOJFJJ(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.JEPBBEBJEFI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.BOBOKKNEFPJ(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(1, 43) >= NAKCFGEAGHH.GetPerkValue(11))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				HEGIEELMDIJ(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.OMDBJINNHPC(1));
			}
		}
		else
		{
			MBFPMMEFFHF(Price.IFMFKEMHHLM(GKNOLDEELGL));
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			BDKJMPLGINI(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)rentedRoomDoor).transform);
		LBBJFHBBICB();
	}

	[SpecialName]
	public ItemInstance PMGKJFMLLFE()
	{
		return customerBase.currentRequest;
	}

	private void ECABFGPKDEP(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.GGFJGHHHEJC.customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.GGFJGHHHEJC.customerInfo.comfortMultiplier);
		float num = 1676f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(1) / 910f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(118) / 1824f;
			if (!roomItemRequest.JEPBBEBJEFI())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(3) / 997f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-42) / 1830f;
			}
			if (Bouncer.GKNNBKICEAK())
			{
				num += (float)Bouncer.NADBCNFALNF(3) / 1684f;
			}
		}
		num = ((WorldTime.HGIBNMBJMOC().hour * -120 >= 159) ? (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(45, 0, LDNMDAHFBGG: true) / 670f)) : (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(29, 0, LDNMDAHFBGG: true) / 836f)));
		if (repComfortMin > 1)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(LDKDBGHCEAH((int)((float)repComfortMin * CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersReputiationMultiplier)));
	}

	public void MPJLNNIPDHJ()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		RentedRoomsManager.RemoveRoomOrder(this);
	}

	public void RemoveRoomOrder()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		RentedRoomsManager.RemoveRoomOrder(this);
	}

	public void PPJHPNHBGOJ()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().HJLIJMNGLCL(customerBase.currentRequest);
		}
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	public static void PKEABNKEDNL(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.AFOACBIHNCL() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.IPKBBGHCJNE())
		{
			if (DNLMCHDOMOK.AFOACBIHNCL().IMCJPECAAPC() == 119)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.AJKDEIPDLHI();
		}
		if (DNLMCHDOMOK.JEPBBEBJEFI())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.JHMAMLIPBNN().LHOIHOGNBKI(DNLMCHDOMOK);
		}
	}

	public void EFOKJCCCABE()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.JFNOOMJMHCB().GetDrinkDispenserColor(roomItemRequest);
	}

	public void EHPNDEFLMLL(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.BAHJFDHLDEI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.LBHAFCAMDEN(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, -40) >= NAKCFGEAGHH.GetPerkValue(9))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				GMIFOFIODJH(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.DHMGJGHCCJD(0));
			}
		}
		else
		{
			MBFPMMEFFHF(Price.DHMGJGHCCJD(GKNOLDEELGL));
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			OIMMIFMKNFH(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)rentedRoomDoor).transform);
		OLDOLNKHACP();
	}

	public void MLONMPCCBIF(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = false;
		((Behaviour)canvasBubbles).enabled = false;
		((Component)bubble).gameObject.SetActive(false);
		LMCJGPHIKPB(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: false);
		RentedRoomsManager.IOGEKKBMMGN(this);
	}

	public static void MEDIGDENNDK(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.KNFNJFFCFNO() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.BAHJFDHLDEI())
		{
			if (DNLMCHDOMOK.KNFNJFFCFNO().JPNFKDMFKMC() == -57)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = true;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.BAHJFDHLDEI();
		}
		if (DNLMCHDOMOK.JLCBECDECBP())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.OPILDPFDFKJ().LHOIHOGNBKI(DNLMCHDOMOK);
		}
	}

	[SpecialName]
	public ItemInstance EGDDFIEGHMC()
	{
		return customerBase.currentRequest;
	}

	public void NLBDLOOALPJ()
	{
		if (Random.Range(0, 8) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 0)
			{
				roomItemRequest = list[Random.Range(0, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(-82, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 1)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GOKIDLOELKB(42, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		KHEGBGPIIDM(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void CMHKMIEFOBO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.JFNOOMJMHCB().KHMAGJAEJEO(roomItemRequest);
	}

	public void UpdateDrinkColorTable()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(customerBase.currentRequest);
		}
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendUpdateDrinkColorTable();
		}
	}

	private IEnumerator KKMLCGDEEEN(int FLOIELKNIAC)
	{
		yield return CommonReferences.wait2;
		TavernReputation.AddAndShowReputationGain(FLOIELKNIAC, Vector2.op_Implicit(((Component)this).transform.position));
	}

	private IEnumerator IOOGIODADLH(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	private void IHEIEGDINKM(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.JHKPNCOMAHI() > 0)
		{
			TavernServiceManager.LKOABOAADCD().MKEMGFAPIIK(ENDNDAOPKHD);
			Money.DCAFCEAIEID(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			Money.JKLFMOOBNIO(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(1901f, 1778f, 183f)));
		}
	}

	public void OOLFJPIHCON()
	{
		if (Random.Range(1, 4) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 1)
			{
				roomItemRequest = list[Random.Range(1, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.INJBNHPGCIJ(128, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.EABMGELAAPG(165, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		OCACHLOJLMA(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void KCJMIHFOEFO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().HJLIJMNGLCL(customerBase.currentRequest);
		}
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendUpdateDrinkColorTable();
		}
	}

	public void OJNGOEHODEO(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.JLCBECDECBP() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.LBHAFCAMDEN(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, -49) >= NAKCFGEAGHH.GetPerkValue(-120))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				GMIFOFIODJH(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.DHMGJGHCCJD(1));
			}
		}
		else
		{
			IHEIEGDINKM(Price.HNDGIKFAKNC(GKNOLDEELGL));
		}
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			NCDEADFDOJD(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)rentedRoomDoor).transform);
		RemoveRoomOrder();
	}

	public void KGNBIIBAMLD()
	{
		if (Random.Range(0, 2) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 0)
			{
				roomItemRequest = allFoodInstances[Random.Range(1, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.COEFFIHKMJG(-183, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.INJBNHPGCIJ(-90, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		OCACHLOJLMA(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void KOIOLDHGGFE()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		TableOrdersManager.instance.CCEHBICCBKP(this);
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendRemoveTableOrder(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	private void OIMMIFMKNFH(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.GGFJGHHHEJC.customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.GGFJGHHHEJC.customerInfo.comfortMultiplier);
		float num = 1595f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(1) / 1522f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(114) / 846f;
			if (!roomItemRequest.IJLGJNLFNDB())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(6) / 999f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(112) / 1992f;
			}
			if (Bouncer.JHLLELHBIDA)
			{
				num += (float)Bouncer.GetEmployeePerkValue(-60) / 475f;
			}
		}
		num = ((WorldTime.NOAOJJLNHJJ.hour * -41 >= -26) ? (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(91, 1) / 440f)) : (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(-19) / 393f)));
		if (repComfortMin > 1)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(NJEEHMDHOMD((int)((float)repComfortMin * CommonReferences.MNFMOEKMJKN().customerInfo.roomOrdersReputiationMultiplier)));
	}

	public void LBBJFHBBICB()
	{
		requesting = true;
		((Component)bubble).gameObject.SetActive(false);
		RentedRoomsManager.CFKDOBBPKNP(this);
	}

	public void MGMLCBKLMDE()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().HJLIJMNGLCL(customerBase.currentRequest);
		}
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	public void KOMEPJKELKA()
	{
		if (Random.Range(1, 2) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 1)
			{
				roomItemRequest = allFoodInstances[Random.Range(1, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.COEFFIHKMJG(37, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 1)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GOKIDLOELKB(131, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		DJELFIKKCOF(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void OOEMCJFBDCI(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.JLCBECDECBP() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.MAPLLCKOHGD(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 53) >= NAKCFGEAGHH.GetPerkValue(2))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				IHEIEGDINKM(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.OMDBJINNHPC(0));
			}
		}
		else
		{
			IHEIEGDINKM(Price.LEDHAKFAHCI(GKNOLDEELGL));
		}
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			OIMMIFMKNFH(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)rentedRoomDoor).transform);
		OMPOJABIHIP();
	}

	[SpecialName]
	public ItemInstance HDOHIKMGKEP()
	{
		return customerBase.currentRequest;
	}

	public static void INPJKDBOFOM(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.AFOACBIHNCL() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.IJLGJNLFNDB())
		{
			if (DNLMCHDOMOK.LHBPOPOIFLE().JPNFKDMFKMC() == -43)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = true;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.IJLGJNLFNDB();
		}
		if (DNLMCHDOMOK.JLCBECDECBP())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.OLHBLKIAFOM().GetDrinkDispenserColor(DNLMCHDOMOK);
		}
	}

	public void AAENBLOBLHB()
	{
		if (Random.Range(0, 1) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 1)
			{
				roomItemRequest = allFoodInstances[Random.Range(0, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.CPMMBEPEJLO(90, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(92, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		UpdateRequestRoomOrder(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void NJCGFGPBILI(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			KGDFPLNBIPJ().SetNewItemRequest(null, GIMHPAANCDH: false, CDPAMNIPPEC: true);
			return;
		}
		DPLHHOHLBDC().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: true, CDPAMNIPPEC: true);
		if (customerBase.currentRequest != null)
		{
			requesting = false;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((customer.characterAnimation.FCGBJEIIMBC == Direction.Diagonal) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(false);
			MEDIGDENNDK(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.DJCJAPAALHG(this);
		}
		if (OnlineManager.MasterOrOffline() && Object.op_Implicit((Object)(object)KGDFPLNBIPJ()) && Object.op_Implicit((Object)(object)EGFDNFIBNDA().npc.seat))
		{
			AHGGMHBEIOF().npc.seat.table.serveOrderInTable.customers.Add(DPLHHOHLBDC());
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			EGFDNFIBNDA().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, DPLHHOHLBDC().npc.seat.table.onlineTable.uniqueId);
		}
	}

	[SpecialName]
	public Customer MFFKBCHNMJF()
	{
		return customerBase as Customer;
	}

	public void BCLMLIDKHOJ()
	{
		if (Random.Range(1, 6) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 0)
			{
				roomItemRequest = list[Random.Range(0, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.INJBNHPGCIJ(92).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.CPMMBEPEJLO(-176).JMDALJBNFML();
			}
		}
		OCACHLOJLMA(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public static void JGDIFJNCFBO(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.AFOACBIHNCL() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.BIIJEMDLBDP())
		{
			if (DNLMCHDOMOK.AFOACBIHNCL().CIGFGKKCPCK(DAINLFIMLIH: false) == 62)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = true;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.IJLGJNLFNDB();
		}
		if (DNLMCHDOMOK.IPKBBGHCJNE())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.OLHBLKIAFOM().HJLIJMNGLCL(DNLMCHDOMOK);
		}
	}

	private IEnumerator IGKDFBKFLHK(int FLOIELKNIAC)
	{
		yield return CommonReferences.wait2;
		TavernReputation.AddAndShowReputationGain(FLOIELKNIAC, Vector2.op_Implicit(((Component)this).transform.position));
	}

	public void EHIMCNECFKK()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(true);
		TableOrdersManager.instance.GJMHBCABJEH(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.JMFBJBMNLIJ(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public static void HENIANDOCPP(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.PHGLMBIEOMK() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.BIIJEMDLBDP())
		{
			if (DNLMCHDOMOK.KNFNJFFCFNO().JPNFKDMFKMC(DAINLFIMLIH: false) == 178)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = true;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.IPKBBGHCJNE();
		}
		if (DNLMCHDOMOK.AJKDEIPDLHI())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.GGFJGHHHEJC.BDOHOMHCKLH(DNLMCHDOMOK);
		}
	}

	public static void CNIAPGKBKOI(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.LHBPOPOIFLE() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.JEPBBEBJEFI())
		{
			if (DNLMCHDOMOK.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false) == -124)
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.JLCBECDECBP();
		}
		if (DNLMCHDOMOK.JLCBECDECBP())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.BNDNMBGJEKP().GetDrinkDispenserColor(DNLMCHDOMOK);
		}
	}

	[SpecialName]
	public ItemInstance IKHIHMBDING()
	{
		return customerBase.currentRequest;
	}

	public void OMOIGMEMPOO()
	{
		requesting = true;
		((Component)bubble).gameObject.SetActive(false);
		TableOrdersManager.instance.GMJKKEHDOHD(this);
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendRemoveTableOrder(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	[SpecialName]
	public Customer DPLHHOHLBDC()
	{
		return customerBase as Customer;
	}

	public void JOOPOLEPMDK()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		TableOrdersManager.instance.CHIFBKLEOAL(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendRemoveTableOrder(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	private void KAPJOAHIKGE(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.OOIPLIEJILO() > 0)
		{
			TavernServiceManager.GGFJGHHHEJC.AddSale(ENDNDAOPKHD);
			Money.AddPrice(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			Money.SpawnMoneyText(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(0f, 1.25f, 0f)), CDPAMNIPPEC: false);
		}
	}

	private IEnumerator ABEPAEMPDOL(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	public void ENNJAKPICAA(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			MFFKBCHNMJF().SetNewItemRequest(null, GIMHPAANCDH: true, CDPAMNIPPEC: true);
			return;
		}
		KGDFPLNBIPJ().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: false, CDPAMNIPPEC: false);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((MFFKBCHNMJF().characterAnimation.FCGBJEIIMBC == (Direction)5) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(false);
			BFOJIKGMEIF(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.FALLMAIFLDO(this);
		}
		if (OnlineManager.PGAGDFAEEFB() && Object.op_Implicit((Object)(object)EGFDNFIBNDA()) && Object.op_Implicit((Object)(object)MFFKBCHNMJF().npc.seat))
		{
			AHGGMHBEIOF().npc.seat.table.serveOrderInTable.customers.Add(customer);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			KGDFPLNBIPJ().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, AHGGMHBEIOF().npc.seat.table.onlineTable.uniqueId);
		}
	}

	[SpecialName]
	public Customer KGDFPLNBIPJ()
	{
		return customerBase as Customer;
	}

	public void CNFHLEBPCBN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.BDOHOMHCKLH(roomItemRequest);
	}

	private void GMIFOFIODJH(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.OOIPLIEJILO() > 0)
		{
			TavernServiceManager.IFPLPBMCKLB().MKEMGFAPIIK(ENDNDAOPKHD);
			Money.AddPrice(ENDNDAOPKHD, OPOHOHFHFFI: false, BGKCHMNJBLJ: false);
			Money.BCINHMELFNJ(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(1462f, 924f, 1355f)), CDPAMNIPPEC: false);
		}
	}

	private void OCEDMJFELBN(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.MNFMOEKMJKN().customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.MNFMOEKMJKN().customerInfo.comfortMultiplier);
		float num = 1322f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(1) / 1454f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(-80) / 234f;
			if (!roomItemRequest.BAHJFDHLDEI())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(3) / 1170f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-31) / 1992f;
			}
			if (Bouncer.GKNNBKICEAK())
			{
				num += (float)Bouncer.NADBCNFALNF(-78) / 1597f;
			}
		}
		num = ((WorldTime.HGIBNMBJMOC().hour * -136 >= 88) ? (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(-41) / 1250f)) : (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(-21) / 1049f)));
		if (repComfortMin > 0)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(KKMLCGDEEEN((int)((float)repComfortMin * CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersReputiationMultiplier)));
	}

	public static void BFOJIKGMEIF(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.PHGLMBIEOMK() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.BAHJFDHLDEI())
		{
			if (DNLMCHDOMOK.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) == 13)
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.BIIJEMDLBDP();
		}
		if (DNLMCHDOMOK.IPKBBGHCJNE())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.JHMAMLIPBNN().BDOHOMHCKLH(DNLMCHDOMOK);
		}
	}

	private IEnumerator HEHNALDAKEO(int FLOIELKNIAC)
	{
		yield return CommonReferences.wait2;
		TavernReputation.AddAndShowReputationGain(FLOIELKNIAC, Vector2.op_Implicit(((Component)this).transform.position));
	}

	[SpecialName]
	public Customer AHGGMHBEIOF()
	{
		return customerBase as Customer;
	}

	public void HCEAHFEMJBO()
	{
		if (Random.Range(0, 5) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 1)
			{
				roomItemRequest = allFoodInstances[Random.Range(1, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.EABMGELAAPG(68, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 1)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.COEFFIHKMJG(-92).JMDALJBNFML();
			}
		}
		UpdateRequestRoomOrder(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void OKMOCMDAKMD(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = true;
		((Behaviour)canvasBubbles).enabled = false;
		((Component)bubble).gameObject.SetActive(true);
		LMCJGPHIKPB(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: true);
		RentedRoomsManager.IOGEKKBMMGN(this);
	}

	public void NACIDEMFDDJ(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.JEPBBEBJEFI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.MAPLLCKOHGD(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, -54) >= NAKCFGEAGHH.GetPerkValue(3))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				AHLBNMOICOO(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.HNDGIKFAKNC(1));
			}
		}
		else
		{
			GMIFOFIODJH(Price.IFMFKEMHHLM(GKNOLDEELGL));
		}
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			GIBCBOCJHAP(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)rentedRoomDoor).transform);
		LBBJFHBBICB();
	}

	public void MGJOIIODANL()
	{
		if (Random.Range(0, 8) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 0)
			{
				roomItemRequest = allFoodInstances[Random.Range(0, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(71, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GOKIDLOELKB(116, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		CCABKKMNJDO(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void RemoveTableOrder()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		TableOrdersManager.instance.RemoveTableOrder(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendRemoveTableOrder(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void MONAACKMKGH(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			AHGGMHBEIOF().SetNewItemRequest(null, GIMHPAANCDH: true, CDPAMNIPPEC: true);
			return;
		}
		MFFKBCHNMJF().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: false, CDPAMNIPPEC: true);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((AHGGMHBEIOF().characterAnimation.FCGBJEIIMBC == Direction.Diagonal) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(true);
			BFOJIKGMEIF(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.CJINGKDBIEE(this);
		}
		if (OnlineManager.MasterOrOffline() && Object.op_Implicit((Object)(object)KGDFPLNBIPJ()) && Object.op_Implicit((Object)(object)customer.npc.seat))
		{
			DPLHHOHLBDC().npc.seat.table.serveOrderInTable.customers.Add(EGFDNFIBNDA());
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OAKLPAAFAIB().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, DPLHHOHLBDC().npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void DNAOIMOOGAD()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().KHMAGJAEJEO(customerBase.currentRequest);
		}
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	public void BPHECPBLHLG()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().LHOIHOGNBKI(customerBase.currentRequest);
		}
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	private void NCDEADFDOJD(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.MNFMOEKMJKN().customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.GGFJGHHHEJC.customerInfo.comfortMultiplier);
		float num = 1864f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(1) / 473f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(-22) / 374f;
			if (!roomItemRequest.BIIJEMDLBDP())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(6) / 203f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-62) / 107f;
			}
			if (Bouncer.JHLLELHBIDA)
			{
				num += (float)Bouncer.NADBCNFALNF(-128) / 162f;
			}
		}
		num = ((WorldTime.NOAOJJLNHJJ.hour * 82 >= 90) ? (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(-83) / 323f)) : (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(52, 1) / 308f)));
		if (repComfortMin > 1)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(IOOGIODADLH((int)((float)repComfortMin * CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersReputiationMultiplier)));
	}

	public void AJJMAHOGOIJ()
	{
		if (Random.Range(0, 4) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 1)
			{
				roomItemRequest = list[Random.Range(1, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(169, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 1)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.INJBNHPGCIJ(93, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		DJELFIKKCOF(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public static void NCEJPKOICAF(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.PHGLMBIEOMK() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.AJKDEIPDLHI())
		{
			if (DNLMCHDOMOK.PHGLMBIEOMK().JDJGFAACPFC() == -175)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.JEPBBEBJEFI();
		}
		if (DNLMCHDOMOK.JEPBBEBJEFI())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.GGFJGHHHEJC.LHOIHOGNBKI(DNLMCHDOMOK);
		}
	}

	public void EJKLJMIPMMD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().HJLIJMNGLCL(roomItemRequest);
	}

	private IEnumerator ODJJDOKONJL(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	private IEnumerator NJEEHMDHOMD(int FLOIELKNIAC)
	{
		yield return CommonReferences.wait2;
		TavernReputation.AddAndShowReputationGain(FLOIELKNIAC, Vector2.op_Implicit(((Component)this).transform.position));
	}

	public void LIDGCJIPFJB()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(true);
		TableOrdersManager.instance.LCDMKIAEBNO(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.JMFBJBMNLIJ(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void AIDGEPMIFAM()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.KHMAGJAEJEO(customerBase.currentRequest);
		}
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	public void DPAGKKFCJGA()
	{
		requesting = true;
		((Component)bubble).gameObject.SetActive(true);
		TableOrdersManager.instance.OEEFOADLKNM(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendRemoveTableOrder(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void CCGIBNANLJD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.JFNOOMJMHCB().HJLIJMNGLCL(roomItemRequest);
	}

	[SpecialName]
	public ItemInstance BKDDBLFAGNJ()
	{
		return customerBase.currentRequest;
	}

	public void PAKLHJLEOPP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().BDOHOMHCKLH(roomItemRequest);
	}

	public void ILAOEDMCMMF()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().LHOIHOGNBKI(customerBase.currentRequest);
		}
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendUpdateDrinkColorTable();
		}
	}

	[SpecialName]
	public ItemInstance LICFLNJDMLD()
	{
		return customerBase.currentRequest;
	}

	private void FJBKCCBNDHC(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.BNCMDNFMECD() > 0)
		{
			TavernServiceManager.JFJOKGAOPHA().GDAGPLPPIPM(ENDNDAOPKHD);
			Money.FGAKGNMLEKL(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			Money.BCINHMELFNJ(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(127f, 1998f, 1418f)));
		}
	}

	public void OJALLGJONDC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.HJLIJMNGLCL(roomItemRequest);
	}

	public void KOHMKGOGHMO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.JHMAMLIPBNN().LHOIHOGNBKI(roomItemRequest);
	}

	public void BCBKMDLILBM(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			EGFDNFIBNDA().SetNewItemRequest(null, GIMHPAANCDH: false, CDPAMNIPPEC: true);
			return;
		}
		DPLHHOHLBDC().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: false, CDPAMNIPPEC: true);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = false;
			((Transform)bubble).position = ((customer.characterAnimation.FCGBJEIIMBC == (Direction)7) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(false);
			OOJPHIEMPOO(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.PIKHCMFHHAN(this);
		}
		if (OnlineManager.PGAGDFAEEFB() && Object.op_Implicit((Object)(object)DPLHHOHLBDC()) && Object.op_Implicit((Object)(object)customer.npc.seat))
		{
			OAKLPAAFAIB().npc.seat.table.serveOrderInTable.customers.Add(OAKLPAAFAIB());
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OAKLPAAFAIB().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, DPLHHOHLBDC().npc.seat.table.onlineTable.uniqueId);
		}
	}

	private IEnumerator CGMEMIEAAOO(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	private void MBFPMMEFFHF(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.JHKPNCOMAHI() > 1)
		{
			TavernServiceManager.JCMKNNOEONP().GNMKDEJPOKL(ENDNDAOPKHD);
			Money.DCAFCEAIEID(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
			Money.LNDBFPMBBBD(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(604f, 1637f, 605f)), CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public Customer EGFDNFIBNDA()
	{
		return customerBase as Customer;
	}

	public void BMLGDIBOAJO(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.BAHJFDHLDEI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.OAFLFGPCPFC(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 5) >= NAKCFGEAGHH.GetPerkValue(-80))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				HEGIEELMDIJ(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.OMDBJINNHPC(1));
			}
		}
		else
		{
			GMIFOFIODJH(Price.GHDCKOJGAMM(GKNOLDEELGL));
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			OIMMIFMKNFH(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)rentedRoomDoor).transform);
		OMPOJABIHIP();
	}

	public void OLDOLNKHACP()
	{
		requesting = true;
		((Component)bubble).gameObject.SetActive(true);
		RentedRoomsManager.ABIPBFCHLOC(this);
	}

	public void NLFAMMMGKGG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().LHOIHOGNBKI(roomItemRequest);
	}

	public void IDILOLEJFAO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().KHMAGJAEJEO(roomItemRequest);
	}

	public void OCACHLOJLMA(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = false;
		((Behaviour)canvasBubbles).enabled = true;
		((Component)bubble).gameObject.SetActive(false);
		JGDIFJNCFBO(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: false);
		RentedRoomsManager.AddRoomOrder(this);
	}

	public void OBKCJOLMKFF()
	{
		requesting = true;
		((Component)bubble).gameObject.SetActive(true);
		TableOrdersManager.instance.OEEFOADLKNM(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.JMFBJBMNLIJ(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	private IEnumerator LDKDBGHCEAH(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	[SpecialName]
	public ItemInstance OGFDHMDMBKJ()
	{
		return customerBase.currentRequest;
	}

	public void KPHNAJEGMDL()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(true);
		RentedRoomsManager.EFCPNDFPNBF(this);
	}

	public void GJBNIGPIKOM()
	{
		if (Random.Range(0, 7) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 1)
			{
				roomItemRequest = allFoodInstances[Random.Range(1, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.EABMGELAAPG(24, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.INJBNHPGCIJ(-92).JMDALJBNFML();
			}
		}
		MLONMPCCBIF(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	[SpecialName]
	public ItemInstance KADOIIENGDI()
	{
		return customerBase.currentRequest;
	}

	public void KPKPOFCCMBA(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			AHGGMHBEIOF().SetNewItemRequest(null, GIMHPAANCDH: false, CDPAMNIPPEC: false);
			return;
		}
		MFFKBCHNMJF().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: true, CDPAMNIPPEC: true);
		if (customerBase.currentRequest != null)
		{
			requesting = false;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((MFFKBCHNMJF().characterAnimation.FCGBJEIIMBC == Direction.Up) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(true);
			BFOJIKGMEIF(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.CJINGKDBIEE(this);
		}
		if (OnlineManager.MasterOrOffline() && Object.op_Implicit((Object)(object)EGFDNFIBNDA()) && Object.op_Implicit((Object)(object)MFFKBCHNMJF().npc.seat))
		{
			EGFDNFIBNDA().npc.seat.table.serveOrderInTable.customers.Add(EGFDNFIBNDA());
		}
		if (OnlineManager.IsMasterClient())
		{
			MFFKBCHNMJF().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, MFFKBCHNMJF().npc.seat.table.onlineTable.uniqueId);
		}
	}

	private void GIBCBOCJHAP(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.MNFMOEKMJKN().customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.GGFJGHHHEJC.customerInfo.comfortMultiplier);
		float num = 1057f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(0) / 1401f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(-90) / 748f;
			if (!roomItemRequest.JEPBBEBJEFI())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(7) / 625f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-32) / 107f;
			}
			if (Bouncer.LDICGJGFBBG())
			{
				num += (float)Bouncer.NADBCNFALNF(48) / 1339f;
			}
		}
		num = ((WorldTime.HGIBNMBJMOC().hour * -122 >= 138) ? (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(-42, 1) / 1138f)) : (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(79, 0, LDNMDAHFBGG: true) / 1889f)));
		if (repComfortMin > 1)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(EILFLLOLHHP((int)((float)repComfortMin * CommonReferences.MNFMOEKMJKN().customerInfo.roomOrdersReputiationMultiplier)));
	}

	[SpecialName]
	public ItemInstance KOGINPGDGDF()
	{
		return customerBase.currentRequest;
	}

	public void BMPIGIINPMA()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(true);
		TableOrdersManager.instance.GJMHBCABJEH(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendRemoveTableOrder(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void GADCOKCHAMD(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			KGDFPLNBIPJ().SetNewItemRequest(null, GIMHPAANCDH: true, CDPAMNIPPEC: false);
			return;
		}
		OAKLPAAFAIB().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: true, CDPAMNIPPEC: true);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((EGFDNFIBNDA().characterAnimation.FCGBJEIIMBC == Direction.Up) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(false);
			HENIANDOCPP(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.EBDNNBJOMNJ(this);
		}
		if (OnlineManager.PGAGDFAEEFB() && Object.op_Implicit((Object)(object)customer) && Object.op_Implicit((Object)(object)AHGGMHBEIOF().npc.seat))
		{
			OAKLPAAFAIB().npc.seat.table.serveOrderInTable.customers.Add(DPLHHOHLBDC());
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			EGFDNFIBNDA().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, AHGGMHBEIOF().npc.seat.table.onlineTable.uniqueId);
		}
	}

	public static void OOJPHIEMPOO(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.AFOACBIHNCL() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.AJKDEIPDLHI())
		{
			if (DNLMCHDOMOK.LHBPOPOIFLE().ODENMDOJPLC() == -69)
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = true;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.BIIJEMDLBDP();
		}
		if (DNLMCHDOMOK.IJLGJNLFNDB())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.JFNOOMJMHCB().LHOIHOGNBKI(DNLMCHDOMOK);
		}
	}

	public static void NEABKOECEHI(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.AFOACBIHNCL() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.AJKDEIPDLHI())
		{
			if (DNLMCHDOMOK.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == -44)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = true;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.IPKBBGHCJNE();
		}
		if (DNLMCHDOMOK.IPKBBGHCJNE())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.JHMAMLIPBNN().KHMAGJAEJEO(DNLMCHDOMOK);
		}
	}

	public void NNNHIHOCFLM()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.JHMAMLIPBNN().LHOIHOGNBKI(customerBase.currentRequest);
		}
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.SendUpdateDrinkColorTable();
		}
	}

	public void EFJLLLAEJFH(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.JEPBBEBJEFI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.MAPLLCKOHGD(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, -30) >= NAKCFGEAGHH.GetPerkValue(-117))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				HEGIEELMDIJ(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.LEDHAKFAHCI(1));
			}
		}
		else
		{
			HEGIEELMDIJ(Price.HNDGIKFAKNC(GKNOLDEELGL));
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences.GGFJGHHHEJC.OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			GCGKNBDBCCJ(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)rentedRoomDoor).transform);
		KPHNAJEGMDL();
	}

	public void OBBCPNMKADP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (customerBase.currentRequest != null)
		{
			((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.LHOIHOGNBKI(customerBase.currentRequest);
		}
		if (OnlineManager.JPPBEIJDCLJ() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.AIGDICMDEIC();
		}
	}

	public void KLBOFKLCKCJ()
	{
		if (Random.Range(0, 5) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 0)
			{
				roomItemRequest = list[Random.Range(0, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.AFOACBIHNCL(-61, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.COEFFIHKMJG(69, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		CCABKKMNJDO(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void FINFOOHHAGB(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.BAHJFDHLDEI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.MIIAOMLAPIM(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 24) >= NAKCFGEAGHH.GetPerkValue(17))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				GMIFOFIODJH(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.IFMFKEMHHLM(1));
			}
		}
		else
		{
			MBFPMMEFFHF(Price.HNDGIKFAKNC(GKNOLDEELGL));
		}
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			OCEDMJFELBN(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)rentedRoomDoor).transform);
		OLDOLNKHACP();
	}

	public void MNEMKIHGAHJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(roomItemRequest);
	}

	public void GCJMDOHMICO()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		TableOrdersManager.instance.GLLHGGOCBFK(this);
		if (OnlineManager.IsMasterClient() && customerBase is Customer customer)
		{
			customer.LJOHCJAOADD?.JMFBJBMNLIJ(customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void OMPOJABIHIP()
	{
		requesting = false;
		((Component)bubble).gameObject.SetActive(false);
		RentedRoomsManager.RemoveRoomOrder(this);
	}

	private IEnumerator BNJGDBGKMGL(int FLOIELKNIAC)
	{
		yield return CommonReferences.wait2;
		TavernReputation.AddAndShowReputationGain(FLOIELKNIAC, Vector2.op_Implicit(((Component)this).transform.position));
	}

	public void KHEGBGPIIDM(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = true;
		((Behaviour)canvasBubbles).enabled = true;
		((Component)bubble).gameObject.SetActive(false);
		BFOJIKGMEIF(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: false);
		RentedRoomsManager.IOGEKKBMMGN(this);
	}

	[SpecialName]
	public ItemInstance LKBJEDDKGBM()
	{
		return customerBase.currentRequest;
	}

	public static void LMCJGPHIKPB(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.AFOACBIHNCL() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.BAHJFDHLDEI())
		{
			if (DNLMCHDOMOK.LHBPOPOIFLE().IMCJPECAAPC() == -85)
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.JLCBECDECBP();
		}
		if (DNLMCHDOMOK.BAHJFDHLDEI())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.OLHBLKIAFOM().GetDrinkDispenserColor(DNLMCHDOMOK);
		}
	}

	public void IIKCLAJNCEJ()
	{
		if (Random.Range(1, 3) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 1)
			{
				roomItemRequest = list[Random.Range(0, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.EABMGELAAPG(-61).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.KMBGJEKCJFJ(132).JMDALJBNFML();
			}
		}
		KHEGBGPIIDM(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	public void GCDAOAKLJMN(int JIIGOACEIKL, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH = null, bool CDPAMNIPPEC = true, int GKNOLDEELGL = 0)
	{
		if (CDPAMNIPPEC)
		{
			if (roomItemRequest.AJKDEIPDLHI() && (DOGOFILIHPJ == null || !DOGOFILIHPJ.BOBOKKNEFPJ(roomItemRequest)))
			{
				return;
			}
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, -28) >= NAKCFGEAGHH.GetPerkValue(-11))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(roomItemRequest, NAKCFGEAGHH);
				GMIFOFIODJH(eNDNDAOPKHD);
				if (OnlineManager.PlayingOnline())
				{
					OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, eNDNDAOPKHD);
				}
			}
			else if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendServeCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, Price.LEDHAKFAHCI(1));
			}
		}
		else
		{
			IHEIEGDINKM(Price.GHDCKOJGAMM(GKNOLDEELGL));
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences.MNFMOEKMJKN().OnAnyCustomerServeItem(JIIGOACEIKL, roomItemRequest);
			EFPFPEMPHBB(NAKCFGEAGHH);
		}
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)rentedRoomDoor).transform);
		LBBJFHBBICB();
	}

	public void AJFGICFKLAN(ItemInstance BIMBBKGOJHG)
	{
		roomItemRequest = BIMBBKGOJHG;
		requesting = true;
		((Behaviour)canvasBubbles).enabled = false;
		((Component)bubble).gameObject.SetActive(false);
		OOJPHIEMPOO(BIMBBKGOJHG, drink, drinkColor, useRequestIcon, ANHLFAANEEA: true);
		RentedRoomsManager.AddRoomOrder(this);
	}

	[SpecialName]
	public Customer OAKLPAAFAIB()
	{
		return customerBase as Customer;
	}

	public void RequestTableOrder(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			customer.SetNewItemRequest(null, GIMHPAANCDH: true, CDPAMNIPPEC: true);
			return;
		}
		customer.SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: true, CDPAMNIPPEC: false);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = true;
			((Transform)bubble).position = ((customer.characterAnimation.FCGBJEIIMBC == Direction.Left) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(true);
			UpdateSprite(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.AddTableOrder(this);
		}
		if (OnlineManager.MasterOrOffline() && Object.op_Implicit((Object)(object)customer) && Object.op_Implicit((Object)(object)customer.npc.seat))
		{
			customer.npc.seat.table.serveOrderInTable.customers.Add(customer);
		}
		if (OnlineManager.IsMasterClient())
		{
			customer.LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, customer.npc.seat.table.onlineTable.uniqueId);
		}
	}

	public void JCKBINJAKJA()
	{
		if (Random.Range(1, 3) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 0)
			{
				roomItemRequest = allFoodInstances[Random.Range(0, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.CPMMBEPEJLO(-157, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(1, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.KMBGJEKCJFJ(185).JMDALJBNFML();
			}
		}
		KHEGBGPIIDM(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	private IEnumerator KLPEHJHCNPI(int FLOIELKNIAC)
	{
		yield return CommonReferences.wait2;
		TavernReputation.AddAndShowReputationGain(FLOIELKNIAC, Vector2.op_Implicit(((Component)this).transform.position));
	}

	public static void MFGOEDOEEMC(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.PHGLMBIEOMK() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.AJKDEIPDLHI())
		{
			if (DNLMCHDOMOK.AFOACBIHNCL().JDJGFAACPFC() == -37)
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.MNFMOEKMJKN().beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.IJLGJNLFNDB();
		}
		if (DNLMCHDOMOK.IPKBBGHCJNE())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.BNDNMBGJEKP().LHOIHOGNBKI(DNLMCHDOMOK);
		}
	}

	private void AHLBNMOICOO(Price ENDNDAOPKHD)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (ENDNDAOPKHD.JHKPNCOMAHI() > 0)
		{
			TavernServiceManager.GGFJGHHHEJC.AddSale(ENDNDAOPKHD);
			Money.CANMCFOCNPA(ENDNDAOPKHD);
			Money.LNDBFPMBBBD(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(623f, 913f, 50f)), CDPAMNIPPEC: false);
		}
	}

	private IEnumerator EILFLLOLHHP(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	public void BGIFNLABJCF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().HJLIJMNGLCL(roomItemRequest);
	}

	public void ILLHOPKJLPK()
	{
		if (Random.Range(1, 7) == 0)
		{
			List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
			if (allFoodInstances.Count > 0)
			{
				roomItemRequest = allFoodInstances[Random.Range(0, allFoodInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.AFOACBIHNCL(-2, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.KMBGJEKCJFJ(-14, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		AJFGICFKLAN(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	private IEnumerator ICGJGIGEJAF(int FLOIELKNIAC)
	{
		return new BPJIHPBNJDB(1)
		{
			_003C_003E4__this = this,
			reputation = FLOIELKNIAC
		};
	}

	public void ACIIHODLJHB(ItemInstance DNLMCHDOMOK, bool ANHLFAANEEA = false)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (DNLMCHDOMOK == null)
		{
			KGDFPLNBIPJ().SetNewItemRequest(null, GIMHPAANCDH: false, CDPAMNIPPEC: true);
			return;
		}
		MFFKBCHNMJF().SetNewItemRequest(DNLMCHDOMOK, GIMHPAANCDH: false, CDPAMNIPPEC: true);
		if (customerBase.currentRequest != null)
		{
			requesting = true;
			((Behaviour)canvasBubbles).enabled = false;
			((Transform)bubble).position = ((KGDFPLNBIPJ().characterAnimation.FCGBJEIIMBC == Direction.Right) ? leftPosition.transform.position : rightPosition.transform.position);
			((Component)bubble).gameObject.SetActive(true);
			UpdateSprite(customerBase.currentRequest, drink, drinkColor, useRequestIcon, ANHLFAANEEA);
			TableOrdersManager.instance.APCOJIEEIMA(this);
		}
		if (OnlineManager.MasterOrOffline() && Object.op_Implicit((Object)(object)MFFKBCHNMJF()) && Object.op_Implicit((Object)(object)MFFKBCHNMJF().npc.seat))
		{
			OAKLPAAFAIB().npc.seat.table.serveOrderInTable.customers.Add(MFFKBCHNMJF());
		}
		if (OnlineManager.IsMasterClient())
		{
			AHGGMHBEIOF().LJOHCJAOADD?.SendRequestTableOrder(DNLMCHDOMOK as FoodInstance, OAKLPAAFAIB().npc.seat.table.onlineTable.uniqueId);
		}
	}

	private void BDKJMPLGINI(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.GGFJGHHHEJC.customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.GGFJGHHHEJC.customerInfo.comfortMultiplier);
		float num = 1f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(1) / 100f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(61) / 100f;
			if (!roomItemRequest.JEPBBEBJEFI())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(4) / 100f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(68) / 100f;
			}
			if (Bouncer.JHLLELHBIDA)
			{
				num += (float)Bouncer.GetEmployeePerkValue(44) / 100f;
			}
		}
		num = ((WorldTime.NOAOJJLNHJJ.hour * 3600 >= 68400) ? (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(38) / 100f)) : (num + num * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(37) / 100f)));
		if (repComfortMin > 0)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(KLPEHJHCNPI((int)((float)repComfortMin * CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersReputiationMultiplier)));
	}

	public void BJMDOIHJABH()
	{
		if (Random.Range(0, 8) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 1)
			{
				roomItemRequest = list[Random.Range(0, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.CPMMBEPEJLO(-80, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 1)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GOKIDLOELKB(-160, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		MLONMPCCBIF(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}

	private void FLIAOPBLOEO(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.MNFMOEKMJKN().customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.MNFMOEKMJKN().customerInfo.comfortMultiplier);
		float num = 1897f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(1) / 1272f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(86) / 1282f;
			if (!roomItemRequest.JLCBECDECBP())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(2) / 382f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-117) / 315f;
			}
			if (Bouncer.JHLLELHBIDA)
			{
				num += (float)Bouncer.NADBCNFALNF(97) / 1299f;
			}
		}
		num = ((WorldTime.HGIBNMBJMOC().hour * -130 >= -86) ? (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(75) / 1451f)) : (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(-84, 1) / 244f)));
		if (repComfortMin > 0)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(CGMEMIEAAOO((int)((float)repComfortMin * CommonReferences.MNFMOEKMJKN().customerInfo.roomOrdersReputiationMultiplier)));
	}

	public void ECFGCGGINLK()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.LHOIHOGNBKI(roomItemRequest);
	}

	private void GCGKNBDBCCJ(Employee NAKCFGEAGHH)
	{
		int repComfortMin = CommonReferences.GGFJGHHHEJC.customerInfo.repComfortMin;
		repComfortMin += Mathf.RoundToInt((float)rentedRoomDoor.rentedRoom.zone.comfort * CommonReferences.GGFJGHHHEJC.customerInfo.comfortMultiplier);
		float num = 1337f;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num += (float)NAKCFGEAGHH.GetPerkValue(0) / 1003f;
			num -= (float)NAKCFGEAGHH.GetPerkValue(-44) / 1989f;
			if (!roomItemRequest.JEPBBEBJEFI())
			{
				num += (float)NAKCFGEAGHH.GetPerkValue(7) / 1600f;
				num -= (float)NAKCFGEAGHH.GetPerkValue(-24) / 1137f;
			}
			if (Bouncer.MFHBHANHINB())
			{
				num += (float)Bouncer.GetEmployeePerkValue(-48) / 1525f;
			}
		}
		num = ((WorldTime.NOAOJJLNHJJ.hour * 40 >= 49) ? (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(44) / 374f)) : (num + num * ((float)PerksDatabaseAccessor.NGMJIGOPGDK(-3) / 184f)));
		if (repComfortMin > 0)
		{
			repComfortMin = (int)((float)repComfortMin * num);
		}
		((MonoBehaviour)this).StartCoroutine(LDKDBGHCEAH((int)((float)repComfortMin * CommonReferences.MNFMOEKMJKN().customerInfo.roomOrdersReputiationMultiplier)));
	}

	public static void UpdateSprite(ItemInstance DNLMCHDOMOK, Image FCKDNADDBJH, Image AMGKGDINMNC, bool NLOOPHNGMLE, bool ANHLFAANEEA)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		if (NLOOPHNGMLE && DNLMCHDOMOK.LHBPOPOIFLE() is Food food && (Object)(object)food.requestIcon != (Object)null)
		{
			FCKDNADDBJH.sprite = food.requestIcon;
		}
		else if (DNLMCHDOMOK.JEPBBEBJEFI())
		{
			if (DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC() == 1318)
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.waterIcon;
			}
			else
			{
				FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.beerIcon;
			}
		}
		else
		{
			FCKDNADDBJH.sprite = CommonReferences.GGFJGHHHEJC.foodIcon;
		}
		if (ANHLFAANEEA)
		{
			((Behaviour)AMGKGDINMNC).enabled = false;
		}
		else
		{
			((Behaviour)AMGKGDINMNC).enabled = DNLMCHDOMOK.JEPBBEBJEFI();
		}
		if (DNLMCHDOMOK.JEPBBEBJEFI())
		{
			((Graphic)AMGKGDINMNC).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(DNLMCHDOMOK);
		}
	}

	public void DNACFNLGKAN()
	{
		if (Random.Range(0, 4) == 0)
		{
			List<FoodInstance> list = BarMenuManager.PJIFIOFJFBI();
			if (list.Count > 1)
			{
				roomItemRequest = list[Random.Range(0, list.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.GetItem(-4, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML();
			}
		}
		else
		{
			List<FoodInstance> allDrinksInstances = BarMenuManager.GetAllDrinksInstances();
			if (allDrinksInstances.Count > 0)
			{
				roomItemRequest = allDrinksInstances[Random.Range(0, allDrinksInstances.Count)];
			}
			else
			{
				roomItemRequest = ItemDatabaseAccessor.INJBNHPGCIJ(194, GGBBJNBBLMF: true).JMDALJBNFML();
			}
		}
		AJFGICFKLAN(roomItemRequest);
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRequestCustomerOrder(rentedRoomDoor.placeable.onlinePlaceable.uniqueId, roomItemRequest);
		}
	}
}
