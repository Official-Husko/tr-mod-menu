using System.Collections.Generic;
using TMPro;

public class MainInventoryUI : InventoryUI
{
	public static MainInventoryUI[] instances = new MainInventoryUI[3];

	public MainActionBarUI mainActionBarUI;

	protected override void Update()
	{
		base.Update();
		if (!IsOpen() || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			return;
		}
		if (GameManager.LocalCoop() && numPages > 1)
		{
			CHAEMDNAODI = CheckNextPage(ref CMGDCLIIONE, currentPage, numPages, null, "UINextCategory", "UIPreviousCategory");
			if (CHAEMDNAODI > -1)
			{
				FocusPage(CHAEMDNAODI);
			}
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (SelectObject.GetPlayer(base.JIIGOACEIKL).focusedSlot != null)
			{
				((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("Remove");
			}
			else
			{
				((TMP_Text)sortByTypeTextMesh).text = LocalisationSystem.Get("SortByType");
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("UIAddRemove") && !DropItemsFocusedSlot())
			{
				Inventory.GetPlayer(base.JIIGOACEIKL).OrderItemsByType(0);
			}
		}
	}

	public void APONGDPMHAF()
	{
		Inventory.NLEFGNHMJNN(base.JIIGOACEIKL, LAGHIOKLJGH: true).HHNHNOCIFEM(0);
	}

	public void DNELMIMHADB()
	{
		Inventory.MHFEFCLBAJG(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DKAEEOOJOHN(0, CDPAMNIPPEC: false);
	}

	public void DKAEEOOJOHN()
	{
		Inventory.JFIPFFDLDKB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HPIAKEJIKMG(0, CDPAMNIPPEC: false);
	}

	public void ACKCLGHFPKI()
	{
		Inventory.GIAOPMIDGPL(base.JIIGOACEIKL, LAGHIOKLJGH: true).OrderItemsByType(0, CDPAMNIPPEC: false);
	}

	public void ABIPDEOCPGF()
	{
		Inventory.OCJGHINCLJM(base.JIIGOACEIKL, LAGHIOKLJGH: true).HHNHNOCIFEM(0);
	}

	public void OrderItemsByType()
	{
		Inventory.GetPlayer(base.JIIGOACEIKL).OrderItemsByType(0);
	}

	public static MainInventoryUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void PFOJFILNJIN(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.ELFGBIGCFGL(JIIGOACEIKL, ADEBNALPEHE, ActionBarInventory.GetPlayer(JIIGOACEIKL));
	}

	public static MainInventoryUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HHNHNOCIFEM()
	{
		Inventory.KCOBKJNCKNP(base.JIIGOACEIKL, LAGHIOKLJGH: true).HHNHNOCIFEM(1, CDPAMNIPPEC: false);
	}

	public static MainInventoryUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void GKAJFEOGKMD(int JIIGOACEIKL, Slot ADEBNALPEHE)
	{
		Utils.FNCKBOHPFFJ(JIIGOACEIKL, ADEBNALPEHE, ActionBarInventory.GetPlayer(JIIGOACEIKL));
	}

	public void JJEMOPDEMIN()
	{
		Inventory.OCJGHINCLJM(base.JIIGOACEIKL, LAGHIOKLJGH: true).HPIAKEJIKMG(0);
	}

	public void NFMMAEOKKKO()
	{
		Inventory.IOBMIHLMGNH(base.JIIGOACEIKL).HHNHNOCIFEM(1);
	}

	public void HLKJNEKDDNJ()
	{
		Inventory.JFIPFFDLDKB(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DKAEEOOJOHN(0);
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	public void ODKIKEINMNB()
	{
		Inventory.MHFEFCLBAJG(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HHNHNOCIFEM(0);
	}

	public static MainInventoryUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JENPMGMPMDP()
	{
		Inventory.NHHOGHLEODI(base.JIIGOACEIKL).MNLBBGCOIEA(1, CDPAMNIPPEC: false);
	}

	public override void OpenUI()
	{
		if (!IsOpen() && !Utils.FNLJGAEHNKA())
		{
			if (GameInventoryUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				GameInventoryUI.Get(base.JIIGOACEIKL).CloseUI();
			}
			mainActionBarUI.OpenUI();
			base.OpenUI();
		}
	}

	public void OCNJJABLOLN()
	{
		Inventory.MPDMDABCCCA(base.JIIGOACEIKL).HPIAKEJIKMG(1);
	}

	public static MainInventoryUI CGFJPHEFFLO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NBEKCINLCJI()
	{
		Inventory.IOBMIHLMGNH(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HHNHNOCIFEM(1);
	}

	public void BLAAPINNOIN()
	{
		Inventory.ILAOFABODGO(base.JIIGOACEIKL).HPIAKEJIKMG(0, CDPAMNIPPEC: false);
	}

	public static MainInventoryUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static MainInventoryUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	protected override void Start()
	{
		base.Start();
		if (numInstance > 0)
		{
			PreparePagesMode(new List<Slot>(Inventory.GetPlayer(base.JIIGOACEIKL).slots), OGCAKIGELBJ: true, MMMCDGNCKJH: false);
		}
	}

	public static MainInventoryUI NIGDBMAOAEN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static MainInventoryUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static MainInventoryUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void NHJBBEEFPFB()
	{
		Inventory.GIAOPMIDGPL(base.JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HHNHNOCIFEM(1);
	}

	public static MainInventoryUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static MainInventoryUI AKMJEPMHFMO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OLDILKIBNBH()
	{
		Inventory.DAEEJGKLOCF(base.JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HPIAKEJIKMG(1, CDPAMNIPPEC: false);
	}

	public static MainInventoryUI IGHMHMNPMLB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			mainActionBarUI.CloseUI();
			base.CloseUI();
		}
	}

	public void LCEDNGDNGPN()
	{
		Inventory.JPDEFKLINCL(base.JIIGOACEIKL, LAGHIOKLJGH: true).HPIAKEJIKMG(0, CDPAMNIPPEC: false);
	}

	public static MainInventoryUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public override void CloseUIRemainActive()
	{
		mainActionBarUI.CloseUI();
		base.CloseUIRemainActive();
	}

	public static MainInventoryUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}
}
