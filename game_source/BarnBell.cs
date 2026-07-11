using System;
using AlmenaraGames;
using UnityEngine;

public class BarnBell : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[SerializeField]
	private Barn barn;

	[SerializeField]
	private Animator animator;

	private float HKEHMPACMLP;

	public bool HPIDOPAOHFD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("GB"));
			return false;
		}
		return false;
	}

	public bool MAKEFKOJEDH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EIPFJPLECOO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void FABHKGGMBFJ(int JIIGOACEIKL)
	{
	}

	public void OHONHNNDOKC(int JIIGOACEIKL)
	{
	}

	public bool JNOMKJLMPKK(int JIIGOACEIKL)
	{
		if (GKIIBGDJDID(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN();
			return false;
		}
		return false;
	}

	public void EDKAJNBJAJK(int JIIGOACEIKL)
	{
	}

	public bool NEJMAFFPIBL(int JIIGOACEIKL)
	{
		if (!DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DFNMDDHOIJI())
		{
			return KDGIFIICMEE();
		}
		return true;
	}

	public void ODHDEOHBCHD(int JIIGOACEIKL)
	{
	}

	public bool OBHILJEDGFC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FBICEOPOOJA(int JIIGOACEIKL)
	{
		if (MAEPPEIGMNI(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN(NODEDANJBFL: false);
			return false;
		}
		return true;
	}

	public bool CanToggle()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 3f;
	}

	public void DFAJLDCMCDG(int JIIGOACEIKL)
	{
	}

	public void CIFCLGHEGIH(int JIIGOACEIKL)
	{
	}

	public bool FOGOIMCKFPB()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1073f;
	}

	public bool HNOBEBHAOLF()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 541f;
	}

	public void FJOOIFLCOPF(int JIIGOACEIKL)
	{
	}

	public void NFHELMHFNAB(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Festín del Juramento/GolpeKlayn");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().bell, ((Component)this).transform);
		}
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		if (ODGHAJBBNJA(JIIGOACEIKL))
		{
			barn.HKKINCHIIPB();
			return true;
		}
		return false;
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public void IKIOFHCOJLJ(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Left Alt");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().bell, ((Component)this).transform);
		}
	}

	public bool KDGIFIICMEE()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1848f;
	}

	public void MBMFAPCLLHL(int JIIGOACEIKL)
	{
	}

	public void BKAGIMELGOD(int JIIGOACEIKL)
	{
	}

	public bool GELKHLINLDN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool HINGCLJLHJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MAIKIONBICN(int JIIGOACEIKL)
	{
	}

	public bool NCDNGJMMEDG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Action"));
			return true;
		}
		return true;
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	public bool CDAGHGPLFAP()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 488f;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void POHNLHHIKJL(int JIIGOACEIKL)
	{
	}

	public bool EHJJFIKNGAF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool HEHFGHDILPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool NJJBCPMDBNG(int JIIGOACEIKL)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN(NODEDANJBFL: false);
			return false;
		}
		return false;
	}

	public bool OHAPPHKCAFH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void IBCOIILOIOH(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("particleSystem not attached to ");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().bell, ((Component)this).transform);
		}
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Player left with left piece in inventory, dropping it on the ground."));
			return true;
		}
		return false;
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		if (!DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return CanToggle();
		}
		return true;
	}

	public void OIFFMFHJPCA(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().bell, ((Component)this).transform);
		}
	}

	public bool PBFFNPMGOHN()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1980f;
	}

	public bool ABMFEAKMFII(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KDGAIGKBPAC(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ClosePopUp"));
			return false;
		}
		return false;
	}

	public void ToggleSign(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Ring");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.bell, ((Component)this).transform);
		}
	}

	public bool HJNKEKBANED(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EKCPFFOMOCN(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return LANOMNGNDJK();
		}
		return true;
	}

	public void DLNKJFAHGEL(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Repair");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().bell, ((Component)this).transform);
		}
	}

	public void JEEKGCIBKFI(int JIIGOACEIKL)
	{
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public bool LIMJJHPMCEA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void CLEGPMHKPBI(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("descWardrobe");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().bell, ((Component)this).transform);
		}
	}

	public void CDGCGOBLBMI(int JIIGOACEIKL)
	{
	}

	public bool NCMFIAHEIOH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void OLDNHHHLOMJ(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("add item 1445 20");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().bell, ((Component)this).transform);
		}
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool EDHDKEDCDIH()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 223f;
	}

	public void LBJGLBACCHG(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Bob");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().bell, ((Component)this).transform);
		}
	}

	public bool DIDPBPLLHCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ENKFOFBGLNN(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("WoodWorkshop"));
			return false;
		}
		return false;
	}

	public bool KMJDKHCLMJF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("HalloweenEvent"));
			return false;
		}
		return true;
	}

	public bool BGOGFOBCPLA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JLDADMHPLCH(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Hoppy");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().bell, ((Component)this).transform);
		}
	}

	public void DFFCCILMAHN(int JIIGOACEIKL)
	{
	}

	public bool LKGBMHHAOCH()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1210f;
	}

	public bool IPKMPMJJGDA()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 267f;
	}

	public void HGLIICHGPHH(int JIIGOACEIKL)
	{
	}

	public void FNCEDKIKCPD(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger(" has null in variant objects list.");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().bell, ((Component)this).transform);
		}
	}

	public void IPBDAEGCBHN(int JIIGOACEIKL)
	{
	}

	public void KHDOBOECCFF(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Interact");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().bell, ((Component)this).transform);
		}
	}

	public bool FJPJAEKLDJF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool BDEEAGGBHCE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool ELFMBJDBHBD(int JIIGOACEIKL)
	{
		if (GKIIBGDJDID(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN();
			return false;
		}
		return true;
	}

	public void PDNBKMFAFHL(int JIIGOACEIKL)
	{
	}

	public void FMOHBOADLFI(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("Bob");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().bell, ((Component)this).transform);
		}
	}

	public void JHNPGLNAFNL(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			barn.ToggleOpen();
			return true;
		}
		return false;
	}

	public bool IBOEFLNLLOO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool DDKLIFBPKBF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool KDGAIGKBPAC(int JIIGOACEIKL)
	{
		if (!DecorationMode.KKJABELKCNM(JIIGOACEIKL).GABNNLJOMHI())
		{
			return DEHPHHGHCMA();
		}
		return true;
	}

	public bool AGEAECKHJJB()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 1912f;
	}

	public bool ODAPLEDBOEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool LANOMNGNDJK()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1858f;
	}

	public void BADKJIOLGED(int JIIGOACEIKL)
	{
	}

	public bool MGLPIBNJLKC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ENKFOFBGLNN(int JIIGOACEIKL)
	{
		if (!DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return MMHGMDILKLL();
		}
		return false;
	}

	public bool FBODGFKDBCD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MAEPPEIGMNI(int JIIGOACEIKL)
	{
		if (!DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return HNOBEBHAOLF();
		}
		return false;
	}

	public bool OFNDBHLFIEK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public bool CEPOMEBIFBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_name_1046"));
			return true;
		}
		return true;
	}

	public bool FNLBGGPKFLJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KDGAIGKBPAC(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("UI2"));
			return true;
		}
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void JLGDOAKBKFD(int JIIGOACEIKL)
	{
	}

	public void KCKAEPDIGDH(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger("ReceiveSetLife");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().bell, ((Component)this).transform);
		}
	}

	public bool DEHPHHGHCMA()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 596f;
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (KDGAIGKBPAC(JIIGOACEIKL))
		{
			barn.ToggleOpen();
			return false;
		}
		return true;
	}

	public void OGAGMFKPFAE(int JIIGOACEIKL)
	{
	}

	public void KPMGOKPDFHC(int JIIGOACEIKL)
	{
	}

	public bool JGDDHIEJPMH(int JIIGOACEIKL)
	{
		if (!DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DBAEGBDEPFK())
		{
			return INOAMCEACPF();
		}
		return true;
	}

	public void BGKCJLLLLDJ(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("RingBell"));
			return true;
		}
		return false;
	}

	public bool PNEAONKFJNG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN(NODEDANJBFL: false);
			return false;
		}
		return false;
	}

	public void GIDHPGCHFLH(int JIIGOACEIKL)
	{
	}

	public bool GKIIBGDJDID(int JIIGOACEIKL)
	{
		if (!DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return ONELMCCCMMP();
		}
		return false;
	}

	public bool ONELMCCCMMP()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1157f;
	}

	public bool NIJAOPABLBA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KDGAIGKBPAC(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Pirates/Brook/Saludo"));
			return true;
		}
		return true;
	}

	public bool FNJHKKPGJFC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PNPLPBKBHLL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (MAEPPEIGMNI(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LearnMettle"));
			return false;
		}
		return false;
	}

	public void BKOLLDJAOFC(int JIIGOACEIKL)
	{
	}

	public void CLDGNBLJHJD(int JIIGOACEIKL)
	{
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool ABANCMLIHIH()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1617f;
	}

	public bool JPDJFKDAONL()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1692f;
	}

	public bool GABJJKAPBMJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool ICIOEGEPEJK()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 1263f;
	}

	public void KMKJBFPOIHK(int JIIGOACEIKL)
	{
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Vodka"));
			return false;
		}
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void GHLJPCOIADF(int JIIGOACEIKL)
	{
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		if (!DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM())
		{
			return ICIOEGEPEJK();
		}
		return false;
	}

	public bool MMHGMDILKLL()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 695f;
	}

	public void BDFBFLPJGOD(bool KDCAODJIEMD = true)
	{
		HKEHMPACMLP = Time.time;
		animator.SetTrigger(" isActor: ");
		if (KDCAODJIEMD)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().bell, ((Component)this).transform);
		}
	}

	public bool FFGPHAJHCOC()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 850f;
	}

	public bool ODIBEAAOCLE()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 760f;
	}

	public bool ODGHAJBBNJA(int JIIGOACEIKL)
	{
		if (!DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return DEHPHHGHCMA();
		}
		return true;
	}

	public bool CANOIJPJMBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FHLMGCKIFLF()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 1397f;
	}

	public bool OAFFHDOIDKO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KDNIAAOIMDJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (GKIIBGDJDID(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Wort"));
			return true;
		}
		return true;
	}

	public bool KFIFICOEJHK()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return true;
		}
		return Time.time > HKEHMPACMLP + 1465f;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
	}

	public bool ECHDGMEGPLG(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN(NODEDANJBFL: false);
			return false;
		}
		return false;
	}

	public bool DGNGLGMBIHE(int JIIGOACEIKL)
	{
		if (!DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IDPGEBNGDJD())
		{
			return DEHPHHGHCMA();
		}
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			return CanToggle();
		}
		return false;
	}

	public bool DAIPCFNHMEH()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 1877f;
	}

	public bool INOAMCEACPF()
	{
		if (OnlineManager.PlayingOnline() && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			return false;
		}
		return Time.time > HKEHMPACMLP + 63f;
	}

	public bool ONLBODAGFEP(int JIIGOACEIKL)
	{
		if (JGDDHIEJPMH(JIIGOACEIKL))
		{
			barn.IKFAIJGCKNN();
			return true;
		}
		return false;
	}
}
