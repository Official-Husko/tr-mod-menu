using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LucenNPC : DialogueNPCBase
{
	[CompilerGenerated]
	private sealed class HCGHDKEDJGC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LucenNPC _003C_003E4__this;

		public float duration;

		public float from;

		public float to;

		private float _003Ctime_003E5__2;

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
		public HCGHDKEDJGC(int _003C_003E1__state)
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
			LucenNPC lucenNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ctime_003E5__2 = 0f;
				((Behaviour)lucenNPC.darkAuraFlicker).enabled = false;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctime_003E5__2 < duration)
			{
				_003Ctime_003E5__2 += Time.deltaTime;
				float num2 = _003Ctime_003E5__2 / duration;
				lucenNPC.darkAuraLight.intensity = Mathf.Lerp(from, to, num2);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			lucenNPC.darkAuraLight.intensity = to;
			if (to > 0f)
			{
				((Behaviour)lucenNPC.darkAuraFlicker).enabled = true;
			}
			else
			{
				((Component)lucenNPC.darkAuraLight).gameObject.SetActive(false);
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

	private static LucenNPC IADEMLIIDPC;

	public float timeBarks;

	public Direction endDirection = Direction.Down;

	public bool disableOnCompleteWalkTo;

	[SerializeField]
	private GenericStateMachine stateMachine;

	public LucenState lucenState;

	public LucenStateBase lucenStateBase;

	public GameObject dustUp;

	public GameObject dustDown;

	public GameObject darkAura;

	public GameObject darkAuraEnd;

	public Light2D darkAuraLight;

	public Universal2DLightFlicker darkAuraFlicker;

	private float LINHNEDHAKO = 3.9f;

	private float JGEIJDLCEEH;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static LucenNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void PPPADNMKKIO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ClosePopUp");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void LKLKHKFAFKE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Japanese Door Not Sending Open Action. Unique ID: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void MICCNLONMGI()
	{
		CastleFormEvent.instance.COOLEJADLFB();
	}

	public void OFHJIANLOEO(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.ClientOnline())
		{
			stateMachine.GEDKKAHCBPG((int)HPHLICMELEE, KCNFNAICINO: false);
		}
	}

	[SpecialName]
	public static LucenNPC IBEGPMLJIOJ()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator MAIGFHEGGJK(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	private void ODKGLIDMCNP()
	{
		SelectDialogueUI(1);
	}

	public void POOLNMDJFDK(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(OIIEMCBFGBH(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(HIIFLCLPBLC(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	public void CECHGBPNDJF()
	{
		CastleFormEvent.instance.HDNFPFBBIDA();
	}

	public void LPGGLIGOLKD(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.ClientOnline())
		{
			stateMachine.ChangeState((int)HPHLICMELEE, KCNFNAICINO: false);
		}
	}

	[SpecialName]
	public static LucenNPC EFPJLFMBPLL()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator KMKNPPHACMA(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	private IEnumerator NMENKEBDIAL(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	private void IGIKNCOLCKL()
	{
		SelectDialogueUI();
	}

	public void JBDFIOAIBCP(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(FKADJFGFEKB(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(AEHDOMMKMEP(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	public void BPDPPBDHJEL(string emotion)
	{
		NHKAFANMEJC().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static LucenNPC BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	public void OBKOPCDLFKD(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(NKHAOCBMNEG(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	[SpecialName]
	public static LucenNPC BNBMNOMFFBE()
	{
		return IADEMLIIDPC;
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			ChangeState(LucenState.WalkTo);
		}
	}

	[SpecialName]
	public static LucenNPC KPDFIEMDDCL()
	{
		return IADEMLIIDPC;
	}

	public void ChangeState(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.ClientOnline())
		{
			stateMachine.ChangeState((int)HPHLICMELEE, KCNFNAICINO: false);
		}
	}

	public void IKJPFKLPPPK()
	{
		CastleFormEvent.instance.OHMAALENPGC();
	}

	[SpecialName]
	public static LucenNPC DFJGHOHPPEL()
	{
		return IADEMLIIDPC;
	}

	public void NBMEBGPFPDL()
	{
		CastleFormEvent.instance.CMJNOAFDEHA();
	}

	public void BFOJOMLKNJE()
	{
		CastleFormEvent.instance.IDOHENEHGFA();
	}

	private IEnumerator NKHAOCBMNEG(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	public void OIIOKDBPGOC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("farminterior");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void IEDKNOKIIEG()
	{
		CastleFormEvent.instance.OHMAALENPGC();
	}

	public void CNHIBHEIAMJ(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			stateMachine.IHMEOKNMHIJ((int)HPHLICMELEE);
		}
	}

	public void HICGHFBHDHG(string emotion)
	{
		BNBMNOMFFBE().emotionsController.GPLECKGJFKM(emotion);
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_13");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void StartCastleEvent()
	{
		CastleFormEvent.instance.StartLucenCastleEvent();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void LNBALFOONDE(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			stateMachine.IHMEOKNMHIJ((int)HPHLICMELEE, KCNFNAICINO: false);
		}
	}

	public void KPIMBGJBGAF(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(MAIGFHEGGJK(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(JIBAOCEJFOM(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	public void JIGIEIOLEBC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(")");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void OKAPGNGLOHO()
	{
		SelectDialogueUI();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void NJMDOAJBINK()
	{
		CastleFormEvent.instance.FDHBJEHCGBG();
	}

	public void MEMLDIDGNGM()
	{
		CastleFormEvent.instance.DLPHKHIGONH();
	}

	private IEnumerator FKADJFGFEKB(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new HCGHDKEDJGC(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void GECCLGGHKCN()
	{
		CastleFormEvent.instance.KHCLPKIOCGO();
	}

	[SpecialName]
	public static LucenNPC MOAKANGAMBA()
	{
		return IADEMLIIDPC;
	}

	public void PHLANJBCIKC(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			stateMachine.ChangeState((int)HPHLICMELEE, KCNFNAICINO: false);
		}
	}

	private void CAOKPIIFHBJ()
	{
		SelectDialogueUI();
	}

	public void JNMMOLGDKAN(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(HPMCPMADAHH(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(HPMCPMADAHH(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	private IEnumerator DLMMNCFNOPP(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	public void JMEEDFLLKAF(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(AEHDOMMKMEP(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(KPDPMDDGPCE(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	[SpecialName]
	public static LucenNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static LucenNPC NHKAFANMEJC()
	{
		return IADEMLIIDPC;
	}

	public void DOAEIDOMNMP()
	{
		CastleFormEvent.instance.FDHBJEHCGBG();
	}

	public void KGCKGKMEDOA(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(HIIFLCLPBLC(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(JIBAOCEJFOM(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	private IEnumerator HPMCPMADAHH(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	public void LHOLMHBPGFH()
	{
		CastleFormEvent.instance.COOLEJADLFB();
	}

	public void KAHFBFFDGOD(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(FKADJFGFEKB(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(HPMCPMADAHH(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	[SpecialName]
	public static LucenNPC POAGAIBEFBF()
	{
		return IADEMLIIDPC;
	}

	public void KDEKLDPKEFE(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			stateMachine.GEDKKAHCBPG((int)HPHLICMELEE, KCNFNAICINO: false);
		}
	}

	private void OIAHJHNPPCO()
	{
		SelectDialogueUI(1);
	}

	public void NKLGEOONFGM()
	{
		CastleFormEvent.instance.HDNFPFBBIDA();
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/LucenTalk";
		}
	}

	public void BMCMCBBGJNH()
	{
		CastleFormEvent.instance.OGCKPJDHELO();
	}

	private void KACEOJDPLKB()
	{
		SelectDialogueUI(1);
	}

	public void OPHMKDDNCIK(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(KMKNPPHACMA(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(FKADJFGFEKB(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	private IEnumerator HIIFLCLPBLC(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new HCGHDKEDJGC(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	public void EndCastleEvent()
	{
		CastleFormEvent.instance.EndLucenCastleEvent();
	}

	public void CAONJPIPLBJ(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.ClientOnline())
		{
			stateMachine.IHMEOKNMHIJ((int)HPHLICMELEE);
		}
	}

	public void EEPJLOBNIMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("quest_name_30");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	private void IDHCFOCEPMD()
	{
		SelectDialogueUI(1);
	}

	public void BODDOFFFBDG()
	{
		CastleFormEvent.instance.IDOHENEHGFA();
	}

	public void ABPJIFCKFHI()
	{
		CastleFormEvent.instance.DLPHKHIGONH();
	}

	public void DAAJGNOJLDI()
	{
		CastleFormEvent.instance.BJBACDIIPPI();
	}

	public void GDLLOPLIPOC(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			stateMachine.IHMEOKNMHIJ((int)HPHLICMELEE);
		}
	}

	public void GHGEKDFEMOM()
	{
		CastleFormEvent.instance.FDHBJEHCGBG();
	}

	public void LDLPFGAKAFI()
	{
		CastleFormEvent.instance.BJBACDIIPPI();
	}

	public void EJAMGJMEAEM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			NDBNGDOAGAM(LucenState.WalkTo);
		}
	}

	public void IHFOJNJAALB(string emotion)
	{
		KPDFIEMDDCL().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EKBJHJLFODI(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.ClientOnline())
		{
			stateMachine.GEDKKAHCBPG((int)HPHLICMELEE);
		}
	}

	public void NDBNGDOAGAM(LucenState HPHLICMELEE)
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			stateMachine.ChangeState((int)HPHLICMELEE);
		}
	}

	public void PKIBNCNNDJJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			PHLANJBCIKC(LucenState.Inactive);
		}
	}

	public void PDNOKJKMEEJ(string emotion)
	{
		POAGAIBEFBF().emotionsController.GPLECKGJFKM(emotion);
	}

	private IEnumerator KPDPMDDGPCE(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new HCGHDKEDJGC(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	public void BLDPKJOMJOK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			LPGGLIGOLKD(LucenState.WalkTo);
		}
	}

	public void PIBMIDIMPHP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/TableDirty/Entry/3/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator AEHDOMMKMEP(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		float time = 0f;
		((Behaviour)darkAuraFlicker).enabled = false;
		while (time < OMHCOLMFGNJ)
		{
			time += Time.deltaTime;
			float num = time / OMHCOLMFGNJ;
			darkAuraLight.intensity = Mathf.Lerp(CBNBHOHFKMF, NJMCDGFPCAG, num);
			yield return null;
		}
		darkAuraLight.intensity = NJMCDGFPCAG;
		if (NJMCDGFPCAG > 0f)
		{
			((Behaviour)darkAuraFlicker).enabled = true;
		}
		else
		{
			((Component)darkAuraLight).gameObject.SetActive(false);
		}
	}

	public void AMLCKCOBHGO(string emotion)
	{
		MOAKANGAMBA().emotionsController.NMAPMPBAGMM(emotion);
	}

	private IEnumerator OIIEMCBFGBH(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new HCGHDKEDJGC(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	[SpecialName]
	public static LucenNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	public void MMAAOFHFPNP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			LPGGLIGOLKD(LucenState.Inactive);
		}
	}

	public void IILNAMPPHMP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ERROR - Steam Lobby received on launch command, but the lobby ID could not be parsed.");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void HCCFPBJNLKC(string emotion)
	{
		MOAKANGAMBA().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void AGCKNMMMMCD()
	{
		CastleFormEvent.instance.HDNFPFBBIDA();
	}

	public void KDKHPAOGNLG(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(NKHAOCBMNEG(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(HPMCPMADAHH(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	[SpecialName]
	public static LucenNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	public void MGLFBGDANPC(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(DLMMNCFNOPP(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			Result variable = DialogueLua.GetVariable("MainProgress");
			instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
		}
	}

	public void PFFAJBLGFDO(string emotion)
	{
		EFPJLFMBPLL().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void ADIOELEBJPA(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(OIIEMCBFGBH(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(NKHAOCBMNEG(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	public void IFJKPCMEBLI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			GDLLOPLIPOC(LucenState.WalkTo);
		}
	}

	public void PPHJFALMJEG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void PGOKKFMKPMD(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(HIIFLCLPBLC(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(JIBAOCEJFOM(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	private IEnumerator JIBAOCEJFOM(float OMHCOLMFGNJ, float CBNBHOHFKMF, float NJMCDGFPCAG)
	{
		return new HCGHDKEDJGC(1)
		{
			_003C_003E4__this = this,
			duration = OMHCOLMFGNJ,
			from = CBNBHOHFKMF,
			to = NJMCDGFPCAG
		};
	}

	public void GLJBJKJNHAN(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void PNOGCPMEGDI(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(MAIGFHEGGJK(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}

	private void PKBHEKHOAAA()
	{
		SelectDialogueUI();
	}

	public void KBFLBLENCKJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("{0}    └─ ... ({1} hijo(s) no expandido(s))");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void PFLBPMIEKGF()
	{
		SelectDialogueUI();
	}

	private void BDJKNKIOPIJ()
	{
		SelectDialogueUI(1);
	}

	public void JAGIEEJADMN(string emotion)
	{
		IBEGPMLJIOJ().emotionsController.GPLECKGJFKM(emotion);
	}

	public void JBKHJEJAMHM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReciveLoadCrowlyEventToMaster");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static LucenNPC LPFNKEOJJKE()
	{
		return IADEMLIIDPC;
	}

	public void JEKCPOHLIEL()
	{
		CastleFormEvent.instance.KHCLPKIOCGO();
	}

	public void DMIHGCBJBKG(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool KEEGDBAAEOG = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endDirection = PFJDGBNBOAM;
			disableOnCompleteWalkTo = KEEGDBAAEOG;
			LNBALFOONDE(LucenState.Inactive);
		}
	}

	public void AIAFEKFOAOG()
	{
		CastleFormEvent.instance.DLPHKHIGONH();
	}

	public void ALKCHKDGBDH()
	{
		CastleFormEvent.instance.EndLucenCastleEvent();
	}

	public void GHMHGNMKMJG()
	{
		CastleFormEvent.instance.OEPJDKGENDP();
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	public void StartIntensityDarkAuraLight(float OMHCOLMFGNJ, bool FLDIKKNAKPM)
	{
		if (FLDIKKNAKPM)
		{
			((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, darkAuraLight.intensity, JGEIJDLCEEH));
			return;
		}
		((Component)darkAuraLight).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(NMENKEBDIAL(OMHCOLMFGNJ, JGEIJDLCEEH, LINHNEDHAKO));
	}
}
