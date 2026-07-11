using Photon.Pun;
using UnityEngine;

public class OnlineReputationManager : MonoBehaviourPunCallbacks
{
	private const int LDMKIGKAGEO = 998;

	public static OnlineReputationManager instance;

	public int milestoneMaster;

	public void LPJKNDHPGNN(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (short)HIHGMPIKGIF;
		array[0] = IMOBLFMHKOD.x;
		array[3] = IMOBLFMHKOD.y;
		array[7] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "UI2", (RpcTarget)0, array);
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	public void SendMilestoneMaster(int ODAOIJCOFMF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveMilestoneMaster", (RpcTarget)1, ODAOIJCOFMF);
	}

	public void PMPMBBJOCOO(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (short)HIHGMPIKGIF;
		array[1] = IMOBLFMHKOD.x;
		array[6] = IMOBLFMHKOD.y;
		array[7] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "Key1", (RpcTarget)0, array);
	}

	public void ONIKBFICBAE(int ODAOIJCOFMF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = ODAOIJCOFMF;
		OnlineManager.SendRPC(photonView, "Unique id ", (RpcTarget)1, array);
	}

	public void OELLGHPDNHO(int ODAOIJCOFMF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = ODAOIJCOFMF;
		OnlineManager.SendRPC(photonView, "NormalRight", (RpcTarget)1, array);
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	private void LDGBOEGNKEF(short HIHGMPIKGIF, float BDKCDBALPJH, float ACMOGJCLELA, float NGDAJGCPJEC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.IFDFPIJKPJI(HIHGMPIKGIF, new Vector2(BDKCDBALPJH, ACMOGJCLELA), null, NGDAJGCPJEC, CDPAMNIPPEC: false);
	}

	private void ALKLBOEBOKB(int ODAOIJCOFMF)
	{
		milestoneMaster = ODAOIJCOFMF;
	}

	public void EELDCIOLCOG(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (short)HIHGMPIKGIF;
		array[0] = IMOBLFMHKOD.x;
		array[4] = IMOBLFMHKOD.y;
		array[4] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "Screenshot not found", (RpcTarget)1, array);
	}

	public void OBPFFBNJGGB(int ODAOIJCOFMF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = ODAOIJCOFMF;
		OnlineManager.SendRPC(photonView, "No se encontró una entrada con ID {0} en la conversación '{1}'.", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveMilestoneMaster(int ODAOIJCOFMF)
	{
		milestoneMaster = ODAOIJCOFMF;
	}

	public void HBDDEPDBCGD(int ODAOIJCOFMF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "\n\n\nMine Level Info:\n", (RpcTarget)0, ODAOIJCOFMF);
	}

	private void GFCPDEAOGHI(short HIHGMPIKGIF, float BDKCDBALPJH, float ACMOGJCLELA, float NGDAJGCPJEC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.FMHJLJPOIGN(HIHGMPIKGIF, new Vector2(BDKCDBALPJH, ACMOGJCLELA), null, NGDAJGCPJEC, CDPAMNIPPEC: false);
	}

	public void CIGODJOBBPF(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HIHGMPIKGIF;
		array[1] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		array[4] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "Sit", (RpcTarget)1, array);
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	public void NNOPACFAHGO(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = (short)HIHGMPIKGIF;
		array[1] = IMOBLFMHKOD.x;
		array[3] = IMOBLFMHKOD.y;
		array[6] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "popUpBuilding9", (RpcTarget)1, array);
	}

	private void FLODOMGFADE(int ODAOIJCOFMF)
	{
		milestoneMaster = ODAOIJCOFMF;
	}

	public void EMPINBHPMGK(int ODAOIJCOFMF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = ODAOIJCOFMF;
		OnlineManager.SendRPC(photonView, "Error_OccupiedRoom", (RpcTarget)0, array);
	}

	private void Awake()
	{
		instance = this;
	}

	public void CIMAFNKDJBJ(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (short)HIHGMPIKGIF;
		array[0] = IMOBLFMHKOD.x;
		array[0] = IMOBLFMHKOD.y;
		array[2] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, " PlayerNum: ", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveAddReputationPoints(short HIHGMPIKGIF, float BDKCDBALPJH, float ACMOGJCLELA, float NGDAJGCPJEC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.AddAndShowReputationGain(HIHGMPIKGIF, new Vector2(BDKCDBALPJH, ACMOGJCLELA), null, NGDAJGCPJEC, CDPAMNIPPEC: false);
	}

	public void LNKFMPIBOMJ(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (short)HIHGMPIKGIF;
		array[0] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		array[4] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "Destroying tree at same position: ", (RpcTarget)1, array);
	}

	public void IGFEDKBPPIH(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = (short)HIHGMPIKGIF;
		array[1] = IMOBLFMHKOD.x;
		array[0] = IMOBLFMHKOD.y;
		array[0] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, ". Time since startup: ", (RpcTarget)0, array);
	}

	private void JKDLJCEHOEJ(int ODAOIJCOFMF)
	{
		milestoneMaster = ODAOIJCOFMF;
	}

	private void KLDOIPOABDL(int ODAOIJCOFMF)
	{
		milestoneMaster = ODAOIJCOFMF;
	}

	public void NJCFDGIPLPM(int ODAOIJCOFMF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "BombShopDisable", (RpcTarget)0, ODAOIJCOFMF);
	}

	private void MGNPMGNGLMH(int ODAOIJCOFMF)
	{
		milestoneMaster = ODAOIJCOFMF;
	}

	private void ECEMPHCDBFF(short HIHGMPIKGIF, float BDKCDBALPJH, float ACMOGJCLELA, float NGDAJGCPJEC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.FMHJLJPOIGN(HIHGMPIKGIF, new Vector2(BDKCDBALPJH, ACMOGJCLELA), null, NGDAJGCPJEC, CDPAMNIPPEC: false);
	}

	public void OBDCNOOCOML(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (short)HIHGMPIKGIF;
		array[0] = IMOBLFMHKOD.x;
		array[2] = IMOBLFMHKOD.y;
		array[0] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "Invalid playerNum", (RpcTarget)1, array);
	}

	public void IHPPFGBKEGA(int ODAOIJCOFMF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemLog", (RpcTarget)1, ODAOIJCOFMF);
	}

	private void KAABOGKENOD(short HIHGMPIKGIF, float BDKCDBALPJH, float ACMOGJCLELA, float NGDAJGCPJEC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.AddAndShowReputationGain(HIHGMPIKGIF, new Vector2(BDKCDBALPJH, ACMOGJCLELA), null, NGDAJGCPJEC, CDPAMNIPPEC: false);
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	public void SendAddReputationPoints(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddReputationPoints", (RpcTarget)1, (short)HIHGMPIKGIF, IMOBLFMHKOD.x, IMOBLFMHKOD.y, NGDAJGCPJEC);
	}

	private void MIGAOILLOBK(short HIHGMPIKGIF, float BDKCDBALPJH, float ACMOGJCLELA, float NGDAJGCPJEC)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		TavernReputation.AddAndShowReputationGain(HIHGMPIKGIF, new Vector2(BDKCDBALPJH, ACMOGJCLELA), null, NGDAJGCPJEC);
	}

	public void OHCHHJIHLOD(int ODAOIJCOFMF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = ODAOIJCOFMF;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	public void PPIHFGALACP(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)HIHGMPIKGIF;
		array[1] = IMOBLFMHKOD.x;
		array[2] = IMOBLFMHKOD.y;
		array[5] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "openShop", (RpcTarget)1, array);
	}

	public void AEIBFAIILJD(int HIHGMPIKGIF, Vector2 IMOBLFMHKOD, float NGDAJGCPJEC)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)HIHGMPIKGIF;
		array[0] = IMOBLFMHKOD.x;
		array[4] = IMOBLFMHKOD.y;
		array[7] = NGDAJGCPJEC;
		OnlineManager.SendRPC(photonView, "UINextPage", (RpcTarget)1, array);
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}
}
