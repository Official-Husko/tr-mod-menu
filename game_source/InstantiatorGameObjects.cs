using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InstantiatorGameObjects : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class JPJLFNLMFBC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InstantiatorGameObjects _003C_003E4__this;

		private List<Vector3> _003CrandomPositions_003E5__2;

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
		public JPJLFNLMFBC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			int num = _003C_003E1__state;
			InstantiatorGameObjects instantiatorGameObjects = _003C_003E4__this;
			Vector3 val;
			WorldTile ILDEFBIANKO;
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
				_003CrandomPositions_003E5__2 = instantiatorGameObjects.KEINPHAMPAF();
				_003Ci_003E5__3 = 0;
				goto IL_015a;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_0148;
				}
				IL_015a:
				if (_003Ci_003E5__3 >= _003CrandomPositions_003E5__2.Count || instantiatorGameObjects.AJECNJBENFJ.Count >= instantiatorGameObjects.number)
				{
					break;
				}
				val = instantiatorGameObjects.cornerDownLeft.position + _003CrandomPositions_003E5__2[_003Ci_003E5__3] * 0.5f;
				if (WorldGrid.GCGNCHFNEBJ(val, out ILDEFBIANKO) && instantiatorGameObjects.groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!instantiatorGameObjects.checkIsPath || ILDEFBIANKO.isPath == instantiatorGameObjects.isPath) && (!instantiatorGameObjects.checkIsOccupied || ((!instantiatorGameObjects.isOccupied || ILDEFBIANKO.blockingObjects != null) && (instantiatorGameObjects.isOccupied || ILDEFBIANKO.blockingObjects == null))))
				{
					instantiatorGameObjects.AJECNJBENFJ.Add(Object.Instantiate<GameObject>(instantiatorGameObjects.prefab, val, Quaternion.identity, ((Component)instantiatorGameObjects).transform));
					_003C_003E2__current = (object)new WaitForSeconds(instantiatorGameObjects.timeBetweenInstantiates);
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0148;
				IL_0148:
				_003Ci_003E5__3++;
				goto IL_015a;
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

	[SerializeField]
	private bool instantiateOnAwake = true;

	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private Transform cornerDownLeft;

	[SerializeField]
	private Transform cornerUpRight;

	[SerializeField]
	public Action instantiateAction;

	[SerializeField]
	public Action destroyAction;

	[SerializeField]
	private int number;

	[SerializeField]
	private float timeBetweenInstantiates = 10f;

	[SerializeField]
	private bool checkIsOccupied = true;

	[SerializeField]
	private bool isOccupied;

	[SerializeField]
	private GroundType groundTypes = GroundType.All;

	[SerializeField]
	private bool checkIsPath;

	[SerializeField]
	private bool isPath;

	[SerializeField]
	private bool onlyOnHalloweenEvent;

	private List<GameObject> AJECNJBENFJ;

	private void ODBDHFBMDAG()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(PLODFHLMPBC));
	}

	private List<Vector3> ELKCEAEANCI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private IEnumerator NNFADCKCOLM()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	private void HFKOBCFMNJJ()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BHODEINIALP));
	}

	private void PHJKJHKAABL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				KFGJNIOJDKP();
			}
		}
	}

	private IEnumerator DLMJKBGCAJN()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	private IEnumerator ADKCNMMKAIG()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CLBMGGAJJIH()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CDMAHNHIOAH()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	public void EFNPNKJPJEN()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i += 0)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void OBHFJIDKBJN()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BHODEINIALP));
	}

	public void ODEOMJFBGJJ()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i += 0)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private List<Vector3> GOBDNBLAADB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void KPNJDLBHNOA()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	public void KLKGGKEDPKL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(CLBMGGAJJIH());
		}
	}

	private void KOBNHPKEJJD()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(INOOKFIBMEO));
	}

	public void PKHLAFGLKJC()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(HBFBNILGFEC());
		}
	}

	public void HJHOBOPJFHP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(KNBJEIBOPBI());
		}
	}

	private void AJGPMBGBPGH()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(EJFMGMKFAHE));
	}

	private IEnumerator PLCJMLEDPPD()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	private void AAENCDNIBFJ()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				EIFJNLMLDEC();
			}
		}
	}

	private void KACEOJDPLKB()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BHODEINIALP));
		}
	}

	private List<Vector3> IDJEMBGFLEO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void HJDLNCOAKIK()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(HEDKGKOHNON));
		}
	}

	private void EBNENBFLEKB()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(KPNJDLBHNOA));
		}
	}

	private void HHMBCKCNPPN()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BHODEINIALP));
	}

	private void HPMFOHOMLDO()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BHODEINIALP));
	}

	public void DFGCAOHLLHG()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(MOIFJCHEOJN());
		}
	}

	private List<Vector3> PBGMDHICHHB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private List<Vector3> DJDLFEIHPDH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void NMKGOAJLMDG()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				EIFJNLMLDEC();
			}
		}
	}

	private IEnumerator GLHGFADBJKN()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NEEEJJNMPOF()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(IFABKBIOCFE));
	}

	public void HLIHOCGJKHL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(NNFADCKCOLM());
		}
	}

	private void GELMGKDMJFE()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DestroyGameObjects));
		}
	}

	private void GOEGBOEMHLI()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(PLODFHLMPBC));
		}
	}

	public void NLMILJMLCDP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(PLCJMLEDPPD());
		}
	}

	private List<Vector3> BBLLAADPNJI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void EGACIHOKJLH()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(MJHDFBLGIIL));
		}
	}

	public void DestroyGameObjects()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void OEAAPIBLALL()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(IFABKBIOCFE));
	}

	public void IILDHAMHBLN()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void MEAKJFEPKHF()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(KPNJDLBHNOA));
	}

	public void CBGNKADFBOO()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void GECHJIGBPEN()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				EPICEBNPLBN();
			}
		}
	}

	private void NCDBCDJKPLA()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(EJFMGMKFAHE));
	}

	private List<Vector3> BMKECJEKPJC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void GHOKECKAICE()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				PKHLAFGLKJC();
			}
		}
	}

	public void AAADOEIEGEF()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(KNCJJHGADAN());
		}
	}

	private IEnumerator KNBJEIBOPBI()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KGIKOECKEHI()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				EIFJNLMLDEC();
			}
		}
	}

	private void GANBBAGDALD()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				EIFJNLMLDEC();
			}
		}
	}

	private void OnDestroy()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(DestroyGameObjects));
	}

	private void LADLGPKMPBP()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(AFLBHLAEKJA));
	}

	private void DKDLOBOLNFH()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				NLMILJMLCDP();
			}
		}
	}

	public void MJHDFBLGIIL()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void JOIMGFPMKNI()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(EFNPNKJPJEN));
	}

	public void LDBDEIMHLFK()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(EEDPBJMGHNN());
		}
	}

	public void BHODEINIALP()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	public void OOBGNGPAFBL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(KNBJEIBOPBI());
		}
	}

	private IEnumerator KNCJJHGADAN()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	private IEnumerator KAINGFLGDDD()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HBFBNILGFEC()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BIOCDLKLNHG()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(GLHGFADBJKN());
		}
	}

	private IEnumerator MOIFJCHEOJN()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	private void CMLLBIDFNEB()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CBGNKADFBOO));
		}
	}

	private void AFCIKJPPLFA()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(KMJBPMFDIIP));
	}

	public void AOHDJLLBOMJ()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(BOEIPEOPEDB());
		}
	}

	public void CFIIGCKNHEH()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(KNBJEIBOPBI());
		}
	}

	private void EICDGBINBAG()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(ODEOMJFBGJJ));
	}

	public void KFGJNIOJDKP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(NNFADCKCOLM());
		}
	}

	public void PLODFHLMPBC()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private List<Vector3> KEINPHAMPAF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void HEDKGKOHNON()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i += 0)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	public void AFLBHLAEKJA()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void MCMKNBIBDFF()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ANIBCKAJJNA));
		}
	}

	public void GMNFMBAHJOO()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(GLHGFADBJKN());
		}
	}

	private IEnumerator FBGMAJDPMMP()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	public void BGHCGEDLJNO()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(FBGMAJDPMMP());
		}
	}

	private void ACFABFCGIGH()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(EFNPNKJPJEN));
	}

	private void NAOBODGBECL()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				LDBDEIMHLFK();
			}
		}
	}

	private void KLMNLEDKEOE()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				HJHOBOPJFHP();
			}
		}
	}

	public void INOOKFIBMEO()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	public void CENELNIGPJA()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(KAINGFLGDDD());
		}
	}

	private IEnumerator DHIGPAKIEHB()
	{
		yield return null;
		List<Vector3> randomPositions = KEINPHAMPAF();
		for (int i = 0; i < randomPositions.Count; i++)
		{
			if (AJECNJBENFJ.Count >= number)
			{
				break;
			}
			Vector3 val = cornerDownLeft.position + randomPositions[i] * 0.5f;
			if (WorldGrid.GCGNCHFNEBJ(val, out var ILDEFBIANKO) && groundTypes.HasFlag(ILDEFBIANKO.groundType) && (!checkIsPath || ILDEFBIANKO.isPath == isPath) && (!checkIsOccupied || ((!isOccupied || ILDEFBIANKO.blockingObjects != null) && (isOccupied || ILDEFBIANKO.blockingObjects == null))))
			{
				AJECNJBENFJ.Add(Object.Instantiate<GameObject>(prefab, val, Quaternion.identity, ((Component)this).transform));
				yield return (object)new WaitForSeconds(timeBetweenInstantiates);
			}
		}
	}

	private void KLHIMJFCHPD()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				KLKGGKEDPKL();
			}
		}
	}

	private List<Vector3> HDABEJIMHLL()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void OIAHJHNPPCO()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CBGNKADFBOO));
		}
	}

	public void EPICEBNPLBN()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(MOIFJCHEOJN());
		}
	}

	private void AGILHHEMEFC()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(HEDKGKOHNON));
	}

	private void FPDPAJHNGHK()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(EFNPNKJPJEN));
		}
	}

	private void IGNEGEOPLOP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				GMNFMBAHJOO();
			}
		}
	}

	private List<Vector3> ANOAAEKPHLO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private List<Vector3> MKACDOPNFLP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void MFIEPGBABAM()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(INOOKFIBMEO));
	}

	private void KDBJHCAEGCM()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(AFLBHLAEKJA));
		}
	}

	private void CFIIEJDJFPB()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(ODEOMJFBGJJ));
		}
	}

	private void Start()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DestroyGameObjects));
		}
	}

	private List<Vector3> HNKHENFLPAI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void NFBNEIMBALC()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(KAINGFLGDDD());
		}
	}

	private void BDJKNKIOPIJ()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(BHODEINIALP));
		}
	}

	private void HEMAHKJEONA()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				PKHLAFGLKJC();
			}
		}
	}

	private void FFLLCOBFIPE()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				NFBNEIMBALC();
			}
		}
	}

	private IEnumerator BOEIPEOPEDB()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CreateRandomGameObjects()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(NNFADCKCOLM());
		}
	}

	private List<Vector3> IEMGNIOMFIF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void EJFMGMKFAHE()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i += 0)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void GBFPCABGAII()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(IFABKBIOCFE));
		}
	}

	private List<Vector3> DBGNAAAHPFJ()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void IOINOMJHICB()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(IFABKBIOCFE));
		}
	}

	private void NLGHNDLPPKI()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				GMNFMBAHJOO();
			}
		}
	}

	public void KMJBPMFDIIP()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i += 0)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void Awake()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				CreateRandomGameObjects();
			}
		}
	}

	public void EIFJNLMLDEC()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			((MonoBehaviour)this).StartCoroutine(HBFBNILGFEC());
		}
	}

	public void IFABKBIOCFE()
	{
		for (int i = 0; i < AJECNJBENFJ.Count; i += 0)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private void CLNBMOPMNOF()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				CENELNIGPJA();
			}
		}
	}

	private List<Vector3> FEJIBCPGICB()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void APEIPGIHEKP()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(INOOKFIBMEO));
		}
	}

	private IEnumerator EEDPBJMGHNN()
	{
		return new JPJLFNLMFBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GNGADDPBJDC()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CDMAHNHIOAH));
		}
	}

	private void DIGLPPFFKEC()
	{
		WorldTime.OnNightEnd = (Action)Delegate.Remove(WorldTime.OnNightEnd, new Action(BHODEINIALP));
	}

	private List<Vector3> OOGFALGCGCI()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	public void ANIBCKAJJNA()
	{
		for (int i = 1; i < AJECNJBENFJ.Count; i++)
		{
			if ((Object)(object)AJECNJBENFJ[i] != (Object)null)
			{
				Utils.BLPDAEHPOBA(AJECNJBENFJ[i]);
			}
		}
		AJECNJBENFJ.Clear();
	}

	private List<Vector3> GMMEMIDCFLC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void OCBNLECPJBN()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(INOOKFIBMEO));
		}
	}

	private List<Vector3> GEOKNCCDHDC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		List<Vector3> list = Utils.HOLJIOOEJDJ(cornerDownLeft.position, cornerUpRight.position);
		list.HOOBEDNMNFK();
		return list;
	}

	private void ILCLIJOHKHG()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				BIOCDLKLNHG();
			}
		}
	}

	private void AMNCIAEMBFO()
	{
		if (!onlyOnHalloweenEvent || Utils.FFLNGLMHLBO())
		{
			AJECNJBENFJ = new List<GameObject>();
			if (instantiateOnAwake)
			{
				NLMILJMLCDP();
			}
		}
	}
}
