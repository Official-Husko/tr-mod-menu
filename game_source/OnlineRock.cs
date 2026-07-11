using UnityEngine;

public class OnlineRock : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Chop,
		WorkFinished
	}

	public Rock rock;

	[HideInInspector]
	public bool rockLoaded;

	public void LDNIKDGDIIA(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void GGLAPPDHHBF(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NHDGJFMPDLG(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void HNJBOCLHLDO(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void KBFAOGGHBCO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	protected override void Start()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (uniqueId == 0)
		{
			if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) != Location.Mine)
			{
				Debug.LogError((object)("Unique ID not set for online rock " + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			}
		}
		else
		{
			AddToDictionary();
		}
	}

	public void KFBIIDBNAHM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MCELFPBECMM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GPKJNAGMDKF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NGKDADGNDCN(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KANOAKBLMGH(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void WorkFinished()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CAPNPGOABHA(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FMIOGCBDLED(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void BEECAPPHDDG(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void MJJGHOBAABD(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BFMHBNJEPLE(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void FPDGCMOHKJJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MEFKJJNINIK(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void COGEJJDPCHP(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void KEFEDHCLLLO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OLEHHOGGJPB(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void OGPKIGDCEKB(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void GKNMADANCLG(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void JKLMEEAMKGE(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void ELBFFFMFGHM(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void IHMBCDMPOOJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EPKEKBLCDFE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void MEKLOGOKEIE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JLECLEAIAHF(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void BBAGHJBMONO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MKDONDHMKGK(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FNNIHCKALPA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PFFFPPKPJMH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void DPMILDNACNJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JAOKBPCPCPM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new RockMessage(this);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		rock = ((Component)((Component)this).transform).GetComponent<Rock>();
		rock.onlineRock = this;
	}

	public void PINLGMHCNIC(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HIOFAEIFAPC(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void HDPEPIDKHNL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JAKHEKFOCOI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CIBOAKMBJGG(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CFLKKNEHJAN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CMKBEMBNIEJ(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void LNJGBCFJGJE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PECOFCJLGMH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DKNBONEEHFB(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void FHFEMAOFGMC(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void GKHIJLHHPGI(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void DPCOFILIODL(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void NKLKJAOPIHO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (FACPEEACCMH == 0)
		{
			rock.Chop(1, (float)GEMFIOKGIMC[0], CDPAMNIPPEC: false);
		}
	}

	public void NGOJPHIEGEJ(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void LEMDCDNHKCB(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void NLCIABNONKA(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void CMEMKJMGBHO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MBCPCAOICID()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void OMMKGNMFNFF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GFLCCNOEAPJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DONLCEDBOOJ(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void DHJNDGICIPL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void DOGNFEGFDID(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CIPBCBPFMHK(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 1)
		{
			rock.WorkFinished(CDPAMNIPPEC: false);
		}
	}

	public void OOCCLDHFHMK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void HAJJCFHBBBN(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JFLPIHEDKLO(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void CDNAJNDJBAE(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void EFMCIAMHKPG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JKFOLJJNEDH(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void COFEFHENLHD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GGHDOEPDHEL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void AONGBFDKGHE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BDBPJCHOCPI(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JGMFMOADNBL(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, OJLICLKJJOF);
	}

	public void OIPAFDIGKOD(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void FJKBPCIBCCC(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void AKFMOCPIHOB(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void GBCLMOPKIDG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EIDNFBCJDJC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void CLADMLEJKMH(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void PGPMHOGGKIF(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void OIIAOFFNIIJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void KPBCDILPGCD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NHLFAAPPAJF(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}

	public void BBIKGMCMLFF(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void CFIBMNHFPEK(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HNBFMDNILON(float OJLICLKJJOF)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = OJLICLKJJOF;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void Chop(float OJLICLKJJOF)
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, OJLICLKJJOF);
	}
}
