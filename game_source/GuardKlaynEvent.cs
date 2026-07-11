using System;
using UnityEngine;

public class GuardKlaynEvent : NPC
{
	public Vector3 targetWalkTo;

	public bool destroy;

	public Direction endWalkDirection = Direction.Diagonal;

	private bool LCHBIEAICAK;

	public void HFCKHCAJHAK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		walkTo.GHDMBFOAAHK(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PBMBOPDALGD));
		walkTo.PEHELKCIECB();
	}

	public void JMLDAJEFMPE()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = true;
		}
	}

	private void KACEOJDPLKB()
	{
		HFCKHCAJHAK();
	}

	private void PBMBOPDALGD()
	{
		PHCNLDCGHHB();
	}

	private void GNGADDPBJDC()
	{
		HFCKHCAJHAK();
	}

	private void KJMDNKCJFEF()
	{
		KMFHAHKJHJP();
	}

	private void Start()
	{
		StartWalking();
	}

	public void PHCNLDCGHHB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		walkTo.GLHBJNDMIDC(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CKGFIHKADBM));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EILPPGGCANE));
		walkTo.PEHELKCIECB();
	}

	private void FOBPMBDMGBL()
	{
		PHCNLDCGHHB();
	}

	public void HILLNFIICFK()
	{
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
		}
		if (destroy)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public void NLOEGNNLKKE()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.PLAGPJAKCKL())
		{
			LCHBIEAICAK = false;
		}
	}

	private void HBMDEHPHAPF()
	{
		HFCKHCAJHAK();
	}

	private void EILPPGGCANE()
	{
		JLAHJOOAKID();
	}

	private void BHKLMNJGLFN()
	{
		DAOFIMMNEKO();
	}

	private void HKGKJCOKLLD()
	{
		FICLGDADLPC();
	}

	public void FixedUpdate()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.IIMEFNIECLI())
		{
			LCHBIEAICAK = true;
		}
	}

	private void PLHEHGHFCJI()
	{
		StartWalking();
	}

	public void JLAHJOOAKID()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		walkTo.BDIKOLNFKGD(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: true, NGAKHGJANLO: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HILLNFIICFK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BHKLMNJGLFN));
		walkTo.PEHELKCIECB();
	}

	public void FICLGDADLPC()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		walkTo.HELOLJBENMK(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HILLNFIICFK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PBMBOPDALGD));
		walkTo.NOFKEMGPFEO();
	}

	public void KPPIKBFOIFB()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = false;
		}
	}

	public void StartWalking()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		walkTo.FNNPPBDFBCI(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.PEHELKCIECB();
	}

	private void ALBMMJPBAGA()
	{
		PHCNLDCGHHB();
	}

	private void AHECKLFEFAB()
	{
		FICLGDADLPC();
	}

	private void ACOJHBFFFIF()
	{
		StartWalking();
	}

	private void NKDFMFFDGKC()
	{
		DAOFIMMNEKO();
	}

	private void LHEHNNJGINH()
	{
		StartWalking();
	}

	private void DCKKIDMJKJM()
	{
		DAOFIMMNEKO();
	}

	private void CCHENCELDDJ()
	{
		DAOFIMMNEKO();
	}

	public void AGLDNOHPHFD()
	{
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (destroy)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public void FGJPOPCBFNE()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.PAHDHACALOH())
		{
			LCHBIEAICAK = true;
		}
	}

	private void HMCGBJCGGEF()
	{
		PHCNLDCGHHB();
	}

	public void EEPKGNNILBE()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.PAHDHACALOH())
		{
			LCHBIEAICAK = false;
		}
	}

	private void IBIHOAPEONB()
	{
		HFCKHCAJHAK();
	}

	public void DAOFIMMNEKO()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		walkTo.KBEENHPEOAB(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EILPPGGCANE));
		walkTo.EHDKLBLKBEO();
	}

	public void CKGFIHKADBM()
	{
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Right;
		}
		if (destroy)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public void MJENOBKFPIN()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = false;
		}
	}

	public void OnActionComplete()
	{
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (destroy)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	private void BDJKNKIOPIJ()
	{
		FICLGDADLPC();
	}

	public void KMFHAHKJHJP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = true;
		walkTo.DBHOIIIHIIM(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HILLNFIICFK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HMCGBJCGGEF));
		walkTo.NOFKEMGPFEO();
	}

	public void ADHFFJDEBMK()
	{
		if (!LCHBIEAICAK && walkTo != null && walkTo.GOACFCOOJLK(OEBNHGNJEJL: true))
		{
			LCHBIEAICAK = true;
		}
	}

	public void BFGPMEKLDDB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LCHBIEAICAK = false;
		walkTo.GINPKMBGOFN(Vector2.op_Implicit(targetWalkTo), AHDHLIECIGH: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HILLNFIICFK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PBMBOPDALGD));
		walkTo.PEHELKCIECB();
	}
}
