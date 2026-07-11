using UnityEngine;

public class OnlineFishTrap : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Collect,
		ChosenItem,
		SetUses
	}

	public Nasa fishTrap;

	public void JMEHBHJAEMA(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KABGNFOBJNP(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void CollectFish()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void PCIFLMIIGCN(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void CIIDOOEOKJJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		switch ((JDBLOKANBMI)FACPEEACCMH)
		{
		case JDBLOKANBMI.ChosenItem:
			fishTrap.SetChosenItem((short)GEMFIOKGIMC[0]);
			break;
		case JDBLOKANBMI.SetUses:
			fishTrap.SetRemainingUses((byte)GEMFIOKGIMC[0], (bool)GEMFIOKGIMC[1]);
			break;
		}
	}

	public void NBOBPGHMIOA(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void NCFBFFBCBHA(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void GKCAPMHFEEF(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CKAKPIALDMO(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 5, EDBPJFNLIAM, DGLBGEIJDOP, null, null, null);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new FishTrapMessage(this);
	}

	public void HKCHPHBCMLP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BONLNIEEKKP(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void ADJPMNBCNCA(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void MEKOEJLJFAD(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MNBNGGHHMBB);
	}

	public void DHOEBBAIMGA(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 4, EDBPJFNLIAM, DGLBGEIJDOP, null, null);
	}

	public void LIOHMJAACBJ(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IJKDDCKIJEG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void KPIJGCIIBIH(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 0)
		{
			fishTrap.CollectFish(1, CDPAMNIPPEC: false);
		}
	}

	public void IFCHMLLMOGP(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NHBAKOIAPDC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BKCOFMGAEEK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NFCHJGEPOFF(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void EJAHKGNPFCB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void CLKFNKCGPBJ(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void AKECLIOGENJ(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void EFLLAFJKJGO(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IDCDMOPJNFF(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}

	public void LCLAFMDJEKC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MAGKHEGEAIC(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 4, array);
	}

	public void PFHGCOMBKAD(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void POLPLKNEBKF(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}

	public void GOEMMBBIHGO(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void IHLPCHIAOLO(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void NJDHEPKJDBF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void ODJFBOIMLAG(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void HNMBAJKBELL(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void EKGFAMADJLH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void EGGKBPAHDMD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GHDLMBIGBOB(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void CNLCPAGMNDA(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LDKFHEKAEBB(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void NIMIPLCOGIN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JKINFOAOPHE(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MNBNGGHHMBB);
	}

	public void JBOPMEILNIK(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MNBNGGHHMBB);
	}

	public void KALFEHFHJNH(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void BJCMEEMNKFL(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void CGNBOOIBHEI(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void MBCCLJHDKGI(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public void NIFJHHHNHBA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BKJALNMBCDC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NDGPBIELGIO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void LEBBCLBNBOI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void SendChosenItem(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MNBNGGHHMBB);
	}

	public void LNKKIJFOPCJ(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void NOJEDMLNEHC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void IJAMOMJFJCJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void KNGGKJBACDB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void EMPJDBMDIML(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 5, array);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		fishTrap = ((Component)((Component)this).transform).GetComponent<Nasa>();
		fishTrap.onlineFishTrap = this;
	}

	public void GPNMMKCDAPB(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void SendRemainingUses(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 2, EDBPJFNLIAM, DGLBGEIJDOP);
	}

	public void MACMICOBJDO(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, EDBPJFNLIAM, DGLBGEIJDOP, null);
	}

	public void LKCJLCGBMKF(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void IJIGIAPJDAM(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JECKIEBHIPC(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 3, array);
	}

	public void IDFGMFCBJMC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GEKCDMGLFLM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BBMOONFMKMI(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IBDCAKNCAFB(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BIEJHGCBMOK(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MNBNGGHHMBB);
	}

	public void MHCKMLJCOJC(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 8, array);
	}

	public void AMHIEGGNECJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MAIFKMELNAF(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LJCPAINPCBB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void ELAGAILKIDP(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MNBNGGHHMBB);
	}

	public void IEBOOGKKFIL(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 6, array);
	}

	public void PJIDIHGGPOE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FGLIGCCMBJG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CJBMIHFNCPI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void AIPAMMPMNLH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void JIMGMOBFPAG(short MNBNGGHHMBB)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MNBNGGHHMBB);
	}

	public void AFJDKHHCBLG(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KECNOHAJEMP(short MNBNGGHHMBB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MNBNGGHHMBB;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JIFDAEKEFCH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EOGOJIHHOKF(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = EDBPJFNLIAM;
		array[1] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 7, array);
	}

	public void AENKCMLCHOD(byte EDBPJFNLIAM, bool DGLBGEIJDOP = false)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[0] = EDBPJFNLIAM;
		array[0] = DGLBGEIJDOP;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}
}
