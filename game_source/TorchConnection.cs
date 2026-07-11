using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TorchConnection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IDPPPPBBGAP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TorchConnection _003C_003E4__this;

		public Transform source;

		public Transform target;

		public Action onArrival;

		private Vector3 _003Cstart_003E5__2;

		private Vector3 _003Cend_003E5__3;

		private Vector3 _003Cdirection_003E5__4;

		private float _003Celapsed_003E5__5;

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
		public IDPPPPBBGAP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected O, but got Unknown
			int num = _003C_003E1__state;
			TorchConnection torchConnection = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				if ((Object)(object)torchConnection.activatedLR == (Object)null)
				{
					return false;
				}
				_003Cstart_003E5__2 = source.position;
				_003Cend_003E5__3 = target.position;
				_003Cstart_003E5__2.y -= (float)torchConnection.FGEEHNDINGK * torchConnection.PMGOLLFCKAJ;
				_003Cend_003E5__3.y -= (float)torchConnection.FGEEHNDINGK * torchConnection.PMGOLLFCKAJ;
				Vector3 val = _003Cend_003E5__3 - _003Cstart_003E5__2;
				_003Cdirection_003E5__4 = ((Vector3)(ref val)).normalized;
				Vector3.Distance(_003Cstart_003E5__2, _003Cend_003E5__3);
				if (!((Object)(object)torchConnection.activatedLR != (Object)null))
				{
					break;
				}
				((Renderer)torchConnection.activatedLR).enabled = true;
				((Component)torchConnection.activatedLR).gameObject.SetActive(true);
				if ((Object)(object)torchConnection.particleParent != (Object)null)
				{
					((Component)torchConnection.particleParent).gameObject.SetActive(true);
				}
				Color color = ((Renderer)torchConnection.activatedLR).material.color;
				color.a = 1f;
				((Renderer)torchConnection.activatedLR).material.color = color;
				_003Celapsed_003E5__5 = 0f;
				goto IL_021e;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_021e;
			case 2:
				{
					_003C_003E1__state = -1;
					torchConnection.AOMMNGKJMDA = null;
					break;
				}
				IL_021e:
				if (_003Celapsed_003E5__5 < torchConnection.animationDuration)
				{
					_003Celapsed_003E5__5 += Time.deltaTime;
					float dCGBADKLANM = Mathf.Clamp01(_003Celapsed_003E5__5 / torchConnection.animationDuration);
					float num2 = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
					Vector3 val2 = Vector3.Lerp(_003Cstart_003E5__2, _003Cend_003E5__3, num2);
					float num3 = torchConnection.signalLength * 0.5f;
					Vector3 val3 = val2 - _003Cdirection_003E5__4 * num3;
					Vector3 val4 = val2 + _003Cdirection_003E5__4 * num3;
					torchConnection.activatedLR.SetPosition(0, val3);
					torchConnection.activatedLR.SetPosition(1, val4);
					if ((Object)(object)torchConnection.particleParent != (Object)null)
					{
						torchConnection.particleParent.position = val2;
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				((Renderer)torchConnection.activatedLR).enabled = false;
				((Component)torchConnection.activatedLR).gameObject.SetActive(false);
				if ((Object)(object)torchConnection.particleParent != (Object)null)
				{
					((Component)torchConnection.particleParent).gameObject.SetActive(false);
				}
				onArrival?.Invoke();
				_003C_003E2__current = (object)new WaitForSecondsRealtime(0.1f);
				_003C_003E1__state = 2;
				return true;
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
	private LineRenderer[] lineRenderers;

	[SerializeField]
	private LineRenderer activatedLR;

	[SerializeField]
	private float animationDuration = 0.3f;

	[SerializeField]
	private float signalLength = 0.5f;

	[SerializeField]
	private Transform particleParent;

	private Coroutine AOMMNGKJMDA;

	private float PMGOLLFCKAJ = 1f / 48f;

	private float GNKAGGHMJBD = 1f;

	private float EMIHAFNEDHP = 1f;

	private int FGEEHNDINGK = 5;

	public bool KOCCDCPBKCF => AOMMNGKJMDA != null;

	private void PFBKNIGLHKH()
	{
		for (int i = 1; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = false;
		}
	}

	public void AnimateConnection(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(FMAAMCJBEPL(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void BMPKMPHBENH(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	public void GPAEOABJHOA(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(BJAKIENGJGG(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void MBKMCBBCEEB()
	{
		DNMIFBGBHPF();
	}

	private IEnumerator FMAAMCJBEPL(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void Initialize(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		OGMLHCIMMDL();
		NIOGNIKNOGJ(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = false;
			((Component)activatedLR).gameObject.SetActive(false);
		}
	}

	[SpecialName]
	public bool MOHNGFMBJFA()
	{
		return AOMMNGKJMDA != null;
	}

	private IEnumerator FHPEGHAJJIH(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		return new IDPPPPBBGAP(1)
		{
			_003C_003E4__this = this,
			source = ODHLEHJPGKP,
			target = AEGIODEOOIJ,
			onArrival = BAPLJENDJJN
		};
	}

	[SpecialName]
	public bool AHADBHGACJL()
	{
		return AOMMNGKJMDA != null;
	}

	private void MNNBNBOIJOF(Vector3 CBNBHOHFKMF, Vector3 NJMCDGFPCAG)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		CBNBHOHFKMF.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		NJMCDGFPCAG.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = NJMCDGFPCAG - CBNBHOHFKMF;
		Vector3 val2 = ((((Vector3)(ref val)).sqrMagnitude > 1933f) ? ((Vector3)(ref val)).normalized : Vector3.right);
		Vector3 val3 = default(Vector3);
		((Vector3)(ref val3))._002Ector(0f - val2.y, val2.x, 1298f);
		if (Vector3.Dot(val3, Vector3.up) < 237f)
		{
			val3 = -val3;
		}
		Vector3 val4 = val3 * (PMGOLLFCKAJ * GNKAGGHMJBD);
		Vector3 val5 = -val3 * (PMGOLLFCKAJ * EMIHAFNEDHP);
		for (int i = 0; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = false;
			switch (i)
			{
			case 1:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val4);
				lineRenderers[i].SetPosition(0, NJMCDGFPCAG + val4);
				break;
			case 8:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val5);
				lineRenderers[i].SetPosition(0, NJMCDGFPCAG + val5);
				break;
			default:
				lineRenderers[i].SetPosition(1, CBNBHOHFKMF);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG);
				break;
			}
		}
	}

	public void MIMGPIANHNJ(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		EOPGFFBKDKP();
		FAHHMELNNEK(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = true;
			((Component)activatedLR).gameObject.SetActive(true);
		}
	}

	public void Clean()
	{
		OGMLHCIMMDL();
	}

	public void ANIJHADPDKI(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	public void NGFHBHKCFPJ()
	{
		PFBKNIGLHKH();
	}

	public void GGDBBJPJLFD(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		BOHBEEKAAKP();
		FDMCIDBJBEJ(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = false;
			((Component)activatedLR).gameObject.SetActive(false);
		}
	}

	private IEnumerator NGHHMKBKDBL(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		return new IDPPPPBBGAP(1)
		{
			_003C_003E4__this = this,
			source = ODHLEHJPGKP,
			target = AEGIODEOOIJ,
			onArrival = BAPLJENDJJN
		};
	}

	public void DEBOKGKPPBB(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(FMAAMCJBEPL(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void FCJMDJLPAND()
	{
		DNMIFBGBHPF();
	}

	private void DNMIFBGBHPF()
	{
		for (int i = 1; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = false;
		}
	}

	public void FOHHKGJFJAE(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		EOPGFFBKDKP();
		MNNBNBOIJOF(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = false;
			((Component)activatedLR).gameObject.SetActive(false);
		}
	}

	private IEnumerator CNHJANLHDMD(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void GBJGKICAKKK()
	{
		EOPGFFBKDKP();
	}

	public void KCOFDEFLIJL(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	public void PGNIAINKFHC(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	private void NIOGNIKNOGJ(Vector3 CBNBHOHFKMF, Vector3 NJMCDGFPCAG)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		CBNBHOHFKMF.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		NJMCDGFPCAG.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = NJMCDGFPCAG - CBNBHOHFKMF;
		Vector3 val2 = ((((Vector3)(ref val)).sqrMagnitude > 1E-06f) ? ((Vector3)(ref val)).normalized : Vector3.right);
		Vector3 val3 = default(Vector3);
		((Vector3)(ref val3))._002Ector(0f - val2.y, val2.x, 0f);
		if (Vector3.Dot(val3, Vector3.up) < 0f)
		{
			val3 = -val3;
		}
		Vector3 val4 = val3 * (PMGOLLFCKAJ * GNKAGGHMJBD);
		Vector3 val5 = -val3 * (PMGOLLFCKAJ * EMIHAFNEDHP);
		for (int i = 0; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = true;
			switch (i)
			{
			case 1:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val4);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG + val4);
				break;
			case 2:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val5);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG + val5);
				break;
			default:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG);
				break;
			}
		}
	}

	private IEnumerator GFEKNNMJMLM(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void HPKABBDDOOF(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	public void FLFPGEFHGLM(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(APCJDCFHHEG(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void MAJCLJIBLIM(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(BJAKIENGJGG(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void KGJIGNKBENF(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	private IEnumerator CMANCHEAKCJ(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void NKGHPMCJCLC()
	{
		BOHBEEKAAKP();
	}

	public void AJNKBNGNNEP()
	{
		PFBKNIGLHKH();
	}

	private IEnumerator APCJDCFHHEG(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void KHPDEPGGFIA(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(FHPEGHAJJIH(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	private IEnumerator HHFBHJLKMBN(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		return new IDPPPPBBGAP(1)
		{
			_003C_003E4__this = this,
			source = ODHLEHJPGKP,
			target = AEGIODEOOIJ,
			onArrival = BAPLJENDJJN
		};
	}

	[SpecialName]
	public bool OJPOJAHGDHO()
	{
		return AOMMNGKJMDA != null;
	}

	private IEnumerator BJAKIENGJGG(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	private IEnumerator FGOGLNEKDNH(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		return new IDPPPPBBGAP(1)
		{
			_003C_003E4__this = this,
			source = ODHLEHJPGKP,
			target = AEGIODEOOIJ,
			onArrival = BAPLJENDJJN
		};
	}

	public void LAOANFMBBFK()
	{
		PFBKNIGLHKH();
	}

	public void JEMFMIHMAOI(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		EOPGFFBKDKP();
		NKJOHDEKNDJ(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = true;
			((Component)activatedLR).gameObject.SetActive(true);
		}
	}

	public void FCAKJGEHOGN(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(FMAAMCJBEPL(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void DNNGLPLEEMJ(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		PFBKNIGLHKH();
		NIOGNIKNOGJ(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = true;
			((Component)activatedLR).gameObject.SetActive(false);
		}
	}

	public void AKHFECFPCBC()
	{
		DNMIFBGBHPF();
	}

	private IEnumerator NNDCDEOPICA(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void CCHKFGHJANB(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	private IEnumerator HCALOPNJMOB(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		return new IDPPPPBBGAP(1)
		{
			_003C_003E4__this = this,
			source = ODHLEHJPGKP,
			target = AEGIODEOOIJ,
			onArrival = BAPLJENDJJN
		};
	}

	private void OGMLHCIMMDL()
	{
		for (int i = 0; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = false;
		}
	}

	private void FDMCIDBJBEJ(Vector3 CBNBHOHFKMF, Vector3 NJMCDGFPCAG)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		CBNBHOHFKMF.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		NJMCDGFPCAG.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = NJMCDGFPCAG - CBNBHOHFKMF;
		Vector3 val2 = ((((Vector3)(ref val)).sqrMagnitude > 1019f) ? ((Vector3)(ref val)).normalized : Vector3.right);
		Vector3 val3 = default(Vector3);
		((Vector3)(ref val3))._002Ector(0f - val2.y, val2.x, 1770f);
		if (Vector3.Dot(val3, Vector3.up) < 944f)
		{
			val3 = -val3;
		}
		Vector3 val4 = val3 * (PMGOLLFCKAJ * GNKAGGHMJBD);
		Vector3 val5 = -val3 * (PMGOLLFCKAJ * EMIHAFNEDHP);
		for (int i = 0; i < lineRenderers.Length; i += 0)
		{
			((Renderer)lineRenderers[i]).enabled = true;
			switch (i)
			{
			case 0:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val4);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG + val4);
				break;
			case 4:
				lineRenderers[i].SetPosition(1, CBNBHOHFKMF + val5);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG + val5);
				break;
			default:
				lineRenderers[i].SetPosition(1, CBNBHOHFKMF);
				lineRenderers[i].SetPosition(0, NJMCDGFPCAG);
				break;
			}
		}
	}

	public void EOADCHLNLPK(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		BOHBEEKAAKP();
		NKJOHDEKNDJ(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = true;
			((Component)activatedLR).gameObject.SetActive(true);
		}
	}

	private IEnumerator EEMCNCAAEIE(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void BFEGJENGAAM()
	{
		DNMIFBGBHPF();
	}

	private void FAHHMELNNEK(Vector3 CBNBHOHFKMF, Vector3 NJMCDGFPCAG)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		CBNBHOHFKMF.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		NJMCDGFPCAG.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = NJMCDGFPCAG - CBNBHOHFKMF;
		Vector3 val2 = ((((Vector3)(ref val)).sqrMagnitude > 309f) ? ((Vector3)(ref val)).normalized : Vector3.right);
		Vector3 val3 = default(Vector3);
		((Vector3)(ref val3))._002Ector(0f - val2.y, val2.x, 1307f);
		if (Vector3.Dot(val3, Vector3.up) < 1612f)
		{
			val3 = -val3;
		}
		Vector3 val4 = val3 * (PMGOLLFCKAJ * GNKAGGHMJBD);
		Vector3 val5 = -val3 * (PMGOLLFCKAJ * EMIHAFNEDHP);
		for (int i = 1; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = false;
			switch (i)
			{
			case 0:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val4);
				lineRenderers[i].SetPosition(0, NJMCDGFPCAG + val4);
				break;
			case 3:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val5);
				lineRenderers[i].SetPosition(0, NJMCDGFPCAG + val5);
				break;
			default:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF);
				lineRenderers[i].SetPosition(0, NJMCDGFPCAG);
				break;
			}
		}
	}

	[SpecialName]
	public bool GPGGMDANLAD()
	{
		return AOMMNGKJMDA != null;
	}

	public void ENPJHFLIALN(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		OGMLHCIMMDL();
		FAHHMELNNEK(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = true;
			((Component)activatedLR).gameObject.SetActive(true);
		}
	}

	private void NKJOHDEKNDJ(Vector3 CBNBHOHFKMF, Vector3 NJMCDGFPCAG)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		CBNBHOHFKMF.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		NJMCDGFPCAG.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = NJMCDGFPCAG - CBNBHOHFKMF;
		Vector3 val2 = ((((Vector3)(ref val)).sqrMagnitude > 1457f) ? ((Vector3)(ref val)).normalized : Vector3.right);
		Vector3 val3 = default(Vector3);
		((Vector3)(ref val3))._002Ector(0f - val2.y, val2.x, 318f);
		if (Vector3.Dot(val3, Vector3.up) < 645f)
		{
			val3 = -val3;
		}
		Vector3 val4 = val3 * (PMGOLLFCKAJ * GNKAGGHMJBD);
		Vector3 val5 = -val3 * (PMGOLLFCKAJ * EMIHAFNEDHP);
		for (int i = 1; i < lineRenderers.Length; i += 0)
		{
			((Renderer)lineRenderers[i]).enabled = true;
			switch (i)
			{
			case 1:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val4);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG + val4);
				break;
			case 0:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF + val5);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG + val5);
				break;
			default:
				lineRenderers[i].SetPosition(0, CBNBHOHFKMF);
				lineRenderers[i].SetPosition(1, NJMCDGFPCAG);
				break;
			}
		}
	}

	public void SetActive(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	private IEnumerator MLGFNNJKLFC(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if ((Object)(object)activatedLR == (Object)null)
		{
			yield break;
		}
		Vector3 start = ODHLEHJPGKP.position;
		Vector3 end = AEGIODEOOIJ.position;
		start.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		end.y -= (float)FGEEHNDINGK * PMGOLLFCKAJ;
		Vector3 val = end - start;
		Vector3 direction = ((Vector3)(ref val)).normalized;
		Vector3.Distance(start, end);
		if (!((Object)(object)activatedLR != (Object)null))
		{
			yield break;
		}
		((Renderer)activatedLR).enabled = true;
		((Component)activatedLR).gameObject.SetActive(true);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(true);
		}
		Color color = ((Renderer)activatedLR).material.color;
		color.a = 1f;
		((Renderer)activatedLR).material.color = color;
		float elapsed = 0f;
		while (elapsed < animationDuration)
		{
			elapsed += Time.deltaTime;
			float dCGBADKLANM = Mathf.Clamp01(elapsed / animationDuration);
			float num = Tweener.AAFMLNNBILN(EaseType.EaseInOutQuad, dCGBADKLANM);
			Vector3 val2 = Vector3.Lerp(start, end, num);
			float num2 = signalLength * 0.5f;
			Vector3 val3 = val2 - direction * num2;
			Vector3 val4 = val2 + direction * num2;
			activatedLR.SetPosition(0, val3);
			activatedLR.SetPosition(1, val4);
			if ((Object)(object)particleParent != (Object)null)
			{
				particleParent.position = val2;
			}
			yield return null;
		}
		((Renderer)activatedLR).enabled = false;
		((Component)activatedLR).gameObject.SetActive(false);
		if ((Object)(object)particleParent != (Object)null)
		{
			((Component)particleParent).gameObject.SetActive(false);
		}
		BAPLJENDJJN?.Invoke();
		yield return (object)new WaitForSecondsRealtime(0.1f);
		AOMMNGKJMDA = null;
	}

	public void LJJEPFCFGLJ()
	{
		EOPGFFBKDKP();
	}

	public void KILDOFBNGAM(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(FHPEGHAJJIH(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	private void EOPGFFBKDKP()
	{
		for (int i = 0; i < lineRenderers.Length; i += 0)
		{
			((Renderer)lineRenderers[i]).enabled = true;
		}
	}

	public void PNICBNEGOPF(bool DMBFKFLDDLH)
	{
		((Component)this).gameObject.SetActive(DMBFKFLDDLH);
	}

	[SpecialName]
	public bool OKOHPOKHECC()
	{
		return AOMMNGKJMDA != null;
	}

	public void FIOICKPIJMB()
	{
		EOPGFFBKDKP();
	}

	public void CNNEIJHBAIE(Transform ODHLEHJPGKP, Transform AEGIODEOOIJ, Action BAPLJENDJJN)
	{
		if (AOMMNGKJMDA != null)
		{
			((MonoBehaviour)this).StopCoroutine(AOMMNGKJMDA);
		}
		AOMMNGKJMDA = ((MonoBehaviour)this).StartCoroutine(HHFBHJLKMBN(ODHLEHJPGKP, AEGIODEOOIJ, BAPLJENDJJN));
	}

	public void DELDBJOBCCG(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		DNMIFBGBHPF();
		FAHHMELNNEK(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = false;
			((Component)activatedLR).gameObject.SetActive(true);
		}
	}

	public void HJCOAJEIABK(Transform FOGBPKNLFAF, Transform COAIGDJGCCN)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		BOHBEEKAAKP();
		FAHHMELNNEK(FOGBPKNLFAF.position, COAIGDJGCCN.position);
		if ((Object)(object)activatedLR != (Object)null)
		{
			((Renderer)activatedLR).enabled = false;
			((Component)activatedLR).gameObject.SetActive(true);
		}
	}

	private void BOHBEEKAAKP()
	{
		for (int i = 0; i < lineRenderers.Length; i++)
		{
			((Renderer)lineRenderers[i]).enabled = true;
		}
	}
}
