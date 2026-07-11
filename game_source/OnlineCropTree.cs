using UnityEngine;

public class OnlineCropTree : OnlineTree
{
	public CropSetter cropSetter;

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		cropSetter = ((Component)this).GetComponent<CropSetter>();
		cropSetter.onlineObject = this;
	}

	public void CPPPCLPLFBE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 93);
	}

	public void GDAIBDCICLH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 193);
	}

	public void INFJGGMHPGH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 66);
	}

	public void BEEFPFKGAIP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 236);
	}

	public void OGPDJBLIMFF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 55);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 12)
		{
			cropSetter.harvestable.Harvest(1, CDPAMNIPPEC: false);
		}
		else
		{
			base.ReceiveAction(FACPEEACCMH);
		}
	}

	public void FDAMIAAGIOK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 147);
	}

	public void JHNJKGIFGOH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 11);
	}

	public void IPDOACHHDEC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 227);
	}

	public void OMCDEOEKKMH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 180);
	}

	public void EMKKDOFCELB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 245);
	}

	public void KEGKOHHAPHE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 152);
	}

	public void Harvest()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 12);
	}

	public void AMPJIFLPCGC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 23);
	}

	public void CCJNBIONGFA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 142);
	}

	public void LNIBJKCLKHJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 8);
	}

	public void HAGIHANJLKE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 218);
	}

	public void EIHGMFGOMBI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 46);
	}

	public void AMKOBIGFEAN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 61);
	}

	public void JCGNLEAJEFH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 46);
	}

	public void DICADAHODHD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 84);
	}

	protected override void Start()
	{
		if (!OnlineManager.PlayingOnline() || (Object)(object)cropSetter == (Object)null)
		{
			return;
		}
		if (uniqueId == 0)
		{
			if ((Object)(object)uniqueObject != (Object)null)
			{
				AssignUniqueId(uniqueObject.uniqueID);
			}
			else
			{
				uniqueId = OnlineObjectsManager.instance.AssignNewUniqueId(this);
			}
			if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && uniqueId >= 100000)
			{
				OnlineObjectsManager.instance.SendInstantiatePlaceable(this);
			}
		}
		AddIfUniqueObject();
	}

	public void LKGJDINBCOG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 66);
	}

	public void MOIGLAIGHIA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 29);
	}

	public void NPGKOJBFBJP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 109);
	}

	public void KJKHELJOCBI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 18);
	}

	public void HGHDCOAHEPP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 97);
	}

	public void IKACPOGJPFC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void APNJFEBEABO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 91);
	}

	public void COACGMBFCON()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 231);
	}

	public void DDFIKOFJNLC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 70);
	}

	public void MEBOPGKFIII()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 93);
	}

	public void LGBFMEEONJJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 200);
	}

	public void NDBHJOJEBOD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 9);
	}

	public void IEJPKJMDEDF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 186);
	}

	public void NHEEPBACFGC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 72);
	}

	public void LIGIHMCMLAE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 242);
	}

	public void DEELDIABAIJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 211);
	}

	public void MBGLEHAOOJA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 66);
	}

	public void DMNJPDJAAAI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 106);
	}

	public void PCOBBAHMAHC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 180);
	}

	public void NLMBIEHMEDI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}
}
