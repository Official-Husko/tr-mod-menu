using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Barn : FarmBuilding
{
	public static Barn instance;

	public IconMaterial style;

	public AnimalSpace[] animalSpaces;

	[SerializeField]
	private GameObject[] toActivateWithLevel;

	public bool buzzThere;

	public SpriteRenderer[] wallSpriteRenderers;

	public SpriteRenderer[] detailSpriteRenderers;

	public GameObject firstAndSecondImprovement;

	public GameObject thirdImprovement;

	public GameObject cobertizo;

	public GameObject window;

	public TravelZone travelZone;

	public BarnBell barnBell;

	private OnlineBarn KBNFPCBNMGK
	{
		get
		{
			if (!((Object)(object)placeable.onlinePlaceable != (Object)null))
			{
				return null;
			}
			return placeable.onlinePlaceable as OnlineBarn;
		}
	}

	public bool CanToggle()
	{
		return barnBell.CanToggle();
	}

	protected override void JKMBDADNOCD()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!IsBuilt())
		{
			if (base.EONJGMONIOM == 0 && !buzzThere)
			{
				buzzThere = true;
			}
			else
			{
				base.DPDMICLMEOD = Mathf.Min(_constructionPhase + 1, constructionPhases.Length);
			}
			UpdateSprite();
		}
		if (IsBuilt())
		{
			travelZone.SetPosition(((Component)travelZone).transform.position);
		}
	}

	protected override void HFMANGJKOMA()
	{
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			animalSpaces[i].WasteFoodUnit();
		}
	}

	public void BAHJCDHEKJB(bool AHJOOLKOBIL)
	{
		for (int i = 1; i < animalSpaces.Length; i += 0)
		{
			if ((Object)(object)animalSpaces[i].FFAPKJDBMLL() != (Object)null)
			{
				animalSpaces[i].NHDHHMBJIIH().pathNodesRegion = (AHJOOLKOBIL ? CommonReferences.MNFMOEKMJKN().allBarnScenes[base.EONJGMONIOM].pathNodesRegion : null);
			}
		}
	}

	public void BLNHDFLMCMI()
	{
		MainUI.ShowErrorText(1, LocalisationSystem.Get("Talk"), 1660f);
		open = true;
	}

	public override void UpdateSprite()
	{
		base.UpdateSprite();
		for (int i = 0; i < toActivateWithLevel.Length; i++)
		{
			toActivateWithLevel[i].SetActive(i == base.EONJGMONIOM);
		}
		if (IsBuilt())
		{
			for (int j = 0; j < wallSpriteRenderers.Length; j++)
			{
				((Renderer)wallSpriteRenderers[j]).material = style.material;
			}
			for (int k = 0; k < detailSpriteRenderers.Length; k++)
			{
				((Renderer)detailSpriteRenderers[k]).material = style.detailMaterial;
			}
			firstAndSecondImprovement.SetActive(base.EONJGMONIOM == 0 || base.EONJGMONIOM == 1);
			thirdImprovement.SetActive(base.EONJGMONIOM == 2);
			cobertizo.SetActive(base.EONJGMONIOM == 1);
			window.SetActive(base.EONJGMONIOM == 1);
		}
		if (OnlineManager.MasterOrOffline())
		{
			placeable.itemSpace.UpdatePathNodes();
		}
	}

	public override List<AnimalNPC> GetAllAnimals()
	{
		List<AnimalNPC> list = new List<AnimalNPC>();
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			if ((Object)(object)animalSpaces[i].DHJHEALFPJN != (Object)null)
			{
				list.Add(animalSpaces[i].DHJHEALFPJN);
			}
		}
		return list;
	}

	public void GIBIGCPOGMO(bool BGKCHMNJBLJ = true)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendEntryAllAnimals();
		}
		if (IsOpen())
		{
			barnBell.IKIOFHCOJLJ(KDCAODJIEMD: false);
		}
		Open(FDHFCIGEBIE: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			List<AnimalNPC> allAnimals = GetAllAnimals();
			for (int i = 1; i < allAnimals.Count; i++)
			{
				((Component)allAnimals[i]).transform.position = allAnimals[i].animalSpace.defaultPosition.position;
				allAnimals[i].WalkAround();
			}
		}
	}

	private void PJLALJAMOAG()
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			float num;
			float num2;
			if (open)
			{
				num = Weather.HowBadIsWeather();
				num2 = allAnimals[i].CMOBLFMDNKF.probabilityToSick * 4f;
			}
			else
			{
				num = 1f;
				num2 = allAnimals[i].CMOBLFMDNKF.probabilityToSick;
			}
			float num3 = Random.Range(0f, 100f / num);
			if (allAnimals[i].CanSick() && num3 < num2)
			{
				allAnimals[i].Sick(CDPAMNIPPEC: true);
			}
			allAnimals[i].WasteVitamin();
		}
	}

	protected override void LKGAOEHMKKO()
	{
		if (((Component)buzzVariants[0]).gameObject.activeInHierarchy)
		{
			buzzVariants[0].Saw();
		}
		if (((Component)buzzVariants[1]).gameObject.activeInHierarchy)
		{
			buzzVariants[1].buzzAnimation.SetBool(FarmBuilding.FNCOABKNAHE, EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[2]).gameObject.activeInHierarchy)
		{
			buzzVariants[2].buzzAnimation.SetBool(FarmBuilding.PCLMNDLNINP, EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[3]).gameObject.activeInHierarchy)
		{
			buzzVariants[3].buzzAnimation.SetBool(FarmBuilding.AMDGJDFDMNP, EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[4]).gameObject.activeInHierarchy)
		{
			buzzVariants[4].buzzAnimation.SetBool(FarmBuilding.PCLMNDLNINP, EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[5]).gameObject.activeInHierarchy)
		{
			buzzVariants[5].buzzAnimation.SetBool(FarmBuilding.AMDGJDFDMNP, EGFGNGJGBOP: true);
		}
		if (((Component)buzzVariants[6]).gameObject.activeInHierarchy)
		{
			buzzVariants[6].buzzAnimation.SetBool(FarmBuilding.FNCOABKNAHE, EGFGNGJGBOP: true);
		}
	}

	public void IGPDGBDDIFF(bool AHJOOLKOBIL)
	{
		for (int i = 0; i < animalSpaces.Length; i += 0)
		{
			if ((Object)(object)animalSpaces[i].DHJHEALFPJN != (Object)null)
			{
				animalSpaces[i].FMECIKJOIEN().pathNodesRegion = (AHJOOLKOBIL ? CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].pathNodesRegion : null);
			}
		}
	}

	public bool AAIGLAHDNBG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return Utils.NANFHBIPIIF(TravelZonesManager.EKDNJDJHONF().ECFDFECLDFK(Location.River, Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior).JDCIIGFOPJA(), 2, 97).Count >= -119;
	}

	private void DEHDLJODJCO()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[0].cornerFrom.position;
		Vector3 position2 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[0].cornerTo.position;
		Vector3 position3 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].downLeftPosition.transform.position;
		Vector3 position4 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].downLeftPosition.transform.position;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && ((Component)currentPlaceables[i]).transform.position.x > position.x && ((Component)currentPlaceables[i]).transform.position.x < position2.x && ((Component)currentPlaceables[i]).transform.position.y > position.y && ((Component)currentPlaceables[i]).transform.position.y < position2.y)
			{
				currentPlaceables[i].ChangePosition(((Component)currentPlaceables[i]).transform.position + (position4 - position3), BGKCHMNJBLJ: false);
			}
		}
	}

	public void OKCEDJIHDKP()
	{
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			animalSpaces[i].CJFEOLELCJB();
		}
	}

	public void CEMINEJCLMM(bool AHJOOLKOBIL)
	{
		for (int i = 1; i < animalSpaces.Length; i += 0)
		{
			if ((Object)(object)animalSpaces[i].ACMJMOPBCJM() != (Object)null)
			{
				animalSpaces[i].PGJDHDIEEJI().pathNodesRegion = (AHJOOLKOBIL ? CommonReferences.MNFMOEKMJKN().allBarnScenes[base.EONJGMONIOM].pathNodesRegion : null);
			}
		}
	}

	private void APKKHLGHNGH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = CommonReferences.MNFMOEKMJKN().allBarnScenes[base.EONJGMONIOM].zonesToCalculate[0].cornerFrom.position;
		Vector3 position2 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].zonesToCalculate[1].cornerTo.position;
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.KNOKBLFFNLM().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && ((Component)currentPlaceables[i]).transform.position.x > position.x && ((Component)currentPlaceables[i]).transform.position.x < position2.x && ((Component)currentPlaceables[i]).transform.position.y > position.y && ((Component)currentPlaceables[i]).transform.position.y < position2.y)
			{
				list.Add(currentPlaceables[i]);
			}
		}
		for (int j = 1; j < list.Count; j++)
		{
			list[j].PickUp(Vector3.zero, LHLHJCDKNHA: false);
		}
	}

	private void MMKJAHCFKGN()
	{
		if (Application.isEditor)
		{
			Debug.Log((object)"Left");
		}
		for (int i = 0; i < animalSpaces.Length; i += 0)
		{
			AnimalNPC animalNPC = animalSpaces[i].LGCDJFKHCCF();
			if ((Object)(object)animalNPC != (Object)null)
			{
				animalSpaces[i].DFEIFHFPHJI(CDPAMNIPPEC: false);
				Utils.BLPDAEHPOBA(((Component)animalNPC).gameObject);
			}
		}
	}

	public void IKFAIJGCKNN(bool NODEDANJBFL = true)
	{
		bool flag = !open;
		if (OnlineManager.PlayingOnline())
		{
			if (NODEDANJBFL)
			{
				OnlineObjectsManager.instance.RequestToggleOpenBarn();
				return;
			}
		}
		else if (flag && !ILODGJPKEDJ())
		{
			ShowAnimalsNeedMoreSpaceText();
		}
		barnBell.FNCEDKIKCPD(KDCAODJIEMD: false);
		Open(flag);
	}

	private void BHOMAAOIEMC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			LKFLNMABNEC();
			ICGNFGKNHJA();
		}
	}

	private void NEOICNJNKNL()
	{
		Initialize();
	}

	private void AFCGOHFNKEP()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[1].cornerFrom.position;
		Vector3 position2 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[0].cornerTo.position;
		Vector3 position3 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].downLeftPosition.transform.position;
		Vector3 position4 = CommonReferences.MNFMOEKMJKN().allBarnScenes[base.EONJGMONIOM].downLeftPosition.transform.position;
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && ((Component)currentPlaceables[i]).transform.position.x > position.x && ((Component)currentPlaceables[i]).transform.position.x < position2.x && ((Component)currentPlaceables[i]).transform.position.y > position.y && ((Component)currentPlaceables[i]).transform.position.y < position2.y)
			{
				currentPlaceables[i].GJKFDALCPMM(((Component)currentPlaceables[i]).transform.position + (position4 - position3));
			}
		}
	}

	public void PutAnimalsToSleep()
	{
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			animalSpaces[i].PutAnimalToSleepIfPosible();
		}
	}

	protected override void NALJNIOAIAG()
	{
		base.NALJNIOAIAG();
		if (!IsBuilt() && base.DPDMICLMEOD == 0)
		{
			((Component)buzzVariants[0]).gameObject.SetActive(buzzThere);
		}
		LKGAOEHMKKO();
	}

	[SpecialName]
	private OnlineBarn BFHGDIEIPHD()
	{
		if (!((Object)(object)placeable.onlinePlaceable != (Object)null))
		{
			return null;
		}
		return placeable.onlinePlaceable as OnlineBarn;
	}

	public bool AnimalsHaveSpaceToLeave()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return Utils.NANFHBIPIIF(TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.BarnInterior).GetCentrePosition(), 3, 105).Count >= 100;
	}

	private void LKFLNMABNEC()
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 1; i < allAnimals.Count; i++)
		{
			float num;
			float num2;
			if (open)
			{
				num = Weather.HowBadIsWeather();
				num2 = allAnimals[i].CMOBLFMDNKF.probabilityToSick * 810f;
			}
			else
			{
				num = 1587f;
				num2 = allAnimals[i].CMOBLFMDNKF.probabilityToSick;
			}
			float num3 = Random.Range(370f, 916f / num);
			if (allAnimals[i].CanSick() && num3 < num2)
			{
				allAnimals[i].Sick(CDPAMNIPPEC: false);
			}
			allAnimals[i].WasteVitamin();
		}
	}

	public override void UpdateAnimalsState()
	{
		int num = 0;
		for (int i = 0; i < waterFeeders.Length; i++)
		{
			num += waterFeeders[i].GetCurrentAmount();
		}
		int num2 = 0;
		for (int j = 0; j < animalSpaces.Length; j++)
		{
			if ((Object)(object)animalSpaces[j].DHJHEALFPJN != (Object)null)
			{
				animalSpaces[j].DHJHEALFPJN.hasFood = animalSpaces[j].foodFeeder.GetCurrentAmount() > 0;
				animalSpaces[j].DHJHEALFPJN.hasWater = num2 < num;
				num2++;
			}
		}
	}

	private void NCFIAJJMKBF(AnimalSpace[] GNKIHPMCAJH)
	{
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			animalSpaces[i].foodFeeder.farmBuilding = this;
		}
		for (int j = 0; j < GNKIHPMCAJH.Length; j++)
		{
			animalSpaces[j].foodFeeder.SetFeederInfo(GNKIHPMCAJH[j].foodFeeder);
		}
		AnimalFeeder[] array = waterFeeders;
		AnimalFeeder[] array2 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].waterFeeders;
		waterFeeders = array2;
		for (int k = 0; k < waterFeeders.Length; k++)
		{
			waterFeeders[k].farmBuilding = this;
		}
		for (int l = 0; l < array.Length; l++)
		{
			(waterFeeders[l] as AnimalFeederWater).SetFeederInfo(array[l] as AnimalFeederWater);
		}
	}

	public override void Demolish(int JIIGOACEIKL)
	{
		PLNGLJOECAO();
		GBNLIJNDICC();
		foreach (KeyValuePair<int, BarnTilemapScene> allBarnScene in CommonReferences.GGFJGHHHEJC.allBarnScenes)
		{
			for (int i = 0; i < allBarnScene.Value.animalSpaces.Length; i++)
			{
				allBarnScene.Value.animalSpaces[i].foodFeeder.ResetState();
			}
			for (int j = 0; j < allBarnScene.Value.waterFeeders.Length; j++)
			{
				allBarnScene.Value.waterFeeders[j].ResetState();
			}
		}
		for (int k = 0; k < animalSpaces.Length; k++)
		{
			animalSpaces[k].DeassignAnimal(CDPAMNIPPEC: true);
		}
		base.Demolish(JIIGOACEIKL);
	}

	private void PLNGLJOECAO()
	{
		if (Application.isEditor)
		{
			Debug.Log((object)"Destroying all animals");
		}
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			AnimalNPC animalAssigned = animalSpaces[i].DHJHEALFPJN;
			if ((Object)(object)animalAssigned != (Object)null)
			{
				animalSpaces[i].DeassignAnimal(CDPAMNIPPEC: false);
				Utils.BLPDAEHPOBA(((Component)animalAssigned).gameObject);
			}
		}
	}

	public void SetStyle(IconMaterial ONLCBJNNJMB)
	{
		style = ONLCBJNNJMB;
		UpdateSprite();
	}

	[SpecialName]
	private OnlineBarn EJPDJDOEGDL()
	{
		if (!((Object)(object)placeable.onlinePlaceable != (Object)null))
		{
			return null;
		}
		return placeable.onlinePlaceable as OnlineBarn;
	}

	public void Initialize()
	{
		animalSpaces = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].animalSpaces;
		AnimalFeeder[] array = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].waterFeeders;
		waterFeeders = array;
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			animalSpaces[i].foodFeeder.farmBuilding = this;
		}
		for (int j = 0; j < waterFeeders.Length; j++)
		{
			waterFeeders[j].farmBuilding = this;
		}
		instance = this;
	}

	public bool ILODGJPKEDJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return Utils.NANFHBIPIIF(TravelZonesManager.DCAEBALADIM().ECFDFECLDFK(Location.Road, ~(Location.Tavern | Location.BarnInterior)).GetCentrePosition(), 0, -62).Count >= 31;
	}

	private void GFMLOBCIELP(AnimalSpace[] GNKIHPMCAJH)
	{
		for (int i = 1; i < animalSpaces.Length; i += 0)
		{
			animalSpaces[i].foodFeeder.farmBuilding = this;
		}
		for (int j = 1; j < GNKIHPMCAJH.Length; j += 0)
		{
			animalSpaces[j].foodFeeder.LLFLNGJGHAB(GNKIHPMCAJH[j].foodFeeder);
		}
		AnimalFeeder[] array = waterFeeders;
		AnimalFeeder[] array2 = CommonReferences.MNFMOEKMJKN().allBarnScenes[base.EONJGMONIOM].waterFeeders;
		waterFeeders = array2;
		for (int k = 1; k < waterFeeders.Length; k += 0)
		{
			waterFeeders[k].farmBuilding = this;
		}
		for (int l = 0; l < array.Length; l++)
		{
			(waterFeeders[l] as AnimalFeederWater).EPNDJCGGPLE(array[l] as AnimalFeederWater);
		}
	}

	public void JLPJCGMJINB(IconMaterial ONLCBJNNJMB)
	{
		style = ONLCBJNNJMB;
		UpdateSprite();
	}

	private void GBNLIJNDICC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].zonesToCalculate[0].cornerFrom.position;
		Vector3 position2 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].zonesToCalculate[0].cornerTo.position;
		List<Placeable> list = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && ((Component)currentPlaceables[i]).transform.position.x > position.x && ((Component)currentPlaceables[i]).transform.position.x < position2.x && ((Component)currentPlaceables[i]).transform.position.y > position.y && ((Component)currentPlaceables[i]).transform.position.y < position2.y)
			{
				list.Add(currentPlaceables[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j].PickUp(Vector3.zero, LHLHJCDKNHA: false, IBCOKMGFPKB: false);
		}
	}

	private void KCCMHCIFMIC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			PJLALJAMOAG();
			ICGNFGKNHJA();
		}
	}

	public void CJGDOILGCNC(IconMaterial ONLCBJNNJMB)
	{
		style = ONLCBJNNJMB;
		UpdateSprite();
	}

	public void EntryAllAnimals(bool BGKCHMNJBLJ = true)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendEntryAllAnimals();
		}
		if (IsOpen())
		{
			barnBell.ToggleSign(KDCAODJIEMD: false);
		}
		Open(FDHFCIGEBIE: false);
		if (OnlineManager.MasterOrOffline())
		{
			List<AnimalNPC> allAnimals = GetAllAnimals();
			for (int i = 0; i < allAnimals.Count; i++)
			{
				((Component)allAnimals[i]).transform.position = allAnimals[i].animalSpace.defaultPosition.position;
				allAnimals[i].WalkAround();
			}
		}
	}

	private void ICGNFGKNHJA()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			allAnimals[i].dontAwake = false;
			if (allAnimals[i].behaviour.GetBool("Sleep"))
			{
				if (WorldGrid.HJPCBBGHPDA(((Component)allAnimals[i]).transform.position) == Location.BarnInterior)
				{
					animalSpaces[i].WakeUpAnimal();
				}
				else if (!allAnimals[i].isSick)
				{
					allAnimals[i].AwakeAnimal();
				}
			}
		}
	}

	public void AJPKAGHDCCJ()
	{
		MainUI.DJCKALOHJFM(1, LocalisationSystem.Get("OnlinePlayer"), 581f);
		open = false;
	}

	private void BOMOLAANGHO(int JIIGOACEIKL)
	{
		if (AnimalNPC.IsTimeToSleep() && !open)
		{
			AssignAnimalsPathRegion(AHJOOLKOBIL: true);
			PutAnimalsToSleep();
		}
	}

	protected override void Start()
	{
		base.Start();
		Weather weather = Weather.instance;
		weather.OnWeatherDetermined = (Action)Delegate.Combine(weather.OnWeatherDetermined, new Action(KCCMHCIFMIC));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(BOMOLAANGHO));
	}

	public void LKILKPDKCNI(bool BGKCHMNJBLJ = true)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendEntryAllAnimals();
		}
		if (IsOpen())
		{
			barnBell.JLDADMHPLCH(KDCAODJIEMD: false);
		}
		Open(FDHFCIGEBIE: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			List<AnimalNPC> allAnimals = GetAllAnimals();
			for (int i = 0; i < allAnimals.Count; i += 0)
			{
				((Component)allAnimals[i]).transform.position = allAnimals[i].animalSpace.defaultPosition.position;
				allAnimals[i].WalkAround();
			}
		}
	}

	public void ShowAnimalsNeedMoreSpaceText()
	{
		MainUI.ShowErrorText(1, LocalisationSystem.Get("AnimalsNeedMoreSpace"));
		open = false;
	}

	private void MDKPDMCHBBO()
	{
		AnimalSpace[] array = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].animalSpaces;
		animalSpaces = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].animalSpaces;
		for (int i = 0; i < array.Length; i++)
		{
			AnimalNPC animalAssigned = array[i].DHJHEALFPJN;
			if ((Object)(object)animalAssigned != (Object)null)
			{
				animalSpaces[i].AssignAnimal(animalAssigned, CDPAMNIPPEC: false);
			}
		}
		NCFIAJJMKBF(array);
	}

	public void HKKINCHIIPB(bool NODEDANJBFL = true)
	{
		bool flag = !open;
		if (OnlineManager.PlayingOnline())
		{
			if (NODEDANJBFL)
			{
				OnlineObjectsManager.instance.NLLEGHKAIJH();
				return;
			}
		}
		else if (flag && !AAIGLAHDNBG())
		{
			AJPKAGHDCCJ();
		}
		barnBell.NFHELMHFNAB(KDCAODJIEMD: false);
		Open(flag);
	}

	private void OJBJPNJPCBN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			PJLALJAMOAG();
			ICGNFGKNHJA();
		}
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
			if (!GameManager.isLoading)
			{
				Weather weather = Weather.instance;
				weather.OnWeatherDetermined = (Action)Delegate.Remove(weather.OnWeatherDetermined, new Action(KCCMHCIFMIC));
			}
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(BOMOLAANGHO));
			}
		}
	}

	public bool IFICIHMKJHA()
	{
		return barnBell.CanToggle();
	}

	protected override void IEFIPPPLCEL()
	{
		base.IEFIPPPLCEL();
		buzzThere = false;
		MDKPDMCHBBO();
		DEHDLJODJCO();
		MHIAAONKLOC();
		if (OnlineManager.MasterOrOffline())
		{
			AssignAnimalsPathRegion(!open);
			for (int i = 0; i < animalSpaces.Length; i++)
			{
				if ((Object)(object)animalSpaces[i].DHJHEALFPJN != (Object)null)
				{
					animalSpaces[i].DHJHEALFPJN.WalkAround();
				}
			}
		}
		UpdateSprite();
	}

	public void ToggleOpen(bool NODEDANJBFL = true)
	{
		bool flag = !open;
		if (OnlineManager.PlayingOnline())
		{
			if (NODEDANJBFL)
			{
				OnlineObjectsManager.instance.RequestToggleOpenBarn();
				return;
			}
		}
		else if (flag && !AnimalsHaveSpaceToLeave())
		{
			ShowAnimalsNeedMoreSpaceText();
		}
		barnBell.ToggleSign();
		Open(flag);
	}

	public void Open(bool FDHFCIGEBIE)
	{
		open = FDHFCIGEBIE;
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		AssignAnimalsPathRegion(!open);
		if (open)
		{
			for (int i = 0; i < animalSpaces.Length; i++)
			{
				if ((Object)(object)animalSpaces[i].DHJHEALFPJN != (Object)null)
				{
					if (animalSpaces[i].DHJHEALFPJN.sleeping)
					{
						animalSpaces[i].WakeUpAnimal();
					}
					animalSpaces[i].DHJHEALFPJN.WalkAroundWithRandomDelay();
				}
			}
			return;
		}
		for (int j = 0; j < animalSpaces.Length; j++)
		{
			if ((Object)(object)animalSpaces[j].DHJHEALFPJN != (Object)null)
			{
				if (animalSpaces[j].DHJHEALFPJN.sleeping)
				{
					animalSpaces[j].WakeUpAnimal();
				}
				else
				{
					animalSpaces[j].DHJHEALFPJN.WalkAroundWithRandomDelay();
				}
			}
		}
	}

	private void FALOGDDGCDD()
	{
		List<AnimalNPC> allAnimals = GetAllAnimals();
		for (int i = 0; i < allAnimals.Count; i++)
		{
			float num;
			float num2;
			if (open)
			{
				num = Weather.HowBadIsWeather();
				num2 = allAnimals[i].CMOBLFMDNKF.probabilityToSick * 666f;
			}
			else
			{
				num = 76f;
				num2 = allAnimals[i].CMOBLFMDNKF.probabilityToSick;
			}
			float num3 = Random.Range(258f, 557f / num);
			if (allAnimals[i].CanSick() && num3 < num2)
			{
				allAnimals[i].Sick(CDPAMNIPPEC: false);
			}
			allAnimals[i].WasteVitamin();
		}
	}

	private void MHIAAONKLOC()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[0].cornerFrom.position;
		Vector3 position2 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[0].cornerTo.position;
		Vector3 position3 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].downLeftPosition.transform.position;
		Vector3 position4 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].downLeftPosition.transform.position;
		DroppedItem[] array = Object.FindObjectsOfType<DroppedItem>();
		foreach (DroppedItem droppedItem in array)
		{
			if (((Component)droppedItem).transform.position.x > position.x && ((Component)droppedItem).transform.position.x < position2.x && ((Component)droppedItem).transform.position.y > position.y && ((Component)droppedItem).transform.position.y < position2.y)
			{
				Transform transform = ((Component)droppedItem).transform;
				transform.position += position4 - position3;
			}
		}
	}

	public void BOJLJHOGMBC(bool BGKCHMNJBLJ = true)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendEntryAllAnimals();
		}
		if (IsOpen())
		{
			barnBell.IKIOFHCOJLJ(KDCAODJIEMD: false);
		}
		Open(FDHFCIGEBIE: false);
		if (OnlineManager.MasterOrOffline())
		{
			List<AnimalNPC> allAnimals = GetAllAnimals();
			for (int i = 1; i < allAnimals.Count; i += 0)
			{
				((Component)allAnimals[i]).transform.position = allAnimals[i].animalSpace.defaultPosition.position;
				allAnimals[i].WalkAround();
			}
		}
	}

	public void AssignAnimalsPathRegion(bool AHJOOLKOBIL)
	{
		for (int i = 0; i < animalSpaces.Length; i++)
		{
			if ((Object)(object)animalSpaces[i].DHJHEALFPJN != (Object)null)
			{
				animalSpaces[i].DHJHEALFPJN.pathNodesRegion = (AHJOOLKOBIL ? CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].pathNodesRegion : null);
			}
		}
	}

	public void HOKDKHHJBMF(bool AHJOOLKOBIL)
	{
		for (int i = 1; i < animalSpaces.Length; i += 0)
		{
			if ((Object)(object)animalSpaces[i].FFAPKJDBMLL() != (Object)null)
			{
				animalSpaces[i].LGCDJFKHCCF().pathNodesRegion = (AHJOOLKOBIL ? CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].pathNodesRegion : null);
			}
		}
	}

	[SpecialName]
	private OnlineBarn OEBFLIOGIGN()
	{
		if (!((Object)(object)placeable.onlinePlaceable != (Object)null))
		{
			return null;
		}
		return placeable.onlinePlaceable as OnlineBarn;
	}

	private void DBJGAEBBFPJ()
	{
		if (Application.isEditor)
		{
			Debug.Log((object)"Items/item_description_1057");
		}
		for (int i = 1; i < animalSpaces.Length; i++)
		{
			AnimalNPC animalAssigned = animalSpaces[i].DHJHEALFPJN;
			if ((Object)(object)animalAssigned != (Object)null)
			{
				animalSpaces[i].DeassignAnimal(CDPAMNIPPEC: true);
				Utils.BLPDAEHPOBA(((Component)animalAssigned).gameObject);
			}
		}
	}

	private void GEIJKKOAOLJ()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].zonesToCalculate[0].cornerFrom.position;
		Vector3 position2 = CommonReferences.MNFMOEKMJKN().allBarnScenes[base.EONJGMONIOM - 0].zonesToCalculate[1].cornerTo.position;
		Vector3 position3 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM - 1].downLeftPosition.transform.position;
		Vector3 position4 = CommonReferences.GGFJGHHHEJC.allBarnScenes[base.EONJGMONIOM].downLeftPosition.transform.position;
		List<Placeable> currentPlaceables = PlaceablesManager.PDECKLKPKCG().currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && ((Component)currentPlaceables[i]).transform.position.x > position.x && ((Component)currentPlaceables[i]).transform.position.x < position2.x && ((Component)currentPlaceables[i]).transform.position.y > position.y && ((Component)currentPlaceables[i]).transform.position.y < position2.y)
			{
				currentPlaceables[i].ChangePosition(((Component)currentPlaceables[i]).transform.position + (position4 - position3));
			}
		}
	}

	private void Awake()
	{
		Initialize();
	}
}
