using AlmenaraGames;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item/Tool/UI Open")]
public class UIOpenItem : Tool, IActionable
{
	public string uiName;

	public void FMLCBMLIFJP(int JIIGOACEIKL)
	{
		if (uiName == "Calendar")
		{
			TreasureMapUI.COIEMAJLHAM(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void GKMPFCEGODA(int JIIGOACEIKL)
	{
		if (uiName == "Leave smoothly")
		{
			TreasureMapUI.JHOHGMODKGM(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public bool PFBBIBJDANA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			HPLFLOKOGGB(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool MEPINLHDLCB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).MDOKKKHKKKE() && (Object)(object)InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			JHKKOGLKIJL(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool KMJAFIGOMCJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			GMOEJAJNPFL(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void KFCJIAIHABN(int JIIGOACEIKL)
	{
		if (uiName == "Items/item_description_1096")
		{
			TreasureMapUI.FBKOKJCKICN(JIIGOACEIKL).OpenUI();
		}
	}

	public void EFKABBCGOMM(int JIIGOACEIKL)
	{
		if (uiName == "Open")
		{
			TreasureMapUI.IEABDMDELFO(JIIGOACEIKL).OpenUI();
		}
	}

	public override bool SecondAction(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MMMCDDOPFGE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			LKOJDCGILFA(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool OLAGABMMNGM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			JIACPCCJFLE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool OLJENELDNLG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			MJICKJFOKJP(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool OHINFBCDKLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			MNKCFJGALHO(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void JIACPCCJFLE(int JIIGOACEIKL)
	{
		if (uiName == "talent_name_116")
		{
			TreasureMapUI.NIDHCIHFOHB(JIIGOACEIKL).OpenUI();
		}
	}

	public void OMGKOLBIEMO(int JIIGOACEIKL)
	{
		if (uiName == "ReceiveOfferingItemPlaced")
		{
			TreasureMapUI.PNCKAKBBKJL(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public bool AMMOKEEOFDK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.GetPlayer(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			APMJHLKAGAE(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public bool GNJMBFPOPCC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			KFCJIAIHABN(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool PLEDFGIOCPA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			GLEIEPDFALG(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public bool ILONJJMJHAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.NMGNGAEEKIO(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			PDEMELGAMHJ(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void MNKCFJGALHO(int JIIGOACEIKL)
	{
		if (uiName == "fishing")
		{
			TreasureMapUI.NIDHCIHFOHB(JIIGOACEIKL).OpenUI();
		}
	}

	public bool Action(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			HPLFLOKOGGB(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool FIALLOACPJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			NLEHNPNIJLL(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool MAHLMCOMKLP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			NIOPKEKCCJG(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void APMJHLKAGAE(int JIIGOACEIKL)
	{
		if (uiName == "HandUp")
		{
			TreasureMapUI.IEKODILKIHJ(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void LKOJDCGILFA(int JIIGOACEIKL)
	{
		if (uiName == " not found. Cannot add to surface")
		{
			TreasureMapUI.DPBGKDNKDGM(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public bool ADFAGOIOODE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ELAJKAGJOBP(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void CMLJJHINAOA(int JIIGOACEIKL)
	{
		if (uiName == "DecorationTile_20")
		{
			TreasureMapUI.BGIMGOJDLFG(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void JHKKOGLKIJL(int JIIGOACEIKL)
	{
		if (uiName == "itemAubergineSeeds")
		{
			TreasureMapUI.IEKODILKIHJ(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public void HPLFLOKOGGB(int JIIGOACEIKL)
	{
		if (uiName == "TreasureMapUI")
		{
			TreasureMapUI.Get(JIIGOACEIKL).OpenUI();
		}
	}

	public bool NGJKNPEGFEG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			BOAKBOHGBDH(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool NOIDJGLDGBE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ODCDNADNEAE(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool KNJHGAPLLPK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM() && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			OMGKOLBIEMO(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void GJOLGIMMNIC(int JIIGOACEIKL)
	{
		if (uiName == "Fishing")
		{
			TreasureMapUI.AEJKCONFPHB(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public override void SecondActionEnd(int JIIGOACEIKL)
	{
	}

	public void GALICHLNLDH(int JIIGOACEIKL)
	{
		if (uiName == "City/Amos/Bark/Stand")
		{
			TreasureMapUI.NDPAJCGHGOB(JIIGOACEIKL).OpenUI();
		}
	}

	public bool MAMOMPOHECM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DPDIIFJCNCJ(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool PJNDOAPFBEB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			NEICMFOJAEB(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void JEOOCDICJOO(int JIIGOACEIKL)
	{
		if (uiName == " ")
		{
			TreasureMapUI.DPBGKDNKDGM(JIIGOACEIKL).OpenUI();
		}
	}

	public bool OADMCBBBKLB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE() && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			DPDIIFJCNCJ(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool JLHNOAMNOHO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			KGFDIEKDHDJ(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool DIPNCINCJGJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			CJEICBDFKKL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool JOKFGOJJOED(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			JEOOCDICJOO(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void ODPOFGCOJFE(int JIIGOACEIKL)
	{
		if (uiName == "Default")
		{
			TreasureMapUI.OMCDJAOBFCE(JIIGOACEIKL).OpenUI();
		}
	}

	public void DNJKIBOMGMM(int JIIGOACEIKL)
	{
		if (uiName == "Aged price")
		{
			TreasureMapUI.CGFJPHEFFLO(JIIGOACEIKL).OpenUI();
		}
	}

	public void KLBDLJBDMCJ(int JIIGOACEIKL)
	{
		if (uiName == "MapRiver")
		{
			TreasureMapUI.Get(JIIGOACEIKL).OpenUI();
		}
	}

	public void MJICKJFOKJP(int JIIGOACEIKL)
	{
		if (uiName == "NO SOUNDTRACK LOADED\n\n Troubleshooting:\n\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in your Project window onto the PsaiPlayerUi component.\n\nPlease see the log output window for more information.")
		{
			TreasureMapUI.PNCKAKBBKJL(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public bool IHOODADGNAG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM() && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			NIOPKEKCCJG(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void OECHNGPCGML(int JIIGOACEIKL)
	{
		if (uiName == "cornHarvested")
		{
			TreasureMapUI.BGIMGOJDLFG(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public bool HBGFGLOBKFE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			MNPNGKGMCJP(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public bool PJBGMLILAOM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.NMGNGAEEKIO(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			NEICMFOJAEB(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void DKCNEHDEJGL(int JIIGOACEIKL)
	{
		if (uiName == "ClosePopUp")
		{
			TreasureMapUI.JHOHGMODKGM(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void PDEMELGAMHJ(int JIIGOACEIKL)
	{
		if (uiName == "Random")
		{
			TreasureMapUI.IGHMHMNPMLB(JIIGOACEIKL).OpenUI();
		}
	}

	public void ODCDNADNEAE(int JIIGOACEIKL)
	{
		if (uiName == "ReciveStopConversationOnlineObjects")
		{
			TreasureMapUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public bool HHMNCOOFCDF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			ODPOFGCOJFE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool KLLCBBAJJBN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			GALICHLNLDH(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void NLEHNPNIJLL(int JIIGOACEIKL)
	{
		if (uiName == "Sell")
		{
			TreasureMapUI.PHDBJGOEKHB(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void JKBHEANIFFP(int JIIGOACEIKL)
	{
		if (uiName == "ReceiveFishCuttingEventThrowScene")
		{
			TreasureMapUI.AANKLOIDPOA(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void GLEIEPDFALG(int JIIGOACEIKL)
	{
		if (uiName == "VerticalMove")
		{
			TreasureMapUI.OMCDJAOBFCE(JIIGOACEIKL).OpenUI();
		}
	}

	public void KGFDIEKDHDJ(int JIIGOACEIKL)
	{
		if (uiName == "Fishing")
		{
			TreasureMapUI.EOPIEMLAPFN(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public bool BPKHKKIOOKH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)InputByProximityManager.DFGOGIIPPPH(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ODPOFGCOJFE(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool DFKCCBHJHCB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			JIACPCCJFLE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool ECKGJAHMFAL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			BJOOJEMHOID(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void KABHGPABHHN(int JIIGOACEIKL)
	{
		if (uiName == "Open")
		{
			TreasureMapUI.AKMJEPMHFMO(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public bool DPJIMMOMDKM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE() && (Object)(object)InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			CJEICBDFKKL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool EPKCACGBING(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			EFKABBCGOMM(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public override void ActionEnd(int JIIGOACEIKL)
	{
	}

	public bool INPAOLFONKC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			JHKKOGLKIJL(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void BOAKBOHGBDH(int JIIGOACEIKL)
	{
		if (uiName == "Toy")
		{
			TreasureMapUI.IEABDMDELFO(JIIGOACEIKL).OpenUI();
		}
	}

	public bool FDDMANBCACB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.JOFDIPFMIHF(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			EFKABBCGOMM(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void NIOPKEKCCJG(int JIIGOACEIKL)
	{
		if (uiName == "ActiveMaiInBar")
		{
			TreasureMapUI.BGIMGOJDLFG(JIIGOACEIKL).OpenUI();
		}
	}

	public void GMOEJAJNPFL(int JIIGOACEIKL)
	{
		if (uiName == "Sound")
		{
			TreasureMapUI.NALKHGMLALJ(JIIGOACEIKL).OpenUI();
		}
	}

	public void MNPNGKGMCJP(int JIIGOACEIKL)
	{
		if (uiName == "Player2")
		{
			TreasureMapUI.PNCKAKBBKJL(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public void CJEICBDFKKL(int JIIGOACEIKL)
	{
		if (uiName == "RoadBlocked/Main 2")
		{
			TreasureMapUI.IEABDMDELFO(JIIGOACEIKL).OpenUI();
		}
	}

	public bool OLNJHIPLODD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			NIOPKEKCCJG(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool IKPNNKPDGPB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			PDEMELGAMHJ(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void NACGHKAACNP(int JIIGOACEIKL)
	{
		if (uiName == "descWardrobe")
		{
			TreasureMapUI.IGHMHMNPMLB(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void DPDIIFJCNCJ(int JIIGOACEIKL)
	{
		if (uiName == "Deselect item")
		{
			TreasureMapUI.MENNLOGFNOK(JIIGOACEIKL).OpenUI();
		}
	}

	public void NEICMFOJAEB(int JIIGOACEIKL)
	{
		if (uiName == "Remove")
		{
			TreasureMapUI.AANKLOIDPOA(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public bool PLELLIHELBH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).MDOKKKHKKKE() && (Object)(object)InputByProximityManager.DAEEJGKLOCF(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			IDLAGJNLPJL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool FFMEJABEPIO(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM() && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			NLBCJNEBHNO(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void BJOOJEMHOID(int JIIGOACEIKL)
	{
		if (uiName == "")
		{
			TreasureMapUI.CGFJPHEFFLO(JIIGOACEIKL).OpenUI();
		}
	}

	public void JGMACFIFANK(int JIIGOACEIKL)
	{
		if (uiName == "Shield")
		{
			TreasureMapUI.FFOABBDFMNE(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void NLBCJNEBHNO(int JIIGOACEIKL)
	{
		if (uiName == "Invalid playerNum")
		{
			TreasureMapUI.MIAOGLENOHL(JIIGOACEIKL).OpenUI();
		}
	}

	public bool JAKBKBNDBIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			GMOEJAJNPFL(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool EHHCPOCLAJA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			ODPOFGCOJFE(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void EBNDKDCNEHF(int JIIGOACEIKL)
	{
		if (uiName == "mForMins")
		{
			TreasureMapUI.FHOGLBPBGMI(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public void ELAJKAGJOBP(int JIIGOACEIKL)
	{
		if (uiName == "")
		{
			TreasureMapUI.FFOABBDFMNE(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public void LNGLKOJMPOJ(int JIIGOACEIKL)
	{
		if (uiName == "SalonDelTrono/TweekTalk")
		{
			TreasureMapUI.NMCJELBLKBB(JIIGOACEIKL).OpenUI();
		}
	}

	public bool KFHGMCNPAFM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			MNFJAANPELP(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void MNFJAANPELP(int JIIGOACEIKL)
	{
		if (uiName == "DueloDeViejos/KentaTalk")
		{
			TreasureMapUI.NIDHCIHFOHB(JIIGOACEIKL).IDLAGJNLPJL();
		}
	}

	public bool DLKLEHNNEPD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GFCOOKLMLNE() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			JEOOCDICJOO(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool FMKMJHKKHOB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE() && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).HBIKILDEHFI() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			DPDIIFJCNCJ(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool NGOFAPGCHEE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).MDOKKKHKKKE() && (Object)(object)InputByProximityManager.MBDFOJAKELO(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			EBNDKDCNEHF(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public bool LDCNBJGAILM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.GetPlayer(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).ABGDFIDOCCL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			GLEIEPDFALG(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool DIGALGJJGGJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).HOMHFEJHKIF() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			MJICKJFOKJP(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool JHHDPLMGMBM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)InputByProximityManager.IJMLNIHAOGK(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().playerExplosion, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			OECHNGPCGML(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool HDLIHDHCABE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)InputByProximityManager.HBDCJFLINDA(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			FMLCBMLIFJP(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool OEFLFKLLJHF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)InputByProximityManager.BPDFMAEOGGC(JIIGOACEIKL).GetCurrentFocusedInputElement() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			IDLAGJNLPJL(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void IDLAGJNLPJL(int JIIGOACEIKL)
	{
		if (uiName == "bathhouseinterior")
		{
			TreasureMapUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
		}
	}

	public bool GGIADKIJNKE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		if (KLGOCJMGKFO && !DecorationMode.BGINAIDHDOM(JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)InputByProximityManager.OGKNJNINGMH(JIIGOACEIKL).GDJNPPCMIBL() == (Object)null)
		{
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().playerExplosion, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			NACGHKAACNP(JIIGOACEIKL);
			return true;
		}
		return true;
	}
}
