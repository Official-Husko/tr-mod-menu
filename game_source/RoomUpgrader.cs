using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RoomUpgrader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ELDLJJNLEPN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoxCollider2D collider2D;

		public RoomUpgrader _003C_003E4__this;

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
		public ELDLJJNLEPN(int _003C_003E1__state)
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
			RoomUpgrader roomUpgrader = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				((Collider2D)collider2D).usedByComposite = false;
				((Collider2D)collider2D).isTrigger = true;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Collider2D)collider2D).composite.GenerateGeometry();
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				((Collider2D)collider2D).usedByComposite = true;
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				((Collider2D)collider2D).composite.GenerateGeometry();
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				roomUpgrader.OnRoomColliderGenerated();
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

	private static RoomUpgrader IADEMLIIDPC;

	public Action OnRoomColliderGenerated = delegate
	{
	};

	public Action OnRoomUpgradeStart = delegate
	{
	};

	public Action OnRoomUpgradeEnd = delegate
	{
	};

	public List<Tilemap> tilemaps;

	public UpgradeRoomInfo craftingRoom;

	public UpgradeRoomInfo tavernFloor;

	public UpgradeRoomInfo cellar;

	public Dictionary<ZoneType, int> upgrades = new Dictionary<ZoneType, int>();

	public static RoomUpgrader GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<RoomUpgrader>();
			}
			return IADEMLIIDPC;
		}
	}

	private void CLPLIBJDMJP(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].LDHAIEPKCHM();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].cornerFrom.position;
			for (int i = 1; i < GMKGCGFCNNM.moveObjects.Length; i++)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	public void MOCHBANFNCK()
	{
		MBKLHKIHJOB(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom, -1, MPLOCLOPMAE: false);
	}

	private void JLIPFLBHHKL()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < allPositionsToCalculate.Length; i += 0)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(allPositionsToCalculate[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.BLCGOEMGKGH(), DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
		}
	}

	private void IAJPDKCECIG()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.NHKAHEEGEGF(), DCHHFGLPNOF: false, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
		}
	}

	private void EJMOBLDCPGO(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].CKADKFLBCAN();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].cornerFrom.position;
			for (int i = 0; i < GMKGCGFCNNM.moveObjects.Length; i += 0)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	public void PCGGJMIKEAG(ZoneType GIBJPCAFCJB, int FBJIMGMMFHC = -1, bool MPLOCLOPMAE = true)
	{
		OnRoomUpgradeStart();
		int mOFKEDGAOEE = ((FBJIMGMMFHC == -1) ? upgrades[GIBJPCAFCJB] : FBJIMGMMFHC);
		switch (GIBJPCAFCJB)
		{
		case ZoneType.CraftingRoom:
			TavernZonesManager.LANAINBEMCM().RemoveTavernZone(0);
			break;
		case ZoneType.DiningRoom:
			TavernZonesManager.GGFJGHHHEJC.LDHCICAGIEF(0);
			break;
		}
		if (GIBJPCAFCJB == ZoneType.RentedRoom)
		{
			EJMOBLDCPGO(craftingRoom, ZoneType.CraftingRoom, mOFKEDGAOEE);
		}
		else
		{
			switch (GIBJPCAFCJB)
			{
			case ZoneType.RentedRoom:
				DNFBEGLBKNC(tavernFloor, ZoneType.DiningRoom, mOFKEDGAOEE);
				break;
			case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
				JIJHMCLEEME(cellar, ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar, mOFKEDGAOEE);
				break;
			}
		}
		Debug.Log((object)("GO" + GIBJPCAFCJB));
		PNBGPNKNFDG();
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		switch (GIBJPCAFCJB)
		{
		case ZoneType.WithoutZone | ZoneType.CraftingRoom:
		case ZoneType.RentedRoom:
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(TavernFloor.FirstFloor);
			break;
		case ZoneType.DiningRoom | ZoneType.MetalWorkshop:
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(TavernFloor.None);
			break;
		}
		OnRoomUpgradeEnd();
	}

	private void DNFBEGLBKNC(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].LDHAIEPKCHM();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].cornerFrom.position;
			for (int i = 1; i < GMKGCGFCNNM.moveObjects.Length; i += 0)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 0;
	}

	private void FGJHGPLODJA()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = Utils.JGEPCPFJANP(Location.Tavern).HNLGGMFFFIM();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.ADEICKHEPFI(), DCHHFGLPNOF: false, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
		}
	}

	private IEnumerator IODGAPFNGAB(BoxCollider2D HIOAEJKLJNH)
	{
		return new ELDLJJNLEPN(1)
		{
			_003C_003E4__this = this,
			collider2D = HIOAEJKLJNH
		};
	}

	private void GEBOJKMGELM(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].LDHAIEPKCHM();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].cornerFrom.position;
			for (int i = 1; i < GMKGCGFCNNM.moveObjects.Length; i++)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 0;
	}

	private void GNOBDKFFPOL()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			upgrades.Add(ZoneType.DiningRoom | ZoneType.CraftingRoom, 0);
			upgrades.Add(ZoneType.None, 1);
			upgrades.Add(~ZoneType.WoodWorkshop, 1);
		}
	}

	private void EBJOEKKFENK()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = Utils.JGEPCPFJANP(Location.Tavern).IBGBCHLIEGH();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		for (int i = 0; i < array.Length; i += 0)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.PJMGHIMKFJL(), DCHHFGLPNOF: false, JPLINFIKAJI: true, OPEEJDDDPLD: true);
			}
		}
	}

	private void HHHGCOKNLMJ(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].ChangeTiles();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].cornerFrom.position;
			for (int i = 0; i < GMKGCGFCNNM.moveObjects.Length; i++)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	private void AGLMGDNBHBF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			upgrades.Add(ZoneType.WithoutZone | ZoneType.CraftingRoom, 1);
			upgrades.Add(ZoneType.DiningRoom | ZoneType.CraftingRoom, 0);
			upgrades.Add(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop), 0);
		}
	}

	private IEnumerator PFNAIBOGAAK(BoxCollider2D HIOAEJKLJNH)
	{
		((Collider2D)HIOAEJKLJNH).usedByComposite = false;
		((Collider2D)HIOAEJKLJNH).isTrigger = true;
		yield return null;
		((Collider2D)HIOAEJKLJNH).composite.GenerateGeometry();
		yield return null;
		((Collider2D)HIOAEJKLJNH).usedByComposite = true;
		yield return null;
		((Collider2D)HIOAEJKLJNH).composite.GenerateGeometry();
		yield return null;
		OnRoomColliderGenerated();
	}

	public void ADMCKGBELCG(ZoneType GIBJPCAFCJB, int FBJIMGMMFHC = -1, bool MPLOCLOPMAE = true)
	{
		OnRoomUpgradeStart();
		int mOFKEDGAOEE = ((FBJIMGMMFHC == -1) ? upgrades[GIBJPCAFCJB] : FBJIMGMMFHC);
		switch (GIBJPCAFCJB)
		{
		case ZoneType.DiningRoom | ZoneType.CraftingRoom:
			TavernZonesManager.HFHPMKJGMPA().RemoveTavernZone(1);
			break;
		case ZoneType.RentedRoom:
			TavernZonesManager.JEEGOBGDLPE().MLKNNDLBIEI(1);
			break;
		}
		switch (GIBJPCAFCJB)
		{
		case ZoneType.DiningRoom | ZoneType.CraftingRoom:
			DPMMBIJNAON(craftingRoom, ZoneType.DiningRoom, mOFKEDGAOEE);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom:
			DNFBEGLBKNC(tavernFloor, ZoneType.WithoutZone | ZoneType.DiningRoom, mOFKEDGAOEE);
			break;
		case ZoneType.CraftingRoom | ZoneType.MetalWorkshop:
			HHHGCOKNLMJ(cellar, ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop, mOFKEDGAOEE);
			break;
		}
		Debug.Log((object)("Invalid time range specified." + GIBJPCAFCJB));
		EBJOEKKFENK();
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		switch (GIBJPCAFCJB)
		{
		case ZoneType.WithoutZone | ZoneType.DiningRoom:
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom:
			GameManager.NJNFHEPLEHL().CalculateCameraBounds(TavernFloor.FirstFloor | TavernFloor.SecondFloor);
			break;
		case ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.Cellar):
			GameManager.NJNFHEPLEHL().CalculateCameraBounds(TavernFloor.Cellar);
			break;
		}
		OnRoomUpgradeEnd();
	}

	private void FGPOPBBHAIF()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(allPositionsToCalculate[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.EECEKHKAAIH, DCHHFGLPNOF: true, JPLINFIKAJI: true);
			}
		}
	}

	public void HFJILKNFHCK()
	{
		UpgradeRoom(ZoneType.WithoutZone | ZoneType.CraftingRoom);
	}

	public void NDOHNONKAMG()
	{
		UpgradeRoom(ZoneType.None, -1, MPLOCLOPMAE: false);
	}

	private void NOBHCEIOOGA()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < array.Length; i += 0)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.PJMGHIMKFJL(), DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
		}
	}

	public void KFJIBLCCJJK()
	{
		ADMCKGBELCG(ZoneType.CraftingRoom, -1, MPLOCLOPMAE: false);
	}

	private void DPMMBIJNAON(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].CKADKFLBCAN();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].cornerFrom.position;
			for (int i = 0; i < GMKGCGFCNNM.moveObjects.Length; i += 0)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	private void NMKGOAJLMDG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			upgrades.Add(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom, 0);
			upgrades.Add(ZoneType.DiningRoom | ZoneType.CraftingRoom, 0);
			upgrades.Add(~(ZoneType.WithoutZone | ZoneType.WoodWorkshop), 0);
		}
	}

	public void PACDGGNKPNH()
	{
		PCGGJMIKEAG(ZoneType.CraftingRoom);
	}

	private IEnumerator GHAJHBLGMGL(BoxCollider2D HIOAEJKLJNH)
	{
		return new ELDLJJNLEPN(1)
		{
			_003C_003E4__this = this,
			collider2D = HIOAEJKLJNH
		};
	}

	private IEnumerator EELIPEMEHLP(BoxCollider2D HIOAEJKLJNH)
	{
		return new ELDLJJNLEPN(1)
		{
			_003C_003E4__this = this,
			collider2D = HIOAEJKLJNH
		};
	}

	private void LIBDPILCKBA(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].LAEEDOLPGHO();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].cornerFrom.position;
			for (int i = 1; i < GMKGCGFCNNM.moveObjects.Length; i++)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	public void UpgradeRoom(ZoneType GIBJPCAFCJB, int FBJIMGMMFHC = -1, bool MPLOCLOPMAE = true)
	{
		OnRoomUpgradeStart();
		int mOFKEDGAOEE = ((FBJIMGMMFHC == -1) ? upgrades[GIBJPCAFCJB] : FBJIMGMMFHC);
		switch (GIBJPCAFCJB)
		{
		case ZoneType.DiningRoom:
			TavernZonesManager.GGFJGHHHEJC.RemoveTavernZone(0);
			break;
		case ZoneType.CraftingRoom:
			TavernZonesManager.GGFJGHHHEJC.RemoveTavernZone(1);
			break;
		}
		switch (GIBJPCAFCJB)
		{
		case ZoneType.CraftingRoom:
			HHHGCOKNLMJ(craftingRoom, ZoneType.CraftingRoom, mOFKEDGAOEE);
			break;
		case ZoneType.DiningRoom:
			HHHGCOKNLMJ(tavernFloor, ZoneType.DiningRoom, mOFKEDGAOEE);
			break;
		case ZoneType.Cellar:
			HHHGCOKNLMJ(cellar, ZoneType.Cellar, mOFKEDGAOEE);
			break;
		}
		Debug.Log((object)("Room Upgraded " + GIBJPCAFCJB));
		FGPOPBBHAIF();
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		switch (GIBJPCAFCJB)
		{
		case ZoneType.DiningRoom:
		case ZoneType.CraftingRoom:
			GameManager.GGFJGHHHEJC.CalculateCameraBounds(TavernFloor.FirstFloor);
			break;
		case ZoneType.Cellar:
			GameManager.GGFJGHHHEJC.CalculateCameraBounds(TavernFloor.Cellar);
			break;
		}
		OnRoomUpgradeEnd();
	}

	private void JOHDAFGBLOL()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < allPositionsToCalculate.Length; i++)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(allPositionsToCalculate[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.NHKAHEEGEGF(), DCHHFGLPNOF: true, JPLINFIKAJI: false, OPEEJDDDPLD: true);
			}
		}
	}

	private void PGEGODAEBLC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			upgrades.Add(ZoneType.DiningRoom, 1);
			upgrades.Add(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom, 0);
			upgrades.Add(ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.MetalWorkshop, 1);
		}
	}

	public void PEPCIFCCNKA()
	{
		PCGGJMIKEAG(ZoneType.DiningRoom | ZoneType.CraftingRoom, -1, MPLOCLOPMAE: false);
	}

	public void BJNHNPBFHBC()
	{
		ELAEGPDLAHK(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom);
	}

	private void PNBGPNKNFDG()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] array = Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < array.Length; i++)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(array[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(array[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.KCJFCHNPIBJ(), DCHHFGLPNOF: true);
			}
		}
	}

	public void NNEFDNLPMKJ()
	{
		PCGGJMIKEAG(ZoneType.WithoutZone | ZoneType.CraftingRoom);
	}

	private void GKBMKJFPFMC(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].LNADHOHFGPA();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].cornerFrom.position;
			for (int i = 1; i < GMKGCGFCNNM.moveObjects.Length; i += 0)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	[SpecialName]
	public static RoomUpgrader MAAAKALBBEE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RoomUpgrader>();
		}
		return IADEMLIIDPC;
	}

	private void JIJHMCLEEME(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].CKADKFLBCAN();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].cornerFrom.position;
			for (int i = 0; i < GMKGCGFCNNM.moveObjects.Length; i += 0)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}

	[ContextMenu("Upgrade tavern")]
	public void UpgradeTavernRoom()
	{
		UpgradeRoom(ZoneType.DiningRoom);
	}

	private void OKHLEMPJONN()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			upgrades.Add(ZoneType.WithoutZone | ZoneType.DiningRoom, 1);
			upgrades.Add(ZoneType.WithoutZone, 0);
			upgrades.Add(~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop), 1);
		}
	}

	public void ELAEGPDLAHK(ZoneType GIBJPCAFCJB, int FBJIMGMMFHC = -1, bool MPLOCLOPMAE = true)
	{
		OnRoomUpgradeStart();
		int mOFKEDGAOEE = ((FBJIMGMMFHC == -1) ? upgrades[GIBJPCAFCJB] : FBJIMGMMFHC);
		switch (GIBJPCAFCJB)
		{
		case ZoneType.None:
			TavernZonesManager.EBAIHKJHCCA().HONJJIAOFEM(1);
			break;
		case ZoneType.DiningRoom:
			TavernZonesManager.IECOPNFJBFD().LDHCICAGIEF(1);
			break;
		}
		switch (GIBJPCAFCJB)
		{
		case ZoneType.CraftingRoom:
			DPMMBIJNAON(craftingRoom, ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom, mOFKEDGAOEE);
			break;
		case ZoneType.None:
			GKBMKJFPFMC(tavernFloor, ZoneType.RentedRoom, mOFKEDGAOEE);
			break;
		case ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop:
			GEBOJKMGELM(cellar, ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop, mOFKEDGAOEE);
			break;
		}
		Debug.Log((object)("MainProgress" + GIBJPCAFCJB));
		JLIPFLBHHKL();
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		switch (GIBJPCAFCJB)
		{
		case ZoneType.WithoutZone | ZoneType.CraftingRoom:
		case ZoneType.RentedRoom:
			GameManager.NJNFHEPLEHL().CalculateCameraBounds(TavernFloor.Cellar | TavernFloor.SecondFloor);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			GameManager.GGFJGHHHEJC.JIOFFKMPJPO(TavernFloor.Cellar);
			break;
		}
		OnRoomUpgradeEnd();
	}

	private void EINHEDGGKFE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector3Int[] allPositionsToCalculate = Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			if (tilemapScene.commonTilemaps.functionalTilemap.HasTile(allPositionsToCalculate[i]))
			{
				Vector3 iMOBLFMHKOD = ((GridLayout)tilemapScene.commonTilemaps.functionalTilemap).CellToWorld(allPositionsToCalculate[i]);
				GameTileMaps.GGFJGHHHEJC.CreateWorldTile(iMOBLFMHKOD, tilemapScene, SeasonManager.PJMGHIMKFJL());
			}
		}
	}

	private IEnumerator JONJLCGDNCO(BoxCollider2D HIOAEJKLJNH)
	{
		((Collider2D)HIOAEJKLJNH).usedByComposite = false;
		((Collider2D)HIOAEJKLJNH).isTrigger = true;
		yield return null;
		((Collider2D)HIOAEJKLJNH).composite.GenerateGeometry();
		yield return null;
		((Collider2D)HIOAEJKLJNH).usedByComposite = true;
		yield return null;
		((Collider2D)HIOAEJKLJNH).composite.GenerateGeometry();
		yield return null;
		OnRoomColliderGenerated();
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			upgrades.Add(ZoneType.CraftingRoom, 0);
			upgrades.Add(ZoneType.DiningRoom, 0);
			upgrades.Add(ZoneType.Cellar, 0);
		}
	}

	public void MBKLHKIHJOB(ZoneType GIBJPCAFCJB, int FBJIMGMMFHC = -1, bool MPLOCLOPMAE = true)
	{
		OnRoomUpgradeStart();
		int mOFKEDGAOEE = ((FBJIMGMMFHC == -1) ? upgrades[GIBJPCAFCJB] : FBJIMGMMFHC);
		switch (GIBJPCAFCJB)
		{
		case ZoneType.DiningRoom | ZoneType.CraftingRoom:
			TavernZonesManager.GGFJGHHHEJC.HONJJIAOFEM(1);
			break;
		case ZoneType.WithoutZone | ZoneType.CraftingRoom:
			TavernZonesManager.JEEGOBGDLPE().LDHCICAGIEF(0);
			break;
		}
		switch (GIBJPCAFCJB)
		{
		case ZoneType.RentedRoom:
			DPMMBIJNAON(craftingRoom, ZoneType.RentedRoom, mOFKEDGAOEE);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom:
			EJMOBLDCPGO(tavernFloor, ZoneType.WithoutZone | ZoneType.DiningRoom, mOFKEDGAOEE);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop):
			JIJHMCLEEME(cellar, ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop, mOFKEDGAOEE);
			break;
		}
		Debug.Log((object)("\n" + GIBJPCAFCJB));
		PNBGPNKNFDG();
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		switch (GIBJPCAFCJB)
		{
		case ZoneType.CraftingRoom:
		case ZoneType.WithoutZone | ZoneType.CraftingRoom:
			GameManager.GGFJGHHHEJC.CalculateCameraBounds(TavernFloor.Cellar | TavernFloor.SecondFloor);
			break;
		case ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar:
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(TavernFloor.None);
			break;
		}
		OnRoomUpgradeEnd();
	}

	public void HPHAABDONGN(ZoneType GIBJPCAFCJB, int FBJIMGMMFHC = -1, bool MPLOCLOPMAE = true)
	{
		OnRoomUpgradeStart();
		int mOFKEDGAOEE = ((FBJIMGMMFHC == -1) ? upgrades[GIBJPCAFCJB] : FBJIMGMMFHC);
		switch (GIBJPCAFCJB)
		{
		case ZoneType.WithoutZone:
			TavernZonesManager.NHKAFANMEJC().RemoveTavernZone(0);
			break;
		case ZoneType.DiningRoom:
			TavernZonesManager.HFHPMKJGMPA().MECFBJDIBMA(0);
			break;
		}
		switch (GIBJPCAFCJB)
		{
		case ZoneType.WithoutZone | ZoneType.DiningRoom:
			GEBOJKMGELM(craftingRoom, ZoneType.DiningRoom | ZoneType.CraftingRoom, mOFKEDGAOEE);
			break;
		case ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom:
			DNFBEGLBKNC(tavernFloor, ZoneType.WithoutZone | ZoneType.DiningRoom, mOFKEDGAOEE);
			break;
		case ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop:
			HHHGCOKNLMJ(cellar, ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.MetalWorkshop, mOFKEDGAOEE);
			break;
		}
		Debug.Log((object)("No se encontró una entrada con ID {0} en la conversación '{1}'." + GIBJPCAFCJB));
		PNBGPNKNFDG();
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		switch (GIBJPCAFCJB)
		{
		case ZoneType.CraftingRoom:
		case ZoneType.DiningRoom | ZoneType.CraftingRoom:
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(TavernFloor.FirstFloor | TavernFloor.SecondFloor);
			break;
		case ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.Cellar | ZoneType.WoodWorkshop):
			GameManager.NJNFHEPLEHL().JIOFFKMPJPO(TavernFloor.Cellar);
			break;
		}
		OnRoomUpgradeEnd();
	}

	[SpecialName]
	public static RoomUpgrader LDBJELPPBAI()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RoomUpgrader>();
		}
		return IADEMLIIDPC;
	}

	private void OFCIHAKBLIM(UpgradeRoomInfo GMKGCGFCNNM, ZoneType GIBJPCAFCJB, int MOFKEDGAOEE)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (MOFKEDGAOEE >= GMKGCGFCNNM.upgrades.Length)
		{
			return;
		}
		GMKGCGFCNNM.upgrades[MOFKEDGAOEE].GHILLIKFMPC();
		if (GMKGCGFCNNM.moveObjects != null)
		{
			Vector3 val = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[0].baseFrom.position - GMKGCGFCNNM.upgrades[MOFKEDGAOEE].corners[1].cornerFrom.position;
			for (int i = 1; i < GMKGCGFCNNM.moveObjects.Length; i++)
			{
				if (i < GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation.Length)
				{
					GMKGCGFCNNM.moveObjects[i].transform.position = GMKGCGFCNNM.upgrades[MOFKEDGAOEE].moveObjectsLocation[i].position + val;
				}
			}
		}
		upgrades[GIBJPCAFCJB] = MOFKEDGAOEE + 1;
	}
}
