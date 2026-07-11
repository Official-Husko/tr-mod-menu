using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapScene : MonoBehaviour
{
	[Serializable]
	public class Corners
	{
		public Transform cornerFrom;

		public Transform cornerTo;
	}

	[CompilerGenerated]
	private sealed class MFDLGPEBDBE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TilemapScene _003C_003E4__this;

		public Season season;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public MFDLGPEBDBE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			TilemapScene tilemapScene = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				tilemapScene.OBOHHKIEMIG(season);
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class KHEEBIHANBH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TilemapScene _003C_003E4__this;

		public Season season;

		private Vector3Int[] _003CpositionsToCalculate_003E5__2;

		private TimerHelper _003Ctimer_003E5__3;

		private int _003Ci_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public KHEEBIHANBH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TilemapScene tilemapScene = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				tilemapScene.updatingTerrain = true;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CpositionsToCalculate_003E5__2 = tilemapScene.GetAllPositionsToCalculate();
				_003Ctimer_003E5__3 = new TimerHelper();
				_003Ci_003E5__4 = 0;
				goto IL_019d;
			case 2:
				_003C_003E1__state = -1;
				goto IL_018b;
			case 3:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_019d:
				if (_003Ci_003E5__4 < _003CpositionsToCalculate_003E5__2.Length)
				{
					if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(_003CpositionsToCalculate_003E5__2[_003Ci_003E5__4]))
					{
						Vector3 val = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(_003CpositionsToCalculate_003E5__2[_003Ci_003E5__4]);
						if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
						{
							ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, season, DCHHFGLPNOF: true);
						}
						else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
						{
							ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, season, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
						}
						if (tilemapScene.updateTerrainForEachWorldTile)
						{
							WorldGrid.MBDKGAIDBDD(ILDEFBIANKO, val, tilemapScene, season);
						}
						if (_003Ctimer_003E5__3.GetMillisecs() > 50f)
						{
							if (tilemapScene.applyChangeSeasonTerrain && tilemapScene.location == Location.Road)
							{
								TitleScreen.GetInstance().allTerrainUpdatedProgress = (float)_003Ci_003E5__4 / (float)_003CpositionsToCalculate_003E5__2.Length;
							}
							_003Ctimer_003E5__3.Reset();
							if (!TilemapsInfo.AEALFCKBGKM(tilemapScene.location) || GameManager.LocalCoop())
							{
								_003C_003E2__current = null;
								_003C_003E1__state = 2;
								return true;
							}
						}
					}
					goto IL_018b;
				}
				if (tilemapScene.gameSeason != season)
				{
					tilemapScene.gameSeason = season;
					if (tilemapScene.applyChangeSeasonTerrain && !tilemapScene.hasSeasonsMaps.HasFlag(SeasonManager.SeasonToCropSeason(season)))
					{
						_003C_003E2__current = ((MonoBehaviour)tilemapScene).StartCoroutine(tilemapScene.FJFFJHCMGKI(season));
						_003C_003E1__state = 3;
						return true;
					}
				}
				else if (tilemapScene.location == Location.Road)
				{
					TitleScreen.GetInstance().allTerrainUpdatedProgress = 1f;
					TitleScreen.GetInstance().allTerrainUpdated = true;
				}
				break;
				IL_018b:
				_003Ci_003E5__4++;
				goto IL_019d;
			}
			tilemapScene.updatingTerrain = false;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public Location location;

	public GameObject parent;

	public bool canUseDecorationMode;

	public CropSeason hasSeasonsMaps = CropSeason.Spring;

	public CommonTilemaps commonTilemaps;

	public WallTilemaps wallTilemaps;

	public SnowTilemaps snowTilemaps;

	[SerializeField]
	private TilemapGroup tilemapsSpring;

	[SerializeField]
	private TilemapGroup tilemapsSummer;

	[SerializeField]
	private TilemapGroup tilemapsAutumn;

	[SerializeField]
	private TilemapGroup tilemapsWinter;

	[SerializeField]
	protected GameObject[] gameObjectsToActivate;

	[SerializeField]
	private CropSetter[] uniqueCrops;

	[SerializeField]
	private BushHarvest[] bushHarvest;

	[SerializeField]
	private MiscellaneousSpawner[] miscellaneousSpawner;

	public WaterType waterType = WaterType.FreshWater;

	public bool loadScene = true;

	public bool updatingTerrain;

	public bool updateTerrain;

	public bool createWorldTilesOnAwake;

	public bool updateTerrainForEachWorldTile;

	public bool applyChangeSeasonTerrain = true;

	public PathNodesRegion pathNodesRegion;

	public Season editorSeason;

	public bool onlyApplySeasonTerrainConversion;

	public Season gameSeason;

	public DrawGizmosType drawType;

	public bool refreshMap = true;

	public GroundType defaultGroundType;

	public MaterialType defaultMaterialType;

	[Space(10f)]
	public Corners[] zonesToCalculate;

	private Tilemap[] DHNGOPCEPLJ;

	private TimerHelper IMLDGBFPEMA;

	private Vector3Int[] GEIFPPHMBFI;

	private TilemapsInfo.UpdateTerrainPositions[] LMPOMIAGCAE;

	public GroundType KKCMMNKICAE(Vector3 IMOBLFMHKOD, bool GAFOJLKFKJA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GroundType result = GroundType.None;
		TileBase val = Utils.GCGNCHFNEBJ<TileBase>(BNMLDAPCNKF().floorUpperTilemap, IMOBLFMHKOD);
		if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Invalid Player for CursorManager") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("Invalid seating")))
		{
			result = GroundType.None;
		}
		else
		{
			val = Utils.GCGNCHFNEBJ<TileBase>(EMHLLEFBBCO(Season.Summer).floorLowerTilemap, IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Other player disconnected was the actor of event ") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("No MinePuzzleBase found for type {0} when trying to get required elements count")))
			{
				result = GroundType.Ground;
			}
		}
		return result;
	}

	private IEnumerator BPLGLPILOCC(Season EECEKHKAAIH)
	{
		yield return null;
		OBOHHKIEMIG(EECEKHKAAIH);
	}

	public void KDBACIPKMKH()
	{
		PathNodesManager.LELIHPHGMEB();
	}

	public void CopyFromTilemapScene()
	{
		TilemapGroup tilemaps = GetTilemaps(editorSeason);
		for (int i = 0; i < tilemaps.seasonTilemaps.Length; i++)
		{
			CCHJPPEHMMB(tilemapsSpring.seasonTilemaps[i], tilemaps.seasonTilemaps[i]);
		}
		CCHJPPEHMMB(tilemapsSpring.autoAcantilado, tilemaps.autoAcantilado);
		CCHJPPEHMMB(tilemapsSpring.cliffsTilemap, tilemaps.cliffsTilemap);
		CCHJPPEHMMB(tilemapsSpring.darkGrass2Tilemap, tilemaps.darkGrass2Tilemap);
		CCHJPPEHMMB(tilemapsSpring.darkGrassTilemap, tilemaps.darkGrassTilemap);
		CCHJPPEHMMB(tilemapsSpring.darkGroundTilemap, tilemaps.darkGroundTilemap);
		CCHJPPEHMMB(tilemapsSpring.distorsionMaskTilemap, tilemaps.distorsionMaskTilemap);
		CCHJPPEHMMB(tilemapsSpring.embarcaderoTilemap, tilemaps.embarcaderoTilemap);
		CCHJPPEHMMB(tilemapsSpring.espumaTilemap, tilemaps.espumaTilemap);
		CCHJPPEHMMB(tilemapsSpring.floorLowerTilemap, tilemaps.floorLowerTilemap);
		CCHJPPEHMMB(tilemapsSpring.floorUpperTilemap, tilemaps.floorUpperTilemap);
		CCHJPPEHMMB(tilemapsSpring.fondoTilemap, tilemaps.fondoTilemap);
		CCHJPPEHMMB(tilemapsSpring.grassAbove, tilemaps.grassAbove);
		CCHJPPEHMMB(tilemapsSpring.parchesOrillaTilemap, tilemaps.parchesOrillaTilemap);
		CCHJPPEHMMB(tilemapsSpring.rockGroundTilemap, tilemaps.rockGroundTilemap);
		CCHJPPEHMMB(tilemapsSpring.waterCliffsTilemap, tilemaps.waterCliffsTilemap);
		CCHJPPEHMMB(tilemapsSpring.waterDownTilemap, tilemaps.waterDownTilemap);
		CCHJPPEHMMB(tilemapsSpring.waterUpTilemap, tilemaps.waterUpTilemap);
	}

	public TilemapGroup EMHLLEFBBCO(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.GGALEPCMBID(EECEKHKAAIH)))
			{
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSpring;
				case Season.Summer:
					return tilemapsSummer;
				}
				if (EECEKHKAAIH == Season.Summer)
				{
					return tilemapsAutumn;
				}
				if (EECEKHKAAIH == Season.Summer)
				{
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Summer && hasSeasonsMaps.HasFlag(CropSeason.None))
			{
				return tilemapsSummer;
			}
			if (editorSeason == (Season)6 && hasSeasonsMaps.HasFlag(CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == Season.Winter && hasSeasonsMaps.HasFlag(CropSeason.Winter))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	private void OEEOBIOKNBJ()
	{
		if (OnlineManager.ClientOnline() && gameSeason != SeasonManager.BLCGOEMGKGH())
		{
			gameSeason = SeasonManager.LPGPJPPLHKG();
			if (applyChangeSeasonTerrain && !hasSeasonsMaps.HasFlag(SeasonManager.NNDMODNDPLO()))
			{
				((MonoBehaviour)this).StartCoroutine(PNLBONHIJMJ(SeasonManager.BLCGOEMGKGH()));
			}
		}
		NDMIDANMPDD();
	}

	private IEnumerator CABBDNMCFBF(Season EECEKHKAAIH)
	{
		return new KHEEBIHANBH(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH
		};
	}

	protected virtual void KMBEOPAHKGB()
	{
		drawType = DrawGizmosType.PathNodes;
	}

	private void NDMIDANMPDD()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnNewGameCreated = (Action)Delegate.Remove(instance2.OnNewGameCreated, new Action(NADOCEEBICL));
	}

	private IEnumerator ELDLDHDHGBD(Season EECEKHKAAIH)
	{
		return new KHEEBIHANBH(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH
		};
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && !((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null) && !((Object)(object)TravelZonesManager.DGCNCEDIFOF() == (Object)null))
		{
			TravelZonesManager.EKDNJDJHONF().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemaps.Remove(FGKDPLDANOA(SeasonManager.ADEICKHEPFI()));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GECFJNDNMGK));
			}
		}
	}

	private IEnumerator LBPDABKGJML(Season EECEKHKAAIH)
	{
		return new KHEEBIHANBH(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH
		};
	}

	private void KCEKLJJBNIL()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	public void BIIGJFECGIA(Transform CHGOBPEDDBJ)
	{
		for (int i = 1; i < CHGOBPEDDBJ.childCount; i += 0)
		{
			AKEAEGLFOII(CHGOBPEDDBJ.GetChild(i));
		}
		ActivateOnWinter component = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnWinter>();
		if (Object.op_Implicit((Object)(object)component))
		{
			component.PPIHDINDBKI(editorSeason);
		}
		ActivateOnSeason component2 = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnSeason>();
		if (Object.op_Implicit((Object)(object)component2))
		{
			component2.GPPNDLFAOGL(editorSeason);
		}
		ChangeSpriteOnSeason component3 = ((Component)CHGOBPEDDBJ).GetComponent<ChangeSpriteOnSeason>();
		if (Object.op_Implicit((Object)(object)component3))
		{
			component3.BGGFNFMNOBF(editorSeason);
		}
		Rock component4 = ((Component)CHGOBPEDDBJ).GetComponent<Rock>();
		if (Object.op_Implicit((Object)(object)component4))
		{
			component4.ResetSnowPhase(editorSeason);
		}
	}

	public TilemapGroup FGKDPLDANOA(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.KJCNKFEICPC(EECEKHKAAIH)))
			{
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSpring;
				case Season.Summer:
					return tilemapsSummer;
				case (Season)6:
					return tilemapsAutumn;
				case (Season)8:
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Spring && hasSeasonsMaps.HasFlag(CropSeason.Spring | CropSeason.Autumn))
			{
				return tilemapsSummer;
			}
			if (editorSeason == (Season)7 && hasSeasonsMaps.HasFlag(CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == Season.Winter && hasSeasonsMaps.HasFlag(CropSeason.Autumn))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	public GroundType DHKDNNNELGN(Vector3 IMOBLFMHKOD, bool GAFOJLKFKJA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GroundType result = GroundType.None;
		TileBase val = Utils.GCGNCHFNEBJ<TileBase>(KIMMMFKFCEK(Season.Summer).floorUpperTilemap, IMOBLFMHKOD);
		if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Hay {0} destructibles y {1} agujeros para cavar disponibles para el puzzle {2}") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("DualShock")))
		{
			result = GroundType.None;
		}
		else
		{
			val = Utils.GCGNCHFNEBJ<TileBase>(IAMBLEDHGDM(Season.Summer).floorLowerTilemap, IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Player2") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("Initial DevConsole message: ")))
			{
				result = GroundType.Ground;
			}
		}
		return result;
	}

	private void EHKOGOIAMGA()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	private void OnDrawGizmosSelected()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	public void PICKHKINHAG(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i++)
		{
			if (commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				if (!WorldGrid.NGDDNLHKAPM(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: false, JPLINFIKAJI: true);
				}
				else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: true);
				}
			}
		}
	}

	private void KIAOOMBGJHB(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(BPLGLPILOCC(EECEKHKAAIH));
	}

	private void HBMBCANOPMH()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	private void AIEKBPENOKC()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && !((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null) && !((Object)(object)TravelZonesManager.GFMBEDCANNI() == (Object)null))
		{
			TravelZonesManager.EKDNJDJHONF().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemaps.Remove(BNMLDAPCNKF(SeasonManager.BLCGOEMGKGH()));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JNBGHNBALOI));
			}
		}
	}

	private void BGIGJDLBHCH(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public TilemapsInfo.UpdateTerrainPositions[] PEPFLHNPPBN()
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.OHIKDDEGAFN(location);
	}

	private void MODBFIOJJKG(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	protected virtual void Awake()
	{
		drawType = DrawGizmosType.None;
	}

	public void CPLBPKIIKFJ()
	{
		PathNodesManager.LELIHPHGMEB();
	}

	public GroundType FIIFFDAEOGJ(Vector3 IMOBLFMHKOD, bool GAFOJLKFKJA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GroundType result = GroundType.Grass;
		TileBase val = Utils.GCGNCHFNEBJ<TileBase>(EMHLLEFBBCO(Season.Summer).floorUpperTilemap, IMOBLFMHKOD);
		if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("</color></b>")))
		{
			result = GroundType.Grass;
		}
		else
		{
			val = Utils.GCGNCHFNEBJ<TileBase>(IAMBLEDHGDM().floorLowerTilemap, IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("ReceiveThrowSlowingSpikes") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("LicenciaDeApertura/KlaynDialogue 07")))
			{
				result = GroundType.Ground;
			}
		}
		return result;
	}

	protected virtual void KLHIMJFCHPD()
	{
		drawType = DrawGizmosType.None;
	}

	private void GNACBEGFCFL(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(IKOLALADOLK(EECEKHKAAIH));
	}

	private void GLIICDEMHNN(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == Location.River)
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false);
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH == Season.Spring && GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false);
				}
			}
		}
	}

	private void NBAEDEJPNGC()
	{
		if (location != (Location.Road | Location.River | Location.Camp))
		{
			CommonReferences.GGFJGHHHEJC.allTilemapsScenes.Add(location, this);
		}
		CommonReferences.MNFMOEKMJKN().allTilemaps.Add(FGKDPLDANOA(SeasonManager.LPGPJPPLHKG()));
		if (!TravelZonesManager.CFHEJAGKIII().allTilemapScenes.ContainsKey(location))
		{
			TravelZonesManager.CFHEJAGKIII().allTilemapScenes.Add(location, this);
		}
		if (updateTerrain)
		{
			if (createWorldTilesOnAwake)
			{
				OKGEDBDIBFD(SeasonManager.LPGPJPPLHKG());
			}
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(GECFJNDNMGK));
			if (TilemapsInfo.LDCJBOFNFAB(location))
			{
				PEMEHGOEIFB(SeasonManager.ADEICKHEPFI());
			}
		}
		if (uniqueCrops != null)
		{
			for (int i = 0; i < uniqueCrops.Length; i += 0)
			{
				GeneratorsManager.instance.FIGNIJJKCOC(uniqueCrops[i]);
			}
		}
		if (bushHarvest != null)
		{
			for (int j = 1; j < bushHarvest.Length; j++)
			{
				GeneratorsManager.instance.IKIBKFLFKAL(bushHarvest[j]);
			}
		}
		if (miscellaneousSpawner != null)
		{
			for (int k = 0; k < miscellaneousSpawner.Length; k++)
			{
				GeneratorsManager.instance.MHFOLDKCNEB(miscellaneousSpawner[k]);
			}
		}
		if (!updateTerrain && refreshMap)
		{
			gameSeason = SeasonManager.PJMGHIMKFJL();
			JFDJPELGMIN(gameSeason);
		}
		if (refreshMap)
		{
			if (TilemapsInfo.CHEACPKMHEC(location))
			{
				JMGKHFPLJPE(SeasonManager.NHKAHEEGEGF());
			}
			else
			{
				KCAPECAMNHB(SeasonManager.KCJFCHNPIBJ());
			}
		}
	}

	private IEnumerator FJFFJHCMGKI(Season EECEKHKAAIH)
	{
		LMPOMIAGCAE = GetAllTerrainPositions();
		if (LMPOMIAGCAE == null || LMPOMIAGCAE.Length == 0)
		{
			GEIFPPHMBFI = GetAllPositionsToCalculate();
		}
		DHNGOPCEPLJ = GetTilemaps(EECEKHKAAIH).seasonTilemaps;
		IMLDGBFPEMA = new TimerHelper();
		if (LMPOMIAGCAE != null && LMPOMIAGCAE.Length != 0)
		{
			for (int i = 0; i < LMPOMIAGCAE.Length; i++)
			{
				for (int k = 0; k < LMPOMIAGCAE[i].positions.Count; k++)
				{
					WorldGrid.CGNOAFNBEAO(DHNGOPCEPLJ[i], LMPOMIAGCAE[i].positions[k], EECEKHKAAIH, editorSeason);
				}
				if (IMLDGBFPEMA.GetMillisecs() > 50f)
				{
					IMLDGBFPEMA.Reset();
					if (Application.isPlaying && (GameManager.LocalCoop() || !TilemapsInfo.AEALFCKBGKM(location)))
					{
						yield return null;
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < GEIFPPHMBFI.Length; i++)
			{
				for (int l = 0; l < DHNGOPCEPLJ.Length; l++)
				{
					if (DHNGOPCEPLJ[l].HasTile(GEIFPPHMBFI[i]))
					{
						WorldGrid.CGNOAFNBEAO(DHNGOPCEPLJ[l], GEIFPPHMBFI[i], EECEKHKAAIH, editorSeason);
					}
				}
				if (IMLDGBFPEMA.GetMillisecs() > 50f)
				{
					IMLDGBFPEMA.Reset();
					if (Application.isPlaying && (GameManager.LocalCoop() || !TilemapsInfo.AEALFCKBGKM(location)))
					{
						yield return null;
					}
				}
			}
		}
		if (location == Location.Road && Object.op_Implicit((Object)(object)TitleScreen.GetInstance()))
		{
			TitleScreen.GetInstance().allTerrainUpdated = true;
		}
	}

	public GroundType GetGroundTypeOnTile(Vector3 IMOBLFMHKOD, bool GAFOJLKFKJA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GroundType result = GroundType.None;
		TileBase val = Utils.GCGNCHFNEBJ<TileBase>(GetTilemaps().floorUpperTilemap, IMOBLFMHKOD);
		if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Grass") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("cliffs")))
		{
			result = GroundType.Grass;
		}
		else
		{
			val = Utils.GCGNCHFNEBJ<TileBase>(GetTilemaps().floorLowerTilemap, IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Ground") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("cliffs")))
			{
				result = GroundType.Ground;
			}
		}
		return result;
	}

	private void BECJGKCOPFK(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(IKOLALADOLK(EECEKHKAAIH));
	}

	private void MPPBNJFOKKJ()
	{
		if (location != Location.BarnInterior)
		{
			CommonReferences.GGFJGHHHEJC.allTilemapsScenes.Add(location, this);
		}
		CommonReferences.GGFJGHHHEJC.allTilemaps.Add(GetTilemaps(SeasonManager.EECEKHKAAIH));
		if (!TravelZonesManager.GGFJGHHHEJC.allTilemapScenes.ContainsKey(location))
		{
			TravelZonesManager.GGFJGHHHEJC.allTilemapScenes.Add(location, this);
		}
		if (updateTerrain)
		{
			if (createWorldTilesOnAwake)
			{
				CreateWorldTiles(SeasonManager.EECEKHKAAIH);
			}
			SeasonManager instance = SeasonManager.instance;
			instance.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance.OnSeasonChanged, new Action<Season>(JNBGHNBALOI));
			if (TilemapsInfo.AEALFCKBGKM(location))
			{
				JNBGHNBALOI(SeasonManager.EECEKHKAAIH);
			}
		}
		if (uniqueCrops != null)
		{
			for (int i = 0; i < uniqueCrops.Length; i++)
			{
				GeneratorsManager.instance.AddUniqueCrops(uniqueCrops[i]);
			}
		}
		if (bushHarvest != null)
		{
			for (int j = 0; j < bushHarvest.Length; j++)
			{
				GeneratorsManager.instance.AddUniqueBush(bushHarvest[j]);
			}
		}
		if (miscellaneousSpawner != null)
		{
			for (int k = 0; k < miscellaneousSpawner.Length; k++)
			{
				GeneratorsManager.instance.AddUniqueSpawner(miscellaneousSpawner[k]);
			}
		}
		if (!updateTerrain && refreshMap)
		{
			gameSeason = SeasonManager.EECEKHKAAIH;
			CreateWorldTiles(gameSeason);
		}
		if (refreshMap)
		{
			if (TilemapsInfo.AEALFCKBGKM(location))
			{
				KIAOOMBGJHB(SeasonManager.EECEKHKAAIH);
			}
			else
			{
				OBOHHKIEMIG(SeasonManager.EECEKHKAAIH);
			}
		}
	}

	private void BHAACAGPNFF(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(BPLGLPILOCC(EECEKHKAAIH));
	}

	private void OBOHHKIEMIG(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == Location.ChristmasCave)
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false);
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH == Season.Winter && GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false);
				}
			}
		}
	}

	public void IAKBJEOHFGD(Transform CHGOBPEDDBJ)
	{
		for (int i = 1; i < CHGOBPEDDBJ.childCount; i += 0)
		{
			IAKBJEOHFGD(CHGOBPEDDBJ.GetChild(i));
		}
		ActivateOnWinter component = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnWinter>();
		if (Object.op_Implicit((Object)(object)component))
		{
			component.MKMHDDGLJEJ(editorSeason);
		}
		ActivateOnSeason component2 = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnSeason>();
		if (Object.op_Implicit((Object)(object)component2))
		{
			component2.HHCBOLLOAMC(editorSeason);
		}
		ChangeSpriteOnSeason component3 = ((Component)CHGOBPEDDBJ).GetComponent<ChangeSpriteOnSeason>();
		if (Object.op_Implicit((Object)(object)component3))
		{
			component3.LODGDFFFGJA(editorSeason);
		}
		Rock component4 = ((Component)CHGOBPEDDBJ).GetComponent<Rock>();
		if (Object.op_Implicit((Object)(object)component4))
		{
			component4.FNMDLJKJFOA(editorSeason);
		}
	}

	public TilemapsInfo.UpdateTerrainPositions[] DFMLIACPAJC()
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.AJDPNNLOGPG(location);
	}

	private void EFBEKNLOILH()
	{
		if (OnlineManager.HHDBMDMFEMP() && gameSeason != SeasonManager.BLCGOEMGKGH())
		{
			gameSeason = SeasonManager.KCJFCHNPIBJ();
			if (applyChangeSeasonTerrain && !hasSeasonsMaps.HasFlag(SeasonManager.IEMEBFFIKMD()))
			{
				((MonoBehaviour)this).StartCoroutine(PNLBONHIJMJ(SeasonManager.EEGJBDCBKFD()));
			}
		}
		NDMIDANMPDD();
	}

	private void LDNNHNNNGHF()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	private void PFDIOMCHLEP(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	private void JKFDJKAJFBA()
	{
		LBPFPIMHJMN();
		if (refreshMap)
		{
			((MonoBehaviour)this).StartCoroutine(KCEMEBILCGD(SeasonManager.BLCGOEMGKGH()));
		}
	}

	public Vector3Int[] HNLGGMFFFIM()
	{
		if (refreshMap && CommonReferences.GGFJGHHHEJC.tilemapsInfo.allPositions.ContainsKey(location))
		{
			return CommonReferences.MNFMOEKMJKN().tilemapsInfo.allPositions[location];
		}
		return (Vector3Int[])(object)new Vector3Int[1];
	}

	public void CGHPPHBPALD()
	{
		PathNodesManager.JKDLLMKIHEG();
	}

	public GroundType CDBCKOOPAHM(Vector3 IMOBLFMHKOD, bool GAFOJLKFKJA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GroundType result = GroundType.None;
		TileBase val = Utils.GCGNCHFNEBJ<TileBase>(IAMBLEDHGDM(Season.Summer).floorUpperTilemap, IMOBLFMHKOD);
		if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("Cleaning") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("Fortitude/MainEvent 6")))
		{
			result = GroundType.Grass;
		}
		else
		{
			val = Utils.GCGNCHFNEBJ<TileBase>(BNMLDAPCNKF(Season.Summer).floorLowerTilemap, IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null && ((Object)val).name.Contains(" (versionOfCropsAndRecipes)") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("Dialogue System/Conversation/Crowly_Introduce/Entry/26/Dialogue Text")))
			{
				result = GroundType.TilledEarth;
			}
		}
		return result;
	}

	public void AKEAEGLFOII(Transform CHGOBPEDDBJ)
	{
		for (int i = 1; i < CHGOBPEDDBJ.childCount; i++)
		{
			ActivateOnChristmasRecursively(CHGOBPEDDBJ.GetChild(i));
		}
		ActivateOnWinter component = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnWinter>();
		if (Object.op_Implicit((Object)(object)component))
		{
			component.PFMCMNDEAON(editorSeason);
		}
		ActivateOnSeason component2 = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnSeason>();
		if (Object.op_Implicit((Object)(object)component2))
		{
			component2.EPEPNKCBNNJ(editorSeason);
		}
		ChangeSpriteOnSeason component3 = ((Component)CHGOBPEDDBJ).GetComponent<ChangeSpriteOnSeason>();
		if (Object.op_Implicit((Object)(object)component3))
		{
			component3.EPEPNKCBNNJ(editorSeason);
		}
		Rock component4 = ((Component)CHGOBPEDDBJ).GetComponent<Rock>();
		if (Object.op_Implicit((Object)(object)component4))
		{
			component4.NCNNNMIIFLF(editorSeason);
		}
	}

	private void Start()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			MPPBNJFOKKJ();
		}
	}

	private void NAFADINDPCF(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	private void PEMEHGOEIFB(Season EECEKHKAAIH)
	{
		if (refreshMap)
		{
			if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnNewGameCreated = (Action)Delegate.Combine(instance.OnNewGameCreated, new Action(NADOCEEBICL));
				GameManager instance2 = GameManager.GGFJGHHHEJC;
				instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			else if (location != 0)
			{
				((MonoBehaviour)this).StartCoroutine(CABBDNMCFBF(EECEKHKAAIH));
			}
		}
	}

	protected virtual void OOIHNJHMBMC()
	{
		drawType = DrawGizmosType.None;
	}

	private void GLHGKDIOMNH(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = CIOLICLDNLA();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == (Location.Tavern | Location.Road | Location.Camp | Location.Farm))
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: true, CDPAMNIPPEC: true);
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH != (Season)7 || GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: true, CDPAMNIPPEC: true);
				}
			}
		}
	}

	public TilemapsInfo.UpdateTerrainPositions[] GetAllTerrainPositions()
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.AJDPNNLOGPG(location);
	}

	private void OnDestroy()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && !((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null) && !((Object)(object)TravelZonesManager.GGFJGHHHEJC == (Object)null))
		{
			TravelZonesManager.GGFJGHHHEJC.allTilemapScenes.Remove(location);
			CommonReferences.GGFJGHHHEJC.allTilemapsScenes.Remove(location);
			CommonReferences.GGFJGHHHEJC.allTilemaps.Remove(GetTilemaps(SeasonManager.EECEKHKAAIH));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(JNBGHNBALOI));
			}
		}
	}

	private IEnumerator IKOLALADOLK(Season EECEKHKAAIH)
	{
		yield return null;
		OBOHHKIEMIG(EECEKHKAAIH);
	}

	public void ActivateOnChristmasRecursively(Transform CHGOBPEDDBJ)
	{
		for (int i = 0; i < CHGOBPEDDBJ.childCount; i++)
		{
			ActivateOnChristmasRecursively(CHGOBPEDDBJ.GetChild(i));
		}
		ActivateOnWinter component = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnWinter>();
		if (Object.op_Implicit((Object)(object)component))
		{
			component.OnSeasonChanged(editorSeason);
		}
		ActivateOnSeason component2 = ((Component)CHGOBPEDDBJ).GetComponent<ActivateOnSeason>();
		if (Object.op_Implicit((Object)(object)component2))
		{
			component2.OnSeasonChanged(editorSeason);
		}
		ChangeSpriteOnSeason component3 = ((Component)CHGOBPEDDBJ).GetComponent<ChangeSpriteOnSeason>();
		if (Object.op_Implicit((Object)(object)component3))
		{
			component3.OnSeasonChanged(editorSeason);
		}
		Rock component4 = ((Component)CHGOBPEDDBJ).GetComponent<Rock>();
		if (Object.op_Implicit((Object)(object)component4))
		{
			component4.ResetSnowPhase(editorSeason);
		}
	}

	private void NKDFMFFDGKC()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			NBAEDEJPNGC();
		}
	}

	private void BFDCCOBCOBF(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = CIOLICLDNLA();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == ~(Location.Tavern | Location.Road | Location.Camp | Location.Farm))
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false, CDPAMNIPPEC: true);
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH == Season.Autumn && GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false, CDPAMNIPPEC: true);
				}
			}
		}
	}

	private void GNGADDPBJDC()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			NBAEDEJPNGC();
		}
	}

	public void JFDJPELGMIN(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = IBGBCHLIEGH();
		for (int i = 1; i < array.Length; i++)
		{
			if (commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				if (!WorldGrid.NGDDNLHKAPM(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: true);
				}
				else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: false, JPLINFIKAJI: false, OPEEJDDDPLD: true);
				}
			}
		}
	}

	public void FBECLEHAOEA()
	{
		BIIGJFECGIA(((Component)this).transform);
	}

	public TilemapGroup GetTilemaps(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.SeasonToCropSeason(EECEKHKAAIH)))
			{
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSpring;
				case Season.Summer:
					return tilemapsSummer;
				case Season.Autumn:
					return tilemapsAutumn;
				case Season.Winter:
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Summer && hasSeasonsMaps.HasFlag(CropSeason.Summer))
			{
				return tilemapsSummer;
			}
			if (editorSeason == Season.Autumn && hasSeasonsMaps.HasFlag(CropSeason.Autumn))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == Season.Winter && hasSeasonsMaps.HasFlag(CropSeason.Winter))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	private IEnumerator BHNFCEIDIPD(Season EECEKHKAAIH)
	{
		updatingTerrain = true;
		yield return null;
		Vector3Int[] positionsToCalculate = GetAllPositionsToCalculate();
		TimerHelper timer = new TimerHelper();
		for (int i = 0; i < positionsToCalculate.Length; i++)
		{
			if (!commonTilemaps.functionalTilemap.HasTile(positionsToCalculate[i]))
			{
				continue;
			}
			Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(positionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true);
			}
			else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
			if (updateTerrainForEachWorldTile)
			{
				WorldGrid.MBDKGAIDBDD(ILDEFBIANKO, val, this, EECEKHKAAIH);
			}
			if (timer.GetMillisecs() > 50f)
			{
				if (applyChangeSeasonTerrain && location == Location.Road)
				{
					TitleScreen.GetInstance().allTerrainUpdatedProgress = (float)i / (float)positionsToCalculate.Length;
				}
				timer.Reset();
				if (!TilemapsInfo.AEALFCKBGKM(location) || GameManager.LocalCoop())
				{
					yield return null;
				}
			}
		}
		if (gameSeason != EECEKHKAAIH)
		{
			gameSeason = EECEKHKAAIH;
			if (applyChangeSeasonTerrain && !hasSeasonsMaps.HasFlag(SeasonManager.SeasonToCropSeason(EECEKHKAAIH)))
			{
				yield return ((MonoBehaviour)this).StartCoroutine(FJFFJHCMGKI(EECEKHKAAIH));
			}
		}
		else if (location == Location.Road)
		{
			TitleScreen.GetInstance().allTerrainUpdatedProgress = 1f;
			TitleScreen.GetInstance().allTerrainUpdated = true;
		}
		updatingTerrain = false;
	}

	protected virtual void DADPOICMNPI()
	{
		drawType = DrawGizmosType.PathNodes;
	}

	public static List<Vector3Int> NLLNKGEFHHG(Transform CBNBHOHFKMF, Transform NJMCDGFPCAG, TilemapGroup IOKGALBEILM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3Int> list = new List<Vector3Int>();
		Vector3Int val = ((GridLayout)IOKGALBEILM.floorUpperTilemap).WorldToCell(CBNBHOHFKMF.position);
		Vector3Int val2 = ((GridLayout)IOKGALBEILM.floorUpperTilemap).WorldToCell(NJMCDGFPCAG.position);
		int num = Math.Sign(((Vector3Int)(ref val2)).x - ((Vector3Int)(ref val)).x);
		int num2 = Math.Sign(((Vector3Int)(ref val2)).y - ((Vector3Int)(ref val)).y);
		Vector3Int item = default(Vector3Int);
		((Vector3Int)(ref item)).z = ((Vector3Int)(ref val)).z;
		for (int i = ((Vector3Int)(ref val)).x; i != ((Vector3Int)(ref val2)).x + num; i += num)
		{
			for (int j = ((Vector3Int)(ref val)).y; j != ((Vector3Int)(ref val2)).y + num2; j += num2)
			{
				((Vector3Int)(ref item)).x = i;
				((Vector3Int)(ref item)).y = j;
				list.Add(item);
			}
		}
		return list;
	}

	public static List<Vector3Int> CalculateAllPositions(Transform CBNBHOHFKMF, Transform NJMCDGFPCAG, TilemapGroup IOKGALBEILM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3Int> list = new List<Vector3Int>();
		Vector3Int val = ((GridLayout)IOKGALBEILM.floorUpperTilemap).WorldToCell(CBNBHOHFKMF.position);
		Vector3Int val2 = ((GridLayout)IOKGALBEILM.floorUpperTilemap).WorldToCell(NJMCDGFPCAG.position);
		int num = Math.Sign(((Vector3Int)(ref val2)).x - ((Vector3Int)(ref val)).x);
		int num2 = Math.Sign(((Vector3Int)(ref val2)).y - ((Vector3Int)(ref val)).y);
		Vector3Int item = default(Vector3Int);
		((Vector3Int)(ref item)).z = ((Vector3Int)(ref val)).z;
		for (int i = ((Vector3Int)(ref val)).x; i != ((Vector3Int)(ref val2)).x + num; i += num)
		{
			for (int j = ((Vector3Int)(ref val)).y; j != ((Vector3Int)(ref val2)).y + num2; j += num2)
			{
				((Vector3Int)(ref item)).x = i;
				((Vector3Int)(ref item)).y = j;
				list.Add(item);
			}
		}
		return list;
	}

	private void FHKMEGJMLEG()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	private void HEGNINLLINP()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && !((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null) && !((Object)(object)TravelZonesManager.CFHEJAGKIII() == (Object)null))
		{
			TravelZonesManager.CFHEJAGKIII().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemaps.Remove(OEMIKEDPIKP(SeasonManager.EEGJBDCBKFD()));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GECFJNDNMGK));
			}
		}
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.ClientOnline() && gameSeason != SeasonManager.EECEKHKAAIH)
		{
			gameSeason = SeasonManager.EECEKHKAAIH;
			if (applyChangeSeasonTerrain && !hasSeasonsMaps.HasFlag(SeasonManager.ACNAHALFEBG))
			{
				((MonoBehaviour)this).StartCoroutine(FJFFJHCMGKI(SeasonManager.EECEKHKAAIH));
			}
		}
		NDMIDANMPDD();
	}

	protected virtual void KHONOODGLBI()
	{
		drawType = DrawGizmosType.PathNodes;
	}

	private void JPHEOLEEAPB()
	{
		if (!TestQualityPCSettings.instance.active)
		{
			NBAEDEJPNGC();
		}
	}

	private void JNJCCIFIKOC()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && !((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null) && !((Object)(object)TravelZonesManager.EKDNJDJHONF() == (Object)null))
		{
			TravelZonesManager.DCAEBALADIM().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemaps.Remove(OEMIKEDPIKP(SeasonManager.EECEKHKAAIH));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(GECFJNDNMGK));
			}
		}
	}

	private void JMFAHLJNMAD(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(PDJOEHHFKCC(EECEKHKAAIH));
	}

	public TilemapGroup BNMLDAPCNKF(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.SeasonToCropSeason(EECEKHKAAIH)))
			{
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSpring;
				case Season.Summer:
					return tilemapsSummer;
				case Season.Autumn:
					return tilemapsAutumn;
				case (Season)6:
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Summer && hasSeasonsMaps.HasFlag(CropSeason.Winter))
			{
				return tilemapsSummer;
			}
			if (editorSeason == (Season)7 && hasSeasonsMaps.HasFlag(CropSeason.Summer))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == (Season)8 && hasSeasonsMaps.HasFlag(CropSeason.Spring | CropSeason.Summer))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	private void COCLDJDCKPM(Season EECEKHKAAIH)
	{
		if (refreshMap)
		{
			if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnNewGameCreated = (Action)Delegate.Combine(gameManager.OnNewGameCreated, new Action(JKFDJKAJFBA));
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(EFBEKNLOILH));
			}
			else if (location != 0)
			{
				((MonoBehaviour)this).StartCoroutine(OKCNMEMLDOD(EECEKHKAAIH));
			}
		}
	}

	private void MGOJFCLHJBC(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	private void GECFJNDNMGK(Season EECEKHKAAIH)
	{
		if (refreshMap)
		{
			if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnNewGameCreated = (Action)Delegate.Combine(gameManager.OnNewGameCreated, new Action(NADOCEEBICL));
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			else if (location != 0)
			{
				((MonoBehaviour)this).StartCoroutine(LBPDABKGJML(EECEKHKAAIH));
			}
		}
	}

	public TilemapsInfo.UpdateTerrainPositions[] LBLBDPDLPOM()
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.KNAGIBCOCEE(location);
	}

	public void ResetPathNodesList()
	{
		PathNodesManager.ResetPathNodesList();
	}

	private void EFJNBPKMCGJ(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.BarnInterior))
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: true, CDPAMNIPPEC: true);
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH != (Season)5 || GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false);
				}
			}
		}
	}

	private void AJGPMBGBPGH()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && !((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null) && !((Object)(object)TravelZonesManager.OLHBLKIAFOM() == (Object)null))
		{
			TravelZonesManager.LKOABOAADCD().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.GGFJGHHHEJC.allTilemaps.Remove(OEMIKEDPIKP(SeasonManager.PJMGHIMKFJL()));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PEMEHGOEIFB));
			}
		}
	}

	public void OKGEDBDIBFD(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i++)
		{
			if (commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				if (!WorldGrid.NGDDNLHKAPM(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: true);
				}
				else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
				}
			}
		}
	}

	public void CreateWorldTiles(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			if (commonTilemaps.functionalTilemap.HasTile(allPositionsToCalculate[i]))
			{
				Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
				if (!WorldGrid.NGDDNLHKAPM(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true);
				}
				else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
				}
			}
		}
	}

	private void GHJPMAJCGDN(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == (Location.River | Location.Farm | Location.FarmShop))
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps));
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH != (Season)8 || GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps));
				}
			}
		}
	}

	public void LNGBBFLFJAL()
	{
		IAKBJEOHFGD(((Component)this).transform);
	}

	public TilemapsInfo.UpdateTerrainPositions[] DJMDKLEANNC()
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.HIMIFOPINJF(location);
	}

	private IEnumerator PDJOEHHFKCC(Season EECEKHKAAIH)
	{
		yield return null;
		OBOHHKIEMIG(EECEKHKAAIH);
	}

	private IEnumerator PNLBONHIJMJ(Season EECEKHKAAIH)
	{
		LMPOMIAGCAE = GetAllTerrainPositions();
		if (LMPOMIAGCAE == null || LMPOMIAGCAE.Length == 0)
		{
			GEIFPPHMBFI = GetAllPositionsToCalculate();
		}
		DHNGOPCEPLJ = GetTilemaps(EECEKHKAAIH).seasonTilemaps;
		IMLDGBFPEMA = new TimerHelper();
		if (LMPOMIAGCAE != null && LMPOMIAGCAE.Length != 0)
		{
			for (int i = 0; i < LMPOMIAGCAE.Length; i++)
			{
				for (int k = 0; k < LMPOMIAGCAE[i].positions.Count; k++)
				{
					WorldGrid.CGNOAFNBEAO(DHNGOPCEPLJ[i], LMPOMIAGCAE[i].positions[k], EECEKHKAAIH, editorSeason);
				}
				if (IMLDGBFPEMA.GetMillisecs() > 50f)
				{
					IMLDGBFPEMA.Reset();
					if (Application.isPlaying && (GameManager.LocalCoop() || !TilemapsInfo.AEALFCKBGKM(location)))
					{
						yield return null;
					}
				}
			}
		}
		else
		{
			for (int i = 0; i < GEIFPPHMBFI.Length; i++)
			{
				for (int l = 0; l < DHNGOPCEPLJ.Length; l++)
				{
					if (DHNGOPCEPLJ[l].HasTile(GEIFPPHMBFI[i]))
					{
						WorldGrid.CGNOAFNBEAO(DHNGOPCEPLJ[l], GEIFPPHMBFI[i], EECEKHKAAIH, editorSeason);
					}
				}
				if (IMLDGBFPEMA.GetMillisecs() > 50f)
				{
					IMLDGBFPEMA.Reset();
					if (Application.isPlaying && (GameManager.LocalCoop() || !TilemapsInfo.AEALFCKBGKM(location)))
					{
						yield return null;
					}
				}
			}
		}
		if (location == Location.Road && Object.op_Implicit((Object)(object)TitleScreen.GetInstance()))
		{
			TitleScreen.GetInstance().allTerrainUpdated = true;
		}
	}

	public void KGLBEGCLJNB(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i += 0)
		{
			if (commonTilemaps.functionalTilemap.HasTile(allPositionsToCalculate[i]))
			{
				Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
				if (!WorldGrid.NGDDNLHKAPM(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true);
				}
				else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: false, JPLINFIKAJI: true);
				}
			}
		}
	}

	protected virtual void AGELAMLCINB()
	{
		drawType = DrawGizmosType.PathNodes;
	}

	public GroundType CEPFCEDACNG(Vector3 IMOBLFMHKOD, bool GAFOJLKFKJA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		GroundType result = GroundType.Grass;
		TileBase val = Utils.GCGNCHFNEBJ<TileBase>(EMHLLEFBBCO(Season.Summer).floorUpperTilemap, IMOBLFMHKOD);
		if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("ReceiveChangeDrinkColorMaster") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("ReceiveShopInfoLoad")))
		{
			result = GroundType.None;
		}
		else
		{
			val = Utils.GCGNCHFNEBJ<TileBase>(GetTilemaps(Season.Summer).floorLowerTilemap, IMOBLFMHKOD);
			if ((Object)(object)val != (Object)null && ((Object)val).name.Contains("TucanEgg") && (!GAFOJLKFKJA || ((Object)val).name.ToLower().Contains("TimeLeft")))
			{
				result = GroundType.Floor;
			}
		}
		return result;
	}

	private void FJBPFOIALMK()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && !((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null) && !((Object)(object)TravelZonesManager.DGCNCEDIFOF() == (Object)null))
		{
			TravelZonesManager.DGCNCEDIFOF().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemaps.Remove(KIMMMFKFCEK(SeasonManager.KCJFCHNPIBJ()));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(COCLDJDCKPM));
			}
		}
	}

	private IEnumerator IMOBMEJBNKE(Season EECEKHKAAIH)
	{
		return new MFDLGPEBDBE(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH
		};
	}

	public TilemapGroup OEMIKEDPIKP(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.KJCNKFEICPC(EECEKHKAAIH)))
			{
				if (EECEKHKAAIH == Season.Spring)
				{
					return tilemapsSpring;
				}
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSummer;
				case (Season)8:
					return tilemapsAutumn;
				case (Season)5:
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Summer && hasSeasonsMaps.HasFlag(CropSeason.Spring))
			{
				return tilemapsSummer;
			}
			if (editorSeason == (Season)6 && hasSeasonsMaps.HasFlag(CropSeason.Winter))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == Season.Summer && hasSeasonsMaps.HasFlag(CropSeason.None))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	private IEnumerator KCEMEBILCGD(Season EECEKHKAAIH)
	{
		updatingTerrain = true;
		yield return null;
		Vector3Int[] positionsToCalculate = GetAllPositionsToCalculate();
		TimerHelper timer = new TimerHelper();
		for (int i = 0; i < positionsToCalculate.Length; i++)
		{
			if (!commonTilemaps.functionalTilemap.HasTile(positionsToCalculate[i]))
			{
				continue;
			}
			Vector3 val = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(positionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true);
			}
			else if (GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Contains(val))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, this, EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
			if (updateTerrainForEachWorldTile)
			{
				WorldGrid.MBDKGAIDBDD(ILDEFBIANKO, val, this, EECEKHKAAIH);
			}
			if (timer.GetMillisecs() > 50f)
			{
				if (applyChangeSeasonTerrain && location == Location.Road)
				{
					TitleScreen.GetInstance().allTerrainUpdatedProgress = (float)i / (float)positionsToCalculate.Length;
				}
				timer.Reset();
				if (!TilemapsInfo.AEALFCKBGKM(location) || GameManager.LocalCoop())
				{
					yield return null;
				}
			}
		}
		if (gameSeason != EECEKHKAAIH)
		{
			gameSeason = EECEKHKAAIH;
			if (applyChangeSeasonTerrain && !hasSeasonsMaps.HasFlag(SeasonManager.SeasonToCropSeason(EECEKHKAAIH)))
			{
				yield return ((MonoBehaviour)this).StartCoroutine(FJFFJHCMGKI(EECEKHKAAIH));
			}
		}
		else if (location == Location.Road)
		{
			TitleScreen.GetInstance().allTerrainUpdatedProgress = 1f;
			TitleScreen.GetInstance().allTerrainUpdated = true;
		}
		updatingTerrain = false;
	}

	private void KCAPECAMNHB(Season EECEKHKAAIH)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i++)
		{
			Vector3 iMOBLFMHKOD = ((GridLayout)commonTilemaps.functionalTilemap).CellToWorld(array[i]);
			if (WorldGrid.NGDDNLHKAPM(iMOBLFMHKOD))
			{
				if (location == (Location.River | Location.Farm))
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: true, CDPAMNIPPEC: true);
				}
				else
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, EECEKHKAAIH != (Season)4 || GameTileMaps.GGFJGHHHEJC.CheckIfThereIsSnow(iMOBLFMHKOD, snowTilemaps.snowTilemaps), BBHMAKKPFKB: false);
				}
			}
		}
	}

	private void BLLLBEOBNEI(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(BPLGLPILOCC(EECEKHKAAIH));
	}

	public TilemapGroup IAMBLEDHGDM(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.KJCNKFEICPC(EECEKHKAAIH)))
			{
				if (EECEKHKAAIH == Season.Spring)
				{
					return tilemapsSpring;
				}
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSummer;
				case (Season)7:
					return tilemapsAutumn;
				case (Season)8:
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Summer && hasSeasonsMaps.HasFlag(CropSeason.None))
			{
				return tilemapsSummer;
			}
			if (editorSeason == (Season)7 && hasSeasonsMaps.HasFlag(CropSeason.Spring | CropSeason.Summer | CropSeason.Autumn))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == Season.Spring && hasSeasonsMaps.HasFlag(CropSeason.Spring | CropSeason.Autumn))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	private void JNBGHNBALOI(Season EECEKHKAAIH)
	{
		if (refreshMap)
		{
			if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnNewGameCreated = (Action)Delegate.Combine(instance.OnNewGameCreated, new Action(NADOCEEBICL));
				GameManager instance2 = GameManager.GGFJGHHHEJC;
				instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
			else if (location != Location.Tavern)
			{
				((MonoBehaviour)this).StartCoroutine(KCEMEBILCGD(EECEKHKAAIH));
			}
		}
	}

	public Vector3Int[] GetAllPositionsToCalculate()
	{
		if (refreshMap && CommonReferences.GGFJGHHHEJC.tilemapsInfo.allPositions.ContainsKey(location))
		{
			return CommonReferences.GGFJGHHHEJC.tilemapsInfo.allPositions[location];
		}
		return (Vector3Int[])(object)new Vector3Int[0];
	}

	public void ChangeSeasonAllObjects()
	{
		ActivateOnChristmasRecursively(((Component)this).transform);
	}

	public TilemapGroup KIMMMFKFCEK(Season EECEKHKAAIH = Season.Spring)
	{
		if (Application.isPlaying)
		{
			if (hasSeasonsMaps.HasFlag(SeasonManager.GGALEPCMBID(EECEKHKAAIH)))
			{
				switch (EECEKHKAAIH)
				{
				case Season.Spring:
					return tilemapsSpring;
				case Season.Summer:
					return tilemapsSummer;
				case Season.Autumn:
					return tilemapsAutumn;
				case (Season)8:
					return tilemapsWinter;
				}
			}
		}
		else
		{
			if (editorSeason == Season.Spring)
			{
				return tilemapsSpring;
			}
			if (editorSeason == Season.Spring && hasSeasonsMaps.HasFlag(CropSeason.Summer))
			{
				return tilemapsSummer;
			}
			if (editorSeason == (Season)8 && hasSeasonsMaps.HasFlag(CropSeason.Summer))
			{
				return tilemapsAutumn;
			}
			if (editorSeason == Season.Spring && hasSeasonsMaps.HasFlag(CropSeason.Winter))
			{
				return tilemapsWinter;
			}
		}
		return tilemapsSpring;
	}

	private void KFDKAGOHCFD()
	{
		Utils.OACPIEGCCCO(drawType, location, (this is BarnTilemapScene barnTilemapScene) ? barnTilemapScene.barnLevel : (-1));
	}

	private IEnumerator OKCNMEMLDOD(Season EECEKHKAAIH)
	{
		return new KHEEBIHANBH(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH
		};
	}

	private void NKGMEMEACNN()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && !((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null) && !((Object)(object)TravelZonesManager.GGFJGHHHEJC == (Object)null))
		{
			TravelZonesManager.OLHBLKIAFOM().allTilemapScenes.Remove(location);
			CommonReferences.MNFMOEKMJKN().allTilemapsScenes.Remove(location);
			CommonReferences.GGFJGHHHEJC.allTilemaps.Remove(EMHLLEFBBCO(SeasonManager.EECEKHKAAIH));
			if (Object.op_Implicit((Object)(object)SeasonManager.instance))
			{
				SeasonManager instance = SeasonManager.instance;
				instance.OnSeasonChanged = (Action<Season>)Delegate.Remove(instance.OnSeasonChanged, new Action<Season>(PEMEHGOEIFB));
			}
		}
	}

	private void IJHMHHHLPKO()
	{
		if (OnlineManager.ClientOnline() && gameSeason != SeasonManager.EECEKHKAAIH)
		{
			gameSeason = SeasonManager.EEGJBDCBKFD();
			if (applyChangeSeasonTerrain && !hasSeasonsMaps.HasFlag(SeasonManager.ACNAHALFEBG))
			{
				((MonoBehaviour)this).StartCoroutine(PNLBONHIJMJ(SeasonManager.ADEICKHEPFI()));
			}
		}
		NDMIDANMPDD();
	}

	private void JMFFOIHPOAH(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	private void LBPFPIMHJMN()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(IJHMHHHLPKO));
		GameManager gameManager2 = GameManager.NJNFHEPLEHL();
		gameManager2.OnNewGameCreated = (Action)Delegate.Remove(gameManager2.OnNewGameCreated, new Action(JKFDJKAJFBA));
	}

	public void LJOCFDPBOCG()
	{
		PathNodesManager.CGGHBEKPOPI();
	}

	private void NADOCEEBICL()
	{
		NDMIDANMPDD();
		if (refreshMap)
		{
			((MonoBehaviour)this).StartCoroutine(KCEMEBILCGD(SeasonManager.EECEKHKAAIH));
		}
	}

	public Vector3Int[] CIOLICLDNLA()
	{
		if (refreshMap && CommonReferences.GGFJGHHHEJC.tilemapsInfo.allPositions.ContainsKey(location))
		{
			return CommonReferences.MNFMOEKMJKN().tilemapsInfo.allPositions[location];
		}
		return (Vector3Int[])(object)new Vector3Int[0];
	}

	public TilemapsInfo.UpdateTerrainPositions[] EIJADBLFBAJ()
	{
		return CommonReferences.MNFMOEKMJKN().tilemapsInfo.AMHIDHEHCMJ(location);
	}

	private void CCHJPPEHMMB(Tilemap GAFHNGLHCPG, Tilemap AEGIODEOOIJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GAFHNGLHCPG == (Object)null || (Object)(object)AEGIODEOOIJ == (Object)null)
		{
			return;
		}
		BoundsInt cellBounds = GAFHNGLHCPG.cellBounds;
		PositionEnumerator allPositionsWithin = ((BoundsInt)(ref cellBounds)).allPositionsWithin;
		PositionEnumerator enumerator = ((PositionEnumerator)(ref allPositionsWithin)).GetEnumerator();
		try
		{
			while (((PositionEnumerator)(ref enumerator)).MoveNext())
			{
				Vector3Int current = ((PositionEnumerator)(ref enumerator)).Current;
				if (GAFHNGLHCPG.HasTile(current))
				{
					AEGIODEOOIJ.SetTile(current, GAFHNGLHCPG.GetTile(current));
					AEGIODEOOIJ.SetTransformMatrix(current, GAFHNGLHCPG.GetTransformMatrix(current));
				}
				else
				{
					AEGIODEOOIJ.SetTile(current, (TileBase)null);
				}
			}
		}
		finally
		{
			((IDisposable)(PositionEnumerator)(ref enumerator)).Dispose();
		}
	}

	public TilemapsInfo.UpdateTerrainPositions[] FELECIKEBHA()
	{
		return CommonReferences.GGFJGHHHEJC.tilemapsInfo.EBDMIJLDIKF(location);
	}

	private void JMGKHFPLJPE(Season EECEKHKAAIH)
	{
		((MonoBehaviour)this).StartCoroutine(PDJOEHHFKCC(EECEKHKAAIH));
	}

	public Vector3Int[] IBGBCHLIEGH()
	{
		if (refreshMap && CommonReferences.GGFJGHHHEJC.tilemapsInfo.allPositions.ContainsKey(location))
		{
			return CommonReferences.GGFJGHHHEJC.tilemapsInfo.allPositions[location];
		}
		return (Vector3Int[])(object)new Vector3Int[1];
	}

	private IEnumerator GJJFHJBAENE(Season EECEKHKAAIH)
	{
		return new KHEEBIHANBH(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH
		};
	}
}
