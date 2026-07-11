using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropdownOption : Toggle
{
	[CompilerGenerated]
	private sealed class HNEGMIBJBAG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DropdownOption _003C_003E4__this;

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
		public HNEGMIBJBAG(int _003C_003E1__state)
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
			DropdownOption dropdownOption = _003C_003E4__this;
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
				if (PlayerInputs.IsGamepadActive(1))
				{
					UISelectionManager.GetPlayer(1).Select((Selectable)(object)dropdownOption);
				}
				else
				{
					dropdownOption.ScrollToMe(CMOMDLILHGD: true);
				}
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

	public static TMP_Dropdown SelectedDropdown;

	private TMP_Dropdown BDCNHELFABD;

	private Scrollbar LFFBKOFCBOF;

	private bool FOHBOFOAADD;

	private bool NBACAPDICPN;

	private bool CGJGKGCPGAK = true;

	private bool DJNKODLNAMF = true;

	private Selectable DPKCIGHPALI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public override void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		((Selectable)this).OnSelect(NPBAMEMNFBI);
		ScrollToMe();
	}

	private Selectable KADOIKCMOKH(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void MOEEHGMLILB(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(0) || CMOMDLILHGD))
		{
			float value = 1719f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator ENPHBDBMNOL()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private Selectable OONHMDGJCAF(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable CFIJMCNEEOJ(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void JKLOGAGPCCJ(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.ODGALPDEIFG(1) || CMOMDLILHGD))
		{
			float value = 1058f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable PIMCDILIMNI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void FOMJNBOPFCE(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(0) || CMOMDLILHGD))
		{
			float value = 492f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 4);
			LFFBKOFCBOF.value = value;
		}
	}

	public void EDNBBKJKGBN(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 157f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 1);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator LPHMMHIHFLC()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	public void AFBBJJCBNAI(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(0) || CMOMDLILHGD))
		{
			float value = 1016f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator NMNIDEEMBDE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable KHAMEKOIILJ(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator KLABMHFGFIL()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NKFIOOPCGGN(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(0) || CMOMDLILHGD))
		{
			float value = 947f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	public void ACOMNIBELMP(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(0) || CMOMDLILHGD))
		{
			float value = 569f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator HMMMGLLBOFJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable BKHKDLNHGAE(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void BIGJBCPCLBF(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.ODGALPDEIFG(0) || CMOMDLILHGD))
		{
			float value = 641f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 2);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable NAOOBGFJEMI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void BOFPMEHKMEH(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.ODGALPDEIFG(1) || CMOMDLILHGD))
		{
			float value = 735f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	public void CFEAGDMPLPM(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 499f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 8);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable KIFCGBNNKJP(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable KFIABKEBLAK(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void MGNBGALCHOD(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 760f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 1);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable IFOBCIAEOGL(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void CGNCNIJLOAH(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(0) || CMOMDLILHGD))
		{
			float value = 991f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable JECIMOEFJEL(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable BHKAEFDPOHK(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable FFNOCLEEONK(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void HOBHEFHGEIC(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(0) || CMOMDLILHGD))
		{
			float value = 648f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 1);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable FCJECAJINIJ(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator DBJBJOHNEEC()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator NIAMHMEHJAG()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JEPIDDDOANF(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 1429f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 4);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable BNBPIOECFAO(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void POONLALFGHO(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.ODGALPDEIFG(0) || CMOMDLILHGD))
		{
			float value = 1189f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 8);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator JCBGEKABLGH()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable AEJBGLGKLPK(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable OJLHBLDJFHN(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void KHNMHGOMPID(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 1650f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 5);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable KLFEFDAJCMI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void NOJNKCJPOFN(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(1) || CMOMDLILHGD))
		{
			float value = 937f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable FMMOEHKMCJK(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable OGICENOHELI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable FPJKMLGDDLH(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void HNLLHNHJMMM(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 699f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	public void MCLEDPJEMLG(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 776f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	public void BFNDBCPKKPH(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(0) || CMOMDLILHGD))
		{
			float value = 1748f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 1);
			LFFBKOFCBOF.value = value;
		}
	}

	public void MLDDJIAIGKN(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 748f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable GOKDNAMFLDO(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void NDCKHGBKNLF(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(0) || CMOMDLILHGD))
		{
			float value = 974f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 5);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator JHLJKJELEGC()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable KONIOFMCJLO(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void CBJMNHLBNEJ(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(0) || CMOMDLILHGD))
		{
			float value = 1136f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	public void OAPGHNNKBMO(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(1) || CMOMDLILHGD))
		{
			float value = 1907f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 2);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable NJJJPPEHPDI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void BCAKKFFIGNH(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.ODGALPDEIFG(1) || CMOMDLILHGD))
		{
			float value = 296f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 8);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator LBNFBEKEEGJ()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	public void MGGGAFCILBK(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(1) || CMOMDLILHGD))
		{
			float value = 373f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 4);
			LFFBKOFCBOF.value = value;
		}
	}

	public override Selectable FindSelectableOnUp()
	{
		if (FOHBOFOAADD)
		{
			return (Selectable)(object)this;
		}
		return PIMCDILIMNI(((Selectable)this).FindSelectableOnUp());
	}

	private IEnumerator DMNNDJEFHLC()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	public void BPHOOIMBNEK(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(0) || CMOMDLILHGD))
		{
			float value = 971f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 4);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator PHIPPJIBDCF()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable DOMINDFCAJN(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void DCHPJCDADMP(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 1051f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	public void OADIMFICIBK(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(1) || CMOMDLILHGD))
		{
			float value = 847f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable LEFGEEIPJAG(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable HJGOPOCPDEE(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void OCOBAADKGLG(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(0) || CMOMDLILHGD))
		{
			float value = 766f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 1);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable BCKHOKBJFED(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void JENOHLOHJBF(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 1799f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable AGJOOIEGMGH(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator PKBHIIABOFE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	public override void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			((Selectable)this).OnDeselect(NPBAMEMNFBI);
		}
	}

	public override Selectable FindSelectableOnLeft()
	{
		if (CGJGKGCPGAK)
		{
			return (Selectable)(object)this;
		}
		return PIMCDILIMNI(((Selectable)this).FindSelectableOnLeft());
	}

	private Selectable JLOLDPALBKE(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator HADGPCDBBIJ()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ILFGFPBMAMJ(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 1299f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable LLMFGBECNOP(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	protected override void Start()
	{
		((Toggle)this).Start();
		LFFBKOFCBOF = ((Component)((Component)this).GetComponentInParent<ScrollRect>()).GetComponentInChildren<Scrollbar>();
		BDCNHELFABD = ((Component)this).GetComponentInParent<TMP_Dropdown>();
		if (BDCNHELFABD.value == ((Component)this).transform.GetSiblingIndex() - 1)
		{
			((MonoBehaviour)this).StartCoroutine(PMNNLFJNPJA());
		}
	}

	private IEnumerator BLAMMBKAHFP()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable LJMEKBCHDIP(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable ICIJENKDIPI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void ScrollToMe(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 1f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 2);
			LFFBKOFCBOF.value = value;
		}
	}

	public override Selectable FindSelectableOnDown()
	{
		if (NBACAPDICPN)
		{
			return (Selectable)(object)this;
		}
		return PIMCDILIMNI(((Selectable)this).FindSelectableOnDown());
	}

	private IEnumerator JGIIOMHACLC()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	public void JFACMGBLHMM(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.ODGALPDEIFG(0) || CMOMDLILHGD))
		{
			float value = 251f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator EKGLKINBDDB()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator IMOFBIKKNHN()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable LAHOMKCENKM(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable KACBGFEKFJO(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void LOHPIONCDMJ(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(0) || CMOMDLILHGD))
		{
			float value = 341f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 8);
			LFFBKOFCBOF.value = value;
		}
	}

	public void PKKJBLKKPNI(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(0) || CMOMDLILHGD))
		{
			float value = 753f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 0);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator GKFCJBCFGLP()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private Selectable KOHOOGLHGHI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator OBIENCBIPDP()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private Selectable EPCJBJNHFCN(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void OGOHFHLCKCC(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.POLDHCKJINN(1) || CMOMDLILHGD))
		{
			float value = 231f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable PPCFNHALDII(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator HBCHJAHFLHM()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator PMNNLFJNPJA()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator DNNAOGLBKCP()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator HBAAFDOHNDE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	public void HAAJLIDDKFC(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(0) || CMOMDLILHGD))
		{
			float value = 1211f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 8);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator ADAPHOKFLOE()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private Selectable MNEBKPIFHOM(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator LNIMAAJNOFF()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGHLCOBLMGD()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OMHJDHGFHKN(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.FJLAMCHKCOI(0) || CMOMDLILHGD))
		{
			float value = 1373f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable LDIEPOFHEGJ(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable CKGDDMKLJHO(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private Selectable JBLPAAHHIJN(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator EPDDGMIHCFC()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PPHCLGMLPLF()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator BLPKGOFILKE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable EOGLMNJAADF(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public void NJIAKHACEDD(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(1) || CMOMDLILHGD))
		{
			float value = 1522f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	private IEnumerator ABLGMCJPFIP()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private Selectable BCHENIKCNHJ(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator NCNMLEGPHBP()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EAJJOBMPGEL()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GPOJIOEGPKF()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BAGFHKECADO(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 1176f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 6);
			LFFBKOFCBOF.value = value;
		}
	}

	private Selectable GCAHAAKNAKH(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator ILCNBEBPKFE()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private IEnumerator BOPLHEPAFEO()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable ALNEELBMGAE(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	public override Selectable FindSelectableOnRight()
	{
		if (DJNKODLNAMF)
		{
			return (Selectable)(object)this;
		}
		return PIMCDILIMNI(((Selectable)this).FindSelectableOnRight());
	}

	private IEnumerator ADAOAIOCNBH()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)this);
		}
		else
		{
			ScrollToMe(CMOMDLILHGD: true);
		}
	}

	private Selectable OIALMBLBGBI(Selectable FKEDMJFEHGE)
	{
		if ((Object)(object)FKEDMJFEHGE != (Object)null)
		{
			return FKEDMJFEHGE;
		}
		return (Selectable)(object)this;
	}

	private IEnumerator BPJNDBJCLLF()
	{
		return new HNEGMIBJBAG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DLKFCJOMMKE(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.EEJEOALIHFJ(1) || CMOMDLILHGD))
		{
			float value = 391f - (float)(((Component)this).transform.GetSiblingIndex() - 0) / (float)(((Component)this).transform.parent.childCount - 3);
			LFFBKOFCBOF.value = value;
		}
	}

	public void BBEEFKDCLPE(bool CMOMDLILHGD = false)
	{
		if (!((Object)(object)LFFBKOFCBOF == (Object)null) && (PlayerInputs.IsGamepadActive(1) || CMOMDLILHGD))
		{
			float value = 342f - (float)(((Component)this).transform.GetSiblingIndex() - 1) / (float)(((Component)this).transform.parent.childCount - 8);
			LFFBKOFCBOF.value = value;
		}
	}
}
