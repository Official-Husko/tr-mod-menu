using UnityEngine;

public class AnimalFeederWaterHenHouse : AnimalFeeder
{
	public int currentAmount;

	public void PKNJAPDPLBB(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void HOJCDNHHMMO(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.SendFillWater(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private void OPPNDACPPFM(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.HENDOOOJGOG(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	public void GPICEMCDCMN(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public override bool WasteUnit(int HFDILBELIKE)
	{
		if (currentAmount == 0)
		{
			return false;
		}
		currentAmount = Mathf.Max(0, currentAmount - HFDILBELIKE);
		UpdateSprite();
		return true;
	}

	public void JHPGPCBHPCK(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	protected override void Start()
	{
		base.Start();
		UpdateSprite();
	}

	public void GOIPMBAIJCC(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void NAGNFOAMAFB(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void DIEBNPAAGOE(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.MIEMNIPKJDI(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	public override void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void GGNINGHAHKF(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void LMJNADIOHDN(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.OEBLFMBFOGE(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void KENJAKKMEEA(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void HPJIKOHJENM(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void LKMOMILNBOE(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.JFEPHOBNBPB(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private void HHMJNMJNAIO(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.HMIMKBCMIDJ(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void OPNAJLAJEOK(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.DBBNNCFPINH(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void NAOKJNHBDLN(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void EBCBHFGLPGH(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void AAHANKFFOCN(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.HLFFPDEJLBD(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void FHJPDEIMMDN(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.IMHLJJJMGBF(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void OIJGLEINGIH(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.GJHCCLAOACB(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void CECGBBPENOP(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.MIEMNIPKJDI(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void AFLBPKKOHMI(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.AOFHAJHHJNH(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	public void MPKOAEALJGK(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void GAGHIDOOBAC(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void LNFCMHANNCF(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void PFOILGEADDH(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.OFACCOGBIIO(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void NGJDAKBOACM(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.GHGBIDMIBHG(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void FABMIMJJMHP(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void FIFDEHKIDID(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void ALMOIGOJFCP(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.ENAGOFPPIIA(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void BCHFIJHLLIC(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.MACOAAHOAMM(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void PEHHFCECICH(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.HOKNEFKPEEL(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void OLBBBIOBBAL(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void EBPPNNJPIEM(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void IJBBHOKLEAL(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.IAJECPNCILN(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void GCCCMGFCDGI(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public override void ResetState()
	{
	}

	public void ABMDKACNJBJ(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void IJKKFAJMOBE(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void HCBCHHENHKF(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void OKKLGBGDPCB(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.HMIMKBCMIDJ(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private void BLFEAJJFLGP(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.CAFLHOLKBHI(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void ACMMGFJOPNK(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.GHGBIDMIBHG(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void CCCFOGKPKPM(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void CCABBDFMPDK(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void AENKHACIFNO(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void PFAFAMDMAFD(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.LAOIMEHEIBC(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void OGFFFOCAPMG(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.FDFJMFPOCNM(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void EEDOFIFNPCH(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void FHPNELDGMEA(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.MACOAAHOAMM(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	public void DJOKJCAFNHN(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void GMGHGHDNHHG(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.ENAGOFPPIIA(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void JILLEKEGDKM(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void CEKCNEFEHCP(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void HJFBAPKENJN(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void BDCPLKGPLBH(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void AGDGIJPINNM(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void CJDABDHAPPJ(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void JDDNGKGLFCL(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void ALDIEECPJLO(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.LKNNJEIEGDM(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private void DGPDPMFOLLM(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.GHHEDDDFFJF(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void HAOCABJMOLD(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void DPNJBOANCMA(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void NAGALOCDDCE(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void CBAEIKDIGEH(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void CCNBHJJCJJB(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (HFKDOAMFAHJ && IsAvailableByProximity(JIIGOACEIKL) && CanFillWithWater(JIIGOACEIKL))
		{
			HOJCDNHHMMO(JIIGOACEIKL, 3);
		}
		return false;
	}

	public void LoadWaterFeeder(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void NIKEPELCCDB(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.MACOAAHOAMM(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void BIJILIOIDLG(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	private void IFBILOPPPEO(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.DBBNNCFPINH(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	public override void Improve()
	{
		base.Improve();
		UpdateSprite();
	}

	public void PDIAJKCDBKN(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void IKALIBNCDAP(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).OpenUI();
			if (HFKDOAMFAHJ)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Fill"));
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetWaterFeederBar(currentAmount, maxAmount[base.EONJGMONIOM]);
			return true;
		}
		return false;
	}

	public void EHOFCNEIECE(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public override int GetCurrentAmount()
	{
		return currentAmount;
	}

	public override void UpdateSprite()
	{
		for (int i = 0; i < improvementsGO.Length; i++)
		{
			((Component)improvementsGO[i]).gameObject.SetActive(i == base.EONJGMONIOM);
		}
		MIBCPFGIABD();
	}

	private void CIBMAKCPLGF(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.IMHLJJJMGBF(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void NBPIPFIIMOI(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void GEIIJPBFIMB(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void BDDKPNFAGIL(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.IMHLJJJMGBF(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void LGCCBAOAIHK(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void IDNBBLNFIAL(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.LKNNJEIEGDM(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	public void OBONIHBACPK(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void SetCurrentAmount(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	private void HIBFLCFEACJ(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.HENDOOOJGOG(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	private void MAJEMLLMFOH(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		if (farmBuilding.placeable.onlinePlaceable is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.SendFillWater(id, currentAmount);
		}
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void MIIPCNGMPPE(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void IHMCOEHGGCF(int HFEBHJBFNHI, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}
}
