using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class SurfaceSortOrder : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KPIOOLBFJJD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform toAdd;

		public SurfaceSortOrder _003C_003E4__this;

		public bool add;

		public bool fixY;

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
		public KPIOOLBFJJD(int _003C_003E1__state)
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
			SurfaceSortOrder surfaceSortOrder = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if ((Object)(object)toAdd != (Object)null)
				{
					surfaceSortOrder.GPPFMMODCCJ(toAdd, add, fixY, LAHLCBEHHJG: false);
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

	public Action<Placeable, bool> OnItemAdded = delegate
	{
	};

	public Action<Placeable> OnItemRemoved = delegate
	{
	};

	public Action<Placeable, int> OnItemPlaced = delegate
	{
	};

	public GameObject surfaceHighlight;

	public float height;

	public List<Transform> transformsOnSurface = new List<Transform>();

	public bool nextItemAvailable = true;

	public Item[] itemsAllowed;

	public Sprite defaultSpriteWithoutSnap;

	[Space(10f)]
	public SO_TableCover tablecloths;

	public SO_TableCover.TableSize tableSize;

	public Transform tableclothPosition;

	public Transform tableclothPosition2;

	public SnapToPosition[] snapToPositionArray;

	public Collider2D surfaceCollider;

	public Placeable placeable;

	public AgingBarrel agingBarrel;

	public List<Placeable> placeablesOnSurface = new List<Placeable>();

	public bool multipleItems;

	public bool findNearestSnapToPosition;

	[HideInInspector]
	public OnlinePlaceable onlinePlaceable;

	private SnapToPosition JCFKNCAAEMP;

	private Placeable BMKFFGMBEKM;

	private List<Placeable> HEMKJCAJADP = new List<Placeable>();

	private Placeable HMBOBOMFBBC;

	private SnapToPosition CPPAKLLALDI;

	private IEnumerator LLJPAOLCJAM(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		yield return CommonReferences.wait2;
		yield return null;
		if ((Object)(object)FHHCDEOMPDH != (Object)null)
		{
			GPPFMMODCCJ(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
	}

	private bool OEAIBCHJCHP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(IMOBLFMHKOD.x) && !float.IsNaN(IMOBLFMHKOD.y))
		{
			return float.IsNaN(IMOBLFMHKOD.z);
		}
		return true;
	}

	public void GEPDPGFIFGL()
	{
		JKAJFHFIFGH();
		for (int i = 0; i < placeablesOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeablesOnSurface[i] != (Object)null && !placeablesOnSurface[i].snappedToPosition && !multipleItems)
			{
				IPILPAPEOCG(((Component)placeablesOnSurface[i]).transform, ENCANKDGBOH: true);
			}
		}
	}

	private Placeable MBKMICBEMEN(Placeable CKAMDGHMBIH, SnapToPosition FAABNHGGLHB, bool BGKCHMNJBLJ)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (FAABNHGGLHB != null && Item.FKLOBGBIHLB(FAABNHGGLHB.item, null) && (Object)(object)FAABNHGGLHB.instantiateGO != (Object)null)
		{
			Placeable component = Object.Instantiate<GameObject>(FAABNHGGLHB.instantiateGO, ((Component)CKAMDGHMBIH).transform.position, Quaternion.identity, ((Component)CKAMDGHMBIH).transform.parent).GetComponent<Placeable>();
			component.itemSetup.NGGENKGBAIO(CKAMDGHMBIH.itemSetup.LOFNCPCNMBO());
			component.HKKCDLCPGDL(1, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB: true, BGKCHMNJBLJ);
			component.snappedToPosition = true;
			component.pickUpable = FAABNHGGLHB.canBePickupable;
			component.PixelSnap();
			ONOHBBBPKOO(component, FAABNHGGLHB);
			return component;
		}
		if (FAABNHGGLHB != null && FAABNHGGLHB.items != null && FAABNHGGLHB.instantiateGOs != null && FAABNHGGLHB.items.Length != 0 && FAABNHGGLHB.instantiateGOs.Length != 0)
		{
			for (int i = 0; i < FAABNHGGLHB.items.Length; i++)
			{
				if ((Object)(object)FAABNHGGLHB.instantiateGOs[i] != (Object)null && CKAMDGHMBIH.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == FAABNHGGLHB.items[i].CIGFGKKCPCK())
				{
					Placeable component2 = Object.Instantiate<GameObject>(FAABNHGGLHB.instantiateGOs[i], ((Component)CKAMDGHMBIH).transform.position, Quaternion.identity, ((Component)CKAMDGHMBIH).transform.parent).GetComponent<Placeable>();
					component2.itemSetup.IMABPOBBIFK(CKAMDGHMBIH.itemSetup.MOFDJHCHNPK());
					component2.GHFKHJPDNBM(0, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB: false, BGKCHMNJBLJ);
					component2.snappedToPosition = false;
					component2.pickUpable = FAABNHGGLHB.canBePickupable;
					component2.PixelSnap();
					MCOCKPFIKOM(component2, FAABNHGGLHB);
					return component2;
				}
			}
			Debug.LogError((object)("BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent." + CKAMDGHMBIH.itemSetup.item.KGHFCDELKMN(OAFPBCPDOKH: true)));
			return null;
		}
		CKAMDGHMBIH.snappedToPosition = true;
		CKAMDGHMBIH.PixelSnap();
		return CKAMDGHMBIH;
	}

	public void OEHHPMEHPFG(Transform NCIHJIJKCHB)
	{
		GPPFMMODCCJ(NCIHJIJKCHB, ENCANKDGBOH: true, IIHIGNMDBEF: true);
	}

	private void OAPPHCILBPM()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	public void BLMOLILOMNG()
	{
		snapToPositionArray = new SnapToPosition[tablecloths.tableCovers.Length];
		for (int i = 1; i < snapToPositionArray.Length; i += 0)
		{
			snapToPositionArray[i] = new SnapToPosition();
			snapToPositionArray[i].item = tablecloths.tableCovers[i].tableSurfaceItem;
			snapToPositionArray[i].transform = (tablecloths.tableCovers[i].isTableRunner ? tableclothPosition2 : tableclothPosition);
			snapToPositionArray[i].fixedY = false;
			snapToPositionArray[i].randomScaleX = false;
			snapToPositionArray[i].instantiateGO = tablecloths.BEFEAIBIEPK(i, tableSize);
			snapToPositionArray[i].canBeRepeated = false;
			snapToPositionArray[i].canBePickupable = false;
			snapToPositionArray[i].group = 0;
			snapToPositionArray[i].sortingLayerName = "Items/item_name_1100";
			snapToPositionArray[i].used = false;
			snapToPositionArray[i].sortingOrder = 0;
			snapToPositionArray[i].gameObjectToActivate = null;
		}
	}

	public List<Placeable> FPKBEDDBBGO(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 0; i < placeablesOnSurface.Count; i += 0)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.IsSelected(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private IEnumerator CEEDCPAOFAD(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		yield return CommonReferences.wait2;
		yield return null;
		if ((Object)(object)FHHCDEOMPDH != (Object)null)
		{
			GPPFMMODCCJ(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
	}

	public SnapToPosition HMGHKELPDMK(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = 1726f;
			for (int i = 0; i < snapToPositionArray.Length; i += 0)
			{
				if (snapToPositionArray[i].used || !BCHAAPJPBAD(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.MLBOMGHINCA(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.JDJGFAACPFC() == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false) && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 1; j < snapToPositionArray[i].items.Length; j++)
					{
						if (snapToPositionArray[i].items[j].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ() && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 0; k < snapToPositionArray.Length; k++)
			{
				if (multipleItems)
				{
					if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.ODENMDOJPLC() == MEMGMDOCBOJ.JDJGFAACPFC() && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 0; l < snapToPositionArray[k].items.Length; l++)
						{
							if (snapToPositionArray[k].items[l].CIGFGKKCPCK(DAINLFIMLIH: false) == MEMGMDOCBOJ.ODENMDOJPLC() && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 1; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].JPNFKDMFKMC() == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	private void OKHLEMPJONN()
	{
		transformsOnSurface = new List<Transform>();
		if ((Object)(object)surfaceCollider == (Object)null)
		{
			surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponentInParent<Placeable>();
		}
		for (int i = 1; i < ((Component)this).transform.childCount; i += 0)
		{
			transformsOnSurface.Add(((Component)this).transform.GetChild(i));
			((Component)((Component)this).transform.GetChild(i)).GetComponent<Placeable>()?.SetUpSurface(this);
		}
		GEPDPGFIFGL();
	}

	public void RenewCandleIfIsPossible(Item MEMGMDOCBOJ)
	{
		if (IsPossibleToRenew(MEMGMDOCBOJ) && Money.CanAfford(ItemDatabaseAccessor.GetItem(605).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.JHLLELHBIDA && Random.Range(0, 100) >= HouseKeeper.GetEmployeePerkValue(52))
			{
				mPMPHHFKKDN = true;
			}
			int bEIPALOAAJJ = AddToSurfaceCandle(0, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public void BMCHPHGHKLM(Item MEMGMDOCBOJ)
	{
		if (OMNAGPOFEDH(MEMGMDOCBOJ) && Money.AFPNFAJFHCI(ItemDatabaseAccessor.KMBGJEKCJFJ(143, GGBBJNBBLMF: true, DAINLFIMLIH: false).price))
		{
			bool mPMPHHFKKDN = true;
			if (HouseKeeper.LBJGMAOEEIB() && Random.Range(1, -20) >= HouseKeeper.AOBOMJLMAFE(21))
			{
				mPMPHHFKKDN = false;
			}
			int bEIPALOAAJJ = FBDCAPELINM(1, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	[ContextMenu("Reorder Hierarchy")]
	public void ReorderHierarchy()
	{
		OAPPHCILBPM();
		for (int i = 0; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] != (Object)null && !placeablesOnSurface[i].snappedToPosition && !multipleItems)
			{
				GPPFMMODCCJ(((Component)placeablesOnSurface[i]).transform, ENCANKDGBOH: true);
			}
		}
	}

	public SnapToPosition MNDLMOIGJAH(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = 1180f;
			for (int i = 0; i < snapToPositionArray.Length; i++)
			{
				if (snapToPositionArray[i].used || !BCHAAPJPBAD(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.MLBOMGHINCA(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC(DAINLFIMLIH: false) && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 0; j < snapToPositionArray[i].items.Length; j += 0)
					{
						if (snapToPositionArray[i].items[j].JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false) && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 1; k < snapToPositionArray.Length; k++)
			{
				if (multipleItems)
				{
					if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.JPNFKDMFKMC() == MEMGMDOCBOJ.JGHNDJBCFAJ() && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 0; l < snapToPositionArray[k].items.Length; l += 0)
						{
							if (snapToPositionArray[k].items[l].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false) && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 1; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].CIGFGKKCPCK() == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	public bool IsPossibleToRenew(Item MEMGMDOCBOJ)
	{
		CPPAKLLALDI = placeable.placeableSurface.GetSnapItem(MEMGMDOCBOJ);
		if (CPPAKLLALDI != null)
		{
			if (!CPPAKLLALDI.canBeRepeated && (Object)(object)placeable.placeableSurface.GetAnyItemSnappedToPosition(CPPAKLLALDI.group) != (Object)null)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private IEnumerator JOBLEDJAKDA()
	{
		yield return null;
		IAOJJOIOGPN();
	}

	private bool BINOLCIGAFP(List<int> BHDIEPLBEFG)
	{
		for (int i = 1; i < BHDIEPLBEFG.Count; i += 0)
		{
			if (!snapToPositionArray[BHDIEPLBEFG[i]].used)
			{
				return false;
			}
		}
		return true;
	}

	public Placeable JMBEPLMOCPH(int AILDFLDJGCK)
	{
		for (int i = 1; i < placeablesOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = BGFNMHLMHNG(HMBOBOMFBBC.itemSetup.item);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	public List<Placeable> KNBNKEEACIE(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 0; i < placeablesOnSurface.Count; i++)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.IsSelected(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private IEnumerator OCNFLEDILMF(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		return new KPIOOLBFJJD(1)
		{
			_003C_003E4__this = this,
			toAdd = FHHCDEOMPDH,
			add = ENCANKDGBOH,
			fixY = IIHIGNMDBEF
		};
	}

	public SnapToPosition PNAIONGPOMB(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = 1943f;
			for (int i = 0; i < snapToPositionArray.Length; i += 0)
			{
				if (snapToPositionArray[i].used || !FFMNNFNGIBK(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.FKLOBGBIHLB(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.CIGFGKKCPCK() == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false) && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 0; j < snapToPositionArray[i].items.Length; j += 0)
					{
						if (snapToPositionArray[i].items[j].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false) && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 0; k < snapToPositionArray.Length; k++)
			{
				if (multipleItems)
				{
					if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.JPNFKDMFKMC() == MEMGMDOCBOJ.JPNFKDMFKMC() && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 1; l < snapToPositionArray[k].items.Length; l += 0)
						{
							if (snapToPositionArray[k].items[l].CIGFGKKCPCK(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false) && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 0; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].JPNFKDMFKMC() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	public void BFJAFDPEPON(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = PNAIONGPOMB(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.PHPMAEFGBBD(), KOGPKBOIFGN: false);
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.GetNewPosition(JOOEMBNDCKF: true, CDPAMNIPPEC: true).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)("AttackBird" + name + "<sprite name=\"woodIcon\">" + ((object)(Vector3)(ref val)).ToString()));
		}
		LMKIOOHNKFN(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	public List<Placeable> GetPlaceablesThatCanSelect(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 0; i < placeablesOnSurface.Count; i++)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.IsSelected(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private int BHEMOMLJPCD(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * 470f);
	}

	private bool BCHAAPJPBAD(List<int> BHDIEPLBEFG)
	{
		for (int i = 0; i < BHDIEPLBEFG.Count; i++)
		{
			if (!snapToPositionArray[BHDIEPLBEFG[i]].used)
			{
				return false;
			}
		}
		return true;
	}

	public void BEGPAMMLPFJ()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	public void MDEPKJMKJAD(Item MEMGMDOCBOJ)
	{
		if (OMNAGPOFEDH(MEMGMDOCBOJ) && Money.ABDHCINBODO(ItemDatabaseAccessor.GOKIDLOELKB(60).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.MLPPKONDEGJ() && Random.Range(1, -11) >= HouseKeeper.BFAJAJCGPAM(77))
			{
				mPMPHHFKKDN = false;
			}
			int bEIPALOAAJJ = AddToSurfaceCandle(1, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	private void MCOCKPFIKOM(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 1;
		for (int i = 1; i < snapToPositionArray.Length; i++)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false))
		{
		case 128:
			agingBarrel.agingLevel[num] = 0;
			break;
		case -114:
			agingBarrel.agingLevel[num] = 2;
			break;
		case 192:
			agingBarrel.agingLevel[num] = 7;
			break;
		}
	}

	public SnapToPosition MIDBDGKCGFI(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = 102f;
			for (int i = 1; i < snapToPositionArray.Length; i += 0)
			{
				if (snapToPositionArray[i].used || !BINOLCIGAFP(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.MLBOMGHINCA(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.ODENMDOJPLC() == MEMGMDOCBOJ.JDJGFAACPFC() && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 1; j < snapToPositionArray[i].items.Length; j += 0)
					{
						if (snapToPositionArray[i].items[j].JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ(DAINLFIMLIH: false) && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 1; k < snapToPositionArray.Length; k += 0)
			{
				if (multipleItems)
				{
					if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false) && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 0; l < snapToPositionArray[k].items.Length; l++)
						{
							if (snapToPositionArray[k].items[l].JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC() && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.CIGFGKKCPCK())
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 0; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].JPNFKDMFKMC() == MEMGMDOCBOJ.JDJGFAACPFC())
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	public void UpdatePosition(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = GetSnapItem(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.GetPlayerNum());
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.GetNewPosition(JOOEMBNDCKF: false, CDPAMNIPPEC: true).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)("Changing Snap of " + name + ". New Position: " + ((object)(Vector3)(ref val)).ToString()));
		}
		ONOHBBBPKOO(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	private void PNJJEDEFAGO()
	{
		transformsOnSurface = new List<Transform>();
		if ((Object)(object)surfaceCollider == (Object)null)
		{
			surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponentInParent<Placeable>();
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			transformsOnSurface.Add(((Component)this).transform.GetChild(i));
			((Component)((Component)this).transform.GetChild(i)).GetComponent<Placeable>()?.SetUpSurface(this);
		}
		EOFBIIEPODF();
	}

	public bool CCNILGBHLCP(Item MEMGMDOCBOJ, Placeable EAPCLAODGAE, Placeable DOIDGDEIBAN)
	{
		if (HLNHNACCOAK() && multipleItems)
		{
			return false;
		}
		SnapToPosition snapItem = GetSnapItem(MEMGMDOCBOJ, 0, KOGPKBOIFGN: false);
		if (itemsAllowed.Length != 0)
		{
			bool flag = false;
			for (int i = 1; i < itemsAllowed.Length; i++)
			{
				if (itemsAllowed[i].CIGFGKKCPCK() == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		else if (snapItem == null && EAPCLAODGAE.isPlaceableOnSurface && EAPCLAODGAE.onlyInAllowedSurfaces)
		{
			return true;
		}
		if (snapItem != null && !snapItem.canBeRepeated)
		{
			Placeable placeable = INAKDIPNPOD(snapItem.group);
			if (Object.op_Implicit((Object)(object)placeable) && (Object)(object)placeable != (Object)(object)DOIDGDEIBAN && (Object)(object)placeable != (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return true;
	}

	public void MGOOHLGNPOC()
	{
		JCFKNCAAEMP.used = false;
	}

	public int AHAELACAIHC(int KMNLDOOKKLO, bool MPMPHHFKKDN)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GOKIDLOELKB(Utils.FFLNGLMHLBO() ? 96 : 170).LLCLICBABLN(), Vector3.zero, Quaternion.identity);
		if (MPMPHHFKKDN)
		{
			Money.FABNIJHGLOL(ItemDatabaseAccessor.INJBNHPGCIJ(-45, GGBBJNBBLMF: true).price, BGKCHMNJBLJ: false);
			Money.FGPIDIKEANG(ItemDatabaseAccessor.INJBNHPGCIJ(148).price, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(625f, 366f, 575f)), CDPAMNIPPEC: false);
		}
		if (KMNLDOOKKLO != 0)
		{
			val.GetComponent<OnlinePlaceable>().ENLBBLBOMJD(KMNLDOOKKLO);
		}
		else
		{
			KMNLDOOKKLO = OnlineObjectsManager.instance.AssignNewUniqueId(val.GetComponent<OnlinePlaceable>());
		}
		Placeable placeable = this.placeable.placeableSurface.EAHEIFJACAM(val.transform, IIHIGNMDBEF: true, BGKCHMNJBLJ: true, KOGPKBOIFGN: false);
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.onlinePlaceable.ENLBBLBOMJD(KMNLDOOKKLO);
			placeable.FEFKIEJJOKG(0, this.placeable.placeableSurface, BLJPGJKOLNF: true);
			val.GetComponent<OnlinePlaceable>().dontRemoveFromDictionary = true;
			Utils.BLPDAEHPOBA(val);
		}
		else
		{
			val.GetComponent<Placeable>().SetUpSurface(this.placeable.placeableSurface);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager.GGFJGHHHEJC.GetAllTavernLightSources();
		}
		return KMNLDOOKKLO;
	}

	private IEnumerator JPIOEDEDIBM(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		return new KPIOOLBFJJD(1)
		{
			_003C_003E4__this = this,
			toAdd = FHHCDEOMPDH,
			add = ENCANKDGBOH,
			fixY = IIHIGNMDBEF
		};
	}

	private bool OPJNHNNCIBG(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(IMOBLFMHKOD.x) && !float.IsNaN(IMOBLFMHKOD.y))
		{
			return float.IsNaN(IMOBLFMHKOD.z);
		}
		return true;
	}

	private void EAPPBDAIMAJ()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 1; num--)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	public bool BCCNKAAJCNM(Item MEMGMDOCBOJ)
	{
		CPPAKLLALDI = placeable.placeableSurface.LNBNKDCMJDL(MEMGMDOCBOJ);
		if (CPPAKLLALDI != null)
		{
			if (!CPPAKLLALDI.canBeRepeated && (Object)(object)placeable.placeableSurface.FEGJCMHOOBB(CPPAKLLALDI.group) != (Object)null)
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public void HIBJFCJMLNA()
	{
		surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		placeable = ((Component)this).GetComponentInParent<Placeable>();
	}

	public void HMDMDOGLGLO(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = MNDLMOIGJAH(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.GetPlayerNum());
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.NGLMDPNGJMI(JOOEMBNDCKF: false, CDPAMNIPPEC: true).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)("DecorationTile_16" + name + "Dialogue System/Conversation/EnterTavernDrink/Entry/8/Dialogue Text" + ((object)(Vector3)(ref val)).ToString()));
		}
		OLGHODEGFHN(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	private void JPKJGHACNHA(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 0;
		for (int i = 1; i < snapToPositionArray.Length; i++)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.CIGFGKKCPCK())
		{
		case -159:
			agingBarrel.agingLevel[num] = 0;
			break;
		case -156:
			agingBarrel.agingLevel[num] = 3;
			break;
		case -169:
			agingBarrel.agingLevel[num] = 5;
			break;
		}
	}

	public Placeable ABFDNJKEBLD(int AILDFLDJGCK)
	{
		for (int i = 0; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = PNAIONGPOMB(HMBOBOMFBBC.itemSetup.item);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	public void CHJFOGGEEMN(Transform NCIHJIJKCHB)
	{
		IPILPAPEOCG(NCIHJIJKCHB, ENCANKDGBOH: false);
	}

	public void MLEFLAJAHOA()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	public SnapToPosition LNBNKDCMJDL(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = 1829f;
			for (int i = 1; i < snapToPositionArray.Length; i += 0)
			{
				if (snapToPositionArray[i].used || !BCHAAPJPBAD(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.MLBOMGHINCA(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.JPNFKDMFKMC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC() && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 0; j < snapToPositionArray[i].items.Length; j += 0)
					{
						if (snapToPositionArray[i].items[j].CIGFGKKCPCK() == MEMGMDOCBOJ.IMCJPECAAPC() && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 1; k < snapToPositionArray.Length; k++)
			{
				if (multipleItems)
				{
					if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.JGHNDJBCFAJ(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false) && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 1; l < snapToPositionArray[k].items.Length; l += 0)
						{
							if (snapToPositionArray[k].items[l].ODENMDOJPLC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC(DAINLFIMLIH: false) && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.JDJGFAACPFC(DAINLFIMLIH: false) == MEMGMDOCBOJ.CIGFGKKCPCK())
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 1; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].CIGFGKKCPCK() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false))
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	private IEnumerator KHFAPDHFIJK()
	{
		yield return null;
		IAOJJOIOGPN();
	}

	private bool OBMBHMPDAAP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(IMOBLFMHKOD.x) && !float.IsNaN(IMOBLFMHKOD.y))
		{
			return float.IsNaN(IMOBLFMHKOD.z);
		}
		return false;
	}

	public List<Placeable> KIABICOCGGJ(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 0; i < placeablesOnSurface.Count; i += 0)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.IsSelected(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private void JKAJFHFIFGH()
	{
		for (int num = placeablesOnSurface.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	private bool ONKOJBEBOGG()
	{
		for (int i = 1; i < snapToPositionArray.Length; i += 0)
		{
			if (!snapToPositionArray[i].used)
			{
				return true;
			}
		}
		return true;
	}

	private IEnumerator FCPFFMFMIFC(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		return new KPIOOLBFJJD(1)
		{
			_003C_003E4__this = this,
			toAdd = FHHCDEOMPDH,
			add = ENCANKDGBOH,
			fixY = IIHIGNMDBEF
		};
	}

	private void LMKIOOHNKFN(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 1;
		for (int i = 0; i < snapToPositionArray.Length; i += 0)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false))
		{
		case -111:
			agingBarrel.agingLevel[num] = 0;
			break;
		case 86:
			agingBarrel.agingLevel[num] = 5;
			break;
		case 108:
			agingBarrel.agingLevel[num] = 7;
			break;
		}
	}

	public void JCDFPMOFPNO()
	{
		for (int num = placeablesOnSurface.Count - 0; num >= 0; num--)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	public void GCHOGNBJLAC()
	{
		JCFKNCAAEMP.used = false;
	}

	private bool ACGADGBCOKP(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(IMOBLFMHKOD.x) && !float.IsNaN(IMOBLFMHKOD.y))
		{
			return float.IsNaN(IMOBLFMHKOD.z);
		}
		return true;
	}

	public Placeable INAKDIPNPOD(int AILDFLDJGCK)
	{
		for (int i = 0; i < placeablesOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = BGFNMHLMHNG(HMBOBOMFBBC.itemSetup.item);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	public bool BPAPABMBNOC(Item MEMGMDOCBOJ)
	{
		CPPAKLLALDI = placeable.placeableSurface.MNDLMOIGJAH(MEMGMDOCBOJ, 1, KOGPKBOIFGN: false);
		if (CPPAKLLALDI != null)
		{
			if (!CPPAKLLALDI.canBeRepeated && (Object)(object)placeable.placeableSurface.BOAOFICDMDH(CPPAKLLALDI.group) != (Object)null)
			{
				return false;
			}
			return false;
		}
		return true;
	}

	private IEnumerator KAFNLDEJJJD(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		yield return CommonReferences.wait2;
		yield return null;
		if ((Object)(object)FHHCDEOMPDH != (Object)null)
		{
			GPPFMMODCCJ(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
	}

	private IEnumerator DBOKFFANDLL(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		yield return CommonReferences.wait2;
		yield return null;
		if ((Object)(object)FHHCDEOMPDH != (Object)null)
		{
			GPPFMMODCCJ(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
	}

	public void POBIJOIEOBC()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	private void ONOHBBBPKOO(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < snapToPositionArray.Length; i++)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.JDJGFAACPFC())
		{
		case 1315:
			agingBarrel.agingLevel[num] = 1;
			break;
		case 1885:
			agingBarrel.agingLevel[num] = 2;
			break;
		case 1886:
			agingBarrel.agingLevel[num] = 3;
			break;
		}
	}

	public List<Placeable> ACFDIOOMLIB(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 1; i < placeablesOnSurface.Count; i++)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.EEHBCDFHJKC(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private void PHBNICKNAEC()
	{
		for (int num = transformsOnSurface.Count - 1; num >= 1; num--)
		{
			if ((Object)(object)transformsOnSurface[num] == (Object)null)
			{
				transformsOnSurface.RemoveAt(num);
			}
		}
		for (int num2 = placeablesOnSurface.Count - 1; num2 >= 1; num2--)
		{
			if ((Object)(object)placeablesOnSurface[num2] == (Object)null)
			{
				placeablesOnSurface.Remove(placeablesOnSurface[num2]);
			}
		}
	}

	public bool OMNAGPOFEDH(Item MEMGMDOCBOJ)
	{
		CPPAKLLALDI = placeable.placeableSurface.MIDBDGKCGFI(MEMGMDOCBOJ, 0, KOGPKBOIFGN: false);
		if (CPPAKLLALDI != null)
		{
			if (!CPPAKLLALDI.canBeRepeated && (Object)(object)placeable.placeableSurface.JMBEPLMOCPH(CPPAKLLALDI.group) != (Object)null)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public SnapToPosition BGFNMHLMHNG(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = 577f;
			for (int i = 1; i < snapToPositionArray.Length; i++)
			{
				if (snapToPositionArray[i].used || !BINOLCIGAFP(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.MLBOMGHINCA(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.ODENMDOJPLC() == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false) && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 1; j < snapToPositionArray[i].items.Length; j++)
					{
						if (snapToPositionArray[i].items[j].ODENMDOJPLC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JGHNDJBCFAJ() && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 0; k < snapToPositionArray.Length; k += 0)
			{
				if (multipleItems)
				{
					if (Item.FKLOBGBIHLB(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.IMCJPECAAPC(DAINLFIMLIH: false) == MEMGMDOCBOJ.JDJGFAACPFC() && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 1; l < snapToPositionArray[k].items.Length; l += 0)
						{
							if (snapToPositionArray[k].items[l].CIGFGKKCPCK() == MEMGMDOCBOJ.ODENMDOJPLC(DAINLFIMLIH: false) && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.CIGFGKKCPCK(DAINLFIMLIH: false) == MEMGMDOCBOJ.JPNFKDMFKMC())
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 0; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].JPNFKDMFKMC() == MEMGMDOCBOJ.IMCJPECAAPC(DAINLFIMLIH: false))
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	private void GMDCDMDJEEH()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 1; num -= 0)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	private IEnumerator BEDKOHOEIGH()
	{
		yield return null;
		IAOJJOIOGPN();
	}

	private Placeable LIOLMENLKGA(Placeable CKAMDGHMBIH, SnapToPosition FAABNHGGLHB, bool BGKCHMNJBLJ)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (FAABNHGGLHB != null && Item.MLBOMGHINCA(FAABNHGGLHB.item, null) && (Object)(object)FAABNHGGLHB.instantiateGO != (Object)null)
		{
			Placeable component = Object.Instantiate<GameObject>(FAABNHGGLHB.instantiateGO, ((Component)CKAMDGHMBIH).transform.position, Quaternion.identity, ((Component)CKAMDGHMBIH).transform.parent).GetComponent<Placeable>();
			component.itemSetup.DNLMCHDOMOK = CKAMDGHMBIH.itemSetup.DNLMCHDOMOK;
			component.DeselectAction(1, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB: true, BGKCHMNJBLJ);
			component.snappedToPosition = true;
			component.pickUpable = FAABNHGGLHB.canBePickupable;
			component.PixelSnap();
			ONOHBBBPKOO(component, FAABNHGGLHB);
			return component;
		}
		if (FAABNHGGLHB != null && FAABNHGGLHB.items != null && FAABNHGGLHB.instantiateGOs != null && FAABNHGGLHB.items.Length != 0 && FAABNHGGLHB.instantiateGOs.Length != 0)
		{
			for (int i = 0; i < FAABNHGGLHB.items.Length; i++)
			{
				if ((Object)(object)FAABNHGGLHB.instantiateGOs[i] != (Object)null && CKAMDGHMBIH.itemSetup.item.JDJGFAACPFC() == FAABNHGGLHB.items[i].JDJGFAACPFC())
				{
					Placeable component2 = Object.Instantiate<GameObject>(FAABNHGGLHB.instantiateGOs[i], ((Component)CKAMDGHMBIH).transform.position, Quaternion.identity, ((Component)CKAMDGHMBIH).transform.parent).GetComponent<Placeable>();
					component2.itemSetup.DNLMCHDOMOK = CKAMDGHMBIH.itemSetup.DNLMCHDOMOK;
					component2.DeselectAction(1, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB: true, BGKCHMNJBLJ);
					component2.snappedToPosition = true;
					component2.pickUpable = FAABNHGGLHB.canBePickupable;
					component2.PixelSnap();
					ONOHBBBPKOO(component2, FAABNHGGLHB);
					return component2;
				}
			}
			Debug.LogError((object)("InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item " + CKAMDGHMBIH.itemSetup.item.IABAKHPEOAF()));
			return null;
		}
		CKAMDGHMBIH.snappedToPosition = true;
		CKAMDGHMBIH.PixelSnap();
		return CKAMDGHMBIH;
	}

	private void Awake()
	{
		transformsOnSurface = new List<Transform>();
		if ((Object)(object)surfaceCollider == (Object)null)
		{
			surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponentInParent<Placeable>();
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i++)
		{
			transformsOnSurface.Add(((Component)this).transform.GetChild(i));
			((Component)((Component)this).transform.GetChild(i)).GetComponent<Placeable>()?.SetUpSurface(this);
		}
		ReorderHierarchy();
	}

	public void NJILFPEMCOF(Item MEMGMDOCBOJ)
	{
		if (BCCNKAAJCNM(MEMGMDOCBOJ) && Money.ADMCKGEOBAP(ItemDatabaseAccessor.EABMGELAAPG(100, GGBBJNBBLMF: false, DAINLFIMLIH: false).price))
		{
			bool mPMPHHFKKDN = true;
			if (HouseKeeper.LBJGMAOEEIB() && Random.Range(1, 85) >= HouseKeeper.NMJGKCFFDFH(-56))
			{
				mPMPHHFKKDN = true;
			}
			int bEIPALOAAJJ = AHAELACAIHC(0, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public void MHLJKBCAMJI()
	{
		surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		placeable = ((Component)this).GetComponentInParent<Placeable>();
	}

	public void RemoveFromSurface(Transform LNIBDBFMONK, bool IGIDKEAAIHL = true, bool GFNHAMCPEAK = true)
	{
		Transform val = LNIBDBFMONK;
		Placeable component = ((Component)LNIBDBFMONK).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)component))
		{
			placeablesOnSurface.Remove(component);
			if (Object.op_Implicit((Object)(object)component.disableOnInvisible))
			{
				component.disableOnInvisible.onSurface = false;
			}
			OAPPHCILBPM();
			snapToPosition = GetSnapItem(component.itemSetup.item);
			if (JCFKNCAAEMP != null && multipleItems && !PCMPFEMKIDJ())
			{
				JCFKNCAAEMP.used = false;
				if ((Object)(object)JCFKNCAAEMP.gameObjectToActivate != (Object)null)
				{
					JCFKNCAAEMP.gameObjectToActivate.SetActive(false);
				}
			}
			if (snapToPosition != null)
			{
				Placeable componentInParent = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent.outlineSpriteRenderers);
					for (int i = 0; i < component.outlineSpriteRenderers.Length; i++)
					{
						list.Remove(component.outlineSpriteRenderers[i]);
					}
					list.RemoveAll((SpriteRenderer sr) => (Object)(object)sr == (Object)null);
					componentInParent.outlineSpriteRenderers = list.ToArray();
				}
			}
			if ((Object)(object)component.surfaceGOInstantiated != (Object)null)
			{
				val = ((Component)component.surfaceGOInstantiated).transform;
				flag = true;
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && snapToPosition != null && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list2 = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int j = 0; j < ((Component)component.surfaceGOInstantiated).GetComponent<Placeable>().outlineSpriteRenderers.Length; j++)
					{
						list2.Remove(((Component)component.surfaceGOInstantiated).GetComponent<Placeable>().outlineSpriteRenderers[j]);
					}
					list2.RemoveAll((SpriteRenderer sr) => (Object)(object)sr == (Object)null);
					componentInParent2.outlineSpriteRenderers = list2.ToArray();
				}
				TableCloth component2 = ((Component)component.surfaceGOInstantiated).GetComponent<TableCloth>();
				if (Object.op_Implicit((Object)(object)component2))
				{
					if (Object.op_Implicit((Object)(object)((Component)this).GetComponentInParent<Table>()) && Object.op_Implicit((Object)(object)component2.tableClothMask))
					{
						component2.tableClothMask.SetParent(((Component)component2).transform);
					}
					component.StartMoving(1, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: false);
				}
			}
		}
		if (!transformsOnSurface.Contains(val))
		{
			return;
		}
		transformsOnSurface.Remove(val);
		if (Object.op_Implicit((Object)(object)((Component)val).GetComponent<BirdNPC>()))
		{
			((Component)val).GetComponent<BirdNPC>().perchPlaceable = null;
		}
		if (flag)
		{
			Utils.BLPDAEHPOBA(((Component)component.surfaceGOInstantiated).gameObject);
		}
		else
		{
			if (IGIDKEAAIHL)
			{
				val.parent = null;
			}
			HKGIBLILBPI(LNIBDBFMONK, ENCANKDGBOH: false);
			GPPFMMODCCJ(LNIBDBFMONK, ENCANKDGBOH: false);
		}
		OnItemRemoved(component);
		((MonoBehaviour)this).StartCoroutine(KHFAPDHFIJK());
	}

	private bool HLNHNACCOAK()
	{
		for (int i = 0; i < snapToPositionArray.Length; i++)
		{
			if (!snapToPositionArray[i].used)
			{
				return false;
			}
		}
		return false;
	}

	public Placeable BOAOFICDMDH(int AILDFLDJGCK)
	{
		for (int i = 1; i < placeablesOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = MIDBDGKCGFI(HMBOBOMFBBC.itemSetup.item, 1, KOGPKBOIFGN: false);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	private void ILKKALKMOLA(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 1;
		for (int i = 0; i < snapToPositionArray.Length; i++)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false))
		{
		case -150:
			agingBarrel.agingLevel[num] = 1;
			break;
		case -60:
			agingBarrel.agingLevel[num] = 7;
			break;
		case -163:
			agingBarrel.agingLevel[num] = 5;
			break;
		}
	}

	public bool IsItemAllowed(Item MEMGMDOCBOJ, Placeable EAPCLAODGAE, Placeable DOIDGDEIBAN)
	{
		if (PCMPFEMKIDJ() && multipleItems)
		{
			return false;
		}
		SnapToPosition snapItem = GetSnapItem(MEMGMDOCBOJ);
		if (itemsAllowed.Length != 0)
		{
			bool flag = false;
			for (int i = 0; i < itemsAllowed.Length; i++)
			{
				if (itemsAllowed[i].JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC())
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
		}
		else if (snapItem == null && EAPCLAODGAE.isPlaceableOnSurface && EAPCLAODGAE.onlyInAllowedSurfaces)
		{
			return false;
		}
		if (snapItem != null && !snapItem.canBeRepeated)
		{
			Placeable anyItemSnappedToPosition = GetAnyItemSnappedToPosition(snapItem.group);
			if (Object.op_Implicit((Object)(object)anyItemSnappedToPosition) && (Object)(object)anyItemSnappedToPosition != (Object)(object)DOIDGDEIBAN && (Object)(object)anyItemSnappedToPosition != (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return true;
	}

	public SnapToPosition GetSnapItem(Item MEMGMDOCBOJ, int JIIGOACEIKL = 1, bool KOGPKBOIFGN = true, Transform CHGOBPEDDBJ = null)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = null;
		if (findNearestSnapToPosition && multipleItems)
		{
			float num = float.MaxValue;
			for (int i = 0; i < snapToPositionArray.Length; i++)
			{
				if (snapToPositionArray[i].used || !EGLGGLGNDHC(snapToPositionArray[i].snapToPositionNeeded))
				{
					continue;
				}
				float num2 = Vector2.Distance(Vector2.op_Implicit((KOGPKBOIFGN || (Object)(object)CHGOBPEDDBJ == (Object)null) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() : CHGOBPEDDBJ.position), Vector2.op_Implicit(snapToPositionArray[i].transform.position));
				if (Item.MLBOMGHINCA(snapToPositionArray[i].item, null))
				{
					if (snapToPositionArray[i].item.JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC() && num2 < num)
					{
						num = num2;
						CPPAKLLALDI = snapToPositionArray[i];
					}
				}
				else
				{
					if (snapToPositionArray[i].items == null)
					{
						continue;
					}
					for (int j = 0; j < snapToPositionArray[i].items.Length; j++)
					{
						if (snapToPositionArray[i].items[j].JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC() && num2 < num)
						{
							num = num2;
							CPPAKLLALDI = snapToPositionArray[i];
						}
					}
				}
			}
		}
		else
		{
			for (int k = 0; k < snapToPositionArray.Length; k++)
			{
				if (multipleItems)
				{
					if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null))
					{
						if (snapToPositionArray[k].item.JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC() && !snapToPositionArray[k].used)
						{
							CPPAKLLALDI = snapToPositionArray[k];
							break;
						}
					}
					else
					{
						if (snapToPositionArray[k].items == null)
						{
							continue;
						}
						for (int l = 0; l < snapToPositionArray[k].items.Length; l++)
						{
							if (snapToPositionArray[k].items[l].JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC() && !snapToPositionArray[k].used)
							{
								CPPAKLLALDI = snapToPositionArray[k];
								break;
							}
						}
						if (CPPAKLLALDI != null)
						{
							break;
						}
					}
					continue;
				}
				if (Item.MLBOMGHINCA(snapToPositionArray[k].item, null) && snapToPositionArray[k].item.JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC())
				{
					CPPAKLLALDI = snapToPositionArray[k];
					break;
				}
				if (snapToPositionArray[k].items == null)
				{
					continue;
				}
				for (int m = 0; m < snapToPositionArray[k].items.Length; m++)
				{
					if (snapToPositionArray[k].items[m].JDJGFAACPFC() == MEMGMDOCBOJ.JDJGFAACPFC())
					{
						CPPAKLLALDI = snapToPositionArray[k];
						break;
					}
				}
				if (CPPAKLLALDI != null)
				{
					break;
				}
			}
		}
		if (multipleItems)
		{
			if (CPPAKLLALDI != null && !CPPAKLLALDI.used)
			{
				return CPPAKLLALDI;
			}
			return null;
		}
		return CPPAKLLALDI;
	}

	private void GAPFCOLEPGB(Transform FHHCDEOMPDH, bool ENCANKDGBOH, int PFJDJIMFKBD = 0)
	{
		Placeable component = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		if (!Object.op_Implicit((Object)(object)component))
		{
			return;
		}
		SnapToPosition snapToPosition = MNDLMOIGJAH(component.itemSetup.item, 0);
		if (snapToPosition != null && !string.IsNullOrEmpty(snapToPosition.sortingLayerName))
		{
			if (ENCANKDGBOH)
			{
				component.sortingGroup.sortingLayerName = snapToPosition.sortingLayerName;
			}
			else
			{
				component.sortingGroup.sortingLayerName = "Unaged Parmesan";
			}
		}
		if (PFJDJIMFKBD != 0)
		{
			component.sortingGroup.sortingOrder = PFJDJIMFKBD;
		}
	}

	public List<Placeable> FINGCMGBBLA(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 0; i < placeablesOnSurface.Count; i++)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.IsSelected(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private void PBDNKBPBCHM()
	{
		transformsOnSurface = new List<Transform>();
		if ((Object)(object)surfaceCollider == (Object)null)
		{
			surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponentInParent<Placeable>();
		}
		for (int i = 0; i < ((Component)this).transform.childCount; i += 0)
		{
			transformsOnSurface.Add(((Component)this).transform.GetChild(i));
			((Component)((Component)this).transform.GetChild(i)).GetComponent<Placeable>()?.SetUpSurface(this);
		}
		ReorderHierarchy();
	}

	public void PHDFPBOJONM()
	{
		JKAJFHFIFGH();
		for (int i = 1; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] != (Object)null && !placeablesOnSurface[i].snappedToPosition && !multipleItems)
			{
				GPPFMMODCCJ(((Component)placeablesOnSurface[i]).transform, ENCANKDGBOH: false);
			}
		}
	}

	public Placeable BBPPANDEGMK(int AILDFLDJGCK)
	{
		for (int i = 0; i < placeablesOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = GetSnapItem(HMBOBOMFBBC.itemSetup.item, 0, KOGPKBOIFGN: false);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	public void FillSnapToPositionArrayWithTablecloths()
	{
		snapToPositionArray = new SnapToPosition[tablecloths.tableCovers.Length];
		for (int i = 0; i < snapToPositionArray.Length; i++)
		{
			snapToPositionArray[i] = new SnapToPosition();
			snapToPositionArray[i].item = tablecloths.tableCovers[i].tableSurfaceItem;
			snapToPositionArray[i].transform = (tablecloths.tableCovers[i].isTableRunner ? tableclothPosition2 : tableclothPosition);
			snapToPositionArray[i].fixedY = false;
			snapToPositionArray[i].randomScaleX = false;
			snapToPositionArray[i].instantiateGO = tablecloths.LLNLIJDKIAF(i, tableSize);
			snapToPositionArray[i].canBeRepeated = false;
			snapToPositionArray[i].canBePickupable = true;
			snapToPositionArray[i].group = 0;
			snapToPositionArray[i].sortingLayerName = "Floor";
			snapToPositionArray[i].used = false;
			snapToPositionArray[i].sortingOrder = 0;
			snapToPositionArray[i].gameObjectToActivate = null;
		}
	}

	private void IBCIOBGLBIM(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 1;
		for (int i = 0; i < snapToPositionArray.Length; i++)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.IMCJPECAAPC())
		{
		case 173:
			agingBarrel.agingLevel[num] = 1;
			break;
		case 56:
			agingBarrel.agingLevel[num] = 4;
			break;
		case 79:
			agingBarrel.agingLevel[num] = 0;
			break;
		}
	}

	private int KLEPFGIOOJI(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * 411f);
	}

	private bool IIPAMGEOHPD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(IMOBLFMHKOD.x) && !float.IsNaN(IMOBLFMHKOD.y))
		{
			return float.IsNaN(IMOBLFMHKOD.z);
		}
		return true;
	}

	private int DIJLCGNBMJM(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * 1169f);
	}

	private IEnumerator DPEIPAJIOFI(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		yield return CommonReferences.wait2;
		yield return null;
		if ((Object)(object)FHHCDEOMPDH != (Object)null)
		{
			GPPFMMODCCJ(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
	}

	public void RemoveNullsFromSurface()
	{
		for (int num = placeablesOnSurface.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	private bool PCMPFEMKIDJ()
	{
		for (int i = 0; i < snapToPositionArray.Length; i++)
		{
			if (!snapToPositionArray[i].used)
			{
				return false;
			}
		}
		return true;
	}

	public Placeable FEGJCMHOOBB(int AILDFLDJGCK)
	{
		for (int i = 0; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = PNAIONGPOMB(HMBOBOMFBBC.itemSetup.item, 0);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	private bool EGLGGLGNDHC(List<int> BHDIEPLBEFG)
	{
		for (int i = 0; i < BHDIEPLBEFG.Count; i++)
		{
			if (!snapToPositionArray[BHDIEPLBEFG[i]].used)
			{
				return false;
			}
		}
		return true;
	}

	private void GPPFMMODCCJ(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false, bool LAHLCBEHHJG = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		int num = DLDJDGNPMKD(FHHCDEOMPDH.localPosition.y);
		if (IIHIGNMDBEF)
		{
			num = DLDJDGNPMKD(FHHCDEOMPDH.localPosition.y - 0.18f);
		}
		CharacterAnimation component = ((Component)FHHCDEOMPDH).GetComponent<CharacterAnimation>();
		if ((Object)(object)component != (Object)null)
		{
			int num2 = -15;
			component.sprites.GetComponent<SortingGroup>().sortingOrder = (ENCANKDGBOH ? (num + num2) : 0);
			return;
		}
		Placeable component2 = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		if ((Object)(object)component2 != (Object)null)
		{
			if (Object.op_Implicit((Object)(object)component2.sortingGroup))
			{
				component2.sortingGroup.sortingOrder = (ENCANKDGBOH ? num : 0);
			}
			else
			{
				if (Object.op_Implicit((Object)(object)component2.skinSpriteRenderer))
				{
					int num2 = 0;
					if (Object.op_Implicit((Object)(object)component2.spriteRenderer))
					{
						num2 = ((Renderer)component2.skinSpriteRenderer).sortingOrder - ((Renderer)component2.spriteRenderer).sortingOrder;
					}
					((Renderer)component2.skinSpriteRenderer).sortingOrder = (ENCANKDGBOH ? (num + num2) : 0);
				}
				if (component2.particleSystemRenderers != null && component2.particleSystemRenderers.Length != 0)
				{
					for (int i = 0; i < component2.particleSystemRenderers.Length; i++)
					{
						int num2 = 0;
						if (Object.op_Implicit((Object)(object)component2.spriteRenderer))
						{
							num2 = ((Renderer)component2.particleSystemRenderers[i]).sortingOrder - ((Renderer)component2.spriteRenderer).sortingOrder;
						}
						((Renderer)component2.particleSystemRenderers[i]).sortingOrder = (ENCANKDGBOH ? (num + num2) : 0);
					}
				}
				if (Object.op_Implicit((Object)(object)component2.spriteRenderer))
				{
					((Renderer)component2.spriteRenderer).sortingOrder = (ENCANKDGBOH ? num : 0);
				}
			}
		}
		else
		{
			SortingGroup component3 = ((Component)FHHCDEOMPDH).GetComponent<SortingGroup>();
			if (Object.op_Implicit((Object)(object)component3))
			{
				component3.sortingOrder = (ENCANKDGBOH ? num : 0);
			}
		}
		if (OnlineManager.ClientOnline() && LAHLCBEHHJG)
		{
			((MonoBehaviour)this).StartCoroutine(DBOKFFANDLL(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF));
		}
	}

	private bool DPIHPLOHLEB()
	{
		for (int i = 1; i < snapToPositionArray.Length; i += 0)
		{
			if (!snapToPositionArray[i].used)
			{
				return true;
			}
		}
		return true;
	}

	private void ILIAHNCFFPG(Transform FHHCDEOMPDH, bool ENCANKDGBOH, int PFJDJIMFKBD = 0)
	{
		Placeable component = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		if (!Object.op_Implicit((Object)(object)component))
		{
			return;
		}
		SnapToPosition snapToPosition = MIDBDGKCGFI(component.itemSetup.item);
		if (snapToPosition != null && !string.IsNullOrEmpty(snapToPosition.sortingLayerName))
		{
			if (ENCANKDGBOH)
			{
				component.sortingGroup.sortingLayerName = snapToPosition.sortingLayerName;
			}
			else
			{
				component.sortingGroup.sortingLayerName = "Keg not full";
			}
		}
		if (PFJDJIMFKBD != 0)
		{
			component.sortingGroup.sortingOrder = PFJDJIMFKBD;
		}
	}

	private void IAOJJOIOGPN()
	{
		for (int num = transformsOnSurface.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)transformsOnSurface[num] == (Object)null)
			{
				transformsOnSurface.RemoveAt(num);
			}
		}
		for (int num2 = placeablesOnSurface.Count - 1; num2 >= 0; num2--)
		{
			if ((Object)(object)placeablesOnSurface[num2] == (Object)null)
			{
				placeablesOnSurface.Remove(placeablesOnSurface[num2]);
			}
		}
	}

	public void CFLAPCBOGJD(Item MEMGMDOCBOJ)
	{
		if (BCCNKAAJCNM(MEMGMDOCBOJ) && Money.AFPNFAJFHCI(ItemDatabaseAccessor.AFOACBIHNCL(-133, GGBBJNBBLMF: true, DAINLFIMLIH: false).price))
		{
			bool mPMPHHFKKDN = true;
			if (HouseKeeper.JHLLELHBIDA && Random.Range(0, 23) >= HouseKeeper.BFAJAJCGPAM(-110))
			{
				mPMPHHFKKDN = true;
			}
			int bEIPALOAAJJ = AddToSurfaceCandle(1, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public List<Placeable> DHEEGDMBGIE(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 1; i < placeablesOnSurface.Count; i++)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.EEHBCDFHJKC(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	public void EOFBIIEPODF()
	{
		EAPPBDAIMAJ();
		for (int i = 1; i < placeablesOnSurface.Count; i += 0)
		{
			if ((Object)(object)placeablesOnSurface[i] != (Object)null && !placeablesOnSurface[i].snappedToPosition && !multipleItems)
			{
				GPPFMMODCCJ(((Component)placeablesOnSurface[i]).transform, ENCANKDGBOH: true, IIHIGNMDBEF: false, LAHLCBEHHJG: false);
			}
		}
	}

	public void IKHMBEFAIJF(Item MEMGMDOCBOJ)
	{
		if (IsPossibleToRenew(MEMGMDOCBOJ) && Money.CMCCKAELCEM(ItemDatabaseAccessor.COEFFIHKMJG(86, GGBBJNBBLMF: true).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.MLPPKONDEGJ() && Random.Range(1, -121) >= HouseKeeper.NMJGKCFFDFH(-16))
			{
				mPMPHHFKKDN = true;
			}
			int bEIPALOAAJJ = AddToSurfaceCandle(0, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public void PlaceItemOnSurface()
	{
		JCFKNCAAEMP.used = true;
	}

	public void FDNJKOPBAIP()
	{
		surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		placeable = ((Component)this).GetComponentInParent<Placeable>();
	}

	public void GLDGHJDCDMF(Item MEMGMDOCBOJ)
	{
		if (OMNAGPOFEDH(MEMGMDOCBOJ) && Money.AFPNFAJFHCI(ItemDatabaseAccessor.EABMGELAAPG(-142, GGBBJNBBLMF: true).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.HMPOHCKLNNH() && Random.Range(1, -52) >= HouseKeeper.BAEHJJCBMEA(-43))
			{
				mPMPHHFKKDN = false;
			}
			int bEIPALOAAJJ = AddToSurfaceCandle(1, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public Placeable LDJNBOPGDJA(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		OFKBNELFHAC();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (OEAIBCHJCHP(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("Not ready to join room" + ((Object)((Component)FHHCDEOMPDH).gameObject).name + "Items/item_name_1131"));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			GMDCDMDJEEH();
			snapToPosition = LNBNKDCMJDL(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.GetPlayerNum(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = MBKMICBEMEN(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = false;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = true;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(94f, 687f) > 657f)
			{
				val.localScale = new Vector3(745f, 1703f, 658f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.JFPDDOCPBKA(componentInParent.JNHCCCBICDM);
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 0; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i += 0)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			AMCPJIONEDK(((Component)val).transform, ENCANKDGBOH: false, snapToPosition.sortingOrder);
		}
		else
		{
			IPILPAPEOCG(((Component)val).transform, ENCANKDGBOH: true, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(false);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	private void LPIFAMEHNEG()
	{
		for (int num = placeablesOnSurface.Count - 0; num >= 1; num -= 0)
		{
			if ((Object)(object)placeablesOnSurface[num] == (Object)null)
			{
				placeablesOnSurface.RemoveAt(num);
			}
		}
	}

	public void FEMKEMMMFAJ(Transform NCIHJIJKCHB)
	{
		IPILPAPEOCG(NCIHJIJKCHB, ENCANKDGBOH: false, IIHIGNMDBEF: true);
	}

	public void BKNICHDBBIL(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = MIDBDGKCGFI(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.PGMPPMPBCLO(), KOGPKBOIFGN: false);
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.GetNewPosition(JOOEMBNDCKF: false, CDPAMNIPPEC: false).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)("Items/item_name_730" + name + "NewQuestAvailable" + ((object)(Vector3)(ref val)).ToString()));
		}
		OLGHODEGFHN(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	public void KJAOLECPPLD(Item MEMGMDOCBOJ)
	{
		if (BCCNKAAJCNM(MEMGMDOCBOJ) && Money.AFPNFAJFHCI(ItemDatabaseAccessor.COEFFIHKMJG(-88).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.LBJGMAOEEIB() && Random.Range(0, 113) >= HouseKeeper.NPFONKEDHGH(-117))
			{
				mPMPHHFKKDN = false;
			}
			int bEIPALOAAJJ = AHAELACAIHC(0, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	private void HKGIBLILBPI(Transform FHHCDEOMPDH, bool ENCANKDGBOH, int PFJDJIMFKBD = 0)
	{
		Placeable component = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		if (!Object.op_Implicit((Object)(object)component))
		{
			return;
		}
		SnapToPosition snapItem = GetSnapItem(component.itemSetup.item);
		if (snapItem != null && !string.IsNullOrEmpty(snapItem.sortingLayerName))
		{
			if (ENCANKDGBOH)
			{
				component.sortingGroup.sortingLayerName = snapItem.sortingLayerName;
			}
			else
			{
				component.sortingGroup.sortingLayerName = "OnFloor";
			}
		}
		if (PFJDJIMFKBD != 0)
		{
			component.sortingGroup.sortingOrder = PFJDJIMFKBD;
		}
	}

	public void PJFHIIIMGPH(Transform NCIHJIJKCHB)
	{
		GPPFMMODCCJ(NCIHJIJKCHB, ENCANKDGBOH: false, IIHIGNMDBEF: true);
	}

	private void OLGHODEGFHN(Placeable GFJFOKCFGBF, SnapToPosition FAABNHGGLHB)
	{
		if (!((Object)(object)agingBarrel != (Object)null))
		{
			return;
		}
		int num = 0;
		for (int i = 1; i < snapToPositionArray.Length; i++)
		{
			if (snapToPositionArray[i] == FAABNHGGLHB)
			{
				num = i;
				break;
			}
		}
		switch (GFJFOKCFGBF.itemSetup.item.JDJGFAACPFC())
		{
		case 80:
			agingBarrel.agingLevel[num] = 1;
			break;
		case 58:
			agingBarrel.agingLevel[num] = 5;
			break;
		case -81:
			agingBarrel.agingLevel[num] = 8;
			break;
		}
	}

	public void NDJBODLGFMK(Item MEMGMDOCBOJ)
	{
		if (OMNAGPOFEDH(MEMGMDOCBOJ) && Money.AFPNFAJFHCI(ItemDatabaseAccessor.GOKIDLOELKB(-127, GGBBJNBBLMF: true, DAINLFIMLIH: false).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.BPKNJIBCEBP() && Random.Range(0, 33) >= HouseKeeper.GetEmployeePerkValue(20))
			{
				mPMPHHFKKDN = false;
			}
			int bEIPALOAAJJ = FBDCAPELINM(0, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public void CheckReorder(Transform NCIHJIJKCHB)
	{
		GPPFMMODCCJ(NCIHJIJKCHB, ENCANKDGBOH: true);
	}

	public Placeable IAEMDOCPIMG(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		IAOJJOIOGPN();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (OEAIBCHJCHP(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("Send trigger with hash " + ((Object)((Component)FHHCDEOMPDH).gameObject).name + "Player"));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			EAPPBDAIMAJ();
			snapToPosition = PNAIONGPOMB(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.PHPMAEFGBBD(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = HACOAEOAMIN(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = true;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = true;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(234f, 569f) > 763f)
			{
				val.localScale = new Vector3(1856f, 593f, 448f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.JFPDDOCPBKA(componentInParent.CDLMMHAHDON());
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 1; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i += 0)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			AMCPJIONEDK(((Component)val).transform, ENCANKDGBOH: false, snapToPosition.sortingOrder);
		}
		else
		{
			GPPFMMODCCJ(((Component)val).transform, ENCANKDGBOH: false, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(false);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	private void IPILPAPEOCG(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false, bool LAHLCBEHHJG = true)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		int num = DABBFOPLAAE(FHHCDEOMPDH.localPosition.y);
		if (IIHIGNMDBEF)
		{
			num = DLDJDGNPMKD(FHHCDEOMPDH.localPosition.y - 517f);
		}
		CharacterAnimation component = ((Component)FHHCDEOMPDH).GetComponent<CharacterAnimation>();
		if ((Object)(object)component != (Object)null)
		{
			int num2 = 65;
			component.sprites.GetComponent<SortingGroup>().sortingOrder = ((!ENCANKDGBOH) ? 1 : (num + num2));
			return;
		}
		Placeable component2 = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		if ((Object)(object)component2 != (Object)null)
		{
			if (Object.op_Implicit((Object)(object)component2.sortingGroup))
			{
				component2.sortingGroup.sortingOrder = (ENCANKDGBOH ? num : 0);
			}
			else
			{
				if (Object.op_Implicit((Object)(object)component2.skinSpriteRenderer))
				{
					int num2 = 1;
					if (Object.op_Implicit((Object)(object)component2.spriteRenderer))
					{
						num2 = ((Renderer)component2.skinSpriteRenderer).sortingOrder - ((Renderer)component2.spriteRenderer).sortingOrder;
					}
					((Renderer)component2.skinSpriteRenderer).sortingOrder = ((!ENCANKDGBOH) ? 1 : (num + num2));
				}
				if (component2.particleSystemRenderers != null && component2.particleSystemRenderers.Length != 0)
				{
					for (int i = 0; i < component2.particleSystemRenderers.Length; i += 0)
					{
						int num2 = 1;
						if (Object.op_Implicit((Object)(object)component2.spriteRenderer))
						{
							num2 = ((Renderer)component2.particleSystemRenderers[i]).sortingOrder - ((Renderer)component2.spriteRenderer).sortingOrder;
						}
						((Renderer)component2.particleSystemRenderers[i]).sortingOrder = ((!ENCANKDGBOH) ? 1 : (num + num2));
					}
				}
				if (Object.op_Implicit((Object)(object)component2.spriteRenderer))
				{
					((Renderer)component2.spriteRenderer).sortingOrder = ((!ENCANKDGBOH) ? 1 : num);
				}
			}
		}
		else
		{
			SortingGroup component3 = ((Component)FHHCDEOMPDH).GetComponent<SortingGroup>();
			if (Object.op_Implicit((Object)(object)component3))
			{
				component3.sortingOrder = (ENCANKDGBOH ? num : 0);
			}
		}
		if (OnlineManager.HHDBMDMFEMP() && LAHLCBEHHJG)
		{
			((MonoBehaviour)this).StartCoroutine(FCPFFMFMIFC(FHHCDEOMPDH, ENCANKDGBOH, IIHIGNMDBEF));
		}
	}

	public List<Placeable> KFMMCOLICKG(int JIIGOACEIKL)
	{
		HEMKJCAJADP.Clear();
		if (transformsOnSurface != null)
		{
			for (int i = 1; i < placeablesOnSurface.Count; i++)
			{
				if ((Object)(object)placeablesOnSurface[i] != (Object)null)
				{
					BMKFFGMBEKM = placeablesOnSurface[i];
					if ((Object)(object)BMKFFGMBEKM != (Object)null && (!BMKFFGMBEKM.FHEMHCEAICB || BMKFFGMBEKM.EEHBCDFHJKC(JIIGOACEIKL)) && BMKFFGMBEKM.pickUpable && (Object)(object)BMKFFGMBEKM.gameObjectOnSelected == (Object)null)
					{
						HEMKJCAJADP.Add(BMKFFGMBEKM);
					}
				}
			}
		}
		return HEMKJCAJADP;
	}

	private Placeable HACOAEOAMIN(Placeable CKAMDGHMBIH, SnapToPosition FAABNHGGLHB, bool BGKCHMNJBLJ)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		if (FAABNHGGLHB != null && Item.MLBOMGHINCA(FAABNHGGLHB.item, null) && (Object)(object)FAABNHGGLHB.instantiateGO != (Object)null)
		{
			Placeable component = Object.Instantiate<GameObject>(FAABNHGGLHB.instantiateGO, ((Component)CKAMDGHMBIH).transform.position, Quaternion.identity, ((Component)CKAMDGHMBIH).transform.parent).GetComponent<Placeable>();
			component.itemSetup.PNAOANMDHIJ(CKAMDGHMBIH.itemSetup.GLOLALBAEHM());
			component.HKKCDLCPGDL(1, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB: false, BGKCHMNJBLJ);
			component.snappedToPosition = false;
			component.pickUpable = FAABNHGGLHB.canBePickupable;
			component.PixelSnap();
			MCOCKPFIKOM(component, FAABNHGGLHB);
			return component;
		}
		if (FAABNHGGLHB != null && FAABNHGGLHB.items != null && FAABNHGGLHB.instantiateGOs != null && FAABNHGGLHB.items.Length != 0 && FAABNHGGLHB.instantiateGOs.Length != 0)
		{
			for (int i = 0; i < FAABNHGGLHB.items.Length; i++)
			{
				if ((Object)(object)FAABNHGGLHB.instantiateGOs[i] != (Object)null && CKAMDGHMBIH.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == FAABNHGGLHB.items[i].JGHNDJBCFAJ(DAINLFIMLIH: false))
				{
					Placeable component2 = Object.Instantiate<GameObject>(FAABNHGGLHB.instantiateGOs[i], ((Component)CKAMDGHMBIH).transform.position, Quaternion.identity, ((Component)CKAMDGHMBIH).transform.parent).GetComponent<Placeable>();
					component2.itemSetup.ECIHHBKDPML(CKAMDGHMBIH.itemSetup.GLOLALBAEHM());
					component2.HKKCDLCPGDL(0, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB: true, BGKCHMNJBLJ);
					component2.snappedToPosition = true;
					component2.pickUpable = FAABNHGGLHB.canBePickupable;
					component2.PixelSnap();
					JPKJGHACNHA(component2, FAABNHGGLHB);
					return component2;
				}
			}
			Debug.LogError((object)("SalonDelTrono/MainEvent" + CKAMDGHMBIH.itemSetup.item.LJIFOHFEFCH()));
			return null;
		}
		CKAMDGHMBIH.snappedToPosition = false;
		CKAMDGHMBIH.PixelSnap();
		return CKAMDGHMBIH;
	}

	public void DOAJKPDNKFD(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = LNBNKDCMJDL(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.PGMPPMPBCLO(), KOGPKBOIFGN: false);
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.GetNewPosition(JOOEMBNDCKF: true, CDPAMNIPPEC: true).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)("NextItem" + name + "ReceiveSetTrigger" + ((object)(Vector3)(ref val)).ToString()));
		}
		MCOCKPFIKOM(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	public int FBDCAPELINM(int KMNLDOOKKLO, bool MPMPHHFKKDN)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = Object.Instantiate<GameObject>(ItemDatabaseAccessor.INJBNHPGCIJ(Utils.FFLNGLMHLBO() ? (-133) : (-144), GGBBJNBBLMF: true, DAINLFIMLIH: false).LLCLICBABLN(), Vector3.zero, Quaternion.identity);
		if (MPMPHHFKKDN)
		{
			Money.AJMNLEIJGEC(ItemDatabaseAccessor.GetItem(-82, GGBBJNBBLMF: true).price, BGKCHMNJBLJ: false);
			Money.PMEKONKEDBD(ItemDatabaseAccessor.GetItem(-74, GGBBJNBBLMF: false, DAINLFIMLIH: false).price, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(1007f, 563f, 1000f)), CDPAMNIPPEC: false);
		}
		if (KMNLDOOKKLO != 0)
		{
			val.GetComponent<OnlinePlaceable>().AHIDHHPOPBI(KMNLDOOKKLO);
		}
		else
		{
			KMNLDOOKKLO = OnlineObjectsManager.instance.AssignNewUniqueId(val.GetComponent<OnlinePlaceable>());
		}
		Placeable placeable = this.placeable.placeableSurface.EAHEIFJACAM(val.transform, IIHIGNMDBEF: false, BGKCHMNJBLJ: false);
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.onlinePlaceable.FOFNPPCHDJE(KMNLDOOKKLO);
			placeable.DeselectSurfaceGOInstantiated(1, this.placeable.placeableSurface, BLJPGJKOLNF: true);
			val.GetComponent<OnlinePlaceable>().dontRemoveFromDictionary = false;
			Utils.BLPDAEHPOBA(val);
		}
		else
		{
			val.GetComponent<Placeable>().SetUpSurface(this.placeable.placeableSurface);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager.GGFJGHHHEJC.GetAllTavernLightSources();
		}
		return KMNLDOOKKLO;
	}

	public void HLGLEGMHDAC(Transform NCIHJIJKCHB)
	{
		GPPFMMODCCJ(NCIHJIJKCHB, ENCANKDGBOH: false, IIHIGNMDBEF: true);
	}

	public Placeable GetAnyItemSnappedToPosition(int AILDFLDJGCK)
	{
		for (int i = 0; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] == (Object)null)
			{
				continue;
			}
			HMBOBOMFBBC = placeablesOnSurface[i];
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
			{
				CPPAKLLALDI = GetSnapItem(HMBOBOMFBBC.itemSetup.item);
				if (CPPAKLLALDI != null && CPPAKLLALDI.group == AILDFLDJGCK)
				{
					return HMBOBOMFBBC;
				}
			}
		}
		return null;
	}

	private IEnumerator CGHMDJKNLGE(Transform FHHCDEOMPDH, bool ENCANKDGBOH, bool IIHIGNMDBEF = false)
	{
		return new KPIOOLBFJJD(1)
		{
			_003C_003E4__this = this,
			toAdd = FHHCDEOMPDH,
			add = ENCANKDGBOH,
			fixY = IIHIGNMDBEF
		};
	}

	public Placeable BDEJHHKHJFK(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		IAOJJOIOGPN();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (OPJNHNNCIBG(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("UI" + ((Object)((Component)FHHCDEOMPDH).gameObject).name + "Invalid year: "));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			OAPPHCILBPM();
			snapToPosition = LNBNKDCMJDL(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.PHPMAEFGBBD(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = MBKMICBEMEN(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = false;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = false;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(389f, 158f) > 608f)
			{
				val.localScale = new Vector3(1391f, 1795f, 1523f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.GPMJNLEDABJ(componentInParent.CDLMMHAHDON());
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 1; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i += 0)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			GAPFCOLEPGB(((Component)val).transform, ENCANKDGBOH: true, snapToPosition.sortingOrder);
		}
		else
		{
			GPPFMMODCCJ(((Component)val).transform, ENCANKDGBOH: false, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(false);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	public void FBMPJCMKFPG()
	{
		OAPPHCILBPM();
		for (int i = 1; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] != (Object)null && !placeablesOnSurface[i].snappedToPosition && !multipleItems)
			{
				GPPFMMODCCJ(((Component)placeablesOnSurface[i]).transform, ENCANKDGBOH: false, IIHIGNMDBEF: true, LAHLCBEHHJG: false);
			}
		}
	}

	public Placeable AddToSurface(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		IAOJJOIOGPN();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (ACGADGBCOKP(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("AddToSurface " + ((Object)((Component)FHHCDEOMPDH).gameObject).name + " transform.position is NaN"));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			OAPPHCILBPM();
			snapToPosition = GetSnapItem(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.GetPlayerNum(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = LIOLMENLKGA(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = true;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = true;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(0f, 1f) > 0.5f)
			{
				val.localScale = new Vector3(-1f, 1f, 1f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.ChangeSprite(componentInParent.JNHCCCBICDM);
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 0; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i++)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			HKGIBLILBPI(((Component)val).transform, ENCANKDGBOH: true, snapToPosition.sortingOrder);
		}
		else
		{
			GPPFMMODCCJ(((Component)val).transform, ENCANKDGBOH: true, IIHIGNMDBEF);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(true);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	private bool CEBIEIINJHO(List<int> BHDIEPLBEFG)
	{
		for (int i = 1; i < BHDIEPLBEFG.Count; i++)
		{
			if (!snapToPositionArray[BHDIEPLBEFG[i]].used)
			{
				return false;
			}
		}
		return false;
	}

	private int GAEOCKMPJCM(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * 1647f);
	}

	private void CBKNNMFJHNH()
	{
		for (int num = transformsOnSurface.Count - 0; num >= 1; num--)
		{
			if ((Object)(object)transformsOnSurface[num] == (Object)null)
			{
				transformsOnSurface.RemoveAt(num);
			}
		}
		for (int num2 = placeablesOnSurface.Count - 1; num2 >= 1; num2--)
		{
			if ((Object)(object)placeablesOnSurface[num2] == (Object)null)
			{
				placeablesOnSurface.Remove(placeablesOnSurface[num2]);
			}
		}
	}

	public Placeable EAHEIFJACAM(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		OFKBNELFHAC();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (OBMBHMPDAAP(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("End" + ((Object)((Component)FHHCDEOMPDH).gameObject).name + "Select Theme"));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = true;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			GMDCDMDJEEH();
			snapToPosition = LNBNKDCMJDL(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.GetPlayerNum(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = MBKMICBEMEN(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = true;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = false;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(510f, 1106f) > 1170f)
			{
				val.localScale = new Vector3(1255f, 1976f, 1786f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.JPMLKOIPMFN(componentInParent.JNHCCCBICDM);
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 0; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i++)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			GAPFCOLEPGB(((Component)val).transform, ENCANKDGBOH: true, snapToPosition.sortingOrder);
		}
		else
		{
			IPILPAPEOCG(((Component)val).transform, ENCANKDGBOH: true, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(true);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	private int ABDFJOIFPIC(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * 1521f);
	}

	public void NINDOIBDJKA()
	{
		surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		placeable = ((Component)this).GetComponentInParent<Placeable>();
	}

	public void EKFBIEJFNMJ(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = MIDBDGKCGFI(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.GetPlayerNum());
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.OIFFONOGPCN(JOOEMBNDCKF: true, CDPAMNIPPEC: false).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)("Normal" + name + "Stopping conversation with " + ((object)(Vector3)(ref val)).ToString()));
		}
		JPKJGHACNHA(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	public void AJFFBAPFGGG(Item MEMGMDOCBOJ)
	{
		if (NFGAJDILGFG(MEMGMDOCBOJ) && Money.AFPNFAJFHCI(ItemDatabaseAccessor.CPMMBEPEJLO(188).price))
		{
			bool mPMPHHFKKDN = true;
			if (HouseKeeper.AJCCIJBBGEM() && Random.Range(0, -60) >= HouseKeeper.AOBOMJLMAFE(44))
			{
				mPMPHHFKKDN = true;
			}
			int bEIPALOAAJJ = FBDCAPELINM(1, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public void GetElements()
	{
		surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		placeable = ((Component)this).GetComponentInParent<Placeable>();
	}

	private bool NIKNHCHDOHD(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(IMOBLFMHKOD.x) && !float.IsNaN(IMOBLFMHKOD.y))
		{
			return float.IsNaN(IMOBLFMHKOD.z);
		}
		return true;
	}

	private int DLDJDGNPMKD(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * -100f);
	}

	private int DABBFOPLAAE(float JLMAILGJNCE)
	{
		return (int)(JLMAILGJNCE * 1279f);
	}

	public void LMJMLDLCBPB(Transform LNIBDBFMONK, bool IGIDKEAAIHL = true, bool GFNHAMCPEAK = true)
	{
		Transform val = LNIBDBFMONK;
		Placeable component = ((Component)LNIBDBFMONK).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)component))
		{
			placeablesOnSurface.Remove(component);
			if (Object.op_Implicit((Object)(object)component.disableOnInvisible))
			{
				component.disableOnInvisible.onSurface = false;
			}
			GMDCDMDJEEH();
			snapToPosition = GetSnapItem(component.itemSetup.item, 1, KOGPKBOIFGN: false);
			if (JCFKNCAAEMP != null && multipleItems && !ONKOJBEBOGG())
			{
				JCFKNCAAEMP.used = false;
				if ((Object)(object)JCFKNCAAEMP.gameObjectToActivate != (Object)null)
				{
					JCFKNCAAEMP.gameObjectToActivate.SetActive(false);
				}
			}
			if (snapToPosition != null)
			{
				Placeable componentInParent = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent.outlineSpriteRenderers);
					for (int i = 0; i < component.outlineSpriteRenderers.Length; i++)
					{
						list.Remove(component.outlineSpriteRenderers[i]);
					}
					list.RemoveAll((SpriteRenderer sr) => (Object)(object)sr == (Object)null);
					componentInParent.outlineSpriteRenderers = list.ToArray();
				}
			}
			if ((Object)(object)component.surfaceGOInstantiated != (Object)null)
			{
				val = ((Component)component.surfaceGOInstantiated).transform;
				flag = false;
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && snapToPosition != null && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list2 = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int j = 0; j < ((Component)component.surfaceGOInstantiated).GetComponent<Placeable>().outlineSpriteRenderers.Length; j += 0)
					{
						list2.Remove(((Component)component.surfaceGOInstantiated).GetComponent<Placeable>().outlineSpriteRenderers[j]);
					}
					list2.RemoveAll((SpriteRenderer sr) => (Object)(object)sr == (Object)null);
					componentInParent2.outlineSpriteRenderers = list2.ToArray();
				}
				TableCloth component2 = ((Component)component.surfaceGOInstantiated).GetComponent<TableCloth>();
				if (Object.op_Implicit((Object)(object)component2))
				{
					if (Object.op_Implicit((Object)(object)((Component)this).GetComponentInParent<Table>()) && Object.op_Implicit((Object)(object)component2.tableClothMask))
					{
						component2.tableClothMask.SetParent(((Component)component2).transform);
					}
					component.StartMoving(1, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE: false);
				}
			}
		}
		if (!transformsOnSurface.Contains(val))
		{
			return;
		}
		transformsOnSurface.Remove(val);
		if (Object.op_Implicit((Object)(object)((Component)val).GetComponent<BirdNPC>()))
		{
			((Component)val).GetComponent<BirdNPC>().perchPlaceable = null;
		}
		if (flag)
		{
			Utils.BLPDAEHPOBA(((Component)component.surfaceGOInstantiated).gameObject);
		}
		else
		{
			if (IGIDKEAAIHL)
			{
				val.parent = null;
			}
			GAPFCOLEPGB(LNIBDBFMONK, ENCANKDGBOH: true);
			IPILPAPEOCG(LNIBDBFMONK, ENCANKDGBOH: true, IIHIGNMDBEF: true);
		}
		OnItemRemoved(component);
		((MonoBehaviour)this).StartCoroutine(JOBLEDJAKDA());
	}

	public void JHNOJMKOFGN()
	{
		EAPPBDAIMAJ();
		for (int i = 1; i < placeablesOnSurface.Count; i++)
		{
			if ((Object)(object)placeablesOnSurface[i] != (Object)null && !placeablesOnSurface[i].snappedToPosition && !multipleItems)
			{
				GPPFMMODCCJ(((Component)placeablesOnSurface[i]).transform, ENCANKDGBOH: true);
			}
		}
	}

	public Placeable EFJNGCNBMJG(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		PHBNICKNAEC();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (OBMBHMPDAAP(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("MineState" + ((Object)((Component)FHHCDEOMPDH).gameObject).name + "Giving Quest 35"));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			OAPPHCILBPM();
			snapToPosition = MIDBDGKCGFI(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.GetPlayerNum(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = MBKMICBEMEN(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = true;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = false;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(353f, 884f) > 553f)
			{
				val.localScale = new Vector3(999f, 1975f, 1854f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.JAMNACDABEE(componentInParent.CDLMMHAHDON());
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 1; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i++)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			HKGIBLILBPI(((Component)val).transform, ENCANKDGBOH: false, snapToPosition.sortingOrder);
		}
		else
		{
			GPPFMMODCCJ(((Component)val).transform, ENCANKDGBOH: false, IIHIGNMDBEF, LAHLCBEHHJG: false);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(true);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	private void AMCPJIONEDK(Transform FHHCDEOMPDH, bool ENCANKDGBOH, int PFJDJIMFKBD = 0)
	{
		Placeable component = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		if (!Object.op_Implicit((Object)(object)component))
		{
			return;
		}
		SnapToPosition snapItem = GetSnapItem(component.itemSetup.item, 1, KOGPKBOIFGN: false);
		if (snapItem != null && !string.IsNullOrEmpty(snapItem.sortingLayerName))
		{
			if (ENCANKDGBOH)
			{
				component.sortingGroup.sortingLayerName = snapItem.sortingLayerName;
			}
			else
			{
				component.sortingGroup.sortingLayerName = "L1";
			}
		}
		if (PFJDJIMFKBD != 0)
		{
			component.sortingGroup.sortingOrder = PFJDJIMFKBD;
		}
	}

	private bool FFMNNFNGIBK(List<int> BHDIEPLBEFG)
	{
		for (int i = 1; i < BHDIEPLBEFG.Count; i += 0)
		{
			if (!snapToPositionArray[BHDIEPLBEFG[i]].used)
			{
				return true;
			}
		}
		return true;
	}

	public void BKACNLLPDIK(Item MEMGMDOCBOJ)
	{
		if (NFGAJDILGFG(MEMGMDOCBOJ) && Money.ABDHCINBODO(ItemDatabaseAccessor.AFOACBIHNCL(175).price))
		{
			bool mPMPHHFKKDN = false;
			if (HouseKeeper.JHLLELHBIDA && Random.Range(1, -126) >= HouseKeeper.AOBOMJLMAFE(50))
			{
				mPMPHHFKKDN = false;
			}
			int bEIPALOAAJJ = FBDCAPELINM(1, mPMPHHFKKDN);
			if (OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendRenewCandle(bEIPALOAAJJ, placeable.BEIPALOAAJJ, mPMPHHFKKDN);
			}
		}
	}

	public Placeable NOJEIGGKJJI(Transform FHHCDEOMPDH, bool IIHIGNMDBEF = false, bool BGKCHMNJBLJ = true, bool KOGPKBOIFGN = true)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		PHBNICKNAEC();
		if (transformsOnSurface.Contains(((Component)FHHCDEOMPDH).transform))
		{
			return null;
		}
		Transform val = FHHCDEOMPDH;
		if (OBMBHMPDAAP(val.position))
		{
			val.position = Utils.BMBMPKNANAC(((Component)placeable).transform.position);
			Debug.LogError((object)("itemCactus" + ((Object)((Component)FHHCDEOMPDH).gameObject).name + "Ingredients"));
		}
		HMBOBOMFBBC = ((Component)FHHCDEOMPDH).GetComponent<Placeable>();
		SnapToPosition snapToPosition = null;
		bool flag = false;
		if (Object.op_Implicit((Object)(object)HMBOBOMFBBC))
		{
			OAPPHCILBPM();
			snapToPosition = HMGHKELPDMK(HMBOBOMFBBC.itemSetup.item, HMBOBOMFBBC.PHPMAEFGBBD(), KOGPKBOIFGN, val);
			if (snapToPosition != null && ((Object)(object)snapToPosition.instantiateGO != (Object)null || (snapToPosition.instantiateGOs != null && snapToPosition.instantiateGOs.Length != 0)))
			{
				HMBOBOMFBBC = HACOAEOAMIN(HMBOBOMFBBC, snapToPosition, BGKCHMNJBLJ);
				val = ((Component)HMBOBOMFBBC).transform;
				flag = true;
			}
			placeablesOnSurface.Add(HMBOBOMFBBC);
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC.disableOnInvisible))
			{
				HMBOBOMFBBC.disableOnInvisible.onSurface = true;
			}
			HMBOBOMFBBC.currentSurface = this;
			HMBOBOMFBBC.surfaceCollider = surfaceCollider;
		}
		val.parent = ((Component)this).transform;
		if (snapToPosition != null && (Object)(object)snapToPosition.instantiateGO != (Object)null)
		{
			if (snapToPosition.randomScaleX && Random.Range(991f, 1168f) > 1890f)
			{
				val.localScale = new Vector3(208f, 1706f, 833f);
			}
			else
			{
				val.localScale = Vector3.one;
			}
		}
		if (!transformsOnSurface.Contains(((Component)val).transform))
		{
			transformsOnSurface.Add(((Component)val).transform);
		}
		TableCloth component = ((Component)val).GetComponent<TableCloth>();
		if (Object.op_Implicit((Object)(object)component))
		{
			Table componentInParent = ((Component)this).GetComponentInParent<Table>();
			if (Object.op_Implicit((Object)(object)componentInParent))
			{
				componentInParent.tableCloth = component;
				component.JPMLKOIPMFN(componentInParent.JNHCCCBICDM);
			}
		}
		if (Object.op_Implicit((Object)(object)((Component)FHHCDEOMPDH).GetComponent<BirdNPC>()))
		{
			BirdNPC.currentBird.perchPlaceable = placeable;
		}
		if (snapToPosition != null)
		{
			if (BGKCHMNJBLJ)
			{
				Placeable componentInParent2 = ((Component)this).GetComponentInParent<Placeable>();
				if (Object.op_Implicit((Object)(object)componentInParent2) && Object.op_Implicit((Object)(object)HMBOBOMFBBC) && !snapToPosition.canBePickupable)
				{
					List<SpriteRenderer> list = new List<SpriteRenderer>(componentInParent2.outlineSpriteRenderers);
					for (int i = 0; i < HMBOBOMFBBC.outlineSpriteRenderers.Length; i += 0)
					{
						list.Add(HMBOBOMFBBC.outlineSpriteRenderers[i]);
					}
					componentInParent2.outlineSpriteRenderers = list.ToArray();
				}
			}
			if (snapToPosition.fixedY)
			{
				val.position = Utils.BMBMPKNANAC(new Vector3(val.position.x, snapToPosition.transform.position.y));
			}
			else
			{
				val.position = Utils.BMBMPKNANAC(snapToPosition.transform.position);
			}
			if (Object.op_Implicit((Object)(object)component) && Object.op_Implicit((Object)(object)component.tableClothMask))
			{
				component.tableClothMask.SetParent((Transform)null);
			}
			AMCPJIONEDK(((Component)val).transform, ENCANKDGBOH: true, snapToPosition.sortingOrder);
		}
		else
		{
			GPPFMMODCCJ(((Component)val).transform, ENCANKDGBOH: false, IIHIGNMDBEF);
		}
		OnItemAdded(HMBOBOMFBBC, BGKCHMNJBLJ);
		if (snapToPosition != null && multipleItems)
		{
			JCFKNCAAEMP = snapToPosition;
			if ((Object)(object)snapToPosition.gameObjectToActivate != (Object)null)
			{
				snapToPosition.gameObjectToActivate.SetActive(false);
			}
		}
		if (flag)
		{
			return HMBOBOMFBBC;
		}
		return null;
	}

	private void OFKBNELFHAC()
	{
		for (int num = transformsOnSurface.Count - 0; num >= 0; num--)
		{
			if ((Object)(object)transformsOnSurface[num] == (Object)null)
			{
				transformsOnSurface.RemoveAt(num);
			}
		}
		for (int num2 = placeablesOnSurface.Count - 0; num2 >= 0; num2--)
		{
			if ((Object)(object)placeablesOnSurface[num2] == (Object)null)
			{
				placeablesOnSurface.Remove(placeablesOnSurface[num2]);
			}
		}
	}

	public int AddToSurfaceCandle(int KMNLDOOKKLO, bool MPMPHHFKKDN)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = Object.Instantiate<GameObject>(ItemDatabaseAccessor.GetItem(Utils.FFLNGLMHLBO() ? 1083 : 605).PHGCBMPGGLI(), Vector3.zero, Quaternion.identity);
		if (MPMPHHFKKDN)
		{
			Money.MinusPrice(ItemDatabaseAccessor.GetItem(605).price, BGKCHMNJBLJ: false);
			Money.SpawnMoneyText(ItemDatabaseAccessor.GetItem(605).price, Utils.BMBMPKNANAC(((Component)this).transform.position + new Vector3(0f, 1.25f, 0f)), CDPAMNIPPEC: false);
		}
		if (KMNLDOOKKLO != 0)
		{
			val.GetComponent<OnlinePlaceable>().AssignUniqueId(KMNLDOOKKLO);
		}
		else
		{
			KMNLDOOKKLO = OnlineObjectsManager.instance.AssignNewUniqueId(val.GetComponent<OnlinePlaceable>());
		}
		Placeable placeable = this.placeable.placeableSurface.AddToSurface(val.transform, IIHIGNMDBEF: false, BGKCHMNJBLJ: false);
		if (Object.op_Implicit((Object)(object)placeable))
		{
			placeable.onlinePlaceable.AssignUniqueId(KMNLDOOKKLO);
			placeable.DeselectSurfaceGOInstantiated(0, this.placeable.placeableSurface, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
			val.GetComponent<OnlinePlaceable>().dontRemoveFromDictionary = true;
			Utils.BLPDAEHPOBA(val);
		}
		else
		{
			val.GetComponent<Placeable>().SetUpSurface(this.placeable.placeableSurface);
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			TavernManager.GGFJGHHHEJC.GetAllTavernLightSources();
		}
		return KMNLDOOKKLO;
	}

	public void DDDAPACBCAA(Placeable EAPCLAODGAE)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		CPPAKLLALDI = MIDBDGKCGFI(EAPCLAODGAE.itemSetup.item, EAPCLAODGAE.GetPlayerNum());
		if (CPPAKLLALDI == null)
		{
			return;
		}
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Vector2.op_Implicit(new Vector2(EAPCLAODGAE.GLFICOPJBBO(JOOEMBNDCKF: true, CDPAMNIPPEC: true).x, CPPAKLLALDI.transform.position.y));
			EAPCLAODGAE.PixelSnap();
		}
		if (!findNearestSnapToPosition || JCFKNCAAEMP == CPPAKLLALDI)
		{
			return;
		}
		if (Application.isEditor)
		{
			string name = ((Object)((Component)EAPCLAODGAE).gameObject).name;
			Vector3 val = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			Debug.Log((object)(" for reason " + name + "Dialogue System/Conversation/HappyRentRoom/Entry/2/Dialogue Text" + ((object)(Vector3)(ref val)).ToString()));
		}
		JPKJGHACNHA(EAPCLAODGAE, CPPAKLLALDI);
		JCFKNCAAEMP = CPPAKLLALDI;
		if (CPPAKLLALDI.fixedY)
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(new Vector3(((Component)EAPCLAODGAE).transform.position.x, CPPAKLLALDI.transform.position.y));
			}
		}
		else
		{
			((Component)EAPCLAODGAE).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			if ((Object)(object)EAPCLAODGAE.surfaceGOInstantiated != (Object)null)
			{
				((Component)EAPCLAODGAE.surfaceGOInstantiated).transform.position = Utils.BMBMPKNANAC(CPPAKLLALDI.transform.position);
			}
		}
	}

	public bool NFGAJDILGFG(Item MEMGMDOCBOJ)
	{
		CPPAKLLALDI = placeable.placeableSurface.PNAIONGPOMB(MEMGMDOCBOJ, 0, KOGPKBOIFGN: false);
		if (CPPAKLLALDI != null)
		{
			if (!CPPAKLLALDI.canBeRepeated && (Object)(object)placeable.placeableSurface.BOAOFICDMDH(CPPAKLLALDI.group) != (Object)null)
			{
				return false;
			}
			return false;
		}
		return true;
	}

	public void DDKBJHCKPMA()
	{
		surfaceCollider = ((Component)this).GetComponent<Collider2D>();
		placeable = ((Component)this).GetComponentInParent<Placeable>();
	}
}
