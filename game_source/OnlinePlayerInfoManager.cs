using Photon.Pun;
using UnityEngine;

public class OnlinePlayerInfoManager : MonoBehaviourPunCallbacks
{
	public static OnlinePlayerInfoManager instance;

	private void MPPBFPLGGJN(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC).IPGBILAIAPG(CDPAMNIPPEC: false);
	}

	public static void IOFAALAOLAF(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[1] = (short)HAJFJGCNKFF.JDJGFAACPFC(DAINLFIMLIH: false);
			array[1] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, " : ", (RpcTarget)0, array);
		}
	}

	public static void LOHLFJOBKOD(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[4];
			array[0] = (short)HAJFJGCNKFF.JGHNDJBCFAJ(DAINLFIMLIH: false);
			array[0] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, "cameraZoom", (RpcTarget)0, array);
		}
	}

	private void KGIEMIGAGPN(int JEPEICNIJNA)
	{
		Money.MinusPrice(Price.DHMGJGHCCJD(JEPEICNIJNA), BGKCHMNJBLJ: false);
	}

	private void HKJAGMGBNEO(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.BCINHMELFNJ(Price.HNDGIKFAKNC(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA), CDPAMNIPPEC: false);
	}

	public static void LHMPDEPLOKI(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			OnlineManager.SendRPC(photonView, "LE_11", (RpcTarget)1, array);
		}
	}

	public static void IMBOEMODLEO(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "talentBrown", (RpcTarget)0, ENDNDAOPKHD.JHKPNCOMAHI());
		}
	}

	private void AGPONCCIFHC()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void SendMinusMoney(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveMinusMoney", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
		}
	}

	public static void FABIJMJHNEH(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[4];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			array[0] = IMOBLFMHKOD.x;
			array[7] = IMOBLFMHKOD.y;
			OnlineManager.SendRPC(photonView, "Starting Pirates Intro Event", (RpcTarget)1, array);
		}
	}

	private void JBBHDOMALDB()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	private void DGOGKLMHJEG()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void GDIMPODNDMB(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.SpawnMoneyText(Price.HNDGIKFAKNC(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA), CDPAMNIPPEC: false);
	}

	public void HIHHHONHPCO(int HLIFMPEJHKC)
	{
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = HLIFMPEJHKC;
		OnlineManager.SendRPC(photonView, "Received an RPC with parameters for an invalid animation", (RpcTarget)1, array);
	}

	public static void HPEPDEDJCNN(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[6];
			array[1] = (short)HAJFJGCNKFF.JGHNDJBCFAJ();
			array[1] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
		}
	}

	private void CNLPJFGIBBK(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.FOHEOELJMPF(ItemDatabaseAccessor.AFOACBIHNCL(FFNOEIENNFM) as Fish, HHNMEJJCBOA, CDPAMNIPPEC: false);
	}

	public static void BNKAFHBBFIM(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[8];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			array[0] = IMOBLFMHKOD.x;
			array[3] = IMOBLFMHKOD.y;
			OnlineManager.SendRPC(photonView, "Fortitude/MainEvent 3", (RpcTarget)0, array);
		}
	}

	private void NCPNBBCNBIM()
	{
		instance = this;
	}

	public static void NJHLKCAKKEL(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = ENDNDAOPKHD.BNCMDNFMECD();
			OnlineManager.SendRPC(photonView, "Starting New Game Coroutine", (RpcTarget)1, array);
		}
	}

	public static void LFMIECBINNH(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[7];
			array[0] = (short)HAJFJGCNKFF.JPNFKDMFKMC(DAINLFIMLIH: false);
			array[0] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
		}
	}

	public static void MMJHJFPHEMD(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "LicenciaDeApertura/TheloniousDialogue 01", (RpcTarget)0, ENDNDAOPKHD.BNCMDNFMECD(), IMOBLFMHKOD.x, null, null, IMOBLFMHKOD.y);
		}
	}

	public static void IHNBEFEGGHO(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			OnlineManager.SendRPC(photonView, "castle", (RpcTarget)0, array);
		}
	}

	public void AMPDEHKLFBE(int HLIFMPEJHKC)
	{
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = HLIFMPEJHKC;
		OnlineManager.SendRPC(photonView, "Ingredient", (RpcTarget)0, array);
	}

	public static void IPAAOEHDOII(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = ENDNDAOPKHD.BNCMDNFMECD();
			OnlineManager.SendRPC(photonView, " goalPos: ", (RpcTarget)0, array);
		}
	}

	public void ALACOMGFDGA(int HLIFMPEJHKC)
	{
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = HLIFMPEJHKC;
		OnlineManager.SendRPC(photonView, "Changing zoom ", (RpcTarget)0, array);
	}

	private void MIKNFPCDLML()
	{
		instance = this;
	}

	public static void KGIEJHDDEGE(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = ENDNDAOPKHD.OOIPLIEJILO();
			OnlineManager.SendRPC(photonView, ":<color=#3a0603> +", (RpcTarget)0, array);
		}
	}

	private void CIHGDBJCAGG(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).KGCOBHPFJKD(CDPAMNIPPEC: false);
	}

	private void ILIEGLLOEHF(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.AddToRecordList(ItemDatabaseAccessor.GOKIDLOELKB(FFNOEIENNFM, GGBBJNBBLMF: true) as Fish, HHNMEJJCBOA);
	}

	private void CMAJDDOKECB(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.PMEKONKEDBD(Price.HNDGIKFAKNC(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA));
	}

	public static void OAFFGLEIIME(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = ENDNDAOPKHD.BNCMDNFMECD();
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/EnterTavernNeutral/Entry/1/Dialogue Text", (RpcTarget)1, array);
		}
	}

	private void KIBIKEGANJC(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.COEFFIHKMJG(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).KGCOBHPFJKD(CDPAMNIPPEC: true);
	}

	private void NJFDKCMBMDH()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void HLNONKOPPJH(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.JOFHBLKMFEG(ItemDatabaseAccessor.GOKIDLOELKB(FFNOEIENNFM) as Fish, HHNMEJJCBOA, CDPAMNIPPEC: false);
	}

	private void PGABAEGKPIG()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void GMOAGAPBLMM(int JEPEICNIJNA)
	{
		Money.HGNGMEKAABG(Price.IFMFKEMHHLM(JEPEICNIJNA), OPOHOHFHFFI: true);
	}

	public static void GEEOEDLJOCN(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = ENDNDAOPKHD.BNCMDNFMECD();
			array[1] = IMOBLFMHKOD.x;
			array[6] = IMOBLFMHKOD.y;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
		}
	}

	private void DGBJJNAADCI()
	{
		instance = this;
	}

	public void OBDEAEJOEIA(int HLIFMPEJHKC)
	{
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[0];
		array[0] = HLIFMPEJHKC;
		OnlineManager.SendRPC(photonView, " (ONLINE) [master client] length: ", (RpcTarget)1, array);
	}

	private void Awake()
	{
		instance = this;
	}

	public static void PPBLJKJEAAN(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[3];
			array[0] = ENDNDAOPKHD.BNCMDNFMECD();
			array[1] = IMOBLFMHKOD.x;
			array[6] = IMOBLFMHKOD.y;
			OnlineManager.SendRPC(photonView, "LE_10", (RpcTarget)0, array);
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void HLCAKACHOOE()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void SendAddMoney(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveAddMoney", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
		}
	}

	private void EHKLKNEDAIM(int JEPEICNIJNA)
	{
		Money.GACOLOLNDHB(Price.LEDHAKFAHCI(JEPEICNIJNA));
	}

	private void AFNFEBEMKMK(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).DIKFNBLGGHJ(CDPAMNIPPEC: false);
	}

	private void JJJDMJCGOCF(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.FOHEOELJMPF(ItemDatabaseAccessor.GetItem(FFNOEIENNFM, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Fish, HHNMEJJCBOA);
	}

	private void LKAPEJFMHHD(int JEPEICNIJNA)
	{
		Money.FGAKGNMLEKL(Price.LEDHAKFAHCI(JEPEICNIJNA), OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
	}

	private void JCNGGPIICIN()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void EFJKBHMJBBI(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.FOHEOELJMPF(ItemDatabaseAccessor.CPMMBEPEJLO(FFNOEIENNFM, GGBBJNBBLMF: false, DAINLFIMLIH: false) as Fish, HHNMEJJCBOA);
	}

	private void NMIIPBPEDJM(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: true);
	}

	private void NHGFDOOFKOC(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.JOFHBLKMFEG(ItemDatabaseAccessor.AFOACBIHNCL(FFNOEIENNFM, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Fish, HHNMEJJCBOA);
	}

	private void FIFJDIIEADN(int JEPEICNIJNA)
	{
		Money.CANMCFOCNPA(Price.DHMGJGHCCJD(JEPEICNIJNA), OPOHOHFHFFI: true);
	}

	public static void OPBBAPDGCGA(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Throw", (RpcTarget)1, (short)HAJFJGCNKFF.JPNFKDMFKMC(), (short)PFBIBFJKHDD, null, null);
		}
	}

	[PunRPC]
	private void ReceiveUnlockHair(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.GetItem(HLIFMPEJHKC).IPGBILAIAPG(CDPAMNIPPEC: false);
	}

	public static void LJJDDIPHEJC(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[8];
			array[1] = (short)HAJFJGCNKFF.ODENMDOJPLC();
			array[1] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, "increase xp", (RpcTarget)1, array);
		}
	}

	public static void MLOBOGJAKNF(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = ENDNDAOPKHD.JHKPNCOMAHI();
			OnlineManager.SendRPC(photonView, " (Client)", (RpcTarget)1, array);
		}
	}

	public static void LJDOAEEBKNG(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = (short)HAJFJGCNKFF.ODENMDOJPLC();
			array[1] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, "Not enough ingredients", (RpcTarget)0, array);
		}
	}

	public static void SendFishInfo(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveFishInfo", (RpcTarget)1, (short)HAJFJGCNKFF.JDJGFAACPFC(), (short)PFBIBFJKHDD);
		}
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	private void DNBGIIGAKMJ()
	{
		instance = this;
	}

	public static void KPAGLPDDCOD(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "]", (RpcTarget)1, ENDNDAOPKHD.BNCMDNFMECD());
		}
	}

	private void EPNJHAKGEMA(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.FGPIDIKEANG(Price.IFMFKEMHHLM(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA));
	}

	public static void MJFMLBGJNFP(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = ENDNDAOPKHD.BNCMDNFMECD();
			OnlineManager.SendRPC(photonView, " seconds.", (RpcTarget)0, array);
		}
	}

	private void FFGABDCEAEA(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.GOKIDLOELKB(HLIFMPEJHKC).AACLOJMCAAN(CDPAMNIPPEC: false);
	}

	public static void PBFODCGHBLB(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "current Theme playing", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
		}
	}

	private void LODIJAPNHAE(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.AddToRecordList(ItemDatabaseAccessor.INJBNHPGCIJ(FFNOEIENNFM) as Fish, HHNMEJJCBOA);
	}

	private void GHOAHGNOFBA(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.COEFFIHKMJG(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).DIKFNBLGGHJ(CDPAMNIPPEC: true);
	}

	private void IMJJELGPPMC(int JEPEICNIJNA)
	{
		Money.GPAGJMHPKAH(Price.OMDBJINNHPC(JEPEICNIJNA));
	}

	private void PDPLPEFOPPG(int JEPEICNIJNA)
	{
		Money.MHIHEOJPFFM(Price.OMDBJINNHPC(JEPEICNIJNA));
	}

	public static void KNJGOHEDAIF(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[4];
			array[0] = ENDNDAOPKHD.OOIPLIEJILO();
			array[0] = IMOBLFMHKOD.x;
			array[5] = IMOBLFMHKOD.y;
			OnlineManager.SendRPC(photonView, "MineState", (RpcTarget)0, array);
		}
	}

	private void FDNAEJDHODK()
	{
		if (Application.isPlaying && (Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void PNGDHFNLPDO(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[2];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			array[0] = IMOBLFMHKOD.x;
			array[2] = IMOBLFMHKOD.y;
			OnlineManager.SendRPC(photonView, "Unlocked at Tavern Reputation {0}", (RpcTarget)1, array);
		}
	}

	private void HIFGNOAPMDF(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.JOFHBLKMFEG(ItemDatabaseAccessor.AFOACBIHNCL(FFNOEIENNFM, GGBBJNBBLMF: true, DAINLFIMLIH: false) as Fish, HHNMEJJCBOA);
	}

	private void DJODIOJCINC(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.AddToRecordList(ItemDatabaseAccessor.INJBNHPGCIJ(FFNOEIENNFM) as Fish, HHNMEJJCBOA, CDPAMNIPPEC: false);
	}

	private void FNGCGAGNDBA(int JEPEICNIJNA)
	{
		Money.MHIHEOJPFFM(Price.IFMFKEMHHLM(JEPEICNIJNA), OPOHOHFHFFI: false, BGKCHMNJBLJ: false);
	}

	[PunRPC]
	private void ReceiveSpawnMoneyText(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.SpawnMoneyText(Price.GHDCKOJGAMM(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA), CDPAMNIPPEC: false);
	}

	public static void APMBPPANMKG(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[6];
			array[0] = (short)HAJFJGCNKFF.IMCJPECAAPC();
			array[0] = (short)PFBIBFJKHDD;
			OnlineManager.SendRPC(photonView, "<color=#BF0000>", (RpcTarget)0, array);
		}
	}

	private void JHOJFFHEHPK(int JEPEICNIJNA)
	{
		Money.MDPJOAAMMPF(Price.LEDHAKFAHCI(JEPEICNIJNA));
	}

	public void PPBIDMFEBDA(int HLIFMPEJHKC)
	{
		PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
		object[] array = new object[1];
		array[1] = HLIFMPEJHKC;
		OnlineManager.SendRPC(photonView, "Collect", (RpcTarget)1, array);
	}

	private void FNAPNDFDBCI(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.EABMGELAAPG(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: true);
	}

	private void MGPAIONNIJM(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.LNDBFPMBBBD(Price.LEDHAKFAHCI(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA));
	}

	public static void NCDFFHLHBFM(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Tutorial/T138/Dialogue2", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
		}
	}

	private void APDODFABCKM(int JEPEICNIJNA)
	{
		Money.AddPrice(Price.DHMGJGHCCJD(JEPEICNIJNA));
	}

	private void ONCJHCOHPCC(int JEPEICNIJNA)
	{
		Money.HKBEBGCKFAB(Price.DHMGJGHCCJD(JEPEICNIJNA), BGKCHMNJBLJ: false);
	}

	public static void LFFEANDMHNO(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[1] = ENDNDAOPKHD.OOIPLIEJILO();
			OnlineManager.SendRPC(photonView, "WaterTrough", (RpcTarget)0, array);
		}
	}

	public void SendUnlockHair(int HLIFMPEJHKC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveUnlockHair", (RpcTarget)1, HLIFMPEJHKC);
	}

	public static void PDLAGMENCOE(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			OnlineManager.SendRPC(photonView, "Items/item_description_642", (RpcTarget)0, array);
		}
	}

	public static void SendSpawnMoneyText(Price ENDNDAOPKHD, Vector3 IMOBLFMHKOD)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "ReceiveSpawnMoneyText", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO(), IMOBLFMHKOD.x, IMOBLFMHKOD.y);
		}
	}

	public static void DGHFKDLMHIG(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "LE_10", (RpcTarget)1, (short)HAJFJGCNKFF.ODENMDOJPLC(), (short)PFBIBFJKHDD, null, null, null);
		}
	}

	public static void NKCLPFOEHIF(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "add item ", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
		}
	}

	private void CBFOFNMFPGA(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.GOKIDLOELKB(HLIFMPEJHKC).IPGBILAIAPG(CDPAMNIPPEC: false);
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void KOKFBLKEDJG(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.CFEDCEPKNKF(Price.LEDHAKFAHCI(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA), CDPAMNIPPEC: false);
	}

	private void NCPPAONHLMM(int JEPEICNIJNA, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Money.CFEDCEPKNKF(Price.LEDHAKFAHCI(JEPEICNIJNA), new Vector3(BDKCDBALPJH, ACMOGJCLELA), CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void ReceiveFishInfo(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.AddToRecordList(ItemDatabaseAccessor.GetItem(FFNOEIENNFM) as Fish, HHNMEJJCBOA, CDPAMNIPPEC: false);
	}

	private void BHPIJBLMIID(int JEPEICNIJNA)
	{
		Money.ENNNOMIKMOK(Price.IFMFKEMHHLM(JEPEICNIJNA));
	}

	private void IBKDCCKACFH(int JEPEICNIJNA)
	{
		Money.DCAFCEAIEID(Price.LEDHAKFAHCI(JEPEICNIJNA), OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
	}

	private void JKBPMGHJKDC(int JEPEICNIJNA)
	{
		Money.AddPrice(Price.DHMGJGHCCJD(JEPEICNIJNA), OPOHOHFHFFI: false, BGKCHMNJBLJ: false);
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void KJAOBEDMMLN(int HLIFMPEJHKC)
	{
		ItemDatabaseAccessor.EABMGELAAPG(HLIFMPEJHKC, GGBBJNBBLMF: true).AFIGLPEBBLN(CDPAMNIPPEC: true);
	}

	[PunRPC]
	private void ReceiveAddMoney(int JEPEICNIJNA)
	{
		Money.AddPrice(Price.GHDCKOJGAMM(JEPEICNIJNA), OPOHOHFHFFI: true, BGKCHMNJBLJ: false);
	}

	public static void LBDJBGPMLBP(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = ENDNDAOPKHD.JHKPNCOMAHI();
			OnlineManager.SendRPC(photonView, "Beta ", (RpcTarget)1, array);
		}
	}

	public static void OCMEHLFAJFF(Price ENDNDAOPKHD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = ENDNDAOPKHD.BNCMDNFMECD();
			OnlineManager.SendRPC(photonView, "\n", (RpcTarget)0, array);
		}
	}

	private void JDHHJKBOJML()
	{
		instance = this;
	}

	private void OBKJMFHMBFP(short FFNOEIENNFM, short HHNMEJJCBOA)
	{
		FishingManager.FOHEOELJMPF(ItemDatabaseAccessor.COEFFIHKMJG(FFNOEIENNFM, GGBBJNBBLMF: true) as Fish, HHNMEJJCBOA, CDPAMNIPPEC: false);
	}

	public static void PKIELLFDFNB(Fish HAJFJGCNKFF, int PFBIBFJKHDD)
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)((MonoBehaviourPun)instance).photonView == (Object)null))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Items/item_name_1032", (RpcTarget)0, (short)HAJFJGCNKFF.JPNFKDMFKMC(), (short)PFBIBFJKHDD, null, null, null, null, null);
		}
	}

	[PunRPC]
	private void ReceiveMinusMoney(int JEPEICNIJNA)
	{
		Money.MinusPrice(Price.GHDCKOJGAMM(JEPEICNIJNA), BGKCHMNJBLJ: false);
	}
}
