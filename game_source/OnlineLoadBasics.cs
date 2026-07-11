using System.Collections;
using Newtonsoft.Json;
using Photon.Pun;
using UnityEngine;

public class OnlineLoadBasics : OnlineLoadBase
{
	public class LoadBasicsInfoSerialized : LoadMessageBase
	{
		[JsonProperty("1")]
		public Vector2 travelZoneTavernToRoadPosition;

		[JsonProperty("2")]
		public double realGameTimeSeconds;

		[JsonProperty("3")]
		public GameDateMessage currentTime;

		[JsonProperty("4")]
		public short weatherType;

		[JsonProperty("5")]
		public bool christmasTreeQuestDone;

		[JsonProperty("6")]
		public bool christmasTree2022QuestDone;

		[JsonProperty("7")]
		public bool christmasTree2023QuestDone;

		[JsonProperty("8")]
		public bool christmasTree2024QuestDone;

		[JsonProperty("9")]
		public bool[] presents2022Opened;

		[JsonProperty("10")]
		public bool present2023Opened;

		[JsonProperty("11")]
		public bool[] presents2024Opened;

		[JsonProperty("31")]
		public bool christmasTree2025QuestDone;

		[JsonProperty("32")]
		public bool[] presents2025Opened;

		[JsonProperty("12")]
		public byte milestoneMaster;

		[JsonProperty("13")]
		public string tavernName;

		[JsonProperty("14")]
		public int moneyCopper;

		[JsonProperty("15")]
		public int wilsonDecorativeObjects;

		[JsonProperty("16")]
		public int farmModeOpenedByOtherPlayer;

		[JsonProperty("17")]
		public short[] actorsBedAssigned = new short[5];

		[JsonProperty("18")]
		public int[] actorsSelectionUniqueId;

		[JsonProperty("19")]
		public bool cityCustomersActive;

		[JsonProperty("20")]
		public int[] cityCustomersIndex;

		[JsonProperty("21")]
		public int cityCustomersNumToActivate;

		[JsonProperty("22")]
		public bool tutorialEnabled;

		[JsonProperty("23")]
		public bool buildingTutorialDone;

		[JsonProperty("24")]
		public int[] commonReferenceEvent;

		[JsonProperty("25")]
		public int adoption;

		[JsonProperty("26")]
		public bool sawmillRepaired;

		[JsonProperty("27")]
		public bool stoneWorkstationRepaired;

		[JsonProperty("28")]
		public bool smelterRepaired;

		[JsonProperty("29")]
		public bool stumpRepaired;

		[JsonProperty("30")]
		public bool blacksmithsTableRepaired;

		[JsonProperty("33")]
		public int toolUpgradeId;

		[JsonProperty("34")]
		public bool toolUpgradeCanCollect;

		private void PPFPPNENEHB()
		{
			currentTime = new GameDateMessage(WorldTime.NOAOJJLNHJJ);
			realGameTimeSeconds = WorldTime.JBMDLCMNNHD;
			weatherType = (short)Weather.currentWeather;
		}

		private void JPFKFJEJPNA()
		{
			tavernName = PlayerInfo.tavernName;
		}

		private void HDOGCMMEBCG()
		{
			wilsonDecorativeObjects = (short)ShopDatabaseAccessor.wilsonDecorativeObjects;
		}

		private void CIOAKIFLPGK()
		{
			Crafter.sawmillRepaired = sawmillRepaired;
			Crafter.stoneWorkstationRepaired = stoneWorkstationRepaired;
			Crafter.stumpRepaired = stumpRepaired;
			Crafter.smelterRepaired = smelterRepaired;
			Crafter.blacksmithsTableRepaired = blacksmithsTableRepaired;
		}

		private void LGDJPDKGCLP()
		{
			commonReferenceEvent = CommonReferences.MNFMOEKMJKN().eventNum;
		}

