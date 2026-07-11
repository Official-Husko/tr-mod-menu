using UnityEngine;
using UnityEngine.UI;

public class CatAnimation : CharacterAnimBase
{
	public CatAnimator catAnimator;

	public bool jumpBed;

	public bool onBed;

	[SerializeField]
	private SpriteRenderer spriteRenderer;

	public Image image;

	private float HMIHFFAEOJE = 4f;

	private float PEENKPODJDC;

	private int KECDIFBCMKI;

	private int PCENIFEHBCK = 99;

	private Vector3 AADMIOHCEEB;

	public OnlineCat onlineCat;

	private Vector3 EJACBOOECHP;

	public static readonly int p_Move = AnimatorParameterCache.p_Move;

	public static readonly int p_Sleeping = AnimatorParameterCache.p_Sleeping;

	public static readonly int p_Eating = AnimatorParameterCache.p_Eating;

	public static readonly int p_LickPaw = AnimatorParameterCache.p_LickPaw;

	public static readonly int p_Yawn = AnimatorParameterCache.p_Yawn;

	public static readonly int p_WagTail = AnimatorParameterCache.p_WagTail;

	public static readonly int p_BendEar = AnimatorParameterCache.p_BendEar;

	public static readonly int p_Sit = AnimatorParameterCache.p_Sit;

