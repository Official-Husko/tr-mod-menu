using System;
using UnityEngine;

public class ReplacePlaceableOnSeason : MonoBehaviour
{
	[SerializeField]
	private Placeable winterPrefab;

	[SerializeField]
	private Placeable springPrefab;

	[SerializeField]
	private Placeable placeable;

	[SerializeField]
	private GameObject[] winterOnlyObjects;

	[SerializeField]
	private Collider2D[] winterOnlyColliders;

	private void KJOJLHCDFPP()
	{
		MAIJMHNKJKN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
	}

	private void JNFHKLOJMJI(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	public void JKCINOIOKBP(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			HJCGJKFJDBN(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			DNFEKEHCCLH(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			LNEBDBBJPJE(JDDHJJOPHAL: true);
			break;
		case Season.Winter:
			ENGOLIJJMAN(JDDHJJOPHAL: true);
			break;
		}
	}

	private void PMMGKJNELGJ(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 1; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void NJFDKCMBMDH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void HFFFFAJFIPB()
	{
		OnSeasonChanged(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
	}

	private void AJMIGKDMPDD(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 1; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	public void INDLPKAHNIL(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			GBCAGIBBFJA(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			JOPLCJOFBIL(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			HJCGJKFJDBN(JDDHJJOPHAL: true);
			break;
		case Season.Winter:
			AJMIGKDMPDD(JDDHJJOPHAL: true);
			break;
		}
	}

	public void ADIKLLPLAOI(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			IKGMNGPEOLL(JDDHJJOPHAL: false);
			break;
		case Season.Summer:
			IKGMNGPEOLL(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			AJMIGKDMPDD(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			KECGFKBAIHM(JDDHJJOPHAL: false);
			break;
		}
	}

	private void PGABAEGKPIG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MMCCDEKAEEC));
		}
	}

	private void KACEOJDPLKB()
	{
		ECCAACPKDBC(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ADIKLLPLAOI));
	}

	private void NKDFMFFDGKC()
	{
		INDLPKAHNIL(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
	}

	private void KOBNHPKEJJD()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void EGACIHOKJLH()
	{
		MMCCDEKAEEC(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ECCAACPKDBC));
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(CHCIHNBDADN));
		}
	}

	private void GOCEMIBPDIP(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void PMGKACBABPN(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	public void CHCIHNBDADN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			HJCGJKFJDBN(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			LNEBDBBJPJE(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			PLMPCJPLDGF(JDDHJJOPHAL: true);
			break;
		case Season.Winter:
			PMGKACBABPN(JDDHJJOPHAL: true);
			break;
		}
	}

	private void IFHLGOMBACP()
	{
		HFDEFMHNHEH(SeasonManager.EEGJBDCBKFD());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
	}

	public void JEPHKKOBNMA(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			HJCGJKFJDBN(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			GOCEMIBPDIP(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			HJCGJKFJDBN(JDDHJJOPHAL: true);
			break;
		case Season.Winter:
			IKGMNGPEOLL(JDDHJJOPHAL: true);
			break;
		}
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
		}
	}

	private void NELBHAMPBPL()
	{
		MMCCDEKAEEC(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CHCIHNBDADN));
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
		}
	}

