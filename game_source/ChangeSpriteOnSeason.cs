using System;
using UnityEngine;

public class ChangeSpriteOnSeason : MonoBehaviour
{
	public bool shareSpringSprite = true;

	public Sprite normal;

	public Sprite summer;

	public Sprite autumn;

	public Sprite christmas;

	public SpriteRenderer spriteToChange;

	[SerializeField]
	private GameObject[] objectsToDeactivate;

	[SerializeField]
	private Collider2D[] collidersToDeactivate;

	public void CFOCLJIDNFK(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.Camp | Location.Farm))
		{
			if ((Object)(object)normal != (Object)null)
			{
				JKOALIPLBMI(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				IKCDNKEODDA(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				MGFBCDOMEBE(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				GIBGLNPNJKP(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				AAFFNBANLGM(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GCMPAFIANPO(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				MJIEMICNPCA(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			AHGDKJPJCHN(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				OEFGJONHAFJ(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				HBLLEACGPAM(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void PKBBDHIHELJ(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	public void OnSeasonChanged(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Mine)
		{
			if ((Object)(object)normal != (Object)null)
			{
				CNCEOFCCNMJ(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				CNCEOFCCNMJ(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				CNCEOFCCNMJ(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				CNCEOFCCNMJ(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				CNCEOFCCNMJ(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CNCEOFCCNMJ(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				CNCEOFCCNMJ(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CNCEOFCCNMJ(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				CNCEOFCCNMJ(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				CNCEOFCCNMJ(OEIALNKDNJB: false);
			}
			break;
		}
	}

	public void INDLPKAHNIL(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.River | Location.Farm | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				LPANDLHLBLB(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				BKJIALBKIBJ(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				DFEIOPAFEDK(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				ILLCENAAEON(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				MGFBCDOMEBE(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GFHGFJNIFCF(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				FLMBIGGCDPO(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GHHDDLDLIPK(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				CAEMLNPPKOA(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				ILLCENAAEON(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void DOHLOJOIHFO()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Dialogue System/Conversation/AcceptRoomSecondFloor/Entry/1/Dialogue Text"), (Object)(object)((Component)this).gameObject);
		}
		CFOCLJIDNFK(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MEJNOBJOELI));
	}

	public void NJJJLLHDPPJ(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				MGFBCDOMEBE(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				ECJKJHBIBMN(OEIALNKDNJB: true);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				IKCDNKEODDA(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				FHDEANPHOIC(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				CCIOIGPMGHL(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			OEFGJONHAFJ(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				GDOCHIIGBFI(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			FFNFEKLMDHB(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				NCNJHFHELLM(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				DFEIOPAFEDK(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void LFNENELHOGJ()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/6/Dialogue Text"), (Object)(object)((Component)this).gameObject);
		}
		KMHEEIONKGI(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GGGPBAKHGIP));
	}

	private void JKOALIPLBMI(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	public void EFOJGJMGCIH(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				NGNJLMCHPMC(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				DFEIOPAFEDK(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				FJICLEHBOIA(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				GCMPAFIANPO(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				FFNFEKLMDHB(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			BKJIALBKIBJ(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				FLMBIGGCDPO(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			IKCDNKEODDA(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				NEGGGJEGPPK(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				CFLFNNALKBB(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void INDGDJGAGPH(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void BJBPHIFNKIF()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "City/Carpenters/Oak/Chisel"), (Object)(object)((Component)this).gameObject);
		}
		GGGPBAKHGIP(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FPDABJECCNO));
	}

	private void DFEIOPAFEDK(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void ECJKJHBIBMN(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void GFHGFJNIFCF(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void DCKHJPFDIAM(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void ILLCENAAEON(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void MJIEMICNPCA(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void EBNENBFLEKB()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "InteractPlaceableIfIsPossibleMaster"), (Object)(object)((Component)this).gameObject);
		}
		HFDEFMHNHEH(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MEJNOBJOELI));
	}

	private void GDOCHIIGBFI(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void AHGDKJPJCHN(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	public void GGGPBAKHGIP(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.BarnInterior | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				DCKHJPFDIAM(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				HKNDIAEAAFK(OEIALNKDNJB: true);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				AAFFNBANLGM(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				HKNDIAEAAFK(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				ILLCENAAEON(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			NCNJHFHELLM(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				OEFGJONHAFJ(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GCLFGIBIBHA(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				ILLCENAAEON(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				CAEMLNPPKOA(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void GHHDDLDLIPK(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void BKJIALBKIBJ(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void HPMFOHOMLDO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(FAJJANOMDLP));
		}
	}

	private void OCPLOMJAFPC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ELHAJCDLBBK));
		}
	}

	public void FAJJANOMDLP(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.River | Location.Camp | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				ILLCENAAEON(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				KLDJPDJHPDG(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				MGFBCDOMEBE(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				GIBGLNPNJKP(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				FJICLEHBOIA(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			FFNFEKLMDHB(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				FFNFEKLMDHB(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GIBGLNPNJKP(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				NCNJHFHELLM(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				NADOEIENKIH(OEIALNKDNJB: true);
			}
			break;
		}
	}

	public void KMHEEIONKGI(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.River | Location.Quarry))
		{
			if ((Object)(object)normal != (Object)null)
			{
				FJICLEHBOIA(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				IGFCLJKOCEG(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				MJIEMICNPCA(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				KLDJPDJHPDG(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				GFHGFJNIFCF(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GCMPAFIANPO(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				HKNDIAEAAFK(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			NEGGGJEGPPK(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				AAFFNBANLGM(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				INDGDJGAGPH(OEIALNKDNJB: false);
			}
			break;
		}
	}

	public void PPIHDINDBKI(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Quarry | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				HKNDIAEAAFK(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				IKCDNKEODDA(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				CAEMLNPPKOA(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				CNCEOFCCNMJ(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				LPANDLHLBLB(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			HBLLEACGPAM(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				PKBBDHIHELJ(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GFHGFJNIFCF(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				GCMPAFIANPO(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				GCMPAFIANPO(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void FHDEANPHOIC(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void IKCDNKEODDA(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void GCMPAFIANPO(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void KLDJPDJHPDG(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	public void HFDEFMHNHEH(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.Camp))
		{
			if ((Object)(object)normal != (Object)null)
			{
				GDOCHIIGBFI(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				NADOEIENKIH(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				ECJKJHBIBMN(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				CNCEOFCCNMJ(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				IGFCLJKOCEG(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			KLDJPDJHPDG(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				AHGDKJPJCHN(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GIBGLNPNJKP(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				AHGDKJPJCHN(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				NGNJLMCHPMC(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void FJICLEHBOIA(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void NOILIOLOOBJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OPHFKKHJPCO));
		}
	}

	private void ICFHPJHBPDN()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Throw"), (Object)(object)((Component)this).gameObject);
		}
		GHEAGNKPBFH(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NJJJLLHDPPJ));
	}

	private void HLHHDNGOGNI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LODGDFFFGJA));
		}
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(NJJJLLHDPPJ));
		}
	}

	private void OILHJENGGEL()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Player2"), (Object)(object)((Component)this).gameObject);
		}
		HHCBOLLOAMC(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JHEKJPEHAJB));
	}

	public void OPHFKKHJPCO(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.River | Location.Farm | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				NCNJHFHELLM(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				FJICLEHBOIA(OEIALNKDNJB: true);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				MJIEMICNPCA(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				GDOCHIIGBFI(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				ECJKJHBIBMN(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			AHGDKJPJCHN(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				NADOEIENKIH(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			JCFFIDCNJPG(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				DFEIOPAFEDK(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				LPANDLHLBLB(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void GCLFGIBIBHA(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void FPDPAJHNGHK()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Snow"), (Object)(object)((Component)this).gameObject);
		}
		GGGPBAKHGIP(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BCDAAJICKFP));
	}

	private void IGFCLJKOCEG(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void LPANDLHLBLB(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void NPMLFHDHJBE()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Hurt"), (Object)(object)((Component)this).gameObject);
		}
		GHEAGNKPBFH(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PPIHDINDBKI));
	}

	public void GHEAGNKPBFH(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				GFHGFJNIFCF(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				GHHDDLDLIPK(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				DCKHJPFDIAM(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				DCKHJPFDIAM(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				JKOALIPLBMI(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			IKCDNKEODDA(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				INDGDJGAGPH(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CFLFNNALKBB(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				FHDEANPHOIC(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				DFEIOPAFEDK(OEIALNKDNJB: false);
			}
			break;
		}
	}

	public void BGGFNFMNOBF(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.River | Location.Farm))
		{
			if ((Object)(object)normal != (Object)null)
			{
				OEFGJONHAFJ(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				GCMPAFIANPO(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				ILLCENAAEON(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				OEFGJONHAFJ(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				AHGDKJPJCHN(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			BKJIALBKIBJ(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				MJIEMICNPCA(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			FJICLEHBOIA(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				GIBGLNPNJKP(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				GCLFGIBIBHA(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void NCNJHFHELLM(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void BPOOAHKHPCL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ELHAJCDLBBK));
		}
	}

	private void FFNFEKLMDHB(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void MCMKNBIBDFF()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "<color=#BF0000>"), (Object)(object)((Component)this).gameObject);
		}
		GGGPBAKHGIP(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LODGDFFFGJA));
	}

	private void GIBGLNPNJKP(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void NDNBDEHFFJF()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "end conversations"), (Object)(object)((Component)this).gameObject);
		}
		GHEAGNKPBFH(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OPHFKKHJPCO));
	}

	private void FLMBIGGCDPO(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void CAEMLNPPKOA(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void KACEOJDPLKB()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Dialogue System/Conversation/Gass_Stand/Entry/10/Dialogue Text"), (Object)(object)((Component)this).gameObject);
		}
		BIDODCBFMNJ(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PPIHDINDBKI));
	}

	public void BOGAMCJIFMK(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Quarry | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				JKOALIPLBMI(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				DFEIOPAFEDK(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				NGNJLMCHPMC(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				KLDJPDJHPDG(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				BKJIALBKIBJ(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			IKCDNKEODDA(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				HKNDIAEAAFK(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			FFNFEKLMDHB(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				ECJKJHBIBMN(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				GHHDDLDLIPK(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PPIHDINDBKI));
		}
	}

	private void PLHEHGHFCJI()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + ": "), (Object)(object)((Component)this).gameObject);
		}
		HFDEFMHNHEH(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BIDODCBFMNJ));
	}

	private void OEFGJONHAFJ(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void CCIOIGPMGHL(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	public void ELHAJCDLBBK(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.BarnInterior | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				AHGDKJPJCHN(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				NADOEIENKIH(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				NADOEIENKIH(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				HBLLEACGPAM(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				GIBGLNPNJKP(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			HKNDIAEAAFK(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				HKNDIAEAAFK(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CFLFNNALKBB(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				FLMBIGGCDPO(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				FJICLEHBOIA(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void PBFGFECPPPO()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + ", "), (Object)(object)((Component)this).gameObject);
		}
		EFOJGJMGCIH(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MEJNOBJOELI));
	}

	private void NADOEIENKIH(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void IAAGKLPMAMK()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Dialogue System/Conversation/Gass_Quest/Entry/31/Dialogue Text"), (Object)(object)((Component)this).gameObject);
		}
		OnSeasonChanged(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BOGAMCJIFMK));
	}

	private void NGNJLMCHPMC(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HHCBOLLOAMC));
		}
	}

	private void CAIJLMJBMLA()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "ReceiveStartKlaynCombat"), (Object)(object)((Component)this).gameObject);
		}
		NJJJLLHDPPJ(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BOGAMCJIFMK));
	}

	private void JPOLFKMLHNH()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "popUpBuilding23"), (Object)(object)((Component)this).gameObject);
		}
		PPIHDINDBKI(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BOGAMCJIFMK));
	}

	private void AMBKBOBDAIF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	public void HHCBOLLOAMC(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.FarmShop)
		{
			if ((Object)(object)normal != (Object)null)
			{
				IKCDNKEODDA(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				FHDEANPHOIC(OEIALNKDNJB: true);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				GDOCHIIGBFI(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				FJICLEHBOIA(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				AAFFNBANLGM(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			DFEIOPAFEDK(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				ECJKJHBIBMN(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CFLFNNALKBB(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				FJICLEHBOIA(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				FLMBIGGCDPO(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void JCNGGPIICIN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KMHEEIONKGI));
		}
	}

	private void DMFMNEMDFNP()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + ""), (Object)(object)((Component)this).gameObject);
		}
		GHEAGNKPBFH(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EPEPNKCBNNJ));
	}

	public void BMGHJHBGJMI(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				NCNJHFHELLM(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				DFEIOPAFEDK(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				GCLFGIBIBHA(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				FJICLEHBOIA(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				HBLLEACGPAM(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			DCKHJPFDIAM(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				HKNDIAEAAFK(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GCMPAFIANPO(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				AAFFNBANLGM(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				DFEIOPAFEDK(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void HBLLEACGPAM(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void JCFFIDCNJPG(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	public void EPEPNKCBNNJ(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				HKNDIAEAAFK(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				NADOEIENKIH(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				GHHDDLDLIPK(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				CCIOIGPMGHL(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				JKOALIPLBMI(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			JKOALIPLBMI(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				NGNJLMCHPMC(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			FLMBIGGCDPO(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				IGFCLJKOCEG(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				FLMBIGGCDPO(OEIALNKDNJB: false);
			}
			break;
		}
	}

	public void JHEKJPEHAJB(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm))
		{
			if ((Object)(object)normal != (Object)null)
			{
				CAEMLNPPKOA(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				NGNJLMCHPMC(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				JCFFIDCNJPG(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				JKOALIPLBMI(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				JCFFIDCNJPG(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CFLFNNALKBB(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				MJIEMICNPCA(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			MJIEMICNPCA(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				ECJKJHBIBMN(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				LPANDLHLBLB(OEIALNKDNJB: false);
			}
			break;
		}
	}

	public void FPDABJECCNO(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == (Location.Road | Location.Camp))
		{
			if ((Object)(object)normal != (Object)null)
			{
				HBLLEACGPAM(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				KLDJPDJHPDG(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				GFHGFJNIFCF(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				GCLFGIBIBHA(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				DCKHJPFDIAM(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GCLFGIBIBHA(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				NGNJLMCHPMC(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			NEGGGJEGPPK(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				FHDEANPHOIC(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				GDOCHIIGBFI(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void NEGGGJEGPPK(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void CFLFNNALKBB(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void MGFBCDOMEBE(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 1; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void HKNDIAEAAFK(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 1; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j += 0)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void IKMPNICLPBM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BIDODCBFMNJ));
		}
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HHCBOLLOAMC));
		}
	}

	private void CNCEOFCCNMJ(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i++)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void AAFFNBANLGM(bool OEIALNKDNJB)
	{
		((Renderer)spriteToChange).enabled = OEIALNKDNJB;
		if (objectsToDeactivate != null)
		{
			for (int i = 0; i < objectsToDeactivate.Length; i += 0)
			{
				objectsToDeactivate[i].SetActive(OEIALNKDNJB);
			}
		}
		if (collidersToDeactivate != null)
		{
			for (int j = 0; j < collidersToDeactivate.Length; j++)
			{
				((Behaviour)collidersToDeactivate[j]).enabled = OEIALNKDNJB;
			}
		}
	}

	private void ACFABFCGIGH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EPEPNKCBNNJ));
		}
	}

	private void JCNPCJOBENP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OPHFKKHJPCO));
		}
	}

	public void LODGDFFFGJA(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior))
		{
			if ((Object)(object)normal != (Object)null)
			{
				CNCEOFCCNMJ(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				FJICLEHBOIA(OEIALNKDNJB: true);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				FJICLEHBOIA(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				GFHGFJNIFCF(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				PKBBDHIHELJ(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			JCFFIDCNJPG(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				FLMBIGGCDPO(OEIALNKDNJB: false);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			JCFFIDCNJPG(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				FFNFEKLMDHB(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				IGFCLJKOCEG(OEIALNKDNJB: false);
			}
			break;
		}
	}

	public void MEJNOBJOELI(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.River | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				GFHGFJNIFCF(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				ECJKJHBIBMN(OEIALNKDNJB: true);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				CFLFNNALKBB(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				DCKHJPFDIAM(OEIALNKDNJB: true);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				BKJIALBKIBJ(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			PKBBDHIHELJ(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				AHGDKJPJCHN(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			GDOCHIIGBFI(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				MJIEMICNPCA(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				NCNJHFHELLM(OEIALNKDNJB: true);
			}
			break;
		}
	}

	private void AHFGOOHOLEL()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "Loop"), (Object)(object)((Component)this).gameObject);
		}
		EPEPNKCBNNJ(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BOGAMCJIFMK));
	}

	public void BIDODCBFMNJ(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.River | Location.Camp))
		{
			if ((Object)(object)normal != (Object)null)
			{
				NADOEIENKIH(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				AAFFNBANLGM(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				CCIOIGPMGHL(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				MJIEMICNPCA(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				FHDEANPHOIC(OEIALNKDNJB: true);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CAEMLNPPKOA(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				HBLLEACGPAM(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			DCKHJPFDIAM(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				FHDEANPHOIC(OEIALNKDNJB: false);
				spriteToChange.sprite = christmas;
			}
			else
			{
				NEGGGJEGPPK(OEIALNKDNJB: false);
			}
			break;
		}
	}

	private void Start()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "no tiene el spriteRenderer de las Seasons asignado"), (Object)(object)((Component)this).gameObject);
		}
		OnSeasonChanged(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
	}

	private void HCEDMLJNOBL()
	{
		if ((Object)(object)spriteToChange == (Object)null)
		{
			Debug.LogError((object)(((Object)((Component)this).gameObject).name + "NEW IMPORTANT CUSTOMER EVENT"), (Object)(object)((Component)this).gameObject);
		}
		EPEPNKCBNNJ(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ELHAJCDLBBK));
	}

	public void BCDAAJICKFP(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == ~(Location.Tavern | Location.Farm | Location.FarmShop))
		{
			if ((Object)(object)normal != (Object)null)
			{
				GIBGLNPNJKP(OEIALNKDNJB: false);
				spriteToChange.sprite = normal;
			}
			else
			{
				AAFFNBANLGM(OEIALNKDNJB: false);
			}
			return;
		}
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if ((Object)(object)normal != (Object)null)
			{
				NCNJHFHELLM(OEIALNKDNJB: true);
				spriteToChange.sprite = normal;
			}
			else
			{
				FLMBIGGCDPO(OEIALNKDNJB: false);
			}
			break;
		case Season.Summer:
			if ((Object)(object)summer != (Object)null)
			{
				GIBGLNPNJKP(OEIALNKDNJB: false);
				spriteToChange.sprite = summer;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			CAEMLNPPKOA(shareSpringSprite);
			break;
		case Season.Autumn:
			if ((Object)(object)autumn != (Object)null)
			{
				DFEIOPAFEDK(OEIALNKDNJB: true);
				spriteToChange.sprite = autumn;
				break;
			}
			if (shareSpringSprite)
			{
				spriteToChange.sprite = normal;
			}
			ECJKJHBIBMN(shareSpringSprite);
			break;
		case Season.Winter:
			if ((Object)(object)christmas != (Object)null)
			{
				ILLCENAAEON(OEIALNKDNJB: true);
				spriteToChange.sprite = christmas;
			}
			else
			{
				FHDEANPHOIC(OEIALNKDNJB: false);
			}
			break;
		}
	}
}
