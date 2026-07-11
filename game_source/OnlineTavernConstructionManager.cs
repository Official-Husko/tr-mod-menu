using System.Collections.Generic;
using Newtonsoft.Json;
using Photon.Pun;
using UnityEngine;

public class OnlineTavernConstructionManager : MonoBehaviourPunCallbacks
{
	public class DecorationIdsMessage : IOnlineSerializable
	{
		[JsonProperty("1")]
		public short[] decoFloorId;

		[JsonProperty("2")]
		public short[] decoWallId;

		[JsonProperty("3")]
		public short[] decoTrimId;
	}

	public static OnlineTavernConstructionManager instance;

	public bool tavernConstructionOpenedByOtherPlayer;

	private float[] LGIGGPIMCFL;

	private float[] FNBEEDCNFKL;

	private short[] DBPCMLBIOBB;

	private TilemapScene ALIKBMPCFFB;

	private void BANEBENHFPM(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			TavernZonesManager.GGFJGHHHEJC.CDGLOEGCAHJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.JEEGOBGDLPE().IEFPCLKKGOJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 336f)), MEPFCAODGLH: false);
			TavernZonesManager.IECOPNFJBFD().KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 835f, FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.GGFJGHHHEJC.KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 1321f, FNBEEDCNFKL[i] + 1561f)));
		}
	}

	public void INAIIJAKFHP(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = (byte)CHFHMMNELGP;
			array[0] = LGIGGPIMCFL;
			array[3] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "Starting Pirates Intro Event", (RpcTarget)0, array);
		}
	}

	public void SendConstructionModeClosed()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveConstructionModeClosed", (RpcTarget)1);
	}

	public void CMBBIJBHCIN(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = LGIGGPIMCFL;
			array[0] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "LE_3", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceiveAllDecorations(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte[] PJBDAGKAAHK)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = OnlineSerializer.Deserialize<DecorationIdsMessage>(PJBDAGKAAHK);
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			DFOCOBBANCG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoFloorId[i]);
			GMJKGOMFCNO(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoWallId[i]);
			DAAPAKEGBNJ(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoTrimId[i]);
		}
	}

	public void JPBLMFDFNEE(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<FloorTileMessage> list = new List<FloorTileMessage>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(HAEIAGKNEPC[i]), out var value))
			{
				FloorTileMessage item = new FloorTileMessage(Vector2.op_Implicit(HAEIAGKNEPC[i]), value);
				list.Add(item);
			}
		}
		FloorTilesMessage floorTilesMessage = default(FloorTilesMessage);
		floorTilesMessage.floorTilesArray = list.ToArray();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(floorTilesMessage);
		OnlineManager.SendRPC(photonView, "christmas", (RpcTarget)1, array);
	}

	private void GMJKGOMFCNO(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0f, 0.5f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0.5f)), PDFCJKGICHJ);
	}

	[PunRPC]
	private void ReceiveDecorationTrim(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			DAAPAKEGBNJ(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	private void JDHHJKBOJML()
	{
		instance = this;
	}

	public void FKOCADHKBAK(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[5];
			array[1] = LGIGGPIMCFL;
			array[1] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "DueloDeViejos/MainEvent3", (RpcTarget)0, array);
		}
	}

	public void KFLLFNLANEI(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[6];
			array2[0] = (byte)GIBJPCAFCJB;
			array2[1] = LGIGGPIMCFL;
			array2[7] = FNBEEDCNFKL;
			array2[2] = array;
			OnlineManager.SendRPC(photonView, "Tutorial/T", (RpcTarget)1, array2);
		}
	}

	private void MJPKBOMFDNN(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(569f, 961f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(980f, 1135f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1355f, 586f)), PDFCJKGICHJ);
	}

	public void ELOJLDGNPDE(List<Vector2> HAEIAGKNEPC)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		OnlineManager.SendRPC(photonView, "Quit to title screen?", (RpcTarget)1, array);
	}

	private void KGNKAMMIMPH()
	{
		BuildingTutorialManager.instance.OKAHJLPLFGA(AODONKKHPBP: false);
	}

	private void ODJIEOHJLDP()
	{
		BuildingTutorialManager.instance.OKAHJLPLFGA(AODONKKHPBP: true);
	}

	public void LMMFPCCOMFH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Wilson/Stand", (RpcTarget)0);
	}

	public void MKBNGCHGBGC(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = LGIGGPIMCFL;
			array[1] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "ReceiveBirdMessage", (RpcTarget)0, array);
		}
	}

	private void FAJCGAAIOAD(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			TavernZonesManager.IECOPNFJBFD().KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.GGFJGHHHEJC.CDGLOEGCAHJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 616f)));
			TavernZonesManager.LANAINBEMCM().KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 518f, FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.OIJLJKLMCBO().RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 985f, FNBEEDCNFKL[i] + 622f)), MEPFCAODGLH: false);
		}
	}

	public void GFMNAMKMHCO(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "TavernServiceManager instance is null", (RpcTarget)1, (byte)GIBJPCAFCJB, LGIGGPIMCFL, FNBEEDCNFKL, null, null, null, null, array);
		}
	}

	private void GPCHLCGCCDL(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.ChangeZone((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	public void ADIFKKLNODO(List<Vector2> HAEIAGKNEPC)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		OnlineManager.SendRPC(photonView, "ReciveResetDialogueUPetShop", (RpcTarget)1, array);
	}

	public void LJHLCKOPJAF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_10", (RpcTarget)0);
	}

	private void OAFLGJKMECI(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte[] PJBDAGKAAHK)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = OnlineSerializer.Deserialize<DecorationIdsMessage>(PJBDAGKAAHK);
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			AKHBOCNEIOG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoFloorId[i]);
			GCPDHKHENCE(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoWallId[i]);
			ACADACLGHLG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoTrimId[i]);
		}
	}

	[PunRPC]
	private void ReceiveDecorationFloor(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			DFOCOBBANCG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	public void NMIACPPGLMI(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[3];
			array2[1] = (byte)GIBJPCAFCJB;
			array2[0] = LGIGGPIMCFL;
			array2[1] = FNBEEDCNFKL;
			array2[6] = array;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text", (RpcTarget)1, array2);
		}
	}

	private void DDGDDMNPANP(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.GCFACJDLJKN((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	private void CLKGMPMGEHA(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(864f, 1662f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1682f, 1468f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(403f, 1922f)), PDFCJKGICHJ);
	}

	private void NKPAAIJMMJM(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1250f, 1871f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1080f, 1317f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1113f, 224f)), PDFCJKGICHJ);
	}

	public void AIFDLOGGEPB(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = (byte)CHFHMMNELGP;
			array[1] = LGIGGPIMCFL;
			array[0] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/TooCold/Entry/1/Dialogue Text", (RpcTarget)0, array);
		}
	}

	public void SendDecorationFloor(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDecorationFloor", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, DBPCMLBIOBB);
	}

	private void OGMFCPGGGLH(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1680f, 486f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1125f, 754f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1020f, 524f)), PDFCJKGICHJ);
	}

	private void Awake()
	{
		instance = this;
	}

	private void FEHFKEDIFLD(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(287f, 297f)), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(581f, 546f)), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(748f, 1649f)), PDFCJKGICHJ, BBHMAKKPFKB: false);
	}

	public void AEEPNFGKFDE(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = LGIGGPIMCFL;
		array[1] = FNBEEDCNFKL;
		array[8] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "</color>", (RpcTarget)1, array);
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	public void BEKCANOOIND()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Disabled", (RpcTarget)0);
	}

	public void IKPNPIBKMME(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemDarkMaltedBarley", (RpcTarget)0, LGIGGPIMCFL, FNBEEDCNFKL, null, null, null, DBPCMLBIOBB);
	}

	private void BILKGEKBDNK(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1744f, 1868f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(251f, 27f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(618f, 1563f)), PDFCJKGICHJ);
	}

	public void SendChangeZone(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChangeZone", (RpcTarget)1, (byte)CHFHMMNELGP, LGIGGPIMCFL, FNBEEDCNFKL);
		}
	}

	[PunRPC]
	private void ReceiveAddZone(byte ANOAHJJFKOJ, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] MLFFJIBFNLG)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			if (MLFFJIBFNLG[i] != -1)
			{
				TavernZone tavernZone = TavernZonesManager.GGFJGHHHEJC.GetTavernZone((int)MLFFJIBFNLG[i]);
				if (tavernZone == null)
				{
					tavernZone = TavernZonesManager.GGFJGHHHEJC.CreateTavernZone((ZoneType)ANOAHJJFKOJ, MLFFJIBFNLG[i]);
				}
				tavernZone.FODNDCDLFPL(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])));
				tavernZone.FODNDCDLFPL(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 0.5f)));
				tavernZone.FODNDCDLFPL(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 0.5f, FNBEEDCNFKL[i])));
				tavernZone.FODNDCDLFPL(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 0.5f, FNBEEDCNFKL[i] + 0.5f)));
			}
		}
	}

	private void HNLNNGPAEMP(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i += 0)
		{
			TavernZonesManager.NHKAFANMEJC().CDGLOEGCAHJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.NHKAFANMEJC().CDGLOEGCAHJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 597f)), MEPFCAODGLH: false);
			TavernZonesManager.LANAINBEMCM().KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 815f, FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.NHKAFANMEJC().KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 1690f, FNBEEDCNFKL[i] + 675f)), MEPFCAODGLH: false);
		}
	}

	public void JEFBPLHKHOI(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = new DecorationIdsMessage();
		decorationIdsMessage.decoFloorId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoWallId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoTrimId = new short[HAEIAGKNEPC.Count];
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			decorationIdsMessage.decoFloorId[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoWallId[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoTrimId[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Eat", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, null, null, null, OnlineSerializer.EKNOFIJNBAP(decorationIdsMessage), null, null);
	}

	public void PMKGKGPCKKF(List<Vector2> HAEIAGKNEPC)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "}", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, null, null, null, null);
	}

	public void IKDCNKBIKCE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UINextPage", (RpcTarget)0);
	}

	public void SendAddZone(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddZone", (RpcTarget)1, (byte)GIBJPCAFCJB, LGIGGPIMCFL, FNBEEDCNFKL, array);
		}
	}

	public void GFBBOIPFMGL(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[4];
			array2[0] = (byte)GIBJPCAFCJB;
			array2[1] = LGIGGPIMCFL;
			array2[0] = FNBEEDCNFKL;
			array2[3] = array;
			OnlineManager.SendRPC(photonView, "PlayerPlatformIDRPC", (RpcTarget)1, array2);
		}
	}

	public void SendAddFloor(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<FloorTileMessage> list = new List<FloorTileMessage>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(HAEIAGKNEPC[i]), out var value))
			{
				FloorTileMessage item = new FloorTileMessage(Vector2.op_Implicit(HAEIAGKNEPC[i]), value);
				list.Add(item);
			}
		}
		FloorTilesMessage floorTilesMessage = default(FloorTilesMessage);
		floorTilesMessage.floorTilesArray = list.ToArray();
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddFloor", (RpcTarget)1, OnlineSerializer.Serialize(floorTilesMessage));
	}

	public void HCIJCNJCLKN(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<FloorTileMessage> list = new List<FloorTileMessage>();
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(HAEIAGKNEPC[i]), out var value))
			{
				FloorTileMessage item = new FloorTileMessage(Vector2.op_Implicit(HAEIAGKNEPC[i]), value);
				list.Add(item);
			}
		}
		FloorTilesMessage floorTilesMessage = default(FloorTilesMessage);
		floorTilesMessage.floorTilesArray = list.ToArray();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(floorTilesMessage);
		OnlineManager.SendRPC(photonView, "ChatInviteCode", (RpcTarget)1, array);
	}

	public void FMOJFNDKMMO(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		array[4] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "LearnBalance", (RpcTarget)0, array);
	}

	public void SendAllDecorations(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = new DecorationIdsMessage();
		decorationIdsMessage.decoFloorId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoWallId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoTrimId = new short[HAEIAGKNEPC.Count];
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			decorationIdsMessage.decoFloorId[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoWallId[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoTrimId[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAllDecorations", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, OnlineSerializer.Serialize(decorationIdsMessage));
	}

	[PunRPC]
	private void ReceiveConstructionModeOpened()
	{
		tavernConstructionOpenedByOtherPlayer = true;
		TavernConstructionManager.GGFJGHHHEJC.KickOutPlayersFromTavern(1, GFNHAMCPEAK: false);
		if (Object.op_Implicit((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC))
		{
			((Component)SpawnCat.GGFJGHHHEJC.catNPC).gameObject.SetActive(false);
		}
	}

	private void HJCFKAHKDBL(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.ChangeZone((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	private void DHIIABACJAA(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			AKHBOCNEIOG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	private void DGCHAJPDDHC(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte[] PJBDAGKAAHK)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = OnlineSerializer.Deserialize<DecorationIdsMessage>(PJBDAGKAAHK);
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			EEBCMJHINNC(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoFloorId[i]);
			AJPGNKDKHFB(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoWallId[i]);
			CLKGMPMGEHA(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoTrimId[i]);
		}
	}

	private void IOCPBIAMPIJ(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1163f, 1266f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1511f, 1057f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(298f, 1531f)), PDFCJKGICHJ);
	}

	public void BFBGFJIFKDD(List<Vector2> HAEIAGKNEPC)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		OnlineManager.SendRPC(photonView, "Bar", (RpcTarget)1, array);
	}

	private void AJFDNHMDNLD()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		tavernConstructionOpenedByOtherPlayer = true;
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
		GameManager.NJNFHEPLEHL().LMENPFIHNHP();
		WorldGrid.DKEHENLDNAG();
		if (Object.op_Implicit((Object)(object)SpawnCat.CHPEMJMLDCN().catNPC))
		{
			((Component)SpawnCat.GAGMPCEPONF().catNPC).gameObject.SetActive(false);
			if (OnlineManager.PGAGDFAEEFB())
			{
				((Component)SpawnCat.NEFIEJALANL().catNPC).transform.position = Utils.MNOPMFHOKNI();
				SpawnCat.GAGMPCEPONF().catNPC.PIOEMOGEOIN();
			}
		}
	}

	public void KBLDAMLLLEA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ".rtf", (RpcTarget)1);
	}

	private void EAEKPCBCGDE(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(660f, 1102f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(677f, 1328f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1260f, 891f)), PDFCJKGICHJ);
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	private void GIMAGBMGBKF(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			EAEKPCBCGDE(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	public void NFIIIBOHEGI(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<FloorTileMessage> list = new List<FloorTileMessage>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(HAEIAGKNEPC[i]), out var value))
			{
				FloorTileMessage item = new FloorTileMessage(Vector2.op_Implicit(HAEIAGKNEPC[i]), value);
				list.Add(item);
			}
		}
		FloorTilesMessage floorTilesMessage = default(FloorTilesMessage);
		floorTilesMessage.floorTilesArray = list.ToArray();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(floorTilesMessage);
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Stand/Entry/1/Dialogue Text", (RpcTarget)0, array);
	}

	public void OHBFBMLLEJM(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = LGIGGPIMCFL;
		array[1] = FNBEEDCNFKL;
		array[1] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "Current game language is ", (RpcTarget)1, array);
	}

	public void ONIKJBHJFPC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " already exists for ", (RpcTarget)0);
	}

	private void DPPFAMFBJPG(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte[] PJBDAGKAAHK)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = OnlineSerializer.Deserialize<DecorationIdsMessage>(PJBDAGKAAHK);
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			PCKEALACHGI(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoFloorId[i]);
			BILKGEKBDNK(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoWallId[i]);
			NIJECNOBION(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoTrimId[i]);
		}
	}

	private void JIBANBMDJNE(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(464f, 823f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1f, 1114f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1210f, 593f)), PDFCJKGICHJ);
	}

	private void DIIMPNHDLKI(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			CLKGMPMGEHA(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	public void BHIHMDKKKJD(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = LGIGGPIMCFL;
			array[0] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "LE_21", (RpcTarget)1, array);
		}
	}

	private void DFOCOBBANCG(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0f, 0.5f)), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0f)), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0.5f)), PDFCJKGICHJ);
	}

	public void GFNKONBIKBL(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = LGIGGPIMCFL;
		array[1] = FNBEEDCNFKL;
		array[2] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "Error max zones", (RpcTarget)0, array);
	}

	private void ACADACLGHLG(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1870f, 91f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(718f, 326f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(35f, 1465f)), PDFCJKGICHJ);
	}

	public void SendDecorationWall(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDecorationWall", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, DBPCMLBIOBB);
	}

	public void IDLGFIEPGBD(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = (byte)CHFHMMNELGP;
			array[0] = LGIGGPIMCFL;
			array[6] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "Items/item_name_725", (RpcTarget)1, array);
		}
	}

	private void PIHGEBONAOI()
	{
		instance = this;
	}

	private void FPPEMPBAICN(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			CLKGMPMGEHA(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	private void DCMPCKOAAPO(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			BILKGEKBDNK(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	[PunRPC]
	private void ReceiveDecorationWall(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			GMJKGOMFCNO(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}

	public void DDHCLIDGCHB(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[0] = (byte)CHFHMMNELGP;
			array[1] = LGIGGPIMCFL;
			array[2] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "vibrationP2", (RpcTarget)0, array);
		}
	}

	public void SendConstructionModeOpened()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveConstructionModeOpened", (RpcTarget)1);
	}

	private void KFJMDJDOGLF(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			TavernZonesManager.JEEGOBGDLPE().IEFPCLKKGOJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])));
			TavernZonesManager.NHKAFANMEJC().BFBEPPAPOAB(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 22f)));
			TavernZonesManager.EBAIHKJHCCA().BFBEPPAPOAB(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 830f, FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.EBAIHKJHCCA().IEFPCLKKGOJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 1521f, FNBEEDCNFKL[i] + 783f)));
		}
	}

	private void AKHBOCNEIOG(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(363f, 492f)), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1360f, 1292f)), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(804f, 148f)), PDFCJKGICHJ);
	}

	private void EKLNAJCMJKL(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.ChangeZone((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	private void AJPGNKDKHFB(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1436f, 586f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(553f, 1106f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(194f, 191f)), PDFCJKGICHJ);
	}

	private void HDOEOAHHCIC(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(801f, 259f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1140f, 760f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(619f, 722f)), PDFCJKGICHJ);
	}

	private void MALJHKPKGJG(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte[] PJBDAGKAAHK)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = OnlineSerializer.Deserialize<DecorationIdsMessage>(PJBDAGKAAHK);
		for (int i = 1; i < LGIGGPIMCFL.Length; i += 0)
		{
			DFOCOBBANCG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoFloorId[i]);
			AJPGNKDKHFB(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoWallId[i]);
			JIBANBMDJNE(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), decorationIdsMessage.decoTrimId[i]);
		}
	}

	private void PCKEALACHGI(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1228f, 688f)), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(54f, 915f)), PDFCJKGICHJ, BBHMAKKPFKB: false);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1222f, 653f)), PDFCJKGICHJ, BBHMAKKPFKB: false);
	}

	private void MCOGCJCGGJP(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.GCFACJDLJKN((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	public void KGLCPEDBEGH(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = LGIGGPIMCFL;
			array[0] = FNBEEDCNFKL;
			OnlineManager.SendRPC(photonView, "Occupied Positions", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceiveBuildingTutorialDone()
	{
		BuildingTutorialManager.instance.BPDDCBHKCME = true;
	}

	private void CIBJCLKKCJI(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.GCFACJDLJKN((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	public void JMHMPHJCPPB(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " occured during execution of GalaxyInstance.Storage.FileShare method", (RpcTarget)0, LGIGGPIMCFL, FNBEEDCNFKL, null, null, null, null, DBPCMLBIOBB);
	}

	public void NJCMMBNGJJI(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = LGIGGPIMCFL;
		array[1] = FNBEEDCNFKL;
		array[6] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "(missing title)", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveConstructionModeClosed()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		tavernConstructionOpenedByOtherPlayer = false;
		WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
		GameManager.GGFJGHHHEJC.CalculateAllCameraBounds();
		WorldGrid.DKEHENLDNAG();
		if (Object.op_Implicit((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC))
		{
			((Component)SpawnCat.GGFJGHHHEJC.catNPC).gameObject.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				((Component)SpawnCat.GGFJGHHHEJC.catNPC).transform.position = Utils.MNOPMFHOKNI();
				SpawnCat.GGFJGHHHEJC.catNPC.WalkAround();
			}
		}
	}

	private void GCPDHKHENCE(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(7f, 1242f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1772f, 75f)), PDFCJKGICHJ);
		WorldGrid.PIBHFFJJAFB(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1611f, 219f)), PDFCJKGICHJ);
	}

	private void BCDKDLJOGDO(byte ANOAHJJFKOJ, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] MLFFJIBFNLG)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			if (MLFFJIBFNLG[i] != -1)
			{
				TavernZone tavernZone = TavernZonesManager.OIJLJKLMCBO().GetTavernZone((int)MLFFJIBFNLG[i]);
				if (tavernZone == null)
				{
					tavernZone = TavernZonesManager.LANAINBEMCM().PLABGPPIOEG((ZoneType)ANOAHJJFKOJ, MLFFJIBFNLG[i]);
				}
				tavernZone.DLBJHNDLCKD(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])));
				tavernZone.DLBJHNDLCKD(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 1597f)));
				tavernZone.KANCPBBFDML(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 248f, FNBEEDCNFKL[i])));
				tavernZone.ILHBDFGHHJJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 1526f, FNBEEDCNFKL[i] + 566f)));
			}
		}
	}

	[PunRPC]
	private void ReceiveAddFloor(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<FloorTilesMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void CGNIBLNDELD(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<FloorTileMessage> list = new List<FloorTileMessage>();
		for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
		{
			if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(HAEIAGKNEPC[i]), out var value))
			{
				FloorTileMessage item = new FloorTileMessage(Vector2.op_Implicit(HAEIAGKNEPC[i]), value);
				list.Add(item);
			}
		}
		FloorTilesMessage floorTilesMessage = default(FloorTilesMessage);
		floorTilesMessage.floorTilesArray = list.ToArray();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(floorTilesMessage);
		OnlineManager.SendRPC(photonView, "NextToWall", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveRemoveFloor(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 0.5f));
			list.Add(new Vector2(LGIGGPIMCFL[i] + 0.5f, FNBEEDCNFKL[i]));
			list.Add(new Vector2(LGIGGPIMCFL[i] + 0.5f, FNBEEDCNFKL[i] + 0.5f));
		}
		WorldGrid.GDJFGIPMBAH(list, CIGOMGBFJGF: false, IAPJDPFPNOA: false);
	}

	public void MAHGEJAHJFB(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[3];
			array2[0] = (byte)GIBJPCAFCJB;
			array2[1] = LGIGGPIMCFL;
			array2[8] = FNBEEDCNFKL;
			array2[4] = array;
			OnlineManager.SendRPC(photonView, "Clean", (RpcTarget)1, array2);
		}
	}

	public void SendRemoveZone(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveZone", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL);
		}
	}

	public void EJEGOKCODNB(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Starting Tutorial Phase: ", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, null);
		}
	}

	[PunRPC]
	private void ReceiveRemoveZone(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			TavernZonesManager.GGFJGHHHEJC.RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])));
			TavernZonesManager.GGFJGHHHEJC.RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 0.5f)));
			TavernZonesManager.GGFJGHHHEJC.RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 0.5f, FNBEEDCNFKL[i])));
			TavernZonesManager.GGFJGHHHEJC.RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 0.5f, FNBEEDCNFKL[i] + 0.5f)));
		}
	}

	private void GPNEMMNPMOH(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.GCFACJDLJKN((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: true);
	}

	public void FIMCPJOGBJI(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[6];
			array2[0] = (byte)GIBJPCAFCJB;
			array2[1] = LGIGGPIMCFL;
			array2[6] = FNBEEDCNFKL;
			array2[1] = array;
			OnlineManager.SendRPC(photonView, "Get Components ", (RpcTarget)1, array2);
		}
	}

	private void FBEDFLGPDBK(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.GCFACJDLJKN((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	private void BMOPEDNMFED(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<FloorTilesMessage>(OINICMNOLPK).JMLOHCEJAOD();
	}

	public void SendRemoveFloor(List<Vector2> HAEIAGKNEPC)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveFloor", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL);
	}

	public void PPIOOJMBKKB(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[1];
			array2[1] = (byte)GIBJPCAFCJB;
			array2[1] = LGIGGPIMCFL;
			array2[5] = FNBEEDCNFKL;
			array2[5] = array;
			OnlineManager.SendRPC(photonView, "DisableRight", (RpcTarget)1, array2);
		}
	}

	public void DFJPAADHBIG(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = LGIGGPIMCFL;
		array[1] = FNBEEDCNFKL;
		array[8] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "ReceiveGetUniqueCropDay", (RpcTarget)0, array);
	}

	public void CAIEGKJBAID(EditorAction CHFHMMNELGP, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i++)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ClosePopUp", (RpcTarget)1, (byte)CHFHMMNELGP, LGIGGPIMCFL, null, FNBEEDCNFKL, null, null);
		}
	}

	private void COHDBPJPLNH()
	{
		tavernConstructionOpenedByOtherPlayer = false;
		TavernConstructionManager.GGFJGHHHEJC.IFGECHOJBBC(1, GFNHAMCPEAK: true);
		if (Object.op_Implicit((Object)(object)SpawnCat.GAGMPCEPONF().catNPC))
		{
			((Component)SpawnCat.MKIEMMGGFEE().catNPC).gameObject.SetActive(false);
		}
	}

	private void NIJECNOBION(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1765f, 825f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(938f, 1338f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(61f, 970f)), PDFCJKGICHJ);
	}

	public void FHJLACHFOEK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UI", (RpcTarget)1);
	}

	private void BEDAOOMDCPI(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i += 0)
		{
			TavernZonesManager.JEEGOBGDLPE().RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), MEPFCAODGLH: false);
			TavernZonesManager.HFHPMKJGMPA().RemoveTileFromZone(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 1321f)), MEPFCAODGLH: false);
			TavernZonesManager.LANAINBEMCM().IEFPCLKKGOJ(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 718f, FNBEEDCNFKL[i])));
			TavernZonesManager.IECOPNFJBFD().KJABCOJCOJF(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 934f, FNBEEDCNFKL[i] + 518f)), MEPFCAODGLH: false);
		}
	}

	public void MKCGCOCAAHB(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = new DecorationIdsMessage();
		decorationIdsMessage.decoFloorId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoWallId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoTrimId = new short[HAEIAGKNEPC.Count];
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			decorationIdsMessage.decoFloorId[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoWallId[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoTrimId[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		array[4] = OnlineSerializer.Serialize(decorationIdsMessage);
		OnlineManager.SendRPC(photonView, "Piso {0}: Generando {1} rocas en {2} spawners disponibles.", (RpcTarget)1, array);
	}

	public void KEIAHCGDOBM(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		List<FloorTileMessage> list = new List<FloorTileMessage>();
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			if (GameTileMaps.GGFJGHHHEJC.AAPNNPFLODM.TryGetValue(Vector2.op_Implicit(HAEIAGKNEPC[i]), out var value))
			{
				FloorTileMessage item = new FloorTileMessage(Vector2.op_Implicit(HAEIAGKNEPC[i]), value);
				list.Add(item);
			}
		}
		FloorTilesMessage floorTilesMessage = default(FloorTilesMessage);
		floorTilesMessage.floorTilesArray = list.ToArray();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(floorTilesMessage);
		OnlineManager.SendRPC(photonView, "Pants_R", (RpcTarget)1, array);
	}

	private void DIMAPDNCBAN()
	{
		instance = this;
	}

	public void SendDecorationTrim(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDecorationTrim", (RpcTarget)1, LGIGGPIMCFL, FNBEEDCNFKL, DBPCMLBIOBB);
	}

	private void KEFDBCCIKFF(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<FloorTilesMessage>(OINICMNOLPK).PFOHEFAMENI();
	}

	public void LHHGJILKOAC(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		array[0] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	public void HMPDLKGNOJA(ZoneType GIBJPCAFCJB, List<Vector2> HAEIAGKNEPC)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
			FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
			short[] array = new short[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
				FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
				array[i] = (short)WorldGrid.APJABAKKKGD(Vector2.op_Implicit(HAEIAGKNEPC[i]));
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[2];
			array2[1] = (byte)GIBJPCAFCJB;
			array2[1] = LGIGGPIMCFL;
			array2[6] = FNBEEDCNFKL;
			array2[5] = array;
			OnlineManager.SendRPC(photonView, "world door: ", (RpcTarget)0, array2);
		}
	}

	private void OBAEEEAHDKI(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.ChangeZone((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	private void DAAPAKEGBNJ(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0f, 0.5f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0f)), PDFCJKGICHJ);
		WorldGrid.IGFNOCNEHCO(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(0.5f, 0.5f)), PDFCJKGICHJ);
	}

	public void FBFOHMDCECE(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.None);
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = LGIGGPIMCFL;
		array[1] = FNBEEDCNFKL;
		array[8] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, "Cant pay current: ", (RpcTarget)0, array);
	}

	private void LAHLMMKOJLK(byte ANOAHJJFKOJ, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] MLFFJIBFNLG)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < LGIGGPIMCFL.Length; i++)
		{
			if (MLFFJIBFNLG[i] != -1)
			{
				TavernZone tavernZone = TavernZonesManager.OIJLJKLMCBO().PDINJGNEMGA(MLFFJIBFNLG[i]);
				if (tavernZone == null)
				{
					tavernZone = TavernZonesManager.GGFJGHHHEJC.KENNMEAJDNF((ZoneType)ANOAHJJFKOJ, MLFFJIBFNLG[i]);
				}
				tavernZone.FODNDCDLFPL(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])));
				tavernZone.HLKLCLAKAEC(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i] + 183f)));
				tavernZone.DLBJHNDLCKD(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 58f, FNBEEDCNFKL[i])));
				tavernZone.DLBJHNDLCKD(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i] + 1646f, FNBEEDCNFKL[i] + 939f)));
			}
		}
	}

	public void SendBuildingTutorialDone()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBuildingTutorialDone", (RpcTarget)1);
	}

	private void HFPDNCBLNDE()
	{
		instance = this;
	}

	private void EEBCMJHINNC(Vector2 IMOBLFMHKOD, short PDFCJKGICHJ)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1998f, 1983f)), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(301f, 170f)), PDFCJKGICHJ);
		WorldGrid.NLIPDGCAIEF(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(1316f, 1757f)), PDFCJKGICHJ);
	}

	public void ABCHHEMIKPB(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		DecorationIdsMessage decorationIdsMessage = new DecorationIdsMessage();
		decorationIdsMessage.decoFloorId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoWallId = new short[HAEIAGKNEPC.Count];
		decorationIdsMessage.decoTrimId = new short[HAEIAGKNEPC.Count];
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			decorationIdsMessage.decoFloorId[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoWallId[i] = (short)WorldGrid.IKCDANOHPJE(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
			decorationIdsMessage.decoTrimId[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Additions", (RpcTarget)0, LGIGGPIMCFL, FNBEEDCNFKL, null, null, OnlineSerializer.JBIPDCGKMGE(decorationIdsMessage));
	}

	public void APEBOJNPMNN(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.PNKHEBBCGMG(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		array[6] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveChangeZone(byte CHFHMMNELGP, float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		for (int i = 0; i < LGIGGPIMCFL.Length; i++)
		{
			list.Add(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]));
		}
		EditorTileMaps.ChangeZone((EditorAction)CHFHMMNELGP, list, GFNHAMCPEAK: false);
	}

	public void AAELMOFKIFM(List<Vector2> HAEIAGKNEPC)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		LGIGGPIMCFL = new float[HAEIAGKNEPC.Count];
		FNBEEDCNFKL = new float[HAEIAGKNEPC.Count];
		DBPCMLBIOBB = new short[HAEIAGKNEPC.Count];
		ALIKBMPCFFB = Utils.JGEPCPFJANP(Location.Tavern);
		for (int i = 1; i < HAEIAGKNEPC.Count; i++)
		{
			LGIGGPIMCFL[i] = HAEIAGKNEPC[i].x;
			FNBEEDCNFKL[i] = HAEIAGKNEPC[i].y;
			DBPCMLBIOBB[i] = (short)WorldGrid.EIHIPOEOBCO(Vector2.op_Implicit(HAEIAGKNEPC[i]), ALIKBMPCFFB);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = LGIGGPIMCFL;
		array[0] = FNBEEDCNFKL;
		array[4] = DBPCMLBIOBB;
		OnlineManager.SendRPC(photonView, " at ", (RpcTarget)0, array);
	}

	private void NNNFJFGJJBG(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, short[] DBPCMLBIOBB)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
		{
			ACADACLGHLG(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i]), DBPCMLBIOBB[i]);
		}
	}
}
