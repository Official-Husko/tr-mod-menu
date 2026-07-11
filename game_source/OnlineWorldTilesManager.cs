using System;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnlineWorldTilesManager : MonoBehaviourPunCallbacks
{
	[Serializable]
	public struct GroundTypeMsg : IOnlineSerializable
	{
		public Vector2Online position;

		public byte groundType;

		public int location;

		public GroundTypeMsg(Vector2 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Location BAIMHDBJPDK)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			position = Utils.LGLEABBIGAH(IMOBLFMHKOD);
			groundType = (byte)GBKMNAPGIOM;
			location = (int)BAIMHDBJPDK;
		}
	}

	private const int LDMKIGKAGEO = 998;

	public static OnlineWorldTilesManager instance;

	[PunRPC]
	private void ReceiveGroundTypeList(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte EBJEOFOJMLN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (LGIGGPIMCFL.Length != 0)
		{
			Location bAIMHDBJPDK = Utils.HJPCBBGHPDA(new Vector2(LGIGGPIMCFL[0], FNBEEDCNFKL[0]));
			for (int i = 0; i < LGIGGPIMCFL.Length; i++)
			{
				WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), (GroundType)EBJEOFOJMLN, bAIMHDBJPDK);
			}
		}
	}

	public void SendHasSnowList(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHasSnowList", (RpcTarget)1, array, array2);
		}
	}

	private void IOOOBKEOLBO(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		WateringCanInstance.KHHLNANJPCO(NCPGNLOJGAF, JLMAILGJNCE);
	}

	public void SendGroundTypeList(List<Vector2> HAEIAGKNEPC, GroundType GBKMNAPGIOM)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGroundTypeList", (RpcTarget)1, array, array2, (byte)GBKMNAPGIOM);
		}
	}

	private void HPIOPIKDHGI(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (LGIGGPIMCFL.Length != 0)
		{
			for (int i = 0; i < LGIGGPIMCFL.Length; i++)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
	}

	public void BPPOIINPOJG(List<Vector2> DHLNCGGFDLK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		float[] array = new float[DHLNCGGFDLK.Count];
		float[] array2 = new float[DHLNCGGFDLK.Count];
		for (int i = 0; i < DHLNCGGFDLK.Count; i++)
		{
			array[i] = DHLNCGGFDLK[i].x;
			array2[i] = DHLNCGGFDLK[i].y;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array3 = new object[8];
		array3[1] = array;
		array3[1] = array2;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array3);
	}

	public void LAPLMCHBKHB(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[1];
			array3[1] = array;
			array3[1] = array2;
			OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array3);
		}
	}

	public void LNDOCFIFMOL(Vector2 IMOBLFMHKOD, bool DNMKMKDAENO)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[3];
			array[1] = IMOBLFMHKOD.x;
			array[0] = IMOBLFMHKOD.y;
			array[2] = DNMKMKDAENO;
			OnlineManager.SendRPC(photonView, "Items/item_description_610", (RpcTarget)0, array);
		}
	}

	private void AEFFEKDKNMO(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		WateringCanInstance.KNIOFCOLINA(NCPGNLOJGAF, JLMAILGJNCE);
	}

	[PunRPC]
	private void ReceiveHasSnowList(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (LGIGGPIMCFL.Length != 0)
		{
			for (int i = 0; i < LGIGGPIMCFL.Length; i++)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), DNMKMKDAENO: true);
			}
		}
	}

	public void BEBIFIHMAOE(Vector2 IMOBLFMHKOD, bool DNMKMKDAENO)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = IMOBLFMHKOD.x;
			array[1] = IMOBLFMHKOD.y;
			array[6] = DNMKMKDAENO;
			OnlineManager.SendRPC(photonView, "Error_OccupiedRoom", (RpcTarget)1, array);
		}
	}

	public void CHAABMFDIOP(Vector2 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Location BAIMHDBJPDK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			byte[] array = OnlineSerializer.EKNOFIJNBAP(new GroundTypeMsg(IMOBLFMHKOD, GBKMNAPGIOM, BAIMHDBJPDK));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[0];
			array2[1] = array;
			OnlineManager.SendRPC(photonView, "Items/item_description_661", (RpcTarget)0, array2);
		}
	}

	public void BCGIFCMOBBA(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i += 0)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[5];
			array3[1] = array;
			array3[0] = array2;
			OnlineManager.SendRPC(photonView, "LE_10", (RpcTarget)1, array3);
		}
	}

	public void JJDIALDJDFH(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i++)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[3];
			array3[1] = array;
			array3[0] = array2;
			OnlineManager.SendRPC(photonView, "mForMins", (RpcTarget)1, array3);
		}
	}

	public void SendWateringCanAction(List<Vector2> DHLNCGGFDLK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		float[] array = new float[DHLNCGGFDLK.Count];
		float[] array2 = new float[DHLNCGGFDLK.Count];
		for (int i = 0; i < DHLNCGGFDLK.Count; i++)
		{
			array[i] = DHLNCGGFDLK[i].x;
			array2[i] = DHLNCGGFDLK[i].y;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveWateringCanAction", (RpcTarget)1, array, array2);
	}

	[PunRPC]
	private void ReceiveWateringCanAction(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		WateringCanInstance.KAIFAHEGAFM(NCPGNLOJGAF, JLMAILGJNCE);
	}

	public void LHHOKPONPHP(Vector2 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Location BAIMHDBJPDK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			byte[] array = OnlineSerializer.Serialize(new GroundTypeMsg(IMOBLFMHKOD, GBKMNAPGIOM, BAIMHDBJPDK));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[0];
			array2[0] = array;
			OnlineManager.SendRPC(photonView, "itemBellPepper", (RpcTarget)0, array2);
		}
	}

	private void GGFJBDJPJNH(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL, byte EBJEOFOJMLN)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (LGIGGPIMCFL.Length != 0)
		{
			Location bAIMHDBJPDK = Utils.HJPCBBGHPDA(new Vector2(LGIGGPIMCFL[0], FNBEEDCNFKL[1]));
			for (int i = 0; i < LGIGGPIMCFL.Length; i++)
			{
				WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), (GroundType)EBJEOFOJMLN, bAIMHDBJPDK, Season.Spring, CDPAMNIPPEC: true);
			}
		}
	}

	private void PPLOEJBJDKB(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (LGIGGPIMCFL.Length != 0)
		{
			for (int i = 0; i < LGIGGPIMCFL.Length; i++)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), DNMKMKDAENO: true, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
	}

	private void BNIKICAEIND()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -115)
		{
			Debug.LogException(new Exception(string.Format("Player2", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 178)), (Object)(object)((Component)this).gameObject);
		}
	}

	[PunRPC]
	private void ReceiveHasSnow(float BDKCDBALPJH, float ACMOGJCLELA, bool DNMKMKDAENO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(BDKCDBALPJH, ACMOGJCLELA)), DNMKMKDAENO);
	}

	public void COFIEGHKFAG(List<Vector2> HAEIAGKNEPC, GroundType GBKMNAPGIOM)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i++)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[2];
			array3[0] = array;
			array3[0] = array2;
			array3[0] = (byte)GBKMNAPGIOM;
			OnlineManager.SendRPC(photonView, "Eat", (RpcTarget)1, array3);
		}
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 998)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {998} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
	}

	private void LMNIFLEJBBM(float[] NCPGNLOJGAF, float[] JLMAILGJNCE)
	{
		WateringCanInstance.KAIFAHEGAFM(NCPGNLOJGAF, JLMAILGJNCE);
	}

	private void PLDFNKMNPFB(float[] LGIGGPIMCFL, float[] FNBEEDCNFKL)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (LGIGGPIMCFL.Length != 0)
		{
			for (int i = 0; i < LGIGGPIMCFL.Length; i += 0)
			{
				WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(LGIGGPIMCFL[i], FNBEEDCNFKL[i])), DNMKMKDAENO: false, BBHMAKKPFKB: false, CDPAMNIPPEC: true);
			}
		}
	}

	public void PDLHDKFFAJL(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_14", (RpcTarget)1, array, array2, null, null, null);
		}
	}

	private void MAKIPKJGENF(float BDKCDBALPJH, float ACMOGJCLELA, bool DNMKMKDAENO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(BDKCDBALPJH, ACMOGJCLELA)), DNMKMKDAENO, BBHMAKKPFKB: true, CDPAMNIPPEC: true);
	}

	private void MFMMHDPGCBO()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -170)
		{
			Debug.LogException(new Exception(string.Format("Toy", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -155)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void FFIEFHMMFPH(float BDKCDBALPJH, float ACMOGJCLELA, bool DNMKMKDAENO)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.AAFPODGPJMP(Vector2.op_Implicit(new Vector2(BDKCDBALPJH, ACMOGJCLELA)), DNMKMKDAENO);
	}

	public void SendHasSnow(Vector2 IMOBLFMHKOD, bool DNMKMKDAENO)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHasSnow", (RpcTarget)1, IMOBLFMHKOD.x, IMOBLFMHKOD.y, DNMKMKDAENO);
		}
	}

	private void EECADNBJGNI(byte[] BBJDPIJPLPA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		GroundTypeMsg groundTypeMsg = OnlineSerializer.Deserialize<GroundTypeMsg>(BBJDPIJPLPA);
		WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(groundTypeMsg.position.BBGCPCAKDOM()), (GroundType)groundTypeMsg.groundType, (Location)groundTypeMsg.location, Season.Spring, CDPAMNIPPEC: true);
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public void SendGroundType(Vector2 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Location BAIMHDBJPDK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			byte[] array = OnlineSerializer.Serialize(new GroundTypeMsg(IMOBLFMHKOD, GBKMNAPGIOM, BAIMHDBJPDK));
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGroundType", (RpcTarget)1, array);
		}
	}

	private void DHFEFCBPEJB(byte[] BBJDPIJPLPA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		GroundTypeMsg groundTypeMsg = OnlineSerializer.Deserialize<GroundTypeMsg>(BBJDPIJPLPA);
		WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(groundTypeMsg.position.ALPFNOPMEAD()), (GroundType)groundTypeMsg.groundType, (Location)groundTypeMsg.location, Season.Spring, CDPAMNIPPEC: true);
	}

	public void GPJHHDGGMLK(List<Vector2> HAEIAGKNEPC)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 0; i < HAEIAGKNEPC.Count; i++)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "PopUpGen error: ", (RpcTarget)0, array, array2, null);
		}
	}

	[PunRPC]
	private void ReceiveGroundType(byte[] BBJDPIJPLPA)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		GroundTypeMsg groundTypeMsg = OnlineSerializer.Deserialize<GroundTypeMsg>(BBJDPIJPLPA);
		WorldGrid.MMOHADHAAGD(Vector2.op_Implicit(groundTypeMsg.position.DMBNLBPEELL()), (GroundType)groundTypeMsg.groundType, (Location)groundTypeMsg.location);
	}

	public void CBAKGPEPAKJ(Vector2 IMOBLFMHKOD, GroundType GBKMNAPGIOM, Location BAIMHDBJPDK)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			byte[] array = OnlineSerializer.Serialize(new GroundTypeMsg(IMOBLFMHKOD, GBKMNAPGIOM, BAIMHDBJPDK));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[1];
			array2[1] = array;
			OnlineManager.SendRPC(photonView, "Game Over! ", (RpcTarget)0, array2);
		}
	}

	public void LKCJPHIFMLO(List<Vector2> DHLNCGGFDLK)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		float[] array = new float[DHLNCGGFDLK.Count];
		float[] array2 = new float[DHLNCGGFDLK.Count];
		for (int i = 1; i < DHLNCGGFDLK.Count; i++)
		{
			array[i] = DHLNCGGFDLK[i].x;
			array2[i] = DHLNCGGFDLK[i].y;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array3 = new object[5];
		array3[1] = array;
		array3[0] = array2;
		OnlineManager.SendRPC(photonView, "Loading tavern floor tiles (ONLINE) ", (RpcTarget)1, array3);
	}

	private void Awake()
	{
		instance = this;
	}

	private void HCEDMLJNOBL()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 85)
		{
			Debug.LogException(new Exception(string.Format("Wilson/Bark/Bark_Bye", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 33)), (Object)(object)((Component)this).gameObject);
		}
	}

	public void NOEJGMGPFHK(List<Vector2> HAEIAGKNEPC, GroundType GBKMNAPGIOM)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (HAEIAGKNEPC.Count != 0)
		{
			float[] array = new float[HAEIAGKNEPC.Count];
			float[] array2 = new float[HAEIAGKNEPC.Count];
			for (int i = 1; i < HAEIAGKNEPC.Count; i += 0)
			{
				array[i] = HAEIAGKNEPC[i].x;
				array2[i] = HAEIAGKNEPC[i].y;
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[6];
			array3[0] = array;
			array3[1] = array2;
			array3[1] = (byte)GBKMNAPGIOM;
			OnlineManager.SendRPC(photonView, "popUpBuilding9", (RpcTarget)1, array3);
		}
	}
}
