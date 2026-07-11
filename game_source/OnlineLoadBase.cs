using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[DefaultExecutionOrder(1)]
[RequireComponent(typeof(PhotonView))]
public abstract class OnlineLoadBase : MonoBehaviourPunCallbacks
{
	protected Queue<LoadMessageBase> KIPHJGADOLE = new Queue<LoadMessageBase>();

	public static byte[] infoSerialized;

	protected void AHGEFIOOEBL(string GEGDHHIDEEF, int JJPJHIHBOIB, LoadMessageBase OKCOIHJLGCM, int MEDDFJKOJFB, bool KJOOOPJKLBB = false, bool EFDBJLLKFJG = false)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		AHGEFIOOEBL(GEGDHHIDEEF, player, OKCOIHJLGCM, MEDDFJKOJFB, KJOOOPJKLBB, EFDBJLLKFJG);
	}

	public abstract IEnumerator SendInfo(int JJPJHIHBOIB);

	protected void CGIBEAJOLFF(LoadMessageBase OINICMNOLPK)
	{
		KIPHJGADOLE.Enqueue(OINICMNOLPK);
	}

	protected void MIDIELKKODM<T>(object[] OINICMNOLPK) where T : LoadMessageBase, new()
	{
		T val = new T();
		OnlineSerializer.DeserializeToObject(val, OINICMNOLPK);
		KIPHJGADOLE.Enqueue(val);
	}

	protected void CGIBEAJOLFF<T>(byte[] OINICMNOLPK) where T : LoadMessageBase
	{
		KIPHJGADOLE.Enqueue(OnlineSerializer.Deserialize<T>(OINICMNOLPK));
	}

	public IEnumerator LoadMessageCoroutine()
	{
		int numMsgsProcessed = 0;
		bool loadDone = false;
		while (true)
		{
			if (KIPHJGADOLE.Count > 0)
			{
				foreach (LoadMessageBase item in KIPHJGADOLE)
				{
					if (item.msgID == numMsgsProcessed)
					{
						numMsgsProcessed++;
						KIPHJGADOLE.Dequeue().OEJJGDMKIDN();
						if (item.lastMsg)
						{
							loadDone = true;
						}
						break;
					}
				}
			}
			if (!loadDone)
			{
				yield return null;
				continue;
			}
			break;
		}
	}

	public virtual void LoadMessageStart()
	{
	}

	protected void AHGEFIOOEBL(string GEGDHHIDEEF, Player NLCDDFDGACP, LoadMessageBase OKCOIHJLGCM, int MEDDFJKOJFB, bool KJOOOPJKLBB = false, bool EFDBJLLKFJG = false)
	{
		OKCOIHJLGCM.msgID = (short)MEDDFJKOJFB;
		OKCOIHJLGCM.lastMsg = KJOOOPJKLBB;
		if (EFDBJLLKFJG)
		{
			object[] propertiesInOrder = OnlineSerializer.GetPropertiesInOrder(OKCOIHJLGCM);
			if (OnlineLoadManager.instance.OEBNHGNJEJL && Application.isEditor)
			{
				Debug.Log((object)("Sending " + OKCOIHJLGCM.GetType()?.ToString() + " (ONLINE customSerializer) [master client] length: " + propertiesInOrder.Length + " totalMsgs: " + MEDDFJKOJFB));
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, GEGDHHIDEEF, NLCDDFDGACP, propertiesInOrder);
			return;
		}
		infoSerialized = OnlineSerializer.Serialize(OKCOIHJLGCM);
		if (OnlineLoadManager.instance.OEBNHGNJEJL && Application.isEditor)
		{
			Debug.Log((object)("Sending " + OKCOIHJLGCM.GetType()?.ToString() + " (ONLINE) [master client] length: " + infoSerialized.Length + " totalMsgs: " + MEDDFJKOJFB));
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, GEGDHHIDEEF, NLCDDFDGACP, infoSerialized);
	}

	public virtual void LoadMessageEnd()
	{
	}
}
