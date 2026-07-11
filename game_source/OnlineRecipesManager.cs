using Photon.Pun;

public class OnlineRecipesManager : MonoBehaviourPunCallbacks
{
	public static OnlineRecipesManager instance;

	public void IMCBJHLJICJ(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.", (RpcTarget)0, (short)GBOJANFONBF);
	}

	[PunRPC]
	private void ReceiveUnlockedRecipeMaster(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	public void BEEIADJIDMJ(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	private void FGMEPEMIFNC()
	{
		AceTNPC.JHMAMLIPBNN().BICFNHGODGG(CDPAMNIPPEC: true);
	}

	public void HEEENPJHJID()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "recipe fragments", (RpcTarget)1);
	}

	public void KGLKHLJAINH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "hallway", (RpcTarget)1);
	}

	private void FGAHFOMHGPD()
	{
		AceTNPC.ICNFHJLLHGP().FDEDPDPMNJO(CDPAMNIPPEC: true);
	}

	public void FKNCPCIFEBJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "fish_description_", (RpcTarget)0);
	}

	public void LAJJJMLCGLK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Throw", (RpcTarget)1);
	}

	public void BMAKFEKFPGF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Hide UI", (RpcTarget)0);
	}

	private void NGJDBFGGMED()
	{
		AceTNPC.ICNFHJLLHGP().ALFONMMABGE(CDPAMNIPPEC: false);
	}

	private void IAEBHNLKJOH()
	{
		AceTNPC.MJCMPKPCNGB().FMIDAIBOIDO(CDPAMNIPPEC: true);
	}

	public void IDMHNFJGBBE(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error instantiating placeable from message of type ", (RpcTarget)1, (short)GBOJANFONBF);
	}

	private void PBOEMHOFDLI()
	{
		AceTNPC.PDECKLKPKCG().NOIMOIFEICF(CDPAMNIPPEC: true);
	}

	private void DJPDAFCJJNC(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
	}

	public void HADBFNMCPHG(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Hurt", (RpcTarget)0, array);
	}

	public void GMCFOOEFECP(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Items/item_description_664", (RpcTarget)0, array);
	}

	private void NEJGOCOJNJM()
	{
		AceTNPC.FMIDAFEGDCD().FMIDAIBOIDO(CDPAMNIPPEC: false);
	}

	public void DHMNIIIFMLF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "FishBiteRPC", (RpcTarget)1);
	}

	private void BPHEMEJIPGD(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF);
	}

	private void EEIAAFCOOBG(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF);
	}

	private void OMPEJNNPCJA(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	public void FAFGMEELFNO(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Pick up", (RpcTarget)1, array);
	}

	private void CPEGCBJPNMB(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
	}

	public void GKJEFENPOOO(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Setup ", (RpcTarget)1, array);
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	private void OPNMJCMFAAJ(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: false, CDPAMNIPPEC: false);
	}

	public void LBJCLHMOCNP(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Give", (RpcTarget)0, (short)GBOJANFONBF);
	}

	public void GFMMLFMAKAL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RoadBlocked/Main 2", (RpcTarget)1);
	}

	private void KKCOEFLPNPA()
	{
		AceTNPC.KMKILBCGJOI().UnlockChristmasRecipe(CDPAMNIPPEC: false);
	}

	private void KOLNFIMKGGK()
	{
		AceTNPC.DGCNCEDIFOF().EFDPLGHNNMJ(CDPAMNIPPEC: false);
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void LDLMJDGKLIC(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	public void HHKGEJGFCHF(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemRug", (RpcTarget)0, (short)GBOJANFONBF);
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
	}

	public void NGGFNHDBJHK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UI2", (RpcTarget)0);
	}

	private void ALBKGJJMNII(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF);
	}

	private void NCKPIOAEMKO(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	private void JIGNMBJOKLF(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	public void HFCIMBHBKMK(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Player with playerNum {0} does not exist or has been removed from the dictionary after disconnecting.", (RpcTarget)0, array);
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	private void OAEJGGFFCBO()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	public void LHEJJOLEDAB(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "UpdateObjectives ", (RpcTarget)1, array);
	}

	public void JINDLFLFNNK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemStout", (RpcTarget)0);
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	private void GMEHEPMGJLP()
	{
		AceTNPC.PDECKLKPKCG().UnlockChristmasRecipe(CDPAMNIPPEC: false);
	}

	private void BIEDAINADCI(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF);
	}

	public void CCIILBHCNMC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Removing Rented Room Zone!", (RpcTarget)0);
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	private void MIIMGEJAGGJ()
	{
		AceTNPC.DGCNCEDIFOF().BICFNHGODGG(CDPAMNIPPEC: false);
	}

	public void LGHENKNKPEH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Eye-lashes", (RpcTarget)1);
	}

	private void MJDIINNPAKE()
	{
		AceTNPC.FMIDAFEGDCD().FMIDAIBOIDO(CDPAMNIPPEC: false);
	}

	private void GNBHIFCBJJL(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	private void KFFKDADBACB(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	public void BAJKMGKKMEO(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Game Over! ", (RpcTarget)1, array);
	}

	private void HPEOHGAKPFF(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF);
	}

	public void SendUnlockedRecipeMaster(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUnlockedRecipeMaster", (RpcTarget)1, (short)GBOJANFONBF);
	}

	private void PKCOMFEBHOJ(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	private void ELFADAKIAOJ(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF);
	}

	public void NMFOLPADHAH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Open", (RpcTarget)1);
	}

	public void HAHFFBDHNBK(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Stand/Entry/10/Dialogue Text", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveUnlockChristmasRecipes()
	{
		AceTNPC.GGFJGHHHEJC.UnlockChristmasRecipe(CDPAMNIPPEC: false);
	}

	public void NFMFBCMALMO()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Unlocked at Tavern Reputation {0}", (RpcTarget)1);
	}

	private void KEKOCMKLKOF()
	{
		AceTNPC.JHMAMLIPBNN().ALFONMMABGE(CDPAMNIPPEC: true);
	}

	public void EMBNPAMJHLI(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error max zones", (RpcTarget)0, (short)GBOJANFONBF);
	}

	public void MBEELFLHOCD(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Items/item_description_629", (RpcTarget)1, array);
	}

	private void CIICEKEJANM()
	{
		instance = this;
	}

	public void NGNGLLCNFEO(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "UIBack", (RpcTarget)1, array);
	}

	private void HEMLAMMKNFD()
	{
		AceTNPC.MJCMPKPCNGB().FMIDAIBOIDO(CDPAMNIPPEC: false);
	}

	private void FIBJAOMOMLM(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	private void CDBDGKABNJK(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	private void ICEJMKNNJDM()
	{
		AceTNPC.PDECKLKPKCG().EFDPLGHNNMJ(CDPAMNIPPEC: false);
	}

	private void DGBJJNAADCI()
	{
		instance = this;
	}

	private void PLAOJECHGEF()
	{
		AceTNPC.NEFIEJALANL().BICFNHGODGG(CDPAMNIPPEC: false);
	}

	public void PCGKNDADPAI(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Read", (RpcTarget)0, array);
	}

	private void ODOKHJGCMJF()
	{
		AceTNPC.POINNCPMEIG().BEMHMONOHOI(CDPAMNIPPEC: true);
	}

	public void INJMJJMCPLJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tail", (RpcTarget)0);
	}

	private void HEOMCJGECNM()
	{
		AceTNPC.GGFJGHHHEJC.BICFNHGODGG(CDPAMNIPPEC: true);
	}

	public void SendUnlockChristmasRecipes()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUnlockChristmasRecipes", (RpcTarget)1);
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void CKGNCPLNBJM(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true);
	}

	public void DKADOJDIIHN(int GBOJANFONBF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_614", (RpcTarget)1, (short)GBOJANFONBF);
	}

	public void OJEJLPFJLEH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Mussel parent not found!!. Parent unique ID: ", (RpcTarget)1);
	}

	public void PINLODFMNGD(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "ValueRemainingMs", (RpcTarget)0, array);
	}

	public void NHLFCPFLBAL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Crowly_Barks_Bye/Entry/4/Dialogue Text", (RpcTarget)1);
	}

	public void LNFOLACIEJL(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Moving", (RpcTarget)0, array);
	}

	private void EEPMNBJFKJN(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	public void MHDHHGEOKJN(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "ReceivePlaceCharges", (RpcTarget)0, array);
	}

	public void IFPLMFPKBBA(int GBOJANFONBF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)GBOJANFONBF;
		OnlineManager.SendRPC(photonView, "Burp", (RpcTarget)1, array);
	}

	public void AFFBIFPBLKJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ErrorJoinRoomClosed", (RpcTarget)1);
	}

	public void KOKFKGODKDC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "House keeper OnFailStart cleaning bed ", (RpcTarget)1);
	}

	private void NMMJNDCHOOH(short GBOJANFONBF)
	{
		RecipesManager.UnlockRecipeMaster(GBOJANFONBF, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}
}
