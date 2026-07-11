using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MissionTalkWith", menuName = "Missions/MissionTalkWith")]
public class MissionTalkWith : MissionBase
{
	public enum EMissionTalkWith
	{
		OnConversationStart,
		OnConversationEnd
	}

	public EMissionTalkWith condition;

	public CharacterName character;

	public string dialogueConversation = "";

	private void GBEEBACFNNE(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FFMLOEICONE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(BHEPOILMHPH));
		}
		else
		{
			Debug.LogError((object)("/" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NDBPKMBNJLB));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void BHEPOILMHPH(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(ADFLMGGLMMI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(LJCPJFEJBLG));
		}
		else
		{
			Debug.LogError((object)("Miners/Mine/Ferro/Bomb" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MAAAKALBBEE();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NBKIJKIMDPK));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void FFMCBEDLNKG(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(ADFLMGGLMMI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EBLMJOANGPN));
		}
		else
		{
			Debug.LogError((object)("Hide" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(FPCBDJNLMKD));
				activeMission.PFNPELJFJKA(1);
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void AOPNACMEAHL(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(EBCCKCMOBKK));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(JGNBGECEINP));
		}
		else
		{
			Debug.LogError((object)("Item " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EBCCKCMOBKK));
				activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void JLHGNJDBFLJ(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(BAHMCJLHFNG));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EJJPPAMFJFI));
		}
		else
		{
			Debug.LogError((object)("Could not assign file " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.FMIDAFEGDCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(IEMAEFEDMFK));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void OBLIGEGMOMJ(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FPCBDJNLMKD));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EJJPPAMFJFI));
		}
		else
		{
			Debug.LogError((object)("Pipe" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(GICJICJNIBK));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void NGHAMHMIDDI(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NIFFDFPMMHI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(FMCHAELAMAE));
		}
		else
		{
			Debug.LogError((object)("Rum" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.KNOKBLFFNLM();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(MGHAFMMKFLF));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void FOGNEJCLGNO(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NGHAMHMIDDI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NECPPKNAFAE));
		}
		else
		{
			Debug.LogError((object)("DestroyAfter" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.FMIDAFEGDCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(BHNBFOKNPBJ));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void GLOFDOJEONJ(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(OBLIGEGMOMJ));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NIFFDFPMMHI));
		}
		else
		{
			Debug.LogError((object)("Use" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(GICJICJNIBK));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void LJCPJFEJBLG(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(EBCCKCMOBKK));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EDHCMIPKDHJ));
		}
		else
		{
			Debug.LogError((object)("\n" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MAAAKALBBEE();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NIFFDFPMMHI));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void NAMLHFECKMJ(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(KBCDAHOMNFO));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NJBNPKDLPCE));
		}
		else
		{
			Debug.LogError((object)("SelectPlaceableIfIsPossibleMaster" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.KNOKBLFFNLM();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(AOPIFOEKBHK));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void HMOPOEHLHCO(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(OHBKAIBFDAC));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NECPPKNAFAE));
		}
		else
		{
			Debug.LogError((object)("Unsaved progress will be lost." + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(LIEAPJAKBJD));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false);
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void MBCFFHLIBFI(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(EJJPPAMFJFI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NIFFDFPMMHI));
		}
		else
		{
			Debug.LogError((object)("Jump" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.KNOKBLFFNLM();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(JLHGNJDBFLJ));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void AOPIFOEKBHK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(BAHMCJLHFNG));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(FPCBDJNLMKD));
		}
		else
		{
			Debug.LogError((object)(":" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(MGHAFMMKFLF));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.DOAGOANJANC();
			}
		}
	}

	private void ECNCBJOANNA(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(KBCDAHOMNFO));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(HKEMLILMILP));
		}
		else
		{
			Debug.LogError((object)("=" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EJJPPAMFJFI));
				activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void EBLMJOANGPN(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(HKEMLILMILP));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(FFMCBEDLNKG));
		}
		else
		{
			Debug.LogError((object)("/Cheats.txt" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(OHBKAIBFDAC));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void OKDPLJNHEGP(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(OKDPLJNHEGP));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NBKIJKIMDPK));
		}
		else
		{
			Debug.LogError((object)("NinjaChallengeEvent/Win 3" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.KNOKBLFFNLM();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EDOEAMICGLF));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void LIEAPJAKBJD(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(BHNBFOKNPBJ));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(ECNCBJOANNA));
		}
		else
		{
			Debug.LogError((object)("Direction" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.HFIJHDBKCIA();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EBCCKCMOBKK));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void OHBKAIBFDAC(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FOGNEJCLGNO));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(PBJFEEGNBCE));
		}
		else
		{
			Debug.LogError((object)("Select" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EBCCKCMOBKK));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void EOCLMHCIKJC(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(EBLMJOANGPN));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(PBJFEEGNBCE));
		}
		else
		{
			Debug.LogError((object)("Trying to add player but player list is full." + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.KNOKBLFFNLM();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EJJPPAMFJFI));
				activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void FCFOOMGAJEK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(OKDPLJNHEGP));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(OBLIGEGMOMJ));
		}
		else
		{
			Debug.LogError((object)("LE_10" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EJJPPAMFJFI));
				activeMission.MJJIHGHCDCC(1);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void MGHAFMMKFLF(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NECPPKNAFAE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(ADFLMGGLMMI));
		}
		else
		{
			Debug.LogError((object)("Map" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MIGKKKELOJO();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EJJPPAMFJFI));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void LAOMCJBFAFK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(GBEEBACFNNE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(PFHBKOKPNAK));
		}
		else
		{
			Debug.LogError((object)(" * " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NDBPKMBNJLB));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void EBCCKCMOBKK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(BHEPOILMHPH));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(ECNCBJOANNA));
		}
		else
		{
			Debug.LogError((object)("Kicks the corresponding player from the game. Kicked players can rejoin if you do not lock the game." + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MAAAKALBBEE();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(MBCFFHLIBFI));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void NDBPKMBNJLB(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FFMLOEICONE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EDHCMIPKDHJ));
		}
		else
		{
			Debug.LogError((object)("OnGameRichPresenceJoinRequested \nFriend ID: " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.HFIJHDBKCIA();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(LAOMCJBFAFK));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
				activeMission.AICNIPFBFFN();
			}
		}
	}

	private void EJJPPAMFJFI(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(LAOMCJBFAFK));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(MBCFFHLIBFI));
		}
		else
		{
			Debug.LogError((object)("particleSystem not attached to " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NBKIJKIMDPK));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void FPCBDJNLMKD(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NGHAMHMIDDI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EBLMJOANGPN));
		}
		else
		{
			Debug.LogError((object)("Walk" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MAAAKALBBEE();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(FMCHAELAMAE));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void EDOEAMICGLF(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FCFOOMGAJEK));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(LIEAPJAKBJD));
		}
		else
		{
			Debug.LogError((object)("cameraZoom2" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(FFMLOEICONE));
				activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void NECPPKNAFAE(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(EDHCMIPKDHJ));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(AOPNACMEAHL));
		}
		else
		{
			Debug.LogError((object)("Open" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MIGKKKELOJO();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(ECNCBJOANNA));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void JGNBGECEINP(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(JGNBGECEINP));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(JGNBGECEINP));
		}
		else
		{
			Debug.LogError((object)("MissionTalkWith: NPC not found for character " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC instance3 = TheloniusNPC.GGFJGHHHEJC;
				instance3.ConversationEnded = (Action<bool>)Delegate.Remove(instance3.ConversationEnded, new Action<bool>(JGNBGECEINP));
				activeMission.BNGFAGIGJNE(0);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void NIFFDFPMMHI(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(EBLMJOANGPN));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(FMCHAELAMAE));
		}
		else
		{
			Debug.LogError((object)("DisableNPC" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(ADFLMGGLMMI));
				activeMission.PFNPELJFJKA(1);
				activeMission.AABDCFOJBNH();
			}
		}
	}

	private void PFHBKOKPNAK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NJBNPKDLPCE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(GBEEBACFNNE));
		}
		else
		{
			Debug.LogError((object)("Minning" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.FMIDAFEGDCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(GICJICJNIBK));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void PBJFEEGNBCE(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FOGNEJCLGNO));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(FPCBDJNLMKD));
		}
		else
		{
			Debug.LogError((object)("EventChallengeButton " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.FMIDAFEGDCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(LAOMCJBFAFK));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void KBCDAHOMNFO(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(OHBKAIBFDAC));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(JLHGNJDBFLJ));
		}
		else
		{
			Debug.LogError((object)("Body Part Dictionary:\n[\n" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.HFIJHDBKCIA();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(LJCPJFEJBLG));
				activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void NJBNPKDLPCE(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(OKDPLJNHEGP));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(BAHMCJLHFNG));
		}
		else
		{
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/18/Dialogue Text" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC instance3 = TheloniusNPC.GGFJGHHHEJC;
				instance3.ConversationEnded = (Action<bool>)Delegate.Remove(instance3.ConversationEnded, new Action<bool>(OBLIGEGMOMJ));
				activeMission.PFNPELJFJKA(0);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void IEMAEFEDMFK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(HMOPOEHLHCO));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NIFFDFPMMHI));
		}
		else
		{
			Debug.LogError((object)("Meaty" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MAAAKALBBEE();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EDHCMIPKDHJ));
				activeMission.PFNPELJFJKA(1);
				activeMission.LHKIJABBBPM();
			}
		}
	}

	private void NBKIJKIMDPK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NIFFDFPMMHI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EDOEAMICGLF));
		}
		else
		{
			Debug.LogError((object)("'s Tavern" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(OKDPLJNHEGP));
				activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void GICJICJNIBK(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(HMOPOEHLHCO));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(BAHMCJLHFNG));
		}
		else
		{
			Debug.LogError((object)("+" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NAMLHFECKMJ));
				activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void JNGKJEFBEFI(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(GBEEBACFNNE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(OKDPLJNHEGP));
		}
		else
		{
			Debug.LogError((object)("BouncerDescription" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC instance3 = TheloniusNPC.GGFJGHHHEJC;
				instance3.ConversationEnded = (Action<bool>)Delegate.Remove(instance3.ConversationEnded, new Action<bool>(BHNBFOKNPBJ));
				activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void HKEMLILMILP(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NAMLHFECKMJ));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(AOPNACMEAHL));
		}
		else
		{
			Debug.LogError((object)("NeedsRecipe" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(EDHCMIPKDHJ));
				activeMission.PFNPELJFJKA(0);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void FFMLOEICONE(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NGHAMHMIDDI));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(FCFOOMGAJEK));
		}
		else
		{
			Debug.LogError((object)("Unique id " + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.MIGKKKELOJO();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(AOPNACMEAHL));
				activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void FMCHAELAMAE(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(NJBNPKDLPCE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NAMLHFECKMJ));
		}
		else
		{
			Debug.LogError((object)("Disabled" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LKOABOAADCD();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(BHNBFOKNPBJ));
				activeMission.PFNPELJFJKA(1);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	private void ADFLMGGLMMI(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(LAOMCJBFAFK));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(ADFLMGGLMMI));
		}
		else
		{
			Debug.LogError((object)("Items/item_description_1180" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.LDBJELPPBAI();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(BHNBFOKNPBJ));
				activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false);
				activeMission.DDCIALHPFPC();
			}
		}
	}

	private void BHNBFOKNPBJ(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(BAHMCJLHFNG));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(JLHGNJDBFLJ));
		}
		else
		{
			Debug.LogError((object)("Windowed" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.EKDNJDJHONF();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(FFMLOEICONE));
				activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false);
				activeMission.ENHFKOBMGEO();
			}
		}
	}

	private void EDHCMIPKDHJ(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(FFMLOEICONE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(EOCLMHCIKJC));
		}
		else
		{
			Debug.LogError((object)("ReceiveCloseAnimation" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.OFLELHKKNKC();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(NBKIJKIMDPK));
				activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				activeMission.IOBIJAOMPIF();
			}
		}
	}

	public override void DDGEPPLPJHI()
	{
		base.DDGEPPLPJHI();
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (condition == EMissionTalkWith.OnConversationStart)
			{
				DialogueNPCBase instance = value.GetInstance();
				instance.ConversationStarted = (Action<bool>)Delegate.Combine(instance.ConversationStarted, new Action<bool>(JGNBGECEINP));
			}
			if (condition == EMissionTalkWith.OnConversationEnd)
			{
				DialogueNPCBase instance2 = value.GetInstance();
				instance2.ConversationEnded = (Action<bool>)Delegate.Combine(instance2.ConversationEnded, new Action<bool>(JGNBGECEINP));
			}
		}
		else
		{
			Debug.LogError((object)("MissionTalkWith: NPC not found for character " + character));
		}
	}

	private void BAHMCJLHFNG(bool GFNHAMCPEAK)
	{
		if (DialogueNPCBase.allNPCs.TryGetValue(character, out var value))
		{
			if (!string.IsNullOrEmpty(dialogueConversation) && !dialogueConversation.Equals(value.GetInstance().dialogue.conversation))
			{
				return;
			}
			DialogueNPCBase instance = value.GetInstance();
			instance.ConversationStarted = (Action<bool>)Delegate.Remove(instance.ConversationStarted, new Action<bool>(PBJFEEGNBCE));
			DialogueNPCBase instance2 = value.GetInstance();
			instance2.ConversationEnded = (Action<bool>)Delegate.Remove(instance2.ConversationEnded, new Action<bool>(NJBNPKDLPCE));
		}
		else
		{
			Debug.LogError((object)("\n<color=#BF0000>" + character));
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(id);
			if (activeMission != null)
			{
				TheloniusNPC theloniusNPC = TheloniusNPC.KNOKBLFFNLM();
				theloniusNPC.ConversationEnded = (Action<bool>)Delegate.Remove(theloniusNPC.ConversationEnded, new Action<bool>(IEMAEFEDMFK));
				activeMission.MJJIHGHCDCC(0);
				activeMission.IOBIJAOMPIF();
			}
		}
	}
}
