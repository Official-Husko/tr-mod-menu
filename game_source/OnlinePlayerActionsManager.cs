using System;
using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnlinePlayerActionsManager : MonoBehaviourPunCallbacks
{
	private const int LDMKIGKAGEO = 998;

	public static OnlinePlayerActionsManager instance;

	public Spade spade;

	public Hoe hoe;

	private void OINAODNLPEE(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, byte CIPOHPFBEHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SpadeInstance.MBCPIHHCPIO(BJDFONAKNJP, IMOBLFMHKOD, (GroundType)CIPOHPFBEHO);
	}

	public void OMPNDAOGIPO(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			AFALJLLJHIO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[2] = IMOBLFMHKOD.y;
		array[6] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, "\n", (RpcTarget)6, array);
	}

	private void AIOJCLOGOJD(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		AFALJLLJHIO((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	private void JFGLHHLFJIL(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, byte CIPOHPFBEHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SpadeInstance.KOKPMJCDEEO(BJDFONAKNJP, IMOBLFMHKOD, (GroundType)CIPOHPFBEHO);
	}

	private void JNNEFOEGIBG(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		HoeInstance.BNODBAKKIBH(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public void StartSpadeAction(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			PFLAADPFBHO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSpadeActionMaster", (RpcTarget)2, (byte)BJDFONAKNJP, IMOBLFMHKOD.x, IMOBLFMHKOD.y, (byte)DGKJGLMBONI);
	}

	private void PCIOPLBPGJO(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		DOIGMPMCPDP(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void IDPHKHGHJGN()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -164)
		{
			Debug.LogException(new Exception(string.Format("Players win!", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 149)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	private void AOPJLOMDCEN(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		JNNEFOEGIBG(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void MJLJPINLFJO(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		JFGLHHLFJIL((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	private void ICGBCNIFMPI(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		BKLHOOHHMMM(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public void HIINMIKACMH(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			IJBHNKPOPIE(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = IMOBLFMHKOD.x;
		array[0] = IMOBLFMHKOD.y;
		array[1] = (byte)FCGBJEIIMBC;
		array[8] = (byte)EEDMOGGJLHO;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text", (RpcTarget)2, array);
	}

	private void PFLAADPFBHO(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, byte CIPOHPFBEHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SpadeInstance.BNODBAKKIBH(BJDFONAKNJP, IMOBLFMHKOD, (GroundType)CIPOHPFBEHO);
	}

	public void LCINOPHPNMF(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			AFALJLLJHIO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[0] = IMOBLFMHKOD.y;
		array[7] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, "/", (RpcTarget)4, array);
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 998)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {998} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
	}

	public void HJILEPEKLCM(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			AFALJLLJHIO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (byte)BJDFONAKNJP;
		array[1] = IMOBLFMHKOD.x;
		array[7] = IMOBLFMHKOD.y;
		array[2] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, "No se ha vinculado el sprite renderer en ", (RpcTarget)2, array);
	}

	private void GHPFCKGMLDA()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -84)
		{
			Debug.LogException(new Exception(string.Format("ReceiveOfferingPuzzleSolved", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -45)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void NJCPCPNGLMP(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		OINAODNLPEE((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}

	private void NHAPLJHGKJD(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		KNEGKGPBEGF(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void NELBHAMPBPL()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -100)
		{
			Debug.LogException(new Exception(string.Format("Open", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -27)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void MIKNFPCDLML()
	{
		instance = this;
	}

	private void NFABFPFLNEE()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -41)
		{
			Debug.LogException(new Exception(string.Format(" seconds.", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -190)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void EPBELDBAEEL(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, byte CIPOHPFBEHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SpadeInstance.NOPMIMMBGNL(BJDFONAKNJP, IMOBLFMHKOD, (GroundType)CIPOHPFBEHO);
	}

	private void IJJGKFCPCCP(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		AFALJLLJHIO((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	[PunRPC]
	private void ReceiveHoeActionMaster(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		BKLHOOHHMMM(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public void DKKGNCKEDCD(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			IJBHNKPOPIE(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		array[5] = (byte)FCGBJEIIMBC;
		array[0] = (byte)EEDMOGGJLHO;
		OnlineManager.SendRPC(photonView, "ReceiveKick", (RpcTarget)6, array);
	}

	public void JLEEMFEIEBH(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			AFALJLLJHIO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[5] = IMOBLFMHKOD.y;
		array[2] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, "ReceiveMinusMoney", (RpcTarget)8, array);
	}

	private void NMLLFPKKHLN(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		BKLHOOHHMMM(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public void CGCKAINEBAK(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			DOIGMPMCPDP(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		array[6] = (byte)FCGBJEIIMBC;
		array[6] = (byte)EEDMOGGJLHO;
		OnlineManager.SendRPC(photonView, "Select", (RpcTarget)6, array);
	}

	private void AFALJLLJHIO(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, byte CIPOHPFBEHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SpadeInstance.BLHICNGCDLD(BJDFONAKNJP, IMOBLFMHKOD, (GroundType)CIPOHPFBEHO);
	}

	private void HBMDEHPHAPF()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -53)
		{
			Debug.LogException(new Exception(string.Format("MineFloor", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 22)), (Object)(object)((Component)this).gameObject);
		}
	}

	[PunRPC]
	private void ReceiveSpadeActionMaster(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		PFLAADPFBHO((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	private void EHDFLMOFBLI(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		JFFLPPMFIEN((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	private void JFFLPPMFIEN(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, byte CIPOHPFBEHO)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SpadeInstance.NOPMIMMBGNL(BJDFONAKNJP, IMOBLFMHKOD, (GroundType)CIPOHPFBEHO);
	}

	private void MCMKNBIBDFF()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 40)
		{
			Debug.LogException(new Exception(string.Format("Next Reward", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -40)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void FJANNFKCJJG(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		AFALJLLJHIO((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	public void NICFDAGKDBO(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			AFALJLLJHIO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		array[2] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, "Items/item_name_1090", (RpcTarget)0, array);
	}

	private void BKLHOOHHMMM(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		HoeInstance.BNODBAKKIBH(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	private void IJBHNKPOPIE(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		HoeInstance.LNPGAIAFINC(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public void FELIPBBAFKD(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			EPBELDBAEEL(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[8] = IMOBLFMHKOD.y;
		array[5] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, " get price serve customer ", (RpcTarget)8, array);
	}

	public void LGECGMNLJPP(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			IJBHNKPOPIE(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		array[7] = (byte)FCGBJEIIMBC;
		array[4] = (byte)EEDMOGGJLHO;
		OnlineManager.SendRPC(photonView, "Items/item_description_1080", (RpcTarget)0, array);
	}

	private void DOIGMPMCPDP(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		HoeInstance.BNODBAKKIBH(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void KNEGKGPBEGF(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		HoeInstance.LNPGAIAFINC(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void JHBBABPAJJC()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 14)
		{
			Debug.LogException(new Exception(string.Format("Fishing", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 12)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void FOKAGBFIDHA(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		EPBELDBAEEL((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	public void CGFNKFDPLPD(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			BKLHOOHHMMM(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = IMOBLFMHKOD.x;
		array[0] = IMOBLFMHKOD.y;
		array[3] = (byte)FCGBJEIIMBC;
		array[4] = (byte)EEDMOGGJLHO;
		OnlineManager.SendRPC(photonView, "Welcome to {0}!", (RpcTarget)6, array);
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	private void POIOGAMBAKN(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		HoeInstance.BNODBAKKIBH(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
	}

	public void HGAMDNGBCCN(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			PFLAADPFBHO(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[8] = IMOBLFMHKOD.y;
		array[7] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	private void DPDEBJBAODJ(float AIANGPHHEHI, float JAMLBMCDGOL, byte FCGBJEIIMBC, byte EEDMOGGJLHO)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		BKLHOOHHMMM(new Vector2(AIANGPHHEHI, JAMLBMCDGOL), (Direction)FCGBJEIIMBC, EEDMOGGJLHO);
	}

	private void CAJGPANKEBL(byte BJDFONAKNJP, float AIANGPHHEHI, float JAMLBMCDGOL, byte CIPOHPFBEHO)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		JFGLHHLFJIL((SpadeInstance.SpadeActionType)BJDFONAKNJP, new Vector2(AIANGPHHEHI, JAMLBMCDGOL), CIPOHPFBEHO);
	}

	public void MJGJCFFGOAF(SpadeInstance.SpadeActionType BJDFONAKNJP, Vector2 IMOBLFMHKOD, GroundType DGKJGLMBONI)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.JPPBEIJDCLJ())
		{
			JFGLHHLFJIL(BJDFONAKNJP, IMOBLFMHKOD, (byte)DGKJGLMBONI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)BJDFONAKNJP;
		array[0] = IMOBLFMHKOD.x;
		array[8] = IMOBLFMHKOD.y;
		array[0] = (byte)DGKJGLMBONI;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)4, array);
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void DIMAPDNCBAN()
	{
		instance = this;
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	public void StartHoeAction(Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC, int EEDMOGGJLHO)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.IsMasterClient())
		{
			BKLHOOHHMMM(IMOBLFMHKOD, FCGBJEIIMBC, EEDMOGGJLHO);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHoeActionMaster", (RpcTarget)2, IMOBLFMHKOD.x, IMOBLFMHKOD.y, (byte)FCGBJEIIMBC, (byte)EEDMOGGJLHO);
	}
}
