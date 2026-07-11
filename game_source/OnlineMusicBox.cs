using UnityEngine;

public class OnlineMusicBox : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		PlayMusic
	}

	public MusicBox musicBox;

	public void CKEFCDIBOEC()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void BFJIOLBIKKG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FPCGKCEAHLK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void DCMEPIHKDOM()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void PDKNKPMADJN()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void LNMECLNFFKA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void HIJBIBAMELL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void AIDLLBBJPEE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void CKJJDLECDEH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void NNMIBIMFGPO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void OJLFJICKDHO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void GKCEEFAHKEL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void EGOCDAMIFHL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void FFLLECFDCON()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void GMJFJMPOOBL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void IKIAOADPBAK()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void SendPlayMusic()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void BDDJAKECFMO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public void BJOBOKDPBEE()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0);
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		musicBox = ((Component)((Component)this).transform).GetComponent<MusicBox>();
		musicBox.onlineMusicBox = this;
	}

	public void EICJLLCCLPL()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void OMFCHALBODB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public void LLDHFGDBHPB()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1);
	}

	public override void ReceiveAction(byte FACPEEACCMH)
	{
		if (FACPEEACCMH == 0)
		{
			musicBox.OpenMusicBox(CDPAMNIPPEC: false);
		}
	}
}
