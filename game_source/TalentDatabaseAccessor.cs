using System;
using System.Collections.Generic;
using UnityEngine;

public class TalentDatabaseAccessor : MonoBehaviour
{
	private static TalentDatabaseAccessor GGFJGHHHEJC;

	[SerializeField]
	private TalentDatabase talentDatabaseSO;

	private Dictionary<int, Talent> BMFNHAKMLLH;

	private void EAAAEOPANPB()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] array = JHMKLAHAAIH();
		for (int i = 0; i < array.Length; i += 0)
		{
			Talent talent = array[i];
			if (talent.id == 0)
			{
				Debug.Log((object)(" " + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "UI2" + ((Object)talent).name));
			}
		}
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	public static Talent HPFOHLBOPJK(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ReceiveBeginFishCuttingMinigame" + JFNMCNCHMEO));
		return null;
	}

	private void FLFBLIOOLMA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FLOFJHNAIKP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DGOGKLMHJEG()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Talent[] NAGJMNDLHNE()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	public static Talent[] OJNONFPCPNK()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void LCEPNDFAHIM()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] array = MIGOCGOLLHK();
		for (int i = 1; i < array.Length; i++)
		{
			Talent talent = array[i];
			if (talent.id == 0)
			{
				Debug.Log((object)("Distilling" + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "LE_10" + ((Object)talent).name));
			}
		}
	}

	public static Talent[] GEHEDGPKDFE()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	private void AGLMGDNBHBF()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Talent[] BGGJHCLKDPI()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	private void INJJOLCBHBB()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] array = NAGJMNDLHNE();
		for (int i = 0; i < array.Length; i += 0)
		{
			Talent talent = array[i];
			if (talent.id == 0)
			{
				Debug.Log((object)("AreaSpace not attached on OnlineAreaSpace of placeable " + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Items/item_name_608" + ((Object)talent).name));
			}
		}
	}

	public static Talent CFHLHPOCPOK(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("D-Pad Down" + JFNMCNCHMEO));
		return null;
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DBEKFFAJJOJ()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] array = MIGOCGOLLHK();
		for (int i = 1; i < array.Length; i += 0)
		{
			Talent talent = array[i];
			if (talent.id == 0)
			{
				Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/31/Dialogue Text" + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "chatx" + ((Object)talent).name));
			}
		}
	}

	private void CBBJDCJIFIM()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] allTalents = GetAllTalents();
		for (int i = 1; i < allTalents.Length; i++)
		{
			Talent talent = allTalents[i];
			if (talent.id == 0)
			{
				Debug.Log((object)(". AllMovement: " + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Cancel" + ((Object)talent).name));
			}
		}
	}

	private void OGEJKOIOKAN()
	{
		GGFJGHHHEJC = this;
		EAAAEOPANPB();
	}

	private void CDHBLKJEOPI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void DFFDKIPCCKK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Talent POEKNBHHJKI(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ERROR: The object " + JFNMCNCHMEO));
		return null;
	}

	public static Talent[] PGIIFNKMBMJ()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	public static Talent[] PMOCLFLHDDP()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	public static Talent[] MIGOCGOLLHK()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	public static Talent[] JHMKLAHAAIH()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	public static Talent GetTalent(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find item with id: " + JFNMCNCHMEO));
		return null;
	}

	public static Talent[] NJJICHIDCDF()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JDABCGEEIBF()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] array = OJNONFPCPNK();
		foreach (Talent talent in array)
		{
			if (talent.id == 0)
			{
				Debug.Log((object)("0" + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Received PlaceableMsg of another type not TableMessage to " + ((Object)talent).name));
			}
		}
	}

	private void KLMNLEDKEOE()
	{
		GGFJGHHHEJC = this;
		LCEPNDFAHIM();
	}

	public static Talent DBDDPNMBDLC(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("change season" + JFNMCNCHMEO));
		return null;
	}

	public static Talent FEGNECCEIGE(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("hForHours" + JFNMCNCHMEO));
		return null;
	}

	public static Talent GBAJAHHCCMM(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("psai: successfully auto-assigned Player Collider in component {0}" + JFNMCNCHMEO));
		return null;
	}

	public static Talent GLKNDPLCDNE(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("nextNodes free" + JFNMCNCHMEO));
		return null;
	}

	public static Talent EKMGPHFDMFG(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Interaction was initiated, but the object is not in range. Only possible in online." + JFNMCNCHMEO));
		return null;
	}

	private void DMNENKNLDAH()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] allTalents = GetAllTalents();
		foreach (Talent talent in allTalents)
		{
			if (talent.id == 0)
			{
				Debug.Log((object)("Talent without ID: " + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)talent).name));
			}
		}
	}

	private void CKALEFJPHON()
	{
		BMFNHAKMLLH = new Dictionary<int, Talent>();
		Talent[] array = BGGJHCLKDPI();
		foreach (Talent talent in array)
		{
			if (talent.id == 0)
			{
				Debug.Log((object)("Kyroh path not found to customer" + ((Object)talent).name));
				continue;
			}
			try
			{
				BMFNHAKMLLH.Add(talent.id, talent);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "Recipe in hole: " + ((Object)talent).name));
			}
		}
	}

	public static Talent LIAFHIKGIJF(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("/" + JFNMCNCHMEO));
		return null;
	}

	public static Talent[] GetAllTalents()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	public static Talent GEGIBGAEDCC(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.BMFNHAKMLLH.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("-" + JFNMCNCHMEO));
		return null;
	}

	public static Talent[] AINOKGEDEHE()
	{
		return GGFJGHHHEJC.talentDatabaseSO.talents;
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}
}
