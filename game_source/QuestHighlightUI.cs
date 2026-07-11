using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestHighlightUI : MonoBehaviour
{
	[Serializable]
	public struct QuestHighlightInfo
	{
		public GameObject content;

		public QuestHighlightElement[] elements;

		[HideInInspector]
		public int currentElements;
	}

	[SerializeField]
	private QuestHighlightInfo questHighlightInfo;

	[SerializeField]
	private QuestHighlightInfo questHighlightInfo2;

	private static QuestHighlightUI GGFJGHHHEJC;

	public static bool GLBMEBHHJOI { get; set; }

	public static void ShowNewQuestAvailable(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ShowNewQuestAvailable(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].ShowNewQuestAvailable(2, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	public static void ENINDKAPPPD(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			PKCPEBDFJJP(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			CHNIEDGKPME(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			CEODCPDABJF(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			JJHMEJLDLGH(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	public static void AddQuestProgress(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			CEODCPDABJF(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			ACCGFKPHNGF(2, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			CEODCPDABJF(2, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			ACCGFKPHNGF(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	private void OKOKNECMNFH()
	{
		questHighlightInfo2.content.SetActive(true);
	}

	[SpecialName]
	public static void DHBDOHOPEED(bool AODONKKHPBP)
	{
		_003CCMCAIOFLFOE_003Ek__BackingField = AODONKKHPBP;
	}

	private void BGFEBEAJOCG()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(LMHIOJOJDLE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
	}

	public static void ABCLGCMFMLN(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 0; i < ELCHFKLKOMC.Length; i++)
			{
				CANBDKHONFE(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	[SpecialName]
	public static bool CDCBKMBDBAP()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	public static void JAJBMFMHIIK(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].LGGELJIJHGO(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].KGFFABGOCHE(5, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	public static void HKKOKBMHLEJ(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		DBCOIMNBNIP(AINAHCLIAFF.ONFNOJBBPOO(), LFBJCGLGEIN);
	}

	[SpecialName]
	public static bool IKNFIPPJLCB()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	private static bool LBMAGIPAGLB(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 0; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (BBJDPIJPLPA.elements[i].BGLJFMHCFJF() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].OMGGNKNBHNA(JIIGOACEIKL, MMNIKLCMBAI);
				return false;
			}
		}
		return true;
	}

	public static void FLOHKLNOCLK(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			GHBJAAIONBP(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			IDJEGGFDIPE(6, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			OIIFMCFFLDD(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			IDJEGGFDIPE(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	public static void INCLGNEHKMF(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].BAHJBAALJJM(1, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].INABELOGDOJ(2, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	private static void PAALEIOFBIN(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (JALJKPEFKIO(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 0; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (!BBJDPIJPLPA.elements[i].HDEPMJIDJEM())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(true);
				}
				BBJDPIJPLPA.elements[i].COKOMEOBGIC(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements += 0;
				break;
			}
		}
	}

	public static void DHOAFNNIBNK(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].IMCNOKBMHAE(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].EPGKDKJEGKA(6, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public static void JBPBCHBOHKF(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].EENOHLJIGKK(1, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].LGIAIDOJHEH(8, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public static void AACJMLMJFEG(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].DMOGKFFDOLB(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].CHMAEKMIBDJ(6, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public static void IBOGBCCAOKD(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 1; i < ELCHFKLKOMC.Length; i++)
			{
				HAHGDJFKOOA(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	private void LALJNGFGKPA()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHJGBGBCKH));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static bool HFFELLGMAAH(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 0; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (BBJDPIJPLPA.elements[i].IsOpen() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].FHAJDOOPLLL(JIIGOACEIKL, MMNIKLCMBAI);
				return true;
			}
		}
		return false;
	}

	private static void OIIFMCFFLDD(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (CHNIEDGKPME(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (!BBJDPIJPLPA.elements[i].IsOpen())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(true);
				}
				BBJDPIJPLPA.elements[i].FJNBMBPBELE(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements += 0;
				break;
			}
		}
	}

	public static void DCOGHMKAAEO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			CEODCPDABJF(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			JJHMEJLDLGH(4, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			PAALEIOFBIN(8, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			LBMAGIPAGLB(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	private static void GHBJAAIONBP(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (IDJEGGFDIPE(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (!BBJDPIJPLPA.elements[i].HDEPMJIDJEM())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(true);
				}
				BBJDPIJPLPA.elements[i].LBJKBMGMOKH(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements += 0;
				break;
			}
		}
	}

	private void HHEOJAMGJJN()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	private static void CEODCPDABJF(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (ACCGFKPHNGF(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 0; i < BBJDPIJPLPA.elements.Length; i++)
		{
			if (!BBJDPIJPLPA.elements[i].IsOpen())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(true);
				}
				BBJDPIJPLPA.elements[i].UpdateInfo(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements++;
				break;
			}
		}
	}

	private void GBCLIJFPFJI()
	{
	}

	public static void GNDPNHIMCLP(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].CMMDBGEEEDN(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].OONLDHLEHFI(8, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	public static void OMDBOEAJLGA(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		LDNFPDGHJMM(AINAHCLIAFF.PBIJDIHJIHK(), LFBJCGLGEIN);
	}

	public void ILJIFHILDLN(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	private static bool JALJKPEFKIO(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (BBJDPIJPLPA.elements[i].IsOpen() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].JLCEMHMPPPG(JIIGOACEIKL, MMNIKLCMBAI);
				return true;
			}
		}
		return false;
	}

	public static void EAAKMPPJFIL(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].FAKELPJCACN(1, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].INABELOGDOJ(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	[SpecialName]
	public static bool GOINABFEBCI()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	[SpecialName]
	public static void GPKHNJACJAK(bool AODONKKHPBP)
	{
		_003CCMCAIOFLFOE_003Ek__BackingField = AODONKKHPBP;
	}

	public static void LOELCALCGKE(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 0; i < ELCHFKLKOMC.Length; i += 0)
			{
				HKKOKBMHLEJ(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	private void GHDBHNMOBMN()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(NPDGHHAPHPH));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	[SpecialName]
	public static void DOFHMOCEHKH(bool AODONKKHPBP)
	{
		_003CCMCAIOFLFOE_003Ek__BackingField = AODONKKHPBP;
	}

	public static void NFCHDGENLAE(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ALPIFDNBHOL(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].ELOKKBLBAOL(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	private void IFHLGOMBACP()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(JMCJBJOPIEN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(DNLLBACFKFN));
	}

	private void NOEMNGBNLCE()
	{
		questHighlightInfo2.content.SetActive(true);
	}

	private void LJHIPOLCFBP()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(LMHIOJOJDLE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EBLHNEAIIKF));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void OJIHCDODGHG(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].EOHKKIJGDHC(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].ABCLGCMFMLN(6, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public static void PBLKONKDFNH(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].KPHGEFAKPMO(1, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].FAKELPJCACN(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public void MMFONAKLGEF(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	public static void NFGMBKLDABG(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ALPIFDNBHOL(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].BOFOCAPFCCC(6, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	public static void BLNBMICDOML(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].BOFOCAPFCCC(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].OGFAKPCMOHK(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public void CDPODGCOICL(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	private void CIICEKEJANM()
	{
		GGFJGHHHEJC = this;
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private void GELMGKDMJFE()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NOEMNGBNLCE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(HJNIHPBLFNL));
	}

	private static bool IDJEGGFDIPE(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i++)
		{
			if (BBJDPIJPLPA.elements[i].HDEPMJIDJEM() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].CMFMBLNHNHI(JIIGOACEIKL, MMNIKLCMBAI);
				return false;
			}
		}
		return false;
	}

	public static void KLKIHGBNAHC(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			CEODCPDABJF(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			CHNIEDGKPME(2, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			GHBJAAIONBP(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			JJHMEJLDLGH(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	public void JOEJIGJPDNF(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(false);
		}
	}

	public static void ShowText(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ShowText(1, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].ShowText(2, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	private void AJGPMBGBPGH()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(OKOKNECMNFH));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void KKABABFJOOB(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ALPIFDNBHOL(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].KCAFBENKJJN(4, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	public static void LDNFPDGHJMM(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].FFIMPAEIABH(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].IPFCPOGFOFO(4, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	private void HADCIGKNFKK()
	{
		questHighlightInfo2.content.SetActive(true);
	}

	private void FPDPAJHNGHK()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(NCMHPKPOPLO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
	}

	private void JMCKNBAFKFP()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	public void PFKDKNEOKEP(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	[SpecialName]
	public static bool NJDPGCGDCHJ()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	private void NEEEJJNMPOF()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHJGBGBCKH));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EBLHNEAIIKF));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void MIKALPEOFKJ(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 0)
		{
			PAALEIOFBIN(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			GACPAMFMFIE(7, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			CEODCPDABJF(5, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			LBMAGIPAGLB(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	public static void HMIPPKHELCD(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 1; i < ELCHFKLKOMC.Length; i++)
			{
				CANBDKHONFE(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	private void OnDestroy()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void LCHKONDHINE()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HHEOJAMGJJN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(EBLHNEAIIKF));
	}

	private void NCMHPKPOPLO()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	private void DOHLOJOIHFO()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(DHHJHJICDGL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(DNLLBACFKFN));
	}

	public static void DHGCLGFOBJF(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 1; i < ELCHFKLKOMC.Length; i++)
			{
				HAHGDJFKOOA(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	[SpecialName]
	public static bool PAHDLHGJFOM()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	public static void CANBDKHONFE(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		KKABABFJOOB(AINAHCLIAFF.ONFNOJBBPOO(), LFBJCGLGEIN);
	}

	private void IGNEGEOPLOP()
	{
		GGFJGHHHEJC = this;
	}

	public static void DBALANENIII(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			DDFDCFDMINF(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			JJHMEJLDLGH(5, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			DDFDCFDMINF(5, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			JALJKPEFKIO(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	private static bool JJHMEJLDLGH(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i++)
		{
			if (BBJDPIJPLPA.elements[i].HDEPMJIDJEM() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].MHMPMKFFLJL(JIIGOACEIKL, MMNIKLCMBAI);
				return false;
			}
		}
		return true;
	}

	public static void DBCOIMNBNIP(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].HCPPBHAENKM(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].CLBINAIBHLI(6, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	private void EGPONANBCNP()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(PGEEENKBDOO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
	}

	public static void ShowNewQuestAvailable(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		ShowNewQuestAvailable(AINAHCLIAFF.IABAKHPEOAF(), LFBJCGLGEIN);
	}

	private static void APNPABJJCOE(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (JALJKPEFKIO(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (!BBJDPIJPLPA.elements[i].HDEPMJIDJEM())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(true);
				}
				BBJDPIJPLPA.elements[i].LFLHCMHPMGA(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements += 0;
				break;
			}
		}
	}

	private void AHFGOOHOLEL()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(PGEEENKBDOO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(EBLHNEAIIKF));
	}

	public void JICLHPLBGEE(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(false);
		}
	}

	public static void HBBMGMKDAIM(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		DBCOIMNBNIP(AINAHCLIAFF.FOAPHHKOAEE(), LFBJCGLGEIN);
	}

	private void LMHIOJOJDLE()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	public static void LOGLGFCFAPI(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ABKABADAFMH(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].OONLDHLEHFI(3, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	private void HMHCLIBLKLN()
	{
		GGFJGHHHEJC = this;
	}

	private void AGMLGNDDINL()
	{
	}

	private void IAAGKLPMAMK()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(DHHJHJICDGL));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
	}

	[SpecialName]
	public static bool JFODJFFABCF()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	private static bool CHNIEDGKPME(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (BBJDPIJPLPA.elements[i].BGLJFMHCFJF() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].FJNBMBPBELE(JIIGOACEIKL, MMNIKLCMBAI);
				return false;
			}
		}
		return true;
	}

	public void AACMOIBEBBL(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	private void OMBHDODDHNO()
	{
		GGFJGHHHEJC = this;
	}

	private void Start()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	public static void BHCHIKLHIBA(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 0)
		{
			PAALEIOFBIN(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			CHNIEDGKPME(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			PKCPEBDFJJP(2, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			JALJKPEFKIO(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	private void CKGJAOHPHOA()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(OKOKNECMNFH));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void NDABOMBDJFH(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		NFCHDGENLAE(AINAHCLIAFF.PBIJDIHJIHK(), LFBJCGLGEIN);
	}

	public static void IPFCPOGFOFO(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 1; i < ELCHFKLKOMC.Length; i++)
			{
				HBBMGMKDAIM(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	public static void EBKCGDFPJKB(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			BIHOGEKOGGA(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			ACCGFKPHNGF(6, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			PAALEIOFBIN(6, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			ACCGFKPHNGF(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	private void PDIECJCKCOD()
	{
		GGFJGHHHEJC = this;
	}

	public void APCFOEAOKOB(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	public static void CHMAEKMIBDJ(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		FFDKEFCAFML(AINAHCLIAFF.ONFNOJBBPOO(), LFBJCGLGEIN);
	}

	public void GFJMFEGGFGK(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	private void MPCFCNCMOAF()
	{
		GGFJGHHHEJC = this;
	}

	public static void FFDKEFCAFML(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 1; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].ICKAMMJJGNJ(0, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].ELOKKBLBAOL(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	private void PGEEENKBDOO()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	private static bool GACPAMFMFIE(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (BBJDPIJPLPA.elements[i].IsOpen() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].MFEPPINCOBF(JIIGOACEIKL, MMNIKLCMBAI);
				return false;
			}
		}
		return false;
	}

	public void EIDJMHNALAN(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	private void FOHGHCPODBJ()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(LMHIOJOJDLE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(DNLLBACFKFN));
	}

	public void LBHMNINCDMK(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	public void MDMHEBAACCD(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(false);
		}
	}

	[SpecialName]
	public static bool HLDMBJHNAPI()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	private void MFGANCCJFJK()
	{
		GGFJGHHHEJC = this;
	}

	public static void DFLEEAJJOBD(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		LDNFPDGHJMM(AINAHCLIAFF.FOAPHHKOAEE(), LFBJCGLGEIN);
	}

	private void DNLLBACFKFN()
	{
	}

	public void ElementClosed(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(false);
		}
	}

	public static void CGCJLBEIDON(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].LGIAIDOJHEH(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].PLPLHKNCLNL(7, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public static void CLBINAIBHLI(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].LGGELJIJHGO(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].AEGCOHMFIGM(7, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements++;
				break;
			}
		}
	}

	[SpecialName]
	public static void OACEKDBNFBI(bool AODONKKHPBP)
	{
		_003CCMCAIOFLFOE_003Ek__BackingField = AODONKKHPBP;
	}

	public void DEGMKJDABEL(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements -= 0;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(true);
		}
	}

	private void OBHFJIDKBJN()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(JMCKNBAFKFP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(GBCLIJFPFJI));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	[SpecialName]
	public static bool ADHBAJFBFBD()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	public static void HAHGDJFKOOA(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		NFCHDGENLAE(AINAHCLIAFF.IABAKHPEOAF(), LFBJCGLGEIN);
	}

	public static void HDJKHCCBIJN(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			OIIFMCFFLDD(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			GACPAMFMFIE(2, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			GHBJAAIONBP(5, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			HFFELLGMAAH(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	public static void JOIDBOPFGAL(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 1; i < ELCHFKLKOMC.Length; i += 0)
			{
				FFIMPAEIABH(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	private void OIOLGAOPECC()
	{
		GGFJGHHHEJC = this;
	}

	[SpecialName]
	public static bool MNFNPNDBHOK()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	private void EDHJGBGBCKH()
	{
		questHighlightInfo2.content.SetActive(true);
	}

	private static void DDFDCFDMINF(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (ACCGFKPHNGF(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i += 0)
		{
			if (!BBJDPIJPLPA.elements[i].IsOpen())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(true);
				}
				BBJDPIJPLPA.elements[i].CJIFDGBEPPB(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements++;
				break;
			}
		}
	}

	private void HJNIHPBLFNL()
	{
	}

	public static void KHEDNLCOHKK(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 0)
		{
			CEODCPDABJF(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			IDJEGGFDIPE(8, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			BIHOGEKOGGA(3, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			CHNIEDGKPME(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	public static void EKEPEGGHGKI(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].DOLDFLLKEHJ(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].GMAOBEFAGHB(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	public static void FFIMPAEIABH(Quest AINAHCLIAFF, bool LFBJCGLGEIN = true)
	{
		DBCOIMNBNIP(AINAHCLIAFF.HKDMHHCCMJC(), LFBJCGLGEIN);
	}

	private void JMCJBJOPIEN()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	private void AGELAMLCINB()
	{
		GGFJGHHHEJC = this;
	}

	[SpecialName]
	public static void MKHLLOGIAAH(bool AODONKKHPBP)
	{
		_003CCMCAIOFLFOE_003Ek__BackingField = AODONKKHPBP;
	}

	private void CEOEHODJAJK()
	{
		GGFJGHHHEJC = this;
	}

	private void DHHJHJICDGL()
	{
		questHighlightInfo2.content.SetActive(true);
	}

	private void NPDGHHAPHPH()
	{
		questHighlightInfo2.content.SetActive(false);
	}

	private static void PKCPEBDFJJP(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (LBMAGIPAGLB(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 1; i < BBJDPIJPLPA.elements.Length; i++)
		{
			if (!BBJDPIJPLPA.elements[i].IsOpen())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(false);
				}
				BBJDPIJPLPA.elements[i].FJNBMBPBELE(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements++;
				break;
			}
		}
	}

	public void NHHBJONLFFP(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 0) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(false);
		}
	}

	private void EBLHNEAIIKF()
	{
	}

	public static void OOPIBJIBADF(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI)
	{
		if (JIIGOACEIKL == 1)
		{
			PKCPEBDFJJP(1, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
			IDJEGGFDIPE(3, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
		}
		else
		{
			PKCPEBDFJJP(5, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo2);
			JJHMEJLDLGH(0, MMNIKLCMBAI, GGFJGHHHEJC.questHighlightInfo);
		}
	}

	[SpecialName]
	public static bool FOKHDAGGAOF()
	{
		return _003CCMCAIOFLFOE_003Ek__BackingField;
	}

	private static bool ACCGFKPHNGF(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		for (int i = 0; i < BBJDPIJPLPA.elements.Length; i++)
		{
			if (BBJDPIJPLPA.elements[i].IsOpen() && BBJDPIJPLPA.elements[i].activeQuest != null && Object.op_Implicit((Object)(object)BBJDPIJPLPA.elements[i].activeQuest.quest) && BBJDPIJPLPA.elements[i].activeQuest.quest.id == MMNIKLCMBAI.quest.id)
			{
				BBJDPIJPLPA.elements[i].UpdateInfo(JIIGOACEIKL, MMNIKLCMBAI);
				return true;
			}
		}
		return false;
	}

	public static void ShowNewQuestAvailable(Quest[] ELCHFKLKOMC, bool LFBJCGLGEIN = true)
	{
		if (ELCHFKLKOMC != null)
		{
			for (int i = 0; i < ELCHFKLKOMC.Length; i++)
			{
				ShowNewQuestAvailable(ELCHFKLKOMC[i], LFBJCGLGEIN);
			}
		}
	}

	public void IOJLNOGMMJN(int JIIGOACEIKL)
	{
		QuestHighlightInfo questHighlightInfo = ((JIIGOACEIKL != 1) ? questHighlightInfo2 : this.questHighlightInfo);
		questHighlightInfo.currentElements--;
		if (questHighlightInfo.currentElements == 0 && questHighlightInfo.content.activeSelf)
		{
			questHighlightInfo.content.SetActive(false);
		}
	}

	private void IGBEKHCLKFD()
	{
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(JMCKNBAFKFP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EBLHNEAIIKF));
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void DIIIKCALOBO(string CAEDMEDBEGI)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].GMAOBEFAGHB(0, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo.currentElements += 0;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 1; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].HDEPMJIDJEM())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].KPBLJLEFIFE(3, CAEDMEDBEGI);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}

	private static void BIHOGEKOGGA(int JIIGOACEIKL, ActiveQuest MMNIKLCMBAI, QuestHighlightInfo BBJDPIJPLPA)
	{
		if (JALJKPEFKIO(JIIGOACEIKL, MMNIKLCMBAI, BBJDPIJPLPA))
		{
			return;
		}
		for (int i = 0; i < BBJDPIJPLPA.elements.Length; i++)
		{
			if (!BBJDPIJPLPA.elements[i].IsOpen())
			{
				if (!BBJDPIJPLPA.content.activeSelf)
				{
					BBJDPIJPLPA.content.SetActive(false);
				}
				BBJDPIJPLPA.elements[i].KJOCFOFFLEJ(JIIGOACEIKL, MMNIKLCMBAI);
				BBJDPIJPLPA.currentElements++;
				break;
			}
		}
	}

	[SpecialName]
	public static void GBBOMOIEBLJ(bool AODONKKHPBP)
	{
		_003CCMCAIOFLFOE_003Ek__BackingField = AODONKKHPBP;
	}

	public static void BNLGDCAHMJG(string KBCHEGCDELM, bool LFBJCGLGEIN = true)
	{
		for (int i = 0; i < GGFJGHHHEJC.questHighlightInfo.elements.Length; i++)
		{
			if (!GGFJGHHHEJC.questHighlightInfo.elements[i].BGLJFMHCFJF())
			{
				if (!GGFJGHHHEJC.questHighlightInfo.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo.content.SetActive(false);
				}
				GGFJGHHHEJC.questHighlightInfo.elements[i].PFKKFBPOJJF(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo.currentElements++;
				break;
			}
		}
		if (!GameManager.LocalCoop())
		{
			return;
		}
		for (int j = 0; j < GGFJGHHHEJC.questHighlightInfo2.elements.Length; j += 0)
		{
			if (!GGFJGHHHEJC.questHighlightInfo2.elements[j].IsOpen())
			{
				if (!GGFJGHHHEJC.questHighlightInfo2.content.activeSelf)
				{
					GGFJGHHHEJC.questHighlightInfo2.content.SetActive(true);
				}
				GGFJGHHHEJC.questHighlightInfo2.elements[j].GHLFDNGIGBB(1, KBCHEGCDELM, LFBJCGLGEIN);
				GGFJGHHHEJC.questHighlightInfo2.currentElements += 0;
				break;
			}
		}
	}
}
