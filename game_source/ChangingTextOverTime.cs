using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;

public class ChangingTextOverTime : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MCGNJKJFBGJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChangingTextOverTime _003C_003E4__this;

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
		public MCGNJKJFBGJ(int _003C_003E1__state)
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
			ChangingTextOverTime changingTextOverTime = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(changingTextOverTime.secondsBetweenChanges);
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				int gKJBCHAHDKK = changingTextOverTime.GKJBCHAHDKK;
				while (changingTextOverTime.GKJBCHAHDKK == gKJBCHAHDKK)
				{
					changingTextOverTime.GKJBCHAHDKK = Random.Range(0, changingTextOverTime.lineSelection.textID.Length);
				}
				((TMP_Text)changingTextOverTime.HAKKEHMOGGH).text = LocalizationManager.GetTranslation(changingTextOverTime.lineSelection.textID[changingTextOverTime.GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
				((MonoBehaviour)changingTextOverTime).StartCoroutine(changingTextOverTime.OPNAAFKLELE());
				return false;
			}
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

	private TextMeshProUGUI HAKKEHMOGGH;

	[SerializeField]
	private SO_TextSelection lineSelection;

	[SerializeField]
	private float secondsBetweenChanges;

	private int GKJBCHAHDKK;

	private void OAEJGGFFCBO()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private IEnumerator LFFDPAPFOOF()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private void LJLKBKEADGI()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 0, true, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(LFFDPAPFOOF());
			}
		}
	}

	private void BDGCFCPFKKE()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 0, false, true, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(KAMFEBJDOOL());
			}
		}
	}

	private IEnumerator PGJNNBDHOHE()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJOJLHCDFPP()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 1, true, false, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(PGJNNBDHOHE());
			}
		}
	}

	private void EOGHJNGJFID()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, false, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(BFCGFKLBDGF());
			}
		}
	}

	private void IIPKPMPGLOL()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void BAKDKFKNHDE()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void Awake()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void GONDLJKGLGO()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void HCEDMLJNOBL()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(EFPAOGPLGCC());
			}
		}
	}

	private void LNPDALMANFB()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void JDMMNLKLMAA()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void IMIONHLAKIH()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 1, true, false, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(OACNOOLDFIM());
			}
		}
	}

	private void AEPBFPCHGPP()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 0, false, true, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(LFFDPAPFOOF());
			}
		}
	}

	private void OIBDBLCLACB()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(JKLDNFJMJBP());
			}
		}
	}

	private void NNBIAIMPNGL()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, false, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(OACNOOLDFIM());
			}
		}
	}

	private IEnumerator DLCFFMNBANM()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EBNENBFLEKB()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, false, true, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(LHOAHPAFGCB());
			}
		}
	}

	private IEnumerator OIEBDKGDNBD()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private IEnumerator HHIBEEICAFO()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GIEADIIBJDK()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NFPCLLOKGOL()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private void EGACIHOKJLH()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, false, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(LHOAHPAFGCB());
			}
		}
	}

	private void AGLMGDNBHBF()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void BFJOEMCBJJO()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void KJHKBGDJNDC()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void BDJKNKIOPIJ()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, true, true, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(DLCFFMNBANM());
			}
		}
	}

	private void KACEOJDPLKB()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, false, true, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(BBDKMCDAGAO());
			}
		}
	}

	private IEnumerator OPNAAFKLELE()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private void GJMLHECPGBP()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, false, true, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(BFCGFKLBDGF());
			}
		}
	}

	private void OKAPGNGLOHO()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 1, false, true, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(KAMFEBJDOOL());
			}
		}
	}

	private IEnumerator HKAEDEHLFJD()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private IEnumerator BFCGFKLBDGF()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CHIJGHPHCNA()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(EFPAOGPLGCC());
			}
		}
	}

	private void KLHIMJFCHPD()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void HINGECEDJAP()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private IEnumerator JKLDNFJMJBP()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private void DADPOICMNPI()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void EIMIDCDEIDD()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void CLNBMOPMNOF()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void CEIIFHIBIFI()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 0, true, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(DLCFFMNBANM());
			}
		}
	}

	private void AHFGOOHOLEL()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, false, true, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(NFPCLLOKGOL());
			}
		}
	}

	private IEnumerator FACLINJPEBN()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private IEnumerator LHOAHPAFGCB()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private void JDAMCMODANB()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void MFGANCCJFJK()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void EFCNKPEPELL()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void CLGBFOIBANN()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private IEnumerator JGKCLJCAIOL()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private IEnumerator FELLNKPBIED()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BBDKMCDAGAO()
	{
		yield return (object)new WaitForSeconds(secondsBetweenChanges);
		int gKJBCHAHDKK = GKJBCHAHDKK;
		while (GKJBCHAHDKK == gKJBCHAHDKK)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
		}
		((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
		((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
	}

	private void IABEJCPMJOF()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, false, true, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(GIEADIIBJDK());
			}
		}
	}

	private IEnumerator OACNOOLDFIM()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BGBFJPJLPMF()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void NAOBODGBECL()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void HPJBLOPJIMI()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void PFLBPMIEKGF()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 1, false, false, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(OIEBDKGDNBD());
			}
		}
	}

	private void Start()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(0, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], true, 0, true, false, (GameObject)null, (string)null, true);
			if (lineSelection.textID.Length > 1)
			{
				((MonoBehaviour)this).StartCoroutine(OPNAAFKLELE());
			}
		}
	}

	private void BHAFCBHENPL()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void FFLLCOBFIPE()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private void HCCJBKKGCLJ()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private IEnumerator EFPAOGPLGCC()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKHLEMPJONN()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private IEnumerator LMGKGLOINMK()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BELOIFKPNMM()
	{
		if ((Object)(object)lineSelection != (Object)null)
		{
			GKJBCHAHDKK = Random.Range(1, lineSelection.textID.Length);
			((TMP_Text)HAKKEHMOGGH).text = LocalizationManager.GetTranslation(lineSelection.textID[GKJBCHAHDKK], false, 1, true, true, (GameObject)null, (string)null, false);
			if (lineSelection.textID.Length > 0)
			{
				((MonoBehaviour)this).StartCoroutine(BFCGFKLBDGF());
			}
		}
	}

	private void GNOBDKFFPOL()
	{
		HAKKEHMOGGH = ((Component)this).GetComponent<TextMeshProUGUI>();
	}

	private IEnumerator GCKKOAEFGJA()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KAMFEBJDOOL()
	{
		return new MCGNJKJFBGJ(1)
		{
			_003C_003E4__this = this
		};
	}
}
