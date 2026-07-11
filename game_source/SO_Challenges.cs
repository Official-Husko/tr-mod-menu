using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

[CreateAssetMenu(fileName = "Challenges", menuName = "Game/Challenges")]
public class SO_Challenges : ScriptableObject
{
	[Serializable]
	public struct ChallengeData
	{
		public string eventName;

		public string rivalName;

		public string uniqueRivalName;

		public Sprite rivalImageSprite;

		public string rulesDescription;

		[Range(1f, 5f)]
		public int difficulty;

		public RecordType recordType;

		public bool recordIsLowestNumberAchieved;

		public Sprite previewImageSprite;

		public ChallengeType challengeType;

		public bool PCFKLMBFPLN()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Perks/perk_description_");
				return ((Result)(ref variable)).AsInt >= 1;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(25);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(-9);
			case ChallengeType.pirates:
				return EventsManager.ALEMDEBCFDH((EventsManager.EventType)91);
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(-163);
			default:
				return false;
			}
		}

		public bool LPKDMPNEMFP()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Intro/SecondConversation");
				return ((Result)(ref variable)).AsInt < 6;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-166);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(26);
			case ChallengeType.pirates:
				return EventsManager.AEFHILOAEEE(EventsManager.EventType.OldMansDuel);
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(-95);
			default:
				return true;
			}
		}

		public bool EDHNGHILCBL()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("ReceiveCompleteItemTransactionBanquetCustomer");
				return ((Result)(ref variable)).AsInt < 0;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-31);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(100);
			case ChallengeType.pirates:
				return EventsManager.AEFHILOAEEE((EventsManager.EventType)(-11));
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(61);
			default:
				return false;
			}
		}

		public bool HODJAJBGFEF()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("itemRedWine");
				return ((Result)(ref variable)).AsInt >= 1;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(-75);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(-82);
			case ChallengeType.pirates:
				return EventsManager.IsDone((EventsManager.EventType)102);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-49);
			default:
				return false;
			}
		}

		public bool NLGPFFDJNCL()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Sleep");
				return ((Result)(ref variable)).AsInt >= 8;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(32);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(-98);
			case ChallengeType.pirates:
				return EventsManager.OOCOFHECMDA((EventsManager.EventType)(-67));
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(-42);
			default:
				return true;
			}
		}

		public bool IGAECLENNGM()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("BuzzBuildExit");
				return ((Result)(ref variable)).AsInt >= 5;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(-66);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(74);
			case ChallengeType.pirates:
				return EventsManager.AEFHILOAEEE((EventsManager.EventType)(-38));
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-49);
			default:
				return true;
			}
		}

		public bool BCHMMPKHLIA()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Player");
				return ((Result)(ref variable)).AsInt < 0;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(-178);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(-53);
			case ChallengeType.pirates:
				return EventsManager.AEFHILOAEEE((EventsManager.EventType)22);
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-107);
			default:
				return true;
			}
		}

		public bool KKOPAKFKBAC()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("MainProgress");
				return ((Result)(ref variable)).AsInt >= 5;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(315);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(316);
			case ChallengeType.pirates:
				return EventsManager.IsDone(EventsManager.EventType.Fortitude);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(322);
			default:
				return true;
			}
		}

		public bool NJAILJEGGEJ()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("_");
				return ((Result)(ref variable)).AsInt >= 8;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(68);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(145);
			case ChallengeType.pirates:
				return EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-67));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(57);
			default:
				return true;
			}
		}

		public bool INMONPINCHL()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("PressToPlay");
				return ((Result)(ref variable)).AsInt >= 6;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(131);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(9);
			case ChallengeType.pirates:
				return EventsManager.OMNBJDPGPEN((EventsManager.EventType)70);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-154);
			default:
				return true;
			}
		}

		public bool DCGPPEKKJLN()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("MainProgress");
				return ((Result)(ref variable)).AsInt < 5;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(105);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(89);
			case ChallengeType.pirates:
				return EventsManager.OOCOFHECMDA((EventsManager.EventType)120);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(194);
			default:
				return true;
			}
		}

		public bool HCMNJNABEPK()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("[MinePuzzleManager] Devolviendo control al jugador {0}.");
				return ((Result)(ref variable)).AsInt < 5;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(51);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(71);
			case ChallengeType.pirates:
				return EventsManager.HGALHLALOKJ(EventsManager.EventType.MaiWorried);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-95);
			default:
				return true;
			}
		}

		public bool HKIEJPFGNMN()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Unaged Brandy");
				return ((Result)(ref variable)).AsInt < 1;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(-102);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(169);
			case ChallengeType.pirates:
				return EventsManager.IsDone((EventsManager.EventType)45);
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(-157);
			default:
				return false;
			}
		}

		public bool FCEMAIBNOFL()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Items/item_description_663");
				return ((Result)(ref variable)).AsInt < 7;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(-104);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(66);
			case ChallengeType.pirates:
				return EventsManager.ALEMDEBCFDH((EventsManager.EventType)50);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-161);
			default:
				return true;
			}
		}

		public bool HCKILAIEEGD()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/BirdPositiveComments/Entry/6/Dialogue Text");
				return ((Result)(ref variable)).AsInt < 6;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-159);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(93);
			case ChallengeType.pirates:
				return EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-63));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-151);
			default:
				return false;
			}
		}

		public bool MALCDMNJOEB()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("BarnTutorialDone");
				return ((Result)(ref variable)).AsInt < 6;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-11);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(-179);
			case ChallengeType.pirates:
				return EventsManager.AEFHILOAEEE((EventsManager.EventType)48);
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-141);
			default:
				return false;
			}
		}

		public bool DBMEMOKBKIE()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Error_FloorTilesLimit");
				return ((Result)(ref variable)).AsInt < 6;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-181);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(-118);
			case ChallengeType.pirates:
				return EventsManager.FDIHEFGPKFP((EventsManager.EventType)115);
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(-8);
			default:
				return false;
			}
		}

		public bool BDCMCEBKFFN()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Order quest");
				return ((Result)(ref variable)).AsInt < 2;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(19);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(-51);
			case ChallengeType.pirates:
				return EventsManager.DOPLDNPIBPP(EventsManager.EventType.MothersRecipe);
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(124);
			default:
				return true;
			}
		}

		public bool CLFGGGCDNJI()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Themes");
				return ((Result)(ref variable)).AsInt >= 5;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-171);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(-45);
			case ChallengeType.pirates:
				return EventsManager.OOCOFHECMDA((EventsManager.EventType)96);
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(198);
			default:
				return true;
			}
		}

		public bool IEBHFEDGMAE()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("UIPreviousCategory");
				return ((Result)(ref variable)).AsInt >= 7;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-23);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(-80);
			case ChallengeType.pirates:
				return EventsManager.LOFKKDNOKNF((EventsManager.EventType)(-107));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-151);
			default:
				return true;
			}
		}

		public bool CNMKKJPFFFP()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Quest/Entry/35/Dialogue Text");
				return ((Result)(ref variable)).AsInt >= 0;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-41);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(-47);
			case ChallengeType.pirates:
				return EventsManager.IsDone((EventsManager.EventType)75);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(176);
			default:
				return true;
			}
		}

		public bool PHDOFPGALIK()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("farm travelling");
				return ((Result)(ref variable)).AsInt >= 2;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(162);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(-138);
			case ChallengeType.pirates:
				return EventsManager.AEFHILOAEEE((EventsManager.EventType)(-76));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(120);
			default:
				return false;
			}
		}

		public bool LKKDNOGKMOF()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("DiningRoom");
				return ((Result)(ref variable)).AsInt >= 7;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(169);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(-157);
			case ChallengeType.pirates:
				return EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-54));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(-130);
			default:
				return false;
			}
		}

		public bool FIBDJHJJKDH()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("HarvestableAllYearRound");
				return ((Result)(ref variable)).AsInt >= 4;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(-158);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(43);
			case ChallengeType.pirates:
				return EventsManager.GGGECIBEKJG((EventsManager.EventType)67);
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(20);
			default:
				return false;
			}
		}

		public bool NDKDAHKMBBJ()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Get Components ");
				return ((Result)(ref variable)).AsInt < 3;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(-129);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(57);
			case ChallengeType.pirates:
				return EventsManager.GGGECIBEKJG((EventsManager.EventType)74);
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-116);
			default:
				return false;
			}
		}

		public bool KDBIOOIHILL()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Start");
				return ((Result)(ref variable)).AsInt < 0;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(-161);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(11);
			case ChallengeType.pirates:
				return EventsManager.GGGECIBEKJG((EventsManager.EventType)(-83));
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(59);
			default:
				return false;
			}
		}

		public bool AGFIAPKAHEM()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("");
				return ((Result)(ref variable)).AsInt < 4;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(72);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(71);
			case ChallengeType.pirates:
				return EventsManager.OOCOFHECMDA((EventsManager.EventType)23);
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-177);
			default:
				return false;
			}
		}

		public bool DPEIOCKDBAM()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("HandUp");
				return ((Result)(ref variable)).AsInt < 4;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(36);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(-198);
			case ChallengeType.pirates:
				return EventsManager.OOCOFHECMDA((EventsManager.EventType)(-81));
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(166);
			default:
				return false;
			}
		}

		public bool CKCJDIFAFOF()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Introduce/Entry/24/Dialogue Text");
				return ((Result)(ref variable)).AsInt >= 8;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.LLOBLPDJNJE(4);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(-59);
			case ChallengeType.pirates:
				return EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-125));
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-197);
			default:
				return false;
			}
		}

		public bool OLNNANNGNON()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("ReceiveJumpFerro2");
				return ((Result)(ref variable)).AsInt >= 2;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(-172);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(-24);
			case ChallengeType.pirates:
				return EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-120));
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(55);
			default:
				return true;
			}
		}

		public bool CALOKEKLCFI()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Pants_R");
				return ((Result)(ref variable)).AsInt < 1;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(-33);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.LLOBLPDJNJE(74);
			case ChallengeType.pirates:
				return EventsManager.OOCOFHECMDA((EventsManager.EventType)(-36));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(76);
			default:
				return false;
			}
		}

		public bool CKMDCDPNONI()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Item with id ");
				return ((Result)(ref variable)).AsInt >= 3;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(110);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(12);
			case ChallengeType.pirates:
				return EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-23));
			case ChallengeType.ninja:
				return MissionsManager.instance.BMFOFINGDLK(9);
			default:
				return true;
			}
		}

		public bool CGMHIOOHDJB()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("Not all players are near Kyroh to start the event");
				return ((Result)(ref variable)).AsInt < 4;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.BMFOFINGDLK(-182);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.IsMissionComplete(-38);
			case ChallengeType.pirates:
				return EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-29));
			case ChallengeType.ninja:
				return MissionsManager.instance.IsMissionComplete(77);
			default:
				return false;
			}
		}

		public bool JLMHALEBPLA()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			switch (challengeType)
			{
			case ChallengeType.banquet:
			{
				Result variable = DialogueLua.GetVariable("The character name can't be empty.");
				return ((Result)(ref variable)).AsInt >= 2;
			}
			case ChallengeType.fishCutting:
				return MissionsManager.instance.IsMissionComplete(-192);
			case ChallengeType.bathhouse:
				return MissionsManager.instance.BMFOFINGDLK(-147);
			case ChallengeType.pirates:
				return EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-96));
			case ChallengeType.ninja:
				return MissionsManager.instance.LLOBLPDJNJE(-97);
			default:
				return true;
			}
		}
	}

	public enum RecordType
	{
		intPoints,
		floatPoints,
		timeInSeconds
	}

	public enum ChallengeType
	{
		banquet,
		pirates,
		fishCutting,
		bathhouse,
		ninja,
		COUNT
	}

	public ChallengeData[] challenges;

	public const int BANQUET_UNLOCK_QUEST_ID = 5;
}
