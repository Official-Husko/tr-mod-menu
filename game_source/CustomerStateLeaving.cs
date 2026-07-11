using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CustomerStateLeaving : CustomerStateBase
{
	private NPCDespawn DDCDOIICNEL;

	private void CMIHJJBOPFF()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void FLHFMICMIFD()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void COMEKIOEKDO()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void CBAPIFOMBGA()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OPHHJKDDJNF()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void LKHFIOGLCCG()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void DEAOKOJPLJG()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.DFHBHGHEHJB(((Component)PJNGMCJIHME).gameObject);
	}

	private void DAIGIACIMBJ()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void CIIBGPONALD()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void KPDFIADBMCA()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.DisableCustomer(((Component)PJNGMCJIHME).gameObject);
	}

	private void GIMFJMNCKDA()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OIGFAMIFKNH()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.AOHAFFGCOAG(((Component)PJNGMCJIHME).gameObject);
	}

	private void HAPLKMJBKCG()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	public override void EnterState(bool GDHCBGCIIKG = false)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		base.EnterState(GDHCBGCIIKG);
		if (PJNGMCJIHME.currentMoodState != MoodState.Rowdy)
		{
			PJNGMCJIHME.EnableInputByProximity(BJFHJCFOEHG: false, CDPAMNIPPEC: true);
		}
		Seat seat = JHIFLALPEBF.seat;
		DDCDOIICNEL = new NPCDespawn(JHIFLALPEBF, Vector2.op_Implicit(((Component)SceneReferences.GetRandomSpawnPoint()).transform.position));
		NPCDespawn dDCDOIICNEL = DDCDOIICNEL;
		dDCDOIICNEL.OnSuccessfulStart = (Action)Delegate.Combine(dDCDOIICNEL.OnSuccessfulStart, (Action)delegate
		{
			TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		});
		if (PJNGMCJIHME.KPGJGABJMFC != MoodState.Rowdy && PJNGMCJIHME.customerType != CustomerType.Guest)
		{
			int num = PJNGMCJIHME.CalculateTravellerReputationGain(seat);
			if (num != 0)
			{
				TavernReputation.AddAndShowReputationGain(num, Vector2.op_Implicit(((Component)PJNGMCJIHME).transform.position), ((Component)PJNGMCJIHME).transform, PJNGMCJIHME.NGDAJGCPJEC);
			}
		}
		PJNGMCJIHME.CustomerLeave();
		NPCDespawn dDCDOIICNEL2 = DDCDOIICNEL;
		dDCDOIICNEL2.OnFailStart = (Action)Delegate.Combine(dDCDOIICNEL2.OnFailStart, (Action)delegate
		{
			JHIFLALPEBF.seat?.GetUp();
			TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
			CustomerPool.DisableCustomer(((Component)PJNGMCJIHME).gameObject);
		});
		DDCDOIICNEL.PEHELKCIECB();
	}

	private void IBLKIJKCLIC()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void HFFLDGMNNMM()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void JFLBKFIGPHO()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void FHODHJJMLCF()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void NNKOBDDKKMC()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void JPHEAOGJPJI()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}

	private void FMMCFFEDGAI()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void GLCNPGEFAJE()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void CEIDDEBDGLL()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.AOHAFFGCOAG(((Component)PJNGMCJIHME).gameObject);
	}

	private void JPEHGBMKAHN()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void LKHLNBPBBFN()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void DFIEJJIOGMI()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.AOHAFFGCOAG(((Component)PJNGMCJIHME).gameObject);
	}

	private void NGACMCANKEP()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void KMHGAIAKJAD()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void BLINFCLLBIM()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	public override int GetStateEnumID()
	{
		return 8;
	}

	private void NDCELEBENKI()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.DisableCustomer(((Component)PJNGMCJIHME).gameObject);
	}

	private void DJBEBFJGBDL()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.CBMBHAJAMCJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void EFJJFKKLDLL()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.DFHBHGHEHJB(((Component)PJNGMCJIHME).gameObject);
	}

	private void CJLFPPIBPPK()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void ANFKPJKGFLN()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void IJAIINFNLAK()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.PLBHAPAKIDJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void NPBGILFKHHM()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}

	private void MBGOMGFDLMN()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.AOHAFFGCOAG(((Component)PJNGMCJIHME).gameObject);
	}

	private void JNPLPODCDKF()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void EIBIFHHHDCI()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void EJKHFPJNINB()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OCBOAHPPPOH()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	[CompilerGenerated]
	private void LCGBPKOBFIF()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void DPOHACFGGNP()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void PIGFGAMNMGP()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.MKHGIIEAGHK(((Component)PJNGMCJIHME).gameObject);
	}

	private void MHPBMOIJOMA()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void DFNLIDFLAOJ()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void EKGPLHMIIKC()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OBCLIGAIPDF()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void CLAPDFBJDPF()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void LFJIHBMCJEH()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.DisableCustomer(((Component)PJNGMCJIHME).gameObject);
	}

	private void BGKFIAOBFBE()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.DisableCustomer(((Component)PJNGMCJIHME).gameObject);
	}

	private void AKAFFFBNBBK()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void CPBDFBIFCEB()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void KIDAFJAKDJP()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void KGHNAFFPMBM()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.AOHAFFGCOAG(((Component)PJNGMCJIHME).gameObject);
	}

	private void CFMMGPEBIEP()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.PLBHAPAKIDJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void GLGAFJJKDEB()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void DBEECAACONH()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void GKABCLFMINL()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void AHIFMAGJFJK()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void KAGLGHGMMPJ()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void EEDDIOBDPHB()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void OCDGLIIDNLD()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OPEBPDKEINN()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}

	[CompilerGenerated]
	private void LLHHMNJJFIO()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.DisableCustomer(((Component)PJNGMCJIHME).gameObject);
	}

	private void PKFLLIMNIIL()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.PLBHAPAKIDJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void EFPLPKKCBMN()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void FDCLMDBAFFM()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.DFHBHGHEHJB(((Component)PJNGMCJIHME).gameObject);
	}

	private void MOEEJOAPPEM()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void HAFJFBOPDNN()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void JGPANDFPJMH()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.DFHBHGHEHJB(((Component)PJNGMCJIHME).gameObject);
	}

	private void FIEPIFMNIMC()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void NDLNNHPEBDH()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void EGCGDMCIKDL()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.CBMBHAJAMCJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void PKNKEALLKIB()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.MKHGIIEAGHK(((Component)PJNGMCJIHME).gameObject);
	}

	private void GEIGNHKEEIH()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.AOHAFFGCOAG(((Component)PJNGMCJIHME).gameObject);
	}

	private void HHDJMKDLFFC()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.CBMBHAJAMCJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void EFCKPEBIPGJ()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}

	private void KIDHPDBEMMO()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void IAEOCIGDFMM()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	public override void ExitState(bool GDHCBGCIIKG = false)
	{
		base.ExitState(GDHCBGCIIKG);
		if (DDCDOIICNEL != null)
		{
			DDCDOIICNEL.JKGGEMBAPAJ();
			DDCDOIICNEL = null;
		}
	}

	private void BCLMAHMJDBJ()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void MKNOCJOKMEK()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void HKNLAJGCMFK()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}

	private void BGPKOFFLHEC()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.DFHBHGHEHJB(((Component)PJNGMCJIHME).gameObject);
	}

	private void OAEJDHECIME()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.KJJGJCGDGOM(((Component)PJNGMCJIHME).gameObject);
	}

	private void OCDKLGMMPHI()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}

	private void AKDKBCKLPLD()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.MKHGIIEAGHK(((Component)PJNGMCJIHME).gameObject);
	}

	public override void FixedUpdateState(bool GDHCBGCIIKG = false)
	{
		base.FixedUpdateState(GDHCBGCIIKG);
		DDCDOIICNEL.IIMEFNIECLI();
	}

	private void IOEIAGGFFNP()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OBGHPJFFACE()
	{
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
	}

	private void BPJJIFNKOJB()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void DKCFIMFGCIO()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void MIHAKFBDALK()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.RemoveCustomerFromTavern(PJNGMCJIHME);
		CustomerPool.PLBHAPAKIDJ(((Component)PJNGMCJIHME).gameObject);
	}

	private void EEKKHPLJPJM()
	{
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
	}

	private void OJMFLBMAOFD()
	{
		JHIFLALPEBF.seat?.GetUp();
		TavernManager.GGFJGHHHEJC.NEDOHDIFDCA(PJNGMCJIHME);
		CustomerPool.LLBLDINBIGK(((Component)PJNGMCJIHME).gameObject);
	}
}
