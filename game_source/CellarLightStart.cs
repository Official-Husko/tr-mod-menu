using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CellarLightStart : MonoBehaviour
{
	public Light2D light2D;

	[SerializeField]
	private NightStart nightStart;

	[SerializeField]
	private Placeable placeable;

	private void FGFGCADFFBC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(HPGGFPEOPGJ));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(JDOKHDEBCPH));
			}
		}
	}

	private void INJNMCCGFIF()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			OKIDBNKLIMA(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void BKOJOMIEMJF(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"\n\n<color=#A95A00>");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.FPAGIHHJBBK(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void IDODLLIMEMO()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			ALAJGICDDMD(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void MHFJEPLKPBF(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"[PlayerGender=");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.JAJCIJHCAAB(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void BFJOEMCBJJO()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(BKOJOMIEMJF));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Duplicate tutorial ID found!" + ((Object)((Component)this).gameObject).name + "FishCuttingEvent/Talk1"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(CALJDPHKBMJ));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NJNEKKGKEKA));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(DJBKHJFHAHL));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			NEJABGEEFJF();
		}
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(IJMEPIGEIEH));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Collider " + ((Object)((Component)this).gameObject).name + "[MinePuzzleManager] Element {0} assigned to spawner {1} on piece {2}"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(DJPIOACNIBO));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NEJABGEEFJF));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(MDNCIAFNFCM));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			EODPIKFPHPK();
		}
	}

	private void JDMMNLKLMAA()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(NIDIBMKHGOK));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Player" + ((Object)((Component)this).gameObject).name + "ShieldTrigger"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(OGKEECMHIDN));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EODPIKFPHPK));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			MAKKDPBOHNK();
		}
	}

	private void MFJIHCKEIIF()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JDKBOHFELFO));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Items/item_description_633" + ((Object)((Component)this).gameObject).name + "[MinePuzzleManager] Deactivating all puzzles"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(INAHBFNCDOK));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PCMJOOALNFC));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(HPGGFPEOPGJ));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			JGIIGHAAIHF();
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
			}
		}
	}

	private void HLPABEIDALI(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)" seconds.");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.JAJCIJHCAAB(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void HEGNINLLINP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFJNFFELBCL));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(MBONNCDBIPM));
			}
		}
	}

	private void ALAJGICDDMD(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"City/PetShop/Nessy/Barks_PetDog");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.PLJPPIHFBAD(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void JDAMCMODANB()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(HLPABEIDALI));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Direction" + ((Object)((Component)this).gameObject).name + " seconds."));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NIDIBMKHGOK));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			EFJNFFELBCL();
		}
	}

	private void OOIHNJHMBMC()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(CALJDPHKBMJ));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("itemRedWineJuice" + ((Object)((Component)this).gameObject).name + "ClosePopUp"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(CALJDPHKBMJ));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(DJBKHJFHAHL));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(OFDMNIEGMCF));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			JDFDLEEELFH();
		}
	}

	private void NMKGOAJLMDG()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(ENBMEMNNHIM));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("\r" + ((Object)((Component)this).gameObject).name + "Farm/Buzz/Main"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(BKOJOMIEMJF));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NJNEKKGKEKA));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(BIPOAFDHOKL));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			MDNCIAFNFCM();
		}
	}

	private void LHABENPEMPB()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(HAMJGIJENDD));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("[MinePuzzleManager] No MinePuzzleBase found for type {0}." + ((Object)((Component)this).gameObject).name + "Spawning special item event: "));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(OBCEBFPJHLG));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PCMJOOALNFC));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IOLEAIBGFNE));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			MDNCIAFNFCM();
		}
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
			}
		}
	}

	private void AMNCIAEMBFO()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(ENBMEMNNHIM));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("OrderName" + ((Object)((Component)this).gameObject).name + "mine level"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(ENBMEMNNHIM));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IDODLLIMEMO));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			HBLKLIMCHJF();
		}
	}

	private void INAHBFNCDOK(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~ZoneType.Cellar)
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"BuildingTutorialOnlyHost");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.Toggle(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void NIDIBMKHGOK(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"Bed is unmade");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.NOLDEOOIMJB(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void NEJABGEEFJF()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			IJMEPIGEIEH(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void FPNCANODJKE()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JHBPOAAOJJL));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Tutorial/T112/Dialogue1" + ((Object)((Component)this).gameObject).name + "Whiskey"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(ENBMEMNNHIM));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OFDMNIEGMCF));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(IDODLLIMEMO));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			EFJNFFELBCL();
		}
	}

	private void JDOKHDEBCPH()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			HAMJGIJENDD(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void PCMJOOALNFC()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			JFBLDFBENLO(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void PKFMLJGJKCP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(NPCPLINCDLO));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(KEIICPHCIIF));
			}
		}
	}

	private void CALJDPHKBMJ(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"Waiting for players to finish their transitions...");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.FPAGIHHJBBK(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(INJNMCCGFIF));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NEJABGEEFJF));
			}
		}
	}

	private void PBDNKBPBCHM()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(HLPABEIDALI));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("ErrorServerTimeout" + ((Object)((Component)this).gameObject).name + "["));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(HLPABEIDALI));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NFKMBHPEAHN));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(INJNMCCGFIF));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			BBLHEMABMLD();
		}
	}

	private void NJNEKKGKEKA()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			INAHBFNCDOK(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KEIICPHCIIF()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			OGKEECMHIDN(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void EIDJLHFAMIB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NFKMBHPEAHN));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(BIPOAFDHOKL));
			}
		}
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
			}
		}
	}

	private void BGBFJPJLPMF()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JHBPOAAOJJL));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("itemRedGrapeMust" + ((Object)((Component)this).gameObject).name + "F2"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(HIKFDNBLGHF));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NEJABGEEFJF));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(NJNEKKGKEKA));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			NFKMBHPEAHN();
		}
	}

	private void BBLHEMABMLD()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			ALAJGICDDMD(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void CMEDJEGJLJN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(MAKKDPBOHNK));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(DJBKHJFHAHL));
			}
		}
	}

	private void BGPGIOMKKAO()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			DJHGCGNCFMP(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KCLKEAHGGEK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(EFJNFFELBCL));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(MDNCIAFNFCM));
			}
		}
	}

	private void JDKBOHFELFO(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"Trying to create a new room with a different code...");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.JAJCIJHCAAB(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void MBONNCDBIPM()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			INAHBFNCDOK(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void OBCEBFPJHLG(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"ReceiveEmployeeWorking");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.DEIKABIIGDH(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void CCOELPOHEBL(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)" to ");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.FPAGIHHJBBK(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void AJGLDLLIIFO()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JHBPOAAOJJL));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)(" " + ((Object)((Component)this).gameObject).name + "Wide screen ratio"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(OBCEBFPJHLG));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EODPIKFPHPK));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(INJNMCCGFIF));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			OFDMNIEGMCF();
		}
	}

	private void EJKKDBFALEB(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"itemCoconut");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.FPAGIHHJBBK(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(JDFDLEEELFH));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(HPGGFPEOPGJ));
			}
		}
	}

	private void ILCLIJOHKHG()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JFBLDFBENLO));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Inventory full" + ((Object)((Component)this).gameObject).name + " : "));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IJMEPIGEIEH));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(EODPIKFPHPK));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(INJNMCCGFIF));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			HPGGFPEOPGJ();
		}
	}

	private void HPMFOHOMLDO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PCMJOOALNFC));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(JDOKHDEBCPH));
			}
		}
	}

	private void PNJJEDEFAGO()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(HLPABEIDALI));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("ToggleEntityView" + ((Object)((Component)this).gameObject).name + ""));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(HAMJGIJENDD));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MDNCIAFNFCM));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(KEIICPHCIIF));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			KEIICPHCIIF();
		}
	}

	private void POECBFJLIIE(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"]");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.PLJPPIHFBAD(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void OFDMNIEGMCF()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			JHBPOAAOJJL(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void MJNMAFOEBMD(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"[Player2Name]");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.Toggle(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void DKNNLPFIBIK()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(DJPIOACNIBO));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Items/item_description_702" + ((Object)((Component)this).gameObject).name + "ReceiveTavernAction"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(IJMEPIGEIEH));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(HPGGFPEOPGJ));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			OFDMNIEGMCF();
		}
	}

	private void OGKEECMHIDN(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"ReceiveRemoveItemOnTray");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.DEIKABIIGDH(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void NFKMBHPEAHN()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			INAHBFNCDOK(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void DJHGCGNCFMP(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ZoneType.Cellar)
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"Light 2D not found");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.Toggle(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void JHBPOAAOJJL(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.RentedRoom | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"Talk");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.NOLDEOOIMJB(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void NLGHNDLPPKI()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JDKBOHFELFO));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("xForXP" + ((Object)((Component)this).gameObject).name + "MainProgress"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(POECBFJLIIE));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(HPGGFPEOPGJ));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			HBLKLIMCHJF();
		}
	}

	private void CIICEKEJANM()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(POECBFJLIIE));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Player2" + ((Object)((Component)this).gameObject).name + "Player2"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(DJPIOACNIBO));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CCBDFPOONHE));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			EFJNFFELBCL();
		}
	}

	private void IOLEAIBGFNE()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			MHFJEPLKPBF(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void EODPIKFPHPK()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			DJPIOACNIBO(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void MBBIGANCPNE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EODPIKFPHPK));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(IDODLLIMEMO));
			}
		}
	}

	private void JGIIGHAAIHF()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			CCOELPOHEBL(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void CCBDFPOONHE()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			OKIDBNKLIMA(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void MAKKDPBOHNK()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			MJNMAFOEBMD(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KHCJDKHONPK()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(HIKFDNBLGHF));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("BanquetOrdersManager is not initialized." + ((Object)((Component)this).gameObject).name + "Items/item_description_1121"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(OKIDBNKLIMA));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OFDMNIEGMCF));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			IOLEAIBGFNE();
		}
	}

	private void BIPOAFDHOKL()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			OGKEECMHIDN(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void DONGKOKMGMM()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(HBLKLIMCHJF));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(NHGBKNAJHOP));
			}
		}
	}

	private void CBJCOLHKLCP(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"Disconnected");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.Toggle(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void DJBKHJFHAHL()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			MHFJEPLKPBF(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void AAEAAEBBFKG()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(IJMEPIGEIEH));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Sickle" + ((Object)((Component)this).gameObject).name + "Dialogue System/Conversation/Crowly_Introduce/Entry/14/Dialogue Text"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(HAMJGIJENDD));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(DJBKHJFHAHL));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(MAKKDPBOHNK));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			DJBKHJFHAHL();
		}
	}

	private void NHGBKNAJHOP()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			HLPABEIDALI(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void HPGGFPEOPGJ()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			POECBFJLIIE(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OFDMNIEGMCF));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(EFJNFFELBCL));
			}
		}
	}

	private void OKIDBNKLIMA(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"UIAddRemove");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.PLJPPIHFBAD(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void PGEGODAEBLC()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(IJMEPIGEIEH));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("ReceiveAddFoodToBento" + ((Object)((Component)this).gameObject).name + "Farm/Buzz/Bark_Searching"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(HLPABEIDALI));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KEIICPHCIIF));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(NEJABGEEFJF));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			HPGGFPEOPGJ();
		}
	}

	private void EFJNFFELBCL()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			DJPIOACNIBO(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void HBLKLIMCHJF()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			MHFJEPLKPBF(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void CLGBFOIBANN()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(NIDIBMKHGOK));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("[GenerateAltar] Candidate {0} pos:{1} distToPuzzle:{2:F1}" + ((Object)((Component)this).gameObject).name + "Items/item_description_1086"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(OKIDBNKLIMA));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PCMJOOALNFC));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(JGIIGHAAIHF));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			BIPOAFDHOKL();
		}
	}

	private void Awake()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(DJHGCGNCFMP));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("NightStart not attached to prefab " + ((Object)((Component)this).gameObject).name + " in Cellar Light Start"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(DJHGCGNCFMP));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			BGPGIOMKKAO();
		}
	}

	private void DJPIOACNIBO(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"Disabled");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.DEIKABIIGDH(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void NPCPLINCDLO()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			BKOJOMIEMJF(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void ENBMEMNNHIM(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"Meat");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.FPAGIHHJBBK(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = false;
		}
	}

	private void NOILIOLOOBJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BIPOAFDHOKL));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JDOKHDEBCPH));
			}
		}
	}

	private void IJMEPIGEIEH(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"NormalLeft");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.NOLDEOOIMJB(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void HIKFDNBLGHF(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == (ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"LE_15");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.DEIKABIIGDH(KDBOIBDPHKD: true);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void CACJMKJBJDP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(MBONNCDBIPM));
			}
		}
	}

	private void HLCAKACHOOE()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(JDFDLEEELFH));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(NPCPLINCDLO));
			}
		}
	}

	private void HAMJGIJENDD(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
			else
			{
				Debug.LogError((object)"ReceiveRemoveTableOrderBanquetCustomer");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.PLJPPIHFBAD(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = true;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(IOLEAIBGFNE));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NEJABGEEFJF));
			}
		}
	}

	private void JFBLDFBENLO(int JIIGOACEIKL)
	{
		if ((Object)(object)nightStart == (Object)null)
		{
			return;
		}
		if ((Object)(object)placeable != (Object)null && placeable.currentZoneType == ~(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(false);
			}
			else
			{
				Debug.LogError((object)"in");
			}
			if ((Object)(object)nightStart != (Object)null)
			{
				nightStart.DEIKABIIGDH(KDBOIBDPHKD: false);
				((Behaviour)nightStart).enabled = false;
			}
			if ((Object)(object)light2D != (Object)null)
			{
				((Component)light2D).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)nightStart != (Object)null)
		{
			((Behaviour)nightStart).enabled = true;
		}
	}

	private void MDNCIAFNFCM()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			DJHGCGNCFMP(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void JDFDLEEELFH()
	{
		try
		{
			if ((Object)(object)placeable != (Object)null)
			{
				placeable.CalculateCurrentZone();
			}
			CCOELPOHEBL(1);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(JHBPOAAOJJL));
		}
		if ((Object)(object)nightStart == (Object)null)
		{
			if (Application.isEditor)
			{
				Debug.LogWarning((object)("Items/item_name_1071" + ((Object)((Component)this).gameObject).name + "Back"));
			}
			nightStart = ((Component)this).GetComponent<NightStart>();
		}
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(MJNMAFOEBMD));
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(HPGGFPEOPGJ));
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			EODPIKFPHPK();
		}
	}
}
