using System;
using Photon.Pun;
using UnityEngine;

public class OnlineNetworkSyncTEMPLATE : MonoBehaviourPunCallbacks
{
	private OriginalClassTEMPLATE MAIONFDOLPJ;

	private void Awake()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void FHIIAKFNBFB()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Open", (RpcTarget)0);
		}
	}

	private void KDBJHCAEGCM()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Combine(mAIONFDOLPJ.OnActionExecuted, new Action(JMFPEAGHCEA));
		}
	}

	private void LANGHIOBJIH()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Combine(mAIONFDOLPJ.OnActionExecuted, new Action(MOOCILFMPOI));
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Remove(mAIONFDOLPJ.OnActionExecuted, new Action(JMFPEAGHCEA));
		}
	}

	private void MDGLECECOIG()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Remove(mAIONFDOLPJ.OnActionExecuted, new Action(JMFPEAGHCEA));
		}
	}

	[PunRPC]
	private void ActionExecutedRPC()
	{
		MAIONFDOLPJ.GMIMGAOIPOA();
	}

	private void FHOCCEBKHJI()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void PICLLGAOIEE()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ". Time since startup: ", (RpcTarget)0);
		}
	}

	private void JMFPEAGHCEA()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "FishCuttingEvent/Win1", (RpcTarget)0);
		}
	}

	private void KFLCCEEHIME()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Scene ", (RpcTarget)0);
		}
	}

	private void OnDestroy()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Remove(mAIONFDOLPJ.OnActionExecuted, new Action(EGNJOFAOFOA));
		}
	}

	private void NEMHOGAHKNO()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveToolUpgradingRPC", (RpcTarget)1);
		}
	}

	private void KJHKBGDJNDC()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void FKDIBOCJFBP()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "scaleUI", (RpcTarget)0);
		}
	}

	private void LEBMDCCBHGC()
	{
		MAIONFDOLPJ.PCNDNHLJNHG();
	}

	private void MOOCILFMPOI()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ".png", (RpcTarget)0);
		}
	}

	private void DFLCBOPEDGH()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sell", (RpcTarget)0);
		}
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Combine(mAIONFDOLPJ.OnActionExecuted, new Action(EGNJOFAOFOA));
		}
	}

	private void EGNJOFAOFOA()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ActionExecutedRPC", (RpcTarget)1);
		}
	}

	private void HFFFFAJFIPB()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Combine(mAIONFDOLPJ.OnActionExecuted, new Action(GFBOMGEEHFA));
		}
	}

	private void JPOLFKMLHNH()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Combine(mAIONFDOLPJ.OnActionExecuted, new Action(KFLCCEEHIME));
		}
	}

	private void GFBOMGEEHFA()
	{
		if (((MonoBehaviourPun)this).photonView.IsMine)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "00", (RpcTarget)1);
		}
	}

	private void LADLGPKMPBP()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Remove(mAIONFDOLPJ.OnActionExecuted, new Action(GFBOMGEEHFA));
		}
	}

	private void CEOEHODJAJK()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void DCANBENNGDO()
	{
		MAIONFDOLPJ.FLLNOJKFOIM();
	}

	private void DCKKIDMJKJM()
	{
		if (OnlineManager.PlayingOnline())
		{
			OriginalClassTEMPLATE mAIONFDOLPJ = MAIONFDOLPJ;
			mAIONFDOLPJ.OnActionExecuted = (Action)Delegate.Combine(mAIONFDOLPJ.OnActionExecuted, new Action(DFLCBOPEDGH));
		}
	}

	private void IIPKPMPGLOL()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void ALEAOANPHIO()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}

	private void MFGANCCJFJK()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
		}
	}
}
