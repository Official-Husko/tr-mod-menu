using UnityEngine;

public class GassAnimation : CharacterAnimBase
{
	public SpriteRenderer gassSprite;

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
			if (Object.op_Implicit((Object)(object)gassSprite))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)gassSprite).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)gassSprite).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
		}
	}

	public void EDPPCEBPLMH()
	{
		SetTrigger("Wage");
		FCGBJEIIMBC = Direction.Up;
	}

	private void Awake()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void GEDCKBLDAFG()
	{
		SetTrigger("Mop");
		NCAJNNHBHJM(Direction.Down);
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
		if (((Vector3)(ref val)).sqrMagnitude > 730f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MJENOBKFPIN()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1976f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JDMMNLKLMAA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OGFKFGAMGCE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 482f)
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

	public void HKBACCPFJFF()
	{
		SetTrigger("", HALNIEBONKH: true);
		NCAJNNHBHJM(Direction.Up);
	}

	private void JIAJFDKNJME()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void LDAJDPGICED()
	{
		SetTrigger("Object ");
		NCAJNNHBHJM(Direction.Up);
	}

	public void KCEKJEOKHIG()
	{
		SetTrigger("Winter");
		FCGBJEIIMBC = Direction.Down;
	}

	private void JMLDAJEFMPE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1277f)
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

	private void PMLHDLPJPDG()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1492f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GONDLJKGLGO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void FOKICCNEFDM()
	{
		SetTrigger("hForHours", HALNIEBONKH: true);
		NCAJNNHBHJM(Direction.Up);
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
		if (((Vector3)(ref val)).sqrMagnitude > 1453f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	public void Struggle()
	{
		SetTrigger("Struggle");
		FCGBJEIIMBC = Direction.Down;
	}

	public void MGCAOHFOELI()
	{
		SetTrigger("Cannot place mine block piece at ", HALNIEBONKH: true);
		FCGBJEIIMBC = Direction.Down;
	}

	public void NPODAOACKCD()
	{
		SetTrigger("itemCaramelWort", HALNIEBONKH: true);
		FCGBJEIIMBC = Direction.Down;
	}

	private void OGEJKOIOKAN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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

	public void MIPIKEHIKFN()
	{
		SetTrigger("Region check failed", HALNIEBONKH: true);
		NCAJNNHBHJM(Direction.Down);
	}

	private void KDHLJKMKFMG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MOEJIBLELHP()
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
		if (((Vector3)(ref val)).sqrMagnitude > 498f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KHONOODGLBI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}
}
