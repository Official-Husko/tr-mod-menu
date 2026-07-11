using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class RoomReceptionDesk : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	public static RoomReceptionDesk instance;

	[SerializeField]
	private Placeable placeable;

	[SerializeField]
	private Transform customerPosition;

	[SerializeField]
	private Transform houseKeeperPosition;

	[SerializeField]
	private Customer customerRequesting;

	public OnlineReceptionDesk onlineReceptionDesk;

	private bool HANKKBNMBEI = true;

	private bool MKDDOEKEJHE = true;

	[SerializeField]
	private bool requesting;

	[SerializeField]
	private bool _negotiatingRoom;

	public bool ANAFBLDDDGD
	{
		get
		{
			return _negotiatingRoom;
		}
		private set
		{
			_negotiatingRoom = value;
		}
	}

	[SpecialName]
	private void MNHJLALIKFL(bool AODONKKHPBP)
	{
		_negotiatingRoom = AODONKKHPBP;
	}

	[SpecialName]
	private void EIIJHFLIFHA(bool AODONKKHPBP)
	{
		_negotiatingRoom = AODONKKHPBP;
	}

	public static void FLEAKKFGIOG(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static void GCAJJHNGCOD(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static Placeable KAIKMCMMHLL()
	{
		return instance.placeable;
	}

	public bool KNGGHHKPIGG(int JIIGOACEIKL)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			return OHEDCPOBPLF(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	private void IGAHGFIGCLH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(FFCMICFDHNP));
		}
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			if (!HANKKBNMBEI)
			{
				RoomOrdersBubble.OGKNJNINGMH(JIIGOACEIKL).updatePos = true;
				HANKKBNMBEI = false;
			}
		}
		else if (!MKDDOEKEJHE)
		{
			RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = true;
			MKDDOEKEJHE = true;
		}
	}

	public static Placeable EJEECOMAMBP()
	{
		return instance.placeable;
	}

	public static bool OMGABAPLJDF()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return instance.MPFPHMDGIHB();
		}
		return true;
	}

	private void Start()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public static bool MLLELDOCKHO()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	public bool CIOGGHDFDCP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void PJHODIDPMNG(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom();
		}
	}

	public static Transform HFMICHAOJFK()
	{
		return instance.houseKeeperPosition;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (IsThereAnyRequest())
		{
			if (ANAFBLDDDGD)
			{
				return false;
			}
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 0.14f;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	[SpecialName]
	public bool HLPDKNGONBI()
	{
		return _negotiatingRoom;
	}

	public static void CIHKICEPKLK(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static Placeable AJCPFEMEHNF()
	{
		return instance.placeable;
	}

	private void DFLPBGPOKGM(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom(CDPAMNIPPEC: false);
		}
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(NMJHKLCHFPH));
		}
	}

	public void GEPEIOKFDHI(bool AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		JFPEAGMNLLI(AODONKKHPBP);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineReceptionDesk.KPPFEMJADGA(AODONKKHPBP);
		}
	}

	private void GBBIHKODILO()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(EOCMOOEFLLF));
	}

	public static void DereserveSpot()
	{
		if (OnlineManager.IsMasterClient() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotReception();
		}
		instance.customerRequesting = null;
		instance.requesting = false;
	}

	public void MBMFAPCLLHL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			if (!HANKKBNMBEI)
			{
				RoomOrdersBubble.FCGLFOJDIBM(JIIGOACEIKL).updatePos = true;
				HANKKBNMBEI = true;
			}
		}
		else if (!MKDDOEKEJHE)
		{
			RoomOrdersBubble.HELHJMDEDNL(JIIGOACEIKL).updatePos = true;
			MKDDOEKEJHE = false;
		}
	}

	public bool FNHLBEGJEMJ(int JIIGOACEIKL)
	{
		if (NMKPOMCPJPB(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			return AEOFEEIGPHI(JIIGOACEIKL);
		}
		return false;
	}

	public void EGDDLLIJFMB(int JIIGOACEIKL)
	{
		if (requesting && (Object)(object)customerRequesting != (Object)null && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(ActionType.Use))
		{
			customerRequesting.DeclineRoom(CDPAMNIPPEC: false);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		}
	}

	public bool HBGEIMCOPLO(int JIIGOACEIKL)
	{
		if (DJFOLAFHINH(JIIGOACEIKL))
		{
			return AIEMCOBMHME(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public static bool KLKDEMKNHNN()
	{
		return (Object)(object)instance != (Object)null;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			return NKNMOHIFDLJ(JIIGOACEIKL);
		}
		return false;
	}

	[SpecialName]
	private void CCKHIIPJCEP(bool AODONKKHPBP)
	{
		_negotiatingRoom = AODONKKHPBP;
	}

	public bool DJFOLAFHINH(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (AOENCPPBIGJ())
		{
			if (HLPDKNGONBI())
			{
				return false;
			}
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 447f;
		}
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI();
	}

	public static Placeable FEDJFNCCPDD()
	{
		return instance.placeable;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public static Customer IDFCGDMFCJP()
	{
		return instance.customerRequesting;
	}

	private void Awake()
	{
		instance = this;
	}

	public void KGHAMBEDHKD(int JIIGOACEIKL)
	{
	}

	public static Customer CPKAIMNMOIH()
	{
		return instance.customerRequesting;
	}

	private bool IOKGICNBEHO(int JIIGOACEIKL)
	{
		if (OLHDGNMBBGI())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return true;
		}
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			RentRoomUI.NHOFBAMNELD(JIIGOACEIKL).HLAKHNBAFHL(null);
			RentRoomUI.NHOFBAMNELD(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		DialogueManager.Bark(" itemInstance: ", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		return false;
	}

	public static Vector3 GetPosition()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!HANKKBNMBEI)
			{
				RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = false;
				HANKKBNMBEI = true;
			}
		}
		else if (!MKDDOEKEJHE)
		{
			RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = false;
			MKDDOEKEJHE = true;
		}
	}

	public static Placeable KGMBAGFAEOC()
	{
		return instance.placeable;
	}

	public bool HNBIEOPGBNB(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (IsThereAnyRequest())
		{
			if (ANAFBLDDDGD)
			{
				return true;
			}
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 995f;
		}
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool BOMCNGALNEN(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (OLHDGNMBBGI())
		{
			if (MNCNOGPLHLO())
			{
				return true;
			}
			return ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 145f;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public static bool IsThereAnyRequest()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	public static bool NEACKPHIPAN()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return instance.MPFPHMDGIHB();
		}
		return false;
	}

	public bool HHNGABEOOPL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void KDDDKJMKKHN(bool AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		EIIJHFLIFHA(AODONKKHPBP);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineReceptionDesk.GHJEPNFKHOL(AODONKKHPBP);
		}
	}

	public static void KBGPJKHJBMP(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	[SpecialName]
	public bool MPFPHMDGIHB()
	{
		return _negotiatingRoom;
	}

	public static void KHGNCDPLJFB(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public static bool BKKDCMOMCOO()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	private void HLKEONIIHOP(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom(CDPAMNIPPEC: false);
		}
	}

	private bool AEOFEEIGPHI(int JIIGOACEIKL)
	{
		if (OLHDGNMBBGI())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return false;
		}
		if (RentedRoomsManager.AEBFCPODCNO().Count > 1)
		{
			RentRoomUI.OFEFGPCGJDF(JIIGOACEIKL).KMPMHKMJMID(null);
			RentRoomUI.HJHCKIAKCKD(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		DialogueManager.Bark("R1", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		return false;
	}

	public static void AHEDCPOLINH(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public static bool FGPEEPCCFHK()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static void BIOGIJKGHIH()
	{
		if (OnlineManager.IsMasterClient() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotReception();
		}
		instance.customerRequesting = null;
		instance.requesting = false;
	}

	private bool NKNMOHIFDLJ(int JIIGOACEIKL)
	{
		if (IsThereAnyRequest())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return false;
		}
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			RentRoomUI.Get(JIIGOACEIKL).SetRequest(null);
			RentRoomUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		DialogueManager.Bark("Player/Bark/RentRoom/NoRooms", ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		return false;
	}

	public bool GLHLBKBINJH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MACGEGIDFNJ(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (CDOPFGDABLI())
		{
			if (ANAFBLDDDGD)
			{
				return true;
			}
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 471f;
		}
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public static Vector3 OFPLAFKBEHE()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (requesting && (Object)(object)customerRequesting != (Object)null && PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp(ActionType.Select))
		{
			customerRequesting.DeclineRoom();
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		}
	}

	public static Customer LHNKDAFIJMB()
	{
		return instance.customerRequesting;
	}

	private void MPCFCNCMOAF()
	{
		instance = this;
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	public static Transform IHLCBMIOCJC()
	{
		return instance.customerPosition;
	}

	public static void HKGMDJFAIEJ(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}

	public void BNPNIKKPICE(int JIIGOACEIKL)
	{
		if (requesting && (Object)(object)customerRequesting != (Object)null && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonUp(ActionType.MoveObject))
		{
			customerRequesting.DeclineRoom(CDPAMNIPPEC: false);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		}
	}

	private void CMLLBIDFNEB()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(PJHODIDPMNG));
	}

	[SpecialName]
	private void JFPEAGMNLLI(bool AODONKKHPBP)
	{
		_negotiatingRoom = AODONKKHPBP;
	}

	public bool CGJJLGACANH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public static Placeable GetPlaceable()
	{
		return instance.placeable;
	}

	public bool NOJJKKFGJEJ(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (MLLELDOCKHO())
		{
			if (HLPDKNGONBI())
			{
				return false;
			}
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 54f;
		}
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public static Vector3 FIGFLHCEJLL()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public static bool IsReserved()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public bool CPDDBBCOOCC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			if (IsThereAnyRequest())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Avatar"));
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(""));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Mouse"));
				if (JIIGOACEIKL == 1)
				{
					if (RentedRoomsManager.KEGINBPMPNA().Count > 0)
					{
						if (HANKKBNMBEI)
						{
							RoomOrdersBubble.FCGLFOJDIBM(JIIGOACEIKL).updatePos = false;
							HANKKBNMBEI = false;
						}
					}
					else if (!HANKKBNMBEI)
					{
						RoomOrdersBubble.IMJOOACMADK(JIIGOACEIKL).updatePos = true;
						HANKKBNMBEI = true;
					}
				}
				else if (RentedRoomsManager.GLJNFKFJMFF().Count > 1)
				{
					if (MKDDOEKEJHE)
					{
						RoomOrdersBubble.IMJOOACMADK(JIIGOACEIKL).updatePos = false;
						MKDDOEKEJHE = false;
					}
				}
				else if (!MKDDOEKEJHE)
				{
					RoomOrdersBubble.CDEGEPGEHED(JIIGOACEIKL).updatePos = false;
					MKDDOEKEJHE = false;
				}
			}
			return true;
		}
		return false;
	}

	private bool LBIEKMFOINK(int JIIGOACEIKL)
	{
		if (CDOPFGDABLI())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return true;
		}
		if (RentedRoomsManager.BNPHNGNPBCH().Count > 0)
		{
			RentRoomUI.HJHCKIAKCKD(JIIGOACEIKL).HMFMNOKAANE(null);
			RentRoomUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		DialogueManager.Bark("OnFloor", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		return true;
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (AOENCPPBIGJ())
		{
			if (DEJPMDCBJAN())
			{
				return false;
			}
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 626f;
		}
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool CNADCCGDBPD(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (FGIIJJLOKPA())
		{
			if (DEJPMDCBJAN())
			{
				return false;
			}
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 1067f;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public static Vector3 FEODGKFADIF()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	[SpecialName]
	public bool DEJPMDCBJAN()
	{
		return _negotiatingRoom;
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	public static Placeable OJGPNDMOPFA()
	{
		return instance.placeable;
	}

	public static bool APLNIIFLFHM()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return !instance.ANAFBLDDDGD;
		}
		return true;
	}

	public static Transform HHIAJODPFDJ()
	{
		return instance.customerPosition;
	}

	public bool FBFGOFLDOHL(int JIIGOACEIKL)
	{
		if (HNBIEOPGBNB(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			return MONNFPLHMOC(JIIGOACEIKL);
		}
		return false;
	}

	public static void OKMMNPLHLGJ(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public static Vector3 GKEKLFBGDMO()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public static Customer BPIOCKMFEPG()
	{
		return instance.customerRequesting;
	}

	[SpecialName]
	private void AEFLKCEHHED(bool AODONKKHPBP)
	{
		_negotiatingRoom = AODONKKHPBP;
	}

	public void CKFKAILHHPJ(bool AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		JFPEAGMNLLI(AODONKKHPBP);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineReceptionDesk.PBBHDIAJCDD(AODONKKHPBP);
		}
	}

	public bool ABGHFCMEIBM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CFGOGPBMEKL(JIIGOACEIKL))
		{
			if (IsThereAnyRequest())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/26/Dialogue Text"));
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("ValueRemainingMs"));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UIVertical"));
				if (JIIGOACEIKL == 0)
				{
					if (RentedRoomsManager.GLJNFKFJMFF().Count > 0)
					{
						if (HANKKBNMBEI)
						{
							RoomOrdersBubble.NPANPNIDKDG(JIIGOACEIKL).updatePos = false;
							HANKKBNMBEI = true;
						}
					}
					else if (!HANKKBNMBEI)
					{
						RoomOrdersBubble.IMJOOACMADK(JIIGOACEIKL).updatePos = false;
						HANKKBNMBEI = true;
					}
				}
				else if (RentedRoomsManager.GLJNFKFJMFF().Count > 0)
				{
					if (MKDDOEKEJHE)
					{
						RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = true;
						MKDDOEKEJHE = false;
					}
				}
				else if (!MKDDOEKEJHE)
				{
					RoomOrdersBubble.HELHJMDEDNL(JIIGOACEIKL).updatePos = false;
					MKDDOEKEJHE = false;
				}
			}
			return false;
		}
		return true;
	}

	public static void CKPKLEDCDFO(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public static void EOMBBADCGJK(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public bool NGBJKCHKPHF(int JIIGOACEIKL)
	{
		if (CFGOGPBMEKL(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			return AEOFEEIGPHI(JIIGOACEIKL);
		}
		return true;
	}

	public static bool OLHDGNMBBGI()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (IsThereAnyRequest())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("RentRoom"));
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Decline"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
				if (JIIGOACEIKL == 1)
				{
					if (RentedRoomsManager.GetRoomOrders().Count > 0)
					{
						if (HANKKBNMBEI)
						{
							RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = true;
							HANKKBNMBEI = false;
						}
					}
					else if (!HANKKBNMBEI)
					{
						RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = false;
						HANKKBNMBEI = true;
					}
				}
				else if (RentedRoomsManager.GetRoomOrders().Count > 0)
				{
					if (MKDDOEKEJHE)
					{
						RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = true;
						MKDDOEKEJHE = false;
					}
				}
				else if (!MKDDOEKEJHE)
				{
					RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = false;
					MKDDOEKEJHE = true;
				}
			}
			return true;
		}
		return false;
	}

	private void JANABBNOBCD(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom();
		}
	}

	public static bool NEFOFLCFBCD()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public static Vector3 GOEONNCGKGJ()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public static bool DJCCDEACFDO()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return instance.MNCNOGPLHLO();
		}
		return true;
	}

	public bool PGGMBNLHJKP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public static Vector3 IAIMGPELBJM()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public static bool NNCFEBHLIBO()
	{
		return (Object)(object)instance != (Object)null;
	}

	public bool EBIDPMLPLIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public static Customer GetCurrentCustomer()
	{
		return instance.customerRequesting;
	}

	[SpecialName]
	public bool MNCNOGPLHLO()
	{
		return _negotiatingRoom;
	}

	public void SetNegotiateRoom(bool AODONKKHPBP, bool CDPAMNIPPEC = true)
	{
		ANAFBLDDDGD = AODONKKHPBP;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineReceptionDesk.SendNegotiatingRoom(AODONKKHPBP);
		}
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!HANKKBNMBEI)
			{
				RoomOrdersBubble.NBEGPFFBKPO(JIIGOACEIKL).updatePos = true;
				HANKKBNMBEI = false;
			}
		}
		else if (!MKDDOEKEJHE)
		{
			RoomOrdersBubble.OGKNJNINGMH(JIIGOACEIKL).updatePos = false;
			MKDDOEKEJHE = true;
		}
	}

	public bool KIJAKAGEMJN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HNBIEOPGBNB(JIIGOACEIKL))
		{
			if (AOENCPPBIGJ())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_"));
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.PreviousItem, LocalisationSystem.Get("Tool"));
			}
			else
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Whiskey"));
				if (JIIGOACEIKL == 1)
				{
					if (RentedRoomsManager.GetRoomOrders().Count > 1)
					{
						if (HANKKBNMBEI)
						{
							RoomOrdersBubble.MBDFOJAKELO(JIIGOACEIKL).updatePos = true;
							HANKKBNMBEI = true;
						}
					}
					else if (!HANKKBNMBEI)
					{
						RoomOrdersBubble.CDEGEPGEHED(JIIGOACEIKL).updatePos = false;
						HANKKBNMBEI = false;
					}
				}
				else if (RentedRoomsManager.GetRoomOrders().Count > 1)
				{
					if (MKDDOEKEJHE)
					{
						RoomOrdersBubble.NPANPNIDKDG(JIIGOACEIKL).updatePos = true;
						MKDDOEKEJHE = false;
					}
				}
				else if (!MKDDOEKEJHE)
				{
					RoomOrdersBubble.FCGLFOJDIBM(JIIGOACEIKL).updatePos = true;
					MKDDOEKEJHE = false;
				}
			}
			return false;
		}
		return false;
	}

	public static Transform GetCustomerPositionTransform()
	{
		return instance.customerPosition;
	}

	public static Customer CICMGHADMNB()
	{
		return instance.customerRequesting;
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		if (HNBIEOPGBNB(JIIGOACEIKL))
		{
			return IOKGICNBEHO(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool PCGDCMKEBPD(int JIIGOACEIKL)
	{
		if (NOJJKKFGJEJ(JIIGOACEIKL))
		{
			return LBIEKMFOINK(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public static Transform NMCMGEAMLGH()
	{
		return instance.houseKeeperPosition;
	}

	public void OHONHNNDOKC(int JIIGOACEIKL)
	{
		if (requesting && (Object)(object)customerRequesting != (Object)null && PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonUp(ActionType.NextItem))
		{
			customerRequesting.DeclineRoom(CDPAMNIPPEC: false);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
		}
	}

	public static bool CPGELEIEKKG()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			return NKNMOHIFDLJ(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public static bool FGIIJJLOKPA()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	public static Customer DKHCPFEFMBD()
	{
		return instance.customerRequesting;
	}

	private bool OHEDCPOBPLF(int JIIGOACEIKL)
	{
		if (AOENCPPBIGJ())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return true;
		}
		if (RentedRoomsManager.GetAllRooms().Count > 0)
		{
			RentRoomUI.LPJPJMPOHPG(JIIGOACEIKL).SetRequest(null);
			RentRoomUI.OFEFGPCGJDF(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		DialogueManager.Bark("Treasure Open!", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		return true;
	}

	public static void ReserveSpot(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public static void BBPMBNAGHPN()
	{
		if (OnlineManager.IsMasterClient() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotReception();
		}
		instance.customerRequesting = null;
		instance.requesting = false;
	}

	public static bool FGFCPIFANFG()
	{
		return (Object)(object)instance.customerRequesting != (Object)null;
	}

	public static bool MNBPFNPMLPH()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return !instance.DEJPMDCBJAN();
		}
		return false;
	}

	public static Transform DEPIBKPACJF()
	{
		return instance.customerPosition;
	}

	public bool KJHDHEIKKMJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	[SpecialName]
	private void KAODALBGEFP(bool AODONKKHPBP)
	{
		_negotiatingRoom = AODONKKHPBP;
	}

	public static Customer BALJJDNIKFF()
	{
		return instance.customerRequesting;
	}

	public bool OKACGFMHMEH(int JIIGOACEIKL)
	{
		if (BOMCNGALNEN(JIIGOACEIKL))
		{
			return IOKGICNBEHO(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public static bool IsThereAnyRequestNotAttended()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return !instance.ANAFBLDDDGD;
		}
		return false;
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	public static Customer GGKBFMHIPNK()
	{
		return instance.customerRequesting;
	}

	public static void RequestRoom(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public bool CLNDNLMMECC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (MACGEGIDFNJ(JIIGOACEIKL))
		{
			if (AOENCPPBIGJ())
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Drag item:"));
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/16/Dialogue Text"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Invalid playerNum"));
				if (JIIGOACEIKL == 1)
				{
					if (RentedRoomsManager.GLJNFKFJMFF().Count > 1)
					{
						if (HANKKBNMBEI)
						{
							RoomOrdersBubble.JHEHMLIPPAA(JIIGOACEIKL).updatePos = true;
							HANKKBNMBEI = false;
						}
					}
					else if (!HANKKBNMBEI)
					{
						RoomOrdersBubble.GetPlayer(JIIGOACEIKL).updatePos = true;
						HANKKBNMBEI = false;
					}
				}
				else if (RentedRoomsManager.KEGINBPMPNA().Count > 1)
				{
					if (MKDDOEKEJHE)
					{
						RoomOrdersBubble.NBEGPFFBKPO(JIIGOACEIKL).updatePos = false;
						MKDDOEKEJHE = true;
					}
				}
				else if (!MKDDOEKEJHE)
				{
					RoomOrdersBubble.OGKNJNINGMH(JIIGOACEIKL).updatePos = true;
					MKDDOEKEJHE = false;
				}
			}
			return false;
		}
		return true;
	}

	public static Vector3 FFJEFLNODOL()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	public static bool MNFMENHKNNN()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	public bool NNNKIBGDAJP(int JIIGOACEIKL)
	{
		if (HNBIEOPGBNB(JIIGOACEIKL))
		{
			return IOKGICNBEHO(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool EMCPKPFKIFH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public static Transform PICDLHDDDIM()
	{
		return instance.customerPosition;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public static bool CDOPFGDABLI()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom();
		}
	}

	private void NMJHKLCHFPH(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom();
		}
	}

	private bool MONNFPLHMOC(int JIIGOACEIKL)
	{
		if (MLLELDOCKHO())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return false;
		}
		if (RentedRoomsManager.BNPHNGNPBCH().Count > 1)
		{
			RentRoomUI.FBKOKJCKICN(JIIGOACEIKL).SetRequest(null);
			RentRoomUI.LPJPJMPOHPG(JIIGOACEIKL).OpenUI();
			return false;
		}
		DialogueManager.Bark("Modifier requirement not met", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		return true;
	}

	public static bool EPJOCNAIKMA()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null && instance.requesting)
		{
			return instance.ANAFBLDDDGD;
		}
		return true;
	}

	public static bool AOENCPPBIGJ()
	{
		if ((Object)(object)instance.customerRequesting != (Object)null)
		{
			return instance.requesting;
		}
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(FFCMICFDHNP));
		}
	}

	public bool BJMLOBEGHPL(int JIIGOACEIKL)
	{
		if (NMKPOMCPJPB(JIIGOACEIKL))
		{
			return AIEMCOBMHME(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void GLLCKILBEOL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!HANKKBNMBEI)
			{
				RoomOrdersBubble.IMJOOACMADK(JIIGOACEIKL).updatePos = false;
				HANKKBNMBEI = false;
			}
		}
		else if (!MKDDOEKEJHE)
		{
			RoomOrdersBubble.JHEHMLIPPAA(JIIGOACEIKL).updatePos = false;
			MKDDOEKEJHE = false;
		}
	}

	public static Customer IHIDDHIKPKD()
	{
		return instance.customerRequesting;
	}

	private void HHLBFDBHDMC()
	{
		TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
		tavernManager.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager.OnTavernClose, new Action<int>(EOCMOOEFLLF));
	}

	public bool NMKPOMCPJPB(int JIIGOACEIKL)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (AOENCPPBIGJ())
		{
			if (DEJPMDCBJAN())
			{
				return false;
			}
			return ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position.y > customerPosition.position.y + 1192f;
		}
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public static Transform JMEPJMJMAGL()
	{
		return instance.houseKeeperPosition;
	}

	public static void NAIDLAJGDFK()
	{
		if (OnlineManager.IsMasterClient() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotReception();
		}
		instance.customerRequesting = null;
		instance.requesting = true;
	}

	public void IMMOHBALOAO(int JIIGOACEIKL)
	{
	}

	public static void EKDMCEKEHAO(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public bool HLBIMIDENCK(int JIIGOACEIKL)
	{
		if (CFGOGPBMEKL(JIIGOACEIKL))
		{
			return LBIEKMFOINK(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	private bool AIEMCOBMHME(int JIIGOACEIKL)
	{
		if (OLHDGNMBBGI())
		{
			if ((Object)(object)customerRequesting != (Object)null && customerRequesting.roomRequest != null)
			{
				return customerRequesting.OpenRentRoomUI(JIIGOACEIKL, customerRequesting.roomRequest);
			}
			return false;
		}
		if (RentedRoomsManager.AEBFCPODCNO().Count > 0)
		{
			RentRoomUI.Get(JIIGOACEIKL).MLFEHEJEDNI(null);
			RentRoomUI.JDODHPEDACJ(JIIGOACEIKL).OpenUI();
			return false;
		}
		DialogueManager.Bark("[GetFallbackCandidates] Total fallback candidates: {0}", ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		return true;
	}

	public bool JPKPJBBFICN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOJJKKFGJEJ(JIIGOACEIKL))
		{
			if (IsThereAnyRequest())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_727"));
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Error_StairsAreBlocking"));
			}
			else
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Crop with ID "));
				if (JIIGOACEIKL == 0)
				{
					if (RentedRoomsManager.GetRoomOrders().Count > 1)
					{
						if (HANKKBNMBEI)
						{
							RoomOrdersBubble.CDEGEPGEHED(JIIGOACEIKL).updatePos = false;
							HANKKBNMBEI = true;
						}
					}
					else if (!HANKKBNMBEI)
					{
						RoomOrdersBubble.NBEGPFFBKPO(JIIGOACEIKL).updatePos = false;
						HANKKBNMBEI = true;
					}
				}
				else if (RentedRoomsManager.GLJNFKFJMFF().Count > 0)
				{
					if (MKDDOEKEJHE)
					{
						RoomOrdersBubble.NPANPNIDKDG(JIIGOACEIKL).updatePos = true;
						MKDDOEKEJHE = false;
					}
				}
				else if (!MKDDOEKEJHE)
				{
					RoomOrdersBubble.HELHJMDEDNL(JIIGOACEIKL).updatePos = true;
					MKDDOEKEJHE = true;
				}
			}
			return false;
		}
		return false;
	}

	private void EDKFNAPDMCN()
	{
		instance = this;
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame && Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager.OnTavernClose, new Action<int>(HLKEONIIHOP));
		}
	}

	public static void PHPMKCIIGPJ(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = true;
	}

	public static Customer GetCustomerRequesting()
	{
		return instance.customerRequesting;
	}

	public static Transform GetHouseKeeperPositionTransform()
	{
		return instance.houseKeeperPosition;
	}

	private void EOCMOOEFLLF(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline() && requesting && (Object)(object)customerRequesting != (Object)null)
		{
			customerRequesting.DeclineRoom();
		}
	}

	public static void PIHIPMEIJGC()
	{
		if (OnlineManager.JPPBEIJDCLJ() && (Object)(object)instance.customerRequesting != (Object)null)
		{
			instance.customerRequesting.LJOHCJAOADD.SendDereserveSpotReception();
		}
		instance.customerRequesting = null;
		instance.requesting = false;
	}

	public static void FFGILHAFMKE(Customer PJNGMCJIHME)
	{
		instance.customerRequesting = PJNGMCJIHME;
		instance.requesting = false;
	}

	public static Vector3 FFPIHLPKMHO()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return ((Component)instance).transform.position;
	}

	private void GANBBAGDALD()
	{
		instance = this;
	}

	public static Customer GEGDEKBACLE()
	{
		return instance.customerRequesting;
	}
}
