using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HeldTools : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KJEILDNIECD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject _collider;

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
		public KJEILDNIECD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_collider.SetActive(true);
				_003C_003E2__current = (object)new WaitForFixedUpdate();
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForFixedUpdate();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_collider.SetActive(false);
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

	private static HeldTools[] GJBBNHCMNJN = new HeldTools[5];

	[SerializeField]
	private GameObject cutCollider;

	[SerializeField]
	private GameObject hitCollider;

	public Animator anim;

	public GameObject sickle;

	public GameObject mop;

	public GameObject sword;

	public Action<bool> OnMopActive = delegate
	{
	};

	public Action<bool> OnSickleActive = delegate
	{
	};

	public Action<bool> OnSwordActive = delegate
	{
	};

	private int JIIGOACEIKL;

	private static bool BJKLFFGLLCJ(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	public void NMLEODBCJAI(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private static void DBECAFJAGBM(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Dialogue System/Conversation/EnterTavernDrink/Entry/8/Dialogue Text");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void IDPHKHGHJGN()
	{
		cutCollider.SetActive(true);
	}

	public void SetSickleActive(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	public void KOCODBEHAJD(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void ActivateCutCollider()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("Direction") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 180f;
		}
		else if (anim.GetInteger("Direction") == 1)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("Direction") == 2)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 270f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 90f;
		}
		((MonoBehaviour)this).StartCoroutine(AKFFNNHILFF(cutCollider));
	}

	private static void KGLKHPDAHOP(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Items/item_description_665");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Error_FloorTilesLimit");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void OOIHNJHMBMC()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		DPKDABKPOIH(this);
	}

	public void DFGHMDNCBCP(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private void JECHMEFJABD()
	{
		cutCollider.SetActive(true);
	}

	public void OHPKMCAMJJE(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	private void IFHLGOMBACP()
	{
		cutCollider.SetActive(true);
	}

	public void PJPDABKJANH(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private IEnumerator LAHAAOMIJGG(GameObject KMMGHABLBOO)
	{
		return new KJEILDNIECD(1)
		{
			_collider = KMMGHABLBOO
		};
	}

	public static HeldTools EJKCBAKCBEO(int JIIGOACEIKL)
	{
		if (!GDCCKKFIIPG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static bool CLCHKFLOAKL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	public static HeldTools OGKNJNINGMH(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void IEFKNICKOKA()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("Direction") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 745f;
		}
		else if (anim.GetInteger("dForDays") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("Items/item_name_1041") == 6)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 237f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 637f;
		}
		((MonoBehaviour)this).StartCoroutine(AKFFNNHILFF(cutCollider));
	}

	private void FOHGHCPODBJ()
	{
		cutCollider.SetActive(true);
	}

	public void MCDFGFJBCFP(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private static bool KJLLBGGILAK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public void MMPCACGFJAL(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private static void PNCPKHIAAKE(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Private Example Method");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"NormalLeftExterior");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void GOEGBOEMHLI()
	{
		cutCollider.SetActive(false);
	}

	private IEnumerator DPPIKDPMOHN(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	private static void IGAGJLPHDFK(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)", ");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"ReceiveFireplaceMessage");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public static HeldTools MFJNNCFFDEH(int JIIGOACEIKL)
	{
		if (!OKOLCPJAHML(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void Start()
	{
		cutCollider.SetActive(false);
	}

	private void MIKNFPCDLML()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CKGGHOGELAN(this);
	}

	private static bool BELJFNLIKKG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	private void FPNCANODJKE()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		DPKDABKPOIH(this);
	}

	private static bool GDCCKKFIIPG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return true;
	}

	private static bool OKOLCPJAHML(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public void KLFMPEJAGCO(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void BMIBAADJOGA()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("HaveGoldenTicket") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1914f;
		}
		else if (anim.GetInteger("UIInteract") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("LE_10") == 4)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 259f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 435f;
		}
		((MonoBehaviour)this).StartCoroutine(LAHAAOMIJGG(cutCollider));
	}

	private void JPOLFKMLHNH()
	{
		cutCollider.SetActive(true);
	}

	private static bool DHJKAAKFMFK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private IEnumerator AKFFNNHILFF(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	public static HeldTools FIHGMLABOBB(int JIIGOACEIKL)
	{
		if (!LKLNMGDLLAM(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static bool AMJIKHIMGOP(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return false;
	}

	public void MHIHCNMEOJC(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void NAAILELIDMJ(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private void DADPOICMNPI()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CKGGHOGELAN(this);
	}

	private IEnumerator DAEGMGPGCMD(GameObject KMMGHABLBOO)
	{
		return new KJEILDNIECD(1)
		{
			_collider = KMMGHABLBOO
		};
	}

	public void GODBPJAJGEB(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private IEnumerator FAGOGNLFHAJ(GameObject KMMGHABLBOO)
	{
		return new KJEILDNIECD(1)
		{
			_collider = KMMGHABLBOO
		};
	}

	private void PNLAJCHBHPH()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		CKGGHOGELAN(this);
	}

	public void MILMCMOPKLB(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	private static bool KAKALCDIOPE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	public void IOGBAPCEDJJ(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private IEnumerator INAAFMPDKLG(GameObject KMMGHABLBOO)
	{
		return new KJEILDNIECD(1)
		{
			_collider = KMMGHABLBOO
		};
	}

	private void KMBEOPAHKGB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		KGLKHPDAHOP(this);
	}

	private void KLHIMJFCHPD()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		KGLKHPDAHOP(this);
	}

	public static HeldTools GetPlayer(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void KEPJNGGNAEK()
	{
		cutCollider.SetActive(true);
	}

	public static HeldTools NPANPNIDKDG(int JIIGOACEIKL)
	{
		if (!KAKALCDIOPE(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void BKIIEFBFLFL(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public void FFLAICAOFJI(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	private void PLHPEMNDAFB()
	{
		cutCollider.SetActive(true);
	}

	public void CJOIAIFBBIN(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private void OILHJENGGEL()
	{
		cutCollider.SetActive(true);
	}

	public void EOKNKLAKLMJ(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	private void DNKEFFMOCKP()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		PNCPKHIAAKE(this);
	}

	public void IFNBOKPHKMG(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public void GIOFPMFNCDP()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("SetIntegerRPC") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1449f;
			}
			else if (anim.GetInteger("Items/item_name_1447") == 1)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("Received RPC SetBool {0} with value {1} on {2}. Setting animator parameter.") == 1)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 762f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 864f;
			}
			((MonoBehaviour)this).StartCoroutine(FAGOGNLFHAJ(hitCollider));
		}
	}

	public void PLJNCILBFKF(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF(this);
	}

	public void KGPLMANNGCE(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public static HeldTools FLOIJFPDJGG(int JIIGOACEIKL)
	{
		if (!OKOLCPJAHML(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void GNMMELIJKML()
	{
		cutCollider.SetActive(true);
	}

	public void IJDFIPHNKNH()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger(") recipes locked") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 520f;
		}
		else if (anim.GetInteger("LE_22") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("Cheer") == 6)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 580f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1106f;
		}
		((MonoBehaviour)this).StartCoroutine(MCCEBKBMJKG(cutCollider));
	}

	private static void CKGGHOGELAN(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Dialogue System/Conversation/TavernFilthy/Entry/10/Dialogue Text");
			return;
		}
		for (int i = 0; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"</color>\n");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private void HEMAHKJEONA()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CKGGHOGELAN(this);
	}

	public void NOJOIODMAGN(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private static void DPKDABKPOIH(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"DemolishConfirmationWithAnimals");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"TavernVision");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public void ActivateHitCollider()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("Direction") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 180f;
			}
			else if (anim.GetInteger("Direction") == 1)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("Direction") == 2)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 270f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 90f;
			}
			((MonoBehaviour)this).StartCoroutine(AKFFNNHILFF(hitCollider));
		}
	}

	public void CPLFJFJAOGA()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("talentPaleAdv.") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1392f;
			}
			else if (anim.GetInteger("Player") == 1)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("Press SPACE to continue") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1543f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1264f;
			}
			((MonoBehaviour)this).StartCoroutine(DAEGMGPGCMD(hitCollider));
		}
	}

	private void DNIPPGPKHLC()
	{
		cutCollider.SetActive(false);
	}

	private static bool AGHMBOBHMGG(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	public void MBCIFBEADOG()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("F4") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 126f;
		}
		else if (anim.GetInteger("Customer Pool instance NULL!") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("???") == 7)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 982f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1330f;
		}
		((MonoBehaviour)this).StartCoroutine(NCIKLHHHAAP(cutCollider));
	}

	private IEnumerator AHAFNMIOMIH(GameObject KMMGHABLBOO)
	{
		return new KJEILDNIECD(1)
		{
			_collider = KMMGHABLBOO
		};
	}

	private void NLNOFEBEBDE()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		IGAGJLPHDFK(this);
	}

	public void NGFIPKJIEBB(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void LPJCHBNJJEE(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public void PLMJOEIEHJE(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public void LMAJJKBBFAD()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("Chisel") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1852f;
			}
			else if (anim.GetInteger("ReceiveEmployeeWorking") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("CannotToggleUI IsActioningTool ") == 7)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1341f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1201f;
			}
			((MonoBehaviour)this).StartCoroutine(MCCEBKBMJKG(hitCollider));
		}
	}

	public void AGNGFBDKJPK(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void HKKJPGGJCII(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private IEnumerator CBPIIBDDKPA(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	private IEnumerator MCCEBKBMJKG(GameObject KMMGHABLBOO)
	{
		return new KJEILDNIECD(1)
		{
			_collider = KMMGHABLBOO
		};
	}

	private void BODICIENBEH()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		DPKDABKPOIH(this);
	}

	private IEnumerator NCIKLHHHAAP(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	public static HeldTools GIAOPMIDGPL(int JIIGOACEIKL)
	{
		if (!GDCCKKFIIPG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void BCMFNHMHIAP(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private void BAKDKFKNHDE()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CMGKOADCCHE(this);
	}

	public static HeldTools DACNEICGAAE(int JIIGOACEIKL)
	{
		if (!ODIFEKCEIPN(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void DIBEFPELOIO(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	public void HEODBPMHLIG(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	private void HCEDMLJNOBL()
	{
		cutCollider.SetActive(false);
	}

	public void HJALPCJGBLJ()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("Items/item_description_678") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1479f;
		}
		else if (anim.GetInteger("ReceiveSymbolPuzzleSolved") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("UI2") == 8)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1860f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 615f;
		}
		((MonoBehaviour)this).StartCoroutine(NCIKLHHHAAP(cutCollider));
	}

	public void HKOOLEACKNB()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("Scene") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1881f;
			}
			else if (anim.GetInteger("Null editor action in database") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("discordLink") == 4)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 313f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 565f;
			}
			((MonoBehaviour)this).StartCoroutine(CBPIIBDDKPA(hitCollider));
		}
	}

	public void ALFAGJOKPLO(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	public void AJGDJEGLKFP(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	private void JDHHJKBOJML()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		DPBNPFKAFNF(this);
	}

	private void DJADNFCFHAG()
	{
		cutCollider.SetActive(true);
	}

	private void OIOLGAOPECC()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		PNCPKHIAAKE(this);
	}

	private static void DPBNPFKAFNF(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"BiscuitAleAbbreviation");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"GetKicked");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public void DEACPBMJBMP(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	public void LGLMLCKOCKI()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("Player 2 inputs disabled.") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 355f;
		}
		else if (anim.GetInteger("") == 1)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("con {0} tiles requeridos.") == 4)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1096f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 633f;
		}
		((MonoBehaviour)this).StartCoroutine(MCCEBKBMJKG(cutCollider));
	}

	public void HKLIFCGGMHN()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("]") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1522f;
			}
			else if (anim.GetInteger(" {0}") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("Inventory full") == 2)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 298f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 462f;
			}
			((MonoBehaviour)this).StartCoroutine(AKFFNNHILFF(hitCollider));
		}
	}

	private static bool ODIFEKCEIPN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return true;
	}

	public void DMGPMGDFDIE(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void AJGCHPHIBPN(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public static HeldTools IDGHAADJPCK(int JIIGOACEIKL)
	{
		if (!CLCHKFLOAKL(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private void KHCJDKHONPK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		HFCLMOKEOHP(this);
	}

	public void SetMopActive(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public void KLOJMIKLEPP(bool DMBFKFLDDLH)
	{
		sickle.SetActive(DMBFKFLDDLH);
		OnSickleActive?.Invoke(DMBFKFLDDLH);
	}

	public static HeldTools GIHKIEGFJNM(int JIIGOACEIKL)
	{
		if (!KJLLBGGILAK(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static HeldTools EIFPKCAFDIB(int JIIGOACEIKL)
	{
		if (!BELJFNLIKKG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static void HFCLMOKEOHP(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"NoEresDigno/KyrohTalks");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"LE_16");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public void SetSwordActive(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public static HeldTools JHEHMLIPPAA(int JIIGOACEIKL)
	{
		if (!OKOLCPJAHML(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public void MGEFKGLFDFO(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public void GCBDIOFFDAH(bool DMBFKFLDDLH)
	{
		mop.SetActive(DMBFKFLDDLH);
		OnMopActive?.Invoke(DMBFKFLDDLH);
	}

	public static HeldTools JBFDEAGDJEL(int JIIGOACEIKL)
	{
		if (!AGHMBOBHMGG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private static bool AEGGHMBILNK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 0)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	public void AFMFKOHIOMG(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	private static void CAAMEEBOAOF(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i++)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"Trying to add player but player list is full.");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	private static bool EJCDCLFNFGK(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return false;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return true;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return false;
		}
		return true;
	}

	private static void CMGKOADCCHE(HeldTools HACPNLAPCCC)
	{
		if (GJBBNHCMNJN.Contains(HACPNLAPCCC))
		{
			Debug.LogWarning((object)"BuildMode");
			return;
		}
		for (int i = 1; i < GJBBNHCMNJN.Length; i += 0)
		{
			if ((Object)(object)GJBBNHCMNJN[i] == (Object)null)
			{
				GJBBNHCMNJN[i] = HACPNLAPCCC;
				HACPNLAPCCC.JIIGOACEIKL = i;
				return;
			}
		}
		Debug.LogWarning((object)"ReceiveEmployees");
		Utils.BLPDAEHPOBA(((Component)HACPNLAPCCC).gameObject);
	}

	public void DDKIHNLKKFN()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("Disabled") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 878f;
			}
			else if (anim.GetInteger("dForDays") == 1)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("ReceiveCrafterRepaired") == 2)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1360f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 657f;
			}
			((MonoBehaviour)this).StartCoroutine(AKFFNNHILFF(hitCollider));
		}
	}

	private void EOBODNOCKGA()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		DBECAFJAGBM(this);
	}

	public void CHBIECCDAJF()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("Customize") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1409f;
			}
			else if (anim.GetInteger("() Ingredient ") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("Dialogue System/Conversation/TableDirty/Entry/4/Dialogue Text") == 2)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 706f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 1391f;
			}
			((MonoBehaviour)this).StartCoroutine(FAGOGNLFHAJ(hitCollider));
		}
	}

	private IEnumerator FGMIAOOBDEB(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	public void MAPLDFDBHCM()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("NormalLeft") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1555f;
		}
		else if (anim.GetInteger(" playerDialogue: ") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("SetAnimatorObjectBoolRPC") == 4)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 286f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 129f;
		}
		((MonoBehaviour)this).StartCoroutine(LAHAAOMIJGG(cutCollider));
	}

	private void EFCNKPEPELL()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		CAAMEEBOAOF(this);
	}

	private void GHOKECKAICE()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		DBECAFJAGBM(this);
	}

	private void CEOEHODJAJK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		PNCPKHIAAKE(this);
	}

	private void KILDJCPLOPP()
	{
		cutCollider.SetActive(false);
	}

	public void PMADAOCEHGD(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}

	public void NIFDOHJIDIB()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (anim.GetInteger("") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 1360f;
		}
		else if (anim.GetInteger("0") == 0)
		{
			cutCollider.transform.eulerAngles = Vector3.zero;
		}
		else if (anim.GetInteger("\n<color=#A95A00>") == 1)
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 607f;
		}
		else
		{
			cutCollider.transform.eulerAngles = Vector3.forward * 870f;
		}
		((MonoBehaviour)this).StartCoroutine(INAAFMPDKLG(cutCollider));
	}

	private static bool LKLNMGDLLAM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL < 1)
		{
			return true;
		}
		if (JIIGOACEIKL >= GJBBNHCMNJN.Length)
		{
			return false;
		}
		if ((Object)(object)GJBBNHCMNJN[JIIGOACEIKL] == (Object)null)
		{
			return true;
		}
		return false;
	}

	private IEnumerator BBNDIDOKAHB(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	public void LOKAJGKNNOB()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)hitCollider))
		{
			if (anim.GetInteger("Use") == 0)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 92f;
			}
			else if (anim.GetInteger(" <sprite name=white_arrow_right> ") == 1)
			{
				hitCollider.transform.eulerAngles = Vector3.zero;
			}
			else if (anim.GetInteger("Information") == 3)
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 966f;
			}
			else
			{
				hitCollider.transform.eulerAngles = Vector3.forward * 535f;
			}
			((MonoBehaviour)this).StartCoroutine(AHAFNMIOMIH(hitCollider));
		}
	}

	public static HeldTools IJMLNIHAOGK(int JIIGOACEIKL)
	{
		if (!AGHMBOBHMGG(JIIGOACEIKL))
		{
			return null;
		}
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	private IEnumerator GOOHECANJIO(GameObject KMMGHABLBOO)
	{
		KMMGHABLBOO.SetActive(true);
		yield return (object)new WaitForFixedUpdate();
		yield return (object)new WaitForFixedUpdate();
		KMMGHABLBOO.SetActive(false);
	}

	public void MBJLCFNBBPH(bool DMBFKFLDDLH)
	{
		sword.SetActive(DMBFKFLDDLH);
		OnSwordActive?.Invoke(DMBFKFLDDLH);
	}
}
