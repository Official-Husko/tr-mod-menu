using UnityEngine;

public class BuzzAnimation : CharacterAnimBase
{
	public SpriteRenderer buzzSprite;

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
			if (Object.op_Implicit((Object)(object)buzzSprite))
			{
				if (FCGBJEIIMBC == Direction.Left)
				{
					((Component)buzzSprite).transform.localScale = new Vector3(-1f, 1f, 1f);
				}
				else
				{
					((Component)buzzSprite).transform.localScale = new Vector3(1f, 1f, 1f);
				}
			}
		}
	}

	private void NEOICNJNKNL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FKIEEDDAGKG()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1838f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JAPFDIEHKPI()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1758f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OGEJKOIOKAN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JDHHJKBOJML()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GECHJIGBPEN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MGMJCAKILCO()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1470f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HCCJBKKGCLJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1334f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void Awake()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CIICEKEJANM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void ALEAOANPHIO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CLNBMOPMNOF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FJIJNLKJGKC()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1859f)
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

	private void KHONOODGLBI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BGBFJPJLPMF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BABJAGOPCOA()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1592f)
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

	private void DPOHEFNJFKK()
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
		if (((Vector3)(ref val)).sqrMagnitude > 281f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = true;
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

	private void KDHLJKMKFMG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MMNBJPDJHGK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void IGNLHLAAMMN()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1882f)
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

	private void NMKGOAJLMDG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KPPIKBFOIFB()
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
		if (((Vector3)(ref val)).sqrMagnitude > 334f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HEDGGNKENPB()
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
		if (((Vector3)(ref val)).sqrMagnitude > 823f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void COKBJNMAMDI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EIOFKDODGKK()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1642f)
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

	private void HDDBJBECDPP()
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
		if (((Vector3)(ref val)).sqrMagnitude > 700f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OBJHHNMMCGF()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1129f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DKDLOBOLNFH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void IGNEGEOPLOP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HEMAHKJEONA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 490f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GMCKBBECJOE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KIGPIILBDAC()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1475f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void NNMGIHNNKED()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1267f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GOJKOBEEMNA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EENAJABELBJ()
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
		if (((Vector3)(ref val)).sqrMagnitude > 935f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HDNHNMJHOJM()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1181f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GONDLJKGLGO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KAOLCOJBFCE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 727f)
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

	private void EIHMDMMOPCM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void LBLJPOEPOMH()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1999f)
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

	private void EIMIDCDEIDD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FALKANGNMJI()
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
		if (((Vector3)(ref val)).sqrMagnitude > 58f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BODICIENBEH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1008f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void EMJKKALMGLK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MPLHFJGFKJD()
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
		if (((Vector3)(ref val)).sqrMagnitude > 106f)
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

	private void GEEPFKHHKDD()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1549f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BAKDKFKNHDE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void AAEAAEBBFKG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 323f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void MDKNIJCHHCE()
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
		if (((Vector3)(ref val)).sqrMagnitude > 734f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PODKNIMOACM()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1002f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void NLGHNDLPPKI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OMBHDODDHNO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JDMMNLKLMAA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void IBMDFNKKPJF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void JMCJFCPCDKL()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1310f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OCJOAHDNDIJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DADPOICMNPI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OCBPECIEPMI()
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
		if (((Vector3)(ref val)).sqrMagnitude > 34f)
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

	private void DHJOHHEMMFK()
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
		if (((Vector3)(ref val)).sqrMagnitude > 343f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			base.CNKHDCIKHCO = false;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PCPNEJOIKAN()
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
		if (((Vector3)(ref val)).sqrMagnitude > 757f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void CEOEHODJAJK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GNOBDKFFPOL()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void GFLFDLIMOLI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
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
		if (((Vector3)(ref val)).sqrMagnitude > 1803f)
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

	private void DNKEFFMOCKP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void ODJPLNDJKEA()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1152f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = false;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: true);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void OOBDKJHKPEP()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1799f)
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

	private void GAEDNJMJDJD()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1575f)
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

	private void BOKOLOCCLEN()
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
		if (((Vector3)(ref val)).sqrMagnitude > 239f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void DNBGIIGAKMJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HKOFLOPDCEJ()
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
		if (((Vector3)(ref val)).sqrMagnitude > 813f)
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

	private void GBIDNAGBLBF()
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
		if (((Vector3)(ref val)).sqrMagnitude > 177f)
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

	private void ADJMGPNBDGF()
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
		if (((Vector3)(ref val)).sqrMagnitude > 1358f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void KHCJDKHONPK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PIHGEBONAOI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HPJBLOPJIMI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void FBFAGHMJAJD()
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
		if (((Vector3)(ref val)).sqrMagnitude > 783f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void ADHFFJDEBMK()
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
		if (((Vector3)(ref val)).sqrMagnitude > 532f)
		{
			NCAJNNHBHJM(Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC));
			base.CNKHDCIKHCO = true;
		}
		else
		{
			base.CNKHDCIKHCO = true;
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void HINEHDJIPGP()
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
		if (((Vector3)(ref val)).sqrMagnitude > 572f)
		{
			FCGBJEIIMBC = Utils.LFOGGLLPPBI(Vector2.op_Implicit(val), FCGBJEIIMBC);
			base.CNKHDCIKHCO = true;
		}
		else
		{
			IHHBOLPDMCJ(AODONKKHPBP: false);
		}
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void BNFGHAGJEGG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}

	private void PCKOHAIPHFI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AADMIOHCEEB = ((Component)this).transform.position;
	}
}
