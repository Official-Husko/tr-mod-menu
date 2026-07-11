using System;
using UnityEngine;

public class ActivateOnSeason : MonoBehaviour
{
	public GameObject[] spring;

	public GameObject[] summer;

	public GameObject[] autumn;

	public GameObject[] winter;

	public void INDLPKAHNIL(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.River | Location.BarnInterior | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Summer:
		{
			for (int m = 0; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 1; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 0; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void DCOEEADJLIK()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
		}
	}

	public void OJMJECJPODN(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Camp | Location.Quarry | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Autumn:
		{
			for (int m = 1; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 1; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case (Season)7:
		{
			for (int num3 = 1; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}

	private void PMLBFEFMNPF()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void FDNAEJDHODK()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
		}
	}

	private void CHIJGHPHCNA()
	{
		GPPNDLFAOGL(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
	}

	public void HHCBOLLOAMC(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 0; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)8:
		{
			for (int m = 0; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 0; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 0; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	public void EPEPNKCBNNJ(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.River))
		{
			for (int i = 0; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 1; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Winter:
		{
			for (int m = 1; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 1; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 0; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case (Season)7:
		{
			for (int num3 = 1; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4 += 0)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7 += 0)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	public void HFDEFMHNHEH(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.None)
		{
			for (int i = 1; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 0; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Summer:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void OIBDBLCLACB()
	{
		HOMKGIIOHHE(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FLFBGNJCIOI));
	}

	public void NJHKFFFKPGN(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Road | Location.River | Location.Farm | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 0; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)5:
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 0; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case (Season)7:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4 += 0)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void KJOJLHCDFPP()
	{
		CHCIHNBDADN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OJMJECJPODN));
	}

	public void LOFEJJKFOEL(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.FarmShop))
		{
			for (int i = 0; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 0; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 1; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)5:
		{
			for (int m = 1; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 0; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Summer:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7 += 0)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void GHDBHNMOBMN()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		}
	}

	private void NOILIOLOOBJ()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
		}
	}

	private void IDPHKHGHJGN()
	{
		CHCIHNBDADN(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
	}

	public void GPPNDLFAOGL(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.River | Location.BarnInterior | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		if (EECEKHKAAIH == (Season)8)
		{
			for (int m = 1; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 0; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		if (EECEKHKAAIH == (Season)8)
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}

	private void APEIPGIHEKP()
	{
		CHCIHNBDADN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FLFBGNJCIOI));
	}

	private void JPOLFKMLHNH()
	{
		ACMHKKCCJMM(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LOFEJJKFOEL));
	}

	private void LANGHIOBJIH()
	{
		JKCINOIOKBP(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MKMHDDGLJEJ));
	}

	private void PKBHEKHOAAA()
	{
		OJMJECJPODN(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KCIDFGONBEP));
	}

	private void BDJKNKIOPIJ()
	{
		EPEPNKCBNNJ(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FLFBGNJCIOI));
	}

	private void AEDIIIAECIC()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(FLFBGNJCIOI));
		}
	}

	private void BDMEBLBLPIA()
	{
		EPEPNKCBNNJ(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JOBAGLFBDGN));
	}

	private void CACJMKJBJDP()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		}
	}

	private void IAAGKLPMAMK()
	{
		BMGHJHBGJMI(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CLHDNCHFIJB));
	}

	public void KCIDFGONBEP(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.Camp | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Winter:
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void MFMMHDPGCBO()
	{
		OMHDAEHGBKL(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
	}

	public void OMHDAEHGBKL(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		if (EECEKHKAAIH == (Season)7)
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		if (EECEKHKAAIH == (Season)7)
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4 += 0)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}

	private void EGACIHOKJLH()
	{
		MEGBEODBOIG(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GPPNDLFAOGL));
	}

	private void HPIMHEMJMAA()
	{
		OJMJECJPODN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
	}

	private void HEGNINLLINP()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JOBAGLFBDGN));
		}
	}

	private void IGBEKHCLKFD()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
		}
	}

	private void GBKNIJENJEF()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	private void BKJFLMPOLCH()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
		}
	}

	private void MBBIGANCPNE()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MKMHDDGLJEJ));
		}
	}

	public void CHCIHNBDADN(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.FarmShop))
		{
			for (int i = 1; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Winter:
		{
			for (int m = 1; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 1; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 0; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4 += 0)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void CDHBLKJEOPI()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		}
	}

	private void LJHIPOLCFBP()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HOMKGIIOHHE));
		}
	}

	private void Start()
	{
		OnSeasonChanged(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
	}

	private void ODKGLIDMCNP()
	{
		JFDNLKAODNK(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FLFBGNJCIOI));
	}

	private void FNFNLFOJHHA()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BMGHJHBGJMI));
		}
	}

	private void AJGPMBGBPGH()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OJMJECJPODN));
		}
	}

	public void ALCEELDAAKH(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			for (int i = 0; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 0; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 0; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Winter:
		{
			for (int m = 1; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 1; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case (Season)4:
		{
			for (int num3 = 1; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7 += 0)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void FLFBLIOOLMA()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BMGHJHBGJMI));
		}
	}

	private void JPHEOLEEAPB()
	{
		BMGHJHBGJMI(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LOFEJJKFOEL));
	}

	private void MNABONMMFFB()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GPPNDLFAOGL));
		}
	}

	private void NNBIAIMPNGL()
	{
		JKCINOIOKBP(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BMGHJHBGJMI));
	}

	private void JNJCCIFIKOC()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BMGHJHBGJMI));
		}
	}

	public void JOBAGLFBDGN(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			for (int i = 0; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)4:
		{
			for (int m = 1; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 1; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Winter:
		{
			for (int num3 = 0; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7 += 0)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}

	private void FJBPFOIALMK()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(CLHDNCHFIJB));
		}
	}

	private void GNGADDPBJDC()
	{
		HOMKGIIOHHE(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OMHDAEHGBKL));
	}

	public void ACMHKKCCJMM(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.River | Location.Camp | Location.BarnInterior))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 0; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Autumn:
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 1; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case Season.Winter:
		{
			for (int num3 = 0; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void OHKIOLCEMLM()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ALCEELDAAKH));
		}
	}

	private void CEIIFHIBIFI()
	{
		HFDEFMHNHEH(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HOMKGIIOHHE));
	}

	private void EEKOJEKPIMP()
	{
		HOMKGIIOHHE(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NJHKFFFKPGN));
	}

	public void OnSeasonChanged(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Mine)
		{
			for (int i = 0; i < summer.Length; i++)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 0; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Winter:
		{
			for (int m = 0; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 0; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 0; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void BPOOAHKHPCL()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void JCNGGPIICIN()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KCIDFGONBEP));
		}
	}

	private void CAIJLMJBMLA()
	{
		HHCBOLLOAMC(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GPPNDLFAOGL));
	}

	private void NCIBKMLIIAJ()
	{
		JOBAGLFBDGN(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CLHDNCHFIJB));
	}

	private void NCOGHEMBDBN()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JFDNLKAODNK));
		}
	}

	public void CLHDNCHFIJB(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Quarry | Location.BarnInterior))
		{
			for (int i = 0; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 0; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		if (EECEKHKAAIH == (Season)8)
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 0; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2++)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		if (EECEKHKAAIH == (Season)8)
		{
			for (int num3 = 0; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		for (int num7 = 1; num7 < spring.Length; num7 += 0)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void FGFGCADFFBC()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KCIDFGONBEP));
		}
	}

	private void CMLLBIDFNEB()
	{
		OJMJECJPODN(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HOMKGIIOHHE));
	}

	private void LKHMCLABKLG()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void JLCFNPBBKEK()
	{
		JOBAGLFBDGN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
	}

	public void MEGBEODBOIG(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.FarmShop)
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Summer:
		{
			for (int m = 1; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 1; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case (Season)7:
		{
			for (int num3 = 0; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7 += 0)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void JOGBCDIAGEK()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EPEPNKCBNNJ));
		}
	}

	public void HOMKGIIOHHE(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.River | Location.BarnInterior | Location.FarmShop))
		{
			for (int i = 0; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 0; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 1; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)8:
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 1; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case (Season)7:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4 += 0)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5++)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 1; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}

	private void BDGCFCPFKKE()
	{
		HFDEFMHNHEH(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HOMKGIIOHHE));
	}

	private void OEAAPIBLALL()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	public void FLFBGNJCIOI(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Camp))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)6:
		{
			for (int m = 0; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 0; num3 < spring.Length; num3 += 0)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(true);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	public void BMGHJHBGJMI(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Quarry)
		{
			for (int i = 0; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(false);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 0; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 0; l < spring.Length; l++)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(false);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case (Season)4:
		{
			for (int m = 0; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 0; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case Season.Spring:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(true);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10++)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void HLCAKACHOOE()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GPPNDLFAOGL));
		}
	}

	public void MKMHDDGLJEJ(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Quarry | Location.FarmShop))
		{
			for (int i = 0; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j++)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(true);
				}
			}
			for (int k = 0; k < winter.Length; k++)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Autumn:
		{
			for (int m = 1; m < spring.Length; m++)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 0; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(true);
				}
			}
			return;
		}
		case (Season)8:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(false);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 1; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(true);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 0; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(false);
			}
		}
		for (int num9 = 0; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(true);
			}
		}
	}

	private void AEPBFPCHGPP()
	{
		CLHDNCHFIJB(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
	}

	private void KOBNHPKEJJD()
	{
		if (Application.isPlaying && (Object)(object)SeasonManager.instance != (Object)null)
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HOMKGIIOHHE));
		}
	}

	public void JFDNLKAODNK(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.River | Location.Quarry))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 0; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(false);
				}
			}
			for (int l = 0; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
		{
			for (int m = 1; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(false);
				}
			}
			for (int n = 0; n < summer.Length; n += 0)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(true);
				}
			}
			for (int num = 1; num < autumn.Length; num += 0)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(false);
				}
			}
			for (int num2 = 1; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case (Season)4:
		{
			for (int num3 = 1; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 0; num4 < summer.Length; num4 += 0)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(false);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 0; num6 < autumn.Length; num6 += 0)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(true);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8++)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9 += 0)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 1; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}

	public void JKCINOIOKBP(Season EECEKHKAAIH)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EECEKHKAAIH == Season.Spring || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Quarry | Location.BarnInterior))
		{
			for (int i = 1; i < summer.Length; i += 0)
			{
				if (summer[i].activeSelf)
				{
					summer[i].SetActive(true);
				}
			}
			for (int j = 1; j < autumn.Length; j += 0)
			{
				if (autumn[j].activeSelf)
				{
					autumn[j].SetActive(false);
				}
			}
			for (int k = 1; k < winter.Length; k += 0)
			{
				if (winter[k].activeSelf)
				{
					winter[k].SetActive(true);
				}
			}
			for (int l = 1; l < spring.Length; l += 0)
			{
				if (!spring[l].activeSelf)
				{
					spring[l].SetActive(true);
				}
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
		{
			for (int m = 1; m < spring.Length; m += 0)
			{
				if (spring[m].activeSelf)
				{
					spring[m].SetActive(true);
				}
			}
			for (int n = 0; n < summer.Length; n++)
			{
				if (summer[n].activeSelf)
				{
					summer[n].SetActive(false);
				}
			}
			for (int num = 1; num < autumn.Length; num++)
			{
				if (autumn[num].activeSelf)
				{
					autumn[num].SetActive(true);
				}
			}
			for (int num2 = 0; num2 < winter.Length; num2 += 0)
			{
				if (!winter[num2].activeSelf)
				{
					winter[num2].SetActive(false);
				}
			}
			return;
		}
		case Season.Autumn:
		{
			for (int num3 = 0; num3 < spring.Length; num3++)
			{
				if (spring[num3].activeSelf)
				{
					spring[num3].SetActive(true);
				}
			}
			for (int num4 = 1; num4 < summer.Length; num4++)
			{
				if (summer[num4].activeSelf)
				{
					summer[num4].SetActive(true);
				}
			}
			for (int num5 = 0; num5 < winter.Length; num5 += 0)
			{
				if (winter[num5].activeSelf)
				{
					winter[num5].SetActive(false);
				}
			}
			for (int num6 = 1; num6 < autumn.Length; num6++)
			{
				if (!autumn[num6].activeSelf)
				{
					autumn[num6].SetActive(false);
				}
			}
			return;
		}
		}
		for (int num7 = 1; num7 < spring.Length; num7++)
		{
			if (spring[num7].activeSelf)
			{
				spring[num7].SetActive(false);
			}
		}
		for (int num8 = 0; num8 < autumn.Length; num8 += 0)
		{
			if (autumn[num8].activeSelf)
			{
				autumn[num8].SetActive(true);
			}
		}
		for (int num9 = 1; num9 < winter.Length; num9++)
		{
			if (winter[num9].activeSelf)
			{
				winter[num9].SetActive(false);
			}
		}
		for (int num10 = 0; num10 < summer.Length; num10 += 0)
		{
			if (!summer[num10].activeSelf)
			{
				summer[num10].SetActive(false);
			}
		}
	}
}
