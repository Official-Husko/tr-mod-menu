using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class CharacterAnimBase : MonoBehaviourPunCallbacks
{
	public Action<Direction> DirectionChanged = delegate
	{
	};

	public Animator animator;

	[SerializeField]
	protected Direction _direction;

	protected bool HFECMNIFMFI;

	protected bool MHEOAHLBGHC;

	public bool clientIgnoresAnimation = true;

	[HideInInspector]
	public OnlineBaseCharacterAnimation onlineCharacterAnim;

	protected static readonly int LJOKEJOCBDI = AnimatorParameterCache.p_Direction;

	protected static readonly int HGEBKKGJONI = AnimatorParameterCache.p_Moving;

	protected static readonly int LOAACMNIKFK = AnimatorParameterCache.p_Running;

	protected static readonly int MPEOOHKMKAM = AnimatorParameterCache.p_LoopSleep;

	protected static readonly int PGDOKFIHFPL = AnimatorParameterCache.p_LoopPeek;

	protected static readonly int IBNECEPOKFI = AnimatorParameterCache.p_Peek;

	protected static readonly int LNNMIIMJDKO = AnimatorParameterCache.p_Sleep;

	protected static readonly int MNJMKDEEGDE = AnimatorParameterCache.p_Look;

	protected static readonly int DIGIHNCFHJD = AnimatorParameterCache.p_Loop;

	protected static readonly int ABOMGPELDKP = AnimatorParameterCache.p_Eat;

	protected static readonly int IAENAGLBEHC = AnimatorParameterCache.p_Random;

	protected static readonly int CIJHGCDKLEH = AnimatorParameterCache.p_ToolRight;

	protected static readonly int ADNDPEIHIIL = AnimatorParameterCache.p_Spade;

	protected static readonly int CKGCLBNOOFJ = AnimatorParameterCache.p_Fishing;

	protected static readonly int CHHKJCPPPOM = AnimatorParameterCache.p_IdleFishing;

	protected static readonly int ECEMIFMNKDE = AnimatorParameterCache.p_StruggleFishing;

	protected static readonly int INOAMIGBGAF = AnimatorParameterCache.p_AxRight;

	protected static readonly int CIFIKMODHOL = AnimatorParameterCache.p_Mine;

	protected static readonly int HPHEJJIDKGC = AnimatorParameterCache.p_Till;

	protected static readonly int OLACPCKIHPJ = AnimatorParameterCache.p_SickleDown;

	protected static readonly int IGDIKHMJPOB = AnimatorParameterCache.p_SickleUp;

	protected static readonly int NDKFGHBHKPF = AnimatorParameterCache.p_Watering;

	protected static readonly int KPGDDDNNJAG = AnimatorParameterCache.p_StartInteracting;

	protected static readonly int KEHJMPNLDKF = AnimatorParameterCache.p_Interact;

	protected static readonly int DCNCGGDKBEE = AnimatorParameterCache.p_StartCleaning;

	protected static readonly int PKDGNMJOFJO = AnimatorParameterCache.p_Cleaning;

	protected static readonly int EHBMCHOEAMK = AnimatorParameterCache.p_SitDown;

	protected static readonly int JKIKPCDFIOF = AnimatorParameterCache.p_SitUp;

	protected static readonly int NFHOEIAJDAD = AnimatorParameterCache.p_SitRight;

	protected static readonly int DHAAAFDKGCK = AnimatorParameterCache.p_Stand;

	protected static readonly int EPIBGJEGMPF = AnimatorParameterCache.p_EatNumber;

	protected static readonly int EJHHMEBBCJB = AnimatorParameterCache.p_Shield;

	protected static readonly int MMMKEGELEED = AnimatorParameterCache.p_AimDirection;

	protected static readonly int PGPDEFAPEDJ = AnimatorParameterCache.p_Crouch;

	public virtual Direction FCGBJEIIMBC
	{
		get
		{
			return _direction;
		}
		set
		{
			if (_direction != value)
			{
				_direction = value;
				DirectionChanged?.Invoke(value);
				AIPALEPMMIE(_direction);
			}
		}
	}

	public bool CNKHDCIKHCO
	{
		get
		{
			return HFECMNIFMFI;
		}
		set
		{
			if (HFECMNIFMFI == value)
			{
				return;
			}
			HFECMNIFMFI = value;
			SetBool(HGEBKKGJONI, HFECMNIFMFI);
			if (OnlineManager.IsMasterClient())
			{
				if (this is AnimalAnimation animalAnimation)
				{
					animalAnimation.onlineAnimal.SendSetBool(HGEBKKGJONI, HFECMNIFMFI);
				}
				else if (this is CatAnimation catAnimation)
				{
					catAnimation.onlineCat.SendSetBool(HGEBKKGJONI, HFECMNIFMFI);
				}
			}
		}
	}

	public bool IGONGEODOFP
	{
		get
		{
			return MHEOAHLBGHC;
		}
		set
		{
			if (MHEOAHLBGHC != value)
			{
				MHEOAHLBGHC = value;
				SetBool(LOAACMNIKFK, MHEOAHLBGHC);
				if (OnlineManager.IsMasterClient() && this is DogAnimation dogAnimation)
				{
					dogAnimation.onlineDog.SendSetBool(LOAACMNIKFK, MHEOAHLBGHC);
				}
			}
		}
	}

	public void GAGOGFEBDCP(Direction AODONKKHPBP)
	{
		_direction = AODONKKHPBP;
		if (((Behaviour)animator).isActiveAndEnabled)
		{
			SetInt(LJOKEJOCBDI, (int)AODONKKHPBP);
		}
	}

	private IEnumerator BGCEHMINPOH(Vector2 FPJJFNBBMGM)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((Vector2)(ref FPJJFNBBMGM)).Normalize();
		FCGBJEIIMBC = Utils.LFOGGLLPPBI(FPJJFNBBMGM, FCGBJEIIMBC);
		yield return null;
	}

	public void SetDirection(Direction FCGBJEIIMBC)
	{
		AIPALEPMMIE(FCGBJEIIMBC);
		this.FCGBJEIIMBC = FCGBJEIIMBC;
	}

	public void Play(string GEGDHHIDEEF, int HLOIOAOICEG)
	{
		Play(Animator.StringToHash(GEGDHHIDEEF), HLOIOAOICEG);
	}

	public void Play(int GJKKNOKIKBJ, int HLOIOAOICEG)
	{
		if ((Object)(object)animator == (Object)null)
		{
			Debug.LogError((object)("Null animator on" + (object)((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		else if (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !HLAOENHNBMO())
		{
			animator.Play(GJKKNOKIKBJ, HLOIOAOICEG);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.OnAnimationForcePlayed(GJKKNOKIKBJ, HLOIOAOICEG);
			}
		}
	}

	private IEnumerator LMNGNGMPHHC(Vector2 FPJJFNBBMGM)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		yield return null;
		((Vector2)(ref FPJJFNBBMGM)).Normalize();
		FCGBJEIIMBC = Utils.LFOGGLLPPBI(FPJJFNBBMGM, FCGBJEIIMBC);
	}

	public void FNNOPPKCKFK(Vector2 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(LMNGNGMPHHC(IMOBLFMHKOD - new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y)));
	}

	public void ForceDirection(Direction AODONKKHPBP)
	{
		_direction = AODONKKHPBP;
		if (((Behaviour)animator).isActiveAndEnabled)
		{
			SetInt(LJOKEJOCBDI, (int)AODONKKHPBP);
		}
	}

	public void SetBool(int GJKKNOKIKBJ, bool EGFGNGJGBOP, bool HALNIEBONKH = false)
	{
		if ((HALNIEBONKH || (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !HLAOENHNBMO())) && MPMHINJPBEO(GJKKNOKIKBJ, (AnimatorControllerParameterType)4))
		{
			animator.SetBool(GJKKNOKIKBJ, EGFGNGJGBOP);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.OnBoolChanged(GJKKNOKIKBJ, EGFGNGJGBOP);
			}
		}
	}

	public AnimatorStateInfo GetCurrentState(int HLOIOAOICEG)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return animator.GetCurrentAnimatorStateInfo(HLOIOAOICEG);
	}

	private IEnumerator LMNGNGMPHHC(Direction HEPJMMGKENJ)
	{
		yield return null;
		FCGBJEIIMBC = HEPJMMGKENJ;
	}

	public void LookAtSelectedNotDelay(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 currentFocusedInputElementPosition = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElementPosition();
		LookAtNotDelay(Vector2.op_Implicit(currentFocusedInputElementPosition));
	}

	private bool MPMHINJPBEO(int GJBMKMKKKAB, AnimatorControllerParameterType CLBBNKJOHIF)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return true;
		}
		if ((Object)(object)animator == (Object)null)
		{
			Debug.LogError((object)"Animator is null or has been destroyed.", (Object)(object)((Component)this).gameObject);
			return false;
		}
		for (int i = 0; i < animator.parameterCount; i++)
		{
			if (animator.GetParameter(i).nameHash != GJBMKMKKKAB)
			{
				continue;
			}
			if (animator.GetParameter(i).type != CLBBNKJOHIF)
			{
				if (Application.isEditor)
				{
					Debug.LogWarning((object)$"Trying to assign the {animator.GetParameter(i).type} parameter {animator.GetParameter(i).name} with the incorrect type ({CLBBNKJOHIF}) on {((Object)((Component)this).gameObject).name}.", (Object)(object)((Component)this).gameObject);
				}
				return false;
			}
			return true;
		}
		if (Application.isEditor)
		{
			Debug.LogWarning((object)$"Parameter {AnimatorParameterCache.KCHHBMCOBJG(animator, GJBMKMKKKAB)} not found on animator: {animator}", (Object)(object)((Component)this).gameObject);
		}
		return false;
	}

	protected void AIPALEPMMIE(Direction FCGBJEIIMBC)
	{
		SetInt(LJOKEJOCBDI, (int)FCGBJEIIMBC, HALNIEBONKH: true);
	}

	public void SetFloat(string GEGDHHIDEEF, float EGFGNGJGBOP)
	{
		SetFloat(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP);
	}

	public bool GetBool(int GJKKNOKIKBJ)
	{
		return animator.GetBool(GJKKNOKIKBJ);
	}

	public void LookAt(Vector2 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(LMNGNGMPHHC(IMOBLFMHKOD - new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y)));
	}

	public void LookDirection(Vector2 MPLCIAKAPGL)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Direction direction = Utils.EIDFHLPBICI(((Vector2)(ref MPLCIAKAPGL)).normalized);
		if (FCGBJEIIMBC != direction)
		{
			((MonoBehaviour)this).StartCoroutine(LMNGNGMPHHC(direction));
		}
	}

	public void SetFloat(int GJKKNOKIKBJ, float EGFGNGJGBOP)
	{
		if (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !HLAOENHNBMO() && MPMHINJPBEO(GJKKNOKIKBJ, (AnimatorControllerParameterType)1))
		{
			animator.SetFloat(GJKKNOKIKBJ, EGFGNGJGBOP);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.OnFloatChanged(GJKKNOKIKBJ, EGFGNGJGBOP);
			}
		}
	}

	public void CGEADHOLHCH(string GEGDHHIDEEF, bool EGFGNGJGBOP, bool HALNIEBONKH = false)
	{
		SetBool(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, HALNIEBONKH);
	}

	public void SetInt(string GEGDHHIDEEF, int EGFGNGJGBOP, bool HALNIEBONKH = false)
	{
		SetInt(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, HALNIEBONKH);
	}

	public void LookAtObject(GameObject MEGPBGODLIL, bool MAPFDGCKBLD = true)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			return;
		}
		Vector2 val = Vector2.op_Implicit(MEGPBGODLIL.transform.position);
		if ((Object)(object)MEGPBGODLIL.transform.parent != (Object)null)
		{
			SurfaceSortOrder component = ((Component)MEGPBGODLIL.transform.parent).GetComponent<SurfaceSortOrder>();
			if ((Object)(object)component != (Object)null && component.height > 0f)
			{
				((Vector2)(ref val))._002Ector(val.x, val.y - component.height);
			}
		}
		if (MAPFDGCKBLD)
		{
			LookAt(val);
		}
		else
		{
			LookAtNotDelay(val);
		}
	}

	[SpecialName]
	public bool LHGMJFGOHFD()
	{
		return HFECMNIFMFI;
	}

	public void SetTrigger(int GJKKNOKIKBJ, bool HALNIEBONKH = false)
	{
		if ((HALNIEBONKH || (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !HLAOENHNBMO())) && MPMHINJPBEO(GJKKNOKIKBJ, (AnimatorControllerParameterType)9))
		{
			animator.SetTrigger(GJKKNOKIKBJ);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.OnTriggerChanged(GJKKNOKIKBJ);
			}
		}
	}

	public void LookDirection(Direction HEPJMMGKENJ)
	{
		if (FCGBJEIIMBC != HEPJMMGKENJ && ((Component)this).gameObject.activeSelf)
		{
			((MonoBehaviour)this).StartCoroutine(LMNGNGMPHHC(HEPJMMGKENJ));
		}
	}

	public void SetBool(string GEGDHHIDEEF, bool EGFGNGJGBOP, bool HALNIEBONKH = false)
	{
		SetBool(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, HALNIEBONKH);
	}

	public void LookAtSelected(int JIIGOACEIKL)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 currentFocusedInputElementPosition = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElementPosition();
		LookAt(Vector2.op_Implicit(currentFocusedInputElementPosition));
	}

	public void SetBoolWithDelay(string GEGDHHIDEEF, bool EGFGNGJGBOP, float FLHBPHPKIML, bool HALNIEBONKH = false)
	{
		((MonoBehaviour)this).StartCoroutine(CCIAFIPAJNO(GEGDHHIDEEF, EGFGNGJGBOP, FLHBPHPKIML, HALNIEBONKH));
	}

	private bool FHGOOPJKOHF(int GJBMKMKKKAB, AnimatorControllerParameterType CLBBNKJOHIF)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (!Application.isEditor)
		{
			return true;
		}
		if ((Object)(object)animator == (Object)null)
		{
			Debug.LogError((object)"`", (Object)(object)((Component)this).gameObject);
			return false;
		}
		for (int i = 0; i < animator.parameterCount; i++)
		{
			if (animator.GetParameter(i).nameHash != GJBMKMKKKAB)
			{
				continue;
			}
			if (animator.GetParameter(i).type != CLBBNKJOHIF)
			{
				if (Application.isEditor)
				{
					object[] array = new object[1];
					array[0] = animator.GetParameter(i).type;
					array[1] = animator.GetParameter(i).name;
					array[7] = CLBBNKJOHIF;
					array[1] = ((Object)((Component)this).gameObject).name;
					Debug.LogWarning((object)string.Format("Dialogue System/Conversation/Gass_Quest/Entry/20/Dialogue Text", array), (Object)(object)((Component)this).gameObject);
				}
				return true;
			}
			return true;
		}
		if (Application.isEditor)
		{
			Debug.LogWarning((object)string.Format("Coming soon!", AnimatorParameterCache.ICAIHPCIEBH(animator, GJBMKMKKKAB), animator), (Object)(object)((Component)this).gameObject);
		}
		return false;
	}

	private IEnumerator CCIAFIPAJNO(string GEGDHHIDEEF, bool EGFGNGJGBOP, float FLHBPHPKIML, bool HALNIEBONKH = false)
	{
		yield return (object)new WaitForSeconds(FLHBPHPKIML);
		SetBool(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP, HALNIEBONKH);
	}

	public void FEJFMBPBJGA(Vector2 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(LMNGNGMPHHC(IMOBLFMHKOD - new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y)));
	}

	[SpecialName]
	public virtual void NCAJNNHBHJM(Direction AODONKKHPBP)
	{
		if (_direction != AODONKKHPBP)
		{
			_direction = AODONKKHPBP;
			DirectionChanged?.Invoke(AODONKKHPBP);
			AIPALEPMMIE(_direction);
		}
	}

	public void MMODGEOPAEB(GameObject MEGPBGODLIL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			return;
		}
		Collider2D[] components = MEGPBGODLIL.GetComponents<Collider2D>();
		Vector2 val = Vector2.op_Implicit(MEGPBGODLIL.transform.position);
		for (int i = 1; i < components.Length; i += 0)
		{
			if (!components[i].isTrigger)
			{
				Bounds bounds = components[i].bounds;
				val = Vector2.op_Implicit(((Bounds)(ref bounds)).center);
				break;
			}
		}
		if ((Object)(object)MEGPBGODLIL.transform.parent != (Object)null)
		{
			SurfaceSortOrder component = ((Component)MEGPBGODLIL.transform.parent).GetComponent<SurfaceSortOrder>();
			if ((Object)(object)component != (Object)null && component.height > 392f)
			{
				((Vector2)(ref val))._002Ector(val.x, val.y - component.height);
			}
		}
		FEJFMBPBJGA(val);
	}

	public void SetTrigger(string GEGDHHIDEEF, bool HALNIEBONKH = false)
	{
		SetTrigger(Animator.StringToHash(GEGDHHIDEEF), HALNIEBONKH);
	}

	public IEnumerator BEPNHOPPFBJ(Direction FCGBJEIIMBC)
	{
		yield return CommonReferences.wait02;
		this.FCGBJEIIMBC = FCGBJEIIMBC;
	}

	public void CAMCJAMPAEN(string GEGDHHIDEEF, float EGFGNGJGBOP)
	{
		SetFloat(Animator.StringToHash(GEGDHHIDEEF), EGFGNGJGBOP);
	}

	public void DGJJGINNOOH(GameObject MEGPBGODLIL, bool MAPFDGCKBLD = true)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			return;
		}
		Vector2 val = Vector2.op_Implicit(MEGPBGODLIL.transform.position);
		if ((Object)(object)MEGPBGODLIL.transform.parent != (Object)null)
		{
			SurfaceSortOrder component = ((Component)MEGPBGODLIL.transform.parent).GetComponent<SurfaceSortOrder>();
			if ((Object)(object)component != (Object)null && component.height > 1496f)
			{
				((Vector2)(ref val))._002Ector(val.x, val.y - component.height);
			}
		}
		if (MAPFDGCKBLD)
		{
			FNNOPPKCKFK(val);
		}
		else
		{
			LookAtNotDelay(val);
		}
	}

	public bool JEJPKGILEDB(string GEGDHHIDEEF)
	{
		return animator.GetBool(GEGDHHIDEEF);
	}

	public void LookAtNotDelay(Vector2 IMOBLFMHKOD)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(BGCEHMINPOH(IMOBLFMHKOD - new Vector2(((Component)this).transform.position.x, ((Component)this).transform.position.y)));
	}

	public IEnumerator SetDirectionWithDelay(Direction FCGBJEIIMBC)
	{
		yield return CommonReferences.wait02;
		this.FCGBJEIIMBC = FCGBJEIIMBC;
	}

	public void IDNHDBIKNKP(int GJKKNOKIKBJ, bool HALNIEBONKH = false)
	{
		if ((HALNIEBONKH || (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !HLAOENHNBMO())) && FHGOOPJKOHF(GJKKNOKIKBJ, (AnimatorControllerParameterType)(-16)))
		{
			animator.SetTrigger(GJKKNOKIKBJ);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.HPIGAKGMLDH(GJKKNOKIKBJ);
			}
		}
	}

	private bool HLAOENHNBMO()
	{
		if (OnlineManager.PlayingOnline() && clientIgnoresAnimation)
		{
			if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
			{
				return !((MonoBehaviourPun)this).photonView.IsMine;
			}
			return false;
		}
		return false;
	}

	public AnimatorStateInfo IBPGIGLEEFK(int HLOIOAOICEG)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return animator.GetCurrentAnimatorStateInfo(HLOIOAOICEG);
	}

	private IEnumerator MBELAHPPAJI(Direction HEPJMMGKENJ)
	{
		yield return null;
		FCGBJEIIMBC = HEPJMMGKENJ;
	}

	public virtual void SetInt(int GJKKNOKIKBJ, int EGFGNGJGBOP, bool HALNIEBONKH = false)
	{
		if ((HALNIEBONKH || (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !HLAOENHNBMO())) && MPMHINJPBEO(GJKKNOKIKBJ, (AnimatorControllerParameterType)3))
		{
			animator.SetInteger(GJKKNOKIKBJ, EGFGNGJGBOP);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.OnIntegerChanged(GJKKNOKIKBJ, EGFGNGJGBOP);
			}
		}
	}

	public bool GetBool(string GEGDHHIDEEF)
	{
		return animator.GetBool(GEGDHHIDEEF);
	}

	[SpecialName]
	public void IHHBOLPDMCJ(bool AODONKKHPBP)
	{
		if (HFECMNIFMFI == AODONKKHPBP)
		{
			return;
		}
		HFECMNIFMFI = AODONKKHPBP;
		SetBool(HGEBKKGJONI, HFECMNIFMFI, HALNIEBONKH: true);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			if (this is AnimalAnimation animalAnimation)
			{
				animalAnimation.onlineAnimal.SendSetBool(HGEBKKGJONI, HFECMNIFMFI);
			}
			else if (this is CatAnimation catAnimation)
			{
				catAnimation.onlineCat.MAEHKKPKGNM(HGEBKKGJONI, HFECMNIFMFI);
			}
		}
	}

	public void LookDirectionByAngle(Vector2 CDMIEECEEGM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Direction direction = Utils.LFOGGLLPPBI(((Vector2)(ref CDMIEECEEGM)).normalized, FCGBJEIIMBC);
		if (FCGBJEIIMBC != direction)
		{
			((MonoBehaviour)this).StartCoroutine(LMNGNGMPHHC(direction));
		}
	}

	public void FHOAPHBOOAH(int GJKKNOKIKBJ, bool HALNIEBONKH = false)
	{
		if ((HALNIEBONKH || (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !PELFLMHDPDD())) && MPMHINJPBEO(GJKKNOKIKBJ, (AnimatorControllerParameterType)13))
		{
			animator.SetTrigger(GJKKNOKIKBJ);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.HPIGAKGMLDH(GJKKNOKIKBJ);
			}
		}
	}

	private bool PELFLMHDPDD()
	{
		if (OnlineManager.PlayingOnline() && clientIgnoresAnimation)
		{
			if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
			{
				return !((MonoBehaviourPun)this).photonView.IsMine;
			}
			return false;
		}
		return false;
	}

	public void LookAtCenterCollider(GameObject MEGPBGODLIL)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MEGPBGODLIL == (Object)null)
		{
			return;
		}
		Collider2D[] components = MEGPBGODLIL.GetComponents<Collider2D>();
		Vector2 val = Vector2.op_Implicit(MEGPBGODLIL.transform.position);
		for (int i = 0; i < components.Length; i++)
		{
			if (!components[i].isTrigger)
			{
				Bounds bounds = components[i].bounds;
				val = Vector2.op_Implicit(((Bounds)(ref bounds)).center);
				break;
			}
		}
		if ((Object)(object)MEGPBGODLIL.transform.parent != (Object)null)
		{
			SurfaceSortOrder component = ((Component)MEGPBGODLIL.transform.parent).GetComponent<SurfaceSortOrder>();
			if ((Object)(object)component != (Object)null && component.height > 0f)
			{
				((Vector2)(ref val))._002Ector(val.x, val.y - component.height);
			}
		}
		LookAt(val);
	}

	public void BIJAFGBMBPJ(int GJKKNOKIKBJ, float EGFGNGJGBOP)
	{
		if (((Component)animator).gameObject.activeSelf && ((Behaviour)animator).enabled && ((Behaviour)animator).isActiveAndEnabled && !PELFLMHDPDD() && MPMHINJPBEO(GJKKNOKIKBJ, (AnimatorControllerParameterType)1))
		{
			animator.SetFloat(GJKKNOKIKBJ, EGFGNGJGBOP);
			if ((Object)(object)onlineCharacterAnim != (Object)null)
			{
				onlineCharacterAnim.ICPPDAHGGLO(GJKKNOKIKBJ, EGFGNGJGBOP);
			}
		}
	}
}
