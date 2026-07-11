using System;
using UnityEngine;

public class CatStateSpawning : CatStateBase
{
	private bool catPet;

	private float walkTime;

	private void HKHCLFLBGHO()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(MEPLGAODEPG));
	}

	private void GLHCJBLCBJL()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(NLFNMJEILJF));
	}

	private void LCPIIALGCAG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.CMIHGBHPLFP()).transform.position;
	}

	private void ADFCLENLEJE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.NEFIEJALANL()).transform.position;
	}

	private void PAELPLLEILB()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.LPFNKEOJJKE()).transform.position;
	}

	public override void GFBLAEEOPAO()
	{
		if (catNpc.walkTo.IIMEFNIECLI())
		{
			if (walkTime == 0f)
			{
				walkTime = Time.fixedTime + 10f;
			}
			if (catPet && Time.fixedTime > walkTime)
			{
				animator.SetTrigger("Walk");
			}
		}
	}

	private void AGFMPPOOPOC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.MKIEMMGGFEE()).transform.position;
	}

	private void CDPCCGBOEJO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.NEFIEJALANL()).transform.position;
	}

	private void KPGEIGNHMBL()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(EHLOCHJHJGC));
	}

	private void IKEHIBADPLE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.PNHHCHJCDNM()).transform.position;
	}

	public override void OnStateEnter(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		base.OnStateEnter(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Combine(instance.OnPetCat, new Action(EOOJPNNCFGD));
		catNpc.walkTo.FNNPPBDFBCI(Vector2.op_Implicit(((Component)SpawnCat.GGFJGHHHEJC).transform.position));
		catNpc.walkTo.speed = 1.5f;
		NPCWalkTo walkTo = catNpc.walkTo;
		walkTo.OnFailStart = (Action)Delegate.Combine(walkTo.OnFailStart, new Action(DJDIFKFIDFG));
		catNpc.walkTo.PEHELKCIECB();
	}

	private void KJFKMLLNBKC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GJFMMOPOKGJ()).transform.position;
	}

	private void ILNJCOPMKDO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.AJIGOHGPFPP()).transform.position;
	}

	private void IBPIJNAHIDH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GAGMPCEPONF()).transform.position;
	}

	private void NJFLFGFCPBK()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(JDACFPICMLO));
	}

	private void MEPLGAODEPG()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(JCEOMBKCFKF));
	}

	private void EOOJPNNCFGD()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(EOOJPNNCFGD));
	}

	private void BEHOAAMJLJN()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(IBKHHBIKHMJ));
	}

	private void CBAKGAJEAOM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GJFMMOPOKGJ()).transform.position;
	}

	private void MLMPOHMPNID()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.AJIGOHGPFPP()).transform.position;
	}

	private void OLPNKOMNAHA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.PNHHCHJCDNM()).transform.position;
	}

	private void GDANOGOAKOP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GJFMMOPOKGJ()).transform.position;
	}

	private void NJONDAJJOCB()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(AJIEMIHAIPE));
	}

	private void GBEAEKEAPNA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.ELGNEJNLBNO()).transform.position;
	}

	private void DGJDOGMDCMF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.KIALFDOKABP()).transform.position;
	}

	private void GCOCLEJHHKD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GAGMPCEPONF()).transform.position;
	}

	private void OPCEACPCGAJ()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(HKHCLFLBGHO));
	}

	public override void OnStateExit(Animator ONDMDLMHMHK, AnimatorStateInfo GHFAKAOLMHC, int GJCCCHOHLAF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((StateMachineBehaviour)this).OnStateExit(ONDMDLMHMHK, GHFAKAOLMHC, GJCCCHOHLAF);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(EOOJPNNCFGD));
	}

	private void KHPHHHMJMLA()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(KHPHHHMJMLA));
	}

	private void BJEEICBPGGI()
	{
		catPet = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(OFCAJMLOIJD));
	}

	private void EGPMMIIPPJD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void CNKFJLNNFIO()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(EOOJPNNCFGD));
	}

	private void MLODCDCPLDE()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(GLHCJBLCBJL));
	}

	private void LMHHHNDLFBG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.ELGNEJNLBNO()).transform.position;
	}

	private void IMDEJKLKFMK()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.NEFIEJALANL()).transform.position;
	}

	private void MCIKEOMDKHE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.KIALFDOKABP()).transform.position;
	}

	private void EHBHGMKJHCO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void OFCAJMLOIJD()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(NGLCKMFFFOL));
	}

	private void KEOEBCIEKHO()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(IHAHLFNDNLB));
	}

	private void EFAKBFMNOMN()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.KIALFDOKABP()).transform.position;
	}

	private void MLDHMCMDDBJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.DIHCEGINELM()).transform.position;
	}

	private void FDMPHONCFMK()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void EGMKHFHGBDP()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(HKHCLFLBGHO));
	}

	private void DJDIFKFIDFG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void JNIMGHBMNDM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void HOIINBIAKNN()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.NEFIEJALANL()).transform.position;
	}

	private void JDACFPICMLO()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(HEDAEILIJNM));
	}

	private void AEOGMMMOCAE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.PNHHCHJCDNM()).transform.position;
	}

	private void GEGKBGHPOCA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.MKIEMMGGFEE()).transform.position;
	}

	private void EIFMHKNHAFJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.NEFIEJALANL()).transform.position;
	}

	private void BBFFOIAFNFE()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(NJFLFGFCPBK));
	}

	private void NFANKOBKAHF()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.CHPEMJMLDCN()).transform.position;
	}

	private void FNOPNDDECLK()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(IAKNMBPGACJ));
	}

	private void CGLCADJHLKC()
	{
		catPet = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(KICOFPPJMJG));
	}

	private void IIIAHJOIJLL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void AJIEMIHAIPE()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(NJONDAJJOCB));
	}

	private void BPOODJHKNEP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.CMIHGBHPLFP()).transform.position;
	}

	private void NGLCKMFFFOL()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(FNOPNDDECLK));
	}

	private void FFDOHJMJJBO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.ELGNEJNLBNO()).transform.position;
	}

	private void OBEOAGDKDPI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.CMIHGBHPLFP()).transform.position;
	}

	private void KICOFPPJMJG()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(BEHOAAMJLJN));
	}

	private void AHBJEMDFNPA()
	{
		catPet = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(GJJAMEEKCHC));
	}

	private void HEKDIOLMKOP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GAGMPCEPONF()).transform.position;
	}

	private void GCJFLHCGLNC()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(NLFNMJEILJF));
	}

	private void HGCDFEODJKO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.ELGNEJNLBNO()).transform.position;
	}

	private void IHLLJOBBBNG()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.AJIGOHGPFPP()).transform.position;
	}

	private void EHLOCHJHJGC()
	{
		catPet = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(FNOPNDDECLK));
	}

	private void IGEFOOOGHNP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.PNHHCHJCDNM()).transform.position;
	}

	private void IHAHLFNDNLB()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(NLFNMJEILJF));
	}

	private void DENBLAINNEE()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(BPPBLLAFKED));
	}

	private void HEDAEILIJNM()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(AJIEMIHAIPE));
	}

	private void FNFEPNIJCHO()
	{
		catPet = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(NJFLFGFCPBK));
	}

	private void JOONDPDFKJH()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(JCEOMBKCFKF));
	}

	private void IBKHHBIKHMJ()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(KEOEBCIEKHO));
	}

	private void ADDKEMDKOKH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GJFMMOPOKGJ()).transform.position;
	}

	private void ENOGGCJFDKK()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(CNKFJLNNFIO));
	}

	private void KAEBPPLJPFM()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(BPPBLLAFKED));
	}

	private void HLLCCGBLONN()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.AJIGOHGPFPP()).transform.position;
	}

	private void BPPBLLAFKED()
	{
		catPet = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(HEDAEILIJNM));
	}

	private void GJJAMEEKCHC()
	{
		catPet = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(KPGEIGNHMBL));
	}

	private void IGIBPNBHGOE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}

	private void NLFNMJEILJF()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(FNFEPNIJCHO));
	}

	private void JCEOMBKCFKF()
	{
		catPet = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPetCat = (Action)Delegate.Remove(instance.OnPetCat, new Action(CGLCADJHLKC));
	}

	private void AABKLPDLGKL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.CMIHGBHPLFP()).transform.position;
	}

	private void ALLMKOMPECM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.NEFIEJALANL()).transform.position;
	}

	private void HEPAIDAKDCH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.LPFNKEOJJKE()).transform.position;
	}

	private void EMKKCDFKKKK()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.AJIGOHGPFPP()).transform.position;
	}

	private void IAKNMBPGACJ()
	{
		catPet = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPetCat = (Action)Delegate.Remove(commonReferences.OnPetCat, new Action(IAKNMBPGACJ));
	}

	private void AMPIMPGKCIN()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.CMIHGBHPLFP()).transform.position;
	}

	private void KABGIOGENCO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GAGMPCEPONF()).transform.position;
	}

	private void KIBADDOPNJO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.DIHCEGINELM()).transform.position;
	}

	private void NDCJDPONBHD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)catNpc).transform.position = ((Component)SpawnCat.GGFJGHHHEJC).transform.position;
	}
}
