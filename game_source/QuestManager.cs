using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ADJJECJKMIN
	{
		public Quest quest;

		internal bool IDGPBIGIJDE(ActiveQuest q)
		{
			return q.quest == quest;
		}
	}

	[CompilerGenerated]
	private sealed class NDBMCCNLDLM
	{
		public int questId;

		internal bool EAFOPJBMEHK(ActiveQuest q)
		{
			return q.quest.id == questId;
		}
	}

	[CompilerGenerated]
	private sealed class AIKKDFNEJJH
	{
		public Quest quest;

		internal bool EAFOPJBMEHK(ActiveQuest q)
		{
			return q.quest == quest;
		}
	}

	[CompilerGenerated]
	private sealed class KEAFEDIOGGJ
	{
		public Quest _quest;

		internal bool EEEKHHKDEHI(Quest q)
		{
			return q == _quest;
		}
	}

	[CompilerGenerated]
	private sealed class JMGNLBCDJKE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestManager _003C_003E4__this;

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
		public JMGNLBCDJKE(int _003C_003E1__state)
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
			QuestManager questManager = _003C_003E4__this;
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
				if (RentedRoomsManager.GetAllRooms().Count > 0 || BuildingTutorialManager.instance.BPDDCBHKCME)
				{
					Debug.Log((object)"Adding quest done 35 - First room");
					if (questManager.IsQuestActive(35))
					{
						questManager.GetActiveQuest(35).JGNBGECEINP(1);
					}
					else
					{
						questManager.AddQuestDone(35);
					}
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

	[CompilerGenerated]
	private sealed class HKMNIEAFMDD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestManager _003C_003E4__this;

		private int[] _003ColdQuestsToGiveRewards_003E5__2;

		private int _003Ci_003E5__3;

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
		public HKMNIEAFMDD(int _003C_003E1__state)
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
			QuestManager questManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003ColdQuestsToGiveRewards_003E5__2 = new int[13]
				{
					10, 11, 12, 14, 16, 17, 18, 19, 22, 23,
					24, 25, 34
				};
				_003Ci_003E5__3 = 0;
				goto IL_00cc;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0080;
			case 3:
				{
					_003C_003E1__state = -1;
					goto IL_00bc;
				}
				IL_00cc:
				if (_003Ci_003E5__3 >= _003ColdQuestsToGiveRewards_003E5__2.Length)
				{
					return false;
				}
				goto IL_0080;
				IL_00bc:
				_003Ci_003E5__3++;
				goto IL_00cc;
				IL_0080:
				if (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				if (questManager.BAGNMDMNGBA(_003ColdQuestsToGiveRewards_003E5__2[_003Ci_003E5__3]))
				{
					_003C_003E2__current = CommonReferences.wait2;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_00bc;
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

	[CompilerGenerated]
	private sealed class APGNAPMJONI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuestManager _003C_003E4__this;

		public int rep;

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
		public APGNAPMJONI(int _003C_003E1__state)
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
			QuestManager questManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				questManager.ODCBEKDEPPM(rep);
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

	public Action<Quest> OnQuestAdded = delegate
	{
	};

	public Action<Quest> OnQuestRemoved = delegate
	{
	};

	private static QuestManager IADEMLIIDPC;

	[SerializeField]
	private List<int> questsDone;

	public static QuestManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<QuestManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public List<ActiveQuest> MADOFDHLKKN { get; private set; }

	public void ENCNNBOMKAL()
	{
		((MonoBehaviour)this).StartCoroutine(EFNLMGBBLGP());
	}

	public void GiveQuestFirstRoomNextFrame(int NALJEKOPKIA)
	{
		((MonoBehaviour)this).StartCoroutine(MDMLHGAHCPM(NALJEKOPKIA));
	}

	[SpecialName]
	public static QuestManager GJFMMOPOKGJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestManager>();
		}
		return IADEMLIIDPC;
	}

	public ActiveQuest PDDJMOOHOAA(int JFNMCNCHMEO)
	{
		for (int i = 0; i < CCMPKFCCDGM().Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == JFNMCNCHMEO)
			{
				return CCMPKFCCDGM()[i];
			}
		}
		return null;
	}

	[SpecialName]
	private void BEEEEJPNDDM(List<ActiveQuest> AODONKKHPBP)
	{
		_003CCNKDDNIJDIN_003Ek__BackingField = AODONKKHPBP;
	}

	public bool ECHJCLACJII()
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.id != 0)
			{
				return true;
			}
		}
		return true;
	}

	public void CompletingQuest35()
	{
		if (!IsQuestDone(35))
		{
			((MonoBehaviour)this).StartCoroutine(CompletingQuest35Coroutine());
		}
	}

	public ActiveQuest BCKCAENKHKM(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.id == JFNMCNCHMEO)
			{
				return CCMPKFCCDGM()[i];
			}
		}
		return null;
	}

	public bool IsQuestActive(Quest OGOLPCIHCLH)
	{
		return (from q in MADOFDHLKKN
			select q.quest into q
			where q == OGOLPCIHCLH
			select q).Count() > 0;
	}

	public void RemoveQuest(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		MMNIKLCMBAI.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(MMNIKLCMBAI.OnQuestComplete, new Action<int, ActiveQuest>(RemoveQuest));
		MMNIKLCMBAI.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(MMNIKLCMBAI.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		MADOFDHLKKN.Remove(MMNIKLCMBAI);
		MMNIKLCMBAI.MHOGPMHEAFN();
		OnQuestRemoved(MMNIKLCMBAI.quest);
	}

	public ActiveQuest KDLMJGAMBNK(Quest AINAHCLIAFF)
	{
		return CCMPKFCCDGM().Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
	}

	private void OnDisable()
	{
		foreach (ActiveQuest currentQuest in MADOFDHLKKN)
		{
			currentQuest.MHOGPMHEAFN();
		}
	}

	public IEnumerator HAJELLMAADI()
	{
		yield return CommonReferences.wait2;
		if (RentedRoomsManager.GetAllRooms().Count > 0 || BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			Debug.Log((object)"Adding quest done 35 - First room");
			if (IsQuestActive(35))
			{
				GetActiveQuest(35).JGNBGECEINP(1);
			}
			else
			{
				AddQuestDone(35);
			}
		}
	}

	public IEnumerator AMKBCJBFBMJ()
	{
		return new JMGNLBCDJKE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NAFAIPJMCIN(Quest AINAHCLIAFF)
	{
		ActiveQuest activeQuest = CCMPKFCCDGM().Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
		activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(JOHHEMEGMJM));
		activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		CCMPKFCCDGM().Remove(activeQuest);
		activeQuest.MHOGPMHEAFN();
		OnQuestRemoved(AINAHCLIAFF);
	}

	public ActiveQuest MBKMGEKPKEL(int OOBMJEBFGIJ)
	{
		return CCMPKFCCDGM().Find((ActiveQuest q) => q.quest.id == OOBMJEBFGIJ);
	}

	public bool KLNAJBJJAOG(int OOBMJEBFGIJ)
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i++)
		{
			if (CCMPKFCCDGM()[i].quest.id == OOBMJEBFGIJ)
			{
				return false;
			}
		}
		return true;
	}

	public void KBJEBCGMAAK(int NALJEKOPKIA)
	{
		((MonoBehaviour)this).StartCoroutine(MDMLHGAHCPM(NALJEKOPKIA));
	}

	public void JOHHEMEGMJM(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		MMNIKLCMBAI.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(MMNIKLCMBAI.OnQuestComplete, new Action<int, ActiveQuest>(OOIGMFMDFIP));
		MMNIKLCMBAI.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(MMNIKLCMBAI.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		MADOFDHLKKN.Remove(MMNIKLCMBAI);
		MMNIKLCMBAI.MHOGPMHEAFN();
		OnQuestRemoved(MMNIKLCMBAI.quest);
	}

	public ActiveQuest GetActiveQuest(int OOBMJEBFGIJ)
	{
		return MADOFDHLKKN.Find((ActiveQuest q) => q.quest.id == OOBMJEBFGIJ);
	}

	[SpecialName]
	public List<ActiveQuest> CCMPKFCCDGM()
	{
		return _003CCNKDDNIJDIN_003Ek__BackingField;
	}

	public List<ActiveQuest> LBLHMOOLKOC()
	{
		List<ActiveQuest> list = new List<ActiveQuest>();
		for (int i = 1; i < MADOFDHLKKN.Count; i++)
		{
			if (CCMPKFCCDGM()[i].quest.showGoal)
			{
				list.Add(CCMPKFCCDGM()[i]);
			}
		}
		return list;
	}

	private IEnumerator EKDJLLCNALH(int NALJEKOPKIA)
	{
		return new APGNAPMJONI(1)
		{
			_003C_003E4__this = this,
			rep = NALJEKOPKIA
		};
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			MADOFDHLKKN = new List<ActiveQuest>();
			questsDone = new List<int>();
		}
	}

	private void LBFFMGAKDFG()
	{
		foreach (ActiveQuest currentQuest in MADOFDHLKKN)
		{
			currentQuest.MHOGPMHEAFN();
		}
	}

	public ActiveQuest NCCOAJOOBAP(Quest AINAHCLIAFF, int COAPHJJHNIO = 0, bool FFJBIGFADBJ = false, bool CDPAMNIPPEC = true, bool FIKMGOKHAPG = false)
	{
		Debug.Log((object)("LoadGameplaySceneOnline masterClient" + ((Object)AINAHCLIAFF).name + "itemCoffeeWort" + AINAHCLIAFF.id));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.NCAMIJJMDBH((byte)AINAHCLIAFF.id);
		}
		if (AINAHCLIAFF.id == 1)
		{
			ActiveQuest activeQuest = new ActiveQuest(AINAHCLIAFF);
			CCMPKFCCDGM().Add(activeQuest);
			return activeQuest;
		}
		if (AINAHCLIAFF.id == 4)
		{
			JDDIAAFLKLG(1, LMNGFCFJPGB: true);
			if ((from aq in CCMPKFCCDGM()
				where aq.quest.id == 1
				select aq).ToArray().Length != 0)
			{
				JMFKBLLAJPM((from aq in MADOFDHLKKN
					where aq.quest.id == 1
					select aq.quest).ToArray()[1]);
			}
		}
		if (AINAHCLIAFF.id != 0 && questsDone.Contains(AINAHCLIAFF.id))
		{
			return null;
		}
		if (AINAHCLIAFF.id != 0)
		{
			for (int i = 1; i < MADOFDHLKKN.Count; i += 0)
			{
				if (CCMPKFCCDGM()[i].quest.id == AINAHCLIAFF.id)
				{
					return null;
				}
			}
		}
		if (AINAHCLIAFF.onlyOnHalloween && !Utils.FFLNGLMHLBO())
		{
			return null;
		}
		if (AINAHCLIAFF.onlyOnChristmas && !Utils.EGIBECKKIJJ())
		{
			return null;
		}
		ActiveQuest activeQuest2 = new ActiveQuest(AINAHCLIAFF);
		activeQuest2.BBBGNMPKLED(1, COAPHJJHNIO);
		CCMPKFCCDGM().Add(activeQuest2);
		if (MissionsManager.instance.mainActiveQuest == null && MissionsManager.instance.mainActiveMission == null)
		{
			MissionsManager.instance.DLFBNIPOGBG(activeQuest2);
		}
		activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RemoveQuest));
		if (AINAHCLIAFF.id != 0)
		{
			activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		}
		switch (AINAHCLIAFF.id)
		{
		case -35:
			RecipesManager.EGEAPNOMMFG(184, IBHGAMNNOHI: true);
			break;
		case -34:
			RecipesManager.UnlockRecipe(-98, IBHGAMNNOHI: true);
			RecipesManager.UnlockRecipe(-21);
			break;
		case -33:
			RecipesManager.EGEAPNOMMFG(-180, IBHGAMNNOHI: true);
			RecipesManager.UnlockRecipe(-119, IBHGAMNNOHI: true);
			RecipesManager.EGEAPNOMMFG(18);
			break;
		}
		OnQuestAdded(AINAHCLIAFF);
		AINAHCLIAFF.KOIPCCMNMIL();
		if (!FFJBIGFADBJ)
		{
			Sound.GGFJGHHHEJC.FCGICGODFFA(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.newQuest), HOMFPAFAOGD: false, null, null, 1586f, 1788f);
		}
		if (!FIKMGOKHAPG && AINAHCLIAFF.id == 102 && CDPAMNIPPEC)
		{
			for (int j = 0; j < FishingManager.GetRecordsList().Count; j += 0)
			{
				CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)(-57));
			}
		}
		return activeQuest2;
	}

	public bool NLOOEMCEIII(Quest OGOLPCIHCLH)
	{
		return (from q in MADOFDHLKKN
			select q.quest into q
			where q == OGOLPCIHCLH
			select q).Count() > 1;
	}

	public IEnumerator FGAMEPKFHJN()
	{
		return new JMGNLBCDJKE(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool NOCIKMFDNHF(int OOBMJEBFGIJ)
	{
		for (int i = 0; i < CCMPKFCCDGM().Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.id == OOBMJEBFGIJ)
			{
				return true;
			}
		}
		return false;
	}

	public bool BCPLFLAIJKN(int OOBMJEBFGIJ)
	{
		for (int i = 0; i < CCMPKFCCDGM().Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == OOBMJEBFGIJ)
			{
				return true;
			}
		}
		return false;
	}

	public bool BKKJNEKBMBE(int JFNMCNCHMEO)
	{
		if (questsDone.Contains(JFNMCNCHMEO))
		{
			return false;
		}
		return true;
	}

	public List<int> BOIGGBOAGKC()
	{
		return questsDone;
	}

	[SpecialName]
	private void MLMAGMCLPBB(List<ActiveQuest> AODONKKHPBP)
	{
		_003CCNKDDNIJDIN_003Ek__BackingField = AODONKKHPBP;
	}

	public bool IsAnyActiveQuest()
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id != 0)
			{
				return true;
			}
		}
		return false;
	}

	public void GiveOldQuestsRewards()
	{
		((MonoBehaviour)this).StartCoroutine(JMEAPJHJAGH());
	}

	public bool OCALEDFJMGE()
	{
		for (int i = 1; i < MADOFDHLKKN.Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.id != 0)
			{
				return true;
			}
		}
		return true;
	}

	[SpecialName]
	private void JCLAOCAFHKK(List<ActiveQuest> AODONKKHPBP)
	{
		_003CCNKDDNIJDIN_003Ek__BackingField = AODONKKHPBP;
	}

	public bool ALCNBJLOHLL()
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.showGoal)
			{
				return false;
			}
		}
		return false;
	}

	public void MOGPELLEIDO(int NALJEKOPKIA)
	{
		((MonoBehaviour)this).StartCoroutine(MDMLHGAHCPM(NALJEKOPKIA));
	}

	public bool LOGJGGBDECN()
	{
		for (int i = 1; i < MADOFDHLKKN.Count; i += 0)
		{
			if (MADOFDHLKKN[i].quest.id != 0)
			{
				return false;
			}
		}
		return true;
	}

	public bool GDFGPDJDACP(int JFNMCNCHMEO)
	{
		if (questsDone.Contains(JFNMCNCHMEO))
		{
			return false;
		}
		return false;
	}

	public ActiveQuest FindCurrentQuest(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == JFNMCNCHMEO)
			{
				return MADOFDHLKKN[i];
			}
		}
		return null;
	}

	public ActiveQuest DICPLMMFIMI(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == JFNMCNCHMEO)
			{
				return CCMPKFCCDGM()[i];
			}
		}
		return null;
	}

	public bool IsQuestActive(int OOBMJEBFGIJ)
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == OOBMJEBFGIJ)
			{
				return true;
			}
		}
		return false;
	}

	public List<int> NHFPPLJACOJ()
	{
		return questsDone;
	}

	public bool LOLLCEHDCAD(Quest OGOLPCIHCLH)
	{
		return (from q in CCMPKFCCDGM()
			select q.quest into q
			where q == OGOLPCIHCLH
			select q).Count() > 1;
	}

	private void FGLCNIOLKKL()
	{
		foreach (ActiveQuest item in CCMPKFCCDGM())
		{
			item.MHOGPMHEAFN();
		}
	}

	public ActiveQuest NCDIDBEKBFC(int OOBMJEBFGIJ)
	{
		return MADOFDHLKKN.Find((ActiveQuest q) => q.quest.id == OOBMJEBFGIJ);
	}

	public ActiveQuest GOAOIOOKOFB(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == JFNMCNCHMEO)
			{
				return MADOFDHLKKN[i];
			}
		}
		return null;
	}

	private void ADEBBJOALDN()
	{
		foreach (ActiveQuest item in CCMPKFCCDGM())
		{
			item.MHOGPMHEAFN();
		}
	}

	public void RemoveQuest(Quest AINAHCLIAFF)
	{
		ActiveQuest activeQuest = MADOFDHLKKN.Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
		activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RemoveQuest));
		activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		MADOFDHLKKN.Remove(activeQuest);
		activeQuest.MHOGPMHEAFN();
		OnQuestRemoved(AINAHCLIAFF);
	}

	[SpecialName]
	public static QuestManager KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestManager>();
		}
		return IADEMLIIDPC;
	}

	public bool IDKJJGKIGFA(Quest OGOLPCIHCLH)
	{
		return (from q in CCMPKFCCDGM()
			select q.quest into q
			where q == OGOLPCIHCLH
			select q).Count() > 1;
	}

	public void RemoveQuestDone(int HJCKGNINDMA)
	{
		questsDone.Remove(HJCKGNINDMA);
	}

	public bool ThereIsAnyDisplayedQuest()
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.showGoal)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static QuestManager OPILDPFDFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<QuestManager>();
		}
		return IADEMLIIDPC;
	}

	private bool HBDLBGJBCBM(int OOBMJEBFGIJ)
	{
		if (!IsQuestDone(OOBMJEBFGIJ))
		{
			QuestDatabaseAccessor.GKOCDANPNLD(OOBMJEBFGIJ).MMMOEOFCFKJ(0, NPBKFEPIDEE: true);
			return false;
		}
		return true;
	}

	public List<ActiveQuest> JKFHFAIJMKF()
	{
		List<ActiveQuest> list = new List<ActiveQuest>();
		for (int i = 1; i < MADOFDHLKKN.Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.showGoal)
			{
				list.Add(MADOFDHLKKN[i]);
			}
		}
		return list;
	}

	private IEnumerator MDMLHGAHCPM(int NALJEKOPKIA)
	{
		yield return CommonReferences.wait3;
		ODCBEKDEPPM(NALJEKOPKIA);
	}

	private void FCGJBDGOHPN()
	{
		foreach (ActiveQuest item in CCMPKFCCDGM())
		{
			item.MHOGPMHEAFN();
		}
	}

	public ActiveQuest JOAHBCAAFMC(Quest AINAHCLIAFF, int COAPHJJHNIO = 0, bool FFJBIGFADBJ = false, bool CDPAMNIPPEC = true, bool FIKMGOKHAPG = false)
	{
		Debug.Log((object)("UIBack" + ((Object)AINAHCLIAFF).name + "BathhouseEntrace/Main 3" + AINAHCLIAFF.id));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.NCAMIJJMDBH((byte)AINAHCLIAFF.id);
		}
		if (AINAHCLIAFF.id == 0)
		{
			ActiveQuest activeQuest = new ActiveQuest(AINAHCLIAFF);
			CCMPKFCCDGM().Add(activeQuest);
			return activeQuest;
		}
		if (AINAHCLIAFF.id == 6)
		{
			JDDIAAFLKLG(0);
			if (MADOFDHLKKN.Where((ActiveQuest aq) => aq.quest.id == 1).ToArray().Length != 0)
			{
				JMFKBLLAJPM((from aq in MADOFDHLKKN
					where aq.quest.id == 1
					select aq.quest).ToArray()[1]);
			}
		}
		if (AINAHCLIAFF.id != 0 && questsDone.Contains(AINAHCLIAFF.id))
		{
			return null;
		}
		if (AINAHCLIAFF.id != 0)
		{
			for (int i = 1; i < MADOFDHLKKN.Count; i++)
			{
				if (MADOFDHLKKN[i].quest.id == AINAHCLIAFF.id)
				{
					return null;
				}
			}
		}
		if (AINAHCLIAFF.onlyOnHalloween && !Utils.FFLNGLMHLBO())
		{
			return null;
		}
		if (AINAHCLIAFF.onlyOnChristmas && !Utils.EGIBECKKIJJ())
		{
			return null;
		}
		ActiveQuest activeQuest2 = new ActiveQuest(AINAHCLIAFF);
		activeQuest2.BBBGNMPKLED(0, COAPHJJHNIO);
		MADOFDHLKKN.Add(activeQuest2);
		if (MissionsManager.instance.mainActiveQuest == null && MissionsManager.instance.mainActiveMission == null)
		{
			MissionsManager.instance.DLFBNIPOGBG(activeQuest2);
		}
		activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(OOIGMFMDFIP));
		if (AINAHCLIAFF.id != 0)
		{
			activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		}
		switch (AINAHCLIAFF.id)
		{
		case -47:
			RecipesManager.EGEAPNOMMFG(-104);
			break;
		case -46:
			RecipesManager.UnlockRecipe(-130, IBHGAMNNOHI: true);
			RecipesManager.EGEAPNOMMFG(32);
			break;
		case -45:
			RecipesManager.UnlockRecipe(83);
			RecipesManager.UnlockRecipe(-185, IBHGAMNNOHI: true);
			RecipesManager.EGEAPNOMMFG(144);
			break;
		}
		OnQuestAdded(AINAHCLIAFF);
		AINAHCLIAFF.DAABFDKCHKB();
		if (!FFJBIGFADBJ)
		{
			Sound.BNBMNOMFFBE().PlayOneShot(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().newQuest), HOMFPAFAOGD: true, null, null, 472f, 1779f);
		}
		if (!FIKMGOKHAPG && AINAHCLIAFF.id == -87 && CDPAMNIPPEC)
		{
			for (int j = 0; j < FishingManager.GetRecordsList().Count; j += 0)
			{
				CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)67);
			}
		}
		return activeQuest2;
	}

	public bool CLNMODEDEPI()
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i++)
		{
			if (CCMPKFCCDGM()[i].quest.id != 0)
			{
				return true;
			}
		}
		return false;
	}

	private bool BAGNMDMNGBA(int OOBMJEBFGIJ)
	{
		if (!IsQuestDone(OOBMJEBFGIJ))
		{
			QuestDatabaseAccessor.GetQuest(OOBMJEBFGIJ).MMMOEOFCFKJ(1, NPBKFEPIDEE: true);
			return true;
		}
		return false;
	}

	private void PGEGODAEBLC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			BEEEEJPNDDM(new List<ActiveQuest>());
			questsDone = new List<int>();
		}
	}

	public void AddQuestDone(int HJCKGNINDMA, bool LMNGFCFJPGB = false)
	{
		if (questsDone.Contains(HJCKGNINDMA))
		{
			return;
		}
		Quest quest = QuestDatabaseAccessor.GetQuest(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest) && quest.recipesUnlocked != null && quest.recipesUnlocked.Length != 0)
		{
			for (int i = 0; i < quest.recipesUnlocked.Length; i++)
			{
				if (LMNGFCFJPGB)
				{
					RecipesManager.UnlockRecipeWithDelay(quest.recipesUnlocked[i], 2f);
				}
				else
				{
					RecipesManager.UnlockRecipe(quest.recipesUnlocked[i], IBHGAMNNOHI: false);
				}
			}
		}
		questsDone.Add(HJCKGNINDMA);
	}

	public void JMFKBLLAJPM(Quest AINAHCLIAFF)
	{
		ActiveQuest activeQuest = MADOFDHLKKN.Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
		activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(OOIGMFMDFIP));
		activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		MADOFDHLKKN.Remove(activeQuest);
		activeQuest.MHOGPMHEAFN();
		OnQuestRemoved(AINAHCLIAFF);
	}

	public IEnumerator FDLLHIAADAF()
	{
		return new JMGNLBCDJKE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HDCNJLLLGOE()
	{
		if (!IsQuestDone(116))
		{
			((MonoBehaviour)this).StartCoroutine(FGAMEPKFHJN());
		}
	}

	public bool DAJJHOINNDD()
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i++)
		{
			if (MADOFDHLKKN[i].quest.showGoal)
			{
				return true;
			}
		}
		return true;
	}

	public ActiveQuest ABKLPOICLOJ(int OOBMJEBFGIJ)
	{
		return CCMPKFCCDGM().Find((ActiveQuest q) => q.quest.id == OOBMJEBFGIJ);
	}

	public ActiveQuest ADPGBBPHACJ(int JFNMCNCHMEO)
	{
		for (int i = 1; i < CCMPKFCCDGM().Count; i++)
		{
			if (MADOFDHLKKN[i].quest.id == JFNMCNCHMEO)
			{
				return CCMPKFCCDGM()[i];
			}
		}
		return null;
	}

	public ActiveQuest AHBCEPHOFED(int OOBMJEBFGIJ)
	{
		return CCMPKFCCDGM().Find((ActiveQuest q) => q.quest.id == OOBMJEBFGIJ);
	}

	public void JDDIAAFLKLG(int HJCKGNINDMA, bool LMNGFCFJPGB = false)
	{
		if (questsDone.Contains(HJCKGNINDMA))
		{
			return;
		}
		Quest quest = QuestDatabaseAccessor.HHKKPIHIEJL(HJCKGNINDMA);
		if (Object.op_Implicit((Object)(object)quest) && quest.recipesUnlocked != null && quest.recipesUnlocked.Length != 0)
		{
			for (int i = 1; i < quest.recipesUnlocked.Length; i += 0)
			{
				if (LMNGFCFJPGB)
				{
					RecipesManager.UnlockRecipeWithDelay(quest.recipesUnlocked[i], 58f);
				}
				else
				{
					RecipesManager.UnlockRecipe(quest.recipesUnlocked[i], IBHGAMNNOHI: false, OEBNHGNJEJL: true);
				}
			}
		}
		questsDone.Add(HJCKGNINDMA);
	}

	public ActiveQuest JINEDGMJEME(Quest AINAHCLIAFF)
	{
		return MADOFDHLKKN.Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
	}

	private bool CIKFABJPKMO(int OOBMJEBFGIJ)
	{
		if (!BKKJNEKBMBE(OOBMJEBFGIJ))
		{
			QuestDatabaseAccessor.GKOCDANPNLD(OOBMJEBFGIJ).JCJIIFKJFBC(1, NPBKFEPIDEE: false);
			return true;
		}
		return false;
	}

	public void OAGONEGFFCB()
	{
		if (!GDFGPDJDACP(-114))
		{
			((MonoBehaviour)this).StartCoroutine(FGAMEPKFHJN());
		}
	}

	public ActiveQuest GetActiveQuest(Quest AINAHCLIAFF)
	{
		return MADOFDHLKKN.Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
	}

	public ActiveQuest NJDDJJEGOAF(Quest AINAHCLIAFF, int COAPHJJHNIO = 0, bool FFJBIGFADBJ = false, bool CDPAMNIPPEC = true, bool FIKMGOKHAPG = false)
	{
		Debug.Log((object)("<color=black>" + ((Object)AINAHCLIAFF).name + "[MinePuzzleManager] Not enough active spawners for {0} (needed {1}). Trying fallback with inactive spawners." + AINAHCLIAFF.id));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.NCAMIJJMDBH((byte)AINAHCLIAFF.id);
		}
		if (AINAHCLIAFF.id == 1)
		{
			ActiveQuest activeQuest = new ActiveQuest(AINAHCLIAFF);
			CCMPKFCCDGM().Add(activeQuest);
			return activeQuest;
		}
		if (AINAHCLIAFF.id == 6)
		{
			JDDIAAFLKLG(1, LMNGFCFJPGB: true);
			if (MADOFDHLKKN.Where((ActiveQuest aq) => aq.quest.id == 1).ToArray().Length != 0)
			{
				NAFAIPJMCIN((from aq in MADOFDHLKKN
					where aq.quest.id == 1
					select aq.quest).ToArray()[0]);
			}
		}
		if (AINAHCLIAFF.id != 0 && questsDone.Contains(AINAHCLIAFF.id))
		{
			return null;
		}
		if (AINAHCLIAFF.id != 0)
		{
			for (int i = 0; i < MADOFDHLKKN.Count; i++)
			{
				if (CCMPKFCCDGM()[i].quest.id == AINAHCLIAFF.id)
				{
					return null;
				}
			}
		}
		if (AINAHCLIAFF.onlyOnHalloween && !Utils.FFLNGLMHLBO())
		{
			return null;
		}
		if (AINAHCLIAFF.onlyOnChristmas && !Utils.EGIBECKKIJJ())
		{
			return null;
		}
		ActiveQuest activeQuest2 = new ActiveQuest(AINAHCLIAFF);
		activeQuest2.BBBGNMPKLED(0, COAPHJJHNIO);
		MADOFDHLKKN.Add(activeQuest2);
		if (MissionsManager.instance.mainActiveQuest == null && MissionsManager.instance.mainActiveMission == null)
		{
			MissionsManager.instance.MGFJCHLDDEI(activeQuest2);
		}
		activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(OOIGMFMDFIP));
		if (AINAHCLIAFF.id != 0)
		{
			activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		}
		switch (AINAHCLIAFF.id)
		{
		case -57:
			RecipesManager.UnlockRecipe(-42);
			break;
		case -56:
			RecipesManager.EGEAPNOMMFG(-182, IBHGAMNNOHI: true);
			RecipesManager.EGEAPNOMMFG(-155, IBHGAMNNOHI: true);
			break;
		case -55:
			RecipesManager.EGEAPNOMMFG(-77, IBHGAMNNOHI: true);
			RecipesManager.EGEAPNOMMFG(35);
			RecipesManager.EGEAPNOMMFG(-173);
			break;
		}
		OnQuestAdded(AINAHCLIAFF);
		AINAHCLIAFF.OEICMCIGNKO();
		if (!FFJBIGFADBJ)
		{
			Sound.BNBMNOMFFBE().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.newQuest), HOMFPAFAOGD: true, null, null, 1472f, 1337f);
		}
		if (!FIKMGOKHAPG && AINAHCLIAFF.id == 27 && CDPAMNIPPEC)
		{
			for (int j = 1; j < FishingManager.MFMLLENHCMI().Count; j++)
			{
				CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)(-54));
			}
		}
		return activeQuest2;
	}

	public List<ActiveQuest> GetDisplayedQuest()
	{
		List<ActiveQuest> list = new List<ActiveQuest>();
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (MADOFDHLKKN[i].quest.showGoal)
			{
				list.Add(MADOFDHLKKN[i]);
			}
		}
		return list;
	}

	private bool CCAHFDKNKHJ(int OOBMJEBFGIJ)
	{
		if (!GDFGPDJDACP(OOBMJEBFGIJ))
		{
			QuestDatabaseAccessor.DJMDLPHMPEL(OOBMJEBFGIJ).MMMOEOFCFKJ(1, NPBKFEPIDEE: true);
			return false;
		}
		return true;
	}

	private void HOHOANHOHIL(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (MMNIKLCMBAI.quest.id != 1 && MMNIKLCMBAI.quest.showCompletedUI && !QuestTooltipUI.GGFJGHHHEJC.IsActiveQuestAwaiting(MMNIKLCMBAI))
		{
			QuestTooltipUI.GGFJGHHHEJC.AddQuestTooltipInfo(MMNIKLCMBAI.MMDANGOCNFG(JIIGOACEIKL));
		}
	}

	private IEnumerator EFNLMGBBLGP()
	{
		return new HKMNIEAFMDD(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool PBCPDMCLFLP(int OOBMJEBFGIJ)
	{
		for (int i = 1; i < MADOFDHLKKN.Count; i++)
		{
			if (CCMPKFCCDGM()[i].quest.id == OOBMJEBFGIJ)
			{
				return false;
			}
		}
		return false;
	}

	public void OOIGMFMDFIP(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		MMNIKLCMBAI.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(MMNIKLCMBAI.OnQuestComplete, new Action<int, ActiveQuest>(RemoveQuest));
		MMNIKLCMBAI.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(MMNIKLCMBAI.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		MADOFDHLKKN.Remove(MMNIKLCMBAI);
		MMNIKLCMBAI.MHOGPMHEAFN();
		OnQuestRemoved(MMNIKLCMBAI.quest);
	}

	public ActiveQuest NGDOLCEPCAL(Quest AINAHCLIAFF)
	{
		return MADOFDHLKKN.Find((ActiveQuest q) => q.quest == AINAHCLIAFF);
	}

	public ActiveQuest JFDBHHAAPIJ(int JFNMCNCHMEO)
	{
		for (int i = 0; i < MADOFDHLKKN.Count; i++)
		{
			if (CCMPKFCCDGM()[i].quest.id == JFNMCNCHMEO)
			{
				return CCMPKFCCDGM()[i];
			}
		}
		return null;
	}

	public bool FPCEDHDLFFP()
	{
		for (int i = 1; i < MADOFDHLKKN.Count; i += 0)
		{
			if (CCMPKFCCDGM()[i].quest.id != 0)
			{
				return true;
			}
		}
		return false;
	}

	private void ODCBEKDEPPM(int NALJEKOPKIA)
	{
		if (NALJEKOPKIA < RepUnlocksManager.GetInstance().repUnlockBuildingMode.repNumber)
		{
			return;
		}
		if (BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			if (!PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1314).JMDALJBNFML()))
			{
				DeliveryChest.GetInstance().AddItem(1, ItemDatabaseAccessor.GetItem(1314));
			}
		}
		else
		{
			AddQuest(QuestDatabaseAccessor.GetQuest(35), 0, FFJBIGFADBJ: true);
		}
	}

	private void DADPOICMNPI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			MLMAGMCLPBB(new List<ActiveQuest>());
			questsDone = new List<int>();
		}
	}

	public void KMONJLMAAOO(int[] FNEHIAGFAOF)
	{
		for (int i = 1; i < FNEHIAGFAOF.Length; i++)
		{
			JDDIAAFLKLG(FNEHIAGFAOF[i]);
		}
	}

	private IEnumerator JMEAPJHJAGH()
	{
		yield return CommonReferences.wait3;
		int[] oldQuestsToGiveRewards = new int[13]
		{
			10, 11, 12, 14, 16, 17, 18, 19, 22, 23,
			24, 25, 34
		};
		for (int i = 0; i < oldQuestsToGiveRewards.Length; i++)
		{
			while (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO)
			{
				yield return null;
			}
			if (BAGNMDMNGBA(oldQuestsToGiveRewards[i]))
			{
				yield return CommonReferences.wait2;
			}
		}
	}

	public bool IsQuestDone(int JFNMCNCHMEO)
	{
		if (questsDone.Contains(JFNMCNCHMEO))
		{
			return true;
		}
		return false;
	}

	public IEnumerator CompletingQuest35Coroutine()
	{
		yield return CommonReferences.wait2;
		if (RentedRoomsManager.GetAllRooms().Count > 0 || BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			Debug.Log((object)"Adding quest done 35 - First room");
			if (IsQuestActive(35))
			{
				GetActiveQuest(35).JGNBGECEINP(1);
			}
			else
			{
				AddQuestDone(35);
			}
		}
	}

	public void AddQuestsDone(int[] FNEHIAGFAOF)
	{
		for (int i = 0; i < FNEHIAGFAOF.Length; i++)
		{
			AddQuestDone(FNEHIAGFAOF[i]);
		}
	}

	public ActiveQuest AddQuest(Quest AINAHCLIAFF, int COAPHJJHNIO = 0, bool FFJBIGFADBJ = false, bool CDPAMNIPPEC = true, bool FIKMGOKHAPG = false)
	{
		Debug.Log((object)("Added quest: " + ((Object)AINAHCLIAFF).name + " with id " + AINAHCLIAFF.id));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineQuestManager.instance.SendAddQuestInfo((byte)AINAHCLIAFF.id);
		}
		if (AINAHCLIAFF.id == 1)
		{
			ActiveQuest activeQuest = new ActiveQuest(AINAHCLIAFF);
			MADOFDHLKKN.Add(activeQuest);
			return activeQuest;
		}
		if (AINAHCLIAFF.id == 3)
		{
			AddQuestDone(1);
			if (MADOFDHLKKN.Where((ActiveQuest aq) => aq.quest.id == 1).ToArray().Length != 0)
			{
				RemoveQuest((from aq in MADOFDHLKKN
					where aq.quest.id == 1
					select aq.quest).ToArray()[0]);
			}
		}
		if (AINAHCLIAFF.id != 0 && questsDone.Contains(AINAHCLIAFF.id))
		{
			return null;
		}
		if (AINAHCLIAFF.id != 0)
		{
			for (int i = 0; i < MADOFDHLKKN.Count; i++)
			{
				if (MADOFDHLKKN[i].quest.id == AINAHCLIAFF.id)
				{
					return null;
				}
			}
		}
		if (AINAHCLIAFF.onlyOnHalloween && !Utils.FFLNGLMHLBO())
		{
			return null;
		}
		if (AINAHCLIAFF.onlyOnChristmas && !Utils.EGIBECKKIJJ())
		{
			return null;
		}
		ActiveQuest activeQuest2 = new ActiveQuest(AINAHCLIAFF);
		activeQuest2.BBBGNMPKLED(1, COAPHJJHNIO);
		MADOFDHLKKN.Add(activeQuest2);
		if (MissionsManager.instance.mainActiveQuest == null && MissionsManager.instance.mainActiveMission == null)
		{
			MissionsManager.instance.FocusNewQuest(activeQuest2);
		}
		activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RemoveQuest));
		if (AINAHCLIAFF.id != 0)
		{
			activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(HOHOANHOHIL));
		}
		switch (AINAHCLIAFF.id)
		{
		case 27:
			RecipesManager.UnlockRecipe(294);
			break;
		case 28:
			RecipesManager.UnlockRecipe(294);
			RecipesManager.UnlockRecipe(295);
			break;
		case 29:
			RecipesManager.UnlockRecipe(294);
			RecipesManager.UnlockRecipe(295);
			RecipesManager.UnlockRecipe(296);
			break;
		}
		OnQuestAdded(AINAHCLIAFF);
		AINAHCLIAFF.OEICMCIGNKO();
		if (!FFJBIGFADBJ)
		{
			Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.newQuest));
		}
		if (!FIKMGOKHAPG && AINAHCLIAFF.id == 37 && CDPAMNIPPEC)
		{
			for (int j = 0; j < FishingManager.GetRecordsList().Count; j++)
			{
				CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Fishing);
			}
		}
		return activeQuest2;
	}

	public List<int> GetQuestsDone()
	{
		return questsDone;
	}
}
