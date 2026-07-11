using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BridgeDoorController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ADONPIJENPG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BridgeDoorController _003C_003E4__this;

		public bool accelerate;

		public Vector3 targetLocalPos;

		public bool opening;

		private Vector3 _003Cstart_003E5__2;

		private float _003Celapsed_003E5__3;

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
		public ADONPIJENPG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			BridgeDoorController bridgeDoorController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Cstart_003E5__2 = bridgeDoorController.doorToMove.localPosition;
				_003Celapsed_003E5__3 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Celapsed_003E5__3 < bridgeDoorController.animationDuration)
			{
				float num2 = _003Celapsed_003E5__3 / bridgeDoorController.animationDuration;
				num2 = ((!accelerate) ? Mathf.SmoothStep(0f, 1f, num2) : (num2 * num2));
				bridgeDoorController.doorToMove.localPosition = Vector3.Lerp(_003Cstart_003E5__2, targetLocalPos, num2);
				_003Celapsed_003E5__3 += Time.deltaTime;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			bridgeDoorController.doorToMove.localPosition = targetLocalPos;
			if (opening)
			{
				((Behaviour)bridgeDoorController.doorCollider).enabled = !opening;
				((Renderer)bridgeDoorController.doorSpriteRenderer).sortingOrder = (opening ? 1 : 0);
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
	private Transform doorToMove;

	[SerializeField]
	private Transform closedLocalPos;

	[SerializeField]
	private Transform openLocalPos;

	[SerializeField]
	private float animationDuration = 1f;

	[SerializeField]
	private Collider2D doorCollider;

	[SerializeField]
	private SpriteRenderer doorSpriteRenderer;

	private Coroutine KAOHHMPKOKC;

	public void PEAEBKGAFKC(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void POOOEMCKINP(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void PCNPICIDNMN()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 116f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(NMMBHCONHIH(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void OMBLHPMFLKP()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1681f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(JJHKPGJGNPN(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void GLEMNBOEENA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1686f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(LCIKFDNNODG(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	private IEnumerator NMMBHCONHIH(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator PCHHCNGMEDL(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void FHFHKHNELBK(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void MBHGKJMGCGB(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void ELEKCPACIND(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void MIGFMJEHCML(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void LAJJJKPOHCP()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1414f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(IAHMJLAKCMM(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void OKCIENINCPK()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 89f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OPPAFNCKMDD(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void IIBPLANEJCP()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1155f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(DHMDLENPODE(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void ODJKPBMEIEF(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator CADBGGHOKGH(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void EMKOJONOJKN()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1151f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(GOJFLDOBHPL(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void PPIMCADOACF(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator INBNIEPCDBP(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	private IEnumerator AABOGOAFPHO(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void MCFHJFPLBBD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1822f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(JAPOBFPNBNG(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void IOLHKGPBLJL()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 707f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OCPBBKKELFL(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	private IEnumerator JJHKPGJGNPN(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void HHMLCNCGOHK(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator KBDJMLPJPEB(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void LHHADAHHHND(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void BCJJLPJDLJC()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 162f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(LCIKFDNNODG(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	private IEnumerator NEIOHDFHBNI(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void DOPCBPPKDPM()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1327f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(EFEHBMDAGNK(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void LINFOJNEDBM(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator BEFPOIHDIBD(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	private IEnumerator OOOJAPHEGGK(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void AFPOHJDDGCF()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1508f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(EADOAPBFCJK(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void JKFAJGKLNKK(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void ENFHKHNICAD(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator OPPAFNCKMDD(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator DHMDLENPODE(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	private IEnumerator DLNHOGCJCKJ(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void ANCPPGBGHHB()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1882f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(DHMDLENPODE(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	private IEnumerator GJOGDJBEGJK(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator LJLPAHJBANM(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void KCPPENJAHIL(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator OCPBBKKELFL(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void DAFHBKBBMDH(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void NFDIDPGEPLE()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 649f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(MDHHMLKMNNJ(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void IBANIFGBPPD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1191f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OEBELAKNGKI(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void OKPNDBINMMA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1990f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(BOOMBGEKIEB(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void DBMFKLODPDP(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void BCMMJNMMEPM(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void BFMNPAIFHAE(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator GBDCJIJOEKB(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void IAMJHGBIHHF()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1934f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(LCIKFDNNODG(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	private IEnumerator MDHHMLKMNNJ(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void MBBMPMLFBEE()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 440f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(CADBGGHOKGH(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void OMPABIFHHON()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1327f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(BEFPOIHDIBD(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void JCJGJOEDMLD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1917f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OPPAFNCKMDD(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	private IEnumerator LCCEGECKINF(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void BJIDPBNLHOH(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void EPHGCBCBDAB()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1089f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(LCIKFDNNODG(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void BDNEKBAMAEI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 437f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(EFEHBMDAGNK(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void LPLNLDMCAMG()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1702f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OCPBBKKELFL(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void OPPKMPABMIA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 311f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OOOJAPHEGGK(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void CloseDoor()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(EADOAPBFCJK(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void EEKMADLGDPN(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void PILENGHAKLI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 689f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(JJHKPGJGNPN(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void GIADHAHMOFO(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void OJABECPMJDB(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void OLMGNDNGODH(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void DPHDGLLPAOG()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 123f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(ENAPNGCNDCC(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void LGLEMEACMMA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 183f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(NEIOHDFHBNI(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void OCCOBGNNKDA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 974f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(IAHMJLAKCMM(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void AMMDCGIGLJJ(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void BDNLABJINND(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator DIFKJBACHLL(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator BOOMBGEKIEB(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator DALNCIPOPDF(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void BCCJAFHPAMG()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 827f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(GBDCJIJOEKB(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void IGFLJEKMGPN(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void NFCPNOPGCEA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1236f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OOOJAPHEGGK(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void GHKGNLPCKFE()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1572f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(DHMDLENPODE(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void FGOADEEHBBI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 819f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(FGHCAOPHFHM(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void MNEKMFLPKOD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 515f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(LCIKFDNNODG(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	private IEnumerator JAPOBFPNBNG(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void EFBNBLIBBBI(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator OEBELAKNGKI(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator LCIKFDNNODG(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void BHKHPKAIOJP(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator IAHMJLAKCMM(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void FIOLDCLKDBP()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1439f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(IAHMJLAKCMM(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void JBNGOIKJBNL()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1155f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(ENAPNGCNDCC(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void OOOFNICLGHD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1488f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(ENAPNGCNDCC(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void JPDCFCKELGK(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void DJKGHAHDKMA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 915f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(BEFPOIHDIBD(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void FLMAOOMNAND()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1147f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(EADOAPBFCJK(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	private IEnumerator FGHCAOPHFHM(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	private IEnumerator GOJFLDOBHPL(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void IMGKALIGLAN(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void BOBADDFEAPD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 179f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(DLNHOGCJCKJ(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void DOJGLGOFLML()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1571f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(NMMBHCONHIH(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void JNFEAHKOALJ()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 687f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(GBDCJIJOEKB(KCLDPDNCNOA: true, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void BKAIINAFHNI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1130f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(HHGPOAOIOMA(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	private IEnumerator ENAPNGCNDCC(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	private IEnumerator LFNHNFOOLCD(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	private IEnumerator EADOAPBFCJK(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		Vector3 start = doorToMove.localPosition;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			float num = elapsed / animationDuration;
			num = ((!GPEDLPHDNMH) ? Mathf.SmoothStep(0f, 1f, num) : (num * num));
			doorToMove.localPosition = Vector3.Lerp(start, JLALFHIKPBP, num);
			elapsed += Time.deltaTime;
			yield return null;
		}
		doorToMove.localPosition = JLALFHIKPBP;
		if (KCLDPDNCNOA)
		{
			((Behaviour)doorCollider).enabled = !KCLDPDNCNOA;
			((Renderer)doorSpriteRenderer).sortingOrder = (KCLDPDNCNOA ? 1 : 0);
		}
	}

	public void EGMNKOJILJD()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 413f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(OEBELAKNGKI(KCLDPDNCNOA: false, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void KNFIACOABNA()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 1496f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(ENAPNGCNDCC(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	public void LFGDLPAFFDA(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void NMIKILCMIGO(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void CHEKPIJGLCI()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 870f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(LCCEGECKINF(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void JKFEFFIANOO(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	public void GMDOJPJMCKM()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 14f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(AABOGOAFPHO(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void LAIOJOBFCFF()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 448f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(MDHHMLKMNNJ(KCLDPDNCNOA: false, closedLocalPos.localPosition, GPEDLPHDNMH: true));
	}

	public void OpenDoor()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (KAOHHMPKOKC != null)
		{
			((MonoBehaviour)this).StopCoroutine(KAOHHMPKOKC);
		}
		animationDuration = 3f;
		KAOHHMPKOKC = ((MonoBehaviour)this).StartCoroutine(EADOAPBFCJK(KCLDPDNCNOA: true, openLocalPos.localPosition, GPEDLPHDNMH: false));
	}

	private IEnumerator HHGPOAOIOMA(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void KCOOFJNBGGA(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}

	private IEnumerator EFEHBMDAGNK(bool KCLDPDNCNOA, Vector3 JLALFHIKPBP, bool GPEDLPHDNMH)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new ADONPIJENPG(1)
		{
			_003C_003E4__this = this,
			opening = KCLDPDNCNOA,
			targetLocalPos = JLALFHIKPBP,
			accelerate = GPEDLPHDNMH
		};
	}

	public void SetDoorInitialPosition(bool KMBGLHKHBII)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)doorToMove != (Object)null)
		{
			doorToMove.localPosition = (KMBGLHKHBII ? openLocalPos.localPosition : closedLocalPos.localPosition);
		}
	}
}
