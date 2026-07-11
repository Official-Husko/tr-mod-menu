using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenericNPC : NPC
{
	public float runSpeed = 2.5f;

	public SpriteRenderer spriteRenderer;

	public Coroutine waitToWalkCoroutine;

	public Animator behaviour;

	public GenericNPCAnimation npcAnimation;

	[HideInInspector]
	public GenericNPCStateBase currentNpcState;

	[HideInInspector]
	public int walkingAgainCount;

	public SimpleAnimationController simpleAnimController;

	public float nextWalkMin;

	public float nextWalkMax;

	private GameObject MOBFJEDPIPM;

	private void AFGJLAACCFN()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JKPKLNDEEGH));
		}
		else
		{
			PPICAMAGNME();
		}
		MACNHBILJBI();
	}

	private void EPHDHKDCNOD()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void CNHEMKHJPPN()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.LECGKEIILJN();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.ENLIEKGPJFL();
		}
	}

	private void HAADHLKPCKD()
	{
		HJCOAJEIABK();
	}

	[CompilerGenerated]
	private void HABAPNHHIJB()
	{
		CPFDLKMCBCB();
	}

	public void KAOLCOJBFCE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.MPNHDBOKKNL();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.MIMMDBGIHOF();
		}
	}

	public void ICBHCBGAONN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void GHBEMCOFHOC()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.DILIFDDMNJH();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.MGJCODFFCPM();
		}
	}

	private void KCOFAJBKHAO()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JKPKLNDEEGH));
		}
		else
		{
			PPICAMAGNME();
		}
		MACNHBILJBI();
	}

	public void JAKECGMLHJN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void EIIOKKFJHBE()
	{
		PPICAMAGNME();
	}

	public void FDPNIIKHKJP()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void BKMEJIGMCGM()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void EEPKGNNILBE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.IKKEDPGDGKG();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.CDHOCKDFHKG();
		}
	}

	private void CDGIANNBMKH()
	{
		ENPJHFLIALN();
	}

	public void JBABHOJPFPG()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.DILIFDDMNJH();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.FBHOKLGAHFL();
		}
	}

	private void NMPFHHEFOPH()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HAADHLKPCKD));
		}
		else
		{
			ENPJHFLIALN();
		}
		ICBHCBGAONN();
	}

	private void OCDECHJNNCD()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void IMOMHCNPCEC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void KLAKFLIHPNN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void HMKNDADIBBN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void KPPIKBFOIFB()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.LECGKEIILJN();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.CEJDIMGHOMI();
		}
	}

	public void OBJHHNMMCGF()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ANJBKPCBBIC();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.LMNJABLGPLL();
		}
	}

	public void ODJPLNDJKEA()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.GBAGMNGMENB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.IDKPCPNLKME();
		}
	}

	public void NCAKMJPLBHK()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void ANLPGPDGNFF()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.NFINBPJFMJK();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.IDKPCPNLKME();
		}
	}

	private void KPOAGLEJGNG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void ICBCMLAIIPF()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KAFAGGBEGPP));
		}
		else
		{
			JEMFMIHMAOI();
		}
		HOGBHJLDIPL();
	}

	private void FIJOLHBICNO()
	{
		JEMFMIHMAOI();
	}

	public void PODKNIMOACM()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ADIFBKLICLD();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.LMNJABLGPLL();
		}
	}

	private void DDIBFALLCNO()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void MAIMGNMIFKG()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NLKIGCGBDMJ));
		}
		else
		{
			PPICAMAGNME();
		}
		BKHGLCBEIPJ();
	}

	private void NDEIAEBBJCE()
	{
		PPICAMAGNME();
	}

	public void NODDNBFDJGO()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ILEFMEIHCKD();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.ENLIEKGPJFL();
		}
	}

	public void BKHGLCBEIPJ()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void JEKMCOEJKJI()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void JJDEGMGCOCC()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(AMLFOKHAMDD));
		}
		else
		{
			ENPJHFLIALN();
		}
		KLAKFLIHPNN();
	}

	private void IJFOIDPHIDG()
	{
		PPICAMAGNME();
	}

	public void FBNHGAOGDJE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.NOPLHMEDIHI();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.FLNJGJLNGKM();
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void MHLHJGHHONF()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FKKFHGMACAM));
		}
		else
		{
			HJCOAJEIABK();
		}
		HMKNDADIBBN();
	}

	private void GBMGCDEJMNC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void AFHDJFJBHCH()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void HJKONJICGML()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(BDMKLDJOGOC));
		}
		else
		{
			CPFDLKMCBCB();
		}
		ICBHCBGAONN();
	}

	public void MACNHBILJBI()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void NBBEGDEBLGD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.HOJKMDMDEMD();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.BICNNAGCIPA();
		}
	}

	private void HCKMHIHALBL()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(CLFJJDMANME));
		}
		else
		{
			CPFDLKMCBCB();
		}
		GLEEFLPBKBE();
	}

	private void EHIGEHGJPJD()
	{
		PPICAMAGNME();
	}

	private void KAIEENEPOKN()
	{
		PPICAMAGNME();
	}

	private void NELLIBBABJD()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	protected override void CPFDLKMCBCB()
	{
		currentNpcState = null;
		base.CPFDLKMCBCB();
	}

	public void GLEEFLPBKBE()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void PPHIIEILOGP()
	{
		CPFDLKMCBCB();
	}

	private void MEFFGGKAALB()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(AMLFOKHAMDD));
		}
		else
		{
			CPFDLKMCBCB();
		}
		BKHGLCBEIPJ();
	}

	private void LCFEBDPNANP()
	{
		PLIFJBMCANA();
	}

	private void MKGKKAJHLAO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void BONEKIAPEIK()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void LPKHACNBCLA()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FIJOLHBICNO));
		}
		else
		{
			PPICAMAGNME();
		}
		GLEEFLPBKBE();
	}

	public void FDFOBDGPNLH()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void AMLFOKHAMDD()
	{
		PLIFJBMCANA();
	}

	private void FMLIINGHHBO()
	{
		CPFDLKMCBCB();
	}

	private void IMAIIBGEGGC()
	{
		CPFDLKMCBCB();
	}

	private void PJOAFKEIPPD()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HAADHLKPCKD));
		}
		else
		{
			ENPJHFLIALN();
		}
		HOGBHJLDIPL();
	}

	public void WalkAround()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void CHDGJHNBNEJ()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void GAEDNJMJDJD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ADIFBKLICLD();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.CEJDIMGHOMI();
		}
	}

	private void CIIBBCPIOIP()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IJFOIDPHIDG));
		}
		else
		{
			ENPJHFLIALN();
		}
		MACNHBILJBI();
	}

	private void CLFJJDMANME()
	{
		PPICAMAGNME();
	}

	public void LAJOCEHPGBP()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.GBAGMNGMENB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.APBMBLLOGFO();
		}
	}

	private void ILACBNHLMGG()
	{
		HJCOAJEIABK();
	}

	public void NNMEEOKBILL()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	public void FixedUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.DPFMOKIDPMB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.TriggerAnimation();
		}
	}

	private void NLFCKFOHPKK()
	{
		ENPJHFLIALN();
	}

	private void EDBOBLNOBLP()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void CLJBKGOGBII()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.NFINBPJFMJK();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.FLNJGJLNGKM();
		}
	}

	private void FKKFHGMACAM()
	{
		PLIFJBMCANA();
	}

	private void MDONEOEDCAM()
	{
		PPICAMAGNME();
	}

	private void NLKIGCGBDMJ()
	{
		JEMFMIHMAOI();
	}

	private void AECMHPBLPNP()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	private void PIDEIIIJLKF()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IJFOIDPHIDG));
		}
		else
		{
			JEMFMIHMAOI();
		}
		NCAKMJPLBHK();
	}

	public void GBIDNAGBLBF()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.OCMBMFFODCH();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.MIMMDBGIHOF();
		}
	}

	public void NCHPGNANPGN()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void LEPDLPEPEFD()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FMLIINGHHBO));
		}
		else
		{
			HJCOAJEIABK();
		}
		HOGBHJLDIPL();
	}

	private void GFPIEOPHABO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void ECHMKEAGFFO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	private void BDMKLDJOGOC()
	{
		CPFDLKMCBCB();
	}

	private void POFIEEODEJO()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(FIJOLHBICNO));
		}
		else
		{
			PPICAMAGNME();
		}
		HOGBHJLDIPL();
	}

	public void HOGBHJLDIPL()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void OnEnable()
	{
		if (OnlineManager.ClientOnline())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, (Action)delegate
			{
				CPFDLKMCBCB();
			});
		}
		else
		{
			CPFDLKMCBCB();
		}
		WalkAround();
	}

	public void NLOEGNNLKKE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.PMAGFLOBEJH();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.FLNJGJLNGKM();
		}
	}

	public void JGIPAEGHKCH()
	{
		behaviour.SetTrigger(NPC.AEOKENCHHPL);
	}

	private void CGMFOICEDNJ()
	{
		ENPJHFLIALN();
	}

	public void EPCLMDOCGKC()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.LECGKEIILJN();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.HGFLKAHDCPG();
		}
	}

	public void OPNJDLOBDEA()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.NFINBPJFMJK();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.NILCCHFGIBM();
		}
	}

	public void EENAJABELBJ()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.DILIFDDMNJH();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.FBHOKLGAHFL();
		}
	}

	private void KAFAGGBEGPP()
	{
		CPFDLKMCBCB();
	}

	private void JKPKLNDEEGH()
	{
		PLIFJBMCANA();
	}

	private void AHCPFICKFHA()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			_ = GameManager.isLoading;
		}
	}

	public void DGDCMLPELHD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.GBAGMNGMENB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.HHLHGCOLABP();
		}
	}

	private void AEMPCMILANL()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(AMLFOKHAMDD));
		}
		else
		{
			CPFDLKMCBCB();
		}
		FDFOBDGPNLH();
	}

	public void OOBDKJHKPEP()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.DPFMOKIDPMB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.NILCCHFGIBM();
		}
	}

	public void OGFKFGAMGCE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ILEFMEIHCKD();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.ADECGNNPINE();
		}
	}

	private void PCNALDJDIFM()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			_ = GameManager.isLoading;
		}
	}

	public void FGJPOPCBFNE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.GBAGMNGMENB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.ENLIEKGPJFL();
		}
	}

	public void PFNIPILPGFN()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ADIFBKLICLD();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.LMNJABLGPLL();
		}
	}

	private void JAKCNHCCOLE()
	{
		PLIFJBMCANA();
	}

	private void KDLDOHFKMBA()
	{
		PPICAMAGNME();
	}

	private void OHIMJBJOGHI()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IMAIIBGEGGC));
		}
		else
		{
			PLIFJBMCANA();
		}
		FDFOBDGPNLH();
	}

	public void AHPNEDOLBII()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.ANJBKPCBBIC();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.IDKPCPNLKME();
		}
	}

	public void MENCIOFBFIE()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)MOBFJEDPIPM != (Object)null)
		{
			MOBFJEDPIPM.transform.position = ((Component)this).transform.position;
		}
		if (Object.op_Implicit((Object)(object)currentNpcState))
		{
			currentNpcState.DPFMOKIDPMB();
		}
		if (walkTo.complete && Time.time > simpleAnimController.nextAnimationTime)
		{
			simpleAnimController.MGJCODFFCPM();
		}
	}
}
