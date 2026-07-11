using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadTerrain : OnlineLoadBase
{
	[Serializable]
	private class LoadTerrainMessage : LoadMessageBase
	{
		[JsonProperty("1")]
		public TerrainMessage[] worldTilesInfo;

		public override void OEJJGDMKIDN()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < worldTilesInfo.Length; i++)
			{
				Vector3 iMOBLFMHKOD = Vector2.op_Implicit(Utils.NKGANMEKDAL(Utils.NGIEAJCBLBC(worldTilesInfo[i].position)) + Vector2.one * 0.25f);
				GroundType groundType = (GroundType)worldTilesInfo[i].groundType;
				switch (groundType)
				{
				case GroundType.TilledEarth:
					Utils.LMLJCGOJFAH(iMOBLFMHKOD, worldTilesInfo[i].daysUntilDry);
					break;
				case GroundType.Grass:
				case GroundType.Ground:
					WorldGrid.MMOHADHAAGD(iMOBLFMHKOD, groundType, Location.Road);
					break;
				default:
					Utils.LMLJCGOJFAH(iMOBLFMHKOD, worldTilesInfo[i].daysUntilDry);
					break;
				}
				if (worldTilesInfo[i].hasSnow)
				{
					WorldGrid.AAFPODGPJMP(iMOBLFMHKOD, DNMKMKDAENO: true);
				}
			}
		}
	}

	[Serializable]
	public struct TerrainMessage
	{
		[JsonProperty("1")]
		public Int16Vector2 position;

		[JsonProperty("2")]
		public byte groundType;

		[JsonProperty("3")]
		public bool hasSnow;

		[JsonProperty("4")]
		public byte daysUntilDry;
	}

	private void CNJFELPHBIP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void NBEOEFEIBHA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void JADNEGBBFHL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void GMKFKPJKEHD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void CNGKHCMLFBL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	public override void LoadMessageStart()
	{
		base.LoadMessageStart();
		SnowGenerator.instance.RemoveSnowInWinterTilemap();
		Utils.fertilSoilPositions = new HashSet<Vector3>();
	}

	private void PKCINNGPCPA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void LODEKLIELGF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void DJLLLLOAEON(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadTerrainMessage worldTilesInfo = new LoadTerrainMessage();
		List<TerrainMessage> worldTilesList = new List<TerrainMessage>();
		int j = 0;
		int numMessages = 0;
		TilemapGroup tilemaps = Utils.JGEPCPFJANP(Location.Road).GetTilemaps(SeasonManager.EECEKHKAAIH);
		Vector3Int[] allPositions = Utils.JGEPCPFJANP(Location.Road).GetAllPositionsToCalculate();
		for (int i = 0; i < allPositions.Length; i++)
		{
			Vector3 val = ((GridLayout)tilemaps.floorUpperTilemap).CellToWorld(allPositions[i]);
			if (!WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO))
			{
				continue;
			}
			if (ILDEFBIANKO.zoneType == ZoneType.WithoutZone && ILDEFBIANKO.groundType != 0)
			{
				TerrainMessage item = default(TerrainMessage);
				item.position = Utils.LKAIECNLMDI(Vector2.op_Implicit(val));
				item.groundType = (byte)ILDEFBIANKO.groundType;
				if (SeasonManager.EECEKHKAAIH == Season.Winter)
				{
					item.hasSnow = ILDEFBIANKO.hasSnow;
				}
				else
				{
					item.hasSnow = false;
				}
				if (ILDEFBIANKO.farmable && ILDEFBIANKO.groundType == GroundType.TilledEarth)
				{
					FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(val + new Vector3(0.25f, 0.25f, 0f)));
					if ((Object)(object)fertileSoil != (Object)null)
					{
						item.daysUntilDry = (byte)fertileSoil.daysUntilDry;
					}
				}
				worldTilesList.Add(item);
				j++;
			}
			if (j >= OnlineManager.LMALNDLJILM.MessageLimits.TerrainWorldTilesPerMessage)
			{
				j = 0;
				worldTilesInfo.worldTilesInfo = worldTilesList.ToArray();
				AHGEFIOOEBL("ReceiveInfoTerrain", targetPlayer, worldTilesInfo, numMessages++);
				worldTilesList.Clear();
				yield return OnlineLoadManager.LICLEEOILOO;
			}
		}
		worldTilesInfo.worldTilesInfo = worldTilesList.ToArray();
		AHGEFIOOEBL("ReceiveInfoTerrain", targetPlayer, worldTilesInfo, numMessages, KJOOOPJKLBB: true);
	}

	private void JDBMGBCCBJB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void DPBAGLLGNBG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void KLJBJJAOKBA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void NMEBLKLKHGN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void JLAMAGMJHIH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void BBNCCCGKMGJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void EOKDBBJGIMO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void HEIFPKHKFNA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void JLFNLBLDIBF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void MKPMOPJPBCM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void GJBMPHFGLPD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void KEKIGLBFJCE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void APLJABDBKFM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void DMKMOHJKCDA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void HLCDEGBNDGI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void OFFIPKKGFNN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void KOFFFPGBJDK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void NLECDCJGIOG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void OEIFJLEJFBB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void NGPKNIPHIPO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void CPFFMIGGEHO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void MKLPDIJPDGB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void MGEGBGIHKIF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveInfoTerrain(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void PDGKIFAFGJK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void GCKHMHAPCBK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void IELBLAGEBOC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void JKOJFMCONHH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void KGKGBIDMKBP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}

	private void FLOENHODHCH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadTerrainMessage>(OINICMNOLPK);
	}
}
