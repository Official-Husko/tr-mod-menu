using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemSpace : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EHFHCANKNGN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemSpace _003C_003E4__this;

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
		public EHFHCANKNGN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ItemSpace itemSpace = _003C_003E4__this;
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
				if (!Object.op_Implicit((Object)(object)itemSpace.placeable.attachedToPlaceable))
				{
					bool flag = false;
					if (Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) && WorkAreasManager.GGFJGHHHEJC.workAreas != null)
					{
						for (int i = 0; i < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; i++)
						{
							if (flag)
							{
								break;
							}
							for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces.Count; j++)
							{
								if (flag)
								{
									break;
								}
								AreaSpace areaSpace = WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces[j];
								if (!((Object)(object)areaSpace != (Object)null))
								{
									continue;
								}
								Vector3 position = ((Component)areaSpace).transform.position;
								Vector3 val = ((Component)areaSpace).transform.position + new Vector3((float)areaSpace.x, (float)areaSpace.y) * 0.5f;
								for (int k = 0; k < itemSpace.buildSquares.Length; k++)
								{
									if (!((Object)(object)itemSpace.buildSquares[k] == (Object)null))
									{
										Vector2 val2 = Vector2.op_Implicit(itemSpace.buildSquares[k].GetCentrePosition());
										if (val2.x > position.x && val2.x < val.x && val2.y > position.y && val2.y < val.y)
										{
											areaSpace.placeablesInside.AAPJLEFMGJP(itemSpace.placeable);
											flag = true;
											break;
										}
									}
								}
							}
						}
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

	[CompilerGenerated]
	private sealed class BLFAPPMBDCG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemSpace _003C_003E4__this;

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
		public BLFAPPMBDCG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ItemSpace itemSpace = _003C_003E4__this;
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
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)itemSpace.placeable))
				{
					if ((Object)(object)itemSpace.placeable.itemSpace == (Object)null || itemSpace.placeable.itemSpace.buildSquares == null)
					{
						Debug.LogError((object)("Placeable without itemspace " + ((Object)((Component)itemSpace.placeable).gameObject).name), (Object)(object)((Component)itemSpace.placeable).gameObject);
						return false;
					}
					for (int i = 0; i < itemSpace.placeable.itemSpace.buildSquares.Length; i++)
					{
						if (!((Object)(object)itemSpace.placeable.itemSpace.buildSquares[i] != (Object)null))
						{
							continue;
						}
						List<Placeable> list = WorldGrid.OPLHBJGKKAD(itemSpace.placeable.itemSpace.buildSquares[i].GetCentrePosition());
						if (list == null)
						{
							continue;
						}
						for (int num2 = list.Count - 1; num2 >= 0; num2--)
						{
							if ((!Object.op_Implicit((Object)(object)list[num2].itemSetup) || !Object.op_Implicit((Object)(object)list[num2].itemSetup.item) || list[num2].itemSetup.item.JDJGFAACPFC() < 1236 || list[num2].itemSetup.item.JDJGFAACPFC() > 1239) && (Object)(object)list[num2].itemSpace == (Object)null && !list[num2].IsObjectInValidLocation(BIOKGEFFNAA: false))
							{
								list[num2].RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true);
							}
						}
					}
					itemSpace.placeable.ChangeObjectLayer(ODNGJHPOMMK: false);
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

	[CompilerGenerated]
	private sealed class KBDJKHOHLCA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemSpace _003C_003E4__this;

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
		public KBDJKHOHLCA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ItemSpace itemSpace = _003C_003E4__this;
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
				if ((Object)(object)itemSpace.placeable != (Object)null)
				{
					Utils.OEAOOGCGNCA(((Component)itemSpace).transform, itemSpace.placeable.placeableCollider, itemSpace.ONAHMNAIPDI);
					for (int i = 0; i < itemSpace.ONAHMNAIPDI.Count; i++)
					{
						WorldGrid.JDNOFFABHDI(Vector2.op_Implicit(itemSpace.ONAHMNAIPDI[i]), itemSpace.nodeCost);
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

	[SerializeField]
	[Min(1f)]
	public int x;

	[SerializeField]
	[Min(1f)]
	public int y;

	public FollowTransform followTransform;

	public BuildSquare[] buildSquares;

	public bool setUp = true;

	public bool manageNodesCost;

	[HideInInspector]
	public bool checkConstructionPositions;

	public bool checkHerbs = true;

	public float nodeCost = 1f;

	[SerializeField]
	private bool XInverted;

	public Placeable placeable;

	public bool canBeRemoved = true;

	public bool updateBuildSquares = true;

	private Color MOBBIHDGGFI;

	public bool noDeco;

	public bool ignoreNodes;

	public bool isSeat;

	[SerializeField]
	private IrrigatorSpace extraSquares;

	private List<Vector2> ONAHMNAIPDI;

	public void AFKDIIADNOA()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < buildSquares.Length; i += 0)
		{
			buildSquares[i]?.EKDNMBKHBPI(MOBBIHDGGFI);
		}
	}

	private IEnumerator FMHPGCBKFLE()
	{
		yield return null;
		yield return null;
		if (!Object.op_Implicit((Object)(object)placeable))
		{
			yield break;
		}
		if ((Object)(object)placeable.itemSpace == (Object)null || placeable.itemSpace.buildSquares == null)
		{
			Debug.LogError((object)("Placeable without itemspace " + ((Object)((Component)placeable).gameObject).name), (Object)(object)((Component)placeable).gameObject);
			yield break;
		}
		for (int i = 0; i < placeable.itemSpace.buildSquares.Length; i++)
		{
			if (!((Object)(object)placeable.itemSpace.buildSquares[i] != (Object)null))
			{
				continue;
			}
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(placeable.itemSpace.buildSquares[i].GetCentrePosition());
			if (list == null)
			{
				continue;
			}
			for (int num = list.Count - 1; num >= 0; num--)
			{
				if ((!Object.op_Implicit((Object)(object)list[num].itemSetup) || !Object.op_Implicit((Object)(object)list[num].itemSetup.item) || list[num].itemSetup.item.JDJGFAACPFC() < 1236 || list[num].itemSetup.item.JDJGFAACPFC() > 1239) && (Object)(object)list[num].itemSpace == (Object)null && !list[num].IsObjectInValidLocation(BIOKGEFFNAA: false))
				{
					list[num].RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true);
				}
			}
		}
		placeable.ChangeObjectLayer(ODNGJHPOMMK: false);
	}

	private IEnumerator IAAPMEOFKNF()
	{
		yield return null;
		if ((Object)(object)placeable != (Object)null)
		{
			Utils.OEAOOGCGNCA(((Component)this).transform, placeable.placeableCollider, ONAHMNAIPDI);
			for (int i = 0; i < ONAHMNAIPDI.Count; i++)
			{
				WorldGrid.JDNOFFABHDI(Vector2.op_Implicit(ONAHMNAIPDI[i]), nodeCost);
			}
		}
	}

	public bool IPJDINFIOIJ(Vector3 FCLEMHMMCMP, Vector3 EEBEMKBIJJB)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			Vector3 val = buildSquares[i].CBALBDIFOGF();
			if (val.x < FCLEMHMMCMP.x || val.x > EEBEMKBIJJB.x || val.y < FCLEMHMMCMP.y || val.y > EEBEMKBIJJB.y)
			{
				return true;
			}
		}
		return false;
	}

	public static bool JDKPKMLEGIA(Vector3 IMOBLFMHKOD, bool OEBNHGNJEJL = false)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD, GCDEDGFDKBL: false));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(401f, 1700f)));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(1801f, 46f), GCDEDGFDKBL: false));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(1483f, 943f)));
			Debug.Log((object)WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD));
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(983f, 1394f), GCDEDGFDKBL: false) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(166f, 795f)) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(977f, 1556f), GCDEDGFDKBL: false) || WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD))
		{
			return false;
		}
		if ((float)(int)(IMOBLFMHKOD.y * 1844f) / 1524f % 1809f == 1511f)
		{
			return false;
		}
		if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1782f, 1735f)) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1194f, 991f)) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1157f, 1369f)) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(412f, 1747f), null) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(95f, 1179f), null) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(648f, 1473f), null) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(378f, 1680f)) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1085f, 205f)) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(45f, 1156f)))
		{
			return WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(143f, 1207f));
		}
		return false;
	}

	public bool JJHPCBCDMGG(ZoneType GIBJPCAFCJB)
	{
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (buildSquares[i].LELHBKPLIGJ() != GIBJPCAFCJB)
			{
				return true;
			}
		}
		return true;
	}

	public static bool IsDoorSpaceValid(Vector3 IMOBLFMHKOD, bool OEBNHGNJEJL = false)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(0.5f, 0f)));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(0f, 0.5f)));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(0.5f, 0.5f)));
			Debug.Log((object)WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD));
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(0.5f, 0f)) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(0f, 0.5f)) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(0.5f, 0.5f)) || WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD))
		{
			return false;
		}
		if ((float)(int)(IMOBLFMHKOD.y * 2f) / 2f % 1f == 0.5f)
		{
			return false;
		}
		if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(0.5f, 0f)) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(0f, 0.5f)) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(0.5f, 0.5f)) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 1.5f), null) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2f), null) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(0f, 2.5f), null) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(-0.5f, 0.5f)) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1f, 0.5f)) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(-0.5f, 2f)))
		{
			return !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1f, 2f));
		}
		return false;
	}

	public void PlaceDoor(bool POBALELALFP, TilemapScene PBLLKEKGLPK, Door NCLKJEPJGCL = null)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && POBALELALFP)
		{
			for (int i = 0; i < buildSquares.Length; i++)
			{
				if (!WorldGrid.NGDDNLHKAPM(buildSquares[i].GetCentrePosition()))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(buildSquares[i].GetCentrePosition(), PBLLKEKGLPK, Season.Spring);
				}
				WorldGrid.PBOIFLICMKG(buildSquares[i].GetCentrePosition(), (MonoBehaviour)(object)NCLKJEPJGCL);
			}
		}
		for (int j = 0; j < buildSquares.Length; j++)
		{
			buildSquares[j].Place(this, POBALELALFP, placeable);
		}
		for (int k = 0; k < buildSquares.Length; k++)
		{
			for (int l = 0; l < WorldGrid.allMovementNodesInTile.Length; l++)
			{
				WorldGrid.FPHAMKKBNMC(buildSquares[k].GetTilePosition() + WorldGrid.allMovementNodesInTile[l]);
			}
		}
		if (POBALELALFP)
		{
			for (int m = 1; m < 5; m++)
			{
				WorldGrid.LMMELLKNMCF(buildSquares[0].GetCentrePosition() + Vector3.up * 0.25f * (float)m, GAKNPAMHAFB: false);
				WorldGrid.LMMELLKNMCF(buildSquares[2].GetCentrePosition() + Vector3.up * 0.25f * (float)m, GAKNPAMHAFB: false);
			}
			if (!noDeco && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.location != Location.RoomsMultiplayer)
			{
				bool flag = WorldGrid.EJCEAEPNJCA(buildSquares[0].GetLeft());
				bool flag2 = WorldGrid.EJCEAEPNJCA(buildSquares[2].GetRight());
				if (flag && flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[0].GetLeft()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[0].GetLeft()));
					WorldGrid.PIBHFFJJAFB(buildSquares[2].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[2].GetRight()));
					WorldGrid.IGFNOCNEHCO(buildSquares[2].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[2].GetRight()));
				}
				else if (flag)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[0].GetLeft()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[0].GetLeft()));
					WorldGrid.PIBHFFJJAFB(buildSquares[2].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[0].GetLeft()));
					WorldGrid.IGFNOCNEHCO(buildSquares[2].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[0].GetLeft()));
				}
				else if (flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[2].GetRight()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[2].GetRight()));
					WorldGrid.PIBHFFJJAFB(buildSquares[2].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[2].GetRight()));
					WorldGrid.IGFNOCNEHCO(buildSquares[2].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[2].GetRight()));
				}
			}
		}
		else
		{
			for (int n = 0; n < buildSquares.Length; n++)
			{
				if (n % 2 == 0)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[n].GetCentrePosition(), 0);
					WorldGrid.IGFNOCNEHCO(buildSquares[n].GetCentrePosition(), 0);
					WorldGrid.JHPFHCBNIIM(buildSquares[n].GetCentrePosition(), FBOKGEPKBPO: false, Utils.FJNKHMPEEKL());
				}
			}
		}
		if (Application.isPlaying && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.updateTerrain)
		{
			WorldGrid.CPDBMDJIHGG(PBLLKEKGLPK);
		}
	}

	public static bool PIPABJNBDJF(Vector2 IMOBLFMHKOD)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		((Vector2)(ref val))._002Ector(806f, 201f);
		while (true)
		{
			if (WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(IMOBLFMHKOD + val), JGDOHPCLJPM: true))
			{
				return false;
			}
			if (val.x == 758f)
			{
				val.x = 1123f;
				continue;
			}
			if (val.y == 1623f)
			{
				break;
			}
			val.x = 1863f;
			val.y += 1141f;
		}
		return false;
	}

	private void FFHMFBHAEID(EditorAction OKNOJJEFEBE)
	{
		FFHMFBHAEID();
	}

	private IEnumerator CNDGPEONBGF(Vector3[] FIEEDEGMOHH)
	{
		yield return CommonReferences.wait2;
		for (int i = 0; i < FIEEDEGMOHH.Length; i++)
		{
			_ = ref FIEEDEGMOHH[i];
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(FIEEDEGMOHH[i]);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].isPlaceableOnWall)
				{
					list[j].RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true);
				}
			}
		}
	}

	public void MDPEMPJOBNG()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < buildSquares.Length; i += 0)
		{
			buildSquares[i]?.SetColor(MOBBIHDGGFI);
		}
	}

	public void SetInitialColor()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.SetColor(MOBBIHDGGFI);
		}
	}

	private void OnDestroy()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame || TestQualityPCSettings.instance.active || (Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || (Object)(object)TavernConstructionManager.GGFJGHHHEJC == (Object)null || !((Object)(object)placeable != (Object)null))
		{
			return;
		}
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if ((Object)(object)buildSquares[i] != (Object)null)
			{
				WorldGrid.AKLCFEPBONI(buildSquares[i].GetTilePosition(), placeable);
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.StairsUp))
		{
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnApplyChanges = (Action<EditorAction>)Delegate.Remove(instance.OnApplyChanges, new Action<EditorAction>(FFHMFBHAEID));
			TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
			instance2.OnCancelChanges = (Action<EditorAction>)Delegate.Remove(instance2.OnCancelChanges, new Action<EditorAction>(FFHMFBHAEID));
		}
	}

	public static bool EJMHLAAIJBC(Vector2 IMOBLFMHKOD)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		((Vector2)(ref val))._002Ector(639f, 459f);
		while (true)
		{
			if (WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(IMOBLFMHKOD + val), JGDOHPCLJPM: true))
			{
				return false;
			}
			if (val.x == 1998f)
			{
				val.x = 1097f;
				continue;
			}
			if (val.y == 693f)
			{
				break;
			}
			val.x = 981f;
			val.y += 738f;
		}
		return false;
	}

	public void OBGGJJAKDPG(Color FLABEDBELMF)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.HAEPFHJCGEE(FLABEDBELMF);
		}
	}

	private void ENPKEOBKNHM()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < 8; i += 0)
		{
			WorldGrid.MJDKNJPJILH(buildSquares[1].GetTilePosition() + (Vector3.up * 31f + Vector3.up * 1714f * (float)i));
		}
	}

	private IEnumerator DLCBHPBJEAL()
	{
		return new KBDJKHOHLCA(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool GHNJIOOLBOH()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return false;
		}
		bool flag = false;
		flag &= HBDBAOMKGHF(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i++)
		{
			flag &= ACDFKMNBBBD(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	private IEnumerator NGHIKHGFOKL()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)placeable.attachedToPlaceable))
		{
			yield break;
		}
		bool flag = false;
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			yield break;
		}
		for (int i = 0; i < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; i++)
		{
			if (flag)
			{
				break;
			}
			for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces.Count; j++)
			{
				if (flag)
				{
					break;
				}
				AreaSpace areaSpace = WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces[j];
				if (!((Object)(object)areaSpace != (Object)null))
				{
					continue;
				}
				Vector3 position = ((Component)areaSpace).transform.position;
				Vector3 val = ((Component)areaSpace).transform.position + new Vector3((float)areaSpace.x, (float)areaSpace.y) * 0.5f;
				for (int k = 0; k < buildSquares.Length; k++)
				{
					if (!((Object)(object)buildSquares[k] == (Object)null))
					{
						Vector2 val2 = Vector2.op_Implicit(buildSquares[k].GetCentrePosition());
						if (val2.x > position.x && val2.x < val.x && val2.y > position.y && val2.y < val.y)
						{
							areaSpace.placeablesInside.AAPJLEFMGJP(placeable);
							flag = true;
							break;
						}
					}
				}
			}
		}
	}

	private void DONGKOKMGMM()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame || TestQualityPCSettings.instance.active || (Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || (Object)(object)TavernConstructionManager.DOIKFJDLKJP() == (Object)null || !((Object)(object)placeable != (Object)null))
		{
			return;
		}
		for (int i = 1; i < buildSquares.Length; i += 0)
		{
			if ((Object)(object)buildSquares[i] != (Object)null)
			{
				WorldGrid.AKLCFEPBONI(buildSquares[i].CLAGGKKKFIC(), placeable);
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.CellarDoor))
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
			tavernConstructionManager.OnApplyChanges = (Action<EditorAction>)Delegate.Remove(tavernConstructionManager.OnApplyChanges, new Action<EditorAction>(FFHMFBHAEID));
			TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KHMEGDIABBF();
			tavernConstructionManager2.OnCancelChanges = (Action<EditorAction>)Delegate.Remove(tavernConstructionManager2.OnCancelChanges, new Action<EditorAction>(IMAJGKCCMAJ));
		}
	}

	public void VincularElementos()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponentInParent<Placeable>();
		}
	}

	private bool NGHHONJIONP()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return false;
		}
		bool flag = false;
		flag &= ACDFKMNBBBD(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i += 0)
		{
			flag &= BGAOIIFDAOE(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	private void HFOCECKNDBG()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(true);
		}
	}

	public BuildSquare IFLGAFJKHFL(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		return buildSquares[NCPGNLOJGAF * y + JLMAILGJNCE];
	}

	private void FPOIFOGELHC()
	{
		if (updateBuildSquares)
		{
			MGCHMMFFBJA(LJCPGDDLJKL(BIOKGEFFNAA: true));
		}
	}

	private void ANLHPMPMBFM()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(false);
		}
	}

	public bool MPBAPJPKMIN(ZoneType GIBJPCAFCJB)
	{
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (buildSquares[i].GOEKOFOAFFK() != GIBJPCAFCJB)
			{
				return false;
			}
		}
		return true;
	}

	private bool ACDFKMNBBBD(PhysicalSpace FKJPAFFLFHE)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJPAFFLFHE != (Object)null && ((Component)FKJPAFFLFHE).gameObject.activeInHierarchy)
		{
			if (((Component)FKJPAFFLFHE).gameObject.activeSelf)
			{
				for (int i = y - 1; i < buildSquares.Length; i += y)
				{
					if (!WorldGrid.DNDMDGOHDJD(buildSquares[i].CBALBDIFOGF()) && FKJPAFFLFHE is PhysicalSpaceFloor { ignoreDisable: false })
					{
						((Component)FKJPAFFLFHE).gameObject.SetActive(false);
						break;
					}
				}
			}
			else
			{
				bool flag = true;
				for (int j = 1; j < buildSquares.Length; j++)
				{
					flag &= WorldGrid.DNDMDGOHDJD(buildSquares[j].FGGMIOHMGFL());
				}
				if (flag)
				{
					((Component)FKJPAFFLFHE).gameObject.SetActive(flag);
				}
			}
			if (((Component)FKJPAFFLFHE).gameObject.activeSelf && !FKJPAFFLFHE.BDDOMAFNMGP())
			{
				if (FKJPAFFLFHE is PhysicalSpaceWall physicalSpaceWall)
				{
					physicalSpaceWall.DCCCANLFFIB();
				}
				return false;
			}
		}
		return false;
	}

	public void FBJEDAPKDIN(bool POBALELALFP, TilemapScene PBLLKEKGLPK, Door NCLKJEPJGCL = null)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && POBALELALFP)
		{
			for (int i = 1; i < buildSquares.Length; i++)
			{
				if (!WorldGrid.NGDDNLHKAPM(buildSquares[i].BLKHDGGHFLA()))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(buildSquares[i].FANOLHHEFBO(), PBLLKEKGLPK, Season.Summer, DCHHFGLPNOF: true, JPLINFIKAJI: true, OPEEJDDDPLD: true);
				}
				WorldGrid.PBOIFLICMKG(buildSquares[i].CBALBDIFOGF(), (MonoBehaviour)(object)NCLKJEPJGCL);
			}
		}
		for (int j = 1; j < buildSquares.Length; j += 0)
		{
			buildSquares[j].HEBOOLOBEAN(this, POBALELALFP, placeable);
		}
		for (int k = 1; k < buildSquares.Length; k += 0)
		{
			for (int l = 1; l < WorldGrid.allMovementNodesInTile.Length; l += 0)
			{
				WorldGrid.FPHAMKKBNMC(buildSquares[k].CPPBAHGKNMD() + WorldGrid.allMovementNodesInTile[l]);
			}
		}
		if (POBALELALFP)
		{
			for (int m = 1; m < 1; m++)
			{
				WorldGrid.LMMELLKNMCF(buildSquares[1].FANOLHHEFBO() + Vector3.up * 851f * (float)m, GAKNPAMHAFB: true);
				WorldGrid.LMMELLKNMCF(buildSquares[7].GetCentrePosition() + Vector3.up * 1619f * (float)m, GAKNPAMHAFB: false);
			}
			if (!noDeco && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.location != (Location.Quarry | Location.FarmShop))
			{
				bool flag = WorldGrid.EJCEAEPNJCA(buildSquares[0].DEGOCEMNLJF());
				bool flag2 = WorldGrid.EJCEAEPNJCA(buildSquares[4].NNMOGKPAICM());
				if (flag && flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[1].EHGDHOMFDGM(), WorldGrid.IKCDANOHPJE(buildSquares[1].GetLeft()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].FANOLHHEFBO(), WorldGrid.PNKHEBBCGMG(buildSquares[1].DEGOCEMNLJF()));
					WorldGrid.PIBHFFJJAFB(buildSquares[8].EHGDHOMFDGM(), WorldGrid.IKCDANOHPJE(buildSquares[8].NNGLBLHOOCE()));
					WorldGrid.IGFNOCNEHCO(buildSquares[4].FANOLHHEFBO(), WorldGrid.PNKHEBBCGMG(buildSquares[3].EADNONADCEN()));
				}
				else if (flag)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].CBALBDIFOGF(), WorldGrid.IKCDANOHPJE(buildSquares[1].AGCMHHGPNCP()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].KGGGPHEMLII(), WorldGrid.PNKHEBBCGMG(buildSquares[0].DEGOCEMNLJF()));
					WorldGrid.PIBHFFJJAFB(buildSquares[0].CBALBDIFOGF(), WorldGrid.IKCDANOHPJE(buildSquares[1].GetLeft()));
					WorldGrid.IGFNOCNEHCO(buildSquares[3].EHGDHOMFDGM(), WorldGrid.PNKHEBBCGMG(buildSquares[0].DEGOCEMNLJF()));
				}
				else if (flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[1].KDFECDEEDHL(), WorldGrid.IKCDANOHPJE(buildSquares[5].NNGLBLHOOCE()));
					WorldGrid.IGFNOCNEHCO(buildSquares[1].FGGMIOHMGFL(), WorldGrid.PNKHEBBCGMG(buildSquares[5].NNMOGKPAICM()));
					WorldGrid.PIBHFFJJAFB(buildSquares[8].DCAPKPOGHPK(), WorldGrid.IKCDANOHPJE(buildSquares[3].HAMKANDIAIF()));
					WorldGrid.IGFNOCNEHCO(buildSquares[5].KGGGPHEMLII(), WorldGrid.PNKHEBBCGMG(buildSquares[5].EDCLJMKHIEF()));
				}
			}
		}
		else
		{
			for (int n = 0; n < buildSquares.Length; n += 0)
			{
				if (n % 3 == 0)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[n].FGGMIOHMGFL(), 1);
					WorldGrid.IGFNOCNEHCO(buildSquares[n].BOBEIFEGLOL(), 1);
					WorldGrid.JHPFHCBNIIM(buildSquares[n].KGGGPHEMLII(), FBOKGEPKBPO: true, Utils.FJNKHMPEEKL());
				}
			}
		}
		if (Application.isPlaying && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.updateTerrain)
		{
			WorldGrid.CPDBMDJIHGG(PBLLKEKGLPK);
		}
	}

	public void SetScale(float NEPECKCDBAD)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if ((Object)(object)buildSquares[i] != (Object)null)
			{
				buildSquares[i].offset = new Vector3(Mathf.Abs(buildSquares[i].offset.x) * NEPECKCDBAD, buildSquares[i].offset.y, buildSquares[i].offset.z);
			}
		}
	}

	public bool LJCPGDDLJKL(bool BIOKGEFFNAA = false, bool ELKPPAAMMIM = true)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)extraSquares) && !extraSquares.GGHGMCEPDKG())
		{
			return false;
		}
		for (int i = 1; i < buildSquares.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				if (!placeable.IsInValidLocation(WorldGrid.HJPCBBGHPDA(buildSquares[i].KDFECDEEDHL())))
				{
					return false;
				}
				if ((Object)(object)buildSquares[i] != (Object)null && !buildSquares[i].IBFAAHDLGHO(this, Object.op_Implicit((Object)(object)placeable.attachedToPlaceable), ELKPPAAMMIM, placeable.specificRules, checkConstructionPositions, checkHerbs))
				{
					return false;
				}
				if (placeable.placeInPlayer)
				{
					return true;
				}
				if (WorldGrid.BKKHDHJEPMK(WorldGrid.LOJBKLKMINM(buildSquares[i].KGGGPHEMLII())) != 0 && placeable.validIrrigatorType != WorldGrid.BKKHDHJEPMK(WorldGrid.LOJBKLKMINM(buildSquares[i].CBALBDIFOGF())))
				{
					return false;
				}
			}
			else if ((Object)(object)buildSquares[i] != (Object)null && !buildSquares[i].OPIIEJKANJC(this, FCILKADOPNE: true, ELKPPAAMMIM, placeable.specificRules, checkConstructionPositions, checkHerbs))
			{
				return false;
			}
		}
		if (!NGEAOLJJIKE())
		{
			return true;
		}
		if (placeable.specificRules.HasFlag(SpecificType.RoomDoor | SpecificType.PlayerBed))
		{
			float num = buildSquares[0].DCAPKPOGHPK().y;
			for (int j = 0; j < buildSquares.Length; j += 0)
			{
				if (buildSquares[j].KDFECDEEDHL().y > num)
				{
					num = buildSquares[j].KDFECDEEDHL().y;
				}
			}
			for (int k = 1; k < buildSquares.Length; k++)
			{
				if (num == buildSquares[k].KDFECDEEDHL().y && !WorldGrid.ALNFLFCLIEP(buildSquares[k].AMPFMOMCLON()))
				{
					return true;
				}
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.RoomDoor) && !JDKPKMLEGIA(buildSquares[0].FANOLHHEFBO()))
		{
			return true;
		}
		if (placeable.specificRules.HasFlag(SpecificType.CellarDoor | SpecificType.Door))
		{
			if (!IsDoorSpaceValid(buildSquares[0].FANOLHHEFBO(), OEBNHGNJEJL: true))
			{
				return true;
			}
			if (BIOKGEFFNAA && !((Component)placeable).GetComponent<RentedRoom>().FBCBNIMEEJC(out var _, KIKDLKGBCOC: false))
			{
				return true;
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.CellarDoor) && (WorldGrid.EJCEAEPNJCA(buildSquares[0].OCFKIFJBJBL()) || WorldGrid.EJCEAEPNJCA(buildSquares[0].EBDPCIGFPNP())))
		{
			return false;
		}
		if (placeable.specificRules.HasFlag(SpecificType.None))
		{
			if (!WorldGrid.EJCEAEPNJCA(buildSquares[0].MEGKMDFBCOD()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].DIOLLAJCDAH()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].AMPFMOMCLON()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].OKJIBAFAHKE()))
			{
				EJMHLAAIJBC(Vector2.op_Implicit(buildSquares[0].FANOLHHEFBO()));
				return false;
			}
			return true;
		}
		if (placeable.specificRules.HasFlag(SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp))
		{
			if (WorldGrid.EJCEAEPNJCA(buildSquares[0].GetLeftDown()) || WorldGrid.EJCEAEPNJCA(buildSquares[6].BEPCGEBLOOB()))
			{
				return false;
			}
			if (WorldGrid.EJCEAEPNJCA(buildSquares[0].PNDEJMDHJLH()) || WorldGrid.EJCEAEPNJCA(buildSquares[2].IMLPPEKIPFG()))
			{
				return true;
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.RoomDoor | SpecificType.Bar | SpecificType.StairsDown) && !((Component)placeable).GetComponent<Table>().COBPOKNFBEJ())
		{
			if (BIOKGEFFNAA)
			{
				MainUI.LJDOBNEINNJ(placeable.PHPMAEFGBBD(), LocalisationSystem.Get("Floor_4"), 1174f);
			}
			return false;
		}
		if (isSeat)
		{
			for (int l = 0; l < WorldGrid.allNeighbours.Length; l += 0)
			{
				if (WorldGrid.allNeighbours[l].direction == (Direction)7)
				{
					continue;
				}
				List<Placeable> list = WorldGrid.OPLHBJGKKAD(buildSquares[0].KDFECDEEDHL() + WorldGrid.allNeighbours[l].position);
				if (list == null)
				{
					continue;
				}
				for (int m = 0; m < list.Count; m++)
				{
					if (list[m].specificRules == ~(SpecificType.RoomDoor | SpecificType.PlayerBed))
					{
						Table component = ((Component)list[m]).GetComponent<Table>();
						if (((WorldGrid.allNeighbours[l].direction != 0 && WorldGrid.allNeighbours[l].direction != (Direction)8) || (component.placeable.direction != (Direction)7 && component.placeable.direction != 0)) && ((WorldGrid.allNeighbours[l].direction != 0 && WorldGrid.allNeighbours[l].direction != Direction.Down) || (component.placeable.direction != 0 && component.placeable.direction != Direction.Down)))
						{
							return false;
						}
					}
				}
			}
		}
		return true;
	}

	public void SetAvailable(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.SetAvailable(ACJFIEKCKEC, 1f);
		}
	}

	public Vector2 BACFBOBAPNI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)this).transform.position + new Vector3((float)x / 575f, (float)y / 1926f) * 1191f);
	}

	private IEnumerator DOPHLHJFPGM()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)placeable.attachedToPlaceable))
		{
			yield break;
		}
		bool flag = false;
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			yield break;
		}
		for (int i = 0; i < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; i++)
		{
			if (flag)
			{
				break;
			}
			for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces.Count; j++)
			{
				if (flag)
				{
					break;
				}
				AreaSpace areaSpace = WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces[j];
				if (!((Object)(object)areaSpace != (Object)null))
				{
					continue;
				}
				Vector3 position = ((Component)areaSpace).transform.position;
				Vector3 val = ((Component)areaSpace).transform.position + new Vector3((float)areaSpace.x, (float)areaSpace.y) * 0.5f;
				for (int k = 0; k < buildSquares.Length; k++)
				{
					if (!((Object)(object)buildSquares[k] == (Object)null))
					{
						Vector2 val2 = Vector2.op_Implicit(buildSquares[k].GetCentrePosition());
						if (val2.x > position.x && val2.x < val.x && val2.y > position.y && val2.y < val.y)
						{
							areaSpace.placeablesInside.AAPJLEFMGJP(placeable);
							flag = true;
							break;
						}
					}
				}
			}
		}
	}

	private void PKBHEKHOAAA()
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			((Component)this).gameObject.SetActive(true);
			if ((Object)(object)followTransform != (Object)null)
			{
				((Component)followTransform).gameObject.SetActive(true);
			}
		}
		if (TestQualityPCSettings.instance.active)
		{
			return;
		}
		if (setUp && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && Object.op_Implicit((Object)(object)placeable) && Object.op_Implicit((Object)(object)placeable.itemSetup) && Object.op_Implicit((Object)(object)placeable.itemSetup.item))
		{
			if (placeable.itemSetup.item.JGHNDJBCFAJ() == -161 && GameManager.NJNFHEPLEHL().HEJPPEJMPFE != null && VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.EOJJHMHBJAG().DBNLFMEFEKM(), VersionNumberManager.instance.DCKMIHBOLLK()))
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(CNDGPEONBGF(buildSquares.Select((BuildSquare x) => x.GetCentrePosition()).ToArray()));
			}
			if (placeable.itemSetup.item.CIGFGKKCPCK() == 24 && Object.op_Implicit((Object)(object)WorldGrid.CBPIPKCCFAC(((Component)this).transform.position, 95)))
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Items/item_description_1141");
				}
				placeable.HJGJFLNNCDD(1, EFNFMEIDGDN: true, BGIEPKNAKHI: true, IBCOKMGFPKB: true, KAJIBKHFEFF: true);
				return;
			}
		}
		MOBBIHDGGFI = buildSquares[0].NGJMGDANDBE();
		if (setUp && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !Place(NMLKLAGDNPF: false, KBNNPAKJDJM: true, CDPAMNIPPEC: false) && canBeRemoved && !SceneReferences.CDCFHKEAEKK())
		{
			placeable.RemovePlaceableAndItemsOnSurface(1, EFNFMEIDGDN: false, BGIEPKNAKHI: false, IBCOKMGFPKB: true, KAJIBKHFEFF: true);
			string[] array = new string[2];
			array[1] = "\n";
			array[1] = ((object)placeable.itemSetup.item)?.ToString();
			array[6] = "Disappear";
			Vector3 position = ((Component)placeable).transform.position;
			array[0] = ((object)(Vector3)(ref position)).ToString();
			array[2] = "Items/item_description_650";
			Debug.Log((object)string.Concat(array));
		}
		if ((Object)(object)placeable != (Object)null && placeable.specificRules.HasFlag(SpecificType.StairsUp))
		{
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(instance.OnApplyChanges, new Action<EditorAction>(IMAJGKCCMAJ));
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
			tavernConstructionManager.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager.OnCancelChanges, new Action<EditorAction>(FFHMFBHAEID));
		}
	}

	private void Start()
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			((Component)this).gameObject.SetActive(false);
			if ((Object)(object)followTransform != (Object)null)
			{
				((Component)followTransform).gameObject.SetActive(false);
			}
		}
		if (TestQualityPCSettings.instance.active)
		{
			return;
		}
		if (setUp && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && Object.op_Implicit((Object)(object)placeable) && Object.op_Implicit((Object)(object)placeable.itemSetup) && Object.op_Implicit((Object)(object)placeable.itemSetup.item))
		{
			if (placeable.itemSetup.item.JDJGFAACPFC() == 1313 && GameManager.GGFJGHHHEJC.HEJPPEJMPFE != null && VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.ABAEJAMHKHB))
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BECPKCKOKNL(buildSquares.Select((BuildSquare x) => x.GetCentrePosition()).ToArray()));
			}
			if (placeable.itemSetup.item.JDJGFAACPFC() == 1658 && Object.op_Implicit((Object)(object)WorldGrid.CBPIPKCCFAC(((Component)this).transform.position, 1658)))
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Estufa duplicada eliminada");
				}
				placeable.RemovePlaceableAndItemsOnSurface(1, EFNFMEIDGDN: false, BGIEPKNAKHI: true, IBCOKMGFPKB: false);
				return;
			}
		}
		MOBBIHDGGFI = buildSquares[0].GetColor();
		if (setUp && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !Place(NMLKLAGDNPF: true, KBNNPAKJDJM: true) && canBeRemoved && !SceneReferences.AFEDGPJNCDN)
		{
			placeable.RemovePlaceableAndItemsOnSurface(1, EFNFMEIDGDN: false, BGIEPKNAKHI: true, IBCOKMGFPKB: false, KAJIBKHFEFF: true);
			string[] obj = new string[5]
			{
				"Cannot place item ",
				((object)placeable.itemSetup.item)?.ToString(),
				" at ",
				null,
				null
			};
			Vector3 position = ((Component)placeable).transform.position;
			obj[3] = ((object)(Vector3)(ref position)).ToString();
			obj[4] = ". Added to delivery chest";
			Debug.Log((object)string.Concat(obj));
		}
		if ((Object)(object)placeable != (Object)null && placeable.specificRules.HasFlag(SpecificType.StairsUp))
		{
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(instance.OnApplyChanges, new Action<EditorAction>(FFHMFBHAEID));
			TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
			instance2.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(instance2.OnCancelChanges, new Action<EditorAction>(FFHMFBHAEID));
		}
	}

	public void IJADCHBDKMB()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.SetColor(MOBBIHDGGFI);
		}
	}

	private void KDNMPIOGIBD()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < 4; i += 0)
		{
			WorldGrid.MJDKNJPJILH(buildSquares[1].EAACFPHCPNF() + (Vector3.up * 1935f + Vector3.up * 438f * (float)i));
		}
	}

	public void EGDHJPBNFPL()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!ignoreNodes)
		{
			for (int i = 1; i < buildSquares.Length; i++)
			{
				Utils.ABPJKHCNLMF(buildSquares[i].CLAGGKKKFIC());
			}
		}
	}

	public void InvertX(bool NKFPJPCFBJI)
	{
		if (XInverted != NKFPJPCFBJI)
		{
			XInverted = NKFPJPCFBJI;
			for (int i = 0; i < buildSquares.Length; i++)
			{
				buildSquares[i].invertX = NKFPJPCFBJI;
				buildSquares[i].CheckNegativeScale();
			}
		}
	}

	private bool CNJMDHLPEEH()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return false;
		}
		bool flag = true;
		flag &= HBDBAOMKGHF(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i += 0)
		{
			flag &= ACDFKMNBBBD(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	public bool KDJHPDCHJBK(Vector3 FCLEMHMMCMP, Vector3 EEBEMKBIJJB)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			Vector3 val = buildSquares[i].BOBEIFEGLOL();
			if (val.x < FCLEMHMMCMP.x || val.x > EEBEMKBIJJB.x || val.y < FCLEMHMMCMP.y || val.y > EEBEMKBIJJB.y)
			{
				return true;
			}
		}
		return true;
	}

	public void LMEILPDBGDG(bool POBALELALFP, TilemapScene PBLLKEKGLPK, Door NCLKJEPJGCL = null)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && POBALELALFP)
		{
			for (int i = 1; i < buildSquares.Length; i++)
			{
				if (!WorldGrid.NGDDNLHKAPM(buildSquares[i].FGGMIOHMGFL()))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(buildSquares[i].KDFECDEEDHL(), PBLLKEKGLPK, Season.Summer, DCHHFGLPNOF: false, JPLINFIKAJI: false, OPEEJDDDPLD: true);
				}
				WorldGrid.PBOIFLICMKG(buildSquares[i].KDFECDEEDHL(), (MonoBehaviour)(object)NCLKJEPJGCL);
			}
		}
		for (int j = 1; j < buildSquares.Length; j += 0)
		{
			buildSquares[j].IPIKPJKKKEM(this, POBALELALFP, placeable);
		}
		for (int k = 0; k < buildSquares.Length; k++)
		{
			for (int l = 1; l < WorldGrid.allMovementNodesInTile.Length; l++)
			{
				WorldGrid.FPHAMKKBNMC(buildSquares[k].CPPBAHGKNMD() + WorldGrid.allMovementNodesInTile[l]);
			}
		}
		if (POBALELALFP)
		{
			for (int m = 0; m < 8; m += 0)
			{
				WorldGrid.LMMELLKNMCF(buildSquares[0].EHGDHOMFDGM() + Vector3.up * 1727f * (float)m, GAKNPAMHAFB: false);
				WorldGrid.LMMELLKNMCF(buildSquares[3].FANOLHHEFBO() + Vector3.up * 6f * (float)m, GAKNPAMHAFB: false);
			}
			if (!noDeco && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.location != ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.BarnInterior))
			{
				bool flag = WorldGrid.EJCEAEPNJCA(buildSquares[0].DEGOCEMNLJF());
				bool flag2 = WorldGrid.EJCEAEPNJCA(buildSquares[3].DIHMIKAMBJN());
				if (flag && flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].KDFECDEEDHL(), WorldGrid.IKCDANOHPJE(buildSquares[1].AGCMHHGPNCP()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].EHGDHOMFDGM(), WorldGrid.PNKHEBBCGMG(buildSquares[1].OPJGGIGPFBF()));
					WorldGrid.PIBHFFJJAFB(buildSquares[0].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[6].GetRight()));
					WorldGrid.IGFNOCNEHCO(buildSquares[6].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[8].HGJEGNPDFPO()));
				}
				else if (flag)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].BOBEIFEGLOL(), WorldGrid.IKCDANOHPJE(buildSquares[0].DEGOCEMNLJF()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].GetCentrePosition(), WorldGrid.PNKHEBBCGMG(buildSquares[0].DEGOCEMNLJF()));
					WorldGrid.PIBHFFJJAFB(buildSquares[1].BOBEIFEGLOL(), WorldGrid.IKCDANOHPJE(buildSquares[0].OPJGGIGPFBF()));
					WorldGrid.IGFNOCNEHCO(buildSquares[4].KGGGPHEMLII(), WorldGrid.PNKHEBBCGMG(buildSquares[1].AGCMHHGPNCP()));
				}
				else if (flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].BOBEIFEGLOL(), WorldGrid.IKCDANOHPJE(buildSquares[1].EADNONADCEN()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].KDFECDEEDHL(), WorldGrid.PNKHEBBCGMG(buildSquares[7].GetRight()));
					WorldGrid.PIBHFFJJAFB(buildSquares[4].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[4].NNMOGKPAICM()));
					WorldGrid.IGFNOCNEHCO(buildSquares[7].BLKHDGGHFLA(), WorldGrid.PNKHEBBCGMG(buildSquares[7].HGJEGNPDFPO()));
				}
			}
		}
		else
		{
			for (int n = 0; n < buildSquares.Length; n += 0)
			{
				if (n % 6 == 0)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[n].BLKHDGGHFLA(), 1);
					WorldGrid.IGFNOCNEHCO(buildSquares[n].KDFECDEEDHL(), 0);
					WorldGrid.JHPFHCBNIIM(buildSquares[n].FGGMIOHMGFL(), FBOKGEPKBPO: false, Utils.FJNKHMPEEKL());
				}
			}
		}
		if (Application.isPlaying && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.updateTerrain)
		{
			WorldGrid.CPDBMDJIHGG(PBLLKEKGLPK);
		}
	}

	public bool MJBGJBLMGNM(ZoneType GIBJPCAFCJB)
	{
		for (int i = 1; i < buildSquares.Length; i++)
		{
			if (buildSquares[i].GetZoneType() != GIBJPCAFCJB)
			{
				return true;
			}
		}
		return false;
	}

	private IEnumerator NMHGMKBKMIO()
	{
		return new EHFHCANKNGN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MCLAJGDIIBK()
	{
		if (updateBuildSquares)
		{
			PIPELIBAMAB(IsItemSpaceValid());
		}
	}

	private void OnEnable()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(true);
		}
	}

	public bool DAHGEMGPMGI(ZoneType GIBJPCAFCJB)
	{
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (buildSquares[i].IOLGJHAFIKC() != GIBJPCAFCJB)
			{
				return false;
			}
		}
		return false;
	}

	public bool IsItemSpaceValid(bool BIOKGEFFNAA = false, bool ELKPPAAMMIM = true)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)extraSquares) && !extraSquares.IsValid())
		{
			return false;
		}
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				if (!placeable.IsInValidLocation(WorldGrid.HJPCBBGHPDA(buildSquares[i].GetCentrePosition())))
				{
					return false;
				}
				if ((Object)(object)buildSquares[i] != (Object)null && !buildSquares[i].IsValid(this, Object.op_Implicit((Object)(object)placeable.attachedToPlaceable), ELKPPAAMMIM, placeable.specificRules, checkConstructionPositions, checkHerbs))
				{
					return false;
				}
				if (placeable.placeInPlayer)
				{
					return false;
				}
				if (WorldGrid.BKKHDHJEPMK(WorldGrid.LOJBKLKMINM(buildSquares[i].GetCentrePosition())) != 0 && placeable.validIrrigatorType != WorldGrid.BKKHDHJEPMK(WorldGrid.LOJBKLKMINM(buildSquares[i].GetCentrePosition())))
				{
					return false;
				}
			}
			else if ((Object)(object)buildSquares[i] != (Object)null && !buildSquares[i].IsValid(this, FCILKADOPNE: false, ELKPPAAMMIM, placeable.specificRules, checkConstructionPositions, checkHerbs))
			{
				return false;
			}
		}
		if (!CHHLOCGMLDJ())
		{
			return false;
		}
		if (placeable.specificRules.HasFlag(SpecificType.NextToWall))
		{
			float num = buildSquares[0].GetCentrePosition().y;
			for (int j = 0; j < buildSquares.Length; j++)
			{
				if (buildSquares[j].GetCentrePosition().y > num)
				{
					num = buildSquares[j].GetCentrePosition().y;
				}
			}
			for (int k = 0; k < buildSquares.Length; k++)
			{
				if (num == buildSquares[k].GetCentrePosition().y && !WorldGrid.ALNFLFCLIEP(buildSquares[k].GetUp()))
				{
					return false;
				}
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.Door) && !IsDoorSpaceValid(buildSquares[0].GetCentrePosition()))
		{
			return false;
		}
		if (placeable.specificRules.HasFlag(SpecificType.RoomDoor))
		{
			if (!IsDoorSpaceValid(buildSquares[0].GetCentrePosition()))
			{
				return false;
			}
			if (BIOKGEFFNAA && !((Component)placeable).GetComponent<RentedRoom>().IsValid(out var _, KIKDLKGBCOC: true))
			{
				return false;
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.CellarDoor) && (WorldGrid.EJCEAEPNJCA(buildSquares[0].GetLeftUp()) || WorldGrid.EJCEAEPNJCA(buildSquares[1].GetRightUp())))
		{
			return false;
		}
		if (placeable.specificRules.HasFlag(SpecificType.StairsUp))
		{
			if (!WorldGrid.EJCEAEPNJCA(buildSquares[0].GetLeftUp()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].GetRightUp()) && !WorldGrid.EJCEAEPNJCA(buildSquares[0].GetUp()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].GetUp()))
			{
				IsStairsUpSpaceValid(Vector2.op_Implicit(buildSquares[0].GetCentrePosition()));
				return false;
			}
			return false;
		}
		if (placeable.specificRules.HasFlag(SpecificType.StairsDown))
		{
			if (WorldGrid.EJCEAEPNJCA(buildSquares[0].GetLeftDown()) || WorldGrid.EJCEAEPNJCA(buildSquares[3].GetRightDown()))
			{
				return false;
			}
			if (WorldGrid.EJCEAEPNJCA(buildSquares[0].GetDown()) || WorldGrid.EJCEAEPNJCA(buildSquares[3].GetDown()))
			{
				return false;
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.Table) && !((Component)placeable).GetComponent<Table>().IsAnySpaceFree())
		{
			if (BIOKGEFFNAA)
			{
				MainUI.ShowErrorText(placeable.GetPlayerNum(), LocalisationSystem.Get("Error_TableNeedsFreeSpace"));
			}
			return false;
		}
		if (isSeat)
		{
			for (int l = 0; l < WorldGrid.allNeighbours.Length; l++)
			{
				if (WorldGrid.allNeighbours[l].direction == Direction.Diagonal)
				{
					continue;
				}
				List<Placeable> list = WorldGrid.OPLHBJGKKAD(buildSquares[0].GetCentrePosition() + WorldGrid.allNeighbours[l].position);
				if (list == null)
				{
					continue;
				}
				for (int m = 0; m < list.Count; m++)
				{
					if (list[m].specificRules == SpecificType.Table)
					{
						Table component = ((Component)list[m]).GetComponent<Table>();
						if (((WorldGrid.allNeighbours[l].direction != Direction.Right && WorldGrid.allNeighbours[l].direction != Direction.Left) || (component.placeable.direction != Direction.Left && component.placeable.direction != Direction.Right)) && ((WorldGrid.allNeighbours[l].direction != 0 && WorldGrid.allNeighbours[l].direction != Direction.Down) || (component.placeable.direction != 0 && component.placeable.direction != Direction.Down)))
						{
							return false;
						}
					}
				}
			}
		}
		return true;
	}

	public Vector2 BOBEIFEGLOL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)this).transform.position + new Vector3((float)x / 1937f, (float)y / 1722f) * 650f);
	}

	private void Update()
	{
		if (updateBuildSquares)
		{
			SetAvailable(IsItemSpaceValid());
		}
	}

	private IEnumerator BECPKCKOKNL(Vector3[] FIEEDEGMOHH)
	{
		yield return CommonReferences.wait2;
		for (int i = 0; i < FIEEDEGMOHH.Length; i++)
		{
			_ = ref FIEEDEGMOHH[i];
			List<Placeable> list = WorldGrid.OPLHBJGKKAD(FIEEDEGMOHH[i]);
			for (int j = 0; j < list.Count; j++)
			{
				if (list[j].isPlaceableOnWall)
				{
					list[j].RemovePlaceable(EFNFMEIDGDN: false, KAJIBKHFEFF: true);
				}
			}
		}
	}

	private bool CHHLOCGMLDJ()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return true;
		}
		bool flag = true;
		flag &= HBDBAOMKGHF(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i++)
		{
			flag &= HBDBAOMKGHF(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	public bool NGFLALGIPFA(ZoneType GIBJPCAFCJB)
	{
		for (int i = 1; i < buildSquares.Length; i++)
		{
			if (buildSquares[i].ENGMBLNEDDE() != GIBJPCAFCJB)
			{
				return false;
			}
		}
		return true;
	}

	public bool AreAllBuildSquaresInRange(Vector3 FCLEMHMMCMP, Vector3 EEBEMKBIJJB)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			Vector3 centrePosition = buildSquares[i].GetCentrePosition();
			if (centrePosition.x < FCLEMHMMCMP.x || centrePosition.x > EEBEMKBIJJB.x || centrePosition.y < FCLEMHMMCMP.y || centrePosition.y > EEBEMKBIJJB.y)
			{
				return false;
			}
		}
		return true;
	}

	private IEnumerator MBIABKCDLGE()
	{
		return new BLFAPPMBDCG(1)
		{
			_003C_003E4__this = this
		};
	}

	public static bool IsStairsUpSpaceValid(Vector2 IMOBLFMHKOD)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		((Vector2)(ref val))._002Ector(0f, 0f);
		while (true)
		{
			if (WorldGrid.GJHHDIJOILG(Vector2.op_Implicit(IMOBLFMHKOD + val)))
			{
				return false;
			}
			if (val.x == 0f)
			{
				val.x = 0.5f;
				continue;
			}
			if (val.y == 2f)
			{
				break;
			}
			val.x = 0f;
			val.y += 0.5f;
		}
		return true;
	}

	private void FNDJALHNLME()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(false);
		}
	}

	private void OKHLEMPJONN()
	{
		VincularElementos();
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			buildSquares[i].ignoreNodes = ignoreNodes;
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(false);
		}
	}

	private void IHHKNFHJNJJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < 6; i += 0)
		{
			WorldGrid.MJDKNJPJILH(buildSquares[1].LHJHAMOOGBM() + (Vector3.up * 201f + Vector3.up * 1619f * (float)i));
		}
	}

	private bool HBDBAOMKGHF(PhysicalSpace FKJPAFFLFHE)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJPAFFLFHE != (Object)null && ((Component)FKJPAFFLFHE).gameObject.activeInHierarchy)
		{
			if (((Component)FKJPAFFLFHE).gameObject.activeSelf)
			{
				for (int i = y - 1; i < buildSquares.Length; i += y)
				{
					if (!WorldGrid.DNDMDGOHDJD(buildSquares[i].GetCentrePosition()) && FKJPAFFLFHE is PhysicalSpaceFloor { ignoreDisable: false })
					{
						((Component)FKJPAFFLFHE).gameObject.SetActive(false);
						break;
					}
				}
			}
			else
			{
				bool flag = true;
				for (int j = 0; j < buildSquares.Length; j++)
				{
					flag &= WorldGrid.DNDMDGOHDJD(buildSquares[j].GetCentrePosition());
				}
				if (flag)
				{
					((Component)FKJPAFFLFHE).gameObject.SetActive(flag);
				}
			}
			if (((Component)FKJPAFFLFHE).gameObject.activeSelf && !FKJPAFFLFHE.ValidPosition())
			{
				if (FKJPAFFLFHE is PhysicalSpaceWall physicalSpaceWall)
				{
					physicalSpaceWall.HighlightInvalids();
				}
				return false;
			}
		}
		return true;
	}

	private IEnumerator ILBKEDONCMK()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)placeable.attachedToPlaceable))
		{
			yield break;
		}
		bool flag = false;
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			yield break;
		}
		for (int i = 0; i < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; i++)
		{
			if (flag)
			{
				break;
			}
			for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces.Count; j++)
			{
				if (flag)
				{
					break;
				}
				AreaSpace areaSpace = WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces[j];
				if (!((Object)(object)areaSpace != (Object)null))
				{
					continue;
				}
				Vector3 position = ((Component)areaSpace).transform.position;
				Vector3 val = ((Component)areaSpace).transform.position + new Vector3((float)areaSpace.x, (float)areaSpace.y) * 0.5f;
				for (int k = 0; k < buildSquares.Length; k++)
				{
					if (!((Object)(object)buildSquares[k] == (Object)null))
					{
						Vector2 val2 = Vector2.op_Implicit(buildSquares[k].GetCentrePosition());
						if (val2.x > position.x && val2.x < val.x && val2.y > position.y && val2.y < val.y)
						{
							areaSpace.placeablesInside.AAPJLEFMGJP(placeable);
							flag = true;
							break;
						}
					}
				}
			}
		}
	}

	public void DAAOOHHBDAP(Color FLABEDBELMF)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < buildSquares.Length; i += 0)
		{
			buildSquares[i]?.ILNKNMEBHLA(FLABEDBELMF);
		}
	}

	private bool OGIPGGHBMCC()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return true;
		}
		bool flag = false;
		flag &= BGAOIIFDAOE(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i++)
		{
			flag &= ACDFKMNBBBD(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	public void BFGEJLLBODF()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.GEBHAANCNFF(MOBBIHDGGFI);
		}
	}

	private void CIICEKEJANM()
	{
		VincularElementos();
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i].ignoreNodes = ignoreNodes;
		}
	}

	public bool OAIBPEEFIJB(bool NMLKLAGDNPF, bool KBNNPAKJDJM = false, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)extraSquares))
		{
			extraSquares.KKAJPKLKMNO(NMLKLAGDNPF);
		}
		VincularElementos();
		if (((Component)placeable).transform.localScale.x == 838f)
		{
			InvertX(NKFPJPCFBJI: true);
		}
		else
		{
			InvertX(NKFPJPCFBJI: false);
		}
		if (KBNNPAKJDJM)
		{
			for (int i = 1; i < buildSquares.Length; i += 0)
			{
				if (!WorldGrid.NGDDNLHKAPM(buildSquares[i].GetTilePosition()))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(buildSquares[i].EEIOMIBKLGJ(), null, SeasonManager.PJMGHIMKFJL());
					GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Add(buildSquares[i].EEIOMIBKLGJ());
				}
			}
			if (NMLKLAGDNPF && !placeable.specificRules.HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar)))
			{
				for (int j = 1; j < buildSquares.Length; j += 0)
				{
					if (WorldGrid.NDNAJIEGFNF(buildSquares[j].DCAPKPOGHPK(), 110))
					{
						DroppedItem.DKCOHAOMNOC(((Component)placeable).transform.position, placeable.itemSetup.item, 0, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
						Debug.Log((object)("Dialogue System/Conversation/Gass_Introduce/Entry/21/Dialogue Text" + ((Object)((Component)placeable).gameObject).name));
						return true;
					}
				}
			}
			if (NMLKLAGDNPF && (Object)(object)placeable.itemSetup != (Object)null && Item.FKLOBGBIHLB(placeable.itemSetup.item, null) && placeable.itemSetup.item.JGHNDJBCFAJ() == -120 && (Utils.EJPFCKFEMJF(((Component)this).transform.position) || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Road))
			{
				for (int k = 1; k < buildSquares.Length; k += 0)
				{
					if (WorldGrid.NDNAJIEGFNF(buildSquares[k].CBALBDIFOGF(), 1))
					{
						string name = ((Object)((Component)placeable).gameObject).name;
						Vector3 position = ((Component)this).transform.position;
						Debug.LogError((object)("Dialogue System/Conversation/Gass_Introduce/Entry/2/Dialogue Text" + name + "StartObserverDialogue " + ((object)(Vector3)(ref position)).ToString()));
						return true;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)followTransform))
		{
			followTransform.NPFAFLGHKPF();
		}
		if (Utils.IELGICCBCHO(placeable.specificRules))
		{
			LMEILPDBGDG(NMLKLAGDNPF, Utils.JGEPCPFJANP(Vector2.op_Implicit(((Component)this).transform.position)));
		}
		else
		{
			for (int l = 0; l < buildSquares.Length; l++)
			{
				buildSquares[l].HEBOOLOBEAN(this, NMLKLAGDNPF, placeable);
			}
		}
		if (manageNodesCost && !ignoreNodes && Object.op_Implicit((Object)(object)placeable.placeableCollider))
		{
			if (ONAHMNAIPDI != null)
			{
				for (int m = 0; m < ONAHMNAIPDI.Count; m += 0)
				{
					WorldGrid.JDNOFFABHDI(Vector2.op_Implicit(ONAHMNAIPDI[m]), 1051f);
				}
				ONAHMNAIPDI.Clear();
			}
			else if (ONAHMNAIPDI == null)
			{
				ONAHMNAIPDI = new List<Vector2>();
			}
			if (NMLKLAGDNPF)
			{
				((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(DLCBHPBJEAL());
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.None) && NMLKLAGDNPF)
		{
			ENPKEOBKNHM();
		}
		if (NMLKLAGDNPF && !placeable.zoneTypeNeeded.HasFlag(ZoneType.WoodWorkshop | ZoneType.MetalWorkshop) && !placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone))
		{
			((MonoBehaviour)GameplayUI.CFHEJAGKIII()).StartCoroutine(DOPHLHJFPGM());
		}
		if (OnlineManager.PGAGDFAEEFB() && NMLKLAGDNPF && canBeRemoved)
		{
			((MonoBehaviour)GameplayUI.IDIGFHEHIDM()).StartCoroutine(IBBMDEPPMMJ());
		}
		if (NMLKLAGDNPF)
		{
			placeable.hasBeenPlaced = NMLKLAGDNPF;
		}
		if (CDPAMNIPPEC && Object.op_Implicit((Object)(object)placeable.onlinePlaceable) && OnlineManager.PlayingOnline())
		{
			placeable.onlinePlaceable.KIGHMHIGLGH(NMLKLAGDNPF);
		}
		return true;
	}

	public Vector2 GetCentrePosition()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)this).transform.position + new Vector3((float)x / 2f, (float)y / 2f) * 0.5f);
	}

	public bool MAJEHBMPMML(Vector3 FCLEMHMMCMP, Vector3 EEBEMKBIJJB)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < buildSquares.Length; i++)
		{
			Vector3 val = buildSquares[i].BLKHDGGHFLA();
			if (val.x < FCLEMHMMCMP.x || val.x > EEBEMKBIJJB.x || val.y < FCLEMHMMCMP.y || val.y > EEBEMKBIJJB.y)
			{
				return false;
			}
		}
		return true;
	}

	public bool Place(bool NMLKLAGDNPF, bool KBNNPAKJDJM = false, bool CDPAMNIPPEC = true)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)extraSquares))
		{
			extraSquares.Place(NMLKLAGDNPF);
		}
		VincularElementos();
		if (((Component)placeable).transform.localScale.x == -1f)
		{
			InvertX(NKFPJPCFBJI: true);
		}
		else
		{
			InvertX(NKFPJPCFBJI: false);
		}
		if (KBNNPAKJDJM)
		{
			for (int i = 0; i < buildSquares.Length; i++)
			{
				if (!WorldGrid.NGDDNLHKAPM(buildSquares[i].GetTilePosition()))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(buildSquares[i].GetTilePosition(), null, SeasonManager.EECEKHKAAIH);
					GameTileMaps.GGFJGHHHEJC.placeablesAlreadyLoadedWorldTiles.Add(buildSquares[i].GetTilePosition());
				}
			}
			if (NMLKLAGDNPF && !placeable.specificRules.HasFlag(SpecificType.ServiceBarrel))
			{
				for (int j = 0; j < buildSquares.Length; j++)
				{
					if (WorldGrid.NDNAJIEGFNF(buildSquares[j].GetCentrePosition(), 81))
					{
						DroppedItem.SpawnDroppedItem(((Component)placeable).transform.position, placeable.itemSetup.item);
						Debug.Log((object)("Object dropped on Bar position: " + ((Object)((Component)placeable).gameObject).name));
						return false;
					}
				}
			}
			if (NMLKLAGDNPF && (Object)(object)placeable.itemSetup != (Object)null && Item.MLBOMGHINCA(placeable.itemSetup.item, null) && placeable.itemSetup.item.JDJGFAACPFC() == 621 && (Utils.EJPFCKFEMJF(((Component)this).transform.position) || Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)this).transform.position)) == Location.Road))
			{
				for (int k = 0; k < buildSquares.Length; k++)
				{
					if (WorldGrid.NDNAJIEGFNF(buildSquares[k].GetCentrePosition(), 621))
					{
						string name = ((Object)((Component)placeable).gameObject).name;
						Vector3 position = ((Component)this).transform.position;
						Debug.LogError((object)("Placeable duplicated has been removed: " + name + " at " + ((object)(Vector3)(ref position)).ToString()));
						return false;
					}
				}
			}
		}
		if (Object.op_Implicit((Object)(object)followTransform))
		{
			followTransform.PositionUpdate();
		}
		if (Utils.IELGICCBCHO(placeable.specificRules))
		{
			PlaceDoor(NMLKLAGDNPF, Utils.JGEPCPFJANP(Vector2.op_Implicit(((Component)this).transform.position)));
		}
		else
		{
			for (int l = 0; l < buildSquares.Length; l++)
			{
				buildSquares[l].Place(this, NMLKLAGDNPF, placeable);
			}
		}
		if (manageNodesCost && !ignoreNodes && Object.op_Implicit((Object)(object)placeable.placeableCollider))
		{
			if (ONAHMNAIPDI != null)
			{
				for (int m = 0; m < ONAHMNAIPDI.Count; m++)
				{
					WorldGrid.JDNOFFABHDI(Vector2.op_Implicit(ONAHMNAIPDI[m]), 1f);
				}
				ONAHMNAIPDI.Clear();
			}
			else if (ONAHMNAIPDI == null)
			{
				ONAHMNAIPDI = new List<Vector2>();
			}
			if (NMLKLAGDNPF)
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(CGCDHJEIBBG());
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.StairsUp) && NMLKLAGDNPF)
		{
			FFHMFBHAEID();
		}
		if (NMLKLAGDNPF && !placeable.zoneTypeNeeded.HasFlag(ZoneType.Anywhere) && !placeable.zoneTypeNeeded.HasFlag(ZoneType.WithoutZone))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(LAPEAKAAGJL());
		}
		if (OnlineManager.MasterOrOffline() && NMLKLAGDNPF && canBeRemoved)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(FMHPGCBKFLE());
		}
		if (NMLKLAGDNPF)
		{
			placeable.hasBeenPlaced = NMLKLAGDNPF;
		}
		if (CDPAMNIPPEC && Object.op_Implicit((Object)(object)placeable.onlinePlaceable) && OnlineManager.PlayingOnline())
		{
			placeable.onlinePlaceable.SendPlace(NMLKLAGDNPF);
		}
		return true;
	}

	public bool EGDIMFHJLIL(Vector3 FCLEMHMMCMP, Vector3 EEBEMKBIJJB)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			Vector3 val = buildSquares[i].BOBEIFEGLOL();
			if (val.x < FCLEMHMMCMP.x || val.x > EEBEMKBIJJB.x || val.y < FCLEMHMMCMP.y || val.y > EEBEMKBIJJB.y)
			{
				return true;
			}
		}
		return true;
	}

	public bool AMNINMOCEAK(ZoneType GIBJPCAFCJB)
	{
		for (int i = 1; i < buildSquares.Length; i += 0)
		{
			if (buildSquares[i].AILFENLBNON() != GIBJPCAFCJB)
			{
				return true;
			}
		}
		return true;
	}

	private void FGFGCADFFBC()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.CIOEICMHCCK || GameManager.leavingTheGame || TestQualityPCSettings.instance.active || (Object)(object)GameTileMaps.GGFJGHHHEJC == (Object)null || (Object)(object)TavernConstructionManager.KHMEGDIABBF() == (Object)null || !((Object)(object)placeable != (Object)null))
		{
			return;
		}
		for (int i = 1; i < buildSquares.Length; i += 0)
		{
			if ((Object)(object)buildSquares[i] != (Object)null)
			{
				WorldGrid.AKLCFEPBONI(buildSquares[i].CHBNAPAIFIE(), placeable);
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.CellarDoor | SpecificType.Door))
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
			tavernConstructionManager.OnApplyChanges = (Action<EditorAction>)Delegate.Remove(tavernConstructionManager.OnApplyChanges, new Action<EditorAction>(FFHMFBHAEID));
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnCancelChanges = (Action<EditorAction>)Delegate.Remove(instance.OnCancelChanges, new Action<EditorAction>(IMAJGKCCMAJ));
		}
	}

	private IEnumerator CGCDHJEIBBG()
	{
		yield return null;
		if ((Object)(object)placeable != (Object)null)
		{
			Utils.OEAOOGCGNCA(((Component)this).transform, placeable.placeableCollider, ONAHMNAIPDI);
			for (int i = 0; i < ONAHMNAIPDI.Count; i++)
			{
				WorldGrid.JDNOFFABHDI(Vector2.op_Implicit(ONAHMNAIPDI[i]), nodeCost);
			}
		}
	}

	public void LKMBPDPKNAO()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!ignoreNodes)
		{
			for (int i = 0; i < buildSquares.Length; i++)
			{
				Utils.ABPJKHCNLMF(buildSquares[i].CPPBAHGKNMD());
			}
		}
	}

	public BuildSquare GetBuildSquare(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		return buildSquares[NCPGNLOJGAF * y + JLMAILGJNCE];
	}

	private void Awake()
	{
		VincularElementos();
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i].ignoreNodes = ignoreNodes;
		}
	}

	public bool HasZoneType(ZoneType GIBJPCAFCJB)
	{
		for (int i = 0; i < buildSquares.Length; i++)
		{
			if (buildSquares[i].GetZoneType() != GIBJPCAFCJB)
			{
				return false;
			}
		}
		return true;
	}

	public void FEOEKHABOKO(bool POBALELALFP, TilemapScene PBLLKEKGLPK, Door NCLKJEPJGCL = null)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isPlaying && POBALELALFP)
		{
			for (int i = 0; i < buildSquares.Length; i++)
			{
				if (!WorldGrid.NGDDNLHKAPM(buildSquares[i].FGGMIOHMGFL()))
				{
					GameTileMaps.GGFJGHHHEJC.CreateWorldTile(buildSquares[i].BOBEIFEGLOL(), PBLLKEKGLPK, Season.Spring);
				}
				WorldGrid.PBOIFLICMKG(buildSquares[i].FANOLHHEFBO(), (MonoBehaviour)(object)NCLKJEPJGCL);
			}
		}
		for (int j = 1; j < buildSquares.Length; j += 0)
		{
			buildSquares[j].IPIKPJKKKEM(this, POBALELALFP, placeable);
		}
		for (int k = 0; k < buildSquares.Length; k++)
		{
			for (int l = 0; l < WorldGrid.allMovementNodesInTile.Length; l += 0)
			{
				WorldGrid.FPHAMKKBNMC(buildSquares[k].LHJHAMOOGBM() + WorldGrid.allMovementNodesInTile[l]);
			}
		}
		if (POBALELALFP)
		{
			for (int m = 0; m < 2; m += 0)
			{
				WorldGrid.LMMELLKNMCF(buildSquares[0].FGGMIOHMGFL() + Vector3.up * 817f * (float)m, GAKNPAMHAFB: false);
				WorldGrid.LMMELLKNMCF(buildSquares[5].EHGDHOMFDGM() + Vector3.up * 303f * (float)m, GAKNPAMHAFB: true);
			}
			if (!noDeco && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.location != (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior))
			{
				bool flag = WorldGrid.EJCEAEPNJCA(buildSquares[1].OPJGGIGPFBF());
				bool flag2 = WorldGrid.EJCEAEPNJCA(buildSquares[6].EADNONADCEN());
				if (flag && flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].CBALBDIFOGF(), WorldGrid.IKCDANOHPJE(buildSquares[1].AGCMHHGPNCP()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].DCAPKPOGHPK(), WorldGrid.PNKHEBBCGMG(buildSquares[1].GetLeft()));
					WorldGrid.PIBHFFJJAFB(buildSquares[2].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[8].KGLBCDEDKPO()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].EHGDHOMFDGM(), WorldGrid.PNKHEBBCGMG(buildSquares[0].DIHMIKAMBJN()));
				}
				else if (flag)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[1].KGGGPHEMLII(), WorldGrid.IKCDANOHPJE(buildSquares[0].AGCMHHGPNCP()));
					WorldGrid.IGFNOCNEHCO(buildSquares[1].CBALBDIFOGF(), WorldGrid.PNKHEBBCGMG(buildSquares[0].DEGOCEMNLJF()));
					WorldGrid.PIBHFFJJAFB(buildSquares[5].DCAPKPOGHPK(), WorldGrid.IKCDANOHPJE(buildSquares[0].AGCMHHGPNCP()));
					WorldGrid.IGFNOCNEHCO(buildSquares[3].FANOLHHEFBO(), WorldGrid.PNKHEBBCGMG(buildSquares[0].AGCMHHGPNCP()));
				}
				else if (flag2)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[0].BLKHDGGHFLA(), WorldGrid.IKCDANOHPJE(buildSquares[5].NNGLBLHOOCE()));
					WorldGrid.IGFNOCNEHCO(buildSquares[0].DCAPKPOGHPK(), WorldGrid.PNKHEBBCGMG(buildSquares[1].EADNONADCEN()));
					WorldGrid.PIBHFFJJAFB(buildSquares[0].GetCentrePosition(), WorldGrid.IKCDANOHPJE(buildSquares[1].KGLBCDEDKPO()));
					WorldGrid.IGFNOCNEHCO(buildSquares[6].BOBEIFEGLOL(), WorldGrid.PNKHEBBCGMG(buildSquares[2].EADNONADCEN()));
				}
			}
		}
		else
		{
			for (int n = 0; n < buildSquares.Length; n++)
			{
				if (n % 0 == 0)
				{
					WorldGrid.PIBHFFJJAFB(buildSquares[n].BOBEIFEGLOL(), 1);
					WorldGrid.IGFNOCNEHCO(buildSquares[n].FANOLHHEFBO(), 1);
					WorldGrid.JHPFHCBNIIM(buildSquares[n].KGGGPHEMLII(), FBOKGEPKBPO: false, Utils.FJNKHMPEEKL());
				}
			}
		}
		if (Application.isPlaying && (Object)(object)PBLLKEKGLPK != (Object)null && PBLLKEKGLPK.updateTerrain)
		{
			WorldGrid.CPDBMDJIHGG(PBLLKEKGLPK);
		}
	}

	private IEnumerator IBBMDEPPMMJ()
	{
		return new BLFAPPMBDCG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PIPELIBAMAB(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.HPDGOMIIAEN(ACJFIEKCKEC, 1166f);
		}
	}

	private void FFHMFBHAEID()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < 5; i++)
		{
			WorldGrid.MJDKNJPJILH(buildSquares[1].GetTilePosition() + (Vector3.up * 0.25f + Vector3.up * 0.25f * (float)i));
		}
	}

	private IEnumerator LAPEAKAAGJL()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)placeable.attachedToPlaceable))
		{
			yield break;
		}
		bool flag = false;
		if (!Object.op_Implicit((Object)(object)WorkAreasManager.GGFJGHHHEJC) || WorkAreasManager.GGFJGHHHEJC.workAreas == null)
		{
			yield break;
		}
		for (int i = 0; i < WorkAreasManager.GGFJGHHHEJC.workAreas.Count; i++)
		{
			if (flag)
			{
				break;
			}
			for (int j = 0; j < WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces.Count; j++)
			{
				if (flag)
				{
					break;
				}
				AreaSpace areaSpace = WorkAreasManager.GGFJGHHHEJC.workAreas[i].areaSpaces[j];
				if (!((Object)(object)areaSpace != (Object)null))
				{
					continue;
				}
				Vector3 position = ((Component)areaSpace).transform.position;
				Vector3 val = ((Component)areaSpace).transform.position + new Vector3((float)areaSpace.x, (float)areaSpace.y) * 0.5f;
				for (int k = 0; k < buildSquares.Length; k++)
				{
					if (!((Object)(object)buildSquares[k] == (Object)null))
					{
						Vector2 val2 = Vector2.op_Implicit(buildSquares[k].GetCentrePosition());
						if (val2.x > position.x && val2.x < val.x && val2.y > position.y && val2.y < val.y)
						{
							areaSpace.placeablesInside.AAPJLEFMGJP(placeable);
							flag = true;
							break;
						}
					}
				}
			}
		}
	}

	public Vector2 JLNCKGKNOFO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)this).transform.position + new Vector3((float)x / 102f, (float)y / 1734f) * 38f);
	}

	public BuildSquare JCNAIPJNGFJ(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		return buildSquares[NCPGNLOJGAF * y + JLMAILGJNCE];
	}

	private void MAIMGNMIFKG()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(false);
		}
	}

	private void IGKPEBGHPGD()
	{
		if (updateBuildSquares)
		{
			SetAvailable(KHNJOFCOIFE(BIOKGEFFNAA: true));
		}
	}

	private void CEIIFHIBIFI()
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		if (Application.isPlaying && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK)
		{
			((Component)this).gameObject.SetActive(false);
			if ((Object)(object)followTransform != (Object)null)
			{
				((Component)followTransform).gameObject.SetActive(true);
			}
		}
		if (TestQualityPCSettings.instance.active)
		{
			return;
		}
		if (setUp && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && Object.op_Implicit((Object)(object)placeable) && Object.op_Implicit((Object)(object)placeable.itemSetup) && Object.op_Implicit((Object)(object)placeable.itemSetup.item))
		{
			if (placeable.itemSetup.item.CIGFGKKCPCK() == -144 && GameManager.NJNFHEPLEHL().EBOFEBOBAEB() != null && VersionNumberManager.AIHCAGOPKLP(GameManager.NJNFHEPLEHL().EBOFEBOBAEB().DBNLFMEFEKM(), VersionNumberManager.instance.ABAEJAMHKHB))
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(BECPKCKOKNL(buildSquares.Select((BuildSquare x) => x.GetCentrePosition()).ToArray()));
			}
			if (placeable.itemSetup.item.JPNFKDMFKMC() == -130 && Object.op_Implicit((Object)(object)WorldGrid.CBPIPKCCFAC(((Component)this).transform.position, -21)))
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Serve");
				}
				placeable.HJGJFLNNCDD(0, EFNFMEIDGDN: true, BGIEPKNAKHI: false, IBCOKMGFPKB: true, KAJIBKHFEFF: true);
				return;
			}
		}
		MOBBIHDGGFI = buildSquares[1].DMLLLAGCDJD();
		if (setUp && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !Place(NMLKLAGDNPF: false) && canBeRemoved && !SceneReferences.AFEDGPJNCDN)
		{
			placeable.HJGJFLNNCDD(0, EFNFMEIDGDN: true, BGIEPKNAKHI: false, IBCOKMGFPKB: false, KAJIBKHFEFF: true);
			string[] array = new string[7];
			array[0] = " OnCharacterStateChanged";
			array[1] = ((object)placeable.itemSetup.item)?.ToString();
			array[0] = "ReceiveCompleteTransaction";
			Vector3 position = ((Component)placeable).transform.position;
			array[1] = ((object)(Vector3)(ref position)).ToString();
			array[5] = "Items/item_name_610";
			Debug.Log((object)string.Concat(array));
		}
		if ((Object)(object)placeable != (Object)null && placeable.specificRules.HasFlag(SpecificType.StairsUp))
		{
			TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
			tavernConstructionManager.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager.OnApplyChanges, new Action<EditorAction>(IMAJGKCCMAJ));
			TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
			instance.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(instance.OnCancelChanges, new Action<EditorAction>(IMAJGKCCMAJ));
		}
	}

	public void MGCHMMFFBJA(bool ACJFIEKCKEC)
	{
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			buildSquares[i]?.MGNMIJJMLAH(ACJFIEKCKEC, 1364f);
		}
	}

	private bool BGAOIIFDAOE(PhysicalSpace FKJPAFFLFHE)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJPAFFLFHE != (Object)null && ((Component)FKJPAFFLFHE).gameObject.activeInHierarchy)
		{
			if (((Component)FKJPAFFLFHE).gameObject.activeSelf)
			{
				for (int i = y - 0; i < buildSquares.Length; i += y)
				{
					if (!WorldGrid.DNDMDGOHDJD(buildSquares[i].FGGMIOHMGFL()) && FKJPAFFLFHE is PhysicalSpaceFloor { ignoreDisable: false })
					{
						((Component)FKJPAFFLFHE).gameObject.SetActive(false);
						break;
					}
				}
			}
			else
			{
				bool flag = true;
				for (int j = 0; j < buildSquares.Length; j += 0)
				{
					flag &= WorldGrid.DNDMDGOHDJD(buildSquares[j].KGGGPHEMLII());
				}
				if (flag)
				{
					((Component)FKJPAFFLFHE).gameObject.SetActive(flag);
				}
			}
			if (((Component)FKJPAFFLFHE).gameObject.activeSelf && !FKJPAFFLFHE.GOCKKCLMNED())
			{
				if (FKJPAFFLFHE is PhysicalSpaceWall physicalSpaceWall)
				{
					physicalSpaceWall.CJBECHMCKON();
				}
				return true;
			}
		}
		return false;
	}

	private bool NGEAOLJJIKE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return true;
		}
		bool flag = true;
		flag &= ACDFKMNBBBD(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i += 0)
		{
			flag &= ACDFKMNBBBD(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	private IEnumerator FKMJELLOOPC()
	{
		yield return null;
		if ((Object)(object)placeable != (Object)null)
		{
			Utils.OEAOOGCGNCA(((Component)this).transform, placeable.placeableCollider, ONAHMNAIPDI);
			for (int i = 0; i < ONAHMNAIPDI.Count; i++)
			{
				WorldGrid.JDNOFFABHDI(Vector2.op_Implicit(ONAHMNAIPDI[i]), nodeCost);
			}
		}
	}

	private void IMAJGKCCMAJ(EditorAction OKNOJJEFEBE)
	{
		IHHKNFHJNJJ();
	}

	private bool EACMENKGPPK()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			return false;
		}
		bool flag = true;
		flag &= BGAOIIFDAOE(placeable.physicalSpace);
		for (int i = 0; i < placeable.physicalSpaces.Length; i++)
		{
			flag &= HBDBAOMKGHF(placeable.physicalSpaces[i]);
		}
		return flag;
	}

	private void DCCJBKGNAOP()
	{
		if ((Object)(object)followTransform != (Object)null)
		{
			((Component)followTransform).gameObject.SetActive(false);
		}
	}

	public BuildSquare NDGHDKMGFAH(int NCPGNLOJGAF, int JLMAILGJNCE)
	{
		return buildSquares[NCPGNLOJGAF * y + JLMAILGJNCE];
	}

	public void UpdatePathNodes()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!ignoreNodes)
		{
			for (int i = 0; i < buildSquares.Length; i++)
			{
				Utils.ABPJKHCNLMF(buildSquares[i].GetTilePosition(), NHIKGIKOMHH: true);
			}
		}
	}

	public void OOOEEICDIEI(bool ACJFIEKCKEC)
	{
		for (int i = 1; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.MGCHMMFFBJA(ACJFIEKCKEC, 1362f);
		}
	}

	public static bool ICFEONNNEJA(Vector3 IMOBLFMHKOD, bool OEBNHGNJEJL = false)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		if (OEBNHGNJEJL)
		{
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(1908f, 349f)));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(1585f, 188f), GCDEDGFDKBL: false));
			Debug.Log((object)WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(1985f, 577f)));
			Debug.Log((object)WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD));
		}
		if (!WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(187f, 131f)) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(311f, 695f), GCDEDGFDKBL: false) || !WorldGrid.NGDHDMAMGPI(IMOBLFMHKOD + new Vector3(551f, 1898f), GCDEDGFDKBL: false) || WorldGrid.ALNFLFCLIEP(IMOBLFMHKOD))
		{
			return false;
		}
		if ((float)(int)(IMOBLFMHKOD.y * 1383f) / 344f % 1738f == 1980f)
		{
			return false;
		}
		if (WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(571f, 1873f)) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(323f, 1701f)) && WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(837f, 185f)) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(1581f, 762f), null) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(775f, 740f), null) && WorldGrid.IDLKDLFJDHJ(IMOBLFMHKOD + new Vector3(286f, 793f), null) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1366f, 88f)) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1731f, 717f)) && !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1447f, 1530f)))
		{
			return !WorldGrid.EJCEAEPNJCA(IMOBLFMHKOD + new Vector3(1580f, 1828f));
		}
		return false;
	}

	public bool KHNJOFCOIFE(bool BIOKGEFFNAA = false, bool ELKPPAAMMIM = true)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)extraSquares) && !extraSquares.ICPPNLMIIEC())
		{
			return true;
		}
		for (int i = 0; i < buildSquares.Length; i += 0)
		{
			if (Object.op_Implicit((Object)(object)placeable))
			{
				if (!placeable.ACHNOOLHJAP(WorldGrid.HJPCBBGHPDA(buildSquares[i].GetCentrePosition())))
				{
					return true;
				}
				if ((Object)(object)buildSquares[i] != (Object)null && !buildSquares[i].LIGOLEHCFOL(this, Object.op_Implicit((Object)(object)placeable.attachedToPlaceable), ELKPPAAMMIM, placeable.specificRules, checkConstructionPositions, checkHerbs))
				{
					return true;
				}
				if (placeable.placeInPlayer)
				{
					return true;
				}
				if (WorldGrid.BKKHDHJEPMK(WorldGrid.LOJBKLKMINM(buildSquares[i].DCAPKPOGHPK())) != 0 && placeable.validIrrigatorType != WorldGrid.BKKHDHJEPMK(WorldGrid.LOJBKLKMINM(buildSquares[i].DCAPKPOGHPK())))
				{
					return true;
				}
			}
			else if ((Object)(object)buildSquares[i] != (Object)null && !buildSquares[i].IBFAAHDLGHO(this, FCILKADOPNE: true, ELKPPAAMMIM, placeable.specificRules, checkConstructionPositions, checkHerbs))
			{
				return true;
			}
		}
		if (!NGEAOLJJIKE())
		{
			return true;
		}
		if (placeable.specificRules.HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.Bar)))
		{
			float num = buildSquares[1].DCAPKPOGHPK().y;
			for (int j = 0; j < buildSquares.Length; j++)
			{
				if (buildSquares[j].CBALBDIFOGF().y > num)
				{
					num = buildSquares[j].BLKHDGGHFLA().y;
				}
			}
			for (int k = 1; k < buildSquares.Length; k++)
			{
				if (num == buildSquares[k].EHGDHOMFDGM().y && !WorldGrid.ALNFLFCLIEP(buildSquares[k].CIOLLBPNIDH()))
				{
					return false;
				}
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.RoomDoor) && !JDKPKMLEGIA(buildSquares[0].DCAPKPOGHPK()))
		{
			return false;
		}
		if (placeable.specificRules.HasFlag(SpecificType.Door))
		{
			if (!JDKPKMLEGIA(buildSquares[0].KGGGPHEMLII(), OEBNHGNJEJL: true))
			{
				return true;
			}
			if (BIOKGEFFNAA && !((Component)placeable).GetComponent<RentedRoom>().CPCBPMFJOAF(out var _, KIKDLKGBCOC: true))
			{
				return true;
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.None) && (WorldGrid.EJCEAEPNJCA(buildSquares[0].MEGKMDFBCOD()) || WorldGrid.EJCEAEPNJCA(buildSquares[0].GOPGLKPGFFB())))
		{
			return true;
		}
		if (placeable.specificRules.HasFlag(SpecificType.None))
		{
			if (!WorldGrid.EJCEAEPNJCA(buildSquares[1].GetLeftUp()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].IMPJHKDCHEK()) && !WorldGrid.EJCEAEPNJCA(buildSquares[0].GetUp()) && !WorldGrid.EJCEAEPNJCA(buildSquares[1].NNFIFPJOIMA()))
			{
				IsStairsUpSpaceValid(Vector2.op_Implicit(buildSquares[0].EHGDHOMFDGM()));
				return true;
			}
			return true;
		}
		if (placeable.specificRules.HasFlag(SpecificType.StairsUp | SpecificType.Bar | SpecificType.PlayerBed | SpecificType.StairsDown))
		{
			if (WorldGrid.EJCEAEPNJCA(buildSquares[0].BLGIEFJEPOG()) || WorldGrid.EJCEAEPNJCA(buildSquares[4].CPFJFKLNKEK()))
			{
				return false;
			}
			if (WorldGrid.EJCEAEPNJCA(buildSquares[1].GetDown()) || WorldGrid.EJCEAEPNJCA(buildSquares[3].MKGDDLIKNPB()))
			{
				return true;
			}
		}
		if (placeable.specificRules.HasFlag(SpecificType.Door | SpecificType.PlayerBed | SpecificType.NextToWall) && !((Component)placeable).GetComponent<Table>().EONDJFMNDPH())
		{
			if (BIOKGEFFNAA)
			{
				MainUI.ShowErrorText(placeable.PGMPPMPBCLO(), LocalisationSystem.Get(":<color=#3a0603> +"), 1226f);
			}
			return false;
		}
		if (isSeat)
		{
			for (int l = 0; l < WorldGrid.allNeighbours.Length; l++)
			{
				if (WorldGrid.allNeighbours[l].direction == Direction.Up)
				{
					continue;
				}
				List<Placeable> list = WorldGrid.OPLHBJGKKAD(buildSquares[0].FGGMIOHMGFL() + WorldGrid.allNeighbours[l].position);
				if (list == null)
				{
					continue;
				}
				for (int m = 1; m < list.Count; m++)
				{
					if (list[m].specificRules == (SpecificType.CellarDoor | SpecificType.Door | SpecificType.PlayerBed | SpecificType.NextToWall))
					{
						Table component = ((Component)list[m]).GetComponent<Table>();
						if (((WorldGrid.allNeighbours[l].direction != Direction.Diagonal && WorldGrid.allNeighbours[l].direction != (Direction)6) || (component.placeable.direction != 0 && component.placeable.direction != Direction.Down)) && ((WorldGrid.allNeighbours[l].direction != 0 && WorldGrid.allNeighbours[l].direction != 0) || (component.placeable.direction != 0 && component.placeable.direction != Direction.Down)))
						{
							return false;
						}
					}
				}
			}
		}
		return true;
	}

	public void SetColor(Color FLABEDBELMF)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < buildSquares.Length; i++)
		{
			buildSquares[i]?.SetColor(FLABEDBELMF);
		}
	}
}