	public static readonly int p_Lick = AnimatorParameterCache.p_Lick;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			if (FCGBJEIIMBC == value)
			{
				return;
			}
			base.FCGBJEIIMBC = value;
			if (Object.op_Implicit((Object)(object)spriteRenderer))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)spriteRenderer).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
			if ((Object)(object)onlineCat != (Object)null && OnlineManager.IsMasterClient())
			{
				onlineCat.SendDirection(value);
			}
		}
	}

	public void EGFDKJKOCNB()
	{
		Sound.BNBMNOMFFBE().FCGICGODFFA(Sound.BNBMNOMFFBE().stepsWood[1], HOMFPAFAOGD: false, null, null, 50f, 1340f);
	}

	public void KODJONHDFCH()
	{
		IDNHDBIKNKP(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_Sit);
		}
	}

	public void OGGAAIDGNEJ()
	{
		SetTrigger(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_Sit);
		}
	}

	public void CLDNEDLBGBG()
	{
		FHOAPHBOOAH(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_LickPaw);
		}
	}

	private void PODKNIMOACM()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 897f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!LHGMJFGOHFD())
			{
				SetTrigger(p_Move, HALNIEBONKH: true);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Move);
				}
			}
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 7);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 2);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(50, 6);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void DPNLOMOMEIF()
	{
		FHOAPHBOOAH(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_Sit);
		}
	}

	private void FixedUpdate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 0f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			if (!base.CNKHDCIKHCO)
			{
				SetTrigger(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Move);
				}
			}
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 5);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 5);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-2, 2);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void MPFEFMHLKNN()
	{
		Sound.MAIDHAPANEB().PlayOneShot(Sound.MAIDHAPANEB().stepsWood[0], HOMFPAFAOGD: false, null, null, 1968f, 1494f);
	}

	private void JMLDAJEFMPE()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 821f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!base.CNKHDCIKHCO)
			{
				FHOAPHBOOAH(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Move);
				}
			}
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 4);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 5);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-22, 7);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void AEPMJLPOGJJ()
	{
		Sound.BNBMNOMFFBE().PlayOneShot(Sound.GGFJGHHHEJC.stepsWood[0], HOMFPAFAOGD: true, null, null, 740f, 501f);
	}

	public void PDFJFCOIOOG()
	{
		FHOAPHBOOAH(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_LickPaw);
		}
	}

	public void EDLBHJILMND()
	{
		Sound.OKAPNFPFPFP().INPNDHPDFNC(Sound.OKAPNFPFPFP().stepsWood[0], HOMFPAFAOGD: false, null, null, 535f, 1909f);
	}

	public void FMKGAHECOEH(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.EPEAPNLFEKG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void DNKEFFMOCKP()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		FCGBJEIIMBC = Direction.Left;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void PAJPCCGFOLA()
	{
		IDNHDBIKNKP(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_Sit);
		}
	}

	public void LAHKHPNINLE(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void GJMANDDAJDI()
	{
		IDNHDBIKNKP(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_Sit);
		}
	}

	public void HJIBPAMAJAC()
	{
		Sound.DIHCEGINELM().FDEMPPFKAFK(Sound.DIHCEGINELM().stepsGrass[0], HOMFPAFAOGD: false, null, null, 35f, 1236f);
	}

	public void NEILMHMJCGC(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void OANKBAMLGLP(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MAEHKKPKGNM(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void MIAPCLBDOGO()
	{
		Sound.ABDJJBFNLBJ().FCGICGODFFA(Sound.OKAPNFPFPFP().stepsWood[1], HOMFPAFAOGD: false, null, null, 1610f, 1100f);
	}

	public void Sleep(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void GNDOEHOCFKD()
	{
		IDNHDBIKNKP(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_Sit);
		}
	}

	public void MAHPOMAKMGL()
	{
		Sound.MAIDHAPANEB().FDEMPPFKAFK(Sound.MAIDHAPANEB().stepsGrass[1], HOMFPAFAOGD: true, null, null, 585f, 1594f);
	}

	public void KKKENOHILMC()
	{
		IDNHDBIKNKP(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_Sit);
		}
	}

	public void FCGBFLKCAPL()
	{
		Sound.OKAPNFPFPFP().MGMGHPCIBEK(Sound.DIHCEGINELM().stepsWood[0], HOMFPAFAOGD: false, null, null, 1295f, 1155f);
	}

	public void BFDPNDOHFGE(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.DIOBAMEOLAG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void OOBDKJHKPEP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1899f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!LHGMJFGOHFD())
			{
				IDNHDBIKNKP(p_Move, HALNIEBONKH: true);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Move);
				}
			}
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 0);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 7);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-63, 2);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	private void KJPECNGCOKK()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM((Direction)6);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OAEJGGFFCBO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM((Direction)6);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DGBJJNAADCI()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		FCGBJEIIMBC = (Direction)8;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void AJBANIHNLEJ()
	{
		Sound.ABDJJBFNLBJ().PlayOneShot(Sound.MAIDHAPANEB().stepsGrass[0], HOMFPAFAOGD: true, null, null, 1495f, 1691f);
	}

	private void DADPOICMNPI()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM(Direction.Left);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void LJJEJCOFNGE(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MAEHKKPKGNM(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void IGNEGEOPLOP()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM((Direction)6);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JDFJGJCFDLE()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1501f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!LHGMJFGOHFD())
			{
				SetTrigger(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 7);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 7);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-73, 0);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void PLLJKILNLHJ()
	{
		FHOAPHBOOAH(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_LickPaw);
		}
	}

	public void JFAGCNDGPDP()
	{
		SetTrigger(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_LickPaw);
		}
	}

	public void PKCHKNLEDKD()
	{
		Sound.ABDJJBFNLBJ().GFMCBGEFEOK(Sound.OKAPNFPFPFP().stepsGrass[0], HOMFPAFAOGD: false, null, null, 1978f, 1764f);
	}

	public void AFOIMNILLLC(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.EPEAPNLFEKG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void BJHHINLHBBM()
	{
		SetTrigger(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_LickPaw);
		}
	}

	public void PAHBCCADHGK(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void LALGIJBMOMI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 60f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!base.CNKHDCIKHCO)
			{
				SetTrigger(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 6);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 2);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(21, 5);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void ELHDDGNGFCE()
	{
		Sound.BNBMNOMFFBE().MGMGHPCIBEK(Sound.ABDJJBFNLBJ().stepsGrass[0], HOMFPAFAOGD: false, null, null, 703f, 1335f);
	}

	private void IBMDFNKKPJF()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		FCGBJEIIMBC = (Direction)8;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void CPMPLKOBFOL()
	{
		Sound.BNBMNOMFFBE().HLLDGLLLNJF(Sound.GGFJGHHHEJC.stepsWood[1], HOMFPAFAOGD: false, null, null, 868f, 1723f);
	}

	private void NNMGIHNNKED()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 370f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			if (!base.CNKHDCIKHCO)
			{
				FHOAPHBOOAH(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 5);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 4);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(35, 4);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void AJPCKBLHAKH()
	{
		FHOAPHBOOAH(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_Sit);
		}
	}

	public void MEOMHHKDKPJ()
	{
		Sound.GGFJGHHHEJC.FCGICGODFFA(Sound.ABDJJBFNLBJ().stepsGrass[0], HOMFPAFAOGD: false, null, null, 628f, 216f);
	}

	private void HINGECEDJAP()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM(Direction.Up);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void LDFNGHOOLFH()
	{
		Sound.GGFJGHHHEJC.FCGICGODFFA(Sound.ABDJJBFNLBJ().stepsWood[1], HOMFPAFAOGD: true, null, null, 750f, 1036f);
	}

	public void FPIOAKFJMAD()
	{
		SetTrigger(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_Sit);
		}
	}

	public void IIALEBKFDPC()
	{
		IDNHDBIKNKP(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_LickPaw);
		}
	}

	public void PAKIOMKDPOJ(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.EPEAPNLFEKG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void JBLFGLGIJGO()
	{
		SetTrigger(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_Sit);
		}
	}

	public void LMIGHJFKFIH()
	{
		SetTrigger(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_Sit);
		}
	}

	public void LickPaw()
	{
		SetTrigger(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_LickPaw);
		}
	}

	public void DHJJPJOAEPE(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.DIOBAMEOLAG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void LandSound()
	{
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.stepsGrass[0]);
	}

	private void FKCOPHFELKD()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 932f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!base.CNKHDCIKHCO)
			{
				SetTrigger(p_Move, HALNIEBONKH: true);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 5);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 0);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-8, 3);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void MGBDIEKPFMA()
	{
		IDNHDBIKNKP(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_LickPaw);
		}
	}

	public void ICPBFHJKLLO()
	{
		Sound.GGFJGHHHEJC.HLLDGLLLNJF(Sound.ABDJJBFNLBJ().stepsGrass[1], HOMFPAFAOGD: false, null, null, 1087f, 1582f);
	}

	public void HMPBOOIMJBH()
	{
		Sound.DIHCEGINELM().MGMGHPCIBEK(Sound.ABDJJBFNLBJ().stepsWood[1], HOMFPAFAOGD: true, null, null, 1085f, 1392f);
	}

	private void JDHHJKBOJML()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM((Direction)7);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void NJKDHLPGPFJ()
	{
		Sound.MAIDHAPANEB().PlayOneShot(Sound.DIHCEGINELM().stepsWood[0], HOMFPAFAOGD: true, null, null, 994f, 1867f);
	}

	public void FJFNMEOEDGH()
	{
		Sound.DIHCEGINELM().INPNDHPDFNC(Sound.DIHCEGINELM().stepsWood[1], HOMFPAFAOGD: false, null, null, 41f, 492f);
	}

	public void PMOCCOLKHCB(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.DIOBAMEOLAG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void MMGKKBKGJNG()
	{
		Sound.ABDJJBFNLBJ().FCGICGODFFA(Sound.ABDJJBFNLBJ().stepsWood[0], HOMFPAFAOGD: false, null, null, 443f, 103f);
	}

	private void NODDNBFDJGO()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1620f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!LHGMJFGOHFD())
			{
				SetTrigger(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Move);
				}
			}
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 0);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 3);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(22, 0);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void JKJBFFAPOOP()
	{
		Sound.ABDJJBFNLBJ().HLLDGLLLNJF(Sound.BNBMNOMFFBE().stepsGrass[0], HOMFPAFAOGD: true, null, null, 1652f, 1585f);
	}

	private void FOJJKOJBHEI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 335f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			if (!LHGMJFGOHFD())
			{
				IDNHDBIKNKP(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 1);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 5);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-83, 8);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void EPDNLEPJJHL()
	{
		Sound.DIHCEGINELM().FCGICGODFFA(Sound.GGFJGHHHEJC.stepsWood[1], HOMFPAFAOGD: false, null, null, 14f, 562f);
	}

	public void JNJLFCHDAMD()
	{
		SetTrigger(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_Sit);
		}
	}

	public void DFOJEEALJOE()
	{
		Sound.OKAPNFPFPFP().HLLDGLLLNJF(Sound.GGFJGHHHEJC.stepsWood[0], HOMFPAFAOGD: true, null, null, 1121f, 938f);
	}

	private void FDCPJNLLNGN()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1702f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			if (!base.CNKHDCIKHCO)
			{
				SetTrigger(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Move);
				}
			}
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 5);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 1);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(17, 3);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void FCFKBOBAEPA()
	{
		Sound.ABDJJBFNLBJ().FDEMPPFKAFK(Sound.DIHCEGINELM().stepsGrass[0], HOMFPAFAOGD: true, null, null, 1885f, 482f);
	}

	public void BGBBDNKAHDK(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void AJGLDLLIIFO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM(Direction.Right);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void KHHLELJMIDM()
	{
		Sound.DIHCEGINELM().GFMCBGEFEOK(Sound.BNBMNOMFFBE().stepsGrass[1], HOMFPAFAOGD: false, null, null, 405f, 1390f);
	}

	private void Awake()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		FCGBJEIIMBC = Direction.Right;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void DMOAAKGJGLC()
	{
		FHOAPHBOOAH(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_LickPaw);
		}
	}

	public void EABEIKKMJCB()
	{
		Sound.DIHCEGINELM().INPNDHPDFNC(Sound.OKAPNFPFPFP().stepsGrass[0], HOMFPAFAOGD: false, null, null, 1615f, 1261f);
	}

	public void OPFGMCKPEGN()
	{
		FHOAPHBOOAH(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_LickPaw);
		}
	}

	public void PEABIGJLDPK()
	{
		FHOAPHBOOAH(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_LickPaw);
		}
	}

	public void MCHBLCCOMKA()
	{
		FHOAPHBOOAH(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_LickPaw);
		}
	}

	public void BEKABMDKNBC()
	{
		Sound.OKAPNFPFPFP().FCGICGODFFA(Sound.OKAPNFPFPFP().stepsWood[1], HOMFPAFAOGD: false, null, null, 812f, 1681f);
	}

	public void FKPFBEKGJIM()
	{
		FHOAPHBOOAH(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_Sit);
		}
	}

	public void IDBABJFGAFA()
	{
		IDNHDBIKNKP(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_Sit);
		}
	}

	public void LPPMFIAPNIA()
	{
		SetTrigger(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_LickPaw);
		}
	}

	private void JEHIMHBBAOM()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1266f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!base.CNKHDCIKHCO)
			{
				FHOAPHBOOAH(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Move);
				}
			}
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 7);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 6);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-117, 6);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void LMKCBFEDPFM(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void BLEFGBJLCCL()
	{
		Sound.ABDJJBFNLBJ().MGMGHPCIBEK(Sound.GGFJGHHHEJC.stepsGrass[1], HOMFPAFAOGD: true, null, null, 502f, 1524f);
	}

	private void GECHJIGBPEN()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM(Direction.Diagonal);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void PIFICNKELEB(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.EPEAPNLFEKG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void GEEPFKHHKDD()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 175f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!LHGMJFGOHFD())
			{
				FHOAPHBOOAH(p_Move, HALNIEBONKH: true);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Move);
				}
			}
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 3);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 7);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(13, 3);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	private void HDDBJBECDPP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 268f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			if (!base.CNKHDCIKHCO)
			{
				IDNHDBIKNKP(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Move);
				}
			}
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(1, 8);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 7);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-58, 2);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void GLFFCKMIHLP()
	{
		Sound.DIHCEGINELM().MGMGHPCIBEK(Sound.GGFJGHHHEJC.stepsGrass[1], HOMFPAFAOGD: false, null, null, 1871f, 28f);
	}

	private void JBABHOJPFPG()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 17f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!base.CNKHDCIKHCO)
			{
				FHOAPHBOOAH(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 8);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 1);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(15, 6);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void DJKFGHFBHDK()
	{
		Sound.OKAPNFPFPFP().MGMGHPCIBEK(Sound.MAIDHAPANEB().stepsGrass[1], HOMFPAFAOGD: false, null, null, 587f, 1625f);
	}

	public void OCOOMCKOHHC()
	{
		Sound.BNBMNOMFFBE().FDEMPPFKAFK(Sound.BNBMNOMFFBE().stepsWood[1], HOMFPAFAOGD: false, null, null, 1662f, 1441f);
	}

	public void KJPHDKEOBKB()
	{
		SetTrigger(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_Sit);
		}
	}

	public void GNLBLPLGAAJ()
	{
		Sound.OKAPNFPFPFP().INPNDHPDFNC(Sound.MAIDHAPANEB().stepsGrass[1], HOMFPAFAOGD: false, null, null, 65f, 1947f);
	}

	public void HCFCJFLIPPD()
	{
		Sound.BNBMNOMFFBE().FCGICGODFFA(Sound.ABDJJBFNLBJ().stepsGrass[0], HOMFPAFAOGD: true, null, null, 883f, 660f);
	}

	public void Sit()
	{
		SetTrigger(p_Sit);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_Sit);
		}
	}

	private void AAEAAEBBFKG()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		PEENKPODJDC = Time.time + HMIHFFAEOJE;
		NCAJNNHBHJM(Direction.Left);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FALKANGNMJI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.HHDBMDMFEMP())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1404f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC));
			if (!base.CNKHDCIKHCO)
			{
				FHOAPHBOOAH(p_Move, HALNIEBONKH: true);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Move);
				}
			}
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 2);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(0, 6);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-87, 4);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void IABJLEEGKMN(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MAEHKKPKGNM(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void NHKAJFFEMPD()
	{
		SetTrigger(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.NMAILIGPACC(p_LickPaw);
		}
	}

	public void ACFHHCLEJKB(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetBool(p_Sleeping, NJHMBMGKCPL);
		}
	}

	private void KBOFHCAJELA()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1667f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(EJACBOOECHP), FCGBJEIIMBC);
			if (!LHGMJFGOHFD())
			{
				IDNHDBIKNKP(p_Move);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.SendSetTrigger(p_Move);
				}
			}
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (!GetBool(CharacterAnimBase.HGEBKKGJONI) && !GetBool(p_Sleeping) && !GetBool(p_Eating) && catAnimator.safeMovement)
		{
			if (!(Time.fixedTime >= PEENKPODJDC))
			{
				return;
			}
			KECDIFBCMKI = Random.Range(0, 4);
			while (PCENIFEHBCK == KECDIFBCMKI)
			{
				KECDIFBCMKI = Random.Range(1, 0);
			}
			PCENIFEHBCK = KECDIFBCMKI;
			switch (KECDIFBCMKI)
			{
			case 0:
				animator.SetTrigger(p_LickPaw);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_LickPaw);
				}
				break;
			case 1:
				animator.SetTrigger(p_Yawn);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.MNJGNCLHDGK(p_Yawn);
				}
				break;
			case 2:
				animator.SetTrigger(p_WagTail);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.NMAILIGPACC(p_WagTail);
				}
				break;
			case 3:
				animator.SetTrigger(p_BendEar);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_BendEar);
				}
				break;
			case 4:
				animator.SetTrigger(p_Lick);
				if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
				{
					onlineCat.BLOEANHKHEG(p_Lick);
				}
				break;
			}
			PEENKPODJDC = Time.fixedTime + HMIHFFAEOJE + (float)Random.Range(-5, 5);
		}
		else
		{
			PEENKPODJDC += Time.fixedDeltaTime;
		}
	}

	public void EMKEMHODJEB(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.DIOBAMEOLAG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void KBDPEEBNBDN()
	{
		Sound.MAIDHAPANEB().PlayOneShot(Sound.GGFJGHHHEJC.stepsGrass[0], HOMFPAFAOGD: false, null, null, 1080f, 425f);
	}

	public void NILJLINGHAF()
	{
		IDNHDBIKNKP(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.MNJGNCLHDGK(p_LickPaw);
		}
	}

	public void JumpSound()
	{
		Sound.GGFJGHHHEJC.PlayOneShot(Sound.GGFJGHHHEJC.stepsWood[0]);
	}

	public void POKJJOABFML()
	{
		IDNHDBIKNKP(p_LickPaw);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.BLOEANHKHEG(p_LickPaw);
		}
	}

	public void OJFDHOLMJEJ()
	{
		SetTrigger(p_LickPaw, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_LickPaw);
		}
	}

	public void FLMJIOABCNP(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.EPEAPNLFEKG(p_Sleeping, NJHMBMGKCPL);
		}
	}

	public void JMCPAIEIKOC()
	{
		IDNHDBIKNKP(p_Sit, HALNIEBONKH: true);
		if (OnlineManager.PlayingOnline() && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.SendSetTrigger(p_Sit);
		}
	}

	public void KIAPMFPEFJD(bool NJHMBMGKCPL, bool CDPAMNIPPEC)
	{
		animator.SetBool(p_Sleeping, NJHMBMGKCPL);
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)onlineCat != (Object)null)
		{
			onlineCat.DIOBAMEOLAG(p_Sleeping, NJHMBMGKCPL);
		}
	}
}
