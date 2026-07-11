using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnlineObjectsManager : MonoBehaviourPunCallbacks
{
	[Serializable]
	private class OnlinePlaceableEntry
	{
		public int id;

		public OnlineObject onlinePlaceable;

		public OnlinePlaceableEntry(int PNFPECBGNMB, OnlineObject LHOJNAHEGIC)
		{
			id = PNFPECBGNMB;
			onlinePlaceable = LHOJNAHEGIC;
		}
	}

	private const int LDMKIGKAGEO = 999;

	public static OnlineObjectsManager instance;

	public Action OnActorPlaceableDeselected = delegate
	{
	};

	public Dictionary<int, OnlineObject> onlineObjects = new Dictionary<int, OnlineObject>();

	public OnlinePlaceable[] playersPlaceablesSelected = new OnlinePlaceable[5];

	public int[] playersUsingObject = new int[5] { -1, -1, -1, -1, -1 };

	public Dictionary<int, Vector2> movingDroppedItems = new Dictionary<int, Vector2>();

	public Dictionary<int, Vector2> movingAnimals = new Dictionary<int, Vector2>();

	public Dictionary<int, Vector2> movingMagicBrooms = new Dictionary<int, Vector2>();

	public Dictionary<int, Vector2> movingCats = new Dictionary<int, Vector2>();

	public Dictionary<int, Vector2> movingHamsters = new Dictionary<int, Vector2>();

	public Dictionary<int, Vector2> movingDogs = new Dictionary<int, Vector2>();

	public Dictionary<int, float> doWorksUpdated = new Dictionary<int, float>();

	public Dictionary<int, float> dirtyTablesToSend = new Dictionary<int, float>();

	public Material outlineMaterialGuests;

	public List<int> untrackedObjects = new List<int>();

	public int nextUniqueId = 100000;

	public int networkID;

	private OnlineObject NKJHFIDLEMN;

	private OnlinePlaceable GPCJDNCIFMB;

	[SerializeField]
	private OnlineObject movingObject;

	private Vector2 EFEIOCBDHBP;

	private WaitForSeconds LEALAKGNMCD;

	public bool requestDone;

	public List<int> interactingObjects = new List<int>();

	private int NOGMHJPJGAP;

	private PlaceableMsg IALMEDHBAKC;

	private OnlinePlaceable HBDFJGNDOGN;

	private static OnlinePlaceable AMJINIOHPAB;

	public void SendPlayerUsingObject(int KMNLDOOKKLO)
	{
		if (Object.op_Implicit((Object)(object)Bed.instance))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerUsingObject", (RpcTarget)0, (byte)Bed.instance.numInstance, KMNLDOOKKLO);
		}
		else
		{
			Debug.LogError((object)("Bed.instance doesnt exist. Cannot SendPlayerUsingObject uniqueId: " + KMNLDOOKKLO));
		}
	}

	[PunRPC]
	public void ReceiveHenHouseMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<HenHouseMsg>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void IKPMEPDFICJ()
	{
		foreach (KeyValuePair<int, float> item in dirtyTablesToSend)
		{
			if (item.Value > 0f)
			{
				SendAddDirtiness(item.Key, item.Value);
			}
			else
			{
				SendReduceDirtiness(item.Key, Mathf.Abs(item.Value));
			}
		}
		dirtyTablesToSend.Clear();
	}

	private void MBGCNGFHEAC(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).Sick();
		}
	}

	public void SendStartWork(int KMNLDOOKKLO, float LLIKFNFINLB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartWork", (RpcTarget)1, KMNLDOOKKLO, LLIKFNFINLB);
	}

	[PunRPC]
	private void ReceiveCatPosition(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.MoveToNextPosition(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	public void SendSetBool(int BEIPALOAAJJ, string GEGDHHIDEEF, bool AODONKKHPBP)
	{
		SendSetBool(BEIPALOAAJJ, Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void MKHJIMLEDBJ(int KMNLDOOKKLO, int MGNOBNCMDJG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = KMNLDOOKKLO;
		array[0] = MGNOBNCMDJG;
		OnlineManager.SendRPC(photonView, "Cat", (RpcTarget)0, array);
	}

	public void ReceiveBallTouch(int KMNLDOOKKLO, int ECPOBCFJFIF, float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineHamsterBall).ReceiveBallTouch(ECPOBCFJFIF, new Vector2(NCPGNLOJGAF, JLMAILGJNCE));
		}
	}

	[PunRPC]
	private void ReceiveAnimalLevel(int BEIPALOAAJJ, int EONJGMONIOM)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveLevel(EONJGMONIOM);
		}
	}

	private void IFHFNDELKOP()
	{
		try
		{
			interactingObjects.Clear();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in OnlineObjectsManager.OnPlayerSleep: " + ex.Message));
		}
	}

	public void HBJIOMBFPFN(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<TreeMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceiveSetBool(int BEIPALOAAJJ, int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlineAnimal)
			{
				(NKJHFIDLEMN as OnlineAnimal).ReceiveSetBool(GJKKNOKIKBJ, AODONKKHPBP);
			}
			else if (NKJHFIDLEMN is OnlineMagicBroom)
			{
				(NKJHFIDLEMN as OnlineMagicBroom).ReceiveSetBool(GJKKNOKIKBJ, AODONKKHPBP);
			}
			else if (NKJHFIDLEMN is OnlineCat)
			{
				(NKJHFIDLEMN as OnlineCat).ReceiveSetBool(GJKKNOKIKBJ, AODONKKHPBP);
			}
			else if (NKJHFIDLEMN is OnlineBird)
			{
				(NKJHFIDLEMN as OnlineBird).ReceiveSetBool(GJKKNOKIKBJ, AODONKKHPBP);
			}
			else if (NKJHFIDLEMN is OnlineDog)
			{
				(NKJHFIDLEMN as OnlineDog).ReceiveSetBool(GJKKNOKIKBJ, AODONKKHPBP);
			}
		}
	}

	private void GIMAMFHJJMD()
	{
		foreach (KeyValuePair<int, float> item in dirtyTablesToSend)
		{
			if (item.Value > 109f)
			{
				SendAddDirtiness(item.Key, item.Value);
			}
			else
			{
				SendReduceDirtiness(item.Key, Mathf.Abs(item.Value));
			}
		}
		dirtyTablesToSend.Clear();
	}

	public bool AnyActorHasPlaceableSelected(int BEIPALOAAJJ)
	{
		for (int i = 0; i < playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)playersPlaceablesSelected[i] != (Object)null && playersPlaceablesSelected[i].uniqueId == BEIPALOAAJJ)
			{
				return true;
			}
		}
		return false;
	}

	[PunRPC]
	public void ReceiveDialogueStart(int BEIPALOAAJJ, bool OMFIGAJAOCJ)
	{
		Debug.Log((object)"ReceiveDialogueStart");
		CHAEKNLHEKP(BEIPALOAAJJ).DialogueStartRPC(OMFIGAJAOCJ);
	}

	public void SendVacateRoom(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveVacateRoom", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void RemoveObjectInDictionary(OnlineObject MACGLLKALDE)
	{
		if (onlineObjects.ContainsKey(MACGLLKALDE.uniqueId) && ((Object)(object)onlineObjects[MACGLLKALDE.uniqueId] == (Object)null || ((object)onlineObjects[MACGLLKALDE.uniqueId]).Equals((object?)MACGLLKALDE)))
		{
			onlineObjects.Remove(MACGLLKALDE.uniqueId);
		}
	}

	[PunRPC]
	private void ReceiveRemoveFromInteracting(int BEIPALOAAJJ)
	{
		if (interactingObjects.Contains(BEIPALOAAJJ))
		{
			interactingObjects.Remove(BEIPALOAAJJ);
		}
	}

	public void SendSetInt(int BEIPALOAAJJ, int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetInt", (RpcTarget)1, BEIPALOAAJJ, GJKKNOKIKBJ, AODONKKHPBP);
	}

	public void SendPlantCrop(Vector2 IMOBLFMHKOD, int BCBFHGNJLOA, int BEIPALOAAJJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlantCrop", (RpcTarget)1, IMOBLFMHKOD.x, IMOBLFMHKOD.y, BCBFHGNJLOA, BEIPALOAAJJ);
	}

	private void ELIEFGIJKAL(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = KMNLDOOKKLO;
		array[0] = BDKCDBALPJH;
		array[0] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "ThemeListView", (RpcTarget)0, array);
	}

	public void SelectPlaceableIfIsPossible(int BEIPALOAAJJ)
	{
		if (OnlineManager.IsMasterClient())
		{
			SelectPlaceableIfIsPossibleMaster(BEIPALOAAJJ, (byte)PhotonNetwork.LocalPlayer.ActorNumber);
			return;
		}
		requestDone = true;
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SelectPlaceableIfIsPossibleMaster", (RpcTarget)2, BEIPALOAAJJ, (short)PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void SendEggIncrement(int KMNLDOOKKLO, int ABAIKKGKDGD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEggIncrement", (RpcTarget)1, KMNLDOOKKLO, (byte)ABAIKKGKDGD);
	}

	public void NCFLAFBFKDK(OnlineDroppedItem DGDKABHINMJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(new DroppedItemMessage(DGDKABHINMJ));
		OnlineManager.SendRPC(photonView, "SelectPermissionAccepted", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveFishTrapMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<FishTrapMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void SendCure(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCure", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void LGNNBEKOKAF(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = KMNLDOOKKLO;
		OnlineManager.SendRPC(photonView, "chatSounds", (RpcTarget)1, array);
	}

	public void CHHGNBLJBFI(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<DrinkDispenserMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void BMLOGPDAHLL(OnlineObject KGCCCHBFJLE)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((!(KGCCCHBFJLE is OnlinePlaceable onlinePlaceable) || !((Object)(object)onlinePlaceable.placeable != (Object)null) || !((Object)(object)onlinePlaceable.placeable.parent != (Object)null)) ? ((Component)KGCCCHBFJLE).transform.position : onlinePlaceable.placeable.parent.transform.position);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = KGCCCHBFJLE.uniqueId;
		array[0] = val.x;
		array[7] = val.y;
		OnlineManager.SendRPC(photonView, "Player with actor number {0} already exists in the dictionary. This shouldn't happen.", (RpcTarget)1, array);
	}

	private OnlineDialogueNPC CHAEKNLHEKP(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			if (!(NKJHFIDLEMN is OnlinePlaceable onlinePlaceable))
			{
				return ((Component)NKJHFIDLEMN).GetComponent<OnlineDialogueNPC>();
			}
			if ((Object)(object)onlinePlaceable.onlineDialogueNPC != (Object)null)
			{
				return onlinePlaceable.onlineDialogueNPC;
			}
			Debug.LogError((object)"OnlinePlaceable doesn't have an OnlineDialogueNPC component");
		}
		return null;
	}

	[PunRPC]
	private void ReceiveDogPosition(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.MoveToNextPosition(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	public void ClearInteractingObjects()
	{
		interactingObjects.Clear();
	}

	[PunRPC]
	public void ReceiveObjectAction(int BEIPALOAAJJ, byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.ReceiveAction(FACPEEACCMH, GEMFIOKGIMC);
		}
		else if (BEIPALOAAJJ >= 100000 || BEIPALOAAJJ < 0)
		{
			Debug.LogError((object)("Multiplayer Object is null " + BEIPALOAAJJ), (Object)(object)((Component)this).gameObject);
			SendMultiplayerObjectNotFound(BEIPALOAAJJ);
		}
	}

	private void DDMAFOHDHAA(int BEIPALOAAJJ, short FFDIEOBBFKL)
	{
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			(onlineObjects[BEIPALOAAJJ] as OnlineDroppedItem).OPJHAIDDILA(FFDIEOBBFKL);
		}
		else
		{
			Debug.LogError((object)("Items/item_name_1107" + BEIPALOAAJJ + "https://discord.gg/7rBtuZb"));
		}
	}

	public void SendSetDirtiness(int KMNLDOOKKLO, float PDIEEDFOINN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetDirtiness", (RpcTarget)1, KMNLDOOKKLO, PDIEEDFOINN);
	}

	[PunRPC]
	private void ReceiveHitJacky()
	{
		JackyController.GGFJGHHHEJC.jackys[2].HitOnline();
	}

	private void Start()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		if (((MonoBehaviourPun)this).photonView.ViewID != 999)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {999} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
		OnlineManager.OnRoomJoined = (Action)Delegate.Combine(OnlineManager.OnRoomJoined, new Action(CCAGDLHMCLL));
		if (Application.isEditor)
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PAEGEMEFOBK));
		}
		LEALAKGNMCD = new WaitForSeconds(((Object)(object)OnlineManager.LMALNDLJILM != (Object)null) ? OnlineManager.LMALNDLJILM.waitTimeBetweenMessages : 0.1f);
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Combine(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	[PunRPC]
	private void ReceiveCloseAnimation(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineItemContainer).ReceiveCloseAnimation();
		}
	}

	private void EOIKPHJCLFA(int BEIPALOAAJJ, bool DDNPPKBFENA, Vector2 PGKJLODFAIF)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return;
		}
		GPCJDNCIFMB = NKJHFIDLEMN as OnlinePlaceable;
		if (Object.op_Implicit((Object)(object)GPCJDNCIFMB))
		{
			if (Object.op_Implicit((Object)(object)GPCJDNCIFMB.placeable) && Object.op_Implicit((Object)(object)GPCJDNCIFMB.placeable.itemSpace))
			{
				GPCJDNCIFMB.ICNMMFEJGJO();
				((Component)GPCJDNCIFMB).transform.position = Vector2.op_Implicit(PGKJLODFAIF);
				GPCJDNCIFMB.placeable.itemSpace.OAIBPEEFIJB(DDNPPKBFENA, KBNNPAKJDJM: true, CDPAMNIPPEC: false);
				GPCJDNCIFMB.CLHLNFFGOGA = DDNPPKBFENA;
				CameraRenderSettings.placeablePlayer = null;
			}
			else
			{
				OnlinePlaceable gPCJDNCIFMB = GPCJDNCIFMB;
				string text = "action" + ((gPCJDNCIFMB != null) ? ((Object)((Component)gPCJDNCIFMB).gameObject).name : null) + "Farm/Buzz/BuildExit";
				OnlinePlaceable gPCJDNCIFMB2 = GPCJDNCIFMB;
				Debug.LogError((object)text, (Object)(object)((gPCJDNCIFMB2 != null) ? ((Component)gPCJDNCIFMB2).gameObject : null));
			}
		}
	}

	public void SendHitToOthers(int BEIPALOAAJJ, Vector3 JBMDOGNFIGJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHit", (RpcTarget)1, BEIPALOAAJJ, JBMDOGNFIGJ.x, JBMDOGNFIGJ.y, false);
	}

	public void SendCrafterRepaired(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCrafterRepaired", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void EHELIJAIBDF(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		movingObject = null;
		if (Object.op_Implicit((Object)(object)Bed.instance))
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = BEIPALOAAJJ;
			array[0] = IMOBLFMHKOD.x;
			array[3] = IMOBLFMHKOD.y;
			array[4] = (byte)Bed.instance.numInstance;
			OnlineManager.SendRPC(photonView, "CurrentThemeSection", (RpcTarget)0, array);
		}
		else
		{
			Debug.LogError((object)("ReceiveInstantiateDog" + BEIPALOAAJJ));
		}
	}

	public void RequestToggleOpenBarn()
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveToggleOpenBarnMaster((short)PhotonNetwork.LocalPlayer.ActorNumber);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveToggleOpenBarnMaster", (RpcTarget)2, (short)PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void GHHOOGFBMLO(int KMNLDOOKKLO, int OBHOAFNMDCD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = KMNLDOOKKLO;
		array[1] = (byte)OBHOAFNMDCD;
		OnlineManager.SendRPC(photonView, "OnlinePlayer", (RpcTarget)1, array);
	}

	private void DOBCOIDCMFF(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBallPosition", (RpcTarget)1, KMNLDOOKKLO, BDKCDBALPJH, ACMOGJCLELA);
	}

	public void SendLoadCrowlyEventToMaster()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReciveLoadCrowlyEventToMaster", (RpcTarget)2);
	}

	[PunRPC]
	private void ReceiveSetDirtiness(int BEIPALOAAJJ, float PDIEEDFOINN)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).SetDirtiness(PDIEEDFOINN);
		}
	}

	private void DLINBJEABBK()
	{
		foreach (KeyValuePair<int, float> item in doWorksUpdated)
		{
			BKLGLJDBBBE(item.Key, item.Value);
		}
		doWorksUpdated.Clear();
	}

	public void SendInteractJacky(int JFNMCNCHMEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInteractJacky", (RpcTarget)1, (byte)JFNMCNCHMEO);
	}

	public void MCFJDPPCIEA(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = KMNLDOOKKLO;
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "Received RPC SetBool {0} with value {1} on {2}. Setting animator parameter.", (RpcTarget)1, array);
	}

	[PunRPC]
	public void InteractPermissionDenied()
	{
		requestDone = false;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
		PlayerInputs.GetPlayer(1).mouseUpBlockers.Remove((MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
	}

	[PunRPC]
	private void ReceiveAddToPlaceableSurface(int BEIPALOAAJJ, int EOBNIMOMJEF, int HOJECNDMCLM)
	{
		if (onlineObjects.ContainsKey(BEIPALOAAJJ) && onlineObjects.ContainsKey(EOBNIMOMJEF))
		{
			GPCJDNCIFMB = onlineObjects[BEIPALOAAJJ] as OnlinePlaceable;
			if ((Object)(object)GPCJDNCIFMB != (Object)null)
			{
				AMJINIOHPAB = onlineObjects[EOBNIMOMJEF] as OnlinePlaceable;
				if (Object.op_Implicit((Object)(object)AMJINIOHPAB))
				{
					GPCJDNCIFMB.placeable.AddPlaceableToSurface(AMJINIOHPAB.placeable.placeableSurface, CDPAMNIPPEC: false, HOJECNDMCLM);
				}
				else
				{
					Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " not found. Cannot add to surface"));
				}
			}
		}
		else
		{
			if (!onlineObjects.ContainsKey(BEIPALOAAJJ))
			{
				Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " not found. Cannot add to surface"));
			}
			if (!onlineObjects.ContainsKey(EOBNIMOMJEF))
			{
				Debug.LogError((object)("Parent unique id " + EOBNIMOMJEF + " not found. Cannot add to surface"));
			}
		}
	}

	[PunRPC]
	private void ReceiveSelectedObjectPositionClient(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.MoveToNextPosition(IMOBLFMHKOD);
		}
	}

	public void SendOpenAnimation(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOpenAnimation", (RpcTarget)1, KMNLDOOKKLO);
	}

	[PunRPC]
	public void ReceiveFollow(int JJPJHIHBOIB)
	{
		DogNPC.instance.onlineDog.ReceiveFollow(JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveAnimalSetProduction(int BEIPALOAAJJ, float AODONKKHPBP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveSetProduction(AODONKKHPBP);
		}
	}

	public void DLJPEICOGND(OnlinePlaceable KGCCCHBFJLE, bool DDNPPKBFENA, Vector2 PGKJLODFAIF)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = KGCCCHBFJLE.uniqueId;
		array[0] = DDNPPKBFENA;
		array[4] = PGKJLODFAIF;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
	}

	private void DNLKEMKFOIP(int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.DKGEOKBHAGO(CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveEggIncrement(int KMNLDOOKKLO, byte ABAIKKGKDGD)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineHenHouse onlineHenHouse)
		{
			onlineHenHouse.henHouse.IncrementEggsAmount(ABAIKKGKDGD, CDPAMNIPPEC: false);
		}
	}

	private void GKOIPEIIIFN(int BEIPALOAAJJ, int HJECLKNOHGC)
	{
		if (onlineObjects.TryGetValue(HJECLKNOHGC, out NKJHFIDLEMN))
		{
			OnlineHenHouse oPNDIFDIBLB = NKJHFIDLEMN as OnlineHenHouse;
			if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
			{
				(NKJHFIDLEMN as OnlineAnimal).AssignChicken(oPNDIFDIBLB);
			}
		}
	}

	[PunRPC]
	private void ReceiveUpdateContentsRoom(int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.UpdateContentsNextFrame();
		}
	}

	public void ENGOINCLFMB(int BEIPALOAAJJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = BEIPALOAAJJ;
		OnlineManager.SendRPC(photonView, "Player2", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveGetUniqueCropHarvestableOnClient(int KMNLDOOKKLO, bool PFIOMFFOBBD)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN) && NKJHFIDLEMN is OnlineCropTree onlineCropTree)
		{
			onlineCropTree.cropSetter.GetUniqueCropHarvestable(PFIOMFFOBBD);
		}
	}

	private void EOGBOGGEAAJ()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<int, Vector2> movingDog in movingDogs)
		{
			HHCMEIGBAJG(movingDog.Key, movingDog.Value.x, movingDog.Value.y);
		}
		movingDogs.Clear();
	}

	[PunRPC]
	public void ReciveInUseOnlineObjects(int BEIPALOAAJJ, bool DJGKNDPGIGB)
	{
		CHAEKNLHEKP(BEIPALOAAJJ).ReciveInUse(DJGKNDPGIGB);
	}

	public void LFGEJHFKOCC(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = KMNLDOOKKLO;
		OnlineManager.SendRPC(photonView, "SetAnimatorStateRPC", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveObjectInteract(int BEIPALOAAJJ, byte MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		if (!onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			Debug.LogError((object)("Cannot receive interact " + BEIPALOAAJJ));
			return;
		}
		NKJHFIDLEMN = onlineObjects[BEIPALOAAJJ];
		if ((Object)(object)NKJHFIDLEMN == (Object)null)
		{
			if (BEIPALOAAJJ >= 100000 || BEIPALOAAJJ < 0)
			{
				Debug.LogError((object)("Multiplayer Object is null " + BEIPALOAAJJ));
				SendMultiplayerObjectNotFound(BEIPALOAAJJ);
			}
		}
		else
		{
			NKJHFIDLEMN.ReceiveInteract(MGEIKDCIANC, GEMFIOKGIMC);
		}
	}

	[PunRPC]
	private void ReceiveInteractJacky(byte JFNMCNCHMEO)
	{
		JackyController.GGFJGHHHEJC.jackys[JFNMCNCHMEO].InteractJacky(1, CKJIHLIFPMF: true);
	}

	public void HMALDEDJIKO(int BEIPALOAAJJ, byte FACPEEACCMH)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.KHCABBJBBED(FACPEEACCMH);
		}
		else if (BEIPALOAAJJ >= -41 || BEIPALOAAJJ < 1)
		{
			Debug.LogError((object)(" %" + BEIPALOAAJJ), (Object)(object)((Component)this).gameObject);
			SendMultiplayerObjectNotFound(BEIPALOAAJJ);
		}
	}

	[PunRPC]
	private void ReceiveStartCrowlyEvent()
	{
		NessyNPC.GGFJGHHHEJC.canTalk = false;
		CrowlyEvent.GGFJGHHHEJC.StartEventOnline();
	}

	public void SendInstantiateDroppedItem(OnlineDroppedItem DGDKABHINMJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDroppedItemMessage", (RpcTarget)1, OnlineSerializer.Serialize(new DroppedItemMessage(DGDKABHINMJ)));
	}

	public void AddMagicBroomMovement(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingMagicBrooms.ContainsKey(KMNLDOOKKLO))
		{
			movingMagicBrooms[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingMagicBrooms.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	[PunRPC]
	public void ReceiveDroppedItemMessage(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DroppedItemMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	[PunRPC]
	private void ReceiveSick(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).Sick();
		}
	}

	private void DIENJGJPHJG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)movingObject != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSelectedObjectPositionClient", (RpcTarget)1, movingObject.uniqueId, EFEIOCBDHBP);
		}
	}

	public void MPNGIFHOAMO(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		movingObject = null;
		if (Object.op_Implicit((Object)(object)Bed.instance))
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[5];
			array[0] = BEIPALOAAJJ;
			array[1] = IMOBLFMHKOD.x;
			array[1] = IMOBLFMHKOD.y;
			array[0] = (byte)Bed.instance.numInstance;
			OnlineManager.SendRPC(photonView, "Dog", (RpcTarget)0, array);
		}
		else
		{
			Debug.LogError((object)("</color>" + BEIPALOAAJJ));
		}
	}

	[PunRPC]
	private void ReceiveServeCustomerOrder(int KMNLDOOKKLO, int KMCCFOGJCJF)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.customerOrder.ServeRoomCustomer(1, null, null, CDPAMNIPPEC: false, KMCCFOGJCJF);
		}
	}

	private void NMOBFGNJIJN(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineItemContainer).NECBNIDONDD();
		}
	}

	[PunRPC]
	public void ReceiveAnimalFeederSlotPressed(int MJEEPANJLFL, short IKMIKEDNCDI, short FGFCNKFEIGF)
	{
		if (onlineObjects.ContainsKey(MJEEPANJLFL))
		{
			if (onlineObjects[MJEEPANJLFL] is OnlineAnimalFeederFood onlineAnimalFeederFood)
			{
				onlineAnimalFeederFood.ReceiveAnimalFeederSlotPressed(IKMIKEDNCDI, FGFCNKFEIGF);
			}
		}
		else
		{
			Debug.LogError((object)("ReceiveRemoveSlot Unique object id " + MJEEPANJLFL + " not found."));
		}
	}

	private void FCDKBNKKKAJ(short JJPJHIHBOIB)
	{
		if (Barn.instance.CanToggle())
		{
			if (!Barn.instance.IsOpen() || Barn.instance.AnimalsHaveSpaceToLeave())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "descOldDoormat", (RpcTarget)1);
			}
			else
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " value ", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, true));
			}
		}
	}

	public void SendInitJackyEvent()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInitJackyEvent", (RpcTarget)1);
	}

	public void DHDLMCGIAAO()
	{
		movingHamsters.Clear();
	}

	public void NOEHOPHLAFA(int KMNLDOOKKLO, HumanInfo DKDFNAGAFNL, int HMEIHIFKGHD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Show", (RpcTarget)1, KMNLDOOKKLO, OnlineSerializer.Serialize(new HumanInfoMsg(DKDFNAGAFNL)), (byte)HMEIHIFKGHD, null, null, null);
	}

	private void BAGKFIHBNIL(short JJPJHIHBOIB, int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			(onlineObjects[KMNLDOOKKLO] as OnlineCrafter).crafter.CancelAllCrafting(0, OnlineManager.IsLocalActor(JJPJHIHBOIB));
		}
		else
		{
			Debug.LogError((object)("talent_name_110" + KMNLDOOKKLO + "ReceiveStartCrowlyEvent" + JJPJHIHBOIB));
		}
	}

	private void HKNAMICDBNB(int KMNLDOOKKLO, float LLIKFNFINLB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = KMNLDOOKKLO;
		array[1] = LLIKFNFINLB;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	private void AOJLCPFCENI(short JJPJHIHBOIB, int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			(onlineObjects[KMNLDOOKKLO] as OnlineCrafter).crafter.CancelAllCrafting(0, OnlineManager.IsLocalActor(JJPJHIHBOIB));
		}
		else
		{
			Debug.LogError((object)("Error " + KMNLDOOKKLO + "Loop" + JJPJHIHBOIB));
		}
	}

	public void SendStartCrowlyEvent()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartCrowlyEvent", (RpcTarget)1);
	}

	private void IOGNDICEIMM(GameObject ANADFOCHOBF)
	{
		OnlineObject[] components = ANADFOCHOBF.GetComponents<OnlineObject>();
		if (components.Length > 0)
		{
			Debug.LogError((object)string.Format("Waiting for players to finish their transitions...", ANADFOCHOBF, components.Length));
		}
	}

	private void OGIKAAEOGAB(byte JFNMCNCHMEO)
	{
		JackyController.GGFJGHHHEJC.jackys[JFNMCNCHMEO].InteractJacky(0);
	}

	[PunRPC]
	public void ReceiveChristmasTreeMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<ChristmasTreeMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void AddActorPlaceableSelected(short JJPJHIHBOIB, OnlinePlaceable HBDFJGNDOGN)
	{
		if (JJPJHIHBOIB != PhotonNetwork.LocalPlayer.ActorNumber && HBDFJGNDOGN.CLHLNFFGOGA)
		{
			playersPlaceablesSelected[OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB)] = HBDFJGNDOGN;
		}
	}

	public void KLKDFCHDOKF(int BEIPALOAAJJ, byte FACPEEACCMH)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.KHCABBJBBED(FACPEEACCMH);
		}
		else if (BEIPALOAAJJ >= 9 || BEIPALOAAJJ < 0)
		{
			Debug.LogError((object)("Error in DialogueNPCBase.EndConversation: " + BEIPALOAAJJ), (Object)(object)((Component)this).gameObject);
			SendMultiplayerObjectNotFound(BEIPALOAAJJ);
		}
	}

	private void ALCNKPKPDGG(int GJDMLMEMKMD)
	{
		if ((Object)(object)playersPlaceablesSelected[GJDMLMEMKMD] != (Object)null)
		{
			if (OnlineManager.JPPBEIJDCLJ() && (Object)(object)playersPlaceablesSelected[GJDMLMEMKMD] != (Object)null)
			{
				playersPlaceablesSelected[GJDMLMEMKMD].placeable.ForcePickUp(0);
			}
			playersPlaceablesSelected[GJDMLMEMKMD] = null;
			OnActorPlaceableDeselected();
		}
	}

	[PunRPC]
	public void ReceiveObjectActionSimple(int BEIPALOAAJJ, byte FACPEEACCMH)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.ReceiveAction(FACPEEACCMH);
		}
		else if (BEIPALOAAJJ >= 100000 || BEIPALOAAJJ < 0)
		{
			Debug.LogError((object)("Multiplayer Object is null " + BEIPALOAAJJ), (Object)(object)((Component)this).gameObject);
			SendMultiplayerObjectNotFound(BEIPALOAAJJ);
		}
	}

	public void SendSetInt(int BEIPALOAAJJ, string GEGDHHIDEEF, int AODONKKHPBP)
	{
		SendSetInt(BEIPALOAAJJ, Animator.StringToHash(GEGDHHIDEEF), AODONKKHPBP);
	}

	public void IDFIBBKKMPF(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<DrinkDispenserMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void SendSetPickupable(int KMNLDOOKKLO, bool IHLGDCAIPLN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetPickupable", (RpcTarget)1, KMNLDOOKKLO, IHLGDCAIPLN);
	}

	public void FHNLMIGDJGI(int BEIPALOAAJJ, short JJPJHIHBOIB)
	{
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			requestDone = true;
		}
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			(onlineObjects[BEIPALOAAJJ] as OnlinePlaceable).PMFKKMGCLJA(JJPJHIHBOIB);
			AddActorPlaceableSelected(JJPJHIHBOIB, onlineObjects[BEIPALOAAJJ] as OnlinePlaceable);
		}
		else
		{
			Debug.LogError((object)("East" + BEIPALOAAJJ + "quest_name_27" + JJPJHIHBOIB));
		}
	}

	public void SendRenewCandle(int BEIPALOAAJJ, int PNFJKJNMOOD, bool MPMPHHFKKDN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRenewCandle", (RpcTarget)1, BEIPALOAAJJ, PNFJKJNMOOD, MPMPHHFKKDN);
	}

	public void GAGNJEMNFIA(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = KMNLDOOKKLO;
		OnlineManager.SendRPC(photonView, "Festín del Juramento/PresentacionMaestros 01", (RpcTarget)1, array);
	}

	public void NAANBBEJLNK(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DroppedItemMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void SendObjectInteract(int BEIPALOAAJJ, byte MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveObjectInteract", (RpcTarget)1, BEIPALOAAJJ, MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void GMJPOKECENH(int BEIPALOAAJJ)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			InteractPlaceableIfIsPossibleMaster(BEIPALOAAJJ, (short)PhotonNetwork.LocalPlayer.ActorNumber);
			return;
		}
		requestDone = true;
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = BEIPALOAAJJ;
		array[1] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "This is a networked player", (RpcTarget)8, array);
	}

	[PunRPC]
	private void ReceiveCure(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).Cure();
		}
	}

	public void GENFINFDEMD(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<CuckooClockMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceivePlaceableInfo(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<PlaceableMsg>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void Update()
	{
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		for (int i = 1; i < playersPlaceablesSelected.Length; i++)
		{
			if (!((Object)(object)playersPlaceablesSelected[i] == (Object)null))
			{
				if ((Object)(object)Bed.instance == (Object)null)
				{
					break;
				}
				if (i != Bed.instance.numInstance)
				{
					playersPlaceablesSelected[i].placeable.WhileSelectedCallback();
				}
			}
		}
	}

	private void JLFBILAOOEF(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = KMNLDOOKKLO;
		array[0] = BDKCDBALPJH;
		array[7] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "Key2", (RpcTarget)0, array);
	}

	public void SendRequestCustomerOrder(int KMNLDOOKKLO, ItemInstance DNLMCHDOMOK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestCustomerOrder", (RpcTarget)1, KMNLDOOKKLO, OnlineSerializer.Serialize(new ItemInstanceWrapperMessage(DNLMCHDOMOK)));
	}

	[PunRPC]
	private void ReceiveRenewCandle(int BEIPALOAAJJ, int PNFJKJNMOOD, bool MPMPHHFKKDN)
	{
		if (onlineObjects.ContainsKey(PNFJKJNMOOD))
		{
			(onlineObjects[PNFJKJNMOOD] as OnlinePlaceable).placeable.placeableSurface.AddToSurfaceCandle(BEIPALOAAJJ, MPMPHHFKKDN);
		}
		else
		{
			Debug.LogError((object)("ReceiveRenewCandle Unique id " + BEIPALOAAJJ + " not found."));
		}
	}

	[PunRPC]
	public void ReceiveDoorInfo(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<DoorMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void OOELPPNOLGN(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<ChristmasTreeMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void NIAMCKGMDPD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<int, Vector2> movingMagicBroom in movingMagicBrooms)
		{
			MOMMGOBLFJM(movingMagicBroom.Key, movingMagicBroom.Value.x, movingMagicBroom.Value.y);
		}
		movingMagicBrooms.Clear();
	}

	public void JNALGIBKJAL(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<RentedRoomMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void MOMMGOBLFJM(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveMagicBroomPosition", (RpcTarget)1, KMNLDOOKKLO, BDKCDBALPJH, ACMOGJCLELA);
	}

	private void BPJHMAHCBNJ()
	{
		AdoptionSignalManager.LPADOMGFAIE().adoption += 0;
	}

	[PunRPC]
	private void ReceiveRequestCustomerOrder(int KMNLDOOKKLO, byte[] OINICMNOLPK)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.customerOrder.UpdateRequestRoomOrder(OnlineSerializer.Deserialize<ItemInstanceWrapperMessage>(OINICMNOLPK).ANMBPDJLNFN());
		}
	}

	private void OMNJGHFEDLF(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveEnable();
		}
	}

	public void SendSetUniqueCropHarvestable(int KMNLDOOKKLO, bool PFIOMFFOBBD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetUniqueCropHarvestable", (RpcTarget)2, KMNLDOOKKLO, PFIOMFFOBBD);
	}

	public void IJCEOMLONFJ(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LoadingOnNewGameCreated", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void SendAnimalFeederSlotPressed(Slot ADEBNALPEHE, int FGFCNKFEIGF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalFeederSlotPressed", (RpcTarget)1, ADEBNALPEHE.uniqueObjectId, ADEBNALPEHE.id, (short)FGFCNKFEIGF);
	}

	public void FDMIHCPFCKK(int KMNLDOOKKLO, HumanInfo DKDFNAGAFNL, int HMEIHIFKGHD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = KMNLDOOKKLO;
		array[1] = OnlineSerializer.JBIPDCGKMGE(new HumanInfoMsg(DKDFNAGAFNL));
		array[6] = (byte)HMEIHIFKGHD;
		OnlineManager.SendRPC(photonView, "Quest not found with ID ", (RpcTarget)1, array);
	}

	public void OCEGMNMJFIC(int BEIPALOAAJJ, float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveHit(NCPGNLOJGAF, JLMAILGJNCE, CDPAMNIPPEC);
		}
	}

	private void GGCHCPKFPKP(int BEIPALOAAJJ, float AODONKKHPBP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveSetProduction(AODONKKHPBP);
		}
	}

	public void HHDGLBAGEFL(int BEIPALOAAJJ, int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = BEIPALOAAJJ;
		array[0] = GJKKNOKIKBJ;
		array[0] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "NotEnoughProfessionPoints", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveFloorDirtInfo(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<FloorDirtMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void SendSetLife(int BEIPALOAAJJ, int GDHFHKKMIEP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetLife", (RpcTarget)1, BEIPALOAAJJ, GDHFHKKMIEP);
	}

	public void SendRemoveFromPlaceableSurface(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveFromPlaceableSurface", (RpcTarget)1, BEIPALOAAJJ);
	}

	public void NDCJKNDILKF(int KMNLDOOKKLO, int GJDMLMEMKMD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "</color>", (RpcTarget)4, KMNLDOOKKLO, (byte)GJDMLMEMKMD, null, null, null, null, null);
	}

	[PunRPC]
	private void ReciveMoveCrowly()
	{
		CrowlyEvent.GGFJGHHHEJC.Move(1, CDPAMNIPPEC: false);
	}

	private void CHJOFJFOPDL(int JJPJHIHBOIB)
	{
		NOGMHJPJGAP = OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB);
		if (playersUsingObject[NOGMHJPJGAP] != -1 && onlineObjects.TryGetValue(playersUsingObject[NOGMHJPJGAP], out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlineItemContainer onlineItemContainer)
			{
				onlineItemContainer.ReceiveCloseAnimation();
			}
			ReceiveRemoveFromInteracting(NKJHFIDLEMN.uniqueId);
		}
		playersUsingObject[NOGMHJPJGAP] = -1;
	}

	[PunRPC]
	public void ReceiveDirection(int BEIPALOAAJJ, byte FCGBJEIIMBC)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.ReceiveDirection((Direction)FCGBJEIIMBC);
		}
	}

	public void InteractPlaceableIfIsPossible(int BEIPALOAAJJ)
	{
		if (OnlineManager.IsMasterClient())
		{
			InteractPlaceableIfIsPossibleMaster(BEIPALOAAJJ, (short)PhotonNetwork.LocalPlayer.ActorNumber);
			return;
		}
		requestDone = true;
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "InteractPlaceableIfIsPossibleMaster", (RpcTarget)2, BEIPALOAAJJ, (short)PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void SendInstantiateMiscellaneousHarvest(OnlineMiscellaneousHarvest DGDKABHINMJ)
	{
		MiscellaneousHarvestMessage mOBFJEDPIPM = new MiscellaneousHarvestMessage(DGDKABHINMJ);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivInstantiateMiscellaneousHarvest", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	[PunRPC]
	public void ReceiveAnimalWalk(int BEIPALOAAJJ, bool HCCBOAMEEIJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveWalk(HCCBOAMEEIJ);
		}
	}

	public void FDJDPOLBEDO(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = KMNLDOOKKLO;
		array[0] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "Sickle", (RpcTarget)6, array);
	}

	private void KINEEEDAKKB(float NCPGNLOJGAF, float JLMAILGJNCE, int BCBFHGNJLOA, int BEIPALOAAJJ)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		Seed.KHEGKHENPLD(1, new Vector2(NCPGNLOJGAF, JLMAILGJNCE), BCBFHGNJLOA, CDPAMNIPPEC: false, BEIPALOAAJJ);
	}

	public void KEHDLCGIBGH(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = KMNLDOOKKLO;
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		array[8] = IMOBLFMHKOD.x;
		array[1] = IMOBLFMHKOD.y;
		OnlineManager.SendRPC(photonView, ".gz", (RpcTarget)1, array);
	}

	[PunRPC]
	public void SelectPermissionDenied()
	{
		requestDone = false;
	}

	private void KDCOMENLNOF()
	{
		if (Application.isPlaying)
		{
			foreach (Placeable currentPlaceable in PlaceablesManager.MAIDHAPANEB().currentPlaceables)
			{
				if (!((Object)(object)currentPlaceable == (Object)null))
				{
					ALHAAPMGHPG(((Component)currentPlaceable).gameObject);
					if (currentPlaceable.rotatable && (Object)(object)currentPlaceable.rotatedPrefab != (Object)null)
					{
						ALHAAPMGHPG(currentPlaceable.rotatedPrefab);
					}
				}
			}
			return;
		}
		Item[] items = ItemDatabaseAccessor.GetDatabaseSO().items;
		for (int i = 0; i < items.Length; i += 0)
		{
			Item item = items[i];
			if (!((Object)(object)item.LLCLICBABLN() == (Object)null))
			{
				ALHAAPMGHPG(item.LLCLICBABLN());
				if (Object.op_Implicit((Object)(object)item.PHGCBMPGGLI().GetComponent<Placeable>()) && item.LLCLICBABLN().GetComponent<Placeable>().rotatable && (Object)(object)item.LLCLICBABLN().GetComponent<Placeable>().rotatedPrefab != (Object)null)
				{
					IOGNDICEIMM(item.LLCLICBABLN().GetComponent<Placeable>().rotatedPrefab);
				}
			}
		}
		Debug.Log((object)"Are you sure to change all buttons to default values?");
	}

	public void EBIAMNPNFHB(int KMNLDOOKKLO, bool PFIOMFFOBBD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = KMNLDOOKKLO;
		array[1] = PFIOMFFOBBD;
		OnlineManager.SendRPC(photonView, "tutorialPopUp112", (RpcTarget)8, array);
	}

	public void SendObjectActionToActor(int BEIPALOAAJJ, byte FACPEEACCMH, int JJPJHIHBOIB, params object[] GEMFIOKGIMC)
	{
		if (BEIPALOAAJJ != 0)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveObjectAction", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), BEIPALOAAJJ, FACPEEACCMH, GEMFIOKGIMC);
		}
	}

	private void EEHGHGMGMAH()
	{
		JackyController.OAPOJCODNCO().InitJackyEvent(CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void ReceiveInitJackyEvent()
	{
		JackyController.GGFJGHHHEJC.InitJackyEvent(CDPAMNIPPEC: false);
	}

	public void AGBECANKBCB(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BirdMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceiveRockMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<RockMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveDoWorkUpdate(int BEIPALOAAJJ, float LLIKFNFINLB)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.AddOnlineWorkAmount(LLIKFNFINLB);
		}
	}

	private void DGMAPCACJPM()
	{
		try
		{
			interactingObjects.Clear();
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveCrystalHit" + ex.Message));
		}
	}

	[PunRPC]
	private void ReceiveCrafterRepaired(int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			if (onlineObjects[KMNLDOOKKLO] is OnlineCrafter onlineCrafter)
			{
				onlineCrafter.crafter.Repair(1, 0, 0, 0, 0, 0, GFNHAMCPEAK: false);
			}
		}
		else
		{
			Debug.LogError((object)("Unique id " + KMNLDOOKKLO + " not found."));
		}
	}

	public void SendCancelAllCrafting(int KMNLDOOKKLO)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveCancelAllCraftingMaster((short)PhotonNetwork.LocalPlayer.ActorNumber, KMNLDOOKKLO);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCancelAllCraftingMaster", (RpcTarget)2, (short)PhotonNetwork.LocalPlayer.ActorNumber, KMNLDOOKKLO);
	}

	[PunRPC]
	private void ReceiveAdoptions()
	{
		AdoptionSignalManager.GetInstance().adoption++;
	}

	[PunRPC]
	private void ReceiveGetUniqueCropDay(int KMNLDOOKKLO, short JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGetUniqueCropDayOnClient", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), KMNLDOOKKLO, GeneratorsManager.instance.GetUniqueCropDays(KMNLDOOKKLO));
	}

	[PunRPC]
	private void ReceiveAnimalPosition(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.MoveToNextPosition(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	public void SendAskForRockStartInfo(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAskForRockStartInfo", (RpcTarget)1, KMNLDOOKKLO, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void UpdateUntrackedObjects(Location NFHFNKHHGGI)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int num = untrackedObjects.Count - 1; num >= 0; num--)
		{
			if (onlineObjects.TryGetValue(untrackedObjects[num], out NKJHFIDLEMN) && Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)NKJHFIDLEMN).transform.position)) == NFHFNKHHGGI)
			{
				untrackedObjects.Remove(untrackedObjects[num]);
				if (NKJHFIDLEMN is OnlineAnimal onlineAnimal)
				{
					onlineAnimal.SendTeleportAnimal();
				}
				else if (NKJHFIDLEMN is OnlineCat onlineCat)
				{
					onlineCat.SendTeleportCat();
				}
			}
		}
	}

	private void IMGGJBDODKJ(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = KMNLDOOKKLO;
		array[1] = BDKCDBALPJH;
		array[5] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "\n", (RpcTarget)1, array);
	}

	public void BPDDEKABKKM(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingHamsters.ContainsKey(KMNLDOOKKLO))
		{
			movingHamsters[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingHamsters.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	[PunRPC]
	private void ReceiveDisable(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveDisable();
		}
	}

	public void DeselectPlaceable(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		movingObject = null;
		if (Object.op_Implicit((Object)(object)Bed.instance))
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DeselectPlaceableOthers", (RpcTarget)1, BEIPALOAAJJ, IMOBLFMHKOD.x, IMOBLFMHKOD.y, (byte)Bed.instance.numInstance);
		}
		else
		{
			Debug.LogError((object)("Bed.instance doesnt exist. Cannot SendDeselectPlaceable uniqueId: " + BEIPALOAAJJ));
		}
	}

	[PunRPC]
	private void ReceiveToggleOpenBarnMaster(short JJPJHIHBOIB)
	{
		if (Barn.instance.CanToggle())
		{
			if (!Barn.instance.IsOpen() || Barn.instance.AnimalsHaveSpaceToLeave())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveToggleOpenBarnAccepted", (RpcTarget)0);
			}
			else
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveToggleOpenBarnCanceled", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false));
			}
		}
	}

	[PunRPC]
	private void ReciveLoadCrowlyEventToMaster()
	{
		if (CrowlyEvent.GGFJGHHHEJC.startCrowlyEvent)
		{
			SendSetCrowlyEvent();
		}
	}

	public void FKMKAJNIHPK(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BeehiveMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void JOECLPIGEFN(int GJDMLMEMKMD)
	{
		if ((Object)(object)playersPlaceablesSelected[GJDMLMEMKMD] != (Object)null)
		{
			if (OnlineManager.IsMasterClient() && (Object)(object)playersPlaceablesSelected[GJDMLMEMKMD] != (Object)null)
			{
				playersPlaceablesSelected[GJDMLMEMKMD].placeable.ForcePickUp(1, NDMBEJNOPPP: true);
			}
			playersPlaceablesSelected[GJDMLMEMKMD] = null;
			OnActorPlaceableDeselected();
		}
	}

	public void SendAdoptions()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAdoptions", (RpcTarget)1);
	}

	[PunRPC]
	private void DestroyObjectClient(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			if (Object.op_Implicit((Object)(object)NKJHFIDLEMN))
			{
				NKJHFIDLEMN.uniqueId = 0;
				if (NKJHFIDLEMN is OnlinePlaceable onlinePlaceable)
				{
					if ((Object)(object)onlinePlaceable.placeable.parent != (Object)null)
					{
						onlinePlaceable.placeable.parent.transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
					}
					else
					{
						((Component)onlinePlaceable).transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
					}
					if (onlinePlaceable.CLHLNFFGOGA)
					{
						onlinePlaceable.placeable.OnThisPlaceablePickedUp(1);
						CommonReferences.GGFJGHHHEJC.OnPlaceablePickedUp(1, onlinePlaceable.placeable, arg3: false);
					}
					Utils.BLPDAEHPOBA(((Object)(object)onlinePlaceable.placeable.parent != (Object)null) ? onlinePlaceable.placeable.parent : ((Component)onlinePlaceable).gameObject);
				}
				else
				{
					((Component)NKJHFIDLEMN).transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
					Utils.BLPDAEHPOBA(((Component)NKJHFIDLEMN).gameObject);
				}
			}
			else
			{
				Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " exist in dictionary but is null"));
			}
		}
		onlineObjects.Remove(BEIPALOAAJJ);
		for (int i = 0; i < playersPlaceablesSelected.Length; i++)
		{
			if (!((Object)(object)playersPlaceablesSelected[i] == (Object)null) && playersPlaceablesSelected[i].uniqueId == BEIPALOAAJJ)
			{
				playersPlaceablesSelected[i] = null;
				break;
			}
		}
		OnActorPlaceableDeselected();
	}

	[PunRPC]
	private void ReceiveDroppedItemPosition(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.MoveToNextPosition(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	public void ICIMPEJEGEN(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<ChristmasTreeMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveKick(int KMNLDOOKKLO, float AINPJHKNJGL, int ECPOBCFJFIF, float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineHamsterBall).ReceiveKick(AINPJHKNJGL, ECPOBCFJFIF, new Vector2(NCPGNLOJGAF, JLMAILGJNCE));
		}
	}

	private void GBMHEMLEMCK(int BEIPALOAAJJ)
	{
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			GPCJDNCIFMB = onlineObjects[BEIPALOAAJJ] as OnlinePlaceable;
			if ((Object)(object)GPCJDNCIFMB != (Object)null)
			{
				GPCJDNCIFMB.placeable.GDMIHFGJEBK(CDPAMNIPPEC: true);
			}
		}
		else
		{
			Debug.LogError((object)("ErrorVersionMatchFailed" + BEIPALOAAJJ + "reputationRequirement" + true));
		}
	}

	private IEnumerator ANPFHCDJNHG()
	{
		while (OnlineManager.PlayingOnline())
		{
			DIENJGJPHJG();
			EDICKNNGMGO();
			DLINBJEABBK();
			IKPMEPDFICJ();
			GAKFBFFLEOG();
			NIAMCKGMDPD();
			MFKOKGMKMFB();
			MKMNFIDKFLD();
			EOGBOGGEAAJ();
			yield return LEALAKGNMCD;
		}
	}

	public void SendReduceDirtiness(int KMNLDOOKKLO, float HNEHMKOJJMF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveReduceDirtiness", (RpcTarget)1, KMNLDOOKKLO, HNEHMKOJJMF);
	}

	private void FKDBPCIHABB(int BEIPALOAAJJ, byte MGEIKDCIANC, object[] GEMFIOKGIMC)
	{
		if (!onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			Debug.LogError((object)("Received PlaceableMsg of another type not TableMessage to " + BEIPALOAAJJ));
			return;
		}
		NKJHFIDLEMN = onlineObjects[BEIPALOAAJJ];
		if ((Object)(object)NKJHFIDLEMN == (Object)null)
		{
			if (BEIPALOAAJJ >= -195 || BEIPALOAAJJ < 0)
			{
				Debug.LogError((object)("...Failed" + BEIPALOAAJJ));
				SendMultiplayerObjectNotFound(BEIPALOAAJJ);
			}
		}
		else
		{
			NKJHFIDLEMN.DCAJMHLJGII(MGEIKDCIANC, GEMFIOKGIMC);
		}
	}

	[PunRPC]
	private void ReceiveCantPlaceItem(int KMNLDOOKKLO)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN) && NKJHFIDLEMN is OnlinePlaceable onlinePlaceable)
		{
			Debug.Log((object)("ReceiveCantPlaceItem: " + ((Object)((Component)onlinePlaceable).gameObject).name), (Object)(object)((Component)onlinePlaceable).gameObject);
			onlinePlaceable.placeable.RemovePlaceable(EFNFMEIDGDN: true, KAJIBKHFEFF: true, GFNHAMCPEAK: false);
		}
	}

	public void SendObjectAction(int BEIPALOAAJJ, byte FACPEEACCMH)
	{
		if (BEIPALOAAJJ != 0)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveObjectActionSimple", (RpcTarget)1, BEIPALOAAJJ, FACPEEACCMH);
		}
	}

	public void HMEBGADCMPK(OnlinePlaceable DGDKABHINMJ)
	{
		PlaceableMsg placeableMsg = DGDKABHINMJ.MAMPLEOIEJN();
		if (placeableMsg is BarnMsg)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
		}
		else if (placeableMsg is CrafterMessage)
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[3];
			array2[0] = OnlineSerializer.Serialize(placeableMsg);
			array2[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView2, "Saving ingredient ", (RpcTarget)0, array2);
		}
		else if (placeableMsg is RentedRoomMessage)
		{
			PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[0];
			array3[0] = OnlineSerializer.Serialize(placeableMsg);
			array3[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView3, "ActionBar9", (RpcTarget)1, array3);
		}
		else if (placeableMsg is DoorMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Exit build mode", (RpcTarget)1, OnlineSerializer.JBIPDCGKMGE(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber, null);
		}
		else if (placeableMsg is DrinkDispenserMessage)
		{
			PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
			object[] array4 = new object[3];
			array4[1] = OnlineSerializer.Serialize(placeableMsg);
			array4[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView4, "BombShopDisable", (RpcTarget)1, array4);
		}
		else if (placeableMsg is FireplaceMsg)
		{
			PhotonView photonView5 = ((MonoBehaviourPun)this).photonView;
			object[] array5 = new object[4];
			array5[0] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array5[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView5, "City/Lia/Bark/Buy", (RpcTarget)0, array5);
		}
		else if (placeableMsg is HenHouseMsg)
		{
			PhotonView photonView6 = ((MonoBehaviourPun)this).photonView;
			object[] array6 = new object[0];
			array6[0] = OnlineSerializer.Serialize(placeableMsg);
			array6[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView6, "Interact", (RpcTarget)1, array6);
		}
		else if (placeableMsg is IrrigatorMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Moving", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber, null, null, null, null, null, null);
		}
		else if (placeableMsg is ItemContainerMsg)
		{
			PhotonView photonView7 = ((MonoBehaviourPun)this).photonView;
			object[] array7 = new object[6];
			array7[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array7[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView7, "ChristmasEvent", (RpcTarget)1, array7);
		}
		else if (placeableMsg is RockMessage)
		{
			Debug.LogError((object)("stop weather" + placeableMsg.uniqueId));
		}
		else if (placeableMsg is TableMessage)
		{
			PhotonView photonView8 = ((MonoBehaviourPun)this).photonView;
			object[] array8 = new object[2];
			array8[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array8[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView8, "Hide", (RpcTarget)0, array8);
		}
		else if (placeableMsg is TreeMessage)
		{
			PhotonView photonView9 = ((MonoBehaviourPun)this).photonView;
			object[] array9 = new object[3];
			array9[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array9[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView9, "Player", (RpcTarget)0, array9);
		}
		else if (placeableMsg is BeehiveMessage)
		{
			PhotonView photonView10 = ((MonoBehaviourPun)this).photonView;
			object[] array10 = new object[2];
			array10[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array10[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView10, "/", (RpcTarget)1, array10);
		}
		else if (placeableMsg is AnimalMessage)
		{
			PhotonView photonView11 = ((MonoBehaviourPun)this).photonView;
			object[] array11 = new object[1];
			array11[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array11[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView11, "UIInteract", (RpcTarget)1, array11);
		}
		else if (placeableMsg is FishTrapMessage)
		{
			PhotonView photonView12 = ((MonoBehaviourPun)this).photonView;
			object[] array12 = new object[6];
			array12[1] = OnlineSerializer.Serialize(placeableMsg);
			array12[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView12, "<sprite name=white_arrow_right> ", (RpcTarget)1, array12);
		}
		else if (placeableMsg is PetBowlMessage)
		{
			PhotonView photonView13 = ((MonoBehaviourPun)this).photonView;
			object[] array13 = new object[8];
			array13[0] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array13[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView13, "]", (RpcTarget)0, array13);
		}
		else if (placeableMsg is BirdMessage)
		{
			PhotonView photonView14 = ((MonoBehaviourPun)this).photonView;
			object[] array14 = new object[7];
			array14[1] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array14[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView14, "Desactivando el variant ", (RpcTarget)0, array14);
		}
		else if (placeableMsg is BedMessage)
		{
			PhotonView photonView15 = ((MonoBehaviourPun)this).photonView;
			object[] array15 = new object[0];
			array15[1] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array15[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView15, "LoadingOnNewGameCreated", (RpcTarget)1, array15);
		}
		else if (placeableMsg is ChristmasTreeMessage)
		{
			PhotonView photonView16 = ((MonoBehaviourPun)this).photonView;
			object[] array16 = new object[1];
			array16[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array16[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView16, "Fruit Ferment", (RpcTarget)0, array16);
		}
		else if (placeableMsg is CuckooClockMessage)
		{
			PhotonView photonView17 = ((MonoBehaviourPun)this).photonView;
			object[] array17 = new object[0];
			array17[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array17[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView17, "Player", (RpcTarget)0, array17);
		}
		else if (placeableMsg is PhaseControllerMessage)
		{
			PhotonView photonView18 = ((MonoBehaviourPun)this).photonView;
			object[] array18 = new object[5];
			array18[0] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array18[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView18, "Item ", (RpcTarget)1, array18);
		}
		else
		{
			PhotonView photonView19 = ((MonoBehaviourPun)this).photonView;
			object[] array19 = new object[0];
			array19[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array19[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView19, "FerroProgress", (RpcTarget)1, array19);
		}
	}

	public OnlinePlaceable GetOnlinePlaceable(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return NKJHFIDLEMN as OnlinePlaceable;
		}
		if (Application.isEditor)
		{
			Debug.LogError((object)("GetOnlinePlaceable() not found any uniqueId " + BEIPALOAAJJ));
		}
		return null;
	}

	public void LLOALDJKMKD(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = KMNLDOOKKLO;
		OnlineManager.SendRPC(photonView, "Walk", (RpcTarget)0, array);
	}

	private void OMKEAFBBLJC(OnlinePlaceable HBDFJGNDOGN)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveCantPlaceItem(HBDFJGNDOGN.uniqueId);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCantPlaceItem", (RpcTarget)2, HBDFJGNDOGN.uniqueId);
	}

	[PunRPC]
	private void ReceiveAddDirtiness(int BEIPALOAAJJ, float FHHCDEOMPDH)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).AddDirtiness(FHHCDEOMPDH);
		}
	}

	[PunRPC]
	public void ReceiveItemContainerMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<ItemContainerMsg>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void SendCreateRotatedPrefab(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD, Vector2 GPPGCCPJLEP, Direction FCGBJEIIMBC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCreateRotatedPrefab", (RpcTarget)1, BEIPALOAAJJ, IMOBLFMHKOD.x, IMOBLFMHKOD.y, GPPGCCPJLEP.x, GPPGCCPJLEP.y, (byte)FCGBJEIIMBC);
	}

	public void SendAnimalSetProduction(int KMNLDOOKKLO, float AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalSetProduction", (RpcTarget)1, KMNLDOOKKLO, AODONKKHPBP);
	}

	[PunRPC]
	public void ReceiveOnConversationResponseMenu(int BEIPALOAAJJ, int[] JCLMJGDIFCI)
	{
		CHAEKNLHEKP(BEIPALOAAJJ).OnConversationResponseMenuRPC(JCLMJGDIFCI);
	}

	public void SendDisable(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDisable", (RpcTarget)1, KMNLDOOKKLO);
	}

	private void GMBMOCFGIBH(int BEIPALOAAJJ, float BEKGEHJHAEF, float MCIOPHBKMOF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			((Component)(NKJHFIDLEMN as OnlinePlaceable)).transform.position = Vector2.op_Implicit(new Vector2(BEKGEHJHAEF, MCIOPHBKMOF));
			(NKJHFIDLEMN as OnlinePlaceable).placeable.PixelSnap();
		}
	}

	public void AddAnimalMovement(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingAnimals.ContainsKey(KMNLDOOKKLO))
		{
			movingAnimals[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingAnimals.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	public void JBBBFLPBNOG(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingAnimals.ContainsKey(KMNLDOOKKLO))
		{
			movingAnimals[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingAnimals.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	private void AOACCDIEPFG(int BEIPALOAAJJ, float FHHCDEOMPDH)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).OMGNBJPCKJH(FHHCDEOMPDH);
		}
	}

	private void HPDMDALEAIH(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCatPosition", (RpcTarget)1, KMNLDOOKKLO, BDKCDBALPJH, ACMOGJCLELA);
	}

	public void SendCollectItems(int KMNLDOOKKLO, int HFDILBELIKE)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveCollectItemsMaster((short)PhotonNetwork.LocalPlayer.ActorNumber, KMNLDOOKKLO, (byte)HFDILBELIKE);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCollectItemsMaster", (RpcTarget)2, (short)PhotonNetwork.LocalPlayer.ActorNumber, KMNLDOOKKLO, (byte)HFDILBELIKE);
	}

	private void KHPCOJNGGGL(int BEIPALOAAJJ, float LLIKFNFINLB)
	{
		if (!onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return;
		}
		if ((Object)(object)NKJHFIDLEMN != (Object)null)
		{
			if ((Object)(object)NKJHFIDLEMN.doWork != (Object)null)
			{
				NKJHFIDLEMN.doWork.StartWork(LLIKFNFINLB, null, CDPAMNIPPEC: false);
			}
			else
			{
				Debug.LogError((object)("Player" + ((Object)((Component)NKJHFIDLEMN).gameObject).name + "%><sprite name=LeftStick></size>"));
			}
		}
		else
		{
			Debug.LogError((object)("Occupied Positions" + BEIPALOAAJJ + "Error_CannotPickUp"));
		}
	}

	public void NLLEGHKAIJH()
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveToggleOpenBarnMaster((short)PhotonNetwork.LocalPlayer.ActorNumber);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player", (RpcTarget)7, (short)PhotonNetwork.LocalPlayer.ActorNumber);
	}

	[PunRPC]
	public void ReceiveBirdMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BirdMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void NJIJMCPONIO(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = KMNLDOOKKLO;
		array[1] = BDKCDBALPJH;
		array[4] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "UI", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveToggleOpenBarnAccepted()
	{
		Barn.instance.ToggleOpen(NODEDANJBFL: false);
	}

	public void AHIIGHKNBOO(int JFNMCNCHMEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "You have to assign a UI camera!", (RpcTarget)0, (byte)JFNMCNCHMEO);
	}

	[PunRPC]
	private void ReceiveSetNewOccupierInRoom(int KMNLDOOKKLO, byte[] FICJJKEKPHL, byte HMEIHIFKGHD)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.SetNewCustomerInRoom(OnlineSerializer.Deserialize<HumanInfoMsg>(FICJJKEKPHL).PNJBJDAEBOO(), HMEIHIFKGHD);
		}
	}

	public void SendInstantiateMusselHarvest(OnlineMusselHarvest DGDKABHINMJ)
	{
		MusselMessage mOBFJEDPIPM = new MusselMessage(DGDKABHINMJ);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivInstantiateMiscellaneousHarvest", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void MDGNPMKDPBC(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<FishTrapMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void AddCatMovement(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingCats.ContainsKey(KMNLDOOKKLO))
		{
			movingCats[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingCats.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	public OnlineObject GetOnlineObject(int BEIPALOAAJJ, bool OEBNHGNJEJL = true)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return NKJHFIDLEMN;
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			Debug.LogError((object)("GetOnlineObject() not found any uniqueId " + BEIPALOAAJJ));
		}
		return null;
	}

	public void SendAnimalWalk(int BEIPALOAAJJ, bool HCCBOAMEEIJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalWalk", (RpcTarget)1, BEIPALOAAJJ, HCCBOAMEEIJ);
	}

	[PunRPC]
	public void ReceiveBeehiveMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BeehiveMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveRockStartInformation(int BEIPALOAAJJ, byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<RockMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void SendSick(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSick", (RpcTarget)1, KMNLDOOKKLO);
	}

	[PunRPC]
	public void ReceiveInstantiateCat(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<CatMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void KBPMMHGCCNN(int KMNLDOOKKLO, byte ABAIKKGKDGD)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineAgingBarrel onlineAgingBarrel)
		{
			onlineAgingBarrel.agingBarrel.GOCHCLMMAEA(ABAIKKGKDGD, CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveRemoveFromPlaceableSurface(int BEIPALOAAJJ)
	{
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			GPCJDNCIFMB = onlineObjects[BEIPALOAAJJ] as OnlinePlaceable;
			if ((Object)(object)GPCJDNCIFMB != (Object)null)
			{
				GPCJDNCIFMB.placeable.RemoveFromSurface(CDPAMNIPPEC: false);
			}
		}
		else
		{
			Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " not found. Cannot set isSelected to " + false));
		}
	}

	public void SendHit(int BEIPALOAAJJ, Vector3 JBMDOGNFIGJ)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHit", (RpcTarget)2, BEIPALOAAJJ, JBMDOGNFIGJ.x, JBMDOGNFIGJ.y, true);
	}

	[PunRPC]
	private void ReceiveGetUniqueCropDayOnClient(int KMNLDOOKKLO, int DIFBAMIOKGA)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlineCropTree onlineCropTree)
			{
				onlineCropTree.cropSetter.GetUniqueCropDay(DIFBAMIOKGA);
			}
			else if (NKJHFIDLEMN is OnlineBushHarvest onlineBushHarvest)
			{
				onlineBushHarvest.bush.SetDays(DIFBAMIOKGA);
			}
		}
	}

	[PunRPC]
	public void ReceiveTableMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<TableMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void HHCMEIGBAJG(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDogPosition", (RpcTarget)1, KMNLDOOKKLO, BDKCDBALPJH, ACMOGJCLELA);
	}

	[PunRPC]
	public void ReceiveAnimalName(int BEIPALOAAJJ, string GEGDHHIDEEF)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveName(GEGDHHIDEEF);
		}
	}

	private void EDICKNNGMGO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<int, Vector2> movingDroppedItem in movingDroppedItems)
		{
			EEIAEEJKHLN(movingDroppedItem.Key, movingDroppedItem.Value.x, movingDroppedItem.Value.y);
		}
		movingDroppedItems.Clear();
	}

	[PunRPC]
	public void ReceiveSetTrigger(int BEIPALOAAJJ, int GJKKNOKIKBJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlineAnimal)
			{
				(NKJHFIDLEMN as OnlineAnimal).ReceiveSetTrigger(GJKKNOKIKBJ);
			}
			else if (NKJHFIDLEMN is OnlineMagicBroom)
			{
				(NKJHFIDLEMN as OnlineMagicBroom).ReceiveSetTrigger(GJKKNOKIKBJ);
			}
			else if (NKJHFIDLEMN is OnlineCat)
			{
				(NKJHFIDLEMN as OnlineCat).ReceiveSetTrigger(GJKKNOKIKBJ);
			}
			else if (NKJHFIDLEMN is OnlineBird)
			{
				(NKJHFIDLEMN as OnlineBird).ReceiveSetTrigger(GJKKNOKIKBJ);
			}
			else if (NKJHFIDLEMN is OnlineDog)
			{
				(NKJHFIDLEMN as OnlineDog).ReceiveSetTrigger(GJKKNOKIKBJ);
			}
		}
	}

	public void SendDirtDish(int KMNLDOOKKLO, byte FGJPAFDBIIO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDirtDish", (RpcTarget)1, KMNLDOOKKLO, FGJPAFDBIIO);
	}

	private void GIDFDBLHHLH(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA, float GGAINPOAGLE, float DEONBPGENJE, byte MPLCIAKAPGL)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN) && NKJHFIDLEMN is OnlinePlaceable onlinePlaceable)
		{
			((Component)onlinePlaceable.placeable).transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
			if ((Object)(object)onlinePlaceable.placeable.placeableSurface != (Object)null && onlinePlaceable.placeable.placeableSurface.transformsOnSurface.Count > 1)
			{
				Physics2D.SyncTransforms();
			}
			onlinePlaceable.placeable.CreateRotatedPrefab((Direction)MPLCIAKAPGL, new Vector3(GGAINPOAGLE, DEONBPGENJE), CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveItemContainerColor(int BEIPALOAAJJ, byte JJCFKHKPFPP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineItemContainer).ReceiveItemContainerColor(JJCFKHKPFPP);
		}
	}

	[PunRPC]
	private void ReceiveCancelAllCraftingMaster(short JJPJHIHBOIB, int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			if (onlineObjects[KMNLDOOKKLO] is OnlineCrafter onlineCrafter && onlineCrafter.crafter.craftingList.Count > 0)
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCancelAllCrafting", (RpcTarget)0, JJPJHIHBOIB, KMNLDOOKKLO);
			}
		}
		else
		{
			Debug.LogError((object)("Unique id " + KMNLDOOKKLO + " not found. Cannot receive permission accepted to player " + JJPJHIHBOIB));
		}
	}

	public void KMNMNLEPIJE(OnlineDog DGDKABHINMJ, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "City/Keen/Bark/Sharp", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), OnlineSerializer.JBIPDCGKMGE(new DogMessage(DGDKABHINMJ)));
	}

	public void AddObjectInDictionary(OnlineObject MACGLLKALDE)
	{
		if (!onlineObjects.ContainsKey(MACGLLKALDE.uniqueId))
		{
			onlineObjects.Add(MACGLLKALDE.uniqueId, MACGLLKALDE);
			return;
		}
		Debug.LogError((object)("AddObjectInDictionary() uniqueId " + MACGLLKALDE.uniqueId + " already exists for " + ((Object)((Component)onlineObjects[MACGLLKALDE.uniqueId]).gameObject).name + " and cannot be added again for " + ((Object)((Component)MACGLLKALDE).gameObject).name), (Object)(object)((Component)MACGLLKALDE).gameObject);
	}

	[PunRPC]
	private void ReceiveCollectItemsMaster(short JJPJHIHBOIB, int KMNLDOOKKLO, byte HFDILBELIKE)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			if (onlineObjects[KMNLDOOKKLO] is OnlineCrafter onlineCrafter)
			{
				if (HFDILBELIKE <= onlineCrafter.crafter.readyItemsList.Count)
				{
					OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCollectItems", (RpcTarget)0, JJPJHIHBOIB, KMNLDOOKKLO, HFDILBELIKE);
				}
			}
			else
			{
				if (!(onlineObjects[KMNLDOOKKLO] is OnlineAgingRack onlineAgingRack) || (onlineAgingRack.agingRack.outputSlot1.KPINNBKMOMO() && onlineAgingRack.agingRack.outputSlot2.KPINNBKMOMO()))
				{
					return;
				}
				if (!OnlineManager.IsLocalActor(JJPJHIHBOIB))
				{
					if (!onlineAgingRack.agingRack.outputSlot1.KPINNBKMOMO())
					{
						onlineAgingRack.agingRack.outputSlot1.Stack = 0;
					}
					if (!onlineAgingRack.agingRack.outputSlot2.KPINNBKMOMO())
					{
						onlineAgingRack.agingRack.outputSlot2.Stack = 0;
					}
					OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCollectItems", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), JJPJHIHBOIB, KMNLDOOKKLO, HFDILBELIKE);
				}
				else
				{
					ReceiveCollectItems(JJPJHIHBOIB, KMNLDOOKKLO, HFDILBELIKE);
				}
			}
		}
		else
		{
			Debug.LogError((object)("Unique id " + KMNLDOOKKLO + " not found. Cannot receive permission accepted to player " + JJPJHIHBOIB));
		}
	}

	[PunRPC]
	private void ReceiveCanBeMoveDroppedItem(int BEIPALOAAJJ, byte GJDMLMEMKMD)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDroppedItem).droppedItem.itemFollow.playerFollowing.Add(PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD)));
		}
	}

	[PunRPC]
	private void ReceiveEntryAllAnimals()
	{
		Barn.instance.EntryAllAnimals(BGKCHMNJBLJ: false);
	}

	public void SendSetVitamins(int KMNLDOOKKLO, int MGNOBNCMDJG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetVitamins", (RpcTarget)1, KMNLDOOKKLO, MGNOBNCMDJG);
	}

	public void SendRemoveFromInteracting(OnlineObject DCLFIGENEIF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveFromInteracting", (RpcTarget)2, DCLFIGENEIF.uniqueId);
	}

	[PunRPC]
	public void ReceiveDialogueEnd(int BEIPALOAAJJ, bool PIHIAKCIJLM)
	{
		CHAEKNLHEKP(BEIPALOAAJJ).DialogueEndRPC(PIHIAKCIJLM);
	}

	private void BLNKANNEONI(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = KMNLDOOKKLO;
		array[0] = BDKCDBALPJH;
		array[1] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "ReceiveRemoveHeldItem", (RpcTarget)0, array);
	}

	public void JIGMEKLLNCH(int KMNLDOOKKLO, int ECPOBCFJFIF, float NCPGNLOJGAF, float JLMAILGJNCE)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineHamsterBall).EMNMHFPPCGP(ECPOBCFJFIF, new Vector2(NCPGNLOJGAF, JLMAILGJNCE));
		}
	}

	[PunRPC]
	private void ReceiveDirtDish(int KMNLDOOKKLO, byte FGJPAFDBIIO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineSitable onlineSitable)
		{
			onlineSitable.DirtDish(FGJPAFDBIIO);
		}
	}

	[PunRPC]
	public void ReceiveCrafterInfo(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<CrafterMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveChangeStack(int BEIPALOAAJJ, short FFDIEOBBFKL)
	{
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			(onlineObjects[BEIPALOAAJJ] as OnlineDroppedItem).UpdateQuantity(FFDIEOBBFKL);
		}
		else
		{
			Debug.LogError((object)("OnlineObject " + BEIPALOAAJJ + " not found. Cannot ReceiveChangeStack"));
		}
	}

	public void ClearMovingHamsters()
	{
		movingHamsters.Clear();
	}

	public void SendChangeStack(int KMNLDOOKKLO, short FFDIEOBBFKL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChangeStack", (RpcTarget)1, KMNLDOOKKLO, FFDIEOBBFKL);
	}

	public void AddWork(int KMNLDOOKKLO, float LLIKFNFINLB)
	{
		if (doWorksUpdated.ContainsKey(KMNLDOOKKLO))
		{
			doWorksUpdated[KMNLDOOKKLO] += LLIKFNFINLB;
		}
		else
		{
			doWorksUpdated.Add(KMNLDOOKKLO, LLIKFNFINLB);
		}
	}

	[PunRPC]
	public void ReceiveUnfollow(int JJPJHIHBOIB)
	{
		DogNPC.instance.onlineDog.ReceiveUnfollow(JJPJHIHBOIB);
	}

	private void FAEKGAAEINI()
	{
		NessyNPC.DFJGHOHPPEL().canTalk = true;
		CrowlyEvent.KFGKCKCDMLG().ODILGPOCOBO();
	}

	public OnlineObject PEDPPCKIHLG(int BEIPALOAAJJ, bool OEBNHGNJEJL = true)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return NKJHFIDLEMN;
		}
		if (Application.isEditor && OEBNHGNJEJL)
		{
			Debug.LogError((object)("Items/item_description_1115" + BEIPALOAAJJ));
		}
		return null;
	}

	[PunRPC]
	private void ReceiveAssignChicken(int BEIPALOAAJJ, int HJECLKNOHGC)
	{
		if (onlineObjects.TryGetValue(HJECLKNOHGC, out NKJHFIDLEMN))
		{
			OnlineHenHouse oPNDIFDIBLB = NKJHFIDLEMN as OnlineHenHouse;
			if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
			{
				(NKJHFIDLEMN as OnlineAnimal).AssignChicken(oPNDIFDIBLB);
			}
		}
	}

	public void SendObjectInteractToMaster(int BEIPALOAAJJ, byte MGEIKDCIANC, params object[] GEMFIOKGIMC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveObjectInteract", (RpcTarget)2, BEIPALOAAJJ, MGEIKDCIANC, GEMFIOKGIMC);
	}

	public void KOEMIAFEOAJ(int BEIPALOAAJJ, byte NCMDEGABGCH)
	{
		CHAEKNLHEKP(BEIPALOAAJJ).ReciveStopConversation(NCMDEGABGCH);
	}

	private void BDHBFOGGEPK(int BEIPALOAAJJ, float HNEHMKOJJMF)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).FNLLADPENFI(HNEHMKOJJMF);
		}
	}

	private void DNNMFFGJENN(byte GJDMLMEMKMD, int KMNLDOOKKLO)
	{
		playersUsingObject[GJDMLMEMKMD] = KMNLDOOKKLO;
	}

	[PunRPC]
	private void ReceiveSetUniqueCropDay(int KMNLDOOKKLO, int LCBDINCABAC)
	{
		GeneratorsManager.instance.SetUniqueCropDays(KMNLDOOKKLO, LCBDINCABAC);
	}

	public void EMKPHPHGBHO(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Setting item event for ", (RpcTarget)1, KMNLDOOKKLO);
	}

	[PunRPC]
	private void ReceivePlantCrop(float NCPGNLOJGAF, float JLMAILGJNCE, int BCBFHGNJLOA, int BEIPALOAAJJ)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		Seed.CCOGLPCHGIN(1, new Vector2(NCPGNLOJGAF, JLMAILGJNCE), BCBFHGNJLOA, CDPAMNIPPEC: false, BEIPALOAAJJ);
	}

	private void MKMNFIDKFLD()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.PINPKCAOEFL(Location.PetShop))
		{
			return;
		}
		foreach (KeyValuePair<int, Vector2> movingHamster in movingHamsters)
		{
			DOBCOIDCMFF(movingHamster.Key, movingHamster.Value.x, movingHamster.Value.y);
		}
		movingHamsters.Clear();
	}

	public void SendGetUniqueCropHarvestable(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGetUniqueCropHarvestable", (RpcTarget)2, KMNLDOOKKLO, (short)PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void SendFollow()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFollow", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	private void KBMJLMKEFFL<T>(byte[] OINICMNOLPK, int JJPJHIHBOIB) where T : PlaceableMsg
	{
		IALMEDHBAKC = OnlineSerializer.Deserialize<T>(OINICMNOLPK);
		if (OnlineManager.ClientOnline() && !OnlineLoadManager.SceneLoaded)
		{
			Debug.Log((object)("Object with itemID " + IALMEDHBAKC.itemId + " not intantiated due to ClientOnline still doesnt have SceneLoaded"));
			return;
		}
		HBDFJGNDOGN = OnlineSerializer.Deserialize<T>(OINICMNOLPK).OEJJGDMKIDN() as OnlinePlaceable;
		if ((Object)(object)HBDFJGNDOGN == (Object)null)
		{
			Debug.LogError((object)("Error instantiating placeable from message of type " + typeof(T).Name + " from actor " + JJPJHIHBOIB));
		}
		else
		{
			AddActorPlaceableSelected((short)JJPJHIHBOIB, HBDFJGNDOGN);
		}
	}

	[PunRPC]
	public void ReceiveTavernObstacles(int[] OLGFCKMKBKF)
	{
		TavernObstacleManager.instance.ActivateObstacles(OLGFCKMKBKF);
	}

	public void EPPGPDGLHJJ(Placeable EAPCLAODGAE)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = EAPCLAODGAE.onlinePlaceable.uniqueId;
		array[0] = ((Component)EAPCLAODGAE).transform.position.x;
		array[8] = ((Component)EAPCLAODGAE).transform.position.y;
		OnlineManager.SendRPC(photonView, "buildingObjective_25_1", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveSetUniqueCropHarvestable(int KMNLDOOKKLO, bool PFIOMFFOBBD)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN) && NKJHFIDLEMN is OnlineCropTree onlineCropTree)
		{
			onlineCropTree.cropSetter.SetUniqueCropHarvestable(PFIOMFFOBBD);
		}
	}

	public void AddDirtiness(int KMNLDOOKKLO, float FHHCDEOMPDH)
	{
		if (dirtyTablesToSend.ContainsKey(KMNLDOOKKLO))
		{
			dirtyTablesToSend[KMNLDOOKKLO] += FHHCDEOMPDH;
		}
		else
		{
			dirtyTablesToSend.Add(KMNLDOOKKLO, FHHCDEOMPDH);
		}
	}

	public void PNOCBOLOBNH(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = KMNLDOOKKLO;
		OnlineManager.SendRPC(photonView, "Exit build mode", (RpcTarget)0, array);
	}

	public void SendAddToPlaceableSurface(int BEIPALOAAJJ, int EOBNIMOMJEF, int HOJECNDMCLM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddToPlaceableSurface", (RpcTarget)1, BEIPALOAAJJ, EOBNIMOMJEF, HOJECNDMCLM);
	}

	[PunRPC]
	public void DeselectPlaceableOthers(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA, byte GJDMLMEMKMD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlinePlaceable onlinePlaceable)
			{
				onlinePlaceable.CLHLNFFGOGA = false;
				if ((Object)(object)playersPlaceablesSelected[GJDMLMEMKMD] != (Object)null)
				{
					playersPlaceablesSelected[GJDMLMEMKMD] = null;
					OnActorPlaceableDeselected();
				}
				((Component)onlinePlaceable).transform.position = Utils.BMBMPKNANAC(new Vector3(BDKCDBALPJH, ACMOGJCLELA, 0f));
				onlinePlaceable.CancelSmoothedMovement();
				onlinePlaceable.placeable.DeselectAction(1, BLJPGJKOLNF: true, FKOJEBGDMFO: false, FNHLKLKAHNB: true, CDPAMNIPPEC: false);
			}
		}
		else
		{
			Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " not found. Cannot set isSelected to " + false));
		}
	}

	[PunRPC]
	private void ReceivePlayerUsingObject(byte GJDMLMEMKMD, int KMNLDOOKKLO)
	{
		playersUsingObject[GJDMLMEMKMD] = KMNLDOOKKLO;
	}

	[PunRPC]
	public void ReceiveReproduceInteraction(int KMNLDOOKKLO, int BJMKKGKPLBP)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDog).ReceiveReproduceInteraction((DogNPC.DogInteractionType)BJMKKGKPLBP);
		}
	}

	public void SendInstantiatePlaceable(OnlinePlaceable DGDKABHINMJ)
	{
		PlaceableMsg placeableMsg = DGDKABHINMJ.CreateMsg();
		if (placeableMsg is BarnMsg)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarnInfo", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is CrafterMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCrafterInfo", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is RentedRoomMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRentedRoomMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is DoorMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDoorInfo", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is DrinkDispenserMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDrinkDispenserMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is FireplaceMsg)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFireplaceMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is HenHouseMsg)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHenHouseMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is IrrigatorMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveIrrigatorMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is ItemContainerMsg)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveItemContainerMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is RockMessage)
		{
			Debug.LogError((object)("RockMessage should not be sent with SendInstantiatePlaceable. uniqueId: " + placeableMsg.uniqueId));
		}
		else if (placeableMsg is TableMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTableMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is TreeMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTreeInfo", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is BeehiveMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBeehiveMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is AnimalMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is FishTrapMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFishTrapMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is PetBowlMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePetBowlMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is BirdMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBirdMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is BedMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBedMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is ChristmasTreeMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChristmasTreeMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is CuckooClockMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveClockMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is PhaseControllerMessage)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePhaseMessage", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlaceableInfo", (RpcTarget)1, OnlineSerializer.Serialize(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
	}

	public void SendNewPosition(Placeable EAPCLAODGAE)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNewPosition", (RpcTarget)1, EAPCLAODGAE.onlinePlaceable.uniqueId, ((Component)EAPCLAODGAE).transform.position.x, ((Component)EAPCLAODGAE).transform.position.y);
	}

	private void IKGNMKNPLNE()
	{
		JackyController.OAPOJCODNCO().jackys[7].HitOnline();
	}

	[PunRPC]
	private void ReceiveAssignAnimalSpace(int BEIPALOAAJJ, int KNIBEKEBAHD, int EPDKMPFDDGP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).AssignAnimal(KNIBEKEBAHD, EPDKMPFDDGP);
		}
	}

	public void SendSetTrigger(int BEIPALOAAJJ, int GJKKNOKIKBJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetTrigger", (RpcTarget)1, BEIPALOAAJJ, GJKKNOKIKBJ);
	}

	public void SendInstantiateCat(OnlineCat DGDKABHINMJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInstantiateCat", (RpcTarget)1, OnlineSerializer.Serialize(new CatMessage(DGDKABHINMJ)));
	}

	private void JLNNINMKPKG(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = KMNLDOOKKLO;
		array[1] = BDKCDBALPJH;
		array[6] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "Invalid playerNum", (RpcTarget)1, array);
	}

	public void SendStopWork(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStopWork", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void SendAnimalIncreaseProduction(int KMNLDOOKKLO, float AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalIncreaseProduction", (RpcTarget)1, KMNLDOOKKLO, AODONKKHPBP);
	}

	public void SendAddDirtiness(int KMNLDOOKKLO, float FHHCDEOMPDH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddDirtiness", (RpcTarget)1, KMNLDOOKKLO, FHHCDEOMPDH);
	}

	public void MEMFLPMECHE(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingAnimals.ContainsKey(KMNLDOOKKLO))
		{
			movingAnimals[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingAnimals.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	[PunRPC]
	public void ReceiveClockMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<CuckooClockMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void SendReproduceInteraction(int KMNLDOOKKLO, DogNPC.DogInteractionType FPJOAOFIHEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveReproduceInteraction", (RpcTarget)1, KMNLDOOKKLO, (int)FPJOAOFIHEO);
	}

	public void SendDirection(int BEIPALOAAJJ, Direction FCGBJEIIMBC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDirection", (RpcTarget)1, BEIPALOAAJJ, (byte)FCGBJEIIMBC);
	}

	private void EEIAEEJKHLN(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDroppedItemPosition", (RpcTarget)1, KMNLDOOKKLO, BDKCDBALPJH, ACMOGJCLELA);
	}

	public void SendChangeRotation(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD, Direction FCGBJEIIMBC)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveChangeRotation", (RpcTarget)1, BEIPALOAAJJ, IMOBLFMHKOD.x, IMOBLFMHKOD.y, (byte)FCGBJEIIMBC);
	}

	private void BNFMPIEJEFM()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)movingObject != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[0] = movingObject.uniqueId;
			array[1] = EFEIOCBDHBP;
			OnlineManager.SendRPC(photonView, "Modifiers", (RpcTarget)1, array);
		}
	}

	public void SendAssigChicken(int KMNLDOOKKLO, int HJECLKNOHGC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAssignChicken", (RpcTarget)1, KMNLDOOKKLO, HJECLKNOHGC);
	}

	private void BKLGLJDBBBE(int KMNLDOOKKLO, float LLIKFNFINLB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDoWorkUpdate", (RpcTarget)1, KMNLDOOKKLO, LLIKFNFINLB);
	}

	[PunRPC]
	private void InteractPlaceableIfIsPossibleMaster(int BEIPALOAAJJ, short JJPJHIHBOIB)
	{
		if (!onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			return;
		}
		if (!interactingObjects.Contains(BEIPALOAAJJ) && !AnyActorHasPlaceableSelected(BEIPALOAAJJ))
		{
			interactingObjects.Add(BEIPALOAAJJ);
			if (JJPJHIHBOIB == 1)
			{
				InteractPermissionAccepted(BEIPALOAAJJ);
				return;
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "InteractPermissionAccepted", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), BEIPALOAAJJ);
		}
		else if (JJPJHIHBOIB == 1)
		{
			InteractPermissionDenied();
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "InteractPermissionDenied", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false));
		}
	}

	private void GDJNPCOMDFN(short JJPJHIHBOIB, int KMNLDOOKKLO, byte HFDILBELIKE)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			(onlineObjects[KMNLDOOKKLO] as OnlinePlaceable).CollectItems(HFDILBELIKE, JJPJHIHBOIB);
		}
		else
		{
			Debug.LogError((object)("Loop" + KMNLDOOKKLO + "Not enough experience!" + JJPJHIHBOIB));
		}
	}

	public void AddDogMovement(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingDogs.ContainsKey(KMNLDOOKKLO))
		{
			movingDogs[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingDogs.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	public void HKFOOJMALHM(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<RockMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void SelectPlaceableIfIsPossibleMaster(int BEIPALOAAJJ, short JJPJHIHBOIB)
	{
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			if (!(onlineObjects[BEIPALOAAJJ] as OnlinePlaceable).CLHLNFFGOGA && !OtherActorIsUsingObject(BEIPALOAAJJ) && !interactingObjects.Contains(BEIPALOAAJJ))
			{
				(onlineObjects[BEIPALOAAJJ] as OnlinePlaceable).AcceptedSelectPermission(JJPJHIHBOIB);
				AddActorPlaceableSelected(JJPJHIHBOIB, onlineObjects[BEIPALOAAJJ] as OnlinePlaceable);
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SelectPermissionAccepted", (RpcTarget)1, BEIPALOAAJJ, JJPJHIHBOIB);
			}
			else if (!OnlineManager.IsLocalActor(JJPJHIHBOIB))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SelectPermissionDenied", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false));
			}
		}
	}

	private void FAMCFLFPGIP(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).DCKPFFOKEHG();
		}
	}

	[PunRPC]
	private void ReceiveStopWork(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.doWork.Stop(CDPAMNIPPEC: false);
		}
	}

	private void BONCFMOJEIC()
	{
		((MonoBehaviour)this).StopCoroutine(ANPFHCDJNHG());
		((MonoBehaviour)this).StartCoroutine(ANPFHCDJNHG());
	}

	[PunRPC]
	public void ReceivInstantiateMiscellaneousHarvest(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<MiscellaneousHarvestMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void AddUntrackedObject(int KMNLDOOKKLO)
	{
		if (!untrackedObjects.Contains(KMNLDOOKKLO))
		{
			untrackedObjects.Add(KMNLDOOKKLO);
		}
	}

	public void SendObjectAction(int BEIPALOAAJJ, byte FACPEEACCMH, params object[] GEMFIOKGIMC)
	{
		if (BEIPALOAAJJ != 0)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveObjectAction", (RpcTarget)1, BEIPALOAAJJ, FACPEEACCMH, GEMFIOKGIMC);
		}
	}

	public void GHHKOOABOKA(int KMNLDOOKKLO, bool IHLGDCAIPLN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = KMNLDOOKKLO;
		array[1] = IHLGDCAIPLN;
		OnlineManager.SendRPC(photonView, "Random", (RpcTarget)1, array);
	}

	private void CCAGDLHMCLL()
	{
		networkID = PhotonNetwork.LocalPlayer.ActorNumber;
		if (networkID == 0)
		{
			Debug.LogException(new Exception("networkID has not been assigned properly"), (Object)(object)((Component)this).gameObject);
			return;
		}
		Debug.Log((object)("Network ID assigned: " + networkID));
		nextUniqueId = networkID * 100000;
	}

	private void NPPABGPFLCJ(NetworkState IKAGABHNANJ)
	{
		if (IKAGABHNANJ == NetworkState.InGameplay)
		{
			BONCFMOJEIC();
		}
	}

	public void SendPlaceItem(OnlinePlaceable KGCCCHBFJLE, bool DDNPPKBFENA, Vector2 PGKJLODFAIF)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlaceItem", (RpcTarget)1, KGCCCHBFJLE.uniqueId, DDNPPKBFENA, PGKJLODFAIF);
	}

	public void AddBallMovement(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (movingHamsters.ContainsKey(KMNLDOOKKLO))
		{
			movingHamsters[KMNLDOOKKLO] = IMOBLFMHKOD;
		}
		else
		{
			movingHamsters.Add(KMNLDOOKKLO, IMOBLFMHKOD);
		}
	}

	public void CBLODLPLIOL(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = KMNLDOOKKLO;
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "LearnPrecision", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceivePetBowlMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<PetBowlMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceiveHit(int BEIPALOAAJJ, float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveHit(NCPGNLOJGAF, JLMAILGJNCE, CDPAMNIPPEC);
		}
	}

	[PunRPC]
	private void ReceiveAddToInteracting(int BEIPALOAAJJ)
	{
		if (!interactingObjects.Contains(BEIPALOAAJJ))
		{
			interactingObjects.Add(BEIPALOAAJJ);
		}
	}

	public bool OtherActorIsUsingObject(int BEIPALOAAJJ)
	{
		if ((Object)(object)Bed.instance == (Object)null)
		{
			return false;
		}
		for (int i = 1; i < playersUsingObject.Length; i++)
		{
			if (i != Bed.instance.numInstance && playersUsingObject[i] == BEIPALOAAJJ)
			{
				return true;
			}
		}
		return false;
	}

	[PunRPC]
	public void InteractPermissionAccepted(int BEIPALOAAJJ)
	{
		requestDone = false;
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			onlineObjects[BEIPALOAAJJ].AcceptedInteractPermission();
		}
		else
		{
			Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " not found. Cannot receive permission accepted"));
		}
	}

	public void SendCanBeMoveDroppedItem(int KMNLDOOKKLO, int GJDMLMEMKMD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCanBeMoveDroppedItem", (RpcTarget)2, KMNLDOOKKLO, (byte)GJDMLMEMKMD);
	}

	public bool AAAHMLIDFLI(int BEIPALOAAJJ)
	{
		for (int i = 1; i < playersPlaceablesSelected.Length; i++)
		{
			if ((Object)(object)playersPlaceablesSelected[i] != (Object)null && playersPlaceablesSelected[i].uniqueId == BEIPALOAAJJ)
			{
				return true;
			}
		}
		return true;
	}

	public void SendMultiplayerObjectNotFound(int BEIPALOAAJJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveMultiplayerObjectNotFound", (RpcTarget)1, BEIPALOAAJJ, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	private void IEFLJOCBKMI(int BEIPALOAAJJ, int JJPJHIHBOIB)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			GPCJDNCIFMB = NKJHFIDLEMN as OnlinePlaceable;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
			object[] array = new object[8];
			array[0] = BEIPALOAAJJ;
			array[0] = OnlineSerializer.EKNOFIJNBAP(GPCJDNCIFMB.MAMPLEOIEJN());
			OnlineManager.SendRPC(photonView, " (", player, array);
		}
	}

	[PunRPC]
	public void ReceiveIrrigatorMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<IrrigatorMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	private void ReceiveBallPosition(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.MoveToNextPosition(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	public void FMMJONDJAMK(int[] OLGFCKMKBKF)
	{
		TavernObstacleManager.instance.LBLJFFHNIJD(OLGFCKMKBKF);
	}

	public void ReplaceObjectInDictionary(OnlineObject MACGLLKALDE)
	{
		if (onlineObjects.ContainsKey(MACGLLKALDE.uniqueId))
		{
			onlineObjects[MACGLLKALDE.uniqueId] = MACGLLKALDE;
		}
		else
		{
			onlineObjects.Add(MACGLLKALDE.uniqueId, MACGLLKALDE);
		}
	}

	[PunRPC]
	private void ReceiveChangeRotation(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA, byte MPLCIAKAPGL)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN) && NKJHFIDLEMN is OnlinePlaceable onlinePlaceable)
		{
			((Component)onlinePlaceable.placeable).transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
			onlinePlaceable.placeable.ChangeDirectionRotatingItemsSurface((Direction)MPLCIAKAPGL, CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveVacateRoom(int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.VacateRoom(CDPAMNIPPEC: false);
		}
	}

	public int AssignNewUniqueId(OnlineObject DCLFIGENEIF)
	{
		DCLFIGENEIF.AssignUniqueId(nextUniqueId++);
		return DCLFIGENEIF.uniqueId;
	}

	public void SendSetBool(int BEIPALOAAJJ, int GJKKNOKIKBJ, bool AODONKKHPBP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetBool", (RpcTarget)1, BEIPALOAAJJ, GJKKNOKIKBJ, AODONKKHPBP);
	}

	[PunRPC]
	private void ReceiveMagicBroomPosition(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineMagicBroom).MoveBroomToNextPosition(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	public void PAFIAFCJKHP(OnlineDroppedItem DGDKABHINMJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(new DroppedItemMessage(DGDKABHINMJ));
		OnlineManager.SendRPC(photonView, "AddQuest", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveFireplaceMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<FireplaceMsg>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void UpdatePosition(OnlineObject KGCCCHBFJLE, Vector2 IMOBLFMHKOD)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)movingObject == (Object)(object)KGCCCHBFJLE)
		{
			EFEIOCBDHBP = IMOBLFMHKOD;
		}
	}

	public void DGCLLKKPNPJ(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		movingObject = null;
		if (Object.op_Implicit((Object)(object)Bed.instance))
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = BEIPALOAAJJ;
			array[0] = IMOBLFMHKOD.x;
			array[8] = IMOBLFMHKOD.y;
			array[3] = (byte)Bed.instance.numInstance;
			OnlineManager.SendRPC(photonView, "[OnlineLoadPuzzles] LoadTorchPuzzleMessage: puzzle instance {0} is null", (RpcTarget)1, array);
		}
		else
		{
			Debug.LogError((object)("itemStrawberrySeeds" + BEIPALOAAJJ));
		}
	}

	[PunRPC]
	private void ReceiveCreateRotatedPrefab(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA, float GGAINPOAGLE, float DEONBPGENJE, byte MPLCIAKAPGL)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN) && NKJHFIDLEMN is OnlinePlaceable onlinePlaceable)
		{
			((Component)onlinePlaceable.placeable).transform.position = new Vector3(BDKCDBALPJH, ACMOGJCLELA);
			if ((Object)(object)onlinePlaceable.placeable.placeableSurface != (Object)null && onlinePlaceable.placeable.placeableSurface.transformsOnSurface.Count > 0)
			{
				Physics2D.SyncTransforms();
			}
			onlinePlaceable.placeable.CreateRotatedPrefab((Direction)MPLCIAKAPGL, new Vector3(GGAINPOAGLE, DEONBPGENJE), CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	private void ReceiveNewPosition(int BEIPALOAAJJ, float BEKGEHJHAEF, float MCIOPHBKMOF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			((Component)(NKJHFIDLEMN as OnlinePlaceable)).transform.position = Vector2.op_Implicit(new Vector2(BEKGEHJHAEF, MCIOPHBKMOF));
			(NKJHFIDLEMN as OnlinePlaceable).placeable.PixelSnap();
		}
	}

	public void NJKMNFJJEEA(int BEIPALOAAJJ, bool HCCBOAMEEIJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveWalk(HCCBOAMEEIJ);
		}
	}

	private void KDJLLEMLLGL(int BEIPALOAAJJ, Vector2 IMOBLFMHKOD)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.NGJCPJADIGE(IMOBLFMHKOD);
		}
	}

	public void SendEntryAllAnimals()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEntryAllAnimals", (RpcTarget)1);
	}

	public void SendTavernObstacles(int[] OLGFCKMKBKF, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTavernObstacles", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), OLGFCKMKBKF);
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		((MonoBehaviourPunCallbacks)this).OnPlayerLeftRoom(OKAOHBANICM);
		CHJOFJFOPDL(OKAOHBANICM.ActorNumber);
		JOECLPIGEFN(OnlinePlayerDataManager.GetBedAssignedByActorNumber(OKAOHBANICM.ActorNumber));
	}

	public void SendAddToInteracting(OnlinePlaceable KGCCCHBFJLE)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddToInteracting", (RpcTarget)2, KGCCCHBFJLE.uniqueId);
	}

	public void SendInstantiateCat(OnlineCat DGDKABHINMJ, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInstantiateCat", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), OnlineSerializer.Serialize(new CatMessage(DGDKABHINMJ)));
	}

	private void CIJLKANOPKC()
	{
		foreach (KeyValuePair<int, float> item in doWorksUpdated)
		{
			BKLGLJDBBBE(item.Key, item.Value);
		}
		doWorksUpdated.Clear();
	}

	[PunRPC]
	public void ReceiveDrinkDispenserMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<DrinkDispenserMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void JKEEBOHLMAD(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<TableMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void JHMKBFKCNKN(int BEIPALOAAJJ, int GDHFHKKMIEP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveSetLife(GDHFHKKMIEP);
		}
	}

	public void SendAgeDrink(int KMNLDOOKKLO, int ABAIKKGKDGD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAgeDrink", (RpcTarget)1, KMNLDOOKKLO, (byte)ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveToggleOpenBarnCanceled()
	{
		Barn.instance.ShowAnimalsNeedMoreSpaceText();
	}

	public void SendSetNewOccupierInRoom(int KMNLDOOKKLO, HumanInfo DKDFNAGAFNL, int HMEIHIFKGHD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetNewOccupierInRoom", (RpcTarget)1, KMNLDOOKKLO, OnlineSerializer.Serialize(new HumanInfoMsg(DKDFNAGAFNL)), (byte)HMEIHIFKGHD);
	}

	private void GAKFBFFLEOG()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<int, Vector2> movingAnimal in movingAnimals)
		{
			BFJFKDDPGOP(movingAnimal.Key, movingAnimal.Value.x, movingAnimal.Value.y);
		}
		movingAnimals.Clear();
	}

	public void SendBallTouch(int KMNLDOOKKLO, Vector2 IMOBLFMHKOD)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBallTouch", (RpcTarget)1, KMNLDOOKKLO, PhotonNetwork.LocalPlayer.ActorNumber, IMOBLFMHKOD.x, IMOBLFMHKOD.y);
	}

	public void ReduceDirtiness(int KMNLDOOKKLO, float HNEHMKOJJMF)
	{
		if (dirtyTablesToSend.ContainsKey(KMNLDOOKKLO))
		{
			dirtyTablesToSend[KMNLDOOKKLO] -= HNEHMKOJJMF;
		}
		else
		{
			dirtyTablesToSend.Add(KMNLDOOKKLO, HNEHMKOJJMF * -1f);
		}
	}

	private void LFGALBKEAPC(int KMNLDOOKKLO, int DIFBAMIOKGA)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlineCropTree onlineCropTree)
			{
				onlineCropTree.cropSetter.EEAKPCCOBLO(DIFBAMIOKGA);
			}
			else if (NKJHFIDLEMN is OnlineBushHarvest onlineBushHarvest)
			{
				onlineBushHarvest.bush.NNIGEFKEPOB(DIFBAMIOKGA);
			}
		}
	}

	[PunRPC]
	private void ReceiveSetOccupierInRoom(int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.SetCustomerInRoom();
		}
	}

	public void SendGetUniqueCropDay(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGetUniqueCropDay", (RpcTarget)2, KMNLDOOKKLO, (short)PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void SendUnfollow()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUnfollow", (RpcTarget)1, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	[PunRPC]
	private void ReceivePlaceItem(int BEIPALOAAJJ, bool DDNPPKBFENA, Vector2 PGKJLODFAIF)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (!onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return;
		}
		GPCJDNCIFMB = NKJHFIDLEMN as OnlinePlaceable;
		if (Object.op_Implicit((Object)(object)GPCJDNCIFMB))
		{
			if (Object.op_Implicit((Object)(object)GPCJDNCIFMB.placeable) && Object.op_Implicit((Object)(object)GPCJDNCIFMB.placeable.itemSpace))
			{
				GPCJDNCIFMB.CancelSmoothedMovement();
				((Component)GPCJDNCIFMB).transform.position = Vector2.op_Implicit(PGKJLODFAIF);
				GPCJDNCIFMB.placeable.itemSpace.Place(DDNPPKBFENA, KBNNPAKJDJM: false, CDPAMNIPPEC: false);
				GPCJDNCIFMB.CLHLNFFGOGA = !DDNPPKBFENA;
				CameraRenderSettings.placeablePlayer = null;
			}
			else
			{
				OnlinePlaceable gPCJDNCIFMB = GPCJDNCIFMB;
				string text = "Item " + ((gPCJDNCIFMB != null) ? ((Object)((Component)gPCJDNCIFMB).gameObject).name : null) + " cannot be placed.";
				OnlinePlaceable gPCJDNCIFMB2 = GPCJDNCIFMB;
				Debug.LogError((object)text, (Object)(object)((gPCJDNCIFMB2 != null) ? ((Component)gPCJDNCIFMB2).gameObject : null));
			}
		}
	}

	[PunRPC]
	public void ReceiveInstantiateDog(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<DogMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	public void BJHNLCDFEMO(int KMNLDOOKKLO)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDog).GABDIDCMNIL();
		}
	}

	public void SendHitJacky()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHitJacky", (RpcTarget)1);
	}

	public void SendDeassignAnimal(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDeassignAnimal", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void SetMovingObject(Placeable EAPCLAODGAE)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			movingObject = EAPCLAODGAE.onlinePlaceable;
			EFEIOCBDHBP = Vector2.op_Implicit(((Component)EAPCLAODGAE).transform.position);
		}
	}

	public void OIACGIOPNEE(int KMNLDOOKKLO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = KMNLDOOKKLO;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/3/Dialogue Text", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveSetCrowlyEvent()
	{
		CrowlyEvent.GGFJGHHHEJC.startCrowlyEvent = true;
	}

	[PunRPC]
	private void ReceiveSetVitamins(int BEIPALOAAJJ, int MGNOBNCMDJG)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).SetVitamins(MGNOBNCMDJG);
		}
	}

	[PunRPC]
	public void ReceivInstantiateMusselHarvest(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<MusselMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	[PunRPC]
	private void ReceiveAgeDrink(int KMNLDOOKKLO, byte ABAIKKGKDGD)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineAgingBarrel onlineAgingBarrel)
		{
			onlineAgingBarrel.agingBarrel.AgeDrink(ABAIKKGKDGD, CDPAMNIPPEC: false);
		}
	}

	public void SendEnable(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEnable", (RpcTarget)1, KMNLDOOKKLO);
	}

	[PunRPC]
	public void ReceivePhaseMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<PhaseControllerMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceiveRentedRoomMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<RentedRoomMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceiveBedMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BedMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void ReceiveExitInteraction(int KMNLDOOKKLO)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDog).ReceiveExitInteraction();
		}
	}

	[PunRPC]
	public void ReciveStopConversationOnlineObjects(int BEIPALOAAJJ, byte NCMDEGABGCH)
	{
		CHAEKNLHEKP(BEIPALOAAJJ).ReciveStopConversation(NCMDEGABGCH);
	}

	public void DOHILDMNNED(int KMNLDOOKKLO, float FHHCDEOMPDH)
	{
		if (dirtyTablesToSend.ContainsKey(KMNLDOOKKLO))
		{
			dirtyTablesToSend[KMNLDOOKKLO] += FHHCDEOMPDH;
		}
		else
		{
			dirtyTablesToSend.Add(KMNLDOOKKLO, FHHCDEOMPDH);
		}
	}

	private void AMLHEGIFKOM(int BEIPALOAAJJ)
	{
		if (interactingObjects.Contains(BEIPALOAAJJ))
		{
			interactingObjects.Remove(BEIPALOAAJJ);
		}
	}

	[PunRPC]
	public void ReceiveSetInt(int BEIPALOAAJJ, int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			if (NKJHFIDLEMN is OnlineCat)
			{
				(NKJHFIDLEMN as OnlineCat).ReceiveSetInt(GJKKNOKIKBJ, AODONKKHPBP);
			}
			else if (NKJHFIDLEMN is OnlineBird)
			{
				(NKJHFIDLEMN as OnlineBird).ReceiveSetInt(GJKKNOKIKBJ, AODONKKHPBP);
			}
			else if (NKJHFIDLEMN is OnlineDog)
			{
				(NKJHFIDLEMN as OnlineDog).ReceiveSetInt(GJKKNOKIKBJ, AODONKKHPBP);
			}
		}
	}

	[PunRPC]
	public void ReceiveTreeInfo(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<TreeMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void MKJMFEOFPIJ(int KMNLDOOKKLO, int KMCCFOGJCJF)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO) && onlineObjects[KMNLDOOKKLO] is OnlineRentedRoom onlineRentedRoom)
		{
			onlineRentedRoom.rentedRoom.customerOrder.OJNGOEHODEO(1, null, null, CDPAMNIPPEC: true, KMCCFOGJCJF);
		}
	}

	[PunRPC]
	public void ReceiveMultiplayerObjectNotFound(int BEIPALOAAJJ, int JJPJHIHBOIB)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			Debug.LogError((object)("Actor Number " + JJPJHIHBOIB + ": Multiplayer Object is null " + BEIPALOAAJJ + " - " + ((Object)((Component)NKJHFIDLEMN).gameObject).name), (Object)(object)((Component)this).gameObject);
		}
	}

	[PunRPC]
	private void ReceiveGetUniqueCropHarvestable(int KMNLDOOKKLO, short JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGetUniqueCropHarvestableOnClient", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), KMNLDOOKKLO, GeneratorsManager.instance.CheckIfCropIsHarvestable(KMNLDOOKKLO));
	}

	[PunRPC]
	public void ReceiveSetLife(int BEIPALOAAJJ, int GDHFHKKMIEP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveSetLife(GDHFHKKMIEP);
		}
	}

	public void MKNKJHGLOBM(int JJPJHIHBOIB)
	{
		DogNPC.instance.onlineDog.INLEIKHGIEB(JJPJHIHBOIB);
	}

	private void NIDPFCLJJAI(int BEIPALOAAJJ, int PNFJKJNMOOD, bool MPMPHHFKKDN)
	{
		if (onlineObjects.ContainsKey(PNFJKJNMOOD))
		{
			(onlineObjects[PNFJKJNMOOD] as OnlinePlaceable).placeable.placeableSurface.FBDCAPELINM(BEIPALOAAJJ, MPMPHHFKKDN);
		}
		else
		{
			Debug.LogError((object)("itemWatermelonSeeds" + BEIPALOAAJJ + "Items/item_name_1068"));
		}
	}

	private void FFMMLPCIODP(short JJPJHIHBOIB)
	{
		if (Barn.instance.IFICIHMKJHA())
		{
			if (!Barn.instance.IsOpen() || Barn.instance.AAIGLAHDNBG())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ItemSetup not attached to prefab ", (RpcTarget)0);
			}
			else
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_18", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false));
			}
		}
	}

	public void PNOMKCCBLMG()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Ignore Raycast", (RpcTarget)1);
	}

	public void GKMEDBOOLFB(int KMNLDOOKKLO, int BJMKKGKPLBP)
	{
		if (onlineObjects.TryGetValue(KMNLDOOKKLO, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineDog).HIPGDPCBNCL((DogNPC.DogInteractionType)BJMKKGKPLBP);
		}
	}

	public void SendDestroyObject(OnlineObject KGCCCHBFJLE)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((!(KGCCCHBFJLE is OnlinePlaceable onlinePlaceable) || !((Object)(object)onlinePlaceable.placeable != (Object)null) || !((Object)(object)onlinePlaceable.placeable.parent != (Object)null)) ? ((Component)KGCCCHBFJLE).transform.position : onlinePlaceable.placeable.parent.transform.position);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DestroyObjectClient", (RpcTarget)1, KGCCCHBFJLE.uniqueId, val.x, val.y);
	}

	[PunRPC]
	private void ReceiveAskForRockStartInfo(int BEIPALOAAJJ, int JJPJHIHBOIB)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			GPCJDNCIFMB = NKJHFIDLEMN as OnlinePlaceable;
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRockStartInformation", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), BEIPALOAAJJ, OnlineSerializer.Serialize(GPCJDNCIFMB.CreateMsg()));
		}
	}

	private void PPEGLINLDDI(int BEIPALOAAJJ, float BEKGEHJHAEF, float MCIOPHBKMOF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			((Component)(NKJHFIDLEMN as OnlinePlaceable)).transform.position = Vector2.op_Implicit(new Vector2(BEKGEHJHAEF, MCIOPHBKMOF));
			(NKJHFIDLEMN as OnlinePlaceable).placeable.PixelSnap();
		}
	}

	private void JCAJPBEEEMC(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).Cure();
		}
	}

	[PunRPC]
	private void ReceiveReduceDirtiness(int BEIPALOAAJJ, float HNEHMKOJJMF)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).ReduceDirtiness(HNEHMKOJJMF);
		}
	}

	private void HHLPMEJOLGL(int BEIPALOAAJJ)
	{
		if (!interactingObjects.Contains(BEIPALOAAJJ))
		{
			interactingObjects.Add(BEIPALOAAJJ);
		}
	}

	[PunRPC]
	public void ReceiveAnimalMessage(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<AnimalMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	[PunRPC]
	public void SelectPermissionAccepted(int BEIPALOAAJJ, short JJPJHIHBOIB)
	{
		if (OnlineManager.IsLocalActor(JJPJHIHBOIB))
		{
			requestDone = false;
		}
		if (onlineObjects.ContainsKey(BEIPALOAAJJ))
		{
			(onlineObjects[BEIPALOAAJJ] as OnlinePlaceable).AcceptedSelectPermission(JJPJHIHBOIB);
			AddActorPlaceableSelected(JJPJHIHBOIB, onlineObjects[BEIPALOAAJJ] as OnlinePlaceable);
		}
		else
		{
			Debug.LogError((object)("Unique id " + BEIPALOAAJJ + " not found. Cannot receive permission accepted to player " + JJPJHIHBOIB));
		}
	}

	private void PAEGEMEFOBK()
	{
		if (Application.isPlaying)
		{
			foreach (Placeable currentPlaceable in PlaceablesManager.GGFJGHHHEJC.currentPlaceables)
			{
				if (!((Object)(object)currentPlaceable == (Object)null))
				{
					ALHAAPMGHPG(((Component)currentPlaceable).gameObject);
					if (currentPlaceable.rotatable && (Object)(object)currentPlaceable.rotatedPrefab != (Object)null)
					{
						ALHAAPMGHPG(currentPlaceable.rotatedPrefab);
					}
				}
			}
			return;
		}
		Item[] items = ItemDatabaseAccessor.GetDatabaseSO().items;
		foreach (Item item in items)
		{
			if (!((Object)(object)item.PHGCBMPGGLI() == (Object)null))
			{
				ALHAAPMGHPG(item.PHGCBMPGGLI());
				if (Object.op_Implicit((Object)(object)item.PHGCBMPGGLI().GetComponent<Placeable>()) && item.PHGCBMPGGLI().GetComponent<Placeable>().rotatable && (Object)(object)item.PHGCBMPGGLI().GetComponent<Placeable>().rotatedPrefab != (Object)null)
				{
					ALHAAPMGHPG(item.PHGCBMPGGLI().GetComponent<Placeable>().rotatedPrefab);
				}
			}
		}
		Debug.Log((object)"Check For Duplicate OnlineObjects finished");
	}

	private void IMPGOKHIMJC(int KMNLDOOKKLO, float LLIKFNFINLB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "New Text start", (RpcTarget)1, KMNLDOOKKLO, LLIKFNFINLB, null);
	}

	private void Awake()
	{
		instance = this;
	}

	public void SendItemContainerColor(int KMNLDOOKKLO, int OBHOAFNMDCD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveItemContainerColor", (RpcTarget)1, KMNLDOOKKLO, (byte)OBHOAFNMDCD);
	}

	public void SendInstantiateFloorDirt(OnlineFloorDirt DGDKABHINMJ)
	{
		FloorDirtMessage mOBFJEDPIPM = new FloorDirtMessage(DGDKABHINMJ);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFloorDirtInfo", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void StopWork(int KMNLDOOKKLO)
	{
		if (doWorksUpdated.ContainsKey(KMNLDOOKKLO))
		{
			doWorksUpdated.Remove(KMNLDOOKKLO);
		}
		SendStopWork(KMNLDOOKKLO);
	}

	[PunRPC]
	private void ReceiveEnable(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveEnable();
		}
	}

	[PunRPC]
	private void ReceiveSetPickupable(int BEIPALOAAJJ, bool IHLGDCAIPLN)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineMagicBroom).SetPickupable(IHLGDCAIPLN);
		}
	}

	public void JHOKMCMAEIK(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<FloorDirtMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	[PunRPC]
	private void ReceiveStartWork(int BEIPALOAAJJ, float LLIKFNFINLB)
	{
		if (!onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			return;
		}
		if ((Object)(object)NKJHFIDLEMN != (Object)null)
		{
			if ((Object)(object)NKJHFIDLEMN.doWork != (Object)null)
			{
				NKJHFIDLEMN.doWork.StartWork(LLIKFNFINLB, null, CDPAMNIPPEC: false);
			}
			else
			{
				Debug.LogError((object)("ReceiveStartWork " + ((Object)((Component)NKJHFIDLEMN).gameObject).name + " without doWork attached to OnlineObject"));
			}
		}
		else
		{
			Debug.LogError((object)("ReceiveStartWork " + BEIPALOAAJJ + " in onlineObjects is null"));
		}
	}

	[PunRPC]
	private void ReceiveDeassignAnimal(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).DeassignAnimal();
		}
	}

	private void MFKOKGMKMFB()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<int, Vector2> movingCat in movingCats)
		{
			HPDMDALEAIH(movingCat.Key, movingCat.Value.x, movingCat.Value.y);
		}
		movingCats.Clear();
	}

	private void ALHAAPMGHPG(GameObject ANADFOCHOBF)
	{
		OnlineObject[] components = ANADFOCHOBF.GetComponents<OnlineObject>();
		if (components.Length > 1)
		{
			Debug.LogError((object)$"El prefab '{ANADFOCHOBF}' tiene {components.Length} componentes 'OnlineObject' (duplicados).");
		}
	}

	public void SendInstantiateDog(OnlineDog DGDKABHINMJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInstantiateDog", (RpcTarget)1, OnlineSerializer.Serialize(new DogMessage(DGDKABHINMJ)));
	}

	public void SendSetUniqueCropDay(int KMNLDOOKKLO, int LCBDINCABAC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetUniqueCropDay", (RpcTarget)2, KMNLDOOKKLO, LCBDINCABAC);
	}

	private void CNALJDIEHNA(int BEIPALOAAJJ, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.EFEGFLBANBJ(new Vector2(BDKCDBALPJH, ACMOGJCLELA));
		}
	}

	[PunRPC]
	public void ReceivInstantiateHoleInGround(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<HoleInGroundMessage>(OINICMNOLPK).OEJJGDMKIDN();
	}

	[PunRPC]
	private void ReceiveCancelAllCrafting(short JJPJHIHBOIB, int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			(onlineObjects[KMNLDOOKKLO] as OnlineCrafter).crafter.CancelAllCrafting(1, OnlineManager.IsLocalActor(JJPJHIHBOIB));
		}
		else
		{
			Debug.LogError((object)("Unique id " + KMNLDOOKKLO + " not found. Cannot receive permission accepted to cancel all crafting actorNumber: " + JJPJHIHBOIB));
		}
	}

	public void GIIGFBIBKKK(int BEIPALOAAJJ, int GJKKNOKIKBJ, int AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = BEIPALOAAJJ;
		array[1] = GJKKNOKIKBJ;
		array[2] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)0, array);
	}

	private void EMOPNLNKCDB(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = KMNLDOOKKLO;
		array[1] = BDKCDBALPJH;
		array[5] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "LucenFall", (RpcTarget)0, array);
	}

	public void SendSetTrigger(int BEIPALOAAJJ, string GEGDHHIDEEF)
	{
		SendSetTrigger(BEIPALOAAJJ, Animator.StringToHash(GEGDHHIDEEF));
	}

	private void OBPBGCMFLJM(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = KMNLDOOKKLO;
		array[0] = BDKCDBALPJH;
		array[0] = ACMOGJCLELA;
		OnlineManager.SendRPC(photonView, "FocusedActionBar", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveOpenAnimation(int BEIPALOAAJJ)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineItemContainer).ReceiveOpenAnimation();
		}
	}

	[PunRPC]
	public void ReceiveBarnInfo(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BarnMsg>(OINICMNOLPK, JJPJHIHBOIB);
	}

	private void NMENEFEJLDK()
	{
		AdoptionSignalManager.NOEBLLHOEOP().adoption += 0;
	}

	public void SendKick(int KMNLDOOKKLO, float AINPJHKNJGL, Vector2 IMOBLFMHKOD)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveKick", (RpcTarget)1, KMNLDOOKKLO, AINPJHKNJGL, PhotonNetwork.LocalPlayer.ActorNumber, IMOBLFMHKOD.x, IMOBLFMHKOD.y);
	}

	private void NIOJLIDOCPJ(int KMNLDOOKKLO)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			if (onlineObjects[KMNLDOOKKLO] is OnlineCrafter onlineCrafter)
			{
				onlineCrafter.crafter.Repair(1, 1, 1, 1, 1, 1);
			}
		}
		else
		{
			Debug.LogError((object)(": " + KMNLDOOKKLO + "Items/item_description_695"));
		}
	}

	public void NDJEDNMLFLL(int BEIPALOAAJJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = BEIPALOAAJJ;
		OnlineManager.SendRPC(photonView, "Items/item_description_1035", (RpcTarget)0, array);
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			OnlineManager.OnRoomJoined = (Action)Delegate.Remove(OnlineManager.OnRoomJoined, new Action(CCAGDLHMCLL));
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
			}
		}
	}

	public void CENDIMENDKN(int BEIPALOAAJJ, byte FACPEEACCMH, object[] GEMFIOKGIMC)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			NKJHFIDLEMN.ReceiveAction(FACPEEACCMH, GEMFIOKGIMC);
		}
		else if (BEIPALOAAJJ >= -81 || BEIPALOAAJJ < 1)
		{
			Debug.LogError((object)("ReceiveLoadRecipes" + BEIPALOAAJJ), (Object)(object)((Component)this).gameObject);
			SendMultiplayerObjectNotFound(BEIPALOAAJJ);
		}
	}

	[PunRPC]
	public void ReceiveOnConversationLine(int BEIPALOAAJJ, string NMMGHIJNPJG, short NIGNPMLFECM, bool HPPJPALKJPK)
	{
		CHAEKNLHEKP(BEIPALOAAJJ).OnConversationLineRPC(NMMGHIJNPJG, NIGNPMLFECM, HPPJPALKJPK);
	}

	public void SendUpdateContentsRoom(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdateContentsRoom", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void SendAnimalLevel(int KMNLDOOKKLO, int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalLevel", (RpcTarget)1, KMNLDOOKKLO, EONJGMONIOM);
	}

	public void SendSetOccupierInRoom(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetOccupierInRoom", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void EBOMJJBEHIG()
	{
		requestDone = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)GameManager.NJNFHEPLEHL());
		PlayerInputs.DEGBDMMDIIL(1).mouseUpBlockers.Remove((MonoBehaviour)(object)GameManager.NJNFHEPLEHL());
	}

	public void SendMoveCrowly()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReciveMoveCrowly", (RpcTarget)1);
	}

	public void SendCloseAnimation(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCloseAnimation", (RpcTarget)1, KMNLDOOKKLO);
	}

	public void SendAssignAnimalSpace(int KMNLDOOKKLO, int KNIBEKEBAHD, int EPDKMPFDDGP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAssignAnimalSpace", (RpcTarget)1, KMNLDOOKKLO, KNIBEKEBAHD, EPDKMPFDDGP);
	}

	public void SendExitInteraction(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveExitInteraction", (RpcTarget)1, KMNLDOOKKLO);
	}

	private void FPILBHLLOIB()
	{
		AdoptionSignalManager.OMEPPDMCFAO().adoption += 0;
	}

	public void JBOBABPKOLO(int[] OLGFCKMKBKF, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[1];
		array[1] = OLGFCKMKBKF;
		OnlineManager.SendRPC(photonView, "Sit", player, array);
	}

	public void SendServeCustomerOrder(int KMNLDOOKKLO, Price ENDNDAOPKHD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveServeCustomerOrder", (RpcTarget)1, KMNLDOOKKLO, ENDNDAOPKHD.OOIPLIEJILO());
	}

	public void FALDKGJCHMP(int KMNLDOOKKLO, int EONJGMONIOM)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "- ", (RpcTarget)0, KMNLDOOKKLO, EONJGMONIOM, null, null, null, null, null, null);
	}

	public void SendInstantiateHoleInGround(OnlineHoleInGround DGDKABHINMJ)
	{
		HoleInGroundMessage mOBFJEDPIPM = new HoleInGroundMessage(DGDKABHINMJ);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivInstantiateHoleInGround", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public void CECGMEEAIOK(int KMNLDOOKKLO, float AODONKKHPBP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = KMNLDOOKKLO;
		array[0] = AODONKKHPBP;
		OnlineManager.SendRPC(photonView, "/", (RpcTarget)0, array);
	}

	public void SendAnimalName(int BEIPALOAAJJ, string GEGDHHIDEEF)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalName", (RpcTarget)1, BEIPALOAAJJ, GEGDHHIDEEF);
	}

	[PunRPC]
	private void ReceiveCollectItems(short JJPJHIHBOIB, int KMNLDOOKKLO, byte HFDILBELIKE)
	{
		if (onlineObjects.ContainsKey(KMNLDOOKKLO))
		{
			(onlineObjects[KMNLDOOKKLO] as OnlinePlaceable).CollectItems(HFDILBELIKE, JJPJHIHBOIB);
		}
		else
		{
			Debug.LogError((object)("Unique id " + KMNLDOOKKLO + " not found. Cannot receive permission accepted to player " + JJPJHIHBOIB));
		}
	}

	public void SendSetCrowlyEvent()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetCrowlyEvent", (RpcTarget)1);
	}

	private void BFJFKDDPGOP(int KMNLDOOKKLO, float BDKCDBALPJH, float ACMOGJCLELA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalPosition", (RpcTarget)1, KMNLDOOKKLO, BDKCDBALPJH, ACMOGJCLELA);
	}

	public void PEDOIKFHCGI(OnlinePlaceable DGDKABHINMJ)
	{
		PlaceableMsg placeableMsg = DGDKABHINMJ.LPKPBCPBFEI();
		if (placeableMsg is BarnMsg)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(placeableMsg);
			array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, "generate forest", (RpcTarget)0, array);
		}
		else if (placeableMsg is CrafterMessage)
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[3];
			array2[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array2[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView2, "CliveProgress", (RpcTarget)1, array2);
		}
		else if (placeableMsg is RentedRoomMessage)
		{
			PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[3];
			array3[1] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array3[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView3, "Open", (RpcTarget)1, array3);
		}
		else if (placeableMsg is DoorMessage)
		{
			PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
			object[] array4 = new object[5];
			array4[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array4[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView4, "Items/item_description_1115", (RpcTarget)1, array4);
		}
		else if (placeableMsg is DrinkDispenserMessage)
		{
			PhotonView photonView5 = ((MonoBehaviourPun)this).photonView;
			object[] array5 = new object[6];
			array5[1] = OnlineSerializer.Serialize(placeableMsg);
			array5[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView5, "Editor action without ID: ", (RpcTarget)0, array5);
		}
		else if (placeableMsg is FireplaceMsg)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MineFloor", (RpcTarget)0, OnlineSerializer.EKNOFIJNBAP(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is HenHouseMsg)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<sprite name=", (RpcTarget)1, OnlineSerializer.JBIPDCGKMGE(placeableMsg), PhotonNetwork.LocalPlayer.ActorNumber);
		}
		else if (placeableMsg is IrrigatorMessage)
		{
			PhotonView photonView6 = ((MonoBehaviourPun)this).photonView;
			object[] array6 = new object[0];
			array6[1] = OnlineSerializer.Serialize(placeableMsg);
			array6[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView6, "Tower", (RpcTarget)0, array6);
		}
		else if (placeableMsg is ItemContainerMsg)
		{
			PhotonView photonView7 = ((MonoBehaviourPun)this).photonView;
			object[] array7 = new object[3];
			array7[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array7[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView7, "questDescMalting", (RpcTarget)1, array7);
		}
		else if (placeableMsg is RockMessage)
		{
			Debug.LogError((object)(". " + placeableMsg.uniqueId));
		}
		else if (placeableMsg is TableMessage)
		{
			PhotonView photonView8 = ((MonoBehaviourPun)this).photonView;
			object[] array8 = new object[3];
			array8[0] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array8[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView8, ")...", (RpcTarget)0, array8);
		}
		else if (placeableMsg is TreeMessage)
		{
			PhotonView photonView9 = ((MonoBehaviourPun)this).photonView;
			object[] array9 = new object[0];
			array9[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array9[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView9, "Player Destroyed. Num Players: ", (RpcTarget)0, array9);
		}
		else if (placeableMsg is BeehiveMessage)
		{
			PhotonView photonView10 = ((MonoBehaviourPun)this).photonView;
			object[] array10 = new object[2];
			array10[1] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array10[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView10, "itemMetalSheet", (RpcTarget)0, array10);
		}
		else if (placeableMsg is AnimalMessage)
		{
			PhotonView photonView11 = ((MonoBehaviourPun)this).photonView;
			object[] array11 = new object[4];
			array11[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array11[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView11, "Player2", (RpcTarget)0, array11);
		}
		else if (placeableMsg is FishTrapMessage)
		{
			PhotonView photonView12 = ((MonoBehaviourPun)this).photonView;
			object[] array12 = new object[6];
			array12[1] = OnlineSerializer.Serialize(placeableMsg);
			array12[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView12, "Eating", (RpcTarget)1, array12);
		}
		else if (placeableMsg is PetBowlMessage)
		{
			PhotonView photonView13 = ((MonoBehaviourPun)this).photonView;
			object[] array13 = new object[8];
			array13[0] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array13[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView13, "City/Hallmund/Stand", (RpcTarget)0, array13);
		}
		else if (placeableMsg is BirdMessage)
		{
			PhotonView photonView14 = ((MonoBehaviourPun)this).photonView;
			object[] array14 = new object[2];
			array14[0] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array14[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView14, "Dialogue System/Conversation/Gass_Barks_Bye/Entry/2/Dialogue Text", (RpcTarget)0, array14);
		}
		else if (placeableMsg is BedMessage)
		{
			PhotonView photonView15 = ((MonoBehaviourPun)this).photonView;
			object[] array15 = new object[1];
			array15[0] = OnlineSerializer.Serialize(placeableMsg);
			array15[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView15, "BackWall", (RpcTarget)0, array15);
		}
		else if (placeableMsg is ChristmasTreeMessage)
		{
			PhotonView photonView16 = ((MonoBehaviourPun)this).photonView;
			object[] array16 = new object[5];
			array16[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array16[1] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView16, "LE_14", (RpcTarget)0, array16);
		}
		else if (placeableMsg is CuckooClockMessage)
		{
			PhotonView photonView17 = ((MonoBehaviourPun)this).photonView;
			object[] array17 = new object[3];
			array17[1] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array17[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView17, "Player/Bark/Tutorial/CrafterBlock", (RpcTarget)0, array17);
		}
		else if (placeableMsg is PhaseControllerMessage)
		{
			PhotonView photonView18 = ((MonoBehaviourPun)this).photonView;
			object[] array18 = new object[4];
			array18[1] = OnlineSerializer.JBIPDCGKMGE(placeableMsg);
			array18[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView18, "popUpBuilding19", (RpcTarget)0, array18);
		}
		else
		{
			PhotonView photonView19 = ((MonoBehaviourPun)this).photonView;
			object[] array19 = new object[6];
			array19[1] = OnlineSerializer.EKNOFIJNBAP(placeableMsg);
			array19[0] = PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView19, "Festín del Juramento/JudgeDialogue 02", (RpcTarget)0, array19);
		}
	}

	[PunRPC]
	private void ReceiveAnimalIncreaseProduction(int BEIPALOAAJJ, float AODONKKHPBP)
	{
		if (onlineObjects.TryGetValue(BEIPALOAAJJ, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineAnimal).ReceiveIncreaseProduction(AODONKKHPBP);
		}
	}

	public void LJFEGOPLANF(int[] OLGFCKMKBKF, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[0];
		array[0] = OLGFCKMKBKF;
		OnlineManager.SendRPC(photonView, "Player/Bark/Tutorial/T100", player, array);
	}

	public void OCCEGNAKNCO(int KMNLDOOKKLO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Loop", (RpcTarget)0, KMNLDOOKKLO);
	}

	public void NOKGJKBFCAD(byte[] OINICMNOLPK, int JJPJHIHBOIB)
	{
		KBMJLMKEFFL<BeehiveMessage>(OINICMNOLPK, JJPJHIHBOIB);
	}

	public void SendInstantiateDog(OnlineDog DGDKABHINMJ, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveInstantiateDog", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), OnlineSerializer.Serialize(new DogMessage(DGDKABHINMJ)));
	}
}
