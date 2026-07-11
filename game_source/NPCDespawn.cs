using System;
using UnityEngine;

public class NPCDespawn : NPCAction
{
	private Vector2 MNNOHBNGPMB;

	public void FDNEIDBLDEN(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.EJPGFOEDPBG(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = true;
		npc.walkTo.NDBJOGGIKCG(GDHHIIMLBEL);
	}

	public void EAPAAKCKKLH(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DBHOIIIHIIM(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.KNBOIOOOKBG(GDHHIIMLBEL);
	}

	public void EKAEPEIOEJF(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DBHOIIIHIIM(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public void IBFHCFGJOFB(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GLHBJNDMIDC(MNNOHBNGPMB);
		npc.walkTo.isActive = false;
		npc.walkTo.NDBJOGGIKCG(GDHHIIMLBEL);
	}

	public void JMLDNKMECAD(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.JJDCANFBFMK(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.HJIOLGOOFMH(GDHHIIMLBEL);
	}

	public void PJDMEIBANNO(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.OGLJDLEGJAA(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = true;
		npc.walkTo.NDBJOGGIKCG(GDHHIIMLBEL);
	}

	public void GAEJNKCCHPK(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.JDHMPOJKOLF(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.KNBOIOOOKBG(GDHHIIMLBEL);
	}

	public void LLNCHCFAHHP(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DBHOIIIHIIM(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.GBKCMOLJKKL(GDHHIIMLBEL);
	}

	public void HNKFJDJPLAO(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.HELOLJBENMK(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.CKJACJMOCDC(GDHHIIMLBEL);
	}

	public void JFMLBHGACCI(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.EJPGFOEDPBG(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.ALIADLGLMOE(GDHHIIMLBEL);
	}

	public void BHJMBAFKMBE(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.CGFMBJFGLAG(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.ALIADLGLMOE(GDHHIIMLBEL);
	}

	public void MGCAKMAJGOF(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DHFPOCOEONG(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public void KBJGIJBDAGA(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GINPKMBGOFN(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.HJIOLGOOFMH(GDHHIIMLBEL);
	}

	public void OPHBHMJOEDJ(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.JDHMPOJKOLF(MNNOHBNGPMB);
		npc.walkTo.isActive = false;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public override void PEHELKCIECB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.FNNPPBDFBCI(MNNOHBNGPMB);
		NPCWalkTo walkTo = npc.walkTo;
		walkTo.OnSuccessfulStart = (Action)Delegate.Combine(walkTo.OnSuccessfulStart, new Action(base.EGDEAFHIKAI));
		NPCWalkTo walkTo2 = npc.walkTo;
		walkTo2.OnFailStart = (Action)Delegate.Combine(walkTo2.OnFailStart, new Action(IALPAKDIDKG));
		npc.walkTo.PEHELKCIECB();
	}

	public void EHGGEOLFCCJ(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.JDHMPOJKOLF(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public void BGNJBCJPDGH(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.HELOLJBENMK(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.CKJACJMOCDC(GDHHIIMLBEL);
	}

	public void MELBHOGAIKH(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.BDIKOLNFKGD(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public void KFFLLAIGEDH(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GINPKMBGOFN(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.GBKCMOLJKKL(GDHHIIMLBEL);
	}

	public void OKCLIPIBHEK(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.CGFMBJFGLAG(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = true;
		npc.walkTo.OALJDOMENMG(GDHHIIMLBEL);
	}

	public void HFAFEFEONNO(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.FNNPPBDFBCI(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public void DLMMPEIHEPP(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.BDIKOLNFKGD(MNNOHBNGPMB);
		npc.walkTo.isActive = false;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public void MCELMDDDOLE(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.OGLJDLEGJAA(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.CKJACJMOCDC(GDHHIIMLBEL);
	}

	public void EICDOHEINCN(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DBHOIIIHIIM(MNNOHBNGPMB);
		npc.walkTo.isActive = true;
		npc.walkTo.GBKCMOLJKKL(GDHHIIMLBEL);
	}

	public void ECGDLGFCJBA(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.OGLJDLEGJAA(MNNOHBNGPMB);
		npc.walkTo.isActive = true;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public override bool IIMEFNIECLI(bool OEBNHGNJEJL = false)
	{
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)"NPCDespawn PerformAction");
		}
		if (complete)
		{
			if (OEBNHGNJEJL)
			{
				Debug.Log((object)"NPCDespawn PerformAction Complete");
			}
			return true;
		}
		if (npc.walkTo.IIMEFNIECLI(OEBNHGNJEJL))
		{
			CustomerPool.DisableCustomer(((Component)npc).gameObject);
			EGIBBBDHEGC();
			return true;
		}
		return false;
	}

	public void NHBJHDHGJNJ(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.KBEENHPEOAB(MNNOHBNGPMB);
		npc.walkTo.isActive = true;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public void FMOGINHMMEA(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.JJDCANFBFMK(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.GBKCMOLJKKL(GDHHIIMLBEL);
	}

	public void IGCPLKJFBIJ(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GHDMBFOAAHK(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.OALJDOMENMG(GDHHIIMLBEL);
	}

	public void DJJFBDLFDLN(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.CGFMBJFGLAG(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.OALJDOMENMG(GDHHIIMLBEL);
	}

	public void AECNEHGDMNL(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.FNNPPBDFBCI(MNNOHBNGPMB);
		npc.walkTo.isActive = true;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public void BAEKHIMIOFL(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.FNNPPBDFBCI(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.GBKCMOLJKKL(GDHHIIMLBEL);
	}

	public void GDMDHOODEDH(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DHFPOCOEONG(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = true;
		npc.walkTo.NDBJOGGIKCG(GDHHIIMLBEL);
	}

	public void KPHFLFHHLME(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GINPKMBGOFN(MNNOHBNGPMB);
		npc.walkTo.isActive = true;
		npc.walkTo.ALIADLGLMOE(GDHHIIMLBEL);
	}

	public void IAODJJEEKEG(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.HELOLJBENMK(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = true;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public void OAKKDCCFEJB(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.KBEENHPEOAB(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.CDHICEDNNKF(GDHHIIMLBEL);
	}

	public NPCDespawn(HumanNPC JHIFLALPEBF, Vector2 MNNOHBNGPMB)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		npc = JHIFLALPEBF;
		this.MNNOHBNGPMB = MNNOHBNGPMB;
	}

	public void OFAFLFPHAAC(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.HELOLJBENMK(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.CDHICEDNNKF(GDHHIIMLBEL);
	}

	public void MMEJJPNMEHI(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.DBHOIIIHIIM(MNNOHBNGPMB);
		npc.walkTo.isActive = false;
		npc.walkTo.CKJACJMOCDC(GDHHIIMLBEL);
	}

	public void AHKNIPJLMNB(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GLHBJNDMIDC(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.KNBOIOOOKBG(GDHHIIMLBEL);
	}

	public void HNCDICPFOHG(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.CGFMBJFGLAG(MNNOHBNGPMB);
		npc.walkTo.isActive = true;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public void PBCBCMPMEEB(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.JDHMPOJKOLF(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public override void JKGGEMBAPAJ()
	{
		if (npc.walkTo != null)
		{
			npc.walkTo.JKGGEMBAPAJ();
		}
		base.JKGGEMBAPAJ();
	}

	public void BOAHNGEOMIP(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GLHBJNDMIDC(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.CJDPPIJHHNE(GDHHIIMLBEL);
	}

	public void IMJJAFBKDEM(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GHDMBFOAAHK(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = true;
		npc.walkTo.HJIOLGOOFMH(GDHHIIMLBEL);
	}

	public void MKPNJEEPPMA(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GLHBJNDMIDC(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.ALIADLGLMOE(GDHHIIMLBEL);
	}

	public void CGBAEEIGFLN(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.HELOLJBENMK(MNNOHBNGPMB, AHDHLIECIGH: false, NGAKHGJANLO: false);
		npc.walkTo.isActive = false;
		npc.walkTo.CKJACJMOCDC(GDHHIIMLBEL);
	}

	public void KEAIECLLKPB(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.HELOLJBENMK(MNNOHBNGPMB, AHDHLIECIGH: true, NGAKHGJANLO: false);
		npc.walkTo.isActive = true;
		npc.walkTo.JKOPNGHNPKF(GDHHIIMLBEL);
	}

	public void BFKDBGGIANC(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.FNNPPBDFBCI(MNNOHBNGPMB);
		npc.walkTo.isActive = false;
		npc.walkTo.ALIADLGLMOE(GDHHIIMLBEL);
	}

	public void ODJBAEBCOND(Vector2[] GDHHIIMLBEL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		npc.walkTo.GLHBJNDMIDC(MNNOHBNGPMB, AHDHLIECIGH: false);
		npc.walkTo.isActive = false;
		npc.walkTo.CKJACJMOCDC(GDHHIIMLBEL);
	}
}
