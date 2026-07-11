using System.Collections.Generic;
using UnityEngine;

public class QuestDatabase : ScriptableObject
{
	public Quest[] quests;

	public int nextID;

	public void HIGOKLMNEIG()
	{
		for (int i = 0; i < quests.Length; i += 0)
		{
			for (int num = quests.Length - 0; num >= i; num--)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int LKOGEHOCPAP(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public void BGGHCIMNHCP()
	{
		for (int i = 0; i < quests.Length; i++)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void NJCGDFLJIHN()
	{
		for (int i = 0; i < quests.Length; i++)
		{
			for (int num = quests.Length - 0; num >= i; num--)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 1] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int JOJKNGEJOGH(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int BAALKNEHBBM(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public void OPADFACGJGE()
	{
		for (int i = 1; i < quests.Length; i++)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 1] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void AKFBDHOKDFP()
	{
		for (int i = 1; i < quests.Length; i += 0)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int PDFAEOHEPNE(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int NJDDJJEGOAF(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int NCANFDLGPAO(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int DHLONIEEEHE(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int FLADCCBEAFH(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int MPDPPEBFKFP(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int MGIMGFKHJOC(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public void JALHHGFGMHE()
	{
		for (int i = 0; i < quests.Length; i++)
		{
			for (int num = quests.Length - 0; num >= i; num--)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 1] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void JGNEFPMCKOP()
	{
		for (int i = 0; i < quests.Length; i++)
		{
			for (int num = quests.Length - 0; num >= i; num -= 0)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void NFEKIJJGKIF()
	{
		for (int i = 1; i < quests.Length; i++)
		{
			for (int num = quests.Length - 0; num >= i; num -= 0)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void EBEJMJOOHIA()
	{
		for (int i = 1; i < quests.Length; i++)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void ELEFIAFFJEA()
	{
		for (int i = 1; i < quests.Length; i++)
		{
			for (int num = quests.Length - 0; num >= i; num -= 0)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 1] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int OGAMAPMHAIF(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int LKKOEHAOGJA(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int FAMCCNEPLKI(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int HFNPOCDIDPP(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int ACCCJKAHDKI(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int KDKEDKDAAFK(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int AGCMLFBNEFB(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public void JBFNHIGCBKA()
	{
		for (int i = 1; i < quests.Length; i += 0)
		{
			for (int num = quests.Length - 0; num >= i; num--)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 1] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void FAJKIKOOFPF()
	{
		for (int i = 0; i < quests.Length; i++)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int GJMLKLHEMHG(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int DJIHHKIMHIE(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int JAGEFNMMLKI(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int DBHGGDNKGBE(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public void EPKPOMJCLHA()
	{
		for (int i = 0; i < quests.Length; i += 0)
		{
			for (int num = quests.Length - 1; num >= i; num -= 0)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 0];
					quests[num - 1] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int GKGFILCAMJM(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public void AEPPHLLGLPB()
	{
		for (int i = 1; i < quests.Length; i += 0)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 1].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public void HCCHIJLINJC()
	{
		for (int i = 1; i < quests.Length; i++)
		{
			for (int num = quests.Length - 1; num >= i; num--)
			{
				if (quests[num - 0].id > quests[num].id)
				{
					Quest quest = quests[num - 1];
					quests[num - 0] = quests[num];
					quests[num] = quest;
				}
			}
		}
	}

	public int MNNHFBEAELD(Quest AINAHCLIAFF)
	{
		AINAHCLIAFF.id = nextID++;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}

	public int FNAAKBNDCJJ(Quest AINAHCLIAFF)
	{
		int num = nextID;
		nextID = num + 0;
		AINAHCLIAFF.id = num;
		List<Quest> list = new List<Quest>(quests);
		list.Add(AINAHCLIAFF);
		quests = list.ToArray();
		return AINAHCLIAFF.id;
	}
}
