using System;
using UnityEngine;

public class OpenShop : MonoBehaviour, IInteractable, ISelectable, IHoverable, IProximity
{
	[SerializeField]
	private ShopType shopType;

	public bool GNBGMLDANLD(int JIIGOACEIKL)
	{
		return false;
	}

	public void JGEIDEAGBJI(int JIIGOACEIKL)
	{
	}

	public bool FJNDDADIBMI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void NLLBFJIFBLP(int JIIGOACEIKL)
	{
	}

	public void POEJLKMJDPF(int JIIGOACEIKL)
	{
	}

	public void MNJHOCPCPMJ(int JIIGOACEIKL)
	{
	}

	public bool EALAGAKPKFF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NDMODGOCNBK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NDNJPJHHKDJ(int JIIGOACEIKL)
	{
		ShopUI.FKFNANNBIAM(JIIGOACEIKL).BOBCIFEDJED();
		return true;
	}

	public bool OOJPCIDDGCN(int JIIGOACEIKL)
	{
		if (DecorationMode.NPANPNIDKDG(JIIGOACEIKL).GABNNLJOMHI())
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("ReceiveStartKlaynChallenge"), 744f);
			return false;
		}
		ShopUI.AGNKKAPMHLN(JIIGOACEIKL).shop = ShopDatabaseAccessor.GJPNBLLHHEJ(shopType);
		ShopUI.JCBPABNCBPI(JIIGOACEIKL).OpenUI();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool GAAPPACMBNO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DBPLFIOGBOM(int JIIGOACEIKL)
	{
	}

	public bool POAFCDOGHMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IKAIGCMENPF(int JIIGOACEIKL)
	{
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("South"), 493f);
			return false;
		}
		ShopUI.IEABDMDELFO(JIIGOACEIKL).shop = ShopDatabaseAccessor.MDLINJLBFPH(shopType);
		ShopUI.JCBPABNCBPI(JIIGOACEIKL).EDHEIFHAAKO();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public void EKFKDEBFDPA(int JIIGOACEIKL)
	{
	}

	public bool DAKHAHICKMO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MFCNGGMNBHB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool FHDFKMOIKBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AOMPILIIHGP(int JIIGOACEIKL)
	{
	}

	public bool AIKGCLCNNLN(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KIDKENDJEEK(int JIIGOACEIKL)
	{
		if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).KNFEPKBIHND())
		{
			MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("scaleUI"), 965f);
			return true;
		}
		ShopUI.IEABDMDELFO(JIIGOACEIKL).shop = ShopDatabaseAccessor.MDLINJLBFPH(shopType);
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI())
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Disabled"), 1147f);
			return false;
		}
		ShopUI.NALKHGMLALJ(JIIGOACEIKL).shop = ShopDatabaseAccessor.LLBJIBGBOMB(shopType);
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool PILFNGKAHKK(int JIIGOACEIKL)
	{
		return false;
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BFDIIFOLJDC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NOHOJFCHMEC(int JIIGOACEIKL)
	{
		return DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool IEONLPIPJFC(int JIIGOACEIKL)
	{
		ShopUI.IEABDMDELFO(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool INHDHCOFLJI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KBDEDNHDNOK(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("PhysicalSpace"));
			return false;
		}
		return true;
	}

	public bool OIPGCPJILMC(int JIIGOACEIKL)
	{
		ShopUI.FKFNANNBIAM(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool CGOPBBGLLEO(int JIIGOACEIKL)
	{
		return false;
	}

	public void HALLHJBEFPN(int JIIGOACEIKL)
	{
	}

	public bool FEOCIADGJIP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JCCFAFPMGFI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DGAAEMIENEI(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Error_NoCatFood"));
			return false;
		}
		return true;
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).KNFEPKBIHND())
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Error_CloseMenus"), 701f);
			return false;
		}
		ShopUI.AGNKKAPMHLN(JIIGOACEIKL).shop = ShopDatabaseAccessor.LLBJIBGBOMB(shopType);
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool DLEDGMKGACB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IBEMCOALOEJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("EnterCode"));
			return true;
		}
		return true;
	}

	public bool IJNMMFDHDJC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool NCGCKHGOJCM(int JIIGOACEIKL)
	{
		return false;
	}

	public void JEAFMKBOPEH(int JIIGOACEIKL)
	{
	}

	public bool JEJAGPHMLLF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && MLMIICLMNCD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("%>"));
			return true;
		}
		return true;
	}

	public bool FEEGKDKHJOE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GBPNIFFOCGE(int JIIGOACEIKL)
	{
		if (DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IBEFDKHFBFM())
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("LearnBalance"), 213f);
			return true;
		}
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool DFOBPNFKEKD(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		return !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && NOHOJFCHMEC(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Already have recipe "));
			return false;
		}
		return true;
	}

	public bool OFIEDMENIEP(int JIIGOACEIKL)
	{
		if (DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Cold"), 1608f);
			return true;
		}
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).shop = ShopDatabaseAccessor.LLBJIBGBOMB(shopType);
		ShopUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public void PEOILAGPJNB(int JIIGOACEIKL)
	{
	}

	public bool KJCHEGOOODF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BMAMFDCGMOJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void BIKILBEOGAD(int JIIGOACEIKL)
	{
	}

	public bool MAKEFKOJEDH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CKNJJKJDBGA(int JIIGOACEIKL)
	{
		ShopUI.FKFNANNBIAM(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool CONCJMINIFL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && JEKCOIDEOMK(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("CannotToggleUI Holding "));
			return true;
		}
		return true;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NDHKOEDAHNI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && MLMIICLMNCD(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("BarIdleNumber"));
			return true;
		}
		return false;
	}

	public bool HAPLPIMJGGN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FPCDPCANNOK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KKDGHOHHIKA(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("ReceiveRenewCandle Unique id "));
			return false;
		}
		return true;
	}

	public void NIPHFNAJKBN(int JIIGOACEIKL)
	{
	}

	public bool BNKHFDEOADN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LJCFJIOBDLD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OBGLKNKPGNP(int JIIGOACEIKL)
	{
		return true;
	}

	public void HPJLNHGMIGD(int JIIGOACEIKL)
	{
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool JGHFBNOBBLN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool GPDHPJBNPAD(int JIIGOACEIKL)
	{
		if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).MDOKKKHKKKE())
		{
			MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Could not find Quest with id: "), 1227f);
			return true;
		}
		ShopUI.JCBPABNCBPI(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).OpenUI();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool LJCNIPCGOGN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void BGKCJLLLLDJ(int JIIGOACEIKL)
	{
	}

	public bool OFMJFMILDJP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PHOKDJNJDPI(int JIIGOACEIKL)
	{
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool DGAAEMIENEI(int JIIGOACEIKL)
	{
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool LPKCIENGJMN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool ABLNPEOHBNL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EIOJAIOOMEI(int JIIGOACEIKL)
	{
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool DBIPJGJPBHP(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool ECHDGMEGPLG(int JIIGOACEIKL)
	{
		if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("NPCDespawn PerformAction"), 1505f);
			return false;
		}
		ShopUI.Get(JIIGOACEIKL).shop = ShopDatabaseAccessor.MNLIACMLIEG(shopType);
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool AMHHJMOFJNP(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BAFEPHDKDCF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JHHNCDODNBD(int JIIGOACEIKL)
	{
		return false;
	}

	public bool GIOPJJHBCHJ(int JIIGOACEIKL)
	{
		if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Direction"), 625f);
			return false;
		}
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool BNFLJFFKMMN(int JIIGOACEIKL)
	{
		return false;
	}

	public void DMMOIAFCEHP(int JIIGOACEIKL)
	{
	}

	public bool OLFMABJKAGA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DIFNFNJOPKP(int JIIGOACEIKL)
	{
	}

	public bool KKDGHOHHIKA(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool EJIIHFENDDN(int JIIGOACEIKL)
	{
		ShopUI.IEABDMDELFO(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool JFCPMLACCPE(int JIIGOACEIKL)
	{
		return true;
	}

	public void KNAECECJECL(int JIIGOACEIKL)
	{
	}

	public bool HKNOENNPKEN(int JIIGOACEIKL)
	{
		ShopUI.IEABDMDELFO(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool NHKJGMPBJND(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NALCGCFJMND(int JIIGOACEIKL)
	{
		ShopUI.IEABDMDELFO(JIIGOACEIKL).BOBCIFEDJED();
		return true;
	}

	public void LJOLGDBKLGH(int JIIGOACEIKL)
	{
	}

	public bool HCBDMHPHBGL(int JIIGOACEIKL)
	{
		ShopUI.Get(JIIGOACEIKL).CloseUI();
		return false;
	}

	public bool JEKCOIDEOMK(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool BDCIGELBCNJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool PGLHDOHLPJM(int JIIGOACEIKL)
	{
		ShopUI.EAONFFENMCE(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KBDEDNHDNOK(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Send begin retry"));
			return false;
		}
		return true;
	}

	public bool IPKOOEJJANI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KBDEDNHDNOK(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Disabled"));
			return false;
		}
		return false;
	}

	public void FPJFFEOAJPM(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
			return false;
		}
		ShopUI.Get(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.Get(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool CNADCCGDBPD(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void NEBIAJNDDOC(int JIIGOACEIKL)
	{
	}

	public void GOIMNNEEDCI(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool MLMIICLMNCD(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void JNPOKLGNINH(int JIIGOACEIKL)
	{
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool KBCNGBAAKMF(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MMAPHMGNIFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IOANEJAHOMG(int JIIGOACEIKL)
	{
		ShopUI.FKFNANNBIAM(JIIGOACEIKL).BOBCIFEDJED();
		return true;
	}

	public void GLLCKILBEOL(int JIIGOACEIKL)
	{
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).KNFEPKBIHND())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("ReceiveEmployeeBackToWorkRPC"), 1917f);
			return true;
		}
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).OpenUI();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool EKKKHOHJONB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void NNAOFNMIOLB(int JIIGOACEIKL)
	{
	}

	public bool FAFJBJOMDPL(int JIIGOACEIKL)
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

	public bool DJKJLLLGCHB(int JIIGOACEIKL)
	{
		if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DMBFKFLDDLH)
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Prepare"), 1959f);
			return false;
		}
		ShopUI.JCBPABNCBPI(JIIGOACEIKL).shop = ShopDatabaseAccessor.GJPNBLLHHEJ(shopType);
		ShopUI.EAONFFENMCE(JIIGOACEIKL).IDLAGJNLPJL();
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return false;
	}

	public bool OPMLKOBGNJC(int JIIGOACEIKL)
	{
		return true;
	}

	public void EJJOGBGFAPP(int JIIGOACEIKL)
	{
	}

	public void KPDGBOICFKI(int JIIGOACEIKL)
	{
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CBLGAAHDHOC(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HAOPENBNBFF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && CNADCCGDBPD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Failed to get current user name for reason "));
			return false;
		}
		return false;
	}

	public void BPBLPHMJKOL(int JIIGOACEIKL)
	{
	}

	public bool NGOMFMMBEEB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool KBDEDNHDNOK(int JIIGOACEIKL)
	{
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool FLEIIDPEAHP(int JIIGOACEIKL)
	{
		if (DecorationMode.GetPlayer(JIIGOACEIKL).DFNMDDHOIJI())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("00"), 1851f);
			return false;
		}
		ShopUI.EPKNOMLADCL(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.EAONFFENMCE(JIIGOACEIKL).OpenUI();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool KIBEBGPMMGL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool KHMDOPOEGCI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		ShopUI.Get(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool MGCIBGCMBKB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool JGKPIMAGPAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BKKKMLAALAC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KPOMIDOHKMP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DHONONOMNIL(int JIIGOACEIKL)
	{
		return false;
	}

	public bool LKDCHBJMBLO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool GOAENJIBOCP(int JIIGOACEIKL)
	{
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool DMIJLPAHCBB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MEKJDKLEMEC(int JIIGOACEIKL)
	{
		if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI())
		{
			MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("itemDarkMaltedBarley"), 1107f);
			return false;
		}
		ShopUI.Get(JIIGOACEIKL).shop = ShopDatabaseAccessor.GetShop(shopType);
		ShopUI.IEKODILKIHJ(JIIGOACEIKL).EDHEIFHAAKO();
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, null);
		return true;
	}

	public bool JMPNIEHPIFN(int JIIGOACEIKL)
	{
		return false;
	}
}
