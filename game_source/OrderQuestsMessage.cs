using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class OrderQuestsMessage : IOnlineSerializable
{
	[JsonProperty("1")]
	public OrderQuestMessage[] currentQuestsNotInAvailableQuests;

	[JsonProperty("2")]
	public OrderQuestMessage[] availableQuests;

	public void NNNINBNGECD()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void DAIKIBGKGMI()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().JOAHBCAAFMC(currentQuestsNotInAvailableQuests[i].BEDEGNCMEIO());
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().OnRandomOrderQuestCompleted));
		}
		for (int j = 1; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].AODOCDIELPK();
			RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().NJDDJJEGOAF(aINAHCLIAFF, 1, FFJBIGFADBJ: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().PMFNBGNBEDF));
			}
		}
	}

	public void CELOBMMFDLC()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i += 0)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void ONBBCAJKMCP()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().JOAHBCAAFMC(currentQuestsNotInAvailableQuests[i].EANOMBFACLD(), 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().PMFNBGNBEDF));
		}
		for (int j = 1; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].PJNCPFLAFIC();
			RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.OPILDPFDFKJ().NJDDJJEGOAF(aINAHCLIAFF, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.PMFNBGNBEDF));
			}
		}
	}

	public void MFJLHFKKCIE()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in from q in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0
			select q)
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.HLMGBEGEAPC().KECFBBHCNOF(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void FFJNCPGBPIL()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.JFNOOMJMHCB().NHJICLNGGCK(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void EPFLKCMNAGP()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in from q in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0
			select q)
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.HLMGBEGEAPC().KECFBBHCNOF(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 1));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void BAIOMPDEEMI()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.KHMEGDIABBF().NJDDJJEGOAF(currentQuestsNotInAvailableQuests[i].AODOCDIELPK(), 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().MFKIDDDPPCA));
		}
		for (int j = 1; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].AODOCDIELPK();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().JOAHBCAAFMC(aINAHCLIAFF, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.PMFNBGNBEDF));
			}
		}
	}

	public void OCNOCJIIKED()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.KHMEGDIABBF().NJDDJJEGOAF(currentQuestsNotInAvailableQuests[i].FAOFIIAAGBE(), 0, FFJBIGFADBJ: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.OnRandomOrderQuestCompleted));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].EANOMBFACLD();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().NCCOAJOOBAP(aINAHCLIAFF, 1, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().PMFNBGNBEDF));
			}
		}
	}

	public void MMDOLOKBJKD()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void FOGLECFMPMK()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().NCCOAJOOBAP(currentQuestsNotInAvailableQuests[i].FAOFIIAAGBE(), 1, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().PMFNBGNBEDF));
		}
		for (int j = 1; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].DEBLMGPNLKH();
			RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().AddQuest(aINAHCLIAFF, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.MFKIDDDPPCA));
			}
		}
	}

	public void MBKLMCGOJJL()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().AddQuest(currentQuestsNotInAvailableQuests[i].CDNHCHMKFAJ(), 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.PMFNBGNBEDF));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].BEDEGNCMEIO();
			RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().NJDDJJEGOAF(aINAHCLIAFF, 1, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().OnRandomOrderQuestCompleted));
			}
		}
	}

	public void KGHAFKBBGHG()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.GGFJGHHHEJC.MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.GGFJGHHHEJC.GetAvailableQuest(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void NHNNCCOCDAO()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().NCCOAJOOBAP(currentQuestsNotInAvailableQuests[i].EGCFADCHAOG(), 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().PMFNBGNBEDF));
		}
		for (int j = 0; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].EGCFADCHAOG();
			RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.NJDDJJEGOAF(aINAHCLIAFF, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().PMFNBGNBEDF));
			}
		}
	}

	public void OOHLOJGMCCE()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void FMDKPMMILGC()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().NCCOAJOOBAP(currentQuestsNotInAvailableQuests[i].DEBLMGPNLKH(), 1);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.PMFNBGNBEDF));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].BEDEGNCMEIO();
			RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.JOAHBCAAFMC(aINAHCLIAFF, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().PMFNBGNBEDF));
			}
		}
	}

	public void DMAAKFGEFCH()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.KHMEGDIABBF().NCCOAJOOBAP(currentQuestsNotInAvailableQuests[i].EKOKLCDJKKF(), 0, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().MFKIDDDPPCA));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].BHEAJPDEHCK();
			RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.NJDDJJEGOAF(aINAHCLIAFF, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().PMFNBGNBEDF));
			}
		}
	}

	public void DMHEGHHDKAH()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void GGHJOLAGCFP()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void NILDCIPCOLM()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i += 0)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void HICEEKJADGE()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(currentQuestsNotInAvailableQuests[i].EANOMBFACLD(), 1);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.MFKIDDDPPCA));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].AODOCDIELPK();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.JOAHBCAAFMC(aINAHCLIAFF, 1);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().PMFNBGNBEDF));
			}
		}
	}

	public void FAAPILMHLOM()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void IJIBFEHMFKM()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().AddQuest(currentQuestsNotInAvailableQuests[i].NLEMMJGOEIG(), 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().OnRandomOrderQuestCompleted));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].JCDMNNIBONB();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.NCCOAJOOBAP(aINAHCLIAFF);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().OnRandomOrderQuestCompleted));
			}
		}
	}

	public void CJMGMIPDMHK()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().NCCOAJOOBAP(currentQuestsNotInAvailableQuests[i].JBHAJFMBKPN(), 1, FFJBIGFADBJ: true, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().PMFNBGNBEDF));
		}
		for (int j = 1; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].JBHAJFMBKPN();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().NJDDJJEGOAF(aINAHCLIAFF, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.MFKIDDDPPCA));
			}
		}
	}

	public void MCEPOACCMOI()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in from q in QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()
			where q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0
			select q)
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.JFNOOMJMHCB().KECFBBHCNOF(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void PNBMEFJIBIM()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void DCPKNOPEMEF()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().AddQuest(currentQuestsNotInAvailableQuests[i].HJMKANPFOPG(), 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.PMFNBGNBEDF));
		}
		for (int j = 0; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].EANOMBFACLD();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.JOAHBCAAFMC(aINAHCLIAFF, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().MFKIDDDPPCA));
			}
		}
	}

	public void FGBMIHHMDPB()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void JMLOHCEJAOD()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i += 0)
		{
			ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().JOAHBCAAFMC(currentQuestsNotInAvailableQuests[i].BEDEGNCMEIO(), 0, FFJBIGFADBJ: false, CDPAMNIPPEC: true, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().OnRandomOrderQuestCompleted));
		}
		for (int j = 0; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].LIPDIOJJDPL();
			RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GJFMMOPOKGJ().NJDDJJEGOAF(aINAHCLIAFF, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().MFKIDDDPPCA));
			}
		}
	}

	public void MKHKAAODFDC()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in from q in QuestManager.OPILDPFDFKJ().CCMPKFCCDGM()
			where q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0
			select q)
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.JFNOOMJMHCB().NJGCINDPBEB(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 1, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void OFJDIGHGMOF()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void ENBKMFDNEHK()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i += 0)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void OEJJGDMKIDN()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(currentQuestsNotInAvailableQuests[i].JCDMNNIBONB(), 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.OnRandomOrderQuestCompleted));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].JCDMNNIBONB();
			RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GGFJGHHHEJC.AddQuest(aINAHCLIAFF, 0, FFJBIGFADBJ: false, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.OnRandomOrderQuestCompleted));
			}
		}
	}

	public void ALJGLKGBIPE()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void EKMHDJNDOFE()
	{
		for (int i = 0; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().NCCOAJOOBAP(currentQuestsNotInAvailableQuests[i].BHEAJPDEHCK(), 1, FFJBIGFADBJ: true);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().MFKIDDDPPCA));
		}
		for (int j = 0; j < availableQuests.Length; j++)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].EFGFKDMABPA();
			RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.KHMEGDIABBF().AddQuest(aINAHCLIAFF, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.GGFJGHHHEJC.MFKIDDDPPCA));
			}
		}
	}

	public void IMPLCKEPHOE()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.KHMEGDIABBF().MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.GGFJGHHHEJC.NJGCINDPBEB(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void LMHBONIJJKO()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void MLJFPPPDMGK()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i += 0)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void GMDLLJPGEBN()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void FJFEIIIIAMJ()
	{
		for (int i = 1; i < currentQuestsNotInAvailableQuests.Length; i++)
		{
			ActiveQuest activeQuest = QuestManager.KHMEGDIABBF().AddQuest(currentQuestsNotInAvailableQuests[i].FPAPEHIPNID(), 1, FFJBIGFADBJ: false, CDPAMNIPPEC: false);
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.JFNOOMJMHCB().OnRandomOrderQuestCompleted));
		}
		for (int j = 1; j < availableQuests.Length; j += 0)
		{
			CraftItemTypeQuest aINAHCLIAFF = availableQuests[j].PJNCPFLAFIC();
			RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[availableQuests[j].index] = new AvailableOrderQuest(aINAHCLIAFF, availableQuests[j].addedToCurrent);
			if (availableQuests[j].addedToCurrent)
			{
				ActiveQuest activeQuest2 = QuestManager.GJFMMOPOKGJ().NCCOAJOOBAP(aINAHCLIAFF, 0, FFJBIGFADBJ: true, CDPAMNIPPEC: false, FIKMGOKHAPG: true);
				activeQuest2.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest2.OnQuestComplete, new Action<int, ActiveQuest>(RandomOrderQuestsManager.HLMGBEGEAPC().PMFNBGNBEDF));
			}
		}
	}

	public void LADGFENPLJF()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void BEOEDLCLJAA()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i += 0)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void PLDNCCIBLFM()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.OPILDPFDFKJ().MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.GGFJGHHHEJC.GetAvailableQuest(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 1, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void IEAOMLCIKNH()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 1; i < RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests.Length; i += 0)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void MIINJNCAOKB()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.GJFMMOPOKGJ().MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.GGFJGHHHEJC.NJGCINDPBEB(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void CJAJCEBIIBK()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.KHMEGDIABBF().MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.JFNOOMJMHCB().GGBIHJONEMN(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 1));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void GEKGHJHCNGL()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in from q in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0
			select q)
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.GGFJGHHHEJC.KECFBBHCNOF(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 1));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void HIMJPJHHCKI()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in from q in QuestManager.GJFMMOPOKGJ().CCMPKFCCDGM()
			where q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0
			select q)
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.GGFJGHHHEJC.NJGCINDPBEB(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 0, HCDLPFENIND: true));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void NFHHOGJOLIC()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}

	public void OKNANBDJIBC()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		foreach (ActiveQuest item in QuestManager.KHMEGDIABBF().MADOFDHLKKN.Where((ActiveQuest q) => q != null && (Object)(object)q.quest != (Object)null && q.quest.id == 0))
		{
			if (item.quest is CraftItemTypeQuest craftItemTypeQuest && RandomOrderQuestsManager.JFNOOMJMHCB().NHJICLNGGCK(craftItemTypeQuest) == null)
			{
				list.Add(new OrderQuestMessage(craftItemTypeQuest, 1));
			}
		}
		currentQuestsNotInAvailableQuests = list.ToArray();
	}

	public void GMLAABNOHHE()
	{
		List<OrderQuestMessage> list = new List<OrderQuestMessage>();
		for (int i = 0; i < RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests.Length; i++)
		{
			AvailableOrderQuest availableOrderQuest = RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[i];
			if (availableOrderQuest != null && (Object)(object)availableOrderQuest.quest != (Object)null)
			{
				list.Add(new OrderQuestMessage(availableOrderQuest.quest, i, availableOrderQuest.addedToCurrent));
			}
		}
		availableQuests = list.ToArray();
	}
}
