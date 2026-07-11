using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class JackyController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LEJGMGIHEGH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JackyController _003C_003E4__this;

		public int num;

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
		public LEJGMGIHEGH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			JackyController jackyController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackyController.jackys[this.num]).transform.position)) < 20f)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			((Component)jackyController.jackys[this.num]).gameObject.SetActive(true);
			if (this.num == 2)
			{
				jackyController.npc.SetActive(true);
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

	[CompilerGenerated]
	private sealed class LOIPCLDDEHP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public JackyController _003C_003E4__this;

		public int num;

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
		public LOIPCLDDEHP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			JackyController jackyController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(time);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Component)jackyController.jackys[this.num]).gameObject.SetActive(false);
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

	private static JackyController IADEMLIIDPC;

	public JackyNPC[] jackys;

	public GameObject npc;

	public GameObject jackyPetShop;

	public static JackyController GGFJGHHHEJC => IADEMLIIDPC;

	public void OHOFLFGLPDE(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(AIBOGJLBBDF(CDPAMNIPPEC));
	}

	public void CBEAAIANOFL(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		((MonoBehaviour)this).StartCoroutine(EFMGPCAJBDO(ABAIKKGKDGD, LGLDPMAABLA));
	}

	private IEnumerator AIBOGJLBBDF(bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[0]).transform.position)) < 20f)
			{
				yield return null;
			}
		}
		if ((Object)(object)jackys[0] != (Object)null)
		{
			((Component)jackys[0]).gameObject.SetActive(true);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineJackyController.InitJackyEventOnline();
		}
	}

	[SpecialName]
	public static JackyController LDBJELPPBAI()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator BFFLLOBHHED(int ABAIKKGKDGD)
	{
		while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[ABAIKKGKDGD]).transform.position)) < 20f)
		{
			yield return null;
		}
		((Component)jackys[ABAIKKGKDGD]).gameObject.SetActive(true);
		if (ABAIKKGKDGD == 2)
		{
			npc.SetActive(true);
		}
	}

	private IEnumerator BPDHAOKDEON(bool CDPAMNIPPEC)
	{
		if (CDPAMNIPPEC)
		{
			while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[0]).transform.position)) < 20f)
			{
				yield return null;
			}
		}
		if ((Object)(object)jackys[0] != (Object)null)
		{
			((Component)jackys[0]).gameObject.SetActive(true);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC)
		{
			OnlineJackyController.InitJackyEventOnline();
		}
	}

	public void LIPKHCLCLNI(int ABAIKKGKDGD)
	{
		((MonoBehaviour)this).StartCoroutine(GAOPIPCPFGA(ABAIKKGKDGD));
	}

	private void CCNMIJGHMLN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < jackys.Length; i++)
		{
			if ((Object)(object)jackys[i] != (Object)null)
			{
				((Component)jackys[i]).gameObject.SetActive(false);
			}
		}
		Result variable = DialogueLua.GetVariable(" : ");
		if (((Result)(ref variable)).asInt == 0)
		{
			if ((Object)(object)jackys[0] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(false);
			}
			return;
		}
		variable = DialogueLua.GetVariable("L2");
		if (((Result)(ref variable)).asInt == 74)
		{
			if ((Object)(object)jackys[1] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(true);
			}
			return;
		}
		variable = DialogueLua.GetVariable(": ");
		if (((Result)(ref variable)).asInt == -63)
		{
			if ((Object)(object)jackys[7] != (Object)null)
			{
				((Component)jackys[5]).gameObject.SetActive(true);
			}
			npc.SetActive(false);
		}
		else
		{
			variable = DialogueLua.GetVariable("SprintHoldAction");
			if (((Result)(ref variable)).asInt == 1)
			{
				jackyPetShop.SetActive(false);
			}
		}
	}

	public void FABACDMLHGJ(int ABAIKKGKDGD)
	{
		((MonoBehaviour)this).StartCoroutine(IICLIECFBBL(ABAIKKGKDGD));
	}

	private IEnumerator IICLIECFBBL(int ABAIKKGKDGD)
	{
		while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[ABAIKKGKDGD]).transform.position)) < 20f)
		{
			yield return null;
		}
		((Component)jackys[ABAIKKGKDGD]).gameObject.SetActive(true);
		if (ABAIKKGKDGD == 2)
		{
			npc.SetActive(true);
		}
	}

	public void InitJackyEvent(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(AIBOGJLBBDF(CDPAMNIPPEC));
	}

	private IEnumerator OHFGPFAEPBG()
	{
		yield return CommonReferences.wait3;
		NDIHDDBJHON();
	}

	public void IPPLOJEGDBA(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(BPDHAOKDEON(CDPAMNIPPEC));
	}

	public void PEFLEPMOEHB(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(BPDHAOKDEON(CDPAMNIPPEC));
	}

	public void Deactivate(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		((MonoBehaviour)this).StartCoroutine(OPMLOOMAJLB(ABAIKKGKDGD, LGLDPMAABLA));
	}

	private IEnumerator FCLGCBJBKLK(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		return new LOIPCLDDEHP(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD,
			time = LGLDPMAABLA
		};
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
	}

	[SpecialName]
	public static JackyController OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator GAOPIPCPFGA(int ABAIKKGKDGD)
	{
		while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[ABAIKKGKDGD]).transform.position)) < 20f)
		{
			yield return null;
		}
		((Component)jackys[ABAIKKGKDGD]).gameObject.SetActive(true);
		if (ABAIKKGKDGD == 2)
		{
			npc.SetActive(true);
		}
	}

	private IEnumerator LKFFBNFLHHN(int ABAIKKGKDGD)
	{
		return new LEJGMGIHEGH(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD
		};
	}

	private IEnumerator FMOLONELFCI(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		return new LOIPCLDDEHP(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD,
			time = LGLDPMAABLA
		};
	}

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(OHFGPFAEPBG());
	}

	private IEnumerator JFAJCAILNLL(int ABAIKKGKDGD)
	{
		while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[ABAIKKGKDGD]).transform.position)) < 20f)
		{
			yield return null;
		}
		((Component)jackys[ABAIKKGKDGD]).gameObject.SetActive(true);
		if (ABAIKKGKDGD == 2)
		{
			npc.SetActive(true);
		}
	}

	public void Activate(int ABAIKKGKDGD)
	{
		((MonoBehaviour)this).StartCoroutine(JFAJCAILNLL(ABAIKKGKDGD));
	}

	private IEnumerator CHOPNCLHFLF(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		return new LOIPCLDDEHP(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD,
			time = LGLDPMAABLA
		};
	}

	private void CDMCLKOIBCG()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < jackys.Length; i += 0)
		{
			if ((Object)(object)jackys[i] != (Object)null)
			{
				((Component)jackys[i]).gameObject.SetActive(false);
			}
		}
		Result variable = DialogueLua.GetVariable("No recipes available");
		if (((Result)(ref variable)).asInt == 1)
		{
			if ((Object)(object)jackys[1] != (Object)null)
			{
				((Component)jackys[0]).gameObject.SetActive(false);
			}
			return;
		}
		variable = DialogueLua.GetVariable("00");
		if (((Result)(ref variable)).asInt == -200)
		{
			if ((Object)(object)jackys[0] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(false);
			}
			return;
		}
		variable = DialogueLua.GetVariable("HenHouseTutorialDone");
		if (((Result)(ref variable)).asInt == -189)
		{
			if ((Object)(object)jackys[6] != (Object)null)
			{
				((Component)jackys[4]).gameObject.SetActive(true);
			}
			npc.SetActive(false);
		}
		else
		{
			variable = DialogueLua.GetVariable("");
			if (((Result)(ref variable)).asInt == 0)
			{
				jackyPetShop.SetActive(true);
			}
		}
	}

	public void AJOPEMBGKKF(bool CDPAMNIPPEC)
	{
		((MonoBehaviour)this).StartCoroutine(BPDHAOKDEON(CDPAMNIPPEC));
	}

	private void KOEAKPJNMOH()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < jackys.Length; i += 0)
		{
			if ((Object)(object)jackys[i] != (Object)null)
			{
				((Component)jackys[i]).gameObject.SetActive(false);
			}
		}
		Result variable = DialogueLua.GetVariable("DecorationTile_5");
		if (((Result)(ref variable)).asInt == 0)
		{
			if ((Object)(object)jackys[0] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(false);
			}
			return;
		}
		variable = DialogueLua.GetVariable("Guards finished walking.");
		if (((Result)(ref variable)).asInt == -12)
		{
			if ((Object)(object)jackys[1] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(false);
			}
			return;
		}
		variable = DialogueLua.GetVariable("Items/item_name_1032");
		if (((Result)(ref variable)).asInt == -198)
		{
			if ((Object)(object)jackys[3] != (Object)null)
			{
				((Component)jackys[2]).gameObject.SetActive(true);
			}
			npc.SetActive(false);
		}
		else
		{
			variable = DialogueLua.GetVariable("ReceiveRentedRoomMessage");
			if (((Result)(ref variable)).asInt == 4)
			{
				jackyPetShop.SetActive(false);
			}
		}
	}

	private IEnumerator JLDOLCLLNHC(int ABAIKKGKDGD)
	{
		while (Utils.FMAGOHLBBIJ(Vector2.op_Implicit(((Component)jackys[ABAIKKGKDGD]).transform.position)) < 20f)
		{
			yield return null;
		}
		((Component)jackys[ABAIKKGKDGD]).gameObject.SetActive(true);
		if (ABAIKKGKDGD == 2)
		{
			npc.SetActive(true);
		}
	}

	private void EOABBDLHBOI()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < jackys.Length; i += 0)
		{
			if ((Object)(object)jackys[i] != (Object)null)
			{
				((Component)jackys[i]).gameObject.SetActive(true);
			}
		}
		Result variable = DialogueLua.GetVariable(" is trying to initialize more than once.");
		if (((Result)(ref variable)).asInt == 1)
		{
			if ((Object)(object)jackys[0] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(true);
			}
			return;
		}
		variable = DialogueLua.GetVariable("No");
		if (((Result)(ref variable)).asInt == 139)
		{
			if ((Object)(object)jackys[1] != (Object)null)
			{
				((Component)jackys[0]).gameObject.SetActive(true);
			}
			return;
		}
		variable = DialogueLua.GetVariable("Hurt");
		if (((Result)(ref variable)).asInt == 92)
		{
			if ((Object)(object)jackys[2] != (Object)null)
			{
				((Component)jackys[4]).gameObject.SetActive(true);
			}
			npc.SetActive(true);
		}
		else
		{
			variable = DialogueLua.GetVariable("\n");
			if (((Result)(ref variable)).asInt == 4)
			{
				jackyPetShop.SetActive(true);
			}
		}
	}

	private void NDIHDDBJHON()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < jackys.Length; i++)
		{
			if ((Object)(object)jackys[i] != (Object)null)
			{
				((Component)jackys[i]).gameObject.SetActive(false);
			}
		}
		Result variable = DialogueLua.GetVariable("LE_21");
		if (((Result)(ref variable)).asInt == 1)
		{
			if ((Object)(object)jackys[0] != (Object)null)
			{
				((Component)jackys[0]).gameObject.SetActive(true);
			}
			return;
		}
		variable = DialogueLua.GetVariable("LE_21");
		if (((Result)(ref variable)).asInt == 1001)
		{
			if ((Object)(object)jackys[1] != (Object)null)
			{
				((Component)jackys[1]).gameObject.SetActive(true);
			}
			return;
		}
		variable = DialogueLua.GetVariable("LE_21");
		if (((Result)(ref variable)).asInt == 1002)
		{
			if ((Object)(object)jackys[2] != (Object)null)
			{
				((Component)jackys[2]).gameObject.SetActive(true);
			}
			npc.SetActive(true);
		}
		else
		{
			variable = DialogueLua.GetVariable("LE_21");
			if (((Result)(ref variable)).asInt == 4)
			{
				jackyPetShop.SetActive(true);
			}
		}
	}

	[SpecialName]
	public static JackyController CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator EFMGPCAJBDO(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		return new LOIPCLDDEHP(1)
		{
			_003C_003E4__this = this,
			num = ABAIKKGKDGD,
			time = LGLDPMAABLA
		};
	}

	[SpecialName]
	public static JackyController NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator OPMLOOMAJLB(int ABAIKKGKDGD, float LGLDPMAABLA)
	{
		yield return (object)new WaitForSeconds(LGLDPMAABLA);
		((Component)jackys[ABAIKKGKDGD]).gameObject.SetActive(false);
	}

	private void HBMDEHPHAPF()
	{
		((MonoBehaviour)this).StartCoroutine(OHFGPFAEPBG());
	}
}
