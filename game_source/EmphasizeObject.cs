using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EmphasizeObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MLNFCBOIMNI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject emphasizedGO;

		public EmphasizeObject _003C_003E4__this;

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
		public MLNFCBOIMNI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			EmphasizeObject emphasizeObject = _003C_003E4__this;
			Transform transform;
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
				goto IL_0048;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0048;
			case 3:
				_003C_003E1__state = -1;
				break;
			case 4:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0048:
				transform = emphasizedGO.transform;
				transform.localScale += new Vector3((emphasizeObject.scaleEmphasize - 1f) / emphasizeObject.timeEmphasize, (emphasizeObject.scaleEmphasize - 1f) / emphasizeObject.timeEmphasize, 0f) * Time.unscaledDeltaTime;
				if (!(emphasizedGO.transform.localScale.x > emphasizeObject.scaleEmphasize))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				emphasizedGO.transform.localScale = new Vector3(emphasizeObject.scaleEmphasize, emphasizeObject.scaleEmphasize, 1f);
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			}
			Transform transform2 = emphasizedGO.transform;
			transform2.localScale -= new Vector3((emphasizeObject.scaleEmphasize - 1f) / emphasizeObject.timeEmphasize, (emphasizeObject.scaleEmphasize - 1f) / emphasizeObject.timeEmphasize) * Time.unscaledDeltaTime;
			if (!(emphasizedGO.transform.localScale.x < 1f))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			}
			emphasizedGO.transform.localScale = Vector3.one;
			emphasizeObject.GEHIIBLIFBF = null;
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
	private GameObject emphasizedGO;

	[SerializeField]
	private float scaleEmphasize = 1.2f;

	[SerializeField]
	private float timeEmphasize = 0.12f;

	private Coroutine GEHIIBLIFBF;

	public void CJBADFNHCCM()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(FBGMFKBHMCL(emphasizedGO));
	}

	private IEnumerator PODJCNHHBCI(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	private IEnumerator MMGHKODEKBN(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void OAJDNMHIPCF(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EOCCJAFBAKL(BLLOFMCONIH));
	}

	public void NJIOFFBAIGF(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PDEKHOPOEAF(BLLOFMCONIH));
	}

	private IEnumerator FHBLFJEEMFC(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void MGFJGPPHLMJ()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(NMDFKPHPABF(emphasizedGO));
	}

	public void FLGEACOLNIN(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(COCCKLIKLEE(BLLOFMCONIH));
	}

	public void BEBIDMBMCDO()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(CDLAFBNOJKG(emphasizedGO));
	}

	private IEnumerator COCCKLIKLEE(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	private IEnumerator MPHDLMFEEOK(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void IEONEBNJGFO(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(LCBKLCHEPCB(BLLOFMCONIH));
	}

	private IEnumerator EBKDPHBIDPE(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void DGADIHAHGCH(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(COCCKLIKLEE(BLLOFMCONIH));
	}

	public void JJBICEGDGPH()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(COCCKLIKLEE(emphasizedGO));
	}

	private IEnumerator HLFBHIJAOEC(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void HALBNDDBLBL(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(OGAFBJONCMI(BLLOFMCONIH));
	}

	private IEnumerator IIBCNJLBIEC(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void GAKLPJGAHLI(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PDEKHOPOEAF(BLLOFMCONIH));
	}

	public void NCLPNHCAJPJ(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EGIMCFEONHJ(BLLOFMCONIH));
	}

	private IEnumerator OEOINHJHHEP(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void MHCEGNGILBD()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(ENAAAJHAGAE(emphasizedGO));
	}

	private IEnumerator EGKMBCCFOOF(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void BIAHHDNICLG(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(NMDFKPHPABF(BLLOFMCONIH));
	}

	public void NOKLCKECFIN()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(PDEKHOPOEAF(emphasizedGO));
	}

	private IEnumerator NMDFKPHPABF(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	private IEnumerator LCBKLCHEPCB(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void JPFLGNABMHH(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PDEKHOPOEAF(BLLOFMCONIH));
	}

	public void MBCNOGDLFFP(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(OEOINHJHHEP(BLLOFMCONIH));
	}

	private IEnumerator JDIPPBLFDOE(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	private IEnumerator PMCKKDEDFHF(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void BIKKOFFKDAN(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EBKDPHBIDPE(BLLOFMCONIH));
	}

	public void DCLOHJBMBPP()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(CDLAFBNOJKG(emphasizedGO));
	}

	private IEnumerator JBKFJLMPBAP(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	private IEnumerator MGLFEEIFNOM(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void CIJDOKKMFBB()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(JMLEJPBOLDI(emphasizedGO));
	}

	public void CHLGCNCACIE()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(MMGHKODEKBN(emphasizedGO));
	}

	public void EPMAAONHDBJ(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(HKEFKKDDCFI(BLLOFMCONIH));
	}

	private IEnumerator IDLLJMFANMO(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void CDOJIFFDMNP()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(HKEFKKDDCFI(emphasizedGO));
	}

	private IEnumerator FHKJFECEMIF(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	private IEnumerator ENAAAJHAGAE(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void AKENGLBGOFL()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(CDLAFBNOJKG(emphasizedGO));
	}

	private IEnumerator PPLKOKLNMGF(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void IDLGKJAAAHP()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(OHGICMAICOG(emphasizedGO));
	}

	public void CDKEMLJPHIH(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(JMLEJPBOLDI(BLLOFMCONIH));
	}

	public void StartEmphasize(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(OGAFBJONCMI(BLLOFMCONIH));
	}

	public void BCKHLLACMPD(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EGKMBCCFOOF(BLLOFMCONIH));
	}

	public void DIDIJOLEJKA(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(CDLAFBNOJKG(BLLOFMCONIH));
	}

	public void JCJLMAAEPNB(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EHLCKAJLIME(BLLOFMCONIH));
	}

	private IEnumerator EGIMCFEONHJ(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void OAGMMFIJCIE(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PHFNLEINPNG(BLLOFMCONIH));
	}

	private IEnumerator JMLEJPBOLDI(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	private IEnumerator MADMGFKGFHD(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void EEFLMJFOLID(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(MMGHKODEKBN(BLLOFMCONIH));
	}

	public void EECAHGMLMNB(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PHFNLEINPNG(BLLOFMCONIH));
	}

	private IEnumerator OGAFBJONCMI(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void OCNBDLFAILF()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(FHKJFECEMIF(emphasizedGO));
	}

	public void StartEmphasize()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(OGAFBJONCMI(emphasizedGO));
	}

	public void LLNNGDBIODB(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(FHKJFECEMIF(BLLOFMCONIH));
	}

	public void MGAICIJCDBJ(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(IIBCNJLBIEC(BLLOFMCONIH));
	}

	public void ONJNJKHOJAK(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(MADMGFKGFHD(BLLOFMCONIH));
	}

	public void DLLDDAMMOFH(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EGKMBCCFOOF(BLLOFMCONIH));
	}

	private IEnumerator PPCEOOODIBB(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void NDBEIJIFDNI()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(FHBLFJEEMFC(emphasizedGO));
	}

	public void FAJNKMFAFOP()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(HLFBHIJAOEC(emphasizedGO));
	}

	public void ANJEKHNMNHB()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(EGIMCFEONHJ(emphasizedGO));
	}

	public void LGDOLOGPDDK()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(COCCKLIKLEE(emphasizedGO));
	}

	private IEnumerator HKEFKKDDCFI(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	private IEnumerator PHFNLEINPNG(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void GEHKLHOAKCE(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(EBKDPHBIDPE(BLLOFMCONIH));
	}

	private IEnumerator CDLAFBNOJKG(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void ADMBOJCCGFG(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PODJCNHHBCI(BLLOFMCONIH));
	}

	private IEnumerator FHMBKJHKOHJ(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void CIDDKJKLAOC(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(FBGMFKBHMCL(BLLOFMCONIH));
	}

	public void ADKGOENPLJE(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PDEKHOPOEAF(BLLOFMCONIH));
	}

	private IEnumerator EOCCJAFBAKL(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	private IEnumerator FBGMFKBHMCL(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	private IEnumerator EHLCKAJLIME(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	public void LEOEIMBJIKN(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(JDIPPBLFDOE(BLLOFMCONIH));
	}

	private IEnumerator OHGICMAICOG(GameObject BLLOFMCONIH)
	{
		return new MLNFCBOIMNI(1)
		{
			_003C_003E4__this = this,
			emphasizedGO = BLLOFMCONIH
		};
	}

	private IEnumerator PDEKHOPOEAF(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void JOGHMJMEEAM(GameObject BLLOFMCONIH)
	{
		((MonoBehaviour)this).StartCoroutine(PMCKKDEDFHF(BLLOFMCONIH));
	}

	private IEnumerator POPJDNAFPIB(GameObject BLLOFMCONIH)
	{
		yield return null;
		while (true)
		{
			Transform transform = BLLOFMCONIH.transform;
			transform.localScale += new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize, 0f) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x > scaleEmphasize)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = new Vector3(scaleEmphasize, scaleEmphasize, 1f);
		yield return null;
		while (true)
		{
			Transform transform2 = BLLOFMCONIH.transform;
			transform2.localScale -= new Vector3((scaleEmphasize - 1f) / timeEmphasize, (scaleEmphasize - 1f) / timeEmphasize) * Time.unscaledDeltaTime;
			if (BLLOFMCONIH.transform.localScale.x < 1f)
			{
				break;
			}
			yield return null;
		}
		BLLOFMCONIH.transform.localScale = Vector3.one;
		GEHIIBLIFBF = null;
	}

	public void JIGJHGIKOAG()
	{
		if (GEHIIBLIFBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(GEHIIBLIFBF);
		}
		GEHIIBLIFBF = ((MonoBehaviour)this).StartCoroutine(PMCKKDEDFHF(emphasizedGO));
	}
}
