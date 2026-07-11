using Photon.Pun;
using UnityEngine;

public class OnlineDoor : OnlinePlaceable
{
	private enum JDBLOKANBMI
	{
		Open,
		RequestOpen,
		ResponseOpen
	}

	public Door door;

	public bool requestOpenToOtherClients;

	public void AODHHBILMND(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void DECODJKJGPB(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.GIGOAOEHKBA();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	public void HMDDLBPKCNB(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void BKMDEIBJJAO(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void NCDCEKGMOAB(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void PLKAILJGIMF(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void DGDPCCGCLCA(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.AGJJEBPPPAC();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void EGHGNPMFMNL(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.NIAJOGCHBKN();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void IAOAAOBFGNL(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void POCCANCCNHE(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void ONDJPJFGEEB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
	}

	public void AAODIEOOONO(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void KGLMDFNPCHG(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void PFAFIGIACOA(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void KEAIKIPHCPC(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void LMBLDPIPNJD(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void NIBGPIOGKDF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
	}

	public void BBKLEKOFBLB(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 4, JJPJHIHBOIB, door.GIGOAOEHKBA());
	}

	public void FPCEPNPDAND(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void ResponseOpen(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void OEPKOCKOGHI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.ECMGCJGPKNO;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 2, JJPJHIHBOIB, array);
	}

	public void FDAJJEACDMO(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.NIAJOGCHBKN();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void NEEOKGNEPFO(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void KNBKNANKFNE(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.NIAJOGCHBKN();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 6, JJPJHIHBOIB, array);
	}

	public void SendOpen(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
	}

	public void NKIODBAGPKD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void DBENDCJNBDG(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void PKPBPIKGCLD(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.FEIJOJGEBHE();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 5, JJPJHIHBOIB, array);
	}

	public void BGCEFGNPKLF(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.GIGOAOEHKBA();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 7, JJPJHIHBOIB, array);
	}

	public void DMOIJJMLKEI(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void NEGAGIDBPPP(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 0, JJPJHIHBOIB, door.FEIJOJGEBHE());
	}

	public override void ReceiveAction(byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		switch (FACPEEACCMH)
		{
		case 0:
			door.ECMGCJGPKNO = (bool)GEMFIOKGIMC[0];
			break;
		case 1:
			RequestOpen((int)GEMFIOKGIMC[0]);
			break;
		case 2:
			ResponseOpen((bool)GEMFIOKGIMC[0]);
			break;
		}
	}

	public void HFAKPGDKFBC(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void AMIGMGAOJNF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void LJINDHODOEG(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void LAJKJIEDJGJ(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.NIAJOGCHBKN();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void NLKBLBDMDPK(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void BMBHGLELGCO(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.FEIJOJGEBHE();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void FMHDKGFBNIB(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void BMLNNNAICNG(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void FDCHEILFJOL(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void OKCACPPHLOK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = door.AGJJEBPPPAC();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 7, JJPJHIHBOIB, array);
	}

	public void MJEHBJGONCF(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void NDLELNINOFJ(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void KCJIFFGLDGD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
	}

	public void CGFCOIENKCF(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void OBODAAMGCAB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void KNLIDHAENFD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void CDLKAANAGME(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = door.ECMGCJGPKNO;
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	public void DDHAPOKFJMO(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void FFAGFPDNPPF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void GMPFAAMLBKI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 0, JJPJHIHBOIB, door.FEIJOJGEBHE());
	}

	public void FGHOMCNIEHM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = door.FEIJOJGEBHE();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void HOGIBLHJFKK(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void MNCCBAIMKKP(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void KBFGCOINLJA(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void PECBKPLFKAI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.GIGOAOEHKBA();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 5, JJPJHIHBOIB, array);
	}

	public void JLMEEPCIPLK(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public override PlaceableMsg CreateMsg()
	{
		return new DoorMessage(this);
	}

	public void DOIOPIHDFJL(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void OFFOEFIGKGH(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void MOINMJOHPHA(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
	}

	public void GAAGKFCILFM(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void MFGDBFIDCKB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void GIONOBDPOMJ(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void DBDPKFBNPMD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void BDPLAPONOKC(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.AGJJEBPPPAC();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	public void MKAPLEEHLON(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.GIGOAOEHKBA();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 1, JJPJHIHBOIB, array);
	}

	public void CHGPIBGFLJD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
	}

	public void CFNCLJPNABB(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = door.FEIJOJGEBHE();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	public void CFGKIEJPIBD(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.FEIJOJGEBHE();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 0, JJPJHIHBOIB, array);
	}

	public void LKCHJKPDKCH(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.EHCJDLADLDI();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 6, JJPJHIHBOIB, array);
	}

	public void ACNLCACPBFF(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 2, JJPJHIHBOIB, door.AGJJEBPPPAC());
	}

	public void FGLHBPLPKLG(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void AAMFPPLIPDO(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void IEMFFEDCAHH(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void KPBKKMIGOAI(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.EHCJDLADLDI();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 7, JJPJHIHBOIB, array);
	}

	public void GNFKKJOBBPK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 8, JJPJHIHBOIB, door.FEIJOJGEBHE());
	}

	public void BDJMEIGKCMK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.AGJJEBPPPAC();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void AMABHKPIODE(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
	}

	public void FIEAECGMKBD(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void DLEIPDHNLPM(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
	}

	public void EBOAHGFDFDB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void RequestOpen(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 2, JJPJHIHBOIB, door.ECMGCJGPKNO);
	}

	public void KAMDAFFONHF(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void HLBMGNHNIPD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
	}

	public void LFEBNILOGFB(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
	}

	public void LLPLAFHAELK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager.instance.SendObjectActionToActor(uniqueId, 5, JJPJHIHBOIB, door.EHCJDLADLDI());
	}

	public void ADPNEOFCOPJ(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void APOEMCCBIKC(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}

	public void NFADHEAMFMN(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void NOJMPOCFIJM(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[1];
		array[1] = door.FEIJOJGEBHE();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 8, JJPJHIHBOIB, array);
	}

	public void CLCLMGBNKBF(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void HBJICDFPCBP(bool DBCDEKIEHMG)
	{
		door.ForceOpen(DBCDEKIEHMG);
	}

	public void BHAKGKPLIEK(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void ELBPPILIDCE(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, DBCDEKIEHMG);
		}
	}

	public void JNPFAGHPMAE(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[1] = door.NIAJOGCHBKN();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 4, JJPJHIHBOIB, array);
	}

	public void AGMJBHFFAOB(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void EABAHHDGGMK(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 0, DBCDEKIEHMG);
		}
	}

	public override void ObjectConfiguration()
	{
		base.ObjectConfiguration();
		door = ((Component)((Component)this).transform).GetComponentInChildren<Door>();
	}

	public void OLIPAJGENGD(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[1];
			array[1] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void ECAJCMBEPKI(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void CPFMFMKODFK(int JJPJHIHBOIB)
	{
		OnlineObjectsManager instance = OnlineObjectsManager.instance;
		int bEIPALOAAJJ = uniqueId;
		object[] array = new object[0];
		array[0] = door.GIGOAOEHKBA();
		instance.SendObjectActionToActor(bEIPALOAAJJ, 3, JJPJHIHBOIB, array);
	}

	protected override void Start()
	{
		base.Start();
		if (requestOpenToOtherClients && OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager.instance.SendObjectAction(uniqueId, 1, PhotonNetwork.LocalPlayer.ActorNumber);
		}
	}

	public void AMHPMLMNIPC(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void EBJEHDPHLCM(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 1, array);
		}
	}

	public void DBKDBFFLBBO(bool DBCDEKIEHMG)
	{
		if (OnlineManager.PlayingOnline() && uniqueId != 0)
		{
			OnlineObjectsManager instance = OnlineObjectsManager.instance;
			int bEIPALOAAJJ = uniqueId;
			object[] array = new object[0];
			array[0] = DBCDEKIEHMG;
			instance.SendObjectAction(bEIPALOAAJJ, 0, array);
		}
	}

	public void LGKADLPCJFB(bool DBCDEKIEHMG)
	{
		door.PHKCPBGFLMF(DBCDEKIEHMG);
	}

	public void PKLKICKFDMH(bool DBCDEKIEHMG)
	{
		door.LNFHFOFBNMH(DBCDEKIEHMG);
	}
}
