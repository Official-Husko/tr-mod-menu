using System;
using UnityEngine;
using UnityEngine.UI;

public class CraftingAction : MonoBehaviour
{
	[SerializeField]
	private SlotUI slotUI;

	[SerializeField]
	private Progressor progressBar;

	private Timer JACMBBJELPI;

	public Image agingRank;

	public void DBKEGHGBEFA(float COAPHJJHNIO)
	{
		progressBar.LNMAGEGNGIF(COAPHJJHNIO);
	}

	public void DHNGIIOGLAK()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void GHJFAMADADK(float COAPHJJHNIO)
	{
		progressBar.NEJPLMCPNPJ(COAPHJJHNIO);
	}

	public void GDDJIOBEPCO(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void HDBOCDKFDCL(float COAPHJJHNIO)
	{
		progressBar.FOLMDNFLBOE(COAPHJJHNIO);
	}

	public void HIHLCBEGNIN(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void EAAIENJGEIP()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void KBFFOEOCAGI(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void HideAgingRank()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void SetProgressBarValue()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.BHGJPBGINCG = JACMBBJELPI.GetProgressValue();
		}
	}

	public void DNJGNBLGCOC()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.HCINJICEGBI(JACMBBJELPI.ONLGPFBKFIE());
		}
	}

	public void NEDCCMAINGH()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.JPNHJAAHMCE(JACMBBJELPI.NOIHJFMOFFG());
		}
	}

	public void NEHBHMDEEPN()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void FHNNCBKIPHF()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.NEJPLMCPNPJ(JACMBBJELPI.OMFAGCGKEIH());
		}
	}

	public void COGEOKGEALM(float COAPHJJHNIO)
	{
		progressBar.KLHFMOPHNBM(COAPHJJHNIO);
	}

	public void LDBMCNPBDKC()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void ShowAgingRank()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void BOOAMEKJNBA(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void MHKHCMHIPFF(float COAPHJJHNIO)
	{
		progressBar.DHJOICOCIHJ(COAPHJJHNIO);
	}

	public void GJPGPAPHCCD()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void MBGMLOHOBHF(float COAPHJJHNIO)
	{
		progressBar.HADLIKGKHOK(COAPHJJHNIO);
	}

	public void GINIPDHODEE()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void AJEPNGCFFAG(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void NPFOLPJGLJB(float COAPHJJHNIO)
	{
		progressBar.IBNCJLJDMGH(COAPHJJHNIO);
	}

	public void DDLJMFPEGHE()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void KBGCHGOGACJ()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.FOLMDNFLBOE(JACMBBJELPI.GetProgressValue());
		}
	}

	public void NLBDMIPJGDJ(int JIIGOACEIKL, ItemInstanceAmount IAIHNNNGNKH)
	{
		if (IAIHNNNGNKH.itemInstance != null)
		{
			if (!slotUI.IHENCGDNPBL.LKFKMDLLMAC(IAIHNNNGNKH.itemInstance) || Item.MLBOMGHINCA(slotUI.IHENCGDNPBL.itemInstance.PHGLMBIEOMK(), IAIHNNNGNKH.itemInstance.PHGLMBIEOMK()) || slotUI.IHENCGDNPBL.Stack != IAIHNNNGNKH.amount)
			{
				slotUI.IHENCGDNPBL.HBMBGCHGEGN(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: true, 1);
				slotUI.IHENCGDNPBL.CMLMNCAGKCK(JIIGOACEIKL, IAIHNNNGNKH.itemInstance, Mathf.RoundToInt((float)Math.Max(0, IAIHNNNGNKH.amount)), HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			}
		}
		else if (slotUI.IHENCGDNPBL.Stack != 0)
		{
			slotUI.IHENCGDNPBL.BBHHJLIFNPP(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: true, 1);
		}
	}

	public void HACNCJPHLIB()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void IDEHJHKJJIM()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void IDNFLHPLEOO()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void SetCrafterProgress(float COAPHJJHNIO)
	{
		progressBar.BHGJPBGINCG = COAPHJJHNIO;
	}

	public void PKNHIPPMGOB()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void SetCrafterTimer(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void SetItemInstanceAmount(int JIIGOACEIKL, ItemInstanceAmount IAIHNNNGNKH)
	{
		if (IAIHNNNGNKH.itemInstance != null)
		{
			if (!slotUI.IHENCGDNPBL.BOMLNEOHFOK(IAIHNNNGNKH.itemInstance) || Item.MLBOMGHINCA(slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), IAIHNNNGNKH.itemInstance.LHBPOPOIFLE()) || slotUI.IHENCGDNPBL.Stack != IAIHNNNGNKH.amount)
			{
				slotUI.IHENCGDNPBL.FDOBDPPMMBH(slotUI.IHENCGDNPBL.Stack);
				slotUI.IHENCGDNPBL.BEEDBHJANGN(JIIGOACEIKL, IAIHNNNGNKH.itemInstance, Mathf.RoundToInt((float)Math.Max(1, IAIHNNNGNKH.amount)));
			}
		}
		else if (slotUI.IHENCGDNPBL.Stack != 0)
		{
			slotUI.IHENCGDNPBL.FDOBDPPMMBH(slotUI.IHENCGDNPBL.Stack);
		}
	}

	public void JCDCJCLAPOP(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void JPHHLKEDOKM(float COAPHJJHNIO)
	{
		progressBar.PKCCJEJLAKD(COAPHJJHNIO);
	}

	public void EPPLLMENLAL()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void MBEHCFDHDJG()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void PGMLPPBPLLN()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}

	public void OFJIBLHDGNC(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void ODMPIIOKJGO(Timer LHACKABKHDN)
	{
		JACMBBJELPI = LHACKABKHDN;
	}

	public void APICGDLIFEG()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void HEAJKIKAJPE()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void PLFJKFEEDJB()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.LKDJOHHJBHC(JACMBBJELPI.CICJNEIPFOL());
		}
	}

	public void OLKOOAIECGO(float COAPHJJHNIO)
	{
		progressBar.JJDKOIOIADG(COAPHJJHNIO);
	}

	public void CPOEABKLOKP(int JIIGOACEIKL, ItemInstanceAmount IAIHNNNGNKH)
	{
		if (IAIHNNNGNKH.itemInstance != null)
		{
			if (!slotUI.IHENCGDNPBL.EDGCGEMMEKP(IAIHNNNGNKH.itemInstance) || Item.FKLOBGBIHLB(slotUI.IHENCGDNPBL.itemInstance.AFOACBIHNCL(), IAIHNNNGNKH.itemInstance.AFOACBIHNCL()) || slotUI.IHENCGDNPBL.Stack != IAIHNNNGNKH.amount)
			{
				slotUI.IHENCGDNPBL.FDOBDPPMMBH(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: true, 1);
				slotUI.IHENCGDNPBL.MHIIKMOOMFH(JIIGOACEIKL, IAIHNNNGNKH.itemInstance, Mathf.RoundToInt((float)Math.Max(0, IAIHNNNGNKH.amount)), HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			}
		}
		else if (slotUI.IHENCGDNPBL.Stack != 0)
		{
			slotUI.IHENCGDNPBL.BBHHJLIFNPP(slotUI.IHENCGDNPBL.Stack, CDPAMNIPPEC: false, 1);
		}
	}

	public void DMINMLMEDBB()
	{
		if (Object.op_Implicit((Object)(object)JACMBBJELPI))
		{
			progressBar.AKLMBMNEBOG(JACMBBJELPI.CICJNEIPFOL());
		}
	}

	public void AGPBHJJGICJ()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void MAGCHPKBFNG(int JIIGOACEIKL, ItemInstanceAmount IAIHNNNGNKH)
	{
		if (IAIHNNNGNKH.itemInstance != null)
		{
			if (!slotUI.IHENCGDNPBL.LKFKMDLLMAC(IAIHNNNGNKH.itemInstance) || Item.FKLOBGBIHLB(slotUI.IHENCGDNPBL.itemInstance.LHBPOPOIFLE(), IAIHNNNGNKH.itemInstance.LHBPOPOIFLE()) || slotUI.IHENCGDNPBL.Stack != IAIHNNNGNKH.amount)
			{
				slotUI.IHENCGDNPBL.HBMBGCHGEGN(slotUI.IHENCGDNPBL.Stack);
				slotUI.IHENCGDNPBL.MHIIKMOOMFH(JIIGOACEIKL, IAIHNNNGNKH.itemInstance, Mathf.RoundToInt((float)Math.Max(0, IAIHNNNGNKH.amount)), HAGPBCJEGKM: true, BDGJBPCEFPN: false, CDPAMNIPPEC: true);
			}
		}
		else if (slotUI.IHENCGDNPBL.Stack != 0)
		{
			slotUI.IHENCGDNPBL.FDOBDPPMMBH(slotUI.IHENCGDNPBL.Stack);
		}
	}

	public void LKEGKKEDGKJ()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void CMPHPPHGJGP(float COAPHJJHNIO)
	{
		progressBar.NFBOLMFKKLL(COAPHJJHNIO);
	}

	public void AADAAFACMDH()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = true;
		}
	}

	public void MALGMLGACAA()
	{
		if ((Object)(object)agingRank != (Object)null)
		{
			((Behaviour)agingRank).enabled = false;
		}
	}
}
