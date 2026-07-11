using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NoticeBoard : MonoBehaviour, IInteractable, ISelectable, IHoverable, IProximity
{
	private static NoticeBoard IADEMLIIDPC;

	public Placeable placeable;

	public static NoticeBoard GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<NoticeBoard>();
			}
			return IADEMLIIDPC;
		}
	}

	public bool EKCPFFOMOCN(int JIIGOACEIKL)
	{
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool FPLPECHEGGI(int JIIGOACEIKL)
	{
		NoticeBoardUI.JHOHGMODKGM(JIIGOACEIKL).CloseUI();
		HireStaffUI.DIMABMEHNNI(JIIGOACEIKL).BOBCIFEDJED();
		OrderQuestUI.FHPEHDDFOIB(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool MGECKEIHEGA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NMAOFEFMNNB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CIAMOMDAKLJ(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BDNPANNEMFF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BBJHICABJPL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OFBABFAOFEJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KPIGMKEFLCG(int JIIGOACEIKL)
	{
		NoticeBoardUI.MDINEPBJFKG(JIIGOACEIKL).CloseUI();
		HireStaffUI.Get(JIIGOACEIKL).BOBCIFEDJED();
		OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool HEGFIAIHPPD(int JIIGOACEIKL)
	{
		return false;
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool DKJMKJKHKNC(int JIIGOACEIKL)
	{
		NoticeBoardUI.LBKJEHDEBEP(JIIGOACEIKL).CloseUI();
		HireStaffUI.GDFNPHJJCPP(JIIGOACEIKL).CloseUI();
		OrderQuestUI.IPDFCJLOHLC(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		NoticeBoardUI.Get(JIIGOACEIKL).CloseUI();
		HireStaffUI.Get(JIIGOACEIKL).CloseUI();
		OrderQuestUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool GACALPOHOLE(int JIIGOACEIKL)
	{
		return true;
	}

	public bool DFNNAJIFOIK(int JIIGOACEIKL)
	{
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool NLFAOKPFHFJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FIJAIBOCHDI(int JIIGOACEIKL)
	{
		if (EDMPHCDAGCE(JIIGOACEIKL))
		{
			if (RandomOrderQuestsManager.JFNOOMJMHCB().LKCNMBAJCHP())
			{
				RandomOrderQuestsManager.GGFJGHHHEJC.GenerateAvailableOrders();
			}
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			NoticeBoardUI.BGIMGOJDLFG(JIIGOACEIKL).OpenUI();
			return false;
		}
		return true;
	}

	public void EKFKDEBFDPA(int JIIGOACEIKL)
	{
	}

	public void FGIBCBOHCEB(int JIIGOACEIKL)
	{
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FHPIBJNKBEN(int JIIGOACEIKL)
	{
	}

	public bool LFDFCDLFNGN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DBEHBEPLCMN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CLNDNLMMECC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_1"));
			return true;
		}
		return true;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public bool NJPFHBINPKE(int JIIGOACEIKL)
	{
		NoticeBoardUI.GJOPJAJJLGN(JIIGOACEIKL).BOBCIFEDJED();
		HireStaffUI.NIDHCIHFOHB(JIIGOACEIKL).BOBCIFEDJED();
		OrderQuestUI.NHOFBAMNELD(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool HBHMGMMNFEO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ICOEHINGKFF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FHDFKMOIKBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ACOAGLHGJFL(int JIIGOACEIKL)
	{
	}

	public bool HMGCKPFAFJL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
	}

	public bool FCCIIBFDFKO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PNBILACHBCP(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JACOGAGOFNG(int JIIGOACEIKL)
	{
		NoticeBoardUI.NDJAMDLOIJL(JIIGOACEIKL).CloseUI();
		HireStaffUI.PNCKAKBBKJL(JIIGOACEIKL).CloseUI();
		OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool DBIPJGJPBHP(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool ADBMLAHFDKF(int JIIGOACEIKL)
	{
		NoticeBoardUI.FHBIFJNCOAI(JIIGOACEIKL).BOBCIFEDJED();
		HireStaffUI.OMCDJAOBFCE(JIIGOACEIKL).CloseUI();
		OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool MIOGLCOPGGA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JMGDHMFOMDP(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool BEGCHMCDPOK(int JIIGOACEIKL)
	{
		NoticeBoardUI.NJOFJHCKGAL(JIIGOACEIKL).BOBCIFEDJED();
		HireStaffUI.PKNHLBOHEDL(JIIGOACEIKL).CloseUI();
		OrderQuestUI.MIFFCOMDIEE(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	[SpecialName]
	public static NoticeBoard NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<NoticeBoard>();
		}
		return IADEMLIIDPC;
	}

	public bool OAFFHDOIDKO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool HCHMAIEMAGA(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool LMKKMOCGOOO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DMPFKNFCNLH(int JIIGOACEIKL)
	{
		return true;
	}

	public void FIECAFNFCDM(int JIIGOACEIKL)
	{
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool GBGCHNBJBFG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LNPNMIGHCCH(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("quest_name_24"));
			return true;
		}
		return true;
	}

	private void JDAMCMODANB()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public bool NNACBJKBKDP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool OHEALCKCADA(int JIIGOACEIKL)
	{
		return true;
	}

	public void KCMEKGJPNAO(int JIIGOACEIKL)
	{
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JMGDHMFOMDP(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("LE_1"));
			return false;
		}
		return false;
	}

	public bool GAAPPACMBNO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BDCIGELBCNJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IPOBMHIPCAC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public void ODLBJAGGAFM(int JIIGOACEIKL)
	{
	}

	public bool JIHFNGMCBOB(int JIIGOACEIKL)
	{
		if (LNPNMIGHCCH(JIIGOACEIKL))
		{
			if (RandomOrderQuestsManager.HLMGBEGEAPC().HasToGenerateAvailableOrders())
			{
				RandomOrderQuestsManager.GGFJGHHHEJC.FEIKEEMJMHJ();
			}
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			NoticeBoardUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return false;
	}

	[SpecialName]
	public static NoticeBoard POINNCPMEIG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<NoticeBoard>();
		}
		return IADEMLIIDPC;
	}

	public void KMAPBDCGIDK(int JIIGOACEIKL)
	{
	}

	public bool JLBADAPMLEH(int JIIGOACEIKL)
	{
		return false;
	}

	public void FECPHPJAEAE(int JIIGOACEIKL)
	{
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
	}

	public bool MJBBIIAOLPC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IDNELGLNMJO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (RandomOrderQuestsManager.GGFJGHHHEJC.HasToGenerateAvailableOrders())
			{
				RandomOrderQuestsManager.GGFJGHHHEJC.GenerateAvailableOrders();
			}
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			NoticeBoardUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	[SpecialName]
	public static NoticeBoard KFGKCKCDMLG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<NoticeBoard>();
		}
		return IADEMLIIDPC;
	}

	public bool ENKFOFBGLNN(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("mForMins"));
			return true;
		}
		return true;
	}

	private void MFJIHCKEIIF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EKCPFFOMOCN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("\n"));
			return true;
		}
		return false;
	}

	public bool ELJEJOADKCI(int JIIGOACEIKL)
	{
		return true;
	}

	public void LGOPNIBHMIA(int JIIGOACEIKL)
	{
	}

	public bool KGPDHFFEDKP(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JJNCCBKOBOD(int JIIGOACEIKL)
	{
		NoticeBoardUI.FFOABBDFMNE(JIIGOACEIKL).BOBCIFEDJED();
		HireStaffUI.NIDHCIHFOHB(JIIGOACEIKL).CloseUI();
		OrderQuestUI.OMCDJAOBFCE(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void KDGHNDFNHNC(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool OPAGNKBJKHO(int JIIGOACEIKL)
	{
		return true;
	}

	private void GGOPCJOAOMC()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public bool JHHLEFJFDCM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool ABGHEMLLDKG(int JIIGOACEIKL)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			if (RandomOrderQuestsManager.HLMGBEGEAPC().LPFJHFLPCOB())
			{
				RandomOrderQuestsManager.JFNOOMJMHCB().GenerateAvailableOrders();
			}
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			NoticeBoardUI.AIMEAJAHLAA(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return true;
	}

	public bool NCLHJLNBJIL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LNPNMIGHCCH(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool HEBIALAMFPC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool ALMMEPANOOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool JHJFAKBEMAE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DFNNAJIFOIK(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Button index hasn't been set up properly."));
			return false;
		}
		return true;
	}

	private void MFGANCCJFJK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LNPNMIGHCCH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/5/Dialogue Text"));
			return false;
		}
		return false;
	}

	public bool GGFLHCNGPDK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool HHJKCBGJABC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool JMLDNFCFNED(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IPMKECFJOHB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EDMPHCDAGCE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("is_master"));
			return false;
		}
		return false;
	}

	public void CLHGAEEHEAB(int JIIGOACEIKL)
	{
	}

	public void APCCCGPGCNG(int JIIGOACEIKL)
	{
	}

	private void FBHHPNJGNJG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public bool FBOJGDCJJLG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EIKPGOMHKOH(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Selected"));
			return true;
		}
		return true;
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

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void BKBHDKKPJBM(int JIIGOACEIKL)
	{
	}
}
