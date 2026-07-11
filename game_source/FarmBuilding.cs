using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class FarmBuilding : MonoBehaviour
{
	[SerializeField]
	protected bool open;

	[SerializeField]
	protected int _constructionPhase;

	[SerializeField]
	protected int _level;

	[SerializeField]
	protected bool improving;

	private int FEEEKHAJELL;

	[SerializeField]
	protected GameObject[] constructionPhases;

	[SerializeField]
	protected BuzzNPCVariant[] buzzVariants;

	[SerializeField]
	protected GameObject[] improvingGO;

	[SerializeField]
	private GameObject notImprovingLvl0;

	[SerializeField]
	private GameObject notImprovingLvl1;

	[SerializeField]
	protected GameObject[] toActivateWithConstructionPhases;

	public int[] maxAnimalsAssigned;

	public Placeable placeable;

	public Transform tooltipPos;

	public AnimalFeeder[] waterFeeders;

	public ChangeLayers changeLayers;

	protected static readonly int PCLMNDLNINP = AnimatorParameterCache.p_Hammer;

	protected static readonly int FNCOABKNAHE = AnimatorParameterCache.p_HammerRoof;

	protected static readonly int AMDGJDFDMNP = AnimatorParameterCache.p_Map;

	public int EONJGMONIOM
	{
		get
		{
			return _level;
		}
		set
		{
			_level = Mathf.Max(0, Mathf.Min(value, 2));
		}
	}

	public int KAPKMMGKEPJ
	{
		get
		{
			return FEEEKHAJELL;
		}
		set
		{
			FEEEKHAJELL = value;
		}
	}

	public int DPDMICLMEOD
	{
		get
		{
			return _constructionPhase;
		}
		set
		{
			_constructionPhase = value;
		}
	}

	protected virtual void IEFIPPPLCEL()
	{
		improving = false;
		EONJGMONIOM++;
	}

	public bool IsOpen()
	{
		return open;
	}

	public void SetConstructionPhase(int AKKFJBFMDPB)
	{
		DPDMICLMEOD = AKKFJBFMDPB;
		UpdateSprite();
	}

	private void IFHFNDELKOP()
	{
		try
		{
			if (IsBuilt())
			{
				if (improving)
				{
					KAPKMMGKEPJ--;
					if (KAPKMMGKEPJ == 0)
					{
						IEFIPPPLCEL();
					}
				}
				HJGLFPDHGEG();
				HFMANGJKOMA();
				FGKCGJOBKHG();
				UpdateAnimalsState();
			}
			else
			{
				JKMBDADNOCD();
			}
			NALJNIOAIAG();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in FarmBuilding.OnPlayerSleep: " + ex.Message));
		}
	}

	protected abstract void HFMANGJKOMA();

	private void FGKCGJOBKHG()
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		if (allAnimals.Count == 0)
		{
			return;
		}
		int num = allAnimals.Count;
		if (waterFeeders.Length == 1)
		{
			for (int i = 0; i < allAnimals.Count; i++)
			{
				waterFeeders[0].WasteUnit(1);
			}
			return;
		}
		bool flag = Random.Range(0, 1) == 0;
		while (num > 0)
		{
			if (waterFeeders[(!flag) ? 1u : 0u].GetCurrentAmount() > 0)
			{
				waterFeeders[(!flag) ? 1u : 0u].WasteUnit(1);
			}
			else
			{
				waterFeeders[flag ? 1 : 0].WasteUnit(1);
			}
			num--;
		}
	}

	public virtual void UpdateSprite()
	{
		for (int i = 0; i < constructionPhases.Length; i++)
		{
			constructionPhases[i].SetActive(i == DPDMICLMEOD);
		}
		for (int j = 0; j < improvingGO.Length; j++)
		{
			improvingGO[j].SetActive(improving && IsBuilt() && j == EONJGMONIOM);
		}
		if (Object.op_Implicit((Object)(object)notImprovingLvl0))
		{
			notImprovingLvl0.SetActive(EONJGMONIOM == 0 && !improving);
		}
		if (Object.op_Implicit((Object)(object)notImprovingLvl1))
		{
			notImprovingLvl1.SetActive(EONJGMONIOM == 1 && !improving);
		}
		for (int k = 0; k < toActivateWithConstructionPhases.Length; k++)
		{
			toActivateWithConstructionPhases[k].SetActive(!IsBuilt());
		}
		NALJNIOAIAG();
	}

	public bool IsLastLevel()
	{
		return EONJGMONIOM == 2;
	}

	protected virtual void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	public abstract void UpdateAnimalsState();

	public void ResetImprovement()
	{
		EONJGMONIOM = 0;
		UpdateSprite();
	}

	protected virtual void NALJNIOAIAG()
	{
		if (IsBuilt() && improving)
		{
			if (EONJGMONIOM == 0)
			{
				HNBNJFPAKFL(buzzVariants.Length - 4, buzzVariants.Length - 3);
			}
			else if (EONJGMONIOM == 1)
			{
				HNBNJFPAKFL(buzzVariants.Length - 2, buzzVariants.Length - 1);
			}
		}
	}

	protected virtual void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
	}

	public void SetImproving(int AACODHOODGB)
	{
		KAPKMMGKEPJ = AACODHOODGB;
		if (KAPKMMGKEPJ > 0)
		{
			improving = true;
			UpdateSprite();
			NALJNIOAIAG();
		}
	}

	public bool IsBuilt()
	{
		return DPDMICLMEOD == constructionPhases.Length - 1;
	}

	protected void HNBNJFPAKFL(int GMOKICIHIOC, int POHAKPIMEEO)
	{
		if (KAPKMMGKEPJ == 2)
		{
			((Component)buzzVariants[GMOKICIHIOC]).gameObject.SetActive(true);
			((Component)buzzVariants[POHAKPIMEEO]).gameObject.SetActive(false);
		}
		else if (KAPKMMGKEPJ == 1)
		{
			((Component)buzzVariants[GMOKICIHIOC]).gameObject.SetActive(false);
			((Component)buzzVariants[POHAKPIMEEO]).gameObject.SetActive(true);
		}
		else
		{
			((Component)buzzVariants[GMOKICIHIOC]).gameObject.SetActive(false);
			((Component)buzzVariants[POHAKPIMEEO]).gameObject.SetActive(false);
		}
		placeable.itemSpace.UpdatePathNodes();
	}

	protected abstract void LKGAOEHMKKO();

	private void HJGLFPDHGEG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			List<AnimalNPC> allAnimals = GetAllAnimals();
			for (int i = 0; i < allAnimals.Count; i++)
			{
				allAnimals[i].IncrementProduction();
				allAnimals[i].IncrementLevel();
			}
		}
	}

	protected abstract void JKMBDADNOCD();

	public virtual void Demolish(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		placeable.PickUp(Vector3.zero, LHLHJCDKNHA: false, IBCOKMGFPKB: false, PIKKACMNOBM: false, PKFIAGMICCK: false);
	}

	public void StartImproving()
	{
		if (!improving)
		{
			improving = true;
			KAPKMMGKEPJ = 3;
			UpdateSprite();
			NALJNIOAIAG();
		}
	}

	public abstract List<AnimalNPC> GetAllAnimals();
}
