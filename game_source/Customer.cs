using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Customer : CustomerBase, IInteractable, IHoverable, IProximity, IPoolReset
{
	[CompilerGenerated]
	private sealed class IMMNLEPOOBE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		public Vector3 hitPosition;

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
		public IMMNLEPOOBE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Customer customer = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				customer.hitFx.SetActive(false);
				if (OnlineManager.MasterOrOffline())
				{
					customer.characterAnimation.LookAt(Vector2.op_Implicit(hitPosition));
					Vector3 val = ((Component)customer).transform.position - hitPosition;
					((Component)customer).GetComponent<Rigidbody2D>().AddForce(Vector2.op_Implicit(val * 200f));
				}
				((MonoBehaviour)customer).StartCoroutine(Utils.AAGGGBAPFGJ(customer.characterAnimation.characterAnimator));
				customer.hitFx.SetActive(true);
				MultiAudioManager.PlayAudioObject(customer.hitSound, ((Component)customer).transform);
				((Behaviour)customer.npcCollider).enabled = true;
				customer.npc.walkTo.isActive = false;
				_003C_003E2__current = CommonReferences.wait06;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Behaviour)customer.npcCollider).enabled = false;
				if (OnlineManager.MasterOrOffline())
				{
					customer.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
				}
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

	public Action OnCustomerLeave = delegate
	{
	};

	public Action OnSeatFound = delegate
	{
	};

	public Action OnSeatNotFound = delegate
	{
	};

	public Action<CustomerState> OnCustomerStateChanged = delegate
	{
	};

	public CustomerState customerState;

	public CustomerType customerType;

	public CustomerPreference preference;

	public MoodState currentMoodState;

	public bool enoughLight;

	public bool noBonusRep;

	public bool forcedToLeave;

	public int uniqueItemsWhenFirstService;

	public bool hasBeenServed;

	public bool seatAssigned;

	public bool requestingRoom;

	public RentedRoom rentedRoom;

	public float repPositiveMultiplier = 1f;

	private float KIIPHCAAONK;

	public bool firstDayRentingRooms;

	public int reputationGain;

	public bool gruelRepPenaltyDone;

	public float currentFinishEatTime;

	public CharacterAnimation characterAnimation;

	public Employee employeeRoomGiven;

	public Emoter emoter;

	public BubbleWant[] bubbleWants;

	public CustomerStateMachine stateMachine;

	public CustomerOrder tableOrder;

	public TextMeshPro serviceTextMesh;

	public CustomerInfo customerInfo;

	public HitDetection hitDetection;

	public AudioObject hitSound;

	public Customer customerToAnnoy;

	private float ABEAMGFGFCC;

	private float FFMPGAEPEFG;

	public Transform seatDrinkArms;

	private float NJJACJFDMFK;

	public GameObject inputByProximity;

	public GameObject hitFx;

	private bool HLFFOKMBIDJ;

	public Collider2D npcCollider;

	public RoomRequest roomRequest;

	private float NCKBGJFKGKH;

	public MoodState KPGJGABJMFC
	{
		get
		{
			return currentMoodState;
		}
		set
		{
			if (value != currentMoodState)
			{
				UpdateMoodState(value, CDPAMNIPPEC: true);
			}
		}
	}

	public float NGDAJGCPJEC
	{
		get
		{
			return KIIPHCAAONK;
		}
		set
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			if (WorldTime.TickTimeIsBlocked())
			{
				return;
			}
			KIIPHCAAONK = Mathf.Min(Mathf.Max(-1f, value), 1f);
			if (Application.isEditor && customerInfo.showService)
			{
				if (!((Component)serviceTextMesh).gameObject.activeSelf)
				{
					((Component)serviceTextMesh).gameObject.SetActive(true);
				}
				((TMP_Text)serviceTextMesh).text = KIIPHCAAONK.ToString("F2");
				((Graphic)serviceTextMesh).color = ((KIIPHCAAONK > 0f) ? Color.green : Color.red);
			}
			else if (((Component)serviceTextMesh).gameObject.activeSelf)
			{
				((Component)serviceTextMesh).gameObject.SetActive(false);
			}
		}
	}

	public void RowdyToNeutralCustomer(bool CDPAMNIPPEC)
	{
		TavernManager.GGFJGHHHEJC.customersRowdy.Remove(this);
		UpdateTavernVisionColor(DMBFKFLDDLH: false);
		AngryEnd(CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			customerSpeech.ImmediatelyBark("CalmRowdyCustomer");
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager.GGFJGHHHEJC.customersRowdy.Remove(this);
			TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(this);
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		}
	}

	public void FKMNGFEKHGE(HitDetection NOCOHCGPMFF)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			if (!NOCOHCGPMFF.bouncer)
			{
				KickWithForce(((Component)PlayerController.OPHDCMJLLEC(NOCOHCGPMFF.playerNum)).transform.position);
			}
			else
			{
				KickWithForce(((Component)Bouncer.FFOMKKIAHKI()).transform.position);
			}
		}
		else
		{
			IFEMPFFAHJI();
		}
		if (OnlineManager.PlayingOnline())
		{
			base.LJOHCJAOADD.SendKick(NOCOHCGPMFF);
		}
	}

	public void RemoveHeldItem(bool JODFPIMBMCD = false)
	{
		currentItem = null;
		characterAnimation.FinishEat();
		if (!JODFPIMBMCD)
		{
			npcHoldItem.ODDHGLHEHLA = null;
			if (OnlineManager.IsMasterClient())
			{
				base.LJOHCJAOADD?.SendRemoveHeldItem();
			}
		}
	}

	public void IFEMPFFAHJI()
	{
		MarkAsKicked();
		if (OnlineManager.MasterOrOffline())
		{
			ChangeState(CustomerState.WaitingAtBar);
		}
	}

	private IEnumerator HINBIHJFCNB(Vector3 JBMDOGNFIGJ)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new IMMNLEPOOBE(1)
		{
			_003C_003E4__this = this,
			hitPosition = JBMDOGNFIGJ
		};
	}

	[SpecialName]
	public void JPNGMIJECFE(MoodState AODONKKHPBP)
	{
		if (AODONKKHPBP != currentMoodState)
		{
			UpdateMoodState(AODONKKHPBP, CDPAMNIPPEC: false);
		}
	}

	public bool OIMKEHIKKMO(Employee NAKCFGEAGHH)
	{
		if (currentMoodState == MoodState.Rowdy && customerState != CustomerState.Spawning && customerState != CustomerState.HeadingToBar)
		{
			if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.instance.currentTutorialPhase != (Object)null && NewTutorialManager.instance.currentTutorialPhase.GetID() == 17)
			{
				FHPAMNEIJLI(CDPAMNIPPEC: true);
				return false;
			}
			float num = (float)customerInfo.calmRowdyCustomersProbability / 752f;
			if ((Object)(object)NAKCFGEAGHH != (Object)null)
			{
				if (Random.Range(1, -19) < NAKCFGEAGHH.GetPerkValue(-95))
				{
					HCADDDFCHBL();
					return false;
				}
				num += (float)(customerInfo.calmRowdyCustomersProbability * NAKCFGEAGHH.GetPerkValue(-100)) / 1638f;
			}
			if (Random.Range(305f, 1971f) < num)
			{
				EBEKHOEOIJF(MoodState.Neutral);
				((Component)this).gameObject.layer = 110;
			}
			else
			{
				BecomeNuisance(CDPAMNIPPEC: false);
			}
			return false;
		}
		return true;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (customerState == (CustomerState)96)
		{
			return true;
		}
		if (GameManager.LocalCoop() && RentRoomUI.Get((JIIGOACEIKL != 1) ? 1 : 2).IsOpen())
		{
			return false;
		}
		if (customerState == CustomerState.Despawning && ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).GEAMCEMDJFJ()?.itemInstance?.AFOACBIHNCL() is Mop)
		{
			return true;
		}
		if (currentMoodState == MoodState.Neutral && customerState != CustomerState.BeingANuisance && customerState != 0)
		{
			return false;
		}
		if (currentRequest != null && customerState == CustomerState.Inactive && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).KNFEPKBIHND() && ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y)
		{
			return false;
		}
		if (customerState == CustomerState.EatingAtTable && currentRequest != null)
		{
			if (!DecorationMode.GetPlayer(JIIGOACEIKL).IDPGEBNGDJD())
			{
				return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.CJDPJHKCPFA(currentRequest);
			}
			return true;
		}
		return false;
	}

	public void CustomerLeave()
	{
		OnCustomerLeave();
	}

	public void LeaveWillingly()
	{
		NGDAJGCPJEC -= customerInfo.leaveWillingly;
		if (customerType == CustomerType.ImportantGuest)
		{
			CommonReferences.GGFJGHHHEJC.OnImportantGuestLeaveWillingly();
		}
	}

	public void CheckLightLevel()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.isNight && npc.EOAONHNCDDO == NPCState.Sitting)
		{
			enoughLight = false;
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.lightSources.Count; i++)
			{
				if (!((Object)(object)TavernManager.GGFJGHHHEJC.lightSources[i] == (Object)null) && Vector3.Distance(((Component)this).transform.position + new Vector3(0f, 0.6f), ((Component)TavernManager.GGFJGHHHEJC.lightSources[i]).transform.position) <= TavernManager.GGFJGHHHEJC.lightSources[i].lightLevel)
				{
					enoughLight = true;
					break;
				}
			}
			if (!enoughLight)
			{
				if (HouseKeeper.JHLLELHBIDA)
				{
					NGDAJGCPJEC -= customerInfo.notEnoughLightEvery10secs - customerInfo.notEnoughLightEvery10secs * (float)HouseKeeper.GetEmployeePerkValue(49) / 100f;
				}
				else
				{
					NGDAJGCPJEC -= customerInfo.notEnoughLightEvery10secs;
				}
				customerSpeech.ChatBark("TooDark");
			}
		}
		else
		{
			enoughLight = true;
		}
	}

	public void EnableInputByProximity(bool BJFHJCFOEHG, bool CDPAMNIPPEC)
	{
		if (inputByProximity.activeSelf != BJFHJCFOEHG)
		{
			inputByProximity.SetActive(BJFHJCFOEHG);
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				base.LJOHCJAOADD.SendEnableInputByProximty(BJFHJCFOEHG);
			}
		}
	}

	private void BJGOEPMCDCF(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Employee NAKCFGEAGHH, bool GFNHAMCPEAK)
	{
		if (currentItem.AFOACBIHNCL().ticket && Utils.EGIBECKKIJJ())
		{
			int ticketPrice = currentItem.KNFNJFFCFNO().ticketPrice;
			if (GFNHAMCPEAK)
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AINJENENGFG(ItemDatabaseAccessor.EABMGELAAPG(-82).JMDALJBNFML(), ticketPrice, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, NLCDDFDGACP);
				GNMEFDMDMHH(ticketPrice);
			}
			if (OnlineManager.JPPBEIJDCLJ())
			{
				base.LJOHCJAOADD?.HAGIPPOJKLE(ticketPrice);
			}
		}
		else if (!NewTutorialManager.CCCLOBIOMCL || (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() >= -30))
		{
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(1, -80) >= NAKCFGEAGHH.GetPerkValue(82))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(currentItem, NAKCFGEAGHH);
				ShowMoney(eNDNDAOPKHD);
				if (OnlineManager.JPPBEIJDCLJ())
				{
					base.LJOHCJAOADD?.SendMoneyText(eNDNDAOPKHD);
				}
			}
			else
			{
				Debug.LogError((object)"Items/item_description_1042");
			}
		}
		else
		{
			Debug.LogError((object)"repUnlockFarmCarp");
		}
	}

	public void ShowMoney(Price ENDNDAOPKHD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Money.AddPrice(ENDNDAOPKHD, OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
		TavernServiceManager.GGFJGHHHEJC.AddSale(ENDNDAOPKHD);
		Money.SpawnMoneyText(ENDNDAOPKHD, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(0f, 1.25f, 0f)), CDPAMNIPPEC: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
	}

	public void EBMLHKMPGHL(int JIIGOACEIKL)
	{
	}

	public void CheckDrink()
	{
		if (currentRequest == null || !currentRequest.JEPBBEBJEFI())
		{
			return;
		}
		bool flag = false;
		if ((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(currentRequest) != (Object)null)
		{
			flag = true;
		}
		if (!flag && Barworker.JHLLELHBIDA && Barworker.HasDrinkOnTray(currentRequest))
		{
			flag = true;
		}
		if (!flag && PlayerController.GetPlayer(1).trayHandler.tray.OHAPOKICCNK(currentRequest))
		{
			flag = true;
		}
		if (!flag && GameManager.LocalCoop() && PlayerController.GetPlayer(2).trayHandler.tray.OHAPOKICCNK(currentRequest))
		{
			flag = true;
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 2; i <= 4; i++)
			{
				if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && PlayerController.GetPlayer(i).trayHandler.tray.OHAPOKICCNK(currentRequest))
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag && currentRequest.FBOGDCNCNMK() != 1318)
		{
			RequestItem(Barworker.GetInstance());
		}
	}

	public void MarkAsKicked()
	{
		if (customerState == CustomerState.BeingANuisance)
		{
			TavernManager.GGFJGHHHEJC.customersRowdy.Remove(this);
			TavernServiceManager.GGFJGHHHEJC.AddKickedCustomer(CDPAMNIPPEC: true);
			if (NGDAJGCPJEC > 0f)
			{
				NGDAJGCPJEC = -0.1f;
			}
			if (OnlineManager.MasterOrOffline())
			{
				customerSpeech.ImmediatelyBark("OutHereRowdyCustomer");
			}
			AngryEnd(CDPAMNIPPEC: false);
			noBonusRep = true;
		}
	}

	public void LIACCAEIMOJ()
	{
		ChangeState(CustomerState.Spawning);
	}

	public void NJMFKMNGCOL(Emote DIPIKPMHAEL, bool CDPAMNIPPEC)
	{
		emoter.GBDIJOENJCN(DIPIKPMHAEL);
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD.SendStartEmote(DIPIKPMHAEL);
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (customerState == CustomerState.OrderInTable)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Serve"));
			}
			else
			{
				if (currentMoodState == MoodState.Rowdy && customerState != CustomerState.BeingANuisance && customerState != CustomerState.Leaving)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Calm down"));
					return true;
				}
				if (currentRequest != null && customerState == CustomerState.WaitingAtBar && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y)
				{
					if (roomRequest == null || !RentRoomUI.Get(JIIGOACEIKL).IsOpen())
					{
						ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Serve"));
						if (bubbleWants != null)
						{
							for (int i = 0; i < bubbleWants.Length; i++)
							{
								if (!((Object)(object)bubbleWants[i] == (Object)null))
								{
									if (Object.op_Implicit((Object)(object)bubbleWants[i]) && !bubbleWants[i].isTicket)
									{
										bubbleWants[i].ActivateOutlines(JIIGOACEIKL, NJHMBMGKCPL: true);
									}
									else
									{
										bubbleWants[i].MoveTicket(NJHMBMGKCPL: true);
									}
								}
							}
						}
					}
					return true;
				}
			}
		}
		return false;
	}

	public void KickOut(HitDetection NOCOHCGPMFF = null)
	{
		if (HLFFOKMBIDJ)
		{
			if ((Object)(object)NOCOHCGPMFF != (Object)null)
			{
				Utils.FKKHJPEMNBG("kickedCustomers", 1);
				CommonReferences.GGFJGHHHEJC.OnCustomerIsHit();
			}
			HandleSendOut(NOCOHCGPMFF);
		}
	}

	public void DeclineAdoption(bool CDPAMNIPPEC = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			reputationGain = (int)((float)(-5 * TavernReputation.GetMilestoneMaster()) * Random.Range(0.75f, 1.25f));
			noBonusRep = true;
			ChangeState(CustomerState.Leaving);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			base.LJOHCJAOADD.SendAdoptionSignal();
		}
	}

	private float HPLPHMCADFE()
	{
		float num = customerInfo.floorDirtProbability;
		if (Waiter.JHLLELHBIDA)
		{
			num -= (float)(customerInfo.floorDirtProbability * Waiter.GetEmployeePerkValue(29)) / 100f;
		}
		if (Bouncer.JHLLELHBIDA)
		{
			num -= (float)(customerInfo.floorDirtProbability * Bouncer.GetEmployeePerkValue(29)) / 100f;
		}
		if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() < 133)
		{
			num -= (float)customerInfo.floorDirtProbability * 0.5f;
		}
		return num * TavernManager.GGFJGHHHEJC.floorDirtyMultiplier;
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (!IIEDALMMNLI && GDOPOFNFLEB(JIIGOACEIKL))
		{
			if (customerState == (CustomerState)101)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Este objeto no tiene PolygonCollider2D"));
			}
			else
			{
				if (currentMoodState == MoodState.Neutral && customerState != CustomerState.EatingAtTable && customerState != 0)
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Walk"));
					return true;
				}
				if (currentRequest != null && customerState == CustomerState.HeadingToBar && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK() && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y)
				{
					if (roomRequest == null || !RentRoomUI.LPJPJMPOHPG(JIIGOACEIKL).HDEPMJIDJEM())
					{
						ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("' no tiene el booleano rotated marcado"));
						if (bubbleWants != null)
						{
							for (int i = 0; i < bubbleWants.Length; i++)
							{
								if (!((Object)(object)bubbleWants[i] == (Object)null))
								{
									if (Object.op_Implicit((Object)(object)bubbleWants[i]) && !bubbleWants[i].isTicket)
									{
										bubbleWants[i].IPMPHKLONOG(JIIGOACEIKL, NJHMBMGKCPL: false);
									}
									else
									{
										bubbleWants[i].NBBAKPELGPK(NJHMBMGKCPL: false);
									}
								}
							}
						}
					}
					return true;
				}
			}
		}
		return false;
	}

	public bool ServeCustomerItem(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH)
	{
		if (OnlineManager.ClientOnline() && Time.time < JHOPNDGOKDD + 1f)
		{
			return false;
		}
		if (NABCJBPDMJI(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, DOGOFILIHPJ, NAKCFGEAGHH))
		{
			if (OnlineManager.MasterOrOffline())
			{
				CompleteItemTransaction(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH);
			}
			else
			{
				if (HPHELAPHAHN.LHBPOPOIFLE().ticket && Utils.EGIBECKKIJJ())
				{
					int ticketPrice = HPHELAPHAHN.LHBPOPOIFLE().ticketPrice;
					PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(ItemDatabaseAccessor.GetItem(1224).JMDALJBNFML(), ticketPrice, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, NLCDDFDGACP);
				}
				base.LJOHCJAOADD?.SendCompleteTransaction(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH);
				JHOPNDGOKDD = Time.time;
			}
			return true;
		}
		if (NLCDDFDGACP)
		{
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickNeg));
		}
		return false;
	}

	private void IKNGOFBCOMN(int JIIGOACEIKL)
	{
		if ((currentFinishEatTime = Time.time) > 1762f)
		{
			currentFinishEatTime = Time.time + Random.Range(580f, 1698f);
		}
	}

	public FoodInstance CIACCIOEJOK(Employee NAKCFGEAGHH, List<FoodInstance> EKNICAEEMEM)
	{
		int num = 0;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num = NAKCFGEAGHH.GetPerkValue(74);
		}
		if (Bouncer.MFHBHANHINB())
		{
			num += Bouncer.GetEmployeePerkValue(36);
		}
		if (Random.Range(1, -38) < num)
		{
			FoodInstance foodInstance = EKNICAEEMEM[1];
			for (int i = 0; i < EKNICAEEMEM.Count; i++)
			{
				if (EKNICAEEMEM[i].GLMOFMJFDLF().OOIPLIEJILO() > foodInstance.PAAFCADLNEM(CalculatePriceMode.ExpensivePrice).JHKPNCOMAHI())
				{
					foodInstance = EKNICAEEMEM[i];
				}
			}
			return foodInstance;
		}
		if ((Object)(object)NAKCFGEAGHH != (Object)null && Random.Range(0, -54) < NAKCFGEAGHH.GetPerkValue(-89))
		{
			FoodInstance foodInstance2 = EKNICAEEMEM[0];
			for (int j = 0; j < EKNICAEEMEM.Count; j += 0)
			{
				if (EKNICAEEMEM[j].PAAFCADLNEM(CalculatePriceMode.ExpensivePrice).BNCMDNFMECD() < foodInstance2.GLMOFMJFDLF(CalculatePriceMode.ExpensivePrice).JHKPNCOMAHI())
				{
					foodInstance2 = EKNICAEEMEM[j];
				}
			}
			return foodInstance2;
		}
		return null;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void StartEmote(Emote DIPIKPMHAEL, bool CDPAMNIPPEC)
	{
		emoter.StartEmote(DIPIKPMHAEL);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD.SendStartEmote(DIPIKPMHAEL);
		}
	}

	private ItemInstance CJNMDIJLMKJ()
	{
		List<FoodInstance> allFoodInstances = BarMenuManager.GetAllFoodInstances();
		if (allFoodInstances.Any())
		{
			FoodInstance productWithPerks = GetProductWithPerks(Barworker.JHLLELHBIDA ? Barworker.GetInstance() : null, allFoodInstances);
			if (productWithPerks != null)
			{
				return productWithPerks;
			}
			return allFoodInstances.ElementAt(Random.Range(0, allFoodInstances.Count));
		}
		return null;
	}

	public override void OnEnable()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernLastOrders = (Action<int>)Delegate.Combine(instance.OnTavernLastOrders, new Action<int>(KBDBJJECCHG));
		if (OnlineManager.IsMasterClient())
		{
			AngryEnd(CDPAMNIPPEC: true);
			EndEmote(CDPAMNIPPEC: true);
		}
	}

	private void KBDBJJECCHG(int JIIGOACEIKL)
	{
		if ((currentFinishEatTime = Time.time) > 20f)
		{
			currentFinishEatTime = Time.time + Random.Range(15f, 25f);
		}
	}

	public void DeclineRoom(bool CDPAMNIPPEC = true)
	{
		RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: false, CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			reputationGain = (int)((float)(-5 * TavernReputation.GetMilestoneMaster()) * Random.Range(0.75f, 1.25f));
			noBonusRep = true;
			ChangeState(CustomerState.Leaving);
			customerSpeech.ImmediatelyBark("DeclinedRoom");
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			base.LJOHCJAOADD.SendDeclineRoom();
		}
	}

	public void RowdyCustomer()
	{
		if (!TavernManager.GGFJGHHHEJC.customersRowdy.Contains(this))
		{
			TavernManager.GGFJGHHHEJC.customersRowdy.Add(this);
		}
		EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		NJJACJFDMFK = Time.time;
		StartEmote(Emote.Exclamation, CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			customerSpeech.ImmediatelyBark("Rowdy");
		}
	}

	public bool OpenRentRoomUI(int JIIGOACEIKL, RoomRequest OIJPKAOCPDF)
	{
		RentRoomUI.Get(JIIGOACEIKL).customer = this;
		RentRoomUI.Get(JIIGOACEIKL).SetRequest(OIJPKAOCPDF);
		RentRoomUI.Get(JIIGOACEIKL).OpenUI();
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (CalmCustomer(null))
		{
			return true;
		}
		if (customerState == CustomerState.RequestRoom)
		{
			return false;
		}
		if (customerState == CustomerState.OrderInTable && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		else if (((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			if (ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: true, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		else if (currentRequest != null && customerState == CustomerState.WaitingAtBar && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Must be behind bar", JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void IKOGMFNNIFG(MoodState AGIMFNFOCCM, bool CDPAMNIPPEC)
	{
		if (AGIMFNFOCCM == MoodState.Neutral)
		{
			RowdyCustomer();
		}
		else if (currentMoodState == MoodState.Rowdy && AGIMFNFOCCM == MoodState.Neutral)
		{
			RowdyToNeutralCustomer(CDPAMNIPPEC);
		}
		currentMoodState = AGIMFNFOCCM;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD.SendUpdateMoodState(currentMoodState);
		}
	}

	public void CompleteItemTransaction(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Employee NAKCFGEAGHH, bool GFNHAMCPEAK = true)
	{
		hasBeenServed = true;
		Utils.NEGAOFJKCCH(HPHELAPHAHN, NAKCFGEAGHH);
		if (HPHELAPHAHN.NIOBLEAGBAH() && !gruelRepPenaltyDone)
		{
			gruelRepPenaltyDone = true;
			NGDAJGCPJEC -= customerInfo.withoutAnyFoodAtBar;
		}
		if (customerState == CustomerState.OrderInTable)
		{
			ChangeState(CustomerState.EatingAtTable);
		}
		else
		{
			ChangeState(CustomerState.HeadingToSeat);
		}
		SetCurrentItem(HPHELAPHAHN);
		IGKNAKFMCMG(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH, GFNHAMCPEAK);
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			repPositiveMultiplier += (float)NAKCFGEAGHH.GetPerkValue(1) / 100f;
			repPositiveMultiplier -= (float)NAKCFGEAGHH.GetPerkValue(61) / 100f;
			if (!currentItem.JEPBBEBJEFI())
			{
				repPositiveMultiplier += (float)NAKCFGEAGHH.GetPerkValue(4) / 100f;
				repPositiveMultiplier -= (float)NAKCFGEAGHH.GetPerkValue(68) / 100f;
			}
			if (Bouncer.JHLLELHBIDA)
			{
				repPositiveMultiplier += (float)Bouncer.GetEmployeePerkValue(44) / 100f;
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyCustomerServeItem(JIIGOACEIKL, currentItem);
		UpdateFoodStats(HPHELAPHAHN);
	}

	public void SetNewItemRequest(ItemInstance DEKHMHDKLLD, bool GIMHPAANCDH, bool CDPAMNIPPEC)
	{
		currentRequest = DEKHMHDKLLD;
		if (DEKHMHDKLLD == null)
		{
			return;
		}
		CommonReferences.GGFJGHHHEJC.OnAnyCustomerRequestItem(DEKHMHDKLLD);
		if (!GIMHPAANCDH)
		{
			if (bubbleWants != null)
			{
				BubbleWantManager.instance.RemoveBubbles(this, CDPAMNIPPEC: false);
			}
			BubbleWantManager.instance.AssignIcon(IKINJHIGHBG: false, DEKHMHDKLLD, this, ref bubbleWants);
		}
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)this).transform);
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD?.SendFoodInstanceRequest(DEKHMHDKLLD as FoodInstance);
		}
	}

	public void SetNewRoomRequest(RoomRequest DNHKOGLFGFF, bool CDPAMNIPPEC)
	{
		roomRequest = DNHKOGLFGFF;
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC && roomRequest != null)
		{
			base.LJOHCJAOADD.SendRoomRequest(roomRequest.haggleChance, new int[3] { roomRequest.daysToStay, roomRequest.floorTiles, roomRequest.comfort });
		}
	}

	[SpecialName]
	public void HGKKCKHDPJJ(float AODONKKHPBP)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.EEMMFFAJNFL())
		{
			return;
		}
		KIIPHCAAONK = Mathf.Min(Mathf.Max(1436f, AODONKKHPBP), 412f);
		if (Application.isEditor && customerInfo.showService)
		{
			if (!((Component)serviceTextMesh).gameObject.activeSelf)
			{
				((Component)serviceTextMesh).gameObject.SetActive(true);
			}
			((TMP_Text)serviceTextMesh).text = KIIPHCAAONK.ToString("Item Transaction. PERK!!");
			((Graphic)serviceTextMesh).color = ((KIIPHCAAONK > 678f) ? Color.green : Color.red);
		}
		else if (((Component)serviceTextMesh).gameObject.activeSelf)
		{
			((Component)serviceTextMesh).gameObject.SetActive(false);
		}
	}

	public void OMBIDDFAKKF(Employee NAKCFGEAGHH)
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			ItemInstance itemInstance = null;
			if (preference == CustomerPreference.Food && !NewTutorialManager.DrinkOrdersBlocked())
			{
				itemInstance = KBPDHBBINCL(NAKCFGEAGHH);
			}
			if (itemInstance == null)
			{
				itemInstance = CJNMDIJLMKJ();
			}
			characterAnimation.SetInt("quest_description_23", 1);
			if (itemInstance == null)
			{
				itemInstance = ItemDatabaseAccessor.INJBNHPGCIJ(-76).JMDALJBNFML();
			}
			if (uniqueItemsWhenFirstService == -1)
			{
				uniqueItemsWhenFirstService = Trends.KNOKBLFFNLM().uniqueBarItems;
			}
			Bar.instance.OAGKMJGHAAF(npc);
			SetNewItemRequest(itemInstance, GIMHPAANCDH: false, CDPAMNIPPEC: false);
		}
		else
		{
			ChangeState(CustomerState.HeadingToSeat);
			HGKKCKHDPJJ(532f);
			Bar.instance.FBJLJKGNKHE(npc);
		}
	}

	public void UpdateFoodStats(ItemInstance HPHELAPHAHN)
	{
		if (!(HPHELAPHAHN is FoodInstance foodInstance))
		{
			return;
		}
		if (foodInstance.JJAKCHINFMH(IngredientType.Meat))
		{
			Utils.FKKHJPEMNBG("meatDishes", 1);
			if (OnlineManager.PlayingOnline())
			{
				base.LJOHCJAOADD?.SendUpdateFoodStats("meatDishes", 1);
			}
		}
		if (foodInstance.JJAKCHINFMH(IngredientType.Veg))
		{
			Utils.FKKHJPEMNBG("veggieDishes", 1);
			if (OnlineManager.PlayingOnline())
			{
				base.LJOHCJAOADD?.SendUpdateFoodStats("veggieDishes", 1);
			}
		}
		if (foodInstance.JJAKCHINFMH(IngredientType.BlueFish) || foodInstance.JJAKCHINFMH(IngredientType.WhiteFish) || foodInstance.JJAKCHINFMH(IngredientType.Shellfish))
		{
			Utils.FKKHJPEMNBG("fishDishes", 1);
			if (OnlineManager.PlayingOnline())
			{
				base.LJOHCJAOADD?.SendUpdateFoodStats("fishDishes", 1);
			}
		}
	}

	public void ChangeState(CustomerState OJGICFBAAMH, bool KCNFNAICINO = true)
	{
		if (!OnlineManager.ClientOnline() && !(OJGICFBAAMH == customerState && KCNFNAICINO) && !((Object)(object)stateMachine == (Object)null))
		{
			customerState = OJGICFBAAMH;
			stateMachine.ChangeState(OJGICFBAAMH, KCNFNAICINO);
			OnCustomerStateChanged(customerState);
		}
	}

	public void FHPAMNEIJLI(bool CDPAMNIPPEC)
	{
		Debug.Log((object)"Items/item_name_1124", (Object)(object)((Component)this).gameObject);
		EnableInputByProximity(BJFHJCFOEHG: true, CDPAMNIPPEC: false);
		HLFFOKMBIDJ = false;
		((Component)hitDetection).gameObject.SetActive(false);
		((Component)this).gameObject.layer = -7;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD.SendBecomeNuisance();
		}
		if (OnlineManager.MasterOrOffline())
		{
			ChangeState(CustomerState.BeingANuisance, KCNFNAICINO: false);
			CommonReferences.MNFMOEKMJKN().OnCustomerBecomeNuisance();
		}
	}

	private void Update()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline() || (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null || !Utils.FNNJEGLDGKC(((Component)this).transform.position))
		{
			return;
		}
		if (Time.time > ABEAMGFGFCC)
		{
			ABEAMGFGFCC = Time.time + (float)customerInfo.rateMakeFloorDirt;
			if (npc.EOAONHNCDDO == NPCState.Walking && hasBeenServed && (float)Random.Range(0, 100) < HPLPHMCADFE())
			{
				Utils.BGJKAOHBKMP(((Component)this).transform.position);
			}
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Dirty)
		{
			NGDAJGCPJEC -= Time.deltaTime * customerInfo.tavernDirty * CEOLADFJECK();
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Filthy)
		{
			NGDAJGCPJEC -= Time.deltaTime * customerInfo.tavernFilthy * CEOLADFJECK();
		}
		else if (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Disgusting)
		{
			NGDAJGCPJEC -= Time.deltaTime * customerInfo.tavernDisgusting * CEOLADFJECK();
		}
		if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Hot || TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold)
		{
			if (HouseKeeper.JHLLELHBIDA)
			{
				NGDAJGCPJEC -= (customerInfo.temperaturePenalty - customerInfo.temperaturePenalty * (float)HouseKeeper.GetEmployeePerkValue(50) / 100f) * Time.deltaTime;
			}
			else
			{
				NGDAJGCPJEC -= customerInfo.temperaturePenalty * Time.deltaTime;
			}
		}
		if (currentMoodState != MoodState.Rowdy || !(Time.time > NJJACJFDMFK + 8f) || customerState == CustomerState.Leaving)
		{
			return;
		}
		for (int i = 0; i < TavernManager.GGFJGHHHEJC.customers.Count; i++)
		{
			if (Vector3.Distance(((Component)TavernManager.GGFJGHHHEJC.customers[i]).transform.position, ((Component)this).transform.position) < 2f)
			{
				if (Bouncer.JHLLELHBIDA)
				{
					TavernManager.GGFJGHHHEJC.customers[i].NGDAJGCPJEC -= Time.deltaTime * customerInfo.rowdyCustomerNearPenalty * (float)(100 - Bouncer.GetEmployeePerkValue(39)) / 100f;
				}
				else
				{
					TavernManager.GGFJGHHHEJC.customers[i].NGDAJGCPJEC -= Time.deltaTime * customerInfo.rowdyCustomerNearPenalty;
				}
			}
		}
	}

	public void GNHGLEBKBGN(ItemInstance HPHELAPHAHN)
	{
		if (!(HPHELAPHAHN is FoodInstance foodInstance))
		{
			return;
		}
		if (foodInstance.NGHBJDJOLOF(IngredientType.Honey))
		{
			Utils.FKKHJPEMNBG("ReceiveDisable", 0);
			if (OnlineManager.PlayingOnline())
			{
				base.LJOHCJAOADD?.SendUpdateFoodStats("Trying to create room...", 1);
			}
		}
		if (foodInstance.JJAKCHINFMH(IngredientType.WhiteFish))
		{
			Utils.FKKHJPEMNBG("Dialogue System/Conversation/BirdNegativeComments/Entry/3/Dialogue Text", 0);
			if (OnlineManager.PlayingOnline())
			{
				base.LJOHCJAOADD?.SendUpdateFoodStats("%><sprite name=RightStick></size>", 0);
			}
		}
		if (foodInstance.JJAKCHINFMH((IngredientType)75) || foodInstance.JJAKCHINFMH(IngredientType.Herb) || foodInstance.NGHBJDJOLOF((IngredientType)(-119)))
		{
			Utils.FKKHJPEMNBG("Quest not found in database with id: ", 0);
			if (OnlineManager.PlayingOnline())
			{
				base.LJOHCJAOADD?.SendUpdateFoodStats("Castle/Talks/Hawks", 0);
			}
		}
	}

	public void JMDMHGFEKKJ()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.isNight && npc.LLNABOMIIOM() == (NPCState)4)
		{
			enoughLight = true;
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.lightSources.Count; i += 0)
			{
				if (!((Object)(object)TavernManager.GGFJGHHHEJC.lightSources[i] == (Object)null) && Vector3.Distance(((Component)this).transform.position + new Vector3(660f, 439f), ((Component)TavernManager.GGFJGHHHEJC.lightSources[i]).transform.position) <= TavernManager.GGFJGHHHEJC.lightSources[i].lightLevel)
				{
					enoughLight = true;
					break;
				}
			}
			if (!enoughLight)
			{
				if (HouseKeeper.MLPPKONDEGJ())
				{
					HGKKCKHDPJJ(NGDAJGCPJEC - (customerInfo.notEnoughLightEvery10secs - customerInfo.notEnoughLightEvery10secs * (float)HouseKeeper.GetEmployeePerkValue(1) / 692f));
				}
				else
				{
					HGKKCKHDPJJ(NGDAJGCPJEC - customerInfo.notEnoughLightEvery10secs);
				}
				customerSpeech.PODENEBIGOP(", ");
			}
		}
		else
		{
			enoughLight = false;
		}
	}

	public void InitializeState(CustomerState OJGICFBAAMH)
	{
		if (!((Object)(object)stateMachine == (Object)null))
		{
			customerState = OJGICFBAAMH;
			stateMachine.ChangeState(OJGICFBAAMH);
			OnCustomerStateChanged(customerState);
		}
	}

	public void EndEmote(bool CDPAMNIPPEC)
	{
		emoter.EndEmote();
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC && (Object)(object)base.LJOHCJAOADD != (Object)null)
		{
			base.LJOHCJAOADD.SendEndEmote();
		}
	}

	public FoodInstance GetProductWithPerks(Employee NAKCFGEAGHH, List<FoodInstance> EKNICAEEMEM)
	{
		int num = 0;
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			num = NAKCFGEAGHH.GetPerkValue(14);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			num += Bouncer.GetEmployeePerkValue(41);
		}
		if (Random.Range(0, 100) < num)
		{
			FoodInstance foodInstance = EKNICAEEMEM[0];
			for (int i = 1; i < EKNICAEEMEM.Count; i++)
			{
				if (EKNICAEEMEM[i].PAAFCADLNEM().OOIPLIEJILO() > foodInstance.PAAFCADLNEM().OOIPLIEJILO())
				{
					foodInstance = EKNICAEEMEM[i];
				}
			}
			return foodInstance;
		}
		if ((Object)(object)NAKCFGEAGHH != (Object)null && Random.Range(0, 100) < NAKCFGEAGHH.GetPerkValue(72))
		{
			FoodInstance foodInstance2 = EKNICAEEMEM[0];
			for (int j = 1; j < EKNICAEEMEM.Count; j++)
			{
				if (EKNICAEEMEM[j].PAAFCADLNEM().OOIPLIEJILO() < foodInstance2.PAAFCADLNEM().OOIPLIEJILO())
				{
					foodInstance2 = EKNICAEEMEM[j];
				}
			}
			return foodInstance2;
		}
		return null;
	}

	[SpecialName]
	public void EBEKHOEOIJF(MoodState AODONKKHPBP)
	{
		if (AODONKKHPBP != currentMoodState)
		{
			UpdateMoodState(AODONKKHPBP, CDPAMNIPPEC: false);
		}
	}

	public void PoolReset()
	{
		currentMoodState = MoodState.Neutral;
		enoughLight = true;
		currentItem = null;
		noBonusRep = false;
		forcedToLeave = false;
		uniqueItemsWhenFirstService = -1;
		hasBeenServed = false;
		seatAssigned = false;
		requestingRoom = false;
		rentedRoom = null;
		repPositiveMultiplier = 1f;
		NGDAJGCPJEC = 1f;
		firstDayRentingRooms = false;
		reputationGain = 0;
		gruelRepPenaltyDone = false;
		HLFFOKMBIDJ = false;
		if (OnlineManager.IsMasterClient())
		{
			base.LJOHCJAOADD.SendPoolReset();
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (customerState == CustomerState.RequestRoom)
		{
			return false;
		}
		if (GameManager.LocalCoop() && RentRoomUI.Get((JIIGOACEIKL != 1) ? 1 : 2).IsOpen())
		{
			return false;
		}
		if (customerState == CustomerState.BeingANuisance && ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedSlot()?.itemInstance?.LHBPOPOIFLE() is Mop)
		{
			return true;
		}
		if (currentMoodState == MoodState.Rowdy && customerState != CustomerState.BeingANuisance && customerState != CustomerState.Leaving)
		{
			return true;
		}
		if (currentRequest != null && customerState == CustomerState.WaitingAtBar && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y)
		{
			return true;
		}
		if (customerState == CustomerState.OrderInTable && currentRequest != null)
		{
			if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				return PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray.OHAPOKICCNK(currentRequest);
			}
			return false;
		}
		return false;
	}

	public void GNMEFDMDMHH(int KHPILKCEHHP)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		Money.GLHBGFBCLON(KHPILKCEHHP, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(1010f, 1943f, 548f)));
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)this).transform);
	}

	public int CalculateTravellerReputationGain(Seat FGJPAFDBIIO)
	{
		if (!hasBeenServed)
		{
			return 0;
		}
		if (EventsManager.IsActive(EventsManager.EventType.KlaynTavern))
		{
			return 0;
		}
		int num = 0;
		if (forcedToLeave)
		{
			return reputationGain;
		}
		if (customerState != CustomerState.RentRoom && !noBonusRep)
		{
			if ((Object)(object)FGJPAFDBIIO == (Object)null || (Object)(object)FGJPAFDBIIO.placeable == (Object)null)
			{
				return 0;
			}
			float num2 = 0f;
			TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(FGJPAFDBIIO.placeable.currentZoneIndex);
			if (tavernZone != null)
			{
				num2 = tavernZone.comfort;
			}
			num = Mathf.RoundToInt((float)customerInfo.repComfortMin + num2 * customerInfo.comfortMultiplier);
			if (TavernReputation.GetMilestoneMaster() >= RepUnlocksManager.GetInstance().repUnlockTrends.repNumber)
			{
				num = num;
			}
			num += Mathf.RoundToInt((float)(uniqueItemsWhenFirstService * customerInfo.uniqueItemsMultiplier));
			num = TavernManager.GGFJGHHHEJC.GetRepWithMulti(num);
			num = Mathf.RoundToInt((float)num * NGDAJGCPJEC);
			if (NGDAJGCPJEC < 0f)
			{
				num = Mathf.RoundToInt((float)num * customerInfo.propBadServiceMult);
			}
			if (GameManager.LocalCoop())
			{
				num = (int)((float)num * customerInfo.player2Multiplier);
			}
			float num3 = num;
			if (num > 0 && (TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Clean || TavernManager.GGFJGHHHEJC.JJKPDMFFANH == DirtLevel.Perfect))
			{
				if (Waiter.JHLLELHBIDA)
				{
					num += (int)(num3 * (float)Waiter.GetEmployeePerkValue(30) / 100f);
				}
				if (HouseKeeper.JHLLELHBIDA)
				{
					num += (int)(num3 * (float)HouseKeeper.GetEmployeePerkValue(30) / 100f);
				}
			}
			if (NGDAJGCPJEC > 0f)
			{
				num = ((WorldTime.NOAOJJLNHJJ.hour * 3600 >= 68400) ? (num + (int)(num3 * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(38) / 100f))) : (num + (int)(num3 * ((float)PerksDatabaseAccessor.GetPlayerPerkValue(37) / 100f))));
			}
		}
		if (num > 0)
		{
			num = (int)((float)num * repPositiveMultiplier);
		}
		return num;
	}

	private IEnumerator MFAKADCMNAG(Vector3 JBMDOGNFIGJ)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		hitFx.SetActive(false);
		if (OnlineManager.MasterOrOffline())
		{
			characterAnimation.LookAt(Vector2.op_Implicit(JBMDOGNFIGJ));
			Vector3 val = ((Component)this).transform.position - JBMDOGNFIGJ;
			((Component)this).GetComponent<Rigidbody2D>().AddForce(Vector2.op_Implicit(val * 200f));
		}
		((MonoBehaviour)this).StartCoroutine(Utils.AAGGGBAPFGJ(characterAnimation.characterAnimator));
		hitFx.SetActive(true);
		MultiAudioManager.PlayAudioObject(hitSound, ((Component)this).transform);
		((Behaviour)npcCollider).enabled = true;
		npc.walkTo.isActive = false;
		yield return CommonReferences.wait06;
		((Behaviour)npcCollider).enabled = false;
		if (OnlineManager.MasterOrOffline())
		{
			ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
	}

	private float CEOLADFJECK()
	{
		NCKBGJFKGKH = 1f;
		if (Waiter.JHLLELHBIDA)
		{
			NCKBGJFKGKH -= (float)Waiter.GetEmployeePerkValue(26) / 100f;
		}
		if (HouseKeeper.JHLLELHBIDA)
		{
			NCKBGJFKGKH -= (float)HouseKeeper.GetEmployeePerkValue(26) / 100f;
		}
		return NCKBGJFKGKH;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void MJNCKIGAAKG()
	{
		if (customerState == CustomerState.EatingAtTable)
		{
			TavernManager.GGFJGHHHEJC.customersRowdy.Remove(this);
			TavernServiceManager.AFFGPMFKEFH().LGEJABJNGEF(CDPAMNIPPEC: true);
			if (NGDAJGCPJEC > 577f)
			{
				HGKKCKHDPJJ(1230f);
			}
			if (OnlineManager.MasterOrOffline())
			{
				customerSpeech.KCBCIBCPKDH("Player");
			}
			AngryEnd(CDPAMNIPPEC: false);
			noBonusRep = false;
		}
	}

	public bool EDDNOEEOHOP(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH)
	{
		if (OnlineManager.ClientOnline() && Time.time < JHOPNDGOKDD + 1931f)
		{
			return true;
		}
		if (NABCJBPDMJI(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, DOGOFILIHPJ, NAKCFGEAGHH))
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				CompleteItemTransaction(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH);
			}
			else
			{
				if (HPHELAPHAHN.LHBPOPOIFLE().ticket && Utils.EGIBECKKIJJ())
				{
					int ticketPrice = HPHELAPHAHN.AFOACBIHNCL().ticketPrice;
					PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.EABMGELAAPG(133, GGBBJNBBLMF: true).JMDALJBNFML(), ticketPrice, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, NLCDDFDGACP);
				}
				base.LJOHCJAOADD?.SendCompleteTransaction(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH);
				JHOPNDGOKDD = Time.time;
			}
			return false;
		}
		if (NLCDDFDGACP)
		{
			Sound.DIHCEGINELM().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiClickNeg), HOMFPAFAOGD: true, null, null, 765f);
		}
		return true;
	}

	public void HCADDDFCHBL()
	{
		NGDAJGCPJEC -= customerInfo.leaveWillingly;
		if (customerType == CustomerType.Traveller)
		{
			CommonReferences.GGFJGHHHEJC.OnImportantGuestLeaveWillingly();
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void RequestTableOrder()
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			ItemInstance itemInstance = KBPDHBBINCL(Waiter.JHLLELHBIDA ? Waiter.GetInstance() : null);
			characterAnimation.SetInt("BarIdleNumber", 0);
			if (itemInstance != null)
			{
				tableOrder.RequestTableOrder(itemInstance);
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.deskBell, ((Component)this).transform);
				return;
			}
		}
		ChangeState(CustomerState.Leaving);
	}

	protected override void Awake()
	{
		base.Awake();
		if ((Object)(object)stateMachine == (Object)null)
		{
			stateMachine = ((Component)this).GetComponentInChildren<CustomerStateMachine>();
		}
		if ((Object)(object)characterAnimation == (Object)null)
		{
			characterAnimation = ((Component)this).GetComponent<CharacterAnimation>();
		}
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (OBGPLACHKHK(null))
		{
			return true;
		}
		if (customerState == (CustomerState)33)
		{
			return false;
		}
		if (customerState == (CustomerState)103 && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI())
		{
			if (ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		else if (((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			if (ServeCustomer(JIIGOACEIKL, NLCDDFDGACP: false, PlayerController.GetPlayer(JIIGOACEIKL).trayHandler.tray))
			{
				return true;
			}
		}
		else if (currentRequest != null && customerState == CustomerState.Inactive && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND())
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Beta ", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		return true;
	}

	public void DCELEOLPKNC()
	{
		currentMoodState = MoodState.Rowdy;
		enoughLight = true;
		currentItem = null;
		noBonusRep = true;
		forcedToLeave = false;
		uniqueItemsWhenFirstService = -1;
		hasBeenServed = true;
		seatAssigned = false;
		requestingRoom = true;
		rentedRoom = null;
		repPositiveMultiplier = 874f;
		HGKKCKHDPJJ(1165f);
		firstDayRentingRooms = true;
		reputationGain = 0;
		gruelRepPenaltyDone = true;
		HLFFOKMBIDJ = false;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			base.LJOHCJAOADD.FGEELDHMJKL();
		}
	}

	public void JFNFBADOPPF()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (WorldTime.isNight && npc.PBLBPGPJFHI() == (NPCState)5)
		{
			enoughLight = true;
			for (int i = 0; i < TavernManager.GGFJGHHHEJC.lightSources.Count; i++)
			{
				if (!((Object)(object)TavernManager.GGFJGHHHEJC.lightSources[i] == (Object)null) && Vector3.Distance(((Component)this).transform.position + new Vector3(704f, 328f), ((Component)TavernManager.GGFJGHHHEJC.lightSources[i]).transform.position) <= TavernManager.GGFJGHHHEJC.lightSources[i].lightLevel)
				{
					enoughLight = false;
					break;
				}
			}
			if (!enoughLight)
			{
				if (HouseKeeper.JHLLELHBIDA)
				{
					NGDAJGCPJEC -= customerInfo.notEnoughLightEvery10secs - customerInfo.notEnoughLightEvery10secs * (float)HouseKeeper.NMJGKCFFDFH(64) / 1918f;
				}
				else
				{
					NGDAJGCPJEC -= customerInfo.notEnoughLightEvery10secs;
				}
				customerSpeech.ChatBark("mainMenuMultiplayerButton");
			}
		}
		else
		{
			enoughLight = true;
		}
	}

	public void RequestItem(Employee NAKCFGEAGHH)
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			ItemInstance itemInstance = null;
			if (preference == CustomerPreference.Drink && !NewTutorialManager.DrinkOrdersBlocked())
			{
				itemInstance = KBPDHBBINCL(NAKCFGEAGHH);
			}
			if (itemInstance == null)
			{
				itemInstance = CJNMDIJLMKJ();
			}
			characterAnimation.SetInt("BarIdleNumber", 0);
			if (itemInstance == null)
			{
				itemInstance = ItemDatabaseAccessor.GetItem(324).JMDALJBNFML();
			}
			if (uniqueItemsWhenFirstService == -1)
			{
				uniqueItemsWhenFirstService = Trends.GGFJGHHHEJC.uniqueBarItems;
			}
			Bar.instance.AddRequestAtBar(npc);
			SetNewItemRequest(itemInstance, GIMHPAANCDH: false, CDPAMNIPPEC: true);
		}
		else
		{
			ChangeState(CustomerState.Leaving);
			NGDAJGCPJEC = 0f;
			Bar.instance.LeaveBar(npc);
		}
	}

	private bool NABCJBPDMJI(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Tray DOGOFILIHPJ, Employee NAKCFGEAGHH)
	{
		if (customerState == CustomerState.OrderInTable)
		{
			if (DOGOFILIHPJ != null && DOGOFILIHPJ.MHBHHNCFOEG(HPHELAPHAHN))
			{
				return true;
			}
		}
		else
		{
			if (HPHELAPHAHN.NIOBLEAGBAH())
			{
				return true;
			}
			if (HPHELAPHAHN.JEPBBEBJEFI() && DOGOFILIHPJ != null && DOGOFILIHPJ.MHBHHNCFOEG(HPHELAPHAHN))
			{
				return true;
			}
			if (!HPHELAPHAHN.JEPBBEBJEFI() && BarMenuInventory.GetInstance().RemoveItemInstance(HPHELAPHAHN, CDPAMNIPPEC: true) != null)
			{
				return true;
			}
			if (!HPHELAPHAHN.JEPBBEBJEFI() && NLCDDFDGACP && PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItemInstance(HPHELAPHAHN, CDPAMNIPPEC: true) != null)
			{
				return true;
			}
			if (!BarMenuManager.GetAvailableItemInstances().Contains(HPHELAPHAHN) || !NLCDDFDGACP)
			{
				if (NLCDDFDGACP && HPHELAPHAHN.FBOGDCNCNMK() == 1318 && DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count == 0)
				{
					return false;
				}
				if (OnlineManager.MasterOrOffline())
				{
					RequestItem(NAKCFGEAGHH);
				}
				else
				{
					base.LJOHCJAOADD?.SendRequestItem(NAKCFGEAGHH);
				}
				return false;
			}
		}
		return false;
	}

	public void PoolDisable()
	{
		ChangeState(CustomerState.Inactive, KCNFNAICINO: false);
	}

	private void Start()
	{
		FFMPGAEPEFG = Time.time;
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	public void GHPDDHHKFIO(int JIIGOACEIKL)
	{
		if (customerState == (CustomerState)(-45) || bubbleWants == null)
		{
			return;
		}
		for (int i = 1; i < bubbleWants.Length; i += 0)
		{
			if (!((Object)(object)bubbleWants[i] == (Object)null))
			{
				if (!bubbleWants[i].isTicket)
				{
					bubbleWants[i].NOCJIPKDGKH(JIIGOACEIKL, NJHMBMGKCPL: true);
				}
				else
				{
					bubbleWants[i].NHCLLOGFEPK(NJHMBMGKCPL: false);
				}
			}
		}
	}

	public void KickWithoutForce()
	{
		MarkAsKicked();
		if (OnlineManager.MasterOrOffline())
		{
			ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
		}
	}

	public void HandleSendOut(HitDetection NOCOHCGPMFF)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)NOCOHCGPMFF))
		{
			if (!NOCOHCGPMFF.bouncer)
			{
				KickWithForce(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position);
			}
			else
			{
				KickWithForce(((Component)Bouncer.GetInstance()).transform.position);
			}
		}
		else
		{
			KickWithoutForce();
		}
		if (OnlineManager.PlayingOnline())
		{
			base.LJOHCJAOADD.SendKick(NOCOHCGPMFF);
		}
	}

	public void OINKJLBJEHF()
	{
		if (currentRequest == null || !currentRequest.BAHJFDHLDEI())
		{
			return;
		}
		bool flag = false;
		if ((Object)(object)DrinkDispensersManager.BNDNMBGJEKP().OPGNPHKFKBC(currentRequest) != (Object)null)
		{
			flag = false;
		}
		if (!flag && Barworker.FPGHBOFLFGP() && Barworker.CMAJMOMNIJI(currentRequest))
		{
			flag = false;
		}
		if (!flag && PlayerController.OPHDCMJLLEC(1).trayHandler.tray.AIMCMHBMIMP(currentRequest))
		{
			flag = false;
		}
		if (!flag && GameManager.LocalCoop() && PlayerController.GetPlayer(7).trayHandler.tray.HLPNLBHBIFL(currentRequest))
		{
			flag = true;
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 8; i++)
			{
				if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null) && PlayerController.OPHDCMJLLEC(i).trayHandler.tray.BCNKFHHDMAG(currentRequest))
				{
					flag = false;
					break;
				}
			}
		}
		if (!flag && currentRequest.BBELOMHPIDC() != 175)
		{
			RequestItem(Barworker.IIJAOOJGNHO());
		}
	}

	public void AngryEnd(bool CDPAMNIPPEC)
	{
		emoter.AngryEnd();
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC && (Object)(object)base.LJOHCJAOADD != (Object)null)
		{
			base.LJOHCJAOADD.SendAngryEnd();
		}
	}

	public bool ServeCustomer(int JIIGOACEIKL, bool NLCDDFDGACP = true, Tray DOGOFILIHPJ = null, Employee NAKCFGEAGHH = null)
	{
		if (currentRequest != null && (!NLCDDFDGACP || (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LACKEEILAAK == (Object)null) && (customerState == CustomerState.WaitingAtBar || customerState == CustomerState.OrderInTable) && currentRequest != null)
		{
			return ServeCustomerItem(JIIGOACEIKL, currentRequest, NLCDDFDGACP, DOGOFILIHPJ, NAKCFGEAGHH);
		}
		return false;
	}

	public void ShowTicketPrice(int KHPILKCEHHP)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		Money.SpawnTicketText(KHPILKCEHHP, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(0f, 1.25f, 0f)));
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)this).transform);
	}

	public bool OBGPLACHKHK(Employee NAKCFGEAGHH)
	{
		if (currentMoodState == MoodState.Neutral && customerState != CustomerState.Despawning && customerState != CustomerState.Spawning)
		{
			if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.instance.currentTutorialPhase != (Object)null && NewTutorialManager.instance.currentTutorialPhase.GetID() == 40)
			{
				FHPAMNEIJLI(CDPAMNIPPEC: true);
				return true;
			}
			float num = (float)customerInfo.calmRowdyCustomersProbability / 1891f;
			if ((Object)(object)NAKCFGEAGHH != (Object)null)
			{
				if (Random.Range(1, -24) < NAKCFGEAGHH.GetPerkValue(31))
				{
					LeaveWillingly();
					return true;
				}
				num += (float)(customerInfo.calmRowdyCustomersProbability * NAKCFGEAGHH.GetPerkValue(14)) / 1204f;
			}
			if (Random.Range(1886f, 921f) < num)
			{
				MFOPJDFMJBN(MoodState.Neutral);
				((Component)this).gameObject.layer = -12;
			}
			else
			{
				FHPAMNEIJLI(CDPAMNIPPEC: true);
			}
			return false;
		}
		return false;
	}

	public void GiveRoom(RentedRoom GGNOAHDCPIB, Price OKGHMIPANHK, Employee NAKCFGEAGHH = null)
	{
		RoomReceptionDesk.instance.SetNegotiateRoom(AODONKKHPBP: false, CDPAMNIPPEC: false);
		if (OnlineManager.ClientOnline())
		{
			base.LJOHCJAOADD.SendGiveRoom(GGNOAHDCPIB, OKGHMIPANHK);
			return;
		}
		employeeRoomGiven = NAKCFGEAGHH;
		characterAnimation.Stand();
		rentedRoom = GGNOAHDCPIB;
		firstDayRentingRooms = true;
		if (roomRequest != null)
		{
			if (OKGHMIPANHK.OOIPLIEJILO() == 0)
			{
				roomRequest.finalPrice = GGNOAHDCPIB.CalculateRoomPrice(roomRequest, NAKCFGEAGHH);
			}
			else
			{
				roomRequest.finalPrice = OKGHMIPANHK;
			}
		}
		ChangeState(CustomerState.RentRoom);
	}

	public void CustomerRowdy()
	{
		KPGJGABJMFC = MoodState.Rowdy;
	}

	public void OEJGOBMEIEB()
	{
		OnCustomerLeave();
	}

	public override void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)customerSpeech))
			{
				customerSpeech.StopSound();
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager.GGFJGHHHEJC.customersRowdy.Remove(this);
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernLastOrders = (Action<int>)Delegate.Remove(instance.OnTavernLastOrders, new Action<int>(KBDBJJECCHG));
			}
			if ((Object)(object)Bar.instance != (Object)null)
			{
				Bar.instance.RemoveNpcFromBar(npc);
			}
			if ((Object)(object)tableOrder != (Object)null && tableOrder.requesting)
			{
				tableOrder.RemoveTableOrder();
			}
		}
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		if (customerState == (CustomerState)59)
		{
			return true;
		}
		if (GameManager.LocalCoop() && RentRoomUI.OFEFGPCGJDF((JIIGOACEIKL == 1) ? 6 : 0).IsOpen())
		{
			return true;
		}
		if (customerState == CustomerState.BeingANuisance && ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).KDJMFELBOPM()?.itemInstance?.LHBPOPOIFLE() is Mop)
		{
			return false;
		}
		if (currentMoodState == MoodState.Rowdy && customerState != CustomerState.Spawning && customerState != CustomerState.HeadingToSeat)
		{
			return true;
		}
		if (currentRequest != null && customerState == CustomerState.Leaving && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI() && ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > ((Component)Bar.instance.placeable).transform.position.y)
		{
			return false;
		}
		if (customerState == (CustomerState)120 && currentRequest != null)
		{
			if (!DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DFNMDDHOIJI())
			{
				return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).trayHandler.tray.AIMCMHBMIMP(currentRequest);
			}
			return false;
		}
		return true;
	}

	private void IGKNAKFMCMG(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Employee NAKCFGEAGHH, bool GFNHAMCPEAK)
	{
		if (currentItem.LHBPOPOIFLE().ticket && Utils.EGIBECKKIJJ())
		{
			int ticketPrice = currentItem.LHBPOPOIFLE().ticketPrice;
			if (GFNHAMCPEAK)
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(ItemDatabaseAccessor.GetItem(1224).JMDALJBNFML(), ticketPrice, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, NLCDDFDGACP);
				ShowTicketPrice(ticketPrice);
			}
			if (OnlineManager.IsMasterClient())
			{
				base.LJOHCJAOADD?.SendTicketPrice(ticketPrice);
			}
		}
		else if (!NewTutorialManager.CCCLOBIOMCL || (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() >= 133))
		{
			if ((Object)(object)NAKCFGEAGHH == (Object)null || Random.Range(0, 100) >= NAKCFGEAGHH.GetPerkValue(55))
			{
				Price eNDNDAOPKHD = Utils.NEGAOFJKCCH(currentItem, NAKCFGEAGHH);
				ShowMoney(eNDNDAOPKHD);
				if (OnlineManager.IsMasterClient())
				{
					base.LJOHCJAOADD?.SendMoneyText(eNDNDAOPKHD);
				}
			}
			else
			{
				Debug.LogError((object)"Item Transaction. PERK!!");
			}
		}
		else
		{
			Debug.LogError((object)"Item Transaction. Tutorial active!!");
		}
	}

	public void UpdateMoodState(MoodState AGIMFNFOCCM, bool CDPAMNIPPEC)
	{
		if (AGIMFNFOCCM == MoodState.Rowdy)
		{
			RowdyCustomer();
		}
		else if (currentMoodState == MoodState.Rowdy && AGIMFNFOCCM == MoodState.Neutral)
		{
			RowdyToNeutralCustomer(CDPAMNIPPEC);
		}
		currentMoodState = AGIMFNFOCCM;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD.SendUpdateMoodState(currentMoodState);
		}
	}

	[SpecialName]
	public void MFOPJDFMJBN(MoodState AODONKKHPBP)
	{
		if (AODONKKHPBP != currentMoodState)
		{
			UpdateMoodState(AODONKKHPBP, CDPAMNIPPEC: false);
		}
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && !seatAssigned && customerState == CustomerState.Despawning && Time.time - FFMPGAEPEFG < 7f)
		{
			ChangeState(CustomerState.Spawning);
		}
	}

	private ItemInstance KBPDHBBINCL(Employee NAKCFGEAGHH)
	{
		List<FoodInstance> allDrinksInstancesHalloween;
		if (Utils.FFLNGLMHLBO() && Random.Range(0, 100) < 70)
		{
			allDrinksInstancesHalloween = BarMenuManager.GetAllDrinksInstancesHalloween();
			if (allDrinksInstancesHalloween.Any())
			{
				FoodInstance productWithPerks = GetProductWithPerks(NAKCFGEAGHH, allDrinksInstancesHalloween);
				if (productWithPerks != null)
				{
					return productWithPerks;
				}
				return allDrinksInstancesHalloween.ElementAt(Random.Range(0, allDrinksInstancesHalloween.Count));
			}
		}
		allDrinksInstancesHalloween = BarMenuManager.GetAllDrinksInstances();
		if (allDrinksInstancesHalloween.Any())
		{
			FoodInstance productWithPerks2 = GetProductWithPerks(NAKCFGEAGHH, allDrinksInstancesHalloween);
			if (productWithPerks2 != null)
			{
				return productWithPerks2;
			}
			return allDrinksInstancesHalloween.ElementAt(Random.Range(0, allDrinksInstancesHalloween.Count));
		}
		return ItemDatabaseAccessor.GetItem(1318).JMDALJBNFML();
	}

	public void BecomeNuisance(bool CDPAMNIPPEC)
	{
		Debug.Log((object)"BecomeNuisance", (Object)(object)((Component)this).gameObject);
		EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: false);
		HLFFOKMBIDJ = true;
		((Component)hitDetection).gameObject.SetActive(true);
		((Component)this).gameObject.layer = 24;
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			base.LJOHCJAOADD.SendBecomeNuisance();
		}
		if (OnlineManager.MasterOrOffline())
		{
			ChangeState(CustomerState.BeingANuisance);
			CommonReferences.GGFJGHHHEJC.OnCustomerBecomeNuisance();
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void KickWithForce(Vector3 JBMDOGNFIGJ)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		MarkAsKicked();
		((MonoBehaviour)this).StartCoroutine(MFAKADCMNAG(JBMDOGNFIGJ));
	}

	public void UpdateTavernVisionColor(bool DMBFKFLDDLH)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (DMBFKFLDDLH)
		{
			if (customerState == CustomerState.BeingANuisance || currentMoodState == MoodState.Rowdy)
			{
				characterAnimation.characterAnimator.ChangeColor(new Color(1f, 0.5f, 0.5f, 1f));
			}
			else
			{
				characterAnimation.characterAnimator.ResetColor();
			}
		}
		else
		{
			characterAnimation.characterAnimator.ResetColor();
		}
	}

	private void HLDFGLIMPFJ(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB() && !seatAssigned && customerState == CustomerState.BeingANuisance && Time.time - FFMPGAEPEFG < 355f)
		{
			ChangeState(CustomerState.Inactive);
		}
	}

	private float POMNANFHCPP()
	{
		float num = customerInfo.floorDirtProbability;
		if (Waiter.INOKIOHEDEH())
		{
			num -= (float)(customerInfo.floorDirtProbability * Waiter.GetEmployeePerkValue(80)) / 1800f;
		}
		if (Bouncer.LDICGJGFBBG())
		{
			num -= (float)(customerInfo.floorDirtProbability * Bouncer.NADBCNFALNF(-124)) / 578f;
		}
		if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() < 168)
		{
			num -= (float)customerInfo.floorDirtProbability * 1027f;
		}
		return num * TavernManager.GGFJGHHHEJC.floorDirtyMultiplier;
	}

	public bool CalmCustomer(Employee NAKCFGEAGHH)
	{
		if (currentMoodState == MoodState.Rowdy && customerState != CustomerState.BeingANuisance && customerState != CustomerState.Leaving)
		{
			if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)NewTutorialManager.instance.currentTutorialPhase != (Object)null && NewTutorialManager.instance.currentTutorialPhase.GetID() == 112)
			{
				BecomeNuisance(CDPAMNIPPEC: true);
				return true;
			}
			float num = (float)customerInfo.calmRowdyCustomersProbability / 100f;
			if ((Object)(object)NAKCFGEAGHH != (Object)null)
			{
				if (Random.Range(0, 100) < NAKCFGEAGHH.GetPerkValue(59))
				{
					LeaveWillingly();
					return true;
				}
				num += (float)(customerInfo.calmRowdyCustomersProbability * NAKCFGEAGHH.GetPerkValue(38)) / 100f;
			}
			if (Random.Range(0f, 1f) < num)
			{
				KPGJGABJMFC = MoodState.Neutral;
				((Component)this).gameObject.layer = 21;
			}
			else
			{
				BecomeNuisance(CDPAMNIPPEC: true);
			}
			return true;
		}
		return false;
	}

	public void IdleAtTable()
	{
		currentItem = null;
		characterAnimation.characterAnimator.ActivateEatGameObjects(0, PJEILLAADOC: true, CDPAMNIPPEC: false);
		npc.FJHKGBNBNKL.SetBool("Eat", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.IsMasterClient())
		{
			base.LJOHCJAOADD.SendIdleAtTable();
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (customerState == CustomerState.OrderInTable || bubbleWants == null)
		{
			return;
		}
		for (int i = 0; i < bubbleWants.Length; i++)
		{
			if (!((Object)(object)bubbleWants[i] == (Object)null))
			{
				if (!bubbleWants[i].isTicket)
				{
					bubbleWants[i].ActivateOutlines(JIIGOACEIKL, NJHMBMGKCPL: false);
				}
				else
				{
					bubbleWants[i].MoveTicket(NJHMBMGKCPL: false);
				}
			}
		}
	}
}
