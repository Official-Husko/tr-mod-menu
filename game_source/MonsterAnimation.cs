using UnityEngine;

public class MonsterAnimation : CharacterAnimBase
{
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	private Vector3 AADMIOHCEEB;

	public override Direction FCGBJEIIMBC
	{
		get
		{
			return base.FCGBJEIIMBC;
		}
		set
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
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
		}
	}

	private void ALEAOANPHIO()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NCAJNNHBHJM(Direction.Right);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FKCOPHFELKD()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 861f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GFABFDHPJOK()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 732f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CLJBKGOGBII()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 1033f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PCKOHAIPHFI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Left;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void NBNCMOAPDOG()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 889f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KDHLJKMKFMG()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = (Direction)5;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OHJIFGGCDAN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 362f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FixedUpdate()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 0f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HHPANGDONBN()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 1038f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BAKDKFKNHDE()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NCAJNNHBHJM(Direction.Right);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void NLOEGNNLKKE()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 1027f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CEOEHODJAJK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = (Direction)7;
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void AFKGJCIANOF()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - AADMIOHCEEB;
		if (((Vector3)(ref val)).sqrMagnitude > 1717f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GONDLJKGLGO()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NCAJNNHBHJM((Direction)5);
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void Awake()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FCGBJEIIMBC = Direction.Right;
		AADMIOHCEEB = ((Component)this).transform.position;
	}
}
