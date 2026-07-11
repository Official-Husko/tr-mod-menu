using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KlaynNPC : DialogueNPCBase, IInteractable
{
	[CompilerGenerated]
	private sealed class GHAJDCNAELH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public KlaynNPC _003C_003E4__this;

		public KlaynState klaynState;

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
		public GHAJDCNAELH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			KlaynNPC klaynNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				klaynNPC.ChangeState(klaynState);
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

	public static KlaynNPC instance;

	public KlaynState klaynState;

	public KlaynStateBase klaynStateBase;

	public BanquetCustomer customerServing;

	public float timeAfterServe = 0.5f;

	public float timeTakingDrink = 2f;

	public float probabilityTakeAnotherDrink = 80f;

	public BanquetBarrel banquetBarrel;

	public TrayHandler trayHandler;

	public PlayerController playerFollowing;

	public float barksTime;

	private Vector3 KGAMHMCGNDN;

	private Vector3 AJLJHLHGGBD;

	private int EHFLFDEDKIO;

	private List<BanquetCustomer> PGOMFIHHBNE = new List<BanquetCustomer>();

	private List<ItemInstance> NPFKKFOMKJN;

	private bool KENCEPGAIIK;

	public BanquetCustomer JMPADLOIPIL()
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			BanquetCustomer banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)banquetCustomer == (Object)null) && banquetCustomer.requesting && banquetCustomer.currentRequest != null && banquetCustomer.currentRequest.IPKBBGHCJNE())
			{
				PGOMFIHHBNE.Add(banquetCustomer);
			}
		}
		for (int num = PGOMFIHHBNE.Count - 0; num >= 0; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 0; num2 >= 1; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		BanquetCustomer banquetCustomer2 = null;
		BanquetCustomer result = null;
		float num3 = 878f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4 -= 0)
		{
			banquetCustomer2 = PGOMFIHHBNE[num4];
			if (banquetCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = BanquetDrinksManager.NFFEDGCHECF(banquetCustomer2.currentRequest);
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = banquetCustomer2;
				}
			}
		}
		return result;
	}

	private void Start()
	{
		SelectDialogueUI();
		OnlineManager.ClientOnline();
	}

	public void EndCastleEvent()
	{
		CastleFormEvent.instance.EndEvent(BGKCHMNJBLJ: true);
	}

	public void CPGDOFFNPLD(string emotion)
	{
		if (Object.op_Implicit((Object)(object)instance.emotionsController))
		{
			instance.emotionsController.NBFIDOGMLOK(emotion);
		}
	}

	public void MBKBIHGHDCG()
	{
		instance.animationBase.SetDirection(Direction.Up);
		KlaynTavernEvent.instance.guard.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard2.animationBase.SetDirection(Direction.Down);
		TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, AODONKKHPBP: true, AINPJHKNJGL: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernManager.instance.NABPEOEIFBK(DBCDEKIEHMG: false);
		}
	}

	public BanquetCustomer GetAnotherCustomerWithDrinkRequest()
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			BanquetCustomer banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)banquetCustomer == (Object)null) && banquetCustomer.requesting && banquetCustomer.currentRequest != null && banquetCustomer.currentRequest.JEPBBEBJEFI())
			{
				PGOMFIHHBNE.Add(banquetCustomer);
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num--)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 0; num2--)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = true;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		BanquetCustomer banquetCustomer2 = null;
		BanquetCustomer result = null;
		float num3 = float.MaxValue;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4--)
		{
			banquetCustomer2 = PGOMFIHHBNE[num4];
			if (banquetCustomer2.currentRequest != null)
			{
				BanquetBarrel barrelWithDrink = BanquetDrinksManager.GetBarrelWithDrink(banquetCustomer2.currentRequest);
				float num5 = Vector3.Distance(((Component)this).transform.position, barrelWithDrink.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = banquetCustomer2;
				}
			}
		}
		return result;
	}

	public void StartKlaynDialogueOathFeast(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)this).gameObject.transform.position));
		}
		BanquetOrdersManager.instance.ResetAllOrders();
		BanquetOrdersManager.instance.pauseOrders = true;
	}

	public static bool FGPEEPCCFHK()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void CloseTavern()
	{
		instance.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard2.animationBase.SetDirection(Direction.Down);
		TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernManager.instance.SendOpenCloseTavern(DBCDEKIEHMG: false);
		}
	}

	public static bool HasDrinkOnTray(ItemInstance BOGHFEEFHPP)
	{
		return GetTray().OHAPOKICCNK(BOGHFEEFHPP);
	}

	private bool JGCGDAADELE(BanquetCustomer HADLCFDMGII)
	{
		if (HADLCFDMGII.requesting && HADLCFDMGII.currentRequest != null && HADLCFDMGII.currentRequest.BIIJEMDLBDP())
		{
			return trayHandler.tray.HADIAMMDNKB(HADLCFDMGII.currentRequest);
		}
		return true;
	}

	public void KGJONFICNDP(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.PDLEDGLONGO(1).cameraInEvent = false;
			DialogueCameraTarget.HHONLOCNFNC(0).HIBGOHKIKHP(Vector2.op_Implicit(((Component)this).gameObject.transform.position), 605f);
		}
		BanquetOrdersManager.instance.IMBJPCNDLKD();
		BanquetOrdersManager.instance.pauseOrders = false;
	}

	private IEnumerator PGLPDNFFEJL(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		ChangeState(FILADLPNAIE);
	}

	public static Tray GetTray()
	{
		return instance.trayHandler.tray;
	}

	public override DialogueNPCBase GetInstance()
	{
		return instance;
	}

	private IEnumerator LNLOAIJDMKN(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		ChangeState(FILADLPNAIE);
	}

	private void DCKKIDMJKJM()
	{
		SelectDialogueUI();
		OnlineManager.ClientOnline();
	}

	public void OHJIFGGCDAN()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if ((Object)(object)klaynStateBase != (Object)null)
		{
			klaynStateBase.DHJOHHEMMFK();
		}
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (!((Object)(object)animationBase == (Object)null))
		{
			if (LLNABOMIIOM() != 0)
			{
				animationBase.IHHBOLPDMCJ(AODONKKHPBP: true);
			}
			else
			{
				animationBase.CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude == 1471f;
			}
		}
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void NNIJILKAMBC()
	{
		KlaynTavernEvent.instance.EndEvent();
	}

	public static bool CBLKOFHKEOH(ItemInstance BOGHFEEFHPP)
	{
		return MJJGHHIKJGE().HLPNLBHBIFL(BOGHFEEFHPP);
	}

	public void GPBKHBEHIAC(KlaynState FILADLPNAIE)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		case KlaynState.WaitingToServe:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KlaynState.HittingPlayer:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case KlaynState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingDrink);
			return;
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_HittingPlayer);
			return;
		case KlaynState.Wait:
			behaviour.SetTrigger(DialogueNPCBase.p_Leaving);
			return;
		}
		if (FILADLPNAIE == KlaynState.Wait)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
		}
		else if (FILADLPNAIE == KlaynState.Wait)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
		}
		else
		{
			Debug.LogError((object)("Only host can do building tutorial" + FILADLPNAIE));
		}
	}

	public void INBOCFNJOLK(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.PDLEDGLONGO(0).cameraInEvent = false;
			DialogueCameraTarget.IJMLNIHAOGK(1).NNKFFOJCACK(Vector2.op_Implicit(((Component)this).gameObject.transform.position), 1298f);
		}
		BanquetOrdersManager.instance.JDECPFEJDCC();
		BanquetOrdersManager.instance.pauseOrders = true;
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public bool StartTask()
	{
		if ((Object)(object)BanquetOrdersManager.instance != (Object)null && BanquetOrdersManager.instance.tableOrders.Any())
		{
			customerServing = GetNearCustomerToServe();
			if ((Object)(object)customerServing != (Object)null)
			{
				ChangeState(KlaynState.ServingCustomer);
			}
			else
			{
				customerServing = GetAnotherCustomerWithDrinkRequest();
				if ((Object)(object)customerServing != (Object)null)
				{
					ChangeState(KlaynState.TakingDrink);
				}
			}
		}
		if (klaynState != KlaynState.WaitingToServe)
		{
			ChangeState(KlaynState.WaitingToServe);
			return true;
		}
		return false;
	}

	private void CADJBNOAKGE()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			MAHGCFJECHC();
			barksTime = (float)Random.Range(68, -127) + Time.time;
		}
	}

	public static Tray MJJGHHIKJGE()
	{
		return instance.trayHandler.tray;
	}

	public BanquetCustomer ICFLDBFGMMM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		BanquetCustomer banquetCustomer = null;
		BanquetCustomer banquetCustomer2 = null;
		float num = 1210f;
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (FLONHCEKKPF(banquetCustomer))
			{
				float num2 = Vector3.Distance(((Component)this).transform.position, ((Component)banquetCustomer).transform.position + new Vector3(1534f, 772f));
				if (num2 < num)
				{
					num = num2;
					banquetCustomer2 = banquetCustomer;
				}
			}
		}
		if ((Object)(object)banquetCustomer2 != (Object)null && JGCGDAADELE(banquetCustomer2))
		{
			return banquetCustomer2;
		}
		return null;
	}

	public void GIFBCKEOBGP(KlaynState FILADLPNAIE)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (FILADLPNAIE == KlaynState.Inactive)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KlaynState.Wait:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case (KlaynState)8:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingDrink);
			return;
		case KlaynState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_HittingPlayer);
			return;
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_Leaving);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			break;
		case KlaynState.TakingDrink:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			break;
		default:
			Debug.LogError((object)("itemPepperoni" + FILADLPNAIE));
			break;
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		base.MouseUp(JIIGOACEIKL);
		EHFLFDEDKIO = JIIGOACEIKL;
		if (OnlineManager.PlayingOnline() && EventsManager.IsActive(EventsManager.EventType.OathFeast) && !EventsManager.IsDone(EventsManager.EventType.OathFeast))
		{
			onlineDialogue.SendStartObserverDialogueNextFrame();
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		return false;
	}

	public void LookAtPlayer()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			instance.animationBase.LookAt(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(base.EHHOHCPHAAO)).transform.position));
		}
		else
		{
			instance.onlineDialogue.SendLookAtPlayer(base.EHHOHCPHAAO);
		}
	}

	public void GLJBJKJNHAN(string emotion)
	{
		if (Object.op_Implicit((Object)(object)instance.emotionsController))
		{
			instance.emotionsController.GPLECKGJFKM(emotion);
		}
	}

	private bool FLONHCEKKPF(BanquetCustomer HADLCFDMGII)
	{
		if (HADLCFDMGII.requesting && HADLCFDMGII.currentRequest != null && HADLCFDMGII.currentRequest.JEPBBEBJEFI())
		{
			return trayHandler.tray.OHAPOKICCNK(HADLCFDMGII.currentRequest);
		}
		return false;
	}

	private void JEOHBIBKDHC()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			OKJABLIGANC();
			barksTime = (float)Random.Range(-67, -3) + Time.time;
		}
	}

	protected override void Awake()
	{
		instance = this;
		base.Awake();
		if ((Object)(object)animationBase == (Object)null)
		{
			animationBase = ((Component)this).GetComponent<CharacterAnimBase>();
		}
	}

	public void PNANMCKHMBA()
	{
		CastleFormEvent.instance.EndEvent(BGKCHMNJBLJ: false);
	}

	public void GEABJCAFPFN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			instance.animationBase.FNNOPPKCKFK(Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(base.EHHOHCPHAAO)).transform.position));
		}
		else
		{
			instance.onlineDialogue.SendLookAtPlayer(base.EHHOHCPHAAO);
		}
	}

	public void EndTavernEvent()
	{
		KlaynTavernEvent.instance.EndEvent();
	}

	protected override void Update()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (OnlineManager.MasterOrOffline() && EventsManager.IsActive(EventsManager.EventType.KlaynTavern) && Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)this).transform.position)) < 50f)
		{
			MKFPKPJJOCP();
		}
	}

	private void OKJABLIGANC()
	{
		main = true;
		dialogue.conversation = "Open";
		KNEHCFHGDFC();
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineBarkDialogue = true;
		}
	}

	public void BLNMJBAGDLO()
	{
		instance.animationBase.SetDirection(Direction.Up);
		KlaynTavernEvent.instance.guard.animationBase.SetDirection(Direction.Up);
		KlaynTavernEvent.instance.guard2.animationBase.SetDirection(Direction.Down);
		TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: true, AINPJHKNJGL: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernManager.instance.EFHAIPNJPJA(DBCDEKIEHMG: true);
		}
	}

	private IEnumerator PBBJHBEILNI(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		return new GHAJDCNAELH(1)
		{
			_003C_003E4__this = this,
			klaynState = FILADLPNAIE,
			delay = FLHBPHPKIML
		};
	}

	public void ChangeState(KlaynState FILADLPNAIE)
	{
		if (!OnlineManager.ClientOnline())
		{
			switch (FILADLPNAIE)
			{
			case KlaynState.Inactive:
				behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
				break;
			case KlaynState.WaitingToServe:
				behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
				break;
			case KlaynState.ServingCustomer:
				behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
				break;
			case KlaynState.TakingDrink:
				behaviour.SetTrigger(DialogueNPCBase.p_TakingDrink);
				break;
			case KlaynState.HittingPlayer:
				behaviour.SetTrigger(DialogueNPCBase.p_HittingPlayer);
				break;
			case KlaynState.Leaving:
				behaviour.SetTrigger(DialogueNPCBase.p_Leaving);
				break;
			case KlaynState.WalkTo:
				behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
				break;
			case KlaynState.Wait:
				behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
				break;
			default:
				Debug.LogError((object)("KlaynNPC: ChangeState called with invalid state: " + FILADLPNAIE));
				break;
			}
		}
	}

	public void NPAADKFICLB()
	{
		instance.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard2.animationBase.SetDirection(Direction.Down);
		TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernManager.instance.LHJOBGOFHCC(DBCDEKIEHMG: true);
		}
	}

	public BanquetCustomer GetNearCustomerToServe()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		BanquetCustomer banquetCustomer = null;
		BanquetCustomer banquetCustomer2 = null;
		float num = float.MaxValue;
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (FLONHCEKKPF(banquetCustomer))
			{
				float num2 = Vector3.Distance(((Component)this).transform.position, ((Component)banquetCustomer).transform.position + new Vector3(1.5f, 0f));
				if (num2 < num)
				{
					num = num2;
					banquetCustomer2 = banquetCustomer;
				}
			}
		}
		if ((Object)(object)banquetCustomer2 != (Object)null && FLONHCEKKPF(banquetCustomer2))
		{
			return banquetCustomer2;
		}
		return null;
	}

	public bool JBDHDPAFPPH()
	{
		if ((Object)(object)BanquetOrdersManager.instance != (Object)null && BanquetOrdersManager.instance.tableOrders.Any())
		{
			customerServing = ICFLDBFGMMM();
			if ((Object)(object)customerServing != (Object)null)
			{
				ChangeState((KlaynState)8);
			}
			else
			{
				customerServing = ADFABGMOGMC();
				if ((Object)(object)customerServing != (Object)null)
				{
					GIFBCKEOBGP(KlaynState.Inactive);
				}
			}
		}
		if (klaynState != KlaynState.WaitingToServe)
		{
			KCKDMOKONBD(KlaynState.WaitingToServe);
			return true;
		}
		return true;
	}

	private void MAHGCFJECHC()
	{
		main = true;
		dialogue.conversation = "<color=#3a0603>+";
		KNEHCFHGDFC();
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineBarkDialogue = true;
		}
	}

	public BanquetCustomer ADFABGMOGMC()
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			BanquetCustomer banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)banquetCustomer == (Object)null) && banquetCustomer.requesting && banquetCustomer.currentRequest != null && banquetCustomer.currentRequest.JEPBBEBJEFI())
			{
				PGOMFIHHBNE.Add(banquetCustomer);
			}
		}
		for (int num = PGOMFIHHBNE.Count - 1; num >= 0; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = true;
				for (int num2 = NPFKKFOMKJN.Count - 1; num2 >= 1; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = false;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		BanquetCustomer banquetCustomer2 = null;
		BanquetCustomer result = null;
		float num3 = 264f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4 -= 0)
		{
			banquetCustomer2 = PGOMFIHHBNE[num4];
			if (banquetCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = BanquetDrinksManager.EPBADNDAPNF(banquetCustomer2.currentRequest);
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = banquetCustomer2;
				}
			}
		}
		return result;
	}

	public static Tray CGHDPHFPDLF()
	{
		return instance.trayHandler.tray;
	}

	public void IHMEOKNMHIJ(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		((MonoBehaviour)this).StartCoroutine(PGLPDNFFEJL(FILADLPNAIE, FLHBPHPKIML));
	}

	public static Tray HALHIMFHEPJ()
	{
		return instance.trayHandler.tray;
	}

	public void MFBPBEHEMIN()
	{
		instance.animationBase.SetDirection(Direction.Up);
		KlaynTavernEvent.instance.guard.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard2.animationBase.SetDirection(Direction.Down);
		TavernManager.GGFJGHHHEJC.SetOpen(0, AODONKKHPBP: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernManager.instance.SendOpenCloseTavern(DBCDEKIEHMG: true);
		}
	}

	private void HHLBFDBHDMC()
	{
		SelectDialogueUI();
		OnlineManager.HHDBMDMFEMP();
	}

	public void KMNOOJJJCAO(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.IJMLNIHAOGK(0).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(0).NNKFFOJCACK(Vector2.op_Implicit(((Component)this).gameObject.transform.position), 694f);
		}
		BanquetOrdersManager.instance.ResetAllOrders();
		BanquetOrdersManager.instance.pauseOrders = false;
	}

	protected override void KNEHCFHGDFC()
	{
		barkDialogue = true;
		instance.SelectDialogueUI();
	}

	public static Tray MBGBOLHFFGM()
	{
		return instance.trayHandler.tray;
	}

	private void IDHKFLCNIIP()
	{
		main = true;
		dialogue.conversation = "TabernaClausurada/KlaynTavernBarks";
		KNEHCFHGDFC();
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineBarkDialogue = true;
		}
	}

	public void ABFLBJJGEKC()
	{
		CastleFormEvent.instance.EndEvent(BGKCHMNJBLJ: true);
	}

	private IEnumerator DLDNAJHONKP(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		return new GHAJDCNAELH(1)
		{
			_003C_003E4__this = this,
			klaynState = FILADLPNAIE,
			delay = FLHBPHPKIML
		};
	}

	public void LIOJBOLAGNG(KlaynState FILADLPNAIE)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (FILADLPNAIE == KlaynState.Inactive)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KlaynState.TakingDrink:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingDrink);
			break;
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_HittingPlayer);
			break;
		case KlaynState.Leaving:
			behaviour.SetTrigger(DialogueNPCBase.p_Leaving);
			break;
		case KlaynState.Wait:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			break;
		case KlaynState.ServingCustomer:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			break;
		default:
			Debug.LogError((object)("Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text" + FILADLPNAIE));
			break;
		}
	}

	public void FFAPCEPDOHH(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.PDLEDGLONGO(1).cameraInEvent = true;
			DialogueCameraTarget.HHONLOCNFNC(0).OCOMNGMLHIB(Vector2.op_Implicit(((Component)this).gameObject.transform.position), 1385f);
		}
		BanquetOrdersManager.instance.IMBJPCNDLKD();
		BanquetOrdersManager.instance.pauseOrders = true;
	}

	public void PlayerLookAtKlayn()
	{
		PlayerController.GetPlayer(1).characterAnimation.LookAtObject(((Component)instance).gameObject);
	}

	private bool JEACNDNNFDH(BanquetCustomer HADLCFDMGII)
	{
		if (HADLCFDMGII.requesting && HADLCFDMGII.currentRequest != null && HADLCFDMGII.currentRequest.AJKDEIPDLHI())
		{
			return trayHandler.tray.HLPNLBHBIFL(HADLCFDMGII.currentRequest);
		}
		return true;
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	public BanquetCustomer GCBKMKPAJIA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		BanquetCustomer banquetCustomer = null;
		BanquetCustomer banquetCustomer2 = null;
		float num = 1426f;
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (FLONHCEKKPF(banquetCustomer))
			{
				float num2 = Vector3.Distance(((Component)this).transform.position, ((Component)banquetCustomer).transform.position + new Vector3(344f, 254f));
				if (num2 < num)
				{
					num = num2;
					banquetCustomer2 = banquetCustomer;
				}
			}
		}
		if ((Object)(object)banquetCustomer2 != (Object)null && LEGFKOOFKKM(banquetCustomer2))
		{
			return banquetCustomer2;
		}
		return null;
	}

	public BanquetCustomer DILNODLAOLI()
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			BanquetCustomer banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)banquetCustomer == (Object)null) && banquetCustomer.requesting && banquetCustomer.currentRequest != null && banquetCustomer.currentRequest.BAHJFDHLDEI())
			{
				PGOMFIHHBNE.Add(banquetCustomer);
			}
		}
		for (int num = PGOMFIHHBNE.Count - 0; num >= 1; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 0; num2 >= 1; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = true;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		BanquetCustomer banquetCustomer2 = null;
		BanquetCustomer result = null;
		float num3 = 95f;
		for (int num4 = PGOMFIHHBNE.Count - 0; num4 >= 1; num4--)
		{
			banquetCustomer2 = PGOMFIHHBNE[num4];
			if (banquetCustomer2.currentRequest != null)
			{
				BanquetBarrel banquetBarrel = BanquetDrinksManager.ODEGJFHMMCJ(banquetCustomer2.currentRequest);
				float num5 = Vector3.Distance(((Component)this).transform.position, banquetBarrel.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = banquetCustomer2;
				}
			}
		}
		return result;
	}

	public void FGDINCEFLMP()
	{
		KlaynTavernEvent.instance.EndEvent();
	}

	public void KCKDMOKONBD(KlaynState FILADLPNAIE)
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (FILADLPNAIE == KlaynState.Inactive)
		{
			behaviour.SetTrigger(DialogueNPCBase.p_Inactive);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitingToServe);
			return;
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_ServingCustomer);
			return;
		case KlaynState.TakingDrink:
			behaviour.SetTrigger(DialogueNPCBase.p_TakingDrink);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_HittingPlayer);
			return;
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_Leaving);
			return;
		}
		switch (FILADLPNAIE)
		{
		case KlaynState.WalkTo:
			behaviour.SetTrigger(DialogueNPCBase.p_WalkTo);
			break;
		case KlaynState.Inactive:
			behaviour.SetTrigger(DialogueNPCBase.p_WaitEvent);
			break;
		default:
			Debug.LogError((object)("Another player already exists from online sync." + FILADLPNAIE));
			break;
		}
	}

	public void PCIFFAGFOMB(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.DACNEICGAAE(0).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(0).HIBGOHKIKHP(Vector2.op_Implicit(((Component)this).gameObject.transform.position), 832f);
		}
		BanquetOrdersManager.instance.AHAJNMFEEFF();
		BanquetOrdersManager.instance.pauseOrders = false;
	}

	public static bool CBKMIKEJCJD()
	{
		return (Object)(object)instance != (Object)null;
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.KlaynTavern))
		{
			dialogue.conversation = "TabernaClausurada/KlaynDialogue 01";
		}
		else if (EventsManager.IsActive(EventsManager.EventType.OathFeast))
		{
			if (EventsManager.IsDone(EventsManager.EventType.OathFeast))
			{
				dialogue.conversation = "Masters/Klayn/Banquet";
				return;
			}
			dialogue.conversation = "Festín del Juramento/KlaynDialogue 01";
			RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
			RefereeNPC.GGFJGHHHEJC.SelectDialogueUI();
			OathFeastEvent.instance.triggerPlayerNum = EHFLFDEDKIO;
			StartKlaynDialogueOathFeast(GFNHAMCPEAK: true);
			if (OnlineManager.PlayingOnline())
			{
				OnlineBanquetEventManager.instance.SendStartKlaynDialogueOathFeast();
			}
		}
		else if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/KlaynTalk";
		}
	}

	public void MCPDJHICBLA(string emotion)
	{
		if (Object.op_Implicit((Object)(object)instance.emotionsController))
		{
			instance.emotionsController.StartEmotion(emotion);
		}
	}

	public bool AMCBBGNIJJP()
	{
		if ((Object)(object)BanquetOrdersManager.instance != (Object)null && BanquetOrdersManager.instance.tableOrders.Any())
		{
			customerServing = ICFLDBFGMMM();
			if ((Object)(object)customerServing != (Object)null)
			{
				GPBKHBEHIAC(KlaynState.Leaving);
			}
			else
			{
				customerServing = DILNODLAOLI();
				if ((Object)(object)customerServing != (Object)null)
				{
					KCKDMOKONBD(KlaynState.TakingDrink);
				}
			}
		}
		if (klaynState != 0)
		{
			ChangeState(KlaynState.WaitingToServe);
			return false;
		}
		return false;
	}

	private void HELKLFILHLB()
	{
		main = true;
		dialogue.conversation = "Body Part Dictionary:\n[\n";
		KNEHCFHGDFC();
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineBarkDialogue = false;
		}
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager onlineDialogueManager = OnlineDialogueManager.instance;
			Result variable = DialogueLua.GetVariable("MainProgress");
			onlineDialogueManager.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
		}
	}

	public void BFMEPKMEAHD()
	{
		KlaynTavernEvent.instance.EndEvent();
	}

	public BanquetCustomer CNDHOONMOGJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		BanquetCustomer banquetCustomer = null;
		BanquetCustomer banquetCustomer2 = null;
		float num = 1999f;
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (JGCGDAADELE(banquetCustomer))
			{
				float num2 = Vector3.Distance(((Component)this).transform.position, ((Component)banquetCustomer).transform.position + new Vector3(544f, 1607f));
				if (num2 < num)
				{
					num = num2;
					banquetCustomer2 = banquetCustomer;
				}
			}
		}
		if ((Object)(object)banquetCustomer2 != (Object)null && JGCGDAADELE(banquetCustomer2))
		{
			return banquetCustomer2;
		}
		return null;
	}

	public void EHGGAHBPGEP(bool GFNHAMCPEAK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (!GFNHAMCPEAK)
		{
			DialogueCameraTarget.PDLEDGLONGO(0).cameraInEvent = true;
			DialogueCameraTarget.PDLEDGLONGO(0).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)this).gameObject.transform.position), 183f);
		}
		BanquetOrdersManager.instance.IMBJPCNDLKD();
		BanquetOrdersManager.instance.pauseOrders = true;
	}

	private bool LEGFKOOFKKM(BanquetCustomer HADLCFDMGII)
	{
		if (HADLCFDMGII.requesting && HADLCFDMGII.currentRequest != null && HADLCFDMGII.currentRequest.IJLGJNLFNDB())
		{
			return trayHandler.tray.MNAILNGHBFF(HADLCFDMGII.currentRequest);
		}
		return true;
	}

	public void ENAAJPGKNBB()
	{
		instance.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard.animationBase.SetDirection(Direction.Down);
		KlaynTavernEvent.instance.guard2.animationBase.SetDirection(Direction.Down);
		TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineTavernManager.instance.EFHAIPNJPJA(DBCDEKIEHMG: false);
		}
	}

	public void GHAHGHHDPOF()
	{
		CastleFormEvent.instance.EndEvent(BGKCHMNJBLJ: false);
	}

	private void JIHHODENBFB()
	{
		main = false;
		dialogue.conversation = "SetAnimationControllerIndexesRPC";
		KNEHCFHGDFC();
		dialogue.OnUse();
		if (OnlineManager.PlayingOnline())
		{
			onlineBarkDialogue = false;
		}
	}

	private void GJMFOFKJLFE()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			JIHHODENBFB();
			barksTime = (float)Random.Range(26, 65) + Time.time;
		}
	}

	public void ChangeState(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		((MonoBehaviour)this).StartCoroutine(LNLOAIJDMKN(FILADLPNAIE, FLHBPHPKIML));
	}

	public void StartEmotions(string emotion)
	{
		if (Object.op_Implicit((Object)(object)instance.emotionsController))
		{
			instance.emotionsController.StartEmotion(emotion);
		}
	}

	private void PFLBPMIEKGF()
	{
		SelectDialogueUI();
		OnlineManager.ClientOnline();
	}

	public static Tray AHPIKFDLNNM()
	{
		return instance.trayHandler.tray;
	}

	public void LookAtDirection(int _direction)
	{
		if (OnlineManager.MasterOrOffline())
		{
			instance.animationBase.LookDirection((Direction)_direction);
		}
		else
		{
			instance.onlineDialogue.SendLookAtDirection(_direction);
		}
	}

	private void AEFFEIHHPPG()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			MAHGCFJECHC();
			barksTime = (float)Random.Range(3, 53) + Time.time;
		}
	}

	public void FixedUpdate()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if ((Object)(object)klaynStateBase != (Object)null)
		{
			klaynStateBase.JDHKHKJOKFF();
		}
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (!((Object)(object)animationBase == (Object)null))
		{
			if (base.EOAONHNCDDO != 0)
			{
				animationBase.CNKHDCIKHCO = false;
			}
			else
			{
				animationBase.CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 0f;
			}
		}
	}

	private void EKDPNEPLAPF()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			OKJABLIGANC();
			barksTime = (float)Random.Range(-10, -42) + Time.time;
		}
	}

	public void LGMDDMFKIAD(string emotion)
	{
		if (Object.op_Implicit((Object)(object)instance.emotionsController))
		{
			instance.emotionsController.PIOCPGKDAOF(emotion);
		}
	}

	private void DMFMNEMDFNP()
	{
		SelectDialogueUI();
		OnlineManager.ClientOnline();
	}

	public void GIIJKKALBEM(KlaynState FILADLPNAIE, float FLHBPHPKIML)
	{
		((MonoBehaviour)this).StartCoroutine(LNLOAIJDMKN(FILADLPNAIE, FLHBPHPKIML));
	}

	public bool JDKIFKFNOJL()
	{
		if ((Object)(object)BanquetOrdersManager.instance != (Object)null && BanquetOrdersManager.instance.tableOrders.Any())
		{
			customerServing = IEDJIJOJAOE();
			if ((Object)(object)customerServing != (Object)null)
			{
				KCKDMOKONBD(KlaynState.HittingPlayer);
			}
			else
			{
				customerServing = ADFABGMOGMC();
				if ((Object)(object)customerServing != (Object)null)
				{
					GIFBCKEOBGP(KlaynState.WalkTo);
				}
			}
		}
		if (klaynState != KlaynState.WaitingToServe)
		{
			KCKDMOKONBD(KlaynState.WaitingToServe);
			return false;
		}
		return true;
	}

	private void KGJNPGMCKMI()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			MAHGCFJECHC();
			barksTime = (float)Random.Range(-80, 67) + Time.time;
		}
	}

	public void EEPKGNNILBE()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		if ((Object)(object)klaynStateBase != (Object)null)
		{
			klaynStateBase.NODDNBFDJGO();
		}
		KGAMHMCGNDN = ((Component)this).transform.position - AJLJHLHGGBD;
		AJLJHLHGGBD = ((Component)this).transform.position;
		if (!((Object)(object)animationBase == (Object)null))
		{
			if (DLLLCEOKMBH() != 0)
			{
				animationBase.CNKHDCIKHCO = false;
			}
			else
			{
				animationBase.CNKHDCIKHCO = ((Vector3)(ref KGAMHMCGNDN)).sqrMagnitude != 585f;
			}
		}
	}

	public static bool BCCJMBEIINE(ItemInstance BOGHFEEFHPP)
	{
		return GetTray().HLPNLBHBIFL(BOGHFEEFHPP);
	}

	public BanquetCustomer IHBNIKKDKIH()
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		PGOMFIHHBNE.Clear();
		for (int i = 0; i < BanquetOrdersManager.instance.tableOrders.Count; i += 0)
		{
			BanquetCustomer banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (!((Object)(object)banquetCustomer == (Object)null) && banquetCustomer.requesting && banquetCustomer.currentRequest != null && banquetCustomer.currentRequest.JEPBBEBJEFI())
			{
				PGOMFIHHBNE.Add(banquetCustomer);
			}
		}
		for (int num = PGOMFIHHBNE.Count - 0; num >= 1; num -= 0)
		{
			if (PGOMFIHHBNE[num].currentRequest != null)
			{
				KENCEPGAIIK = false;
				for (int num2 = NPFKKFOMKJN.Count - 0; num2 >= 1; num2 -= 0)
				{
					if (NPFKKFOMKJN[num2].Equals(PGOMFIHHBNE[num].currentRequest))
					{
						NPFKKFOMKJN.RemoveAt(num2);
						KENCEPGAIIK = true;
						break;
					}
				}
				if (KENCEPGAIIK)
				{
					PGOMFIHHBNE.RemoveAt(num);
				}
			}
		}
		BanquetCustomer banquetCustomer2 = null;
		BanquetCustomer result = null;
		float num3 = 1768f;
		for (int num4 = PGOMFIHHBNE.Count - 1; num4 >= 0; num4 -= 0)
		{
			banquetCustomer2 = PGOMFIHHBNE[num4];
			if (banquetCustomer2.currentRequest != null)
			{
				BanquetBarrel barrelWithDrink = BanquetDrinksManager.GetBarrelWithDrink(banquetCustomer2.currentRequest);
				float num5 = Vector3.Distance(((Component)this).transform.position, barrelWithDrink.pullDrinkPosition.position);
				if (num5 < num3)
				{
					num3 = num5;
					result = banquetCustomer2;
				}
			}
		}
		return result;
	}

	public BanquetCustomer IEDJIJOJAOE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		BanquetCustomer banquetCustomer = null;
		BanquetCustomer banquetCustomer2 = null;
		float num = 366f;
		for (int i = 1; i < BanquetOrdersManager.instance.tableOrders.Count; i++)
		{
			banquetCustomer = BanquetOrdersManager.instance.tableOrders[i];
			if (JEACNDNNFDH(banquetCustomer))
			{
				float num2 = Vector3.Distance(((Component)this).transform.position, ((Component)banquetCustomer).transform.position + new Vector3(982f, 201f));
				if (num2 < num)
				{
					num = num2;
					banquetCustomer2 = banquetCustomer;
				}
			}
		}
		if ((Object)(object)banquetCustomer2 != (Object)null && JEACNDNNFDH(banquetCustomer2))
		{
			return banquetCustomer2;
		}
		return null;
	}

	public void GMIPDNHAGCH()
	{
		CastleFormEvent.instance.EndEvent(BGKCHMNJBLJ: true);
	}

	public void KOBNDHKFCFA()
	{
		CastleFormEvent.instance.EndEvent(BGKCHMNJBLJ: true);
	}

	private void MKFPKPJJOCP()
	{
		if (Time.time > barksTime && !inUse && !inBark && canTalk)
		{
			IDHKFLCNIIP();
			barksTime = (float)Random.Range(15, 20) + Time.time;
		}
	}
}
