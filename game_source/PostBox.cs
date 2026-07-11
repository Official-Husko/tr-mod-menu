using System;
using UnityEngine;

public class PostBox : MonoBehaviour, IInteractable, ISelectable, IHoverable, IProximity
{
	[Serializable]
	public struct LetterSaveData
	{
		public int letterID;

		public bool read;

		public GameDate receivedDate;

		public LetterSaveData(int DNNMJAGMDPA, bool LKAALEJKLPA, GameDate PABKJKLPPOP)
		{
			letterID = DNNMJAGMDPA;
			read = LKAALEJKLPA;
			receivedDate = PABKJKLPPOP;
		}
	}

	public static PostBox instance;

	public GameObject unreadIcon;

	public bool LIDJEBPBDAH(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	public bool JKDKJKNLIDC(int JIIGOACEIKL)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void EEGJKMOHGKI(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	private void KLHIMJFCHPD()
	{
		instance = this;
	}

	public bool MDKIMCGNKMF(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HEOEEFNLJMO(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool ECPCDLJHOEL(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool KJFFGGMPCPI(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool LHMEENAPJBF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool AGDJBEKJHMD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ALBEDNOIEJF(int JIIGOACEIKL)
	{
	}

	public bool JJNJBEEIFFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool LMHMCNOBAGE(int JIIGOACEIKL)
	{
		if (DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("DemolishConfirmationWithAnimals"), 1509f);
			return true;
		}
		PostboxUI.FHKGDLNJFFA(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public void GJKMPLHIDFC(int JIIGOACEIKL)
	{
	}

	public void NEJHEEBHJGL(int JIIGOACEIKL)
	{
	}

	public void BKAGIMELGOD(int JIIGOACEIKL)
	{
	}

	public bool FHFFNFECPKB(int JIIGOACEIKL)
	{
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM())
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("ReceiveTorchPuzzle"), 1755f);
			return false;
		}
		PostboxUI.BMFHCBOFHCN(JIIGOACEIKL).EDHEIFHAAKO();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool IPMAMGLMJJL(int JIIGOACEIKL)
	{
		return false;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool HBGEIMCOPLO(int JIIGOACEIKL)
	{
		return true;
	}

	public void NCPPEDADJHC(int JIIGOACEIKL)
	{
	}

	public void DNAOIIDKFOB(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	public void ShowUnreadLetterIcon(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	private void BNFGHAGJEGG()
	{
		instance = this;
	}

	public bool MKLHOPOEFIH(int JIIGOACEIKL)
	{
		return true;
	}

	public void CCGMBIPHNKK(int JIIGOACEIKL)
	{
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		PostboxUI.Get(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool IJAGNIKIGHK(int JIIGOACEIKL)
	{
		PostboxUI.Get(JIIGOACEIKL).CloseUI();
		return false;
	}

	public bool NGOMFMMBEEB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool LNPNMIGHCCH(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void NEIBJLCMDGK(int JIIGOACEIKL)
	{
	}

	public bool KLMKCGCHGOA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool GLMIPLOGIBB(int JIIGOACEIKL)
	{
		PostboxUI.Get(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool EEIIGMFEPBG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MKGJOJNIICA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool FEANOONDHBB(int JIIGOACEIKL)
	{
		return true;
	}

	public void IJOLGGHJPMD(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	public bool CHPHOHKPIMD(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DMFBDCCJKMD(int JIIGOACEIKL)
	{
		return false;
	}

	public void AHALAGKBJGK(int JIIGOACEIKL)
	{
	}

	public bool DPFFFEGPJDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	private void HFPDNCBLNDE()
	{
		instance = this;
	}

	public bool KNGDGMPGEBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public bool MIOGLCOPGGA(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OPAADDGNEBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HPPHMKMDKEG(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Key: "));
			return true;
		}
		return true;
	}

	public void PLCEPEDKHLO(int JIIGOACEIKL)
	{
	}

	public bool ALPPCGLKHIO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool GCBJNGNEIFH(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EKKKHOHJONB(int JIIGOACEIKL)
	{
		return false;
	}

	public void EBKDIPOKIGI(int JIIGOACEIKL)
	{
	}

	public bool NEPPDGMOLAN(int JIIGOACEIKL)
	{
		PostboxUI.CGFJPHEFFLO(JIIGOACEIKL).CloseUI();
		return false;
	}

	public void GOGMEIBKKMK(int JIIGOACEIKL)
	{
	}

	public bool EPIFGKEFKGN(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MCGLIBHNMNH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HMEKGMOLBPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JJDJIMEDDLM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HPPHMKMDKEG(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("add item "));
			return true;
		}
		return true;
	}

	public bool CDDJCCMHHPE(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EAIOPONBJJK(int JIIGOACEIKL)
	{
		if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DFNMDDHOIJI())
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("buildModeActive"), 533f);
			return true;
		}
		PostboxUI.CGFJPHEFFLO(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool JEHOCIKPEJD(int JIIGOACEIKL)
	{
		if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("HorizontalMove"), 827f);
			return false;
		}
		PostboxUI.ODLPIANFFFJ(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public void FALDJPENKME(int JIIGOACEIKL)
	{
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HEOEEFNLJMO(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("/"));
			return true;
		}
		return false;
	}

	private void Awake()
	{
		instance = this;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
			return false;
		}
		PostboxUI.Get(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public void APCCCGPGCNG(int JIIGOACEIKL)
	{
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void PEOILAGPJNB(int JIIGOACEIKL)
	{
	}

	public void GAAIKGDMDKA(int JIIGOACEIKL)
	{
	}

	public bool IPOBMHIPCAC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HPPHMKMDKEG(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EIILHMGPLLL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GPEFHJHBNMP(int JIIGOACEIKL)
	{
		PostboxUI.DPBGKDNKDGM(JIIGOACEIKL).CloseUI();
		return false;
	}

	public bool PJPJMNAKNMO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool KJBBKMJDOFN(int JIIGOACEIKL)
	{
		return true;
	}

	public void LBHLEDFPLKD(int JIIGOACEIKL)
	{
	}

	public void JOMGAPOBEKC(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	public bool OIICHHNIBMC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JNBMEKDINDD(int JIIGOACEIKL)
	{
		return true;
	}

	public void DMEHDJBOOLN(int JIIGOACEIKL)
	{
	}

	public bool CDGCNOPBJPD(int JIIGOACEIKL)
	{
		if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE())
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Pull beer"), 18f);
			return false;
		}
		PostboxUI.FHKGDLNJFFA(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool KIPFGMENOEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void CLDGNBLJHJD(int JIIGOACEIKL)
	{
	}

	public bool HCBDMHPHBGL(int JIIGOACEIKL)
	{
		PostboxUI.CGFJPHEFFLO(JIIGOACEIKL).CloseUI();
		return false;
	}

	public void FFPNCCAJLJC(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	public bool GOFABLBNKOF(int JIIGOACEIKL)
	{
		if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM())
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("ReceiveInfoTerrain"), 714f);
			return false;
		}
		PostboxUI.HEGPDGJEOPC(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JGAKCPNGEFG(int JIIGOACEIKL)
	{
		return true;
	}

	public void EKFKDEBFDPA(int JIIGOACEIKL)
	{
	}

	public bool MCPGDCCHEHM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NNIGPOBLKFE(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OFMJFMILDJP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PMANGHBFCEA(int JIIGOACEIKL)
	{
		return false;
	}

	public void BIOBJGPKAAG(int JIIGOACEIKL)
	{
	}

	public bool OBJNIJNNCHH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).KNFEPKBIHND())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Player2"), 650f);
			return true;
		}
		PostboxUI.FHKGDLNJFFA(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool KLIPHFPAHHN(int JIIGOACEIKL)
	{
		return false;
	}

	public void FJFCJPPODFP(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool KNOAMKONOOP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FEEOBEFKDCJ(bool BGHGNCLGKDH)
	{
		unreadIcon.SetActive(BGHGNCLGKDH);
	}

	public void LEILHFNBDJP(int JIIGOACEIKL)
	{
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
	}

	public bool GHGMCIBINGB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BEDJMEFHKCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HEOEEFNLJMO(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("bomb materials"));
			return false;
		}
		return false;
	}

	public bool MNHPDNLNAAB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EHKMJKELCIP(int JIIGOACEIKL)
	{
		return true;
	}

	public bool EDDDDEJIEHC(int JIIGOACEIKL)
	{
		return true;
	}

	private void MJOLEIMPOGI()
	{
		instance = this;
	}

	public void KPIDKAPMBLC(int JIIGOACEIKL)
	{
	}

	public bool PJBBLEGMBAK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool LDFBAJAHNLA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).IBEFDKHFBFM();
	}
}
