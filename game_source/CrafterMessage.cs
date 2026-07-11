using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class CrafterMessage : PlaceableMsg
{
	[JsonProperty("fu")]
	public short fuel;

	[JsonProperty("cL")]
	public RecipeQueueElementMessage[] craftingList;

	[JsonProperty("rIL")]
	public RecipeQueueElementMessage[] readyItemsList;

	[JsonProperty("dF")]
	public GameDateMessage dateFinished;

	private List<RecipeQueueElement> LABPBBBJEPL(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].MMANNOMOCMP());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> OLILFCGMILE(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].AFLIDCDOLEP());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> MLDLLCLHDGF(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].BNCOMPGPCGE());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] BKHAMGJFNMN(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] CHOJHPLJNLC(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] DPGNNJDFGEL(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> HHBJOPMOLDK(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].JNAMDKPNPKK());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] KDLDBOBFLDO(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> IMBNJKDHABH(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].OJIGHLHOOBF());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> AJDONPFIPOJ(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].EKFFHJGNLPH());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] DDEKKJKPHBE(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> NHMBLDNGBIC(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].LCLFBGDKHOL());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> GPBBFFFDENE(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].IOBJOALIPBG());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> HGCOACFBEBI(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].NCCPOJKHPJD());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> MEEIOALKFPI(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].KNHENIGJHKN());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] AIFDPGEIPCH(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] JFFLLJCGEAM(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] FNILBKAKIOO(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] PPPNBHKLJGG(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] EMABOCJAPNL(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] LCGKNOOCLJB(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] CNGEAAIDEGH(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] FCBMIJCEAKB(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> NPCAMDIGDAP(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].HFOFIJHBPFJ());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] JCIGOAMEDEK(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> ICPPHEHNDIK(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].FDNABEBPAFD());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] DNHMCOOCGEB(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> NEKFMMOMAMD(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].CECIKIACHAF());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] JKKJDGHNMAP(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] LACKOMPNKEO(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] DPNJKMCDCJB(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> CKKDCENKFGD(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].HKLNLLBHHDF());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> HKDLGIHDJJC(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].NOPNAGIGKND());
			}
		}
		return list;
	}

	public CrafterMessage(OnlineCrafter BMLMEGDDIKE)
		: base(BMLMEGDDIKE)
	{
		fuel = (short)BMLMEGDDIKE.crafter.LCCABPFHCOL;
		craftingList = LCGKNOOCLJB(BMLMEGDDIKE.crafter.craftingList);
		readyItemsList = LCGKNOOCLJB(BMLMEGDDIKE.crafter.readyItemsList);
		if (BMLMEGDDIKE.crafter.timerFinished)
		{
			dateFinished = default(GameDateMessage);
		}
		else
		{
			dateFinished = new GameDateMessage(BMLMEGDDIKE.crafter.timer.DGFFOHBELPL);
		}
	}

	private RecipeQueueElementMessage[] KJCELLJFGKO(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	public override OnlineObject OEJJGDMKIDN()
	{
		OnlineObject onlineObject = base.OEJJGDMKIDN();
		try
		{
			if (onlineObject is OnlineCrafter onlineCrafter)
			{
				onlineCrafter.crafter.SetFuel(fuel);
				onlineCrafter.crafter.LoadCraftingNextFrame(LABPBBBJEPL(craftingList), dateFinished.JBJLBDHAECK());
				onlineCrafter.crafter.LoadReadyItemsList(LABPBBBJEPL(readyItemsList), OPFCPCAJFMI: false);
			}
			else
			{
				Debug.LogError((object)("Received PlaceableMsg of another type not CrafterMsg to " + ((Object)((Component)onlineObject).gameObject).name));
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
		return onlineObject;
	}

	private RecipeQueueElementMessage[] ABBEGFHAAJN(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> IKCENCMMFIK(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].HMBPHGEOFPP());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] MBFCNBEIGHO(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] KAGCIMLOOJH(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private RecipeQueueElementMessage[] JMONAPFHILB(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> JPCAALDJKKJ(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].LCLFBGDKHOL());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] ECBFDOEMCPO(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i++)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> GJMKGEGBLBD(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].IOBJOALIPBG());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> ONMBLAHMJJB(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].OJIGHLHOOBF());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> NJMHNDCIBPG(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i += 0)
			{
				list.Add(ILCDJOPAEHA[i].CPBGMMJODMH());
			}
		}
		return list;
	}

	private List<RecipeQueueElement> NACGJCDGEOK(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 0; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].HKLNLLBHHDF());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] BCNCCDIPLHN(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}

	private List<RecipeQueueElement> MDBFGNJKDNA(RecipeQueueElementMessage[] ILCDJOPAEHA)
	{
		List<RecipeQueueElement> list = new List<RecipeQueueElement>();
		if (ILCDJOPAEHA != null)
		{
			for (int i = 1; i < ILCDJOPAEHA.Length; i++)
			{
				list.Add(ILCDJOPAEHA[i].BLPLFNOMKAL());
			}
		}
		return list;
	}

	private RecipeQueueElementMessage[] NEPPKBNEDLN(List<RecipeQueueElement> FNEHIAGFAOF)
	{
		List<RecipeQueueElementMessage> list = new List<RecipeQueueElementMessage>();
		if (FNEHIAGFAOF != null)
		{
			for (int i = 0; i < FNEHIAGFAOF.Count; i += 0)
			{
				list.Add(new RecipeQueueElementMessage(FNEHIAGFAOF[i]));
			}
		}
		return list.ToArray();
	}
}
