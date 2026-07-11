using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI;

[AddComponentMenu("UI/Button Extended", 58)]
public class UIButtonExtended : Button
{
	public enum VisualState
	{
		Normal,
		Highlighted,
		Pressed,
		Disabled
	}

	[Serializable]
	public class StateChangeEvent : UnityEvent<VisualState, bool>
	{
	}

	public StateChangeEvent onStateChange = new StateChangeEvent();

	[HideInInspector]
	public bool selectTheSameButtonIfNotFoundNextNav;

	[SerializeField]
	public Selectable[] upSelectable;

	[SerializeField]
	private Selectable[] downSelectable;

	[SerializeField]
	private Selectable[] leftSelectable;

	[SerializeField]
	private Selectable[] rightSelectable;

	[SerializeField]
	public Selectable findUpSelectable;

	[SerializeField]
	public Selectable findDownSelectable;

	[SerializeField]
	public Selectable findLeftSelectable;

	[SerializeField]
	public Selectable findRightSelectable;

	public bool ignoreUp;

	public bool ignoreDown;

	public bool ignoreLeft;

	public bool ignoreRight;

	private Selectable IJMDEFJKDAL(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !GAOAMLNINHP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool IGHDKNIDDIL()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable LNDNOOJGLJH(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !ILJPNOAICLA(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool JGJKGJCOJJE()
	{
		return ((Selectable)this).IsPressed();
	}

	public bool HAOFPODIOFO()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool ALDOLHIMBGO()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable HFKEPLFEJNI(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !AGPEIKHHODB(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private bool CBJDCBIAIDG(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool MLKAONCLOEO()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool NDJNOLMDKEL()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private Selectable NHLIAAPABAD(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !HOOOEMANLNC(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private bool CGFLECJFDIC(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private bool ALCPKIAJIFP(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private Selectable OBEPHMAJGNP(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !FDGLHJMAFEP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private bool GOHFLCPENAA(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private bool OEDNKMLKDDO(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool FHOALGBLDGM()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool MLBDJJJAIHE()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool FPFIKLJMINN()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable HMAGHANKCAE(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !EAMCPLNPMIL(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool HEHOOCLFNMO()
	{
		return ((Selectable)this).IsPressed();
	}

	private bool IGHLLDCADJH(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool JJGAPBHMMMF()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private Selectable JCGILGHMPMA(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !NLEDELCGBBL(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public override Selectable FindSelectableOnRight()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		if (ignoreRight)
		{
			return (Selectable)(object)this;
		}
		if (rightSelectable != null)
		{
			for (int i = 0; i < rightSelectable.Length; i++)
			{
				if ((Object)(object)rightSelectable[i] != (Object)null && ((Behaviour)rightSelectable[i]).isActiveAndEnabled && rightSelectable[i].interactable)
				{
					return rightSelectable[i];
				}
			}
		}
		if ((Object)(object)((Selectable)this).FindSelectableOnRight() == (Object)null)
		{
			Navigation navigation = ((Selectable)this).navigation;
			if ((int)((Navigation)(ref navigation)).mode == 4 && Object.op_Implicit((Object)(object)findRightSelectable))
			{
				return findRightSelectable.FindSelectableOnRight();
			}
		}
		Selectable hHFPKDCPPBD = ((Selectable)this).FindSelectableOnRight();
		return HOMJNNCEHCE(hHFPKDCPPBD);
	}

	public bool GGJJHAFANPD()
	{
		return ((Selectable)this).IsPressed();
	}

	private bool PGIFKIBCOHC(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private bool OHPDDJPKHMI(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool FLFKPHOCKDK()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool DJPAIKAEBML()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool HBHHKOHGFML()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool CJCJMFOBFCA()
	{
		return ((Selectable)this).IsPressed();
	}

	private bool AEPICGFPEAM(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private bool ILJPNOAICLA(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private Selectable HKICCFLGEDI(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !NLEDELCGBBL(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private bool DEHAMCANKCN(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool KAGHEABODGO()
	{
		return ((Selectable)this).IsPressed();
	}

	public override Selectable FindSelectableOnUp()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		if (ignoreUp)
		{
			return (Selectable)(object)this;
		}
		if (upSelectable != null)
		{
			for (int i = 0; i < upSelectable.Length; i++)
			{
				if ((Object)(object)upSelectable[i] != (Object)null && ((Behaviour)upSelectable[i]).isActiveAndEnabled && upSelectable[i].interactable)
				{
					return upSelectable[i];
				}
			}
		}
		if ((Object)(object)((Selectable)this).FindSelectableOnUp() == (Object)null)
		{
			Navigation navigation = ((Selectable)this).navigation;
			if ((int)((Navigation)(ref navigation)).mode == 4 && Object.op_Implicit((Object)(object)findUpSelectable))
			{
				return findUpSelectable.FindSelectableOnUp();
			}
		}
		Selectable hHFPKDCPPBD = ((Selectable)this).FindSelectableOnUp();
		return HOMJNNCEHCE(hHFPKDCPPBD);
	}

	public bool AKOGFKBFANC()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private bool EAMCPLNPMIL(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool JKOCBNOKBJE()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private bool GAOAMLNINHP(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private bool DEHGNLNEOCA(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private Selectable HOMJNNCEHCE(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !IGHLLDCADJH(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable ALFNGLNMJHI(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !DEHGNLNEOCA(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable ANAPCOKPCIP(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !GAOAMLNINHP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool HKIBCFPOOGG()
	{
		return ((Selectable)this).IsPressed();
	}

	public bool IONBDLGPEJA()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable ACLMLAKCKNE(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !GAOAMLNINHP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool JOJGLBBNGHP()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private Selectable OJNFNIAAOCM(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !DEHGNLNEOCA(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private bool BNANBKDHCJB(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private Selectable GNKGAEGLCIE(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !PGIFKIBCOHC(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool GFCMFCNNKHI()
	{
		return ((Selectable)this).IsPressed();
	}

	public bool PubIsPressed()
	{
		return ((Selectable)this).IsPressed();
	}

	public bool BKFDAALFGIL()
	{
		return ((Selectable)this).IsPressed();
	}

	public bool JAKMMOAOGOA()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private Selectable LCAOEJEAAMH(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !PGIFKIBCOHC(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private bool HOOOEMANLNC(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	protected override void OnDisable()
	{
		((Selectable)this).OnDisable();
		if (onStateChange != null)
		{
			((UnityEvent<VisualState, bool>)onStateChange).Invoke(VisualState.Disabled, true);
		}
	}

	private Selectable NHNHFJELFFC(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !PGIFKIBCOHC(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public override void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject))
		{
			((Selectable)this).OnDeselect(NPBAMEMNFBI);
		}
	}

	public bool HLJHOMLOGHN()
	{
		return ((Selectable)this).IsPressed();
	}

	public bool AIMJLMKHMJN()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool BKPNHBNEEIL()
	{
		return ((Selectable)this).IsPressed();
	}

	private bool AGPEIKHHODB(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private bool NLEDELCGBBL(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool PubIsHighlighted()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool EPLCOIOICNJ()
	{
		return ((Selectable)this).IsHighlighted();
	}

	protected override void DoStateTransition(SelectionState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected I4, but got Unknown
		((Selectable)this).DoStateTransition(NJHMBMGKCPL, KENEGPFEHHI);
		if (onStateChange != null)
		{
			((UnityEvent<VisualState, bool>)onStateChange).Invoke((VisualState)NJHMBMGKCPL, KENEGPFEHHI);
		}
	}

	public bool EANIBCCJPFF()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable OMBNBLILCIM(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !ALCPKIAJIFP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool FEIMHPADMLL()
	{
		return ((Selectable)this).IsPressed();
	}

	private bool LLBDCODLAJK(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private Selectable HPCJBBAPJFA(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !AEPICGFPEAM(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool OBKENFGLIFH()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable NDMKMNHBAJG(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !GAOAMLNINHP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable IAEIFKLEPOB(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !DEHAMCANKCN(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable JAPLJDOADGC(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !HOOOEMANLNC(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable KMMPPHIGGDM(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !BNANBKDHCJB(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable LJLHBGGIFKF(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !EAMCPLNPMIL(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool AIMCNNHKEJG()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private bool FDGLHJMAFEP(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	private Selectable HKGCIPFAPFP(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !AGPEIKHHODB(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable JFBJOJBNHNJ(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !OEDNKMLKDDO(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool DCLGKEBPKKL()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool HNBDHMJLINH()
	{
		return ((Selectable)this).IsHighlighted();
	}

	public bool HMGKAMFBNBH()
	{
		return ((Selectable)this).IsPressed();
	}

	private Selectable DAPJGHFBFAE(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !GAOAMLNINHP(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public override Selectable FindSelectableOnDown()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		if (ignoreDown)
		{
			return (Selectable)(object)this;
		}
		if (downSelectable != null)
		{
			for (int i = 0; i < downSelectable.Length; i++)
			{
				if ((Object)(object)downSelectable[i] != (Object)null && ((Behaviour)downSelectable[i]).isActiveAndEnabled && downSelectable[i].interactable)
				{
					return downSelectable[i];
				}
			}
		}
		if ((Object)(object)((Selectable)this).FindSelectableOnDown() == (Object)null)
		{
			Navigation navigation = ((Selectable)this).navigation;
			if ((int)((Navigation)(ref navigation)).mode == 4 && Object.op_Implicit((Object)(object)findDownSelectable))
			{
				return findDownSelectable.FindSelectableOnDown();
			}
		}
		Selectable hHFPKDCPPBD = ((Selectable)this).FindSelectableOnDown();
		return HOMJNNCEHCE(hHFPKDCPPBD);
	}

	public override Selectable FindSelectableOnLeft()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Invalid comparison between Unknown and I4
		if (ignoreLeft)
		{
			return (Selectable)(object)this;
		}
		if (leftSelectable != null)
		{
			for (int i = 0; i < leftSelectable.Length; i++)
			{
				if ((Object)(object)leftSelectable[i] != (Object)null && ((Behaviour)leftSelectable[i]).isActiveAndEnabled && leftSelectable[i].interactable)
				{
					return leftSelectable[i];
				}
			}
		}
		if ((Object)(object)((Selectable)this).FindSelectableOnLeft() == (Object)null)
		{
			Navigation navigation = ((Selectable)this).navigation;
			if ((int)((Navigation)(ref navigation)).mode == 4 && Object.op_Implicit((Object)(object)findLeftSelectable))
			{
				return findLeftSelectable.FindSelectableOnLeft();
			}
		}
		Selectable hHFPKDCPPBD = ((Selectable)this).FindSelectableOnLeft();
		return HOMJNNCEHCE(hHFPKDCPPBD);
	}

	public bool MKDHBACKIEC()
	{
		return ((Selectable)this).IsPressed();
	}

	private bool PJHFBGPKAJD(Selectable HHFPKDCPPBD)
	{
		return ((Component)HHFPKDCPPBD).gameObject.layer == ((Component)this).gameObject.layer;
	}

	public bool IEFAAKGCMDL()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private Selectable EHGJLCLPKFM(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !CBJDCBIAIDG(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable GFPKDGCHPED(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !NLEDELCGBBL(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	public bool NGPHAGBIPID()
	{
		return ((Selectable)this).IsHighlighted();
	}

	private Selectable CLMNIFCNADN(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !OHPDDJPKHMI(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}

	private Selectable AFNBHLJJFPG(Selectable HHFPKDCPPBD)
	{
		if ((Object)(object)HHFPKDCPPBD == (Object)null || !PJHFBGPKAJD(HHFPKDCPPBD) || !((Component)HHFPKDCPPBD).gameObject.activeSelf)
		{
			if (selectTheSameButtonIfNotFoundNextNav)
			{
				return (Selectable)(object)this;
			}
			return null;
		}
		return HHFPKDCPPBD;
	}
}
