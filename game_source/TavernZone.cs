using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class TavernZone
{
	[CompilerGenerated]
	private sealed class DGBAMOFKPAG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernZone _003C_003E4__this;

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
		public DGBAMOFKPAG(int _003C_003E1__state)
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
			TavernZone tavernZone = _003C_003E4__this;
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
				tavernZone.BIANBFLPPIA();
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
	private sealed class NHAACNMPMIG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernZone _003C_003E4__this;

		public bool visible;

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
		public NHAACNMPMIG(int _003C_003E1__state)
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
			TavernZone tavernZone = _003C_003E4__this;
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
				tavernZone.PNANPLFPBNP(visible);
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

	public Action<Placeable> OnPlaceableAdded = delegate
	{
	};

	public Action<Placeable> OnPlaceableRemoved = delegate
	{
	};

	public Action OnComfortCalculated = delegate
	{
	};

	public int id = -1;

	public ZoneType zoneType;

	public List<Vector2> positions;

	public List<Placeable> placeables;

	public int comfort;

	public RentedRoom rentedRoom;

	private Dictionary<Item, int> seenItems = new Dictionary<Item, int>();

	private int fishSeen;

	private int seen;

	private float comfortTemp;

	public void OKAIAEJPNAL(bool MDIKPGGBNLI)
	{
		if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && EditorTileMaps.KHFBKLDDGEG() && (Object)(object)GameplayUI.GGFJGHHHEJC != (Object)null)
		{
			((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(AGBIJBDJEMH(MDIKPGGBNLI));
		}
	}

	private void NHFLCAOFMKB(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null) && id == PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	private void PFFABENIAHA()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(3);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(GNKHHFFKLBF));
	}

	private IEnumerator FHJAELJNKBL(bool MDIKPGGBNLI)
	{
		yield return null;
		PNANPLFPBNP(MDIKPGGBNLI);
	}

	public void PFMEKKGIGED(RentedRoom GGNOAHDCPIB)
	{
		rentedRoom = GGNOAHDCPIB;
		GGNOAHDCPIB.GMBGMMIMJJD(RentedRoomsManager.AEBFCPODCNO().Count);
	}

	private IEnumerator KCMCLEJFGFA(bool MDIKPGGBNLI)
	{
		yield return null;
		PNANPLFPBNP(MDIKPGGBNLI);
	}

	private void AEBCMLMFKHP(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		FLFBDPDJMBK(JIIGOACEIKL);
	}

	private void NENMCPLBNAH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(KMCBJLHCEDE());
		}
	}

	public void CMONGPFDMDM(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < placeables.Count; i++)
		{
			if ((Object)(object)placeables[i] != (Object)null && placeables[i].isPlaceableOnWall)
			{
				if (!MDIKPGGBNLI)
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 0);
				}
				else
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, -100);
				}
			}
		}
	}

	public Vector3 LDKILLIBBPM()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 1)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(32f, 226f);
			for (int i = 1; i < positions.Count; i += 0)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[1]);
			float num = 0f - (positions[0].x - val.x) + (positions[0].y - val.y);
			for (int j = 1; j < positions.Count; j++)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)"NextToWall");
		return default(Vector3);
	}

	public void EJKHPGLJKFF(bool MDIKPGGBNLI)
	{
		if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && EditorTileMaps.HPEHHOIMMOB() && (Object)(object)GameplayUI.CMIHGBHPLFP() != (Object)null)
		{
			((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StartCoroutine(LOKAMAOJNEA(MDIKPGGBNLI));
		}
	}

	public void AKLCFEPBONI(Placeable EAPCLAODGAE)
	{
		if (placeables.Contains(EAPCLAODGAE))
		{
			placeables.Remove(EAPCLAODGAE);
			BIANBFLPPIA();
			OnPlaceableRemoved(EAPCLAODGAE);
		}
	}

	private IEnumerator LOKAMAOJNEA(bool MDIKPGGBNLI)
	{
		return new NHAACNMPMIG(1)
		{
			_003C_003E4__this = this,
			visible = MDIKPGGBNLI
		};
	}

	private IEnumerator BGMACGBLKBF()
	{
		yield return null;
		BIANBFLPPIA();
	}

	public void EHMAOFPIFNK(bool MDIKPGGBNLI)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || !EditorTileMaps.HPEHHOIMMOB() || (Object)(object)TavernConstructionManager.DEGPIHEEFHJ() == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE || (Object)(object)ConstructionViews.DEGPIHEEFHJ() == (Object)null || ConstructionViews.HJKBIPPGHJB().PIEFFJFDBFD() != 0)
		{
			CMONGPFDMDM(MDIKPGGBNLI);
			for (int i = 1; i < positions.Count; i += 0)
			{
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i])) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(836f, 69f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1219f, 1923f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(0f, 1026f))))
				{
					continue;
				}
				if (!WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i])))
				{
					if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i] + new Vector2(1412f, 1256f))))
					{
						if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(835f, 1061f))))
						{
							RentedRoomDoor rentedRoomDoor = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(436f, 1450f))) as RentedRoomDoor;
							if ((Object)(object)rentedRoomDoor != (Object)null && !rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
							{
								DecorationTile decoTile = EditorActionsDBAccessor.GetDecoTile(Utils.FJNKHMPEEKL());
								((!MDIKPGGBNLI) ? decoTile.roofTiles.DBlack : decoTile.roofTiles.D).ANEPABGFNHE(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallFrontNoColliders, 1074f, 1335f, CHLOMIOHKOI: false, ACENKKNAOMM: false);
							}
						}
					}
					else if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(positions[i] + new Vector2(891f, 1565f))))
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI);
					}
					else
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: true);
					}
				}
				if (!WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[i])))
				{
					continue;
				}
				for (float num = 1237f; num <= 1559f; num += 517f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i] + Vector2.up * num), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI);
				}
				if (MDIKPGGBNLI)
				{
					WorldGrid.JHPFHCBNIIM(Vector2.op_Implicit(positions[i]), FBOKGEPKBPO: true, Utils.FJNKHMPEEKL());
				}
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(6f, 664f))))
				{
					Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(222f, 790f)));
					if (door is RentedRoomDoor rentedRoomDoor2 && rentedRoomDoor2.rentedRoom.FKGBMIBFAGG())
					{
						door.KDFDGNKNPML(MDIKPGGBNLI);
					}
				}
			}
			return;
		}
		for (int j = 1; j < positions.Count; j++)
		{
			WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: false);
			if (WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[j])))
			{
				for (float num2 = 1843f; num2 <= 701f; num2 += 275f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j] + Vector2.up * num2), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: false);
				}
			}
		}
	}

	public Vector3 AEPELFOCLHM()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 0)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(10000f, 10000f);
			for (int i = 0; i < positions.Count; i++)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[0]);
			float num = 0f - (positions[0].x - val.x) + (positions[0].y - val.y);
			for (int j = 1; j < positions.Count; j++)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)"positions count is 0");
		return default(Vector3);
	}

	private void MNJIBIEJHEJ(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(KMCBJLHCEDE());
		}
	}

	public void ANHOOODHPKD()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(0)))
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
			playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(6)))
		{
			PlayerController playerController2 = PlayerController.OPHDCMJLLEC(6);
			playerController2.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController2.OnZoneChanged, new Action<int, ZoneType, int>(OLNKGEEDPMP));
		}
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(LJMDMPHHKMF());
		}
	}

	public Vector2 EFGNAHFCJAD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[0].x;
		float x2 = positions[1].x;
		float y = positions[0].y;
		float y2 = positions[1].y;
		for (int i = 1; i < positions.Count; i += 0)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 1858f;
	}

	private void ACNCFDLDFHA()
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	private void MBHNKOKCBOJ(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(LJMDMPHHKMF());
		}
	}

	private IEnumerator DPKGHNPLNEG(bool MDIKPGGBNLI)
	{
		return new NHAACNMPMIG(1)
		{
			_003C_003E4__this = this,
			visible = MDIKPGGBNLI
		};
	}

	public void IFLMEBGHLNE(bool MDIKPGGBNLI)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || !EditorTileMaps.KHFBKLDDGEG() || (Object)(object)TavernConstructionManager.DOIKFJDLKJP() == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE || (Object)(object)ConstructionViews.HJKBIPPGHJB() == (Object)null || ConstructionViews.CNDNOECMKME().PIEFFJFDBFD() != 0)
		{
			LABHNLIOFMN(MDIKPGGBNLI);
			for (int i = 1; i < positions.Count; i += 0)
			{
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i])) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1433f, 278f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1580f, 289f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(350f, 1719f))))
				{
					continue;
				}
				if (!WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i])))
				{
					if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i] + new Vector2(9f, 130f))))
					{
						if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1770f, 360f))))
						{
							RentedRoomDoor rentedRoomDoor = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(1157f, 587f))) as RentedRoomDoor;
							if ((Object)(object)rentedRoomDoor != (Object)null && !rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
							{
								DecorationTile decorationTile = EditorActionsDBAccessor.BNKGPJPMFCI(Utils.FJNKHMPEEKL());
								((!MDIKPGGBNLI) ? decorationTile.roofTiles.DBlack : decorationTile.roofTiles.D).DNPIGINNMBC(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallFrontNoColliders, 1404f, 26f, CHLOMIOHKOI: false, ACENKKNAOMM: false);
							}
						}
					}
					else if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(positions[i] + new Vector2(436f, 815f))))
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI);
					}
					else
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: true);
					}
				}
				if (!WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[i])))
				{
					continue;
				}
				for (float num = 584f; num <= 1435f; num += 1407f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i] + Vector2.up * num), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI);
				}
				if (MDIKPGGBNLI)
				{
					WorldGrid.JHPFHCBNIIM(Vector2.op_Implicit(positions[i]), FBOKGEPKBPO: false, Utils.FJNKHMPEEKL());
				}
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1091f, 1928f))))
				{
					Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(769f, 68f)));
					if (door is RentedRoomDoor rentedRoomDoor2 && rentedRoomDoor2.rentedRoom.FKGBMIBFAGG())
					{
						door.KDFDGNKNPML(MDIKPGGBNLI);
					}
				}
			}
			return;
		}
		for (int j = 0; j < positions.Count; j++)
		{
			WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: true);
			if (WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[j])))
			{
				for (float num2 = 1450f; num2 <= 457f; num2 += 724f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j] + Vector2.up * num2), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: false);
				}
			}
		}
	}

	public Vector2 NEKBEKCPJLP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[0].x;
		float x2 = positions[1].x;
		float y = positions[0].y;
		float y2 = positions[0].y;
		for (int i = 1; i < positions.Count; i++)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 765f;
	}

	private void PCKENPCGAHI(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		OKJFFGAOIJM(JIIGOACEIKL);
	}

	public void DIOOFIIIPAG(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 0; i < placeables.Count; i += 0)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)BKLKFNIFKHP(placeables[i]);
			}
		}
		KNICBBCBMHI();
		OnComfortCalculated();
		if (comfort > -92)
		{
			Utils.DLIIAHACOJB(66);
		}
	}

	private IEnumerator AGBIJBDJEMH(bool MDIKPGGBNLI)
	{
		yield return null;
		PNANPLFPBNP(MDIKPGGBNLI);
	}

	public void PNJIEGAOFEH(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			DMHOOBGGAPA(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public void JEBPJCIEECN(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 1; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)BKLKFNIFKHP(placeables[i]);
			}
		}
		MKFLGFNABNG();
		OnComfortCalculated();
		if (comfort > -56)
		{
			Utils.DLIIAHACOJB(69, CDPAMNIPPEC: true);
		}
	}

	public void GJJBIFPPBCB(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < placeables.Count; i += 0)
		{
			if ((Object)(object)placeables[i] != (Object)null && placeables[i].isPlaceableOnWall)
			{
				if (!MDIKPGGBNLI)
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 1);
				}
				else
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 9);
				}
			}
		}
	}

	public void LHAPMEEADKH()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(0)))
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
			playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(2)))
		{
			PlayerController playerController2 = PlayerController.OPHDCMJLLEC(8);
			playerController2.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController2.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
		}
	}

	public void MCKMMEJADKF(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 1;
		for (int i = 1; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)NGBFLDNPFLD(placeables[i]);
			}
		}
		IEDGACFMMAG();
		OnComfortCalculated();
		if (comfort > -27)
		{
			Utils.DLIIAHACOJB(48, CDPAMNIPPEC: true);
		}
	}

	private void AFNBGBMANMH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.IDIGFHEHIDM()).StartCoroutine(KMCBJLHCEDE());
		}
	}

	private void NICNOBMNMGG(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(LJMDMPHHKMF());
		}
	}

	private void IEDGACFMMAG()
	{
		IGHLFIBEGBM(0);
		if (GameManager.LocalCoop())
		{
			IPKHHCOEIFE(1);
		}
	}

	public void EIDJLHFAMIB()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(1)))
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
			playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController.OnZoneChanged, new Action<int, ZoneType, int>(OLNKGEEDPMP));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(3)))
		{
			PlayerController player = PlayerController.GetPlayer(4);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
		}
	}

	public void BKNCNOMAACH(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 1;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 1; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)AOIGBGMFKBC(placeables[i]);
			}
		}
		MKFLGFNABNG();
		OnComfortCalculated();
		if (comfort > 82)
		{
			Utils.DLIIAHACOJB(78, CDPAMNIPPEC: true);
		}
	}

	public void CMOIMCIIEDM(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, ZoneType.None);
		if (positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.PDLFLKBJGOE(IMOBLFMHKOD, ZoneType.None, -1);
			if (MEPFCAODGLH && positions.Count == 0)
			{
				TavernZonesManager.HFHPMKJGMPA().DNAKJMPFGEL(id);
			}
		}
	}

	private void AKBAMJGHLFC()
	{
		IPKHHCOEIFE(0);
		if (GameManager.LocalCoop())
		{
			BFLNCADFNFN(2);
		}
	}

	private void DJODAMFLIKA(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < placeables.Count; i++)
		{
			((Renderer)placeables[i].spriteRenderer).enabled = MDIKPGGBNLI;
			for (int j = 0; j < placeables[i].particleSystemRenderers.Length; j++)
			{
				((Renderer)placeables[i].particleSystemRenderers[j]).enabled = MDIKPGGBNLI;
			}
		}
	}

	public void FODNDCDLFPL(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	public Vector2 OJLJLPLGNKD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[0].x;
		float x2 = positions[1].x;
		float y = positions[0].y;
		float y2 = positions[1].y;
		for (int i = 1; i < positions.Count; i += 0)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 1093f;
	}

	private void ECHOEJGKPJF()
	{
		PlayerController player = PlayerController.GetPlayer(8);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
	}

	private void GELOOCLGBGH()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(GNKHHFFKLBF));
	}

	public void KKDIMAGJLCI(bool MDIKPGGBNLI)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || !EditorTileMaps.KHFBKLDDGEG() || (Object)(object)TavernConstructionManager.DEGPIHEEFHJ() == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE || (Object)(object)ConstructionViews.DEGPIHEEFHJ() == (Object)null || ConstructionViews.DEGPIHEEFHJ().JHPNOMDNNHE() != 0)
		{
			CBKLAMBGCJK(MDIKPGGBNLI);
			for (int i = 1; i < positions.Count; i += 0)
			{
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i])) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1779f, 111f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1479f, 1880f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(973f, 700f))))
				{
					continue;
				}
				if (!WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i])))
				{
					if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i] + new Vector2(396f, 1973f))))
					{
						if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1201f, 494f))))
						{
							RentedRoomDoor rentedRoomDoor = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(1214f, 1838f))) as RentedRoomDoor;
							if ((Object)(object)rentedRoomDoor != (Object)null && !rentedRoomDoor.rentedRoom.FKGBMIBFAGG())
							{
								DecorationTile decorationTile = EditorActionsDBAccessor.BNKGPJPMFCI(Utils.FJNKHMPEEKL());
								((!MDIKPGGBNLI) ? decorationTile.roofTiles.DBlack : decorationTile.roofTiles.D).HBAJILLBNOL(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontNoColliders, 835f, 1253f, CHLOMIOHKOI: true, ACENKKNAOMM: false);
							}
						}
					}
					else if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(positions[i] + new Vector2(231f, 1122f))))
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI);
					}
					else
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: false);
					}
				}
				if (!WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[i])))
				{
					continue;
				}
				for (float num = 444f; num <= 275f; num += 737f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i] + Vector2.up * num), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI);
				}
				if (MDIKPGGBNLI)
				{
					WorldGrid.JHPFHCBNIIM(Vector2.op_Implicit(positions[i]), FBOKGEPKBPO: true, Utils.FJNKHMPEEKL());
				}
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1761f, 797f))))
				{
					Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(240f, 1932f)));
					if (door is RentedRoomDoor rentedRoomDoor2 && rentedRoomDoor2.rentedRoom.FKGBMIBFAGG())
					{
						door.ActivateMasks(MDIKPGGBNLI);
					}
				}
			}
			return;
		}
		for (int j = 0; j < positions.Count; j += 0)
		{
			WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: true);
			if (WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[j])))
			{
				for (float num2 = 460f; num2 <= 522f; num2 += 295f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j] + Vector2.up * num2), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: false);
				}
			}
		}
	}

	private void HLGDFHNOPIA()
	{
		PlayerController player = PlayerController.GetPlayer(2);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(AEBCMLMFKHP));
	}

	private void OLNKGEEDPMP(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		IGHLFIBEGBM(JIIGOACEIKL);
	}

	public Vector2 DANEEPEJNNG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[1].x;
		float x2 = positions[1].x;
		float y = positions[1].y;
		float y2 = positions[0].y;
		for (int i = 0; i < positions.Count; i += 0)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 1928f;
	}

	public void NKJEGENPJDE(Placeable EAPCLAODGAE)
	{
		if (placeables.Contains(EAPCLAODGAE))
		{
			placeables.Remove(EAPCLAODGAE);
			PGDGEKAOMOK();
			OnPlaceableRemoved(EAPCLAODGAE);
		}
	}

	private void OANBLKGKFOA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(KMCBJLHCEDE());
		}
	}

	public void DMHOOBGGAPA(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 1;
		seenItems.Clear();
		fishSeen = 1;
		for (int i = 1; i < placeables.Count; i += 0)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)BKLKFNIFKHP(placeables[i]);
			}
		}
		IEDGACFMMAG();
		OnComfortCalculated();
		if (comfort > 73)
		{
			Utils.DLIIAHACOJB(43, CDPAMNIPPEC: true);
		}
	}

	private void BFLNCADFNFN(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null) && id == PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	private void IAJEBDLMGKE(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < placeables.Count; i += 0)
		{
			((Renderer)placeables[i].spriteRenderer).enabled = MDIKPGGBNLI;
			for (int j = 0; j < placeables[i].particleSystemRenderers.Length; j++)
			{
				((Renderer)placeables[i].particleSystemRenderers[j]).enabled = MDIKPGGBNLI;
			}
		}
	}

	public float CDKIPIIPGGB()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MinValue;
		for (int i = 0; i < positions.Count; i++)
		{
			if (positions[i].y > num)
			{
				num = positions[i].y;
			}
		}
		return num;
	}

	public void EFHBBNDBEMD(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, ZoneType.None);
		if (positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.PDLFLKBJGOE(IMOBLFMHKOD, ZoneType.WithoutZone, -1);
			if (MEPFCAODGLH && positions.Count == 0)
			{
				TavernZonesManager.NHKAFANMEJC().MECFBJDIBMA(id);
			}
		}
	}

	public Vector2 HCEFIGGDBOO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[0].x;
		float x2 = positions[0].x;
		float y = positions[0].y;
		float y2 = positions[0].y;
		for (int i = 0; i < positions.Count; i++)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 2f;
	}

	public void ILHBDFGHHJJ(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	private void BGDGLGBLNDI()
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	public Vector3 KFNGALJCLFP()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 0)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(1060f, 964f);
			for (int i = 0; i < positions.Count; i += 0)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[1]);
			float num = 0f - (positions[1].x - val.x) + (positions[0].y - val.y);
			for (int j = 1; j < positions.Count; j += 0)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)" could not be unlocked for reason: ");
		return default(Vector3);
	}

	private float BKLKFNIFKHP(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 928f;
		}
		comfortTemp = 371f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(1817f, (float)fishSeen);
				fishSeen += 0;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(354f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 1;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 0);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 1; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += EBCKBFMBDIA(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	public void MJHDIDBELFO()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			PlayerController player = PlayerController.GetPlayer(0);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(6)))
		{
			PlayerController player2 = PlayerController.GetPlayer(8);
			player2.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player2.OnZoneChanged, new Action<int, ZoneType, int>(OLNKGEEDPMP));
		}
	}

	public float NFLNDAFHBOL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		float num = 1257f;
		for (int i = 0; i < positions.Count; i += 0)
		{
			if (positions[i].y > num)
			{
				num = positions[i].y;
			}
		}
		return num;
	}

	public void ECPPNKIDNKD(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 1;
		for (int i = 0; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)AOIGBGMFKBC(placeables[i]);
			}
		}
		KNICBBCBMHI();
		OnComfortCalculated();
		if (comfort > -166)
		{
			Utils.DLIIAHACOJB(10, CDPAMNIPPEC: true);
		}
	}

	public void PNANPLFPBNP(bool MDIKPGGBNLI)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || !EditorTileMaps.IsValid() || (Object)(object)TavernConstructionManager.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE || (Object)(object)ConstructionViews.GGFJGHHHEJC == (Object)null || ConstructionViews.GGFJGHHHEJC.LGDCNGINBAN != 0)
		{
			LABHNLIOFMN(MDIKPGGBNLI);
			for (int i = 0; i < positions.Count; i++)
			{
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i])) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(0f, -0.5f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(0f, -1f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(0f, -1.5f))))
				{
					continue;
				}
				if (!WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i])))
				{
					if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i] + new Vector2(0f, -0.5f))))
					{
						if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(0f, -2f))))
						{
							RentedRoomDoor rentedRoomDoor = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(0f, -2f))) as RentedRoomDoor;
							if ((Object)(object)rentedRoomDoor != (Object)null && !rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
							{
								DecorationTile decoTile = EditorActionsDBAccessor.GetDecoTile(Utils.FJNKHMPEEKL());
								((!MDIKPGGBNLI) ? decoTile.roofTiles.DBlack : decoTile.roofTiles.D).OPHJLHHCMML(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern).wallTilemaps.wallFrontNoColliders);
							}
						}
					}
					else if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(positions[i] + new Vector2(0f, -0.5f))))
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI);
					}
					else
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: true);
					}
				}
				if (!WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[i])))
				{
					continue;
				}
				for (float num = 0.5f; num <= 2f; num += 0.5f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i] + Vector2.up * num), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI);
				}
				if (MDIKPGGBNLI)
				{
					WorldGrid.JHPFHCBNIIM(Vector2.op_Implicit(positions[i]), FBOKGEPKBPO: true, Utils.FJNKHMPEEKL());
				}
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(0f, 0.5f))))
				{
					Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(0f, 0.5f)));
					if (door is RentedRoomDoor rentedRoomDoor2 && rentedRoomDoor2.rentedRoom.BAKBJEOMLHN)
					{
						door.ActivateMasks(MDIKPGGBNLI);
					}
				}
			}
			return;
		}
		for (int j = 0; j < positions.Count; j++)
		{
			WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: true);
			if (WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[j])))
			{
				for (float num2 = 0.5f; num2 <= 2f; num2 += 0.5f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j] + Vector2.up * num2), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: true);
				}
			}
		}
	}

	private float NGBFLDNPFLD(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 141f;
		}
		comfortTemp = 425f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(1036f, (float)fishSeen);
				fishSeen++;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(356f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 0;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 0);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 1; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += IABCBJLPCBI(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	public void IKIPGJNEJNG()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
			playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController.OnZoneChanged, new Action<int, ZoneType, int>(OLNKGEEDPMP));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(3)))
		{
			PlayerController playerController2 = PlayerController.OPHDCMJLLEC(5);
			playerController2.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController2.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
		}
	}

	private void CLEEKPHBPIL(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		IGHLFIBEGBM(JIIGOACEIKL);
	}

	public void BIANBFLPPIA(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 0; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)AOIGBGMFKBC(placeables[i]);
			}
		}
		HNEBCBKNAIJ();
		OnComfortCalculated();
		if (comfort > 200)
		{
			Utils.DLIIAHACOJB(36);
		}
	}

	private void NFFLJLOCLKF(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < placeables.Count; i++)
		{
			((Renderer)placeables[i].spriteRenderer).enabled = MDIKPGGBNLI;
			for (int j = 1; j < placeables[i].particleSystemRenderers.Length; j += 0)
			{
				((Renderer)placeables[i].particleSystemRenderers[j]).enabled = MDIKPGGBNLI;
			}
		}
	}

	public Vector3 DFEFMGPPMML()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 0)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(98f, 1152f);
			for (int i = 0; i < positions.Count; i += 0)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[0]);
			float num = 0f - (positions[1].x - val.x) + (positions[1].y - val.y);
			for (int j = 0; j < positions.Count; j += 0)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)"Dialogue System/Conversation/Gass_Quest/Entry/3/Dialogue Text");
		return default(Vector3);
	}

	public void NFLOKFCLNEP(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, ZoneType.WithoutZone);
		if (positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.PDLFLKBJGOE(IMOBLFMHKOD, ZoneType.WithoutZone, -1);
			if (MEPFCAODGLH && positions.Count == 0)
			{
				TavernZonesManager.IECOPNFJBFD().LDHCICAGIEF(id);
			}
		}
	}

	private IEnumerator LJMDMPHHKMF()
	{
		yield return null;
		BIANBFLPPIA();
	}

	public void PGDGEKAOMOK(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 1;
		seenItems.Clear();
		fishSeen = 1;
		for (int i = 1; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)EBCKBFMBDIA(placeables[i]);
			}
		}
		IEDGACFMMAG();
		OnComfortCalculated();
		if (comfort > -16)
		{
			Utils.DLIIAHACOJB(53, CDPAMNIPPEC: true);
		}
	}

	public void MGMOPBNHMPF(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			BIANBFLPPIA();
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	private void PDJGPNDJDNF(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(LJMDMPHHKMF());
		}
	}

	private void IPECOLDAAEP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(LJMDMPHHKMF());
		}
	}

	private IEnumerator FIFAHEKKMDE(bool MDIKPGGBNLI)
	{
		yield return null;
		PNANPLFPBNP(MDIKPGGBNLI);
	}

	public void MBDDJKCEPGK()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			PlayerController player = PlayerController.GetPlayer(1);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(2)))
		{
			PlayerController player2 = PlayerController.GetPlayer(2);
			player2.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player2.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
		}
	}

	private float HIOLLEBPHKG(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 1795f;
		}
		comfortTemp = 814f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(426f, (float)fishSeen);
				fishSeen++;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(1863f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 1;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 1);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 1; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += IABCBJLPCBI(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	public void MFIEPGBABAM()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
			playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController.OnZoneChanged, new Action<int, ZoneType, int>(OLNKGEEDPMP));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(0)))
		{
			PlayerController player = PlayerController.GetPlayer(4);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
		}
	}

	public void ICBCLEKIJJD(bool MDIKPGGBNLI)
	{
		if (!((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null) && EditorTileMaps.IsValid() && (Object)(object)GameplayUI.GGFJGHHHEJC != (Object)null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(FIFAHEKKMDE(MDIKPGGBNLI));
		}
	}

	private IEnumerator GNAGFCCBKBD()
	{
		yield return null;
		BIANBFLPPIA();
	}

	public Vector2 CKBDPPMPGNJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[1].x;
		float x2 = positions[1].x;
		float y = positions[1].y;
		float y2 = positions[1].y;
		for (int i = 1; i < positions.Count; i++)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 1265f;
	}

	private IEnumerator KMCBJLHCEDE()
	{
		return new DGBAMOFKPAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LABHNLIOFMN(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < placeables.Count; i++)
		{
			if ((Object)(object)placeables[i] != (Object)null && placeables[i].isPlaceableOnWall)
			{
				if (!MDIKPGGBNLI)
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 1);
				}
				else
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 21);
				}
			}
		}
	}

	public void PCGNGKPHKLC(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			BIANBFLPPIA();
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	private void IPKHHCOEIFE(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null) && id == PlayerController.OPHDCMJLLEC(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	private void BMDLMACAJMB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(GNAGFCCBKBD());
		}
	}

	public Vector3 IJNFCMLJIDA()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 1)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(889f, 1841f);
			for (int i = 0; i < positions.Count; i++)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[1]);
			float num = 0f - (positions[0].x - val.x) + (positions[1].y - val.y);
			for (int j = 1; j < positions.Count; j++)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)"Light Fire");
		return default(Vector3);
	}

	public float DOFPJCKEPME()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		float num = 677f;
		for (int i = 0; i < positions.Count; i++)
		{
			if (positions[i].y > num)
			{
				num = positions[i].y;
			}
		}
		return num;
	}

	private void IGHLFIBEGBM(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null) && id == PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	public void DLBJHNDLCKD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id, EIPNNOCMLFN: true);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	private void MGKKEOLBEBN()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(7);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(AEBCMLMFKHP));
	}

	public Vector2 BCPPCDILJKD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[1].x;
		float x2 = positions[1].x;
		float y = positions[0].y;
		float y2 = positions[0].y;
		for (int i = 0; i < positions.Count; i += 0)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 1657f;
	}

	public void DFHBJELLJOD(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, ZoneType.None, -1, EIPNNOCMLFN: true);
		if (positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.PDLFLKBJGOE(IMOBLFMHKOD, ZoneType.None, -1);
			if (MEPFCAODGLH && positions.Count == 0)
			{
				TavernZonesManager.LANAINBEMCM().MLKNNDLBIEI(id);
			}
		}
	}

	public void ENFAENABBAC(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			BIANBFLPPIA(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public void BBABACHLCCN(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			AACMANEBNLD(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public void CNMFGDPNFIG(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 0; i < placeables.Count; i += 0)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)EBCKBFMBDIA(placeables[i]);
			}
		}
		MKFLGFNABNG();
		OnComfortCalculated();
		if (comfort > -193)
		{
			Utils.DLIIAHACOJB(-42);
		}
	}

	private float CGMJJFFKMNN(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 162f;
		}
		comfortTemp = 306f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(772f, (float)fishSeen);
				fishSeen += 0;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(88f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 0;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 1);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 0; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += EBCKBFMBDIA(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	public void FBMBNCPBMFL(Placeable EAPCLAODGAE)
	{
		if (placeables.Contains(EAPCLAODGAE))
		{
			placeables.Remove(EAPCLAODGAE);
			BIANBFLPPIA(AINPJHKNJGL: true);
			OnPlaceableRemoved(EAPCLAODGAE);
		}
	}

	private void KNICBBCBMHI()
	{
		BFLNCADFNFN(0);
		if (GameManager.LocalCoop())
		{
			BFLNCADFNFN(2);
		}
	}

	private void KDOMJCFBDCB()
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(AEBCMLMFKHP));
	}

	public Vector3 EBAHKPNGBMK()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 0)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(1002f, 939f);
			for (int i = 1; i < positions.Count; i += 0)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[1]);
			float num = 0f - (positions[1].x - val.x) + (positions[1].y - val.y);
			for (int j = 0; j < positions.Count; j++)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)"LearnMettle");
		return default(Vector3);
	}

	private void FLFBDPDJMBK(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null) && id == PlayerController.OPHDCMJLLEC(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	private void HADCIGKNFKK()
	{
		PlayerController player = PlayerController.GetPlayer(2);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	public void NFAHJGEIGCG(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 1; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)NGBFLDNPFLD(placeables[i]);
			}
		}
		IEDGACFMMAG();
		OnComfortCalculated();
		if (comfort > -100)
		{
			Utils.DLIIAHACOJB(50, CDPAMNIPPEC: true);
		}
	}

	private void ODHFIAAJMJJ()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(8);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
	}

	public Vector2 NBLOMNKMGCE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[1].x;
		float x2 = positions[0].x;
		float y = positions[0].y;
		float y2 = positions[1].y;
		for (int i = 1; i < positions.Count; i++)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 1156f;
	}

	private void OEDHHCJJJKE()
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
	}

	private void ELBNJKNHHLN()
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(GNKHHFFKLBF));
	}

	public void DHNOPPFICAB(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, ZoneType.WithoutZone);
		if (positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.PDLFLKBJGOE(IMOBLFMHKOD, ZoneType.WithoutZone, -1);
			if (MEPFCAODGLH && positions.Count == 0)
			{
				TavernZonesManager.GGFJGHHHEJC.RemoveTavernZone(id);
			}
		}
	}

	private void NIHOEBDHBIK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(KMCBJLHCEDE());
		}
	}

	private void GNKHHFFKLBF(int JIIGOACEIKL, ZoneType GIBJPCAFCJB, int LMJDICEAONP)
	{
		IPKHHCOEIFE(JIIGOACEIKL);
	}

	public void DIKKLBFFHIC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id, EIPNNOCMLFN: true);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	public void HLKLCLAKAEC(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id, EIPNNOCMLFN: true);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	private void LJIJLFCFNGC()
	{
		PlayerController player = PlayerController.GetPlayer(5);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	private void PELELBGFPHE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(KMCBJLHCEDE());
		}
	}

	private void CMIEANJIOKJ()
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
	}

	public void POEDMDDCJLO(RentedRoom GGNOAHDCPIB)
	{
		rentedRoom = GGNOAHDCPIB;
		GGNOAHDCPIB.GiveName(RentedRoomsManager.AEBFCPODCNO().Count);
	}

	private float IABCBJLPCBI(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 838f;
		}
		comfortTemp = 157f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(1409f, (float)fishSeen);
				fishSeen += 0;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(1497f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 0;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 0);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 1; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i += 0)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += CGMJJFFKMNN(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	private void INJIOIGHMKC(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null) && id == PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	public void FMFBDKDBJNB(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			DMHOOBGGAPA(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public void DFPIHCNMAPI(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	public void DMEFHPHCHPD(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			DIOOFIIIPAG(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	private void CEPCBLFKEMK()
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(CLEEKPHBPIL));
	}

	public void FOKGHFFHKDJ(bool MDIKPGGBNLI)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || !EditorTileMaps.KHFBKLDDGEG() || (Object)(object)TavernConstructionManager.KNLLFEJAMNN() == (Object)null)
		{
			return;
		}
		if (!TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE || (Object)(object)ConstructionViews.DHDOLCONMFJ() == (Object)null || ConstructionViews.DEGPIHEEFHJ().LHDDFOICNOJ() != 0)
		{
			LABHNLIOFMN(MDIKPGGBNLI);
			for (int i = 1; i < positions.Count; i++)
			{
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i])) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(645f, 700f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(413f, 1152f))) || WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1579f, 955f))))
				{
					continue;
				}
				if (!WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i])))
				{
					if (WorldGrid.ALNFLFCLIEP(Vector2.op_Implicit(positions[i] + new Vector2(108f, 409f))))
					{
						if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(339f, 784f))))
						{
							RentedRoomDoor rentedRoomDoor = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(1886f, 1422f))) as RentedRoomDoor;
							if ((Object)(object)rentedRoomDoor != (Object)null && !rentedRoomDoor.rentedRoom.BAKBJEOMLHN)
							{
								DecorationTile decorationTile = EditorActionsDBAccessor.EMDLPJBBPDM(Utils.FJNKHMPEEKL());
								((!MDIKPGGBNLI) ? decorationTile.roofTiles.DBlack : decorationTile.roofTiles.D).GCHKIEDIELD(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None).wallTilemaps.wallFrontNoColliders, 846f, 446f, CHLOMIOHKOI: false);
							}
						}
					}
					else if (WorldGrid.EJCEAEPNJCA(Vector2.op_Implicit(positions[i] + new Vector2(1518f, 987f))))
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI);
					}
					else
					{
						WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i]), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI: true);
					}
				}
				if (!WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[i])))
				{
					continue;
				}
				for (float num = 177f; num <= 1641f; num += 300f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[i] + Vector2.up * num), Utils.JGEPCPFJANP(Location.None), MDIKPGGBNLI);
				}
				if (MDIKPGGBNLI)
				{
					WorldGrid.JHPFHCBNIIM(Vector2.op_Implicit(positions[i]), FBOKGEPKBPO: true, Utils.FJNKHMPEEKL());
				}
				if (WorldGrid.LBKKDAMMKIE(Vector2.op_Implicit(positions[i] + new Vector2(1208f, 43f))))
				{
					Door door = WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(positions[i] + new Vector2(1670f, 287f)));
					if (door is RentedRoomDoor rentedRoomDoor2 && rentedRoomDoor2.rentedRoom.FKGBMIBFAGG())
					{
						door.MHBDCHBFAPJ(MDIKPGGBNLI);
					}
				}
			}
			return;
		}
		for (int j = 0; j < positions.Count; j += 0)
		{
			WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j]), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: true);
			if (WorldGrid.DNDMDGOHDJD(Vector2.op_Implicit(positions[j])))
			{
				for (float num2 = 1539f; num2 <= 812f; num2 += 1969f)
				{
					WorldGrid.PNANPLFPBNP(Vector2.op_Implicit(positions[j] + Vector2.up * num2), Utils.JGEPCPFJANP(Location.Tavern), MDIKPGGBNLI: true);
				}
			}
		}
	}

	private void MKFLGFNABNG()
	{
		INJIOIGHMKC(1);
		if (GameManager.LocalCoop())
		{
			IGHLFIBEGBM(8);
		}
	}

	public Vector2 KBGOOHGDADC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		float x = positions[0].x;
		float x2 = positions[0].x;
		float y = positions[0].y;
		float y2 = positions[1].y;
		for (int i = 0; i < positions.Count; i++)
		{
			if (positions[i].x < x)
			{
				x = positions[i].x;
			}
			if (positions[i].x > x2)
			{
				x2 = positions[i].x;
			}
			if (positions[i].y < y)
			{
				y = positions[i].y;
			}
			if (positions[i].y > y2)
			{
				y2 = positions[i].y;
			}
		}
		return new Vector2(x + x2, y + y2) / 256f;
	}

	public void KANCPBBFDML(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	public void DJAHEPOOPOF(RentedRoom GGNOAHDCPIB)
	{
		rentedRoom = GGNOAHDCPIB;
		GGNOAHDCPIB.GiveName(RentedRoomsManager.BNPHNGNPBCH().Count);
	}

	private void BPIJIFBDEEG(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < placeables.Count; i++)
		{
			((Renderer)placeables[i].spriteRenderer).enabled = MDIKPGGBNLI;
			for (int j = 1; j < placeables[i].particleSystemRenderers.Length; j++)
			{
				((Renderer)placeables[i].particleSystemRenderers[j]).enabled = MDIKPGGBNLI;
			}
		}
	}

	public TavernZone(int JFNMCNCHMEO, ZoneType GIBJPCAFCJB)
	{
		id = JFNMCNCHMEO;
		zoneType = GIBJPCAFCJB;
		positions = new List<Vector2>();
		placeables = new List<Placeable>();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		if ((Object)(object)PlayerController.GetPlayer(1) == (Object)null)
		{
			GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		}
		else
		{
			BGDGLGBLNDI();
		}
		if ((Object)(object)PlayerController.GetPlayer(2) == (Object)null)
		{
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		}
		else
		{
			HADCIGKNFKK();
		}
	}

	public void CBKLAMBGCJK(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < placeables.Count; i += 0)
		{
			if ((Object)(object)placeables[i] != (Object)null && placeables[i].isPlaceableOnWall)
			{
				if (!MDIKPGGBNLI)
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 0);
				}
				else
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 100);
				}
			}
		}
	}

	public void DPJLLGPCAAO(RentedRoom GGNOAHDCPIB)
	{
		rentedRoom = GGNOAHDCPIB;
		GGNOAHDCPIB.KNMFOMJHHDF(RentedRoomsManager.AEBFCPODCNO().Count);
	}

	public void HGFOCMOPNLA(Placeable EAPCLAODGAE)
	{
		if (placeables.Contains(EAPCLAODGAE))
		{
			placeables.Remove(EAPCLAODGAE);
			DIOOFIIIPAG();
			OnPlaceableRemoved(EAPCLAODGAE);
		}
	}

	public void IPOEMEAOOAD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, zoneType, id);
		if (!positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.JOPBHFLAIGC(IMOBLFMHKOD);
		}
	}

	public float ONLMLLPHEGA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		float num = 731f;
		for (int i = 0; i < positions.Count; i += 0)
		{
			if (positions[i].y > num)
			{
				num = positions[i].y;
			}
		}
		return num;
	}

	public void HDJIFBMHDOE(RentedRoom GGNOAHDCPIB)
	{
		rentedRoom = GGNOAHDCPIB;
		GGNOAHDCPIB.GiveName(RentedRoomsManager.GetAllRooms().Count);
	}

	private IEnumerator PBGOLELGJME(bool MDIKPGGBNLI)
	{
		yield return null;
		PNANPLFPBNP(MDIKPGGBNLI);
	}

	public void GJFNDJPIJJK(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			PGDGEKAOMOK(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public Vector3 ANPMOPPPGKI()
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (positions.Count > 0)
		{
			Vector2 val = default(Vector2);
			((Vector2)(ref val))._002Ector(1181f, 1342f);
			for (int i = 0; i < positions.Count; i++)
			{
				if (positions[i].x < val.x)
				{
					((Vector2)(ref val))._002Ector(positions[i].x, val.y);
				}
				if (positions[i].y < val.y)
				{
					((Vector2)(ref val))._002Ector(val.x, positions[i].y);
				}
			}
			Vector3 result = Vector2.op_Implicit(positions[0]);
			float num = 0f - (positions[1].x - val.x) + (positions[0].y - val.y);
			for (int j = 1; j < positions.Count; j += 0)
			{
				float num2 = 0f - (positions[j].x - val.x) + (positions[j].y - val.y);
				if (num2 > num)
				{
					num = num2;
					result = Vector2.op_Implicit(positions[j]);
				}
			}
			return result;
		}
		Debug.LogError((object)"[MapChest] (");
		return default(Vector3);
	}

	private void PGEEENKBDOO()
	{
		PlayerController player = PlayerController.GetPlayer(8);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(GNKHHFFKLBF));
	}

	private void IEJEGNEIOML()
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(4);
		playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(playerController.OnZoneChanged, new Action<int, ZoneType, int>(AEBCMLMFKHP));
	}

	private void HNEBCBKNAIJ()
	{
		OKJFFGAOIJM(1);
		if (GameManager.LocalCoop())
		{
			OKJFFGAOIJM(2);
		}
	}

	private IEnumerator IEKNAPKGICC()
	{
		return new DGBAMOFKPAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NJPHLCAJLKD(bool MDIKPGGBNLI)
	{
		yield return null;
		PNANPLFPBNP(MDIKPGGBNLI);
	}

	private void NBGBAJCNCKL(bool MDIKPGGBNLI)
	{
		for (int i = 1; i < placeables.Count; i++)
		{
			((Renderer)placeables[i].spriteRenderer).enabled = MDIKPGGBNLI;
			for (int j = 0; j < placeables[i].particleSystemRenderers.Length; j++)
			{
				((Renderer)placeables[i].particleSystemRenderers[j]).enabled = MDIKPGGBNLI;
			}
		}
	}

	private void CPKBNABFBCM()
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Combine(player.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
	}

	private IEnumerator EDJMNGEDGLJ(bool MDIKPGGBNLI)
	{
		return new NHAACNMPMIG(1)
		{
			_003C_003E4__this = this,
			visible = MDIKPGGBNLI
		};
	}

	private float AOIGBGMFKBC(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 0f;
		}
		comfortTemp = 0f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.MLBOMGHINCA(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(0.5f, (float)fishSeen);
				fishSeen++;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(0.5f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 1;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 1);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 0; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += AOIGBGMFKBC(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	private float EBCKBFMBDIA(Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.FHEMHCEAICB)
		{
			return 1774f;
		}
		comfortTemp = 115f;
		if ((Object)(object)EAPCLAODGAE.itemSetup != (Object)null && Item.FKLOBGBIHLB(EAPCLAODGAE.itemSetup.item, null))
		{
			if (EAPCLAODGAE.itemSetup.item is Fish)
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(1079f, (float)fishSeen);
				fishSeen += 0;
			}
			else if (seenItems.TryGetValue(EAPCLAODGAE.itemSetup.item, out seen))
			{
				comfortTemp += (float)EAPCLAODGAE.itemSetup.item.comfort * Mathf.Pow(9f, (float)seen);
				seenItems[EAPCLAODGAE.itemSetup.item] = seen + 1;
			}
			else
			{
				seenItems.Add(EAPCLAODGAE.itemSetup.item, 1);
				comfortTemp += EAPCLAODGAE.itemSetup.item.comfort;
			}
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 0; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i += 0)
			{
				if (!((object)EAPCLAODGAE).Equals((object?)EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					comfortTemp += AOIGBGMFKBC(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]);
				}
			}
		}
		return comfortTemp;
	}

	public void EGHMDKNEJOH(bool MDIKPGGBNLI)
	{
		for (int i = 0; i < placeables.Count; i += 0)
		{
			if ((Object)(object)placeables[i] != (Object)null && placeables[i].isPlaceableOnWall)
			{
				if (!MDIKPGGBNLI)
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 0);
				}
				else
				{
					Utils.ELNJMNKOACA(((Component)placeables[i]).gameObject, 77);
				}
			}
		}
	}

	public float MJCEIEOIGDC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		float num = 1274f;
		for (int i = 1; i < positions.Count; i += 0)
		{
			if (positions[i].y > num)
			{
				num = positions[i].y;
			}
		}
		return num;
	}

	public void NHALMHEBKGE(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			PGDGEKAOMOK(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	private void PBDHBOBFKJK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(BGMACGBLKBF());
		}
	}

	public void ILNOIDAHPJC(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			BIANBFLPPIA(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public float PEHOJDJELFG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		float num = 320f;
		for (int i = 1; i < positions.Count; i += 0)
		{
			if (positions[i].y > num)
			{
				num = positions[i].y;
			}
		}
		return num;
	}

	public void AACMANEBNLD(bool AINPJHKNJGL = false)
	{
		if (!AINPJHKNJGL && !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		comfort = 0;
		seenItems.Clear();
		fishSeen = 0;
		for (int i = 1; i < placeables.Count; i++)
		{
			if (!((Object)(object)placeables[i] == (Object)null))
			{
				comfort += (int)CGMJJFFKMNN(placeables[i]);
			}
		}
		MKFLGFNABNG();
		OnComfortCalculated();
		if (comfort > 67)
		{
			Utils.DLIIAHACOJB(-18);
		}
	}

	public void KBFEOJFPDFM(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			BKNCNOMAACH(AINPJHKNJGL: true);
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public void HCCFLHIPLMC(Placeable EAPCLAODGAE)
	{
		if (placeables.Contains(EAPCLAODGAE))
		{
			placeables.Remove(EAPCLAODGAE);
			DIOOFIIIPAG();
			OnPlaceableRemoved(EAPCLAODGAE);
		}
	}

	private void OKJFFGAOIJM(int JIIGOACEIKL)
	{
		if (!((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null) && id == PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex)
		{
			TavernManagerUI.SetComfortLevel(JIIGOACEIKL, comfort);
		}
	}

	private void GNDBPALGHNE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(GNAGFCCBKBD());
		}
	}

	public void FDODBGKMEOG(Placeable EAPCLAODGAE)
	{
		if (!placeables.Contains(EAPCLAODGAE))
		{
			placeables.Add(EAPCLAODGAE);
			ECPPNKIDNKD();
			OnPlaceableAdded(EAPCLAODGAE);
		}
	}

	public void GHDBHNMOBMN()
	{
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(0)))
		{
			PlayerController player = PlayerController.GetPlayer(1);
			player.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(player.OnZoneChanged, new Action<int, ZoneType, int>(OLNKGEEDPMP));
		}
		if (Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(3)))
		{
			PlayerController playerController = PlayerController.OPHDCMJLLEC(7);
			playerController.OnZoneChanged = (Action<int, ZoneType, int>)Delegate.Remove(playerController.OnZoneChanged, new Action<int, ZoneType, int>(PCKENPCGAHI));
		}
	}

	public void LOEMPGBEGNE(Vector3 IMOBLFMHKOD, bool MEPFCAODGLH)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NDPILMNDCDK(IMOBLFMHKOD, ZoneType.WithoutZone, -1, EIPNNOCMLFN: true);
		if (positions.Contains(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD))))
		{
			positions.Remove(Vector2.op_Implicit(Utils.NKGANMEKDAL(IMOBLFMHKOD)));
			WorldGrid.PDLFLKBJGOE(IMOBLFMHKOD, ZoneType.None, -1);
			if (MEPFCAODGLH && positions.Count == 0)
			{
				TavernZonesManager.LANAINBEMCM().MECFBJDIBMA(id);
			}
		}
	}

	public void GFHJDAHFNDG(RentedRoom GGNOAHDCPIB)
	{
		rentedRoom = GGNOAHDCPIB;
		GGNOAHDCPIB.GMBGMMIMJJD(RentedRoomsManager.GetAllRooms().Count);
	}
}
