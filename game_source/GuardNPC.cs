using System;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class GuardNPC : DialogueNPCBase
{
	public GameObject[] walkPoints;

	[SerializeField]
	private bool walkingDone;

	private float CMCNEIOHFHL;

	[SerializeField]
	private Vector2 nextWalkRange = new Vector2(2f, 10f);

	[ConversationPopup(false)]
	public string bark = string.Empty;

	public float minBarkTime;

	public float maxBarkTime;

	private float AELCMIGFOAK;

	private void BGENEAOILOF()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNJODLOADKA));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KFKJLMOFPMO));
		if (OnlineManager.PGAGDFAEEFB())
		{
			OABPINLGOGK();
		}
	}

	public void HKIEDFHDAJD()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.JJDCANFBFMK(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position));
			walkTo.speed = speed;
			walkTo.NOFKEMGPFEO();
		}
	}

	public void EPCLMDOCGKC()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.BODEPFFAHLE())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				NHFGBBBCJNM();
			}
		}
	}

	private void CEIIFHIBIFI()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EELNLGMEIDL));
		if (OnlineManager.MasterOrOffline())
		{
			NLHMBBCEJKD();
		}
	}

	private void LFBMFAHPBIM()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	private void MFMMHDPGCBO()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GMCINBCEPJO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EELNLGMEIDL));
		if (OnlineManager.MasterOrOffline())
		{
			BFGPMEKLDDB();
		}
	}

	public void AJJIICECMDO()
	{
		CMCNEIOHFHL = Time.time + Random.Range(285f, 1923f);
	}

	private void FOBPMBDMGBL()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			ABDHBPEMFOO();
		}
	}

	public void GMCINBCEPJO()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1896f, 562f);
	}

	public void NKAMNKDKLHI()
	{
		CMCNEIOHFHL = Time.time + Random.Range(296f, 1918f);
	}

	public void FOEBEJHKEKE()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1389f, 801f);
	}

	private void BPNEABGPAIB()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	public void CLOEFOFKDFC()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1064f, 1018f);
	}

	private void EGACIHOKJLH()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(JLBMCMCCDNN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LFBMFAHPBIM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			NLHMBBCEJKD();
		}
	}

	private void ICFHPJHBPDN()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CLOEFOFKDFC));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GBDAMMFCECP));
		if (OnlineManager.PGAGDFAEEFB())
		{
			JKMFNFMKKAL();
		}
	}

	private void EIOKFNLDEEB()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	private void NBOMJAKJNIK()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			COMLEKJGHGI();
		}
	}

	private void OIAHJHNPPCO()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BEEDFJOOPAH));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JLPDGFJJNAK));
		if (OnlineManager.MasterOrOffline())
		{
			OABPINLGOGK();
		}
	}

	private void ANAHMLJAENA()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			JKMFNFMKKAL();
		}
	}

	private void CMLLBIDFNEB()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BKNBKDKIDNJ));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		if (OnlineManager.PGAGDFAEEFB())
		{
			OABPINLGOGK();
		}
	}

	public void JLBMCMCCDNN()
	{
		CMCNEIOHFHL = Time.time + Random.Range(243f, 226f);
	}

	private void DMKNBLCAJDB()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			HFIOGJGMBGM();
		}
	}

	public void DHGFHNALOAH()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = false;
			walkTo.EJPGFOEDPBG(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.PEHELKCIECB();
		}
	}

	public void JKMFNFMKKAL()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = false;
			walkTo.EJPGFOEDPBG(Vector2.op_Implicit(walkPoints[Random.Range(0, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.EHDKLBLKBEO();
		}
	}

	private void MJDFKJBFMPO()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	public void ABDHBPEMFOO()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.DHFPOCOEONG(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: false);
			walkTo.speed = speed;
			walkTo.NOFKEMGPFEO();
		}
	}

	public void CFJOGFDANJH()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.DHFPOCOEONG(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.EHDKLBLKBEO();
		}
	}

	protected override void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			base.OnDestroy();
			if (walkTo != null)
			{
				NPCWalkTo nPCWalkTo = walkTo;
				nPCWalkTo.OnActionComplete = (Action)Delegate.Remove(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
				NPCWalkTo nPCWalkTo2 = walkTo;
				nPCWalkTo2.OnFailStart = (Action)Delegate.Remove(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			}
		}
	}

	private void OOOHGHHADHB()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			JKMFNFMKKAL();
		}
	}

	public void IHEHHCLJFDK()
	{
		CMCNEIOHFHL = Time.time + Random.Range(710f, 941f);
	}

	public void DFBPHAJIPKD()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				EIOKFNLDEEB();
			}
		}
	}

	private void ODNGBEOKEFK()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(MMHIOJMIJMP));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ANAHMLJAENA));
		if (OnlineManager.PGAGDFAEEFB())
		{
			DNIPBIPJKLJ();
		}
	}

	public void KBCKFDDDEGE()
	{
		CMCNEIOHFHL = Time.time + Random.Range(418f, 914f);
	}

	public void FixedUpdate()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.IIMEFNIECLI())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				ACOJHBFFFIF();
			}
		}
	}

	public void DCLMGAKHJDP()
	{
		CMCNEIOHFHL = Time.time + Random.Range(337f, 1230f);
	}

	private void ACOJHBFFFIF()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			StartWalking();
		}
	}

	private void DLDNJAGCJOA()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			COMLEKJGHGI();
		}
	}

	public void FALKANGNMJI()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				FOBPMBDMGBL();
			}
		}
	}

	protected override void Awake()
	{
		base.Awake();
		AELCMIGFOAK = Random.Range(minBarkTime, maxBarkTime) + Time.time;
	}

	public void FEHGALEDJKI()
	{
		CMCNEIOHFHL = Time.time + Random.Range(239f, 906f);
	}

	private void FPDPAJHNGHK()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PKCODIDOBJO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AHNEAEKDBED));
		if (OnlineManager.PGAGDFAEEFB())
		{
			DHGFHNALOAH();
		}
	}

	private void AEEANHACPGH()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			CFJOGFDANJH();
		}
	}

	public void GFLNGGGPGCF()
	{
		CMCNEIOHFHL = Time.time + Random.Range(434f, 191f);
	}

	public void FGJPOPCBFNE()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.IIMEFNIECLI(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				EIOKFNLDEEB();
			}
		}
	}

	public void HFIOGJGMBGM()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.HELOLJBENMK(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.EHDKLBLKBEO();
		}
	}

	private void CAHIIFMAAEA()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			COMLEKJGHGI();
		}
	}

	public void JMLDAJEFMPE()
	{
		if (!OnlineManager.HHDBMDMFEMP() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.IIMEFNIECLI(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				DMKNBLCAJDB();
			}
		}
	}

	public void NABJFOADAND()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.KBEENHPEOAB(Vector2.op_Implicit(walkPoints[Random.Range(0, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.EHDKLBLKBEO();
		}
	}

	private void IAAGKLPMAMK()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNKIODOAHPN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NHFGBBBCJNM));
		if (OnlineManager.PGAGDFAEEFB())
		{
			StartWalking();
		}
	}

	public void LEDKBJOFJCM()
	{
		CMCNEIOHFHL = Time.time + Random.Range(283f, 421f);
	}

	public void DNIPBIPJKLJ()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.JDHMPOJKOLF(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.PEHELKCIECB();
		}
	}

	public void JMCJFCPCDKL()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.PAHDHACALOH())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				DLDNJAGCJOA();
			}
		}
	}

	public void NLHMBBCEJKD()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = false;
			walkTo.OGLJDLEGJAA(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: false);
			walkTo.speed = speed;
			walkTo.NOFKEMGPFEO();
		}
	}

	private void FOMDNPODHLG()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			JKMFNFMKKAL();
		}
	}

	private void GJMOKBGIBEP()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			DHGFHNALOAH();
		}
	}

	public void CMJJFJFDNED()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.GOACFCOOJLK())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				FLFPPMPBPCK();
			}
		}
	}

	public void ACFMEGDHELN()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.GOACFCOOJLK())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				OOOHGHHADHB();
			}
		}
	}

	public void PKCODIDOBJO()
	{
		CMCNEIOHFHL = Time.time + Random.Range(472f, 1919f);
	}

	private void EELNLGMEIDL()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	public void DPOHEFNJFKK()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.PAHDHACALOH(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				JAHKKNGPCJO();
			}
		}
	}

	private void AHNEAEKDBED()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			BFGPMEKLDDB();
		}
	}

	public void JBABHOJPFPG()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.BODEPFFAHLE())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				ACOJHBFFFIF();
			}
		}
	}

	public void HHPANGDONBN()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.GOACFCOOJLK())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				JLPDGFJJNAK();
			}
		}
	}

	public void BKNBKDKIDNJ()
	{
		CMCNEIOHFHL = Time.time + Random.Range(914f, 534f);
	}

	public void IDBCMIMFHJC()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1563f, 254f);
	}

	public void BFGPMEKLDDB()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = false;
			walkTo.HELOLJBENMK(Vector2.op_Implicit(walkPoints[Random.Range(0, walkPoints.Length)].transform.position));
			walkTo.speed = speed;
			walkTo.PEHELKCIECB();
		}
	}

	private void CFIIEJDJFPB()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNJODLOADKA));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CJJCIBFMPKM));
		if (OnlineManager.MasterOrOffline())
		{
			COMLEKJGHGI();
		}
	}

	public void PODKNIMOACM()
	{
		if (!OnlineManager.HHDBMDMFEMP() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.PAHDHACALOH(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				NHFGBBBCJNM();
			}
		}
	}

	public void OnActionComplete()
	{
		CMCNEIOHFHL = Time.time + Random.Range(2f, 4f);
	}

	private void NHFGBBBCJNM()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			StartWalking();
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return null;
	}

	public void FJIJNLKJGKC()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.IIMEFNIECLI())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				MIFEFJBGDEP();
			}
		}
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (base.MouseUp(JIIGOACEIKL))
		{
			noPortrait = true;
			return true;
		}
		return false;
	}

	public void NHCAPCCBNAL()
	{
		CMCNEIOHFHL = Time.time + Random.Range(745f, 1319f);
	}

	private void LJLKBKEADGI()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FEHGALEDJKI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KNDLFHILBMA));
		if (OnlineManager.MasterOrOffline())
		{
			JKMFNFMKKAL();
		}
	}

	public void BEEDFJOOPAH()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1219f, 1691f);
	}

	private void CJJCIBFMPKM()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			DNIPBIPJKLJ();
		}
	}

	private void BGFCHEIOKOG()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DCLMGAKHJDP));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DMKNBLCAJDB));
		if (OnlineManager.PGAGDFAEEFB())
		{
			StartWalking();
		}
	}

	private void Start()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		if (OnlineManager.MasterOrOffline())
		{
			StartWalking();
		}
	}

	private void BKKEBAFPNIA()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			NABJFOADAND();
		}
	}

	private void JAHKKNGPCJO()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			JKMFNFMKKAL();
		}
	}

	private void JLPDGFJJNAK()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	private void KNDLFHILBMA()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			CFJOGFDANJH();
		}
	}

	private void BOOBKGLCDFK()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			BFGPMEKLDDB();
		}
	}

	private void NNFPNFNFCJJ()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			StartWalking();
		}
	}

	protected override void Update()
	{
		base.Update();
		if (inUse)
		{
			walkTo.JKGGEMBAPAJ();
			walkingDone = true;
		}
	}

	private void FLFPPMPBPCK()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			StartWalking();
		}
	}

	private void MIFEFJBGDEP()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			CFJOGFDANJH();
		}
	}

	private void GBDAMMFCECP()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			BFGPMEKLDDB();
		}
	}

	public void FNKIODOAHPN()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1869f, 706f);
	}

	private void HBMDEHPHAPF()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GFLNGGGPGCF));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GBDAMMFCECP));
		if (OnlineManager.PGAGDFAEEFB())
		{
			HKIEDFHDAJD();
		}
	}

	private void INACOMEAINH()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			OABPINLGOGK();
		}
	}

	private void DKMIGLDKNIO()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			HKIEDFHDAJD();
		}
	}

	public void DGDCMLPELHD()
	{
		if (!OnlineManager.HHDBMDMFEMP() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.BODEPFFAHLE(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				OOOHGHHADHB();
			}
		}
	}

	private void EACIGGOOKGD()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KBCKFDDDEGE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DKMIGLDKNIO));
		if (OnlineManager.PGAGDFAEEFB())
		{
			DNIPBIPJKLJ();
		}
	}

	private void KFKJLMOFPMO()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			BFGPMEKLDDB();
		}
	}

	private void EHNACEHHOJK()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			HKIEDFHDAJD();
		}
	}

	private void EOGHJNGJFID()
	{
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(LEDKBJOFJCM));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KNDLFHILBMA));
		if (OnlineManager.MasterOrOffline())
		{
			OABPINLGOGK();
		}
	}

	public void MMHIOJMIJMP()
	{
		CMCNEIOHFHL = Time.time + Random.Range(1973f, 978f);
	}

	public void COMLEKJGHGI()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = false;
			walkTo.CGFMBJFGLAG(Vector2.op_Implicit(walkPoints[Random.Range(1, walkPoints.Length)].transform.position), AHDHLIECIGH: false);
			walkTo.speed = speed;
			walkTo.PEHELKCIECB();
		}
	}

	public void MGMJCAKILCO()
	{
		if (!OnlineManager.ClientOnline() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				FOBPMBDMGBL();
			}
		}
	}

	public void FNJODLOADKA()
	{
		CMCNEIOHFHL = Time.time + Random.Range(510f, 1165f);
	}

	public void LAJOCEHPGBP()
	{
		if (!OnlineManager.HHDBMDMFEMP() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.PAHDHACALOH(OEBNHGNJEJL: true))
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = false;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				INACOMEAINH();
			}
		}
	}

	public void CLJBKGOGBII()
	{
		if (!OnlineManager.HHDBMDMFEMP() && !inUse && walkPoints.Length != 0)
		{
			if (!walkingDone && walkTo.PAHDHACALOH())
			{
				CMCNEIOHFHL = Time.fixedTime + Random.Range(nextWalkRange.x, nextWalkRange.y);
				walkingDone = true;
			}
			if (walkingDone && Time.fixedTime > CMCNEIOHFHL)
			{
				ACOJHBFFFIF();
			}
		}
	}

	private void DKDBFNCODIK()
	{
		if ((Object)(object)((Component)this).gameObject != (Object)null)
		{
			BFGPMEKLDDB();
		}
	}

	public void StartWalking()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = false;
			walkTo.FNNPPBDFBCI(Vector2.op_Implicit(walkPoints[Random.Range(0, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.PEHELKCIECB();
		}
	}

	public void OABPINLGOGK()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (walkPoints.Length != 0)
		{
			walkingDone = true;
			walkTo.OGLJDLEGJAA(Vector2.op_Implicit(walkPoints[Random.Range(0, walkPoints.Length)].transform.position), AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			walkTo.PEHELKCIECB();
		}
	}
}
