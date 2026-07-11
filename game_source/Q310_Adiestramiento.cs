using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Q310_Adiestramiento", menuName = "Missions/Q310_Adiestramiento")]
public class Q310_Adiestramiento : MissionBase
{
	private void GLMMAOPAIEC(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(116))
		{
			activeMission.MJJIHGHCDCC(0);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(147))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-31) || EventsManager.IsDone((EventsManager.EventType)76))
		{
			activeMission.KNOIJBMDJDK(7, BLJPGJKOLNF: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(MKNCNCIPOKK));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(PGBMDCEKKEO));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(64);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void JCPGEJNAJKG(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(-161))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(89))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-151) || EventsManager.IsDone((EventsManager.EventType)31))
		{
			activeMission.BNGFAGIGJNE(6, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(HMCJBDEDAGP));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(IIBKCGLAMMJ));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(18, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void IBOMEMEJBJP(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-61))
		{
			activeMission.OGHHAGHNOCG(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(179))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(10) || EventsManager.GGGECIBEKJG((EventsManager.EventType)(-1)))
		{
			activeMission.BNGFAGIGJNE(7, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(MPKDHLPJAKC));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(HMCJBDEDAGP));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-18);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void COLENBDBDEI(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(-109))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-108))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-46) || EventsManager.DOPLDNPIBPP((EventsManager.EventType)71))
		{
			activeMission.BNGFAGIGJNE(7);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(MKNCNCIPOKK));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(LFGFLCACLGA));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(123, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void IIBKCGLAMMJ(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(-181))
		{
			activeMission.PFNPELJFJKA(1);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(134))
		{
			activeMission.PFNPELJFJKA(1);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-135) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-97)))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(LFGFLCACLGA));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(GDFCKDDEBPK));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(2, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void KBDAGCBMDBF(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(156))
		{
			activeMission.PFNPELJFJKA(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(166))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-141) || EventsManager.AEFHILOAEEE((EventsManager.EventType)(-67)))
		{
			activeMission.KNOIJBMDJDK(6);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(IIBKCGLAMMJ));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(ICOFEIGKOGM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-119);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void CHGIELNDMAI(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(-144))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(154))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(93) || EventsManager.AEFHILOAEEE((EventsManager.EventType)47))
		{
			activeMission.PFNPELJFJKA(5, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(BOEBOLMLHJH));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(BMLAICPCDDL));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-23, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void HEPIJDIJDOO(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(25))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-42))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (MissionsManager.instance.IsMissionComplete(-104) || EventsManager.FDIHEFGPKFP(EventsManager.EventType.CastleForm))
		{
			activeMission.KNOIJBMDJDK(8, BLJPGJKOLNF: false);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(IABADMPBNGI));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(OHJAKJBBPBM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(94);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void AFGLBOPHIPH(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(75))
		{
			activeMission.BNGFAGIGJNE(0);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-25))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-74) || EventsManager.IsDone((EventsManager.EventType)(-29)))
		{
			activeMission.KNOIJBMDJDK(6, BLJPGJKOLNF: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(ALIAFLOBBII));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(HDBACDKNAHC));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(37);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void IDLJNKJOMMF(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(-51))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(108))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-123) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)39))
		{
			activeMission.PFNPELJFJKA(6, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(BOEBOLMLHJH));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(AOKGHJLMCHO));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-32);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void DMFMGNGODOD(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(189))
		{
			activeMission.PFNPELJFJKA(0);
		}
		if (MissionsManager.instance.IsMissionComplete(158))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(195) || EventsManager.FDIHEFGPKFP((EventsManager.EventType)31))
		{
			activeMission.OGHHAGHNOCG(5, BLJPGJKOLNF: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(IFBDMIBIDNO));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(JCPGEJNAJKG));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(110);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void PGBMDCEKKEO(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(107))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(181))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(147) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)42))
		{
			activeMission.OGHHAGHNOCG(5, BLJPGJKOLNF: false);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(HIAHLELPACK));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(AFGLBOPHIPH));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(71);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void PFCPJJGLJMK(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-143))
		{
			activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-83))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-176) || EventsManager.OOCOFHECMDA((EventsManager.EventType)34))
		{
			activeMission.MJJIHGHCDCC(4, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(CLHAJIIAKCI));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(GDFCKDDEBPK));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-75);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void JFDMPPPGGCC(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(315))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(316))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(319) || EventsManager.IsDone(EventsManager.EventType.Fortitude))
		{
			activeMission.BNGFAGIGJNE(2, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(JFDMPPPGGCC));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(JFDMPPPGGCC));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(39);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void GHMHLALJAKM(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(104))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(7))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(116) || EventsManager.ALEMDEBCFDH((EventsManager.EventType)27))
		{
			activeMission.PFNPELJFJKA(5, BLJPGJKOLNF: false);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(COCNGMMINKF));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(MPKDHLPJAKC));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-51);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void NNKDPDNFMGB(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(118))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-6))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(145) || EventsManager.GGGECIBEKJG((EventsManager.EventType)68))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(HDBACDKNAHC));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(DMFMGNGODOD));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-65);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void LKEDLKKGPGH(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-122))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(115))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-163) || EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-34)))
		{
			activeMission.PFNPELJFJKA(5, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(KBFKAHDGFLA));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(AOKGHJLMCHO));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-70, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void FJNNFOHKOEL(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(56))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(171))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-43) || EventsManager.AEFHILOAEEE((EventsManager.EventType)43))
		{
			activeMission.OGHHAGHNOCG(8, BLJPGJKOLNF: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(COCNGMMINKF));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(POMGNHIOEBB));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-85, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void OINGKNIIAAG(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(134))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(39))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-5) || EventsManager.AEFHILOAEEE((EventsManager.EventType)(-36)))
		{
			activeMission.OGHHAGHNOCG(6, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(MKHBKMDNGKE));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(HEPIJDIJDOO));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-79, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void COCNGMMINKF(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(37))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(4))
		{
			activeMission.OGHHAGHNOCG(1);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-156) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)122))
		{
			activeMission.KNOIJBMDJDK(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(PFCPJJGLJMK));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(FJNNFOHKOEL));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-18, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void DLOIFMIMOJA(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(116))
		{
			activeMission.KNOIJBMDJDK(0);
		}
		if (MissionsManager.instance.IsMissionComplete(181))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-36) || EventsManager.OOCOFHECMDA((EventsManager.EventType)90))
		{
			activeMission.BNGFAGIGJNE(7);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(AJEJFNLDBAH));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(MKNCNCIPOKK));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(44, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void MKHBKMDNGKE(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(176))
		{
			activeMission.MJJIHGHCDCC(0);
		}
		if (MissionsManager.instance.IsMissionComplete(-87))
		{
			activeMission.MJJIHGHCDCC(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(40) || EventsManager.OOCOFHECMDA((EventsManager.EventType)(-74)))
		{
			activeMission.BNGFAGIGJNE(2, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(LKEDLKKGPGH));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(OHJAKJBBPBM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(30, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void LHLPKLMPEBJ(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-46))
		{
			activeMission.PFNPELJFJKA(1);
		}
		if (MissionsManager.instance.IsMissionComplete(-139))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(187) || EventsManager.OOCOFHECMDA((EventsManager.EventType)64))
		{
			activeMission.OGHHAGHNOCG(3, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(HDBACDKNAHC));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(LFGFLCACLGA));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(33);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void HDBACDKNAHC(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-188))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-93))
		{
			activeMission.BNGFAGIGJNE(0);
		}
		if (MissionsManager.instance.IsMissionComplete(45) || EventsManager.DOPLDNPIBPP((EventsManager.EventType)112))
		{
			activeMission.KNOIJBMDJDK(6);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(BOMDKAMONPM));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(OINGKNIIAAG));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(120, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void PLJBBKMIAAO(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(-109))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (MissionsManager.instance.IsMissionComplete(-117))
		{
			activeMission.BNGFAGIGJNE(0);
		}
		if (MissionsManager.instance.IsMissionComplete(155) || EventsManager.AEFHILOAEEE((EventsManager.EventType)(-4)))
		{
			activeMission.PFNPELJFJKA(6);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(EECGOJGABIH));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(BOMDKAMONPM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-119);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void MKNCNCIPOKK(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(120))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(185))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-171) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)70))
		{
			activeMission.OGHHAGHNOCG(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(JCPGEJNAJKG));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(COCNGMMINKF));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-54);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void HMCJBDEDAGP(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(40))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(14))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(65) || EventsManager.FDIHEFGPKFP((EventsManager.EventType)23))
		{
			activeMission.KNOIJBMDJDK(8, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(COLENBDBDEI));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(MPKDHLPJAKC));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(20);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void POMGNHIOEBB(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(-65))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(20))
		{
			activeMission.BNGFAGIGJNE(1);
		}
		if (MissionsManager.instance.IsMissionComplete(-31) || EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-80)))
		{
			activeMission.MJJIHGHCDCC(3, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(BOEBOLMLHJH));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(IFBDMIBIDNO));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-67);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void NGEPABFDBAK(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-9))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(47))
		{
			activeMission.OGHHAGHNOCG(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(86) || EventsManager.GGGECIBEKJG((EventsManager.EventType)73))
		{
			activeMission.PFNPELJFJKA(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(HDBACDKNAHC));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(LNEHFLPIGAM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-53);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void JEFKCPONJIJ(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(126))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(57))
		{
			activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(100) || EventsManager.FDIHEFGPKFP(EventsManager.EventType.MothersRecipe))
		{
			activeMission.BNGFAGIGJNE(3, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(ICOFEIGKOGM));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(GHMHLALJAKM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-27);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void GIIGCFECHPH(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(-22))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-45))
		{
			activeMission.BNGFAGIGJNE(1);
		}
		if (MissionsManager.instance.IsMissionComplete(-70) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-128)))
		{
			activeMission.PFNPELJFJKA(4);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(NGEPABFDBAK));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(HDBACDKNAHC));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-15, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void IABADMPBNGI(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-151))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(198))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-34) || EventsManager.ALEMDEBCFDH((EventsManager.EventType)81))
		{
			activeMission.OGHHAGHNOCG(8, BLJPGJKOLNF: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(JFDMPPPGGCC));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(COLENBDBDEI));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(93);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void GDFCKDDEBPK(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-55))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-181))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(155) || EventsManager.HGALHLALOKJ((EventsManager.EventType)(-118)))
		{
			activeMission.OGHHAGHNOCG(5, BLJPGJKOLNF: false);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(COLENBDBDEI));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(LNEHFLPIGAM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(98, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void HJMIBKHGOHE(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(88))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-185))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-165) || EventsManager.OOCOFHECMDA((EventsManager.EventType)35))
		{
			activeMission.MJJIHGHCDCC(4);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(COCNGMMINKF));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(NNKDPDNFMGB));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-43, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void LNEHFLPIGAM(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(-194))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(174))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-110) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-9)))
		{
			activeMission.BNGFAGIGJNE(4, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(ALIAFLOBBII));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(OHJAKJBBPBM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-40, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void EGIGLFONDAP(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-100))
		{
			activeMission.PFNPELJFJKA(0);
		}
		if (MissionsManager.instance.IsMissionComplete(183))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-102) || EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-49)))
		{
			activeMission.PFNPELJFJKA(3, BLJPGJKOLNF: false);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(OINGKNIIAAG));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(HDBACDKNAHC));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-50);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void ICOFEIGKOGM(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(30))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-24))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(78) || EventsManager.IsDone((EventsManager.EventType)(-41)))
		{
			activeMission.OGHHAGHNOCG(4, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(HJMIBKHGOHE));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(KBDAGCBMDBF));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-31);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void BOEBOLMLHJH(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-121))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(106))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(19) || EventsManager.GGGECIBEKJG((EventsManager.EventType)22))
		{
			activeMission.MJJIHGHCDCC(2);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(COCNGMMINKF));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(HJMIBKHGOHE));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-58, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void LFGFLCACLGA(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(127))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-99))
		{
			activeMission.PFNPELJFJKA(0);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-5) || EventsManager.FDIHEFGPKFP(EventsManager.EventType.AdventureContinues))
		{
			activeMission.MJJIHGHCDCC(5, BLJPGJKOLNF: false);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(EECGOJGABIH));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(BOMDKAMONPM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-77);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void IFBDMIBIDNO(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(65))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(19))
		{
			activeMission.MJJIHGHCDCC(1);
		}
		if (MissionsManager.instance.IsMissionComplete(-96) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)67))
		{
			activeMission.KNOIJBMDJDK(4, BLJPGJKOLNF: false);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(IDLJNKJOMMF));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(OHJAKJBBPBM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-100);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void AJEJFNLDBAH(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(139))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-108))
		{
			activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-16) || EventsManager.HGALHLALOKJ(EventsManager.EventType.Puente_EA))
		{
			activeMission.OGHHAGHNOCG(6, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.EFGJJFGCJNO())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(KBDAGCBMDBF));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(GHMHLALJAKM));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-29, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void ALIAFLOBBII(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(3))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-112))
		{
			activeMission.PFNPELJFJKA(1);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-44) || EventsManager.GGGECIBEKJG((EventsManager.EventType)(-16)))
		{
			activeMission.PFNPELJFJKA(0);
		}
		if (activeMission.PJGLJKFPCHN())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(GIIGCFECHPH));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(CHGIELNDMAI));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(113, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void IHNBEMFIFHI(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(34))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-39))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-119) || EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-51)))
		{
			activeMission.KNOIJBMDJDK(4, BLJPGJKOLNF: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(IFBDMIBIDNO));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(CHGIELNDMAI));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-45, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void CLHAJIIAKCI(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(159))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-57))
		{
			activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-118) || EventsManager.OOCOFHECMDA((EventsManager.EventType)(-41)))
		{
			activeMission.MJJIHGHCDCC(8);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(PFCPJJGLJMK));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(AJEJFNLDBAH));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(107, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void KBFKAHDGFLA(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(197))
		{
			activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-134))
		{
			activeMission.MJJIHGHCDCC(0);
		}
		if (MissionsManager.instance.BMFOFINGDLK(103) || EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-32)))
		{
			activeMission.MJJIHGHCDCC(0);
		}
		if (activeMission.EAJBBEHPPKM())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(PFCPJJGLJMK));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(AOKGHJLMCHO));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-58, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void HIAHLELPACK(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(-199))
		{
			activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(-120))
		{
			activeMission.OGHHAGHNOCG(0);
		}
		if (MissionsManager.instance.BMFOFINGDLK(16) || EventsManager.AEFHILOAEEE((EventsManager.EventType)118))
		{
			activeMission.KNOIJBMDJDK(8, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(ICOFEIGKOGM));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(COLENBDBDEI));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-119);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void MPKDHLPJAKC(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-82))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-98))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(77) || EventsManager.ALEMDEBCFDH((EventsManager.EventType)55))
		{
			activeMission.BNGFAGIGJNE(2, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (activeMission.DLKPCPIMNNI())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(HMCJBDEDAGP));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(AJEJFNLDBAH));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(85, CDPAMNIPPEC: true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void EECGOJGABIH(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(44))
		{
			activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(7))
		{
			activeMission.BNGFAGIGJNE(1);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-32) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)82))
		{
			activeMission.KNOIJBMDJDK(2, BLJPGJKOLNF: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(IHNBEMFIFHI));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(IHNBEMFIFHI));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-119, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void NAIECPBBIIJ(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(91))
		{
			activeMission.KNOIJBMDJDK(1);
		}
		if (MissionsManager.instance.IsMissionComplete(127))
		{
			activeMission.KNOIJBMDJDK(0);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-1) || EventsManager.AEFHILOAEEE((EventsManager.EventType)93))
		{
			activeMission.BNGFAGIGJNE(3, BLJPGJKOLNF: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(LNEHFLPIGAM));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(BOEBOLMLHJH));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(30);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void BMLAICPCDDL(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(46))
		{
			activeMission.OGHHAGHNOCG(0);
		}
		if (MissionsManager.instance.BMFOFINGDLK(25))
		{
			activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(170) || EventsManager.OMNBJDPGPEN(EventsManager.EventType.MaiWorried))
		{
			activeMission.PFNPELJFJKA(6, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(HMCJBDEDAGP));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(JCPGEJNAJKG));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-16, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.LHKIJABBBPM();
			}
		}
	}

	public override void DDGEPPLPJHI()
	{
		base.DDGEPPLPJHI();
		JFDMPPPGGCC(1);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnMissionComplete = (Action<int>)Delegate.Combine(instance.OnMissionComplete, new Action<int>(JFDMPPPGGCC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnEventComplete = (Action<int>)Delegate.Combine(instance2.OnEventComplete, new Action<int>(JFDMPPPGGCC));
	}

	private void OHJAKJBBPBM(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.BMFOFINGDLK(12))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.BMFOFINGDLK(42))
		{
			activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-75) || EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-25)))
		{
			activeMission.MJJIHGHCDCC(4, BLJPGJKOLNF: false);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(KBDAGCBMDBF));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnEventComplete = (Action<int>)Delegate.Remove(instance2.OnEventComplete, new Action<int>(FJNNFOHKOEL));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-106);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void CBHOLBFOPED(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(169))
		{
			activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.IsMissionComplete(-74))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(164) || EventsManager.ALEMDEBCFDH(EventsManager.EventType.FinalTest))
		{
			activeMission.PFNPELJFJKA(3, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.AEEHNCDJBKA())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(LKEDLKKGPGH));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnEventComplete = (Action<int>)Delegate.Remove(instance.OnEventComplete, new Action<int>(DLOIFMIMOJA));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(24, CDPAMNIPPEC: true);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void BOMDKAMONPM(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-116))
		{
			activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-71))
		{
			activeMission.OGHHAGHNOCG(1);
		}
		if (MissionsManager.instance.BMFOFINGDLK(109) || EventsManager.GGGECIBEKJG(EventsManager.EventType.ThroneRoom))
		{
			activeMission.PFNPELJFJKA(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (activeMission.HIFAEOKEHGF())
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnMissionComplete = (Action<int>)Delegate.Remove(instance.OnMissionComplete, new Action<int>(HDBACDKNAHC));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences.OnEventComplete, new Action<int>(JCPGEJNAJKG));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-57);
			if (OnlineManager.PGAGDFAEEFB())
			{
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void AOKGHJLMCHO(int JIIGOACEIKL)
	{
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission == null)
		{
			return;
		}
		if (MissionsManager.instance.IsMissionComplete(184))
		{
			activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(-98))
		{
			activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
		}
		if (MissionsManager.instance.LLOBLPDJNJE(144) || EventsManager.HGALHLALOKJ((EventsManager.EventType)19))
		{
			activeMission.BNGFAGIGJNE(8, BLJPGJKOLNF: false);
		}
		if (activeMission.OGJCNHAHFAL())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnMissionComplete = (Action<int>)Delegate.Remove(commonReferences.OnMissionComplete, new Action<int>(LFGFLCACLGA));
			CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
			commonReferences2.OnEventComplete = (Action<int>)Delegate.Remove(commonReferences2.OnEventComplete, new Action<int>(HIAHLELPACK));
			FinalTestEvent.instance.ActivateEvent();
			Utils.DLIIAHACOJB(-68);
			if (OnlineManager.MasterOrOffline())
			{
				activeMission.IOBIJAOMPIF();
			}
		}
	}
}
