using System;
using System.Collections;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using PixelCrushers.DialogueSystem;

public class OnlineLoadInventories : OnlineLoadBase
{
	[Serializable]
	public class LoadSlotsMessage : LoadMessageBase
	{
		[JsonProperty("1")]
		public SlotsMessage slotsOnline;

		public LoadSlotsMessage(Container ALPOKDOCCGM, int HDFBPKHPAKA = 0)
		{
			slotsOnline = SlotsMessage.MENBNCJDCEO(ALPOKDOCCGM.slots);
		}

		public override void OEJJGDMKIDN()
		{
			slotsOnline.KEBMLHKLFEF();
		}
	}

	public static OnlineLoadInventories instance;

	public void FLFOAJPBDGD(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MINEBGBPJMJ(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).GetAllSlots());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		array[0] = MHMDBOCFCII;
		OnlineManager.DBNIKCMHHMJ(photonView, "LE_21", player, array);
	}

	public void BGEPNCBEECN(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MINEBGBPJMJ(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).BBDOBNLMLGM());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		array[0] = MHMDBOCFCII;
		OnlineManager.DBNIKCMHHMJ(photonView, "\n", player, array);
	}

	private void IOMEOBOMKJK(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).OLNDEGFKHFB(0);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			DJEBOFOEKMJ();
		}
	}

	private void GDMFAALJCHJ(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(0);
		if (OnlineManager.ClientOnline() && !MHMDBOCFCII)
		{
			NCBKHLPHJJB();
		}
	}

	public void GiveToolsOnlinePlayer()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.GGFJGHHHEJC.allTools.Length; i++)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.JDJGFAACPFC() == 1440 || item.JDJGFAACPFC() == 1441)
			{
				Result variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt < 10)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt < 13 && item.JDJGFAACPFC() == 1441)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt >= 13 && item.JDJGFAACPFC() == 1440)
				{
					continue;
				}
			}
			if (!PlayerInventory.GetPlayer(1).HasItem(item.JDJGFAACPFC()))
			{
				PlayerInventory.GetPlayer(1).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void NKNAAEHNGDN(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).CJEJHJCPGAL(1);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			EOIALHACJCB();
		}
	}

	private void MCGPLGDFDCP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveLoadSlots(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	private void HFOGJJDPCMC(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(1);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			CBFBIAFPANN();
		}
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	public void OLMIIIMKKNA(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).FCGJCBJGOIG());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		array[0] = MHMDBOCFCII;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/EnterTavernDrink/Entry/1/Dialogue Text", player, array);
	}

	private void AOJPBAADEDI(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).CJEJHJCPGAL(1);
		if (OnlineManager.ClientOnline() && !MHMDBOCFCII)
		{
			DACAFAIADCH();
		}
	}

	private void PAMLDCCLNLF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	private void Awake()
	{
		instance = this;
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	public void PJOCFMKKPHJ(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).OMCMMDDGHFB());
		OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "Triangle", player, new object[8]
		{
			OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM),
			MHMDBOCFCII,
			null,
			null,
			null,
			null,
			null,
			null
		});
	}

	private void OPADNLLPDGI(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).OLNDEGFKHFB(0);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			DJEBOFOEKMJ();
		}
	}

	private void GKMCCGMEHAJ(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).KLHIDKCOPME(0);
		if (OnlineManager.ClientOnline() && !MHMDBOCFCII)
		{
			CBFBIAFPANN();
		}
	}

	public void PEBICFCEPOO(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MINEBGBPJMJ(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).OMCMMDDGHFB());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		array[1] = MHMDBOCFCII;
		OnlineManager.DBNIKCMHHMJ(photonView, "chatx", player, array);
	}

	private void ENFPGDGJEPN(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(1);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			DACAFAIADCH();
		}
	}

	public void EOIALHACJCB()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.NJNFHEPLEHL().allTools.Length; i += 0)
		{
			Item item = GameManager.NJNFHEPLEHL().allTools[i];
			if (item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -3 || item.IMCJPECAAPC(DAINLFIMLIH: false) == -53)
			{
				Result variable = DialogueLua.GetVariable("Items/item_name_1109");
				if (((Result)(ref variable)).asInt < -9)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Player");
				if (((Result)(ref variable)).asInt < 35 && item.JPNFKDMFKMC(DAINLFIMLIH: false) == 107)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Disabled");
				if (((Result)(ref variable)).asInt >= 78 && item.CIGFGKKCPCK() == 74)
				{
					continue;
				}
			}
			if (!PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).HasItem(item.ODENMDOJPLC(DAINLFIMLIH: false)))
			{
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	public void DACAFAIADCH()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GameManager.GGFJGHHHEJC.allTools.Length; i += 0)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.CIGFGKKCPCK(DAINLFIMLIH: false) == -102 || item.CIGFGKKCPCK(DAINLFIMLIH: false) == 153)
			{
				Result variable = DialogueLua.GetVariable(". Time since startup: ");
				if (((Result)(ref variable)).asInt < -116)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Player");
				if (((Result)(ref variable)).asInt < -57 && item.CIGFGKKCPCK() == -175)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Income");
				if (((Result)(ref variable)).asInt >= 37 && item.ODENMDOJPLC() == -115)
				{
					continue;
				}
			}
			if (!PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(item.IMCJPECAAPC()))
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(item.JMDALJBNFML());
			}
		}
	}

	private void IOHEBCPLOJD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	private void COHHNDFEILC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	public void IJAMMDHOIGC(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).FCGJCBJGOIG());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		array[1] = MHMDBOCFCII;
		OnlineManager.DBNIKCMHHMJ(photonView, "Chat input cancelled", player, array);
	}

	public void CBFBIAFPANN()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.GGFJGHHHEJC.allTools.Length; i++)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.ODENMDOJPLC() == 90 || item.JPNFKDMFKMC() == 40)
			{
				Result variable = DialogueLua.GetVariable("Feed");
				if (((Result)(ref variable)).asInt < -66)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("ReceiveStackContainer");
				if (((Result)(ref variable)).asInt < -121 && item.IMCJPECAAPC() == -198)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Month");
				if (((Result)(ref variable)).asInt >= 42 && item.JPNFKDMFKMC(DAINLFIMLIH: false) == -9)
				{
					continue;
				}
			}
			if (!PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(item.JPNFKDMFKMC(DAINLFIMLIH: false)))
			{
				PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).OJDGOADOCMG(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
		}
	}

	public void MBBMCNKKCNC(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).BBDOBNLMLGM());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		array[1] = MHMDBOCFCII;
		OnlineManager.SendRPC(photonView, ":<color=#3a0603> +", player, array);
	}

	public void IGCDIPFBLON(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MINEBGBPJMJ(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).GetAllSlots());
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "_", player, OnlineSerializer.Serialize(mOBFJEDPIPM), MHMDBOCFCII);
	}

	public void GFMCAIJNCOP()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GameManager.NJNFHEPLEHL().allTools.Length; i += 0)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.JDJGFAACPFC(DAINLFIMLIH: false) == -166 || item.CIGFGKKCPCK() == -13)
			{
				Result variable = DialogueLua.GetVariable("Direction");
				if (((Result)(ref variable)).asInt < 11)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("in ");
				if (((Result)(ref variable)).asInt < -63 && item.JGHNDJBCFAJ() == -131)
				{
					continue;
				}
				variable = DialogueLua.GetVariable(" has null in variant objects list.");
				if (((Result)(ref variable)).asInt >= 45 && item.CIGFGKKCPCK(DAINLFIMLIH: false) == -63)
				{
					continue;
				}
			}
			if (!PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(item.JPNFKDMFKMC()))
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
		}
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	public void NPHANGEBJJL()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.GGFJGHHHEJC.allTools.Length; i++)
		{
			Item item = GameManager.NJNFHEPLEHL().allTools[i];
			if (item.CIGFGKKCPCK(DAINLFIMLIH: false) == 150 || item.IMCJPECAAPC(DAINLFIMLIH: false) == 113)
			{
				Result variable = DialogueLua.GetVariable("repUnlockUpgrades");
				if (((Result)(ref variable)).asInt < 122)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Angry");
				if (((Result)(ref variable)).asInt < 94 && item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 182)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Direction");
				if (((Result)(ref variable)).asInt >= 63 && item.JGHNDJBCFAJ() == 181)
				{
					continue;
				}
			}
			if (!PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(item.JDJGFAACPFC(DAINLFIMLIH: false)))
			{
				PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			}
		}
	}

	public void IPKHACPEAAH()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.NJNFHEPLEHL().allTools.Length; i++)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.JDJGFAACPFC(DAINLFIMLIH: false) == -9 || item.JPNFKDMFKMC(DAINLFIMLIH: false) == 119)
			{
				Result variable = DialogueLua.GetVariable("Pet");
				if (((Result)(ref variable)).asInt < 54)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Player2");
				if (((Result)(ref variable)).asInt < 68 && item.ODENMDOJPLC(DAINLFIMLIH: false) == 99)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Club");
				if (((Result)(ref variable)).asInt >= -51 && item.JDJGFAACPFC(DAINLFIMLIH: false) == 152)
				{
					continue;
				}
			}
			if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(item.CIGFGKKCPCK()))
			{
				PlayerInventory.NEKDDPIAOBE(1).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	private void LDGJBCHODAM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}

	public void SendInventoryToChest(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).GetAllSlots());
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInventoryToChest", player, OnlineSerializer.Serialize(mOBFJEDPIPM), MHMDBOCFCII);
	}

	private void LFAFDAMJNPE(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(0);
		if (OnlineManager.ClientOnline() && !MHMDBOCFCII)
		{
			DJEBOFOEKMJ();
		}
	}

	private void DADPOICMNPI()
	{
		instance = this;
	}

	private void NNMPGMGBMPO(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).CJEJHJCPGAL(1);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			IPKHACPEAAH();
		}
	}

	private void PKLPDBDEDEK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	public void OJHEEGINOPJ()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GameManager.NJNFHEPLEHL().allTools.Length; i++)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.JDJGFAACPFC(DAINLFIMLIH: false) == 17 || item.CIGFGKKCPCK(DAINLFIMLIH: false) == -3)
			{
				Result variable = DialogueLua.GetVariable("ZoneFirewood");
				if (((Result)(ref variable)).asInt < -126)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("tutorialPopUp28");
				if (((Result)(ref variable)).asInt < 97 && item.ODENMDOJPLC() == 140)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Barrel");
				if (((Result)(ref variable)).asInt >= -90 && item.IMCJPECAAPC(DAINLFIMLIH: false) == 92)
				{
					continue;
				}
			}
			if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(item.JPNFKDMFKMC()))
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			}
		}
	}

	public void EEEOHBDKEAF()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.GGFJGHHHEJC.allTools.Length; i += 0)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.CIGFGKKCPCK() == 4 || item.IMCJPECAAPC(DAINLFIMLIH: false) == -198)
			{
				Result variable = DialogueLua.GetVariable("Halloween/Trick/Bark");
				if (((Result)(ref variable)).asInt < 3)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Output is not ready");
				if (((Result)(ref variable)).asInt < 36 && item.CIGFGKKCPCK() == 92)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("LoadGameplaySceneOnline IsMasterClient ");
				if (((Result)(ref variable)).asInt >= -114 && item.ODENMDOJPLC() == -188)
				{
					continue;
				}
			}
			if (!PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(item.IMCJPECAAPC(DAINLFIMLIH: false)))
			{
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
		}
	}

	public void DJEBOFOEKMJ()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < GameManager.GGFJGHHHEJC.allTools.Length; i++)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.ODENMDOJPLC(DAINLFIMLIH: false) == -47 || item.JPNFKDMFKMC(DAINLFIMLIH: false) == -155)
			{
				Result variable = DialogueLua.GetVariable("Attack/MainEvent 10");
				if (((Result)(ref variable)).asInt < 38)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Low");
				if (((Result)(ref variable)).asInt < 110 && item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -140)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Items/item_description_1065");
				if (((Result)(ref variable)).asInt >= -49 && item.JPNFKDMFKMC(DAINLFIMLIH: false) == 181)
				{
					continue;
				}
			}
			if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).HasItem(item.JPNFKDMFKMC()))
			{
				PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).AddItem(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		int numMessages = 0;
		LoadSlotsMessage oKCOIHJLGCM = new LoadSlotsMessage(BarMenuInventory.GetInstance());
		AHGEFIOOEBL("ReceiveLoadSlots", targetPlayer, oKCOIHJLGCM, numMessages++);
		yield return null;
		oKCOIHJLGCM = new LoadSlotsMessage(BuildingInventory.GetInstance());
		AHGEFIOOEBL("ReceiveLoadSlots", targetPlayer, oKCOIHJLGCM, numMessages++);
		yield return null;
		oKCOIHJLGCM = new LoadSlotsMessage(Bin.instance, Bin.instance.EAPCLAODGAE.BEIPALOAAJJ);
		AHGEFIOOEBL("ReceiveLoadSlots", targetPlayer, oKCOIHJLGCM, numMessages++);
		yield return null;
		oKCOIHJLGCM = new LoadSlotsMessage(DeliveryChest.GetInstance(), DeliveryChest.GetInstance().EAPCLAODGAE.BEIPALOAAJJ);
		AHGEFIOOEBL("ReceiveLoadSlots", targetPlayer, oKCOIHJLGCM, numMessages, KJOOOPJKLBB: true);
	}

	public void GAJPBOKCFON(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.CPMJMBLCIMK(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).BBDOBNLMLGM());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		array[1] = MHMDBOCFCII;
		OnlineManager.DBNIKCMHHMJ(photonView, "Exit build mode", player, array);
	}

	private void OFLIKJDLAPC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	public void NOPICDLLMEA(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).GetAllSlots());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		array[1] = MHMDBOCFCII;
		OnlineManager.SendRPC(photonView, "BuzzProgress", player, array);
	}

	public void FNINJBPBGGF(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.CPMJMBLCIMK(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).GetAllSlots());
		OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "port", player, new object[4]
		{
			OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM),
			MHMDBOCFCII,
			null,
			null
		});
	}

	public void EELHGAEPGHC(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MINEBGBPJMJ(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).FCGJCBJGOIG());
		OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "increase reputation", player, new object[5]
		{
			OnlineSerializer.Serialize(mOBFJEDPIPM),
			MHMDBOCFCII,
			null,
			null,
			null
		});
	}

	private void HFFBJMGKFFK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveInventoryToChest(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(1);
		if (OnlineManager.ClientOnline() && !MHMDBOCFCII)
		{
			GiveToolsOnlinePlayer();
		}
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	public void OMBBPOHMJAG(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).BBDOBNLMLGM());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		array[0] = MHMDBOCFCII;
		OnlineManager.SendRPC(photonView, "Get Components ", player, array);
	}

	private void GGALAHDALKO(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).CJEJHJCPGAL(0);
		if (OnlineManager.ClientOnline() && !MHMDBOCFCII)
		{
			EEEOHBDKEAF();
		}
	}

	public void NCBKHLPHJJB()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GameManager.NJNFHEPLEHL().allTools.Length; i += 0)
		{
			Item item = GameManager.GGFJGHHHEJC.allTools[i];
			if (item.ODENMDOJPLC(DAINLFIMLIH: false) == 192 || item.CIGFGKKCPCK() == -189)
			{
				Result variable = DialogueLua.GetVariable("Community_Translation");
				if (((Result)(ref variable)).asInt < 63)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("Animal");
				if (((Result)(ref variable)).asInt < -92 && item.CIGFGKKCPCK(DAINLFIMLIH: false) == 147)
				{
					continue;
				}
				variable = DialogueLua.GetVariable("GoHome");
				if (((Result)(ref variable)).asInt >= -35 && item.CIGFGKKCPCK() == -27)
				{
					continue;
				}
			}
			if (!PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HasItem(item.IMCJPECAAPC(DAINLFIMLIH: false)))
			{
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(item.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
		}
	}

	private void BNJKIHDAKNB(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(1);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			DACAFAIADCH();
		}
	}

	private void EEDEJLPNPEG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	private void BILDINMDPNN(byte[] OINICMNOLPK, bool MHMDBOCFCII)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(1);
		if (OnlineManager.HHDBMDMFEMP() && !MHMDBOCFCII)
		{
			CBFBIAFPANN();
		}
	}

	private void LJNPIHAHKIL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadSlotsMessage>(OINICMNOLPK);
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	public void NDJNBNJHHHN(int JJPJHIHBOIB, bool MHMDBOCFCII)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(PlayerInventory.GetPlayerOnlineWithActor(JJPJHIHBOIB).OMCMMDDGHFB());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		array[0] = MHMDBOCFCII;
		OnlineManager.SendRPC(photonView, "WaitIntro", player, array);
	}
}
