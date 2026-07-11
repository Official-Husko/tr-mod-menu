using System;
using System.Collections;
using UnityEngine;

[DefaultExecutionOrder(1)]
public abstract class Employee : MonoBehaviour, ISelectable, IHoverable, IProximity, IInteractable
{
	public StaffBaseState currentState;

	public Animator behaviour;

	public CharacterAnimation characterAnimation;

	public CharacterCreator characterCreator;

	public HumanNPC npc;

	public TrayHandler trayHandler;

	public WorkerAvoidingWork workerAvoidingWork;

	public Action OnAtAvoidingWorkPoint = delegate
	{
	};

	public Action OnSentEmployeeBackToWork = delegate
	{
	};

	public OnlineEmployee onlineEmployeeScript;

	public bool avoidingWorkPoint;

	public int maxAvoidWorkTimes = 2;

	public DrinkDispenser drinkDispenser;

	public bool canAvoidWork = true;

	public GameObject hitFx;

	public Collider2D npcCollider;

	public Animator avoidingWorkEmote;

	public float avoidWorkMinTime = 45f;

	public float avoidWorkMaxTime = 90f;

	public float avoidWorkRateMin = 180f;

	public float avoidWorkRateMax = 300f;

	public float avoidWorkProbability = 50f;

	public float spawningTime;

	private float APHKKLCOHBN;

	private int CNLBCABEGGC;

	protected float ABEAMGFGFCC;

	private int NLCHEINGAIB;

	private int OHFOGKIALHF;

	private Coroutine HGGOMGHKAMJ;

	protected static readonly int BNJILEEKNNI = AnimatorParameterCache.p_Leaving;

	protected static readonly int DDJGAMBJKPE = AnimatorParameterCache.p_AvoidingWork;

	protected static readonly int JBMKJLEJFKC = AnimatorParameterCache.p_Avoid;

	protected static readonly int IIFLFAJODIL = AnimatorParameterCache.p_Waiting;

	protected static readonly int BKOCCBLGHPB = AnimatorParameterCache.p_TakingDrink;

	protected static readonly int NHMLEJGLJDC = AnimatorParameterCache.p_CleaningTable;

	protected static readonly int JDBIJKJLLGF = AnimatorParameterCache.p_CleaningFloorDirt;

	protected static readonly int NHBJKHNBDPH = AnimatorParameterCache.p_ServingTableOrder;

	protected static readonly int IBLCDBJDFKA = AnimatorParameterCache.p_HeadingToDrinksTable;

	protected static readonly int IIMAJJLHICE = AnimatorParameterCache.p_ServingCustomer;

	protected static readonly int OODELEOPKGE = AnimatorParameterCache.p_LightingFireplace;

	protected static readonly int HBJLLBKDJNK = AnimatorParameterCache.p_ServingRoomOrder;

	protected static readonly int GKJACJIKMAG = AnimatorParameterCache.p_CleaningRoom;

	protected static readonly int IBPBMDEOCLK = AnimatorParameterCache.p_RenewingCandle;

	protected static readonly int DDKMKPJFKOL = AnimatorParameterCache.p_KickRowdyCustomer;

	protected static readonly int EGJEDCPHEJH = AnimatorParameterCache.p_Club;

	public NPCWalkTo OEONGPFALKH => npc.walkTo;

	public EmployeeInfo JFCLIAFAOEK => characterCreator.humanInfo as EmployeeInfo;

	public bool AIKLCDAKADI
	{
		get
		{
			if (JFCLIAFAOEK != null)
			{
				return JFCLIAFAOEK.working;
			}
			return false;
		}
	}

	public abstract bool LFDMDACCKJP { get; }

