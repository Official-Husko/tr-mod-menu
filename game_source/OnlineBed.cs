using System;
using UnityEngine;

public class OnlineBed : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		BedMade
	}

	[SerializeField]
	private TutorialObject tutorialObject;

	public NPCBed nPCBed;

	private void NAPEEBNOGIM()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JDDGDCEDDJE));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void JNGLNLBEGAO()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(APICKFEAFAH));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.MFGOIHMBHML();
		}
	}

	public void EGBMKCPMEHE(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KILKFJBFAMN(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void JPHKPOGBMHP()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(PIJDKIMGOAJ));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void NLKNCODMACJ()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(PNAOOIEFHIG));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	public void PJFABJINPOA(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void GCKBNOBKOEF()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(CAMGOBOPKNM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.BMFNLAOAKAM();
		}
	}

	private void IGMKFHBBBEA()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(LCDFEOGPDNP));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	public void DIDGBCAFMMN(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HFEJNEGJFFF(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new BedMessage(this);
	}

	private void APICKFEAFAH()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(GMMEKIOAGNJ));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.BMFNLAOAKAM();
		}
	}

	private void LBHJDILPHKO()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(BJNBIHMDHLA));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	public void POINDHCDNPA(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void ACLIOOMCONM()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JDDGDCEDDJE));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.MFGOIHMBHML();
		}
	}

	private void APOFAFIDFBI()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(LCDFEOGPDNP));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.BMFNLAOAKAM();
		}
	}

	public void MEJJOLGMCAG(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void MMJMIOIIBEN(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void MCNHGPODOHM()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(ACLIOOMCONM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.IGGMHMIMMLG();
		}
	}

	public void DPJAOGCKEGF(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IHDPJBBGLAI(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void EFBIHDGOOCE(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void CILFGKFIHHN(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void PEEBLDKKJFP()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JPHKPOGBMHP));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.NKPDKADEDIE();
		}
	}

	private void FELKHNPHHKP()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(APICKFEAFAH));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.MFGOIHMBHML();
		}
	}

	public void FEIAPKGBOCG(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MBFPBEIEAHC(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void EPKCDECAILB(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BLGFCMHJBOF);
	}

	private void NDOODFMGKCF()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JDDGDCEDDJE));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.NKPDKADEDIE();
		}
	}

	private void AFEFBPLDBDB()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(NAPEEBNOGIM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.MFGOIHMBHML();
		}
	}

	private void JDDGDCEDDJE()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JDDGDCEDDJE));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void EDKAOLPFFNB()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JNGLNLBEGAO));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.MFGOIHMBHML();
		}
	}

	public void DNJEIJBCJBF(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void DLNODHCFOBN(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void ECADAMDEJFI()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(APICKFEAFAH));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	public void HHLKLHNAEBI(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void MLJNIJOALCH(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void CAMGOBOPKNM()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(BJNBIHMDHLA));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.CDHLMGIMILO();
		}
	}

	private void LIFDCIEACDG()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(APOFAFIDFBI));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.BMFNLAOAKAM();
		}
	}

	public void GBIEFIOPLDF(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void AELANDDCBKC(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IGJEAACBODM(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IGJMGCDJCCM(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BLGFCMHJBOF);
	}

	public void LCKKNGAKOIE(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LILJOMDHKBC(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BLGFCMHJBOF);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 0)
		{
			nPCBed.SetBedMade((bool)GEMFIOKGIMC[0], CDPAMNIPPEC: false);
		}
	}

	private void BJHCELBMBEJ()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(GIKBHJMHCBE));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void KEHFJBGDCLI()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(GCKBNOBKOEF));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.DIKDPABGNAD();
		}
	}

	public void SendBedMade(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, BLGFCMHJBOF);
	}

	public void CODKOJIBAIG(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void LCDFEOGPDNP()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(MCNHGPODOHM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	private void BOJJKKOBGOG()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(CAMGOBOPKNM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	public void KGIBDPCPKDJ(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void OANKNGPAICI()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(PIJDKIMGOAJ));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	private void PNAOOIEFHIG()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(BJNBIHMDHLA));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.NKPDKADEDIE();
		}
	}

	public void POHFJOFHJDB(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void GIKBHJMHCBE()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OOOMCOGJIIP));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.BMFNLAOAKAM();
		}
	}

	private void BDOOBLGFBGD()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(NDOODFMGKCF));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void AAIAIFPPPIG()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(ACLIOOMCONM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.BMFNLAOAKAM();
		}
	}

	private void LNFIIBBNOBJ()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(PNAOOIEFHIG));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void OOOMCOGJIIP()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(ACLIOOMCONM));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.NKPDKADEDIE();
		}
	}

	public void OIEEBCCIEDE(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		nPCBed = ((Component)((Component)this).transform).GetComponent<NPCBed>();
		nPCBed.onlineBed = this;
	}

	private void OPJDBKPOEPO()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(GMMEKIOAGNJ));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	private void GMMEKIOAGNJ()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(LIFDCIEACDG));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	public void AGPMLENAFIJ(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HHDLLFJDOHO(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BLGFCMHJBOF);
	}

	private void BJNBIHMDHLA()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(GIKBHJMHCBE));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.IGGMHMIMMLG();
		}
	}

	public void EKHHGBAKJBB(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	private void PIJDKIMGOAJ()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(FELKHNPHHKP));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.UpdateObject();
		}
	}

	public void BDJAHHNEKKC(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BLGFCMHJBOF);
	}

	public void DCBBNEKPOFA(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BLGFCMHJBOF);
	}

	private void OCFLCHKCACD()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OCFLCHKCACD));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.NKPDKADEDIE();
		}
	}

	private void NBFDJJMBMAF()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(LIFDCIEACDG));
		if ((Object)(object)tutorialObject != (Object)null)
		{
			tutorialObject.JCOOIFMPJOG();
		}
	}

	protected override void Start()
	{
		base.Start();
		if ((Object)(object)tutorialObject == (Object)null)
		{
			tutorialObject = ((Component)this).GetComponent<TutorialObject>();
		}
		if (OnlineManager.ClientOnline())
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(JDDGDCEDDJE));
		}
	}

	public void HPJGGBLOKAH(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void ADAKIABGAFO(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = BLGFCMHJBOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void ILCPOOJBKDA(bool BLGFCMHJBOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, BLGFCMHJBOF);
	}
}