		private void COPKFOOPNPF()
		{
			if (toolUpgradeId != 0)
			{
				if (toolUpgradeCanCollect)
				{
					ToolUpgradeManager.instance.item = ItemDatabaseAccessor.COEFFIHKMJG(toolUpgradeId);
					ToolUpgradeManager.instance.canCollect = toolUpgradeCanCollect;
				}
				else
				{
					ToolUpgradeManager.instance.FOPEFIMNBIA(ItemDatabaseAccessor.KMBGJEKCJFJ(toolUpgradeId, GGBBJNBBLMF: true, DAINLFIMLIH: false));
				}
			}
		}

		private void JKFGPEEBKKP()
		{
			milestoneMaster = (byte)TavernReputation.GetMilestoneMaster();
		}

		private void BBFEIBBPHHF()
		{
			christmasTreeQuestDone = ChristmasEvent.EEIJGHIKANA(-2);
			christmasTree2022QuestDone = ChristmasEvent.IsTreeQuestDone(-73);
			presents2022Opened = ChristmasEvent.LAIECHCFPGC(137);
			christmasTree2023QuestDone = ChristmasEvent.FFDPNFBHNIK(57);
			present2023Opened = ChristmasEvent.LAIECHCFPGC(43)[1];
			christmasTree2024QuestDone = ChristmasEvent.IsTreeQuestDone(7);
			presents2024Opened = ChristmasEvent.GetPresentsOpened(-52);
			christmasTree2025QuestDone = ChristmasEvent.EEIJGHIKANA(-74);
			presents2025Opened = ChristmasEvent.ICFABGNIKIG(5);
		}

		private void OGLNJMMFAGP()
		{
			CommonReferences.MNFMOEKMJKN().eventNum = commonReferenceEvent;
		}

		private void FONBFKEJJHL()
		{
			sawmillRepaired = Crafter.sawmillRepaired;
			stoneWorkstationRepaired = Crafter.stoneWorkstationRepaired;
			stumpRepaired = Crafter.stumpRepaired;
			smelterRepaired = Crafter.smelterRepaired;
			blacksmithsTableRepaired = Crafter.blacksmithsTableRepaired;
		}

		private void FGDKPLNLIKK()
		{
			AdoptionSignalManager.GetInstance().adoption = adoption;
		}

