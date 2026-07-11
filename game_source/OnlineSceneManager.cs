using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnlineSceneManager : MonoBehaviourPunCallbacks, ISingleton
{
	[Serializable]
	private class OnlineSceneState
	{
		public Location location;

		public SceneLoadingStates loadingStateLocal;

		public Action<SceneLoadingStates> OnLocalStateChanged = delegate
		{
		};

		public SceneLoadingStates loadingStateMaster;

		public Action<SceneLoadingStates> OnMasterStateChanged = delegate
		{
		};

		public void EONKODICNIM(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("MineChessPillarPuzzle requires ChessPillarPuzzleSettings", location, IKAGABHNANJ));
			}
		}

		public void OKHGDIFHFHC(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("", location, IKAGABHNANJ));
			}
		}

		public void PFEKDMHGNMC(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("EnterCode", location, IKAGABHNANJ));
			}
		}

		public void PBJHLDGEMCC(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("ChatWelcomeToTavern", location, IKAGABHNANJ));
			}
		}

		public void JJOPKCALMDE(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Multiplayer Object is null ", location, IKAGABHNANJ));
			}
		}

		public void AAHKCLIMJDK(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("BarnTutorialDone", location, IKAGABHNANJ));
			}
		}

		public void FPGHLONDBCB(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format(" in Key1 map category", location, IKAGABHNANJ));
			}
		}

		public void GGMMAFEHEHC(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("</color>", location, IKAGABHNANJ));
			}
		}

		public void JMBPDNDNONN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("LE_21", location, IKAGABHNANJ));
			}
		}

		public void OOICHGHKKHF(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Dialogue System/Conversation/Crowly_Introduce/Entry/30/Dialogue Text", location, IKAGABHNANJ));
			}
		}

		public void NCPADLLLODN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Unsaved progress will be lost.", location, IKAGABHNANJ));
			}
		}

		public void ODCGMIIAAIH(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("OnlinePlayer", location, IKAGABHNANJ));
			}
		}

		public void CKPEMMBLNCB(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("", location, IKAGABHNANJ));
			}
		}

		public void AIBDAAFAPEP(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format(":<color=#3a0603> +", location, IKAGABHNANJ));
			}
		}

		public void LODKOJLEPNP(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("IsOpen", location, IKAGABHNANJ));
			}
		}

		public void MAMCOACGOPK(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Farm/Event/RegañinaViolet", location, IKAGABHNANJ));
			}
		}

		public void PAEEHLKHAOO(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)$"{location} state changed to: {IKAGABHNANJ}");
			}
		}

		public void EENEHIDAIKN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Piso {0}: Generando {1} rocas en {2} spawners disponibles.", location, IKAGABHNANJ));
			}
		}

		public void NNKJCCBCMNA(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Items/item_name_1071", location, IKAGABHNANJ));
			}
		}

		public void GBJPLICDHFN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Interact", location, IKAGABHNANJ));
			}
		}

		public void HLCLFDLBMLM(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("", location, IKAGABHNANJ));
			}
		}

		public void FJEEIOFCKNB(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Items/item_description_1053", location, IKAGABHNANJ));
			}
		}

		public void MGEHGDDMGLP(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format(":", location, IKAGABHNANJ));
			}
		}

		public void MGOJPGBFNAF(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Items/item_name_666", location, IKAGABHNANJ));
			}
		}

		public void KJHILHKENPD(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("\n", location, IKAGABHNANJ));
			}
		}

		public void KHKACOAGCMB(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("MayaMinigames", location, IKAGABHNANJ));
			}
		}

		public void JFAHGNHIBJI(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Dialogue System/Conversation/NeutralInTavern/Entry/5/Dialogue Text", location, IKAGABHNANJ));
			}
		}

		public void NLPFKJFINLO(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Dialogue System/Conversation/TooDark/Entry/1/Dialogue Text", location, IKAGABHNANJ));
			}
		}

		public void MDMHCCNMJPN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Input field already has console support component: {0}", location, IKAGABHNANJ));
			}
		}

		public void FPJFMNDLAKD(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format(" get price serve customer ", location, IKAGABHNANJ));
			}
		}

		public void GMCMKHHFGPM(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)$"{location} state changed to: {IKAGABHNANJ}");
			}
		}

		public void MFHMBGBPIKF(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("endconversation", location, IKAGABHNANJ));
			}
		}

		public void OEHDHICAKCL(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("ReceiveOnConversationLine", location, IKAGABHNANJ));
			}
		}

		public void GKOGOIHLAFJ(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("parent null: {0}, ", location, IKAGABHNANJ));
			}
		}

		public void NFNIINFECCO(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("in", location, IKAGABHNANJ));
			}
		}

		public void HOHDBGNBICD(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Items/item_name_615", location, IKAGABHNANJ));
			}
		}

		public void BCOIFKNPELI(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Kyroh not found path to at ", location, IKAGABHNANJ));
			}
		}

		public void HFEBFBKPAOE(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Rooms", location, IKAGABHNANJ));
			}
		}

		public void FCEKEFMDLOF(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("\n", location, IKAGABHNANJ));
			}
		}

		public void NHBDGKMMDDO(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("itemLog", location, IKAGABHNANJ));
			}
		}

		public void MDFIBCIJGIB(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Read", location, IKAGABHNANJ));
			}
		}

		public void INFCFGJACMD(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("You win!", location, IKAGABHNANJ));
			}
		}

		public void AGBGBJPPNCF(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("NinjaChallengeEvent/Win", location, IKAGABHNANJ));
			}
		}

		public void CBAFOEGBADB(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("pirate cave", location, IKAGABHNANJ));
			}
		}

		public void FHELECCLEFN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("- ", location, IKAGABHNANJ));
			}
		}

		public void BCBMOKNEIFC(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("", location, IKAGABHNANJ));
			}
		}

		public void OOAICCDEIJI(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("Key2", location, IKAGABHNANJ));
			}
		}

		public void IDMNOKJCKLN(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("MenuMode/ButtonEnter", location, IKAGABHNANJ));
			}
		}

		public void PMBBLFJAEDL(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateLocal != IKAGABHNANJ)
			{
				loadingStateLocal = IKAGABHNANJ;
				OnLocalStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("ReceiveCastleFormStartLucenDialogue", location, IKAGABHNANJ));
			}
		}

		public void GBJECNMKBMH(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("mainMenuMultiplayerButton", location, IKAGABHNANJ));
			}
		}

		public void INCEMCHALJG(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("ReceiveGenerateAvailableOrders", location, IKAGABHNANJ));
			}
		}

		public OnlineSceneState(Location NFHFNKHHGGI)
		{
			location = NFHFNKHHGGI;
			loadingStateLocal = SceneLoadingStates.NotLoaded;
			loadingStateMaster = SceneLoadingStates.NotLoaded;
		}

		public void EHBBJOCFKBF(SceneLoadingStates IKAGABHNANJ)
		{
			if (loadingStateMaster != IKAGABHNANJ)
			{
				loadingStateMaster = IKAGABHNANJ;
				OnMasterStateChanged?.Invoke(IKAGABHNANJ);
				Debug.LogError((object)string.Format("descWardrobe", location, IKAGABHNANJ));
			}
		}
	}

	[Serializable]
	private class PlayerSceneState
	{
		public int playerID;

		public Location currentLocation;

		public Location loadingLocation;

		private bool isLoading;
	}

	[CompilerGenerated]
	private sealed class OFDDJGPEJGL
	{
		public Location _location;

		internal bool AHJLHGMMLDD(OnlineSceneState _search)
		{
			return _search.location == _location;
		}
	}

	[CompilerGenerated]
	private sealed class CJEPIMJOOIL
	{
		public Location _location;

		internal void FEDPBFOFPKM(AsyncOperation _operation)
		{
			AGPNLNJOIKF(_location);
		}
	}

	[CompilerGenerated]
	private sealed class OFPBAEJJCJM
	{
		public Location _location;

		internal void COJAKNJKDOB(AsyncOperation _operation)
		{
			DGJGMKLMKJM(_location);
		}
	}

	private static OnlineSceneManager GGFJGHHHEJC;

	[SerializeField]
	private List<OnlineSceneState> Scenes;

	private static PlayerSceneState[] AFCAEJFIHLM;

	public static SceneLoadingStates GetSceneMasterLoadingState(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster;
	}

	public static AsyncOperation NKKFJGHHNNN(Location NFHFNKHHGGI)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.NotLoaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (!((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.EENEHIDAIKN(SceneLoadingStates.NotLoaded);
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineSceneState.FPGHLONDBCB(SceneLoadingStates.Loading);
				}
				CommonReferences.MNFMOEKMJKN().loadingLocation[NFHFNKHHGGI] = false;
				AsyncOperation obj = SceneManager.LoadSceneAsync(NFHFNKHHGGI.ToString(), (LoadSceneMode)0);
				obj.completed += delegate
				{
					AGPNLNJOIKF(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("Empty transform for NPC. This shouldn't happen." + NFHFNKHHGGI.ToString() + "a"));
		return null;
	}

	public static bool JLBLOPBCMHL(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.NotLoaded;
	}

	public void JOGIMBHAHJN()
	{
		PLFEJDOEIAI();
	}

	public static SceneLoadingStates GetSceneLocalLoadingState(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal;
	}

	private static void HJIEGLFFILE(Location NFHFNKHHGGI)
	{
		if (OnlineManager.JPPBEIJDCLJ() && GetSceneMasterLoadingState(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			COALBANJIFO(NFHFNKHHGGI);
		}
	}

	public static bool FGFBEEOLBPC(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.Unloading;
	}

	private static void ILGNDGNGABO(Location NFHFNKHHGGI)
	{
		if (OnlineManager.JPPBEIJDCLJ() && EPJANNNMKEI(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			NKKFJGHHNNN(NFHFNKHHGGI);
		}
	}

	public static bool IsSceneLoadingOnMaster(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.Loading;
	}

	public static void RequestSceneUnload(Location NFHFNKHHGGI)
	{
		if (NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.Loaded)
		{
			KHIFBIHFDFM(NFHFNKHHGGI);
		}
	}

	private static void BHKMJADLDNN(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.BCBMOKNEIFC(SceneLoadingStates.NotLoaded);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineSceneState.OOICHGHKKHF(SceneLoadingStates.Loading);
		}
	}

	private static AsyncOperation HKLCMALHNFJ(Location NFHFNKHHGGI)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.Loaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.NNKJCCBCMNA((SceneLoadingStates)6);
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineSceneState.EONKODICNIM((SceneLoadingStates)6);
				}
				CommonReferences.GGFJGHHHEJC.loadingLocation[NFHFNKHHGGI] = false;
				AsyncOperation obj = SceneManager.UnloadSceneAsync(NFHFNKHHGGI.ToString());
				obj.completed += delegate
				{
					DGJGMKLMKJM(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("Close" + NFHFNKHHGGI.ToString() + "itemMead"));
		return null;
	}

	private static void BFODFIHADJI(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.NFNIINFECCO(SceneLoadingStates.NotLoaded);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineSceneState.EONKODICNIM(SceneLoadingStates.Loading);
		}
	}

	private void IDPHKHGHJGN()
	{
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(InitializeAlwaysLoadedLocations));
	}

	public static bool IGFBLGPOODD(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.NotLoaded;
	}

	public static bool IsSceneLoadingLocally(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.Loading;
	}

	public static AsyncOperation NHDAAMIDCHC(Location NFHFNKHHGGI)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.NotLoaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (!((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.CBAFOEGBADB(SceneLoadingStates.NotLoaded);
				if (OnlineManager.IsMasterClient())
				{
					onlineSceneState.FHELECCLEFN(SceneLoadingStates.Loading);
				}
				CommonReferences.GGFJGHHHEJC.loadingLocation[NFHFNKHHGGI] = true;
				AsyncOperation obj = SceneManager.LoadSceneAsync(NFHFNKHHGGI.ToString(), (LoadSceneMode)1);
				obj.completed += delegate
				{
					AGPNLNJOIKF(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("MainProgress" + NFHFNKHHGGI.ToString() + "Jump"));
		return null;
	}

	private static void GGCMJDBPMOM(Location NFHFNKHHGGI)
	{
		if (OnlineManager.IsMasterClient() && GetSceneMasterLoadingState(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			LoadSceneLocally(NFHFNKHHGGI);
		}
	}

	public void ResetSingleton()
	{
		PLFEJDOEIAI();
	}

	private void IMIONHLAKIH()
	{
	}

	public static bool EEHOPCPEBKE(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == (SceneLoadingStates)6;
	}

	private static void DDNNNEOMKLF(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.GGMMAFEHEHC(SceneLoadingStates.NotLoaded);
		if (OnlineManager.IsMasterClient())
		{
			onlineSceneState.GBJECNMKBMH(SceneLoadingStates.NotLoaded);
		}
	}

	public static bool KIHLMFIBBJB(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.NotLoaded;
	}

	public static bool GEJPIKGHHOH(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.Unloading;
	}

	private static AsyncOperation COALBANJIFO(Location NFHFNKHHGGI)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.Loaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.GMCMKHHFGPM(SceneLoadingStates.Unloading);
				if (OnlineManager.IsMasterClient())
				{
					onlineSceneState.PAEEHLKHAOO(SceneLoadingStates.Unloading);
				}
				CommonReferences.GGFJGHHHEJC.loadingLocation[NFHFNKHHGGI] = false;
				AsyncOperation obj = SceneManager.UnloadSceneAsync(NFHFNKHHGGI.ToString());
				obj.completed += delegate
				{
					DGJGMKLMKJM(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("Scene " + NFHFNKHHGGI.ToString() + " cannot be unloaded at this time. Either it's already unloaded or it's in the process of unloading."));
		return null;
	}

	private void LNPMFIHKGMC()
	{
		AFCAEJFIHLM = new PlayerSceneState[6];
		Scenes = new List<OnlineSceneState>();
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			OnlineSceneState item = new OnlineSceneState(value);
			Scenes.Add(item);
		}
	}

	public static void KDGNELGMBIG(Location NFHFNKHHGGI)
	{
		if (NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == (SceneLoadingStates)6)
		{
			KHIFBIHFDFM(NFHFNKHHGGI);
		}
	}

	public static SceneLoadingStates KDNEHJGJPPP(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal;
	}

	private void OnDestroy()
	{
		GGFJGHHHEJC = null;
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(InitializeAlwaysLoadedLocations));
	}

	public static bool GCGOCLMKNBB(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.NotLoaded;
	}

	private static void IEGHLDLMBKI(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.OKHGDIFHFHC(SceneLoadingStates.NotLoaded);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineSceneState.HLCLFDLBMLM(SceneLoadingStates.NotLoaded);
		}
	}

	private static void DBIEBCBFEIN(Location NFHFNKHHGGI)
	{
		if (OnlineManager.JPPBEIJDCLJ() && GetSceneMasterLoadingState(NFHFNKHHGGI) == (SceneLoadingStates)6)
		{
			KGPHEBALHHF(NFHFNKHHGGI);
		}
	}

	public void ENNDOHKKMHB()
	{
		LNPMFIHKGMC();
	}

	public static bool ILJGMNMKLBG(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.Loading;
	}

	public void OKDICKMLMFE()
	{
		LNPMFIHKGMC();
	}

	public void NFEDMNJKNBH()
	{
		ODIMDOBMFMN();
	}

	public static bool DIKLFIDNGNO(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == (SceneLoadingStates)6;
	}

	private void GJMLHECPGBP()
	{
	}

	public static bool IsSceneLoadedOnMaster(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.Loaded;
	}

	private static void FFIFEILJNAP(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.GMCMKHHFGPM(SceneLoadingStates.NotLoaded);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineSceneState.OOICHGHKKHF(SceneLoadingStates.Loading);
		}
	}

	public static bool CDCBKKJMOPI(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.NotLoaded;
	}

	public static SceneLoadingStates JMMMAKHPEJL(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal;
	}

	private void JDAMCMODANB()
	{
		GGFJGHHHEJC = this;
		NFEDMNJKNBH();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(InitializeAlwaysLoadedLocations));
	}

	private void ODIMDOBMFMN()
	{
		AFCAEJFIHLM = new PlayerSceneState[4];
		Scenes = new List<OnlineSceneState>();
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			OnlineSceneState item = new OnlineSceneState(value);
			Scenes.Add(item);
		}
	}

	private static AsyncOperation KGPHEBALHHF(Location NFHFNKHHGGI)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.Loaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.CBAFOEGBADB(SceneLoadingStates.Loaded);
				if (OnlineManager.IsMasterClient())
				{
					onlineSceneState.OOICHGHKKHF((SceneLoadingStates)6);
				}
				CommonReferences.MNFMOEKMJKN().loadingLocation[NFHFNKHHGGI] = true;
				AsyncOperation obj = SceneManager.UnloadSceneAsync(NFHFNKHHGGI.ToString());
				obj.completed += delegate
				{
					DGJGMKLMKJM(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("ReceiveActorPosition" + NFHFNKHHGGI.ToString() + "AceT_Quest"));
		return null;
	}

	private static void DGJGMKLMKJM(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.GMCMKHHFGPM(SceneLoadingStates.NotLoaded);
		if (OnlineManager.IsMasterClient())
		{
			onlineSceneState.PAEEHLKHAOO(SceneLoadingStates.NotLoaded);
		}
	}

	private void GFLFDLIMOLI()
	{
		GGFJGHHHEJC = this;
		ADGPJJJIIME();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(InitializeAlwaysLoadedLocations));
	}

	public static void BMBCLMFBIEG(Location NFHFNKHHGGI)
	{
		if (EPJANNNMKEI(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			ILGNDGNGABO(NFHFNKHHGGI);
		}
	}

	public static bool MFDNGMFIAKM(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.Loading;
	}

	private static void PMIPJANCPIF(Location NFHFNKHHGGI)
	{
		if (OnlineManager.JPPBEIJDCLJ() && AFOOAIEIHJC(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			NHDAAMIDCHC(NFHFNKHHGGI);
		}
	}

	public static AsyncOperation JEKDLEBBJEE(Location NFHFNKHHGGI)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.NotLoaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (!((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.MGOJPGBFNAF(SceneLoadingStates.Loading);
				if (OnlineManager.JPPBEIJDCLJ())
				{
					onlineSceneState.JFAHGNHIBJI(SceneLoadingStates.NotLoaded);
				}
				CommonReferences.MNFMOEKMJKN().loadingLocation[NFHFNKHHGGI] = true;
				AsyncOperation obj = SceneManager.LoadSceneAsync(NFHFNKHHGGI.ToString(), (LoadSceneMode)1);
				obj.completed += delegate
				{
					AGPNLNJOIKF(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("Crafter not attached on OnlineCrafter of placeable " + NFHFNKHHGGI.ToString() + ""));
		return null;
	}

	public static bool PHPDAFFGIOL(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.NotLoaded;
	}

	private static void AGPNLNJOIKF(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.GMCMKHHFGPM(SceneLoadingStates.Loaded);
		if (OnlineManager.IsMasterClient())
		{
			onlineSceneState.PAEEHLKHAOO(SceneLoadingStates.Loaded);
		}
	}

	public static bool CDMBJJPAIFH(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.Loading;
	}

	private void Start()
	{
	}

	public static void DLODLOIGBKE(Location NFHFNKHHGGI)
	{
		if (NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == (SceneLoadingStates)5)
		{
			KHIFBIHFDFM(NFHFNKHHGGI);
		}
	}

	private static void PJJMAIJBDAL(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.MDMHCCNMJPN(SceneLoadingStates.Loading);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineSceneState.FPGHLONDBCB(SceneLoadingStates.Loading);
		}
	}

	public static AsyncOperation LoadSceneLocally(Location NFHFNKHHGGI)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		if (onlineSceneState.loadingStateLocal == SceneLoadingStates.NotLoaded)
		{
			Scene sceneByName = SceneManager.GetSceneByName(NFHFNKHHGGI.ToString());
			if (!((Scene)(ref sceneByName)).isLoaded)
			{
				onlineSceneState.GMCMKHHFGPM(SceneLoadingStates.Loading);
				if (OnlineManager.IsMasterClient())
				{
					onlineSceneState.PAEEHLKHAOO(SceneLoadingStates.Loading);
				}
				CommonReferences.GGFJGHHHEJC.loadingLocation[NFHFNKHHGGI] = true;
				AsyncOperation obj = SceneManager.LoadSceneAsync(NFHFNKHHGGI.ToString(), (LoadSceneMode)1);
				obj.completed += delegate
				{
					AGPNLNJOIKF(NFHFNKHHGGI);
				};
				return obj;
			}
		}
		Debug.LogException(new Exception("Scene " + NFHFNKHHGGI.ToString() + " cannot be loaded at this time. Either it's already loaded or it's in the process of unloading."));
		return null;
	}

	public static void InitializeAlwaysLoadedLocations()
	{
		AGPNLNJOIKF(Location.Road);
		AGPNLNJOIKF(Location.Tavern);
		AGPNLNJOIKF(Location.BarnInterior);
	}

	public static SceneLoadingStates EPJANNNMKEI(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster;
	}

	private static void LCPICFOGJOL(Location NFHFNKHHGGI)
	{
		if (OnlineManager.IsMasterClient() && GetSceneMasterLoadingState(NFHFNKHHGGI) == (SceneLoadingStates)7)
		{
			KGPHEBALHHF(NFHFNKHHGGI);
		}
	}

	public static bool NEBKPNBPBDC(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster == SceneLoadingStates.NotLoaded;
	}

	private static void KHIFBIHFDFM(Location NFHFNKHHGGI)
	{
		if (OnlineManager.IsMasterClient() && GetSceneMasterLoadingState(NFHFNKHHGGI) == SceneLoadingStates.Loaded)
		{
			COALBANJIFO(NFHFNKHHGGI);
		}
	}

	private static void DHDGLCEPNGJ(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = NGBGLLFMAFD(NFHFNKHHGGI);
		onlineSceneState.MDMHCCNMJPN((SceneLoadingStates)6);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			onlineSceneState.FJEEIOFCKNB(SceneLoadingStates.NotLoaded);
		}
	}

	private void PLFEJDOEIAI()
	{
		AFCAEJFIHLM = new PlayerSceneState[4];
		Scenes = new List<OnlineSceneState>();
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			OnlineSceneState item = new OnlineSceneState(value);
			Scenes.Add(item);
		}
	}

	public static void RequestSceneLoad(Location NFHFNKHHGGI)
	{
		if (GetSceneMasterLoadingState(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			GGCMJDBPMOM(NFHFNKHHGGI);
		}
	}

	private static OnlineSceneState NGBGLLFMAFD(Location NFHFNKHHGGI)
	{
		OnlineSceneState onlineSceneState = GGFJGHHHEJC.Scenes.Find((OnlineSceneState _search) => _search.location == NFHFNKHHGGI);
		if (onlineSceneState == null)
		{
			Debug.LogError((object)$"Scene with location: {NFHFNKHHGGI} has not been added. Adding to scene manager.");
			onlineSceneState = new OnlineSceneState(NFHFNKHHGGI);
			GGFJGHHHEJC.Scenes.Add(onlineSceneState);
		}
		return onlineSceneState;
	}

	private static void FGBGJIALELC(Location NFHFNKHHGGI)
	{
		if (OnlineManager.JPPBEIJDCLJ() && AFOOAIEIHJC(NFHFNKHHGGI) == SceneLoadingStates.NotLoaded)
		{
			LoadSceneLocally(NFHFNKHHGGI);
		}
	}

	public static SceneLoadingStates AFOOAIEIHJC(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateMaster;
	}

	public static bool IsSceneLoadedLocally(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == SceneLoadingStates.Loaded;
	}

	public static bool OECMHNIJONM(Location NFHFNKHHGGI)
	{
		return NGBGLLFMAFD(NFHFNKHHGGI).loadingStateLocal == (SceneLoadingStates)8;
	}

	private void CKFMGPNONAN()
	{
		AFCAEJFIHLM = new PlayerSceneState[4];
		Scenes = new List<OnlineSceneState>();
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			OnlineSceneState item = new OnlineSceneState(value);
			Scenes.Add(item);
		}
	}

	public void ADGPJJJIIME()
	{
		PLFEJDOEIAI();
	}
}
