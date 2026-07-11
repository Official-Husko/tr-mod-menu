using UnityEngine;

public class OnlineHenHouse : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		CollectEggs,
		FillWater
	}

	public HenHouse henHouse;

	public void LKNNJEIEGDM(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HLFFPDEJLBD(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HENDOOOJGOG(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FDFJMFPOCNM(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IMHLJJJMGBF(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FOPABHNEEKN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EENIGFNABBK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void OAKELKOEGOI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void CFALHFMGGEN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void HKDFBECFAMG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PIOJLIJHJLP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MDCJCJAEKAH(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG, null, null, null);
	}

	public void ELBKNPFALCM(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[0] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void AOFHAJHHJNH(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JFEPHOBNBPB(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG, null, null, null, null);
	}

	public void EEBOCKIEALF(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void JMBGEIGBCND()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void IPIBDABHELO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 0)
		{
			henHouse.eggsAmount = 0;
		}
	}

	public void EggsCollected()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JCBOCPLHJKH(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IAJECPNCILN(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[4];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void ENAGOFPPIIA(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LBNBKNMJGLO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void IGFJNBGJKIK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NECOEKFHNHL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MIEMNIPKJDI(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JKGFDFIMHLB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MDGNPEKKFAC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CJKECLLLNHA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void SendFillWater(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG);
	}

	public void DGINDCMICAP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OFACCOGBIIO(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[8];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LIAPDMNNKDK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		henHouse = ((Component)((Component)this).transform).GetComponentInChildren<HenHouse>();
		henHouse.onlineHenHouse = this;
	}

	public void DBBNNCFPINH(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[0] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NHLCOAAHOMA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CJBEFBBGJOG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NDDOIDCNKNL(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG, null, null, null, null);
	}

	public void DCJJLAKIFKL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MACOAAHOAMM(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GHHEDDDFFJF(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG, null, null, null);
	}

	public void BKNPMCIHFOD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CKLPJNPLLIA(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG, null, null);
	}

	public void LGJGKLIIAEA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override PlaceableMsg CreateMsg()
	{
		if ((Object)(object)henHouse == (Object)null)
		{
			Debug.LogError((object)("Hen House not attached on OnlineHenHouse of placeable " + ((Object)((Component)this).gameObject).name));
		}
		return new HenHouseMsg(this);
	}

	public void GJHCCLAOACB(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[6];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BDKOOKBGICG(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[5];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FJALPBOGGBJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CDAHNCNEBLA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GHGBIDMIBHG(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 1 && henHouse.waterFeeders[(byte)GEMFIOKGIMC[0]] is AnimalFeederWaterHenHouse animalFeederWaterHenHouse)
		{
			animalFeederWaterHenHouse.SetCurrentAmount((byte)GEMFIOKGIMC[1]);
		}
	}

	public void HOKNEFKPEEL(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[3];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void DBAGCJGNMBM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OEBLFMBFOGE(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void NIIBBGFOILN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CAFLHOLKBHI(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[7];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void PHCIMMAEEDD(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, (byte)JFNMCNCHMEO, (byte)MGNOBNCMDJG, null, null, null, null);
	}

	public void JGEGKOMPALL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void LGJEOIHLDHC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void LAOIMEHEIBC(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = (byte)JFNMCNCHMEO;
		array[1] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HMIMKBCMIDJ(int JFNMCNCHMEO, int MGNOBNCMDJG)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[2];
		array[1] = (byte)JFNMCNCHMEO;
		array[0] = (byte)MGNOBNCMDJG;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void PEEDGKOINCM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CCKOOOOPLFN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void HCNABOPJNAH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EIHHDBJNJMN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}
}