		public LoadBasicsInfoSerialized()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			if (Object.op_Implicit((Object)(object)TravelZonesManager.GGFJGHHHEJC))
			{
				travelZoneTavernToRoadPosition = Vector2.op_Implicit(((Component)TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road)).transform.position);
			}
			PPFPPNENEHB();
			HFNLPJOAJLO();
			JKFGPEEBKKP();
			ECIFNFMAOFB();
			HDOGCMMEBCG();
			NPABKLJGEIK();
			AEODACLNHCB();
			FFJLMAECDDL();
			OHLOKMPOGKO();
			MIEPJAEPNMF();
			HCBGNLGMJDB();
			for (int i = 1; i < actorsBedAssigned.Length; i++)
			{
				int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(i);
				if (actorNumberByBedAssigned != 0)
				{
					actorsBedAssigned[i] = (short)actorNumberByBedAssigned;
				}
			}
			actorsSelectionUniqueId = OnlineObjectsManager.instance.playersUsingObject;
			cityCustomersActive = CityCustomersController.instance.active;
			cityCustomersIndex = CityCustomersController.instance.tempIndex;
			cityCustomersNumToActivate = CityCustomersController.instance.numberToActivate;
			tutorialEnabled = TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD;
			buildingTutorialDone = BuildingTutorialManager.instance.BPDDCBHKCME;
		}

		private void JEKFLLDDHLG()
		{
			adoption = AdoptionSignalManager.HHGEEDCALHK().adoption;
		}

		private void GKAKHHCNFMD()
		{
			sawmillRepaired = Crafter.sawmillRepaired;
			stoneWorkstationRepaired = Crafter.stoneWorkstationRepaired;
			stumpRepaired = Crafter.stumpRepaired;
			smelterRepaired = Crafter.smelterRepaired;
			blacksmithsTableRepaired = Crafter.blacksmithsTableRepaired;
		}

		private void LLKKGPIILFH()
		{
			WorldTime.ENPNPHKDGPB(realGameTimeSeconds);
			WorldTime.LKEPKFBGKOH(currentTime.KLGFAFDELJB());
			WorldTime.EMJLJOIEEDI();
			Weather.currentWeather = (Weather.WeatherType)weatherType;
			Weather.FJCOKGGBBNG();
		}

		private void HHPNGOABLNI()
		{
			currentTime = new GameDateMessage(WorldTime.HGIBNMBJMOC());
			realGameTimeSeconds = WorldTime.LLBLKNAFIFH();
			weatherType = (short)Weather.currentWeather;
		}

		private void OEBCHBCBLIB()
		{
			OnlineReputationManager.instance.milestoneMaster = milestoneMaster;
		}

		private void AOKGODDCIPI()
		{
			currentTime = new GameDateMessage(WorldTime.HGIBNMBJMOC());
			realGameTimeSeconds = WorldTime.LLBLKNAFIFH();
			weatherType = (short)Weather.currentWeather;
		}

		private void MFHCPFNCENH()
		{
			if (Item.FKLOBGBIHLB(ToolUpgradeManager.instance.item, null))
			{
				toolUpgradeId = ToolUpgradeManager.instance.item.CIGFGKKCPCK();
				toolUpgradeCanCollect = ToolUpgradeManager.instance.canCollect;
			}
		}

		private void HCBGNLGMJDB()
		{
			if (Item.MLBOMGHINCA(ToolUpgradeManager.instance.item, null))
			{
				toolUpgradeId = ToolUpgradeManager.instance.item.JDJGFAACPFC();
				toolUpgradeCanCollect = ToolUpgradeManager.instance.canCollect;
			}
		}

		private void AJHMONAELLH()
		{
			ChristmasEvent.DEFBHHGPPMC(17, christmasTreeQuestDone);
			ChristmasEvent.SetTreeQuestDone(52, christmasTree2022QuestDone);
			ChristmasEvent.DEFBHHGPPMC(-188, christmasTree2023QuestDone);
			ChristmasEvent.DEFBHHGPPMC(-118, christmasTree2024QuestDone);
			ChristmasEvent.PPGKCFFLKJL(10, christmasTree2025QuestDone);
			if (presents2022Opened != null)
			{
				ChristmasEvent.ILEDAPEHPMJ(-4, presents2022Opened);
			}
			bool[] array = new bool[0];
			array[1] = present2023Opened;
			ChristmasEvent.IDBPIHJHNMA(-130, array);
			if (presents2024Opened != null)
			{
				ChristmasEvent.EDODINDEHEN(-46, presents2024Opened);
			}
			if (presents2025Opened != null)
			{
				ChristmasEvent.SetPresentsOpened(3, presents2025Opened);
			}
		}

		private void MPMIAGCDAKN()
		{
			if (toolUpgradeId != 0)
			{
				if (toolUpgradeCanCollect)
				{
					ToolUpgradeManager.instance.item = ItemDatabaseAccessor.GetItem(toolUpgradeId);
					ToolUpgradeManager.instance.canCollect = toolUpgradeCanCollect;
				}
				else
				{
					ToolUpgradeManager.instance.UpgradeTool(ItemDatabaseAccessor.GetItem(toolUpgradeId));
				}
			}
		}

		private void MKIGJGHMHAN()
		{
			OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer = farmModeOpenedByOtherPlayer;
			if (farmModeOpenedByOtherPlayer > 1)
			{
				FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
			}
		}

		private void MAFJHPBEDAI()
		{
			moneyCopper = Money.IGMJLMMADAJ().AOLOLBLLMJN();
		}

		private void NHMACDAMAMJ()
		{
			if (Item.FKLOBGBIHLB(ToolUpgradeManager.instance.item, null))
			{
				toolUpgradeId = ToolUpgradeManager.instance.item.IMCJPECAAPC(DAINLFIMLIH: false);
				toolUpgradeCanCollect = ToolUpgradeManager.instance.canCollect;
			}
		}

		private void JNBNDHNOBFD()
		{
			wilsonDecorativeObjects = (short)ShopDatabaseAccessor.wilsonDecorativeObjects;
		}

		private void AEODACLNHCB()
		{
			farmModeOpenedByOtherPlayer = OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer;
		}

		private void JBPLNGDEMLO()
		{
			adoption = AdoptionSignalManager.MGAHKMKEOFJ().adoption;
		}

		private void JCGDOKHNCJB()
		{
			farmModeOpenedByOtherPlayer = OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer;
		}

		private void EEOICOBEOCF()
		{
			OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer = farmModeOpenedByOtherPlayer;
			if (farmModeOpenedByOtherPlayer > 1)
			{
				FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
			}
		}

		private void EEPFNOIGBGH()
		{
			Crafter.sawmillRepaired = sawmillRepaired;
			Crafter.stoneWorkstationRepaired = stoneWorkstationRepaired;
			Crafter.stumpRepaired = stumpRepaired;
			Crafter.smelterRepaired = smelterRepaired;
			Crafter.blacksmithsTableRepaired = blacksmithsTableRepaired;
		}

		private void FEDIOBFGHHK()
		{
			WorldTime.JBMDLCMNNHD = realGameTimeSeconds;
			WorldTime.NOAOJJLNHJJ = currentTime.JBJLBDHAECK();
			WorldTime.CalcCurrentDayTimeSec();
			Weather.currentWeather = (Weather.WeatherType)weatherType;
			Weather.CheckAllWeather();
		}

		private void GPGLLDNKMAO()
		{
			if (toolUpgradeId != 0)
			{
				if (toolUpgradeCanCollect)
				{
					ToolUpgradeManager.instance.item = ItemDatabaseAccessor.COEFFIHKMJG(toolUpgradeId, GGBBJNBBLMF: false, DAINLFIMLIH: false);
					ToolUpgradeManager.instance.canCollect = toolUpgradeCanCollect;
				}
				else
				{
					ToolUpgradeManager.instance.IDDEEICFIPD(ItemDatabaseAccessor.COEFFIHKMJG(toolUpgradeId, GGBBJNBBLMF: true, DAINLFIMLIH: false), CDPAMNIPPEC: true);
				}
			}
		}

		private void LFJAJJOEDMP()
		{
			PlayerInfo.tavernName = tavernName;
		}

		private void GIFGCBDHKCH()
		{
			OnlineReputationManager.instance.milestoneMaster = milestoneMaster;
		}

		private void JMHCJHPBFLM()
		{
			ShopDatabaseAccessor.wilsonDecorativeObjects = wilsonDecorativeObjects;
		}

		private void DFFHKOCKCII()
		{
			ShopDatabaseAccessor.wilsonDecorativeObjects = wilsonDecorativeObjects;
		}

		private void FBCKNPOBOPD()
		{
			milestoneMaster = (byte)TavernReputation.IHGJJNNHNCB();
		}

		private void MIEPJAEPNMF()
		{
			sawmillRepaired = Crafter.sawmillRepaired;
			stoneWorkstationRepaired = Crafter.stoneWorkstationRepaired;
			stumpRepaired = Crafter.stumpRepaired;
			smelterRepaired = Crafter.smelterRepaired;
			blacksmithsTableRepaired = Crafter.blacksmithsTableRepaired;
		}

		private void PFIOHIFFBGB()
		{
			currentTime = new GameDateMessage(WorldTime.NOAOJJLNHJJ);
			realGameTimeSeconds = WorldTime.ELFDEFOCEFP();
			weatherType = (short)Weather.currentWeather;
		}

		private void MNLOMFAAMDM()
		{
			christmasTreeQuestDone = ChristmasEvent.IsTreeQuestDone(193);
			christmasTree2022QuestDone = ChristmasEvent.IsTreeQuestDone(-191);
			presents2022Opened = ChristmasEvent.LAIECHCFPGC(-146);
			christmasTree2023QuestDone = ChristmasEvent.FFDPNFBHNIK(68);
			present2023Opened = ChristmasEvent.LAIECHCFPGC(193)[1];
			christmasTree2024QuestDone = ChristmasEvent.JOIHPFMGMOG(117);
			presents2024Opened = ChristmasEvent.ICFABGNIKIG(91);
			christmasTree2025QuestDone = ChristmasEvent.FFDPNFBHNIK(41);
			presents2025Opened = ChristmasEvent.ICFABGNIKIG(-83);
		}

		private void OHLOKMPOGKO()
		{
			adoption = AdoptionSignalManager.GetInstance().adoption;
		}

		private void HKDNBHEBCMD()
		{
			if (toolUpgradeId != 0)
			{
				if (toolUpgradeCanCollect)
				{
					ToolUpgradeManager.instance.item = ItemDatabaseAccessor.INJBNHPGCIJ(toolUpgradeId);
					ToolUpgradeManager.instance.canCollect = toolUpgradeCanCollect;
				}
				else
				{
					ToolUpgradeManager.instance.GPHJFILEJHP(ItemDatabaseAccessor.CPMMBEPEJLO(toolUpgradeId), CDPAMNIPPEC: true);
				}
			}
		}

		public override void OEJJGDMKIDN()
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Tavern, Location.Road).ChangePosition(Vector2.op_Implicit(travelZoneTavernToRoadPosition));
			FEDIOBFGHHK();
			BAOJEIDFHLE();
			NFKLCAAIKLK();
			NANECHGFKJB();
			DFFHKOCKCII();
			LFJAJJOEDMP();
			POPEGFHOJJH();
			HMEFOMIGOAF();
			FGDKPLNLIKK();
			EEPFNOIGBGH();
			MPMIAGCDAKN();
			for (int i = 1; i < actorsBedAssigned.Length; i++)
			{
				if (actorsBedAssigned[i] != 0)
				{
					OnlinePlayerDataManager.AddActorBedAssigned(actorsBedAssigned[i], i, HLHAICFGNGP: false);
				}
			}
			OnlinePlayerDataManager.instance.OnActorBedAssigned();
			OnlineObjectsManager.instance.playersUsingObject = actorsSelectionUniqueId;
			if (cityCustomersActive)
			{
				CityCustomersController.instance.ActivateCustomers(cityCustomersNumToActivate, cityCustomersIndex);
			}
			TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD = tutorialEnabled;
			BuildingTutorialManager.instance.BPDDCBHKCME = buildingTutorialDone;
		}

		private void FAANFHOKPFF()
		{
			currentTime = new GameDateMessage(WorldTime.HGIBNMBJMOC());
			realGameTimeSeconds = WorldTime.GKFHKJGALEL();
			weatherType = (short)Weather.currentWeather;
		}

		private void HMEFOMIGOAF()
		{
			CommonReferences.GGFJGHHHEJC.eventNum = commonReferenceEvent;
		}

		private void ACBJMCCOODN()
		{
			sawmillRepaired = Crafter.sawmillRepaired;
			stoneWorkstationRepaired = Crafter.stoneWorkstationRepaired;
			stumpRepaired = Crafter.stumpRepaired;
			smelterRepaired = Crafter.smelterRepaired;
			blacksmithsTableRepaired = Crafter.blacksmithsTableRepaired;
		}

		private void FFGEKKDFLDJ()
		{
			moneyCopper = Money.OGNEAEMNLLD().BNCMDNFMECD();
		}

		private void OOMHHNDJOBO()
		{
			AdoptionSignalManager.NOEBLLHOEOP().adoption = adoption;
		}

		private void AHKKCFIGFHH()
		{
			wilsonDecorativeObjects = (short)ShopDatabaseAccessor.wilsonDecorativeObjects;
		}

		private void FLOEBFFIBAO()
		{
			Crafter.sawmillRepaired = sawmillRepaired;
			Crafter.stoneWorkstationRepaired = stoneWorkstationRepaired;
			Crafter.stumpRepaired = stumpRepaired;
			Crafter.smelterRepaired = smelterRepaired;
			Crafter.blacksmithsTableRepaired = blacksmithsTableRepaired;
		}

		private void DJEAIAFMDMJ()
		{
			sawmillRepaired = Crafter.sawmillRepaired;
			stoneWorkstationRepaired = Crafter.stoneWorkstationRepaired;
			stumpRepaired = Crafter.stumpRepaired;
			smelterRepaired = Crafter.smelterRepaired;
			blacksmithsTableRepaired = Crafter.blacksmithsTableRepaired;
		}

		private void OJKKIJJBOCH()
		{
			adoption = AdoptionSignalManager.NOEBLLHOEOP().adoption;
		}

		private void LMBEPJCNDKN()
		{
			milestoneMaster = (byte)TavernReputation.GetMilestoneMaster();
		}

		private void GNIPJLDBGPE()
		{
			sawmillRepaired = Crafter.sawmillRepaired;
			stoneWorkstationRepaired = Crafter.stoneWorkstationRepaired;
			stumpRepaired = Crafter.stumpRepaired;
			smelterRepaired = Crafter.smelterRepaired;
			blacksmithsTableRepaired = Crafter.blacksmithsTableRepaired;
		}

		private void NHDCMLNMMKP()
		{
			WorldTime.ENPNPHKDGPB(realGameTimeSeconds);
			WorldTime.OFHDFEONCOL(currentTime.CGDNCJIAHHG());
			WorldTime.GMAPCOKNNAI();
			Weather.currentWeather = (Weather.WeatherType)weatherType;
			Weather.HKKKECDNPHB();
		}

		private void HFEGOFPGDIB()
		{
			if (toolUpgradeId != 0)
			{
				if (toolUpgradeCanCollect)
				{
					ToolUpgradeManager.instance.item = ItemDatabaseAccessor.KMBGJEKCJFJ(toolUpgradeId, GGBBJNBBLMF: true, DAINLFIMLIH: false);
					ToolUpgradeManager.instance.canCollect = toolUpgradeCanCollect;
				}
				else
				{
					ToolUpgradeManager.instance.FOPEFIMNBIA(ItemDatabaseAccessor.CPMMBEPEJLO(toolUpgradeId, GGBBJNBBLMF: true));
				}
			}
		}

		private void NFKLCAAIKLK()
		{
			OnlineReputationManager.instance.milestoneMaster = milestoneMaster;
		}

		private void BLDGDAKMFON()
		{
			ChristmasEvent.AHPNBKCBFOJ(178, christmasTreeQuestDone);
			ChristmasEvent.PPGKCFFLKJL(88, christmasTree2022QuestDone);
			ChristmasEvent.DEFBHHGPPMC(-92, christmasTree2023QuestDone);
			ChristmasEvent.SetTreeQuestDone(-44, christmasTree2024QuestDone);
			ChristmasEvent.AHPNBKCBFOJ(55, christmasTree2025QuestDone);
			if (presents2022Opened != null)
			{
				ChristmasEvent.EDODINDEHEN(59, presents2022Opened);
			}
			bool[] array = new bool[0];
			array[1] = present2023Opened;
			ChristmasEvent.IDBPIHJHNMA(-169, array);
			if (presents2024Opened != null)
			{
				ChristmasEvent.MHFIKLFFNCD(-135, presents2024Opened);
			}
			if (presents2025Opened != null)
			{
				ChristmasEvent.SetPresentsOpened(-109, presents2025Opened);
			}
		}

		private void DJIFAHEHPJG()
		{
			WorldTime.ENPNPHKDGPB(realGameTimeSeconds);
			WorldTime.LKEPKFBGKOH(currentTime.HOFLKNLJJPF());
			WorldTime.GMAPCOKNNAI();
			Weather.currentWeather = (Weather.WeatherType)weatherType;
			Weather.FJCOKGGBBNG();
		}

		private void NANECHGFKJB()
		{
			Money.GetBalance().MLCEFKFFBDE(moneyCopper);
		}

		private void ECOMIKCGBAM()
		{
			PlayerInfo.tavernName = tavernName;
		}

		private void EICBEMLICED()
		{
			AdoptionSignalManager.CAJHNGGCJKM().adoption = adoption;
		}

		private void OHBGOMDHIAF()
		{
			Money.JOBFHDLGMDP().MLCEFKFFBDE(moneyCopper);
		}

		private void EGKDGJKHJNB()
		{
			moneyCopper = Money.IGMJLMMADAJ().OOIPLIEJILO();
		}

		private void HHCBOHHCHEI()
		{
			OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer = farmModeOpenedByOtherPlayer;
			if (farmModeOpenedByOtherPlayer > 1)
			{
				FarmConstructionManager.instance.OtherPlayerActivatedFarmMode();
			}
		}

		private void CJEBJFJLLKL()
		{
			Crafter.sawmillRepaired = sawmillRepaired;
			Crafter.stoneWorkstationRepaired = stoneWorkstationRepaired;
			Crafter.stumpRepaired = stumpRepaired;
			Crafter.smelterRepaired = smelterRepaired;
			Crafter.blacksmithsTableRepaired = blacksmithsTableRepaired;
		}

		private void FFJLMAECDDL()
		{
			commonReferenceEvent = CommonReferences.GGFJGHHHEJC.eventNum;
		}

		private void GBEHEGEIBOJ()
		{
			commonReferenceEvent = CommonReferences.GGFJGHHHEJC.eventNum;
		}

		private void NPABKLJGEIK()
		{
			tavernName = PlayerInfo.tavernName;
		}

		private void CMJAKEDPKCB()
		{
			if (toolUpgradeId != 0)
			{
				if (toolUpgradeCanCollect)
				{
					ToolUpgradeManager.instance.item = ItemDatabaseAccessor.INJBNHPGCIJ(toolUpgradeId);
					ToolUpgradeManager.instance.canCollect = toolUpgradeCanCollect;
				}
				else
				{
					ToolUpgradeManager.instance.GPHJFILEJHP(ItemDatabaseAccessor.GOKIDLOELKB(toolUpgradeId));
				}
			}
		}

		private void POPEGFHOJJH()
		{
			OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer = farmModeOpenedByOtherPlayer;
			if (farmModeOpenedByOtherPlayer > 0)
			{
				FarmConstructionManager.instance.OtherPlayerActivatedFarmMode(KBNNPAKJDJM: true);
			}
		}

		private void DJAPBEMFEPB()
		{
			christmasTreeQuestDone = ChristmasEvent.IsTreeQuestDone(-143);
			christmasTree2022QuestDone = ChristmasEvent.IsTreeQuestDone(120);
			presents2022Opened = ChristmasEvent.ICFABGNIKIG(-26);
			christmasTree2023QuestDone = ChristmasEvent.IsTreeQuestDone(-91);
			present2023Opened = ChristmasEvent.ICFABGNIKIG(-143)[0];
			christmasTree2024QuestDone = ChristmasEvent.JOIHPFMGMOG(28);
			presents2024Opened = ChristmasEvent.GetPresentsOpened(158);
			christmasTree2025QuestDone = ChristmasEvent.EEIJGHIKANA(7);
			presents2025Opened = ChristmasEvent.GetPresentsOpened(-89);
		}

		private void BDKMEIMFIAP()
		{
			adoption = AdoptionSignalManager.DNEGFMDKNHL().adoption;
		}

		private void HFNLPJOAJLO()
		{
			christmasTreeQuestDone = ChristmasEvent.IsTreeQuestDone(2021);
			christmasTree2022QuestDone = ChristmasEvent.IsTreeQuestDone(2022);
			presents2022Opened = ChristmasEvent.GetPresentsOpened(2022);
			christmasTree2023QuestDone = ChristmasEvent.IsTreeQuestDone(2023);
			present2023Opened = ChristmasEvent.GetPresentsOpened(2023)[0];
			christmasTree2024QuestDone = ChristmasEvent.IsTreeQuestDone(2024);
			presents2024Opened = ChristmasEvent.GetPresentsOpened(2024);
			christmasTree2025QuestDone = ChristmasEvent.IsTreeQuestDone(2025);
			presents2025Opened = ChristmasEvent.GetPresentsOpened(2025);
		}

		private void IHJEJOICKCI()
		{
			wilsonDecorativeObjects = (short)ShopDatabaseAccessor.wilsonDecorativeObjects;
		}

		private void FDMKAEJNEIE()
		{
			farmModeOpenedByOtherPlayer = OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer;
		}

		private void ECIFNFMAOFB()
		{
			moneyCopper = Money.GetBalance().OOIPLIEJILO();
		}

		private void ENBKJDIODCH()
		{
			farmModeOpenedByOtherPlayer = OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer;
		}

		private void BAOJEIDFHLE()
		{
			ChristmasEvent.SetTreeQuestDone(2021, christmasTreeQuestDone);
			ChristmasEvent.SetTreeQuestDone(2022, christmasTree2022QuestDone);
			ChristmasEvent.SetTreeQuestDone(2023, christmasTree2023QuestDone);
			ChristmasEvent.SetTreeQuestDone(2024, christmasTree2024QuestDone);
			ChristmasEvent.SetTreeQuestDone(2025, christmasTree2025QuestDone);
			if (presents2022Opened != null)
			{
				ChristmasEvent.SetPresentsOpened(2022, presents2022Opened);
			}
			ChristmasEvent.SetPresentsOpened(2023, new bool[1] { present2023Opened });
			if (presents2024Opened != null)
			{
				ChristmasEvent.SetPresentsOpened(2024, presents2024Opened);
			}
			if (presents2025Opened != null)
			{
				ChristmasEvent.SetPresentsOpened(2025, presents2025Opened);
			}
		}

		private void JOIPBKILMAO()
		{
			currentTime = new GameDateMessage(WorldTime.HGIBNMBJMOC());
			realGameTimeSeconds = WorldTime.PBDJFHAKLKD();
			weatherType = (short)Weather.currentWeather;
		}
	}

	private void AJENIFFKFKF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void HPJJDIOCCDM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void KIJJGNLNLEG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void DHCJODKFLJJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void LDNFIFNLCOM(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void AELKLOLKEAK(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void FPIJJLLEDDP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void JJCONEKGOHL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void PNLDGPLGJDE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		LoadBasicsInfoSerialized oKCOIHJLGCM = new LoadBasicsInfoSerialized();
		AHGEFIOOEBL("ReceiveBasics", JJPJHIHBOIB, oKCOIHJLGCM, 0, KJOOOPJKLBB: true);
		yield return null;
	}

	private void DBHENGCAKNO(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	[PunRPC]
	private void ReceiveBasics(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void CLMIEPPAIAE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void JMMJNIPDDHG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void KDHKBNFKFOJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void FKIKFFCNCIL(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}

	private void AGMCEPBLIAA(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadBasicsInfoSerialized>(OINICMNOLPK);
	}
}
