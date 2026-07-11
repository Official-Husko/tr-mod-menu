using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("UI/Button Extended - Target", 58)]
[RequireComponent(typeof(UIButtonExtended))]
public class UIButtonExtended_Target : MonoBehaviour
{
	[Serializable]
	public struct SpriteState
	{
		[SerializeField]
		private Sprite m_HighlightedSprite;

		[SerializeField]
		private Sprite m_PressedSprite;

		[SerializeField]
		private Sprite m_DisabledSprite;

		public Sprite highlightedSprite
		{
			get
			{
				return m_HighlightedSprite;
			}
			set
			{
				m_HighlightedSprite = value;
			}
		}

		public Sprite pressedSprite
		{
			get
			{
				return m_PressedSprite;
			}
			set
			{
				m_PressedSprite = value;
			}
		}

		public Sprite disabledSprite
		{
			get
			{
				return m_DisabledSprite;
			}
			set
			{
				m_DisabledSprite = value;
			}
		}

		[SpecialName]
		public void DNOGPNFDNEP(Sprite AODONKKHPBP)
		{
			m_HighlightedSprite = AODONKKHPBP;
		}

		[SpecialName]
		public Sprite AOCELFOCMLJ()
		{
			return m_DisabledSprite;
		}

		[SpecialName]
		public Sprite GNBMJNHDBGN()
		{
			return m_DisabledSprite;
		}

		[SpecialName]
		public void IIOJOAPFMNO(Sprite AODONKKHPBP)
		{
			m_HighlightedSprite = AODONKKHPBP;
		}

		[SpecialName]
		public Sprite BGLJCBFHDNH()
		{
			return m_DisabledSprite;
		}

		[SpecialName]
		public void KKPBJODEDMG(Sprite AODONKKHPBP)
		{
			m_DisabledSprite = AODONKKHPBP;
		}

		[SpecialName]
		public Sprite PJEGKACJHCF()
		{
			return m_PressedSprite;
		}

		[SpecialName]
		public void CNNEDILNEJP(Sprite AODONKKHPBP)
		{
			m_HighlightedSprite = AODONKKHPBP;
		}

		[SpecialName]
		public Sprite LBBGOCNIECB()
		{
			return m_HighlightedSprite;
		}

		[SpecialName]
		public Sprite OACILFMNMCF()
		{
			return m_PressedSprite;
		}

		[SpecialName]
		public Sprite LDALPJHFDMB()
		{
			return m_HighlightedSprite;
		}

		[SpecialName]
		public void BHGMOFALDIA(Sprite AODONKKHPBP)
		{
			m_DisabledSprite = AODONKKHPBP;
		}

		[SpecialName]
		public Sprite PJLPDANGFAA()
		{
			return m_DisabledSprite;
		}
	}

	[CompilerGenerated]
	private sealed class CJLKPDOMCOC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIButtonExtended_Target _003C_003E4__this;

		public UIButtonExtended.VisualState state;

