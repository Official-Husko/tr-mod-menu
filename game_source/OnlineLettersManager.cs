using Photon.Pun;

public class OnlineLettersManager : MonoBehaviourPunCallbacks
{
	public static OnlineLettersManager instance;

	public void OCNGNOJEIAO(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "</color><br>", (RpcTarget)1, array);
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	public void EJIKMGKAMPO(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Request minigame", (RpcTarget)0, array);
	}

	private void PECMFLDFNJN(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void Awake()
	{
		instance = this;
	}

	public void CKJGLPDHEBE(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "RPC: {0}\nCalled {1} times\nBiggest packet: {2} bytes.", (RpcTarget)1, array);
	}

	public void BKNFBOFFANA(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "ItemInstance is not valid.", (RpcTarget)1, array);
	}

	public void DHFOCFAPEKH(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "next pos reached", (RpcTarget)0, array);
	}

	public void EDMLELHOILI(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "ReceiveTalentsLoad", (RpcTarget)0, array);
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	public void SendLettersInfo(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLettersInfo", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void KIBNHDEIGHE(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).FJFEIIIIAMJ();
	}

	private void MNJOGBAKEAP(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void BEOBGGHHLOI(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).JCJLLIEHCPJ();
	}

	[PunRPC]
	private void ReceiveDeletedLetterIndex(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void DLGACAPLAHO(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void DBFLHELHACI(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	private void PIKAIENKGOH(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).MOEHLFOHLLO();
	}

	public void LJJNBPIIAEI(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "UISelectGamepad", (RpcTarget)1, array);
	}

	public void MPNDMOLKBDN(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "report_type", (RpcTarget)0, array);
	}

	private void MCKPHGLPCGN(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	public void IAEAPMGBAIJ(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Stand/Entry/20/Dialogue Text", (RpcTarget)1, array);
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	private void AJEKNOPKEMF(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).KGNIEGOBNLD();
	}

	private void GGOPCJOAOMC()
	{
		instance = this;
	}

	public void PPIIEGBMNMJ(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "VERSION", (RpcTarget)0, array);
	}

	private void MIKNFPCDLML()
	{
		instance = this;
	}

	private void MBAGHGLMCPE(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	public void ALONNFOLPLE(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Gameplay", (RpcTarget)0, array);
	}

	public void DIPEAJNHMHB(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Object dropped on Bar position: ", (RpcTarget)1, array);
	}

	public void OONKIBNGJED(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)0, array);
	}

	private void DOHEADBHOGC(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	private void AKNFICIDJGB(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).OAOACMPNMOK();
	}

	public void SendNewLetter(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNewLetter", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void GPJKPLHCGHC(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	private void KGECNOEKKOF(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void FHIHAFMDBHM(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void HOKEFEOAECI(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Failed to join the game because the room is full.", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveLettersInfo(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void BMFDIAMGFJJ(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "[BouncerGender=", (RpcTarget)1, array);
	}

	public void EJONBLAKOOC(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "hForHours", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void GJBCOAAIPAP(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	private void GCKNEFBHMFD(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).MOEHLFOHLLO();
	}

	private void DEAEBDNPPFO(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).AELABIMHDNA();
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	public void OENKDMHJDGA(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Drag item:", (RpcTarget)0, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	public void GDKBDHKKFHL(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player2", (RpcTarget)1, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	private void LLEKNIAFOLF(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void NLPCCDCKOCM(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "TimeLeft", (RpcTarget)1, array);
	}

	public void GOCANFAOHCP(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "[GetAllValidCandidates] Total candidates found: {0}", (RpcTarget)0, array);
	}

	public void GMFIDBNJBJI(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "City/Hallmund/Bark/Bye", (RpcTarget)0, array);
	}

	public void LOBEBFIKMBF(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "\n", (RpcTarget)0, array);
	}

	private void HOOLJJHDOMF(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
	}

	private void IBEBHNKBNGJ(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).FMPHBFCJLLM();
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	public void NKOHLFMGOCH(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Honey", (RpcTarget)1, OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM));
	}

	private void NCCILFOJMPK(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).FJFEIIIIAMJ();
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	public void FHADIBIFOJO(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Open", (RpcTarget)0, array);
	}

	public void GIMNCEKJNPF(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "NormalRight", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveNewLetter(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void KDIMFHIOMLJ(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Cat with id ", (RpcTarget)0, array);
	}

	private void OHDDDAGOEAN(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).GMNEAMHNMPB();
	}

	private void HKIGOOLIAMC(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void JDFKPCAELEP(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).FOGLECFMPMK();
	}

	public void MGAECAEDIAD(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	private void MDDFMHDKBFG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void LKDHCIKIBJJ(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void DNGGDHGKBML(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Tools", (RpcTarget)1, array);
	}

	public void OKNBKFDEMFI(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_618", (RpcTarget)0, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void ODHBPODNFOK(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void PNGFAJFHOAH(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "\n", (RpcTarget)0, array);
	}

	private void FPIPKKDDBNL(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).AELABIMHDNA();
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
	}

	private void AGEDIDDABIG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void CFEBHJCPLAL(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
	}

	private void BHFHBKDAOED(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).OKPIDPELELJ();
	}

	public void SendDeletedLetterIndex(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDeletedLetterIndex", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void FBCONBJMFBD(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).AELABIMHDNA();
	}

	private void IDNEPPAKAEG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void HGFHMCPMCEI(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "alcoholContentWarning", (RpcTarget)0, array);
	}

	public void CBHCLHJDPNB(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Dead", (RpcTarget)0, array);
	}

	private void AMPAAKPAGID(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void CAOGKCKCMAN(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "LE_5", (RpcTarget)0, array);
	}

	private void LHONOLPDNLJ(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void DGBJJNAADCI()
	{
		instance = this;
	}

	private void FFOMPGLFKEM(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void BMBABBKBHII(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Inventory full", (RpcTarget)0, array);
	}

	private void ABNJAOKHIOP(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).CCLMONNMMCJ();
	}

	public void BLPKHHACDGB(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Left", (RpcTarget)1, array);
	}

	private void OHGKLHCECFD(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void KEKJCMPMOFN(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Moving", (RpcTarget)0, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void AGELAMLCINB()
	{
		instance = this;
	}

	private void IBKDMAOHDKP(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<LettersMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void DJBDBEFFEAO(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "CloseTitleScreen", (RpcTarget)1, array);
	}

	private void AJHFEOAJIHE(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).OKPIDPELELJ();
	}

	public void LDIHBEGHCGH(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Crafting speed", (RpcTarget)0, array);
	}

	private void PDIECJCKCOD()
	{
		instance = this;
	}

	private void FCHENKKGFGC(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).FJFEIIIIAMJ();
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public void KDJBPLPAODC(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[BouncerGender=", (RpcTarget)0, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	private void FKGOOPAAFFA(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).PFOHEFAMENI();
	}

	private void GOPPJFMAFJA(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).CCLMONNMMCJ();
	}

	public void JEHGCECHPBI(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "' to ", (RpcTarget)0, array);
	}

	private void JGHKLOFCHGN(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<NewLetterMessage>(OINICMNOLPK).OKPIDPELELJ();
	}

	public void DOMIJFCEFLM(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "[GenerateAltar] Candidate {0} pos:{1} distToPuzzle:{2:F1}", (RpcTarget)1, array);
	}

	public void GJICLDBGNCK(int MOFKEDGAOEE)
	{
		DeletedLetterMessage mOBFJEDPIPM = new DeletedLetterMessage(MOFKEDGAOEE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "StairsUp", (RpcTarget)0, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void PCDAKEAJMLD(PostBox.LetterSaveData EHBLKBBHMEE)
	{
		NewLetterMessage mOBFJEDPIPM = new NewLetterMessage(EHBLKBBHMEE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "<sprite name=\"ironBarIcon\">", (RpcTarget)0, array);
	}

	private void ALHDMKNKAPM(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).OAOACMPNMOK();
	}

	private void CLHLHPHHIAH(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DeletedLetterMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void EOGGIJLGIGA(PostBox.LetterSaveData[] HBNEBFKKKNE)
	{
		LettersMessage mOBFJEDPIPM = new LettersMessage(HBNEBFKKKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Sleep", (RpcTarget)1, array);
	}
}
