using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public abstract class OnlineBaseActor : MonoBehaviourPunCallbacks, IPunObservable
{
	[SerializeField]
	protected bool debugNetworkMessages;

	[SerializeField]
	protected bool debugNetworkReadWrite;

	[Tooltip("The Player object uses a different type of transform view.")]
	[SerializeField]
	protected PhotonTransformView photonTransformView;

	[SerializeField]
	protected PhotonTransformViewClassic photonTransformViewClassic;

	[PunRPC]
	public void ReceiveActorPosition(float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
	}

	public void SendActorPosition()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveActorPosition", (RpcTarget)1, ((Component)this).transform.position.x, ((Component)this).transform.position.y);
		}
	}

	protected virtual void Awake()
	{
		if ((Object)(object)photonTransformView == (Object)null)
		{
			photonTransformView = ((Component)this).GetComponent<PhotonTransformView>();
		}
		if ((Object)(object)photonTransformView != (Object)null)
		{
			photonTransformView.m_SynchronizeScale = false;
		}
		if ((Object)(object)photonTransformViewClassic == (Object)null)
		{
			photonTransformViewClassic = ((Component)this).GetComponent<PhotonTransformViewClassic>();
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			photonTransformViewClassic.m_ScaleModel.SynchronizeEnabled = false;
		}
	}

	public void SetPosition(float AIANGPHHEHI, float JAMLBMCDGOL)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)photonTransformView != (Object)null)
		{
			((Behaviour)photonTransformView).enabled = false;
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			((Behaviour)photonTransformViewClassic).enabled = false;
		}
		((Component)this).transform.position = new Vector3(AIANGPHHEHI, JAMLBMCDGOL, 0f);
		if ((Object)(object)photonTransformView != (Object)null)
		{
			((Behaviour)photonTransformView).enabled = true;
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			((Behaviour)photonTransformViewClassic).enabled = true;
		}
	}

	public virtual void OnPhotonSerializeView(PhotonStream OEJPCOIDLFK, PhotonMessageInfo BBJDPIJPLPA)
	{
		if (debugNetworkMessages && debugNetworkReadWrite)
		{
			Debug.Log((object)(OEJPCOIDLFK.IsWriting ? (((object)((Component)this).gameObject).ToString() + " is Writing.") : (((object)((Component)this).gameObject).ToString() + " is Reading.")));
		}
	}

	protected void OPDBPCGDBPH()
	{
		if ((Object)(object)((MonoBehaviourPun)this).photonView == (Object)null)
		{
			return;
		}
		foreach (Component observedComponent in ((MonoBehaviourPun)this).photonView.ObservedComponents)
		{
			Object.Destroy((Object)(object)observedComponent);
		}
		Object.Destroy((Object)(object)((MonoBehaviourPun)this).photonView);
	}
}
