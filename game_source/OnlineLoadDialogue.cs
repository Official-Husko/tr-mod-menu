using System;
using System.Collections;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using PixelCrushers.DialogueSystem;

public class OnlineLoadDialogue : OnlineLoadBase
{
	[Serializable]
	public class LoadDialogueInfo : LoadMessageBase
	{
		[JsonProperty("1")]
		public short[] le;

		[JsonProperty("2")]
		public short tucanEgg;

		[JsonProperty("3")]
		public short gassCoctelQuest;

		[JsonProperty("4")]
		public short skeletonBird;

		[JsonProperty("5")]
		public short aceQuest;

		[JsonProperty("6")]
		public short haveGoldenTicket;

		[JsonProperty("7")]
		public short raraAvisDelivered;

		[JsonProperty("8")]
		public int aceNextQuest;

		[JsonProperty("9")]
		public bool henHouseTutorialDone;

		[JsonProperty("10")]
		public bool barnTutorialDone;

		[JsonProperty("11")]
		public int buzzBuildExit;

		[JsonProperty("12")]
		public short adoptQuest;

		[JsonProperty("13")]
		public bool cat;

		[JsonProperty("14")]
		public bool dog;

		[JsonProperty("15")]
		public short mainProgress;

		[JsonProperty("16")]
		public short brookProgress;

		[JsonProperty("17")]
		public short zuzzuProgress;

		[JsonProperty("18")]
		public short kentaProgress;

		[JsonProperty("19")]
		public short rinProgress;

		[JsonProperty("20")]
		public short learnPrecision;

		[JsonProperty("21")]
		public short learnBalance;

		[JsonProperty("22")]
		public short learnMettle;

		[JsonProperty("23")]
		public short mayaMinigames;

		[JsonProperty("24")]
		public int cliveProgress;

		[JsonProperty("25")]
		public int rochelleProgress;

		[JsonProperty("26")]
		public int ferroProgress;

		[JsonProperty("27")]
		public int mineState;

		[JsonProperty("28")]
		public int mineFloor;

		[JsonProperty("29")]
		public int buzzProgress;

		[JsonProperty("30")]
		public int farmReady;

		[JsonProperty("31")]
		public bool bomb;

		[JsonProperty("32")]
		public int bobProgress;

