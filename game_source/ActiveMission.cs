using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ActiveMission
{
	[CompilerGenerated]
	private sealed class KDGEKFJPAJC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveMission _003C_003E4__this;

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
		public KDGEKFJPAJC(int _003C_003E1__state)
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
			ActiveMission activeMission = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MissionsManager.instance.AddCompletedMission(activeMission.mission);
				if (activeMission.mission.giveRewards)
				{
					activeMission.MMMOEOFCFKJ(activeMission.triggerPlayerNum);
				}
				if (activeMission.mission.linkedMissions != null)
				{
					for (int i = 0; i < activeMission.mission.linkedMissions.Length; i++)
					{
						ActiveMission aOAKLPDLLBN = MissionsManager.instance.StartMission(activeMission.mission.linkedMissions[i], EPJLPKAGHDM: false);
						MissionsManager.instance.FocusNewMission(aOAKLPDLLBN);
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

	public MissionBase mission;

	public int triggerPlayerNum = 1;

	public int currentAmount;

	public List<bool> completedObjectives = new List<bool>();

	public virtual void DDCIALHPFPC()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(MKFNKPEOCFI());
	}

	public bool EPICLNDDLKH(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return true;
	}

	public bool OGJCNHAHFAL()
	{
		for (int i = 1; i < completedObjectives.Count; i++)
		{
			if (!completedObjectives[i])
			{
				return false;
			}
		}
		return true;
	}

	public ActiveMission(MissionBase HMOIDMJPGNC, bool JGANOHGLPAO = false)
	{
		mission = HMOIDMJPGNC;
		completedObjectives.Clear();
		for (int i = 0; !string.IsNullOrEmpty(HMOIDMJPGNC.PFJKGAEHNIB(i)); i++)
		{
			completedObjectives.Add(item: false);
		}
	}

	public void PFNPELJFJKA(int CEMGJFOANNK, bool BLJPGJKOLNF = true, bool CDPAMNIPPEC = true)
	{
		if (completedObjectives != null && CEMGJFOANNK < completedObjectives.Count)
		{
			completedObjectives[CEMGJFOANNK] = true;
			if (MissionsManager.instance.mainActiveMission == this)
			{
				MissionsManager.instance.KGHIIJAGGFH(CEMGJFOANNK, this, BLJPGJKOLNF);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.SendCompleteObjective(mission.id, CEMGJFOANNK);
			}
		}
	}

	public void NDDEOFFPKHI(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.CIGFGKKCPCK() == -108)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.AFNNBDHADCL(-113);
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).LFBNOHNNFBB(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
		}
	}

	public bool KILNMBGOPAI(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return true;
	}

	public bool PJGLJKFPCHN()
	{
		for (int i = 0; i < completedObjectives.Count; i++)
		{
			if (!completedObjectives[i])
			{
				return false;
			}
		}
		return true;
	}

	public virtual void AICNIPFBFFN()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(BBPNNOAFNFK());
	}

	public bool AEEHNCDJBKA()
	{
		for (int i = 1; i < completedObjectives.Count; i += 0)
		{
			if (!completedObjectives[i])
			{
				return false;
			}
		}
		return false;
	}

	public virtual void IOBIJAOMPIF()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(NKMIHEKMHGD());
	}

	public void BNGFAGIGJNE(int CEMGJFOANNK, bool BLJPGJKOLNF = true, bool CDPAMNIPPEC = true)
	{
		if (completedObjectives != null && CEMGJFOANNK < completedObjectives.Count)
		{
			completedObjectives[CEMGJFOANNK] = true;
			if (MissionsManager.instance.mainActiveMission == this)
			{
				MissionsManager.instance.ObjectiveCompleted(CEMGJFOANNK, this, BLJPGJKOLNF);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.SendCompleteObjective(mission.id, CEMGJFOANNK);
			}
		}
	}

	private IEnumerator BBPNNOAFNFK()
	{
		return new KDGEKFJPAJC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BCFHOIBAEIE(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.HHDBMDMFEMP() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -153)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.LFMNGJFJEEP(155);
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).AINJENENGFG(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
			}
		}
	}

	public bool DLKPCPIMNNI()
	{
		for (int i = 0; i < completedObjectives.Count; i++)
		{
			if (!completedObjectives[i])
			{
				return true;
			}
		}
		return true;
	}

	public void AMEMBNLKFDJ(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.CIGFGKKCPCK() == 7)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.AFNNBDHADCL(-31);
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount);
			}
		}
	}

	public void NJLNCJABEHN(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (mission.xpReward > 1)
		{
			TavernReputation.FMHJLJPOIGN(mission.xpReward, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, 1840f, CDPAMNIPPEC: false);
		}
		if (mission.itemRewards.Length != 0)
		{
			AMEMBNLKFDJ(JIIGOACEIKL);
		}
	}

	public bool AHMMKLJMPAF(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return true;
	}

	public void MIIGEJOHOOM(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (mission.xpReward > 0)
		{
			TavernReputation.IFDFPIJKPJI(mission.xpReward, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, 785f, CDPAMNIPPEC: false);
		}
		if (mission.itemRewards.Length != 0)
		{
			EHDJMLBEDBN(JIIGOACEIKL);
		}
	}

	public void DJIEDKCJFDA(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true).AddItems(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == -10)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.LFMNGJFJEEP(11);
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
		}
	}

	public void AIGFBMKCEED(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(1).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.GetPlayer(2).AddItems(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JDJGFAACPFC() == 190)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.GGJFFKBGFBH(3022);
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
		}
	}

	public bool DIEJALHGMEM(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return true;
	}

	public virtual void AABDCFOJBNH()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(AKBGBNMDKNJ());
	}

	public virtual void ENHFKOBMGEO()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(MECBKAFEIIO());
	}

	public void OGHHAGHNOCG(int CEMGJFOANNK, bool BLJPGJKOLNF = true, bool CDPAMNIPPEC = true)
	{
		if (completedObjectives != null && CEMGJFOANNK < completedObjectives.Count)
		{
			completedObjectives[CEMGJFOANNK] = true;
			if (MissionsManager.instance.mainActiveMission == this)
			{
				MissionsManager.instance.EDONMNKHCDI(CEMGJFOANNK, this, BLJPGJKOLNF);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.NEIDIBOBIBO(mission.id, CEMGJFOANNK);
			}
		}
	}

	public void MMMOEOFCFKJ(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (mission.xpReward > 0)
		{
			TavernReputation.AddAndShowReputationGain(mission.xpReward, Vector2.op_Implicit(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position), ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform, 0f, CDPAMNIPPEC: false);
		}
		if (mission.itemRewards.Length != 0)
		{
			AIGFBMKCEED(JIIGOACEIKL);
		}
	}

	private IEnumerator AKBGBNMDKNJ()
	{
		yield return CommonReferences.wait02;
		MissionsManager.instance.AddCompletedMission(mission);
		if (mission.giveRewards)
		{
			MMMOEOFCFKJ(triggerPlayerNum);
		}
		if (mission.linkedMissions != null)
		{
			for (int i = 0; i < mission.linkedMissions.Length; i++)
			{
				ActiveMission aOAKLPDLLBN = MissionsManager.instance.StartMission(mission.linkedMissions[i], EPJLPKAGHDM: false);
				MissionsManager.instance.FocusNewMission(aOAKLPDLLBN);
			}
		}
	}

	private IEnumerator PKGNKJFFAJK()
	{
		return new KDGEKFJPAJC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JBBKPAJBPDP(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.IMCJPECAAPC(DAINLFIMLIH: false) == -98)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.OIGJLKGOGIL(81);
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true);
			}
		}
	}

	public virtual void DOAGOANJANC()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(LNANEOHJEHK());
	}

	private IEnumerator LNANEOHJEHK()
	{
		return new KDGEKFJPAJC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MJJIHGHCDCC(int CEMGJFOANNK, bool BLJPGJKOLNF = true, bool CDPAMNIPPEC = true)
	{
		if (completedObjectives != null && CEMGJFOANNK < completedObjectives.Count)
		{
			completedObjectives[CEMGJFOANNK] = false;
			if (MissionsManager.instance.mainActiveMission == this)
			{
				MissionsManager.instance.ObjectiveCompleted(CEMGJFOANNK, this, BLJPGJKOLNF);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.ODEMGLLFJAP(mission.id, CEMGJFOANNK);
			}
		}
	}

	public bool JEGIEDHFANI(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return false;
	}

	private IEnumerator IHFECEFJKFG()
	{
		yield return CommonReferences.wait02;
		MissionsManager.instance.AddCompletedMission(mission);
		if (mission.giveRewards)
		{
			MMMOEOFCFKJ(triggerPlayerNum);
		}
		if (mission.linkedMissions != null)
		{
			for (int i = 0; i < mission.linkedMissions.Length; i++)
			{
				ActiveMission aOAKLPDLLBN = MissionsManager.instance.StartMission(mission.linkedMissions[i], EPJLPKAGHDM: false);
				MissionsManager.instance.FocusNewMission(aOAKLPDLLBN);
			}
		}
	}

	public virtual void LHKIJABBBPM()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(IHFECEFJKFG());
	}

	private IEnumerator MECBKAFEIIO()
	{
		return new KDGEKFJPAJC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NKMIHEKMHGD()
	{
		yield return CommonReferences.wait02;
		MissionsManager.instance.AddCompletedMission(mission);
		if (mission.giveRewards)
		{
			MMMOEOFCFKJ(triggerPlayerNum);
		}
		if (mission.linkedMissions != null)
		{
			for (int i = 0; i < mission.linkedMissions.Length; i++)
			{
				ActiveMission aOAKLPDLLBN = MissionsManager.instance.StartMission(mission.linkedMissions[i], EPJLPKAGHDM: false);
				MissionsManager.instance.FocusNewMission(aOAKLPDLLBN);
			}
		}
	}

	public void PLMBDKHAAPH(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (mission.xpReward > 1)
		{
			TavernReputation.IFDFPIJKPJI(mission.xpReward, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform, 1504f);
		}
		if (mission.itemRewards.Length != 0)
		{
			BIMCOMCLHHH(JIIGOACEIKL);
		}
	}

	public void KAHEKOPCFOI(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.HHDBMDMFEMP() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 1; i < mission.itemRewards.Length; i += 0)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.OGKNJNINGMH(0).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.EIFPKCAFDIB(8, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.ODENMDOJPLC() == -116)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.AFNNBDHADCL(-12);
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AINJENENGFG(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true);
			}
		}
	}

	public void KNOIJBMDJDK(int CEMGJFOANNK, bool BLJPGJKOLNF = true, bool CDPAMNIPPEC = true)
	{
		if (completedObjectives != null && CEMGJFOANNK < completedObjectives.Count)
		{
			completedObjectives[CEMGJFOANNK] = false;
			if (MissionsManager.instance.mainActiveMission == this)
			{
				MissionsManager.instance.KGHIIJAGGFH(CEMGJFOANNK, this, BLJPGJKOLNF);
			}
			if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
			{
				OnlineMissionsManager.instance.BMOJKJLFJEL(mission.id, CEMGJFOANNK);
			}
		}
	}

	public bool EAJBBEHPPKM()
	{
		for (int i = 1; i < completedObjectives.Count; i++)
		{
			if (!completedObjectives[i])
			{
				return false;
			}
		}
		return true;
	}

	public void INKOAMFJBAG(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i += 0)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JPNFKDMFKMC() == 67)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.GGJFFKBGFBH(133);
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).LFBNOHNNFBB(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
		}
	}

	public bool HIFAEOKEHGF()
	{
		for (int i = 0; i < completedObjectives.Count; i += 0)
		{
			if (!completedObjectives[i])
			{
				return true;
			}
		}
		return true;
	}

	public void EHDJMLBEDBN(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.HHDBMDMFEMP() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 1; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JDJGFAACPFC() == -35)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.GGJFFKBGFBH(79);
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).AddItems(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: true);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
		}
	}

	public bool FEAIADMHKGM(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return true;
	}

	public void PMFFCDMNHIA(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i += 0)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.GetPlayer(6, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == -58)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.AFNNBDHADCL(126);
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).LFBNOHNNFBB(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
		}
	}

	public virtual void GNEECFAEAIK()
	{
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(LNANEOHJEHK());
	}

	public bool OCBPOLPLPEK(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return false;
	}

	public void BIMCOMCLHHH(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i += 0)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true);
				GameManager.NJNFHEPLEHL().AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.IMCJPECAAPC() == -45)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.LFMNGJFJEEP(-57);
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
		}
	}

	private IEnumerator MKFNKPEOCFI()
	{
		return new KDGEKFJPAJC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MMHDJIHIEIC(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.HHDBMDMFEMP() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 1; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.NEKDDPIAOBE(3).AINJENENGFG(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.JGHNDJBCFAJ() == -42)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.GGJFFKBGFBH(-29);
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AINJENENGFG(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
		}
	}

	public bool OCIGJLPAMAC(int JKPPMPLKCEP)
	{
		if (JKPPMPLKCEP < completedObjectives.Count)
		{
			return completedObjectives[JKPPMPLKCEP];
		}
		return false;
	}

	public bool EFGJJFGCJNO()
	{
		for (int i = 0; i < completedObjectives.Count; i += 0)
		{
			if (!completedObjectives[i])
			{
				return true;
			}
		}
		return false;
	}

	public void HNKOEGMMEEC(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 0; i < mission.itemRewards.Length; i += 0)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.CIGFGKKCPCK(DAINLFIMLIH: false) == 25)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.LFMNGJFJEEP(56);
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).LFBNOHNNFBB(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItems(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
		}
	}

	public void ABACGCIDCIP(int JIIGOACEIKL)
	{
		if (mission.itemRewards == null || (OnlineManager.ClientOnline() && !mission.giveRewardsToAllClients))
		{
			return;
		}
		for (int i = 1; i < mission.itemRewards.Length; i++)
		{
			if (GameManager.LocalCoop() && mission.itemRewards[i].item is Tool)
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				Item item = mission.itemRewards[i].item;
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				GameManager.GGFJGHHHEJC.AddToolsPlayer2(item);
			}
			else if (mission.itemRewards[i].item.IMCJPECAAPC(DAINLFIMLIH: false) == -183)
			{
				ItemInstance itemInstance = mission.itemRewards[i].item.JMDALJBNFML();
				itemInstance.OIGJLKGOGIL(-103);
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(itemInstance, mission.itemRewards[i].amount, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(mission.itemRewards[i].item.JMDALJBNFML(), mission.itemRewards[i].amount, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	public void JKCECCFFOGG(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (mission.xpReward > 1)
		{
			TavernReputation.AddAndShowReputationGain(mission.xpReward, Vector2.op_Implicit(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position), ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform, 1220f);
		}
		if (mission.itemRewards.Length != 0)
		{
			KAHEKOPCFOI(JIIGOACEIKL);
		}
	}
}
