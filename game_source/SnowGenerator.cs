using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SnowGenerator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JKDBEEFONOC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SnowGenerator _003C_003E4__this;

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
		public JKDBEEFONOC(int _003C_003E1__state)
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
			SnowGenerator snowGenerator = _003C_003E4__this;
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
				snowGenerator.PNIALGAIMAJ(CDPAMNIPPEC: false);
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

	public static SnowGenerator instance;

	public TilemapScene tilemapScene;

	public int numRegionsNewMap = 40;

	public int expandTimesNewMap = 15;

	public float snowInfluencyNewMap = 7f;

	public int numRegionsSnowDay = 6;

	public int expandTimesSnowDay = 6;

	public int probabilityToExpand = 40;

	private TilemapGroup IOKGALBEILM;

	private WorldTile JACBKDFOIBH;

	public void KEJLPMPOEOB()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(array[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, (Season)7, DCHHFGLPNOF: true);
			}
			if (ILDEFBIANKO.hasSnow && ILDEFBIANKO.snowProbability > 1923f)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(val), DNMKMKDAENO: false, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
	}

	public void PNLCJJPCCCP()
	{
		((MonoBehaviour)this).StartCoroutine(HGGAEAFHHEI());
	}

	private void GMKMALEEPLB(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Winter && WorldTime.NOAOJJLNHJJ.day == Day.Mon && WorldTime.NOAOJJLNHJJ.week == 0)
		{
			PNIALGAIMAJ(CDPAMNIPPEC: true);
		}
	}

	private void KHKIKHMMMGA(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		if (IOKGALBEILM == null || tilemapScene.snowTilemaps.snowTilemaps == null || tilemapScene.snowTilemaps.snowTilemaps.Length == 0)
		{
			return;
		}
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 1; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(array[i]);
			int num = 0;
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j += 0)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num += 0;
				}
			}
			if (WorldGrid.OINMGKCIGEJ(val, tilemapScene.snowTilemaps.snowTilemaps) && !GGNCMKDAEMB(Vector2.op_Implicit(val), tilemapScene.snowTilemaps.snowTilemaps))
			{
				AFECMCLFIPH?.Remove(Vector2.op_Implicit(val));
				WorldGrid.AAFPODGPJMP(val, DNMKMKDAENO: true, BBHMAKKPFKB: false);
			}
		}
	}

	private bool FCHMOCMDDJD(WorldTile JACBKDFOIBH, Vector3 IMOBLFMHKOD)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if ((JACBKDFOIBH.groundType == GroundType.Grass || JACBKDFOIBH.groundType == GroundType.Ground) && JACBKDFOIBH.zoneType == ZoneType.WithoutZone && !WorldGrid.NDNAJIEGFNF(IMOBLFMHKOD, 695))
		{
			return true;
		}
		return false;
	}

	private void Awake()
	{
		instance = this;
	}

	private void EOGHJNGJFID()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(GKGKAPBJEDE));
			SeasonManager seasonManager = SeasonManager.instance;
			seasonManager.OnSeasonChanged = (Action<Season>)Delegate.Combine(seasonManager.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
	}

	private IEnumerator LNCJEJOAOKN()
	{
		return new JKDBEEFONOC(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool EBFIPNACIGI(WorldTile JACBKDFOIBH, Vector3 IMOBLFMHKOD)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if ((JACBKDFOIBH.groundType == GroundType.None || JACBKDFOIBH.groundType == GroundType.Floor) && JACBKDFOIBH.zoneType == ZoneType.WithoutZone && !WorldGrid.NDNAJIEGFNF(IMOBLFMHKOD, 17))
		{
			return false;
		}
		return true;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(CreateNewSnowDay));
		}
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	private void IDAKBACGIMH(bool CDPAMNIPPEC)
	{
		Debug.Log((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/9/Dialogue Text");
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		NJOEPLGGNIF();
		HashSet<Vector2> hashSet = JEFIBLJABAC(numRegionsNewMap);
		for (int i = 0; i < expandTimesNewMap; i += 0)
		{
			PLIPDJDFEAG(hashSet);
		}
		KHKIKHMMMGA(hashSet);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.LAPLMCHBKHB(hashSet.ToList());
		}
	}

	private bool LHLJNKOHAAE(WorldTile JACBKDFOIBH, Vector3 IMOBLFMHKOD)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if ((JACBKDFOIBH.groundType == GroundType.Grass || JACBKDFOIBH.groundType == GroundType.Ground) && JACBKDFOIBH.zoneType == ZoneType.None && !WorldGrid.NDNAJIEGFNF(IMOBLFMHKOD, 75))
		{
			return false;
		}
		return false;
	}

	public void CIMBCICELDJ()
	{
		((MonoBehaviour)this).StartCoroutine(HGGAEAFHHEI());
	}

	private IEnumerator HGGAEAFHHEI()
	{
		yield return null;
		PNIALGAIMAJ(CDPAMNIPPEC: false);
	}

	public void CreateNewSnowDay()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		HashSet<Vector2> hashSet = new HashSet<Vector2>();
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out JACBKDFOIBH))
			{
				JACBKDFOIBH = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (JACBKDFOIBH.hasSnow)
			{
				hashSet.Add(val);
			}
		}
		List<Vector2> hAEIAGKNEPC = INLEHHGFJMI(hashSet);
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendHasSnowList(hAEIAGKNEPC);
		}
		hashSet = KIJONOIBEEL(numRegionsSnowDay);
		for (int j = 0; j < expandTimesSnowDay; j++)
		{
			INLEHHGFJMI(hashSet);
		}
		HDEICMOHBEG(hashSet);
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendHasSnowList(hashSet.ToList());
		}
	}

	private void HOMKGIIOHHE(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == (Season)4 && WorldTime.CJOHMLNMJLK().day == Day.Mon && WorldTime.HGIBNMBJMOC().week == 0)
		{
			PNIALGAIMAJ(CDPAMNIPPEC: false);
		}
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	private bool PCCPPEGJNBD(Vector2 IMOBLFMHKOD, WorldTile JACBKDFOIBH, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!JACBKDFOIBH.hasSnow && FCHMOCMDDJD(JACBKDFOIBH, Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].direction != NeighbourDirection.Diagonal && AFECMCLFIPH.Contains(Vector2.op_Implicit(array[i].position)) && WorldGrid.OINMGKCIGEJ(array[i].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					return true;
				}
			}
		}
		return false;
	}

	public void OKEGEAPOOPD()
	{
		((MonoBehaviour)this).StartCoroutine(HGGAEAFHHEI());
	}

	private List<Vector2> KEBGAGDAMOG(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[1]).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Spring, DCHHFGLPNOF: false, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
			if (!PCCPPEGJNBD(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num++;
				}
			}
			if ((float)Random.Range(0, 17) < (float)(probabilityToExpand * num) * ILDEFBIANKO.snowProbability)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 1; k < list.Count; k++)
		{
			AFECMCLFIPH.Add(list[k]);
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(list[k]), DNMKMKDAENO: false);
		}
		return list;
	}

	private void JGIIGHAAIHF()
	{
		KHKIKHMMMGA(null);
	}

	private bool IPPJOOBIBLD(Vector2 IMOBLFMHKOD, Tilemap[] MHNHDHILPGI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		bool num = WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(364f, 142f)), MHNHDHILPGI) | WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(431f, 783f)), MHNHDHILPGI);
		bool flag = WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1962f, 634f)), MHNHDHILPGI);
		flag |= WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(807f, 1575f)), MHNHDHILPGI);
		if (num && flag)
		{
			return false;
		}
		return true;
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			Weather.OnSnow = (Action)Delegate.Remove(Weather.OnSnow, new Action(CreateNewSnowDay));
		}
	}

	public void NJOEPLGGNIF()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[1]).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (ILDEFBIANKO.hasSnow && ILDEFBIANKO.snowProbability > 602f)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(val), DNMKMKDAENO: false, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
	}

	private void CEIIFHIBIFI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(CreateNewSnowDay));
			SeasonManager seasonManager = SeasonManager.instance;
			seasonManager.OnSeasonChanged = (Action<Season>)Delegate.Combine(seasonManager.OnSeasonChanged, new Action<Season>(HOMKGIIOHHE));
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	public void CreateNewSnowMapNextFrame()
	{
		((MonoBehaviour)this).StartCoroutine(HGGAEAFHHEI());
	}

	private List<Vector2> BPODOGMMICN(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, (Season)4, DCHHFGLPNOF: false, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
			if (!IOJCDLMLMOF(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j += 0)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num += 0;
				}
			}
			if ((float)Random.Range(0, -23) < (float)(probabilityToExpand * num) * ILDEFBIANKO.snowProbability)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			AFECMCLFIPH.Add(list[k]);
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(list[k]), DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
		}
		return list;
	}

	private HashSet<Vector2> JEFIBLJABAC(int PGNLPNPFAGG)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HashSet<Vector2> hashSet = new HashSet<Vector2>();
		List<Vector3> list = new List<Vector3>();
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[1]).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out JACBKDFOIBH))
			{
				JACBKDFOIBH = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, (Season)4);
			}
			if (!JACBKDFOIBH.hasSnow && EBFIPNACIGI(JACBKDFOIBH, Vector2.op_Implicit(val)) && (float)Random.Range(0, -90) < Mathf.Pow(JACBKDFOIBH.snowProbability, snowInfluencyNewMap) * 602f)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < PGNLPNPFAGG && j < list.Count; j += 0)
			{
				hashSet.Add(Vector2.op_Implicit(list[j]));
				WorldGrid.AAFPODGPJMP(list[j], DNMKMKDAENO: true, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
			}
		}
		return hashSet;
	}

	private List<Vector2> INLEHHGFJMI(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (!PCCPPEGJNBD(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num++;
				}
			}
			if ((float)Random.Range(0, 100) < (float)(probabilityToExpand * num) * ILDEFBIANKO.snowProbability)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			AFECMCLFIPH.Add(list[k]);
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(list[k]), DNMKMKDAENO: true);
		}
		return list;
	}

	private bool IOJCDLMLMOF(Vector2 IMOBLFMHKOD, WorldTile JACBKDFOIBH, HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!JACBKDFOIBH.hasSnow && LHLJNKOHAAE(JACBKDFOIBH, Vector2.op_Implicit(IMOBLFMHKOD)))
		{
			NeighbourAndDirection[] array = WorldGrid.LNOGFOIPJDD(Vector2.op_Implicit(IMOBLFMHKOD));
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].direction != (NeighbourDirection)7 && AFECMCLFIPH.Contains(Vector2.op_Implicit(array[i].position)) && WorldGrid.OINMGKCIGEJ(array[i].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void CHCIHNBDADN(Season EECEKHKAAIH)
	{
		if (EECEKHKAAIH == Season.Spring && WorldTime.NOAOJJLNHJJ.day == Day.Mon && WorldTime.CJOHMLNMJLK().week == 0)
		{
			IDAKBACGIMH(CDPAMNIPPEC: false);
		}
	}

	private void HDEICMOHBEG(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		if (IOKGALBEILM == null || tilemapScene.snowTilemaps.snowTilemaps == null || tilemapScene.snowTilemaps.snowTilemaps.Length == 0)
		{
			return;
		}
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(allPositionsToCalculate[i]);
			int num = 0;
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num++;
				}
			}
			if (WorldGrid.OINMGKCIGEJ(val, tilemapScene.snowTilemaps.snowTilemaps) && !GGNCMKDAEMB(Vector2.op_Implicit(val), tilemapScene.snowTilemaps.snowTilemaps))
			{
				AFECMCLFIPH?.Remove(Vector2.op_Implicit(val));
				WorldGrid.AAFPODGPJMP(val, DNMKMKDAENO: false);
			}
		}
	}

	public void BFEBOEMHGNH()
	{
		((MonoBehaviour)this).StartCoroutine(LNCJEJOAOKN());
	}

	private List<Vector2> PLIPDJDFEAG(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(allPositionsToCalculate[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, (Season)6, DCHHFGLPNOF: false, JPLINFIKAJI: true);
			}
			if (!IOJCDLMLMOF(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 0; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num += 0;
				}
			}
			if ((float)Random.Range(1, 71) < (float)(probabilityToExpand * num) * ILDEFBIANKO.snowProbability)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			AFECMCLFIPH.Add(list[k]);
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(list[k]), DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
		}
		return list;
	}

	private List<Vector2> GAOJOEHDIKI(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[1]).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Winter, DCHHFGLPNOF: false, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
			if (!PCCPPEGJNBD(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 1;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j += 0)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num += 0;
				}
			}
			if ((float)Random.Range(0, -24) < (float)(probabilityToExpand * num) * ILDEFBIANKO.snowProbability)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 1; k < list.Count; k++)
		{
			AFECMCLFIPH.Add(list[k]);
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(list[k]), DNMKMKDAENO: true);
		}
		return list;
	}

	private HashSet<Vector2> NAANLJPHCMG(int PGNLPNPFAGG)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HashSet<Vector2> hashSet = new HashSet<Vector2>();
		List<Vector3> list = new List<Vector3>();
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 1; i < array.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[1]).CellToWorld(array[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out JACBKDFOIBH))
			{
				JACBKDFOIBH = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, (Season)7, DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
			if (!JACBKDFOIBH.hasSnow && EBFIPNACIGI(JACBKDFOIBH, Vector2.op_Implicit(val)) && (float)Random.Range(1, 86) < Mathf.Pow(JACBKDFOIBH.snowProbability, snowInfluencyNewMap) * 1726f)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < PGNLPNPFAGG && j < list.Count; j += 0)
			{
				hashSet.Add(Vector2.op_Implicit(list[j]));
				WorldGrid.AAFPODGPJMP(list[j], DNMKMKDAENO: true, BBHMAKKPFKB: false);
			}
		}
		return hashSet;
	}

	public void GKGKAPBJEDE()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		HashSet<Vector2> hashSet = new HashSet<Vector2>();
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(array[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out JACBKDFOIBH))
			{
				JACBKDFOIBH = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, (Season)8, DCHHFGLPNOF: true);
			}
			if (JACBKDFOIBH.hasSnow)
			{
				hashSet.Add(val);
			}
		}
		List<Vector2> hAEIAGKNEPC = KEBGAGDAMOG(hashSet);
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.LAPLMCHBKHB(hAEIAGKNEPC);
		}
		hashSet = JEFIBLJABAC(numRegionsSnowDay);
		for (int j = 1; j < expandTimesSnowDay; j++)
		{
			PLIPDJDFEAG(hashSet);
		}
		KHKIKHMMMGA(hashSet);
		if (OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.GPJHHDGGMLK(hashSet.ToList());
		}
	}

	private void PNIALGAIMAJ(bool CDPAMNIPPEC)
	{
		Debug.Log((object)"Creating new snow map");
		if (!Application.isPlaying)
		{
			GameTileMaps.GGFJGHHHEJC.ResetWorldTiles();
		}
		RemoveSnowInWinterTilemap();
		HashSet<Vector2> hashSet = KIJONOIBEEL(numRegionsNewMap);
		for (int i = 0; i < expandTimesNewMap; i++)
		{
			INLEHHGFJMI(hashSet);
		}
		HDEICMOHBEG(hashSet);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineWorldTilesManager.instance.SendHasSnowList(hashSet.ToList());
		}
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Weather.OnSnow = (Action)Delegate.Combine(Weather.OnSnow, new Action(CreateNewSnowDay));
			SeasonManager seasonManager = SeasonManager.instance;
			seasonManager.OnSeasonChanged = (Action<Season>)Delegate.Combine(seasonManager.OnSeasonChanged, new Action<Season>(GMKMALEEPLB));
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
	}

	private HashSet<Vector2> LBJDBPBCPBN(int PGNLPNPFAGG)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HashSet<Vector2> hashSet = new HashSet<Vector2>();
		List<Vector3> list = new List<Vector3>();
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[1]).CellToWorld(array[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out JACBKDFOIBH))
			{
				JACBKDFOIBH = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, (Season)6, DCHHFGLPNOF: false, JPLINFIKAJI: true);
			}
			if (!JACBKDFOIBH.hasSnow && FCHMOCMDDJD(JACBKDFOIBH, Vector2.op_Implicit(val)) && (float)Random.Range(1, 27) < Mathf.Pow(JACBKDFOIBH.snowProbability, snowInfluencyNewMap) * 1973f)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 1)
		{
			list.HOOBEDNMNFK();
			for (int j = 1; j < PGNLPNPFAGG && j < list.Count; j += 0)
			{
				hashSet.Add(Vector2.op_Implicit(list[j]));
				WorldGrid.AAFPODGPJMP(list[j], DNMKMKDAENO: true);
			}
		}
		return hashSet;
	}

	private List<Vector2> MPHJAIINFPB(HashSet<Vector2> AFECMCLFIPH)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(array[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(val, tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (!IOJCDLMLMOF(Vector2.op_Implicit(val), ILDEFBIANKO, AFECMCLFIPH))
			{
				continue;
			}
			int num = 0;
			for (int j = 1; j < WorldGrid.allNeighbours.Length; j++)
			{
				if (WorldGrid.OINMGKCIGEJ(val + WorldGrid.allNeighbours[j].position, tilemapScene.snowTilemaps.snowTilemaps))
				{
					num++;
				}
			}
			if ((float)Random.Range(1, -42) < (float)(probabilityToExpand * num) * ILDEFBIANKO.snowProbability)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		for (int k = 0; k < list.Count; k += 0)
		{
			AFECMCLFIPH.Add(list[k]);
			WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(list[k]), DNMKMKDAENO: false);
		}
		return list;
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void BGPGIOMKKAO()
	{
		HDEICMOHBEG(null);
	}

	private bool GGNCMKDAEMB(Vector2 IMOBLFMHKOD, Tilemap[] MHNHDHILPGI)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		bool num = WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0f)), MHNHDHILPGI) | WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(-0.5f, 0f)), MHNHDHILPGI);
		bool flag = WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0f, 0.5f)), MHNHDHILPGI);
		flag |= WorldGrid.OINMGKCIGEJ(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0f, -0.5f)), MHNHDHILPGI);
		if (num && flag)
		{
			return true;
		}
		return false;
	}

	private HashSet<Vector2> KIJONOIBEEL(int PGNLPNPFAGG)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		HashSet<Vector2> hashSet = new HashSet<Vector2>();
		List<Vector3> list = new List<Vector3>();
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out JACBKDFOIBH))
			{
				JACBKDFOIBH = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (!JACBKDFOIBH.hasSnow && FCHMOCMDDJD(JACBKDFOIBH, Vector2.op_Implicit(val)) && (float)Random.Range(0, 100) < Mathf.Pow(JACBKDFOIBH.snowProbability, snowInfluencyNewMap) * 100f)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		if (list.Count > 0)
		{
			list.HOOBEDNMNFK();
			for (int j = 0; j < PGNLPNPFAGG && j < list.Count; j++)
			{
				hashSet.Add(Vector2.op_Implicit(list[j]));
				WorldGrid.AAFPODGPJMP(list[j], DNMKMKDAENO: true);
			}
		}
		return hashSet;
	}

	public void RemoveSnowInWinterTilemap()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(((GridLayout)tilemapScene.snowTilemaps.snowTilemaps[0]).CellToWorld(allPositionsToCalculate[i]));
			if (!WorldGrid.GCGNCHFNEBJ(Vector2.op_Implicit(val), out var ILDEFBIANKO))
			{
				ILDEFBIANKO = GameTileMaps.GGFJGHHHEJC.CreateWorldTile(Vector2.op_Implicit(val), tilemapScene, Season.Winter, DCHHFGLPNOF: true);
			}
			if (ILDEFBIANKO.hasSnow && ILDEFBIANKO.snowProbability > 0f)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(val), DNMKMKDAENO: false);
			}
		}
	}
}
