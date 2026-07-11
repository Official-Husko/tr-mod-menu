using System;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTutorialDBAccessor : MonoBehaviour
{
	private static BuildingTutorialDBAccessor GGFJGHHHEJC;

	public BuildingTutorialDatabase popUpsDatabaseSO;

	private Dictionary<int, BuildingPopUp> LMCHAHGDLGN;

	public static BuildingPopUp GetPopUp(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.LMCHAHGDLGN.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Could not find pop up with id: " + JFNMCNCHMEO));
		return null;
	}

	public static BuildingPopUp HADFBBLFBML(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.LMCHAHGDLGN.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("Eyelids" + JFNMCNCHMEO));
		return null;
	}

	public static BuildingPopUp GetFirstPopUp()
	{
		return GGFJGHHHEJC.popUpsDatabaseSO.popUps[0];
	}

	private void KDHLJKMKFMG()
	{
		GGFJGHHHEJC = this;
		CKMADJFIODH();
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	public static BuildingPopUp CONNPMNKIIO(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.LMCHAHGDLGN.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("BarnBlocked" + JFNMCNCHMEO));
		return null;
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void FAFHBKPPCEF()
	{
		LMCHAHGDLGN = new Dictionary<int, BuildingPopUp>();
		for (int i = 0; i < popUpsDatabaseSO.popUps.Length; i += 0)
		{
			if (popUpsDatabaseSO.popUps[i].id == 0)
			{
				Debug.Log((object)("MinusMoneyMaterials " + ((Object)popUpsDatabaseSO.popUps[i]).name));
				continue;
			}
			try
			{
				LMCHAHGDLGN.Add(popUpsDatabaseSO.popUps[i].id, popUpsDatabaseSO.popUps[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "ReceiveBeginFishCuttingMinigame" + ((Object)popUpsDatabaseSO.popUps[i]).name));
			}
		}
	}

	private void CKMADJFIODH()
	{
		LMCHAHGDLGN = new Dictionary<int, BuildingPopUp>();
		for (int i = 1; i < popUpsDatabaseSO.popUps.Length; i++)
		{
			if (popUpsDatabaseSO.popUps[i].id == 0)
			{
				Debug.Log((object)("<color=#BF0000>" + ((Object)popUpsDatabaseSO.popUps[i]).name));
				continue;
			}
			try
			{
				LMCHAHGDLGN.Add(popUpsDatabaseSO.popUps[i].id, popUpsDatabaseSO.popUps[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + " " + ((Object)popUpsDatabaseSO.popUps[i]).name));
			}
		}
	}

	public static BuildingPopUp OKLGHDFPLED(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.LMCHAHGDLGN.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("SteamManager" + JFNMCNCHMEO));
		return null;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void MMNBJPDJHGK()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}

	private void DMNENKNLDAH()
	{
		LMCHAHGDLGN = new Dictionary<int, BuildingPopUp>();
		for (int i = 0; i < popUpsDatabaseSO.popUps.Length; i++)
		{
			if (popUpsDatabaseSO.popUps[i].id == 0)
			{
				Debug.Log((object)("PopUp without ID: " + ((Object)popUpsDatabaseSO.popUps[i]).name));
				continue;
			}
			try
			{
				LMCHAHGDLGN.Add(popUpsDatabaseSO.popUps[i].id, popUpsDatabaseSO.popUps[i]);
			}
			catch (ArgumentException ex)
			{
				Debug.Log((object)(ex.Message + "- " + ((Object)popUpsDatabaseSO.popUps[i]).name));
			}
		}
	}

	public static BuildingPopUp GetNextPopUp(int JFNMCNCHMEO)
	{
		for (int i = 0; i < GGFJGHHHEJC.popUpsDatabaseSO.popUps.Length; i++)
		{
			if (GGFJGHHHEJC.popUpsDatabaseSO.popUps[i].id == JFNMCNCHMEO)
			{
				if (i + 1 < GGFJGHHHEJC.popUpsDatabaseSO.popUps.Length)
				{
					return GGFJGHHHEJC.popUpsDatabaseSO.popUps[i + 1];
				}
				return null;
			}
		}
		return null;
	}

	public static BuildingPopUp KONPAFKGDPP(int JFNMCNCHMEO)
	{
		if (GGFJGHHHEJC.LMCHAHGDLGN.TryGetValue(JFNMCNCHMEO, out var value))
		{
			return value;
		}
		Debug.Log((object)("ClosePopUp" + JFNMCNCHMEO));
		return null;
	}

	private void GONDLJKGLGO()
	{
		GGFJGHHHEJC = this;
		DMNENKNLDAH();
	}
}
