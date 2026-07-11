using System;
using AlmenaraGames;
using UnityEngine;

public class MiscItemHarvest : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public ItemAmount harvestedItems;

	public bool wall;

	public bool CLFHGIFAMME(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool CGBBGIFMMDB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FPHAKPOJPPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JDJGFAACPFC() == 3054 || harvestedItems.item.JDJGFAACPFC() == 3055) && Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(4))
			{
				MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: IngredientType.Mushroom } && Random.Range(0, 100) < PerksDatabaseAccessor.GetPlayerPerkValue(12))
			{
				MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public void AFAEJPCDJJC(int JIIGOACEIKL)
	{
	}

	public bool GKKEAILLOBN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void BENDDGPKABK(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.DKCOHAOMNOC(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
		else
		{
			DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
	}

	public bool MBADIPPGFAO(int JIIGOACEIKL)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.ODENMDOJPLC(DAINLFIMLIH: false) == -159 || harvestedItems.item.JGHNDJBCFAJ() == -56) && Random.Range(0, 87) < PerksDatabaseAccessor.GetPlayerPerkValue(6, 0, LDNMDAHFBGG: true))
			{
				JGJGGOBHKGO(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-6) } && Random.Range(0, -50) < PerksDatabaseAccessor.NGMJIGOPGDK(1, 1, LDNMDAHFBGG: true))
			{
				BENDDGPKABK(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public bool LMHMCNOBAGE(int JIIGOACEIKL)
	{
		if (EEHOADGLDMP(JIIGOACEIKL))
		{
			IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 131 || harvestedItems.item.JDJGFAACPFC() == 13) && Random.Range(1, -126) < PerksDatabaseAccessor.NGMJIGOPGDK(5, 1, LDNMDAHFBGG: true))
			{
				HDLEEOJMILI(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)98 } && Random.Range(1, 37) < PerksDatabaseAccessor.GetPlayerPerkValue(-13))
			{
				BLCKMKPJFLK(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool HFAILPNNNBB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NCDNGJMMEDG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dropped item "));
			return true;
		}
		return false;
	}

	public bool EHJJFIKNGAF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GPDHPJBNPAD(int JIIGOACEIKL)
	{
		if (CLFHGIFAMME(JIIGOACEIKL))
		{
			ONEGINIFCIC(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 127 || harvestedItems.item.IMCJPECAAPC(DAINLFIMLIH: false) == 174) && Random.Range(0, 18) < PerksDatabaseAccessor.NGMJIGOPGDK(3, 1))
			{
				JICPGBNFCOJ(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-18) } && Random.Range(0, -94) < PerksDatabaseAccessor.GetPlayerPerkValue(107, 1))
			{
				EEIOJMGIMFE(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	private void LJMOJOBFEGB(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.FGKGNPKGALN(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
		else
		{
			DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		}
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		if (KEPKNBFJPOO(JIIGOACEIKL))
		{
			MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 21 || harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -185) && Random.Range(0, 103) < PerksDatabaseAccessor.NGMJIGOPGDK(1))
			{
				EEIOJMGIMFE(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: IngredientType.Yeast } && Random.Range(1, -78) < PerksDatabaseAccessor.GetPlayerPerkValue(-80, 1, LDNMDAHFBGG: true))
			{
				EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return false;
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	public bool ENKFOFBGLNN(int JIIGOACEIKL)
	{
		return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool GHDIMCAEAJJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NDHKOEDAHNI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KEPKNBFJPOO(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("BuildMode"));
			return false;
		}
		return true;
	}

	public void MGGEKKLANAB(int JIIGOACEIKL)
	{
	}

	public bool AFOBLAONEDM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_19"));
			return true;
		}
		return false;
	}

	public bool CEPOMEBIFBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KEPKNBFJPOO(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("/resetsize: "));
			return true;
		}
		return false;
	}

	public bool EAJGOIOAPNP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool LOOGAHBFNLA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EEHOADGLDMP(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player/Bark/Tutorial/AgingBarrelBlock"));
			return false;
		}
		return true;
	}

	public void JJELBOKLMLB(int JIIGOACEIKL)
	{
	}

	private void BLCKMKPJFLK(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.KBDEAPJKNED(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		}
		else
		{
			DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
	}

	private void MFPMCMFDONM(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.FGKGNPKGALN(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: true);
		}
		else
		{
			DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG);
		}
	}

	public void OOKIPOOPFDG(int JIIGOACEIKL)
	{
	}

	public bool BHLKEMIONKG(int JIIGOACEIKL)
	{
		if (ENKFOFBGLNN(JIIGOACEIKL))
		{
			LJMOJOBFEGB(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -113 || harvestedItems.item.JDJGFAACPFC() == 72) && Random.Range(1, 38) < PerksDatabaseAccessor.NGMJIGOPGDK(1, 0, LDNMDAHFBGG: true))
			{
				ONEGINIFCIC(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)61 } && Random.Range(1, -74) < PerksDatabaseAccessor.GetPlayerPerkValue(-124, 1, LDNMDAHFBGG: true))
			{
				JGJGGOBHKGO(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return false;
	}

	public void EGDDLLIJFMB(int JIIGOACEIKL)
	{
	}

	public void DFFCCILMAHN(int JIIGOACEIKL)
	{
	}

	private void JICPGBNFCOJ(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		}
		else
		{
			DroppedItem.NBIOCDNPAPO(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
	}

	public void EFGLEADDPAN(int JIIGOACEIKL)
	{
	}

	public bool CMIOKHGJCNB(int JIIGOACEIKL)
	{
		if (CLFHGIFAMME(JIIGOACEIKL))
		{
			ONEGINIFCIC(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -131 || harvestedItems.item.JDJGFAACPFC(DAINLFIMLIH: false) == 85) && Random.Range(1, 22) < PerksDatabaseAccessor.GetPlayerPerkValue(1, 1))
			{
				LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)108 } && Random.Range(1, -4) < PerksDatabaseAccessor.GetPlayerPerkValue(46, 1, LDNMDAHFBGG: true))
			{
				LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	public bool BEHJINBIFDO(int JIIGOACEIKL)
	{
		if (ENKFOFBGLNN(JIIGOACEIKL))
		{
			EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.CIGFGKKCPCK() == -16 || harvestedItems.item.JGHNDJBCFAJ() == 158) && Random.Range(0, 95) < PerksDatabaseAccessor.NGMJIGOPGDK(1, 1, LDNMDAHFBGG: true))
			{
				LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-20) } && Random.Range(1, 91) < PerksDatabaseAccessor.NGMJIGOPGDK(-115))
			{
				DEKEKKKMHKB(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public bool EGNHDNAHHPA(int JIIGOACEIKL)
	{
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			JGJGGOBHKGO(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.IMCJPECAAPC() == 174 || harvestedItems.item.JDJGFAACPFC() == 116) && Random.Range(0, -30) < PerksDatabaseAccessor.NGMJIGOPGDK(8))
			{
				MFPMCMFDONM(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: IngredientType.Legumes } && Random.Range(1, -14) < PerksDatabaseAccessor.GetPlayerPerkValue(-25, 0, LDNMDAHFBGG: true))
			{
				KBDEAPJKNED(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	public void FIECAFNFCDM(int JIIGOACEIKL)
	{
	}

	public bool JPKPJBBFICN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" value "));
			return true;
		}
		return true;
	}

	public bool FMDIGCNHBAP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool FKOACOFKLDJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		if (NOEEFMEKOMN(JIIGOACEIKL))
		{
			FLPJIPHPNBK(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.IMCJPECAAPC(DAINLFIMLIH: false) == 169 || harvestedItems.item.CIGFGKKCPCK() == 44) && Random.Range(1, -76) < PerksDatabaseAccessor.NGMJIGOPGDK(6, 1, LDNMDAHFBGG: true))
			{
				HDLEEOJMILI(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-2) } && Random.Range(0, 95) < PerksDatabaseAccessor.GetPlayerPerkValue(-33, 1, LDNMDAHFBGG: true))
			{
				FLPJIPHPNBK(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	private void LLEHJNECOPF(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.NBIOCDNPAPO(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
		else
		{
			DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
	}

	public void INMODMPAAKJ(int JIIGOACEIKL)
	{
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool OMNKOKKEIFI(int JIIGOACEIKL)
	{
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 70 || harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 125) && Random.Range(0, -117) < PerksDatabaseAccessor.NGMJIGOPGDK(1, 1))
			{
				JGJGGOBHKGO(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: IngredientType.Yeast } && Random.Range(1, -6) < PerksDatabaseAccessor.GetPlayerPerkValue(-127, 0, LDNMDAHFBGG: true))
			{
				MNEJKPHOMCB(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.CIGFGKKCPCK() == -87 || harvestedItems.item.ODENMDOJPLC(DAINLFIMLIH: false) == 131) && Random.Range(0, -43) < PerksDatabaseAccessor.NGMJIGOPGDK(1, 1, LDNMDAHFBGG: true))
			{
				IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)81 } && Random.Range(1, 54) < PerksDatabaseAccessor.NGMJIGOPGDK(-39, 1))
			{
				BLCKMKPJFLK(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public void DPKKPFCPJNP(int JIIGOACEIKL)
	{
	}

	public bool KEPKNBFJPOO(int JIIGOACEIKL)
	{
		return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
	}

	public bool BOJEGMBKILO(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMGDHMFOMDP(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("tutorialPopUp124"));
			return false;
		}
		return false;
	}

	public bool GIPEJKINDHI(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool IPGCPPBNKPF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FACGEEJCMEC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IFMMLFLIJJK(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool EEHOADGLDMP(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool KECIMALLGDA(int JIIGOACEIKL)
	{
		if (CLFHGIFAMME(JIIGOACEIKL))
		{
			JICPGBNFCOJ(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JDJGFAACPFC() == -127 || harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 122) && Random.Range(1, -116) < PerksDatabaseAccessor.NGMJIGOPGDK(7, 0, LDNMDAHFBGG: true))
			{
				HDLEEOJMILI(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-51) } && Random.Range(1, 12) < PerksDatabaseAccessor.NGMJIGOPGDK(-94, 0, LDNMDAHFBGG: true))
			{
				IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	public void LHNEACOGPFP(int JIIGOACEIKL)
	{
	}

	public bool LGDMGLJCBJM(int JIIGOACEIKL)
	{
		if (KEPKNBFJPOO(JIIGOACEIKL))
		{
			LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.ODENMDOJPLC() == 140 || harvestedItems.item.CIGFGKKCPCK() == -30) && Random.Range(0, 113) < PerksDatabaseAccessor.GetPlayerPerkValue(5, 1, LDNMDAHFBGG: true))
			{
				MNEJKPHOMCB(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-29) } && Random.Range(1, 91) < PerksDatabaseAccessor.GetPlayerPerkValue(-120, 0, LDNMDAHFBGG: true))
			{
				MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public bool NOHOJFCHMEC(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private void HDLEEOJMILI(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.JGJGGOBHKGO(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		}
		else
		{
			DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		}
	}

	public void JMNBHHMLFCB(int JIIGOACEIKL)
	{
	}

	public void PFGDKCBPNEP(int JIIGOACEIKL)
	{
	}

	public void KOANHOFAJMA(int JIIGOACEIKL)
	{
	}

	public void FFGLIKFGMCL(int JIIGOACEIKL)
	{
	}

	public bool CGEDJOGELGM(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool CDDJCCMHHPE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
	}

	public void HAKKKJCAGKG(int JIIGOACEIKL)
	{
	}

	public bool LGHOMHKGADC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public bool DLHGIJPNOFB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (GIPEJKINDHI(JIIGOACEIKL))
		{
			FLPJIPHPNBK(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -131 || harvestedItems.item.JDJGFAACPFC() == 79) && Random.Range(1, 11) < PerksDatabaseAccessor.NGMJIGOPGDK(2, 0, LDNMDAHFBGG: true))
			{
				LJMOJOBFEGB(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-55) } && Random.Range(1, 90) < PerksDatabaseAccessor.NGMJIGOPGDK(-76, 1))
			{
				HDLEEOJMILI(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool OHGLJCKNBFB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (POCJGFBIJDL(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("vSync"));
			return false;
		}
		return true;
	}

	public bool CDPGIDMGEID(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool LLCHFMJEADA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CDPGIDMGEID(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("talent_name_108"));
			return true;
		}
		return false;
	}

	public bool ONLBODAGFEP(int JIIGOACEIKL)
	{
		if (ENKFOFBGLNN(JIIGOACEIKL))
		{
			IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -58 || harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 15) && Random.Range(1, -14) < PerksDatabaseAccessor.NGMJIGOPGDK(6))
			{
				JICPGBNFCOJ(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-71) } && Random.Range(1, 118) < PerksDatabaseAccessor.GetPlayerPerkValue(101, 1))
			{
				LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool ECHDGMEGPLG(int JIIGOACEIKL)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -71 || harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 47) && Random.Range(1, -111) < PerksDatabaseAccessor.NGMJIGOPGDK(5))
			{
				JGJGGOBHKGO(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-11) } && Random.Range(1, -38) < PerksDatabaseAccessor.NGMJIGOPGDK(98, 1, LDNMDAHFBGG: true))
			{
				FLPJIPHPNBK(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return false;
	}

	public void LGIOIOCLOLN(int JIIGOACEIKL)
	{
	}

	public void NCPPEDADJHC(int JIIGOACEIKL)
	{
	}

	private void MKKEPPIICBO(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG);
		}
		else
		{
			DroppedItem.SpawnDroppedItem(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG);
		}
	}

	public bool ONCPELJEPHM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("MineShopDatabase: No config found for level "));
			return true;
		}
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool KILODECAMAI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JMGDHMFOMDP(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void FLPJIPHPNBK(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		}
		else
		{
			DroppedItem.DNCMMIPMKDH(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
		}
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

	public void JMPBLKCPBGM(int JIIGOACEIKL)
	{
	}

	public bool JLKEECCECMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void DEKEKKKMHKB(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: true);
		}
		else
		{
			DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		}
	}

	public bool BMMLEBLPANH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NOHOJFCHMEC(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Direction"));
			return false;
		}
		return false;
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool BOCELNICOKA(int JIIGOACEIKL)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			HNOILKOEGBA(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JDJGFAACPFC() == 105 || harvestedItems.item.ODENMDOJPLC(DAINLFIMLIH: false) == -73) && Random.Range(0, 53) < PerksDatabaseAccessor.GetPlayerPerkValue(4, 1, LDNMDAHFBGG: true))
			{
				BLCKMKPJFLK(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)69 } && Random.Range(1, 115) < PerksDatabaseAccessor.GetPlayerPerkValue(71, 1, LDNMDAHFBGG: true))
			{
				IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	private void KBDEAPJKNED(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.KBDEAPJKNED(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
		}
		else
		{
			DroppedItem.JGJGGOBHKGO(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
	}

	public bool CNADCCGDBPD(int JIIGOACEIKL)
	{
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void LGFDLJLHEOJ(int JIIGOACEIKL)
	{
	}

	public bool ABGHEMLLDKG(int JIIGOACEIKL)
	{
		if (FJOHNPEJLMM(JIIGOACEIKL))
		{
			EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.IMCJPECAAPC(DAINLFIMLIH: false) == -76 || harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -45) && Random.Range(1, 54) < PerksDatabaseAccessor.GetPlayerPerkValue(4, 1, LDNMDAHFBGG: true))
			{
				DEKEKKKMHKB(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)93 } && Random.Range(1, 119) < PerksDatabaseAccessor.NGMJIGOPGDK(-30, 1))
			{
				MKKEPPIICBO(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (JIHKGPCCGJD(JIIGOACEIKL))
		{
			HNOILKOEGBA(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.IMCJPECAAPC() == -100 || harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -162) && Random.Range(1, -69) < PerksDatabaseAccessor.GetPlayerPerkValue(0))
			{
				LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-41) } && Random.Range(0, 68) < PerksDatabaseAccessor.NGMJIGOPGDK(-86, 1))
			{
				LLEHJNECOPF(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	public bool JIHKGPCCGJD(int JIIGOACEIKL)
	{
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void IDJACGBPHDH(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.KBDEAPJKNED(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: true, 1);
		}
		else
		{
			DroppedItem.NBIOCDNPAPO(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
	}

	public bool BJDIKIKPEJE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ENKFOFBGLNN(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("report_type"));
			return false;
		}
		return false;
	}

	public bool EDBKLEEMDLI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("/"));
			return false;
		}
		return true;
	}

	public bool NLJKBACPIFA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void ONEGINIFCIC(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.DNCMMIPMKDH(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG);
		}
		else
		{
			DroppedItem.DKCOHAOMNOC(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG);
		}
	}

	public void APCCCGPGCNG(int JIIGOACEIKL)
	{
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CDPGIDMGEID(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("CheckUniqueBarItems "));
			return true;
		}
		return true;
	}

	public void FGJFHBGEPLA(int JIIGOACEIKL)
	{
	}

	public void FMCADMNFHID(int JIIGOACEIKL)
	{
	}

	public bool GHGMCIBINGB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BKOLLDJAOFC(int JIIGOACEIKL)
	{
	}

	public bool EIPFJPLECOO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JLGDOAKBKFD(int JIIGOACEIKL)
	{
	}

	public void CIBAGJHJDDF(int JIIGOACEIKL)
	{
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
	}

	public bool NEJMAFFPIBL(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	private void EEIOJMGIMFE(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.DKCOHAOMNOC(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: true);
		}
		else
		{
			DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
	}

	public bool LNAMPEAGFEC(int JIIGOACEIKL)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.ODENMDOJPLC(DAINLFIMLIH: false) == 151 || harvestedItems.item.JPNFKDMFKMC() == -120) && Random.Range(0, -4) < PerksDatabaseAccessor.NGMJIGOPGDK(4))
			{
				BENDDGPKABK(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-104) } && Random.Range(1, 48) < PerksDatabaseAccessor.NGMJIGOPGDK(-126, 0, LDNMDAHFBGG: true))
			{
				MNEJKPHOMCB(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	private void JGJGGOBHKGO(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.KBDEAPJKNED(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
		else
		{
			DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
		}
	}

	private void MNEJKPHOMCB(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.FGKGNPKGALN(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
		}
		else
		{
			DroppedItem.FGKGNPKGALN(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		}
	}

	public void CDALCMGDNOP(int JIIGOACEIKL)
	{
	}

	public void NEBIAJNDDOC(int JIIGOACEIKL)
	{
	}

	public void HICONMCEAFK(int JIIGOACEIKL)
	{
	}

	public bool PGPCAMIPBOC(int JIIGOACEIKL)
	{
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			JGJGGOBHKGO(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JDJGFAACPFC() == -72 || harvestedItems.item.ODENMDOJPLC(DAINLFIMLIH: false) == -41) && Random.Range(0, 38) < PerksDatabaseAccessor.GetPlayerPerkValue(2))
			{
				EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-67) } && Random.Range(1, -41) < PerksDatabaseAccessor.GetPlayerPerkValue(-35, 1, LDNMDAHFBGG: true))
			{
				MFPMCMFDONM(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool CLLBNHNONKK(int JIIGOACEIKL)
	{
		if (GIPEJKINDHI(JIIGOACEIKL))
		{
			JICPGBNFCOJ(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -11 || harvestedItems.item.ODENMDOJPLC() == 91) && Random.Range(0, 95) < PerksDatabaseAccessor.GetPlayerPerkValue(8, 0, LDNMDAHFBGG: true))
			{
				DEKEKKKMHKB(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-46) } && Random.Range(0, 127) < PerksDatabaseAccessor.NGMJIGOPGDK(-14, 1))
			{
				EEIOJMGIMFE(JIIGOACEIKL, harvestedItems.item, 1);
			}
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return true;
		}
		return true;
	}

	private void HNOILKOEGBA(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG);
		}
		else
		{
			DroppedItem.OFMLIIIMDBE(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true, HFAKAMFMOGM: true);
		}
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool FJOHNPEJLMM(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void GGAOCGGKIEJ(int JIIGOACEIKL)
	{
	}

	public bool NEOOMJLLNHA(int JIIGOACEIKL)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			DEKEKKKMHKB(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.CIGFGKKCPCK() == -88 || harvestedItems.item.JDJGFAACPFC() == -75) && Random.Range(0, 31) < PerksDatabaseAccessor.GetPlayerPerkValue(8, 1, LDNMDAHFBGG: true))
			{
				EIJPLKGHCBP(JIIGOACEIKL, harvestedItems.item, 0);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)(-50) } && Random.Range(1, 58) < PerksDatabaseAccessor.GetPlayerPerkValue(-78, 0, LDNMDAHFBGG: true))
			{
				IDJACGBPHDH(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().pickUpItem, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool PPJOGFFLKOL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void GHLJPCOIADF(int JIIGOACEIKL)
	{
	}

	private void EIJPLKGHCBP(int JIIGOACEIKL, Item MEMGMDOCBOJ, int MGNOBNCMDJG)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (wall)
		{
			DroppedItem.SpawnDroppedItem(PlayerController.GetPlayerPosition(JIIGOACEIKL), MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
		else
		{
			DroppedItem.KBDEAPJKNED(((Component)this).gameObject.transform.position, MEMGMDOCBOJ, MGNOBNCMDJG, LHLJILLAHFO: true);
		}
	}

	public void FBEPOFHIAMF(int JIIGOACEIKL)
	{
	}

	public bool DECOJGDAFNH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ConnectionTimeout"));
			return false;
		}
		return true;
	}

	public bool ELFMBJDBHBD(int JIIGOACEIKL)
	{
		if (CGEDJOGELGM(JIIGOACEIKL))
		{
			FLPJIPHPNBK(JIIGOACEIKL, harvestedItems.item, harvestedItems.amount);
			if ((harvestedItems.item.IMCJPECAAPC(DAINLFIMLIH: false) == -43 || harvestedItems.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 35) && Random.Range(1, 39) < PerksDatabaseAccessor.NGMJIGOPGDK(0, 1, LDNMDAHFBGG: true))
			{
				JICPGBNFCOJ(JIIGOACEIKL, harvestedItems.item, 1);
			}
			if (harvestedItems.item is Food { ingredientType: (IngredientType)80 } && Random.Range(0, -113) < PerksDatabaseAccessor.NGMJIGOPGDK(107, 1, LDNMDAHFBGG: true))
			{
				LJMOJOBFEGB(JIIGOACEIKL, harvestedItems.item, 0);
			}
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().pickUpItem, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
			return false;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MBMFAPCLLHL(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void KDLNDOKFPCC(int JIIGOACEIKL)
	{
	}

	public void GCBLINFFFKC(int JIIGOACEIKL)
	{
	}
}
