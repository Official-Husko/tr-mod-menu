using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionWithProgress", menuName = "Missions/MissionWithProgress")]
public class MissionWithProgress : MissionBase
{
	public ActionDone action;

	public int requiredAmount;

	private void OLBHDKLMILG(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(NFLOGGFIODM));
				activeMission.MJJIHGHCDCC(1);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void MMEAFELGGEH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CLBLJCBOIHG));
				activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void IHNJIACNICP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(PDLJCMIHKOA));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.DOAGOANJANC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void PDLJCMIHKOA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void LMELEKHBNKP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(PLCNKLHCBOA));
				activeMission.OGHHAGHNOCG(0);
				activeMission.GNEECFAEAIK();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void EPDLIBBOHBL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(EGJACPEPJAJ));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void EEEGDIJKBPD(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(GBCBPKMPLCI));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void CGGFABDGOEJ(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EGJACPEPJAJ));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void MOJGGJENCLB(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(IEEEKMBEGIL));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AABDCFOJBNH();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	public override void DDGEPPLPJHI()
	{
		base.DDGEPPLPJHI();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private void FMJEGNDDCAH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(HNEBBBBLBKL));
				activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void CHADOMCDNGL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
				activeMission.BNGFAGIGJNE(0);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void GMDJCHOKHCH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(PLCNKLHCBOA));
				activeMission.PFNPELJFJKA(1);
				activeMission.AABDCFOJBNH();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void LGLGPICNELA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(FHMHHDHGDHK));
				activeMission.BNGFAGIGJNE(0);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void KCMGGLDMDDC(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(HCPBIBOEMMA));
				activeMission.OGHHAGHNOCG(1);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void KEDBKAOPOBO(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(EKOIBCMBGOP));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void AMDHNHEFJLP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(GBCBPKMPLCI));
				activeMission.BNGFAGIGJNE(1);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void MIICHMNMEDP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(AKDIOEAEGID));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void ICNCKPJEBJF(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(HNEBBBBLBKL));
				activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void EKOIBCMBGOP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(PLCNKLHCBOA));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void IOGMEINNIMN(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
				activeMission.DOAGOANJANC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void EGJACPEPJAJ(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(LPEBGJFBLOG));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void IENOOOKLHCA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(JDBHIJBLLLH));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void NAHCBOOIKFL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(FMJEADKBLLJ));
				activeMission.PFNPELJFJKA(1);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void IBDGJAFBAAL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(KCMGGLDMDDC));
				activeMission.MJJIHGHCDCC(0);
				activeMission.DOAGOANJANC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void IHNGKMCBFON(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EAPLDJEJKLA));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void EAPLDJEJKLA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(BKHLGCDJCAP));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void MJAAIPNHFKC(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(EEEGDIJKBPD));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void LPEBGJFBLOG(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(LPEBGJFBLOG));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void CPACHNJDCMP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(HNEBBBBLBKL));
				activeMission.OGHHAGHNOCG(1);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void NFLOGGFIODM(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(FMJEADKBLLJ));
				activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void LBKKOFPLHLH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(IOGMEINNIMN));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false);
				activeMission.AABDCFOJBNH();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void AKDIOEAEGID(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(IOGMEINNIMN));
				activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void PLCNKLHCBOA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(MMEAFELGGEH));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void HNEBBBBLBKL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(LPEBGJFBLOG));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
				activeMission.LHKIJABBBPM();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void IEEEKMBEGIL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(IBDGJAFBAAL));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.GNEECFAEAIK();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void KIMKCKCJDPF(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(EEEGDIJKBPD));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void AHEMFKMJBPN(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(EAPLDJEJKLA));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void BKHLGCDJCAP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(GMDJCHOKHCH));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false);
				activeMission.AABDCFOJBNH();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void JDBHIJBLLLH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(PLCNKLHCBOA));
				activeMission.MJJIHGHCDCC(1);
				activeMission.AABDCFOJBNH();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void GBCBPKMPLCI(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
		if (activeMission != null)
		{
			activeMission.currentAmount += 0;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(IOGMEINNIMN));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void HCPBIBOEMMA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(OLBHDKLMILG));
				activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
				activeMission.AABDCFOJBNH();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void JENDHGMPFAF(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(GMDJCHOKHCH));
				activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void CLBLJCBOIHG(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(IHNGKMCBFON));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void FMJEADKBLLJ(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(PLCNKLHCBOA));
				activeMission.KNOIJBMDJDK(1);
				activeMission.DDCIALHPFPC();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}

	private void FHMHHDHGDHK(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (action != OKNOJJEFEBE)
		{
			return;
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
		if (activeMission != null)
		{
			activeMission.currentAmount++;
			if (activeMission.currentAmount >= requiredAmount)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CLBLJCBOIHG));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
			else
			{
				MissionsManager.instance.UpdateObjectives(activeMission);
			}
		}
	}
}
