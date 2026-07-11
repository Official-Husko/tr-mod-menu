using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionActonDone", menuName = "Missions/MissionActonDone")]
public class MissionActionDone : MissionBase
{
	public ActionDone action;

	private void CHADOMCDNGL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
				activeMission.BNGFAGIGJNE(0);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void MIICHMNMEDP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(OLBHDKLMILG));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void KEDBKAOPOBO(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(EEEGDIJKBPD));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void MJAAIPNHFKC(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(GMDJCHOKHCH));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void GBCBPKMPLCI(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(GBCBPKMPLCI));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void IOGMEINNIMN(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(OLBHDKLMILG));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void PDLJCMIHKOA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void JDBHIJBLLLH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(IBDGJAFBAAL));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void IEEEKMBEGIL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(GBCBPKMPLCI));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	public override void DDGEPPLPJHI()
	{
		base.DDGEPPLPJHI();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
		if (id == 303 || id == 305 || id == 307)
		{
			int num = (id - 303) / 2;
			TheloniusNPC.GGFJGHHHEJC.ActiveForm(num);
		}
	}

	private void IHNJIACNICP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EKOIBCMBGOP));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void FMJEADKBLLJ(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EGJACPEPJAJ));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void ICNCKPJEBJF(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
				activeMission.PFNPELJFJKA(1);
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void AHEMFKMJBPN(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EKOIBCMBGOP));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void LBKKOFPLHLH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EGJACPEPJAJ));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void HNEBBBBLBKL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(KCMGGLDMDDC));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void OLBHDKLMILG(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(PDLJCMIHKOA));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void EKOIBCMBGOP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(FMJEGNDDCAH));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void PLCNKLHCBOA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(OLBHDKLMILG));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void GMDJCHOKHCH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(EEEGDIJKBPD));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void AMDHNHEFJLP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(KCMGGLDMDDC));
				activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void FMJEGNDDCAH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(MIICHMNMEDP));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void LPEBGJFBLOG(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(GBCBPKMPLCI));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void IBDGJAFBAAL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(MIICHMNMEDP));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void EPDLIBBOHBL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EPDLIBBOHBL));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void EEEGDIJKBPD(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(IOGMEINNIMN));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
		}
	}

	private void KCMGGLDMDDC(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(AMDHNHEFJLP));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void EGJACPEPJAJ(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action == OKNOJJEFEBE)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EPDLIBBOHBL));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
		}
	}
}
