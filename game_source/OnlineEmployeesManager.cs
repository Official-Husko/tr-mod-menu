using System.Collections.Generic;
using Photon.Pun;

public class OnlineEmployeesManager : MonoBehaviourPunCallbacks
{
	public static OnlineEmployeesManager instance;

	public void FCHAAMIHDGO(WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			ReceiveHireWorkerMaster((byte)NNLPGGPPCNF, (byte)NECIOBGLOPF);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (byte)NNLPGGPPCNF;
		array[1] = (byte)NECIOBGLOPF;
		OnlineManager.SendRPC(photonView, "Error_RoomIndependent", (RpcTarget)7, array);
	}

	[PunRPC]
	private void ReceiveHireWorkerMaster(byte NNLPGGPPCNF, byte NECIOBGLOPF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHireWorker", (RpcTarget)0, NNLPGGPPCNF, NECIOBGLOPF);
	}

	private void PHPJJKMEHOB(byte NNLPGGPPCNF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = NNLPGGPPCNF;
		OnlineManager.SendRPC(photonView, "Move Forward", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveEmployeeTask(byte NNLPGGPPCNF, byte ABAIKKGKDGD, bool AODONKKHPBP)
	{
		StaffManager.SetEmployeeTask(1, (WorkerType)NNLPGGPPCNF, ABAIKKGKDGD, AODONKKHPBP);
	}

	public void SendDismissWorker(WorkerType NNLPGGPPCNF)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveDismissWorkerMaster((byte)NNLPGGPPCNF);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDismissWorkerMaster", (RpcTarget)2, (byte)NNLPGGPPCNF);
	}

	private void DPCDNFEMJFE(byte NNLPGGPPCNF, byte NECIOBGLOPF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = NNLPGGPPCNF;
		array[1] = NECIOBGLOPF;
		OnlineManager.SendRPC(photonView, "PanelToggleUI", (RpcTarget)1, array);
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void CIBKCCGLJPP(byte NNLPGGPPCNF, byte ABAIKKGKDGD, bool AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = NNLPGGPPCNF;
		array[0] = ABAIKKGKDGD;
		array[3] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "PopUp without ID: ", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveLevelPoints(byte NNLPGGPPCNF, short ECGNJPCBAAH)
	{
		StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).FKJLDHGCJCM(ECGNJPCBAAH);
	}

	public void SendNewEmployees(List<EmployeeInfo> NKDMOMFEOMK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNewEmployees", (RpcTarget)1, OnlineSerializer.Serialize(new EmployeesMessage(NKDMOMFEOMK)));
	}

	[PunRPC]
	private void ReceiveEmployeeWorkingMaster(byte NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEmployeeWorking", (RpcTarget)0, NNLPGGPPCNF, AIKLCDAKADI);
	}

	private void BEGJGOPKMNJ(byte NNLPGGPPCNF, byte NECIOBGLOPF)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = NNLPGGPPCNF;
		array[0] = NECIOBGLOPF;
		OnlineManager.SendRPC(photonView, "Items/item_name_682", (RpcTarget)0, array);
	}

	public void IPGMENMAODM(WorkerType NNLPGGPPCNF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Open", (RpcTarget)1, (byte)NNLPGGPPCNF);
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	public void OMNGAADDHOH(WorkerType NNLPGGPPCNF, int HDHPJJOCJEO, int HNEIOHDBGLM)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			ReceiveUnlockPerkLevelMaster((byte)NNLPGGPPCNF, (byte)HDHPJJOCJEO, (byte)HNEIOHDBGLM);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)NNLPGGPPCNF;
		array[0] = (byte)HDHPJJOCJEO;
		array[3] = (byte)HNEIOHDBGLM;
		OnlineManager.SendRPC(photonView, "SmokeBomb", (RpcTarget)0, array);
	}

	private void PLCMJMELMAK(byte NNLPGGPPCNF, byte ABAIKKGKDGD, bool AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[Brown", (RpcTarget)0, NNLPGGPPCNF, ABAIKKGKDGD, null, null, AODONKKHPBP);
	}

	[PunRPC]
	private void ReceiveIncreaseLevel(byte NNLPGGPPCNF)
	{
		StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).LHLJGJAENKI();
	}

	[PunRPC]
	public void ReceiveSelectPerkLevelMaster(byte NNLPGGPPCNF, byte HDHPJJOCJEO, byte HNEIOHDBGLM)
	{
		ReceiveSelectPerkLevel(NNLPGGPPCNF, HDHPJJOCJEO, HNEIOHDBGLM);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSelectPerkLevel", (RpcTarget)1, NNLPGGPPCNF, HDHPJJOCJEO, HNEIOHDBGLM);
	}

