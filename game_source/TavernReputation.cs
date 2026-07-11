using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class TavernReputation : MonoBehaviour, ISingleton
{
	[Serializable]
	public struct RecipeFragmentsGiven
	{
		public int milestoneMax;

		public int recipeFragments;
	}

	[CompilerGenerated]
	private sealed class OPNJHJCHHKG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernReputation _003C_003E4__this;

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
		public OPNJHJCHHKG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			TavernReputation tavernReputation = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					if (GGFJGHHHEJC.ODAOIJCOFMF != tavernReputation.HGDPDIFOJLO && (Object)(object)LettersManager.instance != (Object)null)
					{
						LettersManager.instance.SendUndeliveredLetters(tavernReputation.HGDPDIFOJLO, GGFJGHHHEJC.ODAOIJCOFMF);
					}
					tavernReputation.HGDPDIFOJLO = GGFJGHHHEJC.ODAOIJCOFMF;
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

	private static TavernReputation IADEMLIIDPC;

	public static Action<int> OnTavernRepMilestoneChanged = delegate
	{
	};

	[SerializeField]
	private int _milestone;

	[SerializeField]
	private float _progress;

	[SerializeField]
	private float percentageMinMaxCustomers = 0.3f;

	public RecipeFragmentsGiven[] recipeFragmentsGivenPerMilestone;

	private int IJHFDFFGKKG;

	private int FPPNNKNCKGJ;

	private bool IADDJIBCBID;

	private int HGDPDIFOJLO;

	public GameObject repText;

	public static TavernReputation GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernReputation>();
			}
			return IADEMLIIDPC;
		}
	}

	private float COAPHJJHNIO
	{
		get
		{
			return _progress;
		}
		set
		{
			_progress = value;
			TavernManagerUI.SetRepBar(_progress);
		}
	}

	private int ODAOIJCOFMF
	{
		get
		{
			return _milestone;
		}
		set
		{
			if (MiscSetup.isDemo && value > MiscSetup.maxDemoRep)
			{
				return;
			}
			if (_milestone != value)
			{
				_milestone = Math.Min(RepUnlocksManager.MaxMilstone, value);
				if (_milestone != 0 && IADDJIBCBID)
				{
					RepRewardPopUp.GGFJGHHHEJC.awaitingCompleteList.Add(ReputationDBAccessor.GetReputation(_milestone));
					RepUnlocksManager.RepUnlocked(ReputationDBAccessor.GetReputation(_milestone));
					IADDJIBCBID = false;
				}
				OnTavernRepMilestoneChanged(_milestone);
			}
			TavernManagerUI.SetMilestoneNumber(_milestone);
			if (_milestone < ReputationDBAccessor.GetAllReputations().Length)
			{
				ChangeMaxReputation(ReputationDBAccessor.GetReputation(_milestone).repMax);
			}
		}
	}

	public int SavedMaxReputationOffline()
	{
		if (OnlineManager.MasterOrOffline())
		{
			HGDPDIFOJLO = GGFJGHHHEJC.ODAOIJCOFMF;
		}
		return HGDPDIFOJLO;
	}

	public int DMPAAHEGCKE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			HGDPDIFOJLO = LANAINBEMCM().JJNMBCFBINA();
		}
		return HGDPDIFOJLO;
	}

	[ContextMenu("ShowRepText")]
	public static RepText ShowRepText(int CDGJMCKAHAM, Vector2 IMOBLFMHKOD, Transform DMBHHLKMHOH, bool GEPGIILHDPA = true)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		RepText component = Object.Instantiate<GameObject>(GGFJGHHHEJC.repText, Vector2.op_Implicit(IMOBLFMHKOD + (Vector2)(((Object)(object)DMBHHLKMHOH != (Object)null) ? new Vector2(-0.25f, 1f) : Vector2.zero)), Quaternion.identity, DMBHHLKMHOH).GetComponent<RepText>();
		component.ELMCPNGHKOI = CDGJMCKAHAM;
		component.ShowIcon(GEPGIILHDPA);
		return component;
	}

	public static void MANNDCENLCE(int JGLPCDLLCKI)
	{
		LANAINBEMCM().FPPNNKNCKGJ = JGLPCDLLCKI;
		TavernManagerUI.UpdateRepText(LANAINBEMCM().IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public static int GLAOJNJNPBA(int NGNLHPBMAMG, float GHAPOIFBPEJ)
	{
		return Mathf.RoundToInt((float)NGNLHPBMAMG * GGFJGHHHEJC.percentageMinMaxCustomers * GHAPOIFBPEJ);
	}

	public static int GetCustomersExtraPerService(int NGNLHPBMAMG, float GHAPOIFBPEJ)
	{
		return Mathf.RoundToInt((float)NGNLHPBMAMG * GGFJGHHHEJC.percentageMinMaxCustomers * GHAPOIFBPEJ);
	}

	public static int HHBGBOAFNNP()
	{
		int customersCapacity = ReputationDBAccessor.KICMFFLPKAM(LANAINBEMCM()._milestone).customersCapacity;
		int num = NJPFOLPMDIA(customersCapacity);
		return Mathf.Max(-59, customersCapacity + num + GLAOJNJNPBA(customersCapacity, TavernServiceManager.HKBJIIJHBJB().GetWeekStats().AOHJJBBJAAJ()));
	}

	public static int IIKECMJHCGO(int NGNLHPBMAMG, float GHAPOIFBPEJ)
	{
		return Mathf.RoundToInt((float)NGNLHPBMAMG * GGFJGHHHEJC.percentageMinMaxCustomers * GHAPOIFBPEJ);
	}

	public static void AddReputationPoints(int HIHGMPIKGIF)
	{
		if (HIHGMPIKGIF > 0)
		{
			Debug.Log((object)$"[REP DIAGNOSTIC] AddReputationPoints({HIHGMPIKGIF}) | milestone: {GGFJGHHHEJC.ODAOIJCOFMF} | exp: {GGFJGHHHEJC.IJHFDFFGKKG}/{GGFJGHHHEJC.FPPNNKNCKGJ}\n{new StackTrace(fNeedFileInfo: true).ToString()}");
		}
		if (GGFJGHHHEJC.ODAOIJCOFMF == RepUnlocksManager.MaxMilstone && GGFJGHHHEJC.IJHFDFFGKKG >= GGFJGHHHEJC.FPPNNKNCKGJ && Math.Sign(HIHGMPIKGIF) > 0)
		{
			return;
		}
		GGFJGHHHEJC.IJHFDFFGKKG = Math.Max(GGFJGHHHEJC.IJHFDFFGKKG + HIHGMPIKGIF, 0);
		if (GGFJGHHHEJC.IJHFDFFGKKG >= GGFJGHHHEJC.FPPNNKNCKGJ)
		{
			if (MiscSetup.isDemo && GGFJGHHHEJC.ODAOIJCOFMF >= MiscSetup.maxDemoRep)
			{
				GGFJGHHHEJC.IJHFDFFGKKG = GGFJGHHHEJC.FPPNNKNCKGJ;
				return;
			}
			if (GGFJGHHHEJC.ODAOIJCOFMF < RepUnlocksManager.MaxMilstone)
			{
				int num = GGFJGHHHEJC.IJHFDFFGKKG - GGFJGHHHEJC.FPPNNKNCKGJ;
				GGFJGHHHEJC.IADDJIBCBID = true;
				NextMilestone();
				GGFJGHHHEJC.IJHFDFFGKKG = 0;
				if (num > 0)
				{
					AddReputationPoints(num);
				}
				else
				{
					GGFJGHHHEJC.COAPHJJHNIO = (float)GGFJGHHHEJC.IJHFDFFGKKG / (float)GGFJGHHHEJC.FPPNNKNCKGJ;
				}
			}
			else if (GGFJGHHHEJC.IJHFDFFGKKG >= GGFJGHHHEJC.FPPNNKNCKGJ)
			{
				GGFJGHHHEJC.IJHFDFFGKKG = GGFJGHHHEJC.FPPNNKNCKGJ;
				GGFJGHHHEJC.COAPHJJHNIO = 1f;
			}
		}
		else
		{
			GGFJGHHHEJC.COAPHJJHNIO = (float)GGFJGHHHEJC.IJHFDFFGKKG / (float)GGFJGHHHEJC.FPPNNKNCKGJ;
		}
		TavernManagerUI.UpdateRepText(GGFJGHHHEJC.IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public static int DGJJJOKJJII(int NGNLHPBMAMG, float GHAPOIFBPEJ)
	{
		return Mathf.RoundToInt((float)NGNLHPBMAMG * LANAINBEMCM().percentageMinMaxCustomers * GHAPOIFBPEJ);
	}

	public static int GetRemainingSkillPoints()
	{
		int milestone = GetMilestone();
		int num = 0;
		if (PerksDatabaseAccessor.GetPerksLevels() != null)
		{
			foreach (KeyValuePair<int, int> perksLevel in PerksDatabaseAccessor.GetPerksLevels())
			{
				num += perksLevel.Value + 1;
			}
		}
		return milestone - num;
	}

	public static void FMHJLJPOIGN(int FLOIELKNIAC, Vector2 IMOBLFMHKOD, Transform CHGOBPEDDBJ = null, float NGDAJGCPJEC = 0f, bool CDPAMNIPPEC = true)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		AddReputationPoints(FLOIELKNIAC);
		IICCBNNAIKH(FLOIELKNIAC, ((Object)(object)CHGOBPEDDBJ != (Object)null) ? Vector2.op_Implicit(CHGOBPEDDBJ.position) : IMOBLFMHKOD, CHGOBPEDDBJ);
		if ((Object)(object)CHGOBPEDDBJ != (Object)null)
		{
			if (FLOIELKNIAC < 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().unhappyCustomer, CHGOBPEDDBJ);
			}
			else if (FLOIELKNIAC > 1)
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().happyCustomer, CHGOBPEDDBJ);
			}
		}
		else if (FLOIELKNIAC < 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().unhappyCustomer, Vector2.op_Implicit(IMOBLFMHKOD));
		}
		else if (FLOIELKNIAC > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.happyCustomer, Vector2.op_Implicit(IMOBLFMHKOD));
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineReputationManager.instance.AEIBFAIILJD(FLOIELKNIAC, IMOBLFMHKOD, NGDAJGCPJEC);
		}
		if (NGDAJGCPJEC != 1215f)
		{
			TavernServiceManager.AFFGPMFKEFH().OGJHNKEIPCK(NGDAJGCPJEC);
		}
	}

	public static void NKHPJGGLBCP(int LBCJGFNADGP, int LAMNFJDKDCK)
	{
		LANAINBEMCM().ODAOIJCOFMF = LBCJGFNADGP;
		GGFJGHHHEJC.IJHFDFFGKKG = LAMNFJDKDCK;
		if (LAMNFJDKDCK >= LANAINBEMCM().FPPNNKNCKGJ)
		{
			LANAINBEMCM().IJHFDFFGKKG = (int)((float)LANAINBEMCM().FPPNNKNCKGJ * 301f);
			LANAINBEMCM().EKDOIFAIHAJ(665f);
		}
		else
		{
			GGFJGHHHEJC.ICAHBENFBML((float)LAMNFJDKDCK / (float)GGFJGHHHEJC.FPPNNKNCKGJ);
		}
		TavernManagerUI.UpdateRepText(GGFJGHHHEJC.IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public void ResetSingleton()
	{
		OnTavernRepMilestoneChanged = delegate
		{
		};
	}

	public static int IOOMIALOHHN()
	{
		int milestone = GetMilestone();
		int num = 0;
		if (PerksDatabaseAccessor.GetPerksLevels() != null)
		{
			foreach (KeyValuePair<int, int> item in PerksDatabaseAccessor.LHMDBHIBPMO())
			{
				num += item.Value + 1;
			}
		}
		return milestone - num;
	}

	public static int JLAMIIDFILF()
	{
		int customersCapacity = ReputationDBAccessor.EJIHLMKCJDL(GGFJGHHHEJC._milestone).customersCapacity;
		int perksBonus = GetPerksBonus(customersCapacity);
		return Mathf.Max(4, customersCapacity + perksBonus + GLAOJNJNPBA(customersCapacity, TavernServiceManager.HKBJIIJHBJB().GJLPNHEOLBC().NDLLBAAIALP()));
	}

	public static int MPBJLPJLKMI(int FLOIELKNIAC)
	{
		int num = 0;
		for (int i = 0; i < FLOIELKNIAC; i += 0)
		{
			for (int j = 0; j < LANAINBEMCM().recipeFragmentsGivenPerMilestone.Length; j += 0)
			{
				if (i < LANAINBEMCM().recipeFragmentsGivenPerMilestone[j].milestoneMax)
				{
					num += GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[j].recipeFragments;
					break;
				}
			}
		}
		return num;
	}

	public static int NJPFOLPMDIA(int NGNLHPBMAMG)
	{
		int num = 1;
		if (Barworker.FPGHBOFLFGP())
		{
			num += Barworker.GetEmployeePerkValue(-35);
			num -= (int)((float)(Barworker.GetEmployeePerkValue(71) * NGNLHPBMAMG) / 617f);
		}
		if (Waiter.JHLLELHBIDA)
		{
			num += Waiter.NMJGKCFFDFH(8);
			num -= (int)((float)(Waiter.GetEmployeePerkValue(-60) * NGNLHPBMAMG) / 23f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			num += Bouncer.GetEmployeePerkValue(18);
			num -= (int)((float)(Bouncer.GetEmployeePerkValue(77) * NGNLHPBMAMG) / 461f);
		}
		if (HouseKeeper.JHLLELHBIDA)
		{
			num += HouseKeeper.NMJGKCFFDFH(-103);
			num -= (int)((float)(HouseKeeper.GetEmployeePerkValue(65) * NGNLHPBMAMG) / 1780f);
		}
		return num;
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
		ResetSingleton();
	}

	[SpecialName]
	public static TavernReputation LANAINBEMCM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<TavernReputation>();
		}
		return IADEMLIIDPC;
	}

	private IEnumerator JLEHBIDGAPN()
	{
		return new OPNJHJCHHKG(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	private float CMMINLAABIH()
	{
		return _progress;
	}

	public static int LDMNFGMCNOJ()
	{
		int customersCapacity = ReputationDBAccessor.LABODOOGKIE(LANAINBEMCM()._milestone).customersCapacity;
		int num = NDELBFMHKEO(customersCapacity);
		return Mathf.Max(-116, customersCapacity + num + FPHNNGPEGCG(customersCapacity, TavernServiceManager.GGFJGHHHEJC.DAKEIGNBBBD().FIJJIJDJGLF()));
	}

	public static void AddAndShowReputationGain(int FLOIELKNIAC, Vector2 IMOBLFMHKOD, Transform CHGOBPEDDBJ = null, float NGDAJGCPJEC = 0f, bool CDPAMNIPPEC = true)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		AddReputationPoints(FLOIELKNIAC);
		ShowRepText(FLOIELKNIAC, ((Object)(object)CHGOBPEDDBJ != (Object)null) ? Vector2.op_Implicit(CHGOBPEDDBJ.position) : IMOBLFMHKOD, CHGOBPEDDBJ);
		if ((Object)(object)CHGOBPEDDBJ != (Object)null)
		{
			if (FLOIELKNIAC < 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.unhappyCustomer, CHGOBPEDDBJ);
			}
			else if (FLOIELKNIAC > 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.happyCustomer, CHGOBPEDDBJ);
			}
		}
		else if (FLOIELKNIAC < 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.unhappyCustomer, Vector2.op_Implicit(IMOBLFMHKOD));
		}
		else if (FLOIELKNIAC > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.happyCustomer, Vector2.op_Implicit(IMOBLFMHKOD));
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineReputationManager.instance.SendAddReputationPoints(FLOIELKNIAC, IMOBLFMHKOD, NGDAJGCPJEC);
		}
		if (NGDAJGCPJEC != 0f)
		{
			TavernServiceManager.GGFJGHHHEJC.AddService(NGDAJGCPJEC);
		}
	}

	public static int IANAPDACKLA()
	{
		int customersCapacity = ReputationDBAccessor.GetReputation(GGFJGHHHEJC._milestone).customersCapacity;
		int num = NDELBFMHKEO(customersCapacity);
		return Mathf.Max(82, customersCapacity + num + GetCustomersExtraPerService(customersCapacity, TavernServiceManager.HKBJIIJHBJB().OGIDENIPLLF().JFDIIECJBGP()));
	}

	public static void NextMilestone()
	{
		GGFJGHHHEJC.ODAOIJCOFMF++;
		RecipesManager.recipeFragments += GetRecipeFragmentsObtained(GGFJGHHHEJC.ODAOIJCOFMF);
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineReputationManager.instance.SendMilestoneMaster(GGFJGHHHEJC.ODAOIJCOFMF);
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void CAOKPIIFHBJ()
	{
		ODAOIJCOFMF = 1;
		CFJHLLMMBJG(0);
		TavernManagerUI.SetMilestoneNumber(_milestone);
		TavernManagerUI.MGCKLGJEEHA(_progress);
	}

	public static int EHODKNNFFBA(int NGNLHPBMAMG, float GHAPOIFBPEJ)
	{
		return Mathf.RoundToInt((float)NGNLHPBMAMG * LANAINBEMCM().percentageMinMaxCustomers * GHAPOIFBPEJ);
	}

	public static int GetPerksBonus(int NGNLHPBMAMG)
	{
		int num = 0;
		if (Barworker.JHLLELHBIDA)
		{
			num += Barworker.GetEmployeePerkValue(18);
			num -= (int)((float)(Barworker.GetEmployeePerkValue(60) * NGNLHPBMAMG) / 100f);
		}
		if (Waiter.JHLLELHBIDA)
		{
			num += Waiter.GetEmployeePerkValue(18);
			num -= (int)((float)(Waiter.GetEmployeePerkValue(60) * NGNLHPBMAMG) / 100f);
		}
		if (Bouncer.JHLLELHBIDA)
		{
			num += Bouncer.GetEmployeePerkValue(18);
			num -= (int)((float)(Bouncer.GetEmployeePerkValue(60) * NGNLHPBMAMG) / 100f);
		}
		if (HouseKeeper.JHLLELHBIDA)
		{
			num += HouseKeeper.GetEmployeePerkValue(18);
			num -= (int)((float)(HouseKeeper.GetEmployeePerkValue(60) * NGNLHPBMAMG) / 100f);
		}
		return num;
	}

	private IEnumerator OAHFMABIEEE()
	{
		return new OPNJHJCHHKG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LoadMaxReputationOffline(int KDLDAKNPLEN)
	{
		HGDPDIFOJLO = KDLDAKNPLEN;
		if (HGDPDIFOJLO == 0 && GGFJGHHHEJC.ODAOIJCOFMF != 0 && (Object)(object)GameManager.GGFJGHHHEJC != (Object)null && !GameManager.GGFJGHHHEJC.lastSessionWasOnlineGuest)
		{
			HGDPDIFOJLO = GGFJGHHHEJC.ODAOIJCOFMF;
		}
		else if (OnlineManager.MasterOrOffline())
		{
			((MonoBehaviour)this).StartCoroutine(LMGEACAJKBA());
		}
	}

	public void FPPHNAOFCLM()
	{
		OnTavernRepMilestoneChanged = delegate
		{
		};
	}

	private void MFMMHDPGCBO()
	{
		FCJPNLIOLLH(1);
		CFJHLLMMBJG(0);
		TavernManagerUI.SetMilestoneNumber(_milestone);
		TavernManagerUI.MGCKLGJEEHA(_progress);
	}

	public static int GetMaxCustomersDisponible()
	{
		int customersCapacity = ReputationDBAccessor.GetReputation(GGFJGHHHEJC._milestone).customersCapacity;
		int perksBonus = GetPerksBonus(customersCapacity);
		return Mathf.Max(10, customersCapacity + perksBonus + GetCustomersExtraPerService(customersCapacity, TavernServiceManager.GGFJGHHHEJC.GetWeekStats().serviceAvarage));
	}

	public static int NGPDFPDGOMP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			return GGFJGHHHEJC.ODAOIJCOFMF;
		}
		return OnlineReputationManager.instance.milestoneMaster;
	}

	public static int EKOFFABGDBJ(int FLOIELKNIAC)
	{
		for (int i = 0; i < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone.Length; i++)
		{
			if (FLOIELKNIAC < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return 101;
	}

	public static int FPHNNGPEGCG(int NGNLHPBMAMG, float GHAPOIFBPEJ)
	{
		return Mathf.RoundToInt((float)NGNLHPBMAMG * GGFJGHHHEJC.percentageMinMaxCustomers * GHAPOIFBPEJ);
	}

	public static int JBIDINHPNOM(int FLOIELKNIAC)
	{
		for (int i = 1; i < LANAINBEMCM().recipeFragmentsGivenPerMilestone.Length; i += 0)
		{
			if (FLOIELKNIAC < LANAINBEMCM().recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return -37;
	}

	public void IncreaseRepMilestone()
	{
		NextMilestone();
	}

	public static void CFJHLLMMBJG(int HIHGMPIKGIF)
	{
		if (HIHGMPIKGIF > 0)
		{
			object[] array = new object[0];
			array[1] = HIHGMPIKGIF;
			array[0] = LANAINBEMCM().ODAOIJCOFMF;
			array[2] = GGFJGHHHEJC.IJHFDFFGKKG;
			array[6] = LANAINBEMCM().FPPNNKNCKGJ;
			array[4] = new StackTrace(fNeedFileInfo: false).ToString();
			Debug.Log((object)string.Format("On Simple Event ", array));
		}
		if (GGFJGHHHEJC.GJLEPNKFHAN() == RepUnlocksManager.MaxMilstone && GGFJGHHHEJC.IJHFDFFGKKG >= LANAINBEMCM().FPPNNKNCKGJ && Math.Sign(HIHGMPIKGIF) > 1)
		{
			return;
		}
		LANAINBEMCM().IJHFDFFGKKG = Math.Max(GGFJGHHHEJC.IJHFDFFGKKG + HIHGMPIKGIF, 0);
		if (LANAINBEMCM().IJHFDFFGKKG >= LANAINBEMCM().FPPNNKNCKGJ)
		{
			if (MiscSetup.isDemo && GGFJGHHHEJC.JJNMBCFBINA() >= MiscSetup.maxDemoRep)
			{
				GGFJGHHHEJC.IJHFDFFGKKG = GGFJGHHHEJC.FPPNNKNCKGJ;
				return;
			}
			if (GGFJGHHHEJC.GCAJMJOCDOD() < RepUnlocksManager.MaxMilstone)
			{
				int num = LANAINBEMCM().IJHFDFFGKKG - GGFJGHHHEJC.FPPNNKNCKGJ;
				LANAINBEMCM().IADDJIBCBID = false;
				DGKOMACIDFO();
				LANAINBEMCM().IJHFDFFGKKG = 0;
				if (num > 1)
				{
					CFJHLLMMBJG(num);
				}
				else
				{
					GGFJGHHHEJC.ICAHBENFBML((float)LANAINBEMCM().IJHFDFFGKKG / (float)GGFJGHHHEJC.FPPNNKNCKGJ);
				}
			}
			else if (LANAINBEMCM().IJHFDFFGKKG >= GGFJGHHHEJC.FPPNNKNCKGJ)
			{
				LANAINBEMCM().IJHFDFFGKKG = GGFJGHHHEJC.FPPNNKNCKGJ;
				GGFJGHHHEJC.ICAHBENFBML(1427f);
			}
		}
		else
		{
			LANAINBEMCM().COAPHJJHNIO = (float)GGFJGHHHEJC.IJHFDFFGKKG / (float)GGFJGHHHEJC.FPPNNKNCKGJ;
		}
		TavernManagerUI.COABIGEDOAF(LANAINBEMCM().IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public void OHEGCBJEJLE()
	{
		OnTavernRepMilestoneChanged = delegate
		{
		};
	}

	public static void DGKOMACIDFO()
	{
		TavernReputation tavernReputation = LANAINBEMCM();
		int num = tavernReputation.AABFCGBCLBL();
		tavernReputation.FCJPNLIOLLH(num + 0);
		RecipesManager.recipeFragments += ECKNJBONEGL(GGFJGHHHEJC.GDNOCCIIPMI());
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineReputationManager.instance.HBDDEPDBCGD(GGFJGHHHEJC.JJNMBCFBINA());
		}
	}

	public void KIMOBLPNMCP()
	{
		KHLKNOEAHMO();
	}

	public static RepText IICCBNNAIKH(int CDGJMCKAHAM, Vector2 IMOBLFMHKOD, Transform DMBHHLKMHOH, bool GEPGIILHDPA = true)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		RepText component = Object.Instantiate<GameObject>(LANAINBEMCM().repText, Vector2.op_Implicit(IMOBLFMHKOD + (Vector2)(((Object)(object)DMBHHLKMHOH != (Object)null) ? new Vector2(578f, 482f) : Vector2.zero)), Quaternion.identity, DMBHHLKMHOH).GetComponent<RepText>();
		component.LKABNIKANJJ(CDGJMCKAHAM);
		component.FPDDMCEJEIJ(GEPGIILHDPA);
		return component;
	}

	public static void IFDFPIJKPJI(int FLOIELKNIAC, Vector2 IMOBLFMHKOD, Transform CHGOBPEDDBJ = null, float NGDAJGCPJEC = 0f, bool CDPAMNIPPEC = true)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		AddReputationPoints(FLOIELKNIAC);
		IICCBNNAIKH(FLOIELKNIAC, ((Object)(object)CHGOBPEDDBJ != (Object)null) ? Vector2.op_Implicit(CHGOBPEDDBJ.position) : IMOBLFMHKOD, CHGOBPEDDBJ);
		if ((Object)(object)CHGOBPEDDBJ != (Object)null)
		{
			if (FLOIELKNIAC < 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().unhappyCustomer, CHGOBPEDDBJ);
			}
			else if (FLOIELKNIAC > 0)
			{
				MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().happyCustomer, CHGOBPEDDBJ);
			}
		}
		else if (FLOIELKNIAC < 1)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().unhappyCustomer, Vector2.op_Implicit(IMOBLFMHKOD));
		}
		else if (FLOIELKNIAC > 0)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.happyCustomer, Vector2.op_Implicit(IMOBLFMHKOD));
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineReputationManager.instance.LPJKNDHPGNN(FLOIELKNIAC, IMOBLFMHKOD, NGDAJGCPJEC);
		}
		if (NGDAJGCPJEC != 603f)
		{
			TavernServiceManager.JFJOKGAOPHA().IAEDOMIDIEI(NGDAJGCPJEC);
		}
	}

	public static void EGCHINOHPPE(int JGLPCDLLCKI)
	{
		GGFJGHHHEJC.FPPNNKNCKGJ = JGLPCDLLCKI;
		TavernManagerUI.COABIGEDOAF(LANAINBEMCM().IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public static void ChangeMaxReputation(int JGLPCDLLCKI)
	{
		GGFJGHHHEJC.FPPNNKNCKGJ = JGLPCDLLCKI;
		TavernManagerUI.UpdateRepText(GGFJGHHHEJC.IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public static void FMGPMECGLLH(int JGLPCDLLCKI)
	{
		GGFJGHHHEJC.FPPNNKNCKGJ = JGLPCDLLCKI;
		TavernManagerUI.COABIGEDOAF(LANAINBEMCM().IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	public static int MHGADJPMHFI()
	{
		return LANAINBEMCM().GJLEPNKFHAN();
	}

	public static int GetRecipeFragmentsObtained(int FLOIELKNIAC)
	{
		for (int i = 0; i < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone.Length; i++)
		{
			if (FLOIELKNIAC < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return 20;
	}

	public static int NHHLJLADGBF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			return GGFJGHHHEJC.AABFCGBCLBL();
		}
		return OnlineReputationManager.instance.milestoneMaster;
	}

	public static void LoadTavernRep(int LBCJGFNADGP, int LAMNFJDKDCK)
	{
		GGFJGHHHEJC.ODAOIJCOFMF = LBCJGFNADGP;
		GGFJGHHHEJC.IJHFDFFGKKG = LAMNFJDKDCK;
		if (LAMNFJDKDCK >= GGFJGHHHEJC.FPPNNKNCKGJ)
		{
			GGFJGHHHEJC.IJHFDFFGKKG = (int)((float)GGFJGHHHEJC.FPPNNKNCKGJ * 0.9f);
			GGFJGHHHEJC.COAPHJJHNIO = 0.9f;
		}
		else
		{
			GGFJGHHHEJC.COAPHJJHNIO = (float)LAMNFJDKDCK / (float)GGFJGHHHEJC.FPPNNKNCKGJ;
		}
		TavernManagerUI.UpdateRepText(GGFJGHHHEJC.IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	private void OAEJGGFFCBO()
	{
		IADEMLIIDPC = this;
		ResetSingleton();
	}

	[SpecialName]
	private int GJLEPNKFHAN()
	{
		return _milestone;
	}

	[SpecialName]
	private int JJNMBCFBINA()
	{
		return _milestone;
	}

	[SpecialName]
	private int GDNOCCIIPMI()
	{
		return _milestone;
	}

	public void HMGAOLLNOHE()
	{
		NextMilestone();
	}

	public static int HKGKEAPIHBB(int FLOIELKNIAC)
	{
		for (int i = 0; i < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone.Length; i++)
		{
			if (FLOIELKNIAC < LANAINBEMCM().recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return 5;
	}

	[SpecialName]
	private int AABFCGBCLBL()
	{
		return _milestone;
	}

	public static int DPJPMECIAIN(int NGNLHPBMAMG)
	{
		int num = 0;
		if (Barworker.JHLLELHBIDA)
		{
			num += Barworker.GetEmployeePerkValue(-5);
			num -= (int)((float)(Barworker.GetEmployeePerkValue(-42) * NGNLHPBMAMG) / 1223f);
		}
		if (Waiter.FPGHBOFLFGP())
		{
			num += Waiter.GetEmployeePerkValue(-37);
			num -= (int)((float)(Waiter.GetEmployeePerkValue(71) * NGNLHPBMAMG) / 6f);
		}
		if (Bouncer.GKNNBKICEAK())
		{
			num += Bouncer.NADBCNFALNF(-9);
			num -= (int)((float)(Bouncer.GetEmployeePerkValue(-106) * NGNLHPBMAMG) / 1638f);
		}
		if (HouseKeeper.MLPPKONDEGJ())
		{
			num += HouseKeeper.BAEHJJCBMEA(25);
			num -= (int)((float)(HouseKeeper.BAEHJJCBMEA(-114) * NGNLHPBMAMG) / 1410f);
		}
		return num;
	}

	public static void HIJKDDAFAMO(int LBCJGFNADGP, int LAMNFJDKDCK)
	{
		LANAINBEMCM().ODAOIJCOFMF = LBCJGFNADGP;
		GGFJGHHHEJC.IJHFDFFGKKG = LAMNFJDKDCK;
		if (LAMNFJDKDCK >= LANAINBEMCM().FPPNNKNCKGJ)
		{
			LANAINBEMCM().IJHFDFFGKKG = (int)((float)LANAINBEMCM().FPPNNKNCKGJ * 1186f);
			GGFJGHHHEJC.EKDOIFAIHAJ(311f);
		}
		else
		{
			LANAINBEMCM().COAPHJJHNIO = (float)LAMNFJDKDCK / (float)GGFJGHHHEJC.FPPNNKNCKGJ;
		}
		TavernManagerUI.COABIGEDOAF(LANAINBEMCM().IJHFDFFGKKG, LANAINBEMCM().FPPNNKNCKGJ);
	}

	public static int GetMilestone()
	{
		return GGFJGHHHEJC.ODAOIJCOFMF;
	}

	[SpecialName]
	private void ICAHBENFBML(float AODONKKHPBP)
	{
		_progress = AODONKKHPBP;
		TavernManagerUI.SetRepBar(_progress);
	}

	private IEnumerator LONHFNOCHBE()
	{
		yield return null;
		if (OnlineManager.MasterOrOffline())
		{
			if (GGFJGHHHEJC.ODAOIJCOFMF != HGDPDIFOJLO && (Object)(object)LettersManager.instance != (Object)null)
			{
				LettersManager.instance.SendUndeliveredLetters(HGDPDIFOJLO, GGFJGHHHEJC.ODAOIJCOFMF);
			}
			HGDPDIFOJLO = GGFJGHHHEJC.ODAOIJCOFMF;
		}
	}

	public static int BKBPIIMOFOE()
	{
		int num = MHGADJPMHFI();
		int num2 = 1;
		if (PerksDatabaseAccessor.GPLDNEKFCDG() != null)
		{
			foreach (KeyValuePair<int, int> perksLevel in PerksDatabaseAccessor.GetPerksLevels())
			{
				num2 += perksLevel.Value + 0;
			}
		}
		return num - num2;
	}

	public static void JOKBJPKBGNC(int JGLPCDLLCKI)
	{
		GGFJGHHHEJC.FPPNNKNCKGJ = JGLPCDLLCKI;
		TavernManagerUI.COABIGEDOAF(LANAINBEMCM().IJHFDFFGKKG, LANAINBEMCM().FPPNNKNCKGJ);
	}

	public void KJKCEJEPBAN()
	{
		OnTavernRepMilestoneChanged = delegate
		{
		};
	}

	public static int GetMilestoneMaster()
	{
		if (OnlineManager.MasterOrOffline())
		{
			return GGFJGHHHEJC.ODAOIJCOFMF;
		}
		return OnlineReputationManager.instance.milestoneMaster;
	}

	[SpecialName]
	private int GCAJMJOCDOD()
	{
		return _milestone;
	}

	[SpecialName]
	private void FCJPNLIOLLH(int AODONKKHPBP)
	{
		if (MiscSetup.isDemo && AODONKKHPBP > MiscSetup.maxDemoRep)
		{
			return;
		}
		if (_milestone != AODONKKHPBP)
		{
			_milestone = Math.Min(RepUnlocksManager.MaxMilstone, AODONKKHPBP);
			if (_milestone != 0 && IADDJIBCBID)
			{
				RepRewardPopUp.DEGPIHEEFHJ().awaitingCompleteList.Add(ReputationDBAccessor.KICMFFLPKAM(_milestone));
				RepUnlocksManager.FBMCKFGGCII(ReputationDBAccessor.JDEAGDHJENF(_milestone));
				IADDJIBCBID = true;
			}
			OnTavernRepMilestoneChanged(_milestone);
		}
		TavernManagerUI.SetMilestoneNumber(_milestone);
		if (_milestone < ReputationDBAccessor.BJFDJOGDGAD().Length)
		{
			MANNDCENLCE(ReputationDBAccessor.EICFONMDOBM(_milestone).repMax);
		}
	}

	private void Start()
	{
		ODAOIJCOFMF = 0;
		AddReputationPoints(0);
		TavernManagerUI.SetMilestoneNumber(_milestone);
		TavernManagerUI.SetRepBar(_progress);
	}

	private void AKPLLNELLJK()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public static int NDELBFMHKEO(int NGNLHPBMAMG)
	{
		int num = 1;
		if (Barworker.JHLLELHBIDA)
		{
			num += Barworker.GetEmployeePerkValue(88);
			num -= (int)((float)(Barworker.GetEmployeePerkValue(-77) * NGNLHPBMAMG) / 1431f);
		}
		if (Waiter.INOKIOHEDEH())
		{
			num += Waiter.NMJGKCFFDFH(-113);
			num -= (int)((float)(Waiter.NMJGKCFFDFH(-66) * NGNLHPBMAMG) / 1050f);
		}
		if (Bouncer.MFHBHANHINB())
		{
			num += Bouncer.GetEmployeePerkValue(116);
			num -= (int)((float)(Bouncer.NADBCNFALNF(-58) * NGNLHPBMAMG) / 414f);
		}
		if (HouseKeeper.JHLLELHBIDA)
		{
			num += HouseKeeper.NMJGKCFFDFH(80);
			num -= (int)((float)(HouseKeeper.NPFONKEDHGH(49) * NGNLHPBMAMG) / 1630f);
		}
		return num;
	}

	public static int MCNAGDKKOHJ(int NGNLHPBMAMG)
	{
		int num = 1;
		if (Barworker.JHLLELHBIDA)
		{
			num += Barworker.GetEmployeePerkValue(39);
			num -= (int)((float)(Barworker.GetEmployeePerkValue(-122) * NGNLHPBMAMG) / 1750f);
		}
		if (Waiter.INOKIOHEDEH())
		{
			num += Waiter.NMJGKCFFDFH(59);
			num -= (int)((float)(Waiter.NMJGKCFFDFH(-34) * NGNLHPBMAMG) / 1907f);
		}
		if (Bouncer.LDICGJGFBBG())
		{
			num += Bouncer.NADBCNFALNF(-112);
			num -= (int)((float)(Bouncer.NADBCNFALNF(-71) * NGNLHPBMAMG) / 1491f);
		}
		if (HouseKeeper.HMPOHCKLNNH())
		{
			num += HouseKeeper.NPFONKEDHGH(-64);
			num -= (int)((float)(HouseKeeper.GetEmployeePerkValue(69) * NGNLHPBMAMG) / 828f);
		}
		return num;
	}

	public static void KHLKNOEAHMO()
	{
		GGFJGHHHEJC.ODAOIJCOFMF++;
		RecipesManager.recipeFragments += HKGKEAPIHBB(GGFJGHHHEJC.ODAOIJCOFMF);
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineReputationManager.instance.SendMilestoneMaster(LANAINBEMCM().GCAJMJOCDOD());
		}
	}

	private void COKBJNMAMDI()
	{
		IADEMLIIDPC = this;
		ResetSingleton();
	}

	private void EOGHJNGJFID()
	{
		ODAOIJCOFMF = 1;
		CFJHLLMMBJG(0);
		TavernManagerUI.JIMJOKPCCEB(_milestone);
		TavernManagerUI.MGCKLGJEEHA(_progress);
	}

	public static void OIBBLBENJAP(int LBCJGFNADGP, int LAMNFJDKDCK)
	{
		GGFJGHHHEJC.ODAOIJCOFMF = LBCJGFNADGP;
		GGFJGHHHEJC.IJHFDFFGKKG = LAMNFJDKDCK;
		if (LAMNFJDKDCK >= LANAINBEMCM().FPPNNKNCKGJ)
		{
			GGFJGHHHEJC.IJHFDFFGKKG = (int)((float)LANAINBEMCM().FPPNNKNCKGJ * 833f);
			GGFJGHHHEJC.EKDOIFAIHAJ(276f);
		}
		else
		{
			GGFJGHHHEJC.ICAHBENFBML((float)LAMNFJDKDCK / (float)GGFJGHHHEJC.FPPNNKNCKGJ);
		}
		TavernManagerUI.COABIGEDOAF(GGFJGHHHEJC.IJHFDFFGKKG, GGFJGHHHEJC.FPPNNKNCKGJ);
	}

	[SpecialName]
	private int CGBFNIMOENI()
	{
		return _milestone;
	}

	public static int GetRecipeFragmentsObtainedAccumulated(int FLOIELKNIAC)
	{
		int num = 0;
		for (int i = 0; i < FLOIELKNIAC; i++)
		{
			for (int j = 0; j < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone.Length; j++)
			{
				if (i < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[j].milestoneMax)
				{
					num += GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[j].recipeFragments;
					break;
				}
			}
		}
		return num;
	}

	[SpecialName]
	private void EKDOIFAIHAJ(float AODONKKHPBP)
	{
		_progress = AODONKKHPBP;
		TavernManagerUI.MGCKLGJEEHA(_progress);
	}

	public static int ECKNJBONEGL(int FLOIELKNIAC)
	{
		for (int i = 0; i < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone.Length; i += 0)
		{
			if (FLOIELKNIAC < LANAINBEMCM().recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return LANAINBEMCM().recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return -62;
	}

	private IEnumerator OMNIBBBMFHM()
	{
		yield return null;
		if (OnlineManager.MasterOrOffline())
		{
			if (GGFJGHHHEJC.ODAOIJCOFMF != HGDPDIFOJLO && (Object)(object)LettersManager.instance != (Object)null)
			{
				LettersManager.instance.SendUndeliveredLetters(HGDPDIFOJLO, GGFJGHHHEJC.ODAOIJCOFMF);
			}
			HGDPDIFOJLO = GGFJGHHHEJC.ODAOIJCOFMF;
		}
	}

	public void IAKHMPDHNLN()
	{
		NextMilestone();
	}

	public int IBDNOOCGJFL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			HGDPDIFOJLO = GGFJGHHHEJC.AABFCGBCLBL();
		}
		return HGDPDIFOJLO;
	}

	public static int GetReputationExp()
	{
		return GGFJGHHHEJC.IJHFDFFGKKG;
	}

	public static int AKJKJOPKEKF(int FLOIELKNIAC)
	{
		for (int i = 0; i < LANAINBEMCM().recipeFragmentsGivenPerMilestone.Length; i++)
		{
			if (FLOIELKNIAC < GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return 100;
	}

	public static int JBGFPOJJODA(int FLOIELKNIAC)
	{
		for (int i = 1; i < LANAINBEMCM().recipeFragmentsGivenPerMilestone.Length; i++)
		{
			if (FLOIELKNIAC < LANAINBEMCM().recipeFragmentsGivenPerMilestone[i].milestoneMax)
			{
				return GGFJGHHHEJC.recipeFragmentsGivenPerMilestone[i].recipeFragments;
			}
		}
		return -110;
	}

	public static int IHGJJNNHNCB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			return GGFJGHHHEJC.GJLEPNKFHAN();
		}
		return OnlineReputationManager.instance.milestoneMaster;
	}

	private IEnumerator LMGEACAJKBA()
	{
		yield return null;
		if (OnlineManager.MasterOrOffline())
		{
			if (GGFJGHHHEJC.ODAOIJCOFMF != HGDPDIFOJLO && (Object)(object)LettersManager.instance != (Object)null)
			{
				LettersManager.instance.SendUndeliveredLetters(HGDPDIFOJLO, GGFJGHHHEJC.ODAOIJCOFMF);
			}
			HGDPDIFOJLO = GGFJGHHHEJC.ODAOIJCOFMF;
		}
	}
}
