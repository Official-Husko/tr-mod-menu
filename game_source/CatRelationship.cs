using System;
using UnityEngine;

public class CatRelationship : AnimalRelationship
{
	public OnlineCat onlineCat;

	[SerializeField]
	private SpriteRenderer relationshipHeart;

	[SerializeField]
	private Sprite[] heartSprites;

	public void FOHGHCPODBJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(HLBPKKFGMEG));
	}

	public void LANGHIOBJIH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DGFLHAOANEO));
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(DGFLHAOANEO));
		}
	}

	private void CHDEOJALBFK()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ABEPGIGLAHG));
		}
	}

	public void JPOLFKMLHNH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(KNFCIMGBNGH));
	}

	public void KACEOJDPLKB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(EGDFENJBPOK));
	}

	public void KJOJLHCDFPP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(EGDFENJBPOK));
	}

	public void DCKKIDMJKJM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(ABEPGIGLAHG));
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(HLBPKKFGMEG));
		}
	}

	public void MCMKNBIBDFF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(HLBPKKFGMEG));
	}

	private void GPOJEHBFOCC()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				OBHLLHLHFOJ();
				if (relationshipLevel >= 53)
				{
					Utils.DLIIAHACOJB(1, CDPAMNIPPEC: true);
				}
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineCat.NACBLANFEDI(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("/" + ex.Message));
		}
	}

	public void OIAHJHNPPCO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(GPOJEHBFOCC));
	}

	public void CAOKPIIFHBJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(HLBPKKFGMEG));
	}

	private void MFIEPGBABAM()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HLBPKKFGMEG));
		}
	}

	public void HFFFFAJFIPB()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(ABEPGIGLAHG));
	}

	private void HLBPKKFGMEG()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true);
				AFOPKLAMEEL();
				if (relationshipLevel >= 50)
				{
					Utils.DLIIAHACOJB(6);
				}
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineCat.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Interact" + ex.Message));
		}
	}

	private void PGEHHBDJFDB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.CheckIfThereIsFoodAvailable(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true);
				CheckTheRelationshipLevelOnPlayerSleep();
				if (relationshipLevel >= 100)
				{
					Utils.DLIIAHACOJB(7);
				}
				if (OnlineManager.IsMasterClient())
				{
					onlineCat.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in CatRelationship.CheckRelationship: " + ex.Message));
		}
	}

	private void MDGLECECOIG()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HLBPKKFGMEG));
		}
	}

	private void HINKPJCNPCF()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(PGEHHBDJFDB));
		}
	}

	public void CEIIFHIBIFI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(KNFCIMGBNGH));
	}

	private void ABEPGIGLAHG()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.FGFBFHBCIPP(GDCLFLFLFBM: true);
				ALIPOLDJFDD();
				if (relationshipLevel >= 17)
				{
					Utils.DLIIAHACOJB(3);
				}
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineCat.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("+connect_lobby" + ex.Message));
		}
	}

	private void EGDFENJBPOK()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.KFKDOEHJONF(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true);
				HEMNCNIAHHO();
				if (relationshipLevel >= -116)
				{
					Utils.DLIIAHACOJB(4);
				}
				if (OnlineManager.IsMasterClient())
				{
					onlineCat.SendSetRelationship(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(", " + ex.Message));
		}
	}

	private void KNFCIMGBNGH()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: true);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: false);
				FJCNLJLPGCB();
				if (relationshipLevel >= 114)
				{
					Utils.DLIIAHACOJB(0);
				}
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineCat.PLOEJPHGJOP(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("[PipePuzzleInteractable] No se encontró PipeConnectionPuzzleUI para playerNum " + ex.Message));
		}
	}

	public void HCEDMLJNOBL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DGFLHAOANEO));
	}

	private void DGFLHAOANEO()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				AJOMICMACEJ = PetBowl.PABANBCGOED(GDCLFLFLFBM: false);
				BNPDMNCBJHL = PetBowl.CheckIfThereIsWaterAvailable(GDCLFLFLFBM: true);
				OBHLLHLHFOJ();
				if (relationshipLevel >= -55)
				{
					Utils.DLIIAHACOJB(8);
				}
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineCat.NACBLANFEDI(relationshipLevel);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Not enough skill points" + ex.Message));
		}
	}

	public void MFMMHDPGCBO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HLBPKKFGMEG));
	}

	public void OLDDEAJMHNI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(HLBPKKFGMEG));
	}

	public void BNIKICAEIND()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(ABEPGIGLAHG));
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(KNFCIMGBNGH));
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(PGEHHBDJFDB));
		}
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(HLBPKKFGMEG));
		}
	}

	public void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(PGEHHBDJFDB));
	}

	private void LADLGPKMPBP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(EGDFENJBPOK));
		}
	}

	private void ACFABFCGIGH()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HLBPKKFGMEG));
		}
	}
}
