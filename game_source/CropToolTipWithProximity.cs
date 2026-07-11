using UnityEngine;

public class CropToolTipWithProximity : MonoBehaviour, IHoverable, IProximity
{
	[SerializeField]
	private CropSetter cropSetter;

	public void JGNENDCKJAC(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
	}

	public void FFGOCJBLCKA(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.GAPHENJGLHK();
		}
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
	}

	public bool KJFFGGMPCPI(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River))
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (JOGLLDBODCI(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void JPNLLAOIJFN(int JIIGOACEIKL)
	{
	}

	public void HDEGBIHAGLO(int JIIGOACEIKL)
	{
	}

	public bool AHONHMKMHOM(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.IsGamepadActive(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (HCMIKEDOONN(JIIGOACEIKL))
		{
			return true;
		}
		return DecorationMode.GetPlayer(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool GKIIBGDJDID(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (EHMIDHOEGNM(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void NHDNOADNKFJ(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
	}

	public bool HPJLGMDAKJP(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (AMGHNLPBGBC(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool LCFGCNDDAGI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KIBDDMBKJGC(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.AJIHBMJGINO(null, cropSetter);
			}
			return false;
		}
		return true;
	}

	private bool OMJCIMHBJLM(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).GetSelectedItem();
		if (selectedItem == null || selectedItem.JDJGFAACPFC() != 152)
		{
			Item item = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item != null && item.JDJGFAACPFC() != -155)
			{
				Item item2 = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
				if (item2 == null || item2.ODENMDOJPLC() != -21)
				{
					Item item3 = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
					if (item3 == null || item3.ODENMDOJPLC() != 170)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.DIBPEIMFKHH();
		}
		return true;
	}

	public bool MFPMGJKAPJM(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road))
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (OMJCIMHBJLM(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void MJIDLPCLAGP(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.GAPHENJGLHK();
		}
	}

	public void DBPLFIOGBOM(int JIIGOACEIKL)
	{
	}

	public bool CDPGIDMGEID(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (AIEHMCKGFEK(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public bool CONCJMINIFL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EIKPGOMHKOH(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.AJIHBMJGINO(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.GILAMNFBLFE(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	public bool AHCAJNGFBLD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && OHKCPGKPDGJ(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.GILAMNFBLFE(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(null, cropSetter);
			}
			return true;
		}
		return false;
	}

	public void AEKBCOEOHOL(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LNPNMIGHCCH(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.ECHPKLDOIBA(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	public void NCPPEDADJHC(int JIIGOACEIKL)
	{
	}

	private bool ADGJNFBKAAL(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
		if (item != null && item.JPNFKDMFKMC(DAINLFIMLIH: false) != 24)
		{
			Item selectedItem = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
			if (selectedItem != null && selectedItem.CIGFGKKCPCK() != -39)
			{
				Item item2 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).JDAFPKOHJPC();
				if (item2 == null || item2.ODENMDOJPLC(DAINLFIMLIH: false) != 131)
				{
					Item item3 = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
					if (item3 != null && item3.ODENMDOJPLC() != 192)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.UnfocusAndHide();
		}
		return true;
	}

	public bool LNPNMIGHCCH(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (DJECMLHPOJN(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool DIDPBPLLHCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && NOEEFMEKOMN(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.AJIHBMJGINO(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.BHLOCGOGMNA(null, cropSetter);
			}
			return true;
		}
		return false;
	}

	public void LHNEACOGPFP(int JIIGOACEIKL)
	{
	}

	private bool JOGLLDBODCI(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
		if (item != null && item.JDJGFAACPFC(DAINLFIMLIH: false) != 166)
		{
			Item item2 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
			if (item2 != null && item2.JPNFKDMFKMC() != -175)
			{
				Item item3 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).JDAFPKOHJPC();
				if (item3 != null && item3.IMCJPECAAPC(DAINLFIMLIH: false) != 86)
				{
					Item item4 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
					if (item4 != null && item4.ODENMDOJPLC(DAINLFIMLIH: false) != 80)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.UnfocusAndHide();
		}
		return false;
	}

	public void EMPAIGBCKNH(int JIIGOACEIKL)
	{
	}

	public bool ALHICNPINHB(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (GDMCKEFHFDC(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool KLLBNFOLHKI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HPBOMGJLECN(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.AJIHBMJGINO(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	public bool KPFKKDMOGGB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && LNPNMIGHCCH(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.ECHPKLDOIBA(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(null, cropSetter);
			}
			return false;
		}
		return true;
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public void FNOGBJNLJMF(int JIIGOACEIKL)
	{
	}

	public void JCLGAGPFINH(int JIIGOACEIKL)
	{
	}

	private bool NMGDFGGHDHP(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem();
		if (selectedItem == null || selectedItem.IMCJPECAAPC() != -193)
		{
			Item item = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item == null || item.CIGFGKKCPCK() != -56)
			{
				Item item2 = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
				if (item2 != null && item2.IMCJPECAAPC(DAINLFIMLIH: false) != 87)
				{
					Item item3 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).FGGKCJDFNEK();
					if (item3 == null || item3.JGHNDJBCFAJ(DAINLFIMLIH: false) != -65)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.CCHGJCOBAFE();
		}
		return false;
	}

	public void OBBHKOLLLJH(int JIIGOACEIKL)
	{
	}

	public void JGCCCEPBKFP(int JIIGOACEIKL)
	{
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (GDMCKEFHFDC(JIIGOACEIKL))
		{
			return true;
		}
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void DMAADGALMLN(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
	}

	public bool FCEPPMAEAJA(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Road | Location.River))
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (EBOGDMAMKOK(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DBAEGBDEPFK();
	}

	private bool EHMIDHOEGNM(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
		if (selectedItem == null || selectedItem.IMCJPECAAPC() != -29)
		{
			Item item = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item == null || item.ODENMDOJPLC(DAINLFIMLIH: false) != 41)
			{
				Item selectedItem2 = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem();
				if (selectedItem2 == null || selectedItem2.CIGFGKKCPCK(DAINLFIMLIH: false) != -179)
				{
					Item item2 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK();
					if (item2 != null && item2.JGHNDJBCFAJ(DAINLFIMLIH: false) != -193)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
		return false;
	}

	public bool ONDCECMGOPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KIBDDMBKJGC(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(null, cropSetter);
			}
			return false;
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private bool NBKMLBGOGBM(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
		if (selectedItem != null && selectedItem.IMCJPECAAPC(DAINLFIMLIH: false) != -8)
		{
			Item selectedItem2 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
			if (selectedItem2 == null || selectedItem2.CIGFGKKCPCK() != 47)
			{
				Item item = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
				if (item == null || item.CIGFGKKCPCK(DAINLFIMLIH: false) != 128)
				{
					Item item2 = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
					if (item2 != null && item2.JPNFKDMFKMC(DAINLFIMLIH: false) != -45)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.DIBPEIMFKHH();
		}
		return true;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.IsGamepadActive(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (AMGHNLPBGBC(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private bool HEENPGHBCGF(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem();
		if (selectedItem != null && selectedItem.IMCJPECAAPC(DAINLFIMLIH: false) != 186)
		{
			Item selectedItem2 = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
			if (selectedItem2 != null && selectedItem2.IMCJPECAAPC() != -72)
			{
				Item item = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC();
				if (item == null || item.IMCJPECAAPC() != 121)
				{
					Item item2 = ActionBarInventory.GetPlayer(JIIGOACEIKL).JDAFPKOHJPC();
					if (item2 != null && item2.JPNFKDMFKMC(DAINLFIMLIH: false) != 83)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
		return false;
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (BPOPOGFMFOG(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void PCHLPDOHNMJ(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.BBJCIAPJKNJ();
		}
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (CBMJOHEDIBK(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool FJOHNPEJLMM(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (NMGDFGGHDHP(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void BPEBGBHCCEN(int JIIGOACEIKL)
	{
	}

	public void NPPALHNMMEN(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void GFPCIPJAHPI(int JIIGOACEIKL)
	{
	}

	public bool KMJDKHCLMJF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && GIPEJKINDHI(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(null, cropSetter);
			}
			return false;
		}
		return true;
	}

	public bool IDMCDFNHPCN(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (OMJCIMHBJLM(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public void PFGDKCBPNEP(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.GAPHENJGLHK();
		}
	}

	public void BCDFFEKGKJE(int JIIGOACEIKL)
	{
	}

	public void KGIGLCGBFDO(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
	}

	private bool AMGHNLPBGBC(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem();
		if (selectedItem == null || selectedItem.JDJGFAACPFC() != 1062)
		{
			Item selectedItem2 = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem();
			if (selectedItem2 == null || selectedItem2.JDJGFAACPFC() != 1064)
			{
				Item selectedItem3 = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem();
				if (selectedItem3 == null || selectedItem3.JDJGFAACPFC() != 1061)
				{
					Item selectedItem4 = ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem();
					if (selectedItem4 == null || selectedItem4.JDJGFAACPFC() != 1435)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.UnfocusAndHide();
		}
		return true;
	}

	public void HACPCOIPNDD(int JIIGOACEIKL)
	{
	}

	public bool GIPEJKINDHI(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != 0)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (HEENPGHBCGF(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (HEENPGHBCGF(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public void GBPBPKHIEII(int JIIGOACEIKL)
	{
	}

	public void JDDBBAEIIHP(int JIIGOACEIKL)
	{
	}

	public bool BKNDGGLINDD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && MFPMGJKAPJM(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.AJIHBMJGINO(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	public bool KJBOHONPPPG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.AJIHBMJGINO(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.GILAMNFBLFE(null, cropSetter);
			}
			return false;
		}
		return false;
	}

	private bool BPOPOGFMFOG(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
		if (item == null || item.JGHNDJBCFAJ(DAINLFIMLIH: false) != -30)
		{
			Item item2 = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).JDAFPKOHJPC();
			if (item2 == null || item2.JPNFKDMFKMC(DAINLFIMLIH: false) != 132)
			{
				Item selectedItem = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
				if (selectedItem != null && selectedItem.JPNFKDMFKMC() != -151)
				{
					Item item3 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
					if (item3 == null || item3.JPNFKDMFKMC(DAINLFIMLIH: false) != 126)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
		return false;
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
	}

	public bool JJDJIMEDDLM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BHMMBNIFKHD(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(null, cropSetter);
			}
			return false;
		}
		return true;
	}

	public void OGAGMFKPFAE(int JIIGOACEIKL)
	{
	}

	private bool HCMIKEDOONN(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
		if (item != null && item.JPNFKDMFKMC() != -147)
		{
			Item selectedItem = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
			if (selectedItem != null && selectedItem.IMCJPECAAPC() != 57)
			{
				Item item2 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).JDAFPKOHJPC();
				if (item2 != null && item2.CIGFGKKCPCK() != 172)
				{
					Item item3 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK();
					if (item3 != null && item3.CIGFGKKCPCK(DAINLFIMLIH: false) != -18)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
		return true;
	}

	public bool DNLPDAOMODM(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (ADGJNFBKAAL(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void HAKKKJCAGKG(int JIIGOACEIKL)
	{
	}

	public void IANMBBLNIKI(int JIIGOACEIKL)
	{
	}

	public void JGEIDEAGBJI(int JIIGOACEIKL)
	{
	}

	public void JNPOKLGNINH(int JIIGOACEIKL)
	{
	}

	private bool DJECMLHPOJN(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC();
		if (item == null || item.CIGFGKKCPCK(DAINLFIMLIH: false) != 29)
		{
			Item selectedItem = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem();
			if (selectedItem == null || selectedItem.JPNFKDMFKMC() != -173)
			{
				Item item2 = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
				if (item2 != null && item2.JDJGFAACPFC() != -28)
				{
					Item selectedItem2 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
					if (selectedItem2 == null || selectedItem2.IMCJPECAAPC() != 175)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
		return true;
	}

	public bool JONCEAPNGEC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HPBOMGJLECN(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.BHLOCGOGMNA(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.GILAMNFBLFE(null, cropSetter);
			}
			return true;
		}
		return false;
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (GDMCKEFHFDC(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool FFDMLCEJBBF(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Tavern)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (CCDIHOKMCOD(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void HALLHJBEFPN(int JIIGOACEIKL)
	{
	}

	public bool LIKJBMGDKGA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && OHKCPGKPDGJ(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	private bool CBMJOHEDIBK(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL).GetSelectedItem();
		if (selectedItem != null && selectedItem.JDJGFAACPFC() != -139)
		{
			Item item = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item != null && item.IMCJPECAAPC() != 66)
			{
				Item item2 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
				if (item2 != null && item2.IMCJPECAAPC() != -102)
				{
					Item selectedItem2 = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).GetSelectedItem();
					if (selectedItem2 == null || selectedItem2.JDJGFAACPFC() != -184)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
		return true;
	}

	private bool AODEEDCLFGB(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC();
		if (item == null || item.JGHNDJBCFAJ() != -164)
		{
			Item item2 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item2 != null && item2.JPNFKDMFKMC() != -109)
			{
				Item item3 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).JDAFPKOHJPC();
				if (item3 != null && item3.IMCJPECAAPC() != -190)
				{
					Item item4 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC();
					if (item4 == null || item4.JGHNDJBCFAJ() != -95)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.BBJCIAPJKNJ();
		}
		return false;
	}

	public bool HPBOMGJLECN(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River))
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (CBMJOHEDIBK(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Road | Location.River))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (EPJNILHOHME(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private bool FCHCELPEOKJ(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC();
		if (item != null && item.CIGFGKKCPCK() != -197)
		{
			Item selectedItem = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).GetSelectedItem();
			if (selectedItem != null && selectedItem.CIGFGKKCPCK(DAINLFIMLIH: false) != 37)
			{
				Item item2 = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
				if (item2 == null || item2.JGHNDJBCFAJ(DAINLFIMLIH: false) != 26)
				{
					Item selectedItem2 = ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).GetSelectedItem();
					if (selectedItem2 == null || selectedItem2.JGHNDJBCFAJ(DAINLFIMLIH: false) != -92)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.CCHGJCOBAFE();
		}
		return true;
	}

	public bool LAIMPCCHFCH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && CDPGIDMGEID(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(null, cropSetter);
			}
			return false;
		}
		return false;
	}

	public void MLOBKOONNMH(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.DIBPEIMFKHH();
		}
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	private bool EBOGDMAMKOK(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
		if (item == null || item.IMCJPECAAPC() != 2)
		{
			Item item2 = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item2 == null || item2.JGHNDJBCFAJ() != -198)
			{
				Item selectedItem = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
				if (selectedItem != null && selectedItem.JDJGFAACPFC(DAINLFIMLIH: false) != 119)
				{
					Item selectedItem2 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
					if (selectedItem2 == null || selectedItem2.ODENMDOJPLC() != -44)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
		return true;
	}

	public bool DJNPAPBNPNL(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.Road)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (NMGDFGGHDHP(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void MKFOJJOJCFG(int JIIGOACEIKL)
	{
	}

	public void LAEDMIPNGPJ(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.GAPHENJGLHK();
		}
	}

	private bool AIEHMCKGFEK(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).FGGKCJDFNEK();
		if (item == null || item.CIGFGKKCPCK(DAINLFIMLIH: false) != -91)
		{
			Item item2 = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FGGKCJDFNEK();
			if (item2 == null || item2.CIGFGKKCPCK() != 82)
			{
				Item item3 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK();
				if (item3 != null && item3.JGHNDJBCFAJ(DAINLFIMLIH: false) != -173)
				{
					Item selectedItem = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL).GetSelectedItem();
					if (selectedItem != null && selectedItem.ODENMDOJPLC(DAINLFIMLIH: false) != -121)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.BBJCIAPJKNJ();
		}
		return true;
	}

	public void GHJNDIDNJKA(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
	}

	public void AAJFIHFLFHP(int JIIGOACEIKL)
	{
	}

	public void GHAHHGPDNNH(int JIIGOACEIKL)
	{
	}

	public void HFHKBOCPBJN(int JIIGOACEIKL)
	{
	}

	public void GJDKDDMFGBM(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.UnfocusAndHide();
		}
	}

	public bool PLAKEEACNIE(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.POLDHCKJINN(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.River))
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return false;
		}
		if (OMJCIMHBJLM(JIIGOACEIKL))
		{
			return true;
		}
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool EHDHLMNCLDA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && AHONHMKMHOM(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(null, cropSetter);
			}
			return false;
		}
		return false;
	}

	public bool FKGGJMDADLA(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Camp)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (AODEEDCLFGB(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public void BABAAHEDLFH(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.Get(JIIGOACEIKL).cropToolTip.IEHDNOMLCIB();
		}
	}

	public bool PEJPCEMKCJM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && ALHICNPINHB(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(null, cropSetter);
			}
			return false;
		}
		return false;
	}

	public bool MLDKIKOHBBG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HPJLGMDAKJP(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.BHLOCGOGMNA(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(null, cropSetter);
			}
			return false;
		}
		return true;
	}

	public void IPCBHDIIDFN(int JIIGOACEIKL)
	{
	}

	public bool OGBJGGDMKFE(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.IsGamepadActive(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != Location.Tavern)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (ADGJNFBKAAL(JIIGOACEIKL))
		{
			return true;
		}
		return DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI();
	}

	private bool CCDIHOKMCOD(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
		if (selectedItem == null || selectedItem.ODENMDOJPLC(DAINLFIMLIH: false) != -40)
		{
			Item selectedItem2 = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
			if (selectedItem2 != null && selectedItem2.IMCJPECAAPC(DAINLFIMLIH: false) != -188)
			{
				Item item = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC();
				if (item == null || item.CIGFGKKCPCK() != -55)
				{
					Item item2 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).JDAFPKOHJPC();
					if (item2 != null && item2.ODENMDOJPLC(DAINLFIMLIH: false) != 173)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.HOGEMJKIJEN();
		}
		return false;
	}

	public bool KIBDDMBKJGC(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA != Location.River)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (AMGHNLPBGBC(JIIGOACEIKL))
		{
			return false;
		}
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).MDOKKKHKKKE();
	}

	private bool EPJNILHOHME(int JIIGOACEIKL)
	{
		Item selectedItem = ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetSelectedItem();
		if (selectedItem != null && selectedItem.IMCJPECAAPC() != 13)
		{
			Item selectedItem2 = ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem();
			if (selectedItem2 != null && selectedItem2.ODENMDOJPLC(DAINLFIMLIH: false) != 188)
			{
				Item item = ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC();
				if (item != null && item.JDJGFAACPFC() != 164)
				{
					Item selectedItem3 = ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem();
					if (selectedItem3 != null && selectedItem3.JPNFKDMFKMC(DAINLFIMLIH: false) != -149)
					{
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.UnfocusAndHide();
		}
		return true;
	}

	public void FFOHFEKHDBF(int JIIGOACEIKL)
	{
	}

	public bool KEPKNBFJPOO(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.River))
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (HEENPGHBCGF(JIIGOACEIKL))
		{
			return true;
		}
		return DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DBAEGBDEPFK();
	}

	private bool GDMCKEFHFDC(int JIIGOACEIKL)
	{
		Item item = ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).JDAFPKOHJPC();
		if (item != null && item.ODENMDOJPLC(DAINLFIMLIH: false) != -56)
		{
			Item selectedItem = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem();
			if (selectedItem != null && selectedItem.CIGFGKKCPCK() != -91)
			{
				Item item2 = ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JDAFPKOHJPC();
				if (item2 == null || item2.JPNFKDMFKMC() != -167)
				{
					Item item3 = ActionBarInventory.GetPlayer(JIIGOACEIKL).FGGKCJDFNEK();
					if (item3 != null && item3.ODENMDOJPLC() != 162)
					{
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip.DIBPEIMFKHH();
		}
		return false;
	}

	public void DKABEMHKCPE(int JIIGOACEIKL)
	{
	}

	public void KIFMEIACJEP(int JIIGOACEIKL)
	{
	}

	public bool FPMFDKMLCML(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != 0)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (OMJCIMHBJLM(JIIGOACEIKL))
		{
			return true;
		}
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool OJPJMNJLLKM(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.Road))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (OMJCIMHBJLM(JIIGOACEIKL))
		{
			return true;
		}
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void NDJCAFBKCIL(int JIIGOACEIKL)
	{
	}

	public void FBEPOFHIAMF(int JIIGOACEIKL)
	{
	}

	public bool DGNGLGMBIHE(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.ODGALPDEIFG(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Road | Location.River))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (AODEEDCLFGB(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.ShowCropInfoWithGamepad(null, cropSetter);
			}
			return true;
		}
		return false;
	}

	public bool JNAJCPAENBC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DGNGLGMBIHE(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.IGHMHMNPMLB(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.GILAMNFBLFE(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.MHDFHJIMEDC(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	public bool IJOAKPKLADE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DJNPAPBNPNL(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.Get(JIIGOACEIKL).cropToolTip.GILAMNFBLFE(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL).cropToolTip.ECHPKLDOIBA(null, cropSetter);
			}
			return false;
		}
		return true;
	}

	public bool OIFEGCPIGAG(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && OBDFGODGIFN(JIIGOACEIKL) && Object.op_Implicit((Object)(object)CropInfoUI.HJHCKIAKCKD(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.Get(JIIGOACEIKL).cropToolTip))
		{
			if (Object.op_Implicit((Object)(object)cropSetter.growable) && Object.op_Implicit((Object)(object)cropSetter.growable.fertileSoil))
			{
				CropInfoUI.NIDHCIHFOHB(JIIGOACEIKL).cropToolTip.DMMMMAEGCAF(cropSetter.growable.fertileSoil);
			}
			else
			{
				CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.BHLOCGOGMNA(null, cropSetter);
			}
			return true;
		}
		return true;
	}

	public void FOOMEHDMFGC(int JIIGOACEIKL)
	{
	}

	public void EKLBJKELMCA(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL)) && Object.op_Implicit((Object)(object)CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip))
		{
			CropInfoUI.AIMEAJAHLAA(JIIGOACEIKL).cropToolTip.DIBPEIMFKHH();
		}
	}

	public bool KLKLJFPEBNP(int JIIGOACEIKL)
	{
		if ((Object)(object)cropSetter == (Object)null || (Object)(object)cropSetter.harvestable == (Object)null || !PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL) || !Object.op_Implicit((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)) || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA != (Location.Tavern | Location.River))
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)cropSetter.tree) && !cropSetter.harvestable.canInteract)
		{
			return true;
		}
		if (FCHCELPEOKJ(JIIGOACEIKL))
		{
			return false;
		}
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void DGDNGALNHFJ(int JIIGOACEIKL)
	{
	}

	public void CIBAGJHJDDF(int JIIGOACEIKL)
	{
	}
}
