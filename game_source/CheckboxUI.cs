using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckboxUI : MonoBehaviour
{
	public Action<int, bool> OnCheckboxChanged = delegate
	{
	};

	[SerializeField]
	private int num;

	[SerializeField]
	private bool _activated = true;

	[SerializeField]
	private Image acceptImage;

	[SerializeField]
	private TextMeshProUGUI description;

	public bool HCOPJPMDEKP
	{
		get
		{
			return _activated;
		}
		private set
		{
			_activated = value;
		}
	}

	public void CAMMADDPGCE(string BNAIDNOIIAB)
	{
		((TMP_Text)description).text = BNAIDNOIIAB;
	}

	public void SetDescription(string BNAIDNOIIAB)
	{
		((TMP_Text)description).text = BNAIDNOIIAB;
	}

	public void HFBJKDGHLPE(bool HCOPJPMDEKP)
	{
		_activated = HCOPJPMDEKP;
		HEPFCDOHNCP();
	}

	public void OANBBBKHOFF()
	{
		_activated = _activated;
		HEPFCDOHNCP();
		OnCheckboxChanged(num, _activated);
	}

	public void AGNHLGLLBEI()
	{
		_activated = _activated;
		HEPFCDOHNCP();
		OnCheckboxChanged(num, _activated);
	}

	private void HEPFCDOHNCP()
	{
		((Component)acceptImage).gameObject.SetActive(_activated);
	}

	private void DCKKIDMJKJM()
	{
		HEPFCDOHNCP();
	}

	[SpecialName]
	private void ADDBJKLEAKG(bool AODONKKHPBP)
	{
		_activated = AODONKKHPBP;
	}

	[SpecialName]
	private void CHMDEHDJDHI(bool AODONKKHPBP)
	{
		_activated = AODONKKHPBP;
	}

	public void DFABFBCOOEO(string BNAIDNOIIAB)
	{
		((TMP_Text)description).text = BNAIDNOIIAB;
	}

	[SpecialName]
	public bool MHEPHGCOAHG()
	{
		return _activated;
	}

	public void JAJCIJHCAAB()
	{
		_activated = !_activated;
		HEPFCDOHNCP();
		OnCheckboxChanged(num, _activated);
	}

	private void Start()
	{
		HEPFCDOHNCP();
	}

	public void OJPECHMJLFE(string BNAIDNOIIAB)
	{
		((TMP_Text)description).text = BNAIDNOIIAB;
	}

	[SpecialName]
	public bool FKHHLLFHMJJ()
	{
		return _activated;
	}

	[SpecialName]
	public bool GHLHKDCBONB()
	{
		return _activated;
	}

	private void CEIIFHIBIFI()
	{
		HEPFCDOHNCP();
	}

	public void SetActivated(bool HCOPJPMDEKP)
	{
		_activated = HCOPJPMDEKP;
		HEPFCDOHNCP();
	}

	[SpecialName]
	private void JHCFEJNKMFB(bool AODONKKHPBP)
	{
		_activated = AODONKKHPBP;
	}

	public void AGALIIEOMOP(string BNAIDNOIIAB)
	{
		((TMP_Text)description).text = BNAIDNOIIAB;
	}

	public void Toggle()
	{
		_activated = !_activated;
		HEPFCDOHNCP();
		OnCheckboxChanged(num, _activated);
	}

	public void GPILFCCFEAG(bool HCOPJPMDEKP)
	{
		_activated = HCOPJPMDEKP;
		HEPFCDOHNCP();
	}

	private void HFFFFAJFIPB()
	{
		HEPFCDOHNCP();
	}
}
