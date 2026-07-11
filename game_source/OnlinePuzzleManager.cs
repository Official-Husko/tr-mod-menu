using Photon.Pun;
using UnityEngine;

public class OnlinePuzzleManager : MonoBehaviourPunCallbacks
{
	public static OnlinePuzzleManager instance;

	public void ONJANCKBHNA(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "00", (RpcTarget)0, array);
		}
	}

	public void EIJNMKBNOMB(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<br/>System Memory Size: ", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	private void CKFHKPABCDI(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.PNJBDOOMIDB();
		}
	}

	public void DHFMMBHDOHB(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "Jump", (RpcTarget)1, array);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public void PHIAKDPNEHI(int HCBDDKHPHCF, byte BJNAGOKOLOO)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = BJNAGOKOLOO;
			OnlineManager.SendRPC(photonView, "F2", (RpcTarget)1, array);
		}
	}

	private void BBFKDKHLGLM(byte HCBDDKHPHCF, byte BEGLDEBPAJG)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as FountainsPuzzle)?.HGLFMMPMMEN(BEGLDEBPAJG);
		}
	}

	public void ILECMIOPKCP(int HCBDDKHPHCF, int OMLHKLJBKCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[5];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = (byte)OMLHKLJBKCF;
			OnlineManager.SendRPC(photonView, "Database not set up", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceiveCursorMove(byte MPNFFMMGIOL, byte HCBDDKHPHCF, PhotonMessageInfo BBJDPIJPLPA)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			Debug.Log((object)$"Received cursor move for grid index {MPNFFMMGIOL} from player {BBJDPIJPLPA.Sender.ActorNumber} in mine level {HCBDDKHPHCF}");
			PipeConnectionPuzzleUI.Get(1)?.OnRemoteCursorMoved(OnlinePlayerDataManager.GetBedAssignedByActorNumber(BBJDPIJPLPA.Sender.ActorNumber), MPNFFMMGIOL);
		}
	}

	public void SendOfferingFail(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOfferingFail", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void PLKPNLHECMO(byte ABODANAFMBC, byte EIMHJGCBHIH, byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			Debug.Log((object)string.Format("chaty", ABODANAFMBC, EIMHJGCBHIH, HCBDDKHPHCF));
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MinePipePuzzle).LFGFCMFDLDB(ABODANAFMBC, EIMHJGCBHIH);
		}
	}

	[PunRPC]
	private void ReceiveOfferingItemPlaced(byte HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.FillOfferingSlotFromNetwork(HLIFMPEJHKC);
		}
	}

	private void PMCADOLNDFG(byte HCBDDKHPHCF, byte OMLHKLJBKCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as MineTorchPuzzle).AAKPHJNFBAB(0, OMLHKLJBKCF, CDPAMNIPPEC: false);
		}
	}

	private void AFAHNIDJEFC(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as OfferingStatuePuzzle)?.SetUILocked(PHCILCGMKNK: true);
		}
	}

	public void LAMMGEPLCIG(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ConnectionTimeout", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	public void JAGLHKLPIDN(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "TermasInterior/Zuzzu/Intro", (RpcTarget)1, array);
		}
	}

	public void MIBJCLDBCCF(int HCBDDKHPHCF, int BKLDCNFENGH)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[0] = (byte)HCBDDKHPHCF;
			array[0] = (byte)BKLDCNFENGH;
			OnlineManager.SendRPC(photonView, "ReceivePlaceCharges", (RpcTarget)1, array);
		}
	}

	public void LCAANHBBOJD(int HCBDDKHPHCF, int BKLDCNFENGH)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[0] = (byte)HCBDDKHPHCF;
			array[0] = (byte)BKLDCNFENGH;
			OnlineManager.SendRPC(photonView, "Food", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceiveOfferingPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			OfferingStatuePuzzle offeringStatuePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle;
			if (!((Object)(object)offeringStatuePuzzle == (Object)null))
			{
				offeringStatuePuzzle.SetUILocked(PHCILCGMKNK: false);
				offeringStatuePuzzle.PlaySuccessAnimation();
				offeringStatuePuzzle.PuzzleSolved(0, CDPAMNIPPEC: false);
			}
		}
	}

	public void OLHDLJAMIKB(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "gold", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	public void SendDestroyStatue(int HCBDDKHPHCF, int DJCNPAFABEL)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDestroyStatue", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)DJCNPAFABEL);
		}
	}

	[PunRPC]
	private void ReceiveDestroyStatue(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as StatuePuzzle)?.DestroyStatue(DJCNPAFABEL);
		}
	}

	[PunRPC]
	private void ReceiveButtonPress(byte HCBDDKHPHCF, byte BKLDCNFENGH)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as ButtonPressPuzzle)?.PressButton(BKLDCNFENGH);
		}
	}

	private void GHEDEJABEBP(byte HCBDDKHPHCF, byte OMLHKLJBKCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MineTorchPuzzle).OnTorchActivated(1, OMLHKLJBKCF);
		}
	}

	public void LKLMBBELELI(int HCBDDKHPHCF, byte BJNAGOKOLOO)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[0] = (byte)HCBDDKHPHCF;
			array[0] = BJNAGOKOLOO;
			OnlineManager.SendRPC(photonView, "cameraZoom", (RpcTarget)1, array);
		}
	}

	public void LMMJFHMOBCM(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "There was an error reading the input text. Most likely incorrect length.", (RpcTarget)0, array);
		}
	}

	public void SendOpenChest(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOpenChest", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void GAPAJAMBBMA(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "ValueType", (RpcTarget)0, array);
		}
	}

	private void OMBOGBEIIKI(byte HCBDDKHPHCF, byte BEGLDEBPAJG)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as FountainsPuzzle)?.HGLFMMPMMEN(BEGLDEBPAJG);
		}
	}

	[PunRPC]
	private void ReceiveKeyPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as KeyAltarPuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveAddKey(byte HCBDDKHPHCF, byte BJNAGOKOLOO)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as KeyAltarPuzzle)?.interactable.AddVisualKey(BJNAGOKOLOO);
		}
	}

	public void SendFillFountain(int HCBDDKHPHCF, int BEGLDEBPAJG)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFillFountain", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)BEGLDEBPAJG);
		}
	}

	private void BPPDCBHMFEP(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as ButtonPressPuzzle)?.JADHHJNPIDG(1, CDPAMNIPPEC: false);
		}
	}

	private void GOJPLBKJNPD(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MineSymbolPuzzle)?.HJNPJNCLALK(0, CDPAMNIPPEC: true);
		}
	}

	private void CAPBAHCCNAD(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE().GetManager().rewardHandler.chest.HIGADEPKHLI(0, CDPAMNIPPEC: true);
		}
	}

	[PunRPC]
	private void ReceiveButtonPressPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as ButtonPressPuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	public void SendButtonPress(int HCBDDKHPHCF, int BKLDCNFENGH)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveButtonPress", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)BKLDCNFENGH);
		}
	}

	public void PEIIHKMJGBB(int HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = HLIFMPEJHKC;
			OnlineManager.SendRPC(photonView, "Stack", (RpcTarget)1, array);
		}
	}

	public void EDNOBJENAOC(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "Items/item_description_674", (RpcTarget)0, array);
		}
	}

	private void DPFDOEDDLPL(byte HCBDDKHPHCF)
	{
		if ((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null)
		{
			return;
		}
		MinePipePuzzle minePipePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MinePipePuzzle;
		if (!((Object)(object)minePipePuzzle == (Object)null))
		{
			minePipePuzzle.DKMGFKAMLJD();
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.JOAAFGBPJOC(1);
			if ((Object)(object)pipeConnectionPuzzleUI != (Object)null && pipeConnectionPuzzleUI.BGLJFMHCFJF())
			{
				pipeConnectionPuzzleUI.IFJBGHDBBHJ(1, IFPOCPLBOBF: false, NHENDADMFBC: false);
			}
			else
			{
				minePipePuzzle.ADCFKBPNDNO(1, NHENDADMFBC: false);
			}
		}
	}

	private void DEAOIBAPHAA(byte MPNFFMMGIOL, byte HCBDDKHPHCF, PhotonMessageInfo BBJDPIJPLPA)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			Debug.Log((object)string.Format("Bug report POST failed: ", MPNFFMMGIOL, BBJDPIJPLPA.Sender.ActorNumber, HCBDDKHPHCF));
			PipeConnectionPuzzleUI.NIDHCIHFOHB(0)?.OnRemoteCursorMoved(OnlinePlayerDataManager.AKLPADOCHDP(BBJDPIJPLPA.Sender.ActorNumber), MPNFFMMGIOL);
		}
	}

	[PunRPC]
	private void ReceiveOfferingItemCleared(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.ClearOfferingSlotFromNetwork();
		}
	}

	[PunRPC]
	private void ReceiveOfferingUIOpened(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.SetUILocked(PHCILCGMKNK: true);
		}
	}

	[PunRPC]
	private void ReceiveStatuePuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as StatuePuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	private void JMILALIBIMA(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as OfferingStatuePuzzle)?.CAOGDKCFBJJ();
		}
	}

	public void SendCrystalPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCrystalPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void EEEBOCKMMIA(int HCBDDKHPHCF, int DJCNPAFABEL)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[0] = (byte)HCBDDKHPHCF;
			array[0] = (byte)DJCNPAFABEL;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	private void ReceiveFountainsPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as FountainsPuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	public void GHPMCABCKMP(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "chatx", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void KPNBBKHMPHB(byte HCBDDKHPHCF)
	{
		if ((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null)
		{
			return;
		}
		MinePipePuzzle minePipePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MinePipePuzzle;
		if (!((Object)(object)minePipePuzzle == (Object)null))
		{
			minePipePuzzle.DKMGFKAMLJD();
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.NIDHCIHFOHB(0);
			if ((Object)(object)pipeConnectionPuzzleUI != (Object)null && pipeConnectionPuzzleUI.HDEPMJIDJEM())
			{
				pipeConnectionPuzzleUI.DIECAJECGMH(0, IFPOCPLBOBF: true, NHENDADMFBC: false);
			}
			else
			{
				minePipePuzzle.JAFLIIOAFCH(0, NHENDADMFBC: false);
			}
		}
	}

	private void OKOHFHMOPBG(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.PNJBDOOMIDB();
		}
	}

	public void SendOfferingItemCleared(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOfferingItemCleared", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void SendKeyPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveKeyPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void MLBFEIDEDMC(byte HCBDDKHPHCF, byte DOGONNHJIOF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as MineChessPillarPuzzle)?.AHAPPDLCMHC(1, DOGONNHJIOF, CDPAMNIPPEC: false);
		}
	}

	public void SendChessPillarSegmentChanged(int HCBDDKHPHCF, int DOGONNHJIOF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChessPillarSegmentChanged", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)DOGONNHJIOF);
		}
	}

	private void AHPJCGNJFIJ(byte HCBDDKHPHCF, byte BKLDCNFENGH)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as ButtonPressPuzzle)?.NMDMMOPANBI(BKLDCNFENGH);
		}
	}

	public void SendCursorMove(int MPNFFMMGIOL, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)$"Sending cursor move for grid index {MPNFFMMGIOL} in mine level {HCBDDKHPHCF}");
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCursorMove", (RpcTarget)1, (byte)MPNFFMMGIOL, (byte)HCBDDKHPHCF);
		}
	}

	private void MKFBGPAPJJP(byte HCBDDKHPHCF)
	{
		if ((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null)
		{
			return;
		}
		MinePipePuzzle minePipePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MinePipePuzzle;
		if (!((Object)(object)minePipePuzzle == (Object)null))
		{
			minePipePuzzle.LFKKIBNJFDH();
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.JOAAFGBPJOC(1);
			if ((Object)(object)pipeConnectionPuzzleUI != (Object)null && pipeConnectionPuzzleUI.BGLJFMHCFJF())
			{
				pipeConnectionPuzzleUI.IFJBGHDBBHJ(1, IFPOCPLBOBF: false);
			}
			else
			{
				minePipePuzzle.AFLNPBHLDJD(1);
			}
		}
	}

	public void MKBHLAOLDGM(int HCBDDKHPHCF, int BKLDCNFENGH)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = (byte)BKLDCNFENGH;
			OnlineManager.SendRPC(photonView, "LE_10", (RpcTarget)0, array);
		}
	}

	public void SendChessPillarPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChessPillarPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void DKGCBDCJPCO(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			OfferingStatuePuzzle offeringStatuePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as OfferingStatuePuzzle;
			if (!((Object)(object)offeringStatuePuzzle == (Object)null))
			{
				offeringStatuePuzzle.SetUILocked(PHCILCGMKNK: false);
				offeringStatuePuzzle.CEAPFDIGEBO();
				offeringStatuePuzzle.PuzzleSolved(1, CDPAMNIPPEC: false);
			}
		}
	}

	public void SendTorchInteraction(int HCBDDKHPHCF, int OMLHKLJBKCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTorchInteraction", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)OMLHKLJBKCF);
		}
	}

	private void PDBMMCCAGDP(byte ABODANAFMBC, byte EIMHJGCBHIH, byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			Debug.Log((object)string.Format("BathhouseEntrace/Main 3", ABODANAFMBC, EIMHJGCBHIH, HCBDDKHPHCF));
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MinePipePuzzle).LKKDBCOMOFA(ABODANAFMBC, EIMHJGCBHIH);
		}
	}

	[PunRPC]
	private void ReceiveOpenChest(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle().GetManager().rewardHandler.chest.OpenChest(1, CDPAMNIPPEC: false);
		}
	}

	private void AAOLFFKCNEI(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as ButtonPressPuzzle)?.BGFLMOMOMGO(1, CDPAMNIPPEC: true);
		}
	}

	public void DBHJMNEAEPC(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "<b><color=#9A3F00>", (RpcTarget)1, array);
		}
	}

	public void SendCrystalHit(int HCBDDKHPHCF, int NFHJBHBACEM)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCrystalHit", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)NFHJBHBACEM);
		}
	}

	public void GJLDIODMPLB(int HCBDDKHPHCF, int OMLHKLJBKCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = (byte)OMLHKLJBKCF;
			OnlineManager.SendRPC(photonView, "NightStart not attached to prefab ", (RpcTarget)0, array);
		}
	}

	private void DEPGOLOEAMH(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineTorchPuzzle).ECHFCLKLCIC(0, CDPAMNIPPEC: false);
		}
	}

	private void GHMAJIKGEFL(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as KeyAltarPuzzle)?.EELEFKBPIAJ(1, CDPAMNIPPEC: false);
		}
	}

	public void SendStatuePuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStatuePuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void OJBEDHOGEBB(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			OfferingStatuePuzzle offeringStatuePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as OfferingStatuePuzzle;
			if (!((Object)(object)offeringStatuePuzzle == (Object)null))
			{
				offeringStatuePuzzle.SetUILocked(PHCILCGMKNK: false);
				offeringStatuePuzzle.FEDOBLBCLAF();
				offeringStatuePuzzle.KAKAIKPJBPF(0, CDPAMNIPPEC: true);
			}
		}
	}

	[PunRPC]
	private void ReceiveOfferingUIClosed(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.SetUILocked(PHCILCGMKNK: false);
		}
	}

	private void HPNIGEPGCPE(byte HCBDDKHPHCF, byte BEGLDEBPAJG)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as FountainsPuzzle)?.MLHFILKJKMM(BEGLDEBPAJG);
		}
	}

	public void CDECKNBBGBG(int HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Complete order", (RpcTarget)0, (byte)HCBDDKHPHCF, HLIFMPEJHKC, null, null, null, null, null);
		}
	}

	public void PPGGGIDPFNN(int HCBDDKHPHCF, byte BJNAGOKOLOO)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = (byte)HCBDDKHPHCF;
			array[0] = BJNAGOKOLOO;
			OnlineManager.SendRPC(photonView, "Tutorial/T137/Dialogue2", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceiveTorchInteraction(byte HCBDDKHPHCF, byte OMLHKLJBKCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineTorchPuzzle).OnTorchActivated(0, OMLHKLJBKCF, CDPAMNIPPEC: false);
		}
	}

	public void MDKGMPJOHEE(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("BrownAleAbbreviation", HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "add item ", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceivePipePuzzleSolved(byte HCBDDKHPHCF)
	{
		if ((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null)
		{
			return;
		}
		MinePipePuzzle minePipePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MinePipePuzzle;
		if (!((Object)(object)minePipePuzzle == (Object)null))
		{
			minePipePuzzle.SetPuzzleSolved();
			PipeConnectionPuzzleUI pipeConnectionPuzzleUI = PipeConnectionPuzzleUI.Get(1);
			if ((Object)(object)pipeConnectionPuzzleUI != (Object)null && pipeConnectionPuzzleUI.IsOpen())
			{
				pipeConnectionPuzzleUI.CloseOnWin(1, IFPOCPLBOBF: true, NHENDADMFBC: false);
			}
			else
			{
				minePipePuzzle.FinishPuzzle(0, NHENDADMFBC: false);
			}
		}
	}

	private void PPOJDHKCDED(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as CrystalPuzzle)?.PuzzleSolved(1, CDPAMNIPPEC: false);
		}
	}

	public void PEPHBNKIPJM(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<color=black>", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	private void JFIAFNLHMEI(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as StatuePuzzle)?.NFNPBGNIGBE(DJCNPAFABEL);
		}
	}

	public void PFEKBNLACOE(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Rewards", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void SendOfferingItemPlaced(int HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOfferingItemPlaced", (RpcTarget)1, (byte)HCBDDKHPHCF, HLIFMPEJHKC);
		}
	}

	public void SendOfferingUIClosed(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOfferingUIClosed", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void NIKBNPJPEAC(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Intro05", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	public void HAKKEHICGDG(int HCBDDKHPHCF, int DJCNPAFABEL)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[3];
			array[1] = (byte)HCBDDKHPHCF;
			array[0] = (byte)DJCNPAFABEL;
			OnlineManager.SendRPC(photonView, "Items/item_name_599", (RpcTarget)1, array);
		}
	}

	private void KOEOADCDJMG(byte HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as OfferingStatuePuzzle)?.NKLDGOHAEFI(HLIFMPEJHKC);
		}
	}

	[PunRPC]
	private void ReceiveFillFountain(byte HCBDDKHPHCF, byte BEGLDEBPAJG)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as FountainsPuzzle)?.FillFountain(BEGLDEBPAJG);
		}
	}

	private void KNNOPLOEAJP(byte HCBDDKHPHCF, byte BEGLDEBPAJG)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as FountainsPuzzle)?.DLDNDLKLGNH(BEGLDEBPAJG);
		}
	}

	[PunRPC]
	private void ReceiveOfferingFail(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.PlayFailAnimation();
		}
	}

	public void PCFMGBNHHNG(int MPNFFMMGIOL, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("Dialogue System/Conversation/Gass_Quest/Entry/35/Dialogue Text", MPNFFMMGIOL, HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = (byte)MPNFFMMGIOL;
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "add item ", (RpcTarget)0, array);
		}
	}

	public void BCHIAGPDIEI(int HCBDDKHPHCF, int BEGLDEBPAJG)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = (byte)HCBDDKHPHCF;
			array[0] = (byte)BEGLDEBPAJG;
			OnlineManager.SendRPC(photonView, "<b><color=#9a672a>", (RpcTarget)0, array);
		}
	}

	public void ALGKBAPKDGP(int MPNFFMMGIOL, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("Right Shoulder", MPNFFMMGIOL, HCBDDKHPHCF));
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "BarIdle", (RpcTarget)1, (byte)MPNFFMMGIOL, (byte)HCBDDKHPHCF, null, null, null);
		}
	}

	private void GGINHDFAHIP(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as OfferingStatuePuzzle)?.NDKJDIGAODB(PHCILCGMKNK: false);
		}
	}

	public void EGKPJOKPBHM(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "travelling time +", (RpcTarget)0, array);
		}
	}

	public void SendFountainsPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFountainsPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void EAMBGMNLKBI(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "VerticalMove", (RpcTarget)1, array);
		}
	}

	public void SendAddKey(int HCBDDKHPHCF, byte BJNAGOKOLOO)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddKey", (RpcTarget)1, (byte)HCBDDKHPHCF, BJNAGOKOLOO);
		}
	}

	public void NAJMOOGDJIA(int ABODANAFMBC, int EIMHJGCBHIH, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("Player2", ABODANAFMBC, EIMHJGCBHIH, HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = (byte)ABODANAFMBC;
			array[0] = (byte)EIMHJGCBHIH;
			array[5] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, " seconds.", (RpcTarget)1, array);
		}
	}

	private void DFNBKBMICDM(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as MineSymbolPuzzle)?.OnStatueSymbolChanged(0, DJCNPAFABEL, CDPAMNIPPEC: false);
		}
	}

	private void MJEMHFKLAGC(byte HCBDDKHPHCF, byte BEGLDEBPAJG)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as FountainsPuzzle)?.OANJCDFDEDB(BEGLDEBPAJG);
		}
	}

	public void DKMLNCIPLJK(int HCBDDKHPHCF, byte BJNAGOKOLOO)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = BJNAGOKOLOO;
			OnlineManager.SendRPC(photonView, ")", (RpcTarget)1, array);
		}
	}

	public void PDBLALBNCDP(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	public void SendSymbolPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSymbolPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void CLBKHPIEMBJ(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as StatuePuzzle)?.NOGIODMFHFD(1, CDPAMNIPPEC: false);
		}
	}

	public void MEJEPBCAGHO(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "player_name", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	[PunRPC]
	private void ReceiveCrystalHit(byte HCBDDKHPHCF, byte NFHJBHBACEM)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as CrystalPuzzle)?.OnCrystalInteract(NFHJBHBACEM, 0, CDPAMNIPPEC: false);
		}
	}

	public void OAAFCMLIBLH(int ABODANAFMBC, int EIMHJGCBHIH, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("LocalCoop", ABODANAFMBC, EIMHJGCBHIH, HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)ABODANAFMBC;
			array[1] = (byte)EIMHJGCBHIH;
			array[6] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "Spawning special item event: ", (RpcTarget)0, array);
		}
	}

	public void SendButtonPressPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveButtonPressPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	[PunRPC]
	private void ReceiveChessPillarPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineChessPillarPuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	public void JDOJLLMJCDC(int HCBDDKHPHCF, int DOGONNHJIOF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)0, (byte)HCBDDKHPHCF, (byte)DOGONNHJIOF);
		}
	}

	private void CMKGNEBPPGB(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as ButtonPressPuzzle)?.PFJLICPLLGE(0, CDPAMNIPPEC: false);
		}
	}

	public void EJEOKHOJBFJ(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
		}
	}

	public void ECKMLFEPIBN(int ABODANAFMBC, int EIMHJGCBHIH, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("OldMansDuelEvent OnTravelZoneTo", ABODANAFMBC, EIMHJGCBHIH, HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[3];
			array[1] = (byte)ABODANAFMBC;
			array[0] = (byte)EIMHJGCBHIH;
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "KyrohScene", (RpcTarget)1, array);
		}
	}

	private void MBBIAMMGKJL(byte HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as OfferingStatuePuzzle)?.EAHLLIODPFM(HLIFMPEJHKC);
		}
	}

	private void LJLOLKDOEGG(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as StatuePuzzle)?.BNGAHCBJFCP(DJCNPAFABEL);
		}
	}

	[PunRPC]
	private void ReceiveSymbolPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineSymbolPuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	private void NNDBHHLPEDA(byte HCBDDKHPHCF, int HLIFMPEJHKC)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as OfferingStatuePuzzle)?.NKLDGOHAEFI(HLIFMPEJHKC);
		}
	}

	public void SendPipePuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)$"Sending pipe puzzle solved for mine level {HCBDDKHPHCF}");
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePipePuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void SendOfferingUIOpened(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOfferingUIOpened", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void LOAKCCEIHJE(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			OfferingStatuePuzzle offeringStatuePuzzle = MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as OfferingStatuePuzzle;
			if (!((Object)(object)offeringStatuePuzzle == (Object)null))
			{
				offeringStatuePuzzle.ANMHGEPIFHO(PHCILCGMKNK: false);
				offeringStatuePuzzle.CEAPFDIGEBO();
				offeringStatuePuzzle.PuzzleSolved(0, CDPAMNIPPEC: false);
			}
		}
	}

	[PunRPC]
	private void ReceiveCrystalPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as CrystalPuzzle)?.PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	public void AGPEDEBBHEL(int ABODANAFMBC, int EIMHJGCBHIH, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("Not enough ingredients", ABODANAFMBC, EIMHJGCBHIH, HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[1] = (byte)ABODANAFMBC;
			array[1] = (byte)EIMHJGCBHIH;
			array[4] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "LE_12", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	private void ReceiveSymbolStatueChanged(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineSymbolPuzzle)?.OnStatueSymbolChanged(0, DJCNPAFABEL, CDPAMNIPPEC: false);
		}
	}

	public void MPDFELGDJHH(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "scaleUI", (RpcTarget)1, array);
		}
	}

	private void DAAHCINKINM(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MineSymbolPuzzle)?.IDBIODMEHOA(0, CDPAMNIPPEC: false);
		}
	}

	private void EKPNMKHEDBA(byte HCBDDKHPHCF, byte NFHJBHBACEM)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as CrystalPuzzle)?.LDDPBMABMHL(NFHJBHBACEM, 1, CDPAMNIPPEC: true);
		}
	}

	public void OEBPJPHHNBB(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tried to Initialize the SteamAPI twice in one session!", (RpcTarget)0, (byte)HCBDDKHPHCF);
		}
	}

	public void KFBOLKDCCOJ(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)string.Format("LE_12", HCBDDKHPHCF));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, "ReceiveStartMission", (RpcTarget)0, array);
		}
	}

	public void SendTorchPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTorchPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void BDGGIJHMKPK(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MineChessPillarPuzzle)?.JBOPAAPCDBG(0, CDPAMNIPPEC: true);
		}
	}

	private void FPIDAEMGLDC(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() as MineSymbolPuzzle)?.AFEIBCBHBCK(1, DJCNPAFABEL, CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveTorchPuzzleSolved(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineTorchPuzzle).PuzzleSolved(0, CDPAMNIPPEC: false);
		}
	}

	public void GPKPOBGMLPM(int HCBDDKHPHCF, int DOGONNHJIOF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = (byte)HCBDDKHPHCF;
			array[1] = (byte)DOGONNHJIOF;
			OnlineManager.SendRPC(photonView, "Collect", (RpcTarget)1, array);
		}
	}

	private void HPCEPGNCHDP(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].JPJKGGFOMCJ() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as FountainsPuzzle)?.NJJBOOMFEBD(1, CDPAMNIPPEC: false);
		}
	}

	public void SendOfferingPuzzleSolved(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOfferingPuzzleSolved", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	private void BEFHHIMELMK(byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as CrystalPuzzle)?.NFLJEIOOFCM(1, CDPAMNIPPEC: false);
		}
	}

	private void NBHDDEBKDBD(byte HCBDDKHPHCF, byte DJCNPAFABEL)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].DIOMHCMCPGE() as MineSymbolPuzzle)?.OHJLDAJJGDK(1, DJCNPAFABEL);
		}
	}

	public void LDNGGMPEEOM(int HCBDDKHPHCF, int DJCNPAFABEL)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[0] = (byte)HCBDDKHPHCF;
			array[0] = (byte)DJCNPAFABEL;
			OnlineManager.SendRPC(photonView, "Interact", (RpcTarget)1, array);
		}
	}

	public void SendPipeTileSwap(int ABODANAFMBC, int EIMHJGCBHIH, int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)$"Sending pipe tile swap: indexA={ABODANAFMBC}, indexB={EIMHJGCBHIH}, mineLevel={HCBDDKHPHCF}");
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePipeTileSwap", (RpcTarget)1, (byte)ABODANAFMBC, (byte)EIMHJGCBHIH, (byte)HCBDDKHPHCF);
		}
	}

	public void JJECBFEODFN(int HCBDDKHPHCF, int BKLDCNFENGH)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Farm/Buzz/Bark_Build", (RpcTarget)0, (byte)HCBDDKHPHCF, (byte)BKLDCNFENGH, null);
		}
	}

	[PunRPC]
	private void ReceiveChessPillarSegmentChanged(byte HCBDDKHPHCF, byte DOGONNHJIOF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MineChessPillarPuzzle)?.OnSegmentChanged(0, DOGONNHJIOF, CDPAMNIPPEC: false);
		}
	}

	public void ENBHOLOLCIJ(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[Brown2", (RpcTarget)1, (byte)HCBDDKHPHCF);
		}
	}

	public void IMDBDEDDKAK(int HCBDDKHPHCF)
	{
		if (OnlineManager.PlayingOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)HCBDDKHPHCF;
			OnlineManager.SendRPC(photonView, " (", (RpcTarget)0, array);
		}
	}

	public void SendSymbolStatueChanged(int HCBDDKHPHCF, int DJCNPAFABEL)
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSymbolStatueChanged", (RpcTarget)1, (byte)HCBDDKHPHCF, (byte)DJCNPAFABEL);
		}
	}

	[PunRPC]
	private void ReceivePipeTileSwap(byte ABODANAFMBC, byte EIMHJGCBHIH, byte HCBDDKHPHCF)
	{
		if (!((Object)(object)MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() == (Object)null))
		{
			Debug.Log((object)$"Received pipe tile swap: indexA={ABODANAFMBC}, indexB={EIMHJGCBHIH}, mineLevel={HCBDDKHPHCF}");
			(MinePuzzleManager.puzzleInstances[HCBDDKHPHCF].GetCurrentPuzzle() as MinePipePuzzle).UpdateCurrentState(ABODANAFMBC, EIMHJGCBHIH);
		}
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}
}