	protected virtual void Start()
	{
		if (IgnoreDuringOnline())
		{
			return;
		}
		if (JFCLIAFAOEK == null)
		{
			DestroyEmployee();
			return;
		}
		APHKKLCOHBN = Time.time + 240f;
		workerAvoidingWork = new WorkerAvoidingWork(this);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineEmployeeScript == (Object)null)
		{
			onlineEmployeeScript = ((Component)this).GetComponent<OnlineEmployee>();
		}
		characterCreator.Initialize();
		spawningTime = Time.time;
		canAvoidWork = Random.Range(0, 100) >= JFCLIAFAOEK.OMNLNLGDOBG(15);
		if (!Money.CanAfford(JFCLIAFAOEK.MFMFHEGMAKI()))
		{
			DestroyEmployee();
		}
		else
		{
			behaviour.SetTrigger(IIFLFAJODIL);
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private IEnumerator AAGGGBAPFGJ()
	{
		for (int i = 0; i < characterAnimation.characterAnimator.allReskins.Length; i++)
		{
			characterAnimation.characterAnimator.allReskins[i].spriteRenderer.color = Color.red;
		}
		yield return CommonReferences.wait01;
		for (int j = 0; j < characterAnimation.characterAnimator.allReskins.Length; j++)
		{
			characterAnimation.characterAnimator.allReskins[j].spriteRenderer.color = Color.white;
		}
		yield return CommonReferences.wait01;
		for (int k = 0; k < characterAnimation.characterAnimator.allReskins.Length; k++)
		{
			characterAnimation.characterAnimator.allReskins[k].spriteRenderer.color = Color.red;
		}
		yield return CommonReferences.wait01;
		for (int l = 0; l < characterAnimation.characterAnimator.allReskins.Length; l++)
		{
			characterAnimation.characterAnimator.allReskins[l].spriteRenderer.color = Color.white;
		}
	}

	public bool CleanFloorDirt(FloorDirt DDJECCPKNKG, float CCLPLPEGEAJ)
	{
		float num = CCLPLPEGEAJ;
		num += CCLPLPEGEAJ * (float)GetPerkValue(31) / 100f;
		num += CCLPLPEGEAJ * (float)GetPerkValue(48) / 100f;
		num -= CCLPLPEGEAJ * (float)GetPerkValue(62) / 100f;
		if (DDJECCPKNKG.Clean(0, num))
		{
			return true;
		}
		return false;
	}

	public bool IgnoreDuringOnline()
	{
		if (OnlineManager.ClientOnline())
		{
			return true;
		}
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.MasterOrOffline())
			{
				behaviour.SetTrigger(IIFLFAJODIL);
			}
			else
			{
				onlineEmployeeScript.SendMasterEmployeeBackToWork();
				avoidingWorkPoint = false;
			}
			return true;
		}
		return false;
	}

	private void IBGFNGCPBPG()
	{
		NLCHEINGAIB++;
		OHFOGKIALHF++;
		if (NLCHEINGAIB >= 60)
		{
			ChargeMoney();
		}
		if (OHFOGKIALHF >= 60)
		{
			OHFOGKIALHF = 0;
			if (!LFDMDACCKJP && JFCLIAFAOEK != null)
			{
				JFCLIAFAOEK.GDKJAPGMOBI();
			}
		}
	}

	public void AvoidWork()
	{
		CommonReferences.GGFJGHHHEJC.workerAvoidingWork = true;
		behaviour.SetTrigger(DDJGAMBJKPE);
		APHKKLCOHBN = Time.time + 300f;
		CNLBCABEGGC++;
	}

	public Price ApplyPerkPrices(ItemInstance AAAECFKMEJJ, Price ENDNDAOPKHD)
	{
		if (JFCLIAFAOEK != null)
		{
			Price eNDNDAOPKHD = Price.GHDCKOJGAMM(ENDNDAOPKHD.copper);
			int num = JFCLIAFAOEK.OMNLNLGDOBG(5);
			if (num > 0)
			{
				ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
			}
			num = JFCLIAFAOEK.OMNLNLGDOBG(69);
			if (num > 0)
			{
				ENDNDAOPKHD = Price.KINGABDNACL(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
			}
			if (AAAECFKMEJJ is FoodInstance foodInstance)
			{
				if (!foodInstance.JJAKCHINFMH(IngredientType.Meat))
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(6);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				else
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(7);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (!foodInstance.LHBPOPOIFLE().containsAlcohol)
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(8);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				else
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(9);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (AAAECFKMEJJ.AFILAHPFDOD(IngredientType.Wine))
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(10);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (AAAECFKMEJJ.JDEFAOOFOMN())
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(11);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (AAAECFKMEJJ.AFILAHPFDOD(IngredientType.Distillate))
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(12);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (AAAECFKMEJJ.AFILAHPFDOD(IngredientType.Cocktail))
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(13);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (foodInstance.JJAKCHINFMH(IngredientType.WhiteFish) || foodInstance.JJAKCHINFMH(IngredientType.BlueFish) || foodInstance.JJAKCHINFMH(IngredientType.Shellfish))
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(16);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (foodInstance.JJAKCHINFMH(IngredientType.Veg) || foodInstance.JJAKCHINFMH(IngredientType.Fruit) || foodInstance.JJAKCHINFMH(IngredientType.Berries))
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(17);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (WorldTime.NOAOJJLNHJJ.hour > 6 && WorldTime.NOAOJJLNHJJ.hour < 16)
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(19);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				else
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(20);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (AAAECFKMEJJ.JEPBBEBJEFI() && AAAECFKMEJJ is FoodInstance { GBCJNGADANM: <3 })
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(22);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				if (AAAECFKMEJJ.JEPBBEBJEFI() && AAAECFKMEJJ is FoodInstance { GBCJNGADANM: >=3 })
				{
					num = JFCLIAFAOEK.OMNLNLGDOBG(23);
					if (num > 0)
					{
						ENDNDAOPKHD = Price.GMJIFJAEANF(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
					}
				}
				num = JFCLIAFAOEK.OMNLNLGDOBG(77);
				if (num > 0 && (foodInstance.JJAKCHINFMH(IngredientType.Meat) || foodInstance.JJAKCHINFMH(IngredientType.WhiteFish) || foodInstance.JJAKCHINFMH(IngredientType.BlueFish) || foodInstance.JJAKCHINFMH(IngredientType.Shellfish)))
				{
					ENDNDAOPKHD = Price.KINGABDNACL(ENDNDAOPKHD, Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)num / 100f));
				}
			}
		}
		return ENDNDAOPKHD;
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public void DelayTrigger(string PFNFAPCMEPI, float FLHBPHPKIML)
	{
		DelayTrigger(Animator.StringToHash(PFNFAPCMEPI), FLHBPHPKIML);
	}

	protected virtual void OnDisable()
	{
		if (OnlineManager.MasterOrOffline())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Remove(WorldTime.OnTickTime1Second, new Action(IBGFNGCPBPG));
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	protected virtual void Awake()
	{
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).GetComponent<HumanNPC>();
		}
		if ((Object)(object)characterAnimation == (Object)null)
		{
			characterAnimation = ((Component)this).GetComponent<CharacterAnimation>();
		}
	}

	private IEnumerator MFAKADCMNAG(HitDetection NOCOHCGPMFF)
	{
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			hitFx.SetActive(false);
			if (NOCOHCGPMFF.bouncer)
			{
				characterAnimation.LookAtObject(((Component)Bouncer.GetInstance()).gameObject);
				Vector3 val = ((Component)this).transform.position - ((Component)Bouncer.GetInstance()).transform.position;
				((Component)this).GetComponent<Rigidbody2D>().AddForce(Vector2.op_Implicit(val * 100f));
			}
			else
			{
				characterAnimation.LookAtObject(((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).gameObject);
				Vector3 val2 = ((Component)this).transform.position - ((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position;
				((Component)this).GetComponent<Rigidbody2D>().AddForce(Vector2.op_Implicit(val2 * 100f));
			}
			((MonoBehaviour)this).StartCoroutine(AAGGGBAPFGJ());
			hitFx.SetActive(true);
			((Behaviour)npcCollider).enabled = true;
			npc.walkTo.isActive = false;
			yield return CommonReferences.wait06;
			((Behaviour)npcCollider).enabled = false;
		}
		behaviour.SetTrigger(IIFLFAJODIL);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return false;
		}
		if (OnlineManager.MasterOrOffline())
		{
			AnimatorStateInfo currentAnimatorStateInfo = behaviour.GetCurrentAnimatorStateInfo(0);
			if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("AvoidingWork"))
			{
				return !LFDMDACCKJP;
			}
			return false;
		}
		return avoidingWorkPoint;
	}

	public void ChargeMoney()
	{
		NLCHEINGAIB = 0;
		if (LFDMDACCKJP || JFCLIAFAOEK == null)
		{
			return;
		}
		Price price = JFCLIAFAOEK.MFMFHEGMAKI();
		if (Money.CanAfford(price))
		{
			ChargeMoneyClient(price);
			if (OnlineManager.IsMasterClient())
			{
				onlineEmployeeScript.SendChargeMoney(price);
			}
		}
		else
		{
			Leave();
		}
	}

	public void DelayTrigger(int OIKALECHOAH, float FLHBPHPKIML)
	{
		if (HGGOMGHKAMJ == null)
		{
			HGGOMGHKAMJ = ((MonoBehaviour)this).StartCoroutine(MPKLEKJHCBO(OIKALECHOAH, FLHBPHPKIML));
		}
	}

	public int GetPerkValue(int JFNMCNCHMEO)
	{
		if (JFCLIAFAOEK != null)
		{
			return JFCLIAFAOEK.OMNLNLGDOBG(JFNMCNCHMEO);
		}
		return 0;
	}

	public void AtAvoidingWorkPoint()
	{
		avoidingWorkPoint = true;
		avoidingWorkEmote.SetBool(JBMKJLEJFKC, true);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public virtual void Leave()
	{
		if (Object.op_Implicit((Object)(object)trayHandler))
		{
			trayHandler.tray.MKBDMMJCGGM();
		}
		behaviour.SetTrigger(BNJILEEKNNI);
	}

	protected virtual void OnEnable()
	{
		if (OnlineManager.MasterOrOffline())
		{
			WorldTime.OnTickTime1Second = (Action)Delegate.Combine(WorldTime.OnTickTime1Second, new Action(IBGFNGCPBPG));
		}
	}

	protected void JOCGLBKGHBB(float GHBIKFABLHE)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		ABEAMGFGFCC = Time.time + GHBIKFABLHE;
		if (npc.EOAONHNCDDO == NPCState.Walking && Random.Range(0, 100) < GetPerkValue(66))
		{
			Utils.BGJKAOHBKMP(((Component)this).transform.position);
		}
	}

	public void ReturnToWork(HitDetection NOCOHCGPMFF = null)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo currentAnimatorStateInfo = behaviour.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).IsName("AvoidingWork"))
		{
			((MonoBehaviour)this).StartCoroutine(MFAKADCMNAG(NOCOHCGPMFF));
		}
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void EmployeeBackToWork()
	{
		if (OnlineManager.IsMasterClient())
		{
			behaviour.SetTrigger(IIFLFAJODIL);
		}
		if (OnlineManager.ClientOnline())
		{
			avoidingWorkPoint = false;
			avoidingWorkEmote.SetBool(JBMKJLEJFKC, false);
		}
	}

	public bool FinishTakingDrink(ItemInstance DNLMCHDOMOK)
	{
		if (drinkDispenser.slots[0].KPINNBKMOMO())
		{
			if (DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC() != 1318)
			{
				behaviour.SetTrigger(IIFLFAJODIL);
				return false;
			}
			drinkDispenser.slots[0].BEEDBHJANGN(0, DNLMCHDOMOK.LHBPOPOIFLE().JMDALJBNFML(), drinkDispenser.maxStack, HAGPBCJEGKM: false, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
		}
		if (Random.Range(0, 100) < GetPerkValue(57))
		{
			drinkDispenser.slots[0].MEODNPFJDMH();
			if (drinkDispenser.slots[0].KPINNBKMOMO())
			{
				behaviour.SetTrigger(IIFLFAJODIL);
			}
			else
			{
				behaviour.SetTrigger(BKOCCBLGHPB);
			}
			return false;
		}
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Talk"));
			return true;
		}
		return false;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private IEnumerator MPKLEKJHCBO(int OIKALECHOAH, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		behaviour.SetTrigger(OIKALECHOAH);
		HGGOMGHKAMJ = null;
	}

	public abstract void SetInstance(Employee NAKCFGEAGHH);

	public void DestroyEmployee()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void ChargeMoneyClient(Price NMGBEJGBFHB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Money.MinusPrice(NMGBEJGBFHB, BGKCHMNJBLJ: false);
		Money.SpawnMoneyText(NMGBEJGBFHB, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(0f, 1.25f, 0f)), CDPAMNIPPEC: false);
		TavernServiceManager.GGFJGHHHEJC.AddBartenderCost(NMGBEJGBFHB);
	}

	protected virtual void Update()
	{
		if (IgnoreDuringOnline() || CNLBCABEGGC >= maxAvoidWorkTimes || !canAvoidWork || !(Time.time > APHKKLCOHBN))
		{
			return;
		}
		APHKKLCOHBN = Time.time + Random.Range(avoidWorkRateMin, avoidWorkRateMax);
		if (!CommonReferences.GGFJGHHHEJC.workerAvoidingWork)
		{
			float num = avoidWorkProbability;
			if (Bouncer.JHLLELHBIDA && !(this is Bouncer))
			{
				num -= avoidWorkProbability * (float)Bouncer.GetEmployeePerkValue(36) / 100f;
			}
			num += avoidWorkProbability * (float)GetPerkValue(56) / 100f;
			if ((float)Random.Range(0, 100) < num)
			{
				AvoidWork();
			}
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}
}
