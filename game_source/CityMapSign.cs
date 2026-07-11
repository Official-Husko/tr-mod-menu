using System;
using UnityEngine;

public class CityMapSign : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	[SerializeField]
	private int currentLocationInt;

	[SerializeField]
	private GameObject bubbleContainer;

	private void IJNPEAAOOEK()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.IBPMLOKIKDN((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	public bool FHNNADMKNOD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Ach_"));
			return true;
		}
		return false;
	}

	public bool CLLBNHNONKK(int JIIGOACEIKL)
	{
		if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI())
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("ReceiveSelectPerkLevelMaster"), 710f);
			return true;
		}
		CityMapUI.BGIMGOJDLFG(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = true;
			DEOGJOACJLF(DAEMAAOLHMG: false);
		}
		CityMapUI.BGIMGOJDLFG(JIIGOACEIKL).OpenUI();
		return true;
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	public bool HEBIALAMFPC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
	}

	public bool BDNKFLJNNEL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void HNOFLLABDEF(int JIIGOACEIKL)
	{
	}

	public void GHLJPCOIADF(int JIIGOACEIKL)
	{
	}

	private void MCGEAIGBFDA(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool IBHGEIHOJLB(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool FHFFNFECPKB(int JIIGOACEIKL)
	{
		if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI())
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Bird sprite info not found with ID "), 724f);
			return false;
		}
		CityMapUI.BGIMGOJDLFG(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = false;
			OEIPIDIHJHE(DAEMAAOLHMG: true);
		}
		CityMapUI.CJMILOMGFJL(JIIGOACEIKL).EDHEIFHAAKO();
		return false;
	}

	private void JACHAKNGMAA(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool DIDPBPLLHCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KCMHBADACDJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/10/Dialogue Text"));
			return false;
		}
		return true;
	}

	public bool JAELLHFFLKO(int JIIGOACEIKL)
	{
		if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD())
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("OnlinePlayer"), 561f);
			return false;
		}
		CityMapUI.AEJKCONFPHB(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = false;
			LMLMKCEMFOG(DAEMAAOLHMG: false);
		}
		CityMapUI.PNCKAKBBKJL(JIIGOACEIKL).EDHEIFHAAKO();
		return true;
	}

	private void FNKKICLLGIH(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	private void APEIPGIHEKP()
	{
		HMMNAJMIFLB(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	private void JIBHLLJGGEN()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.CreateArrayIfNull((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	private void AFGJLAACCFN()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.NCIPDIGBFCJ(NewActivityBubbleManager.BoolArrayType.CityMapBubbles);
		}
	}

	private void LFBIFPBPDMJ()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.MCCACHFODLP(NewActivityBubbleManager.BoolArrayType.CityMapBubbles);
		}
	}

	public bool GHGMCIBINGB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void BJKEEOEEEHH(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool OLCIHEGGHDE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	private void LOMMOKMDEBL(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public void HLNEGJCBPOA(int JIIGOACEIKL)
	{
	}

	public void LFDBCGGIPOM(int JIIGOACEIKL)
	{
	}

	public void BBIAGBIAELE(int JIIGOACEIKL)
	{
	}

	private void HJFJNICPMLD(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(")"));
			return true;
		}
		return true;
	}

	public bool ABMFEAKMFII(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JMAABPOGHCI(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			return false;
		}
		return true;
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
		DEOGJOACJLF(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	public bool DGNGLGMBIHE(int JIIGOACEIKL)
	{
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Read"));
			return true;
		}
		return false;
	}

	private void FMGKCNPMONH(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
	}

	private void MMANKOFCDGO()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.COEMAGLIIGJ((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	public void AOLIDLGHMED(int JIIGOACEIKL)
	{
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
	}

	private void OnEnable()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.CreateArrayIfNull(NewActivityBubbleManager.BoolArrayType.CityMapBubbles);
		}
	}

	public bool OADMPCPHMDK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("SetNPCPosition"));
			return false;
		}
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FOGLDLKAEBK(int JIIGOACEIKL)
	{
	}

	public void DAFFDEDGGCL(int JIIGOACEIKL)
	{
	}

	public void HDLGAPIAEPP(int JIIGOACEIKL)
	{
	}

	private void DEOGJOACJLF(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public void IMMNGGOJINO(int JIIGOACEIKL)
	{
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private void ILLODOAKEKA(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && OBDFGODGIFN(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Beer"));
			return true;
		}
		return false;
	}

	public bool KILODECAMAI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
			return false;
		}
		CityMapUI.Get(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = false;
			DEOGJOACJLF(DAEMAAOLHMG: false);
		}
		CityMapUI.Get(JIIGOACEIKL).OpenUI();
		return true;
	}

	public bool COPFMLIIOOB(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool BCCPGMBMOMM(int JIIGOACEIKL)
	{
		if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("BarnTutorialDone"), 815f);
			return true;
		}
		CityMapUI.NDPAJCGHGOB(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = true;
			MNGPNGOGIBG(DAEMAAOLHMG: false);
		}
		CityMapUI.AKMJEPMHFMO(JIIGOACEIKL).IDLAGJNLPJL();
		return true;
	}

	public void EBMLHKMPGHL(int JIIGOACEIKL)
	{
	}

	public bool OHAPPHKCAFH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void PCHLPDOHNMJ(int JIIGOACEIKL)
	{
	}

	public bool CGEDJOGELGM(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void LMLMKCEMFOG(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	private void HFIHGHBLLAM()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.BOMFDBDDDAJ((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	public bool LOOGAHBFNLA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && COPFMLIIOOB(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Hikari/Stand"));
			return true;
		}
		return true;
	}

	private void FJFLGDADEKM()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.NHDDAEEHKGI((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	public bool BMLBGBOIOCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	public void DCJPIGEHCJL(int JIIGOACEIKL)
	{
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public void PIJCFKHFBED(int JIIGOACEIKL)
	{
	}

	private void DCKKIDMJKJM()
	{
		MNGPNGOGIBG(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	public bool JMAABPOGHCI(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI();
	}

	private void EEKOJEKPIMP()
	{
		DEOGJOACJLF(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	public bool FBCDEMIAKBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(", Property: "));
			return false;
		}
		return true;
	}

	private void GDLAHKEMJFN()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.CreateArrayIfNull((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	public bool OOLNLKPJIML(int JIIGOACEIKL)
	{
		if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI())
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get(""), 404f);
			return true;
		}
		CityMapUI.NIDHCIHFOHB(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = true;
			BJAFCJNOBHD(DAEMAAOLHMG: false);
		}
		CityMapUI.OMCDJAOBFCE(JIIGOACEIKL).OpenUI();
		return false;
	}

	private void BJAFCJNOBHD(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool AKDMFCNENBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IBHGEIHOJLB(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Miners/Camp/Rochelle/Talk"));
			return true;
		}
		return false;
	}

	public bool DKLAKIBJKID(int JIIGOACEIKL)
	{
		if (DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND())
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Selected Room: {0}"), 1810f);
			return false;
		}
		CityMapUI.CJMILOMGFJL(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = false;
			OEIPIDIHJHE(DAEMAAOLHMG: true);
		}
		CityMapUI.DPBGKDNKDGM(JIIGOACEIKL).OpenUI();
		return false;
	}

	public bool FNLBGGPKFLJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EDMPHCDAGCE(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("City/Amos/Bark/Buy"));
			return false;
		}
		return true;
	}

	private void HMMNAJMIFLB(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public void GHPDDHHKFIO(int JIIGOACEIKL)
	{
	}

	private void MNGPNGOGIBG(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EIILHMGPLLL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EAIOPONBJJK(int JIIGOACEIKL)
	{
		if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("tutorialPopUp81"), 1988f);
			return false;
		}
		CityMapUI.Get(JIIGOACEIKL).playerLocationInt = currentLocationInt;
		if (NewActivityBubbleManager.cityMapBubbles[currentLocationInt])
		{
			NewActivityBubbleManager.cityMapBubbles[currentLocationInt] = true;
			OEIPIDIHJHE(DAEMAAOLHMG: false);
		}
		CityMapUI.PHDBJGOEKHB(JIIGOACEIKL).IDLAGJNLPJL();
		return true;
	}

	private void MLLADNLMIMP()
	{
		LMLMKCEMFOG(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	public void KJOEENPNEOC(int JIIGOACEIKL)
	{
	}

	private void IAAGKLPMAMK()
	{
		FNKKICLLGIH(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	public void IFOGDEJAFKA(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool KCMHBADACDJ(int JIIGOACEIKL)
	{
		return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void MCKPOBDBMED(int JIIGOACEIKL)
	{
	}

	public void KECJNJANCEK(int JIIGOACEIKL)
	{
	}

	private void ICBCMLAIIPF()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.NCIPDIGBFCJ((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	public void HPLHMNAIEMF(int JIIGOACEIKL)
	{
	}

	private void KAANJGEDPIN()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.COEMAGLIIGJ((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	private void OEIPIDIHJHE(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	private void IEKMCPGBAGB(bool DAEMAAOLHMG)
	{
		bubbleContainer.SetActive(DAEMAAOLHMG);
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	private void CMLLBIDFNEB()
	{
		BJKEEOEEEHH(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	private void CCJOOMDHMKM()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.NHDDAEEHKGI((NewActivityBubbleManager.BoolArrayType)1);
		}
	}

	private void HOFKJPBBLGP()
	{
		BJAFCJNOBHD(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	private void MEFFGGKAALB()
	{
		if (NewActivityBubbleManager.cityMapBubbles == null || NewActivityBubbleManager.cityMapBubbles.Length == 0)
		{
			NewActivityBubbleManager.IBPMLOKIKDN(NewActivityBubbleManager.BoolArrayType.CityMapBubbles);
		}
	}

	private void HNEGFBCKIIJ()
	{
		LOMMOKMDEBL(NewActivityBubbleManager.cityMapBubbles[currentLocationInt]);
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}
}
