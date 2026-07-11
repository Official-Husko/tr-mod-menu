using System;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FishingRodCollect : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public Item item;

	public GameObject inputByProximity;

	public void BKFHIADKPHK(int JIIGOACEIKL)
	{
	}

	public void MOBFEFJFGBE(int JIIGOACEIKL)
	{
	}

	public bool FCABPAKKKGL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool AJNEPGBOAKC(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void JLPLLHKJEMH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			Result variable = DialogueLua.GetVariable(" (");
			if (((Result)(ref variable)).asInt == 2)
			{
				inputByProximity.SetActive(true);
			}
		}
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
	}

	public void APAFIBNHICN(int JIIGOACEIKL)
	{
	}

	public void PLCKGMKINKG(int JIIGOACEIKL)
	{
	}

	public void JJLOHJPGDDA(int JIIGOACEIKL)
	{
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("\n"));
			return false;
		}
		return true;
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void DLBNJPKKNDN(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void KPDGBOICFKI(int JIIGOACEIKL)
	{
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	public bool BGOGFOBCPLA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void IDMNLNDEBMC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior)))
		{
			Result variable = DialogueLua.GetVariable("psai [{0}]: firing synchronized One-Shot Trigger: {1}");
			if (((Result)(ref variable)).asInt == 6)
			{
				inputByProximity.SetActive(true);
			}
		}
	}

	public void EGDDLLIJFMB(int JIIGOACEIKL)
	{
	}

	public void PNFKIHGMBLG(int JIIGOACEIKL)
	{
	}

	private void BEOGHCHPPAH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.Camp))
		{
			Result variable = DialogueLua.GetVariable("Direction");
			if (((Result)(ref variable)).asInt == 1)
			{
				inputByProximity.SetActive(true);
			}
		}
	}

	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE();
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

	public bool OGBJGGDMKFE(int JIIGOACEIKL)
	{
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool BGIJLENINMO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool GDOPOFNFLEB(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool JHJFAKBEMAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("MopUp"));
			return true;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FDOFAGGAAEO(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Seat without table (sendOnline -> "));
			return true;
		}
		return true;
	}

	public bool JEHOCIKPEJD(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				OnlineItemsManager.instance.KCNAICPHNLP(item.IMCJPECAAPC(DAINLFIMLIH: false), 1);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).AINJENENGFG(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("VSync", (object)4);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			HikariNPC.ABDJJBFNLBJ().PHKMOLLGKGG(1);
			Utils.DLIIAHACOJB(-54);
			HikariNPC.MNFMOEKMJKN().ActiveorDisableCollider(0);
			return true;
		}
		return true;
	}

	public bool EEKCDBMDNOG(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool LIMJJHPMCEA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AKLNDNECCDI(int JIIGOACEIKL)
	{
	}

	public bool BJDIKIKPEJE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Rotate"));
			return false;
		}
		return true;
	}

	private void BHKNJOEBCKA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			Result variable = DialogueLua.GetVariable("ChatWelcomeToTavern");
			if (((Result)(ref variable)).asInt == 1)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool ODAPLEDBOEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void NDLCBLKOBLF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			Result variable = DialogueLua.GetVariable("Use");
			if (((Result)(ref variable)).asInt == 6)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public bool ONDCECMGOPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ActorBedAssigned removed actorNumber: "));
			return true;
		}
		return false;
	}

	public void LDKNMDBCKFJ(int JIIGOACEIKL)
	{
	}

	public bool NNNKIBGDAJP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void LALAFOIGMKN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior)))
		{
			Result variable = DialogueLua.GetVariable("Items/item_name_1097");
			if (((Result)(ref variable)).asInt == 4)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public void GJKMPLHIDFC(int JIIGOACEIKL)
	{
	}

	public bool JOCDOHFACJH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool EBIBHGBCFCF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (GDOPOFNFLEB(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Object with itemID "));
			return true;
		}
		return false;
	}

	public bool PKKHHNOPEPH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MMAPHMGNIFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JMGDHMFOMDP(int JIIGOACEIKL)
	{
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool LCDJOHECICB(int JIIGOACEIKL)
	{
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				OnlineItemsManager.instance.CCOOJIICJPO(item.JDJGFAACPFC(), 1);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).AINJENENGFG(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
				PlayerInventory.GetPlayer(3).AddItems(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("[ChessPillarSolutionHint] Missing sprite for {0}", (object)2);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.ABDJJBFNLBJ().ActiveorDisableCollider(2);
			Utils.DLIIAHACOJB(5, CDPAMNIPPEC: true);
			HikariNPC.EKDNJDJHONF().OFOAEFKNKLK(0);
			return true;
		}
		return true;
	}

	public void AHJKKEMFNCM(int JIIGOACEIKL)
	{
	}

	public bool LFNJAANBPLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OGBJGGDMKFE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			return true;
		}
		return true;
	}

	public bool PLGPABMFEKK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JEEKGCIBKFI(int JIIGOACEIKL)
	{
	}

	public bool FNHLBEGJEMJ(int JIIGOACEIKL)
	{
		if (HMCOGHACLLG(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				OnlineItemsManager.instance.IBNOPGFCDPI(item.ODENMDOJPLC(DAINLFIMLIH: false), 0);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).AINJENENGFG(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
				PlayerInventory.NEKDDPIAOBE(7).AddItems(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("NinjaChallengeEvent/Main 3", (object)0);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			HikariNPC.MNFMOEKMJKN().OFOAEFKNKLK(8);
			Utils.DLIIAHACOJB(-108);
			HikariNPC.EKDNJDJHONF().ActiveorDisableCollider(0);
			return false;
		}
		return true;
	}

	public bool IBHGEIHOJLB(int JIIGOACEIKL)
	{
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void NJNCKELODLF()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Tavern | Location.Farm | Location.FarmShop))
		{
			Result variable = DialogueLua.GetVariable("CREATOR_ID");
			if (((Result)(ref variable)).asInt == 7)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public void FCACPDCJIOO(int JIIGOACEIKL)
	{
	}

	public bool JBNMFGLFANL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HMCOGHACLLG(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player/Bark/RygarStatue"));
			return true;
		}
		return true;
	}

	public bool IHBBDJENKFD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool COIGDMKGFCM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BJCDFHFKEGG(int JIIGOACEIKL)
	{
	}

	public void BCCCLLCEPHM(int JIIGOACEIKL)
	{
	}

	public bool JJANBHCGKOJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void DCJPIGEHCJL(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				OnlineItemsManager.instance.SendItemsToOtherPlayers(item.JDJGFAACPFC(), 1);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.GetPlayer(1).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.GetPlayer(2).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("LE_10", (object)5);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.GGFJGHHHEJC.ActiveorDisableCollider(2);
			Utils.DLIIAHACOJB(19);
			HikariNPC.GGFJGHHHEJC.ActiveorDisableCollider(1);
			return true;
		}
		return false;
	}

	public bool LEIGCMPEMPO(int JIIGOACEIKL)
	{
		if (GDOPOFNFLEB(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				OnlineItemsManager.instance.OBMMDGHBGMD(item.ODENMDOJPLC(), 0);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(item.JMDALJBNFML(), 1);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(item.JMDALJBNFML(), 1, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
			}
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("Received RPC SetTrigger {0} on {1}. Setting animator parameter.", (object)4);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			HikariNPC.EKDNJDJHONF().PHKMOLLGKGG(4);
			Utils.DLIIAHACOJB(-101);
			HikariNPC.GGFJGHHHEJC.PHKMOLLGKGG(0);
			return false;
		}
		return true;
	}

	public void IPBDAEGCBHN(int JIIGOACEIKL)
	{
	}

	public bool LCIJLDEAIDL(int JIIGOACEIKL)
	{
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).AddItems(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
				OnlineItemsManager.instance.OMDLOALIKEN(item.JPNFKDMFKMC(DAINLFIMLIH: false), 0);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
				PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).AINJENENGFG(item.JMDALJBNFML(), 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("Player2", (object)3);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.MNFMOEKMJKN().OFOAEFKNKLK(2);
			Utils.DLIIAHACOJB(8);
			HikariNPC.GGFJGHHHEJC.EOLFHELDFBD(1);
			return false;
		}
		return true;
	}

	public void EFCFFEOMJDI(int JIIGOACEIKL)
	{
	}

	public bool JJNJBEEIFFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MEEJECDJJNK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OGBJGGDMKFE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("PhaseItem"));
			return false;
		}
		return true;
	}

	public void POHNLHHIKJL(int JIIGOACEIKL)
	{
	}

	public bool KMPJAGHJABK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("autoHire"));
			return false;
		}
		return false;
	}

	public bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ALHICNPINHB(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UpgradeToLevel"));
			return true;
		}
		return false;
	}

	private void AAEDMDPLLLJ()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.River))
		{
			Result variable = DialogueLua.GetVariable("Spicy");
			if (((Result)(ref variable)).asInt == 4)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool ALHICNPINHB(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Trying to create room..."));
			return true;
		}
		return true;
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool HJKJLDNBFLP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool KPBBDKDPEFL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	public void LHPFOBOINBD(int JIIGOACEIKL)
	{
	}

	public void BIOBJGPKAAG(int JIIGOACEIKL)
	{
	}

	public void GHPDDHHKFIO(int JIIGOACEIKL)
	{
	}

	public void BBIAGBIAELE(int JIIGOACEIKL)
	{
	}

	private void MNFJELNEGPG()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.River | Location.Farm | Location.BarnInterior))
		{
			Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/TavernFilthy/Entry/3/Dialogue Text");
			if (((Result)(ref variable)).asInt == 4)
			{
				inputByProximity.SetActive(true);
			}
		}
	}

	private void EHBIMKJILDA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.Farm))
		{
			Result variable = DialogueLua.GetVariable("UI2");
			if (((Result)(ref variable)).asInt == 8)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public bool ONCPELJEPHM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EEKCDBMDNOG(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Use"));
			return true;
		}
		return false;
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public void DAHABEEAPBE(int JIIGOACEIKL)
	{
	}

	public void PCHLPDOHNMJ(int JIIGOACEIKL)
	{
	}

	public bool CANOIJPJMBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void IILCHLHOPBF(int JIIGOACEIKL)
	{
	}

	public void PGKDFKHBHFL(int JIIGOACEIKL)
	{
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (HMCOGHACLLG(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				OnlineItemsManager.instance.JNKKEKOABEE(item.JDJGFAACPFC(), 0);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).AINJENENGFG(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AINJENENGFG(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("LearnMettle", (object)3);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.EFPJLFMBPLL().ActiveorDisableCollider(5);
			Utils.DLIIAHACOJB(45);
			HikariNPC.EKDNJDJHONF().PHKMOLLGKGG(0);
			return true;
		}
		return false;
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void JFHHAPLMIHB(int JIIGOACEIKL)
	{
	}

	public bool MACDOFEHENF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OKBPDMDJICC(int JIIGOACEIKL)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				OnlineItemsManager.instance.LHHECAJMADF(item.IMCJPECAAPC(), 0);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.NEKDDPIAOBE(0).AINJENENGFG(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.NEKDDPIAOBE(5).LFBNOHNNFBB(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("<color=black>", (object)4);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.MNFMOEKMJKN().PHKMOLLGKGG(1);
			Utils.DLIIAHACOJB(21);
			HikariNPC.MNFMOEKMJKN().IKBKNBMHCIG(1);
			return false;
		}
		return false;
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GCHHJJCAOEO(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OGBJGGDMKFE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("talent_name_114"));
			return true;
		}
		return true;
	}

	public void ALBEDNOIEJF(int JIIGOACEIKL)
	{
	}

	private void ALNPAFIBJGN()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.Camp | Location.Quarry | Location.FarmShop)))
		{
			Result variable = DialogueLua.GetVariable("Cat");
			if (((Result)(ref variable)).asInt == 6)
			{
				inputByProximity.SetActive(true);
			}
		}
	}

	public void EJGAIPBFJBM(int JIIGOACEIKL)
	{
	}

	public bool PDPOCEDOJMB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DBIPJGJPBHP(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool JMIDFEGOIGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OFNDBHLFIEK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void CKHMKCCJNPG(int JIIGOACEIKL)
	{
	}

	public bool DIEMEAAOAOH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CLFKOPEMJGH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CPDDBBCOOCC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Collect"));
			return false;
		}
		return true;
	}

	public bool HMCOGHACLLG(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool MGLPIBNJLKC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void Update()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Beach))
		{
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 4)
			{
				inputByProximity.SetActive(true);
			}
		}
	}

	public void MCKPOBDBMED(int JIIGOACEIKL)
	{
	}

	public bool IEPGEGHEKEN(int JIIGOACEIKL)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
				OnlineItemsManager.instance.PHMDHDLOPBK(item.ODENMDOJPLC(DAINLFIMLIH: false), 1);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.GetPlayer(1).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
				PlayerInventory.GetPlayer(1).LFBNOHNNFBB(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			else
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 1, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("Take", (object)5);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.OFLELHKKNKC().IKBKNBMHCIG(4);
			Utils.DLIIAHACOJB(7, CDPAMNIPPEC: true);
			HikariNPC.EKDNJDJHONF().PHKMOLLGKGG(0);
			return true;
		}
		return true;
	}

	public bool OAFFHDOIDKO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FKNBGLEMLFM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MNFNIFIMHNF(int JIIGOACEIKL)
	{
	}

	public bool EAIOPONBJJK(int JIIGOACEIKL)
	{
		if (OGBJGGDMKFE(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				OnlineItemsManager.instance.GDMIPHJKFKE(item.ODENMDOJPLC(), 0);
			}
			else if (GameManager.LocalCoop())
			{
				PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).LFBNOHNNFBB(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.EIFPKCAFDIB(0).LFBNOHNNFBB(item.JMDALJBNFML(), 0, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			else
			{
				PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(item.JMDALJBNFML(), 0, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DialogueLua.SetVariable("Precision/DrinkEvent6", (object)2);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			HikariNPC.GGFJGHHHEJC.PHKMOLLGKGG(8);
			Utils.DLIIAHACOJB(-43);
			HikariNPC.MNFMOEKMJKN().PHKMOLLGKGG(1);
			return false;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EEIIGMFEPBG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void FCJBNHNKPID(int JIIGOACEIKL)
	{
	}

	public bool IDMLAIPCFCN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void HBLJGDLKMOD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Tavern | Location.River | Location.BarnInterior | Location.FarmShop))
		{
			Result variable = DialogueLua.GetVariable("TavernFilthy");
			if (((Result)(ref variable)).asInt == 1)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	public bool PGDDFHMBGDK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void KJFDLCLECAE(int JIIGOACEIKL)
	{
	}

	public void CICBEIMDOGJ(int JIIGOACEIKL)
	{
	}

	private void JBGFGOCPEFD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(~(Location.Tavern | Location.River | Location.Camp | Location.FarmShop)))
		{
			Result variable = DialogueLua.GetVariable("ActionBar3");
			if (((Result)(ref variable)).asInt == 4)
			{
				inputByProximity.SetActive(false);
			}
		}
	}

	private void NEPDNLPCCON()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (Utils.NGLLIJPOBEC(Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
		{
			Result variable = DialogueLua.GetVariable("Room code received from steam is not valid: ");
			if (((Result)(ref variable)).asInt == 5)
			{
				inputByProximity.SetActive(false);
			}
		}
	}
}
