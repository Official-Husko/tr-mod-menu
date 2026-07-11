using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class OnlineLoadManager : MonoBehaviourPunCallbacks, ISingleton
{
	[CompilerGenerated]
	private sealed class IICBLEIHMIL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int actorNumber;

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
		public IICBLEIHMIL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				for (int j = 0; j < Bar.instance.occupier.Length; j++)
				{
					if ((Object)(object)Bar.instance.occupier[j] != (Object)null)
					{
						Bar.instance.occupier[j].customer.LJOHCJAOADD.SendSetOccupper(j);
					}
				}
				_003C_003E2__current = CommonReferences.waitRealtime1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < Bar.instance.occupier.Length; i++)
				{
					if ((Object)(object)Bar.instance.occupier[i] != (Object)null && Bar.instance.occupier[i].customer.currentRequest != null)
					{
						Bar.instance.occupier[i].customer.LJOHCJAOADD.SendFoodInstanceRequest(Bar.instance.occupier[i].customer.currentRequest as FoodInstance, actorNumber);
						Bar.instance.occupier[i].customer.LJOHCJAOADD.SendNewState(Bar.instance.occupier[i].customer.customerState, actorNumber);
					}
				}
				return false;
			}
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

	[CompilerGenerated]
	private sealed class EBAMCLCKGGI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineLoadManager _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public EBAMCLCKGGI(int _003C_003E1__state)
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
			OnlineLoadManager onlineLoadManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				goto IL_00f3;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = onlineLoadManager.onlineLoadingScripts[_003Ci_003E5__2].LoadMessageCoroutine();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				onlineLoadManager.onlineLoadingScripts[_003Ci_003E5__2].LoadMessageEnd();
				onlineLoadManager.scriptsLoaded++;
				_003Ci_003E5__2++;
				goto IL_00f3;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.waitRealtime2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 5;
				return true;
			case 5:
				{
					_003C_003E1__state = -1;
					WorldGrid.LOMFGJMEGOG(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
					SceneLoaded = true;
					OnlineManager.SendRPC(((MonoBehaviourPun)onlineLoadManager).photonView, "ReceiveDoneLoading", (RpcTarget)2, PhotonNetwork.LocalPlayer.ActorNumber);
					onlineLoadManager.OnFinishedOnlineLoad();
					((MonoBehaviour)TavernZonesManager.GGFJGHHHEJC).StartCoroutine(TavernZonesManager.GGFJGHHHEJC.CalculateComfortOfAllZonesNextFrame());
					Debug.Log((object)"Done Loading Online Scripts");
					return false;
				}
				IL_00f3:
				if (_003Ci_003E5__2 < onlineLoadManager.onlineLoadingScripts.Length)
				{
					Debug.Log((object)(_003Ci_003E5__2 + "- Loading " + ((object)onlineLoadManager.onlineLoadingScripts[_003Ci_003E5__2]).GetType().ToString()));
					onlineLoadManager.onlineLoadingScripts[_003Ci_003E5__2].LoadMessageStart();
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
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

	[CompilerGenerated]
	private sealed class BGOOEFAGDMN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineLoadManager _003C_003E4__this;

		public int actorNumber;

		private WaitForSecondsRealtime _003CwaitForSeconds_003E5__2;

		private int _003Ci_003E5__3;

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
		public BGOOEFAGDMN(int _003C_003E1__state)
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
			OnlineLoadManager onlineLoadManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CwaitForSeconds_003E5__2 = CommonReferences.waitRealtime01;
				goto IL_006b;
			case 1:
				_003C_003E1__state = -1;
				if (Application.isEditor)
				{
					Debug.Log((object)"Master is Loading. Waiting...");
				}
				goto IL_006b;
			case 2:
				_003C_003E1__state = -1;
				if (Application.isEditor)
				{
					Debug.Log((object)"Players are Sleeping. Waiting...");
				}
				goto IL_00a8;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = _003CwaitForSeconds_003E5__2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				{
					_003C_003E1__state = -1;
					_003Ci_003E5__3++;
					break;
				}
				IL_00a8:
				if (CommonReferences.GGFJGHHHEJC.sleeping)
				{
					_003C_003E2__current = _003CwaitForSeconds_003E5__2;
					_003C_003E1__state = 2;
					return true;
				}
				onlineLoadManager.StopTime();
				_003Ci_003E5__3 = 0;
				break;
				IL_006b:
				if (OnlineManager.JBGAMJPMELP || GameManager.isLoading)
				{
					_003C_003E2__current = _003CwaitForSeconds_003E5__2;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00a8;
			}
			if (_003Ci_003E5__3 < onlineLoadManager.onlineLoadingScripts.Length)
			{
				if (Application.isEditor)
				{
					Debug.Log((object)("Send info for " + ((object)onlineLoadManager.onlineLoadingScripts[_003Ci_003E5__3]).GetType().ToString() + " to actorNumber " + actorNumber));
				}
				_003C_003E2__current = ((MonoBehaviour)onlineLoadManager).StartCoroutine(onlineLoadManager.onlineLoadingScripts[_003Ci_003E5__3].SendInfo(actorNumber));
				_003C_003E1__state = 3;
				return true;
			}
			return false;
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

	private const int LDMKIGKAGEO = 997;

	public static OnlineLoadManager instance;

	public Action OnFinishedOnlineLoad = delegate
	{
	};

	public Action OnFinishedOnlineObjectsLoad = delegate
	{
	};

	public Action OnFinishedAnotherClientEntered = delegate
	{
	};

	public static bool SceneLoaded;

	public int scriptsLoaded;

	public OnlineLoadBase[] onlineLoadingScripts;

	public bool _debug = true;

	private List<int> CKKOJDGADOB = new List<int>();

	public static WaitForSecondsRealtime LICLEEOILOO { get; private set; }

	public bool OEBNHGNJEJL
	{
		get
		{
			if (_debug)
			{
				return Application.isEditor;
			}
			return false;
		}
	}

	public void CKKINNDEHDA(int JJPJHIHBOIB)
	{
		LACNHMBHJIH(JJPJHIHBOIB);
		SendAdditionalInformation(JJPJHIHBOIB);
	}

	private IEnumerator GPGKGEKBAKP()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HIKALNICJDA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			BLKOKPJNEAD(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			AHBAEMENBIC(CommonReferences.waitRealtime01);
		}
		SceneLoaded = true;
	}

	private void LGHKLKAEJHB(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.IsThereAnyRequest())
		{
			RoomRequest roomRequest = RoomReceptionDesk.GetCustomerRequesting().roomRequest;
			if (roomRequest != null)
			{
				RoomReceptionDesk.GetCustomerRequesting().LJOHCJAOADD.SendRoomRequest(roomRequest.haggleChance, new int[3] { roomRequest.daysToStay, roomRequest.floorTiles, roomRequest.comfort }, RoomReceptionDesk.instance.ANAFBLDDDGD, JJPJHIHBOIB);
			}
		}
	}

	private void HENGABFLGGP(int JJPJHIHBOIB)
	{
		DPHNKDPBBFH(JJPJHIHBOIB);
	}

	public void DMHDNNCAMPE(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			MPELBKHLAJP(JJPJHIHBOIB);
		}
	}

	private void DOKFPKBLDAP(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.MNFMENHKNNN())
		{
			RoomRequest roomRequest = RoomReceptionDesk.DKHCPFEFMBD().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.GetCustomerRequesting().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[5];
				array[0] = roomRequest.daysToStay;
				array[0] = roomRequest.floorTiles;
				array[1] = roomRequest.comfort;
				onlineCustomer.CDCICILLFIJ(haggleChance, array, RoomReceptionDesk.instance.MNCNOGPLHLO(), JJPJHIHBOIB);
			}
		}
	}

	[SpecialName]
	private static void LKAJNJKNCNO(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	public void AHLHCEFAAMK()
	{
		OnlinePauseUI.BHKLMDJANKN();
		PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "in", (RpcTarget)1);
		}
		OnFinishedAnotherClientEntered();
	}

	public void AJHJOLCELJJ(int JJPJHIHBOIB)
	{
		PNGDNIPFDIH(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(DJEDLKDKNPH(JJPJHIHBOIB));
		for (int i = 0; i < CustomerPool.instance.activeCustomers.Count; i++)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CustomerStateRequest(JJPJHIHBOIB);
		}
		for (int j = 0; j < CustomerPool.instance.pooledCustomers.Count; j += 0)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.KIALFDOKABP().catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.NEFIEJALANL().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateDog(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			OnlineTavernManager.instance.SendLastOrder(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			OnlineTavernManager.instance.HPHGKIDGIOM(DBCDEKIEHMG: false, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.PPLGBHIOMCD(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.LJFEGOPLANF(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	private void PNGDNIPFDIH(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.AOENCPPBIGJ())
		{
			RoomRequest roomRequest = RoomReceptionDesk.CICMGHADMNB().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.GetCustomerRequesting().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[1];
				array[1] = roomRequest.daysToStay;
				array[1] = roomRequest.floorTiles;
				array[0] = roomRequest.comfort;
				onlineCustomer.SendRoomRequest(haggleChance, array, RoomReceptionDesk.instance.MPFPHMDGIHB(), JJPJHIHBOIB);
			}
		}
	}

	private void ODCDPFDOAIE(int JJPJHIHBOIB)
	{
		NAKKFPBIODB(JJPJHIHBOIB);
	}

	private void EBEBNMJNNHP()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, ")", (RpcTarget)0, array);
	}

	public void CJEDNKCJCIE(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			NHIAFPAADAO(JJPJHIHBOIB);
		}
	}

	private IEnumerator LKIINALBIGB(int JJPJHIHBOIB)
	{
		WaitForSecondsRealtime waitForSeconds = CommonReferences.waitRealtime01;
		while (OnlineManager.JBGAMJPMELP || GameManager.isLoading)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Master is Loading. Waiting...");
			}
		}
		while (CommonReferences.GGFJGHHHEJC.sleeping)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Players are Sleeping. Waiting...");
			}
		}
		StopTime();
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Send info for " + ((object)onlineLoadingScripts[i]).GetType().ToString() + " to actorNumber " + JJPJHIHBOIB));
			}
			yield return ((MonoBehaviour)this).StartCoroutine(onlineLoadingScripts[i].SendInfo(JJPJHIHBOIB));
			yield return waitForSeconds;
		}
	}

	public void BEFGMJLOJMJ(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			ODCDPFDOAIE(JJPJHIHBOIB);
		}
	}

	private void INILHDOHDJL(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(EMMEALCEPNM(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	[SpecialName]
	private static void IOPIGOGJBNB(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	public void KLGFMEMPLKK(int JJPJHIHBOIB)
	{
		CICMENOPNBP(JJPJHIHBOIB);
		CCNNDKNOIBL(JJPJHIHBOIB);
	}

	private IEnumerator GLPDKMPBJEE()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BBBCEEIHHLE()
	{
		instance = null;
	}

	public void PCNPKJAIBIH(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			MPELBKHLAJP(JJPJHIHBOIB);
		}
	}

	public void GABINOIBLKC()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			Debug.Log((object)"Disabled");
			SaveData.CJOAJIADJIC(GameManager.NJNFHEPLEHL().LACNCPCDIIL());
			EEKHIALHPAM();
			((MonoBehaviour)this).StartCoroutine(CFNELKJAHAN());
		}
	}

	[PunRPC]
	private void SendGameInfo(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(LKIINALBIGB(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	[SpecialName]
	private static void IPEBGHPKLJA(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	public void ResetSingleton()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			LICLEEOILOO = new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages);
		}
		else
		{
			LICLEEOILOO = CommonReferences.waitRealtime01;
		}
		SceneLoaded = false;
	}

	private void BGFCHEIOKOG()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -88)
		{
			Debug.LogException(new Exception(string.Format("Avatar", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -197)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(StartRequestMap));
	}

	public void AAIMINEOFNN()
	{
		if (OnlineManager.ClientOnline())
		{
			Debug.Log((object)"qualityWater");
			SaveData.CJOAJIADJIC(GameManager.NJNFHEPLEHL().HEJPPEJMPFE);
			ADPBJGBEOGF();
			((MonoBehaviour)this).StartCoroutine(GPGKGEKBAKP());
		}
	}

	public void CCNNDKNOIBL(int JJPJHIHBOIB)
	{
		BCHJNIPDJPF(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(MMIINMLMLIJ(JJPJHIHBOIB));
		for (int i = 0; i < CustomerPool.instance.activeCustomers.Count; i++)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CustomerStateRequest(JJPJHIHBOIB);
		}
		for (int j = 0; j < CustomerPool.instance.pooledCustomers.Count; j++)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.PNHHCHJCDNM().catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.GAGMPCEPONF().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.KMNMNLEPIJE(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			OnlineTavernManager.instance.NHEBMMADBGA(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			OnlineTavernManager.instance.BLLBLAJOCEK(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.GIDLHPBCFIF(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.LJFEGOPLANF(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	public void GEECNOOBOML()
	{
		MainUI.FNJEGCEFEMP(DHJFAGNJKOF: true);
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(0).placeable) && !SelectObject.BNMEANGDMIP(1).placeable.canBeAddedToInventory)
		{
			SelectObject.BNMEANGDMIP(1).PickUpAndResetSelected();
		}
		OnlinePauseUI.CKCIKHOLOCJ(OnlinePauseUI.MessageCode.HostDisconnected);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this, JONJPDAEHFB: false);
		if (OnlineManager.IsMasterClient())
		{
			OnlineObjectsManager.instance.ClearInteractingObjects();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " 2", (RpcTarget)1);
		}
	}

	private void DENJJKLDAME(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(CJABFJKNBDK(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	public void GMENFKKFBAL()
	{
		if (OnlineManager.ClientOnline())
		{
			Debug.Log((object)"NinjaChallengeEvent/Main 3");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.EBOFEBOBAEB());
			OOEHGBDMGGB();
			((MonoBehaviour)this).StartCoroutine(GLPDKMPBJEE());
		}
	}

	private IEnumerator DJEDLKDKNPH(int JJPJHIHBOIB)
	{
		return new IICBLEIHMIL(1)
		{
			actorNumber = JJPJHIHBOIB
		};
	}

	private void MINEICLACBI(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			ContinuePlaying();
		}
	}

	public void DLJIADIAKNN()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			Debug.Log((object)"Food");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.EBOFEBOBAEB());
			OGDBAGEFECE();
			((MonoBehaviour)this).StartCoroutine(NFPMDFDHNPP());
		}
	}

	public void PGBGGFLMAGK()
	{
		OnlinePauseUI.KCKDAOOKMDJ();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UISelectGamepad", (RpcTarget)0);
		}
		OnFinishedAnotherClientEntered();
	}

	private IEnumerator MMIINMLMLIJ(int JJPJHIHBOIB)
	{
		for (int i = 0; i < Bar.instance.occupier.Length; i++)
		{
			if ((Object)(object)Bar.instance.occupier[i] != (Object)null)
			{
				Bar.instance.occupier[i].customer.LJOHCJAOADD.SendSetOccupper(i);
			}
		}
		yield return CommonReferences.waitRealtime1;
		for (int j = 0; j < Bar.instance.occupier.Length; j++)
		{
			if ((Object)(object)Bar.instance.occupier[j] != (Object)null && Bar.instance.occupier[j].customer.currentRequest != null)
			{
				Bar.instance.occupier[j].customer.LJOHCJAOADD.SendFoodInstanceRequest(Bar.instance.occupier[j].customer.currentRequest as FoodInstance, JJPJHIHBOIB);
				Bar.instance.occupier[j].customer.LJOHCJAOADD.SendNewState(Bar.instance.occupier[j].customer.customerState, JJPJHIHBOIB);
			}
		}
	}

	public void EMFCKKBFMOA()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			LKAJNJKNCNO(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			KDKFCPAEMEI(CommonReferences.waitRealtime01);
		}
		SceneLoaded = true;
	}

	public void SendAdditionalInformation(int JJPJHIHBOIB)
	{
		LGHKLKAEJHB(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(MMIINMLMLIJ(JJPJHIHBOIB));
		for (int i = 0; i < CustomerPool.instance.activeCustomers.Count; i++)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CustomerStateRequest(JJPJHIHBOIB);
		}
		for (int j = 0; j < CustomerPool.instance.pooledCustomers.Count; j++)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.GGFJGHHHEJC.catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateDog(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			OnlineTavernManager.instance.SendLastOrder(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			OnlineTavernManager.instance.SendOpenCloseTavern(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.GetEnabledObstacles(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.SendTavernObstacles(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	public void GEHKCBAMPFO(int JJPJHIHBOIB)
	{
		PNGDNIPFDIH(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(DOEFLENDCDL(JJPJHIHBOIB));
		for (int i = 0; i < CustomerPool.instance.activeCustomers.Count; i++)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CNAHFOIGHGE(JJPJHIHBOIB);
		}
		for (int j = 0; j < CustomerPool.instance.pooledCustomers.Count; j++)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.PNHHCHJCDNM().catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.CHPEMJMLDCN().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.KMNMNLEPIJE(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			OnlineTavernManager.instance.NHEBMMADBGA(DBCDEKIEHMG: false, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			OnlineTavernManager.instance.BLLBLAJOCEK(DBCDEKIEHMG: false, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.HFIDBEHPHKF(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.JBOBABPKOLO(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	private void OCLFLCIAAKG()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "SwishEffect", (RpcTarget)3, array);
	}

	private void FPDPAJHNGHK()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -25)
		{
			Debug.LogException(new Exception(string.Format("<br/>Processor Count: ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -106)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GMENFKKFBAL));
	}

	public void StartRequestMap()
	{
		if (OnlineManager.ClientOnline())
		{
			Debug.Log((object)"StartRequestMap");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.HEJPPEJMPFE);
			OOEHGBDMGGB();
			((MonoBehaviour)this).StartCoroutine(NFPMDFDHNPP());
		}
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
		ADGPJJJIIME();
	}

	private void GEBNGMOJEHB(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(ILLOKBKCGBI(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	[SpecialName]
	private static void JJGOFNHDEMA(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public bool PAPOINPJJBL()
	{
		if (_debug)
		{
			return Application.isEditor;
		}
		return false;
	}

	public void GBMDNPDDIPP()
	{
		if (OnlineManager.ClientOnline())
		{
			Debug.Log((object)"Items/item_description_1110");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.EBOFEBOBAEB());
			PFMABPKDJOI();
			((MonoBehaviour)this).StartCoroutine(GLPDKMPBJEE());
		}
	}

	private void EBBMGENJGAJ(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			ContinuePlaying();
		}
	}

	private void EGACIHOKJLH()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 117)
		{
			Debug.LogException(new Exception(string.Format("Held Item null in ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -49)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(DLJIADIAKNN));
	}

	private void MPELBKHLAJP(int JJPJHIHBOIB)
	{
		MINEICLACBI(JJPJHIHBOIB);
	}

	[SpecialName]
	public static WaitForSecondsRealtime KINNMHLBJAB()
	{
		return _003CBBNBAAAFNGD_003Ek__BackingField;
	}

	private void BGENEAOILOF()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -6)
		{
			Debug.LogException(new Exception(string.Format("Enter", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 140)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KLBONBKAAPO));
	}

	private IEnumerator CFNELKJAHAN()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LACNHMBHJIH(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			MGOMCJKINHJ();
		}
	}

	private void NKDCCDDOHJL(int JJPJHIHBOIB)
	{
		FEBFJLALFMK(JJPJHIHBOIB);
	}

	private IEnumerator DBEHCKMMHEO()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PBANGCONLLP(int JJPJHIHBOIB)
	{
		MINEICLACBI(JJPJHIHBOIB);
	}

	[SpecialName]
	private static void BPHJHKIHHEB(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	private void NHIAFPAADAO(int JJPJHIHBOIB)
	{
		IBJOLAGLJEP(JJPJHIHBOIB);
	}

	[SpecialName]
	public bool JLDPLJGPKEF()
	{
		if (_debug)
		{
			return Application.isEditor;
		}
		return true;
	}

	private void IJKFAMDBGCI(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.AOENCPPBIGJ())
		{
			RoomRequest roomRequest = RoomReceptionDesk.CICMGHADMNB().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.CICMGHADMNB().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[8];
				array[1] = roomRequest.daysToStay;
				array[0] = roomRequest.floorTiles;
				array[7] = roomRequest.comfort;
				onlineCustomer.SendRoomRequest(haggleChance, array, RoomReceptionDesk.instance.MNCNOGPLHLO(), JJPJHIHBOIB);
			}
		}
	}

	[SpecialName]
	private static void KDKFCPAEMEI(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	private void FDFKKDAHAHH(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.MNFMENHKNNN())
		{
			RoomRequest roomRequest = RoomReceptionDesk.GetCustomerRequesting().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.CICMGHADMNB().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[1];
				array[0] = roomRequest.daysToStay;
				array[0] = roomRequest.floorTiles;
				array[5] = roomRequest.comfort;
				onlineCustomer.SendRoomRequest(haggleChance, array, RoomReceptionDesk.instance.MPFPHMDGIHB(), JJPJHIHBOIB);
			}
		}
	}

	public void AJDHKDPCOPD()
	{
		if (OnlineManager.ClientOnline())
		{
			Debug.Log((object)"BarkActor");
			SaveData.CJOAJIADJIC(GameManager.NJNFHEPLEHL().EOJJHMHBJAG());
			OCLFLCIAAKG();
			((MonoBehaviour)this).StartCoroutine(GLPDKMPBJEE());
		}
	}

	private void OOEHGBDMGGB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SendGameInfo", (RpcTarget)2, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void EEIJCPNNALK()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			Debug.Log((object)"No se encontró una entrada con ID {0} en la conversación '{1}'.");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.LACNCPCDIIL());
			PFMABPKDJOI();
			((MonoBehaviour)this).StartCoroutine(NGACLKLBJHM());
		}
	}

	public void KONNDMPJKCI(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			MICLFJCLJLI(JJPJHIHBOIB);
		}
	}

	private IEnumerator MNMGNOFIDLA()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	public bool IKGBELIFJPE()
	{
		if (_debug)
		{
			return Application.isEditor;
		}
		return false;
	}

	public void MCFDDKHLDHK(int JJPJHIHBOIB)
	{
		DOKFPKBLDAP(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(DOEFLENDCDL(JJPJHIHBOIB));
		for (int i = 0; i < CustomerPool.instance.activeCustomers.Count; i += 0)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CustomerStateRequest(JJPJHIHBOIB);
		}
		for (int j = 1; j < CustomerPool.instance.pooledCustomers.Count; j += 0)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.LPFNKEOJJKE().catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.LPFNKEOJJKE().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.KMNMNLEPIJE(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			OnlineTavernManager.instance.SendLastOrder(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			OnlineTavernManager.instance.HBLENALBHFL(DBCDEKIEHMG: false, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.ECCGGCNGDBB(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.LJFEGOPLANF(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	[SpecialName]
	public static WaitForSecondsRealtime DPHEJLLHIPK()
	{
		return _003CBBNBAAAFNGD_003Ek__BackingField;
	}

	public void FCAEIDDPBBB(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			PBANGCONLLP(JJPJHIHBOIB);
		}
	}

	public void CIFAAGGLNNJ()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			IPEBGHPKLJA(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			IOPIGOGJBNB(CommonReferences.waitRealtime01);
		}
		SceneLoaded = true;
	}

	private void DOHLOJOIHFO()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 186)
		{
			Debug.LogException(new Exception(string.Format("ReceiveEnable", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -162)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(AAIMINEOFNN));
	}

	public void CGDPNKMACKK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			BLKOKPJNEAD(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			IPEBGHPKLJA(CommonReferences.waitRealtime01);
		}
		SceneLoaded = false;
	}

	private void PFMABPKDJOI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ChangeAnim", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void BIGJEJNCDOG()
	{
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(0).placeable) && !SelectObject.GetPlayer(1).placeable.canBeAddedToInventory)
		{
			SelectObject.GetPlayer(1).HDLLFOALJEO();
		}
		OnlinePauseUI.ShowMessage(OnlinePauseUI.MessageCode.HostDisconnected);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineObjectsManager.instance.ClearInteractingObjects();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Suitabilities: ", (RpcTarget)0);
		}
	}

	private void HAHHDCMKHPN()
	{
		instance = null;
	}

	private IEnumerator DOEFLENDCDL(int JJPJHIHBOIB)
	{
		return new IICBLEIHMIL(1)
		{
			actorNumber = JJPJHIHBOIB
		};
	}

	public void JCNKFFIMMBK(int JJPJHIHBOIB)
	{
		EBBMGENJGAJ(JJPJHIHBOIB);
		IGHENCKKJCP(JJPJHIHBOIB);
	}

	private IEnumerator NGACLKLBJHM()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IDMABPEIEBO(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			NKDCCDDOHJL(JJPJHIHBOIB);
		}
	}

	private void ADPBJGBEOGF()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "UIPreviousCategory", (RpcTarget)7, array);
	}

	private void FJCMLPLONDJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " is drinking sake. numDrinks: ", (RpcTarget)8, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void DJKPCMABDHL()
	{
		MainUI.CloseAllUIWindows();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(0).placeable) && !SelectObject.GetPlayer(1).placeable.canBeAddedToInventory)
		{
			SelectObject.BNMEANGDMIP(0).PickUpAndResetSelected();
		}
		OnlinePauseUI.PCHNEHJJGON(OnlinePauseUI.MessageCode.HostDisconnected);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineObjectsManager.instance.ClearInteractingObjects();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SendRPC: '", (RpcTarget)0);
		}
	}

	private void CKEEHJMPCEN(int JJPJHIHBOIB)
	{
		NAKKFPBIODB(JJPJHIHBOIB);
	}

	private void AEPBFPCHGPP()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -133)
		{
			Debug.LogException(new Exception(string.Format("Error setting tavern name on CharacterCreatorUI: ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 97)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GMENFKKFBAL));
	}

	public void GGCJOCJPNIA()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			Debug.Log((object)"LearnMettle");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.EOJJHMHBJAG());
			EBEBNMJNNHP();
			((MonoBehaviour)this).StartCoroutine(BEADGBICJIP());
		}
	}

	private IEnumerator JKHPJGJHHEN(int JJPJHIHBOIB)
	{
		return new IICBLEIHMIL(1)
		{
			actorNumber = JJPJHIHBOIB
		};
	}

	public void MGOMCJKINHJ()
	{
		OnlinePauseUI.BHKLMDJANKN();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetDrinkColorMaster", (RpcTarget)0);
		}
		OnFinishedAnotherClientEntered();
	}

	[SpecialName]
	public static WaitForSecondsRealtime GAHBKANNKGI()
	{
		return _003CBBNBAAAFNGD_003Ek__BackingField;
	}

	public void BLIFGOOJAME(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			HENGABFLGGP(JJPJHIHBOIB);
		}
	}

	public void KIPJFIEHCKI()
	{
		onlineLoadingScripts = ((Component)this).GetComponents<OnlineLoadBase>();
	}

	private void HEHNBONKMGJ()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -117)
		{
			Debug.LogException(new Exception(string.Format("Trends of week ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -105)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GBMDNPDDIPP));
	}

	private void Awake()
	{
		instance = this;
		ResetSingleton();
	}

	private void OIAFJLDHPLA(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			CFGPGIEKCPC();
		}
	}

	[SpecialName]
	public bool KDJIJGOBIEG()
	{
		if (_debug)
		{
			return Application.isEditor;
		}
		return true;
	}

	public void CLEEOEHADPO(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			CKEEHJMPCEN(JJPJHIHBOIB);
		}
	}

	public void ILBDLMMBBHH()
	{
		OnlinePauseUI.EDCJILFOCFF();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " joined", (RpcTarget)1);
		}
		OnFinishedAnotherClientEntered();
	}

	public void NKJCBFGAAFD(int JJPJHIHBOIB)
	{
		JJAAPLKKJBB(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(DOEFLENDCDL(JJPJHIHBOIB));
		for (int i = 1; i < CustomerPool.instance.activeCustomers.Count; i++)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CNAHFOIGHGE(JJPJHIHBOIB);
		}
		for (int j = 1; j < CustomerPool.instance.pooledCustomers.Count; j += 0)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.NEFIEJALANL().catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.GAGMPCEPONF().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateDog(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			OnlineTavernManager.instance.HDDALELCCCA(DBCDEKIEHMG: false, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			OnlineTavernManager.instance.SendOpenCloseTavern(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.PHMFJPAIFGE(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.SendTavernObstacles(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	public void HBBNLAJJGEA(int JJPJHIHBOIB)
	{
		OIAFJLDHPLA(JJPJHIHBOIB);
		CCNNDKNOIBL(JJPJHIHBOIB);
	}

	public void FLPOFKLCCEM()
	{
		onlineLoadingScripts = ((Component)this).GetComponents<OnlineLoadBase>();
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 997)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {997} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(StartRequestMap));
	}

	public void FillListLoadComponents()
	{
		onlineLoadingScripts = ((Component)this).GetComponents<OnlineLoadBase>();
	}

	private void GHDBHNMOBMN()
	{
		instance = null;
	}

	private void OnDestroy()
	{
		instance = null;
	}

	private void IBJOLAGLJEP(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			JCIIKEFNNCD();
		}
	}

	private IEnumerator LJBGKLGNFED()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JJCFIJAKDCH()
	{
		onlineLoadingScripts = ((Component)this).GetComponents<OnlineLoadBase>();
	}

	private void LBBKLPNGBFN(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			MGOMCJKINHJ();
		}
	}

	private void CICMENOPNBP(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			PGBGGFLMAGK();
		}
	}

	public void CBPPDJIAODK()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			BPHJHKIHHEB(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			BPHJHKIHHEB(CommonReferences.waitRealtime01);
		}
		SceneLoaded = false;
	}

	private IEnumerator EMMEALCEPNM(int JJPJHIHBOIB)
	{
		return new BGOOEFAGDMN(1)
		{
			_003C_003E4__this = this,
			actorNumber = JJPJHIHBOIB
		};
	}

	private void EEKHIALHPAM()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
	}

	private IEnumerator ILLOKBKCGBI(int JJPJHIHBOIB)
	{
		WaitForSecondsRealtime waitForSeconds = CommonReferences.waitRealtime01;
		while (OnlineManager.JBGAMJPMELP || GameManager.isLoading)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Master is Loading. Waiting...");
			}
		}
		while (CommonReferences.GGFJGHHHEJC.sleeping)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Players are Sleeping. Waiting...");
			}
		}
		StopTime();
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Send info for " + ((object)onlineLoadingScripts[i]).GetType().ToString() + " to actorNumber " + JJPJHIHBOIB));
			}
			yield return ((MonoBehaviour)this).StartCoroutine(onlineLoadingScripts[i].SendInfo(JJPJHIHBOIB));
			yield return waitForSeconds;
		}
	}

	private IEnumerator NFPMDFDHNPP()
	{
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			Debug.Log((object)(i + "- Loading " + ((object)onlineLoadingScripts[i]).GetType().ToString()));
			onlineLoadingScripts[i].LoadMessageStart();
			yield return null;
			yield return onlineLoadingScripts[i].LoadMessageCoroutine();
			onlineLoadingScripts[i].LoadMessageEnd();
			scriptsLoaded++;
		}
		yield return null;
		yield return CommonReferences.waitRealtime2;
		yield return null;
		WorldGrid.LOMFGJMEGOG(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
		SceneLoaded = true;
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDoneLoading", (RpcTarget)2, PhotonNetwork.LocalPlayer.ActorNumber);
		OnFinishedOnlineLoad();
		((MonoBehaviour)TavernZonesManager.GGFJGHHHEJC).StartCoroutine(TavernZonesManager.GGFJGHHHEJC.CalculateComfortOfAllZonesNextFrame());
		Debug.Log((object)"Done Loading Online Scripts");
	}

	private void DPHNKDPBBFH(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			JHLEEIGBOMD();
		}
	}

	public void ADGPJJJIIME()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			KDKFCPAEMEI(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			PBIEIGKFOBA(CommonReferences.waitRealtime01);
		}
		SceneLoaded = true;
	}

	public void KFDAGOHEILH()
	{
		MainUI.FNJEGCEFEMP();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(0).placeable) && !SelectObject.GetPlayer(1).placeable.canBeAddedToInventory)
		{
			SelectObject.BNMEANGDMIP(0).PickUpAndResetSelected();
		}
		OnlinePauseUI.GAIOFBJNBEP(OnlinePauseUI.MessageCode.HostDisconnected);
		PlayerInputs.DLKKNGHEMPB((MonoBehaviour)(object)this, JONJPDAEHFB: false);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineObjectsManager.instance.ClearInteractingObjects();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Spawn", (RpcTarget)0);
		}
	}

	[SpecialName]
	private static void BLKOKPJNEAD(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	public void PHOGIJJCJJG()
	{
		OnlinePauseUI.HideMessage();
		PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ": ", (RpcTarget)0);
		}
		OnFinishedAnotherClientEntered();
	}

	[SpecialName]
	public static WaitForSecondsRealtime CFDMMJPPHPF()
	{
		return _003CBBNBAAAFNGD_003Ek__BackingField;
	}

	public void NPEJGDMLBBK(int JJPJHIHBOIB)
	{
		LGHKLKAEJHB(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(MMIINMLMLIJ(JJPJHIHBOIB));
		for (int i = 0; i < CustomerPool.instance.activeCustomers.Count; i += 0)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CNAHFOIGHGE(JJPJHIHBOIB);
		}
		for (int j = 0; j < CustomerPool.instance.pooledCustomers.Count; j += 0)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: false, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.CMIHGBHPLFP().catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.CMIHGBHPLFP().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateDog(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			OnlineTavernManager.instance.BMHKKDCHGPP(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			OnlineTavernManager.instance.HPHGKIDGIOM(DBCDEKIEHMG: false, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.GIDLHPBCFIF(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.LJFEGOPLANF(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	public void CheckIfPlayerIsLoading(int JJPJHIHBOIB)
	{
		if (CKKOJDGADOB.Contains(JJPJHIHBOIB))
		{
			MPELBKHLAJP(JJPJHIHBOIB);
		}
	}

	public void CFGPGIEKCPC()
	{
		OnlinePauseUI.FDNKAMPGPFO();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text", (RpcTarget)0);
		}
		OnFinishedAnotherClientEntered();
	}

	private void DMBDMDJHONM(int JJPJHIHBOIB)
	{
		DPHNKDPBBFH(JJPJHIHBOIB);
	}

	public void IGHENCKKJCP(int JJPJHIHBOIB)
	{
		LGHKLKAEJHB(JJPJHIHBOIB);
		((MonoBehaviour)this).StartCoroutine(DJEDLKDKNPH(JJPJHIHBOIB));
		for (int i = 1; i < CustomerPool.instance.activeCustomers.Count; i += 0)
		{
			CustomerPool.instance.activeCustomers[i].customer.LJOHCJAOADD.CNAHFOIGHGE(JJPJHIHBOIB);
		}
		for (int j = 1; j < CustomerPool.instance.pooledCustomers.Count; j++)
		{
			CustomerPool.instance.pooledCustomers[j].customer.LJOHCJAOADD.SendActiveOrDisableCustomer(DMBFKFLDDLH: true, JJPJHIHBOIB);
		}
		if ((Object)(object)SpawnCat.GGFJGHHHEJC.catNPC != (Object)null)
		{
			OnlineObjectsManager.instance.SendInstantiateCat(SpawnCat.CHPEMJMLDCN().catNPC.onlineCat, JJPJHIHBOIB);
		}
		if ((Object)(object)DogNPC.instance != (Object)null)
		{
			OnlineObjectsManager.instance.KMNMNLEPIJE(DogNPC.instance.onlineDog, JJPJHIHBOIB);
		}
		if (TavernManager.GGFJGHHHEJC.ADIBBNEJJKG())
		{
			OnlineTavernManager.instance.NHEBMMADBGA(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		else if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			OnlineTavernManager.instance.INMLPGNIMEK(DBCDEKIEHMG: true, JJPJHIHBOIB);
		}
		if ((Object)(object)TavernObstacleManager.instance != (Object)null)
		{
			TavernObstacleManager.instance.ECCGGCNGDBB(out var OLGFCKMKBKF);
			OnlineObjectsManager.instance.LJFEGOPLANF(OLGFCKMKBKF, JJPJHIHBOIB);
		}
	}

	[SpecialName]
	private static void OALOCMHKFJB(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	private void FEBFJLALFMK(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			JHLEEIGBOMD();
		}
	}

	[PunRPC]
	public void StopTime()
	{
		MainUI.CloseAllUIWindows();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(1).placeable) && !SelectObject.GetPlayer(1).placeable.canBeAddedToInventory)
		{
			SelectObject.GetPlayer(1).PickUpAndResetSelected();
		}
		OnlinePauseUI.ShowMessage(OnlinePauseUI.MessageCode.GuestConnecting);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineObjectsManager.instance.ClearInteractingObjects();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "StopTime", (RpcTarget)1);
		}
	}

	private void OGDBAGEFECE()
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "talents", (RpcTarget)8, array);
	}

	private IEnumerator BDFAGMAPKAM()
	{
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			Debug.Log((object)(i + "- Loading " + ((object)onlineLoadingScripts[i]).GetType().ToString()));
			onlineLoadingScripts[i].LoadMessageStart();
			yield return null;
			yield return onlineLoadingScripts[i].LoadMessageCoroutine();
			onlineLoadingScripts[i].LoadMessageEnd();
			scriptsLoaded++;
		}
		yield return null;
		yield return CommonReferences.waitRealtime2;
		yield return null;
		WorldGrid.LOMFGJMEGOG(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
		SceneLoaded = true;
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDoneLoading", (RpcTarget)2, PhotonNetwork.LocalPlayer.ActorNumber);
		OnFinishedOnlineLoad();
		((MonoBehaviour)TavernZonesManager.GGFJGHHHEJC).StartCoroutine(TavernZonesManager.GGFJGHHHEJC.CalculateComfortOfAllZonesNextFrame());
		Debug.Log((object)"Done Loading Online Scripts");
	}

	private void NAKKFPBIODB(int JJPJHIHBOIB)
	{
		CKKOJDGADOB.Remove(JJPJHIHBOIB);
		if (CKKOJDGADOB.Count == 0)
		{
			JCIIKEFNNCD();
		}
	}

	[PunRPC]
	public void ContinuePlaying()
	{
		OnlinePauseUI.HideMessage();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ContinuePlaying", (RpcTarget)1);
		}
		OnFinishedAnotherClientEntered();
	}

	private void OAGFHAGJLLG(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.MNFMENHKNNN())
		{
			RoomRequest roomRequest = RoomReceptionDesk.BALJJDNIKFF().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.BALJJDNIKFF().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[3];
				array[1] = roomRequest.daysToStay;
				array[1] = roomRequest.floorTiles;
				array[6] = roomRequest.comfort;
				onlineCustomer.CDCICILLFIJ(haggleChance, array, RoomReceptionDesk.instance.MPFPHMDGIHB(), JJPJHIHBOIB);
			}
		}
	}

	private void EOGHJNGJFID()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 22)
		{
			Debug.LogException(new Exception(string.Format("FloorDirt", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 131)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(AAIMINEOFNN));
	}

	private IEnumerator HDHDBOCIAFL(int JJPJHIHBOIB)
	{
		WaitForSecondsRealtime waitForSeconds = CommonReferences.waitRealtime01;
		while (OnlineManager.JBGAMJPMELP || GameManager.isLoading)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Master is Loading. Waiting...");
			}
		}
		while (CommonReferences.GGFJGHHHEJC.sleeping)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Players are Sleeping. Waiting...");
			}
		}
		StopTime();
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Send info for " + ((object)onlineLoadingScripts[i]).GetType().ToString() + " to actorNumber " + JJPJHIHBOIB));
			}
			yield return ((MonoBehaviour)this).StartCoroutine(onlineLoadingScripts[i].SendInfo(JJPJHIHBOIB));
			yield return waitForSeconds;
		}
	}

	private IEnumerator AFNBEIBHEOF(int JJPJHIHBOIB)
	{
		for (int i = 0; i < Bar.instance.occupier.Length; i++)
		{
			if ((Object)(object)Bar.instance.occupier[i] != (Object)null)
			{
				Bar.instance.occupier[i].customer.LJOHCJAOADD.SendSetOccupper(i);
			}
		}
		yield return CommonReferences.waitRealtime1;
		for (int j = 0; j < Bar.instance.occupier.Length; j++)
		{
			if ((Object)(object)Bar.instance.occupier[j] != (Object)null && Bar.instance.occupier[j].customer.currentRequest != null)
			{
				Bar.instance.occupier[j].customer.LJOHCJAOADD.SendFoodInstanceRequest(Bar.instance.occupier[j].customer.currentRequest as FoodInstance, JJPJHIHBOIB);
				Bar.instance.occupier[j].customer.LJOHCJAOADD.SendNewState(Bar.instance.occupier[j].customer.customerState, JJPJHIHBOIB);
			}
		}
	}

	private void BMKGHOJDDNB()
	{
		instance = this;
		ADGPJJJIIME();
	}

	[SpecialName]
	private static void AHBAEMENBIC(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	[PunRPC]
	public void ReceiveDoneLoading(int JJPJHIHBOIB)
	{
		MINEICLACBI(JJPJHIHBOIB);
		SendAdditionalInformation(JJPJHIHBOIB);
	}

	private void MICLFJCLJLI(int JJPJHIHBOIB)
	{
		LBBKLPNGBFN(JJPJHIHBOIB);
	}

	public void JHLEEIGBOMD()
	{
		OnlinePauseUI.BHKLMDJANKN();
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Guard", (RpcTarget)1);
		}
		OnFinishedAnotherClientEntered();
	}

	private IEnumerator BEADGBICJIP()
	{
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			Debug.Log((object)(i + "- Loading " + ((object)onlineLoadingScripts[i]).GetType().ToString()));
			onlineLoadingScripts[i].LoadMessageStart();
			yield return null;
			yield return onlineLoadingScripts[i].LoadMessageCoroutine();
			onlineLoadingScripts[i].LoadMessageEnd();
			scriptsLoaded++;
		}
		yield return null;
		yield return CommonReferences.waitRealtime2;
		yield return null;
		WorldGrid.LOMFGJMEGOG(Utils.JGEPCPFJANP(Location.Tavern), Utils.JGEPCPFJANP(Location.Tavern).GetAllPositionsToCalculate());
		SceneLoaded = true;
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDoneLoading", (RpcTarget)2, PhotonNetwork.LocalPlayer.ActorNumber);
		OnFinishedOnlineLoad();
		((MonoBehaviour)TavernZonesManager.GGFJGHHHEJC).StartCoroutine(TavernZonesManager.GGFJGHHHEJC.CalculateComfortOfAllZonesNextFrame());
		Debug.Log((object)"Done Loading Online Scripts");
	}

	public void KEKPCMJILME()
	{
		MainUI.FNJEGCEFEMP();
		if (Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(1).placeable) && !SelectObject.GetPlayer(1).placeable.canBeAddedToInventory)
		{
			SelectObject.GetPlayer(0).PickUpAndResetSelected();
		}
		OnlinePauseUI.PCHNEHJJGON(OnlinePauseUI.MessageCode.GuestConnecting);
		PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineObjectsManager.instance.ClearInteractingObjects();
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "cameraZoom2", (RpcTarget)0);
		}
	}

	private IEnumerator MILMNKHFBAM()
	{
		return new EBAMCLCKGGI(1)
		{
			_003C_003E4__this = this
		};
	}

	[SpecialName]
	private static void GHDFIIPAFGH(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	private void MMELFAEIMDN(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(EMMEALCEPNM(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	private void ONGCLPICPNM(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.FGIIJJLOKPA())
		{
			RoomRequest roomRequest = RoomReceptionDesk.GetCustomerRequesting().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.DKHCPFEFMBD().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[3];
				array[0] = roomRequest.daysToStay;
				array[0] = roomRequest.floorTiles;
				array[2] = roomRequest.comfort;
				onlineCustomer.CDCICILLFIJ(haggleChance, array, RoomReceptionDesk.instance.HLPDKNGONBI(), JJPJHIHBOIB);
			}
		}
	}

	public void JCIIKEFNNCD()
	{
		OnlinePauseUI.EDCJILFOCFF();
		PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)this);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[ProceduralMine] Exit piece: {0} - stairsTravelZone: {1}", (RpcTarget)1);
		}
		OnFinishedAnotherClientEntered();
	}

	private IEnumerator CJABFJKNBDK(int JJPJHIHBOIB)
	{
		WaitForSecondsRealtime waitForSeconds = CommonReferences.waitRealtime01;
		while (OnlineManager.JBGAMJPMELP || GameManager.isLoading)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Master is Loading. Waiting...");
			}
		}
		while (CommonReferences.GGFJGHHHEJC.sleeping)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Players are Sleeping. Waiting...");
			}
		}
		StopTime();
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Send info for " + ((object)onlineLoadingScripts[i]).GetType().ToString() + " to actorNumber " + JJPJHIHBOIB));
			}
			yield return ((MonoBehaviour)this).StartCoroutine(onlineLoadingScripts[i].SendInfo(JJPJHIHBOIB));
			yield return waitForSeconds;
		}
	}

	[SpecialName]
	private static void HOODFMLDDIJ(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	private void GGMDKIFGDGA(int JJPJHIHBOIB)
	{
		EBBMGENJGAJ(JJPJHIHBOIB);
	}

	private void JDHHJKBOJML()
	{
		instance = this;
		CBPPDJIAODK();
	}

	public void JDEPCMAEFKG(int JJPJHIHBOIB)
	{
		EBBMGENJGAJ(JJPJHIHBOIB);
		NKJCBFGAAFD(JJPJHIHBOIB);
	}

	public void KLBONBKAAPO()
	{
		if (OnlineManager.ClientOnline())
		{
			Debug.Log((object)"Example Method With Custom ID");
			SaveData.CJOAJIADJIC(GameManager.GGFJGHHHEJC.HEJPPEJMPFE);
			OGDBAGEFECE();
			((MonoBehaviour)this).StartCoroutine(MNMGNOFIDLA());
		}
	}

	[SpecialName]
	private static void PBIEIGKFOBA(WaitForSecondsRealtime AODONKKHPBP)
	{
		_003CBBNBAAAFNGD_003Ek__BackingField = AODONKKHPBP;
	}

	private void BJACDMIOLLF(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(HDHDBOCIAFL(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	private void JJAAPLKKJBB(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.FGIIJJLOKPA())
		{
			RoomRequest roomRequest = RoomReceptionDesk.GetCustomerRequesting().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.GetCustomerRequesting().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[7];
				array[0] = roomRequest.daysToStay;
				array[1] = roomRequest.floorTiles;
				array[1] = roomRequest.comfort;
				onlineCustomer.SendRoomRequest(haggleChance, array, RoomReceptionDesk.instance.MPFPHMDGIHB(), JJPJHIHBOIB);
			}
		}
	}

	public void ENNDOHKKMHB()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (Object.op_Implicit((Object)(object)OnlineManager.LMALNDLJILM))
		{
			LKAJNJKNCNO(new WaitForSecondsRealtime(OnlineManager.LMALNDLJILM.waitTimeBetweenMessages));
		}
		else
		{
			JJGOFNHDEMA(CommonReferences.waitRealtime01);
		}
		SceneLoaded = true;
	}

	private IEnumerator NOCPHMFJHFP(int JJPJHIHBOIB)
	{
		WaitForSecondsRealtime waitForSeconds = CommonReferences.waitRealtime01;
		while (OnlineManager.JBGAMJPMELP || GameManager.isLoading)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Master is Loading. Waiting...");
			}
		}
		while (CommonReferences.GGFJGHHHEJC.sleeping)
		{
			yield return waitForSeconds;
			if (Application.isEditor)
			{
				Debug.Log((object)"Players are Sleeping. Waiting...");
			}
		}
		StopTime();
		for (int i = 0; i < onlineLoadingScripts.Length; i++)
		{
			if (Application.isEditor)
			{
				Debug.Log((object)("Send info for " + ((object)onlineLoadingScripts[i]).GetType().ToString() + " to actorNumber " + JJPJHIHBOIB));
			}
			yield return ((MonoBehaviour)this).StartCoroutine(onlineLoadingScripts[i].SendInfo(JJPJHIHBOIB));
			yield return waitForSeconds;
		}
	}

	private void KONODJFPACH(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(LKIINALBIGB(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	private void DMDOLOLIFKK(int JJPJHIHBOIB)
	{
		((MonoBehaviour)this).StartCoroutine(EMMEALCEPNM(JJPJHIHBOIB));
		CKKOJDGADOB.Add(JJPJHIHBOIB);
	}

	[SpecialName]
	public bool DPAEPNBJAMP()
	{
		if (_debug)
		{
			return Application.isEditor;
		}
		return false;
	}

	private void BCHJNIPDJPF(int JJPJHIHBOIB)
	{
		if ((Object)(object)RoomReceptionDesk.instance != (Object)null && RoomReceptionDesk.FGIIJJLOKPA())
		{
			RoomRequest roomRequest = RoomReceptionDesk.BALJJDNIKFF().roomRequest;
			if (roomRequest != null)
			{
				OnlineCustomer onlineCustomer = RoomReceptionDesk.DKHCPFEFMBD().LJOHCJAOADD;
				float haggleChance = roomRequest.haggleChance;
				int[] array = new int[3];
				array[0] = roomRequest.daysToStay;
				array[1] = roomRequest.floorTiles;
				array[8] = roomRequest.comfort;
				onlineCustomer.SendRoomRequest(haggleChance, array, RoomReceptionDesk.instance.MPFPHMDGIHB(), JJPJHIHBOIB);
			}
		}
	}
}
