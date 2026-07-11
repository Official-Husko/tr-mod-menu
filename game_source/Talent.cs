using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Talent")]
public class Talent : ScriptableObject
{
	public int id;

	public bool translationByID;

	public string nameId;

	[Space(20f)]
	public Recipe[] recipes;

	public ReputationInfo requiredRep;

	public Sprite sprite;

	public bool showText;

	public void JCKKLEFCMBG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void OCKDHEBJNNP(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string OOCFLCEHNEH(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("ReceiveFoodRequestAsDrink" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string AMICIBODAEJ(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Dialogue System/Conversation/Gass_Barks_Bye/Entry/6/Dialogue Text" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void DEPGHCFGAFL(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void EJABGMGNLHJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string LIJLCLGPPHB(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Object " + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string EDMGEIALACB(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Segments" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string FADDAEENDFC(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("LE_8" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string NAGKECHJJGH(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("ReceiveSymbolStatueChanged" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void LCLPPKJPAGB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string LJIFOHFEFCH(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Tool" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void HFFPDJMLBHB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void IEOOJOMPCDH(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void CBDGFCHOPFJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void FCKECDLKGKA(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void KCFEDGKHOIN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string LOMLPPEKPJB(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("GuestConnecting" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void MKPNJJNOLJG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void LPJMJMJCEFO(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void PBGOLGPDMBD(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string MDOPGLDJJEA(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Load Game Client" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void CKBLMOLBABN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void GAAELJPFJMM(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void BGJIJCMMGML(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string KHGEECPHPMO(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("MapBeach" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void NLBPENEIHCM(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string MFKFBOFGDPP(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Ratio pantalla: " + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void JIGEMOFCIIE(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void FGJLHKFLEEJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void DHLGDLMIAMB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string FHINOLOLGGA(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("ReceiveDeclineRoom" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string PEFMPFLDHHL(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("</color>" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void GHFLHNMPPCG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string IABAKHPEOAF(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("talent_name_" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void JHIADAFPBHO(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void CANNDMEGPOB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string ACCALOKJLJJ(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get(" (" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void GFGAENOILBB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string EAFGBEBLFOH(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Serve" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string HNEAOAKBHDH(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Sprout" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void IBNBPPCJNDF(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void KKNIBOMMGAD(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void BBDNGBELPCH(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void INPIFGOAEON(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void OGHMLOGACGF(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void DLBNDDIEEGN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void EFMMFIPFCEO(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string NPNFGKFLDMC(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("[GenerateAltar] Candidate {0} pos:{1} score:{2:F1} (entrance:{3:F1} big:{4:F1} exit:{5:F1})" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void PLPPDMNINAB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void MGKGIFCIKAN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void JEBPGFGLLKI(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void IAAKBGNJILC(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void HICGGEAJFOJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void OHDGJOLKMPA(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void MNAMKHAPGAE(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string ELMMMIPPMCM(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Lose" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void CJDLGPJCCHK(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void NIHOFDGCINN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void HJIOFAIJMCB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void KIPAHALEDIB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void HELKJNINMBE(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void FGFNJNHDLGJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string KFNBHNHHIOM(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("KlaynNPC: ChangeState called with invalid state: " + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string HDNENGMBDCM(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("KlaynTakingDrink: Current request is not a drink request." + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void GFMLHPILNKC(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void BHJDJPIKABA(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void FALKAJMHIJF(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string OCKFMDJHCHF(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("BarkActor" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string EKIKDGDOJFO(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string LIDBEACHCGC(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Null ControllerInfo in database" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string JCHKJFAENJO(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Use" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void HBIGMFHIOFP(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void GGHJOPIJPJB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void FBBBNGMLHOL(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void HEGDOHJKKIJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string ONFNOJBBPOO(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.HEKFJEKFMNO()))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("<size=" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void DAODCJKECPM(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void EEBEBJHIEMN(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void IBCIEAJFMCF(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void HJAOECAOEDP(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void DPLAFKEAJND(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public string GHNFPBCPBLP(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("ActionBar10" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void FPHKBPEBLPO(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string EJNABPEHMMK(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Invalid year: " + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void NPHGCJNBLID(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void CPGOMLCJLLL(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void EFNFCKKOKLB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string HNOEAGBPGKD(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Dots" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void MBAAAOCFCAE(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void PPMAJFEPCDI(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void HPAKGIJGCNJ(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public string LOFIAPEDHNA(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("Comfort" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public string PANKGIMLMBL(bool PKFAMPACOGO = true)
	{
		if (PKFAMPACOGO && Object.op_Implicit((Object)(object)LocalisationSystem.GGFJGHHHEJC))
		{
			string text = ((!translationByID) ? LocalisationSystem.Get(nameId) : LocalisationSystem.Get("[OnlineMineManager] ReceiveGenerateMineLevel: Client doesnt have scene loaded. Level={0} Seed={1}" + id));
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return ((Object)this).name;
		}
		return ((Object)this).name;
	}

	public void BNNGKIHKFMM(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		if (!list.Contains(JNLKEMLDFIM))
		{
			list.Add(JNLKEMLDFIM);
			recipes = list.ToArray();
		}
	}

	public void JFLPOAMKFIL(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void LOIDMHCIDAG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void KKMIPLBMJEG(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}

	public void IPJMEIIODJB(Recipe JNLKEMLDFIM)
	{
		List<Recipe> list = ((recipes == null || recipes.Length == 0) ? new List<Recipe>() : new List<Recipe>(recipes));
		list.Remove(JNLKEMLDFIM);
		recipes = list.ToArray();
	}
}
