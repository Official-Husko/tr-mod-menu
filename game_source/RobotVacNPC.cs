using System;
using UnityEngine;

public class RobotVacNPC : NPC
{
	public Action OnLeaveBase = delegate
	{
	};

	public Action OnReturnBase = delegate
	{
	};

	public bool active;

	public FloorDirt target;

	[SerializeField]
	private CleanoidBase home;

	[SerializeField]
	private bool walkingToDirt;

	[SerializeField]
	private bool walkingHome;

	[SerializeField]
	private bool isHome = true;

	public Animator animator;

	private bool OIMHAMHKDOG;

	public OnlineMagicBroom onlineMagicBroom;

	private Vector3 AADMIOHCEEB;

	public void HDPPJCDGGCN(FloorDirt DCGBADKLANM)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)target != (Object)null && (Object)(object)target.cleanerAssigned == (Object)(object)this)
		{
			target.cleanerAssigned = null;
		}
		target = DCGBADKLANM;
		if ((Object)(object)target != (Object)null)
		{
			target.cleanerAssigned = this;
			walkingToDirt = false;
			walkTo.GHDMBFOAAHK(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(((Component)target).transform.position)), AHDHLIECIGH: false);
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(MHDCHBAMABI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GNFOCMPJIHE));
			NPCWalkTo nPCWalkTo3 = walkTo;
			nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(PKILOHICOMM));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void EAKLGPONMIM()
	{
		isHome = true;
		walkingHome = true;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.ANNHIPOCGPB(NPC.HGEBKKGJONI);
		}
	}

	private void Start()
	{
		MagicBroomsManager.instance.magicBrooms.Add(this);
	}

	private void KIFAGINEMIJ()
	{
		home.placeable.pickUpable = true;
		isHome = false;
		walkingToDirt = false;
		SetTarget(null);
		if (OnlineManager.IsMasterClient())
		{
			onlineMagicBroom.SendSetPickupable(IHLGDCAIPLN: true);
		}
	}

	private void OMGEMBNPKIE()
	{
		OLLIOMEJKPH(null);
		walkingToDirt = true;
		walkingHome = false;
	}

	public void SetTarget(FloorDirt DCGBADKLANM)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)target != (Object)null && (Object)(object)target.cleanerAssigned == (Object)(object)this)
		{
			target.cleanerAssigned = null;
		}
		target = DCGBADKLANM;
		if ((Object)(object)target != (Object)null)
		{
			target.cleanerAssigned = this;
			walkingToDirt = true;
			walkTo.FNNPPBDFBCI(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(((Component)target).transform.position)));
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GDBCNMEILMG));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BMINCCOPHLJ));
			NPCWalkTo nPCWalkTo3 = walkTo;
			nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(CDAECLNMCBK));
			walkTo.PEHELKCIECB();
		}
	}

	private void LKABGBHAHAF()
	{
		isHome = true;
		walkingHome = true;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.IsMasterClient())
		{
			onlineMagicBroom.SendSetTrigger(NPC.HGEBKKGJONI);
		}
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			base.OnDestroy();
			if (Object.op_Implicit((Object)(object)MagicBroomsManager.instance))
			{
				MagicBroomsManager.instance.magicBrooms.Remove(this);
			}
		}
	}

	private void AFKGJCIANOF()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!active)
		{
			return;
		}
		if (walkingToDirt)
		{
			if ((Object)(object)target != (Object)null)
			{
				if (walkTo.PLAGPJAKCKL())
				{
					walkingToDirt = false;
				}
			}
			else
			{
				walkingToDirt = false;
			}
		}
		else if (walkingHome && walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true))
		{
			FBMGIOFPMFD();
		}
		if (OnlineManager.JPPBEIJDCLJ() && Object.op_Implicit((Object)(object)onlineMagicBroom) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			if (!onlineMagicBroom.placeable.FHEMHCEAICB && !onlineMagicBroom.CLHLNFFGOGA)
			{
				onlineMagicBroom.NOMJMMIPOAE();
			}
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	public void KIHIKAPPFFJ(FloorDirt DCGBADKLANM)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)target != (Object)null && (Object)(object)target.cleanerAssigned == (Object)(object)this)
		{
			target.cleanerAssigned = null;
		}
		target = DCGBADKLANM;
		if ((Object)(object)target != (Object)null)
		{
			target.cleanerAssigned = this;
			walkingToDirt = false;
			walkTo.GHDMBFOAAHK(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(((Component)target).transform.position)), AHDHLIECIGH: false);
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DPOEOPHDOHB));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OMGEMBNPKIE));
			NPCWalkTo nPCWalkTo3 = walkTo;
			nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(CPOAMCKPEEC));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void INCGMHCLIOK()
	{
		isHome = true;
		walkingToDirt = true;
		walkingHome = false;
		HDPPJCDGGCN(null);
		home.placeable.pickUpable = true;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.NJACLLDHJBO(NPC.HGFDBMAGOAN);
			onlineMagicBroom.SendSetPickupable(IHLGDCAIPLN: false);
		}
	}

	private void DGIFHBIJDDE()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!active)
		{
			return;
		}
		if (walkingToDirt)
		{
			if ((Object)(object)target != (Object)null)
			{
				if (walkTo.IIMEFNIECLI())
				{
					walkingToDirt = false;
				}
			}
			else
			{
				walkingToDirt = true;
			}
		}
		else if (walkingHome && walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true))
		{
			JGIFMFBINNI();
		}
		if (OnlineManager.JPPBEIJDCLJ() && Object.op_Implicit((Object)(object)onlineMagicBroom) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			if (!onlineMagicBroom.placeable.FHEMHCEAICB && !onlineMagicBroom.CLHLNFFGOGA)
			{
				onlineMagicBroom.UpdateBroomPosition();
			}
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	private void LCJJBMJILPF()
	{
		isHome = false;
		walkingHome = false;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.HBFNPOIBCHG(NPC.HGEBKKGJONI);
		}
	}

	private void IOIPLDPKLIM()
	{
		if ((Object)(object)target != (Object)null)
		{
			if (!OIMHAMHKDOG)
			{
				OIMHAMHKDOG = true;
			}
			else
			{
				OLLIOMEJKPH(null);
				OIMHAMHKDOG = true;
			}
		}
		walkingToDirt = false;
	}

	private void DKCOBAFFIEI()
	{
		isHome = false;
		walkingHome = true;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.ANNHIPOCGPB(NPC.HGEBKKGJONI);
		}
	}

	private void AGACCKAEEDK()
	{
		home.placeable.pickUpable = false;
		isHome = true;
		walkingToDirt = false;
		HDPPJCDGGCN(null);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.GJHMBJIDFBO(IHLGDCAIPLN: true);
		}
	}

	private void JGIFMFBINNI()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = false;
		walkingHome = true;
	}

	private void FEIHLBAAMBC()
	{
		isHome = false;
		walkingHome = false;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.EGBKNLBAGHA(NPC.HGEBKKGJONI);
		}
	}

	private void KGOECCFCPLK()
	{
		isHome = false;
		walkingToDirt = true;
		walkingHome = false;
		KIHIKAPPFFJ(null);
		home.placeable.pickUpable = false;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.NPOFHMGPGCM(NPC.HGFDBMAGOAN);
			onlineMagicBroom.PIPPNNGLJJA(IHLGDCAIPLN: false);
		}
	}

	private void HKOFLOPDCEJ()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!active)
		{
			return;
		}
		if (walkingToDirt)
		{
			if ((Object)(object)target != (Object)null)
			{
				if (walkTo.PAHDHACALOH())
				{
					walkingToDirt = false;
				}
			}
			else
			{
				walkingToDirt = true;
			}
		}
		else if (walkingHome && walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true))
		{
			HKKEFOJMPPP();
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineMagicBroom) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			if (!onlineMagicBroom.placeable.FHEMHCEAICB && !onlineMagicBroom.KFAJLICFLIC())
			{
				onlineMagicBroom.UpdateBroomPosition();
			}
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	private void GDBCNMEILMG()
	{
		if ((Object)(object)target != (Object)null)
		{
			if (!OIMHAMHKDOG)
			{
				OIMHAMHKDOG = true;
			}
			else
			{
				SetTarget(null);
				OIMHAMHKDOG = false;
			}
		}
		walkingToDirt = false;
	}

	private void MMPMJNAFKHC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!active || OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if ((Object)(object)target == (Object)null)
		{
			if (!walkingToDirt && !isHome && !walkingHome)
			{
				home.placeable.pickUpable = false;
				walkingHome = true;
				walkTo.KBEENHPEOAB(Vector2.op_Implicit(((Component)home).transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
				NPCWalkTo nPCWalkTo = walkTo;
				nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BPLCGNPMJKP));
				NPCWalkTo nPCWalkTo2 = walkTo;
				nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HKKEFOJMPPP));
				NPCWalkTo nPCWalkTo3 = walkTo;
				nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(AGACCKAEEDK));
				walkTo.PEHELKCIECB();
				if (OnlineManager.IsMasterClient())
				{
					onlineMagicBroom.CDJGKENFKPN(IHLGDCAIPLN: true);
				}
			}
		}
		else if (OIMHAMHKDOG && target.EELFIIHLDCB(1, 151f))
		{
			MHDCHBAMABI();
		}
	}

	private void DPOEOPHDOHB()
	{
		if ((Object)(object)target != (Object)null)
		{
			if (!OIMHAMHKDOG)
			{
				OIMHAMHKDOG = false;
			}
			else
			{
				GDBOIIKDELL(null);
				OIMHAMHKDOG = true;
			}
		}
		walkingToDirt = false;
	}

	private void HMODGAEEMCN()
	{
		isHome = false;
		walkingToDirt = true;
		walkingHome = true;
		SetTarget(null);
		home.placeable.pickUpable = true;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.APGKMHDMIKF(NPC.HGFDBMAGOAN);
			onlineMagicBroom.IIJKNHJMJPH(IHLGDCAIPLN: false);
		}
	}

	private void MHDCHBAMABI()
	{
		if ((Object)(object)target != (Object)null)
		{
			if (!OIMHAMHKDOG)
			{
				OIMHAMHKDOG = true;
			}
			else
			{
				GDBOIIKDELL(null);
				OIMHAMHKDOG = true;
			}
		}
		walkingToDirt = false;
	}

	private void LDJMBHKMFPK()
	{
		isHome = false;
		walkingToDirt = true;
		walkingHome = true;
		OLLIOMEJKPH(null);
		home.placeable.pickUpable = false;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.BLOEANHKHEG(NPC.HGFDBMAGOAN);
			onlineMagicBroom.DFMNKGFGMNN(IHLGDCAIPLN: false);
		}
	}

	private void HPDMIKCLHDP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = false;
		walkingHome = false;
	}

	private void JPHHCGFCIFF()
	{
		isHome = true;
		walkingToDirt = true;
		walkingHome = false;
		OLLIOMEJKPH(null);
		home.placeable.pickUpable = true;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.IsMasterClient())
		{
			onlineMagicBroom.ANNHIPOCGPB(NPC.HGFDBMAGOAN);
			onlineMagicBroom.NMLJLOEAJPN(IHLGDCAIPLN: true);
		}
	}

	private void FOBIGFEIFCN()
	{
		home.placeable.pickUpable = true;
		isHome = true;
		walkingToDirt = false;
		OLLIOMEJKPH(null);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.NMLJLOEAJPN(IHLGDCAIPLN: false);
		}
	}

	private void AHIIENJLFEI()
	{
		OLLIOMEJKPH(null);
		walkingToDirt = false;
		walkingHome = true;
	}

	private void FixedUpdate()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!active)
		{
			return;
		}
		if (walkingToDirt)
		{
			if ((Object)(object)target != (Object)null)
			{
				if (walkTo.IIMEFNIECLI())
				{
					walkingToDirt = false;
				}
			}
			else
			{
				walkingToDirt = false;
			}
		}
		else if (walkingHome && walkTo.IIMEFNIECLI())
		{
			FBMGIOFPMFD();
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineMagicBroom) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			if (!onlineMagicBroom.placeable.FHEMHCEAICB && !onlineMagicBroom.CLHLNFFGOGA)
			{
				onlineMagicBroom.UpdateBroomPosition();
			}
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	private void CDAECLNMCBK()
	{
		isHome = false;
		walkingHome = false;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.IsMasterClient())
		{
			onlineMagicBroom.SendSetTrigger(NPC.HGEBKKGJONI);
		}
	}

	private void KLMCHGOMPEH()
	{
		HDPPJCDGGCN(null);
		walkingToDirt = true;
		walkingHome = false;
	}

	private void NHJLCODJMDP()
	{
		home.placeable.pickUpable = true;
		isHome = false;
		walkingToDirt = false;
		KIHIKAPPFFJ(null);
		if (OnlineManager.IsMasterClient())
		{
			onlineMagicBroom.CDJGKENFKPN(IHLGDCAIPLN: false);
		}
	}

	private void DCKKIDMJKJM()
	{
		MagicBroomsManager.instance.magicBrooms.Add(this);
	}

	private void BMINCCOPHLJ()
	{
		SetTarget(null);
		walkingToDirt = false;
		walkingHome = false;
	}

	public void OLLIOMEJKPH(FloorDirt DCGBADKLANM)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)target != (Object)null && (Object)(object)target.cleanerAssigned == (Object)(object)this)
		{
			target.cleanerAssigned = null;
		}
		target = DCGBADKLANM;
		if ((Object)(object)target != (Object)null)
		{
			target.cleanerAssigned = this;
			walkingToDirt = false;
			walkTo.KBEENHPEOAB(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(((Component)target).transform.position)), AHDHLIECIGH: false, NGAKHGJANLO: false);
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DPOEOPHDOHB));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OMGEMBNPKIE));
			NPCWalkTo nPCWalkTo3 = walkTo;
			nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(OFNKMGPKKBL));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void LAHFGIKAEMO()
	{
		GDBOIIKDELL(null);
		walkingToDirt = true;
		walkingHome = false;
	}

	private void GEPBKAPKAEN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = true;
		walkingHome = false;
	}

	private void KDFLKFLJIJB()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = true;
		walkingHome = true;
	}

	private void CPOAMCKPEEC()
	{
		isHome = true;
		walkingHome = true;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.BLIDEAAIBIF(NPC.HGEBKKGJONI);
		}
	}

	private void AAHFOFFPBOO()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = true;
		walkingHome = false;
	}

	private void OIBDBLCLACB()
	{
		MagicBroomsManager.instance.magicBrooms.Add(this);
	}

	public void GDBOIIKDELL(FloorDirt DCGBADKLANM)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)target != (Object)null && (Object)(object)target.cleanerAssigned == (Object)(object)this)
		{
			target.cleanerAssigned = null;
		}
		target = DCGBADKLANM;
		if ((Object)(object)target != (Object)null)
		{
			target.cleanerAssigned = this;
			walkingToDirt = true;
			walkTo.KBEENHPEOAB(Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(((Component)target).transform.position)), AHDHLIECIGH: false);
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IOIPLDPKLIM));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OMGEMBNPKIE));
			NPCWalkTo nPCWalkTo3 = walkTo;
			nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(DKCOBAFFIEI));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void LCEEJFAPLMC()
	{
		isHome = true;
		walkingHome = false;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.NJACLLDHJBO(NPC.HGEBKKGJONI);
		}
	}

	private void GNFOCMPJIHE()
	{
		KIHIKAPPFFJ(null);
		walkingToDirt = false;
		walkingHome = true;
	}

	private void MCKAGJCIDPO()
	{
		if ((Object)(object)target != (Object)null)
		{
			if (!OIMHAMHKDOG)
			{
				OIMHAMHKDOG = false;
			}
			else
			{
				SetTarget(null);
				OIMHAMHKDOG = false;
			}
		}
		walkingToDirt = false;
	}

	private void OIFOIMGEFOF()
	{
		isHome = false;
		walkingToDirt = false;
		walkingHome = false;
		SetTarget(null);
		home.placeable.pickUpable = false;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.GLJKBIPDJGJ(NPC.HGFDBMAGOAN);
			onlineMagicBroom.KILHGNNMKBI(IHLGDCAIPLN: false);
		}
	}

	private void HKKEFOJMPPP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = false;
		walkingHome = true;
	}

	private void JNDELNPACPP()
	{
		isHome = true;
		walkingHome = false;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.ANNHIPOCGPB(NPC.HGEBKKGJONI);
		}
	}

	private void FBMGIOFPMFD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = ((Component)home).transform.position;
		walkingToDirt = false;
		walkingHome = false;
	}

	private void OFNKMGPKKBL()
	{
		isHome = false;
		walkingHome = true;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.GLJKBIPDJGJ(NPC.HGEBKKGJONI);
		}
	}

	private void BPLCGNPMJKP()
	{
		isHome = true;
		walkingToDirt = false;
		walkingHome = false;
		SetTarget(null);
		home.placeable.pickUpable = true;
		OnReturnBase();
		animator.SetTrigger(NPC.HGFDBMAGOAN);
		if (OnlineManager.IsMasterClient())
		{
			onlineMagicBroom.SendSetTrigger(NPC.HGFDBMAGOAN);
			onlineMagicBroom.SendSetPickupable(IHLGDCAIPLN: true);
		}
	}

	private void PKILOHICOMM()
	{
		isHome = true;
		walkingHome = true;
		OnLeaveBase();
		animator.SetTrigger(NPC.HGEBKKGJONI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineMagicBroom.HBFNPOIBCHG(NPC.HGEBKKGJONI);
		}
	}

	private void Update()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!active || OnlineManager.ClientOnline())
		{
			return;
		}
		if ((Object)(object)target == (Object)null)
		{
			if (!walkingToDirt && !isHome && !walkingHome)
			{
				home.placeable.pickUpable = false;
				walkingHome = true;
				walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)home).transform.position));
				NPCWalkTo nPCWalkTo = walkTo;
				nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BPLCGNPMJKP));
				NPCWalkTo nPCWalkTo2 = walkTo;
				nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(FBMGIOFPMFD));
				NPCWalkTo nPCWalkTo3 = walkTo;
				nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(KIFAGINEMIJ));
				walkTo.PEHELKCIECB();
				if (OnlineManager.IsMasterClient())
				{
					onlineMagicBroom.SendSetPickupable(IHLGDCAIPLN: false);
				}
			}
		}
		else if (OIMHAMHKDOG && target.Clean(1, 1f))
		{
			GDBCNMEILMG();
		}
	}

	private void LAABMDDEGCG()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!active || OnlineManager.ClientOnline())
		{
			return;
		}
		if ((Object)(object)target == (Object)null)
		{
			if (!walkingToDirt && !isHome && !walkingHome)
			{
				home.placeable.pickUpable = true;
				walkingHome = true;
				walkTo.DHFPOCOEONG(Vector2.op_Implicit(((Component)home).transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
				NPCWalkTo nPCWalkTo = walkTo;
				nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMODGAEEMCN));
				NPCWalkTo nPCWalkTo2 = walkTo;
				nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HKKEFOJMPPP));
				NPCWalkTo nPCWalkTo3 = walkTo;
				nPCWalkTo3.OnSuccessfulStart = (Action)Delegate.Combine(nPCWalkTo3.OnSuccessfulStart, new Action(AGACCKAEEDK));
				walkTo.EHDKLBLKBEO();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineMagicBroom.PIPPNNGLJJA(IHLGDCAIPLN: true);
				}
			}
		}
		else if (OIMHAMHKDOG && target.Clean(1, 1656f))
		{
			MHDCHBAMABI();
		}
	}

	private void JMLDAJEFMPE()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		if (!active)
		{
			return;
		}
		if (walkingToDirt)
		{
			if ((Object)(object)target != (Object)null)
			{
				if (walkTo.PAHDHACALOH(OEBNHGNJEJL: true))
				{
					walkingToDirt = false;
				}
			}
			else
			{
				walkingToDirt = false;
			}
		}
		else if (walkingHome && walkTo.GOACFCOOJLK())
		{
			JGIFMFBINNI();
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineMagicBroom) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			if (!onlineMagicBroom.placeable.FHEMHCEAICB && !onlineMagicBroom.KFAJLICFLIC())
			{
				onlineMagicBroom.OAMDOOJLHKG();
			}
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}
}
