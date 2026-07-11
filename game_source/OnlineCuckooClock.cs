using UnityEngine;

public class OnlineCuckooClock : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		SetAlarm
	}

	public RelojCuco cuckooClock;

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 0)
		{
			cuckooClock.SetAlarm((int)GEMFIOKGIMC[0], (int)GEMFIOKGIMC[1], (bool)GEMFIOKGIMC[2], CDPAMNIPPEC: false);
		}
	}

	public void OKIPLPAOMGG(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[5] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KHEGDEHNIMJ(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void PCLDOLNIJIO(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[4] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void PDBOKPJGFJL(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[6] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IAFJBDKGCNB(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[8] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IKENOMPNGGO(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[0] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void BLAGFPPPKDD(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MDAGAAGGFGE, CHDKNJECEOK, BHKIEKPMKKA, null, null);
	}

	public void CBODJEEADOD(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void PDJGFNCJENF(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FFDIFBPHKCL(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		cuckooClock = ((Component)this).GetComponent<RelojCuco>();
		cuckooClock.onlineClock = this;
	}

	public void LHHAFHKAJFF(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[1] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MJCMBDCFNAC(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[0] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new CuckooClockMessage(this);
	}

	public void IMIEPECJKAJ(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[6] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void MICGCONIDBH(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[0] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FHGLDBCAELF(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[1] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LDOPCMHGFNK(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[8] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void ANOIOMAKJBP(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GFDKOPAPFPN(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void AGGMILKGNDK(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[1] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LKEGOHHAABE(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CABNLFJHAJD(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MDAGAAGGFGE, CHDKNJECEOK, BHKIEKPMKKA, null, null);
	}

	public void PNFNOIKIDIK(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[8] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void PFFEGDEENEN(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[6] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void ONEBGGIFCOB(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GCLDKGNOGCJ(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MDAGAAGGFGE, CHDKNJECEOK, null, null, BHKIEKPMKKA, null, null, null);
	}

	public void AODMEIBILBF(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HLGOJPICNFE(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[0] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void SendSetAlarm(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MDAGAAGGFGE, CHDKNJECEOK, BHKIEKPMKKA);
	}

	public void ECFLHPGOMMO(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void OPMONMMCMMD(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void ENKFICAMAMJ(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[8] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FLNIFOMCHBL(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IMLHGPGLGIF(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MHDNBEIBNAI(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[5] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HGFNKLJJGNP(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NFIGBEIDAFJ(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[6] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GBAECPAAKGA(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MDAGAAGGFGE, CHDKNJECEOK, null, null, BHKIEKPMKKA);
	}

	public void HPBPHPPAMHC(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MDAGAAGGFGE;
		array[1] = CHDKNJECEOK;
		array[7] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void COGADJBPAPJ(int MDAGAAGGFGE, int CHDKNJECEOK, bool BHKIEKPMKKA)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MDAGAAGGFGE;
		array[0] = CHDKNJECEOK;
		array[3] = BHKIEKPMKKA;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}
}
