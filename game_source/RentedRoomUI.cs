using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RentedRoomUI : MonoBehaviour
{
	private static RentedRoomUI IADEMLIIDPC;

	[SerializeField]
	private RentedRoomUIPanel rentedRoomUIPanelSinglePlayer;

	[SerializeField]
	private RentedRoomUIPanel rentedRoomUIPanelRight;

	[SerializeField]
	private RentedRoomUIPanel rentedRoomUIPanelLeft;

	private RentedRoom GGNOAHDCPIB;

	private RentedRoom GBEIDEPEDLC;

	public RentedRoom ADLKGPPLOPO
	{
		get
		{
			return GGNOAHDCPIB;
		}
		set
		{
			if ((Object)(object)GGNOAHDCPIB != (Object)null)
			{
				RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
				gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(UpdateUI));
				TavernZone zone = GGNOAHDCPIB.zone;
				zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(UpdateUI));
			}
			GGNOAHDCPIB = value;
			if ((Object)(object)GGNOAHDCPIB != (Object)null)
			{
				UpdateUI();
				RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
				gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(UpdateUI));
				TavernZone zone2 = GGNOAHDCPIB.zone;
				zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(UpdateUI));
			}
		}
	}

	public RentedRoom GDJOPCALJAF
	{
		get
		{
			return GBEIDEPEDLC;
		}
		set
		{
			if ((Object)(object)GBEIDEPEDLC != (Object)null)
			{
				RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
				gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(UpdateUI));
				TavernZone zone = GBEIDEPEDLC.zone;
				zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(UpdateUI));
			}
			GBEIDEPEDLC = value;
			if ((Object)(object)GBEIDEPEDLC != (Object)null)
			{
				UpdateUI();
				RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
				gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(UpdateUI));
				TavernZone zone2 = GBEIDEPEDLC.zone;
				zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(UpdateUI));
			}
		}
	}

	public static RentedRoomUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
			}
			return IADEMLIIDPC;
		}
	}

	public void GPPADGCDOIO(int JIIGOACEIKL)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		BJFKKMLPFOA(JIIGOACEIKL, null);
	}

	public void ELFFNLKNBDI(int JIIGOACEIKL)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		SetRentedRoom(JIIGOACEIKL, null);
	}

	private void GONDLJKGLGO()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public RentedRoom ANILCEDOCEB()
	{
		return GGNOAHDCPIB;
	}

	[SpecialName]
	public RentedRoom GMIHAFLEPON()
	{
		return GGNOAHDCPIB;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public static RentedRoomUI KNLLFEJAMNN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public RentedRoom FDFBLNNIJJM()
	{
		return GBEIDEPEDLC;
	}

	[SpecialName]
	public RentedRoom OFBKOBKLENF()
	{
		return GBEIDEPEDLC;
	}

	[SpecialName]
	public RentedRoom MJEGODKODEO()
	{
		return GGNOAHDCPIB;
	}

	[SpecialName]
	public void LHDOMKMHHFD(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(JFNDNMIFLKG));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(DONFECEDHHL));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			GIJIPLBCOFP();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(JPHKKOPICGC));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
	}

	public void GNCOECLMJDL(int JIIGOACEIKL)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		JLPLKFGNCMK(JIIGOACEIKL, null);
	}

	[SpecialName]
	public RentedRoom GBJGHIPLHEI()
	{
		return GBEIDEPEDLC;
	}

	public void BOBOKDDBKII(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.SinglePlayer())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		BJFKKMLPFOA(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public void BNPKOPMOMCO(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(GBIJJFJLEJC));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(UpdateUI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			GIJIPLBCOFP();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(JFNDNMIFLKG));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GBIJJFJLEJC));
		}
	}

	[SpecialName]
	public RentedRoom DKLCMGEBEFK()
	{
		return GGNOAHDCPIB;
	}

	public void KFEOGDGPDBI(int JIIGOACEIKL)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		LIHNALDGNDN(JIIGOACEIKL, null);
	}

	[SpecialName]
	public RentedRoom PFOECEJKDJE()
	{
		return GBEIDEPEDLC;
	}

	[SpecialName]
	public void CNKMGLPDEOP(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(UpdateUI));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			GBIJJFJLEJC();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(MJOCICADHJE));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GBIJJFJLEJC));
		}
	}

	public void LIHNALDGNDN(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 0)
		{
			NOAGKALFGHA(GGNOAHDCPIB);
		}
		else
		{
			NCDGGHKGNBC(GGNOAHDCPIB);
		}
	}

	[SpecialName]
	public void FAGFFAHJOBA(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(UpdateUI));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			DONFECEDHHL();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(GBIJJFJLEJC));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GIJIPLBCOFP));
		}
	}

	public void JMCDLJAAJAC(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.SinglePlayer())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		PHMMOLANKEJ(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public void NCDGGHKGNBC(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(LCAGDLKBGHI));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(DODBDPDMICK));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			GIJIPLBCOFP();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(MJOCICADHJE));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(DODBDPDMICK));
		}
	}

	[SpecialName]
	public void POILDBJGACH(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(DONFECEDHHL));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			MJOCICADHJE();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(DODBDPDMICK));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(UpdateUI));
		}
	}

	public void GBIJJFJLEJC()
	{
		if (GameManager.HDBECFMPJHL())
		{
			rentedRoomUIPanelSinglePlayer.GCBBLHCLOMG(ANILCEDOCEB());
			return;
		}
		rentedRoomUIPanelLeft.LIKMPHECOOM(FBBHIKHDINF());
		rentedRoomUIPanelRight.DPKNBFKOIHA(NFFPAOLAKEE());
	}

	public void MKIHGKNDIJC(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.HDBECFMPJHL())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		EPCMDBBILNM(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public void GMEAOBFFLDM(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(LCAGDLKBGHI));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(UpdateUI));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			UpdateUI();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(JPHKKOPICGC));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(MJOCICADHJE));
		}
	}

	[SpecialName]
	public RentedRoom DLMPLNHPIBN()
	{
		return GBEIDEPEDLC;
	}

	public void FPKEMHFOJMN(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.SinglePlayer())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		EPCMDBBILNM(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public void FODGOMEIDKO(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(JPHKKOPICGC));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(JPHKKOPICGC));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			GIJIPLBCOFP();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(ABOJKOPKPKD));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
	}

	[SpecialName]
	public void ELADGHCMOCC(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(GIJIPLBCOFP));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(DODBDPDMICK));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			GIJIPLBCOFP();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(JPHKKOPICGC));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(ABOJKOPKPKD));
		}
	}

	[SpecialName]
	public RentedRoom GJCKBLMOGPE()
	{
		return GBEIDEPEDLC;
	}

	public void GIJIPLBCOFP()
	{
		if (GameManager.EAOOLEFMIKE())
		{
			rentedRoomUIPanelSinglePlayer.LIKMPHECOOM(HCBELAAHCCK());
			return;
		}
		rentedRoomUIPanelLeft.ENFFEEEFJEP(ANILCEDOCEB());
		rentedRoomUIPanelRight.ENFFEEEFJEP(CMOKGDIDBNB());
	}

	[SpecialName]
	public void IEBNEALMPLA(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(ABOJKOPKPKD));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(DONFECEDHHL));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			JPHKKOPICGC();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(JFNDNMIFLKG));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(DONFECEDHHL));
		}
	}

	[SpecialName]
	public static RentedRoomUI KGPJPILAHDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void PFOJDAEBPPA(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(LCAGDLKBGHI));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(DONFECEDHHL));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			JFNDNMIFLKG();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(MJOCICADHJE));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(UpdateUI));
		}
	}

	[SpecialName]
	public RentedRoom NAHDHFPKNJO()
	{
		return GGNOAHDCPIB;
	}

	[SpecialName]
	public void CKJMEHHCHPG(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(GBIJJFJLEJC));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(JPHKKOPICGC));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			LCAGDLKBGHI();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(GBIJJFJLEJC));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
	}

	public void MPKJOHFHGCM(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.SinglePlayer())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		PHMMOLANKEJ(JIIGOACEIKL, GGNOAHDCPIB);
	}

	public void LCAGDLKBGHI()
	{
		if (GameManager.NBFLEJHLGNB())
		{
			rentedRoomUIPanelSinglePlayer.DPKNBFKOIHA(JOLHJELBABB());
			return;
		}
		rentedRoomUIPanelLeft.BKNLNNLMEDK(HCBELAAHCCK());
		rentedRoomUIPanelRight.CLMJGNOEBAK(NFFPAOLAKEE());
	}

	public void BPIKCHFBJJN(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.SinglePlayer())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		FPHBPPPMPLG(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public RentedRoom CJJEHDBJCFE()
	{
		return GGNOAHDCPIB;
	}

	[SpecialName]
	public void LDLMJHLCPDK(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(ABOJKOPKPKD));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(ABOJKOPKPKD));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			DONFECEDHHL();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(DODBDPDMICK));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
	}

	public void GNDHFDMPBFJ(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		BJFKKMLPFOA(JIIGOACEIKL, GGNOAHDCPIB);
	}

	public void JPEIICHMMGA(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		FGOCPJEBKGM(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public RentedRoom MIANIMDKMLE()
	{
		return GGNOAHDCPIB;
	}

	public void JNKNBINGEIH(int JIIGOACEIKL)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		PHMMOLANKEJ(JIIGOACEIKL, null);
	}

	[SpecialName]
	public RentedRoom NFFPAOLAKEE()
	{
		return GBEIDEPEDLC;
	}

	[SpecialName]
	public void FNOAFAOGCIL(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(EBALLBJEKEI));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			ABOJKOPKPKD();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(EBALLBJEKEI));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
	}

	public void JFNDNMIFLKG()
	{
		if (GameManager.HDBECFMPJHL())
		{
			rentedRoomUIPanelSinglePlayer.BKNLNNLMEDK(CJJEHDBJCFE());
			return;
		}
		rentedRoomUIPanelLeft.DPKNBFKOIHA(ANILCEDOCEB());
		rentedRoomUIPanelRight.CLMJGNOEBAK(LJFGCLFJNGO());
	}

	public void EMNHMCNDLPJ(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 0)
		{
			NOAGKALFGHA(GGNOAHDCPIB);
		}
		else
		{
			LAGJBEBJNCD(GGNOAHDCPIB);
		}
	}

	public void BJFKKMLPFOA(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 1)
		{
			NOAGKALFGHA(GGNOAHDCPIB);
		}
		else
		{
			CKJMEHHCHPG(GGNOAHDCPIB);
		}
	}

	[SpecialName]
	public static RentedRoomUI ECGIAEFKKNA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void NOAGKALFGHA(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(LCAGDLKBGHI));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(JFNDNMIFLKG));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			MJOCICADHJE();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(UpdateUI));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GIJIPLBCOFP));
		}
	}

	public void EBALLBJEKEI()
	{
		if (GameManager.EAOOLEFMIKE())
		{
			rentedRoomUIPanelSinglePlayer.NLLMDBDLLMN(MJEGODKODEO());
			return;
		}
		rentedRoomUIPanelLeft.UpdateUI(CCPCANODPPA());
		rentedRoomUIPanelRight.LIKMPHECOOM(DLMPLNHPIBN());
	}

	[SpecialName]
	public RentedRoom IIAMNIOIGFJ()
	{
		return GBEIDEPEDLC;
	}

	public void JPHKKOPICGC()
	{
		if (GameManager.EAOOLEFMIKE())
		{
			rentedRoomUIPanelSinglePlayer.DPKNBFKOIHA(DKLCMGEBEFK());
			return;
		}
		rentedRoomUIPanelLeft.ENFFEEEFJEP(HCBELAAHCCK());
		rentedRoomUIPanelRight.LIKMPHECOOM(NFFPAOLAKEE());
	}

	[SpecialName]
	public static RentedRoomUI MIGKKKELOJO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	private void OOIHNJHMBMC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void NNEBAHFHINE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void GFLFDLIMOLI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public RentedRoom JOLHJELBABB()
	{
		return GGNOAHDCPIB;
	}

	public void POGKCDNEFNI(int JIIGOACEIKL)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		EMNHMCNDLPJ(JIIGOACEIKL, null);
	}

	public void PHMMOLANKEJ(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 0)
		{
			EKAJLNGIOJB(GGNOAHDCPIB);
		}
		else
		{
			PFOJDAEBPPA(GGNOAHDCPIB);
		}
	}

	public void DONFECEDHHL()
	{
		if (GameManager.HDBECFMPJHL())
		{
			rentedRoomUIPanelSinglePlayer.ENFFEEEFJEP(JOLHJELBABB());
			return;
		}
		rentedRoomUIPanelLeft.LIKMPHECOOM(ADLKGPPLOPO);
		rentedRoomUIPanelRight.DPKNBFKOIHA(GJCKBLMOGPE());
	}

	[SpecialName]
	public RentedRoom DDMJGCLJIGE()
	{
		return GGNOAHDCPIB;
	}

	public void KOKMFDPEMEN(int JIIGOACEIKL)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		EPCMDBBILNM(JIIGOACEIKL, null);
	}

	[SpecialName]
	public void EFCDNAKGMCP(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(GIJIPLBCOFP));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(GBIJJFJLEJC));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			JFNDNMIFLKG();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(JFNDNMIFLKG));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(JPHKKOPICGC));
		}
	}

	[SpecialName]
	public RentedRoom LJFGCLFJNGO()
	{
		return GBEIDEPEDLC;
	}

	[SpecialName]
	public static RentedRoomUI MPLODJJFKAM()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	public void ABOJKOPKPKD()
	{
		if (GameManager.NBFLEJHLGNB())
		{
			rentedRoomUIPanelSinglePlayer.CLMJGNOEBAK(CJJEHDBJCFE());
			return;
		}
		rentedRoomUIPanelLeft.IBDPOPJEIDP(OJKNAOKPEND());
		rentedRoomUIPanelRight.GCBBLHCLOMG(OFBKOBKLENF());
	}

	[SpecialName]
	public RentedRoom OJKNAOKPEND()
	{
		return GGNOAHDCPIB;
	}

	public void JLPLKFGNCMK(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 0)
		{
			CNKMGLPDEOP(GGNOAHDCPIB);
		}
		else
		{
			BNPKOPMOMCO(GGNOAHDCPIB);
		}
	}

	[SpecialName]
	public void EKAJLNGIOJB(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(JPHKKOPICGC));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			LCAGDLKBGHI();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(MJOCICADHJE));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(DONFECEDHHL));
		}
	}

	[SpecialName]
	public void AJEMFALBFHC(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(LCAGDLKBGHI));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			MJOCICADHJE();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(MJOCICADHJE));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GIJIPLBCOFP));
		}
	}

	[SpecialName]
	public void GAPALLGNCIG(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(LCAGDLKBGHI));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(GIJIPLBCOFP));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			JFNDNMIFLKG();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(GIJIPLBCOFP));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
	}

	public void OpenContent(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.SinglePlayer())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		SetRentedRoom(JIIGOACEIKL, GGNOAHDCPIB);
	}

	public void KFEEFNBMCIL(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		LIHNALDGNDN(JIIGOACEIKL, GGNOAHDCPIB);
	}

	[SpecialName]
	public RentedRoom CMOKGDIDBNB()
	{
		return GBEIDEPEDLC;
	}

	[SpecialName]
	public void IPMNNBCKIPL(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(DONFECEDHHL));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(JFNDNMIFLKG));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			DONFECEDHHL();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(GBIJJFJLEJC));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GIJIPLBCOFP));
		}
	}

	public void CloseContent(int JIIGOACEIKL)
	{
		if (GameManager.SinglePlayer())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		SetRentedRoom(JIIGOACEIKL, null);
	}

	public void MJOCICADHJE()
	{
		if (GameManager.HDBECFMPJHL())
		{
			rentedRoomUIPanelSinglePlayer.LIKMPHECOOM(MJEGODKODEO());
			return;
		}
		rentedRoomUIPanelLeft.BKNLNNLMEDK(GMIHAFLEPON());
		rentedRoomUIPanelRight.IBDPOPJEIDP(DLMPLNHPIBN());
	}

	private void HDHPOAPLEJC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void UpdateUI()
	{
		if (GameManager.SinglePlayer())
		{
			rentedRoomUIPanelSinglePlayer.UpdateUI(ADLKGPPLOPO);
			return;
		}
		rentedRoomUIPanelLeft.UpdateUI(ADLKGPPLOPO);
		rentedRoomUIPanelRight.UpdateUI(GDJOPCALJAF);
	}

	[SpecialName]
	public void MOPPHEMMGIK(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(DONFECEDHHL));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			ABOJKOPKPKD();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(GBIJJFJLEJC));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(ABOJKOPKPKD));
		}
	}

	private void PIHGEBONAOI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public RentedRoom IFOLPJFEJFJ()
	{
		return GGNOAHDCPIB;
	}

	public void DAMAFGGCBFJ(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.HDBECFMPJHL())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		JLPLKFGNCMK(JIIGOACEIKL, GGNOAHDCPIB);
	}

	public void BMCDDJPMMLE(int JIIGOACEIKL)
	{
		if (GameManager.HDBECFMPJHL())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		SetRentedRoom(JIIGOACEIKL, null);
	}

	public void FGOCPJEBKGM(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 1)
		{
			EKAJLNGIOJB(GGNOAHDCPIB);
		}
		else
		{
			EFCDNAKGMCP(GGNOAHDCPIB);
		}
	}

	[SpecialName]
	public static RentedRoomUI OPDKAPNDBJE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public void LAGJBEBJNCD(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(ABOJKOPKPKD));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(UpdateUI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			UpdateUI();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(MJOCICADHJE));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GIJIPLBCOFP));
		}
	}

	[SpecialName]
	public RentedRoom FBBHIKHDINF()
	{
		return GGNOAHDCPIB;
	}

	[SpecialName]
	public void GELIAGPIIEH(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(DONFECEDHHL));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(DONFECEDHHL));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			EBALLBJEKEI();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(JFNDNMIFLKG));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(ABOJKOPKPKD));
		}
	}

	[SpecialName]
	public RentedRoom GHNENOIEJEM()
	{
		return GGNOAHDCPIB;
	}

	private void KDHLJKMKFMG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void PGPPIHJJGDB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public void CGKMMFNPPGF(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(UpdateUI));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(ABOJKOPKPKD));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			GBIJJFJLEJC();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(EBALLBJEKEI));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
	}

	public void SetRentedRoom(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 1)
		{
			ADLKGPPLOPO = GGNOAHDCPIB;
		}
		else
		{
			GDJOPCALJAF = GGNOAHDCPIB;
		}
	}

	[SpecialName]
	public void ELCIKFFNIBF(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			RentedRoom gGNOAHDCPIB = GGNOAHDCPIB;
			gGNOAHDCPIB.OnContentsChanged = (Action)Delegate.Remove(gGNOAHDCPIB.OnContentsChanged, new Action(DONFECEDHHL));
			TavernZone zone = GGNOAHDCPIB.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(LCAGDLKBGHI));
		}
		GGNOAHDCPIB = AODONKKHPBP;
		if ((Object)(object)GGNOAHDCPIB != (Object)null)
		{
			ABOJKOPKPKD();
			RentedRoom gGNOAHDCPIB2 = GGNOAHDCPIB;
			gGNOAHDCPIB2.OnContentsChanged = (Action)Delegate.Combine(gGNOAHDCPIB2.OnContentsChanged, new Action(EBALLBJEKEI));
			TavernZone zone2 = GGNOAHDCPIB.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
	}

	private void OGEJKOIOKAN()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public RentedRoom HCBELAAHCCK()
	{
		return GGNOAHDCPIB;
	}

	private void FHOCCEBKHJI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public RentedRoom ELOAGGNMPHC()
	{
		return GGNOAHDCPIB;
	}

	[SpecialName]
	public void HDNKJGMGPIL(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(EBALLBJEKEI));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(ABOJKOPKPKD));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			DONFECEDHHL();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(ABOJKOPKPKD));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(DODBDPDMICK));
		}
	}

	public void FPHBPPPMPLG(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 0)
		{
			GAPALLGNCIG(GGNOAHDCPIB);
		}
		else
		{
			MOPPHEMMGIK(GGNOAHDCPIB);
		}
	}

	[SpecialName]
	public void ADJALHOAEOF(RentedRoom AODONKKHPBP)
	{
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			RentedRoom gBEIDEPEDLC = GBEIDEPEDLC;
			gBEIDEPEDLC.OnContentsChanged = (Action)Delegate.Remove(gBEIDEPEDLC.OnContentsChanged, new Action(GIJIPLBCOFP));
			TavernZone zone = GBEIDEPEDLC.zone;
			zone.OnComfortCalculated = (Action)Delegate.Remove(zone.OnComfortCalculated, new Action(EBALLBJEKEI));
		}
		GBEIDEPEDLC = AODONKKHPBP;
		if ((Object)(object)GBEIDEPEDLC != (Object)null)
		{
			GBIJJFJLEJC();
			RentedRoom gBEIDEPEDLC2 = GBEIDEPEDLC;
			gBEIDEPEDLC2.OnContentsChanged = (Action)Delegate.Combine(gBEIDEPEDLC2.OnContentsChanged, new Action(DODBDPDMICK));
			TavernZone zone2 = GBEIDEPEDLC.zone;
			zone2.OnComfortCalculated = (Action)Delegate.Combine(zone2.OnComfortCalculated, new Action(GBIJJFJLEJC));
		}
	}

	public void MGEFJCENDMD(int JIIGOACEIKL)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(false);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			}
		}
		EPCMDBBILNM(JIIGOACEIKL, null);
	}

	public void DODBDPDMICK()
	{
		if (GameManager.SinglePlayer())
		{
			rentedRoomUIPanelSinglePlayer.DPKNBFKOIHA(CCPCANODPPA());
			return;
		}
		rentedRoomUIPanelLeft.LIKMPHECOOM(GHNENOIEJEM());
		rentedRoomUIPanelRight.ENFFEEEFJEP(GBJGHIPLHEI());
	}

	public void GPBMCMPJCOG(int JIIGOACEIKL)
	{
		if (GameManager.SinglePlayer())
		{
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		PHMMOLANKEJ(JIIGOACEIKL, null);
	}

	[SpecialName]
	public static RentedRoomUI KHMEGDIABBF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<RentedRoomUI>();
		}
		return IADEMLIIDPC;
	}

	public void EPCMDBBILNM(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (JIIGOACEIKL == 0)
		{
			LDLMJHLCPDK(GGNOAHDCPIB);
		}
		else
		{
			LAGJBEBJNCD(GGNOAHDCPIB);
		}
	}

	[SpecialName]
	public RentedRoom CCPCANODPPA()
	{
		return GGNOAHDCPIB;
	}

	private void NMKGOAJLMDG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	[SpecialName]
	public RentedRoom PMOPGGDJAJJ()
	{
		return GBEIDEPEDLC;
	}

	public void JMKPGDHKPDI(int JIIGOACEIKL, RentedRoom GGNOAHDCPIB)
	{
		if (GameManager.HDBECFMPJHL())
		{
			((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(true);
			if (((Component)rentedRoomUIPanelRight).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(true);
			}
			if (((Component)rentedRoomUIPanelLeft).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
		}
		else
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)rentedRoomUIPanelLeft).gameObject.SetActive(true);
			}
			else
			{
				((Component)rentedRoomUIPanelRight).gameObject.SetActive(false);
			}
			if (((Component)rentedRoomUIPanelSinglePlayer).gameObject.activeSelf)
			{
				((Component)rentedRoomUIPanelSinglePlayer).gameObject.SetActive(false);
			}
		}
		LIHNALDGNDN(JIIGOACEIKL, GGNOAHDCPIB);
	}
}
