using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TravelZone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EADPNOFAILE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TravelZone _003C_003E4__this;

		public int playerNum;

		private TilemapScene _003CtilemapScene_003E5__2;

		private TravelZone _003CzoneTo_003E5__3;

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
		public EADPNOFAILE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TravelZone travelZone = _003C_003E4__this;
			FadeCamera player2;
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
				if (IGHHHLBLKCP != null)
				{
					goto IL_006c;
				}
				goto IL_0078;
			case 2:
				_003C_003E1__state = -1;
				goto IL_006c;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0098;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0105;
			case 5:
				{
					_003C_003E1__state = -1;
					FadeCamera.GetPlayer(playerNum).FadeInWithDelay();
					FadeCamera player = FadeCamera.GetPlayer(playerNum);
					player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(travelZone.GIMCLDHIBLL));
					PlayerController.GetPlayer(playerNum).characterAnimation.LookDirectionByAngle(_003CzoneTo_003E5__3.lookDirection);
					travelZone.OnTravelZoneFrom(playerNum);
					_003CzoneTo_003E5__3.CloseDoor();
					_003CzoneTo_003E5__3.OnTravelZoneTo(playerNum);
					CommonReferences.GGFJGHHHEJC.loadingLocation[travelZone.locationTo] = false;
					return false;
				}
				IL_006c:
				if (!IGHHHLBLKCP.isDone)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0078;
				IL_0078:
				if (PGJBPJNFFJK != null)
				{
					goto IL_0098;
				}
				goto IL_00a4;
				IL_0098:
				if (!PGJBPJNFFJK.isDone)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_00a4;
				IL_0105:
				if (_003CtilemapScene_003E5__2.updatingTerrain)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				goto IL_0112;
				IL_00a4:
				if (travelZone.locationTo != 0 && (Object)(object)travelZone.forceTravelZoneTo == (Object)null && travelZone.forceTravelToMineLevel == -1)
				{
					_003CtilemapScene_003E5__2 = TravelZonesManager.GGFJGHHHEJC.allTilemapScenes[travelZone.locationTo];
					if ((Object)(object)_003CtilemapScene_003E5__2 != (Object)null)
					{
						goto IL_0105;
					}
				}
				goto IL_0112;
				IL_0112:
				_003CzoneTo_003E5__3 = travelZone.GetTravelZoneTo();
				if (travelZone.locationTo != 0 && (Object)(object)travelZone.forceTravelZoneTo == (Object)null && travelZone.forceTravelToMineLevel == -1)
				{
					_003CtilemapScene_003E5__2 = TravelZonesManager.GGFJGHHHEJC.allTilemapScenes[travelZone.locationTo];
					if ((Object)(object)_003CtilemapScene_003E5__2 != (Object)null)
					{
						if (TavernVisionManager.GetPlayer(playerNum).IKNOJDMCFOK)
						{
							TavernVisionManager.GetPlayer(playerNum).IKNOJDMCFOK = _003CtilemapScene_003E5__2.canUseDecorationMode;
						}
						if (DecorationMode.GetPlayer(playerNum).DMBFKFLDDLH)
						{
							DecorationMode.GetPlayer(playerNum).DMBFKFLDDLH = _003CtilemapScene_003E5__2.canUseDecorationMode;
						}
					}
				}
				player2 = FadeCamera.GetPlayer(playerNum);
				player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(travelZone.Travelling));
				CommonReferences.GGFJGHHHEJC.OnTravel(playerNum);
				CommonReferences.GGFJGHHHEJC.OnTravelWithZones(playerNum, travelZone, _003CzoneTo_003E5__3);
				_003C_003E2__current = CommonReferences.waitRealtime02;
				_003C_003E1__state = 5;
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
	private sealed class EDJCABMIJMN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public string sceneName;

		public TravelZone _003C_003E4__this;

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
		public EDJCABMIJMN(int _003C_003E1__state)
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
			TravelZone travelZone = _003C_003E4__this;
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
				if (playerNum == 1)
				{
					PGJBPJNFFJK = SceneManager.LoadSceneAsync(sceneName, (LoadSceneMode)1);
					goto IL_0077;
				}
				goto IL_0083;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0077;
			case 3:
				{
					_003C_003E1__state = -1;
					goto IL_00b6;
				}
				IL_00b6:
				if (!IGHHHLBLKCP.isDone)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				break;
				IL_0077:
				if (!PGJBPJNFFJK.isDone)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0083;
				IL_0083:
				if (playerNum != 2)
				{
					break;
				}
				IGHHHLBLKCP = SceneManager.LoadSceneAsync(sceneName, (LoadSceneMode)1);
				goto IL_00b6;
			}
			((MonoBehaviour)travelZone).StartCoroutine(travelZone.LFDIBPFMMAK(playerNum));
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

	private static TravelZone IADEMLIIDPC;

	public Action<int> OnTravelZoneFrom = delegate
	{
	};

	public Action<int> OnTravelZoneTo = delegate
	{
	};

	public Vector2 lookDirection;

	[SerializeField]
	private Door door;

	public Transform playerPosition;

	public Transform playerPosition2;

	public Transform positionOnPathRequest;

	public Vector2 positionOnPathRequestThread = Vector2.zero;

	public bool blocked;

	[SerializeField]
	private Transform squaresParent;

	[SerializeField]
	private Transform square1;

	[SerializeField]
	private Transform square2;

	[SerializeField]
	private Transform[] extraNodePoints;

	[SerializeField]
	private bool squaresParentAddingPositionToDictionary = true;

	[SerializeField]
	private bool removePreviousScene = true;

	[SerializeField]
	private bool waitForAllPlayers;

	public Vector3 position;

	public Vector3 position2;

	private static bool MILNEPJHBDE;

	private static bool GIAMEAIFOOG;

	public Location location;

	public Vector2Int mineStairs;

	public bool isTavernFloor;

	public TavernFloor floor;

	public Location locationTo;

	public TravelZone forceTravelZoneTo;

	[HideInInspector]
	public int forceTravelToMineLevel = -1;

	public TavernFloor floorTo;

	public BarnTilemapScene barnTilemapScene;

	public Barn barn;

	public Collider2D blockingCollider;

	private static AsyncOperation PGJBPJNFFJK;

	private static AsyncOperation IGHHHLBLKCP;

	private static bool MMCINNOCPCE = true;

	public static TravelZone GGFJGHHHEJC => IADEMLIIDPC;

	public Vector2Int PDBAPHJCICN => new Vector2Int(((Vector2Int)(ref mineStairs)).y, ((Vector2Int)(ref mineStairs)).x);

	private void ALFCEFIKBGA(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnTravelFinish(JIIGOACEIKL);
		CommonReferences.MNFMOEKMJKN().OnTravelWithZonesFinished(JIIGOACEIKL, this, KLEIGOKONOM());
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = false;
		}
		PlayerInputs.ILCHIKOPNBI(JIIGOACEIKL, (MonoBehaviour)(object)this);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(JIIGOACEIKL);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(KMKIGJILAGB));
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer.CCCPHIJODBA();
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ~(ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			CommonReferences.MNFMOEKMJKN().OnTravelToCellar(JIIGOACEIKL);
		}
		JNJJABBOOFP(JIIGOACEIKL);
		if (JIIGOACEIKL == 5)
		{
			GIAMEAIFOOG = false;
		}
		else
		{
			MILNEPJHBDE = true;
		}
	}

	public Vector2 GetPositionOnPathRequest()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (positionOnPathRequestThread != Vector2.zero)
		{
			return positionOnPathRequestThread;
		}
		return Vector2.op_Implicit(GetMiddlePosition());
	}

	private bool CGENCCKJDBI(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.Port)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.Port)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Port)
			{
				return true;
			}
		}
		return false;
	}

	private bool KDCHIDJFJCA(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			return PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF);
		}
		if (!PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF))
		{
			return true;
		}
		if (OFFIEFEDJBF(GELMAIBEHDO) == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior) && LCMCPOJEOJA(GELMAIBEHDO) == 0)
		{
			return true;
		}
		return true;
	}

	private bool AJNMIANJCAN(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
		{
			if (EventsManager.CJMECHEOFOF(EventsManager.EventType.OathFeast))
			{
				return false;
			}
			if (EventsManager.CJMECHEOFOF((EventsManager.EventType)(-125)))
			{
				return false;
			}
		}
		return true;
	}

	private void GIMCLDHIBLL(int JIIGOACEIKL)
	{
		CommonReferences.GGFJGHHHEJC.OnTravelFinish(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.OnTravelWithZonesFinished(JIIGOACEIKL, this, GetTravelZoneTo());
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = false;
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = false;
		}
		PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GIMCLDHIBLL));
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.SendFinishTeleport();
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.Cellar)
		{
			CommonReferences.GGFJGHHHEJC.OnTravelToCellar(JIIGOACEIKL);
		}
		MNJNMLIDADC(JIIGOACEIKL);
		if (JIIGOACEIKL == 2)
		{
			GIAMEAIFOOG = false;
		}
		else
		{
			MILNEPJHBDE = false;
		}
	}

	private void LDCLPIDIFIF()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)positionOnPathRequest))
		{
			positionOnPathRequestThread = Vector2.op_Implicit(Utils.MJEACANINDN(positionOnPathRequest.position));
		}
		if (extraNodePoints != null && extraNodePoints.Length != 0)
		{
			position = Utils.MJEACANINDN(extraNodePoints[0].position);
		}
		else
		{
			position = square1.position + Vector3.one * 0.25f;
		}
		position2 = square2.position + Vector3.one * 0.25f;
	}

	private bool JKLFMKOJBOK(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.Farm && NFHFNKHHGGI != Location.FarmShop)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.Farm || NFHFNKHHGGI == Location.FarmShop)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Farm)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.FarmShop)
			{
				return true;
			}
		}
		return false;
	}

	private int MGFGFLADNOA(int GELMAIBEHDO)
	{
		if (GELMAIBEHDO == 1)
		{
			return PlayerController.GetPlayer(6).HCBDDKHPHCF;
		}
		return PlayerController.GetPlayer(0).HCBDDKHPHCF;
	}

	private Vector3 EBNJNICOFEP(int PCPNHOGEFAM, bool FADDMLDBKAO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PCPNHOGEFAM <= 1 || !FADDMLDBKAO)
		{
			return Vector3.zero;
		}
		float num = 0.5f;
		float num2 = 0.1f;
		int num3 = ((PCPNHOGEFAM % 2 == 0) ? 1 : (-1));
		int num4 = (((PCPNHOGEFAM - 2) / 2 % 2 == 0) ? 1 : (-1));
		return new Vector3((float)num3 * num, (float)num4 * num2, 0f);
	}

	private Location DAIIGMBDNDF(int GELMAIBEHDO)
	{
		if (GELMAIBEHDO == 0)
		{
			return PlayerController.OPHDCMJLLEC(4).LEOIMFNKFGA;
		}
		return PlayerController.GetPlayer(1).LEOIMFNKFGA;
	}

	private void Awake()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		TravelZonesManager.GGFJGHHHEJC.AddToDictionary(this);
		position = ((Component)this).transform.position;
		if ((Object)(object)barn != (Object)null)
		{
			Placeable placeable = barn.placeable;
			placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
			Placeable placeable2 = barn.placeable;
			placeable2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(placeable2.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		}
	}

	public void StartTravelZone(int JIIGOACEIKL)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.TravelZoneBlocked(JIIGOACEIKL, this))
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && locationTo == Location.Tavern && OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("TavernInConstruction", JIIGOACEIKL);
			return;
		}
		if (OnlineManager.PlayingOnline() && locationTo == Location.BarnInterior && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 0)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("BarnBlocked", JIIGOACEIKL);
			return;
		}
		TravelZonesManager.GGFJGHHHEJC.SetLastTravelZonePosition(JIIGOACEIKL, Vector2.op_Implicit(((Component)this).transform.position));
		if (OnlineManager.PlayingOnline() && locationTo == Location.PetShop)
		{
			PetShopColliders.instance.ActivateColliders(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PlayingOnline() && location == Location.PetShop)
		{
			PetShopColliders.instance.ActivateColliders(DMBFKFLDDLH: true);
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			if (!MILNEPJHBDE)
			{
				MILNEPJHBDE = true;
				AFEDDCPKIOO(JIIGOACEIKL);
			}
			break;
		case 2:
			if (!OnlineManager.PlayingOnline() && !GIAMEAIFOOG)
			{
				GIAMEAIFOOG = true;
				AFEDDCPKIOO(JIIGOACEIKL);
			}
			break;
		}
	}

	public Vector3 GetRandomPosition()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		MMCINNOCPCE = !MMCINNOCPCE;
		if (!MMCINNOCPCE)
		{
			return position2;
		}
		return position;
	}

	private void LLDPMNJAPBA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)((Component)this).transform != (Object)null)
			{
				ChangePosition(((Component)this).transform.position);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private IEnumerator FEJJPMHCDJD(int JIIGOACEIKL)
	{
		return new EADPNOFAILE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private bool CKIIMOJLGAH(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.City && NFHFNKHHGGI == Location.Road)
			{
				return true;
			}
			if (NLNFBILJJEF == Location.City && NFHFNKHHGGI == Location.CastleGarden)
			{
				return true;
			}
			if (NLNFBILJJEF == Location.City && NFHFNKHHGGI == Location.Port)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.City)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.PetShop)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Sawmill)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Blacksmith)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.CityTavern)
			{
				return true;
			}
		}
		return false;
	}

	public void BlockTravelZone()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("Blocking collider not atttached to " + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = true;
		blocked = true;
	}

	private void JDPBHJHGEJG()
	{
		Debug.LogError((object)"[CrystalPuzzle] - Initialize");
		if (MILNEPJHBDE)
		{
			Debug.LogError((object)"Dialogue System/Conversation/UnhappyRentRoom/Entry/2/Dialogue Text");
			return;
		}
		MILNEPJHBDE = true;
		int num = 0;
		PlayerInputs.LPJCFCODNFA(num, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CommonReferences.MNFMOEKMJKN().OnTravelStart(num);
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = false;
		FadeCamera.EIFPKCAFDIB(num).AJHDEBOMHKK(1332f);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(num);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(HBPEDJNKENJ));
		QuestTooltipUI.MLPCDJPLBAC().BOBCIFEDJED();
		ItemTooltip.EOPIEMLAPFN(num).FCACMDNLAIG(MDIKPGGBNLI: true);
		GEADOKLLPOC(num);
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.NNNBDLGMHEC(locationTo, num);
	}

	private bool EHMJNJCMAIN(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.HDBECFMPJHL())
		{
			if (NLNFBILJJEF == ~(Location.Tavern | Location.River))
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != (Location.Road | Location.Quarry | Location.Farm | Location.FarmShop) && NLNFBILJJEF != (Location.Tavern | Location.Quarry | Location.Farm))
			{
				return true;
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == (Location.Tavern | Location.River) || IJMBMDBCPHI(GELMAIBEHDO) == ~Location.Farm)
			{
				return true;
			}
		}
		return true;
	}

	private void DKPKHCPGPJI(int JIIGOACEIKL)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		TravelZone travelZoneTo = GetTravelZoneTo();
		if (JIIGOACEIKL == 2)
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, ((Object)(object)travelZoneTo.playerPosition2 == (Object)null) ? ((Component)travelZoneTo).transform.position : travelZoneTo.playerPosition2.position, travelZoneTo.location);
		}
		else
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, (((Object)(object)travelZoneTo.playerPosition == (Object)null) ? ((Component)travelZoneTo).transform.position : travelZoneTo.playerPosition.position) + EBNJNICOFEP(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL), PEAKAOOEKBC(travelZoneTo)), travelZoneTo.location);
		}
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.SendStartTeleport((((Object)(object)travelZoneTo.playerPosition == (Object)null) ? ((Component)travelZoneTo).transform.position : travelZoneTo.playerPosition.position) + EBNJNICOFEP(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL), PEAKAOOEKBC(travelZoneTo)));
		}
		StuckRecoverySystem.instance.ResetAndSeedFromTravelZone(JIIGOACEIKL, travelZoneTo);
	}

	private void NLBCNFEAACJ(int JIIGOACEIKL)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		TravelZone travelZone = NOJLAHMDNLB();
		if (JIIGOACEIKL == 6)
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, ((Object)(object)travelZone.playerPosition2 == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition2.position, travelZone.location);
		}
		else
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, (((Object)(object)travelZone.playerPosition == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition.position) + FGKDCFONMOO(OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL), PEAKAOOEKBC(travelZone)), travelZone.location);
		}
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer.SendStartTeleport((((Object)(object)travelZone.playerPosition == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition.position) + FGKDCFONMOO(OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL), HLEHJPPBHGK(travelZone)));
		}
		StuckRecoverySystem.instance.ResetAndSeedFromTravelZone(JIIGOACEIKL, travelZone);
	}

	public Vector3 DCAPGCMBHIM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Utils.MJEACANINDN((position + position2) / 1281f);
	}

	private IEnumerator COGCMHOLAGN(int JIIGOACEIKL, string IIBONBIIHDE)
	{
		return new EDJCABMIJMN(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			sceneName = IIBONBIIHDE
		};
	}

	private int LCMCPOJEOJA(int GELMAIBEHDO)
	{
		if (GELMAIBEHDO == 1)
		{
			return PlayerController.OPHDCMJLLEC(8).HCBDDKHPHCF;
		}
		return PlayerController.GetPlayer(0).HCBDDKHPHCF;
	}

	private IEnumerator IJCPPCLIMCM(int JIIGOACEIKL)
	{
		return new EADPNOFAILE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void MEAKJFEPKHF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if ((Object)(object)TravelZonesManager.OMFKNGDCJFN() != (Object)null)
			{
				TravelZonesManager.LKOABOAADCD().LCIIFLADHOE(((Component)this).transform.position, null);
				OMNKJEOBDAP(null);
				TravelZonesManager.BGMJCCFNNDL().NGHLICBJBKA(this);
			}
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(LLDPMNJAPBA));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(LLDPMNJAPBA));
			}
		}
	}

	private bool APAMLNNIKLL(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.CastleGarden && EventsManager.IsActive(EventsManager.EventType.OathFeast))
		{
			return true;
		}
		return false;
	}

	private bool GLCKJNDIAOO(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (NLNFBILJJEF == (Location.River | Location.Quarry | Location.Farm | Location.FarmShop) && NFHFNKHHGGI != ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.FarmShop))
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != (Location.Camp | Location.BarnInterior) || NFHFNKHHGGI == ~Location.River)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.FarmShop))
			{
				return true;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~(Location.Road | Location.Camp | Location.Farm | Location.BarnInterior))
			{
				return true;
			}
		}
		return true;
	}

	private bool OJOJKDFALNB(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == ~(Location.Camp | Location.Quarry | Location.BarnInterior) && NFHFNKHHGGI != (Location.River | Location.Quarry))
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != ~(Location.River | Location.Camp | Location.Farm | Location.BarnInterior) || NFHFNKHHGGI == ~(Location.Quarry | Location.BarnInterior))
			{
				return true;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == (Location.Road | Location.Farm))
			{
				return false;
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.FarmShop))
			{
				return false;
			}
		}
		return false;
	}

	private bool LCKAEAFGGKK(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.River && NFHFNKHHGGI == Location.Farm)
		{
			return true;
		}
		if (NLNFBILJJEF == Location.River && NFHFNKHHGGI == Location.Forest && MusicController.instance.basicMoodMusicPaused)
		{
			return true;
		}
		return false;
	}

	public void AAMDKIMCDLA()
	{
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			if (value != Location.Anywhere && value != ~(Location.River | Location.Camp) && value != Location.Tavern && value != Location.Camp && value != 0)
			{
				OEAOIKNJNAD(1, value);
			}
		}
	}

	public void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("Player") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("Player2"))
		{
			return;
		}
		if (blocked)
		{
			PlayerController.GetPlayer((!((Component)LGGCFCHOOMB).gameObject.CompareTag("Player2")) ? 1 : 2).PlayerBark("Player/Bark/OathFeastBlock");
			return;
		}
		PlayerController component = ((Component)LGGCFCHOOMB).gameObject.GetComponent<PlayerController>();
		if (waitForAllPlayers)
		{
			if (locationTo == Location.CastleGarden && EventsManager.IsOathFeastFirstActivation())
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, BanquetEvent.TeleportPlayerToCastleGardenWithTravelZone);
				return;
			}
			if ((location == Location.Tavern || location == Location.RoomsMultiplayer) && locationTo == Location.Road && !OldMansDuelEvent.instance.sceneFinished && EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, OldMansDuelEvent.TeleportPlayerToRoad);
				return;
			}
			if (location == Location.BathhouseInterior && locationTo == Location.BathhouseInterior && EventsManager.IsActive(EventsManager.EventType.NinjaChallengeEvent))
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, delegate
				{
					NinjaChallengeEvent.TeleportPlayerToSecondFloor(this);
				});
				return;
			}
			if (location == Location.BathhouseInterior && locationTo == Location.Bathhouse && EventsManager.IsActive(EventsManager.EventType.Attack))
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, AttackEvent.TeleportToBathhouse);
				return;
			}
		}
		StartTravelZone(component.GetPlayerNum());
	}

	private void GGAGEOJBGEN(int JIIGOACEIKL, Location BAIMHDBJPDK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.SinglePlayer() || (PlayerController.GetPlayer(1).LEOIMFNKFGA != BAIMHDBJPDK && PlayerController.GetPlayer(2).LEOIMFNKFGA != BAIMHDBJPDK))
		{
			Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				SceneManager.UnloadSceneAsync(BAIMHDBJPDK.ToString());
			}
		}
	}

	private void PAFBNIBEFEB(TravelZone PHGGMIMGFDK)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (squaresParentAddingPositionToDictionary)
		{
			for (int i = 0; i < squaresParent.childCount; i += 0)
			{
				if ((Object)(object)PHGGMIMGFDK != (Object)null || (Object)(object)TravelZonesManager.OMFKNGDCJFN().CPLBJKJDLPA(squaresParent.GetChild(i).position + Vector3.one * 492f) == (Object)(object)this)
				{
					TravelZonesManager.DCAEBALADIM().OFJAIFINCNA(squaresParent.GetChild(i).position + Vector3.one * 1384f, PHGGMIMGFDK);
				}
			}
		}
		for (int j = 0; j < extraNodePoints.Length; j += 0)
		{
			if ((Object)(object)PHGGMIMGFDK != (Object)null || (Object)(object)TravelZonesManager.OMFKNGDCJFN().CPLBJKJDLPA(extraNodePoints[j].position) == (Object)(object)this)
			{
				TravelZonesManager.OLHBLKIAFOM().LCIIFLADHOE(extraNodePoints[j].position, PHGGMIMGFDK);
			}
		}
	}

	private bool BCJLIECCECI(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
		{
			if (EventsManager.IOLMGKKGLMD(EventsManager.EventType.KyrohWaterfall))
			{
				return true;
			}
			if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-14)))
			{
				return true;
			}
		}
		return false;
	}

	public void KACGDPCMGPL(int JIIGOACEIKL)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (NewTutorialManager.AHGAJOEBHEO(JIIGOACEIKL, this))
		{
			return;
		}
		if (OnlineManager.PlayingOnline() && locationTo == Location.None && OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("City/Petra/Introduce", JIIGOACEIKL, ECPEFDHOFHN: false);
			return;
		}
		if (OnlineManager.PlayingOnline() && locationTo == ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) && OnlineFarmConstructionManager.instance.farmModeOpenedByOtherPlayer > 1)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("ValueName", JIIGOACEIKL, ECPEFDHOFHN: false);
			return;
		}
		TravelZonesManager.EKDNJDJHONF().GJFPJJICGHI(JIIGOACEIKL, Vector2.op_Implicit(((Component)this).transform.position));
		if (OnlineManager.PlayingOnline() && locationTo == (Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			PetShopColliders.instance.JEOFFGNOEPI(DMBFKFLDDLH: false);
		}
		if (OnlineManager.PlayingOnline() && location == ~(Location.Tavern | Location.Road | Location.Camp | Location.FarmShop))
		{
			PetShopColliders.instance.LKAJIJKEONM(DMBFKFLDDLH: false);
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			if (!MILNEPJHBDE)
			{
				MILNEPJHBDE = false;
				NNABCHDEICD(JIIGOACEIKL);
			}
			break;
		case 7:
			if (!OnlineManager.PlayingOnline() && !GIAMEAIFOOG)
			{
				GIAMEAIFOOG = false;
				AFEDDCPKIOO(JIIGOACEIKL);
			}
			break;
		}
	}

	private Vector3 FGKDCFONMOO(int PCPNHOGEFAM, bool FADDMLDBKAO)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (PCPNHOGEFAM <= 0 || !FADDMLDBKAO)
		{
			return Vector3.zero;
		}
		float num = 1615f;
		float num2 = 179f;
		int num3 = ((PCPNHOGEFAM % 5 != 0) ? (-1) : 0);
		int num4 = (((PCPNHOGEFAM - 7) / 4 % 6 == 0) ? 1 : (-1));
		return new Vector3((float)num3 * num, (float)num4 * num2, 1579f);
	}

	private void KPHPNMOIBLF(int GELMAIBEHDO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			if (GPHICIEOCEE(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-73, 875f);
			}
			else if (APAMLNNIKLL(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(-50, 379f);
			}
			else if (JAAALGILLNI(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(-30, 1157f);
			}
			else if (EMEKPNIGAKP(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-80, 561f);
			}
			else if (LCCDHIJDGDM(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(74, 508f);
			}
			else if (DAFPDLKAHHO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(-71, 1337f);
			}
			else if (HMIBDBICIBJ(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (DHEEJMOCJAH(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood(Location.Tavern);
			}
			else if (NPGIJHILBNK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(113, 277f);
			}
			else if (LOBLMOLNCKC(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (EHMJNJCMAIN(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(10, 303f);
			}
			else if (CGENCCKJDBI(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(-54, 1361f);
			}
			else if (KBJLMHIBJIO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-124, 1107f);
			}
			else if (KDCHIDJFJCA(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(-93, 879f);
			}
			else if (IMFIHGALDGG(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.HNBHNFFEMHP();
			}
		}
	}

	private void OnEnable()
	{
		RoomUpgrader instance = RoomUpgrader.GGFJGHHHEJC;
		instance.OnRoomUpgradeStart = (Action)Delegate.Combine(instance.OnRoomUpgradeStart, new Action(LKBDJCPENDD));
		RoomUpgrader instance2 = RoomUpgrader.GGFJGHHHEJC;
		instance2.OnRoomUpgradeEnd = (Action)Delegate.Combine(instance2.OnRoomUpgradeEnd, new Action(LDCLPIDIFIF));
	}

	private void BNEEAPCOLGN(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		PJLKLDHMGCP(((Component)this).transform.position);
	}

	private bool GEOALDPMMEH(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.InnkeepersCave)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.InnkeepersCave)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.InnkeepersCave)
			{
				return true;
			}
		}
		return false;
	}

	private IEnumerator LFDIBPFMMAK(int JIIGOACEIKL)
	{
		yield return null;
		if (IGHHHLBLKCP != null)
		{
			while (!IGHHHLBLKCP.isDone)
			{
				yield return null;
			}
		}
		if (PGJBPJNFFJK != null)
		{
			while (!PGJBPJNFFJK.isDone)
			{
				yield return null;
			}
		}
		if (locationTo != 0 && (Object)(object)forceTravelZoneTo == (Object)null && forceTravelToMineLevel == -1)
		{
			TilemapScene tilemapScene2 = TravelZonesManager.GGFJGHHHEJC.allTilemapScenes[locationTo];
			if ((Object)(object)tilemapScene2 != (Object)null)
			{
				while (tilemapScene2.updatingTerrain)
				{
					yield return null;
				}
			}
		}
		TravelZone zoneTo = GetTravelZoneTo();
		if (locationTo != 0 && (Object)(object)forceTravelZoneTo == (Object)null && forceTravelToMineLevel == -1)
		{
			TilemapScene tilemapScene2 = TravelZonesManager.GGFJGHHHEJC.allTilemapScenes[locationTo];
			if ((Object)(object)tilemapScene2 != (Object)null)
			{
				if (TavernVisionManager.GetPlayer(JIIGOACEIKL).IKNOJDMCFOK)
				{
					TavernVisionManager.GetPlayer(JIIGOACEIKL).IKNOJDMCFOK = tilemapScene2.canUseDecorationMode;
				}
				if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
				{
					DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH = tilemapScene2.canUseDecorationMode;
				}
			}
		}
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(Travelling));
		CommonReferences.GGFJGHHHEJC.OnTravel(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.OnTravelWithZones(JIIGOACEIKL, this, zoneTo);
		yield return CommonReferences.waitRealtime02;
		FadeCamera.GetPlayer(JIIGOACEIKL).FadeInWithDelay();
		FadeCamera player2 = FadeCamera.GetPlayer(JIIGOACEIKL);
		player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(GIMCLDHIBLL));
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookDirectionByAngle(zoneTo.lookDirection);
		OnTravelZoneFrom(JIIGOACEIKL);
		zoneTo.CloseDoor();
		zoneTo.OnTravelZoneTo(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.loadingLocation[locationTo] = false;
	}

	public void OKPNDBINMMA()
	{
		if (Object.op_Implicit((Object)(object)door) && door.GIGOAOEHKBA())
		{
			door.HKNDBJPCFBF();
		}
	}

	private void LIHOHCKFEMG(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(JIIGOACEIKL);
		if (JIIGOACEIKL == 0)
		{
			CommonReferences.MNFMOEKMJKN().travelZoneBeingUsed = true;
		}
		else
		{
			CommonReferences.MNFMOEKMJKN().travelZoneBeingUsed2 = false;
		}
		FadeCamera.GetPlayer(JIIGOACEIKL).GPBOEBGJJPM(571f);
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(Travelling));
		QuestTooltipUI.MLPCDJPLBAC().BOBCIFEDJED();
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		GEADOKLLPOC(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.BAJPNPNOLHF(locationTo, JIIGOACEIKL);
	}

	private bool DHEEJMOCJAH(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.None && NFHFNKHHGGI == (Location.Road | Location.River | Location.BarnInterior | Location.FarmShop))
		{
			return false;
		}
		return true;
	}

	public void Travelling(int JIIGOACEIKL)
	{
		if (location == Location.Mine && locationTo == Location.Mine && !MineManager.TravelToLevel(JIIGOACEIKL, this))
		{
			return;
		}
		if (location == Location.Mine && locationTo != Location.Mine)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.MineExit();
		}
		DKPKHCPGPJI(JIIGOACEIKL);
		bool flag = false;
		if (locationTo != 0 && location != locationTo)
		{
			TilemapScene tilemapScene = Utils.JGEPCPFJANP(location);
			flag = (Object)(object)Utils.JGEPCPFJANP(locationTo) == (Object)null;
			if (flag)
			{
				GFJPNOEGCJI(JIIGOACEIKL, locationTo);
			}
			if ((Object)(object)tilemapScene != (Object)null && removePreviousScene && Utils.BKFNPIFHBDH(tilemapScene.location))
			{
				GGAGEOJBGEN(JIIGOACEIKL, location);
			}
		}
		if (!flag)
		{
			((MonoBehaviour)this).StartCoroutine(LFDIBPFMMAK(JIIGOACEIKL));
		}
		if (locationTo == Location.Camp)
		{
			CommonReferences.GGFJGHHHEJC.travelToCamp = true;
		}
		if (locationTo != 0)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetLocation(locationTo);
		}
		if (locationTo == Location.Bathhouse)
		{
			(Weather.instance.weatherParticles[1].playerOneParticles as RainParticlesManager).MaskRain(JDOIBAFOIPN: true);
			(Weather.instance.weatherParticles[1].playerTwoParticles as RainParticlesManager).MaskRain(JDOIBAFOIPN: true);
		}
		else
		{
			(Weather.instance.weatherParticles[1].playerOneParticles as RainParticlesManager).MaskRain(JDOIBAFOIPN: false);
			(Weather.instance.weatherParticles[1].playerTwoParticles as RainParticlesManager).MaskRain(JDOIBAFOIPN: false);
		}
		if (GameManager.SinglePlayer())
		{
			GC.Collect();
		}
	}

	private void BMOGLOEONLA(int GELMAIBEHDO)
	{
		if (KDNANKOHEJL(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.TriggerMusicTheme(7, 830f);
		}
		else if (APAMLNNIKLL(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.OODLAAKIFKI(1970f, MMEHJCGGNFE: true, 59);
		}
		else if (AJNMIANJCAN(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.OODLAAKIFKI(270f, MMEHJCGGNFE: false, -77);
		}
		else if (OJOJKDFALNB(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(550f);
		}
		else if (GPHICIEOCEE(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1147f);
		}
		else if (NJHBNCNCMMI(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1197f);
		}
		else if (ODGMJEHBMLE(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1695f);
		}
		else if (LCKAEAFGGKK(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1952f, MMEHJCGGNFE: true);
		}
		else if (BCPMJGFBNHJ(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.OODLAAKIFKI(265f, MMEHJCGGNFE: true, -122);
		}
		else if (DAFPDLKAHHO(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.OODLAAKIFKI(1193f, MMEHJCGGNFE: false, 119);
		}
		else if (HFDKOFPJCCO(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1658f, MMEHJCGGNFE: true);
		}
		else if (NPGIJHILBNK(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1176f, MMEHJCGGNFE: true);
		}
		else if (EHMJNJCMAIN(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(697f, MMEHJCGGNFE: false, -118);
		}
		else if (CGENCCKJDBI(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.OODLAAKIFKI(691f, MMEHJCGGNFE: true, -10);
		}
		else if (KBJLMHIBJIO(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1809f, MMEHJCGGNFE: false, 107);
		}
		else if (OBMEFLCDOPN(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(368f, MMEHJCGGNFE: false, -79);
		}
		else if (NDOCOAOBIDP(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(1504f, MMEHJCGGNFE: false, 60);
		}
	}

	public void ChangePosition(Vector3 PAICGEGHOCO)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		OMNKJEOBDAP(null);
		SetPosition(PAICGEGHOCO);
	}

	public void IOLHKGPBLJL()
	{
		if (Object.op_Implicit((Object)(object)door) && door.AGJJEBPPPAC())
		{
			door.JDHOOAABPMJ();
		}
	}

	private bool KDNANKOHEJL(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (NLNFBILJJEF == Location.BarnInterior)
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != 0)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == (Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
		}
		return true;
	}

	private void Start()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)barn == (Object)null)
		{
			SetPosition(((Component)this).transform.position);
		}
		if (Object.op_Implicit((Object)(object)positionOnPathRequest))
		{
			positionOnPathRequestThread = Vector2.op_Implicit(Utils.MJEACANINDN(positionOnPathRequest.position));
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(LLDPMNJAPBA));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(LLDPMNJAPBA));
		if ((Object)(object)blockingCollider != (Object)null)
		{
			((Behaviour)blockingCollider).enabled = false;
		}
		if (location == Location.Mine && locationTo == Location.Mine && ((((Vector2Int)(ref mineStairs)).x == 0 && ((Vector2Int)(ref mineStairs)).y == 0) || (((Vector2Int)(ref mineStairs)).x == 0 && ((Vector2Int)(ref mineStairs)).y == 1)))
		{
			TravelZonesManager.GGFJGHHHEJC.allMineStairs[mineStairs] = this;
		}
	}

	private bool LCCDHIJDGDM(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.HDBECFMPJHL())
		{
			if (NLNFBILJJEF == (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior) && NFHFNKHHGGI == (Location.Road | Location.River))
			{
				return true;
			}
			if (NLNFBILJJEF == ~(Location.Tavern | Location.Camp | Location.Farm | Location.BarnInterior) && NFHFNKHHGGI == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.FarmShop))
			{
				return true;
			}
			if (NLNFBILJJEF == (Location.Tavern | Location.Road | Location.River | Location.BarnInterior | Location.FarmShop) && NFHFNKHHGGI == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.BarnInterior))
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != (Location.Road | Location.River | Location.Farm | Location.FarmShop))
			{
				return false;
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == ~(Location.Road | Location.River | Location.BarnInterior))
			{
				return true;
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == ~(Location.Tavern | Location.Quarry | Location.BarnInterior))
			{
				return true;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~Location.FarmShop)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == (Location.River | Location.Quarry | Location.FarmShop))
			{
				return false;
			}
		}
		return true;
	}

	public void PJLKLDHMGCP(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = PAICGEGHOCO;
		NBLDDKLJFIM();
		OMNKJEOBDAP(this);
	}

	private bool DAFPDLKAHHO(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.CastleGarden)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.CastleGarden)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Castle || IJMBMDBCPHI(GELMAIBEHDO) == Location.CastleGarden)
			{
				return true;
			}
		}
		return false;
	}

	private void NBLDDKLJFIM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)positionOnPathRequest))
		{
			positionOnPathRequestThread = Vector2.op_Implicit(Utils.MJEACANINDN(positionOnPathRequest.position));
		}
		if (extraNodePoints != null && extraNodePoints.Length != 0)
		{
			position = Utils.MJEACANINDN(extraNodePoints[0].position);
		}
		else
		{
			position = square1.position + Vector3.one * 721f;
		}
		position2 = square2.position + Vector3.one * 1205f;
	}

	private void COPPGMNNIBN(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		SetPosition(((Component)this).transform.position);
	}

	private bool DEKICAPLHBP(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.Beach && NFHFNKHHGGI != Location.WilsonHouse)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.Beach || NFHFNKHHGGI == Location.WilsonHouse)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Beach)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.WilsonHouse)
			{
				return true;
			}
		}
		return false;
	}

	public void KCBKJAJEAJL()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("Error_RoomZone" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = true;
		blocked = false;
	}

	private IEnumerator JBLAGOHKMLL(int JIIGOACEIKL)
	{
		yield return null;
		if (IGHHHLBLKCP != null)
		{
			while (!IGHHHLBLKCP.isDone)
			{
				yield return null;
			}
		}
		if (PGJBPJNFFJK != null)
		{
			while (!PGJBPJNFFJK.isDone)
			{
				yield return null;
			}
		}
		if (locationTo != 0 && (Object)(object)forceTravelZoneTo == (Object)null && forceTravelToMineLevel == -1)
		{
			TilemapScene tilemapScene2 = TravelZonesManager.GGFJGHHHEJC.allTilemapScenes[locationTo];
			if ((Object)(object)tilemapScene2 != (Object)null)
			{
				while (tilemapScene2.updatingTerrain)
				{
					yield return null;
				}
			}
		}
		TravelZone zoneTo = GetTravelZoneTo();
		if (locationTo != 0 && (Object)(object)forceTravelZoneTo == (Object)null && forceTravelToMineLevel == -1)
		{
			TilemapScene tilemapScene2 = TravelZonesManager.GGFJGHHHEJC.allTilemapScenes[locationTo];
			if ((Object)(object)tilemapScene2 != (Object)null)
			{
				if (TavernVisionManager.GetPlayer(JIIGOACEIKL).IKNOJDMCFOK)
				{
					TavernVisionManager.GetPlayer(JIIGOACEIKL).IKNOJDMCFOK = tilemapScene2.canUseDecorationMode;
				}
				if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
				{
					DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH = tilemapScene2.canUseDecorationMode;
				}
			}
		}
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(Travelling));
		CommonReferences.GGFJGHHHEJC.OnTravel(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.OnTravelWithZones(JIIGOACEIKL, this, zoneTo);
		yield return CommonReferences.waitRealtime02;
		FadeCamera.GetPlayer(JIIGOACEIKL).FadeInWithDelay();
		FadeCamera player2 = FadeCamera.GetPlayer(JIIGOACEIKL);
		player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(GIMCLDHIBLL));
		PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.LookDirectionByAngle(zoneTo.lookDirection);
		OnTravelZoneFrom(JIIGOACEIKL);
		zoneTo.CloseDoor();
		zoneTo.OnTravelZoneTo(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.loadingLocation[locationTo] = false;
	}

	private bool PCAIOHIAOGK(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.Mine)
		{
			if (NFHFNKHHGGI != Location.Mine)
			{
				return true;
			}
			if (forceTravelToMineLevel == 0)
			{
				return true;
			}
			if (((Vector2Int)(ref mineStairs)).x > 0 && ((Vector2Int)(ref mineStairs)).y == 0)
			{
				return true;
			}
		}
		return false;
	}

	private void DGGGMFPPIKI(int BBIPAKOIIGC)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DGGGMFPPIKI));
		((MonoBehaviour)this).StartCoroutine(BOCBAMENEJB());
	}

	private bool JAAALGILLNI(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.Road | Location.River | Location.Camp | Location.Quarry))
		{
			if (EventsManager.BBMAEAFHEFK(EventsManager.EventType.CastleForm))
			{
				return false;
			}
			if (EventsManager.NJBACCBIHID((EventsManager.EventType)31))
			{
				return true;
			}
		}
		return true;
	}

	private void GFJPNOEGCJI(int JIIGOACEIKL, Location BAIMHDBJPDK)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
		if (!((Scene)(ref sceneByName)).isLoaded)
		{
			if (!CommonReferences.GGFJGHHHEJC.loadingLocation[BAIMHDBJPDK])
			{
				((MonoBehaviour)this).StartCoroutine(FAAPOOIEAJD(JIIGOACEIKL, BAIMHDBJPDK.ToString()));
				CommonReferences.GGFJGHHHEJC.loadingLocation[BAIMHDBJPDK] = true;
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(LFDIBPFMMAK(JIIGOACEIKL));
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(LFDIBPFMMAK(JIIGOACEIKL));
		}
	}

	private void CIBNLDFOBPC()
	{
		NinjaChallengeEvent.HAGEKALEEED(this);
	}

	private Location OFFIEFEDJBF(int GELMAIBEHDO)
	{
		if (GELMAIBEHDO == 0)
		{
			return PlayerController.OPHDCMJLLEC(6).LEOIMFNKFGA;
		}
		return PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA;
	}

	private void OFJAIFINCNA(TravelZone PHGGMIMGFDK)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (squaresParentAddingPositionToDictionary)
		{
			for (int i = 0; i < squaresParent.childCount; i++)
			{
				if ((Object)(object)PHGGMIMGFDK != (Object)null || (Object)(object)TravelZonesManager.EKDNJDJHONF().IBEFLJNMABM(squaresParent.GetChild(i).position + Vector3.one * 1115f) == (Object)(object)this)
				{
					TravelZonesManager.DGCNCEDIFOF().BNBKDNGKMGG(squaresParent.GetChild(i).position + Vector3.one * 1856f, PHGGMIMGFDK);
				}
			}
		}
		for (int j = 1; j < extraNodePoints.Length; j += 0)
		{
			if ((Object)(object)PHGGMIMGFDK != (Object)null || (Object)(object)TravelZonesManager.DCAEBALADIM().GetTravelZoneAtPosition(extraNodePoints[j].position) == (Object)(object)this)
			{
				TravelZonesManager.BGMJCCFNNDL().COCCEJEHLNN(extraNodePoints[j].position, PHGGMIMGFDK);
			}
		}
	}

	private bool GPHICIEOCEE(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			if (NLNFBILJJEF == (Location.Tavern | Location.Farm) && NFHFNKHHGGI != ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != (Location.Quarry | Location.FarmShop) || NFHFNKHHGGI == ~(Location.Road | Location.BarnInterior | Location.FarmShop))
			{
				return true;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~(Location.Road | Location.Quarry | Location.Farm))
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.BarnInterior)
			{
				return true;
			}
		}
		return false;
	}

	public void CHCMOHJHHDB()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("OnlinePlayer" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = true;
		blocked = false;
	}

	private void JMONBCNBAAN()
	{
		Debug.LogError((object)"Look");
		if (MILNEPJHBDE)
		{
			Debug.LogError((object)"Skin index too high!: ");
			return;
		}
		MILNEPJHBDE = true;
		int num = 0;
		PlayerInputs.DisableKeyboardInputsAndMovement(num, (MonoBehaviour)(object)this);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(num);
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = false;
		FadeCamera.GetPlayer(num).IONMINJHMKL(1235f);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(num);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(DGGGMFPPIKI));
		QuestTooltipUI.DEGPIHEEFHJ().BOBCIFEDJED();
		ItemTooltip.IEABDMDELFO(num).FCACMDNLAIG(MDIKPGGBNLI: true);
		BMOGLOEONLA(num);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.CPAKBFAPJLA(locationTo, num);
	}

	private void OEAOIKNJNAD(int JIIGOACEIKL, Location BAIMHDBJPDK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.EAOOLEFMIKE() || (PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA != BAIMHDBJPDK && PlayerController.OPHDCMJLLEC(3).LEOIMFNKFGA != BAIMHDBJPDK))
		{
			Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				SceneManager.UnloadSceneAsync(BAIMHDBJPDK.ToString());
			}
		}
	}

	private void PKFMLJGJKCP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if ((Object)(object)TravelZonesManager.OLHBLKIAFOM() != (Object)null)
			{
				TravelZonesManager.LKOABOAADCD().LCIIFLADHOE(((Component)this).transform.position, null);
				OMNKJEOBDAP(null);
				TravelZonesManager.OLHBLKIAFOM().NGHLICBJBKA(this);
			}
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(LLDPMNJAPBA));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(LLDPMNJAPBA));
			}
		}
	}

	public void KCEPEPBLKCL()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("Can't find seat. Reason: enterChance" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = true;
		blocked = true;
	}

	private void JNJJABBOOFP(int GELMAIBEHDO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			if (GLCKJNDIAOO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(22, 422f);
			}
			else if (APAMLNNIKLL(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-19, 1265f);
			}
			else if (LHNEJHPLKLJ(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-32, 1488f);
			}
			else if (JKLFMKOJBOK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(82, 956f);
			}
			else if (BCPMJGFBNHJ(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(31, 1039f);
			}
			else if (DAFPDLKAHHO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(99, 411f);
			}
			else if (LCKAEAFGGKK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (HFDKOFPJCCO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood(Location.Tavern);
			}
			else if (NPGIJHILBNK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(10, 1043f);
			}
			else if (LOBLMOLNCKC(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (EHMJNJCMAIN(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(-104, 1667f);
			}
			else if (CGENCCKJDBI(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(70, 785f);
			}
			else if (IPKGKEEHGAH(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-57, 622f);
			}
			else if (IEJDDDCMFJO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.IKPHLAAJDLK(-108, 208f);
			}
			else if (DAEALBMCCPE(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.HNBHNFFEMHP();
			}
		}
	}

	private bool KBJLMHIBJIO(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.EAOOLEFMIKE())
		{
			if (NLNFBILJJEF == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.FarmShop))
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != ~(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop))
			{
				return false;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~Location.BarnInterior)
			{
				return true;
			}
		}
		return true;
	}

	public Vector3 GetCentrePosition()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (position + position2) / 2f;
	}

	private bool CGENBDCKHIK(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.HDBECFMPJHL())
		{
			if (NLNFBILJJEF == (Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~(Location.River | Location.Quarry | Location.BarnInterior))
			{
				return true;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~(Location.Road | Location.River | Location.Camp | Location.Quarry))
			{
				return false;
			}
		}
		return false;
	}

	private void EKJNGHBNGIH(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnTravelFinish(JIIGOACEIKL);
		CommonReferences.MNFMOEKMJKN().OnTravelWithZonesFinished(JIIGOACEIKL, this, NOJLAHMDNLB());
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = false;
		}
		PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(JIIGOACEIKL);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GIMCLDHIBLL));
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer.CJCOICDOPLL();
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ~(ZoneType.WithoutZone | ZoneType.CraftingRoom | ZoneType.RentedRoom))
		{
			CommonReferences.GGFJGHHHEJC.OnTravelToCellar(JIIGOACEIKL);
		}
		JNJJABBOOFP(JIIGOACEIKL);
		if (JIIGOACEIKL == 7)
		{
			GIAMEAIFOOG = false;
		}
		else
		{
			MILNEPJHBDE = false;
		}
	}

	private bool HLEHJPPBHGK(TravelZone AGBODONGNPH)
	{
		if ((Object)(object)AGBODONGNPH == (Object)null)
		{
			return true;
		}
		if ((AGBODONGNPH.location == (Location.Camp | Location.BarnInterior) && EventsManager.CGPHKBKPCJF((EventsManager.EventType)(-176))) || (AGBODONGNPH.location == ~(Location.River | Location.Quarry | Location.FarmShop) && EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-8))) || (AGBODONGNPH.location == Location.None && EventsManager.IOLMGKKGLMD((EventsManager.EventType)125)))
		{
			return true;
		}
		return false;
	}

	private void NDMOBBOLNKG()
	{
		NinjaChallengeEvent.IEIEPBHMMFN(this);
	}

	public void KFPPHKODCBB()
	{
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			if (value != Location.Anywhere && value != ~(Location.River | Location.Camp | Location.Quarry | Location.Farm) && value != Location.Tavern && value != Location.Road && value != 0)
			{
				GGAGEOJBGEN(1, value);
			}
		}
	}

	private void BFLIGKNGJEL(int JIIGOACEIKL)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		TravelZone travelZone = NOJLAHMDNLB();
		if (JIIGOACEIKL == 3)
		{
			PlayerController.CLEIAKPOGMM(JIIGOACEIKL, ((Object)(object)travelZone.playerPosition2 == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition2.position, travelZone.location);
		}
		else
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, (((Object)(object)travelZone.playerPosition == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition.position) + EBNJNICOFEP(OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL), HLEHJPPBHGK(travelZone)), travelZone.location);
		}
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.JCHLABOMNJF((((Object)(object)travelZone.playerPosition == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition.position) + FGKDCFONMOO(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL), PEAKAOOEKBC(travelZone)));
		}
		StuckRecoverySystem.instance.ResetAndSeedFromTravelZone(JIIGOACEIKL, travelZone);
	}

	private bool IEJDDDCMFJO(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			return PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF);
		}
		if (!PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF))
		{
			return true;
		}
		if (OFFIEFEDJBF(GELMAIBEHDO) == ~(Location.Road | Location.Farm | Location.BarnInterior) && MGFGFLADNOA(GELMAIBEHDO) == 0)
		{
			return true;
		}
		return false;
	}

	private bool OBMEFLCDOPN(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			return PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF);
		}
		if (!PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF))
		{
			return false;
		}
		if (IJMBMDBCPHI(GELMAIBEHDO) == (Location.Tavern | Location.Farm) && AAECIFOHLGK(GELMAIBEHDO) == 0)
		{
			return true;
		}
		return true;
	}

	public void HGECCGEOAKE()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("OWNER_ID" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = false;
		blocked = true;
	}

	private void CJAFDOJFGMI(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnTravelFinish(JIIGOACEIKL);
		CommonReferences.MNFMOEKMJKN().OnTravelWithZonesFinished(JIIGOACEIKL, this, GetTravelZoneTo());
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		}
		else
		{
			CommonReferences.MNFMOEKMJKN().travelZoneBeingUsed2 = true;
		}
		PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(ALFCEFIKBGA));
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer.CJCOICDOPLL();
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NNMHEPDJOHK == (ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop))
		{
			CommonReferences.MNFMOEKMJKN().OnTravelToCellar(JIIGOACEIKL);
		}
		MNJNMLIDADC(JIIGOACEIKL);
		if (JIIGOACEIKL == 3)
		{
			GIAMEAIFOOG = false;
		}
		else
		{
			MILNEPJHBDE = false;
		}
	}

	public void JMEPKMFCFAB(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = PAICGEGHOCO;
		AFGDPNGHBJM();
		OMNKJEOBDAP(this);
	}

	private void OMNKJEOBDAP(TravelZone PHGGMIMGFDK)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if (squaresParentAddingPositionToDictionary)
		{
			for (int i = 0; i < squaresParent.childCount; i++)
			{
				if ((Object)(object)PHGGMIMGFDK != (Object)null || (Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneAtPosition(squaresParent.GetChild(i).position + Vector3.one * 0.25f) == (Object)(object)this)
				{
					TravelZonesManager.GGFJGHHHEJC.SetTravelZoneAtPosition(squaresParent.GetChild(i).position + Vector3.one * 0.25f, PHGGMIMGFDK);
				}
			}
		}
		for (int j = 0; j < extraNodePoints.Length; j++)
		{
			if ((Object)(object)PHGGMIMGFDK != (Object)null || (Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneAtPosition(extraNodePoints[j].position) == (Object)(object)this)
			{
				TravelZonesManager.GGFJGHHHEJC.SetTravelZoneAtPosition(extraNodePoints[j].position, PHGGMIMGFDK);
			}
		}
	}

	private void KPMFBDEDNHF()
	{
		PAFBNIBEFEB(null);
	}

	private void BJNBAOFGPAA(int JIIGOACEIKL)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		TravelZone travelZone = NOJLAHMDNLB();
		if (JIIGOACEIKL == 5)
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, ((Object)(object)travelZone.playerPosition2 == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition2.position, travelZone.location);
		}
		else
		{
			PlayerController.TeleportPlayer(JIIGOACEIKL, (((Object)(object)travelZone.playerPosition == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition.position) + EBNJNICOFEP(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL), HLEHJPPBHGK(travelZone)), travelZone.location);
		}
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.JCHLABOMNJF((((Object)(object)travelZone.playerPosition == (Object)null) ? ((Component)travelZone).transform.position : travelZone.playerPosition.position) + EBNJNICOFEP(OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL), HLEHJPPBHGK(travelZone)));
		}
		StuckRecoverySystem.instance.HGCAKDKIKNP(JIIGOACEIKL, travelZone);
	}

	public TravelZone KLEIGOKONOM()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)forceTravelZoneTo != (Object)null)
		{
			return forceTravelZoneTo;
		}
		if (forceTravelToMineLevel != -1)
		{
			return TravelZonesManager.LKOABOAADCD().allMineStairs[new Vector2Int(forceTravelToMineLevel, forceTravelToMineLevel)];
		}
		return TravelZonesManager.GFMBEDCANNI().EHIIMIBJGPF(this);
	}

	[SpecialName]
	public Vector2Int BFNLNBGPHHE()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2Int(((Vector2Int)(ref mineStairs)).y, ((Vector2Int)(ref mineStairs)).x);
	}

	public Vector3 JDCIIGFOPJA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return (position + position2) / 1273f;
	}

	public TravelZone NOJLAHMDNLB()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)forceTravelZoneTo != (Object)null)
		{
			return forceTravelZoneTo;
		}
		if (forceTravelToMineLevel != -1)
		{
			return TravelZonesManager.GFMBEDCANNI().allMineStairs[new Vector2Int(forceTravelToMineLevel, forceTravelToMineLevel)];
		}
		return TravelZonesManager.GFMBEDCANNI().KMHDIAOLCEH(this);
	}

	[SpecialName]
	public static TravelZone DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	private bool NJGAAOFCNHC(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.PirateCave)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.PirateCave && NLNFBILJJEF != Location.PirateShip)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.PirateCave || IJMBMDBCPHI(GELMAIBEHDO) == Location.PirateShip)
			{
				return true;
			}
		}
		return false;
	}

	public void GLIHCGGNBHH()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("A very important guest is visiting!" + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = true;
		blocked = false;
	}

	private void GLCEPNHDGCK(int BBIPAKOIIGC)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DGGGMFPPIKI));
		((MonoBehaviour)this).StartCoroutine(DEGFMODIBNI());
	}

	private void PCMHFGMIBPJ(int JIIGOACEIKL)
	{
		PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(JIIGOACEIKL);
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = false;
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = false;
		}
		FadeCamera.IGMCBPOPNCA(JIIGOACEIKL).GPBOEBGJJPM(1995f);
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(Travelling));
		QuestTooltipUI.AJIGOHGPFPP().BOBCIFEDJED();
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		BMOGLOEONLA(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.CPAKBFAPJLA(locationTo, JIIGOACEIKL);
	}

	private bool LLELHFNDHEF(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			return PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF);
		}
		if (!PCAIOHIAOGK(GELMAIBEHDO, NFHFNKHHGGI, NLNFBILJJEF))
		{
			return false;
		}
		if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Mine && AAECIFOHLGK(GELMAIBEHDO) == 0)
		{
			return true;
		}
		return false;
	}

	private void CBBAHPLBKNH(int JIIGOACEIKL, Location BAIMHDBJPDK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.HDBECFMPJHL() || (PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA != BAIMHDBJPDK && PlayerController.GetPlayer(3).LEOIMFNKFGA != BAIMHDBJPDK))
		{
			Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				SceneManager.UnloadSceneAsync(BAIMHDBJPDK.ToString());
			}
		}
	}

	private bool IMFIHGALDGG(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (((Vector2Int)(ref mineStairs)).x == 0)
			{
				if (((Vector2Int)(ref mineStairs)).y > 1)
				{
					return false;
				}
				if (forceTravelToMineLevel > 1)
				{
					return false;
				}
			}
		}
		else
		{
			if (((Vector2Int)(ref mineStairs)).x == 0)
			{
				if (((Vector2Int)(ref mineStairs)).y > 0)
				{
					return true;
				}
				if (forceTravelToMineLevel > 1)
				{
					return true;
				}
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == (Location.Road | Location.BarnInterior | Location.FarmShop) && AAECIFOHLGK(GELMAIBEHDO) == 0)
			{
				return true;
			}
		}
		return true;
	}

	private IEnumerator DEGFMODIBNI()
	{
		Debug.LogError((object)"OnlineSceneLoad");
		while (!OnlineSceneManager.IsSceneLoadedOnMaster(locationTo))
		{
			if (!OnlineSceneManager.IsSceneLoadingOnMaster(locationTo))
			{
				OnlineSceneManager.RequestSceneLoad(locationTo);
			}
			Debug.LogError((object)$"Waiting for scene {locationTo} load on master. Current state: {OnlineSceneManager.GetSceneMasterLoadingState(locationTo)}");
			yield return CommonReferences.wait3;
		}
		while (!OnlineSceneManager.IsSceneLoadedLocally(locationTo))
		{
			if (!OnlineSceneManager.IsSceneLoadingLocally(locationTo))
			{
				OnlineSceneManager.LoadSceneLocally(locationTo);
			}
			Debug.LogError((object)$"Waiting for scene {locationTo} load on client. Current state: {OnlineSceneManager.GetSceneLocalLoadingState(locationTo)}");
			yield return CommonReferences.wait1;
		}
		Travelling(1);
	}

	private bool LHNEJHPLKLJ(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.Forest)
		{
			if (EventsManager.IsActive(EventsManager.EventType.KyrohWaterfall))
			{
				return true;
			}
			if (EventsManager.IsActive(EventsManager.EventType.FinalTest))
			{
				return true;
			}
		}
		return false;
	}

	private void GEADOKLLPOC(int GELMAIBEHDO)
	{
		if (GEOALDPMMEH(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.TriggerMusicTheme(16);
		}
		else if (APAMLNNIKLL(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 24);
		}
		else if (LHNEJHPLKLJ(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 33);
		}
		else if (JKLFMKOJBOK(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (DEKICAPLHBP(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (NJHBNCNCMMI(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (GBIPKKLHFDN(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (LCKAEAFGGKK(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (CKIIMOJLGAH(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 20);
		}
		else if (DAFPDLKAHHO(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 27);
		}
		else if (HFDKOFPJCCO(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (NPGIJHILBNK(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		}
		else if (NJGAAOFCNHC(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 31);
		}
		else if (CGENCCKJDBI(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 32);
		}
		else if (IPKGKEEHGAH(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 30);
		}
		else if (LLELHFNDHEF(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 41);
		}
		else if (NDOCOAOBIDP(GELMAIBEHDO, location, locationTo))
		{
			MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, 42);
		}
	}

	private void BGBFJPJLPMF()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		TravelZonesManager.GFMBEDCANNI().OHGMDCCPMLK(this);
		position = ((Component)this).transform.position;
		if ((Object)(object)barn != (Object)null)
		{
			Placeable placeable = barn.placeable;
			placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
			Placeable placeable2 = barn.placeable;
			placeable2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(placeable2.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		}
	}

	public void CloseDoor()
	{
		if (Object.op_Implicit((Object)(object)door) && door.ECMGCJGPKNO)
		{
			door.OpenCloseTheDoor();
		}
	}

	private IEnumerator BOCBAMENEJB()
	{
		Debug.LogError((object)"OnlineSceneLoad");
		while (!OnlineSceneManager.IsSceneLoadedOnMaster(locationTo))
		{
			if (!OnlineSceneManager.IsSceneLoadingOnMaster(locationTo))
			{
				OnlineSceneManager.RequestSceneLoad(locationTo);
			}
			Debug.LogError((object)$"Waiting for scene {locationTo} load on master. Current state: {OnlineSceneManager.GetSceneMasterLoadingState(locationTo)}");
			yield return CommonReferences.wait3;
		}
		while (!OnlineSceneManager.IsSceneLoadedLocally(locationTo))
		{
			if (!OnlineSceneManager.IsSceneLoadingLocally(locationTo))
			{
				OnlineSceneManager.LoadSceneLocally(locationTo);
			}
			Debug.LogError((object)$"Waiting for scene {locationTo} load on client. Current state: {OnlineSceneManager.GetSceneLocalLoadingState(locationTo)}");
			yield return CommonReferences.wait1;
		}
		Travelling(1);
	}

	private IEnumerator FAAPOOIEAJD(int JIIGOACEIKL, string IIBONBIIHDE)
	{
		yield return null;
		if (JIIGOACEIKL == 1)
		{
			PGJBPJNFFJK = SceneManager.LoadSceneAsync(IIBONBIIHDE, (LoadSceneMode)1);
			while (!PGJBPJNFFJK.isDone)
			{
				yield return null;
			}
		}
		if (JIIGOACEIKL == 2)
		{
			IGHHHLBLKCP = SceneManager.LoadSceneAsync(IIBONBIIHDE, (LoadSceneMode)1);
			while (!IGHHHLBLKCP.isDone)
			{
				yield return null;
			}
		}
		((MonoBehaviour)this).StartCoroutine(LFDIBPFMMAK(JIIGOACEIKL));
	}

	private Location IJMBMDBCPHI(int GELMAIBEHDO)
	{
		if (GELMAIBEHDO == 1)
		{
			return PlayerController.GetPlayer(2).LEOIMFNKFGA;
		}
		return PlayerController.GetPlayer(1).LEOIMFNKFGA;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)RoomUpgrader.GGFJGHHHEJC != (Object)null)
		{
			RoomUpgrader instance = RoomUpgrader.GGFJGHHHEJC;
			instance.OnRoomUpgradeStart = (Action)Delegate.Remove(instance.OnRoomUpgradeStart, new Action(LKBDJCPENDD));
			RoomUpgrader instance2 = RoomUpgrader.GGFJGHHHEJC;
			instance2.OnRoomUpgradeEnd = (Action)Delegate.Remove(instance2.OnRoomUpgradeEnd, new Action(LDCLPIDIFIF));
		}
	}

	[CompilerGenerated]
	private void DOKBNBHMKIE()
	{
		NinjaChallengeEvent.TeleportPlayerToSecondFloor(this);
	}

	private bool ODGMJEHBMLE(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.River | Location.Camp) && (NFHFNKHHGGI == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || NFHFNKHHGGI == (Location.River | Location.BarnInterior) || NFHFNKHHGGI == (Location.Tavern | Location.River | Location.BarnInterior | Location.FarmShop) || NFHFNKHHGGI == (Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.BarnInterior)))
		{
			return true;
		}
		return false;
	}

	private void EEFANKPFHEO(int JIIGOACEIKL)
	{
		PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CommonReferences.MNFMOEKMJKN().OnTravelStart(JIIGOACEIKL);
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		}
		else
		{
			CommonReferences.MNFMOEKMJKN().travelZoneBeingUsed2 = false;
		}
		FadeCamera.IGMCBPOPNCA(JIIGOACEIKL).IONMINJHMKL(1261f);
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(Travelling));
		QuestTooltipUI.GGFJGHHHEJC.CloseUI();
		ItemTooltip.Get(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		GEADOKLLPOC(JIIGOACEIKL);
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.DBGNLKIEBDK(locationTo, JIIGOACEIKL);
	}

	public TravelZone ANOLFMAPJJH()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)forceTravelZoneTo != (Object)null)
		{
			return forceTravelZoneTo;
		}
		if (forceTravelToMineLevel != -1)
		{
			return TravelZonesManager.CFHEJAGKIII().allMineStairs[new Vector2Int(forceTravelToMineLevel, forceTravelToMineLevel)];
		}
		return TravelZonesManager.LKOABOAADCD().GetTravelZoneTo(this);
	}

	private bool BCPMJGFBNHJ(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.NBFLEJHLGNB())
		{
			if (NLNFBILJJEF == (Location.River | Location.Quarry | Location.Farm | Location.BarnInterior) && NFHFNKHHGGI == (Location.Road | Location.River))
			{
				return true;
			}
			if (NLNFBILJJEF == (Location.Tavern | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) && NFHFNKHHGGI == ~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
			{
				return false;
			}
			if (NLNFBILJJEF == ~(Location.Road | Location.Quarry | Location.FarmShop) && NFHFNKHHGGI == (Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != (Location.Tavern | Location.BarnInterior))
			{
				return true;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == ~(Location.Tavern | Location.Road | Location.BarnInterior))
			{
				return true;
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == (Location.River | Location.Farm))
			{
				return false;
			}
			if (OFFIEFEDJBF(GELMAIBEHDO) == (Location.River | Location.Farm))
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop))
			{
				return true;
			}
		}
		return false;
	}

	public Vector3 GetMiddlePosition()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		return Utils.MJEACANINDN((position + position2) / 2f);
	}

	private void NNABCHDEICD(int JIIGOACEIKL)
	{
		PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(JIIGOACEIKL);
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.MNFMOEKMJKN().travelZoneBeingUsed = false;
		}
		else
		{
			CommonReferences.MNFMOEKMJKN().travelZoneBeingUsed2 = true;
		}
		FadeCamera.IGMCBPOPNCA(JIIGOACEIKL).FadeOut(1366f);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(JIIGOACEIKL);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(Travelling));
		QuestTooltipUI.GGFJGHHHEJC.BOBCIFEDJED();
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		GEADOKLLPOC(JIIGOACEIKL);
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.GHIICAIEHKH(locationTo, JIIGOACEIKL);
	}

	private bool NJHBNCNCMMI(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.QuarryCave)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.QuarryCave)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.QuarryCave)
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.InnkeepersCave)
			{
				return true;
			}
		}
		return false;
	}

	private bool MODMONOEIPO(TravelZone AGBODONGNPH)
	{
		if ((Object)(object)AGBODONGNPH == (Object)null)
		{
			return true;
		}
		if ((AGBODONGNPH.location == ~(Location.Camp | Location.Quarry | Location.BarnInterior) && EventsManager.KEGDEHKPKMP((EventsManager.EventType)(-20))) || (AGBODONGNPH.location == ~Location.Farm && EventsManager.FFELMGLBAMH(EventsManager.EventType.Fortitude)) || (AGBODONGNPH.location == (Location.Road | Location.River) && EventsManager.CJMECHEOFOF((EventsManager.EventType)(-55))))
		{
			return false;
		}
		return false;
	}

	private bool GBIPKKLHFDN(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.Quarry && (NFHFNKHHGGI == Location.QuarryCave || NFHFNKHHGGI == Location.ChristmasCave || NFHFNKHHGGI == Location.Mine || NFHFNKHHGGI == Location.Bathhouse))
		{
			return true;
		}
		return false;
	}

	private bool NHOALEKPLEG(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior))
		{
			if (EventsManager.IKCEIJMLNOP(EventsManager.EventType.KlaynTavern))
			{
				return true;
			}
			if (EventsManager.NKMELJPGOBB((EventsManager.EventType)33))
			{
				return false;
			}
		}
		return false;
	}

	private int AAECIFOHLGK(int GELMAIBEHDO)
	{
		if (GELMAIBEHDO == 1)
		{
			return PlayerController.GetPlayer(2).HCBDDKHPHCF;
		}
		return PlayerController.GetPlayer(1).HCBDDKHPHCF;
	}

	public TravelZone GetTravelZoneTo()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)forceTravelZoneTo != (Object)null)
		{
			return forceTravelZoneTo;
		}
		if (forceTravelToMineLevel != -1)
		{
			return TravelZonesManager.GGFJGHHHEJC.allMineStairs[new Vector2Int(forceTravelToMineLevel, forceTravelToMineLevel)];
		}
		return TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTo(this);
	}

	private bool DAEALBMCCPE(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (((Vector2Int)(ref mineStairs)).x == 0)
			{
				if (((Vector2Int)(ref mineStairs)).y > 0)
				{
					return true;
				}
				if (forceTravelToMineLevel > 1)
				{
					return true;
				}
			}
		}
		else
		{
			if (((Vector2Int)(ref mineStairs)).x == 0)
			{
				if (((Vector2Int)(ref mineStairs)).y > 0)
				{
					return true;
				}
				if (forceTravelToMineLevel > 0)
				{
					return true;
				}
			}
			if (DAIIGMBDNDF(GELMAIBEHDO) == ~(Location.Tavern | Location.Road | Location.River | Location.FarmShop) && LCMCPOJEOJA(GELMAIBEHDO) == 0)
			{
				return false;
			}
		}
		return true;
	}

	private bool NPGIJHILBNK(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.ChristmasCave)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.ChristmasCave)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.ChristmasCave)
			{
				return true;
			}
		}
		return false;
	}

	public void IENANFGMJDA()
	{
		if (Object.op_Implicit((Object)(object)door) && door.NIAJOGCHBKN())
		{
			door.PPIMCKBHPAG();
		}
	}

	private bool IPKGKEEHGAH(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == Location.Bathhouse)
			{
				return true;
			}
		}
		else
		{
			if (NLNFBILJJEF != Location.Bathhouse)
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Bathhouse)
			{
				return true;
			}
		}
		return false;
	}

	public void UnloadAllScenes()
	{
		foreach (Location value in Enum.GetValues(typeof(Location)))
		{
			if (value != Location.Anywhere && value != Location.BarnInterior && value != Location.Tavern && value != Location.Road && value != 0)
			{
				GGAGEOJBGEN(1, value);
			}
		}
	}

	private void KCCCFPGMILD(int JIIGOACEIKL, Location BAIMHDBJPDK)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
		if (!((Scene)(ref sceneByName)).isLoaded)
		{
			if (!CommonReferences.GGFJGHHHEJC.loadingLocation[BAIMHDBJPDK])
			{
				((MonoBehaviour)this).StartCoroutine(COGCMHOLAGN(JIIGOACEIKL, BAIMHDBJPDK.ToString()));
				CommonReferences.MNFMOEKMJKN().loadingLocation[BAIMHDBJPDK] = false;
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(JBLAGOHKMLL(JIIGOACEIKL));
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(JBLAGOHKMLL(JIIGOACEIKL));
		}
	}

	private bool NDOCOAOBIDP(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (((Vector2Int)(ref mineStairs)).x == 0)
			{
				if (((Vector2Int)(ref mineStairs)).y > 0)
				{
					return true;
				}
				if (forceTravelToMineLevel > 0)
				{
					return true;
				}
			}
		}
		else
		{
			if (((Vector2Int)(ref mineStairs)).x == 0)
			{
				if (((Vector2Int)(ref mineStairs)).y > 0)
				{
					return true;
				}
				if (forceTravelToMineLevel > 0)
				{
					return true;
				}
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == Location.Mine && AAECIFOHLGK(GELMAIBEHDO) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private bool JCKAMFJMGJM(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.Tavern | Location.Quarry) && (NFHFNKHHGGI == ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm) || NFHFNKHHGGI == (Location.Tavern | Location.Camp | Location.Quarry) || NFHFNKHHGGI == ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.FarmShop) || NFHFNKHHGGI == ~(Location.Tavern | Location.River | Location.Camp | Location.Farm)))
		{
			return false;
		}
		return true;
	}

	private void AFEDDCPKIOO(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(JIIGOACEIKL);
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = true;
		}
		FadeCamera.GetPlayer(JIIGOACEIKL).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(Travelling));
		QuestTooltipUI.GGFJGHHHEJC.CloseUI();
		ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		GEADOKLLPOC(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(locationTo, JIIGOACEIKL);
	}

	private bool HFDKOFPJCCO(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.Road && NFHFNKHHGGI == Location.City)
		{
			return true;
		}
		return false;
	}

	private void OnDestroy()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if ((Object)(object)TravelZonesManager.GGFJGHHHEJC != (Object)null)
			{
				TravelZonesManager.GGFJGHHHEJC.SetTravelZoneAtPosition(((Component)this).transform.position, null);
				OMNKJEOBDAP(null);
				TravelZonesManager.GGFJGHHHEJC.RemoveFromDictionary(this);
			}
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(LLDPMNJAPBA));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(LLDPMNJAPBA));
			}
		}
	}

	private void COKBJNMAMDI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		IADEMLIIDPC = this;
		TravelZonesManager.LKOABOAADCD().NCAIMGDEPDO(this);
		position = ((Component)this).transform.position;
		if ((Object)(object)barn != (Object)null)
		{
			Placeable placeable = barn.placeable;
			placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable.OnThisPlaceablePlaced, new Action<int>(BNEEAPCOLGN));
			Placeable placeable2 = barn.placeable;
			placeable2.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(placeable2.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
		}
	}

	private void HBPEDJNKENJ(int BBIPAKOIIGC)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(HBPEDJNKENJ));
		((MonoBehaviour)this).StartCoroutine(BOCBAMENEJB());
	}

	private void NGEHFPOIJFK(int JIIGOACEIKL)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		SetPosition(((Component)this).transform.position);
	}

	private void MNJNMLIDADC(int GELMAIBEHDO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			if (DEKICAPLHBP(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(18);
			}
			else if (APAMLNNIKLL(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(24);
			}
			else if (LHNEJHPLKLJ(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(33);
			}
			else if (JKLFMKOJBOK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(19);
			}
			else if (CKIIMOJLGAH(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(20);
			}
			else if (DAFPDLKAHHO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(27);
			}
			else if (LCKAEAFGGKK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (HFDKOFPJCCO(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (NPGIJHILBNK(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(23);
			}
			else if (GBIPKKLHFDN(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerCurrentBasicMood();
			}
			else if (NJGAAOFCNHC(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(31);
			}
			else if (CGENCCKJDBI(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(32);
			}
			else if (IPKGKEEHGAH(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(30);
			}
			else if (LLELHFNDHEF(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMusicTheme(41);
			}
			else if (NDOCOAOBIDP(GELMAIBEHDO, location, locationTo))
			{
				MusicController.instance.TriggerMineMusicTheme();
			}
		}
	}

	public void UnblockTravelZone()
	{
		if ((Object)(object)blockingCollider == (Object)null)
		{
			Debug.LogError((object)("Blocking collider not atttached to " + ((Object)((Component)this).gameObject).name), (Object)(object)((Component)this).gameObject);
			return;
		}
		((Behaviour)blockingCollider).enabled = false;
		blocked = false;
	}

	private bool PEAKAOOEKBC(TravelZone AGBODONGNPH)
	{
		if ((Object)(object)AGBODONGNPH == (Object)null)
		{
			return false;
		}
		if ((AGBODONGNPH.location == Location.KujakuHouse && EventsManager.IsActive(EventsManager.EventType.FishCutting)) || (AGBODONGNPH.location == Location.PirateShip && EventsManager.IsActive(EventsManager.EventType.Fortitude)) || (AGBODONGNPH.location == Location.Road && EventsManager.IsActive(EventsManager.EventType.OldMansDuel)))
		{
			return true;
		}
		return false;
	}

	public void SetPosition(Vector3 PAICGEGHOCO)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = PAICGEGHOCO;
		LDCLPIDIFIF();
		OMNKJEOBDAP(this);
	}

	private void LHJMJPDNNHH(int JIIGOACEIKL, Location BAIMHDBJPDK)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
		if (!((Scene)(ref sceneByName)).isLoaded)
		{
			if (!CommonReferences.GGFJGHHHEJC.loadingLocation[BAIMHDBJPDK])
			{
				((MonoBehaviour)this).StartCoroutine(FAAPOOIEAJD(JIIGOACEIKL, BAIMHDBJPDK.ToString()));
				CommonReferences.GGFJGHHHEJC.loadingLocation[BAIMHDBJPDK] = true;
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(IJCPPCLIMCM(JIIGOACEIKL));
			}
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(FEJJPMHCDJD(JIIGOACEIKL));
		}
	}

	[SpecialName]
	public static TravelZone LPFNKEOJJKE()
	{
		return IADEMLIIDPC;
	}

	private void LKBDJCPENDD()
	{
		OMNKJEOBDAP(null);
	}

	private bool HMIBDBICIBJ(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == Location.Road && NFHFNKHHGGI == (Location.Road | Location.Camp | Location.Quarry | Location.Farm))
		{
			return true;
		}
		if (NLNFBILJJEF == Location.None && NFHFNKHHGGI == ~(Location.Tavern | Location.Camp | Location.Quarry) && MusicController.instance.basicMoodMusicPaused)
		{
			return true;
		}
		return true;
	}

	private void ADFNMKLPNPN()
	{
		NinjaChallengeEvent.HAGEKALEEED(this);
	}

	public void FILGJJPEIFO(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).gameObject.CompareTag("in") && !((Component)LGGCFCHOOMB).gameObject.CompareTag("ReceiveButtonPressPuzzle"))
		{
			return;
		}
		if (blocked)
		{
			PlayerController.GetPlayer((!((Component)LGGCFCHOOMB).gameObject.CompareTag("FarmReady")) ? 1 : 0).PlayerBark("ChessPillarInteractable not assigned");
			return;
		}
		PlayerController component = ((Component)LGGCFCHOOMB).gameObject.GetComponent<PlayerController>();
		if (waitForAllPlayers)
		{
			if (locationTo == ~(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop) && EventsManager.GIJEHKNKMIM())
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, BanquetEvent.IEDCKEDKCNI);
				return;
			}
			if ((location == Location.Tavern || location == (Location.Road | Location.River)) && locationTo == Location.Tavern && !OldMansDuelEvent.instance.sceneFinished && EventsManager.NKMELJPGOBB((EventsManager.EventType)30))
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, OldMansDuelEvent.HJFBILFLBNO);
				return;
			}
			if (location == ~(Location.Road | Location.Farm | Location.FarmShop) && locationTo == ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry) && EventsManager.NJBACCBIHID((EventsManager.EventType)(-20)))
			{
				OnlineManager.PBEFPKMICAF(component.playerNum, delegate
				{
					NinjaChallengeEvent.TeleportPlayerToSecondFloor(this);
				});
				return;
			}
			if (location == (Location.River | Location.Camp | Location.Quarry | Location.BarnInterior) && locationTo == (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior) && EventsManager.JAGPJPGBHDK((EventsManager.EventType)29))
			{
				OnlineManager.WaitPlayersToBePreparedToContinue(component.playerNum, AttackEvent.TeleportToBathhouse);
				return;
			}
		}
		StartTravelZone(component.GetPlayerNum());
	}

	private bool PIMKFJJNENJ(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.Tavern | Location.Road) && NFHFNKHHGGI == (Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			return true;
		}
		if (NLNFBILJJEF == (Location.Tavern | Location.Road | Location.River) && NFHFNKHHGGI == (Location.Road | Location.River | Location.Quarry | Location.FarmShop) && MusicController.instance.basicMoodMusicPaused)
		{
			return true;
		}
		return false;
	}

	private bool EMEKPNIGAKP(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (GameManager.SinglePlayer())
		{
			if (NLNFBILJJEF == (Location.Tavern | Location.Road | Location.River | Location.BarnInterior) && NFHFNKHHGGI != (Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.FarmShop))
			{
				return false;
			}
		}
		else
		{
			if (NLNFBILJJEF != (Location.River | Location.Quarry | Location.Farm | Location.BarnInterior) || NFHFNKHHGGI == (Location.Road | Location.River | Location.Camp | Location.FarmShop))
			{
				return true;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == (Location.Tavern | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
			if (IJMBMDBCPHI(GELMAIBEHDO) == (Location.River | Location.Farm | Location.BarnInterior))
			{
				return false;
			}
		}
		return true;
	}

	private void MLAINPFFLEO()
	{
		Debug.LogError((object)"Items/item_description_603");
		if (MILNEPJHBDE)
		{
			Debug.LogError((object)" (");
			return;
		}
		MILNEPJHBDE = false;
		int num = 1;
		PlayerInputs.LPJCFCODNFA(num, (MonoBehaviour)(object)this);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(num);
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		FadeCamera.EIFPKCAFDIB(num).GPBOEBGJJPM(274f);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(num);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(HBPEDJNKENJ));
		QuestTooltipUI.NGIMIHFFNMH().CloseUI();
		ItemTooltip.NIGDBMAOAEN(num).HIIOCMNJGCI(MDIKPGGBNLI: true);
		BMOGLOEONLA(num);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.NNNBDLGMHEC(locationTo, num);
	}

	private void NOIMJBKAKEF()
	{
		Debug.LogError((object)"Online StartTravelZone");
		if (MILNEPJHBDE)
		{
			Debug.LogError((object)"Already Travelling");
			return;
		}
		MILNEPJHBDE = true;
		int num = 1;
		PlayerInputs.DisableKeyboardInputsAndMovement(num, (MonoBehaviour)(object)this);
		CommonReferences.GGFJGHHHEJC.OnTravelStart(num);
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		FadeCamera.GetPlayer(num).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(num);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(HBPEDJNKENJ));
		QuestTooltipUI.GGFJGHHHEJC.CloseUI();
		ItemTooltip.Get(num).SetVisible(MDIKPGGBNLI: false);
		GEADOKLLPOC(num);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(locationTo, num);
	}

	private bool LOBLMOLNCKC(int GELMAIBEHDO, Location NFHFNKHHGGI, Location NLNFBILJJEF)
	{
		if (NLNFBILJJEF == (Location.River | Location.Quarry | Location.Farm) && (NFHFNKHHGGI == Location.FarmShop || NFHFNKHHGGI == ~Location.Camp || NFHFNKHHGGI == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior) || NFHFNKHHGGI == ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop)))
		{
			return true;
		}
		return true;
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool EFNFMEIDGDN, bool GFNHAMCPEAK)
	{
		OMNKJEOBDAP(null);
	}

	private void AFGDPNGHBJM()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)positionOnPathRequest))
		{
			positionOnPathRequestThread = Vector2.op_Implicit(Utils.MJEACANINDN(positionOnPathRequest.position));
		}
		if (extraNodePoints != null && extraNodePoints.Length != 0)
		{
			position = Utils.MJEACANINDN(extraNodePoints[1].position);
		}
		else
		{
			position = square1.position + Vector3.one * 227f;
		}
		position2 = square2.position + Vector3.one * 1620f;
	}

	[SpecialName]
	public static TravelZone AFFGPMFKEFH()
	{
		return IADEMLIIDPC;
	}

	private void KMKIGJILAGB(int JIIGOACEIKL)
	{
		CommonReferences.MNFMOEKMJKN().OnTravelFinish(JIIGOACEIKL);
		CommonReferences.GGFJGHHHEJC.OnTravelWithZonesFinished(JIIGOACEIKL, this, GetTravelZoneTo());
		if (JIIGOACEIKL == 1)
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = false;
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = false;
		}
		PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(JIIGOACEIKL);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(EKJNGHBNGIH));
		if (OnlineManager.PlayingOnline())
		{
			PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer.SendFinishTeleport();
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NNMHEPDJOHK == ~(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop))
		{
			CommonReferences.GGFJGHHHEJC.OnTravelToCellar(JIIGOACEIKL);
		}
		KPHPNMOIBLF(JIIGOACEIKL);
		if (JIIGOACEIKL == 3)
		{
			GIAMEAIFOOG = true;
		}
		else
		{
			MILNEPJHBDE = false;
		}
	}
}