	private void ENGOLIJJMAN(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void IKGMNGPEOLL(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void EBNENBFLEKB()
	{
		MAIJMHNKJKN(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
	}

	private void GFDANOKBCCA(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 1; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	public void OnSeasonChanged(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			GOCEMIBPDIP(JDDHJJOPHAL: false);
			break;
		case Season.Summer:
			GOCEMIBPDIP(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			GOCEMIBPDIP(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			GOCEMIBPDIP(JDDHJJOPHAL: true);
			break;
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
		}
	}

	private void IAAGKLPMAMK()
	{
		ECCAACPKDBC(SeasonManager.PJMGHIMKFJL());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CHCIHNBDADN));
	}

	private void HJCGJKFJDBN(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void PLMPCJPLDGF(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void GBCAGIBBFJA(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
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

	private void OIBDBLCLACB()
	{
		ADIKLLPLAOI(SeasonManager.LPGPJPPLHKG());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MMCCDEKAEEC));
	}

	private void BNIKICAEIND()
	{
		ADIKLLPLAOI(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ADIKLLPLAOI));
	}

	private void CFIIEJDJFPB()
	{
		CHCIHNBDADN(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(CHCIHNBDADN));
	}

	private void ODKGLIDMCNP()
	{
		BJCBKEJNKBF(SeasonManager.NHKAHEEGEGF());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JEPHKKOBNMA));
	}

	private void MCMKNBIBDFF()
	{
		BJCBKEJNKBF(SeasonManager.KCJFCHNPIBJ());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
	}

	private void NCDBCDJKPLA()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	private void JLCFNPBBKEK()
	{
		CHCIHNBDADN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
	}

	private void GJMLHECPGBP()
	{
		CHCIHNBDADN(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
	}

	private void DNFEKEHCCLH(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 1; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void LNEBDBBJPJE(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 1; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void LJLKBKEADGI()
	{
		OJMJECJPODN(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
	}

	public void MMCCDEKAEEC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			GBCAGIBBFJA(JDDHJJOPHAL: false);
			break;
		case Season.Summer:
			GFDANOKBCCA(JDDHJJOPHAL: true);
			break;
		case Season.Autumn:
			DNFEKEHCCLH(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			GOCEMIBPDIP(JDDHJJOPHAL: true);
			break;
		}
	}

	public void MAIJMHNKJKN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			LNEBDBBJPJE(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			GOCEMIBPDIP(JDDHJJOPHAL: true);
			break;
		case Season.Autumn:
			DNFEKEHCCLH(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			BJHKIILGKMO(JDDHJJOPHAL: false);
			break;
		}
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(INDLPKAHNIL));
		}
	}

	public void ECCAACPKDBC(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			GBCAGIBBFJA(JDDHJJOPHAL: false);
			break;
		case Season.Summer:
			PMGKACBABPN(JDDHJJOPHAL: true);
			break;
		case Season.Autumn:
			GFDANOKBCCA(JDDHJJOPHAL: true);
			break;
		case Season.Winter:
			GBCAGIBBFJA(JDDHJJOPHAL: true);
			break;
		}
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(CHCIHNBDADN));
		}
	}

	private void GHPFCKGMLDA()
	{
		BJCBKEJNKBF(SeasonManager.BLCGOEMGKGH());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
	}

	private void JOGBCDIAGEK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JKCINOIOKBP));
		}
	}

	private void KECGFKBAIHM(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.ChangeSkin(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i += 0)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 1; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void PKFMLJGJKCP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(MMCCDEKAEEC));
		}
	}

	private void IKMPNICLPBM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(BJCBKEJNKBF));
		}
	}

	private void MFMMHDPGCBO()
	{
		OJMJECJPODN(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(MAIJMHNKJKN));
	}

	public void HFDEFMHNHEH(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			PLMPCJPLDGF(JDDHJJOPHAL: false);
			break;
		case Season.Summer:
			PMGKACBABPN(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			KECGFKBAIHM(JDDHJJOPHAL: true);
			break;
		case Season.Winter:
			LNEBDBBJPJE(JDDHJJOPHAL: true);
			break;
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(ADIKLLPLAOI));
		}
	}

	private void JOPLCJOFBIL(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex(), PDHJLCDFNCK: false);
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 0; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j++)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	private void DONGKOKMGMM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)SeasonManager.instance))
		{
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(HFDEFMHNHEH));
		}
	}

	public void OJMJECJPODN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			ENGOLIJJMAN(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			GOCEMIBPDIP(JDDHJJOPHAL: true);
			break;
		case Season.Autumn:
			LNEBDBBJPJE(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			AJMIGKDMPDD(JDDHJJOPHAL: false);
			break;
		}
	}

	private void BJHKIILGKMO(bool JDDHJJOPHAL)
	{
		if ((Object)(object)winterPrefab != (Object)null && winterPrefab.skins != null && winterPrefab.skins.Length != 0 && (Object)(object)springPrefab != (Object)null && springPrefab.skins != null && springPrefab.skins.Length != 0 && winterPrefab.skins.Length == springPrefab.skins.Length)
		{
			placeable.skins = (JDDHJJOPHAL ? winterPrefab.skins : springPrefab.skins);
			placeable.GKJEMMKNFBO(placeable.GetSkinIndex());
		}
		if ((Object)(object)placeable.sortingGroup != (Object)null && (Object)(object)winterPrefab.sortingGroup != (Object)null && (Object)(object)springPrefab.sortingGroup != (Object)null)
		{
			placeable.sortingGroup.sortingLayerID = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingLayerID : springPrefab.sortingGroup.sortingLayerID);
			placeable.sortingGroup.sortingOrder = (JDDHJJOPHAL ? winterPrefab.sortingGroup.sortingOrder : springPrefab.sortingGroup.sortingOrder);
		}
		if (winterOnlyObjects != null)
		{
			for (int i = 1; i < winterOnlyObjects.Length; i++)
			{
				winterOnlyObjects[i].SetActive(JDDHJJOPHAL);
			}
		}
		if (winterOnlyColliders != null)
		{
			for (int j = 0; j < winterOnlyColliders.Length; j += 0)
			{
				((Behaviour)winterOnlyColliders[j]).enabled = JDDHJJOPHAL;
			}
		}
	}

	public void BJCBKEJNKBF(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			ENGOLIJJMAN(JDDHJJOPHAL: false);
			break;
		case Season.Summer:
			HJCGJKFJDBN(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			JOPLCJOFBIL(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			AJMIGKDMPDD(JDDHJJOPHAL: false);
			break;
		}
	}

	public void JOBAGLFBDGN(Season EECEKHKAAIH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			GFDANOKBCCA(JDDHJJOPHAL: true);
			break;
		case Season.Summer:
			AJMIGKDMPDD(JDDHJJOPHAL: false);
			break;
		case Season.Autumn:
			PMGKACBABPN(JDDHJJOPHAL: false);
			break;
		case Season.Winter:
			GFDANOKBCCA(JDDHJJOPHAL: true);
			break;
		}
	}

	private void HBMDEHPHAPF()
	{
		OJMJECJPODN(SeasonManager.ADEICKHEPFI());
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(ADIKLLPLAOI));
	}

	private void Start()
	{
		OnSeasonChanged(SeasonManager.EECEKHKAAIH);
		SeasonManager instance = SeasonManager.instance;
		instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(OnSeasonChanged));
	}
}
