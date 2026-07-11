using System;
using AlmenaraGames;
using UnityEngine;

public class MiscellaneousHarvest : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public ItemAmount harvestedItems;

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, harvestedItems.item, harvestedItems.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (harvestedItems.item is Fish { fishType: Fish.FishType.Trash })
			{
				Utils.FKKHJPEMNBG("trashCollected", 1);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void GPECKPBIENC(int JIIGOACEIKL)
	{
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public void BBIAGBIAELE(int JIIGOACEIKL)
	{
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
			return true;
		}
		return false;
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GFKDNEJHNNI(JIIGOACEIKL))
		{
			DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, harvestedItems.item, harvestedItems.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (harvestedItems.item is Fish { fishType: (Fish.FishType)8 })
			{
				Utils.FKKHJPEMNBG("", 1);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool HJKJLDNBFLP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	public bool BADAMAJPKCA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void ACOAGLHGJFL(int JIIGOACEIKL)
	{
	}

	public bool HPBOMGJLECN(int JIIGOACEIKL)
	{
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (GFKDNEJHNNI(JIIGOACEIKL))
		{
			DroppedItem.NBIOCDNPAPO(((Component)this).gameObject.transform.position, harvestedItems.item, harvestedItems.amount, LHLJILLAHFO: true);
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			if (harvestedItems.item is Fish { fishType: Fish.FishType.WhiteFish })
			{
				Utils.FKKHJPEMNBG(", ", 1);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	public void APCCCGPGCNG(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool FHDFKMOIKBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GAAPPACMBNO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void NMPNLEAAJNM(int JIIGOACEIKL)
	{
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool CHEBOFEFAPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool HANKOEKCNJN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, harvestedItems.item, harvestedItems.amount, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (harvestedItems.item is Fish { fishType: (Fish.FishType)7 })
			{
				Utils.FKKHJPEMNBG("piratescave", 1);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return false;
	}

	public bool OJPJMNJLLKM(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool EHDHLMNCLDA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("halloweenActivated"));
			return true;
		}
		return true;
	}

	public void GIIDCCEDHOF(int JIIGOACEIKL)
	{
	}

	public bool JCCFAFPMGFI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NKHLGGKOKKA(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Give"));
			return false;
		}
		return true;
	}

	public void KDGHNDFNHNC(int JIIGOACEIKL)
	{
	}

	public bool DLMPCCAANJJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_1143"));
			return false;
		}
		return false;
	}

	public bool BJDIKIKPEJE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HGAJIMIGBIH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("TooltipsCanvas"));
			return false;
		}
		return true;
	}

	public void CCGMBIPHNKK(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool PKDBLDMIMAO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GJLNLKEFHAI(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			DroppedItem.NBIOCDNPAPO(((Component)this).gameObject.transform.position, harvestedItems.item, harvestedItems.amount, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			if (harvestedItems.item is Fish { fishType: (Fish.FishType)7 })
			{
				Utils.FKKHJPEMNBG("Event BathhouseGame activated", 0);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool BDEEAGGBHCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Return"));
			return false;
		}
		return true;
	}

	public bool OICEBEEANAI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool HDLNAIBNIHM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void GKLIANGHJKM(int JIIGOACEIKL)
	{
	}

	public void FFFAMACMKLI(int JIIGOACEIKL)
	{
	}

	public bool DECOJGDAFNH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("P1Cam"));
			return true;
		}
		return true;
	}

	public void ALBEDNOIEJF(int JIIGOACEIKL)
	{
	}

	public bool JNAJCPAENBC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OJPJMNJLLKM(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveTreeInfo"));
			return true;
		}
		return false;
	}

	public bool BKPEBOBAIJI(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool HHNGABEOOPL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, harvestedItems.item, harvestedItems.amount);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (harvestedItems.item is Fish { fishType: Fish.FishType.Seaweed })
			{
				Utils.FKKHJPEMNBG("fish collection clues", 1);
			}
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void NAKPCICILDA(int JIIGOACEIKL)
	{
	}

	public void MKFOJJOJCFG(int JIIGOACEIKL)
	{
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void FABHKGGMBFJ(int JIIGOACEIKL)
	{
	}

	public void IEAPGGGNNJF(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JDPLMJFBBED(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OJPJMNJLLKM(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("trashCollected"));
			return false;
		}
		return true;
	}

	public void KPIDKAPMBLC(int JIIGOACEIKL)
	{
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
	}

	public bool NNNKIBGDAJP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}
}