		public bool instant;

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
		public CJLKPDOMCOC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected I4, but got Unknown
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UIButtonExtended_Target uIButtonExtended_Target = _003C_003E4__this;
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
				if (((Behaviour)uIButtonExtended_Target).isActiveAndEnabled)
				{
					if (state == UIButtonExtended.VisualState.Disabled && ((Selectable)uIButtonExtended_Target.HLIPBBONOAH).interactable)
					{
						state = UIButtonExtended.VisualState.Normal;
					}
					if (state == UIButtonExtended.VisualState.Highlighted && !uIButtonExtended_Target.HLIPBBONOAH.PubIsHighlighted())
					{
						state = UIButtonExtended.VisualState.Normal;
					}
					Color val = ((ColorBlock)(ref uIButtonExtended_Target.m_Colors)).normalColor;
					Sprite oNJEPDCGKNC = null;
					string fANBBLHJCKN = uIButtonExtended_Target.m_AnimationTriggers.normalTrigger;
					switch (state)
					{
					case UIButtonExtended.VisualState.Normal:
						val = ((ColorBlock)(ref uIButtonExtended_Target.m_Colors)).normalColor;
						oNJEPDCGKNC = null;
						fANBBLHJCKN = uIButtonExtended_Target.m_AnimationTriggers.normalTrigger;
						break;
					case UIButtonExtended.VisualState.Highlighted:
						val = ((ColorBlock)(ref uIButtonExtended_Target.m_Colors)).highlightedColor;
						oNJEPDCGKNC = uIButtonExtended_Target.m_SpriteState.highlightedSprite;
						fANBBLHJCKN = uIButtonExtended_Target.m_AnimationTriggers.highlightedTrigger;
						break;
					case UIButtonExtended.VisualState.Pressed:
						val = ((ColorBlock)(ref uIButtonExtended_Target.m_Colors)).pressedColor;
						oNJEPDCGKNC = uIButtonExtended_Target.m_SpriteState.pressedSprite;
						fANBBLHJCKN = uIButtonExtended_Target.m_AnimationTriggers.pressedTrigger;
						break;
					case UIButtonExtended.VisualState.Disabled:
						val = ((ColorBlock)(ref uIButtonExtended_Target.m_Colors)).disabledColor;
						oNJEPDCGKNC = uIButtonExtended_Target.m_SpriteState.disabledSprite;
						fANBBLHJCKN = uIButtonExtended_Target.m_AnimationTriggers.disabledTrigger;
						break;
					}
					Transition transition = uIButtonExtended_Target.m_Transition;
					switch (transition - 1)
					{
					case 0:
						uIButtonExtended_Target.HEHGFOBDFKP(val * ((ColorBlock)(ref uIButtonExtended_Target.m_Colors)).colorMultiplier, instant);
						break;
					case 1:
						uIButtonExtended_Target.DKIECKFKKIE(oNJEPDCGKNC);
						break;
					case 2:
						uIButtonExtended_Target.OGIJNCOPFKL(fANBBLHJCKN);
						break;
					}
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

	[SerializeField]
	private Transition m_Transition = (Transition)1;

	[SerializeField]
	private ColorBlock m_Colors = ColorBlock.defaultColorBlock;

	[SerializeField]
	private SpriteState m_SpriteState;

	[SerializeField]
	private AnimationTriggers m_AnimationTriggers = new AnimationTriggers();

	[Tooltip("Graphic that will have the selected transtion applied.")]
	[SerializeField]
	private Graphic m_TargetGraphic;

	[Tooltip("GameObject that will have the selected transtion applied.")]
	[SerializeField]
	private GameObject m_TargetGameObject;

	public Transition KMDAKECOHKD
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return m_Transition;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			m_Transition = value;
		}
	}

	public ColorBlock AMNAOKPPPOJ
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return m_Colors;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			m_Colors = value;
		}
	}

	public SpriteState BNEOPPKKIIP
	{
		get
		{
			return m_SpriteState;
		}
		set
		{
			m_SpriteState = value;
		}
	}

	public AnimationTriggers KHJNLOLHPJK
	{
		get
		{
			return m_AnimationTriggers;
		}
		set
		{
			m_AnimationTriggers = value;
		}
	}

	public Graphic NNHDCCFHIPO
	{
		get
		{
			return m_TargetGraphic;
		}
		set
		{
			m_TargetGraphic = value;
		}
	}

	public GameObject PMJIKGLDMAO
	{
		get
		{
			return m_TargetGameObject;
		}
		set
		{
			m_TargetGameObject = value;
		}
	}

	public Animator ONDMDLMHMHK
	{
		get
		{
			if ((Object)(object)m_TargetGameObject != (Object)null)
			{
				return m_TargetGameObject.GetComponent<Animator>();
			}
			return null;
		}
	}

	public UIButtonExtended HLIPBBONOAH => ((Component)this).GetComponent<UIButtonExtended>();

	[SpecialName]
	public void JLCHBBKFMAC(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	[SpecialName]
	public void BDBMLDILICH(Graphic AODONKKHPBP)
	{
		m_TargetGraphic = AODONKKHPBP;
	}

	protected void DJDLCPCCBHA()
	{
		JNDNAEHONKO(KENEGPFEHHI: true);
	}

	[SpecialName]
	public Graphic IIAGLBAGCJM()
	{
		return m_TargetGraphic;
	}

	protected void OIEJIBAPDMM()
	{
		PBFEPGMIGMH(KENEGPFEHHI: true);
	}

	[SpecialName]
	public ColorBlock MKGIJEBIMIB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Colors;
	}

	[SpecialName]
	public Graphic HFGAJOMDNMH()
	{
		return m_TargetGraphic;
	}

	[SpecialName]
	public void PEOGFEPMLPC(Transition AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Transition = AODONKKHPBP;
	}

	[SpecialName]
	public void ABEHFIJBLGE(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	[SpecialName]
	public void JMKODBFAJKA(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	protected void GCANIILEGFN()
	{
		GIBFFLJLKKO();
	}

	protected void OnDestroy()
	{
		if ((Object)(object)HLIPBBONOAH != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)HLIPBBONOAH.onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)ENNNAOLOAKC);
		}
	}

	private void BEMIKEELJGP(Color MEIMIFEOMJE, bool KENEGPFEHHI)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)m_TargetGraphic == (Object)null))
		{
			m_TargetGraphic.CrossFadeColor(MEIMIFEOMJE, (!KENEGPFEHHI) ? ((ColorBlock)(ref m_Colors)).fadeDuration : 1531f, true, true);
		}
	}

	[SpecialName]
	public void CLGOEKAMAEL(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public ColorBlock PHFBENJJMHN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Colors;
	}

	[SpecialName]
	public void BIODHEMHCHL(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	[SpecialName]
	public void CCMJJFPPJBN(GameObject AODONKKHPBP)
	{
		m_TargetGameObject = AODONKKHPBP;
	}

	private IEnumerator LOHONJHKAJM(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		return new CJLKPDOMCOC(1)
		{
			_003C_003E4__this = this,
			state = NJHMBMGKCPL,
			instant = KENEGPFEHHI
		};
	}

	protected virtual void GFGLMDNFIGN(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(DLFCOACIGNN(NJHMBMGKCPL, KENEGPFEHHI));
		}
	}

	protected void IJNPEAAOOEK()
	{
		ABIKEEKFHJL(KENEGPFEHHI: false);
	}

	[SpecialName]
	public SpriteState GCIECGJPKIN()
	{
		return m_SpriteState;
	}

	protected void CJDJDDNCNDJ()
	{
		PBFEPGMIGMH(KENEGPFEHHI: false);
	}

	private void KEHKBHDCKND(Color MEIMIFEOMJE, bool KENEGPFEHHI)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)m_TargetGraphic == (Object)null))
		{
			m_TargetGraphic.CrossFadeColor(MEIMIFEOMJE, (!KENEGPFEHHI) ? ((ColorBlock)(ref m_Colors)).fadeDuration : 952f, true, true);
		}
	}

	private void HEHGFOBDFKP(Color MEIMIFEOMJE, bool KENEGPFEHHI)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)m_TargetGraphic == (Object)null))
		{
			m_TargetGraphic.CrossFadeColor(MEIMIFEOMJE, (!KENEGPFEHHI) ? ((ColorBlock)(ref m_Colors)).fadeDuration : 0f, true, true);
		}
	}

	[SpecialName]
	public AnimationTriggers BBOCOIAFIFN()
	{
		return m_AnimationTriggers;
	}

	protected void KMEJBPOOBJK()
	{
		if ((Object)(object)GIJFBFFIMBD() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)HLIPBBONOAH.onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)GFGLMDNFIGN);
		}
	}

	protected void DIGLPPFFKEC()
	{
		if ((Object)(object)GIJFBFFIMBD() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)HLIPBBONOAH.onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)MGCCAEEACAC);
		}
	}

	[SpecialName]
	public GameObject ILKDOJKGGEH()
	{
		return m_TargetGameObject;
	}

	[SpecialName]
	public void KBNDEAONABC(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public UIButtonExtended OINGJOJFBEH()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	[SpecialName]
	public void NAEIKOLFBBH(Transition AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Transition = AODONKKHPBP;
	}

	[SpecialName]
	public void ELFPLLLHKLB(GameObject AODONKKHPBP)
	{
		m_TargetGameObject = AODONKKHPBP;
	}

	[SpecialName]
	public AnimationTriggers KNLEPDGLLKN()
	{
		return m_AnimationTriggers;
	}

	protected void OnEnable()
	{
		JNDNAEHONKO(KENEGPFEHHI: true);
	}

	protected void KMBEOPAHKGB()
	{
		if ((Object)(object)ANDBECFOODH() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)GHFHOLIFBMO().onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)NBDFNHPDCEA);
		}
	}

	[SpecialName]
	public Animator AMHILCOKJPC()
	{
		if ((Object)(object)m_TargetGameObject != (Object)null)
		{
			return m_TargetGameObject.GetComponent<Animator>();
		}
		return null;
	}

	[SpecialName]
	public void PKPFBNFNPFE(GameObject AODONKKHPBP)
	{
		m_TargetGameObject = AODONKKHPBP;
	}

	[SpecialName]
	public void IIBDMCONCFM(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public Graphic HEBGOLIBMNF()
	{
		return m_TargetGraphic;
	}

	[SpecialName]
	public void GMJIBGPBLJD(ColorBlock AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Colors = AODONKKHPBP;
	}

	[SpecialName]
	public ColorBlock LJBCDCGFGOD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Colors;
	}

	[SpecialName]
	public void NNPDLDHAMLA(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public SpriteState GALJHODJOBK()
	{
		return m_SpriteState;
	}

	[SpecialName]
	public Transition IBFHGNEDILM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Transition;
	}

	[SpecialName]
	public SpriteState ADBCNJPLKPM()
	{
		return m_SpriteState;
	}

	private void JJLKINECCAM(Sprite ONJEPDCGKNC)
	{
		Graphic targetGraphic = m_TargetGraphic;
		Image val = (Image)(object)((targetGraphic is Image) ? targetGraphic : null);
		if (!((Object)(object)val == (Object)null))
		{
			val.overrideSprite = ONJEPDCGKNC;
		}
	}

	[SpecialName]
	public void GNEELNLADGJ(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	[SpecialName]
	public Animator HJFBPJPMKIA()
	{
		if ((Object)(object)m_TargetGameObject != (Object)null)
		{
			return m_TargetGameObject.GetComponent<Animator>();
		}
		return null;
	}

	[SpecialName]
	public void PFPBEFODMKN(Transition AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Transition = AODONKKHPBP;
	}

	[SpecialName]
	public void BDHNBEIGJMO(GameObject AODONKKHPBP)
	{
		m_TargetGameObject = AODONKKHPBP;
	}

	protected virtual void ENNNAOLOAKC(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BILOJBAKIKP(NJHMBMGKCPL, KENEGPFEHHI));
		}
	}

	[SpecialName]
	public GameObject MAFJGKNKJIL()
	{
		return m_TargetGameObject;
	}

	[SpecialName]
	public void GBNGDCMLLDB(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	[SpecialName]
	public Graphic ADDINLPHIJB()
	{
		return m_TargetGraphic;
	}

	protected void CHDEOJALBFK()
	{
		if ((Object)(object)ANDBECFOODH() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)HLIPBBONOAH.onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)NBDFNHPDCEA);
		}
	}

	[SpecialName]
	public Transition OJHNBHCFKGK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Transition;
	}

	[SpecialName]
	public void PPBKPDPIFOP(Transition AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Transition = AODONKKHPBP;
	}

	[SpecialName]
	public SpriteState LEDEAPILADC()
	{
		return m_SpriteState;
	}

	protected void IFBKCNJGADL()
	{
		GIBFFLJLKKO();
	}

	[SpecialName]
	public void NIDKLIIDAKF(ColorBlock AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Colors = AODONKKHPBP;
	}

	[SpecialName]
	public Animator FGEIACPDGCF()
	{
		if ((Object)(object)m_TargetGameObject != (Object)null)
		{
			return m_TargetGameObject.GetComponent<Animator>();
		}
		return null;
	}

	private void MMAAAHPMBFE(string FANBBLHJCKN)
	{
		if (!((Object)(object)FAPFNGONIFK() == (Object)null))
		{
			Animator component = ILKDOJKGGEH().GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	private void MCLHKEFMAFB(string FANBBLHJCKN)
	{
		if (!((Object)(object)FAPFNGONIFK() == (Object)null))
		{
			Animator component = FKFPCHDKOFC().GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	private void PBFEPGMIGMH(bool KENEGPFEHHI)
	{
		if (((Selectable)GIJFBFFIMBD()).interactable)
		{
			NBDFNHPDCEA(UIButtonExtended.VisualState.Highlighted, KENEGPFEHHI);
		}
		else
		{
			GFGLMDNFIGN(UIButtonExtended.VisualState.Normal, KENEGPFEHHI);
		}
	}

	protected void JGCPEAIIHMP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Transition transition = m_Transition;
		switch (transition - 0)
		{
		case 0:
			HEHGFOBDFKP(Color.white, KENEGPFEHHI: false);
			break;
		case 1:
			DKIECKFKKIE(null);
			break;
		case 2:
			FKCLOHHHDOC(m_AnimationTriggers.normalTrigger);
			break;
		}
	}

	private IEnumerator PFKHLCHOLEL(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		yield return null;
		if (((Behaviour)this).isActiveAndEnabled)
		{
			if (NJHMBMGKCPL == UIButtonExtended.VisualState.Disabled && ((Selectable)HLIPBBONOAH).interactable)
			{
				NJHMBMGKCPL = UIButtonExtended.VisualState.Normal;
			}
			if (NJHMBMGKCPL == UIButtonExtended.VisualState.Highlighted && !HLIPBBONOAH.PubIsHighlighted())
			{
				NJHMBMGKCPL = UIButtonExtended.VisualState.Normal;
			}
			Color val = ((ColorBlock)(ref m_Colors)).normalColor;
			Sprite oNJEPDCGKNC = null;
			string fANBBLHJCKN = m_AnimationTriggers.normalTrigger;
			switch (NJHMBMGKCPL)
			{
			case UIButtonExtended.VisualState.Normal:
				val = ((ColorBlock)(ref m_Colors)).normalColor;
				oNJEPDCGKNC = null;
				fANBBLHJCKN = m_AnimationTriggers.normalTrigger;
				break;
			case UIButtonExtended.VisualState.Highlighted:
				val = ((ColorBlock)(ref m_Colors)).highlightedColor;
				oNJEPDCGKNC = m_SpriteState.highlightedSprite;
				fANBBLHJCKN = m_AnimationTriggers.highlightedTrigger;
				break;
			case UIButtonExtended.VisualState.Pressed:
				val = ((ColorBlock)(ref m_Colors)).pressedColor;
				oNJEPDCGKNC = m_SpriteState.pressedSprite;
				fANBBLHJCKN = m_AnimationTriggers.pressedTrigger;
				break;
			case UIButtonExtended.VisualState.Disabled:
				val = ((ColorBlock)(ref m_Colors)).disabledColor;
				oNJEPDCGKNC = m_SpriteState.disabledSprite;
				fANBBLHJCKN = m_AnimationTriggers.disabledTrigger;
				break;
			}
			Transition transition = m_Transition;
			switch (transition - 1)
			{
			case 0:
				HEHGFOBDFKP(val * ((ColorBlock)(ref m_Colors)).colorMultiplier, KENEGPFEHHI);
				break;
			case 1:
				DKIECKFKKIE(oNJEPDCGKNC);
				break;
			case 2:
				OGIJNCOPFKL(fANBBLHJCKN);
				break;
			}
		}
	}

	[SpecialName]
	public void BMKLPAPJEBC(ColorBlock AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Colors = AODONKKHPBP;
	}

	[SpecialName]
	public void DCNDGOEFHGP(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public UIButtonExtended AIJPECEAHBF()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	protected virtual void NBDFNHPDCEA(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BILOJBAKIKP(NJHMBMGKCPL, KENEGPFEHHI));
		}
	}

	[SpecialName]
	public void CLDCHPMJGEB(Graphic AODONKKHPBP)
	{
		m_TargetGraphic = AODONKKHPBP;
	}

	private IEnumerator BILOJBAKIKP(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		yield return null;
		if (((Behaviour)this).isActiveAndEnabled)
		{
			if (NJHMBMGKCPL == UIButtonExtended.VisualState.Disabled && ((Selectable)HLIPBBONOAH).interactable)
			{
				NJHMBMGKCPL = UIButtonExtended.VisualState.Normal;
			}
			if (NJHMBMGKCPL == UIButtonExtended.VisualState.Highlighted && !HLIPBBONOAH.PubIsHighlighted())
			{
				NJHMBMGKCPL = UIButtonExtended.VisualState.Normal;
			}
			Color val = ((ColorBlock)(ref m_Colors)).normalColor;
			Sprite oNJEPDCGKNC = null;
			string fANBBLHJCKN = m_AnimationTriggers.normalTrigger;
			switch (NJHMBMGKCPL)
			{
			case UIButtonExtended.VisualState.Normal:
				val = ((ColorBlock)(ref m_Colors)).normalColor;
				oNJEPDCGKNC = null;
				fANBBLHJCKN = m_AnimationTriggers.normalTrigger;
				break;
			case UIButtonExtended.VisualState.Highlighted:
				val = ((ColorBlock)(ref m_Colors)).highlightedColor;
				oNJEPDCGKNC = m_SpriteState.highlightedSprite;
				fANBBLHJCKN = m_AnimationTriggers.highlightedTrigger;
				break;
			case UIButtonExtended.VisualState.Pressed:
				val = ((ColorBlock)(ref m_Colors)).pressedColor;
				oNJEPDCGKNC = m_SpriteState.pressedSprite;
				fANBBLHJCKN = m_AnimationTriggers.pressedTrigger;
				break;
			case UIButtonExtended.VisualState.Disabled:
				val = ((ColorBlock)(ref m_Colors)).disabledColor;
				oNJEPDCGKNC = m_SpriteState.disabledSprite;
				fANBBLHJCKN = m_AnimationTriggers.disabledTrigger;
				break;
			}
			Transition transition = m_Transition;
			switch (transition - 1)
			{
			case 0:
				HEHGFOBDFKP(val * ((ColorBlock)(ref m_Colors)).colorMultiplier, KENEGPFEHHI);
				break;
			case 1:
				DKIECKFKKIE(oNJEPDCGKNC);
				break;
			case 2:
				OGIJNCOPFKL(fANBBLHJCKN);
				break;
			}
		}
	}

	protected void KLCFICPALBK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Transition transition = m_Transition;
		switch (transition - 0)
		{
		case 0:
			BEMIKEELJGP(Color.white, KENEGPFEHHI: true);
			break;
		case 1:
			FNINMGBFGJK(null);
			break;
		case 2:
			IIJCALMKIAO(m_AnimationTriggers.normalTrigger);
			break;
		}
	}

	[SpecialName]
	public SpriteState MCEEDCMCFCB()
	{
		return m_SpriteState;
	}

	protected void OIOLGAOPECC()
	{
		if ((Object)(object)GIJFBFFIMBD() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)AIJPECEAHBF().onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)GDMMMAOHIIC);
		}
	}

	private void DGDLFHBHBOD(string FANBBLHJCKN)
	{
		if (!((Object)(object)GNBECFEOGOK() == (Object)null))
		{
			Animator component = ILKDOJKGGEH().GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	[SpecialName]
	public SpriteState KJCDKEOEFBD()
	{
		return m_SpriteState;
	}

	[SpecialName]
	public void OEAHMKBINJC(Graphic AODONKKHPBP)
	{
		m_TargetGraphic = AODONKKHPBP;
	}

	[SpecialName]
	public GameObject OOIBDFIIDJD()
	{
		return m_TargetGameObject;
	}

	[SpecialName]
	public void LKGADAGJJLN(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	private void FNINMGBFGJK(Sprite ONJEPDCGKNC)
	{
		Graphic targetGraphic = m_TargetGraphic;
		Image val = (Image)(object)((targetGraphic is Image) ? targetGraphic : null);
		if (!((Object)(object)val == (Object)null))
		{
			val.overrideSprite = ONJEPDCGKNC;
		}
	}

	[SpecialName]
	public GameObject FKFPCHDKOFC()
	{
		return m_TargetGameObject;
	}

	[SpecialName]
	public void CLCPAAMJDJN(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public Transition PKPJPMKGNKN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Transition;
	}

	[SpecialName]
	public AnimationTriggers GIMPHEBEPCE()
	{
		return m_AnimationTriggers;
	}

	[SpecialName]
	public void NGKJDCCKOND(ColorBlock AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Colors = AODONKKHPBP;
	}

	private void BJDCOEOINON(bool KENEGPFEHHI)
	{
		if (((Selectable)GHFHOLIFBMO()).interactable)
		{
			MGCCAEEACAC(UIButtonExtended.VisualState.Highlighted, KENEGPFEHHI);
		}
		else
		{
			ENNNAOLOAKC((UIButtonExtended.VisualState)6, KENEGPFEHHI);
		}
	}

	[SpecialName]
	public Animator HIGKIOCHBKL()
	{
		if ((Object)(object)m_TargetGameObject != (Object)null)
		{
			return m_TargetGameObject.GetComponent<Animator>();
		}
		return null;
	}

	[SpecialName]
	public UIButtonExtended AALPFEGNLOG()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	[SpecialName]
	public void DJMKLJPJDGA(Transition AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Transition = AODONKKHPBP;
	}

	private void DKIECKFKKIE(Sprite ONJEPDCGKNC)
	{
		Graphic targetGraphic = m_TargetGraphic;
		Image val = (Image)(object)((targetGraphic is Image) ? targetGraphic : null);
		if (!((Object)(object)val == (Object)null))
		{
			val.overrideSprite = ONJEPDCGKNC;
		}
	}

	[SpecialName]
	public Graphic OCCJHKICILO()
	{
		return m_TargetGraphic;
	}

	protected void OGGJNBCJGCE()
	{
		KLCFICPALBK();
	}

	[SpecialName]
	public void DFFAMNKFFDF(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	private void OGIJNCOPFKL(string FANBBLHJCKN)
	{
		if (!((Object)(object)PMJIKGLDMAO == (Object)null))
		{
			Animator component = PMJIKGLDMAO.GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	[SpecialName]
	public void NHJMKKMPPFD(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	private void JNDNAEHONKO(bool KENEGPFEHHI)
	{
		if (((Selectable)HLIPBBONOAH).interactable)
		{
			ENNNAOLOAKC(UIButtonExtended.VisualState.Normal, KENEGPFEHHI);
		}
		else
		{
			ENNNAOLOAKC(UIButtonExtended.VisualState.Disabled, KENEGPFEHHI);
		}
	}

	protected virtual void GDMMMAOHIIC(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(BILOJBAKIKP(NJHMBMGKCPL, KENEGPFEHHI));
		}
	}

	protected void BPINJGFECPF()
	{
		KLCFICPALBK();
	}

	private void FKCLOHHHDOC(string FANBBLHJCKN)
	{
		if (!((Object)(object)FAPFNGONIFK() == (Object)null))
		{
			Animator component = EICBFFBPPOA().GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	private IEnumerator DLFCOACIGNN(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		return new CJLKPDOMCOC(1)
		{
			_003C_003E4__this = this,
			state = NJHMBMGKCPL,
			instant = KENEGPFEHHI
		};
	}

	private void KFLEBAPPOJO(string FANBBLHJCKN)
	{
		if (!((Object)(object)FAPFNGONIFK() == (Object)null))
		{
			Animator component = ILKDOJKGGEH().GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	protected void IKIPGJNEJNG()
	{
		if ((Object)(object)AALPFEGNLOG() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)GIJFBFFIMBD().onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)GDMMMAOHIIC);
		}
	}

	private void ABIKEEKFHJL(bool KENEGPFEHHI)
	{
		if (((Selectable)AIJPECEAHBF()).interactable)
		{
			NBDFNHPDCEA(UIButtonExtended.VisualState.Highlighted, KENEGPFEHHI);
		}
		else
		{
			NBDFNHPDCEA(UIButtonExtended.VisualState.Pressed, KENEGPFEHHI);
		}
	}

	protected void MBCCCMMBPEK()
	{
		ABIKEEKFHJL(KENEGPFEHHI: false);
	}

	[SpecialName]
	public Graphic FFNLKKJLJJG()
	{
		return m_TargetGraphic;
	}

	protected void NKGMEMEACNN()
	{
		if ((Object)(object)AIJPECEAHBF() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)GHFHOLIFBMO().onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)NBDFNHPDCEA);
		}
	}

	[SpecialName]
	public Transition LLOCJKBNLDD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Transition;
	}

	private IEnumerator PEFBHFLCPHN(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		yield return null;
		if (((Behaviour)this).isActiveAndEnabled)
		{
			if (NJHMBMGKCPL == UIButtonExtended.VisualState.Disabled && ((Selectable)HLIPBBONOAH).interactable)
			{
				NJHMBMGKCPL = UIButtonExtended.VisualState.Normal;
			}
			if (NJHMBMGKCPL == UIButtonExtended.VisualState.Highlighted && !HLIPBBONOAH.PubIsHighlighted())
			{
				NJHMBMGKCPL = UIButtonExtended.VisualState.Normal;
			}
			Color val = ((ColorBlock)(ref m_Colors)).normalColor;
			Sprite oNJEPDCGKNC = null;
			string fANBBLHJCKN = m_AnimationTriggers.normalTrigger;
			switch (NJHMBMGKCPL)
			{
			case UIButtonExtended.VisualState.Normal:
				val = ((ColorBlock)(ref m_Colors)).normalColor;
				oNJEPDCGKNC = null;
				fANBBLHJCKN = m_AnimationTriggers.normalTrigger;
				break;
			case UIButtonExtended.VisualState.Highlighted:
				val = ((ColorBlock)(ref m_Colors)).highlightedColor;
				oNJEPDCGKNC = m_SpriteState.highlightedSprite;
				fANBBLHJCKN = m_AnimationTriggers.highlightedTrigger;
				break;
			case UIButtonExtended.VisualState.Pressed:
				val = ((ColorBlock)(ref m_Colors)).pressedColor;
				oNJEPDCGKNC = m_SpriteState.pressedSprite;
				fANBBLHJCKN = m_AnimationTriggers.pressedTrigger;
				break;
			case UIButtonExtended.VisualState.Disabled:
				val = ((ColorBlock)(ref m_Colors)).disabledColor;
				oNJEPDCGKNC = m_SpriteState.disabledSprite;
				fANBBLHJCKN = m_AnimationTriggers.disabledTrigger;
				break;
			}
			Transition transition = m_Transition;
			switch (transition - 1)
			{
			case 0:
				HEHGFOBDFKP(val * ((ColorBlock)(ref m_Colors)).colorMultiplier, KENEGPFEHHI);
				break;
			case 1:
				DKIECKFKKIE(oNJEPDCGKNC);
				break;
			case 2:
				OGIJNCOPFKL(fANBBLHJCKN);
				break;
			}
		}
	}

	[SpecialName]
	public void DCBHDKEBGLB(ColorBlock AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Colors = AODONKKHPBP;
	}

	[SpecialName]
	public Animator KLNFKEOOIDF()
	{
		if ((Object)(object)m_TargetGameObject != (Object)null)
		{
			return m_TargetGameObject.GetComponent<Animator>();
		}
		return null;
	}

	private void DFGPCCIEKKM(Color MEIMIFEOMJE, bool KENEGPFEHHI)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)m_TargetGraphic == (Object)null))
		{
			m_TargetGraphic.CrossFadeColor(MEIMIFEOMJE, (!KENEGPFEHHI) ? ((ColorBlock)(ref m_Colors)).fadeDuration : 1422f, true, false);
		}
	}

	[SpecialName]
	public void HKEDJFOFMLI(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	private void NBDBAJNNDEI(string FANBBLHJCKN)
	{
		if (!((Object)(object)MAFJGKNKJIL() == (Object)null))
		{
			Animator component = FAPFNGONIFK().GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	protected void NCDBCDJKPLA()
	{
		if ((Object)(object)ANDBECFOODH() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)KKOGEDAIOEJ().onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)MGCCAEEACAC);
		}
	}

	[SpecialName]
	public GameObject EICBFFBPPOA()
	{
		return m_TargetGameObject;
	}

	[SpecialName]
	public UIButtonExtended GIJFBFFIMBD()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	[SpecialName]
	public void CLKNLDEDNAP(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	protected void KJHKBGDJNDC()
	{
		if ((Object)(object)GIJFBFFIMBD() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)GIJFBFFIMBD().onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)MGCCAEEACAC);
		}
	}

	protected void GIBFFLJLKKO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Transition transition = m_Transition;
		switch (transition - 1)
		{
		case 0:
			HEHGFOBDFKP(Color.white, KENEGPFEHHI: true);
			break;
		case 1:
			DKIECKFKKIE(null);
			break;
		case 2:
			OGIJNCOPFKL(m_AnimationTriggers.normalTrigger);
			break;
		}
	}

	[SpecialName]
	public UIButtonExtended ANDBECFOODH()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	[SpecialName]
	public void KCADJONJMFI(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	[SpecialName]
	public ColorBlock EGEOGMEFJJM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Colors;
	}

	[SpecialName]
	public UIButtonExtended GHFHOLIFBMO()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	[SpecialName]
	public GameObject FAPFNGONIFK()
	{
		return m_TargetGameObject;
	}

	protected void FHOCCEBKHJI()
	{
		if ((Object)(object)HLIPBBONOAH != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)OINGJOJFBEH().onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)NBDFNHPDCEA);
		}
	}

	protected void MMAMJDLONFA()
	{
		GIBFFLJLKKO();
	}

	protected void Awake()
	{
		if ((Object)(object)HLIPBBONOAH != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)HLIPBBONOAH.onStateChange).AddListener((UnityAction<UIButtonExtended.VisualState, bool>)ENNNAOLOAKC);
		}
	}

	protected void GDLAHKEMJFN()
	{
		JNDNAEHONKO(KENEGPFEHHI: true);
	}

	[SpecialName]
	public void ELMBDPONEDN(Transition AODONKKHPBP)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		m_Transition = AODONKKHPBP;
	}

	[SpecialName]
	public void EJDDJKLGDID(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	protected void OJLGOCFKLJE()
	{
		JNDNAEHONKO(KENEGPFEHHI: false);
	}

	private void IIJCALMKIAO(string FANBBLHJCKN)
	{
		if (!((Object)(object)ILKDOJKGGEH() == (Object)null))
		{
			Animator component = PMJIKGLDMAO.GetComponent<Animator>();
			if (!((Object)(object)component == (Object)null) && ((Behaviour)component).enabled && ((Behaviour)component).isActiveAndEnabled && !((Object)(object)component.runtimeAnimatorController == (Object)null) && !string.IsNullOrEmpty(FANBBLHJCKN))
			{
				component.ResetTrigger(m_AnimationTriggers.normalTrigger);
				component.ResetTrigger(m_AnimationTriggers.pressedTrigger);
				component.ResetTrigger(m_AnimationTriggers.highlightedTrigger);
				component.ResetTrigger(m_AnimationTriggers.disabledTrigger);
				component.SetTrigger(FANBBLHJCKN);
			}
		}
	}

	[SpecialName]
	public UIButtonExtended KKOGEDAIOEJ()
	{
		return ((Component)this).GetComponent<UIButtonExtended>();
	}

	protected void PKFMLJGJKCP()
	{
		if ((Object)(object)KKOGEDAIOEJ() != (Object)null)
		{
			((UnityEvent<UIButtonExtended.VisualState, bool>)ANDBECFOODH().onStateChange).RemoveListener((UnityAction<UIButtonExtended.VisualState, bool>)GFGLMDNFIGN);
		}
	}

	[SpecialName]
	public void ABMJOICCOIG(GameObject AODONKKHPBP)
	{
		m_TargetGameObject = AODONKKHPBP;
	}

	[SpecialName]
	public ColorBlock MKBMHODKMKK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Colors;
	}

	[SpecialName]
	public void FMPIPPOCHGB(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	[SpecialName]
	public Transition PCIMNGEBHHB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Transition;
	}

	[SpecialName]
	public ColorBlock DCMDHJODOJP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return m_Colors;
	}

	protected virtual void MGCCAEEACAC(UIButtonExtended.VisualState NJHMBMGKCPL, bool KENEGPFEHHI)
	{
		if (((Component)this).gameObject.activeInHierarchy)
		{
			((MonoBehaviour)this).StartCoroutine(DLFCOACIGNN(NJHMBMGKCPL, KENEGPFEHHI));
		}
	}

	protected void DDIBFALLCNO()
	{
		KLCFICPALBK();
	}

	[SpecialName]
	public GameObject GNBECFEOGOK()
	{
		return m_TargetGameObject;
	}

	[SpecialName]
	public void PLFLFOFAECK(SpriteState AODONKKHPBP)
	{
		m_SpriteState = AODONKKHPBP;
	}

	protected void OnDisable()
	{
		GIBFFLJLKKO();
	}

	[SpecialName]
	public void LEHFDDKAKIA(AnimationTriggers AODONKKHPBP)
	{
		m_AnimationTriggers = AODONKKHPBP;
	}

	protected void EEAKGHLCFOM()
	{
		GIBFFLJLKKO();
	}

	[SpecialName]
	public void GGCLJPJGMCO(Graphic AODONKKHPBP)
	{
		m_TargetGraphic = AODONKKHPBP;
	}

	[SpecialName]
	public Animator NMLILNAAFPJ()
	{
		if ((Object)(object)m_TargetGameObject != (Object)null)
		{
			return m_TargetGameObject.GetComponent<Animator>();
		}
		return null;
	}
}
