using Photon.Pun;

public class OnlineDrinkDispensersManager : MonoBehaviourPunCallbacks
{
	public static OnlineDrinkDispensersManager instance;

	private OnlineObject NKJHFIDLEMN;

	private void CCNIJCFHKHL(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Crouch", (RpcTarget)0, array);
	}

	public void NEFLKGOJKEG(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			OCAJENFKBPJ(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "ReceiveEndEatingAtTable", (RpcTarget)6, array);
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	private void OOIHNJHMBMC()
	{
		instance = this;
	}

	public void GIPDMHHDMKL(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OPILDPFDFKJ().HKIHNBIFMHB((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void DMAKGNOAPDN(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			BPCEBAKPADP(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "[^0-9]", (RpcTarget)8, array);
	}

	[PunRPC]
	private void ReceiveSetDrinkColorMaster(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetDrinkColor", (RpcTarget)1, BEIPALOAAJJ, (byte)KEGEACEAPLA);
	}

	public void DDOMOJPCODI(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			GPCBFDIDNMA(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Perk with id ", (RpcTarget)5, array);
	}

	public void KNCECFEPBOB(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.JHMAMLIPBNN().HKBANNOMDPJ((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void NHIJAAHDCCE(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "christmasActivated", (RpcTarget)1, array);
	}

	public void BHCHJLEMPGA(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			NHIJAAHDCCE(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Stand/Entry/16/Dialogue Text", (RpcTarget)4, array);
	}

	private void ILCLIJOHKHG()
	{
		instance = this;
	}

	public void HNBNKPIEAPP(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.JHMAMLIPBNN().HKIHNBIFMHB((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void LPMFNBOOCMF(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Mouse Wheel Down", (RpcTarget)1, array);
	}

	private void KIBKMGKMBCA(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).MDMCMLHCFOD(KEGEACEAPLA);
		}
	}

	public void CODGMIOAGKG(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			DCJDJDJBIIH(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Loop", (RpcTarget)6, BEIPALOAAJJ, (byte)KEGEACEAPLA);
	}

	public void DDPNIAHAOIL(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			MLDGFLFEENK(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Farm/Buzz/Door_Bark_Searching", (RpcTarget)6, array);
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	public void GPCBFDIDNMA(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.JFNOOMJMHCB().KBLMMGDLEKL((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void LNHKOMOADHB(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			ReceiveSetDrinkColorMaster(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Items/item_name_626", (RpcTarget)6, array);
	}

	public void NGAHHJEHENC(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			NHIJAAHDCCE(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "add all resolutions", (RpcTarget)2, array);
	}

	private void GPCJBLADMGG(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).OCIPIHKCDIN(KEGEACEAPLA);
		}
	}

	private void HAMNBKGNHCG(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).IKHLKOOKAKH(KEGEACEAPLA);
		}
	}

	public void SendChangeDrinkColor(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveChangeDrinkColorMaster(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChangeDrinkColorMaster", (RpcTarget)2, BEIPALOAAJJ, (byte)KEGEACEAPLA);
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
	}

	public void IMCEMNKIEEA(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			GIPDMHHDMKL(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "ReceiveSetInt", (RpcTarget)8, array);
	}

	public void PCFLILCCHDH(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			MGOCKCKHLDL(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)7, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null, null, null, null, null);
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	private void HJLIKFHNMDM(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Duplicate Crop id found: ", (RpcTarget)0, array);
	}

	public void MOMDMMGIBPC(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.BNDNMBGJEKP().HKBANNOMDPJ((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void AOPMIGABIHD(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			OCAJENFKBPJ(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "City Update 0.6.5.0: Removing temple recipes with higher reputation level (", (RpcTarget)8, array);
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	public void NPIDIHLPDAH(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			DCJDJDJBIIH(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "itemMaltedWheat", (RpcTarget)6, array);
	}

	public void DMNBHPEIEIO(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			GOAFFBKKAPC(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1184", (RpcTarget)6, BEIPALOAAJJ, (byte)KEGEACEAPLA);
	}

	public void JPECJIJONED(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			MGOCKCKHLDL(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "LE_14", (RpcTarget)5, array);
	}

	private void DNBGIIGAKMJ()
	{
		instance = this;
	}

	public void ADMMIHMAMND(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OPILDPFDFKJ().KBLMMGDLEKL((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	public void PDDHEHGNODL(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OLHBLKIAFOM().KBLMMGDLEKL((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void EOGHPJLEEFA(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OLHBLKIAFOM().HKIHNBIFMHB((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void MLDGFLFEENK(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.BNDNMBGJEKP().ChangeDrinkColor((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void AHADFPEFKNO(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.JFNOOMJMHCB().KBLMMGDLEKL((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void SendSetDrinkColor(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveSetDrinkColorMaster(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetDrinkColorMaster", (RpcTarget)2, BEIPALOAAJJ, (byte)KEGEACEAPLA);
	}

	public void JEOKFHPPEKM(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			OJIGBODPFMF(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[Variants] Piece {0} ({1}) has 1 variant and it's deactivated.", (RpcTarget)6, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null, null, null, null, null);
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void PFOHGHOKIIF(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).GJKJNIDHBIK(KEGEACEAPLA);
		}
	}

	public void IOKCFFECPPE(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.BNDNMBGJEKP().KBLMMGDLEKL((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void DCJDJDJBIIH(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " is not fish", (RpcTarget)0, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null, null, null, null);
	}

	private void JMPHMPGDDDJ(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Room List has been updated.", (RpcTarget)1, array);
	}

	public void BLAOBHFFBHM(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			BHBHKBIILAO(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)6, array);
	}

	public void LJGIJOOJAJK(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OLHBLKIAFOM().ChangeDrinkColor((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void CLHAHFDPNAI(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			NHIJAAHDCCE(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Could not find item with id: ", (RpcTarget)2, array);
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	private void MGOCKCKHLDL(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "buildingObjective_2_1", (RpcTarget)0, array);
	}

	public void FIKNBDDADLK(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			MLDGFLFEENK(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/8/Dialogue Text", (RpcTarget)8, BEIPALOAAJJ, (byte)KEGEACEAPLA);
	}

	private void MHPIFHBJBGF(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).EAKCKPAFBAO(KEGEACEAPLA);
		}
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	private void PJKDFIDJAGL(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).HPPEHFJKLDI(KEGEACEAPLA);
		}
	}

	private void JPCMLLKFFHP(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).BHIKJKBGJDB(KEGEACEAPLA);
		}
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	public void IJNIKPFLGFD(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			LPMFNBOOCMF(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Fruit Liqueur", (RpcTarget)4, array);
	}

	public void MPJJIEAIMFG(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			ReceiveChangeDrinkColorMaster(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)8, array);
	}

	public void IGBEPALBBNO(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			HNBNKPIEAPP(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSkipKlaynChallenge", (RpcTarget)3, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null, null, null, null);
	}

	public void BHBHKBIILAO(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OLHBLKIAFOM().HKBANNOMDPJ((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	[PunRPC]
	private void ReceiveSetDrinkColor(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).SetDrinkColor(KEGEACEAPLA);
		}
	}

	private void CKDODAODMDO(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).HPPEHFJKLDI(KEGEACEAPLA);
		}
	}

	public void CNJCEFBCPOB(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			DCJDJDJBIIH(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "No se encuentra el valor ", (RpcTarget)4, array);
	}

	public void DMADHMKFPKG(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			LJGIJOOJAJK(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Trigger {0} fired on {1}'s animator. Sending RPC.", (RpcTarget)2, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null);
	}

	public void GOIIEPGIPME(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			MOMDMMGIBPC(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "End", (RpcTarget)2, array);
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	public void FKBNNOIPINA(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.BNDNMBGJEKP().ChangeDrinkColor((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void LNOCFIKLILL(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OLHBLKIAFOM().ChangeDrinkColor((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void OCAJENFKBPJ(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "ReceiveSwitchFoodAtTables", (RpcTarget)0, array);
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
	}

	public void KNBHMCHBPPN(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			HIILJHHHJGJ(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "HideClickWarning", (RpcTarget)1, array);
	}

	private void OJIGBODPFMF(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DogOfFriend", (RpcTarget)0, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null);
	}

	public void COMIPFPCNFK(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			OCAJENFKBPJ(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Friend ", (RpcTarget)8, array);
	}

	private void KHHFCBNEIEL(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "City/PetShop/Nessy/PerritosAbandonados", (RpcTarget)0, array);
	}

	public void HIILJHHHJGJ(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.GGFJGHHHEJC.HKIHNBIFMHB((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	public void BPCEBAKPADP(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OPILDPFDFKJ().HKIHNBIFMHB((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public void OIPLILKGCJL(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			OIANBFBLIFD(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)7, array);
	}

	private void GOAFFBKKAPC(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sleep", (RpcTarget)1, BEIPALOAAJJ, (byte)KEGEACEAPLA, null, null, null, null);
	}

	[PunRPC]
	public void ReceiveChangeDrinkColorMaster(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.GGFJGHHHEJC.ChangeDrinkColor((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void PDIECJCKCOD()
	{
		instance = this;
	}

	private void LJMCJBAHLEC(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).HDHCOBKNBIC(KEGEACEAPLA);
		}
	}

	public void KNLNHLKKGPA(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			DrinkDispensersManager.OLHBLKIAFOM().HKIHNBIFMHB((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser, KEGEACEAPLA);
		}
	}

	private void GEOCALEBBMK(int BEIPALOAAJJ, byte KEGEACEAPLA)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDrinkDispenser).OKAJEGMKCJO(KEGEACEAPLA);
		}
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	private void GGOPCJOAOMC()
	{
		instance = this;
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	public void GEENIMCHCAO(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			KNLNHLKKGPA(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "buildingObjective_9_0", (RpcTarget)0, array);
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public void MJNBGNMOBBG(int BEIPALOAAJJ, short KEGEACEAPLA)
	{
		if (OnlineManager.IsMasterClient())
		{
			MOMDMMGIBPC(BEIPALOAAJJ, (byte)KEGEACEAPLA);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = BEIPALOAAJJ;
		array[0] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "UIBack", (RpcTarget)4, array);
	}

	private void OIANBFBLIFD(int BEIPALOAAJJ, int KEGEACEAPLA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		array[1] = (byte)KEGEACEAPLA;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/TableDirty/Entry/2/Dialogue Text", (RpcTarget)1, array);
	}
}
