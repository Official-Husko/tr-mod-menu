using Photon.Pun;
using Photon.Realtime;

public class OnlineFarmConstructionManager : MonoBehaviourPunCallbacks
{
	public static OnlineFarmConstructionManager instance;

	public int farmModeOpenedByOtherPlayer;

	private void CBJGILIIIDP(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
	}

	private void KFCFGCDPNOO(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public void DINPGDBPPHB(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "Failed to find prefab: ", (RpcTarget)0, array);
	}

	public void BAGPJJCOEPP()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "CutScene Settings", (RpcTarget)0, array);
	}

	public void NKJBDDGJCMP()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, " </mark>", (RpcTarget)0, array);
	}

	private void OEEPGPJJGPL(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.JLPJCGMJINB(CharacterSpritesDBAccessor.KAMKLLEKKKD(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.SetStyle(CharacterSpritesDBAccessor.GetHenHouseStyle(LDKDODKEIHJ));
		}
	}

	private void ODIOFBDFCKP(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void IBNCHMOAKKD()
	{
		farmModeOpenedByOtherPlayer = 1;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	private void OGHKHAPFKEB(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.JOIGJCPADFC(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.GetWaterFeederStyle(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	private void BBBNIJFNGDO(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	private void FLLELLLOBMI()
	{
		farmModeOpenedByOtherPlayer = 0;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	[PunRPC]
	private void ReceiveFeederStyle(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.GetFoodFeederStyle(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(foodFeederStyle);
		}
		else
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.GetWaterFeederStyle(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(foodFeederStyle);
		}
	}

	public void NKMLBJLODMH(int BEIPALOAAJJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = BEIPALOAAJJ;
		OnlineManager.SendRPC(photonView, "<mark=#000000><alpha=#00> ", (RpcTarget)0, array);
	}

	private void IGPMJBHJMAO()
	{
		farmModeOpenedByOtherPlayer = 1;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	public void MLJOAILIGMG()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "ReceiveResetBento", (RpcTarget)0, array);
	}

	public void SendFeederStyle(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFeederStyle", (RpcTarget)1, (byte)IDPPDALAEAA, (byte)LFCPJPCNDEM, (byte)LDKDODKEIHJ);
	}

	private void DGFMFDIFMEA(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void OLBGIPEJBCB(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void BLANIKEBJMC()
	{
		farmModeOpenedByOtherPlayer = 1;
		FarmConstructionManager.instance.AFHOMGNGMPK();
	}

	private void GCCKHNKPPJO()
	{
		farmModeOpenedByOtherPlayer = 0;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	public void KLBNMEBPPPG(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "StartObserverDialogue ", (RpcTarget)1, array);
	}

	public void PEGFCLMNIIL(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		array[2] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "pirates cave", (RpcTarget)0, array);
	}

	public void JLBOLCBALOC(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "' to ", (RpcTarget)0, array);
	}

	public void BPDMGOADEDA(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "LE_6", (RpcTarget)0, array);
	}

	private void BGBAPPODMPK(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		((MonoBehaviourPunCallbacks)this).OnPlayerLeftRoom(OKAOHBANICM);
		if (farmModeOpenedByOtherPlayer == OnlinePlayerDataManager.GetBedAssignedByActorNumber(OKAOHBANICM.ActorNumber))
		{
			ReceiveFarmConstructionDeactivated();
		}
	}

	public void LNFHILBEDGN(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		array[8] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "Sweet", (RpcTarget)1, array);
	}

	private void KJPENIBLFPC(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void PANGMPPIKKJ(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
	}

	private void JMJKOKCEDGM()
	{
		farmModeOpenedByOtherPlayer = 1;
		FarmConstructionManager.instance.AFHOMGNGMPK();
	}

	public void AKPJMCEKFBB(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		array[6] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	private void KMPBFLFLMOA()
	{
		farmModeOpenedByOtherPlayer = 0;
		FarmConstructionManager.instance.AFHOMGNGMPK();
	}

	public void GMEOEKIPOKL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Right Stick Down", (RpcTarget)1);
	}

	public void KJOEDDJCPBC(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		array[6] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "Pause", (RpcTarget)1, array);
	}

	private void KHNNHOAFOKF()
	{
		farmModeOpenedByOtherPlayer = 1;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	public void HDKOAHEHLKA(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "AnimatorObjectStateRequest", (RpcTarget)0, array);
	}

	public void OJCEMCDCLIF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_16", (RpcTarget)1, (byte)Bed.instance.numInstance);
	}

	private void DMHKCAMCCLI(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	public void SendFarmConstructionDeactivated()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFarmConstructionDeactivated", (RpcTarget)1);
	}

	public void SendFarmConstructionActivated()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFarmConstructionActivated", (RpcTarget)1, (byte)Bed.instance.numInstance);
	}

	private void DHNPDPCMBJJ(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	[PunRPC]
	private void ReceiveImproveFeeder(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public void FMKMPCLMKIF(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		array[3] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "UIInteract", (RpcTarget)1, array);
	}

	public void CEGKGNFAGBE(int BEIPALOAAJJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		OnlineManager.SendRPC(photonView, "<color=#BF0000>", (RpcTarget)1, array);
	}

	private void KOOFIBLPACI(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void OBHIGDLANEA()
	{
		farmModeOpenedByOtherPlayer = 1;
		FarmConstructionManager.instance.AFHOMGNGMPK();
	}

	public void NOLHGHACJGO(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		array[6] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "chat", (RpcTarget)0, array);
	}

	public void HNBOFMOJBAJ()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "[ControllerType:", (RpcTarget)1, array);
	}

	private void FBGAAOKGJOA(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public void LHFBFMMPOOA(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Standar/Entry/43/Dialogue Text", (RpcTarget)0, array);
	}

	private void FKFMOHKACMA(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.CJGDOILGCNC(CharacterSpritesDBAccessor.ANCJKCPDMMP(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.DCHCOFGMAKM(CharacterSpritesDBAccessor.PILFAIGHMGL(LDKDODKEIHJ));
		}
	}

	public void KPFFCKOJBAN(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Custom lobby data (Lobby creator): {0}", (RpcTarget)0, (byte)IDPPDALAEAA, (byte)LFCPJPCNDEM, null);
	}

	[PunRPC]
	private void ReceiveFarmConstructionActivated(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	public void CILDABKEAHC(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "DisableLeftExterior", (RpcTarget)0, array);
	}

	private void ELNDJGKFKOI(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.JOIGJCPADFC(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.HOCCFHPJIEB(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	private void JELFOPLAEHO(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.CJGDOILGCNC(CharacterSpritesDBAccessor.MFBIHHELKPD(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.DCHCOFGMAKM(CharacterSpritesDBAccessor.GetHenHouseStyle(LDKDODKEIHJ));
		}
	}

	public void IPGEHNJJBOP(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		array[8] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "SeatFound...", (RpcTarget)0, array);
	}

	public void CMGJNNLKHMB(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = BEIPALOAAJJ;
		array[1] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "onlineregion", (RpcTarget)1, array);
	}

	private void BIOLIGIDPFF(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.DHHOGOKEPON(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.EJGIEDOEJFG(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	private void EHHPNKEKOPL(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	public void FANAAJOGBLG(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, " seconds.", (RpcTarget)0, array);
	}

	private void BJFPJBEHOHF(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.GetFoodFeederStyle(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(foodFeederStyle);
		}
		else
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.DDHBCGDIAFC(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(foodFeederStyle);
		}
	}

	private void ADNLPBHGGIB(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void PCKOHAIPHFI()
	{
		instance = this;
	}

	private void PEFKNEPONAG()
	{
		instance = this;
	}

	public void MENMJOAMJHD(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		array[0] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "Open", (RpcTarget)0, array);
	}

	public void FIKKPOLBAEC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "F2", (RpcTarget)0);
	}

	public void EKNNHGFNKMH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Get Components ", (RpcTarget)1);
	}

	public void BLHFJGKLJBM(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "itemWineYeast", (RpcTarget)0, array);
	}

	private void JIEIDDHPGFB(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
	}

	public void ABOGNGPOLMJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Collect", (RpcTarget)0);
	}

	public void DGNKLJPAOFC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Talk", (RpcTarget)0);
	}

	public void MOELMLLAPOO(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "Far", (RpcTarget)0, array);
	}

	private void AELHIPFCKMH(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.SetStyle(CharacterSpritesDBAccessor.LNJGCKDELJO(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.SetStyle(CharacterSpritesDBAccessor.GNHFFFGAANI(LDKDODKEIHJ));
		}
	}

	private void DGGGHHKPPIP(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	[PunRPC]
	private void ReceiveFarmConstructionDeactivated()
	{
		farmModeOpenedByOtherPlayer = 0;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	private void GMMKNDCHENJ(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	private void HEJGBLPGLBE(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	private void BNHLIOCFFHH(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
	}

	private void CHCLCAFOLIK(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public void SendBuildingImprove(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBuildingImprove", (RpcTarget)1, BEIPALOAAJJ);
	}

	public void JIHLMGAKHOO(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "Could not find local player for the online player with the assigned bed: {0}", (RpcTarget)0, array);
	}

	private void KNNDNFIDNDC(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	public void MBKJDNEEBCK(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)1, BEIPALOAAJJ);
	}

	public void CMILHLCOAJO(int BEIPALOAAJJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		OnlineManager.SendRPC(photonView, "0", (RpcTarget)1, array);
	}

	public void FFKNFHDHJOE(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "Error_CellarZone", (RpcTarget)0, array);
	}

	private void HMLNLHKNFLA()
	{
		farmModeOpenedByOtherPlayer = 0;
		FarmConstructionManager.instance.OtherPlayerDeactivatedFarmMode();
	}

	public void HOOBAJBINGK()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "Player_", (RpcTarget)0, array);
	}

	public void EECPHPLKGPM(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		array[1] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "Random", (RpcTarget)0, array);
	}

	private void LEOMFNAOAGB(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.FHFGJMDAEEG(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.NABJAIMHLCP(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	public void GMFJGNMIBLK(int BEIPALOAAJJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		OnlineManager.SendRPC(photonView, " not found ingredient ", (RpcTarget)1, array);
	}

	private void ILONJAKOEPO(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.SetStyle(CharacterSpritesDBAccessor.GetBarnMaterial(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.DCHCOFGMAKM(CharacterSpritesDBAccessor.GNHFFFGAANI(LDKDODKEIHJ));
		}
	}

	private void CLNBMOPMNOF()
	{
		instance = this;
	}

	public void PHHLHOMOAGL(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MainProgress", (RpcTarget)0, BEIPALOAAJJ);
	}

	public void BCCNMAGHEDA(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "itemRye", (RpcTarget)1, array);
	}

	private void JLJFNEOKFDK(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
	}

	private void GIJLIFDMJME(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.FHFGJMDAEEG(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.EJGIEDOEJFG(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	private void KAPJOLIPOKL()
	{
		farmModeOpenedByOtherPlayer = 0;
		FarmConstructionManager.instance.AFHOMGNGMPK();
	}

	public void SendBuildingStyle(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBuildingStyle", (RpcTarget)1, BEIPALOAAJJ, (byte)LDKDODKEIHJ);
	}

	private void PGKGNMIPOCO(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public void FOCOECLEFGE(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "Floor worker", (RpcTarget)0, array);
	}

	private void CGIBDNCLEFD(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.FHFGJMDAEEG(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.NABJAIMHLCP(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	private void EDMHOANMPNM(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.JLPJCGMJINB(CharacterSpritesDBAccessor.KAMKLLEKKKD(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.PLEKBLENGKF(CharacterSpritesDBAccessor.CPJKPPHMEFB(LDKDODKEIHJ));
		}
	}

	private void FOEDNJLMLJO(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.SetStyle(CharacterSpritesDBAccessor.MFBIHHELKPD(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.DCHCOFGMAKM(CharacterSpritesDBAccessor.BABHNGPODBJ(LDKDODKEIHJ));
		}
	}

	public void FOFFFAEINME()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "ReceiveDestroyStatue", (RpcTarget)1, array);
	}

	private void EMHLHGICKAC(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public void KMAFCDPJCOC(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UI2", (RpcTarget)0, BEIPALOAAJJ);
	}

	private void JPKCLPCEPPC(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.SetStyle(CharacterSpritesDBAccessor.KAMKLLEKKKD(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.SetStyle(CharacterSpritesDBAccessor.CPJKPPHMEFB(LDKDODKEIHJ));
		}
	}

	private void AKJIECHBHHH(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.GetFoodFeederStyle(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(foodFeederStyle);
		}
		else
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.HOCCFHPJIEB(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(foodFeederStyle);
		}
	}

	public void NANBFPIOEGF(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, " : 00", (RpcTarget)1, array);
	}

	private void DFBKCALGKMP(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.GetFoodFeederStyle(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(foodFeederStyle);
		}
		else
		{
			SpritesList foodFeederStyle = CharacterSpritesDBAccessor.GetWaterFeederStyle(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(foodFeederStyle);
		}
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	private void BGNDCONADJJ(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	private void AIEEMICPIFB(byte MABCLGJONDO, byte HNLFMNLHHDE)
	{
		if (HNLFMNLHHDE == 0)
		{
			Barn.instance.animalSpaces[MABCLGJONDO].foodFeeder.Improve();
		}
		else
		{
			Barn.instance.waterFeeders[MABCLGJONDO].Improve();
		}
	}

	public void JINDKAOBJHI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<sprite name=\"ironNailsIcon\">", (RpcTarget)1);
	}

	public void KGIFLGDMFKM(int BEIPALOAAJJ, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		array[1] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "Fish didn't have a proper bed assigned value {0}", (RpcTarget)1, array);
	}

	public void PPOAKFDFCAF(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Place", (RpcTarget)1, BEIPALOAAJJ);
	}

	[PunRPC]
	private void ReceiveBuildingStyle(int BEIPALOAAJJ, byte LDKDODKEIHJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.SetStyle(CharacterSpritesDBAccessor.GetBarnMaterial(LDKDODKEIHJ));
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.SetStyle(CharacterSpritesDBAccessor.GetHenHouseStyle(LDKDODKEIHJ));
		}
	}

	private void LHLPDGBADEO(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
	}

	public void GOOGFKEHOCP(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)IDPPDALAEAA;
		array[1] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "OnGameLobbyJoinRequested. \nLobby: {0} \nFriend: {1}", (RpcTarget)1, array);
	}

	private void OOIFDMMHKKO(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	public void LHHPPHKINOL(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		OnlineManager.SendRPC(photonView, "Open", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveBuildingImprove(int BEIPALOAAJJ)
	{
		OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
		if (onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.barn.StartImproving();
		}
		else if (onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.StartImproving();
		}
	}

	public void SendImproveFeeder(int IDPPDALAEAA, FeederType LFCPJPCNDEM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveImproveFeeder", (RpcTarget)1, (byte)IDPPDALAEAA, (byte)LFCPJPCNDEM);
	}

	private void HFKMIIGGEBA(byte IDPPDALAEAA, byte HNLFMNLHHDE, byte LDKDODKEIHJ)
	{
		if (HNLFMNLHHDE == 0)
		{
			SpritesList style = CharacterSpritesDBAccessor.JOIGJCPADFC(LDKDODKEIHJ);
			Barn.instance.animalSpaces[IDPPDALAEAA].foodFeeder.SetStyle(style);
		}
		else
		{
			SpritesList style = CharacterSpritesDBAccessor.NABJAIMHLCP(LDKDODKEIHJ);
			Barn.instance.waterFeeders[IDPPDALAEAA].SetStyle(style);
		}
	}

	private void NABEJOHHMMD(byte GJDMLMEMKMD)
	{
		farmModeOpenedByOtherPlayer = GJDMLMEMKMD;
		FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
	}

	public void HABIHGLNHFI(int IDPPDALAEAA, FeederType LFCPJPCNDEM, int LDKDODKEIHJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = (byte)IDPPDALAEAA;
		array[0] = (byte)LFCPJPCNDEM;
		array[6] = (byte)LDKDODKEIHJ;
		OnlineManager.SendRPC(photonView, "ReceiveSleepStart", (RpcTarget)0, array);
	}
}
