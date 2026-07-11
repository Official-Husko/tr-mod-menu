using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineLoadObjects : OnlineLoadBase
{
	public class LoadObjectsMessage : LoadMessageBase
	{
		[JsonProperty("1")]
		public PlaceableMsg[] placeablesMsgs;

		[JsonProperty("2")]
		public AreaSpaceMessage[] areaSpacesMessage;

		[JsonProperty("3")]
		public CrafterMessage[] craftersMsgs;

		[JsonProperty("4")]
		public FireplaceMsg[] fireplaceMsgs;

		[JsonProperty("5")]
		public ItemContainerMsg[] containersMsgs;

		[JsonProperty("6")]
		public BarnMsg barnMsg;

		[JsonProperty("7")]
		public HenHouseMsg[] henHousesMsgs;

		[JsonProperty("8")]
		public TableMessage[] tableMessages;

		[JsonProperty("9")]
		public TreeMessage[] treeMessages;

		[JsonProperty("10")]
		public IrrigatorMessage[] irrigatorMessages;

		[JsonProperty("11")]
		public BeehiveMessage[] beehiveMessages;

		[JsonProperty("12")]
		public AnimalMessage[] animalMessages;

		[JsonProperty("13")]
		public DroppedItemMessage[] droppedItemMessages;

		[JsonProperty("14")]
		public FloorDirtMessage[] floorDirtMessages;

		[JsonProperty("15")]
		public HoleInGroundMessage[] holeInGroundMessages;

		[JsonProperty("16")]
		public MiscellaneousHarvestMessage[] miscellaneousHarvestMessages;

		[JsonProperty("17")]
		public MusselMessage[] musselMessages;

		[JsonProperty("18")]
		public DrinkDispenserMessage[] drinkDispensersMessages;

		[JsonProperty("19")]
		public DoorMessage[] doorMessage;

		[JsonProperty("20")]
		public RentedRoomMessage[] rentedRoomMessage;

		[JsonProperty("22")]
		public FishTrapMessage[] fishTrapMessages;

		[JsonProperty("23")]
		public PetBowlMessage[] petBowlMessages;

		[JsonProperty("24")]
		public BirdMessage[] birdMessages;

		[JsonProperty("25")]
		public BedMessage[] bedMessages;

		[JsonProperty("26")]
		public ChristmasTreeMessage[] christmassTreeMessages;

		[JsonProperty("27")]
		public CuckooClockMessage[] clockMessages;

		[JsonProperty("28")]
		public PhaseControllerMessage[] phaseMessages;

		[JsonProperty("29")]
		public AgingRackMessage[] agingRackMessages;

		[JsonProperty("30")]
		public AgingBarrelMessage[] agingBarrelMessages;

		[JsonProperty("31")]
		public RockMessage[] rocksMessages;

		[JsonProperty("32")]
		public DestructibleObjectMessage[] destructibleMessages;

		private void NMLLADPPCML(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void CGBKABJKPGH(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void NAIMHBGDNGP(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void MDPNGDCJOKO(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void LPMKOEFCMOK(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void JMEDOEOAOCM(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void HHCMPIAALDA(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void BGNEKFHNAKL(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void EJBJBKOBNNM(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void BOPMKJDMDJG(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void JLHBDIDPHGD(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		public override void OEJJGDMKIDN()
		{
			ObjectMessage[] bEMNMMDACLK = placeablesMsgs;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = areaSpacesMessage;
			CGBKABJKPGH(bEMNMMDACLK);
			if (areaSpacesMessage != null && areaSpacesMessage.Length != 0)
			{
				JKCEMOOLHFI.AddRange(areaSpacesMessage);
			}
			bEMNMMDACLK = craftersMsgs;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = fireplaceMsgs;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = doorMessage;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = rentedRoomMessage;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = containersMsgs;
			CGBKABJKPGH(bEMNMMDACLK);
			if (barnMsg != null && barnMsg.itemId != 0)
			{
				barnMsg.OEJJGDMKIDN();
			}
			bEMNMMDACLK = henHousesMsgs;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = tableMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = treeMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = irrigatorMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = beehiveMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = droppedItemMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = floorDirtMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = holeInGroundMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = miscellaneousHarvestMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = musselMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = drinkDispensersMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = animalMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = petBowlMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = fishTrapMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = birdMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = bedMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = christmassTreeMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = clockMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = phaseMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = agingRackMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = agingBarrelMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = rocksMessages;
			CGBKABJKPGH(bEMNMMDACLK);
			bEMNMMDACLK = destructibleMessages;
			CGBKABJKPGH(bEMNMMDACLK);
		}

		private void LCMHBNJKOJA(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void PHMKOOCCOCH(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void PKFLMNBIMGI(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void FFDKOMIMLBN(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void PAABJPJEMGH(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void DFLLOCPNMLE(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void AMHLPABIIFB(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void MPAHDPOMACO(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void OMNAPOBHOCH(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void JPNMKJPGFMC(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void JNJEIFNFJDP(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i++)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void HMDJILJDFPG(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void BOLPJEIJPKK(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 0; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}

		private void AALIPLCFPFF(ObjectMessage[] BEMNMMDACLK)
		{
			for (int i = 1; i < BEMNMMDACLK.Length; i += 0)
			{
				if (BEMNMMDACLK[i] is PlaceableMsg placeableMsg)
				{
					if (placeableMsg.surfaceParentId != 0)
					{
						ENPDILFJGCL.Add(placeableMsg);
					}
					else
					{
						BEMNMMDACLK[i].OEJJGDMKIDN();
					}
				}
				else
				{
					BEMNMMDACLK[i].OEJJGDMKIDN();
				}
			}
		}
	}

	private class DHADGNGHADP
	{
		public LoadObjectsMessage placeablesArrayMsg = new LoadObjectsMessage();

		public List<PlaceableMsg> placeablesList = new List<PlaceableMsg>();

		public List<AreaSpaceMessage> areaSpacesList = new List<AreaSpaceMessage>();

		public List<CrafterMessage> craftersList = new List<CrafterMessage>();

		public List<FireplaceMsg> fireplaceList = new List<FireplaceMsg>();

		public List<DoorMessage> doorsList = new List<DoorMessage>();

		public List<RentedRoomMessage> rentedRoomsList = new List<RentedRoomMessage>();

		public List<ItemContainerMsg> containersList = new List<ItemContainerMsg>();

		public List<HenHouseMsg> henHousesList = new List<HenHouseMsg>();

		public List<TableMessage> tablesList = new List<TableMessage>();

		public List<TreeMessage> treeList = new List<TreeMessage>();

		public List<IrrigatorMessage> irrigatorList = new List<IrrigatorMessage>();

		public List<BeehiveMessage> beehiveList = new List<BeehiveMessage>();

		public List<AnimalMessage> animalList = new List<AnimalMessage>();

		public List<DroppedItemMessage> droppedItemsList = new List<DroppedItemMessage>();

		public List<FloorDirtMessage> floorDirtList = new List<FloorDirtMessage>();

		public List<HoleInGroundMessage> holeInGroundList = new List<HoleInGroundMessage>();

		public List<MiscellaneousHarvestMessage> miscellaneousHarvestList = new List<MiscellaneousHarvestMessage>();

		public List<MusselMessage> musselList = new List<MusselMessage>();

		public List<DrinkDispenserMessage> drinkDispensersList = new List<DrinkDispenserMessage>();

		public List<PetBowlMessage> petBowlList = new List<PetBowlMessage>();

		public List<BirdMessage> birdList = new List<BirdMessage>();

		public List<FishTrapMessage> fishTrapList = new List<FishTrapMessage>();

		public List<BedMessage> bedList = new List<BedMessage>();

		public List<ChristmasTreeMessage> christmasTreeList = new List<ChristmasTreeMessage>();

		public List<CuckooClockMessage> clockList = new List<CuckooClockMessage>();

		public List<PhaseControllerMessage> phaseList = new List<PhaseControllerMessage>();

		public List<AgingRackMessage> agingRackList = new List<AgingRackMessage>();

		public List<AgingBarrelMessage> agingBarrelList = new List<AgingBarrelMessage>();

		public List<RockMessage> rockMessageList = new List<RockMessage>();

		public List<DestructibleObjectMessage> destructibleObjectsMessageList = new List<DestructibleObjectMessage>();

		public BarnMsg barnInfo;

		private PlaceableMsg CPIPBNHEELF;

		public void PDGCPKIDJKB()
		{
			FieldInfo[] fields = GetType().GetFields(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void OCPJFPIHCPA(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 156 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.MAMPLEOIEJN();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void EOLFILJIFJA(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 92 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.CreateMsg();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void FMMHJODPMKK()
		{
			FieldInfo[] fields = GetType().GetFields(BindingFlags.IgnoreCase | BindingFlags.FlattenHierarchy);
			for (int i = 1; i < fields.Length; i += 0)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void EGDAHFMPMCN()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void CJALAMOMHKE(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 49 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.GFDGBPOMDMC();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void FDKPBOMFAJP()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void DNNCECBCLGJ()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic));
			for (int i = 1; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void HBMEFDLOENF()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void DMIHOKMJILA(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 93 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.MAMPLEOIEJN();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void CLIPMKLFNMA()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void CPMGIPEGPAC(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 1 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.LPKPBCPBFEI();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void DJLOJEDLDGH()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void EICAPBIPFMD(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= -39 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.LPKPBCPBFEI();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void CNGBALDAKED(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 27 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.LPKPBCPBFEI();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void KOFADCINIDG()
		{
			FieldInfo[] fields = GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void GKABGFCIMLF(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 37 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.LPKPBCPBFEI();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void NKMGHKLPBPN()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void EOCCAAFHDFJ()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic));
			for (int i = 1; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void AELEDJOEIPF(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 199 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.GFDGBPOMDMC();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void BLJJKGOMBDP()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void MCINHDPANDP(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 99 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.GFDGBPOMDMC();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void KAHJMBHJFGG()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.NonPublic));
			for (int i = 0; i < fields.Length; i += 0)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void DBCJLCKEOPM()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
			for (int i = 0; i < fields.Length; i += 0)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void MJHBEHEOFIG()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy));
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void GEAKJAKNGOP(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 68 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.MAMPLEOIEJN();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void IBHGCGMLLCB()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void KNGHLNDGEDA()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void NGLGOKGAJKK(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= -19 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.MAMPLEOIEJN();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void BKJIKNGEMEL(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 9 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.CreateMsg();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void OMIHJNENEGM(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 198 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.CreateMsg();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void MIDDNMACANB()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.DeclaredOnly | BindingFlags.NonPublic));
			for (int i = 0; i < fields.Length; i += 0)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void PAIHNHFPOLE(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= -200 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.OGDHFKILLMN();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void HHJHBLKACJK()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void IMJEGCHOBJN()
		{
			FieldInfo[] fields = GetType().GetFields(BindingFlags.Static | BindingFlags.NonPublic);
			for (int i = 1; i < fields.Length; i++)
			{
				FieldInfo fieldInfo = fields[i];
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void ILPHAPBPAML()
		{
			FieldInfo[] fields = GetType().GetFields(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void NEBCIACOHIG()
		{
			FieldInfo[] fields = GetType().GetFields(~(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic));
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void PKBJLNBDMKP()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void BHIINEJFMII(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 44 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.GFDGBPOMDMC();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void IMLBOBGGAFD()
		{
			FieldInfo[] fields = GetType().GetFields(BindingFlags.Instance | BindingFlags.Public);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.IsGenericType && fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(List<>))
				{
					(fieldInfo.GetValue(this) as IList)?.Clear();
				}
			}
		}

		public void KFDFEKJNFAD(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 15 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.LPKPBCPBFEI();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void INPAHCOMBEC(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= -148 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.LPKPBCPBFEI();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void BJMIGBPDJNG()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void AHGCDPADOEP(OnlineObject DCLFIGENEIF)
		{
			if (DCLFIGENEIF is OnlinePlaceable onlinePlaceable && (onlinePlaceable.uniqueId < -1 || onlinePlaceable.uniqueId >= 100000 || onlinePlaceable.forceSendAtLoad))
			{
				CPIPBNHEELF = onlinePlaceable.CreateMsg();
				if (CPIPBNHEELF is AreaSpaceMessage item)
				{
					areaSpacesList.Add(item);
				}
				else if (CPIPBNHEELF is CrafterMessage item2)
				{
					craftersList.Add(item2);
				}
				else if (CPIPBNHEELF is FireplaceMsg item3)
				{
					fireplaceList.Add(item3);
				}
				else if (CPIPBNHEELF is RentedRoomMessage item4)
				{
					rentedRoomsList.Add(item4);
				}
				else if (CPIPBNHEELF is DoorMessage item5)
				{
					doorsList.Add(item5);
				}
				else if (CPIPBNHEELF is ItemContainerMsg item6)
				{
					containersList.Add(item6);
				}
				else if (CPIPBNHEELF is BarnMsg barnMsg)
				{
					barnInfo = barnMsg;
				}
				else if (CPIPBNHEELF is HenHouseMsg item7)
				{
					henHousesList.Add(item7);
				}
				else if (CPIPBNHEELF is TableMessage item8)
				{
					tablesList.Add(item8);
				}
				else if (CPIPBNHEELF is TreeMessage item9 && !(onlinePlaceable is OnlineCropTree))
				{
					treeList.Add(item9);
				}
				else if (CPIPBNHEELF is IrrigatorMessage item10)
				{
					irrigatorList.Add(item10);
				}
				else if (CPIPBNHEELF is BeehiveMessage item11)
				{
					beehiveList.Add(item11);
				}
				else if (CPIPBNHEELF is AnimalMessage item12)
				{
					animalList.Add(item12);
				}
				else if (CPIPBNHEELF is DrinkDispenserMessage item13)
				{
					drinkDispensersList.Add(item13);
				}
				else if (CPIPBNHEELF is FishTrapMessage item14)
				{
					fishTrapList.Add(item14);
				}
				else if (CPIPBNHEELF is PetBowlMessage item15)
				{
					petBowlList.Add(item15);
				}
				else if (CPIPBNHEELF is BirdMessage item16)
				{
					birdList.Add(item16);
				}
				else if (CPIPBNHEELF is BedMessage item17)
				{
					bedList.Add(item17);
				}
				else if (CPIPBNHEELF is ChristmasTreeMessage item18)
				{
					christmasTreeList.Add(item18);
				}
				else if (CPIPBNHEELF is CuckooClockMessage item19)
				{
					clockList.Add(item19);
				}
				else if (CPIPBNHEELF is PhaseControllerMessage item20)
				{
					phaseList.Add(item20);
				}
				else if (CPIPBNHEELF is AgingRackMessage item21)
				{
					agingRackList.Add(item21);
				}
				else if (CPIPBNHEELF is AgingBarrelMessage item22)
				{
					agingBarrelList.Add(item22);
				}
				else if (CPIPBNHEELF is RockMessage item23)
				{
					rockMessageList.Add(item23);
				}
				else
				{
					placeablesList.Add(CPIPBNHEELF);
				}
			}
			else if (DCLFIGENEIF is OnlineDroppedItem kBEONEKNBIL)
			{
				DroppedItemMessage item24 = new DroppedItemMessage(kBEONEKNBIL);
				droppedItemsList.Add(item24);
			}
			else if (DCLFIGENEIF is OnlineFloorDirt eAFBGFKFBFC)
			{
				floorDirtList.Add(new FloorDirtMessage(eAFBGFKFBFC));
			}
			else if (DCLFIGENEIF is OnlineHoleInGround oIOGDDFLBHM)
			{
				holeInGroundList.Add(new HoleInGroundMessage(oIOGDDFLBHM));
			}
			else if (DCLFIGENEIF is OnlineMusselHarvest aIIJPLLBHDO)
			{
				musselList.Add(new MusselMessage(aIIJPLLBHDO));
			}
			else if (DCLFIGENEIF is OnlineMiscellaneousHarvest iOBFOLBAJNM)
			{
				miscellaneousHarvestList.Add(new MiscellaneousHarvestMessage(iOBFOLBAJNM));
			}
			else if (DCLFIGENEIF is OnlineDestructibleObject hJGJFILLPHD)
			{
				destructibleObjectsMessageList.Add(new DestructibleObjectMessage(hJGJFILLPHD));
			}
		}

		public void MMHBGEDHFPI()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}

		public void LNLGNLMLGPA()
		{
			placeablesArrayMsg.placeablesMsgs = placeablesList.ToArray();
			placeablesArrayMsg.areaSpacesMessage = areaSpacesList.ToArray();
			placeablesArrayMsg.craftersMsgs = craftersList.ToArray();
			placeablesArrayMsg.fireplaceMsgs = fireplaceList.ToArray();
			placeablesArrayMsg.doorMessage = doorsList.ToArray();
			placeablesArrayMsg.rentedRoomMessage = rentedRoomsList.ToArray();
			placeablesArrayMsg.containersMsgs = containersList.ToArray();
			placeablesArrayMsg.barnMsg = barnInfo;
			placeablesArrayMsg.henHousesMsgs = henHousesList.ToArray();
			placeablesArrayMsg.tableMessages = tablesList.ToArray();
			placeablesArrayMsg.treeMessages = treeList.ToArray();
			placeablesArrayMsg.irrigatorMessages = irrigatorList.ToArray();
			placeablesArrayMsg.beehiveMessages = beehiveList.ToArray();
			placeablesArrayMsg.animalMessages = animalList.ToArray();
			placeablesArrayMsg.droppedItemMessages = droppedItemsList.ToArray();
			placeablesArrayMsg.floorDirtMessages = floorDirtList.ToArray();
			placeablesArrayMsg.holeInGroundMessages = holeInGroundList.ToArray();
			placeablesArrayMsg.musselMessages = musselList.ToArray();
			placeablesArrayMsg.miscellaneousHarvestMessages = miscellaneousHarvestList.ToArray();
			placeablesArrayMsg.drinkDispensersMessages = drinkDispensersList.ToArray();
			placeablesArrayMsg.petBowlMessages = petBowlList.ToArray();
			placeablesArrayMsg.birdMessages = birdList.ToArray();
			placeablesArrayMsg.bedMessages = bedList.ToArray();
			placeablesArrayMsg.christmassTreeMessages = christmasTreeList.ToArray();
			placeablesArrayMsg.fishTrapMessages = fishTrapList.ToArray();
			placeablesArrayMsg.clockMessages = clockList.ToArray();
			placeablesArrayMsg.phaseMessages = phaseList.ToArray();
			placeablesArrayMsg.agingRackMessages = agingRackList.ToArray();
			placeablesArrayMsg.agingBarrelMessages = agingBarrelList.ToArray();
			placeablesArrayMsg.rocksMessages = rockMessageList.ToArray();
			placeablesArrayMsg.destructibleMessages = destructibleObjectsMessageList.ToArray();
		}
	}

	public static OnlineLoadObjects instance;

	private static List<PlaceableMsg> ENPDILFJGCL;

	private static List<AreaSpaceMessage> JKCEMOOLHFI;

	private void GDDGANIPCPK(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.PKBJLNBDMKP();
		AHGEFIOOEBL("Scene", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH);
	}

	private void LDNNAJIBDFF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	public override IEnumerator SendInfo(int JJPJHIHBOIB)
	{
		Player targetPlayer = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		int i = 0;
		int numMessages = 0;
		DHADGNGHADP messagesList = new DHADGNGHADP();
		Dictionary<int, OnlineObject> dictionary = new Dictionary<int, OnlineObject>(OnlineObjectsManager.instance.onlineObjects);
		foreach (KeyValuePair<int, OnlineObject> item in dictionary)
		{
			if ((Object)(object)item.Value == (Object)null)
			{
				Debug.LogError((object)("Value null of key: " + item.Key));
				continue;
			}
			messagesList.AHGCDPADOEP(item.Value);
			i++;
			if (NKIDPDFAGAI(i, ref numMessages, messagesList, targetPlayer))
			{
				i = 0;
				yield return OnlineLoadManager.LICLEEOILOO;
			}
		}
		OOKAEBKBCND(ref numMessages, messagesList, targetPlayer, AAAANBAHLKH: true);
	}

	private bool DIBNIMBKGKL(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			DNNNLLHIPBP(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.MJHBEHEOFIG();
			return false;
		}
		return false;
	}

	private void PCKOHAIPHFI()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void ONLJCEOADJB(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.DJLOJEDLDGH();
		AHGEFIOOEBL("Items/item_description_1095", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH);
	}

	private void GLPDCALMBLA()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].PIMGHEIFHAB(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void EHBMONGBJFI()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void EFBEEBBNBKB()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].NJABALNECMH(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	[PunRPC]
	private void ReceiveObjects(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	public override void LoadMessageEnd()
	{
		base.LoadMessageEnd();
		DAHJIMIOLCN();
		DKBKPAHBBBD();
		OnlineLoadManager.instance.OnFinishedOnlineObjectsLoad();
	}

	private void NCOAPBBKHLJ()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].MFOMFFPIKHG(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void CNEBNHEOOJC()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].FGHLBEABGLB(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void BIHGKFKCMGL()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].ONIOCPCJHNO(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void IDCIOBPEFEP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private void CLNLBOAAAIJ(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.DJLOJEDLDGH();
		LoadObjectsMessage placeablesArrayMsg = BMDNHNGGOAA.placeablesArrayMsg;
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("</color>\n", HPOPHLNPNGA, placeablesArrayMsg, num, AAAANBAHLKH, EFDBJLLKFJG: true);
	}

	private bool CFCGHAGCDPM(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			AHFEKLBJAIG(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.FMMHJODPMKK();
			return true;
		}
		return true;
	}

	private void IHICPICPGDM()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].IGLLDHBPGLI(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void OMELJIDNHNJ(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.KNGHLNDGEDA();
		LoadObjectsMessage placeablesArrayMsg = BMDNHNGGOAA.placeablesArrayMsg;
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("TimeLeft", HPOPHLNPNGA, placeablesArrayMsg, num, AAAANBAHLKH);
	}

	private void COEDBJNOGMP()
	{
		for (int i = 0; i < ENPDILFJGCL.Count; i += 0)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j += 0)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("Authorization lost" + ENPDILFJGCL[j].surfaceParentId + "<color=#FFA726>+" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.FMPLGBBHECD(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: false, onlinePlaceable.uniqueId);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(0, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: false);
				onlinePlaceable.dontRemoveFromDictionary = false;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.SetUpSurface(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private bool AGGEFMIFCPN(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			KOCMNALINAB(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.EOCCAAFHDFJ();
			return false;
		}
		return true;
	}

	private void IOCEEECFEKG()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].BKHLMLGCKPE(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void OBOOCGJIKLN()
	{
		for (int i = 1; i < ENPDILFJGCL.Count; i += 0)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j += 0)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("City/Agatha/Introduce" + ENPDILFJGCL[j].surfaceParentId + "NinjaChallengeEvent/Win" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.AddPlaceableToSurface(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: false, onlinePlaceable.uniqueId);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(0, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: true);
				onlinePlaceable.dontRemoveFromDictionary = true;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.MPOKPFDKKCM(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private void OOKAEBKBCND(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.PKBJLNBDMKP();
		AHGEFIOOEBL("ReceiveObjects", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH);
	}

	private bool NJEMCPPHHHE(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			OOKAEBKBCND(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.MJHBEHEOFIG();
			return false;
		}
		return true;
	}

	private void MODNAGOJPDM()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].HAIGBPBFLPB(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void GMCKBBECJOE()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void BPPHGIIEKBA()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].BKHLMLGCKPE(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void LFPDOMAEKFP(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private bool DOPJJCMFDEC(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			CLNLBOAAAIJ(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.MJHBEHEOFIG();
			return false;
		}
		return false;
	}

	private bool CDFKPOMDBLK(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			ONLJCEOADJB(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.MJHBEHEOFIG();
			return true;
		}
		return false;
	}

	private void OFGMKKHLACD(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private bool LFENNMPONGG(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			CLNLBOAAAIJ(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.FMMHJODPMKK();
			return false;
		}
		return false;
	}

	private void GGOBJJIJDLN(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private void OCMKGMKOGCG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private void HCLOPOHAMMC(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private void PKPHKBMPJGJ()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private bool ELOPIKANMKL(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			BJNJDNBAGIM(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.KOFADCINIDG();
			return true;
		}
		return false;
	}

	private void PGEGODAEBLC()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void HLFAMECCNFA()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].PLCNECPFJJC(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void LKFPEOFNPEK()
	{
		for (int i = 0; i < ENPDILFJGCL.Count; i++)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j++)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("Items/item_name_687" + ENPDILFJGCL[j].surfaceParentId + "This is the local player" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.FMPLGBBHECD(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: false, onlinePlaceable.uniqueId, MBFODGDKDHG: true);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(0, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				onlinePlaceable.dontRemoveFromDictionary = true;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.SetUpSurface(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private void BJNJDNBAGIM(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.PKBJLNBDMKP();
		AHGEFIOOEBL("ThemeText", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH, EFDBJLLKFJG: true);
	}

	private void GDLLNOFKCDN(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.EGDAHFMPMCN();
		AHGEFIOOEBL("UIAddRemove", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH);
	}

	private void FBKEGAJHPJF(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private void EMDGIIDKMDM()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].NBAGHIJIIPA(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void FHJANDHLFDB()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].PIMGHEIFHAB(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void AJBPEBDHGHB(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.BJMIGBPDJNG();
		LoadObjectsMessage placeablesArrayMsg = BMDNHNGGOAA.placeablesArrayMsg;
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Pause", HPOPHLNPNGA, placeablesArrayMsg, num, AAAANBAHLKH, EFDBJLLKFJG: true);
	}

	private void NKHGIEHNANK(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.LNLGNLMLGPA();
		AHGEFIOOEBL(" not found. Cannot receive permission accepted", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH, EFDBJLLKFJG: true);
	}

	private void GOJKOBEEMNA()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void CCIMCDNHMGN()
	{
		for (int i = 0; i < ENPDILFJGCL.Count; i++)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j++)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("\n" + ENPDILFJGCL[j].surfaceParentId + "Error " + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.FMPLGBBHECD(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: false, onlinePlaceable.uniqueId, MBFODGDKDHG: true);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.FEFKIEJJOKG(1, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: false);
				onlinePlaceable.dontRemoveFromDictionary = true;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.MPOKPFDKKCM(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private void IFMLBLMEDAF()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i += 0)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].IGLLDHBPGLI(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private bool MPFFDDIKBGC(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			OMELJIDNHNJ(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.MIDDNMACANB();
			return false;
		}
		return true;
	}

	private void HELBHIAELCH()
	{
		for (int i = 0; i < ENPDILFJGCL.Count; i += 0)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 1; j < ENPDILFJGCL.Count; j++)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("Pipe" + ENPDILFJGCL[j].surfaceParentId + "No se encontró la conversación con el título '" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.AddPlaceableToSurface(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: false, onlinePlaceable.uniqueId);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(1, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: false);
				onlinePlaceable.dontRemoveFromDictionary = false;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.SetUpSurface(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private bool PHDPJAJIDAA(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			AHFEKLBJAIG(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.MIDDNMACANB();
			return true;
		}
		return true;
	}

	private void DNNNLLHIPBP(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.LNLGNLMLGPA();
		AHGEFIOOEBL("Sleep", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH, EFDBJLLKFJG: true);
	}

	private void KOHDOANPNHB()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].AKJOMDGDFIB(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private bool FFLOPAIOOHJ(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			OMELJIDNHNJ(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.IMLBOBGGAFD();
			return true;
		}
		return true;
	}

	private bool ALLAPFOJHJA(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			OMELJIDNHNJ(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.IMLBOBGGAFD();
			return false;
		}
		return false;
	}

	private void OOKMBGADNBF()
	{
		for (int i = 1; i < ENPDILFJGCL.Count; i += 0)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j += 0)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("AvoidingWork" + ENPDILFJGCL[j].surfaceParentId + "RewardEntry weights sum {0}, expected 100" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.AddPlaceableToSurface(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: true, onlinePlaceable.uniqueId);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(0, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
				onlinePlaceable.dontRemoveFromDictionary = true;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.SetUpSurface(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private bool IDOICLLBOIN(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			AHFEKLBJAIG(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.FMMHJODPMKK();
			return false;
		}
		return false;
	}

	private void KOCMNALINAB(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.IBHGCGMLLCB();
		LoadObjectsMessage placeablesArrayMsg = BMDNHNGGOAA.placeablesArrayMsg;
		int num = NJJDMGEBEOJ;
		NJJDMGEBEOJ = num + 0;
		AHGEFIOOEBL("Unsaved progress will be lost.", HPOPHLNPNGA, placeablesArrayMsg, num, AAAANBAHLKH);
	}

	private bool OEPLDMFBKOC(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			CLNLBOAAAIJ(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: true);
			BMDNHNGGOAA.FMMHJODPMKK();
			return true;
		}
		return false;
	}

	private void CBLAJKDABCI()
	{
		for (int i = 0; i < ENPDILFJGCL.Count; i++)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j++)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("ValueType" + ENPDILFJGCL[j].surfaceParentId + ":<color=#3a0603> +" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.FMPLGBBHECD(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: true, onlinePlaceable.uniqueId);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(1, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: false);
				onlinePlaceable.dontRemoveFromDictionary = false;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.MPOKPFDKKCM(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private void OKGCJKGLKCJ(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private bool NKIDPDFAGAI(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			OOKAEBKBCND(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.IMLBOBGGAFD();
			return true;
		}
		return false;
	}

	private void BGBFJPJLPMF()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void DAHJIMIOLCN()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].BNBJFAHIMNH(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void JNJNNAKFCJD()
	{
		for (int i = 1; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].GBDMCNEMPAD(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void DMGAIDBCLOE(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}

	private void LNPDALMANFB()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void AHFEKLBJAIG(ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA, bool AAAANBAHLKH)
	{
		BMDNHNGGOAA.MMHBGEDHFPI();
		AHGEFIOOEBL("Error_OccupiedRoom", HPOPHLNPNGA, BMDNHNGGOAA.placeablesArrayMsg, NJJDMGEBEOJ++, AAAANBAHLKH);
	}

	private void EIHMDMMOPCM()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private void BDOKBEJDFEH()
	{
		for (int i = 1; i < ENPDILFJGCL.Count; i += 0)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 1; j < ENPDILFJGCL.Count; j += 0)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("Cleaning" + ENPDILFJGCL[j].surfaceParentId + "Items/item_name_623" + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.OKNEBLLEFNL(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: true, onlinePlaceable.uniqueId, MBFODGDKDHG: true);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.FEFKIEJJOKG(0, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: true);
				onlinePlaceable.dontRemoveFromDictionary = true;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.MPOKPFDKKCM(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private void OHELJGGFJMI()
	{
		for (int i = 0; i < JKCEMOOLHFI.Count; i++)
		{
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(JKCEMOOLHFI[i].uniqueId) is OnlineAreaSpace onlineAreaSpace)
			{
				JKCEMOOLHFI[i].GHHKACEHIOP(onlineAreaSpace.areaSpace.placeablesInside);
			}
		}
	}

	private void DKBKPAHBBBD()
	{
		for (int i = 0; i < ENPDILFJGCL.Count; i++)
		{
			ENPDILFJGCL[i].OEJJGDMKIDN();
		}
		for (int j = 0; j < ENPDILFJGCL.Count; j++)
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].uniqueId);
			if ((Object)(object)onlinePlaceable == (Object)null)
			{
				continue;
			}
			OnlinePlaceable onlinePlaceable2 = OnlineObjectsManager.instance.GetOnlinePlaceable(ENPDILFJGCL[j].surfaceParentId);
			if ((Object)(object)onlinePlaceable2 == (Object)null)
			{
				Debug.LogError((object)("OnlinePlaceable with unique ID " + ENPDILFJGCL[j].surfaceParentId + " not found to load surface over him " + ((Object)((Component)onlinePlaceable.placeable).gameObject).name));
				continue;
			}
			GameObject gameObject = ((Component)onlinePlaceable).gameObject;
			Placeable placeable = onlinePlaceable.placeable.AddPlaceableToSurface(onlinePlaceable2.placeable.placeableSurface, CDPAMNIPPEC: false, onlinePlaceable.uniqueId, MBFODGDKDHG: true);
			if (Object.op_Implicit((Object)(object)placeable))
			{
				placeable.DeselectSurfaceGOInstantiated(1, onlinePlaceable2.placeable.placeableSurface, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
				onlinePlaceable.dontRemoveFromDictionary = true;
				Utils.BLPDAEHPOBA(((Component)onlinePlaceable).gameObject);
				gameObject = ((Component)placeable).gameObject;
			}
			else
			{
				onlinePlaceable.placeable.SetUpSurface(onlinePlaceable2.placeable.placeableSurface);
			}
			gameObject.GetComponent<Placeable>().PixelSnapOnLoad();
		}
		ENPDILFJGCL = null;
	}

	private void Awake()
	{
		ENPDILFJGCL = new List<PlaceableMsg>();
		JKCEMOOLHFI = new List<AreaSpaceMessage>();
	}

	private bool KHHDKBFDCGN(int PPCDIPAJBEF, ref int NJJDMGEBEOJ, DHADGNGHADP BMDNHNGGOAA, Player HPOPHLNPNGA)
	{
		if (PPCDIPAJBEF >= OnlineManager.LMALNDLJILM.MessageLimits.PlaceablesPerMessage)
		{
			GDDGANIPCPK(ref NJJDMGEBEOJ, BMDNHNGGOAA, HPOPHLNPNGA, AAAANBAHLKH: false);
			BMDNHNGGOAA.DBCJLCKEOPM();
			return true;
		}
		return false;
	}

	private void JMPKJBBOFAG(byte[] OINICMNOLPK)
	{
		CGIBEAJOLFF<LoadObjectsMessage>(OINICMNOLPK);
	}
}