	[PunRPC]
	private void ReceiveNewEmployees(byte[] OINICMNOLPK)
	{
		EmployeesMessage employeesMessage = OnlineSerializer.Deserialize<EmployeesMessage>(OINICMNOLPK);
		StaffManager.ResetWorkerOptions();
		for (int i = 0; i < employeesMessage.list.Length; i++)
		{
			StaffManager.SetWorkerOption((WorkerType)employeesMessage.list[i].workerType, employeesMessage.list[i].MBEMBCLOFAG());
		}
	}

	private void FNNHEJMEMEC(byte NNLPGGPPCNF, short ECGNJPCBAAH)
	{
		StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).HIGONOMBGJJ(ECGNJPCBAAH);
	}

	private void IFJCJINJAAD(byte NNLPGGPPCNF, byte NECIOBGLOPF)
	{
		StaffManager.HireWorker(1, (WorkerType)NNLPGGPPCNF, NECIOBGLOPF);
	}

	[PunRPC]
	private void ReceiveEmployeeWorking(byte NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		StaffManager.SetWorking(1, (WorkerType)NNLPGGPPCNF, AIKLCDAKADI);
	}

	public void OAHNBEADJIP(WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			AEFDIIPANKL((byte)NNLPGGPPCNF, (byte)ABAIKKGKDGD, AODONKKHPBP);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (byte)NNLPGGPPCNF;
		array[0] = (byte)ABAIKKGKDGD;
		array[5] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "add item ", (RpcTarget)5, array);
	}

	private void AEFDIIPANKL(byte NNLPGGPPCNF, byte ABAIKKGKDGD, bool AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = NNLPGGPPCNF;
		array[1] = ABAIKKGKDGD;
		array[7] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "Player minigame states: \n {0}, {1}, {2}, {3},", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveUnlockPerkLevel(byte NNLPGGPPCNF, byte HDHPJJOCJEO, byte HNEIOHDBGLM)
	{
		StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).KBNJKIECOOF(HDHPJJOCJEO, HNEIOHDBGLM);
	}

	[PunRPC]
	private void ReceiveDismissWorker(byte NNLPGGPPCNF)
	{
		StaffManager.DismissWorker((WorkerType)NNLPGGPPCNF);
	}

	public void SendIncreaseLevel(WorkerType NNLPGGPPCNF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveIncreaseLevel", (RpcTarget)1, (byte)NNLPGGPPCNF);
	}

	public void MBNODMEOIPB(WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			BEGJGOPKMNJ((byte)NNLPGGPPCNF, (byte)NECIOBGLOPF);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetInt", (RpcTarget)8, (byte)NNLPGGPPCNF, (byte)NECIOBGLOPF, null, null, null);
	}

	public void SendEmployeeWorking(WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveEmployeeWorkingMaster((byte)NNLPGGPPCNF, AIKLCDAKADI);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEmployeeWorkingMaster", (RpcTarget)2, (byte)NNLPGGPPCNF, AIKLCDAKADI);
	}

	[PunRPC]
	private void ReceiveEmployeeTaskMaster(byte NNLPGGPPCNF, byte ABAIKKGKDGD, bool AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEmployeeTask", (RpcTarget)0, NNLPGGPPCNF, ABAIKKGKDGD, AODONKKHPBP);
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public void PINLJBHCMLM(WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		if (OnlineManager.IsMasterClient())
		{
			DBJOBIKOOJM((byte)NNLPGGPPCNF, AIKLCDAKADI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)NNLPGGPPCNF;
		array[0] = AIKLCDAKADI;
		OnlineManager.SendRPC(photonView, "Mine Helmet Light -> Character Changed. Helmet With Lught? {0} | Hair Sprite: {1}", (RpcTarget)3, array);
	}

	public void BFBHBDNPBEK(List<EmployeeInfo> NKDMOMFEOMK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Reverence", (RpcTarget)0, OnlineSerializer.JBIPDCGKMGE(new EmployeesMessage(NKDMOMFEOMK)));
	}

	private void PCKELAKDPAE(byte NNLPGGPPCNF, short ECGNJPCBAAH)
	{
		StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).FKJLDHGCJCM(ECGNJPCBAAH);
	}

	public void ENLFPJGAPGE(WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		if (OnlineManager.IsMasterClient())
		{
			DBJOBIKOOJM((byte)NNLPGGPPCNF, AIKLCDAKADI);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = (byte)NNLPGGPPCNF;
		array[0] = AIKLCDAKADI;
		OnlineManager.SendRPC(photonView, "InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ", (RpcTarget)8, array);
	}

	public void SendHireWorker(WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveHireWorkerMaster((byte)NNLPGGPPCNF, (byte)NECIOBGLOPF);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHireWorkerMaster", (RpcTarget)2, (byte)NNLPGGPPCNF, (byte)NECIOBGLOPF);
	}

	public void SendSelectPerkLevelMaster(WorkerType NNLPGGPPCNF, int HDHPJJOCJEO, int HNEIOHDBGLM)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveSelectPerkLevelMaster((byte)NNLPGGPPCNF, (byte)HDHPJJOCJEO, (byte)HNEIOHDBGLM);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSelectPerkLevelMaster", (RpcTarget)2, (byte)NNLPGGPPCNF, (byte)HDHPJJOCJEO, (byte)HNEIOHDBGLM);
	}

	private void Awake()
	{
		instance = this;
	}

	public void KPOGKNDMCPD(WorkerType NNLPGGPPCNF, int HDHPJJOCJEO, int HNEIOHDBGLM)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			FDAPIOGOFBF((byte)NNLPGGPPCNF, (byte)HDHPJJOCJEO, (byte)HNEIOHDBGLM);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)NNLPGGPPCNF;
		array[1] = (byte)HDHPJJOCJEO;
		array[2] = (byte)HNEIOHDBGLM;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Standar/Entry/27/Dialogue Text", (RpcTarget)8, array);
	}

	public void SendEmployeeTask(WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveEmployeeTaskMaster((byte)NNLPGGPPCNF, (byte)ABAIKKGKDGD, AODONKKHPBP);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEmployeeTaskMaster", (RpcTarget)2, (byte)NNLPGGPPCNF, (byte)ABAIKKGKDGD, AODONKKHPBP);
	}

	[PunRPC]
	private void ReceiveUnlockPerkLevelMaster(byte NNLPGGPPCNF, byte HDHPJJOCJEO, byte HNEIOHDBGLM)
	{
		if (StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).KBNJKIECOOF(HDHPJJOCJEO, HNEIOHDBGLM))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUnlockPerkLevel", (RpcTarget)1, NNLPGGPPCNF, HDHPJJOCJEO, HNEIOHDBGLM);
		}
	}

	[PunRPC]
	private void ReceiveDismissWorkerMaster(byte NNLPGGPPCNF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDismissWorker", (RpcTarget)0, NNLPGGPPCNF);
	}

	public void SendUnlockPerkLevelMaster(WorkerType NNLPGGPPCNF, int HDHPJJOCJEO, int HNEIOHDBGLM)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveUnlockPerkLevelMaster((byte)NNLPGGPPCNF, (byte)HDHPJJOCJEO, (byte)HNEIOHDBGLM);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUnlockPerkLevelMaster", (RpcTarget)2, (byte)NNLPGGPPCNF, (byte)HDHPJJOCJEO, (byte)HNEIOHDBGLM);
	}

	private void FDAPIOGOFBF(byte NNLPGGPPCNF, byte HDHPJJOCJEO, byte HNEIOHDBGLM)
	{
		if (StaffManager.GPPOAHEDNMB((WorkerType)NNLPGGPPCNF).KBNJKIECOOF(HDHPJJOCJEO, HNEIOHDBGLM))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Inventory full", (RpcTarget)0, NNLPGGPPCNF, HDHPJJOCJEO, null, null, null, HNEIOHDBGLM, null, null);
		}
	}

	private void EADAEIKBFBM(byte NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		StaffManager.SetWorking(0, (WorkerType)NNLPGGPPCNF, AIKLCDAKADI);
	}

	[PunRPC]
	private void ReceiveHireWorker(byte NNLPGGPPCNF, byte NECIOBGLOPF)
	{
		StaffManager.HireWorker(1, (WorkerType)NNLPGGPPCNF, NECIOBGLOPF);
	}

	private void DBJOBIKOOJM(byte NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = NNLPGGPPCNF;
		array[0] = AIKLCDAKADI;
		OnlineManager.SendRPC(photonView, "City/PetShop/Nessy/Barks_CatSleep", (RpcTarget)1, array);
	}

	public void SendLevelPoints(WorkerType NNLPGGPPCNF, int ECGNJPCBAAH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLevelPoints", (RpcTarget)1, (byte)NNLPGGPPCNF, (short)ECGNJPCBAAH);
	}

	[PunRPC]
	private void ReceiveSelectPerkLevel(byte NNLPGGPPCNF, byte HDHPJJOCJEO, byte HNEIOHDBGLM)
	{
		StaffManager.GetWorkerInfo((WorkerType)NNLPGGPPCNF).LDENFCNAIFG(HDHPJJOCJEO, HNEIOHDBGLM);
	}
}
