using UnityEngine;

public class OnlineIrrigator : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		FillWater
	}

	public Irrigator irrigator;

	public void NBHBHGFOOLC(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void CFCPMLBJOOK(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void EBPHDDIFLPE(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BFAAENOKODB(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void BBCKJHONCMO(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JKMNLKDKMPN(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new IrrigatorMessage(this);
	}

	public void AOGJHAEGNBM(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void OAGKKGEDCIP(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NAAJMHDFOBL(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GFEMPJCMNFI(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void INKKNNNNNCI(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		irrigator = ((Component)((Component)this).transform).GetComponent<Irrigator>();
		irrigator.onlineIrrigator = this;
	}

	public void HOALNKGDLDF(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void HGLFLHGDCJP(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void OLGGLBEIKOI(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HKDBAJLHHBC(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FMELLFMNBEE(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LINLDLELDBO(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void FEPMEDPNALD(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 0)
		{
			irrigator.FillWater(1, (int)GEMFIOKGIMC[0], CDPAMNIPPEC: false);
		}
	}

	public void LACHGDGMONB(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void BAAEIJIIGDA(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void ABLFDMAEAAB(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void HCJIKIABLEC(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void BMBPNKJHMIB(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void COELHADIAHH(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void NMAKGJMJEJP(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LANFHIJKGHA(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void FillWater(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void EGJJEGPLEGP(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void OAINHEEEHKH(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CONCMKBHCDP(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void AGIEBHAILIL(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void OMEEGJCEHNO(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void NEGGPNLKAKM(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void PODFBOJHCKA(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void POBNNOFPCHH(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JFPBJCAGMKE(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void PKLGPEGGIMF(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void KKFJGLAGCGE(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FABMKNALHNO(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void EBAALBJLHDP(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void CCPGNFGBMEF(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FGELFONEOHD(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FDICGJCDBGG(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KKNJMNLCMPC(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HLKCJCPHCFK(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, MGNOBNCMDJG);
	}

	public void KGOKMOJCBBJ(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void ECNBGBLPFBH(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IEEJBLOBKLL(int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, MGNOBNCMDJG);
	}

	public void IHPAIFNOLOK(int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}
}
