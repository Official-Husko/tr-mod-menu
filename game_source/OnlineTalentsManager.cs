using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineTalentsManager : MonoBehaviourPunCallbacks
{
	[CompilerGenerated]
	private sealed class JHCFAGCIHMH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineTalentsManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public JHCFAGCIHMH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			OnlineTalentsManager onlineTalentsManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (PerksDatabaseAccessor.GetPerksLevels() != null)
				{
					short[] array = PerksDatabaseAccessor.GetPerksLevels().Keys.Select((int x) => (short)x).ToArray();
					byte[] array2 = PerksDatabaseAccessor.GetPerksLevels().Values.Select((int x) => (byte)x).ToArray();
					OnlineManager.SendRPC(((MonoBehaviourPun)onlineTalentsManager).photonView, "ReceiveTalentsFromOther", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber, array, array2);
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static OnlineTalentsManager instance;

	private void ECPGIJOCCKL()
	{
		try
		{
			((MonoBehaviour)this).StartCoroutine(JCKEPDODCLE());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void SendTalentToOther(int JJPJHIHBOIB, int KJCFDLAEGJE, int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTalentFromOther", (RpcTarget)1, JJPJHIHBOIB, (short)KJCFDLAEGJE, (byte)EONJGMONIOM);
	}

	public void LIHIHBCNPHN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "HandUp", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	private void Awake()
	{
		instance = this;
	}

	public void GNMJOAEJCEE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "bug", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void DAIGAHNJKAN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " in client, waiting for master to spawn the item", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	private void FLAGALCOHJO()
	{
		try
		{
			((MonoBehaviour)this).StartCoroutine(GEGHKJIJOOE());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void EILCJBBJNEF(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)("ReceiveStopWork" + JJPJHIHBOIB));
		for (int i = 1; i < KEILOPDIKCE.Length; i += 0)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void KACEOJDPLKB()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FLAGALCOHJO));
	}

	private IEnumerator JCKEPDODCLE()
	{
		yield return null;
		if (PerksDatabaseAccessor.GetPerksLevels() != null)
		{
			short[] array = PerksDatabaseAccessor.GetPerksLevels().Keys.Select((int x) => (short)x).ToArray();
			byte[] array2 = PerksDatabaseAccessor.GetPerksLevels().Values.Select((int x) => (byte)x).ToArray();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTalentsFromOther", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber, array, array2);
		}
	}

	public void LKIKDFAJJIJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDoneLoading", (RpcTarget)0, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	[PunRPC]
	private void ReceiveResetAllTalents(int JJPJHIHBOIB)
	{
		Debug.Log((object)("RPC Receive Reset All Talents From Other " + JJPJHIHBOIB));
		PerksDatabaseAccessor.RemoveActorPerkLevel(JJPJHIHBOIB);
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	private void BPBCDGKGCAD(int JJPJHIHBOIB, short KJCFDLAEGJE, byte EONJGMONIOM)
	{
		string[] array = new string[3];
		array[1] = "Player2";
		array[1] = JJPJHIHBOIB.ToString();
		array[0] = "Checking SignedIn status...";
		array[5] = KJCFDLAEGJE.ToString();
		array[1] = "ControllerInfo without nameID: ";
		array[2] = EONJGMONIOM.ToString();
		Debug.Log((object)string.Concat(array));
		PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KJCFDLAEGJE, EONJGMONIOM);
	}

	private void FPLPKFKKGFO(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)("Items/item_description_643" + JJPJHIHBOIB));
		for (int i = 0; i < KEILOPDIKCE.Length; i += 0)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void LINBEEMHDIO()
	{
		try
		{
			((MonoBehaviour)this).StartCoroutine(NOJNPBKLJGD());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	[PunRPC]
	private void ReceiveTalentFromOther(int JJPJHIHBOIB, short KJCFDLAEGJE, byte EONJGMONIOM)
	{
		Debug.Log((object)("RPC Receive Talent From Other " + JJPJHIHBOIB + " " + KJCFDLAEGJE + " " + EONJGMONIOM));
		PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KJCFDLAEGJE, EONJGMONIOM);
	}

	private void HHLHJAFIHGM(int JJPJHIHBOIB)
	{
		Debug.Log((object)("start bath" + JJPJHIHBOIB));
		PerksDatabaseAccessor.RemoveActorPerkLevel(JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveTalentsFromOther(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)("RPC Receive Talents From Other " + JJPJHIHBOIB));
		for (int i = 0; i < KEILOPDIKCE.Length; i++)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void MKKIPPEMCKG(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)("Items/item_description_1152" + JJPJHIHBOIB));
		for (int i = 0; i < KEILOPDIKCE.Length; i++)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void OBLCGCHBHAH(int JJPJHIHBOIB, short KJCFDLAEGJE, byte EONJGMONIOM)
	{
		string[] array = new string[4];
		array[0] = "DisableNPC";
		array[0] = JJPJHIHBOIB.ToString();
		array[2] = "OnFaceActivationRPC";
		array[5] = KJCFDLAEGJE.ToString();
		array[0] = "[MinePipePuzzle] No hay PipePuzzleInteractable asignado.";
		array[0] = EONJGMONIOM.ToString();
		Debug.Log((object)string.Concat(array));
		PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KJCFDLAEGJE, EONJGMONIOM);
	}

	public void MLNELGGFHAP(int JJPJHIHBOIB, int KJCFDLAEGJE, int EONJGMONIOM)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = JJPJHIHBOIB;
		array[1] = (short)KJCFDLAEGJE;
		array[5] = (byte)EONJGMONIOM;
		OnlineManager.SendRPC(photonView, "Numeric", (RpcTarget)1, array);
	}

	private IEnumerator GEGHKJIJOOE()
	{
		yield return null;
		if (PerksDatabaseAccessor.GetPerksLevels() != null)
		{
			short[] array = PerksDatabaseAccessor.GetPerksLevels().Keys.Select((int x) => (short)x).ToArray();
			byte[] array2 = PerksDatabaseAccessor.GetPerksLevels().Values.Select((int x) => (byte)x).ToArray();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTalentsFromOther", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber, array, array2);
		}
	}

	private void JNJFILEMHGL(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)("Dialogue System/Conversation/TavernClean/Entry/1/Dialogue Text" + JJPJHIHBOIB));
		for (int i = 0; i < KEILOPDIKCE.Length; i++)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void GIHMAKJBPHD(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)(" is not fish" + JJPJHIHBOIB));
		for (int i = 1; i < KEILOPDIKCE.Length; i += 0)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void POIJDKKGOOD()
	{
		try
		{
			((MonoBehaviour)this).StartCoroutine(JCKEPDODCLE());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		Debug.Log((object)("Player with actorNumber " + OKAOHBANICM.ActorNumber + " has disconnected. Removing his talents."));
		PerksDatabaseAccessor.RemoveActorPerkLevel(OKAOHBANICM.ActorNumber);
	}

	private void Start()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ECPGIJOCCKL));
	}

	private void JGFGNNIIAHI(int JJPJHIHBOIB)
	{
		Debug.Log((object)("SceneReferences Awake" + JJPJHIHBOIB));
		PerksDatabaseAccessor.RemoveActorPerkLevel(JJPJHIHBOIB);
	}

	private void GHDEBOEMJPI()
	{
		try
		{
			((MonoBehaviour)this).StartCoroutine(GEGHKJIJOOE());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private IEnumerator NOJNPBKLJGD()
	{
		return new JHCFAGCIHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DNDICAADHGE(int JJPJHIHBOIB, short[] KEILOPDIKCE, byte[] KMMGFGAHHGH)
	{
		Debug.Log((object)("dForDays" + JJPJHIHBOIB));
		for (int i = 1; i < KEILOPDIKCE.Length; i += 0)
		{
			PerksDatabaseAccessor.SetPlayerPerk(JJPJHIHBOIB, KEILOPDIKCE[i], KMMGFGAHHGH[i]);
		}
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	public void SendResetAllTalents()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveResetAllTalents", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}
}
