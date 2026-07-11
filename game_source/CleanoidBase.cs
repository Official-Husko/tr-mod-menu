using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CleanoidBase : MonoBehaviour
{
	public Placeable placeable;

	[SerializeField]
	private RobotVacNPC robotVac;

	private void BGMMJIIFLJK(int JIIGOACEIKL)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)placeable != (Object)null && placeable.CCIKENEGHCA && !placeable.FHEMHCEAICB && placeable.currentZoneType != ZoneType.RentedRoom && Utils.HNDBNJNJGJM(((Component)placeable).transform.position))
		{
			robotVac.active = true;
		}
	}

	private void HEDELLNGDHA(int JIIGOACEIKL)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)placeable != (Object)null && placeable.FHMDNECBLIL() && !placeable.FHEMHCEAICB && placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom) && Utils.HNDBNJNJGJM(((Component)placeable).transform.position))
		{
			robotVac.active = true;
		}
	}

	private void PCEFNHADDIG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
	}

	[CompilerGenerated]
	private void FNFCHFKCFDB(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		robotVac.active = false;
	}

	private void INBIKNCPBKJ(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		robotVac.active = true;
	}

	private void BGPGIOMKKAO()
	{
		BGMMJIIFLJK(1);
	}

	private void DHCIDFJBFAD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(BGMMJIIFLJK));
		}
	}

	[CompilerGenerated]
	private void MAJJECABAAB()
	{
		placeable.pickUpable = true;
	}

	private void PBHBBCEODPK()
	{
		placeable.pickUpable = true;
	}

	private void NJNEHCNJAMA(int JIIGOACEIKL)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)placeable != (Object)null && placeable.CCIKENEGHCA && !placeable.FHEMHCEAICB && placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom) && Utils.HNDBNJNJGJM(((Component)placeable).transform.position))
		{
			robotVac.active = false;
		}
	}

	private void OPGMKJIMNGM()
	{
		placeable.pickUpable = false;
	}

	private void NJFCOFAIMKD()
	{
		placeable.pickUpable = true;
	}

	private void HINKPJCNPCF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(BGMMJIIFLJK));
		}
	}

	private void CEGJJCHHLCE()
	{
		placeable.pickUpable = true;
	}

	[CompilerGenerated]
	private void PEALDCHKCKD(int JIIGOACEIKL)
	{
		BGMMJIIFLJK(1);
	}

	private void JNJCCIFIKOC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
	}

	private void EDBDJLPHGGJ()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && (Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(HEDELLNGDHA));
		}
	}

	private void OnEnable()
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(BGMMJIIFLJK));
	}

	private void JIAJFDKNJME()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		RobotVacNPC robotVacNPC = robotVac;
		robotVacNPC.OnLeaveBase = (Action)Delegate.Combine(robotVacNPC.OnLeaveBase, (Action)delegate
		{
			placeable.pickUpable = false;
		});
		RobotVacNPC robotVacNPC2 = robotVac;
		robotVacNPC2.OnReturnBase = (Action)Delegate.Combine(robotVacNPC2.OnReturnBase, (Action)delegate
		{
			placeable.pickUpable = true;
		});
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, (Action<int, bool, bool>)delegate
		{
			robotVac.active = false;
		});
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, (Action<int>)delegate
		{
			BGMMJIIFLJK(1);
		});
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		RobotVacNPC robotVacNPC = robotVac;
		robotVacNPC.OnLeaveBase = (Action)Delegate.Combine(robotVacNPC.OnLeaveBase, (Action)delegate
		{
			placeable.pickUpable = false;
		});
		RobotVacNPC robotVacNPC2 = robotVac;
		robotVacNPC2.OnReturnBase = (Action)Delegate.Combine(robotVacNPC2.OnReturnBase, (Action)delegate
		{
			placeable.pickUpable = true;
		});
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, (Action<int, bool, bool>)delegate
		{
			robotVac.active = false;
		});
		Placeable obj2 = placeable;
		obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, (Action<int>)delegate
		{
			BGMMJIIFLJK(1);
		});
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	[CompilerGenerated]
	private void GECELDHPGCL()
	{
		placeable.pickUpable = false;
	}
}
