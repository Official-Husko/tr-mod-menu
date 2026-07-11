using System;
using System.Collections.Generic;
using UnityEngine;

public class ToolUpgradeManager : MonoBehaviour
{
	public static ToolUpgradeManager instance;

	public Item item;

	public bool canCollect;

	public List<int> upgradedTools = new List<int>();

	private void DCHDJABABLE()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JBFFNMCKOEM));
	}

	private void MJLNBCBNMEO()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(COPDNJFJKCH));
	}

	public void GPHJFILEJHP(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IGPKHCDAFEF));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.JGHNDJBCFAJ());
		}
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}

	private void AKBLAECDPKD()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JJDJHCPDLOL));
	}

	private void PKPHKBMPJGJ()
	{
		instance = this;
	}

	private void FHLDCHCHANF()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(AKBLAECDPKD));
	}

	public void BOCPIKCDMAK(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-48, CDPAMNIPPEC: true);
			PlayerInventory.EIFPKCAFDIB(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO).HFJGDBENPGM(item.JDJGFAACPFC(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JDJGFAACPFC()))
		{
			upgradedTools.Add(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	private void DAGGLALPNIM()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGDGNNGEJFH));
	}

	private void ALGOBMNPLIB()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	private void ONEDJBMPCBH()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(OEPGEENIGNN));
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	private void GOKMHENLMLB()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FHLDCHCHANF));
	}

	private void NODKJHJFMCO()
	{
		instance = this;
	}

	private void GGOPCJOAOMC()
	{
		instance = this;
	}

	private void OMONLJAAKPP()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JBFFNMCKOEM));
	}

	public void LBECHJECPIF(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(16);
			PlayerInventory.NEKDDPIAOBE(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FICBIPNGLHJ(item.IMCJPECAAPC(DAINLFIMLIH: false), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.CIGFGKKCPCK()))
		{
			upgradedTools.Add(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	public void JBDCEBBPBLH(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(66, CDPAMNIPPEC: true);
			PlayerInventory.EIFPKCAFDIB(HallmundNPC.KNOKBLFFNLM().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FICBIPNGLHJ(item.JGHNDJBCFAJ(DAINLFIMLIH: false));
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.ODENMDOJPLC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JPNFKDMFKMC());
		}
		canCollect = true;
		item = null;
	}

	private void IGPKHCDAFEF()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGDGNNGEJFH));
	}

	private void EIHMDMMOPCM()
	{
		instance = this;
	}

	public void PCLMMBCJPEH(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PMFCLNNDCAG));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.JGHNDJBCFAJ());
		}
	}

	public void GNDEFCAEJEL(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(56);
			PlayerInventory.NEKDDPIAOBE(HallmundNPC.ACPHFLBLJAA().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FICBIPNGLHJ(item.IMCJPECAAPC(DAINLFIMLIH: false), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JGHNDJBCFAJ(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.ODENMDOJPLC(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	public void GDPPBPAILEF(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-124);
			PlayerInventory.NEKDDPIAOBE(HallmundNPC.ACPHFLBLJAA().EHHOHCPHAAO, LAGHIOKLJGH: true).FICBIPNGLHJ(item.JPNFKDMFKMC(DAINLFIMLIH: false), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.ODENMDOJPLC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JGHNDJBCFAJ());
		}
		canCollect = true;
		item = null;
	}

	public void GiveUpgradeTool(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(47);
			PlayerInventory.GetPlayer(HallmundNPC.GGFJGHHHEJC.EHHOHCPHAAO).AddItem(item.JDJGFAACPFC(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JDJGFAACPFC()))
		{
			upgradedTools.Add(item.JDJGFAACPFC());
		}
		canCollect = false;
		item = null;
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	private void MBAGGLHJJLP()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAGGLALPNIM));
	}

	private void OEPGEENIGNN()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IGPKHCDAFEF));
	}

	public void GIHOJHPOCAD(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-43);
			PlayerInventory.OGKNJNINGMH(HallmundNPC.DCAEBALADIM().EHHOHCPHAAO).FICBIPNGLHJ(item.IMCJPECAAPC(DAINLFIMLIH: false), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.ODENMDOJPLC()))
		{
			upgradedTools.Add(item.ODENMDOJPLC(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	private void EFJFJJDGGGI()
	{
		instance = this;
	}

	public void KBALIBJODFA(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MJLNBCBNMEO));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
	}

	private void BNFGHAGJEGG()
	{
		instance = this;
	}

	public void PDLPHBDPAEO(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DAGGLALPNIM));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.CIGFGKKCPCK());
		}
	}

	private void HINGECEDJAP()
	{
		instance = this;
	}

	private void POEAHKDOOFH()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PMFCLNNDCAG));
	}

	public void APOFGEOGEFC(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-96, CDPAMNIPPEC: true);
			PlayerInventory.EIFPKCAFDIB(HallmundNPC.AFFGPMFKEFH().EHHOHCPHAAO).AddItem(item.CIGFGKKCPCK(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JPNFKDMFKMC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JDJGFAACPFC());
		}
		canCollect = false;
		item = null;
	}

	public void EGCHDDJNOAG(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(59);
			PlayerInventory.EIFPKCAFDIB(HallmundNPC.AFFGPMFKEFH().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HFJGDBENPGM(item.CIGFGKKCPCK(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JPNFKDMFKMC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JPNFKDMFKMC());
		}
		canCollect = true;
		item = null;
	}

	private void MNCDAHNHNMJ()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PGDGNNGEJFH));
	}

	public void IFLKLKCKJMJ(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-119);
			PlayerInventory.GetPlayer(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HFJGDBENPGM(item.IMCJPECAAPC(DAINLFIMLIH: false), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JGHNDJBCFAJ()))
		{
			upgradedTools.Add(item.JPNFKDMFKMC(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	public void ILLAHEFHLFP(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-104, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(HallmundNPC.NEFIEJALANL().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HFJGDBENPGM(item.JGHNDJBCFAJ(DAINLFIMLIH: false), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JDJGFAACPFC()))
		{
			upgradedTools.Add(item.ODENMDOJPLC());
		}
		canCollect = true;
		item = null;
	}

	private void CHPDBFANJEI()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JJDJHCPDLOL));
	}

	public void GFPCDEBCHEL(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DCHDJABABLE));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.JDJGFAACPFC());
		}
	}

	private void AAENCDNIBFJ()
	{
		instance = this;
	}

	public void FDGDPAEOCID(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IGPKHCDAFEF));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.JGHNDJBCFAJ());
		}
	}

	public void KEFIHOBGOFL(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(COPDNJFJKCH));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.ODENMDOJPLC(DAINLFIMLIH: false));
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	public void AFNNJJFDNID(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-66);
			PlayerInventory.NEKDDPIAOBE(HallmundNPC.GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(item.ODENMDOJPLC(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.ODENMDOJPLC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JPNFKDMFKMC());
		}
		canCollect = true;
		item = null;
	}

	private void GMJGBMOIIJJ()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GMJGBMOIIJJ));
	}

	public void AHLPPNJELPA(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KDIMLPAKAEJ));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
	}

	private void COPDNJFJKCH()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GOKMHENLMLB));
	}

	public void IDDEEICFIPD(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GMJGBMOIIJJ));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.CIGFGKKCPCK());
		}
	}

	private void PGPPIHJJGDB()
	{
		instance = this;
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	public void KHJKIPAPHOC(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JBFFNMCKOEM));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.IMCJPECAAPC(DAINLFIMLIH: false));
		}
	}

	public void LBOFAHOCMKD(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-51);
			PlayerInventory.OGKNJNINGMH(HallmundNPC.AFFGPMFKEFH().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HFJGDBENPGM(item.JDJGFAACPFC(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JGHNDJBCFAJ()))
		{
			upgradedTools.Add(item.JGHNDJBCFAJ(DAINLFIMLIH: false));
		}
		canCollect = true;
		item = null;
	}

	public void CJNHCCJNJLE(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ONEDJBMPCBH));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.CIGFGKKCPCK());
		}
	}

	private void PMFCLNNDCAG()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ONEDJBMPCBH));
	}

	public void AGFFCIELGPL(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MJLNBCBNMEO));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.JDJGFAACPFC(DAINLFIMLIH: false));
		}
	}

	public void KMHKCBNNNHD(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(EFNCLNAJOKP));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.IMCJPECAAPC());
		}
	}

	private void PGDGNNGEJFH()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(FHLDCHCHANF));
	}

	public void LMKNPCFFKOI(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(CHPDBFANJEI));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.JPNFKDMFKMC());
		}
	}

	public void LCEFOALAOLO(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(39, CDPAMNIPPEC: true);
			PlayerInventory.OGKNJNINGMH(HallmundNPC.ACPHFLBLJAA().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HFJGDBENPGM(item.JGHNDJBCFAJ(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.IMCJPECAAPC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.IMCJPECAAPC(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	public void DHBHNPCOKAC(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-103, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO).HFJGDBENPGM(item.CIGFGKKCPCK(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.CIGFGKKCPCK()))
		{
			upgradedTools.Add(item.JPNFKDMFKMC(DAINLFIMLIH: false));
		}
		canCollect = true;
		item = null;
	}

	private void IAMJGJLOLNN()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(AKBLAECDPKD));
	}

	public void OAOLGPAHPDI(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-31);
			PlayerInventory.OGKNJNINGMH(HallmundNPC.GGFJGHHHEJC.EHHOHCPHAAO).HFJGDBENPGM(item.JPNFKDMFKMC(DAINLFIMLIH: false), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JGHNDJBCFAJ(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JGHNDJBCFAJ(DAINLFIMLIH: false));
		}
		canCollect = true;
		item = null;
	}

	private void JBFFNMCKOEM()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NKDIIKKBPOH));
	}

	public void UpgradeTool(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.JDJGFAACPFC());
		}
	}

	private void ALDJGOCMPPO()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HNIMEMKOGHP));
	}

	private void HNIMEMKOGHP()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PMFCLNNDCAG));
	}

	private void EFNCLNAJOKP()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void ILCLIJOHKHG()
	{
		instance = this;
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	private void IAPAKPNFAJF()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IMAMNEJKKNM));
	}

	public void CBCBCAOBPLN(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NKDIIKKBPOH));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.ODENMDOJPLC());
		}
	}

	private void AJGLDLLIIFO()
	{
		instance = this;
	}

	private void IMAMNEJKKNM()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	public void KGCFJBOAOID(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-52);
			PlayerInventory.GetPlayer(HallmundNPC.EKDNJDJHONF().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(item.CIGFGKKCPCK(DAINLFIMLIH: false), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JGHNDJBCFAJ()))
		{
			upgradedTools.Add(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
		canCollect = true;
		item = null;
	}

	private void EJKIADFBMJO()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CHPDBFANJEI));
	}

	public void EIANGNCAJMB(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-59);
			PlayerInventory.NEKDDPIAOBE(HallmundNPC.ACPHFLBLJAA().EHHOHCPHAAO).AddItem(item.JPNFKDMFKMC(DAINLFIMLIH: false), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.CIGFGKKCPCK()))
		{
			upgradedTools.Add(item.JGHNDJBCFAJ(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	public void JLLABMDJKAC(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JJDJHCPDLOL));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.IMCJPECAAPC());
		}
	}

	private void JJDJHCPDLOL()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(IMAMNEJKKNM));
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	private void DILNFOONCIM()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GOKMHENLMLB));
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	private void OOIHNJHMBMC()
	{
		instance = this;
	}

	public void GAMHOHAJGHL(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KDIMLPAKAEJ));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.JDJGFAACPFC(DAINLFIMLIH: false));
		}
	}

	public void AEDJHIGHFJM(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-12, CDPAMNIPPEC: true);
			PlayerInventory.GetPlayer(HallmundNPC.DCAEBALADIM().EHHOHCPHAAO).AddItem(item.ODENMDOJPLC(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JPNFKDMFKMC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
		canCollect = true;
		item = null;
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	public void FMACNNLHMGH(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(66, CDPAMNIPPEC: true);
			PlayerInventory.OGKNJNINGMH(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO, LAGHIOKLJGH: true).FICBIPNGLHJ(item.ODENMDOJPLC(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JPNFKDMFKMC()))
		{
			upgradedTools.Add(item.JGHNDJBCFAJ(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	public void PBAHAOOOEHG(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-1);
			PlayerInventory.GetPlayer(HallmundNPC.BAKPBHPNKPB().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).FICBIPNGLHJ(item.ODENMDOJPLC(DAINLFIMLIH: false), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.ODENMDOJPLC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.ODENMDOJPLC());
		}
		canCollect = false;
		item = null;
	}

	public void LJOCOKLLPBI(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IAMJGJLOLNN));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.ODENMDOJPLC(DAINLFIMLIH: false));
		}
	}

	public void INLDGFFKBHC(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IMAMNEJKKNM));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.HMOHDMLGJCJ(item.IMCJPECAAPC(DAINLFIMLIH: false));
		}
	}

	public void BADMDOMHKNE(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(CHPDBFANJEI));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.IMCJPECAAPC(DAINLFIMLIH: false));
		}
	}

	private void KDIMLPAKAEJ()
	{
		canCollect = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CHPDBFANJEI));
	}

	public void JANECLIIBMI(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-13);
			PlayerInventory.GetPlayer(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HFJGDBENPGM(item.JPNFKDMFKMC(), HMPDLIPFBGD: true);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.JGHNDJBCFAJ()))
		{
			upgradedTools.Add(item.JPNFKDMFKMC(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	public void FOPEFIMNBIA(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
	}

	public void NELFHDIGJLJ(Item KGNFAONKLDG, bool CDPAMNIPPEC = false)
	{
		item = KGNFAONKLDG;
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IMAMNEJKKNM));
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineManager.SendUpgradeToolRPC(item.CIGFGKKCPCK(DAINLFIMLIH: false));
		}
	}

	public void DLAPOEJCIHD(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(-93);
			PlayerInventory.GetPlayer(HallmundNPC.AFFGPMFKEFH().EHHOHCPHAAO).FICBIPNGLHJ(item.JPNFKDMFKMC(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.CIGFGKKCPCK()))
		{
			upgradedTools.Add(item.JDJGFAACPFC(DAINLFIMLIH: false));
		}
		canCollect = false;
		item = null;
	}

	private void NKDIIKKBPOH()
	{
		canCollect = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DILNFOONCIM));
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	public void IOKBEDIDLDO(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(95, CDPAMNIPPEC: true);
			PlayerInventory.EIFPKCAFDIB(HallmundNPC.PFHFIJDDOME().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(item.JGHNDJBCFAJ(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.IMCJPECAAPC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.CIGFGKKCPCK());
		}
		canCollect = true;
		item = null;
	}

	public void OICKOMOCGOC(bool CDPAMNIPPEC = false)
	{
		if (CDPAMNIPPEC)
		{
			Utils.DLIIAHACOJB(79);
			PlayerInventory.OGKNJNINGMH(HallmundNPC.MPJJAPCFENH().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HFJGDBENPGM(item.JGHNDJBCFAJ(DAINLFIMLIH: false), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			if (OnlineManager.PlayingOnline())
			{
				OnlineManager.SendUpgradeToolCollectRPC();
			}
		}
		if (!upgradedTools.Contains(item.ODENMDOJPLC(DAINLFIMLIH: false)))
		{
			upgradedTools.Add(item.JPNFKDMFKMC());
		}
		canCollect = true;
		item = null;
	}

	private void NCPNBBCNBIM()
	{
		instance = this;
	}
}
