using System;
using UnityEngine;

public class ModifyByGroundType : MonoBehaviour
{
	[Serializable]
	public struct PairGroundSprite
	{
		public GroundType groundType;

		public Sprite sprite;

		public Season season;
	}

	public Placeable placeable;

	public SpriteRenderer spriteRenderer;

	public Sprite defaultSprite;

	public Sprite snowSprite;

	[Space(10f)]
	public PairGroundSprite[] pairs;

	private void CFIIEJDJFPB()
	{
		CKPDKOFJMCE();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LKCGJOLFKFC));
	}

	private void OCPLOMJAFPC()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JAIBGMJMEHC));
		}
	}

	private void APAPPMFIHJE(int JIIGOACEIKL)
	{
		OJDBBJBCBCJ();
	}

	private void HMIIELFEHHD()
	{
		JOOGJANOAMN(SeasonManager.ADEICKHEPFI());
	}

	private void PMKPAFOGLBA(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Summer && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void EFJFJJDGGGI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BFOJIKGMEIF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FICDIANCDHL));
	}

	private void LIAAEMMCCDB(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)4 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void BLNJKNPAKKG(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)4 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void DCOEEADJLIK()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PHAHIHKJIOG));
		}
	}

	private void ODKGLIDMCNP()
	{
		JCHDOCFAMPG();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ALGNCFCJLDJ));
	}

	private void DKDLOBOLNFH()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(KHLHACJEMCF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IIJKAPHMKGO));
	}

	private void JOGBCDIAGEK()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GFMPBMEBOBD));
		}
	}

	private void HHLBFDBHDMC()
	{
		BANAPOHEGGK();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LCIKONKPJJI));
	}

	private void CKPDKOFJMCE()
	{
		AAJJCKCLAGN(SeasonManager.LPGPJPPLHKG());
	}

	private void LKCGJOLFKFC(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Spring && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void GLEADBGEOCE()
	{
		LKCGJOLFKFC(SeasonManager.LPGPJPPLHKG());
	}

	private void LMCJGPHIKPB(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void MLLADNLMIMP()
	{
		JKMFGDGBDDN();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JOOGJANOAMN));
	}

	private void MFJIHCKEIIF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(JGDIFJNCFBO));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FFCCHAKNNPM));
	}

	private void GBFPCABGAII()
	{
		JGDIFJNCFBO();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EDGICPGDAKP));
	}

	private void IIPKPMPGLOL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BMOJKAAIMCP));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(KBGFJEMHMDJ));
	}

	private void JCHDOCFAMPG()
	{
		ALGNCFCJLDJ(SeasonManager.ADEICKHEPFI());
	}

	private void BFBFNJCBOPK()
	{
		FIGNNHNEOGL(SeasonManager.KCJFCHNPIBJ());
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(NOOFLHGHFDF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(KBGFJEMHMDJ));
	}

	private void JOOGJANOAMN(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void BMIENGLCJLL()
	{
		LPHJGHGMICJ(SeasonManager.ADEICKHEPFI());
	}

	private void KBGFJEMHMDJ(int JIIGOACEIKL)
	{
		BLDLEECENFF();
	}

	private void LDPGPIHCBCH()
	{
		MJIDBONKDGC();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PMKPAFOGLBA));
	}

	private void CJAPIMKEFAK()
	{
		GFMPBMEBOBD(SeasonManager.EEGJBDCBKFD());
	}

	private void HPMFOHOMLDO()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
		}
	}

	private void MCMKNBIBDFF()
	{
		PJLABIGIHAI();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FEGEPGGFLIG));
	}

	private void FJKBDHDBGEE(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void NIJMGMDEGLE()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(FEGEPGGFLIG));
		}
	}

	private void NGEHFPOIJFK(int JIIGOACEIKL)
	{
		PJLABIGIHAI();
	}

	private void GDOJKONLMMM()
	{
		MHOEOAJAJOL(SeasonManager.EECEKHKAAIH);
	}

	private void GFMPBMEBOBD(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)8 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void ACFABFCGIGH()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MCIDICEHNFO));
		}
	}

	private void BFOJIKGMEIF()
	{
		JAIBGMJMEHC(SeasonManager.ADEICKHEPFI());
	}

	private void NLNOFEBEBDE()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(NOOFLHGHFDF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FICDIANCDHL));
	}

	private void PKDNMBGODAJ()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PHAHIHKJIOG));
		}
	}

	private void DMFMNEMDFNP()
	{
		GLEADBGEOCE();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(AAJJCKCLAGN));
	}

	private void FICDIANCDHL(int JIIGOACEIKL)
	{
		NOOFLHGHFDF();
	}

	private void DAEJLBJDEIM()
	{
		MJIDBONKDGC();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FEGEPGGFLIG));
	}

	private void BAKDKFKNHDE()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(AHGAGFHKANL));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(LMGOOHFDEBN));
	}

	private void OJDBBJBCBCJ()
	{
		PMKPAFOGLBA(SeasonManager.LPGPJPPLHKG());
	}

	private void EOEDIEABDGB(int JIIGOACEIKL)
	{
		GAFGINOFEPO();
	}

	private void FHDJBIEDHDF()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OOJPHIEMPOO));
		}
	}

	private void FEGEPGGFLIG(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)7 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void HKKDEKIFPPJ()
	{
		BANAPOHEGGK();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EDGICPGDAKP));
	}

	private void BGBFLOCPMII()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(GCKICDDKJLI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	private void BMOJKAAIMCP()
	{
		PJLABIGIHAI(SeasonManager.LPGPJPPLHKG());
	}

	private void GHOKECKAICE()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(JKMFGDGBDDN));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(LFBDCAKJMLN));
	}

	private void OOJPHIEMPOO(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)7 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void IKIPGJNEJNG()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LCIKONKPJJI));
		}
	}

	private void FEHFDNNBCFN()
	{
		MHOEOAJAJOL(SeasonManager.EEGJBDCBKFD());
	}

	private void GNAJBACLEKG()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(PKDEOOOPHAM));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FICDIANCDHL));
	}

	private void BKJHFENEJMH(int JIIGOACEIKL)
	{
		BFOJIKGMEIF();
	}

	private void ANMIPNLGIHM()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JOOGJANOAMN));
		}
	}

	private void FHMIPPPODCD()
	{
		BLNJKNPAKKG(SeasonManager.EECEKHKAAIH);
	}

	private void JHBBABPAJJC()
	{
		NOOFLHGHFDF();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FEGEPGGFLIG));
	}

	private void EEKOJEKPIMP()
	{
		GCKICDDKJLI();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JOOGJANOAMN));
	}

	private void FKNAANNMMLB()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(AOJAIKDOCFJ));
		}
	}

	private void EIDJLHFAMIB()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LCIKONKPJJI));
		}
	}

	private void Awake()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(PJLABIGIHAI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	private void ILCBKEIEOAN()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(FIGNNHNEOGL));
		}
	}

	private void AJGPMBGBPGH()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HEACGABOLBP));
		}
	}

	private void EEPIANDPPLO()
	{
		AAJJCKCLAGN(SeasonManager.PJMGHIMKFJL());
	}

	private void IIJKAPHMKGO(int JIIGOACEIKL)
	{
		FEHFDNNBCFN();
	}

	private void AAJJCKCLAGN(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)5 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void OKHLEMPJONN()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(MJIDBONKDGC));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
	}

	private void PMDPGJKGMOC()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(FJKBDHDBGEE));
		}
	}

	private void AOJAIKDOCFJ(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Summer && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void HPIMHEMJMAA()
	{
		KHLHACJEMCF();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BLNJKNPAKKG));
	}

	private void EDBCAGJGMCM(int JIIGOACEIKL)
	{
		EEPIANDPPLO();
	}

	private void AGILHHEMEFC()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PMKPAFOGLBA));
		}
	}

	private void GNMMELIJKML()
	{
		BMIENGLCJLL();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HEACGABOLBP));
	}

	private void HELHNJDFPPF()
	{
		GCKICDDKJLI();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
	}

	private void COKBJNMAMDI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(FOKPMCGOPGC));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IIJKAPHMKGO));
	}

	private void JGDIFJNCFBO()
	{
		JOOGJANOAMN(SeasonManager.ADEICKHEPFI());
	}

	private void POCIIJFBGPO(int JIIGOACEIKL)
	{
		BMOJKAAIMCP();
	}

	private void FNFNLFOJHHA()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EDGICPGDAKP));
		}
	}

	private void EIBLCDMNBMO(int JIIGOACEIKL)
	{
		BMOJKAAIMCP();
	}

	private void LMGOOHFDEBN(int JIIGOACEIKL)
	{
		AHGAGFHKANL();
	}

	private void HADEPOHAPMA()
	{
		FIGNNHNEOGL(SeasonManager.EECEKHKAAIH);
	}

	private void EFABNGNAENH()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BMOJKAAIMCP));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(APAPPMFIHJE));
	}

	private void FPNCANODJKE()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BFOJIKGMEIF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(APAPPMFIHJE));
	}

	private void JBBHDOMALDB()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PMKPAFOGLBA));
		}
	}

	private void MJIDBONKDGC()
	{
		LIAAEMMCCDB(SeasonManager.LPGPJPPLHKG());
	}

	private void EGACIHOKJLH()
	{
		HADEPOHAPMA();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(LPHJGHGMICJ));
	}

	private void PLHEHGHFCJI()
	{
		BMOJKAAIMCP();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MHOEOAJAJOL));
	}

	private void LFBDCAKJMLN(int JIIGOACEIKL)
	{
		BGLPLADNJGA();
	}

	private void FHEGBNMJADG()
	{
		JCHDOCFAMPG();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BLNJKNPAKKG));
	}

	private void PBNNDINJFMD(int JIIGOACEIKL)
	{
		GDOJKONLMMM();
	}

	private void Start()
	{
		PJLABIGIHAI();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
	}

	private void AFKOAAINHJJ(int JIIGOACEIKL)
	{
		BFBFNJCBOPK();
	}

	private void NOOFLHGHFDF()
	{
		MCIDICEHNFO(SeasonManager.PJMGHIMKFJL());
	}

	private void LPHJGHGMICJ(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void LFPGDGAKPBD()
	{
		GLEADBGEOCE();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FIGNNHNEOGL));
	}

	private void FOKPMCGOPGC()
	{
		JAIBGMJMEHC(SeasonManager.PJMGHIMKFJL());
	}

	private void GAFGINOFEPO()
	{
		AAJJCKCLAGN(SeasonManager.LPGPJPPLHKG());
	}

	private void ALGNCFCJLDJ(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)5 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void KDHLJKMKFMG()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(HMIIELFEHHD));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FICDIANCDHL));
	}

	private void KMEJBPOOBJK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(GLEADBGEOCE));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FFCCHAKNNPM));
	}

	private void FLOFJHNAIKP()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LKCGJOLFKFC));
		}
	}

	private void BIGFBGOMOBA()
	{
		NOOFLHGHFDF();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ALGNCFCJLDJ));
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
		}
	}

	private void KHLHACJEMCF()
	{
		LCIKONKPJJI(SeasonManager.KCJFCHNPIBJ());
	}

	private void HEACGABOLBP(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)7 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void MEAKJFEPKHF()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LPHJGHGMICJ));
		}
	}

	private void EIMIDCDEIDD()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BLDLEECENFF));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IIJKAPHMKGO));
	}

	private void PKDEOOOPHAM()
	{
		MHOEOAJAJOL(SeasonManager.KCJFCHNPIBJ());
	}

	private void JOIMGFPMKNI()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LKCGJOLFKFC));
		}
	}

	private void BLDLEECENFF()
	{
		PHAHIHKJIOG(SeasonManager.BLCGOEMGKGH());
	}

	private void FIGNNHNEOGL(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)7 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void PCEFNHADDIG()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(FIGNNHNEOGL));
		}
	}

	private void MHOEOAJAJOL(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)5 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void MAONIPONCOH()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
		}
	}

	private void BGLPLADNJGA()
	{
		BLNJKNPAKKG(SeasonManager.EEGJBDCBKFD());
	}

	private void FFCCHAKNNPM(int JIIGOACEIKL)
	{
		CKPDKOFJMCE();
	}

	private void IGBEKHCLKFD()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(EDGICPGDAKP));
		}
	}

	private void NGNKDGAFJFB()
	{
		ALGNCFCJLDJ(SeasonManager.EEGJBDCBKFD());
	}

	private void BGBFJPJLPMF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(HADEPOHAPMA));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IIJKAPHMKGO));
	}

	private void PCKOHAIPHFI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(BMOJKAAIMCP));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IIJKAPHMKGO));
	}

	private void PGABAEGKPIG()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(AOJAIKDOCFJ));
		}
	}

	private void HMLJKBEFAHA()
	{
		FJKBDHDBGEE(SeasonManager.EECEKHKAAIH);
	}

	private void GNGADDPBJDC()
	{
		BMIENGLCJLL();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(AOJAIKDOCFJ));
	}

	private void AHGAGFHKANL()
	{
		LMCJGPHIKPB(SeasonManager.LPGPJPPLHKG());
	}

	private void PKEABNKEDNL()
	{
		EDGICPGDAKP(SeasonManager.LPGPJPPLHKG());
	}

	private void PHAHIHKJIOG(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)6 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void OFPPKKHCHDK()
	{
		JAIBGMJMEHC(SeasonManager.EEGJBDCBKFD());
	}

	private void JAIBGMJMEHC(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)5 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void JKMFGDGBDDN()
	{
		PHAHIHKJIOG(SeasonManager.LPGPJPPLHKG());
	}

	private void KNFIDLBONFF()
	{
		BLNJKNPAKKG(SeasonManager.EEGJBDCBKFD());
	}

	private void EDGICPGDAKP(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)4 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 1; i < pairs.Length; i += 0)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void HIIPEIMMEIK()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
		}
	}

	private void PAGIAAKPDCE()
	{
		CKPDKOFJMCE();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(FEGEPGGFLIG));
	}

	private void BANAPOHEGGK()
	{
		EDGICPGDAKP(SeasonManager.ADEICKHEPFI());
	}

	private void MKLIAMJFHOF()
	{
		OJDBBJBCBCJ();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(EDGICPGDAKP));
	}

	private void EOGHJNGJFID()
	{
		HMIIELFEHHD();
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JAIBGMJMEHC));
	}

	private void COGECLBOPIG()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PJLABIGIHAI));
		}
	}

	private void KAPJJNFICFE(int JIIGOACEIKL)
	{
		JCHDOCFAMPG();
	}

	private void LADLGPKMPBP()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JOOGJANOAMN));
		}
	}

	private void PJLABIGIHAI(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Winter && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void MPGKCNOEKBH(int JIIGOACEIKL)
	{
		PKDEOOOPHAM();
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(PJLABIGIHAI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(KBGFJEMHMDJ));
	}

	private void MCIDICEHNFO(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == (Season)7 && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void LCIKONKPJJI(Season EECEKHKAAIH)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		GroundType groundType = WorldGrid.NCEHFMPBBAK(((Component)this).transform.position);
		if (EECEKHKAAIH == Season.Autumn && WorldGrid.OINMGKCIGEJ(((Component)this).transform.position, null))
		{
			spriteRenderer.sprite = snowSprite;
			return;
		}
		for (int i = 0; i < pairs.Length; i++)
		{
			if (pairs[i].groundType == groundType && pairs[i].season == EECEKHKAAIH)
			{
				spriteRenderer.sprite = pairs[i].sprite;
				return;
			}
		}
		spriteRenderer.sprite = defaultSprite;
	}

	private void GCKICDDKJLI()
	{
		LMCJGPHIKPB(SeasonManager.EEGJBDCBKFD());
	}

	private void HMANFAEHJCA()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(GLEADBGEOCE));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(KBGFJEMHMDJ));
	}

	private void PJLABIGIHAI()
	{
		PJLABIGIHAI(SeasonManager.EECEKHKAAIH);
	}

	private void HPBCPENEEDK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(GLEADBGEOCE));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(KBGFJEMHMDJ));
	}

	private void NAOBODGBECL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		Placeable obj = placeable;
		obj.WhileSelectedCallback = (Action)Delegate.Combine(obj.WhileSelectedCallback, new Action(PJLABIGIHAI));
		Placeable obj2 = placeable;
		obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(FICDIANCDHL));
	}

	private void FOJAHMIJJJM()
	{
		if (Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(LKCGJOLFKFC));
		}
	}
}
