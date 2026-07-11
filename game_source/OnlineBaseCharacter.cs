using System;
using Photon.Pun;
using UnityEngine;

public abstract class OnlineBaseCharacter : OnlineBaseActor, IPunInstantiateMagicCallback
{
	protected string PPHIMGHODKK = "Base Character (UNASSIGNED)";

	protected RpcTarget FOMIELBGMLA = (RpcTarget)4;

	public CharacterCreator characterCreator;

	private HumanInfo NLIAJGCMHCG;

	protected override void Awake()
	{
		base.Awake();
		MKFDEDDJMBG();
		if (!OnlineManager.PlayingOnline())
		{
			OPDBPCGDBPH();
			return;
		}
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog(PPHIMGHODKK + " photon awake", (Object)(object)((Component)this).gameObject);
		}
		if ((Object)(object)characterCreator == (Object)null)
		{
			characterCreator = ((Component)this).GetComponent<CharacterCreator>();
		}
		if ((Object)(object)characterCreator != (Object)null)
		{
			characterCreator.BDJENIOPJKC += KLAPDFKAJCK;
		}
	}

	protected void HHFCMOHBAIM()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		SerializedHumanInfo.OCEDKPEFLJP(characterCreator.humanInfo);
		if (debugNetworkMessages)
		{
			string text = JsonUtility.ToJson((object)SerializedHumanInfo.dataByteArray);
			OnlineManager.NetworkLog(PPHIMGHODKK + " appearance changed, sending byte array: " + text, (Object)(object)((Component)this).gameObject);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RPCSetSpritesFromByteArray", FOMIELBGMLA, SerializedHumanInfo.dataByteArray, characterCreator.actionAtBeggining == CharacterCreator.CharacterCreatorStartAction.Bouncer);
	}

	protected virtual void KLAPDFKAJCK()
	{
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog("NetworkSync " + PPHIMGHODKK + " OnCharacterAppearanceChanged", (Object)(object)((Component)this).gameObject);
		}
		if (OnlineManager.IsConnected() && !OnlineManager.ClientOnline())
		{
			HHFCMOHBAIM();
		}
	}

	protected abstract void MKFDEDDJMBG();

	[Obsolete]
	protected void FKMCMABFHOJ()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		string text = JsonUtility.ToJson((object)characterCreator.humanInfo.EPBPAFCPHNJ());
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog(PPHIMGHODKK + " appearance changed, sending: " + text, (Object)(object)((Component)this).gameObject);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RPCSetSprites", FOMIELBGMLA, text);
	}

	[PunRPC]
	protected void RPCSetSpritesFromByteArray(byte[] MIOMJONGHCJ, bool IOOEIOPKOBF)
	{
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog($"Received {PPHIMGHODKK} appearance data as byte array: {MIOMJONGHCJ}", (Object)(object)((Component)this).gameObject);
		}
		SerializedHumanInfo.dataByteArray = MIOMJONGHCJ;
		NLIAJGCMHCG = SerializedHumanInfo.MKICFGEDKCM(IOOEIOPKOBF);
		characterCreator.SetHumanInfo(NLIAJGCMHCG);
	}

	protected virtual void OnDestroy()
	{
		if (OnlineManager.PlayingOnline() && (Object)(object)characterCreator != (Object)null)
		{
			characterCreator.BDJENIOPJKC -= KLAPDFKAJCK;
		}
	}

	protected virtual void MNKCLHAIDPB()
	{
		characterCreator = ((Component)this).GetComponent<CharacterCreator>();
	}

	[Obsolete]
	[PunRPC]
	protected void RPCSetSprites(string HCHBEGNMIGC)
	{
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog("Received " + PPHIMGHODKK + " appearance data: " + HCHBEGNMIGC, (Object)(object)((Component)this).gameObject);
		}
		HumanInfo humanInfo = JsonUtility.FromJson<SerializedHumanInfo>(HCHBEGNMIGC).IIJGBJAAFJA();
		characterCreator.SetHumanInfo(humanInfo);
	}

	protected virtual void ENENANMBLDB()
	{
		((Object)((Component)this).gameObject).name = (OnlineManager.IsMasterClient() ? (PPHIMGHODKK + " (Online Master Clone)") : (PPHIMGHODKK + " (Online Remote Clone)"));
	}

	public virtual void OnPhotonInstantiate(PhotonMessageInfo BBJDPIJPLPA)
	{
		ENENANMBLDB();
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog(((object)(PhotonMessageInfo)(ref BBJDPIJPLPA)).ToString());
			OnlineManager.NetworkLog($"{PPHIMGHODKK} photon instantiation. ViewID: {((MonoBehaviourPun)this).photonView.ViewID}", (Object)(object)((Component)this).gameObject);
		}
	}
}
