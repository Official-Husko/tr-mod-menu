using UnityEngine;

public class ElevatorSwitch : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	public TravelZone travelZone;

	public TravelZone travelZone2;

	public void LGGKLLCDMNG(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.CFHEJAGKIII().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void DMKFEIDLIAN(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.CFHEJAGKIII().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool LIMJJHPMCEA(int JIIGOACEIKL)
	{
		return true;
	}

	public void GJDKDDMFGBM(int JIIGOACEIKL)
	{
	}

	public bool AAGOLOPJOHJ(int JIIGOACEIKL)
	{
		if (HLDFEKIDJAK(JIIGOACEIKL))
		{
			ElevatorSwitchUI.NMCJELBLKBB(JIIGOACEIKL).ENKMCLFMKPA(this);
			ElevatorSwitchUI.FHBIFJNCOAI(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return false;
	}

	public bool CHEBOFEFAPD(int JIIGOACEIKL)
	{
		return true;
	}

	public void DHGHGAGHECK(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.OLHBLKIAFOM().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void FOHBGMLFMEO(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.OACNNJCLEDE().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool NNACBJKBKDP(int JIIGOACEIKL)
	{
		return false;
	}

	public void KECJNJANCEK(int JIIGOACEIKL)
	{
	}

	public bool KJBLDGILHJI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HLDFEKIDJAK(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("FailStart"));
			return false;
		}
		return true;
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public void GLFGADGGGOM(int JIIGOACEIKL)
	{
	}

	public void BFKDGNPAJDE(int JIIGOACEIKL)
	{
	}

	public void GGCCMCLILLH(int JIIGOACEIKL)
	{
	}

	public void JAMLMEGHCKD(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.CFHEJAGKIII().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void KKEMPCJDOBG(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.DCAEBALADIM().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void EPADOBKDNKG(int JIIGOACEIKL)
	{
	}

	public void SetTravelZone(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.GGFJGHHHEJC.allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void HACPCOIPNDD(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void BLLCPBNGMEE(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.OACNNJCLEDE().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool DEEFMMKDBJB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("grow all plants"));
			return true;
		}
		return true;
	}

	public void MHDDGJHCAGF(int JIIGOACEIKL)
	{
	}

	public bool FGONKCAKHLE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IALLCPMIGDP(int JIIGOACEIKL)
	{
		return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool EAOHDAKIJCK(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ElevatorSwitchUI.IEABDMDELFO(JIIGOACEIKL).FKEGGCLEBGN(this);
			ElevatorSwitchUI.MLJJHLNAGBP(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return true;
	}

	public void AOEOBNOPLIG(int JIIGOACEIKL)
	{
	}

	public bool OFBABFAOFEJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void JDFNIFFJEBJ(int JIIGOACEIKL)
	{
	}

	public bool KJFFGGMPCPI(int JIIGOACEIKL)
	{
		return DecorationMode.GetPlayer(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void APALHPDOLLI(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.LKOABOAADCD().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void MJNNGIAAGFH(int JIIGOACEIKL)
	{
	}

	public void LHBAHANFOGL(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.GFMBEDCANNI().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ElevatorSwitchUI.Get(JIIGOACEIKL).SetElevatorSwitch(this);
			ElevatorSwitchUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void FECPHPJAEAE(int JIIGOACEIKL)
	{
	}

	public void KLKLOIIFOEC(int JIIGOACEIKL)
	{
	}

	public bool AFOBLAONEDM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Path is blocked"));
			return false;
		}
		return true;
	}

	public void DAFFDEDGGCL(int JIIGOACEIKL)
	{
	}

	public bool LNPNMIGHCCH(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void PFEBMBCLAJM(int JIIGOACEIKL)
	{
	}

	public bool KGEDLMDOIAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void NAHGJLOOLOI(int JIIGOACEIKL)
	{
	}

	public bool OFNDBHLFIEK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		return false;
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool DOGECDPIPBA(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void ONCCCCECLOO(int JIIGOACEIKL)
	{
	}

	public void OLFFLKHPAPK(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.OMFKNGDCJFN().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ElevatorSwitchUI.JHJKHEBKCFL(JIIGOACEIKL).NNJOFMOCKMJ(this);
			ElevatorSwitchUI.ODLPIANFFFJ(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public bool FHNNADMKNOD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_description_671"));
			return true;
		}
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Use"));
			return true;
		}
		return false;
	}

	public bool KOLGJHCLPNE(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void FBNFCONOMDB(int JIIGOACEIKL)
	{
	}

	public bool PHGADHENHDF(int JIIGOACEIKL)
	{
		if (LNPNMIGHCCH(JIIGOACEIKL))
		{
			ElevatorSwitchUI.JHJKHEBKCFL(JIIGOACEIKL).FPNCMJOOHAN(this);
			ElevatorSwitchUI.FHBIFJNCOAI(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return true;
	}

	public void PIPHCJALBMA(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.OACNNJCLEDE().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool PIJNGCIFLPG(int JIIGOACEIKL)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL))
		{
			ElevatorSwitchUI.HICGKNJMGOE(JIIGOACEIKL).FKEGGCLEBGN(this);
			ElevatorSwitchUI.IEABDMDELFO(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return true;
	}

	public void FGIBCBOHCEB(int JIIGOACEIKL)
	{
	}

	public void FPHKGEPEEOL(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.EKDNJDJHONF().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool NLJKBACPIFA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void GPECKPBIENC(int JIIGOACEIKL)
	{
	}

	public bool FBFGOFLDOHL(int JIIGOACEIKL)
	{
		if (HLDFEKIDJAK(JIIGOACEIKL))
		{
			ElevatorSwitchUI.MLJJHLNAGBP(JIIGOACEIKL).ENKMCLFMKPA(this);
			ElevatorSwitchUI.JHJKHEBKCFL(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return true;
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool HHJKCBGJABC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public bool AJCGEBOAAIJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReciveSimpleDialogueStart"));
			return false;
		}
		return false;
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public bool EHFNNOCENEL(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool LLKEFECABJD(int JIIGOACEIKL)
	{
		if (LNPNMIGHCCH(JIIGOACEIKL))
		{
			ElevatorSwitchUI.NMCJELBLKBB(JIIGOACEIKL).NBAOOEDKGHI(this);
			ElevatorSwitchUI.ODLPIANFFFJ(JIIGOACEIKL).OpenUI();
			return false;
		}
		return false;
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public bool AKFCDDOMNBF(int JIIGOACEIKL)
	{
		if (LNPNMIGHCCH(JIIGOACEIKL))
		{
			ElevatorSwitchUI.NJOFJHCKGAL(JIIGOACEIKL).PINIOJFENPJ(this);
			ElevatorSwitchUI.HICGKNJMGOE(JIIGOACEIKL).OpenUI();
			return false;
		}
		return false;
	}

	public bool EDMPHCDAGCE(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void MLOBKOONNMH(int JIIGOACEIKL)
	{
	}

	public void FDFJKOHMPON(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.OACNNJCLEDE().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public void IJOHPJPPHHG(int JIIGOACEIKL)
	{
	}

	public void HLNEGJCBPOA(int JIIGOACEIKL)
	{
	}

	public void KCMEKGJPNAO(int JIIGOACEIKL)
	{
	}

	public bool AEEKGBMEPFF(int JIIGOACEIKL)
	{
		if (LNPNMIGHCCH(JIIGOACEIKL))
		{
			ElevatorSwitchUI.ODLPIANFFFJ(JIIGOACEIKL).KLEJOHIJNPF(this);
			ElevatorSwitchUI.Get(JIIGOACEIKL).OpenUI();
			return false;
		}
		return true;
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool DJHCNCJGHAL(int JIIGOACEIKL)
	{
		if (DGNGLGMBIHE(JIIGOACEIKL))
		{
			ElevatorSwitchUI.FHBIFJNCOAI(JIIGOACEIKL).IFEKHIMMJKA(this);
			ElevatorSwitchUI.NMCJELBLKBB(JIIGOACEIKL).OpenUI();
			return false;
		}
		return false;
	}

	public bool DGNGLGMBIHE(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).GABNNLJOMHI();
	}

	public void HEMNJNAGBAA(int EONJGMONIOM)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		travelZone.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		travelZone2.mineStairs = new Vector2Int(EONJGMONIOM, EONJGMONIOM);
		TravelZonesManager.BGMJCCFNNDL().allMineStairs[travelZone.mineStairs] = travelZone;
	}

	public bool HLDFEKIDJAK(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void LGDKFCALLKA(int JIIGOACEIKL)
	{
	}

	public void DCBLHLOFPMK(int JIIGOACEIKL)
	{
	}

	public void FALDJPENKME(int JIIGOACEIKL)
	{
	}

	public void CPMBHEGDAMB(int JIIGOACEIKL)
	{
	}

	public void MOBFEFJFGBE(int JIIGOACEIKL)
	{
	}

	public void GHAHHGPDNNH(int JIIGOACEIKL)
	{
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}
}
