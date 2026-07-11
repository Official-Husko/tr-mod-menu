using System;
using UnityEngine;

public class NoticeBoardUI : UIWindow
{
	public GameObject firstElementSelected;

	private static NoticeBoardUI[] GJBBNHCMNJN = new NoticeBoardUI[3];

	public void MILMIOHLFCL()
	{
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI MLJJHLNAGBP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void FPOJHJGBGOF()
	{
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			base.CloseUI();
			SelectObject.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			base.OpenUI();
		}
	}

	public static NoticeBoardUI ENIICLMAPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void ABICNJEIPDJ()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).OpenUI();
	}

	public void DLLIIDFCFHO()
	{
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI LPJPJMPOHPG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI NDJAMDLOIJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI NAGEHKBLJDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI OHPNDOJNCBK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI AIMEAJAHLAA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI HICGKNJMGOE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void OCFMLKHAFLM()
	{
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.Get(base.JIIGOACEIKL).OpenUI();
	}

	public void DPPPIJGLOJB()
	{
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI BBDNJAKIBFN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void BKAGDNJALAL()
	{
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public static NoticeBoardUI IEABDMDELFO(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void MFDJABLPPEC()
	{
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void FBPIHKMEIPO()
	{
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI ODLPIANFFFJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void GHIIMLEMGLL()
	{
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.BFCEHJIIAHN(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void DHAMFLFFJFG()
	{
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.BFCEHJIIAHN(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public static NoticeBoardUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI EAONFFENMCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void CCHHMIIEPMG()
	{
		CalendarUI.Get(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI HEGPDGJEOPC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void IFLICJLOFNF()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).OpenUI();
	}

	public void OpenCalendar()
	{
		CalendarUI.Get(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.Get(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI GDFNPHJJCPP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI FHKGDLNJFFA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI COIEMAJLHAM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void MGLLCLDHIKI()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void MDHAHCCMPJB()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public static NoticeBoardUI ILDNNNMOCOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
		}
	}

	public static NoticeBoardUI FFOABBDFMNE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void BIOEBFLFOKB()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void DIPBIKOBEHE()
	{
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public static NoticeBoardUI KDLDGFBDDCN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI KNMACJDNGEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void EGAOFIGODFG()
	{
		CalendarUI.Get(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public static NoticeBoardUI JGNOJMLHPOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void IMLIONHOPHJ()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.Get(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void LOEKNMJAKMH()
	{
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI EGBMJGOCIJJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI AANKLOIDPOA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI CJMILOMGFJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI FLNPIJOHBIP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void LMALLIAOJFF()
	{
		CalendarUI.Get(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).OpenUI();
	}

	public void MKFALCEFEJO()
	{
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.BFCEHJIIAHN(base.JIIGOACEIKL).OpenUI();
	}

	public void IDAHEEFBGFG()
	{
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).OpenUI();
	}

	public void EOJCNOPLAAD()
	{
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void INAIIJFGJIM()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void MCGMNNIBBPN()
	{
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).OpenUI();
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	public static NoticeBoardUI LKJNAHIPOLN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void JJFKJDJKJJG()
	{
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI FBKOKJCKICN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI EIMDPBGBBIF(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI NHOFBAMNELD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI FHBIFJNCOAI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI LIFMPGJIEKC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void IFNLCFKHNNA()
	{
		CalendarUI.Get(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI NJOFJHCKGAL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void FKLNJHKIFAJ()
	{
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void HCBFJEBOHJD()
	{
		CalendarUI.LAIEKOOCNPC(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI NMCJELBLKBB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI AEJKCONFPHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void NOCADGPMDJF()
	{
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.Get(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI MDINEPBJFKG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void FHCHHHPPBPB()
	{
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.Get(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI PNBHIEINMGH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void OPKJHCADLHG()
	{
		CalendarUI.BFCEHJIIAHN(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.EPLOMIBMKFC(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void FIAMGOODFLP()
	{
		CalendarUI.BFCEHJIIAHN(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).OpenUI();
	}

	public void BPLKFANIOMI()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void DBOBIJCELLJ()
	{
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.HKCAIFFKBMH(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public static NoticeBoardUI PKNHLBOHEDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI HKCAIFFKBMH(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI MENNLOGFNOK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public static NoticeBoardUI KLJCCHJHDGG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public void JCMGDMDCJKA()
	{
		CalendarUI.PIOIOJFDDNF(base.JIIGOACEIKL).openedFromNoticeBoard = true;
		CalendarUI.NDPAJCGHGOB(base.JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void IOEMONHBOHI()
	{
		CalendarUI.BFCEHJIIAHN(base.JIIGOACEIKL).openedFromNoticeBoard = false;
		CalendarUI.JHOHGMODKGM(base.JIIGOACEIKL).OpenUI();
	}

	public static NoticeBoardUI LBKJEHDEBEP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}
}
