using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadTavernFloor : OnlineLoadBase
{
	[Serializable]
	private class LoadFloorTilesMessage : LoadMessageBase
	{
		[JsonProperty("fT")]
		public FloorTilesMessage floorTilesMessage;

		public LoadFloorTilesMessage()
		{
			floorTilesMessage = default(FloorTilesMessage);
		}

		public override void OEJJGDMKIDN()
		{
			if (OnlineLoadManager.instance.OEBNHGNJEJL && Application.isEditor)
			{
				Debug.Log((object)("Loading tavern floor tiles (ONLINE) " + PhotonNetwork.LocalPlayer.ActorNumber + " " + floorTilesMessage.floorTilesArray.Length));
			}
			floorTilesMessage.OEJJGDMKIDN();
		}
	}

	private void LAHJPEDKLFO()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.JLDPLJGPKEF())
		{
			Debug.Log((object)("Tile_{0}_{1}" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.IAMBLEDHGDM(SeasonManager.KCJFCHNPIBJ());
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Floor && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void FOIHBDHGHDA()
	{
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("TrayTrigger" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EEGJBDCBKFD());
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.JBILDINJENF();
		Debug.Log((object)"tutorialPopUp120");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate());
	}

	private void GNJHGCGJMAG()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("Items/item_description_1085" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemaps = tilemapScene.GetTilemaps(SeasonManager.BLCGOEMGKGH());
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.Ground | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	[PunRPC]
	private void ReceiveInfoWorldTiles(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void ALGMBJIHGHC()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Validación completada con {0} error(es)." + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.KIMMMFKFCEK(SeasonManager.KCJFCHNPIBJ());
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
	}

	private void PFBBNBHBBJD()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("ReceiveJumpFerro" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.EMHLLEFBBCO(SeasonManager.NHKAHEEGEGF());
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.None && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
	}

	private void MLPCGNFNFJO()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Items/item_description_673" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.BNMLDAPCNKF(SeasonManager.LPGPJPPLHKG());
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.Ground) && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void ENIKFBIIJGN()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Reputation decreased..." + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.IAMBLEDHGDM(SeasonManager.PJMGHIMKFJL());
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.None && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
	}

	public override void LoadMessageEnd()
	{
		MIPELIMPPFD();
	}

	private void OBHIINAKFEC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void HHMPMHENPKP()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("MainProgress" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.IAMBLEDHGDM(SeasonManager.EEGJBDCBKFD());
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Floor && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void LFNBCEFGLMI()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.PAPOINPJJBL())
		{
			Debug.Log((object)("Mussel without parent!" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.IAMBLEDHGDM(SeasonManager.KCJFCHNPIBJ());
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void LIBCCJJKMDE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void DIACJPMJJAN()
	{
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("Items/item_description_597" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.NHKAHEEGEGF());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().CalculateCameraBoundsNextFrame();
		Debug.Log((object)"Target frame rate (");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).HNLGGMFFFIM());
	}

	private void LCPBECLKHLE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void DLDOLFFOEOG()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Player" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.FGKDPLDANOA(SeasonManager.ADEICKHEPFI());
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 1; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Floor && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void CAHGFHCADAI()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Item with id " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.EMHLLEFBBCO(SeasonManager.PJMGHIMKFJL());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.None && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void IHOGPKBHGAI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void NNALMIHILLM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void AIMNEDEOOOC()
	{
		if (OnlineLoadManager.instance.DPAEPNBJAMP())
		{
			Debug.Log((object)("End" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EEGJBDCBKFD());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().CalculateCameraBoundsNextFrame();
		Debug.Log((object)"Y");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).IBGBCHLIEGH());
	}

	private void GEAPHCNALEN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void FMDGBADFBFP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void KFPOPDJJFGD()
	{
		if (OnlineLoadManager.instance.JLDPLJGPKEF())
		{
			Debug.Log((object)("Item " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EEGJBDCBKFD());
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.CalculateCameraBoundsNextFrame();
		Debug.Log((object)"Disappear");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate());
	}

	private void FFEGBFPJKDF()
	{
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("BuildingTutorialOnlyHost" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EECEKHKAAIH);
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.JBILDINJENF();
		Debug.Log((object)"ChessPillarInteractable not assigned");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate());
	}

	private void EAPMPIMDJPP()
	{
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("] " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.ADEICKHEPFI());
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.JBILDINJENF();
		Debug.Log((object)"{0}: {1}\n");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA());
	}

	private void NOALHNJCDAJ()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("itemAubergine" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.KIMMMFKFCEK(SeasonManager.ADEICKHEPFI());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.None && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void EHNLBDKIMHB()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("nextNodes NOT free. timer: " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.BNMLDAPCNKF(SeasonManager.NHKAHEEGEGF());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void APONEDGLNKH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void POKDJJCFHDE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void JAPLHOFPAAO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void FKFBFGOHGNA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void JIBPMOJMGMO()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("HaveGoldenTicket" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.OEMIKEDPIKP(SeasonManager.PJMGHIMKFJL());
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Ground && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void KKNCMJJCAOE()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("Sharp" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.BNMLDAPCNKF(SeasonManager.KCJFCHNPIBJ());
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Grass && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void BEKLIFNJKEF()
	{
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("ReceivInstantiateHoleInGround" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EECEKHKAAIH);
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.CalculateCameraBoundsNextFrame();
		Debug.Log((object)"");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.None).IBGBCHLIEGH());
	}

	private void IEDDGMIGDEI()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("BrockProgress" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.OEMIKEDPIKP(SeasonManager.BLCGOEMGKGH());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Grass && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
	}

	private void KJPBCBNHPFF()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("Removing tavern floor tiles (ONLINE) " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemaps = tilemapScene.GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Floor && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
	}

	private void BFCOCJNHGIO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void MBNDKHHIGHI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void JLCAFMIGPJJ()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("_EnvMatrix" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.EMHLLEFBBCO(SeasonManager.LPGPJPPLHKG());
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void HDPOFICOJAE()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Quest 39 done, complete mission 301" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemaps = tilemapScene.GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.Ground) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void FHOFLEIMDAO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void FMILMOKPLED()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.DPAEPNBJAMP())
		{
			Debug.Log((object)("ReceiveAskForRockStartInfo" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.BNMLDAPCNKF(SeasonManager.ADEICKHEPFI());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Ground && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
	}

	private void HNOPKFDDPKK()
	{
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)(" " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.KCJFCHNPIBJ());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().CalculateCameraBoundsNextFrame();
		Debug.Log((object)"Items/item_description_1187");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).IBGBCHLIEGH());
	}

	private void AMDBKMDIBMM()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Giving extra wood planks" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.EMHLLEFBBCO(SeasonManager.EECEKHKAAIH);
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Grass && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void DEBOCJIBABP()
	{
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("00" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.KCJFCHNPIBJ());
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.JBILDINJENF();
		Debug.Log((object)"UseHold");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA());
	}

	private void HPKKLKBHIAK()
	{
		if (OnlineLoadManager.instance.PAPOINPJJBL())
		{
			Debug.Log((object)("</color>\n" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.KCJFCHNPIBJ());
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.CalculateCameraBoundsNextFrame();
		Debug.Log((object)"RochelleProgress");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
	}

	private void LIAPMLKFHPO()
	{
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Player" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.BLCGOEMGKGH());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().CalculateCameraBoundsNextFrame();
		Debug.Log((object)"popUpBuilding36");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.Tavern).HNLGGMFFFIM());
	}

	private void LCDLFCAEIDK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	public override void LoadMessageStart()
	{
		KJPBCBNHPFF();
	}

	private void BIDBCPMIAIF()
	{
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("itemAromaHopsSeeds" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.KCJFCHNPIBJ());
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.CalculateCameraBoundsNextFrame();
		Debug.Log((object)"talentChairs");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
	}

	private void GCLMJADHPIH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void PCIOAPPJECO()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("Inventory full" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemaps = tilemapScene.GetTilemaps(SeasonManager.KCJFCHNPIBJ());
		Vector3Int[] array = tilemapScene.IBGBCHLIEGH();
		for (int i = 1; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.TilledEarth && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
	}

	private void MADPJBPFGGB()
	{
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("Player" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.KCJFCHNPIBJ());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().JBILDINJENF();
		Debug.Log((object)"Player");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate());
	}

	private void OMCEKDJMDHJ()
	{
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/24/Dialogue Text" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EECEKHKAAIH);
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.CalculateCameraBoundsNextFrame();
		Debug.Log((object)"mForMins");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).IBGBCHLIEGH());
	}

	private void FKCPBFAHOAC()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.JLDPLJGPKEF())
		{
			Debug.Log((object)(")" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.BNMLDAPCNKF(SeasonManager.KCJFCHNPIBJ());
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	private void FKGOJPCBGPP()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Trough" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.FGKDPLDANOA(SeasonManager.NHKAHEEGEGF());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void MJJPPOAODJH()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("The tavern is still open, are you sure you want to sleep?\n The tavern will close and you might lose reputation." + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.FGKDPLDANOA(SeasonManager.PJMGHIMKFJL());
		Vector3Int[] array = tilemapScene.CIOLICLDNLA();
		for (int i = 1; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.TilledEarth && WorldGrid.HJPCBBGHPDA(val) == Location.None)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
	}

	private void JCDHNMAMJIA()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("0" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemapGroup = tilemapScene.IAMBLEDHGDM(SeasonManager.EEGJBDCBKFD());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 0; i < allPositionsToCalculate.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.Grass && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: true, IAPJDPFPNOA: false);
	}

	private void KHJMKNCKNGO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void OPOIIOHMKPH()
	{
		if (OnlineLoadManager.instance.PAPOINPJJBL())
		{
			Debug.Log((object)("Year" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.LPGPJPPLHKG());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().JBILDINJENF();
		Debug.Log((object)"Sleep");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.Tavern).HNLGGMFFFIM());
	}

	private void CJIMFBAOHGG()
	{
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Dialogue System/Conversation/Gass_Quest/Entry/17/Dialogue Text" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.ADEICKHEPFI());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().JBILDINJENF();
		Debug.Log((object)"ThemeListScrollView");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.None), Utils.JGEPCPFJANP(Location.None).CIOLICLDNLA());
	}

	private void CGHDGJIFBEF()
	{
		if (OnlineLoadManager.instance.DPAEPNBJAMP())
		{
			Debug.Log((object)("Items/item_description_1076" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EEGJBDCBKFD());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().JBILDINJENF();
		Debug.Log((object)"MissionTalkWith: NPC not found for character ");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).CIOLICLDNLA());
	}

	private void MMGDJFMGJPH()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)(":" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.BNMLDAPCNKF(SeasonManager.LPGPJPPLHKG());
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Ground | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadFloorTilesMessage worldTilesInfo = new LoadFloorTilesMessage();
		List<FloorTileMessage> worldTilesList = new List<FloorTileMessage>();
		int i = 0;
		int numMessages = 0;
		List<Vector3> list = GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.Keys.ToList();
		foreach (Vector3 item2 in list)
		{
			if ((Object)(object)Utils.JGEPCPFJANP(Vector2.op_Implicit(item2)) != (Object)null && Utils.JGEPCPFJANP(Vector2.op_Implicit(item2)).location == Location.Tavern && Utils.AOALMGABLGN(Vector2.op_Implicit(item2)) && WorldGrid.EJCEAEPNJCA(item2))
			{
				if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(item2, out var value))
				{
					FloorTileMessage item = new FloorTileMessage(item2, value);
					worldTilesList.Add(item);
				}
				i++;
			}
			if (i >= OnlineManager.LMALNDLJILM.MessageLimits.TavernFloorTilesPerMessage)
			{
				i = 0;
				worldTilesInfo.floorTilesMessage.floorTilesArray = worldTilesList.ToArray();
				AHGEFIOOEBL("ReceiveInfoWorldTiles", targetPlayer, worldTilesInfo, numMessages++);
				worldTilesList.Clear();
				yield return OnlineLoadManager.LICLEEOILOO;
			}
		}
		worldTilesInfo.floorTilesMessage.floorTilesArray = worldTilesList.ToArray();
		AHGEFIOOEBL("ReceiveInfoWorldTiles", targetPlayer, worldTilesInfo, numMessages, KJOOOPJKLBB: true);
	}

	private void KFIHECMPCDP()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)(": " + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.None);
		TilemapGroup tilemaps = tilemapScene.GetTilemaps(SeasonManager.ADEICKHEPFI());
		Vector3Int[] array = tilemapScene.HNLGGMFFFIM();
		for (int i = 0; i < array.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(array[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == (GroundType.Grass | GroundType.TilledEarth) && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void JJJOLNMPNBP()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineLoadManager.instance.IKGBELIFJPE())
		{
			Debug.Log((object)("Invalid NPC photonID: {0} for NPCRoutine." + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		List<Vector2> list = new List<Vector2>();
		TilemapScene tilemapScene = Utils.JGEPCPFJANP(Location.Tavern);
		TilemapGroup tilemapGroup = tilemapScene.IAMBLEDHGDM(SeasonManager.PJMGHIMKFJL());
		Vector3Int[] allPositionsToCalculate = tilemapScene.GetAllPositionsToCalculate();
		for (int i = 1; i < allPositionsToCalculate.Length; i += 0)
		{
			Vector3 val = ((GridLayout)tilemapGroup.floorUpperTilemap).CellToWorld(allPositionsToCalculate[i]);
			if (WorldGrid.NCEHFMPBBAK(val) == GroundType.TilledEarth && WorldGrid.HJPCBBGHPDA(val) == Location.Tavern)
			{
				list.Add(Vector2.op_Implicit(val));
			}
		}
		WorldGrid.GDJFGIPMBAH(list);
	}

	private void BIGKBENALCA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadFloorTilesMessage>(OINICMNOLPK);
	}

	private void IPPIECGCJIB()
	{
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("Already Travelling" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.ADEICKHEPFI());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().JBILDINJENF();
		Debug.Log((object)"CheckTableSprites");
		WorldGrid.FBLEBPPKHDA(TileType.WallBack, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate());
	}

	private void MIPELIMPPFD()
	{
		if (OnlineLoadManager.instance.OEBNHGNJEJL)
		{
			Debug.Log((object)("RecalculatingAllWallTiles (ONLINE) [client]" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.EECEKHKAAIH);
		WorldGrid.ODHKJKNHKGB();
		GameManager.GGFJGHHHEJC.CalculateCameraBoundsNextFrame();
		Debug.Log((object)"Update all floor");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
	}

	private void OKBLHAPFLOD()
	{
		if (OnlineLoadManager.instance.KDJIJGOBIEG())
		{
			Debug.Log((object)("Disappear" + PhotonNetwork.LocalPlayer.ActorNumber));
		}
		WorldGrid.OENGJCPDBKH(SeasonManager.KCJFCHNPIBJ());
		WorldGrid.ODHKJKNHKGB();
		GameManager.NJNFHEPLEHL().JBILDINJENF();
		Debug.Log((object)"GuestConnecting");
		WorldGrid.FBLEBPPKHDA(TileType.Floor, Utils.JGEPCPFJANP(Location.None));
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		WorldGrid.CLEOLJFAOCP(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.None).GetAllPositionsToCalculate());
	}
}
