using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Seat : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EGCHNALKILN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Seat _003C_003E4__this;

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
		public EGCHNALKILN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Seat seat = _003C_003E4__this;
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
				if ((Object)(object)seat.occupier == (Object)null)
				{
					return false;
				}
				if ((Object)(object)seat.occupier.customer.seatDrinkArms == (Object)null)
				{
					return false;
				}
				if (seat.placeable.GetDirection() == Direction.Down)
				{
					seat.table.placeable.placeableSurface.AddToSurface(seat.occupier.customer.seatDrinkArms, IIHIGNMDBEF: true, BGKCHMNJBLJ: false);
				}
				else
				{
					seat.table.placeable.placeableSurface.AddToSurface(seat.occupier.customer.seatDrinkArms, IIHIGNMDBEF: false, BGKCHMNJBLJ: false);
				}
				if (seat.placeable.GetDirection() == Direction.Left)
				{
					if (((Component)seat.table).transform.localScale.x == 1f)
					{
						seat.occupier.customer.seatDrinkArms.localScale = new Vector3(-1f, 1f, 1f);
					}
					else
					{
						seat.occupier.customer.seatDrinkArms.localScale = new Vector3(1f, 1f, 1f);
					}
				}
				else if (seat.placeable.GetDirection() == Direction.Right)
				{
					if (((Component)seat.table).transform.localScale.x == 1f)
					{
						seat.occupier.customer.seatDrinkArms.localScale = new Vector3(1f, 1f, 1f);
					}
					else
					{
						seat.occupier.customer.seatDrinkArms.localScale = new Vector3(-1f, 1f, 1f);
					}
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

	public Vector2[] entryNodes;

	public Vector2 entryPosition;

	public DirtyDish dirtyDish;

	public bool reserved;

	public bool notUsed;

	public bool mainSeat;

	public Table table;

	public Vector3 enteredLocation;

	public Placeable placeable;

	public Seat[] otherSeats;

	[SerializeField]
	private SurfaceSortOrder surface;

	[SerializeField]
	private SpriteRenderer arrow;

	[SerializeField]
	private ItemSpace itemSpace;

	public HumanNPC occupier;

	[SerializeField]
	private Transform npcSitDownPos;

	[SerializeField]
	private Transform npcSitDownPosDown;

	[SerializeField]
	private Transform npcSitDownPosUp;

	[SerializeField]
	private BuildSquare buildSquare;

	[SerializeField]
	private bool useSeatingGroup;

	[HideInInspector]
	public bool tucked;

	[HideInInspector]
	public bool seatingGroupUsed;

	private Neighbour[] FIFABPOJMAF;

	[SerializeField]
	private SpriteRenderer objectRender;

	private Vector3 AIBPGKBAJME;

	private bool JBKBLOHPMGD;

	private NPCHoldObject JKNPDCMAEJJ;

	private Vector3 EALLNEGMPFF;

	private SeatingGroup FFCKDOBGLHH;

	private Vector3 FCGBJEIIMBC;

	private void BELOIFKPNMM()
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if ((Object)(object)arrow != (Object)null)
			{
				((Component)arrow).gameObject.SetActive(false);
			}
			if (OnlineManager.PGAGDFAEEFB())
			{
				if (mainSeat)
				{
					TuckIntoTableNextFrame(0, CBOADNLDMBF: true);
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(GetNeighbourTableNextFrame());
				}
			}
		}
		KOMAIGMHKPG(placeable.GetDirection());
	}

	private void NBOFAPBEENF(Vector3 IMOBLFMHKOD, bool GAKNPAMHAFB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.LMMELLKNMCF(IMOBLFMHKOD, !GAKNPAMHAFB || LGCDHMEEAAG(IMOBLFMHKOD));
	}

	private void LAKALHMOCKF(Direction ALINGFNCMJI)
	{
		if ((Object)(object)objectRender != (Object)null)
		{
			if (ALINGFNCMJI == Direction.Up)
			{
				objectRender.maskInteraction = (SpriteMaskInteraction)0;
			}
			else
			{
				objectRender.maskInteraction = (SpriteMaskInteraction)2;
			}
		}
	}

	private void DBAEOANFLOO()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		BuildSquare[] buildSquares = itemSpace.buildSquares;
		for (int i = 0; i < buildSquares.Length; i++)
		{
			WorldGrid.FPHAMKKBNMC(WorldGrid.LOJBKLKMINM(buildSquares[i].GetCentrePosition()));
		}
	}

	private bool LGCDHMEEAAG(Vector3 DDCCHGHPIGM)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		for (int i = 0; i < WorldGrid.movementNodeDiagonals.Length; i++)
		{
			if (WorldGrid.LFNIJJPBPEL(DDCCHGHPIGM + WorldGrid.movementNodeDiagonals[i], out var OAFDNOGHMDD) && !OAFDNOGHMDD && !GJLLOEOBCAM(DDCCHGHPIGM))
			{
				result = false;
				break;
			}
		}
		return result;
	}

	private void Start()
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if ((Object)(object)arrow != (Object)null)
			{
				((Component)arrow).gameObject.SetActive(false);
			}
			if (OnlineManager.MasterOrOffline())
			{
				if (mainSeat)
				{
					TuckIntoTableNextFrame(1, CBOADNLDMBF: true);
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(GetNeighbourTableNextFrame());
				}
			}
		}
		KOMAIGMHKPG(placeable.GetDirection());
	}

	private IEnumerator ONOJBHDNGNM()
	{
		return new EGCHNALKILN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DLHMEOBCIIG(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			IMHKJLJGPAD();
		}
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			IMHKJLJGPAD();
		}
	}

	public void TuckOnLoad()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)arrow != (Object)null)
		{
			((Component)arrow).gameObject.SetActive(false);
		}
		GetNeighbourTable(AINPJHKNJGL: true);
		Vector3 centrePosition = itemSpace.buildSquares[0].GetCentrePosition();
		TuckIntoTable(1, CBOADNLDMBF: false);
		if (mainSeat && (Object)(object)table == (Object)null)
		{
			WorldGrid.CFAHJNLAJNK(centrePosition, JBNJGMKBKCB: false);
		}
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.blue;
		if (entryNodes != null)
		{
			for (int i = 0; i < entryNodes.Length; i++)
			{
				Gizmos.DrawSphere(Vector2.op_Implicit(Utils.MJEACANINDN(entryNodes[i])), 0.05f);
			}
		}
	}

	public void LBPDCMDJBJK()
	{
		if ((Object)(object)table != (Object)null && Object.op_Implicit((Object)(object)dirtyDish) && ((Component)dirtyDish).gameObject.activeSelf)
		{
			((Component)dirtyDish).gameObject.SetActive(false);
			placeable.placeableSurface.RemoveFromSurface(((Component)dirtyDish).transform, IGIDKEAAIHL: true, GFNHAMCPEAK: false);
		}
	}

	public void DirtDish(bool GLPHCCKKIFD, bool CDPAMNIPPEC)
	{
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JKNPDCMAEJJ == (Object)null)
		{
			return;
		}
		if (GLPHCCKKIFD && table.PDPKEPEBPIK > (float)table.DirtinessThreshold(TableDirtLevel.Messy))
		{
			for (int i = 0; i < table.dish.Length; i++)
			{
				if (((Component)table.dish[i]).gameObject.activeSelf && ((Component)table.dish[i]).transform.position == AIBPGKBAJME)
				{
					JBKBLOHPMGD = true;
				}
			}
			if ((Object)(object)table != (Object)null && occupier.customer.customerState != CustomerState.HeadingToBar && !JBKBLOHPMGD)
			{
				for (int j = 0; j < table.dish.Length; j++)
				{
					if (!((Component)table.dish[j]).gameObject.activeSelf)
					{
						dirtyDish = table.dish[j];
						((Component)dirtyDish).gameObject.SetActive(true);
						((Component)dirtyDish).transform.position = AIBPGKBAJME;
						((Component)dirtyDish).transform.position = Utils.BMBMPKNANAC(((Component)dirtyDish).transform.position);
						table.placeable.placeableSurface.AddToSurface(((Component)table.dish[j]).transform);
						dirtyDish.UpdateDishVisual(JKNPDCMAEJJ.ODDHGLHEHLA);
						if (((Component)dirtyDish).transform.position == new Vector3(0f, 0f, 0f))
						{
							CleanDirtyDish();
						}
						if (!TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(table))
						{
							TavernManager.GGFJGHHHEJC.tableNeedsClean.Add(table);
						}
						break;
					}
				}
			}
		}
		if ((Object)(object)JKNPDCMAEJJ.itemGO != (Object)null)
		{
			if ((Object)(object)table != (Object)null)
			{
				if ((Object)(object)table.placeable != (Object)null && (Object)(object)table.placeable.placeableSurface != (Object)null)
				{
					table.placeable.placeableSurface.RemoveFromSurface(JKNPDCMAEJJ.itemGO.transform);
				}
			}
			else
			{
				Debug.LogError((object)("Seat without table (sendOnline -> " + CDPAMNIPPEC + ")"));
			}
			JKNPDCMAEJJ.itemGO.transform.parent = JKNPDCMAEJJ.spritesParent;
			JKNPDCMAEJJ.itemGO.transform.localPosition = Vector3.zero;
			JKNPDCMAEJJ.itemGO.SetActive(false);
		}
		else if (Application.isEditor)
		{
			Debug.LogWarning((object)"npc hold object itemGO has not been assigned, probably an incorrect online instruction", (Object)(object)((Component)JKNPDCMAEJJ).gameObject);
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			(placeable.onlinePlaceable as OnlineSitable).SendDirtDish(this);
		}
	}

	public void GetNeighbourTable(bool AINPJHKNJGL = false)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		buildSquare.CheckNegativeScale();
		placeable.itemSpace.SetScale(((Component)placeable).transform.localScale.x);
		FCGBJEIIMBC = Utils.NGFODNCHPHB(placeable.GetDirection()) * 0.5f;
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + FCGBJEIIMBC), 0.225f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
		if (!AINPJHKNJGL)
		{
			if (Object.op_Implicit((Object)(object)table) && table.placeable.FHEMHCEAICB)
			{
				table = null;
			}
			if (Object.op_Implicit((Object)(object)table) && !CODJEMEJFGF())
			{
				table = null;
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		if (!placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			if ((Object)(object)arrow != (Object)null)
			{
				((Component)arrow).gameObject.SetActive(false);
			}
			if (OnlineManager.MasterOrOffline())
			{
				if (mainSeat)
				{
					TuckIntoTableNextFrame(0, CBOADNLDMBF: true);
				}
				else
				{
					((MonoBehaviour)this).StartCoroutine(GetNeighbourTableNextFrame());
				}
			}
		}
		KOMAIGMHKPG(placeable.GetDirection());
	}

	public void TuckIntoTableNextFrame(int JIIGOACEIKL, bool CBOADNLDMBF)
	{
		((MonoBehaviour)this).StartCoroutine(GAMDGHLFHLC(JIIGOACEIKL, CBOADNLDMBF));
	}

	private bool AGMJLKAJKFE(Vector3 DDCCHGHPIGM)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < WorldGrid.allGridPositionsSurroundingNode.Length; i++)
		{
			if (!WorldGrid.APKPGNDDJHC(DDCCHGHPIGM + WorldGrid.allGridPositionsSurroundingNode[i]) && !WorldGrid.IFHBJCLHCFG(DDCCHGHPIGM + WorldGrid.allGridPositionsSurroundingNode[i]))
			{
				return false;
			}
		}
		return false;
	}

	private void OnEnable()
	{
		if ((Object)(object)placeable != (Object)null)
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
			Placeable obj3 = placeable;
			obj3.OnThisPlaceableRotated = (Action<Direction>)Delegate.Combine(obj3.OnThisPlaceableRotated, new Action<Direction>(EBLPMHPPIEM));
			Placeable obj4 = placeable;
			obj4.WhileSelectedCallback = (Action)Delegate.Combine(obj4.WhileSelectedCallback, new Action(JAICGFIPFHI));
		}
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
	}

	public void GetNeighbourTableAround()
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		if (useSeatingGroup)
		{
			Direction direction = placeable.GetDirection();
			for (int i = 0; i < 4; i++)
			{
				table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(direction) * 0.5f), 0.225f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
				if (Object.op_Implicit((Object)(object)table) && table.GetSeatingGroup(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(direction) * 0.5f), this) != null)
				{
					if ((direction == Direction.Up || direction == Direction.Down) && (table.placeable.direction == Direction.Up || table.placeable.direction == Direction.Down))
					{
						placeable.SetDirection(direction, CDPAMNIPPEC: true);
						return;
					}
					if ((direction == Direction.Left || direction == Direction.Right) && (table.placeable.direction == Direction.Left || table.placeable.direction == Direction.Right))
					{
						placeable.SetDirection(direction, CDPAMNIPPEC: true);
						return;
					}
				}
				direction = Utils.JPKPFDEBGEO(direction);
			}
			table = null;
			return;
		}
		Direction direction2 = placeable.GetDirection();
		if (!placeable.IsObjectInValidLocation(BIOKGEFFNAA: false))
		{
			return;
		}
		if (direction2 == Direction.Left || direction2 == Direction.Right)
		{
			table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(Direction.Left) * 0.5f), 0.225f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
			if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Left || table.placeable.direction == Direction.Right))
			{
				placeable.SetDirection(Direction.Left, CDPAMNIPPEC: true);
				return;
			}
			table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(Direction.Right) * 0.5f), 0.225f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
			if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Left || table.placeable.direction == Direction.Right))
			{
				placeable.SetDirection(Direction.Right, CDPAMNIPPEC: true);
			}
			return;
		}
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(Direction.Down) * 0.5f), 0.225f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
		if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Down || table.placeable.direction == Direction.Up))
		{
			placeable.SetDirection(Direction.Down, CDPAMNIPPEC: true);
			return;
		}
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(Direction.Up) * 0.5f), 0.225f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
		if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Down || table.placeable.direction == Direction.Up))
		{
			placeable.SetDirection(Direction.Up, CDPAMNIPPEC: true);
		}
	}

	private void OnDestroy()
	{
		TavernSeatingManager.RemoveSeat(this);
	}

	public void UpdateSpritesHeldItem()
	{
		if (occupier.customer.npcHoldItem.ODDHGLHEHLA?.LHBPOPOIFLE() is Food food && (Object)(object)occupier.customer.npcHoldItem.itemGO != (Object)null && food.held)
		{
			(occupier.customer.npcHoldItem.ODDHGLHEHLA as FoodInstance).LONFMPNLKJD(occupier.characterCreator);
		}
	}

	private IEnumerator GHAEFFEPJPJ()
	{
		return new EGCHNALKILN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IMHKJLJGPAD()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		FIFABPOJMAF = new Neighbour[WorldGrid.allMovementNeighbours.Length + 1];
		WorldGrid.DLFFCGLGDLL(buildSquare.GetCentrePosition(), ref FIFABPOJMAF, GLNLCLJJJEG: true);
		entryNodes = (from n in FIFABPOJMAF
			where n.free
			select n.position).ToArray();
	}

	private void KOMAIGMHKPG(Direction ALINGFNCMJI)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)arrow != (Object)null)
		{
			switch (ALINGFNCMJI)
			{
			case Direction.Up:
				((Component)arrow).transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
				break;
			case Direction.Down:
				((Component)arrow).transform.localRotation = Quaternion.Euler(0f, 0f, 270f);
				break;
			default:
				((Component)arrow).transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
				break;
			}
		}
	}

	private bool GCHACHOEFEN()
	{
		if ((placeable.GetDirection() != (Direction)8 && placeable.GetDirection() != (Direction)8) || table.leftRightTuck == 674f)
		{
			if (placeable.GetDirection() == Direction.Up || placeable.GetDirection() == Direction.Up)
			{
				return table.upDownTuck != 758f;
			}
			return true;
		}
		return true;
	}

	public void GetUp()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)occupier == (Object)null)
		{
			return;
		}
		((Component)occupier).transform.position = enteredLocation;
		if ((Object)(object)JKNPDCMAEJJ.itemGO != (Object)null)
		{
			if (OnlineManager.MasterOrOffline())
			{
				bool gLPHCCKKIFD = true;
				if (Waiter.JHLLELHBIDA && Random.Range(0, 100) < Waiter.GetEmployeePerkValue(25))
				{
					gLPHCCKKIFD = false;
				}
				if (Bouncer.JHLLELHBIDA && Random.Range(0, 100) < Bouncer.GetEmployeePerkValue(25))
				{
					gLPHCCKKIFD = false;
				}
				JBKBLOHPMGD = false;
				DirtDish(gLPHCCKKIFD, CDPAMNIPPEC: false);
			}
			else
			{
				JBKBLOHPMGD = false;
				DirtDish(GLPHCCKKIFD: false, CDPAMNIPPEC: false);
			}
		}
		if ((Object)(object)table != (Object)null && placeable.GetDirection() != 0)
		{
			table.placeable.placeableSurface.RemoveFromSurface(occupier.customer.seatDrinkArms, IGIDKEAAIHL: false);
			occupier.customer.seatDrinkArms.localScale = Vector3.one;
		}
		if (placeable.GetDirection() == Direction.Down)
		{
			surface.RemoveFromSurface(((Component)occupier).transform);
		}
		if (Object.op_Implicit((Object)(object)occupier.FJHKGBNBNKL) && OnlineManager.MasterOrOffline())
		{
			occupier.FJHKGBNBNKL.Stand();
		}
		occupier.characterCreator.SetDefaultTools();
		occupier.FJHKGBNBNKL.characterAnimator.EnableTableMaskInteraction(NJHMBMGKCPL: false);
		if (OnlineManager.IsMasterClient())
		{
			occupier.customer.LJOHCJAOADD?.SendGetUp();
		}
		occupier = null;
		JKNPDCMAEJJ = null;
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (!OKNOJJEFEBE)
		{
			if ((Object)(object)arrow != (Object)null)
			{
				((Component)arrow).gameObject.SetActive(true);
			}
			if (mainSeat)
			{
				TuckOutOfTable(IADPLHDEEMN: true);
			}
			placeable.lastPlacedPosition = ((Component)placeable).transform.position;
			if ((Object)(object)table == (Object)null)
			{
				WorldGrid.CFAHJNLAJNK(itemSpace.buildSquares[0].GetCentrePosition(), JBNJGMKBKCB: true);
			}
			table = null;
		}
	}

	public bool AELMLJKBMGG(HumanNPC DHLHBCDKKIJ)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)occupier != (Object)null)
		{
			return false;
		}
		CleanDirtyDish();
		if (OnlineManager.PGAGDFAEEFB())
		{
			enteredLocation = ((Component)DHLHBCDKKIJ).transform.position;
			((Component)DHLHBCDKKIJ).transform.position = ((Component)this).transform.position;
			if ((Object)(object)npcSitDownPosDown != (Object)null && (placeable.GetDirection() == Direction.Up || placeable.GetDirection() == Direction.Up))
			{
				if (placeable.GetDirection() == Direction.Up)
				{
					((Component)DHLHBCDKKIJ).transform.position = npcSitDownPosDown.position;
				}
				if (placeable.GetDirection() == Direction.Up)
				{
					((Component)DHLHBCDKKIJ).transform.position = npcSitDownPosUp.position;
				}
			}
			else if ((Object)(object)npcSitDownPos != (Object)null)
			{
				((Component)DHLHBCDKKIJ).transform.position = npcSitDownPos.position;
			}
			else
			{
				((Component)DHLHBCDKKIJ).transform.position = ((Component)this).transform.position;
			}
		}
		occupier = DHLHBCDKKIJ;
		JKNPDCMAEJJ = DHLHBCDKKIJ.customer.npcHoldItem;
		if (DHLHBCDKKIJ.customer.npcHoldItem.KLDDGAONACP()?.PHGLMBIEOMK() is Food food && (Object)(object)DHLHBCDKKIJ.customer.npcHoldItem.itemGO != (Object)null)
		{
			if (food.held)
			{
				(DHLHBCDKKIJ.customer.npcHoldItem.LNFNHPHHIGD() as FoodInstance).MMDMDDJMHHL(occupier.characterCreator);
			}
			((MonoBehaviour)this).StartCoroutine(JGFIJHKDFKI());
		}
		if ((Object)(object)table != (Object)null && placeable.GetDirection() != 0)
		{
			((MonoBehaviour)this).StartCoroutine(FEOKCGOFONO());
		}
		if (placeable.GetDirection() == Direction.Up)
		{
			surface.BDEJHHKHJFK(((Component)occupier).transform, IIHIGNMDBEF: false, BGKCHMNJBLJ: true, KOGPKBOIFGN: false);
			occupier.customer.seatDrinkArms.localScale = Vector3.one;
		}
		if (Object.op_Implicit((Object)(object)occupier.NDPNCJAOGNL()))
		{
			if (OnlineManager.MasterOrOffline())
			{
				occupier.DKMPEPHLBGI().NCAJNNHBHJM(placeable.GetDirection());
				occupier.NOJMFFFDAJA().AJPCKBLHAKH(placeable.GetDirection());
			}
			if (placeable.GetDirection() != 0)
			{
				occupier.OHKDOEFGKFA().characterAnimator.EnableTableMaskInteraction(NJHMBMGKCPL: false);
			}
		}
		if (OnlineManager.IsMasterClient() && (Object)(object)DHLHBCDKKIJ != (Object)null)
		{
			DHLHBCDKKIJ.customer.LJOHCJAOADD.SendSitDown(this);
		}
		return true;
	}

	private IEnumerator JGFIJHKDFKI()
	{
		yield return null;
		yield return null;
		if (Object.op_Implicit((Object)(object)JKNPDCMAEJJ) && Object.op_Implicit((Object)(object)JKNPDCMAEJJ.itemGO) && (JKNPDCMAEJJ.ODDHGLHEHLA.LHBPOPOIFLE() as Food).foodType != FoodType.Drink)
		{
			JKNPDCMAEJJ.itemGO.SetActive(true);
			JKNPDCMAEJJ.itemGO.transform.localPosition = BJELBOJIBFM();
			JKNPDCMAEJJ.itemGO.transform.position = Utils.BMBMPKNANAC(JKNPDCMAEJJ.itemGO.transform.position);
			table.placeable.placeableSurface.AddToSurface(JKNPDCMAEJJ.itemGO.transform, IIHIGNMDBEF: false, BGKCHMNJBLJ: false);
			AIBPGKBAJME = JKNPDCMAEJJ.itemGO.transform.position;
		}
	}

	public void AddTable(int JIIGOACEIKL, Table IBMBGPOLAIK, bool CBOADNLDMBF)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		table = IBMBGPOLAIK;
		for (int i = 0; i < otherSeats.Length; i++)
		{
			otherSeats[i].table = IBMBGPOLAIK;
		}
		for (int j = 0; j < placeable.itemSpace.buildSquares.Length; j++)
		{
			if (placeable.direction == Direction.Left)
			{
				placeable.itemSpace.buildSquares[j].offset = new Vector3(-0.25f, 0.25f);
			}
			else if (placeable.direction == Direction.Right)
			{
				placeable.itemSpace.buildSquares[j].offset = new Vector3(0.25f, 0.25f);
			}
		}
		if (IBMBGPOLAIK.placeable.canBeAddedToInventory)
		{
			TuckIntoTable(JIIGOACEIKL, CBOADNLDMBF);
		}
		TuckIntoTableNextFrame(JIIGOACEIKL, CBOADNLDMBF);
	}

	public IEnumerator GetNeighbourTableNextFrame()
	{
		yield return null;
		GetNeighbourTable();
	}

	public bool SitDown(HumanNPC DHLHBCDKKIJ)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)occupier != (Object)null)
		{
			return false;
		}
		CleanDirtyDish();
		if (OnlineManager.MasterOrOffline())
		{
			enteredLocation = ((Component)DHLHBCDKKIJ).transform.position;
			((Component)DHLHBCDKKIJ).transform.position = ((Component)this).transform.position;
			if ((Object)(object)npcSitDownPosDown != (Object)null && (placeable.GetDirection() == Direction.Down || placeable.GetDirection() == Direction.Up))
			{
				if (placeable.GetDirection() == Direction.Down)
				{
					((Component)DHLHBCDKKIJ).transform.position = npcSitDownPosDown.position;
				}
				if (placeable.GetDirection() == Direction.Up)
				{
					((Component)DHLHBCDKKIJ).transform.position = npcSitDownPosUp.position;
				}
			}
			else if ((Object)(object)npcSitDownPos != (Object)null)
			{
				((Component)DHLHBCDKKIJ).transform.position = npcSitDownPos.position;
			}
			else
			{
				((Component)DHLHBCDKKIJ).transform.position = ((Component)this).transform.position;
			}
		}
		occupier = DHLHBCDKKIJ;
		JKNPDCMAEJJ = DHLHBCDKKIJ.customer.npcHoldItem;
		if (DHLHBCDKKIJ.customer.npcHoldItem.ODDHGLHEHLA?.LHBPOPOIFLE() is Food food && (Object)(object)DHLHBCDKKIJ.customer.npcHoldItem.itemGO != (Object)null)
		{
			if (food.held)
			{
				(DHLHBCDKKIJ.customer.npcHoldItem.ODDHGLHEHLA as FoodInstance).LONFMPNLKJD(occupier.characterCreator);
			}
			((MonoBehaviour)this).StartCoroutine(JGFIJHKDFKI());
		}
		if ((Object)(object)table != (Object)null && placeable.GetDirection() != 0)
		{
			((MonoBehaviour)this).StartCoroutine(FEOKCGOFONO());
		}
		if (placeable.GetDirection() == Direction.Down)
		{
			surface.AddToSurface(((Component)occupier).transform, IIHIGNMDBEF: false, BGKCHMNJBLJ: false);
			occupier.customer.seatDrinkArms.localScale = Vector3.one;
		}
		if (Object.op_Implicit((Object)(object)occupier.FJHKGBNBNKL))
		{
			if (OnlineManager.MasterOrOffline())
			{
				occupier.FJHKGBNBNKL.FCGBJEIIMBC = placeable.GetDirection();
				occupier.FJHKGBNBNKL.Sit(placeable.GetDirection());
			}
			if (placeable.GetDirection() != 0)
			{
				occupier.FJHKGBNBNKL.characterAnimator.EnableTableMaskInteraction(NJHMBMGKCPL: true);
			}
		}
		if (OnlineManager.IsMasterClient() && (Object)(object)DHLHBCDKKIJ != (Object)null)
		{
			DHLHBCDKKIJ.customer.LJOHCJAOADD.SendSitDown(this);
		}
		return true;
	}

	public void LMAAAEANPCF()
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		if (useSeatingGroup)
		{
			Direction direction = placeable.GetDirection();
			for (int i = 1; i < 6; i++)
			{
				table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.BOBEIFEGLOL() + Utils.NGFODNCHPHB(direction) * 1577f), 130f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
				if (Object.op_Implicit((Object)(object)table) && table.GetSeatingGroup(Vector2.op_Implicit(buildSquare.EHGDHOMFDGM() + Utils.NGFODNCHPHB(direction) * 758f), this) != null)
				{
					if ((direction == Direction.Up || direction == Direction.Up) && (table.placeable.direction == Direction.Up || table.placeable.direction == Direction.Up))
					{
						placeable.KHPEKPOOHHM(direction, CDPAMNIPPEC: true);
						return;
					}
					if ((direction == (Direction)6 || direction == Direction.Right) && (table.placeable.direction == Direction.Up || table.placeable.direction == (Direction)8))
					{
						placeable.SetDirection(direction, CDPAMNIPPEC: true);
						return;
					}
				}
				direction = Utils.JPKPFDEBGEO(direction);
			}
			table = null;
			return;
		}
		Direction direction2 = placeable.GetDirection();
		if (!placeable.FMDLPNMAIHF(BIOKGEFFNAA: true))
		{
			return;
		}
		if (direction2 == Direction.Left || direction2 == Direction.Left)
		{
			table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.EHGDHOMFDGM() + Utils.NGFODNCHPHB((Direction)6) * 8f), 1806f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
			if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == (Direction)5 || table.placeable.direction == Direction.Left))
			{
				placeable.KHPEKPOOHHM(Direction.Left, CDPAMNIPPEC: false);
				return;
			}
			table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.BOBEIFEGLOL() + Utils.NGFODNCHPHB(Direction.Right) * 1347f), 1529f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
			if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Diagonal || table.placeable.direction == Direction.Right))
			{
				placeable.SetDirection(Direction.Down, CDPAMNIPPEC: true);
			}
			return;
		}
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.BLKHDGGHFLA() + Utils.NGFODNCHPHB(Direction.Up) * 1138f), 1345f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
		if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Up || table.placeable.direction == Direction.Up))
		{
			placeable.SetDirection(Direction.Up, CDPAMNIPPEC: true);
			return;
		}
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + Utils.NGFODNCHPHB(Direction.Up) * 1852f), 987f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
		if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Up || table.placeable.direction == Direction.Up))
		{
			placeable.KHPEKPOOHHM(Direction.Up, CDPAMNIPPEC: false);
		}
	}

	private bool GJLLOEOBCAM(Vector3 DDCCHGHPIGM)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < WorldGrid.allGridPositionsSurroundingNode.Length; i++)
		{
			if (!WorldGrid.APKPGNDDJHC(DDCCHGHPIGM + WorldGrid.allGridPositionsSurroundingNode[i]) && !WorldGrid.IFHBJCLHCFG(DDCCHGHPIGM + WorldGrid.allGridPositionsSurroundingNode[i]))
			{
				return false;
			}
		}
		return true;
	}

	private float LHMDMDFOLIM()
	{
		if (placeable.GetDirection() == Direction.Left || placeable.GetDirection() == Direction.Right)
		{
			return table.leftRightTuck;
		}
		return table.upDownTuck;
	}

	public void POAMNOBFFIP(bool IADPLHDEEMN)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)table != (Object)null && mainSeat && DEILNLGKIHG())
		{
			table.seat.Remove(this);
			if (otherSeats != null)
			{
				for (int i = 1; i < otherSeats.Length; i++)
				{
					table.seat.Remove(otherSeats[i]);
				}
			}
			if (useSeatingGroup)
			{
				if (FFCKDOBGLHH != null)
				{
					table.PlaceSeatingGroup(FFCKDOBGLHH, this, NMLKLAGDNPF: true);
				}
			}
			else
			{
				BuildSquare[] buildSquares = itemSpace.buildSquares;
				for (int j = 0; j < buildSquares.Length; j++)
				{
					WorldGrid.BBHDDBDMKHD(buildSquares[j].KDFECDEEDHL(), PMONOIGDAAC: false);
				}
			}
			Transform transform = ((Component)placeable).transform;
			transform.position -= EALLNEGMPFF;
			Transform transform2 = ((Component)itemSpace).transform;
			transform2.position += EALLNEGMPFF;
			EALLNEGMPFF = Vector3.zero;
			if (useSeatingGroup && !IADPLHDEEMN)
			{
				WorldGrid.CFAHJNLAJNK(itemSpace.buildSquares[1].BOBEIFEGLOL(), JBNJGMKBKCB: true);
				WorldGrid.PCGNGKPHKLC(itemSpace.buildSquares[0].EHGDHOMFDGM(), placeable);
			}
			if (!IADPLHDEEMN)
			{
				DBAEOANFLOO();
			}
			if (OnlineManager.JPPBEIJDCLJ())
			{
				placeable.onlinePlaceable.OHDMKFNOFHF(((Component)placeable).transform.position, ((Component)itemSpace).transform.position);
			}
		}
		tucked = true;
		seatingGroupUsed = false;
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)placeable != (Object)null)
			{
				Placeable obj = placeable;
				obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
				Placeable obj2 = placeable;
				obj2.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(obj2.OnThisPlaceablePlaced, new Action<int>(NGEHFPOIJFK));
				Placeable obj3 = placeable;
				obj3.OnThisPlaceableRotated = (Action<Direction>)Delegate.Remove(obj3.OnThisPlaceableRotated, new Action<Direction>(EBLPMHPPIEM));
				Placeable obj4 = placeable;
				obj4.WhileSelectedCallback = (Action)Delegate.Remove(obj4.WhileSelectedCallback, new Action(JAICGFIPFHI));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			}
		}
	}

	private IEnumerator GAMDGHLFHLC(int JIIGOACEIKL, bool CBOADNLDMBF)
	{
		yield return null;
		GetNeighbourTable();
		Vector3 centrePosition = itemSpace.buildSquares[0].GetCentrePosition();
		TuckIntoTable(JIIGOACEIKL, CBOADNLDMBF);
		if (mainSeat && (Object)(object)table == (Object)null)
		{
			WorldGrid.CFAHJNLAJNK(centrePosition, JBNJGMKBKCB: false);
		}
	}

	private Vector3 CICLEENLLGL()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.GetDirection() == (Direction)6)
		{
			return new Vector3(1428f, 890f, 1464f);
		}
		if (placeable.GetDirection() == (Direction)8)
		{
			return new Vector3(1031f, 475f, 1323f);
		}
		if (placeable.GetDirection() == Direction.Up)
		{
			return new Vector3(962f, 412f, 1916f);
		}
		return new Vector3(1795f, 222f, 268f);
	}

	private void Awake()
	{
		TavernSeatingManager.AddSeat(this);
	}

	private void DCJPIKOGMHK(int JIIGOACEIKL)
	{
		bool flag = (Object)(object)table != (Object)null;
		for (int i = 0; i < otherSeats.Length; i++)
		{
			if (!flag && (Object)(object)otherSeats[i].table != (Object)null)
			{
				flag = true;
			}
			otherSeats[i].table = null;
		}
		if (flag)
		{
			MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Invalid seating"));
		}
	}

	public void KNIFLCFEDEA()
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		if (useSeatingGroup)
		{
			Direction direction = placeable.GetDirection();
			for (int i = 0; i < 5; i++)
			{
				table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.KDFECDEEDHL() + Utils.NGFODNCHPHB(direction) * 872f), 1084f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
				if (Object.op_Implicit((Object)(object)table) && table.GetSeatingGroup(Vector2.op_Implicit(buildSquare.EHGDHOMFDGM() + Utils.NGFODNCHPHB(direction) * 1507f), this) != null)
				{
					if ((direction == Direction.Up || direction == Direction.Down) && (table.placeable.direction == Direction.Up || table.placeable.direction == Direction.Down))
					{
						placeable.KHPEKPOOHHM(direction, CDPAMNIPPEC: true);
						return;
					}
					if ((direction == (Direction)8 || direction == (Direction)7) && (table.placeable.direction == (Direction)6 || table.placeable.direction == Direction.Down))
					{
						placeable.KHPEKPOOHHM(direction, CDPAMNIPPEC: false);
						return;
					}
				}
				direction = Utils.JPKPFDEBGEO(direction);
			}
			table = null;
			return;
		}
		Direction direction2 = placeable.GetDirection();
		if (!placeable.FMDLPNMAIHF(BIOKGEFFNAA: false))
		{
			return;
		}
		if (direction2 == Direction.Down || direction2 == Direction.Left)
		{
			table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.EHGDHOMFDGM() + Utils.NGFODNCHPHB((Direction)6) * 675f), 1188f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
			if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == (Direction)6 || table.placeable.direction == Direction.Left))
			{
				placeable.SetDirection(Direction.Right, CDPAMNIPPEC: true);
				return;
			}
			table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.KGGGPHEMLII() + Utils.NGFODNCHPHB((Direction)6) * 1036f), 898f, LayerMask.op_Implicit(CommonReferences.GGFJGHHHEJC.objectLayers));
			if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == (Direction)6 || table.placeable.direction == Direction.Left))
			{
				placeable.KHPEKPOOHHM(Direction.Up, CDPAMNIPPEC: true);
			}
			return;
		}
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.FANOLHHEFBO() + Utils.NGFODNCHPHB(Direction.Up) * 1334f), 1816f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
		if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Down || table.placeable.direction == Direction.Up))
		{
			placeable.SetDirection(Direction.Up, CDPAMNIPPEC: true);
			return;
		}
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.BOBEIFEGLOL() + Utils.NGFODNCHPHB(Direction.Up) * 727f), 1152f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
		if (Object.op_Implicit((Object)(object)table) && (table.placeable.direction == Direction.Up || table.placeable.direction == Direction.Up))
		{
			placeable.KHPEKPOOHHM(Direction.Down, CDPAMNIPPEC: false);
		}
	}

	public void TuckOutOfTable(bool IADPLHDEEMN)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)table != (Object)null && mainSeat && CODJEMEJFGF())
		{
			table.seat.Remove(this);
			if (otherSeats != null)
			{
				for (int i = 0; i < otherSeats.Length; i++)
				{
					table.seat.Remove(otherSeats[i]);
				}
			}
			if (useSeatingGroup)
			{
				if (FFCKDOBGLHH != null)
				{
					table.PlaceSeatingGroup(FFCKDOBGLHH, this, NMLKLAGDNPF: false);
				}
			}
			else
			{
				BuildSquare[] buildSquares = itemSpace.buildSquares;
				for (int j = 0; j < buildSquares.Length; j++)
				{
					WorldGrid.BBHDDBDMKHD(buildSquares[j].GetCentrePosition(), PMONOIGDAAC: false);
				}
			}
			Transform transform = ((Component)placeable).transform;
			transform.position -= EALLNEGMPFF;
			Transform transform2 = ((Component)itemSpace).transform;
			transform2.position += EALLNEGMPFF;
			EALLNEGMPFF = Vector3.zero;
			if (useSeatingGroup && !IADPLHDEEMN)
			{
				WorldGrid.CFAHJNLAJNK(itemSpace.buildSquares[0].GetCentrePosition(), JBNJGMKBKCB: false);
				WorldGrid.PCGNGKPHKLC(itemSpace.buildSquares[0].GetCentrePosition(), placeable);
			}
			if (!IADPLHDEEMN)
			{
				DBAEOANFLOO();
			}
			if (OnlineManager.IsMasterClient())
			{
				placeable.onlinePlaceable.SendNewBenchPosition(((Component)placeable).transform.position, ((Component)itemSpace).transform.position);
			}
		}
		tucked = false;
		seatingGroupUsed = false;
	}

	private Vector3 BJELBOJIBFM()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (placeable.GetDirection() == Direction.Right)
		{
			return new Vector3(0.125f, 0.55f, 0f);
		}
		if (placeable.GetDirection() == Direction.Left)
		{
			return new Vector3(0.125f, 0.55f, 0f);
		}
		if (placeable.GetDirection() == Direction.Down)
		{
			return new Vector3(0f, 0.35f, 0f);
		}
		return new Vector3(0f, 0.825f, 0f);
	}

	private void DBDDLCEJMPM(Vector3 IMOBLFMHKOD, bool GAKNPAMHAFB)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.LMMELLKNMCF(IMOBLFMHKOD, GAKNPAMHAFB && LGCDHMEEAAG(IMOBLFMHKOD));
	}

	public void BPCAMJPJOAI(bool AINPJHKNJGL = false)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		buildSquare.GLGDKGPKACO();
		placeable.itemSpace.SetScale(((Component)placeable).transform.localScale.x);
		FCGBJEIIMBC = Utils.NGFODNCHPHB(placeable.GetDirection()) * 370f;
		table = Utils.EIDILBHBHBK<Table>(Vector2.op_Implicit(buildSquare.GetCentrePosition() + FCGBJEIIMBC), 952f, LayerMask.op_Implicit(CommonReferences.MNFMOEKMJKN().objectLayers));
		if (!AINPJHKNJGL)
		{
			if (Object.op_Implicit((Object)(object)table) && table.placeable.FHEMHCEAICB)
			{
				table = null;
			}
			if (Object.op_Implicit((Object)(object)table) && !GCHACHOEFEN())
			{
				table = null;
			}
		}
	}

	private bool DEILNLGKIHG()
	{
		if ((placeable.GetDirection() != Direction.Diagonal && placeable.GetDirection() != (Direction)5) || table.leftRightTuck == 966f)
		{
			if (placeable.GetDirection() == Direction.Up || placeable.GetDirection() == Direction.Up)
			{
				return table.upDownTuck != 1465f;
			}
			return true;
		}
		return true;
	}

	public void TuckIntoTable(int JIIGOACEIKL, bool CBOADNLDMBF)
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		if (!mainSeat || (OnlineManager.ClientOnline() && OnlineLoadManager.SceneLoaded))
		{
			return;
		}
		if ((Object)(object)table == (Object)null)
		{
			DCJPIKOGMHK(JIIGOACEIKL);
		}
		else
		{
			if (tucked)
			{
				return;
			}
			if ((Object)(object)table != (Object)null)
			{
				table.seat.Add(this);
				if (otherSeats != null)
				{
					for (int i = 0; i < otherSeats.Length; i++)
					{
						if (!otherSeats[i].notUsed)
						{
							table.seat.Add(otherSeats[i]);
						}
					}
				}
			}
			if (CODJEMEJFGF())
			{
				for (int j = 0; j < otherSeats.Length; j++)
				{
					otherSeats[j].GetNeighbourTable();
					if ((Object)(object)otherSeats[j].table != (Object)(object)table)
					{
						DCJPIKOGMHK(JIIGOACEIKL);
						table = null;
						return;
					}
				}
				EALLNEGMPFF = Vector3.zero;
				if (useSeatingGroup)
				{
					FFCKDOBGLHH = table.GetSeatingGroup(Vector2.op_Implicit(itemSpace.buildSquares[0].GetTilePosition() + Utils.NGFODNCHPHB(placeable.GetDirection()) * 0.5f), this);
					if (FFCKDOBGLHH != null)
					{
						if (FFCKDOBGLHH.occupied)
						{
							placeable.ForcePickUp(JIIGOACEIKL);
							DBAEOANFLOO();
							return;
						}
						tucked = true;
						seatingGroupUsed = true;
						table.PlaceSeatingGroup(FFCKDOBGLHH, this, NMLKLAGDNPF: true);
						EALLNEGMPFF = Utils.BMBMPKNANAC(FFCKDOBGLHH.transform.position - ((Component)placeable).transform.position);
					}
					else
					{
						table = null;
					}
				}
				else
				{
					tucked = true;
					BuildSquare[] buildSquares = itemSpace.buildSquares;
					for (int k = 0; k < buildSquares.Length; k++)
					{
						WorldGrid.BBHDDBDMKHD(buildSquares[k].GetCentrePosition(), PMONOIGDAAC: true);
					}
					EALLNEGMPFF = Utils.BMBMPKNANAC(Utils.NGFODNCHPHB(placeable.GetDirection()) * LHMDMDFOLIM());
				}
				if (CBOADNLDMBF)
				{
					Transform transform = ((Component)placeable).transform;
					transform.position += EALLNEGMPFF;
					Transform transform2 = ((Component)itemSpace).transform;
					transform2.position -= EALLNEGMPFF;
				}
				DBAEOANFLOO();
				if (OnlineManager.IsMasterClient())
				{
					placeable.onlinePlaceable.SendNewBenchPosition(((Component)placeable).transform.position, ((Component)itemSpace).transform.position);
				}
			}
			else
			{
				table = null;
			}
		}
	}

	private void EBLPMHPPIEM(Direction FCGBJEIIMBC)
	{
		KOMAIGMHKPG(placeable.GetDirection());
		LAKALHMOCKF(placeable.GetDirection());
	}

	private void JAICGFIPFHI()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		GetNeighbourTableAround();
		GetNeighbourTable();
		if ((Object)(object)arrow != (Object)null)
		{
			if ((Object)(object)table == (Object)null || !placeable.PCGNHMPADGE)
			{
				arrow.color = Color.red;
			}
			else if (useSeatingGroup)
			{
				arrow.color = ((table.GetSeatingGroup(Vector2.op_Implicit(itemSpace.buildSquares[0].GetTilePosition() + Utils.NGFODNCHPHB(placeable.GetDirection()) * 0.5f), this) != null) ? Color.green : Color.red);
			}
			else
			{
				arrow.color = Color.green;
			}
		}
	}

	public void CleanDirtyDish()
	{
		if ((Object)(object)table != (Object)null && Object.op_Implicit((Object)(object)dirtyDish) && ((Component)dirtyDish).gameObject.activeSelf)
		{
			((Component)dirtyDish).gameObject.SetActive(false);
			placeable.placeableSurface.RemoveFromSurface(((Component)dirtyDish).transform);
		}
	}

	private IEnumerator FEOKCGOFONO()
	{
		yield return null;
		if ((Object)(object)occupier == (Object)null || (Object)(object)occupier.customer.seatDrinkArms == (Object)null)
		{
			yield break;
		}
		if (placeable.GetDirection() == Direction.Down)
		{
			table.placeable.placeableSurface.AddToSurface(occupier.customer.seatDrinkArms, IIHIGNMDBEF: true, BGKCHMNJBLJ: false);
		}
		else
		{
			table.placeable.placeableSurface.AddToSurface(occupier.customer.seatDrinkArms, IIHIGNMDBEF: false, BGKCHMNJBLJ: false);
		}
		if (placeable.GetDirection() == Direction.Left)
		{
			if (((Component)table).transform.localScale.x == 1f)
			{
				occupier.customer.seatDrinkArms.localScale = new Vector3(-1f, 1f, 1f);
			}
			else
			{
				occupier.customer.seatDrinkArms.localScale = new Vector3(1f, 1f, 1f);
			}
		}
		else if (placeable.GetDirection() == Direction.Right)
		{
			if (((Component)table).transform.localScale.x == 1f)
			{
				occupier.customer.seatDrinkArms.localScale = new Vector3(1f, 1f, 1f);
			}
			else
			{
				occupier.customer.seatDrinkArms.localScale = new Vector3(-1f, 1f, 1f);
			}
		}
	}

	private bool CODJEMEJFGF()
	{
		if ((placeable.GetDirection() != Direction.Left && placeable.GetDirection() != Direction.Right) || table.leftRightTuck == 0f)
		{
			if (placeable.GetDirection() == Direction.Up || placeable.GetDirection() == Direction.Down)
			{
				return table.upDownTuck != 0f;
			}
			return false;
		}
		return true;
	}

	private void NGEHFPOIJFK(int JIIGOACEIKL)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)arrow != (Object)null)
		{
			((Component)arrow).gameObject.SetActive(false);
		}
		if (mainSeat)
		{
			GetNeighbourTable();
		}
		Vector3 centrePosition = itemSpace.buildSquares[0].GetCentrePosition();
		TuckIntoTable(JIIGOACEIKL, CBOADNLDMBF: true);
		if (mainSeat && (Object)(object)table == (Object)null)
		{
			WorldGrid.CFAHJNLAJNK(centrePosition, JBNJGMKBKCB: false);
		}
	}
}
