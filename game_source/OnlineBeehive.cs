using UnityEngine;

public class OnlineBeehive : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Collect
	}

	public Colmena beehive;

	public void MPGJMKBOJDB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DNJKLHIMLJA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DBGAMCFMDOH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override PlaceableMsg CreateMsg()
	{
		return new BeehiveMessage(this);
	}

	public void GMKCIIMAFOI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void CBELFPKMOEH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		beehive = ((Component)((Component)this).transform).GetComponent<Colmena>();
		beehive.onlineBeehive = this;
	}

	public void GEDCKIGGFDK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FAFMGEHANAP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PDHNFAOKONO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void IMLBIKHOHBI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void FAKICGOIBLB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FLKBEPIBLDF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 0)
		{
			beehive.CollectHoney(1, CDPAMNIPPEC: false);
		}
	}

	public void CCIOEMEBGLK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GOPFIJCKCLB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void PDPBONENICM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MBOJPOFJAME()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MNPGLGJIAEI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void EPAKICMDPOE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void JNFICFHGEII()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HAMFAIKMCEF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CollectHoney()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void KEDEGOKHCOG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void NFMJKJJHMAM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BMENDPCHHGD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void LCJGGLLFMAO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HILGLONIGBE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GCLHOJEMNCD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DMDJPFJAEIJ()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GDLPNJPNOMK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void HJODDIEAEJI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void MKGAIFIJNBO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void APOHBCCFMAC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void LNNAHGHINLG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void DAAPALBEBFF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PIKLOLFHOPL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PHIEFBCODJD()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void JGBAJDENPKP()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GMMFJJDFCOC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EFCFJFIEDKO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NGBKEHIOCAI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void AFDHPMJIHNE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void JLAHABKCJNC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}
}
