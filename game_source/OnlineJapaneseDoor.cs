using System;
using Photon.Pun;
using UnityEngine;

public class OnlineJapaneseDoor : OnlineUniqueObject
{
	private enum JDBLOKANBMI
	{
		Open,
		RequestOpen,
		ResponseOpen
	}

	public JapaneseDoor japaneseDoor;

	public bool requestOpenToOtherClients;

	public void ALIELOJPBJC(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.MCIIPKHFFKN(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.CLKOPJDHFKA(CDPAMNIPPEC: true);
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		japaneseDoor = ((Component)((Component)this).transform).GetComponentInChildren<JapaneseDoor>();
		japaneseDoor.onlineJapaneseDoor = this;
		uniqueId = uniqueObject.uniqueID;
	}

	public void OONCEBFCPJO(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void LLDGJBHPKGF(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.FHAIDANLJLO(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: true);
		}
	}

	public void FIEAECGMKBD(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.KBBDFHMMACE(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.AGPKKDHFDLO(CDPAMNIPPEC: true);
		}
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			base.OnDestroy();
			if (OnlineManager.PlayingOnline())
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(KCGOHNMBBOA));
			}
		}
	}

	public void JHDMECEGFGL(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 6, JJPJHIHBOIB, japaneseDoor.open);
	}

	private void GCIOCKGICNI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void OFFOEFIGKGH(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("Must be behind bar" + uniqueId));
		}
	}

	public void OPMNMMHEELL(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)(" (" + uniqueId));
		}
	}

	public void HIPCEDGEJCF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("</color><br>" + uniqueId));
		}
	}

	public void FFBGPCHCKEJ(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)("OnlinePlayer" + uniqueId));
		}
	}

	public void ENHHAPNGOOP(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.Open(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: false);
		}
	}

	public void HGNKIFBFCKN(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("" + uniqueId));
		}
	}

	public void COOFIHBDMBA(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	public void AENBKDKEEJG(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 0, JJPJHIHBOIB, array);
	}

	public void LGKADLPCJFB(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.JHMNFIGPKLN(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: false);
		}
	}

	public void PKNLANGLEJP(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 4, JJPJHIHBOIB, japaneseDoor.open);
	}

	private void BLFFCHPPBPO()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	protected override void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			uniqueId = uniqueObject.uniqueID;
			base.Start();
			if (requestOpenToOtherClients && uniqueId != 0)
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(KCGOHNMBBOA));
			}
		}
	}

	public void ODCCJEHEDHI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void KKNFADLOFNF(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void ILKJEDDNIPK(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Bucket" + uniqueId));
		}
	}

	public void ResponseOpen(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.Open(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: false);
		}
	}

	public void GLEHALFHCKP(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.FHAIDANLJLO(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: false);
		}
	}

	public void ENOFDAGFMNP(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 0, JJPJHIHBOIB, array);
	}

	public void CDIAIHPBCAN(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.JHMNFIGPKLN(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.AGPKKDHFDLO(CDPAMNIPPEC: false);
		}
	}

	public void AGMJBHFFAOB(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.AANKGECHPID(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.AILOICIGFNL(CDPAMNIPPEC: false);
		}
	}

	public void FIIIIMKGLFL(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	public void KGLMDFNPCHG(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.ELCNPCHAEHF(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.AGPKKDHFDLO(CDPAMNIPPEC: false);
		}
	}

	public void KNBKNANKFNE(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 2, JJPJHIHBOIB, array);
	}

	private void PFCNCAIKHBF()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void BNHGFICCEBI()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void JDHGLAEBBDP(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)(" x " + uniqueId));
		}
	}

	private void EPKJGFBIJKO()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void IGEMEEGAFIH(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void PJJIDAAFLEB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("HenHouseTutorialDone" + uniqueId));
		}
	}

	public void JGCJFAGOKFC(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 6, JJPJHIHBOIB, japaneseDoor.open);
	}

	private void EGFCFNNODFC()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		switch (FACPEEACCMH)
		{
		case 0:
			if ((bool)GEMFIOKGIMC[0])
			{
				japaneseDoor.Open(CDPAMNIPPEC: false);
			}
			else
			{
				japaneseDoor.Close(CDPAMNIPPEC: false);
			}
			break;
		case 1:
			RequestOpen((int)GEMFIOKGIMC[0]);
			break;
		case 2:
			ResponseOpen((bool)GEMFIOKGIMC[0]);
			break;
		}
	}

	public void JBMGJHGDLAM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	private void PBHJMENFKPL()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void HMIMMBMJFKK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 6, JJPJHIHBOIB, array);
	}

	private void BIGMEALFPCG()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void CBEBBMNLNDN(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 5, JJPJHIHBOIB, array);
	}

	public void FDCHEILFJOL(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Items/item_description_665" + uniqueId));
		}
	}

	public void NOJMPOCFIJM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void FDAJJEACDMO(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 6, JJPJHIHBOIB, array);
	}

	public void NDLELNINOFJ(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.ELCNPCHAEHF(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: false);
		}
	}

	public void PALPFONFBFE(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void BDJMEIGKCMK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void FNGIIJCPAFI(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.Open(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: true);
		}
	}

	public void JGHGEHPMNNM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 0, JJPJHIHBOIB, array);
	}

	public void HBLJMPPENHA(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, japaneseDoor.open);
	}

	private void EJCNLOKOPBM()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void RequestOpen(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 2, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void DBDPKFBNPMD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)(" on " + uniqueId));
		}
	}

	public void DLEIPDHNLPM(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Player Not Waiting To Start Event" + uniqueId));
		}
	}

	public void KHHHCELKILD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("RecieveEndEvent" + uniqueId));
		}
	}

	public void BMLNNNAICNG(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("Dropping item event {0} for player {1}" + uniqueId));
		}
	}

	public void KKGKONMCPAG(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	private void OINHKFOHEKF()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BCFHOBHDING(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void MIBIGOJGMIP(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 2, JJPJHIHBOIB, array);
	}

	public void FLCPCJAPJDB(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void PLHFGGHPJEJ(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)("StartObserver SalonDelTrono" + uniqueId));
		}
	}

	public void AAMFPPLIPDO(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.HJNFMHOHHGB(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.CLKOPJDHFKA(CDPAMNIPPEC: true);
		}
	}

	public void KCHDPIEBBCJ(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 0, JJPJHIHBOIB, array);
	}

	private void NAOKIBNHAHH()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void PGHOOMOJDJJ()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void HFMEAPJMKPB(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.FHAIDANLJLO(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.AILOICIGFNL(CDPAMNIPPEC: false);
		}
	}

	public void NIELPONCOKB(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.ELCNPCHAEHF(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: false);
		}
	}

	private void AOLFFPCDBMG()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void AGKDOKBNLOC(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 7, JJPJHIHBOIB, array);
	}

	public void BGIDPJHNIFF(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.KBBDFHMMACE(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: true);
		}
	}

	public void FGGGPHMPPHP(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.HJNFMHOHHGB(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.Close(CDPAMNIPPEC: false);
		}
	}

	public void POCCANCCNHE(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("MainProgress" + uniqueId));
		}
	}

	public void OKMLMMKHFEF(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.ELCNPCHAEHF(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.CLKOPJDHFKA(CDPAMNIPPEC: false);
		}
	}

	public void ADAMLDLMALN(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	public void EAAKDDCOAIF(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	private void OKDDIBNPEDF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void KPDPDCIBPFH(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 6, JJPJHIHBOIB, array);
	}

	private void KCGOHNMBBOA()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void GKKBPFHIJPN(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.FHAIDANLJLO(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: false);
		}
	}

	public void KJLDDGFCNFG(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Failed to share file " + uniqueId));
		}
	}

	private void GHHKLAIMMKA()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void PFMLNIIGNLC(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)("" + uniqueId));
		}
	}

	private void NFPHGPAMMKH()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void SendOpen(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)("Japanese Door Not Sending Open Action. Unique ID: " + uniqueId));
		}
	}

	public void CIHFFGADHCD(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.FHAIDANLJLO(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: false);
		}
	}

	public void JIMJDNHFCOK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void NIBGPIOGKDF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)(" * " + uniqueId));
		}
	}

	public void GKILEFEFKJE(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	private void DGLNCPHCKDK()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void BBKLEKOFBLB(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void KOJGHGBBBPJ(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)("Items/item_description_1132" + uniqueId));
		}
	}

	private void KDFFIKKJHHH()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void PMJLEFEMHBM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	public void HKNJMHECHOJ(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.AANKGECHPID(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: false);
		}
	}

	public void PKEGBEJAMFO(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.Open(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.AILOICIGFNL(CDPAMNIPPEC: true);
		}
	}

	public void KJPAMICBGIE(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("EditorAction_5" + uniqueId));
		}
	}

	public void PLKLCGMDIOO(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.JHMNFIGPKLN(CDPAMNIPPEC: true);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: false);
		}
	}

	public void COEAOFNLBMH(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 2, JJPJHIHBOIB, array);
	}

	public void OCFBDEKDKNP(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 0, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void DNEDHOIJKBF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("No bucket of water" + uniqueId));
		}
	}

	public void BMINKJDAAKO(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	public void ECEHFDJDAJM(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("itemColiflowerSeeds" + uniqueId));
		}
	}

	public void DOFLPFFCJHB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("Aging Rack" + uniqueId));
		}
	}

	public void OOBDBLDBNJN(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 0, JJPJHIHBOIB, array);
	}

	public void OINHCAJBNCA(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text" + uniqueId));
		}
	}

	public void IGPPDMIHNFM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void EIIMMHCCCBI(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("BiscuitAleAbbreviation" + uniqueId));
		}
	}

	public void LNHEJEALJOO(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("ZuzzuProgress" + uniqueId));
		}
	}

	public void GEOPEKOHPNO(bool DBCDEKIEHMG)
	{
		if (DBCDEKIEHMG)
		{
			japaneseDoor.Open(CDPAMNIPPEC: false);
		}
		else
		{
			japaneseDoor.NLGFBHJFJMJ(CDPAMNIPPEC: true);
		}
	}

	public void PBMGGPGJJML(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Craft" + uniqueId));
		}
	}

	private void BJMIGHLBBBF()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void KMLNMNJALGM(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)("RequiresMaceration" + uniqueId));
		}
	}

	public void ILCEGIGCOPI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 5, JJPJHIHBOIB, array);
	}

	private void MOMGOLPKEEP()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void CPDEMJDPFBE()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	private void DGMCDPFHGFN()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 0, array);
	}

	public void IKNNGDBHMIK(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("autoRunP2" + uniqueId));
		}
	}

	public void KOIIHNCIPDE(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
		else
		{
			Debug.Log((object)(" (" + uniqueId));
		}
	}

	private void GMMBJCHIEBB()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}

	public void LFEBNILOGFB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("Dialogue System/Conversation/Crowly_Introduce/Entry/18/Dialogue Text" + uniqueId));
		}
	}

	public void FFAGFPDNPPF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("hallway" + uniqueId));
		}
	}

	public void JOBBELFOBLL(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, japaneseDoor.open);
	}

	public void DMOIJJMLKEI(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
		else
		{
			Debug.Log((object)("ReceiveUpdateContentsRoom" + uniqueId));
		}
	}

	private void JFNOIKLBGGI()
	{
		OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void OADCJBPBMEI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	public void CGPPPLJFHFE(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 2, JJPJHIHBOIB, array);
	}

	public void AABKFJLDLMD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
		else
		{
			Debug.Log((object)("SetNPCParent" + uniqueId));
		}
	}

	public void IOPLFHAEHJF(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = japaneseDoor.open;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 5, JJPJHIHBOIB, array);
	}

	private void IPAAFCIAMCP()
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		instance.SendObjectAction(bEIPALOAAJJ, 1, array);
	}
}
