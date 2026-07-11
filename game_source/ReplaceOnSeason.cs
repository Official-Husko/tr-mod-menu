using System;
using UnityEngine;

public class ReplaceOnSeason : MonoBehaviour
{
	public Placeable placeable;

	public Herb herb;

	public ReplaceOnSeasonInfo[] replaceInfo;

	[SerializeField]
	private ReplaceSpriteOnly[] seasonSprites;

	[SerializeField]
	private ReplaceSpriteOnly[] flowerSeasonSprites;

	[SerializeField]
	private SpriteRenderer spriteToChange;

	private void GHPFCKGMLDA()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HONACKDAJPA));
		NJBLNHKMJFF(SeasonManager.EEGJBDCBKFD());
	}

	private void AKPLLNELLJK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(NBDGCFOMDPL));
		}
	}

	public void ChangeSpriteOnly(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Autumn && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Winter && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void FOBDDFCGLJL(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Winter && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Autumn && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(AAGOJCJEHNA));
		}
	}

	public void AIHJLOMGHKA(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 0; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.HPFFBGFBAJN() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				BDGLOBHNCEO(flowerSeasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			if (!herb.BOPFODDMKIP() && seasonSprites != null && seasonSprites.Length != 0)
			{
				LMILEGBMDKL(seasonSprites, herb.EKNAINLHBCD(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.BDEHCLCDLNI());
					break;
				}
			}
		}
	}

	public void POAACMKFINL(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)4 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)7 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void KKMGEPFMLBO(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.PHPMAEFGBBD(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.HPFFBGFBAJN() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				BDGLOBHNCEO(flowerSeasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				HGHNNPKBEGB(seasonSprites, herb.CLHILLJLNCN(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.HLLCPKFLDIN());
					break;
				}
			}
		}
	}

	private void HNEGFBCKIIJ()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KDOODAINKPB));
		PMOAEOGGODC(SeasonManager.EECEKHKAAIH);
	}

	public void PKPLBLMLCMP(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.LCBHOOCOKMF && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				BJJLGGPFIHC(flowerSeasonSprites, herb.HLLCPKFLDIN(), EECEKHKAAIH);
			}
			if (!herb.HPFFBGFBAJN() && seasonSprites != null && seasonSprites.Length != 0)
			{
				EAEFECMOPFG(seasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.NNAICGLPODL(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.KPACAMGGFJD());
					break;
				}
			}
		}
	}

	private void FOHGHCPODBJ()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KKMGEPFMLBO));
		BLJKFNAFCGA(SeasonManager.BLCGOEMGKGH());
	}

	public void NJBLNHKMJFF(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.HPFFBGFBAJN() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				MNNOKIMFOFH(flowerSeasonSprites, herb.CLHILLJLNCN(), EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				NKNNNCHKLGM(seasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.GNLPNBAKOAD(obj.possibleSprites, herb.BDEHCLCDLNI());
					break;
				}
			}
		}
	}

	public void AIFMKDGFNMF(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)6 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Autumn && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void NKNNNCHKLGM(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)4 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)6 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void FKONEIPMAFH(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.FNPHCNBNMFG() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				LNIKFKGENPN(flowerSeasonSprites, herb.EKNAINLHBCD(), EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				BJJLGGPFIHC(seasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.DBBGAMOIPBP(obj.possibleSprites, herb.PDBFPFFOILD());
					break;
				}
			}
		}
	}

	public void CEHCMKGHKPN(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)4 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void Replace(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 0; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.GetPlayerNum(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.LCBHOOCOKMF && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				ChangeSpriteOnly(flowerSeasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				ChangeSpriteOnly(seasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.PHMPGHEBNON);
					break;
				}
			}
		}
	}

	public void ECHFAPADAEA(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.PHPMAEFGBBD(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.FNPHCNBNMFG() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				POAACMKFINL(flowerSeasonSprites, herb.BCNFECMEGOE(), EECEKHKAAIH);
			}
			if (!herb.FNPHCNBNMFG() && seasonSprites != null && seasonSprites.Length != 0)
			{
				POAACMKFINL(seasonSprites, herb.BDEHCLCDLNI(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.GNLPNBAKOAD(obj.possibleSprites, herb.BLCBKJEMBAP());
					break;
				}
			}
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JIMCBOJHDDE));
		}
	}

	public void KDOODAINKPB(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.LCBHOOCOKMF && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				ANOAAGJGINP(flowerSeasonSprites, herb.CLHILLJLNCN(), EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				KAPIGMLEOOP(seasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.DBBGAMOIPBP(obj.possibleSprites, herb.CLHILLJLNCN());
					break;
				}
			}
		}
	}

	private void PKBHEKHOAAA()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KKMGEPFMLBO));
		NCFMPHHPIMB(SeasonManager.KCJFCHNPIBJ());
	}

	public void ADLDKCFCGCO(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void JEGFOOJGGDK(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)8 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void LNIKFKGENPN(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)7 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)6 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void HONACKDAJPA(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.PHPMAEFGBBD(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.LCBHOOCOKMF && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				ADLDKCFCGCO(flowerSeasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			if (!herb.HPFFBGFBAJN() && seasonSprites != null && seasonSprites.Length != 0)
			{
				FOBDDFCGLJL(seasonSprites, herb.BDEHCLCDLNI(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.NNAICGLPODL(replaceInfo[j].replacePrefab);
					obj.DBBGAMOIPBP(obj.possibleSprites, herb.PDBFPFFOILD());
					break;
				}
			}
		}
	}

	public void ANOAAGJGINP(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)7 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void PAOPJMFNEJF(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 0; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.IKIBJJAMDCP() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				BJJLGGPFIHC(flowerSeasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			if (!herb.HPFFBGFBAJN() && seasonSprites != null && seasonSprites.Length != 0)
			{
				EAEFECMOPFG(seasonSprites, herb.BCNFECMEGOE(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.DBBGAMOIPBP(obj.possibleSprites, herb.CLHILLJLNCN());
					break;
				}
			}
		}
	}

	public void NCFMPHHPIMB(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.FNPHCNBNMFG() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				BDGLOBHNCEO(flowerSeasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				BJJLGGPFIHC(seasonSprites, herb.PHMPGHEBNON, EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.GNLPNBAKOAD(obj.possibleSprites, herb.KPACAMGGFJD());
					break;
				}
			}
		}
	}

	public void NBDGCFOMDPL(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.GetPlayerNum(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.BOPFODDMKIP() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				NKNNNCHKLGM(flowerSeasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				ANOAAGJGINP(seasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.LPDIPFMKKBC(obj.possibleSprites, herb.HLLCPKFLDIN());
					break;
				}
			}
		}
	}

	public void ONKKNFCNFPB(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.BOPFODDMKIP() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				AIFMKDGFNMF(flowerSeasonSprites, herb.BDEHCLCDLNI(), EECEKHKAAIH);
			}
			if (!herb.FNPHCNBNMFG() && seasonSprites != null && seasonSprites.Length != 0)
			{
				FOBDDFCGLJL(seasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.NNAICGLPODL(replaceInfo[j].replacePrefab);
					obj.LPDIPFMKKBC(obj.possibleSprites, herb.CLHILLJLNCN());
					break;
				}
			}
		}
	}

	private void HHMBCKCNPPN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PMOAEOGGODC));
		}
	}

	public void FACIALNINHG(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.GetPlayerNum(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.BOPFODDMKIP() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				FEADFHEMGPJ(flowerSeasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			if (!herb.BOPFODDMKIP() && seasonSprites != null && seasonSprites.Length != 0)
			{
				ADLDKCFCGCO(seasonSprites, herb.PDBFPFFOILD(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.BIOEDLEFBML(replaceInfo[j].replacePrefab);
					obj.DBBGAMOIPBP(obj.possibleSprites, herb.BLCBKJEMBAP());
					break;
				}
			}
		}
	}

	private void OLDDEAJMHNI()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECHFAPADAEA));
		KKMGEPFMLBO(SeasonManager.EEGJBDCBKFD());
	}

	public void EAEFECMOPFG(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)4 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(Replace));
		}
	}

	private void HOFKJPBBLGP()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KEJJLPDMCOK));
		CMFBLFOLFLL(SeasonManager.EEGJBDCBKFD());
	}

	private void JHBBABPAJJC()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(KKMGEPFMLBO));
		KKMGEPFMLBO(SeasonManager.EEGJBDCBKFD());
	}

	private void FGFGCADFFBC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PMOAEOGGODC));
		}
	}

	public void CMFBLFOLFLL(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 0; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.GetPlayerNum(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.BOPFODDMKIP() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				BDGLOBHNCEO(flowerSeasonSprites, herb.CLHILLJLNCN(), EECEKHKAAIH);
			}
			if (!herb.FNPHCNBNMFG() && seasonSprites != null && seasonSprites.Length != 0)
			{
				LNIKFKGENPN(seasonSprites, herb.PDBFPFFOILD(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.NNAICGLPODL(replaceInfo[j].replacePrefab);
					obj.GNLPNBAKOAD(obj.possibleSprites, herb.HLLCPKFLDIN());
					break;
				}
			}
		}
	}

	private void CFIIEJDJFPB()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ONKKNFCNFPB));
		FKONEIPMAFH(SeasonManager.EEGJBDCBKFD());
	}

	public void BLJKFNAFCGA(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.FNPHCNBNMFG() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				MNNOKIMFOFH(flowerSeasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			if (!herb.BOPFODDMKIP() && seasonSprites != null && seasonSprites.Length != 0)
			{
				HGHNNPKBEGB(seasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.LPDIPFMKKBC(obj.possibleSprites, herb.PDBFPFFOILD());
					break;
				}
			}
		}
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(KKMGEPFMLBO));
		}
	}

	private void GNGADDPBJDC()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(NCFMPHHPIMB));
		NJBLNHKMJFF(SeasonManager.KCJFCHNPIBJ());
	}

	public void IANNNPLLIBH(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ECHFAPADAEA));
		}
	}

	public void CDNJNCDBBBJ(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void IMIONHLAKIH()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HONACKDAJPA));
		NCFMPHHPIMB(SeasonManager.NHKAHEEGEGF());
	}

	public void FEADFHEMGPJ(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void KAPIGMLEOOP(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Autumn && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void HLHHDNGOGNI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(NJBLNHKMJFF));
		}
	}

	public void DNHEDBJLGIC(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)6 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)6 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void JIMCBOJHDDE(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PGMPPMPBCLO(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.HPFFBGFBAJN() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				FOBDDFCGLJL(flowerSeasonSprites, herb.BDEHCLCDLNI(), EECEKHKAAIH);
			}
			if (!herb.HPFFBGFBAJN() && seasonSprites != null && seasonSprites.Length != 0)
			{
				DNHEDBJLGIC(seasonSprites, herb.PDBFPFFOILD(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j++)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.KPACAMGGFJD());
					break;
				}
			}
		}
	}

	public void LGEPMBACAIO(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)7 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void BNIKICAEIND()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ONKKNFCNFPB));
		PAOPJMFNEJF(SeasonManager.LPGPJPPLHKG());
	}

	public void PMOAEOGGODC(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i++)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PHPMAEFGBBD(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.IKIBJJAMDCP() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				IANNNPLLIBH(flowerSeasonSprites, herb.KPACAMGGFJD(), EECEKHKAAIH);
			}
			if (!herb.LCBHOOCOKMF && seasonSprites != null && seasonSprites.Length != 0)
			{
				BDGLOBHNCEO(seasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.ReplaceHerb(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.PDBFPFFOILD());
					break;
				}
			}
		}
	}

	public void LMILEGBMDKL(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)4 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Autumn && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void HGHNNPKBEGB(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == (Season)8 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void BDGLOBHNCEO(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)5 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	private void MFMMHDPGCBO()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BLJKFNAFCGA));
		NBDGCFOMDPL(SeasonManager.BLCGOEMGKGH());
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(Replace));
		}
	}

	private void Start()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(Replace));
		Replace(SeasonManager.EECEKHKAAIH);
	}

	private void KACEOJDPLKB()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECHFAPADAEA));
		Replace(SeasonManager.PJMGHIMKFJL());
	}

	private void BGENEAOILOF()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(BLJKFNAFCGA));
		FACIALNINHG(SeasonManager.EECEKHKAAIH);
	}

	private void EGACIHOKJLH()
	{
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CMFBLFOLFLL));
		Replace(SeasonManager.NHKAHEEGEGF());
	}

	public void AAGOJCJEHNA(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 1; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex());
					if (placeable.FHEMHCEAICB)
					{
						component.OEFLFKLLJHF(placeable.PHPMAEFGBBD(), KLGOCJMGKFO: true);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.HPFFBGFBAJN() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				ADLDKCFCGCO(flowerSeasonSprites, herb.EKNAINLHBCD(), EECEKHKAAIH);
			}
			if (!herb.HPFFBGFBAJN() && seasonSprites != null && seasonSprites.Length != 0)
			{
				CEHCMKGHKPN(seasonSprites, herb.HLLCPKFLDIN(), EECEKHKAAIH);
			}
			for (int j = 0; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.BIOEDLEFBML(replaceInfo[j].replacePrefab);
					obj.SetCurrentHerb(obj.possibleSprites, herb.PDBFPFFOILD());
					break;
				}
			}
		}
	}

	public void KEJJLPDMCOK(Season EECEKHKAAIH)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)placeable))
		{
			for (int i = 0; i < replaceInfo.Length; i += 0)
			{
				if (replaceInfo[i].season == EECEKHKAAIH)
				{
					Placeable component = Object.Instantiate<GameObject>(replaceInfo[i].replacePrefab, ((Component)this).transform.position, Quaternion.identity, ((Component)this).transform.parent).GetComponent<Placeable>();
					component.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
					if (placeable.FHEMHCEAICB)
					{
						component.Action(placeable.GetPlayerNum(), KLGOCJMGKFO: false);
					}
					Utils.BLPDAEHPOBA(((Component)this).gameObject);
					break;
				}
			}
		}
		else
		{
			if (!Object.op_Implicit((Object)(object)herb))
			{
				return;
			}
			if (herb.HPFFBGFBAJN() && flowerSeasonSprites != null && flowerSeasonSprites.Length != 0)
			{
				FOBDDFCGLJL(flowerSeasonSprites, herb.BLCBKJEMBAP(), EECEKHKAAIH);
			}
			if (!herb.IKIBJJAMDCP() && seasonSprites != null && seasonSprites.Length != 0)
			{
				ADLDKCFCGCO(seasonSprites, herb.CLHILLJLNCN(), EECEKHKAAIH);
			}
			for (int j = 1; j < replaceInfo.Length; j += 0)
			{
				if (replaceInfo[j].season == EECEKHKAAIH)
				{
					Herb obj = herb.DCFJBNFBDNG(replaceInfo[j].replacePrefab);
					obj.LPDIPFMKKBC(obj.possibleSprites, herb.PDBFPFFOILD());
					break;
				}
			}
		}
	}

	public void BJJLGGPFIHC(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == Season.Summer && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}

	public void MNNOKIMFOFH(ReplaceSpriteOnly[] IFPDPIPEGMP, int PHMPGHEBNON, Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].springSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].springSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].summerSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].summerSprite;
		}
		if (EECEKHKAAIH == Season.Spring && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].autumnSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].autumnSprite;
		}
		if (EECEKHKAAIH == (Season)8 && (Object)(object)IFPDPIPEGMP[PHMPGHEBNON].winterSprite != (Object)null)
		{
			spriteToChange.sprite = IFPDPIPEGMP[PHMPGHEBNON].winterSprite;
		}
	}
}
