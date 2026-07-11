using System;
using UnityEngine;

public class DogRelationship : AnimalRelationship
{
	public OnlineDog onlineDog;

	private void BBENMDAJHEN()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false);
				ALIPOLDJFDD();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CBKLLNMGHEG(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("TimeLeft" + ex.Message));
		}
	}

	private void JFDBJMGFFON()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				OJNPGEBKLEE();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Open" + ex.Message));
		}
	}

	public void GNGADDPBJDC()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NDCFMJHANIE));
	}

	private void MAADACAHMOL()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				HEMNCNIAHHO();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("NeutralInTavern" + ex.Message));
		}
	}

	public void CEIIFHIBIFI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(EKPDFCCFGEP));
	}

	private void ALCJOABPBMA()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JFDBJMGFFON));
		}
	}

	public void IFHLGOMBACP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(HHFBEJDJPBK));
	}

	public void BNIKICAEIND()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFEJMICEEMD));
	}

	private void IFEJMICEEMD()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true);
				HMJEGNIAKLD();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("[MinePuzzleManager] Not enough active spawners for {0} (needed {1}). Trying fallback with inactive spawners." + ex.Message));
		}
	}

	public void BDGCFCPFKKE()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HHFBEJDJPBK));
	}

	private void LBIDKGPPJOG()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				GLHLHAJILFC();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("" + ex.Message));
		}
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(GPIPDNDMLPP));
		}
	}

	private void FGKKLECAAIO()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				OBHLLHLHFOJ();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.BPCJLAJNHKC(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("FarmReady" + ex.Message));
		}
	}

	private void MDGLECECOIG()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ILNMPCDBEKO));
		}
	}

	private void JCHNJOMDFOE()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true);
				OBHLLHLHFOJ();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.DPANHCJILJE(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveCantPlaceItem" + ex.Message));
		}
	}

	private void GPIPDNDMLPP()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				FJCNLJLPGCB();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveBuildingTutorialDone" + ex.Message));
		}
	}

	public void HCEDMLJNOBL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(PCPPCAECBBL));
	}

	private void IBFDMPBAIEK()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false);
				GLHLHAJILFC();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.DPANHCJILJE(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("City/PetShop/Nessy/PerritosAbandonados3" + ex.Message));
		}
	}

	private void EKPDFCCFGEP()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				NLAPHJPFIHF();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("</color>" + ex.Message));
		}
	}

	private void DEKGNHEHKFB()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IBFDMPBAIEK));
		}
	}

	private void KCBEBKDHOFO()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true);
				HMJEGNIAKLD();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.DPANHCJILJE(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("[MinePuzzleManager] Setting destructible objects for current puzzle. Count: {0} Current Puzzle = null? {1}" + ex.Message));
		}
	}

	public void HOKBBFHGACN()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HHFBEJDJPBK));
	}

	private void HHMBCKCNPPN()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(BBENMDAJHEN));
		}
	}

	public void PBFGFECPPPO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IDICKMOKLEM));
	}

	private void KNFCIMGBNGH()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				HMJEGNIAKLD();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.GBCPGODJIJC(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Klayn not find path to at " + ex.Message));
		}
	}

	private void AIFMALMBHOF()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				NLAPHJPFIHF();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.BPCJLAJNHKC(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Dialogue System/Conversation/Gass_Introduce/Entry/1/Dialogue Text" + ex.Message));
		}
	}

	private void GBKNIJENJEF()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(AIFMALMBHOF));
		}
	}

	public void OKAPGNGLOHO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(BBENMDAJHEN));
	}

	private void NDCFMJHANIE()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				HIBHJJPBHKB();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.BPCJLAJNHKC(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Game Over! Pool temperature out of safe range for too long." + ex.Message));
		}
	}

	public void PLHEHGHFCJI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(KNFCIMGBNGH));
	}

	private void OIFAINLJGKO()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false);
				KNAENPBKNHK();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("/" + ex.Message));
		}
	}

	public void HHLBFDBHDMC()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(EKPDFCCFGEP));
	}

	public void HFFFFAJFIPB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(JFDBJMGFFON));
	}

	public void AHGPALJKOKP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(KNFCIMGBNGH));
	}

	public void CFHOODNCOLK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(EGDFENJBPOK));
	}

	public void FHEGBNMJADG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(PGEHHBDJFDB));
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(PGEHHBDJFDB));
		}
	}

	public void LFNENELHOGJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DGFLHAOANEO));
	}

	private void MLHACFIGILI()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false);
				AFOPKLAMEEL();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Game" + ex.Message));
		}
	}

	private void OHKIOLCEMLM()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFEJMICEEMD));
		}
	}

	private void DGFLHAOANEO()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				IDALOAINJEK();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Hovel" + ex.Message));
		}
	}

	private void FLOFJHNAIKP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NDCFMJHANIE));
		}
	}

	public void HNEGFBCKIIJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NCLGOOGJGFK));
	}

	public void NNBIAIMPNGL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CGAFKAONICN));
	}

	private void LALJNGFGKPA()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(GPIPDNDMLPP));
		}
	}

	public void IOINOMJHICB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DGFLHAOANEO));
	}

	private void EGHOIJHBDBP()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MLHACFIGILI));
		}
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(LBIDKGPPJOG));
		}
	}

	private void EJIBCDKKPKD()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: false);
				EIIDLDANKNB();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("{0} selected on index: {1}" + ex.Message));
		}
	}

	public void GOEGBOEMHLI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HHFBEJDJPBK));
	}

	private void IGBEKHCLKFD()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(LBIDKGPPJOG));
		}
	}

	public void OIBDBLCLACB()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NCLGOOGJGFK));
	}

	public void HELHNJDFPPF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(PIABGKDEEAB));
	}

	public void DCKKIDMJKJM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(PGEHHBDJFDB));
	}

	private void IDICKMOKLEM()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				HIBHJJPBHKB();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("UIPreviousPage" + ex.Message));
		}
	}

	private void EGDFENJBPOK()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				OBHLLHLHFOJ();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("No drink available for order in banquet event. Customer: " + ex.Message));
		}
	}

	private void PCPPCAECBBL()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				OJNPGEBKLEE();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.JFOFDGEPPAN(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Sleep" + ex.Message));
		}
	}

	private void AMBKBOBDAIF()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NDCFMJHANIE));
		}
	}

	private void ILNMPCDBEKO()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true);
				HGGLOLJDHPL();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error_StairsAreBlocking" + ex.Message));
		}
	}

	private void BDGLFMKMKHM()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true);
				ALIPOLDJFDD();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Can't find seat. Reason: lastOrders" + ex.Message));
		}
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NDCFMJHANIE));
		}
	}

	private void NCLGOOGJGFK()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				BNFGACOMEJM();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.EHGKNKDPAPO(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveWorkArea" + ex.Message));
		}
	}

	private void MFIEPGBABAM()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(NDCFMJHANIE));
		}
	}

	public void AHFGOOHOLEL()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PCPPCAECBBL));
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IBFDMPBAIEK));
		}
	}

	public void MFMMHDPGCBO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(MLHACFIGILI));
	}

	private void HBHCDJBFEFM()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				OMNKNONJOGC();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("UI" + ex.Message));
		}
	}

	public void EBNENBFLEKB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IBFDMPBAIEK));
	}

	private void JNJCCIFIKOC()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(NDCFMJHANIE));
		}
	}

	public void EGACIHOKJLH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NFKBADHDBIN));
	}

	public void HKKDEKIFPPJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(KNFCIMGBNGH));
	}

	public void CFIIEJDJFPB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFEJMICEEMD));
	}

	public void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(PGEHHBDJFDB));
	}

	private void PIABGKDEEAB()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: false);
				EIIDLDANKNB();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("UISelectGamepad" + ex.Message));
		}
	}

	private void HLCAKACHOOE()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(LBIDKGPPJOG));
		}
	}

	public void IMIONHLAKIH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(KHAKMOENKLJ));
	}

	public void NDGFPPOBCNP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(OIFAINLJGKO));
	}

	private void KHAKMOENKLJ()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true);
				BNFGACOMEJM();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.BPCJLAJNHKC(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("???" + ex.Message));
		}
	}

	private void EIDJLHFAMIB()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(PIABGKDEEAB));
		}
	}

	public void HBMDEHPHAPF()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PCPPCAECBBL));
	}

	private void CMEDJEGJLJN()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IDICKMOKLEM));
		}
	}

	private void MBBIGANCPNE()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(PCPPCAECBBL));
		}
	}

	public void HJDLNCOAKIK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(NCLGOOGJGFK));
	}

	private void CGAFKAONICN()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true);
				HMJEGNIAKLD();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.BPCJLAJNHKC(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("NextItem" + ex.Message));
		}
	}

	public void IGIKNCOLCKL()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(JFDBJMGFFON));
	}

	private void JCNPCJOBENP()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFEJMICEEMD));
		}
	}

	public void NKDFMFFDGKC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IDICKMOKLEM));
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(ILNMPCDBEKO));
		}
	}

	public void JECHMEFJABD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IBFDMPBAIEK));
	}

	private void CDFMNDEKBJE()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JFDBJMGFFON));
		}
	}

	private void CHDEOJALBFK()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(PIABGKDEEAB));
		}
	}

	public void HPIMHEMJMAA()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(MAADACAHMOL));
	}

	private void HLHHDNGOGNI()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(CGAFKAONICN));
		}
	}

	private void NFKBADHDBIN()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FKOGJAGDBLA(GDCLFLFLFBM: true);
				OMNKNONJOGC();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.CBKLLNMGHEG(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Floor_6" + ex.Message));
		}
	}

	private void HNNBAAJAHEN()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(EGDFENJBPOK));
		}
	}

	public void JHBBABPAJJC()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HHFBEJDJPBK));
	}

	private void HHFBEJDJPBK()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false);
				IDALOAINJEK();
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineDog.CNOBMCIJHCP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Floor workerDesc" + ex.Message));
		}
	}

	private void PGEHHBDJFDB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false);
				CheckTheRelationshipLevelOnPlayerSleep();
				if (OnlineManager.IsMasterClient())
				{
					onlineDog.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in DogRelationship.CheckRelationship: " + ex.Message));
		}
	}

	private void EICDGBINBAG()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(PCPPCAECBBL));
		}
	}
}
