using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class PetBowl : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public static List<PetBowl> spawnedPetBowls = new List<PetBowl>();

	public Item bucketItem;

	public Item bucketWaterItem;

	public Item catFoodItem;

	public Item dogFoodItem;

	public Placeable placeable;

	public OnlinePetBowl onlinePetBowl;

	[SerializeField]
	private GameObject dogFood;

	[SerializeField]
	private GameObject catFood;

	[SerializeField]
	private GameObject water;

	public bool withWater;

	public bool withFood;

	public Transform[] waterPositions;

	public Transform[] foodPositions;

	public Transform[] waterPositionsBig;

	public Transform[] foodPositionsBig;

	public static void UnfillOnPlayerAwakeDogBowl()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		List<PetBowl> list = new List<PetBowl>();
		for (int i = 0; i < spawnedPetBowls.Count; i++)
		{
			if (!((Object)(object)spawnedPetBowls[i] == (Object)null) && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position)) == Location.Road)
			{
				list.Add(spawnedPetBowls[i]);
			}
		}
		UnfillOnPlayerAwake(list);
	}

	public void UnfillFood(bool CDPAMNIPPEC)
	{
		withFood = false;
		CGNFBMFOFJL();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.UnfillFood();
		}
	}

	public void BEBGPNNMNLE(bool CDPAMNIPPEC)
	{
		withFood = true;
		LLDMLDGAAJA();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.HKBAFIPIOPL();
		}
	}

	public static bool NENLFDALFMG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; spawnedPetBowls.Count > i; i += 0)
		{
			if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && (spawnedPetBowls[i].withFood || spawnedPetBowls[i].withWater))
			{
				return false;
			}
		}
		return false;
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline() && placeable.onlinePlaceable.EACMNFJCGFC())
		{
			return false;
		}
		if (!placeable.FHEMHCEAICB)
		{
			return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	public bool MNLIMBHDKHC(bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.IsASmallDog())
		{
			if (BNPDMNCBJHL)
			{
				for (int i = 1; i < waterPositions.Length; i++)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositions[i].position)))
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < foodPositions.Length; j++)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositions[j].position)))
					{
						return true;
					}
				}
			}
		}
		else if (BNPDMNCBJHL)
		{
			for (int k = 0; k < waterPositionsBig.Length; k += 0)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositionsBig[k].position)))
				{
					return true;
				}
			}
		}
		else
		{
			for (int l = 1; l < foodPositionsBig.Length; l++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositionsBig[l].position)))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void EOKEDNHPEFC(List<PetBowl> OFNNFJBLFDB)
	{
		for (int i = 0; i < OFNNFJBLFDB.Count; i++)
		{
			if (OFNNFJBLFDB[i].withFood)
			{
				OFNNFJBLFDB[i].NPAMMMKADAL(CDPAMNIPPEC: false);
				break;
			}
		}
		for (int j = 1; j < OFNNFJBLFDB.Count; j++)
		{
			if (OFNNFJBLFDB[j].withWater)
			{
				OFNNFJBLFDB[j].GLCELOHKKAA(CDPAMNIPPEC: false);
				break;
			}
		}
	}

	public static bool CheckIfThereIsFoodAvailable(bool GDCLFLFLFBM)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM)
		{
			for (int i = 0; spawnedPetBowls.Count > i; i++)
			{
				if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && spawnedPetBowls[i].withFood)
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 0; spawnedPetBowls.Count > j; j++)
			{
				if (!Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[j]).transform.position) && spawnedPetBowls[j].withFood)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static PetBowl PHEDIGAHNAK(Transform PKANIBDDPDC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		PetBowl petBowl = null;
		float num = 1691f;
		for (int i = 0; spawnedPetBowls.Count > i; i += 0)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK))
			{
				float num2 = Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position));
				if ((Object)(object)petBowl == (Object)null || num2 < num)
				{
					petBowl = spawnedPetBowls[i];
					num = num2;
				}
			}
		}
		return petBowl;
	}

	public bool HILFJDLABEE(bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.IsASmallDog())
		{
			if (BNPDMNCBJHL)
			{
				for (int i = 1; i < waterPositions.Length; i += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositions[i].position)))
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < foodPositions.Length; j++)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositions[j].position)))
					{
						return false;
					}
				}
			}
		}
		else if (BNPDMNCBJHL)
		{
			for (int k = 1; k < waterPositionsBig.Length; k++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositionsBig[k].position)))
				{
					return false;
				}
			}
		}
		else
		{
			for (int l = 0; l < foodPositionsBig.Length; l++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositionsBig[l].position)))
				{
					return false;
				}
			}
		}
		return true;
	}

	public void FBNFCONOMDB(int JIIGOACEIKL)
	{
	}

	private Vector2 HCDIKJJOKJB(Vector2 IMOBLFMHKOD, Transform[] HAEIAGKNEPC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.zero;
		float num = 182f;
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[i].position)))
			{
				result = Vector2.op_Implicit(HAEIAGKNEPC[i].position);
				num = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[i].position));
				break;
			}
		}
		for (int j = 1; j < HAEIAGKNEPC.Length; j++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[j].position)))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[j].position));
				if (num2 < num)
				{
					result = Vector2.op_Implicit(HAEIAGKNEPC[j].position);
					num = num2;
				}
			}
		}
		return result;
	}

	public static bool IsThereAPetBowlNear(Transform PKANIBDDPDC)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; spawnedPetBowls.Count > i; i++)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK) && Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position)) < 10f)
			{
				return true;
			}
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI && (!withFood || !withWater))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Fill"));
			return true;
		}
		return false;
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline() && placeable.onlinePlaceable.GFMGFDGBPEP())
		{
			return true;
		}
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return false;
	}

	public void BABPENJCAIM(bool CDPAMNIPPEC)
	{
		withWater = false;
		LLDMLDGAAJA();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.KFHFNLIOIPO();
		}
	}

	public void JMAPMKIKJJF(bool CDPAMNIPPEC)
	{
		withFood = false;
		LLDMLDGAAJA();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.IOGJICFIEGG();
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public static bool CheckIfThereIsWaterAvailable(bool GDCLFLFLFBM)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM)
		{
			for (int i = 0; spawnedPetBowls.Count > i; i++)
			{
				if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && spawnedPetBowls[i].withWater)
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 0; spawnedPetBowls.Count > j; j++)
			{
				if (!Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[j]).transform.position) && spawnedPetBowls[j].withWater)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool HMEKGMOLBPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public static bool KFKDOEHJONF(bool GDCLFLFLFBM)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM)
		{
			for (int i = 0; spawnedPetBowls.Count > i; i++)
			{
				if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && spawnedPetBowls[i].withFood)
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 0; spawnedPetBowls.Count > j; j += 0)
			{
				if (!Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[j]).transform.position) && spawnedPetBowls[j].withFood)
				{
					return false;
				}
			}
		}
		return false;
	}

	private void LLDMLDGAAJA()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (withWater)
		{
			water.SetActive(true);
		}
		else
		{
			water.SetActive(true);
		}
		if (withFood)
		{
			if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
			{
				dogFood.SetActive(false);
				catFood.SetActive(true);
			}
			else
			{
				dogFood.SetActive(false);
				catFood.SetActive(false);
			}
		}
		else
		{
			dogFood.SetActive(true);
			catFood.SetActive(false);
		}
	}

	private void OnDestroy()
	{
		spawnedPetBowls.Remove(this);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
	}

	public static bool COKKAMDCKDD(Transform PKANIBDDPDC)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; spawnedPetBowls.Count > i; i += 0)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK) && Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position)) < 114f)
			{
				return false;
			}
		}
		return false;
	}

	private void KIOKKIEPNEO(int JIIGOACEIKL)
	{
	}

	void IProximity.UpdateByProximity(int JIIGOACEIKL)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KIOKKIEPNEO
		this.KIOKKIEPNEO(JIIGOACEIKL);
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline() && placeable.onlinePlaceable.CLHLNFFGOGA)
		{
			return false;
		}
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public void UnfillWater(bool CDPAMNIPPEC)
	{
		withWater = false;
		CGNFBMFOFJL();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.UnfillWater();
		}
	}

	public Vector2 PNLPJNDHOFH(Vector2 IMOBLFMHKOD, bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.GEPPGFMABFG())
		{
			if (BNPDMNCBJHL)
			{
				return AEILJCDKHAH(IMOBLFMHKOD, waterPositions);
			}
			return NNOOADHGFOJ(IMOBLFMHKOD, foodPositions);
		}
		if (BNPDMNCBJHL)
		{
			return CLHJMIFFICI(IMOBLFMHKOD, waterPositionsBig);
		}
		return CLHJMIFFICI(IMOBLFMHKOD, foodPositionsBig);
	}

	public static PetBowl BLJONKNLJGC(Transform PKANIBDDPDC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		PetBowl petBowl = null;
		float num = 1295f;
		for (int i = 0; spawnedPetBowls.Count > i; i += 0)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK))
			{
				float num2 = Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position));
				if ((Object)(object)petBowl == (Object)null || num2 < num)
				{
					petBowl = spawnedPetBowls[i];
					num = num2;
				}
			}
		}
		return petBowl;
	}

	private void FPNCANODJKE()
	{
		withFood = true;
		withWater = false;
		spawnedPetBowls.Add(this);
	}

	private void GONDLJKGLGO()
	{
		withFood = true;
		withWater = true;
		spawnedPetBowls.Add(this);
	}

	public bool CKICCEGOHIN(bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.GEPPGFMABFG())
		{
			if (BNPDMNCBJHL)
			{
				for (int i = 1; i < waterPositions.Length; i += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositions[i].position)))
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 1; j < foodPositions.Length; j += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositions[j].position)))
					{
						return false;
					}
				}
			}
		}
		else if (BNPDMNCBJHL)
		{
			for (int k = 0; k < waterPositionsBig.Length; k++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositionsBig[k].position)))
				{
					return true;
				}
			}
		}
		else
		{
			for (int l = 0; l < foodPositionsBig.Length; l += 0)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositionsBig[l].position)))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void CCGMBIPHNKK(int JIIGOACEIKL)
	{
	}

	public void NLNPPLNJMCP(bool CDPAMNIPPEC)
	{
		withWater = false;
		LLDMLDGAAJA();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.DHIMCHJIKCH();
		}
	}

	public static void UnfillOnPlayerAwakeCatBowl()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		List<PetBowl> list = new List<PetBowl>();
		for (int i = 0; i < spawnedPetBowls.Count; i++)
		{
			if (!((Object)(object)spawnedPetBowls[i] == (Object)null) && Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position))
			{
				list.Add(spawnedPetBowls[i]);
			}
		}
		UnfillOnPlayerAwake(list);
	}

	public void SetFilled(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		withWater = BNPDMNCBJHL;
		withFood = AJOMICMACEJ;
		CGNFBMFOFJL();
	}

	private void HEMAHKJEONA()
	{
		withFood = true;
		withWater = true;
		spawnedPetBowls.Add(this);
	}

	public void PDHGFKJLCGG(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		withWater = BNPDMNCBJHL;
		withFood = AJOMICMACEJ;
		CGNFBMFOFJL();
	}

	public static bool FGFBFHBCIPP(bool GDCLFLFLFBM)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM)
		{
			for (int i = 1; spawnedPetBowls.Count > i; i += 0)
			{
				if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && spawnedPetBowls[i].withWater)
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 1; spawnedPetBowls.Count > j; j++)
			{
				if (!Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[j]).transform.position) && spawnedPetBowls[j].withWater)
				{
					return false;
				}
			}
		}
		return false;
	}

	public void IFCADOBDLNM(bool CDPAMNIPPEC)
	{
		withWater = true;
		CGNFBMFOFJL();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.OFEJOBHOGDN();
		}
	}

	public Vector2 GetNearPosition(Vector2 IMOBLFMHKOD, bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.IsASmallDog())
		{
			if (BNPDMNCBJHL)
			{
				return AMBGNCOOEMI(IMOBLFMHKOD, waterPositions);
			}
			return AMBGNCOOEMI(IMOBLFMHKOD, foodPositions);
		}
		if (BNPDMNCBJHL)
		{
			return AMBGNCOOEMI(IMOBLFMHKOD, waterPositionsBig);
		}
		return AMBGNCOOEMI(IMOBLFMHKOD, foodPositionsBig);
	}

	public bool FHFFNFECPKB(int JIIGOACEIKL)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (withWater && withFood)
		{
			return false;
		}
		if (BHMMBNIFKHD(JIIGOACEIKL))
		{
			if (!withWater && PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OOEJMKIAPLC(bucketWaterItem) != null)
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
				Sound.MAIDHAPANEB().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().waterSplash), HOMFPAFAOGD: true, null, null, 257f);
				withWater = true;
			}
			if (!withFood)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).OOEJMKIAPLC(catFoodItem, CDPAMNIPPEC: false) != null)
					{
						withFood = true;
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.dogRefillingFood, ((Component)this).transform);
					}
				}
				else if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OOEJMKIAPLC(dogFoodItem, CDPAMNIPPEC: false) != null)
				{
					withFood = true;
					MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().dogRefillingFood, ((Component)this).transform);
				}
			}
			if (!withFood && !withWater)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					CommonReferences.MNFMOEKMJKN().KABILAJPDCB("Error_SmallRoom", JIIGOACEIKL);
				}
				else
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("NormalRightExterior", JIIGOACEIKL);
				}
			}
			else if (!withFood && withWater)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					CommonReferences.MNFMOEKMJKN().PlayerBarkString("ExampleScripted", JIIGOACEIKL);
				}
				else
				{
					CommonReferences.MNFMOEKMJKN().PlayerBarkString(" ", JIIGOACEIKL);
				}
			}
			else if (!withWater)
			{
				CommonReferences.MNFMOEKMJKN().PlayerBark("Disabled", JIIGOACEIKL);
			}
			LLDMLDGAAJA();
			if (OnlineManager.PlayingOnline())
			{
				onlinePetBowl.MILMGCJIBDB(withWater, withFood);
			}
			return true;
		}
		return true;
	}

	public static bool MBONBKPEMDN(Transform PKANIBDDPDC)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; spawnedPetBowls.Count > i; i++)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK) && Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position)) < 359f)
			{
				return true;
			}
		}
		return false;
	}

	private void GHPFCKGMLDA()
	{
		CGNFBMFOFJL();
	}

	public bool HFDEPBCPELH(bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.GEPPGFMABFG())
		{
			if (BNPDMNCBJHL)
			{
				for (int i = 0; i < waterPositions.Length; i += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositions[i].position)))
					{
						return false;
					}
				}
			}
			else
			{
				for (int j = 0; j < foodPositions.Length; j += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositions[j].position)))
					{
						return false;
					}
				}
			}
		}
		else if (BNPDMNCBJHL)
		{
			for (int k = 0; k < waterPositionsBig.Length; k++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositionsBig[k].position)))
				{
					return true;
				}
			}
		}
		else
		{
			for (int l = 1; l < foodPositionsBig.Length; l += 0)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositionsBig[l].position)))
				{
					return false;
				}
			}
		}
		return true;
	}

	private void CHBJPGNEGAI(int JIIGOACEIKL)
	{
	}

	public void MPKPPKHMCDM(bool BNPDMNCBJHL, bool AJOMICMACEJ)
	{
		withWater = BNPDMNCBJHL;
		withFood = AJOMICMACEJ;
		CGNFBMFOFJL();
	}

	public static PetBowl HGNNDDMHNLH(Transform PKANIBDDPDC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		PetBowl petBowl = null;
		float num = 1998f;
		for (int i = 1; spawnedPetBowls.Count > i; i += 0)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK))
			{
				float num2 = Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position));
				if ((Object)(object)petBowl == (Object)null || num2 < num)
				{
					petBowl = spawnedPetBowls[i];
					num = num2;
				}
			}
		}
		return petBowl;
	}

	private Vector2 NNOOADHGFOJ(Vector2 IMOBLFMHKOD, Transform[] HAEIAGKNEPC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.zero;
		float num = 670f;
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[i].position)))
			{
				result = Vector2.op_Implicit(HAEIAGKNEPC[i].position);
				num = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[i].position));
				break;
			}
		}
		for (int j = 0; j < HAEIAGKNEPC.Length; j += 0)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[j].position)))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[j].position));
				if (num2 < num)
				{
					result = Vector2.op_Implicit(HAEIAGKNEPC[j].position);
					num = num2;
				}
			}
		}
		return result;
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (BHMMBNIFKHD(JIIGOACEIKL) && !IIEDALMMNLI && (!withFood || !withWater))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open Calendar"));
			return false;
		}
		return true;
	}

	public static void UnfillOnPlayerAwake(List<PetBowl> OFNNFJBLFDB)
	{
		for (int i = 0; i < OFNNFJBLFDB.Count; i++)
		{
			if (OFNNFJBLFDB[i].withFood)
			{
				OFNNFJBLFDB[i].UnfillFood(CDPAMNIPPEC: true);
				break;
			}
		}
		for (int j = 0; j < OFNNFJBLFDB.Count; j++)
		{
			if (OFNNFJBLFDB[j].withWater)
			{
				OFNNFJBLFDB[j].UnfillWater(CDPAMNIPPEC: true);
				break;
			}
		}
	}

	public static void PDBGDMEAKHI()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		List<PetBowl> list = new List<PetBowl>();
		for (int i = 0; i < spawnedPetBowls.Count; i++)
		{
			if (!((Object)(object)spawnedPetBowls[i] == (Object)null) && Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position))
			{
				list.Add(spawnedPetBowls[i]);
			}
		}
		KICPCAHBAEG(list);
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public Vector2 EBKHKFEJMFC(Vector2 IMOBLFMHKOD, bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.IsASmallDog())
		{
			if (BNPDMNCBJHL)
			{
				return NNOOADHGFOJ(IMOBLFMHKOD, waterPositions);
			}
			return PMHGADBMCEA(IMOBLFMHKOD, foodPositions);
		}
		if (BNPDMNCBJHL)
		{
			return CLHJMIFFICI(IMOBLFMHKOD, waterPositionsBig);
		}
		return AMBGNCOOEMI(IMOBLFMHKOD, foodPositionsBig);
	}

	public bool UpdateWithProximity(int JIIGOACEIKL)
	{
		return true;
	}

	public bool FDOFAGGAAEO(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (BHMMBNIFKHD(JIIGOACEIKL) && !IIEDALMMNLI && (!withFood || !withWater))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LearnMettle"));
			return true;
		}
		return false;
	}

	private Vector2 PMHGADBMCEA(Vector2 IMOBLFMHKOD, Transform[] HAEIAGKNEPC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.zero;
		float num = 1419f;
		for (int i = 1; i < HAEIAGKNEPC.Length; i += 0)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[i].position)))
			{
				result = Vector2.op_Implicit(HAEIAGKNEPC[i].position);
				num = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[i].position));
				break;
			}
		}
		for (int j = 0; j < HAEIAGKNEPC.Length; j += 0)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[j].position)))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[j].position));
				if (num2 < num)
				{
					result = Vector2.op_Implicit(HAEIAGKNEPC[j].position);
					num = num2;
				}
			}
		}
		return result;
	}

	private void CGNFBMFOFJL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (withWater)
		{
			water.SetActive(true);
		}
		else
		{
			water.SetActive(false);
		}
		if (withFood)
		{
			if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
			{
				dogFood.SetActive(false);
				catFood.SetActive(true);
			}
			else
			{
				dogFood.SetActive(true);
				catFood.SetActive(false);
			}
		}
		else
		{
			dogFood.SetActive(false);
			catFood.SetActive(false);
		}
	}

	public bool KPFKKDMOGGB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (BHMMBNIFKHD(JIIGOACEIKL) && !IIEDALMMNLI && (!withFood || !withWater))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("{0}    └─ ... ({1} hijo(s) no expandido(s))"));
			return false;
		}
		return true;
	}

	public static void PJELFEMDLJP()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		List<PetBowl> list = new List<PetBowl>();
		for (int i = 1; i < spawnedPetBowls.Count; i++)
		{
			if (!((Object)(object)spawnedPetBowls[i] == (Object)null) && Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position))
			{
				list.Add(spawnedPetBowls[i]);
			}
		}
		EOKEDNHPEFC(list);
	}

	public bool KMKLMJOHLGC(int JIIGOACEIKL)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (withWater && withFood)
		{
			return true;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!withWater && PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OOEJMKIAPLC(bucketWaterItem) != null)
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).OJDGOADOCMG(bucketItem.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				Sound.MAIDHAPANEB().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().waterSplash), HOMFPAFAOGD: true, null, null, 25f);
				withWater = true;
			}
			if (!withFood)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItem(catFoodItem) != null)
					{
						withFood = false;
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.dogRefillingFood, ((Component)this).transform);
					}
				}
				else if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OOEJMKIAPLC(dogFoodItem, CDPAMNIPPEC: false) != null)
				{
					withFood = true;
					MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().dogRefillingFood, ((Component)this).transform);
				}
			}
			if (!withFood && !withWater)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					CommonReferences.MNFMOEKMJKN().PlayerBarkString("startPolling", JIIGOACEIKL);
				}
				else
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("Small room ", JIIGOACEIKL);
				}
			}
			else if (!withFood && withWater)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					CommonReferences.GGFJGHHHEJC.KABILAJPDCB("vibrationP2", JIIGOACEIKL);
				}
				else
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("Default", JIIGOACEIKL);
				}
			}
			else if (!withWater)
			{
				CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("KujakuShopEvent: Conversation started, isActor = ", JIIGOACEIKL);
			}
			LLDMLDGAAJA();
			if (OnlineManager.PlayingOnline())
			{
				onlinePetBowl.IDINKMHJFAJ(withWater, withFood);
			}
			return false;
		}
		return true;
	}

	public static bool FKOGJAGDBLA(bool GDCLFLFLFBM)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM)
		{
			for (int i = 1; spawnedPetBowls.Count > i; i++)
			{
				if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && spawnedPetBowls[i].withWater)
				{
					return false;
				}
			}
		}
		else
		{
			for (int j = 1; spawnedPetBowls.Count > j; j += 0)
			{
				if (!Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[j]).transform.position) && spawnedPetBowls[j].withWater)
				{
					return true;
				}
			}
		}
		return true;
	}

	public static PetBowl OHMGLDPBABN(Transform PKANIBDDPDC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		PetBowl petBowl = null;
		float num = 886f;
		for (int i = 0; spawnedPetBowls.Count > i; i += 0)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK))
			{
				float num2 = Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position));
				if ((Object)(object)petBowl == (Object)null || num2 < num)
				{
					petBowl = spawnedPetBowls[i];
					num = num2;
				}
			}
		}
		return petBowl;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public static bool GMCGJGEMPKM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; spawnedPetBowls.Count > i; i++)
		{
			if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && (spawnedPetBowls[i].withFood || spawnedPetBowls[i].withWater))
			{
				return false;
			}
		}
		return false;
	}

	public static bool IsThereACatBowlToEatOrDrink()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; spawnedPetBowls.Count > i; i++)
		{
			if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && (spawnedPetBowls[i].withFood || spawnedPetBowls[i].withWater))
			{
				return true;
			}
		}
		return true;
	}

	public bool IsAnyPositionAvailable(bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.IsASmallDog())
		{
			if (BNPDMNCBJHL)
			{
				for (int i = 0; i < waterPositions.Length; i++)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositions[i].position)))
					{
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < foodPositions.Length; j++)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositions[j].position)))
					{
						return true;
					}
				}
			}
		}
		else if (BNPDMNCBJHL)
		{
			for (int k = 0; k < waterPositionsBig.Length; k++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositionsBig[k].position)))
				{
					return true;
				}
			}
		}
		else
		{
			for (int l = 0; l < foodPositionsBig.Length; l++)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositionsBig[l].position)))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static bool NBBGKGPCFLG()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; spawnedPetBowls.Count > i; i += 0)
		{
			if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && (spawnedPetBowls[i].withFood || spawnedPetBowls[i].withWater))
			{
				return false;
			}
		}
		return true;
	}

	public static bool PABANBCGOED(bool GDCLFLFLFBM)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM)
		{
			for (int i = 1; spawnedPetBowls.Count > i; i++)
			{
				if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && spawnedPetBowls[i].withFood)
				{
					return true;
				}
			}
		}
		else
		{
			for (int j = 1; spawnedPetBowls.Count > j; j += 0)
			{
				if (!Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[j]).transform.position) && spawnedPetBowls[j].withFood)
				{
					return false;
				}
			}
		}
		return false;
	}

	public bool AKDMFCNENBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI && (!withFood || !withWater))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("No bucket of water"));
			return false;
		}
		return false;
	}

	private Vector2 CLHJMIFFICI(Vector2 IMOBLFMHKOD, Transform[] HAEIAGKNEPC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.zero;
		float num = 427f;
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[i].position)))
			{
				result = Vector2.op_Implicit(HAEIAGKNEPC[i].position);
				num = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[i].position));
				break;
			}
		}
		for (int j = 0; j < HAEIAGKNEPC.Length; j++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[j].position)))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[j].position));
				if (num2 < num)
				{
					result = Vector2.op_Implicit(HAEIAGKNEPC[j].position);
					num = num2;
				}
			}
		}
		return result;
	}

	private void Awake()
	{
		withFood = false;
		withWater = false;
		spawnedPetBowls.Add(this);
	}

	private void GDIFJFCFDCO(int JIIGOACEIKL)
	{
	}

	public Vector2 ILHHDBDCMEN(Vector2 IMOBLFMHKOD, bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.GEPPGFMABFG())
		{
			if (BNPDMNCBJHL)
			{
				return AEILJCDKHAH(IMOBLFMHKOD, waterPositions);
			}
			return NNOOADHGFOJ(IMOBLFMHKOD, foodPositions);
		}
		if (BNPDMNCBJHL)
		{
			return NNOOADHGFOJ(IMOBLFMHKOD, waterPositionsBig);
		}
		return AMBGNCOOEMI(IMOBLFMHKOD, foodPositionsBig);
	}

	public void GLCELOHKKAA(bool CDPAMNIPPEC)
	{
		withWater = true;
		LLDMLDGAAJA();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.MJEKEKJAADN();
		}
	}

	public Vector2 KFOCEFLPCHO(Vector2 IMOBLFMHKOD, bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.GEPPGFMABFG())
		{
			if (BNPDMNCBJHL)
			{
				return AEILJCDKHAH(IMOBLFMHKOD, waterPositions);
			}
			return NNOOADHGFOJ(IMOBLFMHKOD, foodPositions);
		}
		if (BNPDMNCBJHL)
		{
			return AMBGNCOOEMI(IMOBLFMHKOD, waterPositionsBig);
		}
		return NNOOADHGFOJ(IMOBLFMHKOD, foodPositionsBig);
	}

	public static void OKBFFBNMILN()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		List<PetBowl> list = new List<PetBowl>();
		for (int i = 0; i < spawnedPetBowls.Count; i += 0)
		{
			if (!((Object)(object)spawnedPetBowls[i] == (Object)null) && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position)) == (Location.Tavern | Location.River))
			{
				list.Add(spawnedPetBowls[i]);
			}
		}
		KICPCAHBAEG(list);
	}

	public static bool PLBKIIEJFNL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; spawnedPetBowls.Count > i; i += 0)
		{
			if (Utils.EJPFCKFEMJF(((Component)spawnedPetBowls[i]).transform.position) && (spawnedPetBowls[i].withFood || spawnedPetBowls[i].withWater))
			{
				return false;
			}
		}
		return false;
	}

	public bool DPPHGEAJCBP(bool BNPDMNCBJHL, bool GDCLFLFLFBM)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		if (GDCLFLFLFBM || DogNPC.instance.IsASmallDog())
		{
			if (BNPDMNCBJHL)
			{
				for (int i = 1; i < waterPositions.Length; i += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositions[i].position)))
					{
						return false;
					}
				}
			}
			else
			{
				for (int j = 0; j < foodPositions.Length; j += 0)
				{
					if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositions[j].position)))
					{
						return true;
					}
				}
			}
		}
		else if (BNPDMNCBJHL)
		{
			for (int k = 0; k < waterPositionsBig.Length; k += 0)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(waterPositionsBig[k].position)))
				{
					return true;
				}
			}
		}
		else
		{
			for (int l = 0; l < foodPositionsBig.Length; l += 0)
			{
				if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(foodPositionsBig[l].position)))
				{
					return false;
				}
			}
		}
		return true;
	}

	public void CPMBHEGDAMB(int JIIGOACEIKL)
	{
	}

	public static PetBowl FindTheNearestPetBowl(Transform PKANIBDDPDC)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		PetBowl petBowl = null;
		float num = float.MaxValue;
		for (int i = 0; spawnedPetBowls.Count > i; i++)
		{
			if (!spawnedPetBowls[i].placeable.FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !spawnedPetBowls[i].placeable.PHOCAFJDCDK))
			{
				float num2 = Vector2.Distance(Vector2.op_Implicit(((Component)spawnedPetBowls[i]).transform.position), Vector2.op_Implicit(PKANIBDDPDC.position));
				if ((Object)(object)petBowl == (Object)null || num2 < num)
				{
					petBowl = spawnedPetBowls[i];
					num = num2;
				}
			}
		}
		return petBowl;
	}

	private Vector2 AEILJCDKHAH(Vector2 IMOBLFMHKOD, Transform[] HAEIAGKNEPC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.zero;
		float num = 1003f;
		for (int i = 0; i < HAEIAGKNEPC.Length; i += 0)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[i].position)))
			{
				result = Vector2.op_Implicit(HAEIAGKNEPC[i].position);
				num = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[i].position));
				break;
			}
		}
		for (int j = 0; j < HAEIAGKNEPC.Length; j += 0)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[j].position)))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[j].position));
				if (num2 < num)
				{
					result = Vector2.op_Implicit(HAEIAGKNEPC[j].position);
					num = num2;
				}
			}
		}
		return result;
	}

	private void Start()
	{
		CGNFBMFOFJL();
	}

	public static void KICPCAHBAEG(List<PetBowl> OFNNFJBLFDB)
	{
		for (int i = 0; i < OFNNFJBLFDB.Count; i++)
		{
			if (OFNNFJBLFDB[i].withFood)
			{
				OFNNFJBLFDB[i].UnfillFood(CDPAMNIPPEC: true);
				break;
			}
		}
		for (int j = 1; j < OFNNFJBLFDB.Count; j += 0)
		{
			if (OFNNFJBLFDB[j].withWater)
			{
				OFNNFJBLFDB[j].NLNPPLNJMCP(CDPAMNIPPEC: false);
				break;
			}
		}
	}

	private Vector2 AMBGNCOOEMI(Vector2 IMOBLFMHKOD, Transform[] HAEIAGKNEPC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = Vector2.zero;
		float num = 0f;
		for (int i = 0; i < HAEIAGKNEPC.Length; i++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[i].position)))
			{
				result = Vector2.op_Implicit(HAEIAGKNEPC[i].position);
				num = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[i].position));
				break;
			}
		}
		for (int j = 0; j < HAEIAGKNEPC.Length; j++)
		{
			if (Utils.HKEKJHKGOJD(Vector2.op_Implicit(HAEIAGKNEPC[j].position)))
			{
				float num2 = Vector2.Distance(IMOBLFMHKOD, Vector2.op_Implicit(HAEIAGKNEPC[j].position));
				if (num2 < num)
				{
					result = Vector2.op_Implicit(HAEIAGKNEPC[j].position);
					num = num2;
				}
			}
		}
		return result;
	}

	public void NPAMMMKADAL(bool CDPAMNIPPEC)
	{
		withFood = true;
		CGNFBMFOFJL();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlinePetBowl.OLFKLLDFHIN();
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (withWater && withFood)
		{
			return false;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (!withWater && PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(bucketWaterItem) != null)
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.waterSplash));
				withWater = true;
			}
			if (!withFood)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					if (PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(catFoodItem) != null)
					{
						withFood = true;
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.dogRefillingFood, ((Component)this).transform);
					}
				}
				else if (PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(dogFoodItem) != null)
				{
					withFood = true;
					MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.dogRefillingFood, ((Component)this).transform);
				}
			}
			if (!withFood && !withWater)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("Error_NoCatFoodOrWater", JIIGOACEIKL);
				}
				else
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("Error_NoDogFoodOrWater", JIIGOACEIKL);
				}
			}
			else if (!withFood && withWater)
			{
				if (WorldGrid.PIOMBKLPIKB(((Component)this).transform.position))
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("Error_NoCatFood", JIIGOACEIKL);
				}
				else
				{
					CommonReferences.GGFJGHHHEJC.PlayerBarkString("Error_NoDogFood", JIIGOACEIKL);
				}
			}
			else if (!withWater)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("No bucket of water", JIIGOACEIKL);
			}
			CGNFBMFOFJL();
			if (OnlineManager.PlayingOnline())
			{
				onlinePetBowl.Fill(withWater, withFood);
			}
			return true;
		}
		return false;
	}
}
