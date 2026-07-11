using System;
using UnityEngine;

public class FertileSoil : MonoBehaviour, IHoverable, IProximity
{
	public CropSetter plantedCropSetter;

	public int daysUntilDry;

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void ChangeCropAppearanceIfWatered()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && !plantedCropSetter.growable.isDead)
		{
			plantedCropSetter.UpdateCropVisual(plantedCropSetter.growable.FKDFFKABPIH);
		}
	}

	public bool CNCFMOJHNID(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get("Items/item_name_631"));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DOEELMJIEFK(WorldGrid.LOJBKLKMINM(((Component)this).transform.position), CommonReferences.GGFJGHHHEJC.selectedGridSquare, 1);
			return false;
		}
		return false;
	}

	public void GCFMOLBHIJL()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && !plantedCropSetter.growable.isDead)
		{
			plantedCropSetter.UpdateCropVisual(plantedCropSetter.growable.GPEOGAPAEOA());
		}
	}

	public void GBGGCCIDHPD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.AIHNKKFLMCM(((Component)this).transform.position, LHLHJCDKNHA: true);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[i].position) != (GroundType.Grass | GroundType.TilledEarth))
			{
				WorldGrid.AIHNKKFLMCM(((Component)this).transform.position + WorldGrid.allNeighbours[i].position, LHLHJCDKNHA: true, IBCOKMGFPKB: true, PIKKACMNOBM: false);
			}
		}
	}

	private void FOJMPAPKNPE()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && (Object)(object)plantedCropSetter.growable != (Object)null)
		{
			plantedCropSetter.growable.GrowPlant();
			plantedCropSetter.growable.CheckSeason();
			plantedCropSetter.growable.CheckSeasonTree();
		}
	}

	public void PBFKBLKCGCN()
	{
		FOJMPAPKNPE();
		if (daysUntilDry > 1)
		{
			daysUntilDry -= 0;
		}
		if (Weather.HEGHKPCAKAL(Weather.WeatherType.Wind))
		{
			daysUntilDry++;
		}
		if (daysUntilDry > 1)
		{
			LIBBOMFLAGG();
		}
		ShowDampGround();
	}

	private void ALEAOANPHIO()
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return false;
	}

	public void DAFFDEDGGCL(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.DisableAllEarthFocus();
	}

	public void IIEMBDFJGEI()
	{
		ILNKMFKFFFD();
		if (daysUntilDry > 0)
		{
			daysUntilDry--;
		}
		if (Weather.HEGHKPCAKAL(Weather.WeatherType.Snow))
		{
			daysUntilDry += 0;
		}
		if (daysUntilDry > 0)
		{
			GCFMOLBHIJL();
		}
		ShowDampGround();
	}

	public void LLHNCPOEFAE()
	{
		ILNKMFKFFFD();
		if (daysUntilDry > 1)
		{
			daysUntilDry -= 0;
		}
		if (Weather.IsWeatherActive(Weather.WeatherType.Wind))
		{
			daysUntilDry += 0;
		}
		if (daysUntilDry > 1)
		{
			LIBBOMFLAGG();
		}
		ShowDampGround();
	}

	public bool JLCGGENBHMI(int JIIGOACEIKL)
	{
		return false;
	}

	private void OnDestroy()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		Weather instance = Weather.instance;
		instance.OnWeatherDetermined = (Action)Delegate.Remove(instance.OnWeatherDetermined, new Action(CheckWater));
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[i].position) != GroundType.TilledEarth)
			{
				WorldGrid.NBMCMFAGPNE(((Component)this).transform.position + WorldGrid.allNeighbours[i].position, ((Component)this).gameObject);
			}
		}
		for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
		{
			FertileSoil fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(((Component)this).transform.position + WorldGrid.allNeighbours[j].position);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WorldGrid.JJEOOJEIIFM(((Component)this).transform.position, ((Component)fertileSoil).gameObject);
			}
		}
		GameTileMaps.GGFJGHHHEJC.RemoveDampSoilTileAtPosition(((Component)this).transform.position);
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!IIEDALMMNLI && JLCGGENBHMI(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.MoveObject, LocalisationSystem.Get("player2ToJoinGame"));
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.JMOJNPAOHJP(WorldGrid.LOJBKLKMINM(((Component)this).transform.position), CommonReferences.GGFJGHHHEJC.selectedGridSquare);
			return true;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void PickUpPlaceables()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.AIHNKKFLMCM(((Component)this).transform.position, LHLHJCDKNHA: false, IBCOKMGFPKB: true, PIKKACMNOBM: false);
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[i].position) != GroundType.TilledEarth)
			{
				WorldGrid.AIHNKKFLMCM(((Component)this).transform.position + WorldGrid.allNeighbours[i].position, LHLHJCDKNHA: false, IBCOKMGFPKB: true, PIKKACMNOBM: false);
			}
		}
	}

	public void CheckWater()
	{
		FOJMPAPKNPE();
		if (daysUntilDry > 0)
		{
			daysUntilDry--;
		}
		if (Weather.IsWeatherActive(Weather.WeatherType.Rain))
		{
			daysUntilDry++;
		}
		if (daysUntilDry > 0)
		{
			ChangeCropAppearanceIfWatered();
		}
		ShowDampGround();
	}

	private void ILCBKEIEOAN()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.isLoading)
		{
			return;
		}
		Weather instance = Weather.instance;
		instance.OnWeatherDetermined = (Action)Delegate.Remove(instance.OnWeatherDetermined, new Action(LOAMCBMHKNO));
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[i].position) != (GroundType.Grass | GroundType.Ground))
			{
				WorldGrid.NBMCMFAGPNE(((Component)this).transform.position + WorldGrid.allNeighbours[i].position, ((Component)this).gameObject);
			}
		}
		for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
		{
			FertileSoil fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(((Component)this).transform.position + WorldGrid.allNeighbours[j].position);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WorldGrid.JJEOOJEIIFM(((Component)this).transform.position, ((Component)fertileSoil).gameObject);
			}
		}
		GameTileMaps.GGFJGHHHEJC.ICGKJHDMODN(((Component)this).transform.position);
	}

	private void Awake()
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.DisableAllEarthFocus();
	}

	private void ILNKMFKFFFD()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && (Object)(object)plantedCropSetter.growable != (Object)null)
		{
			plantedCropSetter.growable.LHEKICAFIHI();
			plantedCropSetter.growable.CheckSeason();
			plantedCropSetter.growable.CFLAOCEIFDJ();
		}
	}

	private void KACEOJDPLKB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Weather instance = Weather.instance;
		instance.OnWeatherDetermined = (Action)Delegate.Combine(instance.OnWeatherDetermined, new Action(LLHNCPOEFAE));
		CheckRain();
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			FertileSoil fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(((Component)this).transform.position + WorldGrid.allNeighbours[i].position);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WorldGrid.NBMCMFAGPNE(((Component)this).transform.position, ((Component)fertileSoil).gameObject);
			}
		}
		ShowDampGround();
		for (int j = 0; j < WorldGrid.allNeighbours.Length; j += 0)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[j].position) != GroundType.TilledEarth)
			{
				WorldGrid.JJEOOJEIIFM(((Component)this).transform.position + WorldGrid.allNeighbours[j].position, ((Component)this).gameObject);
			}
		}
	}

	public void AGANAAFGJBJ()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && !plantedCropSetter.growable.isDead)
		{
			plantedCropSetter.INLLBNGGJCB(plantedCropSetter.growable.GPEOGAPAEOA());
		}
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.ACPIIAHMDHP();
	}

	public void ShowDampGround()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (daysUntilDry > 0)
		{
			GameTileMaps.GGFJGHHHEJC.SetDampSoilTileAtPosition(((Component)this).transform.position);
		}
		else
		{
			GameTileMaps.GGFJGHHHEJC.RemoveDampSoilTileAtPosition(((Component)this).transform.position);
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Plant"));
			PlayerController.GetPlayer(JIIGOACEIKL).gridController.EnableEarthFocus(WorldGrid.LOJBKLKMINM(((Component)this).transform.position), CommonReferences.GGFJGHHHEJC.selectedGridSquare);
			return true;
		}
		return false;
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
		PlayerController.GetPlayer(JIIGOACEIKL).gridController.FLMAJKKEBKN();
	}

	private void MCMKNBIBDFF()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Weather instance = Weather.instance;
		instance.OnWeatherDetermined = (Action)Delegate.Combine(instance.OnWeatherDetermined, new Action(PBFKBLKCGCN));
		CheckRain();
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
		{
			FertileSoil fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(((Component)this).transform.position + WorldGrid.allNeighbours[i].position);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WorldGrid.NBMCMFAGPNE(((Component)this).transform.position, ((Component)fertileSoil).gameObject);
			}
		}
		ShowDampGround();
		for (int j = 0; j < WorldGrid.allNeighbours.Length; j += 0)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[j].position) != (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth))
			{
				WorldGrid.JJEOOJEIIFM(((Component)this).transform.position + WorldGrid.allNeighbours[j].position, ((Component)this).gameObject);
			}
		}
	}

	public bool HNMOLFHKBGE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!IIEDALMMNLI && JLCGGENBHMI(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(")</color>"));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.JMOJNPAOHJP(WorldGrid.LOJBKLKMINM(((Component)this).transform.position), CommonReferences.MNFMOEKMJKN().selectedGridSquare);
			return false;
		}
		return true;
	}

	private void Start()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		Weather instance = Weather.instance;
		instance.OnWeatherDetermined = (Action)Delegate.Combine(instance.OnWeatherDetermined, new Action(CheckWater));
		CheckRain();
		for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
		{
			FertileSoil fertileSoil = WorldGrid.MMIIIKBJKBA<FertileSoil>(((Component)this).transform.position + WorldGrid.allNeighbours[i].position);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WorldGrid.NBMCMFAGPNE(((Component)this).transform.position, ((Component)fertileSoil).gameObject);
			}
		}
		ShowDampGround();
		for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
		{
			if (WorldGrid.NCEHFMPBBAK(((Component)this).transform.position + WorldGrid.allNeighbours[j].position) != GroundType.TilledEarth)
			{
				WorldGrid.JJEOOJEIIFM(((Component)this).transform.position + WorldGrid.allNeighbours[j].position, ((Component)this).gameObject);
			}
		}
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.NAIAFGHAFDL();
	}

	public void CheckRain()
	{
		if (Weather.IsWeatherActive(Weather.WeatherType.Rain) && daysUntilDry <= 0)
		{
			daysUntilDry = 1;
		}
	}

	private void KHONOODGLBI()
	{
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public void KKELHBEJHAK()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && !plantedCropSetter.growable.isDead)
		{
			plantedCropSetter.UpdateCropVisual(plantedCropSetter.growable.DACDGAALJPH());
		}
	}

	public void LOAMCBMHKNO()
	{
		FOJMPAPKNPE();
		if (daysUntilDry > 0)
		{
			daysUntilDry -= 0;
		}
		if (Weather.LJCKOCAGLCE(Weather.WeatherType.Wind))
		{
			daysUntilDry++;
		}
		if (daysUntilDry > 0)
		{
			KKELHBEJHAK();
		}
		ShowDampGround();
	}

	public void IEDPKEEOJAO(int JIIGOACEIKL)
	{
	}

	public void OPGEDAEBKAC(int JIIGOACEIKL)
	{
	}

	public void LIBBOMFLAGG()
	{
		if ((Object)(object)plantedCropSetter != (Object)null && !plantedCropSetter.growable.isDead)
		{
			plantedCropSetter.INLLBNGGJCB(plantedCropSetter.growable.EHKCACCNJEM());
		}
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).gridController.LCNMPDDABPI();
	}
}