		public LoadDialogueInfo()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
			short[] array = new short[22];
			Result variable = DialogueLua.GetVariable("LE_1");
			array[0] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_2");
			array[1] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_3");
			array[2] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_4");
			array[3] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_5");
			array[4] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_6");
			array[5] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_7");
			array[6] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_8");
			array[7] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_9");
			array[8] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_10");
			array[9] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_11");
			array[10] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_12");
			array[11] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_13");
			array[12] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_14");
			array[13] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_15");
			array[14] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_16");
			array[15] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_17");
			array[16] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_18");
			array[17] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_19");
			array[18] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_20");
			array[19] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_21");
			array[20] = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LE_22");
			array[21] = (short)((Result)(ref variable)).asInt;
			le = array;
			variable = DialogueLua.GetVariable("TucanEgg");
			tucanEgg = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("Gass_CoctelQuest");
			gassCoctelQuest = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("SkeletonBird");
			skeletonBird = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("AceT_Quest");
			aceQuest = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("HaveGoldenTicket");
			haveGoldenTicket = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("RaraAvisDelivered");
			raraAvisDelivered = (short)((Result)(ref variable)).asInt;
			aceNextQuest = CommonReferences.GGFJGHHHEJC.aceNextQuest;
			variable = DialogueLua.GetVariable("HenHouseTutorialDone");
			henHouseTutorialDone = ((Result)(ref variable)).asBool;
			variable = DialogueLua.GetVariable("BarnTutorialDone");
			barnTutorialDone = ((Result)(ref variable)).asBool;
			variable = DialogueLua.GetVariable("BuzzBuildExit");
			buzzBuildExit = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("AdoptQuest");
			adoptQuest = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("Cat");
			cat = ((Result)(ref variable)).asBool;
			variable = DialogueLua.GetVariable("Dog");
			dog = ((Result)(ref variable)).asBool;
			variable = DialogueLua.GetVariable("MainProgress");
			mainProgress = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("BrookProgress");
			brookProgress = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("ZuzzuProgress");
			zuzzuProgress = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("KentaProgress");
			kentaProgress = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("RinProgress");
			rinProgress = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LearnPrecision");
			learnPrecision = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LearnBalance");
			learnBalance = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("LearnMettle");
			learnMettle = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("MayaMinigames");
			mayaMinigames = (short)((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("CliveProgress");
			cliveProgress = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("RochelleProgress");
			rochelleProgress = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("FerroProgress");
			ferroProgress = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("MineState");
			mineState = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("MineFloor");
			mineFloor = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("BuzzProgress");
			buzzProgress = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("FarmReady");
			farmReady = ((Result)(ref variable)).asInt;
			variable = DialogueLua.GetVariable("Bomb");
			bomb = ((Result)(ref variable)).asBool;
			variable = DialogueLua.GetVariable("BobProgress");
			bobProgress = ((Result)(ref variable)).asInt;
		}

		public override void OEJJGDMKIDN()
		{
			DialogueLua.SetVariable("LE_1", (object)le[0]);
			DialogueLua.SetVariable("LE_2", (object)le[1]);
			DialogueLua.SetVariable("LE_3", (object)le[2]);
			DialogueLua.SetVariable("LE_4", (object)le[3]);
			DialogueLua.SetVariable("LE_5", (object)le[4]);
			DialogueLua.SetVariable("LE_6", (object)le[5]);
			DialogueLua.SetVariable("LE_7", (object)le[6]);
			DialogueLua.SetVariable("LE_8", (object)le[7]);
			DialogueLua.SetVariable("LE_9", (object)le[8]);
			DialogueLua.SetVariable("LE_10", (object)le[9]);
			DialogueLua.SetVariable("LE_11", (object)le[10]);
			DialogueLua.SetVariable("LE_12", (object)le[11]);
			DialogueLua.SetVariable("LE_13", (object)le[12]);
			DialogueLua.SetVariable("LE_14", (object)le[13]);
			DialogueLua.SetVariable("LE_15", (object)le[14]);
			DialogueLua.SetVariable("LE_16", (object)le[15]);
			DialogueLua.SetVariable("LE_17", (object)le[16]);
			DialogueLua.SetVariable("LE_18", (object)le[17]);
			DialogueLua.SetVariable("LE_19", (object)le[18]);
			DialogueLua.SetVariable("LE_20", (object)le[19]);
			DialogueLua.SetVariable("LE_21", (object)le[20]);
			DialogueLua.SetVariable("LE_22", (object)le[21]);
			DialogueLua.SetVariable("TucanEgg", (object)tucanEgg);
			DialogueLua.SetVariable("SkeletonBird", (object)skeletonBird);
			DialogueLua.SetVariable("RaraAvisDelivered", (object)raraAvisDelivered);
			DialogueLua.SetVariable("Gass_CoctelQuest", (object)gassCoctelQuest);
			DialogueLua.SetVariable("AceT_Quest", (object)aceQuest);
			DialogueLua.SetVariable("HaveGoldenTicket", (object)haveGoldenTicket);
			CommonReferences.GGFJGHHHEJC.aceNextQuest = aceNextQuest;
			DialogueLua.SetVariable("HenHouseTutorialDone", (object)henHouseTutorialDone);
			DialogueLua.SetVariable("BarnTutorialDone", (object)barnTutorialDone);
			DialogueLua.SetVariable("BuzzBuildExit", (object)buzzBuildExit);
			DialogueLua.SetVariable("AdoptQuest", (object)adoptQuest);
			DialogueLua.SetVariable("Cat", (object)cat);
			DialogueLua.SetVariable("Dog", (object)dog);
			DialogueLua.SetVariable("MainProgress", (object)mainProgress);
			DialogueLua.SetVariable("BrookProgress", (object)brookProgress);
			DialogueLua.SetVariable("ZuzzuProgress", (object)zuzzuProgress);
			DialogueLua.SetVariable("KentaProgress", (object)kentaProgress);
			DialogueLua.SetVariable("RinProgress", (object)rinProgress);
			DialogueLua.SetVariable("LearnPrecision", (object)learnPrecision);
			DialogueLua.SetVariable("LearnBalance", (object)learnBalance);
			DialogueLua.SetVariable("LearnMettle", (object)learnMettle);
			DialogueLua.SetVariable("MayaMinigames", (object)mayaMinigames);
			DialogueLua.SetVariable("CliveProgress", (object)cliveProgress);
			DialogueLua.SetVariable("RochelleProgress", (object)rochelleProgress);
			DialogueLua.SetVariable("FerroProgress", (object)ferroProgress);
			DialogueLua.SetVariable("MineState", (object)mineState);
			DialogueLua.SetVariable("MineFloor", (object)mineFloor);
			DialogueLua.SetVariable("BuzzProgress", (object)buzzProgress);
			DialogueLua.SetVariable("FarmReady", (object)farmReady);
			DialogueLua.SetVariable("Bomb", (object)bomb);
			DialogueLua.SetVariable("BobProgress", (object)bobProgress);
		}
	}

	private void HGJNEILKLMF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void JNAAGDKPPHF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void FHPPKGCLBOB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void ABAEBHDGBBO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void GKIJNLMDPDC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void ECFNCHKFGEF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void KHLBBBNJLKC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void CMJJHCFPEJA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void KIGKHDPCALL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void JMFFEKPLDJE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void BIDDJIDCPAG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void GGIBIIMJKPG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void GFGOACFDJJE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void NDBGBIBMHBM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void EIDOLEMJNEE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void LFKADEEBCDM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void LPJKDCEBPID(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void NPKEPNGLIGP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void NFENBGAGBEC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void CCPKDHMIENJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void CNIBNLEBBFN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void IFDDDLEGOOF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void MPJFKHMBMIH(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void LJLHFPKGFKA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void AICNHGPLOMC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void GMKAJGKFFPP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void AHLKCDPNOKD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void JJNLMKBBOBF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void JHOKKBEPAJN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void OJHCJNIOIAC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void FFPIOHKKFKO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void LBIDFMCOAIO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void HKHDGKBKLPB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void OKKOMHJCNOI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void NHADPDLIILO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void JMAJLABAKGG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void HBEHIKBFDHF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void DAOJPLOMENK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		LoadDialogueInfo oKCOIHJLGCM = new LoadDialogueInfo();
		AHGEFIOOEBL("ReceiveDialogueInfoLoad", player, oKCOIHJLGCM, 0, KJOOOPJKLBB: true);
		yield return null;
	}

	[PunRPC]
	private void ReceiveDialogueInfoLoad(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void FJHHHOMNDMN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void FPELFCFIHOB(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void CIPMCDHKEJA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void JFHIPMDDCHF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void LGPBEIGKBJA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void KNELFGHDDHL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void CMGPNJADEML(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void EKHNKBLLMBP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void MHJJHIEIPJG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void KBMFOCCELNI(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void OJDELEPHDEJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void EACIKCDLKHP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void DFPLDCNGAKA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void FHALKDLOPPG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void HLPPPLPMCEP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}

	private void NMGKFPFKOIM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadDialogueInfo>(OINICMNOLPK);
	}
}
