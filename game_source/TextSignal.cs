using UnityEngine;

public class TextSignal : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public string signalText;

	public bool HEBIALAMFPC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IJOAKPKLADE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CGEDJOGELGM(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveStopWork"));
			return false;
		}
		return false;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
	}

	public void EMPAIGBCKNH(int JIIGOACEIKL)
	{
	}

	public void HPLHMNAIEMF(int JIIGOACEIKL)
	{
	}

	public bool NNACBJKBKDP(int JIIGOACEIKL)
	{
		return true;
	}

	public void DLBNJPKKNDN(int JIIGOACEIKL)
	{
	}

	public void PGBNILBKPED(int JIIGOACEIKL)
	{
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
	}

	public void ANHBEBGBDAG(int JIIGOACEIKL)
	{
	}

	public void MLMDECNIDLP(int JIIGOACEIKL)
	{
	}

	public void KPIDKAPMBLC(int JIIGOACEIKL)
	{
	}

	public bool LMHMCNOBAGE(int JIIGOACEIKL)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			TextSignalUI.PHDBJGOEKHB(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.IEABDMDELFO(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JOHOFKOAIBD(int JIIGOACEIKL)
	{
	}

	public void FHKALEIKPNC(int JIIGOACEIKL)
	{
	}

	public void NAKPCICILDA(int JIIGOACEIKL)
	{
	}

	public void GLFGADGGGOM(int JIIGOACEIKL)
	{
	}

	public void EJGAIPBFJBM(int JIIGOACEIKL)
	{
	}

	public void LDKNMDBCKFJ(int JIIGOACEIKL)
	{
	}

	public void LJLHGJDHFOJ(int JIIGOACEIKL)
	{
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void MCBHIOOAIAM(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool LPKCIENGJMN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BEBLOHAFHNO(int JIIGOACEIKL)
	{
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IGLEJFFHKLE(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OJPJMNJLLKM(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_description_1187"));
			return true;
		}
		return false;
	}

	public bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Tutorial/T111/Dialogue1"));
			return true;
		}
		return false;
	}

	public bool LEFHAOJHCBH(int JIIGOACEIKL)
	{
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool KAPFKOCOOCO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			TextSignalUI.AEJKCONFPHB(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.IEKODILKIHJ(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return true;
	}

	public void AOFPMOPONPH(int JIIGOACEIKL)
	{
	}

	public void IHIIIPGGPPF(int JIIGOACEIKL)
	{
	}

	public bool JENFOIFJOPF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OJPJMNJLLKM(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void MMDJIDCALJB(int JIIGOACEIKL)
	{
	}

	public bool HNMOLFHKBGE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (OHKCPGKPDGJ(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(".png"));
			return false;
		}
		return true;
	}

	public bool CGEDJOGELGM(int JIIGOACEIKL)
	{
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool EBMAMAPEJPD(int JIIGOACEIKL)
	{
		return true;
	}

	public bool APFAKKDDFIK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KBLEJDFHIHJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dropped item "));
			return false;
		}
		return true;
	}

	public void BLDCOHEMFIK(int JIIGOACEIKL)
	{
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		if (CGEDJOGELGM(JIIGOACEIKL))
		{
			TextSignalUI.IEABDMDELFO(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.NIGDBMAOAEN(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public void LLDNEDJJOGF(int JIIGOACEIKL)
	{
	}

	public bool CFLDFKODIKL(int JIIGOACEIKL)
	{
		if (HGAJIMIGBIH(JIIGOACEIKL))
		{
			TextSignalUI.DPBGKDNKDGM(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.NDPAJCGHGOB(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return false;
	}

	public void NDJHJHJBPHC(int JIIGOACEIKL)
	{
	}

	public void GHAHHGPDNNH(int JIIGOACEIKL)
	{
	}

	public void OONFAEHPEFI(int JIIGOACEIKL)
	{
	}

	public void BEMEBLIDBGA(int JIIGOACEIKL)
	{
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool IGFOEIKMMGE(int JIIGOACEIKL)
	{
		return false;
	}

	public void BIOBJGPKAAG(int JIIGOACEIKL)
	{
	}

	public bool COIGDMKGFCM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void NOAIKDADPBD(int JIIGOACEIKL)
	{
	}

	public bool FJPJAEKLDJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FMCADNOBGKP(int JIIGOACEIKL)
	{
		return true;
	}

	public void KMAPBDCGIDK(int JIIGOACEIKL)
	{
	}

	public bool MGJJNHMOJHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FGIJLMGFNMM(int JIIGOACEIKL)
	{
	}

	public bool DLEDGMKGACB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGLEJFFHKLE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Hay {0} destructibles y {1} agujeros para cavar disponibles para el puzzle {2}"));
			return true;
		}
		return true;
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	public bool NPJLDBMBILF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool PAGLJJJCFJN(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			TextSignalUI.HJHCKIAKCKD(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.IMLMJAPMBJA(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return false;
	}

	public void DJODLMDOBOH(int JIIGOACEIKL)
	{
	}

	public void PCKGLEPBNFE(int JIIGOACEIKL)
	{
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public void PLKFEPAHAEK(int JIIGOACEIKL)
	{
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool HANKOEKCNJN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public bool GABJJKAPBMJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool AEPCKAPLLJP(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool LKLOBCHCMJE(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PHJECBNCAAG(int JIIGOACEIKL)
	{
		if (IALLCPMIGDP(JIIGOACEIKL))
		{
			TextSignalUI.DPBGKDNKDGM(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.DPBGKDNKDGM(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return false;
	}

	public bool EIILHMGPLLL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool BDNKFLJNNEL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			TextSignalUI.Get(JIIGOACEIKL).signalText = signalText;
			TextSignalUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public bool AGDJBEKJHMD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MJIDLPCLAGP(int JIIGOACEIKL)
	{
	}

	public void CPMBHEGDAMB(int JIIGOACEIKL)
	{
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Read"));
			return true;
		}
		return false;
	}

	public void LJOLGDBKLGH(int JIIGOACEIKL)
	{
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HGAJIMIGBIH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("PirateMinigame/Lose2"));
			return false;
		}
		return false;
	}

	public bool EEIIGMFEPBG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}
}
