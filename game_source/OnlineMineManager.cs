using Photon.Pun;
using UnityEngine;

public class OnlineMineManager : MonoBehaviourPunCallbacks
{
	public static OnlineMineManager instance;

	public void NOPOPPJAGHA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "00", (RpcTarget)0);
	}

	private void NLJBENEIBGF(byte EONJGMONIOM)
	{
		ProceduralMine.BADFKMEJOKE().EHJHJDIGHMD(EONJGMONIOM);
	}

	private void Awake()
	{
		instance = this;
	}

	private void AICKOMCHDJI()
	{
		MineManager.AGGAGCBAGLL().PlaceCharges();
	}

	private void IGHMMOKFINH()
	{
		instance = this;
	}

	[PunRPC]
	private void ReceiveExplodeCharges()
	{
		MineManager.GGFJGHHHEJC.ExplodeCharges(CDPAMNIPPEC: false);
	}

	public void HLDCKEJEJKF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/BirdCatInteraction/Entry/4/Dialogue Text", (RpcTarget)0);
	}

	public void PFMBJOPKDBJ(int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "IntroNinjaChallengeEvent/Main 2", (RpcTarget)3, (byte)EONJGMONIOM);
	}

	private void EBFNOOPAPED(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("CannotToggleUI RentRoomUI opened", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("Bathouse Minigame has not been initialized. We must be in the bathhouseinterior scene.", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void KKODPAHBPHB(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)1, array);
	}

	private void PJAGIBJACKM()
	{
		instance = this;
	}

	public void GMKDNJIJJFJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Interact", (RpcTarget)0);
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	public void SendGenerateMineLevel(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGenerateMineLevel", (RpcTarget)1, (byte)EONJGMONIOM, BLLLPOFNPLM);
	}

	public void PAFKDIIMOEJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1126", (RpcTarget)1);
	}

	public void GPEDHCNDPPP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " installed", (RpcTarget)0);
	}

	private void BEPHPPAAPIE()
	{
		MineManager.OOKBNHMMFON().PlaceCharges(CDPAMNIPPEC: false);
	}

	public void JDNGGNCOLMP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Ax Level Low", (RpcTarget)0);
	}

	public void NJFADFDACAI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_10", (RpcTarget)0);
	}

	private void ELEBGLNLLLB()
	{
		MineManager.PDECKLKPKCG().IAKICBAOCCO(CDPAMNIPPEC: false);
	}

	private void BKEHJHCEGEA()
	{
		MineManager.PDECKLKPKCG().IAKICBAOCCO();
	}

	public void MFPBBPLPEKM()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DecorationTile_21", (RpcTarget)1);
	}

	private void IGNELLIJHOA()
	{
		MineManager.AGGAGCBAGLL().IAKICBAOCCO();
	}

	public void FCLCEBLNJGI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInfoTerrain", (RpcTarget)1);
	}

	public void MKCAGEKKKOD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "add all resolutions", (RpcTarget)1);
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	public void ALGHCALJBNM()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "NormalRight", (RpcTarget)0);
	}

	public void HBHAMNLPENG(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "ReceiveKick", (RpcTarget)1, array);
	}

	private void DOMHNECMMBC()
	{
		MineManager.PDECKLKPKCG().DNEGOPDNJHF(CDPAMNIPPEC: false);
	}

	private void DKLCBFENOOL()
	{
		MineManager.BGMJCCFNNDL().IAKICBAOCCO(CDPAMNIPPEC: false);
	}

	private void DKEHOFGPCBL()
	{
		MineManager.PDECKLKPKCG().PlaceCharges();
	}

	private void LEEKOCHIIMP(byte EONJGMONIOM)
	{
		ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, 1);
	}

	private void EDIKGNOLJGL()
	{
		MineManager.BGMJCCFNNDL().DNEGOPDNJHF();
	}

	public void KCBEBADLKKJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Left", (RpcTarget)1);
	}

	private void OLKBBKIDPEJ(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Player", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format(" in onlineObjects is null", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.BADFKMEJOKE().NEMOPCKLBAG(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void DIGHKCJHNLE()
	{
		MineManager.PDECKLKPKCG().CHKKKBGALKB();
	}

	private void EFABNGNAENH()
	{
		instance = this;
	}

	public void MEFHLJGMLMO()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_706", (RpcTarget)0);
	}

	private void PIJJFCBJEBB()
	{
		MineManager.GGFJGHHHEJC.IAKICBAOCCO();
	}

	private void ACMMPOMMBNB()
	{
		MineManager.PDECKLKPKCG().ExplodeCharges();
	}

	public void GCPECOBOLJK(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "quarry travelling", (RpcTarget)0, array);
	}

	private void JCCEANILIKB(byte EONJGMONIOM)
	{
		ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, 1);
	}

	private void HHNAMCBNFJN()
	{
		MineManager.BGMJCCFNNDL().IAKICBAOCCO();
	}

	public void MFNHNCMDFKK(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (byte)EONJGMONIOM;
		array[1] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "yForYears", (RpcTarget)0, array);
	}

	private void CHGGNPEKBND()
	{
		MineManager.AGGAGCBAGLL().ExplodeCharges(CDPAMNIPPEC: false);
	}

	public void CAFGODICCJK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "farminterior", (RpcTarget)1);
	}

	private void IPCIJLEDEED()
	{
		MineManager.AGGAGCBAGLL().JKNOFKDANMN(CDPAMNIPPEC: false);
	}

	private void GMFIKDBKHAI(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("ChristmasPresent", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("Waiter", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.IGHCDFAJJPC(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void PGANELBEAIE()
	{
		MineManager.GGFJGHHHEJC.IAKICBAOCCO(CDPAMNIPPEC: false);
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	public void JNFINFCNACC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "CheckoutDate", (RpcTarget)0);
	}

	public void EMEOLKDEMJO(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DecorationTile_13", (RpcTarget)1, (byte)EONJGMONIOM, BLLLPOFNPLM, null, null, null, null, null);
	}

	private void HHCJHNEDAHA()
	{
		MineManager.AGGAGCBAGLL().JKNOFKDANMN(CDPAMNIPPEC: false);
	}

	private void KDOOCGKKGOM()
	{
		MineManager.OOKBNHMMFON().ExplodeCharges();
	}

	public void BHOGKMJJNNA(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)0, array);
	}

	public void NJIODNDJIPK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Left Trigger", (RpcTarget)1);
	}

	private void HLNECEOOMIJ()
	{
		MineManager.GGFJGHHHEJC.ExplodeCharges();
	}

	private void IPOCCBPHCLI()
	{
		MineManager.GGFJGHHHEJC.LOPPDFFCFKA();
	}

	public void OLFFJCNJPBP(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "L2", (RpcTarget)1, (byte)EONJGMONIOM, BLLLPOFNPLM, null, null, null);
	}

	public void KIBHLEIHKBP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UI", (RpcTarget)0);
	}

	public void GIADPOAKPJH(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Key2", (RpcTarget)4, array);
	}

	private void BBIOMDDMPAL(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() == (Object)null)
		{
			Debug.LogWarning((object)string.Format("NotFocused", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("NotValid", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.BADFKMEJOKE().NEMOPCKLBAG(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void IAFCGJGOILB(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "Tutorial/T127/Dialogue2", (RpcTarget)0, array);
	}

	public void CMPGCJGINGF(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Body Part Dictionary:\n[\n", (RpcTarget)2, array);
	}

	public void ELPPPOEHIFH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Guest", (RpcTarget)0);
	}

	private void EDIHFJEAPLG()
	{
		MineManager.BGMJCCFNNDL().IAKICBAOCCO(CDPAMNIPPEC: false);
	}

	private void MEHJBCAOHKJ(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Aged", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.HHDBMDMFEMP() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("/ExtraSettings.sd", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void FNGBLCAMILD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartKlaynDialogueOathFeast", (RpcTarget)0);
	}

	private void AJDGCODCJCL()
	{
		MineManager.BGMJCCFNNDL().CHKKKBGALKB(CDPAMNIPPEC: false);
	}

	public void EILBIOHPEHL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "0", (RpcTarget)0);
	}

	public void PAPCCIMHHNH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_1134", (RpcTarget)0);
	}

	private void HAGBOGEFIHK(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Aged price", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.HHDBMDMFEMP() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("Selected", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.EHJHJDIGHMD(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	[PunRPC]
	private void ReceiveGenerateMineLevelMaster(byte EONJGMONIOM)
	{
		ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM);
	}

	private void DJFLNACMOGD()
	{
		MineManager.OOKBNHMMFON().PlaceCharges(CDPAMNIPPEC: false);
	}

	public void HHHIJDDLCEK(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	public void MIENIIMLMLH(int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/BirdPositiveComments/Entry/8/Dialogue Text", (RpcTarget)8, (byte)EONJGMONIOM);
	}

	public void HEOGAOIBNGC(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "RecieveMothersRecipeEventCof", (RpcTarget)7, array);
	}

	public void EOCEBCOJOHI(int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "night", (RpcTarget)5, (byte)EONJGMONIOM);
	}

	public void LCGAOFDAOOJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "id: ", (RpcTarget)0);
	}

	public void BKDLGCMNKEK(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "LE_3", (RpcTarget)1, array);
	}

	private void IABJIEFCOKE()
	{
		MineManager.GGFJGHHHEJC.ExplodeCharges(CDPAMNIPPEC: false);
	}

	private void EAJGDFNCOFI(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("1", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("Error instantiating placeable from message of type ", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.BADFKMEJOKE().NEMOPCKLBAG(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void EKOFIBPGNHB(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "City/Rhia/Introduce", (RpcTarget)1, array);
	}

	public void KBAIFOFADME(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)6, array);
	}

	private void GOFJCKGJHJO()
	{
		instance = this;
	}

	[PunRPC]
	private void ReceivePlaceCharges()
	{
		MineManager.GGFJGHHHEJC.PlaceCharges(CDPAMNIPPEC: false);
	}

	public void IGMJNAMLJOB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "No content to disable in this NPC!", (RpcTarget)1);
	}

	private void IDKDLMJLJLD(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Error_CellarZone", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("Dialogue System/Conversation/BirdNegativeComments/Entry/3/Dialogue Text", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.ALBOELEENBJ(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void ENGJJDOKFHM()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player2", (RpcTarget)1);
	}

	public void PNJLBLEOEBA(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "</color>", (RpcTarget)7, array);
	}

	private void BPHCPAFHCPM()
	{
		MineManager.PDECKLKPKCG().ExplodeCharges(CDPAMNIPPEC: false);
	}

	public void DJAIPHGKGFB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ".", (RpcTarget)0);
	}

	private void IIEPDDGFGKG()
	{
		MineManager.BGMJCCFNNDL().DNEGOPDNJHF(CDPAMNIPPEC: false);
	}

	public void ABJMDOAMDKF(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)0, array);
	}

	public void IEHGLDMEAAM()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Drunk", (RpcTarget)1);
	}

	private void LDEANKALOCK(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Crafting ", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format(" not found!", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void MPCFCNCMOAF()
	{
		instance = this;
	}

	public void KAHCMDFGFJH(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Use", (RpcTarget)7, array);
	}

	public void SendPlaceCharges()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlaceCharges", (RpcTarget)1);
	}

	public void ICOPNPPFAAA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Crowly_Introduce/Entry/29/Dialogue Text", (RpcTarget)0);
	}

	[PunRPC]
	private void ReceiveGenerateMineLevel(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)$"[OnlineMineManager] ReceiveGenerateMineLevel: ProceduralMine.instance is null. Level={EONJGMONIOM} Seed={BLLLPOFNPLM}");
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)$"[OnlineMineManager] ReceiveGenerateMineLevel: Client doesnt have scene loaded. Level={EONJGMONIOM} Seed={BLLLPOFNPLM}");
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void LLEPJDHHFBA()
	{
		MineManager.BGMJCCFNNDL().ExplodeCharges();
	}

	public void NPMCFPDJNJO(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (byte)EONJGMONIOM;
		array[1] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "Items/item_name_1180", (RpcTarget)1, array);
	}

	public void GAEKNLPLKPG()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalName", (RpcTarget)1);
	}

	private void HBDKHEDCOFD(byte EONJGMONIOM)
	{
		ProceduralMine.GGFJGHHHEJC.EHJHJDIGHMD(EONJGMONIOM, 1);
	}

	private void INHBDHMJHEB()
	{
		instance = this;
	}

	private void ADGMHJNIJMD(byte EONJGMONIOM)
	{
		ProceduralMine.BADFKMEJOKE().EKLBEEPOCDH(EONJGMONIOM, 1);
	}

	private void CHOJKDPIHLM(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() == (Object)null)
		{
			Debug.LogWarning((object)string.Format("HotBath/Main 3", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("ReceiveTrends", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.IGHCDFAJJPC(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void GKJJCEEGGAA(byte EONJGMONIOM)
	{
		ProceduralMine.BADFKMEJOKE().EHJHJDIGHMD(EONJGMONIOM);
	}

	private void PLECMJHDLPL()
	{
		MineManager.GGFJGHHHEJC.IAKICBAOCCO(CDPAMNIPPEC: false);
	}

	public void FJBBEKICILC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player2", (RpcTarget)0);
	}

	private void CHMHFKOFFED(byte EONJGMONIOM)
	{
		ProceduralMine.BADFKMEJOKE().IGHCDFAJJPC(EONJGMONIOM, 1);
	}

	public void LPMMCFLEBNI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_1044", (RpcTarget)1);
	}

	public void NALOALFMENC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_607", (RpcTarget)0);
	}

	private void FLMKKPMAMOH()
	{
		MineManager.OOKBNHMMFON().CHKKKBGALKB(CDPAMNIPPEC: false);
	}

	public void DJHKIKAMAFD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " : ", (RpcTarget)0);
	}

	private void KIMONNNGCLL(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Items/item_description_642", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.HHDBMDMFEMP() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("ErrorInvalidRoomCode", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.BADFKMEJOKE().IGHCDFAJJPC(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void OAFBKOLJKAB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tutorial/T130/Dialogue1", (RpcTarget)1);
	}

	private void JDHHJKBOJML()
	{
		instance = this;
	}

	private void AMMBPFGJLIN(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Trying to add player but player list is full.", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.HHDBMDMFEMP() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("\n", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.GenerateLevel(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void NAEFNNLEPGF()
	{
		MineManager.BGMJCCFNNDL().CHKKKBGALKB();
	}

	public void GONMLOOIMCD(int EONJGMONIOM, int BLLLPOFNPLM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)EONJGMONIOM;
		array[0] = BLLLPOFNPLM;
		OnlineManager.SendRPC(photonView, "TakesXDaysToGrow", (RpcTarget)1, array);
	}

	private void IGNIMDHCOLG()
	{
		MineManager.BGMJCCFNNDL().IAKICBAOCCO(CDPAMNIPPEC: false);
	}

	public void BBLEDEHLJIE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerBucketType", (RpcTarget)1);
	}

	private void OIKCNDONKHJ()
	{
		MineManager.AGGAGCBAGLL().DNEGOPDNJHF(CDPAMNIPPEC: false);
	}

	public void OHBOJADDLBF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTrayState", (RpcTarget)1);
	}

	private void JNBICAOEFMK()
	{
		MineManager.PDECKLKPKCG().IAKICBAOCCO();
	}

	public void KOLOJMCHAAA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " will be destroyed in ", (RpcTarget)1);
	}

	private void OPIIEHNKGHG()
	{
		MineManager.PDECKLKPKCG().ExplodeCharges();
	}

	private void FDHFKCLIGAD()
	{
		MineManager.BGMJCCFNNDL().LOPPDFFCFKA();
	}

	private void GFFJAGCBMIB()
	{
		MineManager.PDECKLKPKCG().IAKICBAOCCO();
	}

	public void SendGenerateMineLevelMaster(int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGenerateMineLevelMaster", (RpcTarget)2, (byte)EONJGMONIOM);
	}

	public void KALJAJDAIMH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Received finish minigame", (RpcTarget)0);
	}

	private void EKPGIOCEANJ()
	{
		MineManager.BGMJCCFNNDL().ExplodeCharges();
	}

	private void CIDNIKOJGAN(byte EONJGMONIOM)
	{
		ProceduralMine.BADFKMEJOKE().EHJHJDIGHMD(EONJGMONIOM);
	}

	private void IONIJFMPGOP(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Destroying all animals", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.HHDBMDMFEMP() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("LE_14", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.NEMOPCKLBAG(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void DGGLPHIAOKM(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "description", (RpcTarget)7, array);
	}

	private void APPCNOMKDMD()
	{
		MineManager.PDECKLKPKCG().LOPPDFFCFKA();
	}

	public void AAGCKFKKAAC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Explode", (RpcTarget)1);
	}

	public void JFABPIJJPNL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Lightning2", (RpcTarget)0);
	}

	public void CEEAHLLILOP(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "ValueSuitabilities", (RpcTarget)3, array);
	}

	private void FELJAKBBFJD()
	{
		instance = this;
	}

	private void OAEJGGFFCBO()
	{
		instance = this;
	}

	private void HBHJDNACMMH()
	{
		MineManager.OOKBNHMMFON().CHKKKBGALKB();
	}

	public void KCOBJFLDOJC(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Items/item_description_693", (RpcTarget)2, array);
	}

	private void MIKLKFFGDCA(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.GGFJGHHHEJC == (Object)null)
		{
			Debug.LogWarning((object)string.Format("<sprite name=\"ironBarIcon\">", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format(" ", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.BADFKMEJOKE().IGHCDFAJJPC(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	public void FBAHLEEJDHE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "cameraZoom2", (RpcTarget)1);
	}

	public void IMMIMPLNEJD(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "OnUserStatsAndAchievementsStoreFailure: ", (RpcTarget)2, array);
	}

	public void SendExplodeCharges()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveExplodeCharges", (RpcTarget)1);
	}

	private void ACHLMCGAHDM()
	{
		MineManager.GGFJGHHHEJC.IAKICBAOCCO();
	}

	public void GHDFBBAEJGN(int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Attack/MainEvent 7", (RpcTarget)5, array);
	}

	private void DPBJLBEKNHG(byte EONJGMONIOM, int BLLLPOFNPLM)
	{
		if ((Object)(object)ProceduralMine.BADFKMEJOKE() == (Object)null)
		{
			Debug.LogWarning((object)string.Format("Fish thrower is null or has been destroyed. This shouldn't happen.", EONJGMONIOM, BLLLPOFNPLM));
		}
		else if (OnlineManager.HHDBMDMFEMP() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.LogWarning((object)string.Format("F3", EONJGMONIOM, BLLLPOFNPLM));
		}
		else
		{
			ProceduralMine.GGFJGHHHEJC.IGHCDFAJJPC(EONJGMONIOM, BLLLPOFNPLM);
		}
	}

	private void IKNHMOEFOCM()
	{
		MineManager.BGMJCCFNNDL().ExplodeCharges(CDPAMNIPPEC: false);
	}
}
