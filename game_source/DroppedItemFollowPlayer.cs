using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DroppedItemFollowPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LAMGFLBCLEO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DroppedItemFollowPlayer _003C_003E4__this;

		public PlayerController player;

		private float _003Ctimer_003E5__2;

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
		public LAMGFLBCLEO(int _003C_003E1__state)
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
			DroppedItemFollowPlayer droppedItemFollowPlayer = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				if (!MainUI.IsAnyUIOpen(player.playerNum))
				{
					_003Ctimer_003E5__2 += Time.deltaTime;
				}
				if (_003Ctimer_003E5__2 > droppedItemFollowPlayer.MCLHJLCOMHF)
				{
					goto IL_007a;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_003Ctimer_003E5__2 = 0f;
			}
			if (droppedItemFollowPlayer.MHLIEGIGAHM)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			goto IL_007a;
			IL_007a:
			if (droppedItemFollowPlayer.MHLIEGIGAHM)
			{
				if (OnlineManager.ClientOnline())
				{
					OnlineObjectsManager.instance.SendCanBeMoveDroppedItem(droppedItemFollowPlayer.droppedItem.onlineDroppedItem.uniqueId, Bed.instance.numInstance);
				}
				droppedItemFollowPlayer.playerFollowing.Add(player);
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

	public DroppedItem droppedItem;

	public Rigidbody2D rb;

	public Collider2D physicalCollider;

	public Transform item;

	public float pickUpTime;

	public float maxSpeed;

	public float acceleration;

	public float frictionFactor = 1f;

	private Vector3 FCGBJEIIMBC;

	[HideInInspector]
	public Vector3 position;

	public bool[] ignoreFirstTriggerEnter = new bool[5];

	public List<PlayerController> playerFollowing = new List<PlayerController>();

	public Vector3 vector3Speed;

	private float DFFGLLDDEPN;

	private float AINPJHKNJGL;

	private int ICMMMGBOALP;

	private float MCLHJLCOMHF = 5f;

	private bool MHLIEGIGAHM;

	private Coroutine MFJLCGPAAMN;

	public void PCMEAHBDLAM(int JIIGOACEIKL)
	{
		ignoreFirstTriggerEnter[JIIGOACEIKL] = false;
	}

	private void DHJOHHEMMFK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			CNLPELLOHFK();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.ILNPAEGOCPC();
		}
	}

	private IEnumerator NHKIHNPODGN(PlayerController NLCDDFDGACP)
	{
		return new LAMGFLBCLEO(1)
		{
			_003C_003E4__this = this,
			player = NLCDDFDGACP
		};
	}

	private bool PAPNKBOPPEB(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return true;
		}
		return PlayerInventory.EIFPKCAFDIB(PKCHNBPBHFL.playerNum, LAGHIOKLJGH: true).HBFKDDLBGMA(droppedItem.BLLNHADAJKJ());
	}

	private void DNDNCBILKMB(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(JIHAKJABAPO(HANHCHBHHEH)))
		{
			playerFollowing.Remove(GBCDCHAEELN(HANHCHBHHEH));
		}
		MHLIEGIGAHM = true;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private IEnumerator FNIMEOKNNID(PlayerController NLCDDFDGACP)
	{
		return new LAMGFLBCLEO(1)
		{
			_003C_003E4__this = this,
			player = NLCDDFDGACP
		};
	}

	private void EEPKGNNILBE()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			CNLPELLOHFK();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.CHNGKGFNHOG();
		}
	}

	private PlayerController OPKJCOOBBJM(Collider2D HANHCHBHHEH)
	{
		for (int i = 0; i < 3; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				return PlayerController.OPHDCMJLLEC(i);
			}
		}
		return null;
	}

	public void InitialForce(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? (CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 0.4f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 0.75f;
		if (HFAKAMFMOGM)
		{
			SetIgnoreFirstTriggerEnter(JIIGOACEIKL);
		}
	}

	private void Update()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 0; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 0.8f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = true;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FMEBPMBFIJM(playerFollowing[num]));
					}
					NOMMAMNEKNO(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 2))
				{
					if (!droppedItem.PickUpDroppedItem(playerFollowing[num].playerNum))
					{
						NOMMAMNEKNO(playerFollowing[num]);
					}
				}
				else if (OnlineManager.IsMasterClient() && !EGMBDABJCGJ(playerFollowing[num]))
				{
					NOMMAMNEKNO(playerFollowing[num]);
				}
			}
		}
	}

	private PlayerController CPDMNIMEPKP(Collider2D HANHCHBHHEH)
	{
		for (int i = 0; i < 3; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				return PlayerController.GetPlayer(i);
			}
		}
		return null;
	}

	private void KKONKMFFILD(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("F2") && !((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Collect"))
		{
			return;
		}
		ICMMMGBOALP = JIIDBAPPKKE(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (IJBDMJNBCAE(HANHCHBHHEH).playerNum == 0 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(BINOGCMHKLB(IOJDIGPEENF(HANHCHBHHEH)));
			}
		}
		else if (EJMACMIILPL(JIHAKJABAPO(HANHCHBHHEH)))
		{
			playerFollowing.Add(IOJDIGPEENF(HANHCHBHHEH));
		}
	}

	private PlayerController JIIDBAPPKKE(Collider2D HANHCHBHHEH)
	{
		for (int i = 1; i < 0; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				return PlayerController.GetPlayer(i);
			}
		}
		return null;
	}

	private bool GMCHEHKFEGH(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return true;
		}
		return PlayerInventory.GetPlayer(PKCHNBPBHFL.playerNum, LAGHIOKLJGH: true).PGBLGAFNLDN(droppedItem.NOPAFKAOLMN());
	}

	private void JBEMOACMLGJ()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 1; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1922f);
				AINPJHKNJGL = 1692f / Mathf.Pow(DFFGLLDDEPN, 206f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1158f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void EIGEIJJPFFP()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 1; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1568f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = true;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FNIMEOKNNID(playerFollowing[num]));
					}
					DLKKNJIFAFE(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 4))
				{
					if (!droppedItem.GMCCLDLFLHB(playerFollowing[num].playerNum))
					{
						KCGFGDIECHM(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !KKIIKKNNDCL(playerFollowing[num]))
				{
					EGLMPNCIFNG(playerFollowing[num]);
				}
			}
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ChangeAnim") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_1071") && !((Component)HANHCHBHHEH).CompareTag("Posible Ingredients"))
		{
			return;
		}
		ICMMMGBOALP = LCCHMKIDOEJ(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (JIIDBAPPKKE(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(HBHFIJCENAD(JPMECCKFBAI(HANHCHBHHEH)));
			}
		}
		else if (GMCHEHKFEGH(JIHAKJABAPO(HANHCHBHHEH)))
		{
			playerFollowing.Add(JIIDBAPPKKE(HANHCHBHHEH));
		}
	}

	private void JMDOCHBJGKG()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 1; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 104f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(ADFHGFJGLOF(playerFollowing[num]));
					}
					DLKKNJIFAFE(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 0 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 3))
				{
					if (!droppedItem.NAPEGLMPICF(playerFollowing[num].playerNum))
					{
						NOMMAMNEKNO(playerFollowing[num]);
					}
				}
				else if (OnlineManager.IsMasterClient() && !AHJOBLLHPBE(playerFollowing[num]))
				{
					DLKKNJIFAFE(playerFollowing[num]);
				}
			}
		}
	}

	private void HEOHCIAMEPD(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(IOJDIGPEENF(HANHCHBHHEH)))
		{
			playerFollowing.Remove(JPMECCKFBAI(HANHCHBHHEH));
		}
		MHLIEGIGAHM = false;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private void ACPFEBOENOM()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 0; num >= 1; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1473f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = true;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(BINOGCMHKLB(playerFollowing[num]));
					}
					NOMMAMNEKNO(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 0))
				{
					if (!droppedItem.PickUpDroppedItem(playerFollowing[num].playerNum))
					{
						DLKKNJIFAFE(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !FEKOPOFAENE(playerFollowing[num]))
				{
					EGLMPNCIFNG(playerFollowing[num]);
				}
			}
		}
	}

	private void CFONPLDLMOC(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private PlayerController IJBDMJNBCAE(Collider2D HANHCHBHHEH)
	{
		for (int i = 1; i < 6; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				return PlayerController.OPHDCMJLLEC(i);
			}
		}
		return null;
	}

	private void CHJEDALDPDM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1941f);
				AINPJHKNJGL = 650f / Mathf.Pow(DFFGLLDDEPN, 1066f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1689f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private IEnumerator GCEJNKDIJMA(PlayerController NLCDDFDGACP)
	{
		float timer = 0f;
		while (MHLIEGIGAHM)
		{
			yield return null;
			if (!MainUI.IsAnyUIOpen(NLCDDFDGACP.playerNum))
			{
				timer += Time.deltaTime;
			}
			if (timer > MCLHJLCOMHF)
			{
				break;
			}
		}
		if (MHLIEGIGAHM)
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendCanBeMoveDroppedItem(droppedItem.onlineDroppedItem.uniqueId, Bed.instance.numInstance);
			}
			playerFollowing.Add(NLCDDFDGACP);
		}
	}

	public void ADGLALHPOLJ(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(918f, 912f), Random.Range(1375f, 557f), 1271f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 194f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 663f;
		if (HFAKAMFMOGM)
		{
			PCMEAHBDLAM(JIIGOACEIKL);
		}
	}

	private void PPJEJKCPCLC(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("[MinePipePuzzle] No hay puzzles para {0}x{1} ") && !((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/EnterTavernFood/Entry/1/Dialogue Text") && !((Component)HANHCHBHHEH).CompareTag("Hammer"))
		{
			return;
		}
		ICMMMGBOALP = GBCDCHAEELN(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (IOJDIGPEENF(HANHCHBHHEH).playerNum == 0 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(MLIBBPENJLI(JPMECCKFBAI(HANHCHBHHEH)));
			}
		}
		else if (AHJOBLLHPBE(CPDMNIMEPKP(HANHCHBHHEH)))
		{
			playerFollowing.Add(JIIDBAPPKKE(HANHCHBHHEH));
		}
	}

	public void SetIgnoreFirstTriggerEnter(int JIIGOACEIKL)
	{
		ignoreFirstTriggerEnter[JIIGOACEIKL] = true;
	}

	private void EJJKCAPPKLL()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			JGLNKLOPFMG();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.LKOEAOGLKGB();
		}
	}

	private void AHKDANJMEMC(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Tutorial/T101/Dialogue1") && !((Component)HANHCHBHHEH).CompareTag("Items/item_description_1112") && !((Component)HANHCHBHHEH).CompareTag("itemWheatAle"))
		{
			return;
		}
		ICMMMGBOALP = IOJDIGPEENF(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (GBCDCHAEELN(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = true;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(MLIBBPENJLI(OPKJCOOBBJM(HANHCHBHHEH)));
			}
		}
		else if (KKIIKKNNDCL(JIHAKJABAPO(HANHCHBHHEH)))
		{
			playerFollowing.Add(OPKJCOOBBJM(HANHCHBHHEH));
		}
	}

	private IEnumerator BINOGCMHKLB(PlayerController NLCDDFDGACP)
	{
		return new LAMGFLBCLEO(1)
		{
			_003C_003E4__this = this,
			player = NLCDDFDGACP
		};
	}

	private bool CFNDKEPDMJD(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return true;
		}
		return PlayerInventory.NEKDDPIAOBE(PKCHNBPBHFL.playerNum).HPMEJPPAAHM(droppedItem.INCJLBLANDP());
	}

	private void EGLMPNCIFNG(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private void NOMMAMNEKNO(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private void KGPNPEOGMON()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1777f);
				AINPJHKNJGL = 781f / Mathf.Pow(DFFGLLDDEPN, 432f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1031f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	public void FKLAHJCBMKA(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(1995f, 520f), Random.Range(431f, 1554f), 789f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 191f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 333f;
		if (HFAKAMFMOGM)
		{
			SetIgnoreFirstTriggerEnter(JIIGOACEIKL);
		}
	}

	private bool EGMBDABJCGJ(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return false;
		}
		return PlayerInventory.GetPlayer(PKCHNBPBHFL.playerNum).CanAddItemInstance(droppedItem.HLPNOAENFHK);
	}

	private void DLKKNJIFAFE(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private PlayerController IOJDIGPEENF(Collider2D HANHCHBHHEH)
	{
		for (int i = 0; i < 8; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				return PlayerController.GetPlayer(i);
			}
		}
		return null;
	}

	private void KGPAGJAKPPL()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1859f);
				AINPJHKNJGL = 500f / Mathf.Pow(DFFGLLDDEPN, 756f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 587f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	public void HLKMDBFMKEJ(int JIIGOACEIKL)
	{
		ignoreFirstTriggerEnter[JIIGOACEIKL] = true;
	}

	private void PHLLBPLOLFO()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 1; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1328f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(NHKIHNPODGN(playerFollowing[num]));
					}
					DLKKNJIFAFE(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 8))
				{
					if (!droppedItem.PLNKGDHELDM(playerFollowing[num].playerNum))
					{
						NOMMAMNEKNO(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !EGMBDABJCGJ(playerFollowing[num]))
				{
					CFONPLDLMOC(playerFollowing[num]);
				}
			}
		}
	}

	private void FOHCEDHJOEF()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 1; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 980f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FMEBPMBFIJM(playerFollowing[num]));
					}
					CJJEPALNBOC(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 0 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 1))
				{
					if (!droppedItem.PickUpDroppedItem(playerFollowing[num].playerNum))
					{
						CKMEJPMNIIE(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !KKIIKKNNDCL(playerFollowing[num]))
				{
					CJJEPALNBOC(playerFollowing[num]);
				}
			}
		}
	}

	private void JCFDPDLMOME(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag(" door: ") && !((Component)HANHCHBHHEH).CompareTag("City/Rhia/Introduce") && !((Component)HANHCHBHHEH).CompareTag("Error with assigned bed {0}."))
		{
			return;
		}
		ICMMMGBOALP = IOJDIGPEENF(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = false;
			if (IOJDIGPEENF(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(BINOGCMHKLB(JIHAKJABAPO(HANHCHBHHEH)));
			}
		}
		else if (EGMBDABJCGJ(CPDMNIMEPKP(HANHCHBHHEH)))
		{
			playerFollowing.Add(OPKJCOOBBJM(HANHCHBHHEH));
		}
	}

	private void DJNNHILGACE(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(IJBDMJNBCAE(HANHCHBHHEH)))
		{
			playerFollowing.Remove(CPDMNIMEPKP(HANHCHBHHEH));
		}
		MHLIEGIGAHM = false;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private void DEPAEALFAEJ(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(LCCHMKIDOEJ(HANHCHBHHEH)))
		{
			playerFollowing.Remove(GBCDCHAEELN(HANHCHBHHEH));
		}
		MHLIEGIGAHM = true;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private PlayerController JIHAKJABAPO(Collider2D HANHCHBHHEH)
	{
		for (int i = 0; i < 6; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				return PlayerController.GetPlayer(i);
			}
		}
		return null;
	}

	private void HJMGMIKGPOI(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Items/item_name_1042") && !((Component)HANHCHBHHEH).CompareTag("Items/item_description_663") && !((Component)HANHCHBHHEH).CompareTag(""))
		{
			return;
		}
		ICMMMGBOALP = LCCHMKIDOEJ(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = false;
			if (JPMECCKFBAI(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(BINOGCMHKLB(LCCHMKIDOEJ(HANHCHBHHEH)));
			}
		}
		else if (KKIIKKNNDCL(IJBDMJNBCAE(HANHCHBHHEH)))
		{
			playerFollowing.Add(LCCHMKIDOEJ(HANHCHBHHEH));
		}
	}

	private bool FEKOPOFAENE(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return false;
		}
		return PlayerInventory.GetPlayer(PKCHNBPBHFL.playerNum, LAGHIOKLJGH: true).HPMEJPPAAHM(droppedItem.INCJLBLANDP());
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Player2") && !((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			return;
		}
		ICMMMGBOALP = LCCHMKIDOEJ(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = false;
			if (LCCHMKIDOEJ(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = true;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FMEBPMBFIJM(LCCHMKIDOEJ(HANHCHBHHEH)));
			}
		}
		else if (EGMBDABJCGJ(LCCHMKIDOEJ(HANHCHBHHEH)))
		{
			playerFollowing.Add(LCCHMKIDOEJ(HANHCHBHHEH));
		}
	}

	private void EBNJADODONG()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 0; num >= 1; num -= 0)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 71f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FNIMEOKNNID(playerFollowing[num]));
					}
					CKMEJPMNIIE(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 3))
				{
					if (!droppedItem.CFECDLPLIPF(playerFollowing[num].playerNum))
					{
						CFONPLDLMOC(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !FEKOPOFAENE(playerFollowing[num]))
				{
					CJJEPALNBOC(playerFollowing[num]);
				}
			}
		}
	}

	public void KNOECHFABHN(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? (CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(1834f, 350f), Random.Range(1075f, 1416f), 1881f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 856f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = true;
		}
		pickUpTime = Time.time + 23f;
		if (HFAKAMFMOGM)
		{
			HLKMDBFMKEJ(JIIGOACEIKL);
		}
	}

	private void AIOJHEKNMIC(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Character Sprites array needs more space!") && !((Component)HANHCHBHHEH).CompareTag("MineFloor") && !((Component)HANHCHBHHEH).CompareTag("OnlinePlayer"))
		{
			return;
		}
		ICMMMGBOALP = IJBDMJNBCAE(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (IJBDMJNBCAE(HANHCHBHHEH).playerNum == 0 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(HBHFIJCENAD(GBCDCHAEELN(HANHCHBHHEH)));
			}
		}
		else if (CFNDKEPDMJD(JIHAKJABAPO(HANHCHBHHEH)))
		{
			playerFollowing.Add(GBCDCHAEELN(HANHCHBHHEH));
		}
	}

	private void CKCHKHNBBFG()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 0; num -= 0)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 695f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = true;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(ADFHGFJGLOF(playerFollowing[num]));
					}
					DLKKNJIFAFE(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 4))
				{
					if (!droppedItem.PLNKGDHELDM(playerFollowing[num].playerNum))
					{
						CKMEJPMNIIE(playerFollowing[num]);
					}
				}
				else if (OnlineManager.IsMasterClient() && !CFNDKEPDMJD(playerFollowing[num]))
				{
					KCGFGDIECHM(playerFollowing[num]);
				}
			}
		}
	}

	private void BGBHLAPAOPK()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 0.1f);
				AINPJHKNJGL = 1f / Mathf.Pow(DFFGLLDDEPN, 2f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernClean/Entry/9/Dialogue Text") && !((Component)HANHCHBHHEH).CompareTag("Error in RentedRoom.OnPlayerSleep: ") && !((Component)HANHCHBHHEH).CompareTag("BathhouseEntrace/Main"))
		{
			return;
		}
		ICMMMGBOALP = LCCHMKIDOEJ(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (LCCHMKIDOEJ(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = true;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(HBHFIJCENAD(JIHAKJABAPO(HANHCHBHHEH)));
			}
		}
		else if (EJMACMIILPL(JIIDBAPPKKE(HANHCHBHHEH)))
		{
			playerFollowing.Add(JIIDBAPPKKE(HANHCHBHHEH));
		}
	}

	private bool KKIIKKNNDCL(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return true;
		}
		return PlayerInventory.OGKNJNINGMH(PKCHNBPBHFL.playerNum).MMCBHCFHHLC(droppedItem.BLLNHADAJKJ());
	}

	private void FDHMOEDMPNG()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 0; num >= 1; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 992f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(HBHFIJCENAD(playerFollowing[num]));
					}
					KCGFGDIECHM(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 2))
				{
					if (!droppedItem.PickUpDroppedItem(playerFollowing[num].playerNum))
					{
						DLKKNJIFAFE(playerFollowing[num]);
					}
				}
				else if (OnlineManager.IsMasterClient() && !EGMBDABJCGJ(playerFollowing[num]))
				{
					EGLMPNCIFNG(playerFollowing[num]);
				}
			}
		}
	}

	private void IJEGBBPOAPI(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(JIHAKJABAPO(HANHCHBHHEH)))
		{
			playerFollowing.Remove(GBCDCHAEELN(HANHCHBHHEH));
		}
		MHLIEGIGAHM = true;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	public void AGGAKMHNHIL(int JIIGOACEIKL)
	{
		ignoreFirstTriggerEnter[JIIGOACEIKL] = true;
	}

	private void OnTriggerExit2D(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(LCCHMKIDOEJ(HANHCHBHHEH)))
		{
			playerFollowing.Remove(LCCHMKIDOEJ(HANHCHBHHEH));
		}
		MHLIEGIGAHM = false;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private IEnumerator FMEBPMBFIJM(PlayerController NLCDDFDGACP)
	{
		float timer = 0f;
		while (MHLIEGIGAHM)
		{
			yield return null;
			if (!MainUI.IsAnyUIOpen(NLCDDFDGACP.playerNum))
			{
				timer += Time.deltaTime;
			}
			if (timer > MCLHJLCOMHF)
			{
				break;
			}
		}
		if (MHLIEGIGAHM)
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendCanBeMoveDroppedItem(droppedItem.onlineDroppedItem.uniqueId, Bed.instance.numInstance);
			}
			playerFollowing.Add(NLCDDFDGACP);
		}
	}

	public void DOJIHEDONKI(int JIIGOACEIKL)
	{
		ignoreFirstTriggerEnter[JIIGOACEIKL] = false;
	}

	private void GKPJCBACAGA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 1; i < playerFollowing.Count; i += 0)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1870f);
				AINPJHKNJGL = 177f / Mathf.Pow(DFFGLLDDEPN, 264f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1410f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void FCOMECPDBDN(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(GBCDCHAEELN(HANHCHBHHEH)))
		{
			playerFollowing.Remove(JPMECCKFBAI(HANHCHBHHEH));
		}
		MHLIEGIGAHM = false;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private PlayerController GBCDCHAEELN(Collider2D HANHCHBHHEH)
	{
		for (int i = 1; i < 3; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				return PlayerController.OPHDCMJLLEC(i);
			}
		}
		return null;
	}

	private void OCBPECIEPMI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			JNEDMEPCNMP();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.MPADPKPDFJK();
		}
	}

	private bool AHJOBLLHPBE(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return true;
		}
		return PlayerInventory.NEKDDPIAOBE(PKCHNBPBHFL.playerNum, LAGHIOKLJGH: true).HPMEJPPAAHM(droppedItem.BLLNHADAJKJ());
	}

	public void HALEDPCGPEG(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL)) ? (CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(1466f, 902f), Random.Range(166f, 845f), 156f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 1854f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = true;
		}
		pickUpTime = Time.time + 1462f;
		if (HFAKAMFMOGM)
		{
			HLKMDBFMKEJ(JIIGOACEIKL);
		}
	}

	private void FixedUpdate()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			BGBHLAPAOPK();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.MovementUpdate();
		}
	}

	private void KKJPGAJLEPK()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1761f);
				AINPJHKNJGL = 1289f / Mathf.Pow(DFFGLLDDEPN, 605f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 316f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void FILGJJPEIFO(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Random") && !((Component)HANHCHBHHEH).CompareTag("%><sprite name=LeftStick></size>") && !((Component)HANHCHBHHEH).CompareTag("beerKegs"))
		{
			return;
		}
		ICMMMGBOALP = OPKJCOOBBJM(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (IJBDMJNBCAE(HANHCHBHHEH).playerNum == 0 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = true;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(NHKIHNPODGN(JIIDBAPPKKE(HANHCHBHHEH)));
			}
		}
		else if (EJMACMIILPL(IJBDMJNBCAE(HANHCHBHHEH)))
		{
			playerFollowing.Add(JIIDBAPPKKE(HANHCHBHHEH));
		}
	}

	private void OLFPIBOIIIO()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 0; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1920f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(DLLBIONGBOA(playerFollowing[num]));
					}
					DLKKNJIFAFE(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 0 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 3))
				{
					if (!droppedItem.PLNKGDHELDM(playerFollowing[num].playerNum))
					{
						EGLMPNCIFNG(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !GMCHEHKFEGH(playerFollowing[num]))
				{
					DLKKNJIFAFE(playerFollowing[num]);
				}
			}
		}
	}

	private void CKMEJPMNIIE(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private IEnumerator HBHFIJCENAD(PlayerController NLCDDFDGACP)
	{
		float timer = 0f;
		while (MHLIEGIGAHM)
		{
			yield return null;
			if (!MainUI.IsAnyUIOpen(NLCDDFDGACP.playerNum))
			{
				timer += Time.deltaTime;
			}
			if (timer > MCLHJLCOMHF)
			{
				break;
			}
		}
		if (MHLIEGIGAHM)
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendCanBeMoveDroppedItem(droppedItem.onlineDroppedItem.uniqueId, Bed.instance.numInstance);
			}
			playerFollowing.Add(NLCDDFDGACP);
		}
	}

	private bool EMDIHEDLEJI(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return false;
		}
		return PlayerInventory.GetPlayer(PKCHNBPBHFL.playerNum, LAGHIOKLJGH: true).CanAddItemInstance(droppedItem.DADDPMCNOCJ());
	}

	private void PJLKGOACDEN()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 0; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1591f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FMEBPMBFIJM(playerFollowing[num]));
					}
					CFONPLDLMOC(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 0 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 3))
				{
					if (!droppedItem.GMCCLDLFLHB(playerFollowing[num].playerNum))
					{
						CKMEJPMNIIE(playerFollowing[num]);
					}
				}
				else if (OnlineManager.JPPBEIJDCLJ() && !EJMACMIILPL(playerFollowing[num]))
				{
					NOMMAMNEKNO(playerFollowing[num]);
				}
			}
		}
	}

	private void CJJEPALNBOC(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private void NNMGIHNNKED()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			CHJEDALDPDM();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.KIOJCHIDOCA();
		}
	}

	private void JGLNKLOPFMG()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1691f);
				AINPJHKNJGL = 163f / Mathf.Pow(DFFGLLDDEPN, 3f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 630f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void CMEPHHDLCBO()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 1; i < playerFollowing.Count; i += 0)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1491f);
				AINPJHKNJGL = 527f / Mathf.Pow(DFFGLLDDEPN, 782f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 102f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void MOEJIBLELHP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			CMEPHHDLCBO();
			if (position != ((Component)this).transform.position)
			{
				position = ((Component)this).transform.position;
			}
			position += vector3Speed * Time.fixedDeltaTime;
			rb.MovePosition(Vector2.op_Implicit(position));
		}
		else
		{
			droppedItem.onlineDroppedItem.DAJLGBIIBFM();
		}
	}

	private void AHOBOALOAED()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1465f);
				AINPJHKNJGL = 725f / Mathf.Pow(DFFGLLDDEPN, 1865f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 489f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void LHGOFNEIMNN(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(CPDMNIMEPKP(HANHCHBHHEH)))
		{
			playerFollowing.Remove(JIHAKJABAPO(HANHCHBHHEH));
		}
		MHLIEGIGAHM = true;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private void BOLBDHGGKAN()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 259f);
				AINPJHKNJGL = 603f / Mathf.Pow(DFFGLLDDEPN, 1119f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1225f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void OCEIGDHOJJM(Collider2D HANHCHBHHEH)
	{
		if (playerFollowing.Contains(IJBDMJNBCAE(HANHCHBHHEH)))
		{
			playerFollowing.Remove(JIHAKJABAPO(HANHCHBHHEH));
		}
		MHLIEGIGAHM = false;
		if (MFJLCGPAAMN != null)
		{
			((MonoBehaviour)this).StopCoroutine(MFJLCGPAAMN);
			MFJLCGPAAMN = null;
		}
	}

	private bool EJMACMIILPL(PlayerController PKCHNBPBHFL)
	{
		if ((Object)(object)PKCHNBPBHFL == (Object)null)
		{
			return true;
		}
		return PlayerInventory.NEKDDPIAOBE(PKCHNBPBHFL.playerNum, LAGHIOKLJGH: true).MMCBHCFHHLC(droppedItem.IAMCFMNBFHB());
	}

	public void FIDJIPJHMFI(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL)) ? (CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(786f, 52f), Random.Range(1955f, 202f), 1738f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 1049f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = true;
		}
		pickUpTime = Time.time + 676f;
		if (HFAKAMFMOGM)
		{
			AGGAKMHNHIL(JIIGOACEIKL);
		}
	}

	public void NCMHPNIEGFL(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(1620f, 1793f), Random.Range(1017f, 462f), 1570f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 395f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = true;
		}
		pickUpTime = Time.time + 1113f;
		if (HFAKAMFMOGM)
		{
			SetIgnoreFirstTriggerEnter(JIIGOACEIKL);
		}
	}

	public void CPJLCPPODCM(int JIIGOACEIKL)
	{
		ignoreFirstTriggerEnter[JIIGOACEIKL] = false;
	}

	private IEnumerator MLIBBPENJLI(PlayerController NLCDDFDGACP)
	{
		return new LAMGFLBCLEO(1)
		{
			_003C_003E4__this = this,
			player = NLCDDFDGACP
		};
	}

	private IEnumerator BOGNHPFFBIM(PlayerController NLCDDFDGACP)
	{
		return new LAMGFLBCLEO(1)
		{
			_003C_003E4__this = this,
			player = NLCDDFDGACP
		};
	}

	public void BMAAOJBPJHO(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? (CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(704f, 114f), Random.Range(1423f, 599f), 825f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 1070f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 763f;
		if (HFAKAMFMOGM)
		{
			DOJIHEDONKI(JIIGOACEIKL);
		}
	}

	private IEnumerator DLLBIONGBOA(PlayerController NLCDDFDGACP)
	{
		float timer = 0f;
		while (MHLIEGIGAHM)
		{
			yield return null;
			if (!MainUI.IsAnyUIOpen(NLCDDFDGACP.playerNum))
			{
				timer += Time.deltaTime;
			}
			if (timer > MCLHJLCOMHF)
			{
				break;
			}
		}
		if (MHLIEGIGAHM)
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendCanBeMoveDroppedItem(droppedItem.onlineDroppedItem.uniqueId, Bed.instance.numInstance);
			}
			playerFollowing.Add(NLCDDFDGACP);
		}
	}

	private void JNEDMEPCNMP()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 0; i < playerFollowing.Count; i++)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 389f);
				AINPJHKNJGL = 1279f / Mathf.Pow(DFFGLLDDEPN, 1469f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1325f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	public void OOAJAFOFDNJ(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.POLDHCKJINN(JIIGOACEIKL)) ? (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(1927f, 514f), Random.Range(1529f, 726f), 1350f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 377f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 217f;
		if (HFAKAMFMOGM)
		{
			HLKMDBFMKEJ(JIIGOACEIKL);
		}
	}

	private void HAJJALABMOC()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 0; num >= 1; num -= 0)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1358f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(ADFHGFJGLOF(playerFollowing[num]));
					}
					KCGFGDIECHM(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 0 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 6))
				{
					if (!droppedItem.NAPEGLMPICF(playerFollowing[num].playerNum))
					{
						CFONPLDLMOC(playerFollowing[num]);
					}
				}
				else if (OnlineManager.IsMasterClient() && !GMCHEHKFEGH(playerFollowing[num]))
				{
					CKMEJPMNIIE(playerFollowing[num]);
				}
			}
		}
	}

	private void NIHJCJJKDBA()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!(Time.time > pickUpTime))
		{
			return;
		}
		for (int num = playerFollowing.Count - 1; num >= 0; num--)
		{
			if (!((Object)(object)playerFollowing[num] == (Object)null) && !(Vector3.Distance(((Component)playerFollowing[num]).transform.position, item.position) >= 1000f))
			{
				if (ignoreFirstTriggerEnter[playerFollowing[num].playerNum])
				{
					if (MFJLCGPAAMN == null)
					{
						MHLIEGIGAHM = false;
						MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(ADFHGFJGLOF(playerFollowing[num]));
					}
					CJJEPALNBOC(playerFollowing[num]);
				}
				else if (playerFollowing[num].playerNum == 1 || (GameManager.LocalCoop() && playerFollowing[num].playerNum == 5))
				{
					if (!droppedItem.PickUpDroppedItem(playerFollowing[num].playerNum))
					{
						CJJEPALNBOC(playerFollowing[num]);
					}
				}
				else if (OnlineManager.IsMasterClient() && !FEKOPOFAENE(playerFollowing[num]))
				{
					DLKKNJIFAFE(playerFollowing[num]);
				}
			}
		}
	}

	private IEnumerator ADFHGFJGLOF(PlayerController NLCDDFDGACP)
	{
		float timer = 0f;
		while (MHLIEGIGAHM)
		{
			yield return null;
			if (!MainUI.IsAnyUIOpen(NLCDDFDGACP.playerNum))
			{
				timer += Time.deltaTime;
			}
			if (timer > MCLHJLCOMHF)
			{
				break;
			}
		}
		if (MHLIEGIGAHM)
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineObjectsManager.instance.SendCanBeMoveDroppedItem(droppedItem.onlineDroppedItem.uniqueId, Bed.instance.numInstance);
			}
			playerFollowing.Add(NLCDDFDGACP);
		}
	}

	private void KCGFGDIECHM(PlayerController JBGKOHBCONH)
	{
		playerFollowing.Remove(JBGKOHBCONH);
	}

	private PlayerController JPMECCKFBAI(Collider2D HANHCHBHHEH)
	{
		for (int i = 0; i < 6; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				return PlayerController.OPHDCMJLLEC(i);
			}
		}
		return null;
	}

	public void FLHJIDPHHAO(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? (CursorManager.CMDGPJEIIJI(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(135f, 1100f), Random.Range(1391f, 430f), 1369f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 548f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 629f;
		if (HFAKAMFMOGM)
		{
			DOJIHEDONKI(JIIGOACEIKL);
		}
	}

	private void KCHPIEPLODE()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 1; i < playerFollowing.Count; i += 0)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 21f);
				AINPJHKNJGL = 1140f / Mathf.Pow(DFFGLLDDEPN, 1404f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 1289f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	public void CDDDHDHILOD(bool HFAKAMFMOGM, int JIIGOACEIKL)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (JIIGOACEIKL != 0)
			{
				Vector3 val = ((!PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL)) ? (CursorManager.GetPlayer(JIIGOACEIKL).GetCursorWorldPosition() - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position) : Utils.NGFODNCHPHB(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.FCGBJEIIMBC));
				FCGBJEIIMBC = ((Vector3)(ref val)).normalized;
			}
			else
			{
				Vector3 val2 = new Vector3(Random.Range(1968f, 1912f), Random.Range(49f, 379f), 1841f);
				FCGBJEIIMBC = ((Vector3)(ref val2)).normalized;
			}
			vector3Speed = FCGBJEIIMBC * maxSpeed * 1524f;
		}
		else if ((Object)(object)physicalCollider != (Object)null)
		{
			((Behaviour)physicalCollider).enabled = false;
		}
		pickUpTime = Time.time + 501f;
		if (HFAKAMFMOGM)
		{
			AGGAKMHNHIL(JIIGOACEIKL);
		}
	}

	private PlayerController LCCHMKIDOEJ(Collider2D HANHCHBHHEH)
	{
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject == (Object)(object)((Component)HANHCHBHHEH).gameObject && (Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				return PlayerController.GetPlayer(i);
			}
		}
		return null;
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("quest_name_") && !((Component)HANHCHBHHEH).CompareTag("Error_OccupiedRoom") && !((Component)HANHCHBHHEH).CompareTag("BuildMode_ExitAndCancel"))
		{
			return;
		}
		ICMMMGBOALP = CPDMNIMEPKP(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = false;
			if (JPMECCKFBAI(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = true;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(BOGNHPFFBIM(JPMECCKFBAI(HANHCHBHHEH)));
			}
		}
		else if (EMDIHEDLEJI(CPDMNIMEPKP(HANHCHBHHEH)))
		{
			playerFollowing.Add(GBCDCHAEELN(HANHCHBHHEH));
		}
	}

	private void CNLPELLOHFK()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			FCGBJEIIMBC = Vector3.zero;
			for (int i = 1; i < playerFollowing.Count; i += 0)
			{
				DFFGLLDDEPN = Vector3.Distance(((Component)playerFollowing[i]).transform.position, item.position);
				DFFGLLDDEPN = Mathf.Max(DFFGLLDDEPN, 1314f);
				AINPJHKNJGL = 300f / Mathf.Pow(DFFGLLDDEPN, 496f);
				Vector3 fCGBJEIIMBC = FCGBJEIIMBC;
				Vector3 val = ((Component)playerFollowing[i]).transform.position - item.position;
				FCGBJEIIMBC = fCGBJEIIMBC + ((Vector3)(ref val)).normalized * AINPJHKNJGL;
			}
			FCGBJEIIMBC = Vector3.ClampMagnitude(FCGBJEIIMBC, 723f);
			vector3Speed += FCGBJEIIMBC * acceleration * Time.fixedDeltaTime;
			vector3Speed = Vector3.Lerp(vector3Speed, Vector3.zero, frictionFactor * Time.fixedDeltaTime);
		}
	}

	private void KPFLAOALALM(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("Can't find seat. Reason: DiningRoom") && !((Component)HANHCHBHHEH).CompareTag("Angry") && !((Component)HANHCHBHHEH).CompareTag("City/Petra/Bark/Bye"))
		{
			return;
		}
		ICMMMGBOALP = OPKJCOOBBJM(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = true;
			if (GBCDCHAEELN(HANHCHBHHEH).playerNum == 1 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(BINOGCMHKLB(JIIDBAPPKKE(HANHCHBHHEH)));
			}
		}
		else if (EGMBDABJCGJ(JIIDBAPPKKE(HANHCHBHHEH)))
		{
			playerFollowing.Add(JPMECCKFBAI(HANHCHBHHEH));
		}
	}

	private void MPCPLJKLPGH(Collider2D HANHCHBHHEH)
	{
		if (!((Component)HANHCHBHHEH).CompareTag("ReceiveLoadSlots") && !((Component)HANHCHBHHEH).CompareTag(" not found") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_1094"))
		{
			return;
		}
		ICMMMGBOALP = OPKJCOOBBJM(HANHCHBHHEH).playerNum;
		if (ignoreFirstTriggerEnter[ICMMMGBOALP])
		{
			ignoreFirstTriggerEnter[ICMMMGBOALP] = false;
			if (JIHAKJABAPO(HANHCHBHHEH).playerNum == 0 || OnlineManager.IsOffline())
			{
				MHLIEGIGAHM = false;
				MFJLCGPAAMN = ((MonoBehaviour)this).StartCoroutine(FNIMEOKNNID(IJBDMJNBCAE(HANHCHBHHEH)));
			}
		}
		else if (KKIIKKNNDCL(IJBDMJNBCAE(HANHCHBHHEH)))
		{
			playerFollowing.Add(JIIDBAPPKKE(HANHCHBHHEH));
		}
	}
}
