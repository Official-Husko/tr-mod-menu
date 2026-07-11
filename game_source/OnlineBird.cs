using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OnlineBird : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		GiveCookie,
		GiveDemonCookie,
		GiveElixir,
		CatAttack,
		BirdSound,
		PositiveReputation,
		NegativeReputation,
		Bark
	}

	public BirdNPC bird;

	private void IIJGODLFFHK(string NAIOOBEPNDO, byte BMCMHPALMPN)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		DialogueManager.Bark(NAIOOBEPNDO, ((Component)this).transform);
	}

	public void LGBKAHJKKLL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DBPINILNLOP(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		JMEKBNCDPPH(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void HJCHDIGPGKN(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void MDKBFKGMDJO(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetBool(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: false);
	}

	public void NAELJGJGJKC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EFECMMIGAHE(string GEGDHHIDEEF)
	{
		GDKAHNKCLBP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void HEPIIDCPJON(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ReceiveSetInt(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		bird.SetInt(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: false);
	}

	private void JAJFJBOJKEH(string NAIOOBEPNDO, byte BMCMHPALMPN)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		DialogueManager.Bark(NAIOOBEPNDO, ((Component)this).transform);
	}

	public void LPJIMHAPBLG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PEMFNLCLLLB(string GEGDHHIDEEF)
	{
		FGJEFNLIMAH(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void MAEHKKPKGNM(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void NOLANBEEEAG(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void PNOJIDLKHAJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 6);
	}

	public void MHECIELEDLH(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ILALMDPKEKP(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.GiveCookie:
			bird.GiveCookie(1, placeable.itemSetup.DNLMCHDOMOK as BirdInstance, null, CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.GiveDemonCookie:
			bird.GiveDemonCookie(CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.GiveElixir:
			bird.GiveElixir(1, CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.CatAttack:
			bird.CatAttack(CDPAMNIPPEC: false);
			break;
		case JDBLOKANBMI.BirdSound:
			bird.birdSpeech.PlayBirdSound();
			break;
		}
	}

	public void FKNAJGJFPDM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void ALIHJEFCHEA(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void LLBPFPAHFJM(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		EAMDIICAIEL(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void KBGCJBKJMDC(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.HHDGLBAGEFL(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void MGIDOPPDFDN(string GEGDHHIDEEF)
	{
		OGEMMEICKMA(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void OJLBOMJKBPC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OJOHDIEEPGN(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = OLDICOEMFHI;
		array[1] = BMCMHPALMPN;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void IOCGADPEGBL(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		JMEKBNCDPPH(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void DMAEJFMAPFC(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void APPMDHMIIFL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void SendSetTrigger(string GEGDHHIDEEF)
	{
		SendSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void EEOLPAEOKFL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void BJLLLGHHKEL(int GJKKNOKIKBJ)
	{
		bird.SetTrigger(GJKKNOKIKBJ, CDPAMNIPPEC: false);
	}

	public void KNDEBCAAMOJ(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = OLDICOEMFHI;
		array[1] = BMCMHPALMPN;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JEKFFADOIKH(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = OLDICOEMFHI;
		array[1] = BMCMHPALMPN;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void BCAMJGCDCMI(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		bird.SetInt(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void DGNKLBNNFHN(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void LDDIBEHGJJC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void KJGGDKELOLA(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FFNIEFCNAMM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void ReceiveSetTrigger(string GEGDHHIDEEF)
	{
		ReceiveSetTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void SendCatAttack()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 3);
	}

	public void PJNFOHPDJPE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5);
	}

	public void FFNIEFCNAMM(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new BirdMessage(this);
	}

	public void DLDKHBAIAOI(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void IHBHIFDKLMI(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = OLDICOEMFHI;
		array[0] = BMCMHPALMPN;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void KJOJAMDMCIM(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: false);
	}

	public void JMEKBNCDPPH(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void CJELOEOOEPE(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		GCOLGGJNOMH(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	private void CJIKOLAAOMP(string NAIOOBEPNDO, byte BMCMHPALMPN)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		DialogueManager.Bark(NAIOOBEPNDO, ((Component)this).transform);
	}

	public void ICNGMJKBEHF(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 7)
		{
			PluginsGameData.randomBark = (byte)GEMFIOKGIMC[1];
			DialogueManager.Bark((string)GEMFIOKGIMC[0], ((Component)this).transform);
		}
	}

	public void CEGPPOMPKJO(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void EAMDIICAIEL(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		bird.SetInt(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: false);
	}

	public void GCOLGGJNOMH(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		bird.SetInt(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void GDKAHNKCLBP(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void LJAMFIIJOCD(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void CBCPEJOBIKM(string GEGDHHIDEEF)
	{
		GDKAHNKCLBP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void CALOKGFCDPN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 6);
	}

	public void SendSetTrigger(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void PHLNCCOJNGE(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void NGABHLNBEBL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void IBPCEAFIMAK(string GEGDHHIDEEF)
	{
		GDKAHNKCLBP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ReceiveSetInt(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		ReceiveSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MOFCJMLCOID(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.HHDGLBAGEFL(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void BNBJLANCNOJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void OMJDHCLEHEM(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void NLKBPDGBHNM(string GEGDHHIDEEF)
	{
		FGJEFNLIMAH(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ReceiveSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void FAAGIIGNEED(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		bird.SetBool(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void SendBirdSound()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4);
	}

	public void ReceiveSetTrigger(int GJKKNOKIKBJ)
	{
		bird.SetTrigger(GJKKNOKIKBJ, CDPAMNIPPEC: false);
	}

	public void SendGiveElixir()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2);
	}

	public void NDEKHJBMDLI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void ANJBNHOMLOG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ReceiveSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void KBOCBOHFENP(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		bird.SetInt(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void IGPBMBBMKMH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OGEMMEICKMA(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void ILALMDPKEKP(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		bird.SetInt(GJKKNOKIKBJ, AODONKKHPBP, CDPAMNIPPEC: true);
	}

	public void GKMIGLGFKOL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5);
	}

	public void KAKIEDMEFGE(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FFNIEFCNAMM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void GEAGJNIBNFO(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void DDBJPAHCGNH(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		MAEHKKPKGNM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void PLDDJNOJOAO(int GJKKNOKIKBJ)
	{
		bird.CJKJAEAIABG(GJKKNOKIKBJ, CDPAMNIPPEC: true);
	}

	public void OONKCHPPHJB(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void FGJEFNLIMAH(int GJKKNOKIKBJ)
	{
		bird.SetTrigger(GJKKNOKIKBJ, CDPAMNIPPEC: false);
	}

	public void ABNEOHDKIHL(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		Debug.Log((object)("Get Components " + ((Object)((Component)this).gameObject).name));
		bird = ((Component)((Component)this).transform).GetComponent<BirdNPC>();
		bird.onlineBird = this;
	}

	public void JMIIPHHBNJI(string GEGDHHIDEEF)
	{
		GDKAHNKCLBP(Animator.StringToHash(GEGDHHIDEEF));
	}

	private void HAJEGCDAOLM(string NAIOOBEPNDO, byte BMCMHPALMPN)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		DialogueManager.Bark(NAIOOBEPNDO, ((Component)this).transform);
	}

	public void GCPFFBNEMLI(string GEGDHHIDEEF)
	{
		GDKAHNKCLBP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void AFBIHAJGPME(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		ALIHJEFCHEA(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void NBIKMHPLCOG(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		SendSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendSetBool(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void BPCJGPNNCLM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void SendGiveCookie()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void IICFOPNFLOK(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.HHDGLBAGEFL(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void ENODCEAMMGF(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		HEPIIDCPJON(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void DGOKABOIONL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JDDODODGDKL(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		PIHLMHLIPMA(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void CHMGPNNFHPA(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		HEPIIDCPJON(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void IODNBLHODNF(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void SendSetInt(string GEGDHHIDEEF, int AODONKKHPBP)
	{
		SendSetInt(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void OIOGFNAALNC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void PFCNDHADCLD(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, OLDICOEMFHI, BMCMHPALMPN, null, null);
	}

	public void NDIOBDKMLLP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 8);
	}

	public void SendSetInt(int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetInt(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void PIHLMHLIPMA(int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineObjectsManager.instance.SendSetBool(uniqueId, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void CMBNKGBPJFG(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		FFNIEFCNAMM(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void SendBarkInfo(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 7, OLDICOEMFHI, BMCMHPALMPN);
	}

	public void KDJBMKPLDNN(int GJKKNOKIKBJ)
	{
		bird.SetTrigger(GJKKNOKIKBJ, CDPAMNIPPEC: false);
	}

	public void CLGLJIOCBML()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MDBCCKCKHAH(int GJKKNOKIKBJ)
	{
		OnlineObjectsManager.instance.SendSetTrigger(uniqueId, GJKKNOKIKBJ);
	}

	public void SendGiveDemonCookie()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PANNIILBOEA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void JOBDOGGILNF(string GEGDHHIDEEF)
	{
		GDKAHNKCLBP(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void EBHCNGMAOCC(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		DGNKLBNNFHN(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void AOJJHOLLKOJ(string GEGDHHIDEEF)
	{
		LJAMFIIJOCD(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void CHELHMNJOHA(string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		HJCHDIGPGKN(Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void FOENNOBEGCJ(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = OLDICOEMFHI;
		array[0] = BMCMHPALMPN;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}
}
