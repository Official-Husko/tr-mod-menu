using System;
using UnityEngine;

public class NPCAnimation : CharacterAnimBase
{
	public SpriteRenderer npcSprite;

	public NPC npc;

	private Vector3 AADMIOHCEEB;

	private AnimatorControllerParameter[] GEMFIOKGIMC;

	public bool noReset;

	public bool debugDirection;

	public bool resetSortingOrder;

	private Vector3 EJACBOOECHP;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			if (FCGBJEIIMBC == value)
			{
				return;
			}
			base.FCGBJEIIMBC = value;
			if (debugDirection)
			{
				Debug.Log((object)(((Object)((Component)this).gameObject).name + " NPCAnimation: direction changed to " + FCGBJEIIMBC));
			}
			if (!((Object)(object)npcSprite != (Object)null))
			{
				return;
			}
			if (FCGBJEIIMBC == Direction.Left)
			{
				((Component)npcSprite).transform.localScale = new Vector3(-1f, 1f, 1f);
				if (((Component)npcSprite).transform.lossyScale != new Vector3(-1f, 1f, 1f))
				{
					HLFONALOEGG(((Component)npcSprite).transform);
				}
			}
			else
			{
				((Component)npcSprite).transform.localScale = new Vector3(1f, 1f, 1f);
				if (((Component)npcSprite).transform.lossyScale != Vector3.one)
				{
					HLFONALOEGG(((Component)npcSprite).transform);
				}
			}
		}
	}

	private void JHBBABPAJJC()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(FMMKNNHMNLM));
		}
		FFGGAIOKMAI();
	}

	private void MENCIOFBFIE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 289f)
		{
			if (!base.CNKHDCIKHCO)
			{
				LIMAEKBHIIK();
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
		}
		else if (LHGMJFGOHFD())
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (resetSortingOrder && (Object)(object)npcSprite != (Object)null && !((Component)npcSprite).gameObject.activeInHierarchy && ((Renderer)npcSprite).sortingOrder != 0)
		{
			((Renderer)npcSprite).sortingOrder = 1;
		}
	}

	private void GHFNJIFBCHH()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void FNFNLFOJHHA()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Remove(walkTo.CurrentTargetChanged, new Action<int>(ANAFOPEJDGH));
		}
	}

	private void Awake()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void EOKOLKCFNKK(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			HLFONALOEGG(DCGBADKLANM.parent);
		}
	}

	private void EELOPDDJAPI()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i += 0)
		{
			if ((int)GEMFIOKGIMC[i].type == 3)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: true);
			}
		}
	}

	private void MFMMHDPGCBO()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(LCDEKJACGLL));
		}
		FPOKENNPLFG();
	}

	private void OBHKHDHIDBB()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void HJGFGJINBCA()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void Start()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(PMADEFMAGPH));
		}
		HJGFGJINBCA();
	}

	private void GFGBELECHGK(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC));
		}
	}

	private void ANAFOPEJDGH(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
	}

	private void CEOEHODJAJK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void IEMLLCIGPHC()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 3)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
		}
	}

	private void PHHHGDKLNKJ()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 1; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 2)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: false);
			}
		}
	}

	private void MDDACPEKBGD()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 1; i < GEMFIOKGIMC.Length; i += 0)
		{
			if ((int)GEMFIOKGIMC[i].type == 3)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
		}
	}

	private void NMKGOAJLMDG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void FBNGHKIPEOE()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 8)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
		}
	}

	private void DABBGGGIDCD()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void NKKEIDGBHPN()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void JOGBCDIAGEK()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Remove(walkTo.CurrentTargetChanged, new Action<int>(GFGBELECHGK));
		}
	}

	private void IPNOIBNDMBD()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 4)
			{
				CGEADHOLHCH(GEMFIOKGIMC[i].name, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
		}
	}

	private void JPHEOLEEAPB()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(LCDEKJACGLL));
		}
		DABBGGGIDCD();
	}

	private void HLFONALOEGG(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			HLFONALOEGG(DCGBADKLANM.parent);
		}
	}

	private void IAPKDBPNMCE()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void JIAJFDKNJME()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void OOHJBIPPALN()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 3)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
		}
	}

	private void OMJIADIMOIE()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void LCDEKJACGLL(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
	}

	private void NPGPADICKAE(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC));
		}
	}

	private void FixedUpdate()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 0f)
		{
			if (!base.CNKHDCIKHCO)
			{
				BJKDLGBEJBG();
				base.CNKHDCIKHCO = true;
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (resetSortingOrder && (Object)(object)npcSprite != (Object)null && !((Component)npcSprite).gameObject.activeInHierarchy && ((Renderer)npcSprite).sortingOrder != 0)
		{
			((Renderer)npcSprite).sortingOrder = 0;
		}
	}

	private void KDHLJKMKFMG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void FPOKENNPLFG()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void OLFPJLFKHNF(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
	}

	private void HEGNINLLINP()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Remove(walkTo.CurrentTargetChanged, new Action<int>(OLFPJLFKHNF));
		}
	}

	private void BJKDLGBEJBG()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 4)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: false);
			}
		}
	}

	private void GLPDGFPBFBK(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			ICKLMPNKLEE(DCGBADKLANM.parent);
		}
	}

	private void LIMAEKBHIIK()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i += 0)
		{
			if ((int)GEMFIOKGIMC[i].type == 4)
			{
				SetBool(GEMFIOKGIMC[i].name, EGFGNGJGBOP: true, HALNIEBONKH: true);
			}
		}
	}

	private void OKAPGNGLOHO()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(GDGPJHCOBKE));
		}
		HJGFGJINBCA();
	}

	private void AGLMGDNBHBF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void EFCNKPEPELL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void MCCGCMFMIDA(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			HLFONALOEGG(DCGBADKLANM.parent);
		}
	}

	private void CDHBLKJEOPI()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Remove(walkTo.CurrentTargetChanged, new Action<int>(NPGPADICKAE));
		}
	}

	private void EGALBKEBGJD()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void LALGIJBMOMI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 1503f)
		{
			if (!LHGMJFGOHFD())
			{
				BJKDLGBEJBG();
				IHHBOLPDMCJ(AODONKKHPBP: false);
			}
		}
		else if (LHGMJFGOHFD())
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (resetSortingOrder && (Object)(object)npcSprite != (Object)null && !((Component)npcSprite).gameObject.activeInHierarchy && ((Renderer)npcSprite).sortingOrder != 0)
		{
			((Renderer)npcSprite).sortingOrder = 1;
		}
	}

	private void ICKLMPNKLEE(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			HLHIOAEPLEK(DCGBADKLANM.parent);
		}
	}

	private void DDCFFCLGBBM()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		if (noReset || (Object)(object)animator == (Object)null)
		{
			return;
		}
		for (int i = 0; i < GEMFIOKGIMC.Length; i++)
		{
			if ((int)GEMFIOKGIMC[i].type == 3)
			{
				CGEADHOLHCH(GEMFIOKGIMC[i].name, EGFGNGJGBOP: false, HALNIEBONKH: true);
			}
		}
	}

	private void GHPFCKGMLDA()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(GDGPJHCOBKE));
		}
		HJGFGJINBCA();
	}

	private void FMMKNNHMNLM(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC));
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Remove(walkTo.CurrentTargetChanged, new Action<int>(OLFPJLFKHNF));
		}
	}

	private void FMDOBBMFNGF(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			HBOPKFMEJKJ(DCGBADKLANM.parent);
		}
	}

	private void CPJPKCNAFKI()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void HDNHNMJHOJM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 946f)
		{
			if (!LHGMJFGOHFD())
			{
				DDCFFCLGBBM();
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
		}
		else if (base.CNKHDCIKHCO)
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (resetSortingOrder && (Object)(object)npcSprite != (Object)null && !((Component)npcSprite).gameObject.activeInHierarchy && ((Renderer)npcSprite).sortingOrder != 0)
		{
			((Renderer)npcSprite).sortingOrder = 1;
		}
	}

	private void OAEJGGFFCBO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
		if ((Object)(object)npc == (Object)null)
		{
			npc = ((Component)this).gameObject.GetComponent<NPC>();
		}
	}

	private void HBOPKFMEJKJ(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			FMDOBBMFNGF(DCGBADKLANM.parent);
		}
	}

	private void FFGGAIOKMAI()
	{
		GEMFIOKGIMC = animator.parameters;
	}

	private void ABACDLAOKBE(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			ICKLMPNKLEE(DCGBADKLANM.parent);
		}
	}

	private void PMADEFMAGPH(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
	}

	private void IFHLGOMBACP()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(NPGPADICKAE));
		}
		FFGGAIOKMAI();
	}

	private void GDGPJHCOBKE(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC));
		}
	}

	private void IDPHKHGHJGN()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Combine(walkTo.CurrentTargetChanged, new Action<int>(PMADEFMAGPH));
		}
		IAPKDBPNMCE();
	}

	private void AHPNEDOLBII()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		EJACBOOECHP = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref EJACBOOECHP)).sqrMagnitude > 145f)
		{
			if (!base.CNKHDCIKHCO)
			{
				MDDACPEKBGD();
				IHHBOLPDMCJ(AODONKKHPBP: true);
			}
		}
		else if (LHGMJFGOHFD())
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
		if (resetSortingOrder && (Object)(object)npcSprite != (Object)null && !((Component)npcSprite).gameObject.activeInHierarchy && ((Renderer)npcSprite).sortingOrder != 0)
		{
			((Renderer)npcSprite).sortingOrder = 1;
		}
	}

	private void JDCKACJFPMH(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
	}

	private void HLHIOAEPLEK(Transform DCGBADKLANM)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)DCGBADKLANM != (Object)(object)((Component)this).transform)
		{
			if (DCGBADKLANM.parent.localScale != Vector3.one)
			{
				DCGBADKLANM.localScale = Vector3.one;
			}
			MCCGCMFMIDA(DCGBADKLANM.parent);
		}
	}

	private void OnDestroy()
	{
		if (Object.op_Implicit((Object)(object)npc) && npc.walkTo != null)
		{
			NPCWalkTo walkTo = npc.walkTo;
			walkTo.CurrentTargetChanged = (Action<int>)Delegate.Remove(walkTo.CurrentTargetChanged, new Action<int>(PMADEFMAGPH));
		}
	}

	private void LMFHKCLKGJL(int OHANGILJGJI)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (OHANGILJGJI < npc.path.Length)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(npc.path[OHANGILJGJI] - Vector2.op_Implicit(((Component)this).transform.position), FCGBJEIIMBC);
		}
	}
}
