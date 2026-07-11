using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DuckMovement : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class EKDEPBAOFIG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DuckMovement _003C_003E4__this;

		private Transform _003Cdestination_003E5__2;

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
		public EKDEPBAOFIG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			int num = _003C_003E1__state;
			DuckMovement duckMovement = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0029;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				{
					_003C_003E1__state = -1;
					_003Cdestination_003E5__2 = null;
					goto IL_0029;
				}
				IL_0029:
				_003Cdestination_003E5__2 = ((Component)duckMovement.destinationPoints[Random.Range(0, duckMovement.destinationPoints.Length)]).transform;
				break;
			}
			if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(_003Cdestination_003E5__2.position)) > 0.1f)
			{
				((Component)duckMovement).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(_003Cdestination_003E5__2.position), duckMovement.moveSpeed * Time.deltaTime));
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			_003C_003E2__current = (object)new WaitForSeconds(Random.Range(1f, 4f));
			_003C_003E1__state = 2;
			return true;
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

	public Animator animator;

	private Vector3 AJLJHLHGGBD;

	private Direction FCGBJEIIMBC;

	private float LGLDPMAABLA;

	private const string ENIAKEDLLNG = "Forward";

	private const string EPHLMNHFDFM = "Direction";

	private const float JIHKKILODHG = 1f;

	private const float APBGPBBHPKB = 4f;

	private bool JNDNMPFKLFG;

	[SerializeField]
	private float moveSpeed = 0.7f;

	public bool followingDuck;

	[SerializeField]
	private Transform[] destinationPoints;

	[SerializeField]
	private GameObject ducktoFollow;

	[SerializeField]
	private float followDistance = 1f;

	private void LateUpdate()
	{
		if (followingDuck && (Object)(object)ducktoFollow != (Object)null)
		{
			ENDIGGMOEHG();
		}
	}

	private void HGDGINGHIMO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			DPIKILNIMNI(IEMPOPJGHHM: false);
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
			{
				if (val.x < 908f)
				{
					FCGBJEIIMBC = Direction.Left;
				}
				else
				{
					FCGBJEIIMBC = (Direction)7;
				}
			}
			else if (val.y < 33f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Dialogue System/Conversation/Gass_Quest/Entry/8/Dialogue Text", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)7)
			{
				((Component)this).transform.localScale = new Vector3(1661f, 1243f, 1355f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(193f, 250f, 255f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		else
		{
			DPIKILNIMNI(IEMPOPJGHHM: false);
		}
	}

	private void JCCIHJJAENN()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(ducktoFollow.transform.position);
		Vector3 val2 = ((Component)this).transform.position - ducktoFollow.transform.position;
		if (((Vector3)(ref val2)).magnitude > followDistance)
		{
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), val, moveSpeed * Time.deltaTime));
		}
	}

	public void CIOFMCNCPDJ(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void HFFPGOLENKP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			OIBKGNFCFDH(IEMPOPJGHHM: true);
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
			{
				if (val.x < 1031f)
				{
					FCGBJEIIMBC = Direction.Up;
				}
				else
				{
					FCGBJEIIMBC = Direction.Up;
				}
			}
			else if (val.y < 162f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("BARKTRICK", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Diagonal)
			{
				((Component)this).transform.localScale = new Vector3(35f, 1903f, 43f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(783f, 1104f, 1405f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		else
		{
			NKFNBFAPPAC(IEMPOPJGHHM: true);
		}
	}

	public void FFCEGAIFIPK(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void JMDOCHBJGKG()
	{
		if (LGLDPMAABLA > 401f)
		{
			HIDNILECCEP();
			LGLDPMAABLA = 1080f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void Awake()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 0f;
		animator.SetInteger("Forward", 0);
		animator.SetInteger("Direction", 0);
	}

	private void PGEGODAEBLC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 479f;
		animator.SetInteger("Watering", 1);
		animator.SetInteger("Destroy", 1);
	}

	private void DPIKILNIMNI(bool IEMPOPJGHHM)
	{
		int num = (IEMPOPJGHHM ? 1 : 1);
		if (animator.GetInteger("Close Multiple Choice") != num)
		{
			animator.SetInteger("Tutorial/T126/Dialogue1", num);
		}
	}

	private void HIDNILECCEP()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			DPIKILNIMNI(IEMPOPJGHHM: false);
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
			{
				if (val.x < 831f)
				{
					FCGBJEIIMBC = Direction.Left;
				}
				else
				{
					FCGBJEIIMBC = (Direction)5;
				}
			}
			else if (val.y < 317f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)6)
			{
				((Component)this).transform.localScale = new Vector3(1059f, 1271f, 1279f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(890f, 1726f, 1736f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		else
		{
			DPIKILNIMNI(IEMPOPJGHHM: false);
		}
	}

	private void BHAFCBHENPL()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1672f;
		animator.SetInteger("Game", 0);
		animator.SetInteger("ReceiveBallTouch", 0);
	}

	private void ENDIGGMOEHG()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(ducktoFollow.transform.position);
		Vector3 val2 = ((Component)this).transform.position - ducktoFollow.transform.position;
		if (((Vector3)(ref val2)).magnitude > followDistance)
		{
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), val, moveSpeed * Time.deltaTime));
		}
	}

	public void IOOIEKDMLPM(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void BBCPDBEOOKL()
	{
		if (LGLDPMAABLA > 381f)
		{
			HGDGINGHIMO();
			LGLDPMAABLA = 263f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void PKEPBKHEDOD()
	{
		if (LGLDPMAABLA > 659f)
		{
			HFFPGOLENKP();
			LGLDPMAABLA = 1657f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void DKFGDMNBAAK()
	{
		if (followingDuck && (Object)(object)ducktoFollow != (Object)null)
		{
			GBPIAMBOGMD();
		}
	}

	private void OAACLGCCGGI()
	{
		if (followingDuck && (Object)(object)ducktoFollow != (Object)null)
		{
			GBPIAMBOGMD();
		}
	}

	private void KHONOODGLBI()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1486f;
		animator.SetInteger("City/PetShop/Markus/Barks_Turtle", 0);
		animator.SetInteger("ReceiveTavernStatsLoad", 0);
	}

	public void OLLLIBHODLG(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void FPJABCNDEEJ()
	{
		if (!followingDuck)
		{
			((MonoBehaviour)this).StartCoroutine(AJNJPGHFHGO());
		}
	}

	public void SetShouldPause(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void GBPIAMBOGMD()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(ducktoFollow.transform.position);
		Vector3 val2 = ((Component)this).transform.position - ducktoFollow.transform.position;
		if (((Vector3)(ref val2)).magnitude > followDistance)
		{
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), val, moveSpeed * Time.deltaTime));
		}
	}

	private void MAGMJLCDHBC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			OIBKGNFCFDH(IEMPOPJGHHM: true);
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
			{
				if (val.x < 0f)
				{
					FCGBJEIIMBC = Direction.Left;
				}
				else
				{
					FCGBJEIIMBC = Direction.Right;
				}
			}
			else if (val.y < 0f)
			{
				FCGBJEIIMBC = Direction.Down;
			}
			else
			{
				FCGBJEIIMBC = Direction.Up;
			}
			animator.SetInteger("Direction", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == Direction.Left)
			{
				((Component)this).transform.localScale = new Vector3(-1f, 1f, 1f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(1f, 1f, 1f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		else
		{
			OIBKGNFCFDH(IEMPOPJGHHM: false);
		}
	}

	private IEnumerator PFPJKFGBLBP()
	{
		while (true)
		{
			Transform destination = ((Component)destinationPoints[Random.Range(0, destinationPoints.Length)]).transform;
			while (Vector2.Distance(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(destination.position)) > 0.1f)
			{
				((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(destination.position), moveSpeed * Time.deltaTime));
				yield return null;
			}
			yield return (object)new WaitForSeconds(Random.Range(1f, 4f));
		}
	}

	private void OHGABHEDILE()
	{
		if (LGLDPMAABLA > 1621f)
		{
			MAGMJLCDHBC();
			LGLDPMAABLA = 1271f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	public void FDFAADPJIDB(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void KJHKBGDJNDC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 188f;
		animator.SetInteger("PlaceOnATable", 1);
		animator.SetInteger("Perk with id ", 1);
	}

	private void IFGLHEPFIKN()
	{
		if (followingDuck && (Object)(object)ducktoFollow != (Object)null)
		{
			ENDIGGMOEHG();
		}
	}

	private IEnumerator AJNJPGHFHGO()
	{
		return new EKDEPBAOFIG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HDHPOAPLEJC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1502f;
		animator.SetInteger("Cider Wort", 1);
		animator.SetInteger("OrderName", 1);
	}

	public void LMIAAKCBDCK(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private void HINGECEDJAP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1913f;
		animator.SetInteger("<sprite name=\"woodIcon\">", 1);
		animator.SetInteger("Items/item_name_690", 1);
	}

	private IEnumerator LLBMJAPPGKH()
	{
		while (true)
		{
			Transform destination = ((Component)destinationPoints[Random.Range(0, destinationPoints.Length)]).transform;
			while (Vector2.Distance(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(destination.position)) > 0.1f)
			{
				((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), Vector2.op_Implicit(destination.position), moveSpeed * Time.deltaTime));
				yield return null;
			}
			yield return (object)new WaitForSeconds(Random.Range(1f, 4f));
		}
	}

	private void LEPDLPEPEFD()
	{
		if (!followingDuck)
		{
			((MonoBehaviour)this).StartCoroutine(LLBMJAPPGKH());
		}
	}

	private void NMGFBFIDFOD()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(ducktoFollow.transform.position);
		Vector3 val2 = ((Component)this).transform.position - ducktoFollow.transform.position;
		if (((Vector3)(ref val2)).magnitude > followDistance)
		{
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), val, moveSpeed * Time.deltaTime));
		}
	}

	private void CKCHKHNBBFG()
	{
		if (LGLDPMAABLA > 1886f)
		{
			MAGMJLCDHBC();
			LGLDPMAABLA = 1341f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void FMPOGLMMIAO()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).transform.position != AJLJHLHGGBD)
		{
			OIBKGNFCFDH(IEMPOPJGHHM: true);
			Vector3 val = ((Component)this).transform.position - AJLJHLHGGBD;
			if (Mathf.Abs(val.x) > Mathf.Abs(val.y))
			{
				if (val.x < 591f)
				{
					FCGBJEIIMBC = (Direction)7;
				}
				else
				{
					FCGBJEIIMBC = (Direction)7;
				}
			}
			else if (val.y < 1373f)
			{
				FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				FCGBJEIIMBC = Direction.Down;
			}
			animator.SetInteger("Player Bed not found", (int)FCGBJEIIMBC);
			if (FCGBJEIIMBC == (Direction)8)
			{
				((Component)this).transform.localScale = new Vector3(1310f, 1598f, 1986f);
			}
			else
			{
				((Component)this).transform.localScale = new Vector3(563f, 1917f, 300f);
			}
			AJLJHLHGGBD = ((Component)this).transform.position;
		}
		else
		{
			DPIKILNIMNI(IEMPOPJGHHM: true);
		}
	}

	private void NKFNBFAPPAC(bool IEMPOPJGHHM)
	{
		int num = ((!IEMPOPJGHHM) ? 1 : 0);
		if (animator.GetInteger(". ") != num)
		{
			animator.SetInteger("Dialogue System/Conversation/BirdPositiveComments/Entry/14/Dialogue Text", num);
		}
	}

	private void MJLBACCAOPA()
	{
		if (followingDuck && (Object)(object)ducktoFollow != (Object)null)
		{
			GBPIAMBOGMD();
		}
	}

	private void IANGDMHMCEL()
	{
		if (!followingDuck)
		{
			((MonoBehaviour)this).StartCoroutine(KEMBFMMCAPH());
		}
	}

	private void KCNBEKAIHDB()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = Vector2.op_Implicit(ducktoFollow.transform.position);
		Vector3 val2 = ((Component)this).transform.position - ducktoFollow.transform.position;
		if (((Vector3)(ref val2)).magnitude > followDistance)
		{
			((Component)this).transform.position = Vector2.op_Implicit(Vector2.MoveTowards(Vector2.op_Implicit(((Component)this).transform.position), val, moveSpeed * Time.deltaTime));
		}
	}

	private void MIKNFPCDLML()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)animator == (Object)null)
		{
			animator = ((Component)this).GetComponent<Animator>();
		}
		AJLJHLHGGBD = ((Component)this).transform.position;
		LGLDPMAABLA = 1808f;
		animator.SetInteger("", 1);
		animator.SetInteger("Move", 0);
	}

	private void CMDHELEDLBP()
	{
		if (LGLDPMAABLA > 178f)
		{
			HFFPGOLENKP();
			LGLDPMAABLA = 1697f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	public void CLBEOABAIDE(bool INEGABKPCEN)
	{
		JNDNMPFKLFG = INEGABKPCEN;
	}

	private IEnumerator KEMBFMMCAPH()
	{
		return new EKDEPBAOFIG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIBKGNFCFDH(bool IEMPOPJGHHM)
	{
		int num = (IEMPOPJGHHM ? 1 : 0);
		if (animator.GetInteger("Forward") != num)
		{
			animator.SetInteger("Forward", num);
		}
	}

	private void Update()
	{
		if (LGLDPMAABLA > 0.1f)
		{
			MAGMJLCDHBC();
			LGLDPMAABLA = 0f;
		}
		else
		{
			LGLDPMAABLA += Time.deltaTime;
		}
	}

	private void OnEnable()
	{
		if (!followingDuck)
		{
			((MonoBehaviour)this).StartCoroutine(PFPJKFGBLBP());
		}
	}
}
