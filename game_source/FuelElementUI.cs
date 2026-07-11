using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class FuelElementUI : SlotUIRecipe
{
	public TextMesh fuelText;

	public void BAJKLJPHKFL()
	{
		Placeable crafterPlaceableZone = FuelUI.JELOGNCPDAB(JIIGOACEIKL).GetCrafterPlaceableZone();
		BHMAEAOBAMN(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), crafterPlaceableZone, LJPHECMPECH: false));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, crafterPlaceableZone);
		base.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(1, num));
	}

	public void DGCKHDDDIBM()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		PABPIGGOEMO();
	}

	public void MJIFFMNOKBL()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		PNILDPCIBBL();
	}

	public void MCNJOLGJBJA()
	{
		Placeable fLAAGFECLME = FuelUI.IOFMOGAPGID(JIIGOACEIKL).CIHODADDHFB();
		GMKEFJHNCPP(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(0, num));
	}

	public void FIDNJNIPGIM()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		GBHDIMEBKEA();
	}

	public void PABPIGGOEMO()
	{
		Placeable fLAAGFECLME = FuelUI.LJONDAEOMFJ(JIIGOACEIKL).HEIMJKMMNEO();
		GLBKFPCMIFL(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(0, num));
	}

	public void PMOGLENNPEN()
	{
		Placeable crafterPlaceableZone = FuelUI.FHPEHDDFOIB(JIIGOACEIKL).GetCrafterPlaceableZone();
		JJLCAPLAEFI(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), crafterPlaceableZone, LJPHECMPECH: true));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), AKNBKINJGCF: false, crafterPlaceableZone, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
	}

	public void MEBFNBNELBH()
	{
		Placeable fLAAGFECLME = FuelUI.IPDFCJLOHLC(JIIGOACEIKL).AKLCDEFOKMI();
		KBHDAKNMHLL(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.LPEGAFPFKLH(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
	}

	public void LOFNIECDBAF()
	{
		Placeable fLAAGFECLME = FuelUI.IMLMJAPMBJA(JIIGOACEIKL).CIHODADDHFB();
		CKDEBFGEECF(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, fLAAGFECLME);
		base.IHENCGDNPBL.Stack = Mathf.Max(0, num);
	}

	public void PGFEPFCAKGP()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		MCIBPHCHFAB();
	}

	public void LGFHMKPCIMC()
	{
		Placeable fLAAGFECLME = FuelUI.LJONDAEOMFJ(JIIGOACEIKL).LGDAICBJJNI();
		MNAPPOGFFJA(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.KCCBHHEGEHG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.Stack = Mathf.Max(0, num);
	}

	public void HPOCMAIDMAF()
	{
		Placeable fLAAGFECLME = FuelUI.IMLMJAPMBJA(JIIGOACEIKL).IJGDLDJLKMM();
		FEBIKPICADP(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.LPEGAFPFKLH(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: true, fLAAGFECLME);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
	}

	public void PNEMCJOPJCD()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		NDMDBECHDCL();
	}

	public void FONMOPCKDFA()
	{
		Placeable fLAAGFECLME = FuelUI.IMLMJAPMBJA(JIIGOACEIKL).CDFGGPKNDNJ();
		MNAPPOGFFJA(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
	}

	public void EHEOAKJDLCE()
	{
		Placeable crafterPlaceableZone = FuelUI.FHPEHDDFOIB(JIIGOACEIKL).GetCrafterPlaceableZone();
		HOKAPNACGAJ(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), crafterPlaceableZone, LJPHECMPECH: false));
		int num = CraftingInventory.KCCBHHEGEHG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, crafterPlaceableZone, AHCENOLCIBM: true);
		base.IHENCGDNPBL.Stack = Mathf.Max(1, num);
	}

	public void AIMDCFPDOMA()
	{
		Placeable fLAAGFECLME = FuelUI.HDMPJKMLFML(JIIGOACEIKL).HEIMJKMMNEO();
		KBHDAKNMHLL(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.LEMBKIDEHPM(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(1, num));
	}

	public void OOKANHIBNDE()
	{
		Placeable fLAAGFECLME = FuelUI.IOFMOGAPGID(JIIGOACEIKL).AKLCDEFOKMI();
		PEEFNLGEJEP(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(1, num));
	}

	public void CIHJKHMIJAH()
	{
		Placeable fLAAGFECLME = FuelUI.JELOGNCPDAB(JIIGOACEIKL).MBAEOPCPJLH();
		HOKAPNACGAJ(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
	}

	public void PGINLECPMNK()
	{
		Placeable fLAAGFECLME = FuelUI.JELOGNCPDAB(JIIGOACEIKL).HEIMJKMMNEO();
		MNAPPOGFFJA(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.KCCBHHEGEHG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void LNICNFLHMHP()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		PABPIGGOEMO();
	}

	public void LOEPFAHGDIA()
	{
		Placeable fLAAGFECLME = FuelUI.OHPNDOJNCBK(JIIGOACEIKL).CDFGGPKNDNJ();
		base.FBBAFPGFLPE = CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: false);
		int num = CraftingInventory.LEMBKIDEHPM(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void CEPDCLGCMBA()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		MCNJOLGJBJA();
	}

	public void NPEEMGKMKFJ()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		BAKGAHONABL();
	}

	public void HMADLHKBAFI()
	{
		Placeable fLAAGFECLME = FuelUI.EAONFFENMCE(JIIGOACEIKL).CIHODADDHFB();
		MGNPDPNCOPN(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
	}

	public void PNILDPCIBBL()
	{
		Placeable fLAAGFECLME = FuelUI.IOFMOGAPGID(JIIGOACEIKL).AKLCDEFOKMI();
		CCKGNKFFDKH(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.LPEGAFPFKLH(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(0, num));
	}

	public void DOIIEMFNGND()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		GBHDIMEBKEA();
	}

	public void PKHFJAIBCDI()
	{
		Placeable fLAAGFECLME = FuelUI.COIEMAJLHAM(JIIGOACEIKL).IJGDLDJLKMM();
		AAGLAEIKHHC(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.LPEGAFPFKLH(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(1, num));
	}

	public void HHNMBJOCPII()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		PGINLECPMNK();
	}

	public void KBHEDHGEFLE()
	{
		Placeable fLAAGFECLME = FuelUI.EAONFFENMCE(JIIGOACEIKL).NNLBHCEMGLB();
		PBBMFMDIAJB(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void DFHHDDKIJED()
	{
		Placeable crafterPlaceableZone = FuelUI.LJONDAEOMFJ(JIIGOACEIKL).GetCrafterPlaceableZone();
		FMEKDKEMBMN(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), crafterPlaceableZone, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: true, crafterPlaceableZone, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(0, num));
	}

	public void FuelClicked()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		UpdateElement();
	}

	public void JJCFOLIKILG()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		LOEPFAHGDIA();
	}

	protected override void OnDisable()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
		if (Application.isPlaying)
		{
			CraftingInventory.OnChanged = (Action)Delegate.Remove(CraftingInventory.OnChanged, new Action(UpdateElement));
		}
	}

	public void LBDPDNIOGAE()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		DFHHDDKIJED();
	}

	public void NNDPINKMFFC()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		LGFHMKPCIMC();
	}

	public void BCDACPKOMDN()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		LJPLMGOPIDD();
	}

	public void BAKGAHONABL()
	{
		Placeable fLAAGFECLME = FuelUI.EAONFFENMCE(JIIGOACEIKL).ECONGAOHINM();
		HOKAPNACGAJ(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(1, num));
	}

	public void NDMDBECHDCL()
	{
		Placeable fLAAGFECLME = FuelUI.FHOGLBPBGMI(JIIGOACEIKL).GAKAFIDHKII();
		DHFIIFNMAOI(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.LPEGAFPFKLH(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JIANDFCINIP(Mathf.Max(0, num));
	}

	public void MCIBPHCHFAB()
	{
		Placeable fLAAGFECLME = FuelUI.FHOGLBPBGMI(JIIGOACEIKL).NNLBHCEMGLB();
		ACLCGMPDEAL(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
	}

	public void NPCMKBHJPMF()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		NDMDBECHDCL();
	}

	public void LDPBKGFBBBM()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		DFHHDDKIJED();
	}

	public void LJPLMGOPIDD()
	{
		Placeable fLAAGFECLME = FuelUI.COIEMAJLHAM(JIIGOACEIKL).CMDBPIBIIJD();
		BHMAEAOBAMN(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(1, num));
	}

	public void LMOHHFCFIEM()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		BCPLGIJLLAD();
	}

	public void EIHJFIGHOKL()
	{
		Placeable fLAAGFECLME = FuelUI.BPBMLNJGGII(JIIGOACEIKL).GAKAFIDHKII();
		MNAPPOGFFJA(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.LEMBKIDEHPM(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void HMFKFJJLDKE()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		BAJKLJPHKFL();
	}

	public void BNEFBNDNKAI()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		BMCCDAKOAIJ();
	}

	public void FFNILLFGOLN()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		GBHDIMEBKEA();
	}

	public void BCPLGIJLLAD()
	{
		Placeable crafterPlaceableZone = FuelUI.LJONDAEOMFJ(JIIGOACEIKL).GetCrafterPlaceableZone();
		DMLDKKELFOJ(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), crafterPlaceableZone, LJPHECMPECH: true));
		int num = CraftingInventory.LPEGAFPFKLH(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, crafterPlaceableZone);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void DIHGEJIAAPO()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		MIHFFNFJFCE();
	}

	public override void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EGHPILDBOIB(NKFPJPCFBJI: true, JIIGOACEIKL);
		}
	}

	public void AJEFOBANEFE()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		CIHJKHMIJAH();
	}

	public void JFHCPBJONGE()
	{
		Placeable fLAAGFECLME = FuelUI.IPDFCJLOHLC(JIIGOACEIKL).OFLIGINIPEF();
		FEBIKPICADP(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
	}

	public void LCOBLJEIADI()
	{
		Placeable fLAAGFECLME = FuelUI.LJONDAEOMFJ(JIIGOACEIKL).CDLILGOJMPE();
		DMLDKKELFOJ(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.LEMBKIDEHPM(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void EAHAFECEMBK()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		BCPLGIJLLAD();
	}

	public void NLLNCNAAOAO()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		LJPLMGOPIDD();
	}

	public void UpdateElement()
	{
		Placeable crafterPlaceableZone = FuelUI.Get(JIIGOACEIKL).GetCrafterPlaceableZone();
		base.FBBAFPGFLPE = CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), crafterPlaceableZone, LJPHECMPECH: false);
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: true, crafterPlaceableZone);
		base.IHENCGDNPBL.Stack = Mathf.Max(1, num);
	}

	public void PDPKKLKFNJH()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		OOKANHIBNDE();
	}

	public void BCFBADKNMDO()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		LCOBLJEIADI();
	}

	public void KJPBMKOJGJA()
	{
		Placeable fLAAGFECLME = FuelUI.EAONFFENMCE(JIIGOACEIKL).MBAEOPCPJLH();
		JJLCAPLAEFI(CraftingInventory.HasItem(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.KCCBHHEGEHG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(0, num));
	}

	public void CIPNBDCLGEJ()
	{
		Placeable fLAAGFECLME = FuelUI.FHPEHDDFOIB(JIIGOACEIKL).GAKAFIDHKII();
		GMKEFJHNCPP(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.LEMBKIDEHPM(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: true, fLAAGFECLME);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
	}

	public void CMDCFPJPEFE()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		EHEOAKJDLCE();
	}

	public void DEPONPCJJAK()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		EHEOAKJDLCE();
	}

	public void NDDGKAJDOOL()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		AIMDCFPDOMA();
	}

	public void BFNPMJOHHNJ()
	{
		Placeable fLAAGFECLME = FuelUI.IPDFCJLOHLC(JIIGOACEIKL).MBAEOPCPJLH();
		FEBIKPICADP(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public override void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EGHPILDBOIB(NKFPJPCFBJI: false, JIIGOACEIKL);
		}
	}

	public void MPANJBPCCHD()
	{
		Placeable crafterPlaceableZone = FuelUI.HDMPJKMLFML(JIIGOACEIKL).GetCrafterPlaceableZone();
		MGNPDPNCOPN(CraftingInventory.JKLEPGLMCEG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), crafterPlaceableZone, LJPHECMPECH: false));
		int num = CraftingInventory.NumberOfItems(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: true, crafterPlaceableZone, AHCENOLCIBM: true);
		base.IHENCGDNPBL.JNMNCEPHFOE(Mathf.Max(0, num));
	}

	public void MIHFFNFJFCE()
	{
		Placeable fLAAGFECLME = FuelUI.IPDFCJLOHLC(JIIGOACEIKL).GAKAFIDHKII();
		IAAEKKLNMEJ(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OBBKDJNLCIO(Mathf.Max(1, num));
	}

	public void EIFDLDHLPPM()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		EHEOAKJDLCE();
	}

	public void LGCDBBBGKGO()
	{
		Placeable fLAAGFECLME = FuelUI.HDMPJKMLFML(JIIGOACEIKL).IIOPNKMLEOH();
		PEEFNLGEJEP(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), fLAAGFECLME, LJPHECMPECH: false));
		int num = CraftingInventory.LEMBKIDEHPM(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), AKNBKINJGCF: false, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.KMKAIPMHANN(Mathf.Max(0, num));
	}

	protected override void OnEnable()
	{
		if (Application.isPlaying)
		{
			UpdateElement();
			CraftingInventory.OnChanged = (Action)Delegate.Combine(CraftingInventory.OnChanged, new Action(UpdateElement));
		}
	}

	protected override void Start()
	{
		if (Application.isPlaying)
		{
			UpdateElement();
		}
	}

	public void BMCCDAKOAIJ()
	{
		Placeable fLAAGFECLME = FuelUI.JELOGNCPDAB(JIIGOACEIKL).AKLCDEFOKMI();
		PEEFNLGEJEP(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.ICCOLMNMGJJ(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: false, fLAAGFECLME);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
	}

	public void NNBMJIBIEEJ()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		MCNJOLGJBJA();
	}

	public void APEIMBPHCNA()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		PKHFJAIBCDI();
	}

	public void LBMOGBNKBJF()
	{
		ICGOPHNHFMO(JIIGOACEIKL);
		MIHFFNFJFCE();
	}

	public void GBHDIMEBKEA()
	{
		Placeable fLAAGFECLME = FuelUI.COIEMAJLHAM(JIIGOACEIKL).MBAEOPCPJLH();
		BHMAEAOBAMN(CraftingInventory.FLLDAMPLHKI(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), fLAAGFECLME, LJPHECMPECH: true));
		int num = CraftingInventory.KCCBHHEGEHG(JIIGOACEIKL, base.IHENCGDNPBL.itemInstance.KNFNJFFCFNO(), AKNBKINJGCF: true, fLAAGFECLME, AHCENOLCIBM: true);
		base.IHENCGDNPBL.OCJOJKJPDNO(Mathf.Max(0, num));
	}
}
